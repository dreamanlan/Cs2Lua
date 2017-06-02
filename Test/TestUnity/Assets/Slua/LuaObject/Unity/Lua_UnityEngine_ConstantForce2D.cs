using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ConstantForce2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_force(IntPtr l) {
		try {
			UnityEngine.ConstantForce2D self=(UnityEngine.ConstantForce2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.force);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_force(IntPtr l) {
		try {
			UnityEngine.ConstantForce2D self=(UnityEngine.ConstantForce2D)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.force=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_relativeForce(IntPtr l) {
		try {
			UnityEngine.ConstantForce2D self=(UnityEngine.ConstantForce2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.relativeForce);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_relativeForce(IntPtr l) {
		try {
			UnityEngine.ConstantForce2D self=(UnityEngine.ConstantForce2D)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.relativeForce=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_torque(IntPtr l) {
		try {
			UnityEngine.ConstantForce2D self=(UnityEngine.ConstantForce2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.torque);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_torque(IntPtr l) {
		try {
			UnityEngine.ConstantForce2D self=(UnityEngine.ConstantForce2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.torque=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ConstantForce2D");
		addMember(l,"force",get_force,set_force,true);
		addMember(l,"relativeForce",get_relativeForce,set_relativeForce,true);
		addMember(l,"torque",get_torque,set_torque,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ConstantForce2D),typeof(UnityEngine.PhysicsUpdateBehaviour2D));
	}
}
