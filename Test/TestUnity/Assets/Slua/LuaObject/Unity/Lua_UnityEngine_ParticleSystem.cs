using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ParticleSystem o;
			o=new UnityEngine.ParticleSystem();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetParticles(IntPtr l) {
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
	static public int GetParticles(IntPtr l) {
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
	static public int Simulate(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				self.Simulate(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.Simulate(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
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
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				self.Play();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Play(a1);
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
	static public int Stop(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				self.Stop();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Stop(a1);
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
	static public int Pause(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				self.Pause();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Pause(a1);
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
	static public int Clear(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				self.Clear();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Clear(a1);
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
	static public int IsAlive(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				var ret=self.IsAlive();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				var ret=self.IsAlive(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
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
	static public int Emit(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.Emit(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
				UnityEngine.ParticleSystem.EmitParams a1;
				checkValueType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.Emit(a1,a2);
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
	static public int get_startDelay(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startDelay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startDelay(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.startDelay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
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
	static public int get_loop(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.loop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_loop(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.loop=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playOnAwake(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.playOnAwake);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playOnAwake(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.playOnAwake=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
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
	static public int get_duration(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.duration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playbackSpeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.playbackSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playbackSpeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.playbackSpeed=v;
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
	static public int get_startSpeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startSpeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.startSpeed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startSize(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startSize(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.startSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startColor(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startColor(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.startColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startRotation(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startRotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startRotation(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.startRotation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startRotation3D(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startRotation3D);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startRotation3D(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.startRotation3D=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startLifetime(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startLifetime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startLifetime(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.startLifetime=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravityModifier(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gravityModifier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gravityModifier(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.gravityModifier=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxParticles(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxParticles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxParticles(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.maxParticles=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_simulationSpace(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.simulationSpace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_simulationSpace(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystemSimulationSpace v;
			checkEnum(l,2,out v);
			self.simulationSpace=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scalingMode(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.scalingMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scalingMode(IntPtr l) {
		try {
			UnityEngine.ParticleSystem self=(UnityEngine.ParticleSystem)checkSelf(l);
			UnityEngine.ParticleSystemScalingMode v;
			checkEnum(l,2,out v);
			self.scalingMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem");
		addMember(l,SetParticles);
		addMember(l,GetParticles);
		addMember(l,Simulate);
		addMember(l,Play);
		addMember(l,Stop);
		addMember(l,Pause);
		addMember(l,Clear);
		addMember(l,IsAlive);
		addMember(l,Emit);
		addMember(l,"startDelay",get_startDelay,set_startDelay,true);
		addMember(l,"isPlaying",get_isPlaying,null,true);
		addMember(l,"isStopped",get_isStopped,null,true);
		addMember(l,"isPaused",get_isPaused,null,true);
		addMember(l,"loop",get_loop,set_loop,true);
		addMember(l,"playOnAwake",get_playOnAwake,set_playOnAwake,true);
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"duration",get_duration,null,true);
		addMember(l,"playbackSpeed",get_playbackSpeed,set_playbackSpeed,true);
		addMember(l,"particleCount",get_particleCount,null,true);
		addMember(l,"startSpeed",get_startSpeed,set_startSpeed,true);
		addMember(l,"startSize",get_startSize,set_startSize,true);
		addMember(l,"startColor",get_startColor,set_startColor,true);
		addMember(l,"startRotation",get_startRotation,set_startRotation,true);
		addMember(l,"startRotation3D",get_startRotation3D,set_startRotation3D,true);
		addMember(l,"startLifetime",get_startLifetime,set_startLifetime,true);
		addMember(l,"gravityModifier",get_gravityModifier,set_gravityModifier,true);
		addMember(l,"maxParticles",get_maxParticles,set_maxParticles,true);
		addMember(l,"simulationSpace",get_simulationSpace,set_simulationSpace,true);
		addMember(l,"scalingMode",get_scalingMode,set_scalingMode,true);
		addMember(l,"randomSeed",get_randomSeed,set_randomSeed,true);
		addMember(l,"emission",get_emission,null,true);
		addMember(l,"shape",get_shape,null,true);
		addMember(l,"velocityOverLifetime",get_velocityOverLifetime,null,true);
		addMember(l,"limitVelocityOverLifetime",get_limitVelocityOverLifetime,null,true);
		addMember(l,"inheritVelocity",get_inheritVelocity,null,true);
		addMember(l,"forceOverLifetime",get_forceOverLifetime,null,true);
		addMember(l,"colorOverLifetime",get_colorOverLifetime,null,true);
		addMember(l,"colorBySpeed",get_colorBySpeed,null,true);
		addMember(l,"sizeOverLifetime",get_sizeOverLifetime,null,true);
		addMember(l,"sizeBySpeed",get_sizeBySpeed,null,true);
		addMember(l,"rotationOverLifetime",get_rotationOverLifetime,null,true);
		addMember(l,"rotationBySpeed",get_rotationBySpeed,null,true);
		addMember(l,"externalForces",get_externalForces,null,true);
		addMember(l,"collision",get_collision,null,true);
		addMember(l,"subEmitters",get_subEmitters,null,true);
		addMember(l,"textureSheetAnimation",get_textureSheetAnimation,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystem),typeof(UnityEngine.Component));
	}
}
