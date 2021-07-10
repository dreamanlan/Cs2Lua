require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

enum(DataBlockDefine.DataBlockFieldTypeEnum, System.Enum, true) {
	member("DataBoolField", 1);
	member("DataInt8Field", 2);
	member("DataUInt8Field", 3);
	member("DataInt16Field", 4);
	member("DataUInt16Field", 5);
	member("DataInt32Field", 6);
	member("DataUInt32Field", 7);
	member("DataInt64Field", 8);
	member("DataUInt64Field", 9);
	member("DataFloatField", 10);
	member("DataDoubleField", 11);
	member("DataStringField", 12);
	member("DataBoolArrayField", 13);
	member("DataInt8ArrayField", 14);
	member("DataUInt8ArrayField", 15);
	member("DataInt16ArrayField", 16);
	member("DataUInt16ArrayField", 17);
	member("DataInt32ArrayField", 18);
	member("DataUInt32ArrayField", 19);
	member("DataInt64ArrayField", 20);
	member("DataUInt64ArrayField", 21);
	member("DataFloatArrayField", 22);
	member("DataDoubleArrayField", 23);
	member("DataStringArrayField", 24);
	member("DataStructField", 25);
	member("DataStructArrayField", 26);
	member("DataInt64VectorField", 27);
	member("DataUInt64VectorField", 28);
	member("DataDoubleVectorField", 29);
	member("DataStrVectorField", 30);
	member("DataStructVectorField", 31);
	member("DataStrInt64MapField", 32);
	member("DataStrUInt64MapField", 33);
	member("DataStrDoubleMapField", 34);
	member("DataStrStrMapField", 35);
	member("DataStrStructMapField", 36);
	member("DataInt64Int64MapField", 37);
	member("DataInt64UInt64MapField", 38);
	member("DataInt64DoubleMapField", 39);
	member("DataInt64StrMapField", 40);
	member("DataInt64StructMapField", 41);
};



