require "cs2lua__utility";
require "cs2lua__namespaces";

local dict = wrapdictionary{};

dict:Add(1,2);
dict:Add(3,4);
dict:Add(5,6);

print("count",dict.Count);

local b,r = dict:TryGetValue(3);
print(b,r);

setexterninstanceindexer(dict, System.Collections.Generic.Dictionary_TKey_TValue, "Item", 3, 2);
setexterninstanceindexer(dict, System.Collections.Generic.Dictionary_TKey_TValue, "Item", 7, 8);

print("count",dict.Count);

b,r = dict:TryGetValue(3);
print(b,r);

b,r = dict:TryGetValue(2);
print(b,r);

local list = wraplist{};

list:Clear();