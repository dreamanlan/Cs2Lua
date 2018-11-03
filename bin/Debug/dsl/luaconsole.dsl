require("cs2lua__utility");
require("cs2lua__attributes");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");

class(LuaConsole) {
	static_methods {
		__new_object = function(...){
			return(newobject(LuaConsole, null, null, ...));
		};
		Print = function(...){
			local{args = params(0);};
		};
		cctor = function(){
		};
	};
	static_fields {
		__attributes = LuaConsole__Attrs;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this){
		};
	};
	instance_fields {
		__attributes = LuaConsole__Attrs;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};
};



