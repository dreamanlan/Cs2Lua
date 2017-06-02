using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Debug : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Debug o;
			o=new UnityEngine.Debug();
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
	static public int DrawLine_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.DrawLine(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				UnityEngine.Debug.DrawLine(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Debug.DrawLine(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Boolean a5;
				checkType(l,5,out a5);
				UnityEngine.Debug.DrawLine(a1,a2,a3,a4,a5);
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
	static public int DrawRay_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.DrawRay(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				UnityEngine.Debug.DrawRay(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				UnityEngine.Debug.DrawRay(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Vector3 a1;
				checkType(l,1,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,2,out a2);
				UnityEngine.Color a3;
				checkType(l,3,out a3);
				System.Single a4;
				checkType(l,4,out a4);
				System.Boolean a5;
				checkType(l,5,out a5);
				UnityEngine.Debug.DrawRay(a1,a2,a3,a4,a5);
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
	static public int Break_s(IntPtr l) {
		try {
			UnityEngine.Debug.Break();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DebugBreak_s(IntPtr l) {
		try {
			UnityEngine.Debug.DebugBreak();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Log_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Debug.Log(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.Log(a1,a2);
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
	static public int LogFormat_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Object[] a2;
				checkParams(l,2,out a2);
				UnityEngine.Debug.LogFormat(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				System.Object[] a3;
				checkParams(l,3,out a3);
				UnityEngine.Debug.LogFormat(a1,a2,a3);
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
	static public int LogError_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Debug.LogError(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.LogError(a1,a2);
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
	static public int LogErrorFormat_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Object[] a2;
				checkParams(l,2,out a2);
				UnityEngine.Debug.LogErrorFormat(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				System.Object[] a3;
				checkParams(l,3,out a3);
				UnityEngine.Debug.LogErrorFormat(a1,a2,a3);
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
	static public int ClearDeveloperConsole_s(IntPtr l) {
		try {
			UnityEngine.Debug.ClearDeveloperConsole();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogException_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Exception a1;
				checkType(l,1,out a1);
				UnityEngine.Debug.LogException(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.Exception a1;
				checkType(l,1,out a1);
				UnityEngine.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.LogException(a1,a2);
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
	static public int LogWarning_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Debug.LogWarning(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.LogWarning(a1,a2);
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
	static public int LogWarningFormat_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Object[] a2;
				checkParams(l,2,out a2);
				UnityEngine.Debug.LogWarningFormat(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				System.Object[] a3;
				checkParams(l,3,out a3);
				UnityEngine.Debug.LogWarningFormat(a1,a2,a3);
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
	static public int Assert_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Boolean a1;
				checkType(l,1,out a1);
				UnityEngine.Debug.Assert(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(bool),typeof(string))){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.Assert(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(bool),typeof(System.Object))){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.Assert(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(bool),typeof(UnityEngine.Object))){
				System.Boolean a1;
				checkType(l,1,out a1);
				UnityEngine.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.Assert(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(bool),typeof(string),typeof(UnityEngine.Object))){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				UnityEngine.Object a3;
				checkType(l,3,out a3);
				UnityEngine.Debug.Assert(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,1,typeof(bool),typeof(System.Object),typeof(UnityEngine.Object))){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Object a3;
				checkType(l,3,out a3);
				UnityEngine.Debug.Assert(a1,a2,a3);
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
	static public int AssertFormat_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				System.Boolean a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				System.Object[] a3;
				checkParams(l,3,out a3);
				UnityEngine.Debug.AssertFormat(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				System.Boolean a1;
				checkType(l,1,out a1);
				UnityEngine.Object a2;
				checkType(l,2,out a2);
				System.String a3;
				checkType(l,3,out a3);
				System.Object[] a4;
				checkParams(l,4,out a4);
				UnityEngine.Debug.AssertFormat(a1,a2,a3,a4);
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
	static public int LogAssertion_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Debug.LogAssertion(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==2){
				System.Object a1;
				checkType(l,1,out a1);
				UnityEngine.Object a2;
				checkType(l,2,out a2);
				UnityEngine.Debug.LogAssertion(a1,a2);
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
	static public int LogAssertionFormat_s(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				System.String a1;
				checkType(l,1,out a1);
				System.Object[] a2;
				checkParams(l,2,out a2);
				UnityEngine.Debug.LogAssertionFormat(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Object a1;
				checkType(l,1,out a1);
				System.String a2;
				checkType(l,2,out a2);
				System.Object[] a3;
				checkParams(l,3,out a3);
				UnityEngine.Debug.LogAssertionFormat(a1,a2,a3);
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
	static public int get_logger(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Debug.logger);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_developerConsoleVisible(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Debug.developerConsoleVisible);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_developerConsoleVisible(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Debug.developerConsoleVisible=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_isDebugBuild(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Debug.isDebugBuild);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Debug");
		addMember(l,DrawLine_s);
		addMember(l,DrawRay_s);
		addMember(l,Break_s);
		addMember(l,DebugBreak_s);
		addMember(l,Log_s);
		addMember(l,LogFormat_s);
		addMember(l,LogError_s);
		addMember(l,LogErrorFormat_s);
		addMember(l,ClearDeveloperConsole_s);
		addMember(l,LogException_s);
		addMember(l,LogWarning_s);
		addMember(l,LogWarningFormat_s);
		addMember(l,Assert_s);
		addMember(l,AssertFormat_s);
		addMember(l,LogAssertion_s);
		addMember(l,LogAssertionFormat_s);
		addMember(l,"logger",get_logger,null,false);
		addMember(l,"developerConsoleVisible",get_developerConsoleVisible,set_developerConsoleVisible,false);
		addMember(l,"isDebugBuild",get_isDebugBuild,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Debug));
	}
}
