
using System;
using System.Collections.Generic;

namespace SLua
{
    public partial class LuaDelegation : LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out UnityEngine.Video.VideoPlayer.FrameReadyEventHandler ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,p)) {
				ua=null;
				return op;
			}
            else if (LuaDLL.lua_isuserdata(l, p)==1)
            {
                ua = (UnityEngine.Video.VideoPlayer.FrameReadyEventHandler)checkObj(l, p);
                return op;
            }
            LuaDelegate ld;
            checkType(l, -1, out ld);
			LuaDLL.lua_pop(l,1);
            if(ld.d!=null)
            {
                ua = (UnityEngine.Video.VideoPlayer.FrameReadyEventHandler)ld.d;
                return op;
            }
			
			l = LuaState.get(l).L;
            ua = (UnityEngine.Video.VideoPlayer a1,System.Int64 a2) =>
            {
                int error = pushTry(l);

				pushValue(l, a1);
				pushValue(l, a2);
				ld.pcall(2, error);
				LuaDLL.lua_settop(l, error-1);
			};
			ld.d=ua;
			return op;
		}
	}
}
