using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_NavMeshLinkInstance : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkInstance o;
			o=new UnityEngine.AI.NavMeshLinkInstance();
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
	static public int Remove(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkInstance self;
			checkValueType(l,1,out self);
			self.Remove();
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
	static public int get_valid(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkInstance self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.valid);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_owner(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkInstance self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.owner);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_owner(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshLinkInstance self;
			checkValueType(l,1,out self);
			UnityEngine.Object v;
			checkType(l,2,out v);
			self.owner=v;
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
		getTypeTable(l,"UnityEngine.AI.NavMeshLinkInstance");
		addMember(l,Remove);
		addMember(l,"valid",get_valid,null,true);
		addMember(l,"owner",get_owner,set_owner,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AI.NavMeshLinkInstance),typeof(System.ValueType));
	}
}
