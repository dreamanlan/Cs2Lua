using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_ShaderKeyword : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeyword o;
			System.String a1;
			checkType(l,2,out a1);
			o=new UnityEngine.Rendering.ShaderKeyword(a1);
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
	static public int IsValid(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeyword self=(UnityEngine.Rendering.ShaderKeyword)checkSelf(l);
			var ret=self.IsValid();
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
	static public int GetKeywordType(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeyword self=(UnityEngine.Rendering.ShaderKeyword)checkSelf(l);
			var ret=self.GetKeywordType();
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetKeywordName(IntPtr l) {
		try {
			UnityEngine.Rendering.ShaderKeyword self=(UnityEngine.Rendering.ShaderKeyword)checkSelf(l);
			var ret=self.GetKeywordName();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.ShaderKeyword");
		addMember(l,IsValid);
		addMember(l,GetKeywordType);
		addMember(l,GetKeywordName);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.ShaderKeyword));
	}
}
