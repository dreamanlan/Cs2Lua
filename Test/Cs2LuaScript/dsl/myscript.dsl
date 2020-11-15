require("cs2dsl__syslib");
require("cs2dsl__attributes");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("luastring");

class(MyScript) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(MyScript, typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(MyScript, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(MyScript.__cctor_called){
				return();
			}else{
				MyScript.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__attributes = MyScript__Attrs;
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		Init = deffunc(0)args(this, obj, mb){
			local(s); s = "test test test from cs2lua !";
			callexternstatic(UnityEngine.Debug, "Log", dslstrtocsstr("UnityEngine.Debug:Log__Void__Object"), s);
			callexterninstance(mb, MonoBehaviourProxy, "StartCoroutine", callinstance(this, MyScript, "TestCoroutine"));
			setinstance(SymbolKind.Field, this, MyScript, "root", newexternobject(UnityEngine.GameObject, typeargs(), typekinds(), null, dslstrtocsstr("UnityEngine.GameObject:ctor__Void__String"), dslstrtocsstr("root")));
			local(slider); slider = typeas(callexterninstance(callexternstatic(UnityEngine.GameObject, "Find", dslstrtocsstr("Canvas/Slider")), UnityEngine.GameObject, "GetComponent", dslstrtocsstr("UnityEngine.GameObject:GetComponent__Component__Type"), typeof(UnityEngine.UI.Slider)), UnityEngine.UI.Slider, TypeKind.Class);
			local(counttxt); counttxt = typeas(callexterninstance(callexternstatic(UnityEngine.GameObject, "Find", dslstrtocsstr("Canvas/Count")), UnityEngine.GameObject, "GetComponent", dslstrtocsstr("UnityEngine.GameObject:GetComponent__Component__Type"), typeof(UnityEngine.UI.Text)), UnityEngine.UI.Text, TypeKind.Class);
			callexterninstance(getexterninstance(SymbolKind.Property, slider, UnityEngine.UI.Slider, "onValueChanged"), UnityEngine.Events.UnityEvent_T0, "AddListener", deffunc(0)args(v){
				callinstance(this, MyScript, "Reset");
				getexterninstance(SymbolKind.Property, counttxt, UnityEngine.UI.Text, "text") = callstatic(LuaString, "Format__System_String__System_Object", "cube:{0}", v);
				setinstance(SymbolKind.Field, this, MyScript, "max", typecast(v, System.Int32, TypeKind.Struct));
			}options[needfuncinfo(false)]);
			callinstance(this, MyScript, "Reset");
		}options[needfuncinfo(false)];
		Update = deffunc(0)args(this){
			local(i); i = 0;
			while( execbinary("<", i, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, MyScript, "cubes"), System.Array, "Length"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(offset); offset = condexp(execbinary("==", execbinary("%", i, 2, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), true, 5, true, -5);
				local(nr); nr = execbinary("+", getinstance(SymbolKind.Field, this, MyScript, "r"), execbinary("*", callexternstatic(UnityEngine.Mathf, "Sin", getexternstatic(SymbolKind.Property, UnityEngine.Time, "time")), offset, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct);
				local(angle); angle = condexp(execbinary("==", execbinary("%", i, 2, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), false, function(){ funcobjret(getexternstatic(SymbolKind.Property, UnityEngine.Time, "time")); }, true, -5);
				local(b); b = newexternstruct(UnityEngine.Vector3, typeargs(), typekinds(), null, dslstrtocsstr("UnityEngine.Vector3:ctor__Void__Single__Single__Single"), typecast(( execbinary("*", callexternstatic(UnityEngine.Mathf, "Cos", execbinary("+", execbinary("/", execbinary("*", execbinary("*", i, 3.14159300, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, MyScript, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), angle, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), nr, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), System.Single, TypeKind.Struct), typecast(( execbinary("*", callexternstatic(UnityEngine.Mathf, "Sin", execbinary("+", execbinary("/", execbinary("*", execbinary("*", i, 3.14159300, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, MyScript, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), angle, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), nr, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), System.Single, TypeKind.Struct), 0);
				setexterninstance(SymbolKind.Property, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, MyScript, "cubes")[i + 1], UnityEngine.GameObject, "transform"), UnityEngine.Transform, "position", b);
			i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			};
			if( execbinary("||", execbinary("<=", getinstance(SymbolKind.Field, this, MyScript, "fogStart"), 0, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), execbinary(">", getinstance(SymbolKind.Field, this, MyScript, "t"), 1, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct) ){
				setinstance(SymbolKind.Field, this, MyScript, "fogStart", getexternstatic(SymbolKind.Property, UnityEngine.Time, "time"));
				local(__old_val_52_12_52_51); __old_val_52_12_52_51 = getinstance(SymbolKind.Field, this, MyScript, "bgCurrent");
				setinstance(SymbolKind.Field, this, MyScript, "bgCurrent", getexterninstancestructmember(SymbolKind.Property, getexternstatic(SymbolKind.Property, UnityEngine.Camera, "main"), UnityEngine.Camera, "backgroundColor"));
				local(__new_val_52_12_52_51); __new_val_52_12_52_51 = getinstance(SymbolKind.Field, this, MyScript, "bgCurrent");
				recycleandkeepstructvalue(UnityEngine.Color, __old_val_52_12_52_51, __new_val_52_12_52_51);
				local(ix); ix = callexternstatic(UnityEngine.Random, "Range", dslstrtocsstr("UnityEngine.Random:Range__Int32__Int32__Int32"), 0, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, MyScript, "colors"), System.Array, "Length"));
				local(__old_val_54_12_54_32); __old_val_54_12_54_32 = getinstance(SymbolKind.Field, this, MyScript, "bgColor");
				setinstance(SymbolKind.Field, this, MyScript, "bgColor", getinstance(SymbolKind.Field, this, MyScript, "colors")[ix + 1]);
				local(__new_val_54_12_54_32); __new_val_54_12_54_32 = getinstance(SymbolKind.Field, this, MyScript, "bgColor");
				recycleandkeepstructvalue(UnityEngine.Color, __old_val_54_12_54_32, __new_val_54_12_54_32);
			};
			setinstance(SymbolKind.Field, this, MyScript, "t", execbinary("/", ( execbinary("-", getexternstatic(SymbolKind.Property, UnityEngine.Time, "time"), getinstance(SymbolKind.Field, this, MyScript, "fogStart"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), 10, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct));
			getexterninstancestructmember(SymbolKind.Property, getexternstatic(SymbolKind.Property, UnityEngine.Camera, "main"), UnityEngine.Camera, "backgroundColor") = callexternstaticreturnstruct(UnityEngine.Color, "Lerp", getinstance(SymbolKind.Field, this, MyScript, "bgCurrent"), getinstance(SymbolKind.Field, this, MyScript, "bgColor"), getinstance(SymbolKind.Field, this, MyScript, "t"));
		}options[needfuncinfo(true)];
		Call = deffunc(0)args(this, name, ...){
			local(args); args = params(System.Object, TypeKind.Class);
		}options[needfuncinfo(false)];
		TestCoroutine = wrapenumerable(deffunc(1)args(this){
			local(__method_ret_69_4_76_5);
			wrapyield(newexternobject(UnityEngine.WaitForSeconds, typeargs(), typekinds(), null, 10), false, true);
			local(i); i = 0;
			while( execbinary("<", i, 60, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				wrapyield(newexternobject(UnityEngine.WaitForSeconds, typeargs(), typekinds(), null, 1), false, true);
				callexternstatic(UnityEngine.Debug, "Log", dslstrtocsstr("UnityEngine.Debug:Log__Void__Object"), callexternstatic(System.String, "Format", dslstrtocsstr("System.String:Format__String__String__Object"), dslstrtocsstr("{0} seconds"), i));
			i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			};
			return(null);
		}options[needfuncinfo(false)]);
		Reset = deffunc(0)args(this){
			if( execbinary("!=", null, getinstance(SymbolKind.Field, this, MyScript, "cubes"), System.Object, System.Object, TypeKind.Class, TypeKind.Class) ){
				local(i); i = 0;
				while( execbinary("<", i, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, MyScript, "cubes"), System.Array, "Length"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
					callexternstatic(UnityEngine.Object, "Destroy", dslstrtocsstr("UnityEngine.Object:Destroy__Void__Object"), getinstance(SymbolKind.Field, this, MyScript, "cubes")[i + 1]);
				i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
				};
			};
			setinstance(SymbolKind.Field, this, MyScript, "cubes", newmultiarray(UnityEngine.GameObject, TypeKind.Class, null, 1, getinstance(SymbolKind.Field, this, MyScript, "max")));
			local(P); P = callexternstatic(UnityEngine.Resources, "Load", dslstrtocsstr("UnityEngine.Resources:Load__Object__String"), dslstrtocsstr("Particle System"));
			local(i); i = 0;
			while( execbinary("<", i, getinstance(SymbolKind.Field, this, MyScript, "max"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(cube); cube = callexternstatic(UnityEngine.GameObject, "CreatePrimitive", 3);
				setexterninstance(SymbolKind.Property, getexterninstance(SymbolKind.Property, cube, UnityEngine.GameObject, "transform"), UnityEngine.Transform, "position", newexternstruct(UnityEngine.Vector3, typeargs(), typekinds(), null, dslstrtocsstr("UnityEngine.Vector3:ctor__Void__Single__Single__Single"), execbinary("*", typecast(callexternstatic(UnityEngine.Mathf, "Cos", execbinary("/", execbinary("*", execbinary("*", i, 3.14159300, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, MyScript, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), System.Single, TypeKind.Struct), getinstance(SymbolKind.Field, this, MyScript, "r"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), execbinary("*", typecast(callexternstatic(UnityEngine.Mathf, "Sin", execbinary("/", execbinary("*", execbinary("*", i, 3.14159300, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, MyScript, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), System.Single, TypeKind.Struct), getinstance(SymbolKind.Field, this, MyScript, "r"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 0));
				callexterninstance(getexterninstance(SymbolKind.Property, cube, UnityEngine.GameObject, "transform"), UnityEngine.Transform, "SetParent", dslstrtocsstr("UnityEngine.Transform:SetParent__Void__Transform"), getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, MyScript, "root"), UnityEngine.GameObject, "transform"));
				local(mat); mat = getexterninstance(SymbolKind.Property, callexterninstance(cube, UnityEngine.GameObject, "GetComponent", dslstrtocsstr("UnityEngine.GameObject:GetComponent__Component__Type"), UnityEngine.Renderer), UnityEngine.Renderer, "material");
				local(box); box = callexterninstance(cube, UnityEngine.GameObject, "GetComponent", dslstrtocsstr("UnityEngine.GameObject:GetComponent__Component__Type"), typeof(UnityEngine.BoxCollider));
				callexternstatic(UnityEngine.Object, "Destroy", dslstrtocsstr("UnityEngine.Object:Destroy__Void__Object"), box);
				local(p); p = typeas(callexternstatic(UnityEngine.Object, "Instantiate", dslstrtocsstr("UnityEngine.Object:Instantiate__Object__Object__Vector3__Quaternion"), P, getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Quaternion, "identity")), UnityEngine.GameObject, TypeKind.Class);
				callexterninstance(getexterninstance(SymbolKind.Property, p, UnityEngine.GameObject, "transform"), UnityEngine.Transform, "SetParent", dslstrtocsstr("UnityEngine.Transform:SetParent__Void__Transform"), getexterninstance(SymbolKind.Property, cube, UnityEngine.GameObject, "transform"));
				local(ix); ix = callexternstatic(UnityEngine.Random, "Range", dslstrtocsstr("UnityEngine.Random:Range__Int32__Int32__Int32"), 0, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, MyScript, "colors"), System.Array, "Length"));
				setexterninstance(SymbolKind.Property, mat, UnityEngine.Material, "color", getinstance(SymbolKind.Field, this, MyScript, "colors")[ix + 1]);
				getinstance(SymbolKind.Field, this, MyScript, "cubes")[i + 1] = cube;
			i = execbinary("+", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			};
		}options[needfuncinfo(true)];
		ctor = deffunc(0)args(this){
			callinstance(this, MyScript, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, MyScript, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, MyScript, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, MyScript, "bgCurrent", newexternstruct(UnityEngine.Color, typeargs(), typekinds(), null));
			recycleandkeepstructvalue(UnityEngine.Color, nil, getinstance(SymbolKind.Field, this, MyScript, "bgCurrent"));
			setinstance(SymbolKind.Field, this, MyScript, "bgColor", newexternstruct(UnityEngine.Color, typeargs(), typekinds(), null));
			recycleandkeepstructvalue(UnityEngine.Color, nil, getinstance(SymbolKind.Field, this, MyScript, "bgColor"));
			setinstance(SymbolKind.Field, this, MyScript, "colors", literalarray(UnityEngine.Color, TypeKind.Struct, getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "red"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "blue"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "green"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "cyan"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "grey"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "white"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "yellow"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "magenta"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "black")));
		}options[needfuncinfo(true)];
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



