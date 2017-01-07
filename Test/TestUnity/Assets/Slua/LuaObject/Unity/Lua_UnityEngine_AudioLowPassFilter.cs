using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioLowPassFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AudioLowPassFilter o;
			o=new UnityEngine.AudioLowPassFilter();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cutoffFrequency(IntPtr l) {
		try {
			UnityEngine.AudioLowPassFilter self=(UnityEngine.AudioLowPassFilter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cutoffFrequency);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cutoffFrequency(IntPtr l) {
		try {
			UnityEngine.AudioLowPassFilter self=(UnityEngine.AudioLowPassFilter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.cutoffFrequency=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_customCutoffCurve(IntPtr l) {
		try {
			UnityEngine.AudioLowPassFilter self=(UnityEngine.AudioLowPassFilter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.customCutoffCurve);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_customCutoffCurve(IntPtr l) {
		try {
			UnityEngine.AudioLowPassFilter self=(UnityEngine.AudioLowPassFilter)checkSelf(l);
			UnityEngine.AnimationCurve v;
			checkType(l,2,out v);
			self.customCutoffCurve=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lowpassResonanceQ(IntPtr l) {
		try {
			UnityEngine.AudioLowPassFilter self=(UnityEngine.AudioLowPassFilter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lowpassResonanceQ);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lowpassResonanceQ(IntPtr l) {
		try {
			UnityEngine.AudioLowPassFilter self=(UnityEngine.AudioLowPassFilter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.lowpassResonanceQ=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioLowPassFilter");
		addMember(l,"cutoffFrequency",get_cutoffFrequency,set_cutoffFrequency,true);
		addMember(l,"customCutoffCurve",get_customCutoffCurve,set_customCutoffCurve,true);
		addMember(l,"lowpassResonanceQ",get_lowpassResonanceQ,set_lowpassResonanceQ,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioLowPassFilter),typeof(UnityEngine.Behaviour));
	}
}
