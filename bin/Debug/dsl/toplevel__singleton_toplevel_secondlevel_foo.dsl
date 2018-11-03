require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");

class(TopLevel.Singleton_TopLevel_SecondLevel_Foo) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ctor", null, ...));
		};
		get_instance = function(){
			if( execbinary("==", getstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance"), null, System.Object, System.Object, Class, Class) ){
				getstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance") = newtypeparamobject(TopLevel.SecondLevel.Foo);
			};
			return(getstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance"));
		};
		set_instance = function(value){
		};
		Delete = function(){
			getstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance") = null;
		};
		cctor = function(){
		};
	};
	static_fields {
		ms_instance = null;
	};
	static_props {
		instance = {
			get = static_methods.get_instance;
			set = static_methods.set_instance;
		};
	};
	static_events {};

	instance_methods {
		ctor = function(this){
			if( execbinary("!=", getstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance"), null, System.Object, System.Object, Class, Class) ){
								return(this);
			};
			getstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance") = typecast(typecast(this, System.Object, false), TopLevel.SecondLevel.Foo, false);
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



