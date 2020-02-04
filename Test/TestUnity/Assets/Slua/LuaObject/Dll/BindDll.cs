using System;
using System.Collections.Generic;
namespace SLua {
	[LuaBinder(2)]
	public class BindDll {
		public static Action<IntPtr>[] GetBindList() {
			Action<IntPtr>[] list= {
				Lua_IStartupPlugin.reg,
				Lua_IStartupPluginFactory.reg,
				Lua_ITickPlugin.reg,
				Lua_ITickPluginFactory.reg,
				Lua_IObjectPluginFactory.reg,
				Lua_PluginManager.reg,
				Lua_MonoBehaviourProxy.reg,
				Lua_Utility.reg,
			};
			return list;
		}
	}
}
