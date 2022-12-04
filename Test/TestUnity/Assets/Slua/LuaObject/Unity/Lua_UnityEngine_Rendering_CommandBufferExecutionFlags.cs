using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_CommandBufferExecutionFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.CommandBufferExecutionFlags");
		addMember(l,0,"None");
		addMember(l,2,"AsyncCompute");
		LuaDLL.lua_pop(l, 1);
	}
}
