require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");
require("toplevel__secondlevel__foo");
require("luaconsole");

class(TopLevel.SecondLevel.FooExtension) {
	static_methods {
		Test3__TopLevel_SecondLevel_Foo = function(obj){
			if( execbinary(">", obj.m_Test, 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				setinstance(obj, "m_Test2", 678);
			};
			local(f); f = newexternlist(System.Collections.Generic.List_T, typeargs(System.Collections.Generic.List_T), typekinds(TypeKind.Class), "System.Collections.Generic.List_T", "ctor", literallist(newexternlist(System.Collections.Generic.List_T, typeargs(System.Int32), typekinds(TypeKind.Struct), "System.Collections.Generic.List_T", "ctor", literallist(1, 2)), newexternlist(System.Collections.Generic.List_T, typeargs(System.Int32), typekinds(TypeKind.Struct), "System.Collections.Generic.List_T", "ctor", literallist(2, 3))));
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
			local(f1); f1 = (function(){ local(__delegation_obj_567_28_567_34); __delegation_obj_567_28_567_34 = f; builddelegation("", __delegation_567_28_567_34, "TopLevel.SecondLevel.Foo:Test", __delegation_obj_567_28_567_34, Test, false, false); })();
			f1();
			local(f2); f2 = (function(){ local(__delegation_obj_570_28_570_35); __delegation_obj_570_28_570_35 = f; builddelegation("", __delegation_570_28_570_35, "TopLevel.SecondLevel.FooExtension:Test3", __delegation_obj_570_28_570_35, Test3, false, false); })();
			f2();
			callstatic(TopLevel.SecondLevel.FooExtension, "Test3__TopLevel_SecondLevel_Foo", getstatic(TopLevel.SecondLevel.FooExtension, "Test3__TopLevel_SecondLevel_Foo"), f);
			local(r); r = invokeoperator(TopLevel.SecondLevel.Foo, "op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo", f, ff);
			f = invokeoperator(TopLevel.SecondLevel.Foo, "op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo", f, ff);
			local(rr); rr = invokeoperator(TopLevel.SecondLevel.Foo, "op_Explicit", 123);
			local(rrr); rrr = typeas(f, TopLevel.SecondLevel.Foo, TypeKind.Class);
			local(obj); obj = newexternobject(UnityEngine.GameObject, typeargs(), typekinds(), "UnityEngine.GameObject", "ctor", null, "test test test");
			callstatic(TopLevel.SecondLevel.FooExtension, "Test3__TopLevel_SecondLevel_Foo__System_Int32", f, 8);
			local(arr); arr = buildarray(System.Int32, 1, 2, 3, 4, 4);
			local(v); v = arr[3];
			local(dict); dict = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, typeargs(System.Int32, System.Int32), typekinds(TypeKind.Struct, TypeKind.Struct), "System.Collections.Generic.Dictionary_TKey_TValue", "ctor", literaldictionary(1 => 2, 3 => 4));
			local(v1); v1 = condaccess(dict, (function(){ return(getexterninstanceindexer(dict, null, "get_Item", 1)); }));
			local(list); list = null;
			local(l); l = condaccess(list, (function(){ return(list.Count); }));
			local(arr2); arr2 = buildarray(System.Int32, 1, 2, 3, 4);
			local(v3); v3 = condaccess(arr2, (function(){ return(arr2[3]); }));
			local(a); a = 1;
			local(b); b = 2;
			local(c); c = 3;
			a = (function(){ b = c; return(b); })();
			c = execbinary("+", c, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
		};
		cctor = function(){
		};
	};
	static_fields {
	};
	static_props {};
	static_events {};

};



