using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Audio_AudioMixerGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_audioMixer(IntPtr l) {
		try {
			UnityEngine.Audio.AudioMixerGroup self=(UnityEngine.Audio.AudioMixerGroup)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.audioMixer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Audio.AudioMixerGroup");
		addMember(l,"audioMixer",get_audioMixer,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Audio.AudioMixerGroup),typeof(UnityEngine.Object));
	}
}
