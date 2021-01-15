require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(Vector3List, System.Collections.Generic.List_T) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(Vector3List, "g_Vector3List", typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(Vector3List, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(Vector3List.__cctor_called){
				return();
			}else{
				Vector3List.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = deffunc(0)args(this){
			buildexternbaseobj(this, Vector3List, System.Collections.Generic.List_T, "ctor");
			callinstance(this, Vector3List, "__ctor");
			return(this);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0)],
		ctor__Int32 = deffunc(0)args(this, c){
			buildexternbaseobj(this, Vector3List, System.Collections.Generic.List_T, "ctor__Int32", c);
			callinstance(this, Vector3List, "__ctor");
			return(this);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0), paramtype(c, System.Int32, TypeKind.Struct, 0)],
		ctor__ICollection_1_Vector3 = deffunc(0)args(this, coll){
			buildexternbaseobj(this, Vector3List, System.Collections.Generic.List_T, "ctor__IEnumerable_1_T", coll);
			callinstance(this, Vector3List, "__ctor");
			return(this);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0), paramtype(coll, System.Collections.Generic.ICollection_T, TypeKind.Interface, 0)],
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, Vector3List, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, Vector3List, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
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

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		ctor__Int32(MethodKind.Constructor, Accessibility.Public){
		};
		ctor__ICollection_1_Vector3(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



