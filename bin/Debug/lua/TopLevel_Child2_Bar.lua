require "utility";
require "TopLevel_Child1_Foo";

TopLevel = {
	Child2 = {
		Bar = {

			s_Test = 123,

			newObject = function(...)
				local args = ...;
				return newobject(TopLevel.Child2.Bar, (function(obj) obj = obj:ctor(args); return obj; end));
			end,
			defineClass = function()
				local static = TopLevel.Child2.Bar;

				local static_props = {
				};

				local static_events = {
				};

				local instance = {
					ctor = function(self, i, j)
						return self;
					end,
					Handler = function(self)
						local f = (function()
							LuaConsole.Print(1, 2, 3);
						end);
						Test__System_Int32(123);
						local t = wrapdelegate((function(v) self:Test__System_Int32(v) end));
						Invoke(1);
						local t2 = wrapdelegate((function(v) self.Test__System_Int32(v) end));
						Invoke(2);
					end,
					Test = function(self)
						local F = TopLevel.Child2.Bar.s_Test;
						local f = newinternobject(TopLevel.Child1.Foo, (function(obj) objobj:ctor__System_Int32(123); return obj; end));
						interndelegationset(f.OnSimple, (function() self.Handler() end));
						local ff = newinternobject(TopLevel.Child1.Foo, (function(obj) objobj:ctor(); self.m_Test = 456; self.m_Test2 = 789; return obj; end));
						local a = 0;
						local b = 0;
						local c = 0;
						b = ( (function() c = c + 2; return c; end)() );
						local list = newexternobject(System.Collections.Generic.List, (function(obj) ; return obj; end));
						list:Add(newexternobject(System.Collections.Generic.List, (function(obj) ; return obj; end)));
						local v = list:__indexer_get(0);
						local dict = newexternobject(System.Collections.Generic.Dictionary, (function(obj) ; return obj; end));
						Test__System_Collections_Generic_Dictionary(dict);
						b, c = f:Test__System_Int32__Ref_System_Int32__Out_System_Int32__Arr_System_Int32(1, b, 3);
						LuaConsole.Print(b, c);
						local r = 0;
						r = r + (function() local ret; ret, b, c = f:Test2(1, 2, b); return ret; end)();
						LuaConsole.Print(r, b, c);
						local v0, b, c = f:Test2(3, 4, b);
						local v = nullablecondexp(ff, f);
						local vv = (function() local v = f; if v == nil then return nil; else return v.m_Test; end; end)();
						local vvv = (function() local v = f; if v == nil then return nil; else return vTest__System_Int32(123); end; end)();
						v, b, c = f:Test2(3, 4, b);
						LuaConsole.Print(v, b, c);
						while a < 12 do
						repeat
							a = a + 1;
							if a < 8 then
								break;
							end;
						until true;
						end;
						repeat
							b = b + 1;
						until not (b < 100);
						local abc = wraparray{};
						local def = wraparray{1, 2, 3, 4, 5};
						local g0 = wraparray{};
						local h0 = (function() local arr = wraparray{}; local d0 = 3; for i0 = 1,d0 do arr[i0] = {}; local d1 = 5; for i1 = 1,d1 do arr[i0][i1] = {}; local d2 = 7; for i2 = 1,d2 do arr[i0][i1][i2] = nil; end; end; end; return arr; end)();
						local g = wraparray{wraparray{1, 2}, wraparray{3, 4}};
						local h = wraparray{wraparray{1, 2}, wraparray{3, 4}};
						local i = 0;
						while i < g0.Length do
						local __compiler_continue_227 = false
						repeat
							g0[i + 1] = wraparray{};
							if true then
								__compiler_continue_227 = true;
								break;
							end;
							if true then
								__compiler_continue_227 = false;
								break;
							end;
							local j = 0;
							while j < g0[i + 1].Length do
								g0[i + 1][j + 1] = wraparray{};
								j = j + 1;
							end;
							i = i + 1;
						until true;
						if __compiler_continue_227 then break; end;
						end;
						local i = 0;
						while i < h0:GetLength(0) do
							local j = 0;
							while j < h0:GetLength(1) do
								local k = 0;
								while k < h0:GetLength(2) do
									h0[i + 1][j + 1][k + 1] = i * j * k;
									k = k + 1;
								end;
								j = j + 1;
							end;
							i = i + 1;
						end;
						local hh = wraparray{7, 6, 7, 8};
						Test__Arr_System_Int32(hh);
						local __compiler_switch_247 = a;
						if (__compiler_switch_247 == 1) and (__compiler_switch_247 == 3) then
						repeat
							if a == 1 then
								break;
							end;
							break;
						until 0 ~= 0;
						elseif __compiler_switch_247 == 2 then
						else
						end;
						local __compiler_foreach_260 = (def):GetEnumerator();
						while __compiler_foreach_260:MoveNext() do
							i = __compiler_foreach_260.Current;
							TopLevel.Child2.Bar.s_Test = TopLevel.Child2.Bar.s_Test + (function() local v = hh; if v == nil then return nil; else return v[i + 1]; end; end)();
						end;
						Test__Arr_System_Int32(wraparray{1, 2, 3});
						Test__Arr_System_Int32(wraparray{1, 2, 3});
						Test__System_Collections_Generic_Dictionary(newexternobject(System.Collections.Generic.Dictionary, (function(obj) ; return obj; end)));
					end,
					Test__System_Int32 = function(self, v)
						LuaConsole.Print(v);
					end,
					Test__Arr_System_Int32 = function(self, arr)
					end,
					Test__System_Collections_Generic_Dictionary = function(self, dict)
					end,

				};

				local instance_props = {
				};

				local instance_events = {
				};

				return defineclass(static, static_props, static_events, instance, instance_props, instance_events);
			end,
		},
	},
};

return TopLevel.Child2.Bar.defineClass();--local obj = TopLevel.Child2.Bar:new();
--obj:Test();
