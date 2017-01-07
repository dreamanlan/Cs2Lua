using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_GraphicsSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Rendering.GraphicsSettings o;
			o=new UnityEngine.Rendering.GraphicsSettings();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetShaderMode_s(IntPtr l) {
		try {
			UnityEngine.Rendering.BuiltinShaderType a1;
			checkEnum(l,1,out a1);
			UnityEngine.Rendering.BuiltinShaderMode a2;
			checkEnum(l,2,out a2);
			UnityEngine.Rendering.GraphicsSettings.SetShaderMode(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetShaderMode_s(IntPtr l) {
		try {
			UnityEngine.Rendering.BuiltinShaderType a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Rendering.GraphicsSettings.GetShaderMode(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetCustomShader_s(IntPtr l) {
		try {
			UnityEngine.Rendering.BuiltinShaderType a1;
			checkEnum(l,1,out a1);
			UnityEngine.Shader a2;
			checkType(l,2,out a2);
			UnityEngine.Rendering.GraphicsSettings.SetCustomShader(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetCustomShader_s(IntPtr l) {
		try {
			UnityEngine.Rendering.BuiltinShaderType a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Rendering.GraphicsSettings.GetCustomShader(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.GraphicsSettings");
		addMember(l,SetShaderMode_s);
		addMember(l,GetShaderMode_s);
		addMember(l,SetCustomShader_s);
		addMember(l,GetCustomShader_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.GraphicsSettings),typeof(UnityEngine.Object));
	}
}
