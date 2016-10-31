using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_VR_VRSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.VR.VRSettings o;
			o=new UnityEngine.VR.VRSettings();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.VR.VRSettings.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.VR.VRSettings.enabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_showDeviceView(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.VR.VRSettings.showDeviceView);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_showDeviceView(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.VR.VRSettings.showDeviceView=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_renderScale(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.VR.VRSettings.renderScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderScale(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.VR.VRSettings.renderScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loadedDevice(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.VR.VRSettings.loadedDevice);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loadedDevice(IntPtr l) {
		try {
			UnityEngine.VR.VRDeviceType v;
			checkEnum(l,2,out v);
			UnityEngine.VR.VRSettings.loadedDevice=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.VR.VRSettings");
		addMember(l,"enabled",get_enabled,set_enabled,false);
		addMember(l,"showDeviceView",get_showDeviceView,set_showDeviceView,false);
		addMember(l,"renderScale",get_renderScale,set_renderScale,false);
		addMember(l,"loadedDevice",get_loadedDevice,set_loadedDevice,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.VR.VRSettings));
	}
}
