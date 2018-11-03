require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");
require("foo_system_int32_system_int32");

class(bar) {
	static_methods {
		__new_object = function(...){
			return(newobject(bar, null, null, ...));
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
			bar.s_DateTime = newexternobject(System.DateTime, "System.DateTime", null, null);
		};
	};
	static_fields {
		s_DateTime = defaultvalue(System.DateTime, "System.DateTime", true);
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		test = function(this){
			local(a); a = newobject(foo_System_Int32_System_Int32, "ctor", null);
			callinstance(a, "parse", "123", "456");
			local(b); b = callinstance(getinstance(this, "m_DateTime"), "ToString");
			local(c); c = callinstance(getstatic(bar, "s_DateTime"), "ToString");
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
			this.m_DateTime = newexternobject(System.DateTime, "System.DateTime", null, null);
		};
	};
	instance_fields {
		m_DateTime = defaultvalue(System.DateTime, "System.DateTime", true);
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};
};



