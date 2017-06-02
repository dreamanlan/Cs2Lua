using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_JointSpring : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.JointSpring o;
			o=new UnityEngine.JointSpring();
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
	static public int get_spring(IntPtr l) {
		try {
			UnityEngine.JointSpring self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.spring);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_spring(IntPtr l) {
		try {
			UnityEngine.JointSpring self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.spring=v;
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
	static public int get_damper(IntPtr l) {
		try {
			UnityEngine.JointSpring self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.damper);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_damper(IntPtr l) {
		try {
			UnityEngine.JointSpring self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.damper=v;
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
	static public int get_targetPosition(IntPtr l) {
		try {
			UnityEngine.JointSpring self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.targetPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_targetPosition(IntPtr l) {
		try {
			UnityEngine.JointSpring self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.targetPosition=v;
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
		getTypeTable(l,"UnityEngine.JointSpring");
		addMember(l,"spring",get_spring,set_spring,true);
		addMember(l,"damper",get_damper,set_damper,true);
		addMember(l,"targetPosition",get_targetPosition,set_targetPosition,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointSpring),typeof(System.ValueType));
	}
}
