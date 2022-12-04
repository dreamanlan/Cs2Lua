using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_CameraLateLatchMatrixType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.CameraLateLatchMatrixType");
		addMember(l,0,"View");
		addMember(l,1,"InverseView");
		addMember(l,2,"ViewProjection");
		addMember(l,3,"InverseViewProjection");
		LuaDLL.lua_pop(l, 1);
	}
}
