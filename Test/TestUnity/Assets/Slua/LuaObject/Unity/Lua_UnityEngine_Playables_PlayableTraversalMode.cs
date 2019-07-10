using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Playables_PlayableTraversalMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Playables.PlayableTraversalMode");
		addMember(l,0,"Mix");
		addMember(l,1,"Passthrough");
		LuaDLL.lua_pop(l, 1);
	}
}
