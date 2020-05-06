require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("toplevel__secondlevel__foo");

class(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1) {
	static_methods {
		__new_object = function(...){
			return((function(...){ local(newobj, v, v2); multiassign(newobj, v, v2) = newobject(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1, typeargs(T), typekinds(TypeKind.TypeParameter), "ctor", null, ...); return(newobj); })(...));
		};
		cctor = function(){
			callstatic(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1, "__cctor");
			setstatic(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1, "s_Test", 9876);
		},
		__cctor = function(){
			if(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.__cctor_called){
				return;
			}else{
				TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.__cctor_called = true;
			};
			TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.s_Inst = newtypeparamobject(TopLevel.SecondLevel.Foo.Test1);
		};
	};
	static_fields {
		TTT = 789;
		s_Test = 2147483647;
		s_Float = wrapconst(System.Single, "PositiveInfinity");
		s_Inst = null;
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this, ref(v), out(v2)){
			callinstance(this, "__ctor");
			local(obj); obj = newtypeparamobject(TopLevel.SecondLevel.Foo.Test1);
			setinstance(this, "m_Test", execbinary("+", v, 4, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
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
			this.m_Test2 = execbinary("+", getstatic(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1, "TTT"), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			this.m_Inst = newtypeparamobject(TopLevel.SecondLevel.Foo.Test1);
		};
	};
	instance_fields {
		m_Test = 123;
		m_Test2 = 0;
		m_Inst = null;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		Test(MethodKind.Ordinary, Accessibility.Public){
			generic(true);
		};
		cctor(MethodKind.StaticConstructor, Accessibility.Private){
			static(true);
		};
	};
	property_info {};
	event_info {};
	field_info {
		TTT(Accessibility.Public){
			static(true);
		};
		m_Test(Accessibility.Private){
		};
		m_Test2(Accessibility.Private){
		};
		m_Inst(Accessibility.Private){
		};
		s_Test(Accessibility.Private){
			static(true);
		};
		s_Float(Accessibility.Private){
			static(true);
		};
		s_Inst(Accessibility.Private){
			static(true);
		};
	};
};



