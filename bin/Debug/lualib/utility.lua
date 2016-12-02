--remove comments for debug with ZeroBrane
--require "luadebug";

System = System or {};
System.Collections = System.Collections or {};
System.Collections.Generic = System.Collections.Generic or {};
System.Collections.Generic.List_T = {};
System.Collections.Generic.Queue_T = {};
System.Collections.Generic.Stack_T = {};
System.Collections.Generic.Dictionary_TKey_TValue = {};
System.Collections.Generic.HashSet_T = {};

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

function condexp(cv,tv,fv)
    if cv then
        return tv;
    else
        return fv;
    end;
end;

function condaccess(v, func)
	return v and func();
end;

function nullcoalescing(v1,v2)
	return v1 or v2;
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

function typecast(obj, t)
	if t == System.String then
		return wrapstring(obj);		
	else
  	return obj;
 	end;
end;

function typeis(obj, t)
  local meta = getmetatable(obj);
  local meta2 = getmetatable(t);
  if meta then
    if type(obj)=="userdata" then
      return meta2 and meta.__typename == meta2.__typename;
    else
      return meta.__class == t;
    end;
  end;
  return false;
end;

function __wrap_if_string(val)
  if type(val)=="string" then
    return System.String(val);
  else
    return val;
  end;
end;

function __unwrap_if_string(val)
  local meta = getmetatable(val);
  if type(val)=="userdata" and meta.__typename=="String" then
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
  local count = __get_table_count(tb);
  local meta = getmetatable(tb);
  if meta then
    meta.__count = count + 1;
  end;
end;

function __dec_table_count(tb)
  local count = __get_table_count(tb);
  if count>0 then
    local meta = getmetatable(tb);
    if meta then
      meta.__count = count - 1;    
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

__mt_index_of_array = function(t, k)
	if k=="Length" or k=="Count" then
		return table.maxn(t);
	elseif k=="GetLength" then
		return function(obj, ix)
      local ret = 0;
      local tb = obj;
      for i=0,ix do			       
        ret = table.maxn(tb);
        tb = tb[0];
      end;
      return ret;
    end;
  elseif k=="Add" then
    return function(obj, v) table.insert(obj, v); end;
  elseif k=="Remove" then
    return function(obj, p)
      local pos = 1;
      local ret = nil;
      for k,v in pairs(obj) do		        
        if v==p then
          ret=v;
          break;
        end;
        pos=pos+1;		        
      end;
      if ret then
        table.remove(obj,pos);
      end;
      return ret;
    end;
  elseif k=="AddRange" then
    return function(obj, coll)
      local enumer = coll:GetEnumerator();
      while enumer:MoveNext() do
        table.insert(obj, enumer.Current);
      end;
    end;
  elseif k=="Insert" then
    return function(obj, ix, p)
      table.insert(obj,ix+1,p);
    end;
  elseif k=="IndexOf" then
	  return function(obj, p)
	    local ix = 0;
      for k,v in pairs(obj) do
        if v==p then	          
          return ix;
        end;
        ix = ix + 1;
      end;
      return -1;
    end;
  elseif k=="LastIndexOf" then
	  return function(obj, p)
	    local num = table.maxn(obj);
      for k=num,1 do
        local v = obj[k];
        if v==p then	          
          return k-1;
        end;
      end;
      return -1;
    end;
  elseif k=="Contains" then
	  return function(obj, p)
      local ret = false;
      for k,v in pairs(obj) do		        
        if v==p then
          ret=true;
          break;
        end;
      end;
      return ret;
    end;
  elseif k=="Peek" then    
    return function(obj)
      local num = table.maxn(obj);
      local v = obj[num];
      return v;
    end;
  elseif k=="Enqueue" then
    return function(obj,v)
      table.insert(obj,1,v);
    end;
  elseif k=="Dequeue" then
    return function(obj)
      local num = table.maxn(obj);
      local v = obj[num];
      table.remove(obj,num);
      return v;
    end;
  elseif k=="Push" then
    return function(obj,v)
      table.insert(obj,v);
    end;
  elseif k=="Pop" then
    return function(obj)
      local num = table.maxn(obj);
      local v = obj[num];
      table.remove(obj,num);
      return v;
    end;
  elseif k=="CopyTo" then
    return function(obj, arr)
      for k,v in pairs(obj) do
        arr[k]=v;
      end;
    end;
  elseif k=="ToArray" then
    return function(obj)
      local ret = {};
      for k,v in pairs(obj) do
        ret[k]=v;
      end;
      return ret;
    end;
  elseif k=="Clear" then
  	while table.maxn(t)>0 do
  		table.remove(t);
  	end;	  	
  elseif k=="GetEnumerator" then
    return function(obj)
      return GetArrayEnumerator(obj);
    end;
	end;
end;

__mt_index_of_dictionary = function(t, k)
	if k=="Count" then
		return __get_table_count(t);
	elseif k=="Add" then
	  return function(obj, p1, p2)
	    p1 = __unwrap_if_string(p1);		    
	    obj[p1] = { value=p2 };
	    __inc_table_count(obj);
	    return p2;
	  end;
	elseif k=="Remove" then
	  return function(obj, p)
	    p = __unwrap_if_string(p);
	    local v = obj[p];
	    local ret = nil;
	    if v then
	      ret = v.value;
        obj[p]=nil;
      end;
      __dec_table_count(obj);
      return ret;
    end;
	elseif k=="ContainsKey" then
	  return function(obj, p)
	    p = __unwrap_if_string(p);
      if obj[p] then
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
      local v = obj[p];
      if v then
        return true, v.value;
      end;
      return false, nil;
    end;
  elseif k=="Keys" then
    local ret = {};
    for k,v in pairs(t) do
      k = __wrap_if_string(k);
      table.insert(ret, k);
    end;
    return ret;
  elseif k=="Values" then
    local ret = {};
    for k,v in pairs(t) do
      table.insert(ret, v.value);
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
	end;
end;

__mt_index_of_hashset = function(t, k)
	if k=="Count" then
		return __get_table_count(t);
	elseif k=="Add" then
	  return function(obj, p)
	    p = __unwrap_if_string(p);
	    obj[p]=true;
	    __inc_table_count(obj);
	    return true;
	  end;
	elseif k=="Remove" then
	  return function(obj, p)
	    p = __unwrap_if_string(p);
	    local ret = obj[p];
	    if ret then
        obj[p]=nil;
      end;
      __dec_table_count(obj);
      return ret;
    end;
	elseif k=="Contains" then
	  return function(obj, p)
	    p = __unwrap_if_string(p);
      if obj[p] then
        return true;
      end;
      return false;
    end;
  elseif k=="CopyTo" then
    return function(obj, arr)
      for k,v in pairs(obj) do
	      k = __wrap_if_string(l);
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
	end;
end;

__mt_delegation = {
  __call = function(t, ...)
    for k,v in pairs(t) do
      if v then
        v(...);
      end;
    end;
  end;
};

function GetArrayEnumerator(tb)
  return setmetatable({
    MoveNext = function(this)
      local tb = this.object;
      local num = table.maxn(tb);
      if this.index < num then
        this.index = this.index + 1;
        this.current = tb[this.index];
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

function wrapstring(str)
  if type(str)=="string" then
    return System.String(str);
  elseif type(str)=="number" then
  	return System.String(tostring(str));
  else
    return str;
  end;
end;

function wraparray(arr)
	return setmetatable(arr, { __index = __mt_index_of_array });
end;

function wrapdictionary(dict)
	return setmetatable(dict, { __index = __mt_index_of_dictionary });
end;

function wrapdelegation(handlers)
  return setmetatable(handlers, __mt_delegation);
end;

function wrapenumerable(func)
	return function(...)
		local args = {...};
		return UnityEngine.WrapEnumerator(function()
			local f = coroutine.wrap(func);
			f(unpack(args));
		end);
	end;
end;

function wrapyield(yieldVal, isEnumerableOrEnumerator, isUnityYield)
	UnityEngine.Yield(yieldVal);
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
	return setmetatable(arr, { __index = __mt_index_of_array });
end;

function wrapexternvaluetype(v)
	return v;
end;

function wrapexternvaluetypearray(arr)
	for i,v in ipairs(arr) do
		arr[i]=wrapexternvaluetype(v);
	end;
	return setmetatable(arr, { __index = __mt_index_of_array });
end;

function defineclass(base, className, static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, instance_interfaces, instance_interface_map, is_value_type)
    
    local base_class = base or {};
    local mt = getmetatable(base_class);

    local class = static or {};
    local class_fields = static_fields or {};
    local class_props = static_props or {};
    local class_events = static_events or {};
    class["__cs2lua_defined"] = true;
    class["__class_name"] = className;
    
    setmetatable(class, {
        __call = function()
        		local baseObj = nil;
        		if mt then
        			baseObj = mt.__call();
        		end;
            local obj = {};
						for k,v in pairs(instance_methods) do
							obj[k] = v;
						end;
            local obj_fields;
            if instance_build then
            	obj_fields = instance_build();
            else
            	obj_fields = {};
            end;
            local obj_props = instance_props or {};
            local obj_events = instance_events or {};
            local obj_intfs = instance_interfaces or {};
            local obj_intf_map = instance_interface_map or {};
            obj["base"] = baseObj;
            
            setmetatable(obj, {
            		__class = class,
            		__is_value_type = is_value_type,
                __index = function(t, k)
                    local ret;
				            ret = obj_fields[k];
				            if nil~=ret then
				            	return ret;
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
                      ret = t[ret];
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
                    if baseObj then
                    	ret = baseObj[k];
                    end;
                    return ret;
                end,

                __newindex = function(t, k, v)
                    local ret;
				            ret = obj_fields[k];
				            if nil~=ret then
				            	obj_fields[k] = v;
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
                    if not baseObj or not pcall(function() baseObj[k] = v end) then
                        rawset(t, k, v);
                    end;
                end,
                
            });

            return obj;
        end,
        
        __index = function(t, k)
            local ret;
            ret = class_fields[k];
            if nil~=ret then
            	return ret;
            end;
            ret = class_props[k];
            if nil~=ret then
              if ret.get then
                ret = ret.get(t);
              else
                ret = nil;
              end;
            elseif base_class then
            	ret = base_class[k];                         
            end;
            return ret;
        end,

        __newindex = function(t, k, v)
            local ret;
            ret = class_fields[k];
            if nil~=ret then
            	class_fields[k] = v;
            end;
            ret = class_props[k];
            if nil~=ret then
              if ret.set then
                ret.set(t, v);
              end;
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

function newobject(class, ctor, initializer, ...)
  local obj = class();
  if ctor then
    obj[ctor](obj, ...);
  end;
  for k,v in pairs(initializer) do
    obj[k] = v;
  end;
  return obj;
end;

function newexternobject(class, className, ctor, doexternsion, initializer, ...)
  local obj = nil;
  if class then
    obj = class(...);
  else
    obj = Slua.CreateClass(className, ...);
  end;
  if obj then
    if doexternsion then
      doexternsion();
    end;
    for k,v in pairs(initializer) do
      obj[k] = v;
    end;
    return obj;
  else
    return nil;
  end;
end;

function newtypeparamobject(t)
  if t.__cs2lua_defined then
    local obj = t();
    if obj.ctor then
      obj:ctor();
    end;
    return obj;
  else
    return t();
  end;
end;

function newdictionary(t, ctor, dict, ...)
  if dict then
	  return setmetatable(dict, { __index = __mt_index_of_dictionary, __class = t });
	end;
end;

function newlist(t, ctor, list, ...)
  if list then
    return setmetatable(list, { __index = __mt_index_of_array, __class = t });
  end;
end;

function newcollection(t, ctor, coll, ...)
  if coll then
    return setmetatable(dict, { __index = __mt_index_of_hashset, __class = t });
  end;
end;

function newexterndictionary(t, className, ctor, doexternsion, dict, ...)
  if dict and t==System.Collections.Generic.Dictionary_TKey_TValue then
	  return setmetatable(dict, { __index = __mt_index_of_dictionary, __class = t });
	else
	  return newexternobject(t, className, ctor, doexternsion, dict, ...);
	end;
end;

function newexternlist(t, className, ctor, doexternsion, list, ...)
  if list and (t==System.Collections.Generic.List_T or t==System.Collections.Generic.Queue_T or t==System.Collections.Generic.Stack_T) then    
	  return setmetatable(list, { __index = __mt_index_of_array, __class = t });
	else
	  return newexternobject(t, className, ctor, doexternsion, list, ...);
  end;
end;

function newexterncollection(t, className, ctor, doexternsion, coll, ...)
  if coll and t==System.Collections.Generic.HashSet_T then
    return setmetatable(dict, { __index = __mt_index_of_hashset, __class = t });
	else
	  return newexternobject(t, className, ctor, doexternsion, coll, ...);
  end;
end;

function delegationwrap(handler)
  return wrapdelegation{ handler };
end;

function delegationset(t, k, handler)
  local v = t;
  if k then
    v = t[k];  
  end;
  local n = table.maxn(t[k]);
  for i=1,n do
    table.remove(v);
  end;
  table.insert(v,handler);
end;
function delegationadd(t, k, handler)
  local v = t;
  if k then
    v = t[k];  
  end;
  table.insert(v, handler);
end;
function delegationremove(t, k, handler)
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
    end;
    pos = pos + 1;
  end;
  if find then
    table.remove(v, pos);
  end;
end;

function externdelegationset(t, k, handler)
  if k then
    t[k] = handler;
  else
    t = handler;
  end;
end;
function externdelegationadd(t, k, handler)
  if k then
    t[k] = {"+=", handler};
  else
    t = {"+=", handler};
  end;
end;
function externdelegationremove(t, k, handler)
  if k then
    t[k] = {"-=", handler};
  else
    t = {"-=", handler};
  end;
end;

function getstaticindexer(class, name, ...)
	return class[name](...);
end;
function getinstanceindexer(obj, name, ...)
	return obj[name](obj, ...);
end;

function setstaticindexer(class, name, ...)
	class[name](...);
	return nil;
end;
function setinstanceindexer(obj, name, ...)
	obj[name](obj, ...);
	return nil;
end;

function getexternstaticindexer(class, name, ...)
	return class[...];
end;
function getexterninstanceindexer(obj, name, ...)  
	local args = {...};
	local index = args[1];
	local meta = getmetatable(obj);
	if meta then
  	if meta.__class == System.Collections.Generic.List_T then
  	  return obj[index+1];
  	elseif meta.__class == System.Collections.Generic.Dictionary_TKey_TValue then
      return obj[index];
    elseif meta.__typename == "LuaArray" then
    	return obj[index+1];
    elseif meta.__typename == "LuaVarObject" then
    	return obj[index];
    else
    	return obj:getItem(index);
    end;
  end;
end;

function setexternstaticindexer(class, name, ...)	
  return nil;
end;
function setexterninstanceindexer(obj, name, ...)
  local args = {...};
  local num = table.maxn(args);
	local index = __unwrap_if_string(args[1]);
	local val = args[num];
  local meta = getmetatable(obj);
  if meta then
    if meta.__class == System.Collections.Generic.List_T then
      obj[index+1] = val;
    elseif meta.__class == System.Collections.Generic.Dictionary_TKey_TValue then      
      obj[index] = val;
    elseif meta.__typename == "LuaArray" then
    	obj[index+1] = val;
    elseif meta.__typename == "LuaVarObject" then
    	obj[index] = val;
    else
    	obj:setItem(index, val);
    end;
  end;
  return nil;
end;

function getstaticelement(class, name, ...)
  return nil;
end;
function getinstanceelement(obj, name, ...)
  return nil;
end;
function setstaticelement(class, name, ...)
  --为了适应表达式内嵌赋值，这个函数需要返回值
  return nil;
end;
function setinstanceelement(obj, name, ...)
  --为了适应表达式内嵌赋值，这个函数需要返回值
  return nil;
end;
function getexternstaticelement(class, name, ...)
  return nil;
end;
function getexterninstanceelement(obj, name, ...)
  return nil;
end;
function setexternstaticelement(class, name, ...)
  --为了适应表达式内嵌赋值，这个函数需要返回值
  return nil;
end;
function setexterninstanceelement(obj, name, ...)
  --为了适应表达式内嵌赋值，这个函数需要返回值
  return nil;
end;

function invokeexternoperator(class, method, ...)
	local args = {...};
	--对slua，对应到lua元表操作符函数的操作符重载cs2lua转lua代码时已经换成对应操作符表达式。
	--执行到这里的应该是无法对应到lua操作符的操作符重载
	local argnum = table.maxn(args);
	if argnum == 1 and args[1] then
	  return args[1][method](...);
	elseif argnum == 2 then
	  if args[1] then
	    return args[1][method](...);
	  elseif args[2] then
	    return args[2][method](...);
	  end;
	end;
	return nil;
end;

function defineentry(class)
  _G.main = function()
    return class;
  end;
end;