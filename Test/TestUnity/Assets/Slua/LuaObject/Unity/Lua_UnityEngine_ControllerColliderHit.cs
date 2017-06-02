using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ControllerColliderHit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ControllerColliderHit o;
			o=new UnityEngine.ControllerColliderHit();
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
	static public int get_controller(IntPtr l) {
		try {
			UnityEngine.ControllerColliderHit self=(UnityEngine.ControllerColliderHit)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.controller);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_collider(IntPtr l) {
		try {
			UnityEngine.ControllerColliderHit self=(UnityEngine.ControllerColliderHit)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.collider);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rigidbody(IntPtr l) {
		try {
			UnityEngine.ControllerColliderHit self=(UnityEngine.ControllerColliderHit)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rigidbody);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_gameObject(IntPtr l) {
		try {
			UnityEngine.ControllerColliderHit self=(UnityEngine.ControllerColliderHit)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gameObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_transform(IntPtr l) {
		try {
			UnityEngine.ControllerColliderHit self=(UnityEngine.ControllerColliderHit)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.transform);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_point(IntPtr l) {
		try {
			UnityEngine.ControllerColliderHit self=(UnityEngine.ControllerColliderHit)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.point);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_normal(IntPtr l) {
		try {
			UnityEngine.ControllerColliderHit self=(UnityEngine.ControllerColliderHit)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.normal);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_moveDirection(IntPtr l) {
		try {
			UnityEngine.ControllerColliderHit self=(UnityEngine.ControllerColliderHit)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.moveDirection);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_moveLength(IntPtr l) {
		try {
			UnityEngine.ControllerColliderHit self=(UnityEngine.ControllerColliderHit)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.moveLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ControllerColliderHit");
		addMember(l,"controller",get_controller,null,true);
		addMember(l,"collider",get_collider,null,true);
		addMember(l,"rigidbody",get_rigidbody,null,true);
		addMember(l,"gameObject",get_gameObject,null,true);
		addMember(l,"transform",get_transform,null,true);
		addMember(l,"point",get_point,null,true);
		addMember(l,"normal",get_normal,null,true);
		addMember(l,"moveDirection",get_moveDirection,null,true);
		addMember(l,"moveLength",get_moveLength,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ControllerColliderHit));
	}
}
