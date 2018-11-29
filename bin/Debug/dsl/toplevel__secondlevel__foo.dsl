require("cs2lua__utility");
require("cs2lua__attributes");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");
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
		op_Addition__TopLevel_SecondLevel_Foo__TopLevel_SecondLevel_Foo = function(self, other){
			setinstance(self, "m_Test", execbinary("+", self.m_Test, other.m_Test, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			return(self);
			return(nil);
		};
		op_Addition__TopLevel_SecondLevel_Foo__System_Int32 = function(self, val){
			setinstance(self, "m_Test", execbinary("+", self.m_Test, val, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
			return(self);
			return(nil);
		};
		op_Explicit = function(a){
			local(f); f = newobject(TopLevel.SecondLevel.Foo, typeargs(), typekinds(), "ctor", null);
			setinstance(f, "m_Test", a);
			setinstance(f, "Val", newobject(TopLevel.TestStruct, typeargs(), typekinds(), "ctor", null));
			local(ts); ts = getinstance(f, "Val");
			ts = wrapvaluetype(ts);
			setinstanceindexer(f, null, "set_Item", ts, ts, 123);
			local(r); r = getinstanceindexer(f, null, "get_Item", ts, ts);
			local(result); result = callinstance(getstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "instance"), "Test123", 1, 2);
			setstatic(TopLevel.Singleton_TopLevel_SecondLevel_Foo, "instance", null);
			return(f);
			return(nil);
		};
		cctor = function(){
			callstatic(TopLevel.SecondLevel.FooBase, "cctor");
		};
	};
	static_fields {
		__attributes = TopLevel__SecondLevel__Foo__Attrs;
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
			value = wrapvaluetype(value);
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
			return(this);
		},
		ctor__System_Int32 = function(this, v){
			callstatic(getinstance(this, "base"), "ctor", this);
			setinstance(this, "m_Test", v);
			return(this);
		},
		ctor__System_Int32__System_Int32 = function(this, a, b){
			callstatic(getinstance(this, "base"), "ctor", this);
			return(this);
		},
		Test123 = function(this, a, b){
			return(typecast(( execbinary("+", a, b, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), System.Int32, TypeKind.Struct); return(__expbody_448_12_448_90);
		};
		GTest__TopLevel_SecondLevel_GenericClass_bar = function(this, arg){
		};
		GTest__TopLevel_SecondLevel_GenericClass_TopLevel_Runnable = function(this, arg){
		};
		Iterator = wrapenumerable(function(this){
			wrapyield(null, false, false);
			wrapyield(newexternobject(UnityEngine.WaitForSeconds, typeargs(), typekinds(), "UnityEngine.WaitForSeconds", "ctor", null, 3), false, true);
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
			local(vv); multiassign(vv, v) = callinstance(this, "TestLocal", __cs2lua_out);
			local(ts); ts = newobject(TopLevel.TestStruct, typeargs(), typekinds(), "ctor", null);
			ts = wrapvaluetype(ts);
			setinstance(ts, "A", 1);
			setinstance(ts, "B", 2);
			setinstance(ts, "C", 3);
			local(ts2); ts2 = ts;
			ts2 = wrapvaluetype(ts2);
			local(ts3);
			ts3 = ts;
			ts3 = wrapvaluetype(ts3);
			callinstance(this, "TestValueArg", ts);
			if( delegationcomparewithnil(true, false, "TopLevel.SecondLevel.Foo:OnSimple", this, nil, "OnSimple", false) ){
				getinstance(this, "OnSimple")();
			};
			local(f); f = getinstance(this, "OnSimple");
			if( delegationcomparewithnil(false, false, "TopLevel.SecondLevel.Foo:f", f, nil, nil, false) ){
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
			ts = wrapvaluetype(ts);
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
			local{__switch_523_16_531_17 = i;};
			if( (__switch_523_16_531_17 == 1) || (__switch_523_16_531_17 == 3) ){
				return();
			}elseif( __switch_523_16_531_17 == 2 ){
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
			this.m_TS = new TopLevel.TestStruct();
		};
	};
	instance_fields {
		OnSimple = null;
		OnSimple2 = null;
		m_Test = 0;
		m_Test2 = 0;
		m_TS = defaultvalue(TopLevel.TestStruct, "TopLevel.TestStruct", false);
		m_HashSet = newexterncollection(System.Collections.Generic.HashSet_T, typeargs(System.String), typekinds(TypeKind.Class), "System.Collections.Generic.HashSet_T", "ctor", literalcollection("one", "two", "three"));
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
};




class(TopLevel.SecondLevel.Foo.Test1) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.SecondLevel.Foo.Test1, typeargs(), typekinds(), null, null, ...));
		};
		cctor = function(){
		};
	};
	static_fields {
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this){
		};
	};
	instance_fields {
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};
};




class(TopLevel.SecondLevel.Foo.Test2) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.SecondLevel.Foo.Test2, typeargs(), typekinds(), null, null, ...));
		};
		cctor = function(){
		};
	};
	static_fields {
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this){
		};
	};
	instance_fields {
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};
};




class(TopLevel.SecondLevel.Foo.FooChild) {
	static_methods {
		__new_object = function(...){
			return(newobject(TopLevel.SecondLevel.Foo.FooChild, typeargs(), typekinds(), null, null, ...));
		};
		cctor = function(){
		};
	};
	static_fields {
	};
	static_props {};
	static_events {};

	instance_methods {
		ctor = function(this){
		};
	};
	instance_fields {
		m_Test1 = 123;
		m_Test2 = 456;
	};
	instance_props {};
	instance_events {};

	interfaces {};
	interface_map {};
};



