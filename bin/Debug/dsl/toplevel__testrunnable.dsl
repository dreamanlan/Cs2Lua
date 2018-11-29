require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");
require("toplevel__runnable");
require("luaconsole");

class(TopLevel.TestRunnable) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.TestRunnable, typeargs(), typekinds(), null, null, ...));
		};
		cctor = function(){
		};
	};
	static_fields {
	};
	static_props {};
	static_events {};

	instance_methods {
		Test = function(this){
			local(f); f = newobject(TopLevel.Runnable, typeargs(), typekinds(), "ctor", null);
			invokewithinterface(f, "TopLevel_IRunnable0", "Test");
			local(i); i = getinstanceindexer(f, null, "get_Item", 4);
			setinstanceindexer(f, null, "set_Item", 0, i);
			setwithinterface(f, "TopLevel_IRunnable_System_Int32", "TestProp", i);
			i = getwithinterface(f, ""TopLevel_IRunnable_System_Int32"", ""TestProp"");
			local(pow); pow = (function(v) { return(execbinary("*", v, v, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct)); };);
			local(pow2); pow2 = (function(v1, v2){ return(execbinary("*", v1, v2, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct)); });
			local(a); a = (function(){
				i = execbinary("*", i, i, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
				callstatic(LuaConsole, "Print", execbinary("*", i, 4, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			});
			setinstancedelegation(f, "OnAction", delegationadd(true, false, "TopLevel.IRunnable_System_Int32:OnAction", f, "TopLevel_IRunnable_System_Int32", "OnAction", a));
			setinstancedelegation(f, "OnAction", delegationremove(true, false, "TopLevel.IRunnable_System_Int32:OnAction", f, "TopLevel_IRunnable_System_Int32", "OnAction", a));
			setinstancedelegation(this, "OnDelegation", delegationadd(false, false, "TopLevel.TestRunnable:OnDelegation", this, null, "OnDelegation", a));
			local(t); t = wrapconst(System.Single, "NegativeInfinity");
			t = wrapconst(System.Single, "NaN");
		};
		ctor = function(this){
		};
	};
	instance_fields {
		OnDelegation = null;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};
};



