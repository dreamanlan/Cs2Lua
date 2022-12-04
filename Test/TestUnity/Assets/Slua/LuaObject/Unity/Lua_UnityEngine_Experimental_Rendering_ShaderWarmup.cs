using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_ShaderWarmup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WarmupShader_s(IntPtr l) {
		try {
			UnityEngine.Shader a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Rendering.ShaderWarmupSetup a2;
			checkValueType(l,2,out a2);
			UnityEngine.Experimental.Rendering.ShaderWarmup.WarmupShader(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WarmupShaderFromCollection_s(IntPtr l) {
		try {
			UnityEngine.ShaderVariantCollection a1;
			checkType(l,1,out a1);
			UnityEngine.Shader a2;
			checkType(l,2,out a2);
			UnityEngine.Experimental.Rendering.ShaderWarmupSetup a3;
			checkValueType(l,3,out a3);
			UnityEngine.Experimental.Rendering.ShaderWarmup.WarmupShaderFromCollection(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.ShaderWarmup");
		addMember(l,WarmupShader_s);
		addMember(l,WarmupShaderFromCollection_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.ShaderWarmup));
	}
}
