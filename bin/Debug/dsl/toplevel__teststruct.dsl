require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");

struct(TopLevel.TestStruct) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.TestStruct, null, null, ...));
		};
		cctor = function(){
		};
	};
	static_fields {
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this){
		};
	};
	instance_fields {
		A = 0;
		B = 0;
		C = 0;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};
};



