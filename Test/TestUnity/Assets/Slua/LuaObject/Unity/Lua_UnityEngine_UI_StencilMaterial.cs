using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_StencilMaterial : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Add__Material__Int32__StencilOp__CompareFunction__ColorWriteMask_s(IntPtr l) {
		try {
			UnityEngine.Material a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Rendering.StencilOp a3;
			checkEnum(l,3,out a3);
			UnityEngine.Rendering.CompareFunction a4;
			checkEnum(l,4,out a4);
			UnityEngine.Rendering.ColorWriteMask a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.UI.StencilMaterial.Add(a1,a2,a3,a4,a5);
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
	static public int Add__Material__Int32__StencilOp__CompareFunction__ColorWriteMask__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.Material a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Rendering.StencilOp a3;
			checkEnum(l,3,out a3);
			UnityEngine.Rendering.CompareFunction a4;
			checkEnum(l,4,out a4);
			UnityEngine.Rendering.ColorWriteMask a5;
			checkEnum(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			var ret=UnityEngine.UI.StencilMaterial.Add(a1,a2,a3,a4,a5,a6,a7);
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
	static public int Remove_s(IntPtr l) {
		try {
			UnityEngine.Material a1;
			checkType(l,1,out a1);
			UnityEngine.UI.StencilMaterial.Remove(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearAll_s(IntPtr l) {
		try {
			UnityEngine.UI.StencilMaterial.ClearAll();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.StencilMaterial");
		addMember(l,Add__Material__Int32__StencilOp__CompareFunction__ColorWriteMask_s);
		addMember(l,Add__Material__Int32__StencilOp__CompareFunction__ColorWriteMask__Int32__Int32_s);
		addMember(l,Remove_s);
		addMember(l,ClearAll_s);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.StencilMaterial));
	}
}
