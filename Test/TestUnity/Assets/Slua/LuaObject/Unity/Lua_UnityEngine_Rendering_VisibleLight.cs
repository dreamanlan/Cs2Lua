using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_VisibleLight : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight o;
			o=new UnityEngine.Rendering.VisibleLight();
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
	static public int Equals__VisibleLight(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.VisibleLight a1;
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
			UnityEngine.Rendering.VisibleLight self;
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
			UnityEngine.Rendering.VisibleLight a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.VisibleLight a2;
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
			UnityEngine.Rendering.VisibleLight a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.VisibleLight a2;
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
	static public int get_light(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.light);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_lightType(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.lightType);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_lightType(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			UnityEngine.LightType v;
			checkEnum(l,2,out v);
			self.lightType=v;
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
	static public int get_finalColor(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.finalColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_finalColor(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.finalColor=v;
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
	static public int get_screenRect(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.screenRect);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_screenRect(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			UnityEngine.Rect v;
			checkValueType(l,2,out v);
			self.screenRect=v;
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
	static public int get_localToWorldMatrix(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.localToWorldMatrix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_localToWorldMatrix(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			UnityEngine.Matrix4x4 v;
			checkValueType(l,2,out v);
			self.localToWorldMatrix=v;
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
			UnityEngine.Rendering.VisibleLight self;
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
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			float v;
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
	static public int get_spotAngle(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.spotAngle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_spotAngle(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.spotAngle=v;
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
	static public int get_intersectsNearPlane(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.intersectsNearPlane);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_intersectsNearPlane(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.intersectsNearPlane=v;
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
	static public int get_intersectsFarPlane(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.intersectsFarPlane);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_intersectsFarPlane(IntPtr l) {
		try {
			UnityEngine.Rendering.VisibleLight self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.intersectsFarPlane=v;
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
		getTypeTable(l,"UnityEngine.Rendering.VisibleLight");
		addMember(l,ctor_s);
		addMember(l,Equals__VisibleLight);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"light",get_light,null,true);
		addMember(l,"lightType",get_lightType,set_lightType,true);
		addMember(l,"finalColor",get_finalColor,set_finalColor,true);
		addMember(l,"screenRect",get_screenRect,set_screenRect,true);
		addMember(l,"localToWorldMatrix",get_localToWorldMatrix,set_localToWorldMatrix,true);
		addMember(l,"range",get_range,set_range,true);
		addMember(l,"spotAngle",get_spotAngle,set_spotAngle,true);
		addMember(l,"intersectsNearPlane",get_intersectsNearPlane,set_intersectsNearPlane,true);
		addMember(l,"intersectsFarPlane",get_intersectsFarPlane,set_intersectsFarPlane,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.VisibleLight),typeof(System.ValueType));
	}
}
