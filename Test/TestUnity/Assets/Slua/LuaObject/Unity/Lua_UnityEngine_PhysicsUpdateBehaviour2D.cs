using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_PhysicsUpdateBehaviour2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.PhysicsUpdateBehaviour2D o;
			o=new UnityEngine.PhysicsUpdateBehaviour2D();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PhysicsUpdateBehaviour2D");
		createTypeMetatable(l,constructor, typeof(UnityEngine.PhysicsUpdateBehaviour2D),typeof(UnityEngine.Behaviour));
	}
}
