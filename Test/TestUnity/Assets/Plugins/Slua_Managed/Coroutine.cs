// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

#if !SLUA_STANDALONE
namespace SLua
{
	using UnityEngine;
	using System.Collections;
	using SLua;
	using System;

	public class LuaCoroutine : LuaObject
	{

		static MonoBehaviour mb;

		static public void reg(IntPtr l, MonoBehaviour m)
		{
			mb = m;
            reg(l, Yieldk, "UnityEngine");
            reg(l, WrapEnumerator, "UnityEngine");

			string yield =
@"
local Yield = UnityEngine.Yieldk
UnityEngine.Yield = function(x)
	local co, ismain = coroutine.running()
	if ismain then error('Can not yield in main thread') end

	if type(x) == 'thread' and coroutine.status(x) ~= 'dead' then
		repeat
			Yield(nil, function() lualog('coroutine.resume status:{0} after thread {1}', coroutine.status(co), x);coroutine.resume(co) end)
            lualog('coroutine.yield for thread {1}', x)
			coroutine.yield()
		until coroutine.status(x) == 'dead'
	else
		Yield(x, function() lualog('coroutine status:{0} after {1}', coroutine.status(co), x);if coroutine.status(co) == 'suspended' then coroutine.resume(co) end; end)
		lualog('coroutine.yield for {1}', x)
        coroutine.yield()
	end
end
";
			LuaState.get(l).doString(yield);
		}

		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		static public int Yieldk(IntPtr l)
		{
			try
			{
				if (LuaDLL.lua_pushthread(l) == 1)
				{
					return error(l, "should put Yield call into lua coroutine.");
				}
				object y = checkObj(l, 1);
				LuaFunction f;
				checkType(l, 2, out f);

				mb.StartCoroutine(yieldReturn(y, f));
				pushValue(l, true);
				return 1;
			}
			catch (Exception e)
			{
				return error(l, e);
			}
		}

		static public IEnumerator yieldReturn(object y, LuaFunction f)
		{
			if (y is IEnumerator)
				yield return mb.StartCoroutine((IEnumerator)y);
			else
				yield return y;
			f.call();
        }

        [MonoPInvokeCallback(typeof(LuaCSFunction))]
        static public int WrapEnumerator(IntPtr l)
        {
            try {
                var t = LuaDLL.lua_tothread(l, 1);
                IEnumerator enumer = buildEnumerator(t);
                LuaDLL.lua_pop(l, 1);
                pushValue(l, true);
                pushValue(l, enumer);
                return 2;
            } catch (Exception e) {
                return error(l, e);
            }
        }
        
        static public IEnumerator buildEnumerator(IntPtr l)
        {
            LuaDLL.lua_resume(l, 0);
            for (; ; ) {
                int r = LuaDLL.lua_status(l);
                if (r == 0) {
                    if (LuaDLL.lua_gettop(l) == 0)
                        break;
                    else
                        yield return null;
                } else if (r == (int)SLua.LuaThreadStatus.LUA_YIELD) {
                    yield return null;
                } else {
                    break;
                }
            }
        }
	}
}
#endif
