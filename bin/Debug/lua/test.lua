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

function b(...)
	print(...);
end;

function a(...)
	local args = {...};
	(function() b(unpack(args)); end)();
end;

a(1,2,3,54);

local arr = wraparray{};

arr[1]=1231;
arr[2]=3456;

print(arr.Count);

--require "bit";

print("bxor:", bit.bxor(1,2));
print("bor", bit.bor(1,2));
print("band", bit.band(1,2));
print("bnot", bit.bnot(2));

local t = {abc=false};
for k,v in pairs(t) do
	print(k,v);
end;
