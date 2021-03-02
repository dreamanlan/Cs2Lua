using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_SpriteState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.UI.SpriteState o;
			o=new UnityEngine.UI.SpriteState();
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
	static public int Equals__SpriteState(IntPtr l) {
		try {
			UnityEngine.UI.SpriteState self;
			checkValueType(l,1,out self);
			UnityEngine.UI.SpriteState a1;
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.UI.SpriteState self;
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
	static public int get_highlightedSprite(IntPtr l) {
		try {
			UnityEngine.UI.SpriteState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.highlightedSprite);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_highlightedSprite(IntPtr l) {
		try {
			UnityEngine.UI.SpriteState self;
			checkValueType(l,1,out self);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.highlightedSprite=v;
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
	static public int get_pressedSprite(IntPtr l) {
		try {
			UnityEngine.UI.SpriteState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.pressedSprite);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pressedSprite(IntPtr l) {
		try {
			UnityEngine.UI.SpriteState self;
			checkValueType(l,1,out self);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.pressedSprite=v;
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
	static public int get_disabledSprite(IntPtr l) {
		try {
			UnityEngine.UI.SpriteState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.disabledSprite);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_disabledSprite(IntPtr l) {
		try {
			UnityEngine.UI.SpriteState self;
			checkValueType(l,1,out self);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.disabledSprite=v;
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
		getTypeTable(l,"UnityEngine.UI.SpriteState");
		addMember(l,ctor_s);
		addMember(l,Equals__SpriteState);
		addMember(l,Equals__Object);
		addMember(l,"highlightedSprite",get_highlightedSprite,set_highlightedSprite,true);
		addMember(l,"pressedSprite",get_pressedSprite,set_pressedSprite,true);
		addMember(l,"disabledSprite",get_disabledSprite,set_disabledSprite,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.SpriteState),typeof(System.ValueType));
	}
}
