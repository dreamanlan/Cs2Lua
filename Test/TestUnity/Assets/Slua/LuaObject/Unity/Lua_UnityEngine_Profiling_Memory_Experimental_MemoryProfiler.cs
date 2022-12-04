using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Profiling_Memory_Experimental_MemoryProfiler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Profiling.Memory.Experimental.MemoryProfiler o;
			o=new UnityEngine.Profiling.Memory.Experimental.MemoryProfiler();
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
		getTypeTable(l,"UnityEngine.Profiling.Memory.Experimental.MemoryProfiler");
		addMember(l,ctor_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Profiling.Memory.Experimental.MemoryProfiler));
	}
}
