require "utility";
TopLevel = {
	Child1 = {
		Foo = {
			new = function(self)
				local o = {
					ctor = function(self)
					end,
					ctor = function(self, v)
						self.m_Test = v;
					end,
					Test = function(self, a, b, ...)
						local c = nil;
						local f = (function(p1) return p1; end);
						f(1);
						local f2 = (function(p1, p2)
							return p1 + p2;
						end);
						f2(1, 2);
						self.m_Test = a + b + 123;
						b = condexp(a < b, a, b);
						if a > 0 then
							c = a + b + ({...})[0 + 1];
						end;
						if a < b then
							c = b - a;
						elseif a >= b then
							c = a - b;
						end;
						if a < b then
							c = b - a;
						else
							c = a - b;
						end;
						if a < b then
							c = b - a;
						elseif a < c then
							c = a - b;
						else
							c = 0;
						end;
						return b, c;
					end,
					Test2 = function(self, a, b, c)
						local d = nil;
						c = c + a + b;
						d = c * 2;
						return c, c, d;
					end,
					OnSimple2 = nil,
					m_Test = 0,
				};
				setmetatable(o, self);
				self.__index = self;
				return o;
			end,
		},
	},
	Child2 = {
		TestEnum = {
			One = 0,
			Two = 1,
			Three = 2,
		},
		Bar = {
			s_Test = 123,
			new = function(self)
				local o = {
					Handler = function(self)
						local f = (function()
							LuaConsole.Print(1, 2, 3);
						end);
						self.Test__System_Int32(123);
						local t = self.Test__System_Int32;
						t(1);
					end,
					Test = function(self)
						local F = TopLevel.Child2.Bar.s_Test;
						local f = (function() local obj = TopLevel.Child1.Foo:new(); obj:ctor(123); return obj; end)();
						f.OnSimple = self.Handler;
						local ff = (function() local obj = TopLevel.Child1.Foo:new(); local self = obj;self.m_Test = 456; return obj; end)();
						local a = 0;
						local b = 0;
						local c = 0;
						b = ( (function() c = c + 2; return c; end)() );
						local dict = (function() local obj = wrapdictionary{}; obj["key1"] = "value1"; obj["key2"] = "value2"; return obj; end)();
						self.Test__System_Collections_Generic_Dictionary(dict);
						b, c = f:Test(1, b, 3);
						LuaConsole.Print(b, c);
						local r = 0;
						r = r + (function() local ret; ret, b, c = f:Test2(1, 2, b); return ret; end)();
						LuaConsole.Print(r, b, c);
						local v0, b, c = f:Test2(3, 4, b);
						local v;
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
						local __compiler_continue_136__ = false
						repeat
							g0[i] = wraparray{};
							if true then
								__compiler_continue_136__ = true;
								break;
							end;
							if true then
								__compiler_continue_136__ = false;
								break;
							end;
							local j = 0;
							while j < g0[i].Length do
								g0[i][j] = wraparray{};
								j = j + 1;
							end;
							i = i + 1;
						until true;
						if __compiler_continue_136__ then break; end;
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
						local hh = wraparray{7, 6, 7, 8};
						self.Test__Arr_System_Int32(hh);
						local __compiler_switch_156__ = a;
						if (__compiler_switch_156__ == 1) and (__compiler_switch_156__ == 3) then
						repeat
							if a == 1 then
								break;
							end;
							break;
						until 0 ~= 0;
						elseif __compiler_switch_156__ == 2 then
						else
						end;
						local __compiler_foreach_169__ = (def):GetEnumerator();
						while __compiler_foreach_169__:MoveNext() do
							i = __compiler_foreach_169__.Current;
							TopLevel.Child2.Bar.s_Test = TopLevel.Child2.Bar.s_Test + i;
						end;
						self.Test__Arr_System_Int32(wraparray{1, 2, 3});
						self.Test__Arr_System_Int32(wraparray{1, 2, 3});
						self.Test__System_Collections_Generic_Dictionary((function() local obj = wrapdictionary{}; obj["1"] = "2"; obj["3"] = "4"; return obj; end)());
					end,
					Test__System_Int32 = function(self, v)
						LuaConsole.Print(v);
					end,
					Test__Arr_System_Int32 = function(self, arr)
					end,
					Test__System_Collections_Generic_Dictionary = function(self, dict)
					end,
				};
				setmetatable(o, self);
				self.__index = self;
				return o;
			end,
		},
--local obj = TopLevel.Child2.Bar:new();
--obj:Test();
	},
};
