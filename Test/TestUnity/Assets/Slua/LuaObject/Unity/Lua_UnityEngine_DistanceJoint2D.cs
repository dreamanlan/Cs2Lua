using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_DistanceJoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autoConfigureDistance(IntPtr l) {
		try {
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoConfigureDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_autoConfigureDistance(IntPtr l) {
		try {
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoConfigureDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_distance(IntPtr l) {
		try {
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.distance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_distance(IntPtr l) {
		try {
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.distance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maxDistanceOnly(IntPtr l) {
		try {
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxDistanceOnly);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maxDistanceOnly(IntPtr l) {
		try {
			UnityEngine.DistanceJoint2D self=(UnityEngine.DistanceJoint2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.maxDistanceOnly=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.DistanceJoint2D");
		addMember(l,"autoConfigureDistance",get_autoConfigureDistance,set_autoConfigureDistance,true);
		addMember(l,"distance",get_distance,set_distance,true);
		addMember(l,"maxDistanceOnly",get_maxDistanceOnly,set_maxDistanceOnly,true);
		createTypeMetatable(l,null, typeof(UnityEngine.DistanceJoint2D),typeof(UnityEngine.AnchoredJoint2D));
	}
}
