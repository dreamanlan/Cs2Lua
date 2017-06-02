using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Shader : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Shader o;
			o=new UnityEngine.Shader();
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
	static public int Find_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.Find(a1);
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
	static public int EnableKeyword_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Shader.EnableKeyword(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DisableKeyword_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Shader.DisableKeyword(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsKeywordEnabled_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.IsKeywordEnabled(a1);
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
	static public int SetGlobalBuffer_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string),typeof(UnityEngine.ComputeBuffer))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalBuffer(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(UnityEngine.ComputeBuffer))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalBuffer(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int PropertyToID_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.PropertyToID(a1);
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
	static public int WarmupAllShaders_s(IntPtr l) {
		try {
			UnityEngine.Shader.WarmupAllShaders();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalFloat_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int),typeof(float))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalFloat(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(float))){
				System.String a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalFloat(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalInt_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int),typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalInt(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(int))){
				System.String a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalInt(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalVector_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int),typeof(UnityEngine.Vector4))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalVector(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(UnityEngine.Vector4))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalVector(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalColor_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int),typeof(UnityEngine.Color))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Color a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalColor(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(UnityEngine.Color))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Color a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalColor(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalMatrix_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int),typeof(UnityEngine.Matrix4x4))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,2,out a2);
				UnityEngine.Shader.SetGlobalMatrix(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(UnityEngine.Matrix4x4))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,2,out a2);
				UnityEngine.Shader.SetGlobalMatrix(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalTexture_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int),typeof(UnityEngine.Texture))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalTexture(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(UnityEngine.Texture))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Texture a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalTexture(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalFloatArray_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string),typeof(System.Single[]))){
				System.String a1;
				checkType(l,1,out a1);
				System.Single[] a2;
				checkArray(l,2,out a2);
				UnityEngine.Shader.SetGlobalFloatArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(System.Single[]))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Single[] a2;
				checkArray(l,2,out a2);
				UnityEngine.Shader.SetGlobalFloatArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(List<System.Single>))){
				System.String a1;
				checkType(l,1,out a1);
				System.Collections.Generic.List<System.Single> a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalFloatArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(List<System.Single>))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Collections.Generic.List<System.Single> a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalFloatArray(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalVectorArray_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string),typeof(UnityEngine.Vector4[]))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Vector4[] a2;
				checkArray(l,2,out a2);
				UnityEngine.Shader.SetGlobalVectorArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(UnityEngine.Vector4[]))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector4[] a2;
				checkArray(l,2,out a2);
				UnityEngine.Shader.SetGlobalVectorArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(List<UnityEngine.Vector4>))){
				System.String a1;
				checkType(l,1,out a1);
				System.Collections.Generic.List<UnityEngine.Vector4> a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalVectorArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(List<UnityEngine.Vector4>))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Collections.Generic.List<UnityEngine.Vector4> a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalVectorArray(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalMatrixArray_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string),typeof(UnityEngine.Matrix4x4[]))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4[] a2;
				checkArray(l,2,out a2);
				UnityEngine.Shader.SetGlobalMatrixArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(UnityEngine.Matrix4x4[]))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.Matrix4x4[] a2;
				checkArray(l,2,out a2);
				UnityEngine.Shader.SetGlobalMatrixArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(List<UnityEngine.Matrix4x4>))){
				System.String a1;
				checkType(l,1,out a1);
				System.Collections.Generic.List<UnityEngine.Matrix4x4> a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalMatrixArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(List<UnityEngine.Matrix4x4>))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Collections.Generic.List<UnityEngine.Matrix4x4> a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.SetGlobalMatrixArray(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int GetGlobalFloat_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalFloat(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalFloat(a1);
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
	static public int GetGlobalInt_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalInt(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalInt(a1);
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
	static public int GetGlobalVector_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalVector(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalVector(a1);
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
	static public int GetGlobalColor_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalColor(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalColor(a1);
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
	static public int GetGlobalMatrix_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalMatrix(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalMatrix(a1);
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
	static public int GetGlobalTexture_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalTexture(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalTexture(a1);
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
	static public int GetGlobalFloatArray_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalFloatArray(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalFloatArray(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(List<System.Single>))){
				System.String a1;
				checkType(l,1,out a1);
				System.Collections.Generic.List<System.Single> a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.GetGlobalFloatArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(List<System.Single>))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Collections.Generic.List<System.Single> a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.GetGlobalFloatArray(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int GetGlobalVectorArray_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalVectorArray(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalVectorArray(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(List<UnityEngine.Vector4>))){
				System.String a1;
				checkType(l,1,out a1);
				System.Collections.Generic.List<UnityEngine.Vector4> a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.GetGlobalVectorArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(List<UnityEngine.Vector4>))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Collections.Generic.List<UnityEngine.Vector4> a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.GetGlobalVectorArray(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int GetGlobalMatrixArray_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(string))){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalMatrixArray(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(int))){
				System.Int32 a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Shader.GetGlobalMatrixArray(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(List<UnityEngine.Matrix4x4>))){
				System.String a1;
				checkType(l,1,out a1);
				System.Collections.Generic.List<UnityEngine.Matrix4x4> a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.GetGlobalMatrixArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(List<UnityEngine.Matrix4x4>))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Collections.Generic.List<UnityEngine.Matrix4x4> a2;
				checkType(l,2,out a2);
				UnityEngine.Shader.GetGlobalMatrixArray(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int get_isSupported(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isSupported);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maximumLOD(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maximumLOD);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maximumLOD(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.maximumLOD=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_globalMaximumLOD(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Shader.globalMaximumLOD);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_globalMaximumLOD(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.Shader.globalMaximumLOD=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_globalRenderPipeline(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Shader.globalRenderPipeline);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_globalRenderPipeline(IntPtr l) {
		try {
			string v;
			checkType(l,2,out v);
			UnityEngine.Shader.globalRenderPipeline=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderQueue(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.renderQueue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Shader");
		addMember(l,Find_s);
		addMember(l,EnableKeyword_s);
		addMember(l,DisableKeyword_s);
		addMember(l,IsKeywordEnabled_s);
		addMember(l,SetGlobalBuffer_s);
		addMember(l,PropertyToID_s);
		addMember(l,WarmupAllShaders_s);
		addMember(l,SetGlobalFloat_s);
		addMember(l,SetGlobalInt_s);
		addMember(l,SetGlobalVector_s);
		addMember(l,SetGlobalColor_s);
		addMember(l,SetGlobalMatrix_s);
		addMember(l,SetGlobalTexture_s);
		addMember(l,SetGlobalFloatArray_s);
		addMember(l,SetGlobalVectorArray_s);
		addMember(l,SetGlobalMatrixArray_s);
		addMember(l,GetGlobalFloat_s);
		addMember(l,GetGlobalInt_s);
		addMember(l,GetGlobalVector_s);
		addMember(l,GetGlobalColor_s);
		addMember(l,GetGlobalMatrix_s);
		addMember(l,GetGlobalTexture_s);
		addMember(l,GetGlobalFloatArray_s);
		addMember(l,GetGlobalVectorArray_s);
		addMember(l,GetGlobalMatrixArray_s);
		addMember(l,"isSupported",get_isSupported,null,true);
		addMember(l,"maximumLOD",get_maximumLOD,set_maximumLOD,true);
		addMember(l,"globalMaximumLOD",get_globalMaximumLOD,set_globalMaximumLOD,false);
		addMember(l,"globalRenderPipeline",get_globalRenderPipeline,set_globalRenderPipeline,false);
		addMember(l,"renderQueue",get_renderQueue,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Shader),typeof(UnityEngine.Object));
	}
}
