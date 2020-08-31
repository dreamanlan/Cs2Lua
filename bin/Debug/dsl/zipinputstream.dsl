require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("zipoutputstream");

class(ZipInputStream) {
	static_methods {
		__new_object = deffunc(1)args(...){
			return(newobject(ZipInputStream, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = deffunc(0)args(){
			callstatic(ZipInputStream, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(ZipInputStream.__cctor_called){
				return;
			}else{
				ZipInputStream.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = deffunc(0)args(this, ms){
			callinstance(this, "__ctor");
			local(os); os = newobject(ZipOutputStream, typeargs(), typekinds(), "ctor", null, newexternobject(System.IO.MemoryStream, typeargs(), typekinds(), null, "System.IO.MemoryStream:ctor"));
			local(os2); os2 = typeas(objecttodsl(callinstance(this, "Test", os, os, os)), ZipOutputStream, TypeKind.Class);
			return(this);
		},
		Test = deffunc(1)args(this, o, ...){
			local{args = params(System.Object, TypeKind.Class);};
			return(null);
		};
		__ctor = deffunc(0)args(this){
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

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		Test(MethodKind.Ordinary, Accessibility.Private){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



