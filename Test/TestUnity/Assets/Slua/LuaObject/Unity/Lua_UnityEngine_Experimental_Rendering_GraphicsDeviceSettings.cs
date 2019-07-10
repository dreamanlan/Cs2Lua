using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_GraphicsDeviceSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_waitForPresentSyncPoint(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.Experimental.Rendering.GraphicsDeviceSettings.waitForPresentSyncPoint);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_waitForPresentSyncPoint(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.WaitForPresentSyncPoint v;
			checkEnum(l,2,out v);
			UnityEngine.Experimental.Rendering.GraphicsDeviceSettings.waitForPresentSyncPoint=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_graphicsJobsSyncPoint(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.Experimental.Rendering.GraphicsDeviceSettings.graphicsJobsSyncPoint);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_graphicsJobsSyncPoint(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.GraphicsJobsSyncPoint v;
			checkEnum(l,2,out v);
			UnityEngine.Experimental.Rendering.GraphicsDeviceSettings.graphicsJobsSyncPoint=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.GraphicsDeviceSettings");
		addMember(l,"waitForPresentSyncPoint",get_waitForPresentSyncPoint,set_waitForPresentSyncPoint,false);
		addMember(l,"graphicsJobsSyncPoint",get_graphicsJobsSyncPoint,set_graphicsJobsSyncPoint,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.GraphicsDeviceSettings));
	}
}
