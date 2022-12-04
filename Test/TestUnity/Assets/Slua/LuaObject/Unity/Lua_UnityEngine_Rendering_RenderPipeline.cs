using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RenderPipeline : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_disposed(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipeline self=(UnityEngine.Rendering.RenderPipeline)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.disposed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultSettings(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderPipeline self=(UnityEngine.Rendering.RenderPipeline)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultSettings);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.RenderPipeline");
		addMember(l,"disposed",get_disposed,null,true);
		addMember(l,"defaultSettings",get_defaultSettings,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.RenderPipeline));
	}
}
