rem working directory
set workdir=%~dp0

%workdir%\Tools\Cs2Lua.exe %workdir%\Cs2LuaScript\Cs2LuaScript.csproj

xcopy %workdir%\Cs2LuaScript\lua\*.txt %workdir%\TestUnity\Assets\Slua\Resources /y /q
xcopy %workdir%\Cs2LuaScript\bin\Debug\Cs2LuaScript.dll %workdir%\TestUnity\Assets\StreamingAssets /y /q
xcopy %workdir%\Cs2LuaScript\bin\Debug\Cs2LuaUtility.dll %workdir%\TestUnity\Assets\StreamingAssets /y /q
