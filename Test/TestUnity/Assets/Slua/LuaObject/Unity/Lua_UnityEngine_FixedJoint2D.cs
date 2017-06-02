using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_FixedJoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_dampingRatio(IntPtr l) {
		try {
			UnityEngine.FixedJoint2D self=(UnityEngine.FixedJoint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dampingRatio);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_dampingRatio(IntPtr l) {
		try {
			UnityEngine.FixedJoint2D self=(UnityEngine.FixedJoint2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.dampingRatio=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_frequency(IntPtr l) {
		try {
			UnityEngine.FixedJoint2D self=(UnityEngine.FixedJoint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frequency);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_frequency(IntPtr l) {
		try {
			UnityEngine.FixedJoint2D self=(UnityEngine.FixedJoint2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.frequency=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_referenceAngle(IntPtr l) {
		try {
			UnityEngine.FixedJoint2D self=(UnityEngine.FixedJoint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.referenceAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.FixedJoint2D");
		addMember(l,"dampingRatio",get_dampingRatio,set_dampingRatio,true);
		addMember(l,"frequency",get_frequency,set_frequency,true);
		addMember(l,"referenceAngle",get_referenceAngle,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.FixedJoint2D),typeof(UnityEngine.AnchoredJoint2D));
	}
}
