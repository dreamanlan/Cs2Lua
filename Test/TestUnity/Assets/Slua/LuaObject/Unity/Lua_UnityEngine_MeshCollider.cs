using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MeshCollider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.MeshCollider o;
			o=new UnityEngine.MeshCollider();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sharedMesh(IntPtr l) {
		try {
			UnityEngine.MeshCollider self=(UnityEngine.MeshCollider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sharedMesh);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sharedMesh(IntPtr l) {
		try {
			UnityEngine.MeshCollider self=(UnityEngine.MeshCollider)checkSelf(l);
			UnityEngine.Mesh v;
			checkType(l,2,out v);
			self.sharedMesh=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_convex(IntPtr l) {
		try {
			UnityEngine.MeshCollider self=(UnityEngine.MeshCollider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.convex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_convex(IntPtr l) {
		try {
			UnityEngine.MeshCollider self=(UnityEngine.MeshCollider)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.convex=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MeshCollider");
		addMember(l,"sharedMesh",get_sharedMesh,set_sharedMesh,true);
		addMember(l,"convex",get_convex,set_convex,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.MeshCollider),typeof(UnityEngine.Collider));
	}
}
