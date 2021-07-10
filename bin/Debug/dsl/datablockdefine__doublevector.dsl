require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(DataBlockDefine.DoubleVector) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.DoubleVector, "g_DataBlockDefine_DoubleVector", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.DoubleVector, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.DoubleVector.__cctor_called){
				return();
			}else{
				DataBlockDefine.DoubleVector.__cctor_called = true;
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
			local(__method_ret_1041_8_1044_9);
			__method_ret_1041_8_1044_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId");
			return(__method_ret_1041_8_1044_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_IsValid"), 1047_12_1048_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId") = callstatic(DataBlockDefine.DclApi, "alloc_container", 3);
			setinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_IsValid"), System.Boolean, TypeKind.Struct), 1054_12_1055_23 ){
				return();
			};
			callstatic(DataBlockDefine.DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_IsValid"), 1062_12_1063_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId", dataBlockId);
			setinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_IsValid"), System.Boolean, TypeKind.Struct), 1069_12_1070_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Reserve = deffunc(0)args(this, space){
			callstatic(DataBlockDefine.DclApi, "container_reserve_space", getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId"), typecast(space, System.UInt64, TypeKind.Struct));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(space, System.Int32, TypeKind.Struct, 0, true)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_1079_8_1082_9);
			__method_ret_1079_8_1082_9 = typecast(callstatic(DataBlockDefine.DclApi, "container_get_size", getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId")), System.Int32, TypeKind.Struct);
			return(__method_ret_1079_8_1082_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, index){
			local(__method_ret_1083_8_1089_9);
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, callinstance(this, DataBlockDefine.DoubleVector, "GetCount"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1085_12_1087_13 ){
				__method_ret_1083_8_1089_9 = callstatic(DataBlockDefine.DclApi, "double_vector_get_element", getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId"), typecast(index, System.UInt64, TypeKind.Struct));
				return(__method_ret_1083_8_1089_9);
			};
			__method_ret_1083_8_1089_9 = 0;
			return(__method_ret_1083_8_1089_9);
		}options[needfuncinfo(false), rettype(return, System.Double, TypeKind.Struct, 0, true), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		SetData = deffunc(0)args(this, index, data){
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, callinstance(this, DataBlockDefine.DoubleVector, "GetCount"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1092_12_1094_13 ){
				callstatic(DataBlockDefine.DclApi, "double_vector_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId"), typecast(index, System.UInt64, TypeKind.Struct), data);
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true), paramtype(data, System.Double, TypeKind.Struct, 0, true)];
		IndexOf = deffunc(1)args(this, data){
			local(__method_ret_1096_8_1099_9);
			__method_ret_1096_8_1099_9 = typecast(callstatic(DataBlockDefine.DclApi, "double_vector_index_of_element", getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId"), data), System.Int32, TypeKind.Struct);
			return(__method_ret_1096_8_1099_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(data, System.Double, TypeKind.Struct, 0, true)];
		GetLast = deffunc(1)args(this){
			local(__method_ret_1100_8_1103_9);
			__method_ret_1100_8_1103_9 = callinstance(this, DataBlockDefine.DoubleVector, "GetData", execbinary("-", callinstance(this, DataBlockDefine.DoubleVector, "GetCount"), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			return(__method_ret_1100_8_1103_9);
		}options[needfuncinfo(false), rettype(return, System.Double, TypeKind.Struct, 0, true)];
		AddLast = deffunc(0)args(this, data){
			callstatic(DataBlockDefine.DclApi, "double_vector_push_back", getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId"), data);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(data, System.Double, TypeKind.Struct, 0, true)];
		RemoveLast = deffunc(0)args(this){
			callstatic(DataBlockDefine.DclApi, "double_vector_pop_back", getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId"));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Remove = deffunc(0)args(this, data){
			local(index); index = callinstance(this, DataBlockDefine.DoubleVector, "IndexOf", data);
			callinstance(this, DataBlockDefine.DoubleVector, "RemoveAt", index);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(data, System.Int64, TypeKind.Struct, 0, true)];
		RemoveAt = deffunc(0)args(this, index){
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, callinstance(this, DataBlockDefine.DoubleVector, "GetCount"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1119_12_1121_13 ){
				callstatic(DataBlockDefine.DclApi, "double_vector_erase", getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId"), typecast(index, System.UInt64, TypeKind.Struct));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		Clear = deffunc(0)args(this){
			callstatic(DataBlockDefine.DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "m_DataBlockId"));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.DoubleVector, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.DoubleVector, "__ctor_called", true);
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
		Reserve(MethodKind.Ordinary, Accessibility.Public){
		};
		GetCount(MethodKind.Ordinary, Accessibility.Public){
		};
		GetData(MethodKind.Ordinary, Accessibility.Public){
		};
		SetData(MethodKind.Ordinary, Accessibility.Public){
		};
		IndexOf(MethodKind.Ordinary, Accessibility.Public){
		};
		GetLast(MethodKind.Ordinary, Accessibility.Public){
		};
		AddLast(MethodKind.Ordinary, Accessibility.Public){
		};
		RemoveLast(MethodKind.Ordinary, Accessibility.Public){
		};
		Remove(MethodKind.Ordinary, Accessibility.Public){
		};
		RemoveAt(MethodKind.Ordinary, Accessibility.Public){
		};
		Clear(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



