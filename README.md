# Stationeers Pedia

A reference library of Stationeers' Stationpedia (device docs, specs, build recipes, and the full `LogicType` glossary), extracted directly from live game data — not hand-transcribed, not scraped from a wiki. Built for use as accurate reference material when writing IC10 scripts or working on the [stationeers-atmospherics](https://github.com/NotFastJustLoud92/stationeers-atmospherics) build.

## Contents

- [`search.html`](search.html) — download/clone the repo and open this locally for a searchable interface over all 1,985 pages (title + full-text search, no server or internet connection needed). Regenerate it with `tools/build_search_index.ps1` any time `data/` changes.
- [`data/`](data/) — the extracted library itself. 1,985 pages, chunked alphabetically into 20 files. Start at [`data/README.md`](data/README.md) for the index and a note on current known gaps.
- [`mod-source/StationpediaDump/`](mod-source/StationpediaDump/) — the BepInEx/Harmony mod that generates `data/`. Not published to Steam Workshop; it's a one-off extraction tool, run manually against a dedicated server install whenever the library needs refreshing (e.g. after a game update changes device stats or adds new content).
- [`tools/`](tools/) — `build_search_index.ps1` + its HTML template, regenerates `search.html` from whatever's currently in `data/`.

## How the extraction works

Stationeers' Stationpedia is real in-game data (`Assets.Scripts.UI.Stationpedia`), not static text — every device's power draw, pressure limits, build recipe, and logic support lives in the compiled game assembly and gets populated at runtime. The mod hooks `GameManager.StartGame` via Harmony, forces the game's own `Stationpedia.PopulateThingPages()` to run (this normally only fires when a player opens the in-game SPDA — meaningless on a headless dedicated server otherwise), then walks every `StationpediaPage` and serializes it to Markdown.

Confirmed working on a fully headless dedicated server — no client, no rendering, no UI needed.

## Regenerating the library

1. Build `mod-source/StationpediaDump` (`dotnet build -c Release`, targets `net472`) against a dedicated server install's current game DLLs — see the project file for the exact reference paths.
2. Drop `StationpediaDump.dll` into that server's `BepInEx/plugins/StationpediaDump/`.
3. Boot the server once. It writes `StationpediaDump_Output/` next to the server root and logs a summary to `BepInEx/LogOutput.log`.
4. Copy the output over `data/`, remove the plugin, run `tools/build_search_index.ps1` to refresh `search.html`, commit.

**Always test a rebuilt version of this mod on an isolated test server first, never directly on a live/production dedicated server** — an earlier, buggier version of this diagnostic hard-crashed a live server before this pattern was established.

## Build recipes

Every printer-built item — furnace-smelted alloys as well as anything made on an Autolathe, Electronics Printer, Rocket Manufactory, etc. — gets a dedicated **Build Recipe** section instead of a raw field dump: printer(s), tier, resource cost, and (for furnace items specifically) temperature/pressure range, parsed out of the game's raw build-step data. Furnace/Advanced Furnace variants are deduplicated when they share identical requirements. Search `search.html` for any item name to find its recipe.

## Known limitation

Per-device "Logic Types" (which `LogicType` values a specific structure actually reads/writes) only populate for devices with a placed instance somewhere in the world at extraction time — a fresh/empty test world has nothing to source that from, so most device pages are missing that specific section even though the field is real and gets dumped whenever it's populated. The `LogicType.*` glossary pages (one per enum value, e.g. `LogicType.On`, `LogicType.Setting`) are complete regardless and cover what each logic type means generally.
