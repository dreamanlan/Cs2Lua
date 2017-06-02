using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystem_SubEmittersModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
	static public int AddSubEmitter(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem a1;
			checkType(l,2,out a1);
			UnityEngine.ParticleSystemSubEmitterType a2;
			checkEnum(l,3,out a2);
			UnityEngine.ParticleSystemSubEmitterProperties a3;
			checkEnum(l,4,out a3);
			self.AddSubEmitter(a1,a2,a3);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveSubEmitter(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.RemoveSubEmitter(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetSubEmitterSystem(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.ParticleSystem a2;
			checkType(l,3,out a2);
			self.SetSubEmitterSystem(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetSubEmitterType(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.ParticleSystemSubEmitterType a2;
			checkEnum(l,3,out a2);
			self.SetSubEmitterType(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetSubEmitterProperties(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.ParticleSystemSubEmitterProperties a2;
			checkEnum(l,3,out a2);
			self.SetSubEmitterProperties(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSubEmitterSystem(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetSubEmitterSystem(a1);
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
	static public int GetSubEmitterType(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetSubEmitterType(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSubEmitterProperties(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetSubEmitterProperties(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
	static public int get_subEmittersCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.SubEmittersModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.subEmittersCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.SubEmittersModule");
		addMember(l,AddSubEmitter);
		addMember(l,RemoveSubEmitter);
		addMember(l,SetSubEmitterSystem);
		addMember(l,SetSubEmitterType);
		addMember(l,SetSubEmitterProperties);
		addMember(l,GetSubEmitterSystem);
		addMember(l,GetSubEmitterType);
		addMember(l,GetSubEmitterProperties);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"subEmittersCount",get_subEmittersCount,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystem.SubEmittersModule),typeof(System.ValueType));
	}
}
