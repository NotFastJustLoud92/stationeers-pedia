# Receives icon PNGs streamed from a StationpediaDump client run (see
# mod-source/StationpediaDump's UploadIcon) and writes them straight into
# the repo's icons/ folder. Needed because the dedicated-server build target
# has no GPU backend and can't decode sprite pixel data itself - only a real
# game client can extract icons, so this is how they get here without a
# manual file copy.
#
# Usage: powershell -File tools/icon_receiver.ps1 [-Port 27021]
# Stop with Ctrl+C once the client-side run finishes (watch the "Received N
# icons" counter, or check the BepInEx log on the client for the final
# "Icons: N exported" line).
param(
    [int]$Port = 27021
)

$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$outDir = Join-Path $repoRoot "icons"
New-Item -ItemType Directory -Force -Path $outDir | Out-Null

$listener = New-Object System.Net.Sockets.TcpListener([System.Net.IPAddress]::Any, $Port)
$listener.Start()
Write-Output "Listening on port $Port, writing icons to $outDir"
Write-Output "(Make sure an inbound firewall rule allows TCP $Port before the client connects.)"

$count = 0
try {
    while ($true) {
        $client = $listener.AcceptTcpClient()
        try {
            $stream = $client.GetStream()

            $hashBytes = New-Object byte[] 4
            $stream.Read($hashBytes, 0, 4) | Out-Null
            $hash = [BitConverter]::ToInt32($hashBytes, 0)

            $lenBytes = New-Object byte[] 4
            $stream.Read($lenBytes, 0, 4) | Out-Null
            $len = [BitConverter]::ToInt32($lenBytes, 0)

            if ($len -le 0 -or $len -gt 5MB) {
                Write-Warning "Rejecting implausible payload length $len for hash $hash"
            } else {
                $data = New-Object byte[] $len
                $read = 0
                while ($read -lt $len) {
                    $n = $stream.Read($data, $read, $len - $read)
                    if ($n -le 0) { break }
                    $read += $n
                }
                if ($read -eq $len) {
                    $path = Join-Path $outDir "$hash.png"
                    [System.IO.File]::WriteAllBytes($path, $data)
                    $count++
                    if ($count % 50 -eq 0) { Write-Output "Received $count icons..." }
                } else {
                    Write-Warning "Short read for hash $hash ($read of $len bytes)"
                }
            }
        }
        catch {
            Write-Warning "Error handling connection: $_"
        }
        finally {
            $client.Close()
        }
    }
}
finally {
    $listener.Stop()
    Write-Output "Stopped. Total icons received: $count"
}
