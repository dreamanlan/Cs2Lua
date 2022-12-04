using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ConfigurableJointMotion : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ConfigurableJointMotion");
		addMember(l,0,"Locked");
		addMember(l,1,"Limited");
		addMember(l,2,"Free");
		LuaDLL.lua_pop(l, 1);
	}
}
