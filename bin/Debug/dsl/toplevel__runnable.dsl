require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("toplevel__testenum");

class(TopLevel.Runnable) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.Runnable, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = function(){
			callstatic(TopLevel.Runnable, "__cctor");
		};
		__cctor = function(){
			if(TopLevel.Runnable.__cctor_called){
				return;
			}else{
				TopLevel.Runnable.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
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
			local(s); s = invokeforbasicvalue(4, true, TopLevel.TestEnum, "ToString", "System.Enum:ToString");
			local(e); e = 1;
			callstatic(System.Enum, "Parse", "System.Enum:Parse__Type__String", typeof(TopLevel.TestEnum), "Two");
			local(ss); ss = invokeforbasicvalue(1, true, System.PlatformID, "ToString", "System.Enum:ToString");
		};
		Runnable_add_OnAction = function(this, value){
		};
		Runnable_remove_OnAction = function(this, value){
		};
		ctor = function(this){
			callinstance(this, "__ctor");
		};
		__ctor = function(this){
			if(getinstance(this, "__ctor_called")){
				return;
			}else{
				setinstance(this, "__ctor_called", true);
			};
		};
	};
	instance_fields {
		__ctor_called = false;
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

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		Runnable_Test(MethodKind.ExplicitInterfaceImplementation, Accessibility.Private){
		};
		Runnable_get_TestProp(MethodKind.PropertyGet, Accessibility.Private){
		};
		Runnable_set_TestProp(MethodKind.PropertySet, Accessibility.Private){
		};
		get_Item(MethodKind.PropertyGet, Accessibility.Public){
		};
		set_Item(MethodKind.PropertySet, Accessibility.Public){
		};
		Test2(MethodKind.Ordinary, Accessibility.Public){
		};
		Runnable_add_OnAction(MethodKind.EventAdd, Accessibility.Private){
		};
		Runnable_remove_OnAction(MethodKind.EventRemove, Accessibility.Private){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {
		TopLevel.IRunnable<System.Int32>.TestProp(Accessibility.Private){
		};
	};
	event_info {
		TopLevel.IRunnable<System.Int32>.OnAction(Accessibility.Private){
		};
	};
	field_info {};
};



