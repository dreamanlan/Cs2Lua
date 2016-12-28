require "cs2lua__utility";
require "cs2lua__namespaces";
require "foo_T_K";

bar = {
	cctor = function()
	end,

	__new_object = function(...)
		return newobject(bar, nil, {}, ...);
	end,
	__define_class = function()
		local static = bar;
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			test = function(this)
				local a; a = newobject(foo_T_K, "ctor", {}, System.Int32, System.Int32);
				a:parse(wrapstring("123"), wrapstring("456"));
			end,
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

		return defineclass(nil, "bar", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


bar.__define_class();

