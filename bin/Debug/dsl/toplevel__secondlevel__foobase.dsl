require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(TopLevel.SecondLevel.FooBase) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.SecondLevel.FooBase, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = function(){
			callstatic(TopLevel.SecondLevel.FooBase, "__cctor");
		};
		__cctor = function(){
			if(TopLevel.SecondLevel.FooBase.__cctor_called){
				return;
			}else{
				TopLevel.SecondLevel.FooBase.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this){
			callinstance(this, "__ctor");
		};
		__ctor = function(this){
			if(getinstance(this, "__ctor_called")){
				return;
			}else{
				setinstance(this, "__ctor_called", true);
			};
		};
	};
	instance_fields {
		m_Ttt = 6789;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {
		m_Ttt(Accessibility.Internal){
		};
	};
};



