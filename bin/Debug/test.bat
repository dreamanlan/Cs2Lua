rem working directory
set workdir=%~dp0

cd %workdir%
Cs2Lua -ext lua -enableinherit -refbypath ..\..\dep\UnityEngine.dll -src test.cs
