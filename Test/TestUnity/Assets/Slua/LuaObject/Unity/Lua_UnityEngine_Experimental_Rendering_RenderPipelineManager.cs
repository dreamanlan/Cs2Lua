using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RenderPipelineManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_currentPipeline(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.Rendering.RenderPipelineManager.currentPipeline);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RenderPipelineManager");
		addMember(l,"currentPipeline",get_currentPipeline,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.RenderPipelineManager));
	}
}
