using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_BlendState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState o;
			System.Boolean a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			o=new UnityEngine.Experimental.Rendering.BlendState(a1,a2);
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
			pushValue(l,UnityEngine.Experimental.Rendering.BlendState.Default);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_separateMRTBlendStates(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.separateMRTBlendStates);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_separateMRTBlendStates(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.separateMRTBlendStates=v;
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
	static public int get_alphaToMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.alphaToMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_alphaToMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.alphaToMask=v;
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
	static public int get_blendState0(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.blendState0);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_blendState0(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RenderTargetBlendState v;
			checkValueType(l,2,out v);
			self.blendState0=v;
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
	static public int get_blendState1(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.blendState1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_blendState1(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RenderTargetBlendState v;
			checkValueType(l,2,out v);
			self.blendState1=v;
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
	static public int get_blendState2(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.blendState2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_blendState2(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RenderTargetBlendState v;
			checkValueType(l,2,out v);
			self.blendState2=v;
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
	static public int get_blendState3(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.blendState3);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_blendState3(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RenderTargetBlendState v;
			checkValueType(l,2,out v);
			self.blendState3=v;
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
	static public int get_blendState4(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.blendState4);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_blendState4(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RenderTargetBlendState v;
			checkValueType(l,2,out v);
			self.blendState4=v;
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
	static public int get_blendState5(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.blendState5);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_blendState5(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RenderTargetBlendState v;
			checkValueType(l,2,out v);
			self.blendState5=v;
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
	static public int get_blendState6(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.blendState6);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_blendState6(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RenderTargetBlendState v;
			checkValueType(l,2,out v);
			self.blendState6=v;
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
	static public int get_blendState7(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.blendState7);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_blendState7(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.BlendState self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RenderTargetBlendState v;
			checkValueType(l,2,out v);
			self.blendState7=v;
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
		getTypeTable(l,"UnityEngine.Experimental.Rendering.BlendState");
		addMember(l,"Default",get_Default,null,false);
		addMember(l,"separateMRTBlendStates",get_separateMRTBlendStates,set_separateMRTBlendStates,true);
		addMember(l,"alphaToMask",get_alphaToMask,set_alphaToMask,true);
		addMember(l,"blendState0",get_blendState0,set_blendState0,true);
		addMember(l,"blendState1",get_blendState1,set_blendState1,true);
		addMember(l,"blendState2",get_blendState2,set_blendState2,true);
		addMember(l,"blendState3",get_blendState3,set_blendState3,true);
		addMember(l,"blendState4",get_blendState4,set_blendState4,true);
		addMember(l,"blendState5",get_blendState5,set_blendState5,true);
		addMember(l,"blendState6",get_blendState6,set_blendState6,true);
		addMember(l,"blendState7",get_blendState7,set_blendState7,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.BlendState),typeof(System.ValueType));
	}
}
