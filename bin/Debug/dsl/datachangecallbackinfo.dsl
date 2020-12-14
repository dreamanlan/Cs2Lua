require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(DataChangeCallBackInfo) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataChangeCallBackInfo, typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataChangeCallBackInfo, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataChangeCallBackInfo.__cctor_called){
				return();
			}else{
				DataChangeCallBackInfo.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = deffunc(0)args(this){
			callinstance(this, DataChangeCallBackInfo, "__ctor");
			callinstance(this, DataChangeCallBackInfo, "reset");
			return(this);
		}options[needfuncinfo(false), rettype(System.Void, TypeKind.Unknown)],
		reset = deffunc(0)args(this){
			setinstance(SymbolKind.Field, this, DataChangeCallBackInfo, "m_ActorId", 0);
		}options[needfuncinfo(false), rettype(System.Void, TypeKind.Unknown)];
		Downcast = deffunc(1)args(this){
			local(__method_ret_95_4_98_5);
			__method_ret_95_4_98_5 = this;
			return(__method_ret_95_4_98_5);
		}options[needfuncinfo(false), rettype(DataChangeCallBackInfo, TypeKind.Class)];
		InitPool = deffunc(0)args(this, pool){
		}options[needfuncinfo(false), rettype(System.Void, TypeKind.Unknown), paramtype(pool, Cs2LuaObjectPoolEx_DataChangeCallBackInfo, TypeKind.Class)];
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataChangeCallBackInfo, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataChangeCallBackInfo, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		m_ActorId = 0;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"ICs2LuaPoolAllocatedObjectEx_DataChangeCallBackInfo";
	};

	class_info(TypeKind.Class, Accessibility.Internal) {
		sealed(true);
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		reset(MethodKind.Ordinary, Accessibility.Public){
		};
		Downcast(MethodKind.Ordinary, Accessibility.Public){
		};
		InitPool(MethodKind.Ordinary, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {
		m_ActorId(Accessibility.Public){
		};
	};
};



