using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_HumanPoseHandler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Avatar__Transform_s(IntPtr l) {
		try {
			UnityEngine.HumanPoseHandler o;
			UnityEngine.Avatar a1;
			checkType(l,1,out a1);
			UnityEngine.Transform a2;
			checkType(l,2,out a2);
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
	static public int ctor__Avatar__A_String_s(IntPtr l) {
		try {
			UnityEngine.HumanPoseHandler o;
			UnityEngine.Avatar a1;
			checkType(l,1,out a1);
			System.String[] a2;
			checkArray(l,2,out a2);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetInternalHumanPose(IntPtr l) {
		try {
			UnityEngine.HumanPoseHandler self=(UnityEngine.HumanPoseHandler)checkSelf(l);
			UnityEngine.HumanPose a1;
			checkValueType(l,2,out a1);
			self.GetInternalHumanPose(ref a1);
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
	static public int SetInternalHumanPose(IntPtr l) {
		try {
			UnityEngine.HumanPoseHandler self=(UnityEngine.HumanPoseHandler)checkSelf(l);
			UnityEngine.HumanPose a1;
			checkValueType(l,2,out a1);
			self.SetInternalHumanPose(ref a1);
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
		addMember(l,ctor__Avatar__Transform_s);
		addMember(l,ctor__Avatar__A_String_s);
		addMember(l,Dispose);
		addMember(l,GetHumanPose);
		addMember(l,SetHumanPose);
		addMember(l,GetInternalHumanPose);
		addMember(l,SetInternalHumanPose);
		createTypeMetatable(l,null, typeof(UnityEngine.HumanPoseHandler));
	}
}
