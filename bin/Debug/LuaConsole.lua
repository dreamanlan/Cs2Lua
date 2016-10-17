require "utility";

LuaConsole = {
	Print = function(...)
		print(...);
	end,
	new = function(self)
		local o = {
		};
		setmetatable(o, self);
		self.__index = self;
		return o;
	end,
};
