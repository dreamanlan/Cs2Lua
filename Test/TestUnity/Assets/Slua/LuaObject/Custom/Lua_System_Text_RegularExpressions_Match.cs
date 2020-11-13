using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Text_RegularExpressions_Match : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int NextMatch(IntPtr l) {
		try {
			System.Text.RegularExpressions.Match self=(System.Text.RegularExpressions.Match)checkSelf(l);
			var ret=self.NextMatch();
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
	static public int Result(IntPtr l) {
		try {
			System.Text.RegularExpressions.Match self=(System.Text.RegularExpressions.Match)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Result(a1);
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
	static public int Synchronized_s(IntPtr l) {
		try {
			System.Text.RegularExpressions.Match a1;
			checkType(l,1,out a1);
			var ret=System.Text.RegularExpressions.Match.Synchronized(a1);
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
	static public int get_Empty(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Text.RegularExpressions.Match.Empty);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Groups(IntPtr l) {
		try {
			System.Text.RegularExpressions.Match self=(System.Text.RegularExpressions.Match)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Groups);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Text.RegularExpressions.Match");
		addMember(l,NextMatch);
		addMember(l,Result);
		addMember(l,Synchronized_s);
		addMember(l,"Empty",get_Empty,null,false);
		addMember(l,"Groups",get_Groups,null,true);
		createTypeMetatable(l,null, typeof(System.Text.RegularExpressions.Match),typeof(System.Text.RegularExpressions.Group));
	}
}
