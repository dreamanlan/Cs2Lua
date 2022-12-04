using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_FormatSwizzle : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.FormatSwizzle");
		addMember(l,0,"FormatSwizzleR");
		addMember(l,1,"FormatSwizzleG");
		addMember(l,2,"FormatSwizzleB");
		addMember(l,3,"FormatSwizzleA");
		addMember(l,4,"FormatSwizzle0");
		addMember(l,5,"FormatSwizzle1");
		LuaDLL.lua_pop(l, 1);
	}
}
