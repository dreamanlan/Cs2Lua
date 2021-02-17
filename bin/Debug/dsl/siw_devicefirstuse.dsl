require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("settinginfowrapper");

class(SIW_DeviceFirstUse, SettingInfoWrapper) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(SIW_DeviceFirstUse, "g_SIW_DeviceFirstUse", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(SettingInfoWrapper, "cctor");
			callstatic(SIW_DeviceFirstUse, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(SIW_DeviceFirstUse.__cctor_called){
				return();
			}else{
				SIW_DeviceFirstUse.__cctor_called = true;
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
		OnLoad = deffunc(1)args(this){
			local(__method_ret_204_4_207_5);
			__method_ret_204_4_207_5 = -1;
			return(__method_ret_204_4_207_5);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		OnSet = deffunc(1)args(this, _value){
			local(__method_ret_208_4_211_5);
			__method_ret_208_4_211_5 = callinstance(getbase(), SettingInfoWrapper, "OnSet", _value);
			return(__method_ret_208_4_211_5);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(_value, System.Int32, TypeKind.Struct, 0, true)];
		ctor = deffunc(0)args(this){
			buildbaseobj(this, SIW_DeviceFirstUse, SettingInfoWrapper, "ctor", 0);
			callinstance(this, SIW_DeviceFirstUse, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, SIW_DeviceFirstUse, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, SIW_DeviceFirstUse, "__ctor_called", true);
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
		sealed(true);
	};
	method_info {
		OnInit(MethodKind.Ordinary, Accessibility.Public){
			override(true);
		};
		OnLoad(MethodKind.Ordinary, Accessibility.Public){
			override(true);
		};
		OnSet(MethodKind.Ordinary, Accessibility.Public){
			override(true);
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



