﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_ColorBlock : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock o;
			o=new UnityEngine.UI.ColorBlock();
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
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
	static public int Equals__ColorBlock(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			UnityEngine.UI.ColorBlock a1;
			checkValueType(l,2,out a1);
			var ret=self.Equals(a1);
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
	static public int op_Equality_s(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock a1;
			checkValueType(l,1,out a1);
			UnityEngine.UI.ColorBlock a2;
			checkValueType(l,2,out a2);
			var ret=(a1==a2);
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
	static public int op_Inequality_s(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock a1;
			checkValueType(l,1,out a1);
			UnityEngine.UI.ColorBlock a2;
			checkValueType(l,2,out a2);
			var ret=(a1!=a2);
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
	static public int get_normalColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.normalColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_normalColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.normalColor=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_highlightedColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.highlightedColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_highlightedColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.highlightedColor=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pressedColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.pressedColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pressedColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.pressedColor=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_disabledColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.disabledColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_disabledColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.disabledColor=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_colorMultiplier(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.colorMultiplier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_colorMultiplier(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.colorMultiplier=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fadeDuration(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.fadeDuration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fadeDuration(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.fadeDuration=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultColorBlock(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.UI.ColorBlock.defaultColorBlock);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ColorBlock");
		addMember(l,ctor_s);
		addMember(l,Equals__Object);
		addMember(l,Equals__ColorBlock);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"normalColor",get_normalColor,set_normalColor,true);
		addMember(l,"highlightedColor",get_highlightedColor,set_highlightedColor,true);
		addMember(l,"pressedColor",get_pressedColor,set_pressedColor,true);
		addMember(l,"disabledColor",get_disabledColor,set_disabledColor,true);
		addMember(l,"colorMultiplier",get_colorMultiplier,set_colorMultiplier,true);
		addMember(l,"fadeDuration",get_fadeDuration,set_fadeDuration,true);
		addMember(l,"defaultColorBlock",get_defaultColorBlock,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.ColorBlock),typeof(System.ValueType));
	}
}
