using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Motion : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Motion o;
			o=new UnityEngine.Motion();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_averageDuration(IntPtr l) {
		try {
			UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.averageDuration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_averageAngularSpeed(IntPtr l) {
		try {
			UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.averageAngularSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_averageSpeed(IntPtr l) {
		try {
			UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.averageSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_apparentSpeed(IntPtr l) {
		try {
			UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.apparentSpeed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isLooping(IntPtr l) {
		try {
			UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isLooping);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_legacy(IntPtr l) {
		try {
			UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.legacy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isHumanMotion(IntPtr l) {
		try {
			UnityEngine.Motion self=(UnityEngine.Motion)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isHumanMotion);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Motion");
		addMember(l,"averageDuration",get_averageDuration,null,true);
		addMember(l,"averageAngularSpeed",get_averageAngularSpeed,null,true);
		addMember(l,"averageSpeed",get_averageSpeed,null,true);
		addMember(l,"apparentSpeed",get_apparentSpeed,null,true);
		addMember(l,"isLooping",get_isLooping,null,true);
		addMember(l,"legacy",get_legacy,null,true);
		addMember(l,"isHumanMotion",get_isHumanMotion,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Motion),typeof(UnityEngine.Object));
	}
}
