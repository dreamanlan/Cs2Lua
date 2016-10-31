using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_EventSystems_StandaloneInputModule : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateModule(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			self.UpdateModule();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsModuleSupported(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			var ret=self.IsModuleSupported();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ShouldActivateModule(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			var ret=self.ShouldActivateModule();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ActivateModule(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			self.ActivateModule();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DeactivateModule(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			self.DeactivateModule();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Process(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			self.Process();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsPointerOverGameObject(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.IsPointerOverGameObject(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsActive(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			var ret=self.IsActive();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsDestroyed(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			var ret=self.IsDestroyed();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Invoke(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.Invoke(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int InvokeRepeating(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.InvokeRepeating(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CancelInvoke(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				self.CancelInvoke();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.CancelInvoke(a1);
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
	static public int IsInvoking(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				var ret=self.IsInvoking();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.IsInvoking(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
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
	static public int StartCoroutine(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.StartCoroutine(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Collections.IEnumerator))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.Collections.IEnumerator a1;
				checkType(l,2,out a1);
				var ret=self.StartCoroutine(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				var ret=self.StartCoroutine(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
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
	static public int StartCoroutine_Auto(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			System.Collections.IEnumerator a1;
			checkType(l,2,out a1);
			var ret=self.StartCoroutine_Auto(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StopCoroutine(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Coroutine))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				UnityEngine.Coroutine a1;
				checkType(l,2,out a1);
				self.StopCoroutine(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(System.Collections.IEnumerator))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.Collections.IEnumerator a1;
				checkType(l,2,out a1);
				self.StopCoroutine(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.StopCoroutine(a1);
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
	static public int StopAllCoroutines(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			self.StopAllCoroutines();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponent(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetComponent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Type))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
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
	static public int GetComponentInChildren(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentInChildren(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.GetComponentInChildren(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
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
	static public int GetComponentsInChildren(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentsInChildren(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.GetComponentsInChildren(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
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
	static public int GetComponentInParent(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
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
	static public int GetComponentsInParent(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentsInParent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.GetComponentsInParent(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
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
	static public int GetComponents(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponents(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Collections.Generic.List<UnityEngine.Component> a2;
				checkType(l,3,out a2);
				self.GetComponents(a1,a2);
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
	static public int CompareTag(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
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
	static public int SendMessageUpwards(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessageUpwards(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
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
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SendMessage(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessage(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.SendMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
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
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BroadcastMessage(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.BroadcastMessage(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
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
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInstanceID(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			var ret=self.GetInstanceID();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_forceModuleActive(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.forceModuleActive);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_forceModuleActive(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.forceModuleActive=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputActionsPerSecond(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.inputActionsPerSecond);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inputActionsPerSecond(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.inputActionsPerSecond=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_repeatDelay(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.repeatDelay);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_repeatDelay(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.repeatDelay=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_horizontalAxis(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.horizontalAxis);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_horizontalAxis(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.horizontalAxis=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_verticalAxis(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.verticalAxis);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_verticalAxis(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.verticalAxis=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_submitButton(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.submitButton);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_submitButton(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.submitButton=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cancelButton(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cancelButton);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cancelButton(IntPtr l) {
		try {
			UnityEngine.EventSystems.StandaloneInputModule self=(UnityEngine.EventSystems.StandaloneInputModule)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.cancelButton=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.EventSystems.StandaloneInputModule");
		addMember(l,UpdateModule);
		addMember(l,IsModuleSupported);
		addMember(l,ShouldActivateModule);
		addMember(l,ActivateModule);
		addMember(l,DeactivateModule);
		addMember(l,Process);
		addMember(l,IsPointerOverGameObject);
		addMember(l,IsActive);
		addMember(l,IsDestroyed);
		addMember(l,Invoke);
		addMember(l,InvokeRepeating);
		addMember(l,CancelInvoke);
		addMember(l,IsInvoking);
		addMember(l,StartCoroutine);
		addMember(l,StartCoroutine_Auto);
		addMember(l,StopCoroutine);
		addMember(l,StopAllCoroutines);
		addMember(l,GetComponent);
		addMember(l,GetComponentInChildren);
		addMember(l,GetComponentsInChildren);
		addMember(l,GetComponentInParent);
		addMember(l,GetComponentsInParent);
		addMember(l,GetComponents);
		addMember(l,CompareTag);
		addMember(l,SendMessageUpwards);
		addMember(l,SendMessage);
		addMember(l,BroadcastMessage);
		addMember(l,GetInstanceID);
		addMember(l,"forceModuleActive",get_forceModuleActive,set_forceModuleActive,true);
		addMember(l,"inputActionsPerSecond",get_inputActionsPerSecond,set_inputActionsPerSecond,true);
		addMember(l,"repeatDelay",get_repeatDelay,set_repeatDelay,true);
		addMember(l,"horizontalAxis",get_horizontalAxis,set_horizontalAxis,true);
		addMember(l,"verticalAxis",get_verticalAxis,set_verticalAxis,true);
		addMember(l,"submitButton",get_submitButton,set_submitButton,true);
		addMember(l,"cancelButton",get_cancelButton,set_cancelButton,true);
		createTypeMetatable(l,null, typeof(UnityEngine.EventSystems.StandaloneInputModule),typeof(UnityEngine.EventSystems.PointerInputModule));
	}
}
