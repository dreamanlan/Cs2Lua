using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CloudStreaming : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PostMessage_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.CloudStreaming.PostMessage(a1);
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
	static public int PeekMessage_s(IntPtr l) {
		try {
			var ret=UnityEngine.CloudStreaming.PeekMessage();
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
	static public int PeekRemoteAudioCapture_s(IntPtr l) {
		try {
			var ret=UnityEngine.CloudStreaming.PeekRemoteAudioCapture();
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
	static public int PeekRemoteAudioCapture__O_Single__Int32_s(IntPtr l) {
		try {
			System.Single[] a1;
			checkArray(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.CloudStreaming.PeekRemoteAudioCapture(a1,a2);
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
	static public int EnableMicRecording_s(IntPtr l) {
		try {
			var ret=UnityEngine.CloudStreaming.EnableMicRecording();
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
	static public int DisableMicRecording_s(IntPtr l) {
		try {
			var ret=UnityEngine.CloudStreaming.DisableMicRecording();
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
		getTypeTable(l,"UnityEngine.CloudStreaming");
		addMember(l,PostMessage_s);
		addMember(l,PeekMessage_s);
		addMember(l,PeekRemoteAudioCapture_s);
		addMember(l,PeekRemoteAudioCapture__O_Single__Int32_s);
		addMember(l,EnableMicRecording_s);
		addMember(l,DisableMicRecording_s);
		createTypeMetatable(l,null, typeof(UnityEngine.CloudStreaming));
	}
}
