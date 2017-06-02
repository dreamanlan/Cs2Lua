using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_NavMeshLinkData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData o;
			o=new UnityEngine.AI.NavMeshLinkData();
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
	static public int get_startPosition(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.startPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_startPosition(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.startPosition=v;
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
	static public int get_endPosition(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.endPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_endPosition(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.endPosition=v;
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
	static public int get_costModifier(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.costModifier);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_costModifier(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.costModifier=v;
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
	static public int get_bidirectional(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.bidirectional);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bidirectional(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.bidirectional=v;
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
	static public int get_width(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.width);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_width(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.width=v;
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
	static public int get_area(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.area);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_area(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkData self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.area=v;
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
			UnityEngine.AI.NavMeshLinkData self;
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
			UnityEngine.AI.NavMeshLinkData self;
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
		getTypeTable(l,"UnityEngine.AI.NavMeshLinkData");
		addMember(l,"startPosition",get_startPosition,set_startPosition,true);
		addMember(l,"endPosition",get_endPosition,set_endPosition,true);
		addMember(l,"costModifier",get_costModifier,set_costModifier,true);
		addMember(l,"bidirectional",get_bidirectional,set_bidirectional,true);
		addMember(l,"width",get_width,set_width,true);
		addMember(l,"area",get_area,set_area,true);
		addMember(l,"agentTypeID",get_agentTypeID,set_agentTypeID,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AI.NavMeshLinkData),typeof(System.ValueType));
	}
}
