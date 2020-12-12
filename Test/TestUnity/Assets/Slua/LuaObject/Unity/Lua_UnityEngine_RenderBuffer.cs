using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_RenderBuffer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
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
	[UnityEngine.Scripting.Preserve]
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RenderBuffer");
		addMember(l,ctor_s);
		addMember(l,GetNativeRenderBufferPtr);
		createTypeMetatable(l,null, typeof(UnityEngine.RenderBuffer),typeof(System.ValueType));
	}
}
