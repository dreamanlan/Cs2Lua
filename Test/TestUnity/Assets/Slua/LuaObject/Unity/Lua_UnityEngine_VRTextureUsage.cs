using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_VRTextureUsage : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.VRTextureUsage");
		addMember(l,0,"None");
		addMember(l,1,"OneEye");
		addMember(l,2,"TwoEyes");
		addMember(l,3,"DeviceSpecific");
		LuaDLL.lua_pop(l, 1);
	}
}
