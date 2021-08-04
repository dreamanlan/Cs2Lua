require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("datablockdefine__cstring");

class(DataBlockDefine.StringVector) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.StringVector, "g_DataBlockDefine_StringVector", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.StringVector, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.StringVector.__cctor_called){
				return();
			}else{
				DataBlockDefine.StringVector.__cctor_called = true;
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
			local(__method_ret_1134_8_1137_9);
			__method_ret_1134_8_1137_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId");
			return(__method_ret_1134_8_1137_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_IsValid"), 1140_12_1141_23 ){
				return();
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId") = callstatic(DclApi, "alloc_container", 2);
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_IsValid"), System.Boolean, TypeKind.Struct), 1148_12_1149_23 ){
				return();
			};
			callinstance(this, DataBlockDefine.StringVector, "Clear");
			callstatic(DclApi, "free_container", getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId"));
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_IsValid"), 1157_12_1158_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId", dataBlockId);
			local(ct); ct = typecast(callstatic(DclApi, "container_get_size", getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId")), System.Int32, TypeKind.Struct);
			local(ix); ix = 0;
			while( execbinary("<", ix, ct, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(strId); strId = callstatic(DclApi, "uint64_vector_get_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId"), typecast(ix, System.UInt64, TypeKind.Struct));
				local(cstr); cstr = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
				callinstance(cstr, DataBlockDefine.CString, "Attach", strId);
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "Add", cstr);
			ix = execbinary("+", ix, 1, null, null, null, null);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_IsValid"), System.Boolean, TypeKind.Struct), 1171_12_1172_23 ){
				return();
			};
			foreachlist(__foreach_ix_1173_12_1175_13, __foreach_exp_1173_12_1175_13, str, getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
				callinstance(str, DataBlockDefine.CString, "Detach");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Reserve = deffunc(0)args(this, space){
			setexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "Capacity", space);
			callstatic(DclApi, "container_reserve_space", getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId"), typecast(space, System.UInt64, TypeKind.Struct));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(space, System.Int32, TypeKind.Struct, 0, true)];
		GetCount = deffunc(1)args(this){
			local(__method_ret_1186_8_1189_9);
			__method_ret_1186_8_1189_9 = getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "Count");
			return(__method_ret_1186_8_1189_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, index){
			local(__method_ret_1190_8_1196_9);
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, callinstance(this, DataBlockDefine.StringVector, "GetCount"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1192_12_1194_13 ){
				__method_ret_1190_8_1196_9 = getexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "get_Item", 1, index);
				return(__method_ret_1190_8_1196_9);
			};
			__method_ret_1190_8_1196_9 = null;
			return(__method_ret_1190_8_1196_9);
		}options[needfuncinfo(false), rettype(return, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		SetData = deffunc(0)args(this, index, data){
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, callinstance(this, DataBlockDefine.StringVector, "GetCount"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1199_12_1206_13 ){
				local(oldData); oldData = getexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "get_Item", 1, index);
				if( execbinary("!=", null, oldData, System.Object, System.Object, TypeKind.Class, TypeKind.Class), 1201_16_1203_17 ){
					callinstance(oldData, DataBlockDefine.CString, "Release");
				};
				setexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "set_Item", 2, index, data);
				callstatic(DclApi, "uint64_vector_set_element", getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId"), typecast(index, System.UInt64, TypeKind.Struct), condexpfunc(true, retval_1205_78_1205_118, condexp_1205_78_1205_118, DataBlockDefine.StringVector, false, data){condexp(execbinary("==", null, data, System.Object, System.Object, TypeKind.Class, TypeKind.Class), true, 0, false, function(){ funcobjret(callinstance(data, DataBlockDefine.CString, "GetDataBlockId")); });}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true), paramtype(data, DataBlockDefine.CString, Class, 0, false)]);
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true), paramtype(data, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		IndexOf = deffunc(1)args(this, data){
			local(__method_ret_1208_8_1215_9);
			local(ix); ix = 0;
			while( execbinary("<", ix, callinstance(this, DataBlockDefine.StringVector, "GetCount"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				if( execbinary("==", callinstance(this, DataBlockDefine.StringVector, "GetData", ix), data, System.Object, System.Object, TypeKind.Class, TypeKind.Class), 1211_16_1212_30 ){
					__method_ret_1208_8_1215_9 = ix;
					return(__method_ret_1208_8_1215_9);
				};
			ix = execbinary("+", ix, 1, null, null, null, null);
			};
			__method_ret_1208_8_1215_9 = -1;
			return(__method_ret_1208_8_1215_9);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(data, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		GetLast = deffunc(1)args(this){
			local(__method_ret_1216_8_1222_9);
			if( execbinary(">", callinstance(this, DataBlockDefine.StringVector, "GetCount"), 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), 1218_12_1221_28 ){
				__method_ret_1216_8_1222_9 = callinstance(this, DataBlockDefine.StringVector, "GetData", execbinary("-", callinstance(this, DataBlockDefine.StringVector, "GetCount"), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
				return(__method_ret_1216_8_1222_9);
			}else{
				__method_ret_1216_8_1222_9 = null;
				return(__method_ret_1216_8_1222_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		AddLast = deffunc(0)args(this, data){
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "Add", data);
			callstatic(DclApi, "uint64_vector_push_back", getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId"), condexpfunc(true, retval_1226_58_1226_98, condexp_1226_58_1226_98, DataBlockDefine.StringVector, false, data){condexp(execbinary("==", null, data, System.Object, System.Object, TypeKind.Class, TypeKind.Class), true, 0, false, function(){ funcobjret(callinstance(data, DataBlockDefine.CString, "GetDataBlockId")); });}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true), paramtype(data, DataBlockDefine.CString, Class, 0, false)]);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(data, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		RemoveLast = deffunc(0)args(this){
			if( execbinary(">", getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), 1230_12_1237_13 ){
				local(oldData); oldData = getexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "get_Item", 1, execbinary("-", getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
				if( execbinary("!=", null, oldData, System.Object, System.Object, TypeKind.Class, TypeKind.Class), 1232_16_1234_17 ){
					callinstance(oldData, DataBlockDefine.CString, "Release");
				};
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "RemoveAt", execbinary("-", getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
				callstatic(DclApi, "uint64_vector_pop_back", getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId"));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Remove = deffunc(0)args(this, data){
			local(index); index = callinstance(this, DataBlockDefine.StringVector, "IndexOf", data);
			if( execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), 1242_12_1247_13 ){
				if( execbinary("!=", null, data, System.Object, System.Object, TypeKind.Class, TypeKind.Class), 1243_16_1245_17 ){
					callinstance(data, DataBlockDefine.CString, "Release");
				};
				callinstance(this, DataBlockDefine.StringVector, "RemoveAt", index);
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(data, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		RemoveAt = deffunc(0)args(this, index){
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, callinstance(this, DataBlockDefine.StringVector, "GetCount"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 1251_12_1258_13 ){
				local(oldData); oldData = getexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "get_Item", 1, index);
				if( execbinary("!=", null, oldData, System.Object, System.Object, TypeKind.Class, TypeKind.Class), 1253_16_1255_17 ){
					callinstance(oldData, DataBlockDefine.CString, "Release");
				};
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "RemoveAt", index);
				callstatic(DclApi, "uint64_vector_erase", getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId"), typecast(index, System.UInt64, TypeKind.Struct));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		Clear = deffunc(0)args(this){
			foreachlist(__foreach_ix_1262_12_1264_13, __foreach_exp_1262_12_1264_13, str, getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
				callinstance(str, DataBlockDefine.CString, "Release");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			callstatic(DclApi, "container_clear", getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataBlockId"));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.StringVector, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.StringVector, "m_DataWrap", newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_DataBlockDefine_CString", typeargs(DataBlockDefine.CString), typekinds(TypeKind.Class), "ctor", 0, literallist("g_System_Collections_Generic_List_DataBlockDefine_CString", typeargs(DataBlockDefine.CString), typekinds(TypeKind.Class))));
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



