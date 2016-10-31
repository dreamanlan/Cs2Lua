using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_CanvasScaler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsActive(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				self.CancelInvoke();
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				var ret=self.IsInvoking();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.StartCoroutine(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Collections.IEnumerator))){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.Collections.IEnumerator a1;
				checkType(l,2,out a1);
				var ret=self.StartCoroutine(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				UnityEngine.Coroutine a1;
				checkType(l,2,out a1);
				self.StopCoroutine(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(System.Collections.IEnumerator))){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.Collections.IEnumerator a1;
				checkType(l,2,out a1);
				self.StopCoroutine(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetComponent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Type))){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentInChildren(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentsInChildren(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentsInParent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponents(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessageUpwards(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessage(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.SendMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.BroadcastMessage(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
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
	static public int get_uiScaleMode(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.uiScaleMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_uiScaleMode(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			UnityEngine.UI.CanvasScaler.ScaleMode v;
			checkEnum(l,2,out v);
			self.uiScaleMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_referencePixelsPerUnit(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.referencePixelsPerUnit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_referencePixelsPerUnit(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.referencePixelsPerUnit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_scaleFactor(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scaleFactor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_scaleFactor(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.scaleFactor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_referenceResolution(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.referenceResolution);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_referenceResolution(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.referenceResolution=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_screenMatchMode(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.screenMatchMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_screenMatchMode(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			UnityEngine.UI.CanvasScaler.ScreenMatchMode v;
			checkEnum(l,2,out v);
			self.screenMatchMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_matchWidthOrHeight(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.matchWidthOrHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_matchWidthOrHeight(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.matchWidthOrHeight=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_physicalUnit(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.physicalUnit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_physicalUnit(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			UnityEngine.UI.CanvasScaler.Unit v;
			checkEnum(l,2,out v);
			self.physicalUnit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fallbackScreenDPI(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fallbackScreenDPI);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fallbackScreenDPI(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.fallbackScreenDPI=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultSpriteDPI(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.defaultSpriteDPI);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_defaultSpriteDPI(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.defaultSpriteDPI=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_dynamicPixelsPerUnit(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.dynamicPixelsPerUnit);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_dynamicPixelsPerUnit(IntPtr l) {
		try {
			UnityEngine.UI.CanvasScaler self=(UnityEngine.UI.CanvasScaler)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.dynamicPixelsPerUnit=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.CanvasScaler");
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
		addMember(l,"uiScaleMode",get_uiScaleMode,set_uiScaleMode,true);
		addMember(l,"referencePixelsPerUnit",get_referencePixelsPerUnit,set_referencePixelsPerUnit,true);
		addMember(l,"scaleFactor",get_scaleFactor,set_scaleFactor,true);
		addMember(l,"referenceResolution",get_referenceResolution,set_referenceResolution,true);
		addMember(l,"screenMatchMode",get_screenMatchMode,set_screenMatchMode,true);
		addMember(l,"matchWidthOrHeight",get_matchWidthOrHeight,set_matchWidthOrHeight,true);
		addMember(l,"physicalUnit",get_physicalUnit,set_physicalUnit,true);
		addMember(l,"fallbackScreenDPI",get_fallbackScreenDPI,set_fallbackScreenDPI,true);
		addMember(l,"defaultSpriteDPI",get_defaultSpriteDPI,set_defaultSpriteDPI,true);
		addMember(l,"dynamicPixelsPerUnit",get_dynamicPixelsPerUnit,set_dynamicPixelsPerUnit,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.CanvasScaler),typeof(UnityEngine.EventSystems.UIBehaviour));
	}
}
