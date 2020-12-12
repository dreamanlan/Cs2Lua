using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_MaterialPropertyBlock : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock o;
			o=new UnityEngine.MaterialPropertyBlock();
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
	static public int Clear(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFloat__String__Single(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetFloat(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFloat__Int32__Single(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetFloat(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInt__String__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetInt(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInt__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetInt(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetVector__String__Vector4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,3,out a2);
			self.SetVector(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetVector__Int32__Vector4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,3,out a2);
			self.SetVector(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetColor__String__Color(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			self.SetColor(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetColor__Int32__Color(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			self.SetColor(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMatrix__String__Matrix4x4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			self.SetMatrix(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMatrix__Int32__Matrix4x4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,3,out a2);
			self.SetMatrix(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBuffer__String__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetBuffer__Int32__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
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
	[UnityEngine.Scripting.Preserve]
	static public int SetTexture__String__Texture(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Texture a2;
			checkType(l,3,out a2);
			self.SetTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTexture__Int32__Texture(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Texture a2;
			checkType(l,3,out a2);
			self.SetTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFloatArray__String__List_1_Single(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<System.Single> a2;
			checkType(l,3,out a2);
			self.SetFloatArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFloatArray__Int32__List_1_Single(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<System.Single> a2;
			checkType(l,3,out a2);
			self.SetFloatArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFloatArray__String__A_Single(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single[] a2;
			checkArray(l,3,out a2);
			self.SetFloatArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFloatArray__Int32__A_Single(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single[] a2;
			checkArray(l,3,out a2);
			self.SetFloatArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetVectorArray__String__List_1_Vector4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Vector4> a2;
			checkType(l,3,out a2);
			self.SetVectorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetVectorArray__Int32__List_1_Vector4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Vector4> a2;
			checkType(l,3,out a2);
			self.SetVectorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetVectorArray__String__A_Vector4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4[] a2;
			checkArray(l,3,out a2);
			self.SetVectorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetVectorArray__Int32__A_Vector4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector4[] a2;
			checkArray(l,3,out a2);
			self.SetVectorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMatrixArray__String__List_1_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Matrix4x4> a2;
			checkType(l,3,out a2);
			self.SetMatrixArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMatrixArray__Int32__List_1_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Matrix4x4> a2;
			checkType(l,3,out a2);
			self.SetMatrixArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMatrixArray__String__A_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4[] a2;
			checkArray(l,3,out a2);
			self.SetMatrixArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMatrixArray__Int32__A_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Matrix4x4[] a2;
			checkArray(l,3,out a2);
			self.SetMatrixArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetFloat__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetFloat(a1);
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
	static public int GetFloat__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetFloat(a1);
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
	static public int GetInt__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetInt(a1);
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
	static public int GetInt__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetInt(a1);
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
	static public int GetVector__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetVector(a1);
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
	static public int GetVector__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetVector(a1);
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
	static public int GetColor__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetColor(a1);
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
	static public int GetColor__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetColor(a1);
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
	static public int GetMatrix__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetMatrix(a1);
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
	static public int GetMatrix__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetMatrix(a1);
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
	static public int GetTexture__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetTexture(a1);
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
	static public int GetTexture__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetTexture(a1);
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
	static public int GetFloatArray__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetFloatArray(a1);
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
	static public int GetFloatArray__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetFloatArray(a1);
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
	static public int GetFloatArray__String__List_1_Single(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<System.Single> a2;
			checkType(l,3,out a2);
			self.GetFloatArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetFloatArray__Int32__List_1_Single(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<System.Single> a2;
			checkType(l,3,out a2);
			self.GetFloatArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetVectorArray__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetVectorArray(a1);
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
	static public int GetVectorArray__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetVectorArray(a1);
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
	static public int GetVectorArray__String__List_1_Vector4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Vector4> a2;
			checkType(l,3,out a2);
			self.GetVectorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetVectorArray__Int32__List_1_Vector4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Vector4> a2;
			checkType(l,3,out a2);
			self.GetVectorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetMatrixArray__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetMatrixArray(a1);
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
	static public int GetMatrixArray__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetMatrixArray(a1);
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
	static public int GetMatrixArray__String__List_1_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Matrix4x4> a2;
			checkType(l,3,out a2);
			self.GetMatrixArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetMatrixArray__Int32__List_1_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Matrix4x4> a2;
			checkType(l,3,out a2);
			self.GetMatrixArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopySHCoefficientArraysFrom__List_1_SphericalHarmonicsL2(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> a1;
			checkType(l,2,out a1);
			self.CopySHCoefficientArraysFrom(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopySHCoefficientArraysFrom__A_SphericalHarmonicsL2(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			UnityEngine.Rendering.SphericalHarmonicsL2[] a1;
			checkArray(l,2,out a1);
			self.CopySHCoefficientArraysFrom(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopySHCoefficientArraysFrom__List_1_SphericalHarmonicsL2__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.CopySHCoefficientArraysFrom(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopySHCoefficientArraysFrom__A_SphericalHarmonicsL2__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			UnityEngine.Rendering.SphericalHarmonicsL2[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.CopySHCoefficientArraysFrom(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyProbeOcclusionArrayFrom__List_1_Vector4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Vector4> a1;
			checkType(l,2,out a1);
			self.CopyProbeOcclusionArrayFrom(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyProbeOcclusionArrayFrom__A_Vector4(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			UnityEngine.Vector4[] a1;
			checkArray(l,2,out a1);
			self.CopyProbeOcclusionArrayFrom(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyProbeOcclusionArrayFrom__List_1_Vector4__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Vector4> a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.CopyProbeOcclusionArrayFrom(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CopyProbeOcclusionArrayFrom__A_Vector4__Int32__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			UnityEngine.Vector4[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.CopyProbeOcclusionArrayFrom(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isEmpty(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isEmpty);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MaterialPropertyBlock");
		addMember(l,ctor_s);
		addMember(l,Clear);
		addMember(l,SetFloat__String__Single);
		addMember(l,SetFloat__Int32__Single);
		addMember(l,SetInt__String__Int32);
		addMember(l,SetInt__Int32__Int32);
		addMember(l,SetVector__String__Vector4);
		addMember(l,SetVector__Int32__Vector4);
		addMember(l,SetColor__String__Color);
		addMember(l,SetColor__Int32__Color);
		addMember(l,SetMatrix__String__Matrix4x4);
		addMember(l,SetMatrix__Int32__Matrix4x4);
		addMember(l,SetBuffer__String__ComputeBuffer);
		addMember(l,SetBuffer__Int32__ComputeBuffer);
		addMember(l,SetTexture__String__Texture);
		addMember(l,SetTexture__Int32__Texture);
		addMember(l,SetFloatArray__String__List_1_Single);
		addMember(l,SetFloatArray__Int32__List_1_Single);
		addMember(l,SetFloatArray__String__A_Single);
		addMember(l,SetFloatArray__Int32__A_Single);
		addMember(l,SetVectorArray__String__List_1_Vector4);
		addMember(l,SetVectorArray__Int32__List_1_Vector4);
		addMember(l,SetVectorArray__String__A_Vector4);
		addMember(l,SetVectorArray__Int32__A_Vector4);
		addMember(l,SetMatrixArray__String__List_1_Matrix4x4);
		addMember(l,SetMatrixArray__Int32__List_1_Matrix4x4);
		addMember(l,SetMatrixArray__String__A_Matrix4x4);
		addMember(l,SetMatrixArray__Int32__A_Matrix4x4);
		addMember(l,GetFloat__String);
		addMember(l,GetFloat__Int32);
		addMember(l,GetInt__String);
		addMember(l,GetInt__Int32);
		addMember(l,GetVector__String);
		addMember(l,GetVector__Int32);
		addMember(l,GetColor__String);
		addMember(l,GetColor__Int32);
		addMember(l,GetMatrix__String);
		addMember(l,GetMatrix__Int32);
		addMember(l,GetTexture__String);
		addMember(l,GetTexture__Int32);
		addMember(l,GetFloatArray__String);
		addMember(l,GetFloatArray__Int32);
		addMember(l,GetFloatArray__String__List_1_Single);
		addMember(l,GetFloatArray__Int32__List_1_Single);
		addMember(l,GetVectorArray__String);
		addMember(l,GetVectorArray__Int32);
		addMember(l,GetVectorArray__String__List_1_Vector4);
		addMember(l,GetVectorArray__Int32__List_1_Vector4);
		addMember(l,GetMatrixArray__String);
		addMember(l,GetMatrixArray__Int32);
		addMember(l,GetMatrixArray__String__List_1_Matrix4x4);
		addMember(l,GetMatrixArray__Int32__List_1_Matrix4x4);
		addMember(l,CopySHCoefficientArraysFrom__List_1_SphericalHarmonicsL2);
		addMember(l,CopySHCoefficientArraysFrom__A_SphericalHarmonicsL2);
		addMember(l,CopySHCoefficientArraysFrom__List_1_SphericalHarmonicsL2__Int32__Int32__Int32);
		addMember(l,CopySHCoefficientArraysFrom__A_SphericalHarmonicsL2__Int32__Int32__Int32);
		addMember(l,CopyProbeOcclusionArrayFrom__List_1_Vector4);
		addMember(l,CopyProbeOcclusionArrayFrom__A_Vector4);
		addMember(l,CopyProbeOcclusionArrayFrom__List_1_Vector4__Int32__Int32__Int32);
		addMember(l,CopyProbeOcclusionArrayFrom__A_Vector4__Int32__Int32__Int32);
		addMember(l,"isEmpty",get_isEmpty,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.MaterialPropertyBlock));
	}
}
