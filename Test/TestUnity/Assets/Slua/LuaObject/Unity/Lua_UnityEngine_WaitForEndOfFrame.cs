using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WaitForEndOfFrame : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.WaitForEndOfFrame o;
			o=new UnityEngine.WaitForEndOfFrame();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WaitForEndOfFrame");
		createTypeMetatable(l,constructor, typeof(UnityEngine.WaitForEndOfFrame),typeof(UnityEngine.YieldInstruction));
	}
}
