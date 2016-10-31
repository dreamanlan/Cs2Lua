using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UICharInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.UICharInfo o;
			o=new UnityEngine.UICharInfo();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cursorPos(IntPtr l) {
		try {
			UnityEngine.UICharInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.cursorPos);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cursorPos(IntPtr l) {
		try {
			UnityEngine.UICharInfo self;
			checkValueType(l,1,out self);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.cursorPos=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_charWidth(IntPtr l) {
		try {
			UnityEngine.UICharInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.charWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_charWidth(IntPtr l) {
		try {
			UnityEngine.UICharInfo self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.charWidth=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UICharInfo");
		addMember(l,"cursorPos",get_cursorPos,set_cursorPos,true);
		addMember(l,"charWidth",get_charWidth,set_charWidth,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UICharInfo),typeof(System.ValueType));
	}
}
