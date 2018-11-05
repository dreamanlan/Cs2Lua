using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_IStartupPlugin : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Start(IntPtr l) {
		try {
			IStartupPlugin self=(IStartupPlugin)checkSelf(l);
			UnityEngine.GameObject a1;
			checkType(l,2,out a1);
			UnityEngine.MonoBehaviour a2;
			checkType(l,3,out a2);
			self.Start(a1,a2);
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
			IStartupPlugin self=(IStartupPlugin)checkSelf(l);
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
		getTypeTable(l,"IStartupPlugin");
		addMember(l,Start);
		addMember(l,Call);
		createTypeMetatable(l,null, typeof(IStartupPlugin));
	}
}
