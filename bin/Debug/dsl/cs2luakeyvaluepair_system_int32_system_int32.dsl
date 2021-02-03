require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(Cs2LuaKeyValuePair_System_Int32_System_Int32) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(Cs2LuaKeyValuePair_System_Int32_System_Int32, "g_Cs2LuaKeyValuePair_System_Int32_System_Int32", typeargs(TKey, TValue), typekinds(TypeKind.TypeParameter, TypeKind.TypeParameter), "ctor__TKey__TValue", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(Cs2LuaKeyValuePair_System_Int32_System_Int32, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(Cs2LuaKeyValuePair_System_Int32_System_Int32.__cctor_called){
				return();
			}else{
				Cs2LuaKeyValuePair_System_Int32_System_Int32.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor__TKey__TValue = deffunc(0)args(this, key, value){
			callinstance(this, Cs2LuaKeyValuePair_System_Int32_System_Int32, "__ctor");
			setinstance(SymbolKind.Field, this, Cs2LuaKeyValuePair_System_Int32_System_Int32, "key", key);
			setinstance(SymbolKind.Field, this, Cs2LuaKeyValuePair_System_Int32_System_Int32, "value", value);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, TKey, TypeKind.TypeParameter, 0, false), paramtype(value, TValue, TypeKind.TypeParameter, 0, false)],
		ctor = deffunc(0)args(this){
			callinstance(this, Cs2LuaKeyValuePair_System_Int32_System_Int32, "__ctor");
			local(t1); t1 = typeof(System.Int32);
			local(t2); t2 = typeof(System.Int32);
			t2 = typecast(t1, System.Int32, TypeKind.TypeParameter);
			setinstance(SymbolKind.Field, this, Cs2LuaKeyValuePair_System_Int32_System_Int32, "key", 0);
			setinstance(SymbolKind.Field, this, Cs2LuaKeyValuePair_System_Int32_System_Int32, "value", 0);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)],
		get_Key = deffunc(1)args(this){
			local(__method_ret_159_4_162_5);
			__method_ret_159_4_162_5 = getinstance(SymbolKind.Field, this, Cs2LuaKeyValuePair_System_Int32_System_Int32, "key");
			return(__method_ret_159_4_162_5);
		}options[needfuncinfo(false), rettype(return, TKey, TypeKind.TypeParameter, 0, false)];
		get_Value = deffunc(1)args(this){
			local(__method_ret_164_4_167_5);
			__method_ret_164_4_167_5 = getinstance(SymbolKind.Field, this, Cs2LuaKeyValuePair_System_Int32_System_Int32, "value");
			return(__method_ret_164_4_167_5);
		}options[needfuncinfo(false), rettype(return, TValue, TypeKind.TypeParameter, 0, false)];
		ToString = deffunc(1)args(this){
			local(__method_ret_169_4_180_5);
			local(stringBuilder); stringBuilder = ;
						if( execbinary("!=", typecast(dsltoobject(SymbolKind.NamedType, false, "System.Object", getinstance(SymbolKind.Property, this, Cs2LuaKeyValuePair_System_Int32_System_Int32, "Key")), System.Object, TypeKind.Class), null, System.Object, System.Object, TypeKind.Class, TypeKind.Class) ){
							};
						if( execbinary("!=", typecast(dsltoobject(SymbolKind.NamedType, false, "System.Object", getinstance(SymbolKind.Property, this, Cs2LuaKeyValuePair_System_Int32_System_Int32, "Value")), System.Object, TypeKind.Class), null, System.Object, System.Object, TypeKind.Class, TypeKind.Class) ){
							};
									return(__method_ret_169_4_180_5);
		}options[needfuncinfo(false), rettype(return, System.String, TypeKind.Class, 0, true)];
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, Cs2LuaKeyValuePair_System_Int32_System_Int32, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, Cs2LuaKeyValuePair_System_Int32_System_Int32, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		key = 0;
		value = 0;
		__ctor_called = false;
	};
	instance_props {
		Key = {
			get = instance_methods.get_Key;
		};
		Value = {
			get = instance_methods.get_Value;
		};
	};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Class, Accessibility.Public) {
		sealed(true);
	};
	method_info {
		ctor__TKey__TValue(MethodKind.Constructor, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		get_Key(MethodKind.PropertyGet, Accessibility.Public){
		};
		get_Value(MethodKind.PropertyGet, Accessibility.Public){
		};
		ToString(MethodKind.Ordinary, Accessibility.Public){
			override(true);
		};
	};
	property_info {
		Key(Accessibility.Public){
			readonly(true);
		};
		Value(Accessibility.Public){
			readonly(true);
		};
	};
	event_info {};
	field_info {
		key(Accessibility.Private){
		};
		value(Accessibility.Private){
		};
	};
};



