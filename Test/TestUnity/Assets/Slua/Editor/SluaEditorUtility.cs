using System.Collections.Generic;
using System;
using System.Linq;
using System.Reflection;
#if !SLUA_STANDALONE
using UnityEngine;
using UnityEditor;
#endif
using System.IO;

namespace SLua
{

    public static class SluaEditorUtility
    {

#if !SLUA_STANDALONE
        [MenuItem("SLua/Setting")]
        public static void Open()
        {
            Selection.activeObject = InstanceOfSLuaSetting;
        }
#endif
        public static void ReBuildTypes()
        {
            SLuaSetting.Instance = InstanceOfSLuaSetting;
            Lua3rdMeta.Instance = InstanceOfLua3rdMeta;

            InstanceOfLua3rdMeta.typesWithAttribtues.Clear();
            Assembly assembly = null;
            foreach (var assem in AppDomain.CurrentDomain.GetAssemblies()) {
                if (assem.GetName().Name == "Assembly-CSharp") {
                    assembly = assem;
                    break;
                }
            }
            if (assembly != null) {
                var types = assembly.GetExportedTypes();
                foreach (var type in types) {
                    var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static);
                    foreach (var method in methods) {
                        if (method.IsDefined(typeof(Lua3rdDLL.LualibRegAttribute), false)) {
                            InstanceOfLua3rdMeta.typesWithAttribtues.Add(type.FullName);
                            break;
                        }
                    }
                }
            }
        }

        private static Lua3rdMeta InstanceOfLua3rdMeta
        {
            get
            {
#if !SLUA_STANDALONE
                if (_instance_lua3rd_meta == null) {
                    _instance_lua3rd_meta = Resources.Load<Lua3rdMeta>("lua3rdmeta");
                }

                if (_instance_lua3rd_meta == null) {
                    _instance_lua3rd_meta = ScriptableObject.CreateInstance<Lua3rdMeta>();
                    string path = "Assets/Slua/Meta/Resources";
                    if (!Directory.Exists(path)) {
                        Directory.CreateDirectory(path);
                    }
                    UnityEditor.AssetDatabase.CreateAsset(_instance_lua3rd_meta, Path.Combine(path, "lua3rdmeta.asset"));
                }

#endif
                return _instance_lua3rd_meta;
            }
        }
        private static SLuaSetting InstanceOfSLuaSetting
        {
            get
            {
#if !SLUA_STANDALONE
                if (_instance_slua_setting == null) {
                    _instance_slua_setting = Resources.Load<SLuaSetting>("setting");

                    if (_instance_slua_setting == null) {
                        _instance_slua_setting = SLuaSetting.CreateInstance<SLuaSetting>();
                        AssetDatabase.CreateAsset(_instance_slua_setting, "Assets/Slua/Meta/Resources/setting.asset");
                    }
                }
#endif
                return _instance_slua_setting;
            }
        }

        private static Lua3rdMeta _instance_lua3rd_meta = null;
        private static SLuaSetting _instance_slua_setting = null;
    }
}
