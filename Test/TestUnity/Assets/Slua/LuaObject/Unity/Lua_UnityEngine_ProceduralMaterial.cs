using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ProceduralMaterial : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralPropertyDescriptions(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			var ret=self.GetProceduralPropertyDescriptions();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HasProceduralProperty(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasProceduralProperty(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralBoolean(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetProceduralBoolean(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsProceduralPropertyVisible(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.IsProceduralPropertyVisible(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProceduralBoolean(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetProceduralBoolean(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralFloat(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetProceduralFloat(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProceduralFloat(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetProceduralFloat(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralVector(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetProceduralVector(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProceduralVector(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,3,out a2);
			self.SetProceduralVector(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralColor(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetProceduralColor(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProceduralColor(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			self.SetProceduralColor(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralEnum(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetProceduralEnum(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProceduralEnum(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetProceduralEnum(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProceduralTexture(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetProceduralTexture(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetProceduralTexture(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Texture2D a2;
			checkType(l,3,out a2);
			self.SetProceduralTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsProceduralPropertyCached(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.IsProceduralPropertyCached(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CacheProceduralProperty(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.CacheProceduralProperty(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearCache(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			self.ClearCache();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RebuildTextures(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			self.RebuildTextures();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RebuildTexturesImmediately(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			self.RebuildTexturesImmediately();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGeneratedTextures(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			var ret=self.GetGeneratedTextures();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGeneratedTexture(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetGeneratedTexture(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FreezeAndReleaseSourceData(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			self.FreezeAndReleaseSourceData();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetColor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(UnityEngine.Color))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Color a2;
				checkType(l,3,out a2);
				self.SetColor(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.Color))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Color a2;
				checkType(l,3,out a2);
				self.SetColor(a1,a2);
				pushValue(l,true);
				return 1;
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
	static public int GetColor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.GetColor(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetColor(a1);
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
	static public int SetVector(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(UnityEngine.Vector4))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,3,out a2);
				self.SetVector(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.Vector4))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,3,out a2);
				self.SetVector(a1,a2);
				pushValue(l,true);
				return 1;
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
	static public int GetVector(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.GetVector(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetVector(a1);
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
	static public int SetTexture(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(UnityEngine.Texture))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Texture a2;
				checkType(l,3,out a2);
				self.SetTexture(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.Texture))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Texture a2;
				checkType(l,3,out a2);
				self.SetTexture(a1,a2);
				pushValue(l,true);
				return 1;
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
	static public int GetTexture(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.GetTexture(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetTexture(a1);
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
	static public int SetTextureOffset(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,3,out a2);
			self.SetTextureOffset(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTextureOffset(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetTextureOffset(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTextureScale(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector2 a2;
			checkType(l,3,out a2);
			self.SetTextureScale(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTextureScale(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetTextureScale(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetMatrix(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,3,out a2);
				self.SetMatrix(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,3,out a2);
				self.SetMatrix(a1,a2);
				pushValue(l,true);
				return 1;
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
	static public int GetMatrix(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.GetMatrix(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetMatrix(a1);
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
	static public int SetFloat(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(float))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetFloat(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(float))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetFloat(a1,a2);
				pushValue(l,true);
				return 1;
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
	static public int GetFloat(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.GetFloat(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetFloat(a1);
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
	static public int SetInt(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(int))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetInt(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(int))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetInt(a1,a2);
				pushValue(l,true);
				return 1;
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
	static public int GetInt(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.GetInt(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetInt(a1);
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
	static public int SetBuffer(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,3,out a2);
			self.SetBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int HasProperty(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.HasProperty(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.HasProperty(a1);
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
	static public int GetTag(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.GetTag(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
				var ret=self.GetTag(a1,a2,a3);
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
	static public int SetOverrideTag(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.SetOverrideTag(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Lerp(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			UnityEngine.Material a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.Lerp(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPass(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.SetPass(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CopyPropertiesFromMaterial(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			self.CopyPropertiesFromMaterial(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EnableKeyword(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.EnableKeyword(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DisableKeyword(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.DisableKeyword(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsKeywordEnabled(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.IsKeywordEnabled(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInstanceID(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			var ret=self.GetInstanceID();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StopRebuilds_s(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial.StopRebuilds();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cacheSize(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.cacheSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cacheSize(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			UnityEngine.ProceduralCacheSize v;
			checkEnum(l,2,out v);
			self.cacheSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animationUpdateRate(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.animationUpdateRate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_animationUpdateRate(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.animationUpdateRate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isProcessing(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isProcessing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isCachedDataAvailable(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isCachedDataAvailable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isLoadTimeGenerated(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isLoadTimeGenerated);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isLoadTimeGenerated(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.isLoadTimeGenerated=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_loadingBehavior(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.loadingBehavior);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isSupported(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.ProceduralMaterial.isSupported);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_substanceProcessorUsage(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.ProceduralMaterial.substanceProcessorUsage);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_substanceProcessorUsage(IntPtr l) {
		try {
			UnityEngine.ProceduralProcessorUsage v;
			checkEnum(l,2,out v);
			UnityEngine.ProceduralMaterial.substanceProcessorUsage=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_preset(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.preset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_preset(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.preset=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isReadable(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isReadable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isReadable(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.isReadable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isFrozen(IntPtr l) {
		try {
			UnityEngine.ProceduralMaterial self=(UnityEngine.ProceduralMaterial)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isFrozen);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ProceduralMaterial");
		addMember(l,GetProceduralPropertyDescriptions);
		addMember(l,HasProceduralProperty);
		addMember(l,GetProceduralBoolean);
		addMember(l,IsProceduralPropertyVisible);
		addMember(l,SetProceduralBoolean);
		addMember(l,GetProceduralFloat);
		addMember(l,SetProceduralFloat);
		addMember(l,GetProceduralVector);
		addMember(l,SetProceduralVector);
		addMember(l,GetProceduralColor);
		addMember(l,SetProceduralColor);
		addMember(l,GetProceduralEnum);
		addMember(l,SetProceduralEnum);
		addMember(l,GetProceduralTexture);
		addMember(l,SetProceduralTexture);
		addMember(l,IsProceduralPropertyCached);
		addMember(l,CacheProceduralProperty);
		addMember(l,ClearCache);
		addMember(l,RebuildTextures);
		addMember(l,RebuildTexturesImmediately);
		addMember(l,GetGeneratedTextures);
		addMember(l,GetGeneratedTexture);
		addMember(l,FreezeAndReleaseSourceData);
		addMember(l,SetColor);
		addMember(l,GetColor);
		addMember(l,SetVector);
		addMember(l,GetVector);
		addMember(l,SetTexture);
		addMember(l,GetTexture);
		addMember(l,SetTextureOffset);
		addMember(l,GetTextureOffset);
		addMember(l,SetTextureScale);
		addMember(l,GetTextureScale);
		addMember(l,SetMatrix);
		addMember(l,GetMatrix);
		addMember(l,SetFloat);
		addMember(l,GetFloat);
		addMember(l,SetInt);
		addMember(l,GetInt);
		addMember(l,SetBuffer);
		addMember(l,HasProperty);
		addMember(l,GetTag);
		addMember(l,SetOverrideTag);
		addMember(l,Lerp);
		addMember(l,SetPass);
		addMember(l,CopyPropertiesFromMaterial);
		addMember(l,EnableKeyword);
		addMember(l,DisableKeyword);
		addMember(l,IsKeywordEnabled);
		addMember(l,GetInstanceID);
		addMember(l,StopRebuilds_s);
		addMember(l,"cacheSize",get_cacheSize,set_cacheSize,true);
		addMember(l,"animationUpdateRate",get_animationUpdateRate,set_animationUpdateRate,true);
		addMember(l,"isProcessing",get_isProcessing,null,true);
		addMember(l,"isCachedDataAvailable",get_isCachedDataAvailable,null,true);
		addMember(l,"isLoadTimeGenerated",get_isLoadTimeGenerated,set_isLoadTimeGenerated,true);
		addMember(l,"loadingBehavior",get_loadingBehavior,null,true);
		addMember(l,"isSupported",get_isSupported,null,false);
		addMember(l,"substanceProcessorUsage",get_substanceProcessorUsage,set_substanceProcessorUsage,false);
		addMember(l,"preset",get_preset,set_preset,true);
		addMember(l,"isReadable",get_isReadable,set_isReadable,true);
		addMember(l,"isFrozen",get_isFrozen,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.ProceduralMaterial),typeof(UnityEngine.Material));
	}
}
