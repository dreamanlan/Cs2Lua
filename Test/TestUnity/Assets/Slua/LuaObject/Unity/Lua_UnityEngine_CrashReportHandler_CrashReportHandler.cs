using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CrashReportHandler_CrashReportHandler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableCaptureExceptions(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.CrashReportHandler.CrashReportHandler.enableCaptureExceptions);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableCaptureExceptions(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.CrashReportHandler.CrashReportHandler.enableCaptureExceptions=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CrashReportHandler.CrashReportHandler");
		addMember(l,"enableCaptureExceptions",get_enableCaptureExceptions,set_enableCaptureExceptions,false);
		createTypeMetatable(l,null, typeof(UnityEngine.CrashReportHandler.CrashReportHandler));
	}
}
