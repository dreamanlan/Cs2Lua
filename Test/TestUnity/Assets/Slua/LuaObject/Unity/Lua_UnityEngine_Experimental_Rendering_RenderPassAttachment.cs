using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RenderPassAttachment : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPassAttachment o;
			UnityEngine.RenderTextureFormat a1;
			checkEnum(l,2,out a1);
			o=new UnityEngine.Experimental.Rendering.RenderPassAttachment(a1);
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
	static public int BindSurface(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPassAttachment self=(UnityEngine.Experimental.Rendering.RenderPassAttachment)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.BindSurface(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BindResolveSurface(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPassAttachment self=(UnityEngine.Experimental.Rendering.RenderPassAttachment)checkSelf(l);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			self.BindResolveSurface(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Clear(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPassAttachment self=(UnityEngine.Experimental.Rendering.RenderPassAttachment)checkSelf(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.UInt32 a3;
			checkType(l,4,out a3);
			self.Clear(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Internal_CreateAttachment_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPassAttachment a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Rendering.RenderPassAttachment.Internal_CreateAttachment(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_loadAction(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPassAttachment self=(UnityEngine.Experimental.Rendering.RenderPassAttachment)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.loadAction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_storeAction(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPassAttachment self=(UnityEngine.Experimental.Rendering.RenderPassAttachment)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.storeAction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_format(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPassAttachment self=(UnityEngine.Experimental.Rendering.RenderPassAttachment)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.format);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_clearColor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPassAttachment self=(UnityEngine.Experimental.Rendering.RenderPassAttachment)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clearColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_clearDepth(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPassAttachment self=(UnityEngine.Experimental.Rendering.RenderPassAttachment)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clearDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_clearStencil(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderPassAttachment self=(UnityEngine.Experimental.Rendering.RenderPassAttachment)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clearStencil);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RenderPassAttachment");
		addMember(l,BindSurface);
		addMember(l,BindResolveSurface);
		addMember(l,Clear);
		addMember(l,Internal_CreateAttachment_s);
		addMember(l,"loadAction",get_loadAction,null,true);
		addMember(l,"storeAction",get_storeAction,null,true);
		addMember(l,"format",get_format,null,true);
		addMember(l,"clearColor",get_clearColor,null,true);
		addMember(l,"clearDepth",get_clearDepth,null,true);
		addMember(l,"clearStencil",get_clearStencil,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.RenderPassAttachment),typeof(UnityEngine.Object));
	}
}
