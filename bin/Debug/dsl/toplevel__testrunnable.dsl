require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("toplevel__runnable");

class(TopLevel.TestRunnable) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.TestRunnable, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = function(){
			callstatic(TopLevel.TestRunnable, "__cctor");
		};
		__cctor = function(){
			if(TopLevel.TestRunnable.__cctor_called){
				return;
			}else{
				TopLevel.TestRunnable.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		Test = function(this){
			local(f); f = newobject(TopLevel.Runnable, typeargs(), typekinds(), "ctor", null);
			invokewithinterface(f, "TopLevel_IRunnable0", "Test");
			local(i); i = getinstanceindexer(f, null, TopLevel.IRunnable_System_Int32, "get_Item", 1, 4);
			setinstanceindexer(f, null, TopLevel.IRunnable_System_Int32, "set_Item", 2, true, 0, i);
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
		OnDelegation = null;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		Test(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {
		OnDelegation(Accessibility.Public){
		};
	};
};



