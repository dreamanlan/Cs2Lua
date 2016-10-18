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
	if v1~=nil then
		return v1;
	else
		return v2;
	end;
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

__mt_array__ = {
	__index = function(t, k)
		if k=="Length" then
			return table.maxn(t);
		elseif k=="GetLength" then
			return function(ix)
			    local ret = 0;
			    local tb = t;
			    for i=0,ix do			       
			      ret = table.maxn(tb);
			      tb = tb[0];
			    end;
			    return ret;
			  end;
		end;
	end,
};

__mt_dictionary__ = {
	__index = function(t, k)
		if k=="Count" then
			return table.maxn(t);
		elseif k=="Add" then
		  return function(p1,p2) t[p1]=p2; return p2; end;
		elseif k=="Remove" then
		  return function(p)
		      local pos = 1;
		      local ret = nil;
		      for k,v in pairs(t) do		        
		        if k==p then
		          ret=v;
		          break;
		        end;
		        pos=pos+1;		        
		      end;
		      if pos>=1 and pos<=table.maxn(t) then
		        table.remove(t,pos);
		      end;
		      return v;
		    end;
		elseif k=="ContainsKey" then
		  return function(p)
		      if t[p]~=nil then
		        return true;
		      end;
		      local ret = false;
		      for k,v in pairs(t) do		        
		        if k==p then
		          ret=true;
		          break;
		        end;
		      end;
		      return ret;
		    end;
		elseif k=="ContainsValue" then
		  return function(p)
		      local ret = false;
		      for k,v in pairs(t) do		        
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

function wraparray(arr)
	return setmetatable(arr, __mt_array__);
end;

function wrapdictionary(dict)
	return setmetatable(dict, __mt_dictionary__);
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