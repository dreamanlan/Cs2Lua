using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RoslynTool.CsToLua;

namespace RoslynTool.CsToLua
{
    public static class CsToLuaProcessor
    {
        public static void Process(string srcFile, string outputExt, IList<string> macros, IDictionary<string, string> _refByNames, IDictionary<string, string> _refByPaths)
        {
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
                foreach (string file in files) {
                    string filePath = Path.Combine(path, file);
                    string fileName = Path.GetFileNameWithoutExtension(filePath);
                    CSharpParseOptions options = new CSharpParseOptions();
                    options = options.WithPreprocessorSymbols(macros);
                    options = options.WithFeatures(new Dictionary<string, string> { { "IOperation", "true" } });
                    SyntaxTree tree = CSharpSyntaxTree.ParseText(File.ReadAllText(filePath), options, filePath);
                    trees.Add(tree);

                    var diags = tree.GetDiagnostics();
                    bool first = true;
                    foreach (var diag in diags) {
                        if (first) {
                            sw.WriteLine("============<<<Syntax Error:{0}>>>============", fileName);
                            first = false;
                        }
                        string msg = diag.ToString();
                        sw.WriteLine("{0}", msg);
                        haveError = true;
                    }
                }
                sw.Close();
            }
            if (haveError) {
                return;
            }

            List<MetadataReference> refs = new List<MetadataReference>();
            refs.Add(MetadataReference.CreateFromFile(typeof(object).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(System.Reflection.Metadata.AssemblyDefinition).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(Cs2Lua.IgnoreAttribute).Assembly.Location));
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
            CSharpCompilationOptions compilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
            CSharpCompilation compilation = CSharpCompilation.Create(name);
            compilation = compilation.WithOptions(compilationOptions);
            compilation = compilation.AddReferences(refs.ToArray());
            foreach (SyntaxTree tree in trees) {
                compilation = compilation.AddSyntaxTrees(tree);
            }
            SymbolTable symTable = new SymbolTable(compilation.Assembly);
            Dictionary<string, List<ClassInfo>> classes = new Dictionary<string, List<ClassInfo>>();
            MergedNamespaceInfo toplevelMni = new MergedNamespaceInfo();
            using (StreamWriter sw = new StreamWriter(Path.Combine(logDir, "SemanticError.log"))) {
                using (StreamWriter sw2 = new StreamWriter(Path.Combine(logDir, "Translation.log"))) {
                    foreach (SyntaxTree tree in trees) {
                        string fileName = Path.GetFileNameWithoutExtension(tree.FilePath);
                        var root = tree.GetRoot();
                        SemanticModel model = compilation.GetSemanticModel(tree, true);

                        var diags = model.GetDiagnostics();
                        bool first = true;
                        foreach (var diag in diags) {
                            if (first) {
                                sw.WriteLine("============<<<Semantic Error:{0}>>>============", fileName);
                                first = false;
                            }
                            string msg = diag.ToString();
                            sw.WriteLine("{0}", msg);
                        }

                        CsLuaTranslater csToLua = new CsLuaTranslater(model, symTable);
                        csToLua.Translate(root);
                        if (csToLua.HaveError) {
                            sw2.WriteLine("============<<<Translation Error:{0}>>>============", fileName);
                            csToLua.SaveLog(sw2);
                        }

                        foreach (var pair in csToLua.ToplevelClasses) {
                            var key = pair.Key;
                            var ci = pair.Value;

                            List<ClassInfo> list;
                            if (!classes.TryGetValue(key, out list)) {
                                list = new List<ClassInfo>();
                                classes.Add(key, list);
                            }
                            list.Add(ci);

                            string[] nss = key.Split('.');
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
                            MergedClassInfo mci;
                            if (!curMni.Classes.TryGetValue(key, out mci)) {
                                mci = new MergedClassInfo();
                                mci.Key = key;
                                curMni.Classes.Add(key, mci);
                            }
                            mci.Classes.Add(ci);
                        }
                    }
                    sw2.Close();
                }
                sw.Close();
            }
            foreach (var pair in classes) {
                StringBuilder sb0 = new StringBuilder();
                string fileName = BuildLuaClass(sb0, pair.Key, pair.Value, true, symTable);
                File.WriteAllText(Path.Combine(outputDir, Path.ChangeExtension(fileName, outputExt)), sb0.ToString());
            }
            StringBuilder sb = new StringBuilder();
            BuildLuaClass(sb, toplevelMni, symTable);
            Console.Write(sb.ToString());
        }

        private static void BuildLuaClass(StringBuilder sb, MergedNamespaceInfo toplevelMni, SymbolTable symTable)
        {
            sb.AppendLine("require \"utility\";");
            BuildLuaClassRecursively(sb, toplevelMni, 0, symTable);
        }
        private static void BuildLuaClassRecursively(StringBuilder sb, MergedNamespaceInfo mni, int indent, SymbolTable symTable)
        {
            if (null != mni) {
                string nsname = mni.Name;
                if (!string.IsNullOrEmpty(nsname)) {
                    sb.AppendFormat("{0}{1} = {{", GetIndentString(indent), nsname);
                    sb.AppendLine();
                    ++indent;
                }
                foreach (var cpair in mni.Classes) {
                    var mci = cpair.Value;
                    BuildLuaClass(sb, mci, symTable);
                }
                foreach (var npair in mni.Namespaces) {
                    var newMni = npair.Value;
                    BuildLuaClassRecursively(sb, newMni, indent, symTable);
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
        private static void BuildLuaClass(StringBuilder sb, MergedClassInfo mci, SymbolTable symTable)
        {
            BuildLuaClass(sb, mci.Key, mci.Classes, false, symTable);
        }
        private static string BuildLuaClass(StringBuilder sb, string key, IList<ClassInfo> classes, bool isAlone, SymbolTable symTable)
        {
            string fileName = key.Replace('.', '_');
            string[] nss = key.Split('.');
            string className = nss[nss.Length - 1];

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
            if (isAlone) {
                sb.AppendLine("require \"utility\";");
                HashSet<string> refs = new HashSet<string>();
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
            }
            
            sb.AppendLine();

            int indent = 0;
            for (int i = 0; i < nss.Length - 1; ++i) {
                if (isAlone) {
                    sb.AppendFormat("{0}{1} = {{", GetIndentString(indent), nss[i]);
                    sb.AppendLine();
                }
                ++indent;
            }

            sb.AppendFormat("{0}{1} = {{", GetIndentString(indent), className);
            sb.AppendLine();
            ++indent;

            //static function
            foreach (var ci in classes) {
                sb.Append(ci.StaticFunctionSourceCodeBuilder.ToString());
            }
            sb.AppendLine();
            //static field
            foreach (var ci in classes) {
                sb.Append(ci.StaticFieldSourceCodeBuilder.ToString());
            }
            sb.AppendLine();

            if (classes.Count > 0 && !classes[0].IsEnum) {

                sb.AppendFormat("{0}newObject = function(...)", GetIndentString(indent));
                sb.AppendLine();
                ++indent;

                if (string.IsNullOrEmpty(exportConstructor)) {
                    sb.AppendFormat("{0}return newobject({1}, (function(obj) return obj; end));", GetIndentString(indent), key);
                    sb.AppendLine();
                } else {
                    //处理ref/out参数
                    sb.AppendFormat("{0}local args = ...;", GetIndentString(indent));
                    sb.AppendLine();
                    sb.AppendFormat("{0}return newobject({1}, (function(obj)", GetIndentString(indent), key);
                    string retArgStr = string.Join(", ", exportConstructorInfo.ReturnParamNames.ToArray());
                    if (exportConstructorInfo.ReturnParamNames.Count > 0) {
                        sb.AppendFormat(" local {0};", retArgStr);
                    }
                    sb.Append(" obj");
                    if (exportConstructorInfo.ReturnParamNames.Count > 0) {
                        sb.Append(", ");
                        sb.Append(retArgStr);
                    }
                    sb.Append(" = ");
                    sb.AppendFormat("obj:{0}", exportConstructor);
                    sb.Append("(args);");
                    sb.Append(" return obj; end));");
                    sb.AppendLine();
                }
                
                --indent;
                sb.AppendFormat("{0}end,", GetIndentString(indent));
                sb.AppendLine();

                sb.AppendFormat("{0}defineClass = function()", GetIndentString(indent));
                sb.AppendLine();
                ++indent;

                sb.AppendFormat("{0}local static = {1};", GetIndentString(indent), key);
                sb.AppendLine();

                sb.AppendLine();

                sb.AppendFormat("{0}local static_props = {{", GetIndentString(indent));
                sb.AppendLine();

                ++indent;

                //static property
                foreach (var ci in classes) {
                    sb.Append(ci.StaticPropertySourceCodeBuilder.ToString());
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
                    sb.Append(ci.StaticEventSourceCodeBuilder.ToString());
                }

                --indent;
                sb.AppendFormat("{0}}};", GetIndentString(indent));
                sb.AppendLine();

                sb.AppendLine();

                sb.AppendFormat("{0}local instance = {{", GetIndentString(indent));
                sb.AppendLine();
                ++indent;

                //instance function
                foreach (var ci in classes) {
                    sb.Append(ci.InstanceFunctionSourceCodeBuilder.ToString());
                }
                sb.AppendLine();
                //instance field
                foreach (var ci in classes) {
                    sb.Append(ci.InstanceFieldSourceCodeBuilder.ToString());
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
                    sb.Append(ci.InstancePropertySourceCodeBuilder.ToString());
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
                    sb.Append(ci.InstanceEventSourceCodeBuilder.ToString());
                }

                --indent;
                sb.AppendFormat("{0}}};", GetIndentString(indent));
                sb.AppendLine();

                sb.AppendLine();

                sb.AppendFormat("{0}return defineclass(static, static_props, static_events, instance, instance_props, instance_events);", GetIndentString(indent));
                sb.AppendLine();

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

            for (int i = 0; i < nss.Length - 1; ++i) {
                --indent;
                if (isAlone) {
                    sb.AppendFormat("{0}}}", GetIndentString(indent));
                    if (indent > 0) {
                        sb.Append(",");
                    } else {
                        sb.Append(";");
                    }
                    sb.AppendLine();
                }
            }

            if (isAlone) {
                sb.AppendLine();
                if (isEntryClass) {
                    sb.AppendFormat("defineentry({0});", key);
                    sb.AppendLine();
                }
                sb.AppendFormat("return {0}.defineClass();", key);
            }

            foreach (var ci in classes) {
                sb.Append(ci.AfterOuterCodeBuilder.ToString());
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
