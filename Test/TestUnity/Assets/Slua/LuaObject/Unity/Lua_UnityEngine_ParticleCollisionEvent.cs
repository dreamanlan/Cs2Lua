using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleCollisionEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ParticleCollisionEvent o;
			o=new UnityEngine.ParticleCollisionEvent();
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
	static public int get_intersection(IntPtr l) {
		try {
			UnityEngine.ParticleCollisionEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.intersection);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_normal(IntPtr l) {
		try {
			UnityEngine.ParticleCollisionEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.normal);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_velocity(IntPtr l) {
		try {
			UnityEngine.ParticleCollisionEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.velocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colliderComponent(IntPtr l) {
		try {
			UnityEngine.ParticleCollisionEvent self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.colliderComponent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleCollisionEvent");
		addMember(l,"intersection",get_intersection,null,true);
		addMember(l,"normal",get_normal,null,true);
		addMember(l,"velocity",get_velocity,null,true);
		addMember(l,"colliderComponent",get_colliderComponent,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleCollisionEvent),typeof(System.ValueType));
	}
}
