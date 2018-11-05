using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_ITickPlugin : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init(IntPtr l) {
		try {
			ITickPlugin self=(ITickPlugin)checkSelf(l);
			UnityEngine.GameObject a1;
			checkType(l,2,out a1);
			UnityEngine.MonoBehaviour a2;
			checkType(l,3,out a2);
			self.Init(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Update(IntPtr l) {
		try {
			ITickPlugin self=(ITickPlugin)checkSelf(l);
			self.Update();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int FixedUpdate(IntPtr l) {
		try {
			ITickPlugin self=(ITickPlugin)checkSelf(l);
			self.FixedUpdate();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LateUpdate(IntPtr l) {
		try {
			ITickPlugin self=(ITickPlugin)checkSelf(l);
			self.LateUpdate();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Call(IntPtr l) {
		try {
			ITickPlugin self=(ITickPlugin)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object[] a2;
			checkParams(l,3,out a2);
			self.Call(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"ITickPlugin");
		addMember(l,Init);
		addMember(l,Update);
		addMember(l,FixedUpdate);
		addMember(l,LateUpdate);
		addMember(l,Call);
		createTypeMetatable(l,null, typeof(ITickPlugin));
	}
}
