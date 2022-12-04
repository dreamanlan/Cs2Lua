using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Globalization_CultureInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__Int32_s(IntPtr l) {
		try {
			System.Globalization.CultureInfo o;
			System.Int32 a1;
			checkType(l,1,out a1);
			o=new System.Globalization.CultureInfo(a1);
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
	static public int ctor__String_s(IntPtr l) {
		try {
			System.Globalization.CultureInfo o;
			System.String a1;
			checkType(l,1,out a1);
			o=new System.Globalization.CultureInfo(a1);
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
	static public int ctor__Int32__Boolean_s(IntPtr l) {
		try {
			System.Globalization.CultureInfo o;
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			o=new System.Globalization.CultureInfo(a1,a2);
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
	static public int ctor__String__Boolean_s(IntPtr l) {
		try {
			System.Globalization.CultureInfo o;
			System.String a1;
			checkType(l,1,out a1);
			System.Boolean a2;
			checkType(l,2,out a2);
			o=new System.Globalization.CultureInfo(a1,a2);
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
	static public int GetConsoleFallbackUICulture(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			var ret=self.GetConsoleFallbackUICulture();
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
	static public int ClearCachedData(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			self.ClearCachedData();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Clone(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			var ret=self.Clone();
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
	static new public int Equals(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			System.Object a1;
			checkType(l,2,out a1);
			var ret=self.Equals(a1);
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
	static new public int ToString(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			var ret=self.ToString();
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
	static public int GetFormat(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetFormat(a1);
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
	static public int GetCultures_s(IntPtr l) {
		try {
			System.Globalization.CultureTypes a1;
			checkEnum(l,1,out a1);
			var ret=System.Globalization.CultureInfo.GetCultures(a1);
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
	static public int ReadOnly_s(IntPtr l) {
		try {
			System.Globalization.CultureInfo a1;
			checkType(l,1,out a1);
			var ret=System.Globalization.CultureInfo.ReadOnly(a1);
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
	static public int GetCultureInfo__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=System.Globalization.CultureInfo.GetCultureInfo(a1);
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
	static public int GetCultureInfo__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.Globalization.CultureInfo.GetCultureInfo(a1);
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
	static public int GetCultureInfo__String__String_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			var ret=System.Globalization.CultureInfo.GetCultureInfo(a1,a2);
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
	static public int GetCultureInfoByIetfLanguageTag_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.Globalization.CultureInfo.GetCultureInfoByIetfLanguageTag(a1);
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
	static public int CreateSpecificCulture_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=System.Globalization.CultureInfo.CreateSpecificCulture(a1);
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
	static public int get_InvariantCulture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Globalization.CultureInfo.InvariantCulture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CurrentCulture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Globalization.CultureInfo.CurrentCulture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_CurrentCulture(IntPtr l) {
		try {
			System.Globalization.CultureInfo v;
			checkType(l,2,out v);
			System.Globalization.CultureInfo.CurrentCulture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CurrentUICulture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Globalization.CultureInfo.CurrentUICulture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_CurrentUICulture(IntPtr l) {
		try {
			System.Globalization.CultureInfo v;
			checkType(l,2,out v);
			System.Globalization.CultureInfo.CurrentUICulture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CultureTypes(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.CultureTypes);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IetfLanguageTag(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IetfLanguageTag);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_KeyboardLayoutId(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.KeyboardLayoutId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_LCID(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.LCID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Name(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_NativeName(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.NativeName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Calendar(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Calendar);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_OptionalCalendars(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.OptionalCalendars);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Parent(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Parent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_TextInfo(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.TextInfo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ThreeLetterISOLanguageName(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ThreeLetterISOLanguageName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ThreeLetterWindowsLanguageName(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ThreeLetterWindowsLanguageName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_TwoLetterISOLanguageName(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.TwoLetterISOLanguageName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_UseUserOverride(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.UseUserOverride);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_CompareInfo(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CompareInfo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsNeutralCulture(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsNeutralCulture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_NumberFormat(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.NumberFormat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_NumberFormat(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			System.Globalization.NumberFormatInfo v;
			checkType(l,2,out v);
			self.NumberFormat=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DateTimeFormat(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.DateTimeFormat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_DateTimeFormat(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			System.Globalization.DateTimeFormatInfo v;
			checkType(l,2,out v);
			self.DateTimeFormat=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DisplayName(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.DisplayName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_EnglishName(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.EnglishName);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_InstalledUICulture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Globalization.CultureInfo.InstalledUICulture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IsReadOnly(IntPtr l) {
		try {
			System.Globalization.CultureInfo self=(System.Globalization.CultureInfo)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.IsReadOnly);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DefaultThreadCurrentCulture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Globalization.CultureInfo.DefaultThreadCurrentCulture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_DefaultThreadCurrentCulture(IntPtr l) {
		try {
			System.Globalization.CultureInfo v;
			checkType(l,2,out v);
			System.Globalization.CultureInfo.DefaultThreadCurrentCulture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DefaultThreadCurrentUICulture(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,System.Globalization.CultureInfo.DefaultThreadCurrentUICulture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_DefaultThreadCurrentUICulture(IntPtr l) {
		try {
			System.Globalization.CultureInfo v;
			checkType(l,2,out v);
			System.Globalization.CultureInfo.DefaultThreadCurrentUICulture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"System.Globalization.CultureInfo");
		addMember(l,ctor__Int32_s);
		addMember(l,ctor__String_s);
		addMember(l,ctor__Int32__Boolean_s);
		addMember(l,ctor__String__Boolean_s);
		addMember(l,GetConsoleFallbackUICulture);
		addMember(l,ClearCachedData);
		addMember(l,Clone);
		addMember(l,Equals);
		addMember(l,ToString);
		addMember(l,GetFormat);
		addMember(l,GetCultures_s);
		addMember(l,ReadOnly_s);
		addMember(l,GetCultureInfo__Int32_s);
		addMember(l,GetCultureInfo__String_s);
		addMember(l,GetCultureInfo__String__String_s);
		addMember(l,GetCultureInfoByIetfLanguageTag_s);
		addMember(l,CreateSpecificCulture_s);
		addMember(l,"InvariantCulture",get_InvariantCulture,null,false);
		addMember(l,"CurrentCulture",get_CurrentCulture,set_CurrentCulture,false);
		addMember(l,"CurrentUICulture",get_CurrentUICulture,set_CurrentUICulture,false);
		addMember(l,"CultureTypes",get_CultureTypes,null,true);
		addMember(l,"IetfLanguageTag",get_IetfLanguageTag,null,true);
		addMember(l,"KeyboardLayoutId",get_KeyboardLayoutId,null,true);
		addMember(l,"LCID",get_LCID,null,true);
		addMember(l,"Name",get_Name,null,true);
		addMember(l,"NativeName",get_NativeName,null,true);
		addMember(l,"Calendar",get_Calendar,null,true);
		addMember(l,"OptionalCalendars",get_OptionalCalendars,null,true);
		addMember(l,"Parent",get_Parent,null,true);
		addMember(l,"TextInfo",get_TextInfo,null,true);
		addMember(l,"ThreeLetterISOLanguageName",get_ThreeLetterISOLanguageName,null,true);
		addMember(l,"ThreeLetterWindowsLanguageName",get_ThreeLetterWindowsLanguageName,null,true);
		addMember(l,"TwoLetterISOLanguageName",get_TwoLetterISOLanguageName,null,true);
		addMember(l,"UseUserOverride",get_UseUserOverride,null,true);
		addMember(l,"CompareInfo",get_CompareInfo,null,true);
		addMember(l,"IsNeutralCulture",get_IsNeutralCulture,null,true);
		addMember(l,"NumberFormat",get_NumberFormat,set_NumberFormat,true);
		addMember(l,"DateTimeFormat",get_DateTimeFormat,set_DateTimeFormat,true);
		addMember(l,"DisplayName",get_DisplayName,null,true);
		addMember(l,"EnglishName",get_EnglishName,null,true);
		addMember(l,"InstalledUICulture",get_InstalledUICulture,null,false);
		addMember(l,"IsReadOnly",get_IsReadOnly,null,true);
		addMember(l,"DefaultThreadCurrentCulture",get_DefaultThreadCurrentCulture,set_DefaultThreadCurrentCulture,false);
		addMember(l,"DefaultThreadCurrentUICulture",get_DefaultThreadCurrentUICulture,set_DefaultThreadCurrentUICulture,false);
		createTypeMetatable(l,null, typeof(System.Globalization.CultureInfo));
	}
}
