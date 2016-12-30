require "cs2lua__utility";
require "cs2lua__namespaces";

TopLevel.Runnable = {
	__new_object = function(...)
		return newobject(TopLevel.Runnable, nil, {}, ...);
	end,
	__define_class = function()
		local static = TopLevel.Runnable;

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
			Runnable_Test = function(this)
				LuaConsole.Print(wrapstring("test."));
			end,
			Runnable_get_TestProp = function(this)
				return 1;
			end,
			Runnable_set_TestProp = function(this, value)
			end,
			get_Item = function(this, ix)
				return 1;
			end,
			set_Item = function(this, ix, value)
			end,
			Test2 = function(this)
			end,
			Runnable_add_OnAction = function(this, value)
			end,
			Runnable_remove_OnAction = function(this, value)
			end,
			ctor = function(this)
			end,
		};

		local instance_fields_build = function()
			local instance_fields = {
			};
			return instance_fields;
		end;

		local instance_props = {
			Runnable_TestProp = {
				get = instance_methods.Runnable_get_TestProp,
				set = instance_methods.Runnable_set_TestProp,
			},
		};

		local instance_events = {
			Runnable_OnAction = {
				add = instance_methods.Runnable_add_OnAction,
				remove = instance_methods.Runnable_remove_OnAction,
			},
		};

		local interfaces = {
			"TopLevel.IRunnable_Int32",
			"TopLevel.IRunnable0",
		};

		local interface_map = {
			IRunnable_T_Test2 = "Test2",
			IRunnable_T_get_Item = "get_Item",
			IRunnable_T_set_Item = "set_Item",
			IRunnable_T_TestProp = "Runnable_TestProp",
			IRunnable_T_get_TestProp = "Runnable_get_TestProp",
			IRunnable_T_set_TestProp = "Runnable_set_TestProp",
			IRunnable_T_add_OnAction = "Runnable_add_OnAction",
			IRunnable_T_remove_OnAction = "Runnable_remove_OnAction",
			IRunnable_T_OnAction = "Runnable_OnAction",
			IRunnable0_Test = "Runnable_Test",
		};


		return defineclass(nil, "TopLevel.Runnable", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


TopLevel.Runnable.__define_class();

