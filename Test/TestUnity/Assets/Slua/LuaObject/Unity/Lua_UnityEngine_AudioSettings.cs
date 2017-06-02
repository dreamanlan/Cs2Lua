using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AudioSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AudioSettings o;
			o=new UnityEngine.AudioSettings();
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
	static public int GetDSPBufferSize_s(IntPtr l) {
		try {
			System.Int32 a1;
			System.Int32 a2;
			UnityEngine.AudioSettings.GetDSPBufferSize(out a1,out a2);
			pushValue(l,true);
			pushValue(l,a1);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetConfiguration_s(IntPtr l) {
		try {
			var ret=UnityEngine.AudioSettings.GetConfiguration();
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
	static public int Reset_s(IntPtr l) {
		try {
			UnityEngine.AudioConfiguration a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.AudioSettings.Reset(a1);
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
	static public int get_driverCapabilities(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.AudioSettings.driverCapabilities);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_speakerMode(IntPtr l) {
		try {
			pushValue(l,true);
			pushEnum(l,(int)UnityEngine.AudioSettings.speakerMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_speakerMode(IntPtr l) {
		try {
			UnityEngine.AudioSpeakerMode v;
			checkEnum(l,2,out v);
			UnityEngine.AudioSettings.speakerMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_dspTime(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.AudioSettings.dspTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_outputSampleRate(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.AudioSettings.outputSampleRate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_outputSampleRate(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.AudioSettings.outputSampleRate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioSettings");
		addMember(l,GetDSPBufferSize_s);
		addMember(l,GetConfiguration_s);
		addMember(l,Reset_s);
		addMember(l,"driverCapabilities",get_driverCapabilities,null,false);
		addMember(l,"speakerMode",get_speakerMode,set_speakerMode,false);
		addMember(l,"dspTime",get_dspTime,null,false);
		addMember(l,"outputSampleRate",get_outputSampleRate,set_outputSampleRate,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioSettings));
	}
}
