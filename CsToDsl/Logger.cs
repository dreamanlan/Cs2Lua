using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace RoslynTool.CsToDsl
{
    public class Logger
    {
        public bool HaveError
        {
            get {
                return m_LogBuilder.Length > 0;
            }
        }
        public string ErrorLog
        {
            get {
                return m_LogBuilder.ToString();
            }
        }
        public void ClearLog()
        {
            m_LogBuilder.Length = 0;
        }
        public void SaveLog(TextWriter writer)
        {
            writer.Write(m_LogBuilder.ToString());
        }
        public void SaveLog(string path)
        {
            File.WriteAllText(path, m_LogBuilder.ToString());
        }
        public void Log(string tag, string format, params object[] args)
        {
            m_LogBuilder.AppendFormat("<<<[Log]>>> [{0}] ", tag);
            m_LogBuilder.AppendFormat(format, args);
            m_LogBuilder.AppendLine();
        }
        public void Log(Location location, string format, params object[] args)
        {
            if (null != location) {
                m_LogBuilder.AppendFormat("<<<[Log]>>> [location: {0}] ", location.GetLineSpan());
            }
            else {
                LogCallStack("Log: location == null !");
            }
            m_LogBuilder.AppendFormat(format, args);
            m_LogBuilder.AppendLine();
        }
        public void Log(SyntaxNode node, string format, params object[] args)
        {
            if (null != node) {
                string[] lines = node.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string line = lines.Length > 0 ? lines[0] : string.Empty;
                m_LogBuilder.AppendFormat("<<<[Log for {0}]>>> [code:[ {1} ] location: {2}] ", node.GetType().Name, line, node.GetLocation().GetLineSpan());
            }
            else {
                LogCallStack("[no source info]");
            }
            m_LogBuilder.AppendFormat(format, args);
            m_LogBuilder.AppendLine();
        }
        public void ReportIllegalSymbol(SyntaxNode node, SymbolInfo symInfo)
        {
            if (null != node) {
                string[] lines = node.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string line = lines.Length > 0 ? lines[0] : string.Empty;
                m_LogBuilder.AppendFormat("<<<[Log for {0}]>>> ", node.GetType().Name);
                m_LogBuilder.AppendFormat("Can't determine symbol: {0}, code:[ {1} ] location: {2}", symInfo.CandidateReason, line, node.GetLocation().GetLineSpan());
                m_LogBuilder.AppendLine();
                foreach (var candidateSymbol in symInfo.CandidateSymbols) {
                    m_LogBuilder.AppendFormat("\tCandidateSymbol: {0}", candidateSymbol.ToString());
                    m_LogBuilder.AppendLine();
                }
            }
            else {
                LogCallStack("ReportIllegalSymbol: node == null !");
            }
        }
        public void ReportIllegalType(SyntaxNode node, ITypeSymbol typeSym)
        {
            if (null != node && null != typeSym && typeSym.TypeKind == TypeKind.Error) {
                var errType = typeSym as IErrorTypeSymbol;
                if (null != errType) {
                    string[] lines = node.ToString().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    string line = lines.Length > 0 ? lines[0] : string.Empty;
                    m_LogBuilder.AppendFormat("<<<[Log for {0}]>>> ", node.GetType().Name);
                    m_LogBuilder.AppendFormat("Error type: {0}, code:[ {1} ] location: {2}", errType.ToString(), line, node.GetLocation().GetLineSpan());
                    m_LogBuilder.AppendLine();
                    foreach (var candidateSymbol in errType.CandidateSymbols) {
                        m_LogBuilder.AppendFormat("\tCandidateSymbol: {0}", candidateSymbol.ToString());
                        m_LogBuilder.AppendLine();
                    }
                }
            }
            else {
                LogCallStack("ReportIllegalType: node == null || typeSym == null || typeSym.TypeKind != TypeKind.Error !");
            }
        }
        public void ReportIllegalType(ISymbol sym)
        {
            var typeSym = sym as ITypeSymbol;
            if (null != typeSym && typeSym.TypeKind == TypeKind.Error) {
                var errType = typeSym as IErrorTypeSymbol;
                if (null != errType) {
                    m_LogBuilder.AppendFormat("<<<[Log]>>> Error type: {0}", errType.ToString());
                    foreach (var location in errType.Locations) {
                        m_LogBuilder.AppendFormat("\tlocation: {0}", location.GetLineSpan());
                    }
                    m_LogBuilder.AppendLine();
                    foreach (var candidateSymbol in errType.CandidateSymbols) {
                        m_LogBuilder.AppendFormat("\tCandidateSymbol: {0}", candidateSymbol.ToString());
                        m_LogBuilder.AppendLine();
                    }
                }
                return;
            }
            if (null != sym) {
                m_LogBuilder.AppendFormat("ErrorSymbol: {0} type:{1}", sym.ToString(), sym.Kind);
                m_LogBuilder.AppendLine();
            }
            else {
                LogCallStack("ReportIllegalType: sym == null !");
            }
        }
        public void LogCallStack(string format, params object[] args)
        {
            m_LogBuilder.AppendFormat(format, args);
            m_LogBuilder.AppendLine();
            m_LogBuilder.Append(System.Environment.StackTrace);
        }

        private StringBuilder m_LogBuilder = new StringBuilder();

        internal static Logger Instance
        {
            get {
                return s_Instance;
            }
        }
        private static Logger s_Instance = new Logger();
    }
}
