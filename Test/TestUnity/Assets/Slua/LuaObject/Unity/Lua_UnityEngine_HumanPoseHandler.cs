using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_HumanPoseHandler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.HumanPoseHandler o;
			UnityEngine.Avatar a1;
			checkType(l,2,out a1);
			UnityEngine.Transform a2;
			checkType(l,3,out a2);
			o=new UnityEngine.HumanPoseHandler(a1,a2);
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
	static public int Dispose(IntPtr l) {
		try {
			UnityEngine.HumanPoseHandler self=(UnityEngine.HumanPoseHandler)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetHumanPose(IntPtr l) {
		try {
			UnityEngine.HumanPoseHandler self=(UnityEngine.HumanPoseHandler)checkSelf(l);
			UnityEngine.HumanPose a1;
			checkValueType(l,2,out a1);
			self.GetHumanPose(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetHumanPose(IntPtr l) {
		try {
			UnityEngine.HumanPoseHandler self=(UnityEngine.HumanPoseHandler)checkSelf(l);
			UnityEngine.HumanPose a1;
			checkValueType(l,2,out a1);
			self.SetHumanPose(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HumanPoseHandler");
		addMember(l,Dispose);
		addMember(l,GetHumanPose);
		addMember(l,SetHumanPose);
		createTypeMetatable(l,constructor, typeof(UnityEngine.HumanPoseHandler));
	}
}
