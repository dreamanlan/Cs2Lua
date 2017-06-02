using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_NavMeshObstacle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_height(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_height(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.height=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_radius(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.radius);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_radius(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.radius=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_velocity(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.velocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_velocity(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.velocity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_carving(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.carving);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_carving(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.carving=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_carveOnlyStationary(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.carveOnlyStationary);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_carveOnlyStationary(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.carveOnlyStationary=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_carvingMoveThreshold(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.carvingMoveThreshold);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_carvingMoveThreshold(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.carvingMoveThreshold=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_carvingTimeToStationary(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.carvingTimeToStationary);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_carvingTimeToStationary(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.carvingTimeToStationary=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_shape(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.shape);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shape(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			UnityEngine.AI.NavMeshObstacleShape v;
			checkEnum(l,2,out v);
			self.shape=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_center(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.center);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_center(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.center=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_size(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.size);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_size(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshObstacle self=(UnityEngine.AI.NavMeshObstacle)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.size=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AI.NavMeshObstacle");
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"radius",get_radius,set_radius,true);
		addMember(l,"velocity",get_velocity,set_velocity,true);
		addMember(l,"carving",get_carving,set_carving,true);
		addMember(l,"carveOnlyStationary",get_carveOnlyStationary,set_carveOnlyStationary,true);
		addMember(l,"carvingMoveThreshold",get_carvingMoveThreshold,set_carvingMoveThreshold,true);
		addMember(l,"carvingTimeToStationary",get_carvingTimeToStationary,set_carvingTimeToStationary,true);
		addMember(l,"shape",get_shape,set_shape,true);
		addMember(l,"center",get_center,set_center,true);
		addMember(l,"size",get_size,set_size,true);
		createTypeMetatable(l,null, typeof(UnityEngine.AI.NavMeshObstacle),typeof(UnityEngine.Behaviour));
	}
}
