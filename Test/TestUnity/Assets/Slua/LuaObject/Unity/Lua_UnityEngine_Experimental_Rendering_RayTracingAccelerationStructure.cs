using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_RayTracingAccelerationStructure : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure o;
			o=new UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure();
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
	static public int ctor__RASSettings_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure o;
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure.RASSettings a1;
			checkValueType(l,1,out a1);
			o=new UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure(a1);
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
	static public int Dispose(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Release(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			self.Release();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Build(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			self.Build();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Build__Vector3(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.Build(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddInstance__Renderer__A_RayTracingSubMeshFlags__Boolean__Boolean__UInt32__UInt32(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			UnityEngine.Renderer a1;
			checkType(l,2,out a1);
			UnityEngine.Experimental.Rendering.RayTracingSubMeshFlags[] a2;
			checkArray(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			System.UInt32 a5;
			checkType(l,6,out a5);
			System.UInt32 a6;
			checkType(l,7,out a6);
			self.AddInstance(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddInstance__Renderer__A_Boolean__A_Boolean__Boolean__Boolean__UInt32__UInt32(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			UnityEngine.Renderer a1;
			checkType(l,2,out a1);
			System.Boolean[] a2;
			checkArray(l,3,out a2);
			System.Boolean[] a3;
			checkArray(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			System.Boolean a5;
			checkType(l,6,out a5);
			System.UInt32 a6;
			checkType(l,7,out a6);
			System.UInt32 a7;
			checkType(l,8,out a7);
			self.AddInstance(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddInstance__GraphicsBuffer__UInt32__Material__Boolean__Boolean__Boolean__UInt32__Boolean__UInt32(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			System.UInt32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Boolean a4;
			checkType(l,5,out a4);
			System.Boolean a5;
			checkType(l,6,out a5);
			System.Boolean a6;
			checkType(l,7,out a6);
			System.UInt32 a7;
			checkType(l,8,out a7);
			System.Boolean a8;
			checkType(l,9,out a8);
			System.UInt32 a9;
			checkType(l,10,out a9);
			self.AddInstance(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddInstance__GraphicsBuffer__UInt32__Material__Matrix4x4__Boolean__Boolean__Boolean__UInt32__Boolean__UInt32(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			UnityEngine.GraphicsBuffer a1;
			checkType(l,2,out a1);
			System.UInt32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			UnityEngine.Matrix4x4 a4;
			checkValueType(l,5,out a4);
			System.Boolean a5;
			checkType(l,6,out a5);
			System.Boolean a6;
			checkType(l,7,out a6);
			System.Boolean a7;
			checkType(l,8,out a7);
			System.UInt32 a8;
			checkType(l,9,out a8);
			System.Boolean a9;
			checkType(l,10,out a9);
			System.UInt32 a10;
			checkType(l,11,out a10);
			self.AddInstance(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveInstance(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			UnityEngine.Renderer a1;
			checkType(l,2,out a1);
			self.RemoveInstance(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateInstanceTransform(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			UnityEngine.Renderer a1;
			checkType(l,2,out a1);
			self.UpdateInstanceTransform(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateInstanceMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			UnityEngine.Renderer a1;
			checkType(l,2,out a1);
			System.UInt32 a2;
			checkType(l,3,out a2);
			self.UpdateInstanceMask(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdateInstanceID(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			UnityEngine.Renderer a1;
			checkType(l,2,out a1);
			System.UInt32 a2;
			checkType(l,3,out a2);
			self.UpdateInstanceID(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSize(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			var ret=self.GetSize();
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
	static public int GetInstanceCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure self=(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)checkSelf(l);
			var ret=self.GetInstanceCount();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure");
		addMember(l,ctor_s);
		addMember(l,ctor__RASSettings_s);
		addMember(l,Dispose);
		addMember(l,Release);
		addMember(l,Build);
		addMember(l,Build__Vector3);
		addMember(l,AddInstance__Renderer__A_RayTracingSubMeshFlags__Boolean__Boolean__UInt32__UInt32);
		addMember(l,AddInstance__Renderer__A_Boolean__A_Boolean__Boolean__Boolean__UInt32__UInt32);
		addMember(l,AddInstance__GraphicsBuffer__UInt32__Material__Boolean__Boolean__Boolean__UInt32__Boolean__UInt32);
		addMember(l,AddInstance__GraphicsBuffer__UInt32__Material__Matrix4x4__Boolean__Boolean__Boolean__UInt32__Boolean__UInt32);
		addMember(l,RemoveInstance);
		addMember(l,UpdateInstanceTransform);
		addMember(l,UpdateInstanceMask);
		addMember(l,UpdateInstanceID);
		addMember(l,GetSize);
		addMember(l,GetInstanceCount);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
	}
}
