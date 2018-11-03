require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");
require("luaconsole");
require("toplevel__testenum");

class(TopLevel.Runnable) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.Runnable, null, null, ...));
		};
		cctor = function(){
		};
	};
	static_fields {
	};
	static_props {};
	static_events {};

	instance_methods {
		Runnable_Test = function(this){
			callstatic(LuaConsole, "Print", "test.");
		};
		Runnable_get_TestProp = function(this){
			return(1);
		};
		Runnable_set_TestProp = function(this, value){
		};
		get_Item = function(this, ix){
			return(1);
		};
		set_Item = function(this, ix, value){
		};
		Test2 = function(this){
			local(s); s = invokeforbasicvalue(4, true, TopLevel.TestEnum, "ToString");
			local(e); e = 1;
			callstatic(System.Enum, "Parse", typeof(TopLevel.TestEnum), "Two");
			local(ss); ss = invokeforbasicvalue(1, true, System.PlatformID, "ToString");
		};
		Runnable_add_OnAction = function(this, value){
		};
		Runnable_remove_OnAction = function(this, value){
		};
		ctor = function(this){
		};
	};
	instance_fields {
	};
	instance_props {
		Runnable_TestProp = {
			get = instance_methods.Runnable_get_TestProp;
			set = instance_methods.Runnable_set_TestProp;
		};
	};
	instance_events {
		Runnable_OnAction = {
			add = instance_methods.Runnable_add_OnAction,
			remove = instance_methods.Runnable_remove_OnAction,
		};
	};

	interfaces {
		"TopLevel.IRunnable_System_Int32";
		"TopLevel.IRunnable0";
	};
	interface_map {
		IRunnable_T_Test2 = "Test2";
		IRunnable_T_get_Item = "get_Item";
		IRunnable_T_set_Item = "set_Item";
		IRunnable_T_TestProp = "Runnable_TestProp";
		IRunnable_T_get_TestProp = "Runnable_get_TestProp";
		IRunnable_T_set_TestProp = "Runnable_set_TestProp";
		IRunnable_T_add_OnAction = "Runnable_add_OnAction";
		IRunnable_T_remove_OnAction = "Runnable_remove_OnAction";
		IRunnable_T_OnAction = "Runnable_OnAction";
		IRunnable0_Test = "Runnable_Test";
	};
};



