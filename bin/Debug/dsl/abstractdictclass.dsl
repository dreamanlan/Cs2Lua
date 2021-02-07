require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(AbstractDictClass) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(AbstractDictClass, "g_AbstractDictClass", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(AbstractDictClass, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(AbstractDictClass.__cctor_called){
				return();
			}else{
				AbstractDictClass.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		Add = deffunc(0)args(this, val){
			callinstance(this, AbstractDictClass, "AddImpl", val);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(val, System.Object, TypeKind.Class, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, AbstractDictClass, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, AbstractDictClass, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, AbstractDictClass, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"IDict";
	};

	class_info(TypeKind.Class, Accessibility.Public) {
		abstract(true);
	};
	method_info {
		Add(MethodKind.Ordinary, Accessibility.Public){
		};
		AddImpl(MethodKind.Ordinary, Accessibility.Protected){
			abstract(true);
		};
		ctor(MethodKind.Constructor, Accessibility.Protected){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



