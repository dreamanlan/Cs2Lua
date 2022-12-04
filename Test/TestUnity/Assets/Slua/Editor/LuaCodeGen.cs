// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
#define ENABLE_USE_INHERIT_INTERFACE

namespace SLua
{
    using UnityEngine;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System;
    using System.Reflection;
    using UnityEditor;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Runtime.CompilerServices;

    public class LuaCodeGen : MonoBehaviour
    {
        static public string GenPath => SLuaSetting.Instance.UnityEngineGeneratePath;
        public delegate void ExportGenericDelegate(Type t, string ns);

        static bool IsCompiling
        {
            get {
                if (EditorApplication.isCompiling) {
                    Debug.Log("Unity Editor is compiling, please wait.");
                }
                return EditorApplication.isCompiling;
            }
        }

        [InitializeOnLoad]
        public class Startup
        {
            static bool isPlaying = false;
            static Startup()
            {
                EditorApplication.update += Update;
                // use this delegation to ensure dispose luavm at last
                EditorApplication.playmodeStateChanged += () => {

                    if (isPlaying == true && EditorApplication.isPlaying == false) {
                        if (LuaState.main != null)
                            LuaState.main.Dispose();
                    }

                    isPlaying = EditorApplication.isPlaying;
                    SLuaSetting.IsEditor = true;
                    SLuaSetting.IsPlaying = EditorApplication.isPlaying;
                };
            }


            static void Update()
            {
                EditorApplication.update -= Update;
                SluaEditorUtility.ReBuildTypes();

                /*
                // Remind user to generate lua interface code
			    var remindGenerate = !EditorPrefs.HasKey("SLUA_REMIND_GENERTE_LUA_INTERFACE") || EditorPrefs.GetBool("SLUA_REMIND_GENERTE_LUA_INTERFACE");
				bool ok = System.IO.Directory.Exists(GenPath+"Unity");
				if (!ok && remindGenerate)
				{
				    if (EditorUtility.DisplayDialog("Slua", "Not found lua interface for Unity, generate it now?", "Generate", "No"))
				    {
				        GenerateAll();
				    }
				    else
				    {
				        if (!EditorUtility.DisplayDialog("Slua", "Remind you next time when no lua interface found for Unity?", "OK",
				            "Don't remind me next time!"))
				        {
                            EditorPrefs.SetBool("SLUA_REMIND_GENERTE_LUA_INTERFACE", false);
				        }
				        else
				        {
				            
                            EditorPrefs.SetBool("SLUA_REMIND_GENERTE_LUA_INTERFACE", true);
				        }
				        
				    }
				}
                */
            }
        }


#if UNITY_2017_2_OR_NEWER
        /*
        public static string[] unityModule = new string[] { "UnityEngine","UnityEngine.CoreModule","UnityEngine.UIModule","UnityEngine.TextRenderingModule","UnityEngine.TextRenderingModule",
                "UnityEngine.UnityWebRequestWWWModule","UnityEngine.Physics2DModule","UnityEngine.AnimationModule","UnityEngine.TextRenderingModule","UnityEngine.IMGUIModule","UnityEngine.UnityWebRequestModule",
            "UnityEngine.PhysicsModule", "UnityEngine.UI" };
        */
        public static string[] unityModule = new string[] {
            "UnityEngine",
            "UnityEngine.CoreModule",
            "UnityEngine.UIModule",
            "UnityEngine.TextRenderingModule",
            "UnityEngine.AnimationModule",
            "UnityEngine.PhysicsModule",
            "UnityEngine.ImageConversionModule",
            "UnityEngine.ParticleSystemModule",
            "UnityEngine.VideoModule",
            "UnityEngine.AudioModule",
        };
#else
        public static string[] unityModule = null;
#endif

        static bool filterType(Type t, HashSet<string> useList, List<string> noUseList)
        {
            if (t.IsDefined(typeof(CompilerGeneratedAttribute), false)) {
                Debug.Log(t.Name + " is filtered out");
                return false;
            }
            if (t.IsDefined(typeof(SLua.DoNotToLuaAttribute), false)) {
                Debug.Log(t.Name + " is filtered out");
                return false;
            }

            string fullName = t.FullName;
            if (useList.Count > 0) {
                if (!useList.Contains(fullName)) {
                    // check type not in nouselist
                    if (noUseList.Count == 0) {
                        return false;
                    }
                    else {
                        foreach (string str in noUseList) {
                            if (fullName.Contains(str)) {
                                return false;
                            }
                        }
                    }
                }
            }
            else {
                foreach (string str in noUseList) {
                    if (fullName.Contains(str)) {
                        return false;
                    }
                }
            }
            return true;
        }

        static void GenerateModule(string[] target = null)
        {
#if UNITY_2017_2_OR_NEWER
            if (target != null) {
                GenerateFor(target, "Unity/", 0, "BindUnity");
            }
            else {
                ModuleSelector wnd = EditorWindow.GetWindow<ModuleSelector>("ModuleSelector");
                wnd.onExport = (string[] module) => {
                    GenerateFor(module, "Unity/", 0, "BindUnity");
                };
            }
#else
            GenerateFor("UnityEngine", "Unity/", 0, "BindUnity");
#endif
        }

        [MenuItem("SLua/Clear")]
        static public void ClearALL()
        {
            clear(new string[] { Path.GetDirectoryName(GenPath) });
            AssetDatabase.Refresh();
            Debug.Log("Clear all complete.");
        }
        [MenuItem("SLua/Make")]
        static public void GenerateAll()
        {
            if (!Directory.Exists(GenPath)) {
                Directory.CreateDirectory(GenPath);
            }
            GenerateModule(unityModule);
            GenerateUI();
            GenerateAds();
            Custom();
            Generate3rdDll();
            AssetDatabase.Refresh();
        }

        static public void GenerateUI()
        {
            GenerateFor("UnityEngine.UI", "Unity/", 1, "BindUnityUI");
        }
        static public void GenerateAds()
        {
            GenerateFor("UnityEngine.Advertisements", "Unity/", 2, "BindUnityAds");
        }
        static List<Type> GetExportsType(string[] asemblyNames, string genAtPath)
        {

            List<Type> exports = new List<Type>();

            foreach (string asemblyName in asemblyNames) {
                Assembly assembly;
                try { assembly = Assembly.Load(asemblyName); } catch (Exception) { continue; }

                Type[] types = assembly.GetExportedTypes();

                HashSet<string> useList = CustomExport.OnGetUseList();
                List<string> noUseList = CustomExport.OnGetNoUseList();

                string path = GenPath + genAtPath;
                foreach (Type t in types) {
                    if (filterType(t, useList, noUseList) && Generate(t, path))
                        exports.Add(t);
                }
                Debug.Log("Generate interface finished: " + asemblyName);
            }
            return exports;
        }

        static public void GenerateFor(string[] asemblyNames, string genAtPath, int genOrder, string bindMethod)
        {
            if (IsCompiling) {
                return;
            }

            List<Type> exports = GetExportsType(asemblyNames, genAtPath);
            string path = GenPath + genAtPath;
            GenerateBind(exports, bindMethod, genOrder, path);
        }

        static public void GenerateFor(string asemblyName, string genAtPath, int genOrder, string bindMethod)
        {
            if (IsCompiling) {
                return;
            }

            List<Type> exports = GetExportsType(new string[] { asemblyName }, genAtPath);
            string path = GenPath + genAtPath;
            GenerateBind(exports, bindMethod, genOrder, path);
        }

        static String FixPathName(string path)
        {
            if (path.EndsWith("\\") || path.EndsWith("/")) {
                return path.Substring(0, path.Length - 1);
            }
            return path;
        }

        static public void Custom()
        {
            if (IsCompiling) {
                return;
            }

            List<Type> exports = new List<Type>();
            string path = GenPath + "Custom/";

            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }

            ExportGenericDelegate fun = (Type t, string ns) => {
                if (Generate(t, ns, path))
                    exports.Add(t);
            };

            HashSet<string> namespaces = CustomExport.OnAddCustomNamespace();

            Assembly assembly;
            Type[] types;

            try {
                // export plugin-dll
                assembly = Assembly.Load("Assembly-CSharp-firstpass");
                types = assembly.GetExportedTypes();
                foreach (Type t in types) {
                    if (t.IsDefined(typeof(CustomLuaClassAttribute), false) || namespaces.Contains(t.Namespace)) {
                        fun(t, null);
                    }
                }
            }
            catch (Exception) { }

            // export self-dll
            assembly = Assembly.Load("Assembly-CSharp");
            types = assembly.GetExportedTypes();
            foreach (Type t in types) {
                if (t.IsDefined(typeof(CustomLuaClassAttribute), false) || namespaces.Contains(t.Namespace)) {
                    fun(t, null);
                }
            }

            CustomExport.OnAddCustomClass(fun);
            GenerateBind(exports, "BindCustom", 3, path);

            Debug.Log("Generate custom interface finished");
        }

        static public List<object> InvokeEditorMethod<T>(string methodName, ref object[] parameters)
        {
            List<object> aReturn = new List<object>();
            System.Reflection.Assembly editorAssembly = System.Reflection.Assembly.Load("Assembly-CSharp-Editor");
            Type[] editorTypes = editorAssembly.GetExportedTypes();
            foreach (Type t in editorTypes) {
                if (typeof(T).IsAssignableFrom(t)) {
                    System.Reflection.MethodInfo method = t.GetMethod(methodName, System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
                    if (method != null) {
                        object cRes = method.Invoke(null, parameters);
                        if (null != cRes) {
                            aReturn.Add(cRes);
                        }
                    }
                }
            }

            return aReturn;
        }

        static public List<object> GetEditorField<T>(string strFieldName)
        {
            List<object> aReturn = new List<object>();
            System.Reflection.Assembly cEditorAssembly = System.Reflection.Assembly.Load("Assembly-CSharp-Editor");
            Type[] aEditorTypes = cEditorAssembly.GetExportedTypes();
            foreach (Type t in aEditorTypes) {
                if (typeof(T).IsAssignableFrom(t)) {
                    FieldInfo cField = t.GetField(strFieldName, BindingFlags.Static | BindingFlags.Public);
                    if (null != cField) {
                        object cValue = cField.GetValue(t);
                        if (null != cValue) {
                            aReturn.Add(cValue);
                        }
                    }
                }
            }

            return aReturn;
        }

        static public void Generate3rdDll()
        {
            if (IsCompiling) {
                return;
            }

            List<Type> cust = new List<Type>();
            List<string> assemblyList = new List<string>();
            CustomExport.OnAddCustomAssembly(ref assemblyList);

            HashSet<string> useList = CustomExport.OnGetCustomAssemblyUseList();
            List<string> noUseList = CustomExport.OnGetCustomAssemblyNoUseList();

            foreach (string assemblyItem in assemblyList) {
                Assembly assembly = Assembly.Load(assemblyItem);
                Type[] types = assembly.GetExportedTypes();
                foreach (Type t in types) {
                    cust.Add(t);
                }
            }
            if (cust.Count > 0) {
                List<Type> exports = new List<Type>();
                string path = GenPath + "Dll/";
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path);
                }
                foreach (Type t in cust) {
                    if (filterType(t, useList, noUseList) && Generate(t, path))
                        exports.Add(t);
                }
                GenerateBind(exports, "BindDll", 2, path);
                Debug.Log("Generate 3rdDll interface finished");
            }
        }

        static void clear(string[] paths)
        {
            try {
                foreach (string path in paths) {
                    System.IO.Directory.Delete(path, true);
                }
            }
            catch {

            }
        }

        static bool Generate(Type t, string path)
        {
            return Generate(t, null, path);
        }

        static bool Generate(Type t, string ns, string path)
        {
#if ENABLE_USE_INHERIT_INTERFACE
            if (t.IsInterface && null != t.Namespace && (t.Namespace.StartsWith("System") || t.Namespace.StartsWith("UnityEngine"))) {
                return false;
            }
#else
            if (t.IsInterface) {
                return false;
            }
#endif

            CodeGenerator cg = new CodeGenerator();
            cg.givenNamespace = ns;
            cg.path = path;
            return cg.Generate(t);
        }

        static void GenerateBind(List<Type> list, string name, int order, string path)
        {
            CodeGenerator cg = new CodeGenerator();
            cg.path = path;
            cg.GenerateBind(list, name, order);
        }

    }

    class CodeGenerator
    {
        static List<string> memberFilter = new List<string>
        {
            "AnimationClip.averageDuration",
            "AnimationClip.averageAngularSpeed",
            "AnimationClip.averageSpeed",
            "AnimationClip.apparentSpeed",
            "AnimationClip.isLooping",
            "AnimationClip.isAnimatorMotion",
            "AnimationClip.isHumanMotion",
            "AnimatorOverrideController.PerformOverrideClipListCleanup",
            "Caching.SetNoBackupFlag",
            "Caching.ResetNoBackupFlag",
            "Light.areaSize",
            "Security.GetChainOfTrustValue",
            "Texture2D.alphaIsTransparency",
            "WWW.movie",
            "WebCamTexture.MarkNonReadable",
            "WebCamTexture.isReadable",
            // i don't know why below 2 functions missed in iOS platform
            "*.OnRebuildRequested",
            // il2cpp not exixts
            "Application.ExternalEval",
            "GameObject.networkView",
            "Component.networkView",
            // unity5
            "AnimatorControllerParameter.name",
            "Input.IsJoystickPreconfigured",
            "Resources.LoadAssetAtPath",
#if UNITY_4_6
			"Motion.ValidateIfRetargetable",
			"Motion.averageDuration",
			"Motion.averageAngularSpeed",
			"Motion.averageSpeed",
			"Motion.apparentSpeed",
			"Motion.isLooping",
			"Motion.isAnimatorMotion",
			"Motion.isHumanMotion",
#endif

			"Light.lightmappingMode",
            "MonoBehaviour.runInEditMode",
            "MonoBehaviour.useGUILayout",
            "PlayableGraph.CreateScriptPlayable",
        };

        static void FilterSpecMethods(out Dictionary<Type, List<MethodInfo>> dic, out Dictionary<Type, Type> overloadedClass)
        {
            dic = new Dictionary<Type, List<MethodInfo>>();
            overloadedClass = new Dictionary<Type, Type>();
            List<string> asems;
            CustomExport.OnGetAssemblyToGenerateExtensionMethod(out asems);

            foreach (string assstr in asems) {
                Assembly assembly = Assembly.Load(assstr);
                var types = assembly.GetExportedTypes();
                foreach (Type type in types) {
                    if (type.IsSealed && !type.IsGenericType && !type.IsNested) {
                        BindingFlags bindingFlags = BindingFlags.Static | BindingFlags.Public;
                        if (null == type.BaseType || !type.BaseType.IsGenericType) {
                            bindingFlags |= BindingFlags.DeclaredOnly;
                        }
                        MethodInfo[] methods = type.GetMethods(bindingFlags);
                        foreach (MethodInfo _method in methods) {
                            MethodInfo method = tryFixGenericMethod(_method);
                            if (IsExtensionMethod(method)) {
                                Type extendedType = method.GetParameters()[0].ParameterType;
                                if (!dic.ContainsKey(extendedType)) {
                                    dic.Add(extendedType, new List<MethodInfo>());
                                }
                                dic[extendedType].Add(method);
                            }
                        }
                    }


                    if (type.IsDefined(typeof(OverloadLuaClassAttribute), false)) {
                        OverloadLuaClassAttribute olc = type.GetCustomAttributes(typeof(OverloadLuaClassAttribute), false)[0] as OverloadLuaClassAttribute;
                        if (olc != null) {
                            if (overloadedClass.ContainsKey(olc.targetType))
                                throw new Exception("Can't overload class more than once");
                            overloadedClass.Add(olc.targetType, type);
                        }
                    }
                }
            }
        }

        static bool IsExtensionMethod(MethodBase method)
        {
            return method.IsDefined(typeof(System.Runtime.CompilerServices.ExtensionAttribute), false);
        }

        static Dictionary<System.Type, List<MethodInfo>> extensionMethods;
        static Dictionary<Type, Type> overloadedClass;

        static CodeGenerator()
        {
            try {
                FilterSpecMethods(out extensionMethods, out overloadedClass);
            }
            catch (Exception ex) {
                UnityEngine.Debug.Log(string.Format("{0}\n{1}", ex.Message, ex.StackTrace));
            }
        }

        HashSet<string> funcname = new HashSet<string>();
        Dictionary<string, bool> directfunc = new Dictionary<string, bool>();

        public string givenNamespace;
        public string path;
        public bool includeExtension = SLuaSetting.Instance.exportExtensionMethod;
        public EOL eol = SLuaSetting.Instance.eol;

        class PropPair
        {
            public string get = "null";
            public string set = "null";
            public bool isInstance = true;
        }
        Dictionary<string, PropPair> propname = new Dictionary<string, PropPair>();

        int indent = 0;

        public void GenerateBind(List<Type> list, string name, int order)
        {
            HashSet<Type> exported = new HashSet<Type>();
            string f = System.IO.Path.Combine(path, name + ".cs");
            using (StreamWriter file = new StreamWriter(f, false, Encoding.UTF8)) {
                file.NewLine = NewLine;
                Write(file, "using System;");
                Write(file, "using System.Collections.Generic;");
                if (name == "BindUnity") {
                    Write(file, "[assembly: UnityEngine.Scripting.Preserve]");
                }
                Write(file, "namespace SLua {");
                Write(file, "[LuaBinder({0})]", order);
                Write(file, "public class {0} {{", name);
                Write(file, "public static Action<IntPtr>[] GetBindList() {");
                Write(file, "Action<IntPtr>[] list= {");
                foreach (Type t in list) {
                    WriteBindType(file, t, list, exported);
                }
                Write(file, "};");
                Write(file, "return list;");
                Write(file, "}");
                Write(file, "}");
                Write(file, "}");
                file.Close();
            }
        }

        void WriteBindType(StreamWriter file, Type t, List<Type> exported, HashSet<Type> binded)
        {
            if (t == null || binded.Contains(t) || !exported.Contains(t))
                return;

            WriteBindType(file, t.BaseType, exported, binded);
            Write(file, "{0}.reg,", ExportName(t), binded);
            binded.Add(t);
        }

        public string DelegateExportFilename(string path, Type t)
        {
            string f;
            if (t.IsGenericType) {
                f = path + string.Format("Lua{0}_{1}.cs", _Name(GenericBaseName(t)), _Name(GenericName(t)));
            }
            else {
                f = path + "LuaDelegate_" + _Name(t.FullName) + ".cs";
            }
            return f;
        }

        public bool Generate(Type t)
        {
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }

            if (!t.IsGenericTypeDefinition && (!IsObsolete(t) && t != typeof(YieldInstruction) && t != typeof(Coroutine))
                || (t.BaseType != null && t.BaseType == typeof(System.MulticastDelegate))) {

                if (t.IsNested && t.DeclaringType.IsPublic == false)
                    return false;

                if (t.IsEnum) {
                    using (StreamWriter file = Begin(t)) {
                        WriteHead(t, file);
                        RegEnumFunction(t, file);
                        End(file);
                    }
                }
                else if (t.BaseType == typeof(System.MulticastDelegate)) {
                    if (t.ContainsGenericParameters)
                        return false;

                    string f = DelegateExportFilename(path, t);

                    using (StreamWriter file = new StreamWriter(f, false, Encoding.UTF8)) {
                        file.NewLine = NewLine;
                        WriteDelegate(t, file);
                        file.Close();
                    }
                    return false;
                }
                else {
                    funcname.Clear();
                    propname.Clear();
                    directfunc.Clear();

                    using (StreamWriter file = Begin(t)) {
                        WriteHead(t, file);
                        WriteConstructor(t, file);
                        WriteFunction(t, file, false);
                        WriteFunction(t, file, true);
                        WriteField(t, file);
                        RegFunction(t, file);
                        End(file);
                    }

                    if (t.BaseType != null && t.BaseType.Name.Contains("UnityEvent`")) {
                        string basename = "LuaUnityEvent_" + _Name(GenericName(t.BaseType)) + ".cs";
                        string f = path + basename;
                        string checkf = LuaCodeGen.GenPath + "Unity/" + basename;
                        if (!File.Exists(checkf)) // if had exported
                        {
                            using (var file = new StreamWriter(f, false, Encoding.UTF8)) {
                                file.NewLine = NewLine;
                                WriteEvent(t, file);
                                file.Close();
                            }
                        }
                    }
                }

                return true;
            }
            return false;
        }


        void WriteDelegate(Type t, StreamWriter file)
        {
            string temp = @"
using System;
using System.Collections.Generic;

namespace SLua
{
    public partial class LuaDelegation : LuaObject
    {

        static internal int checkDelegate(IntPtr l,int p,out $FN ua) {
            int op = extractFunction(l,p);
			if(LuaDLL.lua_isnil(l,p)) {
				ua=null;
				return op;
			}
            else if (LuaDLL.lua_isuserdata(l, p)==1)
            {
                ua = ($FN)checkObj(l, p);
                return op;
            }
            if(LuaDLL.lua_isnil(l,-1)) {
				ua=null;
				return op;
			}
            LuaDelegate ld;
            checkType(l, -1, out ld);
			LuaDLL.lua_pop(l,1);
            if(ld.d!=null)
            {
                ua = ($FN)ld.d;
                return op;
            }
			
			l = LuaState.get(l).L;
            ua = ($ARGS) =>
            {
                int error = pushTry(l);
";

            temp = temp.Replace("$TN", t.Name);
            temp = temp.Replace("$FN", SimpleType(t));
            MethodInfo mi = t.GetMethod("Invoke");
            temp = temp.Replace("$ARGS", ArgsList(mi));
            Write(file, temp);

            this.indent = 4;

            var pars = mi.GetParameters();
            for (int n = 0; n < pars.Length; n++) {
                ParameterInfo p = pars[n];
                var pt = p.ParameterType;
                if (pt.IsByRef)
                    pt = pt.GetElementType();
                if (p.ParameterType.IsByRef && p.IsOut) {
                    Write(file, "LuaDLL.lua_pushnil(l);");
                }
                else if (pt.Name == "BoxedValue") {
                    Write(file, "pushValue(l, a{0}.GetObject());", n + 1);
                }
                else {
                    Write(file, "pushValue(l, a{0});", n + 1);
                }
            }

            Write(file, "ld.pcall({0}, error);", mi.GetParameters().Length);

            int offset = 0;
            if (mi.ReturnType != typeof(void)) {
                offset = 1;
                WriteValueCheck(file, mi.ReturnType, offset, "ret", "error+");
            }

            for (int n = 0; n < pars.Length; n++) {
                ParameterInfo p = pars[n];
                if (p.ParameterType.IsByRef && p.IsOut) {
                    ++offset;
                    string a = string.Format("a{0}", n + 1);
                    WriteCheckType(file, p.ParameterType, offset, a, "error+");
                }
                else if (p.ParameterType.IsByRef) {
                    ++offset;
                    string a = string.Format("a{0}", n + 1);
                    WriteCheckType(file, p.ParameterType, offset, a, "error+");
                }
            }

            Write(file, "LuaDLL.lua_settop(l, error-1);");
            if (mi.ReturnType != typeof(void))
                Write(file, "return ret;");

            Write(file, "};");
            Write(file, "ld.d=ua;");
            Write(file, "return op;");
            Write(file, "}");
            Write(file, "}");
            Write(file, "}");
        }

        string ArgsList(MethodInfo m)
        {
            string str = "";
            ParameterInfo[] pars = m.GetParameters();
            for (int n = 0; n < pars.Length; n++) {
                string t = SimpleType(pars[n].ParameterType);

                ParameterInfo p = pars[n];
                if (p.ParameterType.IsByRef) {
                    if (p.IsOut) {
                        str += string.Format("out {0} a{1}", t, n + 1);
                    }
                    else if (p.IsIn) {
                        str += string.Format("in {0} a{1}", t, n + 1);
                    }
                    else {
                        str += string.Format("ref {0} a{1}", t, n + 1);
                    }
                }
                else {
                    str += string.Format("{0} a{1}", t, n + 1);
                }

                if (n < pars.Length - 1)
                    str += ",";
            }
            return str;
        }

        void tryMake(Type t)
        {

            if (t.BaseType == typeof(System.MulticastDelegate)) {
                CodeGenerator cg = new CodeGenerator();
                if (File.Exists(cg.DelegateExportFilename(LuaCodeGen.GenPath + "Unity/", t)))
                    return;
                cg.path = this.path;
                cg.Generate(t);
            }
        }

        void WriteEvent(Type t, StreamWriter file)
        {
            string temp = @"
using System;
using System.Collections.Generic;
using SLua;

namespace SLua
{
    public class LuaUnityEvent_$CLS : LuaObject
    {

        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int AddListener(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<$GN> self = checkSelf<UnityEngine.Events.UnityEvent<$GN>>(l);
                UnityEngine.Events.UnityAction<$GN> a1;
                checkType(l, 2, out a1);
                self.AddListener(a1);
				pushValue(l,true);
                return 1;
            }
            catch (Exception e)
            {
				return error(l,e);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int RemoveListener(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<$GN> self = checkSelf<UnityEngine.Events.UnityEvent<$GN>>(l);
                UnityEngine.Events.UnityAction<$GN> a1;
                checkType(l, 2, out a1);
                self.RemoveListener(a1);
				pushValue(l,true);
                return 1;
            }
            catch (Exception e)
            {
                return error(l,e);
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int Invoke(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<$GN> self = checkSelf<UnityEngine.Events.UnityEvent<$GN>>(l);
" +

                GenericCallDecl(t.BaseType)


+ @"
				pushValue(l,true);
                return 1;
            }
            catch (Exception e)
            {
                return error(l,e);
            }
        }
        static public void reg(IntPtr l)
        {
            getTypeTable(l, typeof(LuaUnityEvent_$CLS).FullName);
            addMember(l, AddListener);
            addMember(l, RemoveListener);
            addMember(l, Invoke);
            createTypeMetatable(l, null, typeof(LuaUnityEvent_$CLS), typeof(UnityEngine.Events.UnityEventBase));
        }

        static bool checkType(IntPtr l,int p,out UnityEngine.Events.UnityAction<$GN> ua) {
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
            LuaDelegate ld;
            checkType(l, p, out ld);
            if (ld.d != null)
            {
                ua = (UnityEngine.Events.UnityAction<$GN>)ld.d;
                return true;
            }
			l = LuaState.get(l).L;
            ua = ($ARGS) =>
            {
                int error = pushTry(l);
                $PUSHVALUES
                ld.pcall($GENERICCOUNT, error);
                LuaDLL.lua_settop(l,error - 1);
            };
            ld.d = ua;
            return true;
        }
    }
}";


            temp = temp.Replace("$CLS", _Name(GenericName(t.BaseType)));
            temp = temp.Replace("$FNAME", FullName(t));
            temp = temp.Replace("$GN", GenericName(t.BaseType, ","));
            temp = temp.Replace("$ARGS", ArgsDecl(t.BaseType));
            temp = temp.Replace("$PUSHVALUES", PushValues(t.BaseType));
            temp = temp.Replace("$GENERICCOUNT", t.BaseType.GetGenericArguments().Length.ToString());
            Write(file, temp);
        }

        string GenericCallDecl(Type t)
        {

            try {
                Type[] tt = t.GetGenericArguments();
                string ret = "";
                string args = "";
                for (int n = 0; n < tt.Length; n++) {
                    string dt = SimpleType(tt[n]);
                    ret += string.Format("				{0} a{1};", dt, n) + NewLine;
                    //ret+=string.Format("				checkType(l,{0},out a{1});",n+2,n)+NewLine;
                    ret += "				" + GetCheckType(tt[n], n + 2, "a" + n) + NewLine;
                    args += ("a" + n);
                    if (n < tt.Length - 1) args += ",";
                }
                ret += string.Format("				self.Invoke({0});", args) + NewLine;
                return ret;
            }
            catch (Exception e) {
                Debug.Log(e.ToString());
                return "";
            }
        }

        string GetCheckType(Type t, int n, string v = "v", string prefix = "")
        {
            if (t.IsByRef) {
                t = t.GetElementType();
            }
            if (t.IsEnum) {
                return string.Format("checkEnum(l,{2}{0},out {1});", n, v, prefix);
            }
            else if (t.BaseType == typeof(System.MulticastDelegate)) {
                return string.Format("int op=LuaDelegation.checkDelegate(l,{2}{0},out {1});", n, v, prefix);
            }
            else if (IsValueType(t)) {
                if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>))
                    return string.Format("checkNullable(l,{2}{0},out {1});", n, v, prefix);
                else
                    return string.Format("checkValueType(l,{2}{0},out {1});", n, v, prefix);
            }
            else if (t.IsArray) {
                return string.Format("checkArray(l,{2}{0},out {1});", n, v, prefix);
            }
            else {
                return string.Format("checkType(l,{2}{0},out {1});", n, v, prefix);
            }
        }

        string PushValues(Type t)
        {
            try {
                Type[] tt = t.GetGenericArguments();
                string ret = "";
                for (int n = 0; n < tt.Length; n++) {
                    var pt = tt[n];
                    if (pt.IsByRef)
                        pt = pt.GetElementType();
                    if (pt.Name == "BoxedValue")
                        ret += ("pushValue(l,v" + n + ".GetObject());");
                    else
                        ret += ("pushValue(l,v" + n + ");");
                }
                return ret;
            }
            catch (Exception e) {
                Debug.Log(e.ToString());
                return "";
            }
        }

        string ArgsDecl(Type t)
        {
            try {
                Type[] tt = t.GetGenericArguments();
                string ret = "";
                for (int n = 0; n < tt.Length; n++) {
                    string dt = SimpleType(tt[n]);
                    dt += (" v" + n);
                    ret += dt;
                    if (n < tt.Length - 1)
                        ret += ",";
                }
                return ret;
            }
            catch (Exception e) {
                Debug.Log(e.ToString());
                return "";
            }
        }

        void RegEnumFunction(Type t, StreamWriter file)
        {
            // Write export function
            Write(file, "static public void reg(IntPtr l) {");
            Write(file, "getEnumTable(l,\"{0}\");", string.IsNullOrEmpty(givenNamespace) ? FullName(t) : givenNamespace);

            foreach (string name in Enum.GetNames(t)) {
                Write(file, "addMember(l,{0},\"{1}\");", Convert.ToInt32(Enum.Parse(t, name)), name);
            }

            Write(file, "LuaDLL.lua_pop(l, 1);");
            Write(file, "}");
        }


        StreamWriter Begin(Type t)
        {
            string clsname = ExportName(t);
            string f = path + clsname + ".cs";
            try {
                StreamWriter file = new StreamWriter(f, false, Encoding.UTF8);
                file.NewLine = NewLine;
                return file;
            }
            catch (Exception ex) {
                Debug.LogErrorFormat("new StreamWriter \"{0}\" throw exception:{1}\n{2}", f, ex.Message, ex.StackTrace);
                throw;
            }
        }

        private void End(StreamWriter file)
        {
            Write(file, "}");
            file.Flush();
            file.Close();
        }

        private void WriteHead(Type t, StreamWriter file)
        {
            HashSet<string> nsset = new HashSet<string>();
            Write(file, "using System;");
            Write(file, "using SLua;");
            Write(file, "using System.Collections.Generic;");
            nsset.Add("System");
            nsset.Add("SLua");
            nsset.Add("System.Collections.Generic");
            WriteExtraNamespace(file, t, nsset);
#if UNITY_5_3_OR_NEWER
            Write(file, "[UnityEngine.Scripting.Preserve]");
#endif
            Write(file, "public class {0} : LuaObject {{", ExportName(t));
        }

        // add namespace for extension method
        void WriteExtraNamespace(StreamWriter file, Type t, HashSet<string> nsset)
        {
            List<MethodInfo> lstMI;
            if (extensionMethods.TryGetValue(t, out lstMI)) {
                foreach (MethodInfo m in lstMI) {
                    // if not writed
                    if (!string.IsNullOrEmpty(m.ReflectedType.Namespace) && !nsset.Contains(m.ReflectedType.Namespace)) {
                        Write(file, "using {0};", m.ReflectedType.Namespace);
                        nsset.Add(m.ReflectedType.Namespace);
                    }
                }
            }
        }

        private bool IsUnsupportedField(FieldInfo fi)
        {
            if (fi.FieldType.IsGenericType || fi.FieldType.IsPointer)
                return true;
            return false;
        }
        private bool IsUnsupportedProperty(PropertyInfo pi)
        {
            if (pi.PropertyType.IsGenericType || pi.PropertyType.IsPointer)
                return true;
            return false;
        }
        private bool IsUnsupportedMethod(MethodInfo mi)
        {
            if (mi.ReturnType.IsGenericType || mi.ReturnType.IsPointer)
                return true;
            return IsUnsupportedMethod((MethodBase)mi);
        }
        private bool IsUnsupportedMethod(MethodBase mb)
        {
            var ps = mb.GetParameters();
            foreach(var p in ps) {
                if (p.ParameterType.IsGenericType || p.ParameterType.IsPointer) {
                    return true;
                }
            }
            return false;
        }

        private const string c_DisposeName = "Dispose";
        private const string c_DisposeIntfName = "System.IDisposable.Dispose";
        private const string c_StaticDisposeName = "Dispose_s";
        private const string c_StaticDisposeIntfName = "System.IDisposable.Dispose_s";
        private void WriteFunction(Type t, StreamWriter file, bool writeStatic = false)
        {
            BindingFlags bf = BindingFlags.Public;
            if (writeStatic)
                bf |= BindingFlags.Static;
            else
                bf |= BindingFlags.Instance;
            if (null == t.BaseType || !t.BaseType.IsGenericType) {
                bf |= BindingFlags.DeclaredOnly;
            }

            MethodInfo[] members = t.GetMethods(bf);
            List<MethodInfo> methods = new List<MethodInfo>();
            foreach (MethodInfo mi in members) {
                if (IsUnsupportedMethod(mi))
                    continue;
                var assemblyFullName = mi.DeclaringType.Assembly.FullName;
                if (assemblyFullName.StartsWith("mscorlib")) {
                    if (mi.Name == "TryAdd" ||
                        mi.Name == "TryDequeue" ||
                        mi.Name == "TryPeek" ||
                        mi.Name == "TryPop" ||
                        mi.Name == "Deconstruct")
                        continue;
                }
                if (assemblyFullName.StartsWith("System")) {
                    if (mi.Name == "TryAdd" ||
                        mi.Name == "TryDequeue" ||
                        mi.Name == "TryPeek" ||
                        mi.Name == "TryPop")
                        continue;
                }
                if (assemblyFullName.StartsWith("System.Core")) {
                    if (mi.Name == "TryGetValue")
                        continue;
                }
                methods.Add(tryFixGenericMethod(mi));
            }

            if (typeof(IDisposable).IsAssignableFrom(t) && null == methods.Find(m => m.Name == c_DisposeName)) {
                var mis = t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(mi => mi.Name == c_DisposeName || mi.Name == c_DisposeIntfName).ToList();
                if (mis.Count > 0) {
                    foreach (var mi in mis) {
                        if (mi.GetParameters().Length <= 0) {
                            methods.Add(tryFixGenericMethod(mi));
                        }
                    }
                }
                else if (!t.AssemblyQualifiedName.Contains("UnityEngine")) {
                    Debug.LogWarningFormat("Can't find {0} from {1}, maybe defined by base class, ensure export base class.", c_DisposeName, t.FullName);
                }
            }

            if (!writeStatic && this.includeExtension) {
                if (extensionMethods.ContainsKey(t)) {
                    methods.AddRange(extensionMethods[t]);
                }
            }
            foreach (MethodInfo mi in methods) {
                bool instanceFunc;
                if (writeStatic && isPInvoke(mi, out instanceFunc)) {
                    try {
                        directfunc.Add(t.FullName + "." + mi.Name, instanceFunc);
                    }
                    catch (Exception ex) {
                        Debug.LogErrorFormat("Add {0} exception:{1}\n{2}", t.FullName + "." + mi.Name, ex.Message, ex.StackTrace);
                    }
                    continue;
                }

                if (!MemberInFilter(t, mi)) {
                    WriteFunctionImpl(file, writeStatic, mi, t, bf);
                }
            }
        }

        bool isPInvoke(MethodInfo mi, out bool instanceFunc)
        {
            if (mi.IsDefined(typeof(MonoPInvokeCallbackAttribute), false)) {
                instanceFunc = !mi.IsDefined(typeof(StaticExportAttribute), false);
                return true;
            }
            instanceFunc = true;
            return false;
        }

        string staticName(string name)
        {
            return name + "_s";
        }


        bool MemberInFilter(Type t, MemberInfo mi)
        {
            return memberFilter.Contains(t.Name + "." + mi.Name) || memberFilter.Contains("*." + mi.Name);
        }

        bool IsObsolete(MemberInfo t)
        {
            return t.IsDefined(typeof(ObsoleteAttribute), false);
        }

        string NewLine
        {
            get {
                switch (eol) {
                    case EOL.Native:
                        return System.Environment.NewLine;
                    case EOL.CRLF:
                        return "\r\n";
                    case EOL.CR:
                        return "\r";
                    case EOL.LF:
                        return "\n";
                    default:
                        return "";
                }
            }
        }

        bool hasOverloadedVersion(Type t, ref string f)
        {
            Type ot;
            if (overloadedClass.TryGetValue(t, out ot)) {
                MethodInfo mi = ot.GetMethod(f, BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                if (mi != null && mi.IsDefined(typeof(MonoPInvokeCallbackAttribute), false)) {
                    f = FullName(ot) + "." + f;
                    return true;
                }
            }
            return false;
        }

        void RegFunction(Type t, StreamWriter file)
        {
#if UNITY_5_3_OR_NEWER
            Write(file, "[UnityEngine.Scripting.Preserve]");
#endif

            // Write export function
            Write(file, "static public void reg(IntPtr l) {");

            if (t.BaseType != null && t.BaseType.Name.Contains("UnityEvent`")) {
                Write(file, "LuaUnityEvent_{1}.reg(l);", FullName(t), _Name((GenericName(t.BaseType))));
            }

            Write(file, "getTypeTable(l,\"{0}\");", string.IsNullOrEmpty(givenNamespace) ? FullName(t) : givenNamespace);
            foreach (string i in funcname) {
                string f = i;
                Write(file, "addMember(l,{0});", f);
                /*
                if (hasOverloadedVersion(t, ref f))
                    Write(file, "addMember(l,{0});", f);
                else
                    Write(file, "addMember(l,{0});", f);
                */
            }
            foreach (string f in directfunc.Keys) {
                bool instance = directfunc[f];
                Write(file, "addMember(l,{0},{1});", f, instance ? "true" : "false");
            }

            foreach (string f in propname.Keys) {
                PropPair pp = propname[f];
                Write(file, "addMember(l,\"{0}\",{1},{2},{3});", f, pp.get, pp.set, pp.isInstance ? "true" : "false");
            }
            if (t.BaseType != null && !CutBase(t.BaseType)) {
                if (t.BaseType.Name.Contains("UnityEvent`"))
                    Write(file, "createTypeMetatable(l,{2}, typeof({0}),typeof(LuaUnityEvent_{1}));", TypeDecl(t), _Name(GenericName(t.BaseType)), constructorOrNot(t));
                else
                    Write(file, "createTypeMetatable(l,{2}, typeof({0}),typeof({1}));", TypeDecl(t), TypeDecl(t.BaseType), constructorOrNot(t));
            }
            else
                Write(file, "createTypeMetatable(l,{1}, typeof({0}));", TypeDecl(t), constructorOrNot(t));
            Write(file, "}");
        }

        string constructorOrNot(Type t)
        {
            //cs2luaʹ���빹��ԭ��ƥ��ľ�̬�������������ʵ������ʹ��slua������__call�����ˣ������������أ�
            return "null";
        }

        bool CutBase(Type t)
        {
            if (t.FullName.StartsWith("System.Object"))
                return true;
            return false;
        }

        void WriteSet(StreamWriter file, Type t, string cls, string fn, bool isstatic = false, bool canread = true)
        {
            if (t.BaseType == typeof(MulticastDelegate)) {
                if (isstatic) {
                    Write(file, "if(op==0) {0}.{1}=v;", cls, fn);
                    if (canread) {
                        Write(file, "else if(op==1) {0}.{1}+=v;", cls, fn);
                        Write(file, "else if(op==2) {0}.{1}-=v;", cls, fn);
                    }
                }
                else {
                    Write(file, "if(op==0) self.{0}=v;", fn);
                    if (canread) {
                        Write(file, "else if(op==1) self.{0}+=v;", fn);
                        Write(file, "else if(op==2) self.{0}-=v;", fn);
                    }
                }
            }
            else {
                if (isstatic) {
                    Write(file, "{0}.{1}=v;", cls, fn);
                }
                else {
                    Write(file, "self.{0}=v;", fn);
                }
            }
        }

        readonly static string[] keywords = { "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while" };

        static string NormalName(string name)
        {
            if (Array.BinarySearch<string>(keywords, name) >= 0) {
                return "@" + name;
            }
            return name;
        }

        private void WriteField(Type t, StreamWriter file)
        {
            // Write field set/get

            FieldInfo[] fields = GetFields(t);
            foreach (FieldInfo fi in fields) {
                if (IsUnsupportedField(fi) || DontExport(fi) || IsObsolete(fi))
                    continue;

                PropPair pp = new PropPair();
                pp.isInstance = !fi.IsStatic;

                if (fi.FieldType.BaseType != typeof(MulticastDelegate)) {
                    WriteFunctionAttr(file);
                    Write(file, "static public int get_{0}(IntPtr l) {{", fi.Name);
                    WriteTry(file);

                    if (fi.IsStatic) {
                        WriteOk(file);
                        WritePushValue(fi.FieldType, file, string.Format("{0}.{1}", TypeDecl(t), NormalName(fi.Name)));
                    }
                    else {
                        WriteCheckSelf(file, t);
                        WriteOk(file);
                        WritePushValue(fi.FieldType, file, string.Format("self.{0}", NormalName(fi.Name)));
                    }

                    Write(file, "return 2;");
                    WriteCatchExecption(file);
                    Write(file, "}");

                    pp.get = "get_" + fi.Name;
                }

                if (!fi.IsLiteral && !fi.IsInitOnly) {
                    WriteFunctionAttr(file);
                    Write(file, "static public int set_{0}(IntPtr l) {{", fi.Name);
                    WriteTry(file);
                    if (fi.IsStatic) {
                        Write(file, "{0} v;", TypeDecl(fi.FieldType));
                        WriteCheckType(file, fi.FieldType, 2);
                        WriteSet(file, fi.FieldType, TypeDecl(t), NormalName(fi.Name), true);
                    }
                    else {
                        WriteCheckSelf(file, t);
                        Write(file, "{0} v;", TypeDecl(fi.FieldType));
                        WriteCheckType(file, fi.FieldType, 2);
                        WriteSet(file, fi.FieldType, t.FullName, NormalName(fi.Name));
                    }

                    if (t.IsValueType && !fi.IsStatic) {
                        if (t.FullName == "UnityEngine.Color" || t.FullName == "UnityEngine.Quaternion" || t.FullName == "UnityEngine.Vector2" || t.FullName == "UnityEngine.Vector3" || t.FullName == "UnityEngine.Vector4")
                            Write(file, "setBack(l,self);");
                        else
                            Write(file, "setBack(l,(object)self);");
                    }
                    WriteOk(file);
                    Write(file, "return 1;");
                    WriteCatchExecption(file);
                    Write(file, "}");

                    pp.set = "set_" + fi.Name;
                }

                try {
                    propname.Add(fi.Name, pp);
                }
                catch (Exception ex) {
                    Debug.LogErrorFormat("Add {0}.{1}.{2} exception:{3}\n{4}", t.Namespace, t.Name, fi.Name, ex.Message, ex.StackTrace);
                }
                tryMake(fi.FieldType);
            }
            //for this[]
            List<PropertyInfo> getter = new List<PropertyInfo>();
            List<PropertyInfo> setter = new List<PropertyInfo>();
            // Write property set/get
            PropertyInfo[] props = GetProperties(t);
            foreach (PropertyInfo fi in props) {
                //if (fi.Name == "Item" || IsObsolete(fi) || MemberInFilter(t,fi) || DontExport(fi))
                if (IsUnsupportedProperty(fi) || IsObsolete(fi) || MemberInFilter(t, fi) || DontExport(fi))
                    continue;
                if (fi.Name == "Item"
                    || (t.Name == "StringBuilder" && fi.Name == "Chars")
                    || (t.Name == "String" && fi.Name == "Chars")) // for string[]
                {
                    //for this[]
                    if (!fi.GetGetMethod().IsStatic && fi.GetIndexParameters().Length == 1) {
                        if (fi.CanRead && !IsNotSupport(fi.PropertyType))
                            getter.Add(fi);
                        if (fi.CanWrite && fi.GetSetMethod() != null)
                            setter.Add(fi);
                    }
                    continue;
                }
                PropPair pp = new PropPair();
                bool isInstance = true;

                if (fi.CanRead && fi.GetGetMethod() != null) {
                    if (!IsNotSupport(fi.PropertyType)) {
                        WriteFunctionAttr(file);
                        Write(file, "static public int get_{0}(IntPtr l) {{", fi.Name);
                        WriteTry(file);

                        if (fi.GetGetMethod().IsStatic) {
                            isInstance = false;
                            WriteOk(file);
                            WritePushValue(fi.PropertyType, file, string.Format("{0}.{1}", TypeDecl(t), NormalName(fi.Name)));
                        }
                        else {
                            WriteCheckSelf(file, t);
                            WriteOk(file);
                            WritePushValue(fi.PropertyType, file, string.Format("self.{0}", NormalName(fi.Name)));
                        }

                        Write(file, "return 2;");
                        WriteCatchExecption(file);
                        Write(file, "}");
                        pp.get = "get_" + fi.Name;
                    }

                }

                if (fi.CanWrite && fi.GetSetMethod() != null) {
                    WriteFunctionAttr(file);
                    Write(file, "static public int set_{0}(IntPtr l) {{", fi.Name);
                    WriteTry(file);
                    if (fi.GetSetMethod().IsStatic) {
                        WriteValueCheck(file, fi.PropertyType, 2);
                        WriteSet(file, fi.PropertyType, TypeDecl(t), NormalName(fi.Name), true, fi.CanRead);
                        isInstance = false;
                    }
                    else {
                        WriteCheckSelf(file, t);
                        WriteValueCheck(file, fi.PropertyType, 2);
                        WriteSet(file, fi.PropertyType, TypeDecl(t), NormalName(fi.Name), false, fi.CanRead);
                    }

                    if (t.IsValueType) {
                        if (t.FullName == "UnityEngine.Color" || t.FullName == "UnityEngine.Quaternion" || t.FullName == "UnityEngine.Vector2" || t.FullName == "UnityEngine.Vector3" || t.FullName == "UnityEngine.Vector4")
                            Write(file, "setBack(l,self);");
                        else
                            Write(file, "setBack(l,(object)self);");
                    }
                    WriteOk(file);
                    Write(file, "return 1;");
                    WriteCatchExecption(file);
                    Write(file, "}");
                    pp.set = "set_" + fi.Name;
                }
                pp.isInstance = isInstance;

                try {
                    propname.Add(fi.Name, pp);
                }
                catch (Exception ex) {
                    Debug.LogErrorFormat("Add {0}.{1}.{2} exception:{3}\n{4}", t.Namespace, t.Name, fi.Name, ex.Message, ex.StackTrace);
                }
                tryMake(fi.PropertyType);
            }
            //for this[]
            WriteItemFunc(t, file, getter, setter);
        }

        private FieldInfo[] GetFields(Type t)
        {
            return GetFields(t, false);
        }
        private FieldInfo[] GetFields(Type t, bool includeBase)
        {
            HashSet<string> names = new HashSet<string>();
            FieldInfo[] fields = t.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var field in fields) {
                names.Add(field.Name);
            }
            if (null != t.BaseType && (t.BaseType.IsGenericType || includeBase)) {
                FieldInfo[] baseFields = GetFields(t.BaseType, true);
                List<FieldInfo> list = new List<FieldInfo>();
                list.AddRange(fields);
                foreach (var field in baseFields) {
                    if (!names.Contains(field.Name)) {
                        names.Add(field.Name);

                        list.Add(field);
                    }
                }
                return list.ToArray();
            }
            else {
                return fields;
            }
        }

        private PropertyInfo[] GetProperties(Type t)
        {
            return GetProperties(t, false);
        }
        private PropertyInfo[] GetProperties(Type t, bool includeBase)
        {
            HashSet<string> names = new HashSet<string>();
            PropertyInfo[] props = t.GetProperties(BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var field in props) {
                names.Add(field.Name);
            }
            if (null != t.BaseType && (t.BaseType.IsGenericType || includeBase)) {
                PropertyInfo[] baseProps = GetProperties(t.BaseType, true);
                List<PropertyInfo> list = new List<PropertyInfo>();
                list.AddRange(props);
                foreach (var prop in baseProps) {
                    if (!names.Contains(prop.Name)) {
                        names.Add(prop.Name);

                        list.Add(prop);
                    }
                }
                return list.ToArray();
            }
            else {
                return props;
            }
        }

        void WriteItemFunc(Type t, StreamWriter file, List<PropertyInfo> getter, List<PropertyInfo> setter)
        {

            //Write property this[] set/get
            if (getter.Count > 0) {
                //get
                bool first_get = true;
                WriteFunctionAttr(file);
                Write(file, "static public int getItem(IntPtr l) {");
                WriteTry(file);
                WriteCheckSelf(file, t);
                if (getter.Count == 1) {
                    PropertyInfo _get = getter[0];
                    ParameterInfo[] infos = _get.GetIndexParameters();
                    WriteValueCheck(file, infos[0].ParameterType, 2, "v");
                    Write(file, "var ret = self[v];");
                    WriteOk(file);
                    WritePushValue(_get.PropertyType, file, "ret");
                    Write(file, "return 2;");
                }
                else {
                    Write(file, "LuaTypes t = LuaDLL.lua_type(l, 2);");
                    for (int i = 0; i < getter.Count; i++) {
                        PropertyInfo fii = getter[i];
                        ParameterInfo[] infos = fii.GetIndexParameters();
                        Write(file, "{0}(matchType(l,2,t,typeof({1}))){{", first_get ? "if" : "else if", infos[0].ParameterType);
                        WriteValueCheck(file, infos[0].ParameterType, 2, "v");
                        Write(file, "var ret = self[v];");
                        WriteOk(file);
                        WritePushValue(fii.PropertyType, file, "ret");
                        Write(file, "return 2;");
                        Write(file, "}");
                        first_get = false;
                    }
                    WriteError(file, "No matched override function to call");
                }
                WriteCatchExecption(file);
                Write(file, "}");
                funcname.Add("getItem");
            }
            if (setter.Count > 0) {
                bool first_set = true;
                WriteFunctionAttr(file);
                Write(file, "static public int setItem(IntPtr l) {");
                WriteTry(file);
                WriteCheckSelf(file, t);
                if (setter.Count == 1) {
                    PropertyInfo _set = setter[0];
                    ParameterInfo[] infos = _set.GetIndexParameters();
                    WriteValueCheck(file, infos[0].ParameterType, 2);
                    WriteValueCheck(file, _set.PropertyType, 3, "c");
                    Write(file, "self[v]=c;");
                    WriteOk(file);
                }
                else {
                    Write(file, "LuaTypes t = LuaDLL.lua_type(l, 2);");
                    for (int i = 0; i < setter.Count; i++) {
                        PropertyInfo fii = setter[i];
                        if (t.BaseType != typeof(MulticastDelegate)) {
                            ParameterInfo[] infos = fii.GetIndexParameters();
                            Write(file, "{0}(matchType(l,2,t,typeof({1}))){{", first_set ? "if" : "else if", infos[0].ParameterType);
                            WriteValueCheck(file, infos[0].ParameterType, 2, "v");
                            WriteValueCheck(file, fii.PropertyType, 3, "c");
                            Write(file, "self[v]=c;");
                            WriteOk(file);
                            Write(file, "return 1;");
                            Write(file, "}");
                            first_set = false;
                        }
                        if (t.IsValueType) {
                            if (t.FullName == "UnityEngine.Color" || t.FullName == "UnityEngine.Quaternion" || t.FullName == "UnityEngine.Vector2" || t.FullName == "UnityEngine.Vector3" || t.FullName == "UnityEngine.Vector4")
                                Write(file, "setBack(l,self);");
                            else
                                Write(file, "setBack(l,(object)self);");
                        }
                    }
                    Write(file, "LuaDLL.lua_pushstring(l,\"No matched override function to call\");");
                }
                Write(file, "return 1;");
                WriteCatchExecption(file);
                Write(file, "}");
                funcname.Add("setItem");
            }
        }

        void WriteTry(StreamWriter file)
        {
            Write(file, "try {");
        }

        void WriteCatchExecption(StreamWriter file)
        {
            Write(file, "}");
            Write(file, "catch(Exception e) {");
            Write(file, "return error(l,e);");
            Write(file, "}");
        }

        void WriteCheckType(StreamWriter file, Type t, int n, string v = "v", string nprefix = "")
        {
            if (t.IsByRef) {
                t = t.GetElementType();
            }
            if (t.IsEnum)
                Write(file, "checkEnum(l,{2}{0},out {1});", n, v, nprefix);
            else if (t.BaseType == typeof(System.MulticastDelegate))
                Write(file, "int op=LuaDelegation.checkDelegate(l,{2}{0},out {1});", n, v, nprefix);
            else if (IsValueType(t))
                if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>))
                    Write(file, "checkNullable(l,{2}{0},out {1});", n, v, nprefix);
                else
                    Write(file, "checkValueType(l,{2}{0},out {1});", n, v, nprefix);
            else if (t.IsArray)
                Write(file, "checkArray(l,{2}{0},out {1});", n, v, nprefix);
            else
                Write(file, "checkType(l,{2}{0},out {1});", n, v, nprefix);
        }

        void WriteValueCheck(StreamWriter file, Type t, int n, string v = "v", string nprefix = "")
        {
            Write(file, "{0} {1};", SimpleType(t), v);
            WriteCheckType(file, t, n, v, nprefix);
        }

        private void WriteFunctionAttr(StreamWriter file)
        {
            Write(file, "[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]");
#if UNITY_5_3_OR_NEWER
            Write(file, "[UnityEngine.Scripting.Preserve]");
#endif
        }

        ConstructorInfo[] GetValidConstructor(Type t)
        {
            List<ConstructorInfo> ret = new List<ConstructorInfo>();
            if (t.GetConstructor(Type.EmptyTypes) == null && t.IsAbstract && t.IsSealed)
                return ret.ToArray();
            if (t.IsAbstract)
                return ret.ToArray();
            if (t.BaseType != null && t.BaseType.Name == "MonoBehaviour")
                return ret.ToArray();

            ConstructorInfo[] cons = t.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
            foreach (ConstructorInfo ci in cons) {
                
                if (!IsUnsupportedMethod(ci) && !IsObsolete(ci) && !DontExport(ci) && !ContainUnsafe(ci))
                    ret.Add(ci);
            }
            return ret.ToArray();
        }

        bool ContainUnsafe(MethodBase mi)
        {
            foreach (ParameterInfo p in mi.GetParameters()) {
                if (p.ParameterType.FullName.Contains("*"))
                    return true;
            }
            return false;
        }

        bool DontExport(MemberInfo mi)
        {
            var methodString = string.Format("{0}.{1}", GenericBaseName(mi.DeclaringType), mi.Name);
            if (CustomExport.FunctionFilterList.Contains(methodString))
                return true;
            // directly ignore any components .ctor
            if (mi.DeclaringType.IsSubclassOf(typeof(UnityEngine.Component))) {
                if (mi.MemberType == MemberTypes.Constructor) {
                    return true;
                }
            }

            if (mi.IsDefined(typeof(DoNotToLuaAttribute), false))
                return true;

            return false;
        }

        private int CompareParameters(ParameterInfo[] a, ParameterInfo[] b)
        {
            if (a.Length == b.Length) {
                //���������ȼ����
                int aFloatCt = 0;
                int bFloatCt = 0;
                foreach (var pi in a) {
                    if (pi.ParameterType == typeof(float) || pi.ParameterType == typeof(double)) {
                        ++aFloatCt;
                    }
                }
                foreach (var pi in b) {
                    if (pi.ParameterType == typeof(float) || pi.ParameterType == typeof(double)) {
                        ++bFloatCt;
                    }
                }
                if (aFloatCt < bFloatCt)
                    return -1;
                else if (aFloatCt == bFloatCt)
                    return 0;
                else
                    return 1;
            }
            return 0;
        }

        private void WriteConstructor(Type t, StreamWriter file)
        {
            if (t.IsValueType) { // default constructor
                string fn = staticName("ctor");
                funcname.Add(fn);
                WriteFunctionAttr(file);
                Write(file, "static public int {0}(IntPtr l) {{", fn);
                WriteTry(file);
                Write(file, "{0} o;", TypeDecl(t));
                Write(file, "o=new {0}();", TypeDecl(t));
                if (t.Name == "BoxedValue")
                    WriteReturn(file, "o.GetObject()");
                else
                    WriteReturn(file, "o");
                WriteCatchExecption(file);
                Write(file, "}");
            }
            ConstructorInfo[] cons = GetValidConstructor(t);
            if (cons.Length > 0) {
                //����������˳������
                Array.Sort(cons, (a, b) => {
                    int la = a.GetParameters().Length;
                    int lb = b.GetParameters().Length;
                    if (la < lb)
                        return -1;
                    else if (la == lb)
                        return CompareParameters(a.GetParameters(), b.GetParameters());
                    else
                        return 1;
                });
                bool first = true;
                for (int i = 0; i < cons.Length; ++i) {
                    WriteOneConstructor(cons[i], cons.Length, ref first, t, file);
                }
            }
        }

        private void WriteOneConstructor(ConstructorInfo con, int count, ref bool first, Type t, StreamWriter file)
        {
            ConstructorInfo ci = con;
            ParameterInfo[] pars = ci.GetParameters();
            bool skip = false;
            if (ci.DeclaringType.Assembly.FullName.StartsWith("mscorlib")) {
                if (typeof(IDictionary).IsAssignableFrom(ci.DeclaringType)) {
                    if (pars.Length > 0 && typeof(IEnumerable).IsAssignableFrom(pars[0].ParameterType)) {
                        skip = true;
                    }
                }
            }
            if (skip)
                return;
            string name = CalcOverloadedMethodSignature(t, con);
            if (count <= 1 && !t.IsValueType) {
                name = con.Name;
                if (!string.IsNullOrEmpty(name) && name[0] == '.')
                    name = name.Substring(1);
            }
            string fn = staticName(name);
            funcname.Add(fn);
            WriteFunctionAttr(file);
            Write(file, "static public int {0}(IntPtr l) {{", fn);
            WriteTry(file);
            Write(file, "{0} o;", TypeDecl(t));
            for (int k = 0; k < pars.Length; k++) {
                ParameterInfo p = pars[k];
                bool hasParams = p.IsDefined(typeof(ParamArrayAttribute), false);
                CheckArgument(file, p.ParameterType, k, 1, p.IsOut, hasParams);
            }
            Write(file, "o=new {0}({1});", TypeDecl(t), FuncCall(ci));
            WriteOk(file);
            if (t.Name == "String") // if export system.string, push string as ud not lua string
                Write(file, "pushObject(l,o);");
            else if (t.Name == "BoxedValue")
                Write(file, "pushValue(l,o.GetObject());");
            else
                Write(file, "pushValue(l,o);");
            Write(file, "return 2;");
            WriteCatchExecption(file);
            Write(file, "}");
        }

        void WriteOk(StreamWriter file)
        {
            Write(file, "pushValue(l,true);");
        }
        void WriteBad(StreamWriter file)
        {
            Write(file, "pushValue(l,false);");
        }

        void WriteError(StreamWriter file, string err)
        {
            WriteBad(file);
            Write(file, "LuaDLL.lua_pushstring(l,\"{0}\");", err);
            Write(file, "return 2;");
        }

        void WriteReturn(StreamWriter file, string val)
        {
            Write(file, "pushValue(l,true);");
            Write(file, "pushValue(l,{0});", val);
            Write(file, "return 2;");
        }

        bool IsNotSupport(Type t)
        {
            if (t.IsSubclassOf(typeof(Delegate)))
                return true;
            return false;
        }

        string[] prefix = new string[] { "System.Collections.Generic" };
        string RemoveRef(string s, bool removearray = true)
        {
            if (s.EndsWith("&")) s = s.Substring(0, s.Length - 1);
            if (s.EndsWith("[]") && removearray) s = s.Substring(0, s.Length - 2);
            if (s.StartsWith(prefix[0])) s = s.Substring(prefix[0].Length + 1, s.Length - prefix[0].Length - 1);

            s = s.Replace("+", ".");
            if (s.Contains("`")) {
                string regstr = @"`\d";
                Regex r = new Regex(regstr, RegexOptions.None);
                s = r.Replace(s, "");
                s = s.Replace("[", "<");
                s = s.Replace("]", ">");
            }
            return s;
        }

        string GenericBaseName(Type t)
        {
            string n = t.FullName;
            if (n.IndexOf('[') > 0) {
                n = n.Substring(0, n.IndexOf('['));
            }
            return n.Replace("+", ".");
        }
        string GenericName(Type t, string sep = "_")
        {
            try {
                Type[] tt = t.GetGenericArguments();
                string ret = "";
                for (int n = 0; n < tt.Length; n++) {
                    string dt = SimpleType(tt[n]);
                    ret += dt;
                    if (n < tt.Length - 1)
                        ret += sep;
                }
                return ret;
            }
            catch (Exception e) {
                Debug.Log(e.ToString());
                return "";
            }
        }

        string _Name(string n)
        {
            string ret = "";
            for (int i = 0; i < n.Length; i++) {
                if (char.IsLetterOrDigit(n[i]))
                    ret += n[i];
                else
                    ret += "_";
            }
            return ret;
        }

        string TypeDecl(ParameterInfo[] pars, int paraOffset = 0)
        {
            string ret = "";
            for (int n = paraOffset; n < pars.Length; n++) {
                ret += ",typeof(";
                if (pars[n].IsOut)
                    ret += "LuaOut";
                else
                    ret += SimpleType(pars[n].ParameterType);
                ret += ")";
            }
            return ret;
        }

        // fill Generic Parameters if needed
        string MethodDecl(MethodInfo m)
        {
            if (m.IsGenericMethod) {
                string parameters = "";
                bool first = true;
                foreach (Type genericType in m.GetGenericArguments()) {
                    if (first)
                        first = false;
                    else
                        parameters += ",";
                    parameters += genericType.ToString();

                }
                return string.Format("{0}<{1}>", m.Name, parameters);
            }
            else {
                return m.Name;
            }
        }

        // try filling generic parameters
        static MethodInfo tryFixGenericMethod(MethodInfo method)
        {
            if (!method.ContainsGenericParameters)
                return method;

            try {
                Type[] genericTypes = method.GetGenericArguments();
                for (int j = 0; j < genericTypes.Length; j++) {
                    Type[] contraints = genericTypes[j].GetGenericParameterConstraints();
                    if (contraints != null && contraints.Length == 1 && contraints[0] != typeof(ValueType))
                        genericTypes[j] = contraints[0];
                    else
                        return method;
                }
                // only fixed here
                return method.MakeGenericMethod(genericTypes);
            }
            catch (Exception e) {
                Debug.LogError(e);
            }
            return method;
        }

        bool isUsefullMethod(MethodInfo method)
        {
            var assemblyFullName = method.DeclaringType.Assembly.FullName;
            var pis = method.GetParameters();
            int paramNum = pis.Length;
            if (assemblyFullName.StartsWith("mscorlib")) {
                if (typeof(IDictionary).IsAssignableFrom(method.DeclaringType)) {

                    if (method.Name == "Remove" && pis.Length == 2) {
                        return false;
                    }
                }
                if (method.DeclaringType.FullName == "System.IO.Stream" && (method.Name == "Read" || method.Name == "Write") && pis.Length == 1) {
                    return false;
                }
            }
            if ((method.Name.StartsWith("set_", StringComparison.Ordinal) ||
                method.Name.StartsWith("add_", StringComparison.Ordinal)) &&
                paramNum == 1 && pis[0].ParameterType.Name.StartsWith("EventCallback")) {
                return true;
            }
            if ((method.Name != "GetType" || method.Name == "GetType" && paramNum > 0) &&
                (method.Name != "GetHashCode" || method.Name == "GetHashCode" && paramNum > 0) &&
                !method.Name.StartsWith("get_", StringComparison.Ordinal) &&
                !method.Name.StartsWith("set_", StringComparison.Ordinal) &&
                !method.Name.StartsWith("add_", StringComparison.Ordinal) &&
                !method.Name.StartsWith("remove_", StringComparison.Ordinal)) {
                return true;
            }
            return false;
        }

        void WriteFunctionDec(StreamWriter file, string name)
        {
            WriteFunctionAttr(file);
            if (name == "GetType" || name == "GetHashCode" || name == "Equals" || name == "ToString")
                Write(file, "static new public int {0}(IntPtr l) {{", name);
            else
                Write(file, "static public int {0}(IntPtr l) {{", name);
        }

        MethodInfo[] GetMethods(Type t, string name, BindingFlags bf)
        {
            List<MethodInfo> methods = new List<MethodInfo>();

            if (this.includeExtension && ((bf & BindingFlags.Instance) == BindingFlags.Instance)) {
                if (extensionMethods.ContainsKey(t)) {
                    foreach (MethodInfo m in extensionMethods[t]) {
                        if (m.Name == name
                           && !m.IsGenericMethod
                           && !IsObsolete(m)
                           && !DontExport(m)
                           && isUsefullMethod(m)) {
                            methods.Add(m);
                        }
                    }
                }
            }

            MemberInfo[] ms = t.GetMember(name, bf & (~BindingFlags.DeclaredOnly));
            foreach (MemberInfo _m in ms) {
                if (_m.MemberType == MemberTypes.Method) {
                    var m = tryFixGenericMethod((MethodInfo)_m);
                    if (!m.IsGenericMethod
                        && !IsObsolete(m)
                        && !DontExport(m)
                        && isUsefullMethod(m))
                        methods.Add(m);
                }
            }
            return methods.ToArray();
        }

        void WriteFunctionImpl(StreamWriter file, bool writeStatic, MethodInfo m, Type t, BindingFlags bf)
        {
            var methods = GetMethods(t, m.Name, bf);
            if (methods.Length == 0 && m.Name == c_DisposeIntfName) {
                methods = new MethodInfo[] { m };
            }

            int ct = 0;
            for (int n = 0; n < methods.Length; n++) {
                var mi = methods[n];
                if (!IsUnsupportedMethod(mi)) {
                    ++ct;
                }
            }
            if (ct == 1) {
                for (int n = 0; n < methods.Length; n++) {
                    var mi = methods[n];
                    if (!IsUnsupportedMethod(mi)) {
                        string fn = writeStatic ? staticName(mi.Name) : mi.Name;
                        if (fn == c_DisposeIntfName)
                            fn = c_DisposeName;
                        if (fn == c_StaticDisposeIntfName)
                            fn = c_StaticDisposeName;
                        if (!funcname.Contains(fn)) {
                            funcname.Add(fn);

                            WriteFunctionDec(file, fn);
                            WriteTry(file);
                            WriteFunctionCall(mi, file, t, bf);
                            WriteCatchExecption(file);
                            Write(file, "}");
                        }
                    }
                }
            }
            else {
                //��������˳������
                Array.Sort(methods, (a, b) => {
                    int la = a.GetParameters().Length;
                    int lb = b.GetParameters().Length;
                    if (la < lb)
                        return -1;
                    else if (la == lb)
                        return CompareParameters(a.GetParameters(), b.GetParameters());
                    else
                        return 1;
                });
                for (int n = 0; n < methods.Length; n++) {
                    var mi = methods[n];
                    if (!IsUnsupportedMethod(mi)) {
                        string sig = CalcOverloadedMethodSignature(t, mi);
                        string fn = writeStatic ? staticName(sig) : sig;
                        if (!funcname.Contains(fn)) {
                            funcname.Add(fn);

                            WriteFunctionDec(file, fn);
                            WriteTry(file);
                            WriteFunctionCall(mi, file, t, bf);
                            WriteCatchExecption(file);
                            Write(file, "}");
                        }
                    }
                }
            }
        }

        static bool IsAssignableFrom(Type l, Type r)
        {
            bool ret = false;
            if(l.IsArray) {
                if (r.IsArray) {
                    ret = IsAssignableFrom(l.GetElementType(), r.GetElementType());
                }
            }
            else if (l.IsGenericParameter) {
                var cs = l.GetGenericParameterConstraints();
                if (cs.Length == 0) {
                    ret = true;
                }
                else {
                    foreach(var c in cs) {
                        if (c.IsAssignableFrom(r)) {
                            ret = true;
                            break;
                        }
                    }
                }
            }
            else if (l.ContainsGenericParameters) {
                ret = l.Name == r.Name;
            }
            else {
                ret = l.IsAssignableFrom(r);
            }
            return ret;
        }
        static string CalcOverloadedMethodSignature(Type t, MethodBase mb)
        {
            if (null == mb)
                return string.Empty;
            StringBuilder sb = new StringBuilder();
            string name = mb.Name;
            if (!string.IsNullOrEmpty(name) && name[0] == '.')
                name = name.Substring(1);
            sb.Append(name);
            var mi = mb as MethodInfo;
            var declType = mb.DeclaringType;
            if (declType.IsGenericType) {
                declType = declType.GetGenericTypeDefinition();
                var ps = mb.GetParameters();
                var mis = declType.GetMember(mb.Name);
                foreach (var member in mis) {
                    var _mb = member as MethodBase;
                    if (null == _mb)
                        continue;
                    var _ps = _mb.GetParameters();
                    if (_mb.MemberType == mb.MemberType && _mb.GetParameters().Length == mb.GetParameters().Length) {
                        bool match = true;
                        for(int i = 0; i < _ps.Length; ++i) {
                            if(_ps[i].Name!=ps[i].Name || !IsAssignableFrom(_ps[i].ParameterType, ps[i].ParameterType)) {
                                match = false;
                                break;
                            }
                        }
                        if (match) {
                            mb = _mb;
                            mi = mb as MethodInfo;
                            break;
                        }
                    }
                }
            }
            if (null != mi && (name == "op_Implicit" || name == "op_Explicit")) {
                sb.Append("__");
                var retType = mi.ReturnType;
                CalcMethodParameterTypeName(sb, retType);
            }
            foreach (var param in mb.GetParameters()) {
                var paramType = param.ParameterType;
                sb.Append("__");
                if (param.IsOut) {
                    paramType = paramType.GetElementType();
                    sb.Append("O_");
                }
                else if (param.ParameterType.IsByRef) {
                    paramType = paramType.GetElementType();
                    sb.Append("R_");
                }
                CalcMethodParameterTypeName(sb, paramType);
            }
            string tname = t.FullName + ":" + name;
            string sig = sb.ToString().Replace('`', '_');
            return sig;
        }
        static void CalcMethodParameterTypeName(StringBuilder sb, Type type)
        {
            if (type.IsArray) {
                var elementType = type.GetElementType();
                sb.Append("A_");
                CalcMethodParameterTypeName(sb, elementType);
            }
            else {
                sb.Append(type.Name.Replace('.', '_'));
                foreach (var arg in type.GetGenericArguments()) {
                    sb.Append('_');
                    CalcMethodParameterTypeName(sb, arg);
                }
            }
        }

        bool isUniqueArgsCount(MethodBase[] cons, MethodBase mi)
        {
            foreach (MethodBase member in cons) {
                MethodBase m = (MethodBase)member;
                if (m != mi && mi.GetParameters().Length == m.GetParameters().Length)
                    return false;
            }
            return true;
        }


        void WriteCheckSelf(StreamWriter file, Type t)
        {
            if (t.IsValueType) {
                Write(file, "{0} self;", TypeDecl(t));
                if (IsBaseType(t))
                    Write(file, "checkType(l,1,out self);");
                else
                    Write(file, "checkValueType(l,1,out self);");
            }
            else
                Write(file, "{0} self=({0})checkSelf(l);", TypeDecl(t));
        }


        private void WriteFunctionCall(MethodInfo m, StreamWriter file, Type t, BindingFlags bf)
        {
            bool isExtension = IsExtensionMethod(m) && (bf & BindingFlags.Instance) == BindingFlags.Instance;
            bool hasref = false;
            ParameterInfo[] pars = m.GetParameters();


            int argIndex = 1;
            int parOffset = 0;
            if (!m.IsStatic) {
                WriteCheckSelf(file, t);
                argIndex++;
            }
            else if (isExtension) {
                WriteCheckSelf(file, t);
                parOffset++;
            }
            for (int n = parOffset; n < pars.Length; n++) {
                ParameterInfo p = pars[n];
                string pn = p.ParameterType.Name;
                if (pn.EndsWith("&")) {
                    hasref = true;
                }

                bool hasParams = p.IsDefined(typeof(ParamArrayAttribute), false);
                CheckArgument(file, p.ParameterType, n, argIndex, IsOutArg(p), hasParams);
            }

            string ret = "";
            if (m.ReturnType != typeof(void)) {
                ret = "var ret=";
            }

            if (m.IsStatic && !isExtension) {
                if (m.Name == "op_Multiply")
                    Write(file, "{0}a1*a2;", ret);
                else if (m.Name == "op_Subtraction")
                    Write(file, "{0}a1-a2;", ret);
                else if (m.Name == "op_Addition")
                    Write(file, "{0}a1+a2;", ret);
                else if (m.Name == "op_Division")
                    Write(file, "{0}a1/a2;", ret);
                else if (m.Name == "op_UnaryNegation")
                    Write(file, "{0}-a1;", ret);
                else if (m.Name == "op_UnaryPlus")
                    Write(file, "{0}+a1;", ret);
                else if (m.Name == "op_Equality")
                    Write(file, "{0}(a1==a2);", ret);
                else if (m.Name == "op_Inequality")
                    Write(file, "{0}(a1!=a2);", ret);
                else if (m.Name == "op_LessThan")
                    Write(file, "{0}(a1<a2);", ret);
                else if (m.Name == "op_GreaterThan")
                    Write(file, "{0}(a2<a1);", ret);
                else if (m.Name == "op_LessThanOrEqual")
                    Write(file, "{0}(a1<=a2);", ret);
                else if (m.Name == "op_GreaterThanOrEqual")
                    Write(file, "{0}(a2<=a1);", ret);
                else if (m.Name == "op_Implicit")
                    Write(file, "{0} ret={1};", TypeDecl(m.ReturnType), FuncCall(m));
                else if (m.Name == "op_Explicit")
                    Write(file, "var ret=({0}){1};", TypeDecl(m.ReturnType), FuncCall(m));
                else {
                    Write(file, "{3}{2}.{0}({1});", MethodDecl(m), FuncCall(m), TypeDecl(t), ret);
                }
            }
            else if (m.Name == c_DisposeIntfName) {
                Write(file, "{2}((System.IDisposable)self).{0}({1});", c_DisposeName, FuncCall(m, parOffset), ret);
            }
            else {
                Write(file, "{2}self.{0}({1});", MethodDecl(m), FuncCall(m, parOffset), ret);
            }

            WriteOk(file);
            int retcount = 1;
            if (m.ReturnType != typeof(void)) {

                WritePushValue(m.ReturnType, file);
                retcount = 2;
            }


            // push out/ref value for return value
            if (hasref) {
                for (int n = 0; n < pars.Length; n++) {
                    ParameterInfo p = pars[n];

                    if (p.ParameterType.IsByRef) {
                        WritePushValue(p.ParameterType, file, string.Format("a{0}", n + 1));
                        retcount++;
                    }
                }
            }

            if (t.IsValueType && m.ReturnType == typeof(void) && !m.IsStatic) {
                if (t.FullName == "UnityEngine.Color" || t.FullName == "UnityEngine.Quaternion" || t.FullName == "UnityEngine.Vector2" || t.FullName == "UnityEngine.Vector3" || t.FullName == "UnityEngine.Vector4")
                    Write(file, "setBack(l,self);");
                else
                    Write(file, "setBack(l,(object)self);");
            }

            Write(file, "return {0};", retcount);
        }

        string SimpleType(Type t)
        {

            string tn = t.Name;
            switch (tn) {
                case "Single":
                    return "float";
                case "String":
                    return "string";
                case "Double":
                    return "double";
                case "Boolean":
                    return "bool";
                case "Int32":
                    return "int";
                case "Object":
                    return FullName(t);
                default:
                    tn = TypeDecl(t);
                    if (tn.StartsWith("System.Collections.Generic.")) {
                        tn = tn.Replace("System.Collections.Generic.", "");
                    }
                    if (tn.StartsWith("System.Object")) {
                        tn = tn.Replace("System.Object", "object");
                    }
                    return tn;
            }
        }

        void WritePushValue(Type t, StreamWriter file)
        {
            if (t.IsByRef)
                t = t.GetElementType();
            if (t.IsEnum)
                Write(file, "pushEnum(l,(int)ret);");
            else if (t.Name == "BoxedValue")
                Write(file, "pushValue(l,ret.GetObject());");
            else
                Write(file, "pushValue(l,ret);");
        }

        void WritePushValue(Type t, StreamWriter file, string ret)
        {
            if (t.IsByRef)
                t = t.GetElementType();
            if (t.IsEnum)
                Write(file, "pushEnum(l,(int){0});", ret);
            else if (t.Name == "BoxedValue")
                Write(file, "pushValue(l,{0}.GetObject());", ret);
            else
                Write(file, "pushValue(l,{0});", ret);
        }


        void Write(StreamWriter file, string fmt, params object[] args)
        {

            fmt = System.Text.RegularExpressions.Regex.Replace(fmt, @"\r\n?|\n|\r", NewLine);

            if (fmt.StartsWith("}")) indent--;

            for (int n = 0; n < indent; n++)
                file.Write("\t");


            if (args.Length == 0)
                file.WriteLine(fmt);
            else {
                string line = string.Format(fmt, args);
                file.WriteLine(line);
            }

            if (fmt.EndsWith("{")) indent++;
        }

        private bool IsOutArg(ParameterInfo p)
        {
            return (p.IsOut || p.IsDefined(typeof(System.Runtime.InteropServices.OutAttribute), false)) && !p.ParameterType.IsArray;
        }

        private void CheckArgument(StreamWriter file, Type t, int n, int argstart, bool isout, bool isparams)
        {
            Write(file, "{0} a{1};", TypeDecl(t), n + 1);

            if (!isout) {
                if (t.IsByRef) {
                    t = t.GetElementType();
                }
                if (t.IsEnum)
                    Write(file, "checkEnum(l,{0},out a{1});", n + argstart, n + 1);
                else if (t.BaseType == typeof(System.MulticastDelegate)) {
                    tryMake(t);
                    Write(file, "LuaDelegation.checkDelegate(l,{0},out a{1});", n + argstart, n + 1);
                }
                else if (isparams) {
                    if (t.GetElementType().IsValueType && !IsBaseType(t.GetElementType()))
                        Write(file, "checkValueParams(l,{0},out a{1});", n + argstart, n + 1);
                    else
                        Write(file, "checkParams(l,{0},out a{1});", n + argstart, n + 1);
                }
                else if (t.IsArray)
                    Write(file, "checkArray(l,{0},out a{1});", n + argstart, n + 1);
                else if (IsValueType(t)) {
                    if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>))
                        Write(file, "checkNullable(l,{0},out a{1});", n + argstart, n + 1);
                    else
                        Write(file, "checkValueType(l,{0},out a{1});", n + argstart, n + 1);
                }
                else
                    Write(file, "checkType(l,{0},out a{1});", n + argstart, n + 1);
            }
        }

        bool IsValueType(Type t)
        {
            return t.BaseType == typeof(ValueType) && !IsBaseType(t);
        }

        bool IsBaseType(Type t)
        {
            if (t.IsByRef) {
                t = t.GetElementType();
            }
            return t.IsPrimitive || LuaObject.isImplByLua(t);
        }

        string FullName(string str)
        {
            if (str == null) {
                throw new NullReferenceException();
            }
            return RemoveRef(str.Replace("+", "."));
        }

        string TypeDecl(Type t)
        {
            if (t.IsGenericType) {
                string ret = GenericBaseName(t);

                string gs = "";
                gs += "<";
                Type[] types = t.GetGenericArguments();
                for (int n = 0; n < types.Length; n++) {
                    gs += TypeDecl(types[n]);
                    if (n < types.Length - 1)
                        gs += ",";
                }
                gs += ">";

                ret = Regex.Replace(ret, @"`\d+", gs);
                return ret;
            }
            if (t.IsArray) {
                return TypeDecl(t.GetElementType()) + "[]";
            }
            else
                return RemoveRef(t.ToString(), false);
        }

        string ExportName(Type t)
        {
            if (t.IsGenericType) {
                return string.Format("Lua_{0}_{1}", _Name(GenericBaseName(t)), _Name(GenericName(t)));
            }
            else {
                string name = RemoveRef(t.FullName, true);
                name = "Lua_" + name;
                return name.Replace(".", "_");
            }
        }

        string FullName(Type t)
        {
            if (t.FullName == null) {
                Debug.Log(t.Name);
                return t.Name;
            }
            return FullName(t.FullName);
        }

        string FuncCall(MethodBase m, int parOffset = 0)
        {

            string str = "";
            ParameterInfo[] pars = m.GetParameters();
            for (int n = parOffset; n < pars.Length; n++) {
                ParameterInfo p = pars[n];
                if (p.ParameterType.IsByRef) {
                    if (p.IsOut)
                        str += string.Format("out a{0}", n + 1);
                    else if (p.IsIn)
                        str += string.Format("a{0}", n + 1);
                    else
                        str += string.Format("ref a{0}", n + 1);
                }
                else {
                    str += string.Format("a{0}", n + 1);
                }
                if (n < pars.Length - 1)
                    str += ",";
            }
            return str;
        }

    }
}
