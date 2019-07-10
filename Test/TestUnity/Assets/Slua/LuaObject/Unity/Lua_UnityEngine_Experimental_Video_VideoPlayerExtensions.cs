using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Video_VideoPlayerExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetAudioSampleProvider_s(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer a1;
			checkType(l,1,out a1);
			System.UInt16 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Experimental.Video.VideoPlayerExtensions.GetAudioSampleProvider(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Video.VideoPlayerExtensions");
		addMember(l,GetAudioSampleProvider_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Video.VideoPlayerExtensions));
	}
}
