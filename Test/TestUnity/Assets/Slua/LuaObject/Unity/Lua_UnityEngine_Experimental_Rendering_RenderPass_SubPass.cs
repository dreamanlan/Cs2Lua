using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RenderPass_SubPass : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPass.SubPass o;
			UnityEngine.Experimental.Rendering.RenderPass a1;
			checkType(l,2,out a1);
			UnityEngine.Experimental.Rendering.RenderPassAttachment[] a2;
			checkArray(l,3,out a2);
			UnityEngine.Experimental.Rendering.RenderPassAttachment[] a3;
			checkArray(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			o=new UnityEngine.Experimental.Rendering.RenderPass.SubPass(a1,a2,a3,a4);
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
	static public int Dispose(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPass.SubPass self=(UnityEngine.Experimental.Rendering.RenderPass.SubPass)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RenderPass.SubPass");
		addMember(l,Dispose);
		addMember(l,Dispose_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.RenderPass.SubPass));
	}
}
