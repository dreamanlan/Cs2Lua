using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ComputeShader : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int FindKernel(IntPtr l) {
		try {
			UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.FindKernel(a1);
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
	static public int HasKernel(IntPtr l) {
		try {
			UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasKernel(a1);
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
	static public int SetFloat(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetFloat__Int32__Single", argc, 2,typeof(int),typeof(float))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Single a2;
				checkType(l,4,out a2);
				self.SetFloat(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetFloat__String__Single", argc, 2,typeof(string),typeof(float))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Single a2;
				checkType(l,4,out a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetInt(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetInt__Int32__Int32", argc, 2,typeof(int),typeof(int))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				self.SetInt(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetInt__String__Int32", argc, 2,typeof(string),typeof(int))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetVector(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetVector__Int32__Vector4", argc, 2,typeof(int),typeof(UnityEngine.Vector4))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,4,out a2);
				self.SetVector(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetVector__String__Vector4", argc, 2,typeof(string),typeof(UnityEngine.Vector4))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,4,out a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetMatrix(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetMatrix__Int32__Matrix4x4", argc, 2,typeof(int),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,4,out a2);
				self.SetMatrix(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetMatrix__String__Matrix4x4", argc, 2,typeof(string),typeof(UnityEngine.Matrix4x4))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,4,out a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetVectorArray(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetVectorArray__Int32__Arr_Vector4", argc, 2,typeof(int),typeof(UnityEngine.Vector4[]))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.Vector4[] a2;
				checkArray(l,4,out a2);
				self.SetVectorArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetVectorArray__String__Arr_Vector4", argc, 2,typeof(string),typeof(UnityEngine.Vector4[]))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				UnityEngine.Vector4[] a2;
				checkArray(l,4,out a2);
				self.SetVectorArray(a1,a2);
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
	static public int SetMatrixArray(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetMatrixArray__Int32__Arr_Matrix4x4", argc, 2,typeof(int),typeof(UnityEngine.Matrix4x4[]))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.Matrix4x4[] a2;
				checkArray(l,4,out a2);
				self.SetMatrixArray(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetMatrixArray__String__Arr_Matrix4x4", argc, 2,typeof(string),typeof(UnityEngine.Matrix4x4[]))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				UnityEngine.Matrix4x4[] a2;
				checkArray(l,4,out a2);
				self.SetMatrixArray(a1,a2);
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
	static public int SetTexture(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetTexture__Int32__Int32__Texture__Int32", argc, 2,typeof(int),typeof(int),typeof(UnityEngine.Texture),typeof(int))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Texture a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				self.SetTexture(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetTexture__Int32__String__Texture__Int32", argc, 2,typeof(int),typeof(string),typeof(UnityEngine.Texture),typeof(int))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				UnityEngine.Texture a3;
				checkType(l,5,out a3);
				System.Int32 a4;
				checkType(l,6,out a4);
				self.SetTexture(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetTexture__Int32__Int32__Texture", argc, 2,typeof(int),typeof(int),typeof(UnityEngine.Texture))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.Texture a3;
				checkType(l,5,out a3);
				self.SetTexture(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetTexture__Int32__String__Texture", argc, 2,typeof(int),typeof(string),typeof(UnityEngine.Texture))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				UnityEngine.Texture a3;
				checkType(l,5,out a3);
				self.SetTexture(a1,a2,a3);
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
	static public int SetTextureFromGlobal(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetTextureFromGlobal__Int32__Int32__Int32", argc, 2,typeof(int),typeof(int),typeof(int))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				System.Int32 a3;
				checkType(l,5,out a3);
				self.SetTextureFromGlobal(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetTextureFromGlobal__Int32__String__String", argc, 2,typeof(int),typeof(string),typeof(string))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				System.String a3;
				checkType(l,5,out a3);
				self.SetTextureFromGlobal(a1,a2,a3);
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
	static public int SetBuffer(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetBuffer__Int32__Int32__ComputeBuffer", argc, 2,typeof(int),typeof(int),typeof(UnityEngine.ComputeBuffer))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32 a2;
				checkType(l,4,out a2);
				UnityEngine.ComputeBuffer a3;
				checkType(l,5,out a3);
				self.SetBuffer(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetBuffer__Int32__String__ComputeBuffer", argc, 2,typeof(int),typeof(string),typeof(UnityEngine.ComputeBuffer))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.String a2;
				checkType(l,4,out a2);
				UnityEngine.ComputeBuffer a3;
				checkType(l,5,out a3);
				self.SetBuffer(a1,a2,a3);
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
	static public int GetKernelThreadGroupSizes(IntPtr l) {
		try {
			UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.UInt32 a2;
			System.UInt32 a3;
			System.UInt32 a4;
			self.GetKernelThreadGroupSizes(a1,out a2,out a3,out a4);
			pushValue(l,true);
			pushValue(l,a2);
			pushValue(l,a3);
			pushValue(l,a4);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Dispatch(IntPtr l) {
		try {
			UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.Dispatch(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFloats(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetFloats__String__Arr_Single", argc, 2,typeof(string),typeof(System.Single[]))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Single[] a2;
				checkParams(l,4,out a2);
				self.SetFloats(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetFloats__Int32__Arr_Single", argc, 2,typeof(int),typeof(System.Single[]))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Single[] a2;
				checkParams(l,4,out a2);
				self.SetFloats(a1,a2);
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
	static public int SetInts(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetInts__String__Arr_Int32", argc, 2,typeof(string),typeof(System.Int32[]))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Int32[] a2;
				checkParams(l,4,out a2);
				self.SetInts(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetInts__Int32__Arr_Int32", argc, 2,typeof(int),typeof(System.Int32[]))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Int32[] a2;
				checkParams(l,4,out a2);
				self.SetInts(a1,a2);
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
	static public int SetBool(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "SetBool__String__Boolean", argc, 2,typeof(string),typeof(bool))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.String a1;
				checkType(l,3,out a1);
				System.Boolean a2;
				checkType(l,4,out a2);
				self.SetBool(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l, "SetBool__Int32__Boolean", argc, 2,typeof(int),typeof(bool))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				System.Boolean a2;
				checkType(l,4,out a2);
				self.SetBool(a1,a2);
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
	static public int DispatchIndirect(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,4,out a2);
				System.UInt32 a3;
				checkType(l,5,out a3);
				self.DispatchIndirect(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,3,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,4,out a2);
				self.DispatchIndirect(a1,a2);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ComputeShader");
		addMember(l,FindKernel);
		addMember(l,HasKernel);
		addMember(l,SetFloat);
		addMember(l,SetInt);
		addMember(l,SetVector);
		addMember(l,SetMatrix);
		addMember(l,SetVectorArray);
		addMember(l,SetMatrixArray);
		addMember(l,SetTexture);
		addMember(l,SetTextureFromGlobal);
		addMember(l,SetBuffer);
		addMember(l,GetKernelThreadGroupSizes);
		addMember(l,Dispatch);
		addMember(l,SetFloats);
		addMember(l,SetInts);
		addMember(l,SetBool);
		addMember(l,DispatchIndirect);
		createTypeMetatable(l,null, typeof(UnityEngine.ComputeShader),typeof(UnityEngine.Object));
	}
}
