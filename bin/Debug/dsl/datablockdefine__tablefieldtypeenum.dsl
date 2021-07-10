require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

enum(DataBlockDefine.TableFieldTypeEnum, System.Enum, true) {
	member("TableInt32Field", 1);
	member("TableInt64Field", 2);
	member("TableFloatField", 3);
	member("TableStringField", 4);
	member("TableInt32ArrayField", 5);
	member("TableInt64ArrayField", 6);
	member("TableFloatArrayField", 7);
	member("TableStringArrayField", 8);
};



