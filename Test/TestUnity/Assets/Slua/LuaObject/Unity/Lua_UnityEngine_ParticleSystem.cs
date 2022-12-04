using System;
using SLua;
using System.Collections.Generic;
using UnityEngine;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Emit__Int32(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.Emit(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Emit__EmitParams__Int32(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystem.EmitParams a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.Emit(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetParticles__O_Particle(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystem.Particle[] a1;
			checkArray(l,2,out a1);
			self.SetParticles(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetParticles__O_Particle__Int32(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystem.Particle[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetParticles(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetParticles__O_Particle__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystem.Particle[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.SetParticles(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetParticles__O_Particle(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystem.Particle[] a1;
			checkArray(l,2,out a1);
			var ret=self.GetParticles(a1);
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
	static public int GetParticles__O_Particle__Int32(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystem.Particle[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.GetParticles(a1,a2);
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
	static public int GetParticles__O_Particle__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystem.Particle[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.GetParticles(a1,a2,a3);
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
	static public int GetPlaybackState(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			var ret=self.GetPlaybackState();
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
	static public int SetPlaybackState(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystem.PlaybackState a1;
			checkValueType(l,2,out a1);
			self.SetPlaybackState(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTrails(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			var ret=self.GetTrails();
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
	static public int GetTrails__R_Trails(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystem.Trails a1;
			checkValueType(l,2,out a1);
			var ret=self.GetTrails(ref a1);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a1);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTrails(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystem.Trails a1;
			checkValueType(l,2,out a1);
			self.SetTrails(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Simulate__Single(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int Simulate__Single__Boolean(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.Simulate(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Simulate__Single__Boolean__Boolean(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.Simulate(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Simulate__Single__Boolean__Boolean__Boolean(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			self.Simulate(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Play(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			self.Play();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Play__Boolean(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Play(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Pause(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			self.Pause();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Pause__Boolean(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Pause(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Stop(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			self.Stop();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Stop__Boolean(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Stop(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Stop__Boolean__ParticleSystemStopBehavior(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			UnityEngine.ParticleSystemStopBehavior a2;
			checkEnum(l,3,out a2);
			self.Stop(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Clear(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Clear__Boolean(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Clear(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsAlive(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			var ret=self.IsAlive();
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
	static public int IsAlive__Boolean(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			var ret=self.IsAlive(a1);
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
	static public int TriggerSubEmitter__Int32(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.TriggerSubEmitter(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TriggerSubEmitter__Int32__R_Particle(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.ParticleSystem.Particle a2;
			checkValueType(l,3,out a2);
			self.TriggerSubEmitter(a1,ref a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AllocateAxisOfRotationAttribute(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			self.AllocateAxisOfRotationAttribute();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AllocateMeshIndexAttribute(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			self.AllocateMeshIndexAttribute();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AllocateCustomDataAttribute(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystemCustomData a1;
			checkEnum(l,2,out a1);
			self.AllocateCustomDataAttribute(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSafeCollisionEventSize(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			var ret=self.GetSafeCollisionEventSize();
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
	static public int GetSafeTriggerParticlesSize(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystemTriggerEventType a2;
			checkEnum(l,2,out a2);
			var ret=self.GetSafeTriggerParticlesSize(a2);
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
	static public int ResetPreMappedBufferMemory_s(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.ResetPreMappedBufferMemory();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMaximumPreMappedBufferCounts_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.ParticleSystem.SetMaximumPreMappedBufferCounts(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isPlaying(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isPlaying);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isEmitting(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isEmitting);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isStopped(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isStopped);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isPaused(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isPaused);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_particleCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.particleCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_time(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.time);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_time(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.time=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_randomSeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.randomSeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_randomSeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			System.UInt32 v;
			checkType(l,2,out v);
			self.randomSeed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useAutoRandomSeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useAutoRandomSeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useAutoRandomSeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useAutoRandomSeed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_proceduralSimulationSupported(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.proceduralSimulationSupported);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_main(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.main);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_emission(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.emission);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_shape(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shape);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_velocityOverLifetime(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.velocityOverLifetime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_limitVelocityOverLifetime(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.limitVelocityOverLifetime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_inheritVelocity(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.inheritVelocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lifetimeByEmitterSpeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lifetimeByEmitterSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_forceOverLifetime(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.forceOverLifetime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colorOverLifetime(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.colorOverLifetime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colorBySpeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.colorBySpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sizeOverLifetime(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sizeOverLifetime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sizeBySpeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sizeBySpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rotationOverLifetime(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rotationOverLifetime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rotationBySpeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rotationBySpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_externalForces(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.externalForces);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_noise(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.noise);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_collision(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.collision);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_trigger(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.trigger);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_subEmitters(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.subEmitters);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_textureSheetAnimation(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.textureSheetAnimation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lights(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lights);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_trails(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.trails);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_customData(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.customData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem");
		addMember(l,Emit__Int32);
		addMember(l,Emit__EmitParams__Int32);
		addMember(l,SetParticles__O_Particle);
		addMember(l,SetParticles__O_Particle__Int32);
		addMember(l,SetParticles__O_Particle__Int32__Int32);
		addMember(l,GetParticles__O_Particle);
		addMember(l,GetParticles__O_Particle__Int32);
		addMember(l,GetParticles__O_Particle__Int32__Int32);
		addMember(l,GetPlaybackState);
		addMember(l,SetPlaybackState);
		addMember(l,GetTrails);
		addMember(l,GetTrails__R_Trails);
		addMember(l,SetTrails);
		addMember(l,Simulate__Single);
		addMember(l,Simulate__Single__Boolean);
		addMember(l,Simulate__Single__Boolean__Boolean);
		addMember(l,Simulate__Single__Boolean__Boolean__Boolean);
		addMember(l,Play);
		addMember(l,Play__Boolean);
		addMember(l,Pause);
		addMember(l,Pause__Boolean);
		addMember(l,Stop);
		addMember(l,Stop__Boolean);
		addMember(l,Stop__Boolean__ParticleSystemStopBehavior);
		addMember(l,Clear);
		addMember(l,Clear__Boolean);
		addMember(l,IsAlive);
		addMember(l,IsAlive__Boolean);
		addMember(l,TriggerSubEmitter__Int32);
		addMember(l,TriggerSubEmitter__Int32__R_Particle);
		addMember(l,AllocateAxisOfRotationAttribute);
		addMember(l,AllocateMeshIndexAttribute);
		addMember(l,AllocateCustomDataAttribute);
		addMember(l,GetSafeCollisionEventSize);
		addMember(l,GetSafeTriggerParticlesSize);
		addMember(l,ResetPreMappedBufferMemory_s);
		addMember(l,SetMaximumPreMappedBufferCounts_s);
		addMember(l,"isPlaying",get_isPlaying,null,true);
		addMember(l,"isEmitting",get_isEmitting,null,true);
		addMember(l,"isStopped",get_isStopped,null,true);
		addMember(l,"isPaused",get_isPaused,null,true);
		addMember(l,"particleCount",get_particleCount,null,true);
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"randomSeed",get_randomSeed,set_randomSeed,true);
		addMember(l,"useAutoRandomSeed",get_useAutoRandomSeed,set_useAutoRandomSeed,true);
		addMember(l,"proceduralSimulationSupported",get_proceduralSimulationSupported,null,true);
		addMember(l,"main",get_main,null,true);
		addMember(l,"emission",get_emission,null,true);
		addMember(l,"shape",get_shape,null,true);
		addMember(l,"velocityOverLifetime",get_velocityOverLifetime,null,true);
		addMember(l,"limitVelocityOverLifetime",get_limitVelocityOverLifetime,null,true);
		addMember(l,"inheritVelocity",get_inheritVelocity,null,true);
		addMember(l,"lifetimeByEmitterSpeed",get_lifetimeByEmitterSpeed,null,true);
		addMember(l,"forceOverLifetime",get_forceOverLifetime,null,true);
		addMember(l,"colorOverLifetime",get_colorOverLifetime,null,true);
		addMember(l,"colorBySpeed",get_colorBySpeed,null,true);
		addMember(l,"sizeOverLifetime",get_sizeOverLifetime,null,true);
		addMember(l,"sizeBySpeed",get_sizeBySpeed,null,true);
		addMember(l,"rotationOverLifetime",get_rotationOverLifetime,null,true);
		addMember(l,"rotationBySpeed",get_rotationBySpeed,null,true);
		addMember(l,"externalForces",get_externalForces,null,true);
		addMember(l,"noise",get_noise,null,true);
		addMember(l,"collision",get_collision,null,true);
		addMember(l,"trigger",get_trigger,null,true);
		addMember(l,"subEmitters",get_subEmitters,null,true);
		addMember(l,"textureSheetAnimation",get_textureSheetAnimation,null,true);
		addMember(l,"lights",get_lights,null,true);
		addMember(l,"trails",get_trails,null,true);
		addMember(l,"customData",get_customData,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ParticleSystem),typeof(UnityEngine.Component));
	}
}
