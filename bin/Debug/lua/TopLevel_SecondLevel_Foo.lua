require "utility";
require "namespaces";
require "TopLevel_SecondLevel_FooBase";
require "TopLevel_SecondLevel_GenericClass_T";

TopLevel.SecondLevel.Foo = {
	cctor = function()
		TopLevel.SecondLevel.FooBase.cctor(this);
	end,


	__new_object = function(...)
		local args = ...;
		return (function() local obj = newobject(TopLevel.SecondLevel.Foo, "ctor", args); return obj; end)();
	end,
	__define_class = function()
		local static = TopLevel.SecondLevel.Foo;

		local static_props = {
		};

		local static_events = {
		};

		local instance = {
			ctor = function(this)
				this:ctor__System_Int32(0);
				return this;
			end,
			ctor__System_Int32 = function(this, v)
				base.ctor(this);
				this.m_Test = v;
				return this;
			end,
			ctor__System_Int32__System_Int32 = function(this, a, b)
				base.ctor(this);
				return this;
			end,
			GTest__TopLevel_SecondLevel_GenericClass_Int32 = function(this, arg)
			end,
			GTest__TopLevel_SecondLevel_GenericClass_Single = function(this, arg)
			end,
			Test = function(this)
				local t = (function() local __compiler_newobject_96; __compiler_newobject_96 = newobject(TopLevel.SecondLevel.GenericClass_T.InnerGenericClass_TT, "ctor", (function() local __compiler_newobject_96; __compiler_newobject_96 = newobject(TopLevel.SecondLevel.Foo.Test1, "ctor"); return __compiler_newobject_96; end)(), (function() local __compiler_newobject_96; __compiler_newobject_96 = newobject(TopLevel.SecondLevel.Foo.Test2, "ctor"); return __compiler_newobject_96; end)()); return __compiler_newobject_96; end)();
				t:Test(System.Int32, 123);
				t:Test2(System.Int32, (function() local __compiler_newobject_98; __compiler_newobject_98 = newobject(TopLevel.SecondLevel.Foo.Test1, "ctor"); return __compiler_newobject_98; end)(), (function() local __compiler_newobject_98; __compiler_newobject_98 = newobject(TopLevel.SecondLevel.Foo.Test2, "ctor"); return __compiler_newobject_98; end)());
			end,

			OnSimple = wrapdelegation{},
			OnSimple2 = wrapdelegation{},
			m_Test = 0,
			m_Test2 = 0,
		};

		local instance_props = {
		};

		local instance_events = {
		};

		return defineclass(TopLevel.SecondLevel.FooBase, static, static_props, static_events, instance, instance_props, instance_events);
	end,
};

TopLevel.SecondLevel.Foo.__define_class();

--local obj = TopLevel.Child2.Bar:new();
--obj:Test();

TopLevel.SecondLevel.Foo.Test1 = {
	cctor = function()
	end,


	__new_object = function(...)
		return newobject(TopLevel.SecondLevel.Foo.Test1, nil, ...);
	end,
	__define_class = function()
		local static = TopLevel.SecondLevel.Foo.Test1;

		local static_props = {
		};

		local static_events = {
		};

		local instance = {
			ctor = function(this)
			end,

		};

		local instance_props = {
		};

		local instance_events = {
		};

		return defineclass(nil, static, static_props, static_events, instance, instance_props, instance_events);
	end,
};

TopLevel.SecondLevel.Foo.Test1.__define_class();


TopLevel.SecondLevel.Foo.Test2 = {
	cctor = function()
	end,


	__new_object = function(...)
		return newobject(TopLevel.SecondLevel.Foo.Test2, nil, ...);
	end,
	__define_class = function()
		local static = TopLevel.SecondLevel.Foo.Test2;

		local static_props = {
		};

		local static_events = {
		};

		local instance = {
			ctor = function(this)
			end,

		};

		local instance_props = {
		};

		local instance_events = {
		};

		return defineclass(nil, static, static_props, static_events, instance, instance_props, instance_events);
	end,
};

TopLevel.SecondLevel.Foo.Test2.__define_class();


TopLevel.SecondLevel.Foo.FooChild = {
	cctor = function()
	end,


	__new_object = function(...)
		return newobject(TopLevel.SecondLevel.Foo.FooChild, nil, ...);
	end,
	__define_class = function()
		local static = TopLevel.SecondLevel.Foo.FooChild;

		local static_props = {
		};

		local static_events = {
		};

		local instance = {
			ctor = function(this)
			end,

			m_Test1 = 123,
			m_Test2 = 456,
		};

		local instance_props = {
		};

		local instance_events = {
		};

		return defineclass(nil, static, static_props, static_events, instance, instance_props, instance_events);
	end,
};

TopLevel.SecondLevel.Foo.FooChild.__define_class();

