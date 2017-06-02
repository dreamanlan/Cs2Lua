using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Cloth : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClearTransformMotion(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			self.ClearTransformMotion();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetEnabledFading(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.SetEnabledFading(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetEnabledFading(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sleepThreshold(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sleepThreshold);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sleepThreshold(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.sleepThreshold=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bendingStiffness(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bendingStiffness);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bendingStiffness(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.bendingStiffness=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_stretchingStiffness(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stretchingStiffness);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stretchingStiffness(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.stretchingStiffness=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_damping(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.damping);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_damping(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.damping=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_externalAcceleration(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.externalAcceleration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_externalAcceleration(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.externalAcceleration=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_randomAcceleration(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.randomAcceleration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_randomAcceleration(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.randomAcceleration=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useGravity(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useGravity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useGravity(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useGravity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enabled(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_vertices(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.vertices);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_normals(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.normals);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_friction(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.friction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_friction(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.friction=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_collisionMassScale(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.collisionMassScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_collisionMassScale(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.collisionMassScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useContinuousCollision(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useContinuousCollision);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useContinuousCollision(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.useContinuousCollision=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_useVirtualParticles(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useVirtualParticles);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_useVirtualParticles(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.useVirtualParticles=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_coefficients(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.coefficients);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_coefficients(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			UnityEngine.ClothSkinningCoefficient[] v;
			checkArray(l,2,out v);
			self.coefficients=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_worldVelocityScale(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.worldVelocityScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_worldVelocityScale(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.worldVelocityScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_worldAccelerationScale(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.worldAccelerationScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_worldAccelerationScale(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.worldAccelerationScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_solverFrequency(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.solverFrequency);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_solverFrequency(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.solverFrequency=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_capsuleColliders(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.capsuleColliders);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_capsuleColliders(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			UnityEngine.CapsuleCollider[] v;
			checkArray(l,2,out v);
			self.capsuleColliders=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sphereColliders(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sphereColliders);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sphereColliders(IntPtr l) {
		try {
			UnityEngine.Cloth self=(UnityEngine.Cloth)checkSelf(l);
			UnityEngine.ClothSphereColliderPair[] v;
			checkArray(l,2,out v);
			self.sphereColliders=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Cloth");
		addMember(l,ClearTransformMotion);
		addMember(l,SetEnabledFading);
		addMember(l,"sleepThreshold",get_sleepThreshold,set_sleepThreshold,true);
		addMember(l,"bendingStiffness",get_bendingStiffness,set_bendingStiffness,true);
		addMember(l,"stretchingStiffness",get_stretchingStiffness,set_stretchingStiffness,true);
		addMember(l,"damping",get_damping,set_damping,true);
		addMember(l,"externalAcceleration",get_externalAcceleration,set_externalAcceleration,true);
		addMember(l,"randomAcceleration",get_randomAcceleration,set_randomAcceleration,true);
		addMember(l,"useGravity",get_useGravity,set_useGravity,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"vertices",get_vertices,null,true);
		addMember(l,"normals",get_normals,null,true);
		addMember(l,"friction",get_friction,set_friction,true);
		addMember(l,"collisionMassScale",get_collisionMassScale,set_collisionMassScale,true);
		addMember(l,"useContinuousCollision",get_useContinuousCollision,set_useContinuousCollision,true);
		addMember(l,"useVirtualParticles",get_useVirtualParticles,set_useVirtualParticles,true);
		addMember(l,"coefficients",get_coefficients,set_coefficients,true);
		addMember(l,"worldVelocityScale",get_worldVelocityScale,set_worldVelocityScale,true);
		addMember(l,"worldAccelerationScale",get_worldAccelerationScale,set_worldAccelerationScale,true);
		addMember(l,"solverFrequency",get_solverFrequency,set_solverFrequency,true);
		addMember(l,"capsuleColliders",get_capsuleColliders,set_capsuleColliders,true);
		addMember(l,"sphereColliders",get_sphereColliders,set_sphereColliders,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Cloth),typeof(UnityEngine.Component));
	}
}
