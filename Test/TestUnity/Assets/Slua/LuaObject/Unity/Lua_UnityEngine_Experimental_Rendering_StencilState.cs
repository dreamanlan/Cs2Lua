using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Rendering_StencilState : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Experimental.Rendering.StencilState o;
			if(argc==13){
				System.Boolean a1;
				checkType(l,3,out a1);
				System.Byte a2;
				checkType(l,4,out a2);
				System.Byte a3;
				checkType(l,5,out a3);
				UnityEngine.Rendering.CompareFunction a4;
				checkEnum(l,6,out a4);
				UnityEngine.Rendering.StencilOp a5;
				checkEnum(l,7,out a5);
				UnityEngine.Rendering.StencilOp a6;
				checkEnum(l,8,out a6);
				UnityEngine.Rendering.StencilOp a7;
				checkEnum(l,9,out a7);
				UnityEngine.Rendering.CompareFunction a8;
				checkEnum(l,10,out a8);
				UnityEngine.Rendering.StencilOp a9;
				checkEnum(l,11,out a9);
				UnityEngine.Rendering.StencilOp a10;
				checkEnum(l,12,out a10);
				UnityEngine.Rendering.StencilOp a11;
				checkEnum(l,13,out a11);
				o=new UnityEngine.Experimental.Rendering.StencilState(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==9){
				System.Boolean a1;
				checkType(l,3,out a1);
				System.Byte a2;
				checkType(l,4,out a2);
				System.Byte a3;
				checkType(l,5,out a3);
				UnityEngine.Rendering.CompareFunction a4;
				checkEnum(l,6,out a4);
				UnityEngine.Rendering.StencilOp a5;
				checkEnum(l,7,out a5);
				UnityEngine.Rendering.StencilOp a6;
				checkEnum(l,8,out a6);
				UnityEngine.Rendering.StencilOp a7;
				checkEnum(l,9,out a7);
				o=new UnityEngine.Experimental.Rendering.StencilState(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc<=1){
				o=new UnityEngine.Experimental.Rendering.StencilState();
				pushValue(l,true);
				pushObject(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Default(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.Rendering.StencilState.Default);
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
			UnityEngine.Experimental.Rendering.StencilState self;
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
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
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
	static public int get_readMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
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
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			System.Byte v;
			checkType(l,2,out v);
			self.readMask=v;
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
	static public int get_writeMask(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
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
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			System.Byte v;
			checkType(l,2,out v);
			self.writeMask=v;
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
	static public int set_compareFunction(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CompareFunction v;
			checkEnum(l,2,out v);
			self.compareFunction=v;
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
	static public int set_passOperation(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.passOperation=v;
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
	static public int set_failOperation(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.failOperation=v;
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
	static public int set_zFailOperation(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.zFailOperation=v;
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
	static public int get_compareFunctionFront(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
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
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CompareFunction v;
			checkEnum(l,2,out v);
			self.compareFunctionFront=v;
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
	static public int get_passOperationFront(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
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
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.passOperationFront=v;
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
	static public int get_failOperationFront(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
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
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.failOperationFront=v;
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
	static public int get_zFailOperationFront(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
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
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.zFailOperationFront=v;
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
	static public int get_compareFunctionBack(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
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
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.CompareFunction v;
			checkEnum(l,2,out v);
			self.compareFunctionBack=v;
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
	static public int get_passOperationBack(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
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
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.passOperationBack=v;
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
	static public int get_failOperationBack(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
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
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.failOperationBack=v;
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
	static public int get_zFailOperationBack(IntPtr l) {
		try {
			UnityEngine.Experimental.Rendering.StencilState self;
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
			UnityEngine.Experimental.Rendering.StencilState self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.StencilOp v;
			checkEnum(l,2,out v);
			self.zFailOperationBack=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Rendering.StencilState");
		addMember(l,"Default",get_Default,null,false);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"readMask",get_readMask,set_readMask,true);
		addMember(l,"writeMask",get_writeMask,set_writeMask,true);
		addMember(l,"compareFunction",null,set_compareFunction,true);
		addMember(l,"passOperation",null,set_passOperation,true);
		addMember(l,"failOperation",null,set_failOperation,true);
		addMember(l,"zFailOperation",null,set_zFailOperation,true);
		addMember(l,"compareFunctionFront",get_compareFunctionFront,set_compareFunctionFront,true);
		addMember(l,"passOperationFront",get_passOperationFront,set_passOperationFront,true);
		addMember(l,"failOperationFront",get_failOperationFront,set_failOperationFront,true);
		addMember(l,"zFailOperationFront",get_zFailOperationFront,set_zFailOperationFront,true);
		addMember(l,"compareFunctionBack",get_compareFunctionBack,set_compareFunctionBack,true);
		addMember(l,"passOperationBack",get_passOperationBack,set_passOperationBack,true);
		addMember(l,"failOperationBack",get_failOperationBack,set_failOperationBack,true);
		addMember(l,"zFailOperationBack",get_zFailOperationBack,set_zFailOperationBack,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Rendering.StencilState),typeof(System.ValueType));
	}
}
