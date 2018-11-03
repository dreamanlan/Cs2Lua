require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");

class(TopLevel.SecondLevel.FooBase) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.SecondLevel.FooBase, null, null, ...));
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
		m_Ttt = 6789;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};
};



