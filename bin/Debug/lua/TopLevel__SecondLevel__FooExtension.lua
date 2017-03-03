require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";
require "TopLevel__SecondLevel__Foo";
require "LuaConsole";

TopLevel.SecondLevel.FooExtension = {
	__define_class = function()
		local static = TopLevel.SecondLevel.FooExtension;

		local static_methods = {
			Test3__TopLevel_SecondLevel_Foo = function(obj)
				if (obj.m_Test > 0) then
					obj.m_Test2 = 678;
				end;
				local f; f = newexternlist(CS.System.Collections.Generic.List_T, "CS.System.Collections.Generic.List_T", "ctor", {{1, 2}, {2, 3}});
			end,
			Test3__TopLevel_SecondLevel_Foo__CS_System_Int32 = function(__compiler_cs_this, ix)
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
				local rrr; rrr = typeas(123, TopLevel.SecondLevel.Foo, false);
				local obj; obj = newexternobject(CS.UnityEngine.GameObject, "CS.UnityEngine.GameObject", "ctor", {}, "test test test");
				TopLevel.SecondLevel.FooExtension.Test3__TopLevel_SecondLevel_Foo__CS_System_Int32(f, 8);
				local arr; arr = wraparray{1, 2, 3, 4, 4};
				local v; v = arr[3];
				local dict; dict = newexterndictionary(CS.System.Collections.Generic.Dictionary_TKey_TValue, "CS.System.Collections.Generic.Dictionary_TKey_TValue", "ctor", {[tostring(1)] = 2, [tostring(3)] = 4});
				local v1; v1 = condaccess(dict, (function() return getexterninstanceindexer(dict, nil, "get_Item", 1); end));
				local list; list = nil;
				local l; l = condaccess(list, (function() return list.Count; end));
				condaccess(list, (function() return listthis:Add(1); end));
				local v2; v2 = condaccess(list, (function() return setexterninstanceindexer(list, nil, "set_Item", 3, 1); end));
				local arr2; arr2 = wraparray{1, 2, 3, 4};
				local v3; v3 = condaccess(arr2, (function() return arr2[3]; end));
				condaccess(arr2, (function() arr2[4] = 345; return 345; end));
				local a; a = 1;
				local b; b = 2;
				local c; c = 3;
				a = (function() b = c; return b; end)();
				c = invokeintegeroperator(2, "+", c, 1, CS.System.Int32, CS.System.Int32);
			end,
			cctor = function()
			end,
		};

		local static_fields_build = function()
			local static_fields = {
			};
			return static_fields;
		end;
		local static_props = nil;
		local static_events = nil;

		return defineclass(nil, "TopLevel.SecondLevel.FooExtension", static, static_methods, static_fields_build, static_props, static_events, nil, nil, nil, nil, nil, nil, false);
	end,
};

TopLevel.SecondLevel.FooExtension.__define_class();
