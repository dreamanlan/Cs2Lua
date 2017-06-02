using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ParticleSystem_TextureSheetAnimationModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
	static public int get_frameOverTimeMultiplier(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.frameOverTimeMultiplier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_frameOverTimeMultiplier(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.frameOverTimeMultiplier=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_startFrame(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.startFrame);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_startFrame(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.MinMaxCurve v;
			checkValueType(l,2,out v);
			self.startFrame=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_startFrameMultiplier(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.startFrameMultiplier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_startFrameMultiplier(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.startFrameMultiplier=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_uvChannelMask(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.uvChannelMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uvChannelMask(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.UVChannelFlags v;
			checkEnum(l,2,out v);
			self.uvChannelMask=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_flipU(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.flipU);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flipU(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.flipU=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_flipV(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.flipV);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flipV(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.TextureSheetAnimationModule self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.flipV=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.TextureSheetAnimationModule");
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"numTilesX",get_numTilesX,set_numTilesX,true);
		addMember(l,"numTilesY",get_numTilesY,set_numTilesY,true);
		addMember(l,"animation",get_animation,set_animation,true);
		addMember(l,"useRandomRow",get_useRandomRow,set_useRandomRow,true);
		addMember(l,"frameOverTime",get_frameOverTime,set_frameOverTime,true);
		addMember(l,"frameOverTimeMultiplier",get_frameOverTimeMultiplier,set_frameOverTimeMultiplier,true);
		addMember(l,"startFrame",get_startFrame,set_startFrame,true);
		addMember(l,"startFrameMultiplier",get_startFrameMultiplier,set_startFrameMultiplier,true);
		addMember(l,"cycleCount",get_cycleCount,set_cycleCount,true);
		addMember(l,"rowIndex",get_rowIndex,set_rowIndex,true);
		addMember(l,"uvChannelMask",get_uvChannelMask,set_uvChannelMask,true);
		addMember(l,"flipU",get_flipU,set_flipU,true);
		addMember(l,"flipV",get_flipV,set_flipV,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystem.TextureSheetAnimationModule),typeof(System.ValueType));
	}
}
