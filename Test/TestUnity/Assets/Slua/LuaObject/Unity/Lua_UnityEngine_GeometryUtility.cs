using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_GeometryUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.GeometryUtility o;
			o=new UnityEngine.GeometryUtility();
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
	static public int CalculateFrustumPlanes__Camera_s(IntPtr l) {
		try {
			UnityEngine.Camera a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.GeometryUtility.CalculateFrustumPlanes(a1);
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
	static public int CalculateFrustumPlanes__Matrix4x4_s(IntPtr l) {
		try {
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.GeometryUtility.CalculateFrustumPlanes(a1);
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
	static public int CalculateFrustumPlanes__Camera__A_Plane_s(IntPtr l) {
		try {
			UnityEngine.Camera a1;
			checkType(l,1,out a1);
			UnityEngine.Plane[] a2;
			checkArray(l,2,out a2);
			UnityEngine.GeometryUtility.CalculateFrustumPlanes(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CalculateFrustumPlanes__Matrix4x4__A_Plane_s(IntPtr l) {
		try {
			UnityEngine.Matrix4x4 a1;
			checkValueType(l,1,out a1);
			UnityEngine.Plane[] a2;
			checkArray(l,2,out a2);
			UnityEngine.GeometryUtility.CalculateFrustumPlanes(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CalculateBounds_s(IntPtr l) {
		try {
			UnityEngine.Vector3[] a1;
			checkArray(l,1,out a1);
			UnityEngine.Matrix4x4 a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.GeometryUtility.CalculateBounds(a1,a2);
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
	static public int TryCreatePlaneFromPolygon_s(IntPtr l) {
		try {
			UnityEngine.Vector3[] a1;
			checkArray(l,1,out a1);
			UnityEngine.Plane a2;
			var ret=UnityEngine.GeometryUtility.TryCreatePlaneFromPolygon(a1,out a2);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TestPlanesAABB_s(IntPtr l) {
		try {
			UnityEngine.Plane[] a1;
			checkArray(l,1,out a1);
			UnityEngine.Bounds a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.GeometryUtility.TestPlanesAABB(a1,a2);
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
		getTypeTable(l,"UnityEngine.GeometryUtility");
		addMember(l,ctor_s);
		addMember(l,CalculateFrustumPlanes__Camera_s);
		addMember(l,CalculateFrustumPlanes__Matrix4x4_s);
		addMember(l,CalculateFrustumPlanes__Camera__A_Plane_s);
		addMember(l,CalculateFrustumPlanes__Matrix4x4__A_Plane_s);
		addMember(l,CalculateBounds_s);
		addMember(l,TryCreatePlaneFromPolygon_s);
		addMember(l,TestPlanesAABB_s);
		createTypeMetatable(l,null, typeof(UnityEngine.GeometryUtility));
	}
}
