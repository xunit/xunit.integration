#!/usr/bin/env pwsh
#Requires -Version 5.1

# Restore and build first so the xunit MSBuild task can be found

msbuild /t:"Restore;Build" /v:minimal /nologo

# v2 projects require the .NET Framework version of MSBuild

msbuild /t:XunitTest /v:minimal /nologo v2x_net472\v2x_net472.csproj
msbuild /t:XunitTest /v:minimal /nologo v2x_net472_Sdk\v2x_net472_Sdk.csproj

# v3 projects can use the .NET version of MSBuild, even for .NET Framework projects

write-host ""
dotnet msbuild /t:XunitTest /v:minimal /nologo v3x_net472\v3x_net472.csproj
write-host ""
dotnet msbuild /t:XunitTest /v:minimal /nologo v3x_net60\v3x_net60.csproj
