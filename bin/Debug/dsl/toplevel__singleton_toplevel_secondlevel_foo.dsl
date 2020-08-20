require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(TopLevel.Singleton_TopLevel_SecondLevel_Foo) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.Singleton_TopLevel_SecondLevel_Foo, typeargs(T), typekinds(TypeKind.TypeParameter), "ctor", null, ...));
		};
		get_instance = function(){
			if( execbinary("==", getstatic(SymbolKind.Field, TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance"), null, System.Object, System.Object, TypeKind.Class, TypeKind.Class) ){
				setstatic(SymbolKind.Field, TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance", newtypeparamobject(TopLevel.SecondLevel.Foo));
			};
			return(getstatic(SymbolKind.Field, TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance"));
		};
		set_instance = function(value){
		};
		Delete = function(){
			setstatic(SymbolKind.Field, TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance", null);
		};
		cctor = function(){
			callstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "__cctor");
		};
		__cctor = function(){
			if(TopLevel.Singleton_TopLevel_SecondLevel_Foo.__cctor_called){
				return;
			}else{
				TopLevel.Singleton_TopLevel_SecondLevel_Foo.__cctor_called = true;
			};
		};
	};
	static_fields {
		ms_instance = null;
		__cctor_called = false;
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
			callinstance(this, "__ctor");
			if( execbinary("!=", getstatic(SymbolKind.Field, TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance"), null, System.Object, System.Object, TypeKind.Class, TypeKind.Class) ){
				callexternstatic(UnityEngine.Debug, "LogError", "UnityEngine.Debug:LogError__Object", "Cannot have two instances in singleton");
				return(this);
			};
			setstatic(SymbolKind.Field, TopLevel.Singleton_TopLevel_SecondLevel_Foo, "ms_instance", typecast(typecast(this, System.Object, TypeKind.Class), TopLevel.SecondLevel.Foo, TypeKind.TypeParameter));
			return(this);
		},
		__ctor = function(this){
			if(getinstance(SymbolKind.Field, this, "__ctor_called")){
				return;
			}else{
				setinstance(SymbolKind.Field, this, "__ctor_called", true);
			};
		};
	};
	instance_fields {
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		get_instance(MethodKind.PropertyGet, Accessibility.Public){
			static(true);
		};
		set_instance(MethodKind.PropertySet, Accessibility.Public){
			static(true);
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		Delete(MethodKind.Ordinary, Accessibility.Public){
			static(true);
		};
	};
	property_info {
		instance(Accessibility.Public){
			static(true);
		};
	};
	event_info {};
	field_info {
		ms_instance(Accessibility.Protected){
			static(true);
		};
	};
};



