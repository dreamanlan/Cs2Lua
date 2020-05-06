require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(foo_System_Int32_System_Int32) {
	static_methods {
		__new_object = function(...){
			return(newobject(foo_System_Int32_System_Int32, typeargs(T, K), typekinds(TypeKind.TypeParameter, TypeKind.TypeParameter), "ctor", null, ...));
		};
		cctor = function(){
			callstatic(foo_System_Int32_System_Int32, "__cctor");
		};
		__cctor = function(){
			if(foo_System_Int32_System_Int32.__cctor_called){
				return;
			}else{
				foo_System_Int32_System_Int32.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		parse = function(this, a, b){
			local(t); t = typeof(System.Int32);
			local(k); k = typeof(System.Int32);
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
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		parse(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



