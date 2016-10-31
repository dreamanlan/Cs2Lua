using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UnassignedReferenceException : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.UnassignedReferenceException o;
			if(argc==1){
				o=new UnityEngine.UnassignedReferenceException();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				System.String a1;
				checkType(l,2,out a1);
				o=new UnityEngine.UnassignedReferenceException(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==3){
				System.String a1;
				checkType(l,2,out a1);
				System.Exception a2;
				checkType(l,3,out a2);
				o=new UnityEngine.UnassignedReferenceException(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBaseException(IntPtr l) {
		try {
			UnityEngine.UnassignedReferenceException self=(UnityEngine.UnassignedReferenceException)checkSelf(l);
			var ret=self.GetBaseException();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetObjectData(IntPtr l) {
		try {
			UnityEngine.UnassignedReferenceException self=(UnityEngine.UnassignedReferenceException)checkSelf(l);
			System.Runtime.Serialization.SerializationInfo a1;
			checkType(l,2,out a1);
			System.Runtime.Serialization.StreamingContext a2;
			checkValueType(l,3,out a2);
			self.GetObjectData(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UnassignedReferenceException");
		addMember(l,GetBaseException);
		addMember(l,GetObjectData);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UnassignedReferenceException),typeof(System.SystemException));
	}
}
