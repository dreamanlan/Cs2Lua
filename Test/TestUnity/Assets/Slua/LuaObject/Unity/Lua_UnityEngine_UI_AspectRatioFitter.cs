using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_AspectRatioFitter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetLayoutHorizontal(IntPtr l) {
		try {
			UnityEngine.UI.AspectRatioFitter self=(UnityEngine.UI.AspectRatioFitter)checkSelf(l);
			self.SetLayoutHorizontal();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetLayoutVertical(IntPtr l) {
		try {
			UnityEngine.UI.AspectRatioFitter self=(UnityEngine.UI.AspectRatioFitter)checkSelf(l);
			self.SetLayoutVertical();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_aspectMode(IntPtr l) {
		try {
			UnityEngine.UI.AspectRatioFitter self=(UnityEngine.UI.AspectRatioFitter)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.aspectMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_aspectMode(IntPtr l) {
		try {
			UnityEngine.UI.AspectRatioFitter self=(UnityEngine.UI.AspectRatioFitter)checkSelf(l);
			UnityEngine.UI.AspectRatioFitter.AspectMode v;
			checkEnum(l,2,out v);
			self.aspectMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_aspectRatio(IntPtr l) {
		try {
			UnityEngine.UI.AspectRatioFitter self=(UnityEngine.UI.AspectRatioFitter)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.aspectRatio);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_aspectRatio(IntPtr l) {
		try {
			UnityEngine.UI.AspectRatioFitter self=(UnityEngine.UI.AspectRatioFitter)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.aspectRatio=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.AspectRatioFitter");
		addMember(l,SetLayoutHorizontal);
		addMember(l,SetLayoutVertical);
		addMember(l,"aspectMode",get_aspectMode,set_aspectMode,true);
		addMember(l,"aspectRatio",get_aspectRatio,set_aspectRatio,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.AspectRatioFitter),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
