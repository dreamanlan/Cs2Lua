using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_StencilState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState o;
			o=new UnityEngine.Rendering.StencilState();
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
	static public int ctor__Boolean__Byte__Byte__CompareFunction__StencilOp__StencilOp__StencilOp_s(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState o;
			System.Boolean a1;
			checkType(l,1,out a1);
			System.Byte a2;
			checkType(l,2,out a2);
			System.Byte a3;
			checkType(l,3,out a3);
			UnityEngine.Rendering.CompareFunction a4;
			checkEnum(l,4,out a4);
			UnityEngine.Rendering.StencilOp a5;
			checkEnum(l,5,out a5);
			UnityEngine.Rendering.StencilOp a6;
			checkEnum(l,6,out a6);
			UnityEngine.Rendering.StencilOp a7;
			checkEnum(l,7,out a7);
			o=new UnityEngine.Rendering.StencilState(a1,a2,a3,a4,a5,a6,a7);
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
	static public int ctor__Boolean__Byte__Byte__CompareFunction__StencilOp__StencilOp__StencilOp__CompareFunction__StencilOp__StencilOp__StencilOp_s(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState o;
			System.Boolean a1;
			checkType(l,1,out a1);
			System.Byte a2;
			checkType(l,2,out a2);
			System.Byte a3;
			checkType(l,3,out a3);
			UnityEngine.Rendering.CompareFunction a4;
			checkEnum(l,4,out a4);
			UnityEngine.Rendering.StencilOp a5;
			checkEnum(l,5,out a5);
			UnityEngine.Rendering.StencilOp a6;
			checkEnum(l,6,out a6);
			UnityEngine.Rendering.StencilOp a7;
			checkEnum(l,7,out a7);
			UnityEngine.Rendering.CompareFunction a8;
			checkEnum(l,8,out a8);
			UnityEngine.Rendering.StencilOp a9;
			checkEnum(l,9,out a9);
			UnityEngine.Rendering.StencilOp a10;
			checkEnum(l,10,out a10);
			UnityEngine.Rendering.StencilOp a11;
			checkEnum(l,11,out a11);
			o=new UnityEngine.Rendering.StencilState(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
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
	static public int SetCompareFunction(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CompareFunction a1;
			checkEnum(l,2,out a1);
			self.SetCompareFunction(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetPassOperation(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp a1;
			checkEnum(l,2,out a1);
			self.SetPassOperation(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFailOperation(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp a1;
			checkEnum(l,2,out a1);
			self.SetFailOperation(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetZFailOperation(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp a1;
			checkEnum(l,2,out a1);
			self.SetZFailOperation(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Equals__StencilState(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilState a1;
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
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
	static public int op_Equality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.StencilState a2;
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
			UnityEngine.Rendering.StencilState a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.StencilState a2;
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
	static public int get_defaultValue(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.StencilState.defaultValue);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enabled(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_readMask(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.readMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_readMask(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			System.Byte v;
			checkType(l,2,out v);
			self.readMask=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_writeMask(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.writeMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_writeMask(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			System.Byte v;
			checkType(l,2,out v);
			self.writeMask=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_compareFunctionFront(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.compareFunctionFront);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_compareFunctionFront(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CompareFunction v;
			checkEnum(l,2,out v);
			self.compareFunctionFront=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_passOperationFront(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.passOperationFront);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_passOperationFront(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.passOperationFront=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_failOperationFront(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.failOperationFront);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_failOperationFront(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.failOperationFront=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_zFailOperationFront(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.zFailOperationFront);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_zFailOperationFront(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.zFailOperationFront=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_compareFunctionBack(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.compareFunctionBack);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_compareFunctionBack(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CompareFunction v;
			checkEnum(l,2,out v);
			self.compareFunctionBack=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_passOperationBack(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.passOperationBack);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_passOperationBack(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.passOperationBack=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_failOperationBack(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.failOperationBack);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_failOperationBack(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.failOperationBack=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_zFailOperationBack(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.zFailOperationBack);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_zFailOperationBack(IntPtr l) {
		try {
			UnityEngine.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.zFailOperationBack=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.StencilState");
		addMember(l,ctor_s);
		addMember(l,ctor__Boolean__Byte__Byte__CompareFunction__StencilOp__StencilOp__StencilOp_s);
		addMember(l,ctor__Boolean__Byte__Byte__CompareFunction__StencilOp__StencilOp__StencilOp__CompareFunction__StencilOp__StencilOp__StencilOp_s);
		addMember(l,SetCompareFunction);
		addMember(l,SetPassOperation);
		addMember(l,SetFailOperation);
		addMember(l,SetZFailOperation);
		addMember(l,Equals__StencilState);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"defaultValue",get_defaultValue,null,false);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"readMask",get_readMask,set_readMask,true);
		addMember(l,"writeMask",get_writeMask,set_writeMask,true);
		addMember(l,"compareFunctionFront",get_compareFunctionFront,set_compareFunctionFront,true);
		addMember(l,"passOperationFront",get_passOperationFront,set_passOperationFront,true);
		addMember(l,"failOperationFront",get_failOperationFront,set_failOperationFront,true);
		addMember(l,"zFailOperationFront",get_zFailOperationFront,set_zFailOperationFront,true);
		addMember(l,"compareFunctionBack",get_compareFunctionBack,set_compareFunctionBack,true);
		addMember(l,"passOperationBack",get_passOperationBack,set_passOperationBack,true);
		addMember(l,"failOperationBack",get_failOperationBack,set_failOperationBack,true);
		addMember(l,"zFailOperationBack",get_zFailOperationBack,set_zFailOperationBack,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.StencilState),typeof(System.ValueType));
	}
}
