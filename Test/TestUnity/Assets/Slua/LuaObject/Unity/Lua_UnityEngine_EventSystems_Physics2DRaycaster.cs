using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_EventSystems_Physics2DRaycaster : LuaObject {
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.Physics2DRaycaster");
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.Physics2DRaycaster),typeof(UnityEngine.EventSystems.PhysicsRaycaster));
	}
}
