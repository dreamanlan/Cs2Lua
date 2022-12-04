using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Rendering_HybridV2_HybridV2ShaderReflection : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			Unity.Rendering.HybridV2.HybridV2ShaderReflection o;
			o=new Unity.Rendering.HybridV2.HybridV2ShaderReflection();
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
	static public int GetDOTSReflectionVersionNumber_s(IntPtr l) {
		try {
			var ret=Unity.Rendering.HybridV2.HybridV2ShaderReflection.GetDOTSReflectionVersionNumber();
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
		getTypeTable(l,"Unity.Rendering.HybridV2.HybridV2ShaderReflection");
		addMember(l,ctor_s);
		addMember(l,GetDOTSReflectionVersionNumber_s);
		createTypeMetatable(l,null, typeof(Unity.Rendering.HybridV2.HybridV2ShaderReflection));
	}
}
