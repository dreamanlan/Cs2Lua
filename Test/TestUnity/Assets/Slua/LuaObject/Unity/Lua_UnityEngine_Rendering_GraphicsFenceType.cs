using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_GraphicsFenceType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.GraphicsFenceType");
		addMember(l,0,"AsyncQueueSynchronisation");
		addMember(l,1,"CPUSynchronisation");
		LuaDLL.lua_pop(l, 1);
	}
}
