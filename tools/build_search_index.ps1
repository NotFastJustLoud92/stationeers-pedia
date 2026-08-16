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
        if ($hashMatch.Success -and $iconHashes.ContainsKey($hashMatch.Groups[1].Value)) {
            $page | Add-Member -MemberType NoteProperty -Name "i" -Value "icons/$($hashMatch.Groups[1].Value).png"
            $iconedPages++
        }
        $pages += $page
    }
}

Write-Output "Parsed $($pages.Count) pages from $($dataFiles.Count) files. $iconedPages have icons."

$json = $pages | ConvertTo-Json -Depth 3 -Compress
# ConvertTo-Json on a single-element array doesn't wrap in [] - force it.
if ($pages.Count -eq 1) { $json = "[$json]" }
# Defensive: a literal "</script" anywhere in game text would terminate the
# embedding <script> tag early and corrupt the page. None expected, but cheap
# to guard against.
$json = $json.Replace("</script", "<\/script")

$template = Get-Content $templatePath -Raw -Encoding UTF8
$output = $template.Replace("__PAGES_JSON__", $json).Replace("__PAGE_COUNT__", $pages.Count.ToString())
[System.IO.File]::WriteAllText($outPath, $output, (New-Object System.Text.UTF8Encoding $false))

Write-Output "Wrote $outPath ($((Get-Item $outPath).Length) bytes)"
