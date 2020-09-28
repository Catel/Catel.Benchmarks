// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewModelBase_Initialization.cs" company="Catel development team">
//   Copyright (c) 2008 - 2016 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.MVVM.ViewModels
{
    using System;
    using BenchmarkDotNet.Attributes;
    using Catel.MVVM;
    using Fixtures;

    public class ViewModelBase_Benchmark : BenchmarkBase
    {
        private readonly ViewModelWithModelMappings _viewModelWithModelMappings = new ViewModelWithModelMappings();

        [Benchmark]
        public BenchmarkViewModel Construction()
        {
            var vm = new BenchmarkViewModel();
            return vm;
        }

        [Benchmark]
        public void ModelPropertyMappings()
        {
            _viewModelWithModelMappings.FirstName = $"{Guid.NewGuid()}";
        }
    }
}
