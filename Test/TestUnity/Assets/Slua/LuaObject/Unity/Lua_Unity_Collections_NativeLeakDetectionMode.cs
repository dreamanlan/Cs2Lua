using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Collections_NativeLeakDetectionMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"Unity.Collections.NativeLeakDetectionMode");
		addMember(l,1,"Disabled");
		addMember(l,2,"Enabled");
		addMember(l,3,"EnabledWithStackTrace");
		LuaDLL.lua_pop(l, 1);
	}
}
