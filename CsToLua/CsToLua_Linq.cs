using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Semantics;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace RoslynTool.CsToLua
{
    internal partial class CsLuaTranslater
    {
        /// <remarks>
        /// lua实现的LINQ类里的所有lambda函数参数都是按顺序生成的，这里假定LINQ类内部有一个与这里翻译时相似的参数名栈与参数名列表
        /// ，计算到某步时，当前的参数名列表就是接下来调用lambda函数的参数顺序（值按参数名产生的顺序与参数名对应）。
        /// 规则：from/let/join/into子句产生参数名，其中join带的into会覆盖join引入的参数，groupby带的into会清空之前的所有参数。
        /// 注意，LINQ类处理参数的方式与LINQ的查询方法是不一样的，事实上LINQ类的引入是为了简化LINQ语法的翻译（翻译到LINQ查询方
        /// 法的难度要比借助LINQ类实现LINQ功能大很多）。
        /// </remarks>
        public override void VisitQueryExpression(QueryExpressionSyntax node)
        {
            if (!m_EnableLinq) {
                Log(node, "Cs2Lua can't support LINQ, use -enablelinq remove this error! (c# LINQ syntax will translate to use lua LINQ class in utility.lua)");
            }

            m_LinqParamInfoStack.Push(new LinqParamInfo());

            CodeBuilder.Append("LINQ.exec({");
            node.FromClause.Accept(this);
            node.Body.Accept(this);
            CodeBuilder.Append("})");

            m_LinqParamInfoStack.Pop();
        }
        public override void VisitQueryBody(QueryBodySyntax node)
        {
            base.VisitQueryBody(node);
        }
        public override void VisitFromClause(FromClauseSyntax node)
        {
            var paramInfo = m_LinqParamInfoStack.Peek();
            var paramNames = paramInfo.ParamNames;
            string prestr = paramInfo.Prestr;
            paramInfo.Prestr = ", ";

            CodeBuilder.AppendFormat("{0}{{\"from\", (function({1}) return ", prestr, string.Join(", ", paramNames.ToArray()));
            var opd = m_Model.GetOperation(node.Expression) as IConversionExpression;
            OutputExpressionSyntax(node.Expression, opd);
            CodeBuilder.Append("; end)}");

            paramNames.Add(node.Identifier.Text);
        }
        public override void VisitLetClause(LetClauseSyntax node)
        {
            var paramInfo = m_LinqParamInfoStack.Peek();
            var paramNames = paramInfo.ParamNames;
            string prestr = paramInfo.Prestr;
            paramInfo.Prestr = ", ";

            CodeBuilder.AppendFormat("{0}{{\"let\", (function({1}) return ", prestr, string.Join(", ", paramNames.ToArray()));
            var opd = m_Model.GetOperation(node.Expression) as IConversionExpression;
            OutputExpressionSyntax(node.Expression, opd);
            CodeBuilder.Append("; end)}");

            paramNames.Add(node.Identifier.Text);
        }
        public override void VisitJoinClause(JoinClauseSyntax node)
        {
            var paramInfo = m_LinqParamInfoStack.Peek();
            var paramNames = paramInfo.ParamNames;
            string prestr = paramInfo.Prestr;
            paramInfo.Prestr = ", ";

            CodeBuilder.AppendFormat("{0}{{\"join\", (function({1}) return ", prestr, string.Join(", ", paramNames.ToArray()));            
            var opd = m_Model.GetOperation(node.InExpression) as IConversionExpression;
            OutputExpressionSyntax(node.InExpression, opd);
            CodeBuilder.Append("; end), ");

            paramInfo.JoinParamName = node.Identifier.Text;
            paramNames.Add(paramInfo.JoinParamName);

            CodeBuilder.AppendFormat("(function({0}) return ", string.Join(", ", paramNames.ToArray()));
            var opdl = m_Model.GetOperation(node.LeftExpression) as IConversionExpression;
            OutputExpressionSyntax(node.LeftExpression, opdl);
            CodeBuilder.Append("; end), ");

            CodeBuilder.AppendFormat("(function({0}) return ", string.Join(", ", paramNames.ToArray()));
            var opdr = m_Model.GetOperation(node.RightExpression) as IConversionExpression;
            OutputExpressionSyntax(node.RightExpression, opdr);
            CodeBuilder.Append("; end)}");

            if (null != node.Into) {
                VisitJoinIntoClause(node.Into);
            }
        }
        public override void VisitJoinIntoClause(JoinIntoClauseSyntax node)
        {
            var paramInfo = m_LinqParamInfoStack.Peek();
            var paramNames = paramInfo.ParamNames;
            string prestr = paramInfo.Prestr;
            paramInfo.Prestr = ", ";

            paramNames.Remove(paramInfo.JoinParamName);
            paramNames.Add(node.Identifier.Text);
            
            CodeBuilder.AppendFormat("{0}{{\"into\"}}", prestr);
        }
        public override void VisitWhereClause(WhereClauseSyntax node)
        {
            var paramInfo = m_LinqParamInfoStack.Peek();
            var paramNames = paramInfo.ParamNames;
            string prestr = paramInfo.Prestr;
            paramInfo.Prestr = ", ";

            CodeBuilder.AppendFormat("{0}{{\"where\", (function({1}) return ", prestr, string.Join(", ", paramNames.ToArray()));
            var opd = m_Model.GetOperation(node.Condition) as IConversionExpression;
            OutputExpressionSyntax(node.Condition, opd);
            CodeBuilder.Append("; end)}");
        }
        public override void VisitOrderByClause(OrderByClauseSyntax node)
        {
            var paramInfo = m_LinqParamInfoStack.Peek();
            var paramNames = paramInfo.ParamNames;
            string prestr = paramInfo.Prestr;
            paramInfo.Prestr = ", ";
            paramInfo.OrderByPrestr = string.Empty;

            CodeBuilder.AppendFormat("{0}{{\"orderby\", {{", prestr);
            base.VisitOrderByClause(node);
            CodeBuilder.Append("}}");
        }
        public override void VisitOrdering(OrderingSyntax node)
        {
            var paramInfo = m_LinqParamInfoStack.Peek();
            var paramNames = paramInfo.ParamNames;
            string prestr = paramInfo.OrderByPrestr;
            paramInfo.OrderByPrestr = ", ";

            CodeBuilder.AppendFormat("{0}{{(function({1}) return ", prestr, string.Join(", ", paramNames.ToArray()));
            var opd = m_Model.GetOperation(node.Expression) as IConversionExpression;
            OutputExpressionSyntax(node.Expression, opd);
            CodeBuilder.AppendFormat("; end), {0}}}", node.AscendingOrDescendingKeyword.Text != "descending" ? "true" : "false");
        }
        public override void VisitSelectClause(SelectClauseSyntax node)
        {
            var paramInfo = m_LinqParamInfoStack.Peek();
            var paramNames = paramInfo.ParamNames;
            string prestr = paramInfo.Prestr;
            paramInfo.Prestr = ", ";

            CodeBuilder.AppendFormat("{0}{{\"select\", (function({1}) return ", prestr, string.Join(", ", paramNames.ToArray()));
            var opd = m_Model.GetOperation(node.Expression) as IConversionExpression;
            OutputExpressionSyntax(node.Expression, opd);
            CodeBuilder.Append("; end)}");
        }
        public override void VisitGroupClause(GroupClauseSyntax node)
        {
            var paramInfo = m_LinqParamInfoStack.Peek();
            var paramNames = paramInfo.ParamNames;
            string prestr = paramInfo.Prestr;
            paramInfo.Prestr = ", ";

            CodeBuilder.AppendFormat("{0}{{\"groupby\", (function({1}) return ", prestr, string.Join(", ", paramNames.ToArray()));
            var opdGroup = m_Model.GetOperation(node.GroupExpression) as IConversionExpression;
            OutputExpressionSyntax(node.GroupExpression, opdGroup);
            CodeBuilder.Append("; end), ");

            CodeBuilder.AppendFormat("(function({0}) return ", string.Join(", ", paramNames.ToArray()));
            var opdBy = m_Model.GetOperation(node.ByExpression) as IConversionExpression;
            OutputExpressionSyntax(node.ByExpression, opdBy);
            CodeBuilder.Append("; end)}");
        }
        public override void VisitQueryContinuation(QueryContinuationSyntax node)
        {
            var paramInfo = m_LinqParamInfoStack.Peek();
            var paramNames = paramInfo.ParamNames;
            string prestr = paramInfo.Prestr;
            paramInfo.Prestr = ", ";
            paramNames.Clear();
            paramNames.Add(node.Identifier.Text);

            CodeBuilder.AppendFormat("{0}{{\"continuation\"}}", prestr);
            node.Body.Accept(this);
        }
    }
}
