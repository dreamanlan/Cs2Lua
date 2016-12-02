require "cs2lua__utility";
require "cs2lua__namespaces";

TopLevel.Runnable = {
	cctor = function()
	end,

	__new_object = function(...)
		return newobject(TopLevel.Runnable, nil, {}, ...);
	end,
	__define_class = function()
		local static = TopLevel.Runnable;
		local static_fields = nil;
		local static_props = nil;
		local static_events = nil;

		local instance_methods = {
			TopLevel_IRunnable_get_TestProp = function(this)
				return 1;
			end,
			TopLevel_IRunnable_set_TestProp = function(this, value)
			end,
			get_Item = function(this, ix)
				return 1;
			end,
			Test = function(this)
			end,
			TopLevel_IRunnable_add_OnAction = function(this, value)
			end,
			TopLevel_IRunnable_remove_OnAction = function(this, value)
			end,
			ctor = function(this)
			end,
		};

		local instance_build = function()
			local instance_fields = {
			};
			return instance_fields;
		end;

		local instance_props = {
			TopLevel_IRunnable_TestProp = {
				get = instance_methods.TopLevel_IRunnable_get_TestProp,
				set = instance_methods.TopLevel_IRunnable_set_TestProp,
			},
		};

		local instance_events = {
			TopLevel_IRunnable_OnAction = {
				add = instance_methods.TopLevel_IRunnable_add_OnAction,
				remove = instance_methods.TopLevel_IRunnable_remove_OnAction,
			},
		};

		local instance_interfaces = {
			"TopLevel.IRunnable",
		};

		local instance_interface_map = {
			TopLevel_IRunnable_TestProp = "TopLevel_IRunnable_TestProp",
			TopLevel_IRunnable_get_TestProp = "TopLevel_IRunnable_get_TestProp",
			TopLevel_IRunnable_set_TestProp = "TopLevel_IRunnable_set_TestProp",
			TopLevel_IRunnable_add_OnAction = "TopLevel_IRunnable_add_OnAction",
			TopLevel_IRunnable_remove_OnAction = "TopLevel_IRunnable_remove_OnAction",
			TopLevel_IRunnable_OnAction = "TopLevel_IRunnable_OnAction",
		};


		return defineclass(nil, "TopLevel.Runnable", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, instance_interfaces, instance_interface_map, false);
	end,
};


TopLevel.Runnable.__define_class();

