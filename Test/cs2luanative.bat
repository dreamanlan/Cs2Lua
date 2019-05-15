@echo off

rem working directory
set workdir=%~dp0
cd %workdir%

%workdir%\Tools\cs2lua\Cs2Lua.exe %workdir%\Cs2LuaScript\Cs2LuaScript.csproj
xcopy %workdir%\Cs2LuaScript\lua\*.txt %workdir%\TestUnity\Assets\Slua\Resources /y /q

xcopy %workdir%\Cs2LuaScript\bin\Debug\Cs2LuaScript.dll %workdir%\TestUnity\Assets\Plugins /y /q
xcopy %workdir%\Cs2LuaScript\bin\Debug\Cs2DslUtility.dll %workdir%\TestUnity\Assets\Plugins /y /q

del /a /f %workdir%\TestUnity\Assets\StreamingAssets\Cs2LuaScript.dll
del /a /f %workdir%\TestUnity\Assets\StreamingAssets\Cs2DslUtility.dll