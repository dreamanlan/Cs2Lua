using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_OffMeshLinkData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLinkData o;
			o=new UnityEngine.AI.OffMeshLinkData();
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
	static public int get_valid(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLinkData self;
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
	static public int get_activated(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLinkData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.activated);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_linkType(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLinkData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.linkType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_startPos(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLinkData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.startPos);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_endPos(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLinkData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.endPos);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_offMeshLink(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLinkData self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.offMeshLink);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AI.OffMeshLinkData");
		addMember(l,"valid",get_valid,null,true);
		addMember(l,"activated",get_activated,null,true);
		addMember(l,"linkType",get_linkType,null,true);
		addMember(l,"startPos",get_startPos,null,true);
		addMember(l,"endPos",get_endPos,null,true);
		addMember(l,"offMeshLink",get_offMeshLink,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AI.OffMeshLinkData),typeof(System.ValueType));
	}
}
