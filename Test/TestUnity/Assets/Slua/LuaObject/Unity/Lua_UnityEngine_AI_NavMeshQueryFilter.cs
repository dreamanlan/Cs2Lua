using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_NavMeshQueryFilter : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshQueryFilter o;
			o=new UnityEngine.AI.NavMeshQueryFilter();
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
	static public int GetAreaCost(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshQueryFilter self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetAreaCost(a1);
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
	static public int SetAreaCost(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshQueryFilter self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetAreaCost(a1,a2);
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
	static public int get_areaMask(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshQueryFilter self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.areaMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_areaMask(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshQueryFilter self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.areaMask=v;
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
	static public int get_agentTypeID(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshQueryFilter self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.agentTypeID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_agentTypeID(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshQueryFilter self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.agentTypeID=v;
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
		getTypeTable(l,"UnityEngine.AI.NavMeshQueryFilter");
		addMember(l,GetAreaCost);
		addMember(l,SetAreaCost);
		addMember(l,"areaMask",get_areaMask,set_areaMask,true);
		addMember(l,"agentTypeID",get_agentTypeID,set_agentTypeID,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AI.NavMeshQueryFilter),typeof(System.ValueType));
	}
}
