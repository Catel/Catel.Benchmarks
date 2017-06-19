# Benchmarks

Benchmark report generated on 19-jun-2017 08:56

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


If versions behave the same (e.g. result in exactly the same values), this report will show the highest version to represent the most recent state at best.
If a higher version is at least 3% slower than the previous one, it will have a red background. If it is at least 3% faster, it will have a green background.

## Host environment information

BenchmarkDotNet=v0.10.6, OS=Windows 10 Redstone 2 (10.0.15063)

Processor=Intel Core i7-3960X CPU 3.30GHz (Ivy Bridge), ProcessorCount=8

Frequency=10000000 Hz, Resolution=100.0000 ns, Timer=UNKNOWN


## Table of contents
* [Argument_Benchmark](#Argument_Benchmark)
  * [ImplementsInterface](#Argument_Benchmark_ImplementsInterface)
  * [ImplementsInterface_Generic](#Argument_Benchmark_ImplementsInterface_Generic)
  * [ImplementsOneOfTheInterfaces](#Argument_Benchmark_ImplementsOneOfTheInterfaces)
  * [ImplementsOneOfTheInterfaces_Object](#Argument_Benchmark_ImplementsOneOfTheInterfaces_Object)
  * [InheritsFrom](#Argument_Benchmark_InheritsFrom)
  * [InheritsFrom_Generic](#Argument_Benchmark_InheritsFrom_Generic)
  * [InheritsFrom_Object](#Argument_Benchmark_InheritsFrom_Object)
  * [IsMatch](#Argument_Benchmark_IsMatch)
  * [IsMaximum](#Argument_Benchmark_IsMaximum)
  * [IsMinimal](#Argument_Benchmark_IsMinimal)
  * [IsNotEmpty](#Argument_Benchmark_IsNotEmpty)
  * [IsNotMatch](#Argument_Benchmark_IsNotMatch)
  * [IsNotNull](#Argument_Benchmark_IsNotNull)
  * [IsNotNullOrEmpty](#Argument_Benchmark_IsNotNullOrEmpty)
  * [IsNotNullOrEmpty_Guid](#Argument_Benchmark_IsNotNullOrEmpty_Guid)
  * [IsNotNullOrEmptyArray](#Argument_Benchmark_IsNotNullOrEmptyArray)
  * [IsNotNullOrWhitespace](#Argument_Benchmark_IsNotNullOrWhitespace)
  * [IsNotOfOneOfTheTypes](#Argument_Benchmark_IsNotOfOneOfTheTypes)
  * [IsNotOfOneOfTheTypes_Object](#Argument_Benchmark_IsNotOfOneOfTheTypes_Object)
  * [IsNotOfType](#Argument_Benchmark_IsNotOfType)
  * [IsNotOfType_Object](#Argument_Benchmark_IsNotOfType_Object)
  * [IsNotOutOfRange](#Argument_Benchmark_IsNotOutOfRange)
  * [IsOfOneOfTheTypes](#Argument_Benchmark_IsOfOneOfTheTypes)
  * [IsOfOneOfTheTypes_Object](#Argument_Benchmark_IsOfOneOfTheTypes_Object)
  * [IsOfType](#Argument_Benchmark_IsOfType)
  * [IsOfType_Object](#Argument_Benchmark_IsOfType_Object)
* [Assembly_ReflectionExtensions_Benchmark](#Assembly_ReflectionExtensions_Benchmark)
  * [GetCustomAttributeEx](#Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx)
  * [GetCustomAttributesEx](#Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx)
  * [GetExportedTypesEx](#Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx)
  * [GetTypesEx](#Assembly_ReflectionExtensions_Benchmark_GetTypesEx)
* [AssemblyExtensions__Benchmark](#AssemblyExtensions__Benchmark)
  * [Company](#AssemblyExtensions__Benchmark_Company)
  * [Copyright](#AssemblyExtensions__Benchmark_Copyright)
  * [Description](#AssemblyExtensions__Benchmark_Description)
  * [GetBuildDateTime](#AssemblyExtensions__Benchmark_GetBuildDateTime)
  * [GetDirectory](#AssemblyExtensions__Benchmark_GetDirectory)
  * [InformationalVersion](#AssemblyExtensions__Benchmark_InformationalVersion)
  * [Product](#AssemblyExtensions__Benchmark_Product)
  * [Title](#AssemblyExtensions__Benchmark_Title)
  * [Version](#AssemblyExtensions__Benchmark_Version)
* [AssemblyExtensions_Benchmark](#AssemblyExtensions_Benchmark)
  * [Company](#AssemblyExtensions_Benchmark_Company)
  * [Copyright](#AssemblyExtensions_Benchmark_Copyright)
  * [Description](#AssemblyExtensions_Benchmark_Description)
  * [GetBuildDateTime](#AssemblyExtensions_Benchmark_GetBuildDateTime)
  * [GetDirectory](#AssemblyExtensions_Benchmark_GetDirectory)
  * [InformationalVersion](#AssemblyExtensions_Benchmark_InformationalVersion)
  * [Product](#AssemblyExtensions_Benchmark_Product)
  * [Title](#AssemblyExtensions_Benchmark_Title)
  * [Version](#AssemblyExtensions_Benchmark_Version)
* [Attribute_ReflectionExtensions_Benchmark](#Attribute_ReflectionExtensions_Benchmark)
  * [GetAttribute_From_Member](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member)
  * [GetAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type)
  * [GetAttribute_Generic_From_Member](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member)
  * [GetAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type)
  * [IsDecoratedWithAttribute_From_Member](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member)
  * [IsDecoratedWithAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type)
  * [IsDecoratedWithAttribute_Generic_From_Member](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member)
  * [IsDecoratedWithAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type)
  * [TryGetAttribute_From_Member](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member)
  * [TryGetAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type)
  * [TryGetAttribute_Generic_From_Member](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member)
  * [TryGetAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type)
* [CacheStorage_Benchmark](#CacheStorage_Benchmark)
  * [Clear_Cache](#CacheStorage_Benchmark_Clear_Cache)
  * [GetFromCacheOrFetch](#CacheStorage_Benchmark_GetFromCacheOrFetch)
  * [GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy](#CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy)
  * [GetValue_From_An_Already_Initialized_Cache](#CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache)
  * [Overwrite_An_Existing_Cached_Value](#CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value)
  * [RemoveItem_From_Cache](#CacheStorage_Benchmark_RemoveItem_From_Cache)
* [Enum_Benchmark](#Enum_Benchmark)
  * [ConvertFromOtherEnumValue](#Enum_Benchmark_ConvertFromOtherEnumValue)
  * [GetName](#Enum_Benchmark_GetName)
  * [GetName_Long](#Enum_Benchmark_GetName_Long)
  * [GetNames](#Enum_Benchmark_GetNames)
  * [GetValues](#Enum_Benchmark_GetValues)
  * [Parse](#Enum_Benchmark_Parse)
  * [ToList](#Enum_Benchmark_ToList)
  * [TryParse](#Enum_Benchmark_TryParse)
  * [TryParse_IgnoreCase](#Enum_Benchmark_TryParse_IgnoreCase)
  * [TryParse_IgnoreCase_Nullable](#Enum_Benchmark_TryParse_IgnoreCase_Nullable)
  * [TryParse_Nullable](#Enum_Benchmark_TryParse_Nullable)
* [FastDateTime_vs_DateTime_Benchmark](#FastDateTime_vs_DateTime_Benchmark)
  * [DateTime_Now](#FastDateTime_vs_DateTime_Benchmark_DateTime_Now)
  * [FastDateTime_Now](#FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now)
* [FastDateTime_vs_DateTime_UtcNow_Benchmark](#FastDateTime_vs_DateTime_UtcNow_Benchmark)
  * [DateTime_UtcNow](#FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow)
  * [FastDateTime_UtcNow](#FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow)
* [FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark)
  * [FastBindingList_BashInsert](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashInsert)
  * [FastBindingList_BashRemove](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashRemove)
  * [FastObservableCollection_BashInsert](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastObservableCollection_BashInsert)
  * [ObservableCollection_BashInsert](#FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_ObservableCollection_BashInsert)
* [Log_Disabled_Benchmark](#Log_Disabled_Benchmark)
  * [Log_Info](#Log_Disabled_Benchmark_Log_Info)
  * [Log_Info_Format_WithBoxing](#Log_Disabled_Benchmark_Log_Info_Format_WithBoxing)
  * [Log_Info_Format_WithoutBoxing](#Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing)
* [Log_Enabled_Benchmark](#Log_Enabled_Benchmark)
  * [Log_Info](#Log_Enabled_Benchmark_Log_Info)
  * [Log_Info_Format_WithBoxing](#Log_Enabled_Benchmark_Log_Info_Format_WithBoxing)
  * [Log_Info_Format_WithoutBoxing](#Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing)
* [MemberInfoExtensions_Benchmark](#MemberInfoExtensions_Benchmark)
  * [GetSignature_Constructor](#MemberInfoExtensions_Benchmark_GetSignature_Constructor)
  * [GetSignature_Method](#MemberInfoExtensions_Benchmark_GetSignature_Method)
* [MethodInfo_ReflectionExtensions_Benchmark](#MethodInfo_ReflectionExtensions_Benchmark)
  * [GetCustomAttributeEx](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx)
  * [GetCustomAttributeEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit)
  * [GetCustomAttributesEx](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx)
  * [GetCustomAttributesEx_AttributeType](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType)
  * [GetCustomAttributesEx_AttributeType__Inheritd](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd)
  * [GetCustomAttributesEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit)
* [ModelBase_Constructor_Benchmark](#ModelBase_Constructor_Benchmark)
  * [Constructor](#ModelBase_Constructor_Benchmark_Constructor)
* [ModelBase_EqualityComparer_Benchmark](#ModelBase_EqualityComparer_Benchmark)
  * [EqualityComparer](#ModelBase_EqualityComparer_Benchmark_EqualityComparer)
  * [GetHashCode_](#ModelBase_EqualityComparer_Benchmark_GetHashCode_)
* [ModelBase_GetValue_Benchmark](#ModelBase_GetValue_Benchmark)
  * [GetBoolValue](#ModelBase_GetValue_Benchmark_GetBoolValue)
  * [GetIntValue](#ModelBase_GetValue_Benchmark_GetIntValue)
  * [GetStringValue](#ModelBase_GetValue_Benchmark_GetStringValue)
* [ModelBase_SetValue_Benchmark](#ModelBase_SetValue_Benchmark)
  * [SetBoolValue](#ModelBase_SetValue_Benchmark_SetBoolValue)
  * [SetIntValue](#ModelBase_SetValue_Benchmark_SetIntValue)
  * [SetStringValue](#ModelBase_SetValue_Benchmark_SetStringValue)
* [PropertyBag_GetPropertyValue_Benchmark](#PropertyBag_GetPropertyValue_Benchmark)
  * [GetBoolValue](#PropertyBag_GetPropertyValue_Benchmark_GetBoolValue)
  * [GetIntValue](#PropertyBag_GetPropertyValue_Benchmark_GetIntValue)
  * [GetStringValue](#PropertyBag_GetPropertyValue_Benchmark_GetStringValue)
* [PropertyBag_SetPropertyValue_Benchmark](#PropertyBag_SetPropertyValue_Benchmark)
  * [SetBoolValue](#PropertyBag_SetPropertyValue_Benchmark_SetBoolValue)
  * [SetIntValue](#PropertyBag_SetPropertyValue_Benchmark_SetIntValue)
  * [SetStringValue](#PropertyBag_SetPropertyValue_Benchmark_SetStringValue)
* [PropertyInfo_ReflectionExtensions_Benchmark](#PropertyInfo_ReflectionExtensions_Benchmark)
  * [GetCustomAttributeEx](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx)
  * [GetCustomAttributeEx_Inherit](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit)
  * [GetCustomAttributesEx](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx)
  * [GetCustomAttributesEx_AttributeType](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType)
  * [GetCustomAttributesEx_AttributeType__Inheritd](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd)
  * [GetCustomAttributesEx_Inherit](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit)
* [ScopeManager_Benchmark](#ScopeManager_Benchmark)
  * [Get_Existing_ScopeManager](#ScopeManager_Benchmark_Get_Existing_ScopeManager)
  * [Get_New_ScopeManager](#ScopeManager_Benchmark_Get_New_ScopeManager)
* [Serialization_Binary_Benchmark](#Serialization_Binary_Benchmark)
  * [SerializeComplexObjectGraph](#Serialization_Binary_Benchmark_SerializeComplexObjectGraph)
  * [SerializeLevel1Models](#Serialization_Binary_Benchmark_SerializeLevel1Models)
  * [SerializeLevel2Models](#Serialization_Binary_Benchmark_SerializeLevel2Models)
  * [SerializeLevel3Models](#Serialization_Binary_Benchmark_SerializeLevel3Models)
* [Serialization_Json_Benchmark](#Serialization_Json_Benchmark)
  * [SerializeComplexObjectGraph](#Serialization_Json_Benchmark_SerializeComplexObjectGraph)
  * [SerializeLevel1Models](#Serialization_Json_Benchmark_SerializeLevel1Models)
  * [SerializeLevel2Models](#Serialization_Json_Benchmark_SerializeLevel2Models)
  * [SerializeLevel3Models](#Serialization_Json_Benchmark_SerializeLevel3Models)
* [Serialization_Xml_Benchmark](#Serialization_Xml_Benchmark)
  * [SerializeComplexObjectGraph](#Serialization_Xml_Benchmark_SerializeComplexObjectGraph)
  * [SerializeLevel1Models](#Serialization_Xml_Benchmark_SerializeLevel1Models)
  * [SerializeLevel2Models](#Serialization_Xml_Benchmark_SerializeLevel2Models)
  * [SerializeLevel3Models](#Serialization_Xml_Benchmark_SerializeLevel3Models)
* [ServiceLocator_Benchmark](#ServiceLocator_Benchmark)
  * [RegisterType](#ServiceLocator_Benchmark_RegisterType)
  * [ResolveType_Singleton](#ServiceLocator_Benchmark_ResolveType_Singleton)
  * [ResolveType_Transient](#ServiceLocator_Benchmark_ResolveType_Transient)
  * [ResolveType_With_Singleton_Dependency](#ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency)
  * [ResolveType_With_Transient_Dependency](#ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency)
* [Type_ReflectionExtensions_Benchmark](#Type_ReflectionExtensions_Benchmark)
  * [ContainsGenericParametersEx](#Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx)
  * [GetAssemblyEx](#Type_ReflectionExtensions_Benchmark_GetAssemblyEx)
  * [GetAssemblyFullNameEx](#Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx)
  * [GetBaseTypeEx](#Type_ReflectionExtensions_Benchmark_GetBaseTypeEx)
  * [GetConstructorEx](#Type_ReflectionExtensions_Benchmark_GetConstructorEx)
  * [GetConstructorsEx](#Type_ReflectionExtensions_Benchmark_GetConstructorsEx)
  * [GetCustomAttributeEx](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx)
  * [GetCustomAttributeEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit)
  * [GetCustomAttributesEx](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx)
  * [GetCustomAttributesEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit)
  * [GetElementTypeEx](#Type_ReflectionExtensions_Benchmark_GetElementTypeEx)
  * [GetEventEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static)
  * [GetEventEx_Instance](#Type_ReflectionExtensions_Benchmark_GetEventEx_Instance)
  * [GetEventEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags)
  * [GetEventsEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static)
  * [GetEventsEx_Instance](#Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance)
  * [GetFieldEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static)
  * [GetFieldEx_Flatten_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags)
  * [GetFieldEx_Instance](#Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance)
  * [GetFieldEx_Instance_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags)
  * [GetFieldsEx](#Type_ReflectionExtensions_Benchmark_GetFieldsEx)
  * [GetFieldsEx_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags)
  * [GetFieldsEx_Static](#Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static)
  * [GetFieldsEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags)
  * [GetGenericArgumentsEx](#Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx)
  * [GetGenericTypeDefinitionEx](#Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx)
  * [GetInterfacesEx](#Type_ReflectionExtensions_Benchmark_GetInterfacesEx)
  * [GetMemberEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static)
  * [GetMemberEx_Flatten_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags)
  * [GetMemberEx_Instance](#Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance)
  * [GetMemberEx_Instance_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags)
  * [GetMethodEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static)
  * [GetMethodEx_Flatten_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags)
  * [GetMethodEx_Instance](#Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance)
  * [GetMethodEx_Instance_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags)
  * [GetMethodsEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static)
  * [GetMethodsEx_Flatten_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags)
  * [GetMethodsEx_Instance](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance)
  * [GetMethodsEx_Instance_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags)
  * [GetParentTypes](#Type_ReflectionExtensions_Benchmark_GetParentTypes)
  * [GetPropertiesEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static)
  * [GetPropertiesEx_Instance](#Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance)
  * [GetPropertiesEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags)
  * [GetPropertyEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static)
  * [GetPropertyEx_Instance](#Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance)
  * [GetPropertyEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags)
  * [GetSafeFullName](#Type_ReflectionExtensions_Benchmark_GetSafeFullName)
  * [GetTypeInfo](#Type_ReflectionExtensions_Benchmark_GetTypeInfo)
  * [HasBaseTypeEx](#Type_ReflectionExtensions_Benchmark_HasBaseTypeEx)
  * [ImplementsInterfaceEx](#Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx)
  * [ImplementsInterfacesEx](#Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx)
  * [IsAbstractEx](#Type_ReflectionExtensions_Benchmark_IsAbstractEx)
  * [IsArrayEx](#Type_ReflectionExtensions_Benchmark_IsArrayEx)
  * [IsAssignableFromEx](#Type_ReflectionExtensions_Benchmark_IsAssignableFromEx)
  * [IsCatelType](#Type_ReflectionExtensions_Benchmark_IsCatelType)
  * [IsClassEx](#Type_ReflectionExtensions_Benchmark_IsClassEx)
  * [IsCOMObjectEx](#Type_ReflectionExtensions_Benchmark_IsCOMObjectEx)
  * [IsEnumEx](#Type_ReflectionExtensions_Benchmark_IsEnumEx)
  * [IsGenericTypeDefinitionEx](#Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx)
  * [IsGenericTypeEx](#Type_ReflectionExtensions_Benchmark_IsGenericTypeEx)
  * [IsInstanceOfTypeEx](#Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx)
  * [IsInterfaceEx](#Type_ReflectionExtensions_Benchmark_IsInterfaceEx)
  * [IsNestedPublicEx](#Type_ReflectionExtensions_Benchmark_IsNestedPublicEx)
  * [IsPrimitiveEx](#Type_ReflectionExtensions_Benchmark_IsPrimitiveEx)
  * [IsPublicEx](#Type_ReflectionExtensions_Benchmark_IsPublicEx)
  * [IsSerializableEx](#Type_ReflectionExtensions_Benchmark_IsSerializableEx)
  * [IsValueTypeEx](#Type_ReflectionExtensions_Benchmark_IsValueTypeEx)
* [TypeExtensions_Benchmark](#TypeExtensions_Benchmark)
  * [GetCollectionElementType](#TypeExtensions_Benchmark_GetCollectionElementType)
  * [IsBasicType](#TypeExtensions_Benchmark_IsBasicType)
  * [IsClassType](#TypeExtensions_Benchmark_IsClassType)
  * [IsCollection](#TypeExtensions_Benchmark_IsCollection)
  * [IsDictionary](#TypeExtensions_Benchmark_IsDictionary)
  * [IsModelBase](#TypeExtensions_Benchmark_IsModelBase)
  * [IsNullableType](#TypeExtensions_Benchmark_IsNullableType)
* [TypeFactory_Benchmark](#TypeFactory_Benchmark)
  * [CreateInstance](#TypeFactory_Benchmark_CreateInstance)
  * [CreateInstance_PropertyInjection](#TypeFactory_Benchmark_CreateInstance_PropertyInjection)
  * [CreateInstanceWithParameters](#TypeFactory_Benchmark_CreateInstanceWithParameters)
  * [CreateInstanceWithParametersAndAutoCompletion](#TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion)
* [ViewModelBase_Benchmark](#ViewModelBase_Benchmark)
  * [Construction](#ViewModelBase_Benchmark_Construction)
* [WeakEventListener_Benchmark](#WeakEventListener_Benchmark)
  * [CollectionChanged_Notification](#WeakEventListener_Benchmark_CollectionChanged_Notification)
  * [GenericEvent_Notification](#WeakEventListener_Benchmark_GenericEvent_Notification)
  * [PropertyChanged_Notification](#WeakEventListener_Benchmark_PropertyChanged_Notification)
  * [SubscribeToWeakGenericEvent](#WeakEventListener_Benchmark_SubscribeToWeakGenericEvent)
  * [SubscribeToWeakPropertyChangedEvent](#WeakEventListener_Benchmark_SubscribeToWeakPropertyChangedEvent)

## <a name="Argument_Benchmark"></a>Argument_Benchmark

### <a name="Argument_Benchmark_ImplementsInterface"></a>ImplementsInterface

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 20,217 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,9 %</td><td align="right" bgcolor="#A8D08D">-10,3 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FFFFFF">+0,0 %</td><td align="right" bgcolor="#A8D08D">-6,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">114,309 ns</td><td align="right" bgcolor="#FF4949">126,740 ns (Δ = +12,431 ns)</td><td align="right" bgcolor="#A8D08D">113,729 ns (Δ = -13,011 ns)</td><td align="right" bgcolor="#FFFFFF">114,145 ns (Δ = +0,416 ns)</td><td align="right" bgcolor="#FFFFFF">114,170 ns (Δ = +0,025 ns)</td><td align="right" bgcolor="#A8D08D">106,523 ns (Δ = -7,647 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#FF4949">0,127 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#A8D08D">0,114 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FFFFFF">0,114 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,114 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,107 μs (Δ = -0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.2.0</td>
<td align="right">4.3.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">155</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,151</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 9,837 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FF4949">+4,8 %</td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#A8D08D">-4,9 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">117,957 ns</td><td align="right" bgcolor="#A8D08D">111,689 ns (Δ = -6,268 ns)</td><td align="right" bgcolor="#FF4949">117,013 ns (Δ = +5,324 ns)</td><td align="right" bgcolor="#FFFFFF">113,688 ns (Δ = -3,324 ns)</td><td align="right" bgcolor="#A8D08D">108,120 ns (Δ = -5,568 ns)</td><td align="right" bgcolor="#FF4949">111,993 ns (Δ = +3,873 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#A8D08D">0,112 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,117 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,114 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,108 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,112 μs (Δ = +0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 18,719 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,6 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#FF4949">+6,3 %</td><td align="right" bgcolor="#A8D08D">-15,0 %</td><td align="right" bgcolor="#FF4949">+18,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">106,709 ns</td><td align="right" bgcolor="#FF4949">111,582 ns (Δ = +4,873 ns)</td><td align="right" bgcolor="#FFFFFF">109,406 ns (Δ = -2,176 ns)</td><td align="right" bgcolor="#FF4949">116,293 ns (Δ = +6,887 ns)</td><td align="right" bgcolor="#A8D08D">98,818 ns (Δ = -17,476 ns)</td><td align="right" bgcolor="#FF4949">117,537 ns (Δ = +18,719 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#FF4949">0,112 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,109 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,116 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,099 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#FF4949">0,118 μs (Δ = +0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 10,885 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#FF4949">+5,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">116,838 ns</td><td align="right" bgcolor="#FFFFFF">115,234 ns (Δ = -1,604 ns)</td><td align="right" bgcolor="#FFFFFF">115,738 ns (Δ = +0,504 ns)</td><td align="right" bgcolor="#A8D08D">110,992 ns (Δ = -4,747 ns)</td><td align="right" bgcolor="#FF4949">115,641 ns (Δ = +4,649 ns)</td><td align="right" bgcolor="#FF4949">121,877 ns (Δ = +6,236 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,117 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,116 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,111 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">0,116 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#FF4949">0,122 μs (Δ = +0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.2.0</td>
<td align="right">4.3.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">154</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><td align="right">156</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,150</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><td align="right">0,152</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 18,098 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,6 %</td><td align="right" bgcolor="#FF4949">+42,2 %</td><td align="right" bgcolor="#A8D08D">-29,6 %</td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#FFFFFF">-1,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">41,291 ns</td><td align="right" bgcolor="#A8D08D">39,376 ns (Δ = -1,916 ns)</td><td align="right" bgcolor="#FF4949">55,993 ns (Δ = +16,618 ns)</td><td align="right" bgcolor="#A8D08D">39,440 ns (Δ = -16,553 ns)</td><td align="right" bgcolor="#FFFFFF">38,327 ns (Δ = -1,113 ns)</td><td align="right" bgcolor="#FFFFFF">37,895 ns (Δ = -0,432 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#A8D08D">0,039 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,056 μs (Δ = +0,017 μs)</td><td align="right" bgcolor="#A8D08D">0,039 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#FFFFFF">0,038 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,038 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_InheritsFrom_Generic"></a>InheritsFrom_Generic

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 1,512 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,9 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#FFFFFF">-2,6 %</td><td align="right" bgcolor="#FF4949">+3,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">45,651 ns</td><td align="right" bgcolor="#FFFFFF">46,053 ns (Δ = +0,402 ns)</td><td align="right" bgcolor="#FFFFFF">45,570 ns (Δ = -0,483 ns)</td><td align="right" bgcolor="#FFFFFF">46,438 ns (Δ = +0,868 ns)</td><td align="right" bgcolor="#FFFFFF">45,243 ns (Δ = -1,195 ns)</td><td align="right" bgcolor="#FF4949">46,756 ns (Δ = +1,512 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,046 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,046 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,045 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,047 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_InheritsFrom_Object"></a>InheritsFrom_Object

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 4,028 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,8 %</td><td align="right" bgcolor="#A8D08D">-4,9 %</td><td align="right" bgcolor="#FFFFFF">+3,0 %</td><td align="right" bgcolor="#A8D08D">-6,7 %</td><td align="right" bgcolor="#FFFFFF">+2,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">46,038 ns</td><td align="right" bgcolor="#FFFFFF">46,861 ns (Δ = +0,823 ns)</td><td align="right" bgcolor="#A8D08D">44,569 ns (Δ = -2,292 ns)</td><td align="right" bgcolor="#FFFFFF">45,886 ns (Δ = +1,317 ns)</td><td align="right" bgcolor="#A8D08D">42,833 ns (Δ = -3,053 ns)</td><td align="right" bgcolor="#FFFFFF">43,813 ns (Δ = +0,980 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,045 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,046 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,043 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,044 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsMatch"></a>IsMatch

#### Performance

Fastest: **4.4.0**

Slowest: 4.2.0

Δ: 341,384 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,3 %</td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#FFFFFF">+2,6 %</td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#A8D08D">-3,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1053,875 ns</td><td align="right" bgcolor="#A8D08D">713,778 ns (Δ = -340,097 ns)</td><td align="right" bgcolor="#FFFFFF">712,491 ns (Δ = -1,287 ns)</td><td align="right" bgcolor="#FFFFFF">730,952 ns (Δ = +18,461 ns)</td><td align="right" bgcolor="#FF4949">754,396 ns (Δ = +23,444 ns)</td><td align="right" bgcolor="#A8D08D">730,811 ns (Δ = -23,584 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,054 μs</td><td align="right" bgcolor="#A8D08D">0,714 μs (Δ = -0,340 μs)</td><td align="right" bgcolor="#FFFFFF">0,712 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,731 μs (Δ = +0,018 μs)</td><td align="right" bgcolor="#FF4949">0,754 μs (Δ = +0,023 μs)</td><td align="right" bgcolor="#A8D08D">0,731 μs (Δ = -0,024 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsMaximum"></a>IsMaximum

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 4,551 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,0 %</td><td align="right" bgcolor="#FF4949">+8,0 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#A8D08D">-10,5 %</td><td align="right" bgcolor="#A8D08D">-10,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,093 ns</td><td align="right" bgcolor="#A8D08D">17,475 ns (Δ = -2,618 ns)</td><td align="right" bgcolor="#FF4949">18,873 ns (Δ = +1,398 ns)</td><td align="right" bgcolor="#FFFFFF">19,327 ns (Δ = +0,453 ns)</td><td align="right" bgcolor="#A8D08D">17,303 ns (Δ = -2,024 ns)</td><td align="right" bgcolor="#A8D08D">15,542 ns (Δ = -1,761 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#A8D08D">0,017 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,019 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,019 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,017 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,016 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 2,759 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,0 %</td><td align="right" bgcolor="#A8D08D">-5,7 %</td><td align="right" bgcolor="#FF4949">+3,9 %</td><td align="right" bgcolor="#A8D08D">-5,7 %</td><td align="right" bgcolor="#A8D08D">-7,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,237 ns</td><td align="right" bgcolor="#FFFFFF">19,617 ns (Δ = +0,380 ns)</td><td align="right" bgcolor="#A8D08D">18,504 ns (Δ = -1,112 ns)</td><td align="right" bgcolor="#FF4949">19,225 ns (Δ = +0,721 ns)</td><td align="right" bgcolor="#A8D08D">18,124 ns (Δ = -1,101 ns)</td><td align="right" bgcolor="#A8D08D">16,858 ns (Δ = -1,266 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,019 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,019 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,018 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,017 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **4.5.0**

Slowest: 4.4.0

Δ: 0,876 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#FF4949">+5,3 %</td><td align="right" bgcolor="#A8D08D">-10,8 %</td><td align="right" bgcolor="#FF4949">+9,5 %</td><td align="right" bgcolor="#A8D08D">-3,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,820 ns</td><td align="right" bgcolor="#FFFFFF">7,673 ns (Δ = -0,147 ns)</td><td align="right" bgcolor="#FF4949">8,082 ns (Δ = +0,409 ns)</td><td align="right" bgcolor="#A8D08D">7,207 ns (Δ = -0,876 ns)</td><td align="right" bgcolor="#FF4949">7,894 ns (Δ = +0,687 ns)</td><td align="right" bgcolor="#A8D08D">7,610 ns (Δ = -0,284 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,008 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,007 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,008 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,008 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotMatch"></a>IsNotMatch

#### Performance

Fastest: **4.5.0**

Slowest: 4.4.0

Δ: 173,993 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,1 %</td><td align="right" bgcolor="#FF4949">+31,0 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FF4949">+10,1 %</td><td align="right" bgcolor="#A8D08D">-3,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">559,064 ns</td><td align="right" bgcolor="#A8D08D">530,690 ns (Δ = -28,374 ns)</td><td align="right" bgcolor="#FF4949">695,180 ns (Δ = +164,490 ns)</td><td align="right" bgcolor="#A8D08D">521,187 ns (Δ = -173,993 ns)</td><td align="right" bgcolor="#FF4949">573,826 ns (Δ = +52,640 ns)</td><td align="right" bgcolor="#A8D08D">554,977 ns (Δ = -18,850 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,559 μs</td><td align="right" bgcolor="#A8D08D">0,531 μs (Δ = -0,028 μs)</td><td align="right" bgcolor="#FF4949">0,695 μs (Δ = +0,164 μs)</td><td align="right" bgcolor="#A8D08D">0,521 μs (Δ = -0,174 μs)</td><td align="right" bgcolor="#FF4949">0,574 μs (Δ = +0,053 μs)</td><td align="right" bgcolor="#A8D08D">0,555 μs (Δ = -0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotNull"></a>IsNotNull

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 0,938 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,9 %</td><td align="right" bgcolor="#A8D08D">-12,6 %</td><td align="right" bgcolor="#A8D08D">-49,8 %</td><td align="right" bgcolor="#FF4949">+109,3 %</td><td align="right" bgcolor="#FF4949">+29,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,324 ns</td><td align="right" bgcolor="#A8D08D">1,247 ns (Δ = -0,078 ns)</td><td align="right" bgcolor="#A8D08D">1,090 ns (Δ = -0,157 ns)</td><td align="right" bgcolor="#A8D08D">0,547 ns (Δ = -0,543 ns)</td><td align="right" bgcolor="#FF4949">1,144 ns (Δ = +0,598 ns)</td><td align="right" bgcolor="#FF4949">1,484 ns (Δ = +0,340 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#A8D08D">0,001 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,001 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,001 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,001 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,001 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 0,601 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,7 %</td><td align="right" bgcolor="#FF4949">+15,5 %</td><td align="right" bgcolor="#A8D08D">-16,7 %</td><td align="right" bgcolor="#A8D08D">-16,3 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,647 ns</td><td align="right" bgcolor="#FFFFFF">1,691 ns (Δ = +0,044 ns)</td><td align="right" bgcolor="#FF4949">1,953 ns (Δ = +0,262 ns)</td><td align="right" bgcolor="#A8D08D">1,627 ns (Δ = -0,327 ns)</td><td align="right" bgcolor="#A8D08D">1,362 ns (Δ = -0,264 ns)</td><td align="right" bgcolor="#FFFFFF">1,352 ns (Δ = -0,010 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,002 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,002 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,001 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,001 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotNullOrEmpty_Guid"></a>IsNotNullOrEmpty_Guid

#### Performance

Fastest: **4.2.0**

Slowest: 4.4.0

Δ: 2,937 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+30,6 %</td><td align="right" bgcolor="#FF4949">+5,7 %</td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#A8D08D">-5,0 %</td><td align="right" bgcolor="#FFFFFF">-2,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,711 ns</td><td align="right" bgcolor="#FF4949">10,073 ns (Δ = +2,363 ns)</td><td align="right" bgcolor="#FF4949">10,648 ns (Δ = +0,574 ns)</td><td align="right" bgcolor="#A8D08D">10,243 ns (Δ = -0,404 ns)</td><td align="right" bgcolor="#A8D08D">9,733 ns (Δ = -0,510 ns)</td><td align="right" bgcolor="#FFFFFF">9,516 ns (Δ = -0,218 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FF4949">0,010 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,011 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,010 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,010 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,010 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotNullOrEmptyArray"></a>IsNotNullOrEmptyArray

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 0,760 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,9 %</td><td align="right" bgcolor="#A8D08D">-12,5 %</td><td align="right" bgcolor="#FF4949">+13,4 %</td><td align="right" bgcolor="#A8D08D">-18,3 %</td><td align="right" bgcolor="#FF4949">+7,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,733 ns</td><td align="right" bgcolor="#FF4949">4,027 ns (Δ = +0,293 ns)</td><td align="right" bgcolor="#A8D08D">3,524 ns (Δ = -0,502 ns)</td><td align="right" bgcolor="#FF4949">3,998 ns (Δ = +0,473 ns)</td><td align="right" bgcolor="#A8D08D">3,267 ns (Δ = -0,731 ns)</td><td align="right" bgcolor="#FF4949">3,525 ns (Δ = +0,258 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FF4949">0,004 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,004 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,004 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,003 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,004 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotNullOrWhitespace"></a>IsNotNullOrWhitespace

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 7,260 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FF4949">+46,1 %</td><td align="right" bgcolor="#A8D08D">-33,2 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,918 ns</td><td align="right" bgcolor="#FFFFFF">14,986 ns (Δ = +0,068 ns)</td><td align="right" bgcolor="#FFFFFF">14,977 ns (Δ = -0,009 ns)</td><td align="right" bgcolor="#FF4949">21,877 ns (Δ = +6,900 ns)</td><td align="right" bgcolor="#A8D08D">14,617 ns (Δ = -7,260 ns)</td><td align="right" bgcolor="#FFFFFF">14,790 ns (Δ = +0,173 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,022 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes"></a>IsNotOfOneOfTheTypes

#### Performance

Fastest: **4.2.0**

Slowest: 4.3.0

Δ: 3,910 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,8 %</td><td align="right" bgcolor="#A8D08D">-4,5 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">81,367 ns</td><td align="right" bgcolor="#FF4949">85,277 ns (Δ = +3,910 ns)</td><td align="right" bgcolor="#A8D08D">81,436 ns (Δ = -3,841 ns)</td><td align="right" bgcolor="#FFFFFF">83,360 ns (Δ = +1,924 ns)</td><td align="right" bgcolor="#FFFFFF">82,410 ns (Δ = -0,950 ns)</td><td align="right" bgcolor="#FFFFFF">82,924 ns (Δ = +0,514 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FF4949">0,085 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,081 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,083 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,082 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,083 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes_Object"></a>IsNotOfOneOfTheTypes_Object

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 7,929 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#FFFFFF">+2,6 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">85,551 ns</td><td align="right" bgcolor="#FF4949">92,547 ns (Δ = +6,996 ns)</td><td align="right" bgcolor="#A8D08D">84,618 ns (Δ = -7,929 ns)</td><td align="right" bgcolor="#FFFFFF">86,828 ns (Δ = +2,210 ns)</td><td align="right" bgcolor="#FFFFFF">86,730 ns (Δ = -0,097 ns)</td><td align="right" bgcolor="#FFFFFF">86,465 ns (Δ = -0,265 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FF4949">0,093 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,085 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,087 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,087 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,086 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotOfType"></a>IsNotOfType

#### Performance

Fastest: **4.2.0**

Slowest: 4.4.0

Δ: 14,039 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,7 %</td><td align="right" bgcolor="#FF4949">+23,1 %</td><td align="right" bgcolor="#A8D08D">-19,7 %</td><td align="right" bgcolor="#FF4949">+19,9 %</td><td align="right" bgcolor="#A8D08D">-14,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">55,691 ns</td><td align="right" bgcolor="#FFFFFF">56,650 ns (Δ = +0,959 ns)</td><td align="right" bgcolor="#FF4949">69,730 ns (Δ = +13,080 ns)</td><td align="right" bgcolor="#A8D08D">56,027 ns (Δ = -13,703 ns)</td><td align="right" bgcolor="#FF4949">67,167 ns (Δ = +11,140 ns)</td><td align="right" bgcolor="#A8D08D">57,287 ns (Δ = -9,880 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,070 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#A8D08D">0,056 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FF4949">0,067 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,057 μs (Δ = -0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotOfType_Object"></a>IsNotOfType_Object

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 37,338 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,9 %</td><td align="right" bgcolor="#A8D08D">-14,4 %</td><td align="right" bgcolor="#FF4949">+55,1 %</td><td align="right" bgcolor="#A8D08D">-37,0 %</td><td align="right" bgcolor="#FFFFFF">+1,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">62,986 ns</td><td align="right" bgcolor="#FF4949">75,518 ns (Δ = +12,532 ns)</td><td align="right" bgcolor="#A8D08D">64,667 ns (Δ = -10,851 ns)</td><td align="right" bgcolor="#FF4949">100,323 ns (Δ = +35,657 ns)</td><td align="right" bgcolor="#A8D08D">63,161 ns (Δ = -37,163 ns)</td><td align="right" bgcolor="#FFFFFF">64,323 ns (Δ = +1,163 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FF4949">0,076 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#A8D08D">0,065 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#FF4949">0,100 μs (Δ = +0,036 μs)</td><td align="right" bgcolor="#A8D08D">0,063 μs (Δ = -0,037 μs)</td><td align="right" bgcolor="#FFFFFF">0,064 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsNotOutOfRange"></a>IsNotOutOfRange

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 3,710 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,7 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#A8D08D">-5,9 %</td><td align="right" bgcolor="#A8D08D">-5,5 %</td><td align="right" bgcolor="#FFFFFF">-2,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">27,336 ns</td><td align="right" bgcolor="#FF4949">28,610 ns (Δ = +1,274 ns)</td><td align="right" bgcolor="#FFFFFF">28,574 ns (Δ = -0,036 ns)</td><td align="right" bgcolor="#A8D08D">26,887 ns (Δ = -1,687 ns)</td><td align="right" bgcolor="#A8D08D">25,413 ns (Δ = -1,473 ns)</td><td align="right" bgcolor="#FFFFFF">24,900 ns (Δ = -0,513 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FF4949">0,029 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,029 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,027 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,025 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,025 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes"></a>IsOfOneOfTheTypes

#### Performance

Fastest: **4.4.0**

Slowest: 4.2.0

Δ: 33,733 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,3 %</td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#FFFFFF">+2,6 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">91,723 ns</td><td align="right" bgcolor="#A8D08D">61,203 ns (Δ = -30,521 ns)</td><td align="right" bgcolor="#A8D08D">57,991 ns (Δ = -3,212 ns)</td><td align="right" bgcolor="#FFFFFF">59,481 ns (Δ = +1,490 ns)</td><td align="right" bgcolor="#FFFFFF">58,344 ns (Δ = -1,137 ns)</td><td align="right" bgcolor="#FFFFFF">59,247 ns (Δ = +0,902 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#A8D08D">0,061 μs (Δ = -0,031 μs)</td><td align="right" bgcolor="#A8D08D">0,058 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,059 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,058 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,059 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes_Object"></a>IsOfOneOfTheTypes_Object

#### Performance

Fastest: **4.2.0**

Slowest: 4.3.0

Δ: 4,932 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,8 %</td><td align="right" bgcolor="#A8D08D">-5,4 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FFFFFF">+1,6 %</td><td align="right" bgcolor="#FFFFFF">+1,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">62,900 ns</td><td align="right" bgcolor="#FF4949">67,832 ns (Δ = +4,932 ns)</td><td align="right" bgcolor="#A8D08D">64,163 ns (Δ = -3,668 ns)</td><td align="right" bgcolor="#FFFFFF">64,393 ns (Δ = +0,229 ns)</td><td align="right" bgcolor="#FFFFFF">65,395 ns (Δ = +1,003 ns)</td><td align="right" bgcolor="#FFFFFF">66,507 ns (Δ = +1,112 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FF4949">0,068 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,064 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,064 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,065 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,067 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsOfType"></a>IsOfType

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 6,213 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FFFFFF">-1,7 %</td><td align="right" bgcolor="#FF4949">+6,5 %</td><td align="right" bgcolor="#A8D08D">-3,7 %</td><td align="right" bgcolor="#FF4949">+12,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">41,223 ns</td><td align="right" bgcolor="#FFFFFF">40,606 ns (Δ = -0,617 ns)</td><td align="right" bgcolor="#FFFFFF">39,907 ns (Δ = -0,700 ns)</td><td align="right" bgcolor="#FF4949">42,503 ns (Δ = +2,596 ns)</td><td align="right" bgcolor="#A8D08D">40,933 ns (Δ = -1,569 ns)</td><td align="right" bgcolor="#FF4949">46,120 ns (Δ = +5,187 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,040 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,043 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,041 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,046 μs (Δ = +0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Argument_Benchmark_IsOfType_Object"></a>IsOfType_Object

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 3,951 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,2 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FFFFFF">+2,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">47,042 ns</td><td align="right" bgcolor="#FF4949">49,484 ns (Δ = +2,443 ns)</td><td align="right" bgcolor="#A8D08D">47,561 ns (Δ = -1,923 ns)</td><td align="right" bgcolor="#FFFFFF">47,192 ns (Δ = -0,369 ns)</td><td align="right" bgcolor="#A8D08D">45,533 ns (Δ = -1,658 ns)</td><td align="right" bgcolor="#FFFFFF">46,440 ns (Δ = +0,907 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FF4949">0,049 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,048 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,047 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,046 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,046 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="Assembly_ReflectionExtensions_Benchmark"></a>Assembly_ReflectionExtensions_Benchmark

### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 3051,327 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+39,0 %</td><td align="right" bgcolor="#A8D08D">-28,3 %</td><td align="right" bgcolor="#FFFFFF">+3,0 %</td><td align="right" bgcolor="#FF4949">+30,8 %</td><td align="right" bgcolor="#A8D08D">-23,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7753,233 ns</td><td align="right" bgcolor="#FF4949">10778,330 ns (Δ = +3025,097 ns)</td><td align="right" bgcolor="#A8D08D">7727,003 ns (Δ = -3051,327 ns)</td><td align="right" bgcolor="#FFFFFF">7956,020 ns (Δ = +229,017 ns)</td><td align="right" bgcolor="#FF4949">10406,957 ns (Δ = +2450,937 ns)</td><td align="right" bgcolor="#A8D08D">7982,425 ns (Δ = -2424,532 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,753 μs</td><td align="right" bgcolor="#FF4949">10,778 μs (Δ = +3,025 μs)</td><td align="right" bgcolor="#A8D08D">7,727 μs (Δ = -3,051 μs)</td><td align="right" bgcolor="#FFFFFF">7,956 μs (Δ = +0,229 μs)</td><td align="right" bgcolor="#FF4949">10,407 μs (Δ = +2,451 μs)</td><td align="right" bgcolor="#A8D08D">7,982 μs (Δ = -2,425 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FF4949">0,011 ms (Δ = +0,003 ms)</td><td align="right" bgcolor="#A8D08D">0,008 ms (Δ = -0,003 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,008 ms (Δ = -0,002 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 235,254 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,3 %</td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FFFFFF">-1,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7719,770 ns</td><td align="right" bgcolor="#FFFFFF">7894,596 ns (Δ = +174,826 ns)</td><td align="right" bgcolor="#FFFFFF">7930,400 ns (Δ = +35,804 ns)</td><td align="right" bgcolor="#FFFFFF">7866,522 ns (Δ = -63,878 ns)</td><td align="right" bgcolor="#FFFFFF">7827,493 ns (Δ = -39,029 ns)</td><td align="right" bgcolor="#FFFFFF">7695,146 ns (Δ = -132,347 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,720 μs</td><td align="right" bgcolor="#FFFFFF">7,895 μs (Δ = +0,175 μs)</td><td align="right" bgcolor="#FFFFFF">7,930 μs (Δ = +0,036 μs)</td><td align="right" bgcolor="#FFFFFF">7,867 μs (Δ = -0,064 μs)</td><td align="right" bgcolor="#FFFFFF">7,827 μs (Δ = -0,039 μs)</td><td align="right" bgcolor="#FFFFFF">7,695 μs (Δ = -0,132 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><td align="right">729</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><td align="right">0,712</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **4.5.0**

Slowest: 4.5.4

Δ: 832,477 ns


<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,2 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13396,270 ns</td><td align="right" bgcolor="#FF4949">14228,747 ns (Δ = +832,477 ns)</td><td align="right" bgcolor="#FFFFFF">14081,624 ns (Δ = -147,123 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13,396 μs</td><td align="right" bgcolor="#FF4949">14,229 μs (Δ = +0,832 μs)</td><td align="right" bgcolor="#FFFFFF">14,082 μs (Δ = -0,147 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FF4949">0,014 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,014 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.5.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1212</td><td align="right">1229</td><td align="right">1229</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,184</td><td align="right">1,200</td><td align="right">1,200</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0

Δ: 6291,455 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,1 %</td><td align="right" bgcolor="#FF4949">+40,3 %</td><td align="right" bgcolor="#A8D08D">-28,8 %</td><td align="right" bgcolor="#FFFFFF">-1,9 %</td><td align="right" bgcolor="#FF4949">+110,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5485,149 ns</td><td align="right" bgcolor="#FF4949">5710,520 ns (Δ = +225,371 ns)</td><td align="right" bgcolor="#FF4949">8010,283 ns (Δ = +2299,763 ns)</td><td align="right" bgcolor="#A8D08D">5705,513 ns (Δ = -2304,770 ns)</td><td align="right" bgcolor="#FFFFFF">5597,650 ns (Δ = -107,863 ns)</td><td align="right" bgcolor="#FF4949">11776,604 ns (Δ = +6178,954 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,485 μs</td><td align="right" bgcolor="#FF4949">5,711 μs (Δ = +0,225 μs)</td><td align="right" bgcolor="#FF4949">8,010 μs (Δ = +2,300 μs)</td><td align="right" bgcolor="#A8D08D">5,706 μs (Δ = -2,305 μs)</td><td align="right" bgcolor="#FFFFFF">5,598 μs (Δ = -0,108 μs)</td><td align="right" bgcolor="#FF4949">11,777 μs (Δ = +6,179 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = -0,002 ms)</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,012 ms (Δ = +0,006 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.2.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">2660</td><td align="right">2662</td><td align="right">2662</td><td align="right">2662</td><td align="right">2695</td><td align="right">2695</td><tr>
<td>Allocated Kilobytes</td><td align="right">2,598</td><td align="right">2,600</td><td align="right">2,600</td><td align="right">2,600</td><td align="right">2,632</td><td align="right">2,632</td><tr>
<td>Allocated Megabytes</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td></tr>
</table>


## <a name="AssemblyExtensions__Benchmark"></a>AssemblyExtensions__Benchmark

### <a name="AssemblyExtensions__Benchmark_Company"></a>Company

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9558,343 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,558 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">80</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">832</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,813</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9830,104 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,830 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">80</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">880</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,859</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_Description"></a>Description

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9359,122 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,359 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">80</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">848</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,828</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">881935,341 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">881,935 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,882 ms</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">50</td></tr>
<tr>
<td>Gen 1</td><td align="right">20</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">35328</td><tr>
<td>Allocated Kilobytes</td><td align="right">34,500</td><tr>
<td>Allocated Megabytes</td><td align="right">0,034</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2783,894 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,784 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">410</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1008</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,984</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7630,665 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,631 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">70</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">768</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,750</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_Product"></a>Product

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9817,318 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,817 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">80</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">848</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,828</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_Title"></a>Title

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10362,241 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10,362 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">80</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">848</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,828</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions__Benchmark_Version"></a>Version

#### Performance

Fastest: **4.2.0**

Slowest: 4.2.0

Δ: 0,000 ns


<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">969,730 ns</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,970 μs</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.2.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">1020</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1232</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,203</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td></tr>
</table>


## <a name="AssemblyExtensions_Benchmark"></a>AssemblyExtensions_Benchmark

### <a name="AssemblyExtensions_Benchmark_Company"></a>Company

#### Performance

Fastest: **4.5.0**

Slowest: 4.5.4

Δ: 1846,787 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#FF4949">+18,5 %</td><td align="right" bgcolor="#A8D08D">-15,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10231,857 ns</td><td align="right" bgcolor="#FFFFFF">10147,887 ns (Δ = -83,970 ns)</td><td align="right" bgcolor="#FFFFFF">10299,673 ns (Δ = +151,787 ns)</td><td align="right" bgcolor="#A8D08D">9967,533 ns (Δ = -332,140 ns)</td><td align="right" bgcolor="#FF4949">11814,320 ns (Δ = +1846,787 ns)</td><td align="right" bgcolor="#A8D08D">10000,283 ns (Δ = -1814,037 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10,232 μs</td><td align="right" bgcolor="#FFFFFF">10,148 μs (Δ = -0,084 μs)</td><td align="right" bgcolor="#FFFFFF">10,300 μs (Δ = +0,152 μs)</td><td align="right" bgcolor="#A8D08D">9,968 μs (Δ = -0,332 μs)</td><td align="right" bgcolor="#FF4949">11,814 μs (Δ = +1,847 μs)</td><td align="right" bgcolor="#A8D08D">10,000 μs (Δ = -1,814 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,012 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,010 ms (Δ = -0,002 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">836</td><td align="right">836</td><td align="right">836</td><td align="right">836</td><td align="right">836</td><td align="right">836</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,816</td><td align="right">0,816</td><td align="right">0,816</td><td align="right">0,816</td><td align="right">0,816</td><td align="right">0,816</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 903,427 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,6 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10856,793 ns</td><td align="right" bgcolor="#A8D08D">10034,993 ns (Δ = -821,800 ns)</td><td align="right" bgcolor="#FFFFFF">9963,977 ns (Δ = -71,017 ns)</td><td align="right" bgcolor="#FFFFFF">10104,887 ns (Δ = +140,910 ns)</td><td align="right" bgcolor="#FFFFFF">9953,367 ns (Δ = -151,520 ns)</td><td align="right" bgcolor="#FFFFFF">10081,260 ns (Δ = +127,893 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10,857 μs</td><td align="right" bgcolor="#A8D08D">10,035 μs (Δ = -0,822 μs)</td><td align="right" bgcolor="#FFFFFF">9,964 μs (Δ = -0,071 μs)</td><td align="right" bgcolor="#FFFFFF">10,105 μs (Δ = +0,141 μs)</td><td align="right" bgcolor="#FFFFFF">9,953 μs (Δ = -0,152 μs)</td><td align="right" bgcolor="#FFFFFF">10,081 μs (Δ = +0,128 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#A8D08D">0,010 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">885</td><td align="right">885</td><td align="right">885</td><td align="right">885</td><td align="right">885</td><td align="right">885</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,864</td><td align="right">0,864</td><td align="right">0,864</td><td align="right">0,864</td><td align="right">0,864</td><td align="right">0,864</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Description"></a>Description

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 1281,287 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,2 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#A8D08D">-4,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10963,758 ns</td><td align="right" bgcolor="#A8D08D">9740,432 ns (Δ = -1223,325 ns)</td><td align="right" bgcolor="#FFFFFF">9705,110 ns (Δ = -35,322 ns)</td><td align="right" bgcolor="#FF4949">10186,607 ns (Δ = +481,497 ns)</td><td align="right" bgcolor="#FFFFFF">10176,970 ns (Δ = -9,637 ns)</td><td align="right" bgcolor="#A8D08D">9682,471 ns (Δ = -494,499 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10,964 μs</td><td align="right" bgcolor="#A8D08D">9,740 μs (Δ = -1,223 μs)</td><td align="right" bgcolor="#FFFFFF">9,705 μs (Δ = -0,035 μs)</td><td align="right" bgcolor="#FF4949">10,187 μs (Δ = +0,481 μs)</td><td align="right" bgcolor="#FFFFFF">10,177 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#A8D08D">9,682 μs (Δ = -0,494 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#A8D08D">0,010 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,010 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 501333,259 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,0 %</td><td align="right" bgcolor="#A8D08D">-7,2 %</td><td align="right" bgcolor="#A8D08D">-43,1 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">922722,183 ns</td><td align="right" bgcolor="#FF4949">1005737,063 ns (Δ = +83014,880 ns)</td><td align="right" bgcolor="#A8D08D">933075,323 ns (Δ = -72661,740 ns)</td><td align="right" bgcolor="#A8D08D">530786,477 ns (Δ = -402288,847 ns)</td><td align="right" bgcolor="#FFFFFF">525979,124 ns (Δ = -4807,352 ns)</td><td align="right" bgcolor="#A8D08D">504403,804 ns (Δ = -21575,320 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">922,722 μs</td><td align="right" bgcolor="#FF4949">1005,737 μs (Δ = +83,015 μs)</td><td align="right" bgcolor="#A8D08D">933,075 μs (Δ = -72,662 μs)</td><td align="right" bgcolor="#A8D08D">530,786 μs (Δ = -402,289 μs)</td><td align="right" bgcolor="#FFFFFF">525,979 μs (Δ = -4,807 μs)</td><td align="right" bgcolor="#A8D08D">504,404 μs (Δ = -21,575 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,923 ms</td><td align="right" bgcolor="#FF4949">1,006 ms (Δ = +0,083 ms)</td><td align="right" bgcolor="#A8D08D">0,933 ms (Δ = -0,073 ms)</td><td align="right" bgcolor="#A8D08D">0,531 ms (Δ = -0,402 ms)</td><td align="right" bgcolor="#FFFFFF">0,526 ms (Δ = -0,005 ms)</td><td align="right" bgcolor="#A8D08D">0,504 ms (Δ = -0,022 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.3.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">50</td><td align="right">50</td><td align="right">50</td><td align="right">20</td><td align="right">20</td><td align="right">20</td></tr>
<tr>
<td>Gen 1</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">10</td><td align="right">10</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">35330</td><td align="right">35332</td><td align="right">35324</td><td align="right">20370</td><td align="right">20370</td><td align="right">20370</td><tr>
<td>Allocated Kilobytes</td><td align="right">34,502</td><td align="right">34,504</td><td align="right">34,496</td><td align="right">19,893</td><td align="right">19,893</td><td align="right">19,893</td><tr>
<td>Allocated Megabytes</td><td align="right">0,034</td><td align="right">0,034</td><td align="right">0,034</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,019</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 1568,058 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#FFFFFF">-1,8 %</td><td align="right" bgcolor="#FF4949">+53,5 %</td><td align="right" bgcolor="#A8D08D">-32,9 %</td><td align="right" bgcolor="#A8D08D">-3,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3027,667 ns</td><td align="right" bgcolor="#FFFFFF">2977,720 ns (Δ = -49,947 ns)</td><td align="right" bgcolor="#FFFFFF">2922,902 ns (Δ = -54,818 ns)</td><td align="right" bgcolor="#FF4949">4486,880 ns (Δ = +1563,978 ns)</td><td align="right" bgcolor="#A8D08D">3012,504 ns (Δ = -1474,376 ns)</td><td align="right" bgcolor="#A8D08D">2918,822 ns (Δ = -93,682 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,028 μs</td><td align="right" bgcolor="#FFFFFF">2,978 μs (Δ = -0,050 μs)</td><td align="right" bgcolor="#FFFFFF">2,923 μs (Δ = -0,055 μs)</td><td align="right" bgcolor="#FF4949">4,487 μs (Δ = +1,564 μs)</td><td align="right" bgcolor="#A8D08D">3,013 μs (Δ = -1,474 μs)</td><td align="right" bgcolor="#A8D08D">2,919 μs (Δ = -0,094 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1016</td><td align="right">1016</td><td align="right">1016</td><td align="right">1016</td><td align="right">1016</td><td align="right">1016</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,992</td><td align="right">0,992</td><td align="right">0,992</td><td align="right">0,992</td><td align="right">0,992</td><td align="right">0,992</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 258,659 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#FFFFFF">+3,0 %</td><td align="right" bgcolor="#A8D08D">-3,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8064,973 ns</td><td align="right" bgcolor="#FFFFFF">8021,503 ns (Δ = -43,470 ns)</td><td align="right" bgcolor="#FFFFFF">8113,300 ns (Δ = +91,797 ns)</td><td align="right" bgcolor="#FFFFFF">7883,058 ns (Δ = -230,242 ns)</td><td align="right" bgcolor="#FFFFFF">8121,303 ns (Δ = +238,246 ns)</td><td align="right" bgcolor="#A8D08D">7862,644 ns (Δ = -258,659 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,065 μs</td><td align="right" bgcolor="#FFFFFF">8,022 μs (Δ = -0,043 μs)</td><td align="right" bgcolor="#FFFFFF">8,113 μs (Δ = +0,092 μs)</td><td align="right" bgcolor="#FFFFFF">7,883 μs (Δ = -0,230 μs)</td><td align="right" bgcolor="#FFFFFF">8,121 μs (Δ = +0,238 μs)</td><td align="right" bgcolor="#A8D08D">7,863 μs (Δ = -0,259 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,008 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Product"></a>Product

#### Performance

Fastest: **4.2.0**

Slowest: 4.4.0

Δ: 559,091 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,7 %</td><td align="right" bgcolor="#FFFFFF">+2,9 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FFFFFF">+0,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9848,587 ns</td><td align="right" bgcolor="#FFFFFF">10114,040 ns (Δ = +265,453 ns)</td><td align="right" bgcolor="#FFFFFF">10407,678 ns (Δ = +293,638 ns)</td><td align="right" bgcolor="#A8D08D">9989,593 ns (Δ = -418,084 ns)</td><td align="right" bgcolor="#FFFFFF">9979,307 ns (Δ = -10,287 ns)</td><td align="right" bgcolor="#FFFFFF">10028,330 ns (Δ = +49,023 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,849 μs</td><td align="right" bgcolor="#FFFFFF">10,114 μs (Δ = +0,265 μs)</td><td align="right" bgcolor="#FFFFFF">10,408 μs (Δ = +0,294 μs)</td><td align="right" bgcolor="#A8D08D">9,990 μs (Δ = -0,418 μs)</td><td align="right" bgcolor="#FFFFFF">9,979 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">10,028 μs (Δ = +0,049 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Title"></a>Title

#### Performance

Fastest: **4.2.0**

Slowest: 4.4.0

Δ: 363,333 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FFFFFF">+3,0 %</td><td align="right" bgcolor="#FFFFFF">-1,8 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FFFFFF">-1,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9852,423 ns</td><td align="right" bgcolor="#FFFFFF">9921,437 ns (Δ = +69,013 ns)</td><td align="right" bgcolor="#FFFFFF">10215,757 ns (Δ = +294,320 ns)</td><td align="right" bgcolor="#FFFFFF">10030,597 ns (Δ = -185,160 ns)</td><td align="right" bgcolor="#FFFFFF">10069,620 ns (Δ = +39,023 ns)</td><td align="right" bgcolor="#FFFFFF">9943,630 ns (Δ = -125,990 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,852 μs</td><td align="right" bgcolor="#FFFFFF">9,921 μs (Δ = +0,069 μs)</td><td align="right" bgcolor="#FFFFFF">10,216 μs (Δ = +0,294 μs)</td><td align="right" bgcolor="#FFFFFF">10,031 μs (Δ = -0,185 μs)</td><td align="right" bgcolor="#FFFFFF">10,070 μs (Δ = +0,039 μs)</td><td align="right" bgcolor="#FFFFFF">9,944 μs (Δ = -0,126 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><td align="right">852</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><td align="right">0,832</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_Version"></a>Version

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 287,899 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,0 %</td><td align="right" bgcolor="#FFFFFF">-1,8 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#FFFFFF">-1,4 %</td><td align="right" bgcolor="#A8D08D">-4,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1284,713 ns</td><td align="right" bgcolor="#A8D08D">1053,730 ns (Δ = -230,983 ns)</td><td align="right" bgcolor="#FFFFFF">1034,473 ns (Δ = -19,257 ns)</td><td align="right" bgcolor="#FFFFFF">1058,836 ns (Δ = +24,362 ns)</td><td align="right" bgcolor="#FFFFFF">1044,087 ns (Δ = -14,749 ns)</td><td align="right" bgcolor="#A8D08D">996,814 ns (Δ = -47,272 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,285 μs</td><td align="right" bgcolor="#A8D08D">1,054 μs (Δ = -0,231 μs)</td><td align="right" bgcolor="#FFFFFF">1,034 μs (Δ = -0,019 μs)</td><td align="right" bgcolor="#FFFFFF">1,059 μs (Δ = +0,024 μs)</td><td align="right" bgcolor="#FFFFFF">1,044 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#A8D08D">0,997 μs (Δ = -0,047 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1237</td><td align="right">1237</td><td align="right">1237</td><td align="right">1237</td><td align="right">1237</td><td align="right">1237</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,208</td><td align="right">1,208</td><td align="right">1,208</td><td align="right">1,208</td><td align="right">1,208</td><td align="right">1,208</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 339,180 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,8 %</td><td align="right" bgcolor="#A8D08D">-7,4 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3380,300 ns</td><td align="right" bgcolor="#FFFFFF">3285,642 ns (Δ = -94,658 ns)</td><td align="right" bgcolor="#A8D08D">3041,120 ns (Δ = -244,522 ns)</td><td align="right" bgcolor="#FFFFFF">3087,300 ns (Δ = +46,180 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,380 μs</td><td align="right" bgcolor="#FFFFFF">3,286 μs (Δ = -0,095 μs)</td><td align="right" bgcolor="#A8D08D">3,041 μs (Δ = -0,245 μs)</td><td align="right" bgcolor="#FFFFFF">3,087 μs (Δ = +0,046 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 1075,459 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,1 %</td><td align="right" bgcolor="#A8D08D">-19,4 %</td><td align="right" bgcolor="#A8D08D">-4,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3876,720 ns</td><td align="right" bgcolor="#FF4949">4732,335 ns (Δ = +855,615 ns)</td><td align="right" bgcolor="#A8D08D">3816,007 ns (Δ = -916,328 ns)</td><td align="right" bgcolor="#A8D08D">3656,876 ns (Δ = -159,131 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,877 μs</td><td align="right" bgcolor="#FF4949">4,732 μs (Δ = +0,856 μs)</td><td align="right" bgcolor="#A8D08D">3,816 μs (Δ = -0,916 μs)</td><td align="right" bgcolor="#A8D08D">3,657 μs (Δ = -0,159 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 139,696 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#A8D08D">-4,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3212,953 ns</td><td align="right" bgcolor="#FFFFFF">3199,843 ns (Δ = -13,110 ns)</td><td align="right" bgcolor="#FFFFFF">3248,763 ns (Δ = +48,920 ns)</td><td align="right" bgcolor="#A8D08D">3109,067 ns (Δ = -139,696 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,213 μs</td><td align="right" bgcolor="#FFFFFF">3,200 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FFFFFF">3,249 μs (Δ = +0,049 μs)</td><td align="right" bgcolor="#A8D08D">3,109 μs (Δ = -0,140 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1686,553 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,3 %</td><td align="right" bgcolor="#FF4949">+6,8 %</td><td align="right" bgcolor="#A8D08D">-30,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3850,140 ns</td><td align="right" bgcolor="#FF4949">5134,083 ns (Δ = +1283,943 ns)</td><td align="right" bgcolor="#FF4949">5484,817 ns (Δ = +350,733 ns)</td><td align="right" bgcolor="#A8D08D">3798,263 ns (Δ = -1686,553 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,850 μs</td><td align="right" bgcolor="#FF4949">5,134 μs (Δ = +1,284 μs)</td><td align="right" bgcolor="#FF4949">5,485 μs (Δ = +0,351 μs)</td><td align="right" bgcolor="#A8D08D">3,798 μs (Δ = -1,687 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = -0,002 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **4.5.0**

Slowest: 4.4.0

Δ: 80,991 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,5 %</td><td align="right" bgcolor="#FFFFFF">+1,6 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3207,651 ns</td><td align="right" bgcolor="#FFFFFF">3126,660 ns (Δ = -80,991 ns)</td><td align="right" bgcolor="#FFFFFF">3178,027 ns (Δ = +51,367 ns)</td><td align="right" bgcolor="#FFFFFF">3165,253 ns (Δ = -12,773 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,208 μs</td><td align="right" bgcolor="#FFFFFF">3,127 μs (Δ = -0,081 μs)</td><td align="right" bgcolor="#FFFFFF">3,178 μs (Δ = +0,051 μs)</td><td align="right" bgcolor="#FFFFFF">3,165 μs (Δ = -0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **4.5.0**

Slowest: 4.4.0

Δ: 1833,867 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,7 %</td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#FF4949">+4,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5611,057 ns</td><td align="right" bgcolor="#A8D08D">3777,190 ns (Δ = -1833,867 ns)</td><td align="right" bgcolor="#FFFFFF">3849,433 ns (Δ = +72,243 ns)</td><td align="right" bgcolor="#FF4949">4030,563 ns (Δ = +181,130 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,611 μs</td><td align="right" bgcolor="#A8D08D">3,777 μs (Δ = -1,834 μs)</td><td align="right" bgcolor="#FFFFFF">3,849 μs (Δ = +0,072 μs)</td><td align="right" bgcolor="#FF4949">4,031 μs (Δ = +0,181 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = -0,002 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **4.5.0**

Slowest: 4.5.4

Δ: 588,747 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FF4949">+18,2 %</td><td align="right" bgcolor="#A8D08D">-14,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3253,773 ns</td><td align="right" bgcolor="#FFFFFF">3238,507 ns (Δ = -15,267 ns)</td><td align="right" bgcolor="#FF4949">3827,253 ns (Δ = +588,747 ns)</td><td align="right" bgcolor="#A8D08D">3291,109 ns (Δ = -536,144 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,254 μs</td><td align="right" bgcolor="#FFFFFF">3,239 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FF4949">3,827 μs (Δ = +0,589 μs)</td><td align="right" bgcolor="#A8D08D">3,291 μs (Δ = -0,536 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,001 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 589,684 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,7 %</td><td align="right" bgcolor="#FF4949">+15,2 %</td><td align="right" bgcolor="#A8D08D">-13,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3898,037 ns</td><td align="right" bgcolor="#FFFFFF">3830,035 ns (Δ = -68,002 ns)</td><td align="right" bgcolor="#FF4949">4411,491 ns (Δ = +581,456 ns)</td><td align="right" bgcolor="#A8D08D">3821,807 ns (Δ = -589,684 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,898 μs</td><td align="right" bgcolor="#FFFFFF">3,830 μs (Δ = -0,068 μs)</td><td align="right" bgcolor="#FF4949">4,411 μs (Δ = +0,581 μs)</td><td align="right" bgcolor="#A8D08D">3,822 μs (Δ = -0,590 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = -0,001 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 145,412 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#A8D08D">-4,5 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3115,440 ns</td><td align="right" bgcolor="#FF4949">3231,543 ns (Δ = +116,103 ns)</td><td align="right" bgcolor="#A8D08D">3086,131 ns (Δ = -145,412 ns)</td><td align="right" bgcolor="#FFFFFF">3161,060 ns (Δ = +74,929 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,115 μs</td><td align="right" bgcolor="#FF4949">3,232 μs (Δ = +0,116 μs)</td><td align="right" bgcolor="#A8D08D">3,086 μs (Δ = -0,145 μs)</td><td align="right" bgcolor="#FFFFFF">3,161 μs (Δ = +0,075 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 241,803 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,9 %</td><td align="right" bgcolor="#A8D08D">-5,4 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3786,757 ns</td><td align="right" bgcolor="#FF4949">3974,047 ns (Δ = +187,290 ns)</td><td align="right" bgcolor="#A8D08D">3759,457 ns (Δ = -214,590 ns)</td><td align="right" bgcolor="#FFFFFF">3732,243 ns (Δ = -27,213 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,787 μs</td><td align="right" bgcolor="#FF4949">3,974 μs (Δ = +0,187 μs)</td><td align="right" bgcolor="#A8D08D">3,759 μs (Δ = -0,215 μs)</td><td align="right" bgcolor="#FFFFFF">3,732 μs (Δ = -0,027 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 4153,958 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FF4949">+126,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3182,143 ns</td><td align="right" bgcolor="#FFFFFF">3206,440 ns (Δ = +24,297 ns)</td><td align="right" bgcolor="#FFFFFF">3232,966 ns (Δ = +26,526 ns)</td><td align="right" bgcolor="#FF4949">7336,101 ns (Δ = +4103,136 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,182 μs</td><td align="right" bgcolor="#FFFFFF">3,206 μs (Δ = +0,024 μs)</td><td align="right" bgcolor="#FFFFFF">3,233 μs (Δ = +0,027 μs)</td><td align="right" bgcolor="#FF4949">7,336 μs (Δ = +4,103 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,007 ms (Δ = +0,004 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><td align="right">254</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><td align="right">0,248</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.4

Δ: 92,832 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3804,917 ns</td><td align="right" bgcolor="#FFFFFF">3819,198 ns (Δ = +14,281 ns)</td><td align="right" bgcolor="#FFFFFF">3897,749 ns (Δ = +78,551 ns)</td><td align="right" bgcolor="#FFFFFF">3839,627 ns (Δ = -58,122 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,805 μs</td><td align="right" bgcolor="#FFFFFF">3,819 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#FFFFFF">3,898 μs (Δ = +0,079 μs)</td><td align="right" bgcolor="#FFFFFF">3,840 μs (Δ = -0,058 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.4

Δ: 175,713 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,2 %</td><td align="right" bgcolor="#A8D08D">-10,0 %</td><td align="right" bgcolor="#FF4949">+177,1 %</td><td align="right" bgcolor="#FF4949">+5,3 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">92,364 ns</td><td align="right" bgcolor="#FF4949">101,757 ns (Δ = +9,392 ns)</td><td align="right" bgcolor="#A8D08D">91,560 ns (Δ = -10,197 ns)</td><td align="right" bgcolor="#FF4949">253,740 ns (Δ = +162,180 ns)</td><td align="right" bgcolor="#FF4949">267,273 ns (Δ = +13,533 ns)</td><td align="right" bgcolor="#A8D08D">256,387 ns (Δ = -10,887 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#FF4949">0,102 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,092 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FF4949">0,254 μs (Δ = +0,162 μs)</td><td align="right" bgcolor="#FF4949">0,267 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#A8D08D">0,256 μs (Δ = -0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">221</td><td align="right">221</td><td align="right">221</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,216</td><td align="right">0,216</td><td align="right">0,216</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 134,007 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,6 %</td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FF4949">+103,4 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#A8D08D">-6,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">125,486 ns</td><td align="right" bgcolor="#FFFFFF">127,437 ns (Δ = +1,951 ns)</td><td align="right" bgcolor="#FFFFFF">127,594 ns (Δ = +0,157 ns)</td><td align="right" bgcolor="#FF4949">259,493 ns (Δ = +131,898 ns)</td><td align="right" bgcolor="#FFFFFF">257,129 ns (Δ = -2,364 ns)</td><td align="right" bgcolor="#A8D08D">241,132 ns (Δ = -15,997 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,128 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,259 μs (Δ = +0,132 μs)</td><td align="right" bgcolor="#FFFFFF">0,257 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,241 μs (Δ = -0,016 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">139</td><td align="right">139</td><td align="right">139</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,136</td><td align="right">0,136</td><td align="right">0,136</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 139,116 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#A8D08D">-9,7 %</td><td align="right" bgcolor="#FF4949">+106,7 %</td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#FF4949">+6,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">143,290 ns</td><td align="right" bgcolor="#FFFFFF">142,013 ns (Δ = -1,277 ns)</td><td align="right" bgcolor="#A8D08D">128,171 ns (Δ = -13,842 ns)</td><td align="right" bgcolor="#FF4949">264,883 ns (Δ = +136,712 ns)</td><td align="right" bgcolor="#A8D08D">251,218 ns (Δ = -13,666 ns)</td><td align="right" bgcolor="#FF4949">267,287 ns (Δ = +16,069 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,128 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FF4949">0,265 μs (Δ = +0,137 μs)</td><td align="right" bgcolor="#A8D08D">0,251 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FF4949">0,267 μs (Δ = +0,016 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">139</td><td align="right">139</td><td align="right">139</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,136</td><td align="right">0,136</td><td align="right">0,136</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 148,380 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#FF4949">+140,0 %</td><td align="right" bgcolor="#A8D08D">-5,9 %</td><td align="right" bgcolor="#FF4949">+8,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">103,680 ns</td><td align="right" bgcolor="#A8D08D">100,287 ns (Δ = -3,393 ns)</td><td align="right" bgcolor="#FFFFFF">101,368 ns (Δ = +1,081 ns)</td><td align="right" bgcolor="#FF4949">243,303 ns (Δ = +141,936 ns)</td><td align="right" bgcolor="#A8D08D">229,050 ns (Δ = -14,253 ns)</td><td align="right" bgcolor="#FF4949">248,667 ns (Δ = +19,617 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#A8D08D">0,100 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,101 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,243 μs (Δ = +0,142 μs)</td><td align="right" bgcolor="#A8D08D">0,229 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FF4949">0,249 μs (Δ = +0,020 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">123</td><td align="right">123</td><td align="right">123</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,120</td><td align="right">0,120</td><td align="right">0,120</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 233,113 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+46,7 %</td><td align="right" bgcolor="#A8D08D">-35,0 %</td><td align="right" bgcolor="#FF4949">+135,3 %</td><td align="right" bgcolor="#FFFFFF">+2,7 %</td><td align="right" bgcolor="#FF4949">+38,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">103,993 ns</td><td align="right" bgcolor="#FF4949">152,580 ns (Δ = +48,587 ns)</td><td align="right" bgcolor="#A8D08D">99,200 ns (Δ = -53,380 ns)</td><td align="right" bgcolor="#FF4949">233,413 ns (Δ = +134,213 ns)</td><td align="right" bgcolor="#FFFFFF">239,657 ns (Δ = +6,243 ns)</td><td align="right" bgcolor="#FF4949">332,313 ns (Δ = +92,657 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FF4949">0,153 μs (Δ = +0,049 μs)</td><td align="right" bgcolor="#A8D08D">0,099 μs (Δ = -0,053 μs)</td><td align="right" bgcolor="#FF4949">0,233 μs (Δ = +0,134 μs)</td><td align="right" bgcolor="#FFFFFF">0,240 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FF4949">0,332 μs (Δ = +0,093 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">123</td><td align="right">123</td><td align="right">123</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,120</td><td align="right">0,120</td><td align="right">0,120</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.4

Δ: 167,420 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FF4949">+169,2 %</td><td align="right" bgcolor="#FF4949">+4,7 %</td><td align="right" bgcolor="#A8D08D">-4,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">92,215 ns</td><td align="right" bgcolor="#FFFFFF">92,973 ns (Δ = +0,758 ns)</td><td align="right" bgcolor="#FFFFFF">92,033 ns (Δ = -0,940 ns)</td><td align="right" bgcolor="#FF4949">247,757 ns (Δ = +155,723 ns)</td><td align="right" bgcolor="#FF4949">259,453 ns (Δ = +11,697 ns)</td><td align="right" bgcolor="#A8D08D">247,020 ns (Δ = -12,433 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,092 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,248 μs (Δ = +0,156 μs)</td><td align="right" bgcolor="#FF4949">0,259 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#A8D08D">0,247 μs (Δ = -0,012 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">221</td><td align="right">221</td><td align="right">221</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,216</td><td align="right">0,216</td><td align="right">0,216</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 133,873 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#A8D08D">-6,2 %</td><td align="right" bgcolor="#FF4949">+7,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1073,600 ns</td><td align="right" bgcolor="#FF4949">1118,502 ns (Δ = +44,902 ns)</td><td align="right" bgcolor="#FFFFFF">1092,160 ns (Δ = -26,342 ns)</td><td align="right" bgcolor="#A8D08D">1049,433 ns (Δ = -42,727 ns)</td><td align="right" bgcolor="#A8D08D">984,629 ns (Δ = -64,804 ns)</td><td align="right" bgcolor="#FF4949">1058,633 ns (Δ = +74,004 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,074 μs</td><td align="right" bgcolor="#FF4949">1,119 μs (Δ = +0,045 μs)</td><td align="right" bgcolor="#FFFFFF">1,092 μs (Δ = -0,026 μs)</td><td align="right" bgcolor="#A8D08D">1,049 μs (Δ = -0,043 μs)</td><td align="right" bgcolor="#A8D08D">0,985 μs (Δ = -0,065 μs)</td><td align="right" bgcolor="#FF4949">1,059 μs (Δ = +0,074 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">188</td><td align="right">188</td><td align="right">188</td><td align="right">188</td><td align="right">188</td><td align="right">188</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,184</td><td align="right">0,184</td><td align="right">0,184</td><td align="right">0,184</td><td align="right">0,184</td><td align="right">0,184</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 15,128 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,4 %</td><td align="right" bgcolor="#A8D08D">-6,4 %</td><td align="right" bgcolor="#FF4949">+8,9 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#A8D08D">-5,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">144,646 ns</td><td align="right" bgcolor="#FF4949">156,757 ns (Δ = +12,111 ns)</td><td align="right" bgcolor="#A8D08D">146,770 ns (Δ = -9,987 ns)</td><td align="right" bgcolor="#FF4949">159,773 ns (Δ = +13,003 ns)</td><td align="right" bgcolor="#A8D08D">154,363 ns (Δ = -5,410 ns)</td><td align="right" bgcolor="#A8D08D">145,247 ns (Δ = -9,117 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FF4949">0,157 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#A8D08D">0,147 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FF4949">0,160 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#A8D08D">0,154 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,145 μs (Δ = -0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_GetName_Long"></a>GetName_Long

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 20,159 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FF4949">+4,4 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#A8D08D">-9,6 %</td><td align="right" bgcolor="#FFFFFF">-2,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">165,716 ns</td><td align="right" bgcolor="#FFFFFF">163,858 ns (Δ = -1,858 ns)</td><td align="right" bgcolor="#FF4949">171,093 ns (Δ = +7,236 ns)</td><td align="right" bgcolor="#FFFFFF">173,633 ns (Δ = +2,540 ns)</td><td align="right" bgcolor="#A8D08D">156,947 ns (Δ = -16,687 ns)</td><td align="right" bgcolor="#FFFFFF">153,474 ns (Δ = -3,472 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#FFFFFF">0,164 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,171 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,174 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,157 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#FFFFFF">0,153 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_GetNames"></a>GetNames

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 676,931 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,8 %</td><td align="right" bgcolor="#A8D08D">-22,8 %</td><td align="right" bgcolor="#FF4949">+4,5 %</td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#A8D08D">-5,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2029,532 ns</td><td align="right" bgcolor="#FF4949">2675,113 ns (Δ = +645,582 ns)</td><td align="right" bgcolor="#A8D08D">2064,186 ns (Δ = -610,928 ns)</td><td align="right" bgcolor="#FF4949">2157,720 ns (Δ = +93,534 ns)</td><td align="right" bgcolor="#FFFFFF">2122,203 ns (Δ = -35,517 ns)</td><td align="right" bgcolor="#A8D08D">1998,182 ns (Δ = -124,021 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,030 μs</td><td align="right" bgcolor="#FF4949">2,675 μs (Δ = +0,646 μs)</td><td align="right" bgcolor="#A8D08D">2,064 μs (Δ = -0,611 μs)</td><td align="right" bgcolor="#FF4949">2,158 μs (Δ = +0,094 μs)</td><td align="right" bgcolor="#FFFFFF">2,122 μs (Δ = -0,036 μs)</td><td align="right" bgcolor="#A8D08D">1,998 μs (Δ = -0,124 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">918</td><td align="right">918</td><td align="right">918</td><td align="right">918</td><td align="right">918</td><td align="right">918</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,896</td><td align="right">0,896</td><td align="right">0,896</td><td align="right">0,896</td><td align="right">0,896</td><td align="right">0,896</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Enum_Benchmark_GetValues"></a>GetValues

#### Performance

Fastest: **4.2.0**

Slowest: 4.3.0

Δ: 481,897 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+12,3 %</td><td align="right" bgcolor="#A8D08D">-8,3 %</td><td align="right" bgcolor="#FF4949">+3,4 %</td><td align="right" bgcolor="#FFFFFF">+0,0 %</td><td align="right" bgcolor="#A8D08D">-4,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3926,760 ns</td><td align="right" bgcolor="#FF4949">4408,657 ns (Δ = +481,897 ns)</td><td align="right" bgcolor="#A8D08D">4041,293 ns (Δ = -367,363 ns)</td><td align="right" bgcolor="#FF4949">4180,327 ns (Δ = +139,033 ns)</td><td align="right" bgcolor="#FFFFFF">4181,700 ns (Δ = +1,373 ns)</td><td align="right" bgcolor="#A8D08D">3994,507 ns (Δ = -187,193 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,927 μs</td><td align="right" bgcolor="#FF4949">4,409 μs (Δ = +0,482 μs)</td><td align="right" bgcolor="#A8D08D">4,041 μs (Δ = -0,367 μs)</td><td align="right" bgcolor="#FF4949">4,180 μs (Δ = +0,139 μs)</td><td align="right" bgcolor="#FFFFFF">4,182 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">3,995 μs (Δ = -0,187 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1106</td><td align="right">1106</td><td align="right">1106</td><td align="right">1106</td><td align="right">1106</td><td align="right">1106</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,080</td><td align="right">1,080</td><td align="right">1,080</td><td align="right">1,080</td><td align="right">1,080</td><td align="right">1,080</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 32,863 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,6 %</td><td align="right" bgcolor="#FFFFFF">+0,9 %</td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#A8D08D">-7,3 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">345,730 ns</td><td align="right" bgcolor="#A8D08D">322,777 ns (Δ = -22,953 ns)</td><td align="right" bgcolor="#FFFFFF">325,613 ns (Δ = +2,837 ns)</td><td align="right" bgcolor="#FF4949">337,667 ns (Δ = +12,053 ns)</td><td align="right" bgcolor="#A8D08D">312,867 ns (Δ = -24,800 ns)</td><td align="right" bgcolor="#FFFFFF">320,276 ns (Δ = +7,409 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,346 μs</td><td align="right" bgcolor="#A8D08D">0,323 μs (Δ = -0,023 μs)</td><td align="right" bgcolor="#FFFFFF">0,326 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,338 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#A8D08D">0,313 μs (Δ = -0,025 μs)</td><td align="right" bgcolor="#FFFFFF">0,320 μs (Δ = +0,007 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_ToList"></a>ToList

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 275,211 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#FF4949">+6,6 %</td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#A8D08D">-5,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4043,597 ns</td><td align="right" bgcolor="#FFFFFF">4037,147 ns (Δ = -6,450 ns)</td><td align="right" bgcolor="#FF4949">4304,720 ns (Δ = +267,573 ns)</td><td align="right" bgcolor="#A8D08D">4080,117 ns (Δ = -224,603 ns)</td><td align="right" bgcolor="#FF4949">4252,593 ns (Δ = +172,477 ns)</td><td align="right" bgcolor="#A8D08D">4029,509 ns (Δ = -223,084 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,044 μs</td><td align="right" bgcolor="#FFFFFF">4,037 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">4,305 μs (Δ = +0,268 μs)</td><td align="right" bgcolor="#A8D08D">4,080 μs (Δ = -0,225 μs)</td><td align="right" bgcolor="#FF4949">4,253 μs (Δ = +0,172 μs)</td><td align="right" bgcolor="#A8D08D">4,030 μs (Δ = -0,223 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1196</td><td align="right">1196</td><td align="right">1196</td><td align="right">1196</td><td align="right">1196</td><td align="right">1196</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,168</td><td align="right">1,168</td><td align="right">1,168</td><td align="right">1,168</td><td align="right">1,168</td><td align="right">1,168</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse"></a>TryParse

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 188,915 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#A8D08D">-29,8 %</td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#FF4949">+5,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">500,363 ns</td><td align="right" bgcolor="#A8D08D">485,134 ns (Δ = -15,229 ns)</td><td align="right" bgcolor="#FFFFFF">482,029 ns (Δ = -3,105 ns)</td><td align="right" bgcolor="#A8D08D">338,155 ns (Δ = -143,874 ns)</td><td align="right" bgcolor="#A8D08D">311,448 ns (Δ = -26,707 ns)</td><td align="right" bgcolor="#FF4949">329,960 ns (Δ = +18,512 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,500 μs</td><td align="right" bgcolor="#A8D08D">0,485 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FFFFFF">0,482 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,338 μs (Δ = -0,144 μs)</td><td align="right" bgcolor="#A8D08D">0,311 μs (Δ = -0,027 μs)</td><td align="right" bgcolor="#FF4949">0,330 μs (Δ = +0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase"></a>TryParse_IgnoreCase

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 4516,030 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,2 %</td><td align="right" bgcolor="#FFFFFF">-2,9 %</td><td align="right" bgcolor="#A8D08D">-92,9 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#FF4949">+3,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4842,530 ns</td><td align="right" bgcolor="#FFFFFF">4783,663 ns (Δ = -58,867 ns)</td><td align="right" bgcolor="#FFFFFF">4647,037 ns (Δ = -136,627 ns)</td><td align="right" bgcolor="#A8D08D">329,546 ns (Δ = -4317,491 ns)</td><td align="right" bgcolor="#FFFFFF">326,500 ns (Δ = -3,046 ns)</td><td align="right" bgcolor="#FF4949">337,653 ns (Δ = +11,153 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,843 μs</td><td align="right" bgcolor="#FFFFFF">4,784 μs (Δ = -0,059 μs)</td><td align="right" bgcolor="#FFFFFF">4,647 μs (Δ = -0,137 μs)</td><td align="right" bgcolor="#A8D08D">0,330 μs (Δ = -4,317 μs)</td><td align="right" bgcolor="#FFFFFF">0,327 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,338 μs (Δ = +0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = -0,004 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1180</td><td align="right">1180</td><td align="right">1180</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,152</td><td align="right">1,152</td><td align="right">1,152</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase_Nullable"></a>TryParse_IgnoreCase_Nullable

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 214,521 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,6 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FF4949">+155,2 %</td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">140,844 ns</td><td align="right" bgcolor="#FFFFFF">137,236 ns (Δ = -3,609 ns)</td><td align="right" bgcolor="#FFFFFF">137,836 ns (Δ = +0,601 ns)</td><td align="right" bgcolor="#FF4949">351,757 ns (Δ = +213,921 ns)</td><td align="right" bgcolor="#A8D08D">340,300 ns (Δ = -11,457 ns)</td><td align="right" bgcolor="#A8D08D">326,303 ns (Δ = -13,997 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,137 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,138 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,352 μs (Δ = +0,214 μs)</td><td align="right" bgcolor="#A8D08D">0,340 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,326 μs (Δ = -0,014 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 150,962 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,6 %</td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#A8D08D">-28,6 %</td><td align="right" bgcolor="#FFFFFF">-1,7 %</td><td align="right" bgcolor="#FFFFFF">-0,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">476,160 ns</td><td align="right" bgcolor="#FFFFFF">483,713 ns (Δ = +7,553 ns)</td><td align="right" bgcolor="#FFFFFF">477,223 ns (Δ = -6,490 ns)</td><td align="right" bgcolor="#A8D08D">340,530 ns (Δ = -136,693 ns)</td><td align="right" bgcolor="#FFFFFF">334,660 ns (Δ = -5,870 ns)</td><td align="right" bgcolor="#FFFFFF">332,751 ns (Δ = -1,909 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,476 μs</td><td align="right" bgcolor="#FFFFFF">0,484 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,477 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#A8D08D">0,341 μs (Δ = -0,137 μs)</td><td align="right" bgcolor="#FFFFFF">0,335 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,333 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="FastDateTime_vs_DateTime_Benchmark"></a>FastDateTime_vs_DateTime_Benchmark

### <a name="FastDateTime_vs_DateTime_Benchmark_DateTime_Now"></a>DateTime_Now

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 10,100 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+3,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">338,560 ns</td><td align="right" bgcolor="#FFFFFF">348,660 ns (Δ = +10,100 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,339 μs</td><td align="right" bgcolor="#FFFFFF">0,349 μs (Δ = +0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">66</td><td align="right">66</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,064</td><td align="right">0,064</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 17,873 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">128,900 ns</td><td align="right" bgcolor="#A8D08D">111,027 ns (Δ = -17,873 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#A8D08D">0,111 μs (Δ = -0,018 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 3,149 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,545 ns</td><td align="right" bgcolor="#A8D08D">15,396 ns (Δ = -3,149 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 0,430 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,162 ns</td><td align="right" bgcolor="#FFFFFF">14,733 ns (Δ = -0,430 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark"></a>FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark

### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashInsert"></a>FastBindingList_BashInsert

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 46,092 ns


<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,9 %</td><td align="right" bgcolor="#FFFFFF">+3,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">947,813 ns</td><td align="right" bgcolor="#A8D08D">901,721 ns (Δ = -46,092 ns)</td><td align="right" bgcolor="#FFFFFF">929,527 ns (Δ = +27,806 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,948 μs</td><td align="right" bgcolor="#A8D08D">0,902 μs (Δ = -0,046 μs)</td><td align="right" bgcolor="#FFFFFF">0,930 μs (Δ = +0,028 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1062</td><td align="right">1062</td><td align="right">1062</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,037</td><td align="right">1,037</td><td align="right">1,037</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashRemove"></a>FastBindingList_BashRemove

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1,960 ns


<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">499,803 ns</td><td align="right" bgcolor="#FFFFFF">501,270 ns (Δ = +1,467 ns)</td><td align="right" bgcolor="#FFFFFF">499,310 ns (Δ = -1,960 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,500 μs</td><td align="right" bgcolor="#FFFFFF">0,501 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,499 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">418</td><td align="right">418</td><td align="right">418</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,408</td><td align="right">0,408</td><td align="right">0,408</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastObservableCollection_BashInsert"></a>FastObservableCollection_BashInsert

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 642,066 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,1 %</td><td align="right" bgcolor="#A8D08D">-3,6 %</td><td align="right" bgcolor="#FF4949">+41,4 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#A8D08D">-4,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1425,468 ns</td><td align="right" bgcolor="#FF4949">1511,863 ns (Δ = +86,395 ns)</td><td align="right" bgcolor="#A8D08D">1457,257 ns (Δ = -54,607 ns)</td><td align="right" bgcolor="#FF4949">2060,042 ns (Δ = +602,786 ns)</td><td align="right" bgcolor="#FFFFFF">2067,534 ns (Δ = +7,492 ns)</td><td align="right" bgcolor="#A8D08D">1966,142 ns (Δ = -101,392 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,425 μs</td><td align="right" bgcolor="#FF4949">1,512 μs (Δ = +0,086 μs)</td><td align="right" bgcolor="#A8D08D">1,457 μs (Δ = -0,055 μs)</td><td align="right" bgcolor="#FF4949">2,060 μs (Δ = +0,603 μs)</td><td align="right" bgcolor="#FFFFFF">2,068 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#A8D08D">1,966 μs (Δ = -0,101 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">3413</td><td align="right">3413</td><td align="right">3413</td><td align="right">4052</td><td align="right">4049</td><td align="right">4054</td><tr>
<td>Allocated Kilobytes</td><td align="right">3,333</td><td align="right">3,333</td><td align="right">3,333</td><td align="right">3,957</td><td align="right">3,954</td><td align="right">3,959</td><tr>
<td>Allocated Megabytes</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,004</td><td align="right">0,004</td><td align="right">0,004</td></tr>
</table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_ObservableCollection_BashInsert"></a>ObservableCollection_BashInsert

#### Performance

Fastest: **4.2.0**

Slowest: 4.4.0

Δ: 707,136 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FF4949">+77,0 %</td><td align="right" bgcolor="#A8D08D">-40,8 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">904,014 ns</td><td align="right" bgcolor="#FFFFFF">910,282 ns (Δ = +6,268 ns)</td><td align="right" bgcolor="#FF4949">1611,150 ns (Δ = +700,868 ns)</td><td align="right" bgcolor="#A8D08D">954,460 ns (Δ = -656,690 ns)</td><td align="right" bgcolor="#FFFFFF">947,903 ns (Δ = -6,557 ns)</td><td align="right" bgcolor="#FFFFFF">943,384 ns (Δ = -4,519 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,904 μs</td><td align="right" bgcolor="#FFFFFF">0,910 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FF4949">1,611 μs (Δ = +0,701 μs)</td><td align="right" bgcolor="#A8D08D">0,954 μs (Δ = -0,657 μs)</td><td align="right" bgcolor="#FFFFFF">0,948 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,943 μs (Δ = -0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1938</td><td align="right">1938</td><td align="right">1938</td><td align="right">1938</td><td align="right">1938</td><td align="right">1938</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,893</td><td align="right">1,893</td><td align="right">1,893</td><td align="right">1,893</td><td align="right">1,893</td><td align="right">1,893</td><tr>
<td>Allocated Megabytes</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td></tr>
</table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 1,093 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,0 %</td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#FF4949">+3,9 %</td><td align="right" bgcolor="#FF4949">+4,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,333 ns</td><td align="right" bgcolor="#A8D08D">4,961 ns (Δ = -0,373 ns)</td><td align="right" bgcolor="#FFFFFF">5,065 ns (Δ = +0,104 ns)</td><td align="right" bgcolor="#FF4949">5,563 ns (Δ = +0,498 ns)</td><td align="right" bgcolor="#FF4949">5,780 ns (Δ = +0,217 ns)</td><td align="right" bgcolor="#FF4949">6,053 ns (Δ = +0,273 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#A8D08D">0,005 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,005 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,006 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,006 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,006 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 10,242 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,6 %</td><td align="right" bgcolor="#FF4949">+39,6 %</td><td align="right" bgcolor="#A8D08D">-27,4 %</td><td align="right" bgcolor="#A8D08D">-5,4 %</td><td align="right" bgcolor="#FF4949">+5,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,127 ns</td><td align="right" bgcolor="#A8D08D">23,424 ns (Δ = -5,702 ns)</td><td align="right" bgcolor="#FF4949">32,700 ns (Δ = +9,276 ns)</td><td align="right" bgcolor="#A8D08D">23,742 ns (Δ = -8,958 ns)</td><td align="right" bgcolor="#A8D08D">22,458 ns (Δ = -1,284 ns)</td><td align="right" bgcolor="#FF4949">23,727 ns (Δ = +1,269 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#A8D08D">0,023 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,033 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,024 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,022 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,024 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">57</td><td align="right">57</td><td align="right">57</td><td align="right">57</td><td align="right">57</td><td align="right">57</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,056</td><td align="right">0,056</td><td align="right">0,056</td><td align="right">0,056</td><td align="right">0,056</td><td align="right">0,056</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 4,147 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FFFFFF">-2,3 %</td><td align="right" bgcolor="#FF4949">+5,1 %</td><td align="right" bgcolor="#A8D08D">-12,7 %</td><td align="right" bgcolor="#A8D08D">-10,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,548 ns</td><td align="right" bgcolor="#FFFFFF">18,367 ns (Δ = -0,182 ns)</td><td align="right" bgcolor="#FFFFFF">17,947 ns (Δ = -0,420 ns)</td><td align="right" bgcolor="#FF4949">18,860 ns (Δ = +0,913 ns)</td><td align="right" bgcolor="#A8D08D">16,473 ns (Δ = -2,387 ns)</td><td align="right" bgcolor="#A8D08D">14,713 ns (Δ = -1,760 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,019 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,016 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 239,464 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#FFFFFF">+2,8 %</td><td align="right" bgcolor="#FFFFFF">-1,7 %</td><td align="right" bgcolor="#A8D08D">-35,3 %</td><td align="right" bgcolor="#A8D08D">-5,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">583,553 ns</td><td align="right" bgcolor="#FFFFFF">586,467 ns (Δ = +2,913 ns)</td><td align="right" bgcolor="#FFFFFF">603,038 ns (Δ = +16,571 ns)</td><td align="right" bgcolor="#FFFFFF">592,887 ns (Δ = -10,151 ns)</td><td align="right" bgcolor="#A8D08D">383,320 ns (Δ = -209,567 ns)</td><td align="right" bgcolor="#A8D08D">363,573 ns (Δ = -19,747 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,584 μs</td><td align="right" bgcolor="#FFFFFF">0,586 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,603 μs (Δ = +0,017 μs)</td><td align="right" bgcolor="#FFFFFF">0,593 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#A8D08D">0,383 μs (Δ = -0,210 μs)</td><td align="right" bgcolor="#A8D08D">0,364 μs (Δ = -0,020 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">205</td><td align="right">205</td><td align="right">205</td><td align="right">238</td><td align="right">197</td><td align="right">164</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,200</td><td align="right">0,200</td><td align="right">0,200</td><td align="right">0,232</td><td align="right">0,192</td><td align="right">0,160</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 472,575 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,1 %</td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FF4949">+4,1 %</td><td align="right" bgcolor="#FF4949">+16,6 %</td><td align="right" bgcolor="#A8D08D">-36,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1179,491 ns</td><td align="right" bgcolor="#A8D08D">942,667 ns (Δ = -236,825 ns)</td><td align="right" bgcolor="#FFFFFF">920,367 ns (Δ = -22,300 ns)</td><td align="right" bgcolor="#FF4949">958,005 ns (Δ = +37,638 ns)</td><td align="right" bgcolor="#FF4949">1116,700 ns (Δ = +158,695 ns)</td><td align="right" bgcolor="#A8D08D">706,916 ns (Δ = -409,784 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,179 μs</td><td align="right" bgcolor="#A8D08D">0,943 μs (Δ = -0,237 μs)</td><td align="right" bgcolor="#FFFFFF">0,920 μs (Δ = -0,022 μs)</td><td align="right" bgcolor="#FF4949">0,958 μs (Δ = +0,038 μs)</td><td align="right" bgcolor="#FF4949">1,117 μs (Δ = +0,159 μs)</td><td align="right" bgcolor="#A8D08D">0,707 μs (Δ = -0,410 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">393</td><td align="right">393</td><td align="right">393</td><td align="right">426</td><td align="right">385</td><td align="right">352</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,384</td><td align="right">0,384</td><td align="right">0,384</td><td align="right">0,416</td><td align="right">0,376</td><td align="right">0,344</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 371,650 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+13,4 %</td><td align="right" bgcolor="#A8D08D">-15,3 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#A8D08D">-24,8 %</td><td align="right" bgcolor="#A8D08D">-3,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">875,738 ns</td><td align="right" bgcolor="#FF4949">993,307 ns (Δ = +117,569 ns)</td><td align="right" bgcolor="#A8D08D">841,353 ns (Δ = -151,953 ns)</td><td align="right" bgcolor="#FFFFFF">851,807 ns (Δ = +10,453 ns)</td><td align="right" bgcolor="#A8D08D">640,637 ns (Δ = -211,170 ns)</td><td align="right" bgcolor="#A8D08D">621,657 ns (Δ = -18,980 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,876 μs</td><td align="right" bgcolor="#FF4949">0,993 μs (Δ = +0,118 μs)</td><td align="right" bgcolor="#A8D08D">0,841 μs (Δ = -0,152 μs)</td><td align="right" bgcolor="#FFFFFF">0,852 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#A8D08D">0,641 μs (Δ = -0,211 μs)</td><td align="right" bgcolor="#A8D08D">0,622 μs (Δ = -0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">385</td><td align="right">385</td><td align="right">385</td><td align="right">418</td><td align="right">377</td><td align="right">344</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,376</td><td align="right">0,376</td><td align="right">0,376</td><td align="right">0,408</td><td align="right">0,368</td><td align="right">0,336</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="MemberInfoExtensions_Benchmark"></a>MemberInfoExtensions_Benchmark

### <a name="MemberInfoExtensions_Benchmark_GetSignature_Constructor"></a>GetSignature_Constructor

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 153,188 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#FF4949">+79,6 %</td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#A8D08D">-14,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">190,898 ns</td><td align="right" bgcolor="#FFFFFF">189,829 ns (Δ = -1,069 ns)</td><td align="right" bgcolor="#FFFFFF">191,002 ns (Δ = +1,172 ns)</td><td align="right" bgcolor="#FF4949">343,017 ns (Δ = +152,015 ns)</td><td align="right" bgcolor="#A8D08D">328,120 ns (Δ = -14,897 ns)</td><td align="right" bgcolor="#A8D08D">282,138 ns (Δ = -45,982 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,191 μs</td><td align="right" bgcolor="#FFFFFF">0,190 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,191 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,343 μs (Δ = +0,152 μs)</td><td align="right" bgcolor="#A8D08D">0,328 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#A8D08D">0,282 μs (Δ = -0,046 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">90</td><td align="right">90</td><td align="right">90</td><td align="right">213</td><td align="right">213</td><td align="right">213</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,088</td><td align="right">0,088</td><td align="right">0,088</td><td align="right">0,208</td><td align="right">0,208</td><td align="right">0,208</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="MemberInfoExtensions_Benchmark_GetSignature_Method"></a>GetSignature_Method

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 132,810 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FF4949">+46,8 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#A8D08D">-20,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">281,953 ns</td><td align="right" bgcolor="#A8D08D">272,800 ns (Δ = -9,153 ns)</td><td align="right" bgcolor="#FFFFFF">276,227 ns (Δ = +3,427 ns)</td><td align="right" bgcolor="#FF4949">405,610 ns (Δ = +129,383 ns)</td><td align="right" bgcolor="#FFFFFF">394,683 ns (Δ = -10,927 ns)</td><td align="right" bgcolor="#A8D08D">312,952 ns (Δ = -81,732 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td><td align="right" bgcolor="#A8D08D">0,273 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FFFFFF">0,276 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,406 μs (Δ = +0,129 μs)</td><td align="right" bgcolor="#FFFFFF">0,395 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,313 μs (Δ = -0,082 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">90</td><td align="right">90</td><td align="right">90</td><td align="right">213</td><td align="right">213</td><td align="right">213</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,088</td><td align="right">0,088</td><td align="right">0,088</td><td align="right">0,208</td><td align="right">0,208</td><td align="right">0,208</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 164,211 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,6 %</td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4508,130 ns</td><td align="right" bgcolor="#FFFFFF">4625,816 ns (Δ = +117,686 ns)</td><td align="right" bgcolor="#FFFFFF">4637,812 ns (Δ = +11,996 ns)</td><td align="right" bgcolor="#FFFFFF">4649,627 ns (Δ = +11,815 ns)</td><td align="right" bgcolor="#A8D08D">4485,416 ns (Δ = -164,211 ns)</td><td align="right" bgcolor="#FFFFFF">4494,420 ns (Δ = +9,004 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,508 μs</td><td align="right" bgcolor="#FFFFFF">4,626 μs (Δ = +0,118 μs)</td><td align="right" bgcolor="#FFFFFF">4,638 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#FFFFFF">4,650 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#A8D08D">4,485 μs (Δ = -0,164 μs)</td><td align="right" bgcolor="#FFFFFF">4,494 μs (Δ = +0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 267,510 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,1 %</td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#FFFFFF">-1,8 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7529,240 ns</td><td align="right" bgcolor="#FFFFFF">7614,030 ns (Δ = +84,790 ns)</td><td align="right" bgcolor="#FFFFFF">7599,402 ns (Δ = -14,628 ns)</td><td align="right" bgcolor="#FFFFFF">7461,900 ns (Δ = -137,502 ns)</td><td align="right" bgcolor="#FFFFFF">7622,688 ns (Δ = +160,788 ns)</td><td align="right" bgcolor="#FFFFFF">7729,410 ns (Δ = +106,723 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,529 μs</td><td align="right" bgcolor="#FFFFFF">7,614 μs (Δ = +0,085 μs)</td><td align="right" bgcolor="#FFFFFF">7,599 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FFFFFF">7,462 μs (Δ = -0,138 μs)</td><td align="right" bgcolor="#FFFFFF">7,623 μs (Δ = +0,161 μs)</td><td align="right" bgcolor="#FFFFFF">7,729 μs (Δ = +0,107 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.5.0**

Slowest: 4.5.4

Δ: 254,810 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FF4949">+4,3 %</td><td align="right" bgcolor="#FFFFFF">-1,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5896,660 ns</td><td align="right" bgcolor="#FFFFFF">5902,843 ns (Δ = +6,183 ns)</td><td align="right" bgcolor="#FFFFFF">5931,876 ns (Δ = +29,032 ns)</td><td align="right" bgcolor="#FFFFFF">5867,297 ns (Δ = -64,579 ns)</td><td align="right" bgcolor="#FF4949">6122,107 ns (Δ = +254,810 ns)</td><td align="right" bgcolor="#FFFFFF">6024,431 ns (Δ = -97,676 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,897 μs</td><td align="right" bgcolor="#FFFFFF">5,903 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FFFFFF">5,932 μs (Δ = +0,029 μs)</td><td align="right" bgcolor="#FFFFFF">5,867 μs (Δ = -0,065 μs)</td><td align="right" bgcolor="#FF4949">6,122 μs (Δ = +0,255 μs)</td><td align="right" bgcolor="#FFFFFF">6,024 μs (Δ = -0,098 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">680</td><td align="right">680</td><td align="right">680</td><td align="right">680</td><td align="right">680</td><td align="right">680</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,664</td><td align="right">0,664</td><td align="right">0,664</td><td align="right">0,664</td><td align="right">0,664</td><td align="right">0,664</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 455,570 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FFFFFF">+1,8 %</td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#A8D08D">-9,6 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4513,485 ns</td><td align="right" bgcolor="#FFFFFF">4512,263 ns (Δ = -1,222 ns)</td><td align="right" bgcolor="#FFFFFF">4595,587 ns (Δ = +83,324 ns)</td><td align="right" bgcolor="#FF4949">4740,947 ns (Δ = +145,360 ns)</td><td align="right" bgcolor="#A8D08D">4285,377 ns (Δ = -455,570 ns)</td><td align="right" bgcolor="#FFFFFF">4303,490 ns (Δ = +18,113 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,513 μs</td><td align="right" bgcolor="#FFFFFF">4,512 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">4,596 μs (Δ = +0,083 μs)</td><td align="right" bgcolor="#FF4949">4,741 μs (Δ = +0,145 μs)</td><td align="right" bgcolor="#A8D08D">4,285 μs (Δ = -0,456 μs)</td><td align="right" bgcolor="#FFFFFF">4,303 μs (Δ = +0,018 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 183,733 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,7 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#FFFFFF">-1,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7551,705 ns</td><td align="right" bgcolor="#FFFFFF">7425,200 ns (Δ = -126,505 ns)</td><td align="right" bgcolor="#FFFFFF">7519,393 ns (Δ = +94,193 ns)</td><td align="right" bgcolor="#FFFFFF">7441,791 ns (Δ = -77,602 ns)</td><td align="right" bgcolor="#FFFFFF">7608,933 ns (Δ = +167,142 ns)</td><td align="right" bgcolor="#FFFFFF">7483,510 ns (Δ = -125,423 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,552 μs</td><td align="right" bgcolor="#FFFFFF">7,425 μs (Δ = -0,127 μs)</td><td align="right" bgcolor="#FFFFFF">7,519 μs (Δ = +0,094 μs)</td><td align="right" bgcolor="#FFFFFF">7,442 μs (Δ = -0,078 μs)</td><td align="right" bgcolor="#FFFFFF">7,609 μs (Δ = +0,167 μs)</td><td align="right" bgcolor="#FFFFFF">7,484 μs (Δ = -0,125 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><td align="right">721</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><td align="right">0,704</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 302,363 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FFFFFF">-2,3 %</td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FFFFFF">-0,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9396,657 ns</td><td align="right" bgcolor="#FFFFFF">9602,960 ns (Δ = +206,303 ns)</td><td align="right" bgcolor="#FFFFFF">9562,600 ns (Δ = -40,360 ns)</td><td align="right" bgcolor="#FFFFFF">9338,733 ns (Δ = -223,867 ns)</td><td align="right" bgcolor="#FFFFFF">9364,053 ns (Δ = +25,320 ns)</td><td align="right" bgcolor="#FFFFFF">9300,597 ns (Δ = -63,457 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,397 μs</td><td align="right" bgcolor="#FFFFFF">9,603 μs (Δ = +0,206 μs)</td><td align="right" bgcolor="#FFFFFF">9,563 μs (Δ = -0,040 μs)</td><td align="right" bgcolor="#FFFFFF">9,339 μs (Δ = -0,224 μs)</td><td align="right" bgcolor="#FFFFFF">9,364 μs (Δ = +0,025 μs)</td><td align="right" bgcolor="#FFFFFF">9,301 μs (Δ = -0,063 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1090</td><td align="right">1090</td><td align="right">1090</td><td align="right">1090</td><td align="right">1090</td><td align="right">1090</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,064</td><td align="right">1,064</td><td align="right">1,064</td><td align="right">1,064</td><td align="right">1,064</td><td align="right">1,064</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


## <a name="ModelBase_Constructor_Benchmark"></a>ModelBase_Constructor_Benchmark

### <a name="ModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 2554,630 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,1 %</td><td align="right" bgcolor="#A8D08D">-14,8 %</td><td align="right" bgcolor="#A8D08D">-9,5 %</td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#A8D08D">-27,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4534,793 ns</td><td align="right" bgcolor="#FF4949">5538,630 ns (Δ = +1003,837 ns)</td><td align="right" bgcolor="#A8D08D">4718,437 ns (Δ = -820,193 ns)</td><td align="right" bgcolor="#A8D08D">4268,683 ns (Δ = -449,753 ns)</td><td align="right" bgcolor="#A8D08D">4106,187 ns (Δ = -162,497 ns)</td><td align="right" bgcolor="#A8D08D">2984,000 ns (Δ = -1122,187 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,535 μs</td><td align="right" bgcolor="#FF4949">5,539 μs (Δ = +1,004 μs)</td><td align="right" bgcolor="#A8D08D">4,718 μs (Δ = -0,820 μs)</td><td align="right" bgcolor="#A8D08D">4,269 μs (Δ = -0,450 μs)</td><td align="right" bgcolor="#A8D08D">4,106 μs (Δ = -0,162 μs)</td><td align="right" bgcolor="#A8D08D">2,984 μs (Δ = -1,122 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,005 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,001 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.3.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1925</td><td align="right">2081</td><td align="right">2081</td><td align="right">1729</td><td align="right">1720</td><td align="right">1008</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,880</td><td align="right">2,032</td><td align="right">2,032</td><td align="right">1,688</td><td align="right">1,680</td><td align="right">0,984</td><tr>
<td>Allocated Megabytes</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,001</td></tr>
</table>


## <a name="ModelBase_EqualityComparer_Benchmark"></a>ModelBase_EqualityComparer_Benchmark

### <a name="ModelBase_EqualityComparer_Benchmark_EqualityComparer"></a>EqualityComparer

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 1673,240 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#A8D08D">-9,4 %</td><td align="right" bgcolor="#A8D08D">-4,8 %</td><td align="right" bgcolor="#A8D08D">-25,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4661,333 ns</td><td align="right" bgcolor="#FFFFFF">4674,317 ns (Δ = +12,983 ns)</td><td align="right" bgcolor="#FFFFFF">4681,857 ns (Δ = +7,540 ns)</td><td align="right" bgcolor="#A8D08D">4243,143 ns (Δ = -438,713 ns)</td><td align="right" bgcolor="#A8D08D">4038,287 ns (Δ = -204,857 ns)</td><td align="right" bgcolor="#A8D08D">3008,617 ns (Δ = -1029,670 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,661 μs</td><td align="right" bgcolor="#FFFFFF">4,674 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#FFFFFF">4,682 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#A8D08D">4,243 μs (Δ = -0,439 μs)</td><td align="right" bgcolor="#A8D08D">4,038 μs (Δ = -0,205 μs)</td><td align="right" bgcolor="#A8D08D">3,009 μs (Δ = -1,030 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,001 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.3.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1925</td><td align="right">2081</td><td align="right">2081</td><td align="right">1729</td><td align="right">1720</td><td align="right">1008</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,880</td><td align="right">2,032</td><td align="right">2,032</td><td align="right">1,688</td><td align="right">1,680</td><td align="right">0,984</td><tr>
<td>Allocated Megabytes</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,001</td></tr>
</table>


### <a name="ModelBase_EqualityComparer_Benchmark_GetHashCode_"></a>GetHashCode_

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 3055,504 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,7 %</td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#A8D08D">-6,1 %</td><td align="right" bgcolor="#A8D08D">-42,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5547,817 ns</td><td align="right" bgcolor="#FF4949">6030,724 ns (Δ = +482,908 ns)</td><td align="right" bgcolor="#A8D08D">5711,770 ns (Δ = -318,954 ns)</td><td align="right" bgcolor="#A8D08D">5513,843 ns (Δ = -197,927 ns)</td><td align="right" bgcolor="#A8D08D">5178,723 ns (Δ = -335,120 ns)</td><td align="right" bgcolor="#A8D08D">2975,220 ns (Δ = -2203,503 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,548 μs</td><td align="right" bgcolor="#FF4949">6,031 μs (Δ = +0,483 μs)</td><td align="right" bgcolor="#A8D08D">5,712 μs (Δ = -0,319 μs)</td><td align="right" bgcolor="#A8D08D">5,514 μs (Δ = -0,198 μs)</td><td align="right" bgcolor="#A8D08D">5,179 μs (Δ = -0,335 μs)</td><td align="right" bgcolor="#A8D08D">2,975 μs (Δ = -2,204 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,002 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.3.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">2089</td><td align="right">2253</td><td align="right">2253</td><td align="right">1901</td><td align="right">1892</td><td align="right">1032</td><tr>
<td>Allocated Kilobytes</td><td align="right">2,040</td><td align="right">2,200</td><td align="right">2,200</td><td align="right">1,856</td><td align="right">1,848</td><td align="right">1,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,001</td></tr>
</table>


## <a name="ModelBase_GetValue_Benchmark"></a>ModelBase_GetValue_Benchmark

### <a name="ModelBase_GetValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 35,076 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,1 %</td><td align="right" bgcolor="#FF4949">+14,9 %</td><td align="right" bgcolor="#A8D08D">-13,6 %</td><td align="right" bgcolor="#A8D08D">-9,9 %</td><td align="right" bgcolor="#FF4949">+11,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">129,064 ns</td><td align="right" bgcolor="#FF4949">138,234 ns (Δ = +9,170 ns)</td><td align="right" bgcolor="#FF4949">158,790 ns (Δ = +20,556 ns)</td><td align="right" bgcolor="#A8D08D">137,250 ns (Δ = -21,540 ns)</td><td align="right" bgcolor="#A8D08D">123,714 ns (Δ = -13,536 ns)</td><td align="right" bgcolor="#FF4949">137,592 ns (Δ = +13,878 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FF4949">0,138 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#FF4949">0,159 μs (Δ = +0,021 μs)</td><td align="right" bgcolor="#A8D08D">0,137 μs (Δ = -0,022 μs)</td><td align="right" bgcolor="#A8D08D">0,124 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FF4949">0,138 μs (Δ = +0,014 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="ModelBase_GetValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 69,192 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+52,5 %</td><td align="right" bgcolor="#A8D08D">-23,1 %</td><td align="right" bgcolor="#A8D08D">-13,2 %</td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#FF4949">+10,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">128,675 ns</td><td align="right" bgcolor="#FF4949">196,253 ns (Δ = +67,578 ns)</td><td align="right" bgcolor="#A8D08D">150,936 ns (Δ = -45,318 ns)</td><td align="right" bgcolor="#A8D08D">131,053 ns (Δ = -19,882 ns)</td><td align="right" bgcolor="#A8D08D">127,062 ns (Δ = -3,992 ns)</td><td align="right" bgcolor="#FF4949">139,751 ns (Δ = +12,689 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FF4949">0,196 μs (Δ = +0,068 μs)</td><td align="right" bgcolor="#A8D08D">0,151 μs (Δ = -0,045 μs)</td><td align="right" bgcolor="#A8D08D">0,131 μs (Δ = -0,020 μs)</td><td align="right" bgcolor="#A8D08D">0,127 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,140 μs (Δ = +0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="ModelBase_GetValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 25,408 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,8 %</td><td align="right" bgcolor="#FF4949">+19,5 %</td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#FF4949">+15,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">125,169 ns</td><td align="right" bgcolor="#FFFFFF">122,949 ns (Δ = -2,220 ns)</td><td align="right" bgcolor="#FF4949">146,960 ns (Δ = +24,011 ns)</td><td align="right" bgcolor="#A8D08D">134,300 ns (Δ = -12,660 ns)</td><td align="right" bgcolor="#A8D08D">128,688 ns (Δ = -5,612 ns)</td><td align="right" bgcolor="#FF4949">148,357 ns (Δ = +19,668 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,123 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,147 μs (Δ = +0,024 μs)</td><td align="right" bgcolor="#A8D08D">0,134 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#A8D08D">0,129 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,148 μs (Δ = +0,020 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 1340,854 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+29,8 %</td><td align="right" bgcolor="#A8D08D">-10,6 %</td><td align="right" bgcolor="#FF4949">+3,4 %</td><td align="right" bgcolor="#FF4949">+7,2 %</td><td align="right" bgcolor="#A8D08D">-72,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1420,860 ns</td><td align="right" bgcolor="#FF4949">1844,518 ns (Δ = +423,658 ns)</td><td align="right" bgcolor="#A8D08D">1649,035 ns (Δ = -195,483 ns)</td><td align="right" bgcolor="#FF4949">1704,457 ns (Δ = +55,422 ns)</td><td align="right" bgcolor="#FF4949">1827,584 ns (Δ = +123,128 ns)</td><td align="right" bgcolor="#A8D08D">503,663 ns (Δ = -1323,921 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,421 μs</td><td align="right" bgcolor="#FF4949">1,845 μs (Δ = +0,424 μs)</td><td align="right" bgcolor="#A8D08D">1,649 μs (Δ = -0,195 μs)</td><td align="right" bgcolor="#FF4949">1,704 μs (Δ = +0,055 μs)</td><td align="right" bgcolor="#FF4949">1,828 μs (Δ = +0,123 μs)</td><td align="right" bgcolor="#A8D08D">0,504 μs (Δ = -1,324 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = -0,001 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">475</td><td align="right">508</td><td align="right">508</td><td align="right">631</td><td align="right">631</td><td align="right">82</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,464</td><td align="right">0,496</td><td align="right">0,496</td><td align="right">0,616</td><td align="right">0,616</td><td align="right">0,080</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 1368,613 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FF4949">+6,7 %</td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#FFFFFF">-2,6 %</td><td align="right" bgcolor="#A8D08D">-69,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1795,617 ns</td><td align="right" bgcolor="#FFFFFF">1800,037 ns (Δ = +4,420 ns)</td><td align="right" bgcolor="#FF4949">1920,244 ns (Δ = +120,208 ns)</td><td align="right" bgcolor="#A8D08D">1857,265 ns (Δ = -62,979 ns)</td><td align="right" bgcolor="#FFFFFF">1809,270 ns (Δ = -47,995 ns)</td><td align="right" bgcolor="#A8D08D">551,631 ns (Δ = -1257,639 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,796 μs</td><td align="right" bgcolor="#FFFFFF">1,800 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FF4949">1,920 μs (Δ = +0,120 μs)</td><td align="right" bgcolor="#A8D08D">1,857 μs (Δ = -0,063 μs)</td><td align="right" bgcolor="#FFFFFF">1,809 μs (Δ = -0,048 μs)</td><td align="right" bgcolor="#A8D08D">0,552 μs (Δ = -1,258 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = -0,001 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">475</td><td align="right">508</td><td align="right">508</td><td align="right">631</td><td align="right">631</td><td align="right">82</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,464</td><td align="right">0,496</td><td align="right">0,496</td><td align="right">0,616</td><td align="right">0,616</td><td align="right">0,080</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 2057,452 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+62,8 %</td><td align="right" bgcolor="#A8D08D">-33,1 %</td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#A8D08D">-75,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1494,570 ns</td><td align="right" bgcolor="#FF4949">2433,117 ns (Δ = +938,547 ns)</td><td align="right" bgcolor="#A8D08D">1628,720 ns (Δ = -804,397 ns)</td><td align="right" bgcolor="#A8D08D">1557,810 ns (Δ = -70,910 ns)</td><td align="right" bgcolor="#FFFFFF">1561,457 ns (Δ = +3,647 ns)</td><td align="right" bgcolor="#A8D08D">375,665 ns (Δ = -1185,792 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,495 μs</td><td align="right" bgcolor="#FF4949">2,433 μs (Δ = +0,939 μs)</td><td align="right" bgcolor="#A8D08D">1,629 μs (Δ = -0,804 μs)</td><td align="right" bgcolor="#A8D08D">1,558 μs (Δ = -0,071 μs)</td><td align="right" bgcolor="#FFFFFF">1,561 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,376 μs (Δ = -1,186 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = -0,001 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">451</td><td align="right">483</td><td align="right">483</td><td align="right">606</td><td align="right">606</td><td align="right">57</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,440</td><td align="right">0,472</td><td align="right">0,472</td><td align="right">0,592</td><td align="right">0,592</td><td align="right">0,056</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


## <a name="PropertyBag_GetPropertyValue_Benchmark"></a>PropertyBag_GetPropertyValue_Benchmark

### <a name="PropertyBag_GetPropertyValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 22,500 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#A8D08D">-16,6 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#FF4949">+13,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">96,727 ns</td><td align="right" bgcolor="#FFFFFF">95,764 ns (Δ = -0,962 ns)</td><td align="right" bgcolor="#A8D08D">92,669 ns (Δ = -3,096 ns)</td><td align="right" bgcolor="#A8D08D">77,287 ns (Δ = -15,382 ns)</td><td align="right" bgcolor="#A8D08D">74,227 ns (Δ = -3,060 ns)</td><td align="right" bgcolor="#FF4949">84,363 ns (Δ = +10,137 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,093 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,077 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#A8D08D">0,074 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,084 μs (Δ = +0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 19,885 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,6 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#A8D08D">-16,5 %</td><td align="right" bgcolor="#FFFFFF">+2,3 %</td><td align="right" bgcolor="#A8D08D">-4,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">94,552 ns</td><td align="right" bgcolor="#FFFFFF">92,070 ns (Δ = -2,482 ns)</td><td align="right" bgcolor="#FFFFFF">91,356 ns (Δ = -0,714 ns)</td><td align="right" bgcolor="#A8D08D">76,289 ns (Δ = -15,067 ns)</td><td align="right" bgcolor="#FFFFFF">78,047 ns (Δ = +1,758 ns)</td><td align="right" bgcolor="#A8D08D">74,667 ns (Δ = -3,380 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,092 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,091 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,076 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FFFFFF">0,078 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,075 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 32,571 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,7 %</td><td align="right" bgcolor="#A8D08D">-10,3 %</td><td align="right" bgcolor="#A8D08D">-17,4 %</td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FF4949">+8,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">102,980 ns</td><td align="right" bgcolor="#FF4949">113,967 ns (Δ = +10,987 ns)</td><td align="right" bgcolor="#A8D08D">102,178 ns (Δ = -11,789 ns)</td><td align="right" bgcolor="#A8D08D">84,358 ns (Δ = -17,820 ns)</td><td align="right" bgcolor="#A8D08D">81,396 ns (Δ = -2,963 ns)</td><td align="right" bgcolor="#FF4949">88,103 ns (Δ = +6,708 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td><td align="right" bgcolor="#FF4949">0,114 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,102 μs (Δ = -0,012 μs)</td><td align="right" bgcolor="#A8D08D">0,084 μs (Δ = -0,018 μs)</td><td align="right" bgcolor="#A8D08D">0,081 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,088 μs (Δ = +0,007 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 90,473 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,9 %</td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#A8D08D">-7,2 %</td><td align="right" bgcolor="#A8D08D">-6,4 %</td><td align="right" bgcolor="#A8D08D">-27,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">220,147 ns</td><td align="right" bgcolor="#A8D08D">207,067 ns (Δ = -13,080 ns)</td><td align="right" bgcolor="#FFFFFF">206,594 ns (Δ = -0,472 ns)</td><td align="right" bgcolor="#A8D08D">191,764 ns (Δ = -14,830 ns)</td><td align="right" bgcolor="#A8D08D">179,527 ns (Δ = -12,238 ns)</td><td align="right" bgcolor="#A8D08D">129,673 ns (Δ = -49,853 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,220 μs</td><td align="right" bgcolor="#A8D08D">0,207 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FFFFFF">0,207 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,192 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#A8D08D">0,180 μs (Δ = -0,012 μs)</td><td align="right" bgcolor="#A8D08D">0,130 μs (Δ = -0,050 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 104,029 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#A8D08D">-10,5 %</td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#A8D08D">-7,8 %</td><td align="right" bgcolor="#A8D08D">-33,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">200,278 ns</td><td align="right" bgcolor="#FF4949">219,907 ns (Δ = +19,629 ns)</td><td align="right" bgcolor="#A8D08D">196,751 ns (Δ = -23,156 ns)</td><td align="right" bgcolor="#A8D08D">188,157 ns (Δ = -8,594 ns)</td><td align="right" bgcolor="#A8D08D">173,518 ns (Δ = -14,639 ns)</td><td align="right" bgcolor="#A8D08D">115,878 ns (Δ = -57,640 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,200 μs</td><td align="right" bgcolor="#FF4949">0,220 μs (Δ = +0,020 μs)</td><td align="right" bgcolor="#A8D08D">0,197 μs (Δ = -0,023 μs)</td><td align="right" bgcolor="#A8D08D">0,188 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,174 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#A8D08D">0,116 μs (Δ = -0,058 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">25</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,024</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 33,720 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#A8D08D">-28,3 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#FF4949">+44,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">98,661 ns</td><td align="right" bgcolor="#FF4949">101,844 ns (Δ = +3,184 ns)</td><td align="right" bgcolor="#FFFFFF">99,368 ns (Δ = -2,477 ns)</td><td align="right" bgcolor="#A8D08D">71,203 ns (Δ = -28,164 ns)</td><td align="right" bgcolor="#FFFFFF">72,783 ns (Δ = +1,580 ns)</td><td align="right" bgcolor="#FF4949">104,923 ns (Δ = +32,140 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FF4949">0,102 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,099 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,071 μs (Δ = -0,028 μs)</td><td align="right" bgcolor="#FFFFFF">0,073 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,105 μs (Δ = +0,032 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 209,740 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#A8D08D">-4,6 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FF4949">+4,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4415,817 ns</td><td align="right" bgcolor="#FFFFFF">4393,963 ns (Δ = -21,853 ns)</td><td align="right" bgcolor="#FFFFFF">4500,227 ns (Δ = +106,263 ns)</td><td align="right" bgcolor="#A8D08D">4293,517 ns (Δ = -206,710 ns)</td><td align="right" bgcolor="#FFFFFF">4290,487 ns (Δ = -3,030 ns)</td><td align="right" bgcolor="#FF4949">4476,200 ns (Δ = +185,713 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,416 μs</td><td align="right" bgcolor="#FFFFFF">4,394 μs (Δ = -0,022 μs)</td><td align="right" bgcolor="#FFFFFF">4,500 μs (Δ = +0,106 μs)</td><td align="right" bgcolor="#A8D08D">4,294 μs (Δ = -0,207 μs)</td><td align="right" bgcolor="#FFFFFF">4,290 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">4,476 μs (Δ = +0,186 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.4

Δ: 55,160 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,6 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FF4949">+5,8 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#A8D08D">-4,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">888,538 ns</td><td align="right" bgcolor="#A8D08D">856,833 ns (Δ = -31,704 ns)</td><td align="right" bgcolor="#FFFFFF">854,271 ns (Δ = -2,562 ns)</td><td align="right" bgcolor="#FF4949">903,613 ns (Δ = +49,342 ns)</td><td align="right" bgcolor="#FFFFFF">909,431 ns (Δ = +5,818 ns)</td><td align="right" bgcolor="#A8D08D">868,313 ns (Δ = -41,118 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,889 μs</td><td align="right" bgcolor="#A8D08D">0,857 μs (Δ = -0,032 μs)</td><td align="right" bgcolor="#FFFFFF">0,854 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,904 μs (Δ = +0,049 μs)</td><td align="right" bgcolor="#FFFFFF">0,909 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#A8D08D">0,868 μs (Δ = -0,041 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 370,827 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FFFFFF">-1,8 %</td><td align="right" bgcolor="#FF4949">+6,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5599,633 ns</td><td align="right" bgcolor="#A8D08D">5367,203 ns (Δ = -232,430 ns)</td><td align="right" bgcolor="#FFFFFF">5315,133 ns (Δ = -52,070 ns)</td><td align="right" bgcolor="#FFFFFF">5323,603 ns (Δ = +8,470 ns)</td><td align="right" bgcolor="#FFFFFF">5228,807 ns (Δ = -94,797 ns)</td><td align="right" bgcolor="#FF4949">5563,900 ns (Δ = +335,093 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,600 μs</td><td align="right" bgcolor="#A8D08D">5,367 μs (Δ = -0,232 μs)</td><td align="right" bgcolor="#FFFFFF">5,315 μs (Δ = -0,052 μs)</td><td align="right" bgcolor="#FFFFFF">5,324 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#FFFFFF">5,229 μs (Δ = -0,095 μs)</td><td align="right" bgcolor="#FF4949">5,564 μs (Δ = +0,335 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#A8D08D">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">590</td><td align="right">590</td><td align="right">590</td><td align="right">590</td><td align="right">590</td><td align="right">590</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,576</td><td align="right">0,576</td><td align="right">0,576</td><td align="right">0,576</td><td align="right">0,576</td><td align="right">0,576</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 260,647 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#FF4949">+3,1 %</td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#A8D08D">-5,0 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4340,813 ns</td><td align="right" bgcolor="#FFFFFF">4330,627 ns (Δ = -10,187 ns)</td><td align="right" bgcolor="#FF4949">4465,833 ns (Δ = +135,207 ns)</td><td align="right" bgcolor="#FFFFFF">4498,587 ns (Δ = +32,753 ns)</td><td align="right" bgcolor="#A8D08D">4275,533 ns (Δ = -223,053 ns)</td><td align="right" bgcolor="#FFFFFF">4237,940 ns (Δ = -37,593 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,341 μs</td><td align="right" bgcolor="#FFFFFF">4,331 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FF4949">4,466 μs (Δ = +0,135 μs)</td><td align="right" bgcolor="#FFFFFF">4,499 μs (Δ = +0,033 μs)</td><td align="right" bgcolor="#A8D08D">4,276 μs (Δ = -0,223 μs)</td><td align="right" bgcolor="#FFFFFF">4,238 μs (Δ = -0,038 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><td align="right">328</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><td align="right">0,320</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **4.3.0**

Slowest: 4.2.0

Δ: 582,520 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,4 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#FF4949">+15,3 %</td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-3,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1441,947 ns</td><td align="right" bgcolor="#A8D08D">859,427 ns (Δ = -582,520 ns)</td><td align="right" bgcolor="#FFFFFF">864,993 ns (Δ = +5,567 ns)</td><td align="right" bgcolor="#FF4949">996,920 ns (Δ = +131,927 ns)</td><td align="right" bgcolor="#A8D08D">954,993 ns (Δ = -41,927 ns)</td><td align="right" bgcolor="#A8D08D">921,711 ns (Δ = -33,282 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,442 μs</td><td align="right" bgcolor="#A8D08D">0,859 μs (Δ = -0,583 μs)</td><td align="right" bgcolor="#FFFFFF">0,865 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FF4949">0,997 μs (Δ = +0,132 μs)</td><td align="right" bgcolor="#A8D08D">0,955 μs (Δ = -0,042 μs)</td><td align="right" bgcolor="#A8D08D">0,922 μs (Δ = -0,033 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><td align="right">74</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><td align="right">0,072</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 32,934 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#FFFFFF">+2,6 %</td><td align="right" bgcolor="#FFFFFF">-2,1 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FFFFFF">-1,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">788,860 ns</td><td align="right" bgcolor="#FFFFFF">787,260 ns (Δ = -1,600 ns)</td><td align="right" bgcolor="#FFFFFF">807,598 ns (Δ = +20,338 ns)</td><td align="right" bgcolor="#FFFFFF">790,380 ns (Δ = -17,218 ns)</td><td align="right" bgcolor="#FFFFFF">788,360 ns (Δ = -2,020 ns)</td><td align="right" bgcolor="#FFFFFF">774,663 ns (Δ = -13,697 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,789 μs</td><td align="right" bgcolor="#FFFFFF">0,787 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,808 μs (Δ = +0,020 μs)</td><td align="right" bgcolor="#FFFFFF">0,790 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#FFFFFF">0,788 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,775 μs (Δ = -0,014 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">164</td><td align="right">164</td><td align="right">164</td><td align="right">164</td><td align="right">164</td><td align="right">164</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,160</td><td align="right">0,160</td><td align="right">0,160</td><td align="right">0,160</td><td align="right">0,160</td><td align="right">0,160</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="ScopeManager_Benchmark"></a>ScopeManager_Benchmark

### <a name="ScopeManager_Benchmark_Get_Existing_ScopeManager"></a>Get_Existing_ScopeManager

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 281,114 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,0 %</td><td align="right" bgcolor="#A8D08D">-41,6 %</td><td align="right" bgcolor="#A8D08D">-6,5 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#A8D08D">-4,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">469,350 ns</td><td align="right" bgcolor="#A8D08D">356,512 ns (Δ = -112,838 ns)</td><td align="right" bgcolor="#A8D08D">208,083 ns (Δ = -148,428 ns)</td><td align="right" bgcolor="#A8D08D">194,456 ns (Δ = -13,628 ns)</td><td align="right" bgcolor="#FFFFFF">197,263 ns (Δ = +2,807 ns)</td><td align="right" bgcolor="#A8D08D">188,236 ns (Δ = -9,028 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,469 μs</td><td align="right" bgcolor="#A8D08D">0,357 μs (Δ = -0,113 μs)</td><td align="right" bgcolor="#A8D08D">0,208 μs (Δ = -0,148 μs)</td><td align="right" bgcolor="#A8D08D">0,194 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FFFFFF">0,197 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,188 μs (Δ = -0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="ScopeManager_Benchmark_Get_New_ScopeManager"></a>Get_New_ScopeManager

#### Performance

Fastest: **4.4.0**

Slowest: 4.2.0

Δ: 319,862 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,4 %</td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FF4949">+3,1 %</td><td align="right" bgcolor="#FF4949">+8,0 %</td><td align="right" bgcolor="#FF4949">+9,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">513,313 ns</td><td align="right" bgcolor="#A8D08D">377,743 ns (Δ = -135,570 ns)</td><td align="right" bgcolor="#A8D08D">193,451 ns (Δ = -184,292 ns)</td><td align="right" bgcolor="#FF4949">199,472 ns (Δ = +6,021 ns)</td><td align="right" bgcolor="#FF4949">215,447 ns (Δ = +15,975 ns)</td><td align="right" bgcolor="#FF4949">234,860 ns (Δ = +19,413 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,513 μs</td><td align="right" bgcolor="#A8D08D">0,378 μs (Δ = -0,136 μs)</td><td align="right" bgcolor="#A8D08D">0,193 μs (Δ = -0,184 μs)</td><td align="right" bgcolor="#FF4949">0,199 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FF4949">0,215 μs (Δ = +0,016 μs)</td><td align="right" bgcolor="#FF4949">0,235 μs (Δ = +0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 508834,846 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,5 %</td><td align="right" bgcolor="#FF4949">+5,1 %</td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#FF4949">+149,3 %</td><td align="right" bgcolor="#A8D08D">-40,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">359339,996 ns</td><td align="right" bgcolor="#A8D08D">296338,471 ns (Δ = -63001,524 ns)</td><td align="right" bgcolor="#FF4949">311558,923 ns (Δ = +15220,452 ns)</td><td align="right" bgcolor="#FF4949">322995,847 ns (Δ = +11436,923 ns)</td><td align="right" bgcolor="#FF4949">805173,317 ns (Δ = +482177,470 ns)</td><td align="right" bgcolor="#A8D08D">477507,953 ns (Δ = -327665,363 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">359,340 μs</td><td align="right" bgcolor="#A8D08D">296,338 μs (Δ = -63,002 μs)</td><td align="right" bgcolor="#FF4949">311,559 μs (Δ = +15,220 μs)</td><td align="right" bgcolor="#FF4949">322,996 μs (Δ = +11,437 μs)</td><td align="right" bgcolor="#FF4949">805,173 μs (Δ = +482,177 μs)</td><td align="right" bgcolor="#A8D08D">477,508 μs (Δ = -327,665 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,359 ms</td><td align="right" bgcolor="#A8D08D">0,296 ms (Δ = -0,063 ms)</td><td align="right" bgcolor="#FF4949">0,312 ms (Δ = +0,015 ms)</td><td align="right" bgcolor="#FF4949">0,323 ms (Δ = +0,011 ms)</td><td align="right" bgcolor="#FF4949">0,805 ms (Δ = +0,482 ms)</td><td align="right" bgcolor="#A8D08D">0,478 ms (Δ = -0,328 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.3.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">120</td><td align="right">120</td><td align="right">120</td><td align="right">130</td><td align="right">170</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">5</td><td align="right">5</td><td align="right">10</td><td align="right">10</td><td align="right">30</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">80227</td><td align="right">80086</td><td align="right">81402</td><td align="right">85729</td><td align="right">110575</td><td align="right">27091</td><tr>
<td>Allocated Kilobytes</td><td align="right">78,347</td><td align="right">78,209</td><td align="right">79,494</td><td align="right">83,720</td><td align="right">107,983</td><td align="right">26,456</td><tr>
<td>Allocated Megabytes</td><td align="right">0,077</td><td align="right">0,076</td><td align="right">0,078</td><td align="right">0,082</td><td align="right">0,105</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 465251,723 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#FF4949">+6,7 %</td><td align="right" bgcolor="#FF4949">+6,6 %</td><td align="right" bgcolor="#FF4949">+630,0 %</td><td align="right" bgcolor="#A8D08D">-7,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">63320,721 ns</td><td align="right" bgcolor="#FFFFFF">63632,916 ns (Δ = +312,195 ns)</td><td align="right" bgcolor="#FF4949">67903,236 ns (Δ = +4270,320 ns)</td><td align="right" bgcolor="#FF4949">72408,187 ns (Δ = +4504,951 ns)</td><td align="right" bgcolor="#FF4949">528572,443 ns (Δ = +456164,257 ns)</td><td align="right" bgcolor="#A8D08D">488817,390 ns (Δ = -39755,053 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">63,321 μs</td><td align="right" bgcolor="#FFFFFF">63,633 μs (Δ = +0,312 μs)</td><td align="right" bgcolor="#FF4949">67,903 μs (Δ = +4,270 μs)</td><td align="right" bgcolor="#FF4949">72,408 μs (Δ = +4,505 μs)</td><td align="right" bgcolor="#FF4949">528,572 μs (Δ = +456,164 μs)</td><td align="right" bgcolor="#A8D08D">488,817 μs (Δ = -39,755 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,063 ms</td><td align="right" bgcolor="#FFFFFF">0,064 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,068 ms (Δ = +0,004 ms)</td><td align="right" bgcolor="#FF4949">0,072 ms (Δ = +0,005 ms)</td><td align="right" bgcolor="#FF4949">0,529 ms (Δ = +0,456 ms)</td><td align="right" bgcolor="#A8D08D">0,489 ms (Δ = -0,040 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">4.4.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.5.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.3.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">30</td><td align="right">50</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">10</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">20005</td><td align="right">19932</td><td align="right">20276</td><td align="right">21570</td><td align="right">39119</td><td align="right">27091</td><tr>
<td>Allocated Kilobytes</td><td align="right">19,536</td><td align="right">19,465</td><td align="right">19,801</td><td align="right">21,064</td><td align="right">38,202</td><td align="right">26,456</td><tr>
<td>Allocated Megabytes</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,021</td><td align="right">0,037</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 502769,890 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,0 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#FF4949">+12,1 %</td><td align="right" bgcolor="#FF4949">+200,7 %</td><td align="right" bgcolor="#A8D08D">-31,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">216980,557 ns</td><td align="right" bgcolor="#A8D08D">201720,077 ns (Δ = -15260,480 ns)</td><td align="right" bgcolor="#FF4949">209029,626 ns (Δ = +7309,549 ns)</td><td align="right" bgcolor="#FF4949">234277,350 ns (Δ = +25247,724 ns)</td><td align="right" bgcolor="#FF4949">704489,967 ns (Δ = +470212,617 ns)</td><td align="right" bgcolor="#A8D08D">484730,250 ns (Δ = -219759,717 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">216,981 μs</td><td align="right" bgcolor="#A8D08D">201,720 μs (Δ = -15,260 μs)</td><td align="right" bgcolor="#FF4949">209,030 μs (Δ = +7,310 μs)</td><td align="right" bgcolor="#FF4949">234,277 μs (Δ = +25,248 μs)</td><td align="right" bgcolor="#FF4949">704,490 μs (Δ = +470,213 μs)</td><td align="right" bgcolor="#A8D08D">484,730 μs (Δ = -219,760 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,217 ms</td><td align="right" bgcolor="#A8D08D">0,202 ms (Δ = -0,015 ms)</td><td align="right" bgcolor="#FF4949">0,209 ms (Δ = +0,007 ms)</td><td align="right" bgcolor="#FF4949">0,234 ms (Δ = +0,025 ms)</td><td align="right" bgcolor="#FF4949">0,704 ms (Δ = +0,470 ms)</td><td align="right" bgcolor="#A8D08D">0,485 ms (Δ = -0,220 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.5.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">90</td><td align="right">90</td><td align="right">90</td><td align="right">100</td><td align="right">130</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">30</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">59385</td><td align="right">59245</td><td align="right">60582</td><td align="right">64972</td><td align="right">87735</td><td align="right">27091</td><tr>
<td>Allocated Kilobytes</td><td align="right">57,993</td><td align="right">57,856</td><td align="right">59,162</td><td align="right">63,449</td><td align="right">85,679</td><td align="right">26,456</td><tr>
<td>Allocated Megabytes</td><td align="right">0,057</td><td align="right">0,057</td><td align="right">0,058</td><td align="right">0,062</td><td align="right">0,084</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1193743,086 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,3 %</td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#FF4949">+52,7 %</td><td align="right" bgcolor="#A8D08D">-71,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1049730,320 ns</td><td align="right" bgcolor="#FFFFFF">1025761,967 ns (Δ = -23968,353 ns)</td><td align="right" bgcolor="#FFFFFF">1009206,333 ns (Δ = -16555,633 ns)</td><td align="right" bgcolor="#FF4949">1096195,397 ns (Δ = +86989,063 ns)</td><td align="right" bgcolor="#FF4949">1674188,169 ns (Δ = +577992,772 ns)</td><td align="right" bgcolor="#A8D08D">480445,083 ns (Δ = -1193743,086 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1049,730 μs</td><td align="right" bgcolor="#FFFFFF">1025,762 μs (Δ = -23,968 μs)</td><td align="right" bgcolor="#FFFFFF">1009,206 μs (Δ = -16,556 μs)</td><td align="right" bgcolor="#FF4949">1096,195 μs (Δ = +86,989 μs)</td><td align="right" bgcolor="#FF4949">1674,188 μs (Δ = +577,993 μs)</td><td align="right" bgcolor="#A8D08D">480,445 μs (Δ = -1193,743 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,050 ms</td><td align="right" bgcolor="#FFFFFF">1,026 ms (Δ = -0,024 ms)</td><td align="right" bgcolor="#FFFFFF">1,009 ms (Δ = -0,017 ms)</td><td align="right" bgcolor="#FF4949">1,096 ms (Δ = +0,087 ms)</td><td align="right" bgcolor="#FF4949">1,674 ms (Δ = +0,578 ms)</td><td align="right" bgcolor="#A8D08D">0,480 ms (Δ = -1,194 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">410</td><td align="right">410</td><td align="right">420</td><td align="right">450</td><td align="right">530</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">50</td><td align="right">50</td><td align="right">60</td><td align="right">60</td><td align="right">90</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">263117</td><td align="right">262615</td><td align="right">268908</td><td align="right">288618</td><td align="right">337027</td><td align="right">27091</td><tr>
<td>Allocated Kilobytes</td><td align="right">256,950</td><td align="right">256,460</td><td align="right">262,605</td><td align="right">281,854</td><td align="right">329,128</td><td align="right">26,456</td><tr>
<td>Allocated Megabytes</td><td align="right">0,251</td><td align="right">0,250</td><td align="right">0,256</td><td align="right">0,275</td><td align="right">0,321</td><td align="right">0,026</td></tr>
</table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 19844188,974 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,7 %</td><td align="right" bgcolor="#FFFFFF">-2,3 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#A8D08D">-97,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18883375,062 ns</td><td align="right" bgcolor="#FFFFFF">19393473,522 ns (Δ = +510098,460 ns)</td><td align="right" bgcolor="#FFFFFF">18948721,398 ns (Δ = -444752,124 ns)</td><td align="right" bgcolor="#FFFFFF">19187349,287 ns (Δ = +238627,888 ns)</td><td align="right" bgcolor="#FF4949">20312625,478 ns (Δ = +1125276,191 ns)</td><td align="right" bgcolor="#A8D08D">468436,503 ns (Δ = -19844188,974 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">18883,375 μs</td><td align="right" bgcolor="#FFFFFF">19393,474 μs (Δ = +510,098 μs)</td><td align="right" bgcolor="#FFFFFF">18948,721 μs (Δ = -444,752 μs)</td><td align="right" bgcolor="#FFFFFF">19187,349 μs (Δ = +238,628 μs)</td><td align="right" bgcolor="#FF4949">20312,625 μs (Δ = +1125,276 μs)</td><td align="right" bgcolor="#A8D08D">468,437 μs (Δ = -19844,189 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">18,883 ms</td><td align="right" bgcolor="#FFFFFF">19,393 ms (Δ = +0,510 ms)</td><td align="right" bgcolor="#FFFFFF">18,949 ms (Δ = -0,445 ms)</td><td align="right" bgcolor="#FFFFFF">19,187 ms (Δ = +0,239 ms)</td><td align="right" bgcolor="#FF4949">20,313 ms (Δ = +1,125 ms)</td><td align="right" bgcolor="#A8D08D">0,468 ms (Δ = -19,844 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">2260</td><td align="right">2260</td><td align="right">2295</td><td align="right">2355</td><td align="right">2480</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">750</td><td align="right">750</td><td align="right">760</td><td align="right">780</td><td align="right">820</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1427935</td><td align="right">1427449</td><td align="right">1449353</td><td align="right">1486579</td><td align="right">1563700</td><td align="right">27578</td><tr>
<td>Allocated Kilobytes</td><td align="right">1394,468</td><td align="right">1393,993</td><td align="right">1415,384</td><td align="right">1451,737</td><td align="right">1527,051</td><td align="right">26,932</td><tr>
<td>Allocated Megabytes</td><td align="right">1,362</td><td align="right">1,361</td><td align="right">1,382</td><td align="right">1,418</td><td align="right">1,491</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 817574,624 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#A8D08D">-12,4 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FF4949">+60,5 %</td><td align="right" bgcolor="#A8D08D">-63,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">827215,690 ns</td><td align="right" bgcolor="#FF4949">908209,687 ns (Δ = +80993,997 ns)</td><td align="right" bgcolor="#A8D08D">795350,410 ns (Δ = -112859,277 ns)</td><td align="right" bgcolor="#FFFFFF">796823,787 ns (Δ = +1473,377 ns)</td><td align="right" bgcolor="#FF4949">1279015,444 ns (Δ = +482191,658 ns)</td><td align="right" bgcolor="#A8D08D">461440,820 ns (Δ = -817574,624 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">827,216 μs</td><td align="right" bgcolor="#FF4949">908,210 μs (Δ = +80,994 μs)</td><td align="right" bgcolor="#A8D08D">795,350 μs (Δ = -112,859 μs)</td><td align="right" bgcolor="#FFFFFF">796,824 μs (Δ = +1,473 μs)</td><td align="right" bgcolor="#FF4949">1279,015 μs (Δ = +482,192 μs)</td><td align="right" bgcolor="#A8D08D">461,441 μs (Δ = -817,575 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,827 ms</td><td align="right" bgcolor="#FF4949">0,908 ms (Δ = +0,081 ms)</td><td align="right" bgcolor="#A8D08D">0,795 ms (Δ = -0,113 ms)</td><td align="right" bgcolor="#FFFFFF">0,797 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">1,279 ms (Δ = +0,482 ms)</td><td align="right" bgcolor="#A8D08D">0,461 ms (Δ = -0,818 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">100</td><td align="right">100</td><td align="right">100</td><td align="right">100</td><td align="right">130</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">30</td><td align="right">20</td><td align="right">30</td><td align="right">20</td><td align="right">40</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">66626</td><td align="right">66455</td><td align="right">67298</td><td align="right">69735</td><td align="right">87270</td><td align="right">27578</td><tr>
<td>Allocated Kilobytes</td><td align="right">65,064</td><td align="right">64,897</td><td align="right">65,721</td><td align="right">68,101</td><td align="right">85,225</td><td align="right">26,932</td><tr>
<td>Allocated Megabytes</td><td align="right">0,064</td><td align="right">0,063</td><td align="right">0,064</td><td align="right">0,067</td><td align="right">0,083</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 3212248,513 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#FFFFFF">+2,5 %</td><td align="right" bgcolor="#FFFFFF">-2,5 %</td><td align="right" bgcolor="#FF4949">+16,2 %</td><td align="right" bgcolor="#A8D08D">-87,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3271161,230 ns</td><td align="right" bgcolor="#A8D08D">3170293,156 ns (Δ = -100868,074 ns)</td><td align="right" bgcolor="#FFFFFF">3250106,743 ns (Δ = +79813,587 ns)</td><td align="right" bgcolor="#FFFFFF">3169207,958 ns (Δ = -80898,786 ns)</td><td align="right" bgcolor="#FF4949">3681180,167 ns (Δ = +511972,209 ns)</td><td align="right" bgcolor="#A8D08D">468931,653 ns (Δ = -3212248,513 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3271,161 μs</td><td align="right" bgcolor="#A8D08D">3170,293 μs (Δ = -100,868 μs)</td><td align="right" bgcolor="#FFFFFF">3250,107 μs (Δ = +79,814 μs)</td><td align="right" bgcolor="#FFFFFF">3169,208 μs (Δ = -80,899 μs)</td><td align="right" bgcolor="#FF4949">3681,180 μs (Δ = +511,972 μs)</td><td align="right" bgcolor="#A8D08D">468,932 μs (Δ = -3212,249 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,271 ms</td><td align="right" bgcolor="#A8D08D">3,170 ms (Δ = -0,101 ms)</td><td align="right" bgcolor="#FFFFFF">3,250 ms (Δ = +0,080 ms)</td><td align="right" bgcolor="#FFFFFF">3,169 ms (Δ = -0,081 ms)</td><td align="right" bgcolor="#FF4949">3,681 ms (Δ = +0,512 ms)</td><td align="right" bgcolor="#A8D08D">0,469 ms (Δ = -3,212 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">380</td><td align="right">380</td><td align="right">390</td><td align="right">400</td><td align="right">440</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">100</td><td align="right">100</td><td align="right">109</td><td align="right">110</td><td align="right">110</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">245395</td><td align="right">245447</td><td align="right">249495</td><td align="right">257284</td><td align="right">282849</td><td align="right">27578</td><tr>
<td>Allocated Kilobytes</td><td align="right">239,644</td><td align="right">239,694</td><td align="right">243,647</td><td align="right">251,254</td><td align="right">276,220</td><td align="right">26,932</td><tr>
<td>Allocated Megabytes</td><td align="right">0,234</td><td align="right">0,234</td><td align="right">0,238</td><td align="right">0,245</td><td align="right">0,270</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 15269715,775 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#A8D08D">-97,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15163612,285 ns</td><td align="right" bgcolor="#FFFFFF">15021211,589 ns (Δ = -142400,696 ns)</td><td align="right" bgcolor="#FFFFFF">15352788,643 ns (Δ = +331577,054 ns)</td><td align="right" bgcolor="#FFFFFF">15178449,300 ns (Δ = -174339,343 ns)</td><td align="right" bgcolor="#FF4949">15737256,802 ns (Δ = +558807,502 ns)</td><td align="right" bgcolor="#A8D08D">467541,027 ns (Δ = -15269715,775 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">15163,612 μs</td><td align="right" bgcolor="#FFFFFF">15021,212 μs (Δ = -142,401 μs)</td><td align="right" bgcolor="#FFFFFF">15352,789 μs (Δ = +331,577 μs)</td><td align="right" bgcolor="#FFFFFF">15178,449 μs (Δ = -174,339 μs)</td><td align="right" bgcolor="#FF4949">15737,257 μs (Δ = +558,808 μs)</td><td align="right" bgcolor="#A8D08D">467,541 μs (Δ = -15269,716 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">15,164 ms</td><td align="right" bgcolor="#FFFFFF">15,021 ms (Δ = -0,142 ms)</td><td align="right" bgcolor="#FFFFFF">15,353 ms (Δ = +0,332 ms)</td><td align="right" bgcolor="#FFFFFF">15,178 ms (Δ = -0,174 ms)</td><td align="right" bgcolor="#FF4949">15,737 ms (Δ = +0,559 ms)</td><td align="right" bgcolor="#A8D08D">0,468 ms (Δ = -15,270 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">1810</td><td align="right">1810</td><td align="right">1840</td><td align="right">1900</td><td align="right">2000</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">568</td><td align="right">556</td><td align="right">521</td><td align="right">510</td><td align="right">570</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1144436</td><td align="right">1143247</td><td align="right">1161588</td><td align="right">1200270</td><td align="right">1265003</td><td align="right">27578</td><tr>
<td>Allocated Kilobytes</td><td align="right">1117,613</td><td align="right">1116,452</td><td align="right">1134,363</td><td align="right">1172,139</td><td align="right">1235,354</td><td align="right">26,932</td><tr>
<td>Allocated Megabytes</td><td align="right">1,091</td><td align="right">1,090</td><td align="right">1,108</td><td align="right">1,145</td><td align="right">1,206</td><td align="right">0,026</td></tr>
</table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1092173,353 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FF4949">+27,6 %</td><td align="right" bgcolor="#FFFFFF">+0,9 %</td><td align="right" bgcolor="#FF4949">+55,7 %</td><td align="right" bgcolor="#A8D08D">-69,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">788521,930 ns</td><td align="right" bgcolor="#FFFFFF">787360,490 ns (Δ = -1161,440 ns)</td><td align="right" bgcolor="#FF4949">1004686,673 ns (Δ = +217326,183 ns)</td><td align="right" bgcolor="#FFFFFF">1014130,173 ns (Δ = +9443,500 ns)</td><td align="right" bgcolor="#FF4949">1579217,989 ns (Δ = +565087,816 ns)</td><td align="right" bgcolor="#A8D08D">487044,636 ns (Δ = -1092173,353 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">788,522 μs</td><td align="right" bgcolor="#FFFFFF">787,360 μs (Δ = -1,161 μs)</td><td align="right" bgcolor="#FF4949">1004,687 μs (Δ = +217,326 μs)</td><td align="right" bgcolor="#FFFFFF">1014,130 μs (Δ = +9,444 μs)</td><td align="right" bgcolor="#FF4949">1579,218 μs (Δ = +565,088 μs)</td><td align="right" bgcolor="#A8D08D">487,045 μs (Δ = -1092,173 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,789 ms</td><td align="right" bgcolor="#FFFFFF">0,787 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">1,005 ms (Δ = +0,217 ms)</td><td align="right" bgcolor="#FFFFFF">1,014 ms (Δ = +0,009 ms)</td><td align="right" bgcolor="#FF4949">1,579 ms (Δ = +0,565 ms)</td><td align="right" bgcolor="#A8D08D">0,487 ms (Δ = -1,092 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">860</td><td align="right">860</td><td align="right">870</td><td align="right">880</td><td align="right">920</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">120</td><td align="right">120</td><td align="right">120</td><td align="right">121</td><td align="right">152</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">544326</td><td align="right">544230</td><td align="right">550095</td><td align="right">559319</td><td align="right">586975</td><td align="right">29254</td><tr>
<td>Allocated Kilobytes</td><td align="right">531,568</td><td align="right">531,475</td><td align="right">537,202</td><td align="right">546,210</td><td align="right">573,218</td><td align="right">28,568</td><tr>
<td>Allocated Megabytes</td><td align="right">0,519</td><td align="right">0,519</td><td align="right">0,525</td><td align="right">0,533</td><td align="right">0,560</td><td align="right">0,028</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 525384,420 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FF4949">+49,3 %</td><td align="right" bgcolor="#FF4949">+11,4 %</td><td align="right" bgcolor="#FF4949">+269,6 %</td><td align="right" bgcolor="#A8D08D">-24,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">101107,500 ns</td><td align="right" bgcolor="#FFFFFF">101941,483 ns (Δ = +833,983 ns)</td><td align="right" bgcolor="#FF4949">152197,123 ns (Δ = +50255,640 ns)</td><td align="right" bgcolor="#FF4949">169490,613 ns (Δ = +17293,490 ns)</td><td align="right" bgcolor="#FF4949">626491,920 ns (Δ = +457001,307 ns)</td><td align="right" bgcolor="#A8D08D">470258,460 ns (Δ = -156233,460 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">101,108 μs</td><td align="right" bgcolor="#FFFFFF">101,941 μs (Δ = +0,834 μs)</td><td align="right" bgcolor="#FF4949">152,197 μs (Δ = +50,256 μs)</td><td align="right" bgcolor="#FF4949">169,491 μs (Δ = +17,293 μs)</td><td align="right" bgcolor="#FF4949">626,492 μs (Δ = +457,001 μs)</td><td align="right" bgcolor="#A8D08D">470,258 μs (Δ = -156,233 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,101 ms</td><td align="right" bgcolor="#FFFFFF">0,102 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,152 ms (Δ = +0,050 ms)</td><td align="right" bgcolor="#FF4949">0,169 ms (Δ = +0,017 ms)</td><td align="right" bgcolor="#FF4949">0,626 ms (Δ = +0,457 ms)</td><td align="right" bgcolor="#A8D08D">0,470 ms (Δ = -0,156 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">4.5.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">180</td><td align="right">180</td><td align="right">180</td><td align="right">180</td><td align="right">210</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">30</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">115963</td><td align="right">115911</td><td align="right">117563</td><td align="right">120565</td><td align="right">138414</td><td align="right">29254</td><tr>
<td>Allocated Kilobytes</td><td align="right">113,245</td><td align="right">113,194</td><td align="right">114,808</td><td align="right">117,739</td><td align="right">135,170</td><td align="right">28,568</td><tr>
<td>Allocated Megabytes</td><td align="right">0,111</td><td align="right">0,111</td><td align="right">0,112</td><td align="right">0,115</td><td align="right">0,132</td><td align="right">0,028</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 730851,947 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FF4949">+52,6 %</td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#FF4949">+93,1 %</td><td align="right" bgcolor="#A8D08D">-56,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">353491,333 ns</td><td align="right" bgcolor="#FFFFFF">354585,993 ns (Δ = +1094,660 ns)</td><td align="right" bgcolor="#FF4949">541016,393 ns (Δ = +186430,400 ns)</td><td align="right" bgcolor="#FF4949">561643,007 ns (Δ = +20626,613 ns)</td><td align="right" bgcolor="#FF4949">1084343,280 ns (Δ = +522700,273 ns)</td><td align="right" bgcolor="#A8D08D">474189,864 ns (Δ = -610153,416 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">353,491 μs</td><td align="right" bgcolor="#FFFFFF">354,586 μs (Δ = +1,095 μs)</td><td align="right" bgcolor="#FF4949">541,016 μs (Δ = +186,430 μs)</td><td align="right" bgcolor="#FF4949">561,643 μs (Δ = +20,627 μs)</td><td align="right" bgcolor="#FF4949">1084,343 μs (Δ = +522,700 μs)</td><td align="right" bgcolor="#A8D08D">474,190 μs (Δ = -610,153 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,353 ms</td><td align="right" bgcolor="#FFFFFF">0,355 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,541 ms (Δ = +0,186 ms)</td><td align="right" bgcolor="#FF4949">0,562 ms (Δ = +0,021 ms)</td><td align="right" bgcolor="#FF4949">1,084 ms (Δ = +0,523 ms)</td><td align="right" bgcolor="#A8D08D">0,474 ms (Δ = -0,610 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">620</td><td align="right">620</td><td align="right">630</td><td align="right">650</td><td align="right">690</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">50</td><td align="right">50</td><td align="right">50</td><td align="right">54</td><td align="right">80</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">396416</td><td align="right">396237</td><td align="right">402200</td><td align="right">411950</td><td align="right">437244</td><td align="right">29258</td><tr>
<td>Allocated Kilobytes</td><td align="right">387,125</td><td align="right">386,950</td><td align="right">392,773</td><td align="right">402,295</td><td align="right">426,996</td><td align="right">28,572</td><tr>
<td>Allocated Megabytes</td><td align="right">0,378</td><td align="right">0,378</td><td align="right">0,384</td><td align="right">0,393</td><td align="right">0,417</td><td align="right">0,028</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2830389,167 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,2 %</td><td align="right" bgcolor="#FF4949">+40,7 %</td><td align="right" bgcolor="#FF4949">+5,3 %</td><td align="right" bgcolor="#FF4949">+27,6 %</td><td align="right" bgcolor="#A8D08D">-85,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1750030,553 ns</td><td align="right" bgcolor="#FFFFFF">1746174,877 ns (Δ = -3855,677 ns)</td><td align="right" bgcolor="#FF4949">2457672,322 ns (Δ = +711497,445 ns)</td><td align="right" bgcolor="#FF4949">2588305,413 ns (Δ = +130633,091 ns)</td><td align="right" bgcolor="#FF4949">3303770,433 ns (Δ = +715465,020 ns)</td><td align="right" bgcolor="#A8D08D">473381,267 ns (Δ = -2830389,167 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1750,031 μs</td><td align="right" bgcolor="#FFFFFF">1746,175 μs (Δ = -3,856 μs)</td><td align="right" bgcolor="#FF4949">2457,672 μs (Δ = +711,497 μs)</td><td align="right" bgcolor="#FF4949">2588,305 μs (Δ = +130,633 μs)</td><td align="right" bgcolor="#FF4949">3303,770 μs (Δ = +715,465 μs)</td><td align="right" bgcolor="#A8D08D">473,381 μs (Δ = -2830,389 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,750 ms</td><td align="right" bgcolor="#FFFFFF">1,746 ms (Δ = -0,004 ms)</td><td align="right" bgcolor="#FF4949">2,458 ms (Δ = +0,711 ms)</td><td align="right" bgcolor="#FF4949">2,588 ms (Δ = +0,131 ms)</td><td align="right" bgcolor="#FF4949">3,304 ms (Δ = +0,715 ms)</td><td align="right" bgcolor="#A8D08D">0,473 ms (Δ = -2,830 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">2850</td><td align="right">2850</td><td align="right">2890</td><td align="right">2960</td><td align="right">3060</td><td align="right">40</td></tr>
<tr>
<td>Gen 1</td><td align="right">470</td><td align="right">470</td><td align="right">469</td><td align="right">487</td><td align="right">503</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1799924</td><td align="right">1799766</td><td align="right">1825935</td><td align="right">1868288</td><td align="right">1930214</td><td align="right">29260</td><tr>
<td>Allocated Kilobytes</td><td align="right">1757,738</td><td align="right">1757,584</td><td align="right">1783,140</td><td align="right">1824,500</td><td align="right">1884,975</td><td align="right">28,574</td><tr>
<td>Allocated Megabytes</td><td align="right">1,717</td><td align="right">1,716</td><td align="right">1,741</td><td align="right">1,782</td><td align="right">1,841</td><td align="right">0,028</td></tr>
</table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 1905,565 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#A8D08D">-65,7 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#A8D08D">-4,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2880,142 ns</td><td align="right" bgcolor="#A8D08D">2758,947 ns (Δ = -121,195 ns)</td><td align="right" bgcolor="#FF4949">2868,860 ns (Δ = +109,913 ns)</td><td align="right" bgcolor="#A8D08D">983,480 ns (Δ = -1885,380 ns)</td><td align="right" bgcolor="#FF4949">1022,823 ns (Δ = +39,343 ns)</td><td align="right" bgcolor="#A8D08D">974,577 ns (Δ = -48,247 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,880 μs</td><td align="right" bgcolor="#A8D08D">2,759 μs (Δ = -0,121 μs)</td><td align="right" bgcolor="#FF4949">2,869 μs (Δ = +0,110 μs)</td><td align="right" bgcolor="#A8D08D">0,983 μs (Δ = -1,885 μs)</td><td align="right" bgcolor="#FF4949">1,023 μs (Δ = +0,039 μs)</td><td align="right" bgcolor="#A8D08D">0,975 μs (Δ = -0,048 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = -0,002 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1090</td><td align="right">1090</td><td align="right">1090</td><td align="right">1049</td><td align="right">1049</td><td align="right">1008</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,064</td><td align="right">1,064</td><td align="right">1,064</td><td align="right">1,024</td><td align="right">1,024</td><td align="right">0,984</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 32,616 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,0 %</td><td align="right" bgcolor="#A8D08D">-8,5 %</td><td align="right" bgcolor="#FF4949">+11,1 %</td><td align="right" bgcolor="#A8D08D">-6,4 %</td><td align="right" bgcolor="#A8D08D">-9,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">201,893 ns</td><td align="right" bgcolor="#FF4949">214,033 ns (Δ = +12,140 ns)</td><td align="right" bgcolor="#A8D08D">195,867 ns (Δ = -18,167 ns)</td><td align="right" bgcolor="#FF4949">217,617 ns (Δ = +21,750 ns)</td><td align="right" bgcolor="#A8D08D">203,797 ns (Δ = -13,820 ns)</td><td align="right" bgcolor="#A8D08D">185,001 ns (Δ = -18,796 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,202 μs</td><td align="right" bgcolor="#FF4949">0,214 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#A8D08D">0,196 μs (Δ = -0,018 μs)</td><td align="right" bgcolor="#FF4949">0,218 μs (Δ = +0,022 μs)</td><td align="right" bgcolor="#A8D08D">0,204 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#A8D08D">0,185 μs (Δ = -0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_Transient"></a>ResolveType_Transient

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 609,670 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,5 %</td><td align="right" bgcolor="#FF4949">+4,1 %</td><td align="right" bgcolor="#FF4949">+8,9 %</td><td align="right" bgcolor="#FF4949">+4,7 %</td><td align="right" bgcolor="#A8D08D">-4,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3422,362 ns</td><td align="right" bgcolor="#A8D08D">3268,417 ns (Δ = -153,946 ns)</td><td align="right" bgcolor="#FF4949">3401,393 ns (Δ = +132,977 ns)</td><td align="right" bgcolor="#FF4949">3702,777 ns (Δ = +301,383 ns)</td><td align="right" bgcolor="#FF4949">3878,087 ns (Δ = +175,310 ns)</td><td align="right" bgcolor="#A8D08D">3689,183 ns (Δ = -188,903 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,422 μs</td><td align="right" bgcolor="#A8D08D">3,268 μs (Δ = -0,154 μs)</td><td align="right" bgcolor="#FF4949">3,401 μs (Δ = +0,133 μs)</td><td align="right" bgcolor="#FF4949">3,703 μs (Δ = +0,301 μs)</td><td align="right" bgcolor="#FF4949">3,878 μs (Δ = +0,175 μs)</td><td align="right" bgcolor="#A8D08D">3,689 μs (Δ = -0,189 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1235</td><td align="right">1211</td><td align="right">1211</td><td align="right">1440</td><td align="right">1440</td><td align="right">1448</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,206</td><td align="right">1,183</td><td align="right">1,183</td><td align="right">1,406</td><td align="right">1,406</td><td align="right">1,414</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 35,898 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,6 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#FFFFFF">-2,0 %</td><td align="right" bgcolor="#FF4949">+12,9 %</td><td align="right" bgcolor="#A8D08D">-16,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">191,350 ns</td><td align="right" bgcolor="#FFFFFF">194,378 ns (Δ = +3,028 ns)</td><td align="right" bgcolor="#FF4949">201,296 ns (Δ = +6,917 ns)</td><td align="right" bgcolor="#FFFFFF">197,304 ns (Δ = -3,991 ns)</td><td align="right" bgcolor="#FF4949">222,730 ns (Δ = +25,426 ns)</td><td align="right" bgcolor="#A8D08D">186,832 ns (Δ = -35,898 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,191 μs</td><td align="right" bgcolor="#FFFFFF">0,194 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,201 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,197 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,223 μs (Δ = +0,025 μs)</td><td align="right" bgcolor="#A8D08D">0,187 μs (Δ = -0,036 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency"></a>ResolveType_With_Transient_Dependency

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 940,927 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,6 %</td><td align="right" bgcolor="#FF4949">+10,0 %</td><td align="right" bgcolor="#FFFFFF">+3,0 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#A8D08D">-6,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7485,247 ns</td><td align="right" bgcolor="#A8D08D">7062,670 ns (Δ = -422,577 ns)</td><td align="right" bgcolor="#FF4949">7769,270 ns (Δ = +706,600 ns)</td><td align="right" bgcolor="#FFFFFF">8003,597 ns (Δ = +234,327 ns)</td><td align="right" bgcolor="#FFFFFF">7923,780 ns (Δ = -79,817 ns)</td><td align="right" bgcolor="#A8D08D">7426,247 ns (Δ = -497,533 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,485 μs</td><td align="right" bgcolor="#A8D08D">7,063 μs (Δ = -0,423 μs)</td><td align="right" bgcolor="#FF4949">7,769 μs (Δ = +0,707 μs)</td><td align="right" bgcolor="#FFFFFF">8,004 μs (Δ = +0,234 μs)</td><td align="right" bgcolor="#FFFFFF">7,924 μs (Δ = -0,080 μs)</td><td align="right" bgcolor="#A8D08D">7,426 μs (Δ = -0,498 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#A8D08D">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,007 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">2736</td><td align="right">2687</td><td align="right">2687</td><td align="right">3149</td><td align="right">3145</td><td align="right">3006</td><tr>
<td>Allocated Kilobytes</td><td align="right">2,672</td><td align="right">2,624</td><td align="right">2,624</td><td align="right">3,075</td><td align="right">3,071</td><td align="right">2,936</td><tr>
<td>Allocated Megabytes</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td></tr>
</table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 11,311 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+37,5 %</td><td align="right" bgcolor="#A8D08D">-27,3 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#FFFFFF">-2,1 %</td><td align="right" bgcolor="#FFFFFF">-1,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">27,011 ns</td><td align="right" bgcolor="#FF4949">37,133 ns (Δ = +10,123 ns)</td><td align="right" bgcolor="#A8D08D">26,982 ns (Δ = -10,152 ns)</td><td align="right" bgcolor="#FFFFFF">26,731 ns (Δ = -0,251 ns)</td><td align="right" bgcolor="#FFFFFF">26,174 ns (Δ = -0,557 ns)</td><td align="right" bgcolor="#FFFFFF">25,822 ns (Δ = -0,352 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FF4949">0,037 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#A8D08D">0,027 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,027 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,026 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,026 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyEx"></a>GetAssemblyEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 2,276 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#A8D08D">-7,0 %</td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#A8D08D">-4,9 %</td><td align="right" bgcolor="#FFFFFF">+0,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,924 ns</td><td align="right" bgcolor="#FFFFFF">20,944 ns (Δ = +0,020 ns)</td><td align="right" bgcolor="#A8D08D">19,477 ns (Δ = -1,468 ns)</td><td align="right" bgcolor="#FFFFFF">19,626 ns (Δ = +0,149 ns)</td><td align="right" bgcolor="#A8D08D">18,669 ns (Δ = -0,957 ns)</td><td align="right" bgcolor="#FFFFFF">18,833 ns (Δ = +0,164 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,019 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,020 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,019 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,019 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx"></a>GetAssemblyFullNameEx

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 17,767 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,9 %</td><td align="right" bgcolor="#FFFFFF">+0,3 %</td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FF4949">+65,7 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,213 ns</td><td align="right" bgcolor="#FF4949">22,077 ns (Δ = +2,863 ns)</td><td align="right" bgcolor="#FFFFFF">22,136 ns (Δ = +0,059 ns)</td><td align="right" bgcolor="#FFFFFF">22,311 ns (Δ = +0,176 ns)</td><td align="right" bgcolor="#FF4949">36,980 ns (Δ = +14,669 ns)</td><td align="right" bgcolor="#A8D08D">22,667 ns (Δ = -14,313 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FF4949">0,022 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,037 μs (Δ = +0,015 μs)</td><td align="right" bgcolor="#A8D08D">0,023 μs (Δ = -0,014 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetBaseTypeEx"></a>GetBaseTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 1,718 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,6 %</td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FFFFFF">-1,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30,097 ns</td><td align="right" bgcolor="#FF4949">31,791 ns (Δ = +1,694 ns)</td><td align="right" bgcolor="#A8D08D">30,136 ns (Δ = -1,656 ns)</td><td align="right" bgcolor="#FFFFFF">30,102 ns (Δ = -0,033 ns)</td><td align="right" bgcolor="#FFFFFF">30,497 ns (Δ = +0,394 ns)</td><td align="right" bgcolor="#FFFFFF">30,073 ns (Δ = -0,423 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FF4949">0,032 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,030 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,030 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,030 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,030 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorEx"></a>GetConstructorEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 135,757 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+40,6 %</td><td align="right" bgcolor="#A8D08D">-28,6 %</td><td align="right" bgcolor="#FF4949">+5,8 %</td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#FF4949">+6,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">317,350 ns</td><td align="right" bgcolor="#FF4949">446,103 ns (Δ = +128,753 ns)</td><td align="right" bgcolor="#A8D08D">318,440 ns (Δ = -127,663 ns)</td><td align="right" bgcolor="#FF4949">336,873 ns (Δ = +18,433 ns)</td><td align="right" bgcolor="#A8D08D">310,347 ns (Δ = -26,527 ns)</td><td align="right" bgcolor="#FF4949">329,277 ns (Δ = +18,930 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,317 μs</td><td align="right" bgcolor="#FF4949">0,446 μs (Δ = +0,129 μs)</td><td align="right" bgcolor="#A8D08D">0,318 μs (Δ = -0,128 μs)</td><td align="right" bgcolor="#FF4949">0,337 μs (Δ = +0,018 μs)</td><td align="right" bgcolor="#A8D08D">0,310 μs (Δ = -0,027 μs)</td><td align="right" bgcolor="#FF4949">0,329 μs (Δ = +0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">131</td><td align="right">131</td><td align="right">131</td><td align="right">131</td><td align="right">131</td><td align="right">131</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,128</td><td align="right">0,128</td><td align="right">0,128</td><td align="right">0,128</td><td align="right">0,128</td><td align="right">0,128</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorsEx"></a>GetConstructorsEx

#### Performance

Fastest: **4.2.0**

Slowest: 4.4.0

Δ: 19,258 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,6 %</td><td align="right" bgcolor="#FFFFFF">+2,8 %</td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FF4949">+17,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">92,235 ns</td><td align="right" bgcolor="#FF4949">108,467 ns (Δ = +16,232 ns)</td><td align="right" bgcolor="#FFFFFF">111,493 ns (Δ = +3,027 ns)</td><td align="right" bgcolor="#A8D08D">94,110 ns (Δ = -17,383 ns)</td><td align="right" bgcolor="#FFFFFF">94,507 ns (Δ = +0,397 ns)</td><td align="right" bgcolor="#FF4949">111,010 ns (Δ = +16,503 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#FF4949">0,108 μs (Δ = +0,016 μs)</td><td align="right" bgcolor="#FFFFFF">0,111 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,094 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#FFFFFF">0,095 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,111 μs (Δ = +0,017 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.2.0**

Slowest: 4.4.0

Δ: 185,249 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,9 %</td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FFFFFF">-2,3 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3765,034 ns</td><td align="right" bgcolor="#FFFFFF">3876,098 ns (Δ = +111,064 ns)</td><td align="right" bgcolor="#FFFFFF">3950,283 ns (Δ = +74,185 ns)</td><td align="right" bgcolor="#FFFFFF">3905,673 ns (Δ = -44,610 ns)</td><td align="right" bgcolor="#FFFFFF">3816,900 ns (Δ = -88,773 ns)</td><td align="right" bgcolor="#FFFFFF">3840,347 ns (Δ = +23,447 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,765 μs</td><td align="right" bgcolor="#FFFFFF">3,876 μs (Δ = +0,111 μs)</td><td align="right" bgcolor="#FFFFFF">3,950 μs (Δ = +0,074 μs)</td><td align="right" bgcolor="#FFFFFF">3,906 μs (Δ = -0,045 μs)</td><td align="right" bgcolor="#FFFFFF">3,817 μs (Δ = -0,089 μs)</td><td align="right" bgcolor="#FFFFFF">3,840 μs (Δ = +0,023 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 633,569 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FF4949">+6,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9070,773 ns</td><td align="right" bgcolor="#FFFFFF">9010,031 ns (Δ = -60,742 ns)</td><td align="right" bgcolor="#FFFFFF">8981,653 ns (Δ = -28,378 ns)</td><td align="right" bgcolor="#FFFFFF">9024,409 ns (Δ = +42,756 ns)</td><td align="right" bgcolor="#FFFFFF">9064,731 ns (Δ = +40,322 ns)</td><td align="right" bgcolor="#FF4949">9615,222 ns (Δ = +550,491 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,071 μs</td><td align="right" bgcolor="#FFFFFF">9,010 μs (Δ = -0,061 μs)</td><td align="right" bgcolor="#FFFFFF">8,982 μs (Δ = -0,028 μs)</td><td align="right" bgcolor="#FFFFFF">9,024 μs (Δ = +0,043 μs)</td><td align="right" bgcolor="#FFFFFF">9,065 μs (Δ = +0,040 μs)</td><td align="right" bgcolor="#FF4949">9,615 μs (Δ = +0,550 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,001 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.5.4</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">762</td><td align="right">762</td><td align="right">762</td><td align="right">762</td><td align="right">762</td><td align="right">811</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,792</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 289,620 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FF4949">+5,7 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#A8D08D">-4,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3763,549 ns</td><td align="right" bgcolor="#FFFFFF">3771,330 ns (Δ = +7,781 ns)</td><td align="right" bgcolor="#FF4949">3986,370 ns (Δ = +215,040 ns)</td><td align="right" bgcolor="#A8D08D">3849,780 ns (Δ = -136,590 ns)</td><td align="right" bgcolor="#FFFFFF">3857,961 ns (Δ = +8,181 ns)</td><td align="right" bgcolor="#A8D08D">3696,750 ns (Δ = -161,211 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,764 μs</td><td align="right" bgcolor="#FFFFFF">3,771 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#FF4949">3,986 μs (Δ = +0,215 μs)</td><td align="right" bgcolor="#A8D08D">3,850 μs (Δ = -0,137 μs)</td><td align="right" bgcolor="#FFFFFF">3,858 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#A8D08D">3,697 μs (Δ = -0,161 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 650,153 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#FF4949">+3,1 %</td><td align="right" bgcolor="#FFFFFF">-2,1 %</td><td align="right" bgcolor="#FF4949">+6,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9452,849 ns</td><td align="right" bgcolor="#A8D08D">9038,328 ns (Δ = -414,521 ns)</td><td align="right" bgcolor="#FFFFFF">8895,303 ns (Δ = -143,024 ns)</td><td align="right" bgcolor="#FF4949">9172,907 ns (Δ = +277,603 ns)</td><td align="right" bgcolor="#FFFFFF">8981,517 ns (Δ = -191,390 ns)</td><td align="right" bgcolor="#FF4949">9545,457 ns (Δ = +563,940 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,453 μs</td><td align="right" bgcolor="#A8D08D">9,038 μs (Δ = -0,415 μs)</td><td align="right" bgcolor="#FFFFFF">8,895 μs (Δ = -0,143 μs)</td><td align="right" bgcolor="#FF4949">9,173 μs (Δ = +0,278 μs)</td><td align="right" bgcolor="#FFFFFF">8,982 μs (Δ = -0,191 μs)</td><td align="right" bgcolor="#FF4949">9,545 μs (Δ = +0,564 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#A8D08D">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,001 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.5.4</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">762</td><td align="right">762</td><td align="right">762</td><td align="right">762</td><td align="right">762</td><td align="right">811</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,744</td><td align="right">0,792</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 1,069 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#A8D08D">-5,9 %</td><td align="right" bgcolor="#FFFFFF">-2,2 %</td><td align="right" bgcolor="#FF4949">+13,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,878 ns</td><td align="right" bgcolor="#FF4949">8,342 ns (Δ = +0,464 ns)</td><td align="right" bgcolor="#A8D08D">7,903 ns (Δ = -0,439 ns)</td><td align="right" bgcolor="#A8D08D">7,433 ns (Δ = -0,470 ns)</td><td align="right" bgcolor="#FFFFFF">7,273 ns (Δ = -0,160 ns)</td><td align="right" bgcolor="#FF4949">8,248 ns (Δ = +0,975 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FF4949">0,008 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,008 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,007 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,007 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,008 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 208,640 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,7 %</td><td align="right" bgcolor="#A8D08D">-7,7 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FF4949">+26,2 %</td><td align="right" bgcolor="#A8D08D">-18,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">694,030 ns</td><td align="right" bgcolor="#FF4949">774,957 ns (Δ = +80,927 ns)</td><td align="right" bgcolor="#A8D08D">715,127 ns (Δ = -59,830 ns)</td><td align="right" bgcolor="#FFFFFF">714,995 ns (Δ = -0,132 ns)</td><td align="right" bgcolor="#FF4949">902,670 ns (Δ = +187,675 ns)</td><td align="right" bgcolor="#A8D08D">739,903 ns (Δ = -162,767 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,694 μs</td><td align="right" bgcolor="#FF4949">0,775 μs (Δ = +0,081 μs)</td><td align="right" bgcolor="#A8D08D">0,715 μs (Δ = -0,060 μs)</td><td align="right" bgcolor="#FFFFFF">0,715 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,903 μs (Δ = +0,188 μs)</td><td align="right" bgcolor="#A8D08D">0,740 μs (Δ = -0,163 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Instance"></a>GetEventEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 17,190 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,5 %</td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#FF4949">+10,2 %</td><td align="right" bgcolor="#A8D08D">-8,5 %</td><td align="right" bgcolor="#A8D08D">-3,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">139,889 ns</td><td align="right" bgcolor="#FF4949">144,833 ns (Δ = +4,944 ns)</td><td align="right" bgcolor="#A8D08D">139,292 ns (Δ = -5,541 ns)</td><td align="right" bgcolor="#FF4949">153,537 ns (Δ = +14,244 ns)</td><td align="right" bgcolor="#A8D08D">140,503 ns (Δ = -13,033 ns)</td><td align="right" bgcolor="#A8D08D">136,347 ns (Δ = -4,157 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FF4949">0,145 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,139 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,154 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#A8D08D">0,141 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#A8D08D">0,136 μs (Δ = -0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 1594,953 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+44,4 %</td><td align="right" bgcolor="#A8D08D">-30,2 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#A8D08D">-12,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2909,542 ns</td><td align="right" bgcolor="#FF4949">4200,883 ns (Δ = +1291,341 ns)</td><td align="right" bgcolor="#A8D08D">2931,133 ns (Δ = -1269,750 ns)</td><td align="right" bgcolor="#FFFFFF">2974,176 ns (Δ = +43,042 ns)</td><td align="right" bgcolor="#FFFFFF">2985,509 ns (Δ = +11,333 ns)</td><td align="right" bgcolor="#A8D08D">2605,930 ns (Δ = -379,579 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,910 μs</td><td align="right" bgcolor="#FF4949">4,201 μs (Δ = +1,291 μs)</td><td align="right" bgcolor="#A8D08D">2,931 μs (Δ = -1,270 μs)</td><td align="right" bgcolor="#FFFFFF">2,974 μs (Δ = +0,043 μs)</td><td align="right" bgcolor="#FFFFFF">2,986 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#A8D08D">2,606 μs (Δ = -0,380 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">205</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,200</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 241,090 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,4 %</td><td align="right" bgcolor="#A8D08D">-3,6 %</td><td align="right" bgcolor="#FFFFFF">+1,3 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#A8D08D">-15,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1280,509 ns</td><td align="right" bgcolor="#FF4949">1337,157 ns (Δ = +56,647 ns)</td><td align="right" bgcolor="#A8D08D">1288,467 ns (Δ = -48,690 ns)</td><td align="right" bgcolor="#FFFFFF">1305,650 ns (Δ = +17,183 ns)</td><td align="right" bgcolor="#FFFFFF">1301,497 ns (Δ = -4,153 ns)</td><td align="right" bgcolor="#A8D08D">1096,067 ns (Δ = -205,430 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,281 μs</td><td align="right" bgcolor="#FF4949">1,337 μs (Δ = +0,057 μs)</td><td align="right" bgcolor="#A8D08D">1,288 μs (Δ = -0,049 μs)</td><td align="right" bgcolor="#FFFFFF">1,306 μs (Δ = +0,017 μs)</td><td align="right" bgcolor="#FFFFFF">1,301 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#A8D08D">1,096 μs (Δ = -0,205 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">483</td><td align="right">483</td><td align="right">483</td><td align="right">483</td><td align="right">483</td><td align="right">410</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,472</td><td align="right">0,472</td><td align="right">0,472</td><td align="right">0,472</td><td align="right">0,472</td><td align="right">0,400</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 243,808 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FFFFFF">+2,3 %</td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#A8D08D">-4,7 %</td><td align="right" bgcolor="#A8D08D">-27,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">784,313 ns</td><td align="right" bgcolor="#FFFFFF">765,673 ns (Δ = -18,640 ns)</td><td align="right" bgcolor="#FFFFFF">783,644 ns (Δ = +17,971 ns)</td><td align="right" bgcolor="#FFFFFF">779,309 ns (Δ = -4,336 ns)</td><td align="right" bgcolor="#A8D08D">742,583 ns (Δ = -36,726 ns)</td><td align="right" bgcolor="#A8D08D">540,505 ns (Δ = -202,078 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,784 μs</td><td align="right" bgcolor="#FFFFFF">0,766 μs (Δ = -0,019 μs)</td><td align="right" bgcolor="#FFFFFF">0,784 μs (Δ = +0,018 μs)</td><td align="right" bgcolor="#FFFFFF">0,779 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,743 μs (Δ = -0,037 μs)</td><td align="right" bgcolor="#A8D08D">0,541 μs (Δ = -0,202 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">459</td><td align="right">459</td><td align="right">459</td><td align="right">459</td><td align="right">459</td><td align="right">311</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,448</td><td align="right">0,448</td><td align="right">0,448</td><td align="right">0,448</td><td align="right">0,448</td><td align="right">0,304</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 63,243 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#A8D08D">-6,6 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FFFFFF">+1,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">758,809 ns</td><td align="right" bgcolor="#FF4949">790,647 ns (Δ = +31,838 ns)</td><td align="right" bgcolor="#A8D08D">738,138 ns (Δ = -52,509 ns)</td><td align="right" bgcolor="#FFFFFF">735,473 ns (Δ = -2,665 ns)</td><td align="right" bgcolor="#FFFFFF">727,403 ns (Δ = -8,070 ns)</td><td align="right" bgcolor="#FFFFFF">735,725 ns (Δ = +8,322 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,759 μs</td><td align="right" bgcolor="#FF4949">0,791 μs (Δ = +0,032 μs)</td><td align="right" bgcolor="#A8D08D">0,738 μs (Δ = -0,053 μs)</td><td align="right" bgcolor="#FFFFFF">0,735 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,727 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,736 μs (Δ = +0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags"></a>GetFieldEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **4.3.0**

Slowest: 4.4.0

Δ: 23,874 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,5 %</td><td align="right" bgcolor="#FF4949">+16,6 %</td><td align="right" bgcolor="#A8D08D">-11,0 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#FF4949">+10,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">156,835 ns</td><td align="right" bgcolor="#A8D08D">143,426 ns (Δ = -13,409 ns)</td><td align="right" bgcolor="#FF4949">167,300 ns (Δ = +23,874 ns)</td><td align="right" bgcolor="#A8D08D">148,900 ns (Δ = -18,400 ns)</td><td align="right" bgcolor="#FFFFFF">149,771 ns (Δ = +0,871 ns)</td><td align="right" bgcolor="#FF4949">165,653 ns (Δ = +15,882 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,157 μs</td><td align="right" bgcolor="#A8D08D">0,143 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FF4949">0,167 μs (Δ = +0,024 μs)</td><td align="right" bgcolor="#A8D08D">0,149 μs (Δ = -0,018 μs)</td><td align="right" bgcolor="#FFFFFF">0,150 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,166 μs (Δ = +0,016 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 29,642 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,1 %</td><td align="right" bgcolor="#A8D08D">-11,8 %</td><td align="right" bgcolor="#FF4949">+9,6 %</td><td align="right" bgcolor="#A8D08D">-14,1 %</td><td align="right" bgcolor="#FF4949">+7,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">169,133 ns</td><td align="right" bgcolor="#FF4949">174,387 ns (Δ = +5,253 ns)</td><td align="right" bgcolor="#A8D08D">153,759 ns (Δ = -20,628 ns)</td><td align="right" bgcolor="#FF4949">168,551 ns (Δ = +14,792 ns)</td><td align="right" bgcolor="#A8D08D">144,744 ns (Δ = -23,807 ns)</td><td align="right" bgcolor="#FF4949">155,089 ns (Δ = +10,345 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,169 μs</td><td align="right" bgcolor="#FF4949">0,174 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,154 μs (Δ = -0,021 μs)</td><td align="right" bgcolor="#FF4949">0,169 μs (Δ = +0,015 μs)</td><td align="right" bgcolor="#A8D08D">0,145 μs (Δ = -0,024 μs)</td><td align="right" bgcolor="#FF4949">0,155 μs (Δ = +0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 36,358 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,3 %</td><td align="right" bgcolor="#A8D08D">-6,7 %</td><td align="right" bgcolor="#FF4949">+17,9 %</td><td align="right" bgcolor="#A8D08D">-19,9 %</td><td align="right" bgcolor="#FF4949">+6,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">156,493 ns</td><td align="right" bgcolor="#FF4949">166,277 ns (Δ = +9,783 ns)</td><td align="right" bgcolor="#A8D08D">155,190 ns (Δ = -11,087 ns)</td><td align="right" bgcolor="#FF4949">182,920 ns (Δ = +27,730 ns)</td><td align="right" bgcolor="#A8D08D">146,562 ns (Δ = -36,358 ns)</td><td align="right" bgcolor="#FF4949">155,902 ns (Δ = +9,341 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td><td align="right" bgcolor="#FF4949">0,166 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#A8D08D">0,155 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#FF4949">0,183 μs (Δ = +0,028 μs)</td><td align="right" bgcolor="#A8D08D">0,147 μs (Δ = -0,036 μs)</td><td align="right" bgcolor="#FF4949">0,156 μs (Δ = +0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 43,290 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,9 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FF4949">+3,3 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">603,988 ns</td><td align="right" bgcolor="#A8D08D">562,147 ns (Δ = -41,842 ns)</td><td align="right" bgcolor="#FFFFFF">567,693 ns (Δ = +5,546 ns)</td><td align="right" bgcolor="#FF4949">586,673 ns (Δ = +18,981 ns)</td><td align="right" bgcolor="#FFFFFF">592,430 ns (Δ = +5,757 ns)</td><td align="right" bgcolor="#FFFFFF">605,437 ns (Δ = +13,007 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,604 μs</td><td align="right" bgcolor="#A8D08D">0,562 μs (Δ = -0,042 μs)</td><td align="right" bgcolor="#FFFFFF">0,568 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FF4949">0,587 μs (Δ = +0,019 μs)</td><td align="right" bgcolor="#FFFFFF">0,592 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,605 μs (Δ = +0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.5.4</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">287</td><td align="right">279</td><td align="right">319</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,280</td><td align="right">0,272</td><td align="right">0,312</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 36,462 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,0 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#A8D08D">-11,1 %</td><td align="right" bgcolor="#FF4949">+9,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">159,420 ns</td><td align="right" bgcolor="#A8D08D">148,253 ns (Δ = -11,167 ns)</td><td align="right" bgcolor="#A8D08D">142,138 ns (Δ = -6,116 ns)</td><td align="right" bgcolor="#FFFFFF">138,236 ns (Δ = -3,902 ns)</td><td align="right" bgcolor="#A8D08D">122,958 ns (Δ = -15,278 ns)</td><td align="right" bgcolor="#FF4949">134,663 ns (Δ = +11,706 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,159 μs</td><td align="right" bgcolor="#A8D08D">0,148 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,142 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,138 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,123 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FF4949">0,135 μs (Δ = +0,012 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 54,690 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#FFFFFF">+2,0 %</td><td align="right" bgcolor="#FFFFFF">+2,5 %</td><td align="right" bgcolor="#A8D08D">-5,9 %</td><td align="right" bgcolor="#FF4949">+5,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">895,760 ns</td><td align="right" bgcolor="#FFFFFF">890,462 ns (Δ = -5,298 ns)</td><td align="right" bgcolor="#FFFFFF">908,109 ns (Δ = +17,647 ns)</td><td align="right" bgcolor="#FFFFFF">930,516 ns (Δ = +22,407 ns)</td><td align="right" bgcolor="#A8D08D">875,826 ns (Δ = -54,690 ns)</td><td align="right" bgcolor="#FF4949">925,995 ns (Δ = +50,169 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,896 μs</td><td align="right" bgcolor="#FFFFFF">0,890 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,908 μs (Δ = +0,018 μs)</td><td align="right" bgcolor="#FFFFFF">0,931 μs (Δ = +0,022 μs)</td><td align="right" bgcolor="#A8D08D">0,876 μs (Δ = -0,055 μs)</td><td align="right" bgcolor="#FF4949">0,926 μs (Δ = +0,050 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.5.4</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">336</td><td align="right">360</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,328</td><td align="right">0,352</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **4.3.0**

Slowest: 4.4.0

Δ: 52,561 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,6 %</td><td align="right" bgcolor="#FF4949">+40,0 %</td><td align="right" bgcolor="#A8D08D">-20,1 %</td><td align="right" bgcolor="#A8D08D">-9,1 %</td><td align="right" bgcolor="#FF4949">+10,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">136,338 ns</td><td align="right" bgcolor="#A8D08D">131,389 ns (Δ = -4,949 ns)</td><td align="right" bgcolor="#FF4949">183,950 ns (Δ = +52,561 ns)</td><td align="right" bgcolor="#A8D08D">146,993 ns (Δ = -36,957 ns)</td><td align="right" bgcolor="#A8D08D">133,582 ns (Δ = -13,411 ns)</td><td align="right" bgcolor="#FF4949">146,910 ns (Δ = +13,328 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#A8D08D">0,131 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">0,184 μs (Δ = +0,053 μs)</td><td align="right" bgcolor="#A8D08D">0,147 μs (Δ = -0,037 μs)</td><td align="right" bgcolor="#A8D08D">0,134 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FF4949">0,147 μs (Δ = +0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 48,518 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,1 %</td><td align="right" bgcolor="#FF4949">+10,5 %</td><td align="right" bgcolor="#FF4949">+17,9 %</td><td align="right" bgcolor="#A8D08D">-23,7 %</td><td align="right" bgcolor="#FF4949">+23,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">184,717 ns</td><td align="right" bgcolor="#A8D08D">156,884 ns (Δ = -27,832 ns)</td><td align="right" bgcolor="#FF4949">173,373 ns (Δ = +16,489 ns)</td><td align="right" bgcolor="#FF4949">204,437 ns (Δ = +31,063 ns)</td><td align="right" bgcolor="#A8D08D">155,919 ns (Δ = -48,518 ns)</td><td align="right" bgcolor="#FF4949">192,460 ns (Δ = +36,541 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,185 μs</td><td align="right" bgcolor="#A8D08D">0,157 μs (Δ = -0,028 μs)</td><td align="right" bgcolor="#FF4949">0,173 μs (Δ = +0,016 μs)</td><td align="right" bgcolor="#FF4949">0,204 μs (Δ = +0,031 μs)</td><td align="right" bgcolor="#A8D08D">0,156 μs (Δ = -0,049 μs)</td><td align="right" bgcolor="#FF4949">0,192 μs (Δ = +0,037 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx"></a>GetGenericTypeDefinitionEx

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 23,438 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FF4949">+6,0 %</td><td align="right" bgcolor="#FFFFFF">+1,7 %</td><td align="right" bgcolor="#FF4949">+13,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">105,058 ns</td><td align="right" bgcolor="#FFFFFF">104,019 ns (Δ = -1,039 ns)</td><td align="right" bgcolor="#FFFFFF">103,649 ns (Δ = -0,370 ns)</td><td align="right" bgcolor="#FF4949">109,898 ns (Δ = +6,249 ns)</td><td align="right" bgcolor="#FFFFFF">111,733 ns (Δ = +1,836 ns)</td><td align="right" bgcolor="#FF4949">127,087 ns (Δ = +15,353 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,104 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,110 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,112 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,127 μs (Δ = +0,015 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetInterfacesEx"></a>GetInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 40,350 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FFFFFF">-2,9 %</td><td align="right" bgcolor="#FFFFFF">-2,1 %</td><td align="right" bgcolor="#FF4949">+5,4 %</td><td align="right" bgcolor="#A8D08D">-16,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">211,353 ns</td><td align="right" bgcolor="#A8D08D">204,033 ns (Δ = -7,320 ns)</td><td align="right" bgcolor="#FFFFFF">198,167 ns (Δ = -5,867 ns)</td><td align="right" bgcolor="#FFFFFF">194,013 ns (Δ = -4,154 ns)</td><td align="right" bgcolor="#FF4949">204,560 ns (Δ = +10,548 ns)</td><td align="right" bgcolor="#A8D08D">171,003 ns (Δ = -33,557 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#A8D08D">0,204 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,198 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,194 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,205 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,171 μs (Δ = -0,034 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">221</td><td align="right">221</td><td align="right">221</td><td align="right">221</td><td align="right">221</td><td align="right">197</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,216</td><td align="right">0,216</td><td align="right">0,216</td><td align="right">0,216</td><td align="right">0,216</td><td align="right">0,192</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 153,680 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,6 %</td><td align="right" bgcolor="#A8D08D">-10,4 %</td><td align="right" bgcolor="#FF4949">+6,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1413,410 ns</td><td align="right" bgcolor="#FF4949">1477,880 ns (Δ = +64,470 ns)</td><td align="right" bgcolor="#A8D08D">1324,200 ns (Δ = -153,680 ns)</td><td align="right" bgcolor="#FF4949">1408,573 ns (Δ = +84,373 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,413 μs</td><td align="right" bgcolor="#FF4949">1,478 μs (Δ = +0,064 μs)</td><td align="right" bgcolor="#A8D08D">1,324 μs (Δ = -0,154 μs)</td><td align="right" bgcolor="#FF4949">1,409 μs (Δ = +0,084 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">270</td><td align="right">270</td><td align="right">270</td><td align="right">270</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,264</td><td align="right">0,264</td><td align="right">0,264</td><td align="right">0,264</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 45,523 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FFFFFF">-2,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">804,177 ns</td><td align="right" bgcolor="#A8D08D">776,927 ns (Δ = -27,250 ns)</td><td align="right" bgcolor="#FFFFFF">774,543 ns (Δ = -2,383 ns)</td><td align="right" bgcolor="#FFFFFF">758,653 ns (Δ = -15,890 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,804 μs</td><td align="right" bgcolor="#A8D08D">0,777 μs (Δ = -0,027 μs)</td><td align="right" bgcolor="#FFFFFF">0,775 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,759 μs (Δ = -0,016 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance"></a>GetMemberEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 330,937 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,3 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FFFFFF">-1,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1097,890 ns</td><td align="right" bgcolor="#A8D08D">787,649 ns (Δ = -310,241 ns)</td><td align="right" bgcolor="#FFFFFF">781,362 ns (Δ = -6,286 ns)</td><td align="right" bgcolor="#FFFFFF">766,953 ns (Δ = -14,409 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,098 μs</td><td align="right" bgcolor="#A8D08D">0,788 μs (Δ = -0,310 μs)</td><td align="right" bgcolor="#FFFFFF">0,781 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,767 μs (Δ = -0,014 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">41</td><td align="right">41</td><td align="right">41</td><td align="right">41</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,040</td><td align="right">0,040</td><td align="right">0,040</td><td align="right">0,040</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 48,993 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,7 %</td><td align="right" bgcolor="#A8D08D">-5,9 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">753,629 ns</td><td align="right" bgcolor="#FFFFFF">773,880 ns (Δ = +20,251 ns)</td><td align="right" bgcolor="#A8D08D">728,160 ns (Δ = -45,720 ns)</td><td align="right" bgcolor="#FFFFFF">724,887 ns (Δ = -3,273 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,754 μs</td><td align="right" bgcolor="#FFFFFF">0,774 μs (Δ = +0,020 μs)</td><td align="right" bgcolor="#A8D08D">0,728 μs (Δ = -0,046 μs)</td><td align="right" bgcolor="#FFFFFF">0,725 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static"></a>GetMethodEx_Flatten_Static

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 199,760 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+25,8 %</td><td align="right" bgcolor="#A8D08D">-21,1 %</td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">751,119 ns</td><td align="right" bgcolor="#FF4949">945,167 ns (Δ = +194,048 ns)</td><td align="right" bgcolor="#A8D08D">745,407 ns (Δ = -199,760 ns)</td><td align="right" bgcolor="#FFFFFF">748,811 ns (Δ = +3,404 ns)</td><td align="right" bgcolor="#FFFFFF">748,478 ns (Δ = -0,333 ns)</td><td align="right" bgcolor="#FF4949">778,480 ns (Δ = +30,002 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,751 μs</td><td align="right" bgcolor="#FF4949">0,945 μs (Δ = +0,194 μs)</td><td align="right" bgcolor="#A8D08D">0,745 μs (Δ = -0,200 μs)</td><td align="right" bgcolor="#FFFFFF">0,749 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,748 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,778 μs (Δ = +0,030 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags"></a>GetMethodEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 26,136 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FF4949">+15,0 %</td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FF4949">+11,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">166,053 ns</td><td align="right" bgcolor="#FFFFFF">164,881 ns (Δ = -1,172 ns)</td><td align="right" bgcolor="#FF4949">189,687 ns (Δ = +24,806 ns)</td><td align="right" bgcolor="#A8D08D">173,301 ns (Δ = -16,386 ns)</td><td align="right" bgcolor="#FFFFFF">170,713 ns (Δ = -2,588 ns)</td><td align="right" bgcolor="#FF4949">191,017 ns (Δ = +20,303 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#FFFFFF">0,165 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,190 μs (Δ = +0,025 μs)</td><td align="right" bgcolor="#A8D08D">0,173 μs (Δ = -0,016 μs)</td><td align="right" bgcolor="#FFFFFF">0,171 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,191 μs (Δ = +0,020 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 19,267 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#A8D08D">-9,5 %</td><td align="right" bgcolor="#FFFFFF">+1,5 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FF4949">+6,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">200,417 ns</td><td align="right" bgcolor="#FFFFFF">202,484 ns (Δ = +2,068 ns)</td><td align="right" bgcolor="#A8D08D">183,218 ns (Δ = -19,267 ns)</td><td align="right" bgcolor="#FFFFFF">186,008 ns (Δ = +2,790 ns)</td><td align="right" bgcolor="#FFFFFF">188,564 ns (Δ = +2,557 ns)</td><td align="right" bgcolor="#FF4949">199,793 ns (Δ = +11,229 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,200 μs</td><td align="right" bgcolor="#FFFFFF">0,202 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,183 μs (Δ = -0,019 μs)</td><td align="right" bgcolor="#FFFFFF">0,186 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,189 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,200 μs (Δ = +0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 22,320 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FF4949">+13,2 %</td><td align="right" bgcolor="#A8D08D">-10,7 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">180,073 ns</td><td align="right" bgcolor="#FFFFFF">175,697 ns (Δ = -4,377 ns)</td><td align="right" bgcolor="#A8D08D">169,600 ns (Δ = -6,097 ns)</td><td align="right" bgcolor="#FF4949">191,920 ns (Δ = +22,320 ns)</td><td align="right" bgcolor="#A8D08D">171,386 ns (Δ = -20,534 ns)</td><td align="right" bgcolor="#FFFFFF">173,510 ns (Δ = +2,124 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,180 μs</td><td align="right" bgcolor="#FFFFFF">0,176 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,170 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,192 μs (Δ = +0,022 μs)</td><td align="right" bgcolor="#A8D08D">0,171 μs (Δ = -0,021 μs)</td><td align="right" bgcolor="#FFFFFF">0,174 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 3755,007 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#FF4949">+25,6 %</td><td align="right" bgcolor="#A8D08D">-17,4 %</td><td align="right" bgcolor="#A8D08D">-23,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8689,450 ns</td><td align="right" bgcolor="#A8D08D">8356,745 ns (Δ = -332,705 ns)</td><td align="right" bgcolor="#FFFFFF">8127,917 ns (Δ = -228,828 ns)</td><td align="right" bgcolor="#FF4949">10212,287 ns (Δ = +2084,370 ns)</td><td align="right" bgcolor="#A8D08D">8432,083 ns (Δ = -1780,203 ns)</td><td align="right" bgcolor="#A8D08D">6457,280 ns (Δ = -1974,803 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,689 μs</td><td align="right" bgcolor="#A8D08D">8,357 μs (Δ = -0,333 μs)</td><td align="right" bgcolor="#FFFFFF">8,128 μs (Δ = -0,229 μs)</td><td align="right" bgcolor="#FF4949">10,212 μs (Δ = +2,084 μs)</td><td align="right" bgcolor="#A8D08D">8,432 μs (Δ = -1,780 μs)</td><td align="right" bgcolor="#A8D08D">6,457 μs (Δ = -1,975 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#A8D08D">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,008 ms (Δ = -0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = -0,002 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">2900</td><td align="right">2900</td><td align="right">2900</td><td align="right">2900</td><td align="right">2975</td><td align="right">2286</td><tr>
<td>Allocated Kilobytes</td><td align="right">2,832</td><td align="right">2,832</td><td align="right">2,832</td><td align="right">2,832</td><td align="right">2,905</td><td align="right">2,232</td><tr>
<td>Allocated Megabytes</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,002</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 982,787 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#FF4949">+35,5 %</td><td align="right" bgcolor="#A8D08D">-30,0 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td><td align="right" bgcolor="#A8D08D">-23,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1527,477 ns</td><td align="right" bgcolor="#FF4949">1603,919 ns (Δ = +76,443 ns)</td><td align="right" bgcolor="#FF4949">2173,327 ns (Δ = +569,408 ns)</td><td align="right" bgcolor="#A8D08D">1521,820 ns (Δ = -651,507 ns)</td><td align="right" bgcolor="#FFFFFF">1558,257 ns (Δ = +36,437 ns)</td><td align="right" bgcolor="#A8D08D">1190,540 ns (Δ = -367,717 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,527 μs</td><td align="right" bgcolor="#FF4949">1,604 μs (Δ = +0,076 μs)</td><td align="right" bgcolor="#FF4949">2,173 μs (Δ = +0,569 μs)</td><td align="right" bgcolor="#A8D08D">1,522 μs (Δ = -0,652 μs)</td><td align="right" bgcolor="#FFFFFF">1,558 μs (Δ = +0,036 μs)</td><td align="right" bgcolor="#A8D08D">1,191 μs (Δ = -0,368 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">41</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,040</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 2090,799 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,8 %</td><td align="right" bgcolor="#FFFFFF">+0,0 %</td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#FFFFFF">-2,1 %</td><td align="right" bgcolor="#A8D08D">-24,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7635,473 ns</td><td align="right" bgcolor="#FFFFFF">7694,453 ns (Δ = +58,980 ns)</td><td align="right" bgcolor="#FFFFFF">7697,030 ns (Δ = +2,577 ns)</td><td align="right" bgcolor="#FF4949">7944,516 ns (Δ = +247,486 ns)</td><td align="right" bgcolor="#FFFFFF">7779,473 ns (Δ = -165,042 ns)</td><td align="right" bgcolor="#A8D08D">5853,717 ns (Δ = -1925,757 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,635 μs</td><td align="right" bgcolor="#FFFFFF">7,694 μs (Δ = +0,059 μs)</td><td align="right" bgcolor="#FFFFFF">7,697 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">7,945 μs (Δ = +0,247 μs)</td><td align="right" bgcolor="#FFFFFF">7,779 μs (Δ = -0,165 μs)</td><td align="right" bgcolor="#A8D08D">5,854 μs (Δ = -1,926 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = -0,002 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">5005</td><td align="right">5005</td><td align="right">5005</td><td align="right">5005</td><td align="right">5119</td><td align="right">3834</td><tr>
<td>Allocated Kilobytes</td><td align="right">4,888</td><td align="right">4,888</td><td align="right">4,888</td><td align="right">4,888</td><td align="right">4,999</td><td align="right">3,744</td><tr>
<td>Allocated Megabytes</td><td align="right">0,005</td><td align="right">0,005</td><td align="right">0,005</td><td align="right">0,005</td><td align="right">0,005</td><td align="right">0,004</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 375,633 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#FFFFFF">-1,7 %</td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#A8D08D">-21,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1581,937 ns</td><td align="right" bgcolor="#A8D08D">1497,473 ns (Δ = -84,463 ns)</td><td align="right" bgcolor="#FF4949">1560,831 ns (Δ = +63,358 ns)</td><td align="right" bgcolor="#FFFFFF">1533,637 ns (Δ = -27,194 ns)</td><td align="right" bgcolor="#FFFFFF">1539,810 ns (Δ = +6,173 ns)</td><td align="right" bgcolor="#A8D08D">1206,303 ns (Δ = -333,507 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,582 μs</td><td align="right" bgcolor="#A8D08D">1,497 μs (Δ = -0,084 μs)</td><td align="right" bgcolor="#FF4949">1,561 μs (Δ = +0,063 μs)</td><td align="right" bgcolor="#FFFFFF">1,534 μs (Δ = -0,027 μs)</td><td align="right" bgcolor="#FFFFFF">1,540 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#A8D08D">1,206 μs (Δ = -0,334 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">41</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,040</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 103,359 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,2 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#FF4949">+7,8 %</td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#A8D08D">-8,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">920,517 ns</td><td align="right" bgcolor="#A8D08D">854,032 ns (Δ = -66,484 ns)</td><td align="right" bgcolor="#A8D08D">825,159 ns (Δ = -28,873 ns)</td><td align="right" bgcolor="#FF4949">889,767 ns (Δ = +64,608 ns)</td><td align="right" bgcolor="#FFFFFF">891,736 ns (Δ = +1,969 ns)</td><td align="right" bgcolor="#A8D08D">817,158 ns (Δ = -74,578 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,921 μs</td><td align="right" bgcolor="#A8D08D">0,854 μs (Δ = -0,066 μs)</td><td align="right" bgcolor="#A8D08D">0,825 μs (Δ = -0,029 μs)</td><td align="right" bgcolor="#FF4949">0,890 μs (Δ = +0,065 μs)</td><td align="right" bgcolor="#FFFFFF">0,892 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,817 μs (Δ = -0,075 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">270</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,264</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 149,700 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#A8D08D">-6,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1725,233 ns</td><td align="right" bgcolor="#FFFFFF">1719,177 ns (Δ = -6,057 ns)</td><td align="right" bgcolor="#FFFFFF">1739,863 ns (Δ = +20,687 ns)</td><td align="right" bgcolor="#A8D08D">1682,330 ns (Δ = -57,533 ns)</td><td align="right" bgcolor="#FFFFFF">1702,330 ns (Δ = +20,000 ns)</td><td align="right" bgcolor="#A8D08D">1590,163 ns (Δ = -112,167 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,725 μs</td><td align="right" bgcolor="#FFFFFF">1,719 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FFFFFF">1,740 μs (Δ = +0,021 μs)</td><td align="right" bgcolor="#A8D08D">1,682 μs (Δ = -0,058 μs)</td><td align="right" bgcolor="#FFFFFF">1,702 μs (Δ = +0,020 μs)</td><td align="right" bgcolor="#A8D08D">1,590 μs (Δ = -0,112 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">655</td><td align="right">655</td><td align="right">655</td><td align="right">655</td><td align="right">672</td><td align="right">631</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,640</td><td align="right">0,640</td><td align="right">0,640</td><td align="right">0,640</td><td align="right">0,656</td><td align="right">0,616</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 411,426 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,3 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FF4949">+21,8 %</td><td align="right" bgcolor="#FF4949">+14,6 %</td><td align="right" bgcolor="#A8D08D">-28,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1033,877 ns</td><td align="right" bgcolor="#FFFFFF">1030,697 ns (Δ = -3,180 ns)</td><td align="right" bgcolor="#FFFFFF">1020,398 ns (Δ = -10,299 ns)</td><td align="right" bgcolor="#FF4949">1242,800 ns (Δ = +222,403 ns)</td><td align="right" bgcolor="#FF4949">1423,657 ns (Δ = +180,857 ns)</td><td align="right" bgcolor="#A8D08D">1012,231 ns (Δ = -411,426 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,034 μs</td><td align="right" bgcolor="#FFFFFF">1,031 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">1,020 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FF4949">1,243 μs (Δ = +0,222 μs)</td><td align="right" bgcolor="#FF4949">1,424 μs (Δ = +0,181 μs)</td><td align="right" bgcolor="#A8D08D">1,012 μs (Δ = -0,411 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">713</td><td align="right">713</td><td align="right">713</td><td align="right">713</td><td align="right">737</td><td align="right">680</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,696</td><td align="right">0,696</td><td align="right">0,696</td><td align="right">0,696</td><td align="right">0,720</td><td align="right">0,664</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 41,519 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#FF4949">+3,4 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#A8D08D">-12,9 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">312,677 ns</td><td align="right" bgcolor="#FFFFFF">311,173 ns (Δ = -1,503 ns)</td><td align="right" bgcolor="#A8D08D">300,551 ns (Δ = -10,622 ns)</td><td align="right" bgcolor="#FF4949">310,730 ns (Δ = +10,179 ns)</td><td align="right" bgcolor="#FF4949">321,970 ns (Δ = +11,240 ns)</td><td align="right" bgcolor="#A8D08D">280,451 ns (Δ = -41,519 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,313 μs</td><td align="right" bgcolor="#FFFFFF">0,311 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,301 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#FF4949">0,311 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#FF4949">0,322 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,280 μs (Δ = -0,042 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">41</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,040</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **4.2.0**

Slowest: 4.3.0

Δ: 23,028 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,1 %</td><td align="right" bgcolor="#FFFFFF">-0,6 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#FFFFFF">+0,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">739,563 ns</td><td align="right" bgcolor="#FF4949">762,591 ns (Δ = +23,028 ns)</td><td align="right" bgcolor="#FFFFFF">757,729 ns (Δ = -4,862 ns)</td><td align="right" bgcolor="#FFFFFF">756,750 ns (Δ = -0,979 ns)</td><td align="right" bgcolor="#FFFFFF">746,644 ns (Δ = -10,106 ns)</td><td align="right" bgcolor="#FFFFFF">749,111 ns (Δ = +2,467 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,740 μs</td><td align="right" bgcolor="#FF4949">0,763 μs (Δ = +0,023 μs)</td><td align="right" bgcolor="#FFFFFF">0,758 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,757 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,747 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,749 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance"></a>GetPropertyEx_Instance

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.4

Δ: 18,747 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-2,0 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FF4949">+4,5 %</td><td align="right" bgcolor="#FF4949">+6,1 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">178,519 ns</td><td align="right" bgcolor="#FFFFFF">174,942 ns (Δ = -3,578 ns)</td><td align="right" bgcolor="#FFFFFF">173,198 ns (Δ = -1,744 ns)</td><td align="right" bgcolor="#FF4949">180,938 ns (Δ = +7,740 ns)</td><td align="right" bgcolor="#FF4949">191,944 ns (Δ = +11,007 ns)</td><td align="right" bgcolor="#FFFFFF">191,398 ns (Δ = -0,547 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,179 μs</td><td align="right" bgcolor="#FFFFFF">0,175 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,173 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,181 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#FF4949">0,192 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#FFFFFF">0,191 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><td align="right">8</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 463,290 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FF4949">+3,3 %</td><td align="right" bgcolor="#FFFFFF">-1,0 %</td><td align="right" bgcolor="#FFFFFF">+3,0 %</td><td align="right" bgcolor="#A8D08D">-14,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2977,587 ns</td><td align="right" bgcolor="#FFFFFF">2983,997 ns (Δ = +6,410 ns)</td><td align="right" bgcolor="#FF4949">3083,702 ns (Δ = +99,706 ns)</td><td align="right" bgcolor="#FFFFFF">3054,204 ns (Δ = -29,498 ns)</td><td align="right" bgcolor="#FFFFFF">3146,967 ns (Δ = +92,762 ns)</td><td align="right" bgcolor="#A8D08D">2683,677 ns (Δ = -463,290 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,978 μs</td><td align="right" bgcolor="#FFFFFF">2,984 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FF4949">3,084 μs (Δ = +0,100 μs)</td><td align="right" bgcolor="#FFFFFF">3,054 μs (Δ = -0,029 μs)</td><td align="right" bgcolor="#FFFFFF">3,147 μs (Δ = +0,093 μs)</td><td align="right" bgcolor="#A8D08D">2,684 μs (Δ = -0,463 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">205</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,200</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 55,552 ns


<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,2 %</td><td align="right" bgcolor="#FFFFFF">-1,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">260,960 ns</td><td align="right" bgcolor="#A8D08D">208,244 ns (Δ = -52,716 ns)</td><td align="right" bgcolor="#FFFFFF">205,408 ns (Δ = -2,837 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,261 μs</td><td align="right" bgcolor="#A8D08D">0,208 μs (Δ = -0,053 μs)</td><td align="right" bgcolor="#FFFFFF">0,205 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.5.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">311</td><td align="right">311</td><td align="right">311</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,304</td><td align="right">0,304</td><td align="right">0,304</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetTypeInfo"></a>GetTypeInfo

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 1,150 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,4 %</td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#FFFFFF">+1,7 %</td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,113 ns</td><td align="right" bgcolor="#FFFFFF">14,175 ns (Δ = +0,062 ns)</td><td align="right" bgcolor="#FF4949">15,007 ns (Δ = +0,832 ns)</td><td align="right" bgcolor="#FFFFFF">15,263 ns (Δ = +0,257 ns)</td><td align="right" bgcolor="#FFFFFF">14,898 ns (Δ = -0,366 ns)</td><td align="right" bgcolor="#FFFFFF">15,227 ns (Δ = +0,329 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,015 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_HasBaseTypeEx"></a>HasBaseTypeEx

#### Performance

Fastest: **4.5.0**

Slowest: 4.2.0

Δ: 13,918 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,7 %</td><td align="right" bgcolor="#A8D08D">-17,6 %</td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#FF4949">+21,4 %</td><td align="right" bgcolor="#A8D08D">-12,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">51,030 ns</td><td align="right" bgcolor="#A8D08D">47,087 ns (Δ = -3,943 ns)</td><td align="right" bgcolor="#A8D08D">38,796 ns (Δ = -8,291 ns)</td><td align="right" bgcolor="#A8D08D">37,112 ns (Δ = -1,684 ns)</td><td align="right" bgcolor="#FF4949">45,067 ns (Δ = +7,955 ns)</td><td align="right" bgcolor="#A8D08D">39,282 ns (Δ = -5,784 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#A8D08D">0,047 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,039 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#A8D08D">0,037 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,045 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#A8D08D">0,039 μs (Δ = -0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx"></a>ImplementsInterfaceEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 13,051 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FF4949">+28,9 %</td><td align="right" bgcolor="#A8D08D">-21,6 %</td><td align="right" bgcolor="#A8D08D">-4,5 %</td><td align="right" bgcolor="#FF4949">+3,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">40,707 ns</td><td align="right" bgcolor="#FFFFFF">40,396 ns (Δ = -0,311 ns)</td><td align="right" bgcolor="#FF4949">52,057 ns (Δ = +11,661 ns)</td><td align="right" bgcolor="#A8D08D">40,837 ns (Δ = -11,220 ns)</td><td align="right" bgcolor="#A8D08D">39,006 ns (Δ = -1,831 ns)</td><td align="right" bgcolor="#FF4949">40,244 ns (Δ = +1,238 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,052 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#A8D08D">0,041 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,039 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,040 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx"></a>ImplementsInterfacesEx

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0

Δ: 5,842 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,3 %</td><td align="right" bgcolor="#FFFFFF">+0,5 %</td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FFFFFF">-1,3 %</td><td align="right" bgcolor="#FF4949">+15,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35,572 ns</td><td align="right" bgcolor="#FF4949">36,738 ns (Δ = +1,167 ns)</td><td align="right" bgcolor="#FFFFFF">36,923 ns (Δ = +0,184 ns)</td><td align="right" bgcolor="#FFFFFF">36,499 ns (Δ = -0,423 ns)</td><td align="right" bgcolor="#FFFFFF">36,020 ns (Δ = -0,479 ns)</td><td align="right" bgcolor="#FF4949">41,413 ns (Δ = +5,393 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FF4949">0,037 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,037 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,036 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,036 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,041 μs (Δ = +0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsAbstractEx"></a>IsAbstractEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 1,022 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,8 %</td><td align="right" bgcolor="#FFFFFF">+1,7 %</td><td align="right" bgcolor="#FFFFFF">-0,9 %</td><td align="right" bgcolor="#FFFFFF">-2,2 %</td><td align="right" bgcolor="#FFFFFF">+2,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,473 ns</td><td align="right" bgcolor="#A8D08D">15,682 ns (Δ = -0,791 ns)</td><td align="right" bgcolor="#FFFFFF">15,956 ns (Δ = +0,274 ns)</td><td align="right" bgcolor="#FFFFFF">15,807 ns (Δ = -0,149 ns)</td><td align="right" bgcolor="#FFFFFF">15,451 ns (Δ = -0,356 ns)</td><td align="right" bgcolor="#FFFFFF">15,757 ns (Δ = +0,306 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#A8D08D">0,016 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsArrayEx"></a>IsArrayEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2,210 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#FFFFFF">+2,6 %</td><td align="right" bgcolor="#FF4949">+6,0 %</td><td align="right" bgcolor="#A8D08D">-9,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,637 ns</td><td align="right" bgcolor="#FFFFFF">22,049 ns (Δ = +0,412 ns)</td><td align="right" bgcolor="#A8D08D">21,383 ns (Δ = -0,667 ns)</td><td align="right" bgcolor="#FFFFFF">21,949 ns (Δ = +0,566 ns)</td><td align="right" bgcolor="#FF4949">23,263 ns (Δ = +1,314 ns)</td><td align="right" bgcolor="#A8D08D">21,054 ns (Δ = -2,210 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,021 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,023 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,021 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsAssignableFromEx"></a>IsAssignableFromEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 1,446 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,6 %</td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#FFFFFF">-1,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,503 ns</td><td align="right" bgcolor="#A8D08D">25,562 ns (Δ = -0,941 ns)</td><td align="right" bgcolor="#FF4949">26,496 ns (Δ = +0,933 ns)</td><td align="right" bgcolor="#A8D08D">25,687 ns (Δ = -0,809 ns)</td><td align="right" bgcolor="#FFFFFF">25,407 ns (Δ = -0,280 ns)</td><td align="right" bgcolor="#FFFFFF">25,058 ns (Δ = -0,349 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#A8D08D">0,026 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,026 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,026 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,025 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,025 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 15,072 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FFFFFF">+1,6 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FFFFFF">-2,3 %</td><td align="right" bgcolor="#FFFFFF">+2,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">476,720 ns</td><td align="right" bgcolor="#FFFFFF">473,433 ns (Δ = -3,287 ns)</td><td align="right" bgcolor="#FFFFFF">481,047 ns (Δ = +7,613 ns)</td><td align="right" bgcolor="#FFFFFF">488,020 ns (Δ = +6,973 ns)</td><td align="right" bgcolor="#FFFFFF">477,023 ns (Δ = -10,997 ns)</td><td align="right" bgcolor="#FFFFFF">488,506 ns (Δ = +11,482 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,477 μs</td><td align="right" bgcolor="#FFFFFF">0,473 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,481 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,488 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,477 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#FFFFFF">0,489 μs (Δ = +0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsClassEx"></a>IsClassEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 41,922 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,2 %</td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#FF4949">+28,2 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">165,627 ns</td><td align="right" bgcolor="#A8D08D">150,380 ns (Δ = -15,247 ns)</td><td align="right" bgcolor="#FFFFFF">149,567 ns (Δ = -0,813 ns)</td><td align="right" bgcolor="#FF4949">155,009 ns (Δ = +5,442 ns)</td><td align="right" bgcolor="#A8D08D">148,756 ns (Δ = -6,253 ns)</td><td align="right" bgcolor="#FF4949">190,678 ns (Δ = +41,922 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#A8D08D">0,150 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FFFFFF">0,150 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,155 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,149 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,191 μs (Δ = +0,042 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsCOMObjectEx"></a>IsCOMObjectEx

#### Performance

Fastest: **4.2.0**

Slowest: 4.4.0

Δ: 4,411 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,1 %</td><td align="right" bgcolor="#FF4949">+9,4 %</td><td align="right" bgcolor="#A8D08D">-9,3 %</td><td align="right" bgcolor="#FFFFFF">+1,4 %</td><td align="right" bgcolor="#FFFFFF">-2,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,238 ns</td><td align="right" bgcolor="#FF4949">26,193 ns (Δ = +1,955 ns)</td><td align="right" bgcolor="#FF4949">28,649 ns (Δ = +2,456 ns)</td><td align="right" bgcolor="#A8D08D">25,987 ns (Δ = -2,662 ns)</td><td align="right" bgcolor="#FFFFFF">26,342 ns (Δ = +0,356 ns)</td><td align="right" bgcolor="#FFFFFF">25,617 ns (Δ = -0,726 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FF4949">0,026 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,029 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,026 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,026 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,026 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsEnumEx"></a>IsEnumEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 3,449 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,2 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#A8D08D">-9,6 %</td><td align="right" bgcolor="#FFFFFF">-0,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">33,652 ns</td><td align="right" bgcolor="#FFFFFF">34,058 ns (Δ = +0,406 ns)</td><td align="right" bgcolor="#FF4949">35,284 ns (Δ = +1,227 ns)</td><td align="right" bgcolor="#FFFFFF">35,516 ns (Δ = +0,231 ns)</td><td align="right" bgcolor="#A8D08D">32,107 ns (Δ = -3,409 ns)</td><td align="right" bgcolor="#FFFFFF">32,067 ns (Δ = -0,040 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,035 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,036 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,032 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,032 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 4,658 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+56,6 %</td><td align="right" bgcolor="#A8D08D">-26,2 %</td><td align="right" bgcolor="#A8D08D">-8,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,224 ns</td><td align="right" bgcolor="#FF4949">12,883 ns (Δ = +4,658 ns)</td><td align="right" bgcolor="#A8D08D">9,504 ns (Δ = -3,378 ns)</td><td align="right" bgcolor="#A8D08D">8,663 ns (Δ = -0,841 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FF4949">0,013 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,010 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,009 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeEx"></a>IsGenericTypeEx

#### Performance

Fastest: **4.5.0**

Slowest: 4.2.0

Δ: 2,027 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#FFFFFF">+0,6 %</td><td align="right" bgcolor="#A8D08D">-17,2 %</td><td align="right" bgcolor="#FF4949">+21,9 %</td><td align="right" bgcolor="#A8D08D">-9,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,467 ns</td><td align="right" bgcolor="#A8D08D">10,137 ns (Δ = -0,330 ns)</td><td align="right" bgcolor="#FFFFFF">10,193 ns (Δ = +0,057 ns)</td><td align="right" bgcolor="#A8D08D">8,440 ns (Δ = -1,753 ns)</td><td align="right" bgcolor="#FF4949">10,287 ns (Δ = +1,847 ns)</td><td align="right" bgcolor="#A8D08D">9,335 ns (Δ = -0,952 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#A8D08D">0,010 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,010 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,008 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,010 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,009 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx"></a>IsInstanceOfTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 16709,709 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">0,0 %</td><td align="right" bgcolor="#FF4949">+4,5 %</td><td align="right" bgcolor="#FFFFFF">-2,9 %</td><td align="right" bgcolor="#FFFFFF">-1,1 %</td><td align="right" bgcolor="#A8D08D">-49,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31381,887 ns</td><td align="right" bgcolor="#FFFFFF">31368,248 ns (Δ = -13,639 ns)</td><td align="right" bgcolor="#FF4949">32795,360 ns (Δ = +1427,113 ns)</td><td align="right" bgcolor="#FFFFFF">31860,396 ns (Δ = -934,964 ns)</td><td align="right" bgcolor="#FFFFFF">31524,687 ns (Δ = -335,709 ns)</td><td align="right" bgcolor="#A8D08D">16085,651 ns (Δ = -15439,036 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">31,382 μs</td><td align="right" bgcolor="#FFFFFF">31,368 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FF4949">32,795 μs (Δ = +1,427 μs)</td><td align="right" bgcolor="#FFFFFF">31,860 μs (Δ = -0,935 μs)</td><td align="right" bgcolor="#FFFFFF">31,525 μs (Δ = -0,336 μs)</td><td align="right" bgcolor="#A8D08D">16,086 μs (Δ = -15,439 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,031 ms</td><td align="right" bgcolor="#FFFFFF">0,031 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,033 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,032 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,032 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,016 ms (Δ = -0,015 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">5.0.0</td>
<td align="right">4.3.0</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.3.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">2</td><td align="right">2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">7870</td><td align="right">7966</td><td align="right">7965</td><td align="right">7861</td><td align="right">7853</td><td align="right">6021</td><tr>
<td>Allocated Kilobytes</td><td align="right">7,686</td><td align="right">7,779</td><td align="right">7,778</td><td align="right">7,677</td><td align="right">7,669</td><td align="right">5,880</td><tr>
<td>Allocated Megabytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,006</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 2,841 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#FFFFFF">-2,4 %</td><td align="right" bgcolor="#FFFFFF">-1,2 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#A8D08D">-18,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,658 ns</td><td align="right" bgcolor="#FF4949">12,120 ns (Δ = +0,462 ns)</td><td align="right" bgcolor="#FFFFFF">11,827 ns (Δ = -0,293 ns)</td><td align="right" bgcolor="#FFFFFF">11,684 ns (Δ = -0,142 ns)</td><td align="right" bgcolor="#FFFFFF">11,373 ns (Δ = -0,311 ns)</td><td align="right" bgcolor="#A8D08D">9,279 ns (Δ = -2,094 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FF4949">0,012 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,012 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,012 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,011 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,009 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsNestedPublicEx"></a>IsNestedPublicEx

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 0,882 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,6 %</td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#FFFFFF">+1,8 %</td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FF4949">+3,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,657 ns</td><td align="right" bgcolor="#FFFFFF">15,903 ns (Δ = +0,246 ns)</td><td align="right" bgcolor="#A8D08D">15,227 ns (Δ = -0,676 ns)</td><td align="right" bgcolor="#FFFFFF">15,500 ns (Δ = +0,273 ns)</td><td align="right" bgcolor="#FFFFFF">15,520 ns (Δ = +0,020 ns)</td><td align="right" bgcolor="#FF4949">16,108 ns (Δ = +0,588 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,016 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsPrimitiveEx"></a>IsPrimitiveEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 1,910 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,9 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#A8D08D">-10,5 %</td><td align="right" bgcolor="#FFFFFF">+0,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,783 ns</td><td align="right" bgcolor="#A8D08D">14,380 ns (Δ = -1,403 ns)</td><td align="right" bgcolor="#FF4949">14,900 ns (Δ = +0,520 ns)</td><td align="right" bgcolor="#FF4949">15,493 ns (Δ = +0,593 ns)</td><td align="right" bgcolor="#A8D08D">13,873 ns (Δ = -1,619 ns)</td><td align="right" bgcolor="#FFFFFF">13,949 ns (Δ = +0,076 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#A8D08D">0,014 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,015 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,015 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,014 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,014 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsPublicEx"></a>IsPublicEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 1,838 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#A8D08D">-8,2 %</td><td align="right" bgcolor="#FF4949">+9,0 %</td><td align="right" bgcolor="#A8D08D">-11,6 %</td><td align="right" bgcolor="#FF4949">+11,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,556 ns</td><td align="right" bgcolor="#FFFFFF">15,883 ns (Δ = +0,327 ns)</td><td align="right" bgcolor="#A8D08D">14,580 ns (Δ = -1,303 ns)</td><td align="right" bgcolor="#FF4949">15,887 ns (Δ = +1,307 ns)</td><td align="right" bgcolor="#A8D08D">14,049 ns (Δ = -1,838 ns)</td><td align="right" bgcolor="#FF4949">15,607 ns (Δ = +1,558 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,016 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,014 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,016 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsSerializableEx"></a>IsSerializableEx

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 1,056 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+1,9 %</td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#FFFFFF">+1,7 %</td><td align="right" bgcolor="#FFFFFF">-0,8 %</td><td align="right" bgcolor="#FF4949">+5,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,893 ns</td><td align="right" bgcolor="#FFFFFF">17,213 ns (Δ = +0,320 ns)</td><td align="right" bgcolor="#A8D08D">16,638 ns (Δ = -0,576 ns)</td><td align="right" bgcolor="#FFFFFF">16,923 ns (Δ = +0,286 ns)</td><td align="right" bgcolor="#FFFFFF">16,784 ns (Δ = -0,139 ns)</td><td align="right" bgcolor="#FF4949">17,693 ns (Δ = +0,909 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,017 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,017 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,017 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,018 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsValueTypeEx"></a>IsValueTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 2,852 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,2 %</td><td align="right" bgcolor="#FFFFFF">-0,4 %</td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#FF4949">+3,1 %</td><td align="right" bgcolor="#A8D08D">-5,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">42,721 ns</td><td align="right" bgcolor="#FFFFFF">42,219 ns (Δ = -0,502 ns)</td><td align="right" bgcolor="#FFFFFF">42,056 ns (Δ = -0,164 ns)</td><td align="right" bgcolor="#A8D08D">40,713 ns (Δ = -1,343 ns)</td><td align="right" bgcolor="#FF4949">41,977 ns (Δ = +1,264 ns)</td><td align="right" bgcolor="#A8D08D">39,869 ns (Δ = -2,108 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,042 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,041 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,042 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,040 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="TypeExtensions_Benchmark"></a>TypeExtensions_Benchmark

### <a name="TypeExtensions_Benchmark_GetCollectionElementType"></a>GetCollectionElementType

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 52,824 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#A8D08D">-5,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">983,153 ns</td><td align="right" bgcolor="#FFFFFF">968,477 ns (Δ = -14,677 ns)</td><td align="right" bgcolor="#FF4949">1005,151 ns (Δ = +36,674 ns)</td><td align="right" bgcolor="#A8D08D">952,327 ns (Δ = -52,824 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,983 μs</td><td align="right" bgcolor="#FFFFFF">0,968 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FF4949">1,005 μs (Δ = +0,037 μs)</td><td align="right" bgcolor="#A8D08D">0,952 μs (Δ = -0,053 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.4.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">180</td><td align="right">180</td><td align="right">180</td><td align="right">180</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,176</td><td align="right">0,176</td><td align="right">0,176</td><td align="right">0,176</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsBasicType"></a>IsBasicType

#### Performance

Fastest: **4.4.0**

Slowest: 4.2.0

Δ: 4,667 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,7 %</td><td align="right" bgcolor="#A8D08D">-7,5 %</td><td align="right" bgcolor="#FF4949">+13,0 %</td><td align="right" bgcolor="#FFFFFF">-2,1 %</td><td align="right" bgcolor="#FFFFFF">-2,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,170 ns</td><td align="right" bgcolor="#A8D08D">17,839 ns (Δ = -3,331 ns)</td><td align="right" bgcolor="#A8D08D">16,503 ns (Δ = -1,336 ns)</td><td align="right" bgcolor="#FF4949">18,657 ns (Δ = +2,153 ns)</td><td align="right" bgcolor="#FFFFFF">18,273 ns (Δ = -0,383 ns)</td><td align="right" bgcolor="#FFFFFF">17,860 ns (Δ = -0,413 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#A8D08D">0,018 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,017 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,019 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsClassType"></a>IsClassType

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 16,519 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#A8D08D">-6,2 %</td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#FFFFFF">-2,9 %</td><td align="right" bgcolor="#FFFFFF">-0,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">259,177 ns</td><td align="right" bgcolor="#FFFFFF">264,503 ns (Δ = +5,327 ns)</td><td align="right" bgcolor="#A8D08D">247,984 ns (Δ = -16,519 ns)</td><td align="right" bgcolor="#FF4949">262,503 ns (Δ = +14,519 ns)</td><td align="right" bgcolor="#FFFFFF">255,017 ns (Δ = -7,487 ns)</td><td align="right" bgcolor="#FFFFFF">254,310 ns (Δ = -0,707 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,259 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,248 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#FF4949">0,263 μs (Δ = +0,015 μs)</td><td align="right" bgcolor="#FFFFFF">0,255 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,254 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsCollection"></a>IsCollection

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 5,701 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#FF4949">+6,6 %</td><td align="right" bgcolor="#A8D08D">-4,9 %</td><td align="right" bgcolor="#A8D08D">-5,8 %</td><td align="right" bgcolor="#A8D08D">-3,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">39,780 ns</td><td align="right" bgcolor="#A8D08D">38,563 ns (Δ = -1,217 ns)</td><td align="right" bgcolor="#FF4949">41,117 ns (Δ = +2,554 ns)</td><td align="right" bgcolor="#A8D08D">39,093 ns (Δ = -2,024 ns)</td><td align="right" bgcolor="#A8D08D">36,830 ns (Δ = -2,263 ns)</td><td align="right" bgcolor="#A8D08D">35,416 ns (Δ = -1,414 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#A8D08D">0,039 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,041 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,039 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,037 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,035 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsDictionary"></a>IsDictionary

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 13,290 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,7 %</td><td align="right" bgcolor="#FF4949">+8,5 %</td><td align="right" bgcolor="#A8D08D">-5,5 %</td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#FFFFFF">-1,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">124,807 ns</td><td align="right" bgcolor="#FFFFFF">123,882 ns (Δ = -0,925 ns)</td><td align="right" bgcolor="#FF4949">134,397 ns (Δ = +10,515 ns)</td><td align="right" bgcolor="#A8D08D">127,027 ns (Δ = -7,370 ns)</td><td align="right" bgcolor="#A8D08D">123,042 ns (Δ = -3,985 ns)</td><td align="right" bgcolor="#FFFFFF">121,107 ns (Δ = -1,935 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,134 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,127 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,123 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,121 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsModelBase"></a>IsModelBase

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 1,486 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">-0,5 %</td><td align="right" bgcolor="#FFFFFF">-2,5 %</td><td align="right" bgcolor="#FFFFFF">-1,8 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31,535 ns</td><td align="right" bgcolor="#FFFFFF">31,377 ns (Δ = -0,158 ns)</td><td align="right" bgcolor="#FFFFFF">30,607 ns (Δ = -0,770 ns)</td><td align="right" bgcolor="#FFFFFF">30,049 ns (Δ = -0,558 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,031 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,030 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="TypeExtensions_Benchmark_IsNullableType"></a>IsNullableType

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 57,004 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+2,0 %</td><td align="right" bgcolor="#FFFFFF">+0,1 %</td><td align="right" bgcolor="#FF4949">+10,1 %</td><td align="right" bgcolor="#A8D08D">-11,2 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">371,993 ns</td><td align="right" bgcolor="#FFFFFF">379,573 ns (Δ = +7,580 ns)</td><td align="right" bgcolor="#FFFFFF">379,933 ns (Δ = +0,359 ns)</td><td align="right" bgcolor="#FF4949">418,157 ns (Δ = +38,224 ns)</td><td align="right" bgcolor="#A8D08D">371,320 ns (Δ = -46,837 ns)</td><td align="right" bgcolor="#FFFFFF">361,153 ns (Δ = -10,167 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,372 μs</td><td align="right" bgcolor="#FFFFFF">0,380 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,380 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,418 μs (Δ = +0,038 μs)</td><td align="right" bgcolor="#A8D08D">0,371 μs (Δ = -0,047 μs)</td><td align="right" bgcolor="#FFFFFF">0,361 μs (Δ = -0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="TypeFactory_Benchmark"></a>TypeFactory_Benchmark

### <a name="TypeFactory_Benchmark_CreateInstance"></a>CreateInstance

#### Performance

Fastest: **4.5.0**

Slowest: 4.2.0

Δ: 1100,457 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,2 %</td><td align="right" bgcolor="#A8D08D">-8,5 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#FF4949">+6,0 %</td><td align="right" bgcolor="#FF4949">+11,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3794,877 ns</td><td align="right" bgcolor="#A8D08D">2989,590 ns (Δ = -805,287 ns)</td><td align="right" bgcolor="#A8D08D">2735,820 ns (Δ = -253,770 ns)</td><td align="right" bgcolor="#FFFFFF">2694,420 ns (Δ = -41,400 ns)</td><td align="right" bgcolor="#FF4949">2855,304 ns (Δ = +160,884 ns)</td><td align="right" bgcolor="#FF4949">3185,597 ns (Δ = +330,292 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,795 μs</td><td align="right" bgcolor="#A8D08D">2,990 μs (Δ = -0,805 μs)</td><td align="right" bgcolor="#A8D08D">2,736 μs (Δ = -0,254 μs)</td><td align="right" bgcolor="#FFFFFF">2,694 μs (Δ = -0,041 μs)</td><td align="right" bgcolor="#FF4949">2,855 μs (Δ = +0,161 μs)</td><td align="right" bgcolor="#FF4949">3,186 μs (Δ = +0,330 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">661</td><td align="right">637</td><td align="right">637</td><td align="right">907</td><td align="right">907</td><td align="right">1055</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,646</td><td align="right">0,622</td><td align="right">0,622</td><td align="right">0,886</td><td align="right">0,886</td><td align="right">1,030</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 1814,303 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,8 %</td><td align="right" bgcolor="#FFFFFF">+2,2 %</td><td align="right" bgcolor="#FF4949">+19,9 %</td><td align="right" bgcolor="#FF4949">+30,7 %</td><td align="right" bgcolor="#FF4949">+7,4 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2761,590 ns</td><td align="right" bgcolor="#A8D08D">2519,247 ns (Δ = -242,344 ns)</td><td align="right" bgcolor="#FFFFFF">2574,772 ns (Δ = +55,525 ns)</td><td align="right" bgcolor="#FF4949">3086,678 ns (Δ = +511,906 ns)</td><td align="right" bgcolor="#FF4949">4035,597 ns (Δ = +948,919 ns)</td><td align="right" bgcolor="#FF4949">4333,550 ns (Δ = +297,953 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,762 μs</td><td align="right" bgcolor="#A8D08D">2,519 μs (Δ = -0,242 μs)</td><td align="right" bgcolor="#FFFFFF">2,575 μs (Δ = +0,056 μs)</td><td align="right" bgcolor="#FF4949">3,087 μs (Δ = +0,512 μs)</td><td align="right" bgcolor="#FF4949">4,036 μs (Δ = +0,949 μs)</td><td align="right" bgcolor="#FF4949">4,334 μs (Δ = +0,298 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">661</td><td align="right">637</td><td align="right">637</td><td align="right">899</td><td align="right">899</td><td align="right">1047</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,646</td><td align="right">0,622</td><td align="right">0,622</td><td align="right">0,878</td><td align="right">0,878</td><td align="right">1,022</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.4

Δ: 628,823 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,0 %</td><td align="right" bgcolor="#FFFFFF">-2,0 %</td><td align="right" bgcolor="#FF4949">+12,8 %</td><td align="right" bgcolor="#FF4949">+6,8 %</td><td align="right" bgcolor="#A8D08D">-3,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3613,998 ns</td><td align="right" bgcolor="#A8D08D">3144,443 ns (Δ = -469,554 ns)</td><td align="right" bgcolor="#FFFFFF">3082,423 ns (Δ = -62,020 ns)</td><td align="right" bgcolor="#FF4949">3476,397 ns (Δ = +393,973 ns)</td><td align="right" bgcolor="#FF4949">3711,247 ns (Δ = +234,850 ns)</td><td align="right" bgcolor="#A8D08D">3596,440 ns (Δ = -114,807 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,614 μs</td><td align="right" bgcolor="#A8D08D">3,144 μs (Δ = -0,470 μs)</td><td align="right" bgcolor="#FFFFFF">3,082 μs (Δ = -0,062 μs)</td><td align="right" bgcolor="#FF4949">3,476 μs (Δ = +0,394 μs)</td><td align="right" bgcolor="#FF4949">3,711 μs (Δ = +0,235 μs)</td><td align="right" bgcolor="#A8D08D">3,596 μs (Δ = -0,115 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">924</td><td align="right">899</td><td align="right">899</td><td align="right">1317</td><td align="right">1317</td><td align="right">1465</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,902</td><td align="right">0,878</td><td align="right">0,878</td><td align="right">1,286</td><td align="right">1,286</td><td align="right">1,431</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 812,152 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,1 %</td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#FF4949">+22,9 %</td><td align="right" bgcolor="#A8D08D">-13,2 %</td><td align="right" bgcolor="#FF4949">+8,3 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3557,737 ns</td><td align="right" bgcolor="#FF4949">3704,953 ns (Δ = +147,217 ns)</td><td align="right" bgcolor="#A8D08D">3542,663 ns (Δ = -162,290 ns)</td><td align="right" bgcolor="#FF4949">4354,815 ns (Δ = +812,152 ns)</td><td align="right" bgcolor="#A8D08D">3779,707 ns (Δ = -575,108 ns)</td><td align="right" bgcolor="#FF4949">4094,565 ns (Δ = +314,858 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,558 μs</td><td align="right" bgcolor="#FF4949">3,705 μs (Δ = +0,147 μs)</td><td align="right" bgcolor="#A8D08D">3,543 μs (Δ = -0,162 μs)</td><td align="right" bgcolor="#FF4949">4,355 μs (Δ = +0,812 μs)</td><td align="right" bgcolor="#A8D08D">3,780 μs (Δ = -0,575 μs)</td><td align="right" bgcolor="#FF4949">4,095 μs (Δ = +0,315 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">5.0.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1129</td><td align="right">1104</td><td align="right">1104</td><td align="right">1522</td><td align="right">1522</td><td align="right">1678</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,103</td><td align="right">1,078</td><td align="right">1,078</td><td align="right">1,486</td><td align="right">1,486</td><td align="right">1,639</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,002</td></tr>
</table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 10981,198 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF">+0,2 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FFFFFF">+1,0 %</td><td align="right" bgcolor="#FFFFFF">-1,5 %</td><td align="right" bgcolor="#A8D08D">-40,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25895,386 ns</td><td align="right" bgcolor="#FFFFFF">25959,558 ns (Δ = +64,172 ns)</td><td align="right" bgcolor="#FFFFFF">26231,166 ns (Δ = +271,608 ns)</td><td align="right" bgcolor="#FFFFFF">26505,456 ns (Δ = +274,290 ns)</td><td align="right" bgcolor="#FFFFFF">26118,273 ns (Δ = -387,182 ns)</td><td align="right" bgcolor="#A8D08D">15524,258 ns (Δ = -10594,016 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">25,895 μs</td><td align="right" bgcolor="#FFFFFF">25,960 μs (Δ = +0,064 μs)</td><td align="right" bgcolor="#FFFFFF">26,231 μs (Δ = +0,272 μs)</td><td align="right" bgcolor="#FFFFFF">26,505 μs (Δ = +0,274 μs)</td><td align="right" bgcolor="#FFFFFF">26,118 μs (Δ = -0,387 μs)</td><td align="right" bgcolor="#A8D08D">15,524 μs (Δ = -10,594 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,026 ms</td><td align="right" bgcolor="#FFFFFF">0,026 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,026 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,027 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,026 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,016 ms (Δ = -0,011 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.3.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">7582</td><td align="right">7677</td><td align="right">7676</td><td align="right">7574</td><td align="right">7565</td><td align="right">5941</td><tr>
<td>Allocated Kilobytes</td><td align="right">7,404</td><td align="right">7,497</td><td align="right">7,496</td><td align="right">7,396</td><td align="right">7,388</td><td align="right">5,802</td><tr>
<td>Allocated Megabytes</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,006</td></tr>
</table>


## <a name="WeakEventListener_Benchmark"></a>WeakEventListener_Benchmark

### <a name="WeakEventListener_Benchmark_CollectionChanged_Notification"></a>CollectionChanged_Notification

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 32,395 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,7 %</td><td align="right" bgcolor="#FF4949">+22,9 %</td><td align="right" bgcolor="#A8D08D">-17,2 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#A8D08D">-5,7 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">163,205 ns</td><td align="right" bgcolor="#A8D08D">130,982 ns (Δ = -32,223 ns)</td><td align="right" bgcolor="#FF4949">160,977 ns (Δ = +29,994 ns)</td><td align="right" bgcolor="#A8D08D">133,350 ns (Δ = -27,627 ns)</td><td align="right" bgcolor="#FF4949">138,667 ns (Δ = +5,317 ns)</td><td align="right" bgcolor="#A8D08D">130,810 ns (Δ = -7,857 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#A8D08D">0,131 μs (Δ = -0,032 μs)</td><td align="right" bgcolor="#FF4949">0,161 μs (Δ = +0,030 μs)</td><td align="right" bgcolor="#A8D08D">0,133 μs (Δ = -0,028 μs)</td><td align="right" bgcolor="#FF4949">0,139 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,131 μs (Δ = -0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">5.0.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">176</td><td align="right">175</td><td align="right">175</td><td align="right">175</td><td align="right">175</td><td align="right">175</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,172</td><td align="right">0,171</td><td align="right">0,171</td><td align="right">0,171</td><td align="right">0,171</td><td align="right">0,171</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="WeakEventListener_Benchmark_GenericEvent_Notification"></a>GenericEvent_Notification

#### Performance

Fastest: **4.5.0**

Slowest: 4.3.0

Δ: 5,952 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,9 %</td><td align="right" bgcolor="#A8D08D">-16,5 %</td><td align="right" bgcolor="#FFFFFF">-1,6 %</td><td align="right" bgcolor="#FFFFFF">+2,1 %</td><td align="right" bgcolor="#FFFFFF">-0,6 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31,783 ns</td><td align="right" bgcolor="#FF4949">33,337 ns (Δ = +1,554 ns)</td><td align="right" bgcolor="#A8D08D">27,841 ns (Δ = -5,496 ns)</td><td align="right" bgcolor="#FFFFFF">27,385 ns (Δ = -0,456 ns)</td><td align="right" bgcolor="#FFFFFF">27,962 ns (Δ = +0,577 ns)</td><td align="right" bgcolor="#FFFFFF">27,788 ns (Δ = -0,174 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FF4949">0,033 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,028 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,027 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,028 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,028 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="WeakEventListener_Benchmark_PropertyChanged_Notification"></a>PropertyChanged_Notification

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 0,823 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,2 %</td><td align="right" bgcolor="#FF4949">+9,3 %</td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FF4949">+14,0 %</td><td align="right" bgcolor="#A8D08D">-5,0 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,202 ns</td><td align="right" bgcolor="#A8D08D">4,568 ns (Δ = -0,633 ns)</td><td align="right" bgcolor="#FF4949">4,993 ns (Δ = +0,425 ns)</td><td align="right" bgcolor="#A8D08D">4,729 ns (Δ = -0,264 ns)</td><td align="right" bgcolor="#FF4949">5,391 ns (Δ = +0,662 ns)</td><td align="right" bgcolor="#A8D08D">5,120 ns (Δ = -0,271 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#A8D08D">0,005 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,005 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,005 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,005 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,005 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="WeakEventListener_Benchmark_SubscribeToWeakGenericEvent"></a>SubscribeToWeakGenericEvent

#### Performance

Fastest: **4.5.0**

Slowest: 4.2.0

Δ: 3874,471 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,3 %</td><td align="right" bgcolor="#FFFFFF">-2,7 %</td><td align="right" bgcolor="#FFFFFF">-2,5 %</td><td align="right" bgcolor="#FF4949">+4,8 %</td><td align="right" bgcolor="#FFFFFF">-2,5 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21917,667 ns</td><td align="right" bgcolor="#A8D08D">19010,477 ns (Δ = -2907,191 ns)</td><td align="right" bgcolor="#FFFFFF">18504,076 ns (Δ = -506,401 ns)</td><td align="right" bgcolor="#FFFFFF">18043,197 ns (Δ = -460,879 ns)</td><td align="right" bgcolor="#FF4949">18904,747 ns (Δ = +861,550 ns)</td><td align="right" bgcolor="#FFFFFF">18424,913 ns (Δ = -479,833 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">21,918 μs</td><td align="right" bgcolor="#A8D08D">19,010 μs (Δ = -2,907 μs)</td><td align="right" bgcolor="#FFFFFF">18,504 μs (Δ = -0,506 μs)</td><td align="right" bgcolor="#FFFFFF">18,043 μs (Δ = -0,461 μs)</td><td align="right" bgcolor="#FF4949">18,905 μs (Δ = +0,862 μs)</td><td align="right" bgcolor="#FFFFFF">18,425 μs (Δ = -0,480 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,022 ms</td><td align="right" bgcolor="#A8D08D">0,019 ms (Δ = -0,003 ms)</td><td align="right" bgcolor="#FFFFFF">0,019 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,018 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,019 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,018 ms (Δ = 0,000 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1225</td><td align="right">1224</td><td align="right">1224</td><td align="right">1225</td><td align="right">1225</td><td align="right">1225</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,196</td><td align="right">1,195</td><td align="right">1,195</td><td align="right">1,196</td><td align="right">1,196</td><td align="right">1,196</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="WeakEventListener_Benchmark_SubscribeToWeakPropertyChangedEvent"></a>SubscribeToWeakPropertyChangedEvent

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 9664,720 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average % / operation</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,8 %</td><td align="right" bgcolor="#FFFFFF">+0,7 %</td><td align="right" bgcolor="#FF4949">+10,3 %</td><td align="right" bgcolor="#A8D08D">-9,5 %</td><td align="right" bgcolor="#A8D08D">-3,1 %</td></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">28775,407 ns</td><td align="right" bgcolor="#A8D08D">19612,447 ns (Δ = -9162,960 ns)</td><td align="right" bgcolor="#FFFFFF">19753,782 ns (Δ = +141,335 ns)</td><td align="right" bgcolor="#FF4949">21794,943 ns (Δ = +2041,162 ns)</td><td align="right" bgcolor="#A8D08D">19729,237 ns (Δ = -2065,707 ns)</td><td align="right" bgcolor="#A8D08D">19110,687 ns (Δ = -618,550 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">28,775 μs</td><td align="right" bgcolor="#A8D08D">19,612 μs (Δ = -9,163 μs)</td><td align="right" bgcolor="#FFFFFF">19,754 μs (Δ = +0,141 μs)</td><td align="right" bgcolor="#FF4949">21,795 μs (Δ = +2,041 μs)</td><td align="right" bgcolor="#A8D08D">19,729 μs (Δ = -2,066 μs)</td><td align="right" bgcolor="#A8D08D">19,111 μs (Δ = -0,619 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,029 ms</td><td align="right" bgcolor="#A8D08D">0,020 ms (Δ = -0,009 ms)</td><td align="right" bgcolor="#FFFFFF">0,020 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,022 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,020 ms (Δ = -0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,019 ms (Δ = -0,001 ms)</td></tr>
</table>

#### Memory (per 1k operations)

<table>
<tr>
<th>Name</th>
<th>Least</th>
<th>Most</th>
</tr>
<tr>
<td>Gen 0</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 1</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Gen 2</td>
<td align="right">-</td>
<td align="right">-</td>
</tr>
<tr>
<td>Allocated Bytes</td>
<td align="right">4.4.0</td>
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1226</td><td align="right">1224</td><td align="right">1224</td><td align="right">1225</td><td align="right">1225</td><td align="right">1225</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,197</td><td align="right">1,195</td><td align="right">1,195</td><td align="right">1,196</td><td align="right">1,196</td><td align="right">1,196</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


