using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Double : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			System.Double o;
			o=new System.Double();
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
	static public int CompareTo__Object(IntPtr l) {
		try {
			System.Double self;
			checkType(l,1,out self);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.CompareTo(a1);
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
	static public int CompareTo__Double(IntPtr l) {
		try {
			System.Double self;
			checkType(l,1,out self);
			System.Double a1;
			checkType(l,2,out a1);
			var ret=self.CompareTo(a1);
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
	static public int Equals__Object(IntPtr l) {
		try {
			System.Double self;
			checkType(l,1,out self);
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
	static public int Equals__Double(IntPtr l) {
		try {
			System.Double self;
			checkType(l,1,out self);
			System.Double a1;
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
	static new public int ToString(IntPtr l) {
		try {
			System.Double self;
			checkType(l,1,out self);
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
	static public int ToString__String(IntPtr l) {
		try {
			System.Double self;
			checkType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.ToString(a1);
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
	static public int ToString__IFormatProvider(IntPtr l) {
		try {
			System.Double self;
			checkType(l,1,out self);
			System.IFormatProvider a1;
			checkType(l,2,out a1);
			var ret=self.ToString(a1);
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
	static public int ToString__String__IFormatProvider(IntPtr l) {
		try {
			System.Double self;
			checkType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.IFormatProvider a2;
			checkType(l,3,out a2);
			var ret=self.ToString(a1,a2);
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
	static public int GetTypeCode(IntPtr l) {
		try {
			System.Double self;
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
	static public int IsInfinity_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Double.IsInfinity(a1);
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
	static public int IsNaN_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Double.IsNaN(a1);
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
	static public int IsNegative_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Double.IsNegative(a1);
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
	static public int IsNegativeInfinity_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Double.IsNegativeInfinity(a1);
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
	static public int IsNormal_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Double.IsNormal(a1);
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
	static public int IsPositiveInfinity_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Double.IsPositiveInfinity(a1);
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
	static public int IsSubnormal_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			var ret=System.Double.IsSubnormal(a1);
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
	static public int op_Equality_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			System.Double a2;
			checkType(l,2,out a2);
			var ret=(a1==a2);
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
	static public int op_Inequality_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			System.Double a2;
			checkType(l,2,out a2);
			var ret=(a1!=a2);
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
	static public int op_LessThan_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			System.Double a2;
			checkType(l,2,out a2);
			var ret=(a1<a2);
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
	static public int op_GreaterThan_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			System.Double a2;
			checkType(l,2,out a2);
			var ret=(a2<a1);
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
	static public int op_LessThanOrEqual_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			System.Double a2;
			checkType(l,2,out a2);
			var ret=(a1<=a2);
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
	static public int op_GreaterThanOrEqual_s(IntPtr l) {
		try {
			System.Double a1;
			checkType(l,1,out a1);
			System.Double a2;
			checkType(l,2,out a2);
			var ret=(a2<=a1);
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
	static public int Parse__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.Double.Parse(a1);
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
	static public int Parse__String__NumberStyles_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Globalization.NumberStyles a2;
			checkEnum(l,2,out a2);
			var ret=System.Double.Parse(a1,a2);
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
	static public int Parse__String__IFormatProvider_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.IFormatProvider a2;
			checkType(l,2,out a2);
			var ret=System.Double.Parse(a1,a2);
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
	static public int Parse__String__NumberStyles__IFormatProvider_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Globalization.NumberStyles a2;
			checkEnum(l,2,out a2);
			System.IFormatProvider a3;
			checkType(l,3,out a3);
			var ret=System.Double.Parse(a1,a2,a3);
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
	static public int TryParse__String__O_Double_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Double a2;
			var ret=System.Double.TryParse(a1,out a2);
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
	static public int TryParse__String__NumberStyles__IFormatProvider__O_Double_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.Globalization.NumberStyles a2;
			checkEnum(l,2,out a2);
			System.IFormatProvider a3;
			checkType(l,3,out a3);
			System.Double a4;
			var ret=System.Double.TryParse(a1,a2,a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			return 3;
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
			pushValue(l,System.Double.MinValue);
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
			pushValue(l,System.Double.MaxValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Epsilon(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Double.Epsilon);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_NegativeInfinity(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Double.NegativeInfinity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_PositiveInfinity(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Double.PositiveInfinity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_NaN(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Double.NaN);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Double");
		addMember(l,ctor_s);
		addMember(l,CompareTo__Object);
		addMember(l,CompareTo__Double);
		addMember(l,Equals__Object);
		addMember(l,Equals__Double);
		addMember(l,ToString);
		addMember(l,ToString__String);
		addMember(l,ToString__IFormatProvider);
		addMember(l,ToString__String__IFormatProvider);
		addMember(l,GetTypeCode);
		addMember(l,IsInfinity_s);
		addMember(l,IsNaN_s);
		addMember(l,IsNegative_s);
		addMember(l,IsNegativeInfinity_s);
		addMember(l,IsNormal_s);
		addMember(l,IsPositiveInfinity_s);
		addMember(l,IsSubnormal_s);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,op_LessThan_s);
		addMember(l,op_GreaterThan_s);
		addMember(l,op_LessThanOrEqual_s);
		addMember(l,op_GreaterThanOrEqual_s);
		addMember(l,Parse__String_s);
		addMember(l,Parse__String__NumberStyles_s);
		addMember(l,Parse__String__IFormatProvider_s);
		addMember(l,Parse__String__NumberStyles__IFormatProvider_s);
		addMember(l,TryParse__String__O_Double_s);
		addMember(l,TryParse__String__NumberStyles__IFormatProvider__O_Double_s);
		addMember(l,"MinValue",get_MinValue,null,false);
		addMember(l,"MaxValue",get_MaxValue,null,false);
		addMember(l,"Epsilon",get_Epsilon,null,false);
		addMember(l,"NegativeInfinity",get_NegativeInfinity,null,false);
		addMember(l,"PositiveInfinity",get_PositiveInfinity,null,false);
		addMember(l,"NaN",get_NaN,null,false);
		createTypeMetatable(l,null, typeof(System.Double),typeof(System.ValueType));
	}
}
