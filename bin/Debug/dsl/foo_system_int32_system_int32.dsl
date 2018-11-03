require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");

class(foo_System_Int32_System_Int32) {
	static_methods {
		__new_object = function(...){
			return(newobject(foo_System_Int32_System_Int32, null, null, ...));
		};
		cctor = function(){
		};
	};
	static_fields {
	};
	static_props {};
	static_events {};

	instance_methods {
		parse = function(this, a, b){
			local(t); t = typeof(System.Int32);
			local(k); k = typeof(System.Int32);
		};
		ctor = function(this){
		};
	};
	instance_fields {
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};
};



