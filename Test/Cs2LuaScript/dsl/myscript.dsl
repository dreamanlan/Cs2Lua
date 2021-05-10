require("cs2dsl__syslib");
require("cs2dsl__attributes");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("luastring");

class(MyScript) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(MyScript, "g_MyScript", typeargs(), typekinds(), "ctor", 0, null, ...);
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
			callexternstatic(UnityEngine.Debug, "Log__Object", s);
			callexterninstance(mb, MonoBehaviourProxy, "StartCoroutine", callinstance(this, MyScript, "TestCoroutine"));
			setinstance(SymbolKind.Field, this, MyScript, "root", newexternobject(UnityEngine.GameObject, "g_UnityEngine_GameObject", typeargs(), typekinds(), "ctor__String", 0, null, dslstrtocsstr("root")));
			local(slider); slider = typeas(callexterninstance(callexternstatic(UnityEngine.GameObject, "Find", dslstrtocsstr("Canvas/Slider")), UnityEngine.GameObject, "GetComponent__Type", typeof(UnityEngine.UI.Slider)), UnityEngine.UI.Slider, TypeKind.Class);
			local(counttxt); counttxt = typeas(callexterninstance(callexternstatic(UnityEngine.GameObject, "Find", dslstrtocsstr("Canvas/Count")), UnityEngine.GameObject, "GetComponent__Type", typeof(UnityEngine.UI.Text)), UnityEngine.UI.Text, TypeKind.Class);
			callexterninstance(getexterninstance(SymbolKind.Property, slider, UnityEngine.UI.Slider, "onValueChanged"), UnityEngine.Events.UnityEvent_T0, "AddListener", deffunc(0)args(v){
				callinstance(this, MyScript, "Reset");
				getexterninstance(SymbolKind.Property, counttxt, UnityEngine.UI.Text, "text") = callstatic(LuaString, "Format__String__Object", "cube:{0}", v);
				setinstance(SymbolKind.Field, this, MyScript, "max", typecast(v, System.Int32, TypeKind.Struct));
			}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(v, System.Single, TypeKind.Struct, 0, true)]);
			callinstance(this, MyScript, "Reset");
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(obj, UnityEngine.GameObject, TypeKind.Class, 0, true), paramtype(mb, MonoBehaviourProxy, TypeKind.Class, 0, true)];
		Update = deffunc(0)args(this){
			local(i); i = 0;
			while( execbinary("<", i, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, MyScript, "cubes"), System.Array, "Length"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(offset); offset = condexpfunc(true, retval_43_25_43_44, condexp_43_25_43_44, MyScript, false, i){condexp(execbinary("==", execbinary("%", i, 2, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), true, 5, true, -5);}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true), paramtype(i, System.Int32, Struct, 0, true)];
				local(nr); nr = execbinary("+", getinstance(SymbolKind.Field, this, MyScript, "r"), execbinary("*", callexternstatic(UnityEngine.Mathf, "Sin", getexternstatic(SymbolKind.Property, UnityEngine.Time, "time")), offset, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct);
				local(angle); angle = condexpfunc(true, retval_45_24_45_51, condexp_45_24_45_51, MyScript, false, i){condexp(execbinary("==", execbinary("%", i, 2, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct), false, function(){ funcobjret(getexternstatic(SymbolKind.Property, UnityEngine.Time, "time")); }, true, -5);}options[needfuncinfo(false), rettype(return, System.Single, TypeKind.Struct, 0, true), paramtype(i, System.Int32, Struct, 0, true)];
				local(b); b = newexternstruct(UnityEngine.Vector3, "g_UnityEngine_Vector3", typeargs(), typekinds(), "ctor__Single__Single__Single", 0, null, typecast(( execbinary("*", callexternstatic(UnityEngine.Mathf, "Cos", execbinary("+", execbinary("/", execbinary("*", execbinary("*", i, 3.14159300, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, MyScript, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), angle, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), nr, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), System.Single, TypeKind.Struct), typecast(( execbinary("*", callexternstatic(UnityEngine.Mathf, "Sin", execbinary("+", execbinary("/", execbinary("*", execbinary("*", i, 3.14159300, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, MyScript, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), angle, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), nr, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), System.Single, TypeKind.Struct), 0);
				setexterninstance(SymbolKind.Property, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, MyScript, "cubes")[i + 1], UnityEngine.GameObject, "transform"), UnityEngine.Transform, "position", b);
			i = execbinary("+", i, 1, null, null, null, null);
			};
			if( execbinary("||", execbinary("<=", getinstance(SymbolKind.Field, this, MyScript, "fogStart"), 0, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), execbinary(">", getinstance(SymbolKind.Field, this, MyScript, "t"), 1, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), System.Boolean, System.Boolean, TypeKind.Struct, TypeKind.Struct), 50_8_55_9 ){
				setinstance(SymbolKind.Field, this, MyScript, "fogStart", getexternstatic(SymbolKind.Property, UnityEngine.Time, "time"));
				local(__old_val_52_12_52_51); __old_val_52_12_52_51 = getinstance(SymbolKind.Field, this, MyScript, "bgCurrent");
				setinstance(SymbolKind.Field, this, MyScript, "bgCurrent", getexterninstancestructmember(SymbolKind.Property, getexternstatic(SymbolKind.Property, UnityEngine.Camera, "main"), UnityEngine.Camera, "backgroundColor"));
				local(__new_val_52_12_52_51); __new_val_52_12_52_51 = getinstance(SymbolKind.Field, this, MyScript, "bgCurrent");
				recycleandkeepstructvalue(UnityEngine.Color, __old_val_52_12_52_51, __new_val_52_12_52_51);
				local(ix); ix = callexternstatic(UnityEngine.Random, "Range__Int32__Int32", 0, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, MyScript, "colors"), System.Array, "Length"));
				local(__old_val_54_12_54_32); __old_val_54_12_54_32 = getinstance(SymbolKind.Field, this, MyScript, "bgColor");
				setinstance(SymbolKind.Field, this, MyScript, "bgColor", arraygetstruct(false, SymbolKind.Field, UnityEngine.Color, getinstance(SymbolKind.Field, this, MyScript, "colors"), 1, ix + 1));
				getinstance(SymbolKind.Field, this, MyScript, "bgColor") = wrapexternstruct(getinstance(SymbolKind.Field, this, MyScript, "bgColor"), UnityEngine.Color);
				local(__new_val_54_12_54_32); __new_val_54_12_54_32 = getinstance(SymbolKind.Field, this, MyScript, "bgColor");
				recycleandkeepstructvalue(UnityEngine.Color, __old_val_54_12_54_32, __new_val_54_12_54_32);
			};
			setinstance(SymbolKind.Field, this, MyScript, "t", execbinary("/", ( execbinary("-", getexternstatic(SymbolKind.Property, UnityEngine.Time, "time"), getinstance(SymbolKind.Field, this, MyScript, "fogStart"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct) ), 10, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct));
			getexterninstancestructmember(SymbolKind.Property, getexternstatic(SymbolKind.Property, UnityEngine.Camera, "main"), UnityEngine.Camera, "backgroundColor") = callexternstaticreturnstruct(UnityEngine.Color, "Lerp", wrapexternstructargument(getinstance(SymbolKind.Field, this, MyScript, "bgCurrent"), UnityEngine.Color, OperationKind.FieldReference, SymbolKind.Field), wrapexternstructargument(getinstance(SymbolKind.Field, this, MyScript, "bgColor"), UnityEngine.Color, OperationKind.FieldReference, SymbolKind.Field), getinstance(SymbolKind.Field, this, MyScript, "t"));
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Call = deffunc(0)args(this, name, ...){
			local(args); args = params(System.Object, TypeKind.Class);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(name, System.String, TypeKind.Class, 0, true), paramtype(..., System.Object, TypeKind.Array, 0, true)];
		TestCoroutine = wrapenumerable(deffunc(1)args(this){
			local(__method_ret_69_4_76_5);
			wrapyield(newexternobject(UnityEngine.WaitForSeconds, "g_UnityEngine_WaitForSeconds", typeargs(), typekinds(), "ctor", 0, null, 10), false, true);
			local(i); i = 0;
			while( execbinary("<", i, 60, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				wrapyield(newexternobject(UnityEngine.WaitForSeconds, "g_UnityEngine_WaitForSeconds", typeargs(), typekinds(), "ctor", 0, null, 1), false, true);
				callexternstatic(UnityEngine.Debug, "Log__Object", callexternstatic(System.String, "Format__String__Object", dslstrtocsstr("{0} seconds"), i));
			i = execbinary("+", i, 1, null, null, null, null);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, System.Collections.IEnumerator, TypeKind.Interface, 0, true)]);
		Reset = deffunc(0)args(this){
			if( execbinary("!=", null, getinstance(SymbolKind.Field, this, MyScript, "cubes"), System.Object, System.Object, TypeKind.Class, TypeKind.Class), 79_8_83_9 ){
				local(i); i = 0;
				while( execbinary("<", i, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, MyScript, "cubes"), System.Array, "Length"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
					callexternstatic(UnityEngine.Object, "Destroy__Object", getinstance(SymbolKind.Field, this, MyScript, "cubes")[i + 1]);
				i = execbinary("+", i, 1, null, null, null, null);
				};
			};
			setinstance(SymbolKind.Field, this, MyScript, "cubes", newmultiarray(UnityEngine.GameObject, TypeKind.Class, null, 1, getinstance(SymbolKind.Field, this, MyScript, "max")));
			local(P); P = callexternstatic(UnityEngine.Resources, "Load__String", dslstrtocsstr("Particle System"));
			local(i); i = 0;
			while( execbinary("<", i, getinstance(SymbolKind.Field, this, MyScript, "max"), System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(cube); cube = callexternstatic(UnityEngine.GameObject, "CreatePrimitive", 3);
				setexterninstance(SymbolKind.Property, getexterninstance(SymbolKind.Property, cube, UnityEngine.GameObject, "transform"), UnityEngine.Transform, "position", newexternstruct(UnityEngine.Vector3, "g_UnityEngine_Vector3", typeargs(), typekinds(), "ctor__Single__Single__Single", 0, null, execbinary("*", typecast(callexternstatic(UnityEngine.Mathf, "Cos", execbinary("/", execbinary("*", execbinary("*", i, 3.14159300, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, MyScript, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), System.Single, TypeKind.Struct), getinstance(SymbolKind.Field, this, MyScript, "r"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), execbinary("*", typecast(callexternstatic(UnityEngine.Mathf, "Sin", execbinary("/", execbinary("*", execbinary("*", i, 3.14159300, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 2, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, MyScript, "max"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct)), System.Single, TypeKind.Struct), getinstance(SymbolKind.Field, this, MyScript, "r"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 0));
				callexterninstance(getexterninstance(SymbolKind.Property, cube, UnityEngine.GameObject, "transform"), UnityEngine.Transform, "SetParent__Transform", getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, MyScript, "root"), UnityEngine.GameObject, "transform"));
				local(mat); mat = getexterninstance(SymbolKind.Property, callexterninstance(cube, UnityEngine.GameObject, "GetComponent__Type", UnityEngine.Renderer), UnityEngine.Renderer, "material");
				local(box); box = callexterninstance(cube, UnityEngine.GameObject, "GetComponent__Type", typeof(UnityEngine.BoxCollider));
				callexternstatic(UnityEngine.Object, "Destroy__Object", box);
				local(p); p = typeas(callexternstatic(UnityEngine.Object, "Instantiate__Object__Vector3__Quaternion", P, getexternstaticstructmember(SymbolKind.Property, UnityEngine.Vector3, "zero"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Quaternion, "identity")), UnityEngine.GameObject, TypeKind.Class);
				callexterninstance(getexterninstance(SymbolKind.Property, p, UnityEngine.GameObject, "transform"), UnityEngine.Transform, "SetParent__Transform", getexterninstance(SymbolKind.Property, cube, UnityEngine.GameObject, "transform"));
				local(ix); ix = callexternstatic(UnityEngine.Random, "Range__Int32__Int32", 0, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, MyScript, "colors"), System.Array, "Length"));
				setexterninstance(SymbolKind.Property, mat, UnityEngine.Material, "color", arraygetstruct(false, SymbolKind.Field, UnityEngine.Color, getinstance(SymbolKind.Field, this, MyScript, "colors"), 1, ix + 1));
				getinstance(SymbolKind.Field, this, MyScript, "cubes")[i + 1] = cube;
			i = execbinary("+", i, 1, null, null, null, null);
			};
		}options[needfuncinfo(true), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		ctor = deffunc(0)args(this){
			callinstance(this, MyScript, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, MyScript, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, MyScript, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, MyScript, "bgCurrent", newexternstruct(UnityEngine.Color, "g_UnityEngine_Color", typeargs(), typekinds(), "ctor", 0, null));
			recycleandkeepstructvalue(UnityEngine.Color, nil, getinstance(SymbolKind.Field, this, MyScript, "bgCurrent"));
			setinstance(SymbolKind.Field, this, MyScript, "bgColor", newexternstruct(UnityEngine.Color, "g_UnityEngine_Color", typeargs(), typekinds(), "ctor", 0, null));
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
};



