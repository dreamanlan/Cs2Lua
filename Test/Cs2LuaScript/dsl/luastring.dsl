require("cs2dsl__utility");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(LuaString) {
	static_methods {
		__new_object = function(...){
			return(newobject(LuaString, typeargs(), typekinds(), null, null, ...));
		};
		Format__System_String__System_Object = function(str, arg){
			return(callstatic(System.String, "Format", "Format__String__Object", str, arg));
		};
		Format__System_String__System_Object__System_Object = function(str, arg1, arg2){
			return(callstatic(System.String, "Format", "Format__String__Object__Object", str, arg1, arg2));
		};
		Format__System_String__System_Object__System_Object__System_Object = function(str, arg1, arg2, arg3){
			return(callstatic(System.String, "Format", "Format__String__Object__Object__Object", str, arg1, arg2, arg3));
		};
		cctor = function(){
		};
	};
	static_fields {
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this){
		};
	};
	instance_fields {
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};

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



