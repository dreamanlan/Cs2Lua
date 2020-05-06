require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("foo_system_int32_system_int32");

class(bar) {
	static_methods {
		__new_object = function(...){
			return(newobject(bar, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = function(){
			callstatic(bar, "__cctor");
		};
		__cctor = function(){
			if(bar.__cctor_called){
				return;
			}else{
				bar.__cctor_called = true;
			};
			bar.s_DateTime = newexternobject(System.DateTime, typeargs(), typekinds(), null);
		};
	};
	static_fields {
		s_DateTime = null;
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		test = function(this){
			local(a); a = newobject(foo_System_Int32_System_Int32, typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct), "ctor", null);
			callinstance(a, "parse", "123", "456");
			local(b); b = callinstance(getinstance(this, "m_DateTime"), "ToString", "System.DateTime:ToString");
			local(c); c = callinstance(getstatic(bar, "s_DateTime"), "ToString", "System.DateTime:ToString");
			local(dt);
			local(dt2);
		};
		ctor = function(this){
			callinstance(this, "__ctor");
		};
		__ctor = function(this){
			if(getinstance(this, "__ctor_called")){
				return;
			}else{
				setinstance(this, "__ctor_called", true);
			};
			this.m_DateTime = newexternobject(System.DateTime, typeargs(), typekinds(), null);
		};
	};
	instance_fields {
		m_DateTime = null;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		test(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {
		m_DateTime(Accessibility.Private){
		};
		s_DateTime(Accessibility.Private){
			static(true);
		};
	};
};



