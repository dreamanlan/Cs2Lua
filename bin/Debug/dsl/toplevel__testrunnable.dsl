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
			callinstance(f, "TopLevel_IRunnable0_Test");
			local(i); i = getinstanceindexer(f, TopLevel.IRunnable_System_Int32, "get_Item", 1, 4);
			setinstanceindexer(f, TopLevel.IRunnable_System_Int32, "set_Item", 2, true, 0, i);
			setinstance(SymbolKind.Property, f, "TopLevel_IRunnable<System_Int32>_TestProp", i);
			i = getinstance(SymbolKind.Property, f, "TopLevel_IRunnable<System_Int32>_TestProp");
			local(pow); pow = (function(v) { return(execbinary("*", v, v, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct)); };);
			local(pow2); pow2 = (function(v1, v2){ return(execbinary("*", v1, v2, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct)); });
			local(a); a = (function(){
				i = execbinary("*", i, i, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
				callstatic(LuaConsole, "Print", execbinary("*", i, 4, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			});
			setinstancedelegation(SymbolKind.Event, f, "OnAction", delegationadd(false, "TopLevel.IRunnable_System_Int32:OnAction", f, "OnAction", SymbolKind.Event, a));
			setinstancedelegation(SymbolKind.Event, f, "OnAction", delegationremove(false, "TopLevel.IRunnable_System_Int32:OnAction", f, "OnAction", SymbolKind.Event, a));
			setinstancedelegation(SymbolKind.Field, this, "OnDelegation", delegationadd(false, "TopLevel.TestRunnable:OnDelegation", this, "OnDelegation", SymbolKind.Field, a));
			local(t); t = wrapconst(System.Single, "NegativeInfinity");
			t = wrapconst(System.Single, "NaN");
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
		OnDelegation = null;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};

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



