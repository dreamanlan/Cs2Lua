using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_PIX : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.PIX o;
			o=new UnityEngine.Rendering.PIX();
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
	static public int BeginGPUCapture_s(IntPtr l) {
		try {
			UnityEngine.Rendering.PIX.BeginGPUCapture();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EndGPUCapture_s(IntPtr l) {
		try {
			UnityEngine.Rendering.PIX.EndGPUCapture();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsAttached_s(IntPtr l) {
		try {
			var ret=UnityEngine.Rendering.PIX.IsAttached();
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
		getTypeTable(l,"UnityEngine.Rendering.PIX");
		addMember(l,ctor_s);
		addMember(l,BeginGPUCapture_s);
		addMember(l,EndGPUCapture_s);
		addMember(l,IsAttached_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.PIX));
	}
}
