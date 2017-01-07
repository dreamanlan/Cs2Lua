using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rigidbody2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D o;
			o=new UnityEngine.Rigidbody2D();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MovePosition(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			self.MovePosition(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveRotation(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.MoveRotation(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsSleeping(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			var ret=self.IsSleeping();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsAwake(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			var ret=self.IsAwake();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Sleep(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			self.Sleep();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WakeUp(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			self.WakeUp();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsTouching(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Collider2D a1;
			checkType(l,2,out a1);
			var ret=self.IsTouching(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsTouchingLayers(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				var ret=self.IsTouchingLayers();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.IsTouchingLayers(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
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
	static public int AddForce(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				self.AddForce(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode2D a2;
				checkEnum(l,3,out a2);
				self.AddForce(a1,a2);
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
	static public int AddRelativeForce(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				self.AddRelativeForce(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode2D a2;
				checkEnum(l,3,out a2);
				self.AddRelativeForce(a1,a2);
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
	static public int AddForceAtPosition(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,3,out a2);
				self.AddForceAtPosition(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				UnityEngine.Vector2 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector2 a2;
				checkType(l,3,out a2);
				UnityEngine.ForceMode2D a3;
				checkEnum(l,4,out a3);
				self.AddForceAtPosition(a1,a2,a3);
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
	static public int AddTorque(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				self.AddTorque(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode2D a2;
				checkEnum(l,3,out a2);
				self.AddTorque(a1,a2);
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
	static public int GetPoint(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			var ret=self.GetPoint(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRelativePoint(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			var ret=self.GetRelativePoint(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetVector(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			var ret=self.GetVector(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRelativeVector(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			var ret=self.GetRelativeVector(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPointVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			var ret=self.GetPointVelocity(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRelativePointVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			var ret=self.GetRelativePointVelocity(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.position=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.rotation=v;
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
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
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
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 v;
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
	static public int get_angularVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.angularVelocity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.angularVelocity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useAutoMass(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.useAutoMass);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useAutoMass(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useAutoMass=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mass(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mass);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mass(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.mass=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_centerOfMass(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.centerOfMass);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_centerOfMass(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.centerOfMass=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldCenterOfMass(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.worldCenterOfMass);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inertia(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.inertia);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inertia(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.inertia=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drag(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.drag);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_drag(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.drag=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularDrag(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.angularDrag);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularDrag(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.angularDrag=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravityScale(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gravityScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_gravityScale(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.gravityScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isKinematic(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isKinematic);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isKinematic(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.isKinematic=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_freezeRotation(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.freezeRotation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_freezeRotation(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.freezeRotation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constraints(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.constraints);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_constraints(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.RigidbodyConstraints2D v;
			checkEnum(l,2,out v);
			self.constraints=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_simulated(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.simulated);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_simulated(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.simulated=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_interpolation(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.interpolation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_interpolation(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.RigidbodyInterpolation2D v;
			checkEnum(l,2,out v);
			self.interpolation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sleepMode(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.sleepMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sleepMode(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.RigidbodySleepMode2D v;
			checkEnum(l,2,out v);
			self.sleepMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collisionDetectionMode(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.collisionDetectionMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collisionDetectionMode(IntPtr l) {
		try {
			UnityEngine.Rigidbody2D self=(UnityEngine.Rigidbody2D)checkSelf(l);
			UnityEngine.CollisionDetectionMode2D v;
			checkEnum(l,2,out v);
			self.collisionDetectionMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rigidbody2D");
		addMember(l,MovePosition);
		addMember(l,MoveRotation);
		addMember(l,IsSleeping);
		addMember(l,IsAwake);
		addMember(l,Sleep);
		addMember(l,WakeUp);
		addMember(l,IsTouching);
		addMember(l,IsTouchingLayers);
		addMember(l,AddForce);
		addMember(l,AddRelativeForce);
		addMember(l,AddForceAtPosition);
		addMember(l,AddTorque);
		addMember(l,GetPoint);
		addMember(l,GetRelativePoint);
		addMember(l,GetVector);
		addMember(l,GetRelativeVector);
		addMember(l,GetPointVelocity);
		addMember(l,GetRelativePointVelocity);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"rotation",get_rotation,set_rotation,true);
		addMember(l,"velocity",get_velocity,set_velocity,true);
		addMember(l,"angularVelocity",get_angularVelocity,set_angularVelocity,true);
		addMember(l,"useAutoMass",get_useAutoMass,set_useAutoMass,true);
		addMember(l,"mass",get_mass,set_mass,true);
		addMember(l,"centerOfMass",get_centerOfMass,set_centerOfMass,true);
		addMember(l,"worldCenterOfMass",get_worldCenterOfMass,null,true);
		addMember(l,"inertia",get_inertia,set_inertia,true);
		addMember(l,"drag",get_drag,set_drag,true);
		addMember(l,"angularDrag",get_angularDrag,set_angularDrag,true);
		addMember(l,"gravityScale",get_gravityScale,set_gravityScale,true);
		addMember(l,"isKinematic",get_isKinematic,set_isKinematic,true);
		addMember(l,"freezeRotation",get_freezeRotation,set_freezeRotation,true);
		addMember(l,"constraints",get_constraints,set_constraints,true);
		addMember(l,"simulated",get_simulated,set_simulated,true);
		addMember(l,"interpolation",get_interpolation,set_interpolation,true);
		addMember(l,"sleepMode",get_sleepMode,set_sleepMode,true);
		addMember(l,"collisionDetectionMode",get_collisionDetectionMode,set_collisionDetectionMode,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rigidbody2D),typeof(UnityEngine.Component));
	}
}
