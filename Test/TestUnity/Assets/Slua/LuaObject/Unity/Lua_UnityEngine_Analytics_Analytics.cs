using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Analytics_Analytics : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int FlushEvents_s(IntPtr l) {
		try {
			var ret=UnityEngine.Analytics.Analytics.FlushEvents();
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetUserId_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Analytics.Analytics.SetUserId(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetUserGender_s(IntPtr l) {
		try {
			UnityEngine.Analytics.Gender a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.Analytics.Analytics.SetUserGender(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetUserBirthYear_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Analytics.Analytics.SetUserBirthYear(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Transaction_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.String a1;
				checkType(l,1,out a1);
				System.Decimal a2;
				checkValueType(l,2,out a2);
				System.String a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.Analytics.Analytics.Transaction(a1,a2,a3);
				pushValue(l,true);
				pushEnum(l,(int)ret);
				return 2;
			}
			else if(argc==5){
				System.String a1;
				checkType(l,1,out a1);
				System.Decimal a2;
				checkValueType(l,2,out a2);
				System.String a3;
				checkType(l,3,out a3);
				System.String a4;
				checkType(l,4,out a4);
				System.String a5;
				checkType(l,5,out a5);
				var ret=UnityEngine.Analytics.Analytics.Transaction(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushEnum(l,(int)ret);
				return 2;
			}
			else if(argc==6){
				System.String a1;
				checkType(l,1,out a1);
				System.Decimal a2;
				checkValueType(l,2,out a2);
				System.String a3;
				checkType(l,3,out a3);
				System.String a4;
				checkType(l,4,out a4);
				System.String a5;
				checkType(l,5,out a5);
				System.Boolean a6;
				checkType(l,6,out a6);
				var ret=UnityEngine.Analytics.Analytics.Transaction(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				pushEnum(l,(int)ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CustomEvent_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.String a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.Analytics.Analytics.CustomEvent(a1);
				pushValue(l,true);
				pushEnum(l,(int)ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(IDictionary<System.String,object>))){
				System.String a1;
				checkType(l,1,out a1);
				System.Collections.Generic.IDictionary<System.String,System.Object> a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Analytics.Analytics.CustomEvent(a1,a2);
				pushValue(l,true);
				pushEnum(l,(int)ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(string),typeof(UnityEngine.Vector3))){
				System.String a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Analytics.Analytics.CustomEvent(a1,a2);
				pushValue(l,true);
				pushEnum(l,(int)ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_limitUserTracking(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Analytics.Analytics.limitUserTracking);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_limitUserTracking(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Analytics.Analytics.limitUserTracking=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_deviceStatsEnabled(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Analytics.Analytics.deviceStatsEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_deviceStatsEnabled(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Analytics.Analytics.deviceStatsEnabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enabled(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Analytics.Analytics.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enabled(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Analytics.Analytics.enabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Analytics.Analytics");
		addMember(l,FlushEvents_s);
		addMember(l,SetUserId_s);
		addMember(l,SetUserGender_s);
		addMember(l,SetUserBirthYear_s);
		addMember(l,Transaction_s);
		addMember(l,CustomEvent_s);
		addMember(l,"limitUserTracking",get_limitUserTracking,set_limitUserTracking,false);
		addMember(l,"deviceStatsEnabled",get_deviceStatsEnabled,set_deviceStatsEnabled,false);
		addMember(l,"enabled",get_enabled,set_enabled,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Analytics.Analytics));
	}
}
