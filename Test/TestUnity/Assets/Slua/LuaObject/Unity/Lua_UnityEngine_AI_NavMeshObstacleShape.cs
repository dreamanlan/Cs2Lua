using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_NavMeshObstacleShape : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AI.NavMeshObstacleShape");
		addMember(l,0,"Capsule");
		addMember(l,1,"Box");
		LuaDLL.lua_pop(l, 1);
	}
}
