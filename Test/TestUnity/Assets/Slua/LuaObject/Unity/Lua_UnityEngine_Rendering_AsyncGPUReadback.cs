using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_AsyncGPUReadback : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Request_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==11){
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				System.Int32 a6;
				checkType(l,7,out a6);
				System.Int32 a7;
				checkType(l,8,out a7);
				System.Int32 a8;
				checkType(l,9,out a8);
				UnityEngine.TextureFormat a9;
				checkEnum(l,10,out a9);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a10;
				LuaDelegation.checkDelegate(l,11,out a10);
				var ret=UnityEngine.Rendering.AsyncGPUReadback.Request(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==10){
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				System.Int32 a6;
				checkType(l,7,out a6);
				System.Int32 a7;
				checkType(l,8,out a7);
				System.Int32 a8;
				checkType(l,9,out a8);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a9;
				LuaDelegation.checkDelegate(l,10,out a9);
				var ret=UnityEngine.Rendering.AsyncGPUReadback.Request(a1,a2,a3,a4,a5,a6,a7,a8,a9);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Request__ComputeBuffer__Int32__Int32__Action`1_AsyncGPUReadbackRequest", argc, 1,typeof(UnityEngine.ComputeBuffer),typeof(int),typeof(int),typeof(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>))){
				UnityEngine.ComputeBuffer a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a4;
				LuaDelegation.checkDelegate(l,5,out a4);
				var ret=UnityEngine.Rendering.AsyncGPUReadback.Request(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Request__Texture__Int32__TextureFormat__Action`1_AsyncGPUReadbackRequest", argc, 1,typeof(UnityEngine.Texture),typeof(int),typeof(UnityEngine.TextureFormat),typeof(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest>))){
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.TextureFormat a3;
				checkEnum(l,4,out a3);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a4;
				LuaDelegation.checkDelegate(l,5,out a4);
				var ret=UnityEngine.Rendering.AsyncGPUReadback.Request(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a3;
				LuaDelegation.checkDelegate(l,4,out a3);
				var ret=UnityEngine.Rendering.AsyncGPUReadback.Request(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.ComputeBuffer a1;
				checkType(l,2,out a1);
				System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> a2;
				LuaDelegation.checkDelegate(l,3,out a2);
				var ret=UnityEngine.Rendering.AsyncGPUReadback.Request(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.AsyncGPUReadback");
		addMember(l,Request_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.AsyncGPUReadback));
	}
}
