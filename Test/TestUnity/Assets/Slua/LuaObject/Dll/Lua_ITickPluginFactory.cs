using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_ITickPluginFactory : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateInstance(IntPtr l) {
		try {
			ITickPluginFactory self=(ITickPluginFactory)checkSelf(l);
			var ret=self.CreateInstance();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"ITickPluginFactory");
		addMember(l,CreateInstance);
		createTypeMetatable(l,null, typeof(ITickPluginFactory));
	}
}
