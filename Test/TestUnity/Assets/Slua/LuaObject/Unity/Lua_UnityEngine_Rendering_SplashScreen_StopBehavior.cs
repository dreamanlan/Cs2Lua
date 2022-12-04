using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SplashScreen_StopBehavior : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.SplashScreen.StopBehavior");
		addMember(l,0,"StopImmediate");
		addMember(l,1,"FadeOut");
		LuaDLL.lua_pop(l, 1);
	}
}
