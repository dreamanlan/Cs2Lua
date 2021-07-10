require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

enum(DataBlockDefine.ContainerTypeEnum, System.Enum, true) {
	member("Int64Vector", 1);
	member("UInt64Vector", 2);
	member("DoubleVector", 3);
	member("StrInt64Map", 4);
	member("StrUInt64Map", 5);
	member("StrDoubleMap", 6);
	member("Int64Int64Map", 7);
	member("Int64UInt64Map", 8);
	member("Int64DoubleMap", 9);
};



