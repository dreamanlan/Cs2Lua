using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LightBakingOutput : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.LightBakingOutput o;
			o=new UnityEngine.LightBakingOutput();
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
	static public int get_probeOcclusionLightIndex(IntPtr l) {
		try {
			UnityEngine.LightBakingOutput self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.probeOcclusionLightIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_probeOcclusionLightIndex(IntPtr l) {
		try {
			UnityEngine.LightBakingOutput self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.probeOcclusionLightIndex=v;
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
	static public int get_occlusionMaskChannel(IntPtr l) {
		try {
			UnityEngine.LightBakingOutput self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.occlusionMaskChannel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_occlusionMaskChannel(IntPtr l) {
		try {
			UnityEngine.LightBakingOutput self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.occlusionMaskChannel=v;
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
	static public int get_lightmapBakeType(IntPtr l) {
		try {
			UnityEngine.LightBakingOutput self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.lightmapBakeType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightmapBakeType(IntPtr l) {
		try {
			UnityEngine.LightBakingOutput self;
			checkValueType(l,1,out self);
			UnityEngine.LightmapBakeType v;
			checkEnum(l,2,out v);
			self.lightmapBakeType=v;
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
	static public int get_mixedLightingMode(IntPtr l) {
		try {
			UnityEngine.LightBakingOutput self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.mixedLightingMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mixedLightingMode(IntPtr l) {
		try {
			UnityEngine.LightBakingOutput self;
			checkValueType(l,1,out self);
			UnityEngine.MixedLightingMode v;
			checkEnum(l,2,out v);
			self.mixedLightingMode=v;
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
	static public int get_isBaked(IntPtr l) {
		try {
			UnityEngine.LightBakingOutput self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.isBaked);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isBaked(IntPtr l) {
		try {
			UnityEngine.LightBakingOutput self;
			checkValueType(l,1,out self);
			System.Boolean v;
			checkType(l,2,out v);
			self.isBaked=v;
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
		getTypeTable(l,"UnityEngine.LightBakingOutput");
		addMember(l,"probeOcclusionLightIndex",get_probeOcclusionLightIndex,set_probeOcclusionLightIndex,true);
		addMember(l,"occlusionMaskChannel",get_occlusionMaskChannel,set_occlusionMaskChannel,true);
		addMember(l,"lightmapBakeType",get_lightmapBakeType,set_lightmapBakeType,true);
		addMember(l,"mixedLightingMode",get_mixedLightingMode,set_mixedLightingMode,true);
		addMember(l,"isBaked",get_isBaked,set_isBaked,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LightBakingOutput),typeof(System.ValueType));
	}
}
