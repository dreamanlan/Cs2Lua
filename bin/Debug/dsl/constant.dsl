require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(Constant) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(Constant, "g_Constant", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(Constant, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(Constant.__cctor_called){
				return();
			}else{
				Constant.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		One = "";
		Two = "";
		Three = "";
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = deffunc(0)args(this){
			callinstance(this, Constant, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, Constant, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, Constant, "__ctor_called", true);
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
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {
		One(Accessibility.Internal){
			static(true);
			const(true);
		};
		Two(Accessibility.Internal){
			static(true);
			const(true);
		};
		Three(Accessibility.Internal){
			static(true);
			const(true);
		};
	};
};



