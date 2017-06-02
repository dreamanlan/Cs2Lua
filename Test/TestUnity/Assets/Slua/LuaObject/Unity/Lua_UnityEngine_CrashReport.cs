using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CrashReport : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Remove(IntPtr l) {
		try {
			UnityEngine.CrashReport self=(UnityEngine.CrashReport)checkSelf(l);
			self.Remove();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RemoveAll_s(IntPtr l) {
		try {
			UnityEngine.CrashReport.RemoveAll();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_time(IntPtr l) {
		try {
			UnityEngine.CrashReport self=(UnityEngine.CrashReport)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.time);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_text(IntPtr l) {
		try {
			UnityEngine.CrashReport self=(UnityEngine.CrashReport)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.text);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_reports(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.CrashReport.reports);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lastReport(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.CrashReport.lastReport);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CrashReport");
		addMember(l,Remove);
		addMember(l,RemoveAll_s);
		addMember(l,"time",get_time,null,true);
		addMember(l,"text",get_text,null,true);
		addMember(l,"reports",get_reports,null,false);
		addMember(l,"lastReport",get_lastReport,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.CrashReport));
	}
}
