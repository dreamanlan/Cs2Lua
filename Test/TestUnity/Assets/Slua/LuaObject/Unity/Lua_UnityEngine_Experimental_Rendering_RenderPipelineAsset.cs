using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RenderPipelineAsset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DestroyCreatedInstances(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			self.DestroyCreatedInstances();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreatePipeline(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipelineAsset self=(UnityEngine.Experimental.Rendering.RenderPipelineAsset)checkSelf(l);
			var ret=self.CreatePipeline();
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
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RenderPipelineAsset");
		addMember(l,DestroyCreatedInstances);
		addMember(l,CreatePipeline);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.RenderPipelineAsset),typeof(UnityEngine.ScriptableObject));
	}
}
