require "cs2lua_utility";
require "cs2lua_namespaces";
require "TopLevel_SecondLevel_Foo";

TopLevel.SecondLevel.FooExtension = {
	Test3__TopLevel_SecondLevel_Foo = function(obj)
		if obj.m_Test > 0 then
			obj.m_Test2 = 678;
		end;
	end,
	Test3__TopLevel_SecondLevel_Foo__System_Int32 = function(obj, ix)
	end,
	NormalMethod = function()
		LuaConsole.Print(1, 2, 3, 4, 5);
		local f = newobject(TopLevel.SecondLevel.Foo, "ctor");
		local f1 = delegationwrap((function() f:Test() end));
		f1();
		local f2 = delegationwrap((function() f:Test3() end));
		f2();
		TopLevel.SecondLevel.FooExtension.Test3__TopLevel_SecondLevel_Foo(f);
	end,
	cctor = function()
	end,


	__define_class = function()
		TopLevel.SecondLevel.Foo.__install_TopLevel_SecondLevel_FooExtension = function()
			this.Test3__TopLevel_SecondLevel_Foo = TopLevel.SecondLevel.FooExtension.Test3__TopLevel_SecondLevel_Foo;
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
