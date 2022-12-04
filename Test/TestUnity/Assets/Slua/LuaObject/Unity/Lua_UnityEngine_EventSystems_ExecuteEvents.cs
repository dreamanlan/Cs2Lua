using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_EventSystems_ExecuteEvents : LuaObject {
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.ExecuteEvents");
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.ExecuteEvents));
	}
}
