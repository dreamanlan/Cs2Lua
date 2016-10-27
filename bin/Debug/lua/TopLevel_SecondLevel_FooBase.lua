require "cs2lua_utility";
require "cs2lua_namespaces";

TopLevel.SecondLevel.FooBase = {
	cctor = function()
	end,


	__new_object = function(...)
		return newobject(TopLevel.SecondLevel.FooBase, nil, {}, ...);
	end,
	__define_class = function()
		local static = TopLevel.SecondLevel.FooBase;

		local static_props = {
		};

		local static_events = {
		};

		local instance = {
			ctor = function(this)
			end,

			m_Ttt = 6789,
		};

		local instance_props = {
		};

		local instance_events = {
		};

		return defineclass(nil, true, static, static_props, static_events, instance, instance_props, instance_events);
	end,
};


TopLevel.SecondLevel.FooBase.__define_class();

