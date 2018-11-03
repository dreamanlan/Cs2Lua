require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");
require("toplevel__secondlevel__genericclass_toplevel_secondlevel_foo_test1");
require("toplevel__secondlevel__foo");
require("toplevel__secondlevel__fooextension");

class(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2, "ctor", null, ...));
		};
		cctor = function(){
		};
	};
	static_fields {
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this, v, vv){
			getinstance(this, "m_T") = v;
			getinstance(this, "m_TT") = vv;
			local(obj1); obj1 = newtypeparamobject(TopLevel.SecondLevel.Foo.Test1);
			local(obj2); obj2 = newtypeparamobject(TopLevel.SecondLevel.Foo.Test2);
			return(this);
		},
		Test = function(this, G, g){
			local(v); v = typeas(g, TopLevel.SecondLevel.Foo.Test1, false);
			local(v2); v2 = typecast(typecast(g, System.Object, false), TopLevel.SecondLevel.Foo.Test1, false);
			local(f); f = newobject(TopLevel.SecondLevel.Foo, "ctor", null);
			callstatic(TopLevel.SecondLevel.FooExtension, "Test3__TopLevel_SecondLevel_Foo", f);
		};
		Test2 = function(this, GG, t, tt){
			local(t1); t1 = typeof(GG);
			local(t2); t2 = typeof(TopLevel.SecondLevel.Foo.Test1);
			local(t3); t3 = typeof(TopLevel.SecondLevel.Foo.Test2);
			local(t4); t4 = typeof(System.Int32);
			local(v); v = typecast(typecast(t, System.Object, false), TopLevel.SecondLevel.Foo.Test2, false);
		};
		__ctor = function(this){
			if(getinstance(this, "__ctor_called")){
				return;
			}else{
				setinstance(this, "__ctor_called", true);
			};
		};
	};
	instance_fields {
		m_T = null;
		m_TT = null;
		m_TypeT = typeof(TopLevel.SecondLevel.Foo.Test1);
		m_TypeTT = typeof(TopLevel.SecondLevel.Foo.Test2);
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};
};



