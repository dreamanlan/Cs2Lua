using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Mesh_MeshData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData o;
			o=new UnityEngine.Mesh.MeshData();
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
	static public int GetVertexBufferStride(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetVertexBufferStride(a1);
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
	static public int HasVertexAttribute(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.VertexAttribute a1;
			checkEnum(l,2,out a1);
			var ret=self.HasVertexAttribute(a1);
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
	static public int GetVertexAttributeDimension(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.VertexAttribute a1;
			checkEnum(l,2,out a1);
			var ret=self.GetVertexAttributeDimension(a1);
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
	static public int GetVertexAttributeFormat(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.VertexAttribute a1;
			checkEnum(l,2,out a1);
			var ret=self.GetVertexAttributeFormat(a1);
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
	static public int GetVertexAttributeStream(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.VertexAttribute a1;
			checkEnum(l,2,out a1);
			var ret=self.GetVertexAttributeStream(a1);
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
	static public int GetVertexAttributeOffset(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.VertexAttribute a1;
			checkEnum(l,2,out a1);
			var ret=self.GetVertexAttributeOffset(a1);
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
	static public int SetVertexBufferParams(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.VertexAttributeDescriptor[] a2;
			checkValueParams(l,3,out a2);
			self.SetVertexBufferParams(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetIndexBufferParams(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.IndexFormat a2;
			checkEnum(l,3,out a2);
			self.SetIndexBufferParams(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSubMesh(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetSubMesh(a1);
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
	static public int SetSubMesh(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.SubMeshDescriptor a2;
			checkValueType(l,3,out a2);
			UnityEngine.Rendering.MeshUpdateFlags a3;
			checkEnum(l,4,out a3);
			self.SetSubMesh(a1,a2,a3);
			pushValue(l,true);
			setBack(l,(object)self);
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
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
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
	static public int get_vertexBufferCount(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
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
	static public int get_indexFormat(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
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
	static public int get_subMeshCount(IntPtr l) {
		try {
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
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
			UnityEngine.Mesh.MeshData self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.subMeshCount=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Mesh.MeshData");
		addMember(l,ctor_s);
		addMember(l,GetVertexBufferStride);
		addMember(l,HasVertexAttribute);
		addMember(l,GetVertexAttributeDimension);
		addMember(l,GetVertexAttributeFormat);
		addMember(l,GetVertexAttributeStream);
		addMember(l,GetVertexAttributeOffset);
		addMember(l,SetVertexBufferParams);
		addMember(l,SetIndexBufferParams);
		addMember(l,GetSubMesh);
		addMember(l,SetSubMesh);
		addMember(l,"vertexCount",get_vertexCount,null,true);
		addMember(l,"vertexBufferCount",get_vertexBufferCount,null,true);
		addMember(l,"indexFormat",get_indexFormat,null,true);
		addMember(l,"subMeshCount",get_subMeshCount,set_subMeshCount,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Mesh.MeshData),typeof(System.ValueType));
	}
}
