using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystem_TextureSheetAnimationModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule o;
			o=new UnityEngine.ParticleSystem.TextureSheetAnimationModule();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
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
	static public int set_enabled(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
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
	static public int get_numTilesX(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.numTilesX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_numTilesX(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.numTilesX=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_numTilesY(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.numTilesY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_numTilesY(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.numTilesY=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animation(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.animation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_animation(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystemAnimationType v;
			checkEnum(l,2,out v);
			self.animation=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useRandomRow(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.useRandomRow);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useRandomRow(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.useRandomRow=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_frameOverTime(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.frameOverTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_frameOverTime(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.MinMaxCurve v;
			checkValueType(l,2,out v);
			self.frameOverTime=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cycleCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.cycleCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cycleCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.cycleCount=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rowIndex(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rowIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rowIndex(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.rowIndex=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.TextureSheetAnimationModule");
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"numTilesX",get_numTilesX,set_numTilesX,true);
		addMember(l,"numTilesY",get_numTilesY,set_numTilesY,true);
		addMember(l,"animation",get_animation,set_animation,true);
		addMember(l,"useRandomRow",get_useRandomRow,set_useRandomRow,true);
		addMember(l,"frameOverTime",get_frameOverTime,set_frameOverTime,true);
		addMember(l,"cycleCount",get_cycleCount,set_cycleCount,true);
		addMember(l,"rowIndex",get_rowIndex,set_rowIndex,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystem.TextureSheetAnimationModule),typeof(System.ValueType));
	}
}
