using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioDistortionFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AudioDistortionFilter o;
			o=new UnityEngine.AudioDistortionFilter();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distortionLevel(IntPtr l) {
		try {
			UnityEngine.AudioDistortionFilter self=(UnityEngine.AudioDistortionFilter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.distortionLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distortionLevel(IntPtr l) {
		try {
			UnityEngine.AudioDistortionFilter self=(UnityEngine.AudioDistortionFilter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.distortionLevel=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioDistortionFilter");
		addMember(l,"distortionLevel",get_distortionLevel,set_distortionLevel,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioDistortionFilter),typeof(UnityEngine.Behaviour));
	}
}
