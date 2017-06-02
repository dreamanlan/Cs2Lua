using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ComputeShader : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ComputeShader o;
			o=new UnityEngine.ComputeShader();
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
	static public int SetFloat(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(float))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetFloat(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(float))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetInt(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(int))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetInt(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(int))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetBool(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(bool))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.SetBool(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(bool))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
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
	static public int SetVector(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(UnityEngine.Vector4))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector4 a2;
				checkType(l,3,out a2);
				self.SetVector(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.Vector4))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetFloats(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(System.Single[]))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single[] a2;
				checkParams(l,3,out a2);
				self.SetFloats(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Single[]))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single[] a2;
				checkParams(l,3,out a2);
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
			if(matchType(l,argc,2,typeof(int),typeof(System.Int32[]))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32[] a2;
				checkParams(l,3,out a2);
				self.SetInts(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Int32[]))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32[] a2;
				checkParams(l,3,out a2);
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
	static public int SetTexture(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(int),typeof(UnityEngine.Texture))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.Texture a3;
				checkType(l,4,out a3);
				self.SetTexture(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(string),typeof(UnityEngine.Texture))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				UnityEngine.Texture a3;
				checkType(l,4,out a3);
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
			if(matchType(l,argc,2,typeof(int),typeof(int),typeof(int))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.SetTextureFromGlobal(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(string),typeof(string))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				System.String a3;
				checkType(l,4,out a3);
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
			if(matchType(l,argc,2,typeof(int),typeof(int),typeof(UnityEngine.ComputeBuffer))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.ComputeBuffer a3;
				checkType(l,4,out a3);
				self.SetBuffer(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(string),typeof(UnityEngine.ComputeBuffer))){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.String a2;
				checkType(l,3,out a2);
				UnityEngine.ComputeBuffer a3;
				checkType(l,4,out a3);
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
	static public int DispatchIndirect(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,3,out a2);
				self.DispatchIndirect(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.ComputeShader self=(UnityEngine.ComputeShader)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				UnityEngine.ComputeBuffer a2;
				checkType(l,3,out a2);
				System.UInt32 a3;
				checkType(l,4,out a3);
				self.DispatchIndirect(a1,a2,a3);
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
		addMember(l,GetKernelThreadGroupSizes);
		addMember(l,SetFloat);
		addMember(l,SetInt);
		addMember(l,SetBool);
		addMember(l,SetVector);
		addMember(l,SetFloats);
		addMember(l,SetInts);
		addMember(l,SetTexture);
		addMember(l,SetTextureFromGlobal);
		addMember(l,SetBuffer);
		addMember(l,Dispatch);
		addMember(l,DispatchIndirect);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ComputeShader),typeof(UnityEngine.Object));
	}
}
