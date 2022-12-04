using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_GizmoSubset : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.GizmoSubset");
		addMember(l,0,"PreImageEffects");
		addMember(l,1,"PostImageEffects");
		LuaDLL.lua_pop(l, 1);
	}
}
