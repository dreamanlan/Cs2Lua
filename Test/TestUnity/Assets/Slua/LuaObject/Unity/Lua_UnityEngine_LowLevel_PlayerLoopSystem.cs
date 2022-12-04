using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_LowLevel_PlayerLoopSystem : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.LowLevel.PlayerLoopSystem o;
			o=new UnityEngine.LowLevel.PlayerLoopSystem();
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
			UnityEngine.LowLevel.PlayerLoopSystem self;
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
	static public int get_type(IntPtr l) {
		try {
			UnityEngine.LowLevel.PlayerLoopSystem self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_type(IntPtr l) {
		try {
			UnityEngine.LowLevel.PlayerLoopSystem self;
			checkValueType(l,1,out self);
			System.Type v;
			checkType(l,2,out v);
			self.type=v;
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
	static public int get_subSystemList(IntPtr l) {
		try {
			UnityEngine.LowLevel.PlayerLoopSystem self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.subSystemList);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_subSystemList(IntPtr l) {
		try {
			UnityEngine.LowLevel.PlayerLoopSystem self;
			checkValueType(l,1,out self);
			UnityEngine.LowLevel.PlayerLoopSystem[] v;
			checkArray(l,2,out v);
			self.subSystemList=v;
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
	static public int set_updateDelegate(IntPtr l) {
		try {
			UnityEngine.LowLevel.PlayerLoopSystem self;
			checkValueType(l,1,out self);
			UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.updateDelegate=v;
			else if(op==1) self.updateDelegate+=v;
			else if(op==2) self.updateDelegate-=v;
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
	static public int get_updateFunction(IntPtr l) {
		try {
			UnityEngine.LowLevel.PlayerLoopSystem self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.updateFunction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_updateFunction(IntPtr l) {
		try {
			UnityEngine.LowLevel.PlayerLoopSystem self;
			checkValueType(l,1,out self);
			System.IntPtr v;
			checkType(l,2,out v);
			self.updateFunction=v;
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
	static public int get_loopConditionFunction(IntPtr l) {
		try {
			UnityEngine.LowLevel.PlayerLoopSystem self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.loopConditionFunction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_loopConditionFunction(IntPtr l) {
		try {
			UnityEngine.LowLevel.PlayerLoopSystem self;
			checkValueType(l,1,out self);
			System.IntPtr v;
			checkType(l,2,out v);
			self.loopConditionFunction=v;
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
		getTypeTable(l,"UnityEngine.LowLevel.PlayerLoopSystem");
		addMember(l,ctor_s);
		addMember(l,ToString);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"subSystemList",get_subSystemList,set_subSystemList,true);
		addMember(l,"updateDelegate",null,set_updateDelegate,true);
		addMember(l,"updateFunction",get_updateFunction,set_updateFunction,true);
		addMember(l,"loopConditionFunction",get_loopConditionFunction,set_loopConditionFunction,true);
		createTypeMetatable(l,null, typeof(UnityEngine.LowLevel.PlayerLoopSystem),typeof(System.ValueType));
	}
}
