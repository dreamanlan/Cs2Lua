using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_GPUFence : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Rendering.GPUFence o;
			o=new UnityEngine.Rendering.GPUFence();
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
	static public int get_passed(IntPtr l) {
		try {
			UnityEngine.Rendering.GPUFence self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.passed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.GPUFence");
		addMember(l,"passed",get_passed,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.GPUFence),typeof(System.ValueType));
	}
}
