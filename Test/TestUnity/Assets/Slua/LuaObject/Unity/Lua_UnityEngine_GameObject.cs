using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_GameObject : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.GameObject o;
			o=new UnityEngine.GameObject();
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
			UnityEngine.GameObject o;
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.GameObject(a1);
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
	static public int ctor__String__A_Type_s(IntPtr l) {
		try {
			UnityEngine.GameObject o;
			System.String a1;
			checkType(l,1,out a1);
			System.Type[] a2;
			checkParams(l,2,out a2);
			o=new UnityEngine.GameObject(a1,a2);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int GetComponentInParent(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int GetComponents__Type(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int GetComponentsInChildren__Type(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int GetComponentsInParent__Type(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int SendMessageUpwards__String(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int SendMessageUpwards__String__SendMessageOptions(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int SendMessageUpwards__String__Object(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int SendMessageUpwards__String__Object__SendMessageOptions(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int SendMessage__String__SendMessageOptions(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int SendMessage__String__Object(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int SendMessage__String__Object__SendMessageOptions(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int BroadcastMessage__String__SendMessageOptions(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int BroadcastMessage__String__Object(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int BroadcastMessage__String__Object__SendMessageOptions(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int AddComponent(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.AddComponent(a1);
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
	static public int SetActive(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.SetActive(a1);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int CreatePrimitive_s(IntPtr l) {
		try {
			UnityEngine.PrimitiveType a1;
			checkEnum(l,1,out a1);
			var ret=UnityEngine.GameObject.CreatePrimitive(a1);
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
	static public int FindWithTag_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.GameObject.FindWithTag(a1);
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
	static public int FindGameObjectWithTag_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.GameObject.FindGameObjectWithTag(a1);
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
	static public int FindGameObjectsWithTag_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.GameObject.FindGameObjectsWithTag(a1);
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
	static public int Find_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.GameObject.Find(a1);
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
	static public int get_transform(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	static public int get_layer(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.layer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_layer(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.layer=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_activeSelf(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.activeSelf);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_activeInHierarchy(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.activeInHierarchy);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isStatic(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isStatic);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isStatic(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.isStatic=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_tag(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
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
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_scene(IntPtr l) {
		try {
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scene);
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
			UnityEngine.GameObject self=(UnityEngine.GameObject)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.gameObject);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.GameObject");
		addMember(l,ctor_s);
		addMember(l,ctor__String_s);
		addMember(l,ctor__String__A_Type_s);
		addMember(l,GetComponent__Type);
		addMember(l,GetComponent__String);
		addMember(l,GetComponentInChildren__Type);
		addMember(l,GetComponentInChildren__Type__Boolean);
		addMember(l,GetComponentInParent);
		addMember(l,GetComponents__Type);
		addMember(l,GetComponents__Type__List_1_Component);
		addMember(l,GetComponentsInChildren__Type);
		addMember(l,GetComponentsInChildren__Type__Boolean);
		addMember(l,GetComponentsInParent__Type);
		addMember(l,GetComponentsInParent__Type__Boolean);
		addMember(l,SendMessageUpwards__String);
		addMember(l,SendMessageUpwards__String__SendMessageOptions);
		addMember(l,SendMessageUpwards__String__Object);
		addMember(l,SendMessageUpwards__String__Object__SendMessageOptions);
		addMember(l,SendMessage__String);
		addMember(l,SendMessage__String__SendMessageOptions);
		addMember(l,SendMessage__String__Object);
		addMember(l,SendMessage__String__Object__SendMessageOptions);
		addMember(l,BroadcastMessage__String);
		addMember(l,BroadcastMessage__String__SendMessageOptions);
		addMember(l,BroadcastMessage__String__Object);
		addMember(l,BroadcastMessage__String__Object__SendMessageOptions);
		addMember(l,AddComponent);
		addMember(l,SetActive);
		addMember(l,CompareTag);
		addMember(l,CreatePrimitive_s);
		addMember(l,FindWithTag_s);
		addMember(l,FindGameObjectWithTag_s);
		addMember(l,FindGameObjectsWithTag_s);
		addMember(l,Find_s);
		addMember(l,"transform",get_transform,null,true);
		addMember(l,"layer",get_layer,set_layer,true);
		addMember(l,"activeSelf",get_activeSelf,null,true);
		addMember(l,"activeInHierarchy",get_activeInHierarchy,null,true);
		addMember(l,"isStatic",get_isStatic,set_isStatic,true);
		addMember(l,"tag",get_tag,set_tag,true);
		addMember(l,"scene",get_scene,null,true);
		addMember(l,"gameObject",get_gameObject,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.GameObject),typeof(UnityEngine.Object));
	}
}
