using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_JointMotor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.JointMotor o;
			o=new UnityEngine.JointMotor();
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
	static public int get_targetVelocity(IntPtr l) {
		try {
			UnityEngine.JointMotor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.targetVelocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_targetVelocity(IntPtr l) {
		try {
			UnityEngine.JointMotor self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.targetVelocity=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_force(IntPtr l) {
		try {
			UnityEngine.JointMotor self;
			checkValueType(l,1,out self);
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
			UnityEngine.JointMotor self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.force=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_freeSpin(IntPtr l) {
		try {
			UnityEngine.JointMotor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.freeSpin);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_freeSpin(IntPtr l) {
		try {
			UnityEngine.JointMotor self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.freeSpin=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointMotor");
		addMember(l,"targetVelocity",get_targetVelocity,set_targetVelocity,true);
		addMember(l,"force",get_force,set_force,true);
		addMember(l,"freeSpin",get_freeSpin,set_freeSpin,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointMotor),typeof(System.ValueType));
	}
}
