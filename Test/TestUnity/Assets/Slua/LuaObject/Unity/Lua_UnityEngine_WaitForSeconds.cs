using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WaitForSeconds : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.WaitForSeconds o;
			System.Single a1;
			checkType(l,2,out a1);
			o=new UnityEngine.WaitForSeconds(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WaitForSeconds");
		createTypeMetatable(l,constructor, typeof(UnityEngine.WaitForSeconds),typeof(UnityEngine.YieldInstruction));
	}
}
