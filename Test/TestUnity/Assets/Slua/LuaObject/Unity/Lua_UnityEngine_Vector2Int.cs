using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Vector2Int : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Vector2Int o;
			o=new UnityEngine.Vector2Int();
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
	static public int ctor__Int32__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector2Int o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			o=new UnityEngine.Vector2Int(a1,a2);
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
	static public int Set(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.Set(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Scale(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
			UnityEngine.Vector2Int a1;
			checkValueType(l,2,out a1);
			self.Scale(a1);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Clamp(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
			UnityEngine.Vector2Int a1;
			checkValueType(l,2,out a1);
			UnityEngine.Vector2Int a2;
			checkValueType(l,3,out a2);
			self.Clamp(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
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
	static public int Equals__Vector2Int(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
			UnityEngine.Vector2Int a1;
			checkValueType(l,2,out a1);
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
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
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
	static public int Distance_s(IntPtr l) {
		try {
			UnityEngine.Vector2Int a1;
			checkValueType(l,1,out a1);
			UnityEngine.Vector2Int a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.Vector2Int.Distance(a1,a2);
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
	static public int Min_s(IntPtr l) {
		try {
			UnityEngine.Vector2Int a1;
			checkValueType(l,1,out a1);
			UnityEngine.Vector2Int a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.Vector2Int.Min(a1,a2);
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
	static public int Max_s(IntPtr l) {
		try {
			UnityEngine.Vector2Int a1;
			checkValueType(l,1,out a1);
			UnityEngine.Vector2Int a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.Vector2Int.Max(a1,a2);
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
	static public int Scale_s(IntPtr l) {
		try {
			UnityEngine.Vector2Int a1;
			checkValueType(l,1,out a1);
			UnityEngine.Vector2Int a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.Vector2Int.Scale(a1,a2);
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
	static public int op_Implicit_s(IntPtr l) {
		try {
			UnityEngine.Vector2Int a1;
			checkValueType(l,1,out a1);
			UnityEngine.Vector2 ret=a1;
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
	static public int op_Explicit_s(IntPtr l) {
		try {
			UnityEngine.Vector2Int a1;
			checkValueType(l,1,out a1);
			var ret=(UnityEngine.Vector3Int)a1;
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
	static public int FloorToInt_s(IntPtr l) {
		try {
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Vector2Int.FloorToInt(a1);
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
	static public int CeilToInt_s(IntPtr l) {
		try {
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Vector2Int.CeilToInt(a1);
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
	static public int RoundToInt_s(IntPtr l) {
		try {
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Vector2Int.RoundToInt(a1);
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
	static public int op_Addition_s(IntPtr l) {
		try {
			UnityEngine.Vector2Int a1;
			checkValueType(l,1,out a1);
			UnityEngine.Vector2Int a2;
			checkValueType(l,2,out a2);
			var ret=a1+a2;
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
	static public int op_Subtraction_s(IntPtr l) {
		try {
			UnityEngine.Vector2Int a1;
			checkValueType(l,1,out a1);
			UnityEngine.Vector2Int a2;
			checkValueType(l,2,out a2);
			var ret=a1-a2;
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
	static public int op_Multiply__Vector2Int__Vector2Int_s(IntPtr l) {
		try {
			UnityEngine.Vector2Int a1;
			checkValueType(l,1,out a1);
			UnityEngine.Vector2Int a2;
			checkValueType(l,2,out a2);
			var ret=a1*a2;
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
	static public int op_Multiply__Vector2Int__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector2Int a1;
			checkValueType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=a1*a2;
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
			UnityEngine.Vector2Int a1;
			checkValueType(l,1,out a1);
			UnityEngine.Vector2Int a2;
			checkValueType(l,2,out a2);
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
			UnityEngine.Vector2Int a1;
			checkValueType(l,1,out a1);
			UnityEngine.Vector2Int a2;
			checkValueType(l,2,out a2);
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
	static public int get_x(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.x);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_x(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.x=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_y(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.y);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_y(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.y=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_magnitude(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.magnitude);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sqrMagnitude(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sqrMagnitude);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_zero(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Vector2Int.zero);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_one(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Vector2Int.one);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_up(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Vector2Int.up);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_down(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Vector2Int.down);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_left(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Vector2Int.left);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_right(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Vector2Int.right);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int getItem(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			var ret = self[v];
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
	static public int setItem(IntPtr l) {
		try {
			UnityEngine.Vector2Int self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			int c;
			checkType(l,3,out c);
			self[v]=c;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Vector2Int");
		addMember(l,ctor_s);
		addMember(l,ctor__Int32__Int32_s);
		addMember(l,Set);
		addMember(l,Scale);
		addMember(l,Clamp);
		addMember(l,Equals__Object);
		addMember(l,Equals__Vector2Int);
		addMember(l,ToString);
		addMember(l,Distance_s);
		addMember(l,Min_s);
		addMember(l,Max_s);
		addMember(l,Scale_s);
		addMember(l,op_Implicit_s);
		addMember(l,op_Explicit_s);
		addMember(l,FloorToInt_s);
		addMember(l,CeilToInt_s);
		addMember(l,RoundToInt_s);
		addMember(l,op_Addition_s);
		addMember(l,op_Subtraction_s);
		addMember(l,op_Multiply__Vector2Int__Vector2Int_s);
		addMember(l,op_Multiply__Vector2Int__Int32_s);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,getItem);
		addMember(l,setItem);
		addMember(l,"x",get_x,set_x,true);
		addMember(l,"y",get_y,set_y,true);
		addMember(l,"magnitude",get_magnitude,null,true);
		addMember(l,"sqrMagnitude",get_sqrMagnitude,null,true);
		addMember(l,"zero",get_zero,null,false);
		addMember(l,"one",get_one,null,false);
		addMember(l,"up",get_up,null,false);
		addMember(l,"down",get_down,null,false);
		addMember(l,"left",get_left,null,false);
		addMember(l,"right",get_right,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Vector2Int),typeof(System.ValueType));
	}
}
