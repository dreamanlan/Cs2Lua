using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Text_RegularExpressions_Regex : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__String_s(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex o;
			System.String a1;
			checkType(l,1,out a1);
			o=new System.Text.RegularExpressions.Regex(a1);
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
	static public int ctor__String__RegexOptions_s(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex o;
			System.String a1;
			checkType(l,1,out a1);
			System.Text.RegularExpressions.RegexOptions a2;
			checkEnum(l,2,out a2);
			o=new System.Text.RegularExpressions.Regex(a1,a2);
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
	static public int ctor__String__RegexOptions__TimeSpan_s(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex o;
			System.String a1;
			checkType(l,1,out a1);
			System.Text.RegularExpressions.RegexOptions a2;
			checkEnum(l,2,out a2);
			System.TimeSpan a3;
			checkValueType(l,3,out a3);
			o=new System.Text.RegularExpressions.Regex(a1,a2,a3);
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
	static new public int ToString(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			var ret=self.ToString();
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
	static public int GetGroupNames(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			var ret=self.GetGroupNames();
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
	static public int GetGroupNumbers(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			var ret=self.GetGroupNumbers();
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
	static public int GroupNameFromNumber(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GroupNameFromNumber(a1);
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
	static public int GroupNumberFromName(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GroupNumberFromName(a1);
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
	static public int IsMatch__String(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.IsMatch(a1);
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
	static public int IsMatch__String__Int32(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.IsMatch(a1,a2);
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
	static public int Match__String(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Match(a1);
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
	static public int Match__String__Int32(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.Match(a1,a2);
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
	static public int Match__String__Int32__Int32(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.Match(a1,a2,a3);
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
	static public int Matches__String(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Matches(a1);
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
	static public int Matches__String__Int32(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.Matches(a1,a2);
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
	static public int Replace__String__String(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			var ret=self.Replace(a1,a2);
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
	static public int Replace__String__MatchEvaluator(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Text.RegularExpressions.MatchEvaluator a2;
			LuaDelegation.checkDelegate(l,3,out a2);
			var ret=self.Replace(a1,a2);
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
	static public int Replace__String__String__Int32(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.Replace(a1,a2,a3);
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
	static public int Replace__String__MatchEvaluator__Int32(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Text.RegularExpressions.MatchEvaluator a2;
			LuaDelegation.checkDelegate(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.Replace(a1,a2,a3);
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
	static public int Replace__String__String__Int32__Int32(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			var ret=self.Replace(a1,a2,a3,a4);
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
	static public int Replace__String__MatchEvaluator__Int32__Int32(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Text.RegularExpressions.MatchEvaluator a2;
			LuaDelegation.checkDelegate(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Int32 a4;
			checkType(l,5,out a4);
			var ret=self.Replace(a1,a2,a3,a4);
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
	static public int Split__String(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.Split(a1);
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
	static public int Split__String__Int32(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.Split(a1,a2);
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
	static public int Split__String__Int32__Int32(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			var ret=self.Split(a1,a2,a3);
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
	static public int Escape_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.Text.RegularExpressions.Regex.Escape(a1);
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
	static public int Unescape_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.Text.RegularExpressions.Regex.Unescape(a1);
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
	static public int IsMatch__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.Text.RegularExpressions.Regex.IsMatch(a1,a2);
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
	static public int IsMatch__String__String__RegexOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.RegularExpressions.RegexOptions a3;
			checkEnum(l,3,out a3);
			var ret=System.Text.RegularExpressions.Regex.IsMatch(a1,a2,a3);
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
	static public int IsMatch__String__String__RegexOptions__TimeSpan_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.RegularExpressions.RegexOptions a3;
			checkEnum(l,3,out a3);
			System.TimeSpan a4;
			checkValueType(l,4,out a4);
			var ret=System.Text.RegularExpressions.Regex.IsMatch(a1,a2,a3,a4);
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
	static public int Match__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.Text.RegularExpressions.Regex.Match(a1,a2);
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
	static public int Match__String__String__RegexOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.RegularExpressions.RegexOptions a3;
			checkEnum(l,3,out a3);
			var ret=System.Text.RegularExpressions.Regex.Match(a1,a2,a3);
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
	static public int Match__String__String__RegexOptions__TimeSpan_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.RegularExpressions.RegexOptions a3;
			checkEnum(l,3,out a3);
			System.TimeSpan a4;
			checkValueType(l,4,out a4);
			var ret=System.Text.RegularExpressions.Regex.Match(a1,a2,a3,a4);
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
	static public int Matches__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.Text.RegularExpressions.Regex.Matches(a1,a2);
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
	static public int Matches__String__String__RegexOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.RegularExpressions.RegexOptions a3;
			checkEnum(l,3,out a3);
			var ret=System.Text.RegularExpressions.Regex.Matches(a1,a2,a3);
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
	static public int Matches__String__String__RegexOptions__TimeSpan_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.RegularExpressions.RegexOptions a3;
			checkEnum(l,3,out a3);
			System.TimeSpan a4;
			checkValueType(l,4,out a4);
			var ret=System.Text.RegularExpressions.Regex.Matches(a1,a2,a3,a4);
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
	static public int Replace__String__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			var ret=System.Text.RegularExpressions.Regex.Replace(a1,a2,a3);
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
	static public int Replace__String__String__MatchEvaluator_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.RegularExpressions.MatchEvaluator a3;
			LuaDelegation.checkDelegate(l,3,out a3);
			var ret=System.Text.RegularExpressions.Regex.Replace(a1,a2,a3);
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
	static public int Replace__String__String__String__RegexOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Text.RegularExpressions.RegexOptions a4;
			checkEnum(l,4,out a4);
			var ret=System.Text.RegularExpressions.Regex.Replace(a1,a2,a3,a4);
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
	static public int Replace__String__String__MatchEvaluator__RegexOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.RegularExpressions.MatchEvaluator a3;
			LuaDelegation.checkDelegate(l,3,out a3);
			System.Text.RegularExpressions.RegexOptions a4;
			checkEnum(l,4,out a4);
			var ret=System.Text.RegularExpressions.Regex.Replace(a1,a2,a3,a4);
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
	static public int Replace__String__String__String__RegexOptions__TimeSpan_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.String a3;
			checkType(l,3,out a3);
			System.Text.RegularExpressions.RegexOptions a4;
			checkEnum(l,4,out a4);
			System.TimeSpan a5;
			checkValueType(l,5,out a5);
			var ret=System.Text.RegularExpressions.Regex.Replace(a1,a2,a3,a4,a5);
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
	static public int Replace__String__String__MatchEvaluator__RegexOptions__TimeSpan_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.RegularExpressions.MatchEvaluator a3;
			LuaDelegation.checkDelegate(l,3,out a3);
			System.Text.RegularExpressions.RegexOptions a4;
			checkEnum(l,4,out a4);
			System.TimeSpan a5;
			checkValueType(l,5,out a5);
			var ret=System.Text.RegularExpressions.Regex.Replace(a1,a2,a3,a4,a5);
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
	static public int Split__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.Text.RegularExpressions.Regex.Split(a1,a2);
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
	static public int Split__String__String__RegexOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.RegularExpressions.RegexOptions a3;
			checkEnum(l,3,out a3);
			var ret=System.Text.RegularExpressions.Regex.Split(a1,a2,a3);
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
	static public int Split__String__String__RegexOptions__TimeSpan_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			System.Text.RegularExpressions.RegexOptions a3;
			checkEnum(l,3,out a3);
			System.TimeSpan a4;
			checkValueType(l,4,out a4);
			var ret=System.Text.RegularExpressions.Regex.Split(a1,a2,a3,a4);
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
	static public int CompileToAssembly__A_RegexCompilationInfo__AssemblyName_s(IntPtr l) {
		try {
			System.Text.RegularExpressions.RegexCompilationInfo[] a1;
			checkArray(l,1,out a1);
			System.Reflection.AssemblyName a2;
			checkType(l,2,out a2);
			System.Text.RegularExpressions.Regex.CompileToAssembly(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CompileToAssembly__A_RegexCompilationInfo__AssemblyName__A_CustomAttributeBuilder_s(IntPtr l) {
		try {
			System.Text.RegularExpressions.RegexCompilationInfo[] a1;
			checkArray(l,1,out a1);
			System.Reflection.AssemblyName a2;
			checkType(l,2,out a2);
			System.Reflection.Emit.CustomAttributeBuilder[] a3;
			checkArray(l,3,out a3);
			System.Text.RegularExpressions.Regex.CompileToAssembly(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CompileToAssembly__A_RegexCompilationInfo__AssemblyName__A_CustomAttributeBuilder__String_s(IntPtr l) {
		try {
			System.Text.RegularExpressions.RegexCompilationInfo[] a1;
			checkArray(l,1,out a1);
			System.Reflection.AssemblyName a2;
			checkType(l,2,out a2);
			System.Reflection.Emit.CustomAttributeBuilder[] a3;
			checkArray(l,3,out a3);
			System.String a4;
			checkType(l,4,out a4);
			System.Text.RegularExpressions.Regex.CompileToAssembly(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_InfiniteMatchTimeout(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Text.RegularExpressions.Regex.InfiniteMatchTimeout);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CacheSize(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Text.RegularExpressions.Regex.CacheSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_CacheSize(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			System.Text.RegularExpressions.Regex.CacheSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Options(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.Options);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_MatchTimeout(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.MatchTimeout);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_RightToLeft(IntPtr l) {
		try {
			System.Text.RegularExpressions.Regex self=(System.Text.RegularExpressions.Regex)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.RightToLeft);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Text.RegularExpressions.Regex");
		addMember(l,ctor__String_s);
		addMember(l,ctor__String__RegexOptions_s);
		addMember(l,ctor__String__RegexOptions__TimeSpan_s);
		addMember(l,ToString);
		addMember(l,GetGroupNames);
		addMember(l,GetGroupNumbers);
		addMember(l,GroupNameFromNumber);
		addMember(l,GroupNumberFromName);
		addMember(l,IsMatch__String);
		addMember(l,IsMatch__String__Int32);
		addMember(l,Match__String);
		addMember(l,Match__String__Int32);
		addMember(l,Match__String__Int32__Int32);
		addMember(l,Matches__String);
		addMember(l,Matches__String__Int32);
		addMember(l,Replace__String__String);
		addMember(l,Replace__String__MatchEvaluator);
		addMember(l,Replace__String__String__Int32);
		addMember(l,Replace__String__MatchEvaluator__Int32);
		addMember(l,Replace__String__String__Int32__Int32);
		addMember(l,Replace__String__MatchEvaluator__Int32__Int32);
		addMember(l,Split__String);
		addMember(l,Split__String__Int32);
		addMember(l,Split__String__Int32__Int32);
		addMember(l,Escape_s);
		addMember(l,Unescape_s);
		addMember(l,IsMatch__String__String_s);
		addMember(l,IsMatch__String__String__RegexOptions_s);
		addMember(l,IsMatch__String__String__RegexOptions__TimeSpan_s);
		addMember(l,Match__String__String_s);
		addMember(l,Match__String__String__RegexOptions_s);
		addMember(l,Match__String__String__RegexOptions__TimeSpan_s);
		addMember(l,Matches__String__String_s);
		addMember(l,Matches__String__String__RegexOptions_s);
		addMember(l,Matches__String__String__RegexOptions__TimeSpan_s);
		addMember(l,Replace__String__String__String_s);
		addMember(l,Replace__String__String__MatchEvaluator_s);
		addMember(l,Replace__String__String__String__RegexOptions_s);
		addMember(l,Replace__String__String__MatchEvaluator__RegexOptions_s);
		addMember(l,Replace__String__String__String__RegexOptions__TimeSpan_s);
		addMember(l,Replace__String__String__MatchEvaluator__RegexOptions__TimeSpan_s);
		addMember(l,Split__String__String_s);
		addMember(l,Split__String__String__RegexOptions_s);
		addMember(l,Split__String__String__RegexOptions__TimeSpan_s);
		addMember(l,CompileToAssembly__A_RegexCompilationInfo__AssemblyName_s);
		addMember(l,CompileToAssembly__A_RegexCompilationInfo__AssemblyName__A_CustomAttributeBuilder_s);
		addMember(l,CompileToAssembly__A_RegexCompilationInfo__AssemblyName__A_CustomAttributeBuilder__String_s);
		addMember(l,"InfiniteMatchTimeout",get_InfiniteMatchTimeout,null,false);
		addMember(l,"CacheSize",get_CacheSize,set_CacheSize,false);
		addMember(l,"Options",get_Options,null,true);
		addMember(l,"MatchTimeout",get_MatchTimeout,null,true);
		addMember(l,"RightToLeft",get_RightToLeft,null,true);
		createTypeMetatable(l,null, typeof(System.Text.RegularExpressions.Regex));
	}
}
