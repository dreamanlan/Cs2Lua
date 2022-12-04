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
	static public int EncodeToJPG__Texture2D_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.ImageConversion.EncodeToJPG(a1);
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
	static public int EncodeToJPG__Texture2D__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.ImageConversion.EncodeToJPG(a1,a2);
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
	static public int EncodeToEXR__Texture2D_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.ImageConversion.EncodeToEXR(a1);
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
	static public int EncodeToEXR__Texture2D__EXRFlags_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			UnityEngine.Texture2D.EXRFlags a2;
			checkEnum(l,2,out a2);
			var ret=UnityEngine.ImageConversion.EncodeToEXR(a1,a2);
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
	static public int LoadImage__Texture2D__A_Byte_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			System.Byte[] a2;
			checkArray(l,2,out a2);
			var ret=UnityEngine.ImageConversion.LoadImage(a1,a2);
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
	static public int LoadImage__Texture2D__A_Byte__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			System.Byte[] a2;
			checkArray(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.ImageConversion.LoadImage(a1,a2,a3);
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
	static public int EncodeArrayToTGA_s(IntPtr l) {
		try {
			System.Array a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Rendering.GraphicsFormat a2;
			checkEnum(l,2,out a2);
			System.UInt32 a3;
			checkType(l,3,out a3);
			System.UInt32 a4;
			checkType(l,4,out a4);
			System.UInt32 a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.ImageConversion.EncodeArrayToTGA(a1,a2,a3,a4,a5);
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
	static public int EncodeArrayToPNG_s(IntPtr l) {
		try {
			System.Array a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Rendering.GraphicsFormat a2;
			checkEnum(l,2,out a2);
			System.UInt32 a3;
			checkType(l,3,out a3);
			System.UInt32 a4;
			checkType(l,4,out a4);
			System.UInt32 a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.ImageConversion.EncodeArrayToPNG(a1,a2,a3,a4,a5);
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
	static public int EncodeArrayToJPG_s(IntPtr l) {
		try {
			System.Array a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Rendering.GraphicsFormat a2;
			checkEnum(l,2,out a2);
			System.UInt32 a3;
			checkType(l,3,out a3);
			System.UInt32 a4;
			checkType(l,4,out a4);
			System.UInt32 a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.ImageConversion.EncodeArrayToJPG(a1,a2,a3,a4,a5,a6);
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
	static public int EncodeArrayToEXR_s(IntPtr l) {
		try {
			System.Array a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Rendering.GraphicsFormat a2;
			checkEnum(l,2,out a2);
			System.UInt32 a3;
			checkType(l,3,out a3);
			System.UInt32 a4;
			checkType(l,4,out a4);
			System.UInt32 a5;
			checkType(l,5,out a5);
			UnityEngine.Texture2D.EXRFlags a6;
			checkEnum(l,6,out a6);
			var ret=UnityEngine.ImageConversion.EncodeArrayToEXR(a1,a2,a3,a4,a5,a6);
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
	static public int get_EnableLegacyPngGammaRuntimeLoadBehavior(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.ImageConversion.EnableLegacyPngGammaRuntimeLoadBehavior);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_EnableLegacyPngGammaRuntimeLoadBehavior(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.ImageConversion.EnableLegacyPngGammaRuntimeLoadBehavior=v;
			pushValue(l,true);
			return 1;
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
		addMember(l,EncodeToJPG__Texture2D_s);
		addMember(l,EncodeToJPG__Texture2D__Int32_s);
		addMember(l,EncodeToEXR__Texture2D_s);
		addMember(l,EncodeToEXR__Texture2D__EXRFlags_s);
		addMember(l,LoadImage__Texture2D__A_Byte_s);
		addMember(l,LoadImage__Texture2D__A_Byte__Boolean_s);
		addMember(l,EncodeArrayToTGA_s);
		addMember(l,EncodeArrayToPNG_s);
		addMember(l,EncodeArrayToJPG_s);
		addMember(l,EncodeArrayToEXR_s);
		addMember(l,"EnableLegacyPngGammaRuntimeLoadBehavior",get_EnableLegacyPngGammaRuntimeLoadBehavior,set_EnableLegacyPngGammaRuntimeLoadBehavior,false);
		createTypeMetatable(l,null, typeof(UnityEngine.ImageConversion));
	}
}
