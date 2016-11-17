require "cs2lua__utility";
require "cs2lua__namespaces";

TopLevel.SecondLevel.GenericClass_T = {
	cctor = function()
		TopLevel.SecondLevel.GenericClass_T.s_Test = 9876;
	end,

	TTT = 789,
	s_Test = 8765,

	__new_object = function(...)
		return (function(...) local obj, v, v2 = newobject(TopLevel.SecondLevel.GenericClass_T, "ctor", {}, ...); return obj; end)(...);
	end,
	__define_class = function()
		local static = TopLevel.SecondLevel.GenericClass_T;

		local static_props = {
		};

		local static_events = {
		};

		local instance_methods = {
			ctor = function(this, v)
				local v2 = nil;
				this.m_Test = (v + 456);
				v2 = 123;
				return this, v, v2;
			end,
		};

		local instance_build = function()
			local instance = {
				m_Test = 123,
				m_Test2 = (TopLevel.SecondLevel.GenericClass_T.TTT + 1),
			};
			for k,v in pairs(instance_methods) do
				instance[k] = v;
			end;
			return instance;
		end;

		local instance_props = {
		};

		local instance_events = {
		};

		return defineclass(nil, static, static_props, static_events, instance_build, instance_props, instance_events);
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

		local static_props = {
		};

		local static_events = {
		};

		local instance_methods = {
			ctor = function(this, TT, T, v, vv)
				this.__ctor(TT, T);
				this.m_T = v;
				this.m_TT = vv;
				return this;
			end,
			Test = function(this, G, g)
				local f = newobject(TopLevel.SecondLevel.Foo, "ctor", {});
				f:Test3();
			end,
			Test2 = function(this, GG, t, tt)
				local t1 = GG;
				local t2 = this.T;
				local t3 = this.TT;
				local t4 = System.Int32;
				local v = typecast(t, this.TT);
			end,
			__ctor = function(this, TT, T)
				if this.__ctor_called then
					return;
				else
					this.__ctor_called = true;
				end
					self.m_TypeT = T;
					self.m_TypeTT = TT;
			end,
		};

		local instance_build = function()
			local instance = {
				m_T = nil,
				m_TT = nil,
				m_TypeT = nil,
				m_TypeTT = nil,
				__ctor_called = false,
			};
			for k,v in pairs(instance_methods) do
				instance[k] = v;
			end;
			return instance;
		end;

		local instance_props = {
		};

		local instance_events = {
		};

		return defineclass(nil, static, static_props, static_events, instance_build, instance_props, instance_events);
	end,
};


TopLevel.SecondLevel.GenericClass_T.InnerGenericClass_TT.__define_class();

