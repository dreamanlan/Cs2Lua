using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_NavMeshBuildMarkup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildMarkup o;
			o=new UnityEngine.AI.NavMeshBuildMarkup();
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
	static public int get_overrideArea(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildMarkup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.overrideArea);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overrideArea(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildMarkup self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.overrideArea=v;
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
			UnityEngine.AI.NavMeshBuildMarkup self;
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
			UnityEngine.AI.NavMeshBuildMarkup self;
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
	static public int get_ignoreFromBuild(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildMarkup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.ignoreFromBuild);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_ignoreFromBuild(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildMarkup self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.ignoreFromBuild=v;
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
	static public int get_root(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildMarkup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.root);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_root(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildMarkup self;
			checkValueType(l,1,out self);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.root=v;
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
		getTypeTable(l,"UnityEngine.AI.NavMeshBuildMarkup");
		addMember(l,"overrideArea",get_overrideArea,set_overrideArea,true);
		addMember(l,"area",get_area,set_area,true);
		addMember(l,"ignoreFromBuild",get_ignoreFromBuild,set_ignoreFromBuild,true);
		addMember(l,"root",get_root,set_root,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AI.NavMeshBuildMarkup),typeof(System.ValueType));
	}
}
