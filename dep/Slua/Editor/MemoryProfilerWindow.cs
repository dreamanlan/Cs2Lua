using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UnityEditor;

namespace SLua{
	public class MemoryProfilerWindow : EditorWindow {
		[MenuItem("SLua/MemoryProfiler")]
		public static MemoryProfilerWindow Open(){
			var window =  EditorWindow.CreateInstance<MemoryProfilerWindow>();
			window.Focus();
			window.Show();
            return window;
		}

		private List<string[]> _destroyedObjectNames = new List<string[]>();
        private HashSet<string> _lastAllObjectNames = new HashSet<string>();
        private List<string[]> _addedObjectNames = new List<string[]>();

        private Vector2 _scrollPos0;
        private Vector2 _scrollPos1;
		private Vector2 _scrollPos2;

        private bool _includeLuaSnapshot = false;
        private bool _showDelegateStacks = false;
		private bool _showDestroyedObject = false;
		private bool _showAllObject = false;
		private int _cachedDelegateCount = 0;
        private List<string[]> _delegateStackTraces = new List<string[]>();

        void OnGUI()
        {
            float w = this.maxSize.x;
            float h = this.maxSize.y;
            var svrGo = GameObject.FindObjectOfType<LuaSvrGameObject>();
			if(svrGo == null){
				GUILayout.Label("There is no LuaSvrGameObject in you scene. Run your game first");
				return;
			}
            _includeLuaSnapshot = GUILayout.Toggle(_includeLuaSnapshot, new GUIContent("include lua snapshot"));
			if(GUILayout.Button("Capture")){
				System.GC.Collect ();
				LuaDLL.lua_gc(svrGo.state.L, LuaGCOptions.LUA_GCCOLLECT, 0);
                if (_includeLuaSnapshot) {
                    CsLibrary.LogicModuleProxy.ScriptProxy.EvalLua("takesnapshot()");
                }
				var destroyedObjectNames = ObjectCache.GetAlreadyDestroyedObjectNames(svrGo.state.L);
				var allObjectNames = ObjectCache.GetAllManagedObjectNames(svrGo.state.L);
                _destroyedObjectNames.Clear();
                foreach (var names in destroyedObjectNames) {
                    var list = new List<string>();
                    for (int i = 0; i < names.Length; ++i) {
                        if (i == 0) {
                            list.Add(names[i]);
                        }
                        else {
                            var stack = names[i];
                            var lines = stack.Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
                            foreach (var line in lines) {
                                if (!line.Contains("SLua."))
                                    list.Add("\t" + line.Trim());
                            }
                        }
                    }
                    _destroyedObjectNames.Add(list.ToArray());
                }
                _addedObjectNames.Clear();
                foreach(var names in allObjectNames) {
                    if (!_lastAllObjectNames.Contains(names[0])) {
                        var list = new List<string>();
                        for (int i = 0; i < names.Length; ++i) {
                            if (i == 0) {
                                list.Add(names[i]);
                            }
                            else {
                                var stack = names[i];
                                var lines = stack.Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
                                foreach (var line in lines) {
                                    if (!line.Contains("SLua."))
                                        list.Add("\t" + line.Trim());
                                }
                            }
                        }
                        _addedObjectNames.Add(list.ToArray());
                    }
                }
                _lastAllObjectNames.Clear();
                if (null != allObjectNames) {
                    foreach (var names in allObjectNames) {
                        _lastAllObjectNames.Add(names[0]);
                    }
                }
                _cachedDelegateCount = LuaState.main.cachedDelegateCount;
                var delegateStackTraces = LuaState.main.GetCachedDelegateStackTraces();
                _delegateStackTraces.Clear();
                foreach(var st in delegateStackTraces) {
                    var list = new List<string>();
                    for (int i = 0; i < st.Length; ++i) {
                        if (i == 0) {
                            list.Add(st[i]);
                        }
                        else {
                            var stack = st[i];
                            var lines = stack.Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
                            foreach (var line in lines) {
                                if (!line.Contains("SLua."))
                                    list.Add("\t" + line.Trim());
                            }
                        }
                    }
                    _delegateStackTraces.Add(list.ToArray());
                }
            }

            if (GUILayout.Button("Copy")) {
                var sb = new StringBuilder();
                Export(line => { sb.AppendLine(line); });
                GUIUtility.systemCopyBuffer = sb.ToString();
            }
            if (GUILayout.Button("Save")) {
                string file = EditorUtility.SaveFilePanel("save result", string.Empty, "luasnapshot", "txt");
                if (!string.IsNullOrEmpty(file)) {
                    using (var sw = new StreamWriter(file)) {
                        Export(line => { sw.WriteLine(line); });
                        sw.Close();
                    }
                }
            }

            GUILayout.Label ("LuaDelegate count:" + _cachedDelegateCount);
            _showDelegateStacks = EditorGUILayout.Foldout(_showDelegateStacks, "Cached Delegate:" + _delegateStackTraces.Count);
            if (_showDelegateStacks) {
                _scrollPos0 = GUILayout.BeginScrollView(_scrollPos0, GUILayout.Width(w), GUILayout.Height(240));
                int ct = 0;
                foreach (var stacks in _delegateStackTraces) {
                    for (int i = 0; i < stacks.Length; ++i) {
                        GUILayout.Label(stacks[i]);
                    }
                    ++ct;
                    if (ct > 2000)
                        break;
                }
                GUILayout.EndScrollView();
            }
            _showDestroyedObject = EditorGUILayout.Foldout(_showDestroyedObject,"Already Destroyed Unity Object:"+_destroyedObjectNames.Count);
			if(_showDestroyedObject){
				_scrollPos1 = GUILayout.BeginScrollView(_scrollPos1, GUILayout.Width(w), GUILayout.Height(240));
                int ct = 0;
				foreach(var names in _destroyedObjectNames){
                    for (int i = 0; i < names.Length; ++i) {
                        GUILayout.Label(names[i]);
                    }
                    ++ct;
                    if (ct > 2000)
                        break;
				}
				GUILayout.EndScrollView();
			}

			_showAllObject = EditorGUILayout.Foldout(_showAllObject,"Added Managed C# Object:"+_addedObjectNames.Count);
			if(_showAllObject){
				_scrollPos2 = GUILayout.BeginScrollView(_scrollPos2, GUILayout.Width(w), GUILayout.Height(640));
                int ct = 0;
				foreach(var names in _addedObjectNames) {
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

        private void Export(MyAction<string> outputLine)
        {
            outputLine("cached delegates:" + _cachedDelegateCount);
            int ct = 0;
            int totalCt = _delegateStackTraces.Count;
            int delta = totalCt / 100 + (totalCt % 100 > 0 ? 1 : 0);
            foreach (var stacks in _delegateStackTraces) {
                for (int i = 0; i < stacks.Length; ++i) {
                    outputLine(stacks[i]);
                }
                ++ct;
                if (ct % delta == 0)
                    EditorUtility.DisplayProgressBar("cached delegates", string.Format("{0}/{1}", ct, totalCt), ct * 1.0f / totalCt);
            }
            outputLine("destoryed objects:" + _destroyedObjectNames.Count);
            ct = 0;
            totalCt = _destroyedObjectNames.Count;
            delta = totalCt / 100 + (totalCt % 100 > 0 ? 1 : 0);
            foreach (var names in _destroyedObjectNames) {
                for (int i = 0; i < names.Length; ++i) {
                    outputLine(names[i]);
                }
                ++ct;
                if (ct % delta == 0)
                    EditorUtility.DisplayProgressBar("destroyed objects", string.Format("{0}/{1}", ct, totalCt), ct * 1.0f / totalCt);
            }
            outputLine("added objects:" + _addedObjectNames.Count);
            ct = 0;
            totalCt = _addedObjectNames.Count;
            delta = totalCt / 100 + (totalCt % 100 > 0 ? 1 : 0);
            foreach (var names in _addedObjectNames) {
                for (int i = 0; i < names.Length; ++i) {
                    outputLine(names[i]);
                }
                ++ct;
                if (ct % delta == 0)
                    EditorUtility.DisplayProgressBar("added objects", string.Format("{0}/{1}", ct, totalCt), ct * 1.0f / totalCt);
            }
            EditorUtility.ClearProgressBar();
        }
	}
}
