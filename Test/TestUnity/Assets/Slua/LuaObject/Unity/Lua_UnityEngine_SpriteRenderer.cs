using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SpriteRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.SpriteRenderer o;
			o=new UnityEngine.SpriteRenderer();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sprite(IntPtr l) {
		try {
			UnityEngine.SpriteRenderer self=(UnityEngine.SpriteRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sprite);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sprite(IntPtr l) {
		try {
			UnityEngine.SpriteRenderer self=(UnityEngine.SpriteRenderer)checkSelf(l);
			UnityEngine.Sprite v;
			checkType(l,2,out v);
			self.sprite=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		try {
			UnityEngine.SpriteRenderer self=(UnityEngine.SpriteRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.color);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		try {
			UnityEngine.SpriteRenderer self=(UnityEngine.SpriteRenderer)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.color=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flipX(IntPtr l) {
		try {
			UnityEngine.SpriteRenderer self=(UnityEngine.SpriteRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.flipX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flipX(IntPtr l) {
		try {
			UnityEngine.SpriteRenderer self=(UnityEngine.SpriteRenderer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.flipX=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_flipY(IntPtr l) {
		try {
			UnityEngine.SpriteRenderer self=(UnityEngine.SpriteRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.flipY);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_flipY(IntPtr l) {
		try {
			UnityEngine.SpriteRenderer self=(UnityEngine.SpriteRenderer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.flipY=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SpriteRenderer");
		addMember(l,"sprite",get_sprite,set_sprite,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"flipX",get_flipX,set_flipX,true);
		addMember(l,"flipY",get_flipY,set_flipY,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SpriteRenderer),typeof(UnityEngine.Renderer));
	}
}
