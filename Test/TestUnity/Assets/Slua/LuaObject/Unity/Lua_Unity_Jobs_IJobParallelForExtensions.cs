using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Jobs_IJobParallelForExtensions : LuaObject {
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"Unity.Jobs.IJobParallelForExtensions");
		createTypeMetatable(l,null, typeof(Unity.Jobs.IJobParallelForExtensions));
	}
}
