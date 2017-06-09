namespace Catel.Benchmarks.Reflection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Reflection;
    using BenchmarkDotNet.Attributes;
    using Catel.MVVM;
    using Catel.Reflection;

    public class Type_ReflectionExtensions_Benchmark : BenchmarkBase
    {
        #region Methods
        [Benchmark]
        public void IsCatelType()
        {
            typeof(Command).IsCatelType();
        }

        [Benchmark]
        public void GetParentTypes()
        {
            foreach (var type in typeof(C).GetParentTypes())
            {
            }
        }

        [Benchmark]
        public void GetSafeFullName()
        {
            typeof(C).GetSafeFullName(true);
        }

        [Benchmark]
        public void GetCustomAttributeEx()
        {
            typeof(C).GetCustomAttributeEx(typeof(CAttribute), false);
        }

        [Benchmark]
        public void GetCustomAttributeEx_Inherit()
        {
            typeof(C).GetCustomAttributeEx(typeof(AAttribute), true);
        }

        [Benchmark]
        public void GetCustomAttributesEx()
        {
            typeof(C).GetCustomAttributesEx(typeof(CAttribute), false);
        }

        [Benchmark]
        public void GetCustomAttributesEx_Inherit()
        {
            typeof(C).GetCustomAttributesEx(typeof(AAttribute), true);
        }

        [Benchmark]
        public void ContainsGenericParametersEx()
        {
            typeof(List<C>).ContainsGenericParametersEx();
        }

        [Benchmark]
        public void GetAssemblyEx()
        {
            typeof(C).GetAssemblyEx();
        }

        [Benchmark]
        public void GetAssemblyFullNameEx()
        {
            typeof(C).GetAssemblyFullNameEx();
        }

        [Benchmark]
        public void HasBaseTypeEx()
        {
            typeof(C).HasBaseTypeEx(typeof(A));
        }

        [Benchmark]
        public void IsSerializableEx()
        {
            typeof(C).IsSerializableEx();
        }

        [Benchmark]
        public void IsPublicEx()
        {
            typeof(C).IsPublicEx();
        }

        [Benchmark]
        public void IsNestedPublicEx()
        {
            typeof(C).IsNestedPublicEx();
        }

        [Benchmark]
        public void IsInterfaceEx()
        {
            typeof(IDisposable).IsInterfaceEx();
        }

        [Benchmark]
        public void IsAbstractEx()
        {
            typeof(A).IsAbstractEx();
        }

        [Benchmark]
        public void IsArrayEx()
        {
            typeof(A[]).IsArrayEx();
        }

        [Benchmark]
        public void IsClassEx()
        {
            typeof(A).IsClassEx();
        }

        [Benchmark]
        public void IsValueTypeEx()
        {
            typeof(int).IsValueTypeEx();
        }

        [Benchmark]
        public void IsGenericTypeEx()
        {
            typeof(List<A>).IsGenericTypeEx();
        }

        [Benchmark]
        public void IsGenericTypeDefinitionEx()
        {
            typeof(List<>).IsGenericTypeDefinitionEx();
        }

        [Benchmark]
        public void ImplementsInterfaceEx()
        {
            typeof(C).ImplementsInterfaceEx<INotifyPropertyChanged>();
        }

        [Benchmark]
        public void ImplementsInterfacesEx()
        {
            typeof(C).ImplementsInterfaceEx(typeof(INotifyPropertyChanged));
        }

        [Benchmark]
        public void IsPrimitiveEx()
        {
            typeof(int).IsPrimitiveEx();
        }

        [Benchmark]
        public void IsEnumEx()
        {
            typeof(EnumA).IsEnumEx();
        }

        [Benchmark]
        public void IsCOMObjectEx()
        {
            typeof(A).IsCOMObjectEx();
        }

        [Benchmark]
        public void GetGenericTypeDefinitionEx()
        {
            typeof(List<A>).GetGenericTypeDefinitionEx();
        }

        [Benchmark]
        public void GetGenericArgumentsEx()
        {
            typeof(List<A>).GetGenericArgumentsEx();
        }

        [Benchmark]
        public void GetElementTypeEx()
        {
            typeof(A).GetElementTypeEx();
        }

        [Benchmark]
        public void GetInterfacesEx()
        {
            typeof(C).GetInterfacesEx();
        }

        [Benchmark]
        public void GetBaseTypeEx()
        {
            typeof(C).GetBaseTypeEx();
        }

        [Benchmark]
        public void IsAssignableFromEx()
        {
            typeof(A).IsAssignableFromEx(typeof(C));
        }

        [Benchmark]
        public void IsInstanceOfTypeEx()
        {
            typeof(C).IsInstanceOfTypeEx(new C(null));
        }

        [Benchmark]
        public void GetConstructorEx()
        {
            typeof(C).GetConstructorEx(new[] {typeof(object)});
        }

        [Benchmark]
        public void GetConstructorsEx()
        {
            typeof(C).GetConstructorsEx();
        }

        [Benchmark]
        public void GetMemberEx_Flatten_Static()
        {
            typeof(C).GetMemberEx("DoSomething", true, true);
        }

        [Benchmark]
        public void GetMemberEx_Instance()
        {
            typeof(C).GetMemberEx("Clone", false);
        }

        [Benchmark]
        public void GetMemberEx_Flatten_Static_BindingFlags()
        {
            typeof(C).GetMemberEx("DoSomething", BindingFlags.Static | BindingFlags.FlattenHierarchy);
        }

        [Benchmark]
        public void GetMemberEx_Instance_BindingFlags()
        {
            typeof(C).GetMemberEx("Clone", BindingFlags.Instance);
        }

        [Benchmark]
        public void GetMethodEx_Flatten_Static()
        {
            typeof(C).GetMethodEx("DoSomething", true, true);
        }

        [Benchmark]
        public void GetMethodEx_Instance()
        {
            typeof(C).GetMethodEx("Clone", false);
        }

        [Benchmark]
        public void GetMethodEx_Flatten_Static_BindingFlags()
        {
            typeof(C).GetMethodEx("DoSomething", BindingFlags.Static | BindingFlags.FlattenHierarchy);
        }

        [Benchmark]
        public void GetMethodEx_Instance_BindingFlags()
        {
            typeof(C).GetMethodEx("Clone", BindingFlags.Instance);
        }

        [Benchmark]
        public void GetMethodsEx_Flatten_Static()
        {
            typeof(C).GetMethodsEx(true, true);
        }

        [Benchmark]
        public void GetMethodsEx_Instance()
        {
            typeof(C).GetMethodsEx(false);
        }

        [Benchmark]
        public void GetMethodsEx_Flatten_Static_BindingFlags()
        {
            typeof(C).GetMethodsEx(BindingFlags.Static | BindingFlags.FlattenHierarchy);
        }

        [Benchmark]
        public void GetMethodsEx_Instance_BindingFlags()
        {
            typeof(C).GetMethodsEx(BindingFlags.Instance);
        }

        [Benchmark]
        public void GetTypeInfo()
        {
            typeof(C).GetTypeInfo();
        }

        [Benchmark]
        public void GetFieldEx_Flatten_Static()
        {
            typeof(C).GetFieldEx("_afield", true, true);
        }

        [Benchmark]
        public void GetFieldEx_Instance()
        {
            typeof(C).GetFieldEx("_cfield", false);
        }

        [Benchmark]
        public void GetFieldEx_Flatten_Static_BindingFlags()
        {
            typeof(C).GetFieldEx("_afield", BindingFlags.Static | BindingFlags.FlattenHierarchy);
        }

        [Benchmark]
        public void GetPropertyEx_Flatten_Static()
        {
            typeof(C).GetPropertyEx("AProperty", true, true);
        }

        [Benchmark]
        public void GetPropertyEx_Instance()
        {
            typeof(C).GetPropertyEx("CProperty", false);
        }

        [Benchmark]
        public void GetPropertyEx_Static_BindingFlags()
        {
            typeof(C).GetPropertyEx("AProperty", BindingFlags.Static | BindingFlags.FlattenHierarchy);
        }

        [Benchmark]
        public void GetEventEx_Flatten_Static()
        {
            typeof(C).GetEventEx("AEvent", true, true);
        }

        [Benchmark]
        public void GetEventEx_Instance()
        {
            typeof(C).GetEventEx("CEvent", false);
        }

        [Benchmark]
        public void GetEventEx_Static_BindingFlags()
        {
            typeof(C).GetPropertyEx("AEvent", BindingFlags.Static | BindingFlags.FlattenHierarchy);
        }

        [Benchmark]
        public void GetPropertiesEx_Flatten_Static()
        {
            typeof(C).GetPropertiesEx(true, true);
        }

        [Benchmark]
        public void GetPropertiesEx_Instance()
        {
            typeof(C).GetPropertiesEx(false);
        }

        [Benchmark]
        public void GetPropertiesEx_Static_BindingFlags()
        {
            typeof(C).GetPropertiesEx(BindingFlags.Static | BindingFlags.FlattenHierarchy);
        }

        [Benchmark]
        public void GetEventsEx_Flatten_Static()
        {
            typeof(C).GetEventsEx(true, true);
        }

        [Benchmark]
        public void GetEventsEx_Instance()
        {
            typeof(C).GetEventsEx(false);
        }

        [Benchmark]
        public void GetFieldsEx_Static()
        {
            typeof(C).GetFieldsEx(true, true);
        }

        [Benchmark]
        public void GetFieldsEx()
        {
            typeof(C).GetFieldsEx();
        }

        [Benchmark]
        public void GetFieldsEx_Static_BindingFlags()
        {
            typeof(C).GetFieldsEx(BindingFlags.Static | BindingFlags.FlattenHierarchy);
        }

        [Benchmark]
        public void GetFieldsEx_BindingFlags()
        {
            typeof(C).GetFieldsEx(BindingFlags.Instance);
        }

        [Benchmark]
        public void GetFieldEx_Instance_BindingFlags()
        {
            typeof(C).GetFieldEx("_cfield", BindingFlags.Instance);
        }
        #endregion

        #region Nested type: A
        [A]
        public abstract class A : ViewModelBase
        {
            #region Constants
            private static int _afield;
            #endregion

            #region Properties
            public static int AProperty => _afield++;
            #endregion

            #region Methods
            public static void StaticMethod()
            {
            }

            private static void OnAEvent()
            {
                AEvent?.Invoke(null, EventArgs.Empty);
            }
            #endregion

            public static event EventHandler AEvent;
        }
        #endregion

        #region Nested type: AAttribute
        public class AAttribute : Attribute
        {
        }
        #endregion

        #region Nested type: B
        public class B : A, IDisposable
        {
            #region IDisposable Members
            public void Dispose()
            {
            }
            #endregion
        }
        #endregion

        #region Nested type: C
        [C]
        [Serializable]
        public class C : B, ICloneable
        {
            #region Fields
            private int _cfield;
            #endregion

            #region Constructors
            public C(object param)
            {
            }
            #endregion

            #region Properties
            public int CProperty => _cfield++;
            #endregion

            #region ICloneable Members
            public object Clone()
            {
                return new object();
            }
            #endregion

            #region Methods
            protected virtual void OnCEvent()
            {
                CEvent?.Invoke(this, EventArgs.Empty);
            }
            #endregion

            public event EventHandler CEvent;
        }
        #endregion

        #region Nested type: CAttribute
        public class CAttribute : Attribute
        {
        }
        #endregion

        #region Nested type: EnumA
        private enum EnumA
        {
        }
        #endregion
    }
}