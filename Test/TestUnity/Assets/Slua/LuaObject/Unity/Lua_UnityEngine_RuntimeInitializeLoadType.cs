using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_RuntimeInitializeLoadType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.RuntimeInitializeLoadType");
		addMember(l,0,"AfterSceneLoad");
		addMember(l,1,"BeforeSceneLoad");
		addMember(l,2,"AfterAssembliesLoaded");
		addMember(l,3,"BeforeSplashScreen");
		addMember(l,4,"SubsystemRegistration");
		LuaDLL.lua_pop(l, 1);
	}
}
