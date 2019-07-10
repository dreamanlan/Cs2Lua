using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_UInt16 : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			System.UInt16 o;
			o=new System.UInt16();
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
	static public int CompareTo(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "CompareTo__Object", argc, 2,typeof(System.Object))){
				System.UInt16 self;
				checkType(l,1,out self);
				System.Object a1;
				checkType(l,3,out a1);
				var ret=self.CompareTo(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "CompareTo__UInt16", argc, 2,typeof(System.UInt16))){
				System.UInt16 self;
				checkType(l,1,out self);
				System.UInt16 a1;
				checkType(l,3,out a1);
				var ret=self.CompareTo(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTypeCode(IntPtr l) {
		try {
			System.UInt16 self;
			checkType(l,1,out self);
			var ret=self.GetTypeCode();
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
	static public int Parse_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				System.String a1;
				checkType(l,2,out a1);
				System.Globalization.NumberStyles a2;
				checkEnum(l,3,out a2);
				System.IFormatProvider a3;
				checkType(l,4,out a3);
				var ret=System.UInt16.Parse(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Parse__String__NumberStyles", argc, 1,typeof(string),typeof(System.Globalization.NumberStyles))){
				System.String a1;
				checkType(l,2,out a1);
				System.Globalization.NumberStyles a2;
				checkEnum(l,3,out a2);
				var ret=System.UInt16.Parse(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Parse__String__IFormatProvider", argc, 1,typeof(string),typeof(System.IFormatProvider))){
				System.String a1;
				checkType(l,2,out a1);
				System.IFormatProvider a2;
				checkType(l,3,out a2);
				var ret=System.UInt16.Parse(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,2,out a1);
				var ret=System.UInt16.Parse(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int TryParse_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==5){
				System.String a1;
				checkType(l,2,out a1);
				System.Globalization.NumberStyles a2;
				checkEnum(l,3,out a2);
				System.IFormatProvider a3;
				checkType(l,4,out a3);
				System.UInt16 a4;
				var ret=System.UInt16.TryParse(a1,a2,a3,out a4);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a4);
				return 3;
			}
			else if(argc==3){
				System.String a1;
				checkType(l,2,out a1);
				System.UInt16 a2;
				var ret=System.UInt16.TryParse(a1,out a2);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a2);
				return 3;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_MaxValue(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.UInt16.MaxValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_MinValue(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.UInt16.MinValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.UInt16");
		addMember(l,CompareTo);
		addMember(l,GetTypeCode);
		addMember(l,Parse_s);
		addMember(l,TryParse_s);
		addMember(l,"MaxValue",get_MaxValue,null,false);
		addMember(l,"MinValue",get_MinValue,null,false);
		createTypeMetatable(l,constructor, typeof(System.UInt16),typeof(System.ValueType));
	}
}
