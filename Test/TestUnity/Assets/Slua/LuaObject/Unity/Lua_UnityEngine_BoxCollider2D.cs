using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_BoxCollider2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_size(IntPtr l) {
		try {
			UnityEngine.BoxCollider2D self=(UnityEngine.BoxCollider2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.size);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_size(IntPtr l) {
		try {
			UnityEngine.BoxCollider2D self=(UnityEngine.BoxCollider2D)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.size=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_edgeRadius(IntPtr l) {
		try {
			UnityEngine.BoxCollider2D self=(UnityEngine.BoxCollider2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.edgeRadius);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_edgeRadius(IntPtr l) {
		try {
			UnityEngine.BoxCollider2D self=(UnityEngine.BoxCollider2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.edgeRadius=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autoTiling(IntPtr l) {
		try {
			UnityEngine.BoxCollider2D self=(UnityEngine.BoxCollider2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoTiling);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_autoTiling(IntPtr l) {
		try {
			UnityEngine.BoxCollider2D self=(UnityEngine.BoxCollider2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoTiling=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.BoxCollider2D");
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"edgeRadius",get_edgeRadius,set_edgeRadius,true);
		addMember(l,"autoTiling",get_autoTiling,set_autoTiling,true);
		createTypeMetatable(l,null, typeof(UnityEngine.BoxCollider2D),typeof(UnityEngine.Collider2D));
	}
}
