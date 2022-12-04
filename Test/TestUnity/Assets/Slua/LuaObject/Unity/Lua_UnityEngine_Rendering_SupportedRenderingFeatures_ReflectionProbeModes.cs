using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SupportedRenderingFeatures_ReflectionProbeModes : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModes");
		addMember(l,0,"None");
		addMember(l,1,"Rotation");
		LuaDLL.lua_pop(l, 1);
	}
}
