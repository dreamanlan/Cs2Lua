require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(DataBlockDefine.JceStructArray) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.JceStructArray, "g_DataBlockDefine_JceStructArray", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.JceStructArray, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.JceStructArray.__cctor_called){
				return();
			}else{
				DataBlockDefine.JceStructArray.__cctor_called = true;
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
			local(__method_ret_2554_8_2557_9);
			__method_ret_2554_8_2557_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId");
			return(__method_ret_2554_8_2557_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_IsValid"), 2560_12_2561_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_IsValid"), System.Boolean, TypeKind.Struct), 2566_12_2567_23 ){
				return();
			};
			foreachlist(__foreach_ix_2568_12_2570_13, __foreach_exp_2568_12_2570_13, obj, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), DataBlockDefine.IDataBlock, TypeKind.Interface, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
				callinterface(obj, DataBlockDefine.IDataBlock, "Release");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2572_12_2575_13 ){
				callstatic(DataBlockDefine.DclApi, "free_array", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId"));
				setinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId", 0);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_IsValid"), 2580_12_2581_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId", dataBlockId);
			if( execbinary("!=", dataBlockId, 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2583_12_2592_13 ){
				local(len); len = callstatic(DataBlockDefine.DclApi, "get_array_length", dataBlockId);
				setexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), System.Collections.Generic.List_T, "Capacity", len);
				local(ix); ix = 0;
				while( execbinary("<", ix, len, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
					local(objId); objId = callstatic(DataBlockDefine.DclApi, "get_array_element_uint64", dataBlockId, typecast(ix, System.UInt32, TypeKind.Struct));
					local(obj); obj = calldelegation(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "OnNewDataBlock"), "DataBlockDefine.NewDataBlockDelegation.Invoke");
					callinterface(obj, DataBlockDefine.IDataBlock, "Attach", objId);
					callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), System.Collections.Generic.List_T, "Add", obj);
				ix = execbinary("+", ix, 1, null, null, null, null);
				};
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_IsValid"), System.Boolean, TypeKind.Struct), 2597_12_2598_23 ){
				return();
			};
			foreachlist(__foreach_ix_2599_12_2601_13, __foreach_exp_2599_12_2601_13, obj, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), DataBlockDefine.IDataBlock, TypeKind.Interface, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
				callinterface(obj, DataBlockDefine.IDataBlock, "Detach");
			};
			callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetLength = deffunc(1)args(this){
			local(__method_ret_2606_8_2614_9);
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2608_12_2613_13 ){
				__method_ret_2606_8_2614_9 = callstatic(DataBlockDefine.DclApi, "get_array_length", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId"));
				return(__method_ret_2606_8_2614_9);
			}else{
				__method_ret_2606_8_2614_9 = 0;
				return(__method_ret_2606_8_2614_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		Reset = deffunc(0)args(this, size){
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2618_12_2624_13 ){
				foreachlist(__foreach_ix_2619_16_2621_17, __foreach_exp_2619_16_2621_17, obj, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), DataBlockDefine.IDataBlock, TypeKind.Interface, System.Collections.Generic.List_T, System.Collections.Generic.List_T, true){
					callinterface(obj, DataBlockDefine.IDataBlock, "Release");
				};
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), System.Collections.Generic.List_T, "Clear");
				callstatic(DataBlockDefine.DclApi, "free_array", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId"));
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId") = callstatic(DataBlockDefine.DclApi, "alloc_array", 8, size, size);
			setexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), System.Collections.Generic.List_T, "Capacity", typecast(size, System.Int32, TypeKind.Struct));
			local(ix); ix = 0;
			while( execbinary("<", ix, size, System.UInt32, System.UInt32, TypeKind.Struct, TypeKind.Struct) ){
				local(obj); obj = calldelegation(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "OnNewDataBlock"), "DataBlockDefine.NewDataBlockDelegation.Invoke");
				callexterninstance(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), System.Collections.Generic.List_T, "Add", obj);
			ix = execbinary("+", ix, 1, null, null, null, null);
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(size, System.UInt32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, T, index){
			local(__method_ret_2632_8_2640_9);
			if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 2634_12_2639_13 ){
				__method_ret_2632_8_2640_9 = typecast(getexterninstanceindexer(DataBlockDefine.IDataBlock, TypeKind.Interface, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), System.Collections.Generic.List_T, "get_Item", 1, index), T, TypeKind.TypeParameter);
				return(__method_ret_2632_8_2640_9);
			}else{
				__method_ret_2632_8_2640_9 = null;
				return(__method_ret_2632_8_2640_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(T, DataBlockDefine.IDataBlock, TypeKind.TypeParameter, 0, false), paramtype(T, DataBlockDefine.IDataBlock, TypeKind.TypeParameter, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		SetData = deffunc(0)args(this, index, val){
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 2643_12_2648_13 ){
				if( execbinary("&&", execbinary(">=", index, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), execbinary("<", index, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), System.Collections.Generic.List_T, "Count"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 2644_16_2646_17 ){
					setexterninstanceindexer(DataBlockDefine.IDataBlock, TypeKind.Interface, System.Collections.Generic.List_T, getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap"), System.Collections.Generic.List_T, "set_Item", 2, index, val);
				};
				callstatic(DataBlockDefine.DclApi, "set_array_element_uint64", getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataBlockId"), typecast(index, System.UInt32, TypeKind.Struct), callinterface(val, DataBlockDefine.IDataBlock, "GetDataBlockId"));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true), paramtype(val, DataBlockDefine.IDataBlock, TypeKind.Interface, 0, false)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.JceStructArray, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.JceStructArray, "m_DataWrap", newexternlist(System.Collections.Generic.List_T, "g_System_Collections_Generic_List_DataBlockDefine_IDataBlock", typeargs(DataBlockDefine.IDataBlock), typekinds(TypeKind.Interface), "ctor", 0, literallist("g_System_Collections_Generic_List_DataBlockDefine_IDataBlock", typeargs(DataBlockDefine.IDataBlock), typekinds(TypeKind.Interface))));
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
		GetLength(MethodKind.Ordinary, Accessibility.Public){
		};
		Reset(MethodKind.Ordinary, Accessibility.Public){
		};
		GetData(MethodKind.Ordinary, Accessibility.Public){
			generic(true);
		};
		SetData(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



