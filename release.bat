@echo off

dotnet build src/Skybrud.Forms --configuration Release /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../releases/nuget