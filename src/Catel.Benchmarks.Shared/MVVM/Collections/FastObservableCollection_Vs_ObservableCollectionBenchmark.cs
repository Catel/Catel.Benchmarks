// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FastObservableCollection_Vs_ObservableCollectionBenchmark.cs" company="Catel development team">
//   Copyright (c) 2008 - 2017 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel.Benchmarks.MVVM.Collections
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using BenchmarkDotNet.Attributes;
    using Catel.Collections;

    public class FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark : BenchmarkBase
    {
        #region Fields
#if !CATEL_4_4 && !CATEL_4_3 && !CATEL_4_2
        private FastBindingList<int> _fastBindingList;
#endif

        private FastObservableCollection<int> _fastObservableCollection;
        private ObservableCollection<int> _observableCollection;
        #endregion

        #region Methods
        [GlobalSetup]
        public void Init()
        {
#if !CATEL_4_4 && !CATEL_4_3 && !CATEL_4_2
            _fastBindingList = new FastBindingList<int> {-1, -2, -3, -4, -5, -6, -7, -8, -9, -10};
#endif

            _observableCollection = new ObservableCollection<int> {-1, -2, -3, -4, -5, -6, -7, -8, -9, -10};
            _fastObservableCollection = new FastObservableCollection<int> {-1, -2, -3, -4, -5, -6, -7, -8, -9, -10};
        }

        [Benchmark]
        public void ObservableCollection_BashInsert()
        {
#if !CATEL_4_4 && !CATEL_4_3 && !CATEL_4_2
            (_observableCollection as ICollection<int>).AddRange(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
#else
            _observableCollection.AddRange(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
#endif
        }

        [Benchmark]
        public void FastObservableCollection_BashInsert()
        {
#if !CATEL_4_4 && !CATEL_4_3 && !CATEL_4_2
            _fastObservableCollection.AddItems(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, SuspensionMode.Adding);
#else
            _fastObservableCollection.AddItems(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
#endif
        }

#if !CATEL_4_4 && !CATEL_4_3 && !CATEL_4_2
        [Benchmark]
        public void FastBindingList_BashInsert()
        {
            _fastBindingList.AddItems(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
        }
#endif

        [Benchmark]
        public void ObservableCollection_BashRemove()
        {
            for (var i = _observableCollection.Count; i >= 0; i--)
            {
                _observableCollection.Remove(_observableCollection[i]);
            }
        }

        [Benchmark]
        public void FastObservableCollection_BashRemove()
        {
#if !CATEL_4_4 && !CATEL_4_3 && !CATEL_4_2
            using (_fastObservableCollection.SuspendChangeNotifications(SuspensionMode.Removing))
#else
            using (_fastObservableCollection.SuspendChangeNotifications())
#endif
            {
                for (var i = _fastObservableCollection.Count; i >= 0; i--)
                {
                    _fastObservableCollection.Remove(_fastObservableCollection[i]);
                }
            }
        }

#if !CATEL_4_4 && !CATEL_4_3 && !CATEL_4_2
        [Benchmark]
        public void FastBindingList_BashRemove()
        {
            _fastBindingList.RemoveItems(new[] {-1, -2, -3, -4, -5, -6, -7, -8, -9, -10});
        }
#endif
        #endregion
    }
}