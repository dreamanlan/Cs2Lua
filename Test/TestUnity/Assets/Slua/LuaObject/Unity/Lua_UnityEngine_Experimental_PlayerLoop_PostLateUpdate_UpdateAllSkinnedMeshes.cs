using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_PlayerLoop_PostLateUpdate_UpdateAllSkinnedMeshes : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.PlayerLoop.PostLateUpdate.UpdateAllSkinnedMeshes o;
			o=new UnityEngine.Experimental.PlayerLoop.PostLateUpdate.UpdateAllSkinnedMeshes();
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
		getTypeTable(l,"UnityEngine.Experimental.PlayerLoop.PostLateUpdate.UpdateAllSkinnedMeshes");
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.PlayerLoop.PostLateUpdate.UpdateAllSkinnedMeshes),typeof(System.ValueType));
	}
}
