require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(DataBlockDefine.Int64Int64Map) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.Int64Int64Map, "g_DataBlockDefine_Int64Int64Map", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.Int64Int64Map, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.Int64Int64Map.__cctor_called){
				return();
			}else{
				DataBlockDefine.Int64Int64Map.__cctor_called = true;
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
			local(__method_ret_1396_8_1399_9);
			__method_ret_1396_8_1399_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId");
			return(__method_ret_1396_8_1399_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_IsValid"), 1402_12_1403_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId") = callstatic(DataBlockDefine.DclApi, "alloc_container", 7);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_IsValid"), System.Boolean, TypeKind.Struct), 1409_12_1410_23 ){
				return();
			};
			callstatic(DataBlockDefine.DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_IsValid"), 1417_12_1418_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId", dataBlockId);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_IsValid"), System.Boolean, TypeKind.Struct), 1424_12_1425_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_1430_8_1433_9);
			__method_ret_1430_8_1433_9 = typecast(callstatic(DataBlockDefine.DclApi, "container_get_size", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId")), System.Int32, TypeKind.Struct);
			return(__method_ret_1430_8_1433_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, key){
			local(__method_ret_1434_8_1437_9);
			__method_ret_1434_8_1437_9 = callstatic(DataBlockDefine.DclApi, "int64_int64_map_get_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId"), key);
			return(__method_ret_1434_8_1437_9);
		}options[needfuncinfo(false), rettype(return, System.Int64, TypeKind.Struct, 0, true), paramtype(key, System.Int64, TypeKind.Struct, 0, true)];
		SetData = deffunc(0)args(this, key, val){
			callstatic(DataBlockDefine.DclApi, "int64_int64_map_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId"), key, val);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, System.Int64, TypeKind.Struct, 0, true), paramtype(val, System.Int64, TypeKind.Struct, 0, true)];
		Add = deffunc(0)args(this, key, val){
			callstatic(DataBlockDefine.DclApi, "int64_int64_map_add_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId"), key, val);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, System.Int64, TypeKind.Struct, 0, true), paramtype(val, System.Int64, TypeKind.Struct, 0, true)];
		Remove = deffunc(0)args(this, key){
			callstatic(DataBlockDefine.DclApi, "int64_int64_map_remove_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId"), key);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, System.Int64, TypeKind.Struct, 0, true)];
		Contains = deffunc(1)args(this, key){
			local(__method_ret_1450_8_1453_9);
			__method_ret_1450_8_1453_9 = callstatic(DataBlockDefine.DclApi, "int64_int64_map_contains", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId"), key);
			return(__method_ret_1450_8_1453_9);
		}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Struct, 0, true), paramtype(key, System.Int64, TypeKind.Struct, 0, true)];
		Clear = deffunc(0)args(this){
			callstatic(DataBlockDefine.DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId"));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Iterate = deffunc(0)args(this, callback){
			callstatic(DataBlockDefine.DclApi, "iterate_int64_int64_map", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "m_DataBlockId"), deffunc(1)args(k, v){
				local(__method_ret_1460_58_1460_94);
				__method_ret_1460_58_1460_94 = callexterndelegation(callback, "System.Func_T1_T2_TResult.Invoke", k, v);
				return(__method_ret_1460_58_1460_94);
			}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Struct, 0, true), paramtype(k, System.Int64, TypeKind.Struct, 0, true), paramtype(v, System.Int64, TypeKind.Struct, 0, true)]);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(callback, System.Func_T1_T2_TResult, TypeKind.Delegate, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.Int64Int64Map, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Int64Map, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		m_IsValid = false;
		m_DataBlockId = 0;
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



