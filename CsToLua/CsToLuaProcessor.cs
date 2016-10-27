using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RoslynTool.CsToLua;

namespace RoslynTool.CsToLua
{
    public enum ExitCode : int
    {
        Success = 0,
        SyntaxError = 1,
        SemanticError = 2,
        FileNotFound = 3,
    }
    public static class CsToLuaProcessor
    {
        public static ExitCode Process(string srcFile, string outputExt, IList<string> macros, IDictionary<string, string> _refByNames, IDictionary<string, string> _refByPaths, bool enableInherit)
        {
            string exepath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string path = Path.GetDirectoryName(srcFile);
            string name = Path.GetFileNameWithoutExtension(srcFile);
            string ext = Path.GetExtension(srcFile);

            string logDir = Path.Combine(path, "log");
            if (!Directory.Exists(logDir)) {
                Directory.CreateDirectory(logDir);
            }
            string outputDir = Path.Combine(path, "lua");
            if (!Directory.Exists(outputDir)) {
                Directory.CreateDirectory(outputDir);
            }

            List<string> files = new List<string>();
            Dictionary<string, string> refByNames = new Dictionary<string, string>(_refByNames);
            Dictionary<string, string> refByPaths = new Dictionary<string, string>(_refByPaths);
            if (ext == ".csproj") {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(srcFile);
                var nodes = SelectNodes(xmlDoc, "ItemGroup", "Reference");
                foreach (XmlElement node in nodes) {
                    var aliasesNode = SelectSingleNode(node, "Aliases");
                    var pathNode = SelectSingleNode(node, "HintPath");
                    if (null != pathNode) {
                        if (null != aliasesNode)
                            refByPaths.Add(pathNode.InnerText, aliasesNode.InnerText);
                        else
                            refByPaths.Add(pathNode.InnerText, "global");
                    } else {
                        string val = node.GetAttribute("Include");
                        if (!string.IsNullOrEmpty(val)) {
                            if (null != aliasesNode)
                                refByNames.Add(val, aliasesNode.InnerText);
                            else
                                refByNames.Add(val, "global");
                        }
                    }
                }
                nodes = SelectNodes(xmlDoc, "ItemGroup", "ProjectReference");
                foreach (XmlElement node in nodes) {
                    string val = node.GetAttribute("Include");
                    var nameNode = SelectSingleNode(node, "Name");
                    if (null != nameNode) {
                        refByPaths.Add(string.Format("bin/Debug/{0}.dll", nameNode.InnerText), "global");
                    }
                }
                nodes = SelectNodes(xmlDoc, "ItemGroup", "Compile");
                foreach (XmlElement node in nodes) {
                    string val = node.GetAttribute("Include");
                    if (!string.IsNullOrEmpty(val) && val.EndsWith(".cs"))
                        files.Add(val);
                }
            } else {
                files.Add(srcFile);
            }

            bool haveError = false;
            List<SyntaxTree> trees = new List<SyntaxTree>();
            using (StreamWriter sw = new StreamWriter(Path.Combine(logDir, "SyntaxError.log"))) {
                using (StreamWriter sw2 = new StreamWriter(Path.Combine(logDir, "SyntaxWarning.log"))) {
                    foreach (string file in files) {
                        string filePath = Path.Combine(path, file);
                        string fileName = Path.GetFileNameWithoutExtension(filePath);
                        CSharpParseOptions options = new CSharpParseOptions();
                        options = options.WithPreprocessorSymbols(macros);
                        options = options.WithFeatures(new Dictionary<string, string> { { "IOperation", "true" } });
                        SyntaxTree tree = CSharpSyntaxTree.ParseText(File.ReadAllText(filePath), options, filePath);
                        trees.Add(tree);

                        var diags = tree.GetDiagnostics();
                        bool firstError = true;
                        bool firstWarning = true;
                        foreach (var diag in diags) {
                            if (diag.Severity == DiagnosticSeverity.Error) {
                                if (firstError) {
                                    sw.WriteLine("============<<<Syntax Error:{0}>>>============", fileName);
                                    firstError = false;
                                }
                                string msg = diag.ToString();
                                sw.WriteLine("{0}", msg);
                                haveError = true;
                            } else {
                                if (firstWarning) {
                                    sw2.WriteLine("============<<<Syntax Warning:{0}>>>============", fileName);
                                    firstWarning = false;
                                }
                                string msg = diag.ToString();
                                sw2.WriteLine("{0}", msg);
                            }
                        }
                    }
                    sw2.Close();
                }
                sw.Close();
            }
            if (haveError) {
                Console.WriteLine("{0}", File.ReadAllText(Path.Combine(logDir, "SemanticError.log")));
                return ExitCode.SyntaxError;
            }

            List<MetadataReference> refs = new List<MetadataReference>();
            refs.Add(MetadataReference.CreateFromFile(typeof(object).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(System.Reflection.Metadata.AssemblyDefinition).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(Cs2Lua.IgnoreAttribute).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(List<>).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(Dictionary<,>).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(Queue<>).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(HashSet<>).Assembly.Location));
            /*
            refs.Add(MetadataReference.CreateFromFile(typeof(System.Collections.Immutable.ImmutableArray).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(SyntaxTree).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(CSharpSyntaxTree).Assembly.Location));
            */
            foreach (var pair in refByPaths) {
                string fullPath = Path.Combine(path, pair.Key);
                var arr = System.Collections.Immutable.ImmutableArray.Create(pair.Value);
                refs.Add(MetadataReference.CreateFromFile(fullPath, new MetadataReferenceProperties(MetadataImageKind.Assembly, arr)));
            }
            foreach (var pair in refByNames) {
#pragma warning disable 618
                Assembly assembly = Assembly.LoadWithPartialName(pair.Key);
#pragma warning restore 618
                if (null != assembly) {
                    var arr = System.Collections.Immutable.ImmutableArray.Create(pair.Value);
                    refs.Add(MetadataReference.CreateFromFile(assembly.Location, new MetadataReferenceProperties(MetadataImageKind.Assembly, arr)));
                }
            }
            List<SyntaxTree> newTrees = new List<SyntaxTree>();
            CSharpCompilationOptions compilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
            CSharpCompilation compilation = CSharpCompilation.Create(name);
            compilation = compilation.WithOptions(compilationOptions);
            compilation = compilation.AddReferences(refs.ToArray());
            foreach (SyntaxTree tree in trees) {
                LuaKeywordsReplacer replacer = new LuaKeywordsReplacer();
                var newRoot = replacer.Visit(tree.GetRoot()) as CSharpSyntaxNode;
                var newTree = CSharpSyntaxTree.Create(newRoot, tree.Options as CSharpParseOptions, tree.FilePath, tree.Encoding);
                newTrees.Add(newTree);
                compilation = compilation.AddSyntaxTrees(newTree);
            }
            bool haveSemanticError = false;
            bool haveTranslationError = false;
            SymbolTable symTable = new SymbolTable(compilation);
            Dictionary<string, MergedClassInfo> toplevelClasses = new Dictionary<string, MergedClassInfo>();
            MergedNamespaceInfo toplevelMni = new MergedNamespaceInfo();
            using (StreamWriter sw = new StreamWriter(Path.Combine(logDir, "SemanticError.log"))) {
                using (StreamWriter sw2 = new StreamWriter(Path.Combine(logDir, "SemanticWarning.log"))) {
                    using (StreamWriter sw3 = new StreamWriter(Path.Combine(logDir, "Translation.log"))) {
                        foreach (SyntaxTree tree in newTrees) {
                            string fileName = Path.GetFileNameWithoutExtension(tree.FilePath);
                            var root = tree.GetRoot();
                            SemanticModel model = compilation.GetSemanticModel(tree, true);

                            var diags = model.GetDiagnostics();
                            bool firstError = true;
                            bool firstWarning = true;
                            foreach (var diag in diags) {
                                if (diag.Severity == DiagnosticSeverity.Error) {
                                    if (firstError) {
                                        sw.WriteLine("============<<<Semantic Error:{0}>>>============", fileName);
                                        firstError = false;
                                    }
                                    string msg = diag.ToString();
                                    sw.WriteLine("{0}", msg);
                                    haveSemanticError = true;
                                } else {
                                    if (firstWarning) {
                                        sw2.WriteLine("============<<<Semantic Warning:{0}>>>============", fileName);
                                        firstWarning = false;
                                    }
                                    string msg = diag.ToString();
                                    sw2.WriteLine("{0}", msg);
                                }
                            }

                            CsLuaTranslater csToLua = new CsLuaTranslater(model, symTable, enableInherit);
                            csToLua.Translate(root);
                            if (csToLua.HaveError) {
                                sw3.WriteLine("============<<<Translation Error:{0}>>>============", fileName);
                                csToLua.SaveLog(sw3);
                                haveTranslationError = true;
                            }

                            foreach (var pair in csToLua.ToplevelClasses) {
                                var key = pair.Key;
                                var cis = pair.Value;

                                foreach (var ci in cis) {
                                    AddMergedClasses(toplevelClasses, key, ci);
                                }

                                string[] nss = key.Split('.');
                                AddMergedNamespaces(toplevelMni, nss);
                            }
                        }
                        sw3.Close();
                    }
                    sw2.Close();
                }
                sw.Close();
            }
            HashSet<string> lualibRefs = new HashSet<string>();
            StringBuilder nsBuilder = new StringBuilder();
            BuildNamespaces(nsBuilder, toplevelMni);
            File.Copy(Path.Combine(exepath, "lualib/utility.lua"), Path.Combine(outputDir, string.Format("cs2lua_utility.{0}", outputExt)), true);
            File.WriteAllText(Path.Combine(outputDir, string.Format("cs2lua_namespaces.{0}", outputExt)), nsBuilder.ToString());
            foreach (var pair in toplevelClasses) {
                StringBuilder classBuilder = new StringBuilder();
                lualibRefs.Clear();
                string fileName = BuildLuaClass(classBuilder, pair.Key, pair.Value, symTable, lualibRefs);
                foreach (string lib in lualibRefs) {
                    File.Copy(Path.Combine(exepath, "lualib/" + lib), Path.Combine(outputDir, string.Format("{0}.{1}", lib, outputExt)), true);
                }
                File.WriteAllText(Path.Combine(outputDir, Path.ChangeExtension(fileName, outputExt)), classBuilder.ToString());
            }
            StringBuilder allClassBuilder = new StringBuilder();
            lualibRefs.Clear();
            BuildLuaClass(allClassBuilder, toplevelMni, toplevelClasses, symTable, lualibRefs);
            if (haveSemanticError || haveTranslationError) {
                if (haveSemanticError) {
                    Console.WriteLine("{0}", File.ReadAllText(Path.Combine(logDir, "SemanticError.log")));
                }
                if (haveTranslationError) {
                    Console.WriteLine("{0}", File.ReadAllText(Path.Combine(logDir, "Translation.log")));
                }
                return ExitCode.SemanticError;
            } else {
                Console.Write(allClassBuilder.ToString());
                return ExitCode.Success;
            }
        }

        private static void AddMergedClasses(Dictionary<string, MergedClassInfo> mergedClasses, string key, ClassInfo ci)
        {
            MergedClassInfo mci;
            if (!mergedClasses.TryGetValue(key, out mci)) {
                mci = new MergedClassInfo();
                mergedClasses.Add(key, mci);
                mci.Key = key;
            }
            mci.Classes.Add(ci);

            foreach (var pair in ci.InnerClasses) {
                AddMergedClasses(mci.InnerClasses, pair.Key, pair.Value);
            }
        }
        private static void AddMergedNamespaces(MergedNamespaceInfo toplevelMni, params string[] nss)
        {
            MergedNamespaceInfo curMni = toplevelMni;
            for (int i = 0; i < nss.Length - 1; ++i) {
                string nsname = nss[i];
                MergedNamespaceInfo mni;
                if (!curMni.Namespaces.TryGetValue(nsname, out mni)) {
                    mni = new MergedNamespaceInfo();
                    curMni.Namespaces.Add(nsname, mni);
                }
                mni.Name = nsname;
                curMni = mni;
            }
        }
        private static void BuildNamespaces(StringBuilder sb, MergedNamespaceInfo mni)
        {
            BuildNamespacesRecursively(sb, mni, 0);
        }
        private static void BuildNamespacesRecursively(StringBuilder sb, MergedNamespaceInfo mni, int indent)
        {
            if (null != mni) {
                string nsname = mni.Name;
                if (!string.IsNullOrEmpty(nsname)) {
                    sb.AppendFormat("{0}{1} = {{", GetIndentString(indent), nsname);
                    sb.AppendLine();
                    ++indent;
                }
                foreach (var npair in mni.Namespaces) {
                    var newMni = npair.Value;
                    BuildNamespacesRecursively(sb, newMni, indent);
                }
                if (!string.IsNullOrEmpty(nsname)) {
                    --indent;
                    sb.AppendFormat("{0}}}", GetIndentString(indent));
                    if (indent > 0) {
                        sb.Append(",");
                    } else {
                        sb.Append(";");
                    }
                    sb.AppendLine();
                }
            }
        }
        private static void BuildLuaClass(StringBuilder sb, MergedNamespaceInfo toplevelMni, Dictionary<string, MergedClassInfo> toplevelMcis, SymbolTable symTable, HashSet<string> lualibRefs)
        {
            StringBuilder code = new StringBuilder();
            BuildNamespaces(code, toplevelMni);
            foreach (var pair in toplevelMcis) {
                StringBuilder classBuilder = new StringBuilder();
                string fileName = BuildLuaClass(classBuilder, pair.Key, pair.Value, false, symTable, lualibRefs);
                code.Append(classBuilder.ToString());
            }
            sb.AppendLine("require \"cs2lua_utility\";");
            foreach (string lib in lualibRefs) {
                sb.AppendFormat("require \"{0}\";", lib);
                sb.AppendLine();
            }
            sb.Append(code.ToString());
        }
        private static string BuildLuaClass(StringBuilder sb, string key, MergedClassInfo mci, SymbolTable symTable, HashSet<string> lualibRefs)
        {
            return BuildLuaClass(sb, key, mci, true, symTable, lualibRefs);
        }
        private static string BuildLuaClass(StringBuilder sb, string key, MergedClassInfo mci, bool isAlone, SymbolTable symTable, HashSet<string> lualibRefs)
        {
            var classes = mci.Classes;

            string fileName = key.Replace('.', '_');

            bool isStaticClass = false;
            bool isEnumClass = false;
            bool haveCctor = false;
            bool haveCtor = false;
            bool generateBasicCctor = false;
            bool generateBasicCtor = false;
            bool generateTypeParamFields = false;
            string baseClass = string.Empty;
            ClassSymbolInfo csi;
            if (symTable.ClassSymbols.TryGetValue(key, out csi)) {
                haveCctor = csi.ExistStaticConstructor;
                haveCtor = csi.ExistConstructor;
                generateBasicCctor = csi.GenerateBasicCctor;
                generateBasicCtor = csi.GenerateBasicCtor;
                generateTypeParamFields = csi.GenerateTypeParamFields;
                baseClass = csi.BaseClassKey;
                isStaticClass = csi.TypeSymbol.IsStatic;
                isEnumClass = csi.TypeSymbol.TypeKind == TypeKind.Enum;
            }
            bool myselfDefinedBaseClass = csi.TypeSymbol.BaseType.ContainingAssembly == symTable.AssemblySymbol;
            string genericTypeParamNames = string.Join(", ", csi.GenericTypeParamNames.ToArray());

            //按目标类重新组织扩展代码
            Dictionary<string, List<StringBuilder>> classExternsions = new Dictionary<string, List<StringBuilder>>();
            foreach (var ci in classes) {
                foreach (var pair in ci.ExtensionCodeBuilders) {
                    List<StringBuilder> list;
                    if (!classExternsions.TryGetValue(pair.Key, out list)) {
                        list = new List<StringBuilder>();
                        classExternsions.Add(pair.Key, list);
                    }
                    list.Add(pair.Value);
                }
            }

            HashSet<string> requiredlibs = new HashSet<string>();
            HashSet<string> lualibs;
            if (symTable.Requires.TryGetValue(key, out lualibs)) {
                foreach (string lib in lualibs) {
                    if (!lualibRefs.Contains(lib)) {
                        lualibRefs.Add(lib);
                    }
                    if (!requiredlibs.Contains(lib)) {
                        requiredlibs.Add(lib);
                    }
                }
            }
            foreach (var ci in classes) {
                foreach (string r in ci.IgnoreReferences) {
                    if (symTable.Requires.TryGetValue(r, out lualibs)) {
                        foreach (string lib in lualibs) {
                            if (!lualibRefs.Contains(lib)) {
                                lualibRefs.Add(lib);
                            }
                            if (!requiredlibs.Contains(lib)) {
                                requiredlibs.Add(lib);
                            }
                        }
                    }
                }
            }
            
            bool isEntryClass = false;
            string exportConstructor = string.Empty;
            MethodInfo exportConstructorInfo = null;
            foreach (var ci in classes) {
                sb.Append(ci.BeforeOuterCodeBuilder.ToString());
                if (ci.IsEntryClass)
                    isEntryClass = true;
                if (!string.IsNullOrEmpty(ci.ExportConstructor)) {
                    exportConstructor = ci.ExportConstructor;
                    exportConstructorInfo = ci.ExportConstructorInfo;
                }                
            }

            HashSet<string> refs = new HashSet<string>();
            if (isAlone) {
                sb.AppendLine("require \"cs2lua_utility\";");
                sb.AppendLine("require \"cs2lua_namespaces\";");
                foreach (string lib in requiredlibs) {
                    sb.AppendFormat("require \"{0}\";", lib);
                    sb.AppendLine();
                    refs.Add(lib);
                }

                //references
                foreach (var ci in classes) {
                    foreach (string r in ci.References) {
                        if (!r.StartsWith("System.") && !r.StartsWith("UnityEngine.")) {
                            string refname = r.Replace('.', '_');
                            if (!refs.Contains(refname)) {
                                sb.AppendFormat("require \"{0}\";", refname);
                                sb.AppendLine();
                                refs.Add(refname);
                            }
                        }
                    }
                }

                /*
                foreach (var pair in csi.ExtensionClasses) {
                    string refname = pair.Key;
                    if (!refs.Contains(refname)) {
                        sb.AppendFormat("require \"{0}\";", refname);
                        sb.AppendLine();
                        refs.Add(refname);
                    }
                }
                */
            }
            
            sb.AppendLine();

            int indent = 0;
            sb.AppendFormat("{0}{1} = {{", GetIndentString(indent), key);
            sb.AppendLine();
            ++indent;

            if (!isEnumClass) {
                //static function
                foreach (var ci in classes) {
                    sb.Append(ci.StaticFunctionCodeBuilder.ToString());
                }

                if (!haveCctor) {
                    sb.AppendFormat("{0}cctor = function()", GetIndentString(indent));
                    sb.AppendLine();
                    ++indent;
                    if (!string.IsNullOrEmpty(baseClass) && myselfDefinedBaseClass) {
                        sb.AppendFormat("{0}{1}.cctor(this);", GetIndentString(indent), baseClass);
                        sb.AppendLine();
                    }
                    if (generateBasicCctor) {
                        sb.AppendFormat("{0}{1}.__cctor();", GetIndentString(indent), key);
                        sb.AppendLine();
                    }
                    --indent;
                    sb.AppendFormat("{0}end,", GetIndentString(indent));
                    sb.AppendLine();
                }
                if (generateBasicCctor) {
                    sb.AppendFormat("{0}__cctor = function()", GetIndentString(indent));
                    sb.AppendLine();
                    ++indent;
                    sb.AppendFormat("{0}if {1}.__cctor_called then", GetIndentString(indent), key);
                    sb.AppendLine();
                    ++indent;
                    sb.AppendFormat("{0}return;", GetIndentString(indent));
                    sb.AppendLine();
                    --indent;
                    sb.AppendFormat("{0}else", GetIndentString(indent));
                    sb.AppendLine();
                    ++indent;
                    sb.AppendFormat("{0}{1}.__cctor_called = true;", GetIndentString(indent), key);
                    sb.AppendLine();
                    --indent;
                    sb.AppendFormat("{0}end", GetIndentString(indent));
                    sb.AppendLine();

                    --indent;
                    //static initializer
                    foreach (var ci in classes) {
                        sb.Append(ci.StaticInitializerCodeBuilder.ToString());
                    }
                    sb.AppendFormat("{0}end,", GetIndentString(indent));
                    sb.AppendLine();
                }

                sb.AppendLine();
            }
            
            //static field
            foreach (var ci in classes) {
                sb.Append(ci.StaticFieldCodeBuilder.ToString());
            }

            if (!isEnumClass) {
                if (generateBasicCctor) {
                    sb.AppendFormat("{0}__cctor_called = false,", GetIndentString(indent));
                    sb.AppendLine();
                }

                sb.AppendLine();

                if (!isStaticClass) {
                    sb.AppendFormat("{0}__new_object = function(...)", GetIndentString(indent));
                    sb.AppendLine();
                    ++indent;

                    if (string.IsNullOrEmpty(exportConstructor)) {
                        sb.AppendFormat("{0}return newobject({1}, nil, {{}}, ...);", GetIndentString(indent), key);
                        sb.AppendLine();
                    } else {
                        //处理ref/out参数
                        if (exportConstructorInfo.ReturnParamNames.Count > 0) {
                            sb.AppendFormat("{0}local args = ...;", GetIndentString(indent));
                            sb.AppendLine();
                            sb.AppendFormat("{0}return (function() ", GetIndentString(indent));
                            string retArgStr = string.Join(", ", exportConstructorInfo.ReturnParamNames.ToArray());
                            sb.Append("local obj");
                            if (exportConstructorInfo.ReturnParamNames.Count > 0) {
                                sb.Append(", ");
                                sb.Append(retArgStr);
                            }
                            sb.AppendFormat(" = newobject({0}, \"{1}\", {{}}, args); return obj; end)();", key, exportConstructor);
                            sb.AppendLine();
                        } else {
                            sb.AppendFormat("{0}return newobject({1}, \"{2}\", {{}}, args);", GetIndentString(indent), key, exportConstructor);
                            sb.AppendLine();
                        }
                    }

                    --indent;
                    sb.AppendFormat("{0}end,", GetIndentString(indent));
                    sb.AppendLine();
                }

                sb.AppendFormat("{0}__define_class = function()", GetIndentString(indent));
                sb.AppendLine();
                ++indent;

                foreach (var pair in classExternsions) {
                    sb.AppendFormat("{0}{1}.__install_{2} = function(obj)", GetIndentString(indent), pair.Key, fileName);
                    sb.AppendLine();
                    ++indent;
                    foreach (var builder in pair.Value) {
                        sb.AppendFormat(builder.ToString());
                    }
                    --indent;
                    sb.AppendFormat("{0}end", GetIndentString(indent));
                    sb.AppendLine();
                }

                sb.AppendFormat("{0}local static = {1};", GetIndentString(indent), key);
                sb.AppendLine();

                sb.AppendLine();

                sb.AppendFormat("{0}local static_props = {{", GetIndentString(indent));
                sb.AppendLine();

                ++indent;

                //static property
                foreach (var ci in classes) {
                    sb.Append(ci.StaticPropertyCodeBuilder.ToString());
                }

                --indent;
                sb.AppendFormat("{0}}};", GetIndentString(indent));
                sb.AppendLine();

                sb.AppendLine();

                sb.AppendFormat("{0}local static_events = {{", GetIndentString(indent));
                sb.AppendLine();

                ++indent;

                //static event
                foreach (var ci in classes) {
                    sb.Append(ci.StaticEventCodeBuilder.ToString());
                }

                --indent;
                sb.AppendFormat("{0}}};", GetIndentString(indent));
                sb.AppendLine();

                sb.AppendLine();

                if (!isStaticClass) {
                    sb.AppendFormat("{0}local instance = {{", GetIndentString(indent));
                    sb.AppendLine();
                    ++indent;

                    //instance function
                    foreach (var ci in classes) {
                        sb.Append(ci.InstanceFunctionCodeBuilder.ToString());
                    }

                    if (!haveCtor) {
                        sb.AppendFormat("{0}ctor = function(this{1}{2})", GetIndentString(indent), string.IsNullOrEmpty(genericTypeParamNames) ? string.Empty : ", ", genericTypeParamNames);
                        sb.AppendLine();
                        ++indent;
                        if (!string.IsNullOrEmpty(baseClass) && myselfDefinedBaseClass) {
                            sb.AppendFormat("{0}base.ctor(this);", GetIndentString(indent));
                            sb.AppendLine();
                        }
                        if (generateBasicCtor) {
                            sb.AppendFormat("{0}this:__ctor({1});", GetIndentString(indent), genericTypeParamNames);
                            sb.AppendLine();
                        }
                        --indent;
                        sb.AppendFormat("{0}end,", GetIndentString(indent));
                        sb.AppendLine();
                    }
                    if (generateBasicCtor) {
                        sb.AppendFormat("{0}__ctor = function(this{1}{2})", GetIndentString(indent), string.IsNullOrEmpty(genericTypeParamNames) ? string.Empty : ", ", genericTypeParamNames);
                        sb.AppendLine();
                        ++indent;
                        sb.AppendFormat("{0}if this.__ctor_called then", GetIndentString(indent));
                        sb.AppendLine();
                        ++indent;
                        sb.AppendFormat("{0}return;", GetIndentString(indent));
                        sb.AppendLine();
                        --indent;
                        sb.AppendFormat("{0}else", GetIndentString(indent));
                        sb.AppendLine();
                        ++indent;
                        sb.AppendFormat("{0}this.__ctor_called = true;", GetIndentString(indent));
                        sb.AppendLine();
                        --indent;
                        sb.AppendFormat("{0}end", GetIndentString(indent));
                        sb.AppendLine();
                        if (generateTypeParamFields) {
                            sb.AppendFormat("{0}this.__type_params = ", GetIndentString(indent));
                            sb.Append("{");
                            sb.Append(genericTypeParamNames);
                            sb.Append("};");
                        }
                        foreach (var pair in csi.ExtensionClasses) {
                            string refname = pair.Key;
                            sb.AppendFormat("{0}{1}.__install_{2}(this);", GetIndentString(indent), key, refname.Replace(".", "_"));
                            sb.AppendLine();
                        }
                        --indent;
                        //instance initializer
                        foreach (var ci in classes) {
                            sb.Append(ci.InstanceInitializerCodeBuilder.ToString());
                        }
                        sb.AppendFormat("{0}end,", GetIndentString(indent));
                        sb.AppendLine();
                    }

                    sb.AppendLine();

                    //instance field
                    foreach (var ci in classes) {
                        sb.Append(ci.InstanceFieldCodeBuilder.ToString());
                    }

                    if (generateBasicCtor) {
                        sb.AppendFormat("{0}__ctor_called = false,", GetIndentString(indent));
                        sb.AppendLine();
                    }
                    if (generateTypeParamFields) {
                        sb.AppendFormat("{0}__type_params = nil,", GetIndentString(indent));
                        sb.AppendLine();
                    }

                    --indent;
                    sb.AppendFormat("{0}}};", GetIndentString(indent));
                    sb.AppendLine();

                    sb.AppendLine();

                    sb.AppendFormat("{0}local instance_props = {{", GetIndentString(indent));
                    sb.AppendLine();

                    ++indent;

                    //instance property
                    foreach (var ci in classes) {
                        sb.Append(ci.InstancePropertyCodeBuilder.ToString());
                    }

                    --indent;
                    sb.AppendFormat("{0}}};", GetIndentString(indent));
                    sb.AppendLine();

                    sb.AppendLine();

                    sb.AppendFormat("{0}local instance_events = {{", GetIndentString(indent));
                    sb.AppendLine();

                    ++indent;

                    //instance event
                    foreach (var ci in classes) {
                        sb.Append(ci.InstanceEventCodeBuilder.ToString());
                    }

                    --indent;
                    sb.AppendFormat("{0}}};", GetIndentString(indent));
                    sb.AppendLine();

                    sb.AppendLine();
                    
                    sb.AppendFormat("{0}return defineclass({1}, {2}, static, static_props, static_events, instance, instance_props, instance_events);", GetIndentString(indent), string.IsNullOrEmpty(baseClass) ? "nil" : baseClass, myselfDefinedBaseClass ? "false" : "true");
                    sb.AppendLine();
                } else {
                    sb.AppendFormat("{0}return defineclass({1}, {2}, static, static_props, static_events, nil, nil, nil);", GetIndentString(indent), string.IsNullOrEmpty(baseClass) ? "nil" : baseClass, myselfDefinedBaseClass ? "false" : "true");
                    sb.AppendLine();
                }

                --indent;
                sb.AppendFormat("{0}end,", GetIndentString(indent));
                sb.AppendLine();
            }

            --indent;
            sb.AppendFormat("{0}}}", GetIndentString(indent));
            if (indent > 0) {
                sb.Append(",");
            } else {
                sb.Append(";");
            }
            sb.AppendLine();

            if (!isEnumClass) {
                sb.AppendLine();
                sb.AppendLine();
                sb.AppendFormat("{0}.__define_class();", key);
                sb.AppendLine();
                sb.AppendLine();
                if (isEntryClass) {
                    sb.AppendFormat("defineentry({0});", key);
                    sb.AppendLine();
                }
            }

            foreach (var ci in classes) {
                sb.Append(ci.AfterOuterCodeBuilder.ToString());
            }

            if (!isEnumClass) {
                foreach (var pair in mci.InnerClasses) {
                    BuildLuaClass(sb, pair.Key, pair.Value, false, symTable, lualibRefs);
                }
            }

            return fileName;
        }
        private static string GetIndentString(int indent)
        {
            return CsLuaTranslater.GetIndentString(indent);
        }

        private static List<XmlElement> SelectNodes(XmlNode node, params string[] names)
        {
            return SelectNodesRecursively(node, 0, names);
        }
        private static List<XmlElement> SelectNodesRecursively(XmlNode node, int index, params string[] names)
        {
            string name = names[index];
            List<XmlElement> list = new List<XmlElement>();
            foreach (var cnode in node.ChildNodes) {
                var element = cnode as XmlElement;
                if (null != element) {
                    if (element.Name == name) {
                        if (index < names.Length - 1) {
                            list.AddRange(SelectNodesRecursively(element, index + 1, names));
                        } else {
                            list.Add(element);
                        }
                    } else if (index == 0) {
                        list.AddRange(SelectNodesRecursively(element, index, names));
                    }
                }
            }
            return list;
        }
        private static XmlElement SelectSingleNode(XmlNode node, params string[] names)
        {
            return SelectSingleNodeRecursively(node, 0, names);
        }
        private static XmlElement SelectSingleNodeRecursively(XmlNode node, int index, params string[] names)
        {
            XmlElement ret = null;
            string name = names[index];
            foreach (var cnode in node.ChildNodes) {
                var element = cnode as XmlElement;
                if (null != element) {
                    if (element.Name == name) {
                        if (index < names.Length - 1) {
                            ret = SelectSingleNodeRecursively(element, index + 1, names);
                        } else {
                            ret = element;
                        }
                    } else if (index == 0) {
                        ret = SelectSingleNodeRecursively(element, index, names);
                    }
                    if (null != ret) {
                        break;
                    }
                }
            }
            return ret;
        }
    }
}
