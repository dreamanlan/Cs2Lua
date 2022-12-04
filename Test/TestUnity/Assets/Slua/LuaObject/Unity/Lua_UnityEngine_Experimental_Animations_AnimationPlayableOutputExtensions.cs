using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Animations_AnimationPlayableOutputExtensions : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetAnimationStreamSource_s(IntPtr l) {
		try {
			UnityEngine.Animations.AnimationPlayableOutput a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions.GetAnimationStreamSource(a1);
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetAnimationStreamSource_s(IntPtr l) {
		try {
			UnityEngine.Animations.AnimationPlayableOutput a1;
			checkValueType(l,1,out a1);
			UnityEngine.Experimental.Animations.AnimationStreamSource a2;
			checkEnum(l,2,out a2);
			UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions.SetAnimationStreamSource(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetSortingOrder_s(IntPtr l) {
		try {
			UnityEngine.Animations.AnimationPlayableOutput a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions.GetSortingOrder(a1);
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
	static public int SetSortingOrder_s(IntPtr l) {
		try {
			UnityEngine.Animations.AnimationPlayableOutput a1;
			checkValueType(l,1,out a1);
			System.UInt16 a2;
			checkType(l,2,out a2);
			UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions.SetSortingOrder(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions");
		addMember(l,GetAnimationStreamSource_s);
		addMember(l,SetAnimationStreamSource_s);
		addMember(l,GetSortingOrder_s);
		addMember(l,SetSortingOrder_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.Animations.AnimationPlayableOutputExtensions));
	}
}
