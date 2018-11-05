using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RenderStateBlock : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock o;
			UnityEngine.Experimental.Rendering.RenderStateMask a1;
			checkEnum(l,2,out a1);
			o=new UnityEngine.Experimental.Rendering.RenderStateBlock(a1);
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
	static public int get_blendState(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.blendState);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_blendState(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.BlendState v;
			checkValueType(l,2,out v);
			self.blendState=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rasterState(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rasterState);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rasterState(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RasterState v;
			checkValueType(l,2,out v);
			self.rasterState=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_depthState(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.depthState);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_depthState(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.DepthState v;
			checkValueType(l,2,out v);
			self.depthState=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_stencilState(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.stencilState);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stencilState(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.StencilState v;
			checkValueType(l,2,out v);
			self.stencilState=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_stencilReference(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.stencilReference);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stencilReference(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.stencilReference=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.mask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateBlock self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RenderStateMask v;
			checkEnum(l,2,out v);
			self.mask=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RenderStateBlock");
		addMember(l,"blendState",get_blendState,set_blendState,true);
		addMember(l,"rasterState",get_rasterState,set_rasterState,true);
		addMember(l,"depthState",get_depthState,set_depthState,true);
		addMember(l,"stencilState",get_stencilState,set_stencilState,true);
		addMember(l,"stencilReference",get_stencilReference,set_stencilReference,true);
		addMember(l,"mask",get_mask,set_mask,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.RenderStateBlock),typeof(System.ValueType));
	}
}
