using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_StateMachineBehaviour : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int OnStateEnter(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
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
			else if(argc==5){
				UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				UnityEngine.AnimatorStateInfo a2;
				checkValueType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable a4;
				checkType(l,5,out a4);
				self.OnStateEnter(a1,a2,a3,a4);
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
	[UnityEngine.Scripting.Preserve]
	static public int OnStateUpdate(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
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
			else if(argc==5){
				UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				UnityEngine.AnimatorStateInfo a2;
				checkValueType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable a4;
				checkType(l,5,out a4);
				self.OnStateUpdate(a1,a2,a3,a4);
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
	[UnityEngine.Scripting.Preserve]
	static public int OnStateExit(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
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
			else if(argc==5){
				UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				UnityEngine.AnimatorStateInfo a2;
				checkValueType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable a4;
				checkType(l,5,out a4);
				self.OnStateExit(a1,a2,a3,a4);
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
	[UnityEngine.Scripting.Preserve]
	static public int OnStateMove(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
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
			else if(argc==5){
				UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				UnityEngine.AnimatorStateInfo a2;
				checkValueType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable a4;
				checkType(l,5,out a4);
				self.OnStateMove(a1,a2,a3,a4);
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
	[UnityEngine.Scripting.Preserve]
	static public int OnStateIK(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
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
			else if(argc==5){
				UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				UnityEngine.AnimatorStateInfo a2;
				checkValueType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable a4;
				checkType(l,5,out a4);
				self.OnStateIK(a1,a2,a3,a4);
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
	[UnityEngine.Scripting.Preserve]
	static public int OnStateMachineEnter(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.OnStateMachineEnter(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable a3;
				checkType(l,4,out a3);
				self.OnStateMachineEnter(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public int OnStateMachineExit(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.OnStateMachineExit(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.StateMachineBehaviour self=(UnityEngine.StateMachineBehaviour)checkSelf(l);
				UnityEngine.Animator a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.Experimental.Director.AnimatorControllerPlayable a3;
				checkType(l,4,out a3);
				self.OnStateMachineExit(a1,a2,a3);
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
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.StateMachineBehaviour");
		addMember(l,OnStateEnter);
		addMember(l,OnStateUpdate);
		addMember(l,OnStateExit);
		addMember(l,OnStateMove);
		addMember(l,OnStateIK);
		addMember(l,OnStateMachineEnter);
		addMember(l,OnStateMachineExit);
		createTypeMetatable(l,null, typeof(UnityEngine.StateMachineBehaviour),typeof(UnityEngine.ScriptableObject));
	}
}
