require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("datablockdefine__cstring");

class(DataBlockDefine.StringDataBlockMap) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.StringDataBlockMap, "g_DataBlockDefine_StringDataBlockMap", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.StringDataBlockMap, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.StringDataBlockMap.__cctor_called){
				return();
			}else{
				DataBlockDefine.StringDataBlockMap.__cctor_called = true;
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
			local(__method_ret_2180_8_2183_9);
			__method_ret_2180_8_2183_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId");
			return(__method_ret_2180_8_2183_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Structure, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_IsValid"), 2186_12_2187_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId") = callstatic(DclApi, "alloc_container", 5);
			callexternstructdictionaryinstance(2, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure], getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_IsValid"), System.Boolean, TypeKind.Structure), 2194_12_2195_23 ){
				return();
			};
			callinstance(this, DataBlockDefine.StringDataBlockMap, "Clear");
			callstatic(DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_IsValid"), 2203_12_2204_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId", dataBlockId);
			if( execbinary("!=", dataBlockId, 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 2206_12_2215_13 ){
				callstatic(DclApi, "iterate_string_uint64_map", dataBlockId, deffunc(1)args(k, v){
					local(__method_ret_2207_62_2214_17);
					local(key); key = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
					callinstance(key, DataBlockDefine.CString, "Attach", k);
					local(val); val = calldelegation(getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "OnNewDataBlock"), "DataBlockDefine.NewDataBlockDelegation.Invoke");
					callinterface(val, DataBlockDefine.IDataBlock, "Attach", v);
					callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure], [null, null, null, null, System.UInt64, TypeKind.Structure, OperationKind.ParameterReference, SymbolKind.Parameter], [null, null, null, null, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure, OperationKind.ObjectCreation, SymbolKind.Method], getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", k, newstruct(DataBlockDefine.StringDataBlockMap.KeyValue, "g_DataBlockDefine_StringDataBlockMap_KeyValue", typeargs(), typekinds(), "ctor", 0, function(newobj){ setinstance(SymbolKind.Field, newobj, DataBlockDefine.StringDataBlockMap.KeyValue, "Key", key);setinstance(SymbolKind.Field, newobj, DataBlockDefine.StringDataBlockMap.KeyValue, "Value", val); }));
					__method_ret_2207_62_2214_17 = true;
					return(__method_ret_2207_62_2214_17);
				}options[needfuncinfo(true), rettype(return, System.Boolean, TypeKind.Structure, 0, true), paramtype(k, System.UInt64, TypeKind.Structure, 0, true), paramtype(v, System.UInt64, TypeKind.Structure, 0, true)]);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Structure, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_IsValid"), System.Boolean, TypeKind.Structure), 2220_12_2221_23 ){
				return();
			};
			foreach(__foreach_2222_12_2228_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(kv); kv = getexterninstancestructmember(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Key"), DataBlockDefine.CString, "Detach");
				if( execbinary("!=", null, getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Value"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 2225_16_2227_17 ){
					callinterface(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Value"), DataBlockDefine.IDataBlock, "Detach");
				};
			};
			callexternstructdictionaryinstance(2, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure], getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_IsValid", false);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_2234_8_2237_9);
			__method_ret_2234_8_2237_9 = getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Count");
			return(__method_ret_2234_8_2237_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Structure, 0, true)];
		GetData = deffunc(1)args(this, T, key){
			local(__method_ret_2238_8_2248_9);
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 2240_12_2246_13 ){
				local(k); k = callstatic(DclApi, "string_uint64_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(kv);
				if( execclosure(true, __invoke_2243_20_2243_53, true){ multiassign(precode{
					},postcode{
						kv = wrapstruct(kv, DataBlockDefine.StringDataBlockMap.KeyValue);
					})varlist(__invoke_2243_20_2243_53, kv) = callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure], [null, null, null, null, System.UInt64, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], [null, null, null, null, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", k, __cs2dsl_out); }, 2243_16_2245_17 ){
					__method_ret_2238_8_2248_9 = typecast(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Value"), T, TypeKind.TypeParameter);
					return(__method_ret_2238_8_2248_9);
				};
			};
			__method_ret_2238_8_2248_9 = null;
			return(__method_ret_2238_8_2248_9);
		}options[needfuncinfo(true), rettype(T, DataBlockDefine.IDataBlock, TypeKind.TypeParameter, 0, false), paramtype(T, DataBlockDefine.IDataBlock, TypeKind.TypeParameter, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		SetData = deffunc(0)args(this, key, val){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 2251_12_2273_13 ){
				local(oldKey); oldKey = callstatic(DclApi, "string_uint64_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(mapKey); mapKey = callstatic(DclApi, "string_uint64_map_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), condexpfunc(true, retval_2253_105_2253_143, condexp_2253_105_2253_143, DataBlockDefine.StringDataBlockMap, false, val){condexp(execbinary("==", null, val, System.Object, System.Object, TypeKind.Class, TypeKind.Class), true, 0, false, function(){ funcobjret(callinterface(val, DataBlockDefine.IDataBlock, "GetDataBlockId")); });}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Structure, 0, true), paramtype(val, DataBlockDefine.IDataBlock, Interface, 0, false)]);
				if( execbinary("!=", oldKey, mapKey, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 2254_16_2262_17 ){
					local(kv);
					if( execclosure(true, __invoke_2256_24_2256_62, true){ multiassign(precode{
						},postcode{
							kv = wrapstruct(kv, DataBlockDefine.StringDataBlockMap.KeyValue);
						})varlist(__invoke_2256_24_2256_62, kv) = callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure], [null, null, null, null, System.UInt64, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], [null, null, null, null, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", oldKey, __cs2dsl_out); }, 2256_20_2261_21 ){
						callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Key"), DataBlockDefine.CString, "Release");
						if( execbinary("!=", null, getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Value"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 2258_24_2260_25 ){
							callinterface(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Value"), DataBlockDefine.IDataBlock, "Release");
						};
					};
				};
				if( execbinary("!=", mapKey, callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 2263_16_2272_17 ){
					local(newKV); newKV = newstruct(DataBlockDefine.StringDataBlockMap.KeyValue, "g_DataBlockDefine_StringDataBlockMap_KeyValue", typeargs(), typekinds(), "ctor", 0, null);
					setinstance(SymbolKind.Field, newKV, DataBlockDefine.StringDataBlockMap.KeyValue, "Key", newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null));
					callinstance(getinstance(SymbolKind.Field, newKV, DataBlockDefine.StringDataBlockMap.KeyValue, "Key"), DataBlockDefine.CString, "Attach", mapKey);
					setinstance(SymbolKind.Field, newKV, DataBlockDefine.StringDataBlockMap.KeyValue, "Value", val);
					setinstanceindexerstruct(true, DataBlockDefine.StringDataBlockMap.KeyValue, System.Collections.Generic.Dictionary_TKey_TValue, getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "set_Item", 2, mapKey, newKV);
				}else{
					setinstanceindexerstruct(true, DataBlockDefine.StringDataBlockMap.KeyValue, System.Collections.Generic.Dictionary_TKey_TValue, getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "set_Item", 2, mapKey, newstruct(DataBlockDefine.StringDataBlockMap.KeyValue, "g_DataBlockDefine_StringDataBlockMap_KeyValue", typeargs(), typekinds(), "ctor", 0, function(newobj){ setinstance(SymbolKind.Field, newobj, DataBlockDefine.StringDataBlockMap.KeyValue, "Key", key);setinstance(SymbolKind.Field, newobj, DataBlockDefine.StringDataBlockMap.KeyValue, "Value", val); }));
				};
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(val, DataBlockDefine.IDataBlock, TypeKind.Interface, 0, false)];
		Add = deffunc(0)args(this, key, val){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 2277_12_2284_13 ){
				local(mapKey); mapKey = callstatic(DclApi, "string_uint64_map_add_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), condexpfunc(true, retval_2278_105_2278_143, condexp_2278_105_2278_143, DataBlockDefine.StringDataBlockMap, false, val){condexp(execbinary("==", null, val, System.Object, System.Object, TypeKind.Class, TypeKind.Class), true, 0, false, function(){ funcobjret(callinterface(val, DataBlockDefine.IDataBlock, "GetDataBlockId")); });}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Structure, 0, true), paramtype(val, DataBlockDefine.IDataBlock, Interface, 0, false)]);
				local(newKV); newKV = newstruct(DataBlockDefine.StringDataBlockMap.KeyValue, "g_DataBlockDefine_StringDataBlockMap_KeyValue", typeargs(), typekinds(), "ctor", 0, null);
				setinstance(SymbolKind.Field, newKV, DataBlockDefine.StringDataBlockMap.KeyValue, "Key", newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null));
				callinstance(getinstance(SymbolKind.Field, newKV, DataBlockDefine.StringDataBlockMap.KeyValue, "Key"), DataBlockDefine.CString, "Attach", mapKey);
				setinstance(SymbolKind.Field, newKV, DataBlockDefine.StringDataBlockMap.KeyValue, "Value", val);
				callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure], [null, null, null, null, System.UInt64, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], [null, null, null, null, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", mapKey, wrapstructargument(newKV, DataBlockDefine.StringDataBlockMap.KeyValue, OperationKind.LocalReference, SymbolKind.Local));
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(val, DataBlockDefine.IDataBlock, TypeKind.Interface, 0, false)];
		Remove = deffunc(0)args(this, key){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 2288_12_2298_13 ){
				local(mapKey); mapKey = callstatic(DclApi, "string_uint64_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(kv);
				if( execclosure(true, __invoke_2291_20_2291_58, true){ multiassign(precode{
					},postcode{
						kv = wrapstruct(kv, DataBlockDefine.StringDataBlockMap.KeyValue);
					})varlist(__invoke_2291_20_2291_58, kv) = callexternstructdictionaryinstance(4, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure], [null, null, null, null, System.UInt64, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], [null, null, null, null, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure, OperationKind.LocalReference, SymbolKind.Local], getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", mapKey, __cs2dsl_out); }, 2291_16_2296_17 ){
					callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Key"), DataBlockDefine.CString, "Release");
					if( execbinary("!=", null, getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Value"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 2293_20_2295_21 ){
						callinterface(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Value"), DataBlockDefine.IDataBlock, "Release");
					};
				};
				callstatic(DclApi, "string_uint64_map_remove_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Contains = deffunc(1)args(this, key){
			local(__method_ret_2300_8_2306_9);
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 2302_12_2304_13 ){
				__method_ret_2300_8_2306_9 = callstatic(DclApi, "string_int64_map_contains", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				return(__method_ret_2300_8_2306_9);
			};
			__method_ret_2300_8_2306_9 = false;
			return(__method_ret_2300_8_2306_9);
		}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Structure, 0, true), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Clear = deffunc(0)args(this){
			foreach(__foreach_2309_12_2315_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(kv); kv = getexterninstancestructmember(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				callinstance(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Key"), DataBlockDefine.CString, "Release");
				if( execbinary("!=", null, getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Value"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 2312_16_2314_17 ){
					callinterface(getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Value"), DataBlockDefine.IDataBlock, "Release");
				};
			};
			callexternstructdictionaryinstance(2, [System.Collections.Generic.Dictionary_TKey_TValue, System.UInt64, TypeKind.Structure, DataBlockDefine.StringDataBlockMap.KeyValue, TypeKind.Structure], getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			callstatic(DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataBlockId"));
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Iterate = deffunc(0)args(this, callback){
			foreach(__foreach_2321_12_2325_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(kv); kv = getexterninstancestructmember(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				if( execunary("!", callexterndelegation(callback, "System.Func_T1_T2_TResult.Invoke", getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Key"), getinstance(SymbolKind.Field, kv, DataBlockDefine.StringDataBlockMap.KeyValue, "Value")), System.Boolean, TypeKind.Structure), 2323_16_2324_26 ){
					block{
					break;
					};
				};
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(callback, System.Func_T1_T2_TResult, TypeKind.Delegate, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.StringDataBlockMap, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap, "m_DataWrap", newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "g_System_Collections_Generic_Dictionary_System_UInt64_DataBlockDefine_StringDataBlockMap_KeyValue", typeargs(System.UInt64, DataBlockDefine.StringDataBlockMap.KeyValue), typekinds(TypeKind.Structure, TypeKind.Structure), "ctor", 0, literaldictionary("g_System_Collections_Generic_Dictionary_System_UInt64_DataBlockDefine_StringDataBlockMap_KeyValue", typeargs(System.UInt64, DataBlockDefine.StringDataBlockMap.KeyValue), typekinds(TypeKind.Structure, TypeKind.Structure))));
		}options[needfuncinfo(true)];
	};
	instance_fields {
		OnNewDataBlock = null;
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
			generic(true);
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




struct(DataBlockDefine.StringDataBlockMap.KeyValue) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newstruct(DataBlockDefine.StringDataBlockMap.KeyValue, "g_DataBlockDefine_StringDataBlockMap_KeyValue", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(true)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.StringDataBlockMap.KeyValue, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.StringDataBlockMap.KeyValue.__cctor_called){
				return();
			}else{
				DataBlockDefine.StringDataBlockMap.KeyValue.__cctor_called = true;
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
			callinstance(this, DataBlockDefine.StringDataBlockMap.KeyValue, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap.KeyValue, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.StringDataBlockMap.KeyValue, "__ctor_called", true);
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



