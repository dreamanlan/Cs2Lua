require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";
require "cs2lua__interfaces";

foo_System_Int32_System_Int32 = {
	__new_object = function(...)
		return newobject(foo_System_Int32_System_Int32, nil, nil, ...);
	end,
	__define_class = function()
		local static = foo_System_Int32_System_Int32;

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
			parse = function(this, a, b)
				local t; t = System.Int32;
				local k; k = System.Int32;
			end,
			ctor = function(this)
			end,
		};

		local instance_fields_build = function()
			local instance_fields = {
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "foo_System_Int32_System_Int32", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};



foo_System_Int32_System_Int32.__define_class();
