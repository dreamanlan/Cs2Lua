using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Jobs_IJobParallelFor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Execute(IntPtr l) {
		try {
			Unity.Jobs.IJobParallelFor self=(Unity.Jobs.IJobParallelFor)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.Execute(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"Unity.Jobs.IJobParallelFor");
		addMember(l,Execute);
		createTypeMetatable(l,null, typeof(Unity.Jobs.IJobParallelFor));
	}
}
