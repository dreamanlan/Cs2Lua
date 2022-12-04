﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_JointLimits : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.JointLimits o;
			o=new UnityEngine.JointLimits();
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
	static public int get_min(IntPtr l) {
		try {
			UnityEngine.JointLimits self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.min);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_min(IntPtr l) {
		try {
			UnityEngine.JointLimits self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.min=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_max(IntPtr l) {
		try {
			UnityEngine.JointLimits self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.max);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_max(IntPtr l) {
		try {
			UnityEngine.JointLimits self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.max=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bounciness(IntPtr l) {
		try {
			UnityEngine.JointLimits self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.bounciness);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bounciness(IntPtr l) {
		try {
			UnityEngine.JointLimits self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.bounciness=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bounceMinVelocity(IntPtr l) {
		try {
			UnityEngine.JointLimits self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.bounceMinVelocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bounceMinVelocity(IntPtr l) {
		try {
			UnityEngine.JointLimits self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.bounceMinVelocity=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_contactDistance(IntPtr l) {
		try {
			UnityEngine.JointLimits self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.contactDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_contactDistance(IntPtr l) {
		try {
			UnityEngine.JointLimits self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.contactDistance=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointLimits");
		addMember(l,ctor_s);
		addMember(l,"min",get_min,set_min,true);
		addMember(l,"max",get_max,set_max,true);
		addMember(l,"bounciness",get_bounciness,set_bounciness,true);
		addMember(l,"bounceMinVelocity",get_bounceMinVelocity,set_bounceMinVelocity,true);
		addMember(l,"contactDistance",get_contactDistance,set_contactDistance,true);
		createTypeMetatable(l,null, typeof(UnityEngine.JointLimits),typeof(System.ValueType));
	}
}
