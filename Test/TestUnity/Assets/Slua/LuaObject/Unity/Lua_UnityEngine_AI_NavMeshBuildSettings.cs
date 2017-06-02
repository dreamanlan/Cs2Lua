using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_AI_NavMeshBuildSettings : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings o;
			o=new UnityEngine.AI.NavMeshBuildSettings();
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
	static public int ValidationReport(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			UnityEngine.Bounds a1;
			checkValueType(l,2,out a1);
			var ret=self.ValidationReport(a1);
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
	static public int get_agentTypeID(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.agentTypeID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_agentTypeID(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.agentTypeID=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_agentRadius(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.agentRadius);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_agentRadius(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.agentRadius=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_agentHeight(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.agentHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_agentHeight(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.agentHeight=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_agentSlope(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.agentSlope);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_agentSlope(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.agentSlope=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_agentClimb(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.agentClimb);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_agentClimb(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.agentClimb=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overrideVoxelSize(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.overrideVoxelSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overrideVoxelSize(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.overrideVoxelSize=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_voxelSize(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.voxelSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_voxelSize(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.voxelSize=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_overrideTileSize(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.overrideTileSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_overrideTileSize(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.overrideTileSize=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_tileSize(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.tileSize);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_tileSize(IntPtr l) {
		try {
			UnityEngine.AI.NavMeshBuildSettings self;
			checkValueType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.tileSize=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AI.NavMeshBuildSettings");
		addMember(l,ValidationReport);
		addMember(l,"agentTypeID",get_agentTypeID,set_agentTypeID,true);
		addMember(l,"agentRadius",get_agentRadius,set_agentRadius,true);
		addMember(l,"agentHeight",get_agentHeight,set_agentHeight,true);
		addMember(l,"agentSlope",get_agentSlope,set_agentSlope,true);
		addMember(l,"agentClimb",get_agentClimb,set_agentClimb,true);
		addMember(l,"overrideVoxelSize",get_overrideVoxelSize,set_overrideVoxelSize,true);
		addMember(l,"voxelSize",get_voxelSize,set_voxelSize,true);
		addMember(l,"overrideTileSize",get_overrideTileSize,set_overrideTileSize,true);
		addMember(l,"tileSize",get_tileSize,set_tileSize,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AI.NavMeshBuildSettings),typeof(System.ValueType));
	}
}
