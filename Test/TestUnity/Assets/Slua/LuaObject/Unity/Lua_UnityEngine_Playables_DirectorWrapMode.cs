using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Playables_DirectorWrapMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Playables.DirectorWrapMode");
		addMember(l,0,"Hold");
		addMember(l,1,"Loop");
		addMember(l,2,"None");
		LuaDLL.lua_pop(l, 1);
	}
}
