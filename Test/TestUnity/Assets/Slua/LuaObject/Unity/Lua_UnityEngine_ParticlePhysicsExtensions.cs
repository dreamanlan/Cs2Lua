using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticlePhysicsExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
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
	static public int GetCollisionEvents_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem a1;
			checkType(l,1,out a1);
			UnityEngine.GameObject a2;
			checkType(l,2,out a2);
			UnityEngine.ParticleCollisionEvent[] a3;
			checkArray(l,3,out a3);
			var ret=UnityEngine.ParticlePhysicsExtensions.GetCollisionEvents(a1,a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticlePhysicsExtensions");
		addMember(l,GetSafeCollisionEventSize_s);
		addMember(l,GetCollisionEvents_s);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticlePhysicsExtensions));
	}
}
