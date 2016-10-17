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
};
