using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystem_EmissionModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
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
	static public int SetBursts(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.ParticleSystem.EmissionModule self;
				checkValueType(l,1,out self);
				UnityEngine.ParticleSystem.Burst[] a1;
				checkArray(l,2,out a1);
				self.SetBursts(a1);
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			else if(argc==3){
				UnityEngine.ParticleSystem.EmissionModule self;
				checkValueType(l,1,out self);
				UnityEngine.ParticleSystem.Burst[] a1;
				checkArray(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetBursts(a1,a2);
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
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
	static public int set_enabled(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rate(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rate(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.MinMaxCurve v;
			checkValueType(l,2,out v);
			self.rate=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.EmissionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystemEmissionType v;
			checkEnum(l,2,out v);
			self.type=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.EmissionModule");
		addMember(l,SetBursts);
		addMember(l,GetBursts);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"rate",get_rate,set_rate,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"burstCount",get_burstCount,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystem.EmissionModule),typeof(System.ValueType));
	}
}
