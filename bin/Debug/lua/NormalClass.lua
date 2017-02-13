require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";

NormalClass = {
	__new_object = function(...)
		return newobject(NormalClass, nil, {}, ...);
	end,
	__define_class = function()
		local static = NormalClass;

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
			TestExtension__System_Int32 = function(this, a)
			end,
			TestExtension__System_Int32__System_Int32 = function(this, a, b)
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
		local interfaces = {
			"INormal",
		};

		local interface_map = nil;

		return defineclass(nil, "NormalClass", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};

NormalClass.__define_class();
