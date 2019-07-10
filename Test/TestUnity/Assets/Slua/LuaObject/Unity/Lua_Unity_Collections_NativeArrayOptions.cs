using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Collections_NativeArrayOptions : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"Unity.Collections.NativeArrayOptions");
		addMember(l,0,"UninitializedMemory");
		addMember(l,1,"ClearMemory");
		LuaDLL.lua_pop(l, 1);
	}
}
