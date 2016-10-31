using System;
using System.Collections.Generic;
namespace SLua {
	[LuaBinder(2)]
	public class BindDll {
		public static Action<IntPtr>[] GetBindList() {
			Action<IntPtr>[] list= {
				Lua_PluginManager.reg,
			};
			return list;
		}
	}
}
