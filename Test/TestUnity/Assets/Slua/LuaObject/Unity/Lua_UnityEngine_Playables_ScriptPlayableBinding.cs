using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Playables_ScriptPlayableBinding : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Create_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			System.Type a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Playables.ScriptPlayableBinding.Create(a1,a2,a3);
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
		getTypeTable(l,"UnityEngine.Playables.ScriptPlayableBinding");
		addMember(l,Create_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Playables.ScriptPlayableBinding));
	}
}
