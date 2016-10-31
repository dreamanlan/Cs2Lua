using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LODFadeMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LODFadeMode");
		addMember(l,0,"None");
		addMember(l,1,"CrossFade");
		addMember(l,2,"SpeedTree");
		LuaDLL.lua_pop(l, 1);
	}
}
