
LINQ={};
LINQ.exec = function(linq)
  local paramList = {};
  local ix = 1;
  return LINQ.execRecursively(linq, ix, paramList);
end;
LINQ.execRecursively = function(linq, ix, paramList)
	local finalRs = {};
	local interRs = {};
	local itemNum = #linq;
	while ix <= itemNum do
		local v = linq[ix];
		local key = v[1];
		ix = ix + 1;
		
		if key=="from" then
		  local nextIx = LINQ.getNextIndex(linq, ix);
		  
		  --获取目标集合
			local coll = v[2](unpack(paramList));
			LINQ.buildIntermediateResult(linq, ix, paramList, coll, interRs, finalRs);
			
			ix = nextIx;
		elseif key=="where" then
		  --在中间结果集上进行过滤处理
		  local temp = interRs;
		  interRs = {};
		  for i,val in ipairs(temp) do
		    if v[2](unpack(val)) then
		      table.insert(interRs, val);
		    end;
		  end;
		elseif key=="orderby" then
		  --排序（多关键字）
			table.sort(interRs, (function(l1, l2) return LINQ.compare(l1, l2, v[2]); end));
		elseif key=="select" then
		  --生成最终结果集
		  for i,val in ipairs(interRs) do
		    local r = v[2](unpack(val));
		    table.insert(finalRs, r);
		  end;
		else
			--其它子句暂不支持。。
		end;
	end;
	return finalRs;
end;
LINQ.buildIntermediateResult = function(linq, ix, paramList, coll, interRs, finalRs)
  --遍历目标集合，处理连续的let与where (这时where条件可以在单个元素遍历时进行，不用等中间结果集构建后再过滤)
	--如果又遇到from，则递归调用自身来获取子集并合并到当前结果集
	for ii,cv in ipairs(coll) do
		local newParamList = {unpack(paramList)};
		table.insert(newParamList, cv);
		local isMatch = true;
		local newIx = ix;
    local itemNum = #linq;
		while newIx <= itemNum do
			local v = linq[newIx];
			local key = v[1];
			
			if key=="let" then
				table.insert(newParamList, v[2](unpack(newParamList)));
			elseif key=="where" then
				if not v[2](unpack(newParamList)) then
				  --不符合条件的记录不放到中间结果集
					isMatch = false;
					break;
				end;
			elseif key=="from" then
			  --再次遇到from，递归调用再合并结果集
			  local ts = LINQ.execRecursively(linq, newIx, newParamList);
			  for i,val in ipairs(ts) do
			    table.insert(finalRs, val); 
			  end;
			  isMatch = false;
			  break;
			else
			  --其它子句需要在中间结果集完成后再处理，这里跳过
				break;
			end;
			newIx = newIx + 1;
		end;
		if isMatch then
			table.insert(interRs, newParamList);
		end;
	end;
end;
LINQ.compare = function(l1, l2, list)
  for i,v in ipairs(list) do
    local v1 = v[1](unpack(l1));
    local v2 = v[1](unpack(l2));
    local asc = v[2];
    if v1~=v2 then
      if asc then
        return v1<v2;
      else
        return v1>v2;
      end;
    end;
  end;
  return true;
end;
LINQ.getNextIndex = function(linq, ix)
  local itemNum = #linq;
	while ix <= itemNum do
		local v = linq[ix];
		local key = v[1];
		if key=="let" then
		elseif key=="where" then
		elseif key=="from" then
		  return itemNum + 1;
		else
		  return ix;
		end;
		ix = ix + 1;
	end;
	return ix;
end;

local vs = {1,9,6,5,3,7,2,4};
--local rs = LINQ.exec({{"from", function() return vs; end}, {"let", function(v) return v+1; end}, {"where", function(v,v2) return v>2; end}, {"orderby", {{function(v,v2) return v; end, true}}}, {"where", function(v,v2) return v<8; end}, {"select", function(v,v2) return {v1 = v, v2 = v2}; end}});
local rs; rs = LINQ.exec({{"from", (function() return vs; end)}, {"from", (function(v) return {v, v, v, v}; end)}, {"let", (function(v, vv) return v+1; end)}, {"where", (function(v, vv, v2) return (v > 1); end)}, {"let", (function(v, vv, v2) return v2 + 1; end)}, {"where", (function(v, vv, v2, v3) return (v > 4); end)}, {"where", (function(v, vv, v2, v3) return (v < 8); end)}, {"select", (function(v, vv, v2, v3) return {v1 = v, v2 = v2, v3 = v3}; end)}});
--{"orderby", {{(function(v, vv, v2, v3) return v; end), true}}}, 

for i,vs in ipairs(rs) do
  print("{");
  for k,v in pairs(vs) do
    print(" "..k.." = "..v);
  end;
  print("}");
end;

__delegation_keys = {};

function setdelegationkey(func, key, obj, member)
  rawset(__delegation_keys, func, key);
end;
function getdelegationkey(func)
  return rawget(__delegation_keys, func);
end;

local f = function() return 123; end;
setdelegationkey(f, "test");
local key = getdelegationkey(f);
print(key, type(f), f());

local tb = {
	mf = function(this)
		return f();
	end,
};

local ff = (function() local __compiler_delegation_128 = (function() return tb:mf(); end); setdelegationkey(__compiler_delegation_128, "DelegateTest:NormalEnumerator", tb, tb.mf); return __compiler_delegation_128; end)();
key = getdelegationkey(ff);
print(key, type(ff), ff());


local v = {1,nil,3};
print(#v, v[1], v[2], v[3]);

function test(a,b,c)  
  local aaa = function()
    print(a,b,c);
  end;
  aaa();
end;

for i=1,100000 do
test(1,2,3);
test(4,5,6);
end;

print();

function forward(...)
	return ...;
end;

print(forward(1,2,3));

local t = {};
local __mt_index = function(t,k)
    print("get "..tostring(t).." "..tostring(k));
end;
setmetatable(t, {__index = __mt_index});

local v = t[1]

local t1 = os.time()
local d = 0
for i=1,1000 do
d = d + 1
local k = d
end
local t2 = os.time()
print("normal:",os.difftime(t2,t1))

local t3 = os.time()
local d2 = 0
for i=1,1000 do
local k = (function() d2=d2+1;return(d2); end)()
end
local t4 = os.time()
print("functional:",os.difftime(t4,t3))

function testmr()
    return 1,2,3,4
end
local mr = {testmr()}
table.remove(mr, #mr)
print(unpack(mr))

local i
for i in pairs({1,2,3,4}) do
    print(i)
end
print("--")
print(i)

local function testho()
    return function(...) print(...) end
end

testho();

(testho)();

(function() print(123) end)()

a,b = c,d

(1+3)