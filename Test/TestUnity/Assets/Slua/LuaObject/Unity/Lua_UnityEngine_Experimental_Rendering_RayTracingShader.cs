using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RayTracingShader : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFloat__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetFloat__String__Single(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetInt__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetInt__String__Int32(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetVector__Int32__Vector4(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetVector__String__Vector4(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetMatrix__Int32__Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetMatrix__String__Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetVectorArray__Int32__A_Vector4(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetVectorArray__String__A_Vector4(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetMatrixArray__Int32__A_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetMatrixArray__String__A_Matrix4x4(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetTexture__Int32__Texture(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetTexture__String__Texture(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetBuffer__Int32__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetBuffer__Int32__GraphicsBuffer(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetBuffer__String__ComputeBuffer(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetBuffer__String__GraphicsBuffer(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetAccelerationStructure__Int32__RayTracingAccelerationStructure(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure a2;
			checkType(l,3,out a2);
			self.SetAccelerationStructure(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetAccelerationStructure__String__RayTracingAccelerationStructure(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure a2;
			checkType(l,3,out a2);
			self.SetAccelerationStructure(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetShaderPass(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.SetShaderPass(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTextureFromGlobal__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetTextureFromGlobal(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTextureFromGlobal__String__String(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.SetTextureFromGlobal(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Dispatch(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.Camera a5;
			checkType(l,6,out a5);
			self.Dispatch(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFloats__String__A_Single(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single[] a2;
			checkParams(l,3,out a2);
			self.SetFloats(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFloats__Int32__A_Single(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single[] a2;
			checkParams(l,3,out a2);
			self.SetFloats(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInts__String__A_Int32(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32[] a2;
			checkParams(l,3,out a2);
			self.SetInts(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInts__Int32__A_Int32(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32[] a2;
			checkParams(l,3,out a2);
			self.SetInts(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBool__String__Boolean(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetBool(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBool__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetBool(a1,a2);
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
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetConstantBuffer__String__ComputeBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetConstantBuffer__Int32__GraphicsBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int SetConstantBuffer__String__GraphicsBuffer__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
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
	static public int get_maxRecursionDepth(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingShader self=(UnityEngine.Experimental.Rendering.RayTracingShader)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxRecursionDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RayTracingShader");
		addMember(l,SetFloat__Int32__Single);
		addMember(l,SetFloat__String__Single);
		addMember(l,SetInt__Int32__Int32);
		addMember(l,SetInt__String__Int32);
		addMember(l,SetVector__Int32__Vector4);
		addMember(l,SetVector__String__Vector4);
		addMember(l,SetMatrix__Int32__Matrix4x4);
		addMember(l,SetMatrix__String__Matrix4x4);
		addMember(l,SetVectorArray__Int32__A_Vector4);
		addMember(l,SetVectorArray__String__A_Vector4);
		addMember(l,SetMatrixArray__Int32__A_Matrix4x4);
		addMember(l,SetMatrixArray__String__A_Matrix4x4);
		addMember(l,SetTexture__Int32__Texture);
		addMember(l,SetTexture__String__Texture);
		addMember(l,SetBuffer__Int32__ComputeBuffer);
		addMember(l,SetBuffer__Int32__GraphicsBuffer);
		addMember(l,SetBuffer__String__ComputeBuffer);
		addMember(l,SetBuffer__String__GraphicsBuffer);
		addMember(l,SetAccelerationStructure__Int32__RayTracingAccelerationStructure);
		addMember(l,SetAccelerationStructure__String__RayTracingAccelerationStructure);
		addMember(l,SetShaderPass);
		addMember(l,SetTextureFromGlobal__Int32__Int32);
		addMember(l,SetTextureFromGlobal__String__String);
		addMember(l,Dispatch);
		addMember(l,SetFloats__String__A_Single);
		addMember(l,SetFloats__Int32__A_Single);
		addMember(l,SetInts__String__A_Int32);
		addMember(l,SetInts__Int32__A_Int32);
		addMember(l,SetBool__String__Boolean);
		addMember(l,SetBool__Int32__Boolean);
		addMember(l,SetConstantBuffer__Int32__ComputeBuffer__Int32__Int32);
		addMember(l,SetConstantBuffer__String__ComputeBuffer__Int32__Int32);
		addMember(l,SetConstantBuffer__Int32__GraphicsBuffer__Int32__Int32);
		addMember(l,SetConstantBuffer__String__GraphicsBuffer__Int32__Int32);
		addMember(l,"maxRecursionDepth",get_maxRecursionDepth,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.RayTracingShader),typeof(UnityEngine.Object));
	}
}
