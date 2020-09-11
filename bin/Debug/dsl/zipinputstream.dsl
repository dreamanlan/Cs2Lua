require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("zipoutputstream");
require("intlist");

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
			local(intList); intList = newlist(IntList, typeargs(), typekinds(), "ctor", literallist(typeargs(), typekinds()));
			local(a); a = newexternlist(System.Collections.Generic.List_T, typeargs(System.Int32), typekinds(TypeKind.Struct), literallist(typeargs(System.Int32), typekinds(TypeKind.Struct)), "System.Collections.Generic.List_T:ctor");
			callexterninstance(intList, "AddRange", a);
			local(b); b = callinstance(this, "Test2", 124, newexternlist(System.Collections.Generic.List_T, typeargs(System.Int32), typekinds(TypeKind.Struct), literallist(typeargs(System.Int32), typekinds(TypeKind.Struct)), "System.Collections.Generic.List_T:ctor"));
			return(this);
		},
		Test = deffunc(1)args(this, o, ...){
			local{args = params(System.Object, TypeKind.Class);};
			return(null);
		};
		Test2 = deffunc(1)args(this, v, enumer){
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
		Test2(MethodKind.Ordinary, Accessibility.Private){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



