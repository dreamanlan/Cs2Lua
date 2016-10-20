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

function nullablecondexp(v1,v2)
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
		if k=="Length" then
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
      return function(obj, v) table.insert(obj, v);
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
        if pos>=1 and pos<=table.maxn(obj) then
          table.remove(obj,pos);
        end;
        return v;
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
		      if pos>=1 and pos<=table.maxn(obj) then
		        table.remove(obj,pos);
		      end;
		      return v;
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

};

function wraparray(arr)
	return setmetatable(arr, __mt_array);
end;

function wrapdictionary(dict)
	return setmetatable(dict, __mt_dictionary);
end;

function wrapdelegation()
  return setmetatable({}, __mt_delegation);
end;

LuaConsole = {
  Print = function(...)
  	print(...);
  end,
};

LuaString = {
  Format = function(fmt,...)
    return string.format(fmt,...);
  end,
};

function defineclass(static, static_props, static_events, instance, instance_props, instance_events)
    local class = static or {};
    local class_props = static_props or {};
    local class_events = static_events or {};
    setmetatable(class, {            
        __call = function()
            local obj = instance or {};
            local obj_props = instance_props or {};
            local obj_events = instance_events or {};
            obj["__class"] = class;
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
                    rawset(t, k, v);
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

function newinternobject(class, ctorclosure)
  local obj = class();
  obj = ctorclosure(obj);
  return obj;
end;

function newexternobject(class, ctorclosure)
  local obj = ctorclosure(class);
  return obj;
end;

function newobject(class, ctorclosure)
  local obj = class();
  obj = ctorclosure(obj);
  return obj;
end;

function delegationwrap(handler)
  return { handler };
end;

function interndelegationset(v, handler)

end;
function interndelegationadd(v, handler)

end;
function interndelegationremove(v, handler)

end;

function externdelegationset(v, handler)

end;
function externdelegationadd(v, handler)

end;
function interndelegationremove(v, handler)

end;

function defineentry(class)
  _G.main = function()
    return class;
  end;
end;