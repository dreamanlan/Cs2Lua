using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer o;
			o=new UnityEngine.ParticleRenderer();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_particleRenderMode(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.particleRenderMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_particleRenderMode(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			UnityEngine.ParticleRenderMode v;
			checkEnum(l,2,out v);
			self.particleRenderMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lengthScale(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lengthScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lengthScale(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.lengthScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityScale(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.velocityScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityScale(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.velocityScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cameraVelocityScale(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cameraVelocityScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cameraVelocityScale(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.cameraVelocityScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxParticleSize(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxParticleSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxParticleSize(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.maxParticleSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvAnimationXTile(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uvAnimationXTile);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvAnimationXTile(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.uvAnimationXTile=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvAnimationYTile(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uvAnimationYTile);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvAnimationYTile(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.uvAnimationYTile=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvAnimationCycles(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uvAnimationCycles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvAnimationCycles(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.uvAnimationCycles=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxPartileSize(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxPartileSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxPartileSize(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.maxPartileSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_uvTiles(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uvTiles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uvTiles(IntPtr l) {
		try {
			UnityEngine.ParticleRenderer self=(UnityEngine.ParticleRenderer)checkSelf(l);
			UnityEngine.Rect[] v;
			checkArray(l,2,out v);
			self.uvTiles=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleRenderer");
		addMember(l,"particleRenderMode",get_particleRenderMode,set_particleRenderMode,true);
		addMember(l,"lengthScale",get_lengthScale,set_lengthScale,true);
		addMember(l,"velocityScale",get_velocityScale,set_velocityScale,true);
		addMember(l,"cameraVelocityScale",get_cameraVelocityScale,set_cameraVelocityScale,true);
		addMember(l,"maxParticleSize",get_maxParticleSize,set_maxParticleSize,true);
		addMember(l,"uvAnimationXTile",get_uvAnimationXTile,set_uvAnimationXTile,true);
		addMember(l,"uvAnimationYTile",get_uvAnimationYTile,set_uvAnimationYTile,true);
		addMember(l,"uvAnimationCycles",get_uvAnimationCycles,set_uvAnimationCycles,true);
		addMember(l,"maxPartileSize",get_maxPartileSize,set_maxPartileSize,true);
		addMember(l,"uvTiles",get_uvTiles,set_uvTiles,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleRenderer),typeof(UnityEngine.Renderer));
	}
}
