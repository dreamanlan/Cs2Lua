require "cs2lua__utility";
require "cs2lua__namespaces";
require "TopLevel__Runnable";

TopLevel.TestRunnable = {
	cctor = function()
	end,

	__new_object = function(...)
		return newobject(TopLevel.TestRunnable, nil, {}, ...);
	end,
	__define_class = function()
		local static = TopLevel.TestRunnable;
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			Test = function(this)
				local f; f = newobject(TopLevel.Runnable, "ctor", {});
				f:TopLevel_IRunnable_Test();
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
		local instance_interfaces = nil;
		local instance_interface_map = nil;

		return defineclass(nil, "TopLevel.TestRunnable", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, instance_interfaces, instance_interface_map, false);
	end,
};


TopLevel.TestRunnable.__define_class();

