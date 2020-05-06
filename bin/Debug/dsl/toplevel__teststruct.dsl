require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

struct(TopLevel.TestStruct) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.TestStruct, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = function(){
			callstatic(TopLevel.TestStruct, "__cctor");
		};
		__cctor = function(){
			if(TopLevel.TestStruct.__cctor_called){
				return;
			}else{
				TopLevel.TestStruct.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
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
		A = 0;
		B = 0;
		C = 0;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};

	class_info(TypeKind.Struct, Accessibility.Internal) {
		sealed(true);
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {
		A(Accessibility.Public){
		};
		B(Accessibility.Public){
		};
		C(Accessibility.Public){
		};
	};
};



