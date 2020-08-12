require("cs2dsl__lualib");
require("cs2dsl__attributes");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("luastring");

class(MyScript) {
	static_methods {
		__new_object = function(...){
			return(newobject(MyScript, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = function(){
			callstatic(MyScript, "__cctor");
		};
		__cctor = function(){
			if(MyScript.__cctor_called){
				return;
			}else{
				MyScript.__cctor_called = true;
			};
		};
	};
	static_fields {
		__attributes = MyScript__Attrs;
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		Init = function(this, obj, mb){
			local(s); s = "test test test from cs2lua !";
			callexternstatic(UnityEngine.Debug, "Log", "UnityEngine.Debug:Log__Object", s);
			callexterninstance(mb, "StartCoroutine", callinstance(this, "TestCoroutine"));
			setinstance(SymbolKind.Field, this, "root", newexternobject(UnityEngine.GameObject, typeargs(), typekinds(), null, "UnityEngine.GameObject:ctor__String", "root"));
			local(slider); slider = typeas(callexterninstance(callexternstatic(UnityEngine.GameObject, "Find", "Canvas/Slider"), "GetComponent", "UnityEngine.GameObject:GetComponent__Type", typeof(UnityEngine.UI.Slider)), UnityEngine.UI.Slider, TypeKind.Class);
			local(counttxt); counttxt = typeas(callexterninstance(callexternstatic(UnityEngine.GameObject, "Find", "Canvas/Count"), "GetComponent", "UnityEngine.GameObject:GetComponent__Type", typeof(UnityEngine.UI.Text)), UnityEngine.UI.Text, TypeKind.Class);
			callexterninstance(getexterninstance(SymbolKind.Property, slider, "onValueChanged"), "AddListener", (function(v){
				callinstance(this, "Reset");
				getexterninstance(SymbolKind.Property, counttxt, "text") = callstatic(LuaString, "Format__System_String__System_Object", "cube:{0}", v);
				setinstance(SymbolKind.Field, this, "max", typecast(v, System.Int32, TypeKind.Struct));
			}));
			callinstance(this, "Reset");
		};
		Update = function(this){
			local(i); i = 0;
			while( execbinary("<", i, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, "cubes"), "Length"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(offset); offset = condexp(execbinary("==", execbinary("%", i, 2, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), true, 5, true, -5);
				local(nr); nr = execbinary("+", getinstance(SymbolKind.Field, this, "r"), execbinary("*", callexternstatic(UnityEngine.Mathf, "Sin", getexternstatic(SymbolKind.Property, UnityEngine.Time, "time")), offset, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct);
				local(angle); angle = condexp(execbinary("==", execbinary("%", i, 2, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), false, (function(){ return(getexternstatic(SymbolKind.Property, UnityEngine.Time, "time")); }), true, -5);
				local(b); b = newexternobject(UnityEngine.Vector3, typeargs(), typekinds(), null, "UnityEngine.Vector3:ctor__Single__Single__Single", typecast(( execbinary("*", callexternstatic(UnityEngine.Mathf, "Cos", execbinary("+", execbinary("/", execbinary("*", execbinary("*", i, 3.14, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), angle, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), nr, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), System.Single, TypeKind.Struct), typecast(( execbinary("*", callexternstatic(UnityEngine.Mathf, "Sin", execbinary("+", execbinary("/", execbinary("*", execbinary("*", i, 3.14, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), angle, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), nr, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), System.Single, TypeKind.Struct), 0);
				b = wrapexternstruct(b, UnityEngine.Vector3);
				setexterninstance(SymbolKind.Property, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, "cubes")[i + 1], "transform"), "position", b);
			i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			};
			if( execbinary("||", execbinary("<=", getinstance(SymbolKind.Field, this, "fogStart"), 0, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), execbinary(">", getinstance(SymbolKind.Field, this, "t"), 1, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct) ){
				setinstance(SymbolKind.Field, this, "fogStart", getexternstatic(SymbolKind.Property, UnityEngine.Time, "time"));
				setinstance(SymbolKind.Field, this, "bgCurrent", getexterninstance(SymbolKind.Property, getexternstatic(SymbolKind.Property, UnityEngine.Camera, "main"), "backgroundColor"));
				getinstance(SymbolKind.Field, this, "bgCurrent") = wrapexternstruct(getinstance(SymbolKind.Field, this, "bgCurrent"), UnityEngine.Color);
				local(ix); ix = callexternstatic(UnityEngine.Random, "Range", "UnityEngine.Random:Range__Int32__Int32", 0, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, "colors"), "Length"));
				setinstance(SymbolKind.Field, this, "bgColor", getinstance(SymbolKind.Field, this, "colors")[ix + 1]);
				getinstance(SymbolKind.Field, this, "bgColor") = wrapexternstruct(getinstance(SymbolKind.Field, this, "bgColor"), UnityEngine.Color);
			};
			setinstance(SymbolKind.Field, this, "t", execbinary("/", ( execbinary("-", getexternstatic(SymbolKind.Property, UnityEngine.Time, "time"), getinstance(SymbolKind.Field, this, "fogStart"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), 10, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct));
			getexterninstance(SymbolKind.Property, getexternstatic(SymbolKind.Property, UnityEngine.Camera, "main"), "backgroundColor") = callexternstatic(UnityEngine.Color, "Lerp", getinstance(SymbolKind.Field, this, "bgCurrent"), getinstance(SymbolKind.Field, this, "bgColor"), getinstance(SymbolKind.Field, this, "t"));
		};
		Call = function(this, name, ...){
			local{args = params(System.Object, TypeKind.Class);};
		};
		TestCoroutine = wrapenumerable(function(this){
			wrapyield(newexternobject(UnityEngine.WaitForSeconds, typeargs(), typekinds(), null, 10), false, true);
			local(i); i = 0;
			while( execbinary("<", i, 60, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				wrapyield(newexternobject(UnityEngine.WaitForSeconds, typeargs(), typekinds(), null, 1), false, true);
				callexternstatic(UnityEngine.Debug, "Log", "UnityEngine.Debug:Log__Object", callexternstatic(System.String, "Format", "System.String:Format__String__Object", "{0} seconds", i));
			i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			};
			return(null);
		});
		Reset = function(this){
			if( execbinary("!=", null, getinstance(SymbolKind.Field, this, "cubes"), System.Object, System.Object, TypeKind.Class, TypeKind.Class) ){
				local(i); i = 0;
				while( execbinary("<", i, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, "cubes"), "Length"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
					callexternstatic(UnityEngine.Object, "Destroy", "UnityEngine.Object:Destroy__Object", getinstance(SymbolKind.Field, this, "cubes")[i + 1]);
				i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
				};
			};
			setinstance(SymbolKind.Field, this, "cubes", (function(){ local(d0); d0 = getinstance(SymbolKind.Field, this, "max"); local{arr = newarray(UnityEngine.GameObject, TypeKind.Class, d0);}; for(i0, 1, d0){ arr[i0] = null; }; return(arr); })());
			local(P); P = callexternstatic(UnityEngine.Resources, "Load", "UnityEngine.Resources:Load__String", "Particle System");
			local(i); i = 0;
			while( execbinary("<", i, getinstance(SymbolKind.Field, this, "max"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(cube); cube = callexternstatic(UnityEngine.GameObject, "CreatePrimitive", 3);
				setexterninstance(SymbolKind.Property, getexterninstance(SymbolKind.Property, cube, "transform"), "position", newexternobject(UnityEngine.Vector3, typeargs(), typekinds(), null, "UnityEngine.Vector3:ctor__Single__Single__Single", execbinary("*", typecast(callexternstatic(UnityEngine.Mathf, "Cos", execbinary("/", execbinary("*", execbinary("*", i, 3.14, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), System.Single, TypeKind.Struct), getinstance(SymbolKind.Field, this, "r"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), execbinary("*", typecast(callexternstatic(UnityEngine.Mathf, "Sin", execbinary("/", execbinary("*", execbinary("*", i, 3.14, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), System.Single, TypeKind.Struct), getinstance(SymbolKind.Field, this, "r"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 0));
				callexterninstance(getexterninstance(SymbolKind.Property, cube, "transform"), "SetParent", "UnityEngine.Transform:SetParent__Transform", getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, "root"), "transform"));
				local(mat); mat = getexterninstance(SymbolKind.Property, callexterninstance(cube, "GetComponent", "UnityEngine.GameObject:GetComponent__Type", UnityEngine.Renderer), "material");
				local(box); box = callexterninstance(cube, "GetComponent", "UnityEngine.GameObject:GetComponent__Type", typeof(UnityEngine.BoxCollider));
				callexternstatic(UnityEngine.Object, "Destroy", "UnityEngine.Object:Destroy__Object", box);
				local(p); p = typeas(callexternstatic(UnityEngine.Object, "Instantiate", "UnityEngine.Object:Instantiate__Object__Vector3__Quaternion", P, getexternstatic(SymbolKind.Property, UnityEngine.Vector3, "zero"), getexternstatic(SymbolKind.Property, UnityEngine.Quaternion, "identity")), UnityEngine.GameObject, TypeKind.Class);
				callexterninstance(getexterninstance(SymbolKind.Property, p, "transform"), "SetParent", "UnityEngine.Transform:SetParent__Transform", getexterninstance(SymbolKind.Property, cube, "transform"));
				local(ix); ix = callexternstatic(UnityEngine.Random, "Range", "UnityEngine.Random:Range__Int32__Int32", 0, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, "colors"), "Length"));
				setexterninstance(SymbolKind.Property, mat, "color", getinstance(SymbolKind.Field, this, "colors")[ix + 1]);
				getinstance(SymbolKind.Field, this, "cubes")[i + 1] = cube;
			i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			};
		};
		ctor = function(this){
			callinstance(this, "__ctor");
		};
		__ctor = function(this){
			if(getinstance(SymbolKind.Field, this, "__ctor_called")){
				return;
			}else{
				setinstance(SymbolKind.Field, this, "__ctor_called", true);
			};
			this.bgCurrent = newexternobject(UnityEngine.Color, typeargs(), typekinds(), null);
			this.bgColor = newexternobject(UnityEngine.Color, typeargs(), typekinds(), null);
			this.colors = literalarray(UnityEngine.Color, TypeKind.Struct, getexternstatic(SymbolKind.Property, UnityEngine.Color, "red"), getexternstatic(SymbolKind.Property, UnityEngine.Color, "blue"), getexternstatic(SymbolKind.Property, UnityEngine.Color, "green"), getexternstatic(SymbolKind.Property, UnityEngine.Color, "cyan"), getexternstatic(SymbolKind.Property, UnityEngine.Color, "grey"), getexternstatic(SymbolKind.Property, UnityEngine.Color, "white"), getexternstatic(SymbolKind.Property, UnityEngine.Color, "yellow"), getexternstatic(SymbolKind.Property, UnityEngine.Color, "magenta"), getexternstatic(SymbolKind.Property, UnityEngine.Color, "black"));
		};
	};
	instance_fields {
		root = null;
		r = 10;
		max = 400;
		t = 0;
		fogStart = 0;
		bgCurrent = null;
		bgColor = null;
		cubes = null;
		colors = null;
		__attributes = MyScript__Attrs;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"ITickPlugin";
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



