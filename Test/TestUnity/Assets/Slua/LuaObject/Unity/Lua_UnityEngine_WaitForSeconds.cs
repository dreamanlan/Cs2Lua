using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_WaitForSeconds : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.WaitForSeconds o;
			System.Single a1;
			checkType(l,1,out a1);
			o=new UnityEngine.WaitForSeconds(a1);
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
		getTypeTable(l,"UnityEngine.WaitForSeconds");
		addMember(l,ctor_s);
		createTypeMetatable(l,null, typeof(UnityEngine.WaitForSeconds),typeof(UnityEngine.YieldInstruction));
	}
}
