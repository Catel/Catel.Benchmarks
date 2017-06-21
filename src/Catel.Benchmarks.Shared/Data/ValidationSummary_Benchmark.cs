// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidationSummary_Benchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Data
{
    using System.Collections.Generic;
    using BenchmarkDotNet.Attributes;
    using Catel.Data;

    public class ValidationSummary_Benchmark : BenchmarkBase
    {
        #region Fields
        private ValidationContext _validationContext;
        private ValidationSummary _validationSummary;
        #endregion

        #region Methods
        [Setup]
        public void Init()
        {
            var fieldValidationResults = new List<IFieldValidationResult> {FieldValidationResult.CreateError("FieldA", "Field Error"), FieldValidationResult.CreateError("FieldB", "FieldB Error"), FieldValidationResult.CreateWarning("FieldC", "FieldC Warning")};
            var businessRuleValidationResult = new List<IBusinessRuleValidationResult> {BusinessRuleValidationResult.CreateError("BusinessRules Error"), BusinessRuleValidationResult.CreateWarning("BusinessRules Warning")};
            _validationContext = new ValidationContext(fieldValidationResults, businessRuleValidationResult);

            _validationSummary = new ValidationSummary(_validationContext);
        }

        [Benchmark]
        public void Initialization()
        {
            new ValidationSummary(_validationContext);
        }

        [Benchmark]
        public void HasWarnings()
        {
            var validationSummaryHasWarnings = _validationSummary.HasWarnings;
        }

        [Benchmark]
        public void HasErrors()
        {
            var validationSummaryHasErrors = _validationSummary.HasErrors;
        }

        [Benchmark]
        public void HasFieldErrors()
        {
            var validationSummaryHasFieldErrors = _validationSummary.HasFieldErrors;
        }

        [Benchmark]
        public void HasFieldWarnings()
        {
            var validationSummaryHasFieldWarnings = _validationSummary.HasFieldWarnings;
        }

        [Benchmark]
        public void HasBusinessRuleErrors()
        {
            var validationSummaryHasBusinessRuleErrors = _validationSummary.HasBusinessRuleErrors;
        }

        [Benchmark]
        public void HasBusinessRuleWarnings()
        {
            var validationSummaryHasBusinessRuleWarnings = _validationSummary.HasBusinessRuleWarnings;
        }

        [Benchmark]
        public void BusinessRuleErrors()
        {
            var validationSummaryHasBusinessRuleWarnings = _validationSummary.BusinessRuleErrors;
        }

#if !CATEL_4_2 && !CATEL_4_3 && !CATEL_4_4

        [Benchmark]
        public void BusinessRuleWarnings()
        {
            var validationSummaryBusinessRuleWarnings = _validationSummary.BusinessRuleWarnings;
        }

#endif

        [Benchmark]
        public void FieldErrors()
        {
            var validationSummaryFieldErrors = _validationSummary.FieldErrors;
        }

        [Benchmark]
        public void FieldWarnings()
        {
            var validationSummaryFieldWarnings = _validationSummary.FieldWarnings;
        }
        #endregion
    }
}