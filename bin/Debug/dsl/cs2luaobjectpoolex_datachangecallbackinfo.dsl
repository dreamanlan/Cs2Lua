require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(Cs2LuaObjectPoolEx_DataChangeCallBackInfo) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "g_Cs2LuaObjectPoolEx_T", typeargs(T), typekinds(TypeKind.TypeParameter), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(Cs2LuaObjectPoolEx_DataChangeCallBackInfo.__cctor_called){
				return();
			}else{
				Cs2LuaObjectPoolEx_DataChangeCallBackInfo.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		Init__Func_1_T__Action_1_T = deffunc(0)args(this, creater, destroyer){
			setinstancedelegation(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_Creater", delegationset(false, this, "m_Creater", SymbolKind.Field, creater));
			setinstancedelegation(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_Destroyer", delegationset(false, this, "m_Destroyer", SymbolKind.Field, destroyer));
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(creater, System.Func_TResult, TypeKind.Delegate, 0, true), paramtype(destroyer, System.Action_T, TypeKind.Delegate, 0, true)];
		Init__Int32__Func_1_T__Action_1_T = deffunc(0)args(this, initPoolSize, creater, destroyer){
			setinstancedelegation(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_Creater", delegationset(false, this, "m_Creater", SymbolKind.Field, creater));
			setinstancedelegation(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_Destroyer", delegationset(false, this, "m_Destroyer", SymbolKind.Field, destroyer));
			local(i); i = 0;
			while( execbinary("<", i, initPoolSize, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(t); t = callexterndelegation(creater, "System.Func_TResult.Invoke");
				callinterface(t, ICs2LuaPoolAllocatedObjectEx_DataChangeCallBackInfo, "InitPool", this);
				callexterninstance(getinstance(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_UnusedObjects"), System.Collections.Generic.Queue_T, "Enqueue", t);
			i = execbinary("+", i, 1, null, null, null, null);
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(initPoolSize, System.Int32, TypeKind.Struct, 0, true), paramtype(creater, System.Func_TResult, TypeKind.Delegate, 0, true), paramtype(destroyer, System.Action_T, TypeKind.Delegate, 0, true)];
		Alloc = deffunc(1)args(this){
			local(__method_ret_77_4_88_5);
			if( execbinary(">", getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_UnusedObjects"), System.Collections.Generic.Queue_T, "Count"), 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				__method_ret_77_4_88_5 = callexterninstance(getinstance(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_UnusedObjects"), System.Collections.Generic.Queue_T, "Dequeue");
				return(__method_ret_77_4_88_5);
			}else{
				local(t); t = callexterndelegation(getinstance(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_Creater"), "System.Func_TResult.Invoke");
				if( execbinary("!=", null, t, System.Object, System.Object, TypeKind.Class, TypeKind.Class) ){
					callinterface(t, ICs2LuaPoolAllocatedObjectEx_DataChangeCallBackInfo, "InitPool", this);
				};
				__method_ret_77_4_88_5 = t;
				return(__method_ret_77_4_88_5);
			};
			return(null);
		}options[needfuncinfo(false), rettype(T, ICs2LuaPoolAllocatedObjectEx_DataChangeCallBackInfo, TypeKind.TypeParameter, 0, false)];
		Recycle = deffunc(0)args(this, t){
			if( execbinary("!=", null, t, System.Object, System.Object, TypeKind.Class, TypeKind.Class) ){
				callexterninstance(getinstance(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_UnusedObjects"), System.Collections.Generic.Queue_T, "Enqueue", callinterface(t, ICs2LuaPoolAllocatedObjectEx_DataChangeCallBackInfo, "Downcast"));
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(t, ICs2LuaPoolAllocatedObjectEx_DataChangeCallBackInfo, TypeKind.Interface, 0, false)];
		Clear = deffunc(0)args(this){
			if( delegationcomparewithnil(false, this, "m_Destroyer", SymbolKind.Field, false) ){
				foreach(__foreach_98_12_100_13, item, getinstance(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_UnusedObjects"), System.Collections.Generic.Queue_T, System.Collections.Generic.Queue_T, true){
					callexterndelegation(getinstance(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_Destroyer"), "System.Action_T.Invoke", item);
				};
			};
			callexterninstance(getinstance(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_UnusedObjects"), System.Collections.Generic.Queue_T, "Clear");
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		get_Count = deffunc(1)args(this){
			local(__method_ret_104_4_109_5);
			__method_ret_104_4_109_5 = getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_UnusedObjects"), System.Collections.Generic.Queue_T, "Count");
			return(__method_ret_104_4_109_5);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, "m_UnusedObjects", newexterncollection(System.Collections.Generic.Queue_T, "g_System_Collections_Generic_Queue_DataChangeCallBackInfo", typeargs(T), typekinds(TypeKind.TypeParameter), "ctor", 0, literalcollection("g_System_Collections_Generic_Queue_DataChangeCallBackInfo", typeargs(T), typekinds(TypeKind.TypeParameter))));
		}options[needfuncinfo(false)];
	};
	instance_fields {
		m_UnusedObjects = null;
		m_Creater = null;
		m_Destroyer = null;
		__ctor_called = false;
	};
	instance_props {
		Count = {
			get = instance_methods.get_Count;
		};
	};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Class, Accessibility.Public) {
		sealed(true);
	};
	method_info {
		Init__Func_1_T__Action_1_T(MethodKind.Ordinary, Accessibility.Public){
		};
		Init__Int32__Func_1_T__Action_1_T(MethodKind.Ordinary, Accessibility.Public){
		};
		Alloc(MethodKind.Ordinary, Accessibility.Public){
		};
		Recycle(MethodKind.Ordinary, Accessibility.Public){
		};
		Clear(MethodKind.Ordinary, Accessibility.Public){
		};
		get_Count(MethodKind.PropertyGet, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {
		Count(Accessibility.Public){
			readonly(true);
		};
	};
	event_info {};
	field_info {
		m_UnusedObjects(Accessibility.Private){
		};
		m_Creater(Accessibility.Private){
		};
		m_Destroyer(Accessibility.Private){
		};
	};
};



