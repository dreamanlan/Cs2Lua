using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_DrawRendererFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.DrawRendererFlags");
		addMember(l,0,"None");
		addMember(l,1,"EnableDynamicBatching");
		addMember(l,2,"EnableInstancing");
		LuaDLL.lua_pop(l, 1);
	}
}
