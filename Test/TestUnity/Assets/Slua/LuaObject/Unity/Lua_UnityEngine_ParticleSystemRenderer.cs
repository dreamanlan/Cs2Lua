using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ParticleSystemRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer o;
			o=new UnityEngine.ParticleSystemRenderer();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPropertyBlock(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			UnityEngine.MaterialPropertyBlock a1;
			checkType(l,2,out a1);
			self.SetPropertyBlock(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPropertyBlock(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			UnityEngine.MaterialPropertyBlock a1;
			checkType(l,2,out a1);
			self.GetPropertyBlock(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetClosestReflectionProbes(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo> a1;
			checkType(l,2,out a1);
			self.GetClosestReflectionProbes(a1);
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
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetComponent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Type))){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
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
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentInChildren(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
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
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentsInChildren(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
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
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
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
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentsInParent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
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
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponents(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
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
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
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
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessageUpwards(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
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
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessage(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.SendMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
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
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.BroadcastMessage(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
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
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
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
	static public int get_renderMode(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.renderMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_renderMode(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			UnityEngine.ParticleSystemRenderMode v;
			checkEnum(l,2,out v);
			self.renderMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lengthScale(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.lengthScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lengthScale(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.lengthScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_velocityScale(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.velocityScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocityScale(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.velocityScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cameraVelocityScale(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cameraVelocityScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cameraVelocityScale(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.cameraVelocityScale=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalDirection(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.normalDirection);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalDirection(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.normalDirection=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alignment(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.alignment);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alignment(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			UnityEngine.ParticleSystemRenderSpace v;
			checkEnum(l,2,out v);
			self.alignment=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivot(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pivot);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pivot(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.pivot=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortMode(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.sortMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortMode(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			UnityEngine.ParticleSystemSortMode v;
			checkEnum(l,2,out v);
			self.sortMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sortingFudge(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sortingFudge);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sortingFudge(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.sortingFudge=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minParticleSize(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.minParticleSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minParticleSize(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.minParticleSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxParticleSize(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.maxParticleSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxParticleSize(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.maxParticleSize=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mesh(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.mesh);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mesh(IntPtr l) {
		try {
			UnityEngine.ParticleSystemRenderer self=(UnityEngine.ParticleSystemRenderer)checkSelf(l);
			UnityEngine.Mesh v;
			checkType(l,2,out v);
			self.mesh=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ParticleSystemRenderer");
		addMember(l,SetPropertyBlock);
		addMember(l,GetPropertyBlock);
		addMember(l,GetClosestReflectionProbes);
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
		addMember(l,"renderMode",get_renderMode,set_renderMode,true);
		addMember(l,"lengthScale",get_lengthScale,set_lengthScale,true);
		addMember(l,"velocityScale",get_velocityScale,set_velocityScale,true);
		addMember(l,"cameraVelocityScale",get_cameraVelocityScale,set_cameraVelocityScale,true);
		addMember(l,"normalDirection",get_normalDirection,set_normalDirection,true);
		addMember(l,"alignment",get_alignment,set_alignment,true);
		addMember(l,"pivot",get_pivot,set_pivot,true);
		addMember(l,"sortMode",get_sortMode,set_sortMode,true);
		addMember(l,"sortingFudge",get_sortingFudge,set_sortingFudge,true);
		addMember(l,"minParticleSize",get_minParticleSize,set_minParticleSize,true);
		addMember(l,"maxParticleSize",get_maxParticleSize,set_maxParticleSize,true);
		addMember(l,"mesh",get_mesh,set_mesh,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ParticleSystemRenderer),typeof(UnityEngine.Renderer));
	}
}
