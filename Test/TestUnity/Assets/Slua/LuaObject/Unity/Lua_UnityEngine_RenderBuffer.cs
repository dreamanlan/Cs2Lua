using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RenderBuffer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.RenderBuffer o;
			o=new UnityEngine.RenderBuffer();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNativeRenderBufferPtr(IntPtr l) {
		try {
			UnityEngine.RenderBuffer self;
			checkValueType(l,1,out self);
			var ret=self.GetNativeRenderBufferPtr();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RenderBuffer");
		addMember(l,GetNativeRenderBufferPtr);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RenderBuffer),typeof(System.ValueType));
	}
}
