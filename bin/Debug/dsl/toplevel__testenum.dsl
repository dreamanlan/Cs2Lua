require("cs2lua__utility");
require("cs2lua__namespaces");
require("cs2lua__externenums");
require("cs2lua__interfaces");

enum(TopLevel.TestEnum, System.Enum) {
	member("Invalid", -2147483648);
	member("One", 1);
	member("Two", 2);
	member("Three", 4);
	member("Four", 38);
};



