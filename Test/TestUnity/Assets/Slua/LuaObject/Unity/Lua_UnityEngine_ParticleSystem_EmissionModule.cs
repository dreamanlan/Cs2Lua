﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystem_EmissionModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule o;
			o=new UnityEngine.ParticleSystem.EmissionModule();
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
	static public int SetBursts__A_Burst(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.Burst[] a1;
			checkArray(l,2,out a1);
			self.SetBursts(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBursts__A_Burst__Int32(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.Burst[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetBursts(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBursts(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.Burst[] a1;
			checkArray(l,2,out a1);
			var ret=self.GetBursts(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBurst(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.ParticleSystem.Burst a2;
			checkValueType(l,3,out a2);
			self.SetBurst(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBurst(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetBurst(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enabled(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
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
	static public int get_rateOverTime(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rateOverTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rateOverTime(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.MinMaxCurve v;
			checkValueType(l,2,out v);
			self.rateOverTime=v;
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
	static public int get_rateOverTimeMultiplier(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rateOverTimeMultiplier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rateOverTimeMultiplier(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.rateOverTimeMultiplier=v;
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
	static public int get_rateOverDistance(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rateOverDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rateOverDistance(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.MinMaxCurve v;
			checkValueType(l,2,out v);
			self.rateOverDistance=v;
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
	static public int get_rateOverDistanceMultiplier(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rateOverDistanceMultiplier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rateOverDistanceMultiplier(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.rateOverDistanceMultiplier=v;
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
	static public int get_burstCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.burstCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_burstCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.burstCount=v;
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
		getTypeTable(l,"UnityEngine.ParticleSystem.EmissionModule");
		addMember(l,ctor_s);
		addMember(l,SetBursts__A_Burst);
		addMember(l,SetBursts__A_Burst__Int32);
		addMember(l,GetBursts);
		addMember(l,SetBurst);
		addMember(l,GetBurst);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"rateOverTime",get_rateOverTime,set_rateOverTime,true);
		addMember(l,"rateOverTimeMultiplier",get_rateOverTimeMultiplier,set_rateOverTimeMultiplier,true);
		addMember(l,"rateOverDistance",get_rateOverDistance,set_rateOverDistance,true);
		addMember(l,"rateOverDistanceMultiplier",get_rateOverDistanceMultiplier,set_rateOverDistanceMultiplier,true);
		addMember(l,"burstCount",get_burstCount,set_burstCount,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticleSystem.EmissionModule),typeof(System.ValueType));
	}
}
