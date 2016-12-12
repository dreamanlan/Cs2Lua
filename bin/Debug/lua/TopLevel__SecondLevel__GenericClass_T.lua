require "cs2lua__utility";
require "cs2lua__namespaces";

TopLevel.SecondLevel.GenericClass_T = {
	cctor = function()
		TopLevel.SecondLevel.GenericClass_T.__cctor();
		TopLevel.SecondLevel.GenericClass_T.s_Test = 9876;
	end,
	__cctor = function()
		if TopLevel.SecondLevel.GenericClass_T.__cctor_called then
			return;
		else
			TopLevel.SecondLevel.GenericClass_T.__cctor_called = true;
		end
		TopLevel.SecondLevel.GenericClass_T.s_Inst = newtypeparamobject(T)
	end,

	__new_object = function(...)
		return (function(...) local obj, v, v2 = newobject(TopLevel.SecondLevel.GenericClass_T, "ctor", {}, ...); return obj; end)(...);
	end,
	__define_class = function()
		local static = TopLevel.SecondLevel.GenericClass_T;
		local static_fields = {
			TTT = 789,
			s_Test = 2147483647,
			s_Float = wrapconst(System.Single, "PositiveInfinity"),
			s_Inst = true,
			__cctor_called = false,
		};
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			ctor = function(this, T, v)
				local v2 = nil;
				this:__ctor(T);
				local obj; obj = newtypeparamobject(T);
				this.m_Test = (v + 456);
				v2 = 123;
				return this, v, v2;
			end,
			Test = function(this, G)
				local t; t = G;
			end,
			__ctor = function(this, T)
				if this.__ctor_called then
					return;
				else
					this.__ctor_called = true;
				end
				this.m_Inst = newtypeparamobject(T)
			end,
		};

		local instance_build = function()
			local instance_fields = {
				m_Test = 123,
				m_Test2 = (TopLevel.SecondLevel.GenericClass_T.TTT + 1),
				m_Inst = true,
				__ctor_called = false,
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "TopLevel.SecondLevel.GenericClass_T", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


TopLevel.SecondLevel.GenericClass_T.__define_class();


TopLevel.SecondLevel.GenericClass_T.InnerGenericClass_TT = {
	cctor = function()
	end,

	__new_object = function(...)
		return newobject(TopLevel.SecondLevel.GenericClass_T.InnerGenericClass_TT, "ctor", {}, ...);
	end,
	__define_class = function()
		local static = TopLevel.SecondLevel.GenericClass_T.InnerGenericClass_TT;
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			ctor = function(this, TT, T, v, vv)
				this:__ctor(TT, T);
				this.m_T = v;
				this.m_TT = vv;
				local obj1; obj1 = newtypeparamobject(T);
				local obj2; obj2 = newtypeparamobject(TT);
				return this;
			end,
			Test = function(this, G, g)
				local v; v = typecast(g, this.__type_params[2]);
				local v; v = typecast(typecast(g, System.Object), this.__type_params[2]);
				local f; f = newobject(TopLevel.SecondLevel.Foo, "ctor", {});
				f:Test3();
			end,
			Test2 = function(this, GG, t, tt)
				local t1; t1 = GG;
				local t2; t2 = this.__type_params[2];
				local t3; t3 = this.__type_params[1];
				local t4; t4 = System.Int32;
				local v; v = typecast(t, this.__type_params[1]);
			end,
			__ctor = function(this, TT, T)
				if this.__ctor_called then
					return;
				else
					this.__ctor_called = true;
				end
				this.__type_params = {TT, T};
				this.m_TypeT = T
				this.m_TypeTT = TT
			end,
		};

		local instance_build = function()
			local instance_fields = {
				m_T = nil,
				m_TT = nil,
				m_TypeT = true,
				m_TypeTT = true,
				__ctor_called = false,
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "TopLevel.SecondLevel.GenericClass_T.InnerGenericClass_TT", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


TopLevel.SecondLevel.GenericClass_T.InnerGenericClass_TT.__define_class();

