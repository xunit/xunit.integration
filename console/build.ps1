#!/usr/bin/env pwsh
#Requires -Version 5.1

msbuild /t:Restore /v:minimal /nologo

# Have to use .NET Framework MSBuild for non-SDK style projects
msbuild /v:minimal /nologo v2x_net472/v2x_net472.csproj

# We can use .NET MSBuild for any SDK style project
write-host ""
dotnet msbuild /v:minimal /nologo v2x_net472_Sdk/v2x_net472_Sdk.csproj
write-host ""
dotnet msbuild /v:minimal /nologo v3x_net472/v3x_net472.csproj
write-host ""
dotnet msbuild /v:minimal /nologo v3x_net60/v3x_net60.csproj
