require "utility";

TopLevel = {
	Child2 = {
		Point = {
			X = nil,
			Y = nil,
			new = function(self)
				local o = {
				};
				setmetatable(o, self);
				self.__index = self;
				return o;
			end,
		},
	},
};
