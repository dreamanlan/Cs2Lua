using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Animations_AnimationStreamSource : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.Animations.AnimationStreamSource");
		addMember(l,0,"DefaultValues");
		addMember(l,1,"PreviousInputs");
		LuaDLL.lua_pop(l, 1);
	}
}
