using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_FlareLayer : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.FlareLayer");
		createTypeMetatable(l,null, typeof(UnityEngine.FlareLayer),typeof(UnityEngine.Behaviour));
	}
}
