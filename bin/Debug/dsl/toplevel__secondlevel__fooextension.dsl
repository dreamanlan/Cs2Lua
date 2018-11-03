require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");
require("toplevel__secondlevel__foo");
require("gameobject");
require("luaconsole");

class(TopLevel.SecondLevel.FooExtension) {
	static_methods {
		Test3__TopLevel_SecondLevel_Foo = function(obj){
			if( execbinary(">", obj.m_Test, 0, System.Int32, System.Int32, Struct, Struct) ){
				obj.m_Test2 = 678;
			};
			local(f); f = newexternlist(System.Collections.Generic.List_T, "System.Collections.Generic.List_T", "ctor", buildlist(newexternlist(System.Collections.Generic.List_T, "System.Collections.Generic.List_T", "ctor", buildlist(1, 2)), newexternlist(System.Collections.Generic.List_T, "System.Collections.Generic.List_T", "ctor", buildlist(2, 3))));
		};
		Test3__TopLevel_SecondLevel_Foo__System_Int32 = function(__compiler_cs_this, ix){
			callinstance(__compiler_cs_this, "Test123", 123, 456);
		};
		TestExtern = function(obj){
		};
		NormalMethod = function(){
			callstatic(LuaConsole, "Print", 1, 2, 3, 4, 5);
			local(f); f = newobject(TopLevel.SecondLevel.Foo, "ctor", null);
			local(ff); ff = newobject(TopLevel.SecondLevel.Foo, "ctor", null);
			local(f1); f1 = delegationwrap((function(){ local(__compiler_delegation_obj_567_28_567_34); __compiler_delegation_obj_567_28_567_34 = f; builddelegation("", __compiler_delegation_567_28_567_34, "TopLevel.SecondLevel.Foo:Test", __compiler_delegation_obj_567_28_567_34, Test, false, false); })());
			f1();
			local(f2); f2 = delegationwrap((function(){ local(__compiler_delegation_obj_570_28_570_35); __compiler_delegation_obj_570_28_570_35 = f; builddelegation("", __compiler_delegation_570_28_570_35, "TopLevel.SecondLevel.FooExtension:Test3", __compiler_delegation_obj_570_28_570_35, Test3, false, false); })());
			f2();
			callstatic(TopLevel.SecondLevel.FooExtension, "Test3__TopLevel_SecondLevel_Foo", getstatic(TopLevel.SecondLevel.FooExtension, "Test3__TopLevel_SecondLevel_Foo"), f);
			local(r); r = invokeoperator(TopLevel.SecondLevel.Foo, "op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo", f, ff);
			f = invokeoperator(TopLevel.SecondLevel.Foo, "op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo", f, ff);
			local(rr); rr = invokeoperator(TopLevel.SecondLevel.Foo, "op_Explicit", 123);
			local(rrr); rrr = typeas(f, TopLevel.SecondLevel.Foo, false);
			local(obj); obj = ;
			callstatic(TopLevel.SecondLevel.FooExtension, "Test3__TopLevel_SecondLevel_Foo__System_Int32", f, 8);
			local(arr); arr = buildarray(1, 2, 3, 4, 4);
			local(v); v = arr[3];
			local(dict); dict = newexterndictionary(System.Collections.Generic.Dictionary_TKey_TValue, "System.Collections.Generic.Dictionary_TKey_TValue", "ctor", builddictionary(1 => 2, 3 => 4));
			local(v1); v1 = condaccess(dict, (function(){ return(getexterninstanceindexer(dict, null, "get_Item", 1)); }));
			local(list); list = null;
			local(l); l = condaccess(list, (function(){ return(list.Count); }));
			local(arr2); arr2 = buildarray(1, 2, 3, 4);
			local(v3); v3 = condaccess(arr2, (function(){ return(arr2[3]); }));
			local(a); a = 1;
			local(b); b = 2;
			local(c); c = 3;
			a = (function(){ b = c; return(b); })();
			c = execbinary("+", c, 1, System.Int32, System.Int32, Struct, Struct);
		};
		cctor = function(){
		};
	};
	static_fields {
	};
	static_props {};
	static_events {};

};



