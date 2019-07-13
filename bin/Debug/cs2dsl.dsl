dontrequire("cs2luanetworkmessagepools")except("program","messagedefine__cs2luamessageenum2object");

filemerge("messagedefine")match("messagedefine__.*");

nosignaturearg("Euler__.*");

addprologue("{0}{1}::{2}{3}", "CsLibrary.LogSystem.Warn(\"", $class, $member, " begin\")")match("StartupFGUI");
addepilogue("{0}{1}::{2}{3}", "CsLibrary.LogSystem.Warn(\"", $class, $member, " end\")")match("StartupFGUI");

addprologue("{0}{1}::{2}{3}", "CsLibrary.LogSystem.Warn(\"", $class, $member, " begin\")")match("__define_class");
addepilogue("{0}{1}::{2}{3}", "CsLibrary.LogSystem.Warn(\"", $class, $member, " end\")")match("__define_class");
