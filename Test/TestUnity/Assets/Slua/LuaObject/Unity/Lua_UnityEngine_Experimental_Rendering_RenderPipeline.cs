using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RenderPipeline : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Render(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipeline self=(UnityEngine.Experimental.Rendering.RenderPipeline)checkSelf(l);
			UnityEngine.Experimental.Rendering.ScriptableRenderContext a1;
			checkValueType(l,2,out a1);
			UnityEngine.Camera[] a2;
			checkArray(l,3,out a2);
			self.Render(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Dispose(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipeline self=(UnityEngine.Experimental.Rendering.RenderPipeline)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Dispose_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_disposed(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPipeline self=(UnityEngine.Experimental.Rendering.RenderPipeline)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.disposed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RenderPipeline");
		addMember(l,Render);
		addMember(l,Dispose);
		addMember(l,Dispose_s);
		addMember(l,"disposed",get_disposed,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.RenderPipeline));
	}
}
