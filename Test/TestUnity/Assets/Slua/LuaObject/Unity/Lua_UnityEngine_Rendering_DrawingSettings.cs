using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_DrawingSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings o;
			o=new UnityEngine.Rendering.DrawingSettings();
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
	static public int ctor__ShaderTagId__SortingSettings_s(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings o;
			UnityEngine.Rendering.ShaderTagId a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.SortingSettings a2;
			checkValueType(l,2,out a2);
			o=new UnityEngine.Rendering.DrawingSettings(a1,a2);
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
	static public int GetShaderPassName(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetShaderPassName(a1);
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
	static public int SetShaderPassName(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Rendering.ShaderTagId a2;
			checkValueType(l,3,out a2);
			self.SetShaderPassName(a1,a2);
			pushValue(l,true);
			setBack(l,(object)self);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Equals__DrawingSettings(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.DrawingSettings a1;
			checkValueType(l,2,out a1);
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
	static public int Equals__Object(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
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
	static public int op_Equality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.DrawingSettings a2;
			checkValueType(l,2,out a2);
			var ret=(a1==a2);
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
	static public int op_Inequality_s(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.DrawingSettings a2;
			checkValueType(l,2,out a2);
			var ret=(a1!=a2);
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
	static public int get_maxShaderPasses(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Rendering.DrawingSettings.maxShaderPasses);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sortingSettings(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.sortingSettings);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sortingSettings(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.SortingSettings v;
			checkValueType(l,2,out v);
			self.sortingSettings=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_perObjectData(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.perObjectData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_perObjectData(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.PerObjectData v;
			checkEnum(l,2,out v);
			self.perObjectData=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableDynamicBatching(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.enableDynamicBatching);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableDynamicBatching(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.enableDynamicBatching=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enableInstancing(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.enableInstancing);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enableInstancing(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.enableInstancing=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overrideMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.overrideMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overrideMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Material v;
			checkType(l,2,out v);
			self.overrideMaterial=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overrideMaterialPassIndex(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.overrideMaterialPassIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overrideMaterialPassIndex(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.overrideMaterialPassIndex=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fallbackMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.fallbackMaterial);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fallbackMaterial(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Material v;
			checkType(l,2,out v);
			self.fallbackMaterial=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_mainLightIndex(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.mainLightIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mainLightIndex(IntPtr l) {
		try {
			UnityEngine.Rendering.DrawingSettings self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.mainLightIndex=v;
			setBack(l,(object)self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.DrawingSettings");
		addMember(l,ctor_s);
		addMember(l,ctor__ShaderTagId__SortingSettings_s);
		addMember(l,GetShaderPassName);
		addMember(l,SetShaderPassName);
		addMember(l,Equals__DrawingSettings);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"maxShaderPasses",get_maxShaderPasses,null,false);
		addMember(l,"sortingSettings",get_sortingSettings,set_sortingSettings,true);
		addMember(l,"perObjectData",get_perObjectData,set_perObjectData,true);
		addMember(l,"enableDynamicBatching",get_enableDynamicBatching,set_enableDynamicBatching,true);
		addMember(l,"enableInstancing",get_enableInstancing,set_enableInstancing,true);
		addMember(l,"overrideMaterial",get_overrideMaterial,set_overrideMaterial,true);
		addMember(l,"overrideMaterialPassIndex",get_overrideMaterialPassIndex,set_overrideMaterialPassIndex,true);
		addMember(l,"fallbackMaterial",get_fallbackMaterial,set_fallbackMaterial,true);
		addMember(l,"mainLightIndex",get_mainLightIndex,set_mainLightIndex,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.DrawingSettings),typeof(System.ValueType));
	}
}
