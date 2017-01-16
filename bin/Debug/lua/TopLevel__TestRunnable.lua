require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";
require "TopLevel__Runnable";

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
				local i; i = getinstanceindexer(f, nil, "get_Item", 0);
				setinstanceindexer(f, nil, "set_Item", 0, i);
				setwithinterface(f, "TopLevel_IRunnable_System_Int32", "TestProp", i);
				i = getwithinterface(f, ""TopLevel_IRunnable_System_Int32"", ""TestProp"");
				local pow; pow = delegationwrap((function(v) return (v * v); end));
				local pow2; pow2 = delegationwrap((function(v1, v2) local __compiler_lambda_181 = (v1 * v2); return __compiler_lambda_181; end));
				local a; a = delegationwrap((function()
					i = (i * i);
					LuaConsole.Print(i);
				end));
				delegationadd(f, "TopLevel_IRunnable_System_Int32", "OnAction", a);
				delegationremove(f, "TopLevel_IRunnable_System_Int32", "OnAction", a);
				local t; t = wrapconst(System.Single, "NegativeInfinity");
				t = wrapconst(System.Single, "NaN");
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

		return defineclass(nil, "TopLevel.TestRunnable", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, false);
	end,
};

TopLevel.TestRunnable.__define_class();
