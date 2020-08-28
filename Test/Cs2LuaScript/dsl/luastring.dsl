require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(LuaString) {
	static_methods {
		__new_object = deffunc(1)args(...){
			return(newobject(LuaString, typeargs(), typekinds(), "ctor", null, ...));
		};
		Format__System_String__System_Object = deffunc(1)args(str, arg){
			return(callexternstatic(System.String, "Format", "System.String:Format__String__Object", str, arg));
		};
		Format__System_String__System_Object__System_Object = deffunc(1)args(str, arg1, arg2){
			return(callexternstatic(System.String, "Format", "System.String:Format__String__Object__Object", str, arg1, arg2));
		};
		Format__System_String__System_Object__System_Object__System_Object = deffunc(1)args(str, arg1, arg2, arg3){
			return(callexternstatic(System.String, "Format", "System.String:Format__String__Object__Object__Object", str, arg1, arg2, arg3));
		};
		cctor = deffunc(0)args(){
			callstatic(LuaString, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(LuaString.__cctor_called){
				return;
			}else{
				LuaString.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = deffunc(0)args(this){
			callinstance(this, "__ctor");
		};
		__ctor = deffunc(0)args(this){
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
	instance_props {};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		Format__System_String__System_Object(MethodKind.Ordinary, Accessibility.Public){
			static(true);
		};
		Format__System_String__System_Object__System_Object(MethodKind.Ordinary, Accessibility.Public){
			static(true);
		};
		Format__System_String__System_Object__System_Object__System_Object(MethodKind.Ordinary, Accessibility.Public){
			static(true);
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



