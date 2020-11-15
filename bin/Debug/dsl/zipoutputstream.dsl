require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(ZipOutputStream) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(ZipOutputStream, typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		get_Instance = deffunc(1)args(){
			local(__method_ret_108_4_111_5);
			__method_ret_108_4_111_5 = getstatic(SymbolKind.Field, ZipOutputStream, "s_Instance");
			return(__method_ret_108_4_111_5);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(ZipOutputStream, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(ZipOutputStream.__cctor_called){
				return();
			}else{
				ZipOutputStream.__cctor_called = true;
			};
			setstatic(SymbolKind.Field, ZipOutputStream, "s_Instance", newobject(ZipOutputStream, typeargs(), typekinds(), "ctor", null));
		}options[needfuncinfo(false)];
	};
	static_fields {
		s_Instance = null;
		__cctor_called = false;
	};
	static_props {
		Instance = {
			get = static_methods.get_Instance;
		};
	};
	static_events {};

	instance_methods {
		ctor__System_IO_MemoryStream = deffunc(0)args(this, ms){
			callinstance(this, ZipOutputStream, "__ctor");
			setinstance(SymbolKind.Field, getstatic(SymbolKind.Property, ZipOutputStream, "Instance"), ZipOutputStream, "V", 1);
			callinstance(getstatic(SymbolKind.Property, ZipOutputStream, "Instance"), ZipOutputStream, "Test");
			return(this);
		}options[needfuncinfo(false)],
		Test = deffunc(0)args(this){
			local(dict); dict = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct), literaldictionary(typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct)), dslstrtocsstr("System.Collections.Generic.Dictionary_TKey_TValue:ctor__Void"));
			callexterninstance(dict, System.Collections.Generic.Dictionary_TKey_TValue, "Add", 1, 1);
			callexterninstance(dict, System.Collections.Generic.Dictionary_TKey_TValue, "Add", 2, 2);
			setexterninstanceindexer(System.Collections.Generic.Dictionary_TKey_TValue, typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct), dict, System.Collections.Generic.Dictionary_TKey_TValue, "set_Item", 2, true, 1, execbinary("+", getexterninstanceindexer(System.Collections.Generic.Dictionary_TKey_TValue, typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct), dict, System.Collections.Generic.Dictionary_TKey_TValue, "get_Item", 1, 1), getexterninstanceindexer(System.Collections.Generic.Dictionary_TKey_TValue, typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct), dict, System.Collections.Generic.Dictionary_TKey_TValue, "get_Item", 1, 2), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
		}options[needfuncinfo(false)];
		ctor = deffunc(0)args(this){
			callinstance(this, ZipOutputStream, "__ctor");
			return(this);
		}options[needfuncinfo(false)],
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, ZipOutputStream, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, ZipOutputStream, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		V = 0;
		m_I = 1;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		ctor__System_IO_MemoryStream(MethodKind.Constructor, Accessibility.Public){
		};
		get_V(MethodKind.PropertyGet, Accessibility.Public){
		};
		set_V(MethodKind.PropertySet, Accessibility.Public){
		};
		Test(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		get_Instance(MethodKind.PropertyGet, Accessibility.Public){
			static(true);
		};
		cctor(MethodKind.StaticConstructor, Accessibility.Private){
			static(true);
		};
	};
	property_info {
		V(Accessibility.Public){
		};
		Instance(Accessibility.Public){
			static(true);
			readonly(true);
		};
	};
	event_info {};
	field_info {
		m_I(Accessibility.Private){
		};
		s_Instance(Accessibility.Private){
			static(true);
		};
	};
};




class(ZipOutputStream.EmbedClass) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(ZipOutputStream.EmbedClass, typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(ZipOutputStream.EmbedClass, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(ZipOutputStream.EmbedClass.__cctor_called){
				return();
			}else{
				ZipOutputStream.EmbedClass.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		Test = deffunc(0)args(this){
			callinstance(getstatic(SymbolKind.Property, ZipOutputStream, "Instance"), ZipOutputStream, "Test");
		}options[needfuncinfo(false)];
		ctor = deffunc(0)args(this){
			callinstance(this, ZipOutputStream.EmbedClass, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, ZipOutputStream.EmbedClass, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, ZipOutputStream.EmbedClass, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Class, Accessibility.Private) {
	};
	method_info {
		Test(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};



