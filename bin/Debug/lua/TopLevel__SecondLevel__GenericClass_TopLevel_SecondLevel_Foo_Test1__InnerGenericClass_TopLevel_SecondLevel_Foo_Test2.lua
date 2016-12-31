require "cs2lua__utility";
require "cs2lua__namespaces";
require "TopLevel__SecondLevel__GenericClass_TopLevel_SecondLevel_Foo_Test1";
require "TopLevel__SecondLevel__Foo";

TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2 = {
	__new_object = function(...)
		return newobject(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2, "ctor", {}, ...);
	end,
	__define_class = function()
		local static = TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2;

		local static_methods = {
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

		local instance_methods = {
			ctor = function(this, v, vv)
				this.m_T = v;
				this.m_TT = vv;
				local obj1; obj1 = newtypeparamobject(TopLevel.SecondLevel.Foo.Test1);
				local obj2; obj2 = newtypeparamobject(TopLevel.SecondLevel.Foo.Test2);
				return this;
			end,
			Test = function(this, G, g)
				local v; v = typecast(g, TopLevel.SecondLevel.Foo.Test1);
				local v; v = typecast(typecast(g, System.Object), TopLevel.SecondLevel.Foo.Test1);
				local f; f = newobject(TopLevel.SecondLevel.Foo, "ctor", {});
				f:Test3();
			end,
			Test2 = function(this, GG, t, tt)
				local t1; t1 = GG;
				local t2; t2 = TopLevel.SecondLevel.Foo.Test1;
				local t3; t3 = TopLevel.SecondLevel.Foo.Test2;
				local t4; t4 = System.Int32;
				local v; v = typecast(t, TopLevel.SecondLevel.Foo.Test2);
			end,
			__ctor = function(this)
				if this.__ctor_called then
					return;
				else
					this.__ctor_called = true;
				end
			end,
		};

		local instance_fields_build = function()
			local instance_fields = {
				m_T = nil,
				m_TT = nil,
				m_TypeT = TopLevel.SecondLevel.Foo.Test1,
				m_TypeTT = TopLevel.SecondLevel.Foo.Test2,
				__ctor_called = false,
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2.__define_class();

