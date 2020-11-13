using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Text_RegularExpressions_Group : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Synchronized_s(IntPtr l) {
		try {
			System.Text.RegularExpressions.Group a1;
			checkType(l,1,out a1);
			var ret=System.Text.RegularExpressions.Group.Synchronized(a1);
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
	static public int get_Success(IntPtr l) {
		try {
			System.Text.RegularExpressions.Group self=(System.Text.RegularExpressions.Group)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Success);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Name(IntPtr l) {
		try {
			System.Text.RegularExpressions.Group self=(System.Text.RegularExpressions.Group)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Captures(IntPtr l) {
		try {
			System.Text.RegularExpressions.Group self=(System.Text.RegularExpressions.Group)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Captures);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Text.RegularExpressions.Group");
		addMember(l,Synchronized_s);
		addMember(l,"Success",get_Success,null,true);
		addMember(l,"Name",get_Name,null,true);
		addMember(l,"Captures",get_Captures,null,true);
		createTypeMetatable(l,null, typeof(System.Text.RegularExpressions.Group),typeof(System.Text.RegularExpressions.Capture));
	}
}
