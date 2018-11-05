using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Playables_PlayableBehaviour : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnGraphStart(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBehaviour self=(UnityEngine.Playables.PlayableBehaviour)checkSelf(l);
			UnityEngine.Playables.Playable a1;
			checkValueType(l,2,out a1);
			self.OnGraphStart(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnGraphStop(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBehaviour self=(UnityEngine.Playables.PlayableBehaviour)checkSelf(l);
			UnityEngine.Playables.Playable a1;
			checkValueType(l,2,out a1);
			self.OnGraphStop(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnPlayableCreate(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBehaviour self=(UnityEngine.Playables.PlayableBehaviour)checkSelf(l);
			UnityEngine.Playables.Playable a1;
			checkValueType(l,2,out a1);
			self.OnPlayableCreate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnPlayableDestroy(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBehaviour self=(UnityEngine.Playables.PlayableBehaviour)checkSelf(l);
			UnityEngine.Playables.Playable a1;
			checkValueType(l,2,out a1);
			self.OnPlayableDestroy(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBehaviourDelay(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBehaviour self=(UnityEngine.Playables.PlayableBehaviour)checkSelf(l);
			UnityEngine.Playables.Playable a1;
			checkValueType(l,2,out a1);
			UnityEngine.Playables.FrameData a2;
			checkValueType(l,3,out a2);
			self.OnBehaviourDelay(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBehaviourPlay(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBehaviour self=(UnityEngine.Playables.PlayableBehaviour)checkSelf(l);
			UnityEngine.Playables.Playable a1;
			checkValueType(l,2,out a1);
			UnityEngine.Playables.FrameData a2;
			checkValueType(l,3,out a2);
			self.OnBehaviourPlay(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnBehaviourPause(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBehaviour self=(UnityEngine.Playables.PlayableBehaviour)checkSelf(l);
			UnityEngine.Playables.Playable a1;
			checkValueType(l,2,out a1);
			UnityEngine.Playables.FrameData a2;
			checkValueType(l,3,out a2);
			self.OnBehaviourPause(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PrepareData(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBehaviour self=(UnityEngine.Playables.PlayableBehaviour)checkSelf(l);
			UnityEngine.Playables.Playable a1;
			checkValueType(l,2,out a1);
			UnityEngine.Playables.FrameData a2;
			checkValueType(l,3,out a2);
			self.PrepareData(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PrepareFrame(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBehaviour self=(UnityEngine.Playables.PlayableBehaviour)checkSelf(l);
			UnityEngine.Playables.Playable a1;
			checkValueType(l,2,out a1);
			UnityEngine.Playables.FrameData a2;
			checkValueType(l,3,out a2);
			self.PrepareFrame(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ProcessFrame(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBehaviour self=(UnityEngine.Playables.PlayableBehaviour)checkSelf(l);
			UnityEngine.Playables.Playable a1;
			checkValueType(l,2,out a1);
			UnityEngine.Playables.FrameData a2;
			checkValueType(l,3,out a2);
			System.Object a3;
			checkType(l,4,out a3);
			self.ProcessFrame(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Clone(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableBehaviour self=(UnityEngine.Playables.PlayableBehaviour)checkSelf(l);
			var ret=self.Clone();
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
		getTypeTable(l,"UnityEngine.Playables.PlayableBehaviour");
		addMember(l,OnGraphStart);
		addMember(l,OnGraphStop);
		addMember(l,OnPlayableCreate);
		addMember(l,OnPlayableDestroy);
		addMember(l,OnBehaviourDelay);
		addMember(l,OnBehaviourPlay);
		addMember(l,OnBehaviourPause);
		addMember(l,PrepareData);
		addMember(l,PrepareFrame);
		addMember(l,ProcessFrame);
		addMember(l,Clone);
		createTypeMetatable(l,null, typeof(UnityEngine.Playables.PlayableBehaviour));
	}
}
