using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ImageConversion : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EncodeToTGA_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.ImageConversion.EncodeToTGA(a1);
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
	static public int EncodeToPNG_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.ImageConversion.EncodeToPNG(a1);
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
	static public int EncodeToJPG_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Texture2D a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=UnityEngine.ImageConversion.EncodeToJPG(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Texture2D a1;
				checkType(l,2,out a1);
				var ret=UnityEngine.ImageConversion.EncodeToJPG(a1);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EncodeToEXR_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Texture2D a1;
				checkType(l,2,out a1);
				UnityEngine.Texture2D.EXRFlags a2;
				checkEnum(l,3,out a2);
				var ret=UnityEngine.ImageConversion.EncodeToEXR(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Texture2D a1;
				checkType(l,2,out a1);
				var ret=UnityEngine.ImageConversion.EncodeToEXR(a1);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadImage_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Texture2D a1;
				checkType(l,2,out a1);
				System.Byte[] a2;
				checkArray(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				var ret=UnityEngine.ImageConversion.LoadImage(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Texture2D a1;
				checkType(l,2,out a1);
				System.Byte[] a2;
				checkArray(l,3,out a2);
				var ret=UnityEngine.ImageConversion.LoadImage(a1,a2);
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
		getTypeTable(l,"UnityEngine.ImageConversion");
		addMember(l,EncodeToTGA_s);
		addMember(l,EncodeToPNG_s);
		addMember(l,EncodeToJPG_s);
		addMember(l,EncodeToEXR_s);
		addMember(l,LoadImage_s);
		createTypeMetatable(l,null, typeof(UnityEngine.ImageConversion));
	}
}
