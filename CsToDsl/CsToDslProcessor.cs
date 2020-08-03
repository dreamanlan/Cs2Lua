using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using System.Xml;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoslynTool.CsToDsl
{
    public enum ExitCode : int
    {
        Success = 0,
        SyntaxError = 1,
        SemanticError = 2,
        FileNotFound = 3,
        Exception = 4,
    }
    public static class CsToDslProcessor
    {
        public static ExitCode Process(string srcFile, IList<string> macros, IList<string> undefMacros, IList<string> ignoredPath, IList<string> externPath, IList<string> internPath, IDictionary<string, string> _refByNames, IDictionary<string, string> _refByPaths, bool enableInherit, bool enableLinq, bool outputResult, bool parallel)
        {
            const string c_OutputExt = "dsl";
            List<string> preprocessors = new List<string>(macros);
            preprocessors.Add("__DSL__");

            string exepath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            string path = Path.GetDirectoryName(srcFile);
            string name = Path.GetFileNameWithoutExtension(srcFile);
            string ext = Path.GetExtension(srcFile);

            List<string> ignoredFullPath = new List<string>();
            foreach (string s in ignoredPath) {
                ignoredFullPath.Add(Path.Combine(path, s));
            }
            List<string> externFullPath = new List<string>();
            foreach (string s in externPath) {
                externFullPath.Add(Path.Combine(path, s));
            }
            List<string> internFullPath = new List<string>();
            foreach (string s in internPath) {
                internFullPath.Add(Path.Combine(path, s));
            }

            string logDir = Path.Combine(path, "log");
            if (!Directory.Exists(logDir)) {
                Directory.CreateDirectory(logDir);
            }
            string outputDir = Path.Combine(path, "dsl");
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
                    if (null != pathNode && !refByPaths.ContainsKey(pathNode.InnerText)) {
                        if (null != aliasesNode)
                            refByPaths.Add(pathNode.InnerText, aliasesNode.InnerText);
                        else
                            refByPaths.Add(pathNode.InnerText, "global");
                    }
                    else {
                        string val = node.GetAttribute("Include");
                        if (!string.IsNullOrEmpty(val) && !refByNames.ContainsKey(val)) {
                            if (null != aliasesNode)
                                refByNames.Add(val, aliasesNode.InnerText);
                            else
                                refByNames.Add(val, "global");
                        }
                    }
                }
                string prjOutputDir = "bin/Debug/";
                nodes = SelectNodes(xmlDoc, "PropertyGroup");
                foreach (XmlElement node in nodes) {
                    string condition = node.GetAttribute("Condition");
                    var defNode = SelectSingleNode(node, "DefineConstants");
                    var pathNode = SelectSingleNode(node, "OutputPath");
                    if (null != defNode && null != pathNode) {
                        string text = defNode.InnerText.Trim();
                        if (condition.IndexOf("Debug") > 0 || condition.IndexOf("Release") < 0 && (text == "DEBUG" || text.IndexOf(";DEBUG;") > 0 || text.StartsWith("DEBUG;") || text.EndsWith(";DEBUG"))) {
                            preprocessors.AddRange(text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
                            prjOutputDir = pathNode.InnerText.Trim();
                            break;
                        }
                    }
                }
                nodes = SelectNodes(xmlDoc, "ItemGroup", "ProjectReference");
                foreach (XmlElement node in nodes) {
                    string val = node.GetAttribute("Include");
                    string prjFile = Path.Combine(path, val.Trim());
                    var nameNode = SelectSingleNode(node, "Name");
                    if (null != prjFile && null != nameNode) {
                        string prjName = nameNode.InnerText.Trim();
                        string prjOutputFile = ParseProjectOutputFile(prjFile, prjName);
                        string fileName = Path.Combine(prjOutputDir, prjOutputFile);
                        if (!refByPaths.ContainsKey(fileName)) {
                            refByPaths.Add(fileName, "global");
                        }
                    }
                }
                nodes = SelectNodes(xmlDoc, "ItemGroup", "Compile");
                foreach (XmlElement node in nodes) {
                    string val = node.GetAttribute("Include");
                    if (!string.IsNullOrEmpty(val) && val.EndsWith(".cs") && !files.Contains(val)) {
                        files.Add(val);
                    }
                }
            }
            else {
                files.Add(srcFile);
            }

            foreach (string m in undefMacros) {
                preprocessors.Remove(m);
            }

            var temp = refByPaths;
            refByPaths = new Dictionary<string, string>();
            foreach (var pair in temp) {
                var key = pair.Key.Replace('\\', '/');
                var val = pair.Value;
                refByPaths.Add(key, val);
            }
            for (int i = 0; i < files.Count; ++i) {
                var file = files[i];
                files[i] = file.Replace('\\', '/');
            }

            bool haveError = false;
            List<SyntaxTree> trees = new List<SyntaxTree>();
            using (StreamWriter sw = new StreamWriter(Path.Combine(logDir, "SyntaxError.log"))) {
                using (StreamWriter sw2 = new StreamWriter(Path.Combine(logDir, "SyntaxWarning.log"))) {
                    Action<string> handler = (file) => {
                        string filePath = Path.Combine(path, file);
                        string fileName = Path.GetFileNameWithoutExtension(filePath);
                        CSharpParseOptions options = new CSharpParseOptions();
                        options = options.WithPreprocessorSymbols(preprocessors);
                        options = options.WithFeatures(new Dictionary<string, string> { { "IOperation", "true" } });
                        SyntaxTree tree = CSharpSyntaxTree.ParseText(File.ReadAllText(filePath), options, filePath);
                        lock (trees) {
                            trees.Add(tree);
                        }

                        var diags = tree.GetDiagnostics();
                        bool firstError = true;
                        bool firstWarning = true;
                        foreach (var diag in diags) {
                            if (diag.Severity == DiagnosticSeverity.Error) {
                                if (firstError) {
                                    LockWriteLine(sw, "============<<<Syntax Error:{0}>>>============", fileName);
                                    firstError = false;
                                }
                                string msg = diag.ToString();
                                LockWriteLine(sw, "{0}", msg);
                                haveError = true;
                            }
                            else {
                                if (firstWarning) {
                                    LockWriteLine(sw2, "============<<<Syntax Warning:{0}>>>============", fileName);
                                    firstWarning = false;
                                }
                                string msg = diag.ToString();
                                LockWriteLine(sw2, "{0}", msg);
                            }
                        }
                    };
                    if (parallel) {
                        Parallel.ForEach(files, handler);
                    }
                    else {
                        foreach (var file in files) {
                            handler(file);
                        }
                    }
                    sw2.Close();
                }
                sw.Close();
            }
            if (haveError) {
                Console.WriteLine("{0}", File.ReadAllText(Path.Combine(logDir, "SyntaxError.log")));
                return ExitCode.SyntaxError;
            }

            //确保常用的Assembly被引用
            if (!refByNames.ContainsKey("mscorlib")) {
                refByNames.Add("mscorlib", "global");
            }
            if (!refByNames.ContainsKey("System")) {
                refByNames.Add("System", "global");
            }
            if (!refByNames.ContainsKey("System.Core")) {
                refByNames.Add("System.Core", "global");
            }
            List<MetadataReference> refs = new List<MetadataReference>();
            if (string.IsNullOrEmpty(SymbolTable.SystemDllPath)) {
                if (ext == ".cs") {
                    refs.Add(MetadataReference.CreateFromFile(typeof(Queue<>).Assembly.Location));
                    refs.Add(MetadataReference.CreateFromFile(typeof(HashSet<>).Assembly.Location));
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

                refs.Add(MetadataReference.CreateFromFile(typeof(Cs2Dsl.IgnoreAttribute).Assembly.Location));
            }
            else {
                foreach (var pair in refByNames) {
                    string file = Path.Combine(SymbolTable.SystemDllPath, pair.Key) + ".dll";
                    var arr = System.Collections.Immutable.ImmutableArray.Create(pair.Value);
                    refs.Add(MetadataReference.CreateFromFile(file, new MetadataReferenceProperties(MetadataImageKind.Assembly, arr)));
                }

                refs.Add(MetadataReference.CreateFromFile(typeof(Cs2Dsl.IgnoreAttribute).Assembly.Location));
            }

            foreach (var pair in refByPaths) {
                string fullPath = Path.Combine(path, pair.Key);
                var arr = System.Collections.Immutable.ImmutableArray.Create(pair.Value);
                refs.Add(MetadataReference.CreateFromFile(fullPath, new MetadataReferenceProperties(MetadataImageKind.Assembly, arr)));
            }

            List<SyntaxTree> newTrees = new List<SyntaxTree>();
            CSharpCompilationOptions compilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
            compilationOptions = compilationOptions.WithAssemblyIdentityComparer(DesktopAssemblyIdentityComparer.Default);
            CSharpCompilation compilation = CSharpCompilation.Create(name);
            compilation = compilation.WithOptions(compilationOptions);
            compilation = compilation.AddReferences(refs.ToArray());
            foreach (SyntaxTree tree in trees) {
                DslKeywordsReplacer replacer = new DslKeywordsReplacer();
                var newRoot = replacer.Visit(tree.GetRoot()) as CSharpSyntaxNode;
                var newTree = CSharpSyntaxTree.Create(newRoot, tree.Options as CSharpParseOptions, tree.FilePath, tree.Encoding);
                newTrees.Add(newTree);
                compilation = compilation.AddSyntaxTrees(newTree);
            }

            bool haveSemanticError = false;
            bool haveTranslationError = false;
            SymbolTable.Instance.Init(compilation, exepath);
            SymbolTable.Instance.AddRequire("cs2dsl__custom", "cs2dsl__custom");
            Dictionary<string, INamedTypeSymbol> ignoredClasses = new Dictionary<string, INamedTypeSymbol>();
            Dictionary<string, MergedClassInfo> toplevelClasses = new Dictionary<string, MergedClassInfo>();
            MergedNamespaceInfo toplevelMni = new MergedNamespaceInfo();
            using (StreamWriter sw = new StreamWriter(Path.Combine(logDir, "SemanticError.log"))) {
                using (StreamWriter sw2 = new StreamWriter(Path.Combine(logDir, "SemanticWarning.log"))) {
                    using (StreamWriter sw3 = new StreamWriter(Path.Combine(logDir, "Translation.log"))) {
                        Action<SyntaxTree> handler1 = (tree) => {
                            bool ignore = IsIgnoredFile(ignoredFullPath, tree.FilePath);
                            bool isExtern = IsExternFile(externFullPath, tree.FilePath);
                            if (internFullPath.Count > 0) {
                                bool isIntern = IsInternFile(internFullPath, tree.FilePath);
                                if (!isIntern && !ignore) {
                                    isExtern = true;
                                }
                            }
                            string fileName = Path.GetFileNameWithoutExtension(tree.FilePath);
                            var root = tree.GetRoot();
                            SemanticModel model = compilation.GetSemanticModel(tree, true);
                            if (ignore || isExtern) {
                                TypeAnalysis ta = new TypeAnalysis(model);
                                ta.Visit(root);
                                var symbols = ta.Symbols;
                                foreach (var symbol in symbols) {
                                    var type = symbol as INamedTypeSymbol;
                                    if (null != type) {
                                        string key = ClassInfo.SpecialGetFullTypeName(type, isExtern);
                                        lock (ignoredClasses) {
                                            if (!ignoredClasses.ContainsKey(key)) {
                                                ignoredClasses.Add(key, type);
                                            }
                                        }
                                        if (ignore && !SymbolTable.Instance.IgnoredTypes.ContainsKey(key)) {
                                            SymbolTable.Instance.IgnoredTypes.TryAdd(key, type);
                                        }
                                        if (isExtern && !SymbolTable.Instance.ExternTypes.ContainsKey(key)) {
                                            SymbolTable.Instance.ExternTypes.TryAdd(key, type);
                                        }
                                    }
                                }
                            }
                            else {
                                TypeAnalysis ta = new TypeAnalysis(model);
                                ta.Visit(root);
                                var symbols = ta.Symbols;
                                foreach (var symbol in symbols) {
                                    var type = symbol as INamedTypeSymbol;
                                    if (null != type) {
                                        string key = ClassInfo.SpecialGetFullTypeName(type, isExtern);
                                        if (!SymbolTable.Instance.InternTypes.ContainsKey(key)) {
                                            SymbolTable.Instance.InternTypes.TryAdd(key, type);
                                        }
                                    }
                                }
                            }
                        };
                        if (parallel) {
                            Parallel.ForEach(newTrees, handler1);
                        }
                        else {
                            foreach (var tree in newTrees) {
                                handler1(tree);
                            }
                        }
                        SymbolTable.Instance.SymbolClassified();
                        Action<SyntaxTree> handler2 = (tree) => {
                            bool ignore = IsIgnoredFile(ignoredFullPath, tree.FilePath);
                            bool isExtern = IsExternFile(externFullPath, tree.FilePath);
                            if (internFullPath.Count > 0) {
                                bool isIntern = IsInternFile(internFullPath, tree.FilePath);
                                if (!isIntern && !ignore) {
                                    isExtern = true;
                                }
                            }
                            string fileName = Path.GetFileNameWithoutExtension(tree.FilePath);
                            var root = tree.GetRoot();
                            SemanticModel model = compilation.GetSemanticModel(tree, true);

                            var diags = model.GetDiagnostics();
                            bool firstError = true;
                            bool firstWarning = true;
                            foreach (var diag in diags) {
                                if (diag.Severity == DiagnosticSeverity.Error) {
                                    if (firstError) {
                                        LockWriteLine(sw, "============<<<Semantic Error:{0}>>>============", fileName);
                                        firstError = false;
                                    }
                                    string msg = diag.ToString();
                                    LockWriteLine(sw, "{0}", msg);
                                    haveSemanticError = true;
                                }
                                else {
                                    if (firstWarning) {
                                        LockWriteLine(sw2, "============<<<Semantic Warning:{0}>>>============", fileName);
                                        firstWarning = false;
                                    }
                                    string msg = diag.ToString();
                                    LockWriteLine(sw2, "{0}", msg);
                                }
                            }

                            if (!ignore && !isExtern) {
                                CsDslTranslater csToDsl = new CsDslTranslater(model, enableInherit, enableLinq);
                                csToDsl.Translate(root);
                                if (csToDsl.HaveError) {
                                    LockWriteLine(sw3, "============<<<Translation Error:{0}>>>============", fileName);
                                    lock (sw3) {
                                        csToDsl.SaveLog(sw3);
                                        csToDsl.ClearLog();
                                    }
                                    haveTranslationError = true;
                                }

                                foreach (var pair in csToDsl.ToplevelClasses) {
                                    var key = pair.Key;
                                    var cis = pair.Value;

                                    foreach (var ci in cis) {
                                        lock (toplevelClasses) {
                                            AddMergedClasses(toplevelClasses, key, ci);
                                        }
                                    }

                                    string[] nss = key.Split('.');
                                    lock (toplevelMni) {
                                        AddMergedNamespaces(toplevelMni, nss);
                                    }
                                }
                            }
                        };
                        if (parallel) {
                            Parallel.ForEach(newTrees, handler2);
                        }
                        else {
                            foreach (var tree in newTrees) {
                                handler2(tree);
                            }
                        }
                        HashSet<string> handledTypes = new HashSet<string>();
                        var typeSyms = new Queue<DerivedGenericTypeInstanceInfo>();
                        Action<SyntaxNode, INamedTypeSymbol> action = (SyntaxNode node, INamedTypeSymbol typeSym) => {
                            string fileName = Path.GetFileNameWithoutExtension(node.SyntaxTree.FilePath);
                            SemanticModel model = compilation.GetSemanticModel(node.SyntaxTree, true);
                            CsDslTranslater csToDsl = new CsDslTranslater(model, enableInherit, enableLinq);
                            csToDsl.Translate(node, typeSym);
                            if (csToDsl.HaveError) {
                                sw3.WriteLine("============<<<Translation Error:{0}>>>============", fileName);
                                csToDsl.SaveLog(sw3);
                                csToDsl.ClearLog();
                                haveTranslationError = true;
                            }
                            else {
                                while (csToDsl.DerivedGenericTypeInstances.Count > 0) {
                                    var t = csToDsl.DerivedGenericTypeInstances.Dequeue();
                                    typeSyms.Enqueue(t);
                                }
                            }

                            foreach (var cpair in csToDsl.ToplevelClasses) {
                                var ckey = cpair.Key;
                                var cis = cpair.Value;

                                foreach (var ci in cis) {
                                    AddMergedClasses(toplevelClasses, ckey, ci);
                                }
                            }
                        };
                        foreach (var pair in SymbolTable.Instance.GenericTypeInstances) {
                            var typeSym = pair.Value;
                            typeSyms.Enqueue(new DerivedGenericTypeInstanceInfo { Symbol = typeSym, Node = null });
                            while (typeSyms.Count > 0) {
                                var ts = typeSyms.Dequeue();
                                var key = ClassInfo.GetFullName(ts.Symbol);
                                if (!handledTypes.Contains(key)) {
                                    handledTypes.Add(key);

                                    SymbolTable.Instance.SetTypeParamsAndArgs(ts.TypeParameters, ts.TypeArguments, ts.Symbol);
                                    var refKey = ClassInfo.GetFullNameWithTypeParameters(ts.Symbol);
                                    List<SyntaxNode> nodes;
                                    if (SymbolTable.Instance.GenericTypeDefines.TryGetValue(refKey, out nodes)) {
                                        if (null != ts.Node) {
                                            action(ts.Node, ts.Symbol);
                                        }
                                        foreach (var node in nodes) {
                                            action(node, ts.Symbol);
                                        }
                                    }
                                }
                            }
                        }
                        sw3.Close();
                    }
                    sw2.Close();
                }
                sw.Close();
            }
            StringBuilder nsBuilder = new StringBuilder();
            BuildNamespaces(nsBuilder, toplevelMni);
            StringBuilder attrBuilder = new StringBuilder();
            BuildAttributes(attrBuilder, compilation.Assembly, ignoredClasses);
            StringBuilder enumBuilder = new StringBuilder();
            BuildExternEnums(enumBuilder);
            StringBuilder intfBuilder = new StringBuilder();
            BuildInterfaces(intfBuilder);
            StringBuilder refExternBuilder = new StringBuilder();
            BuildReferencedExternTypes(refExternBuilder);
            File.WriteAllText(Path.Combine(outputDir, string.Format("cs2dsl__namespaces.{0}", c_OutputExt)), nsBuilder.ToString());
            File.WriteAllText(Path.Combine(outputDir, string.Format("cs2dsl__attributes.{0}", c_OutputExt)), attrBuilder.ToString());
            File.WriteAllText(Path.Combine(outputDir, string.Format("cs2dsl__externenums.{0}", c_OutputExt)), enumBuilder.ToString());
            File.WriteAllText(Path.Combine(outputDir, string.Format("cs2dsl__interfaces.{0}", c_OutputExt)), intfBuilder.ToString());
            File.WriteAllText(Path.Combine(outputDir, "cs2dsl__references.txt"), refExternBuilder.ToString());
            foreach (var pair in toplevelClasses) {
                StringBuilder classBuilder = new StringBuilder();
                string fileName = BuildDslClass(classBuilder, pair.Key, pair.Value);
                File.WriteAllText(Path.Combine(outputDir, Path.ChangeExtension(fileName.ToLower(), c_OutputExt)), classBuilder.ToString());
            }
            StringBuilder allClassBuilder = new StringBuilder();
            BuildDslClass(allClassBuilder, toplevelMni, toplevelClasses);
            if (haveSemanticError || haveTranslationError) {
                if (haveSemanticError) {
                    Console.WriteLine("{0}", File.ReadAllText(Path.Combine(logDir, "SemanticError.log")));
                }
                if (haveTranslationError) {
                    Console.WriteLine("{0}", File.ReadAllText(Path.Combine(logDir, "Translation.log")));
                }
                return ExitCode.SemanticError;
            }
            else {
                if (outputResult) {
                    Console.Write(allClassBuilder.ToString());
                }
                return ExitCode.Success;
            }
        }

        private static void Log(string file, string msg)
        {
            Console.WriteLine("[{0}]:{1}", file, msg);
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
            foreach (var pair in ci.InnerInterfaces) {
                List<string> list;
                if (!mci.InnerInterfaces.TryGetValue(pair.Key, out list)) {
                    list = new List<string>();
                    mci.InnerInterfaces.Add(pair.Key, list);
                }
                foreach (var intf in pair.Value) {
                    if (!list.Contains(intf)) {
                        list.Add(intf);
                    }
                }
            }
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
            BuildNamespacesRecursively(sb, mni, string.Empty);
        }
        private static void BuildNamespacesRecursively(StringBuilder sb, MergedNamespaceInfo mni, string upperns)
        {
            if (null != mni) {
                string nsname;
                if (string.IsNullOrEmpty(upperns)) {
                    nsname = mni.Name;
                }
                else {
                    nsname = upperns + "." + mni.Name;
                }
                if (!string.IsNullOrEmpty(nsname)) {
                    sb.AppendFormat("namespace({0});", nsname);
                    sb.AppendLine();
                }
                foreach (var npair in mni.Namespaces) {
                    var newMni = npair.Value;
                    BuildNamespacesRecursively(sb, newMni, nsname);
                }
            }
        }
        private static void BuildAttributes(StringBuilder sb, IAssemblySymbol assemblySymbol, Dictionary<string, INamedTypeSymbol> ignoredClasses)
        {
            INamespaceSymbol nssym = assemblySymbol.GlobalNamespace;
            BuildAttributesRecursively(sb, nssym, assemblySymbol, ignoredClasses);
        }
        private static void BuildAttributesRecursively(StringBuilder sb, INamespaceSymbol nssym, IAssemblySymbol assemblySymbol, Dictionary<string, INamedTypeSymbol> ignoredClasses)
        {
            if (null != nssym) {
                foreach (var typeSym in nssym.GetTypeMembers()) {
                    BuildAttributesRecursively(sb, typeSym, assemblySymbol, ignoredClasses);
                }
                foreach (var newSym in nssym.GetNamespaceMembers()) {
                    BuildAttributesRecursively(sb, newSym, assemblySymbol, ignoredClasses);
                }
            }
        }
        private static void BuildAttributesRecursively(StringBuilder sb, INamedTypeSymbol typesym, IAssemblySymbol assemblySymbol, Dictionary<string, INamedTypeSymbol> ignoredClasses)
        {
            BuildClassAttributes(sb, typesym, assemblySymbol, ignoredClasses);
            foreach (var newSym in typesym.GetTypeMembers()) {
                BuildAttributesRecursively(sb, newSym, assemblySymbol, ignoredClasses);
            }
        }
        private static void BuildClassAttributes(StringBuilder sb, INamedTypeSymbol typesym, IAssemblySymbol assemblySymbol, Dictionary<string, INamedTypeSymbol> ignoredClasses)
        {
            string key = ClassInfo.GetFullName(typesym);
            if (ignoredClasses.ContainsKey(key)) {
                return;
            }
            if (ClassInfo.HasAttribute(typesym, "Cs2Dsl.IgnoreAttribute")) {
                return;
            }
            StringBuilder csb = new StringBuilder();
            StringBuilder temp = new StringBuilder();
            int indent = 0;
            ++indent;
            if (typesym.GetAttributes().Length > 0) {
                csb.AppendFormat("{0}class{{", GetIndentString(indent));
                csb.AppendLine();
                ++indent;
                BuildAttributes(csb, indent, typesym.GetAttributes());
                --indent;
                csb.AppendFormat("{0}}};", GetIndentString(indent));
                csb.AppendLine();
            }
            temp.Length = 0;
            foreach (var sym in typesym.GetMembers()) {
                var msym = sym as IFieldSymbol;
                if (null != msym && msym.GetAttributes().Length > 0 && !ClassInfo.HasAttribute(sym, "Cs2Dsl.IgnoreAttribute")) {
                    temp.AppendFormat("{0}field({1}){{", GetIndentString(indent), sym.Name);
                    temp.AppendLine();
                    ++indent;
                    BuildAttributes(temp, indent, msym.GetAttributes());
                    --indent;
                    temp.AppendFormat("{0}}};", GetIndentString(indent));
                    temp.AppendLine();
                }
            }
            if (temp.Length > 0) {
                csb.Append(temp.ToString());
            }
            temp.Length = 0;
            foreach (var sym in typesym.GetMembers()) {
                var msym = sym as IMethodSymbol;
                if (null != msym && msym.GetAttributes().Length > 0 && !ClassInfo.HasAttribute(sym, "Cs2Dsl.IgnoreAttribute")) {
                    string mname = SymbolTable.Instance.NameMangling(msym);
                    temp.AppendFormat("{0}method({1}){{", GetIndentString(indent), mname);
                    temp.AppendLine();
                    ++indent;
                    BuildAttributes(temp, indent, msym.GetAttributes());
                    --indent;
                    temp.AppendFormat("{0}}};", GetIndentString(indent));
                    temp.AppendLine();
                }
            }
            if (temp.Length > 0) {
                csb.Append(temp.ToString());
            }
            temp.Length = 0;
            foreach (var sym in typesym.GetMembers()) {
                var msym = sym as IPropertySymbol;
                if (null != msym && !msym.IsIndexer && msym.GetAttributes().Length > 0 && !ClassInfo.HasAttribute(sym, "Cs2Dsl.IgnoreAttribute")) {
                    temp.AppendFormat("{0}property({1}){{", GetIndentString(indent), sym.Name);
                    temp.AppendLine();
                    ++indent;
                    BuildAttributes(temp, indent, msym.GetAttributes());
                    --indent;
                    temp.AppendFormat("{0}}};", GetIndentString(indent));
                    temp.AppendLine();
                }
            }
            if (temp.Length > 0) {
                csb.Append(temp.ToString());
            }
            temp.Length = 0;
            foreach (var sym in typesym.GetMembers()) {
                var msym = sym as IEventSymbol;
                if (null != msym && msym.GetAttributes().Length > 0 && !ClassInfo.HasAttribute(sym, "Cs2Dsl.IgnoreAttribute")) {
                    temp.AppendFormat("{0}event({1}){{", GetIndentString(indent), sym.Name);
                    temp.AppendLine();
                    ++indent;
                    BuildAttributes(temp, indent, msym.GetAttributes());
                    --indent;
                    temp.AppendFormat("{0}}};", GetIndentString(indent));
                    temp.AppendLine();
                }
            }
            if (temp.Length > 0) {
                csb.Append(temp.ToString());
            }
            --indent;
            if (csb.Length > 0) {
                sb.AppendFormat("attributes({0}){{", ClassInfo.GetFullName(typesym));
                sb.AppendLine();
                sb.Append(csb.ToString());
                sb.Append("};");
                sb.AppendLine();
            }
        }
        private static void BuildAttributes(StringBuilder sb, int indent, System.Collections.Immutable.ImmutableArray<AttributeData> attrs)
        {
            foreach (var attr in attrs) {
                string fn = ClassInfo.GetFullName(attr.AttributeClass);
                sb.AppendFormat("{0}attribute(", GetIndentString(indent));
                sb.AppendFormat("{0}([", fn);
                if (null != attr.AttributeConstructor) {
                    var ps = attr.AttributeConstructor.Parameters;
                    var args = attr.ConstructorArguments;
                    int ct = args.Length < ps.Length ? args.Length : ps.Length;
                    for (int i = 0; i < ct; ++i) {
                        string name = ps[i].Name;
                        sb.Append(name);
                        sb.Append("(");
                        OutputTypedConstant(sb, args[i]);
                        sb.Append(")");
                        if (i < ct - 1) {
                            sb.Append(", ");
                        }
                    }
                }
                sb.Append("], [");
                var namedArgs = attr.NamedArguments;
                int ct2 = namedArgs.Length;
                for (int i = 0; i < ct2; ++i) {
                    var pair = namedArgs[i];
                    string name = pair.Key;
                    sb.Append(name);
                    sb.Append("(");
                    OutputTypedConstant(sb, pair.Value);
                    sb.Append(")");
                    if (i < ct2 - 1) {
                        sb.Append(", ");
                    }
                }
                sb.AppendLine("]));");
            }
        }
        private static void OutputTypedConstant(StringBuilder sb, TypedConstant tc)
        {
            if (tc.Kind == TypedConstantKind.Array) {
                sb.Append("[");
                var vals = tc.Values;
                for (int ix = 0; ix < vals.Length; ++ix) {
                    OutputTypedConstant(sb, vals[ix]);
                    if (ix < vals.Length - 1) {
                        sb.Append(", ");
                    }
                }
                sb.Append("]");
            }
            else {
                object v = tc.Value;
                if (null == v) {
                    sb.Append("null");
                }
                else if (v is string) {
                    sb.AppendFormat("\"{0}\"", v.ToString());
                }
                else {
                    sb.Append(v);
                }
            }
        }
        private static void BuildExternEnums(StringBuilder sb)
        {
            int indent = 0;
            foreach (var pair in SymbolTable.Instance.ExternEnums) {
                string key = pair.Key;
                var typeSym = pair.Value;

                BuildExternEnumNamespace(sb, indent, typeSym);

                sb.AppendLine();
            }
        }
        private static void BuildExternEnumNamespace(StringBuilder sb, int indent, ITypeSymbol enumSym)
        {
            string ns;
            if (null != enumSym.ContainingType) {
                ns = BuildExternEnumNamespace(sb, indent, enumSym.ContainingType);
            }
            else if (null != enumSym.ContainingNamespace) {
                ns = BuildExternEnumNamespace(sb, indent, enumSym.ContainingNamespace);
            }
            else {
                ns = string.Empty;
            }
            if (!string.IsNullOrEmpty(ns)) {
                sb.AppendFormat("{0}enum({1}.{2}) {{", GetIndentString(indent), ns, enumSym.Name);
                sb.AppendLine();
                ++indent;

                foreach (var sym in enumSym.GetMembers()) {
                    if (sym.Kind != SymbolKind.Field) continue;
                    var fsym = sym as IFieldSymbol;
                    sb.AppendFormat("{0}member(\"{1}\", ", GetIndentString(indent), fsym.Name);
                    CsDslTranslater.OutputConstValue(sb, fsym.ConstantValue, fsym);
                    sb.Append(");");
                    sb.AppendLine();
                }

                --indent;
                sb.AppendFormat("{0}}};", GetIndentString(indent));
                sb.AppendLine();
            }
        }
        private static string BuildExternEnumNamespace(StringBuilder sb, int indent, INamedTypeSymbol typeSym)
        {
            string ns;
            if (null != typeSym.ContainingType) {
                ns = BuildExternEnumNamespace(sb, indent, typeSym.ContainingType);
            }
            else if (null != typeSym.ContainingNamespace) {
                ns = BuildExternEnumNamespace(sb, indent, typeSym.ContainingNamespace);
            }
            else {
                ns = string.Empty;
            }
            if (string.IsNullOrEmpty(ns)) {
                return typeSym.Name;
            }
            else {
                return ns + "." + typeSym.Name;
            }
        }
        private static string BuildExternEnumNamespace(StringBuilder sb, int indent, INamespaceSymbol nsSym)
        {
            if (string.IsNullOrEmpty(nsSym.Name)) {
                return string.Empty;
            }
            else {
                string ns;
                if (null != nsSym.ContainingNamespace) {
                    ns = BuildExternEnumNamespace(sb, indent, nsSym.ContainingNamespace);
                }
                else {
                    ns = string.Empty;
                }
                if (string.IsNullOrEmpty(ns)) {
                    return nsSym.Name;
                }
                else {
                    return ns + "." + nsSym.Name;
                }
            }
        }
        private static void BuildInterfaces(StringBuilder sb)
        {
            BuildInterfaces(sb, SymbolTable.Instance.Cs2DslInterfaces);
        }
        private static void BuildInterfaces(StringBuilder sb, Dictionary<string, List<string>> intfs)
        {
            foreach (var pair in intfs) {
                var name = pair.Key;
                var list = pair.Value;
                sb.AppendFormat("interface({0}) {{ interfaces {{", name);
                string prestr = string.Empty;
                foreach (var iname in list) {
                    sb.Append(prestr);
                    sb.AppendFormat("\"{0}\"", iname);
                    prestr = "; ";
                }
                sb.Append("}; };");
                sb.AppendLine();
            }
        }
        private static void BuildReferencedExternTypes(StringBuilder sb)
        {
            foreach (var key in SymbolTable.Instance.ReferencedExternTypes) {
                sb.AppendLine(key);
            }
        }
        private static void BuildDslClass(StringBuilder sb, MergedNamespaceInfo toplevelMni, Dictionary<string, MergedClassInfo> toplevelMcis)
        {
            StringBuilder code = new StringBuilder();
            HashSet<string> dsllibRefs = new HashSet<string>();
            BuildNamespaces(code, toplevelMni);
            foreach (var pair in toplevelMcis) {
                StringBuilder classBuilder = new StringBuilder();
                string fileName = BuildDslClass(classBuilder, pair.Key, pair.Value, false, dsllibRefs);
                code.Append(classBuilder.ToString());
            }
            sb.AppendLine("require(\"cs2dsl__lualib\");");
            sb.AppendLine("require(\"cs2dsl__attributes\");");
            sb.AppendLine("require(\"cs2dsl__externenums\");");
            sb.AppendLine("require(\"cs2dsl__interfaces\");");
            foreach (string lib in dsllibRefs) {
                sb.AppendFormat("require(\"{0}\");", lib.ToLower());
                sb.AppendLine();
            }
            sb.Append(code.ToString());
        }
        private static string BuildDslClass(StringBuilder sb, string key, MergedClassInfo mci)
        {
            HashSet<string> dsllibRefs = new HashSet<string>();
            return BuildDslClass(sb, key, mci, true, dsllibRefs);
        }
        private static string BuildDslClass(StringBuilder sb, string key, MergedClassInfo mci, bool isAlone, HashSet<string> dsllibRefs)
        {
            SymbolTable symTable = SymbolTable.Instance;
            var classes = mci.Classes;
            var firstClass = classes.Count > 0 ? classes[0] : null;
            string genericTypeKey = key;
            string baseClass = string.Empty;
            if (null != firstClass) {
                baseClass = firstClass.BaseKey;
                genericTypeKey = firstClass.GenericTypeKey;
            }

            string fileName = key.Replace(".", "__");
            string attributesName = fileName + "__Attrs";

            bool isStaticClass = false;
            bool isValueType = false;
            bool isEnumClass = false;
            bool haveCctor = false;
            bool haveCtor = false;
            bool existAttributes = false;
            ClassSymbolInfo csi;
            if (symTable.ClassSymbols.TryGetValue(genericTypeKey, out csi)) {
                haveCctor = csi.ExistStaticConstructor;
                haveCtor = csi.ExistConstructor;
                existAttributes = csi.ExistAttributes;
                isStaticClass = csi.TypeSymbol.IsStatic;
                isValueType = csi.TypeSymbol.IsValueType;
                isEnumClass = csi.TypeSymbol.TypeKind == TypeKind.Enum;
            }
            bool myselfDefinedBaseClass = SymbolTable.Instance.IsCs2DslSymbol(csi.TypeSymbol.BaseType);

            HashSet<string> requiredlibs = new HashSet<string>();
            HashSet<string> dsllibs;
            if (symTable.Requires.TryGetValue(key, out dsllibs)) {
                foreach (string lib in dsllibs) {
                    if (!dsllibRefs.Contains(lib)) {
                        dsllibRefs.Add(lib);
                    }
                    if (!requiredlibs.Contains(lib)) {
                        requiredlibs.Add(lib);
                    }
                }
            }
            foreach (var ci in classes) {
                foreach (string r in ci.IgnoreReferences) {
                    if (symTable.Requires.TryGetValue(r, out dsllibs)) {
                        foreach (string lib in dsllibs) {
                            if (!dsllibRefs.Contains(lib)) {
                                dsllibRefs.Add(lib);
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
                sb.AppendLine("require(\"cs2dsl__lualib\");");
                if (existAttributes)
                    sb.AppendLine("require(\"cs2dsl__attributes\");");
                sb.AppendLine("require(\"cs2dsl__namespaces\");");
                sb.AppendLine("require(\"cs2dsl__externenums\");");
                sb.AppendLine("require(\"cs2dsl__interfaces\");");
                foreach (string lib in requiredlibs) {
                    sb.AppendFormat("require(\"{0}\");", lib.ToLower());
                    sb.AppendLine();
                    refs.Add(lib);
                }

                //references
                if (SymbolTable.NoAutoRequire) {
                    sb.AppendLine("require(\"cs2dsl__custom\");");
                }
                else {
                    BuildReferences(sb, key, mci, refs);
                }
            }

            sb.AppendLine();

            int indent = 0;
            if (string.IsNullOrEmpty(baseClass)) {
                sb.AppendFormat("{0}{1}({2}) {{", GetIndentString(indent), isEnumClass ? "enum" : (isValueType ? "struct" : "class"), key);
            }
            else {
                sb.AppendFormat("{0}{1}({2}, {3}) {{", GetIndentString(indent), isEnumClass ? "enum" : (isValueType ? "struct" : "class"), key, baseClass);
            }
            sb.AppendLine();
            ++indent;

            if (isEnumClass) {
                //static field
                foreach (var ci in classes) {
                    sb.Append(ci.StaticFieldCodeBuilder.ToString());
                }
            }
            else {
                sb.AppendFormat("{0}static_methods {{", GetIndentString(indent));
                sb.AppendLine();
                ++indent;

                if (!isStaticClass) {
                    sb.AppendFormat("{0}__new_object = function(...){{", GetIndentString(indent));
                    sb.AppendLine();
                    ++indent;

                    if (string.IsNullOrEmpty(exportConstructor)) {
                        sb.AppendFormat("{0}return(newobject({1}, ", GetIndentString(indent), key);
                        var namedTypeSym = csi.TypeSymbol;
                        CsDslTranslater.OutputTypeArgsInfo(sb, namedTypeSym);
                        sb.Append(", \"ctor\", null, ...));");
                        sb.AppendLine();
                    }
                    else {
                        //处理ref/out参数
                        if (exportConstructorInfo.ReturnParamNames.Count > 0) {
                            sb.AppendFormat("{0}return((function(...){{ ", GetIndentString(indent));
                            string retArgStr = string.Join(", ", exportConstructorInfo.ReturnParamNames.ToArray());
                            sb.AppendFormat("local(newobj, {0}); multiassign(newobj", retArgStr);
                            if (exportConstructorInfo.ReturnParamNames.Count > 0) {
                                sb.Append(", ");
                                sb.Append(retArgStr);
                            }
                            sb.AppendFormat(") = newobject({0}, ", key);
                            var namedTypeSym = csi.TypeSymbol;
                            CsDslTranslater.OutputTypeArgsInfo(sb, namedTypeSym);
                            sb.AppendFormat(", \"{0}\", null, ...); return(newobj); }})(...));", exportConstructor);
                            sb.AppendLine();
                        }
                        else {
                            sb.AppendFormat("{0}return(newobject({1}, ", GetIndentString(indent), key);
                            var namedTypeSym = csi.TypeSymbol;
                            CsDslTranslater.OutputTypeArgsInfo(sb, namedTypeSym);
                            sb.AppendFormat(", \"{0}\", null, ...));", exportConstructor);
                            sb.AppendLine();
                        }
                    }

                    --indent;
                    sb.AppendFormat("{0}}};", GetIndentString(indent));
                    sb.AppendLine();
                }

                //static function
                foreach (var ci in classes) {
                    sb.Append(ci.StaticFunctionCodeBuilder.ToString());
                }

                if (!haveCctor) {
                    sb.AppendFormat("{0}cctor = function(){{", GetIndentString(indent));
                    sb.AppendLine();
                    ++indent;
                    if (!string.IsNullOrEmpty(baseClass) && myselfDefinedBaseClass) {
                        sb.AppendFormat("{0}callstatic({1}, \"cctor\");", GetIndentString(indent), baseClass);
                        sb.AppendLine();
                    }
                    sb.AppendFormat("{0}callstatic({1}, \"__cctor\");", GetIndentString(indent), key);
                    sb.AppendLine();
                    --indent;
                    sb.AppendFormat("{0}}};", GetIndentString(indent));
                    sb.AppendLine();
                }
                sb.AppendFormat("{0}__cctor = function(){{", GetIndentString(indent));
                sb.AppendLine();
                ++indent;
                sb.AppendFormat("{0}if({1}.__cctor_called){{", GetIndentString(indent), key);
                sb.AppendLine();
                ++indent;
                sb.AppendFormat("{0}return;", GetIndentString(indent));
                sb.AppendLine();
                --indent;
                sb.AppendFormat("{0}}}else{{", GetIndentString(indent));
                sb.AppendLine();
                ++indent;
                sb.AppendFormat("{0}{1}.__cctor_called = true;", GetIndentString(indent), key);
                sb.AppendLine();
                --indent;
                sb.AppendFormat("{0}}};", GetIndentString(indent));
                sb.AppendLine();
                //static initializer
                foreach (var ci in classes) {
                    sb.Append(ci.StaticInitializerCodeBuilder.ToString());
                }
                --indent;
                sb.AppendFormat("{0}}};", GetIndentString(indent));
                sb.AppendLine();

                --indent;
                sb.AppendFormat("{0}}};", GetIndentString(indent));
                sb.AppendLine();

                sb.AppendFormat("{0}static_fields {{", GetIndentString(indent));
                sb.AppendLine();
                ++indent;

                //static field
                foreach (var ci in classes) {
                    sb.Append(ci.StaticFieldCodeBuilder.ToString());
                }

                if (existAttributes) {
                    sb.AppendFormat("{0}__attributes = {1};", GetIndentString(indent), attributesName);
                    sb.AppendLine();
                }

                sb.AppendFormat("{0}__cctor_called = false;", GetIndentString(indent));
                sb.AppendLine();

                --indent;
                sb.AppendFormat("{0}}};", GetIndentString(indent));
                sb.AppendLine();

                bool hasStaticProp = false;
                foreach (var ci in classes) {
                    if (ci.StaticPropertyCodeBuilder.Length > 0)
                        hasStaticProp = true;
                }
                if (hasStaticProp) {
                    sb.AppendFormat("{0}static_props {{", GetIndentString(indent));
                    sb.AppendLine();

                    ++indent;

                    //static property
                    foreach (var ci in classes) {
                        sb.Append(ci.StaticPropertyCodeBuilder.ToString());
                    }

                    --indent;
                    sb.AppendFormat("{0}}};", GetIndentString(indent));
                    sb.AppendLine();
                }
                else {
                    sb.AppendFormat("{0}static_props {{}};", GetIndentString(indent));
                    sb.AppendLine();
                }

                bool hasStaticEvent = false;
                foreach (var ci in classes) {
                    if (ci.StaticEventCodeBuilder.Length > 0)
                        hasStaticEvent = true;
                }
                if (hasStaticEvent) {
                    sb.AppendFormat("{0}static_events {{", GetIndentString(indent));
                    sb.AppendLine();

                    ++indent;

                    //static event
                    foreach (var ci in classes) {
                        sb.Append(ci.StaticEventCodeBuilder.ToString());
                    }

                    --indent;
                    sb.AppendFormat("{0}}};", GetIndentString(indent));
                    sb.AppendLine();
                }
                else {
                    sb.AppendFormat("{0}static_events {{}};", GetIndentString(indent));
                    sb.AppendLine();
                }

                sb.AppendLine();

                if (!isStaticClass) {
                    sb.AppendFormat("{0}instance_methods {{", GetIndentString(indent));
                    sb.AppendLine();
                    ++indent;

                    //instance function
                    foreach (var ci in classes) {
                        sb.Append(ci.InstanceFunctionCodeBuilder.ToString());
                    }

                    if (!haveCtor) {
                        sb.AppendFormat("{0}ctor = function(this){{", GetIndentString(indent));
                        sb.AppendLine();
                        ++indent;
                        if (!string.IsNullOrEmpty(baseClass) && myselfDefinedBaseClass) {
                            sb.AppendFormat("{0}callinstance(getinstance(SymbolKind.Field, this, \"base\"), \"ctor\");", GetIndentString(indent));
                            sb.AppendLine();
                        }
                        sb.AppendFormat("{0}callinstance(this, \"__ctor\");", GetIndentString(indent));
                        sb.AppendLine();
                        --indent;
                        sb.AppendFormat("{0}}};", GetIndentString(indent));
                        sb.AppendLine();
                    }

                    sb.AppendFormat("{0}__ctor = function(this){{", GetIndentString(indent));
                    sb.AppendLine();
                    ++indent;
                    sb.AppendFormat("{0}if(getinstance(SymbolKind.Field, this, \"__ctor_called\")){{", GetIndentString(indent));
                    sb.AppendLine();
                    ++indent;
                    sb.AppendFormat("{0}return;", GetIndentString(indent));
                    sb.AppendLine();
                    --indent;
                    sb.AppendFormat("{0}}}else{{", GetIndentString(indent));
                    sb.AppendLine();
                    ++indent;
                    sb.AppendFormat("{0}setinstance(SymbolKind.Field, this, \"__ctor_called\", true);", GetIndentString(indent));
                    sb.AppendLine();
                    --indent;
                    sb.AppendFormat("{0}}};", GetIndentString(indent));
                    sb.AppendLine();
                    //instance initializer
                    foreach (var ci in classes) {
                        sb.Append(ci.InstanceInitializerCodeBuilder.ToString());
                    }
                    --indent;
                    sb.AppendFormat("{0}}};", GetIndentString(indent));
                    sb.AppendLine();

                    --indent;
                    sb.AppendFormat("{0}}};", GetIndentString(indent));
                    sb.AppendLine();

                    sb.AppendFormat("{0}instance_fields {{", GetIndentString(indent));
                    sb.AppendLine();
                    ++indent;

                    //instance field
                    foreach (var ci in classes) {
                        sb.Append(ci.InstanceFieldCodeBuilder.ToString());
                    }

                    if (existAttributes) {
                        sb.AppendFormat("{0}__attributes = {1};", GetIndentString(indent), attributesName);
                        sb.AppendLine();
                    }

                    sb.AppendFormat("{0}__ctor_called = false;", GetIndentString(indent));
                    sb.AppendLine();

                    --indent;
                    sb.AppendFormat("{0}}};", GetIndentString(indent));
                    sb.AppendLine();

                    bool hasInstanceProp = false;
                    foreach (var ci in classes) {
                        if (ci.InstancePropertyCodeBuilder.Length > 0)
                            hasInstanceProp = true;
                    }
                    if (hasInstanceProp) {
                        sb.AppendFormat("{0}instance_props {{", GetIndentString(indent));
                        sb.AppendLine();

                        ++indent;

                        //instance property
                        foreach (var ci in classes) {
                            sb.Append(ci.InstancePropertyCodeBuilder.ToString());
                        }

                        --indent;
                        sb.AppendFormat("{0}}};", GetIndentString(indent));
                        sb.AppendLine();
                    }
                    else {
                        sb.AppendFormat("{0}instance_props {{}};", GetIndentString(indent));
                        sb.AppendLine();
                    }

                    bool hasInstanceEvent = false;
                    foreach (var ci in classes) {
                        if (ci.InstanceEventCodeBuilder.Length > 0)
                            hasInstanceEvent = true;
                    }
                    if (hasInstanceEvent) {
                        sb.AppendFormat("{0}instance_events {{", GetIndentString(indent));
                        sb.AppendLine();

                        ++indent;

                        //instance event
                        foreach (var ci in classes) {
                            sb.Append(ci.InstanceEventCodeBuilder.ToString());
                        }

                        --indent;
                        sb.AppendFormat("{0}}};", GetIndentString(indent));
                        sb.AppendLine();
                    }
                    else {
                        sb.AppendFormat("{0}instance_events {{}};", GetIndentString(indent));
                        sb.AppendLine();
                    }

                    sb.AppendLine();

                    if (csi.InterfaceSymbols.Count > 0) {
                        sb.AppendFormat("{0}interfaces {{", GetIndentString(indent));
                        sb.AppendLine();
                        ++indent;

                        foreach (var intf in csi.InterfaceSymbols) {
                            sb.AppendFormat("{0}\"{1}\";", GetIndentString(indent), ClassInfo.GetFullName(intf));
                            sb.AppendLine();
                        }

                        --indent;
                        sb.AppendFormat("{0}}};", GetIndentString(indent));
                        sb.AppendLine();
                    }
                    else {
                        sb.AppendFormat("{0}interfaces {{}};", GetIndentString(indent));
                        sb.AppendLine();
                    }

                    if (csi.InterfaceMethodMap.Count > 0) {
                        sb.AppendFormat("{0}interface_map {{", GetIndentString(indent));
                        sb.AppendLine();
                        ++indent;

                        foreach (var pair in csi.InterfaceMethodMap) {
                            sb.AppendFormat("{0}{1} = \"{2}\";", GetIndentString(indent), pair.Key, pair.Value);
                            sb.AppendLine();
                        }

                        --indent;
                        sb.AppendFormat("{0}}};", GetIndentString(indent));
                        sb.AppendLine();
                    }
                    else {
                        sb.AppendFormat("{0}interface_map {{}};", GetIndentString(indent));
                        sb.AppendLine();
                    }

                    sb.AppendLine();

                    //修饰信息
                    var tsym = csi.TypeSymbol;
                    sb.AppendFormat("{0}class_info(TypeKind.{1}, Accessibility.{2}) {{", GetIndentString(indent), tsym.TypeKind, tsym.DeclaredAccessibility);
                    sb.AppendLine();
                    ++indent;

                    if (tsym.IsAbstract) {
                        sb.AppendFormat("{0}abstract(true);", GetIndentString(indent));
                        sb.AppendLine();
                    }
                    if (tsym.IsSealed) {
                        sb.AppendFormat("{0}sealed(true);", GetIndentString(indent));
                        sb.AppendLine();
                    }
                    if (tsym.IsStatic) {
                        sb.AppendFormat("{0}static(true);", GetIndentString(indent));
                        sb.AppendLine();
                    }

                    --indent;
                    sb.AppendFormat("{0}}};", GetIndentString(indent));
                    sb.AppendLine();

                    if (csi.MethodSymbols.Count > 0) {
                        sb.AppendFormat("{0}method_info {{", GetIndentString(indent));
                        sb.AppendLine();
                        ++indent;

                        foreach (var msym in csi.MethodSymbols) {
                            var name = SymbolTable.Instance.NameMangling(msym);
                            sb.AppendFormat("{0}{1}(MethodKind.{2}, Accessibility.{3}){{", GetIndentString(indent), name, msym.MethodKind, msym.DeclaredAccessibility);
                            sb.AppendLine();
                            ++indent;
                            string prestr = string.Empty;
                            if (msym.IsAbstract) {
                                sb.AppendFormat("{0}abstract(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (msym.IsVirtual) {
                                sb.AppendFormat("{0}virtual(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (msym.IsOverride) {
                                sb.AppendFormat("{0}override(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (msym.IsStatic) {
                                sb.AppendFormat("{0}static(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (msym.IsExtensionMethod) {
                                sb.AppendFormat("{0}extension(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (msym.IsGenericMethod) {
                                sb.AppendFormat("{0}generic(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (msym.IsSealed) {
                                sb.AppendFormat("{0}sealed(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (msym.IsVararg) {
                                sb.AppendFormat("{0}vararg(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            --indent;
                            sb.AppendFormat("{0}}};", GetIndentString(indent));
                            sb.AppendLine();
                        }

                        --indent;
                        sb.AppendFormat("{0}}};", GetIndentString(indent));
                        sb.AppendLine();
                    }
                    else {
                        sb.AppendFormat("{0}method_info {{}};", GetIndentString(indent));
                        sb.AppendLine();
                    }

                    if (csi.PropertySymbols.Count > 0) {
                        sb.AppendFormat("{0}property_info {{", GetIndentString(indent));
                        sb.AppendLine();
                        ++indent;

                        foreach (var psym in csi.PropertySymbols) {
                            var name = psym.Name;
                            sb.AppendFormat("{0}{1}(Accessibility.{2}){{", GetIndentString(indent), name, psym.DeclaredAccessibility);
                            sb.AppendLine();
                            ++indent;
                            string prestr = string.Empty;
                            if (psym.IsAbstract) {
                                sb.AppendFormat("{0}abstract(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (psym.IsVirtual) {
                                sb.AppendFormat("{0}virtual(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (psym.IsOverride) {
                                sb.AppendFormat("{0}override(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (psym.IsStatic) {
                                sb.AppendFormat("{0}static(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (psym.IsSealed) {
                                sb.AppendFormat("{0}sealed(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (psym.IsIndexer) {
                                sb.AppendFormat("{0}indexer(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (psym.IsReadOnly) {
                                sb.AppendFormat("{0}readonly(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (psym.IsWriteOnly) {
                                sb.AppendFormat("{0}writeonly(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            --indent;
                            sb.AppendFormat("{0}}};", GetIndentString(indent));
                            sb.AppendLine();
                        }

                        --indent;
                        sb.AppendFormat("{0}}};", GetIndentString(indent));
                        sb.AppendLine();
                    }
                    else {
                        sb.AppendFormat("{0}property_info {{}};", GetIndentString(indent));
                        sb.AppendLine();
                    }

                    if (csi.EventSymbols.Count > 0) {
                        sb.AppendFormat("{0}event_info {{", GetIndentString(indent));
                        sb.AppendLine();
                        ++indent;

                        foreach (var esym in csi.EventSymbols) {
                            var name = esym.Name;
                            sb.AppendFormat("{0}{1}(Accessibility.{2}){{", GetIndentString(indent), name, esym.DeclaredAccessibility);
                            sb.AppendLine();
                            ++indent;
                            string prestr = string.Empty;
                            if (esym.IsAbstract) {
                                sb.AppendFormat("{0}abstract(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (esym.IsVirtual) {
                                sb.AppendFormat("{0}virtual(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (esym.IsOverride) {
                                sb.AppendFormat("{0}override(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (esym.IsStatic) {
                                sb.AppendFormat("{0}static(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (esym.IsSealed) {
                                sb.AppendFormat("{0}sealed(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            --indent;
                            sb.AppendFormat("{0}}};", GetIndentString(indent));
                            sb.AppendLine();
                        }

                        --indent;
                        sb.AppendFormat("{0}}};", GetIndentString(indent));
                        sb.AppendLine();
                    }
                    else {
                        sb.AppendFormat("{0}event_info {{}};", GetIndentString(indent));
                        sb.AppendLine();
                    }

                    if (csi.FieldSymbols.Count > 0) {
                        sb.AppendFormat("{0}field_info {{", GetIndentString(indent));
                        sb.AppendLine();
                        ++indent;

                        foreach (var fsym in csi.FieldSymbols) {
                            if (fsym.IsImplicitlyDeclared)
                                continue;
                            var name = fsym.Name;
                            sb.AppendFormat("{0}{1}(Accessibility.{2}){{", GetIndentString(indent), name, fsym.DeclaredAccessibility);
                            sb.AppendLine();
                            ++indent;
                            string prestr = string.Empty;
                            if (fsym.IsStatic) {
                                sb.AppendFormat("{0}static(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (fsym.IsReadOnly) {
                                sb.AppendFormat("{0}readonly(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (fsym.IsConst) {
                                sb.AppendFormat("{0}const(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            if (fsym.IsVolatile) {
                                sb.AppendFormat("{0}volatile(true);", GetIndentString(indent));
                                sb.AppendLine();
                            }
                            --indent;
                            sb.AppendFormat("{0}}};", GetIndentString(indent));
                            sb.AppendLine();
                        }

                        --indent;
                        sb.AppendFormat("{0}}};", GetIndentString(indent));
                        sb.AppendLine();
                    }
                    else {
                        sb.AppendFormat("{0}field_info {{}};", GetIndentString(indent));
                        sb.AppendLine();
                    }
                }
            }

            --indent;
            sb.AppendFormat("{0}}};", GetIndentString(indent));
            sb.AppendLine();

            foreach (var ci in classes) {
                sb.Append(ci.AfterOuterCodeBuilder.ToString());
            }
            sb.AppendLine();

            sb.AppendLine();
            BuildInterfaces(sb, mci.InnerInterfaces);
            sb.AppendLine();

            foreach (var pair in mci.InnerClasses) {
                BuildDslClass(sb, pair.Key, pair.Value, false, dsllibRefs);
            }
            if (isEntryClass) {
                sb.AppendFormat("defineentry({0});", key);
                sb.AppendLine();
            }

            return fileName;
        }
        private static void BuildReferences(StringBuilder sb, string key, MergedClassInfo mci, HashSet<string> refs)
        {
            var classes = mci.Classes;
            foreach (var ci in classes) {
                foreach (string r in ci.References) {
                    if (!r.StartsWith("System.") && !r.StartsWith("UnityEngine.")) {
                        string refname = r.Replace(".", "__");
                        if (!refs.Contains(refname)) {
                            sb.AppendFormat("require(\"{0}\");", refname.ToLower());
                            sb.AppendLine();
                            refs.Add(refname);
                        }
                    }
                }
            }
            foreach (var pair in mci.InnerClasses) {
                BuildReferences(sb, pair.Key, pair.Value, refs);
            }
        }

        private static string GetIndentString(int indent)
        {
            return CsDslTranslater.GetIndentString(indent);
        }

        private static void LockWriteLine(StreamWriter sw, string fmt, params object[] args)
        {
            lock (sw) {
                sw.WriteLine(fmt, args);
            }
        }

        private static bool IsIgnoredFile(IList<string> ignoredPath, string filePath)
        {
            bool ret = false;
            foreach (string path in ignoredPath) {
                if (filePath.StartsWith(path)) {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        private static bool IsExternFile(IList<string> externPath, string filePath)
        {
            bool ret = false;
            foreach (string path in externPath) {
                if (filePath.StartsWith(path)) {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        private static bool IsInternFile(IList<string> internPath, string filePath)
        {
            bool ret = false;
            foreach (string path in internPath) {
                if (filePath.StartsWith(path)) {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        private static string ParseProjectOutputFile(string srcFile, string prjName)
        {
            string fileName = prjName + ".dll";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(srcFile);
            var nodes = SelectNodes(xmlDoc, "PropertyGroup");
            foreach (XmlElement node in nodes) {
                var typeNode = SelectSingleNode(node, "OutputType");
                var nameNode = SelectSingleNode(node, "AssemblyName");
                if (null != typeNode && null != nameNode) {
                    string type = typeNode.InnerText.Trim();
                    string name = nameNode.InnerText.Trim();
                    fileName = name + (type == "Library" ? ".dll" : ".exe");
                }
            }
            return fileName;
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
                        }
                        else {
                            list.Add(element);
                        }
                    }
                    else if (index == 0) {
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
                        }
                        else {
                            ret = element;
                        }
                    }
                    else if (index == 0) {
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
