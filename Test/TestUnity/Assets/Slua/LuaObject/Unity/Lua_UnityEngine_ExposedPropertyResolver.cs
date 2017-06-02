using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ExposedPropertyResolver : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ExposedPropertyResolver o;
			o=new UnityEngine.ExposedPropertyResolver();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ExposedPropertyResolver");
		createTypeMetatable(l,constructor, typeof(UnityEngine.ExposedPropertyResolver),typeof(System.ValueType));
	}
}
