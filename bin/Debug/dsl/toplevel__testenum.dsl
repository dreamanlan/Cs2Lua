require("cs2dsl__lualib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

enum(TopLevel.TestEnum, System.Enum) {
	member("Invalid", -2147483648);
	member("One", 1);
	member("Two", 2);
	member("Three", 4);
	member("Four", 38);
};



