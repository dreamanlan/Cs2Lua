using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_OffMeshLink : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int UpdatePositions(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			self.UpdatePositions();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_activated(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
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
	static public int set_activated(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.activated=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_occupied(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.occupied);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_costOverride(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.costOverride);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_costOverride(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.costOverride=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_biDirectional(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.biDirectional);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_biDirectional(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.biDirectional=v;
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
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
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
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.area=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autoUpdatePositions(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoUpdatePositions);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_autoUpdatePositions(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoUpdatePositions=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_startTransform(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startTransform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_startTransform(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.startTransform=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_endTransform(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.endTransform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_endTransform(IntPtr l) {
		try {
			UnityEngine.AI.OffMeshLink self=(UnityEngine.AI.OffMeshLink)checkSelf(l);
			UnityEngine.Transform v;
			checkType(l,2,out v);
			self.endTransform=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AI.OffMeshLink");
		addMember(l,UpdatePositions);
		addMember(l,"activated",get_activated,set_activated,true);
		addMember(l,"occupied",get_occupied,null,true);
		addMember(l,"costOverride",get_costOverride,set_costOverride,true);
		addMember(l,"biDirectional",get_biDirectional,set_biDirectional,true);
		addMember(l,"area",get_area,set_area,true);
		addMember(l,"autoUpdatePositions",get_autoUpdatePositions,set_autoUpdatePositions,true);
		addMember(l,"startTransform",get_startTransform,set_startTransform,true);
		addMember(l,"endTransform",get_endTransform,set_endTransform,true);
		createTypeMetatable(l,null, typeof(UnityEngine.AI.OffMeshLink),typeof(UnityEngine.Behaviour));
	}
}
