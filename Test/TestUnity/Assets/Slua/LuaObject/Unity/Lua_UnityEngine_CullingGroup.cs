using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CullingGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.CullingGroup o;
			o=new UnityEngine.CullingGroup();
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
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
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
	static public int SetBoundingSpheres(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			UnityEngine.BoundingSphere[] a1;
			checkArray(l,2,out a1);
			self.SetBoundingSpheres(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBoundingSphereCount(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.SetBoundingSphereCount(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EraseSwapBack(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.EraseSwapBack(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int QueryIndices__Boolean__A_Int32__Int32(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			System.Int32[] a2;
			checkArray(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.QueryIndices(a1,a2,a3);
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
	static public int QueryIndices__Int32__A_Int32__Int32(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32[] a2;
			checkArray(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.QueryIndices(a1,a2,a3);
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
	static public int QueryIndices__Boolean__Int32__A_Int32__Int32(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32[] a3;
			checkArray(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			var ret=self.QueryIndices(a1,a2,a3,a4);
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
	static public int IsVisible(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.IsVisible(a1);
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
	static public int GetDistance(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetDistance(a1);
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
	static public int SetBoundingDistances(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			System.Single[] a1;
			checkArray(l,2,out a1);
			self.SetBoundingDistances(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetDistanceReferencePoint__Vector3(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.SetDistanceReferencePoint(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetDistanceReferencePoint__Transform(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			self.SetDistanceReferencePoint(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_onStateChanged(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			UnityEngine.CullingGroup.StateChanged v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onStateChanged=v;
			else if(op==1) self.onStateChanged+=v;
			else if(op==2) self.onStateChanged-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enabled(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_targetCamera(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.targetCamera);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_targetCamera(IntPtr l) {
		try {
			UnityEngine.CullingGroup self=(UnityEngine.CullingGroup)checkSelf(l);
			UnityEngine.Camera v;
			checkType(l,2,out v);
			self.targetCamera=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CullingGroup");
		addMember(l,ctor_s);
		addMember(l,Dispose);
		addMember(l,SetBoundingSpheres);
		addMember(l,SetBoundingSphereCount);
		addMember(l,EraseSwapBack);
		addMember(l,QueryIndices__Boolean__A_Int32__Int32);
		addMember(l,QueryIndices__Int32__A_Int32__Int32);
		addMember(l,QueryIndices__Boolean__Int32__A_Int32__Int32);
		addMember(l,IsVisible);
		addMember(l,GetDistance);
		addMember(l,SetBoundingDistances);
		addMember(l,SetDistanceReferencePoint__Vector3);
		addMember(l,SetDistanceReferencePoint__Transform);
		addMember(l,"onStateChanged",null,set_onStateChanged,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"targetCamera",get_targetCamera,set_targetCamera,true);
		createTypeMetatable(l,null, typeof(UnityEngine.CullingGroup));
	}
}
