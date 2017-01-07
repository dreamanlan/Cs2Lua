using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshAgent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent o;
			o=new UnityEngine.NavMeshAgent();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetDestination(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.SetDestination(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ActivateCurrentOffMeshLink(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.ActivateCurrentOffMeshLink(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CompleteOffMeshLink(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			self.CompleteOffMeshLink();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Warp(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.Warp(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Move(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.Move(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Stop(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			self.Stop();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Resume(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			self.Resume();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetPath(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			self.ResetPath();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPath(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.NavMeshPath a1;
			checkType(l,2,out a1);
			var ret=self.SetPath(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int FindClosestEdge(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.NavMeshHit a1;
			var ret=self.FindClosestEdge(out a1);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a1);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Raycast(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.NavMeshHit a2;
			var ret=self.Raycast(a1,out a2);
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
	static public int CalculatePath(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			UnityEngine.NavMeshPath a2;
			checkType(l,3,out a2);
			var ret=self.CalculatePath(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SamplePathPosition(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			UnityEngine.NavMeshHit a3;
			var ret=self.SamplePathPosition(a1,a2,out a3);
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
	static public int SetAreaCost(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetAreaCost(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAreaCost(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
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
	static public int get_destination(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.destination);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_destination(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.destination=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stoppingDistance(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stoppingDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stoppingDistance(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.stoppingDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocity(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.velocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
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
	static public int get_nextPosition(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.nextPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nextPosition(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.nextPosition=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_steeringTarget(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.steeringTarget);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_desiredVelocity(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.desiredVelocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_remainingDistance(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.remainingDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_baseOffset(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.baseOffset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_baseOffset(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.baseOffset=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOnOffMeshLink(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isOnOffMeshLink);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_currentOffMeshLinkData(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currentOffMeshLinkData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nextOffMeshLinkData(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.nextOffMeshLinkData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoTraverseOffMeshLink(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoTraverseOffMeshLink);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoTraverseOffMeshLink(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoTraverseOffMeshLink=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoBraking(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoBraking);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoBraking(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoBraking=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_autoRepath(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoRepath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_autoRepath(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoRepath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasPath(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pathPending(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pathPending);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isPathStale(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isPathStale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pathStatus(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.pathStatus);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pathEndPosition(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pathEndPosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_path(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.path);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_path(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.NavMeshPath v;
			checkType(l,2,out v);
			self.path=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_areaMask(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.areaMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_areaMask(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.areaMask=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.speed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.speed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularSpeed(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.angularSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularSpeed(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.angularSpeed=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_acceleration(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.acceleration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_acceleration(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.acceleration=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updatePosition(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.updatePosition);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updatePosition(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.updatePosition=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateRotation(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.updateRotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateRotation(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.updateRotation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.radius);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
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
	static public int get_height(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.height);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_height(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
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
	static public int get_obstacleAvoidanceType(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.obstacleAvoidanceType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_obstacleAvoidanceType(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			UnityEngine.ObstacleAvoidanceType v;
			checkEnum(l,2,out v);
			self.obstacleAvoidanceType=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_avoidancePriority(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.avoidancePriority);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_avoidancePriority(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.avoidancePriority=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOnNavMesh(IntPtr l) {
		try {
			UnityEngine.NavMeshAgent self=(UnityEngine.NavMeshAgent)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isOnNavMesh);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshAgent");
		addMember(l,SetDestination);
		addMember(l,ActivateCurrentOffMeshLink);
		addMember(l,CompleteOffMeshLink);
		addMember(l,Warp);
		addMember(l,Move);
		addMember(l,Stop);
		addMember(l,Resume);
		addMember(l,ResetPath);
		addMember(l,SetPath);
		addMember(l,FindClosestEdge);
		addMember(l,Raycast);
		addMember(l,CalculatePath);
		addMember(l,SamplePathPosition);
		addMember(l,SetAreaCost);
		addMember(l,GetAreaCost);
		addMember(l,"destination",get_destination,set_destination,true);
		addMember(l,"stoppingDistance",get_stoppingDistance,set_stoppingDistance,true);
		addMember(l,"velocity",get_velocity,set_velocity,true);
		addMember(l,"nextPosition",get_nextPosition,set_nextPosition,true);
		addMember(l,"steeringTarget",get_steeringTarget,null,true);
		addMember(l,"desiredVelocity",get_desiredVelocity,null,true);
		addMember(l,"remainingDistance",get_remainingDistance,null,true);
		addMember(l,"baseOffset",get_baseOffset,set_baseOffset,true);
		addMember(l,"isOnOffMeshLink",get_isOnOffMeshLink,null,true);
		addMember(l,"currentOffMeshLinkData",get_currentOffMeshLinkData,null,true);
		addMember(l,"nextOffMeshLinkData",get_nextOffMeshLinkData,null,true);
		addMember(l,"autoTraverseOffMeshLink",get_autoTraverseOffMeshLink,set_autoTraverseOffMeshLink,true);
		addMember(l,"autoBraking",get_autoBraking,set_autoBraking,true);
		addMember(l,"autoRepath",get_autoRepath,set_autoRepath,true);
		addMember(l,"hasPath",get_hasPath,null,true);
		addMember(l,"pathPending",get_pathPending,null,true);
		addMember(l,"isPathStale",get_isPathStale,null,true);
		addMember(l,"pathStatus",get_pathStatus,null,true);
		addMember(l,"pathEndPosition",get_pathEndPosition,null,true);
		addMember(l,"path",get_path,set_path,true);
		addMember(l,"areaMask",get_areaMask,set_areaMask,true);
		addMember(l,"speed",get_speed,set_speed,true);
		addMember(l,"angularSpeed",get_angularSpeed,set_angularSpeed,true);
		addMember(l,"acceleration",get_acceleration,set_acceleration,true);
		addMember(l,"updatePosition",get_updatePosition,set_updatePosition,true);
		addMember(l,"updateRotation",get_updateRotation,set_updateRotation,true);
		addMember(l,"radius",get_radius,set_radius,true);
		addMember(l,"height",get_height,set_height,true);
		addMember(l,"obstacleAvoidanceType",get_obstacleAvoidanceType,set_obstacleAvoidanceType,true);
		addMember(l,"avoidancePriority",get_avoidancePriority,set_avoidancePriority,true);
		addMember(l,"isOnNavMesh",get_isOnNavMesh,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMeshAgent),typeof(UnityEngine.Behaviour));
	}
}
