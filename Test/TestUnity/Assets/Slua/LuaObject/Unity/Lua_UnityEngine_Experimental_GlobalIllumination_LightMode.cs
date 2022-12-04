using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_GlobalIllumination_LightMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Experimental.GlobalIllumination.LightMode");
		addMember(l,0,"Realtime");
		addMember(l,1,"Mixed");
		addMember(l,2,"Baked");
		addMember(l,3,"Unknown");
		LuaDLL.lua_pop(l, 1);
	}
}
