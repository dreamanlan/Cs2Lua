using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Video_VideoPlayer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Prepare(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			self.Prepare();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Play(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			self.Play();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Pause(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			self.Pause();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Stop(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			self.Stop();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StepForward(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			self.StepForward();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetAudioLanguageCode(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			var ret=self.GetAudioLanguageCode(a1);
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
	static public int GetAudioChannelCount(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
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
	static public int EnableAudioTrack(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.EnableAudioTrack(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsAudioTrackEnabled(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			var ret=self.IsAudioTrackEnabled(a1);
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
	static public int GetDirectAudioVolume(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			var ret=self.GetDirectAudioVolume(a1);
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
	static public int SetDirectAudioVolume(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetDirectAudioVolume(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetDirectAudioMute(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			var ret=self.GetDirectAudioMute(a1);
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
	static public int SetDirectAudioMute(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetDirectAudioMute(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTargetAudioSource(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			var ret=self.GetTargetAudioSource(a1);
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
	static public int SetTargetAudioSource(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			UnityEngine.AudioSource a2;
			checkType(l,3,out a2);
			self.SetTargetAudioSource(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_source(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.source);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_source(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			UnityEngine.Video.VideoSource v;
			checkEnum(l,2,out v);
			self.source=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_url(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.url);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_url(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.url=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_clip(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.clip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_clip(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			UnityEngine.Video.VideoClip v;
			checkType(l,2,out v);
			self.clip=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_renderMode(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.renderMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_renderMode(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			UnityEngine.Video.VideoRenderMode v;
			checkEnum(l,2,out v);
			self.renderMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_targetCamera(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.targetCamera);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_targetCamera(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			UnityEngine.Camera v;
			checkType(l,2,out v);
			self.targetCamera=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_targetTexture(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.targetTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_targetTexture(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			UnityEngine.RenderTexture v;
			checkType(l,2,out v);
			self.targetTexture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_targetMaterialRenderer(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.targetMaterialRenderer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_targetMaterialRenderer(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			UnityEngine.Renderer v;
			checkType(l,2,out v);
			self.targetMaterialRenderer=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_targetMaterialProperty(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.targetMaterialProperty);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_targetMaterialProperty(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.targetMaterialProperty=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_aspectRatio(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.aspectRatio);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_aspectRatio(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			UnityEngine.Video.VideoAspectRatio v;
			checkEnum(l,2,out v);
			self.aspectRatio=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_targetCameraAlpha(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.targetCameraAlpha);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_targetCameraAlpha(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.targetCameraAlpha=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_texture(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.texture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isPrepared(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isPrepared);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_waitForFirstFrame(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.waitForFirstFrame);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_waitForFirstFrame(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.waitForFirstFrame=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_playOnAwake(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.playOnAwake);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_playOnAwake(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.playOnAwake=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isPlaying(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isPlaying);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_canSetTime(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.canSetTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_time(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.time);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_time(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			double v;
			checkType(l,2,out v);
			self.time=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_frame(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.frame);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_frame(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.frame=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_canStep(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.canStep);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_canSetPlaybackSpeed(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.canSetPlaybackSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_playbackSpeed(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.playbackSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_playbackSpeed(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.playbackSpeed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isLooping(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isLooping);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isLooping(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.isLooping=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_canSetTimeSource(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.canSetTimeSource);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_timeSource(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.timeSource);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_timeSource(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			UnityEngine.Video.VideoTimeSource v;
			checkEnum(l,2,out v);
			self.timeSource=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_canSetSkipOnDrop(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.canSetSkipOnDrop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_skipOnDrop(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.skipOnDrop);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_skipOnDrop(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.skipOnDrop=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_frameCount(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
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
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
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
	static public int get_audioTrackCount(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.audioTrackCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_controlledAudioTrackMaxCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Video.VideoPlayer.controlledAudioTrackMaxCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_controlledAudioTrackCount(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.controlledAudioTrackCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_controlledAudioTrackCount(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			System.UInt16 v;
			checkType(l,2,out v);
			self.controlledAudioTrackCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_audioOutputMode(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.audioOutputMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_audioOutputMode(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			UnityEngine.Video.VideoAudioOutputMode v;
			checkEnum(l,2,out v);
			self.audioOutputMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_canSetDirectAudioVolume(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.canSetDirectAudioVolume);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sendFrameReadyEvents(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sendFrameReadyEvents);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sendFrameReadyEvents(IntPtr l) {
		try {
			UnityEngine.Video.VideoPlayer self=(UnityEngine.Video.VideoPlayer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.sendFrameReadyEvents=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Video.VideoPlayer");
		addMember(l,Prepare);
		addMember(l,Play);
		addMember(l,Pause);
		addMember(l,Stop);
		addMember(l,StepForward);
		addMember(l,GetAudioLanguageCode);
		addMember(l,GetAudioChannelCount);
		addMember(l,EnableAudioTrack);
		addMember(l,IsAudioTrackEnabled);
		addMember(l,GetDirectAudioVolume);
		addMember(l,SetDirectAudioVolume);
		addMember(l,GetDirectAudioMute);
		addMember(l,SetDirectAudioMute);
		addMember(l,GetTargetAudioSource);
		addMember(l,SetTargetAudioSource);
		addMember(l,"source",get_source,set_source,true);
		addMember(l,"url",get_url,set_url,true);
		addMember(l,"clip",get_clip,set_clip,true);
		addMember(l,"renderMode",get_renderMode,set_renderMode,true);
		addMember(l,"targetCamera",get_targetCamera,set_targetCamera,true);
		addMember(l,"targetTexture",get_targetTexture,set_targetTexture,true);
		addMember(l,"targetMaterialRenderer",get_targetMaterialRenderer,set_targetMaterialRenderer,true);
		addMember(l,"targetMaterialProperty",get_targetMaterialProperty,set_targetMaterialProperty,true);
		addMember(l,"aspectRatio",get_aspectRatio,set_aspectRatio,true);
		addMember(l,"targetCameraAlpha",get_targetCameraAlpha,set_targetCameraAlpha,true);
		addMember(l,"texture",get_texture,null,true);
		addMember(l,"isPrepared",get_isPrepared,null,true);
		addMember(l,"waitForFirstFrame",get_waitForFirstFrame,set_waitForFirstFrame,true);
		addMember(l,"playOnAwake",get_playOnAwake,set_playOnAwake,true);
		addMember(l,"isPlaying",get_isPlaying,null,true);
		addMember(l,"canSetTime",get_canSetTime,null,true);
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"frame",get_frame,set_frame,true);
		addMember(l,"canStep",get_canStep,null,true);
		addMember(l,"canSetPlaybackSpeed",get_canSetPlaybackSpeed,null,true);
		addMember(l,"playbackSpeed",get_playbackSpeed,set_playbackSpeed,true);
		addMember(l,"isLooping",get_isLooping,set_isLooping,true);
		addMember(l,"canSetTimeSource",get_canSetTimeSource,null,true);
		addMember(l,"timeSource",get_timeSource,set_timeSource,true);
		addMember(l,"canSetSkipOnDrop",get_canSetSkipOnDrop,null,true);
		addMember(l,"skipOnDrop",get_skipOnDrop,set_skipOnDrop,true);
		addMember(l,"frameCount",get_frameCount,null,true);
		addMember(l,"frameRate",get_frameRate,null,true);
		addMember(l,"audioTrackCount",get_audioTrackCount,null,true);
		addMember(l,"controlledAudioTrackMaxCount",get_controlledAudioTrackMaxCount,null,false);
		addMember(l,"controlledAudioTrackCount",get_controlledAudioTrackCount,set_controlledAudioTrackCount,true);
		addMember(l,"audioOutputMode",get_audioOutputMode,set_audioOutputMode,true);
		addMember(l,"canSetDirectAudioVolume",get_canSetDirectAudioVolume,null,true);
		addMember(l,"sendFrameReadyEvents",get_sendFrameReadyEvents,set_sendFrameReadyEvents,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Video.VideoPlayer),typeof(UnityEngine.Behaviour));
	}
}
