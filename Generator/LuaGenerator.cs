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
    internal static class LuaGenerator
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
            File.Copy(Path.Combine(s_ExePath, "lualib/lualib.lua"), Path.Combine(s_OutPath, "cs2lua__lualib." + s_Ext), true);
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
                    System.Environment.Exit(-1);
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
            System.Environment.Exit(0);
        }
        private static void GenerateLua(Dsl.DslFile dslFile, string outputFile, string fileName)
        {
            var myselfNewRequire = GetMergedFile(fileName);
            FileMergeInfo mergedInfo = null;
            if (!string.IsNullOrEmpty(myselfNewRequire)) {
                s_FileMergeInfos.TryGetValue(myselfNewRequire, out mergedInfo);
            }

            string entryClass = string.Empty;
            HashSet<string> requires = new HashSet<string>();
            List<string> requireList = new List<string>();
            StringBuilder sb = new StringBuilder();
            Stack<string> classDefineStack = new Stack<string>();
            string prestr = string.Empty;
            int indent = 0;
            bool firstRequire = true;
            bool firstAttrs = true;
            foreach (var dslInfo in dslFile.DslInfos) {
                s_CurSyntax = dslInfo;
                string id = dslInfo.GetId();                
                Dsl.FunctionData funcData = dslInfo as Dsl.FunctionData;
                Dsl.FunctionData callData = funcData;
                if (null != funcData && funcData.IsHighOrder) {
                    callData = funcData.LowerOrderFunction;
                }
                if (id == "require") {
                    string requireFileName = callData.GetParamId(0).Replace("cs2dsl__", "cs2lua__");
                    string srcPath = Path.Combine(s_ExePath, string.Format("lualib/{0}.lua", requireFileName));
                    string destPath = Path.Combine(s_OutPath, string.Format("{0}.{1}", requireFileName, s_Ext));
                    bool srcExist = File.Exists(srcPath);
                    bool destExist = File.Exists(destPath);
                    if (!destExist && srcExist) {
                        File.Copy(srcPath, destPath, true);
                    }
                    if ((srcExist || requireFileName.StartsWith("cs2lua__")) && null != mergedInfo && mergedInfo.CodeBuilder.Length > 0) {
                        //合并的文件，只有第一个文件require基础库
                    }
                    else {
                        if (firstRequire) {
                            sb.AppendLine("require \"cs2lua__namespaces\"; ");
                            firstRequire = false;
                        }
                        if (requireFileName != "cs2lua__namespaces" && !DontRequire(fileName, requireFileName)) {
                            var newRequire = GetMergedFile(requireFileName);
                            if (null != newRequire) {
                                if (newRequire != myselfNewRequire && !requires.Contains(newRequire)) {
                                    requires.Add(newRequire);
                                    requireList.Add(newRequire);
                                }
                            }
                            else if (!requires.Contains(requireFileName)) {
                                requires.Add(requireFileName);
                                requireList.Add(requireFileName);
                            }
                        }
                    }
                }
                else if (id == "defineentry") {
                    entryClass = CalcTypeString(callData.GetParam(0));
                }
                else if (id == "attributes") {
                    if (firstAttrs) {
                        sb.AppendLine("__cs2lua__AllAttrs = {};");
                        firstAttrs = false;
                    }
                    string className = CalcTypeString(callData.GetParam(0));
                    sb.AppendFormatLine("{0}__cs2lua__AllAttrs[\"{1}\"] = {{", GetIndentString(indent), className);
                    ++indent;
                    var classAttr = FindStatement(funcData, "class") as Dsl.FunctionData;
                    if (null != classAttr) {
                        sb.AppendFormatLine("{0}Class = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var comp in classAttr.Params) {
                            GenerateAttribute(comp, sb, indent);
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    foreach (var mattr in funcData.Params) {
                        if (mattr.GetId() == "class")
                            continue;
                        var fd = mattr as Dsl.FunctionData;
                        if (null != fd) {
                            var fcd = fd;
                            if (fd.IsHighOrder)
                                fcd = fd.LowerOrderFunction;
                            var mid = fcd.GetParamId(0);
                            sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mid);
                            ++indent;
                            foreach (var comp in fd.Params) {
                                GenerateAttribute(comp, sb, indent);
                            }
                            --indent;
                            sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                        }
                    }
                    --indent;
                    sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                }
                else if (id == "namespace") {
                    string ns = CalcTypeString(callData.GetParam(0));
                    sb.AppendFormatLine("{0}{1} = {1} or {{}};", GetIndentString(indent), ns, ns);
                }
                else if (id == "interface") {
                    string intfName = CalcTypeString(callData.GetParam(0));
                    sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), intfName);
                    ++indent;
                    sb.AppendFormatLine("{0}__cs2lua_defined = true, ", GetIndentString(indent));
                    sb.AppendFormatLine("{0}__cs2lua_fullname = \"{1}\", ", GetIndentString(indent), intfName);
                    sb.AppendFormatLine("{0}__cs2lua_typename = \"{1}\", ", GetIndentString(indent), GetLastName(intfName));
                    sb.AppendFormatLine("{0}__interfaces = {{", GetIndentString(indent));
                    ++indent;
                    var intfs = FindStatement(funcData, "interfaces") as Dsl.FunctionData;
                    if (null != intfs) {
                        foreach (var comp in intfs.Params) {
                            sb.AppendFormatLine("{0}\"{1}\"", prestr, comp.GetId());
                            prestr = ", ";
                        }
                    }
                    --indent;
                    sb.AppendFormatLine("{0}}}, ", GetIndentString(indent));
                    sb.AppendFormatLine("{0}__exist = function(k) return false; end", GetIndentString(indent));
                    --indent;
                    sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                }
                else if (id == "defineentry") {
                    string className = CalcTypeString(callData.GetParam(0));
                    sb.AppendFormatLine("{0}defineentry({1});", GetIndentString(indent), className);
                }
                else if (id == "enum") {
                    string className = CalcTypeString(callData.GetParam(0));
                    var baseClass = callData.GetParam(1);
                    string baseClassName = string.Empty;
                    if (null != baseClass) {
                        baseClassName = CalcTypeString(baseClass);
                    }

                    sb.AppendLine();

                    sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), className);
                    ++indent;
                    foreach (var comp in funcData.Params) {
                        var cd = comp as Dsl.FunctionData;
                        if (null != cd) {
                            sb.AppendFormatLine("{0}[\"{1}\"] = {2},", GetIndentString(indent), cd.GetParamId(0), cd.GetParamId(1));
                        }
                    }
                    --indent;
                    sb.AppendFormatLine("{0}}};", GetIndentString(indent));

                    sb.AppendLine();

                    sb.AppendFormatLine("{0}rawset({1}, \"Value2String\", {{", GetIndentString(indent), className);
                    ++indent;
                    foreach (var comp in funcData.Params) {
                        var cd = comp as Dsl.FunctionData;
                        if (null != cd) {
                            sb.AppendFormatLine("{0}[{1}] = \"{2}\",", GetIndentString(indent), cd.GetParamId(1), cd.GetParamId(0));
                        }
                    }
                    --indent;
                    sb.AppendFormatLine("{0}}});", GetIndentString(indent));
                }
                else if (id == "class" || id == "struct") {
                    string className = CalcTypeString(callData.GetParam(0));
                    var baseClass = callData.GetParam(1);
                    string baseClassName = string.Empty;
                    if (null != baseClass) {
                        baseClassName = CalcTypeString(baseClass);
                    }
                    bool isValueType = id == "struct";

                    sb.AppendLine();

                    sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), className);
                    ++indent;

                    var staticMethods = FindStatement(funcData, "static_methods") as Dsl.FunctionData;
                    if (null != staticMethods) {
                        foreach (var def in staticMethods.Params) {
                            var mdef = def as Dsl.FunctionData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var fdef = mdef.GetParam(1) as Dsl.FunctionData;
                                if (null != fdef) {
                                    if (fdef.HaveStatement()) {
                                        var fcall = fdef;
                                        if (fdef.IsHighOrder)
                                            fcall = fdef.LowerOrderFunction;
                                        bool haveParams = false;
                                        sb.AppendFormat("{0}{1} = {2}(", GetIndentString(indent), mname, fcall.GetId());
                                        prestr = string.Empty;
                                        for (int ix = 0; ix < fcall.Params.Count; ++ix) {
                                            var param = fcall.Params[ix];
                                            sb.Append(prestr);
                                            prestr = ", ";
                                            var pv = param as Dsl.ValueData;
                                            if (null != pv) {
                                                var pname = pv.GetId();
                                                if (ix == fcall.Params.Count - 1 && pname == "...")
                                                    haveParams = true;
                                                sb.Append(pname);
                                            }
                                            else {
                                                var pc = param as Dsl.FunctionData;
                                                if (null != pc) {
                                                    var pname = pc.GetParamId(0);
                                                    if (ix == fcall.Params.Count - 1 && pname == "...")
                                                        haveParams = true;
                                                    sb.Append(pname);
                                                }
                                            }
                                        }
                                        sb.AppendLine(")");
                                        ++indent;
                                        var logInfo = GetPrologueAndEpilogue(className, mname);
                                        if (null != logInfo.PrologueInfo) {
                                            sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfo.PrologueInfo, className, mname));
                                        }
                                        if (null != logInfo.EpilogueInfo) {
                                            sb.AppendFormatLine("{0}return (function(...) local args={{...}}; {1}; return ...; end)((function({2}) ", GetIndentString(indent), CalcLogInfo(logInfo.EpilogueInfo, className, mname), haveParams ? "..." : string.Empty);
                                        }
                                        foreach (var comp in fdef.Params) {
                                            GenerateSyntaxComponent(comp, sb, indent, true);
                                            string subId = comp.GetId();
                                            if (subId != "comments" && subId != "comment") {
                                                sb.AppendLine(";");
                                            }
                                            else {
                                                sb.AppendLine();
                                            }
                                        }
                                        if (null != logInfo.EpilogueInfo) {
                                            sb.AppendFormatLine("{0}end)({1}));", GetIndentString(indent), haveParams ? "..." : string.Empty);
                                        }
                                        --indent;
                                        sb.AppendFormatLine("{0}end,", GetIndentString(indent));
                                    }
                                    else {
                                        sb.AppendFormat("{0}{1} = ", GetIndentString(indent), mname);
                                        GenerateSyntaxComponent(fdef, sb, indent, false);
                                        sb.AppendFormatLine(",");
                                    }
                                }
                            }
                        }
                    }

                    var logInfoForDefineClass = GetPrologueAndEpilogue(className, "__define_class");
                    sb.AppendFormatLine("{0}__define_class = function()", GetIndentString(indent));
                    ++indent;
                    if (null != logInfoForDefineClass.PrologueInfo) {
                        sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfoForDefineClass.PrologueInfo, className, "__define_class"));
                    }
                    sb.AppendLine();

                    sb.AppendFormatLine("{0}local class = {1};", GetIndentString(indent), className);
                    sb.AppendFormatLine("{0}local static_fields_build = function()", GetIndentString(indent));
                    ++indent;
                    sb.AppendFormatLine("{0}local static_fields = {{", GetIndentString(indent));
                    ++indent;

                    var staticFields = FindStatement(funcData, "static_fields") as Dsl.FunctionData;
                    if (null != staticFields) {
                        foreach (var def in staticFields.Params) {
                            var mdef = def as Dsl.FunctionData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var comp = mdef.GetParam(1);
                                sb.AppendFormat("{0}{1} = ", GetIndentString(indent), mname);
                                GenerateFieldValueComponent(comp, sb, indent, false);
                                sb.AppendLine(",");
                            }
                        }
                    }

                    --indent;
                    sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    sb.AppendFormatLine("{0}return static_fields;", GetIndentString(indent));
                    --indent;
                    sb.AppendFormatLine("{0}end;", GetIndentString(indent));
                    
                    sb.AppendLine();

                    var instMethods = FindStatement(funcData, "instance_methods") as Dsl.FunctionData;
                    if (null != instMethods) {
                        sb.AppendFormatLine("{0}local instance_methods = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in instMethods.Params) {
                            var mdef = def as Dsl.FunctionData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var param1 = mdef.GetParam(1);
                                var fdef = param1 as Dsl.FunctionData;
                                if (null != fdef) {
                                    if (fdef.HaveStatement()) {
                                        var fcall = fdef;
                                        if (fdef.IsHighOrder)
                                            fcall = fdef.LowerOrderFunction;
                                        bool haveParams = false;
                                        sb.AppendFormat("{0}{1} = {2}(", GetIndentString(indent), mname, fcall.GetId());
                                        prestr = string.Empty;
                                        for (int ix = 0; ix < fcall.Params.Count; ++ix) {
                                            var param = fcall.Params[ix];
                                            string paramId = param.GetId();
                                            sb.Append(prestr);
                                            prestr = ", ";
                                            var pv = param as Dsl.ValueData;
                                            if (null != pv) {
                                                var pname = pv.GetId();
                                                if (ix == fcall.Params.Count - 1 && pname == "...")
                                                    haveParams = true;
                                                sb.Append(pname);
                                            }
                                            else {
                                                var pc = param as Dsl.FunctionData;
                                                if (null != pc) {
                                                    var pname = pc.GetParamId(0);
                                                    if (ix == fcall.Params.Count - 1 && pname == "...")
                                                        haveParams = true;
                                                    sb.Append(pname);
                                                }
                                            }
                                        }
                                        sb.AppendLine(")");
                                        ++indent;
                                        var logInfo = GetPrologueAndEpilogue(className, mname);
                                        if (null != logInfo.PrologueInfo) {
                                            sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfo.PrologueInfo, className, mname));
                                        }
                                        if (null != logInfo.EpilogueInfo) {
                                            sb.AppendFormatLine("{0}return (function(...) local args={{...}}; {1}; return ...; end)((function({2}) ", GetIndentString(indent), CalcLogInfo(logInfo.EpilogueInfo, className, mname), haveParams ? "..." : string.Empty);
                                        }
                                        foreach (var comp in fdef.Params) {
                                            GenerateSyntaxComponent(comp, sb, indent, true);
                                            string subId = comp.GetId();
                                            if (subId != "comments" && subId != "comment") {
                                                sb.AppendLine(";");
                                            }
                                            else {
                                                sb.AppendLine();
                                            }
                                        }
                                        if (null != logInfo.EpilogueInfo) {
                                            sb.AppendFormatLine("{0}end)({1}));", GetIndentString(indent), haveParams ? "..." : string.Empty);
                                        }
                                        --indent;
                                        sb.AppendFormatLine("{0}end,", GetIndentString(indent));
                                    }
                                    else {
                                        sb.AppendFormat("{0}{1} = ", GetIndentString(indent), mname);
                                        GenerateSyntaxComponent(fdef, sb, indent, false);
                                        sb.AppendFormatLine(",");
                                    }
                                }
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }

                    sb.AppendFormatLine("{0}local instance_fields_build = function()", GetIndentString(indent));
                    ++indent;
					
                    sb.AppendFormatLine("{0}local instance_fields = {{", GetIndentString(indent));
                    ++indent;

                    var instFields = FindStatement(funcData, "instance_fields") as Dsl.FunctionData;
                    if (null != instFields) {
                        foreach (var def in instFields.Params) {
                            var mdef = def as Dsl.FunctionData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var comp = mdef.GetParam(1);
                                sb.AppendFormat("{0}{1} = ", GetIndentString(indent), mname);
                                GenerateFieldValueComponent(comp, sb, indent, false);
                                sb.AppendLine(",");
                            }
                        }
                    }

                    --indent;
                    sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    sb.AppendFormatLine("{0}return instance_fields;", GetIndentString(indent));
                    --indent;
                    sb.AppendFormatLine("{0}end;", GetIndentString(indent));

                    sb.AppendLine();
                    if (null != logInfoForDefineClass.EpilogueInfo) {
                        sb.AppendFormatLine("{0}local __defineclass_return = defineclass({1}, \"{2}\", \"{3}\", class, static_fields_build, instance_methods, instance_fields_build, {4});", GetIndentString(indent), null == baseClass || !baseClass.IsValid() ? "nil" : baseClassName, className, GetLastName(className), isValueType ? "true" : "false");
                        sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfoForDefineClass.EpilogueInfo, className, "__define_class"));
                        sb.AppendFormatLine("{0}return __defineclass_return;", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}return defineclass({1}, \"{2}\", \"{3}\", class, static_fields_build, instance_methods, instance_fields_build, {4});", GetIndentString(indent), null == baseClass || !baseClass.IsValid() ? "nil" : baseClassName, className, GetLastName(className), isValueType ? "true" : "false");
                    }
                    --indent;
                    sb.AppendFormatLine("{0}end,", GetIndentString(indent));

                    sb.AppendLine();

                    var interfaces = FindStatement(funcData, "interfaces") as Dsl.FunctionData;
                    if (null != interfaces && interfaces.GetParamNum() > 0) {
                        sb.AppendFormatLine("{0}__interfaces = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in interfaces.Params) {
                            var mdef = def as Dsl.ValueData;
                            sb.AppendFormatLine("{0}\"{1}\",", GetIndentString(indent), mdef.GetId());
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}__interfaces = nil,", GetIndentString(indent));
                    }

                    bool sealedClass = false;
                    bool staticClass = false;
                    var classInfo = FindStatement(funcData, "class_info") as Dsl.FunctionData;
                    if (null != classInfo) {
                        foreach (var def in classInfo.Params) {
                            var mdef = def as Dsl.FunctionData;
                            string key = mdef.GetId();
                            string val = mdef.GetParamId(0);
                            bool bv;
                            bool.TryParse(val, out bv);
                            if (key == "sealed") {
                                sealedClass = true;
                                break;
                            }
                            else if (key == "static") {
                                staticClass = true;
                                break;
                            }
                        }
                    }
                    if (s_GenClassInfo && null != classInfo) {
                        var fcall = classInfo;
                        if (classInfo.IsHighOrder)
                            fcall = classInfo.LowerOrderFunction;
                        sb.AppendFormatLine("{0}__class_info = {{", GetIndentString(indent));
                        ++indent;
                        var kind = CalcTypeString(fcall.GetParam(0));
                        var accessibility = CalcTypeString(fcall.GetParam(1));
                        sb.AppendFormatLine("{0}Kind = {1},", GetIndentString(indent), kind);
                        if (accessibility == "Accessibility.Private") {
                            sb.AppendFormatLine("{0}private = true,", GetIndentString(indent));
                        }
                        foreach (var def in classInfo.Params) {
                            var mdef = def as Dsl.FunctionData;
                            string key = mdef.GetId();
                            string val = mdef.GetParamId(0);
                            sb.AppendFormatLine("{0}{1} = {2},", GetIndentString(indent), key, val);
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}__class_info = nil,", GetIndentString(indent));
                    }

                    var methodInfo = FindStatement(funcData, "method_info") as Dsl.FunctionData;
                    if ((!sealedClass && !staticClass || s_GenMethodInfo) && null != methodInfo && methodInfo.GetParamNum() > 0) {
                        sb.AppendFormatLine("{0}__method_info = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in methodInfo.Params) {
                            var mfunc = def as Dsl.FunctionData;
                            if (null != mfunc) {
                                var fcall = mfunc;
                                if (mfunc.IsHighOrder)
                                    fcall = mfunc.LowerOrderFunction;
                                bool gen = s_GenMethodInfo;
                                if (!gen) {
                                    if (mfunc.GetId().StartsWith("ctor")) {
                                        gen = true;
                                    }
                                    else {
                                        var accessibility = CalcTypeString(fcall.GetParam(1));
                                        if (accessibility != "Accessibility.Private") {
                                            gen = true;
                                        }
                                        foreach (var minfo in mfunc.Params) {
                                            var mdef = minfo as Dsl.FunctionData;
                                            string key = mdef.GetId();
                                            string val = mdef.GetParamId(0);
                                            bool bv;
                                            bool.TryParse(val, out bv);
                                            if (key == "sealed") {
                                                gen = false;
                                                break;
                                            }
                                            else if (key == "abstract" || key == "virtual" || key == "override") {
                                                gen = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                                if (gen) {
                                    sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mfunc.GetId());
                                    ++indent;
                                    var kind = CalcTypeString(fcall.GetParam(0));
                                    var accessibility = CalcTypeString(fcall.GetParam(1));
                                    sb.AppendFormatLine("{0}Kind = {1},", GetIndentString(indent), kind);
                                    if (accessibility == "Accessibility.Private") {
                                        sb.AppendFormatLine("{0}private = true,", GetIndentString(indent));
                                    }
                                    foreach (var minfo in mfunc.Params) {
                                        var mdef = minfo as Dsl.FunctionData;
                                        string key = mdef.GetId();
                                        string val = mdef.GetParamId(0);
                                        sb.AppendFormatLine("{0}{1} = {2},", GetIndentString(indent), key, val);
                                    }
                                    --indent;
                                    sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                                }
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}__method_info = nil,", GetIndentString(indent));
                    }

                    var propertyInfo = FindStatement(funcData, "property_info") as Dsl.FunctionData;
                    if (s_GenPropertyInfo && null != propertyInfo && propertyInfo.GetParamNum() > 0) {
                        sb.AppendFormatLine("{0}__property_info = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in propertyInfo.Params) {
                            var mfunc = def as Dsl.FunctionData;
                            if (null != mfunc) {
                                var fcall = mfunc;
                                if (mfunc.IsHighOrder)
                                    fcall = mfunc.LowerOrderFunction;
                                sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mfunc.GetId());
                                ++indent;
                                var accessibility = CalcTypeString(fcall.GetParam(0));
                                if (accessibility == "Accessibility.Private") {
                                    sb.AppendFormatLine("{0}private = true,", GetIndentString(indent));
                                }
                                foreach (var minfo in mfunc.Params) {
                                    var mdef = minfo as Dsl.FunctionData;
                                    string key = mdef.GetId();
                                    string val = mdef.GetParamId(0);
                                    sb.AppendFormatLine("{0}{1} = {2},", GetIndentString(indent), key, val);
                                }
                                --indent;
                                sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}__property_info = nil,", GetIndentString(indent));
                    }

                    var eventInfo = FindStatement(funcData, "event_info") as Dsl.FunctionData;
                    if (s_GenEventInfo && null != eventInfo && eventInfo.GetParamNum() > 0) {
                        sb.AppendFormatLine("{0}__event_info = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in eventInfo.Params) {
                            var mfunc = def as Dsl.FunctionData;
                            if (null != mfunc) {
                                var fcall = mfunc;
                                if (mfunc.IsHighOrder)
                                    fcall = mfunc.LowerOrderFunction;
                                sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mfunc.GetId());
                                ++indent;
                                var accessibility = CalcTypeString(fcall.GetParam(0));
                                if (accessibility == "Accessibility.Private") {
                                    sb.AppendFormatLine("{0}private = true,", GetIndentString(indent));
                                }
                                foreach (var minfo in mfunc.Params) {
                                    var mdef = minfo as Dsl.FunctionData;
                                    string key = mdef.GetId();
                                    string val = mdef.GetParamId(0);
                                    sb.AppendFormatLine("{0}{1} = {2},", GetIndentString(indent), key, val);
                                }
                                --indent;
                                sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}__event_info = nil,", GetIndentString(indent));
                    }

                    var fieldInfo = FindStatement(funcData, "field_info") as Dsl.FunctionData;
                    if (s_GenFieldInfo && null != fieldInfo && fieldInfo.GetParamNum() > 0) {
                        sb.AppendFormatLine("{0}__field_info = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in fieldInfo.Params) {
                            var mfunc = def as Dsl.FunctionData;
                            if (null != mfunc) {
                                var fcall = mfunc;
                                if (mfunc.IsHighOrder)
                                    fcall = mfunc.LowerOrderFunction;
                                sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mfunc.GetId());
                                ++indent;
                                var accessibility = CalcTypeString(fcall.GetParam(0));
                                foreach (var minfo in mfunc.Params) {
                                    var mdef = minfo as Dsl.FunctionData;
                                    string key = mdef.GetId();
                                    string val = mdef.GetParamId(0);
                                    sb.AppendFormatLine("{0}{1} = {2},", GetIndentString(indent), key, val);
                                }
                                --indent;
                                sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}__field_info = nil,", GetIndentString(indent));
                    }
                    --indent;
                    sb.AppendFormatLine("{0}}};", GetIndentString(indent));

                    classDefineStack.Push(className);
                }
            }
            sb.AppendLine();
            if (null != mergedInfo) {
                lock (mergedInfo) {
                    foreach (string req in requireList) {
                        if (!mergedInfo.Requires.Contains(req)) {
                            mergedInfo.Requires.Add(req);
                            mergedInfo.RequireList.Add(req);
                        }
                    }
                    mergedInfo.CodeBuilder.AppendLine(sb.ToString());
                    while (classDefineStack.Count > 0) {
                        var className = classDefineStack.Pop();
                        mergedInfo.DefinedClasses.Add(className);
                    }
                    if (!string.IsNullOrEmpty(entryClass)) {
                        mergedInfo.EntryClass = entryClass;
                    }
                }
            }
            else {
                StringBuilder newSb = new StringBuilder();
                newSb.AppendLine(sb.ToString());
                foreach (string req in requireList) {
                    newSb.AppendFormatLine("{0}require \"{1}\";", GetIndentString(indent), req);
                }
                while (classDefineStack.Count > 0) {
                    var className = classDefineStack.Pop();
                    newSb.AppendFormatLine("{0}settempmetatable({1});", GetIndentString(indent), className);
                }
                if (!string.IsNullOrEmpty(entryClass)) {
                    newSb.AppendFormatLine("{0}defineentry({1});", GetIndentString(indent), entryClass);
                }
                File.WriteAllText(outputFile, newSb.ToString());
            }
        }
        private static void GenerateFieldValueComponent(Dsl.ISyntaxComponent comp, StringBuilder sb, int indent, bool firstLineUseIndent)
        {
            s_CurSyntax = comp;
            var valData = comp as Dsl.ValueData;
            if (null != valData) {
                GenerateConcreteSyntax(valData, sb, indent, firstLineUseIndent, true);
            }
            else {
                var funcData = comp as Dsl.FunctionData;
                if (null != funcData) {
                    GenerateConcreteSyntax(funcData, sb, indent, firstLineUseIndent);
                }
                else {
                    var statementData = comp as Dsl.StatementData;
                    if (null != statementData) {
                        GenerateConcreteSyntax(statementData, sb, indent, firstLineUseIndent);
                    }
                    else {
                        System.Diagnostics.Debugger.Break();
                        throw new Exception(string.Format("GenerateFieldValueComponent ISyntaxComponent exception:{0}", sb.ToString()));
                    }
                }
            }
        }
        private static void GenerateSyntaxComponent(Dsl.ISyntaxComponent comp, StringBuilder sb, int indent, bool firstLineUseIndent)
        {
            s_CurSyntax = comp;
            var valData = comp as Dsl.ValueData;
            if (null != valData) {
                GenerateConcreteSyntax(valData, sb, indent, firstLineUseIndent);
            }
            else {
                var funcData = comp as Dsl.FunctionData;
                if (null != funcData) {
                    GenerateConcreteSyntax(funcData, sb, indent, firstLineUseIndent);
                }
                else {
                    var statementData = comp as Dsl.StatementData;
                    GenerateConcreteSyntax(statementData, sb, indent, firstLineUseIndent);
                }
            }
        }
        private static void GenerateConcreteSyntax(Dsl.ValueData data, StringBuilder sb, int indent, bool firstLineUseIndent)
        {
            GenerateConcreteSyntax(data, sb, indent, firstLineUseIndent, false);
        }
        private static void GenerateConcreteSyntax(Dsl.ValueData data, StringBuilder sb, int indent, bool firstLineUseIndent, bool useSpecNil)
        {
            s_CurSyntax = data;
            if (firstLineUseIndent) {
                sb.AppendFormat("{0}", GetIndentString(indent));
            }
            string id = data.GetId();
            switch (data.GetIdType()) {
                case (int)Dsl.ValueData.ID_TOKEN:
                case (int)Dsl.ValueData.NUM_TOKEN:
                case (int)Dsl.ValueData.BOOL_TOKEN:
                    if (id == "null") {
                        if (useSpecNil)
                            id = "__cs2lua_nil_field_value";
                        else
                            id = "nil";
                    }
                    else if (id == "__cs2dsl_out") {
                        id = "__cs2lua_out";
                    }
                    sb.Append(id);
                    break;
                case (int)Dsl.ValueData.STRING_TOKEN:
                    sb.AppendFormat("\"{0}\"", Escape(id));
                    break;
            }
        }
        private static void GenerateConcreteSyntaxForCall(Dsl.FunctionData data, StringBuilder sb, int indent, bool firstLineUseIndent)
        {
            //这个方法生成函数名与参数表部分，需要注意的是data可能是函数名+函数体，在这个方法里不应生成函数体部分
            s_CurSyntax = data;
            if (firstLineUseIndent) {
                sb.AppendFormat("{0}", GetIndentString(indent));
            }
            string id = string.Empty;
            if (data.IsHighOrder) {
                GenerateConcreteSyntaxForCall(data.LowerOrderFunction, sb, indent, false);
            } else {
                id = data.GetId();
            }
            if (data.GetParamClass() == (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_OPERATOR) {
                id = ConvertOperator(id);
                int paramNum = data.GetParamNum();
                if (paramNum == 1) {
                    var param1 = data.GetParam(0);
                    sb.AppendFormat("({0} ", id);
                    GenerateSyntaxComponent(param1, sb, indent, false);
                    sb.Append(")");
                }
                else if (paramNum == 2) {
                    ++indent;
                    var param1 = data.GetParam(0);
                    var param2 = data.GetParam(1);
                    bool handled = false;
                    var fd = param1 as Dsl.FunctionData;
                    string leftParamId = string.Empty;
                    if (null != fd && !fd.IsHighOrder && fd.HaveParam()) {
                        leftParamId = fd.GetId();
                    }
                    if (id == "=" && leftParamId == "multiassign") {
                        var cd = param1 as Dsl.FunctionData;
                        if (null != cd) {
                            if (cd.GetParamNum() > 1) {
                                int varNum = cd.GetParamNum();
                                for (int i = 0; i < varNum; ++i) {
                                    var parami = cd.GetParam(i);
                                    GenerateSyntaxComponent(parami, sb, indent, false);
                                    if (i < varNum - 1) {
                                        sb.Append(",");
                                    }
                                }
                                sb.AppendFormat(" {0} ", id);
                                GenerateSyntaxComponent(param2, sb, indent, false);
                            }
                            else {
                                GenerateSyntaxComponent(cd.GetParam(0), sb, indent, false);
                                sb.AppendFormat(" {0} ", id);
                                GenerateSyntaxComponent(param2, sb, indent, false);
                            }
                            handled = true;
                        }
                    }
                    else if(id == "=" && (leftParamId== "getstatic"
                         || leftParamId == "getexternstatic"
                         || leftParamId == "getinstance"
                         || leftParamId == "getexterninstance")) {                        
                        var cd = param1 as Dsl.FunctionData;
                        if (null != cd.Name) {
                            cd.Name.SetId("s" + leftParamId.Substring(1));
                            cd.AddParam(param2);
                            GenerateConcreteSyntax(cd, sb, indent, false);
                            handled = true;
                        }
                    }
                    else if (id == "=" && leftParamId == "getstaticindexer") {
                        var cd = param1 as Dsl.FunctionData;
                        if (null != cd.Name) {
                            var member = cd.GetParam(1) as Dsl.ValueData;
                            var pct = cd.GetParam(2) as Dsl.ValueData;
                            if (null != member && null != pct) {
                                member.SetId("s" + member.GetId().Substring(1));
                                int ct;
                                int.TryParse(pct.GetId(), out ct);
                                pct.SetId((ct + 1).ToString());

                                cd.Name.SetId("s" + leftParamId.Substring(1));
                                cd.AddParam(param2);
                                GenerateConcreteSyntax(cd, sb, indent, false);
                                handled = true;
                            }
                        }
                    }
                    else if (id == "=" && leftParamId == "getinstanceindexer") {
                        var cd = param1 as Dsl.FunctionData;
                        if (null != cd.Name) {
                            var member = cd.GetParam(3) as Dsl.ValueData;
                            var pct = cd.GetParam(4) as Dsl.ValueData;
                            if (null != member && null != pct) {
                                member.SetId("s" + member.GetId().Substring(1));
                                int ct;
                                int.TryParse(pct.GetId(), out ct);
                                pct.SetId((ct + 1).ToString());

                                cd.Name.SetId("s" + leftParamId.Substring(1));
                                cd.AddParam(param2);
                                GenerateConcreteSyntax(cd, sb, indent, false);
                                handled = true;
                            }
                        }
                    }
                    else if (id == "=" && leftParamId == "getexternstaticindexer") {
                        var cd = param1 as Dsl.FunctionData;
                        if (null != cd.Name) {
                            var member = cd.GetParam(4) as Dsl.ValueData;
                            var pct = cd.GetParam(5) as Dsl.ValueData;
                            if (null != member && null != pct) {
                                member.SetId("s" + member.GetId().Substring(1));
                                int ct;
                                int.TryParse(pct.GetId(), out ct);
                                pct.SetId((ct + 1).ToString());

                                cd.Name.SetId("s" + leftParamId.Substring(1));
                                cd.AddParam(param2);
                                GenerateConcreteSyntax(cd, sb, indent, false);
                                handled = true;
                            }
                        }
                    }
                    else if (id == "=" && leftParamId == "getexterninstanceindexer") {
                        var cd = param1 as Dsl.FunctionData;
                        if (null != cd.Name) {
                            var member = cd.GetParam(6) as Dsl.ValueData;
                            var pct = cd.GetParam(7) as Dsl.ValueData;
                            if (null != member && null != pct) {
                                member.SetId("s" + member.GetId().Substring(1));
                                int ct;
                                int.TryParse(pct.GetId(), out ct);
                                pct.SetId((ct + 1).ToString());

                                cd.Name.SetId("s" + leftParamId.Substring(1));
                                cd.AddParam(param2);
                                GenerateConcreteSyntax(cd, sb, indent, false);
                                handled = true;
                            }
                        }
                    }
                    if (!handled) {
                        if (id != "=")
                            sb.Append("(");
                        GenerateSyntaxComponent(param1, sb, indent, false);
                        sb.AppendFormat(" {0} ", id);
                        GenerateSyntaxComponent(param2, sb, indent, false);
                        if (id != "=")
                            sb.Append(")");
                    }
                }
            }
            else if (id == "comment") {
                sb.AppendFormat("--{0}", data.GetParamId(0));
            }
            else if (id == "local") {
                sb.Append("local ");
                GenerateArguments(data, sb, indent, 0);
            }
            else if (id == "return") {
                sb.Append("return ");
                GenerateArguments(data, sb, indent, 0);
            }
            else if (id == "execunary") {
                string op = data.GetParamId(0);
                var p1 = data.GetParam(1);
                string type1 = CalcTypeString(data.GetParam(2));
                string typeKind1 = CalcTypeString(data.GetParam(3));
                string intOp = op;
                if (op == "++")
                    intOp = "+";
                else if (op == "--")
                    intOp = "-";
                int intOpIndex;
                if (IsIntegerType(type1, typeKind1) && TryGetSpecialIntegerOperatorIndex(intOp, out intOpIndex)) {
                    if (op == "++" || op == "--") {
                        if (s_IntegerTypes.Contains(type1)) {
                            sb.Append("(");
                            GenerateSyntaxComponent(p1, sb, indent, false);
                            sb.AppendFormat(" {0} 1)", intOp);
                        }
                        else {
                            sb.AppendFormat("invokeintegeroperator({0}, \"{1}\", ", intOpIndex, intOp);
                            GenerateSyntaxComponent(p1, sb, indent, false);
                            sb.AppendFormat(", 1, {0}, {1})", type1, type1);
                        }
                    }
                    if (s_IntegerTypes.Contains(type1) && (op == "+" || op == "-")) {
                        sb.AppendFormat("( {0} ", intOp);
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.Append(")");
                    }
                    else {
                        sb.AppendFormat("invokeintegeroperator({0}, \"{1}\", nil, ", intOpIndex, intOp);
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.AppendFormat(", nil, {0})", type1, type1);
                    }
                }
                else {
                    string functor;
                    if (s_UnaryFunctor.TryGetValue(op, out functor)) {
                        sb.AppendFormat("{0}(", functor);
                        GenerateSyntaxComponent(data.GetParam(1), sb, indent, false);
                        sb.Append(")");
                    }
                    else {
                        op = ConvertOperator(op);
                        sb.AppendFormat("({0} ", op);
                        GenerateSyntaxComponent(data.GetParam(1), sb, indent, false);
                        sb.Append(")");
                    }
                }
            }
            else if (id == "execbinary") {
                string op = data.GetParamId(0);
                var p1 = data.GetParam(1);
                var p2 = data.GetParam(2);
                string type1 = CalcTypeString(data.GetParam(3));
                string type2 = CalcTypeString(data.GetParam(4));
                string typeKind1 = CalcTypeString(data.GetParam(5));
                string typeKind2 = CalcTypeString(data.GetParam(6));
                int intOpIndex;
                if (IsIntegerType(type1, typeKind1) && IsIntegerType(type2, typeKind2) && TryGetSpecialIntegerOperatorIndex(op, out intOpIndex)) {
                    if (s_IntegerTypes.Contains(type1) && s_IntegerTypes.Contains(type2) && (op == "+" || op == "-" || op == "%")) {
                        sb.Append("(");
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.AppendFormat(" {0} ", op);
                        GenerateSyntaxComponent(p2, sb, indent, false);
                        sb.Append(")");
                    }
                    else {
                        sb.AppendFormat("invokeintegeroperator({0}, \"{1}\", ", intOpIndex, op);
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.Append(", ");
                        GenerateSyntaxComponent(p2, sb, indent, false);
                        sb.AppendFormat(", {0}, {1})", type1, type2);
                    }
                }
                else if (op == "+" && (type1 == "System.String" || type2 == "System.String")) {
                    bool tostr1 = type1 != "System.String";
                    bool tostr2 = type2 != "System.String";
                    sb.Append("System.String.Concat(\"System.String:Concat__String__String\", ");
                    if (tostr1)
                        sb.Append("tostring(");
                    GenerateSyntaxComponent(p1, sb, indent, false);
                    if (tostr1)
                        sb.Append(")");
                    sb.Append(", ");
                    if (tostr2)
                        sb.Append("tostring(");
                    GenerateSyntaxComponent(p2, sb, indent, false);
                    if (tostr2)
                        sb.Append(")");
                    sb.Append(")");
                }
                else if ((op == "==" || op == "!=") && !IsBasicType(type1, typeKind1, true) && !IsBasicType(type2, typeKind2, true)) {
                    if (op == "==") {
                        sb.Append("isequal(");
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.Append(", ");
                        GenerateSyntaxComponent(p2, sb, indent, false);
                        sb.Append(")");
                    }
                    else {
                        sb.Append("(not isequal(");
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.Append(", ");
                        GenerateSyntaxComponent(p2, sb, indent, false);
                        sb.Append("))");
                    }
                }
                else {
                    string functor;
                    if (s_BinaryFunctor.TryGetValue(op, out functor)) {
                        sb.AppendFormat("{0}(", functor);
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.Append(", ");
                        GenerateSyntaxComponent(p2, sb, indent, false);
                        sb.Append(")");
                    }
                    else {
                        op = ConvertOperator(op);
                        sb.Append("(");
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.AppendFormat(" {0} ", op);
                        GenerateSyntaxComponent(p2, sb, indent, false);
                        sb.Append(")");
                    }
                }
            }
            else if (id == "invokeexternoperator") {
                string method = data.GetParamId(2);
                string luaOp = string.Empty;
                //slua导出时把重载操作符导出成lua实例方法了，然后利用lua实例上支持的操作符元方法在运行时绑定到重载实现
                //这里把lua支持的操作符方法转成lua操作（可能比invokeexternoperator要快一些）
                if (method == "op_Addition") {
                    luaOp = "+";
                }
                else if (method == "op_Subtraction") {
                    luaOp = "-";
                }
                else if (method == "op_Multiply") {
                    luaOp = "*";
                }
                else if (method == "op_Division") {
                    luaOp = "/";
                }
                else if (method == "op_UnaryNegation") {
                    luaOp = "-";
                }
                else if (method == "op_UnaryPlus") {
                    luaOp = "+";
                }
                else if (method == "op_LessThan") {
                    luaOp = "<";
                }
                else if (method == "op_GreaterThan") {
                    luaOp = ">";
                }
                else if (method == "op_LessThanOrEqual") {
                    luaOp = "<=";
                }
                else if (method == "op_GreaterThanOrEqual") {
                    luaOp = ">= ";
                }
                if (string.IsNullOrEmpty(luaOp) || data.GetParamNum() > 5) {
                    sb.Append(id);
                    sb.Append("(");
                    GenerateArguments(data, sb, indent, 0);
                    sb.Append(")");
                }
                else if (data.GetParamNum() == 4 && luaOp == "-") {
                    sb.Append("(- ");
                    var param0 = data.GetParam(3);
                    GenerateSyntaxComponent(param0, sb, indent, false);
                    sb.Append(")");
                }
                else if (data.GetParamNum() == 5) {
                    sb.Append("(");
                    var param0 = data.GetParam(3);
                    var param1 = data.GetParam(4);
                    GenerateSyntaxComponent(param0, sb, indent, false);
                    sb.AppendFormat(" {0} ", luaOp);
                    GenerateSyntaxComponent(param1, sb, indent, false);
                    sb.Append(")");
                }
            }
            else if (id == "getstatic") {
                var kind = CalcTypeString(data.GetParam(0));
                var obj = data.Params[1];
                var member = data.Params[2];
                GenerateSyntaxComponent(obj, sb, indent, false);
                if (kind == "SymbolKind.Property") {
                    sb.AppendFormat(".get_{0}()", member.GetId());
                }
                else {
                    sb.AppendFormat(".{0}", member.GetId());
                }
            }
            else if (id == "getinstance") {
                var kind = CalcTypeString(data.GetParam(0));
                var obj = data.Params[1];
                var member = data.Params[2];
                GenerateSyntaxComponent(obj, sb, indent, false);
                if (kind == "SymbolKind.Property") {
                    sb.AppendFormat(":get_{0}()", member.GetId());
                }
                else {
                    sb.AppendFormat(".{0}", member.GetId());
                }
            }
            else if (id == "setstatic") {
                var kind = CalcTypeString(data.GetParam(0));
                var obj = data.Params[1];
                var member = data.Params[2];
                var val = data.Params[3];
                GenerateSyntaxComponent(obj, sb, indent, false);
                if (kind == "SymbolKind.Property") {
                    sb.AppendFormat(".set_{0}(", member.GetId());
                    GenerateSyntaxComponent(val, sb, indent, false);
                    sb.Append(")");
                }
                else {
                    sb.AppendFormat(".{0}", member.GetId());
                    sb.Append(" = ");
                    GenerateSyntaxComponent(val, sb, indent, false);
                }
            }
            else if (id == "setinstance") {
                var kind = CalcTypeString(data.GetParam(0));
                var obj = data.Params[1];
                var member = data.Params[2];
                var val = data.Params[3];
                GenerateSyntaxComponent(obj, sb, indent, false);
                if (kind == "SymbolKind.Property") {
                    sb.AppendFormat(":set_{0}(", member.GetId());
                    GenerateSyntaxComponent(val, sb, indent, false);
                    sb.Append(")");
                }
                else {
                    sb.AppendFormat(".{0}", member.GetId());
                    sb.Append(" = ");
                    GenerateSyntaxComponent(val, sb, indent, false);
                }
            }
            else if (id == "getexternstatic") {
                var kind = CalcTypeString(data.GetParam(0));
                var obj = data.Params[1];
                var member = data.Params[2];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
            }
            else if (id == "getexterninstance") {
                var kind = CalcTypeString(data.GetParam(0));
                var obj = data.Params[1];
                var member = data.Params[2];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
            }
            else if (id == "setexternstatic") {
                var kind = CalcTypeString(data.GetParam(0));
                var obj = data.Params[1];
                var member = data.Params[2];
                var val = data.Params[3];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
                sb.Append(" = ");
                GenerateSyntaxComponent(val, sb, indent, false);
            }
            else if (id == "setexterninstance") {
                var kind = CalcTypeString(data.GetParam(0));
                var obj = data.Params[1];
                var member = data.Params[2];
                var val = data.Params[3];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
                sb.Append(" = ");
                GenerateSyntaxComponent(val, sb, indent, false);
            }
            else if (id == "callstatic" || id == "callexternstatic") {
                var obj = data.Params[0];
                var member = data.Params[1];
                var mid = member.GetId();
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", mid);
                sb.Append("(");
                int start = 2;
                string sig = string.Empty;
                if (data.Params.Count > start) {
                    var sigParam = data.GetParam(start) as Dsl.ValueData;
                    if (null != sigParam && sigParam.GetIdType() == Dsl.ValueData.STRING_TOKEN && IsSignature(sigParam.GetId(), mid)) {
                        start = 3;
                        sig = sigParam.GetId();
                        string target;
                        if (NoSignatureArg(sig)) {
                            sig = string.Empty;
                        }
                        else if (TryReplaceSignatureArg(sig, out target)) {
                            sig = target;
                        }
                    }
                    else {
                        sig = string.Empty;
                    }
                }
                GenerateArguments(data, sb, indent, start, sig);
                sb.Append(")");
            }
            else if (id == "callinstance" || id == "callexterninstance") {
                var obj = data.Params[0];
                var member = data.Params[1];
                var mid = member.GetId();
                var objCd = obj as Dsl.FunctionData;
                GenerateSyntaxComponent(obj, sb, indent, false);
                if (null != objCd && objCd.GetId() == "getinstance" && objCd.GetParamNum() == 3 && objCd.GetParamId(2) == "base") {
                    sb.AppendFormat(":__self__{0}", mid);
                }
                else {
                    sb.AppendFormat(":{0}", mid);
                }
                sb.Append("(");
                int start = 2;
                string sig = string.Empty;
                if (data.Params.Count > start) {
                    var sigParam = data.GetParam(start) as Dsl.ValueData;
                    if (null != sigParam && sigParam.GetIdType() == Dsl.ValueData.STRING_TOKEN && IsSignature(sigParam.GetId(), mid)) {
                        start = 3;
                        sig = sigParam.GetId();
                        string target;
                        if (NoSignatureArg(sig)) {
                            sig = string.Empty;
                        }
                        else if (TryReplaceSignatureArg(sig, out target)) {
                            sig = target;
                        }
                    }
                    else {
                        sig = string.Empty;
                    }
                }
                GenerateArguments(data, sb, indent, start, sig);
                sb.Append(")");
            }
            else if (id == "callextension") {
                var obj = data.Params[0];
                var member = data.Params[1];
                var mid = member.GetId();
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", mid);
                sb.Append("(");
                int start = 2;
                string sig = string.Empty;
                if (data.Params.Count > start) {
                    var sigParam = data.GetParam(start) as Dsl.ValueData;
                    if (null != sigParam && sigParam.GetIdType() == Dsl.ValueData.STRING_TOKEN && IsSignature(sigParam.GetId(), mid)) {
                        start = 3;
                        sig = sigParam.GetId();
                        string target;
                        if (NoSignatureArg(sig)) {
                            sig = string.Empty;
                        }
                        else if (TryReplaceSignatureArg(sig, out target)) {
                            sig = target;
                        }
                    }
                    else {
                        sig = string.Empty;
                    }
                }
                GenerateArguments(data, sb, indent, start, sig);
                sb.Append(")");
            }
            else if (id == "callexternextension") {
                sb.Append(id);
                sb.Append('(');
                GenerateArguments(data, sb, indent, 0);
                sb.Append(')');
            }
            else if (id == "getstaticindexer") {
                var _class = data.Params[0];
                var _member = data.Params[1].GetId();
                var _pct = data.Params[2].GetId();
                int ct;
                int.TryParse(_pct, out ct);
                if (ct == 1) {
                    var strClass = CalcTypeString(_class);
                    var strMember = _member;
                    int indexerType;
                    bool isIndexerByLua = IndexerByLualib("@@internal", string.Empty, string.Empty, string.Empty, strClass, strMember, out indexerType);

                    var _index = data.Params[3];
                    GenerateSyntaxComponent(_class, sb, 0, false);
                    sb.Append('[');
                    GenerateSyntaxComponent(_index, sb, 0, false);
                    if (isIndexerByLua && indexerType == (int)IndexerTypeEnum.LikeArray) {
                        sb.Append(" + 1");
                    }
                    sb.Append(']');
                }
                else {
                    int start = 3;
                    GenerateSyntaxComponent(_class, sb, 0, false);
                    sb.Append('.');
                    sb.Append(_member);
                    sb.Append('(');
                    GenerateArguments(data, sb, indent, start);
                    sb.Append(')');
                }
            }
            else if (id == "getinstanceindexer") {
                var _obj = data.Params[0];
                var _class = data.Params[1];
                var _member = data.Params[2].GetId();
                var _pct = data.Params[3].GetId();
                int ct;
                int.TryParse(_pct, out ct);
                if (ct == 1) {
                    var strObj = CalcExpressionString(_obj);
                    var strClass = CalcTypeString(_class);
                    var strMember = _member;
                    int indexerType;
                    bool isIndexerByLua = IndexerByLualib("@@internal", string.Empty, string.Empty, strObj, strClass, strMember, out indexerType);

                    var _index = data.Params[4];
                    GenerateSyntaxComponent(_obj, sb, indent, false);
                    sb.Append('[');
                    GenerateSyntaxComponent(_index, sb, 0, false);
                    if (isIndexerByLua && indexerType == (int)IndexerTypeEnum.LikeArray) {
                        sb.Append(" + 1");
                    }
                    sb.Append(']');
                }
                else {
                    int start = 4;
                    GenerateSyntaxComponent(_obj, sb, indent, false);
                    sb.Append(':');
                    sb.Append(_member);
                    sb.Append('(');
                    GenerateSyntaxComponent(_obj, sb, indent, false);
                    sb.Append(", ");
                    GenerateArguments(data, sb, indent, start);
                    sb.Append(')');
                }
            }
            else if (id == "setstaticindexer") {
                var _class = data.Params[0];
                var _member = data.Params[1].GetId();
                var _pct = data.Params[2].GetId();
                var _toplevel = data.Params[3].GetId();
                int ct;
                int.TryParse(_pct, out ct);
                if (ct == 2 && _toplevel == "true") {
                    var strClass = CalcTypeString(_class);
                    var strMember = _member;
                    int indexerType;
                    bool isIndexerByLua = IndexerByLualib("@@internal", string.Empty, string.Empty, string.Empty, strClass, strMember, out indexerType);

                    var _index = data.Params[4];
                    var _val = data.Params[5];
                    GenerateSyntaxComponent(_class, sb, 0, false);
                    sb.Append('[');
                    GenerateSyntaxComponent(_index, sb, 0, false);
                    if (isIndexerByLua && indexerType == (int)IndexerTypeEnum.LikeArray) {
                        sb.Append(" + 1");
                    }
                    sb.Append(']');
                    sb.Append(" = ");
                    GenerateSyntaxComponent(_val, sb, 0, false);
                }
                else {
                    int start = 4;
                    GenerateSyntaxComponent(_class, sb, 0, false);
                    sb.Append('.');
                    sb.Append(_member);
                    sb.Append('(');
                    GenerateArguments(data, sb, indent, start);
                    sb.Append(')');
                }
            }
            else if (id == "setinstanceindexer") {
                var _obj = data.Params[0];
                var _class = data.Params[1];
                var _member = data.Params[2].GetId();
                var _pct = data.Params[3].GetId();
                var _toplevel = data.Params[4].GetId();
                int ct;
                int.TryParse(_pct, out ct);
                if (ct == 2 && _toplevel == "true") {
                    var strObj = CalcExpressionString(_obj);
                    var strClass = CalcTypeString(_class);
                    var strMember = _member;
                    int indexerType;
                    bool isIndexerByLua = IndexerByLualib("@@internal", string.Empty, string.Empty, strObj, strClass, strMember, out indexerType);

                    var _index = data.Params[5];
                    var _val = data.Params[6];
                    GenerateSyntaxComponent(_obj, sb, indent, false);
                    sb.Append('[');
                    GenerateSyntaxComponent(_index, sb, 0, false);
                    if (isIndexerByLua && indexerType == (int)IndexerTypeEnum.LikeArray) {
                        sb.Append(" + 1");
                    }
                    sb.Append(']');
                    sb.Append(" = ");
                    GenerateSyntaxComponent(_val, sb, 0, false);
                }
                else {
                    int start = 5;
                    GenerateSyntaxComponent(_obj, sb, indent, false);
                    sb.Append(':');
                    sb.Append(_member);
                    sb.Append('(');
                    GenerateSyntaxComponent(_obj, sb, indent, false);
                    sb.Append(", ");
                    GenerateArguments(data, sb, indent, start);
                    sb.Append(')');
                }
            }
            else if (id == "getexternstaticindexer") {
                var _callerClass = data.Params[0];
                var _typeargs = data.Params[1] as Dsl.FunctionData;
                var _typekinds = data.Params[2] as Dsl.FunctionData;
                var _class = data.Params[3];
                var _member = data.Params[4];
                var strCallerClass = CalcTypeString(_callerClass);
                var strTypeArgs = CalcTypesString(_typeargs);
                var strTypeKinds = CalcTypesString(_typekinds);
                var strClass = CalcTypeString(_class);
                var strMember = CalcTypeString(_member);
                int indexerType;
                if (IndexerByLualib(strCallerClass, strTypeArgs, strTypeKinds, string.Empty, strClass, strMember, out indexerType)) {
                    var _pct = data.Params[5].GetId();
                    int ct;
                    int.TryParse(_pct, out ct);
                    if (ct == 1) {
                        var _index = data.Params[6];
                        sb.Append(strClass);
                        sb.Append('[');
                        GenerateSyntaxComponent(_index, sb, 0, false);
                        if (indexerType == (int)IndexerTypeEnum.LikeArray) {
                            sb.Append(" + 1");
                        }
                        sb.Append(']');
                    }
                    else {
                        int start = 6;
                        sb.Append(strClass);
                        sb.Append('[');
                        sb.Append('"');
                        sb.Append(strMember);
                        sb.Append('"');
                        sb.Append(']');
                        sb.Append('(');
                        GenerateArguments(data, sb, indent, start);
                        sb.Append(')');
                    }
                }
                else {
                    sb.Append(id);
                    sb.Append('(');
                    GenerateArguments(data, sb, indent, 0);
                    sb.Append(')');
                }
            }
            else if (id == "getexterninstanceindexer") {
                var _callerClass = data.Params[0];
                var _typeargs = data.Params[1] as Dsl.FunctionData;
                var _typekinds = data.Params[2] as Dsl.FunctionData;
                var _obj = data.Params[3];
                var _class = data.Params[4];
                var _member = data.Params[5];
                var strCallerClass = CalcTypeString(_callerClass);
                var strTypeArgs = CalcTypesString(_typeargs);
                var strTypeKinds = CalcTypesString(_typekinds);
                var strObj = CalcExpressionString(_obj);
                var strClass = CalcTypeString(_class);
                var strMember = CalcTypeString(_member);
                int indexerType;
                if (IndexerByLualib(strCallerClass, strTypeArgs, strTypeKinds, strObj, strClass, strMember, out indexerType)) {
                    var _pct = data.Params[6].GetId();
                    int ct;
                    int.TryParse(_pct, out ct);
                    if (ct == 1) {
                        var _index = data.Params[7];
                        sb.Append(strObj);
                        sb.Append('[');
                        GenerateSyntaxComponent(_index, sb, 0, false);
                        if (indexerType == (int)IndexerTypeEnum.LikeArray) {
                            sb.Append(" + 1");
                        }
                        sb.Append(']');
                    }
                    else {
                        int start = 7;
                        GenerateSyntaxComponent(_obj, sb, indent, false);
                        sb.Append('[');
                        sb.Append('"');
                        sb.Append(strMember);
                        sb.Append('"');
                        sb.Append(']');
                        sb.Append('(');
                        GenerateSyntaxComponent(_obj, sb, indent, false);
                        sb.Append(", ");
                        GenerateArguments(data, sb, indent, start);
                        sb.Append(')');
                    }
                }
                else {
                    sb.Append(id);
                    sb.Append('(');
                    GenerateArguments(data, sb, indent, 0);
                    sb.Append(')');
                }
            }
            else if (id == "setexternstaticindexer") {
                var _callerClass = data.Params[0];
                var _typeargs = data.Params[1] as Dsl.FunctionData;
                var _typekinds = data.Params[2] as Dsl.FunctionData;
                var _class = data.Params[3];
                var _member = data.Params[4];
                var strCallerClass = CalcTypeString(_callerClass);
                var strTypeArgs = CalcTypesString(_typeargs);
                var strTypeKinds = CalcTypesString(_typekinds);
                var strClass = CalcTypeString(_class);
                var strMember = CalcTypeString(_member);
                int indexerType;
                if (IndexerByLualib(strCallerClass, strTypeArgs, strTypeKinds, string.Empty, strClass, strMember, out indexerType)) {
                    var _pct = data.Params[5].GetId();
                    var _toplevel = data.Params[6].GetId();
                    int ct;
                    int.TryParse(_pct, out ct);
                    if (ct == 2 && _toplevel == "true") {
                        var _index = data.Params[7];
                        var _val = data.Params[8];
                        sb.Append(strClass);
                        sb.Append('[');
                        GenerateSyntaxComponent(_index, sb, 0, false);
                        if (indexerType == (int)IndexerTypeEnum.LikeArray) {
                            sb.Append(" + 1");
                        }
                        sb.Append(']');
                        sb.Append(" = ");
                        GenerateSyntaxComponent(_val, sb, 0, false);
                    }
                    else {
                        int start = 7;
                        sb.Append(strClass);
                        sb.Append('[');
                        sb.Append('"');
                        sb.Append(strMember);
                        sb.Append('"');
                        sb.Append(']');
                        sb.Append('(');
                        GenerateArguments(data, sb, indent, start);
                        sb.Append(')');
                    }
                }
                else {
                    sb.Append(id);
                    sb.Append('(');
                    GenerateArguments(data, sb, indent, 0);
                    sb.Append(')');
                }
            }
            else if (id == "setexterninstanceindexer") {
                var _callerClass = data.Params[0];
                var _typeargs = data.Params[1] as Dsl.FunctionData;
                var _typekinds = data.Params[2] as Dsl.FunctionData;
                var _obj = data.Params[3];
                var _class = data.Params[4];
                var _member = data.Params[5];
                var strCallerClass = CalcTypeString(_callerClass);
                var strTypeArgs = CalcTypesString(_typeargs);
                var strTypeKinds = CalcTypesString(_typekinds);
                var strObj = CalcExpressionString(_obj);
                var strClass = CalcTypeString(_class);
                var strMember = CalcTypeString(_member);
                int indexerType;
                if (IndexerByLualib(strCallerClass, strTypeArgs, strTypeKinds, strObj, strClass, strMember, out indexerType)) {
                    var _pct = data.Params[6].GetId();
                    var _toplevel = data.Params[7].GetId();
                    int ct;
                    int.TryParse(_pct, out ct);
                    if (ct == 2 && _toplevel == "true") {
                        var _index = data.Params[8];
                        var _val = data.Params[9];
                        sb.Append(strObj);
                        sb.Append('[');
                        GenerateSyntaxComponent(_index, sb, 0, false);
                        if (indexerType == (int)IndexerTypeEnum.LikeArray) {
                            sb.Append(" + 1");
                        }
                        sb.Append(']');
                        sb.Append(" = ");
                        GenerateSyntaxComponent(_val, sb, 0, false);
                    }
                    else {
                        int start = 8;
                        GenerateSyntaxComponent(_obj, sb, indent, false);
                        sb.Append('[');
                        sb.Append('"');
                        sb.Append(strMember);
                        sb.Append('"');
                        sb.Append(']');
                        sb.Append('(');
                        GenerateSyntaxComponent(_obj, sb, indent, false);
                        sb.Append(", ");
                        GenerateArguments(data, sb, indent, start);
                        sb.Append(')');
                    }
                }
                else {
                    sb.Append(id);
                    sb.Append('(');
                    GenerateArguments(data, sb, indent, 0);
                    sb.Append(')');
                }
            }
            else if (id == "typeof") {
                var typeStr = CalcTypeString(data.GetParam(0));
                sb.AppendFormat("{0}", typeStr);
            }
            else if (id == "params") {
                var typeStr = CalcTypeString(data.GetParam(0));
                var typeKind = CalcTypeString(data.GetParam(1));
                sb.AppendFormat("wrapparams({{...}}, {0}, {1})", typeStr, typeKind);
            }
            else if (id == "paramsremove") {
                sb.AppendFormat("table.remove({0})", data.GetParamId(0));
            }
            else if (id == "typeargs") {
                if (data.GetParamNum() > 0) {
                    sb.Append("{");
                    GenerateArguments(data, sb, indent, 0);
                    sb.Append("}");
                }
                else {
                    sb.Append("nil");
                }
            }
            else if (id == "typekinds") {
                if (data.GetParamNum() > 0) {
                    sb.Append("{");
                    GenerateArguments(data, sb, indent, 0);
                    sb.Append("}");
                }
                else {
                    sb.Append("nil");
                }
            }
            else if (id == "builddelegation") {
                var paramsString = data.GetParamId(0);
                var varName = data.GetParamId(1);
                var delegationKey = data.GetParamId(2);
                var objOrClassName = CalcTypeString(data.GetParam(3));
                var methodName = data.GetParamId(4);
                var needReturn = data.GetParamId(5) == "true";
                var isStatic = data.GetParamId(6) == "true";

                sb.AppendFormat("local {0}; {0} = ", varName);
                sb.Append("(function(");
                sb.Append(paramsString);
                sb.AppendLine(")");
                ++indent;
                sb.AppendFormat("{0}", GetIndentString(indent));
                if (needReturn) {
                    sb.Append("return ");
                }
                sb.Append(objOrClassName);
                if (isStatic) {
                    sb.Append(".");
                }
                else {
                    sb.Append(":");
                }
                sb.Append(methodName);
                sb.AppendFormatLine("({0});", paramsString);
                --indent;
                sb.AppendFormatLine("{0}end);", GetIndentString(indent));
                sb.AppendFormat("{0}", GetIndentString(indent));
                sb.AppendFormatLine("setdelegationkey({0}, \"{1}\", {2}, {3}.{4});", varName, delegationKey, objOrClassName, objOrClassName, methodName);
                sb.AppendFormat("{0}return {1}", GetIndentString(indent), varName);
            }
            else if (id == "setdelegation") {
                var kind = CalcTypeString(data.GetParam(0));
                var obj = data.Params[1];
                var val = data.Params[2];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.Append(" = ");
                GenerateSyntaxComponent(val, sb, indent, false);
            }
            else if (id == "setstaticdelegation") {
                var kind = CalcTypeString(data.GetParam(0));
                var obj = data.Params[1];
                var member = data.Params[2];
                var val = data.Params[3];
                if (kind == "SymbolKind.Property") {
                    GenerateSyntaxComponent(obj, sb, indent, false);
                    sb.AppendFormat(".set_{0}(", member.GetId());
                    GenerateSyntaxComponent(val, sb, indent, false);
                    sb.Append(")");
                }
                else {
                    GenerateSyntaxComponent(obj, sb, indent, false);
                    sb.AppendFormat(".{0}", member.GetId());
                    sb.Append(" = ");
                    GenerateSyntaxComponent(val, sb, indent, false);
                }
            }
            else if (id == "setinstancedelegation") {
                var kind = CalcTypeString(data.GetParam(0));
                var obj = data.Params[1];
                var member = data.Params[2];
                var val = data.Params[3];
                if (kind == "SymbolKind.Property") {
                    GenerateSyntaxComponent(obj, sb, indent, false);
                    sb.AppendFormat(":set_{0}(", member.GetId());
                    GenerateSyntaxComponent(val, sb, indent, false);
                    sb.Append(")");
                }
                else {
                    GenerateSyntaxComponent(obj, sb, indent, false);
                    sb.AppendFormat(".{0}", member.GetId());
                    sb.Append(" = ");
                    GenerateSyntaxComponent(val, sb, indent, false);
                }
            }
            else if (id == "anonymousobject") {
                sb.Append("wrapanonymousobject{");
                GenerateArguments(data, sb, indent, 0);
                sb.Append("}");
            }
            else if (id == "literaldictionary") {
                sb.Append("{");
                string prestr = string.Empty;
                for (int ix = 2; ix < data.Params.Count; ++ix) {
                    var param = data.Params[ix] as Dsl.FunctionData;
                    sb.Append(prestr);
                    var k = param.GetParam(0);
                    var kcd = k as Dsl.FunctionData;
                    var v = param.GetParam(1);
                    if (null != kcd) {
                        sb.AppendFormat("[{0}] = ", CalcTypeString(k));
                    }
                    else if (k.GetIdType() == Dsl.ValueData.STRING_TOKEN) {
                        sb.AppendFormat("[\"{0}\"] = ", Escape(k.GetId()));
                    }
                    else {
                        sb.AppendFormat("[{0}] = ", k.GetId());
                    }
                    GenerateSyntaxComponent(v, sb, indent, false);
                    prestr = ", ";
                }
                sb.Append("}");
            }
            else if (id == "literallist" || id == "literalcollection" || id == "literalcomplex") {
                sb.Append("{");
                GenerateArguments(data, sb, indent, 2);
                sb.Append("}");
            }
            else if (id == "literalarray") {
                var typeStr = CalcTypeString(data.GetParam(0));
                var typeKind = CalcTypeString(data.GetParam(1));
                sb.Append("wraparray({");
                GenerateArguments(data, sb, indent, 2);
                sb.AppendFormat("}}, nil, {0}, {1})", typeStr, typeKind);
            }
            else if (id == "newarray") {
                var typeStr = CalcTypeString(data.GetParam(0));
                var typeKind = CalcTypeString(data.GetParam(1));
                if (data.GetParamNum() > 2) {
                    var vname = data.GetParamId(2);
                    sb.AppendFormat("wraparray({{}}, {0}, {1}, {2})", vname, typeStr, typeKind);
                }
                else {
                    sb.AppendFormat("wraparray({{}}, nil, {0}, {1})", typeStr, typeKind);
                }
            }
            else if (id == "foreach") {
                sb.Append("for ");
                var param1 = data.GetParamId(0);
                sb.Append(param1);
                sb.Append(" in ");
                var param2 = data.GetParam(1);
                GenerateSyntaxComponent(param2, sb, indent, false);
                sb.Append(" do");
            }
            else if (id == "for") {
                sb.Append("for ");
                var param0 = data.GetParamId(0);
                sb.Append(param0);
                sb.Append(" = ");
                var param1 = data.GetParam(1);
                GenerateSyntaxComponent(param1, sb, indent, false);
                sb.Append(", ");
                var param2 = data.GetParam(2);
                GenerateSyntaxComponent(param2, sb, indent, false);
                if (data.GetParamNum() > 3) {
                    sb.Append(", ");
                    var param3 = data.GetParam(3);
                    GenerateSyntaxComponent(param3, sb, indent, false);
                }
                sb.Append(" do");
            }
            else if (id == "dslcatch") {
                sb.Append("luacatch(");
                var param0 = data.GetParam(0);
                GenerateSyntaxComponent(param0, sb, indent, false);
                sb.Append(", ");
                var param1 = data.GetParam(1);
                GenerateSyntaxComponent(param1, sb, indent, false);
                sb.Append(", (not ");
                var param2 = data.GetParam(2);
                GenerateSyntaxComponent(param2, sb, indent, false);
                sb.Append(") and ");
                GenerateArguments(data, sb, indent, 3);
                sb.Append(")");
            }
            else {
                if (id == "if") {
                    sb.Append("if ");
                }
                else if (id == "elseif") {
                    sb.Append("elseif ");
                }
                else if (id == "while") {
                    sb.Append("while ");
                }
                else if (id == "until") {
                    sb.Append("until ");
                }
                else if (id == "block") {
                    sb.Append("do");
                }
                else if (id == "dslunpack") {
                    sb.Append("luaunpack");
                }
                else if (id == "lock") {
                    sb.Append("do");
                }
                else if (id == "unsafe") {
                    sb.Append("do");
                }
                else if (id == "dslthrow") {
                    sb.Append("luathrow");
                }
                else if(!string.IsNullOrEmpty(id)) {
                    sb.Append(id);
                }
                if (data.HaveParam()) {
                    if (id == "if" || id == "elseif" || id == "while" || id == "until") {
                    }
                    else {
                        switch (data.GetParamClass()) {
                            case (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PARENTHESIS:
                                sb.Append("(");
                                break;
                            case (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_BRACKET:
                                sb.Append("[");
                                break;
                            case (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD:
                                sb.AppendFormat(".{0}", data.GetParamId(0));
                                break;
                        }
                    }
                    if (data.GetParamClass() != (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD) {
                        GenerateArguments(data, sb, indent, 0);
                    }
                    if (id == "if" || id == "elseif" || id == "while" || id == "until") {
                    }
                    else {
                        switch (data.GetParamClass()) {
                            case (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PARENTHESIS:
                                sb.Append(")");
                                break;
                            case (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_BRACKET:
                                sb.Append("]");
                                break;
                            case (int)Dsl.FunctionData.ParamClassEnum.PARAM_CLASS_PERIOD:
                                break;
                        }
                    }
                    if (id == "if" || id == "elseif") {
                        sb.Append(" then ");
                    }
                    else if (id == "while") {
                        sb.Append(" do");
                    }
                }
            }
        }
        private static void GenerateConcreteSyntax(Dsl.FunctionData data, StringBuilder sb, int indent, bool firstLineUseIndent)
        {
            if (data.HaveParam()) {
                GenerateConcreteSyntaxForCall(data, sb, indent, firstLineUseIndent);
                return;
            }
            s_CurSyntax = data;
            if (firstLineUseIndent) {
                sb.AppendFormat("{0}", GetIndentString(indent));
            }
            var fcall = data;
            if (data.IsHighOrder) {
                fcall = data.LowerOrderFunction;
            }
            string id = string.Empty;
            if (!fcall.IsHighOrder) {
                id = fcall.GetId();
            }
            if (id == "comments") {
                foreach (var comp in data.Params) {
                    GenerateSyntaxComponent(comp, sb, indent, true);
                    sb.AppendLine();
                }
            }
            else if (id == "local") {
                bool first = true;
                foreach (var comp in data.Params) {
                    if (!first) {
                        sb.AppendLine(";");
                    }
                    else {
                        first = false;
                    }
                    sb.Append("local ");
                    GenerateSyntaxComponent(comp, sb, indent, false);
                }
            }
            else if (id == "execclosure") {
                string localName = fcall.GetParamId(0);
                bool needDecl = (bool)Convert.ChangeType(fcall.GetParamId(1), typeof(bool));
                sb.AppendLine("(function() ");
                if (data.HaveStatement()) {
                    ++indent;
                    if (needDecl) {
                        sb.AppendFormatLine("{0}local {1};", GetIndentString(indent), localName);
                    }
                    GenerateStatements(data, sb, indent);
                    sb.AppendFormatLine("{0}return {1};", GetIndentString(indent), localName);
                    --indent;
                }
                sb.AppendFormat("{0}end)()", GetIndentString(indent));
            }
            else if (id == "while") {
                int num = fcall.GetParamNum();
                Dsl.FunctionData closure = null;
                string exp = null;
                if (num == 1 && CanRemoveClosure(fcall.GetParam(0), out closure, out exp)) {
                    //TryGetValue这样的单一条件表达式可以转换为非匿名函数包装样式
                    sb.AppendLine("while true do");
                    ++indent;
                    string localName = closure.ThisOrLowerOrderCall.GetParamId(0);
                    bool needDecl = (bool)Convert.ChangeType(closure.ThisOrLowerOrderCall.GetParamId(1), typeof(bool));
                    if (needDecl) {
                        sb.AppendFormatLine("{0}local {1};", GetIndentString(indent), localName);
                    }
                    GenerateStatements(closure, sb, indent);
                    sb.AppendFormatLine("{0}if not {1} then", GetIndentString(indent), exp);
                    ++indent;
                    sb.AppendFormatLine("{0}break;", GetIndentString(indent));
                    --indent;
                    sb.AppendFormatLine("{0}end;", GetIndentString(indent));
                    --indent;
                }
                else {
                    GenerateConcreteSyntaxForCall(fcall, sb, indent, false);
                }
                if (data.HaveStatement()) {
                    sb.AppendLine();
                    ++indent;
                    GenerateStatements(data, sb, indent);
                    --indent;
                    sb.AppendFormat("{0}end", GetIndentString(indent));
                }
            }
            else if (id == "if") {
                int num = fcall.GetParamNum();
                Dsl.FunctionData closure = null;
                string exp = null;
                if (num == 1 && CanRemoveClosure(fcall.GetParam(0), out closure, out exp)) {
                    //TryGetValue这样的单一条件表达式可以提到if语句外面
                    string localName = closure.ThisOrLowerOrderCall.GetParamId(0);
                    bool needDecl = (bool)Convert.ChangeType(closure.ThisOrLowerOrderCall.GetParamId(1), typeof(bool));
                    if (needDecl) {
                        sb.AppendFormatLine("local {0};", localName);
                    }
                    else {
                        sb.AppendLine("--");
                    }
                    GenerateStatements(closure, sb, indent);
                    sb.AppendFormatLine("{0}if {1} then", GetIndentString(indent), exp);
                }
                else {
                    GenerateConcreteSyntaxForCall(fcall, sb, indent, false);
                }
                if (data.HaveStatement()) {
                    sb.AppendLine();
                    ++indent;
                    GenerateStatements(data, sb, indent);
                    --indent;
                    sb.AppendFormat("{0}end", GetIndentString(indent));
                }
            }
            else if (id == "dslusing" || id == "dsltry") {
                if (id == "dslusing")
                    sb.Append("luausing");
                else
                    sb.Append("luatry");
                var complex = data.LowerOrderFunction.GetParamId(0) == "true";
                var retVar = data.LowerOrderFunction.GetParamId(1);
                if (complex) {
                    sb.Append("(function()");
                    sb.AppendLine();
                    //函数体部分
                    if (data.HaveStatement()) {
                        sb.AppendLine();
                        //赋值操作会++indent
                        //++indent;
                        GenerateStatements(data, sb, indent);
                        --indent;
                    }
                    sb.AppendFormat("{0}end)", GetIndentString(indent));
                }
                else {
                    //赋值操作会++indent，所以这里输出语句时会缩进一次，这样恰好能看出原来的try块的范围，先保持此格式
                    bool canSimplify = false;
                    if (data.GetParamNum() == 1) {
                        var bodyStatement = data.GetParam(0) as Dsl.FunctionData;
                        if (null != bodyStatement) {
                            var name = bodyStatement.GetId();
                            string funcRetVar = null;
                            string tryRetVar = null;
                            string tryRetVal = null;
                            if (!bodyStatement.IsHighOrder && (name == "callstatic" || name == "callexternstatic" || name == "callinstance" || name == "callexterninstance")) {
                                canSimplify = true;
                            }
                            else if (name == "block" && bodyStatement.GetParamNum() == 3) {
                                var funcCall = bodyStatement.GetParam(0) as Dsl.FunctionData;
                                var retValVar = bodyStatement.GetParam(1) as Dsl.FunctionData;
                                var breakStatement = bodyStatement.GetParam(2) as Dsl.ValueData;
                                if (null != funcCall && null != retValVar && null != breakStatement && funcCall.GetId() == "=" && retValVar.GetId() == "=" && breakStatement.GetId() == "break") {
                                    bodyStatement = funcCall.GetParam(1) as Dsl.FunctionData;
                                    if (null != bodyStatement && !bodyStatement.IsHighOrder) {
                                        name = bodyStatement.GetId();
                                        if (name == "callstatic" || name == "callexternstatic" || name == "callinstance" || name == "callexterninstance") {
                                            canSimplify = true;
                                            funcRetVar = funcCall.GetParamId(0);
                                            tryRetVar = retValVar.GetParamId(0);
                                            tryRetVal = retValVar.GetParamId(1);
                                        }
                                    }
                                }
                            }
                            if (canSimplify) {
                                sb.Append("(");
                                //只有一个函数调用的，正常模拟
                                if (name == "callstatic" || name == "callexternstatic") {
                                    var obj = bodyStatement.Params[0];
                                    var member = bodyStatement.Params[1];
                                    var mid = member.GetId();
                                    GenerateSyntaxComponent(obj, sb, indent, false);
                                    sb.AppendFormat(".{0}", mid);
                                    int start = 2;
                                    string sig = string.Empty;
                                    if (bodyStatement.GetParamNum() > start) {
                                        var sigParam = bodyStatement.GetParam(start) as Dsl.ValueData;
                                        if (null != sigParam && sigParam.GetIdType() == Dsl.ValueData.STRING_TOKEN && IsSignature(sigParam.GetId(), mid)) {
                                            start = 3;
                                            sig = sigParam.GetId();
                                            string target;
                                            if (NoSignatureArg(sig)) {
                                                sig = string.Empty;
                                            }
                                            else if (TryReplaceSignatureArg(sig, out target)) {
                                                sig = target;
                                            }
                                        }
                                        else {
                                            sig = string.Empty;
                                        }
                                    }
                                    if (bodyStatement.GetParamNum() > start) {
                                        sb.Append(", ");
                                    }
                                    GenerateArguments(bodyStatement, sb, indent, start, sig);
                                }
                                else if (name == "callinstance" || name == "callexterninstance") {
                                    var obj = bodyStatement.Params[0];
                                    var member = bodyStatement.Params[1];
                                    var mid = member.GetId();
                                    var objCd = obj as Dsl.FunctionData;
                                    GenerateSyntaxComponent(obj, sb, indent, false);
                                    if (null != objCd && objCd.GetId() == "getinstance" && objCd.GetParamNum() == 3 && objCd.GetParamId(2) == "base") {
                                        sb.AppendFormat(".__self__{0}", mid);
                                    }
                                    else {
                                        sb.AppendFormat(".{0}", mid);
                                    }
                                    sb.Append(", ");
                                    GenerateSyntaxComponent(obj, sb, indent, false);
                                    int start = 2;
                                    string sig = string.Empty;
                                    if (bodyStatement.GetParamNum() > start) {
                                        var sigParam = bodyStatement.GetParam(start) as Dsl.ValueData;
                                        if (null != sigParam && sigParam.GetIdType() == Dsl.ValueData.STRING_TOKEN && IsSignature(sigParam.GetId(), mid)) {
                                            start = 3;
                                            sig = sigParam.GetId();
                                            string target;
                                            if (NoSignatureArg(sig)) {
                                                sig = string.Empty;
                                            }
                                            else if (TryReplaceSignatureArg(sig, out target)) {
                                                sig = target;
                                            }
                                        }
                                        else {
                                            sig = string.Empty;
                                        }
                                    }
                                    if (bodyStatement.GetParamNum() > start) {
                                        sb.Append(", ");
                                    }
                                    GenerateArguments(bodyStatement, sb, indent, start, sig);
                                }
                                if (null == funcRetVar) {
                                    sb.Append(")");
                                }
                                else {
                                    sb.AppendLine(");");
                                    --indent;
                                    sb.AppendFormatLine("{0}if {1} then", GetIndentString(indent), retVar);
                                    ++indent;
                                    sb.AppendFormatLine("{0}{1} = {2};", GetIndentString(indent), funcRetVar, tryRetVar);
                                    sb.AppendFormatLine("{0}{1} = {2};", GetIndentString(indent), tryRetVar, tryRetVal);
                                    --indent;
                                    sb.AppendFormat("{0}end", GetIndentString(indent));
                                }
                            }
                        }
                    }
                    if (!canSimplify) {
                        //出于性能考虑（function对象有较大开销），忽略using与try-catch机制
                        sb.AppendLine("(nil);");
                        --indent;
                        sb.AppendFormatLine("{0}repeat", GetIndentString(indent));
                        ++indent;
                        GenerateStatements(data, sb, indent);
                        --indent;
                        sb.AppendFormat("{0}until true", GetIndentString(indent));
                    }
                }
            }
            else {
                //函数名与参数部分由另一方法生成（有可能没有参数）
                GenerateConcreteSyntaxForCall(fcall, sb, indent, false);
                //函数体部分
                if (data.HaveStatement()) {
                    sb.AppendLine();
                    ++indent;
                    GenerateStatements(data, sb, indent);
                    --indent;
                    sb.AppendFormat("{0}end", GetIndentString(indent));
                }
            }
        }
        private static void GenerateConcreteSyntax(Dsl.StatementData data, StringBuilder sb, int indent, bool firstLineUseIndent)
        {
            s_CurSyntax = data;
            if (firstLineUseIndent) {
                sb.AppendFormat("{0}", GetIndentString(indent));
            }
            string id = data.GetId();
            if (id == "linq") {
                string prestr = string.Empty;
                foreach (var funcData in data.Functions) {
                    var fcall = funcData;
                    if (funcData.IsHighOrder)
                        fcall = funcData.LowerOrderFunction;
                    var linqId = fcall.GetId();
                    if (linqId == "linq") {
                        sb.Append("LINQ.exec({");
                    }
                    else if (linqId == "end") {
                        sb.Append("})");
                    }
                    else {
                        sb.AppendFormat("{0}{{\"{1}\"", prestr, linqId);
                        prestr = ", ";
                        ++indent;
                        foreach (var comp in fcall.Params) {
                            sb.Append(prestr);
                            GenerateSyntaxComponent(comp, sb, indent, false);
                        }
                        --indent;
                        sb.Append("}");
                    }
                }
            }
            else if (id == "do") {
                foreach (var funcData in data.Functions) {
                    var fcall = funcData;
                    if (funcData.IsHighOrder)
                        fcall = funcData.LowerOrderFunction;
                    if (funcData == data.First) {
                        if (firstLineUseIndent) {
                            sb.AppendLine("repeat");
                        }
                        else {
                            sb.AppendFormatLine("{0}repeat", GetIndentString(indent));
                        }
                    }
                    else if (funcData == data.Second) {
                        var param0 = fcall.GetParam(0);
                        Dsl.FunctionData closure;
                        string exp;
                        if (CanRemoveClosure(param0, out closure, out exp)) {
                            ++indent;
                            string localName = closure.ThisOrLowerOrderCall.GetParamId(0);
                            bool needDecl = (bool)Convert.ChangeType(closure.ThisOrLowerOrderCall.GetParamId(1), typeof(bool));
                            if (needDecl) {
                                sb.AppendFormatLine("{0}local {1};", GetIndentString(indent), localName);
                            }
                            GenerateStatements(closure, sb, indent);
                            --indent;
                            sb.AppendFormat("{0}until not {1}", GetIndentString(indent), exp);
                        }
                        else if (param0.GetId() == "false") {
                            sb.AppendFormat("{0}until true", GetIndentString(indent));
                        }
                        else {
                            sb.AppendFormat("{0}until not ", GetIndentString(indent));
                            GenerateSyntaxComponent(param0, sb, indent, false);
                        }
                    }
                    if (funcData.HaveStatement()) {
                        sb.AppendLine();
                        ++indent;
                        GenerateStatements(funcData, sb, indent);
                        --indent;
                        if (funcData == data.Last) {
                            sb.AppendFormat("{0}end", GetIndentString(indent));
                        }
                    }
                    else {
                        sb.Append(" ");
                    }
                }
            }
            else if (id == "if") {
                var fdata = data.First;
                var fcall = fdata;
                if (fdata.IsHighOrder)
                    fcall = fdata.LowerOrderFunction;
                int num = fcall.GetParamNum();
                Dsl.FunctionData closure = null;
                string exp = null;
                if (num == 1 && CanRemoveClosure(fcall.GetParam(0), out closure, out exp)) {
                    //TryGetValue这样的单一条件表达式可以提到if语句外面
                    string localName = closure.ThisOrLowerOrderCall.GetParamId(0);
                    bool needDecl = (bool)Convert.ChangeType(closure.ThisOrLowerOrderCall.GetParamId(1), typeof(bool));
                    if (needDecl) {
                        sb.AppendFormatLine("local {0};", localName);
                    }
                    else {
                        sb.AppendLine("--");
                    }
                    GenerateStatements(closure, sb, indent);
                    sb.AppendFormatLine("{0}if {1} then", GetIndentString(indent), exp);
                }
                else {
                    GenerateConcreteSyntaxForCall(fcall, sb, indent, false);
                }
                if (fdata.HaveStatement()) {
                    sb.AppendLine();
                    ++indent;
                    GenerateStatements(fdata, sb, indent);
                    --indent;
                }
                if (data.GetFunctionNum() == 1) {
                    sb.AppendFormat("{0}end", GetIndentString(indent));
                }
                else {
                    for (int ix = 1; ix < data.GetFunctionNum(); ++ix) {
                        var funcData = data.GetFunction(ix);
                        var fcd = funcData;
                        if (funcData.IsHighOrder)
                            fcd = funcData.LowerOrderFunction;
                        if (CanRemoveClosure(fcd.GetParam(0))) {
                            for(int i = 0; i < ix; ++i) {
                                data.Functions.RemoveAt(0);
                            }
                            data.First.LowerOrderFunction.Name.SetId("if");
                            sb.AppendFormatLine("{0}else", GetIndentString(indent));
                            ++indent;
                            GenerateConcreteSyntax(data, sb, indent, true);
                            --indent;
                            sb.AppendLine(";");
                            sb.AppendFormat("{0}end", GetIndentString(indent));
                            break;
                        }
                        GenerateConcreteSyntaxForCall(fcd, sb, indent, funcData == data.First ? false : true);
                        if (funcData.HaveStatement()) {
                            sb.AppendLine();
                            ++indent;
                            GenerateStatements(funcData, sb, indent);
                            --indent;
                            if (funcData == data.Last) {
                                sb.AppendFormat("{0}end", GetIndentString(indent));
                            }
                        }
                        else {
                            sb.Append(" ");
                        }
                    }
                }
            }
            else {
                foreach (var funcData in data.Functions) {
                    var fcall = funcData;
                    if (funcData.IsHighOrder)
                        fcall = funcData.LowerOrderFunction;
                    GenerateConcreteSyntaxForCall(fcall, sb, indent, funcData == data.First ? false : true);
                    if (funcData.HaveStatement()) {
                        sb.AppendLine();
                        ++indent;
                        GenerateStatements(funcData, sb, indent);
                        --indent;
                        if (funcData == data.Last) {
                            sb.AppendFormat("{0}end", GetIndentString(indent));
                        }
                    }
                    else {
                        sb.Append(" ");
                    }
                }
            }
        }
        private static void GenerateAttribute(Dsl.ISyntaxComponent comp, StringBuilder sb, int indent)
        {
            s_CurSyntax = comp;
            string prestr = string.Empty;
            var cd = comp as Dsl.FunctionData;
            if (null != cd) {
                var attrCd = cd.GetParam(0) as Dsl.FunctionData;
                string attr;
                if (attrCd.IsHighOrder) {
                    attr = CalcTypeString(attrCd.LowerOrderFunction);
                }
                else {
                    attr = attrCd.GetId();
                }
                sb.AppendFormat("{0}{{\"{1}\", {{", GetIndentString(indent), attr);
                var posAttrs = attrCd.GetParam(0) as Dsl.FunctionData;
                foreach (var p in posAttrs.Params) {
                    var pcd = p as Dsl.FunctionData;
                    var k = pcd.GetId();
                    var v = pcd.GetParamId(0);
                    sb.Append(prestr);
                    sb.AppendFormat("{0} = \"{1}\"", k, v);
                    prestr = ", ";
                }
                sb.Append("}, {");
                var nameAttrs = attrCd.GetParam(1) as Dsl.FunctionData;
                foreach (var p in nameAttrs.Params) {
                    var pcd = p as Dsl.FunctionData;
                    var k = pcd.GetId();
                    var v = pcd.GetParamId(0);
                    sb.Append(prestr);
                    sb.AppendFormat("{0} = \"{1}\"", k, v);
                    prestr = ", ";
                }
                sb.AppendLine("}};");
            }
        }
        private static void GenerateArguments(Dsl.FunctionData data, StringBuilder sb, int indent, int start)
        {
            s_CurSyntax = data;
            GenerateArguments(data, sb, indent, start, string.Empty);
        }
        private static void GenerateArguments(Dsl.FunctionData data, StringBuilder sb, int indent, int start, string sig)
        {
            s_CurSyntax = data;
            string prestr = string.Empty;
            if (!string.IsNullOrEmpty(sig)) {
                sb.Append(prestr);
                sb.AppendFormat("\"{0}\"", Escape(sig));
                prestr = ", ";
            }
            for (int ix = start; ix < data.Params.Count; ++ix) {
                var param = data.Params[ix];
                sb.Append(prestr);
                string paramId = param.GetId();
                if (param.GetIdType() == (int)Dsl.ValueData.ID_TOKEN && paramId == "...") {
                    sb.Append("...");
                    continue;
                }
                GenerateSyntaxComponent(param, sb, indent, false);
                prestr = ", ";
            }
        }
        private static void GenerateStatements(Dsl.FunctionData data, StringBuilder sb, int indent)
        {
            s_CurSyntax = data;
            foreach (var comp in data.Params) {
                GenerateSyntaxComponent(comp, sb, indent, true);
                string subId = comp.GetId();
                if (subId != "comments" && subId != "comment") {
                    sb.AppendLine(";");
                }
                else {
                    sb.AppendLine();
                }
            }
        }
        private static bool CanRemoveClosure(Dsl.ISyntaxComponent param)
        {
            Dsl.FunctionData closure;
            Dsl.FunctionData exp;
            return CanRemoveClosure(param, out closure, out exp);
        }
        private static bool CanRemoveClosure(Dsl.ISyntaxComponent param, out Dsl.FunctionData closure, out string exp)
        {
            Dsl.FunctionData unaryop;
            if(CanRemoveClosure(param, out closure, out unaryop)) {
                if (null != unaryop) {
                    Dsl.ValueData vd = new Dsl.ValueData(closure.ThisOrLowerOrderCall.GetParamId(0));
                    unaryop.SetParam(1, vd);
                    StringBuilder sb = new StringBuilder();
                    GenerateConcreteSyntax(unaryop, sb, 0, false);
                    exp = sb.ToString();
                }
                else {
                    exp = closure.ThisOrLowerOrderCall.GetParamId(0);
                }
                return true;
            }
            closure = null;
            exp = null;
            return false;
        }
        private static bool CanRemoveClosure(Dsl.ISyntaxComponent param, out Dsl.FunctionData closure, out Dsl.FunctionData exp)
        {
            exp = param as Dsl.FunctionData;
            closure = param as Dsl.FunctionData;
            if (null != exp && exp.GetId() == "execunary" && exp.GetParamId(0) == "!") {
                closure = exp.GetParam(1) as Dsl.FunctionData;
            }
            else {
                exp = null;
            }
            if (null != closure && closure.GetId() == "execclosure") {
                return true;
            }
            return false;
        }
        private static bool IsSignature(string sig, string method)
        {
            int ix = sig.IndexOf(':');
            int startIndex = ix + 1;
            return startIndex == sig.IndexOf(method, startIndex);
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
        private static string CalcTypesString(Dsl.FunctionData cd)
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
        private static string CalcTypeString(Dsl.ISyntaxComponent comp)
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
        private static string CalcExpressionString(Dsl.ISyntaxComponent comp)
        {
            StringBuilder sb = new StringBuilder();
            GenerateSyntaxComponent(comp, sb, 0, false);
            return sb.ToString();
        }
        private static Dsl.ISyntaxComponent FindParam(Dsl.FunctionData funcData, string key)
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
        private static Dsl.ISyntaxComponent FindStatement(Dsl.FunctionData funcData, string key)
        {
            foreach (var statement in funcData.Params) {
                if (key == statement.GetId()) {
                    return statement;
                }
            }
            return null;
        }
        private static string GetLastName(string fullName)
        {
            int ix = fullName.LastIndexOf('.');
            if (ix < 0)
                return fullName;
            else
                return fullName.Substring(ix + 1);
        }
        private static string ConvertOperator(string id)
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
        private static void Log(string file, string msg)
        {
            s_LogBuilder.AppendFormatLine("[{0}]:{1}", file, msg);
        }
        private static string GetIndentString(int indent)
        {
            const string c_IndentString = "\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t";
            return c_IndentString.Substring(0, indent);
        }
        private static string Escape(string src)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < src.Length; ++i) {
                char c = src[i];
                string es = Escape(c);
                sb.Append(es);
            }
            return sb.ToString();
        }
        private static string Escape(char c)
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
        private static bool TryGetSpecialIntegerOperatorIndex(string op, out int index)
        {
            index = s_SpecialIntegerOperators.IndexOf(op);
            return index >= 0;
        }
        private static bool IsBasicType(string t, string typeKind, bool includeString)
        {
            if (typeKind == "TypeKind.Enum" || t == "System.Enum")
                return true;
            if (includeString && t == "System.String")
                return true;
            return s_BasicTypes.Contains(t);
        }
        private static bool IsIntegerType(string t, string typeKind)
        {
            if (typeKind == "TypeKind.Enum" || t == "System.Enum")
                return true;
            return s_IntegerTypes.Contains(t);
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
        private static bool NoSignatureArg(string signature)
        {
            bool ret;
            if (s_CachedNoSignatures.TryGetValue(signature, out ret)) {
                return ret;
            }
            foreach (var info in s_NoSignatureArgInfos) {
                foreach (var regex in info.Matches) {
                    if (regex.IsMatch(signature)) {
                        s_CachedNoSignatures.TryAdd(signature, true);
                        return true;
                    }
                }
            }
            s_CachedNoSignatures.TryAdd(signature, false);
            return false;
        }
        private static bool TryReplaceSignatureArg(string signature, out string target)
        {
            return s_ReplaceSignatureArgInfos.TryGetValue(signature, out target);
        }
        private static bool IndexerByLualib(string objClassName, string typeArgs, string typeKinds, string obj, string className, string member, out int val)
        {
            string key = string.Format("{0}|{1}|{2}|{3}|{4}|{5}", objClassName, typeArgs, typeKinds, obj, className, member);
            if (s_CachedIndexerByLualibInfos.TryGetValue(key, out val)) {
                return val != 0;
            }
            foreach (var info in s_IndexerByLualibInfos) {
                if ((null == info.ObjectClassMatch || info.ObjectClassMatch.IsMatch(objClassName)) &&
                    (null == info.TypeArgsMatch || info.TypeArgsMatch.IsMatch(typeArgs)) &&
                    (null == info.TypeKindsMatch || info.TypeKindsMatch.IsMatch(typeKinds)) &&
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

            s_DontRequireInfos.Clear();
            s_FileMergeInfos.Clear();
            s_NoSignatureArgInfos.Clear();
            s_ReplaceSignatureArgInfos.Clear();
            s_IndexerByLualibInfos.Clear();
            s_AddPrologueOrEpilogueInfos.Clear();
            s_CachedFile2MergedFiles.Clear();
            s_CachedNoSignatures.Clear();
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
            if (id == "dontrequire") {
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
            else if (id == "nosignaturearg") {
                var cfg = new NoSignatureArgInfo();
                foreach (var s in f.Params) {
                    var str = s.GetId();
                    var regex = new Regex(str, RegexOptions.Compiled);
                    cfg.Matches.Add(regex);
                }
                s_NoSignatureArgInfos.Add(cfg);
            }
            else if (id == "replacesignaturearg") {
                for (int i = 0; i < f.GetParamNum(); i += 2) {
                    var src = f.GetParamId(i);
                    var target = f.GetParamId(i + 1);
                    s_ReplaceSignatureArgInfos[src] = target;
                }
            }
            else if (id == "indexerbylualib") {
                var cfg = new IndexerByLualibInfo();
                Dsl.FunctionData fcd = f.ThisOrLowerOrderCall;
                if (fcd.IsValid() && fcd.GetParamNum() >= 6) {
                    var str = fcd.GetParamId(0);
                    var regex = new Regex(str, RegexOptions.Compiled);
                    cfg.ObjectClassMatch = regex;
                    str = fcd.GetParamId(1);
                    regex = new Regex(str, RegexOptions.Compiled);
                    cfg.TypeArgsMatch = regex;
                    str = fcd.GetParamId(2);
                    regex = new Regex(str, RegexOptions.Compiled);
                    cfg.TypeKindsMatch = regex;
                    str = fcd.GetParamId(3);
                    regex = new Regex(str, RegexOptions.Compiled);
                    cfg.ObjectMatch = regex;
                    str = fcd.GetParamId(4);
                    regex = new Regex(str, RegexOptions.Compiled);
                    cfg.ClassMatch = regex;
                    str = fcd.GetParamId(5);
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

        private class NoSignatureArgInfo
        {
            internal List<Regex> Matches = new List<Regex>();
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
            internal Regex TypeArgsMatch = null;
            internal Regex TypeKindsMatch = null;
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

        private static List<DontRequireInfo> s_DontRequireInfos = new List<DontRequireInfo>();
        private static Dictionary<string, FileMergeInfo> s_FileMergeInfos = new Dictionary<string, FileMergeInfo>();
        private static List<NoSignatureArgInfo> s_NoSignatureArgInfos = new List<NoSignatureArgInfo>();
        private static Dictionary<string, string> s_ReplaceSignatureArgInfos = new Dictionary<string, string>();
        private static List<IndexerByLualibInfo> s_IndexerByLualibInfos = new List<IndexerByLualibInfo>();
        private static List<AddPrologueOrEpilogueInfo> s_AddPrologueOrEpilogueInfos = new List<AddPrologueOrEpilogueInfo>();
        private static ConcurrentDictionary<string, string> s_CachedFile2MergedFiles = new ConcurrentDictionary<string, string>();
        private static ConcurrentDictionary<string, bool> s_CachedNoSignatures = new ConcurrentDictionary<string, bool>();
        private static ConcurrentDictionary<string, int> s_CachedIndexerByLualibInfos = new ConcurrentDictionary<string, int>();
        private static ConcurrentDictionary<string, PrologueAndEpilogueInfo> s_CachedPrologueAndEpilogueInfos = new ConcurrentDictionary<string, PrologueAndEpilogueInfo>();
    }
}
