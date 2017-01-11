require "cs2lua__utility";
require "cs2lua__namespaces";
require "cs2lua__externenums";

TopLevel.TestEnum = {
	Invalid = -2147483648,
	One = 1,
	Two = 2,
	Three = 3,
	Four = 38,
};

rawset(TopLevel.TestEnum, "Value2String", {
		[-2147483648] = "Invalid",
		[1] = "One",
		[2] = "Two",
		[3] = "Three",
		[38] = "Four",
});
