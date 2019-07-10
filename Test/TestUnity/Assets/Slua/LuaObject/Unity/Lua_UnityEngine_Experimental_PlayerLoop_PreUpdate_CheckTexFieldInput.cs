using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_PlayerLoop_PreUpdate_CheckTexFieldInput : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.PlayerLoop.PreUpdate.CheckTexFieldInput o;
			o=new UnityEngine.Experimental.PlayerLoop.PreUpdate.CheckTexFieldInput();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.PlayerLoop.PreUpdate.CheckTexFieldInput");
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.PlayerLoop.PreUpdate.CheckTexFieldInput),typeof(System.ValueType));
	}
}
