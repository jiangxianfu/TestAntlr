//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SQLiteParser.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace TestAntlr.Parser {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SQLiteParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface ISQLiteParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParse([NotNull] SQLiteParser.ParseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.sql_stmt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSql_stmt_list([NotNull] SQLiteParser.Sql_stmt_listContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.sql_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSql_stmt([NotNull] SQLiteParser.Sql_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.alter_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlter_table_stmt([NotNull] SQLiteParser.Alter_table_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.analyze_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnalyze_stmt([NotNull] SQLiteParser.Analyze_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.attach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttach_stmt([NotNull] SQLiteParser.Attach_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.begin_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBegin_stmt([NotNull] SQLiteParser.Begin_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.commit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommit_stmt([NotNull] SQLiteParser.Commit_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.rollback_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRollback_stmt([NotNull] SQLiteParser.Rollback_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.savepoint_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSavepoint_stmt([NotNull] SQLiteParser.Savepoint_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.release_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelease_stmt([NotNull] SQLiteParser.Release_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.create_index_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreate_index_stmt([NotNull] SQLiteParser.Create_index_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.indexed_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndexed_column([NotNull] SQLiteParser.Indexed_columnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.create_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreate_table_stmt([NotNull] SQLiteParser.Create_table_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.column_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn_def([NotNull] SQLiteParser.Column_defContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType_name([NotNull] SQLiteParser.Type_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.column_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn_constraint([NotNull] SQLiteParser.Column_constraintContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.signed_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSigned_number([NotNull] SQLiteParser.Signed_numberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.table_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_constraint([NotNull] SQLiteParser.Table_constraintContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.foreign_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForeign_key_clause([NotNull] SQLiteParser.Foreign_key_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.conflict_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConflict_clause([NotNull] SQLiteParser.Conflict_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.create_trigger_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreate_trigger_stmt([NotNull] SQLiteParser.Create_trigger_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.create_view_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreate_view_stmt([NotNull] SQLiteParser.Create_view_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.create_virtual_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreate_virtual_table_stmt([NotNull] SQLiteParser.Create_virtual_table_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWith_clause([NotNull] SQLiteParser.With_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.cte_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCte_table_name([NotNull] SQLiteParser.Cte_table_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.recursive_cte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRecursive_cte([NotNull] SQLiteParser.Recursive_cteContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.common_table_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommon_table_expression([NotNull] SQLiteParser.Common_table_expressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.delete_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDelete_stmt([NotNull] SQLiteParser.Delete_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.delete_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDelete_stmt_limited([NotNull] SQLiteParser.Delete_stmt_limitedContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.detach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDetach_stmt([NotNull] SQLiteParser.Detach_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.drop_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDrop_stmt([NotNull] SQLiteParser.Drop_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] SQLiteParser.ExprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.raise_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRaise_function([NotNull] SQLiteParser.Raise_functionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.literal_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral_value([NotNull] SQLiteParser.Literal_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.insert_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInsert_stmt([NotNull] SQLiteParser.Insert_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.upsert_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUpsert_clause([NotNull] SQLiteParser.Upsert_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.pragma_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPragma_stmt([NotNull] SQLiteParser.Pragma_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.pragma_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPragma_value([NotNull] SQLiteParser.Pragma_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.reindex_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReindex_stmt([NotNull] SQLiteParser.Reindex_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelect_stmt([NotNull] SQLiteParser.Select_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoin_clause([NotNull] SQLiteParser.Join_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.select_core"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelect_core([NotNull] SQLiteParser.Select_coreContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.factored_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactored_select_stmt([NotNull] SQLiteParser.Factored_select_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.simple_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimple_select_stmt([NotNull] SQLiteParser.Simple_select_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.compound_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompound_select_stmt([NotNull] SQLiteParser.Compound_select_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.table_or_subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_or_subquery([NotNull] SQLiteParser.Table_or_subqueryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.result_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResult_column([NotNull] SQLiteParser.Result_columnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.join_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoin_operator([NotNull] SQLiteParser.Join_operatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.join_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoin_constraint([NotNull] SQLiteParser.Join_constraintContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.compound_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompound_operator([NotNull] SQLiteParser.Compound_operatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.update_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUpdate_stmt([NotNull] SQLiteParser.Update_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.column_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn_name_list([NotNull] SQLiteParser.Column_name_listContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.update_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUpdate_stmt_limited([NotNull] SQLiteParser.Update_stmt_limitedContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.qualified_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQualified_table_name([NotNull] SQLiteParser.Qualified_table_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.vacuum_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVacuum_stmt([NotNull] SQLiteParser.Vacuum_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.filter_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFilter_clause([NotNull] SQLiteParser.Filter_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.window_defn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWindow_defn([NotNull] SQLiteParser.Window_defnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.over_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOver_clause([NotNull] SQLiteParser.Over_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.frame_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFrame_spec([NotNull] SQLiteParser.Frame_specContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.frame_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFrame_clause([NotNull] SQLiteParser.Frame_clauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.simple_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimple_function_invocation([NotNull] SQLiteParser.Simple_function_invocationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.aggregate_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAggregate_function_invocation([NotNull] SQLiteParser.Aggregate_function_invocationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.window_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWindow_function_invocation([NotNull] SQLiteParser.Window_function_invocationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.common_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommon_table_stmt([NotNull] SQLiteParser.Common_table_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.order_by_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrder_by_stmt([NotNull] SQLiteParser.Order_by_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.limit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLimit_stmt([NotNull] SQLiteParser.Limit_stmtContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.ordering_term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrdering_term([NotNull] SQLiteParser.Ordering_termContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAsc_desc([NotNull] SQLiteParser.Asc_descContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.frame_left"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFrame_left([NotNull] SQLiteParser.Frame_leftContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.frame_right"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFrame_right([NotNull] SQLiteParser.Frame_rightContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.frame_single"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFrame_single([NotNull] SQLiteParser.Frame_singleContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.window_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWindow_function([NotNull] SQLiteParser.Window_functionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.of_OF_fset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOf_OF_fset([NotNull] SQLiteParser.Of_OF_fsetContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.default_DEFAULT__value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefault_DEFAULT__value([NotNull] SQLiteParser.Default_DEFAULT__valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.partition_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPartition_by([NotNull] SQLiteParser.Partition_byContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.order_by_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrder_by_expr([NotNull] SQLiteParser.Order_by_exprContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.order_by_expr_asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrder_by_expr_asc_desc([NotNull] SQLiteParser.Order_by_expr_asc_descContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.expr_asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr_asc_desc([NotNull] SQLiteParser.Expr_asc_descContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.initial_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInitial_select([NotNull] SQLiteParser.Initial_selectContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.recursive__select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRecursive__select([NotNull] SQLiteParser.Recursive__selectContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.unary_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnary_operator([NotNull] SQLiteParser.Unary_operatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.error_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitError_message([NotNull] SQLiteParser.Error_messageContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.module_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModule_argument([NotNull] SQLiteParser.Module_argumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn_alias([NotNull] SQLiteParser.Column_aliasContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyword([NotNull] SQLiteParser.KeywordContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitName([NotNull] SQLiteParser.NameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_name([NotNull] SQLiteParser.Function_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.schema_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSchema_name([NotNull] SQLiteParser.Schema_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_name([NotNull] SQLiteParser.Table_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.table_or_index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_or_index_name([NotNull] SQLiteParser.Table_or_index_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.new_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNew_table_name([NotNull] SQLiteParser.New_table_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn_name([NotNull] SQLiteParser.Column_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.collation_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCollation_name([NotNull] SQLiteParser.Collation_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.foreign_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForeign_table([NotNull] SQLiteParser.Foreign_tableContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIndex_name([NotNull] SQLiteParser.Index_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.trigger_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTrigger_name([NotNull] SQLiteParser.Trigger_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.view_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitView_name([NotNull] SQLiteParser.View_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.module_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModule_name([NotNull] SQLiteParser.Module_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.pragma_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPragma_name([NotNull] SQLiteParser.Pragma_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.savepoint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSavepoint_name([NotNull] SQLiteParser.Savepoint_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_alias([NotNull] SQLiteParser.Table_aliasContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.transaction_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTransaction_name([NotNull] SQLiteParser.Transaction_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.window_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWindow_name([NotNull] SQLiteParser.Window_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAlias([NotNull] SQLiteParser.AliasContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.filename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFilename([NotNull] SQLiteParser.FilenameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.base_window_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBase_window_name([NotNull] SQLiteParser.Base_window_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.simple_func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimple_func([NotNull] SQLiteParser.Simple_funcContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.aggregate_func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAggregate_func([NotNull] SQLiteParser.Aggregate_funcContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.table_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTable_function_name([NotNull] SQLiteParser.Table_function_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SQLiteParser.any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAny_name([NotNull] SQLiteParser.Any_nameContext context);
}
} // namespace TestAntlr.Parser
