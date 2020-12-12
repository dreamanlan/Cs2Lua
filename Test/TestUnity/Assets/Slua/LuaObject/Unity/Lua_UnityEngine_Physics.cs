using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Physics : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			UnityEngine.Physics o;
			o=new UnityEngine.Physics();
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
	static public int IgnoreCollision__Collider__Collider_s(IntPtr l) {
		try {
			UnityEngine.Collider a1;
			checkType(l,1,out a1);
			UnityEngine.Collider a2;
			checkType(l,2,out a2);
			UnityEngine.Physics.IgnoreCollision(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IgnoreCollision__Collider__Collider__Boolean_s(IntPtr l) {
		try {
			UnityEngine.Collider a1;
			checkType(l,1,out a1);
			UnityEngine.Collider a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			UnityEngine.Physics.IgnoreCollision(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IgnoreLayerCollision__Int32__Int32_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Physics.IgnoreLayerCollision(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int IgnoreLayerCollision__Int32__Int32__Boolean_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			System.Boolean a3;
			checkType(l,3,out a3);
			UnityEngine.Physics.IgnoreLayerCollision(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetIgnoreLayerCollision_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.GetIgnoreLayerCollision(a1,a2);
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
	static public int Raycast__Ray_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.Physics.Raycast(a1);
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
	static public int Raycast__Vector3__Vector3_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.Raycast(a1,a2);
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
	static public int Raycast__Ray__O_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			UnityEngine.RaycastHit a2;
			var ret=UnityEngine.Physics.Raycast(a1,out a2);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Raycast__Ray__Single_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.Raycast(a1,a2);
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
	static public int Raycast__Vector3__Vector3__O_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit a3;
			var ret=UnityEngine.Physics.Raycast(a1,a2,out a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Raycast__Vector3__Vector3__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.Raycast(a1,a2,a3);
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
	static public int Raycast__Ray__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.Raycast(a1,a2,a3);
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
	static public int Raycast__Ray__O_RaycastHit__Single_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			UnityEngine.RaycastHit a2;
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.Raycast(a1,out a2,a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Raycast__Vector3__Vector3__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.Raycast(a1,a2,a3,a4);
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
	static public int Raycast__Vector3__Vector3__O_RaycastHit__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit a3;
			System.Single a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.Raycast(a1,a2,out a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Raycast__Ray__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.QueryTriggerInteraction a4;
			checkEnum(l,4,out a4);
			var ret=UnityEngine.Physics.Raycast(a1,a2,a3,a4);
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
	static public int Raycast__Ray__O_RaycastHit__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			UnityEngine.RaycastHit a2;
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.Raycast(a1,out a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Raycast__Vector3__Vector3__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.QueryTriggerInteraction a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.Physics.Raycast(a1,a2,a3,a4,a5);
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
	static public int Raycast__Vector3__Vector3__O_RaycastHit__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit a3;
			System.Single a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.Raycast(a1,a2,out a3,a4,a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Raycast__Ray__O_RaycastHit__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			UnityEngine.RaycastHit a2;
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.QueryTriggerInteraction a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.Physics.Raycast(a1,out a2,a3,a4,a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a2);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Raycast__Vector3__Vector3__O_RaycastHit__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit a3;
			System.Single a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.QueryTriggerInteraction a6;
			checkEnum(l,6,out a6);
			var ret=UnityEngine.Physics.Raycast(a1,a2,out a3,a4,a5,a6);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Linecast__Vector3__Vector3_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.Linecast(a1,a2);
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
	static public int Linecast__Vector3__Vector3__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.Linecast(a1,a2,a3);
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
	static public int Linecast__Vector3__Vector3__O_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit a3;
			var ret=UnityEngine.Physics.Linecast(a1,a2,out a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Linecast__Vector3__Vector3__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.QueryTriggerInteraction a4;
			checkEnum(l,4,out a4);
			var ret=UnityEngine.Physics.Linecast(a1,a2,a3,a4);
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
	static public int Linecast__Vector3__Vector3__O_RaycastHit__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit a3;
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.Linecast(a1,a2,out a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Linecast__Vector3__Vector3__O_RaycastHit__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit a3;
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.QueryTriggerInteraction a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.Physics.Linecast(a1,a2,out a3,a4,a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CapsuleCast__Vector3__Vector3__Single__Vector3_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4);
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
	static public int CapsuleCast__Vector3__Vector3__Single__Vector3__O_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			UnityEngine.RaycastHit a5;
			var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a5);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CapsuleCast__Vector3__Vector3__Single__Vector3__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,a5);
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
	static public int CapsuleCast__Vector3__Vector3__Single__Vector3__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,a5,a6);
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
	static public int CapsuleCast__Vector3__Vector3__Single__Vector3__O_RaycastHit__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			UnityEngine.RaycastHit a5;
			System.Single a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5,a6);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a5);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CapsuleCast__Vector3__Vector3__Single__Vector3__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.QueryTriggerInteraction a7;
			checkEnum(l,7,out a7);
			var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,a5,a6,a7);
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
	static public int CapsuleCast__Vector3__Vector3__Single__Vector3__O_RaycastHit__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			UnityEngine.RaycastHit a5;
			System.Single a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5,a6,a7);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a5);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CapsuleCast__Vector3__Vector3__Single__Vector3__O_RaycastHit__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			UnityEngine.RaycastHit a5;
			System.Single a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.QueryTriggerInteraction a8;
			checkEnum(l,8,out a8);
			var ret=UnityEngine.Physics.CapsuleCast(a1,a2,a3,a4,out a5,a6,a7,a8);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a5);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SphereCast__Ray__Single_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.SphereCast(a1,a2);
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
	static public int SphereCast__Ray__Single__O_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit a3;
			var ret=UnityEngine.Physics.SphereCast(a1,a2,out a3);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SphereCast__Ray__Single__Single_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.SphereCast(a1,a2,a3);
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
	static public int SphereCast__Vector3__Single__Vector3__O_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit a4;
			var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SphereCast__Ray__Single__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,a4);
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
	static public int SphereCast__Ray__Single__O_RaycastHit__Single_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit a3;
			System.Single a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.SphereCast(a1,a2,out a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SphereCast__Vector3__Single__Vector3__O_RaycastHit__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit a4;
			System.Single a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4,a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SphereCast__Ray__Single__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.QueryTriggerInteraction a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,a4,a5);
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
	static public int SphereCast__Ray__Single__O_RaycastHit__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit a3;
			System.Single a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.SphereCast(a1,a2,out a3,a4,a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SphereCast__Vector3__Single__Vector3__O_RaycastHit__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit a4;
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4,a5,a6);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SphereCast__Ray__Single__O_RaycastHit__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit a3;
			System.Single a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.QueryTriggerInteraction a6;
			checkEnum(l,6,out a6);
			var ret=UnityEngine.Physics.SphereCast(a1,a2,out a3,a4,a5,a6);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a3);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SphereCast__Vector3__Single__Vector3__O_RaycastHit__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit a4;
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.QueryTriggerInteraction a7;
			checkEnum(l,7,out a7);
			var ret=UnityEngine.Physics.SphereCast(a1,a2,a3,out a4,a5,a6,a7);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BoxCast__Vector3__Vector3__Vector3_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.BoxCast(a1,a2,a3);
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
	static public int BoxCast__Vector3__Vector3__Vector3__Quaternion_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,a4);
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
	static public int BoxCast__Vector3__Vector3__Vector3__O_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit a4;
			var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,out a4);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BoxCast__Vector3__Vector3__Vector3__O_RaycastHit__Quaternion_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit a4;
			UnityEngine.Quaternion a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,out a4,a5);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BoxCast__Vector3__Vector3__Vector3__Quaternion__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,a4,a5);
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
	static public int BoxCast__Vector3__Vector3__Vector3__Quaternion__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,a4,a5,a6);
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
	static public int BoxCast__Vector3__Vector3__Vector3__O_RaycastHit__Quaternion__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit a4;
			UnityEngine.Quaternion a5;
			checkType(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,out a4,a5,a6);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BoxCast__Vector3__Vector3__Vector3__Quaternion__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.QueryTriggerInteraction a7;
			checkEnum(l,7,out a7);
			var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,a4,a5,a6,a7);
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
	static public int BoxCast__Vector3__Vector3__Vector3__O_RaycastHit__Quaternion__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit a4;
			UnityEngine.Quaternion a5;
			checkType(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,out a4,a5,a6,a7);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int BoxCast__Vector3__Vector3__Vector3__O_RaycastHit__Quaternion__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit a4;
			UnityEngine.Quaternion a5;
			checkType(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.QueryTriggerInteraction a8;
			checkEnum(l,8,out a8);
			var ret=UnityEngine.Physics.BoxCast(a1,a2,a3,out a4,a5,a6,a7,a8);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a4);
			return 3;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int RaycastAll__Ray_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			var ret=UnityEngine.Physics.RaycastAll(a1);
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
	static public int RaycastAll__Vector3__Vector3_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.RaycastAll(a1,a2);
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
	static public int RaycastAll__Ray__Single_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.RaycastAll(a1,a2);
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
	static public int RaycastAll__Vector3__Vector3__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3);
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
	static public int RaycastAll__Ray__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3);
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
	static public int RaycastAll__Vector3__Vector3__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3,a4);
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
	static public int RaycastAll__Ray__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.QueryTriggerInteraction a4;
			checkEnum(l,4,out a4);
			var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3,a4);
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
	static public int RaycastAll__Vector3__Vector3__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.QueryTriggerInteraction a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.Physics.RaycastAll(a1,a2,a3,a4,a5);
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
	static public int RaycastNonAlloc__Ray__A_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			UnityEngine.RaycastHit[] a2;
			checkArray(l,2,out a2);
			var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2);
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
	static public int RaycastNonAlloc__Vector3__Vector3__A_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit[] a3;
			checkArray(l,3,out a3);
			var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3);
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
	static public int RaycastNonAlloc__Ray__A_RaycastHit__Single_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			UnityEngine.RaycastHit[] a2;
			checkArray(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3);
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
	static public int RaycastNonAlloc__Ray__A_RaycastHit__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			UnityEngine.RaycastHit[] a2;
			checkArray(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3,a4);
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
	static public int RaycastNonAlloc__Vector3__Vector3__A_RaycastHit__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit[] a3;
			checkArray(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3,a4);
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
	static public int RaycastNonAlloc__Ray__A_RaycastHit__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			UnityEngine.RaycastHit[] a2;
			checkArray(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.QueryTriggerInteraction a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3,a4,a5);
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
	static public int RaycastNonAlloc__Vector3__Vector3__A_RaycastHit__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit[] a3;
			checkArray(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3,a4,a5);
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
	static public int RaycastNonAlloc__Vector3__Vector3__A_RaycastHit__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit[] a3;
			checkArray(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.QueryTriggerInteraction a6;
			checkEnum(l,6,out a6);
			var ret=UnityEngine.Physics.RaycastNonAlloc(a1,a2,a3,a4,a5,a6);
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
	static public int CapsuleCastAll__Vector3__Vector3__Single__Vector3_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4);
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
	static public int CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4,a5);
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
	static public int CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4,a5,a6);
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
	static public int CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.QueryTriggerInteraction a7;
			checkEnum(l,7,out a7);
			var ret=UnityEngine.Physics.CapsuleCastAll(a1,a2,a3,a4,a5,a6,a7);
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
	static public int SphereCastAll__Ray__Single_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.SphereCastAll(a1,a2);
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
	static public int SphereCastAll__Vector3__Single__Vector3_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3);
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
	static public int SphereCastAll__Ray__Single__Single_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3);
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
	static public int SphereCastAll__Vector3__Single__Vector3__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4);
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
	static public int SphereCastAll__Ray__Single__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4);
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
	static public int SphereCastAll__Vector3__Single__Vector3__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4,a5);
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
	static public int SphereCastAll__Ray__Single__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.QueryTriggerInteraction a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4,a5);
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
	static public int SphereCastAll__Vector3__Single__Vector3__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.QueryTriggerInteraction a6;
			checkEnum(l,6,out a6);
			var ret=UnityEngine.Physics.SphereCastAll(a1,a2,a3,a4,a5,a6);
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
	static public int OverlapCapsule__Vector3__Vector3__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.OverlapCapsule(a1,a2,a3);
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
	static public int OverlapCapsule__Vector3__Vector3__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.OverlapCapsule(a1,a2,a3,a4);
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
	static public int OverlapCapsule__Vector3__Vector3__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.QueryTriggerInteraction a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.Physics.OverlapCapsule(a1,a2,a3,a4,a5);
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
	static public int OverlapSphere__Vector3__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.OverlapSphere(a1,a2);
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
	static public int OverlapSphere__Vector3__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.OverlapSphere(a1,a2,a3);
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
	static public int OverlapSphere__Vector3__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.QueryTriggerInteraction a4;
			checkEnum(l,4,out a4);
			var ret=UnityEngine.Physics.OverlapSphere(a1,a2,a3,a4);
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
	static public int Simulate_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			UnityEngine.Physics.Simulate(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SyncTransforms_s(IntPtr l) {
		try {
			UnityEngine.Physics.SyncTransforms();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ComputePenetration_s(IntPtr l) {
		try {
			UnityEngine.Collider a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			UnityEngine.Collider a4;
			checkType(l,4,out a4);
			UnityEngine.Vector3 a5;
			checkType(l,5,out a5);
			UnityEngine.Quaternion a6;
			checkType(l,6,out a6);
			UnityEngine.Vector3 a7;
			System.Single a8;
			var ret=UnityEngine.Physics.ComputePenetration(a1,a2,a3,a4,a5,a6,out a7,out a8);
			pushValue(l,true);
			pushValue(l,ret);
			pushValue(l,a7);
			pushValue(l,a8);
			return 4;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ClosestPoint_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Collider a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.ClosestPoint(a1,a2,a3,a4);
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
	static public int OverlapSphereNonAlloc__Vector3__Single__A_Collider_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Collider[] a3;
			checkArray(l,3,out a3);
			var ret=UnityEngine.Physics.OverlapSphereNonAlloc(a1,a2,a3);
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
	static public int OverlapSphereNonAlloc__Vector3__Single__A_Collider__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Collider[] a3;
			checkArray(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.OverlapSphereNonAlloc(a1,a2,a3,a4);
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
	static public int OverlapSphereNonAlloc__Vector3__Single__A_Collider__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Collider[] a3;
			checkArray(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.QueryTriggerInteraction a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.Physics.OverlapSphereNonAlloc(a1,a2,a3,a4,a5);
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
	static public int CheckSphere__Vector3__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.CheckSphere(a1,a2);
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
	static public int CheckSphere__Vector3__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.CheckSphere(a1,a2,a3);
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
	static public int CheckSphere__Vector3__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Int32 a3;
			checkType(l,3,out a3);
			UnityEngine.QueryTriggerInteraction a4;
			checkEnum(l,4,out a4);
			var ret=UnityEngine.Physics.CheckSphere(a1,a2,a3,a4);
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
	static public int CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__A_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			UnityEngine.RaycastHit[] a5;
			checkArray(l,5,out a5);
			var ret=UnityEngine.Physics.CapsuleCastNonAlloc(a1,a2,a3,a4,a5);
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
	static public int CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__A_RaycastHit__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			UnityEngine.RaycastHit[] a5;
			checkArray(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.Physics.CapsuleCastNonAlloc(a1,a2,a3,a4,a5,a6);
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
	static public int CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__A_RaycastHit__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			UnityEngine.RaycastHit[] a5;
			checkArray(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			var ret=UnityEngine.Physics.CapsuleCastNonAlloc(a1,a2,a3,a4,a5,a6,a7);
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
	static public int CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__A_RaycastHit__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Vector3 a4;
			checkType(l,4,out a4);
			UnityEngine.RaycastHit[] a5;
			checkArray(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.QueryTriggerInteraction a8;
			checkEnum(l,8,out a8);
			var ret=UnityEngine.Physics.CapsuleCastNonAlloc(a1,a2,a3,a4,a5,a6,a7,a8);
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
	static public int SphereCastNonAlloc__Ray__Single__A_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit[] a3;
			checkArray(l,3,out a3);
			var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3);
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
	static public int SphereCastNonAlloc__Vector3__Single__Vector3__A_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit[] a4;
			checkArray(l,4,out a4);
			var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4);
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
	static public int SphereCastNonAlloc__Ray__Single__A_RaycastHit__Single_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit[] a3;
			checkArray(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4);
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
	static public int SphereCastNonAlloc__Vector3__Single__Vector3__A_RaycastHit__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit[] a4;
			checkArray(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4,a5);
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
	static public int SphereCastNonAlloc__Ray__Single__A_RaycastHit__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit[] a3;
			checkArray(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4,a5);
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
	static public int SphereCastNonAlloc__Vector3__Single__Vector3__A_RaycastHit__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit[] a4;
			checkArray(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4,a5,a6);
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
	static public int SphereCastNonAlloc__Ray__Single__A_RaycastHit__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Ray a1;
			checkValueType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.RaycastHit[] a3;
			checkArray(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.QueryTriggerInteraction a6;
			checkEnum(l,6,out a6);
			var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4,a5,a6);
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
	static public int SphereCastNonAlloc__Vector3__Single__Vector3__A_RaycastHit__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit[] a4;
			checkArray(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.QueryTriggerInteraction a7;
			checkEnum(l,7,out a7);
			var ret=UnityEngine.Physics.SphereCastNonAlloc(a1,a2,a3,a4,a5,a6,a7);
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
	static public int CheckCapsule__Vector3__Vector3__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.CheckCapsule(a1,a2,a3);
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
	static public int CheckCapsule__Vector3__Vector3__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.CheckCapsule(a1,a2,a3,a4);
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
	static public int CheckCapsule__Vector3__Vector3__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.QueryTriggerInteraction a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.Physics.CheckCapsule(a1,a2,a3,a4,a5);
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
	static public int CheckBox__Vector3__Vector3_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.CheckBox(a1,a2);
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
	static public int CheckBox__Vector3__Vector3__Quaternion_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.CheckBox(a1,a2,a3);
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
	static public int CheckBox__Vector3__Vector3__Quaternion__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.CheckBox(a1,a2,a3,a4);
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
	static public int CheckBox__Vector3__Vector3__Quaternion__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.QueryTriggerInteraction a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.Physics.CheckBox(a1,a2,a3,a4,a5);
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
	static public int OverlapBox__Vector3__Vector3_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.Physics.OverlapBox(a1,a2);
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
	static public int OverlapBox__Vector3__Vector3__Quaternion_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.OverlapBox(a1,a2,a3);
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
	static public int OverlapBox__Vector3__Vector3__Quaternion__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.OverlapBox(a1,a2,a3,a4);
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
	static public int OverlapBox__Vector3__Vector3__Quaternion__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Quaternion a3;
			checkType(l,3,out a3);
			System.Int32 a4;
			checkType(l,4,out a4);
			UnityEngine.QueryTriggerInteraction a5;
			checkEnum(l,5,out a5);
			var ret=UnityEngine.Physics.OverlapBox(a1,a2,a3,a4,a5);
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
	static public int OverlapBoxNonAlloc__Vector3__Vector3__A_Collider_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Collider[] a3;
			checkArray(l,3,out a3);
			var ret=UnityEngine.Physics.OverlapBoxNonAlloc(a1,a2,a3);
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
	static public int OverlapBoxNonAlloc__Vector3__Vector3__A_Collider__Quaternion_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Collider[] a3;
			checkArray(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.OverlapBoxNonAlloc(a1,a2,a3,a4);
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
	static public int OverlapBoxNonAlloc__Vector3__Vector3__A_Collider__Quaternion__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Collider[] a3;
			checkArray(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.OverlapBoxNonAlloc(a1,a2,a3,a4,a5);
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
	static public int OverlapBoxNonAlloc__Vector3__Vector3__A_Collider__Quaternion__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Collider[] a3;
			checkArray(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.QueryTriggerInteraction a6;
			checkEnum(l,6,out a6);
			var ret=UnityEngine.Physics.OverlapBoxNonAlloc(a1,a2,a3,a4,a5,a6);
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
	static public int BoxCastNonAlloc__Vector3__Vector3__Vector3__A_RaycastHit_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit[] a4;
			checkArray(l,4,out a4);
			var ret=UnityEngine.Physics.BoxCastNonAlloc(a1,a2,a3,a4);
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
	static public int BoxCastNonAlloc__Vector3__Vector3__Vector3__A_RaycastHit__Quaternion_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit[] a4;
			checkArray(l,4,out a4);
			UnityEngine.Quaternion a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.BoxCastNonAlloc(a1,a2,a3,a4,a5);
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
	static public int BoxCastNonAlloc__Vector3__Vector3__Vector3__A_RaycastHit__Quaternion__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit[] a4;
			checkArray(l,4,out a4);
			UnityEngine.Quaternion a5;
			checkType(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.Physics.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6);
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
	static public int BoxCastNonAlloc__Vector3__Vector3__Vector3__A_RaycastHit__Quaternion__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit[] a4;
			checkArray(l,4,out a4);
			UnityEngine.Quaternion a5;
			checkType(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			var ret=UnityEngine.Physics.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6,a7);
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
	static public int BoxCastNonAlloc__Vector3__Vector3__Vector3__A_RaycastHit__Quaternion__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.RaycastHit[] a4;
			checkArray(l,4,out a4);
			UnityEngine.Quaternion a5;
			checkType(l,5,out a5);
			System.Single a6;
			checkType(l,6,out a6);
			System.Int32 a7;
			checkType(l,7,out a7);
			UnityEngine.QueryTriggerInteraction a8;
			checkEnum(l,8,out a8);
			var ret=UnityEngine.Physics.BoxCastNonAlloc(a1,a2,a3,a4,a5,a6,a7,a8);
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
	static public int BoxCastAll__Vector3__Vector3__Vector3_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Physics.BoxCastAll(a1,a2,a3);
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
	static public int BoxCastAll__Vector3__Vector3__Vector3__Quaternion_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.Physics.BoxCastAll(a1,a2,a3,a4);
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
	static public int BoxCastAll__Vector3__Vector3__Vector3__Quaternion__Single_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.BoxCastAll(a1,a2,a3,a4,a5);
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
	static public int BoxCastAll__Vector3__Vector3__Vector3__Quaternion__Single__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			var ret=UnityEngine.Physics.BoxCastAll(a1,a2,a3,a4,a5,a6);
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
	static public int BoxCastAll__Vector3__Vector3__Vector3__Quaternion__Single__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			UnityEngine.Vector3 a3;
			checkType(l,3,out a3);
			UnityEngine.Quaternion a4;
			checkType(l,4,out a4);
			System.Single a5;
			checkType(l,5,out a5);
			System.Int32 a6;
			checkType(l,6,out a6);
			UnityEngine.QueryTriggerInteraction a7;
			checkEnum(l,7,out a7);
			var ret=UnityEngine.Physics.BoxCastAll(a1,a2,a3,a4,a5,a6,a7);
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
	static public int OverlapCapsuleNonAlloc__Vector3__Vector3__Single__A_Collider_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Collider[] a4;
			checkArray(l,4,out a4);
			var ret=UnityEngine.Physics.OverlapCapsuleNonAlloc(a1,a2,a3,a4);
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
	static public int OverlapCapsuleNonAlloc__Vector3__Vector3__Single__A_Collider__Int32_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Collider[] a4;
			checkArray(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			var ret=UnityEngine.Physics.OverlapCapsuleNonAlloc(a1,a2,a3,a4,a5);
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
	static public int OverlapCapsuleNonAlloc__Vector3__Vector3__Single__A_Collider__Int32__QueryTriggerInteraction_s(IntPtr l) {
		try {
			UnityEngine.Vector3 a1;
			checkType(l,1,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Collider[] a4;
			checkArray(l,4,out a4);
			System.Int32 a5;
			checkType(l,5,out a5);
			UnityEngine.QueryTriggerInteraction a6;
			checkEnum(l,6,out a6);
			var ret=UnityEngine.Physics.OverlapCapsuleNonAlloc(a1,a2,a3,a4,a5,a6);
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
	static public int RebuildBroadphaseRegions_s(IntPtr l) {
		try {
			UnityEngine.Bounds a1;
			checkValueType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			UnityEngine.Physics.RebuildBroadphaseRegions(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_IgnoreRaycastLayer(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.IgnoreRaycastLayer);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DefaultRaycastLayers(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.DefaultRaycastLayers);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_AllLayers(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.AllLayers);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_gravity(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.gravity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_gravity(IntPtr l) {
		try {
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			UnityEngine.Physics.gravity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultContactOffset(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.defaultContactOffset);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_defaultContactOffset(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.Physics.defaultContactOffset=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sleepThreshold(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.sleepThreshold);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sleepThreshold(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.Physics.sleepThreshold=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_queriesHitTriggers(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.queriesHitTriggers);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_queriesHitTriggers(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Physics.queriesHitTriggers=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_queriesHitBackfaces(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.queriesHitBackfaces);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_queriesHitBackfaces(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Physics.queriesHitBackfaces=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_bounceThreshold(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.bounceThreshold);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_bounceThreshold(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.Physics.bounceThreshold=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultSolverIterations(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.defaultSolverIterations);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_defaultSolverIterations(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.Physics.defaultSolverIterations=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultSolverVelocityIterations(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.defaultSolverVelocityIterations);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_defaultSolverVelocityIterations(IntPtr l) {
		try {
			int v;
			checkType(l,2,out v);
			UnityEngine.Physics.defaultSolverVelocityIterations=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_defaultPhysicsScene(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.defaultPhysicsScene);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autoSimulation(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.autoSimulation);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_autoSimulation(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Physics.autoSimulation=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_autoSyncTransforms(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.autoSyncTransforms);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_autoSyncTransforms(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Physics.autoSyncTransforms=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_reuseCollisionCallbacks(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.reuseCollisionCallbacks);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_reuseCollisionCallbacks(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Physics.reuseCollisionCallbacks=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_interCollisionDistance(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.interCollisionDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_interCollisionDistance(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.Physics.interCollisionDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_interCollisionStiffness(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.interCollisionStiffness);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_interCollisionStiffness(IntPtr l) {
		try {
			float v;
			checkType(l,2,out v);
			UnityEngine.Physics.interCollisionStiffness=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_interCollisionSettingsToggle(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.Physics.interCollisionSettingsToggle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_interCollisionSettingsToggle(IntPtr l) {
		try {
			bool v;
			checkType(l,2,out v);
			UnityEngine.Physics.interCollisionSettingsToggle=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Physics");
		addMember(l,ctor_s);
		addMember(l,IgnoreCollision__Collider__Collider_s);
		addMember(l,IgnoreCollision__Collider__Collider__Boolean_s);
		addMember(l,IgnoreLayerCollision__Int32__Int32_s);
		addMember(l,IgnoreLayerCollision__Int32__Int32__Boolean_s);
		addMember(l,GetIgnoreLayerCollision_s);
		addMember(l,Raycast__Ray_s);
		addMember(l,Raycast__Vector3__Vector3_s);
		addMember(l,Raycast__Ray__O_RaycastHit_s);
		addMember(l,Raycast__Ray__Single_s);
		addMember(l,Raycast__Vector3__Vector3__O_RaycastHit_s);
		addMember(l,Raycast__Vector3__Vector3__Single_s);
		addMember(l,Raycast__Ray__Single__Int32_s);
		addMember(l,Raycast__Ray__O_RaycastHit__Single_s);
		addMember(l,Raycast__Vector3__Vector3__Single__Int32_s);
		addMember(l,Raycast__Vector3__Vector3__O_RaycastHit__Single_s);
		addMember(l,Raycast__Ray__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,Raycast__Ray__O_RaycastHit__Single__Int32_s);
		addMember(l,Raycast__Vector3__Vector3__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,Raycast__Vector3__Vector3__O_RaycastHit__Single__Int32_s);
		addMember(l,Raycast__Ray__O_RaycastHit__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,Raycast__Vector3__Vector3__O_RaycastHit__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,Linecast__Vector3__Vector3_s);
		addMember(l,Linecast__Vector3__Vector3__Int32_s);
		addMember(l,Linecast__Vector3__Vector3__O_RaycastHit_s);
		addMember(l,Linecast__Vector3__Vector3__Int32__QueryTriggerInteraction_s);
		addMember(l,Linecast__Vector3__Vector3__O_RaycastHit__Int32_s);
		addMember(l,Linecast__Vector3__Vector3__O_RaycastHit__Int32__QueryTriggerInteraction_s);
		addMember(l,CapsuleCast__Vector3__Vector3__Single__Vector3_s);
		addMember(l,CapsuleCast__Vector3__Vector3__Single__Vector3__O_RaycastHit_s);
		addMember(l,CapsuleCast__Vector3__Vector3__Single__Vector3__Single_s);
		addMember(l,CapsuleCast__Vector3__Vector3__Single__Vector3__Single__Int32_s);
		addMember(l,CapsuleCast__Vector3__Vector3__Single__Vector3__O_RaycastHit__Single_s);
		addMember(l,CapsuleCast__Vector3__Vector3__Single__Vector3__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,CapsuleCast__Vector3__Vector3__Single__Vector3__O_RaycastHit__Single__Int32_s);
		addMember(l,CapsuleCast__Vector3__Vector3__Single__Vector3__O_RaycastHit__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,SphereCast__Ray__Single_s);
		addMember(l,SphereCast__Ray__Single__O_RaycastHit_s);
		addMember(l,SphereCast__Ray__Single__Single_s);
		addMember(l,SphereCast__Vector3__Single__Vector3__O_RaycastHit_s);
		addMember(l,SphereCast__Ray__Single__Single__Int32_s);
		addMember(l,SphereCast__Ray__Single__O_RaycastHit__Single_s);
		addMember(l,SphereCast__Vector3__Single__Vector3__O_RaycastHit__Single_s);
		addMember(l,SphereCast__Ray__Single__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,SphereCast__Ray__Single__O_RaycastHit__Single__Int32_s);
		addMember(l,SphereCast__Vector3__Single__Vector3__O_RaycastHit__Single__Int32_s);
		addMember(l,SphereCast__Ray__Single__O_RaycastHit__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,SphereCast__Vector3__Single__Vector3__O_RaycastHit__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,BoxCast__Vector3__Vector3__Vector3_s);
		addMember(l,BoxCast__Vector3__Vector3__Vector3__Quaternion_s);
		addMember(l,BoxCast__Vector3__Vector3__Vector3__O_RaycastHit_s);
		addMember(l,BoxCast__Vector3__Vector3__Vector3__O_RaycastHit__Quaternion_s);
		addMember(l,BoxCast__Vector3__Vector3__Vector3__Quaternion__Single_s);
		addMember(l,BoxCast__Vector3__Vector3__Vector3__Quaternion__Single__Int32_s);
		addMember(l,BoxCast__Vector3__Vector3__Vector3__O_RaycastHit__Quaternion__Single_s);
		addMember(l,BoxCast__Vector3__Vector3__Vector3__Quaternion__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,BoxCast__Vector3__Vector3__Vector3__O_RaycastHit__Quaternion__Single__Int32_s);
		addMember(l,BoxCast__Vector3__Vector3__Vector3__O_RaycastHit__Quaternion__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,RaycastAll__Ray_s);
		addMember(l,RaycastAll__Vector3__Vector3_s);
		addMember(l,RaycastAll__Ray__Single_s);
		addMember(l,RaycastAll__Vector3__Vector3__Single_s);
		addMember(l,RaycastAll__Ray__Single__Int32_s);
		addMember(l,RaycastAll__Vector3__Vector3__Single__Int32_s);
		addMember(l,RaycastAll__Ray__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,RaycastAll__Vector3__Vector3__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,RaycastNonAlloc__Ray__A_RaycastHit_s);
		addMember(l,RaycastNonAlloc__Vector3__Vector3__A_RaycastHit_s);
		addMember(l,RaycastNonAlloc__Ray__A_RaycastHit__Single_s);
		addMember(l,RaycastNonAlloc__Ray__A_RaycastHit__Single__Int32_s);
		addMember(l,RaycastNonAlloc__Vector3__Vector3__A_RaycastHit__Single_s);
		addMember(l,RaycastNonAlloc__Ray__A_RaycastHit__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,RaycastNonAlloc__Vector3__Vector3__A_RaycastHit__Single__Int32_s);
		addMember(l,RaycastNonAlloc__Vector3__Vector3__A_RaycastHit__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,CapsuleCastAll__Vector3__Vector3__Single__Vector3_s);
		addMember(l,CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single_s);
		addMember(l,CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single__Int32_s);
		addMember(l,CapsuleCastAll__Vector3__Vector3__Single__Vector3__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,SphereCastAll__Ray__Single_s);
		addMember(l,SphereCastAll__Vector3__Single__Vector3_s);
		addMember(l,SphereCastAll__Ray__Single__Single_s);
		addMember(l,SphereCastAll__Vector3__Single__Vector3__Single_s);
		addMember(l,SphereCastAll__Ray__Single__Single__Int32_s);
		addMember(l,SphereCastAll__Vector3__Single__Vector3__Single__Int32_s);
		addMember(l,SphereCastAll__Ray__Single__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,SphereCastAll__Vector3__Single__Vector3__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,OverlapCapsule__Vector3__Vector3__Single_s);
		addMember(l,OverlapCapsule__Vector3__Vector3__Single__Int32_s);
		addMember(l,OverlapCapsule__Vector3__Vector3__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,OverlapSphere__Vector3__Single_s);
		addMember(l,OverlapSphere__Vector3__Single__Int32_s);
		addMember(l,OverlapSphere__Vector3__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,Simulate_s);
		addMember(l,SyncTransforms_s);
		addMember(l,ComputePenetration_s);
		addMember(l,ClosestPoint_s);
		addMember(l,OverlapSphereNonAlloc__Vector3__Single__A_Collider_s);
		addMember(l,OverlapSphereNonAlloc__Vector3__Single__A_Collider__Int32_s);
		addMember(l,OverlapSphereNonAlloc__Vector3__Single__A_Collider__Int32__QueryTriggerInteraction_s);
		addMember(l,CheckSphere__Vector3__Single_s);
		addMember(l,CheckSphere__Vector3__Single__Int32_s);
		addMember(l,CheckSphere__Vector3__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__A_RaycastHit_s);
		addMember(l,CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__A_RaycastHit__Single_s);
		addMember(l,CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__A_RaycastHit__Single__Int32_s);
		addMember(l,CapsuleCastNonAlloc__Vector3__Vector3__Single__Vector3__A_RaycastHit__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,SphereCastNonAlloc__Ray__Single__A_RaycastHit_s);
		addMember(l,SphereCastNonAlloc__Vector3__Single__Vector3__A_RaycastHit_s);
		addMember(l,SphereCastNonAlloc__Ray__Single__A_RaycastHit__Single_s);
		addMember(l,SphereCastNonAlloc__Vector3__Single__Vector3__A_RaycastHit__Single_s);
		addMember(l,SphereCastNonAlloc__Ray__Single__A_RaycastHit__Single__Int32_s);
		addMember(l,SphereCastNonAlloc__Vector3__Single__Vector3__A_RaycastHit__Single__Int32_s);
		addMember(l,SphereCastNonAlloc__Ray__Single__A_RaycastHit__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,SphereCastNonAlloc__Vector3__Single__Vector3__A_RaycastHit__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,CheckCapsule__Vector3__Vector3__Single_s);
		addMember(l,CheckCapsule__Vector3__Vector3__Single__Int32_s);
		addMember(l,CheckCapsule__Vector3__Vector3__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,CheckBox__Vector3__Vector3_s);
		addMember(l,CheckBox__Vector3__Vector3__Quaternion_s);
		addMember(l,CheckBox__Vector3__Vector3__Quaternion__Int32_s);
		addMember(l,CheckBox__Vector3__Vector3__Quaternion__Int32__QueryTriggerInteraction_s);
		addMember(l,OverlapBox__Vector3__Vector3_s);
		addMember(l,OverlapBox__Vector3__Vector3__Quaternion_s);
		addMember(l,OverlapBox__Vector3__Vector3__Quaternion__Int32_s);
		addMember(l,OverlapBox__Vector3__Vector3__Quaternion__Int32__QueryTriggerInteraction_s);
		addMember(l,OverlapBoxNonAlloc__Vector3__Vector3__A_Collider_s);
		addMember(l,OverlapBoxNonAlloc__Vector3__Vector3__A_Collider__Quaternion_s);
		addMember(l,OverlapBoxNonAlloc__Vector3__Vector3__A_Collider__Quaternion__Int32_s);
		addMember(l,OverlapBoxNonAlloc__Vector3__Vector3__A_Collider__Quaternion__Int32__QueryTriggerInteraction_s);
		addMember(l,BoxCastNonAlloc__Vector3__Vector3__Vector3__A_RaycastHit_s);
		addMember(l,BoxCastNonAlloc__Vector3__Vector3__Vector3__A_RaycastHit__Quaternion_s);
		addMember(l,BoxCastNonAlloc__Vector3__Vector3__Vector3__A_RaycastHit__Quaternion__Single_s);
		addMember(l,BoxCastNonAlloc__Vector3__Vector3__Vector3__A_RaycastHit__Quaternion__Single__Int32_s);
		addMember(l,BoxCastNonAlloc__Vector3__Vector3__Vector3__A_RaycastHit__Quaternion__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,BoxCastAll__Vector3__Vector3__Vector3_s);
		addMember(l,BoxCastAll__Vector3__Vector3__Vector3__Quaternion_s);
		addMember(l,BoxCastAll__Vector3__Vector3__Vector3__Quaternion__Single_s);
		addMember(l,BoxCastAll__Vector3__Vector3__Vector3__Quaternion__Single__Int32_s);
		addMember(l,BoxCastAll__Vector3__Vector3__Vector3__Quaternion__Single__Int32__QueryTriggerInteraction_s);
		addMember(l,OverlapCapsuleNonAlloc__Vector3__Vector3__Single__A_Collider_s);
		addMember(l,OverlapCapsuleNonAlloc__Vector3__Vector3__Single__A_Collider__Int32_s);
		addMember(l,OverlapCapsuleNonAlloc__Vector3__Vector3__Single__A_Collider__Int32__QueryTriggerInteraction_s);
		addMember(l,RebuildBroadphaseRegions_s);
		addMember(l,"IgnoreRaycastLayer",get_IgnoreRaycastLayer,null,false);
		addMember(l,"DefaultRaycastLayers",get_DefaultRaycastLayers,null,false);
		addMember(l,"AllLayers",get_AllLayers,null,false);
		addMember(l,"gravity",get_gravity,set_gravity,false);
		addMember(l,"defaultContactOffset",get_defaultContactOffset,set_defaultContactOffset,false);
		addMember(l,"sleepThreshold",get_sleepThreshold,set_sleepThreshold,false);
		addMember(l,"queriesHitTriggers",get_queriesHitTriggers,set_queriesHitTriggers,false);
		addMember(l,"queriesHitBackfaces",get_queriesHitBackfaces,set_queriesHitBackfaces,false);
		addMember(l,"bounceThreshold",get_bounceThreshold,set_bounceThreshold,false);
		addMember(l,"defaultSolverIterations",get_defaultSolverIterations,set_defaultSolverIterations,false);
		addMember(l,"defaultSolverVelocityIterations",get_defaultSolverVelocityIterations,set_defaultSolverVelocityIterations,false);
		addMember(l,"defaultPhysicsScene",get_defaultPhysicsScene,null,false);
		addMember(l,"autoSimulation",get_autoSimulation,set_autoSimulation,false);
		addMember(l,"autoSyncTransforms",get_autoSyncTransforms,set_autoSyncTransforms,false);
		addMember(l,"reuseCollisionCallbacks",get_reuseCollisionCallbacks,set_reuseCollisionCallbacks,false);
		addMember(l,"interCollisionDistance",get_interCollisionDistance,set_interCollisionDistance,false);
		addMember(l,"interCollisionStiffness",get_interCollisionStiffness,set_interCollisionStiffness,false);
		addMember(l,"interCollisionSettingsToggle",get_interCollisionSettingsToggle,set_interCollisionSettingsToggle,false);
		createTypeMetatable(l,null, typeof(UnityEngine.Physics));
	}
}
