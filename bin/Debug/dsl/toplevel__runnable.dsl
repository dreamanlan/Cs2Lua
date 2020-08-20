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
		TopLevel_IRunnable0_Test = function(this){
			callstatic(LuaConsole, "Print", "test.");
		};
		TopLevel_IRunnable<System_Int32>_get_TestProp = function(this){
			return(1);
		};
		TopLevel_IRunnable<System_Int32>_set_TestProp = function(this, value){
		};
		get_Item = function(this, ix){
			return(1);
		};
		set_Item = function(this, ix, value){
		};
		Test2 = function(this){
			local(s); s = invokeforbasicvalue(4, true, TopLevel.TestEnum, "ToString", "System.Enum:ToString");
			local(e); e = 1;
			callexternstatic(System.Enum, "Parse", "System.Enum:Parse__Type__String", typeof(TopLevel.TestEnum), "Two");
			local(ss); ss = invokeforbasicvalue(1, true, System.PlatformID, "ToString", "System.Enum:ToString");
		};
		TopLevel_IRunnable<System_Int32>_add_OnAction = function(this, value){
		};
		TopLevel_IRunnable<System_Int32>_remove_OnAction = function(this, value){
		};
		ctor = function(this){
			callinstance(this, "__ctor");
		};
		__ctor = function(this){
			if(getinstance(SymbolKind.Field, this, "__ctor_called")){
				return;
			}else{
				setinstance(SymbolKind.Field, this, "__ctor_called", true);
			};
		};
	};
	instance_fields {
		__ctor_called = false;
	};
	instance_props {
		TopLevel_IRunnable<System_Int32>_TestProp = {
			get = instance_methods.TopLevel_IRunnable<System_Int32>_get_TestProp;
			set = instance_methods.TopLevel_IRunnable<System_Int32>_set_TestProp;
		};
	};
	instance_events {
		TopLevel_IRunnable<System_Int32>_OnAction = {
			add = instance_methods.TopLevel_IRunnable<System_Int32>_add_OnAction,
			remove = instance_methods.TopLevel_IRunnable<System_Int32>_remove_OnAction,
		};
	};

	interfaces {
		"TopLevel.IRunnable_System_Int32";
		"TopLevel.IRunnable0";
	};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		TopLevel_IRunnable0_Test(MethodKind.ExplicitInterfaceImplementation, Accessibility.Private){
		};
		TopLevel_IRunnable<System_Int32>_get_TestProp(MethodKind.PropertyGet, Accessibility.Private){
		};
		TopLevel_IRunnable<System_Int32>_set_TestProp(MethodKind.PropertySet, Accessibility.Private){
		};
		get_Item(MethodKind.PropertyGet, Accessibility.Public){
		};
		set_Item(MethodKind.PropertySet, Accessibility.Public){
		};
		Test2(MethodKind.Ordinary, Accessibility.Public){
		};
		TopLevel_IRunnable<System_Int32>_add_OnAction(MethodKind.EventAdd, Accessibility.Private){
		};
		TopLevel_IRunnable<System_Int32>_remove_OnAction(MethodKind.EventRemove, Accessibility.Private){
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



