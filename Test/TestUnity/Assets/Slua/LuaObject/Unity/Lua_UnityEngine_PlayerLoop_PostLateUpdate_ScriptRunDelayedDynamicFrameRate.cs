﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_PlayerLoop_PostLateUpdate_ScriptRunDelayedDynamicFrameRate : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.PlayerLoop.PostLateUpdate.ScriptRunDelayedDynamicFrameRate o;
			o=new UnityEngine.PlayerLoop.PostLateUpdate.ScriptRunDelayedDynamicFrameRate();
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
		getTypeTable(l,"UnityEngine.PlayerLoop.PostLateUpdate.ScriptRunDelayedDynamicFrameRate");
		addMember(l,ctor_s);
		createTypeMetatable(l,null, typeof(UnityEngine.PlayerLoop.PostLateUpdate.ScriptRunDelayedDynamicFrameRate),typeof(System.ValueType));
	}
}
