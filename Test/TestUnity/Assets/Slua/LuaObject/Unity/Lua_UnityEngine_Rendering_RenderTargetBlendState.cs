using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RenderTargetBlendState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBlendState o;
			o=new UnityEngine.Rendering.RenderTargetBlendState();
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
	static public int ctor__ColorWriteMask__BlendMode__BlendMode__BlendMode__BlendMode__BlendOp__BlendOp_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBlendState o;
			UnityEngine.Rendering.ColorWriteMask a1;
			checkEnum(l,1,out a1);
			UnityEngine.Rendering.BlendMode a2;
			checkEnum(l,2,out a2);
			UnityEngine.Rendering.BlendMode a3;
			checkEnum(l,3,out a3);
			UnityEngine.Rendering.BlendMode a4;
			checkEnum(l,4,out a4);
			UnityEngine.Rendering.BlendMode a5;
			checkEnum(l,5,out a5);
			UnityEngine.Rendering.BlendOp a6;
			checkEnum(l,6,out a6);
			UnityEngine.Rendering.BlendOp a7;
			checkEnum(l,7,out a7);
			o=new UnityEngine.Rendering.RenderTargetBlendState(a1,a2,a3,a4,a5,a6,a7);
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
	static public int Equals__RenderTargetBlendState(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderTargetBlendState a1;
			checkValueType(l,2,out a1);
			var ret=self.Equals(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int op_Equality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBlendState a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.RenderTargetBlendState a2;
			checkValueType(l,2,out a2);
			var ret=(a1==a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int op_Inequality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBlendState a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.RenderTargetBlendState a2;
			checkValueType(l,2,out a2);
			var ret=(a1!=a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultValue(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.RenderTargetBlendState.defaultValue);
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
			UnityEngine.Rendering.RenderTargetBlendState self;
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
			UnityEngine.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.ColorWriteMask v;
			checkEnum(l,2,out v);
			self.writeMask=v;
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
	static public int get_sourceColorBlendMode(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBlendState self;
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
			UnityEngine.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BlendMode v;
			checkEnum(l,2,out v);
			self.sourceColorBlendMode=v;
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
	static public int get_destinationColorBlendMode(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBlendState self;
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
			UnityEngine.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BlendMode v;
			checkEnum(l,2,out v);
			self.destinationColorBlendMode=v;
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
	static public int get_sourceAlphaBlendMode(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBlendState self;
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
			UnityEngine.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BlendMode v;
			checkEnum(l,2,out v);
			self.sourceAlphaBlendMode=v;
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
	static public int get_destinationAlphaBlendMode(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBlendState self;
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
			UnityEngine.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BlendMode v;
			checkEnum(l,2,out v);
			self.destinationAlphaBlendMode=v;
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
	static public int get_colorBlendOperation(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBlendState self;
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
			UnityEngine.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BlendOp v;
			checkEnum(l,2,out v);
			self.colorBlendOperation=v;
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
	static public int get_alphaBlendOperation(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetBlendState self;
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
			UnityEngine.Rendering.RenderTargetBlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BlendOp v;
			checkEnum(l,2,out v);
			self.alphaBlendOperation=v;
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
		getTypeTable(l,"UnityEngine.Rendering.RenderTargetBlendState");
		addMember(l,ctor_s);
		addMember(l,ctor__ColorWriteMask__BlendMode__BlendMode__BlendMode__BlendMode__BlendOp__BlendOp_s);
		addMember(l,Equals__RenderTargetBlendState);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"defaultValue",get_defaultValue,null,false);
		addMember(l,"writeMask",get_writeMask,set_writeMask,true);
		addMember(l,"sourceColorBlendMode",get_sourceColorBlendMode,set_sourceColorBlendMode,true);
		addMember(l,"destinationColorBlendMode",get_destinationColorBlendMode,set_destinationColorBlendMode,true);
		addMember(l,"sourceAlphaBlendMode",get_sourceAlphaBlendMode,set_sourceAlphaBlendMode,true);
		addMember(l,"destinationAlphaBlendMode",get_destinationAlphaBlendMode,set_destinationAlphaBlendMode,true);
		addMember(l,"colorBlendOperation",get_colorBlendOperation,set_colorBlendOperation,true);
		addMember(l,"alphaBlendOperation",get_alphaBlendOperation,set_alphaBlendOperation,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.RenderTargetBlendState),typeof(System.ValueType));
	}
}
