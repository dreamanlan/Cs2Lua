using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LineUtility : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.LineUtility o;
			o=new UnityEngine.LineUtility();
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
	static public int Simplify__List_1_Vector3__Single__List_1_Int32_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.Vector3> a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<System.Int32> a3;
			checkType(l,3,out a3);
			UnityEngine.LineUtility.Simplify(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Simplify__List_1_Vector3__Single__List_1_Vector3_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.Vector3> a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.Vector3> a3;
			checkType(l,3,out a3);
			UnityEngine.LineUtility.Simplify(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Simplify__List_1_Vector2__Single__List_1_Int32_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.Vector2> a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<System.Int32> a3;
			checkType(l,3,out a3);
			UnityEngine.LineUtility.Simplify(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Simplify__List_1_Vector2__Single__List_1_Vector2_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.Vector2> a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.Vector2> a3;
			checkType(l,3,out a3);
			UnityEngine.LineUtility.Simplify(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LineUtility");
		addMember(l,ctor_s);
		addMember(l,Simplify__List_1_Vector3__Single__List_1_Int32_s);
		addMember(l,Simplify__List_1_Vector3__Single__List_1_Vector3_s);
		addMember(l,Simplify__List_1_Vector2__Single__List_1_Int32_s);
		addMember(l,Simplify__List_1_Vector2__Single__List_1_Vector2_s);
		createTypeMetatable(l,null, typeof(UnityEngine.LineUtility));
	}
}
