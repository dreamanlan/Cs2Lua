require "cs2lua_utility";
require "cs2lua_namespaces";
require "TopLevel_SecondLevel_FooBase";
require "TopLevel_SecondLevel_GenericClass_T";

TopLevel.SecondLevel.Foo = {
	cctor = function()
		TopLevel.SecondLevel.FooBase.cctor(this);
	end,


	__new_object = function(...)
		return newobject(TopLevel.SecondLevel.Foo, "ctor", {}, args);
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
				this.__ctor();
				return this;
			end,
			ctor__System_Int32 = function(this, v)
				base.ctor(this);
				this.__ctor();
				this.m_Test = v;
				return this;
			end,
			ctor__System_Int32__System_Int32 = function(this, a, b)
				base.ctor(this);
				this.__ctor();
				return this;
			end,
			GTest__TopLevel_SecondLevel_GenericClass_Int32 = function(this, arg)
			end,
			GTest__TopLevel_SecondLevel_GenericClass_Single = function(this, arg)
			end,
			Test = function(this)
				local t = newobject(TopLevel.SecondLevel.GenericClass_T.InnerGenericClass_TT, "ctor", {}, newobject(TopLevel.SecondLevel.Foo.Test1, "ctor", {}), newobject(TopLevel.SecondLevel.Foo.Test2, "ctor", {}));
				t:Test(System.Int32, 123);
				t:Test2(System.Int32, newobject(TopLevel.SecondLevel.Foo.Test1, "ctor", {}), newobject(TopLevel.SecondLevel.Foo.Test2, "ctor", {}));
			end,
			TestContinueAndReturn = function(this)
				local i = 0;
				while i < 100 do
				repeat
					if i < 10 then
						break;
					end;
					do
					return ix;
					end;
					i = i + 1;
				until true;
				end;
				return -1;
			end,
			TestSwitch = function(this)
				local i = 10;
				local __compiler_switch_137 = i;
				if __compiler_switch_137 == 1 then
					return ;
				elseif __compiler_switch_137 == 2 then
					return ;
				else
					return ;
				end;
				if i > 3 then
					return ;
				end;
				if typeis(this, "TopLevel.SecondLevel.FooBase") then
					return ;
				end;
			end,
			__ctor = function(this)
				if this.__ctor_called then
					return;
				else
					this.__ctor_called = true;
				end
				TopLevel.SecondLevel.Foo.__install_TopLevel_SecondLevel_FooExtension(this);
			end,

			OnSimple = wrapdelegation{},
			OnSimple2 = wrapdelegation{},
			m_Test = 0,
			m_Test2 = 0,
			m_HashSet = newcollection(System.Collections.Generic.HashSet_T, "ctor", nil, {{"one", "two", "three"}}),
			__ctor_called = false,
		};

		local instance_props = {
			Val = {
				get = function(this)
					return this.m_Test;
				end,
				set = function(this, value)
				end,
			},
		};

		local instance_events = {
		};

		return defineclass(TopLevel.SecondLevel.FooBase, static, static_props, static_events, instance, instance_props, instance_events);
	end,
};


TopLevel.SecondLevel.Foo.__define_class();


TopLevel.SecondLevel.Foo.Test1 = {
	cctor = function()
	end,


	__new_object = function(...)
		return newobject(TopLevel.SecondLevel.Foo.Test1, nil, {}, ...);
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
		return newobject(TopLevel.SecondLevel.Foo.Test2, nil, {}, ...);
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
		return newobject(TopLevel.SecondLevel.Foo.FooChild, nil, {}, ...);
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

