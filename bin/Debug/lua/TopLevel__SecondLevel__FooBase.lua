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
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			ctor = function(this)
			end,
		};

		local instance_build = function()
			local instance_fields = {
				m_Ttt = 6789,
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "TopLevel.SecondLevel.FooBase", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


TopLevel.SecondLevel.FooBase.__define_class();

