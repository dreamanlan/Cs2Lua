using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_ReflectionProbeSortOptions : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.ReflectionProbeSortOptions");
		addMember(l,0,"None");
		addMember(l,1,"Importance");
		addMember(l,2,"Size");
		addMember(l,3,"ImportanceThenSize");
		LuaDLL.lua_pop(l, 1);
	}
}
