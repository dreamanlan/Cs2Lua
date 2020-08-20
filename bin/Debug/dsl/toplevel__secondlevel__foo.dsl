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
			setinstance(SymbolKind.Field, self, "m_Test", execbinary("+", getinstance(SymbolKind.Field, self, "m_Test"), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			return(self);
			return(null);
		};
		op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo = function(self, other){
			setinstance(SymbolKind.Field, self, "m_Test", execbinary("+", getinstance(SymbolKind.Field, self, "m_Test"), getinstance(SymbolKind.Field, other, "m_Test"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			return(self);
			return(null);
		};
		op_Addition__TopLevel_SecondLevel_Foo__System_Int32 = function(self, val){
			setinstance(SymbolKind.Field, self, "m_Test", execbinary("+", getinstance(SymbolKind.Field, self, "m_Test"), val, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			return(self);
			return(null);
		};
		op_Explicit = function(a){
			local(f); f = newobject(TopLevel.SecondLevel.Foo, typeargs(), typekinds(), "ctor", null);
			setinstance(SymbolKind.Field, f, "m_Test", a);
			setinstance(SymbolKind.Property, f, "Val", newobject(TopLevel.TestStruct, typeargs(), typekinds(), "ctor", null));
			local(ts); ts = getinstance(SymbolKind.Property, f, "Val");
			ts = wrapstruct(ts, TopLevel.TestStruct);
			setinstanceindexer(f, TopLevel.SecondLevel.Foo, "set_Item", 2, true, ts, ts, 123);
			local(r); r = getinstanceindexer(f, TopLevel.SecondLevel.Foo, "get_Item", 1, ts, ts);
			local(result); result = callinstance(getstatic(SymbolKind.Property, TopLevel.Singleton_TopLevel_SecondLevel_Foo, "instance"), "Test123", 1, 2);
			setstatic(SymbolKind.Property, TopLevel.Singleton_TopLevel_SecondLevel_Foo, "instance", null);
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
			return(getinstance(SymbolKind.Field, this, "m_TS"));
		};
		set_Val = function(this, value){
			value = wrapstruct(value, TopLevel.TestStruct);
			setinstance(SymbolKind.Field, this, "m_TS", value);
			getinstance(SymbolKind.Field, this, "m_TS") = wrapstruct(getinstance(SymbolKind.Field, this, "m_TS"), TopLevel.TestStruct);
		};
		get_Item = function(this, ...){
			local{args = params(TopLevel.TestStruct, TypeKind.Struct);};
			return(1);
		};
		set_Item = function(this, ...){
			local{args = params(TopLevel.TestStruct, TypeKind.Struct);};
			local{value = paramsremove(args);};
		};
		ctor = function(this){
			callinstance(this, "ctor__System_Int32", 0);
			callinstance(this, "__ctor");
			return(this);
		},
		ctor__System_Int32 = function(this, v){
			callinstance(getinstance(SymbolKind.Field, this, "base"), "ctor");
			callinstance(this, "__ctor");
			setinstance(SymbolKind.Field, this, "m_Test", v);
			return(this);
		},
		ctor__System_Int32__System_Int32 = function(this, a, b){
			callinstance(getinstance(SymbolKind.Field, this, "base"), "ctor");
			callinstance(this, "__ctor");
			return(this);
		},
		Test123 = function(this, a, b){
			return(typecast(( execbinary("+", a, b, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), System.Int32, TypeKind.Struct));
		};
		GTest__TopLevel_SecondLevel_GenericClass_bar = function(this, arg){
		};
		GTest__TopLevel_SecondLevel_GenericClass_TopLevel_Runnable = function(this, arg){
		};
		Iterator = wrapenumerable(function(this){
			wrapyield(null, false, false);
			wrapyield(newexternobject(UnityEngine.WaitForSeconds, typeargs(), typekinds(), null, 3), false, true);
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
			if( execbinary("<", execclosure(__invoke_490_19_490_35, true){ multiassign(__invoke_490_19_490_35, v) = callinstance(this, "TestLocal", __cs2dsl_out); }, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
			};
			if( execclosure(__invoke_493_19_493_36, true){ multiassign(__invoke_493_19_493_36, v) = callinstance(this, "TestLocal2", __cs2dsl_out); } ){
			};
			if( execunary("!", execclosure(__invoke_496_21_496_38, true){ multiassign(__invoke_496_21_496_38, v) = callinstance(this, "TestLocal2", __cs2dsl_out); }, System.Boolean, TypeKind.Struct) ){
			}elseif( execclosure(__invoke_499_24_499_41, true){ multiassign(__invoke_499_24_499_41, v) = callinstance(this, "TestLocal2", __cs2dsl_out); } ){
			}else{
			};
			while( execclosure(__invoke_505_22_505_39, true){ multiassign(__invoke_505_22_505_39, v) = callinstance(this, "TestLocal2", __cs2dsl_out); } ){
			};
			do{
			}while(execunary("!", execclosure(__invoke_510_26_510_43, true){ multiassign(__invoke_510_26_510_43, v) = callinstance(this, "TestLocal2", __cs2dsl_out); }, System.Boolean, TypeKind.Struct));
			local(ts); ts = newobject(TopLevel.TestStruct, typeargs(), typekinds(), "ctor", null);
			ts = wrapstruct(ts, TopLevel.TestStruct);
			setinstance(SymbolKind.Field, ts, "A", 1);
			setinstance(SymbolKind.Field, ts, "B", 2);
			setinstance(SymbolKind.Field, ts, "C", 3);
			local(ts2); ts2 = ts;
			ts2 = wrapstruct(ts2, TopLevel.TestStruct);
			local(ts3);
			ts3 = ts;
			ts3 = wrapstruct(ts3, TopLevel.TestStruct);
			callinstance(this, "TestValueArg", ts);
			if( delegationcomparewithnil(false, "TopLevel.SecondLevel.Foo:OnSimple", this, "OnSimple", SymbolKind.Event, false) ){
				getinstance(SymbolKind.Event, this, "OnSimple")();
			};
			local(f); f = getinstance(SymbolKind.Event, this, "OnSimple");
			if( delegationcomparewithnil(false, "TopLevel.SecondLevel.Foo:f", f, null, SymbolKind.Local, false) ){
				f();
			};
		};
		TestLocal = function(this, v){
			local(ir); ir = newobject(TopLevel.Runnable, typeargs(), typekinds(), "ctor", null);
			callinstance(ir, "TopLevel_IRunnable0_Test");
			v = 1;
			return(2, v);
		};
		TestLocal2 = function(this, v){
			v = 0;
			return(false, v);
		};
		TestValueArg = function(this, ts){
			ts = wrapstruct(ts, TopLevel.TestStruct);
			setinstance(SymbolKind.Field, ts, "A", 4);
			setinstance(SymbolKind.Field, ts, "B", 5);
			setinstance(SymbolKind.Field, ts, "C", 6);
			return(0);
		};
		TestContinueAndReturn = function(this){
			local(i); i = 0;
			while( execbinary("<", i, 100, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
			do{
				if( execbinary("<", i, 10, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
					block{
					break;
					};
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
			local{__switch_563_16_571_17 = i;};
			if( (__switch_563_16_571_17 == 1) || (__switch_563_16_571_17 == 3) ){
				return();
			}elseif( __switch_563_16_571_17 == 2 ){
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
			if(getinstance(SymbolKind.Field, this, "__ctor_called")){
				return;
			}else{
				setinstance(SymbolKind.Field, this, "__ctor_called", true);
			};
			this.m_TS = newobject(TopLevel.TestStruct, typeargs(), typekinds(), "ctor", null);
			this.m_HashSet = newexterncollection(System.Collections.Generic.HashSet_T, typeargs(System.String), typekinds(TypeKind.Class), literalcollection(typeargs(System.String), typekinds(TypeKind.Class), "one", "two", "three"), "System.Collections.Generic.HashSet_T:ctor");
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
		TestLocal2(MethodKind.Ordinary, Accessibility.Private){
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
			if(getinstance(SymbolKind.Field, this, "__ctor_called")){
				return;
			}else{
				setinstance(SymbolKind.Field, this, "__ctor_called", true);
			};
		};
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
			if(getinstance(SymbolKind.Field, this, "__ctor_called")){
				return;
			}else{
				setinstance(SymbolKind.Field, this, "__ctor_called", true);
			};
		};
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
			if(getinstance(SymbolKind.Field, this, "__ctor_called")){
				return;
			}else{
				setinstance(SymbolKind.Field, this, "__ctor_called", true);
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



