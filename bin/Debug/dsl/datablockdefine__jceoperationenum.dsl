require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

enum(DataBlockDefine.JceOperationEnum, System.Enum, true) {
	member("Nothing", 0);
	member("Post", 1);
	member("Recycle", 2);
	member("PostAndRecycle", 3);
};



