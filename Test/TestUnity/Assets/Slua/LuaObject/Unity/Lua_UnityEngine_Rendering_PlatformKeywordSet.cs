using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_PlatformKeywordSet : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Rendering.PlatformKeywordSet o;
			o=new UnityEngine.Rendering.PlatformKeywordSet();
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
	static public int IsEnabled(IntPtr l) {
		try {
			UnityEngine.Rendering.PlatformKeywordSet self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BuiltinShaderDefine a1;
			checkEnum(l,2,out a1);
			var ret=self.IsEnabled(a1);
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
	static public int Enable(IntPtr l) {
		try {
			UnityEngine.Rendering.PlatformKeywordSet self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BuiltinShaderDefine a1;
			checkEnum(l,2,out a1);
			self.Enable(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Disable(IntPtr l) {
		try {
			UnityEngine.Rendering.PlatformKeywordSet self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.BuiltinShaderDefine a1;
			checkEnum(l,2,out a1);
			self.Disable(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.PlatformKeywordSet");
		addMember(l,IsEnabled);
		addMember(l,Enable);
		addMember(l,Disable);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.PlatformKeywordSet),typeof(System.ValueType));
	}
}
