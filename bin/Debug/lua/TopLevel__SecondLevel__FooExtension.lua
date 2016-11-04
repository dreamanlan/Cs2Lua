require "cs2lua__utility";
require "cs2lua__namespaces";
require "TopLevel__SecondLevel__Foo";
require "GameObject";

TopLevel.SecondLevel.FooExtension = {
	Test3__TopLevel_SecondLevel_Foo = function(obj)
		if (obj.m_Test > 0) then
			obj.m_Test2 = 678;
		end;
		local f = newexternlist(System.Collections.Generic.List_T, "System.Collections.Generic.List_T", "ctor", nil, {{1, 2}, {2, 3}});
	end,
	Test3__TopLevel_SecondLevel_Foo__System_Int32 = function(obj, ix)
	end,
	TestExtern = function(obj)
	end,
	NormalMethod = function()
		LuaConsole.Print(1, 2, 3, 4, 5);
		local f = newobject(TopLevel.SecondLevel.Foo, "ctor", {});
		local ff = newobject(TopLevel.SecondLevel.Foo, "ctor", {});
		local f1 = delegationwrap((function() f:Test() end));
		f1();
		local f2 = delegationwrap((function() f:Test3() end));
		f2();
		TopLevel.SecondLevel.FooExtension.Test3__TopLevel_SecondLevel_Foo(f);
		local r = TopLevel.SecondLevel.Foo.op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo(f, ff);
		f = TopLevel.SecondLevel.Foo.op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo(f, ff);
		local rr = TopLevel.SecondLevel.Foo.op_Explicit(123);
		local rrr = typecast(123, TopLevel.SecondLevel.Foo);
		local obj = ;
		local arr = wraparray{1, 2, 3, 4, 56};
		local v = arr[3];
		local dict = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "System.Collections.Generic.Dictionary_TKey_TValue", "ctor", nil, {[1] = 2, [3] = 4});
		local v1 = condaccess(dict, getexterninstanceindexer(dict, 1));
		local list = nil;
		local l = condaccess(list, list.Count);
		condaccess(list, listthis:Add(1));
		local v2 = condaccess(list, setexterninstanceindexer(list, 3, 1));
		local arr2 = wraparray{1, 2, 3, 4};
		local v3 = condaccess(arr2, arr2[3]);
		condaccess(arr2, (function() arr2[4] = 345; return 345; end)());
		local a = 1;
		local b = 2;
		local c = 3;
		a = (function() b = c; return b; end)();
		c = c + 1;
	end,
	cctor = function()
	end,


	__define_class = function()
		TopLevel.SecondLevel.Foo.__install_TopLevel__SecondLevel__FooExtension = function(obj)
			obj.Test3__TopLevel_SecondLevel_Foo = TopLevel.SecondLevel.FooExtension.Test3__TopLevel_SecondLevel_Foo;
		end
		GameObject.__install_TopLevel__SecondLevel__FooExtension = function(obj)
			obj.TestExtern = TopLevel.SecondLevel.FooExtension.TestExtern;
		end
		local static = TopLevel.SecondLevel.FooExtension;

		local static_props = {
		};

		local static_events = {
		};

		return defineclass(nil, static, static_props, static_events, nil, nil, nil);
	end,
};


TopLevel.SecondLevel.FooExtension.__define_class();

--local obj = TopLevel.Child2.Bar:new();
--obj:Test();
