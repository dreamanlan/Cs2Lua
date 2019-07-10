using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Video_Video3DLayout : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Video.Video3DLayout");
		addMember(l,0,"No3D");
		addMember(l,1,"SideBySide3D");
		addMember(l,2,"OverUnder3D");
		LuaDLL.lua_pop(l, 1);
	}
}
