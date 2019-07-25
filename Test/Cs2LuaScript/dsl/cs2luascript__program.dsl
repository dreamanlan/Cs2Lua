require("cs2dsl__lualib");
require("cs2dsl__attributes");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(Cs2LuaScript.Program) {
	static_methods {
		Init = function(){
			comment("使用c#代码时需要的初始化（平台相关代码，不会转换为lua代码，cs2lua在翻译时会添加__DSL__宏，可以据此设定代码是否要转换为lua）");
			comment("公共初始化（也就是逻辑相关的代码）");
		};
		Main = function(args){
			callstatic(Cs2LuaScript.Program, "Init");
		};
		cctor = function(){
			callstatic(Cs2LuaScript.Program, "__cctor");
		};
		__cctor = function(){
			if(Cs2LuaScript.Program.__cctor_called){
				return;
			}else{
				Cs2LuaScript.Program.__cctor_called = true;
			};
		};
	};
	static_fields {
		__attributes = Cs2LuaScript__Program__Attrs;
		__cctor_called = false;
	};
	static_props {};
	static_events {};

};



defineentry(Cs2LuaScript.Program);
