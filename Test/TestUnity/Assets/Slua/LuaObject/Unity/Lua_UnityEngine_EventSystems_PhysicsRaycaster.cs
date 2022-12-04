﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_EventSystems_PhysicsRaycaster : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_eventCamera(IntPtr l) {
		try {
			UnityEngine.EventSystems.PhysicsRaycaster self=(UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.eventCamera);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depth(IntPtr l) {
		try {
			UnityEngine.EventSystems.PhysicsRaycaster self=(UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.depth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_finalEventMask(IntPtr l) {
		try {
			UnityEngine.EventSystems.PhysicsRaycaster self=(UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.finalEventMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_eventMask(IntPtr l) {
		try {
			UnityEngine.EventSystems.PhysicsRaycaster self=(UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.eventMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_eventMask(IntPtr l) {
		try {
			UnityEngine.EventSystems.PhysicsRaycaster self=(UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
			UnityEngine.LayerMask v;
			checkValueType(l,2,out v);
			self.eventMask=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maxRayIntersections(IntPtr l) {
		try {
			UnityEngine.EventSystems.PhysicsRaycaster self=(UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxRayIntersections);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maxRayIntersections(IntPtr l) {
		try {
			UnityEngine.EventSystems.PhysicsRaycaster self=(UnityEngine.EventSystems.PhysicsRaycaster)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.maxRayIntersections=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.PhysicsRaycaster");
		addMember(l,"eventCamera",get_eventCamera,null,true);
		addMember(l,"depth",get_depth,null,true);
		addMember(l,"finalEventMask",get_finalEventMask,null,true);
		addMember(l,"eventMask",get_eventMask,set_eventMask,true);
		addMember(l,"maxRayIntersections",get_maxRayIntersections,set_maxRayIntersections,true);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.PhysicsRaycaster),typeof(UnityEngine.EventSystems.BaseRaycaster));
	}
}
