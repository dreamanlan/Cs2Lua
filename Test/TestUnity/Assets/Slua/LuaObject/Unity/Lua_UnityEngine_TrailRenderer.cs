using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_TrailRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.TrailRenderer o;
			o=new UnityEngine.TrailRenderer();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try {
			UnityEngine.TrailRenderer self=(UnityEngine.TrailRenderer)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		try {
			UnityEngine.TrailRenderer self=(UnityEngine.TrailRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.time);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		try {
			UnityEngine.TrailRenderer self=(UnityEngine.TrailRenderer)checkSelf(l);
			float v;
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
	static public int get_startWidth(IntPtr l) {
		try {
			UnityEngine.TrailRenderer self=(UnityEngine.TrailRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_startWidth(IntPtr l) {
		try {
			UnityEngine.TrailRenderer self=(UnityEngine.TrailRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.startWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_endWidth(IntPtr l) {
		try {
			UnityEngine.TrailRenderer self=(UnityEngine.TrailRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.endWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_endWidth(IntPtr l) {
		try {
			UnityEngine.TrailRenderer self=(UnityEngine.TrailRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.endWidth=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autodestruct(IntPtr l) {
		try {
			UnityEngine.TrailRenderer self=(UnityEngine.TrailRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autodestruct);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autodestruct(IntPtr l) {
		try {
			UnityEngine.TrailRenderer self=(UnityEngine.TrailRenderer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autodestruct=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.TrailRenderer");
		addMember(l,Clear);
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"startWidth",get_startWidth,set_startWidth,true);
		addMember(l,"endWidth",get_endWidth,set_endWidth,true);
		addMember(l,"autodestruct",get_autodestruct,set_autodestruct,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.TrailRenderer),typeof(UnityEngine.Renderer));
	}
}
