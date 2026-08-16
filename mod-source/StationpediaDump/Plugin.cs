using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Assets.Scripts;
using Assets.Scripts.Objects;
using Assets.Scripts.UI;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

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

            DumpIcons(sorted, outRoot);
        }

        /// <summary>
        /// Exports each page's Thing.Thumbnail sprite as a PNG named by
        /// PrefabHash, so the search site can show real item icons like the
        /// in-game SPDA does. Most non-physical pages (LogicType.* glossary
        /// entries, guide/lore pages) have no PrefabHash/Thing and are
        /// silently skipped - only real placeable Things have thumbnails.
        /// </summary>
        private static void DumpIcons(List<StationpediaPage> pages, string outRoot)
        {
            string iconDir = Path.Combine(outRoot, "icons");
            Directory.CreateDirectory(iconDir);
            int ok = 0, skipped = 0, failed = 0;
            foreach (var page in pages)
            {
                if (page.PrefabHash == 0) { skipped++; continue; }
                string fname = Path.Combine(iconDir, page.PrefabHash + ".png");
                if (File.Exists(fname)) { ok++; continue; } // shared prefab hash across pages
                try
                {
                    Thing thing = Prefab.Find(page.PrefabHash);
                    Sprite sprite = thing != null ? thing.Thumbnail : null;
                    if (sprite == null) { skipped++; continue; }

                    byte[] png = EncodeSpriteToPng(sprite);
                    if (png == null) { failed++; continue; }
                    File.WriteAllBytes(fname, png);
                    UploadIcon(page.PrefabHash, png);
                    ok++;
                }
                catch (Exception e)
                {
                    failed++;
                    Log.LogWarning($"[StationpediaDump] Icon export failed for {page.Key}: {e.Message}");
                }
            }
            Log.LogInfo($"[StationpediaDump] Icons: {ok} exported, {skipped} skipped (no prefab/sprite), {failed} failed.");
        }

        // Optional: this server's dedicated-server build target has no GPU
        // rendering backend, so it can't read compressed sprite pixel data
        // (see EncodeSpriteToPng) - icons only extract cleanly on a real
        // client. When this plugin runs on a client instead, it can stream
        // each icon back to a receiver running on the server over a plain
        // TCP socket, so no manual file transfer is needed. Only active if
        // upload_target.txt (not committed to git - purely local, created by
        // whoever runs the client) sits next to the DLL containing a single
        // "host:port" line; absent by default, so nothing changes for the
        // normal server-side markdown-only run.
        private static string _uploadHost;
        private static int _uploadPort = 27021;
        private static bool _uploadConfigLoaded;

        private static void LoadUploadConfig()
        {
            if (_uploadConfigLoaded) return;
            _uploadConfigLoaded = true;
            try
            {
                string cfgPath = Path.Combine(Paths.PluginPath, "StationpediaDump", "upload_target.txt");
                if (!File.Exists(cfgPath)) return;
                string line = File.ReadAllLines(cfgPath).FirstOrDefault(l => !string.IsNullOrWhiteSpace(l));
                if (string.IsNullOrWhiteSpace(line)) return;
                var parts = line.Trim().Split(':');
                _uploadHost = parts[0];
                if (parts.Length > 1 && int.TryParse(parts[1], out int p)) _uploadPort = p;
                Log.LogInfo($"[StationpediaDump] Icon upload target configured: {_uploadHost}:{_uploadPort}");
            }
            catch (Exception e)
            {
                Log.LogWarning("[StationpediaDump] Failed to read upload_target.txt: " + e.Message);
            }
        }

        private static void UploadIcon(int prefabHash, byte[] png)
        {
            LoadUploadConfig();
            if (string.IsNullOrEmpty(_uploadHost)) return;
            try
            {
                using (var client = new TcpClient())
                {
                    client.Connect(_uploadHost, _uploadPort);
                    using (var stream = client.GetStream())
                    {
                        stream.Write(BitConverter.GetBytes(prefabHash), 0, 4);
                        stream.Write(BitConverter.GetBytes(png.Length), 0, 4);
                        stream.Write(png, 0, png.Length);
                    }
                }
            }
            catch (Exception e)
            {
                Log.LogWarning($"[StationpediaDump] Icon upload failed for {prefabHash}: {e.Message}");
            }
        }

        /// <summary>
        /// Crops a Sprite's region out of its backing Texture2D and encodes it
        /// as PNG. Tries a direct GetPixels() read first (works when the
        /// texture asset is marked readable); falls back to a GPU
        /// blit-to-RenderTexture-then-ReadPixels round trip for non-readable
        /// textures (the common case for packed UI atlases).
        /// </summary>
        private static byte[] EncodeSpriteToPng(Sprite sprite)
        {
            Texture2D tex = sprite.texture;
            if (tex == null) return null;
            Rect r = sprite.textureRect;
            int x = Mathf.RoundToInt(r.x), y = Mathf.RoundToInt(r.y);
            int w = Mathf.RoundToInt(r.width), h = Mathf.RoundToInt(r.height);
            if (w <= 0 || h <= 0) return null;

            Texture2D readable = null;
            RenderTexture rt = null;
            RenderTexture prevActive = null;
            try
            {
                if (!tex.isReadable)
                {
                    rt = RenderTexture.GetTemporary(tex.width, tex.height, 0, RenderTextureFormat.ARGB32);
                    Graphics.Blit(tex, rt);
                    prevActive = RenderTexture.active;
                    RenderTexture.active = rt;
                    readable = new Texture2D(tex.width, tex.height, TextureFormat.RGBA32, false);
                    readable.ReadPixels(new Rect(0, 0, tex.width, tex.height), 0, 0);
                    readable.Apply();
                }

                Texture2D source = readable ?? tex;
                x = Mathf.Clamp(x, 0, Math.Max(0, source.width - w));
                y = Mathf.Clamp(y, 0, Math.Max(0, source.height - h));
                var pixels = source.GetPixels(x, y, w, h);
                var cropped = new Texture2D(w, h, TextureFormat.RGBA32, false);
                cropped.SetPixels(pixels);
                cropped.Apply();
                byte[] png = cropped.EncodeToPNG();
                UnityEngine.Object.Destroy(cropped);
                return png;
            }
            finally
            {
                if (readable != null) UnityEngine.Object.Destroy(readable);
                if (rt != null)
                {
                    RenderTexture.active = prevActive;
                    RenderTexture.ReleaseTemporary(rt);
                }
            }
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
            if (!TryRenderBuildRecipe(page, sb))
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

        // Matches one alternative furnace recipe: "Temperature: X to Y Pressure: A to
        // B 0.75 x Iron from Ore (Iron) 0.25 x Carbon from Charcoal". BuildStates
        // holds one such row per *alternative* recipe (e.g. Steel accepts either
        // Charcoal or Ore (Coal) as its carbon source - each is a complete,
        // independent row, not two ingredients of one recipe split across rows),
        // plus one trailing row with just the yield ("1 x Steel") shared by every
        // variant above it for that printer.
        // The "from" clause is optional - an ingredient can be another craftable
        // item used directly (e.g. Astroloy takes "0.5 x Steel" with no ore
        // source), not just something extracted "from" a raw ore/ice.
        private static readonly Regex FurnaceVariantPattern = new Regex(
            @"^Temperature:\s*(?<temp>.+?)\s+Pressure:\s*(?<pressure>.+?)\s+(?<ingredients>(?:[\d.]+\s*x\s*.+?(?:\s+from\s+.+?)?\s*)+)$",
            RegexOptions.Compiled);
        private static readonly Regex FurnaceIngredientPattern = new Regex(
            @"([\d.]+)\s*x\s*(.+?)(?:\s+from\s+(.+?))?(?=(?:\s+[\d.]+\s*x\s)|$)",
            RegexOptions.Compiled);
        private static readonly Regex FurnaceYieldPattern = new Regex(
            @"^(\d+(?:\.\d+)?)\s*x\s*(.+)$", RegexOptions.Compiled);

        private static string GetStringMember(object obj, Type t, string name)
        {
            var f = t.GetField(name, BindingFlags.Public | BindingFlags.Instance);
            if (f != null) return f.GetValue(obj) as string;
            var p = t.GetProperty(name, BindingFlags.Public | BindingFlags.Instance);
            if (p != null) return p.GetValue(obj) as string;
            return null;
        }

        /// <summary>
        /// Replaces the generic "Build Steps" (page.HowToBuild) dump - previously
        /// a raw reflection-formatted "PrinterName=X, TierName=Y, Description=Z"
        /// line - with a clean "Build Recipe" card for every printer-built item,
        /// not just furnace-smelted alloys. Furnace/Advanced Furnace rows carry
        /// a Temperature/Pressure clause and get the original dedicated parse
        /// (dedup printer tiers sharing identical requirements, one shared
        /// Yield line); everything else (Autolathe, Electronics Printer, etc.)
        /// gets a generic per-(printer,tier) ingredient breakdown instead.
        /// Returns false (caller falls back to the plain list dump) only when
        /// HowToBuild is empty/unparseable - kit-built structures (no printer
        /// involved) keep their existing simple rendering via ResourcesUsed.
        /// </summary>
        private static bool TryRenderBuildRecipe(StationpediaPage page, StringBuilder sb)
        {
            var howToBuild = page.HowToBuild;
            if (howToBuild == null) return false;
            List<object> items;
            try { items = howToBuild.Cast<object>().Where(x => x != null).ToList(); }
            catch { return false; }
            if (items.Count == 0) return false;

            var rows = new List<(string printer, string tier, string desc)>();
            foreach (var item in items)
            {
                Type t = item.GetType();
                string printer = Clean(GetStringMember(item, t, "PrinterName") ?? "");
                string tier = Clean(GetStringMember(item, t, "TierName") ?? "");
                string desc = GetStringMember(item, t, "Description");
                if (desc == null) continue;
                rows.Add((printer, tier, Clean(desc)));
            }
            if (rows.Count == 0) return false;

            bool anyFurnace = rows.Any(r => FurnaceVariantPattern.IsMatch(r.desc));
            if (!anyFurnace) return RenderGenericPrinterRecipe(rows, sb);

            var variantsByPrinter = new Dictionary<string, List<string>>();
            string yieldText = null;
            foreach (var (printer, _, desc) in rows)
            {
                if (FurnaceVariantPattern.IsMatch(desc))
                {
                    if (!variantsByPrinter.TryGetValue(printer, out var list))
                        variantsByPrinter[printer] = list = new List<string>();
                    list.Add(desc);
                }
                else if (yieldText == null)
                {
                    // Some rows (e.g. raw ore/organics burned in an Arc Furnace
                    // for Energy) yield more than one output in a single
                    // description ("500 x Energy 1 x Biomass from Biomass").
                    // Re-templating only the first "N x X" would silently drop
                    // the rest, so just pass the whole cleaned line through
                    // when a second "N x" is present instead of guessing at
                    // its structure.
                    var ym = FurnaceYieldPattern.Match(desc);
                    if (ym.Success)
                    {
                        string rest = ym.Groups[2].Value;
                        yieldText = Regex.IsMatch(rest, @"\d+(?:\.\d+)?\s*x\s")
                            ? desc
                            : $"{ym.Groups[1].Value} x {rest}";
                    }
                }
            }
            if (variantsByPrinter.Count == 0) return false;

            // Dedupe printers whose variant sets are identical (Furnace and
            // Advanced Furnace almost always require the same inputs).
            var printersByVariantSet = new Dictionary<string, List<string>>();
            var variantSetContent = new Dictionary<string, List<string>>();
            foreach (var kv in variantsByPrinter)
            {
                string key = string.Join("||", kv.Value);
                if (!printersByVariantSet.TryGetValue(key, out var printers))
                {
                    printersByVariantSet[key] = printers = new List<string>();
                    variantSetContent[key] = kv.Value;
                }
                printers.Add(kv.Key);
            }

            sb.AppendLine("**Build Recipe:**");
            if (yieldText != null)
                sb.Append("  - Yield: ").AppendLine(yieldText);

            foreach (var kv in printersByVariantSet)
            {
                sb.Append("  - Printer: ").AppendLine(string.Join(" / ", kv.Value.OrderBy(p => p)));
                foreach (var variantDesc in variantSetContent[kv.Key])
                {
                    var m = FurnaceVariantPattern.Match(variantDesc);
                    if (!m.Success) continue;
                    string temp = m.Groups["temp"].Value.Trim();
                    string pressure = m.Groups["pressure"].Value.Trim();
                    var ingredientParts = new List<string>();
                    foreach (Match im in FurnaceIngredientPattern.Matches(m.Groups["ingredients"].Value))
                    {
                        string src = im.Groups[3].Success ? im.Groups[3].Value.Trim() : null;
                        string part = $"{im.Groups[1].Value} {im.Groups[2].Value.Trim()}";
                        if (!string.IsNullOrEmpty(src)) part += $" (from {src})";
                        ingredientParts.Add(part);
                    }
                    if (ingredientParts.Count == 0) continue;
                    sb.Append("    - ").Append(string.Join(" + ", ingredientParts))
                      .Append(" | Temp: ").Append(temp).Append(" | Pressure: ").AppendLine(pressure);
                }
            }
            sb.AppendLine();
            return true;
        }

        /// <summary>
        /// "Build Recipe" rendering for non-furnace printers (Autolathe,
        /// Electronics Printer, Rocket Manufactory, etc.). Raw Description text
        /// for these has no Temperature/Pressure clause - it's a flat run of
        /// "N x Ingredient (from Source)?" tokens, where the first token is
        /// conventionally the print's power cost ("500 x Energy"). Grouped by
        /// (Printer, Tier) since cost/ingredients commonly shift across tiers.
        /// </summary>
        private static bool RenderGenericPrinterRecipe(List<(string printer, string tier, string desc)> rows, StringBuilder sb)
        {
            var seenGroups = new List<(string label, string ingredients)>();
            foreach (var (printer, tier, desc) in rows)
            {
                var parts = new List<string>();
                foreach (Match im in FurnaceIngredientPattern.Matches(desc))
                {
                    string src = im.Groups[3].Success ? im.Groups[3].Value.Trim() : null;
                    string part = $"{im.Groups[1].Value} x {im.Groups[2].Value.Trim()}";
                    if (!string.IsNullOrEmpty(src)) part += $" (from {src})";
                    parts.Add(part);
                }
                if (parts.Count == 0) continue;
                string label = string.IsNullOrEmpty(tier) ? printer : $"{printer} ({tier})";
                seenGroups.Add((label, string.Join(" + ", parts)));
            }
            if (seenGroups.Count == 0) return false;

            sb.AppendLine("**Build Recipe:**");
            foreach (var (label, ingredients) in seenGroups)
            {
                sb.Append("  - Printer: ").AppendLine(label);
                sb.Append("    - ").AppendLine(ingredients);
            }
            sb.AppendLine();
            return true;
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
