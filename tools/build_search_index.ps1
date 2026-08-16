# Rebuilds search.html from data/*.md. Run this any time data/ changes
# (after regenerating the library via mod-source/StationpediaDump).
$ErrorActionPreference = 'Stop'

$repoRoot = Split-Path -Parent $PSScriptRoot
$dataDir = Join-Path $repoRoot "data"
$iconsDir = Join-Path $repoRoot "icons"
$templatePath = Join-Path $PSScriptRoot "search_template.html"
$outPath = Join-Path $repoRoot "search.html"

$iconHashes = @{}
if (Test-Path $iconsDir) {
    Get-ChildItem -Path $iconsDir -Filter "*.png" | ForEach-Object { $iconHashes[$_.BaseName] = $true }
}

# No clean per-item category field exists in the extracted game data
# (PageCustomCategories is ~empty, DisplayFilter is ~99% "Undefined", and
# Stationpedia.HomePageOverrides is just the button list, not a per-item
# mapping - all confirmed dead ends via reflection). This reproduces the
# native SPDA's own category set via title/prefab-name pattern matching
# instead - approximate by nature, but full-text search still covers
# everything regardless of which bucket an item lands in.
function Get-Category($title, $body) {
    if ($title -match '^LogicType\.') { return 'Logic Reference' }
    if ($body -match '(?m)^-\s*\*\*Gas Type:\*\*') { return 'Gases' }
    if ($title -match '^Ore \(') { return 'Ores' }
    if ($title -match '^Ingot \(') { return 'Ingots' }
    if ($title -match '^Kit \(') { return 'Structure Kits' }
    if ($title -match '^Cartridge \(') { return 'Cartridges' }
    if ($title -match '(?i)(Autolathe|Furnace|Electronics Printer|Fabricator|Manufactory|Recycler|Hydraulic Pipe Bender|Security Printer|Chemistry Printer)') { return 'Fabricators' }
    if ($body -match '(?m)^-\s*\*\*Reagents(?: Type)?:\*\*') { return 'Reagents' }
    if ($title -match '(?i)(Pipe|Valve|Volume Pump|Filter \(|Regulator|Vent\b|Cooler|Heater|Condensat|Canister|Gas Tank|Analyz|Active Vent|Passive Vent|Insulation|Heat Exchanger)') { return 'Atmospherics' }
    if ($title -match '(?i)(Battery|Transformer|Charger|^Cable|Wire\b|Switch\b|Breaker|Relay|Capacitor|Power Pylon|Power Controller|Solar Panel|Solar Tracker|Wind Turbine|Generator|APC|Umc)') { return 'Electronics' }
    if ($title -match '(?i)(Logic Chip|Motherboard|Sorter\b|Stacker\b|Console\b|Display\b|Logic (Reader|Writer|Memory|Dial|Transmitter|Receiver)|Integrated Circuit|IC Housing|Programmable Chip)') { return 'Logic Devices' }
    if ($title -match '(?i)(Corn|Wheat|Rice|Soybean|Tomato|Potato|Pumpkin|Fern|Mushroom|Bean|Pepper|Egg\b|Sludge|Cooked|Soup|Powdered|Nutrient Paste|Ration Pack)') { return 'Organics and Food' }
    if ($title -match '(?i)(Rocket|Thruster|Avionics|Landing Gear|Nose Cone|Fuselage|Fuel Tank)') { return 'Rockets' }
    if ($title -match '(?i)(Gene|Splicer|Vial|DNA)') { return 'Genetics' }
    if ($title -match '(?i)(Trade|Vendor|Shuttle)') { return 'Trading' }
    if ($title -match '(?i)^(Wrench|Crowbar|Drill\b|Wirecutters|Duct Tape|Angle Grinder|Welding Torch|Mining Drill|Tablet|Multitool|Scanner|Hacking)') { return 'Hand Tools' }
    if ($title -match '(?i)(Suit|Helmet|Backpack|Glasses|Uniform|Jetpack|Visor|Overalls|Hard Hat|Hazmat|Bobble Head)') { return 'Personal' }
    if ($title -match '(?i)(Chair|^Table|Locker|^Bed\b|Picture Frame|^Sign\b|Trash|^Bin\b|Vending Machine|Water Cooler)') { return 'Furniture' }
    if ($title -match '(?i)(Landingpad|Umbilical|Silo\b)') { return 'Import/Export' }
    return 'Structures'
}

$pages = @()
$dataFiles = Get-ChildItem -Path $dataDir -Filter "*.md" | Where-Object { $_.Name -ne "README.md" } | Sort-Object Name
$iconedPages = 0

foreach ($file in $dataFiles) {
    $text = Get-Content $file.FullName -Raw -Encoding UTF8
    # Pages are separated by a line containing only "---" (WriteFurnaceRecipes
    # etc. never emit a bare "---" mid-page, only WritePage's own trailing
    # separator does) - split on that, first chunk before any "## " is the
    # file's own H1 header and can be discarded.
    $chunks = [regex]::Split($text, "(?m)^---\s*$")
    foreach ($chunk in $chunks) {
        $m = [regex]::Match($chunk, "(?ms)^##\s+(.+?)\r?\n(.*)$")
        if (-not $m.Success) { continue }
        $title = $m.Groups[1].Value.Trim()
        $body = $m.Groups[2].Value.Trim()
        if ([string]::IsNullOrWhiteSpace($title)) { continue }

        $page = [PSCustomObject]@{
            t = $title
            f = $file.Name
            b = $body
        }
        $hashMatch = [regex]::Match($body, "(?m)^-\s*\*\*Prefab Hash:\*\*\s*(-?\d+)\s*$")
        $gasMatch = [regex]::Match($body, "(?m)^-\s*\*\*Gas Type:\*\*\s*(.+?)\s*$")
        if ($hashMatch.Success -and $iconHashes.ContainsKey($hashMatch.Groups[1].Value)) {
            $page | Add-Member -MemberType NoteProperty -Name "i" -Value "icons/$($hashMatch.Groups[1].Value).png"
            $iconedPages++
        } elseif ($gasMatch.Success) {
            # No real sprite extraction for gases (see README known
            # limitations) - the front end generates a chemical-formula
            # badge client-side instead, styled like the in-game diamond
            # icons, from just this GasType name.
            $page | Add-Member -MemberType NoteProperty -Name "g" -Value $gasMatch.Groups[1].Value
            $iconedPages++
        }

        $ctMatch = [regex]::Match($body, "(?m)^-\s*\*\*Content Type:\*\*\s*(Guide|Lore)\s*$")
        if ($ctMatch.Success) {
            $page | Add-Member -MemberType NoteProperty -Name "ct" -Value $ctMatch.Groups[1].Value
            $page | Add-Member -MemberType NoteProperty -Name "c" -Value $ctMatch.Groups[1].Value
        } else {
            $page | Add-Member -MemberType NoteProperty -Name "c" -Value (Get-Category $title $body)
        }
        $pages += $page
    }
}

Write-Output "Parsed $($pages.Count) pages from $($dataFiles.Count) files. $iconedPages have icons."
$catCounts = $pages | Group-Object c | Sort-Object Count -Descending
$catCounts | ForEach-Object { Write-Output "  $($_.Name): $($_.Count)" }

# IC10 Function Library (functions.md) - a completely separate data domain
# from Stationpedia pages, parsed the same way (## headers, --- separators)
# but kept as its own top-level array instead of mixing into $pages.
$functions = @()
$functionsPath = Join-Path $repoRoot "functions.md"
if (Test-Path $functionsPath) {
    $ftext = Get-Content $functionsPath -Raw -Encoding UTF8
    $fchunks = [regex]::Split($ftext, "(?m)^---\s*$")
    foreach ($chunk in $fchunks) {
        $m = [regex]::Match($chunk, "(?ms)^##\s+(.+?)\r?\n(.*)$")
        if (-not $m.Success) { continue }
        $name = $m.Groups[1].Value.Trim()
        $fbody = $m.Groups[2].Value.Trim()
        if ([string]::IsNullOrWhiteSpace($name)) { continue }
        $catM = [regex]::Match($fbody, "(?m)^-\s*\*\*Category:\*\*\s*(.+?)\s*$")
        $sigM = [regex]::Match($fbody, "(?m)^-\s*\*\*Signature:\*\*\s*(.+?)\s*$")
        $desc = [regex]::Replace($fbody, "(?m)^-\s*\*\*(Category|Signature):\*\*.*$", "").Trim()
        $functions += [PSCustomObject]@{
            n = $name
            cat = $(if ($catM.Success) { $catM.Groups[1].Value } else { $null })
            sig = $(if ($sigM.Success) { $sigM.Groups[1].Value } else { $null })
            d = $(if ($desc) { $desc } else { $null })
        }
    }
}
$withDesc = ($functions | Where-Object { $_.d }).Count
Write-Output "Parsed $($functions.Count) IC10 functions ($withDesc with description text)."

$json = $pages | ConvertTo-Json -Depth 3 -Compress
# ConvertTo-Json on a single-element array doesn't wrap in [] - force it.
if ($pages.Count -eq 1) { $json = "[$json]" }
$json = $json.Replace("</script", "<\/script")

$funcJson = $functions | ConvertTo-Json -Depth 3 -Compress
if ($functions.Count -eq 1) { $funcJson = "[$funcJson]" }
if ($functions.Count -eq 0) { $funcJson = "[]" }
# Defensive: a literal "</script" anywhere in game text would terminate the
# embedding <script> tag early and corrupt the page. None expected, but cheap
# to guard against.
$funcJson = $funcJson.Replace("</script", "<\/script")

$template = Get-Content $templatePath -Raw -Encoding UTF8
$output = $template.Replace("__PAGES_JSON__", $json).Replace("__FUNCTIONS_JSON__", $funcJson).Replace("__PAGE_COUNT__", $pages.Count.ToString())
[System.IO.File]::WriteAllText($outPath, $output, (New-Object System.Text.UTF8Encoding $false))

Write-Output "Wrote $outPath ($((Get-Item $outPath).Length) bytes)"
