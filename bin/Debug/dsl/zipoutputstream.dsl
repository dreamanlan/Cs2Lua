require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(ZipOutputStream) {
	static_methods {
		__new_object = deffunc(1)args(...){
			return(newobject(ZipOutputStream, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = deffunc(0)args(){
			callstatic(ZipOutputStream, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(ZipOutputStream.__cctor_called){
				return;
			}else{
				ZipOutputStream.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = deffunc(0)args(this, ms){
			callinstance(this, "__ctor");
			return(this);
		},
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
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



