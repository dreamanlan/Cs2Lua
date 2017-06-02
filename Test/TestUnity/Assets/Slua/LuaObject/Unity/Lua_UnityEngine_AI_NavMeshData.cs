using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_NavMeshData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.AI.NavMeshData o;
			if(argc==1){
				o=new UnityEngine.AI.NavMeshData();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				System.Int32 a1;
				checkType(l,2,out a1);
				o=new UnityEngine.AI.NavMeshData(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sourceBounds(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshData self=(UnityEngine.AI.NavMeshData)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sourceBounds);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AI.NavMeshData");
		addMember(l,"sourceBounds",get_sourceBounds,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AI.NavMeshData),typeof(UnityEngine.Object));
	}
}
