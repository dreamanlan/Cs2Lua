using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure_RayTracingModeMask : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RayTracingModeMask");
		addMember(l,0,"Nothing");
		addMember(l,2,"Static");
		addMember(l,4,"DynamicTransform");
		addMember(l,8,"DynamicGeometry");
		addMember(l,14,"Everything");
		LuaDLL.lua_pop(l, 1);
	}
}
