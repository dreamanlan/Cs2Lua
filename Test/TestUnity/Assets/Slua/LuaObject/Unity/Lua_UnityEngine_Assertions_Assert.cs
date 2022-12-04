using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Assertions_Assert : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsTrue__Boolean_s(IntPtr l) {
		try {
			System.Boolean a1;
			checkType(l,1,out a1);
			UnityEngine.Assertions.Assert.IsTrue(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsTrue__Boolean__String_s(IntPtr l) {
		try {
			System.Boolean a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.IsTrue(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsFalse__Boolean_s(IntPtr l) {
		try {
			System.Boolean a1;
			checkType(l,1,out a1);
			UnityEngine.Assertions.Assert.IsFalse(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsFalse__Boolean__String_s(IntPtr l) {
		try {
			System.Boolean a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.IsFalse(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreApproximatelyEqual__Single__Single_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreApproximatelyEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreApproximatelyEqual__Single__Single__String_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreApproximatelyEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreApproximatelyEqual__Single__Single__Single_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreApproximatelyEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreApproximatelyEqual__Single__Single__Single__String_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.String a4;
			checkType(l,4,out a4);
			UnityEngine.Assertions.Assert.AreApproximatelyEqual(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotApproximatelyEqual__Single__Single_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotApproximatelyEqual__Single__Single__String_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotApproximatelyEqual__Single__Single__Single_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotApproximatelyEqual__Single__Single__Single__String_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.String a4;
			checkType(l,4,out a4);
			UnityEngine.Assertions.Assert.AreNotApproximatelyEqual(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__UInt16__UInt16_s(IntPtr l) {
		try {
			System.UInt16 a1;
			checkType(l,1,out a1);
			System.UInt16 a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__SByte__SByte_s(IntPtr l) {
		try {
			System.SByte a1;
			checkType(l,1,out a1);
			System.SByte a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__Byte__Byte_s(IntPtr l) {
		try {
			System.Byte a1;
			checkType(l,1,out a1);
			System.Byte a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__Int64__Int64_s(IntPtr l) {
		try {
			System.Int64 a1;
			checkType(l,1,out a1);
			System.Int64 a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__Char__Char_s(IntPtr l) {
		try {
			System.Char a1;
			checkType(l,1,out a1);
			System.Char a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__Int16__Int16_s(IntPtr l) {
		try {
			System.Int16 a1;
			checkType(l,1,out a1);
			System.Int16 a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__UInt32__UInt32_s(IntPtr l) {
		try {
			System.UInt32 a1;
			checkType(l,1,out a1);
			System.UInt32 a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__UInt64__UInt64_s(IntPtr l) {
		try {
			System.UInt64 a1;
			checkType(l,1,out a1);
			System.UInt64 a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__Int32__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__Int64__Int64__String_s(IntPtr l) {
		try {
			System.Int64 a1;
			checkType(l,1,out a1);
			System.Int64 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__UInt32__UInt32__String_s(IntPtr l) {
		try {
			System.UInt32 a1;
			checkType(l,1,out a1);
			System.UInt32 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__Int32__Int32__String_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__Object__Object__String_s(IntPtr l) {
		try {
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__Int16__Int16__String_s(IntPtr l) {
		try {
			System.Int16 a1;
			checkType(l,1,out a1);
			System.Int16 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__Char__Char__String_s(IntPtr l) {
		try {
			System.Char a1;
			checkType(l,1,out a1);
			System.Char a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__Byte__Byte__String_s(IntPtr l) {
		try {
			System.Byte a1;
			checkType(l,1,out a1);
			System.Byte a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__SByte__SByte__String_s(IntPtr l) {
		try {
			System.SByte a1;
			checkType(l,1,out a1);
			System.SByte a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__UInt16__UInt16__String_s(IntPtr l) {
		try {
			System.UInt16 a1;
			checkType(l,1,out a1);
			System.UInt16 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreEqual__UInt64__UInt64__String_s(IntPtr l) {
		try {
			System.UInt64 a1;
			checkType(l,1,out a1);
			System.UInt64 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__UInt16__UInt16_s(IntPtr l) {
		try {
			System.UInt16 a1;
			checkType(l,1,out a1);
			System.UInt16 a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__SByte__SByte_s(IntPtr l) {
		try {
			System.SByte a1;
			checkType(l,1,out a1);
			System.SByte a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__Byte__Byte_s(IntPtr l) {
		try {
			System.Byte a1;
			checkType(l,1,out a1);
			System.Byte a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__Int64__Int64_s(IntPtr l) {
		try {
			System.Int64 a1;
			checkType(l,1,out a1);
			System.Int64 a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__Char__Char_s(IntPtr l) {
		try {
			System.Char a1;
			checkType(l,1,out a1);
			System.Char a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__Int16__Int16_s(IntPtr l) {
		try {
			System.Int16 a1;
			checkType(l,1,out a1);
			System.Int16 a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__UInt32__UInt32_s(IntPtr l) {
		try {
			System.UInt32 a1;
			checkType(l,1,out a1);
			System.UInt32 a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__UInt64__UInt64_s(IntPtr l) {
		try {
			System.UInt64 a1;
			checkType(l,1,out a1);
			System.UInt64 a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__Int32__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__Int64__Int64__String_s(IntPtr l) {
		try {
			System.Int64 a1;
			checkType(l,1,out a1);
			System.Int64 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__UInt32__UInt32__String_s(IntPtr l) {
		try {
			System.UInt32 a1;
			checkType(l,1,out a1);
			System.UInt32 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__Int32__Int32__String_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__Object__Object__String_s(IntPtr l) {
		try {
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__Int16__Int16__String_s(IntPtr l) {
		try {
			System.Int16 a1;
			checkType(l,1,out a1);
			System.Int16 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__Char__Char__String_s(IntPtr l) {
		try {
			System.Char a1;
			checkType(l,1,out a1);
			System.Char a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__Byte__Byte__String_s(IntPtr l) {
		try {
			System.Byte a1;
			checkType(l,1,out a1);
			System.Byte a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__SByte__SByte__String_s(IntPtr l) {
		try {
			System.SByte a1;
			checkType(l,1,out a1);
			System.SByte a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__UInt16__UInt16__String_s(IntPtr l) {
		try {
			System.UInt16 a1;
			checkType(l,1,out a1);
			System.UInt16 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AreNotEqual__UInt64__UInt64__String_s(IntPtr l) {
		try {
			System.UInt64 a1;
			checkType(l,1,out a1);
			System.UInt64 a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			UnityEngine.Assertions.Assert.AreNotEqual(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsNull_s(IntPtr l) {
		try {
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.IsNull(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsNotNull_s(IntPtr l) {
		try {
			UnityEngine.Object a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Assertions.Assert.IsNotNull(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Assertions.Assert");
		addMember(l,IsTrue__Boolean_s);
		addMember(l,IsTrue__Boolean__String_s);
		addMember(l,IsFalse__Boolean_s);
		addMember(l,IsFalse__Boolean__String_s);
		addMember(l,AreApproximatelyEqual__Single__Single_s);
		addMember(l,AreApproximatelyEqual__Single__Single__String_s);
		addMember(l,AreApproximatelyEqual__Single__Single__Single_s);
		addMember(l,AreApproximatelyEqual__Single__Single__Single__String_s);
		addMember(l,AreNotApproximatelyEqual__Single__Single_s);
		addMember(l,AreNotApproximatelyEqual__Single__Single__String_s);
		addMember(l,AreNotApproximatelyEqual__Single__Single__Single_s);
		addMember(l,AreNotApproximatelyEqual__Single__Single__Single__String_s);
		addMember(l,AreEqual__UInt16__UInt16_s);
		addMember(l,AreEqual__SByte__SByte_s);
		addMember(l,AreEqual__Byte__Byte_s);
		addMember(l,AreEqual__Int64__Int64_s);
		addMember(l,AreEqual__Char__Char_s);
		addMember(l,AreEqual__Int16__Int16_s);
		addMember(l,AreEqual__UInt32__UInt32_s);
		addMember(l,AreEqual__UInt64__UInt64_s);
		addMember(l,AreEqual__Int32__Int32_s);
		addMember(l,AreEqual__Int64__Int64__String_s);
		addMember(l,AreEqual__UInt32__UInt32__String_s);
		addMember(l,AreEqual__Int32__Int32__String_s);
		addMember(l,AreEqual__Object__Object__String_s);
		addMember(l,AreEqual__Int16__Int16__String_s);
		addMember(l,AreEqual__Char__Char__String_s);
		addMember(l,AreEqual__Byte__Byte__String_s);
		addMember(l,AreEqual__SByte__SByte__String_s);
		addMember(l,AreEqual__UInt16__UInt16__String_s);
		addMember(l,AreEqual__UInt64__UInt64__String_s);
		addMember(l,AreNotEqual__UInt16__UInt16_s);
		addMember(l,AreNotEqual__SByte__SByte_s);
		addMember(l,AreNotEqual__Byte__Byte_s);
		addMember(l,AreNotEqual__Int64__Int64_s);
		addMember(l,AreNotEqual__Char__Char_s);
		addMember(l,AreNotEqual__Int16__Int16_s);
		addMember(l,AreNotEqual__UInt32__UInt32_s);
		addMember(l,AreNotEqual__UInt64__UInt64_s);
		addMember(l,AreNotEqual__Int32__Int32_s);
		addMember(l,AreNotEqual__Int64__Int64__String_s);
		addMember(l,AreNotEqual__UInt32__UInt32__String_s);
		addMember(l,AreNotEqual__Int32__Int32__String_s);
		addMember(l,AreNotEqual__Object__Object__String_s);
		addMember(l,AreNotEqual__Int16__Int16__String_s);
		addMember(l,AreNotEqual__Char__Char__String_s);
		addMember(l,AreNotEqual__Byte__Byte__String_s);
		addMember(l,AreNotEqual__SByte__SByte__String_s);
		addMember(l,AreNotEqual__UInt16__UInt16__String_s);
		addMember(l,AreNotEqual__UInt64__UInt64__String_s);
		addMember(l,IsNull_s);
		addMember(l,IsNotNull_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Assertions.Assert));
	}
}
