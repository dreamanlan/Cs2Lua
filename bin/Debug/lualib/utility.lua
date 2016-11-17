System = System or {};
System.Collections = System.Collections or {};
System.Collections.Generic = System.Collections.Generic or {};
System.Collections.Generic.List_T = {};
System.Collections.Generic.Queue_T = {};
System.Collections.Generic.Stack_T = {};
System.Collections.Generic.Dictionary_TKey_TValue = {};
System.Collections.Generic.HashSet_T = {};

function lshift(v,n)
    for i=1,n do
        v=v*2;
    end;
    return v;
end;

function rshift(v,n)
    for i=1,n do
        v=v/2;
    end;
    return v;
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
	return 1-v;
end;

function bitand(v1,v2)
	return v1-v2;
end;

function bitor(v1,v2)
	return v1+v2;
end;

function bitxor(v1,v2)
	return v1-v2;
end;

function typecast(obj, type)
  return obj;
end;

function typeis(obj, type)
  return true;
end;

function arraytoparams(arr)
	return unpack(arr);
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

__mt_array = {
	__index = function(t, k)
		if k=="Length" or k=="Count" then
			local tb = t.__object;
			return table.maxn(tb);
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
	end,
};

__mt_dictionary = {
	__index = function(t, k)
		if k=="Count" then
			local tb = t.__object;
			return table.maxn(tb);
		elseif k=="Add" then
		  return function(obj, p1, p2)
		    p1 = __unwrap_if_string(p1);		    
		    obj[p1]=p2;
		    return p2;
		  end;
		elseif k=="Remove" then
		  return function(obj, p)
		    p = __unwrap_if_string(p);
	      local pos = 1;
	      local ret = nil;
	      for k,v in pairs(obj) do		        
	        if k==p then
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
		elseif k=="ContainsKey" then
		  return function(obj, p)
		    p = __unwrap_if_string(p);
	      if obj[p] then
	        return true;
	      end;
	      local ret = false;
	      for k,v in pairs(obj) do		        
	        if k==p then
	          ret=true;
	          break;
	        end;
	      end;
	      return ret;
	    end;
		elseif k=="ContainsValue" then
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
	  elseif k=="TryGetValue" then
	    return function(obj, p)
		    p = __unwrap_if_string(p);
	      local val = obj[p];
	      if val then
	        return true, val;
	      end;
	      for k,v in pairs(obj) do
	        if k==p then
	          return true, v;
	        end;
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
        table.insert(ret, v);
      end;
      return ret;
	  elseif k=="Clear" then
	  	while table.maxn(t)>0 do
	  		table.remove(t);
	  	end;	  	
	  elseif k=="GetEnumerator" then
	    return function(obj)
	      return GetDictEnumerator(obj);
	    end;
		end;
	end,
};

__mt_hashset = {
	__index = function(t, k)
		if k=="Count" then
			local tb = t.__object;
			return table.maxn(tb);
		elseif k=="Add" then
		  return function(obj, p)
		    p = __unwrap_if_string(p);
		    obj[p]=true;
		    return true;
		  end;
		elseif k=="Remove" then
		  return function(obj, p)
		    p = __unwrap_if_string(p);
	      local pos = 1;
	      local ret = nil;
	      for k,v in pairs(obj) do		        
	        if k==p then
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
		elseif k=="Contains" then
		  return function(obj, p)
		    p = __unwrap_if_string(p);
	      if obj[p] then
	        return true;
	      end;
	      local ret = false;
	      for k,v in pairs(obj) do		        
	        if k==p then
	          ret=true;
	          break;
	        end;
	      end;
	      return ret;
	    end;
    elseif k=="CopyTo" then
      return function(obj, arr)
        for k,v in pairs(obj) do
		      k = __wrap_if_string(l);
          table.insert(arr,k);
        end;
      end;
	  elseif k=="Clear" then
	  	while table.maxn(t)>0 do
	  		table.remove(t);
	  	end;	  	
	  elseif k=="GetEnumerator" then
	    return function(obj)
	      return GetHashsetEnumerator(obj);
	    end;
		end;
	end,
};

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
        Value = v,
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
  else
    return str;
  end;
end;

function wraparray(arr)
	local mt = setmetatable({__object=arr}, __mt_array);
	return setmetatable(arr, { __index = mt});
end;

function wrapdictionary(dict)
	local mt = setmetatable({__object=dict}, __mt_dictionary);
	return setmetatable(dict, { __index = mt});
end;

function wrapdelegation(handlers)
  return setmetatable(handlers, __mt_delegation);
end;

function wrapenumerable(func)
	return function(...)
		local args = {...};
		local f = coroutine.wrap(func);
		return WrapEnumerator(function() return f(args); end);
	end;
end;

function wrapyield(yieldVal, isEnumerableOrEnumerator, isUnityYield)
	if isEnumerableOrEnumerator then
		Yield(yieldVal);
	elseif isUnityYield then
		Yield(yieldVal);
	else
		coroutine.yield(yieldVal);
	end;
end;

LuaConsole = {
  Write = function(...)
    io.write(...);
  end,
  Print = function(...)
  	print(...);
  end,
};

function defineclass(base, static, static_props, static_events, instance_build, instance_props, instance_events)
    
    local base_class = base or {};
    local mt = getmetatable(base_class);

    local class = static or {};
    local class_props = static_props or {};
    local class_events = static_events or {};
    class["__cs2lua_defined"] = true;
    
    setmetatable(class, {
        __call = function()
        		local baseObj = nil;
        		if mt then
        			baseObj = mt.__call();
        		end;
            local obj = nil;
            if instance_build then
            	obj = instance_build();
            else
            	obj = {};
            end;
            local obj_props = instance_props or {};
            local obj_events = instance_events or {};
            obj["base"] = baseObj;
            
            setmetatable(obj, {
            		__class = class,                
                __index = function(t, k)
                    local ret;
                    ret = obj_props[k];
                    if ret then
                      if ret.get then
                        ret = ret.get(t);
                      else
                        ret = nil;
                      end;
                    elseif baseObj then
                    	ret = baseObj[k];
                    end;
                    return ret;
                end,

                __newindex = function(t, k, v)
                    local ret;
                    ret = obj_props[k];
                    if ret then
                      if ret.set then
                        ret.set(t, v);
                      end;
                      return;
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
            ret = class_props[k];
            if ret then
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
            ret = class_props[k];
            if ret then
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

function newdictionary(type, ctor, dict, ...)
  if dict then
	  local mt = setmetatable({__object=dict}, __mt_dictionary);
	  return setmetatable(dict, { __index = mt, __class = type });
	end;
end;

function newlist(type, ctor, list, ...)
  if list then
	  local mt = setmetatable({__object=list}, __mt_array);
    return setmetatable(list, { __index = mt, __class = type });
  end;
end;

function newcollection(type, ctor, coll, ...)
  if coll then
	  local mt = setmetatable({__object=coll}, __mt_hashset);
    return setmetatable(dict, { __index = mt, __class = type });
  end;
end;

function newexterndictionary(type, className, ctor, doexternsion, dict, ...)
  if dict and type==System.Collections.Generic.Dictionary_TKey_TValue then
	  local mt = setmetatable({__object=dict}, __mt_dictionary);
	  return setmetatable(dict, { __index = mt, __class = type });
	else
	  return newexternobject(type, className, ctor, doexternsion, dict, ...);
	end;
end;

function newexternlist(type, className, ctor, doexternsion, list, ...)
  if list and (type==System.Collections.Generic.List_T or type==System.Collections.Generic.Queue_T or type==System.Collections.Generic.Stack_T) then    
	  local mt = setmetatable({__object=list}, __mt_array);
    return setmetatable(list, { __index = mt, __class = type });
	else
	  return newexternobject(type, className, ctor, doexternsion, list, ...);
  end;
end;

function newexterncollection(type, className, ctor, doexternsion, coll, ...)
  if coll and type==System.Collections.Generic.HashSet_T then
	  local mt = setmetatable({__object=coll}, __mt_hashset);
    return setmetatable(dict, { __index = mt, __class = type });
	else
	  return newexternobject(type, className, ctor, doexternsion, coll, ...);
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

function getexternstaticindexer(class, ...)
	return class[...];
end;
function getexterninstanceindexer(obj, ...)  
	local args = {...};
	local index = args[1];
	local meta = getmetatable(obj);
	if meta then
  	if meta.__class == System.Collections.Generic.List_T then
  	  return obj[index+1];
  	elseif meta.__class == System.Collections.Generic.Dictionary_TKey_TValue then
      return obj[index];
    end;
  end;
end;

function setexternstaticindexer(class, ...)
  
end;
function setexterninstanceindexer(obj, ...)
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
    end;
  end;
end;

function getelement(obj, ...)
  return nil;
end;
function setelement(obj, ...)
  --为了适应表达式内嵌赋值，这个函数需要返回值
  return nil;
end;
function getexternement(obj, ...)
  return nil;
end;
function setexternement(obj, ...)
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