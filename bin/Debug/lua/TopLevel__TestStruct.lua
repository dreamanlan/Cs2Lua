require "cs2lua__utility";
require "cs2lua__namespaces";

TopLevel.TestStruct = {
	cctor = function()
	end,

	__new_object = function(...)
		return newobject(TopLevel.TestStruct, nil, {}, ...);
	end,
	__define_class = function()
		local static = TopLevel.TestStruct;
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			ctor = function(this)
			end,
		};

		local instance_build = function()
			local instance_fields = {
				A = true,
				B = true,
				C = true,
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;

		return defineclass(nil, "TopLevel.TestStruct", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, true);
	end,
};


TopLevel.TestStruct.__define_class();

