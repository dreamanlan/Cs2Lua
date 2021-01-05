using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;

namespace Generator
{
    internal static class StringBuilderExtension
    {
        public static void AppendFormatLine(this StringBuilder sb, string format, params object[] args)
        {
            sb.AppendFormat(format, args);
            sb.AppendLine();
        }
    }
    internal static partial class LuaGenerator
    {
        internal static void Generate(string csprojPath, string outPath, string ext, bool parallel)
        {
            if (string.IsNullOrEmpty(outPath)) {
                outPath = Path.Combine(csprojPath, "lua");
            }
            else if (!Path.IsPathRooted(outPath)) {
                outPath = Path.Combine(csprojPath, outPath);
            }

            s_ExePath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            s_SrcPath = Path.Combine(csprojPath, "dsl");
            s_LogPath = Path.Combine(csprojPath, "log");
            s_OutPath = outPath;
            s_Ext = ext;
            ReadConfig();
            if (!Directory.Exists(s_OutPath)) {
                Directory.CreateDirectory(s_OutPath);
            }
            File.Copy(Path.Combine(s_ExePath, "lualib/syslib.lua"), Path.Combine(s_OutPath, "cs2lua__syslib." + s_Ext), true);
            var files = Directory.GetFiles(s_SrcPath, "*.dsl", SearchOption.TopDirectoryOnly);
            Action<string> handler = (file) => {
                try {
                    string fileName = Path.GetFileNameWithoutExtension(file);

                    Dsl.DslFile dslFile = new Dsl.DslFile();
                    dslFile.Load(file, s => Log(file, s));

                    GenerateLua(dslFile, Path.Combine(s_OutPath, Path.ChangeExtension(fileName.Replace("cs2dsl__", "cs2lua__"), s_Ext)), fileName);
                }
                catch (Exception ex) {
                    string id = string.Empty;
                    int line = 0;
                    if (null != s_CurSyntax) {
                        id = s_CurSyntax.GetId();
                        if (null == id)
                            id = string.Empty;
                        line = s_CurSyntax.GetLine();
                    }
                    Log(file, string.Format("[{0}:{1}]:exception:{2}\n{3}", id, line, ex.Message, ex.StackTrace));
                    File.WriteAllText(Path.Combine(s_LogPath, "Generator.log"), s_LogBuilder.ToString());
                    throw ex;
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
            foreach (var pair in s_FileMergeInfos) {
                var info = pair.Value;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(info.CodeBuilder.ToString());
                foreach (string req in info.RequireList) {
                    sb.AppendFormatLine("{0}require \"{1}\";", GetIndentString(0), req);
                }
                foreach (string className in info.DefinedClasses) {
                    sb.AppendFormatLine("{0}settempmetatable({1});", GetIndentString(0), className);
                }
                if (!string.IsNullOrEmpty(info.EntryClass)) {
                    sb.AppendFormatLine("{0}defineentry({1});", GetIndentString(0), info.EntryClass);
                }
                File.WriteAllText(Path.Combine(s_OutPath, Path.ChangeExtension(info.MergedFileName, s_Ext)), sb.ToString());
            }
            File.WriteAllText(Path.Combine(s_LogPath, "Generator.log"), s_LogBuilder.ToString());
            string specialLib = Path.Combine(s_OutPath, "lualib_special.txt");
            using (var sw = new StreamWriter(specialLib, false)) {
                foreach (var pair in s_FunctionsFromDslHook) {
                    sw.Write(pair.Value);
                    sw.WriteLine();
                }
                sw.Close();
            }
        }
        internal static void GenerateArguments(Dsl.FunctionData data, StringBuilder sb, int indent, int start, FunctionOptions funcOpts, DslExpression.DslCalculator calculator)
        {
            s_CurSyntax = data;
            string prestr = string.Empty;
            for (int ix = start; ix < data.Params.Count; ++ix) {
                var param = data.Params[ix];
                sb.Append(prestr);
                string paramId = param.GetId();
                if (param.GetIdType() == (int)Dsl.ValueData.ID_TOKEN && paramId == "...") {
                    sb.Append("...");
                    continue;
                }
                GenerateSyntaxComponent(param, sb, indent, false, funcOpts, calculator);
                prestr = ", ";
            }
        }
        internal static void GenerateArguments(Dsl.FunctionData data, StringBuilder sb, int indent, IList<int> skips, FunctionOptions funcOpts, DslExpression.DslCalculator calculator)
        {
            s_CurSyntax = data;
            string prestr = string.Empty;
            for (int ix = 0; ix < data.Params.Count; ++ix) {
                if (skips.Contains(ix))
                    continue;
                var param = data.Params[ix];
                sb.Append(prestr);
                string paramId = param.GetId();
                if (param.GetIdType() == (int)Dsl.ValueData.ID_TOKEN && paramId == "...") {
                    sb.Append("...");
                    continue;
                }
                GenerateSyntaxComponent(param, sb, indent, false, funcOpts, calculator);
                prestr = ", ";
            }
        }
        internal static void GenerateCodeBlock(StringBuilder sb, int indent, string code)
        {
            GenerateCodeBlock(sb, indent, code, false);
        }
        internal static void GenerateCodeBlock(StringBuilder sb, int indent, string code, bool removeSemiColonAndNewLine)
        {
            int ix = 0;
            int whiteCount = 0;
            while (code.Length > ix && (code[ix] == '\t' || code[ix] == ' ')) {
                if (code[ix] == '\t')
                    whiteCount += 4;
                else
                    ++whiteCount;
                ++ix;
            }
            var lines = code.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int lineIx = 0; lineIx < lines.Length; ++lineIx) {
                var line = lines[lineIx].TrimEnd();
                int left = whiteCount;
                ix = 0;
                while (line.Length > ix && left > 0 && (line[ix] == '\t' || line[ix] == ' ')) {
                    if (line[ix] == '\t')
                        left -= 4;
                    else
                        --left;
                    ++ix;
                }
                sb.Append(GetIndentString(indent));
                if (removeSemiColonAndNewLine && lineIx == lines.Length - 1) {
                    int lastIx = line.Length - 1;
                    if (lastIx > 0 && line[lastIx] == ';')
                        sb.Append(line.Substring(ix, lastIx - ix));
                    else
                        sb.Append(line.Substring(ix));
                }
                else {
                    sb.AppendLine(line.Substring(ix));
                }
            }
        }
        internal static void ParseFunctionOptions(Dsl.FunctionData opts, FunctionOptions funcOpts)
        {
            foreach (var opt in opts.Params) {
                var optFd = opt as Dsl.FunctionData;
                if (null != optFd) {
                    if (optFd.GetId() == "needfuncinfo") {
                        funcOpts.NeedFuncInfo = optFd.GetParamId(0) == "true";
                    }
                    else if (optFd.GetId() == "rettype") {
                        var t = CalcTypeString(optFd.GetParam(0));
                        var tk = CalcTypeString(optFd.GetParam(1));
                        funcOpts.RetType = new TypeInfo { Type = t, TypeKind = tk };
                    }
                    else if (optFd.GetId() == "paramtype") {
                        var tn = optFd.GetParamId(0);
                        var t = CalcTypeString(optFd.GetParam(1));
                        var tk = CalcTypeString(optFd.GetParam(2));
                        funcOpts.ParamTypes.Add(tn, new TypeInfo { Type = t, TypeKind = tk });
                    }
                }
            }
        }
        internal static string CalcTypesString(Dsl.FunctionData cd)
        {
            StringBuilder sb = new StringBuilder();
            string prestr = string.Empty;
            foreach (var p in cd.Params) {
                var str = CalcTypeString(p);
                sb.Append(prestr);
                sb.Append(str);
                prestr = ":";
            }
            return sb.ToString();
        }
        internal static string CalcTypeString(Dsl.ISyntaxComponent comp)
        {
            string ret = comp.GetId();
            var cd = comp as Dsl.FunctionData;
            if (null != cd && cd.GetParamClass() == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD) {
                string prefix;
                if (cd.IsHighOrder) {
                    prefix = CalcTypeString(cd.LowerOrderFunction);
                }
                else {
                    prefix = cd.GetId();
                }
                ret = prefix + "." + cd.GetParamId(0);
            }
            return ret;
        }
        internal static string CalcExpressionString(Dsl.ISyntaxComponent comp, FunctionOptions funcOpts, DslExpression.DslCalculator calculator)
        {
            StringBuilder sb = new StringBuilder();
            GenerateSyntaxComponent(comp, sb, 0, false, funcOpts, calculator);
            return sb.ToString();
        }
        internal static Dsl.ISyntaxComponent FindParam(Dsl.FunctionData funcData, string key)
        {
            var fcd = funcData;
            if (funcData.IsHighOrder)
                fcd = funcData;
            foreach (var statement in fcd.Params) {
                if (key == statement.GetId()) {
                    return statement;
                }
            }
            return null;
        }
        internal static Dsl.ISyntaxComponent FindStatement(Dsl.FunctionData funcData, string key)
        {
            foreach (var statement in funcData.Params) {
                if (key == statement.GetId()) {
                    return statement;
                }
            }
            return null;
        }
        internal static string GetLastName(string fullName)
        {
            int ix = fullName.LastIndexOf('.');
            if (ix < 0)
                return fullName;
            else
                return fullName.Substring(ix + 1);
        }
        internal static string ConvertOperator(string id)
        {
            if (id == "!=") {
                id = "~=";
            }
            else if (id == "&&") {
                id = "and";
            }
            else if (id == "||") {
                id = "or";
            }
            else if (id == "!") {
                id = "not";
            }
            return id;
        }
        internal static void Log(string file, string msg)
        {
            s_LogBuilder.AppendFormatLine("[{0}]:{1}", file, msg);
        }
        internal static string GetIndentString(int indent)
        {
            const string c_IndentString = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t";
            return c_IndentString.Substring(0, indent);
        }
        internal static string GetArraySubscriptString(int index)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= index; ++i) {
                sb.AppendFormat("[i{0}]", i);
            }
            return sb.ToString();
        }
        internal static string Escape(string src)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < src.Length; ++i) {
                char c = src[i];
                string es = Escape(c);
                sb.Append(es);
            }
            return sb.ToString();
        }
        internal static string Escape(char c)
        {
            switch (c) {
                case '\a':
                    return "\\a";
                case '\b':
                    return "\\b";
                case '\f':
                    return "\\f";
                case '\n':
                    return "\\n";
                case '\r':
                    return "\\r";
                case '\t':
                    return "\\t";
                case '\v':
                    return "\\v";
                case '\\':
                    return "\\\\";
                case '\"':
                    return "\\\"";
                case '\'':
                    return "\\'";
                case '\0':
                    return "\\0";
                default:
                    return c.ToString();
            }
        }
        internal static bool TryGetSpecialIntegerOperatorIndex(string op, out int index)
        {
            index = s_SpecialIntegerOperators.IndexOf(op);
            return index >= 0;
        }
        internal static bool IsBasicType(string t, string typeKind, bool includeString)
        {
            if (typeKind == "TypeKind.Enum" || t == "System.Enum")
                return true;
            if (includeString && t == "System.String")
                return true;
            return s_BasicTypes.Contains(t);
        }
        internal static bool IsIntegerType(string t, string typeKind)
        {
            if (typeKind == "TypeKind.Enum" || t == "System.Enum")
                return true;
            return s_IntegerTypes.Contains(t);
        }
        internal static ConcurrentDictionary<string, string> FunctionsFromDslHook
        {
            get => s_FunctionsFromDslHook;
        }
        private static bool IsParamTypeCheckMethod(string className, string methodName)
        {
            if (s_ParamTypeCheckMethods.Count <= 0)
                return false;
            string key = string.Format("{0}.{1}", className, methodName);
            return s_ParamTypeCheckMethods.Contains(key);
        }
        private static bool DontRequire(string file, string require)
        {
            foreach (var info in s_DontRequireInfos) {
                if (!info.CachedNotExcepts.Contains(file)) {
                    if (info.Excepts.Contains(file)) {
                        continue;
                    }
                    foreach (var regex in info.ExceptMatches) {
                        if (regex.IsMatch(file)) {
                            info.Excepts.Add(file);
                            continue;
                        }
                    }
                    info.CachedNotExcepts.Add(file);
                }
                if (!info.CachedNotRequires.Contains(require)) {
                    if (info.Requires.Contains(require)) {
                        return true;
                    }
                    foreach (var regex in info.Matches) {
                        if (regex.IsMatch(require)) {
                            info.Requires.Add(require);
                            return true;
                        }
                    }
                    info.CachedNotRequires.Add(require);
                }
            }
            return false;
        }
        private static string GetMergedFile(string file)
        {
            string res;
            if (s_CachedFile2MergedFiles.TryGetValue(file, out res)) {
                return res;
            }
            foreach (var pair in s_FileMergeInfos) {
                var info = pair.Value;
                if (info.Lists.Contains(file)) {
                    s_CachedFile2MergedFiles.TryAdd(file, info.MergedFileName);
                    return info.MergedFileName;
                }
                foreach (var regex in info.Matches) {
                    if (regex.IsMatch(file)) {
                        s_CachedFile2MergedFiles.TryAdd(file, info.MergedFileName);
                        return info.MergedFileName;
                    }
                }
            }
            s_CachedFile2MergedFiles.TryAdd(file, null);
            return null;
        }
        private static bool IndexerByLualib(string objClassName, string obj, string className, string member, out int val)
        {
            string key = string.Format("{0}|{1}|{2}|{3}", objClassName, obj, className, member);
            if (s_CachedIndexerByLualibInfos.TryGetValue(key, out val)) {
                return val != 0;
            }
            foreach (var info in s_IndexerByLualibInfos) {
                if ((null == info.ObjectClassMatch || info.ObjectClassMatch.IsMatch(objClassName)) &&
                    (null == info.ObjectMatch || info.ObjectMatch.IsMatch(obj)) &&
                    (null == info.ClassMatch || info.ClassMatch.IsMatch(className)) &&
                    (null == info.MemberMatch || info.MemberMatch.IsMatch(member))) {
                    s_CachedIndexerByLualibInfos.TryAdd(key, info.IndexerType);
                    val = info.IndexerType;
                    return true;
                }
            }
            s_CachedIndexerByLualibInfos.TryAdd(key, 0);
            return false;
        }
        private static string CalcLogInfo(PrologueOrEpilogueInfo info, string className, string methodName)
        {
            string fmt = info.Format;
            var args = new string[info.Args.Length];
            for (int ix = 0; ix < args.Length; ++ix) {
                var arg = info.Args[ix];
                if (arg == "$class")
                    args[ix] = className;
                else if (arg == "$member")
                    args[ix] = methodName;
                else
                    args[ix] = arg;
            }
            return string.Format(fmt, args);
        }
        private static PrologueAndEpilogueInfo GetPrologueAndEpilogue(string _class, string _method)
        {
            string key = string.Format("{0}.{1}", _class, _method);
            PrologueAndEpilogueInfo info;
            if (s_CachedPrologueAndEpilogueInfos.TryGetValue(key, out info)) {
                return info;
            }
            info = new PrologueAndEpilogueInfo();
            foreach (var cfg in s_AddPrologueOrEpilogueInfos) {
                if (cfg.Lists.Contains(key)) {
                    if (cfg.IsPrologue)
                        info.PrologueInfo = cfg.LogInfo;
                    else
                        info.EpilogueInfo = cfg.LogInfo;
                }
                foreach (var regex in cfg.Matches) {
                    if (regex.IsMatch(key)) {
                        if (cfg.IsPrologue)
                            info.PrologueInfo = cfg.LogInfo;
                        else
                            info.EpilogueInfo = cfg.LogInfo;
                    }
                }
            }
            s_CachedPrologueAndEpilogueInfos.TryAdd(key, info);
            return info;
        }
        private static void ReadConfig()
        {
            s_GenClassInfo = false;
            s_GenMethodInfo = false;
            s_GenPropertyInfo = false;
            s_GenEventInfo = false;
            s_GenFieldInfo = false;

            s_ParamTypeCheckMethods.Clear();
            s_DontRequireInfos.Clear();
            s_FileMergeInfos.Clear();
            s_IndexerByLualibInfos.Clear();
            s_AddPrologueOrEpilogueInfos.Clear();
            s_CachedFile2MergedFiles.Clear();
            s_CachedIndexerByLualibInfos.Clear();
            s_CachedPrologueAndEpilogueInfos.Clear();

            var file = Path.Combine(s_ExePath, "cs2dsl.dsl");
            var dslFile = new Dsl.DslFile();
            if (dslFile.Load(file, msg => { Console.WriteLine(msg); })) {
                foreach (var info in dslFile.DslInfos) {
                    ReadConfig(info);
                }
            }
        }
        private static void ReadConfig(Dsl.ISyntaxComponent cfgInfo)
        {
            Dsl.FunctionData f = cfgInfo as Dsl.FunctionData;
            Dsl.StatementData info = cfgInfo as Dsl.StatementData;
            if (null == f && null != info) {
                f = info.First;
            }
            if (null == f)
                return;
            string id = cfgInfo.GetId();
            if(id == "checkparamtype") {
                foreach (var s in f.Params) {
                    s_ParamTypeCheckMethods.Add(s.GetId());
                }
            }
            else if (id == "dontrequire") {
                var cfg = new DontRequireInfo();
                foreach (var s in f.Params) {
                    cfg.Requires.Add(s.GetId());
                }
                if (null != info) {
                    for (int i = 1; i < info.GetFunctionNum(); ++i) {
                        f = info.GetFunction(i);
                        if (null != f) {
                            string fid = f.GetId();
                            if (fid == "match") {
                                foreach (var s in f.Params) {
                                    var str = s.GetId();
                                    var regex = new Regex(str, RegexOptions.Compiled);
                                    cfg.Matches.Add(regex);
                                }
                            }
                            else if (fid == "except") {
                                foreach (var s in f.Params) {
                                    cfg.Excepts.Add(s.GetId());
                                }
                            }
                            else if (fid == "exceptmatch") {
                                foreach (var s in f.Params) {
                                    var str = s.GetId();
                                    var regex = new Regex(str, RegexOptions.Compiled);
                                    cfg.ExceptMatches.Add(regex);
                                }
                            }
                        }
                    }
                }
                s_DontRequireInfos.Add(cfg);
            }
            else if (id == "filemerge") {
                var cfg = new FileMergeInfo();
                if (f.GetParamNum() > 0) {
                    var s = f.GetParamId(0);
                    cfg.MergedFileName = s;
                }
                if (null != info) {
                    for (int i = 1; i < info.GetFunctionNum(); ++i) {
                        f = info.GetFunction(i);
                        if (null != f) {
                            string fid = f.GetId();
                            if (fid == "list") {
                                foreach (var s in f.Params) {
                                    cfg.Lists.Add(s.GetId());
                                }
                            }
                            else if (fid == "match") {
                                foreach (var s in f.Params) {
                                    var str = s.GetId();
                                    var regex = new Regex(str, RegexOptions.Compiled);
                                    cfg.Matches.Add(regex);
                                }
                            }
                        }
                    }
                }
                s_FileMergeInfos.Add(cfg.MergedFileName, cfg);
            }
            else if (id == "indexerbylualib") {
                var cfg = new IndexerByLualibInfo();
                Dsl.FunctionData fcd = f.ThisOrLowerOrderCall;
                if (fcd.IsValid() && fcd.GetParamNum() >= 4) {
                    var str = fcd.GetParamId(0);
                    var regex = new Regex(str, RegexOptions.Compiled);
                    cfg.ObjectClassMatch = regex;
                    str = fcd.GetParamId(1);
                    regex = new Regex(str, RegexOptions.Compiled);
                    cfg.ObjectMatch = regex;
                    str = fcd.GetParamId(2);
                    regex = new Regex(str, RegexOptions.Compiled);
                    cfg.ClassMatch = regex;
                    str = fcd.GetParamId(3);
                    regex = new Regex(str, RegexOptions.Compiled);
                    cfg.MemberMatch = regex;

                    if (f.HaveStatement()) {
                        foreach (var s in f.Params) {
                            var cd = s as Dsl.FunctionData;
                            if (null != cd) {
                                var attrId = cd.GetId();
                                if (attrId == "indexertype") {
                                    var attrVal = cd.GetParamId(0);
                                    int.TryParse(attrVal, out cfg.IndexerType);
                                }
                            }
                        }
                    }
                }
                s_IndexerByLualibInfos.Add(cfg);
            }
            else if (id == "addprologue" || id == "addepilogue") {
                var cfg = new AddPrologueOrEpilogueInfo();
                cfg.IsPrologue = id == "addprologue";
                int pnum = f.GetParamNum();
                if (pnum > 0) {
                    var fmt = f.GetParamId(0);
                    cfg.LogInfo.Format = fmt;
                    var list = new List<string>();
                    for (int ix = 1; ix < pnum; ++ix) {
                        var arg = f.GetParamId(ix);
                        list.Add(arg);
                    }
                    cfg.LogInfo.Args = list.ToArray();
                }
                if (null != info) {
                    for (int i = 1; i < info.GetFunctionNum(); ++i) {
                        f = info.GetFunction(i);
                        if (null != f) {
                            string fid = f.GetId();
                            if (fid == "list") {
                                foreach (var p in f.Params) {
                                    cfg.Lists.Add(p.GetId());
                                }
                            }
                            else if (fid == "match") {
                                foreach (var p in f.Params) {
                                    var str = p.GetId();
                                    var regex = new Regex(str, RegexOptions.Compiled);
                                    cfg.Matches.Add(regex);
                                }
                            }
                        }
                    }
                }
                s_AddPrologueOrEpilogueInfos.Add(cfg);
            }
            else if (id == "genclassinfo") {
                int pnum = f.GetParamNum();
                if (pnum > 0) {
                    var val = f.GetParamId(0);
                    bool.TryParse(val, out s_GenClassInfo);
                }
            }
            else if (id == "genmethodinfo") {
                int pnum = f.GetParamNum();
                if (pnum > 0) {
                    var val = f.GetParamId(0);
                    bool.TryParse(val, out s_GenMethodInfo);
                }
            }
            else if (id == "genpropertyinfo") {
                int pnum = f.GetParamNum();
                if (pnum > 0) {
                    var val = f.GetParamId(0);
                    bool.TryParse(val, out s_GenPropertyInfo);
                }
            }
            else if (id == "geneventinfo") {
                int pnum = f.GetParamNum();
                if (pnum > 0) {
                    var val = f.GetParamId(0);
                    bool.TryParse(val, out s_GenEventInfo);
                }
            }
            else if (id == "genfieldinfo") {
                int pnum = f.GetParamNum();
                if (pnum > 0) {
                    var val = f.GetParamId(0);
                    bool.TryParse(val, out s_GenFieldInfo);
                }
            }
        }

        [ThreadStatic]
        private static Dsl.ISyntaxComponent s_CurSyntax = null;
        private static string s_ExePath = string.Empty;
        private static string s_SrcPath = string.Empty;
        private static string s_LogPath = string.Empty;
        private static string s_OutPath = string.Empty;
        private static string s_Ext = string.Empty;
        private static StringBuilder s_LogBuilder = new StringBuilder();
        //下面这个list的顺序要与lualib.lua里的整数操作表__cs2lua_special_integer_operators一致（索引用作操作符识别常量）
        private static List<string> s_SpecialIntegerOperators = new List<string> { "/", "%", "+", "-", "*", "<<", ">>", "&", "|", "^", "~" };

        private static Dictionary<string, string> s_UnaryFunctor = new Dictionary<string, string> {
            {"~", "bitnot"},
        };
        private static Dictionary<string, string> s_BinaryFunctor = new Dictionary<string, string> {
            {"<<", "lshift"},
            {">>", "rshift"},
            {"&", "bitand"},
            {"|", "bitor"},
            {"^", "bitxor"},
        };
        private static HashSet<string> s_BasicTypes = new HashSet<string> {
            "System.Boolean", "System.Byte", "System.SByte", "System.Int16", "System.UInt16", "System.Int32", "System.UInt32", "System.Int64", "System.UInt64", "System.Single", "System.Double"
        };
        private static HashSet<string> s_IntegerTypes = new HashSet<string> {
            "System.Byte", "System.SByte", "System.Int16", "System.UInt16", "System.Int32", "System.UInt32", "System.Int64", "System.UInt64"
        };

        internal class TypeInfo
        {
            internal string Type = string.Empty;
            internal string TypeKind = string.Empty;
        }
        internal class FunctionOptions
        {
            internal bool NeedFuncInfo = false;
            internal TypeInfo RetType = null;
            internal Dictionary<string, TypeInfo> ParamTypes = new Dictionary<string, TypeInfo>();
        }

        private class DontRequireInfo
        {
            internal HashSet<string> Requires = new HashSet<string>();
            internal List<Regex> Matches = new List<Regex>();
            internal HashSet<string> Excepts = new HashSet<string>();
            internal List<Regex> ExceptMatches = new List<Regex>();

            internal HashSet<string> CachedNotRequires = new HashSet<string>();
            internal HashSet<string> CachedNotExcepts = new HashSet<string>();
        }

        private class FileMergeInfo
        {
            internal string MergedFileName = string.Empty;
            internal string EntryClass = string.Empty;
            internal HashSet<string> Lists = new HashSet<string>();
            internal List<Regex> Matches = new List<Regex>();
            internal StringBuilder CodeBuilder = new StringBuilder();

            internal HashSet<string> Requires = new HashSet<string>();
            internal List<string> RequireList = new List<string>();
            internal List<string> DefinedClasses = new List<string>();
        }

        private enum IndexerTypeEnum : int
        {
            NotByLualib = 0,
            LikeArray,
            Other
        }

        private class IndexerByLualibInfo
        {
            internal Regex ObjectClassMatch = null;
            internal Regex ObjectMatch = null;
            internal Regex ClassMatch = null;
            internal Regex MemberMatch = null;
            internal int IndexerType = (int)IndexerTypeEnum.Other;
        }

        private class PrologueOrEpilogueInfo
        {
            internal string Format = string.Empty;
            internal string[] Args = null;
        }

        private class PrologueAndEpilogueInfo
        {
            internal PrologueOrEpilogueInfo PrologueInfo = null;
            internal PrologueOrEpilogueInfo EpilogueInfo = null;
        }

        private class AddPrologueOrEpilogueInfo
        {
            internal bool IsPrologue = true;
            internal PrologueOrEpilogueInfo LogInfo = new PrologueOrEpilogueInfo();
            internal HashSet<string> Lists = new HashSet<string>();
            internal List<Regex> Matches = new List<Regex>();
        }

        private static bool s_GenClassInfo = false;
        private static bool s_GenMethodInfo = false;
        private static bool s_GenPropertyInfo = false;
        private static bool s_GenEventInfo = false;
        private static bool s_GenFieldInfo = false;

        private static HashSet<string> s_ParamTypeCheckMethods = new HashSet<string>();
        private static List<DontRequireInfo> s_DontRequireInfos = new List<DontRequireInfo>();
        private static Dictionary<string, FileMergeInfo> s_FileMergeInfos = new Dictionary<string, FileMergeInfo>();
        private static List<IndexerByLualibInfo> s_IndexerByLualibInfos = new List<IndexerByLualibInfo>();
        private static List<AddPrologueOrEpilogueInfo> s_AddPrologueOrEpilogueInfos = new List<AddPrologueOrEpilogueInfo>();
        private static ConcurrentDictionary<string, string> s_CachedFile2MergedFiles = new ConcurrentDictionary<string, string>();
        private static ConcurrentDictionary<string, int> s_CachedIndexerByLualibInfos = new ConcurrentDictionary<string, int>();
        private static ConcurrentDictionary<string, PrologueAndEpilogueInfo> s_CachedPrologueAndEpilogueInfos = new ConcurrentDictionary<string, PrologueAndEpilogueInfo>();
        private static ConcurrentDictionary<string, string> s_FunctionsFromDslHook = new ConcurrentDictionary<string, string>();
    }
}
