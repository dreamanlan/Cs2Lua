require "utility";

MyScript = {
	new = function(self)
		local o = {
			Init = function(self, parent)
				local obj = UnityEngine.GameObject("test");
				obj.transform.parent = parent;
				obj:SetActive(true);
				local s = "123";
			end,
			Update = function(self)
			end,
		};
		setmetatable(o, self);
		self.__index = self;
		return o;
	end,
};
