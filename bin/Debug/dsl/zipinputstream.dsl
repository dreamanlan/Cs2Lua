require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");

class(ZipInputStream) {
	static_methods {
		__new_object = function(...){
			return(newobject(ZipInputStream, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = function(){
		};
	};
	static_fields {
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this, ms){
			return(this);
		},
	};
	instance_fields {
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};
};



