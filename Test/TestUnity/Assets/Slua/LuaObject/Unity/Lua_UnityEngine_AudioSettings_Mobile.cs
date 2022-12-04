using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AudioSettings_Mobile : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StartAudioOutput_s(IntPtr l) {
		try {
			UnityEngine.AudioSettings.Mobile.StartAudioOutput();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopAudioOutput_s(IntPtr l) {
		try {
			UnityEngine.AudioSettings.Mobile.StopAudioOutput();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_muteState(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.AudioSettings.Mobile.muteState);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_stopAudioOutputOnMute(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.AudioSettings.Mobile.stopAudioOutputOnMute);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stopAudioOutputOnMute(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.AudioSettings.Mobile.stopAudioOutputOnMute=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_audioOutputStarted(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.AudioSettings.Mobile.audioOutputStarted);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioSettings.Mobile");
		addMember(l,StartAudioOutput_s);
		addMember(l,StopAudioOutput_s);
		addMember(l,"muteState",get_muteState,null,false);
		addMember(l,"stopAudioOutputOnMute",get_stopAudioOutputOnMute,set_stopAudioOutputOnMute,false);
		addMember(l,"audioOutputStarted",get_audioOutputStarted,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.AudioSettings.Mobile));
	}
}
