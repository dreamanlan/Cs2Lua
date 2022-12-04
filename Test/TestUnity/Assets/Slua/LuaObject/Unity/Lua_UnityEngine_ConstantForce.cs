﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ConstantForce : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_force(IntPtr l) {
		try {
			UnityEngine.ConstantForce self=(UnityEngine.ConstantForce)checkSelf(l);
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
			UnityEngine.ConstantForce self=(UnityEngine.ConstantForce)checkSelf(l);
			UnityEngine.Vector3 v;
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
			UnityEngine.ConstantForce self=(UnityEngine.ConstantForce)checkSelf(l);
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
			UnityEngine.ConstantForce self=(UnityEngine.ConstantForce)checkSelf(l);
			UnityEngine.Vector3 v;
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
			UnityEngine.ConstantForce self=(UnityEngine.ConstantForce)checkSelf(l);
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
			UnityEngine.ConstantForce self=(UnityEngine.ConstantForce)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.torque=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_relativeTorque(IntPtr l) {
		try {
			UnityEngine.ConstantForce self=(UnityEngine.ConstantForce)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.relativeTorque);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_relativeTorque(IntPtr l) {
		try {
			UnityEngine.ConstantForce self=(UnityEngine.ConstantForce)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.relativeTorque=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ConstantForce");
		addMember(l,"force",get_force,set_force,true);
		addMember(l,"relativeForce",get_relativeForce,set_relativeForce,true);
		addMember(l,"torque",get_torque,set_torque,true);
		addMember(l,"relativeTorque",get_relativeTorque,set_relativeTorque,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ConstantForce),typeof(UnityEngine.Behaviour));
	}
}
