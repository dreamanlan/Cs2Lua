--local write = io.write;
require "utility";

Mandelbrot = {
	Exec = function()
		local width = 50;
		local height = width;
		local maxiter = 50;
		local limit = 4;
		write("P4\n", width, " ", height, "\n");
		local y = 0;
		while y < height do
			local Ci = 2 * y / height - 1;
			local x = 0;
			while x < width do
				local Zr = 0;
				local Zi = 0;
				local Cr = 2 * x / width - 1.5;
				local i = maxiter;
				local isInside = true;
				repeat
					local Tr = Zr * Zr - Zi * Zi + Cr;
					Zi = 2 * Zr * Zi + Ci;
					Zr = Tr;
					if Zr * Zr + Zi * Zi > limit then
						isInside = false;
						break;
					end;
				until not ((function() i = i - 1; return i; end)() > 0);
				if isInside then
					write("*");
				else
					write(" ");
				end;
				x = x + 1;
			end;
			print();
			y = y + 1;
		end;
	end,
	new = function(self)
		local o = {
		};
		setmetatable(o, self);
		self.__index = self;
		return o;
	end,
};
--Mandelbrot.Exec();
