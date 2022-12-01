require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(DataBlockDefine.Int64DataBlockMap) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.Int64DataBlockMap, "g_DataBlockDefine_Int64DataBlockMap", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.Int64DataBlockMap, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.Int64DataBlockMap.__cctor_called){
				return();
			}else{
				DataBlockDefine.Int64DataBlockMap.__cctor_called = true;
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
			local(__method_ret_1653_8_1656_9);
			__method_ret_1653_8_1656_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataBlockId");
			return(__method_ret_1653_8_1656_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Structure, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_IsValid"), 1659_12_1660_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataBlockId") = callstatic(DclApi, "alloc_container", 8);
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_IsValid"), System.Boolean, TypeKind.Structure), 1667_12_1668_23 ){
				return();
			};
			callinstance(this, DataBlockDefine.Int64DataBlockMap, "Clear");
			callstatic(DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_IsValid"), 1676_12_1677_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataBlockId", dataBlockId);
			if( execbinary("!=", dataBlockId, 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 1679_12_1686_13 ){
				callstatic(DclApi, "iterate_int64_uint64_map", dataBlockId, deffunc(1)args(k, v){
					local(__method_ret_1680_61_1685_17);
					local(elem); elem = calldelegation(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "OnNewDataBlock"), "DataBlockDefine.NewDataBlockDelegation.Invoke");
					callinterface(elem, DataBlockDefine.IDataBlock, "Attach", v);
					callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", k, elem);
					__method_ret_1680_61_1685_17 = true;
					return(__method_ret_1680_61_1685_17);
				}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Structure, 0, true), paramtype(k, System.Int64, TypeKind.Structure, 0, true), paramtype(v, System.UInt64, TypeKind.Structure, 0, true)]);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Structure, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_IsValid"), System.Boolean, TypeKind.Structure), 1691_12_1692_23 ){
				return();
			};
			foreach(__foreach_1693_12_1697_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(elem); elem = getexterninstance(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				if( execbinary("!=", null, elem, System.Object, System.Object, TypeKind.Class, TypeKind.Class), 1695_16_1696_34 ){
					callinterface(elem, DataBlockDefine.IDataBlock, "Detach");
				};
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_IsValid", false);
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_1703_8_1706_9);
			__method_ret_1703_8_1706_9 = getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Count");
			return(__method_ret_1703_8_1706_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Structure, 0, true)];
		GetData = deffunc(1)args(this, T, key){
			local(__method_ret_1707_8_1712_9);
			local(v);
			local(__invoke_1710_12_1710_46); multiassign(precode{
				},postcode{
				})varlist(__invoke_1710_12_1710_46, v) = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "TryGetValue", key, __cs2dsl_out);
			__method_ret_1707_8_1712_9 = typecast(v, T, TypeKind.TypeParameter);
			return(__method_ret_1707_8_1712_9);
		}options[needfuncinfo(false), rettype(T, DataBlockDefine.IDataBlock, TypeKind.TypeParameter, 0, false), paramtype(T, DataBlockDefine.IDataBlock, TypeKind.TypeParameter, 0, false), paramtype(key, System.Int64, TypeKind.Structure, 0, true)];
		SetData = deffunc(0)args(this, key, val){
			setexterninstanceindexer(DataBlockDefine.IDataBlock, TypeKind.Interface, System.Collections.Generic.Dictionary_TKey_TValue, getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "set_Item", 2, key, val);
			callstatic(DclApi, "int64_uint64_map_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataBlockId"), key, callinterface(val, DataBlockDefine.IDataBlock, "GetDataBlockId"));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, System.Int64, TypeKind.Structure, 0, true), paramtype(val, DataBlockDefine.IDataBlock, TypeKind.Interface, 0, false)];
		Add = deffunc(0)args(this, key, val){
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Add", key, val);
			callstatic(DclApi, "int64_uint64_map_add_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataBlockId"), key, callinterface(val, DataBlockDefine.IDataBlock, "GetDataBlockId"));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, System.Int64, TypeKind.Structure, 0, true), paramtype(val, DataBlockDefine.IDataBlock, TypeKind.Interface, 0, false)];
		Remove = deffunc(0)args(this, key){
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Remove", key);
			callstatic(DclApi, "int64_uint64_map_remove_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataBlockId"), key);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, System.Int64, TypeKind.Structure, 0, true)];
		Contains = deffunc(1)args(this, key){
			local(__method_ret_1728_8_1731_9);
			__method_ret_1728_8_1731_9 = callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "ContainsKey", key);
			return(__method_ret_1728_8_1731_9);
		}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Structure, 0, true), paramtype(key, System.Int64, TypeKind.Structure, 0, true)];
		Clear = deffunc(0)args(this){
			foreach(__foreach_1734_12_1738_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				local(elem); elem = getexterninstance(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value");
				if( execbinary("!=", null, elem, System.Object, System.Object, TypeKind.Class, TypeKind.Class), 1736_16_1737_35 ){
					callinterface(elem, DataBlockDefine.IDataBlock, "Release");
				};
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, "Clear");
			callstatic(DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataBlockId"));
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Iterate = deffunc(0)args(this, callback){
			foreach(__foreach_1744_12_1747_13, pair, getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap"), System.Collections.Generic.Dictionary_TKey_TValue, System.Collections.Generic.Dictionary_TKey_TValue, true){
				if( execunary("!", callexterndelegation(callback, "System.Func_T1_T2_TResult.Invoke", getexterninstance(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Key"), getexterninstance(SymbolKind.Property, pair, System.Collections.Generic.KeyValuePair_TKey_TValue, "Value")), System.Boolean, TypeKind.Structure), 1745_16_1746_26 ){
					block{
					break;
					};
				};
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(callback, System.Func_T1_T2_TResult, TypeKind.Delegate, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.Int64DataBlockMap, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DataBlockMap, "m_DataWrap", newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "g_System_Collections_Generic_Dictionary_System_Int64_DataBlockDefine_IDataBlock", typeargs(System.Int64, DataBlockDefine.IDataBlock), typekinds(TypeKind.Structure, TypeKind.Interface), "ctor", 0, literaldictionary("g_System_Collections_Generic_Dictionary_System_Int64_DataBlockDefine_IDataBlock", typeargs(System.Int64, DataBlockDefine.IDataBlock), typekinds(TypeKind.Structure, TypeKind.Interface))));
		}options[needfuncinfo(false)];
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



