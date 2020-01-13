using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Semantics;

namespace RoslynTool.CsToDsl
{
    internal class FieldInitializerAnalysis : CSharpSyntaxWalker
    {
        public bool UseExplicitTypeParam
        {
            get { return m_UseExplicitTypeParam; }
        }
        public ITypeSymbol ObjectCreateType
        {
            get { return m_ObjectCreateType; }
        }

        public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
        {
            var oper = m_Model.GetOperation(node) as ITypeOfExpression;
            var type = oper.TypeOperand;
            if (null != type) {
                if (type.TypeKind == TypeKind.TypeParameter) {
                    var typeParam = type as ITypeParameterSymbol;
                    if (typeParam.TypeParameterKind == TypeParameterKind.Type) {
                        m_UseExplicitTypeParam = true;
                    }
                }
            }
            base.VisitTypeOfExpression(node);
        }

        public override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
        {
            var oper = m_Model.GetOperation(node);
            var objectCreate = oper as IObjectCreationExpression;
            if (null != objectCreate) {
                var typeSymInfo = objectCreate.Type;
                var sym = objectCreate.Constructor;
                m_ObjectCreateType = typeSymInfo;
            }
            else {
                var typeParamObjCreate = oper as ITypeParameterObjectCreationExpression;
                if (null != typeParamObjCreate) {
                    var typeParam = typeParamObjCreate.Type as ITypeParameterSymbol;
                    if (typeParam.TypeParameterKind == TypeParameterKind.Type) {
                        m_UseExplicitTypeParam = true;
                    }
                }
            }
            base.VisitObjectCreationExpression(node);
        }

        public override void VisitCastExpression(CastExpressionSyntax node)
        {
            var typeInfo = m_Model.GetTypeInfo(node.Type);
            var type = typeInfo.Type as ITypeParameterSymbol;
            if (null != type && type.TypeParameterKind == TypeParameterKind.Type) {
                m_UseExplicitTypeParam = true;
            }
            base.VisitCastExpression(node);
        }

        public override void VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            string op = node.OperatorToken.Text;
            if (op == "is" || op == "as") {
                var oper = m_Model.GetOperation(node.Right);
                if (null != oper) {
                    var type = oper.Type as ITypeParameterSymbol;
                    if (null != type && type.TypeParameterKind == TypeParameterKind.Type) {
                        m_UseExplicitTypeParam = true;
                    }
                }
            }
            base.VisitBinaryExpression(node);
        }

        internal FieldInitializerAnalysis(SemanticModel model)
        {
            m_Model = model;
        }

        private SemanticModel m_Model = null;
        private bool m_UseExplicitTypeParam = false;
        private ITypeSymbol m_ObjectCreateType = null;
    }
}
