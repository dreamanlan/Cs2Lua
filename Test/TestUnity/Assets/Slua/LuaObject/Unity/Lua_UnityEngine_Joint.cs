using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Joint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_connectedBody(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.connectedBody);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_connectedBody(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			UnityEngine.Rigidbody v;
			checkType(l,2,out v);
			self.connectedBody=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_axis(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.axis);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_axis(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.axis=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_anchor(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.anchor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_anchor(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.anchor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_connectedAnchor(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.connectedAnchor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_connectedAnchor(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.connectedAnchor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autoConfigureConnectedAnchor(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.autoConfigureConnectedAnchor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_autoConfigureConnectedAnchor(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.autoConfigureConnectedAnchor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_breakForce(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.breakForce);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_breakForce(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.breakForce=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_breakTorque(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.breakTorque);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_breakTorque(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.breakTorque=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableCollision(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enableCollision);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableCollision(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enableCollision=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enablePreprocessing(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enablePreprocessing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enablePreprocessing(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enablePreprocessing=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_currentForce(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currentForce);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_currentTorque(IntPtr l) {
		try {
			UnityEngine.Joint self=(UnityEngine.Joint)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currentTorque);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Joint");
		addMember(l,"connectedBody",get_connectedBody,set_connectedBody,true);
		addMember(l,"axis",get_axis,set_axis,true);
		addMember(l,"anchor",get_anchor,set_anchor,true);
		addMember(l,"connectedAnchor",get_connectedAnchor,set_connectedAnchor,true);
		addMember(l,"autoConfigureConnectedAnchor",get_autoConfigureConnectedAnchor,set_autoConfigureConnectedAnchor,true);
		addMember(l,"breakForce",get_breakForce,set_breakForce,true);
		addMember(l,"breakTorque",get_breakTorque,set_breakTorque,true);
		addMember(l,"enableCollision",get_enableCollision,set_enableCollision,true);
		addMember(l,"enablePreprocessing",get_enablePreprocessing,set_enablePreprocessing,true);
		addMember(l,"currentForce",get_currentForce,null,true);
		addMember(l,"currentTorque",get_currentTorque,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Joint),typeof(UnityEngine.Component));
	}
}
