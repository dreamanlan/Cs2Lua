using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_MeshRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_additionalVertexStreams(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.additionalVertexStreams);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_additionalVertexStreams(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			UnityEngine.Mesh v;
			checkType(l,2,out v);
			self.additionalVertexStreams=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_enlightenVertexStream(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.enlightenVertexStream);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_enlightenVertexStream(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			UnityEngine.Mesh v;
			checkType(l,2,out v);
			self.enlightenVertexStream=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_subMeshStartIndex(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.subMeshStartIndex);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_scaleInLightmap(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.scaleInLightmap);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_scaleInLightmap(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.scaleInLightmap=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_receiveGI(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.receiveGI);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_receiveGI(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			UnityEngine.ReceiveGI v;
			checkEnum(l,2,out v);
			self.receiveGI=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_stitchLightmapSeams(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.stitchLightmapSeams);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_stitchLightmapSeams(IntPtr l) {
		try {
			UnityEngine.MeshRenderer self=(UnityEngine.MeshRenderer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.stitchLightmapSeams=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MeshRenderer");
		addMember(l,"additionalVertexStreams",get_additionalVertexStreams,set_additionalVertexStreams,true);
		addMember(l,"enlightenVertexStream",get_enlightenVertexStream,set_enlightenVertexStream,true);
		addMember(l,"subMeshStartIndex",get_subMeshStartIndex,null,true);
		addMember(l,"scaleInLightmap",get_scaleInLightmap,set_scaleInLightmap,true);
		addMember(l,"receiveGI",get_receiveGI,set_receiveGI,true);
		addMember(l,"stitchLightmapSeams",get_stitchLightmapSeams,set_stitchLightmapSeams,true);
		createTypeMetatable(l,null, typeof(UnityEngine.MeshRenderer),typeof(UnityEngine.Renderer));
	}
}
