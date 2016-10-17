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
						f.OnSimple = f.OnSimple + self.Handler;
						local ff = (function() local obj = TopLevel.Child1.Foo:new();local self = obj;self.m_Test = 456;return obj; end)();
						local a = 0;
						local b = 0;
						local c = 0;
						b = ( (function() c = c + 2; return c; end)() );
						b, c = f:Test(1, b, 3);
						LuaConsole.Print(b, c);
						local r, b, c = f:Test2(1, 2, b);
						LuaConsole.Print(r, b, c);
						local v;
						v, b, c = f:Test2(3, 4, b);
						LuaConsole.Print(v, b, c);
						while a < 10 do
							a = a + 1;
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
							g0[i] = {};
							local j = 0;
							while j < g0[i].Length do
								g0[i][j] = {};
								j = j + 1;
							end;
							i = i + 1;
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
						local hh = {5, 6, 7, 8};
					end,
				};
				setmetatable(o, self);
				self.__index = self;
				return o;
			end,
		},
	},
};
--local obj = TopLevel.Child2.Bar:new();
--obj.Test();
