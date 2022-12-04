using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RayTracingSubMeshFlags : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags");
		addMember(l,0,"Disabled");
		addMember(l,1,"Enabled");
		addMember(l,2,"ClosestHitOnly");
		addMember(l,4,"UniqueAnyHitCalls");
		LuaDLL.lua_pop(l, 1);
	}
}
