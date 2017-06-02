using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AvatarMask : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AvatarMask o;
			o=new UnityEngine.AvatarMask();
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
	static public int GetHumanoidBodyPartActive(IntPtr l) {
		try {
			UnityEngine.AvatarMask self=(UnityEngine.AvatarMask)checkSelf(l);
			UnityEngine.AvatarMaskBodyPart a1;
			checkEnum(l,2,out a1);
			var ret=self.GetHumanoidBodyPartActive(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetHumanoidBodyPartActive(IntPtr l) {
		try {
			UnityEngine.AvatarMask self=(UnityEngine.AvatarMask)checkSelf(l);
			UnityEngine.AvatarMaskBodyPart a1;
			checkEnum(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetHumanoidBodyPartActive(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddTransformPath(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.AvatarMask self=(UnityEngine.AvatarMask)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				self.AddTransformPath(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.AvatarMask self=(UnityEngine.AvatarMask)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.AddTransformPath(a1,a2);
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
	static public int RemoveTransformPath(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.AvatarMask self=(UnityEngine.AvatarMask)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				self.RemoveTransformPath(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.AvatarMask self=(UnityEngine.AvatarMask)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.RemoveTransformPath(a1,a2);
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
	static public int GetTransformPath(IntPtr l) {
		try {
			UnityEngine.AvatarMask self=(UnityEngine.AvatarMask)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetTransformPath(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTransformPath(IntPtr l) {
		try {
			UnityEngine.AvatarMask self=(UnityEngine.AvatarMask)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			self.SetTransformPath(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetTransformActive(IntPtr l) {
		try {
			UnityEngine.AvatarMask self=(UnityEngine.AvatarMask)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetTransformActive(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTransformActive(IntPtr l) {
		try {
			UnityEngine.AvatarMask self=(UnityEngine.AvatarMask)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetTransformActive(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_transformCount(IntPtr l) {
		try {
			UnityEngine.AvatarMask self=(UnityEngine.AvatarMask)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.transformCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_transformCount(IntPtr l) {
		try {
			UnityEngine.AvatarMask self=(UnityEngine.AvatarMask)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.transformCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AvatarMask");
		addMember(l,GetHumanoidBodyPartActive);
		addMember(l,SetHumanoidBodyPartActive);
		addMember(l,AddTransformPath);
		addMember(l,RemoveTransformPath);
		addMember(l,GetTransformPath);
		addMember(l,SetTransformPath);
		addMember(l,GetTransformActive);
		addMember(l,SetTransformActive);
		addMember(l,"transformCount",get_transformCount,set_transformCount,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AvatarMask),typeof(UnityEngine.Object));
	}
}
