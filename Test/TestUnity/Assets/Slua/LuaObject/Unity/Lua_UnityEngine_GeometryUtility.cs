using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_GeometryUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
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
	static public int CalculateFrustumPlanes_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(UnityEngine.Matrix4x4))){
				UnityEngine.Matrix4x4 a1;
				checkValueType(l,1,out a1);
				var ret=UnityEngine.GeometryUtility.CalculateFrustumPlanes(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(UnityEngine.Camera))){
				UnityEngine.Camera a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.GeometryUtility.CalculateFrustumPlanes(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
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
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GeometryUtility");
		addMember(l,CalculateFrustumPlanes_s);
		addMember(l,TestPlanesAABB_s);
		createTypeMetatable(l,constructor, typeof(UnityEngine.GeometryUtility));
	}
}
