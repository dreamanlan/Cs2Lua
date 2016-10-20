require "utility";
require "TopLevel_Child1_GenericClass";

TopLevel = {
	Child1 = {
		Foo = {


			newObject = function(...)
				local args = ...;
				return newobject(TopLevel.Child1.Foo, (function(obj) obj = obj:ctor(args); return obj; end));
			end,
			defineClass = function()
				local static = TopLevel.Child1.Foo;

				local static_props = {
				};

				local static_events = {
				};

				local instance = {
					ctor = function(self)
						self:ctor__System_Int32(0);
						return self;
					end,
					ctor__System_Int32 = function(self, v)
						self.m_Test = v;
						return self;
					end,
					Test__System_Int32__Ref_System_Int32__Out_System_Int32__Arr_System_Int32 = function(self, a, b, ...)
						local args = ...;
						local c = nil;
						local f = wrapdelegate((function(p1) return p1; end));
						Invoke(1);
						local f2 = wrapdelegate((function(p1, p2)
							return p1 + p2;
						end));
						Invoke(1, 2);
						self.m_Test = a + b + 123;
						b = condexp(a < b, a, b);
						if a > 0 then
							c = a + b + args[1];
						end;
						local v = (function() local v = args; if v == nil then return nil; else return v.Length; end; end)();
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
					Test__System_Int32 = function(self, v)
						local v1 = 0;
						local v2;
						local f = newinternobject(TopLevel.Child1.GenericClass, (function(obj) obj, v1, v2 = obj:ctor(v1); return obj; end));
						local v = f:__indexer_get(3, 4);
						f:__indexer_set(4, 5, 6);
						f:__indexer_set(4, 5, (function() local ret; ret, v1, v2 = Test2(1, 2, v1) return ret; end)());
						v, v1, v2 = Test2(1, 2, v1);
						v1, v2 = Test2(1, 2, v1);
						v = 1 + (function() local ret; ret, v1, v2 = Test2(1, 2, v1) return ret; end)();
						v = v + (function() local ret; ret, v1, v2 = Test2(1, 2, v1); return ret; end)();
						v2 = ( (function() v, v1, v2 = Test2(1, 2, v1); return v; end)() );
						f:Test(v);
						interndelegationadd(OnSimple, (function()
						end));
						do
							interndelegationadd(self.OnSimple2, (function()
							end));
						end;
					end,

					OnSimple = wrapdelegation(),
					OnSimple2 = wrapdelegation(),
					m_Test = 0,
					m_Test2 = 0,
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

return TopLevel.Child1.Foo.defineClass();