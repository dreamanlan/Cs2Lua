require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");
require("toplevel__secondlevel__foo");

class(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1) {
	static_methods {
		__new_object = function(...){
			return((function(...){ local(newobj, v, v2); multiassign(newobj, v, v2) = newobject(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1, "ctor", null, ...); return(newobj); })(...));
		};
		cctor = function(){
			getstatic(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1, "s_Test") = 9876;
		},
		__cctor = function(){
			if(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.__cctor_called){
				return;
			}else{
				TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.__cctor_called = true;
			};
		};
	};
	static_fields {
		TTT = 789;
		s_Test = 2147483647;
		s_Float = wrapconst(System.Single, "PositiveInfinity");
		s_Inst = newtypeparamobject(TopLevel.SecondLevel.Foo.Test1);
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this, ref(v), out(v2)){
			local(obj); obj = newtypeparamobject(TopLevel.SecondLevel.Foo.Test1);
			getinstance(this, "m_Test") = execbinary("+", v, 4, System.Int32, System.Int32, Struct, Struct);
			v2 = 123;
			return(this, v, v2);
		},
		Test = function(this, G){
			local(t); t = typeof(G);
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
		m_Test = 123;
		m_Test2 = execbinary("+", getstatic(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1, "TTT"), 1, System.Int32, System.Int32, Struct, Struct);
		m_Inst = newtypeparamobject(TopLevel.SecondLevel.Foo.Test1);
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};
};



