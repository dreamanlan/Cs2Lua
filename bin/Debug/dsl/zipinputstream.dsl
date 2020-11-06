require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("zipoutputstream");
require("intlist");
require("testextension");

class(ZipInputStream) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(ZipInputStream, typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
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
			callinstance(this, ZipInputStream, "__ctor");
			local(os); os = newobject(ZipOutputStream, typeargs(), typekinds(), "ctor", null, newexternobject(System.IO.MemoryStream, typeargs(), typekinds(), null, dslstrtocsstr("System.IO.MemoryStream:ctor__Void")));
			local(os2); os2 = typeas(objecttodsl(callinstance(this, ZipInputStream, "Test", dsltoobject(SymbolKind.Method, false, "ZipInputStream:Test", os), dsltoobject(SymbolKind.Method, false, "ZipInputStream:Test", os), dsltoobject(SymbolKind.Method, false, "ZipInputStream:Test", os))), ZipOutputStream, TypeKind.Class);
			local(intList); intList = newlist(IntList, typeargs(), typekinds(), "ctor", literallist(typeargs(), typekinds()));
			local(a); a = newexternlist(System.Collections.Generic.List_T, typeargs(System.Int32), typekinds(TypeKind.Struct), literallist(typeargs(System.Int32), typekinds(TypeKind.Struct)), dslstrtocsstr("System.Collections.Generic.List_T:ctor__Void"));
			local(aa); aa = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, typeargs(System.String, UnityEngine.Component), typekinds(TypeKind.Class, TypeKind.Class), literaldictionary(typeargs(System.String, UnityEngine.Component), typekinds(TypeKind.Class, TypeKind.Class)), dslstrtocsstr("System.Collections.Generic.Dictionary_TKey_TValue:ctor__Void"));
			callextension(TestExtension, "Test", intList, UnityEngine.ParticleSystem, null);
			callexterninstance(intList, System.Collections.Generic.List_T, "AddRange", a);
			local(gobj); gobj = null;
			local(r); r = callexternstatic(UnityEngine.Object, "Instantiate", dslstrtocsstr("UnityEngine.Object:Instantiate__Object__Object"), gobj);
			local(b); b = callinstance(this, ZipInputStream, "Test2", 124, newexternlist(System.Collections.Generic.List_T, typeargs(System.Int32), typekinds(TypeKind.Struct), literallist(typeargs(System.Int32), typekinds(TypeKind.Struct)), dslstrtocsstr("System.Collections.Generic.List_T:ctor__Void")));
			local(o); o = dsltoobject(SymbolKind.Local, false, "o", literalarray(System.Int32, TypeKind.Struct, 1, 2));
			local(arr); arr = typeas(objecttodsl(o), System.Array, TypeKind.Array);
			local(aa); aa = "123";
			local(bb); bb = "456";
			local(da); da = 1;
			local(db); db = 2;
			local(r); r = execbinary("==", aa, bb, System.Object, System.Object, TypeKind.Class, TypeKind.Class);
			r = execbinary("==", da, db, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct);
			local(ca); ca = getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "white");
			local(cb); cb = getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "black");
			r = invokeexternoperator(System.Boolean, UnityEngine.Color, "op_Equality", ca, cb);
			return(this);
		},
		Test = deffunc(1)args(this, o, ...){
			local(__method_ret_59_4_62_5);
			local{args = params(System.Object, TypeKind.Class);};
			__method_ret_59_4_62_5 = null;
			return(__method_ret_59_4_62_5);
		};
		Test2 = deffunc(1)args(this, v, enumer){
			local(__method_ret_63_4_66_5);
			__method_ret_63_4_66_5 = null;
			return(__method_ret_63_4_66_5);
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, ZipInputStream, "__ctor_called")){
				return;
			}else{
				setinstance(SymbolKind.Field, this, ZipInputStream, "__ctor_called", true);
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



