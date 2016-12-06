require "cs2lua__utility";
require "cs2lua__namespaces";
require "TopLevel__SecondLevel__Foo";

TopLevel.SecondLevel.FooExtension = {
	Test3__TopLevel_SecondLevel_Foo = function(obj)
		if (obj.m_Test > 0) then
			obj.m_Test2 = 678;
		end;
		local f; f = newexternlist(System.Collections.Generic.List_T, "System.Collections.Generic.List_T", "ctor", (function(obj) System.Collections.Generic.List_T.__install_Extentions(obj); end), {{1, 2}, {2, 3}});
	end,
	Test3__TopLevel_SecondLevel_Foo__System_Int32 = function(__compiler_cs_this, ix)
		__compiler_cs_this:Test123(123, 456);
	end,
	TestExtern = function(obj)
	end,
	NormalMethod = function()
		LuaConsole.Print(1, 2, 3, 4, 5);
		local f; f = newobject(TopLevel.SecondLevel.Foo, "ctor", {});
		local ff; ff = newobject(TopLevel.SecondLevel.Foo, "ctor", {});
		local f1; f1 = delegationwrap((function() f:Test() end));
		f1();
		local f2; f2 = delegationwrap((function() f:Test3() end));
		f2();
		TopLevel.SecondLevel.FooExtension.Test3__TopLevel_SecondLevel_Foo(f);
		local r; r = TopLevel.SecondLevel.Foo.op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo(f, ff);
		f = TopLevel.SecondLevel.Foo.op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo(f, ff);
		local rr; rr = TopLevel.SecondLevel.Foo.op_Explicit(123);
		local rrr; rrr = typecast(123, TopLevel.SecondLevel.Foo);
		local obj; obj = newexternobject(UnityEngine.GameObject, "UnityEngine.GameObject", "ctor", (function(obj) UnityEngine.GameObject.__install_TopLevel_SecondLevel_FooExtension(obj); end), {}, wrapstring("test test test"));
		local arr; arr = wraparray{1, 2, 3, 4, 56};
		local v; v = arr[3];
		local dict; dict = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "System.Collections.Generic.Dictionary_TKey_TValue", "ctor", nil, {[1] = 2, [3] = 4});
		local v1; v1 = condaccess(dict, getexterninstanceindexer(dict, nil, "get_Item", 1));
		local list; list = nil;
		local l; l = condaccess(list, list.Count);
		condaccess(list, listthis:Add(1));
		local v2; v2 = condaccess(list, setexterninstanceindexer(list, nil, "set_Item", 3, 1));
		local arr2; arr2 = wraparray{1, 2, 3, 4};
		local v3; v3 = condaccess(arr2, arr2[3 + 1]);
		condaccess(arr2, (function() arr2[4 + 1] = 345; return 345; end)());
		local a; a = 1;
		local b; b = 2;
		local c; c = 3;
		a = (function() b = c; return b; end)();
		c = c + 1;
	end,
	cctor = function()
	end,

	__define_class = function()
		rawset(TopLevel.SecondLevel.Foo, "__install_TopLevel__SecondLevel__FooExtension", (function(obj)
			rawset(obj, "Test3__TopLevel_SecondLevel_Foo", TopLevel.SecondLevel.FooExtension.Test3__TopLevel_SecondLevel_Foo);
		end));
		rawset(UnityEngine.GameObject, "__install_TopLevel__SecondLevel__FooExtension", (function(obj)
			rawset(obj, "TestExtern", TopLevel.SecondLevel.FooExtension.TestExtern);
		end));
		local static = TopLevel.SecondLevel.FooExtension;
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		return defineclass(nil, "TopLevel.SecondLevel.FooExtension", static, static_fields, static_props, static_events, nil, nil, nil, nil, nil, nil, false);
	end,
};


TopLevel.SecondLevel.FooExtension.__define_class();

