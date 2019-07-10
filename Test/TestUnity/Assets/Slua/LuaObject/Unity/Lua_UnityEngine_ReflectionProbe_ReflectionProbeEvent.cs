using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ReflectionProbe_ReflectionProbeEvent : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.ReflectionProbe.ReflectionProbeEvent");
		addMember(l,0,"ReflectionProbeAdded");
		addMember(l,1,"ReflectionProbeRemoved");
		LuaDLL.lua_pop(l, 1);
	}
}
