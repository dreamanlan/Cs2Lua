require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(SettingInfoWrapper) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(SettingInfoWrapper, "g_SettingInfoWrapper", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(SettingInfoWrapper, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(SettingInfoWrapper.__cctor_called){
				return();
			}else{
				SettingInfoWrapper.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		OnInit = deffunc(0)args(this){
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		OnGet = deffunc(1)args(this){
			local(__method_ret_191_4_191_45);
			__method_ret_191_4_191_45 = -1;
			return(__method_ret_191_4_191_45);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		OnSet = deffunc(1)args(this, _value){
			local(__method_ret_192_4_192_55);
			__method_ret_192_4_192_55 = -1;
			return(__method_ret_192_4_192_55);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(_value, System.Int32, TypeKind.Struct, 0, true)];
		OnSave = deffunc(1)args(this){
			local(__method_ret_193_4_193_46);
			__method_ret_193_4_193_46 = -1;
			return(__method_ret_193_4_193_46);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		OnLoad = deffunc(1)args(this){
			local(__method_ret_194_4_194_46);
			__method_ret_194_4_194_46 = -1;
			return(__method_ret_194_4_194_46);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		OnCache = deffunc(1)args(this){
			local(__method_ret_195_4_195_47);
			__method_ret_195_4_195_47 = -1;
			return(__method_ret_195_4_195_47);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		OnRestore = deffunc(1)args(this){
			local(__method_ret_196_4_196_49);
			__method_ret_196_4_196_49 = -1;
			return(__method_ret_196_4_196_49);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, SettingInfoWrapper, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, SettingInfoWrapper, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, SettingInfoWrapper, "__ctor_called", true);
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
		OnInit(MethodKind.Ordinary, Accessibility.Public){
			virtual(true);
		};
		OnGet(MethodKind.Ordinary, Accessibility.Public){
			virtual(true);
		};
		OnSet(MethodKind.Ordinary, Accessibility.Public){
			virtual(true);
		};
		OnSave(MethodKind.Ordinary, Accessibility.Public){
			virtual(true);
		};
		OnLoad(MethodKind.Ordinary, Accessibility.Public){
			virtual(true);
		};
		OnCache(MethodKind.Ordinary, Accessibility.Public){
			virtual(true);
		};
		OnRestore(MethodKind.Ordinary, Accessibility.Public){
			virtual(true);
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



