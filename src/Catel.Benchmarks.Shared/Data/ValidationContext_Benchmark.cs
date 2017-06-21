// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidationContext_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Data
{
    using System.Collections.Generic;
    using BenchmarkDotNet.Attributes;
    using Catel.Data;

    public class ValidationContext_Benchmark : BenchmarkBase
    {
        #region Fields
        private List<IBusinessRuleValidationResult> _businessRuleValidationResult;
        private List<IFieldValidationResult> _fieldValidationResults;
        private ValidationContext _validationContext;
        #endregion

        #region Methods
        [GlobalSetup]
        public void Init()
        {
            _fieldValidationResults = new List<IFieldValidationResult> {FieldValidationResult.CreateError("FieldA", "Field Error"), FieldValidationResult.CreateError("FieldB", "FieldB Error"), FieldValidationResult.CreateWarning("FieldC", "FieldC Warning")};
            _businessRuleValidationResult = new List<IBusinessRuleValidationResult> {BusinessRuleValidationResult.CreateError("BusinessRules Error"), BusinessRuleValidationResult.CreateWarning("BusinessRules Warning")};
            _validationContext = new ValidationContext(_fieldValidationResults, _businessRuleValidationResult);
        }

        [Benchmark]
        public void Initialization()
        {
            var validationContext = new ValidationContext(_fieldValidationResults, _businessRuleValidationResult);
        }

        [Benchmark]
        public void HasErrors()
        {
            var validationContextHasErrors = _validationContext.HasErrors;
        }

        [Benchmark]
        public void HasWarnings()
        {
            var validationContextHasWarnings = _validationContext.HasWarnings;
        }

        [Benchmark]
        public void GetBusinessRuleErrorCount()
        {
            _validationContext.GetBusinessRuleErrorCount();
        }

        [Benchmark]
        public void GetFieldErrorCount()
        {
            _validationContext.GetFieldErrorCount();
        }

        [Benchmark]
        public void GetErrorCount()
        {
            _validationContext.GetErrorCount();
        }

        [Benchmark]
        public void GetWarningCount()
        {
            _validationContext.GetWarningCount();
        }

        [Benchmark]
        public void GetFieldWarningCount()
        {
            _validationContext.GetFieldWarningCount();
        }

        [Benchmark]
        public void GetBusinessRuleWarningCount()
        {
            _validationContext.GetBusinessRuleWarningCount();
        }

        [Benchmark]
        public void GetValidations()
        {
            _validationContext.GetValidations();
        }

        [Benchmark]
        public void GetFieldValidations()
        {
            _validationContext.GetFieldValidations();
        }

        [Benchmark]
        public void GetBusinessRuleValidations()
        {
            _validationContext.GetBusinessRuleValidations();
        }

        [Benchmark]
        public void GetBusinessRuleErrors()
        {
            _validationContext.GetBusinessRuleErrors();
        }

        [Benchmark]
        public void GetBusinessRuleWarnings()
        {
            _validationContext.GetBusinessRuleWarnings();
        }

        [Benchmark]
        public void GetWarnings()
        {
            _validationContext.GetWarnings();
        }

        [Benchmark]
        public void GetFieldErrors()
        {
            _validationContext.GetFieldErrors();
        }

        [Benchmark]
        public void GetFieldWarnings()
        {
            _validationContext.GetFieldWarnings();
        }

        [Benchmark]
        public void GetErrors()
        {
            _validationContext.GetErrors();
        }
        #endregion
    }
}