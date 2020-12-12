using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_tvOS_Remote : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.tvOS.Remote o;
			o=new UnityEngine.tvOS.Remote();
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
	static public int get_allowExitToHome(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.tvOS.Remote.allowExitToHome);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_allowExitToHome(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.tvOS.Remote.allowExitToHome=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_allowRemoteRotation(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.tvOS.Remote.allowRemoteRotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_allowRemoteRotation(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.tvOS.Remote.allowRemoteRotation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_reportAbsoluteDpadValues(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.tvOS.Remote.reportAbsoluteDpadValues);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_reportAbsoluteDpadValues(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.tvOS.Remote.reportAbsoluteDpadValues=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_touchesEnabled(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.tvOS.Remote.touchesEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_touchesEnabled(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.tvOS.Remote.touchesEnabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.tvOS.Remote");
		addMember(l,ctor_s);
		addMember(l,"allowExitToHome",get_allowExitToHome,set_allowExitToHome,false);
		addMember(l,"allowRemoteRotation",get_allowRemoteRotation,set_allowRemoteRotation,false);
		addMember(l,"reportAbsoluteDpadValues",get_reportAbsoluteDpadValues,set_reportAbsoluteDpadValues,false);
		addMember(l,"touchesEnabled",get_touchesEnabled,set_touchesEnabled,false);
		createTypeMetatable(l,null, typeof(UnityEngine.tvOS.Remote));
	}
}
