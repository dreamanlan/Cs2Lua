﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_PlayerLoop_Update_ScriptRunDelayedTasks : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.PlayerLoop.Update.ScriptRunDelayedTasks o;
			o=new UnityEngine.PlayerLoop.Update.ScriptRunDelayedTasks();
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
		getTypeTable(l,"UnityEngine.PlayerLoop.Update.ScriptRunDelayedTasks");
		addMember(l,ctor_s);
		createTypeMetatable(l,null, typeof(UnityEngine.PlayerLoop.Update.ScriptRunDelayedTasks),typeof(System.ValueType));
	}
}
