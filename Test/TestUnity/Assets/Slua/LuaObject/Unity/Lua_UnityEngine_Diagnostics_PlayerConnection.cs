using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Diagnostics_PlayerConnection : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SendFile_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Byte[] a2;
			checkArray(l,2,out a2);
			UnityEngine.Diagnostics.PlayerConnection.SendFile(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_connected(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Diagnostics.PlayerConnection.connected);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Diagnostics.PlayerConnection");
		addMember(l,SendFile_s);
		addMember(l,"connected",get_connected,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Diagnostics.PlayerConnection));
	}
}
