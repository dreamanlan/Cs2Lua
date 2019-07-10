using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_ShaderKeywordSet : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeywordSet o;
			o=new UnityEngine.Rendering.ShaderKeywordSet();
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
	static public int IsEnabled(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeywordSet self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.ShaderKeyword a1;
			checkType(l,2,out a1);
			var ret=self.IsEnabled(a1);
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
	static public int Enable(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeywordSet self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.ShaderKeyword a1;
			checkType(l,2,out a1);
			self.Enable(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Disable(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeywordSet self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.ShaderKeyword a1;
			checkType(l,2,out a1);
			self.Disable(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetShaderKeywords(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeywordSet self;
			checkValueType(l,1,out self);
			var ret=self.GetShaderKeywords();
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
		getTypeTable(l,"UnityEngine.Rendering.ShaderKeywordSet");
		addMember(l,IsEnabled);
		addMember(l,Enable);
		addMember(l,Disable);
		addMember(l,GetShaderKeywords);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.ShaderKeywordSet),typeof(System.ValueType));
	}
}
