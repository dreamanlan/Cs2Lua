using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_Director_PlayableGraph : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph o;
			o=new UnityEngine.Experimental.Director.PlayableGraph();
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
	static public int IsValid(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
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
	static public int Play(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
			checkValueType(l,1,out self);
			self.Play();
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
	static public int Stop(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
			checkValueType(l,1,out self);
			self.Stop();
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
	static public int CreateScriptOutput(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
			checkValueType(l,1,out self);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.CreateScriptOutput(a1);
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
	static public int GetScriptOutput(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetScriptOutput(a1);
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
	static public int CreatePlayable(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
			checkValueType(l,1,out self);
			var ret=self.CreatePlayable();
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
	static public int CreateGenericMixerPlayable(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Experimental.Director.PlayableGraph self;
				checkValueType(l,1,out self);
				var ret=self.CreateGenericMixerPlayable();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Experimental.Director.PlayableGraph self;
				checkValueType(l,1,out self);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.CreateGenericMixerPlayable(a1);
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
	static public int Destroy(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
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
	static public int Connect(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Experimental.Director.Playable),typeof(int),typeof(UnityEngine.Experimental.Director.Playable),typeof(int))){
				UnityEngine.Experimental.Director.PlayableGraph self;
				checkValueType(l,1,out self);
				UnityEngine.Experimental.Director.Playable a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.Experimental.Director.Playable a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				var ret=self.Connect(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Experimental.Director.PlayableHandle),typeof(int),typeof(UnityEngine.Experimental.Director.PlayableHandle),typeof(int))){
				UnityEngine.Experimental.Director.PlayableGraph self;
				checkValueType(l,1,out self);
				UnityEngine.Experimental.Director.PlayableHandle a1;
				checkValueType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.Experimental.Director.PlayableHandle a3;
				checkValueType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				var ret=self.Connect(a1,a2,a3,a4);
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
	static public int Disconnect(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Experimental.Director.PlayableHandle),typeof(int))){
				UnityEngine.Experimental.Director.PlayableGraph self;
				checkValueType(l,1,out self);
				UnityEngine.Experimental.Director.PlayableHandle a1;
				checkValueType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.Disconnect(a1,a2);
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Experimental.Director.Playable),typeof(int))){
				UnityEngine.Experimental.Director.PlayableGraph self;
				checkValueType(l,1,out self);
				UnityEngine.Experimental.Director.Playable a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.Disconnect(a1,a2);
				pushValue(l,true);
				setBack(l,self);
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
	static public int DestroyPlayable(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Director.PlayableHandle a1;
			checkValueType(l,2,out a1);
			self.DestroyPlayable(a1);
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
	static public int DestroyOutput(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Director.ScriptPlayableOutput a1;
			checkValueType(l,2,out a1);
			self.DestroyOutput(a1);
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
	static public int DestroySubgraph(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Director.PlayableHandle a1;
			checkValueType(l,2,out a1);
			self.DestroySubgraph(a1);
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
	static public int Evaluate(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Experimental.Director.PlayableGraph self;
				checkValueType(l,1,out self);
				self.Evaluate();
				pushValue(l,true);
				setBack(l,self);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Experimental.Director.PlayableGraph self;
				checkValueType(l,1,out self);
				System.Single a1;
				checkType(l,2,out a1);
				self.Evaluate(a1);
				pushValue(l,true);
				setBack(l,self);
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
	static public int GetRootPlayable(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetRootPlayable(a1);
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
	static public int CreateGraph_s(IntPtr l) {
		try {
			var ret=UnityEngine.Experimental.Director.PlayableGraph.CreateGraph();
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
	static public int get_isDone(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
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
	static public int get_playableCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.playableCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_scriptOutputCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.scriptOutputCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rootPlayableCount(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.PlayableGraph self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.rootPlayableCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Director.PlayableGraph");
		addMember(l,IsValid);
		addMember(l,Play);
		addMember(l,Stop);
		addMember(l,CreateScriptOutput);
		addMember(l,GetScriptOutput);
		addMember(l,CreatePlayable);
		addMember(l,CreateGenericMixerPlayable);
		addMember(l,Destroy);
		addMember(l,Connect);
		addMember(l,Disconnect);
		addMember(l,DestroyPlayable);
		addMember(l,DestroyOutput);
		addMember(l,DestroySubgraph);
		addMember(l,Evaluate);
		addMember(l,GetRootPlayable);
		addMember(l,CreateGraph_s);
		addMember(l,"isDone",get_isDone,null,true);
		addMember(l,"playableCount",get_playableCount,null,true);
		addMember(l,"scriptOutputCount",get_scriptOutputCount,null,true);
		addMember(l,"rootPlayableCount",get_rootPlayableCount,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Director.PlayableGraph),typeof(System.ValueType));
	}
}
