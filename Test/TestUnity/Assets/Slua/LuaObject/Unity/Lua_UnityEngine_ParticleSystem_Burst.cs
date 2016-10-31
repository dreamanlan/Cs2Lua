using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystem_Burst : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.ParticleSystem.Burst o;
			if(argc==3){
				System.Single a1;
				checkType(l,2,out a1);
				System.Int16 a2;
				checkType(l,3,out a2);
				o=new UnityEngine.ParticleSystem.Burst(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==4){
				System.Single a1;
				checkType(l,2,out a1);
				System.Int16 a2;
				checkType(l,3,out a2);
				System.Int16 a3;
				checkType(l,4,out a3);
				o=new UnityEngine.ParticleSystem.Burst(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==0){
				o=new UnityEngine.ParticleSystem.Burst();
				pushValue(l,true);
				pushObject(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.Burst self;
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
	static public int set_time(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.Burst self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.time=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.Burst self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.minCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.Burst self;
			checkValueType(l,1,out self);
			System.Int16 v;
			checkType(l,2,out v);
			self.minCount=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.Burst self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.maxCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.Burst self;
			checkValueType(l,1,out self);
			System.Int16 v;
			checkType(l,2,out v);
			self.maxCount=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.Burst");
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"minCount",get_minCount,set_minCount,true);
		addMember(l,"maxCount",get_maxCount,set_maxCount,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystem.Burst),typeof(System.ValueType));
	}
}
