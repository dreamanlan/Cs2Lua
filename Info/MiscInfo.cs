using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Operations;

namespace RoslynTool.CsToDsl
{
    internal class ContinueInfo
    {
        internal bool IsLoop = false;
        internal bool IsIgnoreBreak = false;
        internal bool HaveContinue = false;
        internal bool HaveBreak = false;
        internal string BreakFlagVarName = string.Empty;

        internal void Init(SwitchSectionSyntax syntax)
        {
            IsLoop = false;
            IsIgnoreBreak = false;
            HaveContinue = false;
            HaveBreak = true;
            BreakFlagVarName = string.Empty;
        }
        internal void Init(StatementSyntax syntax)
        {
            IsLoop = true;
            IsIgnoreBreak = false;
            ContinueAnalysis cont = new ContinueAnalysis();
            cont.Visit(syntax);
            HaveContinue = cont.ContinueCount > 0;
            HaveBreak = cont.BreakCount > 0;
            BreakFlagVarName = string.Format("__continue_{0}", CsDslTranslater.GetSourcePosForVar(syntax));
        }
    }
    internal class SwitchInfo
    {
        internal string SwitchVarName = string.Empty;
    }
    internal class MergedNamespaceInfo
    {
        internal string Name = string.Empty;
        internal Dictionary<string, MergedNamespaceInfo> Namespaces = new Dictionary<string, MergedNamespaceInfo>();
    }
    internal class MergedClassInfo
    {
        internal string Key = string.Empty;
        internal List<ClassInfo> Classes = new List<ClassInfo>();
        internal Dictionary<string, List<string>> InnerInterfaces = new Dictionary<string, List<string>>();
        internal Dictionary<string, MergedClassInfo> InnerClasses = new Dictionary<string, MergedClassInfo>();
    }
}