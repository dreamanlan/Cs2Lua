using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightmapSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.LightmapSettings o;
			o=new UnityEngine.LightmapSettings();
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
	static public int get_lightmaps(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.LightmapSettings.lightmaps);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightmaps(IntPtr l) {
		try {
			UnityEngine.LightmapData[] v;
			checkArray(l,2,out v);
			UnityEngine.LightmapSettings.lightmaps=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightmapsMode(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.LightmapSettings.lightmapsMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightmapsMode(IntPtr l) {
		try {
			UnityEngine.LightmapsMode v;
			checkEnum(l,2,out v);
			UnityEngine.LightmapSettings.lightmapsMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightProbes(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.LightmapSettings.lightProbes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightProbes(IntPtr l) {
		try {
			UnityEngine.LightProbes v;
			checkType(l,2,out v);
			UnityEngine.LightmapSettings.lightProbes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LightmapSettings");
		addMember(l,"lightmaps",get_lightmaps,set_lightmaps,false);
		addMember(l,"lightmapsMode",get_lightmapsMode,set_lightmapsMode,false);
		addMember(l,"lightProbes",get_lightProbes,set_lightProbes,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LightmapSettings),typeof(UnityEngine.Object));
	}
}
