jit.off();
jit.flush();

function inc(v)
    return v+1;
end;
function get(arr, index)
    return arr[index];
end;
function set(arr, index, v)
    arr[index]=v;
end;

function test1()
    local t1 = os.time();
    local v = 0;
    for i = 1, 100000000 do
        v = inc(v);
    end;
    local t2 = os.time();
    print(os.difftime(t2,t1), v);
end;
function test2()
    local t1 = os.time();
    local v = 0;
    for i = 1, 100000000 do
        v = (function(v0) return v0+1; end)(v);
    end;
    local t2 = os.time();
    print(os.difftime(t2,t1), v);
end;

--test1();
--test2();

function test3()
    local t1 = os.time();
    local v = {0};
    for i = 1, 100000000 do
        v[1] = inc(v[1]);
    end;
    local t2 = os.time();
    print(os.difftime(t2,t1), v[1]);
end;
function test4()
    local t1 = os.time();
    local v = {0};
    for i = 1, 100000000 do
        set(v,1,inc(get(v,1)));
    end;
    local t2 = os.time();
    print(os.difftime(t2,t1), v[1]);
end;

test3();
test4();