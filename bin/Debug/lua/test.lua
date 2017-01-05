require "cs2lua__utility";
require "cs2lua__namespaces";

local dict = wrapdictionary{};

dict:Add(1,2);
dict:Add(3,4);
dict:Add(5,6);

print("count",dict.Count);

local b,r = dict:TryGetValue(3);
print(b,r);

setexterninstanceindexer(dict, nil, "set_Item", 3, 2);
setexterninstanceindexer(dict, nil, "set_Item", 7, 8);

print("count",dict.Count);

b,r = dict:TryGetValue(3);
print(b,r);

b,r = dict:TryGetValue(2);
print(b,r);

r = getexterninstanceindexer(dict, nil, "get_Item", 3);
print(r);

r = getexterninstanceindexer(dict, nil, "get_Item", 7);
print(r);

local arr = wraparray{};
arr:Add(1);
arr:Add(2);
arr:Add(3);

print("array size", arr.Length);

arr:Remove(3);
print("array size", arr.Length);

arr:Clear();