﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SortingGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateAllSortingGroups_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingGroup.UpdateAllSortingGroups();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sortingLayerName(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingGroup self=(UnityEngine.Rendering.SortingGroup)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sortingLayerName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sortingLayerName(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingGroup self=(UnityEngine.Rendering.SortingGroup)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.sortingLayerName=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sortingLayerID(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingGroup self=(UnityEngine.Rendering.SortingGroup)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sortingLayerID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sortingLayerID(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingGroup self=(UnityEngine.Rendering.SortingGroup)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.sortingLayerID=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sortingOrder(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingGroup self=(UnityEngine.Rendering.SortingGroup)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sortingOrder);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sortingOrder(IntPtr l) {
		try {
			UnityEngine.Rendering.SortingGroup self=(UnityEngine.Rendering.SortingGroup)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.sortingOrder=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.SortingGroup");
		addMember(l,UpdateAllSortingGroups_s);
		addMember(l,"sortingLayerName",get_sortingLayerName,set_sortingLayerName,true);
		addMember(l,"sortingLayerID",get_sortingLayerID,set_sortingLayerID,true);
		addMember(l,"sortingOrder",get_sortingOrder,set_sortingOrder,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.SortingGroup),typeof(UnityEngine.Behaviour));
	}
}
