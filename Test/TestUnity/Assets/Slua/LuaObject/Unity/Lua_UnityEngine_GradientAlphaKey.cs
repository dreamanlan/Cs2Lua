﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_GradientAlphaKey : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.GradientAlphaKey o;
			o=new UnityEngine.GradientAlphaKey();
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
	static public int ctor__Single__Single_s(IntPtr l) {
		try {
			UnityEngine.GradientAlphaKey o;
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			o=new UnityEngine.GradientAlphaKey(a1,a2);
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
	static public int get_alpha(IntPtr l) {
		try {
			UnityEngine.GradientAlphaKey self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.alpha);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_alpha(IntPtr l) {
		try {
			UnityEngine.GradientAlphaKey self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.alpha=v;
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
	static public int get_time(IntPtr l) {
		try {
			UnityEngine.GradientAlphaKey self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.time);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_time(IntPtr l) {
		try {
			UnityEngine.GradientAlphaKey self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.time=v;
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
		getTypeTable(l,"UnityEngine.GradientAlphaKey");
		addMember(l,ctor_s);
		addMember(l,ctor__Single__Single_s);
		addMember(l,"alpha",get_alpha,set_alpha,true);
		addMember(l,"time",get_time,set_time,true);
		createTypeMetatable(l,null, typeof(UnityEngine.GradientAlphaKey),typeof(System.ValueType));
	}
}
