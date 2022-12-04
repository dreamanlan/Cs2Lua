using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SubMeshDescriptor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor o;
			o=new UnityEngine.Rendering.SubMeshDescriptor();
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
	static public int ctor__Int32__Int32__MeshTopology_s(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.MeshTopology a3;
			checkEnum(l,3,out a3);
			o=new UnityEngine.Rendering.SubMeshDescriptor(a1,a2,a3);
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
	static new public int ToString(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			var ret=self.ToString();
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
	static public int get_bounds(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
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
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.Bounds v;
			checkValueType(l,2,out v);
			self.bounds=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_topology(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.topology);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_topology(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.MeshTopology v;
			checkEnum(l,2,out v);
			self.topology=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_indexStart(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.indexStart);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_indexStart(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.indexStart=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_indexCount(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.indexCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_indexCount(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.indexCount=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_baseVertex(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.baseVertex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_baseVertex(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.baseVertex=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_firstVertex(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.firstVertex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_firstVertex(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.firstVertex=v;
			setBack(l,(object)self);
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
			UnityEngine.Rendering.SubMeshDescriptor self;
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
	static public int set_vertexCount(IntPtr l) {
		try {
			UnityEngine.Rendering.SubMeshDescriptor self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.vertexCount=v;
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
		getTypeTable(l,"UnityEngine.Rendering.SubMeshDescriptor");
		addMember(l,ctor_s);
		addMember(l,ctor__Int32__Int32__MeshTopology_s);
		addMember(l,ToString);
		addMember(l,"bounds",get_bounds,set_bounds,true);
		addMember(l,"topology",get_topology,set_topology,true);
		addMember(l,"indexStart",get_indexStart,set_indexStart,true);
		addMember(l,"indexCount",get_indexCount,set_indexCount,true);
		addMember(l,"baseVertex",get_baseVertex,set_baseVertex,true);
		addMember(l,"firstVertex",get_firstVertex,set_firstVertex,true);
		addMember(l,"vertexCount",get_vertexCount,set_vertexCount,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.SubMeshDescriptor),typeof(System.ValueType));
	}
}
