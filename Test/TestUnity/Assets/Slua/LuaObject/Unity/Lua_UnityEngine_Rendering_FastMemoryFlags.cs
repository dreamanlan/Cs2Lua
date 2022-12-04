using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_FastMemoryFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.FastMemoryFlags");
		addMember(l,0,"None");
		addMember(l,1,"SpillTop");
		addMember(l,2,"SpillBottom");
		LuaDLL.lua_pop(l, 1);
	}
}
