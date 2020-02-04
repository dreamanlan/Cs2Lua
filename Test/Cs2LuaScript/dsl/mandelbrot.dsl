require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(Mandelbrot) {
	static_methods {
		__new_object = function(...){
			return(newobject(Mandelbrot, typeargs(), typekinds(), "ctor", null, ...));
		};
		cctor = function(){
			callstatic(Mandelbrot, "__cctor");
		};
		__cctor = function(){
			if(Mandelbrot.__cctor_called){
				return;
			}else{
				Mandelbrot.__cctor_called = true;
			};
		};
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		Init = function(this, obj, mb){
			setinstance(this, "root", newexternobject(UnityEngine.GameObject, typeargs(), typekinds(), null, "UnityEngine.GameObject:ctor__String", "mandelbrot"));
			callinstance(this, "Exec");
		};
		Call = function(this, name, ...){
			local{args = params(0);};
		};
		Exec = function(this){
			local(width); width = 50;
			local(height); height = width;
			local(maxiter); maxiter = 50;
			local(limit); limit = 4.00;
			local(y); y = 0;
			while( execbinary("<", y, height, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
				local(Ci); Ci = execbinary("-", execbinary("/", execbinary("*", 2.00, y, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), height, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), 1.00, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct);
				local(x); x = 0;
				while( execbinary("<", x, width, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct) ){
					local(Zr); Zr = 0.00;
					local(Zi); Zi = 0.00;
					local(Cr); Cr = execbinary("-", execbinary("/", execbinary("*", 2.00, x, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), width, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), 1.50, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct);
					local(i); i = maxiter;
					local(isInside); isInside = true;
					do{
						local(Tr); Tr = execbinary("+", execbinary("-", execbinary("*", Zr, Zr, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), execbinary("*", Zi, Zi, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), Cr, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct);
						Zi = execbinary("+", execbinary("*", execbinary("*", 2.00, Zr, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), Zi, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), Ci, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct);
						Zr = Tr;
						if( execbinary(">", execbinary("+", execbinary("*", Zr, Zr, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), execbinary("*", Zi, Zi, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), System.Double, System.Double, TypeKind.Struct, TypeKind.Struct), limit, System.Double, System.Double, TypeKind.Struct, TypeKind.Struct) ){
							isInside = false;
							break;
						};
					}while(execbinary(">", (function(){ i = execbinary("-", i, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct); return(i); })(), 0, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct));
					if( isInside ){
						callinstance(this, "DrawCube", x, y, width, height);
					};
				x = execbinary("+", x, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
				};
			y = execbinary("+", y, 1, System.Int32, System.Int32, TypeKind.Struct, TypeKind.Struct);
			};
		};
		DrawCube = function(this, x, y, w, h){
			local(cube); cube = callstatic(UnityEngine.GameObject, "CreatePrimitive", 3);
			setinstance(getinstance(cube, "transform"), "position", newexternobject(UnityEngine.Vector3, typeargs(), typekinds(), null, "UnityEngine.Vector3:ctor__Single__Single__Single", execbinary("/", execbinary("*", execbinary("*", x, getinstance(this, "r"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(this, "scale"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), w, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), execbinary("-", execbinary("/", execbinary("*", execbinary("*", y, getinstance(this, "r"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), getinstance(this, "scale"), System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), h, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 12, System.Single, System.Single, TypeKind.Struct, TypeKind.Struct), 0));
			callinstance(getinstance(cube, "transform"), "SetParent", "UnityEngine.Transform:SetParent__Transform", getinstance(getinstance(this, "root"), "transform"));
			local(mat); mat = getinstance(callinstance(cube, "GetComponent", "UnityEngine.GameObject:GetComponent__Type", UnityEngine.Renderer), "material");
			local(ix); ix = callstatic(UnityEngine.Random, "Range", "UnityEngine.Random:Range__Int32__Int32", 0, getinstance(getinstance(this, "colors"), "Length"));
			setinstance(mat, "color", getinstance(this, "colors")[ix + 1]);
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
			this.colors = literalarray(UnityEngine.Color, getstatic(UnityEngine.Color, "red"), getstatic(UnityEngine.Color, "blue"), getstatic(UnityEngine.Color, "green"), getstatic(UnityEngine.Color, "cyan"), getstatic(UnityEngine.Color, "grey"), getstatic(UnityEngine.Color, "white"), getstatic(UnityEngine.Color, "yellow"), getstatic(UnityEngine.Color, "magenta"), getstatic(UnityEngine.Color, "black"));
		};
	};
	instance_fields {
		root = null;
		colors = null;
		r = 10;
		scale = 3.00;
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"IStartupPlugin";
	};
	interface_map {
		IStartupPlugin_Init = "Init";
		IStartupPlugin_Call = "Call";
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



