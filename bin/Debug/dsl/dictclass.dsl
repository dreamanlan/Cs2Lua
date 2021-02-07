require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("abstractdictclass");

class(DictClass, AbstractDictClass) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DictClass, "g_DictClass", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(AbstractDictClass, "cctor");
			callstatic(DictClass, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DictClass.__cctor_called){
				return();
			}else{
				DictClass.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		AddImpl__Object = deffunc(0)args(this, val){
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(val, System.Object, TypeKind.Class, 0, true)];
		ctor = deffunc(0)args(this){
			buildbaseobj(this, DictClass, AbstractDictClass, "ctor", 0);
			callinstance(this, DictClass, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DictClass, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DictClass, "__ctor_called", true);
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
		sealed(true);
	};
	method_info {
		AddImpl__Object(MethodKind.Ordinary, Accessibility.Protected){
			override(true);
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



