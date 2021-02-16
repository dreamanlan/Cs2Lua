dontrequire("cs2luanetworkmessagepools")except("program","messagedefine__cs2luamessageenum2object");

filemerge("messagedefine")match("messagedefine__.*");

indexerbylualib("System.Collections.Generic.List_T", ".*", "System.Collections.Generic.List_T", "get_Item"){indexertype(1);};
indexerbylualib("System.Collections.Generic.List_T", ".*", "System.Collections.Generic.List_T", "set_Item"){indexertype(1);};
indexerbylualib("System.Collections.Generic.Dictionary_TKey_TValue", ".*", "System.Collections.Generic.Dictionary_TKey_TValue", "get_Item");
indexerbylualib("System.Collections.Generic.Dictionary_TKey_TValue", ".*", "System.Collections.Generic.Dictionary_TKey_TValue", "set_Item");
indexerbylualib("@@internal", ".*", "Cs2LuaList_T", "get_Item"){indexertype(1);};
indexerbylualib("@@internal", ".*", "Cs2LuaList_T", "set_Item"){indexertype(1);};
//indexerbylualib(".*", "Cs2LuaUiControllerManager\\\.allControllers", ".*", ".*");

addprologue("{0}{1}::{2}{3}", "Utility.Warn(\"", $class, $member, " begin\")")match("StartupFGUI");
addepilogue("{0}{1}::{2}{3}", "Utility.Warn(\"", $class, $member, " end\")")match("StartupFGUI");

addprologue("{0}{1}::{2}{3}", "Utility.Warn(\"", $class, $member, " begin\")")match("__define_class");
addepilogue("{0}{1}::{2}{3}", "Utility.Warn(\"", $class, $member, " end\")")match("__define_class");

checkparamtype
{
    "NPCShopController.ShowShopMainView";
    "NPCShopController.BagShowMainView";
    "StoryMingpianView.ShowMingpian";
};

objuseclassmethod(true);