using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Collections_NativeSliceExtensions : LuaObject {
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"Unity.Collections.NativeSliceExtensions");
		createTypeMetatable(l,null, typeof(Unity.Collections.NativeSliceExtensions));
	}
}
