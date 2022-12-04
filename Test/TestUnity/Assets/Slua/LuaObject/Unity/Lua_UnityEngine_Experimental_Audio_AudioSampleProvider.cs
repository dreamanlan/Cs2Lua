using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Audio_AudioSampleProvider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Dispose(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetSampleFramesAvailableNativeHandler(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesEventNativeFunction a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			System.IntPtr a2;
			checkType(l,3,out a2);
			self.SetSampleFramesAvailableNativeHandler(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearSampleFramesAvailableNativeHandler(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			self.ClearSampleFramesAvailableNativeHandler();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetSampleFramesOverflowNativeHandler(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesEventNativeFunction a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			System.IntPtr a2;
			checkType(l,3,out a2);
			self.SetSampleFramesOverflowNativeHandler(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearSampleFramesOverflowNativeHandler(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			self.ClearSampleFramesOverflowNativeHandler();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_id(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.id);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_trackIndex(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.trackIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_owner(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.owner);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_valid(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.valid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_channelCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.channelCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sampleRate(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sampleRate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_maxSampleFrameCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxSampleFrameCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_availableSampleFrameCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.availableSampleFrameCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_freeSampleFrameCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.freeSampleFrameCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_freeSampleFrameCountLowThreshold(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.freeSampleFrameCountLowThreshold);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_freeSampleFrameCountLowThreshold(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			System.UInt32 v;
			checkType(l,2,out v);
			self.freeSampleFrameCountLowThreshold=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableSampleFramesAvailableEvents(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enableSampleFramesAvailableEvents);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableSampleFramesAvailableEvents(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enableSampleFramesAvailableEvents=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableSilencePadding(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enableSilencePadding);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableSilencePadding(IntPtr l) {
		try {
			UnityEngine.Experimental.Audio.AudioSampleProvider self=(UnityEngine.Experimental.Audio.AudioSampleProvider)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enableSilencePadding=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Audio.AudioSampleProvider");
		addMember(l,Dispose);
		addMember(l,SetSampleFramesAvailableNativeHandler);
		addMember(l,ClearSampleFramesAvailableNativeHandler);
		addMember(l,SetSampleFramesOverflowNativeHandler);
		addMember(l,ClearSampleFramesOverflowNativeHandler);
		addMember(l,"id",get_id,null,true);
		addMember(l,"trackIndex",get_trackIndex,null,true);
		addMember(l,"owner",get_owner,null,true);
		addMember(l,"valid",get_valid,null,true);
		addMember(l,"channelCount",get_channelCount,null,true);
		addMember(l,"sampleRate",get_sampleRate,null,true);
		addMember(l,"maxSampleFrameCount",get_maxSampleFrameCount,null,true);
		addMember(l,"availableSampleFrameCount",get_availableSampleFrameCount,null,true);
		addMember(l,"freeSampleFrameCount",get_freeSampleFrameCount,null,true);
		addMember(l,"freeSampleFrameCountLowThreshold",get_freeSampleFrameCountLowThreshold,set_freeSampleFrameCountLowThreshold,true);
		addMember(l,"enableSampleFramesAvailableEvents",get_enableSampleFramesAvailableEvents,set_enableSampleFramesAvailableEvents,true);
		addMember(l,"enableSilencePadding",get_enableSilencePadding,set_enableSilencePadding,true);
		addMember(l,"consumeSampleFramesNativeFunction",null,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Audio.AudioSampleProvider));
	}
}
