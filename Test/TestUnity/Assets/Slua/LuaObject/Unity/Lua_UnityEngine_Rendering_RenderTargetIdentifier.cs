using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_RenderTargetIdentifier : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Rendering.RenderTargetIdentifier o;
			if(matchType(l,argc,2,typeof(string),typeof(int),typeof(UnityEngine.CubemapFace),typeof(int))){
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.CubemapFace a3;
				checkEnum(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				o=new UnityEngine.Rendering.RenderTargetIdentifier(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(int),typeof(UnityEngine.CubemapFace),typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.CubemapFace a3;
				checkEnum(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				o=new UnityEngine.Rendering.RenderTargetIdentifier(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.RenderBuffer),typeof(int),typeof(UnityEngine.CubemapFace),typeof(int))){
				UnityEngine.RenderBuffer a1;
				checkValueType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.CubemapFace a3;
				checkEnum(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				o=new UnityEngine.Rendering.RenderTargetIdentifier(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Texture),typeof(int),typeof(UnityEngine.CubemapFace),typeof(int))){
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.CubemapFace a3;
				checkEnum(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				o=new UnityEngine.Rendering.RenderTargetIdentifier(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Texture))){
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				o=new UnityEngine.Rendering.RenderTargetIdentifier(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.BuiltinRenderTextureType))){
				UnityEngine.Rendering.BuiltinRenderTextureType a1;
				checkEnum(l,2,out a1);
				o=new UnityEngine.Rendering.RenderTargetIdentifier(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				System.String a1;
				checkType(l,2,out a1);
				o=new UnityEngine.Rendering.RenderTargetIdentifier(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				o=new UnityEngine.Rendering.RenderTargetIdentifier(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc<=1){
				o=new UnityEngine.Rendering.RenderTargetIdentifier();
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
	static public int op_Equality(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
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
	static public int op_Inequality(IntPtr l) {
		try {
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.RenderTargetIdentifier");
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(System.ValueType));
	}
}
