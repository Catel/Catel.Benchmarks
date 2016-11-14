// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModelBasePerformanceTestModels.cs" company="Catel development team">
//   Copyright (c) 2008 - 2015 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.Data.ModelBase.Models
{
    using Catel.Data;

    public class ModelBasePerformanceTestModel : Catel.Data.ModelBase
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