require "utility";

TopLevel = {
	Child1 = {
		GenericClass = {
			cctor = function()
				TopLevel.Child1.GenericClass.s_Test = 9876;
			end,

			OnAction0 = wrapdelegation(),
			OnAction1 = nil,
			s_Test = 8765,

			newObject = function(...)
				local args = ...;
				return newobject(TopLevel.Child1.GenericClass, (function(obj) local v, v2; obj, v, v2 = obj:ctor(args); return obj; end));
			end,
			defineClass = function()
				local static = TopLevel.Child1.GenericClass;

				local static_props = {
				};

				local static_events = {
				};

				local instance = {
					__indexer_get = function(self, v1, v2)
						return 123;
					end,
					__indexer_set = function(self, v1, v2, value)
					end,
					Test = function(self, v)
						LuaConsole.Print(typeis(v, "System.Int32"));
						local path = "";
						local fs = newexternobject(System.IO.StreamWriter, (function(obj) return obj; end));
						LuaConsole.Print(fs:ToString());
						fs:Dispose();
						local s = "test";
						local obj = wrapdictionary{a = 123, b = 456};
						LuaConsole.Print(obj.a);
						local v = self:__indexer_get(1, 2);
						self:__indexer_set(2, 3, 456);
					end,
					ctor = function(self, v)
						local v2 = nil;
						self.m_Test = v + 456;
						v = 123;
						v2 = 789;
						return self, v, v2;
					end,

					PropErr = 456,
					OnAction2 = wrapdelegation(),
					OnAction3 = wrapdelegation(),
					m_Test = 123,
				};

				local instance_props = {
					Prop = {
						get = function(self)
							return 1;
						end,
						set = function(self, value)
							self.m_Test = value;
						end,
					},
				};

				local instance_events = {
					AAA = {
						add = function(self, value)
							interndelegationadd(OnAction0, value);
						end,
						remove = function(self, value)
							interndelegationremove(OnAction0, value);
						end,
					},
				};

				return defineclass(static, static_props, static_events, instance, instance_props, instance_events);
			end,
		},
	},
};

return TopLevel.Child1.GenericClass.defineClass();