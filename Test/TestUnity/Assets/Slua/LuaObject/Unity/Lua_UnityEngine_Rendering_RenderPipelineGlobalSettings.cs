using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RenderPipelineGlobalSettings : LuaObject {
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.RenderPipelineGlobalSettings");
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.RenderPipelineGlobalSettings),typeof(UnityEngine.ScriptableObject));
	}
}
