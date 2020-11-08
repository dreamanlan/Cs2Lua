using System.Collections.Generic;
using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
using System.IO;

namespace SLua
{

    public class Lua3rdMeta : ScriptableObject
    {
        /// <summary>
        ///Cache class types here those contain 3rd dll attribute.
        /// </summary>
        public List<string> typesWithAttribtues = new List<string>();

        void OnEnable()
        {
            this.hideFlags = HideFlags.NotEditable;
        }
        private static Lua3rdMeta _instance = null;
        public static Lua3rdMeta Instance
        {
            get {
                if (_instance == null) {
                    _instance = Resources.Load<Lua3rdMeta>("lua3rdmeta");
                }
                return _instance;
            }
            set {
                _instance = value;
            }
        }
    }
}
