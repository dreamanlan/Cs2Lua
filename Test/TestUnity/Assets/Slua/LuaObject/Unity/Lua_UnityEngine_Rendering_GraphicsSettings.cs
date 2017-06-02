using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_GraphicsSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderPipelineAsset(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.GraphicsSettings.renderPipelineAsset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderPipelineAsset(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset v;
			checkType(l,2,out v);
			UnityEngine.Rendering.GraphicsSettings.renderPipelineAsset=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_transparencySortMode(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.Rendering.GraphicsSettings.transparencySortMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_transparencySortMode(IntPtr l) {
		try {
			UnityEngine.TransparencySortMode v;
			checkEnum(l,2,out v);
			UnityEngine.Rendering.GraphicsSettings.transparencySortMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_transparencySortAxis(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.GraphicsSettings.transparencySortAxis);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_transparencySortAxis(IntPtr l) {
		try {
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			UnityEngine.Rendering.GraphicsSettings.transparencySortAxis=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightsUseLinearIntensity(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.GraphicsSettings.lightsUseLinearIntensity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightsUseLinearIntensity(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Rendering.GraphicsSettings.lightsUseLinearIntensity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightsUseColorTemperature(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.GraphicsSettings.lightsUseColorTemperature);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightsUseColorTemperature(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Rendering.GraphicsSettings.lightsUseColorTemperature=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.GraphicsSettings");
		addMember(l,SetShaderMode_s);
		addMember(l,GetShaderMode_s);
		addMember(l,SetCustomShader_s);
		addMember(l,GetCustomShader_s);
		addMember(l,"renderPipelineAsset",get_renderPipelineAsset,set_renderPipelineAsset,false);
		addMember(l,"transparencySortMode",get_transparencySortMode,set_transparencySortMode,false);
		addMember(l,"transparencySortAxis",get_transparencySortAxis,set_transparencySortAxis,false);
		addMember(l,"lightsUseLinearIntensity",get_lightsUseLinearIntensity,set_lightsUseLinearIntensity,false);
		addMember(l,"lightsUseColorTemperature",get_lightsUseColorTemperature,set_lightsUseColorTemperature,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.GraphicsSettings),typeof(UnityEngine.Object));
	}
}
