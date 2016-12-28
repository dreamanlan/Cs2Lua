require "cs2lua__utility";
require "cs2lua__attributes";
require "cs2lua__namespaces";
require "TopLevel__SecondLevel__FooBase";
require "TopLevel__TestStruct";
require "TopLevel__Singleton_T";
require "TopLevel__SecondLevel__GenericClass_T";
require "TopLevel__Runnable";

TopLevel.SecondLevel.Foo = {
	add_StaticEventBridge = function(value)
	end,
	remove_StaticEventBridge = function(value)
	end,
	op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo = function(self, other)
		self.m_Test = (self.m_Test + other.m_Test);
		return self;
	end,
	op_Addition__TopLevel_SecondLevel_Foo__System_Int32 = function(self, val)
		self.m_Test = (self.m_Test + val);
		return self;
	end,
	op_Explicit = function(a)
		local f; f = newobject(TopLevel.SecondLevel.Foo, "ctor", {});
		f.m_Test = a;
		f.Val = newobject(TopLevel.TestStruct, "ctor", {});
		local ts; ts = f.Val;
		ts = wrapvaluetype(ts);
		setinstanceindexer(f, nil, "set_Item", ts, ts, 123);
		local r; r = getinstanceindexer(f, nil, "get_Item", ts, ts);
		condaccess(f, (function() return setinstanceindexer(f, nil, "set_Item", ts, ts, 123); end));
		r = condaccess(f, (function() return getinstanceindexer(f, nil, "get_Item", ts, ts); end));
		local result; result = TopLevel.Singleton_T.get_instance(TopLevel.SecondLevel.Foo):Test123(1, 2);
		TopLevel.Singleton_T.set_instance(TopLevel.SecondLevel.Foo, nil);
		return f;
	end,
	cctor = function()
		TopLevel.SecondLevel.FooBase.cctor(this);
	end,

	__new_object = function(...)
		return newobject(TopLevel.SecondLevel.Foo, "ctor", {}, ...);
	end,
	__define_class = function()
		local static = TopLevel.SecondLevel.Foo;
		local static_fields = {
			__attributes = TopLevel__SecondLevel__Foo__Attrs,
		};
		local static_props = nil;
		local static_events = {
			StaticEventBridge = {
				add = static.add_StaticEventBridge,
				remove = static.remove_StaticEventBridge,
			},
		};

		local instance_methods = {
			add_EventBridge = function(this, value)
			end,
			remove_EventBridge = function(this, value)
			end,
			get_Val = function(this)
				return this.m_TS;
			end,
			set_Val = function(this, value)
				value = wrapvaluetype(value);
				this.m_TS = value;
			end,
			get_Item = function(this, ...)
				local args = wrapvaluetypearray{...};
				return 1;
			end,
			set_Item = function(this, ...)
				local args = {...};
				local value = table.remove(args);
				args = wrapvaluetypearray(args);
			end,
			ctor = function(this)
				this:ctor__System_Int32(0);
				this:__ctor();
				return this;
			end,
			ctor__System_Int32 = function(this, v)
				base.ctor(this);
				this:__ctor();
				this.m_Test = v;
				return this;
			end,
			ctor__System_Int32__System_Int32 = function(this, a, b)
				base.ctor(this);
				this:__ctor();
				return this;
			end,
			Test123 = function(this, a, b)
				return (a + b);
			end,
			GTest__TopLevel_SecondLevel_GenericClass_Int32 = function(this, arg)
			end,
			GTest__TopLevel_SecondLevel_GenericClass_Single = function(this, arg)
			end,
			Iterator = wrapenumerable(function(this)
				wrapyield(nil, false, false);
				wrapyield(newexternobject(UnityEngine.WaitForSeconds, "UnityEngine.WaitForSeconds", "ctor", nil, {}, 3), false, true);
				return nil;
			end),
			Iterator2 = wrapenumerable(function(this)
				wrapyield(nil, false, false);
				return nil;
			end),
			Test = function(this)
				local t; t = newobject(TopLevel.SecondLevel.GenericClass_T.InnerGenericClass_TT, "ctor", {}, TopLevel.SecondLevel.Foo.Test2, TopLevel.SecondLevel.Foo.Test1, newobject(TopLevel.SecondLevel.Foo.Test1, "ctor", {}), newobject(TopLevel.SecondLevel.Foo.Test2, "ctor", {}));
				t:Test(System.Int32, 123);
				t:Test2(System.Int32, newobject(TopLevel.SecondLevel.Foo.Test1, "ctor", {}), newobject(TopLevel.SecondLevel.Foo.Test2, "ctor", {}));
				local v;
				local vv; vv, v = this:TestLocal();
				local ts; ts = newobject(TopLevel.TestStruct, "ctor", {});
				ts = wrapvaluetype(ts);
				ts.A = 1;
				ts.B = 2;
				ts.C = 3;
				local ts2; ts2 = ts;
				ts2 = wrapvaluetype(ts2);
				local ts3;
				ts3 = ts;
				ts3 = wrapvaluetype(ts3);
				this:TestValueArg(ts);
			end,
			TestLocal = function(this)
				local v = nil;
				local ir; ir = newobject(TopLevel.Runnable, "ctor", {});
								v = 1;
				return 2, v;
			end,
			TestValueArg = function(this, ts)
				ts = wrapvaluetype(ts);
				ts.A = 4;
				ts.B = 5;
				ts.C = 6;
			end,
			TestContinueAndReturn = function(this)
				local i; i = 0;
				while (i < 100) do
				repeat
					if (i < 10) then
						break;
					end;
					do
					return i;
					end;
				until true;
				i = i + 1;
				end;
				return -1;
			end,
			TestSwitch = function(this)
				local i; i = 10;
				local __compiler_switch_428 = i;
				if __compiler_switch_428 == 1 then
					return ;
				elseif __compiler_switch_428 == 2 then
					return ;
				else
					return ;
				end;
				if (i > 3) then
					return ;
				end;
				if typeis(this, TopLevel.SecondLevel.FooBase) then
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
		};

		local instance_build = function()
			local instance_fields = {
				OnSimple = wrapdelegation{},
				OnSimple2 = wrapdelegation{},
				m_Test = 0,
				m_Test2 = 0,
				m_TS = false,
				m_HashSet = newexterncollection(System.Collections.Generic.HashSet_T, "System.Collections.Generic.HashSet_T", "ctor", nil, {wrapstring("one"), wrapstring("two"), wrapstring("three")}),
				__attributes = TopLevel__SecondLevel__Foo__Attrs,
				__ctor_called = false,
			};
			return instance_fields;
		end;

		local instance_props = {
			Val = {
				get = instance_methods.get_Val,
				set = instance_methods.set_Val,
			},
		};

		local instance_events = {
			EventBridge = {
				add = instance_methods.add_EventBridge,
				remove = instance_methods.remove_EventBridge,
			},
		};

		local interfaces = nil;
		local interface_map = nil;

		return defineclass(TopLevel.SecondLevel.FooBase, "TopLevel.SecondLevel.Foo", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
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
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			ctor = function(this)
			end,
		};

		local instance_build = function()
			local instance_fields = {
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "TopLevel.SecondLevel.Foo.Test1", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
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
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			ctor = function(this)
			end,
		};

		local instance_build = function()
			local instance_fields = {
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "TopLevel.SecondLevel.Foo.Test2", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
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
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			ctor = function(this)
			end,
		};

		local instance_build = function()
			local instance_fields = {
				m_Test1 = 123,
				m_Test2 = 456,
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "TopLevel.SecondLevel.Foo.FooChild", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


TopLevel.SecondLevel.Foo.FooChild.__define_class();

