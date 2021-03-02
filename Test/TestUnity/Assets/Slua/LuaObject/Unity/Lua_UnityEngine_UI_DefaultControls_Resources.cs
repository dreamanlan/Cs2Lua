﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_DefaultControls_Resources : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources o;
			o=new UnityEngine.UI.DefaultControls.Resources();
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
	static public int get_standard(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.standard);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_standard(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.standard=v;
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
	static public int get_background(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.background);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_background(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.background=v;
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
	static public int get_inputField(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.inputField);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_inputField(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.inputField=v;
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
	static public int get_knob(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.knob);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_knob(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.knob=v;
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
	static public int get_checkmark(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.checkmark);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_checkmark(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.checkmark=v;
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
	static public int get_dropdown(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.dropdown);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_dropdown(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.dropdown=v;
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
	static public int get_mask(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.mask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mask(IntPtr l) {
		try {
			UnityEngine.UI.DefaultControls.Resources self;
			checkValueType(l,1,out self);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.mask=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.DefaultControls.Resources");
		addMember(l,ctor_s);
		addMember(l,"standard",get_standard,set_standard,true);
		addMember(l,"background",get_background,set_background,true);
		addMember(l,"inputField",get_inputField,set_inputField,true);
		addMember(l,"knob",get_knob,set_knob,true);
		addMember(l,"checkmark",get_checkmark,set_checkmark,true);
		addMember(l,"dropdown",get_dropdown,set_dropdown,true);
		addMember(l,"mask",get_mask,set_mask,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.DefaultControls.Resources),typeof(System.ValueType));
	}
}
