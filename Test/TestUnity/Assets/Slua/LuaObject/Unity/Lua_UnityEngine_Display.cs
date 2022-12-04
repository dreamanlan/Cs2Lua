﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Display : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Activate(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			self.Activate();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Activate__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.Activate(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetParams(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetParams(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRenderingResolution(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetRenderingResolution(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RelativeMouseAt_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Display.RelativeMouseAt(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_displays(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Display.displays);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_displays(IntPtr l) {
		try {
			UnityEngine.Display[] v;
			checkArray(l,2,out v);
			UnityEngine.Display.displays=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderingWidth(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.renderingWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderingHeight(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.renderingHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_systemWidth(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.systemWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_systemHeight(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.systemHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colorBuffer(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.colorBuffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depthBuffer(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.depthBuffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_active(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.active);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_requiresBlitToBackbuffer(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.requiresBlitToBackbuffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_requiresSrgbBlitToBackbuffer(IntPtr l) {
		try {
			UnityEngine.Display self=(UnityEngine.Display)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.requiresSrgbBlitToBackbuffer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_main(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Display.main);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_activeEditorGameViewTarget(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Display.activeEditorGameViewTarget);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Display");
		addMember(l,Activate);
		addMember(l,Activate__Int32__Int32__Int32);
		addMember(l,SetParams);
		addMember(l,SetRenderingResolution);
		addMember(l,RelativeMouseAt_s);
		addMember(l,"displays",get_displays,set_displays,false);
		addMember(l,"renderingWidth",get_renderingWidth,null,true);
		addMember(l,"renderingHeight",get_renderingHeight,null,true);
		addMember(l,"systemWidth",get_systemWidth,null,true);
		addMember(l,"systemHeight",get_systemHeight,null,true);
		addMember(l,"colorBuffer",get_colorBuffer,null,true);
		addMember(l,"depthBuffer",get_depthBuffer,null,true);
		addMember(l,"active",get_active,null,true);
		addMember(l,"requiresBlitToBackbuffer",get_requiresBlitToBackbuffer,null,true);
		addMember(l,"requiresSrgbBlitToBackbuffer",get_requiresSrgbBlitToBackbuffer,null,true);
		addMember(l,"main",get_main,null,false);
		addMember(l,"activeEditorGameViewTarget",get_activeEditorGameViewTarget,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Display));
	}
}
