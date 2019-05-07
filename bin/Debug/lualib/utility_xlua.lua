--remove comments for debug with ZeroBrane
--require "luadebug";

if not package.loading then package.loading = {} end

local rawrequire = require;
-- a chatty version of the actual import function above
function require(x)
  if package.loading[x] == nil then
    package.loading[x]=true
    --print('loading started for ' .. x)
    rawrequire(x)
    --print('loading ended for ' .. x)
    package.loading[x]=nil
  else
    --print('already loading ' .. x)
  end
end

function __basic_type_func(v)
	return v;
end;

CS = CS or {};
CS.System = CS.System or {};
CS.System.Boolean = CS.System.Boolean or __basic_type_func;
CS.System.SByte = CS.System.SByte or __basic_type_func;
CS.System.Byte = CS.System.Byte or __basic_type_func;
CS.System.Char = CS.System.Char or __basic_type_func;
CS.System.Int16 = CS.System.Int16 or __basic_type_func;
CS.System.Int32 = CS.System.Int32 or __basic_type_func;
CS.System.Int64 = CS.System.Int64 or __basic_type_func;
CS.System.UInt16 = CS.System.UInt16 or __basic_type_func;
CS.System.UInt32 = CS.System.UInt32 or __basic_type_func;
CS.System.UInt64 = CS.System.UInt64 or __basic_type_func;
CS.System.Single = CS.System.Single or __basic_type_func;
CS.System.Double = CS.System.Double or __basic_type_func;
CS.System.String = CS.System.String or __basic_type_func;
CS.System.Collections = CS.System.Collections or {};
CS.System.Collections.Generic = CS.System.Collections.Generic or {};
CS.System.Collections.Generic.List_T = {__cs2lua_defined = true, __cs2lua_fullname = "CS.System.Collections.Generic.List_T", __cs2lua_typename = "List", __exist = function(k) return false; end};
CS.System.Collections.Generic.Queue_T = {__cs2lua_defined = true, __cs2lua_fullname = "CS.System.Collections.Generic.Queue_T", __cs2lua_typename = "Queue", __exist = function(k) return false; end};
CS.System.Collections.Generic.Stack_T = {__cs2lua_defined = true, __cs2lua_fullname = "CS.System.Collections.Generic.Stack_T", __cs2lua_typename = "Stack", __exist = function(k) return false; end};
CS.System.Collections.Generic.Dictionary_TKey_TValue = {__cs2lua_defined = true, __cs2lua_fullname = "CS.System.Collections.Generic.Dictionary_TKey_TValue", __cs2lua_typename = "Dictionary", __exist = function(k) return false; end};
CS.System.Collections.Generic.HashSet_T = {__cs2lua_defined = true, __cs2lua_fullname = "CS.System.Collections.Generic.HashSet_T", __cs2lua_typename = "HashSet", __exist = function(k) return false; end};
CS.System.Array = CS.System.Array or {};

CS.System.Collections.Generic.MyDictionary_TKey_TValue = CS.System.Collections.Generic.Dictionary_TKey_TValue;

__cs2lua_out = {};
__cs2lua_nil_field_value = {};

Cs2LuaLibrary = {
	ToString = function(T, val)
		return tostring(val);
	end,
};

TypeKind = {
	Unknown = 0,
	Array = 1,
	Class = 2,
	Delegate = 3,
	Dynamic = 4,
	Enum = 5,
	Error = 6,
	Interface = 7,
	Module = 8,
	Pointer = 9,
	Struct = 10,
	Structure = 10,
	TypeParameter = 11,
	Submission = 12
};

MethodKind = {
	AnonymousFunction = 0,
	LambdaMethod = 0,
	Constructor = 1,
	Conversion = 2,
	DelegateInvoke = 3,
	Destructor = 4,
	EventAdd = 5,
	EventRaise = 6,
	EventRemove = 7,
	ExplicitInterfaceImplementation = 8,
	UserDefinedOperator = 9,
	Ordinary = 10,
	PropertyGet = 11,
	PropertySet = 12,
	ReducedExtension = 13,
	StaticConstructor = 14,
	SharedConstructor = 14,
	BuiltinOperator = 15,
	DeclareMethod = 16,
	LocalFunction = 17
};

function getobjfullname(obj)
	local meta = getmetatable(obj);
	if meta then
		if rawget(meta, "__cs2lua_defined") then
			return rawget(meta, "__cs2lua_fullname");
		else
			local name = rawget(meta, "__fullname");
			local ix = string.find(name, ",");
			if ix==nil then
				return name;
			else
				return string.sub(name, 1, ix-1);
			end;
		end;
	else
		return nil;
	end;
end;

function getobjtypename(obj)
	local meta = getmetatable(obj);
	if meta then
		if rawget(meta, "__cs2lua_defined") then
			return rawget(meta, "__cs2lua_typename");
		else
			return rawget(meta, "__typename");
		end;
	else
		return nil;
	end;
end;

function getclassfullname(t)
	if t then
		if rawget(t, "__cs2lua_defined") then
			return rawget(t, "__cs2lua_fullname");
		else
			local name = rawget(t, "__fullname");
			local ix = string.find(name, ",");
			if ix==nil then
				return name;
			else
				return string.sub(name, 1, ix-1);
			end;
		end;
	else
		return nil;
	end;
end;

function getclasstypename(t)
	if t then
		if rawget(t, "__cs2lua_defined") then
			return rawget(t, "__cs2lua_typename");
		else
			return rawget(t, "__typename");
		end;
	else
		return nil;
	end;
end;

function getobjparentclass(obj)
	local meta = getmetatable(obj);
	if meta then
		if rawget(meta, "__cs2lua_defined") then
			return rawget(meta, "__cs2lua_parent");
		else
			return rawget(meta, "__parent");
		end;
	else
		return nil;
	end;
end;

function getclassparentclass(t)
	if t then
		if rawget(t, "__cs2lua_defined") then
			return rawget(t, "__cs2lua_parent");
		else
			return rawget(t, "__parent");
		end;
	else
		return nil;
	end;
end;

function settempmetatable(class)
	setmetatable(class, { 
		__index = function(tb, key) 
			setmetatable(class, nil);
			class.__define_class();
			return tb[key]; 
		end, 
		__newindex = function(tb,key,val) 
			setmetatable(class, nil);
			class.__define_class();
			tb[key]=val;
		end,
		__call = function(...) 
			setmetatable(class, nil);
			class.__define_class();
			return class(...);
		end
	});
end;

__cs2lua_special_integer_operators = { "/", "%", "+", "-", "*", "<<", ">>", "&", "|", "^", "~" };
__cs2lua_div = 0;
__cs2lua_mod = 1;
__cs2lua_add = 2;
__cs2lua_sub = 3;
__cs2lua_mul = 4;
__cs2lua_lshift = 5;
__cs2lua_rshift = 6;
__cs2lua_bitand = 7;
__cs2lua_bitor = 8;
__cs2lua_bitxor = 9;
__cs2lua_bitnot = 10;

function lshift(v,n)
  if bit then
    return bit.lshift(v,n);
  else
    for i=1,n do
        v=v*2;
    end;
    return v;
  end;
end;

function rshift(v,n)
  if bit then
    return bit.rshift(v,n);
  else
    for i=1,n do
        v=v/2;
    end;
    return v;
  end;
end;

function condexp(cv, tfIsConst, tf, ffIsConst, ff)
    if cv then
      if tfIsConst then
        return tf;
      else
        return tf();
      end;
    else
      if ffIsConst then
        return ff;
      else
        return ff();
      end;
    end;
end;

function condaccess(v, func)
	return v and func();
end;

function nullcoalescing(v, isConst, func)
  if v then
    return v;
	else
    if isConst then
	    return func;
	  else
	    return func();
	  end;	  
	end;
end;

function bitnot(v)
  if bit then
    return bit.bnot(v);
  else
	  return 0;
	end;
end;

function bitand(v1,v2)
  if bit then
    return bit.band(v1,v2);
  else
	  return 0;
	end;
end;

function bitor(v1,v2)
  if bit then
    return bit.bor(v1,v2);
  else
	  return 0;
  end;
end;

function bitxor(v1,v2)
  if bit then
    return bit.bxor(v1,v2);
  else
	  return 0;
	end;
end;

function typecast(obj, t, tk)
	if t == CS.System.String then
		return tostring(obj);
	elseif t == CS.System.Single or t ==	CS.System.Double then
	  return tonumber(obj);
	elseif t == CS.System.Int64 or t == CS.System.UInt64 then
	  local v = tonumber(obj);
	  v = math.floor(v);
	  return v;
	elseif t == CS.System.Int32 or t == CS.System.UInt32 then
	  local v = tonumber(obj);
	  v = math.floor(v);
	  if v > 0 then
	    v = v % 0x100000000;
	  elseif v < 0 then
	    v = -((-v) % 0x100000000);
	  end;
	  if t==CS.System.Int32 and v>0x7fffffff then
	    v = v - 0xffffffff - 1;
	  end;
	  return v;
	elseif t == CS.System.Int16 or t == CS.System.UInt16 or t == CS.System.Char then
	  local v = tonumber(obj);
	  v = math.floor(v);
	  if v > 0 then
	    v = v % 0x10000;
	  elseif v < 0 then
	    v = -((-v) % 0x10000);
	  end;
	  if t==CS.System.Int16 and v>0x7fff then
	    v = v - 0xffff - 1;
	  end;
	  return v;
	elseif t == CS.System.SByte or t == CS.System.Byte then
	  local v = tonumber(obj);
	  v = math.floor(v);
	  if v > 0 then
	    v = v % 0x100;
	  elseif v < 0 then
	    v = -((-v) % 0x100);
	  end;
	  if t==CS.System.SByte and v>0x7f then
	    v = v - 0xff - 1;
	  end;
	  return v;
	elseif t == CS.System.Boolean then
		return obj;
	elseif tk == TypeKind.Enum then
	  return obj;
	elseif typeis(obj, t, tk) then
		return obj;
	else
  	return obj;
 	end;
end;

function typeas(obj, t, tk)
	if t == CS.System.String then
		return tostring(obj);
	elseif t == CS.System.Single or t ==	CS.System.Double then
	  return tonumber(obj);
	elseif t == CS.System.Int64 or t == CS.System.UInt64 then
	  local v = tonumber(obj);
	  v = math.floor(v);
	  return v;
	elseif t == CS.System.Int32 or t == CS.System.UInt32 then
	  return typecast(obj, t, tk);
	elseif t == CS.System.Int16 or t == CS.System.UInt16 or t == CS.System.Char then
	  return typecast(obj, t, tk);
	elseif t == CS.System.SByte or t == CS.System.Byte then
	  return typecast(obj, t, tk);
	elseif t == CS.System.Boolean then
		return obj;
	elseif tk==TypeKind.Enum then
	  return obj;
	elseif typeis(obj, t, tk) then
		return obj;
	else
		return nil;
 	end;
end;

function __typeis_check_xlua(objType, t)
	local tType = typeof(t);
	if objType == tType then
		return true;
	end
	if tType:IsAssignableFrom(objType) then
		return true;
	end
	return false;
end

function typeis(obj, t, tk)
	local meta = getmetatable(obj);
  local tn1 = getobjfullname(obj);
  local tn2 = getclassfullname(t);
	local intfsname = nil;
	if meta then
		if type(obj)=="userdata" then
			return __typeis_check_xlua(obj:GetType(), t);
		else
			if rawget(meta, "__class") == t then
				return true;
			end;
			local intfs = rawget(meta, "__interfaces");
			if intfs then
				intfsname = tn2;
				if intfsname ~= nil then
					for i,v in ipairs(intfs) do
						if v == intfsname then
							return true;
						end;
					end;
				end
			end;
			--check cs2lua base class chain
			local baseClass = rawget(meta, "__cs2lua_parent");
			local lastCheckedClass = meta;
			intfsname = tn2;
			while baseClass ~= nil do
				if baseClass == t then
					return true;
				end;
				intfs = rawget(meta, "__interfaces");
				if intfs ~= nil and intfsname ~= nil then
					for i,v in ipairs(intfs) do
						if v == intfsname then
							return true;
						end;
					end;
				end;
				if rawget(baseClass, "__cs2lua_defined") then
					baseClass = rawget(baseClass, "__cs2lua_parent");
				else
					lastCheckedClass = baseClass;
					break;
				end;
			end;
			--try xlua base class and parent metatable chain
			if not rawget(lastCheckedClass, "__cs2lua_defined") then
				return __typeis_check_xlua(typeof(lastCheckedClass), t);
			end;
		end;
	end;
	return false;
end;

function __do_eq(v1,v2)
	return v1==v2;
end;

function isequal(v1,v2)
	local succ, res = pcall(__do_eq,v1,v2);
	if succ then
		return res;
	else
		return rawequal(v1,v2);
	end;
end;

function __wrap_if_string(val)
  if type(val)=="string" then
    return CS.System.String(val);
  else
    return val;
  end;
end;

function __unwrap_if_string(val)
  local meta = getmetatable(val);
  if type(val)=="userdata" and rawget(meta, "__typename")=="String" then
    return tostring(val);
  else
    return val;
  end;
end;

function __calc_table_count(tb)
  local count = 0;
  for k,v in pairs(tb) do
    count = count+1;
  end;
  return count;
end;

function __set_table_count(tb, count)
  local meta = getmetatable(tb);
  if meta then
    meta.__count = count;
  end;
end;

function __get_table_count(tb)
  local count = 0;
  local meta = getmetatable(tb);
  if meta then
    if meta.__count then
      count = meta.__count;
    else
      count = __calc_table_count(tb);
      meta.__count = count;
    end;
  end;
  return count;
end;

function __inc_table_count(tb)
  local meta = getmetatable(tb);
  if meta then
  	if nil ~= meta.__count then
	    meta.__count = meta.__count + 1;
	  else
	  	meta.__count = __calc_table_count(tb);
	  end;
	end;
end;

function __dec_table_count(tb)
  local meta = getmetatable(tb);
  if meta then
  	if meta.__count and meta.__count > 0 then
    	meta.__count = meta.__count - 1;    
    else
    	meta.__count = __calc_table_count(tb);
    end;
  end;
end;

function __clear_table(tb)
  local keys={};
  for k,v in pairs(tb) do
    table.insert(keys,k);
  end;
  for i,v in ipairs(keys) do
    tb[v]=nil;
  end;
  local meta = getmetatable(tb);
  if meta then
    meta.__count = 0;
  end;
end;

function __wrap_table_field(v)
	if nil==v then
		return __cs2lua_nil_field_value;
	else
		return v;
	end;
end;

function __unwrap_table_field(v)
	if __cs2lua_nil_field_value==v then
		return nil;
	else
		return v;
	end;
end;

function __set_array_count(tb, count)
  local meta = getmetatable(tb);
  if meta then
    meta.__count = count;
  end;
end;

function __get_array_count(tb)
  local count = 0;
  local meta = getmetatable(tb);
  if meta then
    if meta.__count then
      count = meta.__count;
    else
      count = #tb;
      meta.__count = count;
    end;
  end;
  return count;
end;

function __inc_array_count(tb)
  local meta = getmetatable(tb);
  if meta then
  	if nil ~= meta.__count then
	    meta.__count = meta.__count + 1;
	  else
	  	meta.__count = #tb;
	  end;
	end;
end;

function __dec_array_count(tb)
  local meta = getmetatable(tb);
  if meta then
  	if meta.__count and meta.__count > 0 then
    	meta.__count = meta.__count - 1;    
    else
    	meta.__count = #tb;
    end;
  end;
end;

__mt_index_of_array = function(t, k)
  if k=="__exist" then --禁用继承
    return function(tb,fk) return false; end;
	elseif k=="Length" or k=="Count" then
		return __get_array_count(t);
	elseif k=="GetLength" then
		return function(obj, ix)
      local ret = 0;
      local tb = obj;
      for i=0,ix do			       
        ret = __get_array_count(tb);
        tb = rawget(tb,0);
      end;
      return ret;
    end;
  elseif k=="Add" then
    return function(obj, v) table.insert(obj, v);__inc_array_count(obj); end;
  elseif k=="Remove" then
    return function(obj, p)
    	local pos = 0;
      local ret = nil;
    	local ct = __get_array_count(obj);
      for i = 1,ct do
        local v = rawget(obj,i);
        if isequal(v,p) then
        	pos = i;
          ret=v;
          break;
        end;
      end;
      if ret then
        table.remove(obj,pos);
        __dec_array_count(obj);
      end;
      return ret;
    end;
  elseif k=="RemoveAt" then
    return function(obj, ix)
      table.remove(obj, ix+1);
      __dec_array_count(obj);
    end;
  elseif k=="RemoveAll" then
    return function(obj, pred)
    	local deletes = {};
    	local ct = __get_array_count(obj);
      for i = 1,ct do		        
        if pred(rawget(obj,i)) then
        	table.insert(deletes, i);
        end;
      end;
      for i,v in ipairs(deletes) do
      	table.remove(obj, v);
      	__dec_array_count(obj);
      end;
    end;
  elseif k=="AddRange" then
    return function(obj, coll)
      local enumer = coll:GetEnumerator();
      while enumer:MoveNext() do
        table.insert(obj, enumer.Current);
        __inc_array_count(obj);
      end;
    end;
  elseif k=="Insert" then
    return function(obj, ix, p)
      table.insert(obj,ix+1,p);
      __inc_array_count(obj);
    end;
  elseif k=="IndexOf" then
	  return function(obj, p)
    	local ct = __get_array_count(obj);
      for i = 1,ct do
        local v = rawget(obj,i);
        if v==p then	          
          return i-1;
        end;
      end;
      return -1;
    end;
  elseif k=="LastIndexOf" then
	  return function(obj, p)
    	local ct = __get_array_count(obj);
      for k=ct,1 do
        local v = rawget(obj,k);
        if v==p then	          
          return k-1;
        end;
      end;
      return -1;
    end;
  elseif k=="FindIndex" then
  	return function(obj, predicate)
    	local ct = __get_array_count(obj);
      for i = 1,ct do
        local v = rawget(obj,i);
  			if predicate(v) then
  				return i-1;
  			end
  		end
  		return -1;
  	end;
  elseif k=="Find" then
  	return function(obj, predicate)
    	local ct = __get_array_count(obj);
      for i = 1,ct do
        local v = rawget(obj,i);
  			if predicate(v) then
  				return v;
  			end
  		end
  		return nil;
  	end;
  elseif k=="Contains" then
	  return function(obj, p)
      local ret = false;
    	local ct = __get_array_count(obj);
      for i = 1,ct do
        local v = rawget(obj,i);
        if v==p then
          ret=true;
          break;
        end;
      end;
      return ret;
    end;
  elseif k=="Peek" then    
    return function(obj)
    	local ct = __get_array_count(obj);
      local v = rawget(obj,ct);
      return v;
    end;
  elseif k=="Enqueue" then
    return function(obj,v)
      table.insert(obj,1,v);
      __inc_array_count(obj);
    end;
  elseif k=="Dequeue" then
    return function(obj)
    	local ct = __get_array_count(obj);
      local v = rawget(obj,ct);
      table.remove(obj,ct);
      __dec_array_count(obj);
      return v;
    end;
  elseif k=="Push" then
    return function(obj,v)
      table.insert(obj,v);
      __inc_array_count(obj);
    end;
  elseif k=="Pop" then
    return function(obj)
    	local ct = __get_array_count(obj);
      local v = rawget(obj,ct);
      table.remove(obj,num);
      __dec_array_count(obj);
      return v;
    end;
  elseif k=="CopyTo" then
    return function(obj, arr)
    	local ct = __get_array_count(obj);
      for k = 1,ct do
        arr[k] = rawget(obj,k);
      end;
    end;
  elseif k=="ToArray" then
    return function(obj)
    	local ct = __get_array_count(obj);
      local ret = wraparray({}, ct);
      for k = 1,ct do
        ret[k] = rawget(obj,k);
      end;
      return ret;
    end;
  elseif k=="Clear" then
    return function(obj)
    	local ct = __get_array_count(obj);
    	for i = ct,1,-1 do
    		table.remove(obj, i);
    	end;
    	__set_array_count(obj, 0);
    end;
  elseif k=="GetEnumerator" then
    return function(obj)
      return GetArrayEnumerator(obj);
    end
  elseif k=="Sort" then
		return function(obj, predicate)
		  table.sort(obj, function(a, b) return predicate(a, b) < 0 end);
		end
  elseif k=="GetType" then
   	return function(obj)
   		local meta = getmetatable(obj);   		
   		return meta.__class;
   	end;
  end
end;

__mt_index_of_dictionary = function(t, k)
	if k=="__exist" then --禁用继承
    return function(tb,fk) return false; end;
	elseif k=="Count" then
		return __get_table_count(t);
	elseif k=="Add" then
	  return function(obj, p1, p2)
	    p1 = __unwrap_if_string(p1);		    
	    rawset(obj, p1, { value=p2 });
	    __inc_table_count(obj);
	    return p2;
	  end;
	elseif k=="Remove" then
	  return function(obj, p)
	    p = __unwrap_if_string(p);
	    local v = rawget(obj,p);
	    local ret = nil;
	    if v then
	      ret = v.value;
        rawset(obj, p, nil);
      end;
      __dec_table_count(obj);
      return ret;
    end;
	elseif k=="ContainsKey" then
	  return function(obj, p)
	    p = __unwrap_if_string(p);
      if rawget(obj,p) then
        return true;
      end;
      return false;
    end;
	elseif k=="ContainsValue" then
	  return function(obj, p)
      local ret = false;
      for k,v in pairs(obj) do		        
        if v.value==p then
          ret=true;
          break;
        end;
      end;
      return ret;
    end;		    
  elseif k=="TryGetValue" then
    return function(obj, p)
	    p = __unwrap_if_string(p);
      local v = rawget(obj,p);
      if v then
        return true, v.value;
      end;
      return false, nil;
    end;
  elseif k=="Keys" then
    local ret = wraparray{};
    for k,v in pairs(t) do
      k = __wrap_if_string(k);
      table.insert(ret, k);
      __inc_array_count(ret);
    end;
    return ret;
  elseif k=="Values" then
    local ret = wraparray{};
    for k,v in pairs(t) do
      table.insert(ret, v.value);
      __inc_array_count(ret);
    end;
    return ret;
  elseif k=="Clear" then
  	return function(obj)
  	  __clear_table(obj);
  	end;
  elseif k=="GetEnumerator" then
    return function(obj)
      return GetDictEnumerator(obj);
    end;
  elseif k=="GetType" then
   	return function(obj)
   		local meta = getmetatable(obj);   		
   		return meta.__class;
   	end;
  else
    local v = rawget(t,k);
    if v then
  	  return v.value;
    end;
    return nil;    
	end;
end;

__mt_newindex_of_dictionary = function(t, k, val)  
  local v = rawget(t,k);
  if not v then
	  __inc_table_count(t);
  end;
  rawset(t, k, { value = val });
end;

__mt_index_of_hashset = function(t, k)
	if k=="__exist" then --禁用继承
    return function(tb,fk) return false; end;
	elseif k=="Count" then
		return __get_table_count(t);
	elseif k=="Add" then
	  return function(obj, p)
	    p = __unwrap_if_string(p);
	    rawset(obj, p, true);
	    __inc_table_count(obj);
	    return true;
	  end;
	elseif k=="Remove" then
	  return function(obj, p)
	    p = __unwrap_if_string(p);
	    local ret = rawget(obj,p);
	    if ret then
        rawset(obj, p, nil);
      end;
      __dec_table_count(obj);
      return ret;
    end;
	elseif k=="Contains" then
	  return function(obj, p)
	    p = __unwrap_if_string(p);
      if rawget(obj,p) then
        return true;
      end;
      return false;
    end;
  elseif k=="CopyTo" then
    return function(obj, arr)
      for k,v in pairs(obj) do
	      k = __wrap_if_string(k);
        table.insert(arr,k);
      end;
    end;
  elseif k=="Clear" then
  	return function(obj)
  	  __clear_table(obj);
  	end;
  elseif k=="GetEnumerator" then
    return function(obj)
      return GetHashsetEnumerator(obj);
    end;
  elseif k=="GetType" then
   	return function(obj)
   		local meta = getmetatable(obj);   		
   		return meta.__class;
   	end;
	end;
end;

__mt_delegation = {
  __is_delegation = true,
  __call = function(t, ...)
    local ret = nil;
    for k,v in pairs(t) do
      if v then
        ret = v(...);
      end;
    end;
    return ret;
  end,
};

function GetArrayEnumerator(tb)
  return setmetatable({
    MoveNext = function(this)
      local tb = this.object;
      local num = __get_array_count(tb);
      if this.index < num then
        this.index = this.index + 1;
        this.current = rawget(tb,this.index);
        return true;
      else
        return false;
      end;
    end,
    object = tb,
    index = 0,
    current = nil,
  },{
    __index = function(t, k)
      if k=="Current" then
        return t.current;
      end;
      return nil;
    end,
  });
end;

function GetDictEnumerator(tb)
  return setmetatable({
    MoveNext = function(this)
      local tb = this.object;
      local v = nil;
      this.key, v = next(tb, this.key);
      this.current = {
        Key = __wrap_if_string(this.key),
        Value = v and v.value,
      };
      if this.key then
        return true;
      else
        return false;
      end;
    end,
    object = tb,
    key = nil,
    current = nil,
  },{
    __index = function(t, k)
      if k=="Current" then
        return t.current;
      end;
      return nil;
    end,
  });
end;

function GetHashsetEnumerator(tb)
  return setmetatable({
    MoveNext = function(this)
      local tb = this.object;
      local v = nil;
      this.key, v = next(tb, this.key);      
      if this.key then
        return true;
      else
        return false;
      end;
    end,
    object = tb,
    key = nil,
  },{
    __index = function(t, k)
      if k=="Current" then
        return __wrap_if_string(t.key);
      end;
      return nil;
    end,
  });
end;

function wrapconst(t, name)
  if name then
    return t[name];
  else
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
  end;
  return nil;
end;

function wrapchar(char, intVal)
  if intVal>0 then
    return intVal;
  else
    local str = tostring(char);
    local l = string.len(str);
    if l==1 then
      local first = string.byte(str,1,1);
      return first;
    elseif l==2 then
      local first = string.byte(str,1,1);
      local second = string.byte(str,2,2);
      return first+second*0x100;
    else
      return 0;
    end;
  end;
end;

function wraparray(arr, size)
  if not size then
    size = #arr;
  end;
	return setmetatable(arr, { __index = __mt_index_of_array, __count = size, __cs2lua_defined = true, __class = CS.System.Collections.Generic.List_T });
end;

function wrapdictionary(dict)
  local obj = {};
  setmetatable(obj, { __index = __mt_index_of_dictionary, __newindex = __mt_newindex_of_dictionary, __cs2lua_defined = true, __class = CS.System.Collections.Generic.Dictionary_TKey_TValue });
	for k,v in pairs(dict) do
	  obj:Add(k, v);
	end;
  return obj;
end;

function wrapdelegation(handlers)
  return setmetatable(handlers, __mt_delegation);
end;

function wrapenumerable(func)
	return function(...)
		local args = {...};
		return WrapEnumerator(coroutine.create(function()
			func(table.unpack(args));
		end));
	end;
end;

function wrapyield(yieldVal, isEnumerableOrEnumerator, isUnityYield)
	Yield(yieldVal);
end;

LuaConsole = {
  Write = function(...)
    io.write(...);
  end,
  Print = function(...)
  	print(...);
  end,
};

function wrapvaluetype(v)
	return v;
end;

function wrapvaluetypearray(arr)
	for i,v in ipairs(arr) do
		arr[i]=wrapvaluetype(v);
	end;
	local size = #arr;
	return setmetatable(arr, { __index = __mt_index_of_array, __Count = size, __cs2lua_defined = true, __class = CS.System.Collections.Generic.List_T });
end;

function wrapexternvaluetype(v)
	return v;
end;

function wrapexternvaluetypearray(arr)
	for i,v in ipairs(arr) do
		arr[i]=wrapexternvaluetype(v);
	end;
	local size = #arr;
	return setmetatable(arr, { __index = __mt_index_of_array, __Count = size, __cs2lua_defined = true, __class = CS.System.Collections.Generic.List_T });
end;

function defineclass(base, fullName, typeName, static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, class_info, method_info, property_info, event_info, field_info, is_value_type)
    local base_class = base;
    local mt = getmetatable(base_class);

    local class = static or {};
    for ck,cv in pairs(static_methods) do
      rawset(class, ck, cv);
    end;
    local class_fields;
    if static_fields_build then
      class_fields = static_fields_build();
    else
      class_fields = {};
    end;
    local class_props = static_props or {};
    local class_events = static_events or {};
    rawset(class, "__cs2lua_defined", true);
    rawset(class, "__cs2lua_fullname", fullName);
    rawset(class, "__cs2lua_typename", typeName);
    rawset(class, "__cs2lua_parent", base_class);
    rawset(class, "__is_value_type", is_value_type);
    rawset(class, "__interfaces", interfaces);
    rawset(class, "__interface_map", interface_map);
        
    local function __find_base_class_key(k)
      if nil==k then
        CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
        return false;
      end;
      if base_class then
        if rawget(base_class, "__cs2lua_defined") then
          local r,v = pcall(function() return base_class.__exist(k); end);
          if r then
            return v;
          end;
        else
          local r,ret = pcall(function() return base_class[k]; end);
          if r then
            return true;
          end;
        end;
      end;
      return false;
    end;        
    local function __find_class_key(k)
      if nil==k then
        CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
        return false;
      end;
      local ret;
      ret = rawget(class, k);
      if nil~=ret then
        return true;
      end;
      ret = class_fields[k];
      if nil~=ret then
        return true;
      end;
      ret = class_props[k];
      if nil~=ret then
        return true;
      end;
      ret = class_events[k];
      if nil~=ret then
        return true;
      end;
      return __find_base_class_key(k);
    end;
    local function __wrap_virtual_method(k, f)
    	return function(this, ...)
        local child = rawget(this, "__child__");
        while child do
          local nf = rawget(child, k);
          if nf then
            return nf(child, ...);
          end
          child = rawget(child, "__child__");
        end
        return f(this, ...);
    	end;
    end;
    
    setmetatable(class, {
        __call = function()
      			local baseObj = nil;
      			if base_class == CS.UnityEngine.MonoBehaviour then
      				baseObj = nil;
      			elseif mt then
      				baseObj = mt.__call();
      			end;
            local obj = {};
						for k,v in pairs(instance_methods) do
							local minfo = method_info[k];
							if not minfo then
								obj[k] = v;
								if k~="__ctor" then
									UnityEngine.Debug.LogError("can't found method "..tostring(k));
								end;
							else
								if minfo["abstract"] or minfo["virtual"] or minfo["override"] then
									obj[k] = __wrap_virtual_method(k, v);
								else									
									obj[k] = v;
								end;
								if k=="ctor" or ((not minfo["private"]) and (not minfo["sealed"])) then
									obj["__self__"..k] = v;
								end;
							end;
						end;
            local obj_fields;
            if instance_fields_build then
              obj_fields = instance_fields_build();
            else
              obj_fields = {};
            end;
            local obj_props = instance_props or {};
            local obj_events = instance_events or {};
            local obj_intf_map = interface_map or {};
            
            obj["base"] = baseObj;
            if baseObj then
            	baseObj["__child__"] = obj;
            end;
            
            local function __find_base_obj_key(k)
              if nil==k then
                CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
                return false;
              end;
              if baseObj then
                local meta = getmetatable(baseObj);
                if meta and rawget(meta, "__cs2lua_defined") then
                  local r,v = pcall(function() return baseObj:__exist(k); end);
                  if r then
                    return v;
                  end;
                else
                  local r, ret = pcall(function() return baseObj[k]; end);
                  if r then
                    return true;
                  end;
                end;
              end;
              return false;
            end;
            local function __find_obj_key(k)
              if nil==k then
                CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
                return false;
              end;
              local ret;
              ret = rawget(obj, k);
              if nil~=ret then
                return true;
              end;
              ret = obj_fields[k];
              if nil~=ret then
                return true;
              end;
              ret = obj_props[k];
              if nil~=ret then
                return true;
              end;
              ret = obj_events[k];
              if nil~=ret then
                return true;
              end;
              local nk = obj_intf_map[k];
              if nil~=nk then
                ret = obj_fields[nk];
                if nil~=ret then
                  return true;
                end;
                ret = obj_props[nk];
                if nil~=ret then
                  return true;
                end;
                ret = obj_events[nk];
                if nil~=ret then
                  return true;
                end;
              end;
              return __find_base_obj_key(k);
            end;
			
			local function __is_monobehaviour_instance(self)
				local mt = getmetatable(self)
				if mt == nil then
					return false;
				end
				
				local clsTbl = mt.__class;
				local baseTbl = clsTbl.__parent;
				
				if baseTbl == CS.UnityEngine.MonoBehaviour then
					return true;
				end
				
				return false;
			end
            
            setmetatable(obj, {
                __class = class,
                __cs2lua_defined = true,
                __cs2lua_fullname = fullName,
                __cs2lua_typename = typeName,
                __cs2lua_parent = base_class,
                __is_value_type = is_value_type,
                __interfaces = interfaces,
                __interface_map = interface_map,
                __index = function(t, k)
                    if k=="__exist" then
                      return function(tb, fk) return __find_obj_key(fk); end;
                    end;
                    if nil==k then
                      CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
                      return nil;
                    end;
                    local ret;
                    ret = obj_fields[k];
                    if nil~=ret then
                      return __unwrap_table_field(ret);
                    end;
                    ret = obj_props[k];
                    if nil~=ret then
                      if ret.get then
                        ret = ret.get(t);
                      else
                        ret = nil;
                      end;
                      return ret;
                    end;
                    ret = obj_intf_map[k];
                    if nil~=ret then
                      ret = obj_fields[ret];
                      if nil~=ret then
                        return ret;
                      end;
                      ret = obj_props[ret];
                      if nil~=ret then
                        if ret.get then
                          ret = ret.get(t);
                        else
                          ret = nil;
                        end;
                        return ret;
                      end;
                    end;
                    if __find_base_obj_key(k) then
                      ret = baseObj[k];					
					  if type(ret) == 'function' and __is_monobehaviour_instance(t) then
						
							function __call_with_monobehaviour(obj, ...)
								return ret(obj.MonoBehaviour, ...);
							end
							return __call_with_monobehaviour;
						--return function(obj, ...)
						--	return ret(obj.MonoBehaviour, ...)
						--end
					  end
					
                      return ret;
                    end;
                    --简单支持反射方法:GetType()
                    if k=="GetType" then
                      return function(tb) return class; end;
                    end;
                    return ret;
                end,

                __newindex = function(t, k, v)
                    if nil==k then
                      CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
                      return;
                    end;
                    local ret;
                    ret = obj_fields[k];
                    if nil~=ret then
                      obj_fields[k] = __wrap_table_field(v);
                      return;
                    end;
                    ret = obj_props[k];
                    if nil~=ret then
                      if ret.set then
                        ret.set(t, v);
                      end;
                      return;
                    end;
                    ret = obj_intf_map[k];
                    if nil~=ret then
                      ret = obj_props[ret];
                      if nil~=ret then
                        if ret.set then
                          ret.set(t, v);
                        end;
                        return;
                      end;
                    end;
                    if __find_base_obj_key(k) then
                      baseObj[k] = v;
                      return;
                    end;
                    rawset(t, k, v);
                end,
        
                __setbase = function(self, base)
                  baseObj = base;
                end,              
            });

            return obj;
        end,
        
        __index = function(t, k)
            if k=="__exist" then
              return function(fk) return __find_class_key(fk); end;
            end;
            if nil==k then
              CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
              return nil;
            end;
            local ret;
            ret = class_fields[k];
            if nil~=ret then
              return __unwrap_table_field(ret);
            end;
            ret = class_props[k];
            if nil~=ret then
              if ret.get then
                ret = ret.get(t);
              else
                ret = nil;
              end;
              return ret;
            end;
            if __find_base_class_key(k) then
              ret = base_class[k];
              return ret;
            end;
            --简单支持反射的属性:Type.Name与Type.FullName            
            if k=="Name" then
              ret = typeName;
            elseif k=="FullName" then
              ret = fullName;
            end;
            return ret;
        end,

        __newindex = function(t, k, v)
            if nil==k then
              CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
              return;
            end;
            local ret;
            ret = class_fields[k];
            if nil~=ret then
              class_fields[k] = __wrap_table_field(v);
              return;
            end;
            ret = class_props[k];
            if nil~=ret then
              if ret.set then
                ret.set(t, v);
              end;
              return;
            end;
            if __find_base_class_key(k) then
              base_class[k] = v;
              return;
            end;
            rawset(t, k, v);
        end,
    });
    if class.cctor then
      class.cctor();
    end;
    return class;
end;

function newobject(class, typeargs, typekinds, ctor, initializer, ...)
  local obj = class();
  if ctor then
    obj[ctor](obj, ...);
  end;
  if obj and initializer then
  	initializer(obj);
  end;
  return obj;
end;

function newexternobject(class, typeargs, typekinds, initializer, ...)
  local obj = class(...);
  if obj and initializer then
  	initializer(obj);
  end;
  return obj;
end;

function newtypeparamobject(t)
  if rawget(t, "__cs2lua_defined") then
    local obj = t();
    if obj.ctor then
      obj:ctor();
    end;
    return obj;
  else
    return t();
  end;
end;

function newdictionary(t, typeargs, typekinds, ctor, dict, ...)
  if dict then
    local obj = {};
	  setmetatable(obj, { __index = __mt_index_of_dictionary, __newindex = __mt_newindex_of_dictionary, __cs2lua_defined = true, __class = t });
		for k,v in pairs(dict) do
		  obj:Add(k, v);
		end;
    return obj;
	end;
end;

function newlist(t, typeargs, typekinds, ctor, list, ...)
  if list then
    return setmetatable(list, { __index = __mt_index_of_array, __cs2lua_defined = true, __class = t });
  end;
end;

function newcollection(t, typeargs, typekinds, ctor, coll, ...)
  if coll then
    return setmetatable(coll, { __index = __mt_index_of_hashset, __cs2lua_defined = true, __class = t });
  end;
end;

function newexterndictionary(t, typeargs, typekinds, dict, ...)
  if dict and t==System.Collections.Generic.Dictionary_TKey_TValue then
    local obj = {};
	  setmetatable(obj, { __index = __mt_index_of_dictionary, __newindex = __mt_newindex_of_dictionary, __cs2lua_defined = true, __class = t });
		for k,v in pairs(dict) do
		  obj:Add(k, v);
		end;
    return obj;
	else	  
	  local obj = t(...);
	  if obj then
			if dict ~= nil then
				for k,v in pairs(dict) do
				  obj:Add(k, v);
				end;
			end
	    return obj;
	  else
	    return nil;
	  end;
	end;
end;

function newexternlist(t, typeargs, typekinds, list, ...)
  if list and t==CS.System.Collections.Generic.List_T then    
	  return setmetatable(list, { __index = __mt_index_of_array, __cs2lua_defined = true, __class = t });
	else 
	  local obj = t(...);
	  if obj then
			if list ~= nil then
				for i,v in ipairs(list) do
				  obj:Add(v);
				end;
			end
	    return obj;
	  else
	    return nil;
	  end;
  end;
end;

function newexterncollection(t, typeargs, typekinds, coll, ...)
  if coll and (t==CS.System.Collections.Generic.Queue_T or t==CS.System.Collections.Generic.Stack_T) then
    return setmetatable(coll, { __index = __mt_index_of_array, __cs2lua_defined = true, __class = t });
  elseif coll and t==CS.System.Collections.Generic.HashSet_T then
    return setmetatable(coll, { __index = __mt_index_of_hashset, __cs2lua_defined = true, __class = t });
	else
	  local obj = t(...);
	  if obj then
			if coll ~= nil then
				for i,v in ipairs(coll) do
				  obj:Add(v);
				end;
			end
	    return obj;
	  else
	    return nil;
	  end;
  end;
end;

__delegation_keys = {};

local function __get_obj_string(obj)
  if type(obj) == "table" then
    local oldTblMeta = getmetatable(obj);    
    setmetatable(obj, nil);
    local s = tostring(obj);
    setmetatable(obj, oldTblMeta);
    return s;
  else
    return tostring(obj);
  end
end

function setdelegationkey(func, key, obj, member)
  rawset(__delegation_keys, func, key .. __get_obj_string(obj));
end;
function getdelegationkey(func)
  return rawget(__delegation_keys, func);
end;
function removedelegationkey(func)
  rawset(__delegation_keys, func, nil);
end;
function dumpdelegationtable()
  print("dumpdelegationtable");
  
  if next(__delegation_keys) == nil then
	print("dumpdelegationtable empty");
	return;
  end
  
  for k, v in pairs(__delegation_keys) do
      print(k);
      print(v);
  end
end

function delegationwrap(handler)
  if handler then
    local meta = getmetatable(handler);
    if meta and rawget(meta, "__is_delegation") then
      return handler;
    else
      return wrapdelegation{ handler };
    end;
  else
    return wrapdelegation{};
  end;
end;

function delegationcomparewithnil(isevent, isStatic, key, t, inf, k, isequal)
  if not t then
    if isequal then 
      return true;
    else
      return false;
    end;
  end;
  if type(t)=="function" then
  	if isequal then 
      return false;
    else
      return true;
    end;
  end;
  local v = t;
  if k then
    v = t[k];  
  end;
  if type(v)=="function" then
  	if isequal then 
      return false;
    else
      return true;
    end;
  end;
  local n = #v;
  if isequal and n==0 then
    return true;
  elseif not isqual and n>0 then
    return true;
  else
    return false;
  end;
end;
function delegationset(isevent, isStatic, key, t, intf, k, handler)
  local v = t;
  if k then
    v = t[k];
  end;
  if not v or type(v)~="table" then
  	--取不到值或者值不是表，则有可能是普通的特性访问
  	--t[k] = handler;
  	return handler;
  else
	  local n = #v;
	  for i=1,n do
	    table.remove(v);
	  end;
	  table.insert(v,handler);
	  return v;
  end;
end;
function delegationadd(isevent, isStatic, key, t, intf, k, handler)
  local v = t;
  if k then
    v = t[k];  
  end;
  if v == nil then
    v = delegationwrap(handler);
  else
    table.insert(v, handler);
  end;
  return v;
end;
function delegationremove(isevent, isStatic, key, t, intf, k, handler)
  local v = t;
  if k then
    v = t[k];  
  end;
  local find=false;
  local pos = 1;
  for k,v in pairs(v) do
    if v==handler then
      find=true;
      break;
    else
    	local key1 = getdelegationkey(v);
    	local key2 = getdelegationkey(handler);
  		if key1 and key2 and key1 == key2 then
  			find=true;
  			break;
  		end;
    end;
    pos = pos + 1;
  end;
  if find then
    removedelegationkey(v[pos]);
    table.remove(v, pos);
    removedelegationkey(handler);
  end;
  return v;
end;

__extern_delegation_str_func = {}
function getexterndelegationfunc(str)
  local tbl = rawget(__extern_delegation_str_func, str);
  if tbl ~= nil then
    return tbl[1];
  end;
  return nil;
end
function setexterndelegationfunc(str, func)
  local tbl = rawget(__extern_delegation_str_func, str);  
  if tbl ~= nil then
    table.insert(tbl, func);
  else
    tbl = { func };
  end  
	rawset(__extern_delegation_str_func, str, tbl);
end
function removeexterndelegationfunc(str, handler)
  local tbl = rawget(__extern_delegation_str_func, str);
  if tbl == nil then
    return;
  end;  
  for k, v in pairs(tbl) do
    if v == handler then
      table.remove(tbl, k);
      break;
    end;
  end  
  if next(tbl) == nil then
    rawset(__extern_delegation_str_func, str, nil);
  end;
end
function dumpexterndelegationtable()
  print("dumpexterndelegationtable");
  
  if next(__extern_delegation_str_func) == nil then
	print("dumpexterndelegationtable empty");
	return;
  end
  
  for k, v in pairs(__extern_delegation_str_func) do
      print(k);
      for a, b in pairs(v) do
        print(b);
      end
  end
end

function externdelegationcomparewithnil(isevent, isStatic, key, t, inf, k, isequal)
  local v = t;
  if k then
    v = t[k];
  end;
  if isequal and not v then
    return true;
  elseif not isequal and v then
    return true;
  else
    return false;
  end;
end;
function externdelegationset(isevent, isStatic, key, t, intf, k, handler)
  if k then
    --t[k] = handler;
    return handler;
  else
    return handler;
  end;
end;
function externdelegationadd(isevent, isStatic, key, t, intf, k, handler)
  local str = getdelegationkey(handler);
  if str then
    setexterndelegationfunc(str .. key, handler);
  end;
  if k then    
    if isevent then
      if isStatic then
        t[k]("+", handler);
      else
        t[k](t, "+", handler);
      end;
    else
      t[k] = t[k] + handler;
    end;
  else
    t = t + handler;
  end;
end;
function externdelegationremove(isevent, isStatic, key, t, intf, k, handler)
  local str = getdelegationkey(handler);
  local trueHandler = handler;
  if str then
    trueHandler = getexterndelegationfunc(str .. key);
  end;
  if k then    
    if isevent then
      if isStatic then
        t[k]("-", trueHandler);
      else
        t[k](t, "-", trueHandler);
      end;
    else
      t[k] = t[k] - trueHandler;
    end;
  else
    t = t - trueHandler;
  end;
  removedelegationkey(handler);
  if str then
    removeexterndelegationfunc(str .. key, trueHandler);
  end;
  
end;

function getstaticindexer(class, name, ...)
  if name then
	  return class[name](...);
	else
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
    return nil;
	end;
end;
function getinstanceindexer(obj, intf, name, ...)
  if name then
	  return obj[name](obj, ...);
	else
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
    return nil;
	end;
end;

function setstaticindexer(class, name, ...)
  if name then
	  class[name](...);
	else
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
	end;
	return nil;
end;
function setinstanceindexer(obj, intf, name, ...)
  if name then
	  obj[name](obj, ...);
	else
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
	end;
	return nil;
end;

function getexternstaticindexer(class, name, ...)
	return class[...];
end;
function getexterninstanceindexer(obj, intf, name, ...)  
	local args = {...};
	local index = __unwrap_if_string(args[1]);
	if nil==index then
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
    return nil;
  end;
	local meta = getmetatable(obj);
	if meta then
		local class = rawget(meta, "__class");
		local typename = rawget(meta, "__typename");
		if class == CS.System.Collections.Generic.List_T then
			return obj[index+1];
		elseif class == CS.System.Collections.Generic.Dictionary_TKey_TValue then
			local v = obj[index];
			if v then
				return v.value;
			else
				return nil;
			end;
		elseif typename == "LuaArray" then
			return obj[index+1];	-- todo: fixme
		elseif typename == "LuaVarObject" then
			return obj[index];		-- todo: fixme
		else
			return obj[index];
    end;
  end;
end;

function setexternstaticindexer(class, name, ...)	
  return nil;
end;
function setexterninstanceindexer(obj, intf, name, ...)
  local args = {...};
  local num = #args;
	local index = __unwrap_if_string(args[1]);
	if nil==index then
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
    return;
  end;
  local val = nil;
  if num>1 then
  	val = args[num];
  end;
  local meta = getmetatable(obj);
  if meta then
		local class = rawget(meta, "__class");
		local typename = rawget(meta, "__typename");
    if class == CS.System.Collections.Generic.List_T then
      obj[index+1] = val;
    elseif class == CS.System.Collections.Generic.Dictionary_TKey_TValue then      
      if obj[index] then
        obj[index] = { value=val };
      else
        obj:Add(index, val);
      end;
    elseif typename == "LuaArray" then
    	obj[index+1] = val;	--todo: fixme
    elseif typename == "LuaVarObject" then
    	obj[index] = val;  	--todo: fixme
    else
    	obj[index] = val;
    end;
  end;
  return nil;
end;

function invokeexternoperator(class, method, ...)
	local args = {...};
	--对slua，对应到lua元表操作符函数的操作符重载cs2lua转lua代码时已经换成对应操作符表达式。
	--执行到这里的应该是无法对应到lua操作符的操作符重载
	local argnum = #args;
	if method=="op_Equality" then
	  if args[1] and args[2] then
	    return args[1]==args[2];
	  elseif not args[1] then
	    return CS.XLuaExtensions.IsNull(args[2]);
	  elseif not args[2] then
	    return CS.XLuaExtensions.IsNull(args[1]);
	  else
	    return true;
	  end;
	elseif method=="op_Inequality" then
	  if args[1] and args[2] then
	    return args[1]~=args[2];
	  elseif not args[1] then
	    return not CS.XLuaExtensions.IsNull(args[2]);
	  elseif not args[2] then
	    return not CS.XLuaExtensions.IsNull(args[1]);
	  else
	    return false;
	  end;	  
	elseif method=="op_Implicit" then
  	local t = nil;
  	if args[1] then
  		local meta = getmetatable(args[1]);
  		if meta then
	  		t = rawget(meta, "__typename");
  		end;
  	end;
    if class==CS.UnityEngine.Vector4 then
    	if t=="Vector3" then
      	return CS.UnityEngine.Vector4(args[1].x, args[1].y, args[1].z, 0);
      elseif t=="Vector4" then
      	return CS.UnityEngine.Vector3(args[1].x, args[1].y, args[1].z);
      end;
    elseif class==CS.UnityEngine.Vector2 then
    	if t=="Vector3" then
    		return CS.UnityEngine.Vector2(args[1].x, args[1].y);
    	else
      	return CS.UnityEngine.Vector3(args[1].x, args[1].y, 0);
      end;
    elseif class==CS.UnityEngine.Color32 then
    	if t=="Color32" then
      	return CS.UnityEngine.Color(args[1].r/255.0, args[1].g/255.0, args[1].b/255.0, args[1].a/255.0);
      else
      	return CS.UnityEngine.Color32(math.floor(args[1].r*255), math.floor(args[1].g*255), math.floor(args[1].b*255), math.floor(args[1].a*255));
      end;
    else
	    --这里就不仔细判断了，就假定是UnityEngine.Object子类了
	    return not CS.XLuaExtensions.IsNull(args[1]);
	  end;
	end;
	if method then
  	if argnum == 1 and args[1] then
  	  return args[1][method](...);
  	elseif argnum == 2 then
  	  if args[1] then
  	    return args[1][method](...);
  	  elseif args[2] then
  	    return args[2][method](...);
  	  end;
  	end;  
	else
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
	end;
	return nil;
end;

function defineentry(class)
  _G.main = function()
    return class;
  end;
end;

function invokewithinterface(obj, intf, method, ...)
	local meta = getmetatable(obj);
	if method then
  	if meta and rawget(meta, "__cs2lua_defined") then
  		return obj[method](obj,...);
  	else
  		return obj[method](obj,...);
  	end;
	else
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
  end;
	return nil;
end;
function getwithinterface(obj, intf, property)
	local meta = getmetatable(obj);
	if property then
  	if meta and rawget(meta, "__cs2lua_defined") then
  		return obj[property];
  	else
  		return obj[property];
  	end;
	else
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
  end;
	return nil;
end;
function setwithinterface(obj, intf, property, value)
	local meta = getmetatable(obj);
	if property then
  	if meta and rawget(meta, "__cs2lua_defined") then
  		obj[property]=value;
  	else
  		obj[property]=value;
  	end;
	else
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
  end;
	return nil;
end;

function invokeforstring(str, method, ...)
	if method == "Length" then
		return string.len(str);
	elseif method == "ToUpper" then
		return string.upper(str);
	elseif method == "ToLower" then
		return string.lower(str);
	elseif method == "Equals" then
		local otherStr=...;
		return str==otherStr;
	elseif method == "Substring" then	
		local pos, length = ...;	
		if pos > string.len(str) then
			error("Argument is out of range.");
			return;
		elseif length ~= nil and pos + length > string.len(str) then
			error("Argument is out of range.");
			return;
		end
		if length == nil then
			return string.sub(str, pos + 1);
		else
			return string.sub(str, pos + 1, pos + length);
		end
	elseif method == "Split" then
	  local csstr = CS.System.String(obj);
	  return csstr:Split(string.char(...));
	else
		error("implement c# string method here" .. method)
	end	
end

function invokeforbasicvalue(obj, isEnum, class, method, ...)
	local args = {...};
	local meta = getmetatable(obj);
	if isEnum and obj and method=="ToString" then
	  return class.Value2String[obj];
	end;
	if method then
	if type(obj)=="string" then	
	  return invokeforstring(obj, method, ...);
	elseif meta then
		return obj[method](obj,...);
	elseif method=="CompareTo" then
	  if obj>args[1] then
	    return 1;
	  elseif obj<args[1] then
	    return -1;
	  else
	    return 0;
	  end;
	elseif method=="ToString" then
	  return tostring(obj);
	elseif method=="Split" then
	  return obj:Split(string.char(...));
	end;
	else
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
  end;
	return nil;
end;
function getforbasicvalue(obj, isEnum, class, property)
	local meta = getmetatable(obj);
	if property then
	if type(obj)=="string" then
	  return invokeforstring(obj, property);
	elseif meta then
		return obj[property];
	else
		return obj[property];
	end;
	else
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
  end;
	return nil;
end;
function setforbasicvalue(obj, isEnum, class, property, value)
	local meta = getmetatable(obj);
	if property then
	if type(obj)=="string" then
	  return invokeforstring(obj, property, value);
	elseif meta then
		obj[property]=value;
	else
		obj[property]=value;
	end;
	else
    CS.UnityEngine.Debug.LogError("[cs2lua] table index is nil");
  end;
	return nil;
end;

function invokearraystaticmethod(firstArray, secondArray, method, ...)
  if nil~=firstArray and nil~=method then
    local args = {...};
    local meta = getmetatable(firstArray);    
		if meta and rawget(meta, "__cs2lua_defined") then
      if method=="IndexOf" then
        return firstArray:IndexOf(args[3]);
      elseif method=="Sort" then
        return table.sort(firstArray, function(a, b) return args[3](a, b) < 0 end);
      else
        return nil;
      end;
    else
      --这种情形认为是外部导出的数组调用，直接调导出接口了（由于CS.System.Array有generic成员，这些方法的调用估计会出错）
      CS.System.Array[method](...);
    end;
  else
    return nil;
  end;
end;

--暂时只对整数除法进行特殊处理，运算溢出暂不处理
--__cs2lua_div = 0;
--__cs2lua_mod = 1;
--__cs2lua_add = 2;
--__cs2lua_sub = 3;
--__cs2lua_mul = 4;
--__cs2lua_lshift = 5;
--__cs2lua_rshift = 6;
--__cs2lua_bitand = 7;
--__cs2lua_bitor = 8;
--__cs2lua_bitxor = 9;
--__cs2lua_bitnot = 10;
function invokeintegeroperator(op, luaop, opd1, opd2, type1, type2)
  if op==__cs2lua_div then
    local r;
    if opd1*opd2>0 then
      r = math.floor(opd1/opd2);
    else
      r = -math.floor(-opd1/opd2);
    end;
    return r;
  elseif op==__cs2lua_mod then
    return opd1 % opd2;
  elseif op==__cs2lua_add then
    if type1 then
      return opd1 + opd2;
    else
      return opd2;
    end;
  elseif op==__cs2lua_sub then
    if type1 then
      return opd1 - opd2;
    else
      return -opd2;
    end;
  elseif op==__cs2lua_mul then
    return opd1 * opd2;
  elseif op==__cs2lua_lshift then
    return lshift(opd1, opd2);
  elseif op==__cs2lua_rshift then
    return rshift(opd1, opd2);
  elseif op==__cs2lua_bitand then
    return bitand(opd1, opd2);
  elseif op==__cs2lua_bitor then
    return bitor(opd1, opd2);
  elseif op==__cs2lua_bitxor then
    return bitxor(opd1, opd2);
  elseif op==__cs2lua_bitnot then
    return bitnot(opd1);
  end;
end;

function getiterator(exp)
	local meta = getmetatable(exp);
	if meta and rawget(meta, "__cs2lua_defined") then
		local enumer = exp:GetEnumerator();
		return function()
			if enumer:MoveNext() then
				return enumer.Current;
			else
				return nil;
			end;
		end;
	else
		local enumer = exp:GetEnumerator();
		return function()
			if enumer:MoveNext() then
				return enumer.Current.Value;
			else
				return nil;
			end;
		end;
	end;
end;

function defaultvalue(t, typename, isExtern)
	if t==CS.UnityEngine.Vector3 then
		return CS.UnityEngine.Vector3.zero;
	elseif t==CS.UnityEngine.Vector2 then
		return CS.UnityEngine.Vector2.zero;
	elseif t==CS.UnityEngine.Vector4 then
		return CS.UnityEngine.Vector4.zero;
	elseif t==CS.UnityEngine.Quaternion then
		return CS.UnityEngine.Quaternion.identity;
	elseif t==CS.UnityEngine.Color then
		return CS.UnityEngine.Color.black;
	elseif t==CS.UnityEngine.Color32 then
		return CS.UnityEngine.Color32(0,0,0,0);
	elseif isExtern then
		return t();
	else
		return t.__new_object();
	end;
end;

--命令行开关-usearraygetset开启后，数组的访问会委托到下面2个函数
--这里只实现了一维数组的处理
function arrayget(arr, ...)
  local args = {...};
  local num = #args;
  local ix = args[1];
  local meta = getmetatable(arr);
  if meta and rawget(meta, "__cs2lua_defined") then
    return arr[ix];
  else
    return arr[ix-1];
  end;
end;
function arrayset(arr, ...)
  local args = {...};
  local num = #args;
  local ix = args[1];
  local val = args[num];
  local meta = getmetatable(arr);
  if meta and rawget(meta, "__cs2lua_defined") then
    arr[ix] = val;
  else
    arr[ix-1] = val;
  end;
  return val;
end;

function luausing(func)
  return pcall(func);
end;

function luatry(func)
  return xpcall(func, function(e)
    local err = tostring(e);
    local trace = debug.traceback(err); 
    return {err, trace};
  end);
end;

function luacatch(handled, ret, err, func)
	local retval = nil;
  if not handled and not ret then
    handled, retval = func(handled, {Message=err[1],StackTrace=err[2]});
  end; 
  return handled, retval;
end;

function luathrow(obj)
  if type(obj)=="string" then
    error(obj);
  else
    error(obj.Message);
  end;
end;

function luaunpack(arr)
	local mt = getmetatable(arr);
	if mt and mt.__cs2lua_defined then
		return unpack(arr);
	else
		return arr;
	end;
end;

function chararraytostring(arr)
	string.char(unpack(arr));
end;

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
	for cv in getiterator(coll) do
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
