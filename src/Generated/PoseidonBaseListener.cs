//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/ryannkelly/Desktop/CfgParse/src/test/CSharp/Poseidon.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

 namespace RapNet.generated; 

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPoseidonListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class PoseidonBaseListener : IPoseidonListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.computationalUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComputationalUnit([NotNull] PoseidonParser.ComputationalUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.computationalUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComputationalUnit([NotNull] PoseidonParser.ComputationalUnitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.classDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassDefinition([NotNull] PoseidonParser.ClassDefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.classDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassDefinition([NotNull] PoseidonParser.ClassDefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.classBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassBlock([NotNull] PoseidonParser.ClassBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.classBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassBlock([NotNull] PoseidonParser.ClassBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.classExtension"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassExtension([NotNull] PoseidonParser.ClassExtensionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.classExtension"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassExtension([NotNull] PoseidonParser.ClassExtensionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] PoseidonParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] PoseidonParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.variableAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableAssignment([NotNull] PoseidonParser.VariableAssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.variableAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableAssignment([NotNull] PoseidonParser.VariableAssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.variableDeclaratorId"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclaratorId([NotNull] PoseidonParser.VariableDeclaratorIdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.variableDeclaratorId"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclaratorId([NotNull] PoseidonParser.VariableDeclaratorIdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.variableInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableInitializer([NotNull] PoseidonParser.VariableInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.variableInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableInitializer([NotNull] PoseidonParser.VariableInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.arrayInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayInitializer([NotNull] PoseidonParser.ArrayInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.arrayInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayInitializer([NotNull] PoseidonParser.ArrayInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] PoseidonParser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] PoseidonParser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.literalBoolean"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralBoolean([NotNull] PoseidonParser.LiteralBooleanContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.literalBoolean"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralBoolean([NotNull] PoseidonParser.LiteralBooleanContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.literalString"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralString([NotNull] PoseidonParser.LiteralStringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.literalString"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralString([NotNull] PoseidonParser.LiteralStringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.literalNull"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralNull([NotNull] PoseidonParser.LiteralNullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.literalNull"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralNull([NotNull] PoseidonParser.LiteralNullContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.literalNumeric"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralNumeric([NotNull] PoseidonParser.LiteralNumericContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.literalNumeric"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralNumeric([NotNull] PoseidonParser.LiteralNumericContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.literalFloat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralFloat([NotNull] PoseidonParser.LiteralFloatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.literalFloat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralFloat([NotNull] PoseidonParser.LiteralFloatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.literalInteger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralInteger([NotNull] PoseidonParser.LiteralIntegerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.literalInteger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralInteger([NotNull] PoseidonParser.LiteralIntegerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.deleteStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeleteStatement([NotNull] PoseidonParser.DeleteStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.deleteStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeleteStatement([NotNull] PoseidonParser.DeleteStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] PoseidonParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] PoseidonParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.parExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParExpression([NotNull] PoseidonParser.ParExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.parExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParExpression([NotNull] PoseidonParser.ParExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.primaryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryExpression([NotNull] PoseidonParser.PrimaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.primaryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryExpression([NotNull] PoseidonParser.PrimaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PoseidonParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] PoseidonParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PoseidonParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] PoseidonParser.IdentifierContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
