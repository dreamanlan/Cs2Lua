using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LineRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.LineRenderer o;
			o=new UnityEngine.LineRenderer();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetWidth(IntPtr l) {
		try {
			UnityEngine.LineRenderer self=(UnityEngine.LineRenderer)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetWidth(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetColors(IntPtr l) {
		try {
			UnityEngine.LineRenderer self=(UnityEngine.LineRenderer)checkSelf(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			UnityEngine.Color a2;
			checkType(l,3,out a2);
			self.SetColors(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetVertexCount(IntPtr l) {
		try {
			UnityEngine.LineRenderer self=(UnityEngine.LineRenderer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.SetVertexCount(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPosition(IntPtr l) {
		try {
			UnityEngine.LineRenderer self=(UnityEngine.LineRenderer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.SetPosition(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPositions(IntPtr l) {
		try {
			UnityEngine.LineRenderer self=(UnityEngine.LineRenderer)checkSelf(l);
			UnityEngine.Vector3[] a1;
			checkArray(l,2,out a1);
			self.SetPositions(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useWorldSpace(IntPtr l) {
		try {
			UnityEngine.LineRenderer self=(UnityEngine.LineRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useWorldSpace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useWorldSpace(IntPtr l) {
		try {
			UnityEngine.LineRenderer self=(UnityEngine.LineRenderer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useWorldSpace=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LineRenderer");
		addMember(l,SetWidth);
		addMember(l,SetColors);
		addMember(l,SetVertexCount);
		addMember(l,SetPosition);
		addMember(l,SetPositions);
		addMember(l,"useWorldSpace",get_useWorldSpace,set_useWorldSpace,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LineRenderer),typeof(UnityEngine.Renderer));
	}
}
