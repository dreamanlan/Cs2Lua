require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("datablockdefine__cstring");

class(DataBlockDefine.StringInt64Map) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.StringInt64Map, "g_DataBlockDefine_StringInt64Map", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.StringInt64Map, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.StringInt64Map.__cctor_called){
				return();
			}else{
				DataBlockDefine.StringInt64Map.__cctor_called = true;
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
			local(__method_ret_1753_8_1756_9);
			__method_ret_1753_8_1756_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId");
			return(__method_ret_1753_8_1756_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_IsValid"), 1759_12_1760_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId") = callstatic(DataBlockDefine.DclApi, "alloc_container", 4);
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_IsValid"), System.Boolean, TypeKind.Struct), 1767_12_1768_23 ){
				return();
			};
			callinstance(this, DataBlockDefine.StringInt64Map, "Clear");
			callstatic(DataBlockDefine.DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_IsValid"), 1776_12_1777_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId", dataBlockId);
			if( execbinary("!=", dataBlockId, 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 1779_12_1786_13 ){
				callstatic(DataBlockDefine.DclApi, "iterate_string_int64_map", dataBlockId, deffunc(1)args(k, v){
					local(__method_ret_1780_61_1785_17);
					local(key); key = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
					callinstance(key, DataBlockDefine.CString, "Attach", k);
					callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", k, key);
					__method_ret_1780_61_1785_17 = true;
					return(__method_ret_1780_61_1785_17);
				}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Struct, 0, true), paramtype(k, System.UInt64, TypeKind.Struct, 0, true), paramtype(v, System.Int64, TypeKind.Struct, 0, true)]);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_IsValid"), System.Boolean, TypeKind.Struct), 1791_12_1792_23 ){
				return();
			};
			foreach(__foreach_1793_12_1796_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(key); key = getexterninstance(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				callinstance(key, DataBlockDefine.CString, "Detach");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_IsValid", false);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_1802_8_1805_9);
			__method_ret_1802_8_1805_9 = getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Count");
			return(__method_ret_1802_8_1805_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, key){
			local(__method_ret_1806_8_1809_9);
			__method_ret_1806_8_1809_9 = callstatic(DataBlockDefine.DclApi, "string_int64_map_get_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId"), condexpfunc(true, retval_1808_70_1808_108, condexp_1808_70_1808_108, DataBlockDefine.StringInt64Map, false, key){condexp(execbinary("==", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), true, 0, false, function(){ funcobjret(callinstance(key, DataBlockDefine.CString, "GetDataBlockId")); });}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true), paramtype(key, DataBlockDefine.CString, Class, 0, false)]);
			return(__method_ret_1806_8_1809_9);
		}options[needfuncinfo(false), rettype(return, System.Int64, TypeKind.Struct, 0, true), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		SetData = deffunc(0)args(this, key, val){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1812_12_1829_13 ){
				local(oldKey); oldKey = callstatic(DataBlockDefine.DclApi, "string_int64_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(mapKey); mapKey = callstatic(DataBlockDefine.DclApi, "string_int64_map_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), val);
				if( execbinary("!=", oldKey, mapKey, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 1815_16_1820_17 ){
					local(oldKeyObj);
					if( execclosure(true, __invoke_1817_24_1817_69, true){ multiassign(precode{
						},postcode{
						})varlist(__invoke_1817_24_1817_69, oldKeyObj) = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", oldKey, __cs2dsl_out); }, 1817_20_1819_21 ){
						callinstance(oldKeyObj, DataBlockDefine.CString, "Release");
					};
				};
				if( execbinary("!=", mapKey, callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 1821_16_1828_17 ){
					local(newKey); newKey = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
					callinstance(newKey, DataBlockDefine.CString, "Attach", mapKey);
					setexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.Dictionary_TKey_TValue, getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "set_Item", 2, mapKey, newKey);
				}else{
					setexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.Dictionary_TKey_TValue, getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "set_Item", 2, mapKey, key);
				};
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(val, System.Int64, TypeKind.Struct, 0, true)];
		Add = deffunc(0)args(this, key, val){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1833_12_1838_13 ){
				local(mapKey); mapKey = callstatic(DataBlockDefine.DclApi, "string_int64_map_add_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), val);
				local(newKey); newKey = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
				callinstance(newKey, DataBlockDefine.CString, "Attach", mapKey);
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", mapKey, newKey);
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(val, System.Int64, TypeKind.Struct, 0, true)];
		Remove = deffunc(0)args(this, key){
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1842_12_1849_13 ){
				local(mapKey); mapKey = callstatic(DataBlockDefine.DclApi, "string_int64_map_get_key", getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				local(keyObj);
				if( execclosure(true, __invoke_1845_20_1845_62, true){ multiassign(precode{
					},postcode{
					})varlist(__invoke_1845_20_1845_62, keyObj) = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", mapKey, __cs2dsl_out); }, 1845_16_1847_17 ){
					callinstance(keyObj, DataBlockDefine.CString, "Release");
				};
				callstatic(DataBlockDefine.DclApi, "string_int64_map_remove_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Contains = deffunc(1)args(this, key){
			local(__method_ret_1851_8_1857_9);
			if( execbinary("&&", execbinary("!=", null, key, System.Object, System.Object, TypeKind.Class, TypeKind.Class), execbinary("!=", callinstance(key, DataBlockDefine.CString, "GetDataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1853_12_1855_13 ){
				__method_ret_1851_8_1857_9 = callstatic(DataBlockDefine.DclApi, "string_int64_map_contains", getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId"), callinstance(key, DataBlockDefine.CString, "GetDataBlockId"));
				return(__method_ret_1851_8_1857_9);
			};
			__method_ret_1851_8_1857_9 = false;
			return(__method_ret_1851_8_1857_9);
		}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Struct, 0, true), paramtype(key, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Clear = deffunc(0)args(this){
			foreach(__foreach_1860_12_1863_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(key); key = getexterninstance(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				callinstance(key, DataBlockDefine.CString, "Release");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			callstatic(DataBlockDefine.DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId"));
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Iterate = deffunc(0)args(this, callback){
			callstatic(DataBlockDefine.DclApi, "iterate_string_int64_map", getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataBlockId"), deffunc(1)args(k, v){
				local(__method_ret_1869_59_1875_13);
				local(kObj);
				if( execclosure(true, __invoke_1871_20_1871_55, true){ multiassign(precode{
					},postcode{
					})varlist(__invoke_1871_20_1871_55, kObj) = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", k, __cs2dsl_out); }, 1871_16_1874_33 ){
					__method_ret_1869_59_1875_13 = callexterndelegation(callback, "System.Func_T1_T2_TResult.Invoke", kObj, v);
					return(__method_ret_1869_59_1875_13);
				}else{
					__method_ret_1869_59_1875_13 = false;
					return(__method_ret_1869_59_1875_13);
				};
				return(null);
			}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Struct, 0, true), paramtype(k, System.UInt64, TypeKind.Struct, 0, true), paramtype(v, System.Int64, TypeKind.Struct, 0, true)]);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(callback, System.Func_T1_T2_TResult, TypeKind.Delegate, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.StringInt64Map, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringInt64Map, "m_DataWrap", newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "g_System_Collections_Generic_Dictionary_System_UInt64_DataBlockDefine_CString", typeargs(System.UInt64, DataBlockDefine.CString), typekinds(TypeKind.Struct, TypeKind.Class), "ctor", 0, literaldictionary("g_System_Collections_Generic_Dictionary_System_UInt64_DataBlockDefine_CString", typeargs(System.UInt64, DataBlockDefine.CString), typekinds(TypeKind.Struct, TypeKind.Class))));
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



