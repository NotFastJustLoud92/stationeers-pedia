# Stationeers Pedia

A reference library of Stationeers' Stationpedia (device docs, specs, build recipes, real item icons, and the full `LogicType` glossary), extracted directly from live game data — not hand-transcribed, not scraped from a wiki. Covers vanilla content plus every device/item added by the Cragspire server's Workshop mod set. Built for use as accurate reference material when writing IC10 scripts or working on the [stationeers-atmospherics](https://github.com/NotFastJustLoud92/stationeers-atmospherics) build.

## Contents

- [`search.html`](search.html) — download/clone the repo and open this locally for a searchable interface over all 2,435 pages (title + full-text search, no server or internet connection needed). Regenerate it with `tools/build_search_index.ps1` any time `data/` or `icons/` changes.
- [`data/`](data/) — the extracted library itself. 2,435 pages, chunked alphabetically into 25 files. Start at [`data/README.md`](data/README.md) for the index and a note on current known gaps.
- [`icons/`](icons/) — real in-game item icons, one PNG per `Prefab Hash` that has one (1,868 of 2,435 pages). Matched to pages automatically by `build_search_index.ps1`.
- [`mod-source/StationpediaDump/`](mod-source/StationpediaDump/) — the BepInEx/Harmony mod that generates `data/` and `icons/`. Not published to Steam Workshop; it's a one-off extraction tool, run manually whenever the library needs refreshing (e.g. after a game update or mod-set change).
- [`tools/`](tools/) — `build_search_index.ps1` + its HTML template regenerate `search.html`; `icon_receiver.ps1` is the server-side receiver used during a client-side icon capture run (see below).

## How the extraction works

Stationeers' Stationpedia is real in-game data (`Assets.Scripts.UI.Stationpedia`), not static text — every device's power draw, pressure limits, build recipe, and logic support lives in the compiled game assembly and gets populated at runtime. The mod hooks `GameManager.StartGame` (or `GameManager.OnReadyToPlay` for a joining client - see below) via Harmony, forces the game's own `Stationpedia.PopulateThingPages()` to run (this normally only fires when a player opens the in-game SPDA — meaningless on a headless dedicated server otherwise), then walks every `StationpediaPage` and serializes it to Markdown.

Text/spec data extraction is confirmed working on a fully headless dedicated server — no client, no rendering, no UI needed.

**Icons are different: they require a real game client.** The dedicated-server Unity build target has no GPU rendering backend, so it can't decode the compressed sprite textures item icons are stored as (`Graphics.Blit`/`RenderTexture.ReadPixels` silently produce blank images there). Icon extraction only works when the mod runs inside an actual game client with a real GPU — see `EncodeSpriteToPng` and the `UploadIcon` TCP streaming path in `Plugin.cs` for how a client-side run gets icon bytes back to wherever `data/`/`icons/` live without a manual file copy.

## Regenerating the library

**Text/spec data (server-side, no icons):**
1. Build `mod-source/StationpediaDump` (`dotnet build -c Release`, targets `net472`) against a dedicated server install's current game DLLs — see the project file for the exact reference paths.
2. Drop `StationpediaDump.dll` into that server's `BepInEx/plugins/StationpediaDump/`.
3. Boot the server once. It writes `StationpediaDump_Output/` next to the server root and logs a summary to `BepInEx/LogOutput.log`.
4. Copy the output over `data/`, remove the plugin, run `tools/build_search_index.ps1` to refresh `search.html`, commit.

**Icons (needs a real client):** run the same mod inside an actual game client (not the dedicated server) instead - either hosting a local session or joining a server - then copy the client's `StationpediaDump_Output/icons/` folder into the repo's `icons/` and rerun `tools/build_search_index.ps1`. If the client is joining a remote server rather than hosting, `GameManager.StartGame` never fires (it's host-authoritative only) - `OnReadyToPlay` is patched as well specifically to cover that case.

**Include modded content:** run against a server/world with the desired Workshop mods enabled (`mods/modconfig.xml` + `mods/mods/`) - the dump walks whatever `Stationpedia.StationpediaPages` contains, vanilla or modded, with no special-casing needed. **Client and server mod sets must match** - StationeersLaunchPad's networking handshake rejects a join otherwise (surfaces as a generic "invalid booster networking version" error, not an obviously mod-related one).

**Always test a rebuilt version of this mod on an isolated test server first, never directly on a live/production dedicated server** — an earlier, buggier version of this diagnostic hard-crashed a live server before this pattern was established.

## Build recipes

Every printer-built item — furnace-smelted alloys as well as anything made on an Autolathe, Electronics Printer, Rocket Manufactory, etc. — gets a dedicated **Build Recipe** section instead of a raw field dump: printer(s), tier, resource cost, and (for furnace items specifically) temperature/pressure range, parsed out of the game's raw build-step data. Furnace/Advanced Furnace variants are deduplicated when they share identical requirements. Search `search.html` for any item name to find its recipe.

## Known limitations

Per-device "Logic Types" (which `LogicType` values a specific structure actually reads/writes) only populate for devices with a placed instance somewhere in the world at extraction time — a fresh/empty test world has nothing to source that from, so most device pages are missing that specific section even though the field is real and gets dumped whenever it's populated. The `LogicType.*` glossary pages (one per enum value, e.g. `LogicType.On`, `LogicType.Setting`) are complete regardless and cover what each logic type means generally.

Gas-property pages (Oxygen, Nitrogen, etc.) have full spec data — Specific Heat, Latent Heat, freeze/boil points, Combustion reactions — but no icon. Icons are matched by `Prefab Hash`, and pure gas types aren't spawnable `Thing` prefabs the way physical items/structures are, so there's no `Thing.Thumbnail` sprite to extract for them. The in-game SPDA sources gas icons from a separate `Stationpedia._gasThumbnails` list instead - not currently wired up here.
