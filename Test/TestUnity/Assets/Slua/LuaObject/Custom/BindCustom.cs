using System;
using System.Collections.Generic;
namespace SLua {
	[LuaBinder(3)]
	public class BindCustom {
		public static Action<IntPtr>[] GetBindList() {
			Action<IntPtr>[] list= {
				Lua_System_Collections_Generic_List_1_int.reg,
				Lua_System_Collections_Generic_Dictionary_2_int_string.reg,
				Lua_System_String.reg,
				Lua_System_Int32.reg,
				Lua_System_UInt32.reg,
				Lua_System_Int64.reg,
				Lua_System_UInt64.reg,
				Lua_System_Single.reg,
				Lua_System_Double.reg,
			};
			return list;
		}
	}
}
