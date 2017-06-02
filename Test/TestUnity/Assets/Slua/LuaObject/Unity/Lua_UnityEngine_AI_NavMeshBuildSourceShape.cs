using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_NavMeshBuildSourceShape : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AI.NavMeshBuildSourceShape");
		addMember(l,0,"Mesh");
		addMember(l,1,"Terrain");
		addMember(l,2,"Box");
		addMember(l,3,"Sphere");
		addMember(l,4,"Capsule");
		addMember(l,5,"ModifierBox");
		LuaDLL.lua_pop(l, 1);
	}
}
