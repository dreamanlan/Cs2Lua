﻿using System;
using System.Collections.Generic;
namespace SLua {
	[LuaBinder(3)]
	public class BindCustom {
		public static Action<IntPtr>[] GetBindList() {
			Action<IntPtr>[] list= {
				Lua_System_Object.reg,
				Lua_System_Exception.reg,
				Lua_System_String.reg,
				Lua_System_Array.reg,
				Lua_System_Collections_ArrayList.reg,
				Lua_System_Collections_Hashtable.reg,
				Lua_System_Collections_BitArray.reg,
				Lua_System_Collections_Queue.reg,
				Lua_System_Collections_Stack.reg,
				Lua_System_Collections_SortedList.reg,
				Lua_System_Byte.reg,
				Lua_System_Boolean.reg,
				Lua_System_SByte.reg,
				Lua_System_Byte.reg,
				Lua_System_Int16.reg,
				Lua_System_UInt16.reg,
				Lua_System_Int32.reg,
				Lua_System_UInt32.reg,
				Lua_System_Int64.reg,
				Lua_System_UInt64.reg,
				Lua_System_Single.reg,
				Lua_System_Double.reg,
				Lua_System_Convert.reg,
				Lua_System_TypeCode.reg,
				Lua_System_Reflection_MemberInfo.reg,
				Lua_System_Type.reg,
				Lua_System_IO_File.reg,
				Lua_System_IO_Path.reg,
				Lua_System_IO_Directory.reg,
				Lua_System_IO_DirectoryInfo.reg,
				Lua_System_IO_Stream.reg,
				Lua_System_IO_FileStream.reg,
				Lua_System_IO_BinaryReader.reg,
				Lua_System_IO_BinaryWriter.reg,
				Lua_System_DateTime.reg,
				Lua_System_TimeSpan.reg,
				Lua_System_Math.reg,
				Lua_System_Random.reg,
				Lua_System_Delegate.reg,
				Lua_System_Globalization_CultureInfo.reg,
				Lua_System_Text_StringBuilder.reg,
				Lua_System_Text_Encoding.reg,
				Lua_System_Text_ASCIIEncoding.reg,
				Lua_System_Text_UTF8Encoding.reg,
				Lua_System_Text_UnicodeEncoding.reg,
				Lua_System_Text_RegularExpressions_Regex.reg,
				Lua_System_Text_RegularExpressions_Capture.reg,
				Lua_System_Text_RegularExpressions_Group.reg,
				Lua_System_Text_RegularExpressions_Match.reg,
				Lua_System_Text_RegularExpressions_MatchCollection.reg,
				Lua_System_Text_RegularExpressions_GroupCollection.reg,
				Lua_System_Text_RegularExpressions_CaptureCollection.reg,
				Lua_System_GC.reg,
				Lua_System_Collections_Generic_KeyValuePair_2_int_int.reg,
				Lua_System_Collections_Generic_KeyValuePair_2_int_float.reg,
				Lua_System_Collections_Generic_KeyValuePair_2_int_string.reg,
				Lua_System_Collections_Generic_KeyValuePair_2_int_System_Object.reg,
				Lua_System_Collections_Generic_KeyValuePair_2_int_UnityEngine_Object.reg,
				Lua_System_Collections_Generic_KeyValuePair_2_string_int.reg,
				Lua_System_Collections_Generic_KeyValuePair_2_string_float.reg,
				Lua_System_Collections_Generic_KeyValuePair_2_string_string.reg,
				Lua_System_Collections_Generic_KeyValuePair_2_string_System_Object.reg,
				Lua_System_Collections_Generic_KeyValuePair_2_string_UnityEngine_Object.reg,
			};
			return list;
		}
	}
}
