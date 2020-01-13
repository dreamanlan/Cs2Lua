using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace RoslynTool.CsToDsl
{
    internal class LocalVariableAccessAnalysis : CSharpSyntaxWalker
    {
        public bool NeedInitOnDeclaration
        {
            get { return m_NeedInitOnDeclaration; }
            set { m_NeedInitOnDeclaration = value; }
        }
        public override void VisitIdentifierName(IdentifierNameSyntax node)
        {
            if (m_FirstAccess) {
                var name = node.Identifier.Text;
                if (name == m_VarName) {
                    SyntaxKind kind;
                    var expectedNode = GetExpectedParentNode(node, out kind);
                    switch (kind) {
                        case SyntaxKind.LocalDeclarationStatement:
                            break;
                        case SyntaxKind.SimpleAssignmentExpression: {
                                var assignNode = expectedNode as AssignmentExpressionSyntax;
                                var leftNode = assignNode.Left;
                                if (leftNode == node) {
                                    m_NeedInitOnDeclaration = false;
                                }
                                else {
                                    m_NeedInitOnDeclaration = true;
                                }
                            }
                            m_FirstAccess = false;
                            break;
                        case SyntaxKind.Argument: {
                                var argNode = expectedNode as ArgumentSyntax;
                                if (null != argNode) {
                                    if (null != argNode.RefOrOutKeyword && argNode.RefOrOutKeyword.Text == "out") {
                                        m_NeedInitOnDeclaration = false;
                                    }
                                    else {
                                        m_NeedInitOnDeclaration = true;
                                    }
                                }
                            }
                            m_FirstAccess = false;
                            break;
                        default:
                            m_NeedInitOnDeclaration = true;
                            m_FirstAccess = false;
                            break;
                    }
                }
            }
            base.VisitIdentifierName(node);
        }

        private SyntaxNode GetExpectedParentNode(SyntaxNode node, out SyntaxKind kind)
        {
            kind = SyntaxKind.ErrorKeyword;
            var parent = node.Parent;
            while (null != parent) {
                if (parent.IsKind(SyntaxKind.LocalDeclarationStatement)) {
                    kind = SyntaxKind.LocalDeclarationStatement;
                    return parent;
                }
                else if (parent.IsKind(SyntaxKind.SimpleAssignmentExpression)) {
                    kind = SyntaxKind.SimpleAssignmentExpression;
                    return parent;
                }
                else if (parent.IsKind(SyntaxKind.Argument)) {
                    kind = SyntaxKind.Argument;
                    return parent;
                }
                parent = parent.Parent;
            }
            return null;
        }

        internal LocalVariableAccessAnalysis(string name)
        {
            m_VarName = name;
        }

        private string m_VarName = string.Empty;
        private bool m_NeedInitOnDeclaration = false;
        private bool m_FirstAccess = true;
    }
}

