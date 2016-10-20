require "utility";

TopLevel = {
	Child2 = {
		Point = {

			X = nil,
			Y = nil,

			newObject = function(self)
				local obj = self();
				if obj.ctor then
					obj.ctor();
				end;
				return obj;
			end,
			defineClass = function(self)
				local static = self;

				local static_props = {
				};

				local instance = {

				};

				local instance_props = {
				};

				return defineclass(static, static_props, instance, instance_props);
			end,
		},
	},
};

return TopLevel.Child2.Point:defineClass();