using System;
using SLua;
using System.Collections.Generic;
using UnityEngine;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Texture2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.Texture2D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Texture2D(a1,a2);
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
	static public int ctor__Int32__Int32__DefaultFormat__TextureCreationFlags_s(IntPtr l) {
		try {
			UnityEngine.Texture2D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Experimental.Rendering.DefaultFormat a3;
			checkEnum(l,3,out a3);
			UnityEngine.Experimental.Rendering.TextureCreationFlags a4;
			checkEnum(l,4,out a4);
			o=new UnityEngine.Texture2D(a1,a2,a3,a4);
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
	static public int ctor__Int32__Int32__GraphicsFormat__TextureCreationFlags_s(IntPtr l) {
		try {
			UnityEngine.Texture2D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Experimental.Rendering.GraphicsFormat a3;
			checkEnum(l,3,out a3);
			UnityEngine.Experimental.Rendering.TextureCreationFlags a4;
			checkEnum(l,4,out a4);
			o=new UnityEngine.Texture2D(a1,a2,a3,a4);
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
	static public int ctor__Int32__Int32__TextureFormat__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Texture2D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.TextureFormat a3;
			checkEnum(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Texture2D(a1,a2,a3,a4);
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
	static public int ctor__Int32__Int32__GraphicsFormat__Int32__TextureCreationFlags_s(IntPtr l) {
		try {
			UnityEngine.Texture2D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Experimental.Rendering.GraphicsFormat a3;
			checkEnum(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Experimental.Rendering.TextureCreationFlags a5;
			checkEnum(l,5,out a5);
			o=new UnityEngine.Texture2D(a1,a2,a3,a4,a5);
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
	static public int ctor__Int32__Int32__TextureFormat__Int32__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Texture2D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.TextureFormat a3;
			checkEnum(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			o=new UnityEngine.Texture2D(a1,a2,a3,a4,a5);
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
	static public int ctor__Int32__Int32__TextureFormat__Boolean__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Texture2D o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.TextureFormat a3;
			checkEnum(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			o=new UnityEngine.Texture2D(a1,a2,a3,a4,a5);
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
	static public int Compress(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Compress(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearRequestedMipmapLevel(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			self.ClearRequestedMipmapLevel();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsRequestedMipmapLevelLoaded(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			var ret=self.IsRequestedMipmapLevelLoaded();
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
	static public int ClearMinimumMipmapLevel(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			self.ClearMinimumMipmapLevel();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateExternalTexture(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.IntPtr a1;
			checkType(l,2,out a1);
			self.UpdateExternalTexture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetRawTextureData(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			var ret=self.GetRawTextureData();
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
	static public int GetPixels(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			var ret=self.GetPixels();
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
	static public int GetPixels__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPixels(a1);
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
	static public int GetPixels__Int32__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			var ret=self.GetPixels(a1,a2,a3,a4);
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
	static public int GetPixels__Int32__Int32__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			var ret=self.GetPixels(a1,a2,a3,a4,a5);
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
	static public int GetPixels32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			var ret=self.GetPixels32();
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
	static public int GetPixels32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPixels32(a1);
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
	static public int PackTextures__A_Texture2D__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			UnityEngine.Texture2D[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.PackTextures(a1,a2);
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
	static public int PackTextures__A_Texture2D__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			UnityEngine.Texture2D[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.PackTextures(a1,a2,a3);
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
	static public int PackTextures__A_Texture2D__Int32__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			UnityEngine.Texture2D[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			var ret=self.PackTextures(a1,a2,a3,a4);
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
	static public int SetPixel__Int32__Int32__Color(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Color a3;
			checkType(l,4,out a3);
			self.SetPixel(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixel__Int32__Int32__Color__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Color a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetPixel(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixels__A_Color(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			UnityEngine.Color[] a1;
			checkArray(l,2,out a1);
			self.SetPixels(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixels__A_Color__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			UnityEngine.Color[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetPixels(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixels__Int32__Int32__Int32__Int32__A_Color(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.Color[] a5;
			checkArray(l,6,out a5);
			self.SetPixels(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixels__Int32__Int32__Int32__Int32__A_Color__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.Color[] a5;
			checkArray(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			self.SetPixels(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPixel__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.GetPixel(a1,a2);
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
	static public int GetPixel__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.GetPixel(a1,a2,a3);
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
	static public int GetPixelBilinear__Single__Single(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.GetPixelBilinear(a1,a2);
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
	static public int GetPixelBilinear__Single__Single__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.GetPixelBilinear(a1,a2,a3);
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
	static public int LoadRawTextureData__A_Byte(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			self.LoadRawTextureData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadRawTextureData__IntPtr__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.IntPtr a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.LoadRawTextureData(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Apply(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			self.Apply();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Apply__Boolean(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Apply(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Apply__Boolean__Boolean(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.Apply(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Reinitialize__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.Reinitialize(a1,a2);
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
	static public int Reinitialize__Int32__Int32__TextureFormat__Boolean(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.TextureFormat a3;
			checkEnum(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			var ret=self.Reinitialize(a1,a2,a3,a4);
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
	static public int Reinitialize__Int32__Int32__GraphicsFormat__Boolean(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Experimental.Rendering.GraphicsFormat a3;
			checkEnum(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			var ret=self.Reinitialize(a1,a2,a3,a4);
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
	static public int ReadPixels__Rect__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.ReadPixels(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadPixels__Rect__Int32__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			self.ReadPixels(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixels32__A_Color32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			UnityEngine.Color32[] a1;
			checkArray(l,2,out a1);
			self.SetPixels32(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixels32__A_Color32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			UnityEngine.Color32[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetPixels32(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixels32__Int32__Int32__Int32__Int32__A_Color32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.Color32[] a5;
			checkArray(l,6,out a5);
			self.SetPixels32(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPixels32__Int32__Int32__Int32__Int32__A_Color32__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.Color32[] a5;
			checkArray(l,6,out a5);
			System.Int32 a6;
			checkType(l,7,out a6);
			self.SetPixels32(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EncodeToTGA(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			var ret=self.EncodeToTGA();
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
	static public int EncodeToPNG(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			var ret=self.EncodeToPNG();
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
	static public int EncodeToJPG__Texture2D(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			var ret=self.EncodeToJPG();
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
	static public int EncodeToJPG__Texture2D__Int32(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=self.EncodeToJPG(a2);
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
	static public int EncodeToEXR__Texture2D(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			var ret=self.EncodeToEXR();
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
	static public int EncodeToEXR__Texture2D__EXRFlags(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			UnityEngine.Texture2D.EXRFlags a2;
			checkEnum(l,2,out a2);
			var ret=self.EncodeToEXR(a2);
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
	static public int LoadImage__Texture2D__A_Byte(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Byte[] a2;
			checkArray(l,2,out a2);
			var ret=self.LoadImage(a2);
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
	static public int LoadImage__Texture2D__A_Byte__Boolean(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			System.Byte[] a2;
			checkArray(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			var ret=self.LoadImage(a2,a3);
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
	static public int CreateExternalTexture_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.TextureFormat a3;
			checkEnum(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			System.IntPtr a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.Texture2D.CreateExternalTexture(a1,a2,a3,a4,a5,a6);
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
	static public int get_format(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.format);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ignoreMipmapLimit(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ignoreMipmapLimit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_ignoreMipmapLimit(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.ignoreMipmapLimit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_whiteTexture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture2D.whiteTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_blackTexture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture2D.blackTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_redTexture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture2D.redTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_grayTexture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture2D.grayTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_linearGrayTexture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture2D.linearGrayTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_normalTexture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Texture2D.normalTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isReadable(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isReadable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_vtOnly(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vtOnly);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_streamingMipmaps(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.streamingMipmaps);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_streamingMipmapsPriority(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.streamingMipmapsPriority);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_requestedMipmapLevel(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.requestedMipmapLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_requestedMipmapLevel(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.requestedMipmapLevel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_minimumMipmapLevel(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minimumMipmapLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_minimumMipmapLevel(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.minimumMipmapLevel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_calculatedMipmapLevel(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.calculatedMipmapLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_desiredMipmapLevel(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.desiredMipmapLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_loadingMipmapLevel(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.loadingMipmapLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_loadedMipmapLevel(IntPtr l) {
		try {
			UnityEngine.Texture2D self=(UnityEngine.Texture2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.loadedMipmapLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Texture2D");
		addMember(l,ctor__Int32__Int32_s);
		addMember(l,ctor__Int32__Int32__DefaultFormat__TextureCreationFlags_s);
		addMember(l,ctor__Int32__Int32__GraphicsFormat__TextureCreationFlags_s);
		addMember(l,ctor__Int32__Int32__TextureFormat__Boolean_s);
		addMember(l,ctor__Int32__Int32__GraphicsFormat__Int32__TextureCreationFlags_s);
		addMember(l,ctor__Int32__Int32__TextureFormat__Int32__Boolean_s);
		addMember(l,ctor__Int32__Int32__TextureFormat__Boolean__Boolean_s);
		addMember(l,Compress);
		addMember(l,ClearRequestedMipmapLevel);
		addMember(l,IsRequestedMipmapLevelLoaded);
		addMember(l,ClearMinimumMipmapLevel);
		addMember(l,UpdateExternalTexture);
		addMember(l,GetRawTextureData);
		addMember(l,GetPixels);
		addMember(l,GetPixels__Int32);
		addMember(l,GetPixels__Int32__Int32__Int32__Int32);
		addMember(l,GetPixels__Int32__Int32__Int32__Int32__Int32);
		addMember(l,GetPixels32);
		addMember(l,GetPixels32__Int32);
		addMember(l,PackTextures__A_Texture2D__Int32);
		addMember(l,PackTextures__A_Texture2D__Int32__Int32);
		addMember(l,PackTextures__A_Texture2D__Int32__Int32__Boolean);
		addMember(l,SetPixel__Int32__Int32__Color);
		addMember(l,SetPixel__Int32__Int32__Color__Int32);
		addMember(l,SetPixels__A_Color);
		addMember(l,SetPixels__A_Color__Int32);
		addMember(l,SetPixels__Int32__Int32__Int32__Int32__A_Color);
		addMember(l,SetPixels__Int32__Int32__Int32__Int32__A_Color__Int32);
		addMember(l,GetPixel__Int32__Int32);
		addMember(l,GetPixel__Int32__Int32__Int32);
		addMember(l,GetPixelBilinear__Single__Single);
		addMember(l,GetPixelBilinear__Single__Single__Int32);
		addMember(l,LoadRawTextureData__A_Byte);
		addMember(l,LoadRawTextureData__IntPtr__Int32);
		addMember(l,Apply);
		addMember(l,Apply__Boolean);
		addMember(l,Apply__Boolean__Boolean);
		addMember(l,Reinitialize__Int32__Int32);
		addMember(l,Reinitialize__Int32__Int32__TextureFormat__Boolean);
		addMember(l,Reinitialize__Int32__Int32__GraphicsFormat__Boolean);
		addMember(l,ReadPixels__Rect__Int32__Int32);
		addMember(l,ReadPixels__Rect__Int32__Int32__Boolean);
		addMember(l,SetPixels32__A_Color32);
		addMember(l,SetPixels32__A_Color32__Int32);
		addMember(l,SetPixels32__Int32__Int32__Int32__Int32__A_Color32);
		addMember(l,SetPixels32__Int32__Int32__Int32__Int32__A_Color32__Int32);
		addMember(l,EncodeToTGA);
		addMember(l,EncodeToPNG);
		addMember(l,EncodeToJPG__Texture2D);
		addMember(l,EncodeToJPG__Texture2D__Int32);
		addMember(l,EncodeToEXR__Texture2D);
		addMember(l,EncodeToEXR__Texture2D__EXRFlags);
		addMember(l,LoadImage__Texture2D__A_Byte);
		addMember(l,LoadImage__Texture2D__A_Byte__Boolean);
		addMember(l,CreateExternalTexture_s);
		addMember(l,"format",get_format,null,true);
		addMember(l,"ignoreMipmapLimit",get_ignoreMipmapLimit,set_ignoreMipmapLimit,true);
		addMember(l,"whiteTexture",get_whiteTexture,null,false);
		addMember(l,"blackTexture",get_blackTexture,null,false);
		addMember(l,"redTexture",get_redTexture,null,false);
		addMember(l,"grayTexture",get_grayTexture,null,false);
		addMember(l,"linearGrayTexture",get_linearGrayTexture,null,false);
		addMember(l,"normalTexture",get_normalTexture,null,false);
		addMember(l,"isReadable",get_isReadable,null,true);
		addMember(l,"vtOnly",get_vtOnly,null,true);
		addMember(l,"streamingMipmaps",get_streamingMipmaps,null,true);
		addMember(l,"streamingMipmapsPriority",get_streamingMipmapsPriority,null,true);
		addMember(l,"requestedMipmapLevel",get_requestedMipmapLevel,set_requestedMipmapLevel,true);
		addMember(l,"minimumMipmapLevel",get_minimumMipmapLevel,set_minimumMipmapLevel,true);
		addMember(l,"calculatedMipmapLevel",get_calculatedMipmapLevel,null,true);
		addMember(l,"desiredMipmapLevel",get_desiredMipmapLevel,null,true);
		addMember(l,"loadingMipmapLevel",get_loadingMipmapLevel,null,true);
		addMember(l,"loadedMipmapLevel",get_loadedMipmapLevel,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Texture2D),typeof(UnityEngine.Texture));
	}
}
