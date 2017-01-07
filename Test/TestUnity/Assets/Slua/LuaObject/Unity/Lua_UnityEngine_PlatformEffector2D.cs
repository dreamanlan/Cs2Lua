using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PlatformEffector2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D o;
			o=new UnityEngine.PlatformEffector2D();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useOneWay(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useOneWay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useOneWay(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useOneWay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useOneWayGrouping(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useOneWayGrouping);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useOneWayGrouping(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useOneWayGrouping=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useSideFriction(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useSideFriction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useSideFriction(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useSideFriction=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useSideBounce(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useSideBounce);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useSideBounce(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useSideBounce=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_surfaceArc(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.surfaceArc);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_surfaceArc(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.surfaceArc=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sideArc(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sideArc);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sideArc(IntPtr l) {
		try {
			UnityEngine.PlatformEffector2D self=(UnityEngine.PlatformEffector2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.sideArc=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PlatformEffector2D");
		addMember(l,"useOneWay",get_useOneWay,set_useOneWay,true);
		addMember(l,"useOneWayGrouping",get_useOneWayGrouping,set_useOneWayGrouping,true);
		addMember(l,"useSideFriction",get_useSideFriction,set_useSideFriction,true);
		addMember(l,"useSideBounce",get_useSideBounce,set_useSideBounce,true);
		addMember(l,"surfaceArc",get_surfaceArc,set_surfaceArc,true);
		addMember(l,"sideArc",get_sideArc,set_sideArc,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.PlatformEffector2D),typeof(UnityEngine.Effector2D));
	}
}
