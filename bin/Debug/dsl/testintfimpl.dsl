require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(TestIntfImpl) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(TestIntfImpl, typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(TestIntfImpl, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(TestIntfImpl.__cctor_called){
				return();
			}else{
				TestIntfImpl.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		get_prop = deffunc(1)args(this){
			local(__method_ret_25_4_25_33);
			__method_ret_25_4_25_33 = getinstance(SymbolKind.Field, this, TestIntfImpl, "prop"); return(__method_ret_25_4_25_33);
		}options[needfuncinfo(false)];
		set_prop = deffunc(0)args(this, value){
			setinstance(SymbolKind.Field, this, TestIntfImpl, "prop", value);
		}options[needfuncinfo(false)];
		ctor = deffunc(0)args(this){
			callinstance(this, TestIntfImpl, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, TestIntfImpl, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, TestIntfImpl, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		prop = 0;
		__ctor_called = false;
	};
	instance_props {
		prop = {
			get = instance_methods.get_prop;
			set = instance_methods.set_prop;
		};
	};
	instance_events {};

	interfaces {
		"ITestIntf";
	};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		get_prop(MethodKind.PropertyGet, Accessibility.Public){
		};
		set_prop(MethodKind.PropertySet, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {
		prop(Accessibility.Public){
		};
	};
	event_info {};
	field_info {
	};
};



