using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Exception : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			System.Exception o;
			o=new System.Exception();
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
	static public int ctor__String_s(IntPtr l) {
		try {
			System.Exception o;
			System.String a1;
			checkType(l,1,out a1);
			o=new System.Exception(a1);
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
	static public int ctor__String__Exception_s(IntPtr l) {
		try {
			System.Exception o;
			System.String a1;
			checkType(l,1,out a1);
			System.Exception a2;
			checkType(l,2,out a2);
			o=new System.Exception(a1,a2);
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
	static public int GetBaseException(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
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
	[UnityEngine.Scripting.Preserve]
	static new public int ToString(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
			var ret=self.ToString();
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
	static public int GetObjectData(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Message(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Message);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Data(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Data);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_InnerException(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.InnerException);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_TargetSite(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.TargetSite);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_StackTrace(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.StackTrace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_HelpLink(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.HelpLink);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_HelpLink(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.HelpLink=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Source(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Source);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_Source(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.Source=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_HResult(IntPtr l) {
		try {
			System.Exception self=(System.Exception)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.HResult);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Exception");
		addMember(l,ctor_s);
		addMember(l,ctor__String_s);
		addMember(l,ctor__String__Exception_s);
		addMember(l,GetBaseException);
		addMember(l,ToString);
		addMember(l,GetObjectData);
		addMember(l,"Message",get_Message,null,true);
		addMember(l,"Data",get_Data,null,true);
		addMember(l,"InnerException",get_InnerException,null,true);
		addMember(l,"TargetSite",get_TargetSite,null,true);
		addMember(l,"StackTrace",get_StackTrace,null,true);
		addMember(l,"HelpLink",get_HelpLink,set_HelpLink,true);
		addMember(l,"Source",get_Source,set_Source,true);
		addMember(l,"HResult",get_HResult,null,true);
		createTypeMetatable(l,null, typeof(System.Exception));
	}
}
