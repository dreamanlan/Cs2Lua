using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_BatchRendererGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchRendererGroup o;
			UnityEngine.Rendering.BatchRendererGroup.OnPerformCulling a1;
			LuaDelegation.checkDelegate(l,1,out a1);
			o=new UnityEngine.Rendering.BatchRendererGroup(a1);
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
			UnityEngine.Rendering.BatchRendererGroup self=(UnityEngine.Rendering.BatchRendererGroup)checkSelf(l);
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
	static public int AddBatch(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchRendererGroup self=(UnityEngine.Rendering.BatchRendererGroup)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Material a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			UnityEngine.Rendering.ShadowCastingMode a5;
			checkEnum(l,6,out a5);
			System.Boolean a6;
			checkType(l,7,out a6);
			System.Boolean a7;
			checkType(l,8,out a7);
			UnityEngine.Bounds a8;
			checkValueType(l,9,out a8);
			System.Int32 a9;
			checkType(l,10,out a9);
			UnityEngine.MaterialPropertyBlock a10;
			checkType(l,11,out a10);
			UnityEngine.GameObject a11;
			checkType(l,12,out a11);
			System.UInt64 a12;
			checkType(l,13,out a12);
			System.UInt32 a13;
			checkType(l,14,out a13);
			var ret=self.AddBatch(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12,a13);
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
	static public int SetBatchFlags(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchRendererGroup self=(UnityEngine.Rendering.BatchRendererGroup)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.UInt64 a2;
			checkType(l,3,out a2);
			self.SetBatchFlags(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInstancingData(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchRendererGroup self=(UnityEngine.Rendering.BatchRendererGroup)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.MaterialPropertyBlock a3;
			checkType(l,4,out a3);
			self.SetInstancingData(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBatchBounds(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchRendererGroup self=(UnityEngine.Rendering.BatchRendererGroup)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Bounds a2;
			checkValueType(l,3,out a2);
			self.SetBatchBounds(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetNumBatches(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchRendererGroup self=(UnityEngine.Rendering.BatchRendererGroup)checkSelf(l);
			var ret=self.GetNumBatches();
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
	static public int RemoveBatch(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchRendererGroup self=(UnityEngine.Rendering.BatchRendererGroup)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.RemoveBatch(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EnableVisibleIndicesYArray(IntPtr l) {
		try {
			UnityEngine.Rendering.BatchRendererGroup self=(UnityEngine.Rendering.BatchRendererGroup)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.EnableVisibleIndicesYArray(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.BatchRendererGroup");
		addMember(l,ctor_s);
		addMember(l,Dispose);
		addMember(l,AddBatch);
		addMember(l,SetBatchFlags);
		addMember(l,SetInstancingData);
		addMember(l,SetBatchBounds);
		addMember(l,GetNumBatches);
		addMember(l,RemoveBatch);
		addMember(l,EnableVisibleIndicesYArray);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.BatchRendererGroup));
	}
}
