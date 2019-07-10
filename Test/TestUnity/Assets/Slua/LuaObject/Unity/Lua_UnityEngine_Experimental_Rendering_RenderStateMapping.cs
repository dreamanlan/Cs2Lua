using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RenderStateMapping : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Experimental.Rendering.RenderStateMapping o;
			if(argc==4){
				System.String a1;
				checkType(l,3,out a1);
				UnityEngine.Experimental.Rendering.RenderStateBlock a2;
				checkValueType(l,4,out a2);
				o=new UnityEngine.Experimental.Rendering.RenderStateMapping(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Experimental.Rendering.RenderStateBlock a1;
				checkValueType(l,3,out a1);
				o=new UnityEngine.Experimental.Rendering.RenderStateMapping(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc<=1){
				o=new UnityEngine.Experimental.Rendering.RenderStateMapping();
				pushValue(l,true);
				pushObject(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderType(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateMapping self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.renderType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderType(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateMapping self;
			checkValueType(l,1,out self);
			string v;
			checkType(l,2,out v);
			self.renderType=v;
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
	static public int get_stateBlock(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateMapping self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.stateBlock);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stateBlock(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RenderStateMapping self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.RenderStateBlock v;
			checkValueType(l,2,out v);
			self.stateBlock=v;
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
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RenderStateMapping");
		addMember(l,"renderType",get_renderType,set_renderType,true);
		addMember(l,"stateBlock",get_stateBlock,set_stateBlock,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.RenderStateMapping),typeof(System.ValueType));
	}
}
