require("cs2lua__utility");
require("cs2lua__attributes");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");

class(Cs2LuaScript.Program) {
	static_methods {
		Init = function(){
			comment("使用c#代码时需要的初始化（平台相关代码，不会转换为lua代码，cs2lua在翻译时会添加__LUA__宏，可以据此设定代码是否要转换为lua）");
			comment("公共初始化（也就是逻辑相关的代码）");
		};
		Main = function(args){
			callstatic(Cs2LuaScript.Program, "Init");
		};
		cctor = function(){
		};
	};
	static_fields {
		__attributes = Cs2LuaScript__Program__Attrs;
	};
	static_props {};
	static_events {};

};



defineentry(Cs2LuaScript.Program);
