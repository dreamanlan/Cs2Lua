﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_HumanBone : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.HumanBone o;
			o=new UnityEngine.HumanBone();
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
	static public int get_limit(IntPtr l) {
		try {
			UnityEngine.HumanBone self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.limit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_limit(IntPtr l) {
		try {
			UnityEngine.HumanBone self;
			checkValueType(l,1,out self);
			UnityEngine.HumanLimit v;
			checkValueType(l,2,out v);
			self.limit=v;
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
	static public int get_boneName(IntPtr l) {
		try {
			UnityEngine.HumanBone self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.boneName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_boneName(IntPtr l) {
		try {
			UnityEngine.HumanBone self;
			checkValueType(l,1,out self);
			string v;
			checkType(l,2,out v);
			self.boneName=v;
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
	static public int get_humanName(IntPtr l) {
		try {
			UnityEngine.HumanBone self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.humanName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_humanName(IntPtr l) {
		try {
			UnityEngine.HumanBone self;
			checkValueType(l,1,out self);
			string v;
			checkType(l,2,out v);
			self.humanName=v;
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
		getTypeTable(l,"UnityEngine.HumanBone");
		addMember(l,ctor_s);
		addMember(l,"limit",get_limit,set_limit,true);
		addMember(l,"boneName",get_boneName,set_boneName,true);
		addMember(l,"humanName",get_humanName,set_humanName,true);
		createTypeMetatable(l,null, typeof(UnityEngine.HumanBone),typeof(System.ValueType));
	}
}
