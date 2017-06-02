using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Effector2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useColliderMask(IntPtr l) {
		try {
			UnityEngine.Effector2D self=(UnityEngine.Effector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useColliderMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useColliderMask(IntPtr l) {
		try {
			UnityEngine.Effector2D self=(UnityEngine.Effector2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useColliderMask=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colliderMask(IntPtr l) {
		try {
			UnityEngine.Effector2D self=(UnityEngine.Effector2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.colliderMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colliderMask(IntPtr l) {
		try {
			UnityEngine.Effector2D self=(UnityEngine.Effector2D)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.colliderMask=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Effector2D");
		addMember(l,"useColliderMask",get_useColliderMask,set_useColliderMask,true);
		addMember(l,"colliderMask",get_colliderMask,set_colliderMask,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Effector2D),typeof(UnityEngine.Behaviour));
	}
}
