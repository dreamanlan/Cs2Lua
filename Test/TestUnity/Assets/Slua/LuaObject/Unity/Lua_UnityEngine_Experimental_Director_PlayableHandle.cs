using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Director_PlayableHandle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle o;
			o=new UnityEngine.Experimental.Director.PlayableHandle();
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
	static public int GetObject(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2)){
				UnityEngine.Experimental.Director.PlayableHandle self;
				checkValueType(l,1,out self);
				var ret=self.GetObject();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2)){
				UnityEngine.Experimental.Director.PlayableHandle self;
				checkValueType(l,1,out self);
				var ret=self.GetObject<UnityEngine.Experimental.Director.Playable>();
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
	static public int IsValid(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			var ret=self.IsValid();
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
	static public int GetInput(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
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
	[UnityEngine.Scripting.Preserve]
	static public int GetOutput(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
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
	[UnityEngine.Scripting.Preserve]
	static public int SetInputWeight(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
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
	[UnityEngine.Scripting.Preserve]
	static public int GetInputWeight(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
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
	[UnityEngine.Scripting.Preserve]
	static public int Destroy(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			self.Destroy();
			pushValue(l,true);
			setBack(l,self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int op_Equality(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle a1;
			checkValueType(l,1,out a1);
			UnityEngine.Experimental.Director.PlayableHandle a2;
			checkValueType(l,2,out a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int op_Inequality(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle a1;
			checkValueType(l,1,out a1);
			UnityEngine.Experimental.Director.PlayableHandle a2;
			checkValueType(l,2,out a2);
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
	[UnityEngine.Scripting.Preserve]
	static public int get_Null(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Experimental.Director.PlayableHandle.Null);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_graph(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.graph);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_inputCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.inputCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_inputCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.inputCount=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_outputCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.outputCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_outputCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.outputCount=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_playState(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.playState);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_playState(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Director.PlayState v;
			checkEnum(l,2,out v);
			self.playState=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_speed(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.speed);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_speed(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			double v;
			checkType(l,2,out v);
			self.speed=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_time(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.time);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_time(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			double v;
			checkType(l,2,out v);
			self.time=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isDone(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.isDone);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_isDone(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.isDone=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_duration(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.duration);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_duration(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableHandle self;
			checkValueType(l,1,out self);
			double v;
			checkType(l,2,out v);
			self.duration=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Director.PlayableHandle");
		addMember(l,GetObject);
		addMember(l,IsValid);
		addMember(l,GetInput);
		addMember(l,GetOutput);
		addMember(l,SetInputWeight);
		addMember(l,GetInputWeight);
		addMember(l,Destroy);
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		addMember(l,"Null",get_Null,null,false);
		addMember(l,"graph",get_graph,null,true);
		addMember(l,"inputCount",get_inputCount,set_inputCount,true);
		addMember(l,"outputCount",get_outputCount,set_outputCount,true);
		addMember(l,"playState",get_playState,set_playState,true);
		addMember(l,"speed",get_speed,set_speed,true);
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"isDone",get_isDone,set_isDone,true);
		addMember(l,"duration",get_duration,set_duration,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Director.PlayableHandle),typeof(System.ValueType));
	}
}
