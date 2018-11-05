using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RenderTargetBlendState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState o;
			UnityEngine.Rendering.ColorWriteMask a1;
			checkEnum(l,2,out a1);
			UnityEngine.Rendering.BlendMode a2;
			checkEnum(l,3,out a2);
			UnityEngine.Rendering.BlendMode a3;
			checkEnum(l,4,out a3);
			UnityEngine.Rendering.BlendMode a4;
			checkEnum(l,5,out a4);
			UnityEngine.Rendering.BlendMode a5;
			checkEnum(l,6,out a5);
			UnityEngine.Rendering.BlendOp a6;
			checkEnum(l,7,out a6);
			UnityEngine.Rendering.BlendOp a7;
			checkEnum(l,8,out a7);
			o=new UnityEngine.Experimental.Rendering.RenderTargetBlendState(a1,a2,a3,a4,a5,a6,a7);
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
	static public int get_Default(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.Rendering.RenderTargetBlendState.Default);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_writeMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.writeMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_writeMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.ColorWriteMask v;
			checkEnum(l,2,out v);
			self.writeMask=v;
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
	static public int get_sourceColorBlendMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.sourceColorBlendMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sourceColorBlendMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BlendMode v;
			checkEnum(l,2,out v);
			self.sourceColorBlendMode=v;
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
	static public int get_destinationColorBlendMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.destinationColorBlendMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_destinationColorBlendMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BlendMode v;
			checkEnum(l,2,out v);
			self.destinationColorBlendMode=v;
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
	static public int get_sourceAlphaBlendMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.sourceAlphaBlendMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sourceAlphaBlendMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BlendMode v;
			checkEnum(l,2,out v);
			self.sourceAlphaBlendMode=v;
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
	static public int get_destinationAlphaBlendMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.destinationAlphaBlendMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_destinationAlphaBlendMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BlendMode v;
			checkEnum(l,2,out v);
			self.destinationAlphaBlendMode=v;
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
	static public int get_colorBlendOperation(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.colorBlendOperation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colorBlendOperation(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BlendOp v;
			checkEnum(l,2,out v);
			self.colorBlendOperation=v;
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
	static public int get_alphaBlendOperation(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.alphaBlendOperation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_alphaBlendOperation(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BlendOp v;
			checkEnum(l,2,out v);
			self.alphaBlendOperation=v;
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
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RenderTargetBlendState");
		addMember(l,"Default",get_Default,null,false);
		addMember(l,"writeMask",get_writeMask,set_writeMask,true);
		addMember(l,"sourceColorBlendMode",get_sourceColorBlendMode,set_sourceColorBlendMode,true);
		addMember(l,"destinationColorBlendMode",get_destinationColorBlendMode,set_destinationColorBlendMode,true);
		addMember(l,"sourceAlphaBlendMode",get_sourceAlphaBlendMode,set_sourceAlphaBlendMode,true);
		addMember(l,"destinationAlphaBlendMode",get_destinationAlphaBlendMode,set_destinationAlphaBlendMode,true);
		addMember(l,"colorBlendOperation",get_colorBlendOperation,set_colorBlendOperation,true);
		addMember(l,"alphaBlendOperation",get_alphaBlendOperation,set_alphaBlendOperation,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.RenderTargetBlendState),typeof(System.ValueType));
	}
}
