require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";

TopLevel.TestEnum = {
	["Invalid"] = -2147483648,
	["One"] = 1,
	["Two"] = 2,
	["Three"] = 4,
	["Four"] = 38.00,
};

rawset(TopLevel.TestEnum, "Value2String", {
		[-2147483648] = "Invalid",
		[1] = "One",
		[2] = "Two",
		[4] = "Three",
		[38.00] = "Four",
});
