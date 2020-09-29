# Benchmarks

Benchmark report generated on 29-sep-2020 14:51

Running the benchmarks took 05:22:05.2247647

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


If versions behave the same (e.g. result in exactly the same values), this report will show the highest version to represent the most recent state at best.
If a higher version is at least 3% slower than the previous one, it will have a red background. If it is at least 3% faster, it will have a green background.

## Host environment information

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042

Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores

.NET Core SDK=5.0.100-preview.8.20417.9



## Important benchmarks

### High priority (current version slower than previous one)

26 item(s)

1. [LanguageHelper_Benchmark::GetString](#LanguageHelper_Benchmark_GetString) v5.12.0 is **825,38%** (Δ: 2451,703 ns) slower than v5.9.0

2. [ResourceHelper_Benchmark::GetString](#ResourceHelper_Benchmark_GetString) v5.12.0 is **748,94%** (Δ: 2278,183 ns) slower than v5.9.0

3. [ScopeManager_Benchmark::Get_Existing_ScopeManager](#ScopeManager_Benchmark_Get_Existing_ScopeManager) v5.12.0 is **470,92%** (Δ: 461,029 ns) slower than v5.9.0

4. [ScopeManager_Benchmark::Get_New_ScopeManager](#ScopeManager_Benchmark_Get_New_ScopeManager) v5.12.0 is **465,44%** (Δ: 457,143 ns) slower than v5.9.0

5. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Instance](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance) v5.12.0 is **80,15%** (Δ: 2356,768 ns) slower than v5.9.0

6. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static) v5.12.0 is **62,29%** (Δ: 2076,572 ns) slower than v5.9.0

7. [ExpressionHelper_Benchmark::GetPropertyName](#ExpressionHelper_Benchmark_GetPropertyName) v5.12.0 is **53,25%** (Δ: 1269,864 ns) slower than v5.9.0

8. [ExpressionHelper_Benchmark::GetOwner](#ExpressionHelper_Benchmark_GetOwner) v5.12.0 is **52,95%** (Δ: 502,972 ns) slower than v5.9.0

9. [ViewModelBase_Benchmark::Construction](#ViewModelBase_Benchmark_Construction) v5.12.0 is **47,26%** (Δ: 6900,523 ns) slower than v5.9.0

10. [Type_ReflectionExtensions_Benchmark::IsInstanceOfTypeEx](#Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx) v5.12.0 is **24,99%** (Δ: 3197,132 ns) slower than v5.9.0

11. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_1000](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000) v5.12.0 is **24,57%** (Δ: 133697,602 ns) slower than v5.9.0

12. [Type_ReflectionExtensions_Benchmark::GetPropertyEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags) v5.12.0 is **21,19%** (Δ: 362,855 ns) slower than v5.9.0

13. [Attribute_ReflectionExtensions_Benchmark::GetAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type) v5.12.0 is **17,86%** (Δ: 282,254 ns) slower than v5.9.0

14. [Type_ReflectionExtensions_Benchmark::GetEventEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags) v5.12.0 is **17,56%** (Δ: 295,082 ns) slower than v5.9.0

15. [Enum_Benchmark::ToList](#Enum_Benchmark_ToList) v5.12.0 is **17,34%** (Δ: 410,581 ns) slower than v5.9.0

16. [Attribute_ReflectionExtensions_Benchmark::GetAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type) v5.12.0 is **16,84%** (Δ: 268,347 ns) slower than v5.9.0

17. [Attribute_ReflectionExtensions_Benchmark::IsDecoratedWithAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type) v5.12.0 is **15,77%** (Δ: 255,677 ns) slower than v5.9.0

18. [Serialization_Binary_Benchmark::SerializeLevel3Models](#Serialization_Binary_Benchmark_SerializeLevel3Models) v5.12.0 is **13,78%** (Δ: 115073,495 ns) slower than v5.9.0

19. [AssemblyExtensions_Benchmark::GetBuildDateTime](#AssemblyExtensions_Benchmark_GetBuildDateTime) v5.12.0 is **10,67%** (Δ: 26520,313 ns) slower than v5.9.0

20. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_100](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100) v5.12.0 is **8,66%** (Δ: 194113,789 ns) slower than v5.9.0

21. [ServiceLocator_Benchmark::ResolveType_With_Transient_Dependency](#ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency) v5.12.0 is **8,54%** (Δ: 387,565 ns) slower than v5.9.0

22. [AssemblyExtensions_Benchmark::InformationalVersion](#AssemblyExtensions_Benchmark_InformationalVersion) v5.12.0 is **7,32%** (Δ: 294,688 ns) slower than v5.9.0

23. [AssemblyExtensions_Benchmark::Company](#AssemblyExtensions_Benchmark_Company) v5.12.0 is **5,74%** (Δ: 282,283 ns) slower than v5.9.0

24. [AssemblyExtensions_Benchmark::Title](#AssemblyExtensions_Benchmark_Title) v5.12.0 is **5,19%** (Δ: 251,286 ns) slower than v5.9.0

25. [Serialization_Binary_Benchmark::SerializeLevel2Models](#Serialization_Binary_Benchmark_SerializeLevel2Models) v5.12.0 is **4,25%** (Δ: 14213,411 ns) slower than v5.9.0

Skipping 1 items since maximum list length is 25


### Improved (current version faster than previous one)

28 item(s)

1. [Type_ReflectionExtensions_Benchmark::IsCatelType](#Type_ReflectionExtensions_Benchmark_IsCatelType) v5.12.0 is **62,19%** (Δ: -383,928 ns) faster than v5.9.0

2. [Type_ReflectionExtensions_Benchmark::GetParentTypes](#Type_ReflectionExtensions_Benchmark_GetParentTypes) v5.12.0 is **50,89%** (Δ: -516,771 ns) faster than v5.9.0

3. [Serialization_Xml_Benchmark::SerializeLevel3Models](#Serialization_Xml_Benchmark_SerializeLevel3Models) v5.12.0 is **46,53%** (Δ: -823633,774 ns) faster than v5.9.0

4. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType__Inheritd](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd) v5.12.0 is **44,81%** (Δ: -479,548 ns) faster than v5.9.0

5. [Type_ReflectionExtensions_Benchmark::GetCustomAttributeEx](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx) v5.12.0 is **43,75%** (Δ: -1429,967 ns) faster than v5.9.0

6. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.12.0 is **43,64%** (Δ: -1926,285 ns) faster than v5.9.0

7. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_Inherit](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit) v5.12.0 is **43,60%** (Δ: -385,893 ns) faster than v5.9.0

8. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v5.12.0 is **41,82%** (Δ: -406,931 ns) faster than v5.9.0

9. [Type_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v5.12.0 is **40,99%** (Δ: -4037,493 ns) faster than v5.9.0

10. [Type_ReflectionExtensions_Benchmark::GetCustomAttributesEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit) v5.12.0 is **38,17%** (Δ: -3644,789 ns) faster than v5.9.0

11. [Serialization_Xml_Benchmark::SerializeComplexObjectGraph](#Serialization_Xml_Benchmark_SerializeComplexObjectGraph) v5.12.0 is **37,85%** (Δ: -318255,953 ns) faster than v5.9.0

12. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit) v5.12.0 is **37,74%** (Δ: -2659,731 ns) faster than v5.9.0

13. [ViewModelBase_Benchmark::ModelPropertyMappings](#ViewModelBase_Benchmark_ModelPropertyMappings) v5.9.0 is **37,33%** (Δ: -17438,146 ns) faster than v5.6.0

14. [Type_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.12.0 is **35,68%** (Δ: -1010,867 ns) faster than v5.9.0

15. [ValidationContext_Benchmark::GetWarningCount](#ValidationContext_Benchmark_GetWarningCount) v5.12.0 is **33,31%** (Δ: -363,162 ns) faster than v5.9.0

16. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType) v5.12.0 is **30,60%** (Δ: -1012,190 ns) faster than v5.9.0

17. [Serialization_Xml_Benchmark::SerializeLevel2Models](#Serialization_Xml_Benchmark_SerializeLevel2Models) v5.12.0 is **28,76%** (Δ: -151480,858 ns) faster than v5.9.0

18. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx) v5.12.0 is **28,73%** (Δ: -833,477 ns) faster than v5.9.0

19. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType__Inheritd](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd) v5.12.0 is **28,23%** (Δ: -1454,508 ns) faster than v5.9.0

20. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType) v5.12.0 is **26,95%** (Δ: -805,652 ns) faster than v5.9.0

21. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v5.12.0 is **24,34%** (Δ: -1213,414 ns) faster than v5.9.0

22. [Serialization_Xml_Benchmark::SerializeLevel1Models](#Serialization_Xml_Benchmark_SerializeLevel1Models) v5.12.0 is **20,22%** (Δ: -59992,987 ns) faster than v5.9.0

23. [AssemblyExtensions_Benchmark::Copyright](#AssemblyExtensions_Benchmark_Copyright) v5.12.0 is **13,38%** (Δ: -806,072 ns) faster than v5.9.0

24. [Serialization_Json_Benchmark::SerializeLevel1Models](#Serialization_Json_Benchmark_SerializeLevel1Models) v5.12.0 is **5,64%** (Δ: -42211,426 ns) faster than v5.9.0

25. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_500](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500) v5.12.0 is **4,05%** (Δ: -29320,987 ns) faster than v5.9.0

Skipping 3 items since maximum list length is 25


## <a name="Argument_Benchmark"></a>Argument_Benchmark

### <a name="Argument_Benchmark_ImplementsInterface"></a>ImplementsInterface

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 23,394 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">93,914 ns</td><td align="right" bgcolor="#FFFFFF">93,125 ns</td><td align="right" bgcolor="#FFFFFF">73,047 ns</td><td align="right" bgcolor="#FFFFFF">70,520 ns</td><td align="right" bgcolor="#FFFFFF">71,502 ns</td><td align="right" bgcolor="#FFFFFF">73,907 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 16,727 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">83,369 ns</td><td align="right" bgcolor="#FFFFFF">85,912 ns</td><td align="right" bgcolor="#FFFFFF">69,300 ns</td><td align="right" bgcolor="#FFFFFF">69,184 ns</td><td align="right" bgcolor="#FFFFFF">75,755 ns</td><td align="right" bgcolor="#FFFFFF">79,523 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 15,680 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">82,354 ns</td><td align="right" bgcolor="#FFFFFF">77,230 ns</td><td align="right" bgcolor="#FFFFFF">70,813 ns</td><td align="right" bgcolor="#FFFFFF">66,674 ns</td><td align="right" bgcolor="#FFFFFF">73,342 ns</td><td align="right" bgcolor="#FFFFFF">69,867 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 15,797 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">87,453 ns</td><td align="right" bgcolor="#FFFFFF">71,655 ns</td><td align="right" bgcolor="#FFFFFF">78,904 ns</td><td align="right" bgcolor="#FFFFFF">78,254 ns</td><td align="right" bgcolor="#FFFFFF">73,796 ns</td><td align="right" bgcolor="#FFFFFF">75,027 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 11,876 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31,464 ns</td><td align="right" bgcolor="#FFFFFF">26,355 ns</td><td align="right" bgcolor="#FFFFFF">37,851 ns</td><td align="right" bgcolor="#FFFFFF">25,975 ns</td><td align="right" bgcolor="#FFFFFF">30,513 ns</td><td align="right" bgcolor="#FFFFFF">31,251 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Generic"></a>InheritsFrom_Generic

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 7,217 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">36,764 ns</td><td align="right" bgcolor="#FFFFFF">29,546 ns</td><td align="right" bgcolor="#FFFFFF">34,333 ns</td><td align="right" bgcolor="#FFFFFF">32,057 ns</td><td align="right" bgcolor="#FFFFFF">34,486 ns</td><td align="right" bgcolor="#FFFFFF">30,555 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Object"></a>InheritsFrom_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 9,862 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">40,109 ns</td><td align="right" bgcolor="#FFFFFF">30,247 ns</td><td align="right" bgcolor="#FFFFFF">32,132 ns</td><td align="right" bgcolor="#FFFFFF">32,747 ns</td><td align="right" bgcolor="#FFFFFF">35,586 ns</td><td align="right" bgcolor="#FFFFFF">33,541 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsMatch"></a>IsMatch

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 78,379 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">584,446 ns</td><td align="right" bgcolor="#FFFFFF">584,680 ns</td><td align="right" bgcolor="#FFFFFF">567,531 ns</td><td align="right" bgcolor="#FFFFFF">561,863 ns</td><td align="right" bgcolor="#FFFFFF">578,658 ns</td><td align="right" bgcolor="#FFFFFF">506,301 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,584 μs</td><td align="right" bgcolor="#FFFFFF">0,585 μs</td><td align="right" bgcolor="#FFFFFF">0,568 μs</td><td align="right" bgcolor="#FFFFFF">0,562 μs</td><td align="right" bgcolor="#FFFFFF">0,579 μs</td><td align="right" bgcolor="#FFFFFF">0,506 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#A8D08D">321,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#A8D08D">0,313 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsMaximum"></a>IsMaximum

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 2,679 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,151 ns</td><td align="right" bgcolor="#FFFFFF">9,472 ns</td><td align="right" bgcolor="#FFFFFF">10,217 ns</td><td align="right" bgcolor="#FFFFFF">10,196 ns</td><td align="right" bgcolor="#FFFFFF">10,575 ns</td><td align="right" bgcolor="#FFFFFF">9,955 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 4,991 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,582 ns</td><td align="right" bgcolor="#FFFFFF">11,000 ns</td><td align="right" bgcolor="#FFFFFF">15,991 ns</td><td align="right" bgcolor="#FFFFFF">11,776 ns</td><td align="right" bgcolor="#FFFFFF">11,164 ns</td><td align="right" bgcolor="#FFFFFF">11,637 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 0,659 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,526 ns</td><td align="right" bgcolor="#FFFFFF">3,015 ns</td><td align="right" bgcolor="#FFFFFF">3,273 ns</td><td align="right" bgcolor="#FFFFFF">3,140 ns</td><td align="right" bgcolor="#FFFFFF">3,675 ns</td><td align="right" bgcolor="#FFFFFF">3,141 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotMatch"></a>IsNotMatch

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 139,538 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">484,907 ns</td><td align="right" bgcolor="#FFFFFF">487,439 ns</td><td align="right" bgcolor="#FFFFFF">454,836 ns</td><td align="right" bgcolor="#FFFFFF">443,010 ns</td><td align="right" bgcolor="#FFFFFF">463,642 ns</td><td align="right" bgcolor="#FFFFFF">347,901 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,485 μs</td><td align="right" bgcolor="#FFFFFF">0,487 μs</td><td align="right" bgcolor="#FFFFFF">0,455 μs</td><td align="right" bgcolor="#FFFFFF">0,443 μs</td><td align="right" bgcolor="#FFFFFF">0,464 μs</td><td align="right" bgcolor="#FFFFFF">0,348 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#A8D08D">321,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#A8D08D">0,313 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsNotNull"></a>IsNotNull

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 1,045 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,306 ns</td><td align="right" bgcolor="#FFFFFF">1,382 ns</td><td align="right" bgcolor="#FFFFFF">1,429 ns</td><td align="right" bgcolor="#FFFFFF">0,952 ns</td><td align="right" bgcolor="#FFFFFF">1,150 ns</td><td align="right" bgcolor="#FFFFFF">0,384 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 0,828 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,025 ns</td><td align="right" bgcolor="#FFFFFF">1,443 ns</td><td align="right" bgcolor="#FFFFFF">1,492 ns</td><td align="right" bgcolor="#FFFFFF">1,238 ns</td><td align="right" bgcolor="#FFFFFF">1,032 ns</td><td align="right" bgcolor="#FFFFFF">0,664 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty_Guid"></a>IsNotNullOrEmpty_Guid

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 1,595 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,910 ns</td><td align="right" bgcolor="#FFFFFF">7,315 ns</td><td align="right" bgcolor="#FFFFFF">8,068 ns</td><td align="right" bgcolor="#FFFFFF">7,893 ns</td><td align="right" bgcolor="#FFFFFF">7,949 ns</td><td align="right" bgcolor="#FFFFFF">7,611 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmptyArray"></a>IsNotNullOrEmptyArray

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 1,323 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,766 ns</td><td align="right" bgcolor="#FFFFFF">2,637 ns</td><td align="right" bgcolor="#FFFFFF">2,658 ns</td><td align="right" bgcolor="#FFFFFF">3,664 ns</td><td align="right" bgcolor="#FFFFFF">2,342 ns</td><td align="right" bgcolor="#FFFFFF">2,452 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrWhitespace"></a>IsNotNullOrWhitespace

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 6,318 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,994 ns</td><td align="right" bgcolor="#FFFFFF">8,622 ns</td><td align="right" bgcolor="#FFFFFF">8,834 ns</td><td align="right" bgcolor="#FFFFFF">10,441 ns</td><td align="right" bgcolor="#FFFFFF">4,123 ns</td><td align="right" bgcolor="#FFFFFF">4,152 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes"></a>IsNotOfOneOfTheTypes

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 9,165 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">62,047 ns</td><td align="right" bgcolor="#FFFFFF">60,536 ns</td><td align="right" bgcolor="#FFFFFF">56,516 ns</td><td align="right" bgcolor="#FFFFFF">55,607 ns</td><td align="right" bgcolor="#FFFFFF">64,772 ns</td><td align="right" bgcolor="#FFFFFF">60,536 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes_Object"></a>IsNotOfOneOfTheTypes_Object

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 27,829 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">65,235 ns</td><td align="right" bgcolor="#FFFFFF">86,035 ns</td><td align="right" bgcolor="#FFFFFF">59,703 ns</td><td align="right" bgcolor="#FFFFFF">58,206 ns</td><td align="right" bgcolor="#FFFFFF">63,098 ns</td><td align="right" bgcolor="#FFFFFF">65,131 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,060 μs</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType"></a>IsNotOfType

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 7,582 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">43,765 ns</td><td align="right" bgcolor="#FFFFFF">36,183 ns</td><td align="right" bgcolor="#FFFFFF">39,868 ns</td><td align="right" bgcolor="#FFFFFF">38,292 ns</td><td align="right" bgcolor="#FFFFFF">38,266 ns</td><td align="right" bgcolor="#FFFFFF">43,325 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType_Object"></a>IsNotOfType_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 10,094 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">52,483 ns</td><td align="right" bgcolor="#FFFFFF">42,389 ns</td><td align="right" bgcolor="#FFFFFF">47,936 ns</td><td align="right" bgcolor="#FFFFFF">42,513 ns</td><td align="right" bgcolor="#FFFFFF">45,591 ns</td><td align="right" bgcolor="#FFFFFF">45,496 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOutOfRange"></a>IsNotOutOfRange

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 2,168 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,451 ns</td><td align="right" bgcolor="#FFFFFF">17,592 ns</td><td align="right" bgcolor="#FFFFFF">16,707 ns</td><td align="right" bgcolor="#FFFFFF">16,283 ns</td><td align="right" bgcolor="#FFFFFF">17,172 ns</td><td align="right" bgcolor="#FFFFFF">17,827 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">51,000</td><td align="right" bgcolor="#FFFFFF">51,000</td><td align="right" bgcolor="#FFFFFF">51,000</td><td align="right" bgcolor="#FFFFFF">51,000</td><td align="right" bgcolor="#FFFFFF">51,000</td><td align="right" bgcolor="#A8D08D">49,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,050</td><td align="right" bgcolor="#FFFFFF">0,050</td><td align="right" bgcolor="#FFFFFF">0,050</td><td align="right" bgcolor="#FFFFFF">0,050</td><td align="right" bgcolor="#FFFFFF">0,050</td><td align="right" bgcolor="#A8D08D">0,048 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes"></a>IsOfOneOfTheTypes

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 5,630 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">44,464 ns</td><td align="right" bgcolor="#FFFFFF">38,834 ns</td><td align="right" bgcolor="#FFFFFF">43,599 ns</td><td align="right" bgcolor="#FFFFFF">39,201 ns</td><td align="right" bgcolor="#FFFFFF">41,266 ns</td><td align="right" bgcolor="#FFFFFF">39,600 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfOneOfTheTypes_Object"></a>IsOfOneOfTheTypes_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 16,590 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">48,854 ns</td><td align="right" bgcolor="#FFFFFF">44,294 ns</td><td align="right" bgcolor="#FFFFFF">60,884 ns</td><td align="right" bgcolor="#FFFFFF">46,776 ns</td><td align="right" bgcolor="#FFFFFF">48,712 ns</td><td align="right" bgcolor="#FFFFFF">46,411 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType"></a>IsOfType

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 3,377 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,572 ns</td><td align="right" bgcolor="#FFFFFF">26,770 ns</td><td align="right" bgcolor="#FFFFFF">27,365 ns</td><td align="right" bgcolor="#FFFFFF">26,933 ns</td><td align="right" bgcolor="#FFFFFF">27,423 ns</td><td align="right" bgcolor="#FFFFFF">26,195 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType_Object"></a>IsOfType_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 1,664 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35,296 ns</td><td align="right" bgcolor="#FFFFFF">33,632 ns</td><td align="right" bgcolor="#FFFFFF">33,984 ns</td><td align="right" bgcolor="#FFFFFF">34,181 ns</td><td align="right" bgcolor="#FFFFFF">33,851 ns</td><td align="right" bgcolor="#FFFFFF">33,813 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="Assembly_ReflectionExtensions_Benchmark"></a>Assembly_ReflectionExtensions_Benchmark

### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 1006,382 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5133,303 ns</td><td align="right" bgcolor="#A8D08D">4230,198 ns (Δ = -903,104 ns)</td><td align="right" bgcolor="#FFFFFF">4132,635 ns</td><td align="right" bgcolor="#FFFFFF">4178,021 ns</td><td align="right" bgcolor="#FFFFFF">4126,921 ns</td><td align="right" bgcolor="#FFFFFF">4154,272 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,133 μs</td><td align="right" bgcolor="#FFFFFF">4,230 μs</td><td align="right" bgcolor="#FFFFFF">4,133 μs</td><td align="right" bgcolor="#FFFFFF">4,178 μs</td><td align="right" bgcolor="#FFFFFF">4,127 μs</td><td align="right" bgcolor="#FFFFFF">4,154 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#A8D08D">731,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#A8D08D">0,714 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 849,534 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4895,273 ns</td><td align="right" bgcolor="#A8D08D">4144,588 ns (Δ = -750,685 ns)</td><td align="right" bgcolor="#FFFFFF">4076,323 ns</td><td align="right" bgcolor="#FFFFFF">4148,356 ns</td><td align="right" bgcolor="#FFFFFF">4045,740 ns</td><td align="right" bgcolor="#FFFFFF">4293,789 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,895 μs</td><td align="right" bgcolor="#FFFFFF">4,145 μs</td><td align="right" bgcolor="#FFFFFF">4,076 μs</td><td align="right" bgcolor="#FFFFFF">4,148 μs</td><td align="right" bgcolor="#FFFFFF">4,046 μs</td><td align="right" bgcolor="#FFFFFF">4,294 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#A8D08D">731,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#A8D08D">0,714 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 2328,618 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,7 %</td><td align="right" bgcolor="#A8D08D">-19,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12086,715 ns</td><td align="right" bgcolor="#A8D08D">10520,181 ns (Δ = -1566,534 ns)</td><td align="right" bgcolor="#FFFFFF">10520,448 ns</td><td align="right" bgcolor="#FF4949">12175,267 ns (Δ = +1654,819 ns)</td><td align="right" bgcolor="#A8D08D">9846,649 ns (Δ = -2328,618 ns)</td><td align="right" bgcolor="#FFFFFF">9864,800 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">12,087 μs</td><td align="right" bgcolor="#FFFFFF">10,520 μs</td><td align="right" bgcolor="#FFFFFF">10,520 μs</td><td align="right" bgcolor="#FFFFFF">12,175 μs</td><td align="right" bgcolor="#FFFFFF">9,847 μs</td><td align="right" bgcolor="#FFFFFF">9,865 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#A8D08D">-2,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1414,000</td><td align="right" bgcolor="#FFFFFF">1414,000</td><td align="right" bgcolor="#FFFFFF">1414,000</td><td align="right" bgcolor="#FFFFFF">1414,000</td><td align="right" bgcolor="#A8D08D">1413,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">1383,000 (Δ = -30,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,381</td><td align="right" bgcolor="#FFFFFF">1,381</td><td align="right" bgcolor="#FFFFFF">1,381</td><td align="right" bgcolor="#FFFFFF">1,381</td><td align="right" bgcolor="#A8D08D">1,380 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">1,351 (Δ = -0,029)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 1532,083 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,4 %</td><td align="right" bgcolor="#FF4949">+7,8 %</td><td align="right" bgcolor="#FF4949">+8,8 %</td><td align="right" bgcolor="#A8D08D">-16,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5864,408 ns</td><td align="right" bgcolor="#A8D08D">4433,528 ns (Δ = -1430,880 ns)</td><td align="right" bgcolor="#FF4949">4777,780 ns (Δ = +344,253 ns)</td><td align="right" bgcolor="#FF4949">5196,656 ns (Δ = +418,875 ns)</td><td align="right" bgcolor="#A8D08D">4332,326 ns (Δ = -864,330 ns)</td><td align="right" bgcolor="#FFFFFF">4441,299 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,864 μs</td><td align="right" bgcolor="#FFFFFF">4,434 μs</td><td align="right" bgcolor="#FFFFFF">4,778 μs</td><td align="right" bgcolor="#FFFFFF">5,197 μs</td><td align="right" bgcolor="#FFFFFF">4,332 μs</td><td align="right" bgcolor="#FFFFFF">4,441 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-2,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3115,000</td><td align="right" bgcolor="#FFFFFF">3115,000</td><td align="right" bgcolor="#FFFFFF">3115,000</td><td align="right" bgcolor="#FFFFFF">3115,000</td><td align="right" bgcolor="#A8D08D">3114,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">3053,000 (Δ = -61,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,042</td><td align="right" bgcolor="#FFFFFF">3,042</td><td align="right" bgcolor="#FFFFFF">3,042</td><td align="right" bgcolor="#FFFFFF">3,042</td><td align="right" bgcolor="#A8D08D">3,041 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">2,981 (Δ = -0,060)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,000)</td></tr></table>


## <a name="AssemblyExtensions_Benchmark"></a>AssemblyExtensions_Benchmark

### <a name="AssemblyExtensions_Benchmark_Company"></a>Company

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 1610,110 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,9 %</td><td align="right" bgcolor="#A8D08D">-24,4 %</td><td align="right" bgcolor="#FF4949">+5,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5550,245 ns</td><td align="right" bgcolor="#A8D08D">4900,317 ns (Δ = -649,928 ns)</td><td align="right" bgcolor="#FFFFFF">4889,294 ns</td><td align="right" bgcolor="#FF4949">6499,404 ns (Δ = +1610,110 ns)</td><td align="right" bgcolor="#A8D08D">4914,491 ns (Δ = -1584,913 ns)</td><td align="right" bgcolor="#FF4949">5196,773 ns (Δ = +282,283 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,550 μs</td><td align="right" bgcolor="#FFFFFF">4,900 μs</td><td align="right" bgcolor="#FFFFFF">4,889 μs</td><td align="right" bgcolor="#FFFFFF">6,499 μs</td><td align="right" bgcolor="#FFFFFF">4,914 μs</td><td align="right" bgcolor="#FFFFFF">5,197 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">840,000</td><td align="right" bgcolor="#FFFFFF">840,000</td><td align="right" bgcolor="#FFFFFF">840,000</td><td align="right" bgcolor="#FFFFFF">840,000</td><td align="right" bgcolor="#FFFFFF">840,000</td><td align="right" bgcolor="#FF4949">862,000 (Δ = +22,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,820</td><td align="right" bgcolor="#FFFFFF">0,820</td><td align="right" bgcolor="#FFFFFF">0,820</td><td align="right" bgcolor="#FFFFFF">0,820</td><td align="right" bgcolor="#FFFFFF">0,820</td><td align="right" bgcolor="#FF4949">0,842 (Δ = +0,021)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 1126,314 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+23,0 %</td><td align="right" bgcolor="#A8D08D">-13,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6018,441 ns</td><td align="right" bgcolor="#A8D08D">4958,105 ns (Δ = -1060,336 ns)</td><td align="right" bgcolor="#FFFFFF">4976,356 ns</td><td align="right" bgcolor="#FFFFFF">4897,827 ns</td><td align="right" bgcolor="#FF4949">6024,141 ns (Δ = +1126,314 ns)</td><td align="right" bgcolor="#A8D08D">5218,069 ns (Δ = -806,072 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,018 μs</td><td align="right" bgcolor="#FFFFFF">4,958 μs</td><td align="right" bgcolor="#FFFFFF">4,976 μs</td><td align="right" bgcolor="#FFFFFF">4,898 μs</td><td align="right" bgcolor="#FFFFFF">6,024 μs</td><td align="right" bgcolor="#FFFFFF">5,218 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">886,000</td><td align="right" bgcolor="#FFFFFF">886,000</td><td align="right" bgcolor="#FFFFFF">886,000</td><td align="right" bgcolor="#FFFFFF">886,000</td><td align="right" bgcolor="#FFFFFF">886,000</td><td align="right" bgcolor="#FF4949">908,000 (Δ = +22,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,865</td><td align="right" bgcolor="#FFFFFF">0,865</td><td align="right" bgcolor="#FFFFFF">0,865</td><td align="right" bgcolor="#FFFFFF">0,865</td><td align="right" bgcolor="#FFFFFF">0,865</td><td align="right" bgcolor="#FF4949">0,887 (Δ = +0,021)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Description"></a>Description

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 852,648 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5709,320 ns</td><td align="right" bgcolor="#A8D08D">5058,904 ns (Δ = -650,417 ns)</td><td align="right" bgcolor="#FFFFFF">5038,154 ns</td><td align="right" bgcolor="#FFFFFF">4908,700 ns</td><td align="right" bgcolor="#FFFFFF">4856,673 ns</td><td align="right" bgcolor="#FFFFFF">5076,175 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,709 μs</td><td align="right" bgcolor="#FFFFFF">5,059 μs</td><td align="right" bgcolor="#FFFFFF">5,038 μs</td><td align="right" bgcolor="#FFFFFF">4,909 μs</td><td align="right" bgcolor="#FFFFFF">4,857 μs</td><td align="right" bgcolor="#FFFFFF">5,076 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FF4949">878,000 (Δ = +23,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FF4949">0,857 (Δ = +0,022)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 28615,914 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,7 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#FF4949">+10,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">272486,240 ns</td><td align="right" bgcolor="#A8D08D">256911,201 ns (Δ = -15575,038 ns)</td><td align="right" bgcolor="#A8D08D">246467,705 ns (Δ = -10443,496 ns)</td><td align="right" bgcolor="#FF4949">256811,030 ns (Δ = +10343,325 ns)</td><td align="right" bgcolor="#A8D08D">248563,306 ns (Δ = -8247,724 ns)</td><td align="right" bgcolor="#FF4949">275083,619 ns (Δ = +26520,313 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">272,486 μs</td><td align="right" bgcolor="#FFFFFF">256,911 μs</td><td align="right" bgcolor="#FFFFFF">246,468 μs</td><td align="right" bgcolor="#FFFFFF">256,811 μs</td><td align="right" bgcolor="#FFFFFF">248,563 μs</td><td align="right" bgcolor="#FFFFFF">275,084 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,272 ms</td><td align="right" bgcolor="#FFFFFF">0,257 ms</td><td align="right" bgcolor="#FFFFFF">0,246 ms</td><td align="right" bgcolor="#FFFFFF">0,257 ms</td><td align="right" bgcolor="#FFFFFF">0,249 ms</td><td align="right" bgcolor="#FFFFFF">0,275 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.5</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FF4949">24,000 (Δ = +9,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20671,000</td><td align="right" bgcolor="#A8D08D">20669,000 (Δ = -2,000)</td><td align="right" bgcolor="#A8D08D">20665,000 (Δ = -4,000)</td><td align="right" bgcolor="#FF4949">20670,000 (Δ = +5,000)</td><td align="right" bgcolor="#A8D08D">20667,000 (Δ = -3,000)</td><td align="right" bgcolor="#FF4949">20694,000 (Δ = +27,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">20,187</td><td align="right" bgcolor="#A8D08D">20,185 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">20,181 (Δ = -0,004)</td><td align="right" bgcolor="#FF4949">20,186 (Δ = +0,005)</td><td align="right" bgcolor="#A8D08D">20,183 (Δ = -0,003)</td><td align="right" bgcolor="#FF4949">20,209 (Δ = +0,026)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,020 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,020 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 1447,447 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+86,0 %</td><td align="right" bgcolor="#A8D08D">-45,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2125,368 ns</td><td align="right" bgcolor="#A8D08D">1818,566 ns (Δ = -306,802 ns)</td><td align="right" bgcolor="#FFFFFF">1683,045 ns</td><td align="right" bgcolor="#FF4949">3130,491 ns (Δ = +1447,447 ns)</td><td align="right" bgcolor="#A8D08D">1715,798 ns (Δ = -1414,694 ns)</td><td align="right" bgcolor="#FFFFFF">1931,277 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,125 μs</td><td align="right" bgcolor="#FFFFFF">1,819 μs</td><td align="right" bgcolor="#FFFFFF">1,683 μs</td><td align="right" bgcolor="#FFFFFF">3,130 μs</td><td align="right" bgcolor="#FFFFFF">1,716 μs</td><td align="right" bgcolor="#FFFFFF">1,931 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1055,000</td><td align="right" bgcolor="#FFFFFF">1055,000</td><td align="right" bgcolor="#FFFFFF">1055,000</td><td align="right" bgcolor="#FFFFFF">1055,000</td><td align="right" bgcolor="#FFFFFF">1055,000</td><td align="right" bgcolor="#FF4949">1068,000 (Δ = +13,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,030</td><td align="right" bgcolor="#FFFFFF">1,030</td><td align="right" bgcolor="#FFFFFF">1,030</td><td align="right" bgcolor="#FFFFFF">1,030</td><td align="right" bgcolor="#FFFFFF">1,030</td><td align="right" bgcolor="#FF4949">1,043 (Δ = +0,013)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 2043,776 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,2 %</td><td align="right" bgcolor="#A8D08D">-26,1 %</td><td align="right" bgcolor="#A8D08D">-8,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5005,118 ns</td><td align="right" bgcolor="#FF4949">6068,061 ns (Δ = +1062,943 ns)</td><td align="right" bgcolor="#A8D08D">4483,101 ns (Δ = -1584,960 ns)</td><td align="right" bgcolor="#A8D08D">4118,202 ns (Δ = -364,899 ns)</td><td align="right" bgcolor="#FFFFFF">4024,285 ns</td><td align="right" bgcolor="#FF4949">4318,973 ns (Δ = +294,688 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,005 μs</td><td align="right" bgcolor="#FFFFFF">6,068 μs</td><td align="right" bgcolor="#FFFFFF">4,483 μs</td><td align="right" bgcolor="#FFFFFF">4,118 μs</td><td align="right" bgcolor="#FFFFFF">4,024 μs</td><td align="right" bgcolor="#FFFFFF">4,319 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Product"></a>Product

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 1032,870 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5837,624 ns</td><td align="right" bgcolor="#A8D08D">4804,754 ns (Δ = -1032,870 ns)</td><td align="right" bgcolor="#FFFFFF">4836,701 ns</td><td align="right" bgcolor="#FFFFFF">4813,340 ns</td><td align="right" bgcolor="#FFFFFF">4876,241 ns</td><td align="right" bgcolor="#FFFFFF">5100,976 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,838 μs</td><td align="right" bgcolor="#FFFFFF">4,805 μs</td><td align="right" bgcolor="#FFFFFF">4,837 μs</td><td align="right" bgcolor="#FFFFFF">4,813 μs</td><td align="right" bgcolor="#FFFFFF">4,876 μs</td><td align="right" bgcolor="#FFFFFF">5,101 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FF4949">878,000 (Δ = +23,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FF4949">0,857 (Δ = +0,022)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Title"></a>Title

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 954,019 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5796,121 ns</td><td align="right" bgcolor="#A8D08D">4945,693 ns (Δ = -850,428 ns)</td><td align="right" bgcolor="#FFFFFF">5063,077 ns</td><td align="right" bgcolor="#FFFFFF">4954,152 ns</td><td align="right" bgcolor="#FFFFFF">4842,102 ns</td><td align="right" bgcolor="#FF4949">5093,388 ns (Δ = +251,286 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,796 μs</td><td align="right" bgcolor="#FFFFFF">4,946 μs</td><td align="right" bgcolor="#FFFFFF">5,063 μs</td><td align="right" bgcolor="#FFFFFF">4,954 μs</td><td align="right" bgcolor="#FFFFFF">4,842 μs</td><td align="right" bgcolor="#FFFFFF">5,093 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FF4949">878,000 (Δ = +23,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FF4949">0,857 (Δ = +0,022)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Version"></a>Version

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 184,056 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">795,305 ns</td><td align="right" bgcolor="#FFFFFF">615,949 ns</td><td align="right" bgcolor="#FFFFFF">664,026 ns</td><td align="right" bgcolor="#FFFFFF">611,249 ns</td><td align="right" bgcolor="#FFFFFF">614,935 ns</td><td align="right" bgcolor="#FFFFFF">702,965 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,795 μs</td><td align="right" bgcolor="#FFFFFF">0,616 μs</td><td align="right" bgcolor="#FFFFFF">0,664 μs</td><td align="right" bgcolor="#FFFFFF">0,611 μs</td><td align="right" bgcolor="#FFFFFF">0,615 μs</td><td align="right" bgcolor="#FFFFFF">0,703 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1265,000</td><td align="right" bgcolor="#FFFFFF">1265,000</td><td align="right" bgcolor="#FFFFFF">1265,000</td><td align="right" bgcolor="#FFFFFF">1265,000</td><td align="right" bgcolor="#FFFFFF">1265,000</td><td align="right" bgcolor="#FF4949">1268,000 (Δ = +3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,235</td><td align="right" bgcolor="#FFFFFF">1,235</td><td align="right" bgcolor="#FFFFFF">1,235</td><td align="right" bgcolor="#FFFFFF">1,235</td><td align="right" bgcolor="#FFFFFF">1,235</td><td align="right" bgcolor="#FF4949">1,238 (Δ = +0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 419,970 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1806,902 ns</td><td align="right" bgcolor="#A8D08D">1386,932 ns (Δ = -419,970 ns)</td><td align="right" bgcolor="#FFFFFF">1443,226 ns</td><td align="right" bgcolor="#FFFFFF">1394,624 ns</td><td align="right" bgcolor="#FFFFFF">1427,003 ns</td><td align="right" bgcolor="#FFFFFF">1477,624 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,807 μs</td><td align="right" bgcolor="#FFFFFF">1,387 μs</td><td align="right" bgcolor="#FFFFFF">1,443 μs</td><td align="right" bgcolor="#FFFFFF">1,395 μs</td><td align="right" bgcolor="#FFFFFF">1,427 μs</td><td align="right" bgcolor="#FFFFFF">1,478 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#A8D08D">249,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#A8D08D">0,243 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 1283,756 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2877,670 ns</td><td align="right" bgcolor="#A8D08D">1623,894 ns (Δ = -1253,775 ns)</td><td align="right" bgcolor="#FFFFFF">1619,751 ns</td><td align="right" bgcolor="#FFFFFF">1625,767 ns</td><td align="right" bgcolor="#FFFFFF">1593,914 ns</td><td align="right" bgcolor="#FF4949">1862,261 ns (Δ = +268,347 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,878 μs</td><td align="right" bgcolor="#FFFFFF">1,624 μs</td><td align="right" bgcolor="#FFFFFF">1,620 μs</td><td align="right" bgcolor="#FFFFFF">1,626 μs</td><td align="right" bgcolor="#FFFFFF">1,594 μs</td><td align="right" bgcolor="#FFFFFF">1,862 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 282,715 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1718,656 ns</td><td align="right" bgcolor="#FFFFFF">1717,871 ns</td><td align="right" bgcolor="#A8D08D">1445,007 ns (Δ = -272,864 ns)</td><td align="right" bgcolor="#FFFFFF">1435,942 ns</td><td align="right" bgcolor="#FFFFFF">1486,725 ns</td><td align="right" bgcolor="#FFFFFF">1506,147 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,719 μs</td><td align="right" bgcolor="#FFFFFF">1,718 μs</td><td align="right" bgcolor="#FFFFFF">1,445 μs</td><td align="right" bgcolor="#FFFFFF">1,436 μs</td><td align="right" bgcolor="#FFFFFF">1,487 μs</td><td align="right" bgcolor="#FFFFFF">1,506 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#A8D08D">249,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#A8D08D">0,243 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 532,260 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2112,619 ns</td><td align="right" bgcolor="#FFFFFF">2087,885 ns</td><td align="right" bgcolor="#A8D08D">1672,590 ns (Δ = -415,295 ns)</td><td align="right" bgcolor="#FFFFFF">1613,197 ns</td><td align="right" bgcolor="#FFFFFF">1580,359 ns</td><td align="right" bgcolor="#FF4949">1862,613 ns (Δ = +282,254 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,113 μs</td><td align="right" bgcolor="#FFFFFF">2,088 μs</td><td align="right" bgcolor="#FFFFFF">1,673 μs</td><td align="right" bgcolor="#FFFFFF">1,613 μs</td><td align="right" bgcolor="#FFFFFF">1,580 μs</td><td align="right" bgcolor="#FFFFFF">1,863 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 382,957 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1756,305 ns</td><td align="right" bgcolor="#A8D08D">1465,027 ns (Δ = -291,279 ns)</td><td align="right" bgcolor="#FFFFFF">1442,140 ns</td><td align="right" bgcolor="#FFFFFF">1373,349 ns</td><td align="right" bgcolor="#FFFFFF">1382,013 ns</td><td align="right" bgcolor="#FFFFFF">1574,709 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,756 μs</td><td align="right" bgcolor="#FFFFFF">1,465 μs</td><td align="right" bgcolor="#FFFFFF">1,442 μs</td><td align="right" bgcolor="#FFFFFF">1,373 μs</td><td align="right" bgcolor="#FFFFFF">1,382 μs</td><td align="right" bgcolor="#FFFFFF">1,575 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#A8D08D">249,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#A8D08D">0,243 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 244,686 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1846,448 ns</td><td align="right" bgcolor="#FFFFFF">1699,523 ns</td><td align="right" bgcolor="#FFFFFF">1641,880 ns</td><td align="right" bgcolor="#FFFFFF">1618,341 ns</td><td align="right" bgcolor="#FFFFFF">1630,093 ns</td><td align="right" bgcolor="#FFFFFF">1863,027 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,846 μs</td><td align="right" bgcolor="#FFFFFF">1,700 μs</td><td align="right" bgcolor="#FFFFFF">1,642 μs</td><td align="right" bgcolor="#FFFFFF">1,618 μs</td><td align="right" bgcolor="#FFFFFF">1,630 μs</td><td align="right" bgcolor="#FFFFFF">1,863 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 544,504 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1939,832 ns</td><td align="right" bgcolor="#A8D08D">1492,549 ns (Δ = -447,283 ns)</td><td align="right" bgcolor="#FFFFFF">1408,037 ns</td><td align="right" bgcolor="#FFFFFF">1534,360 ns</td><td align="right" bgcolor="#FFFFFF">1395,327 ns</td><td align="right" bgcolor="#FFFFFF">1535,447 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,940 μs</td><td align="right" bgcolor="#FFFFFF">1,493 μs</td><td align="right" bgcolor="#FFFFFF">1,408 μs</td><td align="right" bgcolor="#FFFFFF">1,534 μs</td><td align="right" bgcolor="#FFFFFF">1,395 μs</td><td align="right" bgcolor="#FFFFFF">1,535 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#A8D08D">249,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#A8D08D">0,243 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 321,884 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1940,134 ns</td><td align="right" bgcolor="#FFFFFF">1697,443 ns</td><td align="right" bgcolor="#FFFFFF">1664,683 ns</td><td align="right" bgcolor="#FFFFFF">1618,250 ns</td><td align="right" bgcolor="#FFFFFF">1620,952 ns</td><td align="right" bgcolor="#FF4949">1876,629 ns (Δ = +255,677 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,940 μs</td><td align="right" bgcolor="#FFFFFF">1,697 μs</td><td align="right" bgcolor="#FFFFFF">1,665 μs</td><td align="right" bgcolor="#FFFFFF">1,618 μs</td><td align="right" bgcolor="#FFFFFF">1,621 μs</td><td align="right" bgcolor="#FFFFFF">1,877 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 211,724 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1600,007 ns</td><td align="right" bgcolor="#FFFFFF">1469,164 ns</td><td align="right" bgcolor="#FFFFFF">1444,489 ns</td><td align="right" bgcolor="#FFFFFF">1557,443 ns</td><td align="right" bgcolor="#FFFFFF">1388,283 ns</td><td align="right" bgcolor="#FFFFFF">1458,531 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,600 μs</td><td align="right" bgcolor="#FFFFFF">1,469 μs</td><td align="right" bgcolor="#FFFFFF">1,444 μs</td><td align="right" bgcolor="#FFFFFF">1,557 μs</td><td align="right" bgcolor="#FFFFFF">1,388 μs</td><td align="right" bgcolor="#FFFFFF">1,459 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#A8D08D">249,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#A8D08D">0,243 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 481,593 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2062,138 ns</td><td align="right" bgcolor="#A8D08D">1622,299 ns (Δ = -439,839 ns)</td><td align="right" bgcolor="#FFFFFF">1640,493 ns</td><td align="right" bgcolor="#FFFFFF">1640,094 ns</td><td align="right" bgcolor="#FFFFFF">1580,544 ns</td><td align="right" bgcolor="#FFFFFF">1820,544 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,062 μs</td><td align="right" bgcolor="#FFFFFF">1,622 μs</td><td align="right" bgcolor="#FFFFFF">1,640 μs</td><td align="right" bgcolor="#FFFFFF">1,640 μs</td><td align="right" bgcolor="#FFFFFF">1,581 μs</td><td align="right" bgcolor="#FFFFFF">1,821 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 649,351 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,5 %</td><td align="right" bgcolor="#A8D08D">-29,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1785,027 ns</td><td align="right" bgcolor="#FF4949">2043,050 ns (Δ = +258,023 ns)</td><td align="right" bgcolor="#A8D08D">1432,913 ns (Δ = -610,137 ns)</td><td align="right" bgcolor="#FFFFFF">1550,262 ns</td><td align="right" bgcolor="#FFFFFF">1393,699 ns</td><td align="right" bgcolor="#FFFFFF">1581,731 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,785 μs</td><td align="right" bgcolor="#FFFFFF">2,043 μs</td><td align="right" bgcolor="#FFFFFF">1,433 μs</td><td align="right" bgcolor="#FFFFFF">1,550 μs</td><td align="right" bgcolor="#FFFFFF">1,394 μs</td><td align="right" bgcolor="#FFFFFF">1,582 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#A8D08D">249,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#A8D08D">0,243 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 413,471 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2053,407 ns</td><td align="right" bgcolor="#A8D08D">1722,798 ns (Δ = -330,609 ns)</td><td align="right" bgcolor="#FFFFFF">1681,268 ns</td><td align="right" bgcolor="#FFFFFF">1639,936 ns</td><td align="right" bgcolor="#FFFFFF">1651,298 ns</td><td align="right" bgcolor="#FFFFFF">1844,285 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,053 μs</td><td align="right" bgcolor="#FFFFFF">1,723 μs</td><td align="right" bgcolor="#FFFFFF">1,681 μs</td><td align="right" bgcolor="#FFFFFF">1,640 μs</td><td align="right" bgcolor="#FFFFFF">1,651 μs</td><td align="right" bgcolor="#FFFFFF">1,844 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 42,896 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">241,591 ns</td><td align="right" bgcolor="#FFFFFF">209,379 ns</td><td align="right" bgcolor="#FFFFFF">203,213 ns</td><td align="right" bgcolor="#FFFFFF">211,839 ns</td><td align="right" bgcolor="#FFFFFF">246,110 ns</td><td align="right" bgcolor="#FFFFFF">213,440 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td><td align="right" bgcolor="#FFFFFF">0,209 μs</td><td align="right" bgcolor="#FFFFFF">0,203 μs</td><td align="right" bgcolor="#FFFFFF">0,212 μs</td><td align="right" bgcolor="#FFFFFF">0,246 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 66,970 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">264,838 ns</td><td align="right" bgcolor="#FFFFFF">197,868 ns</td><td align="right" bgcolor="#FFFFFF">203,517 ns</td><td align="right" bgcolor="#FFFFFF">205,418 ns</td><td align="right" bgcolor="#FFFFFF">208,318 ns</td><td align="right" bgcolor="#FFFFFF">225,960 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td><td align="right" bgcolor="#FFFFFF">0,204 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 52,682 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">255,340 ns</td><td align="right" bgcolor="#FFFFFF">207,908 ns</td><td align="right" bgcolor="#FFFFFF">202,658 ns</td><td align="right" bgcolor="#FFFFFF">233,727 ns</td><td align="right" bgcolor="#FFFFFF">204,573 ns</td><td align="right" bgcolor="#FFFFFF">211,096 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,255 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,203 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#A8D08D">138,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FF4949">143,000 (Δ = +5,000)</td><td align="right" bgcolor="#A8D08D">138,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">138,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#A8D08D">0,135 (Δ = -0,005)</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FF4949">0,140 (Δ = +0,005)</td><td align="right" bgcolor="#A8D08D">0,135 (Δ = -0,005)</td><td align="right" bgcolor="#FFFFFF">0,135</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 40,048 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">212,879 ns</td><td align="right" bgcolor="#FFFFFF">221,151 ns</td><td align="right" bgcolor="#FFFFFF">181,103 ns</td><td align="right" bgcolor="#FFFFFF">185,876 ns</td><td align="right" bgcolor="#FFFFFF">186,561 ns</td><td align="right" bgcolor="#FFFFFF">192,885 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,181 μs</td><td align="right" bgcolor="#FFFFFF">0,186 μs</td><td align="right" bgcolor="#FFFFFF">0,187 μs</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">121,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#A8D08D">0,118 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 34,521 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">215,033 ns</td><td align="right" bgcolor="#FFFFFF">188,011 ns</td><td align="right" bgcolor="#FFFFFF">180,512 ns</td><td align="right" bgcolor="#FFFFFF">189,504 ns</td><td align="right" bgcolor="#FFFFFF">197,618 ns</td><td align="right" bgcolor="#FFFFFF">198,549 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,215 μs</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td><td align="right" bgcolor="#FFFFFF">0,181 μs</td><td align="right" bgcolor="#FFFFFF">0,190 μs</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td><td align="right" bgcolor="#FFFFFF">0,199 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">121,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#A8D08D">0,118 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 42,761 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">240,530 ns</td><td align="right" bgcolor="#FFFFFF">202,286 ns</td><td align="right" bgcolor="#FFFFFF">197,768 ns</td><td align="right" bgcolor="#FFFFFF">206,223 ns</td><td align="right" bgcolor="#FFFFFF">202,222 ns</td><td align="right" bgcolor="#FFFFFF">233,264 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,241 μs</td><td align="right" bgcolor="#FFFFFF">0,202 μs</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#FFFFFF">0,202 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 158,947 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">729,722 ns</td><td align="right" bgcolor="#FFFFFF">644,563 ns</td><td align="right" bgcolor="#FFFFFF">626,787 ns</td><td align="right" bgcolor="#FFFFFF">635,394 ns</td><td align="right" bgcolor="#FFFFFF">570,776 ns</td><td align="right" bgcolor="#FFFFFF">687,203 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,730 μs</td><td align="right" bgcolor="#FFFFFF">0,645 μs</td><td align="right" bgcolor="#FFFFFF">0,627 μs</td><td align="right" bgcolor="#FFFFFF">0,635 μs</td><td align="right" bgcolor="#FFFFFF">0,571 μs</td><td align="right" bgcolor="#FFFFFF">0,687 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">189,000</td><td align="right" bgcolor="#FFFFFF">189,000</td><td align="right" bgcolor="#FFFFFF">189,000</td><td align="right" bgcolor="#FFFFFF">189,000</td><td align="right" bgcolor="#FFFFFF">189,000</td><td align="right" bgcolor="#A8D08D">187,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,185</td><td align="right" bgcolor="#FFFFFF">0,185</td><td align="right" bgcolor="#FFFFFF">0,185</td><td align="right" bgcolor="#FFFFFF">0,185</td><td align="right" bgcolor="#FFFFFF">0,185</td><td align="right" bgcolor="#A8D08D">0,183 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 18,794 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">107,458 ns</td><td align="right" bgcolor="#FFFFFF">89,652 ns</td><td align="right" bgcolor="#FFFFFF">96,824 ns</td><td align="right" bgcolor="#FFFFFF">102,589 ns</td><td align="right" bgcolor="#FFFFFF">88,665 ns</td><td align="right" bgcolor="#FFFFFF">96,392 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td><td align="right" bgcolor="#FFFFFF">0,089 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetName_Long"></a>GetName_Long

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 24,893 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">118,599 ns</td><td align="right" bgcolor="#FFFFFF">100,985 ns</td><td align="right" bgcolor="#FFFFFF">97,805 ns</td><td align="right" bgcolor="#FFFFFF">98,177 ns</td><td align="right" bgcolor="#FFFFFF">93,705 ns</td><td align="right" bgcolor="#FFFFFF">100,155 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetNames"></a>GetNames

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 306,186 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1596,765 ns</td><td align="right" bgcolor="#A8D08D">1290,579 ns (Δ = -306,186 ns)</td><td align="right" bgcolor="#FFFFFF">1338,882 ns</td><td align="right" bgcolor="#FFFFFF">1302,984 ns</td><td align="right" bgcolor="#FFFFFF">1337,338 ns</td><td align="right" bgcolor="#FFFFFF">1504,488 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,597 μs</td><td align="right" bgcolor="#FFFFFF">1,291 μs</td><td align="right" bgcolor="#FFFFFF">1,339 μs</td><td align="right" bgcolor="#FFFFFF">1,303 μs</td><td align="right" bgcolor="#FFFFFF">1,337 μs</td><td align="right" bgcolor="#FFFFFF">1,504 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">916,000</td><td align="right" bgcolor="#FFFFFF">916,000</td><td align="right" bgcolor="#FFFFFF">916,000</td><td align="right" bgcolor="#FFFFFF">916,000</td><td align="right" bgcolor="#FFFFFF">916,000</td><td align="right" bgcolor="#FF4949">918,000 (Δ = +2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,895</td><td align="right" bgcolor="#FFFFFF">0,895</td><td align="right" bgcolor="#FFFFFF">0,895</td><td align="right" bgcolor="#FFFFFF">0,895</td><td align="right" bgcolor="#FFFFFF">0,895</td><td align="right" bgcolor="#FF4949">0,896 (Δ = +0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_GetValues"></a>GetValues

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 572,084 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3049,539 ns</td><td align="right" bgcolor="#A8D08D">2477,455 ns (Δ = -572,084 ns)</td><td align="right" bgcolor="#FFFFFF">2590,664 ns</td><td align="right" bgcolor="#FFFFFF">2511,274 ns</td><td align="right" bgcolor="#FFFFFF">2731,300 ns</td><td align="right" bgcolor="#FFFFFF">2681,536 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,050 μs</td><td align="right" bgcolor="#FFFFFF">2,477 μs</td><td align="right" bgcolor="#FFFFFF">2,591 μs</td><td align="right" bgcolor="#FFFFFF">2,511 μs</td><td align="right" bgcolor="#FFFFFF">2,731 μs</td><td align="right" bgcolor="#FFFFFF">2,682 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 214,114 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">417,299 ns</td><td align="right" bgcolor="#FFFFFF">203,184 ns</td><td align="right" bgcolor="#FFFFFF">207,609 ns</td><td align="right" bgcolor="#FFFFFF">207,513 ns</td><td align="right" bgcolor="#FFFFFF">236,437 ns</td><td align="right" bgcolor="#FFFFFF">226,797 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,417 μs</td><td align="right" bgcolor="#FFFFFF">0,203 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FF4949">115,000 (Δ = +2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FF4949">0,112 (Δ = +0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_ToList"></a>ToList

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 646,017 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,7 %</td><td align="right" bgcolor="#FF4949">+17,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3013,993 ns</td><td align="right" bgcolor="#A8D08D">2542,568 ns (Δ = -471,425 ns)</td><td align="right" bgcolor="#FFFFFF">2645,105 ns</td><td align="right" bgcolor="#FFFFFF">2776,041 ns</td><td align="right" bgcolor="#A8D08D">2367,976 ns (Δ = -408,065 ns)</td><td align="right" bgcolor="#FF4949">2778,557 ns (Δ = +410,581 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,014 μs</td><td align="right" bgcolor="#FFFFFF">2,543 μs</td><td align="right" bgcolor="#FFFFFF">2,645 μs</td><td align="right" bgcolor="#FFFFFF">2,776 μs</td><td align="right" bgcolor="#FFFFFF">2,368 μs</td><td align="right" bgcolor="#FFFFFF">2,779 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1198,000</td><td align="right" bgcolor="#FFFFFF">1198,000</td><td align="right" bgcolor="#FFFFFF">1198,000</td><td align="right" bgcolor="#FFFFFF">1198,000</td><td align="right" bgcolor="#FFFFFF">1198,000</td><td align="right" bgcolor="#FF4949">1199,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,170</td><td align="right" bgcolor="#FFFFFF">1,170</td><td align="right" bgcolor="#FFFFFF">1,170</td><td align="right" bgcolor="#FFFFFF">1,170</td><td align="right" bgcolor="#FFFFFF">1,170</td><td align="right" bgcolor="#FF4949">1,171 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_TryParse"></a>TryParse

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 74,380 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">288,453 ns</td><td align="right" bgcolor="#FFFFFF">285,656 ns</td><td align="right" bgcolor="#FFFFFF">216,244 ns</td><td align="right" bgcolor="#FFFFFF">214,386 ns</td><td align="right" bgcolor="#FFFFFF">214,073 ns</td><td align="right" bgcolor="#FFFFFF">239,285 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,288 μs</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,216 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,239 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FF4949">115,000 (Δ = +2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FF4949">0,112 (Δ = +0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase"></a>TryParse_IgnoreCase

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 45,672 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">263,731 ns</td><td align="right" bgcolor="#FFFFFF">218,059 ns</td><td align="right" bgcolor="#FFFFFF">222,631 ns</td><td align="right" bgcolor="#FFFFFF">228,813 ns</td><td align="right" bgcolor="#FFFFFF">219,366 ns</td><td align="right" bgcolor="#FFFFFF">243,949 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,229 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FF4949">115,000 (Δ = +2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FF4949">0,112 (Δ = +0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase_Nullable"></a>TryParse_IgnoreCase_Nullable

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 45,942 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">258,807 ns</td><td align="right" bgcolor="#FFFFFF">218,281 ns</td><td align="right" bgcolor="#FFFFFF">212,865 ns</td><td align="right" bgcolor="#FFFFFF">241,991 ns</td><td align="right" bgcolor="#FFFFFF">213,324 ns</td><td align="right" bgcolor="#FFFFFF">233,261 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,259 μs</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FF4949">115,000 (Δ = +2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FF4949">0,112 (Δ = +0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 104,050 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">313,412 ns</td><td align="right" bgcolor="#FFFFFF">214,380 ns</td><td align="right" bgcolor="#FFFFFF">219,024 ns</td><td align="right" bgcolor="#FFFFFF">211,452 ns</td><td align="right" bgcolor="#FFFFFF">209,361 ns</td><td align="right" bgcolor="#FFFFFF">225,915 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,313 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,209 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FF4949">115,000 (Δ = +2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FF4949">0,112 (Δ = +0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="ExpressionHelper_Benchmark"></a>ExpressionHelper_Benchmark

### <a name="ExpressionHelper_Benchmark_GetOwner"></a>GetOwner

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 629,887 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,1 %</td><td align="right" bgcolor="#A8D08D">-26,8 %</td><td align="right" bgcolor="#FF4949">+41,0 %</td><td align="right" bgcolor="#A8D08D">-26,3 %</td><td align="right" bgcolor="#FF4949">+52,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1544,245 ns</td><td align="right" bgcolor="#A8D08D">1249,580 ns (Δ = -294,665 ns)</td><td align="right" bgcolor="#A8D08D">914,358 ns (Δ = -335,222 ns)</td><td align="right" bgcolor="#FF4949">1289,366 ns (Δ = +375,008 ns)</td><td align="right" bgcolor="#A8D08D">949,938 ns (Δ = -339,429 ns)</td><td align="right" bgcolor="#FF4949">1452,909 ns (Δ = +502,972 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,544 μs</td><td align="right" bgcolor="#FFFFFF">1,250 μs</td><td align="right" bgcolor="#FFFFFF">0,914 μs</td><td align="right" bgcolor="#FFFFFF">1,289 μs</td><td align="right" bgcolor="#FFFFFF">0,950 μs</td><td align="right" bgcolor="#FFFFFF">1,453 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">655,000</td><td align="right" bgcolor="#FFFFFF">655,000</td><td align="right" bgcolor="#FFFFFF">655,000</td><td align="right" bgcolor="#FFFFFF">655,000</td><td align="right" bgcolor="#FFFFFF">655,000</td><td align="right" bgcolor="#A8D08D">652,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,640</td><td align="right" bgcolor="#FFFFFF">0,640</td><td align="right" bgcolor="#FFFFFF">0,640</td><td align="right" bgcolor="#FFFFFF">0,640</td><td align="right" bgcolor="#FFFFFF">0,640</td><td align="right" bgcolor="#A8D08D">0,637 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="ExpressionHelper_Benchmark_GetPropertyName"></a>GetPropertyName

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 1832,934 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,5 %</td><td align="right" bgcolor="#A8D08D">-18,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,0 %</td><td align="right" bgcolor="#FF4949">+53,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2929,328 ns</td><td align="right" bgcolor="#A8D08D">2240,219 ns (Δ = -689,109 ns)</td><td align="right" bgcolor="#A8D08D">1821,730 ns (Δ = -418,489 ns)</td><td align="right" bgcolor="#FFFFFF">1954,530 ns</td><td align="right" bgcolor="#FF4949">2384,800 ns (Δ = +430,270 ns)</td><td align="right" bgcolor="#FF4949">3654,664 ns (Δ = +1269,864 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,929 μs</td><td align="right" bgcolor="#FFFFFF">2,240 μs</td><td align="right" bgcolor="#FFFFFF">1,822 μs</td><td align="right" bgcolor="#FFFFFF">1,955 μs</td><td align="right" bgcolor="#FFFFFF">2,385 μs</td><td align="right" bgcolor="#FFFFFF">3,655 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td></tr></table>


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 58,871 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">121,959 ns</td><td align="right" bgcolor="#FFFFFF">63,088 ns</td><td align="right" bgcolor="#FFFFFF">65,979 ns</td><td align="right" bgcolor="#FFFFFF">74,091 ns</td><td align="right" bgcolor="#FFFFFF">65,259 ns</td><td align="right" bgcolor="#FFFFFF">64,707 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 10,449 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">72,334 ns</td><td align="right" bgcolor="#FFFFFF">68,008 ns</td><td align="right" bgcolor="#FFFFFF">61,885 ns</td><td align="right" bgcolor="#FFFFFF">65,508 ns</td><td align="right" bgcolor="#FFFFFF">62,179 ns</td><td align="right" bgcolor="#FFFFFF">64,795 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="HashHelper_Benchmark"></a>HashHelper_Benchmark

### <a name="HashHelper_Benchmark_HashHelper"></a>HashHelper

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 11,021 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,347 ns</td><td align="right" bgcolor="#FFFFFF">15,331 ns</td><td align="right" bgcolor="#FFFFFF">11,876 ns</td><td align="right" bgcolor="#FFFFFF">15,392 ns</td><td align="right" bgcolor="#FFFFFF">11,825 ns</td><td align="right" bgcolor="#FFFFFF">22,845 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">67,000</td><td align="right" bgcolor="#FFFFFF">67,000</td><td align="right" bgcolor="#FFFFFF">67,000</td><td align="right" bgcolor="#FFFFFF">67,000</td><td align="right" bgcolor="#FFFFFF">67,000</td><td align="right" bgcolor="#A8D08D">66,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,065</td><td align="right" bgcolor="#FFFFFF">0,065</td><td align="right" bgcolor="#FFFFFF">0,065</td><td align="right" bgcolor="#FFFFFF">0,065</td><td align="right" bgcolor="#FFFFFF">0,065</td><td align="right" bgcolor="#A8D08D">0,064 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


## <a name="LanguageHelper_Benchmark"></a>LanguageHelper_Benchmark

### <a name="LanguageHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 2451,703 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+825,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">309,244 ns</td><td align="right" bgcolor="#FFFFFF">312,664 ns</td><td align="right" bgcolor="#FFFFFF">309,109 ns</td><td align="right" bgcolor="#FFFFFF">304,224 ns</td><td align="right" bgcolor="#FFFFFF">297,040 ns</td><td align="right" bgcolor="#FF4949">2748,743 ns (Δ = +2451,703 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,309 μs</td><td align="right" bgcolor="#FFFFFF">0,313 μs</td><td align="right" bgcolor="#FFFFFF">0,309 μs</td><td align="right" bgcolor="#FFFFFF">0,304 μs</td><td align="right" bgcolor="#FFFFFF">0,297 μs</td><td align="right" bgcolor="#FFFFFF">2,749 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +2,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+595,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FF4949">1815,000 (Δ = +1554,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FF4949">1,772 (Δ = +1,518)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,001)</td></tr></table>


## <a name="Log_Debug_Benchmark"></a>Log_Debug_Benchmark

### <a name="Log_Debug_Benchmark_Log_Debug_Format_1_Format_Argument"></a>Log_Debug_Format_1_Format_Argument

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 123,373 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">502,210 ns</td><td align="right" bgcolor="#FFFFFF">406,656 ns</td><td align="right" bgcolor="#FFFFFF">403,542 ns</td><td align="right" bgcolor="#FFFFFF">392,323 ns</td><td align="right" bgcolor="#FFFFFF">423,419 ns</td><td align="right" bgcolor="#FFFFFF">515,696 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,502 μs</td><td align="right" bgcolor="#FFFFFF">0,407 μs</td><td align="right" bgcolor="#FFFFFF">0,404 μs</td><td align="right" bgcolor="#FFFFFF">0,392 μs</td><td align="right" bgcolor="#FFFFFF">0,423 μs</td><td align="right" bgcolor="#FFFFFF">0,516 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_2_Format_Arguments"></a>Log_Debug_Format_2_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 117,973 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">585,253 ns</td><td align="right" bgcolor="#FFFFFF">470,446 ns</td><td align="right" bgcolor="#FFFFFF">528,712 ns</td><td align="right" bgcolor="#FFFFFF">476,132 ns</td><td align="right" bgcolor="#FFFFFF">467,281 ns</td><td align="right" bgcolor="#FFFFFF">558,264 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,585 μs</td><td align="right" bgcolor="#FFFFFF">0,470 μs</td><td align="right" bgcolor="#FFFFFF">0,529 μs</td><td align="right" bgcolor="#FFFFFF">0,476 μs</td><td align="right" bgcolor="#FFFFFF">0,467 μs</td><td align="right" bgcolor="#FFFFFF">0,558 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FF4949">380,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FF4949">0,371 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments"></a>Log_Debug_Format_3_Format_Arguments

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 147,992 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">720,114 ns</td><td align="right" bgcolor="#FFFFFF">686,455 ns</td><td align="right" bgcolor="#FFFFFF">623,954 ns</td><td align="right" bgcolor="#FFFFFF">572,122 ns</td><td align="right" bgcolor="#FFFFFF">581,571 ns</td><td align="right" bgcolor="#FFFFFF">682,448 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,720 μs</td><td align="right" bgcolor="#FFFFFF">0,686 μs</td><td align="right" bgcolor="#FFFFFF">0,624 μs</td><td align="right" bgcolor="#FFFFFF">0,572 μs</td><td align="right" bgcolor="#FFFFFF">0,582 μs</td><td align="right" bgcolor="#FFFFFF">0,682 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FF4949">452,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FF4949">0,441 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_4_Format_Arguments"></a>Log_Debug_Format_4_Format_Arguments

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 204,138 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">888,124 ns</td><td align="right" bgcolor="#FFFFFF">795,495 ns</td><td align="right" bgcolor="#FFFFFF">739,049 ns</td><td align="right" bgcolor="#FFFFFF">683,985 ns</td><td align="right" bgcolor="#FFFFFF">706,313 ns</td><td align="right" bgcolor="#FFFFFF">809,843 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,888 μs</td><td align="right" bgcolor="#FFFFFF">0,795 μs</td><td align="right" bgcolor="#FFFFFF">0,739 μs</td><td align="right" bgcolor="#FFFFFF">0,684 μs</td><td align="right" bgcolor="#FFFFFF">0,706 μs</td><td align="right" bgcolor="#FFFFFF">0,810 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FF4949">580,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FF4949">0,566 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_5_Format_Arguments"></a>Log_Debug_Format_5_Format_Arguments

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 214,199 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">989,628 ns</td><td align="right" bgcolor="#FFFFFF">867,963 ns</td><td align="right" bgcolor="#FFFFFF">836,817 ns</td><td align="right" bgcolor="#FFFFFF">775,429 ns</td><td align="right" bgcolor="#FFFFFF">776,366 ns</td><td align="right" bgcolor="#FFFFFF">911,171 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,990 μs</td><td align="right" bgcolor="#FFFFFF">0,868 μs</td><td align="right" bgcolor="#FFFFFF">0,837 μs</td><td align="right" bgcolor="#FFFFFF">0,775 μs</td><td align="right" bgcolor="#FFFFFF">0,776 μs</td><td align="right" bgcolor="#FFFFFF">0,911 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments"></a>Log_Debug_Format_6_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 155,908 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1086,834 ns</td><td align="right" bgcolor="#FFFFFF">970,947 ns</td><td align="right" bgcolor="#FFFFFF">989,126 ns</td><td align="right" bgcolor="#FFFFFF">936,122 ns</td><td align="right" bgcolor="#FFFFFF">930,925 ns</td><td align="right" bgcolor="#FFFFFF">1072,195 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,087 μs</td><td align="right" bgcolor="#FFFFFF">0,971 μs</td><td align="right" bgcolor="#FFFFFF">0,989 μs</td><td align="right" bgcolor="#FFFFFF">0,936 μs</td><td align="right" bgcolor="#FFFFFF">0,931 μs</td><td align="right" bgcolor="#FFFFFF">1,072 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_7_Format_Arguments"></a>Log_Debug_Format_7_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 180,463 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1224,769 ns</td><td align="right" bgcolor="#FFFFFF">1073,711 ns</td><td align="right" bgcolor="#FFFFFF">1109,054 ns</td><td align="right" bgcolor="#FFFFFF">1061,677 ns</td><td align="right" bgcolor="#FFFFFF">1044,306 ns</td><td align="right" bgcolor="#FFFFFF">1195,733 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,225 μs</td><td align="right" bgcolor="#FFFFFF">1,074 μs</td><td align="right" bgcolor="#FFFFFF">1,109 μs</td><td align="right" bgcolor="#FFFFFF">1,062 μs</td><td align="right" bgcolor="#FFFFFF">1,044 μs</td><td align="right" bgcolor="#FFFFFF">1,196 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#A8D08D">924,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#A8D08D">0,902 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 3,725 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,132 ns</td><td align="right" bgcolor="#FFFFFF">1,818 ns</td><td align="right" bgcolor="#FFFFFF">0,530 ns</td><td align="right" bgcolor="#FFFFFF">0,735 ns</td><td align="right" bgcolor="#FFFFFF">0,407 ns</td><td align="right" bgcolor="#FFFFFF">1,263 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 6,590 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,158 ns</td><td align="right" bgcolor="#FFFFFF">10,125 ns</td><td align="right" bgcolor="#FFFFFF">10,229 ns</td><td align="right" bgcolor="#FFFFFF">9,957 ns</td><td align="right" bgcolor="#FFFFFF">9,568 ns</td><td align="right" bgcolor="#FFFFFF">11,789 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FF4949">59,000 (Δ = +3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FF4949">0,058 (Δ = +0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 5,120 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,782 ns</td><td align="right" bgcolor="#FFFFFF">10,969 ns</td><td align="right" bgcolor="#FFFFFF">7,782 ns</td><td align="right" bgcolor="#FFFFFF">7,662 ns</td><td align="right" bgcolor="#FFFFFF">7,758 ns</td><td align="right" bgcolor="#FFFFFF">7,960 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">33,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,032 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 41,485 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">241,597 ns</td><td align="right" bgcolor="#FFFFFF">216,552 ns</td><td align="right" bgcolor="#FFFFFF">200,111 ns</td><td align="right" bgcolor="#FFFFFF">204,704 ns</td><td align="right" bgcolor="#FFFFFF">200,429 ns</td><td align="right" bgcolor="#FFFFFF">234,363 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td><td align="right" bgcolor="#FFFFFF">0,217 μs</td><td align="right" bgcolor="#FFFFFF">0,200 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,200 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#A8D08D">161,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#A8D08D">0,157 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 126,876 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">536,131 ns</td><td align="right" bgcolor="#FFFFFF">419,007 ns</td><td align="right" bgcolor="#FFFFFF">426,910 ns</td><td align="right" bgcolor="#FFFFFF">457,375 ns</td><td align="right" bgcolor="#FFFFFF">409,255 ns</td><td align="right" bgcolor="#FFFFFF">474,203 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,536 μs</td><td align="right" bgcolor="#FFFFFF">0,419 μs</td><td align="right" bgcolor="#FFFFFF">0,427 μs</td><td align="right" bgcolor="#FFFFFF">0,457 μs</td><td align="right" bgcolor="#FFFFFF">0,409 μs</td><td align="right" bgcolor="#FFFFFF">0,474 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">353,000</td><td align="right" bgcolor="#FFFFFF">353,000</td><td align="right" bgcolor="#FFFFFF">353,000</td><td align="right" bgcolor="#FFFFFF">353,000</td><td align="right" bgcolor="#FFFFFF">353,000</td><td align="right" bgcolor="#FF4949">354,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,345</td><td align="right" bgcolor="#FFFFFF">0,345</td><td align="right" bgcolor="#FFFFFF">0,345</td><td align="right" bgcolor="#FFFFFF">0,345</td><td align="right" bgcolor="#FFFFFF">0,345</td><td align="right" bgcolor="#FF4949">0,346 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 97,060 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">443,203 ns</td><td align="right" bgcolor="#FFFFFF">361,283 ns</td><td align="right" bgcolor="#FFFFFF">376,135 ns</td><td align="right" bgcolor="#FFFFFF">358,903 ns</td><td align="right" bgcolor="#FFFFFF">346,144 ns</td><td align="right" bgcolor="#FFFFFF">397,027 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,443 μs</td><td align="right" bgcolor="#FFFFFF">0,361 μs</td><td align="right" bgcolor="#FFFFFF">0,376 μs</td><td align="right" bgcolor="#FFFFFF">0,359 μs</td><td align="right" bgcolor="#FFFFFF">0,346 μs</td><td align="right" bgcolor="#FFFFFF">0,397 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#A8D08D">347,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#A8D08D">0,339 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


## <a name="Log_Error_Benchmark"></a>Log_Error_Benchmark

### <a name="Log_Error_Benchmark_Log_Error_Format_1_Format_Argument"></a>Log_Error_Format_1_Format_Argument

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 122,993 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">517,781 ns</td><td align="right" bgcolor="#FFFFFF">421,337 ns</td><td align="right" bgcolor="#FFFFFF">432,167 ns</td><td align="right" bgcolor="#FFFFFF">402,147 ns</td><td align="right" bgcolor="#FFFFFF">394,788 ns</td><td align="right" bgcolor="#FFFFFF">435,235 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,518 μs</td><td align="right" bgcolor="#FFFFFF">0,421 μs</td><td align="right" bgcolor="#FFFFFF">0,432 μs</td><td align="right" bgcolor="#FFFFFF">0,402 μs</td><td align="right" bgcolor="#FFFFFF">0,395 μs</td><td align="right" bgcolor="#FFFFFF">0,435 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FF4949">308,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FF4949">0,301 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_2_Format_Arguments"></a>Log_Error_Format_2_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 83,644 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">566,379 ns</td><td align="right" bgcolor="#FFFFFF">511,879 ns</td><td align="right" bgcolor="#FFFFFF">503,212 ns</td><td align="right" bgcolor="#FFFFFF">497,400 ns</td><td align="right" bgcolor="#FFFFFF">482,735 ns</td><td align="right" bgcolor="#FFFFFF">546,549 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,566 μs</td><td align="right" bgcolor="#FFFFFF">0,512 μs</td><td align="right" bgcolor="#FFFFFF">0,503 μs</td><td align="right" bgcolor="#FFFFFF">0,497 μs</td><td align="right" bgcolor="#FFFFFF">0,483 μs</td><td align="right" bgcolor="#FFFFFF">0,547 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FF4949">380,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FF4949">0,371 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_3_Format_Arguments"></a>Log_Error_Format_3_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 177,117 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">743,517 ns</td><td align="right" bgcolor="#FFFFFF">606,580 ns</td><td align="right" bgcolor="#FFFFFF">630,212 ns</td><td align="right" bgcolor="#FFFFFF">603,281 ns</td><td align="right" bgcolor="#FFFFFF">566,401 ns</td><td align="right" bgcolor="#FFFFFF">672,467 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,744 μs</td><td align="right" bgcolor="#FFFFFF">0,607 μs</td><td align="right" bgcolor="#FFFFFF">0,630 μs</td><td align="right" bgcolor="#FFFFFF">0,603 μs</td><td align="right" bgcolor="#FFFFFF">0,566 μs</td><td align="right" bgcolor="#FFFFFF">0,672 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FF4949">452,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FF4949">0,441 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_4_Format_Arguments"></a>Log_Error_Format_4_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 148,436 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">847,703 ns</td><td align="right" bgcolor="#FFFFFF">725,284 ns</td><td align="right" bgcolor="#FFFFFF">744,721 ns</td><td align="right" bgcolor="#FFFFFF">758,090 ns</td><td align="right" bgcolor="#FFFFFF">699,267 ns</td><td align="right" bgcolor="#FFFFFF">813,581 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,848 μs</td><td align="right" bgcolor="#FFFFFF">0,725 μs</td><td align="right" bgcolor="#FFFFFF">0,745 μs</td><td align="right" bgcolor="#FFFFFF">0,758 μs</td><td align="right" bgcolor="#FFFFFF">0,699 μs</td><td align="right" bgcolor="#FFFFFF">0,814 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FF4949">580,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FF4949">0,566 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_5_Format_Arguments"></a>Log_Error_Format_5_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 186,852 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">979,202 ns</td><td align="right" bgcolor="#FFFFFF">833,677 ns</td><td align="right" bgcolor="#FFFFFF">822,386 ns</td><td align="right" bgcolor="#FFFFFF">862,192 ns</td><td align="right" bgcolor="#FFFFFF">792,350 ns</td><td align="right" bgcolor="#FFFFFF">938,443 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">0,834 μs</td><td align="right" bgcolor="#FFFFFF">0,822 μs</td><td align="right" bgcolor="#FFFFFF">0,862 μs</td><td align="right" bgcolor="#FFFFFF">0,792 μs</td><td align="right" bgcolor="#FFFFFF">0,938 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_6_Format_Arguments"></a>Log_Error_Format_6_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 258,516 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1148,504 ns</td><td align="right" bgcolor="#FFFFFF">1029,096 ns</td><td align="right" bgcolor="#FFFFFF">1012,311 ns</td><td align="right" bgcolor="#FFFFFF">994,338 ns</td><td align="right" bgcolor="#FFFFFF">889,988 ns</td><td align="right" bgcolor="#FFFFFF">1089,213 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,149 μs</td><td align="right" bgcolor="#FFFFFF">1,029 μs</td><td align="right" bgcolor="#FFFFFF">1,012 μs</td><td align="right" bgcolor="#FFFFFF">0,994 μs</td><td align="right" bgcolor="#FFFFFF">0,890 μs</td><td align="right" bgcolor="#FFFFFF">1,089 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_7_Format_Arguments"></a>Log_Error_Format_7_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 403,477 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1407,760 ns</td><td align="right" bgcolor="#A8D08D">1047,310 ns (Δ = -360,450 ns)</td><td align="right" bgcolor="#FFFFFF">1052,223 ns</td><td align="right" bgcolor="#FFFFFF">1066,279 ns</td><td align="right" bgcolor="#FFFFFF">1004,283 ns</td><td align="right" bgcolor="#FFFFFF">1208,411 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,408 μs</td><td align="right" bgcolor="#FFFFFF">1,047 μs</td><td align="right" bgcolor="#FFFFFF">1,052 μs</td><td align="right" bgcolor="#FFFFFF">1,066 μs</td><td align="right" bgcolor="#FFFFFF">1,004 μs</td><td align="right" bgcolor="#FFFFFF">1,208 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#A8D08D">924,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#A8D08D">0,902 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


## <a name="Log_Info_Benchmark"></a>Log_Info_Benchmark

### <a name="Log_Info_Benchmark_Log_Info_Format_1_Format_Argument"></a>Log_Info_Format_1_Format_Argument

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 156,432 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">571,041 ns</td><td align="right" bgcolor="#FFFFFF">414,609 ns</td><td align="right" bgcolor="#FFFFFF">432,935 ns</td><td align="right" bgcolor="#FFFFFF">418,941 ns</td><td align="right" bgcolor="#FFFFFF">439,040 ns</td><td align="right" bgcolor="#FFFFFF">485,288 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,571 μs</td><td align="right" bgcolor="#FFFFFF">0,415 μs</td><td align="right" bgcolor="#FFFFFF">0,433 μs</td><td align="right" bgcolor="#FFFFFF">0,419 μs</td><td align="right" bgcolor="#FFFFFF">0,439 μs</td><td align="right" bgcolor="#FFFFFF">0,485 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_2_Format_Arguments"></a>Log_Info_Format_2_Format_Arguments

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 180,555 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">700,968 ns</td><td align="right" bgcolor="#FFFFFF">522,306 ns</td><td align="right" bgcolor="#FFFFFF">542,868 ns</td><td align="right" bgcolor="#FFFFFF">520,413 ns</td><td align="right" bgcolor="#FFFFFF">565,145 ns</td><td align="right" bgcolor="#FFFFFF">579,675 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,701 μs</td><td align="right" bgcolor="#FFFFFF">0,522 μs</td><td align="right" bgcolor="#FFFFFF">0,543 μs</td><td align="right" bgcolor="#FFFFFF">0,520 μs</td><td align="right" bgcolor="#FFFFFF">0,565 μs</td><td align="right" bgcolor="#FFFFFF">0,580 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">420,000</td><td align="right" bgcolor="#FFFFFF">420,000</td><td align="right" bgcolor="#FFFFFF">420,000</td><td align="right" bgcolor="#FFFFFF">420,000</td><td align="right" bgcolor="#FFFFFF">420,000</td><td align="right" bgcolor="#A8D08D">419,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,410</td><td align="right" bgcolor="#FFFFFF">0,410</td><td align="right" bgcolor="#FFFFFF">0,410</td><td align="right" bgcolor="#FFFFFF">0,410</td><td align="right" bgcolor="#FFFFFF">0,410</td><td align="right" bgcolor="#A8D08D">0,409 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_3_Format_Arguments"></a>Log_Info_Format_3_Format_Arguments

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 142,383 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">755,647 ns</td><td align="right" bgcolor="#FFFFFF">626,719 ns</td><td align="right" bgcolor="#FFFFFF">629,700 ns</td><td align="right" bgcolor="#FFFFFF">613,264 ns</td><td align="right" bgcolor="#FFFFFF">723,418 ns</td><td align="right" bgcolor="#FFFFFF">708,968 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,756 μs</td><td align="right" bgcolor="#FFFFFF">0,627 μs</td><td align="right" bgcolor="#FFFFFF">0,630 μs</td><td align="right" bgcolor="#FFFFFF">0,613 μs</td><td align="right" bgcolor="#FFFFFF">0,723 μs</td><td align="right" bgcolor="#FFFFFF">0,709 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">502,000</td><td align="right" bgcolor="#FFFFFF">502,000</td><td align="right" bgcolor="#FFFFFF">502,000</td><td align="right" bgcolor="#FFFFFF">502,000</td><td align="right" bgcolor="#FFFFFF">502,000</td><td align="right" bgcolor="#A8D08D">498,000 (Δ = -4,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,490</td><td align="right" bgcolor="#FFFFFF">0,490</td><td align="right" bgcolor="#FFFFFF">0,490</td><td align="right" bgcolor="#FFFFFF">0,490</td><td align="right" bgcolor="#FFFFFF">0,490</td><td align="right" bgcolor="#A8D08D">0,486 (Δ = -0,004)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_4_Format_Arguments"></a>Log_Info_Format_4_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 255,595 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">959,042 ns</td><td align="right" bgcolor="#FFFFFF">729,418 ns</td><td align="right" bgcolor="#FFFFFF">742,628 ns</td><td align="right" bgcolor="#FFFFFF">726,235 ns</td><td align="right" bgcolor="#FFFFFF">703,447 ns</td><td align="right" bgcolor="#FFFFFF">837,155 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,959 μs</td><td align="right" bgcolor="#FFFFFF">0,729 μs</td><td align="right" bgcolor="#FFFFFF">0,743 μs</td><td align="right" bgcolor="#FFFFFF">0,726 μs</td><td align="right" bgcolor="#FFFFFF">0,703 μs</td><td align="right" bgcolor="#FFFFFF">0,837 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FF4949">580,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FF4949">0,566 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_5_Format_Arguments"></a>Log_Info_Format_5_Format_Arguments

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 262,157 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">945,676 ns</td><td align="right" bgcolor="#FFFFFF">848,041 ns</td><td align="right" bgcolor="#FFFFFF">845,746 ns</td><td align="right" bgcolor="#FFFFFF">824,003 ns</td><td align="right" bgcolor="#FF4949">1086,160 ns (Δ = +262,157 ns)</td><td align="right" bgcolor="#FFFFFF">924,011 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,946 μs</td><td align="right" bgcolor="#FFFFFF">0,848 μs</td><td align="right" bgcolor="#FFFFFF">0,846 μs</td><td align="right" bgcolor="#FFFFFF">0,824 μs</td><td align="right" bgcolor="#FFFFFF">1,086 μs</td><td align="right" bgcolor="#FFFFFF">0,924 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_6_Format_Arguments"></a>Log_Info_Format_6_Format_Arguments

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 275,500 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+30,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1093,313 ns</td><td align="right" bgcolor="#FFFFFF">957,369 ns</td><td align="right" bgcolor="#FFFFFF">924,933 ns</td><td align="right" bgcolor="#FFFFFF">909,808 ns</td><td align="right" bgcolor="#FF4949">1185,308 ns (Δ = +275,500 ns)</td><td align="right" bgcolor="#FFFFFF">978,445 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,093 μs</td><td align="right" bgcolor="#FFFFFF">0,957 μs</td><td align="right" bgcolor="#FFFFFF">0,925 μs</td><td align="right" bgcolor="#FFFFFF">0,910 μs</td><td align="right" bgcolor="#FFFFFF">1,185 μs</td><td align="right" bgcolor="#FFFFFF">0,978 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#A8D08D">741,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#A8D08D">0,724 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments"></a>Log_Info_Format_7_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 262,023 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1198,756 ns</td><td align="right" bgcolor="#FFFFFF">984,789 ns</td><td align="right" bgcolor="#FFFFFF">994,196 ns</td><td align="right" bgcolor="#FFFFFF">1210,922 ns</td><td align="right" bgcolor="#A8D08D">948,898 ns (Δ = -262,023 ns)</td><td align="right" bgcolor="#FFFFFF">1101,987 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,199 μs</td><td align="right" bgcolor="#FFFFFF">0,985 μs</td><td align="right" bgcolor="#FFFFFF">0,994 μs</td><td align="right" bgcolor="#FFFFFF">1,211 μs</td><td align="right" bgcolor="#FFFFFF">0,949 μs</td><td align="right" bgcolor="#FFFFFF">1,102 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Status_Benchmark"></a>Log_Status_Benchmark

### <a name="Log_Status_Benchmark_Log_Status_Format_1_Format_Argument"></a>Log_Status_Format_1_Format_Argument

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 91,182 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">448,910 ns</td><td align="right" bgcolor="#FFFFFF">404,261 ns</td><td align="right" bgcolor="#FFFFFF">413,258 ns</td><td align="right" bgcolor="#FFFFFF">462,501 ns</td><td align="right" bgcolor="#FFFFFF">385,284 ns</td><td align="right" bgcolor="#FFFFFF">476,467 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,449 μs</td><td align="right" bgcolor="#FFFFFF">0,404 μs</td><td align="right" bgcolor="#FFFFFF">0,413 μs</td><td align="right" bgcolor="#FFFFFF">0,463 μs</td><td align="right" bgcolor="#FFFFFF">0,385 μs</td><td align="right" bgcolor="#FFFFFF">0,476 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FF4949">308,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FF4949">0,301 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_2_Format_Arguments"></a>Log_Status_Format_2_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 282,105 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">654,867 ns</td><td align="right" bgcolor="#FFFFFF">554,231 ns</td><td align="right" bgcolor="#FFFFFF">763,130 ns</td><td align="right" bgcolor="#FFFFFF">604,651 ns</td><td align="right" bgcolor="#FFFFFF">481,025 ns</td><td align="right" bgcolor="#FFFFFF">564,333 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,655 μs</td><td align="right" bgcolor="#FFFFFF">0,554 μs</td><td align="right" bgcolor="#FFFFFF">0,763 μs</td><td align="right" bgcolor="#FFFFFF">0,605 μs</td><td align="right" bgcolor="#FFFFFF">0,481 μs</td><td align="right" bgcolor="#FFFFFF">0,564 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FF4949">380,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FF4949">0,371 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_3_Format_Arguments"></a>Log_Status_Format_3_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 367,898 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+58,0 %</td><td align="right" bgcolor="#A8D08D">-36,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">819,730 ns</td><td align="right" bgcolor="#FFFFFF">607,212 ns</td><td align="right" bgcolor="#FF4949">959,360 ns (Δ = +352,148 ns)</td><td align="right" bgcolor="#A8D08D">611,467 ns (Δ = -347,893 ns)</td><td align="right" bgcolor="#FFFFFF">591,462 ns</td><td align="right" bgcolor="#FFFFFF">651,461 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,820 μs</td><td align="right" bgcolor="#FFFFFF">0,607 μs</td><td align="right" bgcolor="#FFFFFF">0,959 μs</td><td align="right" bgcolor="#FFFFFF">0,611 μs</td><td align="right" bgcolor="#FFFFFF">0,591 μs</td><td align="right" bgcolor="#FFFFFF">0,651 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FF4949">452,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FF4949">0,441 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments"></a>Log_Status_Format_4_Format_Arguments

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 295,323 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,7 %</td><td align="right" bgcolor="#A8D08D">-29,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">794,346 ns</td><td align="right" bgcolor="#FFFFFF">752,307 ns</td><td align="right" bgcolor="#FF4949">1013,355 ns (Δ = +261,048 ns)</td><td align="right" bgcolor="#A8D08D">718,031 ns (Δ = -295,323 ns)</td><td align="right" bgcolor="#FFFFFF">726,288 ns</td><td align="right" bgcolor="#FFFFFF">805,513 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,794 μs</td><td align="right" bgcolor="#FFFFFF">0,752 μs</td><td align="right" bgcolor="#FFFFFF">1,013 μs</td><td align="right" bgcolor="#FFFFFF">0,718 μs</td><td align="right" bgcolor="#FFFFFF">0,726 μs</td><td align="right" bgcolor="#FFFFFF">0,806 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FF4949">580,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FF4949">0,566 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_5_Format_Arguments"></a>Log_Status_Format_5_Format_Arguments

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 146,491 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">967,778 ns</td><td align="right" bgcolor="#FFFFFF">841,946 ns</td><td align="right" bgcolor="#FFFFFF">856,500 ns</td><td align="right" bgcolor="#FFFFFF">821,287 ns</td><td align="right" bgcolor="#FFFFFF">946,514 ns</td><td align="right" bgcolor="#FFFFFF">929,928 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,968 μs</td><td align="right" bgcolor="#FFFFFF">0,842 μs</td><td align="right" bgcolor="#FFFFFF">0,857 μs</td><td align="right" bgcolor="#FFFFFF">0,821 μs</td><td align="right" bgcolor="#FFFFFF">0,947 μs</td><td align="right" bgcolor="#FFFFFF">0,930 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_6_Format_Arguments"></a>Log_Status_Format_6_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 211,375 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1175,455 ns</td><td align="right" bgcolor="#FFFFFF">964,080 ns</td><td align="right" bgcolor="#FFFFFF">979,068 ns</td><td align="right" bgcolor="#FFFFFF">981,465 ns</td><td align="right" bgcolor="#FFFFFF">993,799 ns</td><td align="right" bgcolor="#FFFFFF">1110,883 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,175 μs</td><td align="right" bgcolor="#FFFFFF">0,964 μs</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">0,981 μs</td><td align="right" bgcolor="#FFFFFF">0,994 μs</td><td align="right" bgcolor="#FFFFFF">1,111 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_7_Format_Arguments"></a>Log_Status_Format_7_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 231,998 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1224,832 ns</td><td align="right" bgcolor="#FFFFFF">1235,272 ns</td><td align="right" bgcolor="#FFFFFF">1068,751 ns</td><td align="right" bgcolor="#FFFFFF">1080,064 ns</td><td align="right" bgcolor="#FFFFFF">1003,274 ns</td><td align="right" bgcolor="#FFFFFF">1207,704 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,225 μs</td><td align="right" bgcolor="#FFFFFF">1,235 μs</td><td align="right" bgcolor="#FFFFFF">1,069 μs</td><td align="right" bgcolor="#FFFFFF">1,080 μs</td><td align="right" bgcolor="#FFFFFF">1,003 μs</td><td align="right" bgcolor="#FFFFFF">1,208 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#A8D08D">924,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#A8D08D">0,902 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


## <a name="Log_Warning_Benchmark"></a>Log_Warning_Benchmark

### <a name="Log_Warning_Benchmark_Log_Warning_Format_1_Format_Argument"></a>Log_Warning_Format_1_Format_Argument

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 91,140 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">470,881 ns</td><td align="right" bgcolor="#FFFFFF">481,663 ns</td><td align="right" bgcolor="#FFFFFF">417,198 ns</td><td align="right" bgcolor="#FFFFFF">404,462 ns</td><td align="right" bgcolor="#FFFFFF">390,523 ns</td><td align="right" bgcolor="#FFFFFF">458,936 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,471 μs</td><td align="right" bgcolor="#FFFFFF">0,482 μs</td><td align="right" bgcolor="#FFFFFF">0,417 μs</td><td align="right" bgcolor="#FFFFFF">0,404 μs</td><td align="right" bgcolor="#FFFFFF">0,391 μs</td><td align="right" bgcolor="#FFFFFF">0,459 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FF4949">308,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FF4949">0,301 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_2_Format_Arguments"></a>Log_Warning_Format_2_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 165,451 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">587,533 ns</td><td align="right" bgcolor="#FFFFFF">626,102 ns</td><td align="right" bgcolor="#FFFFFF">515,884 ns</td><td align="right" bgcolor="#FFFFFF">517,101 ns</td><td align="right" bgcolor="#FFFFFF">460,651 ns</td><td align="right" bgcolor="#FFFFFF">564,885 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,588 μs</td><td align="right" bgcolor="#FFFFFF">0,626 μs</td><td align="right" bgcolor="#FFFFFF">0,516 μs</td><td align="right" bgcolor="#FFFFFF">0,517 μs</td><td align="right" bgcolor="#FFFFFF">0,461 μs</td><td align="right" bgcolor="#FFFFFF">0,565 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FF4949">380,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FF4949">0,371 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_3_Format_Arguments"></a>Log_Warning_Format_3_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 86,493 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">647,463 ns</td><td align="right" bgcolor="#FFFFFF">641,253 ns</td><td align="right" bgcolor="#FFFFFF">616,230 ns</td><td align="right" bgcolor="#FFFFFF">635,962 ns</td><td align="right" bgcolor="#FFFFFF">575,918 ns</td><td align="right" bgcolor="#FFFFFF">662,411 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,647 μs</td><td align="right" bgcolor="#FFFFFF">0,641 μs</td><td align="right" bgcolor="#FFFFFF">0,616 μs</td><td align="right" bgcolor="#FFFFFF">0,636 μs</td><td align="right" bgcolor="#FFFFFF">0,576 μs</td><td align="right" bgcolor="#FFFFFF">0,662 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FF4949">452,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FF4949">0,441 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_4_Format_Arguments"></a>Log_Warning_Format_4_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 120,829 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">806,245 ns</td><td align="right" bgcolor="#FFFFFF">719,491 ns</td><td align="right" bgcolor="#FFFFFF">722,911 ns</td><td align="right" bgcolor="#FFFFFF">778,572 ns</td><td align="right" bgcolor="#FFFFFF">693,611 ns</td><td align="right" bgcolor="#FFFFFF">814,440 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,806 μs</td><td align="right" bgcolor="#FFFFFF">0,719 μs</td><td align="right" bgcolor="#FFFFFF">0,723 μs</td><td align="right" bgcolor="#FFFFFF">0,779 μs</td><td align="right" bgcolor="#FFFFFF">0,694 μs</td><td align="right" bgcolor="#FFFFFF">0,814 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FF4949">580,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FF4949">0,566 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_5_Format_Arguments"></a>Log_Warning_Format_5_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 195,399 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1017,707 ns</td><td align="right" bgcolor="#FFFFFF">834,405 ns</td><td align="right" bgcolor="#FFFFFF">916,789 ns</td><td align="right" bgcolor="#FFFFFF">911,324 ns</td><td align="right" bgcolor="#FFFFFF">822,308 ns</td><td align="right" bgcolor="#FFFFFF">1003,477 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,018 μs</td><td align="right" bgcolor="#FFFFFF">0,834 μs</td><td align="right" bgcolor="#FFFFFF">0,917 μs</td><td align="right" bgcolor="#FFFFFF">0,911 μs</td><td align="right" bgcolor="#FFFFFF">0,822 μs</td><td align="right" bgcolor="#FFFFFF">1,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_6_Format_Arguments"></a>Log_Warning_Format_6_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 223,923 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1168,198 ns</td><td align="right" bgcolor="#FFFFFF">1001,528 ns</td><td align="right" bgcolor="#FFFFFF">1068,740 ns</td><td align="right" bgcolor="#FFFFFF">972,957 ns</td><td align="right" bgcolor="#FFFFFF">944,274 ns</td><td align="right" bgcolor="#FFFFFF">1158,931 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,168 μs</td><td align="right" bgcolor="#FFFFFF">1,002 μs</td><td align="right" bgcolor="#FFFFFF">1,069 μs</td><td align="right" bgcolor="#FFFFFF">0,973 μs</td><td align="right" bgcolor="#FFFFFF">0,944 μs</td><td align="right" bgcolor="#FFFFFF">1,159 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments"></a>Log_Warning_Format_7_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 260,675 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1195,470 ns</td><td align="right" bgcolor="#FFFFFF">1094,397 ns</td><td align="right" bgcolor="#FFFFFF">1253,894 ns</td><td align="right" bgcolor="#FFFFFF">1078,907 ns</td><td align="right" bgcolor="#FFFFFF">993,219 ns</td><td align="right" bgcolor="#FFFFFF">1232,080 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,195 μs</td><td align="right" bgcolor="#FFFFFF">1,094 μs</td><td align="right" bgcolor="#FFFFFF">1,254 μs</td><td align="right" bgcolor="#FFFFFF">1,079 μs</td><td align="right" bgcolor="#FFFFFF">0,993 μs</td><td align="right" bgcolor="#FFFFFF">1,232 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#A8D08D">924,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#A8D08D">0,902 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 361,834 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2352,851 ns</td><td align="right" bgcolor="#A8D08D">2007,560 ns (Δ = -345,292 ns)</td><td align="right" bgcolor="#FFFFFF">1991,017 ns</td><td align="right" bgcolor="#FFFFFF">2047,940 ns</td><td align="right" bgcolor="#FFFFFF">2071,365 ns</td><td align="right" bgcolor="#FFFFFF">2212,504 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,353 μs</td><td align="right" bgcolor="#FFFFFF">2,008 μs</td><td align="right" bgcolor="#FFFFFF">1,991 μs</td><td align="right" bgcolor="#FFFFFF">2,048 μs</td><td align="right" bgcolor="#FFFFFF">2,071 μs</td><td align="right" bgcolor="#FFFFFF">2,213 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#A8D08D">347,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#A8D08D">0,339 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 1556,412 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+36,3 %</td><td align="right" bgcolor="#A8D08D">-24,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4114,360 ns</td><td align="right" bgcolor="#A8D08D">3572,626 ns (Δ = -541,734 ns)</td><td align="right" bgcolor="#FFFFFF">3429,079 ns</td><td align="right" bgcolor="#FFFFFF">3657,042 ns</td><td align="right" bgcolor="#FF4949">4985,491 ns (Δ = +1328,449 ns)</td><td align="right" bgcolor="#A8D08D">3772,077 ns (Δ = -1213,414 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,114 μs</td><td align="right" bgcolor="#FFFFFF">3,573 μs</td><td align="right" bgcolor="#FFFFFF">3,429 μs</td><td align="right" bgcolor="#FFFFFF">3,657 μs</td><td align="right" bgcolor="#FFFFFF">4,985 μs</td><td align="right" bgcolor="#FFFFFF">3,772 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#A8D08D">723,000 (Δ = -4,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#A8D08D">0,706 (Δ = -0,004)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 1311,434 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-29,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3731,820 ns</td><td align="right" bgcolor="#FF4949">4051,170 ns (Δ = +319,350 ns)</td><td align="right" bgcolor="#A8D08D">2851,049 ns (Δ = -1200,121 ns)</td><td align="right" bgcolor="#FFFFFF">2739,736 ns</td><td align="right" bgcolor="#FFFFFF">2767,169 ns</td><td align="right" bgcolor="#FFFFFF">2913,173 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,732 μs</td><td align="right" bgcolor="#FFFFFF">4,051 μs</td><td align="right" bgcolor="#FFFFFF">2,851 μs</td><td align="right" bgcolor="#FFFFFF">2,740 μs</td><td align="right" bgcolor="#FFFFFF">2,767 μs</td><td align="right" bgcolor="#FFFFFF">2,913 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#A8D08D">675,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#A8D08D">0,659 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 1000,271 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+45,4 %</td><td align="right" bgcolor="#A8D08D">-26,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2556,094 ns</td><td align="right" bgcolor="#A8D08D">2077,588 ns (Δ = -478,506 ns)</td><td align="right" bgcolor="#FFFFFF">1989,547 ns</td><td align="right" bgcolor="#FFFFFF">2055,949 ns</td><td align="right" bgcolor="#FF4949">2989,818 ns (Δ = +933,869 ns)</td><td align="right" bgcolor="#A8D08D">2184,165 ns (Δ = -805,652 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,556 μs</td><td align="right" bgcolor="#FFFFFF">2,078 μs</td><td align="right" bgcolor="#FFFFFF">1,990 μs</td><td align="right" bgcolor="#FFFFFF">2,056 μs</td><td align="right" bgcolor="#FFFFFF">2,990 μs</td><td align="right" bgcolor="#FFFFFF">2,184 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#A8D08D">347,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#A8D08D">0,339 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 1672,931 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+43,1 %</td><td align="right" bgcolor="#A8D08D">-28,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4099,840 ns</td><td align="right" bgcolor="#FFFFFF">3877,144 ns</td><td align="right" bgcolor="#A8D08D">3479,622 ns (Δ = -397,522 ns)</td><td align="right" bgcolor="#FFFFFF">3600,529 ns</td><td align="right" bgcolor="#FF4949">5152,554 ns (Δ = +1552,025 ns)</td><td align="right" bgcolor="#A8D08D">3698,045 ns (Δ = -1454,508 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,100 μs</td><td align="right" bgcolor="#FFFFFF">3,877 μs</td><td align="right" bgcolor="#FFFFFF">3,480 μs</td><td align="right" bgcolor="#FFFFFF">3,601 μs</td><td align="right" bgcolor="#FFFFFF">5,153 μs</td><td align="right" bgcolor="#FFFFFF">3,698 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#A8D08D">723,000 (Δ = -4,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#A8D08D">0,706 (Δ = -0,004)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 2856,645 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+65,4 %</td><td align="right" bgcolor="#A8D08D">-37,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4983,199 ns</td><td align="right" bgcolor="#A8D08D">4266,971 ns (Δ = -716,228 ns)</td><td align="right" bgcolor="#FFFFFF">4190,502 ns</td><td align="right" bgcolor="#FFFFFF">4261,174 ns</td><td align="right" bgcolor="#FF4949">7047,147 ns (Δ = +2785,973 ns)</td><td align="right" bgcolor="#A8D08D">4387,416 ns (Δ = -2659,731 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,983 μs</td><td align="right" bgcolor="#FFFFFF">4,267 μs</td><td align="right" bgcolor="#FFFFFF">4,191 μs</td><td align="right" bgcolor="#FFFFFF">4,261 μs</td><td align="right" bgcolor="#FFFFFF">7,047 μs</td><td align="right" bgcolor="#FFFFFF">4,387 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1096,000</td><td align="right" bgcolor="#FFFFFF">1096,000</td><td align="right" bgcolor="#FFFFFF">1096,000</td><td align="right" bgcolor="#FFFFFF">1096,000</td><td align="right" bgcolor="#FFFFFF">1096,000</td><td align="right" bgcolor="#A8D08D">1094,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,070</td><td align="right" bgcolor="#FFFFFF">1,070</td><td align="right" bgcolor="#FFFFFF">1,070</td><td align="right" bgcolor="#FFFFFF">1,070</td><td align="right" bgcolor="#FFFFFF">1,070</td><td align="right" bgcolor="#A8D08D">1,068 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


## <a name="ModelBase_Constructor_Benchmark"></a>ModelBase_Constructor_Benchmark

### <a name="ModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 645,503 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2994,817 ns</td><td align="right" bgcolor="#A8D08D">2438,903 ns (Δ = -555,913 ns)</td><td align="right" bgcolor="#FFFFFF">2349,314 ns</td><td align="right" bgcolor="#FF4949">2613,021 ns (Δ = +263,707 ns)</td><td align="right" bgcolor="#FFFFFF">2551,400 ns</td><td align="right" bgcolor="#FFFFFF">2352,640 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,995 μs</td><td align="right" bgcolor="#FFFFFF">2,439 μs</td><td align="right" bgcolor="#FFFFFF">2,349 μs</td><td align="right" bgcolor="#FFFFFF">2,613 μs</td><td align="right" bgcolor="#FFFFFF">2,551 μs</td><td align="right" bgcolor="#FFFFFF">2,353 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">975,000</td><td align="right" bgcolor="#A8D08D">973,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#A8D08D">934,000 (Δ = -39,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,952</td><td align="right" bgcolor="#A8D08D">0,950 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#A8D08D">0,912 (Δ = -0,038)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 130,753 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">446,878 ns</td><td align="right" bgcolor="#FFFFFF">413,428 ns</td><td align="right" bgcolor="#FFFFFF">329,342 ns</td><td align="right" bgcolor="#FFFFFF">331,757 ns</td><td align="right" bgcolor="#FFFFFF">316,125 ns</td><td align="right" bgcolor="#FFFFFF">337,219 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,447 μs</td><td align="right" bgcolor="#FFFFFF">0,413 μs</td><td align="right" bgcolor="#FFFFFF">0,329 μs</td><td align="right" bgcolor="#FFFFFF">0,332 μs</td><td align="right" bgcolor="#FFFFFF">0,316 μs</td><td align="right" bgcolor="#FFFFFF">0,337 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#A8D08D">59,000 (Δ = -23,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#A8D08D">0,058 (Δ = -0,022)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 128,780 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">474,159 ns</td><td align="right" bgcolor="#FFFFFF">345,378 ns</td><td align="right" bgcolor="#FFFFFF">351,560 ns</td><td align="right" bgcolor="#FFFFFF">351,163 ns</td><td align="right" bgcolor="#FFFFFF">394,155 ns</td><td align="right" bgcolor="#FFFFFF">367,944 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,474 μs</td><td align="right" bgcolor="#FFFFFF">0,345 μs</td><td align="right" bgcolor="#FFFFFF">0,352 μs</td><td align="right" bgcolor="#FFFFFF">0,351 μs</td><td align="right" bgcolor="#FFFFFF">0,394 μs</td><td align="right" bgcolor="#FFFFFF">0,368 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#A8D08D">59,000 (Δ = -23,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#A8D08D">0,058 (Δ = -0,022)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 132,712 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">311,182 ns</td><td align="right" bgcolor="#FFFFFF">266,051 ns</td><td align="right" bgcolor="#FFFFFF">271,105 ns</td><td align="right" bgcolor="#FFFFFF">257,248 ns</td><td align="right" bgcolor="#FFFFFF">389,960 ns</td><td align="right" bgcolor="#FFFFFF">331,003 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,311 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td><td align="right" bgcolor="#FFFFFF">0,271 μs</td><td align="right" bgcolor="#FFFFFF">0,257 μs</td><td align="right" bgcolor="#FFFFFF">0,390 μs</td><td align="right" bgcolor="#FFFFFF">0,331 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FF4949">59,000 (Δ = +3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FF4949">0,058 (Δ = +0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="ObjectHelper_Benchmark"></a>ObjectHelper_Benchmark

### <a name="ObjectHelper_Benchmark_AreEqual__Same_Reference"></a>AreEqual__Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 3,161 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,331 ns</td><td align="right" bgcolor="#FFFFFF">2,083 ns</td><td align="right" bgcolor="#FFFFFF">1,951 ns</td><td align="right" bgcolor="#FFFFFF">1,958 ns</td><td align="right" bgcolor="#FFFFFF">1,393 ns</td><td align="right" bgcolor="#FFFFFF">4,492 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Both_Null"></a>AreEqual_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 2,912 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,342 ns</td><td align="right" bgcolor="#FFFFFF">3,136 ns</td><td align="right" bgcolor="#FFFFFF">1,658 ns</td><td align="right" bgcolor="#FFFFFF">1,619 ns</td><td align="right" bgcolor="#FFFFFF">1,466 ns</td><td align="right" bgcolor="#FFFFFF">4,253 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Not_Same_Reference"></a>AreEqual_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 5,950 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,421 ns</td><td align="right" bgcolor="#FFFFFF">5,503 ns</td><td align="right" bgcolor="#FFFFFF">5,466 ns</td><td align="right" bgcolor="#FFFFFF">5,549 ns</td><td align="right" bgcolor="#FFFFFF">4,849 ns</td><td align="right" bgcolor="#FFFFFF">10,371 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_One_Null"></a>AreEqual_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 2,354 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,363 ns</td><td align="right" bgcolor="#FFFFFF">2,014 ns</td><td align="right" bgcolor="#FFFFFF">2,322 ns</td><td align="right" bgcolor="#FFFFFF">2,253 ns</td><td align="right" bgcolor="#FFFFFF">1,423 ns</td><td align="right" bgcolor="#FFFFFF">3,717 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Strings"></a>AreEqual_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 3,001 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,410 ns</td><td align="right" bgcolor="#FFFFFF">6,960 ns</td><td align="right" bgcolor="#FFFFFF">5,803 ns</td><td align="right" bgcolor="#FFFFFF">5,670 ns</td><td align="right" bgcolor="#FFFFFF">5,670 ns</td><td align="right" bgcolor="#FFFFFF">8,411 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Both_Null"></a>AreEqualReferences_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 2,704 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,260 ns</td><td align="right" bgcolor="#FFFFFF">2,011 ns</td><td align="right" bgcolor="#FFFFFF">1,934 ns</td><td align="right" bgcolor="#FFFFFF">1,867 ns</td><td align="right" bgcolor="#FFFFFF">1,473 ns</td><td align="right" bgcolor="#FFFFFF">3,964 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Not_Same_Reference"></a>AreEqualReferences_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 17,984 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">33,374 ns</td><td align="right" bgcolor="#FFFFFF">41,896 ns</td><td align="right" bgcolor="#FFFFFF">35,566 ns</td><td align="right" bgcolor="#FFFFFF">34,383 ns</td><td align="right" bgcolor="#FFFFFF">36,044 ns</td><td align="right" bgcolor="#FFFFFF">51,357 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_One_Null"></a>AreEqualReferences_One_Null

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 1,252 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,499 ns</td><td align="right" bgcolor="#FFFFFF">2,091 ns</td><td align="right" bgcolor="#FFFFFF">1,878 ns</td><td align="right" bgcolor="#FFFFFF">1,813 ns</td><td align="right" bgcolor="#FFFFFF">1,473 ns</td><td align="right" bgcolor="#FFFFFF">2,725 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Same_Reference"></a>AreEqualReferences_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 5,827 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,446 ns</td><td align="right" bgcolor="#FFFFFF">1,617 ns</td><td align="right" bgcolor="#FFFFFF">1,644 ns</td><td align="right" bgcolor="#FFFFFF">1,518 ns</td><td align="right" bgcolor="#FFFFFF">1,495 ns</td><td align="right" bgcolor="#FFFFFF">7,273 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Strings"></a>AreEqualReferences_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 11,902 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">50,726 ns</td><td align="right" bgcolor="#FFFFFF">62,628 ns</td><td align="right" bgcolor="#FFFFFF">55,451 ns</td><td align="right" bgcolor="#FFFFFF">56,071 ns</td><td align="right" bgcolor="#FFFFFF">52,823 ns</td><td align="right" bgcolor="#FFFFFF">57,715 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_IsNull"></a>IsNull

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 0,945 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,207 ns</td><td align="right" bgcolor="#FFFFFF">0,466 ns</td><td align="right" bgcolor="#FFFFFF">0,239 ns</td><td align="right" bgcolor="#FFFFFF">0,256 ns</td><td align="right" bgcolor="#FFFFFF">0,277 ns</td><td align="right" bgcolor="#FFFFFF">1,152 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ObjectToStringHelper_Benchmark"></a>ObjectToStringHelper_Benchmark

### <a name="ObjectToStringHelper_Benchmark_ToFullTypeString"></a>ToFullTypeString

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 19,640 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">70,405 ns</td><td align="right" bgcolor="#FFFFFF">90,045 ns</td><td align="right" bgcolor="#FFFFFF">74,980 ns</td><td align="right" bgcolor="#FFFFFF">73,673 ns</td><td align="right" bgcolor="#FFFFFF">76,673 ns</td><td align="right" bgcolor="#FFFFFF">80,349 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectToStringHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 2278,490 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+24,0 %</td><td align="right" bgcolor="#A8D08D">-22,0 %</td><td align="right" bgcolor="#FF4949">+12,6 %</td><td align="right" bgcolor="#A8D08D">-86,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2085,767 ns</td><td align="right" bgcolor="#FF4949">2586,779 ns (Δ = +501,013 ns)</td><td align="right" bgcolor="#A8D08D">2018,363 ns (Δ = -568,417 ns)</td><td align="right" bgcolor="#FF4949">2273,592 ns (Δ = +255,230 ns)</td><td align="right" bgcolor="#A8D08D">308,290 ns (Δ = -1965,303 ns)</td><td align="right" bgcolor="#FFFFFF">320,763 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,086 μs</td><td align="right" bgcolor="#FFFFFF">2,587 μs</td><td align="right" bgcolor="#FFFFFF">2,018 μs</td><td align="right" bgcolor="#FFFFFF">2,274 μs</td><td align="right" bgcolor="#FFFFFF">0,308 μs</td><td align="right" bgcolor="#FFFFFF">0,321 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-92,8 %</td><td align="right" bgcolor="#A8D08D">-1,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1746,000</td><td align="right" bgcolor="#A8D08D">1715,000 (Δ = -31,000)</td><td align="right" bgcolor="#FFFFFF">1715,000</td><td align="right" bgcolor="#FFFFFF">1715,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -1592,000)</td><td align="right" bgcolor="#A8D08D">121,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,705</td><td align="right" bgcolor="#A8D08D">1,675 (Δ = -0,030)</td><td align="right" bgcolor="#FFFFFF">1,675</td><td align="right" bgcolor="#FFFFFF">1,675</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -1,555)</td><td align="right" bgcolor="#A8D08D">0,118 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ObjectToStringHelper_Benchmark_ToTypeString"></a>ToTypeString

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 5,328 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,512 ns</td><td align="right" bgcolor="#FFFFFF">23,840 ns</td><td align="right" bgcolor="#FFFFFF">18,616 ns</td><td align="right" bgcolor="#FFFFFF">19,274 ns</td><td align="right" bgcolor="#FFFFFF">19,401 ns</td><td align="right" bgcolor="#FFFFFF">22,216 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ParallelHelper_Benchmark"></a>ParallelHelper_Benchmark

### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100"></a>ExecuteInParallel_ItemsPerBash_100

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 373123,230 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,1 %</td><td align="right" bgcolor="#FF4949">+4,5 %</td><td align="right" bgcolor="#A8D08D">-13,1 %</td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#FF4949">+8,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2315143,655 ns</td><td align="right" bgcolor="#FF4949">2503017,086 ns (Δ = +187873,431 ns)</td><td align="right" bgcolor="#FF4949">2615259,958 ns (Δ = +112242,872 ns)</td><td align="right" bgcolor="#A8D08D">2273457,167 ns (Δ = -341802,790 ns)</td><td align="right" bgcolor="#A8D08D">2242136,727 ns (Δ = -31320,440 ns)</td><td align="right" bgcolor="#FF4949">2436250,516 ns (Δ = +194113,789 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2315,144 μs</td><td align="right" bgcolor="#FFFFFF">2503,017 μs</td><td align="right" bgcolor="#FFFFFF">2615,260 μs</td><td align="right" bgcolor="#A8D08D">2273,457 μs (Δ = -341,803 μs)</td><td align="right" bgcolor="#FFFFFF">2242,137 μs</td><td align="right" bgcolor="#FFFFFF">2436,251 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,315 ms</td><td align="right" bgcolor="#FFFFFF">2,503 ms</td><td align="right" bgcolor="#FFFFFF">2,615 ms</td><td align="right" bgcolor="#FFFFFF">2,273 ms</td><td align="right" bgcolor="#FFFFFF">2,242 ms</td><td align="right" bgcolor="#FFFFFF">2,436 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">129,000</td><td align="right" bgcolor="#FFFFFF">129,000</td><td align="right" bgcolor="#A8D08D">128,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">128,000</td><td align="right" bgcolor="#FFFFFF">128,000</td><td align="right" bgcolor="#FF4949">199,000 (Δ = +71,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#A8D08D">-0,5 %</td><td align="right" bgcolor="#FF4949">+0,2 %</td><td align="right" bgcolor="#A8D08D">-0,2 %</td><td align="right" bgcolor="#A8D08D">-0,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169272,000</td><td align="right" bgcolor="#A8D08D">169185,000 (Δ = -87,000)</td><td align="right" bgcolor="#A8D08D">168343,000 (Δ = -842,000)</td><td align="right" bgcolor="#FF4949">168728,000 (Δ = +385,000)</td><td align="right" bgcolor="#A8D08D">168317,000 (Δ = -411,000)</td><td align="right" bgcolor="#A8D08D">167540,000 (Δ = -777,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">165,305</td><td align="right" bgcolor="#A8D08D">165,220 (Δ = -0,085)</td><td align="right" bgcolor="#A8D08D">164,397 (Δ = -0,822)</td><td align="right" bgcolor="#FF4949">164,773 (Δ = +0,376)</td><td align="right" bgcolor="#A8D08D">164,372 (Δ = -0,401)</td><td align="right" bgcolor="#A8D08D">163,613 (Δ = -0,759)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,161</td><td align="right" bgcolor="#A8D08D">0,161 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,161 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,161 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,161 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,001)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000"></a>ExecuteInParallel_ItemsPerBash_1000

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 245278,952 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+46,8 %</td><td align="right" bgcolor="#A8D08D">-28,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+24,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">524654,574 ns</td><td align="right" bgcolor="#FF4949">769933,526 ns (Δ = +245278,952 ns)</td><td align="right" bgcolor="#A8D08D">549679,945 ns (Δ = -220253,581 ns)</td><td align="right" bgcolor="#FFFFFF">547389,372 ns</td><td align="right" bgcolor="#FFFFFF">544110,520 ns</td><td align="right" bgcolor="#FF4949">677808,121 ns (Δ = +133697,602 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">524,655 μs</td><td align="right" bgcolor="#FFFFFF">769,934 μs</td><td align="right" bgcolor="#FFFFFF">549,680 μs</td><td align="right" bgcolor="#FFFFFF">547,389 μs</td><td align="right" bgcolor="#FFFFFF">544,111 μs</td><td align="right" bgcolor="#FFFFFF">677,808 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,525 ms</td><td align="right" bgcolor="#FFFFFF">0,770 ms</td><td align="right" bgcolor="#FFFFFF">0,550 ms</td><td align="right" bgcolor="#FFFFFF">0,547 ms</td><td align="right" bgcolor="#FFFFFF">0,544 ms</td><td align="right" bgcolor="#FFFFFF">0,678 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.9</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.6</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">69,000</td><td align="right" bgcolor="#FFFFFF">69,000</td><td align="right" bgcolor="#FFFFFF">69,000</td><td align="right" bgcolor="#FFFFFF">69,000</td><td align="right" bgcolor="#FFFFFF">69,000</td><td align="right" bgcolor="#FF4949">108,000 (Δ = +39,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#FF4949">+0,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">91219,000</td><td align="right" bgcolor="#A8D08D">91171,000 (Δ = -48,000)</td><td align="right" bgcolor="#FF4949">91223,000 (Δ = +52,000)</td><td align="right" bgcolor="#A8D08D">91110,000 (Δ = -113,000)</td><td align="right" bgcolor="#FF4949">91228,000 (Δ = +118,000)</td><td align="right" bgcolor="#FF4949">91639,000 (Δ = +411,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">89,081</td><td align="right" bgcolor="#A8D08D">89,034 (Δ = -0,047)</td><td align="right" bgcolor="#FF4949">89,085 (Δ = +0,051)</td><td align="right" bgcolor="#A8D08D">88,975 (Δ = -0,110)</td><td align="right" bgcolor="#FF4949">89,090 (Δ = +0,115)</td><td align="right" bgcolor="#FF4949">89,491 (Δ = +0,401)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,087</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,000)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500"></a>ExecuteInParallel_ItemsPerBash_500

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 327448,242 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+37,1 %</td><td align="right" bgcolor="#A8D08D">-28,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">745758,500 ns</td><td align="right" bgcolor="#FF4949">1022528,568 ns (Δ = +276770,068 ns)</td><td align="right" bgcolor="#A8D08D">736099,012 ns (Δ = -286429,556 ns)</td><td align="right" bgcolor="#FFFFFF">729457,945 ns</td><td align="right" bgcolor="#FFFFFF">724401,313 ns</td><td align="right" bgcolor="#A8D08D">695080,325 ns (Δ = -29320,987 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">745,759 μs</td><td align="right" bgcolor="#FF4949">1022,529 μs (Δ = +276,770 μs)</td><td align="right" bgcolor="#A8D08D">736,099 μs (Δ = -286,430 μs)</td><td align="right" bgcolor="#FFFFFF">729,458 μs</td><td align="right" bgcolor="#FFFFFF">724,401 μs</td><td align="right" bgcolor="#FFFFFF">695,080 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,746 ms</td><td align="right" bgcolor="#FFFFFF">1,023 ms</td><td align="right" bgcolor="#FFFFFF">0,736 ms</td><td align="right" bgcolor="#FFFFFF">0,729 ms</td><td align="right" bgcolor="#FFFFFF">0,724 ms</td><td align="right" bgcolor="#FFFFFF">0,695 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.5</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FF4949">115,000 (Δ = +41,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#A8D08D">-0,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">97906,000</td><td align="right" bgcolor="#A8D08D">97730,000 (Δ = -176,000)</td><td align="right" bgcolor="#FF4949">98129,000 (Δ = +399,000)</td><td align="right" bgcolor="#A8D08D">98004,000 (Δ = -125,000)</td><td align="right" bgcolor="#A8D08D">97857,000 (Δ = -147,000)</td><td align="right" bgcolor="#A8D08D">97176,000 (Δ = -681,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">95,611</td><td align="right" bgcolor="#A8D08D">95,439 (Δ = -0,172)</td><td align="right" bgcolor="#FF4949">95,829 (Δ = +0,390)</td><td align="right" bgcolor="#A8D08D">95,707 (Δ = -0,122)</td><td align="right" bgcolor="#A8D08D">95,563 (Δ = -0,144)</td><td align="right" bgcolor="#A8D08D">94,898 (Δ = -0,665)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,093</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,094 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,001)</td></tr></table>


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 12,986 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">94,730 ns</td><td align="right" bgcolor="#FFFFFF">83,296 ns</td><td align="right" bgcolor="#FFFFFF">86,181 ns</td><td align="right" bgcolor="#FFFFFF">95,606 ns</td><td align="right" bgcolor="#FFFFFF">85,412 ns</td><td align="right" bgcolor="#FFFFFF">96,283 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 22,655 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">101,044 ns</td><td align="right" bgcolor="#FFFFFF">80,463 ns</td><td align="right" bgcolor="#FFFFFF">84,797 ns</td><td align="right" bgcolor="#FFFFFF">87,515 ns</td><td align="right" bgcolor="#FFFFFF">78,389 ns</td><td align="right" bgcolor="#FFFFFF">80,821 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 15,044 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">62,028 ns</td><td align="right" bgcolor="#FFFFFF">50,697 ns</td><td align="right" bgcolor="#FFFFFF">50,563 ns</td><td align="right" bgcolor="#FFFFFF">51,894 ns</td><td align="right" bgcolor="#FFFFFF">49,068 ns</td><td align="right" bgcolor="#FFFFFF">46,984 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 1000,831 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+44,7 %</td><td align="right" bgcolor="#A8D08D">-28,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2417,795 ns</td><td align="right" bgcolor="#A8D08D">1931,685 ns (Δ = -486,110 ns)</td><td align="right" bgcolor="#FFFFFF">1900,277 ns</td><td align="right" bgcolor="#FFFFFF">2005,200 ns</td><td align="right" bgcolor="#FF4949">2901,109 ns (Δ = +895,908 ns)</td><td align="right" bgcolor="#A8D08D">2067,632 ns (Δ = -833,477 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,418 μs</td><td align="right" bgcolor="#FFFFFF">1,932 μs</td><td align="right" bgcolor="#FFFFFF">1,900 μs</td><td align="right" bgcolor="#FFFFFF">2,005 μs</td><td align="right" bgcolor="#FFFFFF">2,901 μs</td><td align="right" bgcolor="#FFFFFF">2,068 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#A8D08D">321,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#A8D08D">0,313 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 407,597 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-34,5 %</td><td align="right" bgcolor="#FF4949">+54,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-41,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">681,025 ns</td><td align="right" bgcolor="#FFFFFF">863,286 ns</td><td align="right" bgcolor="#A8D08D">565,408 ns (Δ = -297,877 ns)</td><td align="right" bgcolor="#FF4949">874,128 ns (Δ = +308,720 ns)</td><td align="right" bgcolor="#FFFFFF">973,005 ns</td><td align="right" bgcolor="#A8D08D">566,075 ns (Δ = -406,931 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,681 μs</td><td align="right" bgcolor="#FFFFFF">0,863 μs</td><td align="right" bgcolor="#FFFFFF">0,565 μs</td><td align="right" bgcolor="#FFFFFF">0,874 μs</td><td align="right" bgcolor="#FFFFFF">0,973 μs</td><td align="right" bgcolor="#FFFFFF">0,566 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#A8D08D">75,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#A8D08D">0,073 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 1999,034 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,0 %</td><td align="right" bgcolor="#A8D08D">-23,6 %</td><td align="right" bgcolor="#FF4949">+21,5 %</td><td align="right" bgcolor="#FF4949">+50,4 %</td><td align="right" bgcolor="#A8D08D">-43,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2747,964 ns</td><td align="right" bgcolor="#FF4949">3161,512 ns (Δ = +413,548 ns)</td><td align="right" bgcolor="#A8D08D">2415,466 ns (Δ = -746,046 ns)</td><td align="right" bgcolor="#FF4949">2935,746 ns (Δ = +520,281 ns)</td><td align="right" bgcolor="#FF4949">4414,500 ns (Δ = +1478,754 ns)</td><td align="right" bgcolor="#A8D08D">2488,215 ns (Δ = -1926,285 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,748 μs</td><td align="right" bgcolor="#FFFFFF">3,162 μs</td><td align="right" bgcolor="#FFFFFF">2,415 μs</td><td align="right" bgcolor="#FFFFFF">2,936 μs</td><td align="right" bgcolor="#FFFFFF">4,415 μs</td><td align="right" bgcolor="#FFFFFF">2,488 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">589,000</td><td align="right" bgcolor="#FFFFFF">589,000</td><td align="right" bgcolor="#FFFFFF">589,000</td><td align="right" bgcolor="#FFFFFF">589,000</td><td align="right" bgcolor="#FFFFFF">589,000</td><td align="right" bgcolor="#A8D08D">587,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,575</td><td align="right" bgcolor="#FFFFFF">0,575</td><td align="right" bgcolor="#FFFFFF">0,575</td><td align="right" bgcolor="#FFFFFF">0,575</td><td align="right" bgcolor="#FFFFFF">0,575</td><td align="right" bgcolor="#A8D08D">0,573 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 2100,756 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+71,8 %</td><td align="right" bgcolor="#A8D08D">-52,8 %</td><td align="right" bgcolor="#FF4949">+44,4 %</td><td align="right" bgcolor="#FF4949">+22,0 %</td><td align="right" bgcolor="#A8D08D">-30,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2316,675 ns</td><td align="right" bgcolor="#FF4949">3978,931 ns (Δ = +1662,256 ns)</td><td align="right" bgcolor="#A8D08D">1878,175 ns (Δ = -2100,756 ns)</td><td align="right" bgcolor="#FF4949">2711,809 ns (Δ = +833,634 ns)</td><td align="right" bgcolor="#FF4949">3307,789 ns (Δ = +595,980 ns)</td><td align="right" bgcolor="#A8D08D">2295,599 ns (Δ = -1012,190 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,317 μs</td><td align="right" bgcolor="#FFFFFF">3,979 μs</td><td align="right" bgcolor="#FFFFFF">1,878 μs</td><td align="right" bgcolor="#FFFFFF">2,712 μs</td><td align="right" bgcolor="#FFFFFF">3,308 μs</td><td align="right" bgcolor="#FFFFFF">2,296 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#A8D08D">321,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#A8D08D">0,313 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 515,927 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+46,3 %</td><td align="right" bgcolor="#FF4949">+30,9 %</td><td align="right" bgcolor="#A8D08D">-44,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">692,920 ns</td><td align="right" bgcolor="#FFFFFF">554,352 ns</td><td align="right" bgcolor="#FFFFFF">558,820 ns</td><td align="right" bgcolor="#FF4949">817,466 ns (Δ = +258,646 ns)</td><td align="right" bgcolor="#FF4949">1070,279 ns (Δ = +252,813 ns)</td><td align="right" bgcolor="#A8D08D">590,731 ns (Δ = -479,548 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,693 μs</td><td align="right" bgcolor="#FFFFFF">0,554 μs</td><td align="right" bgcolor="#FFFFFF">0,559 μs</td><td align="right" bgcolor="#FFFFFF">0,817 μs</td><td align="right" bgcolor="#FFFFFF">1,070 μs</td><td align="right" bgcolor="#FFFFFF">0,591 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#A8D08D">75,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#A8D08D">0,073 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 402,393 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-35,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+42,2 %</td><td align="right" bgcolor="#A8D08D">-43,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">621,872 ns</td><td align="right" bgcolor="#FFFFFF">752,703 ns</td><td align="right" bgcolor="#A8D08D">482,639 ns (Δ = -270,065 ns)</td><td align="right" bgcolor="#FFFFFF">622,481 ns</td><td align="right" bgcolor="#FF4949">885,032 ns (Δ = +262,551 ns)</td><td align="right" bgcolor="#A8D08D">499,139 ns (Δ = -385,893 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,622 μs</td><td align="right" bgcolor="#FFFFFF">0,753 μs</td><td align="right" bgcolor="#FFFFFF">0,483 μs</td><td align="right" bgcolor="#FFFFFF">0,622 μs</td><td align="right" bgcolor="#FFFFFF">0,885 μs</td><td align="right" bgcolor="#FFFFFF">0,499 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#A8D08D">161,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#A8D08D">0,157 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


## <a name="ResourceHelper_Benchmark"></a>ResourceHelper_Benchmark

### <a name="ResourceHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 2278,183 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+748,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">468,674 ns</td><td align="right" bgcolor="#FFFFFF">543,855 ns</td><td align="right" bgcolor="#FFFFFF">344,674 ns</td><td align="right" bgcolor="#FFFFFF">312,879 ns</td><td align="right" bgcolor="#FFFFFF">304,186 ns</td><td align="right" bgcolor="#FF4949">2582,369 ns (Δ = +2278,183 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,469 μs</td><td align="right" bgcolor="#FFFFFF">0,544 μs</td><td align="right" bgcolor="#FFFFFF">0,345 μs</td><td align="right" bgcolor="#FFFFFF">0,313 μs</td><td align="right" bgcolor="#FFFFFF">0,304 μs</td><td align="right" bgcolor="#FFFFFF">2,582 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +2,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+595,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FF4949">1815,000 (Δ = +1554,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FF4949">1,772 (Δ = +1,518)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,001)</td></tr></table>


## <a name="ScopeManager_Benchmark"></a>ScopeManager_Benchmark

### <a name="ScopeManager_Benchmark_Get_Existing_ScopeManager"></a>Get_Existing_ScopeManager

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 462,374 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+470,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">101,899 ns</td><td align="right" bgcolor="#FFFFFF">128,085 ns</td><td align="right" bgcolor="#FFFFFF">96,554 ns</td><td align="right" bgcolor="#FFFFFF">97,591 ns</td><td align="right" bgcolor="#FFFFFF">97,899 ns</td><td align="right" bgcolor="#FF4949">558,928 ns (Δ = +461,029 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,559 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2030,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FF4949">554,000 (Δ = +528,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FF4949">0,541 (Δ = +0,516)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="ScopeManager_Benchmark_Get_New_ScopeManager"></a>Get_New_ScopeManager

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 459,011 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+465,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">108,379 ns</td><td align="right" bgcolor="#FFFFFF">125,478 ns</td><td align="right" bgcolor="#FFFFFF">96,350 ns</td><td align="right" bgcolor="#FFFFFF">99,209 ns</td><td align="right" bgcolor="#FFFFFF">98,218 ns</td><td align="right" bgcolor="#FF4949">555,361 ns (Δ = +457,143 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,555 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2003,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FF4949">547,000 (Δ = +521,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FF4949">0,534 (Δ = +0,509)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 65166,650 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,7 %</td><td align="right" bgcolor="#A8D08D">-13,5 %</td><td align="right" bgcolor="#FF4949">+1,4 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">389138,231 ns</td><td align="right" bgcolor="#FF4949">454304,881 ns (Δ = +65166,650 ns)</td><td align="right" bgcolor="#A8D08D">392752,664 ns (Δ = -61552,218 ns)</td><td align="right" bgcolor="#FF4949">398261,638 ns (Δ = +5508,975 ns)</td><td align="right" bgcolor="#FF4949">414189,498 ns (Δ = +15927,859 ns)</td><td align="right" bgcolor="#FFFFFF">412752,296 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">389,138 μs</td><td align="right" bgcolor="#FFFFFF">454,305 μs</td><td align="right" bgcolor="#FFFFFF">392,753 μs</td><td align="right" bgcolor="#FFFFFF">398,262 μs</td><td align="right" bgcolor="#FFFFFF">414,189 μs</td><td align="right" bgcolor="#FFFFFF">412,752 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,389 ms</td><td align="right" bgcolor="#FFFFFF">0,454 ms</td><td align="right" bgcolor="#FFFFFF">0,393 ms</td><td align="right" bgcolor="#FFFFFF">0,398 ms</td><td align="right" bgcolor="#FFFFFF">0,414 ms</td><td align="right" bgcolor="#FFFFFF">0,413 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">79,000</td><td align="right" bgcolor="#FFFFFF">79,000</td><td align="right" bgcolor="#FFFFFF">79,000</td><td align="right" bgcolor="#A8D08D">78,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">78,000</td><td align="right" bgcolor="#FF4949">150,000 (Δ = +72,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-1,1 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+22,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">104010,000</td><td align="right" bgcolor="#A8D08D">103999,000 (Δ = -11,000)</td><td align="right" bgcolor="#FF4949">104005,000 (Δ = +6,000)</td><td align="right" bgcolor="#A8D08D">102819,000 (Δ = -1186,000)</td><td align="right" bgcolor="#A8D08D">102800,000 (Δ = -19,000)</td><td align="right" bgcolor="#FF4949">126003,000 (Δ = +23203,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">101,572</td><td align="right" bgcolor="#A8D08D">101,562 (Δ = -0,011)</td><td align="right" bgcolor="#FF4949">101,567 (Δ = +0,006)</td><td align="right" bgcolor="#A8D08D">100,409 (Δ = -1,158)</td><td align="right" bgcolor="#A8D08D">100,391 (Δ = -0,019)</td><td align="right" bgcolor="#FF4949">123,050 (Δ = +22,659)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,099</td><td align="right" bgcolor="#A8D08D">0,099 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,099 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,098 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,098 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,120 (Δ = +0,022)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 54218,485 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,8 %</td><td align="right" bgcolor="#A8D08D">-18,7 %</td><td align="right" bgcolor="#FF4949">+14,4 %</td><td align="right" bgcolor="#A8D08D">-12,1 %</td><td align="right" bgcolor="#FF4949">+2,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">235827,951 ns</td><td align="right" bgcolor="#FF4949">289627,686 ns (Δ = +53799,735 ns)</td><td align="right" bgcolor="#A8D08D">235409,201 ns (Δ = -54218,485 ns)</td><td align="right" bgcolor="#FF4949">269340,018 ns (Δ = +33930,817 ns)</td><td align="right" bgcolor="#A8D08D">236629,580 ns (Δ = -32710,438 ns)</td><td align="right" bgcolor="#FF4949">241398,389 ns (Δ = +4768,810 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">235,828 μs</td><td align="right" bgcolor="#FFFFFF">289,628 μs</td><td align="right" bgcolor="#FFFFFF">235,409 μs</td><td align="right" bgcolor="#FFFFFF">269,340 μs</td><td align="right" bgcolor="#FFFFFF">236,630 μs</td><td align="right" bgcolor="#FFFFFF">241,398 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,236 ms</td><td align="right" bgcolor="#FFFFFF">0,290 ms</td><td align="right" bgcolor="#FFFFFF">0,235 ms</td><td align="right" bgcolor="#FFFFFF">0,269 ms</td><td align="right" bgcolor="#FFFFFF">0,237 ms</td><td align="right" bgcolor="#FFFFFF">0,241 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.6</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">28,000</td><td align="right" bgcolor="#FF4949">52,000 (Δ = +24,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-2,9 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+18,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">38224,000</td><td align="right" bgcolor="#A8D08D">38209,000 (Δ = -15,000)</td><td align="right" bgcolor="#A8D08D">38208,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">37102,000 (Δ = -1106,000)</td><td align="right" bgcolor="#FF4949">37107,000 (Δ = +5,000)</td><td align="right" bgcolor="#FF4949">43936,000 (Δ = +6829,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">37,328</td><td align="right" bgcolor="#A8D08D">37,313 (Δ = -0,015)</td><td align="right" bgcolor="#A8D08D">37,313 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">36,232 (Δ = -1,080)</td><td align="right" bgcolor="#FF4949">36,237 (Δ = +0,005)</td><td align="right" bgcolor="#FF4949">42,906 (Δ = +6,669)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,035 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,035 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,042 (Δ = +0,007)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 153249,469 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+45,2 %</td><td align="right" bgcolor="#A8D08D">-31,2 %</td><td align="right" bgcolor="#A8D08D">-1,6 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#FF4949">+4,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">326844,749 ns</td><td align="right" bgcolor="#FF4949">474562,803 ns (Δ = +147718,054 ns)</td><td align="right" bgcolor="#A8D08D">326397,857 ns (Δ = -148164,945 ns)</td><td align="right" bgcolor="#A8D08D">321313,334 ns (Δ = -5084,523 ns)</td><td align="right" bgcolor="#FF4949">334137,085 ns (Δ = +12823,751 ns)</td><td align="right" bgcolor="#FF4949">348350,496 ns (Δ = +14213,411 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">326,845 μs</td><td align="right" bgcolor="#FFFFFF">474,563 μs</td><td align="right" bgcolor="#FFFFFF">326,398 μs</td><td align="right" bgcolor="#FFFFFF">321,313 μs</td><td align="right" bgcolor="#FFFFFF">334,137 μs</td><td align="right" bgcolor="#FFFFFF">348,350 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,327 ms</td><td align="right" bgcolor="#FFFFFF">0,475 ms</td><td align="right" bgcolor="#FFFFFF">0,326 ms</td><td align="right" bgcolor="#FFFFFF">0,321 ms</td><td align="right" bgcolor="#FFFFFF">0,334 ms</td><td align="right" bgcolor="#FFFFFF">0,348 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.6</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">63,000</td><td align="right" bgcolor="#FFFFFF">63,000</td><td align="right" bgcolor="#FFFFFF">63,000</td><td align="right" bgcolor="#A8D08D">62,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">62,000</td><td align="right" bgcolor="#FF4949">124,000 (Δ = +62,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+28,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">82958,000</td><td align="right" bgcolor="#A8D08D">82933,000 (Δ = -25,000)</td><td align="right" bgcolor="#FF4949">82936,000 (Δ = +3,000)</td><td align="right" bgcolor="#A8D08D">81692,000 (Δ = -1244,000)</td><td align="right" bgcolor="#FF4949">81696,000 (Δ = +4,000)</td><td align="right" bgcolor="#FF4949">104791,000 (Δ = +23095,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">81,014</td><td align="right" bgcolor="#A8D08D">80,989 (Δ = -0,024)</td><td align="right" bgcolor="#FF4949">80,992 (Δ = +0,003)</td><td align="right" bgcolor="#A8D08D">79,777 (Δ = -1,215)</td><td align="right" bgcolor="#FF4949">79,781 (Δ = +0,004)</td><td align="right" bgcolor="#FF4949">102,335 (Δ = +22,554)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,079</td><td align="right" bgcolor="#A8D08D">0,079 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,079 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,078 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,078 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,100 (Δ = +0,022)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 465598,685 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+38,4 %</td><td align="right" bgcolor="#A8D08D">-34,8 %</td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#FF4949">+13,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">915346,960 ns</td><td align="right" bgcolor="#FF4949">1266675,963 ns (Δ = +351329,003 ns)</td><td align="right" bgcolor="#A8D08D">825812,798 ns (Δ = -440863,164 ns)</td><td align="right" bgcolor="#A8D08D">801077,278 ns (Δ = -24735,521 ns)</td><td align="right" bgcolor="#FF4949">834903,251 ns (Δ = +33825,974 ns)</td><td align="right" bgcolor="#FF4949">949976,747 ns (Δ = +115073,495 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">915,347 μs</td><td align="right" bgcolor="#FF4949">1266,676 μs (Δ = +351,329 μs)</td><td align="right" bgcolor="#A8D08D">825,813 μs (Δ = -440,863 μs)</td><td align="right" bgcolor="#FFFFFF">801,077 μs</td><td align="right" bgcolor="#FFFFFF">834,903 μs</td><td align="right" bgcolor="#FFFFFF">949,977 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,915 ms</td><td align="right" bgcolor="#FFFFFF">1,267 ms</td><td align="right" bgcolor="#FFFFFF">0,826 ms</td><td align="right" bgcolor="#FFFFFF">0,801 ms</td><td align="right" bgcolor="#FFFFFF">0,835 ms</td><td align="right" bgcolor="#FFFFFF">0,950 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.6</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">238,000</td><td align="right" bgcolor="#FFFFFF">238,000</td><td align="right" bgcolor="#FFFFFF">238,000</td><td align="right" bgcolor="#A8D08D">236,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">236,000</td><td align="right" bgcolor="#FF4949">495,000 (Δ = +259,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-0,7 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+33,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">312805,000</td><td align="right" bgcolor="#A8D08D">312778,000 (Δ = -27,000)</td><td align="right" bgcolor="#A8D08D">312773,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">310547,000 (Δ = -2226,000)</td><td align="right" bgcolor="#FF4949">310697,000 (Δ = +150,000)</td><td align="right" bgcolor="#FF4949">415620,000 (Δ = +104923,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">305,474</td><td align="right" bgcolor="#A8D08D">305,447 (Δ = -0,026)</td><td align="right" bgcolor="#A8D08D">305,442 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">303,269 (Δ = -2,174)</td><td align="right" bgcolor="#FF4949">303,415 (Δ = +0,146)</td><td align="right" bgcolor="#FF4949">405,879 (Δ = +102,464)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,298</td><td align="right" bgcolor="#A8D08D">0,298 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,298 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,002)</td><td align="right" bgcolor="#FF4949">0,296 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,396 (Δ = +0,100)</td></tr></table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 2074332,775 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,5 %</td><td align="right" bgcolor="#A8D08D">-1,7 %</td><td align="right" bgcolor="#FF4949">+1,6 %</td><td align="right" bgcolor="#A8D08D">-1,0 %</td><td align="right" bgcolor="#A8D08D">-1,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14122300,815 ns</td><td align="right" bgcolor="#A8D08D">12358990,065 ns (Δ = -1763310,750 ns)</td><td align="right" bgcolor="#A8D08D">12152675,577 ns (Δ = -206314,489 ns)</td><td align="right" bgcolor="#FF4949">12349254,535 ns (Δ = +196578,958 ns)</td><td align="right" bgcolor="#A8D08D">12219717,488 ns (Δ = -129537,046 ns)</td><td align="right" bgcolor="#A8D08D">12047968,040 ns (Δ = -171749,448 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14122,301 μs</td><td align="right" bgcolor="#A8D08D">12358,990 μs (Δ = -1763,311 μs)</td><td align="right" bgcolor="#FFFFFF">12152,676 μs</td><td align="right" bgcolor="#FFFFFF">12349,255 μs</td><td align="right" bgcolor="#FFFFFF">12219,717 μs</td><td align="right" bgcolor="#FFFFFF">12047,968 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">14,122 ms</td><td align="right" bgcolor="#FFFFFF">12,359 ms</td><td align="right" bgcolor="#FFFFFF">12,153 ms</td><td align="right" bgcolor="#FFFFFF">12,349 ms</td><td align="right" bgcolor="#FFFFFF">12,220 ms</td><td align="right" bgcolor="#FFFFFF">12,048 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1169,000</td><td align="right" bgcolor="#A8D08D">1165,000 (Δ = -4,000)</td><td align="right" bgcolor="#FF4949">1171,000 (Δ = +6,000)</td><td align="right" bgcolor="#A8D08D">1169,000 (Δ = -2,000)</td><td align="right" bgcolor="#A8D08D">1166,000 (Δ = -3,000)</td><td align="right" bgcolor="#FF4949">2024,000 (Δ = +858,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#A8D08D">-0,2 %</td><td align="right" bgcolor="#A8D08D">-0,2 %</td><td align="right" bgcolor="#FF4949">+11,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1533357,000</td><td align="right" bgcolor="#A8D08D">1528410,000 (Δ = -4947,000)</td><td align="right" bgcolor="#FF4949">1535185,000 (Δ = +6775,000)</td><td align="right" bgcolor="#A8D08D">1532783,000 (Δ = -2402,000)</td><td align="right" bgcolor="#A8D08D">1529372,000 (Δ = -3411,000)</td><td align="right" bgcolor="#FF4949">1698807,000 (Δ = +169435,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1497,419</td><td align="right" bgcolor="#A8D08D">1492,588 (Δ = -4,831)</td><td align="right" bgcolor="#FF4949">1499,204 (Δ = +6,616)</td><td align="right" bgcolor="#A8D08D">1496,858 (Δ = -2,346)</td><td align="right" bgcolor="#A8D08D">1493,527 (Δ = -3,331)</td><td align="right" bgcolor="#FF4949">1658,991 (Δ = +165,464)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,462</td><td align="right" bgcolor="#A8D08D">1,458 (Δ = -0,005)</td><td align="right" bgcolor="#FF4949">1,464 (Δ = +0,006)</td><td align="right" bgcolor="#A8D08D">1,462 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">1,459 (Δ = -0,003)</td><td align="right" bgcolor="#FF4949">1,620 (Δ = +0,162)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 106897,777 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+12,5 %</td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#A8D08D">-7,7 %</td><td align="right" bgcolor="#FF4949">+9,7 %</td><td align="right" bgcolor="#A8D08D">-5,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">701319,196 ns</td><td align="right" bgcolor="#FF4949">789094,269 ns (Δ = +87775,074 ns)</td><td align="right" bgcolor="#A8D08D">739446,241 ns (Δ = -49648,029 ns)</td><td align="right" bgcolor="#A8D08D">682196,492 ns (Δ = -57249,748 ns)</td><td align="right" bgcolor="#FF4949">748657,975 ns (Δ = +66461,483 ns)</td><td align="right" bgcolor="#A8D08D">706446,549 ns (Δ = -42211,426 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">701,319 μs</td><td align="right" bgcolor="#FFFFFF">789,094 μs</td><td align="right" bgcolor="#FFFFFF">739,446 μs</td><td align="right" bgcolor="#FFFFFF">682,196 μs</td><td align="right" bgcolor="#FFFFFF">748,658 μs</td><td align="right" bgcolor="#FFFFFF">706,447 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,701 ms</td><td align="right" bgcolor="#FFFFFF">0,789 ms</td><td align="right" bgcolor="#FFFFFF">0,739 ms</td><td align="right" bgcolor="#FFFFFF">0,682 ms</td><td align="right" bgcolor="#FFFFFF">0,749 ms</td><td align="right" bgcolor="#FFFFFF">0,706 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.5</td><td align="right">5.6</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FF4949">113,000 (Δ = +48,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,2 %</td><td align="right" bgcolor="#A8D08D">-1,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">86085,000</td><td align="right" bgcolor="#A8D08D">86067,000 (Δ = -18,000)</td><td align="right" bgcolor="#FF4949">86253,000 (Δ = +186,000)</td><td align="right" bgcolor="#A8D08D">85264,000 (Δ = -989,000)</td><td align="right" bgcolor="#FFFFFF">85264,000</td><td align="right" bgcolor="#FF4949">95316,000 (Δ = +10052,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">84,067</td><td align="right" bgcolor="#A8D08D">84,050 (Δ = -0,018)</td><td align="right" bgcolor="#FF4949">84,231 (Δ = +0,182)</td><td align="right" bgcolor="#A8D08D">83,266 (Δ = -0,966)</td><td align="right" bgcolor="#FFFFFF">83,266</td><td align="right" bgcolor="#FF4949">93,082 (Δ = +9,816)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,082</td><td align="right" bgcolor="#A8D08D">0,082 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,082 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,081 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,081</td><td align="right" bgcolor="#FF4949">0,091 (Δ = +0,010)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 498913,017 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,2 %</td><td align="right" bgcolor="#A8D08D">-15,2 %</td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#A8D08D">-1,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2484616,084 ns</td><td align="right" bgcolor="#FF4949">2637796,833 ns (Δ = +153180,750 ns)</td><td align="right" bgcolor="#A8D08D">2237045,767 ns (Δ = -400751,066 ns)</td><td align="right" bgcolor="#A8D08D">2138883,817 ns (Δ = -98161,951 ns)</td><td align="right" bgcolor="#FF4949">2225290,336 ns (Δ = +86406,520 ns)</td><td align="right" bgcolor="#A8D08D">2187553,040 ns (Δ = -37737,296 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2484,616 μs</td><td align="right" bgcolor="#FFFFFF">2637,797 μs</td><td align="right" bgcolor="#A8D08D">2237,046 μs (Δ = -400,751 μs)</td><td align="right" bgcolor="#FFFFFF">2138,884 μs</td><td align="right" bgcolor="#FFFFFF">2225,290 μs</td><td align="right" bgcolor="#FFFFFF">2187,553 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,485 ms</td><td align="right" bgcolor="#FFFFFF">2,638 ms</td><td align="right" bgcolor="#FFFFFF">2,237 ms</td><td align="right" bgcolor="#FFFFFF">2,139 ms</td><td align="right" bgcolor="#FFFFFF">2,225 ms</td><td align="right" bgcolor="#FFFFFF">2,188 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">211,000</td><td align="right" bgcolor="#FFFFFF">211,000</td><td align="right" bgcolor="#FFFFFF">211,000</td><td align="right" bgcolor="#A8D08D">210,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">210,000</td><td align="right" bgcolor="#FF4949">367,000 (Δ = +157,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#A8D08D">-0,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">276650,000</td><td align="right" bgcolor="#A8D08D">276647,000 (Δ = -3,000)</td><td align="right" bgcolor="#FF4949">277689,000 (Δ = +1042,000)</td><td align="right" bgcolor="#A8D08D">276399,000 (Δ = -1290,000)</td><td align="right" bgcolor="#FFFFFF">276399,000</td><td align="right" bgcolor="#FF4949">308459,000 (Δ = +32060,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">270,166</td><td align="right" bgcolor="#A8D08D">270,163 (Δ = -0,003)</td><td align="right" bgcolor="#FF4949">271,181 (Δ = +1,018)</td><td align="right" bgcolor="#A8D08D">269,921 (Δ = -1,260)</td><td align="right" bgcolor="#FFFFFF">269,921</td><td align="right" bgcolor="#FF4949">301,229 (Δ = +31,309)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,264</td><td align="right" bgcolor="#A8D08D">0,264 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,265 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,264 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,264</td><td align="right" bgcolor="#FF4949">0,294 (Δ = +0,031)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 1660115,915 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,2 %</td><td align="right" bgcolor="#A8D08D">-13,5 %</td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#FF4949">+3,3 %</td><td align="right" bgcolor="#A8D08D">-3,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10614273,574 ns</td><td align="right" bgcolor="#FF4949">11272857,837 ns (Δ = +658584,263 ns)</td><td align="right" bgcolor="#A8D08D">9755046,130 ns (Δ = -1517811,707 ns)</td><td align="right" bgcolor="#A8D08D">9612741,923 ns (Δ = -142304,208 ns)</td><td align="right" bgcolor="#FF4949">9931157,870 ns (Δ = +318415,947 ns)</td><td align="right" bgcolor="#A8D08D">9629392,600 ns (Δ = -301765,270 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10614,274 μs</td><td align="right" bgcolor="#FF4949">11272,858 μs (Δ = +658,584 μs)</td><td align="right" bgcolor="#A8D08D">9755,046 μs (Δ = -1517,812 μs)</td><td align="right" bgcolor="#FFFFFF">9612,742 μs</td><td align="right" bgcolor="#FF4949">9931,158 μs (Δ = +318,416 μs)</td><td align="right" bgcolor="#A8D08D">9629,393 μs (Δ = -301,765 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">10,614 ms</td><td align="right" bgcolor="#FFFFFF">11,273 ms</td><td align="right" bgcolor="#FFFFFF">9,755 ms</td><td align="right" bgcolor="#FFFFFF">9,613 ms</td><td align="right" bgcolor="#FFFFFF">9,931 ms</td><td align="right" bgcolor="#FFFFFF">9,629 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.4</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">937,000</td><td align="right" bgcolor="#FF4949">940,000 (Δ = +3,000)</td><td align="right" bgcolor="#FF4949">943,000 (Δ = +3,000)</td><td align="right" bgcolor="#A8D08D">940,000 (Δ = -3,000)</td><td align="right" bgcolor="#FF4949">941,000 (Δ = +1,000)</td><td align="right" bgcolor="#FF4949">1659,000 (Δ = +718,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+12,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1229427,000</td><td align="right" bgcolor="#FF4949">1232564,000 (Δ = +3137,000)</td><td align="right" bgcolor="#FF4949">1236931,000 (Δ = +4367,000)</td><td align="right" bgcolor="#A8D08D">1233274,000 (Δ = -3657,000)</td><td align="right" bgcolor="#FF4949">1233813,000 (Δ = +539,000)</td><td align="right" bgcolor="#FF4949">1392087,000 (Δ = +158274,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1200,612</td><td align="right" bgcolor="#FF4949">1203,676 (Δ = +3,063)</td><td align="right" bgcolor="#FF4949">1207,940 (Δ = +4,265)</td><td align="right" bgcolor="#A8D08D">1204,369 (Δ = -3,571)</td><td align="right" bgcolor="#FF4949">1204,896 (Δ = +0,526)</td><td align="right" bgcolor="#FF4949">1359,460 (Δ = +154,564)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,172</td><td align="right" bgcolor="#FF4949">1,175 (Δ = +0,003)</td><td align="right" bgcolor="#FF4949">1,180 (Δ = +0,004)</td><td align="right" bgcolor="#A8D08D">1,176 (Δ = -0,003)</td><td align="right" bgcolor="#FF4949">1,177 (Δ = +0,001)</td><td align="right" bgcolor="#FF4949">1,328 (Δ = +0,151)</td></tr></table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 437720,641 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,3 %</td><td align="right" bgcolor="#FF4949">+4,5 %</td><td align="right" bgcolor="#FF4949">+2,1 %</td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-37,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">960300,910 ns</td><td align="right" bgcolor="#A8D08D">823006,459 ns (Δ = -137294,451 ns)</td><td align="right" bgcolor="#FF4949">860212,524 ns (Δ = +37206,065 ns)</td><td align="right" bgcolor="#FF4949">878149,662 ns (Δ = +17937,138 ns)</td><td align="right" bgcolor="#A8D08D">840836,223 ns (Δ = -37313,439 ns)</td><td align="right" bgcolor="#A8D08D">522580,269 ns (Δ = -318255,953 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">960,301 μs</td><td align="right" bgcolor="#FFFFFF">823,006 μs</td><td align="right" bgcolor="#FFFFFF">860,213 μs</td><td align="right" bgcolor="#FFFFFF">878,150 μs</td><td align="right" bgcolor="#FFFFFF">840,836 μs</td><td align="right" bgcolor="#A8D08D">522,580 μs (Δ = -318,256 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,960 ms</td><td align="right" bgcolor="#FFFFFF">0,823 ms</td><td align="right" bgcolor="#FFFFFF">0,860 ms</td><td align="right" bgcolor="#FFFFFF">0,878 ms</td><td align="right" bgcolor="#FFFFFF">0,841 ms</td><td align="right" bgcolor="#FFFFFF">0,523 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.6</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.9</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">443,000</td><td align="right" bgcolor="#FFFFFF">443,000</td><td align="right" bgcolor="#FFFFFF">443,000</td><td align="right" bgcolor="#FF4949">451,000 (Δ = +8,000)</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">155,000 (Δ = -296,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+1,8 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-77,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">582274,000</td><td align="right" bgcolor="#FF4949">582299,000 (Δ = +25,000)</td><td align="right" bgcolor="#A8D08D">582254,000 (Δ = -45,000)</td><td align="right" bgcolor="#FF4949">592481,000 (Δ = +10227,000)</td><td align="right" bgcolor="#FF4949">592493,000 (Δ = +12,000)</td><td align="right" bgcolor="#A8D08D">130764,000 (Δ = -461729,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">568,627</td><td align="right" bgcolor="#FF4949">568,651 (Δ = +0,024)</td><td align="right" bgcolor="#A8D08D">568,607 (Δ = -0,044)</td><td align="right" bgcolor="#FF4949">578,595 (Δ = +9,987)</td><td align="right" bgcolor="#FF4949">578,606 (Δ = +0,012)</td><td align="right" bgcolor="#A8D08D">127,699 (Δ = -450,907)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,555</td><td align="right" bgcolor="#FF4949">0,555 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,555 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,565 (Δ = +0,010)</td><td align="right" bgcolor="#FF4949">0,565 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,125 (Δ = -0,440)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 91210,076 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,0 %</td><td align="right" bgcolor="#FF4949">+2,2 %</td><td align="right" bgcolor="#A8D08D">-2,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">327985,185 ns</td><td align="right" bgcolor="#A8D08D">295163,351 ns (Δ = -32821,834 ns)</td><td align="right" bgcolor="#FF4949">301556,524 ns (Δ = +6393,173 ns)</td><td align="right" bgcolor="#A8D08D">293803,913 ns (Δ = -7752,611 ns)</td><td align="right" bgcolor="#FFFFFF">296768,096 ns</td><td align="right" bgcolor="#A8D08D">236775,109 ns (Δ = -59992,987 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">327,985 μs</td><td align="right" bgcolor="#FFFFFF">295,163 μs</td><td align="right" bgcolor="#FFFFFF">301,557 μs</td><td align="right" bgcolor="#FFFFFF">293,804 μs</td><td align="right" bgcolor="#FFFFFF">296,768 μs</td><td align="right" bgcolor="#FFFFFF">236,775 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,328 ms</td><td align="right" bgcolor="#FFFFFF">0,295 ms</td><td align="right" bgcolor="#FFFFFF">0,302 ms</td><td align="right" bgcolor="#FFFFFF">0,294 ms</td><td align="right" bgcolor="#FFFFFF">0,297 ms</td><td align="right" bgcolor="#FFFFFF">0,237 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.6</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">104,000</td><td align="right" bgcolor="#FFFFFF">104,000</td><td align="right" bgcolor="#FFFFFF">104,000</td><td align="right" bgcolor="#FFFFFF">104,000</td><td align="right" bgcolor="#FFFFFF">104,000</td><td align="right" bgcolor="#A8D08D">48,000 (Δ = -56,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,2 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-70,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">137668,000</td><td align="right" bgcolor="#FFFFFF">137668,000</td><td align="right" bgcolor="#A8D08D">137647,000 (Δ = -21,000)</td><td align="right" bgcolor="#FF4949">137920,000 (Δ = +273,000)</td><td align="right" bgcolor="#A8D08D">137913,000 (Δ = -7,000)</td><td align="right" bgcolor="#A8D08D">40775,000 (Δ = -97138,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">134,441</td><td align="right" bgcolor="#FFFFFF">134,441</td><td align="right" bgcolor="#A8D08D">134,421 (Δ = -0,021)</td><td align="right" bgcolor="#FF4949">134,688 (Δ = +0,267)</td><td align="right" bgcolor="#A8D08D">134,681 (Δ = -0,007)</td><td align="right" bgcolor="#A8D08D">39,819 (Δ = -94,861)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,131</td><td align="right" bgcolor="#FFFFFF">0,131</td><td align="right" bgcolor="#A8D08D">0,131 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,132 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,039 (Δ = -0,093)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 231817,036 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#FF4949">+4,4 %</td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#A8D08D">-5,0 %</td><td align="right" bgcolor="#A8D08D">-28,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">607091,876 ns</td><td align="right" bgcolor="#A8D08D">512270,057 ns (Δ = -94821,819 ns)</td><td align="right" bgcolor="#FF4949">534639,512 ns (Δ = +22369,455 ns)</td><td align="right" bgcolor="#FF4949">554411,779 ns (Δ = +19772,266 ns)</td><td align="right" bgcolor="#A8D08D">526755,698 ns (Δ = -27656,081 ns)</td><td align="right" bgcolor="#A8D08D">375274,840 ns (Δ = -151480,858 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">607,092 μs</td><td align="right" bgcolor="#FFFFFF">512,270 μs</td><td align="right" bgcolor="#FFFFFF">534,640 μs</td><td align="right" bgcolor="#FFFFFF">554,412 μs</td><td align="right" bgcolor="#FFFFFF">526,756 μs</td><td align="right" bgcolor="#FFFFFF">375,275 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,607 ms</td><td align="right" bgcolor="#FFFFFF">0,512 ms</td><td align="right" bgcolor="#FFFFFF">0,535 ms</td><td align="right" bgcolor="#FFFFFF">0,554 ms</td><td align="right" bgcolor="#FFFFFF">0,527 ms</td><td align="right" bgcolor="#FFFFFF">0,375 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.6</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.5</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.9</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">329,000</td><td align="right" bgcolor="#FFFFFF">329,000</td><td align="right" bgcolor="#FFFFFF">329,000</td><td align="right" bgcolor="#FF4949">333,000 (Δ = +4,000)</td><td align="right" bgcolor="#FFFFFF">333,000</td><td align="right" bgcolor="#A8D08D">103,000 (Δ = -230,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+1,2 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-80,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">432940,000</td><td align="right" bgcolor="#FF4949">433040,000 (Δ = +100,000)</td><td align="right" bgcolor="#A8D08D">432973,000 (Δ = -67,000)</td><td align="right" bgcolor="#FF4949">437981,000 (Δ = +5008,000)</td><td align="right" bgcolor="#FF4949">437989,000 (Δ = +8,000)</td><td align="right" bgcolor="#A8D08D">86530,000 (Δ = -351459,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">422,793</td><td align="right" bgcolor="#FF4949">422,891 (Δ = +0,098)</td><td align="right" bgcolor="#A8D08D">422,825 (Δ = -0,065)</td><td align="right" bgcolor="#FF4949">427,716 (Δ = +4,891)</td><td align="right" bgcolor="#FF4949">427,724 (Δ = +0,008)</td><td align="right" bgcolor="#A8D08D">84,502 (Δ = -343,222)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,413</td><td align="right" bgcolor="#FF4949">0,413 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,413 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,418 (Δ = +0,005)</td><td align="right" bgcolor="#FF4949">0,418 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,083 (Δ = -0,335)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 998309,496 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,2 %</td><td align="right" bgcolor="#FF4949">+2,9 %</td><td align="right" bgcolor="#FF4949">+8,0 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#A8D08D">-46,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1944746,138 ns</td><td align="right" bgcolor="#A8D08D">1648659,420 ns (Δ = -296086,718 ns)</td><td align="right" bgcolor="#FF4949">1696922,939 ns (Δ = +48263,519 ns)</td><td align="right" bgcolor="#FF4949">1832214,541 ns (Δ = +135291,602 ns)</td><td align="right" bgcolor="#A8D08D">1770070,417 ns (Δ = -62144,124 ns)</td><td align="right" bgcolor="#A8D08D">946436,643 ns (Δ = -823633,774 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1944,746 μs</td><td align="right" bgcolor="#A8D08D">1648,659 μs (Δ = -296,087 μs)</td><td align="right" bgcolor="#FFFFFF">1696,923 μs</td><td align="right" bgcolor="#FFFFFF">1832,215 μs</td><td align="right" bgcolor="#FFFFFF">1770,070 μs</td><td align="right" bgcolor="#A8D08D">946,437 μs (Δ = -823,634 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,945 ms</td><td align="right" bgcolor="#FFFFFF">1,649 ms</td><td align="right" bgcolor="#FFFFFF">1,697 ms</td><td align="right" bgcolor="#FFFFFF">1,832 ms</td><td align="right" bgcolor="#FFFFFF">1,770 ms</td><td align="right" bgcolor="#FFFFFF">0,946 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.6</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.6</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1453,000</td><td align="right" bgcolor="#FFFFFF">1453,000</td><td align="right" bgcolor="#FFFFFF">1453,000</td><td align="right" bgcolor="#FF4949">1473,000 (Δ = +20,000)</td><td align="right" bgcolor="#FFFFFF">1473,000</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -1104,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+1,3 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-84,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1909467,000</td><td align="right" bgcolor="#FF4949">1909562,000 (Δ = +95,000)</td><td align="right" bgcolor="#FF4949">1910023,000 (Δ = +461,000)</td><td align="right" bgcolor="#FF4949">1935788,000 (Δ = +25765,000)</td><td align="right" bgcolor="#A8D08D">1935273,000 (Δ = -515,000)</td><td align="right" bgcolor="#A8D08D">310241,000 (Δ = -1625032,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1864,714</td><td align="right" bgcolor="#FF4949">1864,807 (Δ = +0,093)</td><td align="right" bgcolor="#FF4949">1865,257 (Δ = +0,450)</td><td align="right" bgcolor="#FF4949">1890,418 (Δ = +25,161)</td><td align="right" bgcolor="#A8D08D">1889,915 (Δ = -0,503)</td><td align="right" bgcolor="#A8D08D">302,970 (Δ = -1586,945)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,821</td><td align="right" bgcolor="#FF4949">1,821 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">1,822 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">1,846 (Δ = +0,025)</td><td align="right" bgcolor="#A8D08D">1,846 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -1,550)</td></tr></table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 295,639 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1076,814 ns</td><td align="right" bgcolor="#FFFFFF">933,262 ns</td><td align="right" bgcolor="#FFFFFF">869,738 ns</td><td align="right" bgcolor="#FFFFFF">882,243 ns</td><td align="right" bgcolor="#FFFFFF">781,175 ns</td><td align="right" bgcolor="#FFFFFF">796,920 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,077 μs</td><td align="right" bgcolor="#FFFFFF">0,933 μs</td><td align="right" bgcolor="#FFFFFF">0,870 μs</td><td align="right" bgcolor="#FFFFFF">0,882 μs</td><td align="right" bgcolor="#FFFFFF">0,781 μs</td><td align="right" bgcolor="#FFFFFF">0,797 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.6</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td><td align="right" bgcolor="#A8D08D">-8,8 %</td><td align="right" bgcolor="#FF4949">+1,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">940,000</td><td align="right" bgcolor="#FFFFFF">940,000</td><td align="right" bgcolor="#FFFFFF">940,000</td><td align="right" bgcolor="#FF4949">943,000 (Δ = +3,000)</td><td align="right" bgcolor="#A8D08D">860,000 (Δ = -83,000)</td><td align="right" bgcolor="#FF4949">875,000 (Δ = +15,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,918</td><td align="right" bgcolor="#FFFFFF">0,918</td><td align="right" bgcolor="#FFFFFF">0,918</td><td align="right" bgcolor="#FF4949">0,921 (Δ = +0,003)</td><td align="right" bgcolor="#A8D08D">0,840 (Δ = -0,081)</td><td align="right" bgcolor="#FF4949">0,854 (Δ = +0,015)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 44,741 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">175,706 ns</td><td align="right" bgcolor="#FFFFFF">144,841 ns</td><td align="right" bgcolor="#FFFFFF">139,037 ns</td><td align="right" bgcolor="#FFFFFF">136,293 ns</td><td align="right" bgcolor="#FFFFFF">165,125 ns</td><td align="right" bgcolor="#FFFFFF">130,965 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,176 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,165 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#A8D08D">147,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#A8D08D">0,144 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Transient"></a>ResolveType_Transient

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 367,102 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2431,808 ns</td><td align="right" bgcolor="#A8D08D">2118,705 ns (Δ = -313,103 ns)</td><td align="right" bgcolor="#FFFFFF">2088,962 ns</td><td align="right" bgcolor="#FFFFFF">2118,391 ns</td><td align="right" bgcolor="#FFFFFF">2302,283 ns</td><td align="right" bgcolor="#FFFFFF">2456,064 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,432 μs</td><td align="right" bgcolor="#FFFFFF">2,119 μs</td><td align="right" bgcolor="#FFFFFF">2,089 μs</td><td align="right" bgcolor="#FFFFFF">2,118 μs</td><td align="right" bgcolor="#FFFFFF">2,302 μs</td><td align="right" bgcolor="#FFFFFF">2,456 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1449,000</td><td align="right" bgcolor="#A8D08D">1439,000 (Δ = -10,000)</td><td align="right" bgcolor="#FFFFFF">1439,000</td><td align="right" bgcolor="#FFFFFF">1439,000</td><td align="right" bgcolor="#FFFFFF">1439,000</td><td align="right" bgcolor="#FF4949">1727,000 (Δ = +288,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,415</td><td align="right" bgcolor="#A8D08D">1,405 (Δ = -0,010)</td><td align="right" bgcolor="#FFFFFF">1,405</td><td align="right" bgcolor="#FFFFFF">1,405</td><td align="right" bgcolor="#FFFFFF">1,405</td><td align="right" bgcolor="#FF4949">1,687 (Δ = +0,281)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 58,103 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">179,948 ns</td><td align="right" bgcolor="#FFFFFF">141,278 ns</td><td align="right" bgcolor="#FFFFFF">136,083 ns</td><td align="right" bgcolor="#FFFFFF">127,256 ns</td><td align="right" bgcolor="#FFFFFF">121,845 ns</td><td align="right" bgcolor="#FFFFFF">133,229 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,180 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#A8D08D">147,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#A8D08D">0,144 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency"></a>ResolveType_With_Transient_Dependency

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 725,367 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5262,514 ns</td><td align="right" bgcolor="#A8D08D">4853,598 ns (Δ = -408,915 ns)</td><td align="right" bgcolor="#FFFFFF">4649,068 ns</td><td align="right" bgcolor="#FFFFFF">4724,259 ns</td><td align="right" bgcolor="#FFFFFF">4537,147 ns</td><td align="right" bgcolor="#FF4949">4924,712 ns (Δ = +387,565 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,263 μs</td><td align="right" bgcolor="#FFFFFF">4,854 μs</td><td align="right" bgcolor="#FFFFFF">4,649 μs</td><td align="right" bgcolor="#FFFFFF">4,724 μs</td><td align="right" bgcolor="#FFFFFF">4,537 μs</td><td align="right" bgcolor="#FFFFFF">4,925 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +2,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3036,000</td><td align="right" bgcolor="#A8D08D">3021,000 (Δ = -15,000)</td><td align="right" bgcolor="#FFFFFF">3021,000</td><td align="right" bgcolor="#FFFFFF">3021,000</td><td align="right" bgcolor="#FFFFFF">3021,000</td><td align="right" bgcolor="#FF4949">3595,000 (Δ = +574,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,965</td><td align="right" bgcolor="#A8D08D">2,950 (Δ = -0,015)</td><td align="right" bgcolor="#FFFFFF">2,950</td><td align="right" bgcolor="#FFFFFF">2,950</td><td align="right" bgcolor="#FFFFFF">2,950</td><td align="right" bgcolor="#FF4949">3,511 (Δ = +0,561)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,001)</td></tr></table>


## <a name="TagHelper_Benchmark"></a>TagHelper_Benchmark

### <a name="TagHelper_Benchmark_AreTagsEqual"></a>AreTagsEqual

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 3,644 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,052 ns</td><td align="right" bgcolor="#FFFFFF">6,847 ns</td><td align="right" bgcolor="#FFFFFF">5,247 ns</td><td align="right" bgcolor="#FFFFFF">5,689 ns</td><td align="right" bgcolor="#FFFFFF">5,631 ns</td><td align="right" bgcolor="#FFFFFF">8,891 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TagHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 13997,654 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-94,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14412,618 ns</td><td align="right" bgcolor="#FFFFFF">14630,251 ns</td><td align="right" bgcolor="#A8D08D">12330,845 ns (Δ = -2299,406 ns)</td><td align="right" bgcolor="#FFFFFF">12218,632 ns</td><td align="right" bgcolor="#A8D08D">632,598 ns (Δ = -11586,034 ns)</td><td align="right" bgcolor="#FFFFFF">650,409 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14,413 μs</td><td align="right" bgcolor="#FFFFFF">14,630 μs</td><td align="right" bgcolor="#FFFFFF">12,331 μs</td><td align="right" bgcolor="#FFFFFF">12,219 μs</td><td align="right" bgcolor="#FFFFFF">0,633 μs</td><td align="right" bgcolor="#FFFFFF">0,650 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -8,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-97,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">11033,000</td><td align="right" bgcolor="#A8D08D">10999,000 (Δ = -34,000)</td><td align="right" bgcolor="#FFFFFF">10999,000</td><td align="right" bgcolor="#FFFFFF">10999,000</td><td align="right" bgcolor="#A8D08D">282,000 (Δ = -10717,000)</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">10,774</td><td align="right" bgcolor="#A8D08D">10,741 (Δ = -0,033)</td><td align="right" bgcolor="#FFFFFF">10,741</td><td align="right" bgcolor="#FFFFFF">10,741</td><td align="right" bgcolor="#A8D08D">0,275 (Δ = -10,466)</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,011</td><td align="right" bgcolor="#A8D08D">0,010 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,010)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 12,184 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,589 ns</td><td align="right" bgcolor="#FFFFFF">22,830 ns</td><td align="right" bgcolor="#FFFFFF">18,064 ns</td><td align="right" bgcolor="#FFFFFF">21,810 ns</td><td align="right" bgcolor="#FFFFFF">30,247 ns</td><td align="right" bgcolor="#FFFFFF">21,645 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyEx"></a>GetAssemblyEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 9,055 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,390 ns</td><td align="right" bgcolor="#FFFFFF">16,402 ns</td><td align="right" bgcolor="#FFFFFF">13,878 ns</td><td align="right" bgcolor="#FFFFFF">17,694 ns</td><td align="right" bgcolor="#FFFFFF">22,934 ns</td><td align="right" bgcolor="#FFFFFF">13,955 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx"></a>GetAssemblyFullNameEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 12,864 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,675 ns</td><td align="right" bgcolor="#FFFFFF">18,905 ns</td><td align="right" bgcolor="#FFFFFF">17,035 ns</td><td align="right" bgcolor="#FFFFFF">20,122 ns</td><td align="right" bgcolor="#FFFFFF">29,219 ns</td><td align="right" bgcolor="#FFFFFF">16,355 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetBaseTypeEx"></a>GetBaseTypeEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 8,146 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,726 ns</td><td align="right" bgcolor="#FFFFFF">18,734 ns</td><td align="right" bgcolor="#FFFFFF">17,605 ns</td><td align="right" bgcolor="#FFFFFF">25,751 ns</td><td align="right" bgcolor="#FFFFFF">18,190 ns</td><td align="right" bgcolor="#FFFFFF">18,976 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorEx"></a>GetConstructorEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 90,584 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">278,616 ns</td><td align="right" bgcolor="#FFFFFF">188,033 ns</td><td align="right" bgcolor="#FFFFFF">233,519 ns</td><td align="right" bgcolor="#FFFFFF">214,277 ns</td><td align="right" bgcolor="#FFFFFF">256,739 ns</td><td align="right" bgcolor="#FFFFFF">188,267 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,257 μs</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">133,000</td><td align="right" bgcolor="#FFFFFF">133,000</td><td align="right" bgcolor="#FFFFFF">133,000</td><td align="right" bgcolor="#FFFFFF">133,000</td><td align="right" bgcolor="#FFFFFF">133,000</td><td align="right" bgcolor="#A8D08D">131,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,130</td><td align="right" bgcolor="#FFFFFF">0,130</td><td align="right" bgcolor="#FFFFFF">0,130</td><td align="right" bgcolor="#FFFFFF">0,130</td><td align="right" bgcolor="#FFFFFF">0,130</td><td align="right" bgcolor="#A8D08D">0,128 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorsEx"></a>GetConstructorsEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 42,126 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">101,593 ns</td><td align="right" bgcolor="#FFFFFF">78,038 ns</td><td align="right" bgcolor="#FFFFFF">79,342 ns</td><td align="right" bgcolor="#FFFFFF">83,659 ns</td><td align="right" bgcolor="#FFFFFF">81,614 ns</td><td align="right" bgcolor="#FFFFFF">59,467 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">33,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,032 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 1630,630 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,3 %</td><td align="right" bgcolor="#FF4949">+52,0 %</td><td align="right" bgcolor="#A8D08D">-43,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2005,313 ns</td><td align="right" bgcolor="#A8D08D">1685,414 ns (Δ = -319,899 ns)</td><td align="right" bgcolor="#FFFFFF">1638,174 ns</td><td align="right" bgcolor="#FF4949">2150,849 ns (Δ = +512,675 ns)</td><td align="right" bgcolor="#FF4949">3268,805 ns (Δ = +1117,956 ns)</td><td align="right" bgcolor="#A8D08D">1838,837 ns (Δ = -1429,967 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,005 μs</td><td align="right" bgcolor="#FFFFFF">1,685 μs</td><td align="right" bgcolor="#FFFFFF">1,638 μs</td><td align="right" bgcolor="#FFFFFF">2,151 μs</td><td align="right" bgcolor="#FFFFFF">3,269 μs</td><td align="right" bgcolor="#FFFFFF">1,839 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 4188,920 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,7 %</td><td align="right" bgcolor="#FF4949">+13,3 %</td><td align="right" bgcolor="#FF4949">+32,3 %</td><td align="right" bgcolor="#FF4949">+16,1 %</td><td align="right" bgcolor="#A8D08D">-41,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6634,518 ns</td><td align="right" bgcolor="#A8D08D">5661,702 ns (Δ = -972,816 ns)</td><td align="right" bgcolor="#FF4949">6412,267 ns (Δ = +750,565 ns)</td><td align="right" bgcolor="#FF4949">8481,298 ns (Δ = +2069,031 ns)</td><td align="right" bgcolor="#FF4949">9850,621 ns (Δ = +1369,324 ns)</td><td align="right" bgcolor="#A8D08D">5813,128 ns (Δ = -4037,493 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,635 μs</td><td align="right" bgcolor="#FFFFFF">5,662 μs</td><td align="right" bgcolor="#FFFFFF">6,412 μs</td><td align="right" bgcolor="#FFFFFF">8,481 μs</td><td align="right" bgcolor="#FFFFFF">9,851 μs</td><td align="right" bgcolor="#FFFFFF">5,813 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#A8D08D">813,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#A8D08D">0,794 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 1167,389 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,2 %</td><td align="right" bgcolor="#FF4949">+26,0 %</td><td align="right" bgcolor="#A8D08D">-35,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2430,327 ns</td><td align="right" bgcolor="#A8D08D">1666,121 ns (Δ = -764,206 ns)</td><td align="right" bgcolor="#FFFFFF">1855,412 ns</td><td align="right" bgcolor="#FF4949">2249,020 ns (Δ = +393,608 ns)</td><td align="right" bgcolor="#FF4949">2833,510 ns (Δ = +584,490 ns)</td><td align="right" bgcolor="#A8D08D">1822,643 ns (Δ = -1010,867 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,430 μs</td><td align="right" bgcolor="#FFFFFF">1,666 μs</td><td align="right" bgcolor="#FFFFFF">1,855 μs</td><td align="right" bgcolor="#FFFFFF">2,249 μs</td><td align="right" bgcolor="#FFFFFF">2,834 μs</td><td align="right" bgcolor="#FFFFFF">1,823 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 4298,688 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,4 %</td><td align="right" bgcolor="#FF4949">+11,3 %</td><td align="right" bgcolor="#FF4949">+58,4 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#A8D08D">-38,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6661,569 ns</td><td align="right" bgcolor="#A8D08D">5636,764 ns (Δ = -1024,805 ns)</td><td align="right" bgcolor="#FF4949">6272,641 ns (Δ = +635,876 ns)</td><td align="right" bgcolor="#FF4949">9935,453 ns (Δ = +3662,812 ns)</td><td align="right" bgcolor="#A8D08D">9548,307 ns (Δ = -387,146 ns)</td><td align="right" bgcolor="#A8D08D">5903,517 ns (Δ = -3644,789 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,662 μs</td><td align="right" bgcolor="#FFFFFF">5,637 μs</td><td align="right" bgcolor="#FFFFFF">6,273 μs</td><td align="right" bgcolor="#FFFFFF">9,935 μs</td><td align="right" bgcolor="#FFFFFF">9,548 μs</td><td align="right" bgcolor="#FFFFFF">5,904 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#A8D08D">813,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#A8D08D">0,794 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 2,300 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,920 ns</td><td align="right" bgcolor="#FFFFFF">4,976 ns</td><td align="right" bgcolor="#FFFFFF">4,674 ns</td><td align="right" bgcolor="#FFFFFF">5,822 ns</td><td align="right" bgcolor="#FFFFFF">6,974 ns</td><td align="right" bgcolor="#FFFFFF">4,680 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 97,681 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">526,958 ns</td><td align="right" bgcolor="#FFFFFF">497,482 ns</td><td align="right" bgcolor="#FFFFFF">454,928 ns</td><td align="right" bgcolor="#FFFFFF">465,664 ns</td><td align="right" bgcolor="#FFFFFF">429,277 ns</td><td align="right" bgcolor="#FFFFFF">515,371 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,527 μs</td><td align="right" bgcolor="#FFFFFF">0,497 μs</td><td align="right" bgcolor="#FFFFFF">0,455 μs</td><td align="right" bgcolor="#FFFFFF">0,466 μs</td><td align="right" bgcolor="#FFFFFF">0,429 μs</td><td align="right" bgcolor="#FFFFFF">0,515 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#A8D08D">243,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#A8D08D">0,237 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Instance"></a>GetEventEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 16,518 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">90,642 ns</td><td align="right" bgcolor="#FFFFFF">86,635 ns</td><td align="right" bgcolor="#FFFFFF">80,003 ns</td><td align="right" bgcolor="#FFFFFF">83,575 ns</td><td align="right" bgcolor="#FFFFFF">74,123 ns</td><td align="right" bgcolor="#FFFFFF">74,923 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 453,941 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2134,012 ns</td><td align="right" bgcolor="#FFFFFF">1890,491 ns</td><td align="right" bgcolor="#FFFFFF">1816,334 ns</td><td align="right" bgcolor="#FFFFFF">1856,309 ns</td><td align="right" bgcolor="#FFFFFF">1680,070 ns</td><td align="right" bgcolor="#FF4949">1975,152 ns (Δ = +295,082 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,134 μs</td><td align="right" bgcolor="#FFFFFF">1,890 μs</td><td align="right" bgcolor="#FFFFFF">1,816 μs</td><td align="right" bgcolor="#FFFFFF">1,856 μs</td><td align="right" bgcolor="#FFFFFF">1,680 μs</td><td align="right" bgcolor="#FFFFFF">1,975 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.6</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#FF4949">+261,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FF4949">210,000 (Δ = +10,000)</td><td align="right" bgcolor="#FF4949">760,000 (Δ = +550,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FF4949">0,205 (Δ = +0,010)</td><td align="right" bgcolor="#FF4949">0,742 (Δ = +0,537)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 145,468 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">783,971 ns</td><td align="right" bgcolor="#FFFFFF">668,856 ns</td><td align="right" bgcolor="#FFFFFF">659,204 ns</td><td align="right" bgcolor="#FFFFFF">680,561 ns</td><td align="right" bgcolor="#FFFFFF">638,503 ns</td><td align="right" bgcolor="#FFFFFF">697,629 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,784 μs</td><td align="right" bgcolor="#FFFFFF">0,669 μs</td><td align="right" bgcolor="#FFFFFF">0,659 μs</td><td align="right" bgcolor="#FFFFFF">0,681 μs</td><td align="right" bgcolor="#FFFFFF">0,639 μs</td><td align="right" bgcolor="#FFFFFF">0,698 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">404,000</td><td align="right" bgcolor="#FFFFFF">404,000</td><td align="right" bgcolor="#FFFFFF">404,000</td><td align="right" bgcolor="#FFFFFF">404,000</td><td align="right" bgcolor="#FFFFFF">404,000</td><td align="right" bgcolor="#A8D08D">400,000 (Δ = -4,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,395</td><td align="right" bgcolor="#FFFFFF">0,395</td><td align="right" bgcolor="#FFFFFF">0,395</td><td align="right" bgcolor="#FFFFFF">0,395</td><td align="right" bgcolor="#FFFFFF">0,395</td><td align="right" bgcolor="#A8D08D">0,391 (Δ = -0,004)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 57,344 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">329,736 ns</td><td align="right" bgcolor="#FFFFFF">282,888 ns</td><td align="right" bgcolor="#FFFFFF">283,178 ns</td><td align="right" bgcolor="#FFFFFF">282,439 ns</td><td align="right" bgcolor="#FFFFFF">272,393 ns</td><td align="right" bgcolor="#FFFFFF">281,755 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,330 μs</td><td align="right" bgcolor="#FFFFFF">0,283 μs</td><td align="right" bgcolor="#FFFFFF">0,283 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#A8D08D">301,000 (Δ = -6,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#A8D08D">0,294 (Δ = -0,006)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 369,020 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+61,7 %</td><td align="right" bgcolor="#A8D08D">-34,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">535,594 ns</td><td align="right" bgcolor="#FFFFFF">498,042 ns</td><td align="right" bgcolor="#FF4949">805,435 ns (Δ = +307,393 ns)</td><td align="right" bgcolor="#A8D08D">529,323 ns (Δ = -276,112 ns)</td><td align="right" bgcolor="#FFFFFF">436,415 ns</td><td align="right" bgcolor="#FFFFFF">482,701 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,536 μs</td><td align="right" bgcolor="#FFFFFF">0,498 μs</td><td align="right" bgcolor="#FFFFFF">0,805 μs</td><td align="right" bgcolor="#FFFFFF">0,529 μs</td><td align="right" bgcolor="#FFFFFF">0,436 μs</td><td align="right" bgcolor="#FFFFFF">0,483 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#A8D08D">243,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#A8D08D">0,237 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags"></a>GetFieldEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 37,889 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">104,945 ns</td><td align="right" bgcolor="#FFFFFF">83,860 ns</td><td align="right" bgcolor="#FFFFFF">89,365 ns</td><td align="right" bgcolor="#FFFFFF">84,628 ns</td><td align="right" bgcolor="#FFFFFF">73,054 ns</td><td align="right" bgcolor="#FFFFFF">67,056 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,089 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 24,555 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">105,246 ns</td><td align="right" bgcolor="#FFFFFF">95,083 ns</td><td align="right" bgcolor="#FFFFFF">101,936 ns</td><td align="right" bgcolor="#FFFFFF">95,746 ns</td><td align="right" bgcolor="#FFFFFF">84,419 ns</td><td align="right" bgcolor="#FFFFFF">80,691 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 25,386 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">98,125 ns</td><td align="right" bgcolor="#FFFFFF">81,545 ns</td><td align="right" bgcolor="#FFFFFF">82,738 ns</td><td align="right" bgcolor="#FFFFFF">82,500 ns</td><td align="right" bgcolor="#FFFFFF">74,621 ns</td><td align="right" bgcolor="#FFFFFF">72,739 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 229,322 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">445,806 ns</td><td align="right" bgcolor="#FFFFFF">385,522 ns</td><td align="right" bgcolor="#FFFFFF">595,873 ns</td><td align="right" bgcolor="#FFFFFF">382,060 ns</td><td align="right" bgcolor="#FFFFFF">366,551 ns</td><td align="right" bgcolor="#FFFFFF">423,781 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,446 μs</td><td align="right" bgcolor="#FFFFFF">0,386 μs</td><td align="right" bgcolor="#FFFFFF">0,596 μs</td><td align="right" bgcolor="#FFFFFF">0,382 μs</td><td align="right" bgcolor="#FFFFFF">0,367 μs</td><td align="right" bgcolor="#FFFFFF">0,424 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">317,000</td><td align="right" bgcolor="#FF4949">348,000 (Δ = +31,000)</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FF4949">364,000 (Δ = +16,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,310</td><td align="right" bgcolor="#FF4949">0,340 (Δ = +0,030)</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FF4949">0,355 (Δ = +0,016)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 9,994 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">83,626 ns</td><td align="right" bgcolor="#FFFFFF">74,533 ns</td><td align="right" bgcolor="#FFFFFF">74,568 ns</td><td align="right" bgcolor="#FFFFFF">75,506 ns</td><td align="right" bgcolor="#FFFFFF">73,632 ns</td><td align="right" bgcolor="#FFFFFF">74,675 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 59,689 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">672,104 ns</td><td align="right" bgcolor="#FFFFFF">649,990 ns</td><td align="right" bgcolor="#FFFFFF">618,045 ns</td><td align="right" bgcolor="#FFFFFF">648,563 ns</td><td align="right" bgcolor="#FFFFFF">616,954 ns</td><td align="right" bgcolor="#FFFFFF">676,643 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,672 μs</td><td align="right" bgcolor="#FFFFFF">0,650 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,649 μs</td><td align="right" bgcolor="#FFFFFF">0,617 μs</td><td align="right" bgcolor="#FFFFFF">0,677 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">358,000</td><td align="right" bgcolor="#FF4949">389,000 (Δ = +31,000)</td><td align="right" bgcolor="#FFFFFF">389,000</td><td align="right" bgcolor="#FFFFFF">389,000</td><td align="right" bgcolor="#FFFFFF">389,000</td><td align="right" bgcolor="#FF4949">397,000 (Δ = +8,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,350</td><td align="right" bgcolor="#FF4949">0,380 (Δ = +0,030)</td><td align="right" bgcolor="#FFFFFF">0,380</td><td align="right" bgcolor="#FFFFFF">0,380</td><td align="right" bgcolor="#FFFFFF">0,380</td><td align="right" bgcolor="#FF4949">0,388 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 7,397 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">81,442 ns</td><td align="right" bgcolor="#FFFFFF">77,737 ns</td><td align="right" bgcolor="#FFFFFF">77,016 ns</td><td align="right" bgcolor="#FFFFFF">75,979 ns</td><td align="right" bgcolor="#FFFFFF">74,045 ns</td><td align="right" bgcolor="#FFFFFF">77,365 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 38,426 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">124,499 ns</td><td align="right" bgcolor="#FFFFFF">115,497 ns</td><td align="right" bgcolor="#FFFFFF">110,471 ns</td><td align="right" bgcolor="#FFFFFF">148,845 ns</td><td align="right" bgcolor="#FFFFFF">110,419 ns</td><td align="right" bgcolor="#FFFFFF">127,944 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">33,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,032 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx"></a>GetGenericTypeDefinitionEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 17,354 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">62,896 ns</td><td align="right" bgcolor="#FFFFFF">60,601 ns</td><td align="right" bgcolor="#FFFFFF">57,410 ns</td><td align="right" bgcolor="#FFFFFF">74,764 ns</td><td align="right" bgcolor="#FFFFFF">68,053 ns</td><td align="right" bgcolor="#FFFFFF">72,880 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetInterfacesEx"></a>GetInterfacesEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 31,244 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">112,468 ns</td><td align="right" bgcolor="#FFFFFF">98,689 ns</td><td align="right" bgcolor="#FFFFFF">92,753 ns</td><td align="right" bgcolor="#FFFFFF">123,997 ns</td><td align="right" bgcolor="#FFFFFF">97,183 ns</td><td align="right" bgcolor="#FFFFFF">108,317 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.6</td><td align="right">5.9</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,1 %</td><td align="right" bgcolor="#A8D08D">-1,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">195,000</td><td align="right" bgcolor="#FFFFFF">195,000</td><td align="right" bgcolor="#FFFFFF">195,000</td><td align="right" bgcolor="#FFFFFF">195,000</td><td align="right" bgcolor="#FF4949">205,000 (Δ = +10,000)</td><td align="right" bgcolor="#A8D08D">203,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FF4949">0,200 (Δ = +0,010)</td><td align="right" bgcolor="#A8D08D">0,198 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 198,336 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1088,489 ns</td><td align="right" bgcolor="#FFFFFF">928,956 ns</td><td align="right" bgcolor="#FFFFFF">952,852 ns</td><td align="right" bgcolor="#FFFFFF">969,021 ns</td><td align="right" bgcolor="#FFFFFF">890,153 ns</td><td align="right" bgcolor="#FFFFFF">921,587 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,088 μs</td><td align="right" bgcolor="#FFFFFF">0,929 μs</td><td align="right" bgcolor="#FFFFFF">0,953 μs</td><td align="right" bgcolor="#FFFFFF">0,969 μs</td><td align="right" bgcolor="#FFFFFF">0,890 μs</td><td align="right" bgcolor="#FFFFFF">0,922 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">271,000</td><td align="right" bgcolor="#FFFFFF">271,000</td><td align="right" bgcolor="#FFFFFF">271,000</td><td align="right" bgcolor="#FFFFFF">271,000</td><td align="right" bgcolor="#FFFFFF">271,000</td><td align="right" bgcolor="#A8D08D">269,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,265</td><td align="right" bgcolor="#FFFFFF">0,265</td><td align="right" bgcolor="#FFFFFF">0,265</td><td align="right" bgcolor="#FFFFFF">0,265</td><td align="right" bgcolor="#FFFFFF">0,265</td><td align="right" bgcolor="#A8D08D">0,263 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 205,733 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">560,799 ns</td><td align="right" bgcolor="#FFFFFF">471,804 ns</td><td align="right" bgcolor="#FFFFFF">662,510 ns</td><td align="right" bgcolor="#FFFFFF">471,729 ns</td><td align="right" bgcolor="#FFFFFF">456,777 ns</td><td align="right" bgcolor="#FFFFFF">486,549 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,561 μs</td><td align="right" bgcolor="#FFFFFF">0,472 μs</td><td align="right" bgcolor="#FFFFFF">0,663 μs</td><td align="right" bgcolor="#FFFFFF">0,472 μs</td><td align="right" bgcolor="#FFFFFF">0,457 μs</td><td align="right" bgcolor="#FFFFFF">0,487 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#A8D08D">26,000 (Δ = -5,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#A8D08D">0,025 (Δ = -0,005)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance"></a>GetMemberEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 109,610 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">562,736 ns</td><td align="right" bgcolor="#FFFFFF">471,947 ns</td><td align="right" bgcolor="#FFFFFF">481,592 ns</td><td align="right" bgcolor="#FFFFFF">474,585 ns</td><td align="right" bgcolor="#FFFFFF">453,126 ns</td><td align="right" bgcolor="#FFFFFF">473,645 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,563 μs</td><td align="right" bgcolor="#FFFFFF">0,472 μs</td><td align="right" bgcolor="#FFFFFF">0,482 μs</td><td align="right" bgcolor="#FFFFFF">0,475 μs</td><td align="right" bgcolor="#FFFFFF">0,453 μs</td><td align="right" bgcolor="#FFFFFF">0,474 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 53,797 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">479,749 ns</td><td align="right" bgcolor="#FFFFFF">448,529 ns</td><td align="right" bgcolor="#FFFFFF">502,327 ns</td><td align="right" bgcolor="#FFFFFF">453,159 ns</td><td align="right" bgcolor="#FFFFFF">481,952 ns</td><td align="right" bgcolor="#FFFFFF">462,200 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,480 μs</td><td align="right" bgcolor="#FFFFFF">0,449 μs</td><td align="right" bgcolor="#FFFFFF">0,502 μs</td><td align="right" bgcolor="#FFFFFF">0,453 μs</td><td align="right" bgcolor="#FFFFFF">0,482 μs</td><td align="right" bgcolor="#FFFFFF">0,462 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#A8D08D">26,000 (Δ = -5,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#A8D08D">0,025 (Δ = -0,005)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static"></a>GetMethodEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 183,209 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">653,215 ns</td><td align="right" bgcolor="#FFFFFF">492,007 ns</td><td align="right" bgcolor="#FFFFFF">470,306 ns</td><td align="right" bgcolor="#FFFFFF">506,379 ns</td><td align="right" bgcolor="#FFFFFF">470,006 ns</td><td align="right" bgcolor="#FFFFFF">501,328 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,653 μs</td><td align="right" bgcolor="#FFFFFF">0,492 μs</td><td align="right" bgcolor="#FFFFFF">0,470 μs</td><td align="right" bgcolor="#FFFFFF">0,506 μs</td><td align="right" bgcolor="#FFFFFF">0,470 μs</td><td align="right" bgcolor="#FFFFFF">0,501 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#A8D08D">243,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#A8D08D">0,237 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags"></a>GetMethodEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 36,500 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">117,512 ns</td><td align="right" bgcolor="#FFFFFF">128,004 ns</td><td align="right" bgcolor="#FFFFFF">116,382 ns</td><td align="right" bgcolor="#FFFFFF">100,442 ns</td><td align="right" bgcolor="#FFFFFF">92,652 ns</td><td align="right" bgcolor="#FFFFFF">91,504 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,116 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 28,619 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">127,417 ns</td><td align="right" bgcolor="#FFFFFF">116,271 ns</td><td align="right" bgcolor="#FFFFFF">117,906 ns</td><td align="right" bgcolor="#FFFFFF">110,999 ns</td><td align="right" bgcolor="#FFFFFF">98,942 ns</td><td align="right" bgcolor="#FFFFFF">98,797 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,116 μs</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 24,106 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">117,389 ns</td><td align="right" bgcolor="#FFFFFF">101,292 ns</td><td align="right" bgcolor="#FFFFFF">107,013 ns</td><td align="right" bgcolor="#FFFFFF">102,434 ns</td><td align="right" bgcolor="#FFFFFF">93,283 ns</td><td align="right" bgcolor="#FFFFFF">112,804 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,117 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 2076,572 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,8 %</td><td align="right" bgcolor="#A8D08D">-24,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#FF4949">+62,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3771,203 ns</td><td align="right" bgcolor="#FF4949">4631,851 ns (Δ = +860,648 ns)</td><td align="right" bgcolor="#A8D08D">3515,654 ns (Δ = -1116,197 ns)</td><td align="right" bgcolor="#FFFFFF">3648,113 ns</td><td align="right" bgcolor="#A8D08D">3333,668 ns (Δ = -314,444 ns)</td><td align="right" bgcolor="#FF4949">5410,240 ns (Δ = +2076,572 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,771 μs</td><td align="right" bgcolor="#FFFFFF">4,632 μs</td><td align="right" bgcolor="#FFFFFF">3,516 μs</td><td align="right" bgcolor="#FFFFFF">3,648 μs</td><td align="right" bgcolor="#FFFFFF">3,334 μs</td><td align="right" bgcolor="#FFFFFF">5,410 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,7 %</td><td align="right" bgcolor="#FF4949">+1,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td><td align="right" bgcolor="#FF4949">+2,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">2059,000</td><td align="right" bgcolor="#FF4949">2115,000 (Δ = +56,000)</td><td align="right" bgcolor="#FF4949">2136,000 (Δ = +21,000)</td><td align="right" bgcolor="#FFFFFF">2136,000</td><td align="right" bgcolor="#FF4949">2141,000 (Δ = +5,000)</td><td align="right" bgcolor="#FF4949">2190,000 (Δ = +49,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,011</td><td align="right" bgcolor="#FF4949">2,065 (Δ = +0,055)</td><td align="right" bgcolor="#FF4949">2,086 (Δ = +0,021)</td><td align="right" bgcolor="#FFFFFF">2,086</td><td align="right" bgcolor="#FF4949">2,091 (Δ = +0,005)</td><td align="right" bgcolor="#FF4949">2,139 (Δ = +0,048)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 138,243 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">892,242 ns</td><td align="right" bgcolor="#FFFFFF">835,968 ns</td><td align="right" bgcolor="#FFFFFF">767,561 ns</td><td align="right" bgcolor="#FFFFFF">881,835 ns</td><td align="right" bgcolor="#FFFFFF">753,999 ns</td><td align="right" bgcolor="#FFFFFF">844,149 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,892 μs</td><td align="right" bgcolor="#FFFFFF">0,836 μs</td><td align="right" bgcolor="#FFFFFF">0,768 μs</td><td align="right" bgcolor="#FFFFFF">0,882 μs</td><td align="right" bgcolor="#FFFFFF">0,754 μs</td><td align="right" bgcolor="#FFFFFF">0,844 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -4,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,004)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 2356,768 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,5 %</td><td align="right" bgcolor="#A8D08D">-7,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,6 %</td><td align="right" bgcolor="#FF4949">+80,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3608,618 ns</td><td align="right" bgcolor="#A8D08D">3339,286 ns (Δ = -269,332 ns)</td><td align="right" bgcolor="#A8D08D">3083,749 ns (Δ = -255,537 ns)</td><td align="right" bgcolor="#FFFFFF">3252,018 ns</td><td align="right" bgcolor="#A8D08D">2940,432 ns (Δ = -311,585 ns)</td><td align="right" bgcolor="#FF4949">5297,200 ns (Δ = +2356,768 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,609 μs</td><td align="right" bgcolor="#FFFFFF">3,339 μs</td><td align="right" bgcolor="#FFFFFF">3,084 μs</td><td align="right" bgcolor="#FFFFFF">3,252 μs</td><td align="right" bgcolor="#FFFFFF">2,940 μs</td><td align="right" bgcolor="#FFFFFF">5,297 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +2,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,3 %</td><td align="right" bgcolor="#FF4949">+2,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3483,000</td><td align="right" bgcolor="#FF4949">3596,000 (Δ = +113,000)</td><td align="right" bgcolor="#FFFFFF">3596,000</td><td align="right" bgcolor="#FFFFFF">3596,000</td><td align="right" bgcolor="#FF4949">3643,000 (Δ = +47,000)</td><td align="right" bgcolor="#FF4949">3739,000 (Δ = +96,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,401</td><td align="right" bgcolor="#FF4949">3,512 (Δ = +0,110)</td><td align="right" bgcolor="#FFFFFF">3,512</td><td align="right" bgcolor="#FFFFFF">3,512</td><td align="right" bgcolor="#FF4949">3,558 (Δ = +0,046)</td><td align="right" bgcolor="#FF4949">3,651 (Δ = +0,094)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,004 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 202,869 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">931,364 ns</td><td align="right" bgcolor="#FFFFFF">754,756 ns</td><td align="right" bgcolor="#FFFFFF">850,353 ns</td><td align="right" bgcolor="#FFFFFF">852,858 ns</td><td align="right" bgcolor="#FFFFFF">728,494 ns</td><td align="right" bgcolor="#FFFFFF">840,203 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,931 μs</td><td align="right" bgcolor="#FFFFFF">0,755 μs</td><td align="right" bgcolor="#FFFFFF">0,850 μs</td><td align="right" bgcolor="#FFFFFF">0,853 μs</td><td align="right" bgcolor="#FFFFFF">0,728 μs</td><td align="right" bgcolor="#FFFFFF">0,840 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -4,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,004)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 545,987 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+54,0 %</td><td align="right" bgcolor="#A8D08D">-50,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">601,579 ns</td><td align="right" bgcolor="#FFFFFF">470,537 ns</td><td align="right" bgcolor="#FFFFFF">469,400 ns</td><td align="right" bgcolor="#FFFFFF">659,281 ns</td><td align="right" bgcolor="#FF4949">1015,387 ns (Δ = +356,105 ns)</td><td align="right" bgcolor="#A8D08D">498,616 ns (Δ = -516,771 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,602 μs</td><td align="right" bgcolor="#FFFFFF">0,471 μs</td><td align="right" bgcolor="#FFFFFF">0,469 μs</td><td align="right" bgcolor="#FFFFFF">0,659 μs</td><td align="right" bgcolor="#FFFFFF">1,015 μs</td><td align="right" bgcolor="#FFFFFF">0,499 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.6</td><td align="right">5.9</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#A8D08D">-0,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FF4949">276,000 (Δ = +10,000)</td><td align="right" bgcolor="#A8D08D">275,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FF4949">0,270 (Δ = +0,010)</td><td align="right" bgcolor="#A8D08D">0,269 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 181,351 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1007,902 ns</td><td align="right" bgcolor="#FFFFFF">961,426 ns</td><td align="right" bgcolor="#FFFFFF">826,551 ns</td><td align="right" bgcolor="#FFFFFF">872,432 ns</td><td align="right" bgcolor="#FFFFFF">829,411 ns</td><td align="right" bgcolor="#FFFFFF">904,459 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,008 μs</td><td align="right" bgcolor="#FFFFFF">0,961 μs</td><td align="right" bgcolor="#FFFFFF">0,827 μs</td><td align="right" bgcolor="#FFFFFF">0,872 μs</td><td align="right" bgcolor="#FFFFFF">0,829 μs</td><td align="right" bgcolor="#FFFFFF">0,904 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">548,000</td><td align="right" bgcolor="#FFFFFF">548,000</td><td align="right" bgcolor="#FFFFFF">548,000</td><td align="right" bgcolor="#FFFFFF">548,000</td><td align="right" bgcolor="#FFFFFF">548,000</td><td align="right" bgcolor="#A8D08D">541,000 (Δ = -7,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,535</td><td align="right" bgcolor="#FFFFFF">0,535</td><td align="right" bgcolor="#FFFFFF">0,535</td><td align="right" bgcolor="#FFFFFF">0,535</td><td align="right" bgcolor="#FFFFFF">0,535</td><td align="right" bgcolor="#A8D08D">0,528 (Δ = -0,007)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 86,128 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">525,769 ns</td><td align="right" bgcolor="#FFFFFF">455,142 ns</td><td align="right" bgcolor="#FFFFFF">458,013 ns</td><td align="right" bgcolor="#FFFFFF">441,196 ns</td><td align="right" bgcolor="#FFFFFF">439,641 ns</td><td align="right" bgcolor="#FFFFFF">465,117 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,526 μs</td><td align="right" bgcolor="#FFFFFF">0,455 μs</td><td align="right" bgcolor="#FFFFFF">0,458 μs</td><td align="right" bgcolor="#FFFFFF">0,441 μs</td><td align="right" bgcolor="#FFFFFF">0,440 μs</td><td align="right" bgcolor="#FFFFFF">0,465 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">563,000</td><td align="right" bgcolor="#FFFFFF">563,000</td><td align="right" bgcolor="#FFFFFF">563,000</td><td align="right" bgcolor="#FFFFFF">563,000</td><td align="right" bgcolor="#FFFFFF">563,000</td><td align="right" bgcolor="#A8D08D">557,000 (Δ = -6,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,550</td><td align="right" bgcolor="#FFFFFF">0,550</td><td align="right" bgcolor="#FFFFFF">0,550</td><td align="right" bgcolor="#FFFFFF">0,550</td><td align="right" bgcolor="#FFFFFF">0,550</td><td align="right" bgcolor="#A8D08D">0,544 (Δ = -0,006)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 38,745 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">150,958 ns</td><td align="right" bgcolor="#FFFFFF">131,103 ns</td><td align="right" bgcolor="#FFFFFF">129,286 ns</td><td align="right" bgcolor="#FFFFFF">131,543 ns</td><td align="right" bgcolor="#FFFFFF">125,331 ns</td><td align="right" bgcolor="#FFFFFF">112,213 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,151 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#A8D08D">10,000 (Δ = -5,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,015</td><td align="right" bgcolor="#FFFFFF">0,015</td><td align="right" bgcolor="#FFFFFF">0,015</td><td align="right" bgcolor="#FFFFFF">0,015</td><td align="right" bgcolor="#FFFFFF">0,015</td><td align="right" bgcolor="#A8D08D">0,010 (Δ = -0,005)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 127,005 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">581,667 ns</td><td align="right" bgcolor="#FFFFFF">476,394 ns</td><td align="right" bgcolor="#FFFFFF">540,549 ns</td><td align="right" bgcolor="#FFFFFF">519,454 ns</td><td align="right" bgcolor="#FFFFFF">454,662 ns</td><td align="right" bgcolor="#FFFFFF">523,621 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,582 μs</td><td align="right" bgcolor="#FFFFFF">0,476 μs</td><td align="right" bgcolor="#FFFFFF">0,541 μs</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td><td align="right" bgcolor="#FFFFFF">0,455 μs</td><td align="right" bgcolor="#FFFFFF">0,524 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FF4949">265,000 (Δ = +19,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FF4949">0,259 (Δ = +0,019)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance"></a>GetPropertyEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 35,689 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">130,400 ns</td><td align="right" bgcolor="#FFFFFF">108,671 ns</td><td align="right" bgcolor="#FFFFFF">108,203 ns</td><td align="right" bgcolor="#FFFFFF">109,401 ns</td><td align="right" bgcolor="#FFFFFF">94,711 ns</td><td align="right" bgcolor="#FFFFFF">115,880 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,130 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,116 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">26,000 (Δ = +26,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,025 (Δ = +0,025)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 362,855 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2068,678 ns</td><td align="right" bgcolor="#FFFFFF">2015,582 ns</td><td align="right" bgcolor="#FFFFFF">1853,946 ns</td><td align="right" bgcolor="#FFFFFF">1853,651 ns</td><td align="right" bgcolor="#FFFFFF">1712,548 ns</td><td align="right" bgcolor="#FF4949">2075,403 ns (Δ = +362,855 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,069 μs</td><td align="right" bgcolor="#FFFFFF">2,016 μs</td><td align="right" bgcolor="#FFFFFF">1,854 μs</td><td align="right" bgcolor="#FFFFFF">1,854 μs</td><td align="right" bgcolor="#FFFFFF">1,713 μs</td><td align="right" bgcolor="#FFFFFF">2,075 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.6</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#FF4949">+261,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FF4949">210,000 (Δ = +10,000)</td><td align="right" bgcolor="#FF4949">760,000 (Δ = +550,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FF4949">0,205 (Δ = +0,010)</td><td align="right" bgcolor="#FF4949">0,742 (Δ = +0,537)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 144,058 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">144,569 ns</td><td align="right" bgcolor="#FFFFFF">131,400 ns</td><td align="right" bgcolor="#FFFFFF">124,790 ns</td><td align="right" bgcolor="#FFFFFF">167,179 ns</td><td align="right" bgcolor="#FFFFFF">268,848 ns</td><td align="right" bgcolor="#FFFFFF">126,040 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#FFFFFF">0,269 μs</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">317,000</td><td align="right" bgcolor="#FFFFFF">317,000</td><td align="right" bgcolor="#FFFFFF">317,000</td><td align="right" bgcolor="#FFFFFF">317,000</td><td align="right" bgcolor="#FFFFFF">317,000</td><td align="right" bgcolor="#FF4949">321,000 (Δ = +4,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,310</td><td align="right" bgcolor="#FFFFFF">0,310</td><td align="right" bgcolor="#FFFFFF">0,310</td><td align="right" bgcolor="#FFFFFF">0,310</td><td align="right" bgcolor="#FFFFFF">0,310</td><td align="right" bgcolor="#FF4949">0,313 (Δ = +0,004)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetTypeInfo"></a>GetTypeInfo

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 2,626 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,589 ns</td><td align="right" bgcolor="#FFFFFF">8,750 ns</td><td align="right" bgcolor="#FFFFFF">8,849 ns</td><td align="right" bgcolor="#FFFFFF">9,569 ns</td><td align="right" bgcolor="#FFFFFF">8,230 ns</td><td align="right" bgcolor="#FFFFFF">7,963 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_HasBaseTypeEx"></a>HasBaseTypeEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 15,731 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,166 ns</td><td align="right" bgcolor="#FFFFFF">23,314 ns</td><td align="right" bgcolor="#FFFFFF">23,618 ns</td><td align="right" bgcolor="#FFFFFF">27,811 ns</td><td align="right" bgcolor="#FFFFFF">39,044 ns</td><td align="right" bgcolor="#FFFFFF">24,859 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx"></a>ImplementsInterfaceEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 18,319 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,066 ns</td><td align="right" bgcolor="#FFFFFF">25,200 ns</td><td align="right" bgcolor="#FFFFFF">23,277 ns</td><td align="right" bgcolor="#FFFFFF">29,337 ns</td><td align="right" bgcolor="#FFFFFF">41,596 ns</td><td align="right" bgcolor="#FFFFFF">24,523 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx"></a>ImplementsInterfacesEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 18,443 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,979 ns</td><td align="right" bgcolor="#FFFFFF">21,949 ns</td><td align="right" bgcolor="#FFFFFF">20,948 ns</td><td align="right" bgcolor="#FFFFFF">26,176 ns</td><td align="right" bgcolor="#FFFFFF">39,391 ns</td><td align="right" bgcolor="#FFFFFF">22,752 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAbstractEx"></a>IsAbstractEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 8,576 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17,110 ns</td><td align="right" bgcolor="#FFFFFF">11,922 ns</td><td align="right" bgcolor="#FFFFFF">10,220 ns</td><td align="right" bgcolor="#FFFFFF">15,172 ns</td><td align="right" bgcolor="#FFFFFF">18,626 ns</td><td align="right" bgcolor="#FFFFFF">10,051 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsArrayEx"></a>IsArrayEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 10,618 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,568 ns</td><td align="right" bgcolor="#FFFFFF">13,251 ns</td><td align="right" bgcolor="#FFFFFF">13,061 ns</td><td align="right" bgcolor="#FFFFFF">17,406 ns</td><td align="right" bgcolor="#FFFFFF">23,679 ns</td><td align="right" bgcolor="#FFFFFF">14,189 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAssignableFromEx"></a>IsAssignableFromEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 5,742 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,184 ns</td><td align="right" bgcolor="#FFFFFF">16,514 ns</td><td align="right" bgcolor="#FFFFFF">16,073 ns</td><td align="right" bgcolor="#FFFFFF">21,325 ns</td><td align="right" bgcolor="#FFFFFF">16,040 ns</td><td align="right" bgcolor="#FFFFFF">21,781 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 383,928 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-62,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">369,988 ns</td><td align="right" bgcolor="#FFFFFF">345,868 ns</td><td align="right" bgcolor="#FFFFFF">297,658 ns</td><td align="right" bgcolor="#FFFFFF">421,153 ns</td><td align="right" bgcolor="#FFFFFF">617,299 ns</td><td align="right" bgcolor="#A8D08D">233,371 ns (Δ = -383,928 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,370 μs</td><td align="right" bgcolor="#FFFFFF">0,346 μs</td><td align="right" bgcolor="#FFFFFF">0,298 μs</td><td align="right" bgcolor="#FFFFFF">0,421 μs</td><td align="right" bgcolor="#FFFFFF">0,617 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsClassEx"></a>IsClassEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 134,145 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">146,026 ns</td><td align="right" bgcolor="#FFFFFF">187,345 ns</td><td align="right" bgcolor="#FFFFFF">115,175 ns</td><td align="right" bgcolor="#FFFFFF">138,109 ns</td><td align="right" bgcolor="#FFFFFF">249,320 ns</td><td align="right" bgcolor="#FFFFFF">124,803 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,187 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,249 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCOMObjectEx"></a>IsCOMObjectEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 10,254 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,750 ns</td><td align="right" bgcolor="#FFFFFF">16,191 ns</td><td align="right" bgcolor="#FFFFFF">16,179 ns</td><td align="right" bgcolor="#FFFFFF">22,410 ns</td><td align="right" bgcolor="#FFFFFF">26,433 ns</td><td align="right" bgcolor="#FFFFFF">16,872 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsEnumEx"></a>IsEnumEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 8,806 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,766 ns</td><td align="right" bgcolor="#FFFFFF">25,241 ns</td><td align="right" bgcolor="#FFFFFF">20,721 ns</td><td align="right" bgcolor="#FFFFFF">25,734 ns</td><td align="right" bgcolor="#FFFFFF">29,527 ns</td><td align="right" bgcolor="#FFFFFF">22,824 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 4,616 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,329 ns</td><td align="right" bgcolor="#FFFFFF">5,982 ns</td><td align="right" bgcolor="#FFFFFF">6,060 ns</td><td align="right" bgcolor="#FFFFFF">8,708 ns</td><td align="right" bgcolor="#FFFFFF">10,598 ns</td><td align="right" bgcolor="#FFFFFF">6,843 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeEx"></a>IsGenericTypeEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 4,441 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,138 ns</td><td align="right" bgcolor="#FFFFFF">6,140 ns</td><td align="right" bgcolor="#FFFFFF">6,107 ns</td><td align="right" bgcolor="#FFFFFF">8,773 ns</td><td align="right" bgcolor="#FFFFFF">10,548 ns</td><td align="right" bgcolor="#FFFFFF">6,317 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx"></a>IsInstanceOfTypeEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 3420,059 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,5 %</td><td align="right" bgcolor="#A8D08D">-13,9 %</td><td align="right" bgcolor="#FF4949">+25,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14231,397 ns</td><td align="right" bgcolor="#A8D08D">12572,349 ns (Δ = -1659,048 ns)</td><td align="right" bgcolor="#FFFFFF">12756,557 ns</td><td align="right" bgcolor="#FF4949">14866,293 ns (Δ = +2109,736 ns)</td><td align="right" bgcolor="#A8D08D">12795,276 ns (Δ = -2071,017 ns)</td><td align="right" bgcolor="#FF4949">15992,408 ns (Δ = +3197,132 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14,231 μs</td><td align="right" bgcolor="#FFFFFF">12,572 μs</td><td align="right" bgcolor="#FFFFFF">12,757 μs</td><td align="right" bgcolor="#FFFFFF">14,866 μs</td><td align="right" bgcolor="#FFFFFF">12,795 μs</td><td align="right" bgcolor="#FFFFFF">15,992 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#FF4949">+20,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">5801,000</td><td align="right" bgcolor="#FF4949">6139,000 (Δ = +338,000)</td><td align="right" bgcolor="#FFFFFF">6139,000</td><td align="right" bgcolor="#FFFFFF">6139,000</td><td align="right" bgcolor="#FF4949">6374,000 (Δ = +235,000)</td><td align="right" bgcolor="#FF4949">7667,000 (Δ = +1293,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">5,665</td><td align="right" bgcolor="#FF4949">5,995 (Δ = +0,330)</td><td align="right" bgcolor="#FFFFFF">5,995</td><td align="right" bgcolor="#FFFFFF">5,995</td><td align="right" bgcolor="#FF4949">6,225 (Δ = +0,229)</td><td align="right" bgcolor="#FF4949">7,487 (Δ = +1,263)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,007 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 6,132 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,165 ns</td><td align="right" bgcolor="#FFFFFF">6,658 ns</td><td align="right" bgcolor="#FFFFFF">7,593 ns</td><td align="right" bgcolor="#FFFFFF">10,211 ns</td><td align="right" bgcolor="#FFFFFF">12,789 ns</td><td align="right" bgcolor="#FFFFFF">7,923 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsNestedPublicEx"></a>IsNestedPublicEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 5,647 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,785 ns</td><td align="right" bgcolor="#FFFFFF">10,624 ns</td><td align="right" bgcolor="#FFFFFF">13,767 ns</td><td align="right" bgcolor="#FFFFFF">12,509 ns</td><td align="right" bgcolor="#FFFFFF">15,452 ns</td><td align="right" bgcolor="#FFFFFF">10,139 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPrimitiveEx"></a>IsPrimitiveEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 4,718 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,634 ns</td><td align="right" bgcolor="#FFFFFF">10,248 ns</td><td align="right" bgcolor="#FFFFFF">10,204 ns</td><td align="right" bgcolor="#FFFFFF">12,814 ns</td><td align="right" bgcolor="#FFFFFF">14,922 ns</td><td align="right" bgcolor="#FFFFFF">10,680 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPublicEx"></a>IsPublicEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 6,770 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,567 ns</td><td align="right" bgcolor="#FFFFFF">10,488 ns</td><td align="right" bgcolor="#FFFFFF">13,892 ns</td><td align="right" bgcolor="#FFFFFF">14,458 ns</td><td align="right" bgcolor="#FFFFFF">16,952 ns</td><td align="right" bgcolor="#FFFFFF">10,181 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsSerializableEx"></a>IsSerializableEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 8,967 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,785 ns</td><td align="right" bgcolor="#FFFFFF">10,585 ns</td><td align="right" bgcolor="#FFFFFF">10,659 ns</td><td align="right" bgcolor="#FFFFFF">12,769 ns</td><td align="right" bgcolor="#FFFFFF">19,220 ns</td><td align="right" bgcolor="#FFFFFF">10,253 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsValueTypeEx"></a>IsValueTypeEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 30,981 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31,526 ns</td><td align="right" bgcolor="#FFFFFF">31,554 ns</td><td align="right" bgcolor="#FFFFFF">25,676 ns</td><td align="right" bgcolor="#FFFFFF">32,357 ns</td><td align="right" bgcolor="#FFFFFF">56,656 ns</td><td align="right" bgcolor="#FFFFFF">32,723 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="TypeExtensions_Benchmark"></a>TypeExtensions_Benchmark

### <a name="TypeExtensions_Benchmark_GetCollectionElementType"></a>GetCollectionElementType

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 588,812 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-74,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">793,732 ns</td><td align="right" bgcolor="#A8D08D">204,920 ns (Δ = -588,812 ns)</td><td align="right" bgcolor="#FFFFFF">217,032 ns</td><td align="right" bgcolor="#FFFFFF">260,888 ns</td><td align="right" bgcolor="#FFFFFF">208,374 ns</td><td align="right" bgcolor="#FFFFFF">315,772 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,794 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,217 μs</td><td align="right" bgcolor="#FFFFFF">0,261 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,316 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-79,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#A8D08D">36,000 (Δ = -143,000)</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">33,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#A8D08D">0,035 (Δ = -0,140)</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,032 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsBasicType"></a>IsBasicType

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 5,721 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17,736 ns</td><td align="right" bgcolor="#FFFFFF">12,851 ns</td><td align="right" bgcolor="#FFFFFF">13,380 ns</td><td align="right" bgcolor="#FFFFFF">12,015 ns</td><td align="right" bgcolor="#FFFFFF">12,632 ns</td><td align="right" bgcolor="#FFFFFF">17,501 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsClassType"></a>IsClassType

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 114,549 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">162,291 ns</td><td align="right" bgcolor="#FFFFFF">152,239 ns</td><td align="right" bgcolor="#FFFFFF">154,254 ns</td><td align="right" bgcolor="#FFFFFF">196,817 ns</td><td align="right" bgcolor="#FFFFFF">157,766 ns</td><td align="right" bgcolor="#FFFFFF">266,788 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,162 μs</td><td align="right" bgcolor="#FFFFFF">0,152 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,267 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsCollection"></a>IsCollection

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 13,382 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,332 ns</td><td align="right" bgcolor="#FFFFFF">23,352 ns</td><td align="right" bgcolor="#FFFFFF">27,895 ns</td><td align="right" bgcolor="#FFFFFF">22,457 ns</td><td align="right" bgcolor="#FFFFFF">30,965 ns</td><td align="right" bgcolor="#FFFFFF">35,839 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsDictionary"></a>IsDictionary

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 70,933 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">74,251 ns</td><td align="right" bgcolor="#FFFFFF">72,777 ns</td><td align="right" bgcolor="#FFFFFF">110,897 ns</td><td align="right" bgcolor="#FFFFFF">68,211 ns</td><td align="right" bgcolor="#FFFFFF">70,413 ns</td><td align="right" bgcolor="#FFFFFF">139,144 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsModelBase"></a>IsModelBase

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 10,494 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">23,274 ns</td><td align="right" bgcolor="#FFFFFF">18,223 ns</td><td align="right" bgcolor="#FFFFFF">19,176 ns</td><td align="right" bgcolor="#FFFFFF">18,944 ns</td><td align="right" bgcolor="#FFFFFF">19,098 ns</td><td align="right" bgcolor="#FFFFFF">28,717 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsNullableType"></a>IsNullableType

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 103,584 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">300,620 ns</td><td align="right" bgcolor="#FFFFFF">216,157 ns</td><td align="right" bgcolor="#FFFFFF">231,010 ns</td><td align="right" bgcolor="#FFFFFF">207,867 ns</td><td align="right" bgcolor="#FFFFFF">215,297 ns</td><td align="right" bgcolor="#FFFFFF">311,451 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,301 μs</td><td align="right" bgcolor="#FFFFFF">0,216 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,215 μs</td><td align="right" bgcolor="#FFFFFF">0,311 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">33,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,032 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


## <a name="TypeFactory_Benchmark"></a>TypeFactory_Benchmark

### <a name="TypeFactory_Benchmark_CreateInstance"></a>CreateInstance

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 335,005 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1868,813 ns</td><td align="right" bgcolor="#FFFFFF">1640,444 ns</td><td align="right" bgcolor="#FFFFFF">1619,287 ns</td><td align="right" bgcolor="#FFFFFF">1637,093 ns</td><td align="right" bgcolor="#FFFFFF">1533,807 ns</td><td align="right" bgcolor="#FFFFFF">1661,832 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,869 μs</td><td align="right" bgcolor="#FFFFFF">1,640 μs</td><td align="right" bgcolor="#FFFFFF">1,619 μs</td><td align="right" bgcolor="#FFFFFF">1,637 μs</td><td align="right" bgcolor="#FFFFFF">1,534 μs</td><td align="right" bgcolor="#FFFFFF">1,662 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.6</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#FF4949">+27,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1053,000</td><td align="right" bgcolor="#A8D08D">1040,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">1040,000</td><td align="right" bgcolor="#A8D08D">1039,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">1040,000 (Δ = +1,000)</td><td align="right" bgcolor="#FF4949">1323,000 (Δ = +283,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,028</td><td align="right" bgcolor="#A8D08D">1,016 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">1,016</td><td align="right" bgcolor="#A8D08D">1,015 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">1,016 (Δ = +0,001)</td><td align="right" bgcolor="#FF4949">1,292 (Δ = +0,276)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 485,656 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1948,316 ns</td><td align="right" bgcolor="#FFFFFF">1779,391 ns</td><td align="right" bgcolor="#FFFFFF">1651,769 ns</td><td align="right" bgcolor="#FFFFFF">1611,755 ns</td><td align="right" bgcolor="#FFFFFF">1462,661 ns</td><td align="right" bgcolor="#FFFFFF">1632,925 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,948 μs</td><td align="right" bgcolor="#FFFFFF">1,779 μs</td><td align="right" bgcolor="#FFFFFF">1,652 μs</td><td align="right" bgcolor="#FFFFFF">1,612 μs</td><td align="right" bgcolor="#FFFFFF">1,463 μs</td><td align="right" bgcolor="#FFFFFF">1,633 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td><td align="right" bgcolor="#A8D08D">-0,4 %</td><td align="right" bgcolor="#FF4949">+28,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1044,000</td><td align="right" bgcolor="#A8D08D">1029,000 (Δ = -15,000)</td><td align="right" bgcolor="#FFFFFF">1029,000</td><td align="right" bgcolor="#FF4949">1032,000 (Δ = +3,000)</td><td align="right" bgcolor="#A8D08D">1028,000 (Δ = -4,000)</td><td align="right" bgcolor="#FF4949">1317,000 (Δ = +289,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,020</td><td align="right" bgcolor="#A8D08D">1,005 (Δ = -0,015)</td><td align="right" bgcolor="#FFFFFF">1,005</td><td align="right" bgcolor="#FF4949">1,008 (Δ = +0,003)</td><td align="right" bgcolor="#A8D08D">1,004 (Δ = -0,004)</td><td align="right" bgcolor="#FF4949">1,286 (Δ = +0,282)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 675,975 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,2 %</td><td align="right" bgcolor="#A8D08D">-17,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2359,662 ns</td><td align="right" bgcolor="#FF4949">2718,190 ns (Δ = +358,528 ns)</td><td align="right" bgcolor="#A8D08D">2250,844 ns (Δ = -467,346 ns)</td><td align="right" bgcolor="#FFFFFF">2125,917 ns</td><td align="right" bgcolor="#FFFFFF">2042,215 ns</td><td align="right" bgcolor="#FFFFFF">2106,056 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,360 μs</td><td align="right" bgcolor="#FFFFFF">2,718 μs</td><td align="right" bgcolor="#FFFFFF">2,251 μs</td><td align="right" bgcolor="#FFFFFF">2,126 μs</td><td align="right" bgcolor="#FFFFFF">2,042 μs</td><td align="right" bgcolor="#FFFFFF">2,106 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1469,000</td><td align="right" bgcolor="#FF4949">1480,000 (Δ = +11,000)</td><td align="right" bgcolor="#FFFFFF">1480,000</td><td align="right" bgcolor="#FFFFFF">1480,000</td><td align="right" bgcolor="#FFFFFF">1480,000</td><td align="right" bgcolor="#FF4949">1773,000 (Δ = +293,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,435</td><td align="right" bgcolor="#FF4949">1,445 (Δ = +0,011)</td><td align="right" bgcolor="#FFFFFF">1,445</td><td align="right" bgcolor="#FFFFFF">1,445</td><td align="right" bgcolor="#FFFFFF">1,445</td><td align="right" bgcolor="#FF4949">1,731 (Δ = +0,286)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 1411,331 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,2 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2759,217 ns</td><td align="right" bgcolor="#FF4949">3674,210 ns (Δ = +914,993 ns)</td><td align="right" bgcolor="#A8D08D">2477,204 ns (Δ = -1197,006 ns)</td><td align="right" bgcolor="#FFFFFF">2420,670 ns</td><td align="right" bgcolor="#FFFFFF">2262,879 ns</td><td align="right" bgcolor="#FFFFFF">2450,365 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,759 μs</td><td align="right" bgcolor="#FFFFFF">3,674 μs</td><td align="right" bgcolor="#FFFFFF">2,477 μs</td><td align="right" bgcolor="#FFFFFF">2,421 μs</td><td align="right" bgcolor="#FFFFFF">2,263 μs</td><td align="right" bgcolor="#FFFFFF">2,450 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1680,000</td><td align="right" bgcolor="#FF4949">1690,000 (Δ = +10,000)</td><td align="right" bgcolor="#FFFFFF">1690,000</td><td align="right" bgcolor="#FFFFFF">1690,000</td><td align="right" bgcolor="#FFFFFF">1690,000</td><td align="right" bgcolor="#FF4949">1983,000 (Δ = +293,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,641</td><td align="right" bgcolor="#FF4949">1,650 (Δ = +0,010)</td><td align="right" bgcolor="#FFFFFF">1,650</td><td align="right" bgcolor="#FFFFFF">1,650</td><td align="right" bgcolor="#FFFFFF">1,650</td><td align="right" bgcolor="#FF4949">1,937 (Δ = +0,286)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


## <a name="UniqueIdentifierHelper_Benchmark"></a>UniqueIdentifierHelper_Benchmark

### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier"></a>GetUniqueIdentifier

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 46,592 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">71,444 ns</td><td align="right" bgcolor="#FFFFFF">98,314 ns</td><td align="right" bgcolor="#FFFFFF">70,102 ns</td><td align="right" bgcolor="#FFFFFF">52,157 ns</td><td align="right" bgcolor="#FFFFFF">51,722 ns</td><td align="right" bgcolor="#FFFFFF">68,589 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier_Generic"></a>GetUniqueIdentifier_Generic

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 37,982 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">70,134 ns</td><td align="right" bgcolor="#FFFFFF">89,695 ns</td><td align="right" bgcolor="#FFFFFF">69,992 ns</td><td align="right" bgcolor="#FFFFFF">56,428 ns</td><td align="right" bgcolor="#FFFFFF">51,713 ns</td><td align="right" bgcolor="#FFFFFF">62,159 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ValidatableModelBase_Constructor_Benchmark"></a>ValidatableModelBase_Constructor_Benchmark

### <a name="ValidatableModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 1139,333 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3305,938 ns</td><td align="right" bgcolor="#A8D08D">2486,861 ns (Δ = -819,077 ns)</td><td align="right" bgcolor="#FFFFFF">2581,022 ns</td><td align="right" bgcolor="#FFFFFF">2829,634 ns</td><td align="right" bgcolor="#A8D08D">2166,605 ns (Δ = -663,029 ns)</td><td align="right" bgcolor="#FFFFFF">2342,795 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,306 μs</td><td align="right" bgcolor="#FFFFFF">2,487 μs</td><td align="right" bgcolor="#FFFFFF">2,581 μs</td><td align="right" bgcolor="#FFFFFF">2,830 μs</td><td align="right" bgcolor="#FFFFFF">2,167 μs</td><td align="right" bgcolor="#FFFFFF">2,343 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">975,000</td><td align="right" bgcolor="#A8D08D">973,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#A8D08D">934,000 (Δ = -39,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,952</td><td align="right" bgcolor="#A8D08D">0,950 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#A8D08D">0,912 (Δ = -0,038)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


## <a name="ValidationContext_Benchmark"></a>ValidationContext_Benchmark

### <a name="ValidationContext_Benchmark_GetBusinessRuleErrorCount"></a>GetBusinessRuleErrorCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 60,663 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">154,259 ns</td><td align="right" bgcolor="#FFFFFF">139,963 ns</td><td align="right" bgcolor="#FFFFFF">158,150 ns</td><td align="right" bgcolor="#FFFFFF">200,625 ns</td><td align="right" bgcolor="#FFFFFF">142,214 ns</td><td align="right" bgcolor="#FFFFFF">153,827 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FF4949">0,166 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleErrors"></a>GetBusinessRuleErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 68,446 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">201,467 ns</td><td align="right" bgcolor="#FFFFFF">134,407 ns</td><td align="right" bgcolor="#FFFFFF">143,945 ns</td><td align="right" bgcolor="#FFFFFF">139,942 ns</td><td align="right" bgcolor="#FFFFFF">133,021 ns</td><td align="right" bgcolor="#FFFFFF">156,339 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FF4949">0,166 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleValidations"></a>GetBusinessRuleValidations

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 60,866 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">199,234 ns</td><td align="right" bgcolor="#FFFFFF">151,136 ns</td><td align="right" bgcolor="#FFFFFF">153,326 ns</td><td align="right" bgcolor="#FFFFFF">162,197 ns</td><td align="right" bgcolor="#FFFFFF">147,992 ns</td><td align="right" bgcolor="#FFFFFF">208,859 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,199 μs</td><td align="right" bgcolor="#FFFFFF">0,151 μs</td><td align="right" bgcolor="#FFFFFF">0,153 μs</td><td align="right" bgcolor="#FFFFFF">0,162 μs</td><td align="right" bgcolor="#FFFFFF">0,148 μs</td><td align="right" bgcolor="#FFFFFF">0,209 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#A8D08D">177,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#A8D08D">0,173 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarningCount"></a>GetBusinessRuleWarningCount

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 50,014 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">152,865 ns</td><td align="right" bgcolor="#FFFFFF">182,235 ns</td><td align="right" bgcolor="#FFFFFF">139,463 ns</td><td align="right" bgcolor="#FFFFFF">156,477 ns</td><td align="right" bgcolor="#FFFFFF">132,221 ns</td><td align="right" bgcolor="#FFFFFF">165,819 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,153 μs</td><td align="right" bgcolor="#FFFFFF">0,182 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FF4949">0,166 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarnings"></a>GetBusinessRuleWarnings

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 61,161 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">195,758 ns</td><td align="right" bgcolor="#FFFFFF">140,480 ns</td><td align="right" bgcolor="#FFFFFF">149,348 ns</td><td align="right" bgcolor="#FFFFFF">134,597 ns</td><td align="right" bgcolor="#FFFFFF">134,651 ns</td><td align="right" bgcolor="#FFFFFF">167,459 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FF4949">0,166 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrorCount"></a>GetErrorCount

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 140,832 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">805,765 ns</td><td align="right" bgcolor="#FFFFFF">754,666 ns</td><td align="right" bgcolor="#FFFFFF">711,916 ns</td><td align="right" bgcolor="#FFFFFF">702,529 ns</td><td align="right" bgcolor="#FFFFFF">843,361 ns</td><td align="right" bgcolor="#FFFFFF">781,259 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,806 μs</td><td align="right" bgcolor="#FFFFFF">0,755 μs</td><td align="right" bgcolor="#FFFFFF">0,712 μs</td><td align="right" bgcolor="#FFFFFF">0,703 μs</td><td align="right" bgcolor="#FFFFFF">0,843 μs</td><td align="right" bgcolor="#FFFFFF">0,781 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#A8D08D">514,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#A8D08D">0,502 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrors"></a>GetErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 269,847 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">809,963 ns</td><td align="right" bgcolor="#FFFFFF">929,167 ns</td><td align="right" bgcolor="#FFFFFF">688,028 ns</td><td align="right" bgcolor="#FFFFFF">681,678 ns</td><td align="right" bgcolor="#FFFFFF">659,320 ns</td><td align="right" bgcolor="#FFFFFF">759,776 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,810 μs</td><td align="right" bgcolor="#FFFFFF">0,929 μs</td><td align="right" bgcolor="#FFFFFF">0,688 μs</td><td align="right" bgcolor="#FFFFFF">0,682 μs</td><td align="right" bgcolor="#FFFFFF">0,659 μs</td><td align="right" bgcolor="#FFFFFF">0,760 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#A8D08D">514,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#A8D08D">0,502 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrorCount"></a>GetFieldErrorCount

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 45,632 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">197,168 ns</td><td align="right" bgcolor="#FFFFFF">166,354 ns</td><td align="right" bgcolor="#FFFFFF">204,912 ns</td><td align="right" bgcolor="#FFFFFF">177,750 ns</td><td align="right" bgcolor="#FFFFFF">159,280 ns</td><td align="right" bgcolor="#FFFFFF">180,115 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,178 μs</td><td align="right" bgcolor="#FFFFFF">0,159 μs</td><td align="right" bgcolor="#FFFFFF">0,180 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FF4949">0,166 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrors"></a>GetFieldErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 36,790 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">195,064 ns</td><td align="right" bgcolor="#FFFFFF">167,090 ns</td><td align="right" bgcolor="#FFFFFF">169,502 ns</td><td align="right" bgcolor="#FFFFFF">167,491 ns</td><td align="right" bgcolor="#FFFFFF">158,274 ns</td><td align="right" bgcolor="#FFFFFF">177,467 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#FFFFFF">0,170 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FF4949">0,166 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldValidations"></a>GetFieldValidations

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 49,579 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">212,957 ns</td><td align="right" bgcolor="#FFFFFF">185,152 ns</td><td align="right" bgcolor="#FFFFFF">183,678 ns</td><td align="right" bgcolor="#FFFFFF">176,911 ns</td><td align="right" bgcolor="#FFFFFF">226,491 ns</td><td align="right" bgcolor="#FFFFFF">192,277 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,185 μs</td><td align="right" bgcolor="#FFFFFF">0,184 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#A8D08D">177,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#A8D08D">0,173 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarningCount"></a>GetFieldWarningCount

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 34,688 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">179,517 ns</td><td align="right" bgcolor="#FFFFFF">175,350 ns</td><td align="right" bgcolor="#FFFFFF">148,475 ns</td><td align="right" bgcolor="#FFFFFF">146,363 ns</td><td align="right" bgcolor="#FFFFFF">144,829 ns</td><td align="right" bgcolor="#FFFFFF">160,403 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,180 μs</td><td align="right" bgcolor="#FFFFFF">0,175 μs</td><td align="right" bgcolor="#FFFFFF">0,148 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,160 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FF4949">0,166 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarnings"></a>GetFieldWarnings

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 34,497 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">176,611 ns</td><td align="right" bgcolor="#FFFFFF">149,291 ns</td><td align="right" bgcolor="#FFFFFF">146,481 ns</td><td align="right" bgcolor="#FFFFFF">143,319 ns</td><td align="right" bgcolor="#FFFFFF">142,114 ns</td><td align="right" bgcolor="#FFFFFF">164,083 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,164 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FF4949">0,166 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetValidations"></a>GetValidations

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 104,792 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">410,549 ns</td><td align="right" bgcolor="#FFFFFF">395,996 ns</td><td align="right" bgcolor="#FFFFFF">350,847 ns</td><td align="right" bgcolor="#FFFFFF">351,417 ns</td><td align="right" bgcolor="#FFFFFF">455,638 ns</td><td align="right" bgcolor="#FFFFFF">405,565 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,411 μs</td><td align="right" bgcolor="#FFFFFF">0,396 μs</td><td align="right" bgcolor="#FFFFFF">0,351 μs</td><td align="right" bgcolor="#FFFFFF">0,351 μs</td><td align="right" bgcolor="#FFFFFF">0,456 μs</td><td align="right" bgcolor="#FFFFFF">0,406 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#A8D08D">347,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#A8D08D">0,339 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarningCount"></a>GetWarningCount

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 480,285 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+78,7 %</td><td align="right" bgcolor="#A8D08D">-33,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">750,104 ns</td><td align="right" bgcolor="#FFFFFF">683,145 ns</td><td align="right" bgcolor="#FFFFFF">638,170 ns</td><td align="right" bgcolor="#FFFFFF">610,125 ns</td><td align="right" bgcolor="#FF4949">1090,410 ns (Δ = +480,285 ns)</td><td align="right" bgcolor="#A8D08D">727,248 ns (Δ = -363,162 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,750 μs</td><td align="right" bgcolor="#FFFFFF">0,683 μs</td><td align="right" bgcolor="#FFFFFF">0,638 μs</td><td align="right" bgcolor="#FFFFFF">0,610 μs</td><td align="right" bgcolor="#FFFFFF">1,090 μs</td><td align="right" bgcolor="#FFFFFF">0,727 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#A8D08D">514,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#A8D08D">0,502 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarnings"></a>GetWarnings

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 152,559 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">754,478 ns</td><td align="right" bgcolor="#FFFFFF">618,466 ns</td><td align="right" bgcolor="#FFFFFF">758,839 ns</td><td align="right" bgcolor="#FFFFFF">617,547 ns</td><td align="right" bgcolor="#FFFFFF">606,280 ns</td><td align="right" bgcolor="#FFFFFF">705,925 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,754 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,759 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,606 μs</td><td align="right" bgcolor="#FFFFFF">0,706 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#A8D08D">514,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#A8D08D">0,502 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 102,045 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">203,870 ns</td><td align="right" bgcolor="#FFFFFF">167,524 ns</td><td align="right" bgcolor="#FFFFFF">170,073 ns</td><td align="right" bgcolor="#FFFFFF">260,188 ns</td><td align="right" bgcolor="#FFFFFF">158,143 ns</td><td align="right" bgcolor="#FFFFFF">184,923 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,204 μs</td><td align="right" bgcolor="#FFFFFF">0,168 μs</td><td align="right" bgcolor="#FFFFFF">0,170 μs</td><td align="right" bgcolor="#FFFFFF">0,260 μs</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,185 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FF4949">0,166 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 33,868 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">177,145 ns</td><td align="right" bgcolor="#FFFFFF">145,691 ns</td><td align="right" bgcolor="#FFFFFF">169,438 ns</td><td align="right" bgcolor="#FFFFFF">154,715 ns</td><td align="right" bgcolor="#FFFFFF">143,278 ns</td><td align="right" bgcolor="#FFFFFF">163,496 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,169 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FF4949">0,166 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 69,354 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">234,713 ns</td><td align="right" bgcolor="#FFFFFF">195,207 ns</td><td align="right" bgcolor="#FFFFFF">194,698 ns</td><td align="right" bgcolor="#FFFFFF">261,128 ns</td><td align="right" bgcolor="#FFFFFF">191,773 ns</td><td align="right" bgcolor="#FFFFFF">212,981 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,235 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,261 μs</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">333,000</td><td align="right" bgcolor="#FFFFFF">333,000</td><td align="right" bgcolor="#FFFFFF">333,000</td><td align="right" bgcolor="#FFFFFF">333,000</td><td align="right" bgcolor="#FFFFFF">333,000</td><td align="right" bgcolor="#A8D08D">331,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,325</td><td align="right" bgcolor="#FFFFFF">0,325</td><td align="right" bgcolor="#FFFFFF">0,325</td><td align="right" bgcolor="#FFFFFF">0,325</td><td align="right" bgcolor="#FFFFFF">0,325</td><td align="right" bgcolor="#A8D08D">0,323 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


## <a name="ValidationSummary_Benchmark"></a>ValidationSummary_Benchmark

### <a name="ValidationSummary_Benchmark_BusinessRuleErrors"></a>BusinessRuleErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 1,943 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,817 ns</td><td align="right" bgcolor="#FFFFFF">5,097 ns</td><td align="right" bgcolor="#FFFFFF">5,051 ns</td><td align="right" bgcolor="#FFFFFF">4,918 ns</td><td align="right" bgcolor="#FFFFFF">4,874 ns</td><td align="right" bgcolor="#FFFFFF">5,904 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">33,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,032 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ValidationSummary_Benchmark_BusinessRuleWarnings"></a>BusinessRuleWarnings

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 4,903 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,460 ns</td><td align="right" bgcolor="#FFFFFF">5,137 ns</td><td align="right" bgcolor="#FFFFFF">4,917 ns</td><td align="right" bgcolor="#FFFFFF">4,889 ns</td><td align="right" bgcolor="#FFFFFF">5,011 ns</td><td align="right" bgcolor="#FFFFFF">9,792 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">33,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,032 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldErrors"></a>FieldErrors

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 2,624 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,589 ns</td><td align="right" bgcolor="#FFFFFF">4,964 ns</td><td align="right" bgcolor="#FFFFFF">5,100 ns</td><td align="right" bgcolor="#FFFFFF">5,039 ns</td><td align="right" bgcolor="#FFFFFF">4,996 ns</td><td align="right" bgcolor="#FFFFFF">5,923 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">33,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,032 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldWarnings"></a>FieldWarnings

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 1,247 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,203 ns</td><td align="right" bgcolor="#FFFFFF">4,956 ns</td><td align="right" bgcolor="#FFFFFF">4,990 ns</td><td align="right" bgcolor="#FFFFFF">5,077 ns</td><td align="right" bgcolor="#FFFFFF">5,164 ns</td><td align="right" bgcolor="#FFFFFF">5,936 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">33,000 (Δ = -3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,032 (Δ = -0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasBusinessRuleErrors"></a>HasBusinessRuleErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 0,396 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,120 ns</td><td align="right" bgcolor="#FFFFFF">0,213 ns</td><td align="right" bgcolor="#FFFFFF">0,156 ns</td><td align="right" bgcolor="#FFFFFF">0,063 ns</td><td align="right" bgcolor="#FFFFFF">0,033 ns</td><td align="right" bgcolor="#FFFFFF">0,429 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasBusinessRuleWarnings"></a>HasBusinessRuleWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 0,346 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,156 ns</td><td align="right" bgcolor="#FFFFFF">0,226 ns</td><td align="right" bgcolor="#FFFFFF">0,219 ns</td><td align="right" bgcolor="#FFFFFF">0,344 ns</td><td align="right" bgcolor="#FFFFFF">0,173 ns</td><td align="right" bgcolor="#FFFFFF">0,501 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 0,117 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,387 ns</td><td align="right" bgcolor="#FFFFFF">0,385 ns</td><td align="right" bgcolor="#FFFFFF">0,430 ns</td><td align="right" bgcolor="#FFFFFF">0,388 ns</td><td align="right" bgcolor="#FFFFFF">0,314 ns</td><td align="right" bgcolor="#FFFFFF">0,325 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldErrors"></a>HasFieldErrors

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 0,906 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,104 ns</td><td align="right" bgcolor="#FFFFFF">0,238 ns</td><td align="right" bgcolor="#FFFFFF">0,213 ns</td><td align="right" bgcolor="#FFFFFF">0,076 ns</td><td align="right" bgcolor="#FFFFFF">0,113 ns</td><td align="right" bgcolor="#FFFFFF">0,981 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldWarnings"></a>HasFieldWarnings

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 0,381 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,092 ns</td><td align="right" bgcolor="#FFFFFF">0,221 ns</td><td align="right" bgcolor="#FFFFFF">0,165 ns</td><td align="right" bgcolor="#FFFFFF">0,041 ns</td><td align="right" bgcolor="#FFFFFF">0,299 ns</td><td align="right" bgcolor="#FFFFFF">0,421 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 0,227 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,595 ns</td><td align="right" bgcolor="#FFFFFF">0,383 ns</td><td align="right" bgcolor="#FFFFFF">0,368 ns</td><td align="right" bgcolor="#FFFFFF">0,387 ns</td><td align="right" bgcolor="#FFFFFF">0,456 ns</td><td align="right" bgcolor="#FFFFFF">0,389 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 210,731 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">871,052 ns</td><td align="right" bgcolor="#FFFFFF">726,148 ns</td><td align="right" bgcolor="#FFFFFF">682,587 ns</td><td align="right" bgcolor="#FFFFFF">674,541 ns</td><td align="right" bgcolor="#FFFFFF">660,321 ns</td><td align="right" bgcolor="#FFFFFF">719,275 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,871 μs</td><td align="right" bgcolor="#FFFFFF">0,726 μs</td><td align="right" bgcolor="#FFFFFF">0,683 μs</td><td align="right" bgcolor="#FFFFFF">0,675 μs</td><td align="right" bgcolor="#FFFFFF">0,660 μs</td><td align="right" bgcolor="#FFFFFF">0,719 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#A8D08D">741,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#A8D08D">0,724 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 8116,964 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,7 %</td><td align="right" bgcolor="#FF4949">+47,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15511,589 ns</td><td align="right" bgcolor="#A8D08D">13383,825 ns (Δ = -2127,764 ns)</td><td align="right" bgcolor="#FFFFFF">13569,467 ns</td><td align="right" bgcolor="#FFFFFF">13809,995 ns</td><td align="right" bgcolor="#FF4949">14600,266 ns (Δ = +790,272 ns)</td><td align="right" bgcolor="#FF4949">21500,789 ns (Δ = +6900,523 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">15,512 μs</td><td align="right" bgcolor="#FFFFFF">13,384 μs</td><td align="right" bgcolor="#FFFFFF">13,569 μs</td><td align="right" bgcolor="#FFFFFF">13,810 μs</td><td align="right" bgcolor="#FFFFFF">14,600 μs</td><td align="right" bgcolor="#FFFFFF">21,501 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,022 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.12</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#FF4949">+20,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">5723,000</td><td align="right" bgcolor="#FF4949">6062,000 (Δ = +339,000)</td><td align="right" bgcolor="#FFFFFF">6062,000</td><td align="right" bgcolor="#FFFFFF">6062,000</td><td align="right" bgcolor="#FF4949">6293,000 (Δ = +231,000)</td><td align="right" bgcolor="#FF4949">7588,000 (Δ = +1295,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">5,589</td><td align="right" bgcolor="#FF4949">5,920 (Δ = +0,331)</td><td align="right" bgcolor="#FFFFFF">5,920</td><td align="right" bgcolor="#FFFFFF">5,920</td><td align="right" bgcolor="#FF4949">6,146 (Δ = +0,226)</td><td align="right" bgcolor="#FF4949">7,410 (Δ = +1,265)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,005</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,007 (Δ = +0,001)</td></tr></table>


### <a name="ViewModelBase_Benchmark_ModelPropertyMappings"></a>ModelPropertyMappings

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 18898,528 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,4 %</td><td align="right" bgcolor="#FF4949">+13,5 %</td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#A8D08D">-37,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31577,574 ns</td><td align="right" bgcolor="#FF4949">42439,390 ns (Δ = +10861,816 ns)</td><td align="right" bgcolor="#FF4949">48177,013 ns (Δ = +5737,623 ns)</td><td align="right" bgcolor="#A8D08D">46716,631 ns (Δ = -1460,382 ns)</td><td align="right" bgcolor="#A8D08D">29278,485 ns (Δ = -17438,146 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">31,578 μs</td><td align="right" bgcolor="#FFFFFF">42,439 μs</td><td align="right" bgcolor="#FFFFFF">48,177 μs</td><td align="right" bgcolor="#FFFFFF">46,717 μs</td><td align="right" bgcolor="#FFFFFF">29,278 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,032 ms</td><td align="right" bgcolor="#FFFFFF">0,042 ms</td><td align="right" bgcolor="#FFFFFF">0,048 ms</td><td align="right" bgcolor="#FFFFFF">0,047 ms</td><td align="right" bgcolor="#FFFFFF">0,029 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9</td><td align="right">5.4</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.4</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FF4949">16,000 (Δ = +4,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#A8D08D">8,000 (Δ = -8,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+29,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">16787,000</td><td align="right" bgcolor="#FF4949">21678,000 (Δ = +4891,000)</td><td align="right" bgcolor="#FFFFFF">21678,000</td><td align="right" bgcolor="#FFFFFF">21678,000</td><td align="right" bgcolor="#A8D08D">11444,000 (Δ = -10234,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">16,394</td><td align="right" bgcolor="#FF4949">21,170 (Δ = +4,776)</td><td align="right" bgcolor="#FFFFFF">21,170</td><td align="right" bgcolor="#FFFFFF">21,170</td><td align="right" bgcolor="#A8D08D">11,176 (Δ = -9,994)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FF4949">0,021 (Δ = +0,005)</td><td align="right" bgcolor="#FFFFFF">0,021</td><td align="right" bgcolor="#FFFFFF">0,021</td><td align="right" bgcolor="#A8D08D">0,011 (Δ = -0,010)</td></tr></table>


