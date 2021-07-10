require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("datablockdefine__cstring");

class(DataBlockDefine.StringStringMap) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.StringStringMap, "g_DataBlockDefine_StringStringMap", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.StringStringMap, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.StringStringMap.__cctor_called){
				return();
			}else{
				DataBlockDefine.StringStringMap.__cctor_called = true;
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
			local(__method_ret_2015_8_2018_9);
			__method_ret_2015_8_2018_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId");
			return(__method_ret_2015_8_2018_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid"), 2021_12_2022_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId") = callstatic(DataBlockDefine.DclApi, "alloc_container", 5);
			callexternstructdictionaryinstance(2, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Struct, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid"), System.Boolean, TypeKind.Struct), 2029_12_2030_23 ){
				return();
			};
			callinstance(this, DataBlockDefine.StringStringMap, "Clear");
			callstatic(DataBlockDefine.DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid"), 2038_12_2039_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId", dataBlockId);
			if( execbinary("!=", dataBlockId, 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2041_12_2050_13 ){
				callstatic(DataBlockDefine.DclApi, "iterate_string_uint64_map", dataBlockId, deffunc(1)args(k, v){
					local(__method_ret_2042_62_2049_17);
					local(key); key = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
					callinstance(key, DataBlockDefine.CString, "Attach", k);
					local(val); val = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
					callinstance(val, DataBlockDefine.CString, "Attach", v);
					callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Struct, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct], [null, null, null, null, System.UInt64, TypeKind.Struct, OperationKind.ParameterReference, SymbolKind.Parameter], [null, null, null, null, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct, OperationKind.ObjectCreation, SymbolKind.Method], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", k, newstruct(DataBlockDefine.StringStringMap.KeyValue, "g_DataBlockDefine_StringStringMap_KeyValue", typeargs(), typekinds(), "ctor", 0, function(newobj){ setinstance(SymbolKind.Field, newobj, DataBlockDefine.StringStringMap.KeyValue, "Key", key);setinstance(SymbolKind.Field, newobj, DataBlockDefine.StringStringMap.KeyValue, "Value", val); }));
					__method_ret_2042_62_2049_17 = true;
					return(__method_ret_2042_62_2049_17);
				}options[needfuncinfo(true), rettype(return, System.Boolean, TypeKind.Struct, 0, true), paramtype(k, System.UInt64, TypeKind.Struct, 0, true), paramtype(v, System.UInt64, TypeKind.Struct, 0, true)]);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid"), System.Boolean, TypeKind.Struct), 2055_12_2056_23 ){
				return();
			};
			foreach(__foreach_2057_12_2063_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(kv); kv = getexterninstancestructmember(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Key"), DataBlockDefine.CString, "Detach");
				if( execbinary("!=", null, getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 2060_16_2062_17 ){
					callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), DataBlockDefine.CString, "Detach");
				};
			};
			callexternstructdictionaryinstance(2, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Struct, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid", false);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_2069_8_2072_9);
			__method_ret_2069_8_2072_9 = getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Count");
			return(__method_ret_2069_8_2072_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, key){
			local(__method_ret_2073_8_2083_9);
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 2075_12_2081_13 ){
				local(k); k = callstatic(DataBlockDefine.DclApi, "string_uint64_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(kv);
				if( execclosure(true, __invoke_2078_20_2078_53, true){ multiassign(precode{
					},postcode{
						kv = wrapstruct(kv, DataBlockDefine.StringStringMap.KeyValue);
					})varlist(__invoke_2078_20_2078_53, kv) = callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Struct, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct], [null, null, null, null, System.UInt64, TypeKind.Struct, OperationKind.LocalReference, SymbolKind.Local], [null, null, null, null, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct, OperationKind.LocalReference, SymbolKind.Local], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", k, __cs2dsl_out); }, 2078_16_2080_17 ){
					__method_ret_2073_8_2083_9 = getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value");
					return(__method_ret_2073_8_2083_9);
				};
			};
			__method_ret_2073_8_2083_9 = null;
			return(__method_ret_2073_8_2083_9);
		}options[needfuncinfo(true), rettype(return, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		SetData = deffunc(0)args(this, key, val){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 2086_12_2108_13 ){
				local(oldKey); oldKey = callstatic(DataBlockDefine.DclApi, "string_uint64_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(mapKey); mapKey = callstatic(DataBlockDefine.DclApi, "string_uint64_map_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), condexpfunc(true, retval_2088_105_2088_143, condexp_2088_105_2088_143, DataBlockDefine.StringStringMap, false, val){condexp(execbinary("==", null, val, System.Object, System.Object, TypeKind.Class, TypeKind.Class), true, 0, false, function(){ funcobjret(callinstance(val, DataBlockDefine.CString, "GetDataBlockId")); });}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true), paramtype(val, DataBlockDefine.CString, Class, 0, false)]);
				if( execbinary("!=", oldKey, mapKey, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2089_16_2097_17 ){
					local(kv);
					if( execclosure(true, __invoke_2091_24_2091_62, true){ multiassign(precode{
						},postcode{
							kv = wrapstruct(kv, DataBlockDefine.StringStringMap.KeyValue);
						})varlist(__invoke_2091_24_2091_62, kv) = callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Struct, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct], [null, null, null, null, System.UInt64, TypeKind.Struct, OperationKind.LocalReference, SymbolKind.Local], [null, null, null, null, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct, OperationKind.LocalReference, SymbolKind.Local], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", oldKey, __cs2dsl_out); }, 2091_20_2096_21 ){
						callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Key"), DataBlockDefine.CString, "Release");
						if( execbinary("!=", null, getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 2093_24_2095_25 ){
							callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), DataBlockDefine.CString, "Release");
						};
					};
				};
				if( execbinary("!=", mapKey, callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2098_16_2107_17 ){
					local(newKV); newKV = newstruct(DataBlockDefine.StringStringMap.KeyValue, "g_DataBlockDefine_StringStringMap_KeyValue", typeargs(), typekinds(), "ctor", 0, null);
					setinstance(SymbolKind.Field, newKV, DataBlockDefine.StringStringMap.KeyValue, "Key", newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null));
					callinstance(getinstance(SymbolKind.Field, newKV, DataBlockDefine.StringStringMap.KeyValue, "Key"), DataBlockDefine.CString, "Attach", mapKey);
					setinstance(SymbolKind.Field, newKV, DataBlockDefine.StringStringMap.KeyValue, "Value", val);
					setinstanceindexerstruct(true, DataBlockDefine.StringStringMap.KeyValue, System.Collections.Generic.Dictionary_TKey_TValue, getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "set_Item", 2, mapKey, newKV);
				}else{
					setinstanceindexerstruct(true, DataBlockDefine.StringStringMap.KeyValue, System.Collections.Generic.Dictionary_TKey_TValue, getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "set_Item", 2, mapKey, newstruct(DataBlockDefine.StringStringMap.KeyValue, "g_DataBlockDefine_StringStringMap_KeyValue", typeargs(), typekinds(), "ctor", 0, function(newobj){ setinstance(SymbolKind.Field, newobj, DataBlockDefine.StringStringMap.KeyValue, "Key", key);setinstance(SymbolKind.Field, newobj, DataBlockDefine.StringStringMap.KeyValue, "Value", val); }));
				};
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(val, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Add = deffunc(0)args(this, key, val){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 2112_12_2119_13 ){
				local(mapKey); mapKey = callstatic(DataBlockDefine.DclApi, "string_uint64_map_add_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), condexpfunc(true, retval_2113_105_2113_143, condexp_2113_105_2113_143, DataBlockDefine.StringStringMap, false, val){condexp(execbinary("==", null, val, System.Object, System.Object, TypeKind.Class, TypeKind.Class), true, 0, false, function(){ funcobjret(callinstance(val, DataBlockDefine.CString, "GetDataBlockId")); });}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true), paramtype(val, DataBlockDefine.CString, Class, 0, false)]);
				local(newKV); newKV = newstruct(DataBlockDefine.StringStringMap.KeyValue, "g_DataBlockDefine_StringStringMap_KeyValue", typeargs(), typekinds(), "ctor", 0, null);
				setinstance(SymbolKind.Field, newKV, DataBlockDefine.StringStringMap.KeyValue, "Key", newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null));
				callinstance(getinstance(SymbolKind.Field, newKV, DataBlockDefine.StringStringMap.KeyValue, "Key"), DataBlockDefine.CString, "Attach", mapKey);
				setinstance(SymbolKind.Field, newKV, DataBlockDefine.StringStringMap.KeyValue, "Value", val);
				callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Struct, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct], [null, null, null, null, System.UInt64, TypeKind.Struct, OperationKind.LocalReference, SymbolKind.Local], [null, null, null, null, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct, OperationKind.LocalReference, SymbolKind.Local], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", mapKey, wrapstructargument(newKV, DataBlockDefine.StringStringMap.KeyValue, OperationKind.LocalReference, SymbolKind.Local));
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(val, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Remove = deffunc(0)args(this, key){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 2123_12_2133_13 ){
				local(mapKey); mapKey = callstatic(DataBlockDefine.DclApi, "string_uint64_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(kv);
				if( execclosure(true, __invoke_2126_20_2126_58, true){ multiassign(precode{
					},postcode{
						kv = wrapstruct(kv, DataBlockDefine.StringStringMap.KeyValue);
					})varlist(__invoke_2126_20_2126_58, kv) = callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Struct, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct], [null, null, null, null, System.UInt64, TypeKind.Struct, OperationKind.LocalReference, SymbolKind.Local], [null, null, null, null, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct, OperationKind.LocalReference, SymbolKind.Local], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", mapKey, __cs2dsl_out); }, 2126_16_2131_17 ){
					callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Key"), DataBlockDefine.CString, "Release");
					if( execbinary("!=", null, getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 2128_20_2130_21 ){
						callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), DataBlockDefine.CString, "Release");
					};
				};
				callstatic(DataBlockDefine.DclApi, "string_uint64_map_remove_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Contains = deffunc(1)args(this, key){
			local(__method_ret_2135_8_2141_9);
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 2137_12_2139_13 ){
				__method_ret_2135_8_2141_9 = callstatic(DataBlockDefine.DclApi, "string_int64_map_contains", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				return(__method_ret_2135_8_2141_9);
			};
			__method_ret_2135_8_2141_9 = false;
			return(__method_ret_2135_8_2141_9);
		}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Struct, 0, true), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Clear = deffunc(0)args(this){
			foreach(__foreach_2144_12_2150_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(kv); kv = getexterninstancestructmember(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Key"), DataBlockDefine.CString, "Release");
				if( execbinary("!=", null, getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 2147_16_2149_17 ){
					callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), DataBlockDefine.CString, "Release");
				};
			};
			callexternstructdictionaryinstance(2, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Struct, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Struct], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			callstatic(DataBlockDefine.DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"));
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Iterate = deffunc(0)args(this, callback){
			foreach(__foreach_2156_12_2160_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(kv); kv = getexterninstancestructmember(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				if( execunary("!", callexterndelegation(callback, "System.Func_T1_T2_TResult.Invoke", getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Key"), getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value")), System.Boolean, TypeKind.Struct), 2158_16_2159_26 ){
					block{
					break;
					};
				};
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(callback, System.Func_T1_T2_TResult, TypeKind.Delegate, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.StringStringMap, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap", newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "g_System_Collections_Generic_Dictionary_System_UInt64_DataBlockDefine_StringStringMap_KeyValue", typeargs(System.UInt64, DataBlockDefine.StringStringMap.KeyValue), typekinds(TypeKind.Struct, TypeKind.Struct), "ctor", 0, literaldictionary("g_System_Collections_Generic_Dictionary_System_UInt64_DataBlockDefine_StringStringMap_KeyValue", typeargs(System.UInt64, DataBlockDefine.StringStringMap.KeyValue), typekinds(TypeKind.Struct, TypeKind.Struct))));
		}options[needfuncinfo(true)];
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




struct(DataBlockDefine.StringStringMap.KeyValue) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newstruct(DataBlockDefine.StringStringMap.KeyValue, "g_DataBlockDefine_StringStringMap_KeyValue", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(true)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.StringStringMap.KeyValue, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.StringStringMap.KeyValue.__cctor_called){
				return();
			}else{
				DataBlockDefine.StringStringMap.KeyValue.__cctor_called = true;
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
			callinstance(this, DataBlockDefine.StringStringMap.KeyValue, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap.KeyValue, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap.KeyValue, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		Key = null;
		Value = null;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Struct, Accessibility.Private) {
		sealed(true);
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



