using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Assets.Scripts;
using Assets.Scripts.UI;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace StationpediaDump
{
    [BepInPlugin("tool.stationpediadump", "StationpediaDump", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Harmony.CreateAndPatchAll(typeof(DumpPatch));
            Logger.LogInfo("[StationpediaDump] Harmony patch applied, waiting for GameManager.StartGame...");
        }
    }

    [HarmonyPatch(typeof(GameManager), nameof(GameManager.StartGame))]
    public class DumpPatch
    {
        private static bool _done;

        public static void Postfix()
        {
            if (_done) return;
            _done = true;
            try
            {
                Dumper.DumpAll();
            }
            catch (Exception e)
            {
                Dumper.Log.LogError("[StationpediaDump] Dump failed: " + e);
            }
        }
    }

    public static class Dumper
    {
        public static readonly ManualLogSource Log = BepInEx.Logging.Logger.CreateLogSource("StationpediaDump");

        public static void DumpAll()
        {
            ForcePopulateThingPages();

            var pages = Stationpedia.StationpediaPages;
            if (pages == null)
            {
                Log.LogWarning("[StationpediaDump] StationpediaPages is null, nothing to dump.");
                return;
            }

            string outRoot = Path.GetFullPath(Path.Combine(Paths.PluginPath, "..", "..", "StationpediaDump_Output"));
            Directory.CreateDirectory(outRoot);

            // Neither PageCustomCategories (mostly empty) nor DisplayFilter
            // (a coarse Guide/Lore/everything-else UI filter, not the detailed
            // category tree) map cleanly onto the in-game category browser -
            // both were tried and produced a near-total single bucket. Content
            // is fully greppable regardless of which file it lands in, so
            // chunk alphabetically by title instead of chasing that further.
            const int ChunkSize = 100;
            var sorted = pages.OrderBy(p => DisplayTitle(p), StringComparer.OrdinalIgnoreCase).ToList();
            var chunks = new List<List<StationpediaPage>>();
            for (int i = 0; i < sorted.Count; i += ChunkSize)
                chunks.Add(sorted.Skip(i).Take(ChunkSize).ToList());

            var idx = new StringBuilder();
            idx.AppendLine("# Stationpedia Reference Library");
            idx.AppendLine();
            idx.AppendLine("Extracted directly from live game data via a BepInEx/Harmony plugin on a headless dedicated server.");
            idx.Append(pages.Count).AppendLine(" pages total, chunked alphabetically by title.");
            idx.AppendLine();
            idx.AppendLine("**Known gap:** per-device \"Logic Types\" (which LogicType values a specific structure reads/writes, e.g. what Volume Pump supports) are populated by the game per placed *instance*, not per page template - a fresh/empty world has nothing to source that from, so most device pages won't show a Logic Types section even though the field exists and is dumped when populated. It's not missing data on purpose; forcing full coverage would need spawning one of every constructible prefab into a world first. However, every individual `LogicType.*` enum value (On, Setting, PressureInternal, etc.) has its own dedicated glossary page with a clean description - search for `## LogicType.` across these files for that reference instead.");
            idx.AppendLine();

            int fileCount = 0;
            foreach (var chunk in chunks)
            {
                string first = SanitizeFileName(DisplayTitle(chunk.First()));
                string last = SanitizeFileName(DisplayTitle(chunk.Last()));
                string fileName = $"{fileCount:D2}_{first}-{last}.md";
                var sb = new StringBuilder();
                sb.Append("# ").Append(DisplayTitle(chunk.First())).Append(" - ").AppendLine(DisplayTitle(chunk.Last()));
                sb.AppendLine();
                foreach (var page in chunk)
                    WritePage(sb, page);
                File.WriteAllText(Path.Combine(outRoot, fileName), sb.ToString());
                idx.Append("- [").Append(DisplayTitle(chunk.First())).Append(" - ").Append(DisplayTitle(chunk.Last()))
                   .Append("](").Append(fileName).Append(") (").Append(chunk.Count).AppendLine(" pages)");
                fileCount++;
            }
            File.WriteAllText(Path.Combine(outRoot, "README.md"), idx.ToString());

            Log.LogInfo($"[StationpediaDump] Wrote {fileCount} files + README to {outRoot} ({pages.Count} pages total)");
        }

        /// <summary>
        /// StationpediaPage.LogicInstructions (and related logic-type fields)
        /// are only populated per Thing *instance* via the private
        /// Stationpedia.PopulateThingPages(), which normally only runs when a
        /// player actually opens the SPDA UI - meaningless on a headless
        /// dedicated server, so it never ran on its own. Force it via
        /// reflection before reading page data.
        /// </summary>
        private static void ForcePopulateThingPages()
        {
            try
            {
                var inst = Stationpedia.Instance;
                if (inst == null) { Log.LogWarning("[StationpediaDump] Stationpedia.Instance null, cannot force logic-type population."); return; }
                var m = typeof(Stationpedia).GetMethod("PopulateThingPages",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                if (m == null) { Log.LogWarning("[StationpediaDump] PopulateThingPages method not found."); return; }
                m.Invoke(inst, null);
                Log.LogInfo("[StationpediaDump] Forced PopulateThingPages() to populate logic-type info.");
            }
            catch (Exception e)
            {
                Log.LogWarning("[StationpediaDump] ForcePopulateThingPages failed (continuing without it): " + e.Message);
            }
        }

        private static string DisplayTitle(StationpediaPage page)
        {
            string raw = !string.IsNullOrEmpty(page.Title) ? page.Title : page.Key ?? "";
            string cleaned = Clean(raw);
            return string.IsNullOrEmpty(cleaned) ? raw : cleaned;
        }

        private static void WritePage(StringBuilder sb, StationpediaPage page)
        {
            // StationpediaPage.Parsed is a lazily-evaluated property; several
            // fields (notably LogicInstructions) appear to only populate once
            // a page has actually been "opened" at least once in the UI. Touch
            // it here to force that before reading anything else off the page.
            try { _ = page.Parsed; } catch { /* best-effort */ }

            sb.Append("## ").AppendLine(DisplayTitle(page));
            sb.AppendLine();
            if (!string.IsNullOrEmpty(page.Description))
            {
                sb.AppendLine(Clean(page.Description));
                sb.AppendLine();
            }

            WriteField(sb, "Key", page.Key);
            WriteField(sb, "Prefab Name", page.PrefabName);
            WriteField(sb, "Prefab Hash", page.PrefabHash != 0 ? page.PrefabHash.ToString() : null);
            WriteField(sb, "Base Power Draw", page.BasePowerDraw);
            WriteField(sb, "Power Storage", page.PowerStorage);
            WriteField(sb, "Power Generation", page.PowerGeneration);
            WriteField(sb, "Max Pressure", page.MaxPressure);
            WriteField(sb, "Volume", page.Volume);
            WriteField(sb, "Memory Size", page.MemorySize);
            WriteField(sb, "Memory Access", page.MemoryAccess);
            WriteField(sb, "Has Memory", page.HasMemory ? "true" : null);
            WriteField(sb, "Nutrition", page.Nutrition);
            WriteField(sb, "Nutrition Quality", page.NutritionQuality);
            WriteField(sb, "Growth Time", page.GrowthTime);
            WriteField(sb, "Stack Size", page.StackSizeText);
            WriteField(sb, "Paintable", page.PaintableText);
            WriteField(sb, "Reagents Type", page.ReagentsType);
            WriteField(sb, "Specific Heat", page.SpecificHeatText);
            WriteField(sb, "Freeze Temperature", page.FreezeTemperatureText);
            WriteField(sb, "Boiling Temperature", page.BoilingTemperatureText);
            WriteField(sb, "Flashpoint", page.FlashpointText);
            WriteField(sb, "Auto Ignition", page.AutoIgnitionText);
            WriteField(sb, "Placeable In Rocket", page.PlaceableInRocket);
            WriteField(sb, "Rocket Mass", page.RocketMass);

            WriteList(sb, "Logic Types", page.LogicInstructions);
            WriteList(sb, "Logic Slot Types", page.LogicSlotInsert);
            WriteList(sb, "Logic Bindings", page.LogicBindings);
            WriteList(sb, "Slots", page.SlotInserts);
            WriteList(sb, "Build Steps", page.HowToBuild);
            WriteList(sb, "Build States", page.BuildStates);
            WriteList(sb, "Constructed From Kits", page.ConstructedByKits);
            WriteList(sb, "Resources Used", page.ResourcesUsed);
            WriteList(sb, "Mode Options", page.ModeInsert);
            WriteList(sb, "Connections", page.ConnectionInsert);
            WriteList(sb, "Found In Ore", page.FoundInOre);
            WriteList(sb, "Found In Gas", page.FoundInGas);
            WriteList(sb, "Found In Fermentation", page.FoundInFermentation);
            WriteList(sb, "Constructed Things", page.ConstructedThings);
            WriteList(sb, "Used In", page.UsedIn);

            sb.AppendLine();
            sb.AppendLine("---");
            sb.AppendLine();
        }

        // Stationpedia text is full of in-game rich-text markup (<color=..>,
        // <link=..>, <sup>, etc.) meant for the SPDA UI renderer, not raw
        // Markdown - strips to plain readable text. Collapses the runs of
        // blank lines this leaves behind (ASCII-art instruction tables use
        // embedded newlines inside a single field's text) down to one.
        private static string Clean(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            s = Regex.Replace(s, "<[^>]+>", "");
            s = Regex.Replace(s, "\r\n|\r|\n", " ").Trim();
            s = Regex.Replace(s, "\\s{2,}", " ");
            return s;
        }

        private static void WriteField(StringBuilder sb, string label, string value)
        {
            string cleaned = Clean(value);
            if (string.IsNullOrWhiteSpace(cleaned)) return;
            sb.Append("- **").Append(label).Append(":** ").AppendLine(cleaned);
        }

        private static void WriteList(StringBuilder sb, string label, IEnumerable items)
        {
            if (items == null) return;
            List<object> list;
            try { list = items.Cast<object>().Where(x => x != null).ToList(); }
            catch { return; }
            if (list.Count == 0) return;

            sb.Append("**").Append(label).AppendLine(":**");
            foreach (var item in list)
            {
                string s = Clean(SafeToString(item));
                if (!string.IsNullOrWhiteSpace(s))
                    sb.Append("  - ").AppendLine(s);
            }
        }

        /// <summary>
        /// Generic reflection-based renderer for the many auxiliary Stationpedia
        /// types (logic instruction entries, slot inserts, build steps, etc.) so
        /// this doesn't need a hand-written case for each one. Depth-limited to
        /// avoid runaway recursion on any accidental cyclic references.
        /// </summary>
        private static string SafeToString(object obj, int depth = 0)
        {
            if (obj == null) return "";
            Type type = obj.GetType();

            if (obj is string str) return str;
            if (type.IsPrimitive || type.IsEnum) return obj.ToString();
            if (IsSkippableAssetType(type)) return "";

            if (depth >= 2) return type.Name;

            var parts = new List<string>();
            foreach (var f in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                object v;
                try { v = f.GetValue(obj); } catch { continue; }
                AppendPart(parts, f.Name, v, depth);
            }
            foreach (var p in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (p.GetIndexParameters().Length > 0) continue;
                object v;
                try { v = p.GetValue(obj); } catch { continue; }
                AppendPart(parts, p.Name, v, depth);
            }

            return parts.Count > 0 ? string.Join(", ", parts) : type.Name;
        }

        // Visual/engine asset types carry no useful documentation value here
        // (raw mesh vertices, texture rects, etc.) and were bloating the dump
        // with noise - skip anything whose declared type lives in these
        // namespaces/type-name patterns entirely rather than trying to
        // reflect into them.
        private static bool IsSkippableAssetType(Type t)
        {
            string ns = t.Namespace ?? "";
            if (ns.StartsWith("UnityEngine")) return true;
            switch (t.Name)
            {
                case "Sprite":
                case "Texture2D":
                case "Texture":
                case "Material":
                case "GameObject":
                case "Transform":
                case "AudioClip":
                    return true;
                default:
                    return false;
            }
        }

        private static void AppendPart(List<string> parts, string name, object v, int depth)
        {
            if (v == null) return;
            if (v is string s)
            {
                if (string.IsNullOrWhiteSpace(s)) return;
                parts.Add($"{name}={s}");
                return;
            }
            if (v is bool b)
            {
                if (!b) return; // only note true flags, false is the common case
                parts.Add(name);
                return;
            }
            Type vt = v.GetType();
            if (IsSkippableAssetType(vt)) return;
            if (vt.IsPrimitive || vt.IsEnum)
            {
                parts.Add($"{name}={v}");
                return;
            }
            if (v is IEnumerable en && !(v is string))
            {
                var items = en.Cast<object>().Select(x => SafeToString(x, depth + 1)).Where(x => !string.IsNullOrWhiteSpace(x));
                string joined = string.Join("; ", items);
                if (!string.IsNullOrWhiteSpace(joined))
                    parts.Add($"{name}=[{joined}]");
                return;
            }
            string nested = SafeToString(v, depth + 1);
            if (!string.IsNullOrWhiteSpace(nested))
                parts.Add($"{name}=({nested})");
        }

        private static string SanitizeFileName(string name)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
                name = name.Replace(c, '_');
            return name.Replace(" ", "_");
        }
    }
}
