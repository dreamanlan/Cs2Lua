using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystemMeshShapeType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ParticleSystemMeshShapeType");
		addMember(l,0,"Vertex");
		addMember(l,1,"Edge");
		addMember(l,2,"Triangle");
		LuaDLL.lua_pop(l, 1);
	}
}
