require("cs2dsl__lualib");
require("cs2dsl__attributes");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("toplevel__secondlevel__foobase");
require("toplevel__teststruct");
require("toplevel__singleton_toplevel_secondlevel_foo");
require("toplevel__secondlevel__genericclass_toplevel_secondlevel_foo_test1__innergenericclass_toplevel_secondlevel_foo_test2");
require("toplevel__runnable");

class(TopLevel.SecondLevel.Foo, TopLevel.SecondLevel.FooBase) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.SecondLevel.Foo, typeargs(), typekinds(), "ctor", null, ...));
		};
		add_StaticEventBridge = function(value){
		};
		remove_StaticEventBridge = function(value){
		};
		op_Increment = function(self){
			setinstance(self, "m_Test", execbinary("+", self.m_Test, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			return(self);
			return(null);
		};
		op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo = function(self, other){
			setinstance(self, "m_Test", execbinary("+", self.m_Test, other.m_Test, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			return(self);
			return(null);
		};
		op_Addition__TopLevel_SecondLevel_Foo__System_Int32 = function(self, val){
			setinstance(self, "m_Test", execbinary("+", self.m_Test, val, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			return(self);
			return(null);
		};
		op_Explicit = function(a){
			local(f); f = newobject(TopLevel.SecondLevel.Foo, typeargs(), typekinds(), "ctor", null);
			setinstance(f, "m_Test", a);
			setinstance(f, "Val", newobject(TopLevel.TestStruct, typeargs(), typekinds(), "ctor", null));
			local(ts); ts = getinstance(f, "Val");
			ts = wrapstruct(ts);
			setinstanceindexer(f, null, TopLevel.SecondLevel.Foo, "set_Item", 2, true, ts, ts, 123);
			local(r); r = getinstanceindexer(f, null, TopLevel.SecondLevel.Foo, "get_Item", 1, ts, ts);
			local(result); result = callinstance(getstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "instance"), "Test123", 1, 2);
			setstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "instance", null);
			return(f);
			return(null);
		};
		cctor = function(){
			callstatic(TopLevel.SecondLevel.FooBase, "cctor");
			callstatic(TopLevel.SecondLevel.Foo, "__cctor");
		};
		__cctor = function(){
			if(TopLevel.SecondLevel.Foo.__cctor_called){
				return;
			}else{
				TopLevel.SecondLevel.Foo.__cctor_called = true;
			};
		};
	};
	static_fields {
		__attributes = TopLevel__SecondLevel__Foo__Attrs;
		__cctor_called = false;
	};
	static_props {};
	static_events {
		StaticEventBridge = {
			add = static_methods.add_StaticEventBridge,
			remove = static_methods.remove_StaticEventBridge,
		};
	};

	instance_methods {
		add_EventBridge = function(this, value){
		};
		remove_EventBridge = function(this, value){
		};
		get_Val = function(this){
			return(this.m_TS);
		};
		set_Val = function(this, value){
			value = wrapstruct(value);
			setinstance(this, "m_TS", value);
		};
		get_Item = function(this, ...){
			local{args = params(1);};
			return(1);
		};
		set_Item = function(this, ...){
			local{args = params();};
			local{value = paramsremove(args);};
			local{args = params(1, args);};
		};
		ctor = function(this){
			callinstance(this, "ctor__System_Int32", 0);
			callinstance(this, "__ctor");
			return(this);
		},
		ctor__System_Int32 = function(this, v){
			callinstance(getinstance(this, "base"), "ctor");
			callinstance(this, "__ctor");
			setinstance(this, "m_Test", v);
			return(this);
		},
		ctor__System_Int32__System_Int32 = function(this, a, b){
			callinstance(getinstance(this, "base"), "ctor");
			callinstance(this, "__ctor");
			return(this);
		},
		Test123 = function(this, a, b){
			return(typecast(( execbinary("+", a, b, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), System.Int32, TypeKind.Struct); return(__expbody_458_12_458_90);
		};
		GTest__TopLevel_SecondLevel_GenericClass_bar = function(this, arg){
		};
		GTest__TopLevel_SecondLevel_GenericClass_TopLevel_Runnable = function(this, arg){
		};
		Iterator = wrapenumerable(function(this){
			wrapyield(null, false, false);
			wrapyield(, false, false);
			return(null);
		});
		Iterator2 = wrapenumerable(function(this){
			wrapyield(null, false, false);
			return(null);
		});
		Test = function(this){
			callinstance(this, "Test123", 1, wrapconst(System.Single, "NegativeInfinity"));
			local(abc); abc = wrapconst(System.Single, "NegativeInfinity");
			local(t); t = newobject(TopLevel.SecondLevel.GenericClass_TopLevel_SecondLevel_Foo_Test1.InnerGenericClass_TopLevel_SecondLevel_Foo_Test2, typeargs(TopLevel.SecondLevel.Foo.Test2), typekinds(TypeKind.Class), "ctor", null, newobject(TopLevel.SecondLevel.Foo.Test1, typeargs(), typekinds(), "ctor", null), newobject(TopLevel.SecondLevel.Foo.Test2, typeargs(), typekinds(), "ctor", null));
			callinstance(t, "Test", System.Int32, 123);
			callinstance(t, "Test2", System.Int32, newobject(TopLevel.SecondLevel.Foo.Test1, typeargs(), typekinds(), "ctor", null), newobject(TopLevel.SecondLevel.Foo.Test2, typeargs(), typekinds(), "ctor", null));
			local(v);
			local(vv); multiassign(vv, v) = callinstance(this, "TestLocal", __cs2dsl_out);
			local(ts); ts = newobject(TopLevel.TestStruct, typeargs(), typekinds(), "ctor", null);
			ts = wrapstruct(ts);
			setinstance(ts, "A", 1);
			setinstance(ts, "B", 2);
			setinstance(ts, "C", 3);
			local(ts2); ts2 = ts;
			ts2 = wrapstruct(ts2);
			local(ts3);
			ts3 = ts;
			ts3 = wrapstruct(ts3);
			callinstance(this, "TestValueArg", ts);
			if( delegationcomparewithnil(true, false, "TopLevel.SecondLevel.Foo:OnSimple", this, null, "OnSimple", false) ){
				getinstance(this, "OnSimple")();
			};
			local(f); f = getinstance(this, "OnSimple");
			if( delegationcomparewithnil(false, false, "TopLevel.SecondLevel.Foo:f", f, null, null, false) ){
				f();
			};
		};
		TestLocal = function(this, out(v)){
			local(ir); ir = newobject(TopLevel.Runnable, typeargs(), typekinds(), "ctor", null);
			invokewithinterface(ir, "TopLevel_IRunnable0", "Test");
			v = 1;
			return(2, v);
		};
		TestValueArg = function(this, ts){
			ts = wrapstruct(ts);
			setinstance(ts, "A", 4);
			setinstance(ts, "B", 5);
			setinstance(ts, "C", 6);
			return(0);
		};
		TestContinueAndReturn = function(this){
			local(i); i = 0;
			while( execbinary("<", i, 100, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
			do{
				if( execbinary("<", i, 10, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
					break;
				};
				block{
				return(i);
				};
			}while(false);
			i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			};
			return(-1);
		};
		TestSwitch = function(this){
			local(i); i = 10;
			local{__switch_533_16_541_17 = i;};
			if( (__switch_533_16_541_17 == 1) || (__switch_533_16_541_17 == 3) ){
				return();
			}elseif( __switch_533_16_541_17 == 2 ){
				return();
			}else{
				return();
			};
			if( execbinary(">", i, 3, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				return();
			};
			if( typeis(this, TopLevel.SecondLevel.FooBase, TypeKind.Class) ){
				return();
			};
		};
		__ctor = function(this){
			if(getinstance(this, "__ctor_called")){
				return;
			}else{
				setinstance(this, "__ctor_called", true);
			};
			this.m_TS = newobject(TopLevel.TestStruct, typeargs(), typekinds(), "ctor", null);
			this.m_HashSet = newexterncollection(System.Collections.Generic.HashSet_T, typeargs(System.String), typekinds(TypeKind.Class), literalcollection("one", "two", "three"), "System.Collections.Generic.HashSet_T:ctor");
		};
	};
	instance_fields {
		OnSimple = null;
		OnSimple2 = null;
		m_Test = 0;
		m_Test2 = 0;
		m_TS = null;
		m_HashSet = null;
		__attributes = TopLevel__SecondLevel__Foo__Attrs;
		__ctor_called = false;
	};
	instance_props {
		Val = {
			get = instance_methods.get_Val;
			set = instance_methods.set_Val;
		};
	};
	instance_events {
		EventBridge = {
			add = instance_methods.add_EventBridge,
			remove = instance_methods.remove_EventBridge,
		};
	};

	interfaces {};
	interface_map {};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		add_OnSimple(MethodKind.EventAdd, Accessibility.Public){
		};
		remove_OnSimple(MethodKind.EventRemove, Accessibility.Public){
		};
		add_EventBridge(MethodKind.EventAdd, Accessibility.Public){
		};
		remove_EventBridge(MethodKind.EventRemove, Accessibility.Public){
		};
		add_StaticEventBridge(MethodKind.EventAdd, Accessibility.Public){
			static(true);
		};
		remove_StaticEventBridge(MethodKind.EventRemove, Accessibility.Public){
			static(true);
		};
		get_Val(MethodKind.PropertyGet, Accessibility.Public){
		};
		set_Val(MethodKind.PropertySet, Accessibility.Public){
		};
		get_Item(MethodKind.PropertyGet, Accessibility.Public){
		};
		set_Item(MethodKind.PropertySet, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
		ctor__System_Int32(MethodKind.Constructor, Accessibility.Public){
		};
		ctor__System_Int32__System_Int32(MethodKind.Constructor, Accessibility.Public){
		};
		op_Increment(MethodKind.UserDefinedOperator, Accessibility.Public){
			static(true);
		};
		op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo(MethodKind.UserDefinedOperator, Accessibility.Public){
			static(true);
		};
		op_Addition__TopLevel_SecondLevel_Foo__System_Int32(MethodKind.UserDefinedOperator, Accessibility.Public){
			static(true);
		};
		op_Explicit(MethodKind.Conversion, Accessibility.Public){
			static(true);
		};
		Test123(MethodKind.Ordinary, Accessibility.Public){
		};
		GTest__TopLevel_SecondLevel_GenericClass_bar(MethodKind.Ordinary, Accessibility.Public){
		};
		GTest__TopLevel_SecondLevel_GenericClass_TopLevel_Runnable(MethodKind.Ordinary, Accessibility.Public){
		};
		Iterator(MethodKind.Ordinary, Accessibility.Public){
		};
		Iterator2(MethodKind.Ordinary, Accessibility.Public){
		};
		Test(MethodKind.Ordinary, Accessibility.Public){
		};
		TestLocal(MethodKind.Ordinary, Accessibility.Private){
		};
		TestValueArg(MethodKind.Ordinary, Accessibility.Private){
		};
		TestContinueAndReturn(MethodKind.Ordinary, Accessibility.Private){
		};
		TestSwitch(MethodKind.Ordinary, Accessibility.Private){
		};
	};
	property_info {
		Val(Accessibility.Public){
		};
	};
	event_info {
		OnSimple(Accessibility.Public){
		};
		EventBridge(Accessibility.Public){
		};
		StaticEventBridge(Accessibility.Public){
			static(true);
		};
	};
	field_info {
		OnSimple2(Accessibility.Public){
		};
		m_Test(Accessibility.Internal){
		};
		m_Test2(Accessibility.Internal){
		};
		m_TS(Accessibility.Internal){
		};
		m_HashSet(Accessibility.Private){
		};
	};
};




class(TopLevel.SecondLevel.Foo.Test1) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.SecondLevel.Foo.Test1, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = function(){
			callstatic(TopLevel.SecondLevel.Foo.Test1, "__cctor");
		};
		__cctor = function(){
			if(TopLevel.SecondLevel.Foo.Test1.__cctor_called){
				return;
			}else{
				TopLevel.SecondLevel.Foo.Test1.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this){
			callinstance(this, "__ctor");
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
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};

	class_info(TypeKind.Class, Accessibility.Private) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};




class(TopLevel.SecondLevel.Foo.Test2) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.SecondLevel.Foo.Test2, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = function(){
			callstatic(TopLevel.SecondLevel.Foo.Test2, "__cctor");
		};
		__cctor = function(){
			if(TopLevel.SecondLevel.Foo.Test2.__cctor_called){
				return;
			}else{
				TopLevel.SecondLevel.Foo.Test2.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this){
			callinstance(this, "__ctor");
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
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};

	class_info(TypeKind.Class, Accessibility.Private) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {};
};




class(TopLevel.SecondLevel.Foo.FooChild) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.SecondLevel.Foo.FooChild, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = function(){
			callstatic(TopLevel.SecondLevel.Foo.FooChild, "__cctor");
		};
		__cctor = function(){
			if(TopLevel.SecondLevel.Foo.FooChild.__cctor_called){
				return;
			}else{
				TopLevel.SecondLevel.Foo.FooChild.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this){
			callinstance(this, "__ctor");
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
		m_Test1 = 123;
		m_Test2 = 456;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};

	class_info(TypeKind.Class, Accessibility.Private) {
	};
	method_info {
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {
		m_Test1(Accessibility.Internal){
		};
		m_Test2(Accessibility.Internal){
		};
	};
};



