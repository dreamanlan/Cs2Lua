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

LuaConsole = {
    Print = function(...)
    	print(...);
    end,
}

__mt_array__ = {
	__index = function(t, k)
		if k=="Length" then
			return table.maxn(t);
		elseif k=="GetLength" then
			return function(ix) table.maxn(t) end;
		end;
	end,
};

__mt_dictionary__ = {
	__index = function(t, k)
		if k=="Count" then
			return table.maxn(t);
		end;
	end,
};

function wraparray(arr)
	return setmetatable(arr, __mt_array__);
end;

function wrapdictionary(dict)
	return setmetatable(dict, __mt_dictionary__);
end;
