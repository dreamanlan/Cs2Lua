using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LuaGenerator
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
            } else if (!Path.IsPathRooted(outPath)) {
                outPath = Path.Combine(csprojPath, outPath);
            }

            s_ExePath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            s_SrcPath = Path.Combine(csprojPath, "dsl");
            s_OutPath = outPath;
            s_Ext = ext;
            File.Copy(Path.Combine(s_ExePath, "lualib/utility.lua"), Path.Combine(s_OutPath, "cs2lua__utility." + s_Ext), true);
            var files = Directory.GetFiles(s_SrcPath, "*.dsl", SearchOption.TopDirectoryOnly);
            foreach (string file in files) {
                try {
                    string fileName = Path.GetFileName(file);

                    Dsl.DslFile dslFile = new Dsl.DslFile();
                    dslFile.Load(file, s => Log(file, s));
                    GenerateLua(dslFile, Path.Combine(s_OutPath, Path.ChangeExtension(fileName, s_Ext)));
                } catch (Exception ex) {
                    Log(file, string.Format("exception:{0}\n{1}", ex.Message, ex.StackTrace));
                    System.Environment.Exit(-1);
                }
            }
            System.Environment.Exit(0);
        }
        private static void GenerateLua(Dsl.DslFile dslFile, string outputFile)
        {
            StringBuilder sb = new StringBuilder();
            Stack<string> classDefineStack = new Stack<string>();
            string prestr = string.Empty;
            int indent = 0;
            bool firstAttrs = true;
            foreach (var dslInfo in dslFile.DslInfos) {
                string id = dslInfo.GetId();
                var funcData = dslInfo.First;
                var callData = funcData.Call;
                if (id == "require") {
                    string requireFileName = callData.GetParamId(0);
                    string srcPath = Path.Combine(s_ExePath, string.Format("lualib/{0}.lua", requireFileName));
                    string destPath = Path.Combine(s_OutPath, string.Format("{0}.{1}", requireFileName, s_Ext));
                    if (!File.Exists(destPath) && File.Exists(srcPath)) {
                        File.Copy(srcPath, destPath, true);
                    }
                    sb.AppendFormatLine("{0}require \"{1}\";", GetIndentString(indent), requireFileName);
                } else if (id == "attributes") {
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
                } else if (id == "namespace") {
                    string ns = CalcTypeString(callData.GetParam(0));
                    sb.AppendFormatLine("{0}{1} = {1} or {{}};", GetIndentString(indent), ns, ns);
                } else if (id == "interface") {
                    string intfName = CalcTypeString(callData.GetParam(0));
                    sb.AppendFormatLine("{0}{1} = {{", GetIndentString(indent), intfName);
                    ++indent;
                    sb.AppendFormatLine("{0}__cs2lua_defined = true, ", GetIndentString(indent));
                    sb.AppendFormatLine("{0}__type_name = \"{1}\", ", GetIndentString(indent), intfName);
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
                } else if (id == "defineentry") {
                    string className = CalcTypeString(callData.GetParam(0));
                    sb.AppendFormatLine("{0}defineentry({1});", GetIndentString(indent), className);
                } else if (id == "enum") {
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
                } else if (id == "class" || id == "struct") {
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
                                    sb.AppendFormat("{0}{1} = {2}(", GetIndentString(indent), mname, fcall.GetId());
                                    prestr = string.Empty;
                                    for (int ix = 0; ix < fcall.Params.Count; ++ix) {
                                        var param = fcall.Params[ix];
                                        sb.Append(prestr);
                                        prestr = ", ";
                                        var pv = param as Dsl.ValueData;
                                        if (null != pv) {
                                            sb.Append(pv.GetId());
                                        } else {
                                            var pc = param as Dsl.CallData;
                                            if (null != pc) {
                                                sb.Append(pc.GetParamId(0));
                                            }
                                        }
                                    }
                                    sb.AppendLine(")");
                                    ++indent;
                                    foreach (var comp in fdef.Statements) {
                                        GenerateSyntaxComponent(comp, sb, indent, true);
                                        string subId = comp.GetId();
                                        if (subId != "comments" && subId != "comment") {
                                            sb.AppendLine(";");
                                        } else {
                                            sb.AppendLine();
                                        }
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
                                    sb.AppendFormat("{0}{1} = {2}(", GetIndentString(indent), mname, fcall.GetId());
                                    prestr = string.Empty;
                                    for (int ix = 0; ix < fcall.Params.Count; ++ix) {
                                        var param = fcall.Params[ix];
                                        sb.Append(prestr);
                                        prestr = ", ";
                                        var pv = param as Dsl.ValueData;
                                        if (null != pv) {
                                            sb.Append(pv.GetId());
                                        } else {
                                            var pc = param as Dsl.CallData;
                                            if (null != pc) {
                                                sb.Append(pc.GetParamId(0));
                                            }
                                        }
                                    }
                                    sb.AppendLine(")");
                                    ++indent;
                                    foreach (var comp in fdef.Statements) {
                                        GenerateSyntaxComponent(comp, sb, indent, true);
                                        string subId = comp.GetId();
                                        if (subId != "comments" && subId != "comment") {
                                            sb.AppendLine(";");
                                        } else {
                                            sb.AppendLine();
                                        }
                                    }
                                    --indent;
                                    sb.AppendFormatLine("{0}end,", GetIndentString(indent));
                                } else {
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
                    } else {
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
                    } else {
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
                                    sb.AppendFormat("{0}{1} = {2}(", GetIndentString(indent), mname, fcall.GetId());
                                    prestr = string.Empty;
                                    for (int ix = 0; ix < fcall.Params.Count;++ix ) {
                                        var param = fcall.Params[ix];
                                        string paramId = param.GetId();
                                        sb.Append(prestr);
                                        prestr = ", ";
                                        var pv = param as Dsl.ValueData;
                                        if (null != pv) {
                                            sb.Append(paramId);
                                        } else {
                                            var pc = param as Dsl.CallData;
                                            if (null != pc) {
                                                sb.Append(pc.GetParamId(0));
                                            }
                                        }
                                    }
                                    sb.AppendLine(")");
                                    ++indent;
                                    foreach (var comp in fdef.Statements) {
                                        GenerateSyntaxComponent(comp, sb, indent, true);
                                        string subId = comp.GetId();
                                        if (subId != "comments" && subId != "comment") {
                                            sb.AppendLine(";");
                                        } else {
                                            sb.AppendLine();
                                        }
                                    }
                                    --indent;
                                    sb.AppendFormatLine("{0}end,", GetIndentString(indent));
                                } else {
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
                    } else {
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
                    } else {
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
                    } else {
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
                    } else {
                        sb.AppendFormatLine("{0}local interface_map = nil;", GetIndentString(indent));
                    }

                    sb.AppendLine();

                    sb.AppendFormatLine("{0}return defineclass({1}, \"{2}\", static, static_methods, static_fields_build, static_props, static_events, instance_methods, instance_fields_build, instance_props, instance_events, interfaces, interface_map, {3});", GetIndentString(indent), null == baseClass ? "nil" : baseClassName, className, isValueType ? "true" : "false");

                    --indent;
                    sb.AppendFormatLine("{0}end,", GetIndentString(indent));
                    --indent;
                    sb.AppendFormatLine("{0}}};", GetIndentString(indent));
                    classDefineStack.Push(className);
                }
            }
            sb.AppendLine();
            while (classDefineStack.Count > 0) {
                var className = classDefineStack.Pop();
                sb.AppendFormatLine("{0}{1}.__define_class();", GetIndentString(indent), className);
            }
            File.WriteAllText(outputFile, sb.ToString());
        }
        private static void GenerateFieldValueComponent(Dsl.ISyntaxComponent comp, StringBuilder sb, int indent, bool firstLineUseIndent)
        {
            var valData = comp as Dsl.ValueData;
            if (null != valData) {
                GenerateConcreteSyntax(valData, sb, indent, firstLineUseIndent, true);
            } else {
                var callData = comp as Dsl.CallData;
                if (null != callData) {
                    GenerateConcreteSyntax(callData, sb, indent, firstLineUseIndent);
                } else {
                    var funcData = comp as Dsl.FunctionData;
                    if (null != funcData) {
                        GenerateConcreteSyntax(funcData, sb, indent, firstLineUseIndent);
                    } else {
                        var statementData = comp as Dsl.StatementData;
                        GenerateConcreteSyntax(statementData, sb, indent, firstLineUseIndent);
                    }
                }
            }
        }
        private static void GenerateSyntaxComponent(Dsl.ISyntaxComponent comp, StringBuilder sb, int indent, bool firstLineUseIndent)
        {
            var valData = comp as Dsl.ValueData;
            if (null != valData) {
                GenerateConcreteSyntax(valData, sb, indent, firstLineUseIndent);
            } else {
                var callData = comp as Dsl.CallData;
                if (null != callData) {
                    GenerateConcreteSyntax(callData, sb, indent, firstLineUseIndent);
                } else {
                    var funcData = comp as Dsl.FunctionData;
                    if (null != funcData) {
                        GenerateConcreteSyntax(funcData, sb, indent, firstLineUseIndent);
                    } else {
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
                } else if (paramNum == 2) {
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
                            } else {
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
            } else if (id == "comment") {
                sb.AppendFormat("--{0}", data.GetParamId(0));
            } else if (id == "local") {
                sb.Append("local ");
                string prestr = string.Empty;
                foreach (var param in data.Params) {
                    sb.Append(prestr);
                    GenerateSyntaxComponent(param, sb, indent, false);
                    prestr = ", ";
                }
            } else if (id == "ref" || id == "out") {
                var param = data.GetParam(0);
                GenerateSyntaxComponent(param, sb, indent, false);
            } else if (id == "return") {
                sb.Append("return ");
                string prestr = string.Empty;
                foreach (var param in data.Params) {
                    sb.Append(prestr);
                    GenerateSyntaxComponent(param, sb, indent, false);
                    prestr = ", ";
                }
            } else if (id == "execunary") {
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
                    sb.AppendFormat("invokeintegeroperator({0}, \"{1}\", ", intOpIndex, intOp);
                    GenerateSyntaxComponent(p1, sb, indent, false);
                    sb.AppendFormat(", 1, {0}, {1})", type1, type1);
                } else {
                    string functor;
                    if (s_UnaryFunctor.TryGetValue(op, out functor)) {
                        sb.AppendFormat("{0}(", functor);
                        GenerateSyntaxComponent(data.GetParam(1), sb, indent, false);
                        sb.Append(")");
                    } else {
                        op = ConvertOperator(op);
                        sb.AppendFormat("({0} ", op);
                        GenerateSyntaxComponent(data.GetParam(1), sb, indent, false);
                        sb.Append(")");
                    }
                }
            } else if (id == "execbinary") {
                string op = data.GetParamId(0);
                var p1 = data.GetParam(1);
                var p2 = data.GetParam(2);
                string type1 = CalcTypeString(data.GetParam(3));
                string type2 = CalcTypeString(data.GetParam(4));
                string typeKind1 = CalcTypeString(data.GetParam(5));
                string typeKind2 = CalcTypeString(data.GetParam(6));
                int intOpIndex;
                if (IsIntegerType(type1, typeKind1) && IsIntegerType(type2, typeKind2) && TryGetSpecialIntegerOperatorIndex(op, out intOpIndex)) {
                    sb.AppendFormat("invokeintegeroperator({0}, \"{1}\", ", intOpIndex, op);
                    GenerateSyntaxComponent(p1, sb, indent, false);
                    sb.Append(", ");
                    GenerateSyntaxComponent(p2, sb, indent, false);
                    sb.AppendFormat(", {0}, {1})", type1, type2);
                } else if (op == "+" && (type1 == "System.String" || type2 == "System.String")) {
                    bool tostr1 = type1 != "System.String";
                    bool tostr2 = type2 != "System.String";
                    sb.Append("System.String.Concat(");
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
                } else if ((op == "==" || op == "!=") && !IsBasicType(type1, typeKind1, true) && !IsBasicType(type2, typeKind2, true)) {
                    if (op == "==") {
                        sb.Append("isequal(");
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.Append(", ");
                        GenerateSyntaxComponent(p2, sb, indent, false);
                        sb.Append(")");
                    } else {
                        sb.Append("(not isequal(");
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.Append(", ");
                        GenerateSyntaxComponent(p2, sb, indent, false);
                        sb.Append("))");
                    }
                } else {
                    string functor;
                    if (s_BinaryFunctor.TryGetValue(op, out functor)) {
                        sb.AppendFormat("{0}(", functor);
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.Append(", ");
                        GenerateSyntaxComponent(p2, sb, indent, false);
                        sb.Append(")");
                    } else {
                        op = ConvertOperator(op);
                        sb.Append("(");
                        GenerateSyntaxComponent(p1, sb, indent, false);
                        sb.AppendFormat(" {0} ", op);
                        GenerateSyntaxComponent(p2, sb, indent, false);
                        sb.Append(")");
                    }
                }
            } else if (id == "invokeexternoperator") {
                string method = data.GetParamId(1);
                string luaOp = string.Empty;
                //slua导出时把重载操作符导出成lua实例方法了，然后利用lua实例上支持的操作符元方法在运行时绑定到重载实现
                //这里把lua支持的操作符方法转成lua操作（可能比invokeexternoperator要快一些）
                if (method == "op_Addition") {
                    luaOp = "+";
                } else if (method == "op_Subtraction") {
                    luaOp = "-";
                } else if (method == "op_Multiply") {
                    luaOp = "*";
                } else if (method == "op_Division") {
                    luaOp = "/";
                } else if (method == "op_UnaryNegation") {
                    luaOp = "-";
                } else if (method == "op_UnaryPlus") {
                    luaOp = "+";
                } else if (method == "op_LessThan") {
                    luaOp = "<";
                } else if (method == "op_GreaterThan") {
                    luaOp = ">";
                } else if (method == "op_LessThanOrEqual") {
                    luaOp = "<=";
                } else if (method == "op_GreaterThanOrEqual") {
                    luaOp = ">= ";
                }
                if (string.IsNullOrEmpty(luaOp)) {
                    sb.Append(id);
                    sb.Append("(");
                    string prestr = string.Empty;
                    for (int ix = 0; ix < data.Params.Count; ++ix) {
                        var param = data.Params[ix];
                        sb.Append(prestr);
                        string paramId = param.GetId();
                        if (paramId == "...") {
                            sb.Append("...");
                            continue;
                        }
                        GenerateSyntaxComponent(param, sb, indent, false);
                        prestr = ", ";
                    }
                    sb.Append(")");
                } else if (data.GetParamNum() == 3 && luaOp == "-") {
                    sb.Append("(- ");
                    var param0 = data.GetParam(2);
                    GenerateSyntaxComponent(param0, sb, indent, false);
                    sb.Append(")");
                } else if (data.GetParamNum() == 4) {
                    sb.Append("(");
                    var param0 = data.GetParam(2);
                    var param1 = data.GetParam(3);
                    GenerateSyntaxComponent(param0, sb, indent, false);
                    sb.AppendFormat(" {0} ", luaOp);
                    GenerateSyntaxComponent(param1, sb, indent, false);
                    sb.Append(")");
                }
            } else if (id == "getstatic") {
                var obj = data.Params[0];
                var member = data.Params[1];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
            } else if (id == "getinstance") {
                var obj = data.Params[0];
                var member = data.Params[1];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
            } else if (id == "setstatic") {
                var obj = data.Params[0];
                var member = data.Params[1];
                var val = data.Params[2];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
                sb.Append(" = ");
                GenerateSyntaxComponent(val, sb, indent, false);
            } else if (id == "setinstance") {
                var obj = data.Params[0];
                var member = data.Params[1];
                var val = data.Params[2];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
                sb.Append(" = ");
                GenerateSyntaxComponent(val, sb, indent, false);
            } else if (id == "callstatic") {
                var obj = data.Params[0];
                var member = data.Params[1];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(".{0}", member.GetId());
                sb.Append("(");
                string prestr = string.Empty;
                for (int ix = 2; ix < data.Params.Count; ++ix) {
                    var param = data.Params[ix];
                    sb.Append(prestr);
                    string paramId = param.GetId();
                    if (paramId == "...") {
                        sb.Append("...");
                        continue;
                    }
                    GenerateSyntaxComponent(param, sb, indent, false);
                    prestr = ", ";
                }
                sb.Append(")");
            } else if (id == "callinstance") {
                var obj = data.Params[0];
                var member = data.Params[1];
                GenerateSyntaxComponent(obj, sb, indent, false);
                sb.AppendFormat(":{0}", member.GetId());
                sb.Append("(");
                string prestr = string.Empty;
                for (int ix = 2; ix < data.Params.Count; ++ix) {
                    var param = data.Params[ix];
                    sb.Append(prestr);
                    string paramId = param.GetId();
                    if (paramId == "...") {
                        sb.Append("...");
                        continue;
                    }
                    GenerateSyntaxComponent(param, sb, indent, false);
                    prestr = ", ";
                }
                sb.Append(")");
            } else if (id == "typeof") {
                var typeStr = CalcTypeString(data.GetParam(0));
                sb.AppendFormat("{0}", typeStr);
            } else if (id == "params") {
                int num = data.GetParamNum();
                if (num == 0) {
                    sb.Append("{...}");
                } else if (num == 1) {
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
                } else {
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
            } else if (id == "paramsremove") {
                sb.AppendFormat("table.remove({0})", data.GetParamId(0));
            } else if (id == "typeargs") {
                sb.Append("{");
                string prestr = string.Empty;
                for (int ix = 0; ix < data.Params.Count; ++ix) {
                    var param = data.Params[ix];
                    sb.Append(prestr);
                    GenerateSyntaxComponent(param, sb, indent, false);
                    prestr = ", ";
                }
                sb.Append("}");
            } else if (id == "typekinds") {
                sb.Append("{");
                string prestr = string.Empty;
                for (int ix = 0; ix < data.Params.Count; ++ix) {
                    var param = data.Params[ix];
                    sb.Append(prestr);
                    GenerateSyntaxComponent(param, sb, indent, false);
                    prestr = ", ";
                }
                sb.Append("}");
            } else if (id == "initdelegation") {
                sb.Append("wrapdelegation{}");
            } else if (id == "builddelegation") {
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
                } else {
                    sb.Append(":");
                }
                sb.Append(methodName);
                sb.AppendFormatLine("({0});", paramsString);
                --indent;
                sb.AppendFormatLine("{0}end);", GetIndentString(indent));
                sb.AppendFormat("{0}", GetIndentString(indent));
                sb.AppendFormatLine("setdelegationkey({0}, \"{1}\", {2}, {3}.{4});", varName, delegationKey, objOrClassName, objOrClassName, methodName);
                sb.AppendFormat("{0}return {1}", GetIndentString(indent), varName);
            } else if (id == "anonymousobject") {
                sb.Append("wrapdictionary{");
                string prestr = string.Empty;
                for (int ix = 0; ix < data.Params.Count; ++ix) {
                    var param = data.Params[ix];
                    sb.Append(prestr);
                    GenerateSyntaxComponent(param, sb, indent, false);
                    prestr = ", ";
                }
                sb.Append("}");
            } else if (id == "builddictionary") {
                sb.Append("{");
                string prestr = string.Empty;
                for (int ix = 0; ix < data.Params.Count; ++ix) {
                    var param = data.Params[ix] as Dsl.CallData;
                    sb.Append(prestr);
                    var k = param.GetParamId(0);
                    var v = param.GetParam(1);
                    sb.AppendFormat("[\"{0}\"] = ", Escape(k));
                    GenerateSyntaxComponent(v, sb, indent, false);
                    prestr = ", ";
                }
                sb.Append("}");
            } else if (id == "buildlist" || id == "buildcollection" || id == "buildcomplex" || id == "buildobject") {
                sb.Append("{");
                string prestr = string.Empty;
                for (int ix = 0; ix < data.Params.Count; ++ix) {
                    var param = data.Params[ix];
                    sb.Append(prestr);
                    GenerateSyntaxComponent(param, sb, indent, false);
                    prestr = ", ";
                }
                sb.Append("}");
            } else if (id == "buildarray") {
                sb.Append("wraparray({");
                string prestr = string.Empty;
                for (int ix = 0; ix < data.Params.Count; ++ix) {
                    var param = data.Params[ix];
                    sb.Append(prestr);
                    GenerateSyntaxComponent(param, sb, indent, false);
                    prestr = ", ";
                }
                sb.Append("})");
            } else if (id == "initarray") {
                if (data.GetParamNum() > 0) {
                    var vname = data.GetParamId(0);
                    sb.AppendFormat("wraparray({{}}, {0})", vname);
                } else {
                    sb.Append("wraparray{}");
                }
            } else if (id == "foreach") {
                sb.Append("for ");
                var param1 = data.GetParamId(0);
                sb.Append(param1);
                sb.Append(" in ");
                var param2 = data.GetParam(1);
                GenerateSyntaxComponent(param2, sb, indent, false);
                sb.Append(" do");
            } else if (id == "for") {
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
            } else {
                if (null != callData) {
                    GenerateSyntaxComponent(callData, sb, indent, false);
                } else if (id == "if") {
                    sb.Append("if ");
                } else if (id == "elseif") {
                    sb.Append("elseif ");
                } else if (id == "while") {
                    sb.Append("while ");
                } else if (id == "until") {
                    sb.Append("until ");
                } else if (id == "block") {
                    sb.Append("do");
                } else if (id == "dsltry") {
                    sb.Append("luatry");
                } else if (id == "dslcatch") {
                    sb.Append("luacatch");
                } else if (id == "dslthrow") {
                    sb.Append("luathrow");
                } else {
                    sb.Append(id);
                }
                if (data.HaveParam()) {
                    if (id == "if" || id == "elseif" || id == "while" || id == "until") {
                    } else {
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
                        string prestr = string.Empty;
                        for (int ix = 0; ix < data.Params.Count; ++ix) {
                            var param = data.Params[ix];
                            sb.Append(prestr);
                            string paramId = param.GetId();
                            if (paramId == "...") {
                                sb.Append("...");
                                continue;
                            }
                            GenerateSyntaxComponent(param, sb, indent, false);
                            prestr = ", ";
                        }
                    }
                    if (id == "if" || id == "elseif" || id == "while" || id == "until") {
                    } else {
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
                    } else if (id == "while") {
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
            } else if (id == "local") {
                bool first = true;
                foreach (var comp in data.Statements) {
                    if (!first) {
                        sb.AppendLine(";");
                    } else {
                        first = false;
                    }
                    sb.Append("local ");
                    GenerateSyntaxComponent(comp, sb, indent, false);
                }
            } else {
                GenerateConcreteSyntax(fcall, sb, indent, false);
                if (data.HaveStatement()) {
                    sb.AppendLine();
                    ++indent;
                    foreach (var comp in data.Statements) {
                        GenerateSyntaxComponent(comp, sb, indent, true);
                        string subId = comp.GetId();
                        if (subId != "comments" && subId != "comment") {
                            sb.AppendLine(";");
                        } else {
                            sb.AppendLine();
                        }
                    }
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
                    if (linqId=="linq") {
                        sb.Append("LINQ.exec({");
                    } else if (linqId == "end") {
                        sb.Append("})");
                    } else {
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
            } else if (id == "do") {
                foreach (var funcData in data.Functions) {
                    var fcall = funcData.Call;
                    if (funcData == data.First) {
                        if (firstLineUseIndent) {
                            sb.AppendLine("repeat");
                        } else {
                            sb.AppendFormatLine("{0}repeat", GetIndentString(indent));
                        }
                    } else if (funcData == data.Second) {
                        var param0 = fcall.GetParam(0);
                        if (param0.GetId() == "false") {
                            sb.AppendFormat("{0}until true", GetIndentString(indent));
                        } else {
                            sb.AppendFormat("{0}until not (", GetIndentString(indent));
                            GenerateSyntaxComponent(param0, sb, indent, false);
                            sb.Append(")");
                        }
                    }
                    if (funcData.HaveStatement()) {
                        sb.AppendLine();
                        ++indent;
                        foreach (var comp in funcData.Statements) {
                            GenerateSyntaxComponent(comp, sb, indent, true);
                            string subId = comp.GetId();
                            if (subId != "comments" && subId != "comment") {
                                sb.AppendLine(";");
                            } else {
                                sb.AppendLine();
                            }
                        }
                        --indent;
                        if (funcData == data.Last) {
                            sb.AppendFormat("{0}end", GetIndentString(indent));
                        }
                    } else {
                        sb.Append(" ");
                    }
                }
            } else {
                foreach (var funcData in data.Functions) {
                    var fcall = funcData.Call;
                    GenerateConcreteSyntax(fcall, sb, indent, funcData == data.First ? false : true);
                    if (funcData.HaveStatement()) {
                        sb.AppendLine();
                        ++indent;
                        foreach (var comp in funcData.Statements) {
                            GenerateSyntaxComponent(comp, sb, indent, true);
                            string subId = comp.GetId();
                            if (subId != "comments" && subId != "comment") {
                                sb.AppendLine(";");
                            } else {
                                sb.AppendLine();
                            }
                        }
                        --indent;
                        if (funcData == data.Last) {
                            sb.AppendFormat("{0}end", GetIndentString(indent));
                        }
                    } else {
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
                } else {
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
        private static string CalcTypeString(Dsl.ISyntaxComponent comp)
        {
            string ret = comp.GetId();
            var cd = comp as Dsl.CallData;
            if (null != cd && cd.GetParamClass() == (int)Dsl.CallData.ParamClassEnum.PARAM_CLASS_PERIOD) {
                string prefix;
                if (cd.IsHighOrder) {
                    prefix = CalcTypeString(cd.Call);
                } else {
                    prefix = cd.GetId();
                }
                ret = prefix + "." + cd.GetParamId(0);
            }
            return ret;
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
        private static string ConvertOperator(string id)
        {
            if (id == "!=") {
                id = "~=";
            } else if (id == "&&") {
                id = "and";
            } else if (id == "||") {
                id = "or";
            } else if (id == "!") {
                id = "not";
            }
            return id;
        }
        private static void Log(string file, string msg)
        {
            Console.WriteLine("[{0}]:{1}", file, msg);
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

        private static string s_ExePath = string.Empty;
        private static string s_SrcPath = string.Empty;
        private static string s_OutPath = string.Empty;
        private static string s_Ext = string.Empty;
        //下面这个list的顺序要与utility.lua里的整数操作表__cs2lua_special_integer_operators一致（索引用作操作符识别常量）
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
    }
}
