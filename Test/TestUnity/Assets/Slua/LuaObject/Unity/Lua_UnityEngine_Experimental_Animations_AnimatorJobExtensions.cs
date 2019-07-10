using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Animations_AnimatorJobExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BindStreamTransform_s(IntPtr l) {
		try {
			UnityEngine.Animator a1;
			checkType(l,1,out a1);
			UnityEngine.Transform a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Experimental.Animations.AnimatorJobExtensions.BindStreamTransform(a1,a2);
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
	static public int BindStreamProperty_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				UnityEngine.Transform a2;
				checkType(l,3,out a2);
				System.Type a3;
				checkType(l,4,out a3);
				System.String a4;
				checkType(l,5,out a4);
				System.Boolean a5;
				checkType(l,6,out a5);
				var ret=UnityEngine.Experimental.Animations.AnimatorJobExtensions.BindStreamProperty(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				UnityEngine.Transform a2;
				checkType(l,3,out a2);
				System.Type a3;
				checkType(l,4,out a3);
				System.String a4;
				checkType(l,5,out a4);
				var ret=UnityEngine.Experimental.Animations.AnimatorJobExtensions.BindStreamProperty(a1,a2,a3,a4);
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
	[UnityEngine.Scripting.Preserve]
	static public int BindSceneTransform_s(IntPtr l) {
		try {
			UnityEngine.Animator a1;
			checkType(l,1,out a1);
			UnityEngine.Transform a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Experimental.Animations.AnimatorJobExtensions.BindSceneTransform(a1,a2);
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
	static public int BindSceneProperty_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				UnityEngine.Transform a2;
				checkType(l,3,out a2);
				System.Type a3;
				checkType(l,4,out a3);
				System.String a4;
				checkType(l,5,out a4);
				System.Boolean a5;
				checkType(l,6,out a5);
				var ret=UnityEngine.Experimental.Animations.AnimatorJobExtensions.BindSceneProperty(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==5){
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				UnityEngine.Transform a2;
				checkType(l,3,out a2);
				System.Type a3;
				checkType(l,4,out a3);
				System.String a4;
				checkType(l,5,out a4);
				var ret=UnityEngine.Experimental.Animations.AnimatorJobExtensions.BindSceneProperty(a1,a2,a3,a4);
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
	[UnityEngine.Scripting.Preserve]
	static public int OpenAnimationStream_s(IntPtr l) {
		try {
			UnityEngine.Animator a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Animations.AnimationStream a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.Experimental.Animations.AnimatorJobExtensions.OpenAnimationStream(a1,ref a2);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CloseAnimationStream_s(IntPtr l) {
		try {
			UnityEngine.Animator a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Animations.AnimationStream a2;
			checkValueType(l,2,out a2);
			UnityEngine.Experimental.Animations.AnimatorJobExtensions.CloseAnimationStream(a1,ref a2);
			pushValue(l,true);
			pushValue(l,a2);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResolveAllStreamHandles_s(IntPtr l) {
		try {
			UnityEngine.Animator a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Animations.AnimatorJobExtensions.ResolveAllStreamHandles(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResolveAllSceneHandles_s(IntPtr l) {
		try {
			UnityEngine.Animator a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Animations.AnimatorJobExtensions.ResolveAllSceneHandles(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Animations.AnimatorJobExtensions");
		addMember(l,BindStreamTransform_s);
		addMember(l,BindStreamProperty_s);
		addMember(l,BindSceneTransform_s);
		addMember(l,BindSceneProperty_s);
		addMember(l,OpenAnimationStream_s);
		addMember(l,CloseAnimationStream_s);
		addMember(l,ResolveAllStreamHandles_s);
		addMember(l,ResolveAllSceneHandles_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Animations.AnimatorJobExtensions));
	}
}
