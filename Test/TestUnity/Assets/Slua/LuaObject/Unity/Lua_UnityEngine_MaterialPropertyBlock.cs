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
	static public int SetInteger__String__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetInteger(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInteger__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetInteger(a1,a2);
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
	static public int SetBuffer__String__GraphicsBuffer(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.GraphicsBuffer a2;
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
	static public int SetBuffer__Int32__GraphicsBuffer(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.GraphicsBuffer a2;
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
	static public int SetTexture__String__RenderTexture__RenderTextureSubElement(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,3,out a2);
			UnityEngine.Rendering.RenderTextureSubElement a3;
			checkEnum(l,4,out a3);
			self.SetTexture(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTexture__Int32__RenderTexture__RenderTextureSubElement(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,3,out a2);
			UnityEngine.Rendering.RenderTextureSubElement a3;
			checkEnum(l,4,out a3);
			self.SetTexture(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetConstantBuffer__String__ComputeBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetConstantBuffer(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetConstantBuffer__Int32__ComputeBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetConstantBuffer(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetConstantBuffer__String__GraphicsBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetConstantBuffer(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetConstantBuffer__Int32__GraphicsBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetConstantBuffer(a1,a2,a3,a4);
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
	static public int HasProperty__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasProperty(a1);
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
	static public int HasProperty__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.HasProperty(a1);
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
	static public int HasInt__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasInt(a1);
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
	static public int HasInt__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.HasInt(a1);
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
	static public int HasFloat__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasFloat(a1);
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
	static public int HasFloat__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.HasFloat(a1);
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
	static public int HasInteger__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasInteger(a1);
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
	static public int HasInteger__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.HasInteger(a1);
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
	static public int HasTexture__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasTexture(a1);
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
	static public int HasTexture__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.HasTexture(a1);
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
	static public int HasMatrix__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasMatrix(a1);
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
	static public int HasMatrix__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.HasMatrix(a1);
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
	static public int HasVector__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasVector(a1);
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
	static public int HasVector__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.HasVector(a1);
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
	static public int HasColor__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasColor(a1);
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
	static public int HasColor__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.HasColor(a1);
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
	static public int HasBuffer__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasBuffer(a1);
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
	static public int HasBuffer__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.HasBuffer(a1);
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
	static public int HasConstantBuffer__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.HasConstantBuffer(a1);
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
	static public int HasConstantBuffer__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.HasConstantBuffer(a1);
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
	static public int GetInteger__String(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetInteger(a1);
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
	static public int GetInteger__Int32(IntPtr l) {
		try {
			UnityEngine.MaterialPropertyBlock self=(UnityEngine.MaterialPropertyBlock)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetInteger(a1);
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
		addMember(l,SetInt__String__Int32);
		addMember(l,SetInt__Int32__Int32);
		addMember(l,SetFloat__String__Single);
		addMember(l,SetFloat__Int32__Single);
		addMember(l,SetInteger__String__Int32);
		addMember(l,SetInteger__Int32__Int32);
		addMember(l,SetVector__String__Vector4);
		addMember(l,SetVector__Int32__Vector4);
		addMember(l,SetColor__String__Color);
		addMember(l,SetColor__Int32__Color);
		addMember(l,SetMatrix__String__Matrix4x4);
		addMember(l,SetMatrix__Int32__Matrix4x4);
		addMember(l,SetBuffer__String__ComputeBuffer);
		addMember(l,SetBuffer__Int32__ComputeBuffer);
		addMember(l,SetBuffer__String__GraphicsBuffer);
		addMember(l,SetBuffer__Int32__GraphicsBuffer);
		addMember(l,SetTexture__String__Texture);
		addMember(l,SetTexture__Int32__Texture);
		addMember(l,SetTexture__String__RenderTexture__RenderTextureSubElement);
		addMember(l,SetTexture__Int32__RenderTexture__RenderTextureSubElement);
		addMember(l,SetConstantBuffer__String__ComputeBuffer__Int32__Int32);
		addMember(l,SetConstantBuffer__Int32__ComputeBuffer__Int32__Int32);
		addMember(l,SetConstantBuffer__String__GraphicsBuffer__Int32__Int32);
		addMember(l,SetConstantBuffer__Int32__GraphicsBuffer__Int32__Int32);
		addMember(l,SetFloatArray__String__A_Single);
		addMember(l,SetFloatArray__Int32__A_Single);
		addMember(l,SetVectorArray__String__A_Vector4);
		addMember(l,SetVectorArray__Int32__A_Vector4);
		addMember(l,SetMatrixArray__String__A_Matrix4x4);
		addMember(l,SetMatrixArray__Int32__A_Matrix4x4);
		addMember(l,HasProperty__String);
		addMember(l,HasProperty__Int32);
		addMember(l,HasInt__String);
		addMember(l,HasInt__Int32);
		addMember(l,HasFloat__String);
		addMember(l,HasFloat__Int32);
		addMember(l,HasInteger__String);
		addMember(l,HasInteger__Int32);
		addMember(l,HasTexture__String);
		addMember(l,HasTexture__Int32);
		addMember(l,HasMatrix__String);
		addMember(l,HasMatrix__Int32);
		addMember(l,HasVector__String);
		addMember(l,HasVector__Int32);
		addMember(l,HasColor__String);
		addMember(l,HasColor__Int32);
		addMember(l,HasBuffer__String);
		addMember(l,HasBuffer__Int32);
		addMember(l,HasConstantBuffer__String);
		addMember(l,HasConstantBuffer__Int32);
		addMember(l,GetFloat__String);
		addMember(l,GetFloat__Int32);
		addMember(l,GetInt__String);
		addMember(l,GetInt__Int32);
		addMember(l,GetInteger__String);
		addMember(l,GetInteger__Int32);
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
		addMember(l,GetVectorArray__String);
		addMember(l,GetVectorArray__Int32);
		addMember(l,GetMatrixArray__String);
		addMember(l,GetMatrixArray__Int32);
		addMember(l,CopySHCoefficientArraysFrom__A_SphericalHarmonicsL2);
		addMember(l,CopySHCoefficientArraysFrom__A_SphericalHarmonicsL2__Int32__Int32__Int32);
		addMember(l,CopyProbeOcclusionArrayFrom__A_Vector4);
		addMember(l,CopyProbeOcclusionArrayFrom__A_Vector4__Int32__Int32__Int32);
		addMember(l,"isEmpty",get_isEmpty,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.MaterialPropertyBlock));
	}
}
