require("cs2dsl__utility");
require("cs2dsl__attributes");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("luastring");

class(MyScript) {
	static_methods {
		__new_object = function(...){
			return(newobject(MyScript, typeargs(), typekinds(), null, null, ...));
		};
		cctor = function(){
		};
	};
	static_fields {
		__attributes = MyScript__Attrs;
	};
	static_props {};
	static_events {};

	instance_methods {
		Init = function(this, obj, mb){
			local(s); s = "test test test from cs2lua !";
			callstatic(UnityEngine.Debug, "Log", "Log__Object", s);
			callinstance(mb, "StartCoroutine", "StartCoroutine__IEnumerator", callinstance(this, "TestCoroutine"));
			setinstance(this, "root", newexternobject(UnityEngine.GameObject, typeargs(), typekinds(), , null, "ctor__String", "root"));
			local(slider); slider = typeas(callinstance(callstatic(UnityEngine.GameObject, "Find", "Canvas/Slider"), "GetComponent", "GetComponent__Type", typeof(UnityEngine.UI.Slider)), UnityEngine.UI.Slider, TypeKind.Class);
			local(counttxt); counttxt = typeas(callinstance(callstatic(UnityEngine.GameObject, "Find", "Canvas/Count"), "GetComponent", "GetComponent__Type", typeof(UnityEngine.UI.Text)), UnityEngine.UI.Text, TypeKind.Class);
			callinstance(getinstance(slider, "onValueChanged"), "AddListener", (function(v){
				callinstance(this, "Reset");
				getinstance(counttxt, "text") = callstatic(LuaString, "Format", "cube:{0}", v);
				setinstance(this, "max", typecast(v, System.Int32, TypeKind.Struct));
			}));
			callinstance(this, "Reset");
		};
		Update = function(this){
			local(i); i = 0;
			while( execbinary("<", i, getinstance(getinstance(this, "cubes"), "Length"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(offset); offset = condexp(execbinary("==", execbinary("%", i, 2, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), true, 5, true, -5);
				local(nr); nr = execbinary("+", getinstance(this, "r"), execbinary("*", callstatic(UnityEngine.Mathf, "Sin", getstatic(UnityEngine.Time, "time")), offset, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct);
				local(angle); angle = condexp(execbinary("==", execbinary("%", i, 2, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), false, (function(){ return(getstatic(UnityEngine.Time, "time")); }), true, -5);
				local(b); b = newexternobject(UnityEngine.Vector3, typeargs(), typekinds(), , null, "ctor__Single__Single__Single", typecast(( execbinary("*", callstatic(UnityEngine.Mathf, "Cos", execbinary("+", execbinary("/", execbinary("*", execbinary("*", i, 3.14, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(this, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), angle, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), nr, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), System.Single, TypeKind.Struct), typecast(( execbinary("*", callstatic(UnityEngine.Mathf, "Sin", execbinary("+", execbinary("/", execbinary("*", execbinary("*", i, 3.14, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(this, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), angle, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), nr, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), System.Single, TypeKind.Struct), 0);
				setinstance(getinstance(getinstance(this, "cubes")[i + 1], "transform"), "position", b);
			i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			};
			if( execbinary("||", execbinary("<=", getinstance(this, "fogStart"), 0, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), execbinary(">", getinstance(this, "t"), 1, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct) ){
				setinstance(this, "fogStart", getstatic(UnityEngine.Time, "time"));
				setinstance(this, "bgCurrent", getinstance(getstatic(UnityEngine.Camera, "main"), "backgroundColor"));
				local(ix); ix = callstatic(UnityEngine.Random, "Range", "Range__Int32__Int32", 0, getinstance(getinstance(this, "colors"), "Length"));
				setinstance(this, "bgColor", getinstance(this, "colors")[ix + 1]);
			};
			setinstance(this, "t", execbinary("/", ( execbinary("-", getstatic(UnityEngine.Time, "time"), getinstance(this, "fogStart"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), 10, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct));
			getinstance(getstatic(UnityEngine.Camera, "main"), "backgroundColor") = callstatic(UnityEngine.Color, "Lerp", getinstance(this, "bgCurrent"), getinstance(this, "bgColor"), getinstance(this, "t"));
		};
		Call = function(this, name, ...){
			local{args = params(0);};
		};
		TestCoroutine = wrapenumerable(function(this){
			wrapyield(newexternobject(UnityEngine.WaitForSeconds, typeargs(), typekinds(), , null, 10), false, true);
			local(i); i = 0;
			while( execbinary("<", i, 60, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				wrapyield(newexternobject(UnityEngine.WaitForSeconds, typeargs(), typekinds(), , null, 1), false, true);
				callstatic(UnityEngine.Debug, "Log", "Log__Object", callstatic(System.String, "Format", "Format__String__Object", "{0} seconds", i));
			i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			};
			return(null);
		});
		Reset = function(this){
			if( execbinary("!=", null, getinstance(this, "cubes"), System.Object, System.Object, TypeKind.Class, TypeKind.Class) ){
				local(i); i = 0;
				while( execbinary("<", i, getinstance(getinstance(this, "cubes"), "Length"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
					callstatic(UnityEngine.Object, "Destroy", "Destroy__Object", getinstance(this, "cubes")[i + 1]);
				i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
				};
			};
			setinstance(this, "cubes", (function(){ local(d0); d0 = getinstance(this, "max"); local{arr = newarray(UnityEngine.GameObject, d0);}; for(i0, 1, d0){ arr[i0] = null; }; return(arr); })());
			local(P); P = callstatic(UnityEngine.Resources, "Load", "Load__String", "Particle System");
			local(i); i = 0;
			while( execbinary("<", i, getinstance(this, "max"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(cube); cube = callstatic(UnityEngine.GameObject, "CreatePrimitive", 3);
				setinstance(getinstance(cube, "transform"), "position", newexternobject(UnityEngine.Vector3, typeargs(), typekinds(), , null, "ctor__Single__Single__Single", execbinary("*", typecast(callstatic(UnityEngine.Mathf, "Cos", execbinary("/", execbinary("*", execbinary("*", i, 3.14, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(this, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), System.Single, TypeKind.Struct), getinstance(this, "r"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), execbinary("*", typecast(callstatic(UnityEngine.Mathf, "Sin", execbinary("/", execbinary("*", execbinary("*", i, 3.14, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(this, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), System.Single, TypeKind.Struct), getinstance(this, "r"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 0));
				callinstance(getinstance(cube, "transform"), "SetParent", "SetParent__Transform", getinstance(getinstance(this, "root"), "transform"));
				local(mat); mat = getinstance(callinstance(cube, "GetComponent", "GetComponent__Type", UnityEngine.Renderer), "material");
				local(box); box = callinstance(cube, "GetComponent", "GetComponent__Type", typeof(UnityEngine.BoxCollider));
				callstatic(UnityEngine.Object, "Destroy", "Destroy__Object", box);
				local(p); p = typeas(callstatic(UnityEngine.Object, "Instantiate", "Instantiate__Object__Vector3__Quaternion", P, getstatic(UnityEngine.Vector3, "zero"), getstatic(UnityEngine.Quaternion, "identity")), UnityEngine.GameObject, TypeKind.Class);
				callinstance(getinstance(p, "transform"), "SetParent", "SetParent__Transform", getinstance(cube, "transform"));
				local(ix); ix = callstatic(UnityEngine.Random, "Range", "Range__Int32__Int32", 0, getinstance(getinstance(this, "colors"), "Length"));
				setinstance(mat, "color", getinstance(this, "colors")[ix + 1]);
				getinstance(this, "cubes")[i + 1] = cube;
			i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			};
		};
		ctor = function(this){
			callinstance(this, "__ctor");
		};
		__ctor = function(this){
			if(getinstance(this, "__ctor_called")){
				return;
			}else{
				setinstance(this, "__ctor_called", true);
			};
			this.bgCurrent = newexternobject(UnityEngine.Color, typeargs(), typekinds(), , null);
			this.bgColor = newexternobject(UnityEngine.Color, typeargs(), typekinds(), , null);
		};
	};
	instance_fields {
		root = null;
		r = 10;
		max = 400;
		t = 0;
		fogStart = 0;
		bgCurrent = defaultvalue(UnityEngine.Color, "UnityEngine.Color", true);
		bgColor = defaultvalue(UnityEngine.Color, "UnityEngine.Color", true);
		cubes = null;
		colors = buildarray(UnityEngine.Color, getstatic(UnityEngine.Color, "red"), getstatic(UnityEngine.Color, "blue"), getstatic(UnityEngine.Color, "green"), getstatic(UnityEngine.Color, "cyan"), getstatic(UnityEngine.Color, "grey"), getstatic(UnityEngine.Color, "white"), getstatic(UnityEngine.Color, "yellow"), getstatic(UnityEngine.Color, "magenta"), getstatic(UnityEngine.Color, "black"));
		__attributes = MyScript__Attrs;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"ITickPlugin";
	};
	interface_map {
		ITickPlugin_Init = "Init";
		ITickPlugin_Update = "Update";
		ITickPlugin_FixedUpdate = "FixedUpdate";
		ITickPlugin_LateUpdate = "LateUpdate";
		ITickPlugin_Call = "Call";
	};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		Init(MethodKind.Ordinary, Accessibility.Public){
		};
		Update(MethodKind.Ordinary, Accessibility.Public){
		};
		FixedUpdate(MethodKind.Ordinary, Accessibility.Public){
		};
		LateUpdate(MethodKind.Ordinary, Accessibility.Public){
		};
		Call(MethodKind.Ordinary, Accessibility.Public){
		};
		TestCoroutine(MethodKind.Ordinary, Accessibility.Private){
		};
		Reset(MethodKind.Ordinary, Accessibility.Private){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {
		root(Accessibility.Private){
		};
		r(Accessibility.Private){
		};
		max(Accessibility.Private){
		};
		t(Accessibility.Private){
		};
		fogStart(Accessibility.Private){
		};
		bgCurrent(Accessibility.Private){
		};
		bgColor(Accessibility.Private){
		};
		cubes(Accessibility.Private){
		};
		colors(Accessibility.Private){
		};
	};
};



