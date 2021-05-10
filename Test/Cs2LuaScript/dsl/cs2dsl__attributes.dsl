attributes(Cs2LuaType){
	method(GetFullName){
		attribute(Cs2Dsl.TranslateToAttribute([luaModuleName("Cs2LuaTypeImpl"), targetMethodName("Cs2LuaTypeImpl.GetFullName")], []));
	};
	method(GetName){
		attribute(Cs2Dsl.TranslateToAttribute([luaModuleName("Cs2LuaTypeImpl"), targetMethodName("Cs2LuaTypeImpl.GetName")], []));
	};
};
attributes(Program){
	class{
		attribute(Cs2Dsl.RequireAttribute([luaModuleNames(["lualib_valuetypescript", "lualib_basic"])], []));
		attribute(Cs2Dsl.EntryAttribute([], []));
	};
};
