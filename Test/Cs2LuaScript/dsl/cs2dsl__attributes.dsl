attributes(Cs2LuaType){
	method(GetFullName){
		attribute(Cs2Dsl.TranslateToAttribute([scriptModuleName("Cs2LuaTypeImpl"), targetMethodName("Cs2LuaTypeImpl.GetFullName")], []));
	};
	method(GetName){
		attribute(Cs2Dsl.TranslateToAttribute([scriptModuleName("Cs2LuaTypeImpl"), targetMethodName("Cs2LuaTypeImpl.GetName")], []));
	};
};
attributes(Program){
	class{
		attribute(Cs2Dsl.RequireAttribute([scriptModuleNames(["lualib_valuetypescript", "lualib_basic"])], []));
		attribute(Cs2Dsl.EntryAttribute([], []));
	};
};
