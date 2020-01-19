config(LegalGenericTypeList)
{
    type("ObjectPluginFactory_T");
	type("TickPluginFactory_T");
	type("StartupPluginFactory_T");

    type("System.Collections.Generic.List_T");
	type("System.Collections.Generic.Dictionary_TKey_TValue");
	type("System.Collections.Generic.HashSet_T");
	type("System.Collections.Generic.KeyValuePair_TKey_TValue");
	type("System.Collections.Generic.Queue_T");
};
config(LegalGenericMethodList)
{
    method("UnityEngine.GameObject.GetComponentsInChildren");
};
config(LegalParameterGenericTypeList)
{
	type("System.Collections.Generic.LinkedListNode_T");
	type("System.Collections.Generic.IEnumerable_T");
	type("StorySystem.IStoryValue_T");
	type("System.Action_T");
};
config(LegalExtensionList)
{
    type("Vector3Extension");
    type("DG.Tweening.TweenExtensions");
    type("DG.Tweening.TweenSettingsExtensions");
    type("DG.Tweening.ShortcutExtensions");
    type("UnityEngine.Playables.PlayableExtensions");
    type("UniGifExtension");
};
config(LegalConvertionList)
{
    convertion("","");
};
config(IllegalTypeList)
{
    type("");
};
config(IllegalMethodList)
{
    method("","");
};
config(IllegalPropertyList)
{
    property("","");
};
config(IllegalFieldList)
{
    field("","");
};