using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WaitForFixedUpdate : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.WaitForFixedUpdate o;
			o=new UnityEngine.WaitForFixedUpdate();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WaitForFixedUpdate");
		createTypeMetatable(l,constructor, typeof(UnityEngine.WaitForFixedUpdate),typeof(UnityEngine.YieldInstruction));
	}
}
