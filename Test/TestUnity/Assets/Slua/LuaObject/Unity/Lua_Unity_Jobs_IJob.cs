using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Jobs_IJob : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Execute(IntPtr l) {
		try {
			Unity.Jobs.IJob self=(Unity.Jobs.IJob)checkSelf(l);
			self.Execute();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"Unity.Jobs.IJob");
		addMember(l,Execute);
		createTypeMetatable(l,null, typeof(Unity.Jobs.IJob));
	}
}
