﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UnityEditor;

namespace SLua
{
    public class MemoryProfilerWindow : EditorWindow
    {
        [MenuItem("SLua/MemoryProfiler")]
        public static MemoryProfilerWindow Open()
        {
            var window = EditorWindow.CreateInstance<MemoryProfilerWindow>();
            window.Focus();
            window.Show();
            return window;
        }

        private Vector2 _scrollPos;
        private Vector2 _scrollPos0;
        private Vector2 _scrollPos1;
        private Vector2 _scrollPos2;

        private bool _gcBeforeCapture = false;
        private bool _includeLuaSnapshot = false;
        private bool _showDebugStringMaps = false;
        private bool _showDelegateStacks = false;
        private bool _showDestroyedObject = false;
        private bool _showAllObject = false;

        void OnGUI()
        {
            float w = this.maxSize.x;
            float h = this.maxSize.y;
            var svrGo = GameObject.FindObjectOfType<LuaSvrGameObject>();
            if (svrGo == null) {
                GUILayout.Label("There is no LuaSvrGameObject in you scene. Run your game first");
                return;
            }

            LuaSnapshot.Prepare();
            _gcBeforeCapture = GUILayout.Toggle(_gcBeforeCapture, new GUIContent("gc before capture"));
            _includeLuaSnapshot = GUILayout.Toggle(_includeLuaSnapshot, new GUIContent("include lua snapshot"));
            if (GUILayout.Button("Capture")) {
                LuaSnapshot.Capture(_gcBeforeCapture, _includeLuaSnapshot ? (System.Action)(()=> { }) : (System.Action)null);
            }

            if (GUILayout.Button("Copy")) {
                var sb = new StringBuilder();
                LuaSnapshot.Export(line => { sb.AppendLine(line); }, (title, info, progress) => { EditorUtility.DisplayProgressBar(title, info, progress); });
                EditorUtility.ClearProgressBar();
                GUIUtility.systemCopyBuffer = sb.ToString();
            }
            if (GUILayout.Button("Save")) {
                string file = EditorUtility.SaveFilePanel("save result", string.Empty, "luasnapshot", "txt");
                if (!string.IsNullOrEmpty(file)) {
                    using (var sw = new StreamWriter(file)) {
                        LuaSnapshot.Export(line => { sw.WriteLine(line); }, (title, info, progress) => { EditorUtility.DisplayProgressBar(title, info, progress); });
                        EditorUtility.ClearProgressBar();
                        sw.Close();
                    }
                }
            }

            if (null != LuaSnapshot.Obj2Ints) {
                int ct0 = 0;
                foreach (var dict in LuaSnapshot.Obj2Ints) {
                    ct0 += dict.Count;
                }
                GUILayout.Label("Object2Int count:" + ct0);
            }
            if (null != LuaSnapshot.Int2Objs) {
                int ct0 = 0;
                foreach (var dict in LuaSnapshot.Int2Objs) {
                    ct0 += dict.Count;
                }
                GUILayout.Label("Int2Object count:" + ct0);
            }

            _showDebugStringMaps = EditorGUILayout.Foldout(_showDebugStringMaps, "Lua Script Count:" + LuaState.DebugStringMap.Count);
            if (_showDebugStringMaps) {
                _scrollPos = GUILayout.BeginScrollView(_scrollPos, GUILayout.Width(w), GUILayout.Height(240));
                int ct = 0;
                foreach (var pair in LuaState.DebugStringMap) {
                    GUILayout.Label(pair.Key + " => " + pair.Value);
                    ++ct;
                    if (ct > 2000)
                        break;
                }
                GUILayout.EndScrollView();
            }
            GUILayout.Label("LuaDelegate count:" + LuaSnapshot.CachedDelegateCount);
            _showDelegateStacks = EditorGUILayout.Foldout(_showDelegateStacks, "Cached Delegate:" + LuaSnapshot.DelegateStackTraces.Count);
            if (_showDelegateStacks) {
                _scrollPos0 = GUILayout.BeginScrollView(_scrollPos0, GUILayout.Width(w), GUILayout.Height(240));
                int ct = 0;
                foreach (var stacks in LuaSnapshot.DelegateStackTraces) {
                    for (int i = 0; i < stacks.Length; ++i) {
                        GUILayout.Label(stacks[i]);
                    }
                    ++ct;
                    if (ct > 2000)
                        break;
                }
                GUILayout.EndScrollView();
            }
            _showDestroyedObject = EditorGUILayout.Foldout(_showDestroyedObject, "Already Destroyed Unity Object:" + LuaSnapshot.DestroyedObjectNames.Count);
            if (_showDestroyedObject) {
                _scrollPos1 = GUILayout.BeginScrollView(_scrollPos1, GUILayout.Width(w), GUILayout.Height(240));
                int ct = 0;
                foreach (var names in LuaSnapshot.DestroyedObjectNames) {
                    for (int i = 0; i < names.Length; ++i) {
                        GUILayout.Label(names[i]);
                    }
                    ++ct;
                    if (ct > 2000)
                        break;
                }
                GUILayout.EndScrollView();
            }

            _showAllObject = EditorGUILayout.Foldout(_showAllObject, "Added Managed C# Object:" + LuaSnapshot.AddedObjectNames.Count);
            if (_showAllObject) {
                _scrollPos2 = GUILayout.BeginScrollView(_scrollPos2, GUILayout.Width(w), GUILayout.Height(640));
                int ct = 0;
                foreach (var names in LuaSnapshot.AddedObjectNames) {
                    for (int i = 0; i < names.Length; ++i) {
                        GUILayout.Label(names[i]);
                    }
                    ++ct;
                    if (ct > 2000)
                        break;
                }
                GUILayout.EndScrollView();
            }
        }
    }
}
