﻿//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System.Diagnostics.CodeAnalysis;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;

namespace Microsoft.Kusto.ServiceLayer.Formatter
{
    // Any new SqlCodeObject types should have a Visit method added, and this class should then be updated with a matching
    // Visit implementation that routes to the Format method.
    [SuppressMessage("Microsoft.Maintainability","CA1506:AvoidExcessiveClassCoupling")]
    partial class FormatterVisitor : SqlCodeObjectVisitor
    {
        public override void Visit(SqlAggregateFunctionCallExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlAllAnyComparisonBooleanExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlAllowPageLocksIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlAllowRowLocksIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlAlterFunctionStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlAlterProcedureStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlAlterTriggerStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlAlterViewStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlAssignment codeObject) { Format(codeObject); }
        public override void Visit(SqlBackupCertificateStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlBackupDatabaseStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlBackupLogStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlBackupMasterKeyStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlBackupServiceMasterKeyStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlBackupTableStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlBatch codeObject) { Format(codeObject); }
        public override void Visit(SqlBetweenBooleanExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlBinaryBooleanExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlBinaryFilterExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlBinaryQueryExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlBinaryScalarExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlBooleanExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlBooleanFilterExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlBreakStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlBuiltinScalarFunctionCallExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlCastExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlChangeTrackingContext codeObject) { Format(codeObject); }
        public override void Visit(SqlCheckConstraint codeObject) { Format(codeObject); }
        public override void Visit(SqlClrAssemblySpecifier codeObject) { Format(codeObject); }
        public override void Visit(SqlClrClassSpecifier codeObject) { Format(codeObject); }
        public override void Visit(SqlClrFunctionBodyDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlClrMethodSpecifier codeObject) { Format(codeObject); }
        public override void Visit(SqlCollateScalarExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlCollation codeObject) { Format(codeObject); }
        public override void Visit(SqlColumnAssignment codeObject) { Format(codeObject); }
        public override void Visit(SqlColumnDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlColumnIdentity codeObject) { Format(codeObject); }
        public override void Visit(SqlColumnRefExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlCommentStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCommonTableExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlComparisonBooleanExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlCompoundStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCompressionPartitionRange codeObject) { Format(codeObject); }
        public override void Visit(SqlComputedColumnDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlConditionClause codeObject) { Format(codeObject); }
        public override void Visit(SqlConstraint codeObject) { Format(codeObject); }
        public override void Visit(SqlContinueStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlConvertExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateFunctionStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateIndexStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateLoginFromAsymKeyStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateLoginFromCertificateStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateLoginFromWindowsStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateLoginWithPasswordStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateProcedureStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateRoleStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateSchemaStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateSynonymStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateTableStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateTriggerStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateUserDefinedDataTypeStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateUserDefinedTableTypeStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateUserDefinedTypeStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateUserFromAsymKeyStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateUserFromCertificateStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateUserFromLoginStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateUserOption codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateUserStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateUserWithImplicitAuthenticationStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateUserWithoutLoginStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateViewStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCubeGroupByItem codeObject) { Format(codeObject); }
        public override void Visit(SqlCursorDeclareStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlCursorOption codeObject) { Format(codeObject); }
        public override void Visit(SqlCursorVariableAssignment codeObject) { Format(codeObject); }
        public override void Visit(SqlCursorVariableRefExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlDataCompressionIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlDataType codeObject) { Format(codeObject); }
        public override void Visit(SqlDataTypeSpecification codeObject) { Format(codeObject); }
        public override void Visit(SqlDBCCStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDdlTriggerDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlDefaultConstraint codeObject) { Format(codeObject); }
        public override void Visit(SqlDefaultValuesInsertMergeActionSource codeObject) { Format(codeObject); }
        public override void Visit(SqlDefaultValuesInsertSource codeObject) { Format(codeObject); }
        public override void Visit(SqlDeleteMergeAction codeObject) { Format(codeObject); }
        public override void Visit(SqlDeleteSpecification codeObject) { Format(codeObject); }
        public override void Visit(SqlDeleteStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDenyStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDerivedTableExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlDmlSpecificationTableSource codeObject) { Format(codeObject); }
        public override void Visit(SqlDmlTriggerDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlDropAggregateStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropDatabaseStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropDefaultStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropExistingIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlDropFunctionStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropLoginStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropProcedureStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropRuleStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropSchemaStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropSynonymStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropTableStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropTriggerStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropTypeStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropUserStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropViewStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlExecuteAsClause codeObject) { Format(codeObject); }
        public override void Visit(SqlExecuteArgument codeObject) { Format(codeObject); }
        public override void Visit(SqlExecuteModuleStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlExistsBooleanExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlFillFactorIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlFilterClause codeObject) { Format(codeObject); }
        public override void Visit(SqlForBrowseClause codeObject) { Format(codeObject); }
        public override void Visit(SqlForeignKeyConstraint codeObject) { Format(codeObject); }
        public override void Visit(SqlForXmlAutoClause codeObject) { Format(codeObject); }
        public override void Visit(SqlForXmlClause codeObject) { Format(codeObject); }
        public override void Visit(SqlForXmlDirective codeObject) { Format(codeObject); }
        public override void Visit(SqlForXmlExplicitClause codeObject) { Format(codeObject); }
        public override void Visit(SqlForXmlPathClause codeObject) { Format(codeObject); }
        public override void Visit(SqlForXmlRawClause codeObject) { Format(codeObject); }
        public override void Visit(SqlFromClause codeObject) { Format(codeObject); }
        public override void Visit(SqlFullTextBooleanExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlFullTextColumn codeObject) { Format(codeObject); }
        public override void Visit(SqlFunctionDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlGlobalScalarVariableRefExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlGrandTotalGroupByItem codeObject) { Format(codeObject); }
        public override void Visit(SqlGrandTotalGroupingSet codeObject) { Format(codeObject); }
        public override void Visit(SqlGrantStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlGroupByClause codeObject) { Format(codeObject); }
        public override void Visit(SqlGroupBySets codeObject) { Format(codeObject); }
        public override void Visit(SqlGroupingSetItemsCollection codeObject) { Format(codeObject); }
        public override void Visit(SqlHavingClause codeObject) { Format(codeObject); }
        public override void Visit(SqlIdentifier codeObject) { Format(codeObject); }
        public override void Visit(SqlIdentityFunctionCallExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlIfElseStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlIgnoreDupKeyIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlInBooleanExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlInBooleanExpressionCollectionValue codeObject) { Format(codeObject); }
        public override void Visit(SqlInBooleanExpressionQueryValue codeObject) { Format(codeObject); }
        public override void Visit(SqlIndexedColumn codeObject) { Format(codeObject); }
        public override void Visit(SqlIndexHint codeObject) { Format(codeObject); }
        public override void Visit(SqlIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlInlineFunctionBodyDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlInlineTableRelationalFunctionDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlInlineTableVariableDeclaration codeObject) { Format(codeObject); }
        public override void Visit(SqlInlineTableVariableDeclareStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlInsertMergeAction codeObject) { Format(codeObject); }
        public override void Visit(SqlInsertSource codeObject) { Format(codeObject); }
        public override void Visit(SqlInsertSpecification codeObject) { Format(codeObject); }
        public override void Visit(SqlInsertStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlIntoClause codeObject) { Format(codeObject); }
        public override void Visit(SqlIsNullBooleanExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlLargeDataStorageInformation codeObject) { Format(codeObject); }
        public override void Visit(SqlLikeBooleanExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlLiteralExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlLoginPassword codeObject) { Format(codeObject); }
        public override void Visit(SqlMaxDegreeOfParallelismIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlMergeActionClause codeObject) { Format(codeObject); }
        public override void Visit(SqlMergeSpecification codeObject) { Format(codeObject); }
        public override void Visit(SqlMergeStatement codeObject) { Format(codeObject); }        
        public override void Visit(SqlModuleCalledOnNullInputOption codeObject) { Format(codeObject); }
        public override void Visit(SqlModuleEncryptionOption codeObject) { Format(codeObject); }
        public override void Visit(SqlModuleExecuteAsOption codeObject) { Format(codeObject); }
        public override void Visit(SqlModuleOption codeObject) { Format(codeObject); }
        public override void Visit(SqlModuleRecompileOption codeObject) { Format(codeObject); }
        public override void Visit(SqlModuleReturnsNullOnNullInputOption codeObject) { Format(codeObject); }
        public override void Visit(SqlModuleSchemaBindingOption codeObject) { Format(codeObject); }
        public override void Visit(SqlModuleViewMetadataOption codeObject) { Format(codeObject); }
        public override void Visit(SqlMultistatementFunctionBodyDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlMultistatementTableRelationalFunctionDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlNotBooleanExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlObjectIdentifier codeObject) { Format(codeObject); }
        public override void Visit(SqlObjectReference codeObject) { Format(codeObject); }
        public override void Visit(SqlOnlineIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlOrderByClause codeObject) { Format(codeObject); }
        public override void Visit(SqlOrderByItem codeObject) { Format(codeObject); }
        public override void Visit(SqlOutputClause codeObject) { Format(codeObject); }
        public override void Visit(SqlOutputIntoClause codeObject) { Format(codeObject); }
        public override void Visit(SqlPadIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlParameterDeclaration codeObject) { Format(codeObject); }
        public override void Visit(SqlPivotClause codeObject) { Format(codeObject); }
        public override void Visit(SqlPivotTableExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlPrimaryKeyConstraint codeObject) { Format(codeObject); }
        public override void Visit(SqlProcedureDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlQualifiedJoinTableExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlQueryExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlQuerySpecification codeObject) { Format(codeObject); }
        public override void Visit(SqlQueryWithClause codeObject) { Format(codeObject); }
        public override void Visit(SqlRestoreDatabaseStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlRestoreInformationStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlRestoreLogStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlRestoreMasterKeyStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlRestoreServiceMasterKeyStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlRestoreTableStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlReturnStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlRevokeStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlRollupGroupByItem codeObject) { Format(codeObject); }
        public override void Visit(SqlRowConstructorExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlScalarClrFunctionDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlScalarExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlScalarFunctionReturnType codeObject) { Format(codeObject); }
        public override void Visit(SqlScalarRefExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlScalarRelationalFunctionDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlScalarSubQueryExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlScalarVariableAssignment codeObject) { Format(codeObject); }
        public override void Visit(SqlScalarVariableRefExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlScript codeObject) { Format(codeObject); }
        public override void Visit(SqlSearchedCaseExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlSearchedWhenClause codeObject) { Format(codeObject); }
        public override void Visit(SqlSelectClause codeObject) { Format(codeObject); }
        public override void Visit(SqlSelectIntoClause codeObject) { Format(codeObject); }
        public override void Visit(SqlSelectScalarExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlSelectSpecification codeObject) { Format(codeObject); }
        public override void Visit(SqlSelectSpecificationInsertSource codeObject) { Format(codeObject); }
        public override void Visit(SqlSelectStarExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlSelectStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlSelectVariableAssignmentExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlSetAssignmentStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlSetClause codeObject) { Format(codeObject); }
        public override void Visit(SqlSetStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlSimpleCaseExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlSimpleGroupByItem codeObject) { Format(codeObject); }
        public override void Visit(SqlSimpleOrderByClause codeObject) { Format(codeObject); }
        public override void Visit(SqlSimpleOrderByItem codeObject) { Format(codeObject); }
        public override void Visit(SqlSimpleWhenClause codeObject) { Format(codeObject); }
        public override void Visit(SqlSortedDataIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlSortedDataReorgIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlSortInTempDbIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlStatisticsNoRecomputeIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlStatisticsOnlyIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlStorageSpecification codeObject) { Format(codeObject); }
        public override void Visit(SqlTableClrFunctionDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlTableConstructorExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlTableConstructorInsertSource codeObject) { Format(codeObject); }
        public override void Visit(SqlTableDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlTableExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlTableFunctionReturnType codeObject) { Format(codeObject); }
        public override void Visit(SqlTableHint codeObject) { Format(codeObject); }
        public override void Visit(SqlTableRefExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlTableUdtInstanceMethodExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlTableValuedFunctionRefExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlTableVariableRefExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlTargetTableExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlTopSpecification codeObject) { Format(codeObject); }
        public override void Visit(SqlTriggerAction codeObject) { Format(codeObject); }
        public override void Visit(SqlTriggerDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlTriggerEvent codeObject) { Format(codeObject); }
        public override void Visit(SqlTryCatchStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlUdtInstanceDataMemberExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlUdtInstanceMethodExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlUdtStaticDataMemberExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlUdtStaticMethodExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlUnaryScalarExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlUniqueConstraint codeObject) { Format(codeObject); }
        public override void Visit(SqlUnpivotClause codeObject) { Format(codeObject); }
        public override void Visit(SqlUnpivotTableExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlUnqualifiedJoinTableExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlUpdateBooleanExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlUpdateMergeAction codeObject) { Format(codeObject); }
        public override void Visit(SqlUpdateSpecification codeObject) { Format(codeObject); }
        public override void Visit(SqlUpdateStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlUserDefinedScalarFunctionCallExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlUseStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlValuesInsertMergeActionSource codeObject) { Format(codeObject); }
        public override void Visit(SqlVariableColumnAssignment codeObject) { Format(codeObject); }
        public override void Visit(SqlVariableDeclaration codeObject) { Format(codeObject); }
        public override void Visit(SqlVariableDeclareStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlViewDefinition codeObject) { Format(codeObject); }
        public override void Visit(SqlWhereClause codeObject) { Format(codeObject); }
        public override void Visit(SqlWhileStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlXmlNamespacesDeclaration codeObject) { Format(codeObject); }
        public override void Visit(SqlAtTimeZoneExpression codeObject) { Format(codeObject); }
        public override void Visit(SqlBucketCountIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlCompressionDelayIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlCreateUserFromExternalProviderStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropSecurityPolicyStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlDropSequenceStatement codeObject) { Format(codeObject); }
        public override void Visit(SqlInlineIndexConstraint codeObject) { Format(codeObject); }
        public override void Visit(SqlModuleNativeCompilationOption codeObject) { Format(codeObject); }
        public override void Visit(SqlStatisticsIncrementalIndexOption codeObject) { Format(codeObject); }
        public override void Visit(SqlTemporalPeriodDefinition codeObject) { Format(codeObject); }
    }

}
