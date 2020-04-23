dontrequire("cs2luanetworkmessagepools")except("program","messagedefine__cs2luamessageenum2object");

filemerge("messagedefine")match("messagedefine__.*");

//nosignaturearg("Euler__.*");
//replacesignaturearg("Instantiate__GameObject","Instantiate__Object");
indexerbylualib("System.Collections.Generic.List_T", "FairyGUI\.TextField\.LineInfo", ".*", ".*", "null", "System.Collections.Generic.List_T", "get_Item"){indexertype(2);};
indexerbylualib("System.Collections.Generic.List_T", "FairyGUI\.TextField\.LineInfo", ".*", ".*", "null", "System.Collections.Generic.List_T", "set_Item"){indexertype(2);};
indexerbylualib("System.Collections.Generic.List_T", ".*", ".*", ".*", "null", "System.Collections.Generic.List_T", "get_Item"){indexertype(1);};
indexerbylualib("System.Collections.Generic.List_T", ".*", ".*", ".*", "null", "System.Collections.Generic.List_T", "set_Item"){indexertype(1);};
indexerbylualib("System.Collections.Generic.Dictionary_TKey_TValue", ".*", ".*", ".*", "null", "System.Collections.Generic.Dictionary_TKey_TValue", "get_Item");
indexerbylualib("System.Collections.Generic.Dictionary_TKey_TValue", ".*", ".*", ".*", "null", "System.Collections.Generic.Dictionary_TKey_TValue", "set_Item");
indexerbylualib("@@internal", ".*", ".*", ".*", "null", "Cs2LuaList_T", "get_Item"){indexertype(1);};
indexerbylualib("@@internal", ".*", ".*", ".*", "null", "Cs2LuaList_T", "set_Item"){indexertype(1);};
indexerbylualib("@@internal", ".*", ".*", ".*", "null", "Cs2LuaIntDictionary_TValue", "get_Item"){indexertype(1);};
indexerbylualib("@@internal", ".*", ".*", ".*", "null", "Cs2LuaIntDictionary_TValue", "set_Item"){indexertype(1);};
//indexerbylualib(".*", ".*", ".*", "Cs2LuaUiControllerManager\\\.allControllers", "null", ".*", ".*");

addprologue("{0}{1}::{2}{3}", "Utility.Warn(\"", $class, $member, " begin\")")match("StartupFGUI");
addepilogue("{0}{1}::{2}{3}", "Utility.Warn(\"", $class, $member, " end\")")match("StartupFGUI");

addprologue("{0}{1}::{2}{3}", "Utility.Warn(\"", $class, $member, " begin\")")match("__define_class");
addepilogue("{0}{1}::{2}{3}", "Utility.Warn(\"", $class, $member, " end\")")match("__define_class");
