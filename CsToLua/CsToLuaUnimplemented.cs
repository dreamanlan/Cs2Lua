using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using RoslynTool.CsToLua;

namespace RoslynTool.CsToLua
{
    internal partial class CsLuaTranslater
    {
        #region 未计划支持的语法特性
        public override void VisitGenericName(GenericNameSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitTypeParameterList(TypeParameterListSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitTypeParameter(TypeParameterSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitTypeParameterConstraintClause(TypeParameterConstraintClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitTypeArgumentList(TypeArgumentListSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitTypeConstraint(TypeConstraintSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitConstructorConstraint(ConstructorConstraintSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitClassOrStructConstraint(ClassOrStructConstraintSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitBracketedParameterList(BracketedParameterListSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitAccessorList(AccessorListSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitAccessorDeclaration(AccessorDeclarationSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitArrowExpressionClause(ArrowExpressionClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitMemberBindingExpression(MemberBindingExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitElementBindingExpression(ElementBindingExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitConstructorInitializer(ConstructorInitializerSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitDestructorDeclaration(DestructorDeclarationSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitExplicitInterfaceSpecifier(ExplicitInterfaceSpecifierSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitOperatorDeclaration(OperatorDeclarationSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitAnonymousObjectMemberDeclarator(AnonymousObjectMemberDeclaratorSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitMakeRefExpression(MakeRefExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitRefTypeExpression(RefTypeExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitRefValueExpression(RefValueExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitThrowStatement(ThrowStatementSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitYieldStatement(YieldStatementSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitLabeledStatement(LabeledStatementSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitGotoStatement(GotoStatementSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitPointerType(PointerTypeSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitNullableType(NullableTypeSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitOmittedTypeArgument(OmittedTypeArgumentSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitImplicitElementAccess(ImplicitElementAccessSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitNameColon(NameColonSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitAliasQualifiedName(AliasQualifiedNameSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitExternAliasDirective(ExternAliasDirectiveSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitNameEquals(NameEqualsSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitUsingStatement(UsingStatementSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitFixedStatement(FixedStatementSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitCheckedStatement(CheckedStatementSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitCheckedExpression(CheckedExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitUnsafeStatement(UnsafeStatementSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitLockStatement(LockStatementSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitTryStatement(TryStatementSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitCatchClause(CatchClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitCatchDeclaration(CatchDeclarationSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitCatchFilterClause(CatchFilterClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitFinallyClause(FinallyClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitDefaultExpression(DefaultExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitSizeOfExpression(SizeOfExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitStackAllocArrayCreationExpression(StackAllocArrayCreationExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitIncompleteMember(IncompleteMemberSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitAwaitExpression(AwaitExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitTypeCref(TypeCrefSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitQualifiedCref(QualifiedCrefSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitNameMemberCref(NameMemberCrefSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitIndexerMemberCref(IndexerMemberCrefSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitOperatorMemberCref(OperatorMemberCrefSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitConversionOperatorMemberCref(ConversionOperatorMemberCrefSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitCrefParameterList(CrefParameterListSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitCrefBracketedParameterList(CrefBracketedParameterListSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitCrefParameter(CrefParameterSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitQueryExpression(QueryExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitQueryBody(QueryBodySyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitFromClause(FromClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitLetClause(LetClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitJoinClause(JoinClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitJoinIntoClause(JoinIntoClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitWhereClause(WhereClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitOrderByClause(OrderByClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitOrdering(OrderingSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitSelectClause(SelectClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitGroupClause(GroupClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitQueryContinuation(QueryContinuationSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitOmittedArraySizeExpression(OmittedArraySizeExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitInterpolatedStringExpression(InterpolatedStringExpressionSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitInterpolatedStringText(InterpolatedStringTextSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitInterpolation(InterpolationSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitInterpolationAlignmentClause(InterpolationAlignmentClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitInterpolationFormatClause(InterpolationFormatClauseSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitGlobalStatement(GlobalStatementSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        #endregion

        #region 借助语义信息处理过的语法部分，如果执行到则说明处理不完整
        public override void VisitBaseList(BaseListSyntax node)
        {
            Log(node, "Unhandle syntax part: {0}\n{1}", node.ToString(), Environment.StackTrace);
        }
        public override void VisitSimpleBaseType(SimpleBaseTypeSyntax node)
        {
            Log(node, "Unhandle syntax part: {0}\n{1}", node.ToString(), Environment.StackTrace);
        }
        public override void VisitParameterList(ParameterListSyntax node)
        {
            Log(node, "Unhandle syntax part: {0}\n{1}", node.ToString(), Environment.StackTrace);
        }
        public override void VisitParameter(ParameterSyntax node)
        {
            Log(node, "Unhandle syntax part: {0}\n{1}", node.ToString(), Environment.StackTrace);
        }
        public override void VisitAttributeList(AttributeListSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitAttributeTargetSpecifier(AttributeTargetSpecifierSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitAttribute(AttributeSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitAttributeArgumentList(AttributeArgumentListSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        public override void VisitAttributeArgument(AttributeArgumentSyntax node)
        {
            Log(node, "Unsupported syntax part: {0} location{1}", node.ToString(), node.GetLocation().GetLineSpan());
        }
        #endregion

        #region 不用单独处理的语法部分
        public override void VisitSwitchSection(SwitchSectionSyntax node)
        { }
        public override void VisitCaseSwitchLabel(CaseSwitchLabelSyntax node)
        { }
        public override void VisitDefaultSwitchLabel(DefaultSwitchLabelSyntax node)
        { }
        public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
        { }
        public override void VisitArrayType(ArrayTypeSyntax node)
        { }
        public override void VisitArrayRankSpecifier(ArrayRankSpecifierSyntax node)
        { }
        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        { }
        public override void VisitPredefinedType(PredefinedTypeSyntax node)
        { }
        public override void VisitUsingDirective(UsingDirectiveSyntax node)
        { }
        public override void VisitSkippedTokensTrivia(SkippedTokensTriviaSyntax node)
        { }
        public override void VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax node)
        { }
        public override void VisitReferenceDirectiveTrivia(ReferenceDirectiveTriviaSyntax node)
        { }
        public override void VisitLoadDirectiveTrivia(LoadDirectiveTriviaSyntax node)
        { }
        public override void VisitShebangDirectiveTrivia(ShebangDirectiveTriviaSyntax node)
        { }
        public override void VisitXmlElement(XmlElementSyntax node)
        { }
        public override void VisitXmlElementStartTag(XmlElementStartTagSyntax node)
        { }
        public override void VisitXmlElementEndTag(XmlElementEndTagSyntax node)
        { }
        public override void VisitXmlEmptyElement(XmlEmptyElementSyntax node)
        { }
        public override void VisitXmlName(XmlNameSyntax node)
        { }
        public override void VisitXmlPrefix(XmlPrefixSyntax node)
        { }
        public override void VisitXmlTextAttribute(XmlTextAttributeSyntax node)
        { }
        public override void VisitXmlCrefAttribute(XmlCrefAttributeSyntax node)
        { }
        public override void VisitXmlNameAttribute(XmlNameAttributeSyntax node)
        { }
        public override void VisitXmlText(XmlTextSyntax node)
        { }
        public override void VisitXmlCDataSection(XmlCDataSectionSyntax node)
        { }
        public override void VisitXmlProcessingInstruction(XmlProcessingInstructionSyntax node)
        { }
        public override void VisitXmlComment(XmlCommentSyntax node)
        { }
        public override void VisitRegionDirectiveTrivia(RegionDirectiveTriviaSyntax node)
        { }
        public override void VisitEndRegionDirectiveTrivia(EndRegionDirectiveTriviaSyntax node)
        { }
        #endregion
        
        #region 预处理的功能Roslyn库已经实现，这些接口是提供预处理相关信息，我们不需要处理
        public override void VisitIfDirectiveTrivia(IfDirectiveTriviaSyntax node)
        {
        }
        public override void VisitEndIfDirectiveTrivia(EndIfDirectiveTriviaSyntax node)
        {
        }
        public override void VisitDefineDirectiveTrivia(DefineDirectiveTriviaSyntax node)
        {
        }
        public override void VisitUndefDirectiveTrivia(UndefDirectiveTriviaSyntax node)
        {
        }
        public override void VisitElifDirectiveTrivia(ElifDirectiveTriviaSyntax node)
        {
        }
        public override void VisitElseDirectiveTrivia(ElseDirectiveTriviaSyntax node)
        {
        }
        public override void VisitErrorDirectiveTrivia(ErrorDirectiveTriviaSyntax node)
        {
        }
        public override void VisitWarningDirectiveTrivia(WarningDirectiveTriviaSyntax node)
        {
        }
        public override void VisitBadDirectiveTrivia(BadDirectiveTriviaSyntax node)
        {
        }
        public override void VisitLineDirectiveTrivia(LineDirectiveTriviaSyntax node)
        {
        }
        public override void VisitPragmaWarningDirectiveTrivia(PragmaWarningDirectiveTriviaSyntax node)
        {
        }
        public override void VisitPragmaChecksumDirectiveTrivia(PragmaChecksumDirectiveTriviaSyntax node)
        {
        }
        #endregion
    }
}
