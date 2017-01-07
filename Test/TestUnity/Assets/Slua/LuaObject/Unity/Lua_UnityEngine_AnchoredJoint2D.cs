using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnchoredJoint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AnchoredJoint2D o;
			o=new UnityEngine.AnchoredJoint2D();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_anchor(IntPtr l) {
		try {
			UnityEngine.AnchoredJoint2D self=(UnityEngine.AnchoredJoint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.anchor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_anchor(IntPtr l) {
		try {
			UnityEngine.AnchoredJoint2D self=(UnityEngine.AnchoredJoint2D)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.anchor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_connectedAnchor(IntPtr l) {
		try {
			UnityEngine.AnchoredJoint2D self=(UnityEngine.AnchoredJoint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.connectedAnchor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_connectedAnchor(IntPtr l) {
		try {
			UnityEngine.AnchoredJoint2D self=(UnityEngine.AnchoredJoint2D)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.connectedAnchor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoConfigureConnectedAnchor(IntPtr l) {
		try {
			UnityEngine.AnchoredJoint2D self=(UnityEngine.AnchoredJoint2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoConfigureConnectedAnchor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoConfigureConnectedAnchor(IntPtr l) {
		try {
			UnityEngine.AnchoredJoint2D self=(UnityEngine.AnchoredJoint2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoConfigureConnectedAnchor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnchoredJoint2D");
		addMember(l,"anchor",get_anchor,set_anchor,true);
		addMember(l,"connectedAnchor",get_connectedAnchor,set_connectedAnchor,true);
		addMember(l,"autoConfigureConnectedAnchor",get_autoConfigureConnectedAnchor,set_autoConfigureConnectedAnchor,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnchoredJoint2D),typeof(UnityEngine.Joint2D));
	}
}
