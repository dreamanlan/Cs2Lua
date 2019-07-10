using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Video_VideoClip : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetAudioChannelCount(IntPtr l) {
		try {
			UnityEngine.Video.VideoClip self=(UnityEngine.Video.VideoClip)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			var ret=self.GetAudioChannelCount(a1);
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
	static public int GetAudioSampleRate(IntPtr l) {
		try {
			UnityEngine.Video.VideoClip self=(UnityEngine.Video.VideoClip)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			var ret=self.GetAudioSampleRate(a1);
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
	static public int GetAudioLanguage(IntPtr l) {
		try {
			UnityEngine.Video.VideoClip self=(UnityEngine.Video.VideoClip)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			var ret=self.GetAudioLanguage(a1);
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
	static public int get_originalPath(IntPtr l) {
		try {
			UnityEngine.Video.VideoClip self=(UnityEngine.Video.VideoClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.originalPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_frameCount(IntPtr l) {
		try {
			UnityEngine.Video.VideoClip self=(UnityEngine.Video.VideoClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frameCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_frameRate(IntPtr l) {
		try {
			UnityEngine.Video.VideoClip self=(UnityEngine.Video.VideoClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frameRate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_length(IntPtr l) {
		try {
			UnityEngine.Video.VideoClip self=(UnityEngine.Video.VideoClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.length);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_width(IntPtr l) {
		try {
			UnityEngine.Video.VideoClip self=(UnityEngine.Video.VideoClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			UnityEngine.Video.VideoClip self=(UnityEngine.Video.VideoClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pixelAspectRatioNumerator(IntPtr l) {
		try {
			UnityEngine.Video.VideoClip self=(UnityEngine.Video.VideoClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pixelAspectRatioNumerator);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pixelAspectRatioDenominator(IntPtr l) {
		try {
			UnityEngine.Video.VideoClip self=(UnityEngine.Video.VideoClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pixelAspectRatioDenominator);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_audioTrackCount(IntPtr l) {
		try {
			UnityEngine.Video.VideoClip self=(UnityEngine.Video.VideoClip)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.audioTrackCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Video.VideoClip");
		addMember(l,GetAudioChannelCount);
		addMember(l,GetAudioSampleRate);
		addMember(l,GetAudioLanguage);
		addMember(l,"originalPath",get_originalPath,null,true);
		addMember(l,"frameCount",get_frameCount,null,true);
		addMember(l,"frameRate",get_frameRate,null,true);
		addMember(l,"length",get_length,null,true);
		addMember(l,"width",get_width,null,true);
		addMember(l,"height",get_height,null,true);
		addMember(l,"pixelAspectRatioNumerator",get_pixelAspectRatioNumerator,null,true);
		addMember(l,"pixelAspectRatioDenominator",get_pixelAspectRatioDenominator,null,true);
		addMember(l,"audioTrackCount",get_audioTrackCount,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Video.VideoClip),typeof(UnityEngine.Object));
	}
}
