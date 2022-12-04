using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_ScriptableRuntimeReflectionSystemSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_system(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemSettings.system);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_system(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem v;
			checkType(l,2,out v);
			UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemSettings.system=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemSettings");
		addMember(l,"system",get_system,set_system,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemSettings));
	}
}
