require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(StrStrDict, System.Collections.Generic.Dictionary_TKey_TValue) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(StrStrDict, "g_StrStrDict", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(StrStrDict, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(StrStrDict.__cctor_called){
				return();
			}else{
				StrStrDict.__cctor_called = true;
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
			callinstance(this, StrStrDict, "__ctor");
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)],
		ctor__Int32 = deffunc(0)args(this, capacity){
			buildexternbaseobj(this, StrStrDict, System.Collections.Generic.Dictionary_TKey_TValue, "ctor__Int32", 0, capacity);
			callinstance(this, StrStrDict, "__ctor");
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(capacity, System.Int32, TypeKind.Struct, 0, true)],
		ctor__IDictionary_2_String_String = deffunc(0)args(this, dict){
			buildexternbaseobj(this, StrStrDict, System.Collections.Generic.Dictionary_TKey_TValue, "ctor__IDictionary_2_TKey_TValue", 0, dict);
			callinstance(this, StrStrDict, "__ctor");
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dict, System.Collections.Generic.IDictionary_TKey_TValue, TypeKind.Interface, 0, true)],
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, StrStrDict, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, StrStrDict, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"System.Collections.Generic.IDictionary_TKey_TValue";
		"System.Collections.Generic.ICollection_T";
		"System.Collections.IDictionary";
		"System.Collections.ICollection";
		"System.Collections.Generic.IReadOnlyDictionary_TKey_TValue";
		"System.Collections.Generic.IReadOnlyCollection_T";
		"System.Collections.Generic.IEnumerable_T";
		"System.Collections.IEnumerable";
		"System.Runtime.Serialization.ISerializable";
		"System.Runtime.Serialization.IDeserializationCallback";
	};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		ctor__Int32(MethodKind.Constructor, Accessibility.Public){
		};
		ctor__IDictionary_2_String_String(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



