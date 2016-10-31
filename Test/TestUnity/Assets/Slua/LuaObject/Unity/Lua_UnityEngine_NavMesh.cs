using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMesh : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.NavMesh o;
			o=new UnityEngine.NavMesh();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.NavMeshHit a3;
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.NavMesh.Raycast(a1,a2,out a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculatePath_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.NavMeshPath a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.NavMesh.CalculatePath(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindClosestEdge_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.NavMeshHit a2;
			System.Int32 a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.NavMesh.FindClosestEdge(a1,out a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SamplePosition_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.NavMeshHit a2;
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.NavMesh.SamplePosition(a1,out a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetAreaCost_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.NavMesh.SetAreaCost(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAreaCost_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.NavMesh.GetAreaCost(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAreaFromName_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.NavMesh.GetAreaFromName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CalculateTriangulation_s(IntPtr l) {
		try {
			var ret=UnityEngine.NavMesh.CalculateTriangulation();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_AllAreas(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.NavMesh.AllAreas);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_avoidancePredictionTime(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.NavMesh.avoidancePredictionTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_avoidancePredictionTime(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.NavMesh.avoidancePredictionTime=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pathfindingIterationsPerFrame(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.NavMesh.pathfindingIterationsPerFrame);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pathfindingIterationsPerFrame(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.NavMesh.pathfindingIterationsPerFrame=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMesh");
		addMember(l,Raycast_s);
		addMember(l,CalculatePath_s);
		addMember(l,FindClosestEdge_s);
		addMember(l,SamplePosition_s);
		addMember(l,SetAreaCost_s);
		addMember(l,GetAreaCost_s);
		addMember(l,GetAreaFromName_s);
		addMember(l,CalculateTriangulation_s);
		addMember(l,"AllAreas",get_AllAreas,null,false);
		addMember(l,"avoidancePredictionTime",get_avoidancePredictionTime,set_avoidancePredictionTime,false);
		addMember(l,"pathfindingIterationsPerFrame",get_pathfindingIterationsPerFrame,set_pathfindingIterationsPerFrame,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMesh));
	}
}
