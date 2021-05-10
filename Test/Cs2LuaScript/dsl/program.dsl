require("cs2dsl__syslib");
require("cs2dsl__attributes");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("lualib_valuetypescript");
require("lualib_basic");

class(Program) {
	static_methods {
		Init = deffunc(0)args(){
			comment("使用c#代码时需要的初始化（平台相关代码，不会转换为lua代码，cs2lua在翻译时会添加__DSL__宏，可以据此设定代码是否要转换为lua）");
			comment("公共初始化（也就是逻辑相关的代码）");
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Main = deffunc(0)args(args){
			callstatic(Program, "Init");
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(args, System.String, TypeKind.Array, 0, true)];
		cctor = deffunc(0)args(){
			callstatic(Program, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(Program.__cctor_called){
				return();
			}else{
				Program.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__attributes = Program__Attrs;
		__cctor_called = false;
	};
	static_props {};
	static_events {};

};



defineentry(Program);
