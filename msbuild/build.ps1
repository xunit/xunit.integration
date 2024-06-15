msbuild /t:Restore /v:minimal /nologo

# v2 projects require the .NET Framework version of MSBuild

msbuild /v:minimal /nologo v2x_net472\v2x_net472.csproj
msbuild /v:minimal /nologo v2x_net472_Sdk\v2x_net472_Sdk.csproj

# v3 projects can use the .NET version of MSBuild, even for .NET Framework projects

write-host ""
dotnet msbuild /v:minimal /nologo v3x_net472\v3x_net472.csproj
write-host ""
dotnet msbuild /v:minimal /nologo v3x_net60\v3x_net60.csproj
