# Benchmarks

Benchmark report generated on 18-jun-2017 19:44

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

Δ: 43,840 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">161,160 ns</td><td align="right" bgcolor="#FF4949">170,960 ns (Δ = +9,800 ns)</td><td align="right" bgcolor="#A8D08D">132,322 ns (Δ = -38,638 ns)</td><td align="right" bgcolor="#FFFFFF">134,900 ns (Δ = +2,578 ns)</td><td align="right" bgcolor="#FFFFFF">132,433 ns (Δ = -2,467 ns)</td><td align="right" bgcolor="#A8D08D">127,120 ns (Δ = -5,313 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,161 μs</td><td align="right" bgcolor="#FF4949">0,171 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#A8D08D">0,132 μs (Δ = -0,039 μs)</td><td align="right" bgcolor="#FFFFFF">0,135 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,132 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,127 μs (Δ = -0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 29,423 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">150,112 ns</td><td align="right" bgcolor="#A8D08D">139,880 ns (Δ = -10,232 ns)</td><td align="right" bgcolor="#FFFFFF">137,493 ns (Δ = -2,387 ns)</td><td align="right" bgcolor="#FF4949">141,828 ns (Δ = +4,334 ns)</td><td align="right" bgcolor="#FF4949">165,019 ns (Δ = +23,191 ns)</td><td align="right" bgcolor="#A8D08D">135,596 ns (Δ = -29,423 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,150 μs</td><td align="right" bgcolor="#A8D08D">0,140 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,137 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,142 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FF4949">0,165 μs (Δ = +0,023 μs)</td><td align="right" bgcolor="#A8D08D">0,136 μs (Δ = -0,029 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 18,582 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">144,675 ns</td><td align="right" bgcolor="#A8D08D">134,298 ns (Δ = -10,377 ns)</td><td align="right" bgcolor="#FFFFFF">130,440 ns (Δ = -3,858 ns)</td><td align="right" bgcolor="#FFFFFF">129,498 ns (Δ = -0,942 ns)</td><td align="right" bgcolor="#FFFFFF">126,093 ns (Δ = -3,404 ns)</td><td align="right" bgcolor="#FFFFFF">127,454 ns (Δ = +1,361 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#A8D08D">0,134 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,130 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,129 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,126 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,127 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 23,997 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">142,745 ns</td><td align="right" bgcolor="#A8D08D">138,566 ns (Δ = -4,179 ns)</td><td align="right" bgcolor="#FF4949">146,373 ns (Δ = +7,808 ns)</td><td align="right" bgcolor="#A8D08D">139,297 ns (Δ = -7,077 ns)</td><td align="right" bgcolor="#A8D08D">122,376 ns (Δ = -16,920 ns)</td><td align="right" bgcolor="#FFFFFF">122,490 ns (Δ = +0,114 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#A8D08D">0,139 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,146 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#A8D08D">0,139 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,122 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#FFFFFF">0,122 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 8,127 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">48,547 ns</td><td align="right" bgcolor="#A8D08D">42,587 ns (Δ = -5,960 ns)</td><td align="right" bgcolor="#FFFFFF">43,838 ns (Δ = +1,251 ns)</td><td align="right" bgcolor="#FFFFFF">43,424 ns (Δ = -0,414 ns)</td><td align="right" bgcolor="#A8D08D">40,420 ns (Δ = -3,004 ns)</td><td align="right" bgcolor="#FFFFFF">40,540 ns (Δ = +0,120 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#A8D08D">0,043 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,044 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,043 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,040 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,041 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 4.2.0

Δ: 13,447 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">60,554 ns</td><td align="right" bgcolor="#A8D08D">50,169 ns (Δ = -10,385 ns)</td><td align="right" bgcolor="#FFFFFF">49,200 ns (Δ = -0,969 ns)</td><td align="right" bgcolor="#FFFFFF">50,320 ns (Δ = +1,120 ns)</td><td align="right" bgcolor="#A8D08D">47,107 ns (Δ = -3,213 ns)</td><td align="right" bgcolor="#FFFFFF">48,260 ns (Δ = +1,153 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#A8D08D">0,050 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,049 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,050 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,047 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,048 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 3,188 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">48,676 ns</td><td align="right" bgcolor="#FF4949">50,780 ns (Δ = +2,104 ns)</td><td align="right" bgcolor="#A8D08D">48,647 ns (Δ = -2,133 ns)</td><td align="right" bgcolor="#FFFFFF">49,840 ns (Δ = +1,193 ns)</td><td align="right" bgcolor="#A8D08D">47,633 ns (Δ = -2,207 ns)</td><td align="right" bgcolor="#FFFFFF">47,592 ns (Δ = -0,042 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FF4949">0,051 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,049 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,050 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,048 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,048 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Slowest: 4.3.0

Δ: 53,036 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">713,540 ns</td><td align="right" bgcolor="#FF4949">753,116 ns (Δ = +39,576 ns)</td><td align="right" bgcolor="#A8D08D">700,080 ns (Δ = -53,036 ns)</td><td align="right" bgcolor="#FFFFFF">708,280 ns (Δ = +8,200 ns)</td><td align="right" bgcolor="#FFFFFF">718,011 ns (Δ = +9,731 ns)</td><td align="right" bgcolor="#FFFFFF">705,509 ns (Δ = -12,502 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,714 μs</td><td align="right" bgcolor="#FF4949">0,753 μs (Δ = +0,040 μs)</td><td align="right" bgcolor="#A8D08D">0,700 μs (Δ = -0,053 μs)</td><td align="right" bgcolor="#FFFFFF">0,708 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,718 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,706 μs (Δ = -0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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

Slowest: 4.3.0

Δ: 3,383 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,703 ns</td><td align="right" bgcolor="#FFFFFF">22,833 ns (Δ = +0,131 ns)</td><td align="right" bgcolor="#A8D08D">21,671 ns (Δ = -1,162 ns)</td><td align="right" bgcolor="#FFFFFF">21,773 ns (Δ = +0,102 ns)</td><td align="right" bgcolor="#A8D08D">20,778 ns (Δ = -0,996 ns)</td><td align="right" bgcolor="#A8D08D">19,450 ns (Δ = -1,328 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,022 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,021 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,019 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **4.4.0**

Slowest: 4.2.0

Δ: 1,009 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">23,609 ns</td><td align="right" bgcolor="#FFFFFF">23,087 ns (Δ = -0,522 ns)</td><td align="right" bgcolor="#FFFFFF">22,600 ns (Δ = -0,487 ns)</td><td align="right" bgcolor="#FFFFFF">22,753 ns (Δ = +0,153 ns)</td><td align="right" bgcolor="#FFFFFF">22,987 ns (Δ = +0,233 ns)</td><td align="right" bgcolor="#FFFFFF">22,605 ns (Δ = -0,382 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,023 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,023 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,023 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,023 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 0,989 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,708 ns</td><td align="right" bgcolor="#FFFFFF">8,793 ns (Δ = +0,085 ns)</td><td align="right" bgcolor="#FFFFFF">8,667 ns (Δ = -0,127 ns)</td><td align="right" bgcolor="#FFFFFF">8,853 ns (Δ = +0,187 ns)</td><td align="right" bgcolor="#A8D08D">8,013 ns (Δ = -0,840 ns)</td><td align="right" bgcolor="#FF4949">9,002 ns (Δ = +0,989 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,009 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,009 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,008 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,009 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 13,807 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">519,335 ns</td><td align="right" bgcolor="#FFFFFF">521,500 ns (Δ = +2,165 ns)</td><td align="right" bgcolor="#FFFFFF">516,813 ns (Δ = -4,687 ns)</td><td align="right" bgcolor="#FFFFFF">530,620 ns (Δ = +13,807 ns)</td><td align="right" bgcolor="#FFFFFF">524,598 ns (Δ = -6,022 ns)</td><td align="right" bgcolor="#FFFFFF">521,928 ns (Δ = -2,670 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td><td align="right" bgcolor="#FFFFFF">0,522 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,517 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,531 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#FFFFFF">0,525 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,522 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.2.0**

Slowest: 4.4.0

Δ: 1,907 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FF4949">1,490 ns (Δ = +1,490 ns)</td><td align="right" bgcolor="#FF4949">1,907 ns (Δ = +0,416 ns)</td><td align="right" bgcolor="#A8D08D">1,575 ns (Δ = -0,332 ns)</td><td align="right" bgcolor="#A8D08D">1,498 ns (Δ = -0,077 ns)</td><td align="right" bgcolor="#FF4949">1,720 ns (Δ = +0,222 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FF4949">0,001 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,002 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,002 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,001 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,002 μs (Δ = +0,000 μs)</td></tr>
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


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 0,409 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,148 ns</td><td align="right" bgcolor="#A8D08D">1,827 ns (Δ = -0,321 ns)</td><td align="right" bgcolor="#FF4949">1,950 ns (Δ = +0,123 ns)</td><td align="right" bgcolor="#FF4949">2,236 ns (Δ = +0,286 ns)</td><td align="right" bgcolor="#FFFFFF">2,187 ns (Δ = -0,049 ns)</td><td align="right" bgcolor="#A8D08D">2,100 ns (Δ = -0,087 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#A8D08D">0,002 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,002 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,002 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,002 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,002 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.3.0**

Slowest: 4.2.0

Δ: 3,848 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,600 ns</td><td align="right" bgcolor="#A8D08D">10,752 ns (Δ = -3,848 ns)</td><td align="right" bgcolor="#FF4949">11,276 ns (Δ = +0,524 ns)</td><td align="right" bgcolor="#FF4949">13,757 ns (Δ = +2,481 ns)</td><td align="right" bgcolor="#A8D08D">10,770 ns (Δ = -2,987 ns)</td><td align="right" bgcolor="#FF4949">13,151 ns (Δ = +2,381 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#A8D08D">0,011 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,011 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,014 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,011 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,013 μs (Δ = +0,002 μs)</td></tr>
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

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 1,473 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,938 ns</td><td align="right" bgcolor="#FF4949">3,702 ns (Δ = +0,764 ns)</td><td align="right" bgcolor="#FF4949">4,347 ns (Δ = +0,644 ns)</td><td align="right" bgcolor="#FFFFFF">4,411 ns (Δ = +0,064 ns)</td><td align="right" bgcolor="#A8D08D">3,271 ns (Δ = -1,140 ns)</td><td align="right" bgcolor="#FF4949">4,071 ns (Δ = +0,800 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FF4949">0,004 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,004 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,004 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,003 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,004 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 8,604 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,053 ns</td><td align="right" bgcolor="#FFFFFF">16,272 ns (Δ = +0,218 ns)</td><td align="right" bgcolor="#FFFFFF">15,817 ns (Δ = -0,455 ns)</td><td align="right" bgcolor="#FF4949">16,487 ns (Δ = +0,670 ns)</td><td align="right" bgcolor="#FF4949">24,093 ns (Δ = +7,607 ns)</td><td align="right" bgcolor="#A8D08D">15,489 ns (Δ = -8,604 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,016 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,024 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,009 μs)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 2,640 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">84,948 ns</td><td align="right" bgcolor="#FFFFFF">85,687 ns (Δ = +0,738 ns)</td><td align="right" bgcolor="#FFFFFF">87,207 ns (Δ = +1,520 ns)</td><td align="right" bgcolor="#FFFFFF">85,871 ns (Δ = -1,336 ns)</td><td align="right" bgcolor="#FFFFFF">84,567 ns (Δ = -1,304 ns)</td><td align="right" bgcolor="#FFFFFF">84,893 ns (Δ = +0,327 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,087 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,086 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,085 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,085 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 5,779 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">93,967 ns</td><td align="right" bgcolor="#FFFFFF">95,609 ns (Δ = +1,642 ns)</td><td align="right" bgcolor="#A8D08D">92,769 ns (Δ = -2,840 ns)</td><td align="right" bgcolor="#FFFFFF">90,553 ns (Δ = -2,216 ns)</td><td align="right" bgcolor="#FFFFFF">89,830 ns (Δ = -0,723 ns)</td><td align="right" bgcolor="#FF4949">93,347 ns (Δ = +3,517 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,093 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,091 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,090 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,093 μs (Δ = +0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.3.0**

Slowest: 4.2.0

Δ: 23,040 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">82,100 ns</td><td align="right" bgcolor="#A8D08D">59,060 ns (Δ = -23,040 ns)</td><td align="right" bgcolor="#FF4949">62,690 ns (Δ = +3,630 ns)</td><td align="right" bgcolor="#FFFFFF">61,133 ns (Δ = -1,556 ns)</td><td align="right" bgcolor="#FFFFFF">60,138 ns (Δ = -0,996 ns)</td><td align="right" bgcolor="#FF4949">62,519 ns (Δ = +2,381 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#A8D08D">0,059 μs (Δ = -0,023 μs)</td><td align="right" bgcolor="#FF4949">0,063 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,061 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,060 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,063 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 3,008 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">68,020 ns</td><td align="right" bgcolor="#FFFFFF">68,178 ns (Δ = +0,158 ns)</td><td align="right" bgcolor="#FFFFFF">67,420 ns (Δ = -0,758 ns)</td><td align="right" bgcolor="#FFFFFF">67,567 ns (Δ = +0,147 ns)</td><td align="right" bgcolor="#FFFFFF">67,267 ns (Δ = -0,300 ns)</td><td align="right" bgcolor="#A8D08D">65,170 ns (Δ = -2,097 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,067 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,068 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,067 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,065 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Slowest: 4.4.0

Δ: 10,810 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30,898 ns</td><td align="right" bgcolor="#A8D08D">29,807 ns (Δ = -1,091 ns)</td><td align="right" bgcolor="#FF4949">38,620 ns (Δ = +8,813 ns)</td><td align="right" bgcolor="#A8D08D">32,056 ns (Δ = -6,564 ns)</td><td align="right" bgcolor="#A8D08D">28,741 ns (Δ = -3,314 ns)</td><td align="right" bgcolor="#A8D08D">27,810 ns (Δ = -0,931 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#A8D08D">0,030 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,039 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,032 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,029 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,028 μs (Δ = -0,001 μs)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 6,591 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">61,993 ns</td><td align="right" bgcolor="#FF4949">66,351 ns (Δ = +4,358 ns)</td><td align="right" bgcolor="#FFFFFF">65,102 ns (Δ = -1,249 ns)</td><td align="right" bgcolor="#FFFFFF">63,454 ns (Δ = -1,648 ns)</td><td align="right" bgcolor="#A8D08D">59,760 ns (Δ = -3,694 ns)</td><td align="right" bgcolor="#FF4949">64,273 ns (Δ = +4,513 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FF4949">0,066 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,065 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,063 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,060 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,064 μs (Δ = +0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 6,778 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">69,830 ns</td><td align="right" bgcolor="#FFFFFF">71,729 ns (Δ = +1,899 ns)</td><td align="right" bgcolor="#FFFFFF">71,992 ns (Δ = +0,263 ns)</td><td align="right" bgcolor="#FFFFFF">70,996 ns (Δ = -0,996 ns)</td><td align="right" bgcolor="#A8D08D">67,805 ns (Δ = -3,190 ns)</td><td align="right" bgcolor="#A8D08D">65,213 ns (Δ = -2,592 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,072 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,071 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,068 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,065 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 12,164 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">43,160 ns</td><td align="right" bgcolor="#A8D08D">41,796 ns (Δ = -1,364 ns)</td><td align="right" bgcolor="#FFFFFF">42,520 ns (Δ = +0,724 ns)</td><td align="right" bgcolor="#A8D08D">41,191 ns (Δ = -1,329 ns)</td><td align="right" bgcolor="#FFFFFF">41,930 ns (Δ = +0,739 ns)</td><td align="right" bgcolor="#FF4949">53,355 ns (Δ = +11,425 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#A8D08D">0,042 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,043 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,041 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,042 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,053 μs (Δ = +0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 2,514 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">50,862 ns</td><td align="right" bgcolor="#FFFFFF">51,145 ns (Δ = +0,283 ns)</td><td align="right" bgcolor="#FFFFFF">49,773 ns (Δ = -1,372 ns)</td><td align="right" bgcolor="#FFFFFF">50,253 ns (Δ = +0,480 ns)</td><td align="right" bgcolor="#FFFFFF">50,381 ns (Δ = +0,128 ns)</td><td align="right" bgcolor="#A8D08D">48,631 ns (Δ = -1,750 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,050 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,050 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,050 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,049 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.3.0**

Slowest: 4.4.0

Δ: 401,860 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7513,589 ns</td><td align="right" bgcolor="#FFFFFF">7440,007 ns (Δ = -73,582 ns)</td><td align="right" bgcolor="#FF4949">7841,867 ns (Δ = +401,860 ns)</td><td align="right" bgcolor="#FFFFFF">7803,240 ns (Δ = -38,627 ns)</td><td align="right" bgcolor="#A8D08D">7569,973 ns (Δ = -233,267 ns)</td><td align="right" bgcolor="#FFFFFF">7686,547 ns (Δ = +116,573 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,514 μs</td><td align="right" bgcolor="#FFFFFF">7,440 μs (Δ = -0,074 μs)</td><td align="right" bgcolor="#FF4949">7,842 μs (Δ = +0,402 μs)</td><td align="right" bgcolor="#FFFFFF">7,803 μs (Δ = -0,039 μs)</td><td align="right" bgcolor="#A8D08D">7,570 μs (Δ = -0,233 μs)</td><td align="right" bgcolor="#FFFFFF">7,687 μs (Δ = +0,117 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">737</td><td align="right">737</td><td align="right">737</td><td align="right">737</td><td align="right">737</td><td align="right">737</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,720</td><td align="right">0,720</td><td align="right">0,720</td><td align="right">0,720</td><td align="right">0,720</td><td align="right">0,720</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 813,580 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7541,231 ns</td><td align="right" bgcolor="#FFFFFF">7672,512 ns (Δ = +131,281 ns)</td><td align="right" bgcolor="#FF4949">8349,480 ns (Δ = +676,968 ns)</td><td align="right" bgcolor="#A8D08D">7650,114 ns (Δ = -699,366 ns)</td><td align="right" bgcolor="#FFFFFF">7603,990 ns (Δ = -46,124 ns)</td><td align="right" bgcolor="#FFFFFF">7535,900 ns (Δ = -68,090 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,541 μs</td><td align="right" bgcolor="#FFFFFF">7,673 μs (Δ = +0,131 μs)</td><td align="right" bgcolor="#FF4949">8,349 μs (Δ = +0,677 μs)</td><td align="right" bgcolor="#A8D08D">7,650 μs (Δ = -0,699 μs)</td><td align="right" bgcolor="#FFFFFF">7,604 μs (Δ = -0,046 μs)</td><td align="right" bgcolor="#FFFFFF">7,536 μs (Δ = -0,068 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,008 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">737</td><td align="right">737</td><td align="right">737</td><td align="right">737</td><td align="right">737</td><td align="right">737</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,720</td><td align="right">0,720</td><td align="right">0,720</td><td align="right">0,720</td><td align="right">0,720</td><td align="right">0,720</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 410,541 ns


<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13087,390 ns</td><td align="right" bgcolor="#FFFFFF">13363,580 ns (Δ = +276,190 ns)</td><td align="right" bgcolor="#FFFFFF">13497,931 ns (Δ = +134,351 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13,087 μs</td><td align="right" bgcolor="#FFFFFF">13,364 μs (Δ = +0,276 μs)</td><td align="right" bgcolor="#FFFFFF">13,498 μs (Δ = +0,134 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,013 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">1196</td><td align="right">1212</td><td align="right">1212</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,168</td><td align="right">1,184</td><td align="right">1,184</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.4

Δ: 2407,447 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5580,120 ns</td><td align="right" bgcolor="#FFFFFF">5689,889 ns (Δ = +109,769 ns)</td><td align="right" bgcolor="#A8D08D">5335,713 ns (Δ = -354,176 ns)</td><td align="right" bgcolor="#FF4949">5853,164 ns (Δ = +517,452 ns)</td><td align="right" bgcolor="#FF4949">7743,160 ns (Δ = +1889,996 ns)</td><td align="right" bgcolor="#A8D08D">5527,293 ns (Δ = -2215,867 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,580 μs</td><td align="right" bgcolor="#FFFFFF">5,690 μs (Δ = +0,110 μs)</td><td align="right" bgcolor="#A8D08D">5,336 μs (Δ = -0,354 μs)</td><td align="right" bgcolor="#FF4949">5,853 μs (Δ = +0,517 μs)</td><td align="right" bgcolor="#FF4949">7,743 μs (Δ = +1,890 μs)</td><td align="right" bgcolor="#A8D08D">5,527 μs (Δ = -2,216 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = -0,002 ms)</td></tr>
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
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">2638</td><td align="right">2638</td><td align="right">2638</td><td align="right">2638</td><td align="right">2671</td><td align="right">2671</td><tr>
<td>Allocated Kilobytes</td><td align="right">2,576</td><td align="right">2,576</td><td align="right">2,576</td><td align="right">2,576</td><td align="right">2,608</td><td align="right">2,608</td><tr>
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

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 440,398 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9657,800 ns</td><td align="right" bgcolor="#FF4949">10018,588 ns (Δ = +360,788 ns)</td><td align="right" bgcolor="#FFFFFF">9977,480 ns (Δ = -41,108 ns)</td><td align="right" bgcolor="#FFFFFF">9708,320 ns (Δ = -269,160 ns)</td><td align="right" bgcolor="#FFFFFF">9648,844 ns (Δ = -59,476 ns)</td><td align="right" bgcolor="#FFFFFF">9578,190 ns (Δ = -70,654 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,658 μs</td><td align="right" bgcolor="#FF4949">10,019 μs (Δ = +0,361 μs)</td><td align="right" bgcolor="#FFFFFF">9,977 μs (Δ = -0,041 μs)</td><td align="right" bgcolor="#FFFFFF">9,708 μs (Δ = -0,269 μs)</td><td align="right" bgcolor="#FFFFFF">9,649 μs (Δ = -0,059 μs)</td><td align="right" bgcolor="#FFFFFF">9,578 μs (Δ = -0,071 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 2718,524 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9809,968 ns</td><td align="right" bgcolor="#FFFFFF">9766,847 ns (Δ = -43,122 ns)</td><td align="right" bgcolor="#FF4949">12345,480 ns (Δ = +2578,633 ns)</td><td align="right" bgcolor="#A8D08D">10865,747 ns (Δ = -1479,733 ns)</td><td align="right" bgcolor="#A8D08D">9915,240 ns (Δ = -950,507 ns)</td><td align="right" bgcolor="#FFFFFF">9626,956 ns (Δ = -288,284 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,810 μs</td><td align="right" bgcolor="#FFFFFF">9,767 μs (Δ = -0,043 μs)</td><td align="right" bgcolor="#FF4949">12,345 μs (Δ = +2,579 μs)</td><td align="right" bgcolor="#A8D08D">10,866 μs (Δ = -1,480 μs)</td><td align="right" bgcolor="#A8D08D">9,915 μs (Δ = -0,951 μs)</td><td align="right" bgcolor="#FFFFFF">9,627 μs (Δ = -0,288 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,012 ms (Δ = +0,003 ms)</td><td align="right" bgcolor="#A8D08D">0,011 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,010 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 472,960 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9627,340 ns</td><td align="right" bgcolor="#FFFFFF">9581,933 ns (Δ = -45,407 ns)</td><td align="right" bgcolor="#FF4949">9894,333 ns (Δ = +312,400 ns)</td><td align="right" bgcolor="#A8D08D">9523,213 ns (Δ = -371,120 ns)</td><td align="right" bgcolor="#FFFFFF">9421,373 ns (Δ = -101,840 ns)</td><td align="right" bgcolor="#FF4949">9767,842 ns (Δ = +346,469 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,627 μs</td><td align="right" bgcolor="#FFFFFF">9,582 μs (Δ = -0,045 μs)</td><td align="right" bgcolor="#FF4949">9,894 μs (Δ = +0,312 μs)</td><td align="right" bgcolor="#A8D08D">9,523 μs (Δ = -0,371 μs)</td><td align="right" bgcolor="#FFFFFF">9,421 μs (Δ = -0,102 μs)</td><td align="right" bgcolor="#FF4949">9,768 μs (Δ = +0,346 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.5.0**

Slowest: 4.2.0

Δ: 397312,532 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">890002,622 ns</td><td align="right" bgcolor="#FFFFFF">885419,031 ns (Δ = -4583,591 ns)</td><td align="right" bgcolor="#FFFFFF">887467,580 ns (Δ = +2048,549 ns)</td><td align="right" bgcolor="#A8D08D">492690,090 ns (Δ = -394777,490 ns)</td><td align="right" bgcolor="#FFFFFF">492748,993 ns (Δ = +58,903 ns)</td><td align="right" bgcolor="#FFFFFF">492920,341 ns (Δ = +171,348 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">890,003 μs</td><td align="right" bgcolor="#FFFFFF">885,419 μs (Δ = -4,584 μs)</td><td align="right" bgcolor="#FFFFFF">887,468 μs (Δ = +2,049 μs)</td><td align="right" bgcolor="#A8D08D">492,690 μs (Δ = -394,777 μs)</td><td align="right" bgcolor="#FFFFFF">492,749 μs (Δ = +0,059 μs)</td><td align="right" bgcolor="#FFFFFF">492,920 μs (Δ = +0,171 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,890 ms</td><td align="right" bgcolor="#FFFFFF">0,885 ms (Δ = -0,005 ms)</td><td align="right" bgcolor="#FFFFFF">0,887 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,493 ms (Δ = -0,395 ms)</td><td align="right" bgcolor="#FFFFFF">0,493 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,493 ms (Δ = +0,000 ms)</td></tr>
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
<td align="right">4.2.0</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">10</td><td align="right">10</td><td align="right">10</td></tr>
<tr>
<td>Gen 1</td><td align="right">10</td><td align="right">10</td><td align="right">10</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">35324</td><td align="right">35324</td><td align="right">35324</td><td align="right">20390</td><td align="right">20390</td><td align="right">20390</td><tr>
<td>Allocated Kilobytes</td><td align="right">34,496</td><td align="right">34,496</td><td align="right">34,496</td><td align="right">19,912</td><td align="right">19,912</td><td align="right">19,912</td><tr>
<td>Allocated Megabytes</td><td align="right">0,034</td><td align="right">0,034</td><td align="right">0,034</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,019</td></tr>
</table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 201,654 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2896,547 ns</td><td align="right" bgcolor="#FFFFFF">2875,218 ns (Δ = -21,329 ns)</td><td align="right" bgcolor="#FF4949">3062,913 ns (Δ = +187,696 ns)</td><td align="right" bgcolor="#FFFFFF">3017,360 ns (Δ = -45,553 ns)</td><td align="right" bgcolor="#A8D08D">2861,259 ns (Δ = -156,101 ns)</td><td align="right" bgcolor="#FFFFFF">2898,827 ns (Δ = +37,568 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,897 μs</td><td align="right" bgcolor="#FFFFFF">2,875 μs (Δ = -0,021 μs)</td><td align="right" bgcolor="#FF4949">3,063 μs (Δ = +0,188 μs)</td><td align="right" bgcolor="#FFFFFF">3,017 μs (Δ = -0,046 μs)</td><td align="right" bgcolor="#A8D08D">2,861 μs (Δ = -0,156 μs)</td><td align="right" bgcolor="#FFFFFF">2,899 μs (Δ = +0,038 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 107,300 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7724,047 ns</td><td align="right" bgcolor="#FFFFFF">7759,340 ns (Δ = +35,293 ns)</td><td align="right" bgcolor="#FFFFFF">7741,474 ns (Δ = -17,866 ns)</td><td align="right" bgcolor="#FFFFFF">7714,988 ns (Δ = -26,486 ns)</td><td align="right" bgcolor="#FFFFFF">7652,040 ns (Δ = -62,948 ns)</td><td align="right" bgcolor="#FFFFFF">7705,887 ns (Δ = +53,847 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,724 μs</td><td align="right" bgcolor="#FFFFFF">7,759 μs (Δ = +0,035 μs)</td><td align="right" bgcolor="#FFFFFF">7,741 μs (Δ = -0,018 μs)</td><td align="right" bgcolor="#FFFFFF">7,715 μs (Δ = -0,026 μs)</td><td align="right" bgcolor="#FFFFFF">7,652 μs (Δ = -0,063 μs)</td><td align="right" bgcolor="#FFFFFF">7,706 μs (Δ = +0,054 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 5.0.0

Δ: 3231,271 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9653,889 ns</td><td align="right" bgcolor="#FF4949">10115,978 ns (Δ = +462,089 ns)</td><td align="right" bgcolor="#A8D08D">9722,713 ns (Δ = -393,264 ns)</td><td align="right" bgcolor="#FFFFFF">9966,333 ns (Δ = +243,620 ns)</td><td align="right" bgcolor="#FFFFFF">9894,738 ns (Δ = -71,596 ns)</td><td align="right" bgcolor="#FF4949">12885,160 ns (Δ = +2990,423 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,654 μs</td><td align="right" bgcolor="#FF4949">10,116 μs (Δ = +0,462 μs)</td><td align="right" bgcolor="#A8D08D">9,723 μs (Δ = -0,393 μs)</td><td align="right" bgcolor="#FFFFFF">9,966 μs (Δ = +0,244 μs)</td><td align="right" bgcolor="#FFFFFF">9,895 μs (Δ = -0,072 μs)</td><td align="right" bgcolor="#FF4949">12,885 μs (Δ = +2,990 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,013 ms (Δ = +0,003 ms)</td></tr>
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

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 421,763 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9791,709 ns</td><td align="right" bgcolor="#FFFFFF">9867,247 ns (Δ = +75,538 ns)</td><td align="right" bgcolor="#FFFFFF">9795,527 ns (Δ = -71,719 ns)</td><td align="right" bgcolor="#FFFFFF">9699,516 ns (Δ = -96,012 ns)</td><td align="right" bgcolor="#FFFFFF">9851,210 ns (Δ = +151,694 ns)</td><td align="right" bgcolor="#FFFFFF">10121,278 ns (Δ = +270,068 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,792 μs</td><td align="right" bgcolor="#FFFFFF">9,867 μs (Δ = +0,076 μs)</td><td align="right" bgcolor="#FFFFFF">9,796 μs (Δ = -0,072 μs)</td><td align="right" bgcolor="#FFFFFF">9,700 μs (Δ = -0,096 μs)</td><td align="right" bgcolor="#FFFFFF">9,851 μs (Δ = +0,152 μs)</td><td align="right" bgcolor="#FFFFFF">10,121 μs (Δ = +0,270 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,010 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 52,224 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1029,284 ns</td><td align="right" bgcolor="#FFFFFF">1024,813 ns (Δ = -4,471 ns)</td><td align="right" bgcolor="#FFFFFF">998,870 ns (Δ = -25,943 ns)</td><td align="right" bgcolor="#FFFFFF">1016,980 ns (Δ = +18,110 ns)</td><td align="right" bgcolor="#A8D08D">977,060 ns (Δ = -39,920 ns)</td><td align="right" bgcolor="#FF4949">1021,927 ns (Δ = +44,867 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,029 μs</td><td align="right" bgcolor="#FFFFFF">1,025 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,999 μs (Δ = -0,026 μs)</td><td align="right" bgcolor="#FFFFFF">1,017 μs (Δ = +0,018 μs)</td><td align="right" bgcolor="#A8D08D">0,977 μs (Δ = -0,040 μs)</td><td align="right" bgcolor="#FF4949">1,022 μs (Δ = +0,045 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">1245</td><td align="right">1245</td><td align="right">1245</td><td align="right">1245</td><td align="right">1245</td><td align="right">1245</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,216</td><td align="right">1,216</td><td align="right">1,216</td><td align="right">1,216</td><td align="right">1,216</td><td align="right">1,216</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 292,309 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3320,209 ns</td><td align="right" bgcolor="#A8D08D">3214,667 ns (Δ = -105,542 ns)</td><td align="right" bgcolor="#FFFFFF">3183,880 ns (Δ = -30,787 ns)</td><td align="right" bgcolor="#A8D08D">3027,900 ns (Δ = -155,980 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,320 μs</td><td align="right" bgcolor="#A8D08D">3,215 μs (Δ = -0,106 μs)</td><td align="right" bgcolor="#FFFFFF">3,184 μs (Δ = -0,031 μs)</td><td align="right" bgcolor="#A8D08D">3,028 μs (Δ = -0,156 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">262</td><td align="right">262</td><td align="right">262</td><td align="right">262</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,256</td><td align="right">0,256</td><td align="right">0,256</td><td align="right">0,256</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 85,707 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3754,535 ns</td><td align="right" bgcolor="#FFFFFF">3735,000 ns (Δ = -19,535 ns)</td><td align="right" bgcolor="#FFFFFF">3671,493 ns (Δ = -63,507 ns)</td><td align="right" bgcolor="#FFFFFF">3757,200 ns (Δ = +85,707 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,755 μs</td><td align="right" bgcolor="#FFFFFF">3,735 μs (Δ = -0,020 μs)</td><td align="right" bgcolor="#FFFFFF">3,671 μs (Δ = -0,064 μs)</td><td align="right" bgcolor="#FFFFFF">3,757 μs (Δ = +0,086 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **4.5.0**

Slowest: 4.4.0

Δ: 1165,150 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4275,650 ns</td><td align="right" bgcolor="#A8D08D">3110,500 ns (Δ = -1165,150 ns)</td><td align="right" bgcolor="#FFFFFF">3112,160 ns (Δ = +1,660 ns)</td><td align="right" bgcolor="#FFFFFF">3123,330 ns (Δ = +11,170 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,276 μs</td><td align="right" bgcolor="#A8D08D">3,111 μs (Δ = -1,165 μs)</td><td align="right" bgcolor="#FFFFFF">3,112 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">3,123 μs (Δ = +0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">262</td><td align="right">262</td><td align="right">262</td><td align="right">262</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,256</td><td align="right">0,256</td><td align="right">0,256</td><td align="right">0,256</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **4.5.0**

Slowest: 4.5.4

Δ: 191,160 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3867,927 ns</td><td align="right" bgcolor="#FFFFFF">3775,418 ns (Δ = -92,509 ns)</td><td align="right" bgcolor="#FF4949">3966,578 ns (Δ = +191,160 ns)</td><td align="right" bgcolor="#A8D08D">3783,423 ns (Δ = -183,154 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,868 μs</td><td align="right" bgcolor="#FFFFFF">3,775 μs (Δ = -0,093 μs)</td><td align="right" bgcolor="#FF4949">3,967 μs (Δ = +0,191 μs)</td><td align="right" bgcolor="#A8D08D">3,783 μs (Δ = -0,183 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 1125,866 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3046,982 ns</td><td align="right" bgcolor="#FFFFFF">3026,580 ns (Δ = -20,402 ns)</td><td align="right" bgcolor="#FFFFFF">2986,990 ns (Δ = -39,590 ns)</td><td align="right" bgcolor="#FF4949">4112,856 ns (Δ = +1125,866 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,047 μs</td><td align="right" bgcolor="#FFFFFF">3,027 μs (Δ = -0,020 μs)</td><td align="right" bgcolor="#FFFFFF">2,987 μs (Δ = -0,040 μs)</td><td align="right" bgcolor="#FF4949">4,113 μs (Δ = +1,126 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">262</td><td align="right">262</td><td align="right">262</td><td align="right">262</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,256</td><td align="right">0,256</td><td align="right">0,256</td><td align="right">0,256</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 308,426 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3811,588 ns</td><td align="right" bgcolor="#FFFFFF">3918,702 ns (Δ = +107,114 ns)</td><td align="right" bgcolor="#A8D08D">3610,276 ns (Δ = -308,426 ns)</td><td align="right" bgcolor="#FF4949">3878,305 ns (Δ = +268,028 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,812 μs</td><td align="right" bgcolor="#FFFFFF">3,919 μs (Δ = +0,107 μs)</td><td align="right" bgcolor="#A8D08D">3,610 μs (Δ = -0,308 μs)</td><td align="right" bgcolor="#FF4949">3,878 μs (Δ = +0,268 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 132,460 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3195,113 ns</td><td align="right" bgcolor="#FFFFFF">3164,353 ns (Δ = -30,760 ns)</td><td align="right" bgcolor="#A8D08D">3062,653 ns (Δ = -101,700 ns)</td><td align="right" bgcolor="#FFFFFF">3102,590 ns (Δ = +39,937 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,195 μs</td><td align="right" bgcolor="#FFFFFF">3,164 μs (Δ = -0,031 μs)</td><td align="right" bgcolor="#A8D08D">3,063 μs (Δ = -0,102 μs)</td><td align="right" bgcolor="#FFFFFF">3,103 μs (Δ = +0,040 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">262</td><td align="right">262</td><td align="right">262</td><td align="right">262</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,256</td><td align="right">0,256</td><td align="right">0,256</td><td align="right">0,256</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 226,378 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3808,747 ns</td><td align="right" bgcolor="#FFFFFF">3754,860 ns (Δ = -53,887 ns)</td><td align="right" bgcolor="#FFFFFF">3782,780 ns (Δ = +27,920 ns)</td><td align="right" bgcolor="#FF4949">3981,238 ns (Δ = +198,458 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,809 μs</td><td align="right" bgcolor="#FFFFFF">3,755 μs (Δ = -0,054 μs)</td><td align="right" bgcolor="#FFFFFF">3,783 μs (Δ = +0,028 μs)</td><td align="right" bgcolor="#FF4949">3,981 μs (Δ = +0,198 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 107,235 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2960,107 ns</td><td align="right" bgcolor="#FF4949">3067,341 ns (Δ = +107,235 ns)</td><td align="right" bgcolor="#FFFFFF">3011,000 ns (Δ = -56,341 ns)</td><td align="right" bgcolor="#FFFFFF">3042,780 ns (Δ = +31,780 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,960 μs</td><td align="right" bgcolor="#FF4949">3,067 μs (Δ = +0,107 μs)</td><td align="right" bgcolor="#FFFFFF">3,011 μs (Δ = -0,056 μs)</td><td align="right" bgcolor="#FFFFFF">3,043 μs (Δ = +0,032 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">262</td><td align="right">262</td><td align="right">262</td><td align="right">262</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,256</td><td align="right">0,256</td><td align="right">0,256</td><td align="right">0,256</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 169,846 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3718,484 ns</td><td align="right" bgcolor="#FFFFFF">3649,899 ns (Δ = -68,586 ns)</td><td align="right" bgcolor="#FF4949">3793,067 ns (Δ = +143,168 ns)</td><td align="right" bgcolor="#FFFFFF">3819,745 ns (Δ = +26,678 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,718 μs</td><td align="right" bgcolor="#FFFFFF">3,650 μs (Δ = -0,069 μs)</td><td align="right" bgcolor="#FF4949">3,793 μs (Δ = +0,143 μs)</td><td align="right" bgcolor="#FFFFFF">3,820 μs (Δ = +0,027 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 88,509 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3129,516 ns</td><td align="right" bgcolor="#FFFFFF">3218,024 ns (Δ = +88,509 ns)</td><td align="right" bgcolor="#FFFFFF">3142,337 ns (Δ = -75,688 ns)</td><td align="right" bgcolor="#FFFFFF">3145,078 ns (Δ = +2,741 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,130 μs</td><td align="right" bgcolor="#FFFFFF">3,218 μs (Δ = +0,089 μs)</td><td align="right" bgcolor="#FFFFFF">3,142 μs (Δ = -0,076 μs)</td><td align="right" bgcolor="#FFFFFF">3,145 μs (Δ = +0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">262</td><td align="right">262</td><td align="right">262</td><td align="right">262</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,256</td><td align="right">0,256</td><td align="right">0,256</td><td align="right">0,256</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 167,221 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3851,684 ns</td><td align="right" bgcolor="#FFFFFF">3894,350 ns (Δ = +42,666 ns)</td><td align="right" bgcolor="#A8D08D">3727,129 ns (Δ = -167,221 ns)</td><td align="right" bgcolor="#FFFFFF">3783,160 ns (Δ = +56,031 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,852 μs</td><td align="right" bgcolor="#FFFFFF">3,894 μs (Δ = +0,043 μs)</td><td align="right" bgcolor="#A8D08D">3,727 μs (Δ = -0,167 μs)</td><td align="right" bgcolor="#FFFFFF">3,783 μs (Δ = +0,056 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 209,375 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">102,076 ns</td><td align="right" bgcolor="#FFFFFF">101,413 ns (Δ = -0,662 ns)</td><td align="right" bgcolor="#FFFFFF">98,500 ns (Δ = -2,913 ns)</td><td align="right" bgcolor="#FF4949">248,955 ns (Δ = +150,455 ns)</td><td align="right" bgcolor="#FFFFFF">253,049 ns (Δ = +4,094 ns)</td><td align="right" bgcolor="#FF4949">307,875 ns (Δ = +54,826 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,099 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,249 μs (Δ = +0,150 μs)</td><td align="right" bgcolor="#FFFFFF">0,253 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FF4949">0,308 μs (Δ = +0,055 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 134,960 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">131,698 ns</td><td align="right" bgcolor="#FFFFFF">129,213 ns (Δ = -2,485 ns)</td><td align="right" bgcolor="#FFFFFF">130,350 ns (Δ = +1,137 ns)</td><td align="right" bgcolor="#FF4949">264,173 ns (Δ = +133,823 ns)</td><td align="right" bgcolor="#A8D08D">252,200 ns (Δ = -11,973 ns)</td><td align="right" bgcolor="#FFFFFF">250,452 ns (Δ = -1,748 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,130 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,264 μs (Δ = +0,134 μs)</td><td align="right" bgcolor="#A8D08D">0,252 μs (Δ = -0,012 μs)</td><td align="right" bgcolor="#FFFFFF">0,250 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 136,199 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">134,951 ns</td><td align="right" bgcolor="#FFFFFF">131,662 ns (Δ = -3,289 ns)</td><td align="right" bgcolor="#FFFFFF">131,840 ns (Δ = +0,178 ns)</td><td align="right" bgcolor="#FF4949">267,861 ns (Δ = +136,021 ns)</td><td align="right" bgcolor="#A8D08D">258,809 ns (Δ = -9,052 ns)</td><td align="right" bgcolor="#FFFFFF">255,155 ns (Δ = -3,654 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,132 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,268 μs (Δ = +0,136 μs)</td><td align="right" bgcolor="#A8D08D">0,259 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FFFFFF">0,255 μs (Δ = -0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">147</td><td align="right">147</td><td align="right">147</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,144</td><td align="right">0,144</td><td align="right">0,144</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0

Δ: 171,453 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">104,747 ns</td><td align="right" bgcolor="#FF4949">109,447 ns (Δ = +4,700 ns)</td><td align="right" bgcolor="#A8D08D">106,258 ns (Δ = -3,189 ns)</td><td align="right" bgcolor="#FF4949">234,298 ns (Δ = +128,040 ns)</td><td align="right" bgcolor="#FF4949">246,741 ns (Δ = +12,443 ns)</td><td align="right" bgcolor="#FF4949">276,200 ns (Δ = +29,459 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FF4949">0,109 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,106 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,234 μs (Δ = +0,128 μs)</td><td align="right" bgcolor="#FF4949">0,247 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#FF4949">0,276 μs (Δ = +0,029 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">131</td><td align="right">131</td><td align="right">131</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,128</td><td align="right">0,128</td><td align="right">0,128</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 173,962 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">114,767 ns</td><td align="right" bgcolor="#A8D08D">109,716 ns (Δ = -5,051 ns)</td><td align="right" bgcolor="#A8D08D">106,388 ns (Δ = -3,327 ns)</td><td align="right" bgcolor="#FF4949">280,350 ns (Δ = +173,962 ns)</td><td align="right" bgcolor="#A8D08D">235,350 ns (Δ = -45,000 ns)</td><td align="right" bgcolor="#FFFFFF">235,200 ns (Δ = -0,150 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#A8D08D">0,110 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,106 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,280 μs (Δ = +0,174 μs)</td><td align="right" bgcolor="#A8D08D">0,235 μs (Δ = -0,045 μs)</td><td align="right" bgcolor="#FFFFFF">0,235 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">32</td><td align="right">33</td><td align="right">33</td><td align="right">131</td><td align="right">131</td><td align="right">131</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,031</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,128</td><td align="right">0,128</td><td align="right">0,128</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 158,379 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">97,547 ns</td><td align="right" bgcolor="#FF4949">101,573 ns (Δ = +4,026 ns)</td><td align="right" bgcolor="#FFFFFF">102,822 ns (Δ = +1,249 ns)</td><td align="right" bgcolor="#FF4949">255,927 ns (Δ = +153,104 ns)</td><td align="right" bgcolor="#A8D08D">243,995 ns (Δ = -11,932 ns)</td><td align="right" bgcolor="#FF4949">251,708 ns (Δ = +7,714 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FF4949">0,102 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,103 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,256 μs (Δ = +0,153 μs)</td><td align="right" bgcolor="#A8D08D">0,244 μs (Δ = -0,012 μs)</td><td align="right" bgcolor="#FF4949">0,252 μs (Δ = +0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">28</td><td align="right">33</td><td align="right">33</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,027</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **4.5.4**

Slowest: 4.2.0

Δ: 218,925 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1222,814 ns</td><td align="right" bgcolor="#A8D08D">1016,173 ns (Δ = -206,641 ns)</td><td align="right" bgcolor="#FF4949">1167,040 ns (Δ = +150,867 ns)</td><td align="right" bgcolor="#FF4949">1214,380 ns (Δ = +47,340 ns)</td><td align="right" bgcolor="#A8D08D">1003,889 ns (Δ = -210,491 ns)</td><td align="right" bgcolor="#FFFFFF">1019,611 ns (Δ = +15,722 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,223 μs</td><td align="right" bgcolor="#A8D08D">1,016 μs (Δ = -0,207 μs)</td><td align="right" bgcolor="#FF4949">1,167 μs (Δ = +0,151 μs)</td><td align="right" bgcolor="#FF4949">1,214 μs (Δ = +0,047 μs)</td><td align="right" bgcolor="#A8D08D">1,004 μs (Δ = -0,210 μs)</td><td align="right" bgcolor="#FFFFFF">1,020 μs (Δ = +0,016 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">197</td><td align="right">197</td><td align="right">197</td><td align="right">197</td><td align="right">197</td><td align="right">197</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,192</td><td align="right">0,192</td><td align="right">0,192</td><td align="right">0,192</td><td align="right">0,192</td><td align="right">0,192</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 23,282 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">171,756 ns</td><td align="right" bgcolor="#FFFFFF">170,190 ns (Δ = -1,566 ns)</td><td align="right" bgcolor="#FF4949">175,640 ns (Δ = +5,450 ns)</td><td align="right" bgcolor="#FFFFFF">176,502 ns (Δ = +0,862 ns)</td><td align="right" bgcolor="#A8D08D">153,220 ns (Δ = -23,282 ns)</td><td align="right" bgcolor="#FF4949">164,818 ns (Δ = +11,598 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,170 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,176 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,177 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,153 μs (Δ = -0,023 μs)</td><td align="right" bgcolor="#FF4949">0,165 μs (Δ = +0,012 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 28,107 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">193,410 ns</td><td align="right" bgcolor="#FF4949">210,720 ns (Δ = +17,310 ns)</td><td align="right" bgcolor="#FFFFFF">206,492 ns (Δ = -4,228 ns)</td><td align="right" bgcolor="#A8D08D">197,920 ns (Δ = -8,572 ns)</td><td align="right" bgcolor="#A8D08D">182,613 ns (Δ = -15,307 ns)</td><td align="right" bgcolor="#FF4949">193,465 ns (Δ = +10,852 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FF4949">0,211 μs (Δ = +0,017 μs)</td><td align="right" bgcolor="#FFFFFF">0,206 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,198 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,183 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#FF4949">0,193 μs (Δ = +0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 138,194 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2065,467 ns</td><td align="right" bgcolor="#FFFFFF">2047,475 ns (Δ = -17,992 ns)</td><td align="right" bgcolor="#FFFFFF">2071,187 ns (Δ = +23,712 ns)</td><td align="right" bgcolor="#FFFFFF">2083,813 ns (Δ = +12,627 ns)</td><td align="right" bgcolor="#A8D08D">1979,471 ns (Δ = -104,342 ns)</td><td align="right" bgcolor="#FF4949">2117,665 ns (Δ = +138,194 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,065 μs</td><td align="right" bgcolor="#FFFFFF">2,047 μs (Δ = -0,018 μs)</td><td align="right" bgcolor="#FFFFFF">2,071 μs (Δ = +0,024 μs)</td><td align="right" bgcolor="#FFFFFF">2,084 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#A8D08D">1,979 μs (Δ = -0,104 μs)</td><td align="right" bgcolor="#FF4949">2,118 μs (Δ = +0,138 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 5.0.0

Δ: 265,743 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3962,438 ns</td><td align="right" bgcolor="#FF4949">4118,413 ns (Δ = +155,975 ns)</td><td align="right" bgcolor="#FFFFFF">4123,718 ns (Δ = +5,305 ns)</td><td align="right" bgcolor="#FFFFFF">4150,698 ns (Δ = +26,979 ns)</td><td align="right" bgcolor="#FFFFFF">4142,720 ns (Δ = -7,978 ns)</td><td align="right" bgcolor="#FFFFFF">4228,181 ns (Δ = +85,461 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,962 μs</td><td align="right" bgcolor="#FF4949">4,118 μs (Δ = +0,156 μs)</td><td align="right" bgcolor="#FFFFFF">4,124 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#FFFFFF">4,151 μs (Δ = +0,027 μs)</td><td align="right" bgcolor="#FFFFFF">4,143 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FFFFFF">4,228 μs (Δ = +0,085 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">1114</td><td align="right">1114</td><td align="right">1114</td><td align="right">1114</td><td align="right">1114</td><td align="right">1114</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,088</td><td align="right">1,088</td><td align="right">1,088</td><td align="right">1,088</td><td align="right">1,088</td><td align="right">1,088</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 83,205 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">337,969 ns</td><td align="right" bgcolor="#FFFFFF">343,940 ns (Δ = +5,971 ns)</td><td align="right" bgcolor="#FF4949">410,933 ns (Δ = +66,993 ns)</td><td align="right" bgcolor="#A8D08D">354,190 ns (Δ = -56,743 ns)</td><td align="right" bgcolor="#A8D08D">327,727 ns (Δ = -26,463 ns)</td><td align="right" bgcolor="#FF4949">337,902 ns (Δ = +10,175 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,338 μs</td><td align="right" bgcolor="#FFFFFF">0,344 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FF4949">0,411 μs (Δ = +0,067 μs)</td><td align="right" bgcolor="#A8D08D">0,354 μs (Δ = -0,057 μs)</td><td align="right" bgcolor="#A8D08D">0,328 μs (Δ = -0,026 μs)</td><td align="right" bgcolor="#FF4949">0,338 μs (Δ = +0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 281,620 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3988,360 ns</td><td align="right" bgcolor="#FF4949">4146,663 ns (Δ = +158,303 ns)</td><td align="right" bgcolor="#A8D08D">3948,084 ns (Δ = -198,578 ns)</td><td align="right" bgcolor="#FFFFFF">3971,361 ns (Δ = +23,277 ns)</td><td align="right" bgcolor="#FF4949">4192,393 ns (Δ = +221,032 ns)</td><td align="right" bgcolor="#FFFFFF">4229,705 ns (Δ = +37,311 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,988 μs</td><td align="right" bgcolor="#FF4949">4,147 μs (Δ = +0,158 μs)</td><td align="right" bgcolor="#A8D08D">3,948 μs (Δ = -0,199 μs)</td><td align="right" bgcolor="#FFFFFF">3,971 μs (Δ = +0,023 μs)</td><td align="right" bgcolor="#FF4949">4,192 μs (Δ = +0,221 μs)</td><td align="right" bgcolor="#FFFFFF">4,230 μs (Δ = +0,037 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 4.4.0

Δ: 171,138 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">502,180 ns</td><td align="right" bgcolor="#FFFFFF">499,249 ns (Δ = -2,931 ns)</td><td align="right" bgcolor="#FFFFFF">508,396 ns (Δ = +9,147 ns)</td><td align="right" bgcolor="#A8D08D">361,120 ns (Δ = -147,276 ns)</td><td align="right" bgcolor="#A8D08D">337,258 ns (Δ = -23,862 ns)</td><td align="right" bgcolor="#FFFFFF">338,547 ns (Δ = +1,289 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,502 μs</td><td align="right" bgcolor="#FFFFFF">0,499 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,508 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,361 μs (Δ = -0,147 μs)</td><td align="right" bgcolor="#A8D08D">0,337 μs (Δ = -0,024 μs)</td><td align="right" bgcolor="#FFFFFF">0,339 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 4.3.0

Δ: 4581,008 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4766,028 ns</td><td align="right" bgcolor="#FF4949">4914,363 ns (Δ = +148,335 ns)</td><td align="right" bgcolor="#A8D08D">4555,018 ns (Δ = -359,346 ns)</td><td align="right" bgcolor="#A8D08D">366,600 ns (Δ = -4188,418 ns)</td><td align="right" bgcolor="#A8D08D">333,356 ns (Δ = -33,244 ns)</td><td align="right" bgcolor="#FF4949">362,664 ns (Δ = +29,308 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,766 μs</td><td align="right" bgcolor="#FF4949">4,914 μs (Δ = +0,148 μs)</td><td align="right" bgcolor="#A8D08D">4,555 μs (Δ = -0,359 μs)</td><td align="right" bgcolor="#A8D08D">0,367 μs (Δ = -4,188 μs)</td><td align="right" bgcolor="#A8D08D">0,333 μs (Δ = -0,033 μs)</td><td align="right" bgcolor="#FF4949">0,363 μs (Δ = +0,029 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = -0,004 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Δ: 215,956 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">166,175 ns</td><td align="right" bgcolor="#A8D08D">160,700 ns (Δ = -5,475 ns)</td><td align="right" bgcolor="#FFFFFF">162,036 ns (Δ = +1,336 ns)</td><td align="right" bgcolor="#FF4949">376,656 ns (Δ = +214,620 ns)</td><td align="right" bgcolor="#A8D08D">358,022 ns (Δ = -18,633 ns)</td><td align="right" bgcolor="#A8D08D">338,360 ns (Δ = -19,662 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#A8D08D">0,161 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,162 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,377 μs (Δ = +0,215 μs)</td><td align="right" bgcolor="#A8D08D">0,358 μs (Δ = -0,019 μs)</td><td align="right" bgcolor="#A8D08D">0,338 μs (Δ = -0,020 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">10</td><td align="right">16</td><td align="right">16</td><td align="right">115</td><td align="right">115</td><td align="right">115</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,010</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,112</td><td align="right">0,112</td><td align="right">0,112</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 156,793 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">489,270 ns</td><td align="right" bgcolor="#FF4949">508,133 ns (Δ = +18,863 ns)</td><td align="right" bgcolor="#A8D08D">492,100 ns (Δ = -16,033 ns)</td><td align="right" bgcolor="#A8D08D">358,447 ns (Δ = -133,653 ns)</td><td align="right" bgcolor="#FFFFFF">367,505 ns (Δ = +9,058 ns)</td><td align="right" bgcolor="#A8D08D">351,340 ns (Δ = -16,165 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,489 μs</td><td align="right" bgcolor="#FF4949">0,508 μs (Δ = +0,019 μs)</td><td align="right" bgcolor="#A8D08D">0,492 μs (Δ = -0,016 μs)</td><td align="right" bgcolor="#A8D08D">0,358 μs (Δ = -0,134 μs)</td><td align="right" bgcolor="#FFFFFF">0,368 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#A8D08D">0,351 μs (Δ = -0,016 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 64,703 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">388,870 ns</td><td align="right" bgcolor="#A8D08D">324,167 ns (Δ = -64,703 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,389 μs</td><td align="right" bgcolor="#A8D08D">0,324 μs (Δ = -0,065 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">66</td><td align="right">66</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,064</td><td align="right">0,064</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 0,877 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">114,617 ns</td><td align="right" bgcolor="#FFFFFF">115,493 ns (Δ = +0,877 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs (Δ = +0,001 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 4,291 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,436 ns</td><td align="right" bgcolor="#FF4949">17,727 ns (Δ = +4,291 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FF4949">0,018 μs (Δ = +0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 6,690 ns


<table>
<tr>
<th> </th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,670 ns</td><td align="right" bgcolor="#A8D08D">17,980 ns (Δ = -6,690 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#A8D08D">0,018 μs (Δ = -0,007 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark"></a>FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark

### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashInsert"></a>FastBindingList_BashInsert

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 19,822 ns


<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">881,671 ns</td><td align="right" bgcolor="#FFFFFF">866,004 ns (Δ = -15,667 ns)</td><td align="right" bgcolor="#FFFFFF">885,827 ns (Δ = +19,822 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,882 μs</td><td align="right" bgcolor="#FFFFFF">0,866 μs (Δ = -0,016 μs)</td><td align="right" bgcolor="#FFFFFF">0,886 μs (Δ = +0,020 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 333,526 ns


<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">500,066 ns</td><td align="right" bgcolor="#FFFFFF">498,111 ns (Δ = -1,955 ns)</td><td align="right" bgcolor="#FF4949">831,637 ns (Δ = +333,526 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,500 μs</td><td align="right" bgcolor="#FFFFFF">0,498 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,832 μs (Δ = +0,334 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">426</td><td align="right">426</td><td align="right">426</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,416</td><td align="right">0,416</td><td align="right">0,416</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastObservableCollection_BashInsert"></a>FastObservableCollection_BashInsert

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0

Δ: 560,933 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1430,841 ns</td><td align="right" bgcolor="#FFFFFF">1474,947 ns (Δ = +44,106 ns)</td><td align="right" bgcolor="#FFFFFF">1508,751 ns (Δ = +33,804 ns)</td><td align="right" bgcolor="#FF4949">1969,607 ns (Δ = +460,856 ns)</td><td align="right" bgcolor="#FFFFFF">1947,760 ns (Δ = -21,847 ns)</td><td align="right" bgcolor="#FFFFFF">1991,773 ns (Δ = +44,013 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,431 μs</td><td align="right" bgcolor="#FFFFFF">1,475 μs (Δ = +0,044 μs)</td><td align="right" bgcolor="#FFFFFF">1,509 μs (Δ = +0,034 μs)</td><td align="right" bgcolor="#FF4949">1,970 μs (Δ = +0,461 μs)</td><td align="right" bgcolor="#FFFFFF">1,948 μs (Δ = -0,022 μs)</td><td align="right" bgcolor="#FFFFFF">1,992 μs (Δ = +0,044 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">3421</td><td align="right">3420</td><td align="right">3420</td><td align="right">4059</td><td align="right">4059</td><td align="right">4059</td><tr>
<td>Allocated Kilobytes</td><td align="right">3,341</td><td align="right">3,340</td><td align="right">3,340</td><td align="right">3,964</td><td align="right">3,964</td><td align="right">3,964</td><tr>
<td>Allocated Megabytes</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,004</td><td align="right">0,004</td><td align="right">0,004</td></tr>
</table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_ObservableCollection_BashInsert"></a>ObservableCollection_BashInsert

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 52,418 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">905,324 ns</td><td align="right" bgcolor="#A8D08D">878,311 ns (Δ = -27,013 ns)</td><td align="right" bgcolor="#FF4949">913,482 ns (Δ = +35,171 ns)</td><td align="right" bgcolor="#FFFFFF">930,729 ns (Δ = +17,247 ns)</td><td align="right" bgcolor="#A8D08D">890,022 ns (Δ = -40,707 ns)</td><td align="right" bgcolor="#FFFFFF">903,294 ns (Δ = +13,273 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,905 μs</td><td align="right" bgcolor="#A8D08D">0,878 μs (Δ = -0,027 μs)</td><td align="right" bgcolor="#FF4949">0,913 μs (Δ = +0,035 μs)</td><td align="right" bgcolor="#FFFFFF">0,931 μs (Δ = +0,017 μs)</td><td align="right" bgcolor="#A8D08D">0,890 μs (Δ = -0,041 μs)</td><td align="right" bgcolor="#FFFFFF">0,903 μs (Δ = +0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">1946</td><td align="right">1947</td><td align="right">1947</td><td align="right">1947</td><td align="right">1947</td><td align="right">1947</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,900</td><td align="right">1,901</td><td align="right">1,901</td><td align="right">1,901</td><td align="right">1,901</td><td align="right">1,901</td><tr>
<td>Allocated Megabytes</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td><td align="right">0,002</td></tr>
</table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **4.2.0**

Slowest: 5.0.0

Δ: 1,328 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,351 ns</td><td align="right" bgcolor="#FF4949">6,574 ns (Δ = +0,223 ns)</td><td align="right" bgcolor="#FF4949">6,800 ns (Δ = +0,226 ns)</td><td align="right" bgcolor="#FF4949">7,366 ns (Δ = +0,566 ns)</td><td align="right" bgcolor="#FFFFFF">7,548 ns (Δ = +0,182 ns)</td><td align="right" bgcolor="#FFFFFF">7,679 ns (Δ = +0,131 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FF4949">0,007 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,007 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,007 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,008 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,008 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 4.2.0

Δ: 3,265 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,960 ns</td><td align="right" bgcolor="#A8D08D">28,916 ns (Δ = -1,044 ns)</td><td align="right" bgcolor="#FFFFFF">28,420 ns (Δ = -0,496 ns)</td><td align="right" bgcolor="#FF4949">29,800 ns (Δ = +1,380 ns)</td><td align="right" bgcolor="#A8D08D">26,695 ns (Δ = -3,105 ns)</td><td align="right" bgcolor="#FF4949">29,043 ns (Δ = +2,348 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#A8D08D">0,029 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,028 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,030 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,027 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,029 μs (Δ = +0,002 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">66</td><td align="right">66</td><td align="right">66</td><td align="right">66</td><td align="right">66</td><td align="right">66</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,064</td><td align="right">0,064</td><td align="right">0,064</td><td align="right">0,064</td><td align="right">0,064</td><td align="right">0,064</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 5,864 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,980 ns</td><td align="right" bgcolor="#A8D08D">22,175 ns (Δ = -0,805 ns)</td><td align="right" bgcolor="#FFFFFF">21,893 ns (Δ = -0,282 ns)</td><td align="right" bgcolor="#FF4949">26,203 ns (Δ = +4,311 ns)</td><td align="right" bgcolor="#A8D08D">23,213 ns (Δ = -2,990 ns)</td><td align="right" bgcolor="#A8D08D">20,339 ns (Δ = -2,874 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#A8D08D">0,022 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,026 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,023 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,020 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 419,900 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">583,413 ns</td><td align="right" bgcolor="#FFFFFF">577,565 ns (Δ = -5,849 ns)</td><td align="right" bgcolor="#FF4949">791,480 ns (Δ = +213,915 ns)</td><td align="right" bgcolor="#A8D08D">618,311 ns (Δ = -173,169 ns)</td><td align="right" bgcolor="#A8D08D">371,580 ns (Δ = -246,731 ns)</td><td align="right" bgcolor="#FF4949">387,520 ns (Δ = +15,940 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,583 μs</td><td align="right" bgcolor="#FFFFFF">0,578 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,791 μs (Δ = +0,214 μs)</td><td align="right" bgcolor="#A8D08D">0,618 μs (Δ = -0,173 μs)</td><td align="right" bgcolor="#A8D08D">0,372 μs (Δ = -0,247 μs)</td><td align="right" bgcolor="#FF4949">0,388 μs (Δ = +0,016 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">213</td><td align="right">213</td><td align="right">213</td><td align="right">246</td><td align="right">197</td><td align="right">164</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,208</td><td align="right">0,208</td><td align="right">0,208</td><td align="right">0,240</td><td align="right">0,192</td><td align="right">0,160</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 240,370 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">908,288 ns</td><td align="right" bgcolor="#FFFFFF">918,993 ns (Δ = +10,706 ns)</td><td align="right" bgcolor="#FFFFFF">920,053 ns (Δ = +1,060 ns)</td><td align="right" bgcolor="#FFFFFF">935,498 ns (Δ = +15,444 ns)</td><td align="right" bgcolor="#FFFFFF">959,441 ns (Δ = +23,943 ns)</td><td align="right" bgcolor="#A8D08D">719,071 ns (Δ = -240,370 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,908 μs</td><td align="right" bgcolor="#FFFFFF">0,919 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#FFFFFF">0,920 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,935 μs (Δ = +0,015 μs)</td><td align="right" bgcolor="#FFFFFF">0,959 μs (Δ = +0,024 μs)</td><td align="right" bgcolor="#A8D08D">0,719 μs (Δ = -0,240 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">393</td><td align="right">393</td><td align="right">393</td><td align="right">426</td><td align="right">393</td><td align="right">360</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,384</td><td align="right">0,384</td><td align="right">0,384</td><td align="right">0,416</td><td align="right">0,384</td><td align="right">0,352</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 449,109 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">898,233 ns</td><td align="right" bgcolor="#FF4949">1081,240 ns (Δ = +183,007 ns)</td><td align="right" bgcolor="#A8D08D">848,400 ns (Δ = -232,840 ns)</td><td align="right" bgcolor="#FFFFFF">853,753 ns (Δ = +5,353 ns)</td><td align="right" bgcolor="#A8D08D">632,131 ns (Δ = -221,623 ns)</td><td align="right" bgcolor="#FFFFFF">637,107 ns (Δ = +4,976 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,898 μs</td><td align="right" bgcolor="#FF4949">1,081 μs (Δ = +0,183 μs)</td><td align="right" bgcolor="#A8D08D">0,848 μs (Δ = -0,233 μs)</td><td align="right" bgcolor="#FFFFFF">0,854 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,632 μs (Δ = -0,222 μs)</td><td align="right" bgcolor="#FFFFFF">0,637 μs (Δ = +0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">393</td><td align="right">393</td><td align="right">393</td><td align="right">426</td><td align="right">377</td><td align="right">344</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,384</td><td align="right">0,384</td><td align="right">0,384</td><td align="right">0,416</td><td align="right">0,368</td><td align="right">0,336</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="MemberInfoExtensions_Benchmark"></a>MemberInfoExtensions_Benchmark

### <a name="MemberInfoExtensions_Benchmark_GetSignature_Constructor"></a>GetSignature_Constructor

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 143,758 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">206,440 ns</td><td align="right" bgcolor="#A8D08D">197,951 ns (Δ = -8,489 ns)</td><td align="right" bgcolor="#FFFFFF">194,115 ns (Δ = -3,836 ns)</td><td align="right" bgcolor="#FF4949">337,873 ns (Δ = +143,758 ns)</td><td align="right" bgcolor="#A8D08D">321,022 ns (Δ = -16,851 ns)</td><td align="right" bgcolor="#A8D08D">286,173 ns (Δ = -34,849 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#A8D08D">0,198 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,194 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,338 μs (Δ = +0,144 μs)</td><td align="right" bgcolor="#A8D08D">0,321 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#A8D08D">0,286 μs (Δ = -0,035 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">98</td><td align="right">98</td><td align="right">98</td><td align="right">213</td><td align="right">213</td><td align="right">213</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,096</td><td align="right">0,096</td><td align="right">0,096</td><td align="right">0,208</td><td align="right">0,208</td><td align="right">0,208</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="MemberInfoExtensions_Benchmark_GetSignature_Method"></a>GetSignature_Method

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 122,667 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">269,375 ns</td><td align="right" bgcolor="#FF4949">298,840 ns (Δ = +29,465 ns)</td><td align="right" bgcolor="#A8D08D">266,382 ns (Δ = -32,458 ns)</td><td align="right" bgcolor="#FF4949">389,049 ns (Δ = +122,667 ns)</td><td align="right" bgcolor="#FFFFFF">388,404 ns (Δ = -0,644 ns)</td><td align="right" bgcolor="#A8D08D">317,000 ns (Δ = -71,404 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,269 μs</td><td align="right" bgcolor="#FF4949">0,299 μs (Δ = +0,029 μs)</td><td align="right" bgcolor="#A8D08D">0,266 μs (Δ = -0,032 μs)</td><td align="right" bgcolor="#FF4949">0,389 μs (Δ = +0,123 μs)</td><td align="right" bgcolor="#FFFFFF">0,388 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,317 μs (Δ = -0,071 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">98</td><td align="right">98</td><td align="right">98</td><td align="right">213</td><td align="right">213</td><td align="right">213</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,096</td><td align="right">0,096</td><td align="right">0,096</td><td align="right">0,208</td><td align="right">0,208</td><td align="right">0,208</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 1665,670 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4324,867 ns</td><td align="right" bgcolor="#FFFFFF">4424,110 ns (Δ = +99,243 ns)</td><td align="right" bgcolor="#A8D08D">4282,260 ns (Δ = -141,850 ns)</td><td align="right" bgcolor="#FF4949">5947,930 ns (Δ = +1665,670 ns)</td><td align="right" bgcolor="#A8D08D">4600,577 ns (Δ = -1347,353 ns)</td><td align="right" bgcolor="#A8D08D">4361,220 ns (Δ = -239,357 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,325 μs</td><td align="right" bgcolor="#FFFFFF">4,424 μs (Δ = +0,099 μs)</td><td align="right" bgcolor="#A8D08D">4,282 μs (Δ = -0,142 μs)</td><td align="right" bgcolor="#FF4949">5,948 μs (Δ = +1,666 μs)</td><td align="right" bgcolor="#A8D08D">4,601 μs (Δ = -1,347 μs)</td><td align="right" bgcolor="#A8D08D">4,361 μs (Δ = -0,239 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,005 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.2.0**

Slowest: 4.5.0

Δ: 182,473 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7305,187 ns</td><td align="right" bgcolor="#FFFFFF">7384,560 ns (Δ = +79,373 ns)</td><td align="right" bgcolor="#FFFFFF">7380,680 ns (Δ = -3,880 ns)</td><td align="right" bgcolor="#FFFFFF">7487,660 ns (Δ = +106,980 ns)</td><td align="right" bgcolor="#FFFFFF">7339,900 ns (Δ = -147,760 ns)</td><td align="right" bgcolor="#FFFFFF">7415,952 ns (Δ = +76,052 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,305 μs</td><td align="right" bgcolor="#FFFFFF">7,385 μs (Δ = +0,079 μs)</td><td align="right" bgcolor="#FFFFFF">7,381 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">7,488 μs (Δ = +0,107 μs)</td><td align="right" bgcolor="#FFFFFF">7,340 μs (Δ = -0,148 μs)</td><td align="right" bgcolor="#FFFFFF">7,416 μs (Δ = +0,076 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 4.2.0

Δ: 280,856 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6055,503 ns</td><td align="right" bgcolor="#A8D08D">5824,867 ns (Δ = -230,636 ns)</td><td align="right" bgcolor="#FFFFFF">5867,433 ns (Δ = +42,567 ns)</td><td align="right" bgcolor="#FFFFFF">5774,647 ns (Δ = -92,787 ns)</td><td align="right" bgcolor="#FF4949">5970,055 ns (Δ = +195,408 ns)</td><td align="right" bgcolor="#FFFFFF">5816,107 ns (Δ = -153,948 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,056 μs</td><td align="right" bgcolor="#A8D08D">5,825 μs (Δ = -0,231 μs)</td><td align="right" bgcolor="#FFFFFF">5,867 μs (Δ = +0,043 μs)</td><td align="right" bgcolor="#FFFFFF">5,775 μs (Δ = -0,093 μs)</td><td align="right" bgcolor="#FF4949">5,970 μs (Δ = +0,195 μs)</td><td align="right" bgcolor="#FFFFFF">5,816 μs (Δ = -0,154 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,006 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,006 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">682</td><td align="right">688</td><td align="right">688</td><td align="right">688</td><td align="right">688</td><td align="right">688</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,666</td><td align="right">0,672</td><td align="right">0,672</td><td align="right">0,672</td><td align="right">0,672</td><td align="right">0,672</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 389,152 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4391,977 ns</td><td align="right" bgcolor="#FFFFFF">4381,950 ns (Δ = -10,027 ns)</td><td align="right" bgcolor="#FFFFFF">4304,578 ns (Δ = -77,372 ns)</td><td align="right" bgcolor="#FF4949">4444,204 ns (Δ = +139,626 ns)</td><td align="right" bgcolor="#A8D08D">4292,303 ns (Δ = -151,900 ns)</td><td align="right" bgcolor="#FF4949">4681,456 ns (Δ = +389,152 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,392 μs</td><td align="right" bgcolor="#FFFFFF">4,382 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">4,305 μs (Δ = -0,077 μs)</td><td align="right" bgcolor="#FF4949">4,444 μs (Δ = +0,140 μs)</td><td align="right" bgcolor="#A8D08D">4,292 μs (Δ = -0,152 μs)</td><td align="right" bgcolor="#FF4949">4,681 μs (Δ = +0,389 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,005 ms (Δ = +0,000 ms)</td></tr>
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

Δ: 247,831 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7430,364 ns</td><td align="right" bgcolor="#FFFFFF">7361,520 ns (Δ = -68,844 ns)</td><td align="right" bgcolor="#FFFFFF">7392,640 ns (Δ = +31,120 ns)</td><td align="right" bgcolor="#FFFFFF">7534,622 ns (Δ = +141,982 ns)</td><td align="right" bgcolor="#FFFFFF">7609,351 ns (Δ = +74,729 ns)</td><td align="right" bgcolor="#FFFFFF">7490,180 ns (Δ = -119,171 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,430 μs</td><td align="right" bgcolor="#FFFFFF">7,362 μs (Δ = -0,069 μs)</td><td align="right" bgcolor="#FFFFFF">7,393 μs (Δ = +0,031 μs)</td><td align="right" bgcolor="#FFFFFF">7,535 μs (Δ = +0,142 μs)</td><td align="right" bgcolor="#FFFFFF">7,609 μs (Δ = +0,075 μs)</td><td align="right" bgcolor="#FFFFFF">7,490 μs (Δ = -0,119 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 885,955 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9140,766 ns</td><td align="right" bgcolor="#FF4949">9764,375 ns (Δ = +623,609 ns)</td><td align="right" bgcolor="#A8D08D">9242,487 ns (Δ = -521,888 ns)</td><td align="right" bgcolor="#FFFFFF">9213,865 ns (Δ = -28,621 ns)</td><td align="right" bgcolor="#A8D08D">8878,420 ns (Δ = -335,445 ns)</td><td align="right" bgcolor="#FFFFFF">8936,369 ns (Δ = +57,949 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,141 μs</td><td align="right" bgcolor="#FF4949">9,764 μs (Δ = +0,624 μs)</td><td align="right" bgcolor="#A8D08D">9,242 μs (Δ = -0,522 μs)</td><td align="right" bgcolor="#FFFFFF">9,214 μs (Δ = -0,029 μs)</td><td align="right" bgcolor="#A8D08D">8,878 μs (Δ = -0,335 μs)</td><td align="right" bgcolor="#FFFFFF">8,936 μs (Δ = +0,058 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,009 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">1098</td><td align="right">1098</td><td align="right">1098</td><td align="right">1098</td><td align="right">1098</td><td align="right">1098</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,072</td><td align="right">1,072</td><td align="right">1,072</td><td align="right">1,072</td><td align="right">1,072</td><td align="right">1,072</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


## <a name="ModelBase_GetValue_Benchmark"></a>ModelBase_GetValue_Benchmark

### <a name="ModelBase_GetValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.3.0**

Slowest: 4.4.0

Δ: 30,527 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">135,497 ns</td><td align="right" bgcolor="#FFFFFF">132,300 ns (Δ = -3,197 ns)</td><td align="right" bgcolor="#FF4949">162,827 ns (Δ = +30,527 ns)</td><td align="right" bgcolor="#A8D08D">133,788 ns (Δ = -29,038 ns)</td><td align="right" bgcolor="#FFFFFF">136,369 ns (Δ = +2,581 ns)</td><td align="right" bgcolor="#FF4949">147,913 ns (Δ = +11,544 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,163 μs (Δ = +0,031 μs)</td><td align="right" bgcolor="#A8D08D">0,134 μs (Δ = -0,029 μs)</td><td align="right" bgcolor="#FFFFFF">0,136 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,148 μs (Δ = +0,012 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 4.4.0

Δ: 25,875 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">135,687 ns</td><td align="right" bgcolor="#FFFFFF">136,633 ns (Δ = +0,947 ns)</td><td align="right" bgcolor="#FF4949">154,200 ns (Δ = +17,567 ns)</td><td align="right" bgcolor="#A8D08D">134,727 ns (Δ = -19,473 ns)</td><td align="right" bgcolor="#A8D08D">128,325 ns (Δ = -6,402 ns)</td><td align="right" bgcolor="#FF4949">145,149 ns (Δ = +16,824 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,137 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,154 μs (Δ = +0,018 μs)</td><td align="right" bgcolor="#A8D08D">0,135 μs (Δ = -0,019 μs)</td><td align="right" bgcolor="#A8D08D">0,128 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,145 μs (Δ = +0,017 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.5.0**

Slowest: 4.4.0

Δ: 21,671 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">128,747 ns</td><td align="right" bgcolor="#FFFFFF">127,448 ns (Δ = -1,298 ns)</td><td align="right" bgcolor="#FF4949">147,147 ns (Δ = +19,698 ns)</td><td align="right" bgcolor="#A8D08D">125,476 ns (Δ = -21,671 ns)</td><td align="right" bgcolor="#FFFFFF">128,502 ns (Δ = +3,027 ns)</td><td align="right" bgcolor="#FF4949">135,760 ns (Δ = +7,258 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,147 μs (Δ = +0,020 μs)</td><td align="right" bgcolor="#A8D08D">0,125 μs (Δ = -0,022 μs)</td><td align="right" bgcolor="#FFFFFF">0,129 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FF4949">0,136 μs (Δ = +0,007 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 4.5.0

Δ: 1255,263 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1357,565 ns</td><td align="right" bgcolor="#FF4949">1559,991 ns (Δ = +202,426 ns)</td><td align="right" bgcolor="#FF4949">1620,270 ns (Δ = +60,279 ns)</td><td align="right" bgcolor="#FF4949">1744,540 ns (Δ = +124,270 ns)</td><td align="right" bgcolor="#FFFFFF">1729,111 ns (Δ = -15,429 ns)</td><td align="right" bgcolor="#A8D08D">489,278 ns (Δ = -1239,834 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,358 μs</td><td align="right" bgcolor="#FF4949">1,560 μs (Δ = +0,202 μs)</td><td align="right" bgcolor="#FF4949">1,620 μs (Δ = +0,060 μs)</td><td align="right" bgcolor="#FF4949">1,745 μs (Δ = +0,124 μs)</td><td align="right" bgcolor="#FFFFFF">1,729 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#A8D08D">0,489 μs (Δ = -1,240 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = -0,001 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">475</td><td align="right">508</td><td align="right">508</td><td align="right">639</td><td align="right">639</td><td align="right">82</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,464</td><td align="right">0,496</td><td align="right">0,496</td><td align="right">0,624</td><td align="right">0,624</td><td align="right">0,080</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1278,322 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1707,927 ns</td><td align="right" bgcolor="#A8D08D">1524,422 ns (Δ = -183,505 ns)</td><td align="right" bgcolor="#FF4949">1672,311 ns (Δ = +147,889 ns)</td><td align="right" bgcolor="#FFFFFF">1699,356 ns (Δ = +27,044 ns)</td><td align="right" bgcolor="#FF4949">1802,896 ns (Δ = +103,540 ns)</td><td align="right" bgcolor="#A8D08D">524,573 ns (Δ = -1278,322 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,708 μs</td><td align="right" bgcolor="#A8D08D">1,524 μs (Δ = -0,184 μs)</td><td align="right" bgcolor="#FF4949">1,672 μs (Δ = +0,148 μs)</td><td align="right" bgcolor="#FFFFFF">1,699 μs (Δ = +0,027 μs)</td><td align="right" bgcolor="#FF4949">1,803 μs (Δ = +0,104 μs)</td><td align="right" bgcolor="#A8D08D">0,525 μs (Δ = -1,278 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = -0,001 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">475</td><td align="right">508</td><td align="right">508</td><td align="right">639</td><td align="right">639</td><td align="right">82</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,464</td><td align="right">0,496</td><td align="right">0,496</td><td align="right">0,624</td><td align="right">0,624</td><td align="right">0,080</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 1252,832 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1259,820 ns</td><td align="right" bgcolor="#FF4949">1457,110 ns (Δ = +197,290 ns)</td><td align="right" bgcolor="#FFFFFF">1469,610 ns (Δ = +12,500 ns)</td><td align="right" bgcolor="#FF4949">1616,465 ns (Δ = +146,855 ns)</td><td align="right" bgcolor="#A8D08D">1546,080 ns (Δ = -70,385 ns)</td><td align="right" bgcolor="#A8D08D">363,633 ns (Δ = -1182,447 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,260 μs</td><td align="right" bgcolor="#FF4949">1,457 μs (Δ = +0,197 μs)</td><td align="right" bgcolor="#FFFFFF">1,470 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#FF4949">1,616 μs (Δ = +0,147 μs)</td><td align="right" bgcolor="#A8D08D">1,546 μs (Δ = -0,070 μs)</td><td align="right" bgcolor="#A8D08D">0,364 μs (Δ = -1,182 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = -0,001 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">459</td><td align="right">492</td><td align="right">492</td><td align="right">606</td><td align="right">606</td><td align="right">66</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,448</td><td align="right">0,480</td><td align="right">0,480</td><td align="right">0,592</td><td align="right">0,592</td><td align="right">0,064</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,000</td></tr>
</table>


## <a name="PropertyBag_GetPropertyValue_Benchmark"></a>PropertyBag_GetPropertyValue_Benchmark

### <a name="PropertyBag_GetPropertyValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.5.0**

Slowest: 5.0.0

Δ: 47,960 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">97,000 ns</td><td align="right" bgcolor="#FFFFFF">95,873 ns (Δ = -1,127 ns)</td><td align="right" bgcolor="#FFFFFF">93,830 ns (Δ = -2,043 ns)</td><td align="right" bgcolor="#A8D08D">77,267 ns (Δ = -16,563 ns)</td><td align="right" bgcolor="#FFFFFF">79,267 ns (Δ = +2,000 ns)</td><td align="right" bgcolor="#FF4949">125,227 ns (Δ = +45,960 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,094 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,077 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#FFFFFF">0,079 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FF4949">0,125 μs (Δ = +0,046 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 4.3.0

Δ: 19,959 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">96,409 ns</td><td align="right" bgcolor="#FFFFFF">99,289 ns (Δ = +2,880 ns)</td><td align="right" bgcolor="#FFFFFF">96,929 ns (Δ = -2,360 ns)</td><td align="right" bgcolor="#A8D08D">79,529 ns (Δ = -17,400 ns)</td><td align="right" bgcolor="#FFFFFF">80,222 ns (Δ = +0,693 ns)</td><td align="right" bgcolor="#FFFFFF">79,330 ns (Δ = -0,892 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,097 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,080 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#FFFFFF">0,080 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,079 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Slowest: 4.2.0

Δ: 21,647 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">105,427 ns</td><td align="right" bgcolor="#FFFFFF">102,985 ns (Δ = -2,442 ns)</td><td align="right" bgcolor="#FFFFFF">104,488 ns (Δ = +1,503 ns)</td><td align="right" bgcolor="#A8D08D">87,444 ns (Δ = -17,044 ns)</td><td align="right" bgcolor="#A8D08D">83,780 ns (Δ = -3,664 ns)</td><td align="right" bgcolor="#FFFFFF">85,671 ns (Δ = +1,891 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,103 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,104 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,087 μs (Δ = -0,017 μs)</td><td align="right" bgcolor="#A8D08D">0,084 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,086 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 4.4.0

Δ: 98,787 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">218,067 ns</td><td align="right" bgcolor="#A8D08D">210,440 ns (Δ = -7,627 ns)</td><td align="right" bgcolor="#FF4949">222,367 ns (Δ = +11,927 ns)</td><td align="right" bgcolor="#A8D08D">191,667 ns (Δ = -30,700 ns)</td><td align="right" bgcolor="#A8D08D">181,100 ns (Δ = -10,567 ns)</td><td align="right" bgcolor="#A8D08D">123,580 ns (Δ = -57,520 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#A8D08D">0,210 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FF4949">0,222 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#A8D08D">0,192 μs (Δ = -0,031 μs)</td><td align="right" bgcolor="#A8D08D">0,181 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,124 μs (Δ = -0,058 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 93,471 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">206,266 ns</td><td align="right" bgcolor="#FFFFFF">210,836 ns (Δ = +4,570 ns)</td><td align="right" bgcolor="#FFFFFF">216,767 ns (Δ = +5,931 ns)</td><td align="right" bgcolor="#A8D08D">189,724 ns (Δ = -27,043 ns)</td><td align="right" bgcolor="#FFFFFF">188,210 ns (Δ = -1,514 ns)</td><td align="right" bgcolor="#A8D08D">123,296 ns (Δ = -64,914 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,217 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#A8D08D">0,190 μs (Δ = -0,027 μs)</td><td align="right" bgcolor="#FFFFFF">0,188 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,123 μs (Δ = -0,065 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">33</td><td align="right">0</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,032</td><td align="right">0,000</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 52,030 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">103,147 ns</td><td align="right" bgcolor="#A8D08D">99,535 ns (Δ = -3,612 ns)</td><td align="right" bgcolor="#FF4949">126,604 ns (Δ = +27,069 ns)</td><td align="right" bgcolor="#A8D08D">76,540 ns (Δ = -50,064 ns)</td><td align="right" bgcolor="#FF4949">102,860 ns (Δ = +26,320 ns)</td><td align="right" bgcolor="#A8D08D">74,573 ns (Δ = -28,287 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td><td align="right" bgcolor="#A8D08D">0,100 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FF4949">0,127 μs (Δ = +0,027 μs)</td><td align="right" bgcolor="#A8D08D">0,077 μs (Δ = -0,050 μs)</td><td align="right" bgcolor="#FF4949">0,103 μs (Δ = +0,026 μs)</td><td align="right" bgcolor="#A8D08D">0,075 μs (Δ = -0,028 μs)</td></tr>
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


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 199,386 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4365,350 ns</td><td align="right" bgcolor="#FFFFFF">4334,813 ns (Δ = -30,537 ns)</td><td align="right" bgcolor="#FFFFFF">4229,286 ns (Δ = -105,527 ns)</td><td align="right" bgcolor="#FF4949">4421,038 ns (Δ = +191,752 ns)</td><td align="right" bgcolor="#A8D08D">4248,569 ns (Δ = -172,469 ns)</td><td align="right" bgcolor="#FFFFFF">4221,653 ns (Δ = -26,916 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,365 μs</td><td align="right" bgcolor="#FFFFFF">4,335 μs (Δ = -0,031 μs)</td><td align="right" bgcolor="#FFFFFF">4,229 μs (Δ = -0,106 μs)</td><td align="right" bgcolor="#FF4949">4,421 μs (Δ = +0,192 μs)</td><td align="right" bgcolor="#A8D08D">4,249 μs (Δ = -0,172 μs)</td><td align="right" bgcolor="#FFFFFF">4,222 μs (Δ = -0,027 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 64,051 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">841,872 ns</td><td align="right" bgcolor="#FFFFFF">829,300 ns (Δ = -12,572 ns)</td><td align="right" bgcolor="#FF4949">859,670 ns (Δ = +30,370 ns)</td><td align="right" bgcolor="#FF4949">893,351 ns (Δ = +33,681 ns)</td><td align="right" bgcolor="#A8D08D">847,900 ns (Δ = -45,451 ns)</td><td align="right" bgcolor="#FF4949">890,560 ns (Δ = +42,660 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,842 μs</td><td align="right" bgcolor="#FFFFFF">0,829 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FF4949">0,860 μs (Δ = +0,030 μs)</td><td align="right" bgcolor="#FF4949">0,893 μs (Δ = +0,034 μs)</td><td align="right" bgcolor="#A8D08D">0,848 μs (Δ = -0,045 μs)</td><td align="right" bgcolor="#FF4949">0,891 μs (Δ = +0,043 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">82</td><td align="right">82</td><td align="right">82</td><td align="right">82</td><td align="right">82</td><td align="right">82</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,080</td><td align="right">0,080</td><td align="right">0,080</td><td align="right">0,080</td><td align="right">0,080</td><td align="right">0,080</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 199,033 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5184,605 ns</td><td align="right" bgcolor="#FFFFFF">5124,287 ns (Δ = -60,318 ns)</td><td align="right" bgcolor="#FFFFFF">5237,538 ns (Δ = +113,252 ns)</td><td align="right" bgcolor="#FFFFFF">5149,280 ns (Δ = -88,258 ns)</td><td align="right" bgcolor="#FFFFFF">5306,047 ns (Δ = +156,767 ns)</td><td align="right" bgcolor="#FFFFFF">5323,320 ns (Δ = +17,273 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,185 μs</td><td align="right" bgcolor="#FFFFFF">5,124 μs (Δ = -0,060 μs)</td><td align="right" bgcolor="#FFFFFF">5,238 μs (Δ = +0,113 μs)</td><td align="right" bgcolor="#FFFFFF">5,149 μs (Δ = -0,088 μs)</td><td align="right" bgcolor="#FFFFFF">5,306 μs (Δ = +0,157 μs)</td><td align="right" bgcolor="#FFFFFF">5,323 μs (Δ = +0,017 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,005 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 195,742 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4327,558 ns</td><td align="right" bgcolor="#FFFFFF">4217,556 ns (Δ = -110,003 ns)</td><td align="right" bgcolor="#FFFFFF">4204,184 ns (Δ = -13,371 ns)</td><td align="right" bgcolor="#FF4949">4399,927 ns (Δ = +195,742 ns)</td><td align="right" bgcolor="#FFFFFF">4321,311 ns (Δ = -78,616 ns)</td><td align="right" bgcolor="#FFFFFF">4301,153 ns (Δ = -20,158 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,328 μs</td><td align="right" bgcolor="#FFFFFF">4,218 μs (Δ = -0,110 μs)</td><td align="right" bgcolor="#FFFFFF">4,204 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#FF4949">4,400 μs (Δ = +0,196 μs)</td><td align="right" bgcolor="#FFFFFF">4,321 μs (Δ = -0,079 μs)</td><td align="right" bgcolor="#FFFFFF">4,301 μs (Δ = -0,020 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td></tr>
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

Slowest: 5.0.0

Δ: 97,657 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">867,470 ns</td><td align="right" bgcolor="#A8D08D">836,900 ns (Δ = -30,570 ns)</td><td align="right" bgcolor="#FFFFFF">842,671 ns (Δ = +5,771 ns)</td><td align="right" bgcolor="#FF4949">930,140 ns (Δ = +87,469 ns)</td><td align="right" bgcolor="#A8D08D">845,553 ns (Δ = -84,587 ns)</td><td align="right" bgcolor="#FF4949">934,557 ns (Δ = +89,003 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,867 μs</td><td align="right" bgcolor="#A8D08D">0,837 μs (Δ = -0,031 μs)</td><td align="right" bgcolor="#FFFFFF">0,843 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FF4949">0,930 μs (Δ = +0,087 μs)</td><td align="right" bgcolor="#A8D08D">0,846 μs (Δ = -0,085 μs)</td><td align="right" bgcolor="#FF4949">0,935 μs (Δ = +0,089 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">82</td><td align="right">82</td><td align="right">82</td><td align="right">82</td><td align="right">82</td><td align="right">82</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,080</td><td align="right">0,080</td><td align="right">0,080</td><td align="right">0,080</td><td align="right">0,080</td><td align="right">0,080</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 771,103 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">782,380 ns</td><td align="right" bgcolor="#FFFFFF">785,822 ns (Δ = +3,442 ns)</td><td align="right" bgcolor="#FFFFFF">802,264 ns (Δ = +16,442 ns)</td><td align="right" bgcolor="#A8D08D">777,640 ns (Δ = -24,624 ns)</td><td align="right" bgcolor="#A8D08D">754,667 ns (Δ = -22,973 ns)</td><td align="right" bgcolor="#FF4949">1525,770 ns (Δ = +771,103 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,782 μs</td><td align="right" bgcolor="#FFFFFF">0,786 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,802 μs (Δ = +0,016 μs)</td><td align="right" bgcolor="#A8D08D">0,778 μs (Δ = -0,025 μs)</td><td align="right" bgcolor="#A8D08D">0,755 μs (Δ = -0,023 μs)</td><td align="right" bgcolor="#FF4949">1,526 μs (Δ = +0,771 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,001 ms)</td></tr>
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

Δ: 176,207 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">364,385 ns</td><td align="right" bgcolor="#FFFFFF">362,995 ns (Δ = -1,390 ns)</td><td align="right" bgcolor="#A8D08D">209,515 ns (Δ = -153,480 ns)</td><td align="right" bgcolor="#FFFFFF">208,364 ns (Δ = -1,151 ns)</td><td align="right" bgcolor="#FFFFFF">203,027 ns (Δ = -5,338 ns)</td><td align="right" bgcolor="#A8D08D">188,178 ns (Δ = -14,849 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,364 μs</td><td align="right" bgcolor="#FFFFFF">0,363 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,210 μs (Δ = -0,153 μs)</td><td align="right" bgcolor="#FFFFFF">0,208 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,203 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,188 μs (Δ = -0,015 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 192,868 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">370,001 ns</td><td align="right" bgcolor="#FFFFFF">365,867 ns (Δ = -4,135 ns)</td><td align="right" bgcolor="#A8D08D">201,695 ns (Δ = -164,172 ns)</td><td align="right" bgcolor="#FF4949">207,951 ns (Δ = +6,256 ns)</td><td align="right" bgcolor="#FFFFFF">210,128 ns (Δ = +2,177 ns)</td><td align="right" bgcolor="#A8D08D">177,133 ns (Δ = -32,994 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,370 μs</td><td align="right" bgcolor="#FFFFFF">0,366 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,202 μs (Δ = -0,164 μs)</td><td align="right" bgcolor="#FF4949">0,208 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,210 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,177 μs (Δ = -0,033 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Δ: 493734,977 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">287670,631 ns</td><td align="right" bgcolor="#FFFFFF">282590,250 ns (Δ = -5080,381 ns)</td><td align="right" bgcolor="#FF4949">313316,858 ns (Δ = +30726,608 ns)</td><td align="right" bgcolor="#FFFFFF">315049,250 ns (Δ = +1732,392 ns)</td><td align="right" bgcolor="#FF4949">776325,227 ns (Δ = +461275,977 ns)</td><td align="right" bgcolor="#A8D08D">455910,153 ns (Δ = -320415,073 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">287,671 μs</td><td align="right" bgcolor="#FFFFFF">282,590 μs (Δ = -5,080 μs)</td><td align="right" bgcolor="#FF4949">313,317 μs (Δ = +30,727 μs)</td><td align="right" bgcolor="#FFFFFF">315,049 μs (Δ = +1,732 μs)</td><td align="right" bgcolor="#FF4949">776,325 μs (Δ = +461,276 μs)</td><td align="right" bgcolor="#A8D08D">455,910 μs (Δ = -320,415 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,288 ms</td><td align="right" bgcolor="#FFFFFF">0,283 ms (Δ = -0,005 ms)</td><td align="right" bgcolor="#FF4949">0,313 ms (Δ = +0,031 ms)</td><td align="right" bgcolor="#FFFFFF">0,315 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#FF4949">0,776 ms (Δ = +0,461 ms)</td><td align="right" bgcolor="#A8D08D">0,456 ms (Δ = -0,320 ms)</td></tr>
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
<td>Gen 0</td><td align="right">60</td><td align="right">60</td><td align="right">60</td><td align="right">60</td><td align="right">80</td><td align="right">10</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">10</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">80230</td><td align="right">80087</td><td align="right">81406</td><td align="right">85728</td><td align="right">110583</td><td align="right">27083</td><tr>
<td>Allocated Kilobytes</td><td align="right">78,350</td><td align="right">78,210</td><td align="right">79,498</td><td align="right">83,719</td><td align="right">107,991</td><td align="right">26,448</td><tr>
<td>Allocated Megabytes</td><td align="right">0,077</td><td align="right">0,076</td><td align="right">0,078</td><td align="right">0,082</td><td align="right">0,105</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 440103,422 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">59836,413 ns</td><td align="right" bgcolor="#FFFFFF">60434,660 ns (Δ = +598,247 ns)</td><td align="right" bgcolor="#FF4949">73976,813 ns (Δ = +13542,153 ns)</td><td align="right" bgcolor="#A8D08D">70903,193 ns (Δ = -3073,620 ns)</td><td align="right" bgcolor="#FF4949">499939,836 ns (Δ = +429036,642 ns)</td><td align="right" bgcolor="#A8D08D">459989,173 ns (Δ = -39950,662 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">59,836 μs</td><td align="right" bgcolor="#FFFFFF">60,435 μs (Δ = +0,598 μs)</td><td align="right" bgcolor="#FF4949">73,977 μs (Δ = +13,542 μs)</td><td align="right" bgcolor="#A8D08D">70,903 μs (Δ = -3,074 μs)</td><td align="right" bgcolor="#FF4949">499,940 μs (Δ = +429,037 μs)</td><td align="right" bgcolor="#A8D08D">459,989 μs (Δ = -39,951 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,060 ms</td><td align="right" bgcolor="#FFFFFF">0,060 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,074 ms (Δ = +0,014 ms)</td><td align="right" bgcolor="#A8D08D">0,071 ms (Δ = -0,003 ms)</td><td align="right" bgcolor="#FF4949">0,500 ms (Δ = +0,429 ms)</td><td align="right" bgcolor="#A8D08D">0,460 ms (Δ = -0,040 ms)</td></tr>
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
<td align="right">4.3.0</td>
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">10</td><td align="right">10</td><td align="right">10</td><td align="right">10</td><td align="right">20</td><td align="right">10</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">20022</td><td align="right">19940</td><td align="right">20284</td><td align="right">21579</td><td align="right">39117</td><td align="right">27083</td><tr>
<td>Allocated Kilobytes</td><td align="right">19,553</td><td align="right">19,473</td><td align="right">19,809</td><td align="right">21,073</td><td align="right">38,200</td><td align="right">26,448</td><tr>
<td>Allocated Megabytes</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,019</td><td align="right">0,021</td><td align="right">0,037</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 484747,009 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">201760,713 ns</td><td align="right" bgcolor="#FFFFFF">200454,791 ns (Δ = -1305,922 ns)</td><td align="right" bgcolor="#FF4949">206666,153 ns (Δ = +6211,362 ns)</td><td align="right" bgcolor="#FFFFFF">208132,613 ns (Δ = +1466,460 ns)</td><td align="right" bgcolor="#FF4949">685201,800 ns (Δ = +477069,187 ns)</td><td align="right" bgcolor="#A8D08D">459873,844 ns (Δ = -225327,956 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">201,761 μs</td><td align="right" bgcolor="#FFFFFF">200,455 μs (Δ = -1,306 μs)</td><td align="right" bgcolor="#FF4949">206,666 μs (Δ = +6,211 μs)</td><td align="right" bgcolor="#FFFFFF">208,133 μs (Δ = +1,466 μs)</td><td align="right" bgcolor="#FF4949">685,202 μs (Δ = +477,069 μs)</td><td align="right" bgcolor="#A8D08D">459,874 μs (Δ = -225,328 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,202 ms</td><td align="right" bgcolor="#FFFFFF">0,200 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,207 ms (Δ = +0,006 ms)</td><td align="right" bgcolor="#FFFFFF">0,208 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,685 ms (Δ = +0,477 ms)</td><td align="right" bgcolor="#A8D08D">0,460 ms (Δ = -0,225 ms)</td></tr>
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
<td>Gen 0</td><td align="right">40</td><td align="right">40</td><td align="right">40</td><td align="right">40</td><td align="right">60</td><td align="right">10</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">10</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">59393</td><td align="right">59245</td><td align="right">60589</td><td align="right">64973</td><td align="right">87739</td><td align="right">27083</td><tr>
<td>Allocated Kilobytes</td><td align="right">58,001</td><td align="right">57,856</td><td align="right">59,169</td><td align="right">63,450</td><td align="right">85,683</td><td align="right">26,448</td><tr>
<td>Allocated Megabytes</td><td align="right">0,057</td><td align="right">0,057</td><td align="right">0,058</td><td align="right">0,062</td><td align="right">0,084</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1106839,133 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">952701,351 ns</td><td align="right" bgcolor="#FFFFFF">943862,200 ns (Δ = -8839,151 ns)</td><td align="right" bgcolor="#FF4949">990350,182 ns (Δ = +46487,982 ns)</td><td align="right" bgcolor="#FF4949">1028817,018 ns (Δ = +38466,836 ns)</td><td align="right" bgcolor="#FF4949">1560903,813 ns (Δ = +532086,796 ns)</td><td align="right" bgcolor="#A8D08D">454064,680 ns (Δ = -1106839,133 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">952,701 μs</td><td align="right" bgcolor="#FFFFFF">943,862 μs (Δ = -8,839 μs)</td><td align="right" bgcolor="#FF4949">990,350 μs (Δ = +46,488 μs)</td><td align="right" bgcolor="#FF4949">1028,817 μs (Δ = +38,467 μs)</td><td align="right" bgcolor="#FF4949">1560,904 μs (Δ = +532,087 μs)</td><td align="right" bgcolor="#A8D08D">454,065 μs (Δ = -1106,839 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,953 ms</td><td align="right" bgcolor="#FFFFFF">0,944 ms (Δ = -0,009 ms)</td><td align="right" bgcolor="#FF4949">0,990 ms (Δ = +0,046 ms)</td><td align="right" bgcolor="#FF4949">1,029 ms (Δ = +0,038 ms)</td><td align="right" bgcolor="#FF4949">1,561 ms (Δ = +0,532 ms)</td><td align="right" bgcolor="#A8D08D">0,454 ms (Δ = -1,107 ms)</td></tr>
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
<td>Gen 0</td><td align="right">200</td><td align="right">200</td><td align="right">210</td><td align="right">220</td><td align="right">260</td><td align="right">10</td></tr>
<tr>
<td>Gen 1</td><td align="right">20</td><td align="right">20</td><td align="right">30</td><td align="right">30</td><td align="right">40</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">263133</td><td align="right">262617</td><td align="right">268909</td><td align="right">288617</td><td align="right">337025</td><td align="right">27083</td><tr>
<td>Allocated Kilobytes</td><td align="right">256,966</td><td align="right">256,462</td><td align="right">262,606</td><td align="right">281,853</td><td align="right">329,126</td><td align="right">26,448</td><tr>
<td>Allocated Megabytes</td><td align="right">0,251</td><td align="right">0,250</td><td align="right">0,256</td><td align="right">0,275</td><td align="right">0,321</td><td align="right">0,026</td></tr>
</table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 18771760,435 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18203549,344 ns</td><td align="right" bgcolor="#FFFFFF">18482967,845 ns (Δ = +279418,501 ns)</td><td align="right" bgcolor="#FFFFFF">18412071,258 ns (Δ = -70896,587 ns)</td><td align="right" bgcolor="#FFFFFF">18330123,700 ns (Δ = -81947,558 ns)</td><td align="right" bgcolor="#FF4949">19233915,700 ns (Δ = +903792,000 ns)</td><td align="right" bgcolor="#A8D08D">462155,265 ns (Δ = -18771760,435 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">18203,549 μs</td><td align="right" bgcolor="#FFFFFF">18482,968 μs (Δ = +279,419 μs)</td><td align="right" bgcolor="#FFFFFF">18412,071 μs (Δ = -70,897 μs)</td><td align="right" bgcolor="#FFFFFF">18330,124 μs (Δ = -81,948 μs)</td><td align="right" bgcolor="#FF4949">19233,916 μs (Δ = +903,792 μs)</td><td align="right" bgcolor="#A8D08D">462,155 μs (Δ = -18771,760 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">18,204 ms</td><td align="right" bgcolor="#FFFFFF">18,483 ms (Δ = +0,279 ms)</td><td align="right" bgcolor="#FFFFFF">18,412 ms (Δ = -0,071 ms)</td><td align="right" bgcolor="#FFFFFF">18,330 ms (Δ = -0,082 ms)</td><td align="right" bgcolor="#FF4949">19,234 ms (Δ = +0,904 ms)</td><td align="right" bgcolor="#A8D08D">0,462 ms (Δ = -18,772 ms)</td></tr>
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
<td>Gen 0</td><td align="right">1130</td><td align="right">1130</td><td align="right">1140</td><td align="right">1170</td><td align="right">1231</td><td align="right">10</td></tr>
<tr>
<td>Gen 1</td><td align="right">370</td><td align="right">370</td><td align="right">380</td><td align="right">390</td><td align="right">410</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1427878</td><td align="right">1428036</td><td align="right">1446913</td><td align="right">1486354</td><td align="right">1563043</td><td align="right">27564</td><tr>
<td>Allocated Kilobytes</td><td align="right">1394,412</td><td align="right">1394,566</td><td align="right">1413,001</td><td align="right">1451,518</td><td align="right">1526,409</td><td align="right">26,918</td><tr>
<td>Allocated Megabytes</td><td align="right">1,362</td><td align="right">1,362</td><td align="right">1,380</td><td align="right">1,417</td><td align="right">1,491</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 793631,678 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">759267,783 ns</td><td align="right" bgcolor="#FFFFFF">778678,325 ns (Δ = +19410,542 ns)</td><td align="right" bgcolor="#FFFFFF">782162,687 ns (Δ = +3484,362 ns)</td><td align="right" bgcolor="#FFFFFF">765738,201 ns (Δ = -16424,485 ns)</td><td align="right" bgcolor="#FF4949">1236604,308 ns (Δ = +470866,107 ns)</td><td align="right" bgcolor="#A8D08D">442972,630 ns (Δ = -793631,678 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">759,268 μs</td><td align="right" bgcolor="#FFFFFF">778,678 μs (Δ = +19,411 μs)</td><td align="right" bgcolor="#FFFFFF">782,163 μs (Δ = +3,484 μs)</td><td align="right" bgcolor="#FFFFFF">765,738 μs (Δ = -16,424 μs)</td><td align="right" bgcolor="#FF4949">1236,604 μs (Δ = +470,866 μs)</td><td align="right" bgcolor="#A8D08D">442,973 μs (Δ = -793,632 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,759 ms</td><td align="right" bgcolor="#FFFFFF">0,779 ms (Δ = +0,019 ms)</td><td align="right" bgcolor="#FFFFFF">0,782 ms (Δ = +0,003 ms)</td><td align="right" bgcolor="#FFFFFF">0,766 ms (Δ = -0,016 ms)</td><td align="right" bgcolor="#FF4949">1,237 ms (Δ = +0,471 ms)</td><td align="right" bgcolor="#A8D08D">0,443 ms (Δ = -0,794 ms)</td></tr>
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
<td>Gen 0</td><td align="right">50</td><td align="right">50</td><td align="right">50</td><td align="right">50</td><td align="right">60</td><td align="right">10</td></tr>
<tr>
<td>Gen 1</td><td align="right">10</td><td align="right">10</td><td align="right">10</td><td align="right">10</td><td align="right">20</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">66696</td><td align="right">66651</td><td align="right">67376</td><td align="right">69721</td><td align="right">87361</td><td align="right">27564</td><tr>
<td>Allocated Kilobytes</td><td align="right">65,133</td><td align="right">65,089</td><td align="right">65,797</td><td align="right">68,087</td><td align="right">85,313</td><td align="right">26,918</td><tr>
<td>Allocated Megabytes</td><td align="right">0,064</td><td align="right">0,064</td><td align="right">0,064</td><td align="right">0,066</td><td align="right">0,083</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 3096864,057 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3010682,693 ns</td><td align="right" bgcolor="#FFFFFF">3098901,844 ns (Δ = +88219,151 ns)</td><td align="right" bgcolor="#FFFFFF">3086188,493 ns (Δ = -12713,352 ns)</td><td align="right" bgcolor="#FFFFFF">3032717,282 ns (Δ = -53471,211 ns)</td><td align="right" bgcolor="#FF4949">3544133,253 ns (Δ = +511415,971 ns)</td><td align="right" bgcolor="#A8D08D">447269,196 ns (Δ = -3096864,057 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3010,683 μs</td><td align="right" bgcolor="#FFFFFF">3098,902 μs (Δ = +88,219 μs)</td><td align="right" bgcolor="#FFFFFF">3086,188 μs (Δ = -12,713 μs)</td><td align="right" bgcolor="#FFFFFF">3032,717 μs (Δ = -53,471 μs)</td><td align="right" bgcolor="#FF4949">3544,133 μs (Δ = +511,416 μs)</td><td align="right" bgcolor="#A8D08D">447,269 μs (Δ = -3096,864 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,011 ms</td><td align="right" bgcolor="#FFFFFF">3,099 ms (Δ = +0,088 ms)</td><td align="right" bgcolor="#FFFFFF">3,086 ms (Δ = -0,013 ms)</td><td align="right" bgcolor="#FFFFFF">3,033 ms (Δ = -0,053 ms)</td><td align="right" bgcolor="#FF4949">3,544 ms (Δ = +0,511 ms)</td><td align="right" bgcolor="#A8D08D">0,447 ms (Δ = -3,097 ms)</td></tr>
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
<td align="right">4.3.0</td>
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
<td>Gen 0</td><td align="right">190</td><td align="right">190</td><td align="right">190</td><td align="right">200</td><td align="right">220</td><td align="right">10</td></tr>
<tr>
<td>Gen 1</td><td align="right">50</td><td align="right">60</td><td align="right">56</td><td align="right">60</td><td align="right">50</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">245747</td><td align="right">245845</td><td align="right">249843</td><td align="right">257395</td><td align="right">282989</td><td align="right">27564</td><tr>
<td>Allocated Kilobytes</td><td align="right">239,987</td><td align="right">240,083</td><td align="right">243,987</td><td align="right">251,362</td><td align="right">276,356</td><td align="right">26,918</td><tr>
<td>Allocated Megabytes</td><td align="right">0,234</td><td align="right">0,234</td><td align="right">0,238</td><td align="right">0,245</td><td align="right">0,270</td><td align="right">0,026</td></tr>
</table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 14732898,377 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14295873,245 ns</td><td align="right" bgcolor="#FFFFFF">14279777,111 ns (Δ = -16096,134 ns)</td><td align="right" bgcolor="#FFFFFF">14345431,367 ns (Δ = +65654,256 ns)</td><td align="right" bgcolor="#FFFFFF">14342003,357 ns (Δ = -3428,010 ns)</td><td align="right" bgcolor="#FF4949">15171695,810 ns (Δ = +829692,453 ns)</td><td align="right" bgcolor="#A8D08D">438797,433 ns (Δ = -14732898,377 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14295,873 μs</td><td align="right" bgcolor="#FFFFFF">14279,777 μs (Δ = -16,096 μs)</td><td align="right" bgcolor="#FFFFFF">14345,431 μs (Δ = +65,654 μs)</td><td align="right" bgcolor="#FFFFFF">14342,003 μs (Δ = -3,428 μs)</td><td align="right" bgcolor="#FF4949">15171,696 μs (Δ = +829,692 μs)</td><td align="right" bgcolor="#A8D08D">438,797 μs (Δ = -14732,898 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">14,296 ms</td><td align="right" bgcolor="#FFFFFF">14,280 ms (Δ = -0,016 ms)</td><td align="right" bgcolor="#FFFFFF">14,345 ms (Δ = +0,066 ms)</td><td align="right" bgcolor="#FFFFFF">14,342 ms (Δ = -0,003 ms)</td><td align="right" bgcolor="#FF4949">15,172 ms (Δ = +0,830 ms)</td><td align="right" bgcolor="#A8D08D">0,439 ms (Δ = -14,733 ms)</td></tr>
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
<td align="right">4.5.4</td>
</tr>
</table>

<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Gen 0</td><td align="right">900</td><td align="right">900</td><td align="right">920</td><td align="right">950</td><td align="right">1000</td><td align="right">10</td></tr>
<tr>
<td>Gen 1</td><td align="right">290</td><td align="right">252</td><td align="right">260</td><td align="right">250</td><td align="right">288</td><td align="right">0</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1145337</td><td align="right">1142511</td><td align="right">1161516</td><td align="right">1199337</td><td align="right">1265496</td><td align="right">27564</td><tr>
<td>Allocated Kilobytes</td><td align="right">1118,493</td><td align="right">1115,733</td><td align="right">1134,293</td><td align="right">1171,228</td><td align="right">1235,836</td><td align="right">26,918</td><tr>
<td>Allocated Megabytes</td><td align="right">1,092</td><td align="right">1,090</td><td align="right">1,108</td><td align="right">1,144</td><td align="right">1,207</td><td align="right">0,026</td></tr>
</table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1039728,660 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">758712,863 ns</td><td align="right" bgcolor="#FFFFFF">758319,173 ns (Δ = -393,689 ns)</td><td align="right" bgcolor="#FF4949">917913,611 ns (Δ = +159594,438 ns)</td><td align="right" bgcolor="#FF4949">950096,300 ns (Δ = +32182,689 ns)</td><td align="right" bgcolor="#FF4949">1497736,110 ns (Δ = +547639,810 ns)</td><td align="right" bgcolor="#A8D08D">458007,450 ns (Δ = -1039728,660 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">758,713 μs</td><td align="right" bgcolor="#FFFFFF">758,319 μs (Δ = -0,394 μs)</td><td align="right" bgcolor="#FF4949">917,914 μs (Δ = +159,594 μs)</td><td align="right" bgcolor="#FF4949">950,096 μs (Δ = +32,183 μs)</td><td align="right" bgcolor="#FF4949">1497,736 μs (Δ = +547,640 μs)</td><td align="right" bgcolor="#A8D08D">458,007 μs (Δ = -1039,729 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,759 ms</td><td align="right" bgcolor="#FFFFFF">0,758 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,918 ms (Δ = +0,160 ms)</td><td align="right" bgcolor="#FF4949">0,950 ms (Δ = +0,032 ms)</td><td align="right" bgcolor="#FF4949">1,498 ms (Δ = +0,548 ms)</td><td align="right" bgcolor="#A8D08D">0,458 ms (Δ = -1,040 ms)</td></tr>
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
<td>Gen 0</td><td align="right">420</td><td align="right">420</td><td align="right">430</td><td align="right">440</td><td align="right">460</td><td align="right">20</td></tr>
<tr>
<td>Gen 1</td><td align="right">60</td><td align="right">60</td><td align="right">60</td><td align="right">60</td><td align="right">74</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">544336</td><td align="right">544219</td><td align="right">550102</td><td align="right">559315</td><td align="right">586989</td><td align="right">29278</td><tr>
<td>Allocated Kilobytes</td><td align="right">531,578</td><td align="right">531,464</td><td align="right">537,209</td><td align="right">546,206</td><td align="right">573,231</td><td align="right">28,592</td><tr>
<td>Allocated Megabytes</td><td align="right">0,519</td><td align="right">0,519</td><td align="right">0,525</td><td align="right">0,533</td><td align="right">0,560</td><td align="right">0,028</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 500880,211 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">99302,687 ns</td><td align="right" bgcolor="#FF4949">124905,533 ns (Δ = +25602,847 ns)</td><td align="right" bgcolor="#FF4949">151203,827 ns (Δ = +26298,293 ns)</td><td align="right" bgcolor="#FF4949">158455,502 ns (Δ = +7251,676 ns)</td><td align="right" bgcolor="#FF4949">600182,898 ns (Δ = +441727,396 ns)</td><td align="right" bgcolor="#A8D08D">450380,759 ns (Δ = -149802,138 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">99,303 μs</td><td align="right" bgcolor="#FF4949">124,906 μs (Δ = +25,603 μs)</td><td align="right" bgcolor="#FF4949">151,204 μs (Δ = +26,298 μs)</td><td align="right" bgcolor="#FF4949">158,456 μs (Δ = +7,252 μs)</td><td align="right" bgcolor="#FF4949">600,183 μs (Δ = +441,727 μs)</td><td align="right" bgcolor="#A8D08D">450,381 μs (Δ = -149,802 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,099 ms</td><td align="right" bgcolor="#FF4949">0,125 ms (Δ = +0,026 ms)</td><td align="right" bgcolor="#FF4949">0,151 ms (Δ = +0,026 ms)</td><td align="right" bgcolor="#FF4949">0,158 ms (Δ = +0,007 ms)</td><td align="right" bgcolor="#FF4949">0,600 ms (Δ = +0,442 ms)</td><td align="right" bgcolor="#A8D08D">0,450 ms (Δ = -0,150 ms)</td></tr>
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
<td>Gen 0</td><td align="right">80</td><td align="right">80</td><td align="right">90</td><td align="right">90</td><td align="right">100</td><td align="right">20</td></tr>
<tr>
<td>Gen 1</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">10</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">115957</td><td align="right">115905</td><td align="right">117564</td><td align="right">120568</td><td align="right">138422</td><td align="right">29278</td><tr>
<td>Allocated Kilobytes</td><td align="right">113,239</td><td align="right">113,188</td><td align="right">114,809</td><td align="right">117,742</td><td align="right">135,178</td><td align="right">28,592</td><tr>
<td>Allocated Megabytes</td><td align="right">0,111</td><td align="right">0,111</td><td align="right">0,112</td><td align="right">0,115</td><td align="right">0,132</td><td align="right">0,028</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 696038,253 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">334032,280 ns</td><td align="right" bgcolor="#FF4949">350997,407 ns (Δ = +16965,127 ns)</td><td align="right" bgcolor="#FF4949">503316,207 ns (Δ = +152318,800 ns)</td><td align="right" bgcolor="#FF4949">574385,350 ns (Δ = +71069,143 ns)</td><td align="right" bgcolor="#FF4949">1030070,533 ns (Δ = +455685,183 ns)</td><td align="right" bgcolor="#A8D08D">452560,556 ns (Δ = -577509,978 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">334,032 μs</td><td align="right" bgcolor="#FF4949">350,997 μs (Δ = +16,965 μs)</td><td align="right" bgcolor="#FF4949">503,316 μs (Δ = +152,319 μs)</td><td align="right" bgcolor="#FF4949">574,385 μs (Δ = +71,069 μs)</td><td align="right" bgcolor="#FF4949">1030,071 μs (Δ = +455,685 μs)</td><td align="right" bgcolor="#A8D08D">452,561 μs (Δ = -577,510 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,334 ms</td><td align="right" bgcolor="#FF4949">0,351 ms (Δ = +0,017 ms)</td><td align="right" bgcolor="#FF4949">0,503 ms (Δ = +0,152 ms)</td><td align="right" bgcolor="#FF4949">0,574 ms (Δ = +0,071 ms)</td><td align="right" bgcolor="#FF4949">1,030 ms (Δ = +0,456 ms)</td><td align="right" bgcolor="#A8D08D">0,453 ms (Δ = -0,578 ms)</td></tr>
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
<td>Gen 0</td><td align="right">310</td><td align="right">310</td><td align="right">310</td><td align="right">320</td><td align="right">340</td><td align="right">20</td></tr>
<tr>
<td>Gen 1</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">20</td><td align="right">40</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">396439</td><td align="right">396247</td><td align="right">402210</td><td align="right">411957</td><td align="right">437238</td><td align="right">29278</td><tr>
<td>Allocated Kilobytes</td><td align="right">387,147</td><td align="right">386,960</td><td align="right">392,783</td><td align="right">402,302</td><td align="right">426,990</td><td align="right">28,592</td><tr>
<td>Allocated Megabytes</td><td align="right">0,378</td><td align="right">0,378</td><td align="right">0,384</td><td align="right">0,393</td><td align="right">0,417</td><td align="right">0,028</td></tr>
</table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2718594,058 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1610026,773 ns</td><td align="right" bgcolor="#FFFFFF">1632443,764 ns (Δ = +22416,991 ns)</td><td align="right" bgcolor="#FF4949">2340453,127 ns (Δ = +708009,362 ns)</td><td align="right" bgcolor="#FF4949">2449298,201 ns (Δ = +108845,075 ns)</td><td align="right" bgcolor="#FF4949">3171858,027 ns (Δ = +722559,825 ns)</td><td align="right" bgcolor="#A8D08D">453263,969 ns (Δ = -2718594,058 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1610,027 μs</td><td align="right" bgcolor="#FFFFFF">1632,444 μs (Δ = +22,417 μs)</td><td align="right" bgcolor="#FF4949">2340,453 μs (Δ = +708,009 μs)</td><td align="right" bgcolor="#FF4949">2449,298 μs (Δ = +108,845 μs)</td><td align="right" bgcolor="#FF4949">3171,858 μs (Δ = +722,560 μs)</td><td align="right" bgcolor="#A8D08D">453,264 μs (Δ = -2718,594 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,610 ms</td><td align="right" bgcolor="#FFFFFF">1,632 ms (Δ = +0,022 ms)</td><td align="right" bgcolor="#FF4949">2,340 ms (Δ = +0,708 ms)</td><td align="right" bgcolor="#FF4949">2,449 ms (Δ = +0,109 ms)</td><td align="right" bgcolor="#FF4949">3,172 ms (Δ = +0,723 ms)</td><td align="right" bgcolor="#A8D08D">0,453 ms (Δ = -2,719 ms)</td></tr>
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
<td>Gen 0</td><td align="right">1420</td><td align="right">1420</td><td align="right">1440</td><td align="right">1480</td><td align="right">1530</td><td align="right">20</td></tr>
<tr>
<td>Gen 1</td><td align="right">230</td><td align="right">230</td><td align="right">230</td><td align="right">239</td><td align="right">250</td><td align="right">10</td></tr>
<tr>
<td>Gen 2</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><td align="right">0</td><tr>
<td>Allocated Bytes</td><td align="right">1799884</td><td align="right">1799752</td><td align="right">1825959</td><td align="right">1868266</td><td align="right">1929995</td><td align="right">29278</td><tr>
<td>Allocated Kilobytes</td><td align="right">1757,699</td><td align="right">1757,570</td><td align="right">1783,163</td><td align="right">1824,479</td><td align="right">1884,761</td><td align="right">28,592</td><tr>
<td>Allocated Megabytes</td><td align="right">1,717</td><td align="right">1,716</td><td align="right">1,741</td><td align="right">1,782</td><td align="right">1,841</td><td align="right">0,028</td></tr>
</table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **4.5.0**

Slowest: 4.4.0

Δ: 1845,260 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2773,249 ns</td><td align="right" bgcolor="#A8D08D">2507,860 ns (Δ = -265,389 ns)</td><td align="right" bgcolor="#FF4949">2816,247 ns (Δ = +308,387 ns)</td><td align="right" bgcolor="#A8D08D">970,987 ns (Δ = -1845,260 ns)</td><td align="right" bgcolor="#FF4949">1167,977 ns (Δ = +196,990 ns)</td><td align="right" bgcolor="#A8D08D">1028,760 ns (Δ = -139,217 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,773 μs</td><td align="right" bgcolor="#A8D08D">2,508 μs (Δ = -0,265 μs)</td><td align="right" bgcolor="#FF4949">2,816 μs (Δ = +0,308 μs)</td><td align="right" bgcolor="#A8D08D">0,971 μs (Δ = -1,845 μs)</td><td align="right" bgcolor="#FF4949">1,168 μs (Δ = +0,197 μs)</td><td align="right" bgcolor="#A8D08D">1,029 μs (Δ = -0,139 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">1098</td><td align="right">1098</td><td align="right">1098</td><td align="right">1049</td><td align="right">1049</td><td align="right">1016</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,072</td><td align="right">1,072</td><td align="right">1,072</td><td align="right">1,024</td><td align="right">1,024</td><td align="right">0,992</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 9,970 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">207,988 ns</td><td align="right" bgcolor="#FFFFFF">205,397 ns (Δ = -2,592 ns)</td><td align="right" bgcolor="#FFFFFF">204,910 ns (Δ = -0,487 ns)</td><td align="right" bgcolor="#FFFFFF">207,876 ns (Δ = +2,966 ns)</td><td align="right" bgcolor="#FFFFFF">209,430 ns (Δ = +1,554 ns)</td><td align="right" bgcolor="#A8D08D">199,460 ns (Δ = -9,970 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,205 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,208 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,209 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,199 μs (Δ = -0,010 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 705,725 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3364,780 ns</td><td align="right" bgcolor="#A8D08D">3223,880 ns (Δ = -140,900 ns)</td><td align="right" bgcolor="#FFFFFF">3133,473 ns (Δ = -90,407 ns)</td><td align="right" bgcolor="#FF4949">3729,716 ns (Δ = +596,243 ns)</td><td align="right" bgcolor="#FFFFFF">3698,358 ns (Δ = -31,357 ns)</td><td align="right" bgcolor="#FF4949">3839,198 ns (Δ = +140,840 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,365 μs</td><td align="right" bgcolor="#A8D08D">3,224 μs (Δ = -0,141 μs)</td><td align="right" bgcolor="#FFFFFF">3,133 μs (Δ = -0,090 μs)</td><td align="right" bgcolor="#FF4949">3,730 μs (Δ = +0,596 μs)</td><td align="right" bgcolor="#FFFFFF">3,698 μs (Δ = -0,031 μs)</td><td align="right" bgcolor="#FF4949">3,839 μs (Δ = +0,141 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">1242</td><td align="right">1209</td><td align="right">1209</td><td align="right">1439</td><td align="right">1439</td><td align="right">1455</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,213</td><td align="right">1,181</td><td align="right">1,181</td><td align="right">1,405</td><td align="right">1,405</td><td align="right">1,421</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 15,914 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">211,040 ns</td><td align="right" bgcolor="#FFFFFF">215,976 ns (Δ = +4,936 ns)</td><td align="right" bgcolor="#A8D08D">206,667 ns (Δ = -9,309 ns)</td><td align="right" bgcolor="#FFFFFF">204,200 ns (Δ = -2,467 ns)</td><td align="right" bgcolor="#FF4949">212,378 ns (Δ = +8,178 ns)</td><td align="right" bgcolor="#A8D08D">200,062 ns (Δ = -12,316 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,216 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,207 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FFFFFF">0,204 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,212 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#A8D08D">0,200 μs (Δ = -0,012 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 1445,724 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8907,858 ns</td><td align="right" bgcolor="#A8D08D">7659,572 ns (Δ = -1248,286 ns)</td><td align="right" bgcolor="#FF4949">8345,120 ns (Δ = +685,548 ns)</td><td align="right" bgcolor="#FFFFFF">8586,893 ns (Δ = +241,773 ns)</td><td align="right" bgcolor="#FFFFFF">8817,320 ns (Δ = +230,427 ns)</td><td align="right" bgcolor="#A8D08D">7462,133 ns (Δ = -1355,187 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,908 μs</td><td align="right" bgcolor="#A8D08D">7,660 μs (Δ = -1,248 μs)</td><td align="right" bgcolor="#FF4949">8,345 μs (Δ = +0,686 μs)</td><td align="right" bgcolor="#FFFFFF">8,587 μs (Δ = +0,242 μs)</td><td align="right" bgcolor="#FFFFFF">8,817 μs (Δ = +0,230 μs)</td><td align="right" bgcolor="#A8D08D">7,462 μs (Δ = -1,355 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#A8D08D">0,008 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,008 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,007 ms (Δ = -0,001 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">2782</td><td align="right">2732</td><td align="right">2732</td><td align="right">3191</td><td align="right">3191</td><td align="right">3044</td><tr>
<td>Allocated Kilobytes</td><td align="right">2,717</td><td align="right">2,668</td><td align="right">2,668</td><td align="right">3,116</td><td align="right">3,116</td><td align="right">2,973</td><tr>
<td>Allocated Megabytes</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td></tr>
</table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 3,779 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31,789 ns</td><td align="right" bgcolor="#A8D08D">29,048 ns (Δ = -2,741 ns)</td><td align="right" bgcolor="#FFFFFF">29,716 ns (Δ = +0,668 ns)</td><td align="right" bgcolor="#FFFFFF">29,680 ns (Δ = -0,036 ns)</td><td align="right" bgcolor="#A8D08D">28,769 ns (Δ = -0,911 ns)</td><td align="right" bgcolor="#FFFFFF">28,010 ns (Δ = -0,759 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#A8D08D">0,029 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,030 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,030 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,029 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,028 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Δ: 1,020 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,111 ns</td><td align="right" bgcolor="#FFFFFF">22,760 ns (Δ = +0,649 ns)</td><td align="right" bgcolor="#A8D08D">21,893 ns (Δ = -0,867 ns)</td><td align="right" bgcolor="#FFFFFF">22,407 ns (Δ = +0,513 ns)</td><td align="right" bgcolor="#A8D08D">21,740 ns (Δ = -0,667 ns)</td><td align="right" bgcolor="#FF4949">22,653 ns (Δ = +0,913 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,022 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,022 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,023 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 2,913 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,827 ns</td><td align="right" bgcolor="#A8D08D">25,501 ns (Δ = -1,326 ns)</td><td align="right" bgcolor="#FFFFFF">25,810 ns (Δ = +0,309 ns)</td><td align="right" bgcolor="#A8D08D">24,947 ns (Δ = -0,863 ns)</td><td align="right" bgcolor="#FFFFFF">24,719 ns (Δ = -0,228 ns)</td><td align="right" bgcolor="#A8D08D">23,913 ns (Δ = -0,806 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#A8D08D">0,026 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,026 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,025 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,025 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,024 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 0,585 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">33,170 ns</td><td align="right" bgcolor="#FFFFFF">33,744 ns (Δ = +0,574 ns)</td><td align="right" bgcolor="#FFFFFF">33,356 ns (Δ = -0,388 ns)</td><td align="right" bgcolor="#FFFFFF">33,428 ns (Δ = +0,072 ns)</td><td align="right" bgcolor="#FFFFFF">33,159 ns (Δ = -0,269 ns)</td><td align="right" bgcolor="#FFFFFF">33,273 ns (Δ = +0,114 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,033 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,033 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,033 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,033 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 17,358 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">331,480 ns</td><td align="right" bgcolor="#FFFFFF">341,520 ns (Δ = +10,040 ns)</td><td align="right" bgcolor="#A8D08D">329,916 ns (Δ = -11,604 ns)</td><td align="right" bgcolor="#FF4949">343,213 ns (Δ = +13,298 ns)</td><td align="right" bgcolor="#FFFFFF">336,173 ns (Δ = -7,040 ns)</td><td align="right" bgcolor="#FF4949">347,273 ns (Δ = +11,100 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,331 μs</td><td align="right" bgcolor="#FFFFFF">0,342 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#A8D08D">0,330 μs (Δ = -0,012 μs)</td><td align="right" bgcolor="#FF4949">0,343 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#FFFFFF">0,336 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FF4949">0,347 μs (Δ = +0,011 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 30,288 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">110,547 ns</td><td align="right" bgcolor="#FF4949">137,560 ns (Δ = +27,013 ns)</td><td align="right" bgcolor="#A8D08D">112,329 ns (Δ = -25,231 ns)</td><td align="right" bgcolor="#FFFFFF">113,503 ns (Δ = +1,174 ns)</td><td align="right" bgcolor="#A8D08D">109,169 ns (Δ = -4,333 ns)</td><td align="right" bgcolor="#FFFFFF">107,272 ns (Δ = -1,898 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td><td align="right" bgcolor="#FF4949">0,138 μs (Δ = +0,027 μs)</td><td align="right" bgcolor="#A8D08D">0,112 μs (Δ = -0,025 μs)</td><td align="right" bgcolor="#FFFFFF">0,114 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,109 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,107 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 327,822 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3800,468 ns</td><td align="right" bgcolor="#FFFFFF">3754,421 ns (Δ = -46,047 ns)</td><td align="right" bgcolor="#FF4949">3978,502 ns (Δ = +224,081 ns)</td><td align="right" bgcolor="#FFFFFF">3984,607 ns (Δ = +6,104 ns)</td><td align="right" bgcolor="#A8D08D">3719,111 ns (Δ = -265,496 ns)</td><td align="right" bgcolor="#FFFFFF">3656,785 ns (Δ = -62,326 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,800 μs</td><td align="right" bgcolor="#FFFFFF">3,754 μs (Δ = -0,046 μs)</td><td align="right" bgcolor="#FF4949">3,979 μs (Δ = +0,224 μs)</td><td align="right" bgcolor="#FFFFFF">3,985 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#A8D08D">3,719 μs (Δ = -0,265 μs)</td><td align="right" bgcolor="#FFFFFF">3,657 μs (Δ = -0,062 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.3.0**

Slowest: 5.0.0

Δ: 811,213 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8866,475 ns</td><td align="right" bgcolor="#FFFFFF">8711,047 ns (Δ = -155,429 ns)</td><td align="right" bgcolor="#FF4949">9068,053 ns (Δ = +357,007 ns)</td><td align="right" bgcolor="#FFFFFF">8850,208 ns (Δ = -217,845 ns)</td><td align="right" bgcolor="#FFFFFF">8826,660 ns (Δ = -23,548 ns)</td><td align="right" bgcolor="#FF4949">9522,260 ns (Δ = +695,600 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,866 μs</td><td align="right" bgcolor="#FFFFFF">8,711 μs (Δ = -0,155 μs)</td><td align="right" bgcolor="#FF4949">9,068 μs (Δ = +0,357 μs)</td><td align="right" bgcolor="#FFFFFF">8,850 μs (Δ = -0,218 μs)</td><td align="right" bgcolor="#FFFFFF">8,827 μs (Δ = -0,024 μs)</td><td align="right" bgcolor="#FF4949">9,522 μs (Δ = +0,696 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,010 ms (Δ = +0,001 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><td align="right">819</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,800</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.2.0**

Slowest: 4.3.0

Δ: 337,413 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3674,733 ns</td><td align="right" bgcolor="#FF4949">4012,147 ns (Δ = +337,413 ns)</td><td align="right" bgcolor="#A8D08D">3687,213 ns (Δ = -324,933 ns)</td><td align="right" bgcolor="#FFFFFF">3705,632 ns (Δ = +18,418 ns)</td><td align="right" bgcolor="#FFFFFF">3736,143 ns (Δ = +30,511 ns)</td><td align="right" bgcolor="#FF4949">3914,075 ns (Δ = +177,932 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,675 μs</td><td align="right" bgcolor="#FF4949">4,012 μs (Δ = +0,337 μs)</td><td align="right" bgcolor="#A8D08D">3,687 μs (Δ = -0,325 μs)</td><td align="right" bgcolor="#FFFFFF">3,706 μs (Δ = +0,018 μs)</td><td align="right" bgcolor="#FFFFFF">3,736 μs (Δ = +0,031 μs)</td><td align="right" bgcolor="#FF4949">3,914 μs (Δ = +0,178 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,004 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 702,297 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8789,380 ns</td><td align="right" bgcolor="#FFFFFF">8782,407 ns (Δ = -6,973 ns)</td><td align="right" bgcolor="#FFFFFF">8663,409 ns (Δ = -118,997 ns)</td><td align="right" bgcolor="#FF4949">8970,067 ns (Δ = +306,657 ns)</td><td align="right" bgcolor="#FFFFFF">8716,193 ns (Δ = -253,873 ns)</td><td align="right" bgcolor="#FF4949">9365,707 ns (Δ = +649,513 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,789 μs</td><td align="right" bgcolor="#FFFFFF">8,782 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FFFFFF">8,663 μs (Δ = -0,119 μs)</td><td align="right" bgcolor="#FF4949">8,970 μs (Δ = +0,307 μs)</td><td align="right" bgcolor="#FFFFFF">8,716 μs (Δ = -0,254 μs)</td><td align="right" bgcolor="#FF4949">9,366 μs (Δ = +0,650 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,009 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,009 ms (Δ = +0,001 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><td align="right">770</td><td align="right">819</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,752</td><td align="right">0,800</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 1,379 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,548 ns</td><td align="right" bgcolor="#FF4949">9,940 ns (Δ = +0,393 ns)</td><td align="right" bgcolor="#A8D08D">9,193 ns (Δ = -0,747 ns)</td><td align="right" bgcolor="#FF4949">9,887 ns (Δ = +0,693 ns)</td><td align="right" bgcolor="#A8D08D">8,561 ns (Δ = -1,326 ns)</td><td align="right" bgcolor="#FF4949">9,293 ns (Δ = +0,732 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FF4949">0,010 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,009 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,010 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,009 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,009 μs (Δ = +0,001 μs)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 24,972 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">742,493 ns</td><td align="right" bgcolor="#FFFFFF">746,051 ns (Δ = +3,558 ns)</td><td align="right" bgcolor="#FFFFFF">750,432 ns (Δ = +4,381 ns)</td><td align="right" bgcolor="#FFFFFF">744,303 ns (Δ = -6,128 ns)</td><td align="right" bgcolor="#FFFFFF">741,913 ns (Δ = -2,390 ns)</td><td align="right" bgcolor="#FFFFFF">725,460 ns (Δ = -16,453 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,742 μs</td><td align="right" bgcolor="#FFFFFF">0,746 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,750 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,744 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,742 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,725 μs (Δ = -0,016 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 18,049 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">186,648 ns</td><td align="right" bgcolor="#FFFFFF">187,405 ns (Δ = +0,757 ns)</td><td align="right" bgcolor="#FFFFFF">189,195 ns (Δ = +1,790 ns)</td><td align="right" bgcolor="#FFFFFF">189,870 ns (Δ = +0,675 ns)</td><td align="right" bgcolor="#A8D08D">179,124 ns (Δ = -10,746 ns)</td><td align="right" bgcolor="#FF4949">197,173 ns (Δ = +18,049 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,187 μs</td><td align="right" bgcolor="#FFFFFF">0,187 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,189 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,190 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,179 μs (Δ = -0,011 μs)</td><td align="right" bgcolor="#FF4949">0,197 μs (Δ = +0,018 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 1088,890 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2997,864 ns</td><td align="right" bgcolor="#FF4949">3663,470 ns (Δ = +665,606 ns)</td><td align="right" bgcolor="#A8D08D">2998,980 ns (Δ = -664,490 ns)</td><td align="right" bgcolor="#FFFFFF">3069,089 ns (Δ = +70,109 ns)</td><td align="right" bgcolor="#FFFFFF">2987,335 ns (Δ = -81,754 ns)</td><td align="right" bgcolor="#A8D08D">2574,580 ns (Δ = -412,755 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,998 μs</td><td align="right" bgcolor="#FF4949">3,663 μs (Δ = +0,666 μs)</td><td align="right" bgcolor="#A8D08D">2,999 μs (Δ = -0,664 μs)</td><td align="right" bgcolor="#FFFFFF">3,069 μs (Δ = +0,070 μs)</td><td align="right" bgcolor="#FFFFFF">2,987 μs (Δ = -0,082 μs)</td><td align="right" bgcolor="#A8D08D">2,575 μs (Δ = -0,413 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">229</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,224</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 341,813 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1416,280 ns</td><td align="right" bgcolor="#FF4949">1499,499 ns (Δ = +83,219 ns)</td><td align="right" bgcolor="#A8D08D">1392,498 ns (Δ = -107,002 ns)</td><td align="right" bgcolor="#FFFFFF">1392,458 ns (Δ = -0,040 ns)</td><td align="right" bgcolor="#FFFFFF">1377,910 ns (Δ = -14,548 ns)</td><td align="right" bgcolor="#A8D08D">1157,687 ns (Δ = -220,223 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,416 μs</td><td align="right" bgcolor="#FF4949">1,499 μs (Δ = +0,083 μs)</td><td align="right" bgcolor="#A8D08D">1,392 μs (Δ = -0,107 μs)</td><td align="right" bgcolor="#FFFFFF">1,392 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">1,378 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#A8D08D">1,158 μs (Δ = -0,220 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">508</td><td align="right">508</td><td align="right">508</td><td align="right">508</td><td align="right">508</td><td align="right">426</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,496</td><td align="right">0,496</td><td align="right">0,496</td><td align="right">0,496</td><td align="right">0,496</td><td align="right">0,416</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 460,378 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">876,713 ns</td><td align="right" bgcolor="#FFFFFF">879,507 ns (Δ = +2,793 ns)</td><td align="right" bgcolor="#FFFFFF">879,113 ns (Δ = -0,393 ns)</td><td align="right" bgcolor="#FF4949">1088,320 ns (Δ = +209,207 ns)</td><td align="right" bgcolor="#A8D08D">869,673 ns (Δ = -218,647 ns)</td><td align="right" bgcolor="#A8D08D">627,942 ns (Δ = -241,731 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,877 μs</td><td align="right" bgcolor="#FFFFFF">0,880 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,879 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">1,088 μs (Δ = +0,209 μs)</td><td align="right" bgcolor="#A8D08D">0,870 μs (Δ = -0,219 μs)</td><td align="right" bgcolor="#A8D08D">0,628 μs (Δ = -0,242 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">475</td><td align="right">475</td><td align="right">475</td><td align="right">475</td><td align="right">475</td><td align="right">328</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,464</td><td align="right">0,464</td><td align="right">0,464</td><td align="right">0,464</td><td align="right">0,464</td><td align="right">0,320</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 43,756 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">782,013 ns</td><td align="right" bgcolor="#FFFFFF">798,467 ns (Δ = +16,453 ns)</td><td align="right" bgcolor="#FFFFFF">778,602 ns (Δ = -19,865 ns)</td><td align="right" bgcolor="#FFFFFF">782,280 ns (Δ = +3,678 ns)</td><td align="right" bgcolor="#A8D08D">754,711 ns (Δ = -27,569 ns)</td><td align="right" bgcolor="#FF4949">779,550 ns (Δ = +24,839 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,782 μs</td><td align="right" bgcolor="#FFFFFF">0,798 μs (Δ = +0,016 μs)</td><td align="right" bgcolor="#FFFFFF">0,779 μs (Δ = -0,020 μs)</td><td align="right" bgcolor="#FFFFFF">0,782 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,755 μs (Δ = -0,028 μs)</td><td align="right" bgcolor="#FF4949">0,780 μs (Δ = +0,025 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 13,658 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">214,880 ns</td><td align="right" bgcolor="#FFFFFF">219,564 ns (Δ = +4,684 ns)</td><td align="right" bgcolor="#A8D08D">209,135 ns (Δ = -10,429 ns)</td><td align="right" bgcolor="#FFFFFF">214,845 ns (Δ = +5,710 ns)</td><td align="right" bgcolor="#A8D08D">205,907 ns (Δ = -8,938 ns)</td><td align="right" bgcolor="#FF4949">215,067 ns (Δ = +9,160 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,215 μs</td><td align="right" bgcolor="#FFFFFF">0,220 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,209 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,215 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#A8D08D">0,206 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FF4949">0,215 μs (Δ = +0,009 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 27,373 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">222,979 ns</td><td align="right" bgcolor="#FF4949">246,647 ns (Δ = +23,668 ns)</td><td align="right" bgcolor="#A8D08D">226,370 ns (Δ = -20,277 ns)</td><td align="right" bgcolor="#FFFFFF">228,237 ns (Δ = +1,867 ns)</td><td align="right" bgcolor="#A8D08D">219,273 ns (Δ = -8,963 ns)</td><td align="right" bgcolor="#FFFFFF">219,991 ns (Δ = +0,718 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FF4949">0,247 μs (Δ = +0,024 μs)</td><td align="right" bgcolor="#A8D08D">0,226 μs (Δ = -0,020 μs)</td><td align="right" bgcolor="#FFFFFF">0,228 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,219 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FFFFFF">0,220 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 37,028 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">217,428 ns</td><td align="right" bgcolor="#FF4949">251,144 ns (Δ = +33,715 ns)</td><td align="right" bgcolor="#A8D08D">219,420 ns (Δ = -31,724 ns)</td><td align="right" bgcolor="#FFFFFF">221,222 ns (Δ = +1,802 ns)</td><td align="right" bgcolor="#A8D08D">214,116 ns (Δ = -7,106 ns)</td><td align="right" bgcolor="#FF4949">225,800 ns (Δ = +11,684 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,217 μs</td><td align="right" bgcolor="#FF4949">0,251 μs (Δ = +0,034 μs)</td><td align="right" bgcolor="#A8D08D">0,219 μs (Δ = -0,032 μs)</td><td align="right" bgcolor="#FFFFFF">0,221 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,214 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FF4949">0,226 μs (Δ = +0,012 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 71,806 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">629,811 ns</td><td align="right" bgcolor="#FF4949">694,693 ns (Δ = +64,882 ns)</td><td align="right" bgcolor="#A8D08D">622,888 ns (Δ = -71,806 ns)</td><td align="right" bgcolor="#FF4949">645,748 ns (Δ = +22,861 ns)</td><td align="right" bgcolor="#FFFFFF">637,901 ns (Δ = -7,847 ns)</td><td align="right" bgcolor="#FF4949">661,727 ns (Δ = +23,825 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,630 μs</td><td align="right" bgcolor="#FF4949">0,695 μs (Δ = +0,065 μs)</td><td align="right" bgcolor="#A8D08D">0,623 μs (Δ = -0,072 μs)</td><td align="right" bgcolor="#FF4949">0,646 μs (Δ = +0,023 μs)</td><td align="right" bgcolor="#FFFFFF">0,638 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FF4949">0,662 μs (Δ = +0,024 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">279</td><td align="right">328</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,272</td><td align="right">0,320</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 27,580 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">186,186 ns</td><td align="right" bgcolor="#FFFFFF">189,111 ns (Δ = +2,925 ns)</td><td align="right" bgcolor="#FFFFFF">188,493 ns (Δ = -0,618 ns)</td><td align="right" bgcolor="#FFFFFF">189,860 ns (Δ = +1,367 ns)</td><td align="right" bgcolor="#FFFFFF">184,653 ns (Δ = -5,207 ns)</td><td align="right" bgcolor="#FF4949">212,233 ns (Δ = +27,580 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,186 μs</td><td align="right" bgcolor="#FFFFFF">0,189 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,188 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,190 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,185 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FF4949">0,212 μs (Δ = +0,028 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **4.4.0**

Slowest: 4.2.0

Δ: 40,235 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">954,200 ns</td><td align="right" bgcolor="#FFFFFF">940,208 ns (Δ = -13,992 ns)</td><td align="right" bgcolor="#FFFFFF">913,965 ns (Δ = -26,243 ns)</td><td align="right" bgcolor="#FFFFFF">935,660 ns (Δ = +21,695 ns)</td><td align="right" bgcolor="#FFFFFF">928,889 ns (Δ = -6,771 ns)</td><td align="right" bgcolor="#FFFFFF">953,398 ns (Δ = +24,509 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,954 μs</td><td align="right" bgcolor="#FFFFFF">0,940 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FFFFFF">0,914 μs (Δ = -0,026 μs)</td><td align="right" bgcolor="#FFFFFF">0,936 μs (Δ = +0,022 μs)</td><td align="right" bgcolor="#FFFFFF">0,929 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,953 μs (Δ = +0,025 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">344</td><td align="right">360</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,336</td><td align="right">0,352</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 19,613 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">196,222 ns</td><td align="right" bgcolor="#FFFFFF">200,933 ns (Δ = +4,712 ns)</td><td align="right" bgcolor="#A8D08D">191,360 ns (Δ = -9,573 ns)</td><td align="right" bgcolor="#FFFFFF">190,847 ns (Δ = -0,513 ns)</td><td align="right" bgcolor="#A8D08D">181,320 ns (Δ = -9,527 ns)</td><td align="right" bgcolor="#FFFFFF">185,933 ns (Δ = +4,613 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td><td align="right" bgcolor="#FFFFFF">0,201 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,191 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,191 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,181 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,186 μs (Δ = +0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 21,950 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">173,513 ns</td><td align="right" bgcolor="#A8D08D">165,573 ns (Δ = -7,940 ns)</td><td align="right" bgcolor="#FF4949">179,893 ns (Δ = +14,320 ns)</td><td align="right" bgcolor="#A8D08D">170,391 ns (Δ = -9,502 ns)</td><td align="right" bgcolor="#FF4949">187,523 ns (Δ = +17,132 ns)</td><td align="right" bgcolor="#FFFFFF">185,453 ns (Δ = -2,070 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,174 μs</td><td align="right" bgcolor="#A8D08D">0,166 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FF4949">0,180 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#A8D08D">0,170 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FF4949">0,188 μs (Δ = +0,017 μs)</td><td align="right" bgcolor="#FFFFFF">0,185 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 2,980 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">111,847 ns</td><td align="right" bgcolor="#FFFFFF">111,420 ns (Δ = -0,427 ns)</td><td align="right" bgcolor="#FFFFFF">112,665 ns (Δ = +1,245 ns)</td><td align="right" bgcolor="#FFFFFF">109,850 ns (Δ = -2,815 ns)</td><td align="right" bgcolor="#FFFFFF">109,685 ns (Δ = -0,165 ns)</td><td align="right" bgcolor="#FFFFFF">111,693 ns (Δ = +2,008 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,111 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,113 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,110 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,110 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,112 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 4.3.0

Δ: 36,014 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">219,196 ns</td><td align="right" bgcolor="#FFFFFF">225,302 ns (Δ = +6,106 ns)</td><td align="right" bgcolor="#FFFFFF">220,608 ns (Δ = -4,694 ns)</td><td align="right" bgcolor="#FFFFFF">222,373 ns (Δ = +1,765 ns)</td><td align="right" bgcolor="#A8D08D">207,837 ns (Δ = -14,537 ns)</td><td align="right" bgcolor="#A8D08D">189,288 ns (Δ = -18,548 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,225 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,221 μs (Δ = -0,005 μs)</td><td align="right" bgcolor="#FFFFFF">0,222 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,208 μs (Δ = -0,015 μs)</td><td align="right" bgcolor="#A8D08D">0,189 μs (Δ = -0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">229</td><td align="right">197</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,224</td><td align="right">0,192</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 82,396 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1542,040 ns</td><td align="right" bgcolor="#FFFFFF">1509,204 ns (Δ = -32,836 ns)</td><td align="right" bgcolor="#A8D08D">1459,644 ns (Δ = -49,560 ns)</td><td align="right" bgcolor="#FF4949">1522,378 ns (Δ = +62,733 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,542 μs</td><td align="right" bgcolor="#FFFFFF">1,509 μs (Δ = -0,033 μs)</td><td align="right" bgcolor="#A8D08D">1,460 μs (Δ = -0,050 μs)</td><td align="right" bgcolor="#FF4949">1,522 μs (Δ = +0,063 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">279</td><td align="right">279</td><td align="right">279</td><td align="right">279</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,272</td><td align="right">0,272</td><td align="right">0,272</td><td align="right">0,272</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 39,128 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">913,511 ns</td><td align="right" bgcolor="#FFFFFF">923,608 ns (Δ = +10,097 ns)</td><td align="right" bgcolor="#FFFFFF">903,047 ns (Δ = -20,562 ns)</td><td align="right" bgcolor="#FFFFFF">884,480 ns (Δ = -18,567 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,914 μs</td><td align="right" bgcolor="#FFFFFF">0,924 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,903 μs (Δ = -0,021 μs)</td><td align="right" bgcolor="#FFFFFF">0,884 μs (Δ = -0,019 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 30,718 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">915,240 ns</td><td align="right" bgcolor="#FFFFFF">912,320 ns (Δ = -2,920 ns)</td><td align="right" bgcolor="#A8D08D">884,522 ns (Δ = -27,798 ns)</td><td align="right" bgcolor="#FFFFFF">886,044 ns (Δ = +1,522 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,915 μs</td><td align="right" bgcolor="#FFFFFF">0,912 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,885 μs (Δ = -0,028 μs)</td><td align="right" bgcolor="#FFFFFF">0,886 μs (Δ = +0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><td align="right">49</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><td align="right">0,048</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 20,982 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">868,950 ns</td><td align="right" bgcolor="#FFFFFF">877,433 ns (Δ = +8,483 ns)</td><td align="right" bgcolor="#FFFFFF">856,452 ns (Δ = -20,982 ns)</td><td align="right" bgcolor="#FFFFFF">861,107 ns (Δ = +4,655 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,869 μs</td><td align="right" bgcolor="#FFFFFF">0,877 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,856 μs (Δ = -0,021 μs)</td><td align="right" bgcolor="#FFFFFF">0,861 μs (Δ = +0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 35,652 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">800,827 ns</td><td align="right" bgcolor="#FFFFFF">816,938 ns (Δ = +16,112 ns)</td><td align="right" bgcolor="#A8D08D">784,532 ns (Δ = -32,407 ns)</td><td align="right" bgcolor="#FFFFFF">796,905 ns (Δ = +12,373 ns)</td><td align="right" bgcolor="#FFFFFF">794,022 ns (Δ = -2,883 ns)</td><td align="right" bgcolor="#FFFFFF">781,287 ns (Δ = -12,736 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,801 μs</td><td align="right" bgcolor="#FFFFFF">0,817 μs (Δ = +0,016 μs)</td><td align="right" bgcolor="#A8D08D">0,785 μs (Δ = -0,032 μs)</td><td align="right" bgcolor="#FFFFFF">0,797 μs (Δ = +0,012 μs)</td><td align="right" bgcolor="#FFFFFF">0,794 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,781 μs (Δ = -0,013 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 32,980 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">253,344 ns</td><td align="right" bgcolor="#A8D08D">235,030 ns (Δ = -18,314 ns)</td><td align="right" bgcolor="#FF4949">263,807 ns (Δ = +28,777 ns)</td><td align="right" bgcolor="#A8D08D">236,120 ns (Δ = -27,687 ns)</td><td align="right" bgcolor="#FF4949">247,300 ns (Δ = +11,180 ns)</td><td align="right" bgcolor="#A8D08D">230,827 ns (Δ = -16,473 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,253 μs</td><td align="right" bgcolor="#A8D08D">0,235 μs (Δ = -0,018 μs)</td><td align="right" bgcolor="#FF4949">0,264 μs (Δ = +0,029 μs)</td><td align="right" bgcolor="#A8D08D">0,236 μs (Δ = -0,028 μs)</td><td align="right" bgcolor="#FF4949">0,247 μs (Δ = +0,011 μs)</td><td align="right" bgcolor="#A8D08D">0,231 μs (Δ = -0,016 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 14,013 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">264,433 ns</td><td align="right" bgcolor="#FFFFFF">262,907 ns (Δ = -1,527 ns)</td><td align="right" bgcolor="#A8D08D">254,910 ns (Δ = -7,997 ns)</td><td align="right" bgcolor="#FFFFFF">258,533 ns (Δ = +3,623 ns)</td><td align="right" bgcolor="#FFFFFF">252,542 ns (Δ = -5,991 ns)</td><td align="right" bgcolor="#FFFFFF">250,420 ns (Δ = -2,122 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td><td align="right" bgcolor="#FFFFFF">0,263 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,255 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#FFFFFF">0,259 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,253 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,250 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 55,301 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">248,708 ns</td><td align="right" bgcolor="#FF4949">293,910 ns (Δ = +45,202 ns)</td><td align="right" bgcolor="#A8D08D">238,609 ns (Δ = -55,301 ns)</td><td align="right" bgcolor="#FFFFFF">242,850 ns (Δ = +4,241 ns)</td><td align="right" bgcolor="#FFFFFF">238,640 ns (Δ = -4,210 ns)</td><td align="right" bgcolor="#FFFFFF">242,716 ns (Δ = +4,076 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,249 μs</td><td align="right" bgcolor="#FF4949">0,294 μs (Δ = +0,045 μs)</td><td align="right" bgcolor="#A8D08D">0,239 μs (Δ = -0,055 μs)</td><td align="right" bgcolor="#FFFFFF">0,243 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,239 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,243 μs (Δ = +0,004 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2178,871 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7980,658 ns</td><td align="right" bgcolor="#FFFFFF">8026,284 ns (Δ = +45,627 ns)</td><td align="right" bgcolor="#FFFFFF">7968,050 ns (Δ = -58,234 ns)</td><td align="right" bgcolor="#FFFFFF">8159,353 ns (Δ = +191,303 ns)</td><td align="right" bgcolor="#FF4949">8579,051 ns (Δ = +419,698 ns)</td><td align="right" bgcolor="#A8D08D">6400,180 ns (Δ = -2178,871 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,981 μs</td><td align="right" bgcolor="#FFFFFF">8,026 μs (Δ = +0,046 μs)</td><td align="right" bgcolor="#FFFFFF">7,968 μs (Δ = -0,058 μs)</td><td align="right" bgcolor="#FFFFFF">8,159 μs (Δ = +0,191 μs)</td><td align="right" bgcolor="#FF4949">8,579 μs (Δ = +0,420 μs)</td><td align="right" bgcolor="#A8D08D">6,400 μs (Δ = -2,179 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,009 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = -0,002 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">2949</td><td align="right">2949</td><td align="right">2949</td><td align="right">2949</td><td align="right">3031</td><td align="right">2359</td><tr>
<td>Allocated Kilobytes</td><td align="right">2,880</td><td align="right">2,880</td><td align="right">2,880</td><td align="right">2,880</td><td align="right">2,960</td><td align="right">2,304</td><tr>
<td>Allocated Megabytes</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,003</td><td align="right">0,002</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 369,258 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1529,280 ns</td><td align="right" bgcolor="#FFFFFF">1555,393 ns (Δ = +26,113 ns)</td><td align="right" bgcolor="#FFFFFF">1563,929 ns (Δ = +8,536 ns)</td><td align="right" bgcolor="#FFFFFF">1587,276 ns (Δ = +23,347 ns)</td><td align="right" bgcolor="#FFFFFF">1563,602 ns (Δ = -23,673 ns)</td><td align="right" bgcolor="#A8D08D">1218,018 ns (Δ = -345,584 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,529 μs</td><td align="right" bgcolor="#FFFFFF">1,555 μs (Δ = +0,026 μs)</td><td align="right" bgcolor="#FFFFFF">1,564 μs (Δ = +0,009 μs)</td><td align="right" bgcolor="#FFFFFF">1,587 μs (Δ = +0,023 μs)</td><td align="right" bgcolor="#FFFFFF">1,564 μs (Δ = -0,024 μs)</td><td align="right" bgcolor="#A8D08D">1,218 μs (Δ = -0,346 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">98</td><td align="right">98</td><td align="right">98</td><td align="right">98</td><td align="right">98</td><td align="right">82</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,096</td><td align="right">0,096</td><td align="right">0,096</td><td align="right">0,096</td><td align="right">0,096</td><td align="right">0,080</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1832,493 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7492,642 ns</td><td align="right" bgcolor="#FFFFFF">7469,342 ns (Δ = -23,300 ns)</td><td align="right" bgcolor="#FFFFFF">7525,773 ns (Δ = +56,431 ns)</td><td align="right" bgcolor="#FFFFFF">7556,803 ns (Δ = +31,029 ns)</td><td align="right" bgcolor="#FFFFFF">7650,893 ns (Δ = +94,091 ns)</td><td align="right" bgcolor="#A8D08D">5818,400 ns (Δ = -1832,493 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,493 μs</td><td align="right" bgcolor="#FFFFFF">7,469 μs (Δ = -0,023 μs)</td><td align="right" bgcolor="#FFFFFF">7,526 μs (Δ = +0,056 μs)</td><td align="right" bgcolor="#FFFFFF">7,557 μs (Δ = +0,031 μs)</td><td align="right" bgcolor="#FFFFFF">7,651 μs (Δ = +0,094 μs)</td><td align="right" bgcolor="#A8D08D">5,818 μs (Δ = -1,832 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,008 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,006 ms (Δ = -0,002 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">5063</td><td align="right">5063</td><td align="right">5063</td><td align="right">5063</td><td align="right">5161</td><td align="right">3916</td><tr>
<td>Allocated Kilobytes</td><td align="right">4,944</td><td align="right">4,944</td><td align="right">4,944</td><td align="right">4,944</td><td align="right">5,040</td><td align="right">3,824</td><tr>
<td>Allocated Megabytes</td><td align="right">0,005</td><td align="right">0,005</td><td align="right">0,005</td><td align="right">0,005</td><td align="right">0,005</td><td align="right">0,004</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 348,491 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1558,873 ns</td><td align="right" bgcolor="#FFFFFF">1524,844 ns (Δ = -34,030 ns)</td><td align="right" bgcolor="#FFFFFF">1549,593 ns (Δ = +24,750 ns)</td><td align="right" bgcolor="#FFFFFF">1582,780 ns (Δ = +33,187 ns)</td><td align="right" bgcolor="#FFFFFF">1575,063 ns (Δ = -7,717 ns)</td><td align="right" bgcolor="#A8D08D">1234,289 ns (Δ = -340,774 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,559 μs</td><td align="right" bgcolor="#FFFFFF">1,525 μs (Δ = -0,034 μs)</td><td align="right" bgcolor="#FFFFFF">1,550 μs (Δ = +0,025 μs)</td><td align="right" bgcolor="#FFFFFF">1,583 μs (Δ = +0,033 μs)</td><td align="right" bgcolor="#FFFFFF">1,575 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#A8D08D">1,234 μs (Δ = -0,341 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">98</td><td align="right">98</td><td align="right">98</td><td align="right">98</td><td align="right">98</td><td align="right">82</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,096</td><td align="right">0,096</td><td align="right">0,096</td><td align="right">0,096</td><td align="right">0,096</td><td align="right">0,080</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 16,685 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">833,867 ns</td><td align="right" bgcolor="#FFFFFF">836,325 ns (Δ = +2,459 ns)</td><td align="right" bgcolor="#FFFFFF">820,281 ns (Δ = -16,045 ns)</td><td align="right" bgcolor="#FFFFFF">832,987 ns (Δ = +12,706 ns)</td><td align="right" bgcolor="#FFFFFF">823,470 ns (Δ = -9,517 ns)</td><td align="right" bgcolor="#FFFFFF">819,640 ns (Δ = -3,830 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,834 μs</td><td align="right" bgcolor="#FFFFFF">0,836 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,820 μs (Δ = -0,016 μs)</td><td align="right" bgcolor="#FFFFFF">0,833 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#FFFFFF">0,823 μs (Δ = -0,010 μs)</td><td align="right" bgcolor="#FFFFFF">0,820 μs (Δ = -0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">295</td><td align="right">279</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,288</td><td align="right">0,272</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 69,427 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1775,338 ns</td><td align="right" bgcolor="#FFFFFF">1783,313 ns (Δ = +7,976 ns)</td><td align="right" bgcolor="#FFFFFF">1781,484 ns (Δ = -1,829 ns)</td><td align="right" bgcolor="#FFFFFF">1821,646 ns (Δ = +40,161 ns)</td><td align="right" bgcolor="#FFFFFF">1831,827 ns (Δ = +10,181 ns)</td><td align="right" bgcolor="#A8D08D">1762,400 ns (Δ = -69,427 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,775 μs</td><td align="right" bgcolor="#FFFFFF">1,783 μs (Δ = +0,008 μs)</td><td align="right" bgcolor="#FFFFFF">1,781 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">1,822 μs (Δ = +0,040 μs)</td><td align="right" bgcolor="#FFFFFF">1,832 μs (Δ = +0,010 μs)</td><td align="right" bgcolor="#A8D08D">1,762 μs (Δ = -0,069 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">688</td><td align="right">688</td><td align="right">688</td><td align="right">688</td><td align="right">705</td><td align="right">672</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,672</td><td align="right">0,672</td><td align="right">0,672</td><td align="right">0,672</td><td align="right">0,688</td><td align="right">0,656</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 60,873 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1193,793 ns</td><td align="right" bgcolor="#FFFFFF">1189,569 ns (Δ = -4,225 ns)</td><td align="right" bgcolor="#FFFFFF">1193,054 ns (Δ = +3,485 ns)</td><td align="right" bgcolor="#FFFFFF">1207,150 ns (Δ = +14,096 ns)</td><td align="right" bgcolor="#FFFFFF">1223,627 ns (Δ = +16,477 ns)</td><td align="right" bgcolor="#A8D08D">1162,753 ns (Δ = -60,873 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,194 μs</td><td align="right" bgcolor="#FFFFFF">1,190 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">1,193 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">1,207 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#FFFFFF">1,224 μs (Δ = +0,016 μs)</td><td align="right" bgcolor="#A8D08D">1,163 μs (Δ = -0,061 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">754</td><td align="right">754</td><td align="right">754</td><td align="right">754</td><td align="right">786</td><td align="right">737</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,736</td><td align="right">0,736</td><td align="right">0,736</td><td align="right">0,736</td><td align="right">0,768</td><td align="right">0,720</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **4.3.0**

Slowest: 4.2.0

Δ: 73,133 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">536,453 ns</td><td align="right" bgcolor="#A8D08D">463,320 ns (Δ = -73,133 ns)</td><td align="right" bgcolor="#FF4949">501,883 ns (Δ = +38,563 ns)</td><td align="right" bgcolor="#A8D08D">479,453 ns (Δ = -22,430 ns)</td><td align="right" bgcolor="#FF4949">502,789 ns (Δ = +23,336 ns)</td><td align="right" bgcolor="#A8D08D">476,750 ns (Δ = -26,039 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,536 μs</td><td align="right" bgcolor="#A8D08D">0,463 μs (Δ = -0,073 μs)</td><td align="right" bgcolor="#FF4949">0,502 μs (Δ = +0,039 μs)</td><td align="right" bgcolor="#A8D08D">0,479 μs (Δ = -0,022 μs)</td><td align="right" bgcolor="#FF4949">0,503 μs (Δ = +0,023 μs)</td><td align="right" bgcolor="#A8D08D">0,477 μs (Δ = -0,026 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">66</td><td align="right">66</td><td align="right">66</td><td align="right">66</td><td align="right">82</td><td align="right">66</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,064</td><td align="right">0,064</td><td align="right">0,064</td><td align="right">0,064</td><td align="right">0,080</td><td align="right">0,064</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **4.4.0**

Slowest: 4.3.0

Δ: 174,600 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">776,120 ns</td><td align="right" bgcolor="#FF4949">944,600 ns (Δ = +168,480 ns)</td><td align="right" bgcolor="#A8D08D">770,000 ns (Δ = -174,600 ns)</td><td align="right" bgcolor="#FF4949">818,422 ns (Δ = +48,422 ns)</td><td align="right" bgcolor="#FFFFFF">804,333 ns (Δ = -14,089 ns)</td><td align="right" bgcolor="#FFFFFF">826,289 ns (Δ = +21,956 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,776 μs</td><td align="right" bgcolor="#FF4949">0,945 μs (Δ = +0,168 μs)</td><td align="right" bgcolor="#A8D08D">0,770 μs (Δ = -0,175 μs)</td><td align="right" bgcolor="#FF4949">0,818 μs (Δ = +0,048 μs)</td><td align="right" bgcolor="#FFFFFF">0,804 μs (Δ = -0,014 μs)</td><td align="right" bgcolor="#FFFFFF">0,826 μs (Δ = +0,022 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 9,530 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">236,318 ns</td><td align="right" bgcolor="#FFFFFF">240,367 ns (Δ = +4,048 ns)</td><td align="right" bgcolor="#FFFFFF">241,340 ns (Δ = +0,973 ns)</td><td align="right" bgcolor="#FFFFFF">236,988 ns (Δ = -4,352 ns)</td><td align="right" bgcolor="#FFFFFF">237,413 ns (Δ = +0,425 ns)</td><td align="right" bgcolor="#FFFFFF">231,810 ns (Δ = -5,603 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,240 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,241 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,237 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,237 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,232 μs (Δ = -0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><td align="right">16</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><td align="right">0,016</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 460,824 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3087,933 ns</td><td align="right" bgcolor="#FFFFFF">3023,930 ns (Δ = -64,003 ns)</td><td align="right" bgcolor="#FFFFFF">3000,484 ns (Δ = -23,446 ns)</td><td align="right" bgcolor="#FF4949">3137,811 ns (Δ = +137,327 ns)</td><td align="right" bgcolor="#FFFFFF">3100,420 ns (Δ = -37,391 ns)</td><td align="right" bgcolor="#A8D08D">2676,987 ns (Δ = -423,433 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,088 μs</td><td align="right" bgcolor="#FFFFFF">3,024 μs (Δ = -0,064 μs)</td><td align="right" bgcolor="#FFFFFF">3,000 μs (Δ = -0,023 μs)</td><td align="right" bgcolor="#FF4949">3,138 μs (Δ = +0,137 μs)</td><td align="right" bgcolor="#FFFFFF">3,100 μs (Δ = -0,037 μs)</td><td align="right" bgcolor="#A8D08D">2,677 μs (Δ = -0,423 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">246</td><td align="right">229</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,240</td><td align="right">0,224</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 58,033 ns


<table>
<tr>
<th> </th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">290,820 ns</td><td align="right" bgcolor="#A8D08D">232,787 ns (Δ = -58,033 ns)</td><td align="right" bgcolor="#FF4949">240,944 ns (Δ = +8,158 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,291 μs</td><td align="right" bgcolor="#A8D08D">0,233 μs (Δ = -0,058 μs)</td><td align="right" bgcolor="#FF4949">0,241 μs (Δ = +0,008 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 1,641 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17,100 ns</td><td align="right" bgcolor="#FFFFFF">17,284 ns (Δ = +0,184 ns)</td><td align="right" bgcolor="#FFFFFF">16,967 ns (Δ = -0,318 ns)</td><td align="right" bgcolor="#FFFFFF">17,140 ns (Δ = +0,173 ns)</td><td align="right" bgcolor="#A8D08D">16,440 ns (Δ = -0,700 ns)</td><td align="right" bgcolor="#A8D08D">15,643 ns (Δ = -0,797 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,017 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,017 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,016 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,016 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 2,648 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">40,932 ns</td><td align="right" bgcolor="#FFFFFF">40,431 ns (Δ = -0,501 ns)</td><td align="right" bgcolor="#FFFFFF">39,360 ns (Δ = -1,071 ns)</td><td align="right" bgcolor="#FF4949">41,038 ns (Δ = +1,678 ns)</td><td align="right" bgcolor="#A8D08D">38,390 ns (Δ = -2,648 ns)</td><td align="right" bgcolor="#FFFFFF">38,953 ns (Δ = +0,563 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,039 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,041 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,038 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,039 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 4,780 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">45,409 ns</td><td align="right" bgcolor="#FFFFFF">44,133 ns (Δ = -1,276 ns)</td><td align="right" bgcolor="#FF4949">46,913 ns (Δ = +2,781 ns)</td><td align="right" bgcolor="#FFFFFF">45,590 ns (Δ = -1,323 ns)</td><td align="right" bgcolor="#FFFFFF">44,996 ns (Δ = -0,594 ns)</td><td align="right" bgcolor="#A8D08D">42,133 ns (Δ = -2,862 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,047 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,046 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,045 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,042 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 4,653 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">39,587 ns</td><td align="right" bgcolor="#FFFFFF">40,373 ns (Δ = +0,787 ns)</td><td align="right" bgcolor="#FFFFFF">40,250 ns (Δ = -0,123 ns)</td><td align="right" bgcolor="#FFFFFF">40,649 ns (Δ = +0,399 ns)</td><td align="right" bgcolor="#FFFFFF">39,825 ns (Δ = -0,824 ns)</td><td align="right" bgcolor="#A8D08D">35,996 ns (Δ = -3,829 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,040 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,041 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,040 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,036 μs (Δ = -0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 0,503 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,058 ns</td><td align="right" bgcolor="#FFFFFF">18,020 ns (Δ = -0,038 ns)</td><td align="right" bgcolor="#FFFFFF">17,827 ns (Δ = -0,193 ns)</td><td align="right" bgcolor="#FFFFFF">17,680 ns (Δ = -0,147 ns)</td><td align="right" bgcolor="#FFFFFF">17,580 ns (Δ = -0,100 ns)</td><td align="right" bgcolor="#FFFFFF">17,555 ns (Δ = -0,025 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Slowest: 4.2.0

Δ: 5,087 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">27,233 ns</td><td align="right" bgcolor="#A8D08D">24,220 ns (Δ = -3,013 ns)</td><td align="right" bgcolor="#FFFFFF">24,400 ns (Δ = +0,180 ns)</td><td align="right" bgcolor="#FFFFFF">24,433 ns (Δ = +0,033 ns)</td><td align="right" bgcolor="#A8D08D">22,670 ns (Δ = -1,763 ns)</td><td align="right" bgcolor="#FFFFFF">22,147 ns (Δ = -0,523 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#A8D08D">0,024 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,024 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,024 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,023 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Δ: 8,513 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35,860 ns</td><td align="right" bgcolor="#A8D08D">28,930 ns (Δ = -6,930 ns)</td><td align="right" bgcolor="#A8D08D">27,559 ns (Δ = -1,371 ns)</td><td align="right" bgcolor="#FF4949">28,607 ns (Δ = +1,047 ns)</td><td align="right" bgcolor="#FFFFFF">27,835 ns (Δ = -0,772 ns)</td><td align="right" bgcolor="#FFFFFF">27,347 ns (Δ = -0,488 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#A8D08D">0,029 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,028 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,029 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,028 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,027 μs (Δ = 0,000 μs)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 29,604 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">466,987 ns</td><td align="right" bgcolor="#FFFFFF">473,227 ns (Δ = +6,240 ns)</td><td align="right" bgcolor="#FFFFFF">478,920 ns (Δ = +5,693 ns)</td><td align="right" bgcolor="#FFFFFF">492,294 ns (Δ = +13,374 ns)</td><td align="right" bgcolor="#A8D08D">466,863 ns (Δ = -25,431 ns)</td><td align="right" bgcolor="#FFFFFF">462,690 ns (Δ = -4,173 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,467 μs</td><td align="right" bgcolor="#FFFFFF">0,473 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,479 μs (Δ = +0,006 μs)</td><td align="right" bgcolor="#FFFFFF">0,492 μs (Δ = +0,013 μs)</td><td align="right" bgcolor="#A8D08D">0,467 μs (Δ = -0,025 μs)</td><td align="right" bgcolor="#FFFFFF">0,463 μs (Δ = -0,004 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Δ: 41,877 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">157,516 ns</td><td align="right" bgcolor="#FFFFFF">156,633 ns (Δ = -0,882 ns)</td><td align="right" bgcolor="#FFFFFF">156,169 ns (Δ = -0,464 ns)</td><td align="right" bgcolor="#FFFFFF">156,221 ns (Δ = +0,052 ns)</td><td align="right" bgcolor="#FFFFFF">153,196 ns (Δ = -3,025 ns)</td><td align="right" bgcolor="#FF4949">195,072 ns (Δ = +41,877 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,157 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,156 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,156 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,153 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FF4949">0,195 μs (Δ = +0,042 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.4.0

Δ: 29,364 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">28,870 ns</td><td align="right" bgcolor="#FFFFFF">28,147 ns (Δ = -0,723 ns)</td><td align="right" bgcolor="#FF4949">57,231 ns (Δ = +29,084 ns)</td><td align="right" bgcolor="#A8D08D">28,827 ns (Δ = -28,404 ns)</td><td align="right" bgcolor="#FFFFFF">29,004 ns (Δ = +0,178 ns)</td><td align="right" bgcolor="#A8D08D">27,867 ns (Δ = -1,138 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,057 μs (Δ = +0,029 μs)</td><td align="right" bgcolor="#A8D08D">0,029 μs (Δ = -0,028 μs)</td><td align="right" bgcolor="#FFFFFF">0,029 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,028 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Slowest: 4.4.0

Δ: 16,905 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">38,073 ns</td><td align="right" bgcolor="#FFFFFF">37,007 ns (Δ = -1,066 ns)</td><td align="right" bgcolor="#FF4949">51,200 ns (Δ = +14,193 ns)</td><td align="right" bgcolor="#A8D08D">38,589 ns (Δ = -12,611 ns)</td><td align="right" bgcolor="#A8D08D">34,480 ns (Δ = -4,109 ns)</td><td align="right" bgcolor="#FFFFFF">34,295 ns (Δ = -0,185 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,051 μs (Δ = +0,014 μs)</td><td align="right" bgcolor="#A8D08D">0,039 μs (Δ = -0,013 μs)</td><td align="right" bgcolor="#A8D08D">0,034 μs (Δ = -0,004 μs)</td><td align="right" bgcolor="#FFFFFF">0,034 μs (Δ = 0,000 μs)</td></tr>
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


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 1,587 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,513 ns</td><td align="right" bgcolor="#FFFFFF">11,353 ns (Δ = -0,160 ns)</td><td align="right" bgcolor="#A8D08D">9,927 ns (Δ = -1,427 ns)</td><td align="right" bgcolor="#FF4949">10,285 ns (Δ = +0,358 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,010 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,010 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 2,131 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,186 ns</td><td align="right" bgcolor="#FFFFFF">12,365 ns (Δ = +0,179 ns)</td><td align="right" bgcolor="#FFFFFF">12,183 ns (Δ = -0,182 ns)</td><td align="right" bgcolor="#FF4949">13,111 ns (Δ = +0,928 ns)</td><td align="right" bgcolor="#A8D08D">11,367 ns (Δ = -1,744 ns)</td><td align="right" bgcolor="#A8D08D">10,980 ns (Δ = -0,387 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,012 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FF4949">0,013 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,011 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,011 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Slowest: 4.5.4

Δ: 16944,622 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30277,489 ns</td><td align="right" bgcolor="#FFFFFF">29867,480 ns (Δ = -410,009 ns)</td><td align="right" bgcolor="#FFFFFF">30751,705 ns (Δ = +884,225 ns)</td><td align="right" bgcolor="#FFFFFF">30370,590 ns (Δ = -381,115 ns)</td><td align="right" bgcolor="#FFFFFF">31198,635 ns (Δ = +828,045 ns)</td><td align="right" bgcolor="#A8D08D">14254,013 ns (Δ = -16944,622 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">30,277 μs</td><td align="right" bgcolor="#FFFFFF">29,867 μs (Δ = -0,410 μs)</td><td align="right" bgcolor="#FFFFFF">30,752 μs (Δ = +0,884 μs)</td><td align="right" bgcolor="#FFFFFF">30,371 μs (Δ = -0,381 μs)</td><td align="right" bgcolor="#FFFFFF">31,199 μs (Δ = +0,828 μs)</td><td align="right" bgcolor="#A8D08D">14,254 μs (Δ = -16,945 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,030 ms</td><td align="right" bgcolor="#FFFFFF">0,030 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,031 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,030 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,031 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,014 ms (Δ = -0,017 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">7867</td><td align="right">7966</td><td align="right">7966</td><td align="right">7857</td><td align="right">7854</td><td align="right">6075</td><tr>
<td>Allocated Kilobytes</td><td align="right">7,683</td><td align="right">7,779</td><td align="right">7,779</td><td align="right">7,673</td><td align="right">7,670</td><td align="right">5,933</td><tr>
<td>Allocated Megabytes</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,008</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,006</td></tr>
</table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **4.4.0**

Slowest: 4.2.0

Δ: 1,452 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,232 ns</td><td align="right" bgcolor="#A8D08D">13,340 ns (Δ = -0,892 ns)</td><td align="right" bgcolor="#A8D08D">12,780 ns (Δ = -0,560 ns)</td><td align="right" bgcolor="#FFFFFF">13,047 ns (Δ = +0,267 ns)</td><td align="right" bgcolor="#FFFFFF">12,941 ns (Δ = -0,106 ns)</td><td align="right" bgcolor="#FFFFFF">12,867 ns (Δ = -0,074 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#A8D08D">0,013 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,013 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,013 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,013 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,013 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 1,159 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17,720 ns</td><td align="right" bgcolor="#FFFFFF">18,053 ns (Δ = +0,333 ns)</td><td align="right" bgcolor="#A8D08D">17,450 ns (Δ = -0,602 ns)</td><td align="right" bgcolor="#FF4949">18,042 ns (Δ = +0,592 ns)</td><td align="right" bgcolor="#FFFFFF">17,623 ns (Δ = -0,419 ns)</td><td align="right" bgcolor="#A8D08D">16,893 ns (Δ = -0,730 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,017 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,018 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,017 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Slowest: 4.4.0

Δ: 2,580 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,440 ns</td><td align="right" bgcolor="#FFFFFF">16,485 ns (Δ = +0,045 ns)</td><td align="right" bgcolor="#FF4949">17,100 ns (Δ = +0,615 ns)</td><td align="right" bgcolor="#FFFFFF">16,753 ns (Δ = -0,347 ns)</td><td align="right" bgcolor="#A8D08D">14,520 ns (Δ = -2,233 ns)</td><td align="right" bgcolor="#FFFFFF">14,780 ns (Δ = +0,260 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FF4949">0,017 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,017 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,015 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,015 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1,099 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17,902 ns</td><td align="right" bgcolor="#FFFFFF">17,631 ns (Δ = -0,271 ns)</td><td align="right" bgcolor="#FFFFFF">17,524 ns (Δ = -0,107 ns)</td><td align="right" bgcolor="#FFFFFF">17,920 ns (Δ = +0,396 ns)</td><td align="right" bgcolor="#FFFFFF">18,293 ns (Δ = +0,372 ns)</td><td align="right" bgcolor="#A8D08D">17,193 ns (Δ = -1,099 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,018 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,017 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **5.0.0**

Slowest: 4.3.0

Δ: 3,200 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,191 ns</td><td align="right" bgcolor="#FF4949">21,720 ns (Δ = +1,529 ns)</td><td align="right" bgcolor="#A8D08D">19,410 ns (Δ = -2,310 ns)</td><td align="right" bgcolor="#A8D08D">18,714 ns (Δ = -0,696 ns)</td><td align="right" bgcolor="#FF4949">19,497 ns (Δ = +0,783 ns)</td><td align="right" bgcolor="#A8D08D">18,520 ns (Δ = -0,977 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FF4949">0,022 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,019 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,019 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,019 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,019 μs (Δ = -0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 3,478 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">44,830 ns</td><td align="right" bgcolor="#FFFFFF">46,120 ns (Δ = +1,290 ns)</td><td align="right" bgcolor="#FFFFFF">46,698 ns (Δ = +0,578 ns)</td><td align="right" bgcolor="#A8D08D">45,167 ns (Δ = -1,531 ns)</td><td align="right" bgcolor="#A8D08D">43,220 ns (Δ = -1,947 ns)</td><td align="right" bgcolor="#FFFFFF">44,241 ns (Δ = +1,021 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FFFFFF">0,047 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,045 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,043 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,044 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Slowest: 4.5.0

Δ: 36,996 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">983,371 ns</td><td align="right" bgcolor="#FFFFFF">985,160 ns (Δ = +1,789 ns)</td><td align="right" bgcolor="#FFFFFF">976,797 ns (Δ = -8,363 ns)</td><td align="right" bgcolor="#A8D08D">948,164 ns (Δ = -28,632 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,983 μs</td><td align="right" bgcolor="#FFFFFF">0,985 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,977 μs (Δ = -0,008 μs)</td><td align="right" bgcolor="#A8D08D">0,948 μs (Δ = -0,029 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,001 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,001 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.4.0

Δ: 2,593 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,180 ns</td><td align="right" bgcolor="#FF4949">21,722 ns (Δ = +1,542 ns)</td><td align="right" bgcolor="#FFFFFF">22,053 ns (Δ = +0,331 ns)</td><td align="right" bgcolor="#A8D08D">21,267 ns (Δ = -0,786 ns)</td><td align="right" bgcolor="#A8D08D">19,460 ns (Δ = -1,807 ns)</td><td align="right" bgcolor="#FFFFFF">20,000 ns (Δ = +0,540 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FF4949">0,022 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,022 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#A8D08D">0,021 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,019 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,020 μs (Δ = +0,001 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 53,236 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">249,118 ns</td><td align="right" bgcolor="#FF4949">297,700 ns (Δ = +48,582 ns)</td><td align="right" bgcolor="#A8D08D">246,969 ns (Δ = -50,731 ns)</td><td align="right" bgcolor="#FFFFFF">251,938 ns (Δ = +4,969 ns)</td><td align="right" bgcolor="#A8D08D">244,464 ns (Δ = -7,474 ns)</td><td align="right" bgcolor="#FFFFFF">249,530 ns (Δ = +5,066 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,249 μs</td><td align="right" bgcolor="#FF4949">0,298 μs (Δ = +0,049 μs)</td><td align="right" bgcolor="#A8D08D">0,247 μs (Δ = -0,051 μs)</td><td align="right" bgcolor="#FFFFFF">0,252 μs (Δ = +0,005 μs)</td><td align="right" bgcolor="#A8D08D">0,244 μs (Δ = -0,007 μs)</td><td align="right" bgcolor="#FFFFFF">0,250 μs (Δ = +0,005 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Δ: 6,840 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">41,298 ns</td><td align="right" bgcolor="#FFFFFF">42,020 ns (Δ = +0,722 ns)</td><td align="right" bgcolor="#FF4949">45,600 ns (Δ = +3,580 ns)</td><td align="right" bgcolor="#A8D08D">42,563 ns (Δ = -3,038 ns)</td><td align="right" bgcolor="#A8D08D">40,710 ns (Δ = -1,853 ns)</td><td align="right" bgcolor="#A8D08D">38,760 ns (Δ = -1,950 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#FF4949">0,046 μs (Δ = +0,004 μs)</td><td align="right" bgcolor="#A8D08D">0,043 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#A8D08D">0,041 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,039 μs (Δ = -0,002 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.2.0**

Slowest: 4.5.4

Δ: 5,172 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">130,053 ns</td><td align="right" bgcolor="#FFFFFF">131,842 ns (Δ = +1,789 ns)</td><td align="right" bgcolor="#FFFFFF">131,783 ns (Δ = -0,059 ns)</td><td align="right" bgcolor="#FFFFFF">131,929 ns (Δ = +0,146 ns)</td><td align="right" bgcolor="#FFFFFF">135,225 ns (Δ = +3,296 ns)</td><td align="right" bgcolor="#FFFFFF">131,818 ns (Δ = -3,407 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,130 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,132 μs (Δ = 0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,132 μs (Δ = +0,000 μs)</td><td align="right" bgcolor="#FFFFFF">0,135 μs (Δ = +0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,132 μs (Δ = -0,003 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.5.4**

Slowest: 4.5.0

Δ: 2,983 ns


<table>
<tr>
<th> </th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">34,197 ns</td><td align="right" bgcolor="#FF4949">35,807 ns (Δ = +1,609 ns)</td><td align="right" bgcolor="#A8D08D">32,823 ns (Δ = -2,983 ns)</td><td align="right" bgcolor="#FFFFFF">33,196 ns (Δ = +0,372 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FF4949">0,036 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,033 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,033 μs (Δ = +0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = +0,000 ms)</td></tr>
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

Fastest: **4.3.0**

Slowest: 4.4.0

Δ: 67,804 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">367,751 ns</td><td align="right" bgcolor="#FFFFFF">361,942 ns (Δ = -5,809 ns)</td><td align="right" bgcolor="#FF4949">429,747 ns (Δ = +67,804 ns)</td><td align="right" bgcolor="#A8D08D">372,545 ns (Δ = -57,202 ns)</td><td align="right" bgcolor="#FFFFFF">369,996 ns (Δ = -2,549 ns)</td><td align="right" bgcolor="#FFFFFF">363,690 ns (Δ = -6,306 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,368 μs</td><td align="right" bgcolor="#FFFFFF">0,362 μs (Δ = -0,006 μs)</td><td align="right" bgcolor="#FF4949">0,430 μs (Δ = +0,068 μs)</td><td align="right" bgcolor="#A8D08D">0,373 μs (Δ = -0,057 μs)</td><td align="right" bgcolor="#FFFFFF">0,370 μs (Δ = -0,003 μs)</td><td align="right" bgcolor="#FFFFFF">0,364 μs (Δ = -0,006 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.3.0**

Slowest: 4.5.4

Δ: 867,931 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2373,356 ns</td><td align="right" bgcolor="#A8D08D">2142,536 ns (Δ = -230,820 ns)</td><td align="right" bgcolor="#FF4949">2312,013 ns (Δ = +169,478 ns)</td><td align="right" bgcolor="#FF4949">2821,713 ns (Δ = +509,700 ns)</td><td align="right" bgcolor="#FF4949">3010,467 ns (Δ = +188,753 ns)</td><td align="right" bgcolor="#FFFFFF">2943,818 ns (Δ = -66,648 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,373 μs</td><td align="right" bgcolor="#A8D08D">2,143 μs (Δ = -0,231 μs)</td><td align="right" bgcolor="#FF4949">2,312 μs (Δ = +0,169 μs)</td><td align="right" bgcolor="#FF4949">2,822 μs (Δ = +0,510 μs)</td><td align="right" bgcolor="#FF4949">3,010 μs (Δ = +0,189 μs)</td><td align="right" bgcolor="#FFFFFF">2,944 μs (Δ = -0,067 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#A8D08D">0,002 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">668</td><td align="right">636</td><td align="right">636</td><td align="right">914</td><td align="right">914</td><td align="right">1062</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,652</td><td align="right">0,621</td><td align="right">0,621</td><td align="right">0,893</td><td align="right">0,893</td><td align="right">1,037</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **4.2.0**

Slowest: 4.4.0

Δ: 1102,973 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2175,917 ns</td><td align="right" bgcolor="#FFFFFF">2205,208 ns (Δ = +29,292 ns)</td><td align="right" bgcolor="#FF4949">3278,890 ns (Δ = +1073,682 ns)</td><td align="right" bgcolor="#A8D08D">3118,529 ns (Δ = -160,361 ns)</td><td align="right" bgcolor="#A8D08D">2851,889 ns (Δ = -266,640 ns)</td><td align="right" bgcolor="#FF4949">3040,970 ns (Δ = +189,081 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,176 μs</td><td align="right" bgcolor="#FFFFFF">2,205 μs (Δ = +0,029 μs)</td><td align="right" bgcolor="#FF4949">3,279 μs (Δ = +1,074 μs)</td><td align="right" bgcolor="#A8D08D">3,119 μs (Δ = -0,160 μs)</td><td align="right" bgcolor="#A8D08D">2,852 μs (Δ = -0,267 μs)</td><td align="right" bgcolor="#FF4949">3,041 μs (Δ = +0,189 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,003 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">668</td><td align="right">636</td><td align="right">636</td><td align="right">898</td><td align="right">898</td><td align="right">1045</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,652</td><td align="right">0,621</td><td align="right">0,621</td><td align="right">0,877</td><td align="right">0,877</td><td align="right">1,021</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **4.4.0**

Slowest: 4.5.0

Δ: 746,165 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2889,527 ns</td><td align="right" bgcolor="#FFFFFF">2928,425 ns (Δ = +38,898 ns)</td><td align="right" bgcolor="#FFFFFF">2862,555 ns (Δ = -65,870 ns)</td><td align="right" bgcolor="#FF4949">3608,720 ns (Δ = +746,165 ns)</td><td align="right" bgcolor="#A8D08D">3431,560 ns (Δ = -177,160 ns)</td><td align="right" bgcolor="#FF4949">3581,900 ns (Δ = +150,340 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,890 μs</td><td align="right" bgcolor="#FFFFFF">2,928 μs (Δ = +0,039 μs)</td><td align="right" bgcolor="#FFFFFF">2,863 μs (Δ = -0,066 μs)</td><td align="right" bgcolor="#FF4949">3,609 μs (Δ = +0,746 μs)</td><td align="right" bgcolor="#A8D08D">3,432 μs (Δ = -0,177 μs)</td><td align="right" bgcolor="#FF4949">3,582 μs (Δ = +0,150 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">931</td><td align="right">898</td><td align="right">898</td><td align="right">1324</td><td align="right">1324</td><td align="right">1471</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,909</td><td align="right">0,877</td><td align="right">0,877</td><td align="right">1,293</td><td align="right">1,293</td><td align="right">1,437</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **4.4.0**

Slowest: 5.0.0

Δ: 736,927 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3540,770 ns</td><td align="right" bgcolor="#A8D08D">3408,953 ns (Δ = -131,817 ns)</td><td align="right" bgcolor="#A8D08D">3293,967 ns (Δ = -114,987 ns)</td><td align="right" bgcolor="#FF4949">3994,780 ns (Δ = +700,813 ns)</td><td align="right" bgcolor="#FFFFFF">4010,910 ns (Δ = +16,130 ns)</td><td align="right" bgcolor="#FFFFFF">4030,893 ns (Δ = +19,983 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,541 μs</td><td align="right" bgcolor="#A8D08D">3,409 μs (Δ = -0,132 μs)</td><td align="right" bgcolor="#A8D08D">3,294 μs (Δ = -0,115 μs)</td><td align="right" bgcolor="#FF4949">3,995 μs (Δ = +0,701 μs)</td><td align="right" bgcolor="#FFFFFF">4,011 μs (Δ = +0,016 μs)</td><td align="right" bgcolor="#FFFFFF">4,031 μs (Δ = +0,020 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,003 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,004 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,004 ms (Δ = +0,000 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">1127</td><td align="right">1111</td><td align="right">1111</td><td align="right">1520</td><td align="right">1520</td><td align="right">1684</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,101</td><td align="right">1,085</td><td align="right">1,085</td><td align="right">1,484</td><td align="right">1,484</td><td align="right">1,645</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,002</td></tr>
</table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 13120,182 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">27814,271 ns</td><td align="right" bgcolor="#FFFFFF">27057,140 ns (Δ = -757,131 ns)</td><td align="right" bgcolor="#A8D08D">26240,741 ns (Δ = -816,399 ns)</td><td align="right" bgcolor="#FFFFFF">25729,050 ns (Δ = -511,691 ns)</td><td align="right" bgcolor="#FF4949">27927,382 ns (Δ = +2198,332 ns)</td><td align="right" bgcolor="#A8D08D">14807,200 ns (Δ = -13120,182 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">27,814 μs</td><td align="right" bgcolor="#FFFFFF">27,057 μs (Δ = -0,757 μs)</td><td align="right" bgcolor="#A8D08D">26,241 μs (Δ = -0,816 μs)</td><td align="right" bgcolor="#FFFFFF">25,729 μs (Δ = -0,512 μs)</td><td align="right" bgcolor="#FF4949">27,927 μs (Δ = +2,198 μs)</td><td align="right" bgcolor="#A8D08D">14,807 μs (Δ = -13,120 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,028 ms</td><td align="right" bgcolor="#FFFFFF">0,027 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#A8D08D">0,026 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,026 ms (Δ = -0,001 ms)</td><td align="right" bgcolor="#FF4949">0,028 ms (Δ = +0,002 ms)</td><td align="right" bgcolor="#A8D08D">0,015 ms (Δ = -0,013 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">7580</td><td align="right">7677</td><td align="right">7676</td><td align="right">7572</td><td align="right">7565</td><td align="right">5995</td><tr>
<td>Allocated Kilobytes</td><td align="right">7,402</td><td align="right">7,497</td><td align="right">7,496</td><td align="right">7,395</td><td align="right">7,388</td><td align="right">5,854</td><tr>
<td>Allocated Megabytes</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,007</td><td align="right">0,006</td></tr>
</table>


## <a name="WeakEventListener_Benchmark"></a>WeakEventListener_Benchmark

### <a name="WeakEventListener_Benchmark_CollectionChanged_Notification"></a>CollectionChanged_Notification

#### Performance

Fastest: **5.0.0**

Slowest: 4.2.0

Δ: 28,622 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">145,120 ns</td><td align="right" bgcolor="#A8D08D">133,387 ns (Δ = -11,733 ns)</td><td align="right" bgcolor="#FFFFFF">135,729 ns (Δ = +2,342 ns)</td><td align="right" bgcolor="#A8D08D">126,515 ns (Δ = -9,214 ns)</td><td align="right" bgcolor="#FF4949">133,280 ns (Δ = +6,765 ns)</td><td align="right" bgcolor="#A8D08D">116,498 ns (Δ = -16,782 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#A8D08D">0,133 μs (Δ = -0,012 μs)</td><td align="right" bgcolor="#FFFFFF">0,136 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,127 μs (Δ = -0,009 μs)</td><td align="right" bgcolor="#FF4949">0,133 μs (Δ = +0,007 μs)</td><td align="right" bgcolor="#A8D08D">0,116 μs (Δ = -0,017 μs)</td></tr>
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
<td>Allocated Bytes</td><td align="right">181</td><td align="right">184</td><td align="right">184</td><td align="right">184</td><td align="right">184</td><td align="right">184</td><tr>
<td>Allocated Kilobytes</td><td align="right">0,177</td><td align="right">0,180</td><td align="right">0,180</td><td align="right">0,180</td><td align="right">0,180</td><td align="right">0,180</td><tr>
<td>Allocated Megabytes</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td><td align="right">0,000</td></tr>
</table>


### <a name="WeakEventListener_Benchmark_GenericEvent_Notification"></a>GenericEvent_Notification

#### Performance

Fastest: **4.5.4**

Slowest: 4.3.0

Δ: 2,290 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,342 ns</td><td align="right" bgcolor="#FF4949">31,107 ns (Δ = +1,765 ns)</td><td align="right" bgcolor="#A8D08D">28,847 ns (Δ = -2,260 ns)</td><td align="right" bgcolor="#FF4949">30,760 ns (Δ = +1,913 ns)</td><td align="right" bgcolor="#A8D08D">28,817 ns (Δ = -1,943 ns)</td><td align="right" bgcolor="#FFFFFF">29,340 ns (Δ = +0,523 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FF4949">0,031 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,029 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FF4949">0,031 μs (Δ = +0,002 μs)</td><td align="right" bgcolor="#A8D08D">0,029 μs (Δ = -0,002 μs)</td><td align="right" bgcolor="#FFFFFF">0,029 μs (Δ = +0,001 μs)</td></tr>
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


### <a name="WeakEventListener_Benchmark_PropertyChanged_Notification"></a>PropertyChanged_Notification

#### Performance

Fastest: **4.4.0**

Slowest: 4.2.0

Δ: 1,649 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,767 ns</td><td align="right" bgcolor="#A8D08D">5,996 ns (Δ = -0,771 ns)</td><td align="right" bgcolor="#A8D08D">5,118 ns (Δ = -0,878 ns)</td><td align="right" bgcolor="#FF4949">6,298 ns (Δ = +1,180 ns)</td><td align="right" bgcolor="#A8D08D">5,380 ns (Δ = -0,918 ns)</td><td align="right" bgcolor="#A8D08D">5,167 ns (Δ = -0,213 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#A8D08D">0,006 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,005 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#FF4949">0,006 μs (Δ = +0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,005 μs (Δ = -0,001 μs)</td><td align="right" bgcolor="#A8D08D">0,005 μs (Δ = 0,000 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FF4949">0,000 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,000 ms (Δ = 0,000 ms)</td></tr>
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

Fastest: **4.3.0**

Slowest: 4.5.0

Δ: 1214,876 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17673,407 ns</td><td align="right" bgcolor="#FFFFFF">17215,600 ns (Δ = -457,807 ns)</td><td align="right" bgcolor="#FFFFFF">17552,604 ns (Δ = +337,004 ns)</td><td align="right" bgcolor="#FF4949">18430,476 ns (Δ = +877,872 ns)</td><td align="right" bgcolor="#FFFFFF">18293,441 ns (Δ = -137,034 ns)</td><td align="right" bgcolor="#A8D08D">17426,210 ns (Δ = -867,231 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">17,673 μs</td><td align="right" bgcolor="#FFFFFF">17,216 μs (Δ = -0,458 μs)</td><td align="right" bgcolor="#FFFFFF">17,553 μs (Δ = +0,337 μs)</td><td align="right" bgcolor="#FF4949">18,430 μs (Δ = +0,878 μs)</td><td align="right" bgcolor="#FFFFFF">18,293 μs (Δ = -0,137 μs)</td><td align="right" bgcolor="#A8D08D">17,426 μs (Δ = -0,867 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,017 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,018 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FF4949">0,018 ms (Δ = +0,001 ms)</td><td align="right" bgcolor="#FFFFFF">0,018 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,017 ms (Δ = -0,001 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">1232</td><td align="right">1232</td><td align="right">1232</td><td align="right">1232</td><td align="right">1232</td><td align="right">1232</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,203</td><td align="right">1,203</td><td align="right">1,203</td><td align="right">1,203</td><td align="right">1,203</td><td align="right">1,203</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


### <a name="WeakEventListener_Benchmark_SubscribeToWeakPropertyChangedEvent"></a>SubscribeToWeakPropertyChangedEvent

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.0

Δ: 1094,687 ns


<table>
<tr>
<th> </th><th>4.2.0</th><th>4.3.0</th><th>4.4.0</th><th>4.5.0</th><th>4.5.4</th><th>5.0.0</th></tr>
<tr>
<td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18951,453 ns</td><td align="right" bgcolor="#FFFFFF">19079,010 ns (Δ = +127,557 ns)</td><td align="right" bgcolor="#FFFFFF">18848,500 ns (Δ = -230,510 ns)</td><td align="right" bgcolor="#FFFFFF">19164,767 ns (Δ = +316,267 ns)</td><td align="right" bgcolor="#FFFFFF">18824,810 ns (Δ = -339,957 ns)</td><td align="right" bgcolor="#A8D08D">18070,080 ns (Δ = -754,730 ns)</td></tr>
<tr>
<td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">18,951 μs</td><td align="right" bgcolor="#FFFFFF">19,079 μs (Δ = +0,128 μs)</td><td align="right" bgcolor="#FFFFFF">18,849 μs (Δ = -0,231 μs)</td><td align="right" bgcolor="#FFFFFF">19,165 μs (Δ = +0,316 μs)</td><td align="right" bgcolor="#FFFFFF">18,825 μs (Δ = -0,340 μs)</td><td align="right" bgcolor="#A8D08D">18,070 μs (Δ = -0,755 μs)</td></tr>
<tr>
<td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,019 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,019 ms (Δ = +0,000 ms)</td><td align="right" bgcolor="#FFFFFF">0,019 ms (Δ = 0,000 ms)</td><td align="right" bgcolor="#A8D08D">0,018 ms (Δ = -0,001 ms)</td></tr>
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
<td>Allocated Bytes</td><td align="right">1232</td><td align="right">1232</td><td align="right">1232</td><td align="right">1232</td><td align="right">1232</td><td align="right">1232</td><tr>
<td>Allocated Kilobytes</td><td align="right">1,203</td><td align="right">1,203</td><td align="right">1,203</td><td align="right">1,203</td><td align="right">1,203</td><td align="right">1,203</td><tr>
<td>Allocated Megabytes</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td><td align="right">0,001</td></tr>
</table>


