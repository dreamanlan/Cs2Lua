﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SplashScreen : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SplashScreen o;
			o=new UnityEngine.Rendering.SplashScreen();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Begin_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SplashScreen.Begin();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Stop_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SplashScreen.StopBehavior a1;
			checkEnum(l,1,out a1);
			UnityEngine.Rendering.SplashScreen.Stop(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Draw_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SplashScreen.Draw();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isFinished(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.SplashScreen.isFinished);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.SplashScreen");
		addMember(l,ctor_s);
		addMember(l,Begin_s);
		addMember(l,Stop_s);
		addMember(l,Draw_s);
		addMember(l,"isFinished",get_isFinished,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.SplashScreen));
	}
}
