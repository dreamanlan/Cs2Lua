using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_RectOffset : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.RectOffset o;
			o=new UnityEngine.RectOffset();
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
	static public int ctor__Int32__Int32__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.RectOffset o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			o=new UnityEngine.RectOffset(a1,a2,a3,a4);
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
	static new public int ToString(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			var ret=self.ToString();
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
	static public int ToString__String(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.ToString(a1);
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
	static public int ToString__String__IFormatProvider(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.IFormatProvider a2;
			checkType(l,3,out a2);
			var ret=self.ToString(a1,a2);
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
	static public int Add(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			var ret=self.Add(a1);
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
	static public int Remove(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			var ret=self.Remove(a1);
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
	static public int get_left(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.left);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_left(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.left=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_right(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.right);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_right(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.right=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_top(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.top);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_top(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.top=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bottom(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bottom);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bottom(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.bottom=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_horizontal(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.horizontal);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_vertical(IntPtr l) {
		try {
			UnityEngine.RectOffset self=(UnityEngine.RectOffset)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vertical);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RectOffset");
		addMember(l,ctor_s);
		addMember(l,ctor__Int32__Int32__Int32__Int32_s);
		addMember(l,ToString);
		addMember(l,ToString__String);
		addMember(l,ToString__String__IFormatProvider);
		addMember(l,Add);
		addMember(l,Remove);
		addMember(l,"left",get_left,set_left,true);
		addMember(l,"right",get_right,set_right,true);
		addMember(l,"top",get_top,set_top,true);
		addMember(l,"bottom",get_bottom,set_bottom,true);
		addMember(l,"horizontal",get_horizontal,null,true);
		addMember(l,"vertical",get_vertical,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.RectOffset));
	}
}
