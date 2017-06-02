using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Analytics_AnalyticsResult : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Analytics.AnalyticsResult");
		addMember(l,0,"Ok");
		addMember(l,1,"NotInitialized");
		addMember(l,2,"AnalyticsDisabled");
		addMember(l,3,"TooManyItems");
		addMember(l,4,"SizeLimitReached");
		addMember(l,5,"TooManyRequests");
		addMember(l,6,"InvalidData");
		addMember(l,7,"UnsupportedPlatform");
		LuaDLL.lua_pop(l, 1);
	}
}
