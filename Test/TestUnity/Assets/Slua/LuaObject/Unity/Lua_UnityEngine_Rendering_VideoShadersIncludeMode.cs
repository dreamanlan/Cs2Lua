using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_VideoShadersIncludeMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.VideoShadersIncludeMode");
		addMember(l,0,"Never");
		addMember(l,1,"Referenced");
		addMember(l,2,"Always");
		LuaDLL.lua_pop(l, 1);
	}
}
