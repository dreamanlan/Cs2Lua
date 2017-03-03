require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";
require "TopLevel__Runnable";
require "LuaConsole";

TopLevel.TestRunnable = {
	__new_object = function(...)
		return newobject(TopLevel.TestRunnable, nil, {}, ...);
	end,
	__define_class = function()
		local static = TopLevel.TestRunnable;

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
			Test = function(this)
				local f; f = newobject(TopLevel.Runnable, "ctor", {});
				invokewithinterface(f, "TopLevel_IRunnable0", "Test");
				local i; i = getinstanceindexer(f, nil, "get_Item", 4);
				setinstanceindexer(f, nil, "set_Item", 0, i);
				setwithinterface(f, "TopLevel_IRunnable_CS_System_Int32", "TestProp", i);
				i = getwithinterface(f, ""TopLevel_IRunnable_CS_System_Int32"", ""TestProp"");
				local pow; pow = delegationwrap((function(v) return invokeintegeroperator(4, "*", v, v, CS.System.Int32, CS.System.Int32); end));
				local pow2; pow2 = delegationwrap((function(v1, v2) return invokeintegeroperator(4, "*", v1, v2, CS.System.Int32, CS.System.Int32); end));
				local a; a = delegationwrap((function()
					i = invokeintegeroperator(4, "*", i, i, CS.System.Int32, CS.System.Int32);
					LuaConsole.Print(invokeintegeroperator(4, "*", i, 4, CS.System.Int32, CS.System.Int32));
				end));
				delegationadd(true, f, "TopLevel_IRunnable_CS_System_Int32", "OnAction", a);
				delegationremove(true, f, "TopLevel_IRunnable_CS_System_Int32", "OnAction", a);
				delegationadd(false, this, nil, "OnDelegation", a);
				local t; t = wrapconst(CS.System.Single, "NegativeInfinity");
				t = wrapconst(CS.System.Single, "NaN");
			end,
			ctor = function(this)
			end,
		};

		local instance_fields_build = function()
			local instance_fields = {
				OnDelegation = wrapdelegation{},
			};
			return instance_fields;
		end;
		local instance_props = nil;
		local instance_events = nil;
		local interfaces = nil;
		local interface_map = nil;

		return defineclass(nil, "TopLevel.TestRunnable", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};

TopLevel.TestRunnable.__define_class();
