using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Assertions_Comparers_FloatComparer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Assertions.Comparers.FloatComparer o;
			o=new UnityEngine.Assertions.Comparers.FloatComparer();
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
	static public int ctor__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Assertions.Comparers.FloatComparer o;
			System.Boolean a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Assertions.Comparers.FloatComparer(a1);
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
	static public int ctor__Single_s(IntPtr l) {
		try {
			UnityEngine.Assertions.Comparers.FloatComparer o;
			System.Single a1;
			checkType(l,1,out a1);
			o=new UnityEngine.Assertions.Comparers.FloatComparer(a1);
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
	static public int ctor__Single__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Assertions.Comparers.FloatComparer o;
			System.Single a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Assertions.Comparers.FloatComparer(a1,a2);
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Assertions.Comparers.FloatComparer self=(UnityEngine.Assertions.Comparers.FloatComparer)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
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
	static public int Equals__Single__Single(IntPtr l) {
		try {
			UnityEngine.Assertions.Comparers.FloatComparer self=(UnityEngine.Assertions.Comparers.FloatComparer)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.Equals(a1,a2);
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
	static new public int GetHashCode(IntPtr l) {
		try {
			UnityEngine.Assertions.Comparers.FloatComparer self=(UnityEngine.Assertions.Comparers.FloatComparer)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.GetHashCode(a1);
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
	static public int AreEqual_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Assertions.Comparers.FloatComparer.AreEqual(a1,a2,a3);
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
	static public int AreEqualRelative_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Assertions.Comparers.FloatComparer.AreEqualRelative(a1,a2,a3);
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
	static public int get_s_ComparerWithDefaultTolerance(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Assertions.Comparers.FloatComparer.s_ComparerWithDefaultTolerance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_kEpsilon(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Assertions.Comparers.FloatComparer.kEpsilon);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Assertions.Comparers.FloatComparer");
		addMember(l,ctor_s);
		addMember(l,ctor__Boolean_s);
		addMember(l,ctor__Single_s);
		addMember(l,ctor__Single__Boolean_s);
		addMember(l,Equals__Object);
		addMember(l,Equals__Single__Single);
		addMember(l,GetHashCode);
		addMember(l,AreEqual_s);
		addMember(l,AreEqualRelative_s);
		addMember(l,"s_ComparerWithDefaultTolerance",get_s_ComparerWithDefaultTolerance,null,false);
		addMember(l,"kEpsilon",get_kEpsilon,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Assertions.Comparers.FloatComparer));
	}
}
