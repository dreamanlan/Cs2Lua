using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Director_PlayState : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Director.PlayState");
		addMember(l,0,"Paused");
		addMember(l,1,"Playing");
		LuaDLL.lua_pop(l, 1);
	}
}
