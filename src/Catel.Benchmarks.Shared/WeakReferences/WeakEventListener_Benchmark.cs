namespace Catel.Benchmarks.WeakReferences
{
    using System;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
#if !CATEL_5_0
    using Annotations;
#endif
    using BenchmarkDotNet.Attributes;

    public class WeakEventListener_Benchmark : BenchmarkBase
    {
#region Fields
        private bool _collectionChangedEventHandler;
        private bool _computedEventHandlerExecuted;
        private Person _person4NotificationBenchmarks;
        private Person _person4SubscriptionBenchmarks;
        private ObservableCollection<Person> _persons4NotificationBenchmarks;
        private ObservableCollection<Person> _persons4SubscriptionBenchmarks;

        private bool _propertyChangedEventHandlerExecuted;
#endregion

#region Methods
        [Setup]
        public void Init()
        {
            _person4NotificationBenchmarks = new Person();
            _person4SubscriptionBenchmarks = new Person();
            _persons4NotificationBenchmarks = new ObservableCollection<Person>();
            _persons4SubscriptionBenchmarks = new ObservableCollection<Person>();

            WeakEventListener<WeakEventListener_Benchmark, Person, PropertyChangedEventArgs>.SubscribeToWeakPropertyChangedEvent(this, _person4NotificationBenchmarks, OnPropertyChanged);
            WeakEventListener<WeakEventListener_Benchmark, Person, EventArgs>.SubscribeToWeakGenericEvent(this, _person4NotificationBenchmarks, "Computed", OnComputed);
            WeakEventListener<WeakEventListener_Benchmark, ObservableCollection<Person>, NotifyCollectionChangedEventArgs>.SubscribeToWeakCollectionChangedEvent(this, _persons4NotificationBenchmarks, CollectionChanged);
        }

        private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            _collectionChangedEventHandler = true;
        }

        private void OnComputed(object sender, EventArgs e)
        {
            _computedEventHandlerExecuted = true;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            _propertyChangedEventHandlerExecuted = true;
        }

        [Benchmark]
        public void GenericEvent_Notification()
        {
            _person4NotificationBenchmarks.InvokeCompute();
            while (!_computedEventHandlerExecuted)
            {
            }
        }

        [Benchmark]
        public void CollectionChanged_Notification()
        {
            _persons4NotificationBenchmarks.Add(_person4NotificationBenchmarks);
            while (!_collectionChangedEventHandler)
            {
            }
        }

        [Benchmark]
        public void SubscribeToWeakPropertyChangedEvent()
        {
            WeakEventListener<WeakEventListener_Benchmark, Person, PropertyChangedEventArgs>.SubscribeToWeakPropertyChangedEvent(this, _person4SubscriptionBenchmarks, OnPropertyChanged);
        }

        [Benchmark]
        public void SubscribeToWeakGenericEvent()
        {
            WeakEventListener<WeakEventListener_Benchmark, Person, EventArgs>.SubscribeToWeakGenericEvent(this, _person4SubscriptionBenchmarks, "Computed", OnComputed);
        }

        [Benchmark]
        public void SubscribeToWeakCollectionChangedEvent()
        {
            WeakEventListener<WeakEventListener_Benchmark, ObservableCollection<Person>, EventArgs>.SubscribeToWeakCollectionChangedEvent(this, _persons4SubscriptionBenchmarks, CollectionChanged);
        }

        [Benchmark]
        public void PropertyChanged_Notification()
        {
            _person4NotificationBenchmarks.Name = "Alex";
            while (!_propertyChangedEventHandlerExecuted)
            {
            }
        }
#endregion

#region Nested type: Person
        public class Person : INotifyPropertyChanged
        {
#region Fields
            private string _name;
#endregion

#region Properties
            public string Name
            {
                get => _name;
                set
                {
                    if (value == _name)
                        return;

                    _name = value;
                    OnPropertyChanged();
                }
            }
#endregion

#region INotifyPropertyChanged Members
            public event PropertyChangedEventHandler PropertyChanged;
#endregion

#region Methods
#if !CATEL_5_0
            [NotifyPropertyChangedInvocator]
#endif
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            protected virtual void OnComputed()
            {
                Computed?.Invoke(this, EventArgs.Empty);
            }

            public void InvokeCompute()
            {
                OnComputed();
            }
#endregion

            public event EventHandler Computed;
        }
#endregion
    }
}