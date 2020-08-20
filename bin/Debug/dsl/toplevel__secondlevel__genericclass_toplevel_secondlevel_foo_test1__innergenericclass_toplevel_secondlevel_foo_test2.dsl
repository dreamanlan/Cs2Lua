require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("toplevel__secondlevel__genericclass_toplevel_secondlevel_foo_test1");
require("toplevel__secondlevel__foo");
require("toplevel__secondlevel__fooextension");

class(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2, typeargs(TT), typekinds(TypeKind.TypeParameter), "ctor", null, ...));
		};
		cctor = function(){
			callstatic(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2, "__cctor");
		};
		__cctor = function(){
			if(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2.__cctor_called){
				return;
			}else{
				TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this, v, vv){
			callinstance(this, "__ctor");
			setinstance(SymbolKind.Field, this, "m_T", v);
			setinstance(SymbolKind.Field, this, "m_TT", vv);
			local(obj1); obj1 = newtypeparamobject(TopLevel.SecondLevel.Foo.Test1);
			local(obj2); obj2 = newtypeparamobject(TopLevel.SecondLevel.Foo.Test2);
			return(this);
		},
		Test = function(this, G, g){
			local(v); v = typeas(g, TopLevel.SecondLevel.Foo.Test1, TypeKind.TypeParameter);
			local(v2); v2 = typecast(typecast(g, System.Object, TypeKind.Class), TopLevel.SecondLevel.Foo.Test1, TypeKind.TypeParameter);
			local(f); f = newobject(TopLevel.SecondLevel.Foo, typeargs(), typekinds(), "ctor", null);
			callextension(TopLevel.SecondLevel.FooExtension, "Test3__TopLevel_SecondLevel_Foo", f);
			comment("++f;");
			comment("f++;");
			comment("--f;");
			comment("f--;");
			comment("int i = (++f).m_Test + (f++).m_Test + (--f).m_Test + (f--).m_Test;");
		};
		Test2 = function(this, GG, t, tt){
			local(t1); t1 = typeof(GG);
			local(t2); t2 = typeof(TopLevel.SecondLevel.Foo.Test1);
			local(t3); t3 = typeof(TopLevel.SecondLevel.Foo.Test2);
			local(t4); t4 = typeof(System.Int32);
			local(v); v = typecast(typecast(t, System.Object, TypeKind.Class), TopLevel.SecondLevel.Foo.Test2, TypeKind.TypeParameter);
		};
		__ctor = function(this){
			if(getinstance(SymbolKind.Field, this, "__ctor_called")){
				return;
			}else{
				setinstance(SymbolKind.Field, this, "__ctor_called", true);
			};
			this.m_TypeT = typeof(TopLevel.SecondLevel.Foo.Test1);
			this.m_TypeTT = typeof(TopLevel.SecondLevel.Foo.Test2);
		};
	};
	instance_fields {
		m_T = null;
		m_TT = null;
		m_TypeT = null;
		m_TypeTT = null;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		Test(MethodKind.Ordinary, Accessibility.Public){
			generic(true);
		};
		Test2(MethodKind.Ordinary, Accessibility.Public){
			generic(true);
		};
	};
	property_info {};
	event_info {};
	field_info {
		m_T(Accessibility.Private){
		};
		m_TT(Accessibility.Private){
		};
		m_TypeT(Accessibility.Private){
		};
		m_TypeTT(Accessibility.Private){
		};
	};
};



