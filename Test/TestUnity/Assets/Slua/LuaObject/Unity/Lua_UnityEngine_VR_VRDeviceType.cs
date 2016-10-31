using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_VR_VRDeviceType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.VR.VRDeviceType");
		addMember(l,0,"None");
		addMember(l,1,"Stereo");
		addMember(l,2,"Split");
		addMember(l,3,"Oculus");
		addMember(l,4,"PlayStationVR");
		addMember(l,4,"Morpheus");
		LuaDLL.lua_pop(l, 1);
	}
}
