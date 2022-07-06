@echo off

dotnet build src/Skybrud.Forms --configuration Debug /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=c:/nuget