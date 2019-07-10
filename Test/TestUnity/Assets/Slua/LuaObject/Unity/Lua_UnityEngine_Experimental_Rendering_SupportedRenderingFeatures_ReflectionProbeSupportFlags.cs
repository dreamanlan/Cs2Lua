using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_SupportedRenderingFeatures_ReflectionProbeSupportFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.SupportedRenderingFeatures.ReflectionProbeSupportFlags");
		addMember(l,0,"None");
		addMember(l,1,"Rotation");
		LuaDLL.lua_pop(l, 1);
	}
}
