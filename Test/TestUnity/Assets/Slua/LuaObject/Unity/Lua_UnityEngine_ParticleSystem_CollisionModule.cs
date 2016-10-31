using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystem_CollisionModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule o;
			o=new UnityEngine.ParticleSystem.CollisionModule();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPlane(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Transform a2;
			checkType(l,3,out a2);
			self.SetPlane(a1,a2);
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPlane(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPlane(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.enabled);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystemCollisionType v;
			checkEnum(l,2,out v);
			self.type=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mode(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mode(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystemCollisionMode v;
			checkEnum(l,2,out v);
			self.mode=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dampen(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.dampen);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dampen(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.MinMaxCurve v;
			checkValueType(l,2,out v);
			self.dampen=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounce(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.bounce);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bounce(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.MinMaxCurve v;
			checkValueType(l,2,out v);
			self.bounce=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lifetimeLoss(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.lifetimeLoss);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lifetimeLoss(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystem.MinMaxCurve v;
			checkValueType(l,2,out v);
			self.lifetimeLoss=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minKillSpeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.minKillSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minKillSpeed(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.minKillSpeed=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collidesWith(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.collidesWith);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collidesWith(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			UnityEngine.LayerMask v;
			checkValueType(l,2,out v);
			self.collidesWith=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enableDynamicColliders(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.enableDynamicColliders);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enableDynamicColliders(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.enableDynamicColliders=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enableInteriorCollisions(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.enableInteriorCollisions);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enableInteriorCollisions(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.enableInteriorCollisions=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxCollisionShapes(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.maxCollisionShapes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxCollisionShapes(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.maxCollisionShapes=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_quality(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.quality);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_quality(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			UnityEngine.ParticleSystemCollisionQuality v;
			checkEnum(l,2,out v);
			self.quality=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_voxelSize(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.voxelSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_voxelSize(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.voxelSize=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radiusScale(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.radiusScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radiusScale(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.radiusScale=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sendCollisionMessages(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sendCollisionMessages);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sendCollisionMessages(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.sendCollisionMessages=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxPlaneCount(IntPtr l) {
		try {
			UnityEngine.ParticleSystem.CollisionModule self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.maxPlaneCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystem.CollisionModule");
		addMember(l,SetPlane);
		addMember(l,GetPlane);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"dampen",get_dampen,set_dampen,true);
		addMember(l,"bounce",get_bounce,set_bounce,true);
		addMember(l,"lifetimeLoss",get_lifetimeLoss,set_lifetimeLoss,true);
		addMember(l,"minKillSpeed",get_minKillSpeed,set_minKillSpeed,true);
		addMember(l,"collidesWith",get_collidesWith,set_collidesWith,true);
		addMember(l,"enableDynamicColliders",get_enableDynamicColliders,set_enableDynamicColliders,true);
		addMember(l,"enableInteriorCollisions",get_enableInteriorCollisions,set_enableInteriorCollisions,true);
		addMember(l,"maxCollisionShapes",get_maxCollisionShapes,set_maxCollisionShapes,true);
		addMember(l,"quality",get_quality,set_quality,true);
		addMember(l,"voxelSize",get_voxelSize,set_voxelSize,true);
		addMember(l,"radiusScale",get_radiusScale,set_radiusScale,true);
		addMember(l,"sendCollisionMessages",get_sendCollisionMessages,set_sendCollisionMessages,true);
		addMember(l,"maxPlaneCount",get_maxPlaneCount,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystem.CollisionModule),typeof(System.ValueType));
	}
}
