require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(LuaString) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(LuaString, "g_LuaString", typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		Format__String__Object = deffunc(1)args(str, __dsl_arg){
			local(__method_ret_6_4_9_5);
			__method_ret_6_4_9_5 = callexternstatic(System.String, "Format__String__Object", str, __dsl_arg);
			return(__method_ret_6_4_9_5);
		}options[needfuncinfo(false), rettype(System.String, TypeKind.Class), paramtype(str, System.String, TypeKind.Class), paramtype(__dsl_arg, System.Object, TypeKind.Class)];
		Format__String__Object__Object = deffunc(1)args(str, arg1, arg2){
			local(__method_ret_10_4_13_5);
			__method_ret_10_4_13_5 = callexternstatic(System.String, "Format__String__Object__Object", str, arg1, arg2);
			return(__method_ret_10_4_13_5);
		}options[needfuncinfo(false), rettype(System.String, TypeKind.Class), paramtype(str, System.String, TypeKind.Class), paramtype(arg1, System.Object, TypeKind.Class), paramtype(arg2, System.Object, TypeKind.Class)];
		Format__String__Object__Object__Object = deffunc(1)args(str, arg1, arg2, arg3){
			local(__method_ret_14_4_17_5);
			__method_ret_14_4_17_5 = callexternstatic(System.String, "Format__String__Object__Object__Object", str, arg1, arg2, arg3);
			return(__method_ret_14_4_17_5);
		}options[needfuncinfo(false), rettype(System.String, TypeKind.Class), paramtype(str, System.String, TypeKind.Class), paramtype(arg1, System.Object, TypeKind.Class), paramtype(arg2, System.Object, TypeKind.Class), paramtype(arg3, System.Object, TypeKind.Class)];
		cctor = deffunc(0)args(){
			callstatic(LuaString, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(LuaString.__cctor_called){
				return();
			}else{
				LuaString.__cctor_called = true;
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
			callinstance(this, LuaString, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, LuaString, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, LuaString, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		Format__String__Object(MethodKind.Ordinary, Accessibility.Public){
			static(true);
		};
		Format__String__Object__Object(MethodKind.Ordinary, Accessibility.Public){
			static(true);
		};
		Format__String__Object__Object__Object(MethodKind.Ordinary, Accessibility.Public){
			static(true);
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



