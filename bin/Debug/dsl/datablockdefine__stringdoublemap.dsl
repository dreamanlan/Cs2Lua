require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("datablockdefine__cstring");

class(DataBlockDefine.StringDoubleMap) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.StringDoubleMap, "g_DataBlockDefine_StringDoubleMap", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.StringDoubleMap, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.StringDoubleMap.__cctor_called){
				return();
			}else{
				DataBlockDefine.StringDoubleMap.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		GetDataBlockId = deffunc(1)args(this){
			local(__method_ret_1888_8_1891_9);
			__method_ret_1888_8_1891_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId");
			return(__method_ret_1888_8_1891_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Structure, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_IsValid"), 1894_12_1895_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId") = callstatic(DclApi, "alloc_container", 6);
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_IsValid"), System.Boolean, TypeKind.Structure), 1902_12_1903_23 ){
				return();
			};
			callinstance(this, DataBlockDefine.StringDoubleMap, "Clear");
			callstatic(DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_IsValid"), 1911_12_1912_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId", dataBlockId);
			if( execbinary("!=", dataBlockId, 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 1914_12_1921_13 ){
				callstatic(DclApi, "iterate_string_double_map", dataBlockId, deffunc(1)args(k, v){
					local(__method_ret_1915_62_1920_17);
					local(key); key = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
					callinstance(key, DataBlockDefine.CString, "Attach", k);
					callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", k, key);
					__method_ret_1915_62_1920_17 = true;
					return(__method_ret_1915_62_1920_17);
				}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Structure, 0, true), paramtype(k, System.UInt64, TypeKind.Structure, 0, true), paramtype(v, System.Double, TypeKind.Structure, 0, true)]);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Structure, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_IsValid"), System.Boolean, TypeKind.Structure), 1926_12_1927_23 ){
				return();
			};
			foreach(__foreach_1928_12_1931_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(key); key = getexterninstance(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				callinstance(key, DataBlockDefine.CString, "Detach");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_IsValid", false);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_1937_8_1940_9);
			__method_ret_1937_8_1940_9 = getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Count");
			return(__method_ret_1937_8_1940_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Structure, 0, true)];
		GetData = deffunc(1)args(this, key){
			local(__method_ret_1941_8_1944_9);
			__method_ret_1941_8_1944_9 = callstatic(DclApi, "string_double_map_get_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId"), condexpfunc(true, retval_1943_71_1943_109, condexp_1943_71_1943_109, DataBlockDefine.StringDoubleMap, false, key){condexp(execbinary("==", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), true, 0, false, function(){ funcobjret(callinstance(key, DataBlockDefine.CString, "GetDataBlockId")); });}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Structure, 0, true), paramtype(key, DataBlockDefine.CString, Class, 0, false)]);
			return(__method_ret_1941_8_1944_9);
		}options[needfuncinfo(false), rettype(return, System.Double, TypeKind.Structure, 0, true), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		SetData = deffunc(0)args(this, key, val){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 1947_12_1964_13 ){
				local(oldKey); oldKey = callstatic(DclApi, "string_double_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(mapKey); mapKey = callstatic(DclApi, "string_double_map_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), val);
				if( execbinary("!=", oldKey, mapKey, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 1950_16_1955_17 ){
					local(oldKeyObj);
					if( execclosure(true, __invoke_1952_24_1952_69, true){ multiassign(precode{
						},postcode{
						})varlist(__invoke_1952_24_1952_69, oldKeyObj) = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", oldKey, __cs2dsl_out); }, 1952_20_1954_21 ){
						callinstance(oldKeyObj, DataBlockDefine.CString, "Release");
					};
				};
				if( execbinary("!=", mapKey, callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 1956_16_1963_17 ){
					local(newKey); newKey = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
					callinstance(newKey, DataBlockDefine.CString, "Attach", mapKey);
					setexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.Dictionary_TKey_TValue, getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "set_Item", 2, mapKey, newKey);
				}else{
					setexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.Dictionary_TKey_TValue, getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "set_Item", 2, mapKey, key);
				};
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(val, System.Double, TypeKind.Structure, 0, true)];
		Add = deffunc(0)args(this, key, val){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 1968_12_1973_13 ){
				local(mapKey); mapKey = callstatic(DclApi, "string_double_map_add_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), val);
				local(newKey); newKey = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
				callinstance(newKey, DataBlockDefine.CString, "Attach", mapKey);
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", mapKey, newKey);
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(val, System.Double, TypeKind.Structure, 0, true)];
		Remove = deffunc(0)args(this, key){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 1977_12_1984_13 ){
				local(mapKey); mapKey = callstatic(DclApi, "string_double_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(keyObj);
				if( execclosure(true, __invoke_1980_20_1980_62, true){ multiassign(precode{
					},postcode{
					})varlist(__invoke_1980_20_1980_62, keyObj) = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", mapKey, __cs2dsl_out); }, 1980_16_1982_17 ){
					callinstance(keyObj, DataBlockDefine.CString, "Release");
				};
				callstatic(DclApi, "string_double_map_remove_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Contains = deffunc(1)args(this, key){
			local(__method_ret_1986_8_1992_9);
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 1988_12_1990_13 ){
				__method_ret_1986_8_1992_9 = callstatic(DclApi, "string_double_map_contains", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				return(__method_ret_1986_8_1992_9);
			};
			__method_ret_1986_8_1992_9 = false;
			return(__method_ret_1986_8_1992_9);
		}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Structure, 0, true), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Clear = deffunc(0)args(this){
			foreach(__foreach_1995_12_1998_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(key); key = getexterninstance(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				callinstance(key, DataBlockDefine.CString, "Release");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			callstatic(DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId"));
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Iterate = deffunc(0)args(this, callback){
			callstatic(DclApi, "iterate_string_double_map", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataBlockId"), deffunc(1)args(k, v){
				local(__method_ret_2004_60_2010_13);
				local(kObj);
				if( execclosure(true, __invoke_2006_20_2006_55, true){ multiassign(precode{
					},postcode{
					})varlist(__invoke_2006_20_2006_55, kObj) = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", k, __cs2dsl_out); }, 2006_16_2009_33 ){
					__method_ret_2004_60_2010_13 = callexterndelegation(callback, "System.Func_T1_T2_TResult.Invoke", kObj, v);
					return(__method_ret_2004_60_2010_13);
				}else{
					__method_ret_2004_60_2010_13 = false;
					return(__method_ret_2004_60_2010_13);
				};
				return(null);
			}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Structure, 0, true), paramtype(k, System.UInt64, TypeKind.Structure, 0, true), paramtype(v, System.Double, TypeKind.Structure, 0, true)]);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(callback, System.Func_T1_T2_TResult, TypeKind.Delegate, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.StringDoubleMap, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDoubleMap, "m_DataWrap", newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "g_System_Collections_Generic_Dictionary_System_UInt64_DataBlockDefine_CString", typeargs(System.UInt64, DataBlockDefine.CString), typekinds(TypeKind.Structure, TypeKind.Class), "ctor", 0, literaldictionary("g_System_Collections_Generic_Dictionary_System_UInt64_DataBlockDefine_CString", typeargs(System.UInt64, DataBlockDefine.CString), typekinds(TypeKind.Structure, TypeKind.Class))));
		}options[needfuncinfo(false)];
	};
	instance_fields {
		m_IsValid = false;
		m_DataBlockId = 0;
		m_DataWrap = null;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"DataBlockDefine.IDataBlock";
	};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		GetDataBlockId(MethodKind.Ordinary, Accessibility.Public){
		};
		Init(MethodKind.Ordinary, Accessibility.Public){
		};
		Release(MethodKind.Ordinary, Accessibility.Public){
		};
		Attach(MethodKind.Ordinary, Accessibility.Public){
		};
		Detach(MethodKind.Ordinary, Accessibility.Public){
		};
		GetCount(MethodKind.Ordinary, Accessibility.Public){
		};
		GetData(MethodKind.Ordinary, Accessibility.Public){
		};
		SetData(MethodKind.Ordinary, Accessibility.Public){
		};
		Add(MethodKind.Ordinary, Accessibility.Public){
		};
		Remove(MethodKind.Ordinary, Accessibility.Public){
		};
		Contains(MethodKind.Ordinary, Accessibility.Public){
		};
		Clear(MethodKind.Ordinary, Accessibility.Public){
		};
		Iterate(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



