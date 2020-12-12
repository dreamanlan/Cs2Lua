using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_StateMachineBehaviour : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateEnter__Animator__AnimatorStateInfo__Int32(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorStateInfo a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.OnStateEnter(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateEnter__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorStateInfo a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Animations.AnimatorControllerPlayable a4;
			checkValueType(l,5,out a4);
			self.OnStateEnter(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateUpdate__Animator__AnimatorStateInfo__Int32(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorStateInfo a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.OnStateUpdate(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateUpdate__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorStateInfo a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Animations.AnimatorControllerPlayable a4;
			checkValueType(l,5,out a4);
			self.OnStateUpdate(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateExit__Animator__AnimatorStateInfo__Int32(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorStateInfo a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.OnStateExit(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateExit__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorStateInfo a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Animations.AnimatorControllerPlayable a4;
			checkValueType(l,5,out a4);
			self.OnStateExit(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateMove__Animator__AnimatorStateInfo__Int32(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorStateInfo a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.OnStateMove(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateMove__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorStateInfo a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Animations.AnimatorControllerPlayable a4;
			checkValueType(l,5,out a4);
			self.OnStateMove(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateIK__Animator__AnimatorStateInfo__Int32(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorStateInfo a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.OnStateIK(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateIK__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			UnityEngine.AnimatorStateInfo a2;
			checkValueType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Animations.AnimatorControllerPlayable a4;
			checkValueType(l,5,out a4);
			self.OnStateIK(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateMachineEnter__Animator__Int32(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.OnStateMachineEnter(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateMachineEnter__Animator__Int32__AnimatorControllerPlayable(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Animations.AnimatorControllerPlayable a3;
			checkValueType(l,4,out a3);
			self.OnStateMachineEnter(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateMachineExit__Animator__Int32(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.OnStateMachineExit(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateMachineExit__Animator__Int32__AnimatorControllerPlayable(IntPtr l) {
		try {
			UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
			UnityEngine.Animator a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			UnityEngine.Animations.AnimatorControllerPlayable a3;
			checkValueType(l,4,out a3);
			self.OnStateMachineExit(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.StateMachineBehaviour");
		addMember(l,OnStateEnter__Animator__AnimatorStateInfo__Int32);
		addMember(l,OnStateEnter__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable);
		addMember(l,OnStateUpdate__Animator__AnimatorStateInfo__Int32);
		addMember(l,OnStateUpdate__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable);
		addMember(l,OnStateExit__Animator__AnimatorStateInfo__Int32);
		addMember(l,OnStateExit__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable);
		addMember(l,OnStateMove__Animator__AnimatorStateInfo__Int32);
		addMember(l,OnStateMove__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable);
		addMember(l,OnStateIK__Animator__AnimatorStateInfo__Int32);
		addMember(l,OnStateIK__Animator__AnimatorStateInfo__Int32__AnimatorControllerPlayable);
		addMember(l,OnStateMachineEnter__Animator__Int32);
		addMember(l,OnStateMachineEnter__Animator__Int32__AnimatorControllerPlayable);
		addMember(l,OnStateMachineExit__Animator__Int32);
		addMember(l,OnStateMachineExit__Animator__Int32__AnimatorControllerPlayable);
		createTypeMetatable(l,null, typeof(UnityEngine.StateMachineBehaviour),typeof(UnityEngine.ScriptableObject));
	}
}
