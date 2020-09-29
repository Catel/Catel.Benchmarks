# Benchmarks

Benchmark report generated on 29-sep-2020 17:05

Running the benchmarks took 01:14:18.2772016

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

1. [ModelBase_SetValue_Benchmark::SetStringValue](#ModelBase_SetValue_Benchmark_SetStringValue) v6.0.0 is **94,34%** (Δ: 350,271 ns) slower than v5.12.0

2. [TypeFactory_Benchmark::CreateInstance](#TypeFactory_Benchmark_CreateInstance) v6.0.0 is **77,67%** (Δ: 1233,828 ns) slower than v5.12.0

3. [Type_ReflectionExtensions_Benchmark::GetCustomAttributesEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit) v6.0.0 is **71,05%** (Δ: 1749,083 ns) slower than v5.12.0

4. [Type_ReflectionExtensions_Benchmark::GetEventEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags) v6.0.0 is **70,24%** (Δ: 1230,303 ns) slower than v5.12.0

5. [Type_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v6.0.0 is **62,02%** (Δ: 833,532 ns) slower than v5.12.0

6. [Type_ReflectionExtensions_Benchmark::IsInstanceOfTypeEx](#Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx) v6.0.0 is **57,38%** (Δ: 6456,354 ns) slower than v5.12.0

7. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Instance](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance) v6.0.0 is **56,78%** (Δ: 2105,280 ns) slower than v5.12.0

8. [Type_ReflectionExtensions_Benchmark::GetPropertyEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags) v6.0.0 is **42,17%** (Δ: 726,187 ns) slower than v5.12.0

9. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static) v6.0.0 is **41,98%** (Δ: 1533,523 ns) slower than v5.12.0

10. [ValidatableModelBase_Constructor_Benchmark::Constructor](#ValidatableModelBase_Constructor_Benchmark_Constructor) v6.0.0 is **39,76%** (Δ: 1007,666 ns) slower than v5.12.0

11. [ModelBase_Constructor_Benchmark::Constructor](#ModelBase_Constructor_Benchmark_Constructor) v6.0.0 is **37,17%** (Δ: 932,567 ns) slower than v5.12.0

12. [Log_Warning_Benchmark::Log_Warning_Format_7_Format_Arguments](#Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments) v6.0.0 is **37,10%** (Δ: 361,365 ns) slower than v5.12.0

13. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Instance_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags) v6.0.0 is **32,99%** (Δ: 324,347 ns) slower than v5.12.0

14. [Type_ReflectionExtensions_Benchmark::GetPropertiesEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static) v6.0.0 is **32,49%** (Δ: 284,342 ns) slower than v5.12.0

15. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Flatten_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags) v6.0.0 is **28,82%** (Δ: 282,754 ns) slower than v5.12.0

16. [Serialization_Json_Benchmark::SerializeLevel1Models](#Serialization_Json_Benchmark_SerializeLevel1Models) v6.0.0 is **21,50%** (Δ: 62065,260 ns) slower than v5.12.0

17. [Enum_Benchmark::ToList](#Enum_Benchmark_ToList) v6.0.0 is **19,70%** (Δ: 458,328 ns) slower than v5.12.0

18. [ViewModelBase_Benchmark::ModelPropertyMappings](#ViewModelBase_Benchmark_ModelPropertyMappings) v6.0.0 is **16,30%** (Δ: 4293,173 ns) slower than v5.12.0

19. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_100](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100) v6.0.0 is **16,13%** (Δ: 19116,865 ns) slower than v5.12.0

20. [Type_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v6.0.0 is **11,97%** (Δ: 287,946 ns) slower than v5.12.0

21. [Serialization_Xml_Benchmark::SerializeComplexObjectGraph](#Serialization_Xml_Benchmark_SerializeComplexObjectGraph) v6.0.0 is **7,97%** (Δ: 17775,355 ns) slower than v5.12.0

22. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_500](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500) v6.0.0 is **5,67%** (Δ: 5553,291 ns) slower than v5.12.0

23. [ViewModelBase_Benchmark::Construction](#ViewModelBase_Benchmark_Construction) v6.0.0 is **3,97%** (Δ: 439,505 ns) slower than v5.12.0

24. [Serialization_Json_Benchmark::SerializeComplexObjectGraph](#Serialization_Json_Benchmark_SerializeComplexObjectGraph) v6.0.0 is **1,90%** (Δ: 155488,525 ns) slower than v5.12.0

25. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_1000](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000) v6.0.0 is **1,30%** (Δ: 1331,148 ns) slower than v5.12.0

Skipping 1 items since maximum list length is 25


### Improved (current version faster than previous one)

14 item(s)

1. [Serialization_Binary_Benchmark::SerializeLevel1Models](#Serialization_Binary_Benchmark_SerializeLevel1Models) v5.12.0 is **83,76%** (Δ: -198197,817 ns) faster than v5.9.0

2. [Serialization_Binary_Benchmark::SerializeLevel2Models](#Serialization_Binary_Benchmark_SerializeLevel2Models) v5.12.0 is **68,10%** (Δ: -227563,037 ns) faster than v5.9.0

3. [Serialization_Binary_Benchmark::SerializeComplexObjectGraph](#Serialization_Binary_Benchmark_SerializeComplexObjectGraph) v5.12.0 is **62,68%** (Δ: -259632,935 ns) faster than v5.9.0

4. [Serialization_Binary_Benchmark::SerializeLevel3Models](#Serialization_Binary_Benchmark_SerializeLevel3Models) v5.12.0 is **38,28%** (Δ: -319639,681 ns) faster than v5.9.0

5. [Serialization_Xml_Benchmark::SerializeLevel1Models](#Serialization_Xml_Benchmark_SerializeLevel1Models) v6.0.0 is **23,44%** (Δ: -8582,959 ns) faster than v5.12.0

6. [ExpressionHelper_Benchmark::GetPropertyName](#ExpressionHelper_Benchmark_GetPropertyName) v6.0.0 is **18,37%** (Δ: -828,686 ns) faster than v5.12.0

7. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType) v6.0.0 is **17,67%** (Δ: -316,827 ns) faster than v5.12.0

8. [ExpressionHelper_Benchmark::GetOwner](#ExpressionHelper_Benchmark_GetOwner) v6.0.0 is **15,45%** (Δ: -300,551 ns) faster than v5.12.0

9. [AssemblyExtensions_Benchmark::Title](#AssemblyExtensions_Benchmark_Title) v6.0.0 is **9,15%** (Δ: -354,785 ns) faster than v5.12.0

10. [Serialization_Json_Benchmark::SerializeLevel2Models](#Serialization_Json_Benchmark_SerializeLevel2Models) v6.0.0 is **8,60%** (Δ: -106933,850 ns) faster than v5.12.0

11. [Serialization_Json_Benchmark::SerializeLevel3Models](#Serialization_Json_Benchmark_SerializeLevel3Models) v6.0.0 is **8,54%** (Δ: -517071,346 ns) faster than v5.12.0

12. [Serialization_Xml_Benchmark::SerializeLevel3Models](#Serialization_Xml_Benchmark_SerializeLevel3Models) v6.0.0 is **7,09%** (Δ: -35858,028 ns) faster than v5.12.0

13. [Serialization_Xml_Benchmark::SerializeLevel2Models](#Serialization_Xml_Benchmark_SerializeLevel2Models) v6.0.0 is **6,37%** (Δ: -7036,500 ns) faster than v5.12.0

14. [Assembly_ReflectionExtensions_Benchmark::GetExportedTypesEx](#Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx) v6.0.0 is **3,74%** (Δ: -575,328 ns) faster than v5.12.0



## <a name="Argument_Benchmark"></a>Argument_Benchmark

### <a name="Argument_Benchmark_ImplementsInterface"></a>ImplementsInterface

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 196,303 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">93,914 ns</td><td align="right" bgcolor="#FFFFFF">93,125 ns</td><td align="right" bgcolor="#FFFFFF">73,047 ns</td><td align="right" bgcolor="#FFFFFF">70,520 ns</td><td align="right" bgcolor="#FFFFFF">71,502 ns</td><td align="right" bgcolor="#FFFFFF">266,823 ns</td><td align="right" bgcolor="#FFFFFF">254,120 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,267 μs</td><td align="right" bgcolor="#FFFFFF">0,254 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 233,459 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">83,369 ns</td><td align="right" bgcolor="#FFFFFF">85,912 ns</td><td align="right" bgcolor="#FFFFFF">69,300 ns</td><td align="right" bgcolor="#FFFFFF">69,184 ns</td><td align="right" bgcolor="#FFFFFF">75,755 ns</td><td align="right" bgcolor="#FFFFFF">302,643 ns</td><td align="right" bgcolor="#FFFFFF">287,088 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,303 μs</td><td align="right" bgcolor="#FFFFFF">0,287 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 200,266 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">82,354 ns</td><td align="right" bgcolor="#FFFFFF">77,230 ns</td><td align="right" bgcolor="#FFFFFF">70,813 ns</td><td align="right" bgcolor="#FFFFFF">66,674 ns</td><td align="right" bgcolor="#FFFFFF">73,342 ns</td><td align="right" bgcolor="#FFFFFF">266,940 ns</td><td align="right" bgcolor="#FFFFFF">252,213 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,267 μs</td><td align="right" bgcolor="#FFFFFF">0,252 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 200,021 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">87,453 ns</td><td align="right" bgcolor="#FFFFFF">71,655 ns</td><td align="right" bgcolor="#FFFFFF">78,904 ns</td><td align="right" bgcolor="#FFFFFF">78,254 ns</td><td align="right" bgcolor="#FFFFFF">73,796 ns</td><td align="right" bgcolor="#FFFFFF">271,676 ns</td><td align="right" bgcolor="#FFFFFF">267,956 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td><td align="right" bgcolor="#FFFFFF">0,268 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 71,338 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31,464 ns</td><td align="right" bgcolor="#FFFFFF">26,355 ns</td><td align="right" bgcolor="#FFFFFF">37,851 ns</td><td align="right" bgcolor="#FFFFFF">25,975 ns</td><td align="right" bgcolor="#FFFFFF">30,513 ns</td><td align="right" bgcolor="#FFFFFF">97,313 ns</td><td align="right" bgcolor="#FFFFFF">75,238 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Generic"></a>InheritsFrom_Generic

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 76,941 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">36,764 ns</td><td align="right" bgcolor="#FFFFFF">29,546 ns</td><td align="right" bgcolor="#FFFFFF">34,333 ns</td><td align="right" bgcolor="#FFFFFF">32,057 ns</td><td align="right" bgcolor="#FFFFFF">34,486 ns</td><td align="right" bgcolor="#FFFFFF">106,488 ns</td><td align="right" bgcolor="#FFFFFF">97,388 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Object"></a>InheritsFrom_Object

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 78,478 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">40,109 ns</td><td align="right" bgcolor="#FFFFFF">30,247 ns</td><td align="right" bgcolor="#FFFFFF">32,132 ns</td><td align="right" bgcolor="#FFFFFF">32,747 ns</td><td align="right" bgcolor="#FFFFFF">35,586 ns</td><td align="right" bgcolor="#FFFFFF">95,613 ns</td><td align="right" bgcolor="#FFFFFF">108,725 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsMatch"></a>IsMatch

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 158,333 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">584,446 ns</td><td align="right" bgcolor="#FFFFFF">584,680 ns</td><td align="right" bgcolor="#FFFFFF">567,531 ns</td><td align="right" bgcolor="#FFFFFF">561,863 ns</td><td align="right" bgcolor="#FFFFFF">578,658 ns</td><td align="right" bgcolor="#FFFFFF">426,347 ns</td><td align="right" bgcolor="#FFFFFF">443,675 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,584 μs</td><td align="right" bgcolor="#FFFFFF">0,585 μs</td><td align="right" bgcolor="#FFFFFF">0,568 μs</td><td align="right" bgcolor="#FFFFFF">0,562 μs</td><td align="right" bgcolor="#FFFFFF">0,579 μs</td><td align="right" bgcolor="#FFFFFF">0,426 μs</td><td align="right" bgcolor="#FFFFFF">0,444 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-67,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#A8D08D">104,000 (Δ = -219,000)</td><td align="right" bgcolor="#FFFFFF">104,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#A8D08D">0,102 (Δ = -0,214)</td><td align="right" bgcolor="#FFFFFF">0,102</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsMaximum"></a>IsMaximum

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 17,644 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,151 ns</td><td align="right" bgcolor="#FFFFFF">9,472 ns</td><td align="right" bgcolor="#FFFFFF">10,217 ns</td><td align="right" bgcolor="#FFFFFF">10,196 ns</td><td align="right" bgcolor="#FFFFFF">10,575 ns</td><td align="right" bgcolor="#FFFFFF">27,116 ns</td><td align="right" bgcolor="#FFFFFF">10,250 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,7 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#A8D08D">24,000 (Δ = -2,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#A8D08D">0,023 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 20,463 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,582 ns</td><td align="right" bgcolor="#FFFFFF">11,000 ns</td><td align="right" bgcolor="#FFFFFF">15,991 ns</td><td align="right" bgcolor="#FFFFFF">11,776 ns</td><td align="right" bgcolor="#FFFFFF">11,164 ns</td><td align="right" bgcolor="#FFFFFF">31,463 ns</td><td align="right" bgcolor="#FFFFFF">14,709 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,7 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#A8D08D">24,000 (Δ = -2,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#A8D08D">0,023 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 7,116 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,526 ns</td><td align="right" bgcolor="#FFFFFF">3,015 ns</td><td align="right" bgcolor="#FFFFFF">3,273 ns</td><td align="right" bgcolor="#FFFFFF">3,140 ns</td><td align="right" bgcolor="#FFFFFF">3,675 ns</td><td align="right" bgcolor="#FFFFFF">10,131 ns</td><td align="right" bgcolor="#FFFFFF">9,142 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotMatch"></a>IsNotMatch

#### Performance

Fastest: **6.0.0**

Slowest: 5.4.0

Δ: 184,889 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">484,907 ns</td><td align="right" bgcolor="#FFFFFF">487,439 ns</td><td align="right" bgcolor="#FFFFFF">454,836 ns</td><td align="right" bgcolor="#FFFFFF">443,010 ns</td><td align="right" bgcolor="#FFFFFF">463,642 ns</td><td align="right" bgcolor="#FFFFFF">320,281 ns</td><td align="right" bgcolor="#FFFFFF">302,550 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,485 μs</td><td align="right" bgcolor="#FFFFFF">0,487 μs</td><td align="right" bgcolor="#FFFFFF">0,455 μs</td><td align="right" bgcolor="#FFFFFF">0,443 μs</td><td align="right" bgcolor="#FFFFFF">0,464 μs</td><td align="right" bgcolor="#FFFFFF">0,320 μs</td><td align="right" bgcolor="#FFFFFF">0,303 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-67,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#A8D08D">104,000 (Δ = -219,000)</td><td align="right" bgcolor="#FFFFFF">104,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#A8D08D">0,102 (Δ = -0,214)</td><td align="right" bgcolor="#FFFFFF">0,102</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotNull"></a>IsNotNull

#### Performance

Fastest: **5.6.0**

Slowest: 6.0.0

Δ: 5,232 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,306 ns</td><td align="right" bgcolor="#FFFFFF">1,382 ns</td><td align="right" bgcolor="#FFFFFF">1,429 ns</td><td align="right" bgcolor="#FFFFFF">0,952 ns</td><td align="right" bgcolor="#FFFFFF">1,150 ns</td><td align="right" bgcolor="#FFFFFF">5,852 ns</td><td align="right" bgcolor="#FFFFFF">6,184 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **5.0.0**

Slowest: 6.0.0

Δ: 7,230 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,025 ns</td><td align="right" bgcolor="#FFFFFF">1,443 ns</td><td align="right" bgcolor="#FFFFFF">1,492 ns</td><td align="right" bgcolor="#FFFFFF">1,238 ns</td><td align="right" bgcolor="#FFFFFF">1,032 ns</td><td align="right" bgcolor="#FFFFFF">7,417 ns</td><td align="right" bgcolor="#FFFFFF">8,255 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty_Guid"></a>IsNotNullOrEmpty_Guid

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 5,992 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,910 ns</td><td align="right" bgcolor="#FFFFFF">7,315 ns</td><td align="right" bgcolor="#FFFFFF">8,068 ns</td><td align="right" bgcolor="#FFFFFF">7,893 ns</td><td align="right" bgcolor="#FFFFFF">7,949 ns</td><td align="right" bgcolor="#FFFFFF">13,307 ns</td><td align="right" bgcolor="#FFFFFF">12,417 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmptyArray"></a>IsNotNullOrEmptyArray

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 5,485 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,766 ns</td><td align="right" bgcolor="#FFFFFF">2,637 ns</td><td align="right" bgcolor="#FFFFFF">2,658 ns</td><td align="right" bgcolor="#FFFFFF">3,664 ns</td><td align="right" bgcolor="#FFFFFF">2,342 ns</td><td align="right" bgcolor="#FFFFFF">7,826 ns</td><td align="right" bgcolor="#FFFFFF">7,826 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrWhitespace"></a>IsNotNullOrWhitespace

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 8,391 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,994 ns</td><td align="right" bgcolor="#FFFFFF">8,622 ns</td><td align="right" bgcolor="#FFFFFF">8,834 ns</td><td align="right" bgcolor="#FFFFFF">10,441 ns</td><td align="right" bgcolor="#FFFFFF">4,123 ns</td><td align="right" bgcolor="#FFFFFF">12,242 ns</td><td align="right" bgcolor="#FFFFFF">12,514 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes"></a>IsNotOfOneOfTheTypes

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 93,631 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">62,047 ns</td><td align="right" bgcolor="#FFFFFF">60,536 ns</td><td align="right" bgcolor="#FFFFFF">56,516 ns</td><td align="right" bgcolor="#FFFFFF">55,607 ns</td><td align="right" bgcolor="#FFFFFF">64,772 ns</td><td align="right" bgcolor="#FFFFFF">149,238 ns</td><td align="right" bgcolor="#FFFFFF">131,663 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes_Object"></a>IsNotOfOneOfTheTypes_Object

#### Performance

Fastest: **5.6.0**

Slowest: 6.0.0

Δ: 110,907 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">65,235 ns</td><td align="right" bgcolor="#FFFFFF">86,035 ns</td><td align="right" bgcolor="#FFFFFF">59,703 ns</td><td align="right" bgcolor="#FFFFFF">58,206 ns</td><td align="right" bgcolor="#FFFFFF">63,098 ns</td><td align="right" bgcolor="#FFFFFF">165,000 ns</td><td align="right" bgcolor="#FFFFFF">169,113 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,060 μs</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,165 μs</td><td align="right" bgcolor="#FFFFFF">0,169 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType"></a>IsNotOfType

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 90,154 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">43,765 ns</td><td align="right" bgcolor="#FFFFFF">36,183 ns</td><td align="right" bgcolor="#FFFFFF">39,868 ns</td><td align="right" bgcolor="#FFFFFF">38,292 ns</td><td align="right" bgcolor="#FFFFFF">38,266 ns</td><td align="right" bgcolor="#FFFFFF">125,475 ns</td><td align="right" bgcolor="#FFFFFF">126,338 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType_Object"></a>IsNotOfType_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 88,498 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">52,483 ns</td><td align="right" bgcolor="#FFFFFF">42,389 ns</td><td align="right" bgcolor="#FFFFFF">47,936 ns</td><td align="right" bgcolor="#FFFFFF">42,513 ns</td><td align="right" bgcolor="#FFFFFF">45,591 ns</td><td align="right" bgcolor="#FFFFFF">130,886 ns</td><td align="right" bgcolor="#FFFFFF">130,600 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOutOfRange"></a>IsNotOutOfRange

#### Performance

Fastest: **6.0.0**

Slowest: 5.12.0

Δ: 27,494 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,451 ns</td><td align="right" bgcolor="#FFFFFF">17,592 ns</td><td align="right" bgcolor="#FFFFFF">16,707 ns</td><td align="right" bgcolor="#FFFFFF">16,283 ns</td><td align="right" bgcolor="#FFFFFF">17,172 ns</td><td align="right" bgcolor="#FFFFFF">43,239 ns</td><td align="right" bgcolor="#FFFFFF">15,745 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,9 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">51,000</td><td align="right" bgcolor="#FFFFFF">51,000</td><td align="right" bgcolor="#FFFFFF">51,000</td><td align="right" bgcolor="#FFFFFF">51,000</td><td align="right" bgcolor="#FFFFFF">51,000</td><td align="right" bgcolor="#A8D08D">48,000 (Δ = -3,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -48,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,050</td><td align="right" bgcolor="#FFFFFF">0,050</td><td align="right" bgcolor="#FFFFFF">0,050</td><td align="right" bgcolor="#FFFFFF">0,050</td><td align="right" bgcolor="#FFFFFF">0,050</td><td align="right" bgcolor="#A8D08D">0,047 (Δ = -0,003)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,047)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes"></a>IsOfOneOfTheTypes

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 78,279 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">44,464 ns</td><td align="right" bgcolor="#FFFFFF">38,834 ns</td><td align="right" bgcolor="#FFFFFF">43,599 ns</td><td align="right" bgcolor="#FFFFFF">39,201 ns</td><td align="right" bgcolor="#FFFFFF">41,266 ns</td><td align="right" bgcolor="#FFFFFF">117,113 ns</td><td align="right" bgcolor="#FFFFFF">102,888 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,117 μs</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfOneOfTheTypes_Object"></a>IsOfOneOfTheTypes_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 105,093 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">48,854 ns</td><td align="right" bgcolor="#FFFFFF">44,294 ns</td><td align="right" bgcolor="#FFFFFF">60,884 ns</td><td align="right" bgcolor="#FFFFFF">46,776 ns</td><td align="right" bgcolor="#FFFFFF">48,712 ns</td><td align="right" bgcolor="#FFFFFF">149,388 ns</td><td align="right" bgcolor="#FFFFFF">109,350 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType"></a>IsOfType

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 71,217 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,572 ns</td><td align="right" bgcolor="#FFFFFF">26,770 ns</td><td align="right" bgcolor="#FFFFFF">27,365 ns</td><td align="right" bgcolor="#FFFFFF">26,933 ns</td><td align="right" bgcolor="#FFFFFF">27,423 ns</td><td align="right" bgcolor="#FFFFFF">97,988 ns</td><td align="right" bgcolor="#FFFFFF">77,150 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType_Object"></a>IsOfType_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 80,343 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35,296 ns</td><td align="right" bgcolor="#FFFFFF">33,632 ns</td><td align="right" bgcolor="#FFFFFF">33,984 ns</td><td align="right" bgcolor="#FFFFFF">34,181 ns</td><td align="right" bgcolor="#FFFFFF">33,851 ns</td><td align="right" bgcolor="#FFFFFF">113,975 ns</td><td align="right" bgcolor="#FFFFFF">81,523 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="Assembly_ReflectionExtensions_Benchmark"></a>Assembly_ReflectionExtensions_Benchmark

### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 2433,912 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-34,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5133,303 ns</td><td align="right" bgcolor="#A8D08D">4230,198 ns (Δ = -903,104 ns)</td><td align="right" bgcolor="#FFFFFF">4132,635 ns</td><td align="right" bgcolor="#FFFFFF">4178,021 ns</td><td align="right" bgcolor="#FFFFFF">4126,921 ns</td><td align="right" bgcolor="#A8D08D">2699,390 ns (Δ = -1427,530 ns)</td><td align="right" bgcolor="#FFFFFF">2743,828 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,133 μs</td><td align="right" bgcolor="#FFFFFF">4,230 μs</td><td align="right" bgcolor="#FFFFFF">4,133 μs</td><td align="right" bgcolor="#FFFFFF">4,178 μs</td><td align="right" bgcolor="#FFFFFF">4,127 μs</td><td align="right" bgcolor="#FFFFFF">2,699 μs</td><td align="right" bgcolor="#FFFFFF">2,744 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#A8D08D">544,000 (Δ = -188,000)</td><td align="right" bgcolor="#FFFFFF">544,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#A8D08D">0,531 (Δ = -0,184)</td><td align="right" bgcolor="#FFFFFF">0,531</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 2197,072 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4895,273 ns</td><td align="right" bgcolor="#A8D08D">4144,588 ns (Δ = -750,685 ns)</td><td align="right" bgcolor="#FFFFFF">4076,323 ns</td><td align="right" bgcolor="#FFFFFF">4148,356 ns</td><td align="right" bgcolor="#FFFFFF">4045,740 ns</td><td align="right" bgcolor="#A8D08D">2698,201 ns (Δ = -1347,538 ns)</td><td align="right" bgcolor="#FFFFFF">2908,953 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,895 μs</td><td align="right" bgcolor="#FFFFFF">4,145 μs</td><td align="right" bgcolor="#FFFFFF">4,076 μs</td><td align="right" bgcolor="#FFFFFF">4,148 μs</td><td align="right" bgcolor="#FFFFFF">4,046 μs</td><td align="right" bgcolor="#FFFFFF">2,698 μs</td><td align="right" bgcolor="#FFFFFF">2,909 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#FFFFFF">732,000</td><td align="right" bgcolor="#A8D08D">544,000 (Δ = -188,000)</td><td align="right" bgcolor="#FFFFFF">544,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#FFFFFF">0,715</td><td align="right" bgcolor="#A8D08D">0,531 (Δ = -0,184)</td><td align="right" bgcolor="#FFFFFF">0,531</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 5545,143 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,7 %</td><td align="right" bgcolor="#A8D08D">-19,1 %</td><td align="right" bgcolor="#FF4949">+56,3 %</td><td align="right" bgcolor="#A8D08D">-3,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12086,715 ns</td><td align="right" bgcolor="#A8D08D">10520,181 ns (Δ = -1566,534 ns)</td><td align="right" bgcolor="#FFFFFF">10520,448 ns</td><td align="right" bgcolor="#FF4949">12175,267 ns (Δ = +1654,819 ns)</td><td align="right" bgcolor="#A8D08D">9846,649 ns (Δ = -2328,618 ns)</td><td align="right" bgcolor="#FF4949">15391,792 ns (Δ = +5545,143 ns)</td><td align="right" bgcolor="#A8D08D">14816,463 ns (Δ = -575,328 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">12,087 μs</td><td align="right" bgcolor="#FFFFFF">10,520 μs</td><td align="right" bgcolor="#FFFFFF">10,520 μs</td><td align="right" bgcolor="#FFFFFF">12,175 μs</td><td align="right" bgcolor="#FFFFFF">9,847 μs</td><td align="right" bgcolor="#FFFFFF">15,392 μs</td><td align="right" bgcolor="#FFFFFF">14,816 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#A8D08D">-0,4 %</td><td align="right" bgcolor="#A8D08D">-0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1414,000</td><td align="right" bgcolor="#FFFFFF">1414,000</td><td align="right" bgcolor="#FFFFFF">1414,000</td><td align="right" bgcolor="#FFFFFF">1414,000</td><td align="right" bgcolor="#A8D08D">1413,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">1408,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">1400,000 (Δ = -8,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,381</td><td align="right" bgcolor="#FFFFFF">1,381</td><td align="right" bgcolor="#FFFFFF">1,381</td><td align="right" bgcolor="#FFFFFF">1,381</td><td align="right" bgcolor="#A8D08D">1,380 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">1,375 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">1,367 (Δ = -0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 2724,465 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,4 %</td><td align="right" bgcolor="#FF4949">+7,8 %</td><td align="right" bgcolor="#FF4949">+8,8 %</td><td align="right" bgcolor="#A8D08D">-16,6 %</td><td align="right" bgcolor="#A8D08D">-27,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5864,408 ns</td><td align="right" bgcolor="#A8D08D">4433,528 ns (Δ = -1430,880 ns)</td><td align="right" bgcolor="#FF4949">4777,780 ns (Δ = +344,253 ns)</td><td align="right" bgcolor="#FF4949">5196,656 ns (Δ = +418,875 ns)</td><td align="right" bgcolor="#A8D08D">4332,326 ns (Δ = -864,330 ns)</td><td align="right" bgcolor="#A8D08D">3139,943 ns (Δ = -1192,382 ns)</td><td align="right" bgcolor="#FFFFFF">3177,203 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,864 μs</td><td align="right" bgcolor="#FFFFFF">4,434 μs</td><td align="right" bgcolor="#FFFFFF">4,778 μs</td><td align="right" bgcolor="#FFFFFF">5,197 μs</td><td align="right" bgcolor="#FFFFFF">4,332 μs</td><td align="right" bgcolor="#FFFFFF">3,140 μs</td><td align="right" bgcolor="#FFFFFF">3,177 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-50,2 %</td><td align="right" bgcolor="#A8D08D">-0,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3115,000</td><td align="right" bgcolor="#FFFFFF">3115,000</td><td align="right" bgcolor="#FFFFFF">3115,000</td><td align="right" bgcolor="#FFFFFF">3115,000</td><td align="right" bgcolor="#A8D08D">3114,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">1552,000 (Δ = -1562,000)</td><td align="right" bgcolor="#A8D08D">1544,000 (Δ = -8,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,042</td><td align="right" bgcolor="#FFFFFF">3,042</td><td align="right" bgcolor="#FFFFFF">3,042</td><td align="right" bgcolor="#FFFFFF">3,042</td><td align="right" bgcolor="#A8D08D">3,041 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">1,516 (Δ = -1,525)</td><td align="right" bgcolor="#A8D08D">1,508 (Δ = -0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


## <a name="AssemblyExtensions_Benchmark"></a>AssemblyExtensions_Benchmark

### <a name="AssemblyExtensions_Benchmark_Company"></a>Company

#### Performance

Fastest: **6.0.0**

Slowest: 5.6.0

Δ: 3023,898 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,9 %</td><td align="right" bgcolor="#A8D08D">-24,4 %</td><td align="right" bgcolor="#A8D08D">-28,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5550,245 ns</td><td align="right" bgcolor="#A8D08D">4900,317 ns (Δ = -649,928 ns)</td><td align="right" bgcolor="#FFFFFF">4889,294 ns</td><td align="right" bgcolor="#FF4949">6499,404 ns (Δ = +1610,110 ns)</td><td align="right" bgcolor="#A8D08D">4914,491 ns (Δ = -1584,913 ns)</td><td align="right" bgcolor="#A8D08D">3503,590 ns (Δ = -1410,901 ns)</td><td align="right" bgcolor="#FFFFFF">3475,506 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,550 μs</td><td align="right" bgcolor="#FFFFFF">4,900 μs</td><td align="right" bgcolor="#FFFFFF">4,889 μs</td><td align="right" bgcolor="#FFFFFF">6,499 μs</td><td align="right" bgcolor="#FFFFFF">4,914 μs</td><td align="right" bgcolor="#FFFFFF">3,504 μs</td><td align="right" bgcolor="#FFFFFF">3,476 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">840,000</td><td align="right" bgcolor="#FFFFFF">840,000</td><td align="right" bgcolor="#FFFFFF">840,000</td><td align="right" bgcolor="#FFFFFF">840,000</td><td align="right" bgcolor="#FFFFFF">840,000</td><td align="right" bgcolor="#A8D08D">661,000 (Δ = -179,000)</td><td align="right" bgcolor="#FFFFFF">661,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,820</td><td align="right" bgcolor="#FFFFFF">0,820</td><td align="right" bgcolor="#FFFFFF">0,820</td><td align="right" bgcolor="#FFFFFF">0,820</td><td align="right" bgcolor="#FFFFFF">0,820</td><td align="right" bgcolor="#A8D08D">0,646 (Δ = -0,175)</td><td align="right" bgcolor="#FFFFFF">0,646</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **6.0.0**

Slowest: 5.9.0

Δ: 2489,923 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+23,0 %</td><td align="right" bgcolor="#A8D08D">-41,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6018,441 ns</td><td align="right" bgcolor="#A8D08D">4958,105 ns (Δ = -1060,336 ns)</td><td align="right" bgcolor="#FFFFFF">4976,356 ns</td><td align="right" bgcolor="#FFFFFF">4897,827 ns</td><td align="right" bgcolor="#FF4949">6024,141 ns (Δ = +1126,314 ns)</td><td align="right" bgcolor="#A8D08D">3544,152 ns (Δ = -2479,990 ns)</td><td align="right" bgcolor="#FFFFFF">3534,219 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,018 μs</td><td align="right" bgcolor="#FFFFFF">4,958 μs</td><td align="right" bgcolor="#FFFFFF">4,976 μs</td><td align="right" bgcolor="#FFFFFF">4,898 μs</td><td align="right" bgcolor="#FFFFFF">6,024 μs</td><td align="right" bgcolor="#FFFFFF">3,544 μs</td><td align="right" bgcolor="#FFFFFF">3,534 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">886,000</td><td align="right" bgcolor="#FFFFFF">886,000</td><td align="right" bgcolor="#FFFFFF">886,000</td><td align="right" bgcolor="#FFFFFF">886,000</td><td align="right" bgcolor="#FFFFFF">886,000</td><td align="right" bgcolor="#A8D08D">709,000 (Δ = -177,000)</td><td align="right" bgcolor="#FFFFFF">709,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,865</td><td align="right" bgcolor="#FFFFFF">0,865</td><td align="right" bgcolor="#FFFFFF">0,865</td><td align="right" bgcolor="#FFFFFF">0,865</td><td align="right" bgcolor="#FFFFFF">0,865</td><td align="right" bgcolor="#A8D08D">0,692 (Δ = -0,173)</td><td align="right" bgcolor="#FFFFFF">0,692</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Description"></a>Description

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 2272,476 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-27,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5709,320 ns</td><td align="right" bgcolor="#A8D08D">5058,904 ns (Δ = -650,417 ns)</td><td align="right" bgcolor="#FFFFFF">5038,154 ns</td><td align="right" bgcolor="#FFFFFF">4908,700 ns</td><td align="right" bgcolor="#FFFFFF">4856,673 ns</td><td align="right" bgcolor="#A8D08D">3504,920 ns (Δ = -1351,753 ns)</td><td align="right" bgcolor="#FFFFFF">3436,845 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,709 μs</td><td align="right" bgcolor="#FFFFFF">5,059 μs</td><td align="right" bgcolor="#FFFFFF">5,038 μs</td><td align="right" bgcolor="#FFFFFF">4,909 μs</td><td align="right" bgcolor="#FFFFFF">4,857 μs</td><td align="right" bgcolor="#FFFFFF">3,505 μs</td><td align="right" bgcolor="#FFFFFF">3,437 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#A8D08D">669,000 (Δ = -186,000)</td><td align="right" bgcolor="#FFFFFF">669,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#A8D08D">0,653 (Δ = -0,182)</td><td align="right" bgcolor="#FFFFFF">0,653</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 224226,623 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,7 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#A8D08D">-80,6 %</td><td align="right" bgcolor="#FF4949">+1,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">272486,240 ns</td><td align="right" bgcolor="#A8D08D">256911,201 ns (Δ = -15575,038 ns)</td><td align="right" bgcolor="#A8D08D">246467,705 ns (Δ = -10443,496 ns)</td><td align="right" bgcolor="#FF4949">256811,030 ns (Δ = +10343,325 ns)</td><td align="right" bgcolor="#A8D08D">248563,306 ns (Δ = -8247,724 ns)</td><td align="right" bgcolor="#A8D08D">48259,616 ns (Δ = -200303,690 ns)</td><td align="right" bgcolor="#FF4949">48848,014 ns (Δ = +588,397 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">272,486 μs</td><td align="right" bgcolor="#FFFFFF">256,911 μs</td><td align="right" bgcolor="#FFFFFF">246,468 μs</td><td align="right" bgcolor="#FFFFFF">256,811 μs</td><td align="right" bgcolor="#FFFFFF">248,563 μs</td><td align="right" bgcolor="#FFFFFF">48,260 μs</td><td align="right" bgcolor="#FFFFFF">48,848 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,272 ms</td><td align="right" bgcolor="#FFFFFF">0,257 ms</td><td align="right" bgcolor="#FFFFFF">0,246 ms</td><td align="right" bgcolor="#FFFFFF">0,257 ms</td><td align="right" bgcolor="#FFFFFF">0,249 ms</td><td align="right" bgcolor="#FFFFFF">0,048 ms</td><td align="right" bgcolor="#FFFFFF">0,049 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -15,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -3,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-77,5 %</td><td align="right" bgcolor="#A8D08D">-0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20671,000</td><td align="right" bgcolor="#A8D08D">20669,000 (Δ = -2,000)</td><td align="right" bgcolor="#A8D08D">20665,000 (Δ = -4,000)</td><td align="right" bgcolor="#FF4949">20670,000 (Δ = +5,000)</td><td align="right" bgcolor="#A8D08D">20667,000 (Δ = -3,000)</td><td align="right" bgcolor="#A8D08D">4640,000 (Δ = -16027,000)</td><td align="right" bgcolor="#A8D08D">4632,000 (Δ = -8,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">20,187</td><td align="right" bgcolor="#A8D08D">20,185 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">20,181 (Δ = -0,004)</td><td align="right" bgcolor="#FF4949">20,186 (Δ = +0,005)</td><td align="right" bgcolor="#A8D08D">20,183 (Δ = -0,003)</td><td align="right" bgcolor="#A8D08D">4,531 (Δ = -15,651)</td><td align="right" bgcolor="#A8D08D">4,523 (Δ = -0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,020 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,004 (Δ = -0,015)</td><td align="right" bgcolor="#A8D08D">0,004 (Δ = -0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **6.0.0**

Slowest: 5.6.0

Δ: 2890,300 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+86,0 %</td><td align="right" bgcolor="#A8D08D">-45,2 %</td><td align="right" bgcolor="#A8D08D">-85,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2125,368 ns</td><td align="right" bgcolor="#A8D08D">1818,566 ns (Δ = -306,802 ns)</td><td align="right" bgcolor="#FFFFFF">1683,045 ns</td><td align="right" bgcolor="#FF4949">3130,491 ns (Δ = +1447,447 ns)</td><td align="right" bgcolor="#A8D08D">1715,798 ns (Δ = -1414,694 ns)</td><td align="right" bgcolor="#A8D08D">254,056 ns (Δ = -1461,742 ns)</td><td align="right" bgcolor="#FFFFFF">240,191 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,125 μs</td><td align="right" bgcolor="#FFFFFF">1,819 μs</td><td align="right" bgcolor="#FFFFFF">1,683 μs</td><td align="right" bgcolor="#FFFFFF">3,130 μs</td><td align="right" bgcolor="#FFFFFF">1,716 μs</td><td align="right" bgcolor="#FFFFFF">0,254 μs</td><td align="right" bgcolor="#FFFFFF">0,240 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-61,3 %</td><td align="right" bgcolor="#A8D08D">-2,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1055,000</td><td align="right" bgcolor="#FFFFFF">1055,000</td><td align="right" bgcolor="#FFFFFF">1055,000</td><td align="right" bgcolor="#FFFFFF">1055,000</td><td align="right" bgcolor="#FFFFFF">1055,000</td><td align="right" bgcolor="#A8D08D">408,000 (Δ = -647,000)</td><td align="right" bgcolor="#A8D08D">400,000 (Δ = -8,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,030</td><td align="right" bgcolor="#FFFFFF">1,030</td><td align="right" bgcolor="#FFFFFF">1,030</td><td align="right" bgcolor="#FFFFFF">1,030</td><td align="right" bgcolor="#FFFFFF">1,030</td><td align="right" bgcolor="#A8D08D">0,398 (Δ = -0,632)</td><td align="right" bgcolor="#A8D08D">0,391 (Δ = -0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 3326,483 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,2 %</td><td align="right" bgcolor="#A8D08D">-26,1 %</td><td align="right" bgcolor="#A8D08D">-8,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5005,118 ns</td><td align="right" bgcolor="#FF4949">6068,061 ns (Δ = +1062,943 ns)</td><td align="right" bgcolor="#A8D08D">4483,101 ns (Δ = -1584,960 ns)</td><td align="right" bgcolor="#A8D08D">4118,202 ns (Δ = -364,899 ns)</td><td align="right" bgcolor="#FFFFFF">4024,285 ns</td><td align="right" bgcolor="#A8D08D">2741,578 ns (Δ = -1282,707 ns)</td><td align="right" bgcolor="#FFFFFF">2743,158 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,005 μs</td><td align="right" bgcolor="#FFFFFF">6,068 μs</td><td align="right" bgcolor="#FFFFFF">4,483 μs</td><td align="right" bgcolor="#FFFFFF">4,118 μs</td><td align="right" bgcolor="#FFFFFF">4,024 μs</td><td align="right" bgcolor="#FFFFFF">2,742 μs</td><td align="right" bgcolor="#FFFFFF">2,743 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#A8D08D">584,000 (Δ = -189,000)</td><td align="right" bgcolor="#FFFFFF">584,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#A8D08D">0,570 (Δ = -0,185)</td><td align="right" bgcolor="#FFFFFF">0,570</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Product"></a>Product

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 2369,357 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5837,624 ns</td><td align="right" bgcolor="#A8D08D">4804,754 ns (Δ = -1032,870 ns)</td><td align="right" bgcolor="#FFFFFF">4836,701 ns</td><td align="right" bgcolor="#FFFFFF">4813,340 ns</td><td align="right" bgcolor="#FFFFFF">4876,241 ns</td><td align="right" bgcolor="#A8D08D">3468,267 ns (Δ = -1407,974 ns)</td><td align="right" bgcolor="#FFFFFF">3554,753 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,838 μs</td><td align="right" bgcolor="#FFFFFF">4,805 μs</td><td align="right" bgcolor="#FFFFFF">4,837 μs</td><td align="right" bgcolor="#FFFFFF">4,813 μs</td><td align="right" bgcolor="#FFFFFF">4,876 μs</td><td align="right" bgcolor="#FFFFFF">3,468 μs</td><td align="right" bgcolor="#FFFFFF">3,555 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#A8D08D">669,000 (Δ = -186,000)</td><td align="right" bgcolor="#FFFFFF">669,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#A8D08D">0,653 (Δ = -0,182)</td><td align="right" bgcolor="#FFFFFF">0,653</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Title"></a>Title

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 2274,695 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,9 %</td><td align="right" bgcolor="#A8D08D">-9,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5796,121 ns</td><td align="right" bgcolor="#A8D08D">4945,693 ns (Δ = -850,428 ns)</td><td align="right" bgcolor="#FFFFFF">5063,077 ns</td><td align="right" bgcolor="#FFFFFF">4954,152 ns</td><td align="right" bgcolor="#FFFFFF">4842,102 ns</td><td align="right" bgcolor="#A8D08D">3876,211 ns (Δ = -965,891 ns)</td><td align="right" bgcolor="#A8D08D">3521,426 ns (Δ = -354,785 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,796 μs</td><td align="right" bgcolor="#FFFFFF">4,946 μs</td><td align="right" bgcolor="#FFFFFF">5,063 μs</td><td align="right" bgcolor="#FFFFFF">4,954 μs</td><td align="right" bgcolor="#FFFFFF">4,842 μs</td><td align="right" bgcolor="#FFFFFF">3,876 μs</td><td align="right" bgcolor="#FFFFFF">3,521 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#FFFFFF">855,000</td><td align="right" bgcolor="#A8D08D">669,000 (Δ = -186,000)</td><td align="right" bgcolor="#FFFFFF">669,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#FFFFFF">0,835</td><td align="right" bgcolor="#A8D08D">0,653 (Δ = -0,182)</td><td align="right" bgcolor="#FFFFFF">0,653</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Version"></a>Version

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 184,056 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">795,305 ns</td><td align="right" bgcolor="#FFFFFF">615,949 ns</td><td align="right" bgcolor="#FFFFFF">664,026 ns</td><td align="right" bgcolor="#FFFFFF">611,249 ns</td><td align="right" bgcolor="#FFFFFF">614,935 ns</td><td align="right" bgcolor="#FFFFFF">759,778 ns</td><td align="right" bgcolor="#FFFFFF">762,145 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,795 μs</td><td align="right" bgcolor="#FFFFFF">0,616 μs</td><td align="right" bgcolor="#FFFFFF">0,664 μs</td><td align="right" bgcolor="#FFFFFF">0,611 μs</td><td align="right" bgcolor="#FFFFFF">0,615 μs</td><td align="right" bgcolor="#FFFFFF">0,760 μs</td><td align="right" bgcolor="#FFFFFF">0,762 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-39,9 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1265,000</td><td align="right" bgcolor="#FFFFFF">1265,000</td><td align="right" bgcolor="#FFFFFF">1265,000</td><td align="right" bgcolor="#FFFFFF">1265,000</td><td align="right" bgcolor="#FFFFFF">1265,000</td><td align="right" bgcolor="#A8D08D">760,000 (Δ = -505,000)</td><td align="right" bgcolor="#FF4949">792,000 (Δ = +32,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,235</td><td align="right" bgcolor="#FFFFFF">1,235</td><td align="right" bgcolor="#FFFFFF">1,235</td><td align="right" bgcolor="#FFFFFF">1,235</td><td align="right" bgcolor="#FFFFFF">1,235</td><td align="right" bgcolor="#A8D08D">0,742 (Δ = -0,493)</td><td align="right" bgcolor="#FF4949">0,773 (Δ = +0,031)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 631,043 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1806,902 ns</td><td align="right" bgcolor="#A8D08D">1386,932 ns (Δ = -419,970 ns)</td><td align="right" bgcolor="#FFFFFF">1443,226 ns</td><td align="right" bgcolor="#FFFFFF">1394,624 ns</td><td align="right" bgcolor="#FFFFFF">1427,003 ns</td><td align="right" bgcolor="#FFFFFF">1186,223 ns</td><td align="right" bgcolor="#FFFFFF">1175,859 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,807 μs</td><td align="right" bgcolor="#FFFFFF">1,387 μs</td><td align="right" bgcolor="#FFFFFF">1,443 μs</td><td align="right" bgcolor="#FFFFFF">1,395 μs</td><td align="right" bgcolor="#FFFFFF">1,427 μs</td><td align="right" bgcolor="#FFFFFF">1,186 μs</td><td align="right" bgcolor="#FFFFFF">1,176 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#A8D08D">192,000 (Δ = -59,000)</td><td align="right" bgcolor="#FFFFFF">192,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#A8D08D">0,188 (Δ = -0,058)</td><td align="right" bgcolor="#FFFFFF">0,188</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 1577,151 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2877,670 ns</td><td align="right" bgcolor="#A8D08D">1623,894 ns (Δ = -1253,775 ns)</td><td align="right" bgcolor="#FFFFFF">1619,751 ns</td><td align="right" bgcolor="#FFFFFF">1625,767 ns</td><td align="right" bgcolor="#FFFFFF">1593,914 ns</td><td align="right" bgcolor="#FFFFFF">1361,726 ns</td><td align="right" bgcolor="#FFFFFF">1300,518 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,878 μs</td><td align="right" bgcolor="#FFFFFF">1,624 μs</td><td align="right" bgcolor="#FFFFFF">1,620 μs</td><td align="right" bgcolor="#FFFFFF">1,626 μs</td><td align="right" bgcolor="#FFFFFF">1,594 μs</td><td align="right" bgcolor="#FFFFFF">1,362 μs</td><td align="right" bgcolor="#FFFFFF">1,301 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">224,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">224,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,219 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,219</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 527,045 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1718,656 ns</td><td align="right" bgcolor="#FFFFFF">1717,871 ns</td><td align="right" bgcolor="#A8D08D">1445,007 ns (Δ = -272,864 ns)</td><td align="right" bgcolor="#FFFFFF">1435,942 ns</td><td align="right" bgcolor="#FFFFFF">1486,725 ns</td><td align="right" bgcolor="#A8D08D">1191,611 ns (Δ = -295,114 ns)</td><td align="right" bgcolor="#FFFFFF">1215,074 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,719 μs</td><td align="right" bgcolor="#FFFFFF">1,718 μs</td><td align="right" bgcolor="#FFFFFF">1,445 μs</td><td align="right" bgcolor="#FFFFFF">1,436 μs</td><td align="right" bgcolor="#FFFFFF">1,487 μs</td><td align="right" bgcolor="#FFFFFF">1,192 μs</td><td align="right" bgcolor="#FFFFFF">1,215 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#A8D08D">192,000 (Δ = -59,000)</td><td align="right" bgcolor="#FFFFFF">192,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#A8D08D">0,188 (Δ = -0,058)</td><td align="right" bgcolor="#FFFFFF">0,188</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 758,801 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2112,619 ns</td><td align="right" bgcolor="#FFFFFF">2087,885 ns</td><td align="right" bgcolor="#A8D08D">1672,590 ns (Δ = -415,295 ns)</td><td align="right" bgcolor="#FFFFFF">1613,197 ns</td><td align="right" bgcolor="#FFFFFF">1580,359 ns</td><td align="right" bgcolor="#FFFFFF">1365,125 ns</td><td align="right" bgcolor="#FFFFFF">1353,819 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,113 μs</td><td align="right" bgcolor="#FFFFFF">2,088 μs</td><td align="right" bgcolor="#FFFFFF">1,673 μs</td><td align="right" bgcolor="#FFFFFF">1,613 μs</td><td align="right" bgcolor="#FFFFFF">1,580 μs</td><td align="right" bgcolor="#FFFFFF">1,365 μs</td><td align="right" bgcolor="#FFFFFF">1,354 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">224,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">224,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,219 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,219</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 587,641 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1756,305 ns</td><td align="right" bgcolor="#A8D08D">1465,027 ns (Δ = -291,279 ns)</td><td align="right" bgcolor="#FFFFFF">1442,140 ns</td><td align="right" bgcolor="#FFFFFF">1373,349 ns</td><td align="right" bgcolor="#FFFFFF">1382,013 ns</td><td align="right" bgcolor="#FFFFFF">1196,859 ns</td><td align="right" bgcolor="#FFFFFF">1168,665 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,756 μs</td><td align="right" bgcolor="#FFFFFF">1,465 μs</td><td align="right" bgcolor="#FFFFFF">1,442 μs</td><td align="right" bgcolor="#FFFFFF">1,373 μs</td><td align="right" bgcolor="#FFFFFF">1,382 μs</td><td align="right" bgcolor="#FFFFFF">1,197 μs</td><td align="right" bgcolor="#FFFFFF">1,169 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#A8D08D">192,000 (Δ = -59,000)</td><td align="right" bgcolor="#FFFFFF">192,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#A8D08D">0,188 (Δ = -0,058)</td><td align="right" bgcolor="#FFFFFF">0,188</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 525,838 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1846,448 ns</td><td align="right" bgcolor="#FFFFFF">1699,523 ns</td><td align="right" bgcolor="#FFFFFF">1641,880 ns</td><td align="right" bgcolor="#FFFFFF">1618,341 ns</td><td align="right" bgcolor="#FFFFFF">1630,093 ns</td><td align="right" bgcolor="#A8D08D">1378,466 ns (Δ = -251,627 ns)</td><td align="right" bgcolor="#FFFFFF">1320,610 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,846 μs</td><td align="right" bgcolor="#FFFFFF">1,700 μs</td><td align="right" bgcolor="#FFFFFF">1,642 μs</td><td align="right" bgcolor="#FFFFFF">1,618 μs</td><td align="right" bgcolor="#FFFFFF">1,630 μs</td><td align="right" bgcolor="#FFFFFF">1,378 μs</td><td align="right" bgcolor="#FFFFFF">1,321 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">224,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">224,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,219 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,219</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 775,228 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1939,832 ns</td><td align="right" bgcolor="#A8D08D">1492,549 ns (Δ = -447,283 ns)</td><td align="right" bgcolor="#FFFFFF">1408,037 ns</td><td align="right" bgcolor="#FFFFFF">1534,360 ns</td><td align="right" bgcolor="#FFFFFF">1395,327 ns</td><td align="right" bgcolor="#FFFFFF">1320,958 ns</td><td align="right" bgcolor="#FFFFFF">1164,604 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,940 μs</td><td align="right" bgcolor="#FFFFFF">1,493 μs</td><td align="right" bgcolor="#FFFFFF">1,408 μs</td><td align="right" bgcolor="#FFFFFF">1,534 μs</td><td align="right" bgcolor="#FFFFFF">1,395 μs</td><td align="right" bgcolor="#FFFFFF">1,321 μs</td><td align="right" bgcolor="#FFFFFF">1,165 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#A8D08D">192,000 (Δ = -59,000)</td><td align="right" bgcolor="#FFFFFF">192,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#A8D08D">0,188 (Δ = -0,058)</td><td align="right" bgcolor="#FFFFFF">0,188</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 578,720 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1940,134 ns</td><td align="right" bgcolor="#FFFFFF">1697,443 ns</td><td align="right" bgcolor="#FFFFFF">1664,683 ns</td><td align="right" bgcolor="#FFFFFF">1618,250 ns</td><td align="right" bgcolor="#FFFFFF">1620,952 ns</td><td align="right" bgcolor="#A8D08D">1361,414 ns (Δ = -259,538 ns)</td><td align="right" bgcolor="#FFFFFF">1415,058 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,940 μs</td><td align="right" bgcolor="#FFFFFF">1,697 μs</td><td align="right" bgcolor="#FFFFFF">1,665 μs</td><td align="right" bgcolor="#FFFFFF">1,618 μs</td><td align="right" bgcolor="#FFFFFF">1,621 μs</td><td align="right" bgcolor="#FFFFFF">1,361 μs</td><td align="right" bgcolor="#FFFFFF">1,415 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">224,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">224,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,219 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,219</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 556,773 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1600,007 ns</td><td align="right" bgcolor="#FFFFFF">1469,164 ns</td><td align="right" bgcolor="#FFFFFF">1444,489 ns</td><td align="right" bgcolor="#FFFFFF">1557,443 ns</td><td align="right" bgcolor="#FFFFFF">1388,283 ns</td><td align="right" bgcolor="#FFFFFF">1172,750 ns</td><td align="right" bgcolor="#FFFFFF">1043,234 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,600 μs</td><td align="right" bgcolor="#FFFFFF">1,469 μs</td><td align="right" bgcolor="#FFFFFF">1,444 μs</td><td align="right" bgcolor="#FFFFFF">1,557 μs</td><td align="right" bgcolor="#FFFFFF">1,388 μs</td><td align="right" bgcolor="#FFFFFF">1,173 μs</td><td align="right" bgcolor="#FFFFFF">1,043 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#A8D08D">192,000 (Δ = -59,000)</td><td align="right" bgcolor="#FFFFFF">192,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#A8D08D">0,188 (Δ = -0,058)</td><td align="right" bgcolor="#FFFFFF">0,188</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 715,059 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2062,138 ns</td><td align="right" bgcolor="#A8D08D">1622,299 ns (Δ = -439,839 ns)</td><td align="right" bgcolor="#FFFFFF">1640,493 ns</td><td align="right" bgcolor="#FFFFFF">1640,094 ns</td><td align="right" bgcolor="#FFFFFF">1580,544 ns</td><td align="right" bgcolor="#FFFFFF">1347,078 ns</td><td align="right" bgcolor="#FFFFFF">1356,105 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,062 μs</td><td align="right" bgcolor="#FFFFFF">1,622 μs</td><td align="right" bgcolor="#FFFFFF">1,640 μs</td><td align="right" bgcolor="#FFFFFF">1,640 μs</td><td align="right" bgcolor="#FFFFFF">1,581 μs</td><td align="right" bgcolor="#FFFFFF">1,347 μs</td><td align="right" bgcolor="#FFFFFF">1,356 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">224,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">224,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,219 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,219</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **6.0.0**

Slowest: 5.4.0

Δ: 850,624 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,5 %</td><td align="right" bgcolor="#A8D08D">-29,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1785,027 ns</td><td align="right" bgcolor="#FF4949">2043,050 ns (Δ = +258,023 ns)</td><td align="right" bgcolor="#A8D08D">1432,913 ns (Δ = -610,137 ns)</td><td align="right" bgcolor="#FFFFFF">1550,262 ns</td><td align="right" bgcolor="#FFFFFF">1393,699 ns</td><td align="right" bgcolor="#FFFFFF">1216,313 ns</td><td align="right" bgcolor="#FFFFFF">1192,426 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,785 μs</td><td align="right" bgcolor="#FFFFFF">2,043 μs</td><td align="right" bgcolor="#FFFFFF">1,433 μs</td><td align="right" bgcolor="#FFFFFF">1,550 μs</td><td align="right" bgcolor="#FFFFFF">1,394 μs</td><td align="right" bgcolor="#FFFFFF">1,216 μs</td><td align="right" bgcolor="#FFFFFF">1,192 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#FFFFFF">251,000</td><td align="right" bgcolor="#A8D08D">192,000 (Δ = -59,000)</td><td align="right" bgcolor="#FFFFFF">192,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#FFFFFF">0,245</td><td align="right" bgcolor="#A8D08D">0,188 (Δ = -0,058)</td><td align="right" bgcolor="#FFFFFF">0,188</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 679,766 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2053,407 ns</td><td align="right" bgcolor="#A8D08D">1722,798 ns (Δ = -330,609 ns)</td><td align="right" bgcolor="#FFFFFF">1681,268 ns</td><td align="right" bgcolor="#FFFFFF">1639,936 ns</td><td align="right" bgcolor="#FFFFFF">1651,298 ns</td><td align="right" bgcolor="#A8D08D">1373,641 ns (Δ = -277,657 ns)</td><td align="right" bgcolor="#FFFFFF">1493,125 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,053 μs</td><td align="right" bgcolor="#FFFFFF">1,723 μs</td><td align="right" bgcolor="#FFFFFF">1,681 μs</td><td align="right" bgcolor="#FFFFFF">1,640 μs</td><td align="right" bgcolor="#FFFFFF">1,651 μs</td><td align="right" bgcolor="#FFFFFF">1,374 μs</td><td align="right" bgcolor="#FFFFFF">1,493 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">224,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">224,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,219 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,219</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 109,260 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">241,591 ns</td><td align="right" bgcolor="#FFFFFF">209,379 ns</td><td align="right" bgcolor="#FFFFFF">203,213 ns</td><td align="right" bgcolor="#FFFFFF">211,839 ns</td><td align="right" bgcolor="#FFFFFF">246,110 ns</td><td align="right" bgcolor="#FFFFFF">312,473 ns</td><td align="right" bgcolor="#FFFFFF">298,559 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td><td align="right" bgcolor="#FFFFFF">0,209 μs</td><td align="right" bgcolor="#FFFFFF">0,203 μs</td><td align="right" bgcolor="#FFFFFF">0,212 μs</td><td align="right" bgcolor="#FFFFFF">0,246 μs</td><td align="right" bgcolor="#FFFFFF">0,312 μs</td><td align="right" bgcolor="#FFFFFF">0,299 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#A8D08D">-11,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#A8D08D">216,000 (Δ = -4,000)</td><td align="right" bgcolor="#A8D08D">192,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#A8D08D">0,211 (Δ = -0,004)</td><td align="right" bgcolor="#A8D08D">0,188 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 101,609 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">264,838 ns</td><td align="right" bgcolor="#FFFFFF">197,868 ns</td><td align="right" bgcolor="#FFFFFF">203,517 ns</td><td align="right" bgcolor="#FFFFFF">205,418 ns</td><td align="right" bgcolor="#FFFFFF">208,318 ns</td><td align="right" bgcolor="#FFFFFF">293,584 ns</td><td align="right" bgcolor="#FFFFFF">299,477 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td><td align="right" bgcolor="#FFFFFF">0,204 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,294 μs</td><td align="right" bgcolor="#FFFFFF">0,299 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#A8D08D">-17,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#A8D08D">136,000 (Δ = -2,000)</td><td align="right" bgcolor="#A8D08D">112,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#A8D08D">0,133 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,109 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 153,933 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">255,340 ns</td><td align="right" bgcolor="#FFFFFF">207,908 ns</td><td align="right" bgcolor="#FFFFFF">202,658 ns</td><td align="right" bgcolor="#FFFFFF">233,727 ns</td><td align="right" bgcolor="#FFFFFF">204,573 ns</td><td align="right" bgcolor="#FFFFFF">356,590 ns</td><td align="right" bgcolor="#FFFFFF">321,431 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,255 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,203 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,357 μs</td><td align="right" bgcolor="#FFFFFF">0,321 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#A8D08D">-16,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">143,000</td><td align="right" bgcolor="#A8D08D">138,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FF4949">143,000 (Δ = +5,000)</td><td align="right" bgcolor="#A8D08D">138,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">136,000 (Δ = -2,000)</td><td align="right" bgcolor="#A8D08D">113,000 (Δ = -23,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,140</td><td align="right" bgcolor="#A8D08D">0,135 (Δ = -0,005)</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FF4949">0,140 (Δ = +0,005)</td><td align="right" bgcolor="#A8D08D">0,135 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">0,133 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,110 (Δ = -0,022)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 118,708 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">212,879 ns</td><td align="right" bgcolor="#FFFFFF">221,151 ns</td><td align="right" bgcolor="#FFFFFF">181,103 ns</td><td align="right" bgcolor="#FFFFFF">185,876 ns</td><td align="right" bgcolor="#FFFFFF">186,561 ns</td><td align="right" bgcolor="#FFFFFF">299,190 ns</td><td align="right" bgcolor="#FFFFFF">299,811 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,181 μs</td><td align="right" bgcolor="#FFFFFF">0,186 μs</td><td align="right" bgcolor="#FFFFFF">0,187 μs</td><td align="right" bgcolor="#FFFFFF">0,299 μs</td><td align="right" bgcolor="#FFFFFF">0,300 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,4 %</td><td align="right" bgcolor="#A8D08D">-20,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">120,000 (Δ = -3,000)</td><td align="right" bgcolor="#A8D08D">96,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#A8D08D">0,117 (Δ = -0,003)</td><td align="right" bgcolor="#A8D08D">0,094 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 117,763 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">215,033 ns</td><td align="right" bgcolor="#FFFFFF">188,011 ns</td><td align="right" bgcolor="#FFFFFF">180,512 ns</td><td align="right" bgcolor="#FFFFFF">189,504 ns</td><td align="right" bgcolor="#FFFFFF">197,618 ns</td><td align="right" bgcolor="#FFFFFF">298,274 ns</td><td align="right" bgcolor="#FFFFFF">290,383 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,215 μs</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td><td align="right" bgcolor="#FFFFFF">0,181 μs</td><td align="right" bgcolor="#FFFFFF">0,190 μs</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td><td align="right" bgcolor="#FFFFFF">0,298 μs</td><td align="right" bgcolor="#FFFFFF">0,290 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,4 %</td><td align="right" bgcolor="#A8D08D">-20,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">120,000 (Δ = -3,000)</td><td align="right" bgcolor="#A8D08D">96,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#A8D08D">0,117 (Δ = -0,003)</td><td align="right" bgcolor="#A8D08D">0,094 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 110,663 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">240,530 ns</td><td align="right" bgcolor="#FFFFFF">202,286 ns</td><td align="right" bgcolor="#FFFFFF">197,768 ns</td><td align="right" bgcolor="#FFFFFF">206,223 ns</td><td align="right" bgcolor="#FFFFFF">202,222 ns</td><td align="right" bgcolor="#FFFFFF">308,431 ns</td><td align="right" bgcolor="#FFFFFF">301,033 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,241 μs</td><td align="right" bgcolor="#FFFFFF">0,202 μs</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#FFFFFF">0,202 μs</td><td align="right" bgcolor="#FFFFFF">0,308 μs</td><td align="right" bgcolor="#FFFFFF">0,301 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#A8D08D">-11,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#A8D08D">216,000 (Δ = -4,000)</td><td align="right" bgcolor="#A8D08D">192,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#A8D08D">0,211 (Δ = -0,004)</td><td align="right" bgcolor="#A8D08D">0,188 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 340,653 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">729,722 ns</td><td align="right" bgcolor="#FFFFFF">644,563 ns</td><td align="right" bgcolor="#FFFFFF">626,787 ns</td><td align="right" bgcolor="#FFFFFF">635,394 ns</td><td align="right" bgcolor="#FFFFFF">570,776 ns</td><td align="right" bgcolor="#FFFFFF">544,309 ns</td><td align="right" bgcolor="#FFFFFF">389,069 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,730 μs</td><td align="right" bgcolor="#FFFFFF">0,645 μs</td><td align="right" bgcolor="#FFFFFF">0,627 μs</td><td align="right" bgcolor="#FFFFFF">0,635 μs</td><td align="right" bgcolor="#FFFFFF">0,571 μs</td><td align="right" bgcolor="#FFFFFF">0,544 μs</td><td align="right" bgcolor="#FFFFFF">0,389 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-71,4 %</td><td align="right" bgcolor="#A8D08D">-48,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">189,000</td><td align="right" bgcolor="#FFFFFF">189,000</td><td align="right" bgcolor="#FFFFFF">189,000</td><td align="right" bgcolor="#FFFFFF">189,000</td><td align="right" bgcolor="#FFFFFF">189,000</td><td align="right" bgcolor="#A8D08D">54,000 (Δ = -135,000)</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -26,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,185</td><td align="right" bgcolor="#FFFFFF">0,185</td><td align="right" bgcolor="#FFFFFF">0,185</td><td align="right" bgcolor="#FFFFFF">0,185</td><td align="right" bgcolor="#FFFFFF">0,185</td><td align="right" bgcolor="#A8D08D">0,053 (Δ = -0,132)</td><td align="right" bgcolor="#A8D08D">0,027 (Δ = -0,025)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 239,475 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">107,458 ns</td><td align="right" bgcolor="#FFFFFF">89,652 ns</td><td align="right" bgcolor="#FFFFFF">96,824 ns</td><td align="right" bgcolor="#FFFFFF">102,589 ns</td><td align="right" bgcolor="#FFFFFF">88,665 ns</td><td align="right" bgcolor="#FFFFFF">310,160 ns</td><td align="right" bgcolor="#FFFFFF">328,140 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td><td align="right" bgcolor="#FFFFFF">0,089 μs</td><td align="right" bgcolor="#FFFFFF">0,310 μs</td><td align="right" bgcolor="#FFFFFF">0,328 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#A8D08D">-88,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FF4949">27,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">3,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FF4949">0,026 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Enum_Benchmark_GetName_Long"></a>GetName_Long

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 232,940 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">118,599 ns</td><td align="right" bgcolor="#FFFFFF">100,985 ns</td><td align="right" bgcolor="#FFFFFF">97,805 ns</td><td align="right" bgcolor="#FFFFFF">98,177 ns</td><td align="right" bgcolor="#FFFFFF">93,705 ns</td><td align="right" bgcolor="#FFFFFF">321,264 ns</td><td align="right" bgcolor="#FFFFFF">326,645 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,321 μs</td><td align="right" bgcolor="#FFFFFF">0,327 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#A8D08D">-88,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FF4949">27,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">3,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FF4949">0,026 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Enum_Benchmark_GetNames"></a>GetNames

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 436,379 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1596,765 ns</td><td align="right" bgcolor="#A8D08D">1290,579 ns (Δ = -306,186 ns)</td><td align="right" bgcolor="#FFFFFF">1338,882 ns</td><td align="right" bgcolor="#FFFFFF">1302,984 ns</td><td align="right" bgcolor="#FFFFFF">1337,338 ns</td><td align="right" bgcolor="#FFFFFF">1182,853 ns</td><td align="right" bgcolor="#FFFFFF">1160,386 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,597 μs</td><td align="right" bgcolor="#FFFFFF">1,291 μs</td><td align="right" bgcolor="#FFFFFF">1,339 μs</td><td align="right" bgcolor="#FFFFFF">1,303 μs</td><td align="right" bgcolor="#FFFFFF">1,337 μs</td><td align="right" bgcolor="#FFFFFF">1,183 μs</td><td align="right" bgcolor="#FFFFFF">1,160 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-35,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">916,000</td><td align="right" bgcolor="#FFFFFF">916,000</td><td align="right" bgcolor="#FFFFFF">916,000</td><td align="right" bgcolor="#FFFFFF">916,000</td><td align="right" bgcolor="#FFFFFF">916,000</td><td align="right" bgcolor="#A8D08D">590,000 (Δ = -326,000)</td><td align="right" bgcolor="#FFFFFF">590,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,895</td><td align="right" bgcolor="#FFFFFF">0,895</td><td align="right" bgcolor="#FFFFFF">0,895</td><td align="right" bgcolor="#FFFFFF">0,895</td><td align="right" bgcolor="#FFFFFF">0,895</td><td align="right" bgcolor="#A8D08D">0,576 (Δ = -0,318)</td><td align="right" bgcolor="#FFFFFF">0,576</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Enum_Benchmark_GetValues"></a>GetValues

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 817,948 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3049,539 ns</td><td align="right" bgcolor="#A8D08D">2477,455 ns (Δ = -572,084 ns)</td><td align="right" bgcolor="#FFFFFF">2590,664 ns</td><td align="right" bgcolor="#FFFFFF">2511,274 ns</td><td align="right" bgcolor="#FFFFFF">2731,300 ns</td><td align="right" bgcolor="#A8D08D">2284,042 ns (Δ = -447,258 ns)</td><td align="right" bgcolor="#FFFFFF">2231,591 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,050 μs</td><td align="right" bgcolor="#FFFFFF">2,477 μs</td><td align="right" bgcolor="#FFFFFF">2,591 μs</td><td align="right" bgcolor="#FFFFFF">2,511 μs</td><td align="right" bgcolor="#FFFFFF">2,731 μs</td><td align="right" bgcolor="#FFFFFF">2,284 μs</td><td align="right" bgcolor="#FFFFFF">2,232 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#A8D08D">920,000 (Δ = -191,000)</td><td align="right" bgcolor="#FFFFFF">920,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#A8D08D">0,898 (Δ = -0,187)</td><td align="right" bgcolor="#FFFFFF">0,898</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 214,114 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">417,299 ns</td><td align="right" bgcolor="#FFFFFF">203,184 ns</td><td align="right" bgcolor="#FFFFFF">207,609 ns</td><td align="right" bgcolor="#FFFFFF">207,513 ns</td><td align="right" bgcolor="#FFFFFF">236,437 ns</td><td align="right" bgcolor="#FFFFFF">378,699 ns</td><td align="right" bgcolor="#FFFFFF">366,528 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,417 μs</td><td align="right" bgcolor="#FFFFFF">0,203 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,379 μs</td><td align="right" bgcolor="#FFFFFF">0,367 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-75,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -85,000)</td><td align="right" bgcolor="#FFFFFF">28,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#A8D08D">0,027 (Δ = -0,083)</td><td align="right" bgcolor="#FFFFFF">0,027</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_ToList"></a>ToList

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 687,860 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3013,993 ns</td><td align="right" bgcolor="#A8D08D">2542,568 ns (Δ = -471,425 ns)</td><td align="right" bgcolor="#FFFFFF">2645,105 ns</td><td align="right" bgcolor="#FFFFFF">2776,041 ns</td><td align="right" bgcolor="#A8D08D">2367,976 ns (Δ = -408,065 ns)</td><td align="right" bgcolor="#FFFFFF">2326,134 ns</td><td align="right" bgcolor="#FF4949">2784,462 ns (Δ = +458,328 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,014 μs</td><td align="right" bgcolor="#FFFFFF">2,543 μs</td><td align="right" bgcolor="#FFFFFF">2,645 μs</td><td align="right" bgcolor="#FFFFFF">2,776 μs</td><td align="right" bgcolor="#FFFFFF">2,368 μs</td><td align="right" bgcolor="#FFFFFF">2,326 μs</td><td align="right" bgcolor="#FFFFFF">2,784 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,5 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1198,000</td><td align="right" bgcolor="#FFFFFF">1198,000</td><td align="right" bgcolor="#FFFFFF">1198,000</td><td align="right" bgcolor="#FFFFFF">1198,000</td><td align="right" bgcolor="#FFFFFF">1198,000</td><td align="right" bgcolor="#A8D08D">1000,000 (Δ = -198,000)</td><td align="right" bgcolor="#FF4949">1001,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,170</td><td align="right" bgcolor="#FFFFFF">1,170</td><td align="right" bgcolor="#FFFFFF">1,170</td><td align="right" bgcolor="#FFFFFF">1,170</td><td align="right" bgcolor="#FFFFFF">1,170</td><td align="right" bgcolor="#A8D08D">0,977 (Δ = -0,193)</td><td align="right" bgcolor="#FF4949">0,978 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_TryParse"></a>TryParse

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 173,740 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">288,453 ns</td><td align="right" bgcolor="#FFFFFF">285,656 ns</td><td align="right" bgcolor="#FFFFFF">216,244 ns</td><td align="right" bgcolor="#FFFFFF">214,386 ns</td><td align="right" bgcolor="#FFFFFF">214,073 ns</td><td align="right" bgcolor="#FFFFFF">387,813 ns</td><td align="right" bgcolor="#FFFFFF">387,806 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,288 μs</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,216 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,388 μs</td><td align="right" bgcolor="#FFFFFF">0,388 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-75,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -85,000)</td><td align="right" bgcolor="#FFFFFF">28,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#A8D08D">0,027 (Δ = -0,083)</td><td align="right" bgcolor="#FFFFFF">0,027</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase"></a>TryParse_IgnoreCase

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 169,236 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">263,731 ns</td><td align="right" bgcolor="#FFFFFF">218,059 ns</td><td align="right" bgcolor="#FFFFFF">222,631 ns</td><td align="right" bgcolor="#FFFFFF">228,813 ns</td><td align="right" bgcolor="#FFFFFF">219,366 ns</td><td align="right" bgcolor="#FFFFFF">387,296 ns</td><td align="right" bgcolor="#FFFFFF">380,984 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,229 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,387 μs</td><td align="right" bgcolor="#FFFFFF">0,381 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-75,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -85,000)</td><td align="right" bgcolor="#FFFFFF">28,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#A8D08D">0,027 (Δ = -0,083)</td><td align="right" bgcolor="#FFFFFF">0,027</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase_Nullable"></a>TryParse_IgnoreCase_Nullable

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 169,962 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">258,807 ns</td><td align="right" bgcolor="#FFFFFF">218,281 ns</td><td align="right" bgcolor="#FFFFFF">212,865 ns</td><td align="right" bgcolor="#FFFFFF">241,991 ns</td><td align="right" bgcolor="#FFFFFF">213,324 ns</td><td align="right" bgcolor="#FFFFFF">382,826 ns</td><td align="right" bgcolor="#FFFFFF">376,569 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,259 μs</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,383 μs</td><td align="right" bgcolor="#FFFFFF">0,377 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-75,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -85,000)</td><td align="right" bgcolor="#FFFFFF">28,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#A8D08D">0,027 (Δ = -0,083)</td><td align="right" bgcolor="#FFFFFF">0,027</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 163,981 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">313,412 ns</td><td align="right" bgcolor="#FFFFFF">214,380 ns</td><td align="right" bgcolor="#FFFFFF">219,024 ns</td><td align="right" bgcolor="#FFFFFF">211,452 ns</td><td align="right" bgcolor="#FFFFFF">209,361 ns</td><td align="right" bgcolor="#FFFFFF">369,688 ns</td><td align="right" bgcolor="#FFFFFF">373,342 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,313 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,209 μs</td><td align="right" bgcolor="#FFFFFF">0,370 μs</td><td align="right" bgcolor="#FFFFFF">0,373 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-75,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -85,000)</td><td align="right" bgcolor="#FFFFFF">28,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#A8D08D">0,027 (Δ = -0,083)</td><td align="right" bgcolor="#FFFFFF">0,027</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ExpressionHelper_Benchmark"></a>ExpressionHelper_Benchmark

### <a name="ExpressionHelper_Benchmark_GetOwner"></a>GetOwner

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 1031,225 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,1 %</td><td align="right" bgcolor="#A8D08D">-26,8 %</td><td align="right" bgcolor="#FF4949">+41,0 %</td><td align="right" bgcolor="#A8D08D">-26,3 %</td><td align="right" bgcolor="#FF4949">+104,8 %</td><td align="right" bgcolor="#A8D08D">-15,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1544,245 ns</td><td align="right" bgcolor="#A8D08D">1249,580 ns (Δ = -294,665 ns)</td><td align="right" bgcolor="#A8D08D">914,358 ns (Δ = -335,222 ns)</td><td align="right" bgcolor="#FF4949">1289,366 ns (Δ = +375,008 ns)</td><td align="right" bgcolor="#A8D08D">949,938 ns (Δ = -339,429 ns)</td><td align="right" bgcolor="#FF4949">1945,583 ns (Δ = +995,646 ns)</td><td align="right" bgcolor="#A8D08D">1645,032 ns (Δ = -300,551 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,544 μs</td><td align="right" bgcolor="#FFFFFF">1,250 μs</td><td align="right" bgcolor="#FFFFFF">0,914 μs</td><td align="right" bgcolor="#FFFFFF">1,289 μs</td><td align="right" bgcolor="#FFFFFF">0,950 μs</td><td align="right" bgcolor="#FFFFFF">1,946 μs</td><td align="right" bgcolor="#FFFFFF">1,645 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">655,000</td><td align="right" bgcolor="#FFFFFF">655,000</td><td align="right" bgcolor="#FFFFFF">655,000</td><td align="right" bgcolor="#FFFFFF">655,000</td><td align="right" bgcolor="#FFFFFF">655,000</td><td align="right" bgcolor="#A8D08D">586,000 (Δ = -69,000)</td><td align="right" bgcolor="#FFFFFF">586,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,640</td><td align="right" bgcolor="#FFFFFF">0,640</td><td align="right" bgcolor="#FFFFFF">0,640</td><td align="right" bgcolor="#FFFFFF">0,640</td><td align="right" bgcolor="#FFFFFF">0,640</td><td align="right" bgcolor="#A8D08D">0,572 (Δ = -0,067)</td><td align="right" bgcolor="#FFFFFF">0,572</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ExpressionHelper_Benchmark_GetPropertyName"></a>GetPropertyName

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 2688,257 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,5 %</td><td align="right" bgcolor="#A8D08D">-18,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,0 %</td><td align="right" bgcolor="#FF4949">+89,1 %</td><td align="right" bgcolor="#A8D08D">-18,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2929,328 ns</td><td align="right" bgcolor="#A8D08D">2240,219 ns (Δ = -689,109 ns)</td><td align="right" bgcolor="#A8D08D">1821,730 ns (Δ = -418,489 ns)</td><td align="right" bgcolor="#FFFFFF">1954,530 ns</td><td align="right" bgcolor="#FF4949">2384,800 ns (Δ = +430,270 ns)</td><td align="right" bgcolor="#FF4949">4509,987 ns (Δ = +2125,187 ns)</td><td align="right" bgcolor="#A8D08D">3681,301 ns (Δ = -828,686 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,929 μs</td><td align="right" bgcolor="#FFFFFF">2,240 μs</td><td align="right" bgcolor="#FFFFFF">1,822 μs</td><td align="right" bgcolor="#FFFFFF">1,955 μs</td><td align="right" bgcolor="#FFFFFF">2,385 μs</td><td align="right" bgcolor="#FFFFFF">4,510 μs</td><td align="right" bgcolor="#FFFFFF">3,681 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td><td align="right" bgcolor="#A8D08D">-2,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#A8D08D">1827,000 (Δ = -165,000)</td><td align="right" bgcolor="#A8D08D">1779,000 (Δ = -48,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#A8D08D">1,784 (Δ = -0,161)</td><td align="right" bgcolor="#A8D08D">1,737 (Δ = -0,047)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,000)</td></tr></table>


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

Δ: 307,625 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2601,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,347 ns</td><td align="right" bgcolor="#FFFFFF">15,331 ns</td><td align="right" bgcolor="#FFFFFF">11,876 ns</td><td align="right" bgcolor="#FFFFFF">15,392 ns</td><td align="right" bgcolor="#FFFFFF">11,825 ns</td><td align="right" bgcolor="#FF4949">319,450 ns (Δ = +307,625 ns)</td><td align="right" bgcolor="#FFFFFF">261,006 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,319 μs</td><td align="right" bgcolor="#FFFFFF">0,261 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">6.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+91,0 %</td><td align="right" bgcolor="#FF4949">+0,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">67,000</td><td align="right" bgcolor="#FFFFFF">67,000</td><td align="right" bgcolor="#FFFFFF">67,000</td><td align="right" bgcolor="#FFFFFF">67,000</td><td align="right" bgcolor="#FFFFFF">67,000</td><td align="right" bgcolor="#FF4949">128,000 (Δ = +61,000)</td><td align="right" bgcolor="#FF4949">129,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,065</td><td align="right" bgcolor="#FFFFFF">0,065</td><td align="right" bgcolor="#FFFFFF">0,065</td><td align="right" bgcolor="#FFFFFF">0,065</td><td align="right" bgcolor="#FFFFFF">0,065</td><td align="right" bgcolor="#FF4949">0,125 (Δ = +0,060)</td><td align="right" bgcolor="#FF4949">0,126 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="LanguageHelper_Benchmark"></a>LanguageHelper_Benchmark

### <a name="LanguageHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 306,753 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+103,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">309,244 ns</td><td align="right" bgcolor="#FFFFFF">312,664 ns</td><td align="right" bgcolor="#FFFFFF">309,109 ns</td><td align="right" bgcolor="#FFFFFF">304,224 ns</td><td align="right" bgcolor="#FFFFFF">297,040 ns</td><td align="right" bgcolor="#FF4949">603,793 ns (Δ = +306,753 ns)</td><td align="right" bgcolor="#FFFFFF">564,956 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,309 μs</td><td align="right" bgcolor="#FFFFFF">0,313 μs</td><td align="right" bgcolor="#FFFFFF">0,309 μs</td><td align="right" bgcolor="#FFFFFF">0,304 μs</td><td align="right" bgcolor="#FFFFFF">0,297 μs</td><td align="right" bgcolor="#FFFFFF">0,604 μs</td><td align="right" bgcolor="#FFFFFF">0,565 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#A8D08D">-0,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#A8D08D">257,000 (Δ = -4,000)</td><td align="right" bgcolor="#A8D08D">256,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#A8D08D">0,251 (Δ = -0,004)</td><td align="right" bgcolor="#A8D08D">0,250 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


## <a name="Log_Debug_Benchmark"></a>Log_Debug_Benchmark

### <a name="Log_Debug_Benchmark_Log_Debug_Format_1_Format_Argument"></a>Log_Debug_Format_1_Format_Argument

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 202,261 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">502,210 ns</td><td align="right" bgcolor="#FFFFFF">406,656 ns</td><td align="right" bgcolor="#FFFFFF">403,542 ns</td><td align="right" bgcolor="#FFFFFF">392,323 ns</td><td align="right" bgcolor="#FFFFFF">423,419 ns</td><td align="right" bgcolor="#FFFFFF">594,583 ns</td><td align="right" bgcolor="#FFFFFF">423,819 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,502 μs</td><td align="right" bgcolor="#FFFFFF">0,407 μs</td><td align="right" bgcolor="#FFFFFF">0,404 μs</td><td align="right" bgcolor="#FFFFFF">0,392 μs</td><td align="right" bgcolor="#FFFFFF">0,423 μs</td><td align="right" bgcolor="#FFFFFF">0,595 μs</td><td align="right" bgcolor="#FFFFFF">0,424 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,4 %</td><td align="right" bgcolor="#A8D08D">-10,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#A8D08D">296,000 (Δ = -42,000)</td><td align="right" bgcolor="#A8D08D">264,000 (Δ = -32,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#A8D08D">0,289 (Δ = -0,041)</td><td align="right" bgcolor="#A8D08D">0,258 (Δ = -0,031)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_2_Format_Arguments"></a>Log_Debug_Format_2_Format_Arguments

#### Performance

Fastest: **6.0.0**

Slowest: 5.12.0

Δ: 140,083 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">585,253 ns</td><td align="right" bgcolor="#FFFFFF">470,446 ns</td><td align="right" bgcolor="#FFFFFF">528,712 ns</td><td align="right" bgcolor="#FFFFFF">476,132 ns</td><td align="right" bgcolor="#FFFFFF">467,281 ns</td><td align="right" bgcolor="#FFFFFF">593,056 ns</td><td align="right" bgcolor="#FFFFFF">452,973 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,585 μs</td><td align="right" bgcolor="#FFFFFF">0,470 μs</td><td align="right" bgcolor="#FFFFFF">0,529 μs</td><td align="right" bgcolor="#FFFFFF">0,476 μs</td><td align="right" bgcolor="#FFFFFF">0,467 μs</td><td align="right" bgcolor="#FFFFFF">0,593 μs</td><td align="right" bgcolor="#FFFFFF">0,453 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#A8D08D">304,000 (Δ = -75,000)</td><td align="right" bgcolor="#FFFFFF">304,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#A8D08D">0,297 (Δ = -0,073)</td><td align="right" bgcolor="#FFFFFF">0,297</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments"></a>Log_Debug_Format_3_Format_Arguments

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 193,904 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">720,114 ns</td><td align="right" bgcolor="#FFFFFF">686,455 ns</td><td align="right" bgcolor="#FFFFFF">623,954 ns</td><td align="right" bgcolor="#FFFFFF">572,122 ns</td><td align="right" bgcolor="#FFFFFF">581,571 ns</td><td align="right" bgcolor="#FFFFFF">526,210 ns</td><td align="right" bgcolor="#FFFFFF">536,304 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,720 μs</td><td align="right" bgcolor="#FFFFFF">0,686 μs</td><td align="right" bgcolor="#FFFFFF">0,624 μs</td><td align="right" bgcolor="#FFFFFF">0,572 μs</td><td align="right" bgcolor="#FFFFFF">0,582 μs</td><td align="right" bgcolor="#FFFFFF">0,526 μs</td><td align="right" bgcolor="#FFFFFF">0,536 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">344,000 (Δ = -107,000)</td><td align="right" bgcolor="#FFFFFF">344,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,336 (Δ = -0,104)</td><td align="right" bgcolor="#FFFFFF">0,336</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_4_Format_Arguments"></a>Log_Debug_Format_4_Format_Arguments

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 302,853 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">888,124 ns</td><td align="right" bgcolor="#FFFFFF">795,495 ns</td><td align="right" bgcolor="#FFFFFF">739,049 ns</td><td align="right" bgcolor="#FFFFFF">683,985 ns</td><td align="right" bgcolor="#FFFFFF">706,313 ns</td><td align="right" bgcolor="#FFFFFF">637,979 ns</td><td align="right" bgcolor="#FFFFFF">585,271 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,888 μs</td><td align="right" bgcolor="#FFFFFF">0,795 μs</td><td align="right" bgcolor="#FFFFFF">0,739 μs</td><td align="right" bgcolor="#FFFFFF">0,684 μs</td><td align="right" bgcolor="#FFFFFF">0,706 μs</td><td align="right" bgcolor="#FFFFFF">0,638 μs</td><td align="right" bgcolor="#FFFFFF">0,585 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#A8D08D">440,000 (Δ = -139,000)</td><td align="right" bgcolor="#FFFFFF">440,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#A8D08D">0,430 (Δ = -0,136)</td><td align="right" bgcolor="#FFFFFF">0,430</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_5_Format_Arguments"></a>Log_Debug_Format_5_Format_Arguments

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 293,894 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">989,628 ns</td><td align="right" bgcolor="#FFFFFF">867,963 ns</td><td align="right" bgcolor="#FFFFFF">836,817 ns</td><td align="right" bgcolor="#FFFFFF">775,429 ns</td><td align="right" bgcolor="#FFFFFF">776,366 ns</td><td align="right" bgcolor="#FFFFFF">745,625 ns</td><td align="right" bgcolor="#FFFFFF">695,734 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,990 μs</td><td align="right" bgcolor="#FFFFFF">0,868 μs</td><td align="right" bgcolor="#FFFFFF">0,837 μs</td><td align="right" bgcolor="#FFFFFF">0,775 μs</td><td align="right" bgcolor="#FFFFFF">0,776 μs</td><td align="right" bgcolor="#FFFFFF">0,746 μs</td><td align="right" bgcolor="#FFFFFF">0,696 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#A8D08D">488,000 (Δ = -172,000)</td><td align="right" bgcolor="#FFFFFF">488,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,168)</td><td align="right" bgcolor="#FFFFFF">0,477</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments"></a>Log_Debug_Format_6_Format_Arguments

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 185,237 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1086,834 ns</td><td align="right" bgcolor="#FFFFFF">970,947 ns</td><td align="right" bgcolor="#FFFFFF">989,126 ns</td><td align="right" bgcolor="#FFFFFF">936,122 ns</td><td align="right" bgcolor="#FFFFFF">930,925 ns</td><td align="right" bgcolor="#FFFFFF">901,597 ns</td><td align="right" bgcolor="#FFFFFF">918,191 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,087 μs</td><td align="right" bgcolor="#FFFFFF">0,971 μs</td><td align="right" bgcolor="#FFFFFF">0,989 μs</td><td align="right" bgcolor="#FFFFFF">0,936 μs</td><td align="right" bgcolor="#FFFFFF">0,931 μs</td><td align="right" bgcolor="#FFFFFF">0,902 μs</td><td align="right" bgcolor="#FFFFFF">0,918 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#A8D08D">632,000 (Δ = -203,000)</td><td align="right" bgcolor="#FFFFFF">632,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#A8D08D">0,617 (Δ = -0,198)</td><td align="right" bgcolor="#FFFFFF">0,617</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_7_Format_Arguments"></a>Log_Debug_Format_7_Format_Arguments

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 400,081 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1224,769 ns</td><td align="right" bgcolor="#FFFFFF">1073,711 ns</td><td align="right" bgcolor="#FFFFFF">1109,054 ns</td><td align="right" bgcolor="#FFFFFF">1061,677 ns</td><td align="right" bgcolor="#FFFFFF">1044,306 ns</td><td align="right" bgcolor="#FFFFFF">990,856 ns</td><td align="right" bgcolor="#FFFFFF">824,688 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,225 μs</td><td align="right" bgcolor="#FFFFFF">1,074 μs</td><td align="right" bgcolor="#FFFFFF">1,109 μs</td><td align="right" bgcolor="#FFFFFF">1,062 μs</td><td align="right" bgcolor="#FFFFFF">1,044 μs</td><td align="right" bgcolor="#FFFFFF">0,991 μs</td><td align="right" bgcolor="#FFFFFF">0,825 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#A8D08D">688,000 (Δ = -239,000)</td><td align="right" bgcolor="#FFFFFF">688,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#A8D08D">0,672 (Δ = -0,233)</td><td align="right" bgcolor="#FFFFFF">0,672</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 4,145 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,132 ns</td><td align="right" bgcolor="#FFFFFF">1,818 ns</td><td align="right" bgcolor="#FFFFFF">0,530 ns</td><td align="right" bgcolor="#FFFFFF">0,735 ns</td><td align="right" bgcolor="#FFFFFF">0,407 ns</td><td align="right" bgcolor="#FFFFFF">3,250 ns</td><td align="right" bgcolor="#FFFFFF">4,552 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 27,154 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,158 ns</td><td align="right" bgcolor="#FFFFFF">10,125 ns</td><td align="right" bgcolor="#FFFFFF">10,229 ns</td><td align="right" bgcolor="#FFFFFF">9,957 ns</td><td align="right" bgcolor="#FFFFFF">9,568 ns</td><td align="right" bgcolor="#FFFFFF">36,722 ns</td><td align="right" bgcolor="#FFFFFF">17,619 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-57,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#A8D08D">24,000 (Δ = -32,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#A8D08D">0,023 (Δ = -0,031)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **6.0.0**

Slowest: 5.12.0

Δ: 19,536 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,782 ns</td><td align="right" bgcolor="#FFFFFF">10,969 ns</td><td align="right" bgcolor="#FFFFFF">7,782 ns</td><td align="right" bgcolor="#FFFFFF">7,662 ns</td><td align="right" bgcolor="#FFFFFF">7,758 ns</td><td align="right" bgcolor="#FFFFFF">23,403 ns</td><td align="right" bgcolor="#FFFFFF">3,867 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,1 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">32,000 (Δ = -4,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -32,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,031 (Δ = -0,004)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,031)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 319,514 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+159,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">241,597 ns</td><td align="right" bgcolor="#FFFFFF">216,552 ns</td><td align="right" bgcolor="#FFFFFF">200,111 ns</td><td align="right" bgcolor="#FFFFFF">204,704 ns</td><td align="right" bgcolor="#FFFFFF">200,429 ns</td><td align="right" bgcolor="#FF4949">519,625 ns (Δ = +319,196 ns)</td><td align="right" bgcolor="#FFFFFF">287,344 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td><td align="right" bgcolor="#FFFFFF">0,217 μs</td><td align="right" bgcolor="#FFFFFF">0,200 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,200 μs</td><td align="right" bgcolor="#FFFFFF">0,520 μs</td><td align="right" bgcolor="#FFFFFF">0,287 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#A8D08D">144,000 (Δ = -20,000)</td><td align="right" bgcolor="#FFFFFF">144,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#A8D08D">0,141 (Δ = -0,020)</td><td align="right" bgcolor="#FFFFFF">0,141</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 173,354 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">536,131 ns</td><td align="right" bgcolor="#FFFFFF">419,007 ns</td><td align="right" bgcolor="#FFFFFF">426,910 ns</td><td align="right" bgcolor="#FFFFFF">457,375 ns</td><td align="right" bgcolor="#FFFFFF">409,255 ns</td><td align="right" bgcolor="#FFFFFF">582,609 ns</td><td align="right" bgcolor="#FFFFFF">452,616 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,536 μs</td><td align="right" bgcolor="#FFFFFF">0,419 μs</td><td align="right" bgcolor="#FFFFFF">0,427 μs</td><td align="right" bgcolor="#FFFFFF">0,457 μs</td><td align="right" bgcolor="#FFFFFF">0,409 μs</td><td align="right" bgcolor="#FFFFFF">0,583 μs</td><td align="right" bgcolor="#FFFFFF">0,453 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,1 %</td><td align="right" bgcolor="#A8D08D">-10,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">353,000</td><td align="right" bgcolor="#FFFFFF">353,000</td><td align="right" bgcolor="#FFFFFF">353,000</td><td align="right" bgcolor="#FFFFFF">353,000</td><td align="right" bgcolor="#FFFFFF">353,000</td><td align="right" bgcolor="#A8D08D">296,000 (Δ = -57,000)</td><td align="right" bgcolor="#A8D08D">264,000 (Δ = -32,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,345</td><td align="right" bgcolor="#FFFFFF">0,345</td><td align="right" bgcolor="#FFFFFF">0,345</td><td align="right" bgcolor="#FFFFFF">0,345</td><td align="right" bgcolor="#FFFFFF">0,345</td><td align="right" bgcolor="#A8D08D">0,289 (Δ = -0,056)</td><td align="right" bgcolor="#A8D08D">0,258 (Δ = -0,031)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 201,773 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">443,203 ns</td><td align="right" bgcolor="#FFFFFF">361,283 ns</td><td align="right" bgcolor="#FFFFFF">376,135 ns</td><td align="right" bgcolor="#FFFFFF">358,903 ns</td><td align="right" bgcolor="#FFFFFF">346,144 ns</td><td align="right" bgcolor="#FFFFFF">547,917 ns</td><td align="right" bgcolor="#FFFFFF">494,625 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,443 μs</td><td align="right" bgcolor="#FFFFFF">0,361 μs</td><td align="right" bgcolor="#FFFFFF">0,376 μs</td><td align="right" bgcolor="#FFFFFF">0,359 μs</td><td align="right" bgcolor="#FFFFFF">0,346 μs</td><td align="right" bgcolor="#FFFFFF">0,548 μs</td><td align="right" bgcolor="#FFFFFF">0,495 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,0 %</td><td align="right" bgcolor="#A8D08D">-10,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#A8D08D">320,000 (Δ = -28,000)</td><td align="right" bgcolor="#A8D08D">288,000 (Δ = -32,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#A8D08D">0,313 (Δ = -0,027)</td><td align="right" bgcolor="#A8D08D">0,281 (Δ = -0,031)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


## <a name="Log_Error_Benchmark"></a>Log_Error_Benchmark

### <a name="Log_Error_Benchmark_Log_Error_Format_1_Format_Argument"></a>Log_Error_Format_1_Format_Argument

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 177,603 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">517,781 ns</td><td align="right" bgcolor="#FFFFFF">421,337 ns</td><td align="right" bgcolor="#FFFFFF">432,167 ns</td><td align="right" bgcolor="#FFFFFF">402,147 ns</td><td align="right" bgcolor="#FFFFFF">394,788 ns</td><td align="right" bgcolor="#FFFFFF">572,391 ns</td><td align="right" bgcolor="#FFFFFF">495,446 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,518 μs</td><td align="right" bgcolor="#FFFFFF">0,421 μs</td><td align="right" bgcolor="#FFFFFF">0,432 μs</td><td align="right" bgcolor="#FFFFFF">0,402 μs</td><td align="right" bgcolor="#FFFFFF">0,395 μs</td><td align="right" bgcolor="#FFFFFF">0,572 μs</td><td align="right" bgcolor="#FFFFFF">0,495 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#A8D08D">264,000 (Δ = -43,000)</td><td align="right" bgcolor="#FFFFFF">264,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#A8D08D">0,258 (Δ = -0,042)</td><td align="right" bgcolor="#FFFFFF">0,258</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_2_Format_Arguments"></a>Log_Error_Format_2_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 121,727 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">566,379 ns</td><td align="right" bgcolor="#FFFFFF">511,879 ns</td><td align="right" bgcolor="#FFFFFF">503,212 ns</td><td align="right" bgcolor="#FFFFFF">497,400 ns</td><td align="right" bgcolor="#FFFFFF">482,735 ns</td><td align="right" bgcolor="#FFFFFF">604,463 ns</td><td align="right" bgcolor="#FFFFFF">575,086 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,566 μs</td><td align="right" bgcolor="#FFFFFF">0,512 μs</td><td align="right" bgcolor="#FFFFFF">0,503 μs</td><td align="right" bgcolor="#FFFFFF">0,497 μs</td><td align="right" bgcolor="#FFFFFF">0,483 μs</td><td align="right" bgcolor="#FFFFFF">0,604 μs</td><td align="right" bgcolor="#FFFFFF">0,575 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#A8D08D">304,000 (Δ = -75,000)</td><td align="right" bgcolor="#FFFFFF">304,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#A8D08D">0,297 (Δ = -0,073)</td><td align="right" bgcolor="#FFFFFF">0,297</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_3_Format_Arguments"></a>Log_Error_Format_3_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 177,117 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">743,517 ns</td><td align="right" bgcolor="#FFFFFF">606,580 ns</td><td align="right" bgcolor="#FFFFFF">630,212 ns</td><td align="right" bgcolor="#FFFFFF">603,281 ns</td><td align="right" bgcolor="#FFFFFF">566,401 ns</td><td align="right" bgcolor="#FFFFFF">682,474 ns</td><td align="right" bgcolor="#FFFFFF">616,111 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,744 μs</td><td align="right" bgcolor="#FFFFFF">0,607 μs</td><td align="right" bgcolor="#FFFFFF">0,630 μs</td><td align="right" bgcolor="#FFFFFF">0,603 μs</td><td align="right" bgcolor="#FFFFFF">0,566 μs</td><td align="right" bgcolor="#FFFFFF">0,682 μs</td><td align="right" bgcolor="#FFFFFF">0,616 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">344,000 (Δ = -107,000)</td><td align="right" bgcolor="#FFFFFF">344,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,336 (Δ = -0,104)</td><td align="right" bgcolor="#FFFFFF">0,336</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_4_Format_Arguments"></a>Log_Error_Format_4_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 148,436 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">847,703 ns</td><td align="right" bgcolor="#FFFFFF">725,284 ns</td><td align="right" bgcolor="#FFFFFF">744,721 ns</td><td align="right" bgcolor="#FFFFFF">758,090 ns</td><td align="right" bgcolor="#FFFFFF">699,267 ns</td><td align="right" bgcolor="#FFFFFF">752,731 ns</td><td align="right" bgcolor="#FFFFFF">726,833 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,848 μs</td><td align="right" bgcolor="#FFFFFF">0,725 μs</td><td align="right" bgcolor="#FFFFFF">0,745 μs</td><td align="right" bgcolor="#FFFFFF">0,758 μs</td><td align="right" bgcolor="#FFFFFF">0,699 μs</td><td align="right" bgcolor="#FFFFFF">0,753 μs</td><td align="right" bgcolor="#FFFFFF">0,727 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#A8D08D">440,000 (Δ = -139,000)</td><td align="right" bgcolor="#FFFFFF">440,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#A8D08D">0,430 (Δ = -0,136)</td><td align="right" bgcolor="#FFFFFF">0,430</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_5_Format_Arguments"></a>Log_Error_Format_5_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 186,852 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">979,202 ns</td><td align="right" bgcolor="#FFFFFF">833,677 ns</td><td align="right" bgcolor="#FFFFFF">822,386 ns</td><td align="right" bgcolor="#FFFFFF">862,192 ns</td><td align="right" bgcolor="#FFFFFF">792,350 ns</td><td align="right" bgcolor="#FFFFFF">821,569 ns</td><td align="right" bgcolor="#FFFFFF">809,429 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">0,834 μs</td><td align="right" bgcolor="#FFFFFF">0,822 μs</td><td align="right" bgcolor="#FFFFFF">0,862 μs</td><td align="right" bgcolor="#FFFFFF">0,792 μs</td><td align="right" bgcolor="#FFFFFF">0,822 μs</td><td align="right" bgcolor="#FFFFFF">0,809 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#A8D08D">488,000 (Δ = -172,000)</td><td align="right" bgcolor="#FFFFFF">488,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,168)</td><td align="right" bgcolor="#FFFFFF">0,477</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_6_Format_Arguments"></a>Log_Error_Format_6_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 258,516 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1148,504 ns</td><td align="right" bgcolor="#FFFFFF">1029,096 ns</td><td align="right" bgcolor="#FFFFFF">1012,311 ns</td><td align="right" bgcolor="#FFFFFF">994,338 ns</td><td align="right" bgcolor="#FFFFFF">889,988 ns</td><td align="right" bgcolor="#FFFFFF">937,952 ns</td><td align="right" bgcolor="#FFFFFF">910,980 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,149 μs</td><td align="right" bgcolor="#FFFFFF">1,029 μs</td><td align="right" bgcolor="#FFFFFF">1,012 μs</td><td align="right" bgcolor="#FFFFFF">0,994 μs</td><td align="right" bgcolor="#FFFFFF">0,890 μs</td><td align="right" bgcolor="#FFFFFF">0,938 μs</td><td align="right" bgcolor="#FFFFFF">0,911 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#A8D08D">632,000 (Δ = -203,000)</td><td align="right" bgcolor="#FFFFFF">632,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#A8D08D">0,617 (Δ = -0,198)</td><td align="right" bgcolor="#FFFFFF">0,617</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_7_Format_Arguments"></a>Log_Error_Format_7_Format_Arguments

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 482,597 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1407,760 ns</td><td align="right" bgcolor="#A8D08D">1047,310 ns (Δ = -360,450 ns)</td><td align="right" bgcolor="#FFFFFF">1052,223 ns</td><td align="right" bgcolor="#FFFFFF">1066,279 ns</td><td align="right" bgcolor="#FFFFFF">1004,283 ns</td><td align="right" bgcolor="#FFFFFF">964,497 ns</td><td align="right" bgcolor="#FFFFFF">925,163 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,408 μs</td><td align="right" bgcolor="#FFFFFF">1,047 μs</td><td align="right" bgcolor="#FFFFFF">1,052 μs</td><td align="right" bgcolor="#FFFFFF">1,066 μs</td><td align="right" bgcolor="#FFFFFF">1,004 μs</td><td align="right" bgcolor="#FFFFFF">0,964 μs</td><td align="right" bgcolor="#FFFFFF">0,925 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#A8D08D">688,000 (Δ = -239,000)</td><td align="right" bgcolor="#FFFFFF">688,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#A8D08D">0,672 (Δ = -0,233)</td><td align="right" bgcolor="#FFFFFF">0,672</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Info_Benchmark"></a>Log_Info_Benchmark

### <a name="Log_Info_Benchmark_Log_Info_Format_1_Format_Argument"></a>Log_Info_Format_1_Format_Argument

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 208,414 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">571,041 ns</td><td align="right" bgcolor="#FFFFFF">414,609 ns</td><td align="right" bgcolor="#FFFFFF">432,935 ns</td><td align="right" bgcolor="#FFFFFF">418,941 ns</td><td align="right" bgcolor="#FFFFFF">439,040 ns</td><td align="right" bgcolor="#FFFFFF">623,023 ns</td><td align="right" bgcolor="#FFFFFF">521,944 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,571 μs</td><td align="right" bgcolor="#FFFFFF">0,415 μs</td><td align="right" bgcolor="#FFFFFF">0,433 μs</td><td align="right" bgcolor="#FFFFFF">0,419 μs</td><td align="right" bgcolor="#FFFFFF">0,439 μs</td><td align="right" bgcolor="#FFFFFF">0,623 μs</td><td align="right" bgcolor="#FFFFFF">0,522 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,4 %</td><td align="right" bgcolor="#A8D08D">-10,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#A8D08D">296,000 (Δ = -42,000)</td><td align="right" bgcolor="#A8D08D">264,000 (Δ = -32,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#A8D08D">0,289 (Δ = -0,041)</td><td align="right" bgcolor="#A8D08D">0,258 (Δ = -0,031)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_2_Format_Arguments"></a>Log_Info_Format_2_Format_Arguments

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 180,555 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">700,968 ns</td><td align="right" bgcolor="#FFFFFF">522,306 ns</td><td align="right" bgcolor="#FFFFFF">542,868 ns</td><td align="right" bgcolor="#FFFFFF">520,413 ns</td><td align="right" bgcolor="#FFFFFF">565,145 ns</td><td align="right" bgcolor="#FFFFFF">665,685 ns</td><td align="right" bgcolor="#FFFFFF">570,163 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,701 μs</td><td align="right" bgcolor="#FFFFFF">0,522 μs</td><td align="right" bgcolor="#FFFFFF">0,543 μs</td><td align="right" bgcolor="#FFFFFF">0,520 μs</td><td align="right" bgcolor="#FFFFFF">0,565 μs</td><td align="right" bgcolor="#FFFFFF">0,666 μs</td><td align="right" bgcolor="#FFFFFF">0,570 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,1 %</td><td align="right" bgcolor="#A8D08D">-11,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">420,000</td><td align="right" bgcolor="#FFFFFF">420,000</td><td align="right" bgcolor="#FFFFFF">420,000</td><td align="right" bgcolor="#FFFFFF">420,000</td><td align="right" bgcolor="#FFFFFF">420,000</td><td align="right" bgcolor="#A8D08D">344,000 (Δ = -76,000)</td><td align="right" bgcolor="#A8D08D">304,000 (Δ = -40,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,410</td><td align="right" bgcolor="#FFFFFF">0,410</td><td align="right" bgcolor="#FFFFFF">0,410</td><td align="right" bgcolor="#FFFFFF">0,410</td><td align="right" bgcolor="#FFFFFF">0,410</td><td align="right" bgcolor="#A8D08D">0,336 (Δ = -0,074)</td><td align="right" bgcolor="#A8D08D">0,297 (Δ = -0,039)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_3_Format_Arguments"></a>Log_Info_Format_3_Format_Arguments

#### Performance

Fastest: **5.6.0**

Slowest: 5.0.0

Δ: 142,383 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">755,647 ns</td><td align="right" bgcolor="#FFFFFF">626,719 ns</td><td align="right" bgcolor="#FFFFFF">629,700 ns</td><td align="right" bgcolor="#FFFFFF">613,264 ns</td><td align="right" bgcolor="#FFFFFF">723,418 ns</td><td align="right" bgcolor="#FFFFFF">708,708 ns</td><td align="right" bgcolor="#FFFFFF">632,313 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,756 μs</td><td align="right" bgcolor="#FFFFFF">0,627 μs</td><td align="right" bgcolor="#FFFFFF">0,630 μs</td><td align="right" bgcolor="#FFFFFF">0,613 μs</td><td align="right" bgcolor="#FFFFFF">0,723 μs</td><td align="right" bgcolor="#FFFFFF">0,709 μs</td><td align="right" bgcolor="#FFFFFF">0,632 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,9 %</td><td align="right" bgcolor="#A8D08D">-12,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">502,000</td><td align="right" bgcolor="#FFFFFF">502,000</td><td align="right" bgcolor="#FFFFFF">502,000</td><td align="right" bgcolor="#FFFFFF">502,000</td><td align="right" bgcolor="#FFFFFF">502,000</td><td align="right" bgcolor="#A8D08D">392,000 (Δ = -110,000)</td><td align="right" bgcolor="#A8D08D">344,000 (Δ = -48,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,490</td><td align="right" bgcolor="#FFFFFF">0,490</td><td align="right" bgcolor="#FFFFFF">0,490</td><td align="right" bgcolor="#FFFFFF">0,490</td><td align="right" bgcolor="#FFFFFF">0,490</td><td align="right" bgcolor="#A8D08D">0,383 (Δ = -0,107)</td><td align="right" bgcolor="#A8D08D">0,336 (Δ = -0,047)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_4_Format_Arguments"></a>Log_Info_Format_4_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 255,595 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">959,042 ns</td><td align="right" bgcolor="#FFFFFF">729,418 ns</td><td align="right" bgcolor="#FFFFFF">742,628 ns</td><td align="right" bgcolor="#FFFFFF">726,235 ns</td><td align="right" bgcolor="#FFFFFF">703,447 ns</td><td align="right" bgcolor="#FFFFFF">767,330 ns</td><td align="right" bgcolor="#FFFFFF">735,767 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,959 μs</td><td align="right" bgcolor="#FFFFFF">0,729 μs</td><td align="right" bgcolor="#FFFFFF">0,743 μs</td><td align="right" bgcolor="#FFFFFF">0,726 μs</td><td align="right" bgcolor="#FFFFFF">0,703 μs</td><td align="right" bgcolor="#FFFFFF">0,767 μs</td><td align="right" bgcolor="#FFFFFF">0,736 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#A8D08D">440,000 (Δ = -139,000)</td><td align="right" bgcolor="#FFFFFF">440,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#A8D08D">0,430 (Δ = -0,136)</td><td align="right" bgcolor="#FFFFFF">0,430</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_5_Format_Arguments"></a>Log_Info_Format_5_Format_Arguments

#### Performance

Fastest: **6.0.0**

Slowest: 5.9.0

Δ: 287,387 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">945,676 ns</td><td align="right" bgcolor="#FFFFFF">848,041 ns</td><td align="right" bgcolor="#FFFFFF">845,746 ns</td><td align="right" bgcolor="#FFFFFF">824,003 ns</td><td align="right" bgcolor="#FF4949">1086,160 ns (Δ = +262,157 ns)</td><td align="right" bgcolor="#FFFFFF">840,741 ns</td><td align="right" bgcolor="#FFFFFF">798,773 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,946 μs</td><td align="right" bgcolor="#FFFFFF">0,848 μs</td><td align="right" bgcolor="#FFFFFF">0,846 μs</td><td align="right" bgcolor="#FFFFFF">0,824 μs</td><td align="right" bgcolor="#FFFFFF">1,086 μs</td><td align="right" bgcolor="#FFFFFF">0,841 μs</td><td align="right" bgcolor="#FFFFFF">0,799 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#A8D08D">488,000 (Δ = -172,000)</td><td align="right" bgcolor="#FFFFFF">488,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,168)</td><td align="right" bgcolor="#FFFFFF">0,477</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_6_Format_Arguments"></a>Log_Info_Format_6_Format_Arguments

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 320,974 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+30,3 %</td><td align="right" bgcolor="#A8D08D">-27,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1093,313 ns</td><td align="right" bgcolor="#FFFFFF">957,369 ns</td><td align="right" bgcolor="#FFFFFF">924,933 ns</td><td align="right" bgcolor="#FFFFFF">909,808 ns</td><td align="right" bgcolor="#FF4949">1185,308 ns (Δ = +275,500 ns)</td><td align="right" bgcolor="#A8D08D">864,334 ns (Δ = -320,974 ns)</td><td align="right" bgcolor="#FFFFFF">893,780 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,093 μs</td><td align="right" bgcolor="#FFFFFF">0,957 μs</td><td align="right" bgcolor="#FFFFFF">0,925 μs</td><td align="right" bgcolor="#FFFFFF">0,910 μs</td><td align="right" bgcolor="#FFFFFF">1,185 μs</td><td align="right" bgcolor="#FFFFFF">0,864 μs</td><td align="right" bgcolor="#FFFFFF">0,894 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-27,8 %</td><td align="right" bgcolor="#FF4949">+17,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#A8D08D">536,000 (Δ = -206,000)</td><td align="right" bgcolor="#FF4949">632,000 (Δ = +96,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#A8D08D">0,523 (Δ = -0,201)</td><td align="right" bgcolor="#FF4949">0,617 (Δ = +0,094)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments"></a>Log_Info_Format_7_Format_Arguments

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 293,797 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1198,756 ns</td><td align="right" bgcolor="#FFFFFF">984,789 ns</td><td align="right" bgcolor="#FFFFFF">994,196 ns</td><td align="right" bgcolor="#FFFFFF">1210,922 ns</td><td align="right" bgcolor="#A8D08D">948,898 ns (Δ = -262,023 ns)</td><td align="right" bgcolor="#FFFFFF">917,125 ns</td><td align="right" bgcolor="#FFFFFF">917,264 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,199 μs</td><td align="right" bgcolor="#FFFFFF">0,985 μs</td><td align="right" bgcolor="#FFFFFF">0,994 μs</td><td align="right" bgcolor="#FFFFFF">1,211 μs</td><td align="right" bgcolor="#FFFFFF">0,949 μs</td><td align="right" bgcolor="#FFFFFF">0,917 μs</td><td align="right" bgcolor="#FFFFFF">0,917 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,7 %</td><td align="right" bgcolor="#FF4949">+17,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#A8D08D">584,000 (Δ = -235,000)</td><td align="right" bgcolor="#FF4949">688,000 (Δ = +104,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#A8D08D">0,570 (Δ = -0,229)</td><td align="right" bgcolor="#FF4949">0,672 (Δ = +0,102)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="Log_Status_Benchmark"></a>Log_Status_Benchmark

### <a name="Log_Status_Benchmark_Log_Status_Format_1_Format_Argument"></a>Log_Status_Format_1_Format_Argument

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 164,512 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">448,910 ns</td><td align="right" bgcolor="#FFFFFF">404,261 ns</td><td align="right" bgcolor="#FFFFFF">413,258 ns</td><td align="right" bgcolor="#FFFFFF">462,501 ns</td><td align="right" bgcolor="#FFFFFF">385,284 ns</td><td align="right" bgcolor="#FFFFFF">549,797 ns</td><td align="right" bgcolor="#FFFFFF">538,359 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,449 μs</td><td align="right" bgcolor="#FFFFFF">0,404 μs</td><td align="right" bgcolor="#FFFFFF">0,413 μs</td><td align="right" bgcolor="#FFFFFF">0,463 μs</td><td align="right" bgcolor="#FFFFFF">0,385 μs</td><td align="right" bgcolor="#FFFFFF">0,550 μs</td><td align="right" bgcolor="#FFFFFF">0,538 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#A8D08D">264,000 (Δ = -43,000)</td><td align="right" bgcolor="#FFFFFF">264,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#A8D08D">0,258 (Δ = -0,042)</td><td align="right" bgcolor="#FFFFFF">0,258</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_2_Format_Arguments"></a>Log_Status_Format_2_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 282,105 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">654,867 ns</td><td align="right" bgcolor="#FFFFFF">554,231 ns</td><td align="right" bgcolor="#FFFFFF">763,130 ns</td><td align="right" bgcolor="#FFFFFF">604,651 ns</td><td align="right" bgcolor="#FFFFFF">481,025 ns</td><td align="right" bgcolor="#FFFFFF">609,219 ns</td><td align="right" bgcolor="#FFFFFF">594,649 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,655 μs</td><td align="right" bgcolor="#FFFFFF">0,554 μs</td><td align="right" bgcolor="#FFFFFF">0,763 μs</td><td align="right" bgcolor="#FFFFFF">0,605 μs</td><td align="right" bgcolor="#FFFFFF">0,481 μs</td><td align="right" bgcolor="#FFFFFF">0,609 μs</td><td align="right" bgcolor="#FFFFFF">0,595 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#A8D08D">304,000 (Δ = -75,000)</td><td align="right" bgcolor="#FFFFFF">304,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#A8D08D">0,297 (Δ = -0,073)</td><td align="right" bgcolor="#FFFFFF">0,297</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_3_Format_Arguments"></a>Log_Status_Format_3_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 367,898 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+58,0 %</td><td align="right" bgcolor="#A8D08D">-36,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">819,730 ns</td><td align="right" bgcolor="#FFFFFF">607,212 ns</td><td align="right" bgcolor="#FF4949">959,360 ns (Δ = +352,148 ns)</td><td align="right" bgcolor="#A8D08D">611,467 ns (Δ = -347,893 ns)</td><td align="right" bgcolor="#FFFFFF">591,462 ns</td><td align="right" bgcolor="#FFFFFF">667,500 ns</td><td align="right" bgcolor="#FFFFFF">631,350 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,820 μs</td><td align="right" bgcolor="#FFFFFF">0,607 μs</td><td align="right" bgcolor="#FFFFFF">0,959 μs</td><td align="right" bgcolor="#FFFFFF">0,611 μs</td><td align="right" bgcolor="#FFFFFF">0,591 μs</td><td align="right" bgcolor="#FFFFFF">0,668 μs</td><td align="right" bgcolor="#FFFFFF">0,631 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">344,000 (Δ = -107,000)</td><td align="right" bgcolor="#FFFFFF">344,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,336 (Δ = -0,104)</td><td align="right" bgcolor="#FFFFFF">0,336</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments"></a>Log_Status_Format_4_Format_Arguments

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 295,323 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,7 %</td><td align="right" bgcolor="#A8D08D">-29,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">794,346 ns</td><td align="right" bgcolor="#FFFFFF">752,307 ns</td><td align="right" bgcolor="#FF4949">1013,355 ns (Δ = +261,048 ns)</td><td align="right" bgcolor="#A8D08D">718,031 ns (Δ = -295,323 ns)</td><td align="right" bgcolor="#FFFFFF">726,288 ns</td><td align="right" bgcolor="#FFFFFF">754,069 ns</td><td align="right" bgcolor="#FFFFFF">719,402 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,794 μs</td><td align="right" bgcolor="#FFFFFF">0,752 μs</td><td align="right" bgcolor="#FFFFFF">1,013 μs</td><td align="right" bgcolor="#FFFFFF">0,718 μs</td><td align="right" bgcolor="#FFFFFF">0,726 μs</td><td align="right" bgcolor="#FFFFFF">0,754 μs</td><td align="right" bgcolor="#FFFFFF">0,719 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#A8D08D">440,000 (Δ = -139,000)</td><td align="right" bgcolor="#FFFFFF">440,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#A8D08D">0,430 (Δ = -0,136)</td><td align="right" bgcolor="#FFFFFF">0,430</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_5_Format_Arguments"></a>Log_Status_Format_5_Format_Arguments

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 188,472 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">967,778 ns</td><td align="right" bgcolor="#FFFFFF">841,946 ns</td><td align="right" bgcolor="#FFFFFF">856,500 ns</td><td align="right" bgcolor="#FFFFFF">821,287 ns</td><td align="right" bgcolor="#FFFFFF">946,514 ns</td><td align="right" bgcolor="#FFFFFF">840,412 ns</td><td align="right" bgcolor="#FFFFFF">779,306 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,968 μs</td><td align="right" bgcolor="#FFFFFF">0,842 μs</td><td align="right" bgcolor="#FFFFFF">0,857 μs</td><td align="right" bgcolor="#FFFFFF">0,821 μs</td><td align="right" bgcolor="#FFFFFF">0,947 μs</td><td align="right" bgcolor="#FFFFFF">0,840 μs</td><td align="right" bgcolor="#FFFFFF">0,779 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#A8D08D">488,000 (Δ = -172,000)</td><td align="right" bgcolor="#FFFFFF">488,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,168)</td><td align="right" bgcolor="#FFFFFF">0,477</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_6_Format_Arguments"></a>Log_Status_Format_6_Format_Arguments

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 305,554 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1175,455 ns</td><td align="right" bgcolor="#FFFFFF">964,080 ns</td><td align="right" bgcolor="#FFFFFF">979,068 ns</td><td align="right" bgcolor="#FFFFFF">981,465 ns</td><td align="right" bgcolor="#FFFFFF">993,799 ns</td><td align="right" bgcolor="#FFFFFF">935,472 ns</td><td align="right" bgcolor="#FFFFFF">869,901 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,175 μs</td><td align="right" bgcolor="#FFFFFF">0,964 μs</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">0,981 μs</td><td align="right" bgcolor="#FFFFFF">0,994 μs</td><td align="right" bgcolor="#FFFFFF">0,935 μs</td><td align="right" bgcolor="#FFFFFF">0,870 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#A8D08D">632,000 (Δ = -203,000)</td><td align="right" bgcolor="#FFFFFF">632,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#A8D08D">0,617 (Δ = -0,198)</td><td align="right" bgcolor="#FFFFFF">0,617</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_7_Format_Arguments"></a>Log_Status_Format_7_Format_Arguments

#### Performance

Fastest: **6.0.0**

Slowest: 5.4.0

Δ: 301,835 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1224,832 ns</td><td align="right" bgcolor="#FFFFFF">1235,272 ns</td><td align="right" bgcolor="#FFFFFF">1068,751 ns</td><td align="right" bgcolor="#FFFFFF">1080,064 ns</td><td align="right" bgcolor="#FFFFFF">1003,274 ns</td><td align="right" bgcolor="#FFFFFF">970,326 ns</td><td align="right" bgcolor="#FFFFFF">933,438 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,225 μs</td><td align="right" bgcolor="#FFFFFF">1,235 μs</td><td align="right" bgcolor="#FFFFFF">1,069 μs</td><td align="right" bgcolor="#FFFFFF">1,080 μs</td><td align="right" bgcolor="#FFFFFF">1,003 μs</td><td align="right" bgcolor="#FFFFFF">0,970 μs</td><td align="right" bgcolor="#FFFFFF">0,933 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#A8D08D">688,000 (Δ = -239,000)</td><td align="right" bgcolor="#FFFFFF">688,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#A8D08D">0,672 (Δ = -0,233)</td><td align="right" bgcolor="#FFFFFF">0,672</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Warning_Benchmark"></a>Log_Warning_Benchmark

### <a name="Log_Warning_Benchmark_Log_Warning_Format_1_Format_Argument"></a>Log_Warning_Format_1_Format_Argument

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 173,465 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">470,881 ns</td><td align="right" bgcolor="#FFFFFF">481,663 ns</td><td align="right" bgcolor="#FFFFFF">417,198 ns</td><td align="right" bgcolor="#FFFFFF">404,462 ns</td><td align="right" bgcolor="#FFFFFF">390,523 ns</td><td align="right" bgcolor="#FFFFFF">563,988 ns</td><td align="right" bgcolor="#FFFFFF">544,929 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,471 μs</td><td align="right" bgcolor="#FFFFFF">0,482 μs</td><td align="right" bgcolor="#FFFFFF">0,417 μs</td><td align="right" bgcolor="#FFFFFF">0,404 μs</td><td align="right" bgcolor="#FFFFFF">0,391 μs</td><td align="right" bgcolor="#FFFFFF">0,564 μs</td><td align="right" bgcolor="#FFFFFF">0,545 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#A8D08D">264,000 (Δ = -43,000)</td><td align="right" bgcolor="#FFFFFF">264,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#A8D08D">0,258 (Δ = -0,042)</td><td align="right" bgcolor="#FFFFFF">0,258</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_2_Format_Arguments"></a>Log_Warning_Format_2_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 177,044 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">587,533 ns</td><td align="right" bgcolor="#FFFFFF">626,102 ns</td><td align="right" bgcolor="#FFFFFF">515,884 ns</td><td align="right" bgcolor="#FFFFFF">517,101 ns</td><td align="right" bgcolor="#FFFFFF">460,651 ns</td><td align="right" bgcolor="#FFFFFF">637,694 ns</td><td align="right" bgcolor="#FFFFFF">590,225 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,588 μs</td><td align="right" bgcolor="#FFFFFF">0,626 μs</td><td align="right" bgcolor="#FFFFFF">0,516 μs</td><td align="right" bgcolor="#FFFFFF">0,517 μs</td><td align="right" bgcolor="#FFFFFF">0,461 μs</td><td align="right" bgcolor="#FFFFFF">0,638 μs</td><td align="right" bgcolor="#FFFFFF">0,590 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#FFFFFF">379,000</td><td align="right" bgcolor="#A8D08D">304,000 (Δ = -75,000)</td><td align="right" bgcolor="#FFFFFF">304,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#FFFFFF">0,370</td><td align="right" bgcolor="#A8D08D">0,297 (Δ = -0,073)</td><td align="right" bgcolor="#FFFFFF">0,297</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_3_Format_Arguments"></a>Log_Warning_Format_3_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 90,637 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">647,463 ns</td><td align="right" bgcolor="#FFFFFF">641,253 ns</td><td align="right" bgcolor="#FFFFFF">616,230 ns</td><td align="right" bgcolor="#FFFFFF">635,962 ns</td><td align="right" bgcolor="#FFFFFF">575,918 ns</td><td align="right" bgcolor="#FFFFFF">666,555 ns</td><td align="right" bgcolor="#FFFFFF">645,422 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,647 μs</td><td align="right" bgcolor="#FFFFFF">0,641 μs</td><td align="right" bgcolor="#FFFFFF">0,616 μs</td><td align="right" bgcolor="#FFFFFF">0,636 μs</td><td align="right" bgcolor="#FFFFFF">0,576 μs</td><td align="right" bgcolor="#FFFFFF">0,667 μs</td><td align="right" bgcolor="#FFFFFF">0,645 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">344,000 (Δ = -107,000)</td><td align="right" bgcolor="#FFFFFF">344,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,336 (Δ = -0,104)</td><td align="right" bgcolor="#FFFFFF">0,336</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_4_Format_Arguments"></a>Log_Warning_Format_4_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 112,635 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">806,245 ns</td><td align="right" bgcolor="#FFFFFF">719,491 ns</td><td align="right" bgcolor="#FFFFFF">722,911 ns</td><td align="right" bgcolor="#FFFFFF">778,572 ns</td><td align="right" bgcolor="#FFFFFF">693,611 ns</td><td align="right" bgcolor="#FFFFFF">763,472 ns</td><td align="right" bgcolor="#FFFFFF">744,724 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,806 μs</td><td align="right" bgcolor="#FFFFFF">0,719 μs</td><td align="right" bgcolor="#FFFFFF">0,723 μs</td><td align="right" bgcolor="#FFFFFF">0,779 μs</td><td align="right" bgcolor="#FFFFFF">0,694 μs</td><td align="right" bgcolor="#FFFFFF">0,763 μs</td><td align="right" bgcolor="#FFFFFF">0,745 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#FFFFFF">579,000</td><td align="right" bgcolor="#A8D08D">440,000 (Δ = -139,000)</td><td align="right" bgcolor="#FFFFFF">440,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#FFFFFF">0,565</td><td align="right" bgcolor="#A8D08D">0,430 (Δ = -0,136)</td><td align="right" bgcolor="#FFFFFF">0,430</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_5_Format_Arguments"></a>Log_Warning_Format_5_Format_Arguments

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 213,195 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1017,707 ns</td><td align="right" bgcolor="#FFFFFF">834,405 ns</td><td align="right" bgcolor="#FFFFFF">916,789 ns</td><td align="right" bgcolor="#FFFFFF">911,324 ns</td><td align="right" bgcolor="#FFFFFF">822,308 ns</td><td align="right" bgcolor="#FFFFFF">840,177 ns</td><td align="right" bgcolor="#FFFFFF">804,513 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,018 μs</td><td align="right" bgcolor="#FFFFFF">0,834 μs</td><td align="right" bgcolor="#FFFFFF">0,917 μs</td><td align="right" bgcolor="#FFFFFF">0,911 μs</td><td align="right" bgcolor="#FFFFFF">0,822 μs</td><td align="right" bgcolor="#FFFFFF">0,840 μs</td><td align="right" bgcolor="#FFFFFF">0,805 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#FFFFFF">660,000</td><td align="right" bgcolor="#A8D08D">488,000 (Δ = -172,000)</td><td align="right" bgcolor="#FFFFFF">488,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#FFFFFF">0,645</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,168)</td><td align="right" bgcolor="#FFFFFF">0,477</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_6_Format_Arguments"></a>Log_Warning_Format_6_Format_Arguments

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 251,599 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1168,198 ns</td><td align="right" bgcolor="#FFFFFF">1001,528 ns</td><td align="right" bgcolor="#FFFFFF">1068,740 ns</td><td align="right" bgcolor="#FFFFFF">972,957 ns</td><td align="right" bgcolor="#FFFFFF">944,274 ns</td><td align="right" bgcolor="#FFFFFF">937,255 ns</td><td align="right" bgcolor="#FFFFFF">916,599 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,168 μs</td><td align="right" bgcolor="#FFFFFF">1,002 μs</td><td align="right" bgcolor="#FFFFFF">1,069 μs</td><td align="right" bgcolor="#FFFFFF">0,973 μs</td><td align="right" bgcolor="#FFFFFF">0,944 μs</td><td align="right" bgcolor="#FFFFFF">0,937 μs</td><td align="right" bgcolor="#FFFFFF">0,917 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#FFFFFF">835,000</td><td align="right" bgcolor="#A8D08D">632,000 (Δ = -203,000)</td><td align="right" bgcolor="#FFFFFF">632,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#FFFFFF">0,815</td><td align="right" bgcolor="#A8D08D">0,617 (Δ = -0,198)</td><td align="right" bgcolor="#FFFFFF">0,617</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments"></a>Log_Warning_Format_7_Format_Arguments

#### Performance

Fastest: **5.12.0**

Slowest: 6.0.0

Δ: 361,365 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+37,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1195,470 ns</td><td align="right" bgcolor="#FFFFFF">1094,397 ns</td><td align="right" bgcolor="#FFFFFF">1253,894 ns</td><td align="right" bgcolor="#FFFFFF">1078,907 ns</td><td align="right" bgcolor="#FFFFFF">993,219 ns</td><td align="right" bgcolor="#FFFFFF">974,097 ns</td><td align="right" bgcolor="#FF4949">1335,463 ns (Δ = +361,365 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,195 μs</td><td align="right" bgcolor="#FFFFFF">1,094 μs</td><td align="right" bgcolor="#FFFFFF">1,254 μs</td><td align="right" bgcolor="#FFFFFF">1,079 μs</td><td align="right" bgcolor="#FFFFFF">0,993 μs</td><td align="right" bgcolor="#FFFFFF">0,974 μs</td><td align="right" bgcolor="#FFFFFF">1,335 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#FFFFFF">927,000</td><td align="right" bgcolor="#A8D08D">688,000 (Δ = -239,000)</td><td align="right" bgcolor="#FFFFFF">688,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#FFFFFF">0,905</td><td align="right" bgcolor="#A8D08D">0,672 (Δ = -0,233)</td><td align="right" bgcolor="#FFFFFF">0,672</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 844,045 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-27,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2352,851 ns</td><td align="right" bgcolor="#A8D08D">2007,560 ns (Δ = -345,292 ns)</td><td align="right" bgcolor="#FFFFFF">1991,017 ns</td><td align="right" bgcolor="#FFFFFF">2047,940 ns</td><td align="right" bgcolor="#FFFFFF">2071,365 ns</td><td align="right" bgcolor="#A8D08D">1508,807 ns (Δ = -562,558 ns)</td><td align="right" bgcolor="#FFFFFF">1558,430 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,353 μs</td><td align="right" bgcolor="#FFFFFF">2,008 μs</td><td align="right" bgcolor="#FFFFFF">1,991 μs</td><td align="right" bgcolor="#FFFFFF">2,048 μs</td><td align="right" bgcolor="#FFFFFF">2,071 μs</td><td align="right" bgcolor="#FFFFFF">1,509 μs</td><td align="right" bgcolor="#FFFFFF">1,558 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#A8D08D">248,000 (Δ = -100,000)</td><td align="right" bgcolor="#FFFFFF">248,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#A8D08D">0,242 (Δ = -0,098)</td><td align="right" bgcolor="#FFFFFF">0,242</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 2997,176 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+36,3 %</td><td align="right" bgcolor="#A8D08D">-60,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4114,360 ns</td><td align="right" bgcolor="#A8D08D">3572,626 ns (Δ = -541,734 ns)</td><td align="right" bgcolor="#FFFFFF">3429,079 ns</td><td align="right" bgcolor="#FFFFFF">3657,042 ns</td><td align="right" bgcolor="#FF4949">4985,491 ns (Δ = +1328,449 ns)</td><td align="right" bgcolor="#A8D08D">1988,315 ns (Δ = -2997,176 ns)</td><td align="right" bgcolor="#FFFFFF">2014,285 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,114 μs</td><td align="right" bgcolor="#FFFFFF">3,573 μs</td><td align="right" bgcolor="#FFFFFF">3,429 μs</td><td align="right" bgcolor="#FFFFFF">3,657 μs</td><td align="right" bgcolor="#FFFFFF">4,985 μs</td><td align="right" bgcolor="#FFFFFF">1,988 μs</td><td align="right" bgcolor="#FFFFFF">2,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#A8D08D">384,000 (Δ = -343,000)</td><td align="right" bgcolor="#FFFFFF">384,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#A8D08D">0,375 (Δ = -0,335)</td><td align="right" bgcolor="#FFFFFF">0,375</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 2035,019 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-29,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-27,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3731,820 ns</td><td align="right" bgcolor="#FF4949">4051,170 ns (Δ = +319,350 ns)</td><td align="right" bgcolor="#A8D08D">2851,049 ns (Δ = -1200,121 ns)</td><td align="right" bgcolor="#FFFFFF">2739,736 ns</td><td align="right" bgcolor="#FFFFFF">2767,169 ns</td><td align="right" bgcolor="#A8D08D">2016,151 ns (Δ = -751,018 ns)</td><td align="right" bgcolor="#FFFFFF">2020,016 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,732 μs</td><td align="right" bgcolor="#FFFFFF">4,051 μs</td><td align="right" bgcolor="#FFFFFF">2,851 μs</td><td align="right" bgcolor="#FFFFFF">2,740 μs</td><td align="right" bgcolor="#FFFFFF">2,767 μs</td><td align="right" bgcolor="#FFFFFF">2,016 μs</td><td align="right" bgcolor="#FFFFFF">2,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#A8D08D">576,000 (Δ = -100,000)</td><td align="right" bgcolor="#FFFFFF">576,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#A8D08D">0,563 (Δ = -0,098)</td><td align="right" bgcolor="#FFFFFF">0,563</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **6.0.0**

Slowest: 5.9.0

Δ: 1513,902 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+45,4 %</td><td align="right" bgcolor="#A8D08D">-40,0 %</td><td align="right" bgcolor="#A8D08D">-17,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2556,094 ns</td><td align="right" bgcolor="#A8D08D">2077,588 ns (Δ = -478,506 ns)</td><td align="right" bgcolor="#FFFFFF">1989,547 ns</td><td align="right" bgcolor="#FFFFFF">2055,949 ns</td><td align="right" bgcolor="#FF4949">2989,818 ns (Δ = +933,869 ns)</td><td align="right" bgcolor="#A8D08D">1792,742 ns (Δ = -1197,075 ns)</td><td align="right" bgcolor="#A8D08D">1475,916 ns (Δ = -316,827 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,556 μs</td><td align="right" bgcolor="#FFFFFF">2,078 μs</td><td align="right" bgcolor="#FFFFFF">1,990 μs</td><td align="right" bgcolor="#FFFFFF">2,056 μs</td><td align="right" bgcolor="#FFFFFF">2,990 μs</td><td align="right" bgcolor="#FFFFFF">1,793 μs</td><td align="right" bgcolor="#FFFFFF">1,476 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#A8D08D">248,000 (Δ = -100,000)</td><td align="right" bgcolor="#FFFFFF">248,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#A8D08D">0,242 (Δ = -0,098)</td><td align="right" bgcolor="#FFFFFF">0,242</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **6.0.0**

Slowest: 5.9.0

Δ: 3181,127 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+43,1 %</td><td align="right" bgcolor="#A8D08D">-61,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4099,840 ns</td><td align="right" bgcolor="#FFFFFF">3877,144 ns</td><td align="right" bgcolor="#A8D08D">3479,622 ns (Δ = -397,522 ns)</td><td align="right" bgcolor="#FFFFFF">3600,529 ns</td><td align="right" bgcolor="#FF4949">5152,554 ns (Δ = +1552,025 ns)</td><td align="right" bgcolor="#A8D08D">2002,173 ns (Δ = -3150,381 ns)</td><td align="right" bgcolor="#FFFFFF">1971,426 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,100 μs</td><td align="right" bgcolor="#FFFFFF">3,877 μs</td><td align="right" bgcolor="#FFFFFF">3,480 μs</td><td align="right" bgcolor="#FFFFFF">3,601 μs</td><td align="right" bgcolor="#FFFFFF">5,153 μs</td><td align="right" bgcolor="#FFFFFF">2,002 μs</td><td align="right" bgcolor="#FFFFFF">1,971 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#FFFFFF">727,000</td><td align="right" bgcolor="#A8D08D">384,000 (Δ = -343,000)</td><td align="right" bgcolor="#FFFFFF">384,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#FFFFFF">0,710</td><td align="right" bgcolor="#A8D08D">0,375 (Δ = -0,335)</td><td align="right" bgcolor="#FFFFFF">0,375</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **6.0.0**

Slowest: 5.9.0

Δ: 4437,964 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+65,4 %</td><td align="right" bgcolor="#A8D08D">-62,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4983,199 ns</td><td align="right" bgcolor="#A8D08D">4266,971 ns (Δ = -716,228 ns)</td><td align="right" bgcolor="#FFFFFF">4190,502 ns</td><td align="right" bgcolor="#FFFFFF">4261,174 ns</td><td align="right" bgcolor="#FF4949">7047,147 ns (Δ = +2785,973 ns)</td><td align="right" bgcolor="#A8D08D">2663,676 ns (Δ = -4383,471 ns)</td><td align="right" bgcolor="#FFFFFF">2609,183 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,983 μs</td><td align="right" bgcolor="#FFFFFF">4,267 μs</td><td align="right" bgcolor="#FFFFFF">4,191 μs</td><td align="right" bgcolor="#FFFFFF">4,261 μs</td><td align="right" bgcolor="#FFFFFF">7,047 μs</td><td align="right" bgcolor="#FFFFFF">2,664 μs</td><td align="right" bgcolor="#FFFFFF">2,609 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-35,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1096,000</td><td align="right" bgcolor="#FFFFFF">1096,000</td><td align="right" bgcolor="#FFFFFF">1096,000</td><td align="right" bgcolor="#FFFFFF">1096,000</td><td align="right" bgcolor="#FFFFFF">1096,000</td><td align="right" bgcolor="#A8D08D">712,000 (Δ = -384,000)</td><td align="right" bgcolor="#FFFFFF">712,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,070</td><td align="right" bgcolor="#FFFFFF">1,070</td><td align="right" bgcolor="#FFFFFF">1,070</td><td align="right" bgcolor="#FFFFFF">1,070</td><td align="right" bgcolor="#FFFFFF">1,070</td><td align="right" bgcolor="#A8D08D">0,695 (Δ = -0,375)</td><td align="right" bgcolor="#FFFFFF">0,695</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ModelBase_Constructor_Benchmark"></a>ModelBase_Constructor_Benchmark

### <a name="ModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 1092,036 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+37,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2994,817 ns</td><td align="right" bgcolor="#A8D08D">2438,903 ns (Δ = -555,913 ns)</td><td align="right" bgcolor="#FFFFFF">2349,314 ns</td><td align="right" bgcolor="#FF4949">2613,021 ns (Δ = +263,707 ns)</td><td align="right" bgcolor="#FFFFFF">2551,400 ns</td><td align="right" bgcolor="#FFFFFF">2508,782 ns</td><td align="right" bgcolor="#FF4949">3441,349 ns (Δ = +932,567 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,995 μs</td><td align="right" bgcolor="#FFFFFF">2,439 μs</td><td align="right" bgcolor="#FFFFFF">2,349 μs</td><td align="right" bgcolor="#FFFFFF">2,613 μs</td><td align="right" bgcolor="#FFFFFF">2,551 μs</td><td align="right" bgcolor="#FFFFFF">2,509 μs</td><td align="right" bgcolor="#FFFFFF">3,441 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">6.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#FF4949">+64,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">975,000</td><td align="right" bgcolor="#A8D08D">973,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#A8D08D">922,000 (Δ = -51,000)</td><td align="right" bgcolor="#FF4949">1520,000 (Δ = +598,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,952</td><td align="right" bgcolor="#A8D08D">0,950 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#A8D08D">0,900 (Δ = -0,050)</td><td align="right" bgcolor="#FF4949">1,484 (Δ = +0,584)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 290,307 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">446,878 ns</td><td align="right" bgcolor="#FFFFFF">413,428 ns</td><td align="right" bgcolor="#FFFFFF">329,342 ns</td><td align="right" bgcolor="#FFFFFF">331,757 ns</td><td align="right" bgcolor="#FFFFFF">316,125 ns</td><td align="right" bgcolor="#FFFFFF">481,416 ns</td><td align="right" bgcolor="#FFFFFF">606,432 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,447 μs</td><td align="right" bgcolor="#FFFFFF">0,413 μs</td><td align="right" bgcolor="#FFFFFF">0,329 μs</td><td align="right" bgcolor="#FFFFFF">0,332 μs</td><td align="right" bgcolor="#FFFFFF">0,316 μs</td><td align="right" bgcolor="#FFFFFF">0,481 μs</td><td align="right" bgcolor="#FFFFFF">0,606 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+56,1 %</td><td align="right" bgcolor="#A8D08D">-56,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FF4949">128,000 (Δ = +46,000)</td><td align="right" bgcolor="#A8D08D">56,000 (Δ = -72,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FF4949">0,125 (Δ = +0,045)</td><td align="right" bgcolor="#A8D08D">0,055 (Δ = -0,070)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 372,789 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">474,159 ns</td><td align="right" bgcolor="#FFFFFF">345,378 ns</td><td align="right" bgcolor="#FFFFFF">351,560 ns</td><td align="right" bgcolor="#FFFFFF">351,163 ns</td><td align="right" bgcolor="#FFFFFF">394,155 ns</td><td align="right" bgcolor="#FFFFFF">522,570 ns</td><td align="right" bgcolor="#FFFFFF">718,168 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,474 μs</td><td align="right" bgcolor="#FFFFFF">0,345 μs</td><td align="right" bgcolor="#FFFFFF">0,352 μs</td><td align="right" bgcolor="#FFFFFF">0,351 μs</td><td align="right" bgcolor="#FFFFFF">0,394 μs</td><td align="right" bgcolor="#FFFFFF">0,523 μs</td><td align="right" bgcolor="#FFFFFF">0,718 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+56,1 %</td><td align="right" bgcolor="#A8D08D">-56,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FF4949">128,000 (Δ = +46,000)</td><td align="right" bgcolor="#A8D08D">56,000 (Δ = -72,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FF4949">0,125 (Δ = +0,045)</td><td align="right" bgcolor="#A8D08D">0,055 (Δ = -0,070)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.6.0**

Slowest: 6.0.0

Δ: 464,294 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+94,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">311,182 ns</td><td align="right" bgcolor="#FFFFFF">266,051 ns</td><td align="right" bgcolor="#FFFFFF">271,105 ns</td><td align="right" bgcolor="#FFFFFF">257,248 ns</td><td align="right" bgcolor="#FFFFFF">389,960 ns</td><td align="right" bgcolor="#FFFFFF">371,272 ns</td><td align="right" bgcolor="#FF4949">721,543 ns (Δ = +350,271 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,311 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td><td align="right" bgcolor="#FFFFFF">0,271 μs</td><td align="right" bgcolor="#FFFFFF">0,257 μs</td><td align="right" bgcolor="#FFFFFF">0,390 μs</td><td align="right" bgcolor="#FFFFFF">0,371 μs</td><td align="right" bgcolor="#FFFFFF">0,722 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td><td align="right" bgcolor="#FFFFFF">56,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td><td align="right" bgcolor="#FFFFFF">0,055</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ObjectHelper_Benchmark"></a>ObjectHelper_Benchmark

### <a name="ObjectHelper_Benchmark_AreEqual__Same_Reference"></a>AreEqual__Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 4,294 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,331 ns</td><td align="right" bgcolor="#FFFFFF">2,083 ns</td><td align="right" bgcolor="#FFFFFF">1,951 ns</td><td align="right" bgcolor="#FFFFFF">1,958 ns</td><td align="right" bgcolor="#FFFFFF">1,393 ns</td><td align="right" bgcolor="#FFFFFF">5,625 ns</td><td align="right" bgcolor="#FFFFFF">5,128 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Both_Null"></a>AreEqual_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 7,946 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,342 ns</td><td align="right" bgcolor="#FFFFFF">3,136 ns</td><td align="right" bgcolor="#FFFFFF">1,658 ns</td><td align="right" bgcolor="#FFFFFF">1,619 ns</td><td align="right" bgcolor="#FFFFFF">1,466 ns</td><td align="right" bgcolor="#FFFFFF">9,288 ns</td><td align="right" bgcolor="#FFFFFF">5,682 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Not_Same_Reference"></a>AreEqual_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 15,220 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,421 ns</td><td align="right" bgcolor="#FFFFFF">5,503 ns</td><td align="right" bgcolor="#FFFFFF">5,466 ns</td><td align="right" bgcolor="#FFFFFF">5,549 ns</td><td align="right" bgcolor="#FFFFFF">4,849 ns</td><td align="right" bgcolor="#FFFFFF">19,641 ns</td><td align="right" bgcolor="#FFFFFF">11,375 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_One_Null"></a>AreEqual_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 4,353 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,363 ns</td><td align="right" bgcolor="#FFFFFF">2,014 ns</td><td align="right" bgcolor="#FFFFFF">2,322 ns</td><td align="right" bgcolor="#FFFFFF">2,253 ns</td><td align="right" bgcolor="#FFFFFF">1,423 ns</td><td align="right" bgcolor="#FFFFFF">5,716 ns</td><td align="right" bgcolor="#FFFFFF">5,573 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Strings"></a>AreEqual_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 14,412 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,410 ns</td><td align="right" bgcolor="#FFFFFF">6,960 ns</td><td align="right" bgcolor="#FFFFFF">5,803 ns</td><td align="right" bgcolor="#FFFFFF">5,670 ns</td><td align="right" bgcolor="#FFFFFF">5,670 ns</td><td align="right" bgcolor="#FFFFFF">19,821 ns</td><td align="right" bgcolor="#FFFFFF">13,196 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Both_Null"></a>AreEqualReferences_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 6.0.0

Δ: 17,422 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,260 ns</td><td align="right" bgcolor="#FFFFFF">2,011 ns</td><td align="right" bgcolor="#FFFFFF">1,934 ns</td><td align="right" bgcolor="#FFFFFF">1,867 ns</td><td align="right" bgcolor="#FFFFFF">1,473 ns</td><td align="right" bgcolor="#FFFFFF">7,959 ns</td><td align="right" bgcolor="#FFFFFF">18,682 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Not_Same_Reference"></a>AreEqualReferences_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 6.0.0

Δ: 52,039 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">33,374 ns</td><td align="right" bgcolor="#FFFFFF">41,896 ns</td><td align="right" bgcolor="#FFFFFF">35,566 ns</td><td align="right" bgcolor="#FFFFFF">34,383 ns</td><td align="right" bgcolor="#FFFFFF">36,044 ns</td><td align="right" bgcolor="#FFFFFF">61,644 ns</td><td align="right" bgcolor="#FFFFFF">85,413 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ObjectHelper_Benchmark_AreEqualReferences_One_Null"></a>AreEqualReferences_One_Null

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 12,717 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,499 ns</td><td align="right" bgcolor="#FFFFFF">2,091 ns</td><td align="right" bgcolor="#FFFFFF">1,878 ns</td><td align="right" bgcolor="#FFFFFF">1,813 ns</td><td align="right" bgcolor="#FFFFFF">1,473 ns</td><td align="right" bgcolor="#FFFFFF">5,681 ns</td><td align="right" bgcolor="#FFFFFF">14,190 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Same_Reference"></a>AreEqualReferences_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 6.0.0

Δ: 52,841 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,446 ns</td><td align="right" bgcolor="#FFFFFF">1,617 ns</td><td align="right" bgcolor="#FFFFFF">1,644 ns</td><td align="right" bgcolor="#FFFFFF">1,518 ns</td><td align="right" bgcolor="#FFFFFF">1,495 ns</td><td align="right" bgcolor="#FFFFFF">2,841 ns</td><td align="right" bgcolor="#FFFFFF">54,288 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Strings"></a>AreEqualReferences_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 6.0.0

Δ: 74,961 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">50,726 ns</td><td align="right" bgcolor="#FFFFFF">62,628 ns</td><td align="right" bgcolor="#FFFFFF">55,451 ns</td><td align="right" bgcolor="#FFFFFF">56,071 ns</td><td align="right" bgcolor="#FFFFFF">52,823 ns</td><td align="right" bgcolor="#FFFFFF">87,124 ns</td><td align="right" bgcolor="#FFFFFF">125,688 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_IsNull"></a>IsNull

#### Performance

Fastest: **5.0.0**

Slowest: 6.0.0

Δ: 4,416 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,207 ns</td><td align="right" bgcolor="#FFFFFF">0,466 ns</td><td align="right" bgcolor="#FFFFFF">0,239 ns</td><td align="right" bgcolor="#FFFFFF">0,256 ns</td><td align="right" bgcolor="#FFFFFF">0,277 ns</td><td align="right" bgcolor="#FFFFFF">1,875 ns</td><td align="right" bgcolor="#FFFFFF">4,622 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ObjectToStringHelper_Benchmark"></a>ObjectToStringHelper_Benchmark

### <a name="ObjectToStringHelper_Benchmark_ToFullTypeString"></a>ToFullTypeString

#### Performance

Fastest: **5.0.0**

Slowest: 6.0.0

Δ: 126,279 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">70,405 ns</td><td align="right" bgcolor="#FFFFFF">90,045 ns</td><td align="right" bgcolor="#FFFFFF">74,980 ns</td><td align="right" bgcolor="#FFFFFF">73,673 ns</td><td align="right" bgcolor="#FFFFFF">76,673 ns</td><td align="right" bgcolor="#FFFFFF">171,913 ns</td><td align="right" bgcolor="#FFFFFF">196,684 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +2,000)</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,002)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ObjectToStringHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 2278,490 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+24,0 %</td><td align="right" bgcolor="#A8D08D">-22,0 %</td><td align="right" bgcolor="#FF4949">+12,6 %</td><td align="right" bgcolor="#A8D08D">-86,4 %</td><td align="right" bgcolor="#FF4949">+133,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2085,767 ns</td><td align="right" bgcolor="#FF4949">2586,779 ns (Δ = +501,013 ns)</td><td align="right" bgcolor="#A8D08D">2018,363 ns (Δ = -568,417 ns)</td><td align="right" bgcolor="#FF4949">2273,592 ns (Δ = +255,230 ns)</td><td align="right" bgcolor="#A8D08D">308,290 ns (Δ = -1965,303 ns)</td><td align="right" bgcolor="#FF4949">718,756 ns (Δ = +410,467 ns)</td><td align="right" bgcolor="#FFFFFF">598,216 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,086 μs</td><td align="right" bgcolor="#FFFFFF">2,587 μs</td><td align="right" bgcolor="#FFFFFF">2,018 μs</td><td align="right" bgcolor="#FFFFFF">2,274 μs</td><td align="right" bgcolor="#FFFFFF">0,308 μs</td><td align="right" bgcolor="#FFFFFF">0,719 μs</td><td align="right" bgcolor="#FFFFFF">0,598 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-92,8 %</td><td align="right" bgcolor="#A8D08D">-17,9 %</td><td align="right" bgcolor="#A8D08D">-1,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1746,000</td><td align="right" bgcolor="#A8D08D">1715,000 (Δ = -31,000)</td><td align="right" bgcolor="#FFFFFF">1715,000</td><td align="right" bgcolor="#FFFFFF">1715,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -1592,000)</td><td align="right" bgcolor="#A8D08D">101,000 (Δ = -22,000)</td><td align="right" bgcolor="#A8D08D">100,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,705</td><td align="right" bgcolor="#A8D08D">1,675 (Δ = -0,030)</td><td align="right" bgcolor="#FFFFFF">1,675</td><td align="right" bgcolor="#FFFFFF">1,675</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -1,555)</td><td align="right" bgcolor="#A8D08D">0,099 (Δ = -0,021)</td><td align="right" bgcolor="#A8D08D">0,098 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="ObjectToStringHelper_Benchmark_ToTypeString"></a>ToTypeString

#### Performance

Fastest: **5.0.0**

Slowest: 6.0.0

Δ: 97,413 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,512 ns</td><td align="right" bgcolor="#FFFFFF">23,840 ns</td><td align="right" bgcolor="#FFFFFF">18,616 ns</td><td align="right" bgcolor="#FFFFFF">19,274 ns</td><td align="right" bgcolor="#FFFFFF">19,401 ns</td><td align="right" bgcolor="#FFFFFF">85,039 ns</td><td align="right" bgcolor="#FFFFFF">115,925 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,116 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ParallelHelper_Benchmark"></a>ParallelHelper_Benchmark

### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100"></a>ExecuteInParallel_ItemsPerBash_100

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 2496744,439 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,1 %</td><td align="right" bgcolor="#FF4949">+4,5 %</td><td align="right" bgcolor="#A8D08D">-13,1 %</td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#A8D08D">-94,7 %</td><td align="right" bgcolor="#FF4949">+16,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2315143,655 ns</td><td align="right" bgcolor="#FF4949">2503017,086 ns (Δ = +187873,431 ns)</td><td align="right" bgcolor="#FF4949">2615259,958 ns (Δ = +112242,872 ns)</td><td align="right" bgcolor="#A8D08D">2273457,167 ns (Δ = -341802,790 ns)</td><td align="right" bgcolor="#A8D08D">2242136,727 ns (Δ = -31320,440 ns)</td><td align="right" bgcolor="#A8D08D">118515,518 ns (Δ = -2123621,209 ns)</td><td align="right" bgcolor="#FF4949">137632,383 ns (Δ = +19116,865 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2315,144 μs</td><td align="right" bgcolor="#FFFFFF">2503,017 μs</td><td align="right" bgcolor="#FFFFFF">2615,260 μs</td><td align="right" bgcolor="#A8D08D">2273,457 μs (Δ = -341,803 μs)</td><td align="right" bgcolor="#FFFFFF">2242,137 μs</td><td align="right" bgcolor="#A8D08D">118,516 μs (Δ = -2123,621 μs)</td><td align="right" bgcolor="#FFFFFF">137,632 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,315 ms</td><td align="right" bgcolor="#FFFFFF">2,503 ms</td><td align="right" bgcolor="#FFFFFF">2,615 ms</td><td align="right" bgcolor="#FFFFFF">2,273 ms</td><td align="right" bgcolor="#FFFFFF">2,242 ms</td><td align="right" bgcolor="#FFFFFF">0,119 ms</td><td align="right" bgcolor="#FFFFFF">0,138 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">129,000</td><td align="right" bgcolor="#FFFFFF">129,000</td><td align="right" bgcolor="#A8D08D">128,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">128,000</td><td align="right" bgcolor="#FFFFFF">128,000</td><td align="right" bgcolor="#A8D08D">6,000 (Δ = -122,000)</td><td align="right" bgcolor="#FF4949">8,000 (Δ = +2,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#A8D08D">-0,5 %</td><td align="right" bgcolor="#FF4949">+0,2 %</td><td align="right" bgcolor="#A8D08D">-0,2 %</td><td align="right" bgcolor="#A8D08D">-49,0 %</td><td align="right" bgcolor="#FF4949">+28,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169272,000</td><td align="right" bgcolor="#A8D08D">169185,000 (Δ = -87,000)</td><td align="right" bgcolor="#A8D08D">168343,000 (Δ = -842,000)</td><td align="right" bgcolor="#FF4949">168728,000 (Δ = +385,000)</td><td align="right" bgcolor="#A8D08D">168317,000 (Δ = -411,000)</td><td align="right" bgcolor="#A8D08D">85844,000 (Δ = -82473,000)</td><td align="right" bgcolor="#FF4949">110282,000 (Δ = +24438,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">165,305</td><td align="right" bgcolor="#A8D08D">165,220 (Δ = -0,085)</td><td align="right" bgcolor="#A8D08D">164,397 (Δ = -0,822)</td><td align="right" bgcolor="#FF4949">164,773 (Δ = +0,376)</td><td align="right" bgcolor="#A8D08D">164,372 (Δ = -0,401)</td><td align="right" bgcolor="#A8D08D">83,832 (Δ = -80,540)</td><td align="right" bgcolor="#FF4949">107,697 (Δ = +23,865)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,161</td><td align="right" bgcolor="#A8D08D">0,161 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,161 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,161 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,161 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,082 (Δ = -0,079)</td><td align="right" bgcolor="#FF4949">0,105 (Δ = +0,023)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000"></a>ExecuteInParallel_ItemsPerBash_1000

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 667861,217 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+46,8 %</td><td align="right" bgcolor="#A8D08D">-28,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-81,2 %</td><td align="right" bgcolor="#FF4949">+1,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">524654,574 ns</td><td align="right" bgcolor="#FF4949">769933,526 ns (Δ = +245278,952 ns)</td><td align="right" bgcolor="#A8D08D">549679,945 ns (Δ = -220253,581 ns)</td><td align="right" bgcolor="#FFFFFF">547389,372 ns</td><td align="right" bgcolor="#FFFFFF">544110,520 ns</td><td align="right" bgcolor="#A8D08D">102072,309 ns (Δ = -442038,211 ns)</td><td align="right" bgcolor="#FF4949">103403,457 ns (Δ = +1331,148 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">524,655 μs</td><td align="right" bgcolor="#FFFFFF">769,934 μs</td><td align="right" bgcolor="#FFFFFF">549,680 μs</td><td align="right" bgcolor="#FFFFFF">547,389 μs</td><td align="right" bgcolor="#FFFFFF">544,111 μs</td><td align="right" bgcolor="#A8D08D">102,072 μs (Δ = -442,038 μs)</td><td align="right" bgcolor="#FFFFFF">103,403 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,525 ms</td><td align="right" bgcolor="#FFFFFF">0,770 ms</td><td align="right" bgcolor="#FFFFFF">0,550 ms</td><td align="right" bgcolor="#FFFFFF">0,547 ms</td><td align="right" bgcolor="#FFFFFF">0,544 ms</td><td align="right" bgcolor="#FFFFFF">0,102 ms</td><td align="right" bgcolor="#FFFFFF">0,103 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">6.0</td><td align="right">5.9</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.9</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">69,000</td><td align="right" bgcolor="#FFFFFF">69,000</td><td align="right" bgcolor="#FFFFFF">69,000</td><td align="right" bgcolor="#FFFFFF">69,000</td><td align="right" bgcolor="#FFFFFF">69,000</td><td align="right" bgcolor="#A8D08D">3,000 (Δ = -66,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">-50,1 %</td><td align="right" bgcolor="#FF4949">+6,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">91219,000</td><td align="right" bgcolor="#A8D08D">91171,000 (Δ = -48,000)</td><td align="right" bgcolor="#FF4949">91223,000 (Δ = +52,000)</td><td align="right" bgcolor="#A8D08D">91110,000 (Δ = -113,000)</td><td align="right" bgcolor="#FF4949">91228,000 (Δ = +118,000)</td><td align="right" bgcolor="#A8D08D">45504,000 (Δ = -45724,000)</td><td align="right" bgcolor="#FF4949">48495,000 (Δ = +2991,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">89,081</td><td align="right" bgcolor="#A8D08D">89,034 (Δ = -0,047)</td><td align="right" bgcolor="#FF4949">89,085 (Δ = +0,051)</td><td align="right" bgcolor="#A8D08D">88,975 (Δ = -0,110)</td><td align="right" bgcolor="#FF4949">89,090 (Δ = +0,115)</td><td align="right" bgcolor="#A8D08D">44,438 (Δ = -44,652)</td><td align="right" bgcolor="#FF4949">47,358 (Δ = +2,921)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,087</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,043 (Δ = -0,044)</td><td align="right" bgcolor="#FF4949">0,046 (Δ = +0,003)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500"></a>ExecuteInParallel_ItemsPerBash_500

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 924562,443 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+37,1 %</td><td align="right" bgcolor="#A8D08D">-28,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-86,5 %</td><td align="right" bgcolor="#FF4949">+5,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">745758,500 ns</td><td align="right" bgcolor="#FF4949">1022528,568 ns (Δ = +276770,068 ns)</td><td align="right" bgcolor="#A8D08D">736099,012 ns (Δ = -286429,556 ns)</td><td align="right" bgcolor="#FFFFFF">729457,945 ns</td><td align="right" bgcolor="#FFFFFF">724401,313 ns</td><td align="right" bgcolor="#A8D08D">97966,125 ns (Δ = -626435,188 ns)</td><td align="right" bgcolor="#FF4949">103519,416 ns (Δ = +5553,291 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">745,759 μs</td><td align="right" bgcolor="#FF4949">1022,529 μs (Δ = +276,770 μs)</td><td align="right" bgcolor="#A8D08D">736,099 μs (Δ = -286,430 μs)</td><td align="right" bgcolor="#FFFFFF">729,458 μs</td><td align="right" bgcolor="#FFFFFF">724,401 μs</td><td align="right" bgcolor="#A8D08D">97,966 μs (Δ = -626,435 μs)</td><td align="right" bgcolor="#FFFFFF">103,519 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,746 ms</td><td align="right" bgcolor="#FFFFFF">1,023 ms</td><td align="right" bgcolor="#FFFFFF">0,736 ms</td><td align="right" bgcolor="#FFFFFF">0,729 ms</td><td align="right" bgcolor="#FFFFFF">0,724 ms</td><td align="right" bgcolor="#FFFFFF">0,098 ms</td><td align="right" bgcolor="#FFFFFF">0,104 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.5</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#A8D08D">3,000 (Δ = -71,000)</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#A8D08D">-48,2 %</td><td align="right" bgcolor="#FF4949">+10,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">97906,000</td><td align="right" bgcolor="#A8D08D">97730,000 (Δ = -176,000)</td><td align="right" bgcolor="#FF4949">98129,000 (Δ = +399,000)</td><td align="right" bgcolor="#A8D08D">98004,000 (Δ = -125,000)</td><td align="right" bgcolor="#A8D08D">97857,000 (Δ = -147,000)</td><td align="right" bgcolor="#A8D08D">50686,000 (Δ = -47171,000)</td><td align="right" bgcolor="#FF4949">55915,000 (Δ = +5229,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">95,611</td><td align="right" bgcolor="#A8D08D">95,439 (Δ = -0,172)</td><td align="right" bgcolor="#FF4949">95,829 (Δ = +0,390)</td><td align="right" bgcolor="#A8D08D">95,707 (Δ = -0,122)</td><td align="right" bgcolor="#A8D08D">95,563 (Δ = -0,144)</td><td align="right" bgcolor="#A8D08D">49,498 (Δ = -46,065)</td><td align="right" bgcolor="#FF4949">54,604 (Δ = +5,106)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,093</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,094 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,048 (Δ = -0,045)</td><td align="right" bgcolor="#FF4949">0,053 (Δ = +0,005)</td></tr></table>


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 172,916 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">94,730 ns</td><td align="right" bgcolor="#FFFFFF">83,296 ns</td><td align="right" bgcolor="#FFFFFF">86,181 ns</td><td align="right" bgcolor="#FFFFFF">95,606 ns</td><td align="right" bgcolor="#FFFFFF">85,412 ns</td><td align="right" bgcolor="#FFFFFF">209,668 ns</td><td align="right" bgcolor="#FFFFFF">256,213 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td><td align="right" bgcolor="#FFFFFF">0,256 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">24,000 (Δ = +24,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,023 (Δ = +0,023)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 179,085 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">101,044 ns</td><td align="right" bgcolor="#FFFFFF">80,463 ns</td><td align="right" bgcolor="#FFFFFF">84,797 ns</td><td align="right" bgcolor="#FFFFFF">87,515 ns</td><td align="right" bgcolor="#FFFFFF">78,389 ns</td><td align="right" bgcolor="#FFFFFF">247,215 ns</td><td align="right" bgcolor="#FFFFFF">257,474 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td><td align="right" bgcolor="#FFFFFF">0,257 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">24,000 (Δ = +24,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,023 (Δ = +0,023)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 158,578 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">62,028 ns</td><td align="right" bgcolor="#FFFFFF">50,697 ns</td><td align="right" bgcolor="#FFFFFF">50,563 ns</td><td align="right" bgcolor="#FFFFFF">51,894 ns</td><td align="right" bgcolor="#FFFFFF">49,068 ns</td><td align="right" bgcolor="#FFFFFF">121,425 ns</td><td align="right" bgcolor="#FFFFFF">207,647 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **6.0.0**

Slowest: 5.9.0

Δ: 1519,386 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+44,7 %</td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2417,795 ns</td><td align="right" bgcolor="#A8D08D">1931,685 ns (Δ = -486,110 ns)</td><td align="right" bgcolor="#FFFFFF">1900,277 ns</td><td align="right" bgcolor="#FFFFFF">2005,200 ns</td><td align="right" bgcolor="#FF4949">2901,109 ns (Δ = +895,908 ns)</td><td align="right" bgcolor="#A8D08D">1438,841 ns (Δ = -1462,267 ns)</td><td align="right" bgcolor="#FFFFFF">1381,723 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,418 μs</td><td align="right" bgcolor="#FFFFFF">1,932 μs</td><td align="right" bgcolor="#FFFFFF">1,900 μs</td><td align="right" bgcolor="#FFFFFF">2,005 μs</td><td align="right" bgcolor="#FFFFFF">2,901 μs</td><td align="right" bgcolor="#FFFFFF">1,439 μs</td><td align="right" bgcolor="#FFFFFF">1,382 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#A8D08D">248,000 (Δ = -75,000)</td><td align="right" bgcolor="#FFFFFF">248,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#A8D08D">0,242 (Δ = -0,073)</td><td align="right" bgcolor="#FFFFFF">0,242</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **6.0.0**

Slowest: 5.9.0

Δ: 573,691 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-34,5 %</td><td align="right" bgcolor="#FF4949">+54,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">681,025 ns</td><td align="right" bgcolor="#FFFFFF">863,286 ns</td><td align="right" bgcolor="#A8D08D">565,408 ns (Δ = -297,877 ns)</td><td align="right" bgcolor="#FF4949">874,128 ns (Δ = +308,720 ns)</td><td align="right" bgcolor="#FFFFFF">973,005 ns</td><td align="right" bgcolor="#A8D08D">543,265 ns (Δ = -429,740 ns)</td><td align="right" bgcolor="#FFFFFF">399,314 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,681 μs</td><td align="right" bgcolor="#FFFFFF">0,863 μs</td><td align="right" bgcolor="#FFFFFF">0,565 μs</td><td align="right" bgcolor="#FFFFFF">0,874 μs</td><td align="right" bgcolor="#FFFFFF">0,973 μs</td><td align="right" bgcolor="#FFFFFF">0,543 μs</td><td align="right" bgcolor="#FFFFFF">0,399 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-98,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -76,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,074)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 2440,466 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,0 %</td><td align="right" bgcolor="#A8D08D">-23,6 %</td><td align="right" bgcolor="#FF4949">+21,5 %</td><td align="right" bgcolor="#FF4949">+50,4 %</td><td align="right" bgcolor="#A8D08D">-55,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2747,964 ns</td><td align="right" bgcolor="#FF4949">3161,512 ns (Δ = +413,548 ns)</td><td align="right" bgcolor="#A8D08D">2415,466 ns (Δ = -746,046 ns)</td><td align="right" bgcolor="#FF4949">2935,746 ns (Δ = +520,281 ns)</td><td align="right" bgcolor="#FF4949">4414,500 ns (Δ = +1478,754 ns)</td><td align="right" bgcolor="#A8D08D">1974,034 ns (Δ = -2440,466 ns)</td><td align="right" bgcolor="#FFFFFF">2013,065 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,748 μs</td><td align="right" bgcolor="#FFFFFF">3,162 μs</td><td align="right" bgcolor="#FFFFFF">2,415 μs</td><td align="right" bgcolor="#FFFFFF">2,936 μs</td><td align="right" bgcolor="#FFFFFF">4,415 μs</td><td align="right" bgcolor="#FFFFFF">1,974 μs</td><td align="right" bgcolor="#FFFFFF">2,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">589,000</td><td align="right" bgcolor="#FFFFFF">589,000</td><td align="right" bgcolor="#FFFFFF">589,000</td><td align="right" bgcolor="#FFFFFF">589,000</td><td align="right" bgcolor="#FFFFFF">589,000</td><td align="right" bgcolor="#A8D08D">576,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">576,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,575</td><td align="right" bgcolor="#FFFFFF">0,575</td><td align="right" bgcolor="#FFFFFF">0,575</td><td align="right" bgcolor="#FFFFFF">0,575</td><td align="right" bgcolor="#FFFFFF">0,575</td><td align="right" bgcolor="#A8D08D">0,563 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,563</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **6.0.0**

Slowest: 5.4.0

Δ: 2622,462 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+71,8 %</td><td align="right" bgcolor="#A8D08D">-52,8 %</td><td align="right" bgcolor="#FF4949">+44,4 %</td><td align="right" bgcolor="#FF4949">+22,0 %</td><td align="right" bgcolor="#A8D08D">-56,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2316,675 ns</td><td align="right" bgcolor="#FF4949">3978,931 ns (Δ = +1662,256 ns)</td><td align="right" bgcolor="#A8D08D">1878,175 ns (Δ = -2100,756 ns)</td><td align="right" bgcolor="#FF4949">2711,809 ns (Δ = +833,634 ns)</td><td align="right" bgcolor="#FF4949">3307,789 ns (Δ = +595,980 ns)</td><td align="right" bgcolor="#A8D08D">1433,232 ns (Δ = -1874,557 ns)</td><td align="right" bgcolor="#FFFFFF">1356,469 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,317 μs</td><td align="right" bgcolor="#FFFFFF">3,979 μs</td><td align="right" bgcolor="#FFFFFF">1,878 μs</td><td align="right" bgcolor="#FFFFFF">2,712 μs</td><td align="right" bgcolor="#FFFFFF">3,308 μs</td><td align="right" bgcolor="#FFFFFF">1,433 μs</td><td align="right" bgcolor="#FFFFFF">1,356 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#FFFFFF">323,000</td><td align="right" bgcolor="#A8D08D">248,000 (Δ = -75,000)</td><td align="right" bgcolor="#FFFFFF">248,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#FFFFFF">0,315</td><td align="right" bgcolor="#A8D08D">0,242 (Δ = -0,073)</td><td align="right" bgcolor="#FFFFFF">0,242</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **6.0.0**

Slowest: 5.9.0

Δ: 674,029 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+46,3 %</td><td align="right" bgcolor="#FF4949">+30,9 %</td><td align="right" bgcolor="#A8D08D">-52,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">692,920 ns</td><td align="right" bgcolor="#FFFFFF">554,352 ns</td><td align="right" bgcolor="#FFFFFF">558,820 ns</td><td align="right" bgcolor="#FF4949">817,466 ns (Δ = +258,646 ns)</td><td align="right" bgcolor="#FF4949">1070,279 ns (Δ = +252,813 ns)</td><td align="right" bgcolor="#A8D08D">504,896 ns (Δ = -565,383 ns)</td><td align="right" bgcolor="#FFFFFF">396,250 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,693 μs</td><td align="right" bgcolor="#FFFFFF">0,554 μs</td><td align="right" bgcolor="#FFFFFF">0,559 μs</td><td align="right" bgcolor="#FFFFFF">0,817 μs</td><td align="right" bgcolor="#FFFFFF">1,070 μs</td><td align="right" bgcolor="#FFFFFF">0,505 μs</td><td align="right" bgcolor="#FFFFFF">0,396 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-98,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#FFFFFF">77,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -76,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#FFFFFF">0,075</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,074)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **6.0.0**

Slowest: 5.9.0

Δ: 475,359 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-35,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+42,2 %</td><td align="right" bgcolor="#A8D08D">-39,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">621,872 ns</td><td align="right" bgcolor="#FFFFFF">752,703 ns</td><td align="right" bgcolor="#A8D08D">482,639 ns (Δ = -270,065 ns)</td><td align="right" bgcolor="#FFFFFF">622,481 ns</td><td align="right" bgcolor="#FF4949">885,032 ns (Δ = +262,551 ns)</td><td align="right" bgcolor="#A8D08D">534,810 ns (Δ = -350,222 ns)</td><td align="right" bgcolor="#FFFFFF">409,673 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,622 μs</td><td align="right" bgcolor="#FFFFFF">0,753 μs</td><td align="right" bgcolor="#FFFFFF">0,483 μs</td><td align="right" bgcolor="#FFFFFF">0,622 μs</td><td align="right" bgcolor="#FFFFFF">0,885 μs</td><td align="right" bgcolor="#FFFFFF">0,535 μs</td><td align="right" bgcolor="#FFFFFF">0,410 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#A8D08D">88,000 (Δ = -76,000)</td><td align="right" bgcolor="#FFFFFF">88,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#A8D08D">0,086 (Δ = -0,074)</td><td align="right" bgcolor="#FFFFFF">0,086</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ResourceHelper_Benchmark"></a>ResourceHelper_Benchmark

### <a name="ResourceHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 239,669 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">468,674 ns</td><td align="right" bgcolor="#FFFFFF">543,855 ns</td><td align="right" bgcolor="#FFFFFF">344,674 ns</td><td align="right" bgcolor="#FFFFFF">312,879 ns</td><td align="right" bgcolor="#FFFFFF">304,186 ns</td><td align="right" bgcolor="#FFFFFF">452,327 ns</td><td align="right" bgcolor="#FFFFFF">340,232 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,469 μs</td><td align="right" bgcolor="#FFFFFF">0,544 μs</td><td align="right" bgcolor="#FFFFFF">0,345 μs</td><td align="right" bgcolor="#FFFFFF">0,313 μs</td><td align="right" bgcolor="#FFFFFF">0,304 μs</td><td align="right" bgcolor="#FFFFFF">0,452 μs</td><td align="right" bgcolor="#FFFFFF">0,340 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#FFFFFF">261,000</td><td align="right" bgcolor="#A8D08D">256,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">256,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#FFFFFF">0,255</td><td align="right" bgcolor="#A8D08D">0,250 (Δ = -0,005)</td><td align="right" bgcolor="#FFFFFF">0,250</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ScopeManager_Benchmark"></a>ScopeManager_Benchmark

### <a name="ScopeManager_Benchmark_Get_Existing_ScopeManager"></a>Get_Existing_ScopeManager

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 52,871 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">101,899 ns</td><td align="right" bgcolor="#FFFFFF">128,085 ns</td><td align="right" bgcolor="#FFFFFF">96,554 ns</td><td align="right" bgcolor="#FFFFFF">97,591 ns</td><td align="right" bgcolor="#FFFFFF">97,899 ns</td><td align="right" bgcolor="#FFFFFF">109,347 ns</td><td align="right" bgcolor="#FFFFFF">149,425 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -26,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,025)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ScopeManager_Benchmark_Get_New_ScopeManager"></a>Get_New_ScopeManager

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 29,128 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">108,379 ns</td><td align="right" bgcolor="#FFFFFF">125,478 ns</td><td align="right" bgcolor="#FFFFFF">96,350 ns</td><td align="right" bgcolor="#FFFFFF">99,209 ns</td><td align="right" bgcolor="#FFFFFF">98,218 ns</td><td align="right" bgcolor="#FFFFFF">125,053 ns</td><td align="right" bgcolor="#FFFFFF">104,018 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -26,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,025)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 299748,319 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,7 %</td><td align="right" bgcolor="#A8D08D">-13,5 %</td><td align="right" bgcolor="#FF4949">+1,4 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#A8D08D">-62,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">389138,231 ns</td><td align="right" bgcolor="#FF4949">454304,881 ns (Δ = +65166,650 ns)</td><td align="right" bgcolor="#A8D08D">392752,664 ns (Δ = -61552,218 ns)</td><td align="right" bgcolor="#FF4949">398261,638 ns (Δ = +5508,975 ns)</td><td align="right" bgcolor="#FF4949">414189,498 ns (Δ = +15927,859 ns)</td><td align="right" bgcolor="#A8D08D">154556,563 ns (Δ = -259632,935 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">389,138 μs</td><td align="right" bgcolor="#FFFFFF">454,305 μs</td><td align="right" bgcolor="#FFFFFF">392,753 μs</td><td align="right" bgcolor="#FFFFFF">398,262 μs</td><td align="right" bgcolor="#FFFFFF">414,189 μs</td><td align="right" bgcolor="#A8D08D">154,557 μs (Δ = -259,633 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,389 ms</td><td align="right" bgcolor="#FFFFFF">0,454 ms</td><td align="right" bgcolor="#FFFFFF">0,393 ms</td><td align="right" bgcolor="#FFFFFF">0,398 ms</td><td align="right" bgcolor="#FFFFFF">0,414 ms</td><td align="right" bgcolor="#FFFFFF">0,155 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">79,000</td><td align="right" bgcolor="#FFFFFF">79,000</td><td align="right" bgcolor="#FFFFFF">79,000</td><td align="right" bgcolor="#A8D08D">78,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">78,000</td><td align="right" bgcolor="#A8D08D">6,000 (Δ = -72,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-1,1 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-12,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">104010,000</td><td align="right" bgcolor="#A8D08D">103999,000 (Δ = -11,000)</td><td align="right" bgcolor="#FF4949">104005,000 (Δ = +6,000)</td><td align="right" bgcolor="#A8D08D">102819,000 (Δ = -1186,000)</td><td align="right" bgcolor="#A8D08D">102800,000 (Δ = -19,000)</td><td align="right" bgcolor="#A8D08D">89710,000 (Δ = -13090,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">101,572</td><td align="right" bgcolor="#A8D08D">101,562 (Δ = -0,011)</td><td align="right" bgcolor="#FF4949">101,567 (Δ = +0,006)</td><td align="right" bgcolor="#A8D08D">100,409 (Δ = -1,158)</td><td align="right" bgcolor="#A8D08D">100,391 (Δ = -0,019)</td><td align="right" bgcolor="#A8D08D">87,607 (Δ = -12,783)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,099</td><td align="right" bgcolor="#A8D08D">0,099 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,099 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,098 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,098 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,086 (Δ = -0,012)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 251195,924 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,8 %</td><td align="right" bgcolor="#A8D08D">-18,7 %</td><td align="right" bgcolor="#FF4949">+14,4 %</td><td align="right" bgcolor="#A8D08D">-12,1 %</td><td align="right" bgcolor="#A8D08D">-83,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">235827,951 ns</td><td align="right" bgcolor="#FF4949">289627,686 ns (Δ = +53799,735 ns)</td><td align="right" bgcolor="#A8D08D">235409,201 ns (Δ = -54218,485 ns)</td><td align="right" bgcolor="#FF4949">269340,018 ns (Δ = +33930,817 ns)</td><td align="right" bgcolor="#A8D08D">236629,580 ns (Δ = -32710,438 ns)</td><td align="right" bgcolor="#A8D08D">38431,763 ns (Δ = -198197,817 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">235,828 μs</td><td align="right" bgcolor="#FFFFFF">289,628 μs</td><td align="right" bgcolor="#FFFFFF">235,409 μs</td><td align="right" bgcolor="#FFFFFF">269,340 μs</td><td align="right" bgcolor="#FFFFFF">236,630 μs</td><td align="right" bgcolor="#FFFFFF">38,432 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,236 ms</td><td align="right" bgcolor="#FFFFFF">0,290 ms</td><td align="right" bgcolor="#FFFFFF">0,235 ms</td><td align="right" bgcolor="#FFFFFF">0,269 ms</td><td align="right" bgcolor="#FFFFFF">0,237 ms</td><td align="right" bgcolor="#FFFFFF">0,038 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">28,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -27,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-2,9 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-37,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">38224,000</td><td align="right" bgcolor="#A8D08D">38209,000 (Δ = -15,000)</td><td align="right" bgcolor="#A8D08D">38208,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">37102,000 (Δ = -1106,000)</td><td align="right" bgcolor="#FF4949">37107,000 (Δ = +5,000)</td><td align="right" bgcolor="#A8D08D">23333,000 (Δ = -13774,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">37,328</td><td align="right" bgcolor="#A8D08D">37,313 (Δ = -0,015)</td><td align="right" bgcolor="#A8D08D">37,313 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">36,232 (Δ = -1,080)</td><td align="right" bgcolor="#FF4949">36,237 (Δ = +0,005)</td><td align="right" bgcolor="#A8D08D">22,786 (Δ = -13,451)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,035 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,035 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,022 (Δ = -0,013)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 367988,755 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+45,2 %</td><td align="right" bgcolor="#A8D08D">-31,2 %</td><td align="right" bgcolor="#A8D08D">-1,6 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#A8D08D">-68,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">326844,749 ns</td><td align="right" bgcolor="#FF4949">474562,803 ns (Δ = +147718,054 ns)</td><td align="right" bgcolor="#A8D08D">326397,857 ns (Δ = -148164,945 ns)</td><td align="right" bgcolor="#A8D08D">321313,334 ns (Δ = -5084,523 ns)</td><td align="right" bgcolor="#FF4949">334137,085 ns (Δ = +12823,751 ns)</td><td align="right" bgcolor="#A8D08D">106574,047 ns (Δ = -227563,037 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">326,845 μs</td><td align="right" bgcolor="#FFFFFF">474,563 μs</td><td align="right" bgcolor="#FFFFFF">326,398 μs</td><td align="right" bgcolor="#FFFFFF">321,313 μs</td><td align="right" bgcolor="#FFFFFF">334,137 μs</td><td align="right" bgcolor="#FFFFFF">106,574 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,327 ms</td><td align="right" bgcolor="#FFFFFF">0,475 ms</td><td align="right" bgcolor="#FFFFFF">0,326 ms</td><td align="right" bgcolor="#FFFFFF">0,321 ms</td><td align="right" bgcolor="#FFFFFF">0,334 ms</td><td align="right" bgcolor="#FFFFFF">0,107 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">63,000</td><td align="right" bgcolor="#FFFFFF">63,000</td><td align="right" bgcolor="#FFFFFF">63,000</td><td align="right" bgcolor="#A8D08D">62,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">62,000</td><td align="right" bgcolor="#A8D08D">5,000 (Δ = -57,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-19,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">82958,000</td><td align="right" bgcolor="#A8D08D">82933,000 (Δ = -25,000)</td><td align="right" bgcolor="#FF4949">82936,000 (Δ = +3,000)</td><td align="right" bgcolor="#A8D08D">81692,000 (Δ = -1244,000)</td><td align="right" bgcolor="#FF4949">81696,000 (Δ = +4,000)</td><td align="right" bgcolor="#A8D08D">66062,000 (Δ = -15634,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">81,014</td><td align="right" bgcolor="#A8D08D">80,989 (Δ = -0,024)</td><td align="right" bgcolor="#FF4949">80,992 (Δ = +0,003)</td><td align="right" bgcolor="#A8D08D">79,777 (Δ = -1,215)</td><td align="right" bgcolor="#FF4949">79,781 (Δ = +0,004)</td><td align="right" bgcolor="#A8D08D">64,514 (Δ = -15,268)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,079</td><td align="right" bgcolor="#A8D08D">0,079 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,079 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,078 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,078 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,063 (Δ = -0,015)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 751412,392 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+38,4 %</td><td align="right" bgcolor="#A8D08D">-34,8 %</td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">915346,960 ns</td><td align="right" bgcolor="#FF4949">1266675,963 ns (Δ = +351329,003 ns)</td><td align="right" bgcolor="#A8D08D">825812,798 ns (Δ = -440863,164 ns)</td><td align="right" bgcolor="#A8D08D">801077,278 ns (Δ = -24735,521 ns)</td><td align="right" bgcolor="#FF4949">834903,251 ns (Δ = +33825,974 ns)</td><td align="right" bgcolor="#A8D08D">515263,570 ns (Δ = -319639,681 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">915,347 μs</td><td align="right" bgcolor="#FF4949">1266,676 μs (Δ = +351,329 μs)</td><td align="right" bgcolor="#A8D08D">825,813 μs (Δ = -440,863 μs)</td><td align="right" bgcolor="#FFFFFF">801,077 μs</td><td align="right" bgcolor="#FFFFFF">834,903 μs</td><td align="right" bgcolor="#A8D08D">515,264 μs (Δ = -319,640 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,915 ms</td><td align="right" bgcolor="#FFFFFF">1,267 ms</td><td align="right" bgcolor="#FFFFFF">0,826 ms</td><td align="right" bgcolor="#FFFFFF">0,801 ms</td><td align="right" bgcolor="#FFFFFF">0,835 ms</td><td align="right" bgcolor="#FFFFFF">0,515 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">5.12</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">238,000</td><td align="right" bgcolor="#FFFFFF">238,000</td><td align="right" bgcolor="#FFFFFF">238,000</td><td align="right" bgcolor="#A8D08D">236,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">236,000</td><td align="right" bgcolor="#A8D08D">21,000 (Δ = -215,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-0,7 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-11,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">312805,000</td><td align="right" bgcolor="#A8D08D">312778,000 (Δ = -27,000)</td><td align="right" bgcolor="#A8D08D">312773,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">310547,000 (Δ = -2226,000)</td><td align="right" bgcolor="#FF4949">310697,000 (Δ = +150,000)</td><td align="right" bgcolor="#A8D08D">275235,000 (Δ = -35462,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">305,474</td><td align="right" bgcolor="#A8D08D">305,447 (Δ = -0,026)</td><td align="right" bgcolor="#A8D08D">305,442 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">303,269 (Δ = -2,174)</td><td align="right" bgcolor="#FF4949">303,415 (Δ = +0,146)</td><td align="right" bgcolor="#A8D08D">268,784 (Δ = -34,631)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,298</td><td align="right" bgcolor="#A8D08D">0,298 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,298 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,002)</td><td align="right" bgcolor="#FF4949">0,296 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,262 (Δ = -0,034)</td></tr></table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 5941943,003 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,5 %</td><td align="right" bgcolor="#A8D08D">-1,7 %</td><td align="right" bgcolor="#FF4949">+1,6 %</td><td align="right" bgcolor="#A8D08D">-1,0 %</td><td align="right" bgcolor="#A8D08D">-33,1 %</td><td align="right" bgcolor="#FF4949">+1,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14122300,815 ns</td><td align="right" bgcolor="#A8D08D">12358990,065 ns (Δ = -1763310,750 ns)</td><td align="right" bgcolor="#A8D08D">12152675,577 ns (Δ = -206314,489 ns)</td><td align="right" bgcolor="#FF4949">12349254,535 ns (Δ = +196578,958 ns)</td><td align="right" bgcolor="#A8D08D">12219717,488 ns (Δ = -129537,046 ns)</td><td align="right" bgcolor="#A8D08D">8180357,813 ns (Δ = -4039359,676 ns)</td><td align="right" bgcolor="#FF4949">8335846,338 ns (Δ = +155488,525 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14122,301 μs</td><td align="right" bgcolor="#A8D08D">12358,990 μs (Δ = -1763,311 μs)</td><td align="right" bgcolor="#FFFFFF">12152,676 μs</td><td align="right" bgcolor="#FFFFFF">12349,255 μs</td><td align="right" bgcolor="#FFFFFF">12219,717 μs</td><td align="right" bgcolor="#A8D08D">8180,358 μs (Δ = -4039,360 μs)</td><td align="right" bgcolor="#FFFFFF">8335,846 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">14,122 ms</td><td align="right" bgcolor="#FFFFFF">12,359 ms</td><td align="right" bgcolor="#FFFFFF">12,153 ms</td><td align="right" bgcolor="#FFFFFF">12,349 ms</td><td align="right" bgcolor="#FFFFFF">12,220 ms</td><td align="right" bgcolor="#FFFFFF">8,180 ms</td><td align="right" bgcolor="#FFFFFF">8,336 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.5</td></tr><tr><td>Gen 1</td><td align="right">5.9</td><td align="right">6.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.5</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1169,000</td><td align="right" bgcolor="#A8D08D">1165,000 (Δ = -4,000)</td><td align="right" bgcolor="#FF4949">1171,000 (Δ = +6,000)</td><td align="right" bgcolor="#A8D08D">1169,000 (Δ = -2,000)</td><td align="right" bgcolor="#A8D08D">1166,000 (Δ = -3,000)</td><td align="right" bgcolor="#A8D08D">54,000 (Δ = -1112,000)</td><td align="right" bgcolor="#FFFFFF">54,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">11,000 (Δ = +9,000)</td><td align="right" bgcolor="#FF4949">12,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#A8D08D">-0,2 %</td><td align="right" bgcolor="#A8D08D">-0,2 %</td><td align="right" bgcolor="#A8D08D">-53,6 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1533357,000</td><td align="right" bgcolor="#A8D08D">1528410,000 (Δ = -4947,000)</td><td align="right" bgcolor="#FF4949">1535185,000 (Δ = +6775,000)</td><td align="right" bgcolor="#A8D08D">1532783,000 (Δ = -2402,000)</td><td align="right" bgcolor="#A8D08D">1529372,000 (Δ = -3411,000)</td><td align="right" bgcolor="#A8D08D">709334,000 (Δ = -820038,000)</td><td align="right" bgcolor="#A8D08D">709196,000 (Δ = -138,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1497,419</td><td align="right" bgcolor="#A8D08D">1492,588 (Δ = -4,831)</td><td align="right" bgcolor="#FF4949">1499,204 (Δ = +6,616)</td><td align="right" bgcolor="#A8D08D">1496,858 (Δ = -2,346)</td><td align="right" bgcolor="#A8D08D">1493,527 (Δ = -3,331)</td><td align="right" bgcolor="#A8D08D">692,709 (Δ = -800,818)</td><td align="right" bgcolor="#A8D08D">692,574 (Δ = -0,135)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,462</td><td align="right" bgcolor="#A8D08D">1,458 (Δ = -0,005)</td><td align="right" bgcolor="#FF4949">1,464 (Δ = +0,006)</td><td align="right" bgcolor="#A8D08D">1,462 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">1,459 (Δ = -0,003)</td><td align="right" bgcolor="#A8D08D">0,676 (Δ = -0,782)</td><td align="right" bgcolor="#A8D08D">0,676 (Δ = -0,000)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 500370,811 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+12,5 %</td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#A8D08D">-7,7 %</td><td align="right" bgcolor="#FF4949">+9,7 %</td><td align="right" bgcolor="#A8D08D">-61,4 %</td><td align="right" bgcolor="#FF4949">+21,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">701319,196 ns</td><td align="right" bgcolor="#FF4949">789094,269 ns (Δ = +87775,074 ns)</td><td align="right" bgcolor="#A8D08D">739446,241 ns (Δ = -49648,029 ns)</td><td align="right" bgcolor="#A8D08D">682196,492 ns (Δ = -57249,748 ns)</td><td align="right" bgcolor="#FF4949">748657,975 ns (Δ = +66461,483 ns)</td><td align="right" bgcolor="#A8D08D">288723,458 ns (Δ = -459934,517 ns)</td><td align="right" bgcolor="#FF4949">350788,718 ns (Δ = +62065,260 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">701,319 μs</td><td align="right" bgcolor="#FFFFFF">789,094 μs</td><td align="right" bgcolor="#FFFFFF">739,446 μs</td><td align="right" bgcolor="#FFFFFF">682,196 μs</td><td align="right" bgcolor="#FFFFFF">748,658 μs</td><td align="right" bgcolor="#A8D08D">288,723 μs (Δ = -459,935 μs)</td><td align="right" bgcolor="#FFFFFF">350,789 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,701 ms</td><td align="right" bgcolor="#FFFFFF">0,789 ms</td><td align="right" bgcolor="#FFFFFF">0,739 ms</td><td align="right" bgcolor="#FFFFFF">0,682 ms</td><td align="right" bgcolor="#FFFFFF">0,749 ms</td><td align="right" bgcolor="#FFFFFF">0,289 ms</td><td align="right" bgcolor="#FFFFFF">0,351 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">6.0</td><td align="right">5.6</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.5</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -63,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,2 %</td><td align="right" bgcolor="#A8D08D">-1,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-55,7 %</td><td align="right" bgcolor="#FF4949">+0,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">86085,000</td><td align="right" bgcolor="#A8D08D">86067,000 (Δ = -18,000)</td><td align="right" bgcolor="#FF4949">86253,000 (Δ = +186,000)</td><td align="right" bgcolor="#A8D08D">85264,000 (Δ = -989,000)</td><td align="right" bgcolor="#FFFFFF">85264,000</td><td align="right" bgcolor="#A8D08D">37798,000 (Δ = -47466,000)</td><td align="right" bgcolor="#FF4949">38051,000 (Δ = +253,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">84,067</td><td align="right" bgcolor="#A8D08D">84,050 (Δ = -0,018)</td><td align="right" bgcolor="#FF4949">84,231 (Δ = +0,182)</td><td align="right" bgcolor="#A8D08D">83,266 (Δ = -0,966)</td><td align="right" bgcolor="#FFFFFF">83,266</td><td align="right" bgcolor="#A8D08D">36,912 (Δ = -46,354)</td><td align="right" bgcolor="#FF4949">37,159 (Δ = +0,247)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,082</td><td align="right" bgcolor="#A8D08D">0,082 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,082 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,081 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,081</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,045)</td><td align="right" bgcolor="#FF4949">0,036 (Δ = +0,000)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **6.0.0**

Slowest: 5.4.0

Δ: 1501575,983 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,2 %</td><td align="right" bgcolor="#A8D08D">-15,2 %</td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#A8D08D">-44,1 %</td><td align="right" bgcolor="#A8D08D">-8,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2484616,084 ns</td><td align="right" bgcolor="#FF4949">2637796,833 ns (Δ = +153180,750 ns)</td><td align="right" bgcolor="#A8D08D">2237045,767 ns (Δ = -400751,066 ns)</td><td align="right" bgcolor="#A8D08D">2138883,817 ns (Δ = -98161,951 ns)</td><td align="right" bgcolor="#FF4949">2225290,336 ns (Δ = +86406,520 ns)</td><td align="right" bgcolor="#A8D08D">1243154,700 ns (Δ = -982135,636 ns)</td><td align="right" bgcolor="#A8D08D">1136220,850 ns (Δ = -106933,850 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2484,616 μs</td><td align="right" bgcolor="#FFFFFF">2637,797 μs</td><td align="right" bgcolor="#A8D08D">2237,046 μs (Δ = -400,751 μs)</td><td align="right" bgcolor="#FFFFFF">2138,884 μs</td><td align="right" bgcolor="#FFFFFF">2225,290 μs</td><td align="right" bgcolor="#A8D08D">1243,155 μs (Δ = -982,136 μs)</td><td align="right" bgcolor="#FFFFFF">1136,221 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,485 ms</td><td align="right" bgcolor="#FFFFFF">2,638 ms</td><td align="right" bgcolor="#FFFFFF">2,237 ms</td><td align="right" bgcolor="#FFFFFF">2,139 ms</td><td align="right" bgcolor="#FFFFFF">2,225 ms</td><td align="right" bgcolor="#FFFFFF">1,243 ms</td><td align="right" bgcolor="#FFFFFF">1,136 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.5</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">211,000</td><td align="right" bgcolor="#FFFFFF">211,000</td><td align="right" bgcolor="#FFFFFF">211,000</td><td align="right" bgcolor="#A8D08D">210,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">210,000</td><td align="right" bgcolor="#A8D08D">9,000 (Δ = -201,000)</td><td align="right" bgcolor="#FFFFFF">9,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#A8D08D">-0,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-55,6 %</td><td align="right" bgcolor="#FF4949">+1,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">276650,000</td><td align="right" bgcolor="#A8D08D">276647,000 (Δ = -3,000)</td><td align="right" bgcolor="#FF4949">277689,000 (Δ = +1042,000)</td><td align="right" bgcolor="#A8D08D">276399,000 (Δ = -1290,000)</td><td align="right" bgcolor="#FFFFFF">276399,000</td><td align="right" bgcolor="#A8D08D">122758,000 (Δ = -153641,000)</td><td align="right" bgcolor="#FF4949">124376,000 (Δ = +1618,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">270,166</td><td align="right" bgcolor="#A8D08D">270,163 (Δ = -0,003)</td><td align="right" bgcolor="#FF4949">271,181 (Δ = +1,018)</td><td align="right" bgcolor="#A8D08D">269,921 (Δ = -1,260)</td><td align="right" bgcolor="#FFFFFF">269,921</td><td align="right" bgcolor="#A8D08D">119,881 (Δ = -150,040)</td><td align="right" bgcolor="#FF4949">121,461 (Δ = +1,580)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,264</td><td align="right" bgcolor="#A8D08D">0,264 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,265 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,264 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,264</td><td align="right" bgcolor="#A8D08D">0,117 (Δ = -0,147)</td><td align="right" bgcolor="#FF4949">0,119 (Δ = +0,002)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **6.0.0**

Slowest: 5.4.0

Δ: 5734999,481 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,2 %</td><td align="right" bgcolor="#A8D08D">-13,5 %</td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#FF4949">+3,3 %</td><td align="right" bgcolor="#A8D08D">-39,0 %</td><td align="right" bgcolor="#A8D08D">-8,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10614273,574 ns</td><td align="right" bgcolor="#FF4949">11272857,837 ns (Δ = +658584,263 ns)</td><td align="right" bgcolor="#A8D08D">9755046,130 ns (Δ = -1517811,707 ns)</td><td align="right" bgcolor="#A8D08D">9612741,923 ns (Δ = -142304,208 ns)</td><td align="right" bgcolor="#FF4949">9931157,870 ns (Δ = +318415,947 ns)</td><td align="right" bgcolor="#A8D08D">6054929,702 ns (Δ = -3876228,167 ns)</td><td align="right" bgcolor="#A8D08D">5537858,356 ns (Δ = -517071,346 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10614,274 μs</td><td align="right" bgcolor="#FF4949">11272,858 μs (Δ = +658,584 μs)</td><td align="right" bgcolor="#A8D08D">9755,046 μs (Δ = -1517,812 μs)</td><td align="right" bgcolor="#FFFFFF">9612,742 μs</td><td align="right" bgcolor="#FF4949">9931,158 μs (Δ = +318,416 μs)</td><td align="right" bgcolor="#A8D08D">6054,930 μs (Δ = -3876,228 μs)</td><td align="right" bgcolor="#A8D08D">5537,858 μs (Δ = -517,071 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">10,614 ms</td><td align="right" bgcolor="#FFFFFF">11,273 ms</td><td align="right" bgcolor="#FFFFFF">9,755 ms</td><td align="right" bgcolor="#FFFFFF">9,613 ms</td><td align="right" bgcolor="#FFFFFF">9,931 ms</td><td align="right" bgcolor="#FFFFFF">6,055 ms</td><td align="right" bgcolor="#FFFFFF">5,538 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.5</td></tr><tr><td>Gen 1</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.5</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">937,000</td><td align="right" bgcolor="#FF4949">940,000 (Δ = +3,000)</td><td align="right" bgcolor="#FF4949">943,000 (Δ = +3,000)</td><td align="right" bgcolor="#A8D08D">940,000 (Δ = -3,000)</td><td align="right" bgcolor="#FF4949">941,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">42,000 (Δ = -899,000)</td><td align="right" bgcolor="#FFFFFF">42,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-55,4 %</td><td align="right" bgcolor="#FF4949">+0,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1229427,000</td><td align="right" bgcolor="#FF4949">1232564,000 (Δ = +3137,000)</td><td align="right" bgcolor="#FF4949">1236931,000 (Δ = +4367,000)</td><td align="right" bgcolor="#A8D08D">1233274,000 (Δ = -3657,000)</td><td align="right" bgcolor="#FF4949">1233813,000 (Δ = +539,000)</td><td align="right" bgcolor="#A8D08D">550380,000 (Δ = -683433,000)</td><td align="right" bgcolor="#FF4949">553526,000 (Δ = +3146,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1200,612</td><td align="right" bgcolor="#FF4949">1203,676 (Δ = +3,063)</td><td align="right" bgcolor="#FF4949">1207,940 (Δ = +4,265)</td><td align="right" bgcolor="#A8D08D">1204,369 (Δ = -3,571)</td><td align="right" bgcolor="#FF4949">1204,896 (Δ = +0,526)</td><td align="right" bgcolor="#A8D08D">537,480 (Δ = -667,415)</td><td align="right" bgcolor="#FF4949">540,553 (Δ = +3,072)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,172</td><td align="right" bgcolor="#FF4949">1,175 (Δ = +0,003)</td><td align="right" bgcolor="#FF4949">1,180 (Δ = +0,004)</td><td align="right" bgcolor="#A8D08D">1,176 (Δ = -0,003)</td><td align="right" bgcolor="#FF4949">1,177 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,525 (Δ = -0,652)</td><td align="right" bgcolor="#FF4949">0,528 (Δ = +0,003)</td></tr></table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 737252,553 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,3 %</td><td align="right" bgcolor="#FF4949">+4,5 %</td><td align="right" bgcolor="#FF4949">+2,1 %</td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-73,5 %</td><td align="right" bgcolor="#FF4949">+8,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">960300,910 ns</td><td align="right" bgcolor="#A8D08D">823006,459 ns (Δ = -137294,451 ns)</td><td align="right" bgcolor="#FF4949">860212,524 ns (Δ = +37206,065 ns)</td><td align="right" bgcolor="#FF4949">878149,662 ns (Δ = +17937,138 ns)</td><td align="right" bgcolor="#A8D08D">840836,223 ns (Δ = -37313,439 ns)</td><td align="right" bgcolor="#A8D08D">223048,358 ns (Δ = -617787,865 ns)</td><td align="right" bgcolor="#FF4949">240823,713 ns (Δ = +17775,355 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">960,301 μs</td><td align="right" bgcolor="#FFFFFF">823,006 μs</td><td align="right" bgcolor="#FFFFFF">860,213 μs</td><td align="right" bgcolor="#FFFFFF">878,150 μs</td><td align="right" bgcolor="#FFFFFF">840,836 μs</td><td align="right" bgcolor="#A8D08D">223,048 μs (Δ = -617,788 μs)</td><td align="right" bgcolor="#FFFFFF">240,824 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,960 ms</td><td align="right" bgcolor="#FFFFFF">0,823 ms</td><td align="right" bgcolor="#FFFFFF">0,860 ms</td><td align="right" bgcolor="#FFFFFF">0,878 ms</td><td align="right" bgcolor="#FFFFFF">0,841 ms</td><td align="right" bgcolor="#FFFFFF">0,223 ms</td><td align="right" bgcolor="#FFFFFF">0,241 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.6</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.9</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">443,000</td><td align="right" bgcolor="#FFFFFF">443,000</td><td align="right" bgcolor="#FFFFFF">443,000</td><td align="right" bgcolor="#FF4949">451,000 (Δ = +8,000)</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">7,000 (Δ = -444,000)</td><td align="right" bgcolor="#A8D08D">6,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+1,8 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-84,5 %</td><td align="right" bgcolor="#A8D08D">-5,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">582274,000</td><td align="right" bgcolor="#FF4949">582299,000 (Δ = +25,000)</td><td align="right" bgcolor="#A8D08D">582254,000 (Δ = -45,000)</td><td align="right" bgcolor="#FF4949">592481,000 (Δ = +10227,000)</td><td align="right" bgcolor="#FF4949">592493,000 (Δ = +12,000)</td><td align="right" bgcolor="#A8D08D">91754,000 (Δ = -500739,000)</td><td align="right" bgcolor="#A8D08D">86479,000 (Δ = -5275,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">568,627</td><td align="right" bgcolor="#FF4949">568,651 (Δ = +0,024)</td><td align="right" bgcolor="#A8D08D">568,607 (Δ = -0,044)</td><td align="right" bgcolor="#FF4949">578,595 (Δ = +9,987)</td><td align="right" bgcolor="#FF4949">578,606 (Δ = +0,012)</td><td align="right" bgcolor="#A8D08D">89,604 (Δ = -489,003)</td><td align="right" bgcolor="#A8D08D">84,452 (Δ = -5,151)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,555</td><td align="right" bgcolor="#FF4949">0,555 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,555 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,565 (Δ = +0,010)</td><td align="right" bgcolor="#FF4949">0,565 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,088 (Δ = -0,478)</td><td align="right" bgcolor="#A8D08D">0,082 (Δ = -0,005)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 299943,722 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,0 %</td><td align="right" bgcolor="#FF4949">+2,2 %</td><td align="right" bgcolor="#A8D08D">-2,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-87,7 %</td><td align="right" bgcolor="#A8D08D">-23,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">327985,185 ns</td><td align="right" bgcolor="#A8D08D">295163,351 ns (Δ = -32821,834 ns)</td><td align="right" bgcolor="#FF4949">301556,524 ns (Δ = +6393,173 ns)</td><td align="right" bgcolor="#A8D08D">293803,913 ns (Δ = -7752,611 ns)</td><td align="right" bgcolor="#FFFFFF">296768,096 ns</td><td align="right" bgcolor="#A8D08D">36624,422 ns (Δ = -260143,674 ns)</td><td align="right" bgcolor="#A8D08D">28041,463 ns (Δ = -8582,959 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">327,985 μs</td><td align="right" bgcolor="#FFFFFF">295,163 μs</td><td align="right" bgcolor="#FFFFFF">301,557 μs</td><td align="right" bgcolor="#FFFFFF">293,804 μs</td><td align="right" bgcolor="#FFFFFF">296,768 μs</td><td align="right" bgcolor="#A8D08D">36,624 μs (Δ = -260,144 μs)</td><td align="right" bgcolor="#FFFFFF">28,041 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,328 ms</td><td align="right" bgcolor="#FFFFFF">0,295 ms</td><td align="right" bgcolor="#FFFFFF">0,302 ms</td><td align="right" bgcolor="#FFFFFF">0,294 ms</td><td align="right" bgcolor="#FFFFFF">0,297 ms</td><td align="right" bgcolor="#FFFFFF">0,037 ms</td><td align="right" bgcolor="#FFFFFF">0,028 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.6</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">104,000</td><td align="right" bgcolor="#FFFFFF">104,000</td><td align="right" bgcolor="#FFFFFF">104,000</td><td align="right" bgcolor="#FFFFFF">104,000</td><td align="right" bgcolor="#FFFFFF">104,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -103,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+0,2 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-85,4 %</td><td align="right" bgcolor="#FF4949">+1,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">137668,000</td><td align="right" bgcolor="#FFFFFF">137668,000</td><td align="right" bgcolor="#A8D08D">137647,000 (Δ = -21,000)</td><td align="right" bgcolor="#FF4949">137920,000 (Δ = +273,000)</td><td align="right" bgcolor="#A8D08D">137913,000 (Δ = -7,000)</td><td align="right" bgcolor="#A8D08D">20130,000 (Δ = -117783,000)</td><td align="right" bgcolor="#FF4949">20338,000 (Δ = +208,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">134,441</td><td align="right" bgcolor="#FFFFFF">134,441</td><td align="right" bgcolor="#A8D08D">134,421 (Δ = -0,021)</td><td align="right" bgcolor="#FF4949">134,688 (Δ = +0,267)</td><td align="right" bgcolor="#A8D08D">134,681 (Δ = -0,007)</td><td align="right" bgcolor="#A8D08D">19,658 (Δ = -115,022)</td><td align="right" bgcolor="#FF4949">19,861 (Δ = +0,203)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,131</td><td align="right" bgcolor="#FFFFFF">0,131</td><td align="right" bgcolor="#A8D08D">0,131 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,132 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,019 (Δ = -0,112)</td><td align="right" bgcolor="#FF4949">0,019 (Δ = +0,000)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 503739,001 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#FF4949">+4,4 %</td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#A8D08D">-5,0 %</td><td align="right" bgcolor="#A8D08D">-79,0 %</td><td align="right" bgcolor="#A8D08D">-6,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">607091,876 ns</td><td align="right" bgcolor="#A8D08D">512270,057 ns (Δ = -94821,819 ns)</td><td align="right" bgcolor="#FF4949">534639,512 ns (Δ = +22369,455 ns)</td><td align="right" bgcolor="#FF4949">554411,779 ns (Δ = +19772,266 ns)</td><td align="right" bgcolor="#A8D08D">526755,698 ns (Δ = -27656,081 ns)</td><td align="right" bgcolor="#A8D08D">110389,375 ns (Δ = -416366,323 ns)</td><td align="right" bgcolor="#A8D08D">103352,875 ns (Δ = -7036,500 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">607,092 μs</td><td align="right" bgcolor="#FFFFFF">512,270 μs</td><td align="right" bgcolor="#FFFFFF">534,640 μs</td><td align="right" bgcolor="#FFFFFF">554,412 μs</td><td align="right" bgcolor="#FFFFFF">526,756 μs</td><td align="right" bgcolor="#A8D08D">110,389 μs (Δ = -416,366 μs)</td><td align="right" bgcolor="#FFFFFF">103,353 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,607 ms</td><td align="right" bgcolor="#FFFFFF">0,512 ms</td><td align="right" bgcolor="#FFFFFF">0,535 ms</td><td align="right" bgcolor="#FFFFFF">0,554 ms</td><td align="right" bgcolor="#FFFFFF">0,527 ms</td><td align="right" bgcolor="#FFFFFF">0,110 ms</td><td align="right" bgcolor="#FFFFFF">0,103 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.6</td></tr><tr><td>Gen 1</td><td align="right">6.0</td><td align="right">5.5</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.9</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">329,000</td><td align="right" bgcolor="#FFFFFF">329,000</td><td align="right" bgcolor="#FFFFFF">329,000</td><td align="right" bgcolor="#FF4949">333,000 (Δ = +4,000)</td><td align="right" bgcolor="#FFFFFF">333,000</td><td align="right" bgcolor="#A8D08D">3,000 (Δ = -330,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#FF4949">+1,2 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-89,7 %</td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">432940,000</td><td align="right" bgcolor="#FF4949">433040,000 (Δ = +100,000)</td><td align="right" bgcolor="#A8D08D">432973,000 (Δ = -67,000)</td><td align="right" bgcolor="#FF4949">437981,000 (Δ = +5008,000)</td><td align="right" bgcolor="#FF4949">437989,000 (Δ = +8,000)</td><td align="right" bgcolor="#A8D08D">45017,000 (Δ = -392972,000)</td><td align="right" bgcolor="#FF4949">45105,000 (Δ = +88,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">422,793</td><td align="right" bgcolor="#FF4949">422,891 (Δ = +0,098)</td><td align="right" bgcolor="#A8D08D">422,825 (Δ = -0,065)</td><td align="right" bgcolor="#FF4949">427,716 (Δ = +4,891)</td><td align="right" bgcolor="#FF4949">427,724 (Δ = +0,008)</td><td align="right" bgcolor="#A8D08D">43,962 (Δ = -383,762)</td><td align="right" bgcolor="#FF4949">44,048 (Δ = +0,086)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,413</td><td align="right" bgcolor="#FF4949">0,413 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,413 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,418 (Δ = +0,005)</td><td align="right" bgcolor="#FF4949">0,418 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,043 (Δ = -0,375)</td><td align="right" bgcolor="#FF4949">0,043 (Δ = +0,000)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 1474980,940 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,2 %</td><td align="right" bgcolor="#FF4949">+2,9 %</td><td align="right" bgcolor="#FF4949">+8,0 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#A8D08D">-71,4 %</td><td align="right" bgcolor="#A8D08D">-7,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1944746,138 ns</td><td align="right" bgcolor="#A8D08D">1648659,420 ns (Δ = -296086,718 ns)</td><td align="right" bgcolor="#FF4949">1696922,939 ns (Δ = +48263,519 ns)</td><td align="right" bgcolor="#FF4949">1832214,541 ns (Δ = +135291,602 ns)</td><td align="right" bgcolor="#A8D08D">1770070,417 ns (Δ = -62144,124 ns)</td><td align="right" bgcolor="#A8D08D">505623,227 ns (Δ = -1264447,190 ns)</td><td align="right" bgcolor="#A8D08D">469765,199 ns (Δ = -35858,028 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1944,746 μs</td><td align="right" bgcolor="#A8D08D">1648,659 μs (Δ = -296,087 μs)</td><td align="right" bgcolor="#FFFFFF">1696,923 μs</td><td align="right" bgcolor="#FFFFFF">1832,215 μs</td><td align="right" bgcolor="#FFFFFF">1770,070 μs</td><td align="right" bgcolor="#A8D08D">505,623 μs (Δ = -1264,447 μs)</td><td align="right" bgcolor="#FFFFFF">469,765 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,945 ms</td><td align="right" bgcolor="#FFFFFF">1,649 ms</td><td align="right" bgcolor="#FFFFFF">1,697 ms</td><td align="right" bgcolor="#FFFFFF">1,832 ms</td><td align="right" bgcolor="#FFFFFF">1,770 ms</td><td align="right" bgcolor="#FFFFFF">0,506 ms</td><td align="right" bgcolor="#FFFFFF">0,470 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.6</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">5.6</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1453,000</td><td align="right" bgcolor="#FFFFFF">1453,000</td><td align="right" bgcolor="#FFFFFF">1453,000</td><td align="right" bgcolor="#FF4949">1473,000 (Δ = +20,000)</td><td align="right" bgcolor="#FFFFFF">1473,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -1461,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+1,3 %</td><td align="right" bgcolor="#A8D08D">-0,0 %</td><td align="right" bgcolor="#A8D08D">-91,4 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1909467,000</td><td align="right" bgcolor="#FF4949">1909562,000 (Δ = +95,000)</td><td align="right" bgcolor="#FF4949">1910023,000 (Δ = +461,000)</td><td align="right" bgcolor="#FF4949">1935788,000 (Δ = +25765,000)</td><td align="right" bgcolor="#A8D08D">1935273,000 (Δ = -515,000)</td><td align="right" bgcolor="#A8D08D">166733,000 (Δ = -1768540,000)</td><td align="right" bgcolor="#FF4949">166901,000 (Δ = +168,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1864,714</td><td align="right" bgcolor="#FF4949">1864,807 (Δ = +0,093)</td><td align="right" bgcolor="#FF4949">1865,257 (Δ = +0,450)</td><td align="right" bgcolor="#FF4949">1890,418 (Δ = +25,161)</td><td align="right" bgcolor="#A8D08D">1889,915 (Δ = -0,503)</td><td align="right" bgcolor="#A8D08D">162,825 (Δ = -1727,090)</td><td align="right" bgcolor="#FF4949">162,989 (Δ = +0,164)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,821</td><td align="right" bgcolor="#FF4949">1,821 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">1,822 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">1,846 (Δ = +0,025)</td><td align="right" bgcolor="#A8D08D">1,846 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,159 (Δ = -1,687)</td><td align="right" bgcolor="#FF4949">0,159 (Δ = +0,000)</td></tr></table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 1294,673 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+165,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1076,814 ns</td><td align="right" bgcolor="#FFFFFF">933,262 ns</td><td align="right" bgcolor="#FFFFFF">869,738 ns</td><td align="right" bgcolor="#FFFFFF">882,243 ns</td><td align="right" bgcolor="#FFFFFF">781,175 ns</td><td align="right" bgcolor="#FF4949">2075,848 ns (Δ = +1294,673 ns)</td><td align="right" bgcolor="#FFFFFF">1871,637 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,077 μs</td><td align="right" bgcolor="#FFFFFF">0,933 μs</td><td align="right" bgcolor="#FFFFFF">0,870 μs</td><td align="right" bgcolor="#FFFFFF">0,882 μs</td><td align="right" bgcolor="#FFFFFF">0,781 μs</td><td align="right" bgcolor="#FFFFFF">2,076 μs</td><td align="right" bgcolor="#FFFFFF">1,872 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td><td align="right" bgcolor="#A8D08D">-8,8 %</td><td align="right" bgcolor="#FF4949">+43,6 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">940,000</td><td align="right" bgcolor="#FFFFFF">940,000</td><td align="right" bgcolor="#FFFFFF">940,000</td><td align="right" bgcolor="#FF4949">943,000 (Δ = +3,000)</td><td align="right" bgcolor="#A8D08D">860,000 (Δ = -83,000)</td><td align="right" bgcolor="#FF4949">1235,000 (Δ = +375,000)</td><td align="right" bgcolor="#A8D08D">1234,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,918</td><td align="right" bgcolor="#FFFFFF">0,918</td><td align="right" bgcolor="#FFFFFF">0,918</td><td align="right" bgcolor="#FF4949">0,921 (Δ = +0,003)</td><td align="right" bgcolor="#A8D08D">0,840 (Δ = -0,081)</td><td align="right" bgcolor="#FF4949">1,206 (Δ = +0,366)</td><td align="right" bgcolor="#A8D08D">1,205 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 132,850 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">175,706 ns</td><td align="right" bgcolor="#FFFFFF">144,841 ns</td><td align="right" bgcolor="#FFFFFF">139,037 ns</td><td align="right" bgcolor="#FFFFFF">136,293 ns</td><td align="right" bgcolor="#FFFFFF">165,125 ns</td><td align="right" bgcolor="#FFFFFF">269,142 ns</td><td align="right" bgcolor="#FFFFFF">259,022 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,176 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,165 μs</td><td align="right" bgcolor="#FFFFFF">0,269 μs</td><td align="right" bgcolor="#FFFFFF">0,259 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#A8D08D">144,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">144,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#A8D08D">0,141 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,141</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Transient"></a>ResolveType_Transient

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 342,846 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2431,808 ns</td><td align="right" bgcolor="#A8D08D">2118,705 ns (Δ = -313,103 ns)</td><td align="right" bgcolor="#FFFFFF">2088,962 ns</td><td align="right" bgcolor="#FFFFFF">2118,391 ns</td><td align="right" bgcolor="#FFFFFF">2302,283 ns</td><td align="right" bgcolor="#FFFFFF">2173,125 ns</td><td align="right" bgcolor="#FFFFFF">2196,491 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,432 μs</td><td align="right" bgcolor="#FFFFFF">2,119 μs</td><td align="right" bgcolor="#FFFFFF">2,089 μs</td><td align="right" bgcolor="#FFFFFF">2,118 μs</td><td align="right" bgcolor="#FFFFFF">2,302 μs</td><td align="right" bgcolor="#FFFFFF">2,173 μs</td><td align="right" bgcolor="#FFFFFF">2,196 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,1 %</td><td align="right" bgcolor="#A8D08D">-1,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1449,000</td><td align="right" bgcolor="#A8D08D">1439,000 (Δ = -10,000)</td><td align="right" bgcolor="#FFFFFF">1439,000</td><td align="right" bgcolor="#FFFFFF">1439,000</td><td align="right" bgcolor="#FFFFFF">1439,000</td><td align="right" bgcolor="#A8D08D">1409,000 (Δ = -30,000)</td><td align="right" bgcolor="#A8D08D">1385,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,415</td><td align="right" bgcolor="#A8D08D">1,405 (Δ = -0,010)</td><td align="right" bgcolor="#FFFFFF">1,405</td><td align="right" bgcolor="#FFFFFF">1,405</td><td align="right" bgcolor="#FFFFFF">1,405</td><td align="right" bgcolor="#A8D08D">1,376 (Δ = -0,029)</td><td align="right" bgcolor="#A8D08D">1,353 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 134,683 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">179,948 ns</td><td align="right" bgcolor="#FFFFFF">141,278 ns</td><td align="right" bgcolor="#FFFFFF">136,083 ns</td><td align="right" bgcolor="#FFFFFF">127,256 ns</td><td align="right" bgcolor="#FFFFFF">121,845 ns</td><td align="right" bgcolor="#FFFFFF">256,528 ns</td><td align="right" bgcolor="#FFFFFF">243,925 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,180 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,257 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#FFFFFF">148,000</td><td align="right" bgcolor="#A8D08D">144,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">144,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#FFFFFF">0,145</td><td align="right" bgcolor="#A8D08D">0,141 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,141</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency"></a>ResolveType_With_Transient_Dependency

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 1051,413 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5262,514 ns</td><td align="right" bgcolor="#A8D08D">4853,598 ns (Δ = -408,915 ns)</td><td align="right" bgcolor="#FFFFFF">4649,068 ns</td><td align="right" bgcolor="#FFFFFF">4724,259 ns</td><td align="right" bgcolor="#FFFFFF">4537,147 ns</td><td align="right" bgcolor="#A8D08D">4263,082 ns (Δ = -274,064 ns)</td><td align="right" bgcolor="#FFFFFF">4211,101 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,263 μs</td><td align="right" bgcolor="#FFFFFF">4,854 μs</td><td align="right" bgcolor="#FFFFFF">4,649 μs</td><td align="right" bgcolor="#FFFFFF">4,724 μs</td><td align="right" bgcolor="#FFFFFF">4,537 μs</td><td align="right" bgcolor="#FFFFFF">4,263 μs</td><td align="right" bgcolor="#FFFFFF">4,211 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,2 %</td><td align="right" bgcolor="#A8D08D">-1,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3036,000</td><td align="right" bgcolor="#A8D08D">3021,000 (Δ = -15,000)</td><td align="right" bgcolor="#FFFFFF">3021,000</td><td align="right" bgcolor="#FFFFFF">3021,000</td><td align="right" bgcolor="#FFFFFF">3021,000</td><td align="right" bgcolor="#A8D08D">2985,000 (Δ = -36,000)</td><td align="right" bgcolor="#A8D08D">2937,000 (Δ = -48,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,965</td><td align="right" bgcolor="#A8D08D">2,950 (Δ = -0,015)</td><td align="right" bgcolor="#FFFFFF">2,950</td><td align="right" bgcolor="#FFFFFF">2,950</td><td align="right" bgcolor="#FFFFFF">2,950</td><td align="right" bgcolor="#A8D08D">2,915 (Δ = -0,035)</td><td align="right" bgcolor="#A8D08D">2,868 (Δ = -0,047)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,000)</td></tr></table>


## <a name="TagHelper_Benchmark"></a>TagHelper_Benchmark

### <a name="TagHelper_Benchmark_AreTagsEqual"></a>AreTagsEqual

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 9,447 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,052 ns</td><td align="right" bgcolor="#FFFFFF">6,847 ns</td><td align="right" bgcolor="#FFFFFF">5,247 ns</td><td align="right" bgcolor="#FFFFFF">5,689 ns</td><td align="right" bgcolor="#FFFFFF">5,631 ns</td><td align="right" bgcolor="#FFFFFF">14,694 ns</td><td align="right" bgcolor="#FFFFFF">13,614 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TagHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 13997,654 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-94,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14412,618 ns</td><td align="right" bgcolor="#FFFFFF">14630,251 ns</td><td align="right" bgcolor="#A8D08D">12330,845 ns (Δ = -2299,406 ns)</td><td align="right" bgcolor="#FFFFFF">12218,632 ns</td><td align="right" bgcolor="#A8D08D">632,598 ns (Δ = -11586,034 ns)</td><td align="right" bgcolor="#FFFFFF">823,935 ns</td><td align="right" bgcolor="#FFFFFF">751,165 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14,413 μs</td><td align="right" bgcolor="#FFFFFF">14,630 μs</td><td align="right" bgcolor="#FFFFFF">12,331 μs</td><td align="right" bgcolor="#FFFFFF">12,219 μs</td><td align="right" bgcolor="#FFFFFF">0,633 μs</td><td align="right" bgcolor="#FFFFFF">0,824 μs</td><td align="right" bgcolor="#FFFFFF">0,751 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -8,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-97,4 %</td><td align="right" bgcolor="#A8D08D">-9,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">11033,000</td><td align="right" bgcolor="#A8D08D">10999,000 (Δ = -34,000)</td><td align="right" bgcolor="#FFFFFF">10999,000</td><td align="right" bgcolor="#FFFFFF">10999,000</td><td align="right" bgcolor="#A8D08D">282,000 (Δ = -10717,000)</td><td align="right" bgcolor="#A8D08D">256,000 (Δ = -26,000)</td><td align="right" bgcolor="#FFFFFF">256,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">10,774</td><td align="right" bgcolor="#A8D08D">10,741 (Δ = -0,033)</td><td align="right" bgcolor="#FFFFFF">10,741</td><td align="right" bgcolor="#FFFFFF">10,741</td><td align="right" bgcolor="#A8D08D">0,275 (Δ = -10,466)</td><td align="right" bgcolor="#A8D08D">0,250 (Δ = -0,025)</td><td align="right" bgcolor="#FFFFFF">0,250</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,011</td><td align="right" bgcolor="#A8D08D">0,010 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,010)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 23,417 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,589 ns</td><td align="right" bgcolor="#FFFFFF">22,830 ns</td><td align="right" bgcolor="#FFFFFF">18,064 ns</td><td align="right" bgcolor="#FFFFFF">21,810 ns</td><td align="right" bgcolor="#FFFFFF">30,247 ns</td><td align="right" bgcolor="#FFFFFF">27,384 ns</td><td align="right" bgcolor="#FFFFFF">41,481 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyEx"></a>GetAssemblyEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 24,358 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,390 ns</td><td align="right" bgcolor="#FFFFFF">16,402 ns</td><td align="right" bgcolor="#FFFFFF">13,878 ns</td><td align="right" bgcolor="#FFFFFF">17,694 ns</td><td align="right" bgcolor="#FFFFFF">22,934 ns</td><td align="right" bgcolor="#FFFFFF">23,139 ns</td><td align="right" bgcolor="#FFFFFF">38,236 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx"></a>GetAssemblyFullNameEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 38,104 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,675 ns</td><td align="right" bgcolor="#FFFFFF">18,905 ns</td><td align="right" bgcolor="#FFFFFF">17,035 ns</td><td align="right" bgcolor="#FFFFFF">20,122 ns</td><td align="right" bgcolor="#FFFFFF">29,219 ns</td><td align="right" bgcolor="#FFFFFF">31,831 ns</td><td align="right" bgcolor="#FFFFFF">55,139 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetBaseTypeEx"></a>GetBaseTypeEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 31,943 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,726 ns</td><td align="right" bgcolor="#FFFFFF">18,734 ns</td><td align="right" bgcolor="#FFFFFF">17,605 ns</td><td align="right" bgcolor="#FFFFFF">25,751 ns</td><td align="right" bgcolor="#FFFFFF">18,190 ns</td><td align="right" bgcolor="#FFFFFF">25,181 ns</td><td align="right" bgcolor="#FFFFFF">49,549 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorEx"></a>GetConstructorEx

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 253,930 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">278,616 ns</td><td align="right" bgcolor="#FFFFFF">188,033 ns</td><td align="right" bgcolor="#FFFFFF">233,519 ns</td><td align="right" bgcolor="#FFFFFF">214,277 ns</td><td align="right" bgcolor="#FFFFFF">256,739 ns</td><td align="right" bgcolor="#FFFFFF">319,570 ns</td><td align="right" bgcolor="#FFFFFF">441,963 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,257 μs</td><td align="right" bgcolor="#FFFFFF">0,320 μs</td><td align="right" bgcolor="#FFFFFF">0,442 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">133,000</td><td align="right" bgcolor="#FFFFFF">133,000</td><td align="right" bgcolor="#FFFFFF">133,000</td><td align="right" bgcolor="#FFFFFF">133,000</td><td align="right" bgcolor="#FFFFFF">133,000</td><td align="right" bgcolor="#A8D08D">128,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">128,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,130</td><td align="right" bgcolor="#FFFFFF">0,130</td><td align="right" bgcolor="#FFFFFF">0,130</td><td align="right" bgcolor="#FFFFFF">0,130</td><td align="right" bgcolor="#FFFFFF">0,130</td><td align="right" bgcolor="#A8D08D">0,125 (Δ = -0,005)</td><td align="right" bgcolor="#FFFFFF">0,125</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorsEx"></a>GetConstructorsEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 82,627 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">101,593 ns</td><td align="right" bgcolor="#FFFFFF">78,038 ns</td><td align="right" bgcolor="#FFFFFF">79,342 ns</td><td align="right" bgcolor="#FFFFFF">83,659 ns</td><td align="right" bgcolor="#FFFFFF">81,614 ns</td><td align="right" bgcolor="#FFFFFF">160,664 ns</td><td align="right" bgcolor="#FFFFFF">133,814 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,161 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">32,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">32,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,031 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,031</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **6.0.0**

Slowest: 5.9.0

Δ: 1904,691 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,3 %</td><td align="right" bgcolor="#FF4949">+52,0 %</td><td align="right" bgcolor="#A8D08D">-58,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2005,313 ns</td><td align="right" bgcolor="#A8D08D">1685,414 ns (Δ = -319,899 ns)</td><td align="right" bgcolor="#FFFFFF">1638,174 ns</td><td align="right" bgcolor="#FF4949">2150,849 ns (Δ = +512,675 ns)</td><td align="right" bgcolor="#FF4949">3268,805 ns (Δ = +1117,956 ns)</td><td align="right" bgcolor="#A8D08D">1366,293 ns (Δ = -1902,512 ns)</td><td align="right" bgcolor="#FFFFFF">1364,113 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,005 μs</td><td align="right" bgcolor="#FFFFFF">1,685 μs</td><td align="right" bgcolor="#FFFFFF">1,638 μs</td><td align="right" bgcolor="#FFFFFF">2,151 μs</td><td align="right" bgcolor="#FFFFFF">3,269 μs</td><td align="right" bgcolor="#FFFFFF">1,366 μs</td><td align="right" bgcolor="#FFFFFF">1,364 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">224,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">224,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,219 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,219</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 7444,684 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,7 %</td><td align="right" bgcolor="#FF4949">+13,3 %</td><td align="right" bgcolor="#FF4949">+32,3 %</td><td align="right" bgcolor="#FF4949">+16,1 %</td><td align="right" bgcolor="#A8D08D">-75,6 %</td><td align="right" bgcolor="#FF4949">+12,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6634,518 ns</td><td align="right" bgcolor="#A8D08D">5661,702 ns (Δ = -972,816 ns)</td><td align="right" bgcolor="#FF4949">6412,267 ns (Δ = +750,565 ns)</td><td align="right" bgcolor="#FF4949">8481,298 ns (Δ = +2069,031 ns)</td><td align="right" bgcolor="#FF4949">9850,621 ns (Δ = +1369,324 ns)</td><td align="right" bgcolor="#A8D08D">2405,938 ns (Δ = -7444,684 ns)</td><td align="right" bgcolor="#FF4949">2693,884 ns (Δ = +287,946 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,635 μs</td><td align="right" bgcolor="#FFFFFF">5,662 μs</td><td align="right" bgcolor="#FFFFFF">6,412 μs</td><td align="right" bgcolor="#FFFFFF">8,481 μs</td><td align="right" bgcolor="#FFFFFF">9,851 μs</td><td align="right" bgcolor="#FFFFFF">2,406 μs</td><td align="right" bgcolor="#FFFFFF">2,694 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-66,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#A8D08D">272,000 (Δ = -542,000)</td><td align="right" bgcolor="#FFFFFF">272,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#A8D08D">0,266 (Δ = -0,529)</td><td align="right" bgcolor="#FFFFFF">0,266</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 1489,455 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,2 %</td><td align="right" bgcolor="#FF4949">+26,0 %</td><td align="right" bgcolor="#A8D08D">-52,6 %</td><td align="right" bgcolor="#FF4949">+62,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2430,327 ns</td><td align="right" bgcolor="#A8D08D">1666,121 ns (Δ = -764,206 ns)</td><td align="right" bgcolor="#FFFFFF">1855,412 ns</td><td align="right" bgcolor="#FF4949">2249,020 ns (Δ = +393,608 ns)</td><td align="right" bgcolor="#FF4949">2833,510 ns (Δ = +584,490 ns)</td><td align="right" bgcolor="#A8D08D">1344,055 ns (Δ = -1489,455 ns)</td><td align="right" bgcolor="#FF4949">2177,588 ns (Δ = +833,532 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,430 μs</td><td align="right" bgcolor="#FFFFFF">1,666 μs</td><td align="right" bgcolor="#FFFFFF">1,855 μs</td><td align="right" bgcolor="#FFFFFF">2,249 μs</td><td align="right" bgcolor="#FFFFFF">2,834 μs</td><td align="right" bgcolor="#FFFFFF">1,344 μs</td><td align="right" bgcolor="#FFFFFF">2,178 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">224,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">224,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,219 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,219</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 7473,548 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,4 %</td><td align="right" bgcolor="#FF4949">+11,3 %</td><td align="right" bgcolor="#FF4949">+58,4 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#A8D08D">-74,2 %</td><td align="right" bgcolor="#FF4949">+71,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6661,569 ns</td><td align="right" bgcolor="#A8D08D">5636,764 ns (Δ = -1024,805 ns)</td><td align="right" bgcolor="#FF4949">6272,641 ns (Δ = +635,876 ns)</td><td align="right" bgcolor="#FF4949">9935,453 ns (Δ = +3662,812 ns)</td><td align="right" bgcolor="#A8D08D">9548,307 ns (Δ = -387,146 ns)</td><td align="right" bgcolor="#A8D08D">2461,904 ns (Δ = -7086,403 ns)</td><td align="right" bgcolor="#FF4949">4210,988 ns (Δ = +1749,083 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,662 μs</td><td align="right" bgcolor="#FFFFFF">5,637 μs</td><td align="right" bgcolor="#FFFFFF">6,273 μs</td><td align="right" bgcolor="#FFFFFF">9,935 μs</td><td align="right" bgcolor="#FFFFFF">9,548 μs</td><td align="right" bgcolor="#FFFFFF">2,462 μs</td><td align="right" bgcolor="#FFFFFF">4,211 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-66,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#FFFFFF">814,000</td><td align="right" bgcolor="#A8D08D">272,000 (Δ = -542,000)</td><td align="right" bgcolor="#FFFFFF">272,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#FFFFFF">0,795</td><td align="right" bgcolor="#A8D08D">0,266 (Δ = -0,529)</td><td align="right" bgcolor="#FFFFFF">0,266</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 20,263 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,920 ns</td><td align="right" bgcolor="#FFFFFF">4,976 ns</td><td align="right" bgcolor="#FFFFFF">4,674 ns</td><td align="right" bgcolor="#FFFFFF">5,822 ns</td><td align="right" bgcolor="#FFFFFF">6,974 ns</td><td align="right" bgcolor="#FFFFFF">16,663 ns</td><td align="right" bgcolor="#FFFFFF">24,938 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 135,589 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">526,958 ns</td><td align="right" bgcolor="#FFFFFF">497,482 ns</td><td align="right" bgcolor="#FFFFFF">454,928 ns</td><td align="right" bgcolor="#FFFFFF">465,664 ns</td><td align="right" bgcolor="#FFFFFF">429,277 ns</td><td align="right" bgcolor="#FFFFFF">391,369 ns</td><td align="right" bgcolor="#FFFFFF">447,988 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,527 μs</td><td align="right" bgcolor="#FFFFFF">0,497 μs</td><td align="right" bgcolor="#FFFFFF">0,455 μs</td><td align="right" bgcolor="#FFFFFF">0,466 μs</td><td align="right" bgcolor="#FFFFFF">0,429 μs</td><td align="right" bgcolor="#FFFFFF">0,391 μs</td><td align="right" bgcolor="#FFFFFF">0,448 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-61,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#A8D08D">96,000 (Δ = -150,000)</td><td align="right" bgcolor="#FFFFFF">96,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#A8D08D">0,094 (Δ = -0,146)</td><td align="right" bgcolor="#FFFFFF">0,094</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Instance"></a>GetEventEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 420,577 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+431,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">90,642 ns</td><td align="right" bgcolor="#FFFFFF">86,635 ns</td><td align="right" bgcolor="#FFFFFF">80,003 ns</td><td align="right" bgcolor="#FFFFFF">83,575 ns</td><td align="right" bgcolor="#FFFFFF">74,123 ns</td><td align="right" bgcolor="#FF4949">394,000 ns (Δ = +319,877 ns)</td><td align="right" bgcolor="#FFFFFF">494,700 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,394 μs</td><td align="right" bgcolor="#FFFFFF">0,495 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">96,000 (Δ = +96,000)</td><td align="right" bgcolor="#FFFFFF">96,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,094 (Δ = +0,094)</td><td align="right" bgcolor="#FFFFFF">0,094</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 1301,780 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+70,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2134,012 ns</td><td align="right" bgcolor="#FFFFFF">1890,491 ns</td><td align="right" bgcolor="#FFFFFF">1816,334 ns</td><td align="right" bgcolor="#FFFFFF">1856,309 ns</td><td align="right" bgcolor="#FFFFFF">1680,070 ns</td><td align="right" bgcolor="#FFFFFF">1751,547 ns</td><td align="right" bgcolor="#FF4949">2981,850 ns (Δ = +1230,303 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,134 μs</td><td align="right" bgcolor="#FFFFFF">1,890 μs</td><td align="right" bgcolor="#FFFFFF">1,816 μs</td><td align="right" bgcolor="#FFFFFF">1,856 μs</td><td align="right" bgcolor="#FFFFFF">1,680 μs</td><td align="right" bgcolor="#FFFFFF">1,752 μs</td><td align="right" bgcolor="#FFFFFF">2,982 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.6</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#FF4949">+284,8 %</td><td align="right" bgcolor="#A8D08D">-8,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FF4949">210,000 (Δ = +10,000)</td><td align="right" bgcolor="#FF4949">808,000 (Δ = +598,000)</td><td align="right" bgcolor="#A8D08D">739,000 (Δ = -69,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FF4949">0,205 (Δ = +0,010)</td><td align="right" bgcolor="#FF4949">0,789 (Δ = +0,584)</td><td align="right" bgcolor="#A8D08D">0,722 (Δ = -0,067)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 315,565 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">783,971 ns</td><td align="right" bgcolor="#FFFFFF">668,856 ns</td><td align="right" bgcolor="#FFFFFF">659,204 ns</td><td align="right" bgcolor="#FFFFFF">680,561 ns</td><td align="right" bgcolor="#FFFFFF">638,503 ns</td><td align="right" bgcolor="#FFFFFF">643,014 ns</td><td align="right" bgcolor="#FFFFFF">468,406 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,784 μs</td><td align="right" bgcolor="#FFFFFF">0,669 μs</td><td align="right" bgcolor="#FFFFFF">0,659 μs</td><td align="right" bgcolor="#FFFFFF">0,681 μs</td><td align="right" bgcolor="#FFFFFF">0,639 μs</td><td align="right" bgcolor="#FFFFFF">0,643 μs</td><td align="right" bgcolor="#FFFFFF">0,468 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-38,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">404,000</td><td align="right" bgcolor="#FFFFFF">404,000</td><td align="right" bgcolor="#FFFFFF">404,000</td><td align="right" bgcolor="#FFFFFF">404,000</td><td align="right" bgcolor="#FFFFFF">404,000</td><td align="right" bgcolor="#A8D08D">248,000 (Δ = -156,000)</td><td align="right" bgcolor="#FFFFFF">248,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,395</td><td align="right" bgcolor="#FFFFFF">0,395</td><td align="right" bgcolor="#FFFFFF">0,395</td><td align="right" bgcolor="#FFFFFF">0,395</td><td align="right" bgcolor="#FFFFFF">0,395</td><td align="right" bgcolor="#A8D08D">0,242 (Δ = -0,152)</td><td align="right" bgcolor="#FFFFFF">0,242</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 407,698 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+149,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">329,736 ns</td><td align="right" bgcolor="#FFFFFF">282,888 ns</td><td align="right" bgcolor="#FFFFFF">283,178 ns</td><td align="right" bgcolor="#FFFFFF">282,439 ns</td><td align="right" bgcolor="#FFFFFF">272,393 ns</td><td align="right" bgcolor="#FF4949">680,091 ns (Δ = +407,698 ns)</td><td align="right" bgcolor="#FFFFFF">512,932 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,330 μs</td><td align="right" bgcolor="#FFFFFF">0,283 μs</td><td align="right" bgcolor="#FFFFFF">0,283 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td><td align="right" bgcolor="#FFFFFF">0,680 μs</td><td align="right" bgcolor="#FFFFFF">0,513 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FF4949">392,000 (Δ = +85,000)</td><td align="right" bgcolor="#FFFFFF">392,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FF4949">0,383 (Δ = +0,083)</td><td align="right" bgcolor="#FFFFFF">0,383</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 419,289 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+61,7 %</td><td align="right" bgcolor="#A8D08D">-34,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">535,594 ns</td><td align="right" bgcolor="#FFFFFF">498,042 ns</td><td align="right" bgcolor="#FF4949">805,435 ns (Δ = +307,393 ns)</td><td align="right" bgcolor="#A8D08D">529,323 ns (Δ = -276,112 ns)</td><td align="right" bgcolor="#FFFFFF">436,415 ns</td><td align="right" bgcolor="#FFFFFF">386,146 ns</td><td align="right" bgcolor="#FFFFFF">497,888 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,536 μs</td><td align="right" bgcolor="#FFFFFF">0,498 μs</td><td align="right" bgcolor="#FFFFFF">0,805 μs</td><td align="right" bgcolor="#FFFFFF">0,529 μs</td><td align="right" bgcolor="#FFFFFF">0,436 μs</td><td align="right" bgcolor="#FFFFFF">0,386 μs</td><td align="right" bgcolor="#FFFFFF">0,498 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-61,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#A8D08D">96,000 (Δ = -150,000)</td><td align="right" bgcolor="#FFFFFF">96,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#A8D08D">0,094 (Δ = -0,146)</td><td align="right" bgcolor="#FFFFFF">0,094</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags"></a>GetFieldEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 66,558 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">104,945 ns</td><td align="right" bgcolor="#FFFFFF">83,860 ns</td><td align="right" bgcolor="#FFFFFF">89,365 ns</td><td align="right" bgcolor="#FFFFFF">84,628 ns</td><td align="right" bgcolor="#FFFFFF">73,054 ns</td><td align="right" bgcolor="#FFFFFF">139,613 ns</td><td align="right" bgcolor="#FFFFFF">97,075 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,089 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 432,806 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+359,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">105,246 ns</td><td align="right" bgcolor="#FFFFFF">95,083 ns</td><td align="right" bgcolor="#FFFFFF">101,936 ns</td><td align="right" bgcolor="#FFFFFF">95,746 ns</td><td align="right" bgcolor="#FFFFFF">84,419 ns</td><td align="right" bgcolor="#FF4949">387,727 ns (Δ = +303,308 ns)</td><td align="right" bgcolor="#FFFFFF">517,225 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,388 μs</td><td align="right" bgcolor="#FFFFFF">0,517 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">96,000 (Δ = +96,000)</td><td align="right" bgcolor="#FFFFFF">96,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,094 (Δ = +0,094)</td><td align="right" bgcolor="#FFFFFF">0,094</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **6.0.0**

Slowest: 5.12.0

Δ: 64,770 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">98,125 ns</td><td align="right" bgcolor="#FFFFFF">81,545 ns</td><td align="right" bgcolor="#FFFFFF">82,738 ns</td><td align="right" bgcolor="#FFFFFF">82,500 ns</td><td align="right" bgcolor="#FFFFFF">74,621 ns</td><td align="right" bgcolor="#FFFFFF">128,338 ns</td><td align="right" bgcolor="#FFFFFF">63,567 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 233,232 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">445,806 ns</td><td align="right" bgcolor="#FFFFFF">385,522 ns</td><td align="right" bgcolor="#FFFFFF">595,873 ns</td><td align="right" bgcolor="#FFFFFF">382,060 ns</td><td align="right" bgcolor="#FFFFFF">366,551 ns</td><td align="right" bgcolor="#FFFFFF">599,783 ns</td><td align="right" bgcolor="#FFFFFF">438,094 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,446 μs</td><td align="right" bgcolor="#FFFFFF">0,386 μs</td><td align="right" bgcolor="#FFFFFF">0,596 μs</td><td align="right" bgcolor="#FFFFFF">0,382 μs</td><td align="right" bgcolor="#FFFFFF">0,367 μs</td><td align="right" bgcolor="#FFFFFF">0,600 μs</td><td align="right" bgcolor="#FFFFFF">0,438 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">317,000</td><td align="right" bgcolor="#FF4949">348,000 (Δ = +31,000)</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FF4949">352,000 (Δ = +4,000)</td><td align="right" bgcolor="#FFFFFF">352,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,310</td><td align="right" bgcolor="#FF4949">0,340 (Δ = +0,030)</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FF4949">0,344 (Δ = +0,004)</td><td align="right" bgcolor="#FFFFFF">0,344</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **6.0.0**

Slowest: 5.12.0

Δ: 79,333 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">83,626 ns</td><td align="right" bgcolor="#FFFFFF">74,533 ns</td><td align="right" bgcolor="#FFFFFF">74,568 ns</td><td align="right" bgcolor="#FFFFFF">75,506 ns</td><td align="right" bgcolor="#FFFFFF">73,632 ns</td><td align="right" bgcolor="#FFFFFF">143,112 ns</td><td align="right" bgcolor="#FFFFFF">63,779 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 186,113 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">672,104 ns</td><td align="right" bgcolor="#FFFFFF">649,990 ns</td><td align="right" bgcolor="#FFFFFF">618,045 ns</td><td align="right" bgcolor="#FFFFFF">648,563 ns</td><td align="right" bgcolor="#FFFFFF">616,954 ns</td><td align="right" bgcolor="#FFFFFF">660,898 ns</td><td align="right" bgcolor="#FFFFFF">485,991 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,672 μs</td><td align="right" bgcolor="#FFFFFF">0,650 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,649 μs</td><td align="right" bgcolor="#FFFFFF">0,617 μs</td><td align="right" bgcolor="#FFFFFF">0,661 μs</td><td align="right" bgcolor="#FFFFFF">0,486 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.4</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-34,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">358,000</td><td align="right" bgcolor="#FF4949">389,000 (Δ = +31,000)</td><td align="right" bgcolor="#FFFFFF">389,000</td><td align="right" bgcolor="#FFFFFF">389,000</td><td align="right" bgcolor="#FFFFFF">389,000</td><td align="right" bgcolor="#A8D08D">256,000 (Δ = -133,000)</td><td align="right" bgcolor="#FFFFFF">256,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,350</td><td align="right" bgcolor="#FF4949">0,380 (Δ = +0,030)</td><td align="right" bgcolor="#FFFFFF">0,380</td><td align="right" bgcolor="#FFFFFF">0,380</td><td align="right" bgcolor="#FFFFFF">0,380</td><td align="right" bgcolor="#A8D08D">0,250 (Δ = -0,130)</td><td align="right" bgcolor="#FFFFFF">0,250</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **6.0.0**

Slowest: 5.12.0

Δ: 58,311 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">81,442 ns</td><td align="right" bgcolor="#FFFFFF">77,737 ns</td><td align="right" bgcolor="#FFFFFF">77,016 ns</td><td align="right" bgcolor="#FFFFFF">75,979 ns</td><td align="right" bgcolor="#FFFFFF">74,045 ns</td><td align="right" bgcolor="#FFFFFF">121,963 ns</td><td align="right" bgcolor="#FFFFFF">63,651 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 167,733 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">124,499 ns</td><td align="right" bgcolor="#FFFFFF">115,497 ns</td><td align="right" bgcolor="#FFFFFF">110,471 ns</td><td align="right" bgcolor="#FFFFFF">148,845 ns</td><td align="right" bgcolor="#FFFFFF">110,419 ns</td><td align="right" bgcolor="#FFFFFF">187,704 ns</td><td align="right" bgcolor="#FFFFFF">278,152 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td><td align="right" bgcolor="#FFFFFF">0,278 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">32,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">32,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,031 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,031</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx"></a>GetGenericTypeDefinitionEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 87,486 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">62,896 ns</td><td align="right" bgcolor="#FFFFFF">60,601 ns</td><td align="right" bgcolor="#FFFFFF">57,410 ns</td><td align="right" bgcolor="#FFFFFF">74,764 ns</td><td align="right" bgcolor="#FFFFFF">68,053 ns</td><td align="right" bgcolor="#FFFFFF">130,375 ns</td><td align="right" bgcolor="#FFFFFF">144,896 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,130 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetInterfacesEx"></a>GetInterfacesEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 31,244 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">112,468 ns</td><td align="right" bgcolor="#FFFFFF">98,689 ns</td><td align="right" bgcolor="#FFFFFF">92,753 ns</td><td align="right" bgcolor="#FFFFFF">123,997 ns</td><td align="right" bgcolor="#FFFFFF">97,183 ns</td><td align="right" bgcolor="#FFFFFF">119,925 ns</td><td align="right" bgcolor="#FFFFFF">119,751 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.9</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,1 %</td><td align="right" bgcolor="#A8D08D">-2,4 %</td><td align="right" bgcolor="#A8D08D">-8,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">195,000</td><td align="right" bgcolor="#FFFFFF">195,000</td><td align="right" bgcolor="#FFFFFF">195,000</td><td align="right" bgcolor="#FFFFFF">195,000</td><td align="right" bgcolor="#FF4949">205,000 (Δ = +10,000)</td><td align="right" bgcolor="#A8D08D">200,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">184,000 (Δ = -16,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FF4949">0,200 (Δ = +0,010)</td><td align="right" bgcolor="#A8D08D">0,195 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">0,180 (Δ = -0,016)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 388,276 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1088,489 ns</td><td align="right" bgcolor="#FFFFFF">928,956 ns</td><td align="right" bgcolor="#FFFFFF">952,852 ns</td><td align="right" bgcolor="#FFFFFF">969,021 ns</td><td align="right" bgcolor="#FFFFFF">890,153 ns</td><td align="right" bgcolor="#FFFFFF">769,847 ns</td><td align="right" bgcolor="#FFFFFF">700,213 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,088 μs</td><td align="right" bgcolor="#FFFFFF">0,929 μs</td><td align="right" bgcolor="#FFFFFF">0,953 μs</td><td align="right" bgcolor="#FFFFFF">0,969 μs</td><td align="right" bgcolor="#FFFFFF">0,890 μs</td><td align="right" bgcolor="#FFFFFF">0,770 μs</td><td align="right" bgcolor="#FFFFFF">0,700 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-55,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">271,000</td><td align="right" bgcolor="#FFFFFF">271,000</td><td align="right" bgcolor="#FFFFFF">271,000</td><td align="right" bgcolor="#FFFFFF">271,000</td><td align="right" bgcolor="#FFFFFF">271,000</td><td align="right" bgcolor="#A8D08D">120,000 (Δ = -151,000)</td><td align="right" bgcolor="#FFFFFF">120,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,265</td><td align="right" bgcolor="#FFFFFF">0,265</td><td align="right" bgcolor="#FFFFFF">0,265</td><td align="right" bgcolor="#FFFFFF">0,265</td><td align="right" bgcolor="#FFFFFF">0,265</td><td align="right" bgcolor="#A8D08D">0,117 (Δ = -0,147)</td><td align="right" bgcolor="#FFFFFF">0,117</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **6.0.0**

Slowest: 5.5.0

Δ: 268,028 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">560,799 ns</td><td align="right" bgcolor="#FFFFFF">471,804 ns</td><td align="right" bgcolor="#FFFFFF">662,510 ns</td><td align="right" bgcolor="#FFFFFF">471,729 ns</td><td align="right" bgcolor="#FFFFFF">456,777 ns</td><td align="right" bgcolor="#FFFFFF">444,701 ns</td><td align="right" bgcolor="#FFFFFF">394,482 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,561 μs</td><td align="right" bgcolor="#FFFFFF">0,472 μs</td><td align="right" bgcolor="#FFFFFF">0,663 μs</td><td align="right" bgcolor="#FFFFFF">0,472 μs</td><td align="right" bgcolor="#FFFFFF">0,457 μs</td><td align="right" bgcolor="#FFFFFF">0,445 μs</td><td align="right" bgcolor="#FFFFFF">0,394 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#A8D08D">24,000 (Δ = -7,000)</td><td align="right" bgcolor="#FFFFFF">24,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#A8D08D">0,023 (Δ = -0,007)</td><td align="right" bgcolor="#FFFFFF">0,023</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance"></a>GetMemberEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 315,103 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+69,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">562,736 ns</td><td align="right" bgcolor="#FFFFFF">471,947 ns</td><td align="right" bgcolor="#FFFFFF">481,592 ns</td><td align="right" bgcolor="#FFFFFF">474,585 ns</td><td align="right" bgcolor="#FFFFFF">453,126 ns</td><td align="right" bgcolor="#FF4949">768,229 ns (Δ = +315,103 ns)</td><td align="right" bgcolor="#FFFFFF">691,334 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,563 μs</td><td align="right" bgcolor="#FFFFFF">0,472 μs</td><td align="right" bgcolor="#FFFFFF">0,482 μs</td><td align="right" bgcolor="#FFFFFF">0,475 μs</td><td align="right" bgcolor="#FFFFFF">0,453 μs</td><td align="right" bgcolor="#FFFFFF">0,768 μs</td><td align="right" bgcolor="#FFFFFF">0,691 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+255,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FF4949">128,000 (Δ = +92,000)</td><td align="right" bgcolor="#FFFFFF">128,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FF4949">0,125 (Δ = +0,090)</td><td align="right" bgcolor="#FFFFFF">0,125</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 74,894 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">479,749 ns</td><td align="right" bgcolor="#FFFFFF">448,529 ns</td><td align="right" bgcolor="#FFFFFF">502,327 ns</td><td align="right" bgcolor="#FFFFFF">453,159 ns</td><td align="right" bgcolor="#FFFFFF">481,952 ns</td><td align="right" bgcolor="#FFFFFF">427,432 ns</td><td align="right" bgcolor="#FFFFFF">460,781 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,480 μs</td><td align="right" bgcolor="#FFFFFF">0,449 μs</td><td align="right" bgcolor="#FFFFFF">0,502 μs</td><td align="right" bgcolor="#FFFFFF">0,453 μs</td><td align="right" bgcolor="#FFFFFF">0,482 μs</td><td align="right" bgcolor="#FFFFFF">0,427 μs</td><td align="right" bgcolor="#FFFFFF">0,461 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#A8D08D">24,000 (Δ = -7,000)</td><td align="right" bgcolor="#FFFFFF">24,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#FFFFFF">0,030</td><td align="right" bgcolor="#A8D08D">0,023 (Δ = -0,007)</td><td align="right" bgcolor="#FFFFFF">0,023</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static"></a>GetMethodEx_Flatten_Static

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 248,026 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">653,215 ns</td><td align="right" bgcolor="#FFFFFF">492,007 ns</td><td align="right" bgcolor="#FFFFFF">470,306 ns</td><td align="right" bgcolor="#FFFFFF">506,379 ns</td><td align="right" bgcolor="#FFFFFF">470,006 ns</td><td align="right" bgcolor="#FFFFFF">405,189 ns</td><td align="right" bgcolor="#FFFFFF">565,188 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,653 μs</td><td align="right" bgcolor="#FFFFFF">0,492 μs</td><td align="right" bgcolor="#FFFFFF">0,470 μs</td><td align="right" bgcolor="#FFFFFF">0,506 μs</td><td align="right" bgcolor="#FFFFFF">0,470 μs</td><td align="right" bgcolor="#FFFFFF">0,405 μs</td><td align="right" bgcolor="#FFFFFF">0,565 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-61,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#A8D08D">96,000 (Δ = -150,000)</td><td align="right" bgcolor="#FFFFFF">96,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#A8D08D">0,094 (Δ = -0,146)</td><td align="right" bgcolor="#FFFFFF">0,094</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags"></a>GetMethodEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 54,711 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">117,512 ns</td><td align="right" bgcolor="#FFFFFF">128,004 ns</td><td align="right" bgcolor="#FFFFFF">116,382 ns</td><td align="right" bgcolor="#FFFFFF">100,442 ns</td><td align="right" bgcolor="#FFFFFF">92,652 ns</td><td align="right" bgcolor="#FFFFFF">147,363 ns</td><td align="right" bgcolor="#FFFFFF">121,400 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,116 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 415,558 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+310,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">127,417 ns</td><td align="right" bgcolor="#FFFFFF">116,271 ns</td><td align="right" bgcolor="#FFFFFF">117,906 ns</td><td align="right" bgcolor="#FFFFFF">110,999 ns</td><td align="right" bgcolor="#FFFFFF">98,942 ns</td><td align="right" bgcolor="#FF4949">406,372 ns (Δ = +307,431 ns)</td><td align="right" bgcolor="#FFFFFF">514,500 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,116 μs</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,406 μs</td><td align="right" bgcolor="#FFFFFF">0,515 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">96,000 (Δ = +96,000)</td><td align="right" bgcolor="#FFFFFF">96,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,094 (Δ = +0,094)</td><td align="right" bgcolor="#FFFFFF">0,094</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 51,242 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">117,389 ns</td><td align="right" bgcolor="#FFFFFF">101,292 ns</td><td align="right" bgcolor="#FFFFFF">107,013 ns</td><td align="right" bgcolor="#FFFFFF">102,434 ns</td><td align="right" bgcolor="#FFFFFF">93,283 ns</td><td align="right" bgcolor="#FFFFFF">144,525 ns</td><td align="right" bgcolor="#FFFFFF">136,950 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,117 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,137 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 1852,682 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,8 %</td><td align="right" bgcolor="#A8D08D">-24,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#FF4949">+9,6 %</td><td align="right" bgcolor="#FF4949">+42,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3771,203 ns</td><td align="right" bgcolor="#FF4949">4631,851 ns (Δ = +860,648 ns)</td><td align="right" bgcolor="#A8D08D">3515,654 ns (Δ = -1116,197 ns)</td><td align="right" bgcolor="#FFFFFF">3648,113 ns</td><td align="right" bgcolor="#A8D08D">3333,668 ns (Δ = -314,444 ns)</td><td align="right" bgcolor="#FF4949">3652,827 ns (Δ = +319,158 ns)</td><td align="right" bgcolor="#FF4949">5186,350 ns (Δ = +1533,523 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,771 μs</td><td align="right" bgcolor="#FFFFFF">4,632 μs</td><td align="right" bgcolor="#FFFFFF">3,516 μs</td><td align="right" bgcolor="#FFFFFF">3,648 μs</td><td align="right" bgcolor="#FFFFFF">3,334 μs</td><td align="right" bgcolor="#FFFFFF">3,653 μs</td><td align="right" bgcolor="#FFFFFF">5,186 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.9</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,7 %</td><td align="right" bgcolor="#FF4949">+1,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,2 %</td><td align="right" bgcolor="#A8D08D">-2,8 %</td><td align="right" bgcolor="#A8D08D">-5,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">2059,000</td><td align="right" bgcolor="#FF4949">2115,000 (Δ = +56,000)</td><td align="right" bgcolor="#FF4949">2136,000 (Δ = +21,000)</td><td align="right" bgcolor="#FFFFFF">2136,000</td><td align="right" bgcolor="#FF4949">2141,000 (Δ = +5,000)</td><td align="right" bgcolor="#A8D08D">2080,000 (Δ = -61,000)</td><td align="right" bgcolor="#A8D08D">1968,000 (Δ = -112,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,011</td><td align="right" bgcolor="#FF4949">2,065 (Δ = +0,055)</td><td align="right" bgcolor="#FF4949">2,086 (Δ = +0,021)</td><td align="right" bgcolor="#FFFFFF">2,086</td><td align="right" bgcolor="#FF4949">2,091 (Δ = +0,005)</td><td align="right" bgcolor="#A8D08D">2,031 (Δ = -0,060)</td><td align="right" bgcolor="#A8D08D">1,922 (Δ = -0,109)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 509,801 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+28,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">892,242 ns</td><td align="right" bgcolor="#FFFFFF">835,968 ns</td><td align="right" bgcolor="#FFFFFF">767,561 ns</td><td align="right" bgcolor="#FFFFFF">881,835 ns</td><td align="right" bgcolor="#FFFFFF">753,999 ns</td><td align="right" bgcolor="#FFFFFF">981,046 ns</td><td align="right" bgcolor="#FF4949">1263,800 ns (Δ = +282,754 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,892 μs</td><td align="right" bgcolor="#FFFFFF">0,836 μs</td><td align="right" bgcolor="#FFFFFF">0,768 μs</td><td align="right" bgcolor="#FFFFFF">0,882 μs</td><td align="right" bgcolor="#FFFFFF">0,754 μs</td><td align="right" bgcolor="#FFFFFF">0,981 μs</td><td align="right" bgcolor="#FFFFFF">1,264 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -20,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,020)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 2872,930 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,5 %</td><td align="right" bgcolor="#A8D08D">-7,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,6 %</td><td align="right" bgcolor="#FF4949">+26,1 %</td><td align="right" bgcolor="#FF4949">+56,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3608,618 ns</td><td align="right" bgcolor="#A8D08D">3339,286 ns (Δ = -269,332 ns)</td><td align="right" bgcolor="#A8D08D">3083,749 ns (Δ = -255,537 ns)</td><td align="right" bgcolor="#FFFFFF">3252,018 ns</td><td align="right" bgcolor="#A8D08D">2940,432 ns (Δ = -311,585 ns)</td><td align="right" bgcolor="#FF4949">3708,082 ns (Δ = +767,650 ns)</td><td align="right" bgcolor="#FF4949">5813,363 ns (Δ = +2105,280 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,609 μs</td><td align="right" bgcolor="#FFFFFF">3,339 μs</td><td align="right" bgcolor="#FFFFFF">3,084 μs</td><td align="right" bgcolor="#FFFFFF">3,252 μs</td><td align="right" bgcolor="#FFFFFF">2,940 μs</td><td align="right" bgcolor="#FFFFFF">3,708 μs</td><td align="right" bgcolor="#FFFFFF">5,813 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,3 %</td><td align="right" bgcolor="#FF4949">+7,6 %</td><td align="right" bgcolor="#A8D08D">-6,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3483,000</td><td align="right" bgcolor="#FF4949">3596,000 (Δ = +113,000)</td><td align="right" bgcolor="#FFFFFF">3596,000</td><td align="right" bgcolor="#FFFFFF">3596,000</td><td align="right" bgcolor="#FF4949">3643,000 (Δ = +47,000)</td><td align="right" bgcolor="#FF4949">3920,000 (Δ = +277,000)</td><td align="right" bgcolor="#A8D08D">3680,000 (Δ = -240,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,401</td><td align="right" bgcolor="#FF4949">3,512 (Δ = +0,110)</td><td align="right" bgcolor="#FFFFFF">3,512</td><td align="right" bgcolor="#FFFFFF">3,512</td><td align="right" bgcolor="#FF4949">3,558 (Δ = +0,046)</td><td align="right" bgcolor="#FF4949">3,828 (Δ = +0,271)</td><td align="right" bgcolor="#A8D08D">3,594 (Δ = -0,234)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,004 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,004 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 579,031 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+35,0 %</td><td align="right" bgcolor="#FF4949">+33,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">931,364 ns</td><td align="right" bgcolor="#FFFFFF">754,756 ns</td><td align="right" bgcolor="#FFFFFF">850,353 ns</td><td align="right" bgcolor="#FFFFFF">852,858 ns</td><td align="right" bgcolor="#FFFFFF">728,494 ns</td><td align="right" bgcolor="#FF4949">983,178 ns (Δ = +254,684 ns)</td><td align="right" bgcolor="#FF4949">1307,526 ns (Δ = +324,347 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,931 μs</td><td align="right" bgcolor="#FFFFFF">0,755 μs</td><td align="right" bgcolor="#FFFFFF">0,850 μs</td><td align="right" bgcolor="#FFFFFF">0,853 μs</td><td align="right" bgcolor="#FFFFFF">0,728 μs</td><td align="right" bgcolor="#FFFFFF">0,983 μs</td><td align="right" bgcolor="#FFFFFF">1,308 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -20,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,020)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **6.0.0**

Slowest: 5.9.0

Δ: 574,503 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+54,0 %</td><td align="right" bgcolor="#A8D08D">-42,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">601,579 ns</td><td align="right" bgcolor="#FFFFFF">470,537 ns</td><td align="right" bgcolor="#FFFFFF">469,400 ns</td><td align="right" bgcolor="#FFFFFF">659,281 ns</td><td align="right" bgcolor="#FF4949">1015,387 ns (Δ = +356,105 ns)</td><td align="right" bgcolor="#A8D08D">582,633 ns (Δ = -432,754 ns)</td><td align="right" bgcolor="#FFFFFF">440,884 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,602 μs</td><td align="right" bgcolor="#FFFFFF">0,471 μs</td><td align="right" bgcolor="#FFFFFF">0,469 μs</td><td align="right" bgcolor="#FFFFFF">0,659 μs</td><td align="right" bgcolor="#FFFFFF">1,015 μs</td><td align="right" bgcolor="#FFFFFF">0,583 μs</td><td align="right" bgcolor="#FFFFFF">0,441 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.9</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#A8D08D">-5,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FF4949">276,000 (Δ = +10,000)</td><td align="right" bgcolor="#A8D08D">272,000 (Δ = -4,000)</td><td align="right" bgcolor="#A8D08D">256,000 (Δ = -16,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FF4949">0,270 (Δ = +0,010)</td><td align="right" bgcolor="#A8D08D">0,266 (Δ = -0,004)</td><td align="right" bgcolor="#A8D08D">0,250 (Δ = -0,016)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 332,874 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1007,902 ns</td><td align="right" bgcolor="#FFFFFF">961,426 ns</td><td align="right" bgcolor="#FFFFFF">826,551 ns</td><td align="right" bgcolor="#FFFFFF">872,432 ns</td><td align="right" bgcolor="#FFFFFF">829,411 ns</td><td align="right" bgcolor="#FFFFFF">875,083 ns</td><td align="right" bgcolor="#FF4949">1159,425 ns (Δ = +284,342 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,008 μs</td><td align="right" bgcolor="#FFFFFF">0,961 μs</td><td align="right" bgcolor="#FFFFFF">0,827 μs</td><td align="right" bgcolor="#FFFFFF">0,872 μs</td><td align="right" bgcolor="#FFFFFF">0,829 μs</td><td align="right" bgcolor="#FFFFFF">0,875 μs</td><td align="right" bgcolor="#FFFFFF">1,159 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">548,000</td><td align="right" bgcolor="#FFFFFF">548,000</td><td align="right" bgcolor="#FFFFFF">548,000</td><td align="right" bgcolor="#FFFFFF">548,000</td><td align="right" bgcolor="#FFFFFF">548,000</td><td align="right" bgcolor="#A8D08D">408,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">408,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,535</td><td align="right" bgcolor="#FFFFFF">0,535</td><td align="right" bgcolor="#FFFFFF">0,535</td><td align="right" bgcolor="#FFFFFF">0,535</td><td align="right" bgcolor="#FFFFFF">0,535</td><td align="right" bgcolor="#A8D08D">0,398 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,398</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 659,460 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+98,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">525,769 ns</td><td align="right" bgcolor="#FFFFFF">455,142 ns</td><td align="right" bgcolor="#FFFFFF">458,013 ns</td><td align="right" bgcolor="#FFFFFF">441,196 ns</td><td align="right" bgcolor="#FFFFFF">439,641 ns</td><td align="right" bgcolor="#FF4949">870,755 ns (Δ = +431,114 ns)</td><td align="right" bgcolor="#FFFFFF">1099,102 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,526 μs</td><td align="right" bgcolor="#FFFFFF">0,455 μs</td><td align="right" bgcolor="#FFFFFF">0,458 μs</td><td align="right" bgcolor="#FFFFFF">0,441 μs</td><td align="right" bgcolor="#FFFFFF">0,440 μs</td><td align="right" bgcolor="#FFFFFF">0,871 μs</td><td align="right" bgcolor="#FFFFFF">1,099 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">563,000</td><td align="right" bgcolor="#FFFFFF">563,000</td><td align="right" bgcolor="#FFFFFF">563,000</td><td align="right" bgcolor="#FFFFFF">563,000</td><td align="right" bgcolor="#FFFFFF">563,000</td><td align="right" bgcolor="#FF4949">688,000 (Δ = +125,000)</td><td align="right" bgcolor="#FFFFFF">688,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,550</td><td align="right" bgcolor="#FFFFFF">0,550</td><td align="right" bgcolor="#FFFFFF">0,550</td><td align="right" bgcolor="#FFFFFF">0,550</td><td align="right" bgcolor="#FFFFFF">0,550</td><td align="right" bgcolor="#FF4949">0,672 (Δ = +0,122)</td><td align="right" bgcolor="#FFFFFF">0,672</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **6.0.0**

Slowest: 5.12.0

Δ: 91,651 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">150,958 ns</td><td align="right" bgcolor="#FFFFFF">131,103 ns</td><td align="right" bgcolor="#FFFFFF">129,286 ns</td><td align="right" bgcolor="#FFFFFF">131,543 ns</td><td align="right" bgcolor="#FFFFFF">125,331 ns</td><td align="right" bgcolor="#FFFFFF">161,363 ns</td><td align="right" bgcolor="#FFFFFF">69,712 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,151 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,161 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -15,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,015</td><td align="right" bgcolor="#FFFFFF">0,015</td><td align="right" bgcolor="#FFFFFF">0,015</td><td align="right" bgcolor="#FFFFFF">0,015</td><td align="right" bgcolor="#FFFFFF">0,015</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,015)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 155,118 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">581,667 ns</td><td align="right" bgcolor="#FFFFFF">476,394 ns</td><td align="right" bgcolor="#FFFFFF">540,549 ns</td><td align="right" bgcolor="#FFFFFF">519,454 ns</td><td align="right" bgcolor="#FFFFFF">454,662 ns</td><td align="right" bgcolor="#FFFFFF">426,548 ns</td><td align="right" bgcolor="#FFFFFF">538,106 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,582 μs</td><td align="right" bgcolor="#FFFFFF">0,476 μs</td><td align="right" bgcolor="#FFFFFF">0,541 μs</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td><td align="right" bgcolor="#FFFFFF">0,455 μs</td><td align="right" bgcolor="#FFFFFF">0,427 μs</td><td align="right" bgcolor="#FFFFFF">0,538 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#FFFFFF">246,000</td><td align="right" bgcolor="#A8D08D">120,000 (Δ = -126,000)</td><td align="right" bgcolor="#FFFFFF">120,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#FFFFFF">0,240</td><td align="right" bgcolor="#A8D08D">0,117 (Δ = -0,123)</td><td align="right" bgcolor="#FFFFFF">0,117</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance"></a>GetPropertyEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 417,626 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+357,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">130,400 ns</td><td align="right" bgcolor="#FFFFFF">108,671 ns</td><td align="right" bgcolor="#FFFFFF">108,203 ns</td><td align="right" bgcolor="#FFFFFF">109,401 ns</td><td align="right" bgcolor="#FFFFFF">94,711 ns</td><td align="right" bgcolor="#FF4949">433,531 ns (Δ = +338,820 ns)</td><td align="right" bgcolor="#FFFFFF">512,338 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,130 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,434 μs</td><td align="right" bgcolor="#FFFFFF">0,512 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">120,000 (Δ = +120,000)</td><td align="right" bgcolor="#FFFFFF">120,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,117 (Δ = +0,117)</td><td align="right" bgcolor="#FFFFFF">0,117</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 735,802 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+42,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2068,678 ns</td><td align="right" bgcolor="#FFFFFF">2015,582 ns</td><td align="right" bgcolor="#FFFFFF">1853,946 ns</td><td align="right" bgcolor="#FFFFFF">1853,651 ns</td><td align="right" bgcolor="#FFFFFF">1712,548 ns</td><td align="right" bgcolor="#FFFFFF">1722,163 ns</td><td align="right" bgcolor="#FF4949">2448,350 ns (Δ = +726,187 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,069 μs</td><td align="right" bgcolor="#FFFFFF">2,016 μs</td><td align="right" bgcolor="#FFFFFF">1,854 μs</td><td align="right" bgcolor="#FFFFFF">1,854 μs</td><td align="right" bgcolor="#FFFFFF">1,713 μs</td><td align="right" bgcolor="#FFFFFF">1,722 μs</td><td align="right" bgcolor="#FFFFFF">2,448 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.6</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#FF4949">+284,8 %</td><td align="right" bgcolor="#A8D08D">-8,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FF4949">210,000 (Δ = +10,000)</td><td align="right" bgcolor="#FF4949">808,000 (Δ = +598,000)</td><td align="right" bgcolor="#A8D08D">739,000 (Δ = -69,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FF4949">0,205 (Δ = +0,010)</td><td align="right" bgcolor="#FF4949">0,789 (Δ = +0,584)</td><td align="right" bgcolor="#A8D08D">0,722 (Δ = -0,067)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 144,058 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">144,569 ns</td><td align="right" bgcolor="#FFFFFF">131,400 ns</td><td align="right" bgcolor="#FFFFFF">124,790 ns</td><td align="right" bgcolor="#FFFFFF">167,179 ns</td><td align="right" bgcolor="#FFFFFF">268,848 ns</td><td align="right" bgcolor="#FFFFFF">221,375 ns</td><td align="right" bgcolor="#FFFFFF">158,013 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#FFFFFF">0,269 μs</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">317,000</td><td align="right" bgcolor="#FFFFFF">317,000</td><td align="right" bgcolor="#FFFFFF">317,000</td><td align="right" bgcolor="#FFFFFF">317,000</td><td align="right" bgcolor="#FFFFFF">317,000</td><td align="right" bgcolor="#A8D08D">312,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">312,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,310</td><td align="right" bgcolor="#FFFFFF">0,310</td><td align="right" bgcolor="#FFFFFF">0,310</td><td align="right" bgcolor="#FFFFFF">0,310</td><td align="right" bgcolor="#FFFFFF">0,310</td><td align="right" bgcolor="#A8D08D">0,305 (Δ = -0,005)</td><td align="right" bgcolor="#FFFFFF">0,305</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetTypeInfo"></a>GetTypeInfo

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 14,333 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,589 ns</td><td align="right" bgcolor="#FFFFFF">8,750 ns</td><td align="right" bgcolor="#FFFFFF">8,849 ns</td><td align="right" bgcolor="#FFFFFF">9,569 ns</td><td align="right" bgcolor="#FFFFFF">8,230 ns</td><td align="right" bgcolor="#FFFFFF">12,976 ns</td><td align="right" bgcolor="#FFFFFF">22,563 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_HasBaseTypeEx"></a>HasBaseTypeEx

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 29,852 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,166 ns</td><td align="right" bgcolor="#FFFFFF">23,314 ns</td><td align="right" bgcolor="#FFFFFF">23,618 ns</td><td align="right" bgcolor="#FFFFFF">27,811 ns</td><td align="right" bgcolor="#FFFFFF">39,044 ns</td><td align="right" bgcolor="#FFFFFF">30,597 ns</td><td align="right" bgcolor="#FFFFFF">53,166 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx"></a>ImplementsInterfaceEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 51,801 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,066 ns</td><td align="right" bgcolor="#FFFFFF">25,200 ns</td><td align="right" bgcolor="#FFFFFF">23,277 ns</td><td align="right" bgcolor="#FFFFFF">29,337 ns</td><td align="right" bgcolor="#FFFFFF">41,596 ns</td><td align="right" bgcolor="#FFFFFF">34,918 ns</td><td align="right" bgcolor="#FFFFFF">75,078 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx"></a>ImplementsInterfacesEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 42,829 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,979 ns</td><td align="right" bgcolor="#FFFFFF">21,949 ns</td><td align="right" bgcolor="#FFFFFF">20,948 ns</td><td align="right" bgcolor="#FFFFFF">26,176 ns</td><td align="right" bgcolor="#FFFFFF">39,391 ns</td><td align="right" bgcolor="#FFFFFF">29,796 ns</td><td align="right" bgcolor="#FFFFFF">63,777 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAbstractEx"></a>IsAbstractEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 18,656 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17,110 ns</td><td align="right" bgcolor="#FFFFFF">11,922 ns</td><td align="right" bgcolor="#FFFFFF">10,220 ns</td><td align="right" bgcolor="#FFFFFF">15,172 ns</td><td align="right" bgcolor="#FFFFFF">18,626 ns</td><td align="right" bgcolor="#FFFFFF">15,153 ns</td><td align="right" bgcolor="#FFFFFF">28,876 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsArrayEx"></a>IsArrayEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 24,660 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,568 ns</td><td align="right" bgcolor="#FFFFFF">13,251 ns</td><td align="right" bgcolor="#FFFFFF">13,061 ns</td><td align="right" bgcolor="#FFFFFF">17,406 ns</td><td align="right" bgcolor="#FFFFFF">23,679 ns</td><td align="right" bgcolor="#FFFFFF">19,508 ns</td><td align="right" bgcolor="#FFFFFF">37,721 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAssignableFromEx"></a>IsAssignableFromEx

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 36,096 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,184 ns</td><td align="right" bgcolor="#FFFFFF">16,514 ns</td><td align="right" bgcolor="#FFFFFF">16,073 ns</td><td align="right" bgcolor="#FFFFFF">21,325 ns</td><td align="right" bgcolor="#FFFFFF">16,040 ns</td><td align="right" bgcolor="#FFFFFF">25,239 ns</td><td align="right" bgcolor="#FFFFFF">52,135 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **6.0.0**

Slowest: 5.9.0

Δ: 381,674 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-54,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">369,988 ns</td><td align="right" bgcolor="#FFFFFF">345,868 ns</td><td align="right" bgcolor="#FFFFFF">297,658 ns</td><td align="right" bgcolor="#FFFFFF">421,153 ns</td><td align="right" bgcolor="#FFFFFF">617,299 ns</td><td align="right" bgcolor="#A8D08D">281,130 ns (Δ = -336,168 ns)</td><td align="right" bgcolor="#FFFFFF">235,625 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,370 μs</td><td align="right" bgcolor="#FFFFFF">0,346 μs</td><td align="right" bgcolor="#FFFFFF">0,298 μs</td><td align="right" bgcolor="#FFFFFF">0,421 μs</td><td align="right" bgcolor="#FFFFFF">0,617 μs</td><td align="right" bgcolor="#FFFFFF">0,281 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsClassEx"></a>IsClassEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 134,145 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">146,026 ns</td><td align="right" bgcolor="#FFFFFF">187,345 ns</td><td align="right" bgcolor="#FFFFFF">115,175 ns</td><td align="right" bgcolor="#FFFFFF">138,109 ns</td><td align="right" bgcolor="#FFFFFF">249,320 ns</td><td align="right" bgcolor="#FFFFFF">184,521 ns</td><td align="right" bgcolor="#FFFFFF">210,264 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,187 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,249 μs</td><td align="right" bgcolor="#FFFFFF">0,185 μs</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCOMObjectEx"></a>IsCOMObjectEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 27,910 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,750 ns</td><td align="right" bgcolor="#FFFFFF">16,191 ns</td><td align="right" bgcolor="#FFFFFF">16,179 ns</td><td align="right" bgcolor="#FFFFFF">22,410 ns</td><td align="right" bgcolor="#FFFFFF">26,433 ns</td><td align="right" bgcolor="#FFFFFF">21,929 ns</td><td align="right" bgcolor="#FFFFFF">44,089 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsEnumEx"></a>IsEnumEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 42,845 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,766 ns</td><td align="right" bgcolor="#FFFFFF">25,241 ns</td><td align="right" bgcolor="#FFFFFF">20,721 ns</td><td align="right" bgcolor="#FFFFFF">25,734 ns</td><td align="right" bgcolor="#FFFFFF">29,527 ns</td><td align="right" bgcolor="#FFFFFF">29,734 ns</td><td align="right" bgcolor="#FFFFFF">63,565 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 21,638 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,329 ns</td><td align="right" bgcolor="#FFFFFF">5,982 ns</td><td align="right" bgcolor="#FFFFFF">6,060 ns</td><td align="right" bgcolor="#FFFFFF">8,708 ns</td><td align="right" bgcolor="#FFFFFF">10,598 ns</td><td align="right" bgcolor="#FFFFFF">13,616 ns</td><td align="right" bgcolor="#FFFFFF">27,620 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeEx"></a>IsGenericTypeEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 19,583 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,138 ns</td><td align="right" bgcolor="#FFFFFF">6,140 ns</td><td align="right" bgcolor="#FFFFFF">6,107 ns</td><td align="right" bgcolor="#FFFFFF">8,773 ns</td><td align="right" bgcolor="#FFFFFF">10,548 ns</td><td align="right" bgcolor="#FFFFFF">12,785 ns</td><td align="right" bgcolor="#FFFFFF">25,690 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx"></a>IsInstanceOfTypeEx

#### Performance

Fastest: **5.12.0**

Slowest: 6.0.0

Δ: 6456,354 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,5 %</td><td align="right" bgcolor="#A8D08D">-13,9 %</td><td align="right" bgcolor="#A8D08D">-12,1 %</td><td align="right" bgcolor="#FF4949">+57,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14231,397 ns</td><td align="right" bgcolor="#A8D08D">12572,349 ns (Δ = -1659,048 ns)</td><td align="right" bgcolor="#FFFFFF">12756,557 ns</td><td align="right" bgcolor="#FF4949">14866,293 ns (Δ = +2109,736 ns)</td><td align="right" bgcolor="#A8D08D">12795,276 ns (Δ = -2071,017 ns)</td><td align="right" bgcolor="#A8D08D">11251,646 ns (Δ = -1543,629 ns)</td><td align="right" bgcolor="#FF4949">17708,000 ns (Δ = +6456,354 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14,231 μs</td><td align="right" bgcolor="#FFFFFF">12,572 μs</td><td align="right" bgcolor="#FFFFFF">12,757 μs</td><td align="right" bgcolor="#FFFFFF">14,866 μs</td><td align="right" bgcolor="#FFFFFF">12,795 μs</td><td align="right" bgcolor="#FFFFFF">11,252 μs</td><td align="right" bgcolor="#FFFFFF">17,708 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#A8D08D">-3,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">5801,000</td><td align="right" bgcolor="#FF4949">6139,000 (Δ = +338,000)</td><td align="right" bgcolor="#FFFFFF">6139,000</td><td align="right" bgcolor="#FFFFFF">6139,000</td><td align="right" bgcolor="#FF4949">6374,000 (Δ = +235,000)</td><td align="right" bgcolor="#FF4949">6632,000 (Δ = +258,000)</td><td align="right" bgcolor="#A8D08D">6400,000 (Δ = -232,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">5,665</td><td align="right" bgcolor="#FF4949">5,995 (Δ = +0,330)</td><td align="right" bgcolor="#FFFFFF">5,995</td><td align="right" bgcolor="#FFFFFF">5,995</td><td align="right" bgcolor="#FF4949">6,225 (Δ = +0,229)</td><td align="right" bgcolor="#FF4949">6,477 (Δ = +0,252)</td><td align="right" bgcolor="#A8D08D">6,250 (Δ = -0,227)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,006 (Δ = -0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 20,887 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,165 ns</td><td align="right" bgcolor="#FFFFFF">6,658 ns</td><td align="right" bgcolor="#FFFFFF">7,593 ns</td><td align="right" bgcolor="#FFFFFF">10,211 ns</td><td align="right" bgcolor="#FFFFFF">12,789 ns</td><td align="right" bgcolor="#FFFFFF">14,176 ns</td><td align="right" bgcolor="#FFFFFF">27,545 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsNestedPublicEx"></a>IsNestedPublicEx

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 17,230 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,785 ns</td><td align="right" bgcolor="#FFFFFF">10,624 ns</td><td align="right" bgcolor="#FFFFFF">13,767 ns</td><td align="right" bgcolor="#FFFFFF">12,509 ns</td><td align="right" bgcolor="#FFFFFF">15,452 ns</td><td align="right" bgcolor="#FFFFFF">15,966 ns</td><td align="right" bgcolor="#FFFFFF">27,853 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPrimitiveEx"></a>IsPrimitiveEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 23,872 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,634 ns</td><td align="right" bgcolor="#FFFFFF">10,248 ns</td><td align="right" bgcolor="#FFFFFF">10,204 ns</td><td align="right" bgcolor="#FFFFFF">12,814 ns</td><td align="right" bgcolor="#FFFFFF">14,922 ns</td><td align="right" bgcolor="#FFFFFF">20,394 ns</td><td align="right" bgcolor="#FFFFFF">34,076 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPublicEx"></a>IsPublicEx

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 27,098 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,567 ns</td><td align="right" bgcolor="#FFFFFF">10,488 ns</td><td align="right" bgcolor="#FFFFFF">13,892 ns</td><td align="right" bgcolor="#FFFFFF">14,458 ns</td><td align="right" bgcolor="#FFFFFF">16,952 ns</td><td align="right" bgcolor="#FFFFFF">15,139 ns</td><td align="right" bgcolor="#FFFFFF">37,586 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsSerializableEx"></a>IsSerializableEx

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 32,078 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,785 ns</td><td align="right" bgcolor="#FFFFFF">10,585 ns</td><td align="right" bgcolor="#FFFFFF">10,659 ns</td><td align="right" bgcolor="#FFFFFF">12,769 ns</td><td align="right" bgcolor="#FFFFFF">19,220 ns</td><td align="right" bgcolor="#FFFFFF">17,529 ns</td><td align="right" bgcolor="#FFFFFF">42,663 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsValueTypeEx"></a>IsValueTypeEx

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 46,160 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31,526 ns</td><td align="right" bgcolor="#FFFFFF">31,554 ns</td><td align="right" bgcolor="#FFFFFF">25,676 ns</td><td align="right" bgcolor="#FFFFFF">32,357 ns</td><td align="right" bgcolor="#FFFFFF">56,656 ns</td><td align="right" bgcolor="#FFFFFF">31,903 ns</td><td align="right" bgcolor="#FFFFFF">71,836 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="TypeExtensions_Benchmark"></a>TypeExtensions_Benchmark

### <a name="TypeExtensions_Benchmark_GetCollectionElementType"></a>GetCollectionElementType

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 588,812 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-74,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">793,732 ns</td><td align="right" bgcolor="#A8D08D">204,920 ns (Δ = -588,812 ns)</td><td align="right" bgcolor="#FFFFFF">217,032 ns</td><td align="right" bgcolor="#FFFFFF">260,888 ns</td><td align="right" bgcolor="#FFFFFF">208,374 ns</td><td align="right" bgcolor="#FFFFFF">346,060 ns</td><td align="right" bgcolor="#FFFFFF">263,933 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,794 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,217 μs</td><td align="right" bgcolor="#FFFFFF">0,261 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,346 μs</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-79,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#A8D08D">36,000 (Δ = -143,000)</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">32,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">32,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#A8D08D">0,035 (Δ = -0,140)</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,031 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,031</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsBasicType"></a>IsBasicType

#### Performance

Fastest: **5.6.0**

Slowest: 6.0.0

Δ: 13,536 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17,736 ns</td><td align="right" bgcolor="#FFFFFF">12,851 ns</td><td align="right" bgcolor="#FFFFFF">13,380 ns</td><td align="right" bgcolor="#FFFFFF">12,015 ns</td><td align="right" bgcolor="#FFFFFF">12,632 ns</td><td align="right" bgcolor="#FFFFFF">24,405 ns</td><td align="right" bgcolor="#FFFFFF">25,551 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsClassType"></a>IsClassType

#### Performance

Fastest: **6.0.0**

Slowest: 5.12.0

Δ: 92,745 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">162,291 ns</td><td align="right" bgcolor="#FFFFFF">152,239 ns</td><td align="right" bgcolor="#FFFFFF">154,254 ns</td><td align="right" bgcolor="#FFFFFF">196,817 ns</td><td align="right" bgcolor="#FFFFFF">157,766 ns</td><td align="right" bgcolor="#FFFFFF">234,818 ns</td><td align="right" bgcolor="#FFFFFF">142,073 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,162 μs</td><td align="right" bgcolor="#FFFFFF">0,152 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,235 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsCollection"></a>IsCollection

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 20,603 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,332 ns</td><td align="right" bgcolor="#FFFFFF">23,352 ns</td><td align="right" bgcolor="#FFFFFF">27,895 ns</td><td align="right" bgcolor="#FFFFFF">22,457 ns</td><td align="right" bgcolor="#FFFFFF">30,965 ns</td><td align="right" bgcolor="#FFFFFF">43,060 ns</td><td align="right" bgcolor="#FFFFFF">36,042 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsDictionary"></a>IsDictionary

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 89,389 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">74,251 ns</td><td align="right" bgcolor="#FFFFFF">72,777 ns</td><td align="right" bgcolor="#FFFFFF">110,897 ns</td><td align="right" bgcolor="#FFFFFF">68,211 ns</td><td align="right" bgcolor="#FFFFFF">70,413 ns</td><td align="right" bgcolor="#FFFFFF">157,600 ns</td><td align="right" bgcolor="#FFFFFF">80,030 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsModelBase"></a>IsModelBase

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 16,221 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">23,274 ns</td><td align="right" bgcolor="#FFFFFF">18,223 ns</td><td align="right" bgcolor="#FFFFFF">19,176 ns</td><td align="right" bgcolor="#FFFFFF">18,944 ns</td><td align="right" bgcolor="#FFFFFF">19,098 ns</td><td align="right" bgcolor="#FFFFFF">33,778 ns</td><td align="right" bgcolor="#FFFFFF">34,444 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsNullableType"></a>IsNullableType

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 100,925 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">300,620 ns</td><td align="right" bgcolor="#FFFFFF">216,157 ns</td><td align="right" bgcolor="#FFFFFF">231,010 ns</td><td align="right" bgcolor="#FFFFFF">207,867 ns</td><td align="right" bgcolor="#FFFFFF">215,297 ns</td><td align="right" bgcolor="#FFFFFF">308,792 ns</td><td align="right" bgcolor="#FFFFFF">255,268 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,301 μs</td><td align="right" bgcolor="#FFFFFF">0,216 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,215 μs</td><td align="right" bgcolor="#FFFFFF">0,309 μs</td><td align="right" bgcolor="#FFFFFF">0,255 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">32,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">32,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,031 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,031</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="TypeFactory_Benchmark"></a>TypeFactory_Benchmark

### <a name="TypeFactory_Benchmark_CreateInstance"></a>CreateInstance

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 1288,568 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+77,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1868,813 ns</td><td align="right" bgcolor="#FFFFFF">1640,444 ns</td><td align="right" bgcolor="#FFFFFF">1619,287 ns</td><td align="right" bgcolor="#FFFFFF">1637,093 ns</td><td align="right" bgcolor="#FFFFFF">1533,807 ns</td><td align="right" bgcolor="#FFFFFF">1588,547 ns</td><td align="right" bgcolor="#FF4949">2822,375 ns (Δ = +1233,828 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,869 μs</td><td align="right" bgcolor="#FFFFFF">1,640 μs</td><td align="right" bgcolor="#FFFFFF">1,619 μs</td><td align="right" bgcolor="#FFFFFF">1,637 μs</td><td align="right" bgcolor="#FFFFFF">1,534 μs</td><td align="right" bgcolor="#FFFFFF">1,589 μs</td><td align="right" bgcolor="#FFFFFF">2,822 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">-9,9 %</td><td align="right" bgcolor="#A8D08D">-2,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1053,000</td><td align="right" bgcolor="#A8D08D">1040,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">1040,000</td><td align="right" bgcolor="#A8D08D">1039,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">1040,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">937,000 (Δ = -103,000)</td><td align="right" bgcolor="#A8D08D">913,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,028</td><td align="right" bgcolor="#A8D08D">1,016 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">1,016</td><td align="right" bgcolor="#A8D08D">1,015 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">1,016 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,915 (Δ = -0,101)</td><td align="right" bgcolor="#A8D08D">0,892 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 485,656 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1948,316 ns</td><td align="right" bgcolor="#FFFFFF">1779,391 ns</td><td align="right" bgcolor="#FFFFFF">1651,769 ns</td><td align="right" bgcolor="#FFFFFF">1611,755 ns</td><td align="right" bgcolor="#FFFFFF">1462,661 ns</td><td align="right" bgcolor="#FFFFFF">1632,576 ns</td><td align="right" bgcolor="#FFFFFF">1547,917 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,948 μs</td><td align="right" bgcolor="#FFFFFF">1,779 μs</td><td align="right" bgcolor="#FFFFFF">1,652 μs</td><td align="right" bgcolor="#FFFFFF">1,612 μs</td><td align="right" bgcolor="#FFFFFF">1,463 μs</td><td align="right" bgcolor="#FFFFFF">1,633 μs</td><td align="right" bgcolor="#FFFFFF">1,548 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,3 %</td><td align="right" bgcolor="#A8D08D">-0,4 %</td><td align="right" bgcolor="#A8D08D">-8,9 %</td><td align="right" bgcolor="#A8D08D">-2,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1044,000</td><td align="right" bgcolor="#A8D08D">1029,000 (Δ = -15,000)</td><td align="right" bgcolor="#FFFFFF">1029,000</td><td align="right" bgcolor="#FF4949">1032,000 (Δ = +3,000)</td><td align="right" bgcolor="#A8D08D">1028,000 (Δ = -4,000)</td><td align="right" bgcolor="#A8D08D">937,000 (Δ = -91,000)</td><td align="right" bgcolor="#A8D08D">913,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,020</td><td align="right" bgcolor="#A8D08D">1,005 (Δ = -0,015)</td><td align="right" bgcolor="#FFFFFF">1,005</td><td align="right" bgcolor="#FF4949">1,008 (Δ = +0,003)</td><td align="right" bgcolor="#A8D08D">1,004 (Δ = -0,004)</td><td align="right" bgcolor="#A8D08D">0,915 (Δ = -0,089)</td><td align="right" bgcolor="#A8D08D">0,892 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 841,258 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,2 %</td><td align="right" bgcolor="#A8D08D">-17,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2359,662 ns</td><td align="right" bgcolor="#FF4949">2718,190 ns (Δ = +358,528 ns)</td><td align="right" bgcolor="#A8D08D">2250,844 ns (Δ = -467,346 ns)</td><td align="right" bgcolor="#FFFFFF">2125,917 ns</td><td align="right" bgcolor="#FFFFFF">2042,215 ns</td><td align="right" bgcolor="#FFFFFF">1876,932 ns</td><td align="right" bgcolor="#FFFFFF">2024,462 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,360 μs</td><td align="right" bgcolor="#FFFFFF">2,718 μs</td><td align="right" bgcolor="#FFFFFF">2,251 μs</td><td align="right" bgcolor="#FFFFFF">2,126 μs</td><td align="right" bgcolor="#FFFFFF">2,042 μs</td><td align="right" bgcolor="#FFFFFF">1,877 μs</td><td align="right" bgcolor="#FFFFFF">2,024 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.4</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#A8D08D">-1,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1469,000</td><td align="right" bgcolor="#FF4949">1480,000 (Δ = +11,000)</td><td align="right" bgcolor="#FFFFFF">1480,000</td><td align="right" bgcolor="#FFFFFF">1480,000</td><td align="right" bgcolor="#FFFFFF">1480,000</td><td align="right" bgcolor="#A8D08D">1401,000 (Δ = -79,000)</td><td align="right" bgcolor="#A8D08D">1377,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,435</td><td align="right" bgcolor="#FF4949">1,445 (Δ = +0,011)</td><td align="right" bgcolor="#FFFFFF">1,445</td><td align="right" bgcolor="#FFFFFF">1,445</td><td align="right" bgcolor="#FFFFFF">1,445</td><td align="right" bgcolor="#A8D08D">1,368 (Δ = -0,077)</td><td align="right" bgcolor="#A8D08D">1,345 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 1416,353 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,2 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2759,217 ns</td><td align="right" bgcolor="#FF4949">3674,210 ns (Δ = +914,993 ns)</td><td align="right" bgcolor="#A8D08D">2477,204 ns (Δ = -1197,006 ns)</td><td align="right" bgcolor="#FFFFFF">2420,670 ns</td><td align="right" bgcolor="#FFFFFF">2262,879 ns</td><td align="right" bgcolor="#FFFFFF">2257,857 ns</td><td align="right" bgcolor="#FFFFFF">2385,625 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,759 μs</td><td align="right" bgcolor="#FFFFFF">3,674 μs</td><td align="right" bgcolor="#FFFFFF">2,477 μs</td><td align="right" bgcolor="#FFFFFF">2,421 μs</td><td align="right" bgcolor="#FFFFFF">2,263 μs</td><td align="right" bgcolor="#FFFFFF">2,258 μs</td><td align="right" bgcolor="#FFFFFF">2,386 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.4</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,8 %</td><td align="right" bgcolor="#A8D08D">-1,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1680,000</td><td align="right" bgcolor="#FF4949">1690,000 (Δ = +10,000)</td><td align="right" bgcolor="#FFFFFF">1690,000</td><td align="right" bgcolor="#FFFFFF">1690,000</td><td align="right" bgcolor="#FFFFFF">1690,000</td><td align="right" bgcolor="#A8D08D">1609,000 (Δ = -81,000)</td><td align="right" bgcolor="#A8D08D">1585,000 (Δ = -24,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,641</td><td align="right" bgcolor="#FF4949">1,650 (Δ = +0,010)</td><td align="right" bgcolor="#FFFFFF">1,650</td><td align="right" bgcolor="#FFFFFF">1,650</td><td align="right" bgcolor="#FFFFFF">1,650</td><td align="right" bgcolor="#A8D08D">1,571 (Δ = -0,079)</td><td align="right" bgcolor="#A8D08D">1,548 (Δ = -0,023)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,000)</td></tr></table>


## <a name="UniqueIdentifierHelper_Benchmark"></a>UniqueIdentifierHelper_Benchmark

### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier"></a>GetUniqueIdentifier

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 60,191 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">71,444 ns</td><td align="right" bgcolor="#FFFFFF">98,314 ns</td><td align="right" bgcolor="#FFFFFF">70,102 ns</td><td align="right" bgcolor="#FFFFFF">52,157 ns</td><td align="right" bgcolor="#FFFFFF">51,722 ns</td><td align="right" bgcolor="#FFFFFF">111,913 ns</td><td align="right" bgcolor="#FFFFFF">74,286 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier_Generic"></a>GetUniqueIdentifier_Generic

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 90,509 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">70,134 ns</td><td align="right" bgcolor="#FFFFFF">89,695 ns</td><td align="right" bgcolor="#FFFFFF">69,992 ns</td><td align="right" bgcolor="#FFFFFF">56,428 ns</td><td align="right" bgcolor="#FFFFFF">51,713 ns</td><td align="right" bgcolor="#FFFFFF">109,338 ns</td><td align="right" bgcolor="#FFFFFF">142,222 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ValidatableModelBase_Constructor_Benchmark"></a>ValidatableModelBase_Constructor_Benchmark

### <a name="ValidatableModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 1375,501 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,4 %</td><td align="right" bgcolor="#FF4949">+17,0 %</td><td align="right" bgcolor="#FF4949">+39,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3305,938 ns</td><td align="right" bgcolor="#A8D08D">2486,861 ns (Δ = -819,077 ns)</td><td align="right" bgcolor="#FFFFFF">2581,022 ns</td><td align="right" bgcolor="#FFFFFF">2829,634 ns</td><td align="right" bgcolor="#A8D08D">2166,605 ns (Δ = -663,029 ns)</td><td align="right" bgcolor="#FF4949">2534,440 ns (Δ = +367,836 ns)</td><td align="right" bgcolor="#FF4949">3542,106 ns (Δ = +1007,666 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,306 μs</td><td align="right" bgcolor="#FFFFFF">2,487 μs</td><td align="right" bgcolor="#FFFFFF">2,581 μs</td><td align="right" bgcolor="#FFFFFF">2,830 μs</td><td align="right" bgcolor="#FFFFFF">2,167 μs</td><td align="right" bgcolor="#FFFFFF">2,534 μs</td><td align="right" bgcolor="#FFFFFF">3,542 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12</td><td align="right">6.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#FF4949">+64,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">975,000</td><td align="right" bgcolor="#A8D08D">973,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#A8D08D">922,000 (Δ = -51,000)</td><td align="right" bgcolor="#FF4949">1520,000 (Δ = +598,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,952</td><td align="right" bgcolor="#A8D08D">0,950 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#A8D08D">0,900 (Δ = -0,050)</td><td align="right" bgcolor="#FF4949">1,484 (Δ = +0,584)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="ValidationContext_Benchmark"></a>ValidationContext_Benchmark

### <a name="ValidationContext_Benchmark_GetBusinessRuleErrorCount"></a>GetBusinessRuleErrorCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 97,785 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">154,259 ns</td><td align="right" bgcolor="#FFFFFF">139,963 ns</td><td align="right" bgcolor="#FFFFFF">158,150 ns</td><td align="right" bgcolor="#FFFFFF">200,625 ns</td><td align="right" bgcolor="#FFFFFF">142,214 ns</td><td align="right" bgcolor="#FFFFFF">237,747 ns</td><td align="right" bgcolor="#FFFFFF">236,484 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,238 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">160,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,156 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,156</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleErrors"></a>GetBusinessRuleErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 112,743 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">201,467 ns</td><td align="right" bgcolor="#FFFFFF">134,407 ns</td><td align="right" bgcolor="#FFFFFF">143,945 ns</td><td align="right" bgcolor="#FFFFFF">139,942 ns</td><td align="right" bgcolor="#FFFFFF">133,021 ns</td><td align="right" bgcolor="#FFFFFF">245,764 ns</td><td align="right" bgcolor="#FFFFFF">244,861 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td><td align="right" bgcolor="#FFFFFF">0,246 μs</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">160,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,156 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,156</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleValidations"></a>GetBusinessRuleValidations

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 91,037 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">199,234 ns</td><td align="right" bgcolor="#FFFFFF">151,136 ns</td><td align="right" bgcolor="#FFFFFF">153,326 ns</td><td align="right" bgcolor="#FFFFFF">162,197 ns</td><td align="right" bgcolor="#FFFFFF">147,992 ns</td><td align="right" bgcolor="#FFFFFF">239,029 ns</td><td align="right" bgcolor="#FFFFFF">224,455 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,199 μs</td><td align="right" bgcolor="#FFFFFF">0,151 μs</td><td align="right" bgcolor="#FFFFFF">0,153 μs</td><td align="right" bgcolor="#FFFFFF">0,162 μs</td><td align="right" bgcolor="#FFFFFF">0,148 μs</td><td align="right" bgcolor="#FFFFFF">0,239 μs</td><td align="right" bgcolor="#FFFFFF">0,224 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#A8D08D">144,000 (Δ = -35,000)</td><td align="right" bgcolor="#FFFFFF">144,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#A8D08D">0,141 (Δ = -0,034)</td><td align="right" bgcolor="#FFFFFF">0,141</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarningCount"></a>GetBusinessRuleWarningCount

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 125,919 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">152,865 ns</td><td align="right" bgcolor="#FFFFFF">182,235 ns</td><td align="right" bgcolor="#FFFFFF">139,463 ns</td><td align="right" bgcolor="#FFFFFF">156,477 ns</td><td align="right" bgcolor="#FFFFFF">132,221 ns</td><td align="right" bgcolor="#FFFFFF">258,140 ns</td><td align="right" bgcolor="#FFFFFF">228,575 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,153 μs</td><td align="right" bgcolor="#FFFFFF">0,182 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,258 μs</td><td align="right" bgcolor="#FFFFFF">0,229 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">160,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,156 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,156</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarnings"></a>GetBusinessRuleWarnings

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 100,444 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">195,758 ns</td><td align="right" bgcolor="#FFFFFF">140,480 ns</td><td align="right" bgcolor="#FFFFFF">149,348 ns</td><td align="right" bgcolor="#FFFFFF">134,597 ns</td><td align="right" bgcolor="#FFFFFF">134,651 ns</td><td align="right" bgcolor="#FFFFFF">235,042 ns</td><td align="right" bgcolor="#FFFFFF">206,538 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td><td align="right" bgcolor="#FFFFFF">0,235 μs</td><td align="right" bgcolor="#FFFFFF">0,207 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">160,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,156 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,156</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrorCount"></a>GetErrorCount

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 214,117 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">805,765 ns</td><td align="right" bgcolor="#FFFFFF">754,666 ns</td><td align="right" bgcolor="#FFFFFF">711,916 ns</td><td align="right" bgcolor="#FFFFFF">702,529 ns</td><td align="right" bgcolor="#FFFFFF">843,361 ns</td><td align="right" bgcolor="#FFFFFF">629,244 ns</td><td align="right" bgcolor="#FFFFFF">706,276 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,806 μs</td><td align="right" bgcolor="#FFFFFF">0,755 μs</td><td align="right" bgcolor="#FFFFFF">0,712 μs</td><td align="right" bgcolor="#FFFFFF">0,703 μs</td><td align="right" bgcolor="#FFFFFF">0,843 μs</td><td align="right" bgcolor="#FFFFFF">0,629 μs</td><td align="right" bgcolor="#FFFFFF">0,706 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#A8D08D">488,000 (Δ = -29,000)</td><td align="right" bgcolor="#FFFFFF">488,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,028)</td><td align="right" bgcolor="#FFFFFF">0,477</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrors"></a>GetErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 269,847 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">809,963 ns</td><td align="right" bgcolor="#FFFFFF">929,167 ns</td><td align="right" bgcolor="#FFFFFF">688,028 ns</td><td align="right" bgcolor="#FFFFFF">681,678 ns</td><td align="right" bgcolor="#FFFFFF">659,320 ns</td><td align="right" bgcolor="#FFFFFF">720,091 ns</td><td align="right" bgcolor="#FFFFFF">697,786 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,810 μs</td><td align="right" bgcolor="#FFFFFF">0,929 μs</td><td align="right" bgcolor="#FFFFFF">0,688 μs</td><td align="right" bgcolor="#FFFFFF">0,682 μs</td><td align="right" bgcolor="#FFFFFF">0,659 μs</td><td align="right" bgcolor="#FFFFFF">0,720 μs</td><td align="right" bgcolor="#FFFFFF">0,698 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#A8D08D">488,000 (Δ = -29,000)</td><td align="right" bgcolor="#FFFFFF">488,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,028)</td><td align="right" bgcolor="#FFFFFF">0,477</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrorCount"></a>GetFieldErrorCount

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 79,202 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">197,168 ns</td><td align="right" bgcolor="#FFFFFF">166,354 ns</td><td align="right" bgcolor="#FFFFFF">204,912 ns</td><td align="right" bgcolor="#FFFFFF">177,750 ns</td><td align="right" bgcolor="#FFFFFF">159,280 ns</td><td align="right" bgcolor="#FFFFFF">224,753 ns</td><td align="right" bgcolor="#FFFFFF">238,482 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,178 μs</td><td align="right" bgcolor="#FFFFFF">0,159 μs</td><td align="right" bgcolor="#FFFFFF">0,225 μs</td><td align="right" bgcolor="#FFFFFF">0,238 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">160,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,156 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,156</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrors"></a>GetFieldErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 88,442 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">195,064 ns</td><td align="right" bgcolor="#FFFFFF">167,090 ns</td><td align="right" bgcolor="#FFFFFF">169,502 ns</td><td align="right" bgcolor="#FFFFFF">167,491 ns</td><td align="right" bgcolor="#FFFFFF">158,274 ns</td><td align="right" bgcolor="#FFFFFF">246,715 ns</td><td align="right" bgcolor="#FFFFFF">226,001 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#FFFFFF">0,170 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">160,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,156 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,156</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldValidations"></a>GetFieldValidations

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 49,579 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">212,957 ns</td><td align="right" bgcolor="#FFFFFF">185,152 ns</td><td align="right" bgcolor="#FFFFFF">183,678 ns</td><td align="right" bgcolor="#FFFFFF">176,911 ns</td><td align="right" bgcolor="#FFFFFF">226,491 ns</td><td align="right" bgcolor="#FFFFFF">215,000 ns</td><td align="right" bgcolor="#FFFFFF">224,925 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,185 μs</td><td align="right" bgcolor="#FFFFFF">0,184 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td><td align="right" bgcolor="#FFFFFF">0,215 μs</td><td align="right" bgcolor="#FFFFFF">0,225 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#FFFFFF">179,000</td><td align="right" bgcolor="#A8D08D">152,000 (Δ = -27,000)</td><td align="right" bgcolor="#FFFFFF">152,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#FFFFFF">0,175</td><td align="right" bgcolor="#A8D08D">0,148 (Δ = -0,026)</td><td align="right" bgcolor="#FFFFFF">0,148</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarningCount"></a>GetFieldWarningCount

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 92,448 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">179,517 ns</td><td align="right" bgcolor="#FFFFFF">175,350 ns</td><td align="right" bgcolor="#FFFFFF">148,475 ns</td><td align="right" bgcolor="#FFFFFF">146,363 ns</td><td align="right" bgcolor="#FFFFFF">144,829 ns</td><td align="right" bgcolor="#FFFFFF">230,352 ns</td><td align="right" bgcolor="#FFFFFF">237,277 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,180 μs</td><td align="right" bgcolor="#FFFFFF">0,175 μs</td><td align="right" bgcolor="#FFFFFF">0,148 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,230 μs</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">160,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,156 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,156</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarnings"></a>GetFieldWarnings

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 103,325 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">176,611 ns</td><td align="right" bgcolor="#FFFFFF">149,291 ns</td><td align="right" bgcolor="#FFFFFF">146,481 ns</td><td align="right" bgcolor="#FFFFFF">143,319 ns</td><td align="right" bgcolor="#FFFFFF">142,114 ns</td><td align="right" bgcolor="#FFFFFF">245,439 ns</td><td align="right" bgcolor="#FFFFFF">231,850 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td><td align="right" bgcolor="#FFFFFF">0,232 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">160,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,156 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,156</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetValidations"></a>GetValidations

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 212,916 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">410,549 ns</td><td align="right" bgcolor="#FFFFFF">395,996 ns</td><td align="right" bgcolor="#FFFFFF">350,847 ns</td><td align="right" bgcolor="#FFFFFF">351,417 ns</td><td align="right" bgcolor="#FFFFFF">455,638 ns</td><td align="right" bgcolor="#FFFFFF">554,503 ns</td><td align="right" bgcolor="#FFFFFF">563,763 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,411 μs</td><td align="right" bgcolor="#FFFFFF">0,396 μs</td><td align="right" bgcolor="#FFFFFF">0,351 μs</td><td align="right" bgcolor="#FFFFFF">0,351 μs</td><td align="right" bgcolor="#FFFFFF">0,456 μs</td><td align="right" bgcolor="#FFFFFF">0,555 μs</td><td align="right" bgcolor="#FFFFFF">0,564 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#FFFFFF">348,000</td><td align="right" bgcolor="#A8D08D">320,000 (Δ = -28,000)</td><td align="right" bgcolor="#FFFFFF">320,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#FFFFFF">0,340</td><td align="right" bgcolor="#A8D08D">0,313 (Δ = -0,027)</td><td align="right" bgcolor="#FFFFFF">0,313</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarningCount"></a>GetWarningCount

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 480,285 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+78,7 %</td><td align="right" bgcolor="#A8D08D">-42,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">750,104 ns</td><td align="right" bgcolor="#FFFFFF">683,145 ns</td><td align="right" bgcolor="#FFFFFF">638,170 ns</td><td align="right" bgcolor="#FFFFFF">610,125 ns</td><td align="right" bgcolor="#FF4949">1090,410 ns (Δ = +480,285 ns)</td><td align="right" bgcolor="#A8D08D">632,917 ns (Δ = -457,493 ns)</td><td align="right" bgcolor="#FFFFFF">658,370 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,750 μs</td><td align="right" bgcolor="#FFFFFF">0,683 μs</td><td align="right" bgcolor="#FFFFFF">0,638 μs</td><td align="right" bgcolor="#FFFFFF">0,610 μs</td><td align="right" bgcolor="#FFFFFF">1,090 μs</td><td align="right" bgcolor="#FFFFFF">0,633 μs</td><td align="right" bgcolor="#FFFFFF">0,658 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#A8D08D">488,000 (Δ = -29,000)</td><td align="right" bgcolor="#FFFFFF">488,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,028)</td><td align="right" bgcolor="#FFFFFF">0,477</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarnings"></a>GetWarnings

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 152,559 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">754,478 ns</td><td align="right" bgcolor="#FFFFFF">618,466 ns</td><td align="right" bgcolor="#FFFFFF">758,839 ns</td><td align="right" bgcolor="#FFFFFF">617,547 ns</td><td align="right" bgcolor="#FFFFFF">606,280 ns</td><td align="right" bgcolor="#FFFFFF">698,542 ns</td><td align="right" bgcolor="#FFFFFF">670,435 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,754 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,759 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,606 μs</td><td align="right" bgcolor="#FFFFFF">0,699 μs</td><td align="right" bgcolor="#FFFFFF">0,670 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#FFFFFF">517,000</td><td align="right" bgcolor="#A8D08D">488,000 (Δ = -29,000)</td><td align="right" bgcolor="#FFFFFF">488,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#FFFFFF">0,505</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,028)</td><td align="right" bgcolor="#FFFFFF">0,477</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 102,045 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">203,870 ns</td><td align="right" bgcolor="#FFFFFF">167,524 ns</td><td align="right" bgcolor="#FFFFFF">170,073 ns</td><td align="right" bgcolor="#FFFFFF">260,188 ns</td><td align="right" bgcolor="#FFFFFF">158,143 ns</td><td align="right" bgcolor="#FFFFFF">252,799 ns</td><td align="right" bgcolor="#FFFFFF">231,157 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,204 μs</td><td align="right" bgcolor="#FFFFFF">0,168 μs</td><td align="right" bgcolor="#FFFFFF">0,170 μs</td><td align="right" bgcolor="#FFFFFF">0,260 μs</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,253 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">160,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,156 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,156</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 116,337 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">177,145 ns</td><td align="right" bgcolor="#FFFFFF">145,691 ns</td><td align="right" bgcolor="#FFFFFF">169,438 ns</td><td align="right" bgcolor="#FFFFFF">154,715 ns</td><td align="right" bgcolor="#FFFFFF">143,278 ns</td><td align="right" bgcolor="#FFFFFF">259,614 ns</td><td align="right" bgcolor="#FFFFFF">228,088 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,169 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,260 μs</td><td align="right" bgcolor="#FFFFFF">0,228 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">160,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,156 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,156</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 76,526 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">234,713 ns</td><td align="right" bgcolor="#FFFFFF">195,207 ns</td><td align="right" bgcolor="#FFFFFF">194,698 ns</td><td align="right" bgcolor="#FFFFFF">261,128 ns</td><td align="right" bgcolor="#FFFFFF">191,773 ns</td><td align="right" bgcolor="#FFFFFF">268,299 ns</td><td align="right" bgcolor="#FFFFFF">265,938 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,235 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,261 μs</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,268 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">333,000</td><td align="right" bgcolor="#FFFFFF">333,000</td><td align="right" bgcolor="#FFFFFF">333,000</td><td align="right" bgcolor="#FFFFFF">333,000</td><td align="right" bgcolor="#FFFFFF">333,000</td><td align="right" bgcolor="#A8D08D">224,000 (Δ = -109,000)</td><td align="right" bgcolor="#FFFFFF">224,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,325</td><td align="right" bgcolor="#FFFFFF">0,325</td><td align="right" bgcolor="#FFFFFF">0,325</td><td align="right" bgcolor="#FFFFFF">0,325</td><td align="right" bgcolor="#FFFFFF">0,325</td><td align="right" bgcolor="#A8D08D">0,219 (Δ = -0,106)</td><td align="right" bgcolor="#FFFFFF">0,219</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ValidationSummary_Benchmark"></a>ValidationSummary_Benchmark

### <a name="ValidationSummary_Benchmark_BusinessRuleErrors"></a>BusinessRuleErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 13,986 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,817 ns</td><td align="right" bgcolor="#FFFFFF">5,097 ns</td><td align="right" bgcolor="#FFFFFF">5,051 ns</td><td align="right" bgcolor="#FFFFFF">4,918 ns</td><td align="right" bgcolor="#FFFFFF">4,874 ns</td><td align="right" bgcolor="#FFFFFF">18,859 ns</td><td align="right" bgcolor="#FFFFFF">17,842 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">24,000 (Δ = -12,000)</td><td align="right" bgcolor="#FFFFFF">24,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,023 (Δ = -0,012)</td><td align="right" bgcolor="#FFFFFF">0,023</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_BusinessRuleWarnings"></a>BusinessRuleWarnings

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 13,847 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,460 ns</td><td align="right" bgcolor="#FFFFFF">5,137 ns</td><td align="right" bgcolor="#FFFFFF">4,917 ns</td><td align="right" bgcolor="#FFFFFF">4,889 ns</td><td align="right" bgcolor="#FFFFFF">5,011 ns</td><td align="right" bgcolor="#FFFFFF">18,737 ns</td><td align="right" bgcolor="#FFFFFF">18,227 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">24,000 (Δ = -12,000)</td><td align="right" bgcolor="#FFFFFF">24,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,023 (Δ = -0,012)</td><td align="right" bgcolor="#FFFFFF">0,023</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldErrors"></a>FieldErrors

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 13,613 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,589 ns</td><td align="right" bgcolor="#FFFFFF">4,964 ns</td><td align="right" bgcolor="#FFFFFF">5,100 ns</td><td align="right" bgcolor="#FFFFFF">5,039 ns</td><td align="right" bgcolor="#FFFFFF">4,996 ns</td><td align="right" bgcolor="#FFFFFF">18,576 ns</td><td align="right" bgcolor="#FFFFFF">18,577 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">24,000 (Δ = -12,000)</td><td align="right" bgcolor="#FFFFFF">24,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,023 (Δ = -0,012)</td><td align="right" bgcolor="#FFFFFF">0,023</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldWarnings"></a>FieldWarnings

#### Performance

Fastest: **5.4.0**

Slowest: 6.0.0

Δ: 15,405 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,203 ns</td><td align="right" bgcolor="#FFFFFF">4,956 ns</td><td align="right" bgcolor="#FFFFFF">4,990 ns</td><td align="right" bgcolor="#FFFFFF">5,077 ns</td><td align="right" bgcolor="#FFFFFF">5,164 ns</td><td align="right" bgcolor="#FFFFFF">19,337 ns</td><td align="right" bgcolor="#FFFFFF">20,361 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#A8D08D">24,000 (Δ = -12,000)</td><td align="right" bgcolor="#FFFFFF">24,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#A8D08D">0,023 (Δ = -0,012)</td><td align="right" bgcolor="#FFFFFF">0,023</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasBusinessRuleErrors"></a>HasBusinessRuleErrors

#### Performance

Fastest: **5.9.0**

Slowest: 6.0.0

Δ: 2,717 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,120 ns</td><td align="right" bgcolor="#FFFFFF">0,213 ns</td><td align="right" bgcolor="#FFFFFF">0,156 ns</td><td align="right" bgcolor="#FFFFFF">0,063 ns</td><td align="right" bgcolor="#FFFFFF">0,033 ns</td><td align="right" bgcolor="#FFFFFF">2,245 ns</td><td align="right" bgcolor="#FFFFFF">2,750 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasBusinessRuleWarnings"></a>HasBusinessRuleWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 3,108 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,156 ns</td><td align="right" bgcolor="#FFFFFF">0,226 ns</td><td align="right" bgcolor="#FFFFFF">0,219 ns</td><td align="right" bgcolor="#FFFFFF">0,344 ns</td><td align="right" bgcolor="#FFFFFF">0,173 ns</td><td align="right" bgcolor="#FFFFFF">3,264 ns</td><td align="right" bgcolor="#FFFFFF">2,826 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 3,006 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,387 ns</td><td align="right" bgcolor="#FFFFFF">0,385 ns</td><td align="right" bgcolor="#FFFFFF">0,430 ns</td><td align="right" bgcolor="#FFFFFF">0,388 ns</td><td align="right" bgcolor="#FFFFFF">0,314 ns</td><td align="right" bgcolor="#FFFFFF">3,319 ns</td><td align="right" bgcolor="#FFFFFF">2,917 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldErrors"></a>HasFieldErrors

#### Performance

Fastest: **5.6.0**

Slowest: 6.0.0

Δ: 1,917 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,104 ns</td><td align="right" bgcolor="#FFFFFF">0,238 ns</td><td align="right" bgcolor="#FFFFFF">0,213 ns</td><td align="right" bgcolor="#FFFFFF">0,076 ns</td><td align="right" bgcolor="#FFFFFF">0,113 ns</td><td align="right" bgcolor="#FFFFFF">1,503 ns</td><td align="right" bgcolor="#FFFFFF">1,992 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldWarnings"></a>HasFieldWarnings

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 2,550 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,092 ns</td><td align="right" bgcolor="#FFFFFF">0,221 ns</td><td align="right" bgcolor="#FFFFFF">0,165 ns</td><td align="right" bgcolor="#FFFFFF">0,041 ns</td><td align="right" bgcolor="#FFFFFF">0,299 ns</td><td align="right" bgcolor="#FFFFFF">2,590 ns</td><td align="right" bgcolor="#FFFFFF">2,434 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.5.0**

Slowest: 6.0.0

Δ: 2,496 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,595 ns</td><td align="right" bgcolor="#FFFFFF">0,383 ns</td><td align="right" bgcolor="#FFFFFF">0,368 ns</td><td align="right" bgcolor="#FFFFFF">0,387 ns</td><td align="right" bgcolor="#FFFFFF">0,456 ns</td><td align="right" bgcolor="#FFFFFF">2,092 ns</td><td align="right" bgcolor="#FFFFFF">2,865 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **6.0.0**

Slowest: 5.0.0

Δ: 259,368 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">871,052 ns</td><td align="right" bgcolor="#FFFFFF">726,148 ns</td><td align="right" bgcolor="#FFFFFF">682,587 ns</td><td align="right" bgcolor="#FFFFFF">674,541 ns</td><td align="right" bgcolor="#FFFFFF">660,321 ns</td><td align="right" bgcolor="#FFFFFF">634,574 ns</td><td align="right" bgcolor="#FFFFFF">611,685 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,871 μs</td><td align="right" bgcolor="#FFFFFF">0,726 μs</td><td align="right" bgcolor="#FFFFFF">0,683 μs</td><td align="right" bgcolor="#FFFFFF">0,675 μs</td><td align="right" bgcolor="#FFFFFF">0,660 μs</td><td align="right" bgcolor="#FFFFFF">0,635 μs</td><td align="right" bgcolor="#FFFFFF">0,612 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#FFFFFF">742,000</td><td align="right" bgcolor="#A8D08D">704,000 (Δ = -38,000)</td><td align="right" bgcolor="#FFFFFF">704,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#FFFFFF">0,725</td><td align="right" bgcolor="#A8D08D">0,688 (Δ = -0,037)</td><td align="right" bgcolor="#FFFFFF">0,688</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 4430,157 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,7 %</td><td align="right" bgcolor="#A8D08D">-24,1 %</td><td align="right" bgcolor="#FF4949">+4,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15511,589 ns</td><td align="right" bgcolor="#A8D08D">13383,825 ns (Δ = -2127,764 ns)</td><td align="right" bgcolor="#FFFFFF">13569,467 ns</td><td align="right" bgcolor="#FFFFFF">13809,995 ns</td><td align="right" bgcolor="#FF4949">14600,266 ns (Δ = +790,272 ns)</td><td align="right" bgcolor="#A8D08D">11081,432 ns (Δ = -3518,834 ns)</td><td align="right" bgcolor="#FF4949">11520,938 ns (Δ = +439,505 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">15,512 μs</td><td align="right" bgcolor="#FFFFFF">13,384 μs</td><td align="right" bgcolor="#FFFFFF">13,569 μs</td><td align="right" bgcolor="#FFFFFF">13,810 μs</td><td align="right" bgcolor="#FFFFFF">14,600 μs</td><td align="right" bgcolor="#FFFFFF">11,081 μs</td><td align="right" bgcolor="#FFFFFF">11,521 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 1</td><td align="right">6.0</td><td align="right">5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0</td><td align="right">5.12</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#A8D08D">-3,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">5723,000</td><td align="right" bgcolor="#FF4949">6062,000 (Δ = +339,000)</td><td align="right" bgcolor="#FFFFFF">6062,000</td><td align="right" bgcolor="#FFFFFF">6062,000</td><td align="right" bgcolor="#FF4949">6293,000 (Δ = +231,000)</td><td align="right" bgcolor="#FF4949">6560,000 (Δ = +267,000)</td><td align="right" bgcolor="#A8D08D">6352,000 (Δ = -208,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">5,589</td><td align="right" bgcolor="#FF4949">5,920 (Δ = +0,331)</td><td align="right" bgcolor="#FFFFFF">5,920</td><td align="right" bgcolor="#FFFFFF">5,920</td><td align="right" bgcolor="#FF4949">6,146 (Δ = +0,226)</td><td align="right" bgcolor="#FF4949">6,406 (Δ = +0,261)</td><td align="right" bgcolor="#A8D08D">6,203 (Δ = -0,203)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,005</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,006 (Δ = -0,000)</td></tr></table>


### <a name="ViewModelBase_Benchmark_ModelPropertyMappings"></a>ModelPropertyMappings

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 21846,528 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,4 %</td><td align="right" bgcolor="#FF4949">+13,5 %</td><td align="right" bgcolor="#A8D08D">-3,0 %</td><td align="right" bgcolor="#A8D08D">-37,3 %</td><td align="right" bgcolor="#A8D08D">-10,1 %</td><td align="right" bgcolor="#FF4949">+16,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31577,574 ns</td><td align="right" bgcolor="#FF4949">42439,390 ns (Δ = +10861,816 ns)</td><td align="right" bgcolor="#FF4949">48177,013 ns (Δ = +5737,623 ns)</td><td align="right" bgcolor="#A8D08D">46716,631 ns (Δ = -1460,382 ns)</td><td align="right" bgcolor="#A8D08D">29278,485 ns (Δ = -17438,146 ns)</td><td align="right" bgcolor="#A8D08D">26330,485 ns (Δ = -2948,000 ns)</td><td align="right" bgcolor="#FF4949">30623,659 ns (Δ = +4293,173 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">31,578 μs</td><td align="right" bgcolor="#FFFFFF">42,439 μs</td><td align="right" bgcolor="#FFFFFF">48,177 μs</td><td align="right" bgcolor="#FFFFFF">46,717 μs</td><td align="right" bgcolor="#FFFFFF">29,278 μs</td><td align="right" bgcolor="#FFFFFF">26,330 μs</td><td align="right" bgcolor="#FFFFFF">30,624 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,032 ms</td><td align="right" bgcolor="#FFFFFF">0,042 ms</td><td align="right" bgcolor="#FFFFFF">0,048 ms</td><td align="right" bgcolor="#FFFFFF">0,047 ms</td><td align="right" bgcolor="#FFFFFF">0,029 ms</td><td align="right" bgcolor="#FFFFFF">0,026 ms</td><td align="right" bgcolor="#FFFFFF">0,031 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">6.0</td><td align="right">5.4</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">6.0</td><td align="right">5.4</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th><th>6.0.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FF4949">16,000 (Δ = +4,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#FFFFFF">16,000</td><td align="right" bgcolor="#A8D08D">8,000 (Δ = -8,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -8,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+29,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,2 %</td><td align="right" bgcolor="#A8D08D">-17,4 %</td><td align="right" bgcolor="#A8D08D">-14,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">16787,000</td><td align="right" bgcolor="#FF4949">21678,000 (Δ = +4891,000)</td><td align="right" bgcolor="#FFFFFF">21678,000</td><td align="right" bgcolor="#FFFFFF">21678,000</td><td align="right" bgcolor="#A8D08D">11444,000 (Δ = -10234,000)</td><td align="right" bgcolor="#A8D08D">9456,000 (Δ = -1988,000)</td><td align="right" bgcolor="#A8D08D">8120,000 (Δ = -1336,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">16,394</td><td align="right" bgcolor="#FF4949">21,170 (Δ = +4,776)</td><td align="right" bgcolor="#FFFFFF">21,170</td><td align="right" bgcolor="#FFFFFF">21,170</td><td align="right" bgcolor="#A8D08D">11,176 (Δ = -9,994)</td><td align="right" bgcolor="#A8D08D">9,234 (Δ = -1,941)</td><td align="right" bgcolor="#A8D08D">7,930 (Δ = -1,305)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,016</td><td align="right" bgcolor="#FF4949">0,021 (Δ = +0,005)</td><td align="right" bgcolor="#FFFFFF">0,021</td><td align="right" bgcolor="#FFFFFF">0,021</td><td align="right" bgcolor="#A8D08D">0,011 (Δ = -0,010)</td><td align="right" bgcolor="#A8D08D">0,009 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,008 (Δ = -0,001)</td></tr></table>


