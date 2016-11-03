System = System or {};
System.Collections = System.Collections or {};
System.Collections.Generic = System.Collections.Generic or {};
System.Collections.Generic.List_T = {};
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

__mt_array = {
	__index = function(t, k)
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
		end;
	end,
};

__mt_dictionary = {
	__index = function(t, k)
		if k=="Count" then
			return table.maxn(t);
		elseif k=="Add" then
		  return function(obj, p1,p2) obj[p1]=p2; return p2; end;
		elseif k=="Remove" then
		  return function(obj, p)
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
	      if obj[p]~=nil then
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

function wrapstring(str)
  if type(str)=="string" then
    return System.String(str);
  else
    return str;
  end;
end;

function wraparray(arr)
	return setmetatable(arr, __mt_array);
end;

function wrapdictionary(dict)
	return setmetatable(dict, __mt_dictionary);
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
            obj["__class"] = class;
            obj["base"] = baseObj;
            
            setmetatable(obj, {                
                __index = function(t, k)
                    local ret;
                    ret = obj_props[k];
                    if nil ~= ret then
                      if nil ~= ret.get then
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
                    if nil ~= ret then
                      if nil ~= ret.set then
                        ret.set(t, v);
                      end;
                      return;
                    end;
                    if nil == baseObj or not pcall(function() baseObj[k] = v end) then
                        rawset(t, k, v);
                    end;
                end,
                
            });

            return obj;
        end,
        
        __index = function(t, k)
            local ret;
            ret = class_props[k];
            if nil ~= ret then
              if nil ~= ret.get then
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
            if ret ~= nil then
              if nil ~= ret.set then
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
    dict["__class"] = type;
	  return setmetatable(dict, __mt_dictionary);
	end;
end;

function newlist(type, ctor, list, ...)
  if list then
    list["__class"] = type;
    return setmetatable(list, __mt_array);
  end;
end;

function newcollection(type, ctor, coll, ...)
  if coll then
    coll["__class"] = type;
    return setmetatable(dict, __mt_array);
  end;
end;

function newexterndictionary(type, className, ctor, doexternsion, dict, ...)
  if dict and type==System.Collections.Generic.Dictionary_TKey_TValue then    
    dict["__class"] = type;
	  return setmetatable(dict, __mt_dictionary);
	else
	  return newexternobject(type, className, ctor, doexternsion, dict, ...);
	end;
end;

function newexternlist(type, className, ctor, doexternsion, list, ...)
  if list and type==System.Collections.Generic.List_T then
    list["__class"] = type;
    return setmetatable(list, __mt_array);
	else
	  return newexternobject(type, className, ctor, doexternsion, list, ...);
  end;
end;

function newexterncollection(type, className, ctor, doexternsion, coll, ...)
  if coll and type==System.Collections.Generic.HashSet_T then
    coll["__class"] = type;
    return setmetatable(coll, __mt_array);
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
	if obj.__class == System.Collections.Generic.List_T then
	  return obj[index+1];
	else
	  return obj[...];
  end;
end;

function getelement(obj, ...)
  return nil;
end;
function setelement(obj, ...)
  --为了适应表达式内嵌赋值，这个函数需要返回值
  return nil;
end;
function getexternelement(obj, ...)
  return nil;
end;
function setexternelement(obj, ...)
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