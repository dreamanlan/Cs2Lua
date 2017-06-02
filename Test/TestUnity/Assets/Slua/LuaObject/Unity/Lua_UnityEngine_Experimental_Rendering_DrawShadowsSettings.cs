using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_DrawShadowsSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawShadowsSettings o;
			UnityEngine.Experimental.Rendering.CullResults a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			o=new UnityEngine.Experimental.Rendering.DrawShadowsSettings(a1,a2);
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
	static public int get_lightIndex(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawShadowsSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lightIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightIndex(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawShadowsSettings self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.lightIndex=v;
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
	static public int get_splitData(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawShadowsSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.splitData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_splitData(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawShadowsSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.ShadowSplitData v;
			checkValueType(l,2,out v);
			self.splitData=v;
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
	static public int set_cullResults(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.DrawShadowsSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.CullResults v;
			checkValueType(l,2,out v);
			self.cullResults=v;
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
		getTypeTable(l,"UnityEngine.Experimental.Rendering.DrawShadowsSettings");
		addMember(l,"lightIndex",get_lightIndex,set_lightIndex,true);
		addMember(l,"splitData",get_splitData,set_splitData,true);
		addMember(l,"cullResults",null,set_cullResults,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.DrawShadowsSettings),typeof(System.ValueType));
	}
}
