require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(DataBlockDefine.Int64DoubleMap) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.Int64DoubleMap, "g_DataBlockDefine_Int64DoubleMap", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.Int64DoubleMap, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.Int64DoubleMap.__cctor_called){
				return();
			}else{
				DataBlockDefine.Int64DoubleMap.__cctor_called = true;
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
			local(__method_ret_1466_8_1469_9);
			__method_ret_1466_8_1469_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId");
			return(__method_ret_1466_8_1469_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_IsValid"), 1472_12_1473_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId") = callstatic(DataBlockDefine.DclApi, "alloc_container", 9);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_IsValid"), System.Boolean, TypeKind.Struct), 1479_12_1480_23 ){
				return();
			};
			callstatic(DataBlockDefine.DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_IsValid"), 1487_12_1488_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId", dataBlockId);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_IsValid"), System.Boolean, TypeKind.Struct), 1494_12_1495_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_1500_8_1503_9);
			__method_ret_1500_8_1503_9 = typecast(callstatic(DataBlockDefine.DclApi, "container_get_size", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId")), System.Int32, TypeKind.Struct);
			return(__method_ret_1500_8_1503_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, key){
			local(__method_ret_1504_8_1507_9);
			__method_ret_1504_8_1507_9 = callstatic(DataBlockDefine.DclApi, "int64_double_map_get_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId"), key);
			return(__method_ret_1504_8_1507_9);
		}options[needfuncinfo(false), rettype(return, System.Double, TypeKind.Struct, 0, true), paramtype(key, System.Int64, TypeKind.Struct, 0, true)];
		SetData = deffunc(0)args(this, key, val){
			callstatic(DataBlockDefine.DclApi, "int64_double_map_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId"), key, val);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, System.Int64, TypeKind.Struct, 0, true), paramtype(val, System.Double, TypeKind.Struct, 0, true)];
		Add = deffunc(0)args(this, key, val){
			callstatic(DataBlockDefine.DclApi, "int64_double_map_add_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId"), key, val);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, System.Int64, TypeKind.Struct, 0, true), paramtype(val, System.Double, TypeKind.Struct, 0, true)];
		Remove = deffunc(0)args(this, key){
			callstatic(DataBlockDefine.DclApi, "int64_double_map_remove_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId"), key);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(key, System.Int64, TypeKind.Struct, 0, true)];
		Contains = deffunc(1)args(this, key){
			local(__method_ret_1520_8_1523_9);
			__method_ret_1520_8_1523_9 = callstatic(DataBlockDefine.DclApi, "int64_double_map_contains", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId"), key);
			return(__method_ret_1520_8_1523_9);
		}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Struct, 0, true), paramtype(key, System.Int64, TypeKind.Struct, 0, true)];
		Clear = deffunc(0)args(this){
			callstatic(DataBlockDefine.DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId"));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Iterate = deffunc(0)args(this, callback){
			callstatic(DataBlockDefine.DclApi, "iterate_int64_double_map", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "m_DataBlockId"), deffunc(1)args(k, v){
				local(__method_ret_1530_59_1530_95);
				__method_ret_1530_59_1530_95 = callexterndelegation(callback, "System.Func_T1_T2_TResult.Invoke", k, v);
				return(__method_ret_1530_59_1530_95);
			}options[needfuncinfo(false), rettype(return, System.Boolean, TypeKind.Struct, 0, true), paramtype(k, System.Int64, TypeKind.Struct, 0, true), paramtype(v, System.Double, TypeKind.Struct, 0, true)]);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(callback, System.Func_T1_T2_TResult, TypeKind.Delegate, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.Int64DoubleMap, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.Int64DoubleMap, "__ctor_called", true);
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



