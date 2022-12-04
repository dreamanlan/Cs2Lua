using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RenderTargetBinding : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding o;
			o=new UnityEngine.Rendering.RenderTargetBinding();
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
	static public int ctor__RenderTargetSetup_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding o;
			UnityEngine.RenderTargetSetup a1;
			checkValueType(l,1,out a1);
			o=new UnityEngine.Rendering.RenderTargetBinding(a1);
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
	static public int ctor__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding o;
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.RenderBufferLoadAction a2;
			checkEnum(l,2,out a2);
			UnityEngine.Rendering.RenderBufferStoreAction a3;
			checkEnum(l,3,out a3);
			UnityEngine.Rendering.RenderTargetIdentifier a4;
			checkValueType(l,4,out a4);
			UnityEngine.Rendering.RenderBufferLoadAction a5;
			checkEnum(l,5,out a5);
			UnityEngine.Rendering.RenderBufferStoreAction a6;
			checkEnum(l,6,out a6);
			o=new UnityEngine.Rendering.RenderTargetBinding(a1,a2,a3,a4,a5,a6);
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
	static public int ctor__A_RenderTargetIdentifier__A_RenderBufferLoadAction__A_RenderBufferStoreAction__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding o;
			UnityEngine.Rendering.RenderTargetIdentifier[] a1;
			checkArray(l,1,out a1);
			UnityEngine.Rendering.RenderBufferLoadAction[] a2;
			checkArray(l,2,out a2);
			UnityEngine.Rendering.RenderBufferStoreAction[] a3;
			checkArray(l,3,out a3);
			UnityEngine.Rendering.RenderTargetIdentifier a4;
			checkValueType(l,4,out a4);
			UnityEngine.Rendering.RenderBufferLoadAction a5;
			checkEnum(l,5,out a5);
			UnityEngine.Rendering.RenderBufferStoreAction a6;
			checkEnum(l,6,out a6);
			o=new UnityEngine.Rendering.RenderTargetBinding(a1,a2,a3,a4,a5,a6);
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
	static public int get_colorRenderTargets(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.colorRenderTargets);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colorRenderTargets(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderTargetIdentifier[] v;
			checkArray(l,2,out v);
			self.colorRenderTargets=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depthRenderTarget(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.depthRenderTarget);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depthRenderTarget(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderTargetIdentifier v;
			checkValueType(l,2,out v);
			self.depthRenderTarget=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colorLoadActions(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.colorLoadActions);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colorLoadActions(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferLoadAction[] v;
			checkArray(l,2,out v);
			self.colorLoadActions=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colorStoreActions(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.colorStoreActions);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colorStoreActions(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferStoreAction[] v;
			checkArray(l,2,out v);
			self.colorStoreActions=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depthLoadAction(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.depthLoadAction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depthLoadAction(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferLoadAction v;
			checkEnum(l,2,out v);
			self.depthLoadAction=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depthStoreAction(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.depthStoreAction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depthStoreAction(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferStoreAction v;
			checkEnum(l,2,out v);
			self.depthStoreAction=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_flags(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.flags);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_flags(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBinding self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderTargetFlags v;
			checkEnum(l,2,out v);
			self.flags=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.RenderTargetBinding");
		addMember(l,ctor_s);
		addMember(l,ctor__RenderTargetSetup_s);
		addMember(l,ctor__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction_s);
		addMember(l,ctor__A_RenderTargetIdentifier__A_RenderBufferLoadAction__A_RenderBufferStoreAction__RenderTargetIdentifier__RenderBufferLoadAction__RenderBufferStoreAction_s);
		addMember(l,"colorRenderTargets",get_colorRenderTargets,set_colorRenderTargets,true);
		addMember(l,"depthRenderTarget",get_depthRenderTarget,set_depthRenderTarget,true);
		addMember(l,"colorLoadActions",get_colorLoadActions,set_colorLoadActions,true);
		addMember(l,"colorStoreActions",get_colorStoreActions,set_colorStoreActions,true);
		addMember(l,"depthLoadAction",get_depthLoadAction,set_depthLoadAction,true);
		addMember(l,"depthStoreAction",get_depthStoreAction,set_depthStoreAction,true);
		addMember(l,"flags",get_flags,set_flags,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.RenderTargetBinding),typeof(System.ValueType));
	}
}
