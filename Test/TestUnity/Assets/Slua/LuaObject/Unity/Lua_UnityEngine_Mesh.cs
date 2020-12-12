using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Mesh : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Mesh o;
			o=new UnityEngine.Mesh();
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
	static public int GetNativeVertexBufferPtr(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetNativeVertexBufferPtr(a1);
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
	static public int GetNativeIndexBufferPtr(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			var ret=self.GetNativeIndexBufferPtr();
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
	static public int ClearBlendShapes(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.ClearBlendShapes();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBlendShapeName(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetBlendShapeName(a1);
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
	static public int GetBlendShapeIndex(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetBlendShapeIndex(a1);
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
	static public int GetBlendShapeFrameCount(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetBlendShapeFrameCount(a1);
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
	static public int GetBlendShapeFrameWeight(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.GetBlendShapeFrameWeight(a1,a2);
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
	static public int GetBlendShapeFrameVertices(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Vector3[] a3;
			checkArray(l,4,out a3);
			UnityEngine.Vector3[] a4;
			checkArray(l,5,out a4);
			UnityEngine.Vector3[] a5;
			checkArray(l,6,out a5);
			self.GetBlendShapeFrameVertices(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddBlendShapeFrame(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			UnityEngine.Vector3[] a3;
			checkArray(l,4,out a3);
			UnityEngine.Vector3[] a4;
			checkArray(l,5,out a4);
			UnityEngine.Vector3[] a5;
			checkArray(l,6,out a5);
			self.AddBlendShapeFrame(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUVDistributionMetric(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetUVDistributionMetric(a1);
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
	static public int GetVertices(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Vector3> a1;
			checkType(l,2,out a1);
			self.GetVertices(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetVertices(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Vector3> a1;
			checkType(l,2,out a1);
			self.SetVertices(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetNormals(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Vector3> a1;
			checkType(l,2,out a1);
			self.GetNormals(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetNormals(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Vector3> a1;
			checkType(l,2,out a1);
			self.SetNormals(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTangents(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Vector4> a1;
			checkType(l,2,out a1);
			self.GetTangents(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTangents(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Vector4> a1;
			checkType(l,2,out a1);
			self.SetTangents(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetColors__List_1_Color(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Color> a1;
			checkType(l,2,out a1);
			self.GetColors(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetColors__List_1_Color32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Color32> a1;
			checkType(l,2,out a1);
			self.GetColors(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetColors__List_1_Color(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Color> a1;
			checkType(l,2,out a1);
			self.SetColors(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetColors__List_1_Color32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Color32> a1;
			checkType(l,2,out a1);
			self.SetColors(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetUVs__Int32__List_1_Vector2(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Vector2> a2;
			checkType(l,3,out a2);
			self.SetUVs(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetUVs__Int32__List_1_Vector3(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Vector3> a2;
			checkType(l,3,out a2);
			self.SetUVs(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetUVs__Int32__List_1_Vector4(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Vector4> a2;
			checkType(l,3,out a2);
			self.SetUVs(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUVs__Int32__List_1_Vector2(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Vector2> a2;
			checkType(l,3,out a2);
			self.GetUVs(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUVs__Int32__List_1_Vector3(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Vector3> a2;
			checkType(l,3,out a2);
			self.GetUVs(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUVs__Int32__List_1_Vector4(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Vector4> a2;
			checkType(l,3,out a2);
			self.GetUVs(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTriangles__Int32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetTriangles(a1);
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
	static public int GetTriangles__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.GetTriangles(a1,a2);
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
	static public int GetTriangles__List_1_Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<System.Int32> a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.GetTriangles(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTriangles__List_1_Int32__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<System.Int32> a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.GetTriangles(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetIndices__Int32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetIndices(a1);
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
	static public int GetIndices__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.GetIndices(a1,a2);
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
	static public int GetIndices__List_1_Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<System.Int32> a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.GetIndices(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetIndices__List_1_Int32__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<System.Int32> a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.GetIndices(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetIndexStart(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetIndexStart(a1);
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
	static public int GetIndexCount(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetIndexCount(a1);
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
	static public int GetBaseVertex(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetBaseVertex(a1);
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
	static public int SetTriangles__A_Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetTriangles(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTriangles__List_1_Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<System.Int32> a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetTriangles(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTriangles__A_Int32__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.SetTriangles(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTriangles__List_1_Int32__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<System.Int32> a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.SetTriangles(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTriangles__A_Int32__Int32__Boolean__Int32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32[] a1;
			checkArray(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetTriangles(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTriangles__List_1_Int32__Int32__Boolean__Int32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<System.Int32> a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			self.SetTriangles(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetIndices__A_Int32__MeshTopology__Int32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32[] a1;
			checkArray(l,2,out a1);
			UnityEngine.MeshTopology a2;
			checkEnum(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.SetIndices(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetIndices__A_Int32__MeshTopology__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32[] a1;
			checkArray(l,2,out a1);
			UnityEngine.MeshTopology a2;
			checkEnum(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			self.SetIndices(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetIndices__A_Int32__MeshTopology__Int32__Boolean__Int32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32[] a1;
			checkArray(l,2,out a1);
			UnityEngine.MeshTopology a2;
			checkEnum(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			System.Int32 a5;
			checkType(l,6,out a5);
			self.SetIndices(a1,a2,a3,a4,a5);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBindposes(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Matrix4x4> a1;
			checkType(l,2,out a1);
			self.GetBindposes(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBoneWeights(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.BoneWeight> a1;
			checkType(l,2,out a1);
			self.GetBoneWeights(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Clear(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
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
	static public int Clear__Boolean(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.Clear(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RecalculateBounds(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.RecalculateBounds();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RecalculateNormals(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.RecalculateNormals();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RecalculateTangents(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.RecalculateTangents();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int MarkDynamic(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			self.MarkDynamic();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UploadMeshData(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.UploadMeshData(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTopology(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetTopology(a1);
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
	static public int CombineMeshes__A_CombineInstance(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.CombineInstance[] a1;
			checkArray(l,2,out a1);
			self.CombineMeshes(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CombineMeshes__A_CombineInstance__Boolean(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.CombineInstance[] a1;
			checkArray(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.CombineMeshes(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CombineMeshes__A_CombineInstance__Boolean__Boolean(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.CombineInstance[] a1;
			checkArray(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.CombineMeshes(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CombineMeshes__A_CombineInstance__Boolean__Boolean__Boolean(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.CombineInstance[] a1;
			checkArray(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			self.CombineMeshes(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_indexFormat(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.indexFormat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_indexFormat(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Rendering.IndexFormat v;
			checkEnum(l,2,out v);
			self.indexFormat=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_vertexBufferCount(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vertexBufferCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_blendShapeCount(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.blendShapeCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_boneWeights(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.boneWeights);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_boneWeights(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.BoneWeight[] v;
			checkArray(l,2,out v);
			self.boneWeights=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bindposes(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bindposes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bindposes(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Matrix4x4[] v;
			checkArray(l,2,out v);
			self.bindposes=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isReadable(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
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
	static public int get_isRenderable(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isRenderable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isRenderable(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.isRenderable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_vertexCount(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vertexCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_subMeshCount(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.subMeshCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_subMeshCount(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.subMeshCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bounds(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bounds);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bounds(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Bounds v;
			checkValueType(l,2,out v);
			self.bounds=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_vertices(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vertices);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_vertices(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector3[] v;
			checkArray(l,2,out v);
			self.vertices=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_normals(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.normals);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_normals(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector3[] v;
			checkArray(l,2,out v);
			self.normals=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_tangents(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tangents);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_tangents(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector4[] v;
			checkArray(l,2,out v);
			self.tangents=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_uv(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uv(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector2[] v;
			checkArray(l,2,out v);
			self.uv=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_uv2(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uv2(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector2[] v;
			checkArray(l,2,out v);
			self.uv2=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_uv3(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv3);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uv3(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector2[] v;
			checkArray(l,2,out v);
			self.uv3=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_uv4(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv4);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uv4(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector2[] v;
			checkArray(l,2,out v);
			self.uv4=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_uv5(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv5);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uv5(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector2[] v;
			checkArray(l,2,out v);
			self.uv5=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_uv6(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv6);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uv6(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector2[] v;
			checkArray(l,2,out v);
			self.uv6=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_uv7(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv7);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uv7(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector2[] v;
			checkArray(l,2,out v);
			self.uv7=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_uv8(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.uv8);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_uv8(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Vector2[] v;
			checkArray(l,2,out v);
			self.uv8=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colors(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.colors);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colors(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Color[] v;
			checkArray(l,2,out v);
			self.colors=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colors32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.colors32);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colors32(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			UnityEngine.Color32[] v;
			checkArray(l,2,out v);
			self.colors32=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_triangles(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.triangles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_triangles(IntPtr l) {
		try {
			UnityEngine.Mesh self=(UnityEngine.Mesh)checkSelf(l);
			System.Int32[] v;
			checkArray(l,2,out v);
			self.triangles=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Mesh");
		addMember(l,ctor_s);
		addMember(l,GetNativeVertexBufferPtr);
		addMember(l,GetNativeIndexBufferPtr);
		addMember(l,ClearBlendShapes);
		addMember(l,GetBlendShapeName);
		addMember(l,GetBlendShapeIndex);
		addMember(l,GetBlendShapeFrameCount);
		addMember(l,GetBlendShapeFrameWeight);
		addMember(l,GetBlendShapeFrameVertices);
		addMember(l,AddBlendShapeFrame);
		addMember(l,GetUVDistributionMetric);
		addMember(l,GetVertices);
		addMember(l,SetVertices);
		addMember(l,GetNormals);
		addMember(l,SetNormals);
		addMember(l,GetTangents);
		addMember(l,SetTangents);
		addMember(l,GetColors__List_1_Color);
		addMember(l,GetColors__List_1_Color32);
		addMember(l,SetColors__List_1_Color);
		addMember(l,SetColors__List_1_Color32);
		addMember(l,SetUVs__Int32__List_1_Vector2);
		addMember(l,SetUVs__Int32__List_1_Vector3);
		addMember(l,SetUVs__Int32__List_1_Vector4);
		addMember(l,GetUVs__Int32__List_1_Vector2);
		addMember(l,GetUVs__Int32__List_1_Vector3);
		addMember(l,GetUVs__Int32__List_1_Vector4);
		addMember(l,GetTriangles__Int32);
		addMember(l,GetTriangles__Int32__Boolean);
		addMember(l,GetTriangles__List_1_Int32__Int32);
		addMember(l,GetTriangles__List_1_Int32__Int32__Boolean);
		addMember(l,GetIndices__Int32);
		addMember(l,GetIndices__Int32__Boolean);
		addMember(l,GetIndices__List_1_Int32__Int32);
		addMember(l,GetIndices__List_1_Int32__Int32__Boolean);
		addMember(l,GetIndexStart);
		addMember(l,GetIndexCount);
		addMember(l,GetBaseVertex);
		addMember(l,SetTriangles__A_Int32__Int32);
		addMember(l,SetTriangles__List_1_Int32__Int32);
		addMember(l,SetTriangles__A_Int32__Int32__Boolean);
		addMember(l,SetTriangles__List_1_Int32__Int32__Boolean);
		addMember(l,SetTriangles__A_Int32__Int32__Boolean__Int32);
		addMember(l,SetTriangles__List_1_Int32__Int32__Boolean__Int32);
		addMember(l,SetIndices__A_Int32__MeshTopology__Int32);
		addMember(l,SetIndices__A_Int32__MeshTopology__Int32__Boolean);
		addMember(l,SetIndices__A_Int32__MeshTopology__Int32__Boolean__Int32);
		addMember(l,GetBindposes);
		addMember(l,GetBoneWeights);
		addMember(l,Clear);
		addMember(l,Clear__Boolean);
		addMember(l,RecalculateBounds);
		addMember(l,RecalculateNormals);
		addMember(l,RecalculateTangents);
		addMember(l,MarkDynamic);
		addMember(l,UploadMeshData);
		addMember(l,GetTopology);
		addMember(l,CombineMeshes__A_CombineInstance);
		addMember(l,CombineMeshes__A_CombineInstance__Boolean);
		addMember(l,CombineMeshes__A_CombineInstance__Boolean__Boolean);
		addMember(l,CombineMeshes__A_CombineInstance__Boolean__Boolean__Boolean);
		addMember(l,"indexFormat",get_indexFormat,set_indexFormat,true);
		addMember(l,"vertexBufferCount",get_vertexBufferCount,null,true);
		addMember(l,"blendShapeCount",get_blendShapeCount,null,true);
		addMember(l,"boneWeights",get_boneWeights,set_boneWeights,true);
		addMember(l,"bindposes",get_bindposes,set_bindposes,true);
		addMember(l,"isReadable",get_isReadable,null,true);
		addMember(l,"isRenderable",get_isRenderable,set_isRenderable,true);
		addMember(l,"vertexCount",get_vertexCount,null,true);
		addMember(l,"subMeshCount",get_subMeshCount,set_subMeshCount,true);
		addMember(l,"bounds",get_bounds,set_bounds,true);
		addMember(l,"vertices",get_vertices,set_vertices,true);
		addMember(l,"normals",get_normals,set_normals,true);
		addMember(l,"tangents",get_tangents,set_tangents,true);
		addMember(l,"uv",get_uv,set_uv,true);
		addMember(l,"uv2",get_uv2,set_uv2,true);
		addMember(l,"uv3",get_uv3,set_uv3,true);
		addMember(l,"uv4",get_uv4,set_uv4,true);
		addMember(l,"uv5",get_uv5,set_uv5,true);
		addMember(l,"uv6",get_uv6,set_uv6,true);
		addMember(l,"uv7",get_uv7,set_uv7,true);
		addMember(l,"uv8",get_uv8,set_uv8,true);
		addMember(l,"colors",get_colors,set_colors,true);
		addMember(l,"colors32",get_colors32,set_colors32,true);
		addMember(l,"triangles",get_triangles,set_triangles,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Mesh),typeof(UnityEngine.Object));
	}
}
