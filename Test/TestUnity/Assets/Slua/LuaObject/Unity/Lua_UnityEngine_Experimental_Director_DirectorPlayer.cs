using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Experimental_Director_DirectorPlayer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.DirectorPlayer o;
			o=new UnityEngine.Experimental.Director.DirectorPlayer();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Experimental.Director.DirectorPlayer self=(UnityEngine.Experimental.Director.DirectorPlayer)checkSelf(l);
				UnityEngine.Experimental.Director.Playable a1;
				checkType(l,2,out a1);
				self.Play(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Experimental.Director.DirectorPlayer self=(UnityEngine.Experimental.Director.DirectorPlayer)checkSelf(l);
				UnityEngine.Experimental.Director.Playable a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.Play(a1,a2);
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
	static public int Stop(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.DirectorPlayer self=(UnityEngine.Experimental.Director.DirectorPlayer)checkSelf(l);
			self.Stop();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTime(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.DirectorPlayer self=(UnityEngine.Experimental.Director.DirectorPlayer)checkSelf(l);
			System.Double a1;
			checkType(l,2,out a1);
			self.SetTime(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTime(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.DirectorPlayer self=(UnityEngine.Experimental.Director.DirectorPlayer)checkSelf(l);
			var ret=self.GetTime();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTimeUpdateMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.DirectorPlayer self=(UnityEngine.Experimental.Director.DirectorPlayer)checkSelf(l);
			UnityEngine.Experimental.Director.DirectorUpdateMode a1;
			checkEnum(l,2,out a1);
			self.SetTimeUpdateMode(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTimeUpdateMode(IntPtr l) {
		try {
			UnityEngine.Experimental.Director.DirectorPlayer self=(UnityEngine.Experimental.Director.DirectorPlayer)checkSelf(l);
			var ret=self.GetTimeUpdateMode();
			pushValue(l,true);
			pushEnum(l,(int)ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Experimental.Director.DirectorPlayer");
		addMember(l,Play);
		addMember(l,Stop);
		addMember(l,SetTime);
		addMember(l,GetTime);
		addMember(l,SetTimeUpdateMode);
		addMember(l,GetTimeUpdateMode);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Experimental.Director.DirectorPlayer),typeof(UnityEngine.Behaviour));
	}
}
