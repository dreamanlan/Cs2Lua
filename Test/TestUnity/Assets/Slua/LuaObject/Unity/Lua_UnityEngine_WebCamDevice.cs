using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_WebCamDevice : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.WebCamDevice o;
			o=new UnityEngine.WebCamDevice();
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
	static public int get_name(IntPtr l) {
		try {
			UnityEngine.WebCamDevice self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isFrontFacing(IntPtr l) {
		try {
			UnityEngine.WebCamDevice self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.isFrontFacing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WebCamDevice");
		addMember(l,"name",get_name,null,true);
		addMember(l,"isFrontFacing",get_isFrontFacing,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WebCamDevice),typeof(System.ValueType));
	}
}
