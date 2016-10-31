using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Experimental_Director_Playable : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable o;
			o=new UnityEngine.Experimental.Director.Playable();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInput(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetInput(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInputs(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
				var ret=self.GetInputs();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
				System.Collections.Generic.List<UnityEngine.Experimental.Director.Playable> a1;
				checkType(l,2,out a1);
				self.GetInputs(a1);
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
	static public int ClearInputs(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			self.ClearInputs();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetOutput(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetOutput(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetOutputs(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
				var ret=self.GetOutputs();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
				System.Collections.Generic.List<UnityEngine.Experimental.Director.Playable> a1;
				checkType(l,2,out a1);
				self.GetOutputs(a1);
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
	static public int Dispose(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInputWeight(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetInputWeight(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetInputWeight(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			var ret=self.SetInputWeight(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PrepareFrame(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			UnityEngine.Experimental.Director.FrameData a1;
			checkValueType(l,2,out a1);
			self.PrepareFrame(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ProcessFrame(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			UnityEngine.Experimental.Director.FrameData a1;
			checkValueType(l,2,out a1);
			System.Object a2;
			checkType(l,3,out a2);
			self.ProcessFrame(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSetTime(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.OnSetTime(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSetPlayState(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			UnityEngine.Experimental.Director.PlayState a1;
			checkEnum(l,2,out a1);
			self.OnSetPlayState(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Connect_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Experimental.Director.Playable a1;
				checkType(l,1,out a1);
				UnityEngine.Experimental.Director.Playable a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.Experimental.Director.Playable.Connect(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Experimental.Director.Playable a1;
				checkType(l,1,out a1);
				UnityEngine.Experimental.Director.Playable a2;
				checkType(l,2,out a2);
				System.Int32 a3;
				checkType(l,3,out a3);
				System.Int32 a4;
				checkType(l,4,out a4);
				var ret=UnityEngine.Experimental.Director.Playable.Connect(a1,a2,a3,a4);
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
	static public int Disconnect_s(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Experimental.Director.Playable.Disconnect(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Director.Playable a2;
			checkType(l,2,out a2);
			var ret=(a1==a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable a1;
			checkType(l,1,out a1);
			UnityEngine.Experimental.Director.Playable a2;
			checkType(l,2,out a2);
			var ret=(a1!=a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.time);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			double v;
			checkType(l,2,out v);
			self.time=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_state(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.state);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_state(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			UnityEngine.Experimental.Director.PlayState v;
			checkEnum(l,2,out v);
			self.state=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.inputCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_outputCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.Playable self=(UnityEngine.Experimental.Director.Playable)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.outputCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Director.Playable");
		addMember(l,GetInput);
		addMember(l,GetInputs);
		addMember(l,ClearInputs);
		addMember(l,GetOutput);
		addMember(l,GetOutputs);
		addMember(l,Dispose);
		addMember(l,GetInputWeight);
		addMember(l,SetInputWeight);
		addMember(l,PrepareFrame);
		addMember(l,ProcessFrame);
		addMember(l,OnSetTime);
		addMember(l,OnSetPlayState);
		addMember(l,Connect_s);
		addMember(l,Disconnect_s);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"state",get_state,set_state,true);
		addMember(l,"inputCount",get_inputCount,null,true);
		addMember(l,"outputCount",get_outputCount,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Director.Playable));
	}
}
