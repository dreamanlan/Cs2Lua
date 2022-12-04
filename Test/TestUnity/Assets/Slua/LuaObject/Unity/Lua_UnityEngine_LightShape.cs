using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightShape : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightShape");
		addMember(l,0,"Cone");
		addMember(l,1,"Pyramid");
		addMember(l,2,"Box");
		LuaDLL.lua_pop(l, 1);
	}
}
