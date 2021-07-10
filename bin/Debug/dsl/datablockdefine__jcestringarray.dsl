require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("datablockdefine__cstring");

class(DataBlockDefine.JceStringArray) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.JceStringArray, "g_DataBlockDefine_JceStringArray", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.JceStringArray, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.JceStringArray.__cctor_called){
				return();
			}else{
				DataBlockDefine.JceStringArray.__cctor_called = true;
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
			local(__method_ret_2446_8_2449_9);
			__method_ret_2446_8_2449_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId");
			return(__method_ret_2446_8_2449_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid"), 2452_12_2453_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid"), System.Boolean, TypeKind.Struct), 2458_12_2459_23 ){
				return();
			};
			foreachlist(__foreach_ix_2460_12_2462_13, __foreach_exp_2460_12_2462_13, str, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
				callstatic(DataBlockDefine.DclApi, "free_string", callinstance(str, DataBlockDefine.CString, "GetDataBlockId"));
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2464_12_2467_13 ){
				callstatic(DataBlockDefine.DclApi, "free_array", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"));
				setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId", 0);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid"), 2472_12_2473_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId", dataBlockId);
			if( execbinary("!=", dataBlockId, 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2475_12_2484_13 ){
				local(len); len = callstatic(DataBlockDefine.DclApi, "get_array_length", dataBlockId);
				setexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Capacity", len);
				local(ix); ix = 0;
				while( execbinary("<", ix, len, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
					local(strId); strId = callstatic(DataBlockDefine.DclApi, "get_array_element_uint64", dataBlockId, typecast(ix, System.UInt32, TypeKind.Struct));
					local(cstr); cstr = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
					callinstance(cstr, DataBlockDefine.CString, "Attach", strId);
					callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Add", cstr);
				ix = execbinary("+", ix, 1, null, null, null, null);
				};
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid"), System.Boolean, TypeKind.Struct), 2489_12_2490_23 ){
				return();
			};
			foreachlist(__foreach_ix_2491_12_2493_13, __foreach_exp_2491_12_2493_13, str, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
				callinstance(str, DataBlockDefine.CString, "Detach");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetLength = deffunc(1)args(this){
			local(__method_ret_2498_8_2506_9);
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2500_12_2505_13 ){
				__method_ret_2498_8_2506_9 = callstatic(DataBlockDefine.DclApi, "get_array_length", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"));
				return(__method_ret_2498_8_2506_9);
			}else{
				__method_ret_2498_8_2506_9 = 0;
				return(__method_ret_2498_8_2506_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		Reset = deffunc(0)args(this, size){
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2510_12_2516_13 ){
				foreachlist(__foreach_ix_2511_16_2513_17, __foreach_exp_2511_16_2513_17, str, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
					callstatic(DataBlockDefine.DclApi, "free_string", callinstance(str, DataBlockDefine.CString, "GetDataBlockId"));
				};
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
				callstatic(DataBlockDefine.DclApi, "free_array", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"));
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId") = callstatic(DataBlockDefine.DclApi, "alloc_array", 8, size, size);
			setexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Capacity", typecast(size, System.Int32, TypeKind.Struct));
			local(ix); ix = 0;
			while( execbinary("<", ix, size, System.UInt32, System.UInt32, TypeKind.Struct, TypeKind.Struct) ){
				local(cstr); cstr = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Add", cstr);
			ix = execbinary("+", ix, 1, null, null, null, null);
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(size, System.UInt32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, index){
			local(__method_ret_2524_8_2532_9);
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 2526_12_2531_13 ){
				__method_ret_2524_8_2532_9 = getexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "get_Item", 1, index);
				return(__method_ret_2524_8_2532_9);
			}else{
				__method_ret_2524_8_2532_9 = null;
				return(__method_ret_2524_8_2532_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		SetData = deffunc(0)args(this, index, val){
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2535_12_2540_13 ){
				if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 2536_16_2538_17 ){
					setexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "set_Item", 2, index, val);
				};
				callstatic(DataBlockDefine.DclApi, "set_array_element_uint64", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"), typecast(index, System.UInt32, TypeKind.Struct), callinstance(val, DataBlockDefine.CString, "GetDataBlockId"));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true), paramtype(val, DataBlockDefine.CString, TypeKind.Class, 0, false)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.JceStringArray, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap", newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_DataBlockDefine_CString", typeargs(DataBlockDefine.CString), typekinds(TypeKind.Class), "ctor", 0, literallist("g_System_Collections_Generic_List_DataBlockDefine_CString", typeargs(DataBlockDefine.CString), typekinds(TypeKind.Class))));
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
		GetLength(MethodKind.Ordinary, Accessibility.Public){
		};
		Reset(MethodKind.Ordinary, Accessibility.Public){
		};
		GetData(MethodKind.Ordinary, Accessibility.Public){
		};
		SetData(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



