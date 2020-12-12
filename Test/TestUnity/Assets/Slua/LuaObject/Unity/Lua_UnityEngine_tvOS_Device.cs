using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_tvOS_Device : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.tvOS.Device o;
			o=new UnityEngine.tvOS.Device();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetNoBackupFlag_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.tvOS.Device.SetNoBackupFlag(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResetNoBackupFlag_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.tvOS.Device.ResetNoBackupFlag(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_systemVersion(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.tvOS.Device.systemVersion);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_generation(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.tvOS.Device.generation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_vendorIdentifier(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.tvOS.Device.vendorIdentifier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_advertisingIdentifier(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.tvOS.Device.advertisingIdentifier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_advertisingTrackingEnabled(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.tvOS.Device.advertisingTrackingEnabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.tvOS.Device");
		addMember(l,ctor_s);
		addMember(l,SetNoBackupFlag_s);
		addMember(l,ResetNoBackupFlag_s);
		addMember(l,"systemVersion",get_systemVersion,null,false);
		addMember(l,"generation",get_generation,null,false);
		addMember(l,"vendorIdentifier",get_vendorIdentifier,null,false);
		addMember(l,"advertisingIdentifier",get_advertisingIdentifier,null,false);
		addMember(l,"advertisingTrackingEnabled",get_advertisingTrackingEnabled,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.tvOS.Device));
	}
}
