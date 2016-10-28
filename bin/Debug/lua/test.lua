local a = 234;
local abc = (function() a = 123; a = a + 345; return a; end)() + 345;
local a_1 = 456;
print(a, abc, a_1);