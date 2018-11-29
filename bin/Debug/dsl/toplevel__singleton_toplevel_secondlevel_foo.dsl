require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");

class(TopLevel.Singleton_TopLevel_SecondLevel_Foo) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.Singleton_TopLevel_SecondLevel_Foo, typeargs(TopLevel.Singleton_T.T), typekinds(TypeKind.TypeParameter), "ctor", null, ...));
		};
		get_instance = function(){
			if( execbinary("==", getstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance"), null, System.Object, System.Object, TypeKind.Class, TypeKind.Class) ){
				setstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance", newtypeparamobject(TopLevel.SecondLevel.Foo));
			};
			return(getstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance"));
		};
		set_instance = function(value){
		};
		Delete = function(){
			setstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance", null);
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
			if( execbinary("!=", getstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance"), null, System.Object, System.Object, TypeKind.Class, TypeKind.Class) ){
				callstatic(UnityEngine.Debug, "LogError", "Cannot have two instances in singleton");
				return(this);
			};
			setstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance", typecast(typecast(this, System.Object, TypeKind.Class), TopLevel.SecondLevel.Foo, TypeKind.TypeParameter));
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



