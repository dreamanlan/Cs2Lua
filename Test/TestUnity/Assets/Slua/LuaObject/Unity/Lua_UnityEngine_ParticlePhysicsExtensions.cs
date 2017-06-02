using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticlePhysicsExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSafeCollisionEventSize_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.ParticlePhysicsExtensions.GetSafeCollisionEventSize(a1);
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
	static public int GetCollisionEvents_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem a1;
			checkType(l,1,out a1);
			UnityEngine.GameObject a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.ParticleCollisionEvent> a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.ParticlePhysicsExtensions.GetCollisionEvents(a1,a2,a3);
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
	static public int GetSafeTriggerParticlesSize_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem a1;
			checkType(l,1,out a1);
			UnityEngine.ParticleSystemTriggerEventType a2;
			checkEnum(l,2,out a2);
			var ret=UnityEngine.ParticlePhysicsExtensions.GetSafeTriggerParticlesSize(a1,a2);
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
	static public int GetTriggerParticles_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem a1;
			checkType(l,1,out a1);
			UnityEngine.ParticleSystemTriggerEventType a2;
			checkEnum(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.ParticlePhysicsExtensions.GetTriggerParticles(a1,a2,a3);
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
	static public int SetTriggerParticles_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.ParticleSystem a1;
				checkType(l,1,out a1);
				UnityEngine.ParticleSystemTriggerEventType a2;
				checkEnum(l,2,out a2);
				System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> a3;
				checkType(l,3,out a3);
				UnityEngine.ParticlePhysicsExtensions.SetTriggerParticles(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.ParticleSystem a1;
				checkType(l,1,out a1);
				UnityEngine.ParticleSystemTriggerEventType a2;
				checkEnum(l,2,out a2);
				System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				System.Int32 a5;
				checkType(l,5,out a5);
				UnityEngine.ParticlePhysicsExtensions.SetTriggerParticles(a1,a2,a3,a4,a5);
				pushValue(l,true);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticlePhysicsExtensions");
		addMember(l,GetSafeCollisionEventSize_s);
		addMember(l,GetCollisionEvents_s);
		addMember(l,GetSafeTriggerParticlesSize_s);
		addMember(l,GetTriggerParticles_s);
		addMember(l,SetTriggerParticles_s);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticlePhysicsExtensions));
	}
}
