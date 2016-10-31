using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightmapData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.LightmapData o;
			o=new UnityEngine.LightmapData();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapFar(IntPtr l) {
		try {
			UnityEngine.LightmapData self=(UnityEngine.LightmapData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lightmapFar);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightmapFar(IntPtr l) {
		try {
			UnityEngine.LightmapData self=(UnityEngine.LightmapData)checkSelf(l);
			UnityEngine.Texture2D v;
			checkType(l,2,out v);
			self.lightmapFar=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lightmapNear(IntPtr l) {
		try {
			UnityEngine.LightmapData self=(UnityEngine.LightmapData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lightmapNear);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lightmapNear(IntPtr l) {
		try {
			UnityEngine.LightmapData self=(UnityEngine.LightmapData)checkSelf(l);
			UnityEngine.Texture2D v;
			checkType(l,2,out v);
			self.lightmapNear=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LightmapData");
		addMember(l,"lightmapFar",get_lightmapFar,set_lightmapFar,true);
		addMember(l,"lightmapNear",get_lightmapNear,set_lightmapNear,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LightmapData));
	}
}
