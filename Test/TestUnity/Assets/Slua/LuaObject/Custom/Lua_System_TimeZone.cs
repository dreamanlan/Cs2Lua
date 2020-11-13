using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_TimeZone : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetDaylightChanges(IntPtr l) {
		try {
			System.TimeZone self=(System.TimeZone)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetDaylightChanges(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetUtcOffset(IntPtr l) {
		try {
			System.TimeZone self=(System.TimeZone)checkSelf(l);
			System.DateTime a1;
			checkValueType(l,2,out a1);
			var ret=self.GetUtcOffset(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsDaylightSavingTime(IntPtr l) {
		try {
			System.TimeZone self=(System.TimeZone)checkSelf(l);
			System.DateTime a1;
			checkValueType(l,2,out a1);
			var ret=self.IsDaylightSavingTime(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToLocalTime(IntPtr l) {
		try {
			System.TimeZone self=(System.TimeZone)checkSelf(l);
			System.DateTime a1;
			checkValueType(l,2,out a1);
			var ret=self.ToLocalTime(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToUniversalTime(IntPtr l) {
		try {
			System.TimeZone self=(System.TimeZone)checkSelf(l);
			System.DateTime a1;
			checkValueType(l,2,out a1);
			var ret=self.ToUniversalTime(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsDaylightSavingTime_s(IntPtr l) {
		try {
			System.DateTime a1;
			checkValueType(l,1,out a1);
			System.Globalization.DaylightTime a2;
			checkType(l,2,out a2);
			var ret=System.TimeZone.IsDaylightSavingTime(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CurrentTimeZone(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.TimeZone.CurrentTimeZone);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DaylightName(IntPtr l) {
		try {
			System.TimeZone self=(System.TimeZone)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.DaylightName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_StandardName(IntPtr l) {
		try {
			System.TimeZone self=(System.TimeZone)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.StandardName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.TimeZone");
		addMember(l,GetDaylightChanges);
		addMember(l,GetUtcOffset);
		addMember(l,IsDaylightSavingTime);
		addMember(l,ToLocalTime);
		addMember(l,ToUniversalTime);
		addMember(l,IsDaylightSavingTime_s);
		addMember(l,"CurrentTimeZone",get_CurrentTimeZone,null,false);
		addMember(l,"DaylightName",get_DaylightName,null,true);
		addMember(l,"StandardName",get_StandardName,null,true);
		createTypeMetatable(l,null, typeof(System.TimeZone));
	}
}
