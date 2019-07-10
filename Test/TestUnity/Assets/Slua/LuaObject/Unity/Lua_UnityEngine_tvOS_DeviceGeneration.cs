using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_tvOS_DeviceGeneration : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.tvOS.DeviceGeneration");
		addMember(l,0,"Unknown");
		addMember(l,1001,"AppleTV1Gen");
		addMember(l,1002,"AppleTV2Gen");
		LuaDLL.lua_pop(l, 1);
	}
}
