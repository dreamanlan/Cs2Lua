using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Debug : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
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
	static public int DrawLine__Vector3__Vector3_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Debug.DrawLine(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawLine__Vector3__Vector3__Color_s(IntPtr l) {
		try {
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
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawLine__Vector3__Vector3__Color__Single_s(IntPtr l) {
		try {
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
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawLine__Vector3__Vector3__Color__Single__Boolean_s(IntPtr l) {
		try {
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
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawRay__Vector3__Vector3_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Debug.DrawRay(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawRay__Vector3__Vector3__Color_s(IntPtr l) {
		try {
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
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawRay__Vector3__Vector3__Color__Single_s(IntPtr l) {
		try {
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
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DrawRay__Vector3__Vector3__Color__Single__Boolean_s(IntPtr l) {
		try {
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
	static public int Log__Object_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Debug.Log(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Log__Object__Object_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			UnityEngine.Debug.Log(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogError__Object_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Debug.LogError(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogError__Object__Object_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			UnityEngine.Debug.LogError(a1,a2);
			pushValue(l,true);
			return 1;
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
	static public int LogException__Exception_s(IntPtr l) {
		try {
			System.Exception a1;
			checkType(l,1,out a1);
			UnityEngine.Debug.LogException(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogException__Exception__Object_s(IntPtr l) {
		try {
			System.Exception a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			UnityEngine.Debug.LogException(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogWarning__Object_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Debug.LogWarning(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogWarning__Object__Object_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			UnityEngine.Debug.LogWarning(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Assert__Boolean_s(IntPtr l) {
		try {
			System.Boolean a1;
			checkType(l,1,out a1);
			UnityEngine.Debug.Assert(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Assert__Boolean__Object_s(IntPtr l) {
		try {
			System.Boolean a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			UnityEngine.Debug.Assert(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Assert__Boolean__String_s(IntPtr l) {
		try {
			System.Boolean a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Debug.Assert(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Assert__Boolean__Object__Object_s(IntPtr l) {
		try {
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
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Assert__Boolean__String__Object_s(IntPtr l) {
		try {
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
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AssertFormat__Boolean__String__A_Object_s(IntPtr l) {
		try {
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
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AssertFormat__Boolean__Object__String__A_Object_s(IntPtr l) {
		try {
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
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogAssertion__Object_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Debug.LogAssertion(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LogAssertion__Object__Object_s(IntPtr l) {
		try {
			System.Object a1;
			checkType(l,1,out a1);
			UnityEngine.Object a2;
			checkType(l,2,out a2);
			UnityEngine.Debug.LogAssertion(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_unityLogger(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Debug.unityLogger);
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
		addMember(l,ctor_s);
		addMember(l,DrawLine__Vector3__Vector3_s);
		addMember(l,DrawLine__Vector3__Vector3__Color_s);
		addMember(l,DrawLine__Vector3__Vector3__Color__Single_s);
		addMember(l,DrawLine__Vector3__Vector3__Color__Single__Boolean_s);
		addMember(l,DrawRay__Vector3__Vector3_s);
		addMember(l,DrawRay__Vector3__Vector3__Color_s);
		addMember(l,DrawRay__Vector3__Vector3__Color__Single_s);
		addMember(l,DrawRay__Vector3__Vector3__Color__Single__Boolean_s);
		addMember(l,Break_s);
		addMember(l,DebugBreak_s);
		addMember(l,Log__Object_s);
		addMember(l,Log__Object__Object_s);
		addMember(l,LogError__Object_s);
		addMember(l,LogError__Object__Object_s);
		addMember(l,ClearDeveloperConsole_s);
		addMember(l,LogException__Exception_s);
		addMember(l,LogException__Exception__Object_s);
		addMember(l,LogWarning__Object_s);
		addMember(l,LogWarning__Object__Object_s);
		addMember(l,Assert__Boolean_s);
		addMember(l,Assert__Boolean__Object_s);
		addMember(l,Assert__Boolean__String_s);
		addMember(l,Assert__Boolean__Object__Object_s);
		addMember(l,Assert__Boolean__String__Object_s);
		addMember(l,AssertFormat__Boolean__String__A_Object_s);
		addMember(l,AssertFormat__Boolean__Object__String__A_Object_s);
		addMember(l,LogAssertion__Object_s);
		addMember(l,LogAssertion__Object__Object_s);
		addMember(l,"unityLogger",get_unityLogger,null,false);
		addMember(l,"developerConsoleVisible",get_developerConsoleVisible,set_developerConsoleVisible,false);
		addMember(l,"isDebugBuild",get_isDebugBuild,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Debug));
	}
}
