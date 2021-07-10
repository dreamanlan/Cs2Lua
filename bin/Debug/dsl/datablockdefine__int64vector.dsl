require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(DataBlockDefine.Int64Vector) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.Int64Vector, "g_DataBlockDefine_Int64Vector", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.Int64Vector, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.Int64Vector.__cctor_called){
				return();
			}else{
				DataBlockDefine.Int64Vector.__cctor_called = true;
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
			local(__method_ret_945_8_948_9);
			__method_ret_945_8_948_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId");
			return(__method_ret_945_8_948_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_IsValid"), 951_12_952_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId") = callstatic(DataBlockDefine.DclApi, "alloc_container", 1);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_IsValid"), System.Boolean, TypeKind.Struct), 958_12_959_23 ){
				return();
			};
			callstatic(DataBlockDefine.DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_IsValid"), 966_12_967_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId", dataBlockId);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_IsValid"), System.Boolean, TypeKind.Struct), 973_12_974_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Reserve = deffunc(0)args(this, space){
			callstatic(DataBlockDefine.DclApi, "container_reserve_space", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId"), typecast(space, System.UInt64, TypeKind.Struct));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(space, System.Int32, TypeKind.Struct, 0, true)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_983_8_986_9);
			__method_ret_983_8_986_9 = typecast(callstatic(DataBlockDefine.DclApi, "container_get_size", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId")), System.Int32, TypeKind.Struct);
			return(__method_ret_983_8_986_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, index){
			local(__method_ret_987_8_993_9);
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, callinstance(this, DataBlockDefine.Int64Vector, "GetCount"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 989_12_991_13 ){
				__method_ret_987_8_993_9 = callstatic(DataBlockDefine.DclApi, "int64_vector_get_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId"), typecast(index, System.UInt64, TypeKind.Struct));
				return(__method_ret_987_8_993_9);
			};
			__method_ret_987_8_993_9 = 0;
			return(__method_ret_987_8_993_9);
		}options[needfuncinfo(false), rettype(return, System.Int64, TypeKind.Struct, 0, true), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		SetData = deffunc(0)args(this, index, data){
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, callinstance(this, DataBlockDefine.Int64Vector, "GetCount"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 996_12_998_13 ){
				callstatic(DataBlockDefine.DclApi, "int64_vector_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId"), typecast(index, System.UInt64, TypeKind.Struct), data);
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true), paramtype(data, System.Int64, TypeKind.Struct, 0, true)];
		IndexOf = deffunc(1)args(this, data){
			local(__method_ret_1000_8_1007_9);
			local(ix); ix = 0;
			while( execbinary("<", ix, callinstance(this, DataBlockDefine.Int64Vector, "GetCount"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				if( execbinary("==", callinstance(this, DataBlockDefine.Int64Vector, "GetData", ix), data, System.Int64, System.Int64, TypeKind.Struct, TypeKind.Struct), 1003_16_1004_30 ){
					__method_ret_1000_8_1007_9 = ix;
					return(__method_ret_1000_8_1007_9);
				};
			ix = execbinary("+", ix, 1, null, null, null, null);
			};
			__method_ret_1000_8_1007_9 = -1;
			return(__method_ret_1000_8_1007_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(data, System.Int64, TypeKind.Struct, 0, true)];
		GetLast = deffunc(1)args(this){
			local(__method_ret_1008_8_1011_9);
			__method_ret_1008_8_1011_9 = callinstance(this, DataBlockDefine.Int64Vector, "GetData", execbinary("-", callinstance(this, DataBlockDefine.Int64Vector, "GetCount"), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			return(__method_ret_1008_8_1011_9);
		}options[needfuncinfo(false), rettype(return, System.Int64, TypeKind.Struct, 0, true)];
		AddLast = deffunc(0)args(this, data){
			callstatic(DataBlockDefine.DclApi, "int64_vector_push_back", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId"), data);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(data, System.Int64, TypeKind.Struct, 0, true)];
		RemoveLast = deffunc(0)args(this){
			callstatic(DataBlockDefine.DclApi, "int64_vector_pop_back", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId"));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Remove = deffunc(0)args(this, data){
			local(index); index = callinstance(this, DataBlockDefine.Int64Vector, "IndexOf", data);
			callinstance(this, DataBlockDefine.Int64Vector, "RemoveAt", index);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(data, System.Int64, TypeKind.Struct, 0, true)];
		RemoveAt = deffunc(0)args(this, index){
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, callinstance(this, DataBlockDefine.Int64Vector, "GetCount"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1027_12_1029_13 ){
				callstatic(DataBlockDefine.DclApi, "int64_vector_erase", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId"), typecast(index, System.UInt64, TypeKind.Struct));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		Clear = deffunc(0)args(this){
			callstatic(DataBlockDefine.DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "m_DataBlockId"));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.Int64Vector, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.Int64Vector, "__ctor_called", true);
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



