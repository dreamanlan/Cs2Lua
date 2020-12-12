using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Font : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Font o;
			o=new UnityEngine.Font();
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
	static public int ctor__String_s(IntPtr l) {
		try {
			UnityEngine.Font o;
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Font(a1);
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
	static public int HasCharacter(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			var ret=self.HasCharacter(a1);
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
	static public int GetCharacterInfo__Char__O_CharacterInfo(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			UnityEngine.CharacterInfo a2;
			var ret=self.GetCharacterInfo(a1,out a2);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetCharacterInfo__Char__O_CharacterInfo__Int32(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			UnityEngine.CharacterInfo a2;
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.GetCharacterInfo(a1,out a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetCharacterInfo__Char__O_CharacterInfo__Int32__FontStyle(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			System.Char a1;
			checkType(l,2,out a1);
			UnityEngine.CharacterInfo a2;
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.FontStyle a4;
			checkEnum(l,5,out a4);
			var ret=self.GetCharacterInfo(a1,out a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestCharactersInTexture__String(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.RequestCharactersInTexture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestCharactersInTexture__String__Int32(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.RequestCharactersInTexture(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RequestCharactersInTexture__String__Int32__FontStyle(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.FontStyle a3;
			checkEnum(l,4,out a3);
			self.RequestCharactersInTexture(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateDynamicFontFromOSFont__String__Int32_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Font.CreateDynamicFontFromOSFont(a1,a2);
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
	static public int CreateDynamicFontFromOSFont__A_String__Int32_s(IntPtr l) {
		try {
			System.String[] a1;
			checkArray(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Font.CreateDynamicFontFromOSFont(a1,a2);
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
	static public int GetMaxVertsForString_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Font.GetMaxVertsForString(a1);
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
	static public int GetOSInstalledFontNames_s(IntPtr l) {
		try {
			var ret=UnityEngine.Font.GetOSInstalledFontNames();
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
	static public int get_material(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.material);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_material(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			UnityEngine.Material v;
			checkType(l,2,out v);
			self.material=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fontNames(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fontNames);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fontNames(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.fontNames=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_dynamic(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dynamic);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ascent(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ascent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fontSize(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fontSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_characterInfo(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.characterInfo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_characterInfo(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			UnityEngine.CharacterInfo[] v;
			checkArray(l,2,out v);
			self.characterInfo=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lineHeight(IntPtr l) {
		try {
			UnityEngine.Font self=(UnityEngine.Font)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lineHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Font");
		addMember(l,ctor_s);
		addMember(l,ctor__String_s);
		addMember(l,HasCharacter);
		addMember(l,GetCharacterInfo__Char__O_CharacterInfo);
		addMember(l,GetCharacterInfo__Char__O_CharacterInfo__Int32);
		addMember(l,GetCharacterInfo__Char__O_CharacterInfo__Int32__FontStyle);
		addMember(l,RequestCharactersInTexture__String);
		addMember(l,RequestCharactersInTexture__String__Int32);
		addMember(l,RequestCharactersInTexture__String__Int32__FontStyle);
		addMember(l,CreateDynamicFontFromOSFont__String__Int32_s);
		addMember(l,CreateDynamicFontFromOSFont__A_String__Int32_s);
		addMember(l,GetMaxVertsForString_s);
		addMember(l,GetOSInstalledFontNames_s);
		addMember(l,"material",get_material,set_material,true);
		addMember(l,"fontNames",get_fontNames,set_fontNames,true);
		addMember(l,"dynamic",get_dynamic,null,true);
		addMember(l,"ascent",get_ascent,null,true);
		addMember(l,"fontSize",get_fontSize,null,true);
		addMember(l,"characterInfo",get_characterInfo,set_characterInfo,true);
		addMember(l,"lineHeight",get_lineHeight,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Font),typeof(UnityEngine.Object));
	}
}
