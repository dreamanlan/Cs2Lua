using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Semantics;

using RoslynTool.CsToLua;

namespace RoslynTool.CsToLua
{
    internal class TypeOfAnalysis : CSharpSyntaxWalker
    {
        public bool HaveTypeOf
        {
            get { return m_HaveTypeOf; }
        }

        public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
        {
            var oper = m_Model.GetOperation(node) as ITypeOfExpression;
            var type = oper.TypeOperand;
            if (null != type) {
                if (type.TypeKind == TypeKind.TypeParameter) {
                    var typeParam = type as ITypeParameterSymbol;
                    if (typeParam.TypeParameterKind == TypeParameterKind.Type) {
                        m_HaveTypeOf = true;
                    }
                }
            }
            base.VisitTypeOfExpression(node);
        }

        internal TypeOfAnalysis(SemanticModel model)
        {
            m_Model = model;
        }

        private SemanticModel m_Model = null;
        private bool m_HaveTypeOf = false;
    }
}
