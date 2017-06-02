using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ProceduralLoadingBehavior : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ProceduralLoadingBehavior");
		addMember(l,0,"DoNothing");
		addMember(l,1,"Generate");
		addMember(l,2,"BakeAndKeep");
		addMember(l,3,"BakeAndDiscard");
		addMember(l,4,"Cache");
		addMember(l,5,"DoNothingAndCache");
		LuaDLL.lua_pop(l, 1);
	}
}
