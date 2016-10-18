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
        public static void Process(string srcFile)
        {
            //srcFile = "Cs2Lua.csproj";
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
            List<string> refByNames = new List<string>();
            List<string> refByPaths = new List<string>();
            if (ext == ".csproj") {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(srcFile);
                var nodes = SelectNodes(xmlDoc, "ItemGroup", "Reference");
                foreach (XmlElement node in nodes) {
                    var pathNode = SelectSingleNode(node, "HintPath");
                    if (null != pathNode) {
                        refByPaths.Add(pathNode.InnerText);
                    } else {
                        string val = node.GetAttribute("Include");
                        if (!string.IsNullOrEmpty(val))
                            refByNames.Add(val);
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

            List<SyntaxTree> trees = new List<SyntaxTree>();
            foreach (string file in files) {
                string filePath = Path.Combine(path, file);
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                CSharpParseOptions options = new CSharpParseOptions();
                options = options.WithPreprocessorSymbols("__LUA__");
                options = options.WithFeatures(new Dictionary<string, string> { { "IOperation", "true" } });
                SyntaxTree tree = CSharpSyntaxTree.ParseText(File.ReadAllText(filePath), options, filePath);
                trees.Add(tree);
                var diags = tree.GetDiagnostics();
                bool haveError = false;
                using (StreamWriter sw = new StreamWriter(Path.Combine(logDir, string.Format("SyntaxError_{0}.log", fileName)))) {
                    foreach (var diag in diags) {
                        string msg = diag.ToString();
                        sw.WriteLine("{0}", msg);
                        haveError = true;
                    }
                    sw.Close();
                }
                if (haveError) {
                    return;
                }
            }

            List<MetadataReference> refs = new List<MetadataReference>();
            refs.Add(MetadataReference.CreateFromFile(typeof(object).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(System.Reflection.Metadata.AssemblyDefinition).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(System.Collections.Immutable.ImmutableArray).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(SyntaxTree).Assembly.Location));
            refs.Add(MetadataReference.CreateFromFile(typeof(CSharpSyntaxTree).Assembly.Location));
            foreach (var refByPath in refByPaths) {
                string fullPath = Path.Combine(path, refByPath);
                refs.Add(MetadataReference.CreateFromFile(fullPath));
            }
            foreach (var refByName in refByNames) {
#pragma warning disable 618
                Assembly assembly = Assembly.LoadWithPartialName(refByName);
#pragma warning restore 618
                if (null != assembly) {
                    refs.Add(MetadataReference.CreateFromFile(assembly.Location));
                }
            }
            CSharpCompilationOptions compilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
            CSharpCompilation compilation = CSharpCompilation.Create(name);
            compilation = compilation.WithOptions(compilationOptions);
            compilation = compilation.AddReferences(refs.ToArray());
            foreach (SyntaxTree tree in trees) {
                compilation = compilation.AddSyntaxTrees(tree);
            }
            Dictionary<string, List<ClassInfo>> classes = new Dictionary<string, List<ClassInfo>>();
            MergedNamespaceInfo toplevelMni = new MergedNamespaceInfo();
            foreach (SyntaxTree tree in trees) {
                string fileName = Path.GetFileNameWithoutExtension(tree.FilePath);
                var root = tree.GetRoot();
                SemanticModel model = compilation.GetSemanticModel(tree, true);
                var diags = model.GetDiagnostics();
                using (StreamWriter sw = new StreamWriter(Path.Combine(logDir, string.Format("SemanticError_{0}.log", fileName)))) {
                    foreach (var diag in diags) {
                        string msg = diag.ToString();
                        sw.WriteLine("{0}", msg);
                    }
                    sw.Close();
                }
                CsLuaTranslater csToLua = new CsLuaTranslater(model, new SymbolTable(compilation.Assembly));
                csToLua.Translate(root);
                csToLua.SaveLog(Path.Combine(logDir, string.Format("Translation_{0}.log", fileName)));

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
            foreach (var pair in classes) {
                StringBuilder sb0 = new StringBuilder();
                string fileName = BuildLuaClass(sb0, pair.Key, pair.Value, true);
                File.WriteAllText(Path.Combine(outputDir, fileName + ".txt"), sb0.ToString());
            }
            StringBuilder sb = new StringBuilder();
            BuildLuaClass(sb, toplevelMni);
            Console.Write(sb.ToString());
        }

        private static void BuildLuaClass(StringBuilder sb, MergedNamespaceInfo toplevelMni)
        {
            sb.AppendLine("require \"utility\";");
            BuildLuaClassRecursively(sb, toplevelMni, 0);
        }
        private static void BuildLuaClassRecursively(StringBuilder sb, MergedNamespaceInfo mni, int indent)
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
                    BuildLuaClass(sb, mci);
                }
                foreach (var npair in mni.Namespaces) {
                    var newMni = npair.Value;
                    BuildLuaClassRecursively(sb, newMni, indent);
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
        private static void BuildLuaClass(StringBuilder sb, MergedClassInfo mci)
        {
            BuildLuaClass(sb, mci.Key, mci.Classes, false);
        }
        private static string BuildLuaClass(StringBuilder sb, string key, IList<ClassInfo> classes, bool isAlone)
        {
            string fileName = key.Replace('.', '_');
            string[] nss = key.Split('.');
            string className = nss[nss.Length - 1];

            foreach (var ci in classes) {
                sb.Append(ci.BeforeOuterCodeBuilder.ToString());
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
                sb.AppendLine();
            }

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
            //static field
            foreach (var ci in classes) {
                sb.Append(ci.StaticFieldSourceCodeBuilder.ToString());
            }

            if (classes.Count > 0 && !classes[0].IsEnum) {

                sb.AppendFormat("{0}new = function(self)", GetIndentString(indent));
                sb.AppendLine();
                ++indent;

                sb.AppendFormat("{0}local o = {{", GetIndentString(indent));
                sb.AppendLine();
                ++indent;

                //instance function
                foreach (var ci in classes) {
                    sb.Append(ci.InstanceFunctionSourceCodeBuilder.ToString());
                }
                //instance field
                foreach (var ci in classes) {
                    sb.Append(ci.InstanceFieldSourceCodeBuilder.ToString());
                }

                --indent;
                sb.AppendFormat("{0}}};", GetIndentString(indent));
                sb.AppendLine();
                sb.AppendFormat("{0}setmetatable(o, self);", GetIndentString(indent));
                sb.AppendLine();
                sb.AppendFormat("{0}self.__index = self;", GetIndentString(indent));
                sb.AppendLine();
                sb.AppendFormat("{0}return o;", GetIndentString(indent));
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
                sb.AppendLine("function main()");
                sb.AppendFormat("\treturn {0};", key);
                sb.AppendLine();
                sb.AppendLine("end;");
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
