using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystem_SubEmittersModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule o;
			o=new UnityEngine.ParticleSystem.SubEmittersModule();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
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
			UnityEngine.ParticleSystem.SubEmittersModule self;
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
	static public int get_birth0(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.birth0);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_birth0(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem v;
			checkType(l,2,out v);
			self.birth0=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_birth1(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.birth1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_birth1(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem v;
			checkType(l,2,out v);
			self.birth1=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collision0(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.collision0);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collision0(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem v;
			checkType(l,2,out v);
			self.collision0=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collision1(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.collision1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collision1(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem v;
			checkType(l,2,out v);
			self.collision1=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_death0(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.death0);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_death0(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem v;
			checkType(l,2,out v);
			self.death0=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_death1(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.death1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_death1(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem v;
			checkType(l,2,out v);
			self.death1=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.SubEmittersModule");
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"birth0",get_birth0,set_birth0,true);
		addMember(l,"birth1",get_birth1,set_birth1,true);
		addMember(l,"collision0",get_collision0,set_collision0,true);
		addMember(l,"collision1",get_collision1,set_collision1,true);
		addMember(l,"death0",get_death0,set_death0,true);
		addMember(l,"death1",get_death1,set_death1,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystem.SubEmittersModule),typeof(System.ValueType));
	}
}
