rem working directory
set workdir=%~dp0

cd %workdir%
Cs2Lua -xlua -ext lua -enableinherit -refbypath ..\..\dep\UnityEngine.dll -ignorepath lua -ignorepath log -src test_delegate.cs
