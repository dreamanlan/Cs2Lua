using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_DrawRendererSortMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.DrawRendererSortMode");
		addMember(l,0,"Perspective");
		addMember(l,1,"Orthographic");
		addMember(l,2,"CustomAxis");
		LuaDLL.lua_pop(l, 1);
	}
}
