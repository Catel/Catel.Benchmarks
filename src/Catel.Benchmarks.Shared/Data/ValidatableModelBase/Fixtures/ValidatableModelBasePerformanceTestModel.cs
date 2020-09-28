// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidatableModelBasePerformanceTestModel.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Catel.Benchmarks.Data.ValidatableModelBase.Fixtures
{
    using Catel.Data;

    public class ValidatableModelBasePerformanceTestModel : Catel.Data.ValidatableModelBase
    {
        public string StringProperty { get; set; }


        public int IntProperty { get; set; }

        public bool BoolProperty { get; set; }
    }
}
