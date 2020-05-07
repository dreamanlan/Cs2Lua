require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("toplevel__secondlevel__foo");
require("gameobject");

class(TopLevel.SecondLevel.FooExtension) {
	static_methods {
		Test3__TopLevel_SecondLevel_Foo = function(obj){
			if( execbinary(">", obj.m_Test, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				setinstance(obj, "m_Test2", 678);
			};
			local(f); f = newexternlist(System.Collections.Generic.List_T, typeargs(System.Collections.Generic.List_T), typekinds(TypeKind.Class), literallist(newexternlist(System.Collections.Generic.List_T, typeargs(System.Int32), typekinds(TypeKind.Struct), literallist(1, 2), "System.Collections.Generic.List_T:ctor"), newexternlist(System.Collections.Generic.List_T, typeargs(System.Int32), typekinds(TypeKind.Struct), literallist(2, 3), "System.Collections.Generic.List_T:ctor")), "System.Collections.Generic.List_T:ctor");
		};
		Test3__TopLevel_SecondLevel_Foo__System_Int32 = function(__cs_this, ix){
			callinstance(__cs_this, "Test123", 123, 456);
		};
		TestExtern = function(obj){
		};
		NormalMethod = function(){
			callstatic(LuaConsole, "Print", 1, 2, 3, 4, 5);
			local(f); f = newobject(TopLevel.SecondLevel.Foo, typeargs(), typekinds(), "ctor", null);
			local(ff); ff = newobject(TopLevel.SecondLevel.Foo, typeargs(), typekinds(), "ctor", null);
			local(f1); f1 = (function(){ local(__delegation_obj_590_28_590_34); __delegation_obj_590_28_590_34 = f; builddelegation("", __delegation_590_28_590_34, "TopLevel.SecondLevel.Foo:Test", __delegation_obj_590_28_590_34, Test, false, false); })();
			f1();
			local(f2); f2 = (function(){ local(__delegation_obj_593_28_593_35); __delegation_obj_593_28_593_35 = f; builddelegation("", __delegation_593_28_593_35, "TopLevel.SecondLevel.FooExtension:Test3", __delegation_obj_593_28_593_35, Test3, false, false); })();
			f2();
			callstatic(TopLevel.SecondLevel.FooExtension, "Test3__TopLevel_SecondLevel_Foo", f);
			local(r); r = invokeoperator(TopLevel.SecondLevel.Foo, TopLevel.SecondLevel.Foo, "op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo", f, ff);
			f = invokeoperator(TopLevel.SecondLevel.Foo, TopLevel.SecondLevel.Foo, "op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo", f, ff);
			local(rr); rr = invokeoperator(TopLevel.SecondLevel.Foo, TopLevel.SecondLevel.Foo, "op_Explicit", 123);
			local(rrr); rrr = typeas(f, TopLevel.SecondLevel.Foo, TypeKind.Class);
			local(obj); obj = ;
			callstatic(TopLevel.SecondLevel.FooExtension, "Test3__TopLevel_SecondLevel_Foo__System_Int32", f, 8);
			local(arr); arr = literalarray(System.Int32, 1, 2, 3, 4, 4);
			local(v); v = arr[3];
			local(dict); dict = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct), literaldictionary(1 => 2, 3 => 4), "System.Collections.Generic.Dictionary_TKey_TValue:ctor");
			local(v1); v1 = condaccess(dict, (function(){ return(getexterninstanceindexer(System.Collections.Generic.Dictionary_TKey_TValue, typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct), dict, null, System.Collections.Generic.Dictionary_TKey_TValue, "get_Item", 1, 1)); }));
			local(list); list = null;
			local(l); l = condaccess(list, (function(){ return(list.Count); }));
			local(arr2); arr2 = literalarray(System.Int32, 1, 2, 3, 4);
			local(v3); v3 = condaccess(arr2, (function(){ return(arr2[3]); }));
			local(a); a = 1;
			local(b); b = 2;
			local(c); c = 3;
			a = (function(){ b = (function(){ local(__unary_619_20_619_23); __unary_619_20_619_23 = c; c = execbinary("+", c, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct); return(__unary_619_20_619_23); })(); return(b); })();
		};
		cctor = function(){
			callstatic(TopLevel.SecondLevel.FooExtension, "__cctor");
		};
		__cctor = function(){
			if(TopLevel.SecondLevel.FooExtension.__cctor_called){
				return;
			}else{
				TopLevel.SecondLevel.FooExtension.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

};



