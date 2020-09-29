namespace Catel.Benchmarks.MVVM.Collections
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using BenchmarkDotNet.Attributes;
    using Catel.Collections;

    public class FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark : BenchmarkBase
    {
        private FastBindingList<int> _fastBindingList;

        private FastObservableCollection<int> _fastObservableCollection;
        private ObservableCollection<int> _observableCollection;

        [GlobalSetup]
        public void Init()
        {
            _fastBindingList = new FastBindingList<int> {-1, -2, -3, -4, -5, -6, -7, -8, -9, -10};
            _observableCollection = new ObservableCollection<int> {-1, -2, -3, -4, -5, -6, -7, -8, -9, -10};
            _fastObservableCollection = new FastObservableCollection<int> {-1, -2, -3, -4, -5, -6, -7, -8, -9, -10};
        }

        [Benchmark]
        public void ObservableCollection_BashInsert()
        {
            _observableCollection.AddRange(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }

        [Benchmark]
        public void FastObservableCollection_BashInsert()
        {
            _fastObservableCollection.AddItems(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }

        [Benchmark]
        public void FastBindingList_BashInsert()
        {
            _fastBindingList.AddItems(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
        }

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
            using (_fastObservableCollection.SuspendChangeNotifications(SuspensionMode.Removing))
            {
                for (var i = _fastObservableCollection.Count; i >= 0; i--)
                {
                    _fastObservableCollection.Remove(_fastObservableCollection[i]);
                }
            }
        }

        [Benchmark]
        public void FastBindingList_BashRemove()
        {
            _fastBindingList.RemoveItems(new[] {-1, -2, -3, -4, -5, -6, -7, -8, -9, -10});
        }
    }
}
