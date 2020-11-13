attributes(Cs2LuaType){
	method(GetFullName){
		attribute(Cs2Dsl.TranslateToAttribute([luaModuleName("Cs2LuaTypeImpl"), targetMethodName("Cs2LuaTypeImpl.GetFullName")], []));
	};
};
attributes(Program){
	class{
		attribute(Cs2Dsl.RequireAttribute([luaModuleNames(["lualib_valuetypescript"])], []));
		attribute(Cs2Dsl.EntryAttribute([], []));
	};
};
