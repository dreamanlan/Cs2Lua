
using System;
using System.Collections.Generic;

namespace SLua
{
    public partial class LuaDelegation : LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out UnityEngine.U2D.SpriteAtlasManager.RequestAtlasCallback ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,p)) {
				ua=null;
				return op;
			}
            else if (LuaDLL.lua_isuserdata(l, p)==1)
            {
                ua = (UnityEngine.U2D.SpriteAtlasManager.RequestAtlasCallback)checkObj(l, p);
                return op;
            }
            if(LuaDLL.lua_isnil(l,-1)) {
				ua=null;
				return op;
			}
            LuaDelegate ld;
            checkType(l, -1, out ld);
			LuaDLL.lua_pop(l,1);
            if(ld.d!=null)
            {
                ua = (UnityEngine.U2D.SpriteAtlasManager.RequestAtlasCallback)ld.d;
                return op;
            }
			
			l = LuaState.get(l).L;
            ua = (string a1,System.Action<UnityEngine.U2D.SpriteAtlas> a2) =>
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
