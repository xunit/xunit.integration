$nugetVersion = "4.3.0"
$nugetExe = [System.IO.Path]::Combine($home, ".nuget", "cli", $nugetVersion, "nuget.exe")

function _download_nuget() {
    $cliVersionPath = split-path $nugetExe -Parent
    if ((test-path $cliVersionPath) -eq $false) {
        New-Item -Type Directory -Path $cliVersionPath | out-null
    }

    if ((test-path $nugetExe) -eq $false) {
        write-host ("Downloading NuGet version " + $nugetVersion) -ForegroundColor White
            Invoke-WebRequest ("https://dist.nuget.org/win-x86-commandline/v" + $nugetVersion + "/nuget.exe") -OutFile $nugetExe
    }
}

function _fatal([string] $message) {
    Write-Host -ForegroundColor Red ("Error: " + $message)
    exit -1
}

function _require([string] $command, [string] $message) {
    if ((get-command $command -ErrorAction SilentlyContinue) -eq $null) {
        _fatal $message
    }
}

_require dotnet "Could not find 'dotnet'. Please ensure .NET CLI Tooling is installed."
_require msbuild "Could not find 'msbuild'. Please ensure MSBUILD.EXE v15 is on the path."
_download_nuget 

& $nugetExe restore

Get-ChildItem -r -i *net452*.csproj | ForEach-Object {
    write-host ""
    write-host $_.FullName -ForegroundColor White
    write-host ""
    & msbuild "$($_.FullName)" "/t:XunitTest" /p:XunitTest_IgnoreFailures=true /p:XunitTest_TargetDependencies=Build /v:minimal /nologo
}

Get-ChildItem -r -i *netcoreapp*.csproj | ForEach-Object {
    write-host ""
    write-host $_.FullName -ForegroundColor White
    write-host ""
    & dotnet msbuild "$($_.FullName)" "/t:Build;XunitTest" /p:XunitTest_IgnoreFailures=true /p:XunitTest_TargetDependencies=Build /v:minimal /nologo
}