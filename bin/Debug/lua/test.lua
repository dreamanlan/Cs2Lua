require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";

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

local abc = "abcdef";
local meta = getmetatable(abc);
print(type(abc), meta);
for k,v in pairs(meta) do
  print(k,v);
end;

System.PlatformID = {
  Xbox = 1,
};
System.PlatformID.Value2String = {
  [1] = "Xbox",
};
print(System.PlatformID.Xbox);
print(invokeforbasicvalue(5, true, System.PlatformID, "ToString"));

local str="123";
local str0="";

local tab = {
  str = "",
};

System.String = setmetatable({},{
  __call = function(tb, str)
    local obj_val=str;
    return setmetatable({},{
      __index = function(t,k)
        if k=="Length" then
          print("call .Length "..type(obj_val));
          return #obj_val;
        end;
      end,
    });
  end,
});

print(getforbasicvalue(tab.str, false, System.String, "Length"));
print(getforbasicvalue(str0, false, System.String, "Length"));

local val = 18765;
print(val/2, invokespecialintegeroperator('/', val, 2, System.Int32, System.Int32));

val = -18765;
print(val/2, invokespecialintegeroperator('/', val, 2, System.Int32, System.Int32));