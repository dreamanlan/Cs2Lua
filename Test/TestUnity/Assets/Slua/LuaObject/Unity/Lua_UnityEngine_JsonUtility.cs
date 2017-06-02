using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_JsonUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ToJson_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Object a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.JsonUtility.ToJson(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Object a1;
				checkType(l,1,out a1);
				System.Boolean a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.JsonUtility.ToJson(a1,a2);
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
	static public int FromJson_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Type a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.JsonUtility.FromJson(a1,a2);
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
	static public int FromJsonOverwrite_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			UnityEngine.JsonUtility.FromJsonOverwrite(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JsonUtility");
		addMember(l,ToJson_s);
		addMember(l,FromJson_s);
		addMember(l,FromJsonOverwrite_s);
		createTypeMetatable(l,null, typeof(UnityEngine.JsonUtility));
	}
}
