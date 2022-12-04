using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightmapCompression : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightmapCompression");
		addMember(l,0,"None");
		addMember(l,1,"LowQuality");
		addMember(l,2,"NormalQuality");
		addMember(l,3,"HighQuality");
		LuaDLL.lua_pop(l, 1);
	}
}
