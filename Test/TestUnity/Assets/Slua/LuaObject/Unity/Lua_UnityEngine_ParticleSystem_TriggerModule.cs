using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystem_TriggerModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
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
	static public int AddCollider(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			UnityEngine.Component a1;
			checkType(l,2,out a1);
			self.AddCollider(a1);
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
	static public int RemoveCollider__Int32(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.RemoveCollider(a1);
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
	static public int RemoveCollider__Component(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			UnityEngine.Component a1;
			checkType(l,2,out a1);
			self.RemoveCollider(a1);
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
			setBack(l,(object)self);
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
	static public int get_colliderQueryMode(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.colliderQueryMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colliderQueryMode(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystemColliderQueryMode v;
			checkEnum(l,2,out v);
			self.colliderQueryMode=v;
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
	static public int get_colliderCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TriggerModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.colliderCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.TriggerModule");
		addMember(l,ctor_s);
		addMember(l,AddCollider);
		addMember(l,RemoveCollider__Int32);
		addMember(l,RemoveCollider__Component);
		addMember(l,SetCollider);
		addMember(l,GetCollider);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"inside",get_inside,set_inside,true);
		addMember(l,"outside",get_outside,set_outside,true);
		addMember(l,"enter",get_enter,set_enter,true);
		addMember(l,"exit",get_exit,set_exit,true);
		addMember(l,"colliderQueryMode",get_colliderQueryMode,set_colliderQueryMode,true);
		addMember(l,"radiusScale",get_radiusScale,set_radiusScale,true);
		addMember(l,"colliderCount",get_colliderCount,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticleSystem.TriggerModule),typeof(System.ValueType));
	}
}
