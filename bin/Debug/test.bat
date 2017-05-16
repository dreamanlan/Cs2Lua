rem working directory
set workdir=%~dp0

cd %workdir%
Cs2Lua -ext lua -enableinherit -enablelinq -refbypath ..\..\dep\UnityEngine.dll -src test.cs
