using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Shader : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetDependency(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetDependency(a1);
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
	static public int GetPassCountInSubshader(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPassCountInSubshader(a1);
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
	static public int FindPassTagValue__Int32__ShaderTagId(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.ShaderTagId a2;
			checkValueType(l,3,out a2);
			var ret=self.FindPassTagValue(a1,a2);
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
	static public int FindPassTagValue__Int32__Int32__ShaderTagId(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Rendering.ShaderTagId a3;
			checkValueType(l,4,out a3);
			var ret=self.FindPassTagValue(a1,a2,a3);
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
	static public int FindSubshaderTagValue(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.ShaderTagId a2;
			checkValueType(l,3,out a2);
			var ret=self.FindSubshaderTagValue(a1,a2);
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
	static public int GetPropertyCount(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			var ret=self.GetPropertyCount();
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
	static public int FindPropertyIndex(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.FindPropertyIndex(a1);
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
	static public int GetPropertyName(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPropertyName(a1);
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
	static public int GetPropertyNameId(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPropertyNameId(a1);
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
	static public int GetPropertyType(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPropertyType(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPropertyDescription(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPropertyDescription(a1);
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
	static public int GetPropertyFlags(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPropertyFlags(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPropertyAttributes(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPropertyAttributes(a1);
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
	static public int GetPropertyDefaultFloatValue(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPropertyDefaultFloatValue(a1);
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
	static public int GetPropertyDefaultVectorValue(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPropertyDefaultVectorValue(a1);
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
	static public int GetPropertyRangeLimits(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPropertyRangeLimits(a1);
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
	static public int GetPropertyTextureDimension(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPropertyTextureDimension(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPropertyTextureDefaultName(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPropertyTextureDefaultName(a1);
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
	static public int FindTextureStack(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.String a2;
			System.Int32 a3;
			var ret=self.FindTextureStack(a1,out a2,out a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			pushValue(l,a3);
			return 4;
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
	static public int EnableKeyword__String_s(IntPtr l) {
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
	static public int EnableKeyword__R_GlobalKeyword_s(IntPtr l) {
		try {
			UnityEngine.Rendering.GlobalKeyword a1;
			checkValueType(l,1,out a1);
			UnityEngine.Shader.EnableKeyword(a1);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DisableKeyword__String_s(IntPtr l) {
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
	static public int DisableKeyword__R_GlobalKeyword_s(IntPtr l) {
		try {
			UnityEngine.Rendering.GlobalKeyword a1;
			checkValueType(l,1,out a1);
			UnityEngine.Shader.DisableKeyword(a1);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsKeywordEnabled__String_s(IntPtr l) {
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
	static public int IsKeywordEnabled__R_GlobalKeyword_s(IntPtr l) {
		try {
			UnityEngine.Rendering.GlobalKeyword a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.Shader.IsKeywordEnabled(a1);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a1);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetKeyword_s(IntPtr l) {
		try {
			UnityEngine.Rendering.GlobalKeyword a1;
			checkValueType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetKeyword(a1,a2);
			pushValue(l,true);
			pushValue(l,a1);
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
	static public int SetGlobalInt__String__Int32_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalInt(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalInt__Int32__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalInt(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalFloat__String__Single_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalFloat(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalFloat__Int32__Single_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalFloat(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalInteger__String__Int32_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalInteger(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalInteger__Int32__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalInteger(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalVector__String__Vector4_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalVector(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalVector__Int32__Vector4_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4 a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalVector(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalColor__String__Color_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Color a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalColor(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalColor__Int32__Color_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Color a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalColor(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalMatrix__String__Matrix4x4_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Shader.SetGlobalMatrix(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalMatrix__Int32__Matrix4x4_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			UnityEngine.Shader.SetGlobalMatrix(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalTexture__String__Texture_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalTexture__Int32__Texture_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalTexture__String__RenderTexture__RenderTextureSubElement_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Rendering.RenderTextureSubElement a3;
			checkEnum(l,3,out a3);
			UnityEngine.Shader.SetGlobalTexture(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalTexture__Int32__RenderTexture__RenderTextureSubElement_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.RenderTexture a2;
			checkType(l,2,out a2);
			UnityEngine.Rendering.RenderTextureSubElement a3;
			checkEnum(l,3,out a3);
			UnityEngine.Shader.SetGlobalTexture(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalBuffer__String__ComputeBuffer_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalBuffer__Int32__ComputeBuffer_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalBuffer__String__GraphicsBuffer_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalBuffer__Int32__GraphicsBuffer_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			UnityEngine.Shader.SetGlobalBuffer(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalConstantBuffer__String__ComputeBuffer__Int32__Int32_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Shader.SetGlobalConstantBuffer(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalConstantBuffer__Int32__ComputeBuffer__Int32__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.ComputeBuffer a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Shader.SetGlobalConstantBuffer(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalConstantBuffer__String__GraphicsBuffer__Int32__Int32_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Shader.SetGlobalConstantBuffer(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalConstantBuffer__Int32__GraphicsBuffer__Int32__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.GraphicsBuffer a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.Shader.SetGlobalConstantBuffer(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalFloatArray__String__A_Single_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Single[] a2;
			checkArray(l,2,out a2);
			UnityEngine.Shader.SetGlobalFloatArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalFloatArray__Int32__A_Single_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Single[] a2;
			checkArray(l,2,out a2);
			UnityEngine.Shader.SetGlobalFloatArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalVectorArray__String__A_Vector4_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4[] a2;
			checkArray(l,2,out a2);
			UnityEngine.Shader.SetGlobalVectorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalVectorArray__Int32__A_Vector4_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector4[] a2;
			checkArray(l,2,out a2);
			UnityEngine.Shader.SetGlobalVectorArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalMatrixArray__String__A_Matrix4x4_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4[] a2;
			checkArray(l,2,out a2);
			UnityEngine.Shader.SetGlobalMatrixArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetGlobalMatrixArray__Int32__A_Matrix4x4_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.Matrix4x4[] a2;
			checkArray(l,2,out a2);
			UnityEngine.Shader.SetGlobalMatrixArray(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetGlobalInt__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalInt(a1);
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
	static public int GetGlobalInt__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalInt(a1);
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
	static public int GetGlobalFloat__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalFloat(a1);
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
	static public int GetGlobalFloat__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalFloat(a1);
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
	static public int GetGlobalInteger__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalInteger(a1);
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
	static public int GetGlobalInteger__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalInteger(a1);
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
	static public int GetGlobalVector__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalVector(a1);
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
	static public int GetGlobalVector__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalVector(a1);
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
	static public int GetGlobalColor__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalColor(a1);
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
	static public int GetGlobalColor__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalColor(a1);
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
	static public int GetGlobalMatrix__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalMatrix(a1);
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
	static public int GetGlobalMatrix__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalMatrix(a1);
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
	static public int GetGlobalTexture__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalTexture(a1);
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
	static public int GetGlobalTexture__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalTexture(a1);
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
	static public int GetGlobalFloatArray__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalFloatArray(a1);
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
	static public int GetGlobalFloatArray__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalFloatArray(a1);
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
	static public int GetGlobalVectorArray__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalVectorArray(a1);
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
	static public int GetGlobalVectorArray__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalVectorArray(a1);
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
	static public int GetGlobalMatrixArray__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalMatrixArray(a1);
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
	static public int GetGlobalMatrixArray__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Shader.GetGlobalMatrixArray(a1);
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
	static public int get_maximumChunksOverride(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Shader.maximumChunksOverride);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_maximumChunksOverride(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.Shader.maximumChunksOverride=v;
			pushValue(l,true);
			return 1;
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
	static public int get_enabledGlobalKeywords(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Shader.enabledGlobalKeywords);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_globalKeywords(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Shader.globalKeywords);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_keywordSpace(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.keywordSpace);
			return 2;
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_passCount(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
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
	static public int get_subshaderCount(IntPtr l) {
		try {
			UnityEngine.Shader self=(UnityEngine.Shader)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.subshaderCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Shader");
		addMember(l,GetDependency);
		addMember(l,GetPassCountInSubshader);
		addMember(l,FindPassTagValue__Int32__ShaderTagId);
		addMember(l,FindPassTagValue__Int32__Int32__ShaderTagId);
		addMember(l,FindSubshaderTagValue);
		addMember(l,GetPropertyCount);
		addMember(l,FindPropertyIndex);
		addMember(l,GetPropertyName);
		addMember(l,GetPropertyNameId);
		addMember(l,GetPropertyType);
		addMember(l,GetPropertyDescription);
		addMember(l,GetPropertyFlags);
		addMember(l,GetPropertyAttributes);
		addMember(l,GetPropertyDefaultFloatValue);
		addMember(l,GetPropertyDefaultVectorValue);
		addMember(l,GetPropertyRangeLimits);
		addMember(l,GetPropertyTextureDimension);
		addMember(l,GetPropertyTextureDefaultName);
		addMember(l,FindTextureStack);
		addMember(l,Find_s);
		addMember(l,EnableKeyword__String_s);
		addMember(l,EnableKeyword__R_GlobalKeyword_s);
		addMember(l,DisableKeyword__String_s);
		addMember(l,DisableKeyword__R_GlobalKeyword_s);
		addMember(l,IsKeywordEnabled__String_s);
		addMember(l,IsKeywordEnabled__R_GlobalKeyword_s);
		addMember(l,SetKeyword_s);
		addMember(l,WarmupAllShaders_s);
		addMember(l,PropertyToID_s);
		addMember(l,SetGlobalInt__String__Int32_s);
		addMember(l,SetGlobalInt__Int32__Int32_s);
		addMember(l,SetGlobalFloat__String__Single_s);
		addMember(l,SetGlobalFloat__Int32__Single_s);
		addMember(l,SetGlobalInteger__String__Int32_s);
		addMember(l,SetGlobalInteger__Int32__Int32_s);
		addMember(l,SetGlobalVector__String__Vector4_s);
		addMember(l,SetGlobalVector__Int32__Vector4_s);
		addMember(l,SetGlobalColor__String__Color_s);
		addMember(l,SetGlobalColor__Int32__Color_s);
		addMember(l,SetGlobalMatrix__String__Matrix4x4_s);
		addMember(l,SetGlobalMatrix__Int32__Matrix4x4_s);
		addMember(l,SetGlobalTexture__String__Texture_s);
		addMember(l,SetGlobalTexture__Int32__Texture_s);
		addMember(l,SetGlobalTexture__String__RenderTexture__RenderTextureSubElement_s);
		addMember(l,SetGlobalTexture__Int32__RenderTexture__RenderTextureSubElement_s);
		addMember(l,SetGlobalBuffer__String__ComputeBuffer_s);
		addMember(l,SetGlobalBuffer__Int32__ComputeBuffer_s);
		addMember(l,SetGlobalBuffer__String__GraphicsBuffer_s);
		addMember(l,SetGlobalBuffer__Int32__GraphicsBuffer_s);
		addMember(l,SetGlobalConstantBuffer__String__ComputeBuffer__Int32__Int32_s);
		addMember(l,SetGlobalConstantBuffer__Int32__ComputeBuffer__Int32__Int32_s);
		addMember(l,SetGlobalConstantBuffer__String__GraphicsBuffer__Int32__Int32_s);
		addMember(l,SetGlobalConstantBuffer__Int32__GraphicsBuffer__Int32__Int32_s);
		addMember(l,SetGlobalFloatArray__String__A_Single_s);
		addMember(l,SetGlobalFloatArray__Int32__A_Single_s);
		addMember(l,SetGlobalVectorArray__String__A_Vector4_s);
		addMember(l,SetGlobalVectorArray__Int32__A_Vector4_s);
		addMember(l,SetGlobalMatrixArray__String__A_Matrix4x4_s);
		addMember(l,SetGlobalMatrixArray__Int32__A_Matrix4x4_s);
		addMember(l,GetGlobalInt__String_s);
		addMember(l,GetGlobalInt__Int32_s);
		addMember(l,GetGlobalFloat__String_s);
		addMember(l,GetGlobalFloat__Int32_s);
		addMember(l,GetGlobalInteger__String_s);
		addMember(l,GetGlobalInteger__Int32_s);
		addMember(l,GetGlobalVector__String_s);
		addMember(l,GetGlobalVector__Int32_s);
		addMember(l,GetGlobalColor__String_s);
		addMember(l,GetGlobalColor__Int32_s);
		addMember(l,GetGlobalMatrix__String_s);
		addMember(l,GetGlobalMatrix__Int32_s);
		addMember(l,GetGlobalTexture__String_s);
		addMember(l,GetGlobalTexture__Int32_s);
		addMember(l,GetGlobalFloatArray__String_s);
		addMember(l,GetGlobalFloatArray__Int32_s);
		addMember(l,GetGlobalVectorArray__String_s);
		addMember(l,GetGlobalVectorArray__Int32_s);
		addMember(l,GetGlobalMatrixArray__String_s);
		addMember(l,GetGlobalMatrixArray__Int32_s);
		addMember(l,"maximumChunksOverride",get_maximumChunksOverride,set_maximumChunksOverride,false);
		addMember(l,"maximumLOD",get_maximumLOD,set_maximumLOD,true);
		addMember(l,"globalMaximumLOD",get_globalMaximumLOD,set_globalMaximumLOD,false);
		addMember(l,"isSupported",get_isSupported,null,true);
		addMember(l,"globalRenderPipeline",get_globalRenderPipeline,set_globalRenderPipeline,false);
		addMember(l,"enabledGlobalKeywords",get_enabledGlobalKeywords,null,false);
		addMember(l,"globalKeywords",get_globalKeywords,null,false);
		addMember(l,"keywordSpace",get_keywordSpace,null,true);
		addMember(l,"renderQueue",get_renderQueue,null,true);
		addMember(l,"passCount",get_passCount,null,true);
		addMember(l,"subshaderCount",get_subshaderCount,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Shader),typeof(UnityEngine.Object));
	}
}
