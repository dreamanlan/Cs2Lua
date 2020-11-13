using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Math : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Acos_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Math.Acos(a1);
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
	static public int Asin_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Math.Asin(a1);
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
	static public int Atan_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Math.Atan(a1);
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
	static public int Atan2_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			System.Double a2;
			checkType(l,2,out a2);
			var ret=System.Math.Atan2(a1,a2);
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
	static public int Ceiling_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Ceiling__Decimal__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Math.Ceiling(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Ceiling__Double__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Math.Ceiling(a1);
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
	static public int Cos_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Math.Cos(a1);
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
	static public int Cosh_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Math.Cosh(a1);
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
	static public int Floor_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Floor__Decimal__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Math.Floor(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Floor__Double__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Math.Floor(a1);
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
	static public int Sin_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Math.Sin(a1);
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
	static public int Tan_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Math.Tan(a1);
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
	static public int Sinh_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Math.Sinh(a1);
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
	static public int Tanh_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Math.Tanh(a1);
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
	static public int Round_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Round__Decimal__Decimal__Int32__MidpointRounding", argc, 1,typeof(System.Decimal),typeof(int),typeof(System.MidpointRounding))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.MidpointRounding a3;
				checkEnum(l,4,out a3);
				var ret=System.Math.Round(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Round__Double__Double__Int32__MidpointRounding", argc, 1,typeof(double),typeof(int),typeof(System.MidpointRounding))){
				System.Double a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.MidpointRounding a3;
				checkEnum(l,4,out a3);
				var ret=System.Math.Round(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Round__Decimal__Decimal__Int32", argc, 1,typeof(System.Decimal),typeof(int))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Round(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Round__Decimal__Decimal__MidpointRounding", argc, 1,typeof(System.Decimal),typeof(System.MidpointRounding))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				System.MidpointRounding a2;
				checkEnum(l,3,out a2);
				var ret=System.Math.Round(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Round__Double__Double__Int32", argc, 1,typeof(double),typeof(int))){
				System.Double a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Round(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Round__Double__Double__MidpointRounding", argc, 1,typeof(double),typeof(System.MidpointRounding))){
				System.Double a1;
				checkType(l,2,out a1);
				System.MidpointRounding a2;
				checkEnum(l,3,out a2);
				var ret=System.Math.Round(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Round__Decimal__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Math.Round(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Round__Double__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Math.Round(a1);
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
	static public int Truncate_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Truncate__Decimal__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Math.Truncate(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Truncate__Double__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Math.Truncate(a1);
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
	static public int Sqrt_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Math.Sqrt(a1);
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
	static public int Log_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.Double a1;
				checkType(l,2,out a1);
				System.Double a2;
				checkType(l,3,out a2);
				var ret=System.Math.Log(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Math.Log(a1);
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
	static public int Log10_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Math.Log10(a1);
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
	static public int Exp_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Math.Exp(a1);
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
	static public int Pow_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			System.Double a2;
			checkType(l,2,out a2);
			var ret=System.Math.Pow(a1,a2);
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
	static public int IEEERemainder_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			System.Double a2;
			checkType(l,2,out a2);
			var ret=System.Math.IEEERemainder(a1,a2);
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
	static public int Abs_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Abs__SByte__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Math.Abs(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Abs__Int16__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Math.Abs(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Abs__Int32__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Math.Abs(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Abs__Int64__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Math.Abs(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Abs__Decimal__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Math.Abs(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Abs__Single__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Math.Abs(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Abs__Double__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Math.Abs(a1);
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
	static public int Max_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Max__SByte__SByte__SByte", argc, 1,typeof(System.SByte),typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				System.SByte a2;
				checkType(l,3,out a2);
				var ret=System.Math.Max(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Max__Byte__Byte__Byte", argc, 1,typeof(System.Byte),typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				System.Byte a2;
				checkType(l,3,out a2);
				var ret=System.Math.Max(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Max__Int16__Int16__Int16", argc, 1,typeof(System.Int16),typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				System.Int16 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Max(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Max__UInt16__UInt16__UInt16", argc, 1,typeof(System.UInt16),typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				System.UInt16 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Max(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Max__Int32__Int32__Int32", argc, 1,typeof(int),typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Max(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Max__UInt32__UInt32__UInt32", argc, 1,typeof(System.UInt32),typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				System.UInt32 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Max(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Max__Int64__Int64__Int64", argc, 1,typeof(System.Int64),typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				System.Int64 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Max(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Max__UInt64__UInt64__UInt64", argc, 1,typeof(System.UInt64),typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				System.UInt64 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Max(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Max__Decimal__Decimal__Decimal", argc, 1,typeof(System.Decimal),typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				System.Decimal a2;
				checkValueType(l,3,out a2);
				var ret=System.Math.Max(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Max__Single__Single__Single", argc, 1,typeof(float),typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				var ret=System.Math.Max(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Max__Double__Double__Double", argc, 1,typeof(double),typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				System.Double a2;
				checkType(l,3,out a2);
				var ret=System.Math.Max(a1,a2);
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
	static public int Min_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Min__SByte__SByte__SByte", argc, 1,typeof(System.SByte),typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				System.SByte a2;
				checkType(l,3,out a2);
				var ret=System.Math.Min(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Min__Byte__Byte__Byte", argc, 1,typeof(System.Byte),typeof(System.Byte))){
				System.Byte a1;
				checkType(l,2,out a1);
				System.Byte a2;
				checkType(l,3,out a2);
				var ret=System.Math.Min(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Min__Int16__Int16__Int16", argc, 1,typeof(System.Int16),typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				System.Int16 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Min(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Min__UInt16__UInt16__UInt16", argc, 1,typeof(System.UInt16),typeof(System.UInt16))){
				System.UInt16 a1;
				checkType(l,2,out a1);
				System.UInt16 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Min(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Min__Int32__Int32__Int32", argc, 1,typeof(int),typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Min(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Min__UInt32__UInt32__UInt32", argc, 1,typeof(System.UInt32),typeof(System.UInt32))){
				System.UInt32 a1;
				checkType(l,2,out a1);
				System.UInt32 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Min(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Min__Int64__Int64__Int64", argc, 1,typeof(System.Int64),typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				System.Int64 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Min(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Min__UInt64__UInt64__UInt64", argc, 1,typeof(System.UInt64),typeof(System.UInt64))){
				System.UInt64 a1;
				checkType(l,2,out a1);
				System.UInt64 a2;
				checkType(l,3,out a2);
				var ret=System.Math.Min(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Min__Decimal__Decimal__Decimal", argc, 1,typeof(System.Decimal),typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				System.Decimal a2;
				checkValueType(l,3,out a2);
				var ret=System.Math.Min(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Min__Single__Single__Single", argc, 1,typeof(float),typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				var ret=System.Math.Min(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Min__Double__Double__Double", argc, 1,typeof(double),typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				System.Double a2;
				checkType(l,3,out a2);
				var ret=System.Math.Min(a1,a2);
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
	static public int Sign_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "Sign__Int32__SByte", argc, 1,typeof(System.SByte))){
				System.SByte a1;
				checkType(l,2,out a1);
				var ret=System.Math.Sign(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Sign__Int32__Int16", argc, 1,typeof(System.Int16))){
				System.Int16 a1;
				checkType(l,2,out a1);
				var ret=System.Math.Sign(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Sign__Int32__Int32", argc, 1,typeof(int))){
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=System.Math.Sign(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Sign__Int32__Int64", argc, 1,typeof(System.Int64))){
				System.Int64 a1;
				checkType(l,2,out a1);
				var ret=System.Math.Sign(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Sign__Int32__Decimal", argc, 1,typeof(System.Decimal))){
				System.Decimal a1;
				checkValueType(l,2,out a1);
				var ret=System.Math.Sign(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Sign__Int32__Single", argc, 1,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				var ret=System.Math.Sign(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l, "Sign__Int32__Double", argc, 1,typeof(double))){
				System.Double a1;
				checkType(l,2,out a1);
				var ret=System.Math.Sign(a1);
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
	static public int BigMul_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=System.Math.BigMul(a1,a2);
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
	static public int DivRem_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l, "DivRem__Int32__Int32__Int32__Out_Int32", argc, 1,typeof(int),typeof(int),typeof(LuaOut))){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				var ret=System.Math.DivRem(a1,a2,out a3);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
				return 3;
			}
			else if(matchType(l, "DivRem__Int64__Int64__Int64__Out_Int64", argc, 1,typeof(System.Int64),typeof(System.Int64),typeof(LuaOut))){
				System.Int64 a1;
				checkType(l,2,out a1);
				System.Int64 a2;
				checkType(l,3,out a2);
				System.Int64 a3;
				var ret=System.Math.DivRem(a1,a2,out a3);
				pushValue(l,true);
				pushValue(l,ret);
				pushValue(l,a3);
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
	static public int get_PI(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Math.PI);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_E(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Math.E);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Math");
		addMember(l,Acos_s);
		addMember(l,Asin_s);
		addMember(l,Atan_s);
		addMember(l,Atan2_s);
		addMember(l,Ceiling_s);
		addMember(l,Cos_s);
		addMember(l,Cosh_s);
		addMember(l,Floor_s);
		addMember(l,Sin_s);
		addMember(l,Tan_s);
		addMember(l,Sinh_s);
		addMember(l,Tanh_s);
		addMember(l,Round_s);
		addMember(l,Truncate_s);
		addMember(l,Sqrt_s);
		addMember(l,Log_s);
		addMember(l,Log10_s);
		addMember(l,Exp_s);
		addMember(l,Pow_s);
		addMember(l,IEEERemainder_s);
		addMember(l,Abs_s);
		addMember(l,Max_s);
		addMember(l,Min_s);
		addMember(l,Sign_s);
		addMember(l,BigMul_s);
		addMember(l,DivRem_s);
		addMember(l,"PI",get_PI,null,false);
		addMember(l,"E",get_E,null,false);
		createTypeMetatable(l,null, typeof(System.Math));
	}
}
