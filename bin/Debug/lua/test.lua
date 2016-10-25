local a = 234;
local abc = (function() a = 123; a = a + 345; return a; end)() + 345;
print(a, abc);