using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_CommandBufferExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SwitchIntoFastMemory_s(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,2,out a2);
			UnityEngine.Rendering.FastMemoryFlags a3;
			checkEnum(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			UnityEngine.Rendering.CommandBufferExtensions.SwitchIntoFastMemory(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SwitchOutOfFastMemory_s(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer a1;
			checkType(l,1,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			UnityEngine.Rendering.CommandBufferExtensions.SwitchOutOfFastMemory(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.CommandBufferExtensions");
		addMember(l,SwitchIntoFastMemory_s);
		addMember(l,SwitchOutOfFastMemory_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.CommandBufferExtensions));
	}
}
