require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(IntList, System.Collections.Generic.List_T) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(IntList, typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		};
		cctor = deffunc(0)args(){
			callstatic(IntList, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(IntList.__cctor_called){
				return;
			}else{
				IntList.__cctor_called = true;
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
			callinstance(this, IntList, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, IntList, "__ctor_called")){
				return;
			}else{
				setinstance(SymbolKind.Field, this, IntList, "__ctor_called", true);
			};
		};
	};
	instance_fields {
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"System.Collections.Generic.IList_T";
		"System.Collections.Generic.ICollection_T";
		"System.Collections.IList";
		"System.Collections.ICollection";
		"System.Collections.Generic.IReadOnlyList_T";
		"System.Collections.Generic.IReadOnlyCollection_T";
		"System.Collections.Generic.IEnumerable_T";
		"System.Collections.IEnumerable";
	};

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



