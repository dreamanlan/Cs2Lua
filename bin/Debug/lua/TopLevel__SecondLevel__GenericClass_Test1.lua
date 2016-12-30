require "cs2lua__utility";
require "cs2lua__namespaces";

TopLevel.SecondLevel.GenericClass_Test1 = {
	__new_object = function(...)
		return (function(...) local obj, v, v2 = newobject(TopLevel.SecondLevel.GenericClass_Test1, "ctor", {}, ...); return obj; end)(...);
	end,
	__define_class = function()
		local static = TopLevel.SecondLevel.GenericClass_Test1;

		local static_methods = {
			cctor = function()
				s_Test = 9876;
			end,
			__cctor = function()
				if TopLevel.SecondLevel.GenericClass_Test1.__cctor_called then
					return;
				else
					TopLevel.SecondLevel.GenericClass_Test1.__cctor_called = true;
				end
				TopLevel.SecondLevel.GenericClass_Test1.s_Inst = newtypeparamobject(Test1);
			end,
		};

		local static_fields_build = function()
			local static_fields = {
				TTT = 789,
				s_Test = 2147483647,
				s_Float = wrapconst(System.Single, "PositiveInfinity"),
				s_Inst = false,
				__cctor_called = false,
			};
			return static_fields;
		end;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			ctor = function(this, v)
				local v2 = nil;
				local obj; obj = newtypeparamobject(Test1);
				m_Test = (v + 456);
				v2 = 123;
				return this, v, v2;
			end,
			Test = function(this, G)
				local t; t = G;
			end,
			__ctor = function(this)
				if this.__ctor_called then
					return;
				else
					this.__ctor_called = true;
				end
				this.m_Inst = newtypeparamobject(Test1);
			end,
		};

		local instance_fields_build = function()
			local instance_fields = {
				m_Test = 123,
				m_Test2 = (TTT + 1),
				m_Inst = false,
				__ctor_called = false,
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "TopLevel.SecondLevel.GenericClass_Test1", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


TopLevel.SecondLevel.GenericClass_Test1.__define_class();

