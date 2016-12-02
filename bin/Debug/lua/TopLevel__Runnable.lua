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
			TopLevel_Runnable_Test = function(this)
				LuaConsole.Print(wrapstring("test."));
			end,
			TopLevel_Runnable_get_TestProp = function(this)
				return 1;
			end,
			TopLevel_Runnable_set_TestProp = function(this, value)
			end,
			get_Item = function(this, ix)
				return 1;
			end,
			set_Item = function(this, ix, value)
			end,
			Test2 = function(this)
			end,
			TopLevel_Runnable_add_OnAction = function(this, value)
			end,
			TopLevel_Runnable_remove_OnAction = function(this, value)
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
			TopLevel_Runnable_TestProp = {
				get = instance_methods.TopLevel_Runnable_get_TestProp,
				set = instance_methods.TopLevel_Runnable_set_TestProp,
			},
		};

		local instance_events = {
			TopLevel_Runnable_OnAction = {
				add = instance_methods.TopLevel_Runnable_add_OnAction,
				remove = instance_methods.TopLevel_Runnable_remove_OnAction,
			},
		};

		local interfaces = {
			"TopLevel.IRunnable_T",
			"TopLevel.IRunnable0",
		};

		local interface_map = {
			TopLevel_IRunnable_T_Test2 = "Test2",
			TopLevel_IRunnable_T_get_Item = "get_Item",
			TopLevel_IRunnable_T_set_Item = "set_Item",
			TopLevel_IRunnable_T_TestProp = "TopLevel_Runnable_TestProp",
			TopLevel_IRunnable_T_get_TestProp = "TopLevel_Runnable_get_TestProp",
			TopLevel_IRunnable_T_set_TestProp = "TopLevel_Runnable_set_TestProp",
			TopLevel_IRunnable_T_add_OnAction = "TopLevel_Runnable_add_OnAction",
			TopLevel_IRunnable_T_remove_OnAction = "TopLevel_Runnable_remove_OnAction",
			TopLevel_IRunnable_T_OnAction = "TopLevel_Runnable_OnAction",
			TopLevel_IRunnable0_Test = "TopLevel_Runnable_Test",
		};


		return defineclass(nil, "TopLevel.Runnable", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


TopLevel.Runnable.__define_class();

