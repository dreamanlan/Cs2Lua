using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RayTracingMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.RayTracingMode");
		addMember(l,0,"Off");
		addMember(l,1,"Static");
		addMember(l,2,"DynamicTransform");
		addMember(l,3,"DynamicGeometry");
		LuaDLL.lua_pop(l, 1);
	}
}
