using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Audio_AudioMixerSnapshot : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int TransitionTo(IntPtr l) {
		try {
			UnityEngine.Audio.AudioMixerSnapshot self=(UnityEngine.Audio.AudioMixerSnapshot)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.TransitionTo(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_audioMixer(IntPtr l) {
		try {
			UnityEngine.Audio.AudioMixerSnapshot self=(UnityEngine.Audio.AudioMixerSnapshot)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.audioMixer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Audio.AudioMixerSnapshot");
		addMember(l,TransitionTo);
		addMember(l,"audioMixer",get_audioMixer,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Audio.AudioMixerSnapshot),typeof(UnityEngine.Object));
	}
}
