using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Material : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Shader_s(IntPtr l) {
		try {
			UnityEngine.Material o;
			UnityEngine.Shader a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Material(a1);
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
	static public int ctor__Material_s(IntPtr l) {
		try {
			UnityEngine.Material o;
			UnityEngine.Material a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Material(a1);
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
	static public int HasProperty__Int32(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int HasProperty__String(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int EnableKeyword(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int DisableKeyword(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int IsKeywordEnabled(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetShaderPassEnabled(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetShaderPassEnabled(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetShaderPassEnabled(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetShaderPassEnabled(a1);
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
	static public int GetPassName(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPassName(a1);
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
	static public int FindPass(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.FindPass(a1);
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
	static public int SetOverrideTag(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int GetTag__String__Boolean(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.GetTag(a1,a2);
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
	static public int GetTag__String__Boolean__String(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Lerp(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetPass(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int CopyPropertiesFromMaterial(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int GetTexturePropertyNames(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			var ret=self.GetTexturePropertyNames();
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
	static public int GetTexturePropertyNames__List_1_String(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.Collections.Generic.List<System.String> a1;
			checkType(l,2,out a1);
			self.GetTexturePropertyNames(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTexturePropertyNameIDs(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			var ret=self.GetTexturePropertyNameIDs();
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
	static public int GetTexturePropertyNameIDs__List_1_Int32(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.Collections.Generic.List<System.Int32> a1;
			checkType(l,2,out a1);
			self.GetTexturePropertyNameIDs(a1);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int SetColor__String__Color(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int SetVector__String__Vector4(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int SetMatrix__String__Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int SetTexture__String__Texture(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int SetBuffer__String__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int SetFloatArray__String__List_1_Single(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int SetColorArray__String__List_1_Color(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Color> a2;
			checkType(l,3,out a2);
			self.SetColorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetColorArray__Int32__List_1_Color(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Color> a2;
			checkType(l,3,out a2);
			self.SetColorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetColorArray__String__A_Color(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Color[] a2;
			checkArray(l,3,out a2);
			self.SetColorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetColorArray__Int32__A_Color(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Color[] a2;
			checkArray(l,3,out a2);
			self.SetColorArray(a1,a2);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int GetColor__String(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int GetVector__String(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int GetMatrix__String(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int GetColorArray__String(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetColorArray(a1);
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
	static public int GetColorArray__Int32(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetColorArray(a1);
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
	static public int GetColorArray__String__List_1_Color(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Color> a2;
			checkType(l,3,out a2);
			self.GetColorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetColorArray__Int32__List_1_Color(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Color> a2;
			checkType(l,3,out a2);
			self.GetColorArray(a1,a2);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	static public int SetTextureOffset__String__Vector2(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetTextureOffset__Int32__Vector2(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.Int32 a1;
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
	[UnityEngine.Scripting.Preserve]
	static public int SetTextureScale__String__Vector2(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetTextureScale__Int32__Vector2(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.Int32 a1;
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
	[UnityEngine.Scripting.Preserve]
	static public int GetTextureOffset__String(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int GetTextureOffset__Int32(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.Int32 a1;
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
	[UnityEngine.Scripting.Preserve]
	static public int GetTextureScale__String(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static public int GetTextureScale__Int32(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.Int32 a1;
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
	[UnityEngine.Scripting.Preserve]
	static public int get_shader(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shader);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shader(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			UnityEngine.Shader v;
			checkType(l,2,out v);
			self.shader=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_color(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.color);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_color(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.color=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mainTexture(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mainTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mainTexture(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			UnityEngine.Texture v;
			checkType(l,2,out v);
			self.mainTexture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mainTextureOffset(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mainTextureOffset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mainTextureOffset(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.mainTextureOffset=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mainTextureScale(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mainTextureScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mainTextureScale(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.mainTextureScale=v;
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
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.renderQueue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderQueue(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.renderQueue=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_globalIlluminationFlags(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.globalIlluminationFlags);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_globalIlluminationFlags(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			UnityEngine.MaterialGlobalIlluminationFlags v;
			checkEnum(l,2,out v);
			self.globalIlluminationFlags=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_doubleSidedGI(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.doubleSidedGI);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_doubleSidedGI(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.doubleSidedGI=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableInstancing(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enableInstancing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableInstancing(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enableInstancing=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_passCount(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.passCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_shaderKeywords(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shaderKeywords);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shaderKeywords(IntPtr l) {
		try {
			UnityEngine.Material self=(UnityEngine.Material)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.shaderKeywords=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Material");
		addMember(l,ctor__Shader_s);
		addMember(l,ctor__Material_s);
		addMember(l,HasProperty__Int32);
		addMember(l,HasProperty__String);
		addMember(l,EnableKeyword);
		addMember(l,DisableKeyword);
		addMember(l,IsKeywordEnabled);
		addMember(l,SetShaderPassEnabled);
		addMember(l,GetShaderPassEnabled);
		addMember(l,GetPassName);
		addMember(l,FindPass);
		addMember(l,SetOverrideTag);
		addMember(l,GetTag__String__Boolean);
		addMember(l,GetTag__String__Boolean__String);
		addMember(l,Lerp);
		addMember(l,SetPass);
		addMember(l,CopyPropertiesFromMaterial);
		addMember(l,GetTexturePropertyNames);
		addMember(l,GetTexturePropertyNames__List_1_String);
		addMember(l,GetTexturePropertyNameIDs);
		addMember(l,GetTexturePropertyNameIDs__List_1_Int32);
		addMember(l,SetFloat__String__Single);
		addMember(l,SetFloat__Int32__Single);
		addMember(l,SetInt__String__Int32);
		addMember(l,SetInt__Int32__Int32);
		addMember(l,SetColor__String__Color);
		addMember(l,SetColor__Int32__Color);
		addMember(l,SetVector__String__Vector4);
		addMember(l,SetVector__Int32__Vector4);
		addMember(l,SetMatrix__String__Matrix4x4);
		addMember(l,SetMatrix__Int32__Matrix4x4);
		addMember(l,SetTexture__String__Texture);
		addMember(l,SetTexture__Int32__Texture);
		addMember(l,SetBuffer__String__ComputeBuffer);
		addMember(l,SetBuffer__Int32__ComputeBuffer);
		addMember(l,SetFloatArray__String__List_1_Single);
		addMember(l,SetFloatArray__Int32__List_1_Single);
		addMember(l,SetFloatArray__String__A_Single);
		addMember(l,SetFloatArray__Int32__A_Single);
		addMember(l,SetColorArray__String__List_1_Color);
		addMember(l,SetColorArray__Int32__List_1_Color);
		addMember(l,SetColorArray__String__A_Color);
		addMember(l,SetColorArray__Int32__A_Color);
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
		addMember(l,GetColor__String);
		addMember(l,GetColor__Int32);
		addMember(l,GetVector__String);
		addMember(l,GetVector__Int32);
		addMember(l,GetMatrix__String);
		addMember(l,GetMatrix__Int32);
		addMember(l,GetTexture__String);
		addMember(l,GetTexture__Int32);
		addMember(l,GetFloatArray__String);
		addMember(l,GetFloatArray__Int32);
		addMember(l,GetFloatArray__String__List_1_Single);
		addMember(l,GetFloatArray__Int32__List_1_Single);
		addMember(l,GetColorArray__String);
		addMember(l,GetColorArray__Int32);
		addMember(l,GetColorArray__String__List_1_Color);
		addMember(l,GetColorArray__Int32__List_1_Color);
		addMember(l,GetVectorArray__String);
		addMember(l,GetVectorArray__Int32);
		addMember(l,GetVectorArray__String__List_1_Vector4);
		addMember(l,GetVectorArray__Int32__List_1_Vector4);
		addMember(l,GetMatrixArray__String);
		addMember(l,GetMatrixArray__Int32);
		addMember(l,GetMatrixArray__String__List_1_Matrix4x4);
		addMember(l,GetMatrixArray__Int32__List_1_Matrix4x4);
		addMember(l,SetTextureOffset__String__Vector2);
		addMember(l,SetTextureOffset__Int32__Vector2);
		addMember(l,SetTextureScale__String__Vector2);
		addMember(l,SetTextureScale__Int32__Vector2);
		addMember(l,GetTextureOffset__String);
		addMember(l,GetTextureOffset__Int32);
		addMember(l,GetTextureScale__String);
		addMember(l,GetTextureScale__Int32);
		addMember(l,"shader",get_shader,set_shader,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"mainTexture",get_mainTexture,set_mainTexture,true);
		addMember(l,"mainTextureOffset",get_mainTextureOffset,set_mainTextureOffset,true);
		addMember(l,"mainTextureScale",get_mainTextureScale,set_mainTextureScale,true);
		addMember(l,"renderQueue",get_renderQueue,set_renderQueue,true);
		addMember(l,"globalIlluminationFlags",get_globalIlluminationFlags,set_globalIlluminationFlags,true);
		addMember(l,"doubleSidedGI",get_doubleSidedGI,set_doubleSidedGI,true);
		addMember(l,"enableInstancing",get_enableInstancing,set_enableInstancing,true);
		addMember(l,"passCount",get_passCount,null,true);
		addMember(l,"shaderKeywords",get_shaderKeywords,set_shaderKeywords,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Material),typeof(UnityEngine.Object));
	}
}
