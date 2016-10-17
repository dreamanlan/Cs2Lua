require "utility";
require "LuaConsole";
require "TopLevel_Child1_Foo";

TopLevel = {
	Child2 = {
		Bar = {
			s_Test = 123,
			new = function(self)
				local o = {
					Handler = function(self)
						local f = (function()
							LuaConsole.Print(1, 2, 3);
						end);
					end,
					Test = function(self)
						local F = TopLevel.Child2.Bar.s_Test;
						local f = (function() local obj = TopLevel.Child1.Foo:new();obj:ctor(123);return obj; end)();
						f.OnSimple = self.Handler;
						local ff = (function() local obj = TopLevel.Child1.Foo:new();local self = obj;self.m_Test = 456;return obj; end)();
						local a = 0;
						local b = 0;
						local c = 0;
						b = ( (function() c = c + 2; return c; end)() );
						local dict = (function() local obj = System.Collections.Generic.Dictionary:new();local self = obj;obj[key] = value;return obj; end)();
						b, c = f:Test(1, b, 3);
						LuaConsole.Print(b, c);
						local r = 0;
						r = r + (function() local ret; ret, b, c = f:Test2(1, 2, b); return ret; end)();
						LuaConsole.Print(r, b, c);
						local v;
						v, b, c = f:Test2(3, 4, b);
						LuaConsole.Print(v, b, c);
						while a < 12 do
						repeat
							if a < 8 then
								break;
							end;
							a = a + 1;
						until 0~= 0;
						end;
						repeat
							b = b + 1;
						until not (b < 100);
						local abc = {};
						local def = {1, 2, 3, 4, 5};
						local g0 = {};
						local h0 = (function() local arr={};local d0=3;for i0=1,d0 do arr[i0] = {};local d1=5;for i1=1,d1 do arr[i0][i1] = {};local d2=7;for i2=1,d2 do arr[i0][i1][i2] = nil; end; end; end; return arr; end)();
						local g = {{1, 2}, {3, 4}};
						local h = {{1, 2}, {3, 4}};
						local i = 0;
						while i < g0.Length do
						local __compiler_continue_131__ = false
						repeat
							g0[i] = {};
							if True then
								__compiler_continue_131__ = true;
								break;
							end;
							if True then
								__compiler_continue_131__ = false;
								break;
							end;
							local j = 0;
							while j < g0[i].Length do
								g0[i][j] = {};
								j = j + 1;
							end;
							i = i + 1;
						until 0~= 0;
						if __compiler_continue_131__ then break; end;
						end;
						local i = 0;
						while i < h0:GetLength(0) do
							local j = 0;
							while j < h0:GetLength(1) do
								local k = 0;
								while k < h0:GetLength(2) do
									h0[i][j][k] = i * j * k;
									k = k + 1;
								end;
								j = j + 1;
							end;
							i = i + 1;
						end;
						local hh = {7, 6, 7, 8};
						local __compiler_switch_150__ = a;
						if (__compiler_switch_150__ == 1) and (__compiler_switch_150__ == 3) then
						repeat
							if a == 1 then
								break;
							end;
							break;
						until 0 ~= 0;
						elseif __compiler_switch_150__ == 2 then
						else
						end;
						local __compiler_foreach_163__ = (def):GetEnumerator();
						while __compiler_foreach_163__:MoveNext() do
							i = __compiler_foreach_163__.Current;
							self.s_Test = self.s_Test + i;
						end;
					end,
				};
				setmetatable(o, self);
				self.__index = self;
				return o;
			end,
		},
	},
};
