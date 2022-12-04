﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Experimental_GlobalIllumination_LightDataGI : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI o;
			o=new UnityEngine.Experimental.GlobalIllumination.LightDataGI();
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
	static public int Init__R_DirectionalLight(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight a1;
			checkValueType(l,2,out a1);
			self.Init(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			setBack(l,(object)self);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_PointLight(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.PointLight a1;
			checkValueType(l,2,out a1);
			self.Init(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			setBack(l,(object)self);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_SpotLight(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.SpotLight a1;
			checkValueType(l,2,out a1);
			self.Init(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			setBack(l,(object)self);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_RectangleLight(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.RectangleLight a1;
			checkValueType(l,2,out a1);
			self.Init(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			setBack(l,(object)self);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_DiscLight(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.DiscLight a1;
			checkValueType(l,2,out a1);
			self.Init(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			setBack(l,(object)self);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_SpotLightBoxShape(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.SpotLightBoxShape a1;
			checkValueType(l,2,out a1);
			self.Init(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			setBack(l,(object)self);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_SpotLightPyramidShape(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.SpotLightPyramidShape a1;
			checkValueType(l,2,out a1);
			self.Init(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			setBack(l,(object)self);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_DirectionalLight__R_Cookie(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.DirectionalLight a1;
			checkValueType(l,2,out a1);
			UnityEngine.Experimental.GlobalIllumination.Cookie a2;
			checkValueType(l,3,out a2);
			self.Init(ref a1,ref a2);
			pushValue(l,true);
			pushValue(l,a1);
			pushValue(l,a2);
			setBack(l,(object)self);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_PointLight__R_Cookie(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.PointLight a1;
			checkValueType(l,2,out a1);
			UnityEngine.Experimental.GlobalIllumination.Cookie a2;
			checkValueType(l,3,out a2);
			self.Init(ref a1,ref a2);
			pushValue(l,true);
			pushValue(l,a1);
			pushValue(l,a2);
			setBack(l,(object)self);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_SpotLight__R_Cookie(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.SpotLight a1;
			checkValueType(l,2,out a1);
			UnityEngine.Experimental.GlobalIllumination.Cookie a2;
			checkValueType(l,3,out a2);
			self.Init(ref a1,ref a2);
			pushValue(l,true);
			pushValue(l,a1);
			pushValue(l,a2);
			setBack(l,(object)self);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_RectangleLight__R_Cookie(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.RectangleLight a1;
			checkValueType(l,2,out a1);
			UnityEngine.Experimental.GlobalIllumination.Cookie a2;
			checkValueType(l,3,out a2);
			self.Init(ref a1,ref a2);
			pushValue(l,true);
			pushValue(l,a1);
			pushValue(l,a2);
			setBack(l,(object)self);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_DiscLight__R_Cookie(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.DiscLight a1;
			checkValueType(l,2,out a1);
			UnityEngine.Experimental.GlobalIllumination.Cookie a2;
			checkValueType(l,3,out a2);
			self.Init(ref a1,ref a2);
			pushValue(l,true);
			pushValue(l,a1);
			pushValue(l,a2);
			setBack(l,(object)self);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_SpotLightBoxShape__R_Cookie(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.SpotLightBoxShape a1;
			checkValueType(l,2,out a1);
			UnityEngine.Experimental.GlobalIllumination.Cookie a2;
			checkValueType(l,3,out a2);
			self.Init(ref a1,ref a2);
			pushValue(l,true);
			pushValue(l,a1);
			pushValue(l,a2);
			setBack(l,(object)self);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Init__R_SpotLightPyramidShape__R_Cookie(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.SpotLightPyramidShape a1;
			checkValueType(l,2,out a1);
			UnityEngine.Experimental.GlobalIllumination.Cookie a2;
			checkValueType(l,3,out a2);
			self.Init(ref a1,ref a2);
			pushValue(l,true);
			pushValue(l,a1);
			pushValue(l,a2);
			setBack(l,(object)self);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int InitNoBake(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.InitNoBake(a1);
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
	static public int get_instanceID(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.instanceID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_instanceID(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.instanceID=v;
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
	static public int get_cookieID(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.cookieID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cookieID(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.cookieID=v;
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
	static public int get_cookieScale(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.cookieScale);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cookieScale(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.cookieScale=v;
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
	static public int get_color(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.color);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_color(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.LinearColor v;
			checkValueType(l,2,out v);
			self.color=v;
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
	static public int get_indirectColor(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.indirectColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_indirectColor(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.LinearColor v;
			checkValueType(l,2,out v);
			self.indirectColor=v;
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
	static public int get_orientation(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.orientation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_orientation(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Quaternion v;
			checkType(l,2,out v);
			self.orientation=v;
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
	static public int get_position(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_position(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.position=v;
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
	static public int get_range(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.range);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_range(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.range=v;
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
	static public int get_coneAngle(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.coneAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_coneAngle(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.coneAngle=v;
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
	static public int get_innerConeAngle(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.innerConeAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_innerConeAngle(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.innerConeAngle=v;
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
	static public int get_shape0(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.shape0);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shape0(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.shape0=v;
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
	static public int get_shape1(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.shape1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shape1(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			System.Single v;
			checkType(l,2,out v);
			self.shape1=v;
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
	static public int get_type(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_type(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.LightType v;
			checkEnum(l,2,out v);
			self.type=v;
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
	static public int get_mode(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_mode(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.LightMode v;
			checkEnum(l,2,out v);
			self.mode=v;
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
	static public int get_shadow(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.shadow);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_shadow(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			System.Byte v;
			checkType(l,2,out v);
			self.shadow=v;
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
	static public int get_falloff(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.falloff);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_falloff(IntPtr l) {
		try {
			UnityEngine.Experimental.GlobalIllumination.LightDataGI self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.GlobalIllumination.FalloffType v;
			checkEnum(l,2,out v);
			self.falloff=v;
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
		getTypeTable(l,"UnityEngine.Experimental.GlobalIllumination.LightDataGI");
		addMember(l,ctor_s);
		addMember(l,Init__R_DirectionalLight);
		addMember(l,Init__R_PointLight);
		addMember(l,Init__R_SpotLight);
		addMember(l,Init__R_RectangleLight);
		addMember(l,Init__R_DiscLight);
		addMember(l,Init__R_SpotLightBoxShape);
		addMember(l,Init__R_SpotLightPyramidShape);
		addMember(l,Init__R_DirectionalLight__R_Cookie);
		addMember(l,Init__R_PointLight__R_Cookie);
		addMember(l,Init__R_SpotLight__R_Cookie);
		addMember(l,Init__R_RectangleLight__R_Cookie);
		addMember(l,Init__R_DiscLight__R_Cookie);
		addMember(l,Init__R_SpotLightBoxShape__R_Cookie);
		addMember(l,Init__R_SpotLightPyramidShape__R_Cookie);
		addMember(l,InitNoBake);
		addMember(l,"instanceID",get_instanceID,set_instanceID,true);
		addMember(l,"cookieID",get_cookieID,set_cookieID,true);
		addMember(l,"cookieScale",get_cookieScale,set_cookieScale,true);
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"indirectColor",get_indirectColor,set_indirectColor,true);
		addMember(l,"orientation",get_orientation,set_orientation,true);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"range",get_range,set_range,true);
		addMember(l,"coneAngle",get_coneAngle,set_coneAngle,true);
		addMember(l,"innerConeAngle",get_innerConeAngle,set_innerConeAngle,true);
		addMember(l,"shape0",get_shape0,set_shape0,true);
		addMember(l,"shape1",get_shape1,set_shape1,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"shadow",get_shadow,set_shadow,true);
		addMember(l,"falloff",get_falloff,set_falloff,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Experimental.GlobalIllumination.LightDataGI),typeof(System.ValueType));
	}
}
