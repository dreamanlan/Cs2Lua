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
			local(__method_ret_2451_8_2454_9);
			__method_ret_2451_8_2454_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId");
			return(__method_ret_2451_8_2454_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Structure, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid"), 2457_12_2458_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid"), System.Boolean, TypeKind.Structure), 2463_12_2464_23 ){
				return();
			};
			foreachlist(__foreach_ix_2465_12_2467_13, __foreach_exp_2465_12_2467_13, str, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
				callstatic(DclApi, "free_string", callinstance(str, DataBlockDefine.CString, "GetDataBlockId"));
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 2469_12_2472_13 ){
				callstatic(DclApi, "free_array", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"));
				setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId", 0);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid"), 2477_12_2478_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId", dataBlockId);
			if( execbinary("!=", dataBlockId, 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 2480_12_2489_13 ){
				local(len); len = callstatic(DclApi, "get_array_length", dataBlockId);
				setexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Capacity", len);
				local(ix); ix = 0;
				while( execbinary("<", ix, len, System.Int32, System.Int32, TypeKind.Structure, TypeKind.Structure) ){
					local(strId); strId = callstatic(DclApi, "get_array_element_uint64", dataBlockId, typecast(ix, System.UInt32, TypeKind.Structure));
					local(cstr); cstr = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
					callinstance(cstr, DataBlockDefine.CString, "Attach", strId);
					callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Add", cstr);
				ix = execbinary("+", ix, 1, null, null, null, null);
				};
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Structure, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid"), System.Boolean, TypeKind.Structure), 2494_12_2495_23 ){
				return();
			};
			foreachlist(__foreach_ix_2496_12_2498_13, __foreach_exp_2496_12_2498_13, str, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
				callinstance(str, DataBlockDefine.CString, "Detach");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetLength = deffunc(1)args(this){
			local(__method_ret_2503_8_2511_9);
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 2505_12_2510_13 ){
				__method_ret_2503_8_2511_9 = callstatic(DclApi, "get_array_length", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"));
				return(__method_ret_2503_8_2511_9);
			}else{
				__method_ret_2503_8_2511_9 = 0;
				return(__method_ret_2503_8_2511_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Structure, 0, true)];
		Reset = deffunc(0)args(this, size){
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 2515_12_2521_13 ){
				foreachlist(__foreach_ix_2516_16_2518_17, __foreach_exp_2516_16_2518_17, str, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
					callstatic(DclApi, "free_string", callinstance(str, DataBlockDefine.CString, "GetDataBlockId"));
				};
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
				callstatic(DclApi, "free_array", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"));
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId") = callstatic(DclApi, "alloc_array", 8, size, size);
			setexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Capacity", typecast(size, System.Int32, TypeKind.Structure));
			local(ix); ix = 0;
			while( execbinary("<", ix, size, System.UInt32, System.UInt32, TypeKind.Structure, TypeKind.Structure) ){
				local(cstr); cstr = newobject(DataBlockDefine.CString, "g_DataBlockDefine_CString", typeargs(), typekinds(), "ctor", 0, null);
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Add", cstr);
			ix = execbinary("+", ix, 1, null, null, null, null);
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(size, System.UInt32, TypeKind.Structure, 0, true)];
		GetData = deffunc(1)args(this, index){
			local(__method_ret_2529_8_2537_9);
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Structure, TypeKind.Structure), execbinary("<", index, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), System.Int32, System.Int32, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 2531_12_2536_13 ){
				__method_ret_2529_8_2537_9 = getexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "get_Item", 1, index);
				return(__method_ret_2529_8_2537_9);
			}else{
				__method_ret_2529_8_2537_9 = null;
				return(__method_ret_2529_8_2537_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, DataBlockDefine.CString, TypeKind.Class, 0, false), paramtype(index, System.Int32, TypeKind.Structure, 0, true)];
		SetData = deffunc(0)args(this, index, val){
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Structure, TypeKind.Structure), 2540_12_2545_13 ){
				if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Structure, TypeKind.Structure), execbinary("<", index, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), System.Int32, System.Int32, TypeKind.Structure, TypeKind.Structure), System.Boolean, System.Boolean, TypeKind.Structure, TypeKind.Structure), 2541_16_2543_17 ){
					setexterninstanceindexer(DataBlockDefine.CString, TypeKind.Class, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataWrap"), System.Collections.Generic.List_T, "set_Item", 2, index, val);
				};
				callstatic(DclApi, "set_array_element_uint64", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStringArray, "m_DataBlockId"), typecast(index, System.UInt32, TypeKind.Structure), callinstance(val, DataBlockDefine.CString, "GetDataBlockId"));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Structure, 0, true), paramtype(val, DataBlockDefine.CString, TypeKind.Class, 0, false)];
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



