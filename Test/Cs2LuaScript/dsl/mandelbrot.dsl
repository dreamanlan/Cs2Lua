require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(Mandelbrot) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(Mandelbrot, typeargs(), typekinds(), "ctor", null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(Mandelbrot, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(Mandelbrot.__cctor_called){
				return();
			}else{
				Mandelbrot.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		Init = deffunc(0)args(this, obj, mb){
			setinstance(SymbolKind.Field, this, Mandelbrot, "root", newexternobject(UnityEngine.GameObject, typeargs(), typekinds(), "ctor__String", null, dslstrtocsstr("mandelbrot")));
			callinstance(this, Mandelbrot, "Exec");
		}options[needfuncinfo(false)];
		Call = deffunc(0)args(this, name, ...){
			local(args); args = params(System.Object, TypeKind.Class);
		}options[needfuncinfo(false)];
		Exec = deffunc(0)args(this){
			local(width); width = 50;
			local(height); height = width;
			local(maxiter); maxiter = 50;
			local(limit); limit = 4.0000000000000000;
			local(y); y = 0;
			while( execbinary("<", y, height, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(Ci); Ci = execbinary("-", execbinary("/", execbinary("*", 2.0000000000000000, y, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), height, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), 1.0000000000000000, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct);
				local(x); x = 0;
				while( execbinary("<", x, width, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
					local(Zr); Zr = 0.0000000000000000;
					local(Zi); Zi = 0.0000000000000000;
					local(Cr); Cr = execbinary("-", execbinary("/", execbinary("*", 2.0000000000000000, x, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), width, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), 1.5000000000000000, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct);
					local(i); i = maxiter;
					local(isInside); isInside = true;
					do{
						local(Tr); Tr = execbinary("+", execbinary("-", execbinary("*", Zr, Zr, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), execbinary("*", Zi, Zi, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), Cr, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct);
						Zi = execbinary("+", execbinary("*", execbinary("*", 2.0000000000000000, Zr, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), Zi, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), Ci, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct);
						Zr = Tr;
						if( execbinary(">", execbinary("+", execbinary("*", Zr, Zr, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), execbinary("*", Zi, Zi, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), limit, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct) ){
							isInside = false;
							block{
							break;
							};
						};
					}while(execbinary(">", prefixoperator(true, i, execbinary("-", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct)), 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
					if( isInside ){
						callinstance(this, Mandelbrot, "DrawCube", x, y, width, height);
					};
				x = execbinary("+", x, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
				};
			y = execbinary("+", y, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			};
		}options[needfuncinfo(false)];
		DrawCube = deffunc(0)args(this, x, y, w, h){
			local(cube); cube = callexternstatic(UnityEngine.GameObject, "CreatePrimitive", 3);
			setexterninstance(SymbolKind.Property, getexterninstance(SymbolKind.Property, cube, UnityEngine.GameObject, "transform"), UnityEngine.Transform, "position", newexternstruct(UnityEngine.Vector3, typeargs(), typekinds(), "ctor__Single__Single__Single", null, execbinary("/", execbinary("*", execbinary("*", x, getinstance(SymbolKind.Field, this, Mandelbrot, "r"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, Mandelbrot, "scale"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), w, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), execbinary("-", execbinary("/", execbinary("*", execbinary("*", y, getinstance(SymbolKind.Field, this, Mandelbrot, "r"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(SymbolKind.Field, this, Mandelbrot, "scale"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), h, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 12, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 0));
			callexterninstance(getexterninstance(SymbolKind.Property, cube, UnityEngine.GameObject, "transform"), UnityEngine.Transform, "SetParent__Transform", getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, Mandelbrot, "root"), UnityEngine.GameObject, "transform"));
			local(mat); mat = getexterninstance(SymbolKind.Property, callexterninstance(cube, UnityEngine.GameObject, "GetComponent__Type", UnityEngine.Renderer), UnityEngine.Renderer, "material");
			local(ix); ix = callexternstatic(UnityEngine.Random, "Range__Int32__Int32", 0, getexterninstance(SymbolKind.Property, getinstance(SymbolKind.Field, this, Mandelbrot, "colors"), System.Array, "Length"));
			setexterninstance(SymbolKind.Property, mat, UnityEngine.Material, "color", getinstance(SymbolKind.Field, this, Mandelbrot, "colors")[ix + 1]);
		}options[needfuncinfo(true)];
		ctor = deffunc(0)args(this){
			callinstance(this, Mandelbrot, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, Mandelbrot, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, Mandelbrot, "__ctor_called", true);
			};
			setinstance(SymbolKind.Field, this, Mandelbrot, "colors", literalarray(UnityEngine.Color, TypeKind.Struct, getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "red"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "blue"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "green"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "cyan"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "grey"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "white"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "yellow"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "magenta"), getexternstaticstructmember(SymbolKind.Property, UnityEngine.Color, "black")));
		}options[needfuncinfo(true)];
	};
	instance_fields {
		root = null;
		colors = null;
		r = 10;
		scale = 3.00000000;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"IStartupPlugin";
	};

	class_info(TypeKind.Class, Accessibility.Internal) {
	};
	method_info {
		Init(MethodKind.Ordinary, Accessibility.Public){
		};
		Call(MethodKind.Ordinary, Accessibility.Public){
		};
		Exec(MethodKind.Ordinary, Accessibility.Private){
		};
		DrawCube(MethodKind.Ordinary, Accessibility.Private){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
	property_info {};
	event_info {};
	field_info {
		root(Accessibility.Private){
		};
		colors(Accessibility.Private){
		};
		r(Accessibility.Private){
		};
		scale(Accessibility.Private){
		};
	};
};
comment("Mandelbrot.Exec();");



