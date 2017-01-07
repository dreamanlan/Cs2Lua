using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleEmitter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearParticles(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			self.ClearParticles();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Emit(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
				self.Emit();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.Emit(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==6){
				UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				UnityEngine.Color a5;
				checkType(l,6,out a5);
				self.Emit(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			else if(argc==8){
				UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				UnityEngine.Color a5;
				checkType(l,6,out a5);
				System.Single a6;
				checkType(l,7,out a6);
				System.Single a7;
				checkType(l,8,out a7);
				self.Emit(a1,a2,a3,a4,a5,a6,a7);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Simulate(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.Simulate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_emit(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.emit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_emit(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.emit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minSize(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minSize(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.minSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxSize(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxSize(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.maxSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minEnergy(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minEnergy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minEnergy(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.minEnergy=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxEnergy(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxEnergy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxEnergy(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.maxEnergy=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minEmission(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minEmission);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minEmission(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.minEmission=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxEmission(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxEmission);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxEmission(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.maxEmission=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_emitterVelocityScale(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.emitterVelocityScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_emitterVelocityScale(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.emitterVelocityScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldVelocity(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.worldVelocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_worldVelocity(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.worldVelocity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localVelocity(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.localVelocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localVelocity(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.localVelocity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rndVelocity(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rndVelocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rndVelocity(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.rndVelocity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useWorldSpace(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useWorldSpace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useWorldSpace(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useWorldSpace=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rndRotation(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rndRotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rndRotation(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.rndRotation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularVelocity(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.angularVelocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularVelocity(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.angularVelocity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rndAngularVelocity(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rndAngularVelocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rndAngularVelocity(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.rndAngularVelocity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particles(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.particles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_particles(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			UnityEngine.Particle[] v;
			checkArray(l,2,out v);
			self.particles=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleCount(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.particleCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
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
			UnityEngine.ParticleEmitter self=(UnityEngine.ParticleEmitter)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleEmitter");
		addMember(l,ClearParticles);
		addMember(l,Emit);
		addMember(l,Simulate);
		addMember(l,"emit",get_emit,set_emit,true);
		addMember(l,"minSize",get_minSize,set_minSize,true);
		addMember(l,"maxSize",get_maxSize,set_maxSize,true);
		addMember(l,"minEnergy",get_minEnergy,set_minEnergy,true);
		addMember(l,"maxEnergy",get_maxEnergy,set_maxEnergy,true);
		addMember(l,"minEmission",get_minEmission,set_minEmission,true);
		addMember(l,"maxEmission",get_maxEmission,set_maxEmission,true);
		addMember(l,"emitterVelocityScale",get_emitterVelocityScale,set_emitterVelocityScale,true);
		addMember(l,"worldVelocity",get_worldVelocity,set_worldVelocity,true);
		addMember(l,"localVelocity",get_localVelocity,set_localVelocity,true);
		addMember(l,"rndVelocity",get_rndVelocity,set_rndVelocity,true);
		addMember(l,"useWorldSpace",get_useWorldSpace,set_useWorldSpace,true);
		addMember(l,"rndRotation",get_rndRotation,set_rndRotation,true);
		addMember(l,"angularVelocity",get_angularVelocity,set_angularVelocity,true);
		addMember(l,"rndAngularVelocity",get_rndAngularVelocity,set_rndAngularVelocity,true);
		addMember(l,"particles",get_particles,set_particles,true);
		addMember(l,"particleCount",get_particleCount,null,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticleEmitter),typeof(UnityEngine.Component));
	}
}
