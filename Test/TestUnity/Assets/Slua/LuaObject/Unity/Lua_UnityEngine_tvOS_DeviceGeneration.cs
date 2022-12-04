using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_tvOS_DeviceGeneration : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.tvOS.DeviceGeneration");
		addMember(l,0,"Unknown");
		addMember(l,1001,"AppleTV1Gen");
		addMember(l,1001,"AppleTVHD");
		addMember(l,1002,"AppleTV2Gen");
		addMember(l,1002,"AppleTV4K");
		addMember(l,1003,"AppleTV4K2Gen");
		LuaDLL.lua_pop(l, 1);
	}
}
