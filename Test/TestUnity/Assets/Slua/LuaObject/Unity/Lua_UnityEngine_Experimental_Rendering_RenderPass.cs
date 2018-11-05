using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RenderPass : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPass o;
			UnityEngine.Experimental.Rendering.ScriptableRenderContext a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.Experimental.Rendering.RenderPassAttachment[] a5;
			checkArray(l,6,out a5);
			UnityEngine.Experimental.Rendering.RenderPassAttachment a6;
			checkType(l,7,out a6);
			o=new UnityEngine.Experimental.Rendering.RenderPass(a1,a2,a3,a4,a5,a6);
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
			UnityEngine.Experimental.Rendering.RenderPass self=(UnityEngine.Experimental.Rendering.RenderPass)checkSelf(l);
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
	static public int get_colorAttachments(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPass self=(UnityEngine.Experimental.Rendering.RenderPass)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.colorAttachments);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depthAttachment(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPass self=(UnityEngine.Experimental.Rendering.RenderPass)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.depthAttachment);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_width(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPass self=(UnityEngine.Experimental.Rendering.RenderPass)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPass self=(UnityEngine.Experimental.Rendering.RenderPass)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sampleCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPass self=(UnityEngine.Experimental.Rendering.RenderPass)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sampleCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_context(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPass self=(UnityEngine.Experimental.Rendering.RenderPass)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.context);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RenderPass");
		addMember(l,Dispose);
		addMember(l,Dispose_s);
		addMember(l,"colorAttachments",get_colorAttachments,null,true);
		addMember(l,"depthAttachment",get_depthAttachment,null,true);
		addMember(l,"width",get_width,null,true);
		addMember(l,"height",get_height,null,true);
		addMember(l,"sampleCount",get_sampleCount,null,true);
		addMember(l,"context",get_context,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.RenderPass));
	}
}
