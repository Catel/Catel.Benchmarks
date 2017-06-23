// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidatableModelBasePerformanceTestModel.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

#if !CATEL_4

namespace Catel.Benchmarks.Data.ValidatableModelBase.Fixtures
{
    using Catel.Data;

    public class ValidatableModelBasePerformanceTestModel : Catel.Data.ValidatableModelBase
    {
        public string StringProperty
        {
            get { return GetValue<string>(StringPropertyProperty); }
            set { SetValue(StringPropertyProperty, value); }
        }

        public static readonly PropertyData StringPropertyProperty = RegisterProperty("StringProperty", typeof(string), null);


        public int IntProperty
        {
            get { return GetValue<int>(IntPropertyProperty); }
            set { SetValue(IntPropertyProperty, value); }
        }

        public static readonly PropertyData IntPropertyProperty = RegisterProperty("IntProperty", typeof(int), null);


        public bool BoolProperty
        {
            get { return GetValue<bool>(BoolPropertyProperty); }
            set { SetValue(BoolPropertyProperty, value); }
        }

        public static readonly PropertyData BoolPropertyProperty = RegisterProperty("BoolProperty", typeof(bool), null);
    }
}

#endif