using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_StaticBatchingUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.StaticBatchingUtility o;
			o=new UnityEngine.StaticBatchingUtility();
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
	static public int Combine__GameObject_s(IntPtr l) {
		try {
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			UnityEngine.StaticBatchingUtility.Combine(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Combine__A_GameObject__GameObject_s(IntPtr l) {
		try {
			UnityEngine.GameObject[] a1;
			checkArray(l,1,out a1);
			UnityEngine.GameObject a2;
			checkType(l,2,out a2);
			UnityEngine.StaticBatchingUtility.Combine(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.StaticBatchingUtility");
		addMember(l,ctor_s);
		addMember(l,Combine__GameObject_s);
		addMember(l,Combine__A_GameObject__GameObject_s);
		createTypeMetatable(l,null, typeof(UnityEngine.StaticBatchingUtility));
	}
}
