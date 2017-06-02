using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_HumanPose : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.HumanPose o;
			o=new UnityEngine.HumanPose();
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
	static public int get_bodyPosition(IntPtr l) {
		try {
			UnityEngine.HumanPose self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.bodyPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bodyPosition(IntPtr l) {
		try {
			UnityEngine.HumanPose self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.bodyPosition=v;
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
	static public int get_bodyRotation(IntPtr l) {
		try {
			UnityEngine.HumanPose self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.bodyRotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bodyRotation(IntPtr l) {
		try {
			UnityEngine.HumanPose self;
			checkValueType(l,1,out self);
			UnityEngine.Quaternion v;
			checkType(l,2,out v);
			self.bodyRotation=v;
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
	static public int get_muscles(IntPtr l) {
		try {
			UnityEngine.HumanPose self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.muscles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_muscles(IntPtr l) {
		try {
			UnityEngine.HumanPose self;
			checkValueType(l,1,out self);
			System.Single[] v;
			checkArray(l,2,out v);
			self.muscles=v;
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
		getTypeTable(l,"UnityEngine.HumanPose");
		addMember(l,"bodyPosition",get_bodyPosition,set_bodyPosition,true);
		addMember(l,"bodyRotation",get_bodyRotation,set_bodyRotation,true);
		addMember(l,"muscles",get_muscles,set_muscles,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.HumanPose),typeof(System.ValueType));
	}
}
