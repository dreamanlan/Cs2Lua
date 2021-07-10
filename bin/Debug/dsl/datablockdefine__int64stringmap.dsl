require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("datablockdefine__cstring");

class(DataBlockDefine.Int64StringMap) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.Int64StringMap, "g_DataBlockDefine_Int64StringMap", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.Int64StringMap, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.Int64StringMap.__cctor_called){
				return();
			}else{
				DataBlockDefine.Int64StringMap.__cctor_called = true;
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
			local(__method_ret_1540_8_1543_9);
			__method_ret_1540_8_1543_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataBlockId");
			return(__method_ret_1540_8_1543_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_IsValid"), 1546_12_1547_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataBlockId") = callstatic(DataBlockDefine.DclApi, "alloc_container", 8);
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_IsValid"), System.Boolean, TypeKind.Struct), 1554_12_1555_23 ){
				return();
			};
			callinstance(this, DataBlockDefine.Int64StringMap, "Clear");
			callstatic(DataBlockDefine.DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_IsValid"), 1563_12_1564_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataBlockId", dataBlockId);
			if( execbinary("!=", dataBlockId, 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 1566_12_1573_13 ){
				callstatic(DataBlockDefine.DclApi, "iterate_int64_uint64_map", dataBlockId, deffunc(1)args(k, v){
					local(__method_ret_1567_61_1572_17);
					local(elem); elem = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
					callinstance(elem, DataBlockDefine.CString, "Attach", v);
					callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", k, elem);
					__method_ret_1567_61_1572_17 = true;
					return(__method_ret_1567_61_1572_17);
				}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Struct, 0, true), paramtype(k, System.Int64, TypeKind.Struct, 0, true), paramtype(v, System.UInt64, TypeKind.Struct, 0, true)]);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_IsValid"), System.Boolean, TypeKind.Struct), 1578_12_1579_23 ){
				return();
			};
			foreach(__foreach_1580_12_1584_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(elem); elem = getexterninstance(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				if( execbinary("!=", null, elem, System.Object, System.Object, TypeKind.Class, TypeKind.Class), 1582_16_1583_34 ){
					callinstance(elem, DataBlockDefine.CString, "Detach");
				};
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_IsValid", false);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_1590_8_1593_9);
			__method_ret_1590_8_1593_9 = getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Count");
			return(__method_ret_1590_8_1593_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, key){
			local(__method_ret_1594_8_1599_9);
			local(ret);
			local(__invoke_1597_12_1597_48); multiassign(precode{
				},postcode{
				})varlist(__invoke_1597_12_1597_48, ret) = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", key, __cs2dsl_out);
			__method_ret_1594_8_1599_9 = ret;
			return(__method_ret_1594_8_1599_9);
		}options[needfuncinfo(false), rettype(return, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(key, System.Int64, TypeKind.Struct, 0, true)];
		SetData = deffunc(0)args(this, key, val){
			local(oldVal);
			if( execclosure(true, __invoke_1603_16_1603_55, true){ multiassign(precode{
				},postcode{
				})varlist(__invoke_1603_16_1603_55, oldVal) = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", key, __cs2dsl_out); }, 1603_12_1605_13 ){
				callinstance(oldVal, DataBlockDefine.CString, "Release");
			};
			setexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.Dictionary_TKey_TValue, getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "set_Item", 2, key, val);
			callstatic(DataBlockDefine.DclApi, "int64_uint64_map_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataBlockId"), key, condexpfunc(true, retval_1607_68_1607_106, condexp_1607_68_1607_106, DataBlockDefine.Int64StringMap, false, val){condexp(execbinary("==", null, val, System.Object, System.Object, TypeKind.Class, TypeKind.Class), true, 0, false, function(){ funcobjret(callinstance(val, DataBlockDefine.CString, "GetDataBlockId")); });}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true), paramtype(val, DataBlockDefine.CString, Class, 0, false)]);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, System.Int64, TypeKind.Struct, 0, true), paramtype(val, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Add = deffunc(0)args(this, key, val){
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", key, val);
			callstatic(DataBlockDefine.DclApi, "int64_uint64_map_add_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataBlockId"), key, condexpfunc(true, retval_1612_68_1612_106, condexp_1612_68_1612_106, DataBlockDefine.Int64StringMap, false, val){condexp(execbinary("==", null, val, System.Object, System.Object, TypeKind.Class, TypeKind.Class), true, 0, false, function(){ funcobjret(callinstance(val, DataBlockDefine.CString, "GetDataBlockId")); });}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true), paramtype(val, DataBlockDefine.CString, Class, 0, false)]);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, System.Int64, TypeKind.Struct, 0, true), paramtype(val, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		Remove = deffunc(0)args(this, key){
			local(oldVal);
			if( execclosure(true, __invoke_1617_16_1617_55, true){ multiassign(precode{
				},postcode{
				})varlist(__invoke_1617_16_1617_55, oldVal) = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", key, __cs2dsl_out); }, 1617_12_1619_13 ){
				callinstance(oldVal, DataBlockDefine.CString, "Release");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Remove", key);
			callstatic(DataBlockDefine.DclApi, "int64_uint64_map_remove_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataBlockId"), key);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, System.Int64, TypeKind.Struct, 0, true)];
		Contains = deffunc(1)args(this, key){
			local(__method_ret_1623_8_1626_9);
			__method_ret_1623_8_1626_9 = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "ContainsKey", key);
			return(__method_ret_1623_8_1626_9);
		}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Struct, 0, true), paramtype(key, System.Int64, TypeKind.Struct, 0, true)];
		Clear = deffunc(0)args(this){
			foreach(__foreach_1629_12_1633_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(elem); elem = getexterninstance(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				if( execbinary("!=", null, elem, System.Object, System.Object, TypeKind.Class, TypeKind.Class), 1631_16_1632_35 ){
					callinstance(elem, DataBlockDefine.CString, "Release");
				};
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			callstatic(DataBlockDefine.DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataBlockId"));
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Iterate = deffunc(0)args(this, callback){
			foreach(__foreach_1639_12_1642_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				if( execunary("!", callexterndelegation(callback, "System.Func_T1_T2_TResult.Invoke", getexterninstance(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Key"), getexterninstance(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value")), System.Boolean, TypeKind.Struct), 1640_16_1641_26 ){
					block{
					break;
					};
				};
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(callback, System.Func_T1_T2_TResult, TypeKind.Delegate, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.Int64StringMap, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64StringMap, "m_DataWrap", newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "g_System_Collections_Generic_Dictionary_System_Int64_DataBlockDefine_CString", typeargs(System.Int64, DataBlockDefine.CString), typekinds(TypeKind.Struct, TypeKind.Class), "ctor", 0, literaldictionary("g_System_Collections_Generic_Dictionary_System_Int64_DataBlockDefine_CString", typeargs(System.Int64, DataBlockDefine.CString), typekinds(TypeKind.Struct, TypeKind.Class))));
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



