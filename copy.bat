..\Hostx64\x64\editbin.exe /stack:40960000 bin\Debug\Cs2Lua.exe

copy /y bin\Debug\Cs2Lua.exe c:\Code\Client\Tools\cs2dsl\Cs2Lua.exe
copy /y bin\Debug\Cs2Lua.exe d:\Code\Client\Tools\cs2dsl\Cs2Lua.exe
copy /y bin\Debug\Cs2Lua.exe Test\Tools\Cs2Lua.exe
copy /y bin\Debug\lualib\cs2luatypeimpl.lua Test\Tools\lualib\cs2luatypeimpl.lua
copy /y bin\Debug\lualib\lualib.lua Test\Tools\lualib\lualib.lua
copy /y bin\Debug\lualib\cs2luatypeimpl.lua ..\Cs2Dsl\bin\Debug\lualib\cs2luatypeimpl.lua
copy /y bin\Debug\lualib\lualib.lua ..\Cs2Dsl\bin\Debug\lualib\lualib.lua

@pause
