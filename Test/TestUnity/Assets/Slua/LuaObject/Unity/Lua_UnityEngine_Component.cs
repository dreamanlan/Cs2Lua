using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Component : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Component o;
			o=new UnityEngine.Component();
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
	static public int GetComponent__Type(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetComponent(a1);
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
	static public int GetComponent__String(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetComponent(a1);
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
	static public int GetComponentInChildren__Type(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetComponentInChildren(a1);
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
	static public int GetComponentInChildren__Type__Boolean(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.GetComponentInChildren(a1,a2);
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
	static public int GetComponentsInChildren__Type(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetComponentsInChildren(a1);
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
	static public int GetComponentsInChildren__Type__Boolean(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.GetComponentsInChildren(a1,a2);
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
	static public int GetComponentInParent(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetComponentInParent(a1);
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
	static public int GetComponentsInParent__Type(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetComponentsInParent(a1);
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
	static public int GetComponentsInParent__Type__Boolean(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			var ret=self.GetComponentsInParent(a1,a2);
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
	static public int GetComponents__Type(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetComponents(a1);
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
	static public int GetComponents__Type__List_1_Component(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.Component> a2;
			checkType(l,3,out a2);
			self.GetComponents(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CompareTag(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.CompareTag(a1);
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
	static public int SendMessageUpwards__String(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.SendMessageUpwards(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SendMessageUpwards__String__Object(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			self.SendMessageUpwards(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SendMessageUpwards__String__SendMessageOptions(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.SendMessageOptions a2;
			checkEnum(l,3,out a2);
			self.SendMessageUpwards(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SendMessageUpwards__String__Object__SendMessageOptions(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			UnityEngine.SendMessageOptions a3;
			checkEnum(l,4,out a3);
			self.SendMessageUpwards(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SendMessage__String(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.SendMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SendMessage__String__Object(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			self.SendMessage(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SendMessage__String__SendMessageOptions(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.SendMessageOptions a2;
			checkEnum(l,3,out a2);
			self.SendMessage(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SendMessage__String__Object__SendMessageOptions(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			UnityEngine.SendMessageOptions a3;
			checkEnum(l,4,out a3);
			self.SendMessage(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BroadcastMessage__String(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.BroadcastMessage(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BroadcastMessage__String__Object(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			self.BroadcastMessage(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BroadcastMessage__String__SendMessageOptions(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			UnityEngine.SendMessageOptions a2;
			checkEnum(l,3,out a2);
			self.BroadcastMessage(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BroadcastMessage__String__Object__SendMessageOptions(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			UnityEngine.SendMessageOptions a3;
			checkEnum(l,4,out a3);
			self.BroadcastMessage(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_transform(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
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
	static public int get_gameObject(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
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
	static public int get_tag(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tag);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_tag(IntPtr l) {
		try {
			UnityEngine.Component self=(UnityEngine.Component)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.tag=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Component");
		addMember(l,ctor_s);
		addMember(l,GetComponent__Type);
		addMember(l,GetComponent__String);
		addMember(l,GetComponentInChildren__Type);
		addMember(l,GetComponentInChildren__Type__Boolean);
		addMember(l,GetComponentsInChildren__Type);
		addMember(l,GetComponentsInChildren__Type__Boolean);
		addMember(l,GetComponentInParent);
		addMember(l,GetComponentsInParent__Type);
		addMember(l,GetComponentsInParent__Type__Boolean);
		addMember(l,GetComponents__Type);
		addMember(l,GetComponents__Type__List_1_Component);
		addMember(l,CompareTag);
		addMember(l,SendMessageUpwards__String);
		addMember(l,SendMessageUpwards__String__Object);
		addMember(l,SendMessageUpwards__String__SendMessageOptions);
		addMember(l,SendMessageUpwards__String__Object__SendMessageOptions);
		addMember(l,SendMessage__String);
		addMember(l,SendMessage__String__Object);
		addMember(l,SendMessage__String__SendMessageOptions);
		addMember(l,SendMessage__String__Object__SendMessageOptions);
		addMember(l,BroadcastMessage__String);
		addMember(l,BroadcastMessage__String__Object);
		addMember(l,BroadcastMessage__String__SendMessageOptions);
		addMember(l,BroadcastMessage__String__Object__SendMessageOptions);
		addMember(l,"transform",get_transform,null,true);
		addMember(l,"gameObject",get_gameObject,null,true);
		addMember(l,"tag",get_tag,set_tag,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Component),typeof(UnityEngine.Object));
	}
}
