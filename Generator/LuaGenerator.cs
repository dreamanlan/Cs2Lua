using System;
using System.Collections.Generic;
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
        internal static void Generate(string csprojPath, string outPath, string ext)
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
            foreach (string file in files) {
                try {
                    string fileName = Path.GetFileNameWithoutExtension(file);

                    Dsl.DslFile dslFile = new Dsl.DslFile();
                    dslFile.Load(file, s => Log(file, s));
                    GenerateLua(dslFile, Path.Combine(s_OutPath, Path.ChangeExtension(fileName.Replace("cs2dsl__", "cs2lua__"), s_Ext)), fileName);
                }
                catch (Exception ex) {
                    Log(file, string.Format("exception:{0}\n{1}", ex.Message, ex.StackTrace));
                    File.WriteAllText(Path.Combine(s_LogPath, "Generator.log"), s_LogBuilder.ToString());
                    System.Environment.Exit(-1);
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
                string id = dslInfo.GetId();
                var funcData = dslInfo.First;
                var callData = funcData.Call;
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
                        foreach (var comp in classAttr.Statements) {
                            GenerateAttribute(comp, sb, indent);
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    foreach (var mattr in funcData.Statements) {
                        if (mattr.GetId() == "class")
                            continue;
                        var fd = mattr as Dsl.FunctionData;
                        if (null != fd) {
                            var mid = fd.Call.GetParamId(0);
                            sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mid);
                            ++indent;
                            foreach (var comp in fd.Statements) {
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
                        foreach (var comp in intfs.Statements) {
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
                    foreach (var comp in funcData.Statements) {
                        var cd = comp as Dsl.CallData;
                        if (null != cd) {
                            sb.AppendFormatLine("{0}[\"{1}\"] = {2},", GetIndentString(indent), cd.GetParamId(0), cd.GetParamId(1));
                        }
                    }
                    --indent;
                    sb.AppendFormatLine("{0}}};", GetIndentString(indent));

                    sb.AppendLine();

                    sb.AppendFormatLine("{0}rawset({1}, \"Value2String\", {{", GetIndentString(indent), className);
                    ++indent;
                    foreach (var comp in funcData.Statements) {
                        var cd = comp as Dsl.CallData;
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
                        foreach (var def in staticMethods.Statements) {
                            var mdef = def as Dsl.CallData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var fdef = mdef.GetParam(1) as Dsl.FunctionData;
                                if (mname == "__new_object" && null != fdef) {
                                    var fcall = fdef.Call;
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
                                            var pc = param as Dsl.CallData;
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
                                    foreach (var comp in fdef.Statements) {
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
                            }
                        }
                    }

                    sb.AppendFormatLine("{0}__define_class = function()", GetIndentString(indent));
                    ++indent;
                    sb.AppendFormatLine("{0}local static = {1};", GetIndentString(indent), className);

                    if (null != staticMethods) {
                        sb.AppendFormatLine("{0}local static_methods = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in staticMethods.Statements) {
                            var mdef = def as Dsl.CallData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var param1 = mdef.GetParam(1);
                                var fdef = param1 as Dsl.FunctionData;
                                if (mname != "__new_object" && null != fdef) {
                                    var fcall = fdef.Call;
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
                                            var pc = param as Dsl.CallData;
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
                                    foreach (var comp in fdef.Statements) {
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
                                    var cdef = param1 as Dsl.CallData;
                                    if (null != cdef) {
                                        sb.AppendFormat("{0}{1} = ", GetIndentString(indent), mname);
                                        GenerateSyntaxComponent(cdef, sb, indent, false);
                                        sb.AppendFormatLine(",");
                                    }
                                }
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }

                    sb.AppendLine();

                    sb.AppendFormatLine("{0}local static_fields_build = function()", GetIndentString(indent));
                    ++indent;
                    sb.AppendFormatLine("{0}local static_fields = {{", GetIndentString(indent));
                    ++indent;

                    var staticFields = FindStatement(funcData, "static_fields") as Dsl.FunctionData;
                    if (null != staticFields) {
                        foreach (var def in staticFields.Statements) {
                            var mdef = def as Dsl.CallData;
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

                    var staticProps = FindStatement(funcData, "static_props") as Dsl.FunctionData;
                    if (null != staticProps && staticProps.GetStatementNum() > 0) {
                        sb.AppendFormatLine("{0}local static_props = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in staticProps.Statements) {
                            var mdef = def as Dsl.CallData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var prop = mdef.GetParam(1);
                                sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mname);
                                ++indent;
                                var body = prop as Dsl.FunctionData;
                                if (null != body) {
                                    foreach (var comp in body.Statements) {
                                        GenerateSyntaxComponent(comp, sb, indent, true);
                                        sb.AppendLine(",");
                                    }
                                }
                                --indent;
                                sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}local static_props = nil;", GetIndentString(indent));
                    }
                    var staticEvents = FindStatement(funcData, "static_events") as Dsl.FunctionData;
                    if (null != staticEvents && staticEvents.GetStatementNum() > 0) {
                        sb.AppendFormatLine("{0}local static_events = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in staticEvents.Statements) {
                            var mdef = def as Dsl.CallData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var evt = mdef.GetParam(1);
                                sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mname);
                                ++indent;
                                var body = evt as Dsl.FunctionData;
                                if (null != body) {
                                    foreach (var comp in body.Statements) {
                                        GenerateSyntaxComponent(comp, sb, indent, true);
                                        sb.AppendLine(",");
                                    }
                                }
                                --indent;
                                sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}local static_events = nil;", GetIndentString(indent));
                    }

                    sb.AppendLine();

                    var instMethods = FindStatement(funcData, "instance_methods") as Dsl.FunctionData;
                    if (null != instMethods) {
                        sb.AppendFormatLine("{0}local instance_methods = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in instMethods.Statements) {
                            var mdef = def as Dsl.CallData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var param1 = mdef.GetParam(1);
                                var fdef = param1 as Dsl.FunctionData;
                                if (null != fdef) {
                                    var fcall = fdef.Call;
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
                                            var pc = param as Dsl.CallData;
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
                                    foreach (var comp in fdef.Statements) {
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
                                    var cdef = param1 as Dsl.CallData;
                                    if (null != cdef) {
                                        sb.AppendFormat("{0}{1} = ", GetIndentString(indent), mname);
                                        GenerateSyntaxComponent(cdef, sb, indent, false);
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
                        foreach (var def in instFields.Statements) {
                            var mdef = def as Dsl.CallData;
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

                    var instanceProps = FindStatement(funcData, "instance_props") as Dsl.FunctionData;
                    if (null != instanceProps && instanceProps.GetStatementNum() > 0) {
                        sb.AppendFormatLine("{0}local instance_props = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in instanceProps.Statements) {
                            var mdef = def as Dsl.CallData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var prop = mdef.GetParam(1);
                                sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mname);
                                ++indent;
                                var body = prop as Dsl.FunctionData;
                                if (null != body) {
                                    foreach (var comp in body.Statements) {
                                        GenerateSyntaxComponent(comp, sb, indent, true);
                                        sb.AppendLine(",");
                                    }
                                }
                                --indent;
                                sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}local instance_props = nil;", GetIndentString(indent));
                    }
                    var instanceEvents = FindStatement(funcData, "instance_events") as Dsl.FunctionData;
                    if (null != instanceEvents && instanceEvents.GetStatementNum() > 0) {
                        sb.AppendFormatLine("{0}local instance_events = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in instanceProps.Statements) {
                            var mdef = def as Dsl.CallData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var evt = mdef.GetParam(1);
                                sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mname);
                                ++indent;
                                var body = evt as Dsl.FunctionData;
                                if (null != body) {
                                    foreach (var comp in body.Statements) {
                                        GenerateSyntaxComponent(comp, sb, indent, true);
                                        sb.AppendLine(",");
                                    }
                                }
                                --indent;
                                sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}local instance_events = nil;", GetIndentString(indent));
                    }

                    sb.AppendLine();

                    var interfaces = FindStatement(funcData, "interfaces") as Dsl.FunctionData;
                    if (null != interfaces && interfaces.GetStatementNum() > 0) {
                        sb.AppendFormatLine("{0}local interfaces = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in interfaces.Statements) {
                            var mdef = def as Dsl.ValueData;
                            sb.AppendFormatLine("{0}\"{1}\",", GetIndentString(indent), mdef.GetId());
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}local interfaces = nil;", GetIndentString(indent));
                    }
                    var interfaceMap = FindStatement(funcData, "interface_map") as Dsl.FunctionData;
                    if (null != interfaceMap && interfaceMap.GetStatementNum() > 0) {
                        sb.AppendFormatLine("{0}local interface_map = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in interfaceMap.Statements) {
                            var mdef = def as Dsl.CallData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                string mvalue = mdef.GetParamId(1);
                                sb.AppendFormatLine("{0}{1} = \"{2}\",", GetIndentString(indent), mname, mvalue);
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}local interface_map = nil;", GetIndentString(indent));
                    }

                    sb.AppendLine();

                    var classInfo = FindStatement(funcData, "class_info") as Dsl.FunctionData;
                    if (null != classInfo) {
                        sb.AppendFormatLine("{0}local class_info = {{", GetIndentString(indent));
                        ++indent;
                        var kind = CalcTypeString(classInfo.Call.GetParam(0));
                        var accessibility = CalcTypeString(classInfo.Call.GetParam(1));
                        sb.AppendFormatLine("{0}Kind = {1},", GetIndentString(indent), kind);
                        if (accessibility == "Accessibility.Private") {
                            sb.AppendFormatLine("{0}private = true,", GetIndentString(indent));
                        }
                        foreach (var def in classInfo.Statements) {
                            var mdef = def as Dsl.CallData;
                            string key = mdef.GetId();
                            string val = mdef.GetParamId(0);
                            sb.AppendFormatLine("{0}{1} = {2},", GetIndentString(indent), key, val);
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }

                    var methodInfo = FindStatement(funcData, "method_info") as Dsl.FunctionData;
                    if (null != methodInfo && methodInfo.GetStatementNum() > 0) {
                        sb.AppendFormatLine("{0}local method_info = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in methodInfo.Statements) {
                            var mfunc = def as Dsl.FunctionData;
                            if (null != mfunc) {
                                sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mfunc.GetId());
                                ++indent;
                                var kind = CalcTypeString(mfunc.Call.GetParam(0));
                                var accessibility = CalcTypeString(mfunc.Call.GetParam(1));
                                sb.AppendFormatLine("{0}Kind = {1},", GetIndentString(indent), kind);
                                if (accessibility == "Accessibility.Private") {
                                    sb.AppendFormatLine("{0}private = true,", GetIndentString(indent));
                                }
                                foreach (var minfo in mfunc.Statements) {
                                    var mdef = minfo as Dsl.CallData;
                                    string key = mdef.GetId();
                                    string val = mdef.GetParamId(0);
                                    sb.AppendFormatLine("{0}{1} = {2},", GetIndentString(indent), key, val);
                                }
                                --indent;
                                sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}local method_info = nil;", GetIndentString(indent));
                    }

                    var propertyInfo = FindStatement(funcData, "property_info") as Dsl.FunctionData;
                    if (null != propertyInfo && propertyInfo.GetStatementNum() > 0) {
                        sb.AppendFormatLine("{0}local property_info = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in propertyInfo.Statements) {
                            var mfunc = def as Dsl.FunctionData;
                            if (null != mfunc) {
                                sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mfunc.GetId());
                                ++indent;
                                var accessibility = CalcTypeString(mfunc.Call.GetParam(0));
                                if (accessibility == "Accessibility.Private") {
                                    sb.AppendFormatLine("{0}private = true,", GetIndentString(indent));
                                }
                                foreach (var minfo in mfunc.Statements) {
                                    var mdef = minfo as Dsl.CallData;
                                    string key = mdef.GetId();
                                    string val = mdef.GetParamId(0);
                                    sb.AppendFormatLine("{0}{1} = {2},", GetIndentString(indent), key, val);
                                }
                                --indent;
                                sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}local property_info = nil;", GetIndentString(indent));
                    }

                    var eventInfo = FindStatement(funcData, "event_info") as Dsl.FunctionData;
                    if (null != eventInfo && eventInfo.GetStatementNum() > 0) {
                        sb.AppendFormatLine("{0}local field_info = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in eventInfo.Statements) {
                            var mfunc = def as Dsl.FunctionData;
                            if (null != mfunc) {
                                sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mfunc.GetId());
                                ++indent;
                                var accessibility = CalcTypeString(mfunc.Call.GetParam(0));
                                if (accessibility == "Accessibility.Private") {
                                    sb.AppendFormatLine("{0}private = true,", GetIndentString(indent));
                                }
                                foreach (var minfo in mfunc.Statements) {
                                    var mdef = minfo as Dsl.CallData;
                                    string key = mdef.GetId();
                                    string val = mdef.GetParamId(0);
                                    sb.AppendFormatLine("{0}{1} = {2},", GetIndentString(indent), key, val);
                                }
                                --indent;
                                sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}local event_info = nil;", GetIndentString(indent));
                    }

                    var fieldInfo = FindStatement(funcData, "field_info") as Dsl.FunctionData;
                    if (null != fieldInfo && fieldInfo.GetStatementNum() > 0) {
                        sb.AppendFormatLine("{0}local field_info = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in fieldInfo.Statements) {
                            var mfunc = def as Dsl.FunctionData;
                            if (null != mfunc) {
                                sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), mfunc.GetId());
                                ++indent;
                                var accessibility = CalcTypeString(mfunc.Call.GetParam(0));
                                foreach (var minfo in mfunc.Statements) {
                                    var mdef = minfo as Dsl.CallData;
                                    string key = mdef.GetId();
                                    string val = mdef.GetParamId(0);
                                    sb.AppendFormatLine("{0}{1} = {2},", GetIndentString(indent), key, val);
                                }
                                --indent;
                                sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}local field_info = nil;", GetIndentString(indent));
                    }

                    sb.AppendLine();

                    var logInfoForDefineClass = GetPrologueAndEpilogue(className, "__define_class");
                    if (null != logInfoForDefineClass.PrologueInfo) {
                        sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfoForDefineClass.PrologueInfo, className, "__define_class"));
                    }
                    if (null != logInfoForDefineClass.EpilogueInfo) {
                        sb.AppendFormatLine("{0}local __defineclass_return = defineclass({1}, \"{2}\", \"{3}\", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, class_info, method_info, property_info, event_info, field_info, {4});", GetIndentString(indent), null == baseClass ? "nil" : baseClassName, className, GetLastName(className), isValueType ? "true" : "false");
                        sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfoForDefineClass.EpilogueInfo, className, "__define_class"));
                        sb.AppendFormatLine("{0}return __defineclass_return;", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}return defineclass({1}, \"{2}\", \"{3}\", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, class_info, method_info, property_info, event_info, field_info, {4});", GetIndentString(indent), null == baseClass ? "nil" : baseClassName, className, GetLastName(className), isValueType ? "true" : "false");
                    }

                    --indent;
                    sb.AppendFormatLine("{0}end,", GetIndentString(indent));
                    --indent;
                    sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    classDefineStack.Push(className);
                }
            }
            sb.AppendLine();
            if (null != mergedInfo) {
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
            var valData = comp as Dsl.ValueData;
            if (null != valData) {
                GenerateConcreteSyntax(valData, sb, indent, firstLineUseIndent, true);
            }
            else {
                var callData = comp as Dsl.CallData;
                if (null != callData) {
                    GenerateConcreteSyntax(callData, sb, indent, firstLineUseIndent);
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
        }
        private static void GenerateSyntaxComponent(Dsl.ISyntaxComponent comp, StringBuilder sb, int indent, bool firstLineUseIndent)
        {
            var valData = comp as Dsl.ValueData;
            if (null != valData) {
                GenerateConcreteSyntax(valData, sb, indent, firstLineUseIndent);
            }
            else {
                var callData = comp as Dsl.CallData;
                if (null != callData) {
                    GenerateConcreteSyntax(callData, sb, indent, firstLineUseIndent);
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
        }
        private static void GenerateConcreteSyntax(Dsl.ValueData data, StringBuilder sb, int indent, bool firstLineUseIndent)
        {
            GenerateConcreteSyntax(data, sb, indent, firstLineUseIndent, false);
        }
        private static void GenerateConcreteSyntax(Dsl.ValueData data, StringBuilder sb, int indent, bool firstLineUseIndent, bool useSpecNil)
        {
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
        private static void GenerateConcreteSyntax(Dsl.CallData data, StringBuilder sb, int indent, bool firstLineUseIndent)
        {
            string id = string.Empty;
            var callData = data.Call;
            if (null == callData) {
                id = data.GetId();
            }
            if (firstLineUseIndent) {
                sb.AppendFormat("{0}", GetIndentString(indent));
            }
            if (data.GetParamClass() == (int)Dsl.CallData.ParamClassEnum.PARAM_CLASS_OPERATOR) {
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
                    if (id == "=" && param1.GetId() == "multiassign") {
                        var cd = param1 as Dsl.CallData;
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
            else if (id == "ref" || id == "out") {
                var param = data.GetParam(0);
                GenerateSyntaxComponent(param, sb, indent, false);
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
                    sb.Append("System.String.Concat(\"Concat__String__String\", ");
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
                var obj = data.Params[0];
                var member = data.Params[1];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
            }
            else if (id == "getinstance") {
                var obj = data.Params[0];
                var member = data.Params[1];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
            }
            else if (id == "setstatic") {
                var obj = data.Params[0];
                var member = data.Params[1];
                var val = data.Params[2];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
                sb.Append(" = ");
                GenerateSyntaxComponent(val, sb, indent, false);
            }
            else if (id == "setinstance") {
                var obj = data.Params[0];
                var member = data.Params[1];
                var val = data.Params[2];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
                sb.Append(" = ");
                GenerateSyntaxComponent(val, sb, indent, false);
            }
            else if (id == "callstatic") {
                var obj = data.Params[0];
                var member = data.Params[1];
                var mid = member.GetId();
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", mid);
                sb.Append("(");
                int start = 2;
                if (data.Params.Count > start) {
                    var sig = data.GetParamId(start);
                    if (sig.StartsWith(mid) && NoSignatureArg(sig)) {
                        start = 3;
                    }
                }
                GenerateArguments(data, sb, indent, start);
                sb.Append(")");
            }
            else if (id == "callinstance") {
                var obj = data.Params[0];
                var member = data.Params[1];
                var mid = member.GetId();
                var objCd = obj as Dsl.CallData;
                GenerateSyntaxComponent(obj, sb, indent, false);
                if (null != objCd && objCd.GetId() == "getinstance" && objCd.GetParamNum() == 2 && objCd.GetParamId(1) == "base") {
                    sb.AppendFormat(":__self__{0}", mid);
                }
                else {
                    sb.AppendFormat(":{0}", mid);
                }
                sb.Append("(");
                int start = 2;
                if (data.Params.Count > start) {
                    var sig = data.GetParamId(start);
                    if (sig.StartsWith(mid) && NoSignatureArg(sig)) {
                        start = 3;
                    }
                }
                GenerateArguments(data, sb, indent, start);
                sb.Append(")");
            }
            else if (id == "getstaticindexer") {
                var _class = data.Params[0];
                var _member = data.Params[1].GetId();
                var _pct = data.Params[2].GetId();
                int ct;
                int.TryParse(_pct, out ct);
                if (ct == 1) {
                    var _index = data.Params[3];
                    GenerateSyntaxComponent(_class, sb, 0, false);
                    sb.Append('[');
                    GenerateSyntaxComponent(_index, sb, 0, false);
                    sb.Append(']');
                }
                else {
                    int start = 3;
                    GenerateSyntaxComponent(_class, sb, 0, false);
                    sb.Append('[');
                    sb.Append('"');
                    sb.Append(_member);
                    sb.Append('"');
                    sb.Append(']');
                    sb.Append('(');
                    GenerateArguments(data, sb, indent, start);
                    sb.Append(')');
                }
            }
            else if (id == "getinstanceindexer") {
                var _obj = data.Params[0];
                var _intf = data.Params[1];
                var _class = data.Params[2];
                var _member = data.Params[3].GetId();
                var _pct = data.Params[4].GetId();
                int ct;
                int.TryParse(_pct, out ct);
                if (ct == 1) {
                    var _index = data.Params[5];
                    GenerateSyntaxComponent(_obj, sb, indent, false);
                    sb.Append('[');
                    GenerateSyntaxComponent(_index, sb, 0, false);
                    sb.Append(']');
                }
                else {
                    int start = 5;
                    GenerateSyntaxComponent(_obj, sb, indent, false);
                    sb.Append('[');
                    sb.Append('"');
                    sb.Append(_member);
                    sb.Append('"');
                    sb.Append(']');
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
                    var _index = data.Params[4];
                    var _val = data.Params[5];
                    GenerateSyntaxComponent(_class, sb, 0, false);
                    sb.Append('[');
                    GenerateSyntaxComponent(_index, sb, 0, false);
                    sb.Append(']');
                    sb.Append(" = ");
                    GenerateSyntaxComponent(_val, sb, 0, false);
                }
                else {
                    int start = 4;
                    GenerateSyntaxComponent(_class, sb, 0, false);
                    sb.Append('[');
                    sb.Append('"');
                    sb.Append(_member);
                    sb.Append('"');
                    sb.Append(']');
                    sb.Append('(');
                    GenerateArguments(data, sb, indent, start);
                    sb.Append(')');
                }
            }
            else if (id == "setinstanceindexer") {
                var _obj = data.Params[0];
                var _intf = data.Params[1];
                var _class = data.Params[2];
                var _member = data.Params[3].GetId();
                var _pct = data.Params[4].GetId();
                var _toplevel = data.Params[5].GetId();
                int ct;
                int.TryParse(_pct, out ct);
                if (ct == 2 && _toplevel=="true") {
                    var _index = data.Params[6];
                    var _val = data.Params[7];
                    GenerateSyntaxComponent(_obj, sb, indent, false);
                    sb.Append('[');
                    GenerateSyntaxComponent(_index, sb, 0, false);
                    sb.Append(']');
                    sb.Append(" = ");
                    GenerateSyntaxComponent(_val, sb, 0, false);
                }
                else {
                    int start = 6;
                    GenerateSyntaxComponent(_obj, sb, indent, false);
                    sb.Append('[');
                    sb.Append('"');
                    sb.Append(_member);
                    sb.Append('"');
                    sb.Append(']');
                    sb.Append('(');
                    GenerateSyntaxComponent(_obj, sb, indent, false);
                    sb.Append(", ");
                    GenerateArguments(data, sb, indent, start);
                    sb.Append(')');
                }
            }
            else if (id == "getexternstaticindexer") {
                var _callerClass = data.Params[0];
                var _typeargs = data.Params[1] as Dsl.CallData;
                var _typekinds = data.Params[2] as Dsl.CallData;
                var _class = data.Params[3];
                var _member = data.Params[4];
                var strCallerClass = CalcTypeString(_callerClass);
                var strClass = CalcTypeString(_class);
                var strMember = CalcTypeString(_member);
                var keyIsInteger = true;
                if (_typeargs.GetParamNum() > 0 && _typekinds.GetParamNum() > 0) {
                    var firstTypeArg = CalcTypeString(_typeargs.GetParam(0));
                    var firstTypeKind = CalcTypeString(_typekinds.GetParam(0));
                    keyIsInteger = IsIntegerType(firstTypeArg, firstTypeKind);
                }
                int indexerType;
                if (IndexerByLualib(strCallerClass, string.Empty, string.Empty, strClass, strMember, out indexerType) && (indexerType == (int)IndexerTypeEnum.LikeArray || !keyIsInteger)) {
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
                var _typeargs = data.Params[1] as Dsl.CallData;
                var _typekinds = data.Params[2] as Dsl.CallData;
                var _obj = data.Params[3];
                var _intf = data.Params[4];
                var _class = data.Params[5];
                var _member = data.Params[6];
                var strCallerClass = CalcTypeString(_callerClass);
                var strObj = CalcExpressionString(_obj);
                var strIntf = CalcTypeString(_intf);
                var strClass = CalcTypeString(_class);
                var strMember = CalcTypeString(_member);
                var keyIsInteger = true;
                if (_typeargs.GetParamNum() > 0 && _typekinds.GetParamNum() > 0) {
                    var firstTypeArg = CalcTypeString(_typeargs.GetParam(0));
                    var firstTypeKind = CalcTypeString(_typekinds.GetParam(0));
                    keyIsInteger = IsIntegerType(firstTypeArg, firstTypeKind);
                }
                int indexerType;
                if(IndexerByLualib(strCallerClass, strObj, strIntf, strClass, strMember, out indexerType) && (indexerType == (int)IndexerTypeEnum.LikeArray || !keyIsInteger)) {
                    var _pct = data.Params[7].GetId();
                    int ct;
                    int.TryParse(_pct, out ct);
                    if (ct == 1) {
                        var _index = data.Params[8];
                        sb.Append(strObj);
                        sb.Append('[');
                        GenerateSyntaxComponent(_index, sb, 0, false);
                        if (indexerType == (int)IndexerTypeEnum.LikeArray) {
                            sb.Append(" + 1");
                        }
                        sb.Append(']');
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
                } else {
                    sb.Append(id);
                    sb.Append('(');
                    GenerateArguments(data, sb, indent, 0);
                    sb.Append(')');
                }
            }
            else if (id == "setexternstaticindexer") {
                var _callerClass = data.Params[0];
                var _typeargs = data.Params[1] as Dsl.CallData;
                var _typekinds = data.Params[2] as Dsl.CallData;
                var _class = data.Params[3];
                var _member = data.Params[4];
                var strCallerClass = CalcTypeString(_callerClass);
                var strClass = CalcTypeString(_class);
                var strMember = CalcTypeString(_member);
                var keyIsInteger = true;
                if (_typeargs.GetParamNum() > 0 && _typekinds.GetParamNum() > 0) {
                    var firstTypeArg = CalcTypeString(_typeargs.GetParam(0));
                    var firstTypeKind = CalcTypeString(_typekinds.GetParam(0));
                    keyIsInteger = IsIntegerType(firstTypeArg, firstTypeKind);
                }
                int indexerType;
                if (IndexerByLualib(strCallerClass, string.Empty, string.Empty, strClass, strMember, out indexerType) && (indexerType == (int)IndexerTypeEnum.LikeArray || !keyIsInteger)) {
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
                var _typeargs = data.Params[1] as Dsl.CallData;
                var _typekinds = data.Params[2] as Dsl.CallData;
                var _obj = data.Params[3];
                var _intf = data.Params[4];
                var _class = data.Params[5];
                var _member = data.Params[6];
                var strCallerClass = CalcTypeString(_callerClass);
                var strObj = CalcExpressionString(_obj);
                var strIntf = CalcTypeString(_intf);
                var strClass = CalcTypeString(_class);
                var strMember = CalcTypeString(_member);
                var keyIsInteger = true;
                if (_typeargs.GetParamNum() > 0 && _typekinds.GetParamNum() > 0) {
                    var firstTypeArg = CalcTypeString(_typeargs.GetParam(0));
                    var firstTypeKind = CalcTypeString(_typekinds.GetParam(0));
                    keyIsInteger = IsIntegerType(firstTypeArg, firstTypeKind);
                }
                int indexerType;
                if (IndexerByLualib(strCallerClass, strObj, strIntf, strClass, strMember, out indexerType) && (indexerType == (int)IndexerTypeEnum.LikeArray || !keyIsInteger)) {
                    var _pct = data.Params[7].GetId();
                    var _toplevel = data.Params[8].GetId();
                    int ct;
                    int.TryParse(_pct, out ct);
                    if (ct == 2 && _toplevel == "true") {
                        var _index = data.Params[9];
                        var _val = data.Params[10];
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
                        int start = 9;
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
                int num = data.GetParamNum();
                if (num == 0) {
                    sb.Append("{...}");
                }
                else if (num == 1) {
                    int type;
                    if (int.TryParse(data.GetParamId(0), out type)) {
                        switch (type) {
                            case 0:
                                sb.Append("wraparray{...}");
                                break;
                            case 1:
                                sb.Append("wrapvaluetypearray{...}");
                                break;
                            case 2:
                                sb.Append("wrapexternvaluetypearray{...}");
                                break;
                        }
                    }
                }
                else {
                    int type;
                    if (int.TryParse(data.GetParamId(0), out type)) {
                        string name = data.GetParamId(1);
                        switch (type) {
                            case 0:
                                sb.AppendFormat("wraparray({0})", name);
                                break;
                            case 1:
                                sb.AppendFormat("wrapvaluetypearray({0})", name);
                                break;
                            case 2:
                                sb.AppendFormat("wrapexternvaluetypearray({0})", name);
                                break;
                        }
                    }
                }
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
                //这里可以对xlua的delegation用法进行特殊转换
                var obj = data.Params[0];
                var val = data.Params[1];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.Append(" = ");
                GenerateSyntaxComponent(val, sb, indent, false);
            }
            else if (id == "setstaticdelegation") {
                //这里可以对xlua的delegation用法进行特殊转换
                var obj = data.Params[0];
                var member = data.Params[1];
                var val = data.Params[2];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
                sb.Append(" = ");
                GenerateSyntaxComponent(val, sb, indent, false);
            }
            else if (id == "setinstancedelegation") {
                //这里可以对xlua的delegation用法进行特殊转换
                var obj = data.Params[0];
                var member = data.Params[1];
                var val = data.Params[2];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
                sb.Append(" = ");
                GenerateSyntaxComponent(val, sb, indent, false);
            }
            else if (id == "anonymousobject") {
                sb.Append("wrapdictionary{");
                GenerateArguments(data, sb, indent, 0);
                sb.Append("}");
            }
            else if (id == "literaldictionary") {
                sb.Append("{");
                string prestr = string.Empty;
                for (int ix = 0; ix < data.Params.Count; ++ix) {
                    var param = data.Params[ix] as Dsl.CallData;
                    sb.Append(prestr);
                    var k = param.GetParam(0);
                    var kcd = k as Dsl.CallData;
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
            else if (id == "literallist" || id == "literalcollection" || id == "literalcomplex" || id == "literalobject") {
                sb.Append("{");
                GenerateArguments(data, sb, indent, 0);
                sb.Append("}");
            }
            else if (id == "buildarray") {
                var typeStr = CalcTypeString(data.GetParam(0));
                if (typeStr == "System.Char") {
                    sb.Append("chararraytostring({");
                    GenerateArguments(data, sb, indent, 1);
                    sb.Append("})");
                }
                else {
                    sb.Append("wraparray({");
                    GenerateArguments(data, sb, indent, 1);
                    sb.Append("})");
                }
            }
            else if (id == "newarray") {
                var typeStr = CalcTypeString(data.GetParam(0));
                if (data.GetParamNum() > 1) {
                    var vname = data.GetParamId(1);
                    sb.AppendFormat("wraparray({{}}, {0})", vname);
                }
                else {
                    sb.Append("wraparray{}");
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
            else {
                if (null != callData) {
                    GenerateSyntaxComponent(callData, sb, indent, false);
                }
                else if (id == "if") {
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
                else if (id == "dslusing") {
                    sb.Append("luausing");
                }
                else if (id == "dsltry") {
                    sb.Append("luatry");
                }
                else if (id == "dslcatch") {
                    sb.Append("luacatch");
                }
                else if (id == "dslthrow") {
                    sb.Append("luathrow");
                }
                else {
                    sb.Append(id);
                }
                if (data.HaveParam()) {
                    if (id == "if" || id == "elseif" || id == "while" || id == "until") {
                    }
                    else {
                        switch (data.GetParamClass()) {
                            case (int)Dsl.CallData.ParamClassEnum.PARAM_CLASS_PARENTHESIS:
                                sb.Append("(");
                                break;
                            case (int)Dsl.CallData.ParamClassEnum.PARAM_CLASS_BRACKET:
                                sb.Append("[");
                                break;
                            case (int)Dsl.CallData.ParamClassEnum.PARAM_CLASS_PERIOD:
                                sb.AppendFormat(".{0}", data.GetParamId(0));
                                break;
                        }
                    }
                    if (data.GetParamClass() != (int)Dsl.CallData.ParamClassEnum.PARAM_CLASS_PERIOD) {
                        GenerateArguments(data, sb, indent, 0);
                    }
                    if (id == "if" || id == "elseif" || id == "while" || id == "until") {
                    }
                    else {
                        switch (data.GetParamClass()) {
                            case (int)Dsl.CallData.ParamClassEnum.PARAM_CLASS_PARENTHESIS:
                                sb.Append(")");
                                break;
                            case (int)Dsl.CallData.ParamClassEnum.PARAM_CLASS_BRACKET:
                                sb.Append("]");
                                break;
                            case (int)Dsl.CallData.ParamClassEnum.PARAM_CLASS_PERIOD:
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
            if (firstLineUseIndent) {
                sb.AppendFormat("{0}", GetIndentString(indent));
            }
            var fcall = data.Call;
            string id = string.Empty;
            var callData = fcall.Call;
            if (null == callData) {
                id = fcall.GetId();
            }
            if (id == "comments") {
                foreach (var comp in data.Statements) {
                    GenerateSyntaxComponent(comp, sb, indent, true);
                    sb.AppendLine();
                }
            }
            else if (id == "local") {
                bool first = true;
                foreach (var comp in data.Statements) {
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
            else {
                GenerateConcreteSyntax(fcall, sb, indent, false);
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
            if (firstLineUseIndent) {
                sb.AppendFormat("{0}", GetIndentString(indent));
            }
            string id = data.GetId();
            if (id == "linq") {
                string prestr = string.Empty;
                foreach (var funcData in data.Functions) {
                    var fcall = funcData.Call;
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
                    var fcall = funcData.Call;
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
                        if (param0.GetId() == "false") {
                            sb.AppendFormat("{0}until true", GetIndentString(indent));
                        }
                        else {
                            sb.AppendFormat("{0}until not (", GetIndentString(indent));
                            GenerateSyntaxComponent(param0, sb, indent, false);
                            sb.Append(")");
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
            else {
                foreach (var funcData in data.Functions) {
                    var fcall = funcData.Call;
                    GenerateConcreteSyntax(fcall, sb, indent, funcData == data.First ? false : true);
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
            string prestr = string.Empty;
            var cd = comp as Dsl.CallData;
            if (null != cd) {
                var attrCd = cd.GetParam(0) as Dsl.CallData;
                string attr;
                if (attrCd.IsHighOrder) {
                    attr = CalcTypeString(attrCd.Call);
                }
                else {
                    attr = attrCd.GetId();
                }
                sb.AppendFormat("{0}{{\"{1}\", {{", GetIndentString(indent), attr);
                var posAttrs = attrCd.GetParam(0) as Dsl.CallData;
                foreach (var p in posAttrs.Params) {
                    var pcd = p as Dsl.CallData;
                    var k = pcd.GetId();
                    var v = pcd.GetParamId(0);
                    sb.Append(prestr);
                    sb.AppendFormat("{0} = \"{1}\"", k, v);
                    prestr = ", ";
                }
                sb.Append("}, {");
                var nameAttrs = attrCd.GetParam(1) as Dsl.CallData;
                foreach (var p in nameAttrs.Params) {
                    var pcd = p as Dsl.CallData;
                    var k = pcd.GetId();
                    var v = pcd.GetParamId(0);
                    sb.Append(prestr);
                    sb.AppendFormat("{0} = \"{1}\"", k, v);
                    prestr = ", ";
                }
                sb.AppendLine("}};");
            }
        }
        private static void GenerateArguments(Dsl.CallData data, StringBuilder sb, int indent, int start)
        {
            string prestr = string.Empty;
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
            foreach (var comp in data.Statements) {
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
        private static string CalcTypeString(Dsl.ISyntaxComponent comp)
        {
            string ret = comp.GetId();
            var cd = comp as Dsl.CallData;
            if (null != cd && cd.GetParamClass() == (int)Dsl.CallData.ParamClassEnum.PARAM_CLASS_PERIOD) {
                string prefix;
                if (cd.IsHighOrder) {
                    prefix = CalcTypeString(cd.Call);
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
            foreach (var statement in funcData.Call.Params) {
                if (key == statement.GetId()) {
                    return statement;
                }
            }
            return null;
        }
        private static Dsl.ISyntaxComponent FindStatement(Dsl.FunctionData funcData, string key)
        {
            foreach (var statement in funcData.Statements) {
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
                    s_CachedFile2MergedFiles.Add(file, info.MergedFileName);
                    return info.MergedFileName;
                }
                foreach (var regex in info.Matches) {
                    if (regex.IsMatch(file)) {
                        s_CachedFile2MergedFiles.Add(file, info.MergedFileName);
                        return info.MergedFileName;
                    }
                }
            }
            s_CachedFile2MergedFiles.Add(file, null);
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
                        s_CachedNoSignatures.Add(signature, true);
                        return true;
                    }
                }
            }
            s_CachedNoSignatures.Add(signature, false);
            return false;
        }
        private static bool IndexerByLualib(string objClassName, string obj, string intf, string className, string member, out int val)
        {
            string key = string.Format("{0}|{1}|{2}|{3}|{4}", objClassName, obj, intf, className, member);
            if (s_CachedIndexerByLualibInfos.TryGetValue(key, out val)) {
                return val != 0;
            }
            foreach (var info in s_IndexerByLualibInfos) {
                if ((null == info.ObjectClassMatch || info.ObjectClassMatch.IsMatch(objClassName)) && 
                    (null == info.ObjectMatch || info.ObjectMatch.IsMatch(obj)) &&
                    (null == info.InterfaceMatch || info.InterfaceMatch.IsMatch(intf)) &&
                    (null == info.ClassMatch || info.ClassMatch.IsMatch(className)) &&
                    (null == info.MemberMatch || info.MemberMatch.IsMatch(member))) {
                    s_CachedIndexerByLualibInfos.Add(key, info.IndexerType);
                    val = info.IndexerType;
                    return true;
                }
            }
            s_CachedIndexerByLualibInfos.Add(key, 0);
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
            s_CachedPrologueAndEpilogueInfos.Add(key, info);
            return info;
        }
        private static void ReadConfig()
        {
            s_DontRequireInfos.Clear();
            s_FileMergeInfos.Clear();
            s_NoSignatureArgInfos.Clear();
            s_AddPrologueOrEpilogueInfos.Clear();
            s_CachedFile2MergedFiles.Clear();
            s_CachedNoSignatures.Clear();
            s_CachedPrologueAndEpilogueInfos.Clear();

            var file = Path.Combine(s_ExePath, "cs2dsl.dsl");
            var dslFile = new Dsl.DslFile();
            if (dslFile.Load(file, msg => { Console.WriteLine(msg); })) {
                foreach (var info in dslFile.DslInfos) {
                    ReadConfig(info);
                }
            }
        }
        private static void ReadConfig(Dsl.DslInfo info)
        {
            string id = info.GetId();
            if (id == "dontrequire") {
                var cfg = new DontRequireInfo();
                var f = info.First;
                if (null != f) {
                    foreach (var p in f.Call.Params) {
                        cfg.Requires.Add(p.GetId());
                    }
                    foreach (var s in f.Statements) {
                        cfg.Requires.Add(s.GetId());
                    }
                }
                for (int i = 1; i < info.GetFunctionNum(); ++i) {
                    f = info.GetFunction(i);
                    if (null != f) {
                        string fid = f.GetId();
                        if (fid == "match") {
                            foreach (var p in f.Call.Params) {
                                var str = p.GetId();
                                var regex = new Regex(str, RegexOptions.Compiled);
                                cfg.Matches.Add(regex);
                            }
                            foreach (var s in f.Statements) {
                                var str = s.GetId();
                                var regex = new Regex(str, RegexOptions.Compiled);
                                cfg.Matches.Add(regex);
                            }
                        }
                        else if (fid == "except") {
                            foreach (var p in f.Call.Params) {
                                cfg.Excepts.Add(p.GetId());
                            }
                            foreach (var s in f.Statements) {
                                cfg.Excepts.Add(s.GetId());
                            }
                        }
                        else if (fid == "exceptmatch") {
                            foreach (var p in f.Call.Params) {
                                var str = p.GetId();
                                var regex = new Regex(str, RegexOptions.Compiled);
                                cfg.ExceptMatches.Add(regex);
                            }
                            foreach (var s in f.Statements) {
                                var str = s.GetId();
                                var regex = new Regex(str, RegexOptions.Compiled);
                                cfg.ExceptMatches.Add(regex);
                            }
                        }
                    }
                }
                s_DontRequireInfos.Add(cfg);
            }
            else if (id == "filemerge") {
                var cfg = new FileMergeInfo();
                var f = info.First;
                if (null != f) {
                    if (f.Call.GetParamNum() > 0) {
                        var p = f.Call.GetParamId(0);
                        cfg.MergedFileName = p;
                    }
                    else if (f.GetStatementNum() > 0) {
                        var s = f.GetStatementId(0);
                        cfg.MergedFileName = s;
                    }
                }
                for (int i = 1; i < info.GetFunctionNum(); ++i) {
                    f = info.GetFunction(i);
                    if (null != f) {
                        string fid = f.GetId();
                        if (fid == "list") {
                            foreach (var p in f.Call.Params) {
                                cfg.Lists.Add(p.GetId());
                            }
                            foreach (var s in f.Statements) {
                                cfg.Lists.Add(s.GetId());
                            }
                        }
                        else if (fid == "match") {
                            foreach (var p in f.Call.Params) {
                                var str = p.GetId();
                                var regex = new Regex(str, RegexOptions.Compiled);
                                cfg.Matches.Add(regex);
                            }
                            foreach (var s in f.Statements) {
                                var str = s.GetId();
                                var regex = new Regex(str, RegexOptions.Compiled);
                                cfg.Matches.Add(regex);
                            }
                        }
                    }
                }
                s_FileMergeInfos.Add(cfg.MergedFileName, cfg);
            }
            else if (id == "nosignaturearg") {
                var cfg = new NoSignatureArgInfo();
                var f = info.First;
                if (null != f) {
                    foreach (var p in f.Call.Params) {
                        var str = p.GetId();
                        var regex = new Regex(str, RegexOptions.Compiled);
                        cfg.Matches.Add(regex);
                    }
                    foreach (var s in f.Statements) {
                        var str = s.GetId();
                        var regex = new Regex(str, RegexOptions.Compiled);
                        cfg.Matches.Add(regex);
                    }
                }
                s_NoSignatureArgInfos.Add(cfg);
            }
            else if (id == "indexerbylualib") {
                var cfg = new IndexerByLualibInfo();
                var f = info.First;
                if (null != f) {
                    if (f.Call.GetParamNum() >= 5) {
                        var str = f.Call.GetParamId(0);
                        var regex = new Regex(str, RegexOptions.Compiled);
                        cfg.ObjectClassMatch = regex;
                        str = f.Call.GetParamId(1);
                        regex = new Regex(str, RegexOptions.Compiled);
                        cfg.ObjectMatch = regex;
                        str = f.Call.GetParamId(2);
                        regex = new Regex(str, RegexOptions.Compiled);
                        cfg.InterfaceMatch = regex;
                        str = f.Call.GetParamId(3);
                        regex = new Regex(str, RegexOptions.Compiled);
                        cfg.ClassMatch = regex;
                        str = f.Call.GetParamId(4);
                        regex = new Regex(str, RegexOptions.Compiled);
                        cfg.MemberMatch = regex;

                        foreach (var s in f.Statements) {
                            var cd = s as Dsl.CallData;
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
                var f = info.First;
                if (null != f) {
                    int pnum = f.Call.GetParamNum();
                    int snum = f.GetStatementNum();
                    if (pnum > 0) {
                        var fmt = f.Call.GetParamId(0);
                        cfg.LogInfo.Format = fmt;
                        var list = new List<string>();
                        for (int ix = 1; ix < pnum; ++ix) {
                            var arg = f.Call.GetParamId(ix);
                            list.Add(arg);
                        }
                        cfg.LogInfo.Args = list.ToArray();
                    }
                    else if (snum > 0) {
                        var fmt = f.GetStatementId(0);
                        cfg.LogInfo.Format = fmt;
                        var list = new List<string>();
                        for (int ix = 1; ix < pnum; ++ix) {
                            var arg = f.GetStatementId(ix);
                            list.Add(arg);
                        }
                        cfg.LogInfo.Args = list.ToArray();
                    }
                }
                for (int i = 1; i < info.GetFunctionNum(); ++i) {
                    f = info.GetFunction(i);
                    if (null != f) {
                        string fid = f.GetId();
                        if (fid == "list") {
                            foreach (var p in f.Call.Params) {
                                cfg.Lists.Add(p.GetId());
                            }
                            foreach (var s in f.Statements) {
                                cfg.Lists.Add(s.GetId());
                            }
                        }
                        else if (fid == "match") {
                            foreach (var p in f.Call.Params) {
                                var str = p.GetId();
                                var regex = new Regex(str, RegexOptions.Compiled);
                                cfg.Matches.Add(regex);
                            }
                            foreach (var s in f.Statements) {
                                var str = s.GetId();
                                var regex = new Regex(str, RegexOptions.Compiled);
                                cfg.Matches.Add(regex);
                            }
                        }
                    }
                }
                s_AddPrologueOrEpilogueInfos.Add(cfg);
            }
        }

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
            internal Regex ObjectMatch = null;
            internal Regex InterfaceMatch = null;
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

        private static List<DontRequireInfo> s_DontRequireInfos = new List<DontRequireInfo>();
        private static Dictionary<string, FileMergeInfo> s_FileMergeInfos = new Dictionary<string, FileMergeInfo>();
        private static List<NoSignatureArgInfo> s_NoSignatureArgInfos = new List<NoSignatureArgInfo>();
        private static List<IndexerByLualibInfo> s_IndexerByLualibInfos = new List<IndexerByLualibInfo>();
        private static List<AddPrologueOrEpilogueInfo> s_AddPrologueOrEpilogueInfos = new List<AddPrologueOrEpilogueInfo>();
        private static Dictionary<string, string> s_CachedFile2MergedFiles = new Dictionary<string, string>();
        private static Dictionary<string, bool> s_CachedNoSignatures = new Dictionary<string, bool>();
        private static Dictionary<string, int> s_CachedIndexerByLualibInfos = new Dictionary<string, int>();
        private static Dictionary<string, PrologueAndEpilogueInfo> s_CachedPrologueAndEpilogueInfos = new Dictionary<string, PrologueAndEpilogueInfo>();
    }
}
