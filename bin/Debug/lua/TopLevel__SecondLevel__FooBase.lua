require "cs2lua__utility";
require "cs2lua__namespaces";

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

		local instance_methods = {
			ctor = function(this)
			end,
		};

		local instance_build = function()
			local instance = {
				m_Ttt = 6789,
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


TopLevel.SecondLevel.FooBase.__define_class();

