using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Gradient : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Gradient o;
			o=new UnityEngine.Gradient();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Evaluate(IntPtr l) {
		try {
			UnityEngine.Gradient self=(UnityEngine.Gradient)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.Evaluate(a1);
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
	static public int SetKeys(IntPtr l) {
		try {
			UnityEngine.Gradient self=(UnityEngine.Gradient)checkSelf(l);
			UnityEngine.GradientColorKey[] a1;
			checkArray(l,2,out a1);
			UnityEngine.GradientAlphaKey[] a2;
			checkArray(l,3,out a2);
			self.SetKeys(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colorKeys(IntPtr l) {
		try {
			UnityEngine.Gradient self=(UnityEngine.Gradient)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.colorKeys);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colorKeys(IntPtr l) {
		try {
			UnityEngine.Gradient self=(UnityEngine.Gradient)checkSelf(l);
			UnityEngine.GradientColorKey[] v;
			checkArray(l,2,out v);
			self.colorKeys=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_alphaKeys(IntPtr l) {
		try {
			UnityEngine.Gradient self=(UnityEngine.Gradient)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.alphaKeys);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_alphaKeys(IntPtr l) {
		try {
			UnityEngine.Gradient self=(UnityEngine.Gradient)checkSelf(l);
			UnityEngine.GradientAlphaKey[] v;
			checkArray(l,2,out v);
			self.alphaKeys=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mode(IntPtr l) {
		try {
			UnityEngine.Gradient self=(UnityEngine.Gradient)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mode(IntPtr l) {
		try {
			UnityEngine.Gradient self=(UnityEngine.Gradient)checkSelf(l);
			UnityEngine.GradientMode v;
			checkEnum(l,2,out v);
			self.mode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Gradient");
		addMember(l,Evaluate);
		addMember(l,SetKeys);
		addMember(l,"colorKeys",get_colorKeys,set_colorKeys,true);
		addMember(l,"alphaKeys",get_alphaKeys,set_alphaKeys,true);
		addMember(l,"mode",get_mode,set_mode,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Gradient));
	}
}
