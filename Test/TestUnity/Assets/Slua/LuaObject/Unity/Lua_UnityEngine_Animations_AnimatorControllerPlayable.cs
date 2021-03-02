using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Animations_AnimatorControllerPlayable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable o;
			o=new UnityEngine.Animations.AnimatorControllerPlayable();
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
	static public int GetHandle(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetHandle();
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
	static public int SetHandle(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			UnityEngine.Playables.PlayableHandle a1;
			checkValueType(l,2,out a1);
			self.SetHandle(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Equals__AnimatorControllerPlayable(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			UnityEngine.Animations.AnimatorControllerPlayable a1;
			checkValueType(l,2,out a1);
			var ret=self.Equals(a1);
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
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
	static public int GetFloat__String(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetFloat(a1);
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
	static public int GetFloat__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetFloat(a1);
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
	static public int SetFloat__String__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetFloat(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetFloat__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetFloat(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetBool__String(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetBool(a1);
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
	static public int GetBool__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetBool(a1);
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
	static public int SetBool__String__Boolean(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetBool(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetBool__Int32__Boolean(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			self.SetBool(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetInteger__String(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetInteger(a1);
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
	static public int GetInteger__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetInteger(a1);
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
	static public int SetInteger__String__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetInteger(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetInteger__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetInteger(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTrigger__String(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			self.SetTrigger(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetTrigger__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.SetTrigger(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResetTrigger__String(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			self.ResetTrigger(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ResetTrigger__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.ResetTrigger(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IsParameterControlledByCurve__String(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.IsParameterControlledByCurve(a1);
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
	static public int IsParameterControlledByCurve__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.IsParameterControlledByCurve(a1);
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
	static public int GetLayerCount(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetLayerCount();
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
	static public int GetLayerName(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetLayerName(a1);
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
	static public int GetLayerIndex(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetLayerIndex(a1);
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
	static public int GetLayerWeight(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetLayerWeight(a1);
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
	static public int SetLayerWeight(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetLayerWeight(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetCurrentAnimatorStateInfo(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetCurrentAnimatorStateInfo(a1);
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
	static public int GetNextAnimatorStateInfo(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetNextAnimatorStateInfo(a1);
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
	static public int GetAnimatorTransitionInfo(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetAnimatorTransitionInfo(a1);
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
	static public int GetCurrentAnimatorClipInfo__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetCurrentAnimatorClipInfo(a1);
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
	static public int GetCurrentAnimatorClipInfo__Int32__List_1_AnimatorClipInfo(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> a2;
			checkType(l,3,out a2);
			self.GetCurrentAnimatorClipInfo(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetNextAnimatorClipInfo__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetNextAnimatorClipInfo(a1);
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
	static public int GetNextAnimatorClipInfo__Int32__List_1_AnimatorClipInfo(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> a2;
			checkType(l,3,out a2);
			self.GetNextAnimatorClipInfo(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetCurrentAnimatorClipInfoCount(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetCurrentAnimatorClipInfoCount(a1);
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
	static public int GetNextAnimatorClipInfoCount(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetNextAnimatorClipInfoCount(a1);
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
	static public int IsInTransition(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.IsInTransition(a1);
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
	static public int GetParameterCount(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			var ret=self.GetParameterCount();
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
	static public int GetParameter(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetParameter(a1);
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
	static public int CrossFadeInFixedTime__String__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.CrossFadeInFixedTime(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CrossFadeInFixedTime__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.CrossFadeInFixedTime(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CrossFadeInFixedTime__String__Single__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.CrossFadeInFixedTime(a1,a2,a3);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CrossFadeInFixedTime__Int32__Single__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.CrossFadeInFixedTime(a1,a2,a3);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CrossFadeInFixedTime__String__Single__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			self.CrossFadeInFixedTime(a1,a2,a3,a4);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CrossFadeInFixedTime__Int32__Single__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			self.CrossFadeInFixedTime(a1,a2,a3,a4);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CrossFade__String__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.CrossFade(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CrossFade__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.CrossFade(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CrossFade__String__Single__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.CrossFade(a1,a2,a3);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CrossFade__Int32__Single__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.CrossFade(a1,a2,a3);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CrossFade__String__Single__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			self.CrossFade(a1,a2,a3,a4);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CrossFade__Int32__Single__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			self.CrossFade(a1,a2,a3,a4);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PlayInFixedTime__String(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			self.PlayInFixedTime(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PlayInFixedTime__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.PlayInFixedTime(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PlayInFixedTime__String__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.PlayInFixedTime(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PlayInFixedTime__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.PlayInFixedTime(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PlayInFixedTime__String__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.PlayInFixedTime(a1,a2,a3);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int PlayInFixedTime__Int32__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.PlayInFixedTime(a1,a2,a3);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Play__String(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			self.Play(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Play__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.Play(a1);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Play__String__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.Play(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Play__Int32__Int32(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.Play(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Play__String__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.Play(a1,a2,a3);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Play__Int32__Int32__Single(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Single a3;
			checkType(l,4,out a3);
			self.Play(a1,a2,a3);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int HasState(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			var ret=self.HasState(a1,a2);
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
	static public int Create_s(IntPtr l) {
		try {
			UnityEngine.Playables.PlayableGraph a1;
			checkValueType(l,1,out a1);
			UnityEngine.RuntimeAnimatorController a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Animations.AnimatorControllerPlayable.Create(a1,a2);
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
	static public int op_Implicit_s(IntPtr l) {
		try {
			UnityEngine.Animations.AnimatorControllerPlayable a1;
			checkValueType(l,1,out a1);
			UnityEngine.Playables.Playable ret=a1;
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
	static public int op_Explicit_s(IntPtr l) {
		try {
			UnityEngine.Playables.Playable a1;
			checkValueType(l,1,out a1);
			var ret=(UnityEngine.Animations.AnimatorControllerPlayable)a1;
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
	static public int get_Null(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Animations.AnimatorControllerPlayable.Null);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Animations.AnimatorControllerPlayable");
		addMember(l,ctor_s);
		addMember(l,GetHandle);
		addMember(l,SetHandle);
		addMember(l,Equals__AnimatorControllerPlayable);
		addMember(l,Equals__Object);
		addMember(l,GetFloat__String);
		addMember(l,GetFloat__Int32);
		addMember(l,SetFloat__String__Single);
		addMember(l,SetFloat__Int32__Single);
		addMember(l,GetBool__String);
		addMember(l,GetBool__Int32);
		addMember(l,SetBool__String__Boolean);
		addMember(l,SetBool__Int32__Boolean);
		addMember(l,GetInteger__String);
		addMember(l,GetInteger__Int32);
		addMember(l,SetInteger__String__Int32);
		addMember(l,SetInteger__Int32__Int32);
		addMember(l,SetTrigger__String);
		addMember(l,SetTrigger__Int32);
		addMember(l,ResetTrigger__String);
		addMember(l,ResetTrigger__Int32);
		addMember(l,IsParameterControlledByCurve__String);
		addMember(l,IsParameterControlledByCurve__Int32);
		addMember(l,GetLayerCount);
		addMember(l,GetLayerName);
		addMember(l,GetLayerIndex);
		addMember(l,GetLayerWeight);
		addMember(l,SetLayerWeight);
		addMember(l,GetCurrentAnimatorStateInfo);
		addMember(l,GetNextAnimatorStateInfo);
		addMember(l,GetAnimatorTransitionInfo);
		addMember(l,GetCurrentAnimatorClipInfo__Int32);
		addMember(l,GetCurrentAnimatorClipInfo__Int32__List_1_AnimatorClipInfo);
		addMember(l,GetNextAnimatorClipInfo__Int32);
		addMember(l,GetNextAnimatorClipInfo__Int32__List_1_AnimatorClipInfo);
		addMember(l,GetCurrentAnimatorClipInfoCount);
		addMember(l,GetNextAnimatorClipInfoCount);
		addMember(l,IsInTransition);
		addMember(l,GetParameterCount);
		addMember(l,GetParameter);
		addMember(l,CrossFadeInFixedTime__String__Single);
		addMember(l,CrossFadeInFixedTime__Int32__Single);
		addMember(l,CrossFadeInFixedTime__String__Single__Int32);
		addMember(l,CrossFadeInFixedTime__Int32__Single__Int32);
		addMember(l,CrossFadeInFixedTime__String__Single__Int32__Single);
		addMember(l,CrossFadeInFixedTime__Int32__Single__Int32__Single);
		addMember(l,CrossFade__String__Single);
		addMember(l,CrossFade__Int32__Single);
		addMember(l,CrossFade__String__Single__Int32);
		addMember(l,CrossFade__Int32__Single__Int32);
		addMember(l,CrossFade__String__Single__Int32__Single);
		addMember(l,CrossFade__Int32__Single__Int32__Single);
		addMember(l,PlayInFixedTime__String);
		addMember(l,PlayInFixedTime__Int32);
		addMember(l,PlayInFixedTime__String__Int32);
		addMember(l,PlayInFixedTime__Int32__Int32);
		addMember(l,PlayInFixedTime__String__Int32__Single);
		addMember(l,PlayInFixedTime__Int32__Int32__Single);
		addMember(l,Play__String);
		addMember(l,Play__Int32);
		addMember(l,Play__String__Int32);
		addMember(l,Play__Int32__Int32);
		addMember(l,Play__String__Int32__Single);
		addMember(l,Play__Int32__Int32__Single);
		addMember(l,HasState);
		addMember(l,Create_s);
		addMember(l,op_Implicit_s);
		addMember(l,op_Explicit_s);
		addMember(l,"Null",get_Null,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Animations.AnimatorControllerPlayable),typeof(System.ValueType));
	}
}
