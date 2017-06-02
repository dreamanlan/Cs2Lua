using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_ObstacleAvoidanceType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.AI.ObstacleAvoidanceType");
		addMember(l,0,"NoObstacleAvoidance");
		addMember(l,1,"LowQualityObstacleAvoidance");
		addMember(l,2,"MedQualityObstacleAvoidance");
		addMember(l,3,"GoodQualityObstacleAvoidance");
		addMember(l,4,"HighQualityObstacleAvoidance");
		LuaDLL.lua_pop(l, 1);
	}
}
