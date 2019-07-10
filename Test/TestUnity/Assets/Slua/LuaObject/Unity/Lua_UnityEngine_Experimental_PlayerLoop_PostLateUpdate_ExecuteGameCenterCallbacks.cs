using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_PlayerLoop_PostLateUpdate_ExecuteGameCenterCallbacks : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.PlayerLoop.PostLateUpdate.ExecuteGameCenterCallbacks o;
			o=new UnityEngine.Experimental.PlayerLoop.PostLateUpdate.ExecuteGameCenterCallbacks();
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
		getTypeTable(l,"UnityEngine.Experimental.PlayerLoop.PostLateUpdate.ExecuteGameCenterCallbacks");
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.PlayerLoop.PostLateUpdate.ExecuteGameCenterCallbacks),typeof(System.ValueType));
	}
}
