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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticlePhysicsExtensions");
		addMember(l,GetSafeCollisionEventSize_s);
		addMember(l,GetSafeTriggerParticlesSize_s);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticlePhysicsExtensions));
	}
}
