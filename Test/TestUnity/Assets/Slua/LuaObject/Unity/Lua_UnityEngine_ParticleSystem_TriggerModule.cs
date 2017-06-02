using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystem_TriggerModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule o;
			o=new UnityEngine.ParticleSystem.TriggerModule();
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
	static public int SetCollider(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Component a2;
			checkType(l,3,out a2);
			self.SetCollider(a1,a2);
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
	static public int GetCollider(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetCollider(a1);
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
			UnityEngine.ParticleSystem.TriggerModule self;
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
			UnityEngine.ParticleSystem.TriggerModule self;
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
	static public int get_inside(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.inside);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_inside(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystemOverlapAction v;
			checkEnum(l,2,out v);
			self.inside=v;
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
	static public int get_outside(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.outside);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_outside(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystemOverlapAction v;
			checkEnum(l,2,out v);
			self.outside=v;
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
	static public int get_enter(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.enter);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enter(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystemOverlapAction v;
			checkEnum(l,2,out v);
			self.enter=v;
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
	static public int get_exit(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.exit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_exit(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystemOverlapAction v;
			checkEnum(l,2,out v);
			self.exit=v;
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
	static public int get_radiusScale(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.radiusScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_radiusScale(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.radiusScale=v;
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
	static public int get_maxColliderCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.maxColliderCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.TriggerModule");
		addMember(l,SetCollider);
		addMember(l,GetCollider);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"inside",get_inside,set_inside,true);
		addMember(l,"outside",get_outside,set_outside,true);
		addMember(l,"enter",get_enter,set_enter,true);
		addMember(l,"exit",get_exit,set_exit,true);
		addMember(l,"radiusScale",get_radiusScale,set_radiusScale,true);
		addMember(l,"maxColliderCount",get_maxColliderCount,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystem.TriggerModule),typeof(System.ValueType));
	}
}
