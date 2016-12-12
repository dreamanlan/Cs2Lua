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
				invokewithinterface(f, "TopLevel_IRunnable0", "Test");
				local i; i = getinstanceindexer(f, nil, "get_Item", 0);
				setinstanceindexer(f, nil, "set_Item", 0, i);
				setwithinterface(f, "TopLevel_IRunnable_T", "TestProp", i);
				i = getwithinterface(f, ""TopLevel_IRunnable_T"", ""TestProp"");
				local a; a = delegationwrap((function()
				end));
				delegationadd(f, "TopLevel_IRunnable_T", "OnAction", a);
				delegationremove(f, "TopLevel_IRunnable_T", "OnAction", a);
				local t; t = wrapconst(System.Single, "NegativeInfinity");
				t = wrapconst(System.Single, "NaN");
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

		return defineclass(nil, "TopLevel.TestRunnable", static, static_fields, static_props, static_events, instance_methods, instance_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};


TopLevel.TestRunnable.__define_class();

