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
    internal static partial class LuaGenerator
    {
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
                    string fullName = CalcTypeString(callData.GetParam(0));
                    var baseClass = callData.GetParam(1);
                    string baseClassName = string.Empty;
                    if (null != baseClass) {
                        baseClassName = CalcTypeString(baseClass);
                    }

                    sb.AppendLine();

                    int dotIx = fullName.LastIndexOf('.');
                    if (dotIx > 0) {
                        string ns = fullName.Substring(0, dotIx);
                        string className = fullName.Substring(dotIx + 1);

                        sb.AppendFormatLine("{0}rawset({1}, \"{2}\", {{", GetIndentString(indent), ns, className);
                        ++indent;
                        foreach (var comp in funcData.Params) {
                            var cd = comp as Dsl.FunctionData;
                            if (null != cd) {
                                sb.AppendFormatLine("{0}[\"{1}\"] = {2},", GetIndentString(indent), cd.GetParamId(0), cd.GetParamId(1));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}});", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), fullName);
                        ++indent;
                        foreach (var comp in funcData.Params) {
                            var cd = comp as Dsl.FunctionData;
                            if (null != cd) {
                                sb.AppendFormatLine("{0}[\"{1}\"] = {2},", GetIndentString(indent), cd.GetParamId(0), cd.GetParamId(1));
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }

                    sb.AppendLine();

                    sb.AppendFormatLine("{0}rawset({1}, \"Value2String\", {{", GetIndentString(indent), fullName);
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
                    if (null != staticMethods && staticMethods.GetParamNum() > 0) {
                        sb.AppendFormatLine("{0}-------------------------------", GetIndentString(indent));
                        sb.AppendFormatLine("{0}-------- class methods --------", GetIndentString(indent));
                        sb.AppendFormatLine("{0}-------------------------------", GetIndentString(indent));
                        bool firstMethod = true;
                        foreach (var def in staticMethods.Params) {
                            if (!firstMethod)
                                sb.AppendLine();
                            firstMethod = false;

                            var mdef = def as Dsl.FunctionData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var mtemp = mdef.GetParam(1);
                                var cdef = mtemp as Dsl.FunctionData;
                                var fdef = mtemp as Dsl.StatementData;
                                if (null != cdef) {
                                    fdef = cdef.GetParam(0) as Dsl.StatementData;
                                }
                                if (null != fdef && fdef.GetFunctionNum() == 2) {
                                    var first = fdef.First;
                                    var second = fdef.Second;
                                    int rct;
                                    int.TryParse(first.GetParamId(0), out rct);
                                    if (second.HaveStatement()) {
                                        var fcall = second;
                                        if (second.IsHighOrder)
                                            fcall = second.LowerOrderFunction;
                                        sb.AppendFormat("{0}{1} = ", GetIndentString(indent), mname);
                                        if (null != cdef) {
                                            sb.Append("wrapenumerable(");
                                        }
                                        sb.Append("function(");
                                        bool haveParams = GenerateFunctionParams(fcall, sb);
                                        sb.AppendLine(")");
                                        ++indent;
                                        var logInfo = GetPrologueAndEpilogue(className, mname);
                                        if (null != logInfo.PrologueInfo) {
                                            sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfo.PrologueInfo, className, mname));
                                        }
                                        if (null != logInfo.EpilogueInfo) {
                                            if (rct > 0) {
                                                sb.AppendFormat("{0}local ", GetIndentString(indent));
                                                GenerateFunctionRetVars(second, sb, rct, "__retval_");
                                                sb.AppendFormat(" = {0}.__real_{1}(", className, mname);
                                                GenerateFunctionParams(fcall, sb);
                                                sb.AppendLine(");");
                                                sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfo.EpilogueInfo, className, mname));
                                                sb.AppendFormat("{0}return ", GetIndentString(indent));
                                                GenerateFunctionRetVars(second, sb, rct, "__retval_");
                                                sb.AppendLine(";");
                                            }
                                            else {
                                                sb.AppendFormat("{0}{1}.__real_{2}(", GetIndentString(indent), className, mname);
                                                GenerateFunctionParams(fcall, sb);
                                                sb.AppendLine(");");
                                                sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfo.EpilogueInfo, className, mname));
                                            }
                                            --indent;
                                            if(null!=cdef)
                                                sb.AppendFormatLine("{0}end),", GetIndentString(indent));
                                            else
                                                sb.AppendFormatLine("{0}end,", GetIndentString(indent));
                                            sb.AppendFormat("{0}__real_{1} = ", GetIndentString(indent), mname);
                                            sb.Append("function(");
                                            GenerateFunctionParams(fcall, sb);
                                            sb.AppendLine(")");
                                            ++indent;
                                        }
                                        sb.AppendFormatLine("{0}local __cs2lua_func_info = luainitialize();", GetIndentString(indent));
                                        GenerateStatements(second, sb, indent);
                                        bool lastIsNotReturn = true;
                                        int snum = second.GetParamNum();
                                        for (; snum > 0; --snum) {
                                            var cid = second.GetParamId(snum - 1);
                                            if (cid != "comment" && cid != "comments")
                                                break;
                                        }
                                        if (snum > 0) {
                                            lastIsNotReturn = second.GetParamId(snum - 1) != "return";
                                        }
                                        if (rct <= 0 && lastIsNotReturn) {
                                            sb.AppendFormatLine("{0}__cs2lua_func_info = luafinalize(__cs2lua_func_info);", GetIndentString(indent));
                                        }
                                        --indent;
                                        if (null != cdef && null == logInfo.EpilogueInfo)
                                            sb.AppendFormatLine("{0}end),", GetIndentString(indent));
                                        else
                                            sb.AppendFormatLine("{0}end,", GetIndentString(indent));
                                    }
                                }
                            }
                        }
                        sb.AppendLine();
                    }

                    var staticFields = FindStatement(funcData, "static_fields") as Dsl.FunctionData;
                    if (null != staticFields && staticFields.GetParamNum() > 0) {
                        sb.AppendFormatLine("{0}-------------------------------", GetIndentString(indent));
                        sb.AppendFormatLine("{0}-------- class fields --------", GetIndentString(indent));
                        sb.AppendFormatLine("{0}-------------------------------", GetIndentString(indent));
                        foreach (var def in staticFields.Params) {
                            var mdef = def as Dsl.FunctionData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var comp = mdef.GetParam(1);
                                if (comp.GetId() != "null") {
                                    sb.AppendFormat("{0}{1} = ", GetIndentString(indent), mname);
                                    GenerateFieldValueComponent(comp, sb, indent, false);
                                    sb.AppendLine(",");
                                }
                            }
                        }
                        sb.AppendLine();
                    }

                    sb.AppendFormatLine("{0}-------------------------------", GetIndentString(indent));
                    sb.AppendFormatLine("{0}--- define class and object ---", GetIndentString(indent));
                    sb.AppendFormatLine("{0}-------------------------------", GetIndentString(indent));
                    var logInfoForDefineClass = GetPrologueAndEpilogue(className, "__define_class");
                    sb.AppendFormatLine("{0}__define_class = function()", GetIndentString(indent));
                    ++indent;
                    if (null != logInfoForDefineClass.PrologueInfo) {
                        sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfoForDefineClass.PrologueInfo, className, "__define_class"));
                    }
                    sb.AppendLine();

                    sb.AppendFormatLine("{0}local class = {1};", GetIndentString(indent), className);
                    
                    sb.AppendLine();

                    var instMethods = FindStatement(funcData, "instance_methods") as Dsl.FunctionData;
                    if (null != instMethods && instMethods.GetParamNum() > 0) {
                        sb.AppendFormatLine("{0}local obj_methods = {{", GetIndentString(indent));
                        ++indent;
                        bool firstMethod = true;
                        foreach (var def in instMethods.Params) {
                            if (!firstMethod)
                                sb.AppendLine();
                            firstMethod = false;

                            var mdef = def as Dsl.FunctionData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var mtemp = mdef.GetParam(1);
                                var cdef = mtemp as Dsl.FunctionData;
                                var fdef = mtemp as Dsl.StatementData;
                                if (null != cdef) {
                                    fdef = cdef.GetParam(0) as Dsl.StatementData;
                                }
                                if (null != fdef && fdef.GetFunctionNum() == 2) {
                                    var first = fdef.First;
                                    var second = fdef.Second;
                                    int rct;
                                    int.TryParse(first.GetParamId(0), out rct);
                                    if (second.HaveStatement()) {
                                        var fcall = second;
                                        if (second.IsHighOrder)
                                            fcall = second.LowerOrderFunction;
                                        sb.AppendFormat("{0}{1} = ", GetIndentString(indent), mname);
                                        if (null != cdef) {
                                            sb.Append("wrapenumerable(");
                                        }
                                        sb.Append("function(");
                                        bool haveParams = GenerateFunctionParams(fcall, sb);
                                        sb.AppendLine(")");
                                        ++indent;
                                        var logInfo = GetPrologueAndEpilogue(className, mname);
                                        if (null != logInfo.PrologueInfo) {
                                            sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfo.PrologueInfo, className, mname));
                                        }
                                        if (null != logInfo.EpilogueInfo) {
                                            if (rct > 0) {
                                                sb.AppendFormat("{0}local ", GetIndentString(indent));
                                                GenerateFunctionRetVars(second, sb, rct, "__retval_");
                                                sb.AppendFormat(" = {0}.__real_{1}(", "this", mname);
                                                GenerateFunctionParams(fcall, sb);
                                                sb.AppendLine(");");
                                                sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfo.EpilogueInfo, className, mname));
                                                sb.AppendFormat("{0}return ", GetIndentString(indent));
                                                GenerateFunctionRetVars(second, sb, rct, "__retval_");
                                                sb.AppendLine(";");
                                            }
                                            else {
                                                sb.AppendFormat("{0}{1}.__real_{2}(", GetIndentString(indent), "this", mname);
                                                GenerateFunctionParams(fcall, sb);
                                                sb.AppendLine(");");
                                                sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfo.EpilogueInfo, className, mname));
                                            }
                                            --indent;
                                            if (null != cdef)
                                                sb.AppendFormatLine("{0}end),", GetIndentString(indent));
                                            else
                                                sb.AppendFormatLine("{0}end,", GetIndentString(indent));
                                            sb.AppendFormat("{0}__real_{1} = ", GetIndentString(indent), mname);
                                            sb.Append("function(");
                                            GenerateFunctionParams(fcall, sb);
                                            sb.AppendLine(")");
                                            ++indent;
                                        }
                                        sb.AppendFormatLine("{0}local __cs2lua_func_info = luainitialize();", GetIndentString(indent));
                                        GenerateStatements(second, sb, indent);
                                        bool lastIsNotReturn = true;
                                        int snum = second.GetParamNum();
                                        for (; snum > 0; --snum) {
                                            var cid = second.GetParamId(snum - 1);
                                            if (cid != "comment" && cid != "comments")
                                                break;
                                        }
                                        if (snum > 0) {
                                            lastIsNotReturn = second.GetParamId(snum - 1) != "return";
                                        }
                                        if (rct <= 0 && lastIsNotReturn) {
                                            sb.AppendFormatLine("{0}__cs2lua_func_info = luafinalize(__cs2lua_func_info);", GetIndentString(indent));
                                        }
                                        --indent;
                                        if (null != cdef && null == logInfo.EpilogueInfo)
                                            sb.AppendFormatLine("{0}end),", GetIndentString(indent));
                                        else
                                            sb.AppendFormatLine("{0}end,", GetIndentString(indent));
                                    }
                                }
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}local obj_methods = nil;", GetIndentString(indent));
                    }

                    sb.AppendLine();

                    sb.AppendFormatLine("{0}local obj_build = function()", GetIndentString(indent));
                    ++indent;
                    var instFields = FindStatement(funcData, "instance_fields") as Dsl.FunctionData;
                    if (null != instFields && instFields.GetParamNum() > 0) {
                        sb.AppendFormatLine("{0}return {{", GetIndentString(indent));
                        ++indent;

                        foreach (var def in instFields.Params) {
                            var mdef = def as Dsl.FunctionData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                var comp = mdef.GetParam(1);
                                if (comp.GetId() != "null") {
                                    sb.AppendFormat("{0}{1} = ", GetIndentString(indent), mname);
                                    GenerateFieldValueComponent(comp, sb, indent, false);
                                    sb.AppendLine(",");
                                }
                            }
                        }

                        --indent;
                        sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}return nil;", GetIndentString(indent));
                    }
                    --indent;
                    sb.AppendFormatLine("{0}end;", GetIndentString(indent));

                    sb.AppendLine();
                    ///备忘：
                    ///这个对象模型分为class、obj_methods, obj_build三块
                    ///1、class表包含了静态方法与静态字段
                    ///2、obj_methods表独立有2个作用，一个方法放到obj上可能占内存会比较多，另外为了支持方法换名以支持虚函数机制
                    ///，参见lualib的defineclass实现。
                    ///3、obj_build是个函数，用来生成每个对象实例，已经包含了对应的字段表与初始值（因为每个实例都需要一份不同的数
                    ///据，所以是一个返回字段表的函数）
                    ///4、考虑继承机制需要在当前类不存在成员时往父类查找，而字段值可能是nil，此时相当于类实例里删除了这个字段，为
                    ///了仍然能正确查到当前类是否存在字段，在类信息里额外保存了2个字段信息表，一个静态的，一个实例的。
                    if (null != logInfoForDefineClass.EpilogueInfo) {
                        sb.AppendFormatLine("{0}local __defineclass_return = defineclass({1}, \"{2}\", \"{3}\", class, obj_methods, obj_build, {4});", GetIndentString(indent), null == baseClass || !baseClass.IsValid() ? "nil" : baseClassName, className, GetLastName(className), isValueType ? "true" : "false");
                        sb.AppendFormatLine("{0}{1};", GetIndentString(indent), CalcLogInfo(logInfoForDefineClass.EpilogueInfo, className, "__define_class"));
                        sb.AppendFormatLine("{0}return __defineclass_return;", GetIndentString(indent));
                    }
                    else {
                        sb.AppendFormatLine("{0}return defineclass({1}, \"{2}\", \"{3}\", class, obj_methods, obj_build, {4});", GetIndentString(indent), null == baseClass || !baseClass.IsValid() ? "nil" : baseClassName, className, GetLastName(className), isValueType ? "true" : "false");
                    }
                    --indent;
                    sb.AppendFormatLine("{0}end,", GetIndentString(indent));

                    sb.AppendLine();

                    sb.AppendFormatLine("{0}-------------------------------", GetIndentString(indent));
                    sb.AppendFormatLine("{0}--------- fields info ---------", GetIndentString(indent));
                    sb.AppendFormatLine("{0}-------------------------------", GetIndentString(indent));
                    if (null != staticFields && staticFields.GetParamNum() > 0) {
                        sb.AppendFormatLine("{0}__class_fields = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in staticFields.Params) {
                            var mdef = def as Dsl.FunctionData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                sb.AppendFormatLine("{0}{1} = true,", GetIndentString(indent), mname);
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                    }

                    sb.AppendLine();

                    if (null != instFields && instFields.GetParamNum() > 0) {
                        sb.AppendFormatLine("{0}__obj_fields = {{", GetIndentString(indent));
                        ++indent;
                        foreach (var def in instFields.Params) {
                            var mdef = def as Dsl.FunctionData;
                            if (mdef.GetId() == "=") {
                                string mname = mdef.GetParamId(0);
                                sb.AppendFormatLine("{0}{1} = true,", GetIndentString(indent), mname);
                            }
                        }
                        --indent;
                        sb.AppendFormatLine("{0}}},", GetIndentString(indent));
                    }

                    sb.AppendLine();

                    sb.AppendFormatLine("{0}-------------------------------", GetIndentString(indent));
                    sb.AppendFormatLine("{0}-------- metadata info --------", GetIndentString(indent));
                    sb.AppendFormatLine("{0}-------------------------------", GetIndentString(indent));
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
        private static bool GenerateFunctionParams(Dsl.FunctionData fcall, StringBuilder sb)
        {
            bool haveParams = false;
            string prestr = string.Empty;
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
            return haveParams;
        }
        private static void GenerateFunctionRetVars(Dsl.FunctionData fdef, StringBuilder sb, int ct, string prefix)
        {
            for(int i = 0; i < ct; ++i) {
                if (i > 0)
                    sb.Append(", ");
                sb.AppendFormat("{0}{1}", prefix, i + 1);
            }
        }
        private static void GenerateFieldValueComponent(Dsl.ISyntaxComponent comp, StringBuilder sb, int indent, bool firstLineUseIndent)
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
        private static void GenerateStatement(Dsl.ISyntaxComponent comp, StringBuilder sb, int indent)
        {
            var func = comp as Dsl.FunctionData;
            if (null != func && !func.HaveStatement()) {
                Dsl.FunctionData oper;
                bool prefix;
                if (CanSplitPrefixPostfixOperator(comp, out oper, out prefix)) {
                    sb.AppendFormat("{0}", GetIndentString(indent));
                    GeneratePrefixPostfixOperator(oper, sb, true);
                    sb.AppendLine(";");
                    var p = oper.GetParam(0) as Dsl.ValueData;
                    p.SetId("false");
                    GenerateSyntaxComponent(comp, sb, indent, true);
                }
                else {
                    GenerateSyntaxComponent(comp, sb, indent, true);
                }
            }
            else {
                GenerateSyntaxComponent(comp, sb, indent, true);
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
            s_CurSyntax = data;
            if (firstLineUseIndent) {
                sb.AppendFormat("{0}", GetIndentString(indent));
            }
            string id = data.GetId();
            switch (data.GetIdType()) {
                case (int)Dsl.ValueData.ID_TOKEN:
                case (int)Dsl.ValueData.NUM_TOKEN:
                    if (id == "null") {
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
                    else if (id == "=" && (leftParamId == "getstatic"
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
                    else if (id == "=" && leftParamId == "getexternstaticstructmember") {
                        var cd = param1 as Dsl.FunctionData;
                        if (null != cd.Name) {
                            cd.Name.SetId("setexternstatic");
                            cd.AddParam(param2);
                            GenerateConcreteSyntax(cd, sb, indent, false);
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
            else if (id == "condexp") {
                var p1 = data.GetParam(0);
                var p2 = data.GetParamId(1);
                var p3 = data.GetParam(2);
                var p3Func = p3 as Dsl.FunctionData;
                var p4 = data.GetParamId(3);
                var p5 = data.GetParam(4);
                var p5Func = p5 as Dsl.FunctionData;
                if (p2 == "false" && null != p3Func && !ExistEmbedFunctionObject(p3Func)) {
                    var func = p3Func.GetParam(0) as Dsl.FunctionData;
                    if (null != func && !func.HaveId() && func.GetParamNum() == 1) {
                        func = func.GetParam(0) as Dsl.FunctionData;
                    }
                    if (null != func && func.GetId() == "funcobjret") {
                        p2 = "true";
                        p3 = func.GetParam(0);
                    }
                }
                if (p4 == "false" && null != p5Func && !ExistEmbedFunctionObject(p5Func)) {
                    var func = p5Func.GetParam(0) as Dsl.FunctionData;
                    if (null != func && !func.HaveId() && func.GetParamNum() == 1) {
                        func = func.GetParam(0) as Dsl.FunctionData;
                    }
                    if (null != func && func.GetId() == "funcobjret") {
                        p4 = "true";
                        p5 = func.GetParam(0);
                    }
                }
                if (p2 == "true" && p4 == "true") {
                    sb.Append("((");
                    GenerateSyntaxComponent(p1, sb, indent, false);
                    sb.Append(") and (");
                    GenerateSyntaxComponent(p3, sb, indent, false);
                    sb.Append(") or (");
                    GenerateSyntaxComponent(p5, sb, indent, false);
                    sb.Append("))");
                }
                else {
                    sb.Append("condexp(");
                    GenerateSyntaxComponent(p1, sb, indent, false);
                    sb.Append(", ");
                    sb.Append(p2);
                    sb.Append(", ");
                    GenerateSyntaxComponent(p3, sb, indent, false);
                    sb.Append(", ");
                    sb.Append(p4);
                    sb.Append(", ");
                    GenerateSyntaxComponent(p5, sb, indent, false);
                    sb.Append(")");
                }
            }
            else if (id == "condaccess") {
                var p1 = data.GetParam(0);
                var p2 = data.GetParam(1);
                var p2Func = p2 as Dsl.FunctionData;
                var isSimple = false;
                if (null != p2Func && !ExistEmbedFunctionObject(p2Func)) {
                    var func = p2Func.GetParam(0) as Dsl.FunctionData;
                    if (null != func && !func.HaveId() && func.GetParamNum() == 1) {
                        func = func.GetParam(0) as Dsl.FunctionData;
                    }
                    if (null != func && func.GetId() == "funcobjret") {
                        isSimple = true;
                        p2 = func.GetParam(0);
                    }
                }
                if (isSimple) {
                    sb.Append("((");
                    GenerateSyntaxComponent(p1, sb, indent, false);
                    sb.Append(") and (");
                    GenerateSyntaxComponent(p2, sb, indent, false);
                    sb.Append(") or nil)");
                }
                else {
                    sb.Append("condaccess(");
                    GenerateSyntaxComponent(p1, sb, indent, false);
                    sb.Append(", ");
                    sb.Append(p2);
                    sb.Append(")");
                }
            }
            else if(id== "nullcoalescing") {
                var p1 = data.GetParam(0);
                var p2 = data.GetParamId(1);
                var p3 = data.GetParam(2);
                var p3Func = p3 as Dsl.FunctionData;
                if (p2 == "false" && null != p3Func && !ExistEmbedFunctionObject(p3Func)) {
                    var func = p3Func.GetParam(0) as Dsl.FunctionData;
                    if (null != func && !func.HaveId() && func.GetParamNum() == 1) {
                        func = func.GetParam(0) as Dsl.FunctionData;
                    }
                    if (null != func && func.GetId() == "funcobjret") {
                        p2 = "true";
                        p3 = func.GetParam(0);
                    }
                }
                if (p2 == "true") {
                    sb.Append("((");
                    GenerateSyntaxComponent(p1, sb, indent, false);
                    sb.Append(") or (");
                    GenerateSyntaxComponent(p3, sb, indent, false);
                    sb.Append("))");
                }
                else {
                    sb.Append("nullcoalescing(");
                    GenerateSyntaxComponent(p1, sb, indent, false);
                    sb.Append(", ");
                    GenerateSyntaxComponent(p3, sb, indent, false);
                    sb.Append(")");
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
                sb.AppendLine("__cs2lua_func_info = luafinalize(__cs2lua_func_info);");
                sb.AppendFormat("{0}return ", GetIndentString(indent));
                GenerateArguments(data, sb, indent, 0);
            }
            else if (id == "funcobjret") {
                sb.AppendFormat("{0}return ", GetIndentString(indent));
                GenerateArguments(data, sb, indent, 0);
            }
            else if (id == "newobject" || id == "newstruct" || id == "newexternobject" || id == "newexternstruct" ||
                id == "wrapoutstruct" || id == "wrapoutexternstruct" || id == "wrapstruct" || id == "wrapexternstruct" || 
                id == "getexternstaticstructmember") {
                sb.Append(id);
                sb.Append("(__cs2lua_func_info");
                if (data.GetParamNum() > 0)
                    sb.Append(", ");
                GenerateArguments(data, sb, indent, 0);
                sb.Append(")");
            }
            else if (id == "prefixoperator" || id == "postfixoperator") {
                GeneratePrefixPostfixOperator(data, sb, false);
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
                    sb.Append("System.String.Concat(\"System.String:Concat__String__String__String\", ");
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
                else if ((op == "==" || op == "!=") && type1 == "System.String" && type2 == "System.String") {
                    if (op == "==") {
                        sb.Append("stringisequal(");
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.Append(", ");
                        GenerateSyntaxComponent(p2, sb, indent, false);
                        sb.Append(")");
                    }
                    else {
                        sb.Append("(not stringisequal(");
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.Append(", ");
                        GenerateSyntaxComponent(p2, sb, indent, false);
                        sb.Append("))");
                    }
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
            else if (id == "calldelegation" || id == "callexterndelegation") {
                var obj = data.Params[0];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.Append("(");
                int start = 1;
                GenerateArguments(data, sb, indent, start);
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
                var srcPos = data.GetParamId(0);
                var delegationKey = data.GetParamId(1);
                var objOrClass = data.GetParam(2);
                var methodName = data.GetParamId(3);
                var isStatic = data.GetParamId(4) == "true";

                sb.AppendLine("(function()");
                ++indent;
                sb.AppendFormat("{0}local __obj_{1} = ", GetIndentString(indent), srcPos);
                GenerateSyntaxComponent(objOrClass, sb, 0, false);
                sb.AppendLine(";");
                sb.AppendFormatLine("{0}local __fk_{1} = calcdelegationkey(\"{2}\", __obj_{1});", GetIndentString(indent), srcPos, delegationKey);
                sb.AppendFormatLine("{0}return builddelegationonce(__fk_{1}, getdelegation(__fk_{1}) or function(...)", GetIndentString(indent), srcPos, delegationKey);
                ++indent;
                sb.AppendFormat("{0}", GetIndentString(indent));
                sb.AppendFormat("return __obj_{0}", srcPos);
                if (isStatic) {
                    sb.Append(".");
                }
                else {
                    sb.Append(":");
                }
                sb.Append(methodName);
                sb.AppendLine("(...);");
                --indent;
                sb.AppendFormatLine("{0}end);", GetIndentString(indent));
                --indent;
                sb.AppendFormat("{0}end)()", GetIndentString(indent));
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
            else if (id == "newmultiarray") {
                var typeStr = CalcTypeString(data.GetParam(0));
                var typeKind = CalcTypeString(data.GetParam(1));
                var defVal = data.GetParam(2);
                int ct;
                int.TryParse(data.GetParamId(3), out ct);
                if (ct <= 3) {
                    //三维以下数组的定义在lualib里实现
                    sb.AppendFormat("newarraydim{0}({1}, {2}, ", ct, typeStr, typeKind);
                    GenerateSyntaxComponent(defVal, sb, 0, false);
                    if (ct > 0) {
                        sb.Append(", ");
                        var exp = data.GetParam(4 + 0);
                        GenerateSyntaxComponent(exp, sb, 0, false);
                    }
                    if (ct > 1) {
                        sb.Append(", ");
                        var exp = data.GetParam(4 + 1);
                        GenerateSyntaxComponent(exp, sb, 0, false);
                    }
                    if (ct > 2) {
                        sb.Append(", ");
                        var exp = data.GetParam(4 + 2);
                        GenerateSyntaxComponent(exp, sb, 0, false);
                    }
                    sb.Append(")");
                }
                else {
                    //四维及以上数组在这里使用函数对象嵌入初始化代码，应该很少用到
                    sb.Append("(function()");
                    for (int i = 0; i < ct; ++i) {
                        sb.AppendFormat(" local d{0} = ", i);
                        var exp = data.GetParam(4 + i);
                        GenerateSyntaxComponent(exp, sb, 0, false);
                        if (i == 0) {
                            sb.AppendFormat("; local arr = wraparray({{}}, d0, {0}, {1})", typeStr, typeKind);
                        }
                        sb.AppendFormat("; for i{0} = 1, d{1} do arr{2} = ", i, i, GetArraySubscriptString(i));
                        if (i < ct - 1) {
                            sb.Append("wraparray({}, ");
                            var nextExp = data.GetParam(4 + i + 1);
                            GenerateSyntaxComponent(nextExp, sb, 0, false);
                            sb.AppendFormat(", {0}, {1});", typeStr, typeKind);
                        }
                        else {
                            GenerateSyntaxComponent(defVal, sb, 0, false);
                            sb.Append(";");
                        }
                    }
                    for (int i = 0; i < ct; ++i) {
                        sb.Append(" end;");
                    }
                    sb.Append(" return arr; end)()");
                }
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
                else if (id == "lock") {
                    sb.Append("do");
                }
                else if (id == "unsafe") {
                    sb.Append("do");
                }
                else if (id == "dsltoobject") {
                    sb.Append("luatoobject");
                }
                else if (id == "objecttodsl") {
                    sb.Append("objecttolua");
                }
                else if (id == "dslunpack") {
                    sb.Append("luaunpack");
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
                GenerateClosure(data, sb, indent, false);
            }
            else if (id == "foreach") {
                var param0 = fcall.GetParamId(0);
                var param1 = fcall.GetParamId(1);
                var param2 = fcall.GetParam(2);
                sb.AppendFormat("local {0} = newiterator(", param0);
                GenerateSyntaxComponent(param2, sb, indent, false);
                sb.AppendLine(");");
                sb.AppendFormat("{0}for ", GetIndentString(indent));
                sb.Append(param1);
                sb.Append(" in getiterator(");
                sb.Append(param0);
                sb.Append(") do");
                if (data.HaveStatement()) {
                    sb.AppendLine();
                    ++indent;
                    GenerateStatements(data, sb, indent);
                    --indent;
                }
                sb.AppendFormatLine("{0}end;", GetIndentString(indent));
                sb.AppendFormat("{0}recycleiterator({1})", GetIndentString(indent), param0);
            }
            else if (id == "while") {
                var condExp = fcall.GetParam(0);
                Dsl.FunctionData closure = null;
                Dsl.FunctionData oper = null;
                bool prefix = false;
                if (CanRemoveClosure(condExp, out closure) || CanSplitPrefixPostfixOperator(condExp, out oper, out prefix)) {
                    //TryGetValue这样的单一条件表达式可以转换为非匿名函数包装样式
                    sb.AppendLine("while true do");
                    ++indent;
                    if (null != closure) {
                        GenerateClosure(closure, sb, indent, true);
                        var p = closure.LowerOrderFunction.GetParam(0) as Dsl.ValueData;
                        p.SetId("false");
                    }
                    if (null != oper) {
                        sb.AppendFormat("{0}", GetIndentString(indent));
                        GeneratePrefixPostfixOperator(oper, sb, true);
                        sb.AppendLine(";");
                        var p = oper.GetParam(0) as Dsl.ValueData;
                        p.SetId("false");
                    }
                    sb.AppendFormat("{0}if not ", GetIndentString(indent));
                    GenerateSyntaxComponent(condExp, sb, 0, false);
                    sb.AppendLine(" then");
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
                var condExp = fcall.GetParam(0);
                Dsl.FunctionData closure = null;
                Dsl.FunctionData oper = null;
                bool prefix = false;
                if (CanRemoveClosure(condExp, out closure) || CanSplitPrefixPostfixOperator(condExp, out oper, out prefix)) {
                    //TryGetValue这样的单一条件表达式可以提到if语句外面
                    if (null != closure) {
                        sb.AppendLine("--");
                        GenerateClosure(closure, sb, indent, true);
                        var p = closure.LowerOrderFunction.GetParam(0) as Dsl.ValueData;
                        p.SetId("false");
                    }
                    if (null != oper) {
                        sb.AppendLine("--");
                        sb.AppendFormat("{0}", GetIndentString(indent));
                        GeneratePrefixPostfixOperator(oper, sb, true);
                        sb.AppendLine(";");
                        var p = oper.GetParam(0) as Dsl.ValueData;
                        p.SetId("false");
                    }
                    sb.AppendFormat("{0}if ", GetIndentString(indent));
                    GenerateSyntaxComponent(condExp, sb, 0, false);
                    sb.AppendLine(" then");
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
                        var condExp = fcall.GetParam(0);
                        Dsl.FunctionData closure = null;
                        Dsl.FunctionData oper = null;
                        bool prefix = false;
                        if (CanRemoveClosure(condExp, out closure) || CanSplitPrefixPostfixOperator(condExp, out oper, out prefix)) {
                            ++indent;
                            if (null != closure) {
                                GenerateClosure(closure, sb, indent, true);
                                var p = closure.LowerOrderFunction.GetParam(0) as Dsl.ValueData;
                                p.SetId("false");
                            }
                            if (null != oper) {
                                sb.AppendFormat("{0}", GetIndentString(indent));
                                GeneratePrefixPostfixOperator(oper, sb, true);
                                sb.AppendLine(";");
                                var p = oper.GetParam(0) as Dsl.ValueData;
                                p.SetId("false");
                            }
                            --indent;
                            sb.AppendFormat("{0}until not ", GetIndentString(indent));
                            GenerateSyntaxComponent(condExp, sb, 0, false);
                        }
                        else if (condExp.GetId() == "false") {
                            sb.AppendFormat("{0}until true", GetIndentString(indent));
                        }
                        else {
                            sb.AppendFormat("{0}until not ", GetIndentString(indent));
                            GenerateSyntaxComponent(condExp, sb, indent, false);
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
                var fcall = fdata.LowerOrderFunction;
                var condExp = fcall.GetParam(0);
                Dsl.FunctionData closure = null;
                Dsl.FunctionData oper = null;
                bool prefix = false;
                if (CanRemoveClosure(condExp, out closure) || CanSplitPrefixPostfixOperator(condExp, out oper, out prefix)) {
                    //TryGetValue这样的单一条件表达式可以提到if语句外面
                    if (null != closure) {
                        sb.AppendLine("--");
                        GenerateClosure(closure, sb, indent, true);
                        var p = closure.LowerOrderFunction.GetParam(0) as Dsl.ValueData;
                        p.SetId("false");
                    }
                    if (null != oper) {
                        sb.AppendLine("--");
                        sb.AppendFormat("{0}", GetIndentString(indent));
                        GeneratePrefixPostfixOperator(oper, sb, true);
                        sb.AppendLine(";");
                        var p = oper.GetParam(0) as Dsl.ValueData;
                        p.SetId("false");
                    }
                    sb.AppendFormat("{0}if ", GetIndentString(indent));
                    GenerateSyntaxComponent(condExp, sb, 0, false);
                    sb.AppendLine(" then");
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
                        if (funcData.IsHighOrder) {
                            fcd = funcData.LowerOrderFunction;
                            var elseCondExp = fcd.GetParam(0);
                            if (CanRemoveClosure(elseCondExp) || CanSplitPrefixPostfixOperator(elseCondExp)) {
                                for (int i = 0; i < ix; ++i) {
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
            else if (id == "deffunc") {
                var fdef = data;
                if (null != fdef && fdef.GetFunctionNum() == 2) {
                    var first = fdef.First;
                    var second = fdef.Second;
                    int rct;
                    int.TryParse(first.GetParamId(0), out rct);
                    if (second.HaveStatement()) {
                        var fcall = second;
                        if (second.IsHighOrder)
                            fcall = second.LowerOrderFunction;
                        sb.Append("function(");
                        bool haveParams = GenerateFunctionParams(fcall, sb);
                        sb.AppendLine(")");
                        ++indent;
                        sb.AppendFormatLine("{0}local __cs2lua_func_info = luainitialize();", GetIndentString(indent));
                        GenerateStatements(second, sb, indent);
                        bool lastIsNotReturn = true;
                        int snum = second.GetParamNum();
                        for (; snum > 0; --snum) {
                            var cid = second.GetParamId(snum - 1);
                            if (cid != "comment" && cid != "comments")
                                break;
                        }
                        if (snum > 0) {
                            lastIsNotReturn = second.GetParamId(snum - 1) != "return";
                        }
                        if (rct <= 0 && lastIsNotReturn) {
                            sb.AppendFormatLine("{0}__cs2lua_func_info = luafinalize(__cs2lua_func_info);", GetIndentString(indent));
                        }
                        --indent;
                        sb.AppendFormat("{0}end", GetIndentString(indent));
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
                GenerateStatement(comp, sb, indent);
                string subId = comp.GetId();
                if (subId != "comments" && subId != "comment") {
                    sb.AppendLine(";");
                }
                else {
                    sb.AppendLine();
                }
            }
        }
    }
}
