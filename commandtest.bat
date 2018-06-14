@echo off
:1
git reset --hard origin/master
move /y src\com.tweirtx.TBAAPIv3client\com.tweirtx.TBAAPIv3client.nuspec.backup src\com.tweirtx.TBAAPIv3client\com.tweirtx.TBAAPIv3client.nuspec | nuget pack src\com.tweirtx.TBAAPIv3client\com.tweirtx.TBAAPIv3client.nuspec
goto :1