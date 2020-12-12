using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_SceneManagement_SceneManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.SceneManagement.SceneManager o;
			o=new UnityEngine.SceneManagement.SceneManager();
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
	static public int GetActiveScene_s(IntPtr l) {
		try {
			var ret=UnityEngine.SceneManagement.SceneManager.GetActiveScene();
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
	static public int SetActiveScene_s(IntPtr l) {
		try {
			UnityEngine.SceneManagement.Scene a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.SceneManagement.SceneManager.SetActiveScene(a1);
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
	static public int GetSceneByPath_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.SceneManagement.SceneManager.GetSceneByPath(a1);
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
	static public int GetSceneByName_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.SceneManagement.SceneManager.GetSceneByName(a1);
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
	static public int GetSceneByBuildIndex_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex(a1);
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
	static public int GetSceneAt_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.SceneManagement.SceneManager.GetSceneAt(a1);
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
	static public int CreateScene__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.SceneManagement.SceneManager.CreateScene(a1);
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
	static public int CreateScene__String__CreateSceneParameters_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.CreateSceneParameters a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.SceneManagement.SceneManager.CreateScene(a1,a2);
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
	static public int MergeScenes_s(IntPtr l) {
		try {
			UnityEngine.SceneManagement.Scene a1;
			checkValueType(l,1,out a1);
			UnityEngine.SceneManagement.Scene a2;
			checkValueType(l,2,out a2);
			UnityEngine.SceneManagement.SceneManager.MergeScenes(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int MoveGameObjectToScene_s(IntPtr l) {
		try {
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.Scene a2;
			checkValueType(l,2,out a2);
			UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadScene__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.SceneManager.LoadScene(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadScene__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.SceneManager.LoadScene(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadScene__String__LoadSceneMode_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.LoadSceneMode a2;
			checkEnum(l,2,out a2);
			UnityEngine.SceneManagement.SceneManager.LoadScene(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadScene__String__LoadSceneParameters_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.LoadSceneParameters a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.SceneManagement.SceneManager.LoadScene(a1,a2);
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
	static public int LoadScene__Int32__LoadSceneMode_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.LoadSceneMode a2;
			checkEnum(l,2,out a2);
			UnityEngine.SceneManagement.SceneManager.LoadScene(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadScene__Int32__LoadSceneParameters_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.LoadSceneParameters a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.SceneManagement.SceneManager.LoadScene(a1,a2);
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
	static public int LoadSceneAsync__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(a1);
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
	static public int LoadSceneAsync__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(a1);
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
	static public int LoadSceneAsync__Int32__LoadSceneMode_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.LoadSceneMode a2;
			checkEnum(l,2,out a2);
			var ret=UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(a1,a2);
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
	static public int LoadSceneAsync__Int32__LoadSceneParameters_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.LoadSceneParameters a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(a1,a2);
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
	static public int LoadSceneAsync__String__LoadSceneMode_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.LoadSceneMode a2;
			checkEnum(l,2,out a2);
			var ret=UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(a1,a2);
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
	static public int LoadSceneAsync__String__LoadSceneParameters_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.LoadSceneParameters a2;
			checkValueType(l,2,out a2);
			var ret=UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(a1,a2);
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
	static public int UnloadSceneAsync__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(a1);
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
	static public int UnloadSceneAsync__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(a1);
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
	static public int UnloadSceneAsync__Scene_s(IntPtr l) {
		try {
			UnityEngine.SceneManagement.Scene a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(a1);
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
	static public int UnloadSceneAsync__Int32__UnloadSceneOptions_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.UnloadSceneOptions a2;
			checkEnum(l,2,out a2);
			var ret=UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(a1,a2);
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
	static public int UnloadSceneAsync__String__UnloadSceneOptions_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			UnityEngine.SceneManagement.UnloadSceneOptions a2;
			checkEnum(l,2,out a2);
			var ret=UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(a1,a2);
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
	static public int UnloadSceneAsync__Scene__UnloadSceneOptions_s(IntPtr l) {
		try {
			UnityEngine.SceneManagement.Scene a1;
			checkValueType(l,1,out a1);
			UnityEngine.SceneManagement.UnloadSceneOptions a2;
			checkEnum(l,2,out a2);
			var ret=UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(a1,a2);
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
	static public int get_sceneCount(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SceneManagement.SceneManager.sceneCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sceneCountInBuildSettings(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SceneManagement.SceneManager");
		addMember(l,ctor_s);
		addMember(l,GetActiveScene_s);
		addMember(l,SetActiveScene_s);
		addMember(l,GetSceneByPath_s);
		addMember(l,GetSceneByName_s);
		addMember(l,GetSceneByBuildIndex_s);
		addMember(l,GetSceneAt_s);
		addMember(l,CreateScene__String_s);
		addMember(l,CreateScene__String__CreateSceneParameters_s);
		addMember(l,MergeScenes_s);
		addMember(l,MoveGameObjectToScene_s);
		addMember(l,LoadScene__String_s);
		addMember(l,LoadScene__Int32_s);
		addMember(l,LoadScene__String__LoadSceneMode_s);
		addMember(l,LoadScene__String__LoadSceneParameters_s);
		addMember(l,LoadScene__Int32__LoadSceneMode_s);
		addMember(l,LoadScene__Int32__LoadSceneParameters_s);
		addMember(l,LoadSceneAsync__Int32_s);
		addMember(l,LoadSceneAsync__String_s);
		addMember(l,LoadSceneAsync__Int32__LoadSceneMode_s);
		addMember(l,LoadSceneAsync__Int32__LoadSceneParameters_s);
		addMember(l,LoadSceneAsync__String__LoadSceneMode_s);
		addMember(l,LoadSceneAsync__String__LoadSceneParameters_s);
		addMember(l,UnloadSceneAsync__Int32_s);
		addMember(l,UnloadSceneAsync__String_s);
		addMember(l,UnloadSceneAsync__Scene_s);
		addMember(l,UnloadSceneAsync__Int32__UnloadSceneOptions_s);
		addMember(l,UnloadSceneAsync__String__UnloadSceneOptions_s);
		addMember(l,UnloadSceneAsync__Scene__UnloadSceneOptions_s);
		addMember(l,"sceneCount",get_sceneCount,null,false);
		addMember(l,"sceneCountInBuildSettings",get_sceneCountInBuildSettings,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.SceneManagement.SceneManager));
	}
}
