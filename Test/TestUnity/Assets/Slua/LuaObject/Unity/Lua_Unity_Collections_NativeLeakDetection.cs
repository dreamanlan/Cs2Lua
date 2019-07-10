using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_Unity_Collections_NativeLeakDetection : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Mode(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)Unity.Collections.NativeLeakDetection.Mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_Mode(IntPtr l) {
		try {
			Unity.Collections.NativeLeakDetectionMode v;
			checkEnum(l,2,out v);
			Unity.Collections.NativeLeakDetection.Mode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"Unity.Collections.NativeLeakDetection");
		addMember(l,"Mode",get_Mode,set_Mode,false);
		createTypeMetatable(l,null, typeof(Unity.Collections.NativeLeakDetection));
	}
}
