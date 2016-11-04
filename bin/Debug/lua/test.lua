require "cs2lua__utility";

local a = 234;
local abc = (function() a = 123; a = a + 345; return a; end)() + 345;
local a_1 = 456;
print(a, abc, a_1);

function test(cc, mm, ...)
	local args = {...};
	return args[1] + args[2];
end;

print(test(nil, "", 1, 3, 4));

local t = wrapdictionary{};

print(t.Count);

t:Add("test", 12345);