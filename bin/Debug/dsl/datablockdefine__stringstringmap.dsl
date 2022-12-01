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
			local(__method_ret_2019_8_2022_9);
			__method_ret_2019_8_2022_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId");
			return(__method_ret_2019_8_2022_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Structure, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid"), 2025_12_2026_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId") = callstatic(DclApi, "alloc_container", 5);
			callexternstructdictionaryinstance(2, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid"), System.Boolean, TypeKind.Structure), 2033_12_2034_23 ){
				return();
			};
			callinstance(this, DataBlockDefine.StringStringMap, "Clear");
			callstatic(DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid"), 2042_12_2043_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId", dataBlockId);
			if( execbinary("!=", dataBlockId, 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 2045_12_2054_13 ){
				callstatic(DclApi, "iterate_string_uint64_map", dataBlockId, deffunc(1)args(k, v){
					local(__method_ret_2046_62_2053_17);
					local(key); key = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
					callinstance(key, DataBlockDefine.CString, "Attach", k);
					local(val); val = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
					callinstance(val, DataBlockDefine.CString, "Attach", v);
					callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure], [null, null, null, null, System.UInt64, TypeKind.Structure, OperationKind.ParameterReference, SymbolKind.Parameter], [null, null, null, null, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure, OperationKind.ObjectCreation, SymbolKind.Method], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", k, newstruct(DataBlockDefine.StringStringMap.KeyValue, "g_DataBlockDefine_StringStringMap_KeyValue", typeargs(), typekinds(), "ctor", 0, function(newobj){ setinstance(SymbolKind.Field, newobj, DataBlockDefine.StringStringMap.KeyValue, "Key", key);setinstance(SymbolKind.Field, newobj, DataBlockDefine.StringStringMap.KeyValue, "Value", val); }));
					__method_ret_2046_62_2053_17 = true;
					return(__method_ret_2046_62_2053_17);
				}options[needfuncinfo(true), rettype(return, System.Boolean, TypeKind.Structure, 0, true), paramtype(k, System.UInt64, TypeKind.Structure, 0, true), paramtype(v, System.UInt64, TypeKind.Structure, 0, true)]);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Structure, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid"), System.Boolean, TypeKind.Structure), 2059_12_2060_23 ){
				return();
			};
			foreach(__foreach_2061_12_2067_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(kv); kv = getexterninstancestructmember(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Key"), DataBlockDefine.CString, "Detach");
				if( execbinary("!=", null, getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 2064_16_2066_17 ){
					callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), DataBlockDefine.CString, "Detach");
				};
			};
			callexternstructdictionaryinstance(2, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_IsValid", false);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_2073_8_2076_9);
			__method_ret_2073_8_2076_9 = getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Count");
			return(__method_ret_2073_8_2076_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Structure, 0, true)];
		GetData = deffunc(1)args(this, key){
			local(__method_ret_2077_8_2087_9);
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 2079_12_2085_13 ){
				local(k); k = callstatic(DclApi, "string_uint64_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(kv);
				if( execclosure(true, __invoke_2082_20_2082_53, true){ multiassign(precode{
					},postcode{
						kv = wrapstruct(kv, DataBlockDefine.StringStringMap.KeyValue);
					})varlist(__invoke_2082_20_2082_53, kv) = callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure], [null, null, null, null, System.UInt64, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], [null, null, null, null, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", k, __cs2dsl_out); }, 2082_16_2084_17 ){
					__method_ret_2077_8_2087_9 = getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value");
					return(__method_ret_2077_8_2087_9);
				};
			};
			__method_ret_2077_8_2087_9 = null;
			return(__method_ret_2077_8_2087_9);
		}options[needfuncinfo(true), rettype(return, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		SetData = deffunc(0)args(this, key, val){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 2090_12_2112_13 ){
				local(oldKey); oldKey = callstatic(DclApi, "string_uint64_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(mapKey); mapKey = callstatic(DclApi, "string_uint64_map_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), condexpfunc(true, retval_2092_105_2092_143, condexp_2092_105_2092_143, DataBlockDefine.StringStringMap, false, val){condexp(execbinary("==", null, val, System.Object, System.Object, TypeKind.Class, TypeKind.Class), true, 0, false, function(){ funcobjret(callinstance(val, DataBlockDefine.CString, "GetDataBlockId")); });}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Structure, 0, true), paramtype(val, DataBlockDefine.CString, Class, 0, false)]);
				if( execbinary("!=", oldKey, mapKey, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 2093_16_2101_17 ){
					local(kv);
					if( execclosure(true, __invoke_2095_24_2095_62, true){ multiassign(precode{
						},postcode{
							kv = wrapstruct(kv, DataBlockDefine.StringStringMap.KeyValue);
						})varlist(__invoke_2095_24_2095_62, kv) = callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure], [null, null, null, null, System.UInt64, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], [null, null, null, null, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", oldKey, __cs2dsl_out); }, 2095_20_2100_21 ){
						callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Key"), DataBlockDefine.CString, "Release");
						if( execbinary("!=", null, getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 2097_24_2099_25 ){
							callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), DataBlockDefine.CString, "Release");
						};
					};
				};
				if( execbinary("!=", mapKey, callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 2102_16_2111_17 ){
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
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 2116_12_2123_13 ){
				local(mapKey); mapKey = callstatic(DclApi, "string_uint64_map_add_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), condexpfunc(true, retval_2117_105_2117_143, condexp_2117_105_2117_143, DataBlockDefine.StringStringMap, false, val){condexp(execbinary("==", null, val, System.Object, System.Object, TypeKind.Class, TypeKind.Class), true, 0, false, function(){ funcobjret(callinstance(val, DataBlockDefine.CString, "GetDataBlockId")); });}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Structure, 0, true), paramtype(val, DataBlockDefine.CString, Class, 0, false)]);
				local(newKV); newKV = newstruct(DataBlockDefine.StringStringMap.KeyValue, "g_DataBlockDefine_StringStringMap_KeyValue", typeargs(), typekinds(), "ctor", 0, null);
				setinstance(SymbolKind.Field, newKV, DataBlockDefine.StringStringMap.KeyValue, "Key", newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null));
				callinstance(getinstance(SymbolKind.Field, newKV, DataBlockDefine.StringStringMap.KeyValue, "Key"), DataBlockDefine.CString, "Attach", mapKey);
				setinstance(SymbolKind.Field, newKV, DataBlockDefine.StringStringMap.KeyValue, "Value", val);
				callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure], [null, null, null, null, System.UInt64, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], [null, null, null, null, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", mapKey, wrapstructargument(newKV, DataBlockDefine.StringStringMap.KeyValue, OperationKind.LocalReference, SymbolKind.Local));
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(val, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Remove = deffunc(0)args(this, key){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 2127_12_2137_13 ){
				local(mapKey); mapKey = callstatic(DclApi, "string_uint64_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(kv);
				if( execclosure(true, __invoke_2130_20_2130_58, true){ multiassign(precode{
					},postcode{
						kv = wrapstruct(kv, DataBlockDefine.StringStringMap.KeyValue);
					})varlist(__invoke_2130_20_2130_58, kv) = callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure], [null, null, null, null, System.UInt64, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], [null, null, null, null, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", mapKey, __cs2dsl_out); }, 2130_16_2135_17 ){
					callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Key"), DataBlockDefine.CString, "Release");
					if( execbinary("!=", null, getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 2132_20_2134_21 ){
						callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), DataBlockDefine.CString, "Release");
					};
				};
				callstatic(DclApi, "string_uint64_map_remove_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Contains = deffunc(1)args(this, key){
			local(__method_ret_2139_8_2145_9);
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 2141_12_2143_13 ){
				__method_ret_2139_8_2145_9 = callstatic(DclApi, "string_int64_map_contains", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				return(__method_ret_2139_8_2145_9);
			};
			__method_ret_2139_8_2145_9 = false;
			return(__method_ret_2139_8_2145_9);
		}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Structure, 0, true), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Clear = deffunc(0)args(this){
			foreach(__foreach_2148_12_2154_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(kv); kv = getexterninstancestructmember(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Key"), DataBlockDefine.CString, "Release");
				if( execbinary("!=", null, getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 2151_16_2153_17 ){
					callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value"), DataBlockDefine.CString, "Release");
				};
			};
			callexternstructdictionaryinstance(2, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringStringMap.KeyValue, TypeKind.Structure], getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			callstatic(DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataBlockId"));
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Iterate = deffunc(0)args(this, callback){
			foreach(__foreach_2160_12_2164_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(kv); kv = getexterninstancestructmember(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				if( execunary("!", callexterndelegation(callback, "System.Func_T1_T2_TResult.Invoke", getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Key"), getinstance(SymbolKind.Field, kv, DataBlockDefine.StringStringMap.KeyValue, "Value")), System.Boolean, TypeKind.Structure), 2162_16_2163_26 ){
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
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringStringMap, "m_DataWrap", newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "g_System_Collections_Generic_Dictionary_System_UInt64_DataBlockDefine_StringStringMap_KeyValue", typeargs(System.UInt64, DataBlockDefine.StringStringMap.KeyValue), typekinds(TypeKind.Structure, TypeKind.Structure), "ctor", 0, literaldictionary("g_System_Collections_Generic_Dictionary_System_UInt64_DataBlockDefine_StringStringMap_KeyValue", typeargs(System.UInt64, DataBlockDefine.StringStringMap.KeyValue), typekinds(TypeKind.Structure, TypeKind.Structure))));
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

	class_info(TypeKind.Structure, Accessibility.Private) {
		sealed(true);
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



