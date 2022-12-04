using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_AttachmentDescriptor : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor o;
			o=new UnityEngine.Rendering.AttachmentDescriptor();
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
	static public int ctor__GraphicsFormat_s(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor o;
			UnityEngine.Experimental.Rendering.GraphicsFormat a1;
			checkEnum(l,1,out a1);
			o=new UnityEngine.Rendering.AttachmentDescriptor(a1);
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
	static public int ctor__RenderTextureFormat_s(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor o;
			UnityEngine.RenderTextureFormat a1;
			checkEnum(l,1,out a1);
			o=new UnityEngine.Rendering.AttachmentDescriptor(a1);
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
	static public int ctor__RenderTextureFormat__RenderTargetIdentifier__Boolean__Boolean__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor o;
			UnityEngine.RenderTextureFormat a1;
			checkEnum(l,1,out a1);
			UnityEngine.Rendering.RenderTargetIdentifier a2;
			checkValueType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			System.Boolean a4;
			checkType(l,4,out a4);
			System.Boolean a5;
			checkType(l,5,out a5);
			o=new UnityEngine.Rendering.AttachmentDescriptor(a1,a2,a3,a4,a5);
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
	static public int ConfigureTarget(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			System.Boolean a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			self.ConfigureTarget(a1,a2,a3);
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
	static public int ConfigureResolveTarget(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderTargetIdentifier a1;
			checkValueType(l,2,out a1);
			self.ConfigureResolveTarget(a1);
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
	static public int ConfigureClear(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			System.UInt32 a3;
			checkType(l,4,out a3);
			self.ConfigureClear(a1,a2,a3);
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
	static public int Equals__AttachmentDescriptor(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.AttachmentDescriptor a1;
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
			UnityEngine.Rendering.AttachmentDescriptor self;
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
			UnityEngine.Rendering.AttachmentDescriptor a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.AttachmentDescriptor a2;
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
			UnityEngine.Rendering.AttachmentDescriptor a1;
			checkValueType(l,1,out a1);
			UnityEngine.Rendering.AttachmentDescriptor a2;
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
	static public int get_loadAction(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.loadAction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_loadAction(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferLoadAction v;
			checkEnum(l,2,out v);
			self.loadAction=v;
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
	static public int get_storeAction(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.storeAction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_storeAction(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferStoreAction v;
			checkEnum(l,2,out v);
			self.storeAction=v;
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
	static public int get_graphicsFormat(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.graphicsFormat);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_graphicsFormat(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.Experimental.Rendering.GraphicsFormat v;
			checkEnum(l,2,out v);
			self.graphicsFormat=v;
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
	static public int get_format(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.format);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_format(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.RenderTextureFormat v;
			checkEnum(l,2,out v);
			self.format=v;
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
	static public int get_loadStoreTarget(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.loadStoreTarget);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_loadStoreTarget(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderTargetIdentifier v;
			checkValueType(l,2,out v);
			self.loadStoreTarget=v;
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
	static public int get_resolveTarget(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.resolveTarget);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_resolveTarget(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderTargetIdentifier v;
			checkValueType(l,2,out v);
			self.resolveTarget=v;
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
	static public int get_clearColor(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.clearColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_clearColor(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.clearColor=v;
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
	static public int get_clearDepth(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.clearDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_clearDepth(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.clearDepth=v;
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
	static public int get_clearStencil(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.clearStencil);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_clearStencil(IntPtr l) {
		try {
			UnityEngine.Rendering.AttachmentDescriptor self;
			checkValueType(l,1,out self);
			System.UInt32 v;
			checkType(l,2,out v);
			self.clearStencil=v;
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
		getTypeTable(l,"UnityEngine.Rendering.AttachmentDescriptor");
		addMember(l,ctor_s);
		addMember(l,ctor__GraphicsFormat_s);
		addMember(l,ctor__RenderTextureFormat_s);
		addMember(l,ctor__RenderTextureFormat__RenderTargetIdentifier__Boolean__Boolean__Boolean_s);
		addMember(l,ConfigureTarget);
		addMember(l,ConfigureResolveTarget);
		addMember(l,ConfigureClear);
		addMember(l,Equals__AttachmentDescriptor);
		addMember(l,Equals__Object);
		addMember(l,op_Equality_s);
		addMember(l,op_Inequality_s);
		addMember(l,"loadAction",get_loadAction,set_loadAction,true);
		addMember(l,"storeAction",get_storeAction,set_storeAction,true);
		addMember(l,"graphicsFormat",get_graphicsFormat,set_graphicsFormat,true);
		addMember(l,"format",get_format,set_format,true);
		addMember(l,"loadStoreTarget",get_loadStoreTarget,set_loadStoreTarget,true);
		addMember(l,"resolveTarget",get_resolveTarget,set_resolveTarget,true);
		addMember(l,"clearColor",get_clearColor,set_clearColor,true);
		addMember(l,"clearDepth",get_clearDepth,set_clearDepth,true);
		addMember(l,"clearStencil",get_clearStencil,set_clearStencil,true);
		createTypeMetatable(l,null, typeof(UnityEngine.Rendering.AttachmentDescriptor),typeof(System.ValueType));
	}
}
