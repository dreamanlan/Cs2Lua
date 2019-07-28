dontrequire("cs2luanetworkmessagepools")except("program","messagedefine__cs2luamessageenum2object");

filemerge("messagedefine")match("messagedefine__.*");

//nosignaturearg("Euler__.*");

addprologue("{0}{1}::{2}{3}", "UnityEngine.Debug.LogWarning(\"LogWarning_Object\", \"", $class, $member, " begin\")")match("__define_class");
addepilogue("{0}{1}::{2}{3}", "UnityEngine.Debug.LogWarning(\"LogWarning_Object\", \"", $class, $member, " end\")")match("__define_class");
