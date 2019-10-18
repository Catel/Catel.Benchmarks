# Benchmarks

Benchmark report generated on 18-okt-2019 12:59

Running the benchmarks took 03:18:14.4179517

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


If versions behave the same (e.g. result in exactly the same values), this report will show the highest version to represent the most recent state at best.
If a higher version is at least 3% slower than the previous one, it will have a red background. If it is at least 3% faster, it will have a green background.

## Host environment information

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18363

Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores



## Important benchmarks

### High priority (current version slower than previous one)

17 item(s)

1. [LanguageHelper_Benchmark::GetString](#LanguageHelper_Benchmark_GetString) v5.12.0 is **773,74%** (Δ: 2434,149 ns) slower than v5.9.0

2. [ResourceHelper_Benchmark::GetString](#ResourceHelper_Benchmark_GetString) v5.12.0 is **699,43%** (Δ: 2259,341 ns) slower than v5.9.0

3. [ScopeManager_Benchmark::Get_New_ScopeManager](#ScopeManager_Benchmark_Get_New_ScopeManager) v5.12.0 is **434,99%** (Δ: 451,553 ns) slower than v5.9.0

4. [ScopeManager_Benchmark::Get_Existing_ScopeManager](#ScopeManager_Benchmark_Get_Existing_ScopeManager) v5.12.0 is **404,14%** (Δ: 448,060 ns) slower than v5.9.0

5. [ExpressionHelper_Benchmark::GetPropertyName](#ExpressionHelper_Benchmark_GetPropertyName) v5.12.0 is **82,52%** (Δ: 1652,275 ns) slower than v5.9.0

6. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Instance](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance) v5.12.0 is **56,34%** (Δ: 1908,963 ns) slower than v5.9.0

7. [Type_ReflectionExtensions_Benchmark::GetMethodsEx_Flatten_Static](#Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static) v5.12.0 is **54,32%** (Δ: 1904,328 ns) slower than v5.9.0

8. [ViewModelBase_Benchmark::Construction](#ViewModelBase_Benchmark_Construction) v5.12.0 is **53,57%** (Δ: 7500,480 ns) slower than v5.9.0

9. [ExpressionHelper_Benchmark::GetOwner](#ExpressionHelper_Benchmark_GetOwner) v5.12.0 is **38,79%** (Δ: 406,075 ns) slower than v5.9.0

10. [Type_ReflectionExtensions_Benchmark::GetPropertyEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags) v5.12.0 is **16,10%** (Δ: 287,757 ns) slower than v5.9.0

11. [Serialization_Binary_Benchmark::SerializeLevel3Models](#Serialization_Binary_Benchmark_SerializeLevel3Models) v5.12.0 is **7,29%** (Δ: 64557,925 ns) slower than v5.9.0

12. [Serialization_Binary_Benchmark::SerializeLevel2Models](#Serialization_Binary_Benchmark_SerializeLevel2Models) v5.12.0 is **6,28%** (Δ: 20574,965 ns) slower than v5.9.0

13. [Type_ReflectionExtensions_Benchmark::IsInstanceOfTypeEx](#Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx) v5.12.0 is **5,93%** (Δ: 895,755 ns) slower than v5.9.0

14. [Serialization_Binary_Benchmark::SerializeComplexObjectGraph](#Serialization_Binary_Benchmark_SerializeComplexObjectGraph) v5.12.0 is **5,78%** (Δ: 22539,496 ns) slower than v5.9.0

15. [Serialization_Binary_Benchmark::SerializeLevel1Models](#Serialization_Binary_Benchmark_SerializeLevel1Models) v5.12.0 is **4,26%** (Δ: 9870,165 ns) slower than v5.9.0

16. [Serialization_Json_Benchmark::SerializeLevel1Models](#Serialization_Json_Benchmark_SerializeLevel1Models) v5.12.0 is **2,27%** (Δ: 15684,243 ns) slower than v5.9.0

17. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_100](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100) v5.12.0 is **2,17%** (Δ: 51728,884 ns) slower than v5.9.0



### Improved (current version faster than previous one)

17 item(s)

1. [Serialization_Xml_Benchmark::SerializeLevel3Models](#Serialization_Xml_Benchmark_SerializeLevel3Models) v5.12.0 is **50,46%** (Δ: -963917,440 ns) faster than v5.9.0

2. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_500](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500) v5.12.0 is **48,41%** (Δ: -652271,813 ns) faster than v5.9.0

3. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_1000](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000) v5.12.0 is **48,33%** (Δ: -634094,263 ns) faster than v5.9.0

4. [Serialization_Xml_Benchmark::SerializeComplexObjectGraph](#Serialization_Xml_Benchmark_SerializeComplexObjectGraph) v5.12.0 is **40,15%** (Δ: -350523,232 ns) faster than v5.9.0

5. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType__Inheritd](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd) v5.12.0 is **36,09%** (Δ: -2088,448 ns) faster than v5.9.0

6. [Serialization_Xml_Benchmark::SerializeLevel2Models](#Serialization_Xml_Benchmark_SerializeLevel2Models) v5.12.0 is **34,97%** (Δ: -201847,325 ns) faster than v5.9.0

7. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v5.12.0 is **33,86%** (Δ: -1930,845 ns) faster than v5.9.0

8. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit) v5.12.0 is **30,40%** (Δ: -1916,061 ns) faster than v5.9.0

9. [Log_Status_Benchmark::Log_Status_Format_4_Format_Arguments](#Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments) v5.12.0 is **29,97%** (Δ: -344,697 ns) faster than v5.9.0

10. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType) v5.12.0 is **28,45%** (Δ: -868,277 ns) faster than v5.9.0

11. [Serialization_Xml_Benchmark::SerializeLevel1Models](#Serialization_Xml_Benchmark_SerializeLevel1Models) v5.12.0 is **27,28%** (Δ: -88816,472 ns) faster than v5.9.0

12. [Log_Info_Benchmark::Log_Info_Format_7_Format_Arguments](#Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments) v5.12.0 is **24,63%** (Δ: -360,139 ns) faster than v5.9.0

13. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.12.0 is **21,35%** (Δ: -790,755 ns) faster than v5.9.0

14. [Type_ReflectionExtensions_Benchmark::GetEventEx_Static_BindingFlags](#Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags) v5.12.0 is **19,64%** (Δ: -482,845 ns) faster than v5.9.0

15. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx) v5.12.0 is **13,56%** (Δ: -324,443 ns) faster than v5.9.0

16. [AssemblyExtensions_Benchmark::Product](#AssemblyExtensions_Benchmark_Product) v5.12.0 is **8,93%** (Δ: -499,877 ns) faster than v5.9.0

17. [Serialization_Json_Benchmark::SerializeComplexObjectGraph](#Serialization_Json_Benchmark_SerializeComplexObjectGraph) v5.12.0 is **1,66%** (Δ: -202908,011 ns) faster than v5.9.0



## <a name="Argument_Benchmark"></a>Argument_Benchmark

### <a name="Argument_Benchmark_ImplementsInterface"></a>ImplementsInterface

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 6,361 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">69,127 ns</td><td align="right" bgcolor="#FFFFFF">72,240 ns</td><td align="right" bgcolor="#FFFFFF">71,049 ns</td><td align="right" bgcolor="#FFFFFF">75,488 ns</td><td align="right" bgcolor="#FFFFFF">70,923 ns</td><td align="right" bgcolor="#FFFFFF">73,907 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 41,945 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">73,109 ns</td><td align="right" bgcolor="#FFFFFF">73,253 ns</td><td align="right" bgcolor="#FFFFFF">78,307 ns</td><td align="right" bgcolor="#FFFFFF">109,892 ns</td><td align="right" bgcolor="#FFFFFF">67,947 ns</td><td align="right" bgcolor="#FFFFFF">79,523 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 7,516 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">67,077 ns</td><td align="right" bgcolor="#FFFFFF">64,704 ns</td><td align="right" bgcolor="#FFFFFF">62,351 ns</td><td align="right" bgcolor="#FFFFFF">69,101 ns</td><td align="right" bgcolor="#FFFFFF">67,120 ns</td><td align="right" bgcolor="#FFFFFF">69,867 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 9,864 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">79,261 ns</td><td align="right" bgcolor="#FFFFFF">69,397 ns</td><td align="right" bgcolor="#FFFFFF">72,268 ns</td><td align="right" bgcolor="#FFFFFF">73,743 ns</td><td align="right" bgcolor="#FFFFFF">70,917 ns</td><td align="right" bgcolor="#FFFFFF">75,027 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 9,805 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">28,589 ns</td><td align="right" bgcolor="#FFFFFF">28,952 ns</td><td align="right" bgcolor="#FFFFFF">28,884 ns</td><td align="right" bgcolor="#FFFFFF">38,395 ns</td><td align="right" bgcolor="#FFFFFF">30,613 ns</td><td align="right" bgcolor="#FFFFFF">31,251 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Generic"></a>InheritsFrom_Generic

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 9,685 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35,207 ns</td><td align="right" bgcolor="#FFFFFF">30,477 ns</td><td align="right" bgcolor="#FFFFFF">32,624 ns</td><td align="right" bgcolor="#FFFFFF">40,163 ns</td><td align="right" bgcolor="#FFFFFF">31,647 ns</td><td align="right" bgcolor="#FFFFFF">30,555 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Object"></a>InheritsFrom_Object

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 12,621 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30,787 ns</td><td align="right" bgcolor="#FFFFFF">36,616 ns</td><td align="right" bgcolor="#FFFFFF">33,212 ns</td><td align="right" bgcolor="#FFFFFF">43,408 ns</td><td align="right" bgcolor="#FFFFFF">33,832 ns</td><td align="right" bgcolor="#FFFFFF">33,541 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsMatch"></a>IsMatch

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 94,952 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">556,572 ns</td><td align="right" bgcolor="#FFFFFF">601,253 ns</td><td align="right" bgcolor="#FFFFFF">580,679 ns</td><td align="right" bgcolor="#FFFFFF">559,867 ns</td><td align="right" bgcolor="#FFFFFF">545,537 ns</td><td align="right" bgcolor="#FFFFFF">506,301 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,557 μs</td><td align="right" bgcolor="#FFFFFF">0,601 μs</td><td align="right" bgcolor="#FFFFFF">0,581 μs</td><td align="right" bgcolor="#FFFFFF">0,560 μs</td><td align="right" bgcolor="#FFFFFF">0,546 μs</td><td align="right" bgcolor="#FFFFFF">0,506 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsMaximum"></a>IsMaximum

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 3,436 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,851 ns</td><td align="right" bgcolor="#FFFFFF">10,355 ns</td><td align="right" bgcolor="#FFFFFF">9,537 ns</td><td align="right" bgcolor="#FFFFFF">12,973 ns</td><td align="right" bgcolor="#FFFFFF">9,901 ns</td><td align="right" bgcolor="#FFFFFF">9,955 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 6,273 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,581 ns</td><td align="right" bgcolor="#FFFFFF">17,261 ns</td><td align="right" bgcolor="#FFFFFF">11,176 ns</td><td align="right" bgcolor="#FFFFFF">13,152 ns</td><td align="right" bgcolor="#FFFFFF">10,988 ns</td><td align="right" bgcolor="#FFFFFF">11,637 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 1,085 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,835 ns</td><td align="right" bgcolor="#FFFFFF">3,724 ns</td><td align="right" bgcolor="#FFFFFF">3,933 ns</td><td align="right" bgcolor="#FFFFFF">3,320 ns</td><td align="right" bgcolor="#FFFFFF">4,227 ns</td><td align="right" bgcolor="#FFFFFF">3,141 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotMatch"></a>IsNotMatch

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 92,957 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">435,995 ns</td><td align="right" bgcolor="#FFFFFF">440,859 ns</td><td align="right" bgcolor="#FFFFFF">411,095 ns</td><td align="right" bgcolor="#FFFFFF">434,373 ns</td><td align="right" bgcolor="#FFFFFF">421,909 ns</td><td align="right" bgcolor="#FFFFFF">347,901 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,436 μs</td><td align="right" bgcolor="#FFFFFF">0,441 μs</td><td align="right" bgcolor="#FFFFFF">0,411 μs</td><td align="right" bgcolor="#FFFFFF">0,434 μs</td><td align="right" bgcolor="#FFFFFF">0,422 μs</td><td align="right" bgcolor="#FFFFFF">0,348 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotNull"></a>IsNotNull

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 0,899 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,008 ns</td><td align="right" bgcolor="#FFFFFF">0,525 ns</td><td align="right" bgcolor="#FFFFFF">0,744 ns</td><td align="right" bgcolor="#FFFFFF">1,283 ns</td><td align="right" bgcolor="#FFFFFF">1,040 ns</td><td align="right" bgcolor="#FFFFFF">0,384 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 0,733 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,536 ns</td><td align="right" bgcolor="#FFFFFF">0,424 ns</td><td align="right" bgcolor="#FFFFFF">0,885 ns</td><td align="right" bgcolor="#FFFFFF">0,539 ns</td><td align="right" bgcolor="#FFFFFF">1,157 ns</td><td align="right" bgcolor="#FFFFFF">0,664 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty_Guid"></a>IsNotNullOrEmpty_Guid

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 0,823 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,616 ns</td><td align="right" bgcolor="#FFFFFF">7,175 ns</td><td align="right" bgcolor="#FFFFFF">7,779 ns</td><td align="right" bgcolor="#FFFFFF">7,997 ns</td><td align="right" bgcolor="#FFFFFF">7,464 ns</td><td align="right" bgcolor="#FFFFFF">7,611 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmptyArray"></a>IsNotNullOrEmptyArray

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 1,187 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,384 ns</td><td align="right" bgcolor="#FFFFFF">2,261 ns</td><td align="right" bgcolor="#FFFFFF">2,235 ns</td><td align="right" bgcolor="#FFFFFF">2,184 ns</td><td align="right" bgcolor="#FFFFFF">3,371 ns</td><td align="right" bgcolor="#FFFFFF">2,452 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrWhitespace"></a>IsNotNullOrWhitespace

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 5,232 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,779 ns</td><td align="right" bgcolor="#FFFFFF">8,101 ns</td><td align="right" bgcolor="#FFFFFF">9,384 ns</td><td align="right" bgcolor="#FFFFFF">8,704 ns</td><td align="right" bgcolor="#FFFFFF">4,307 ns</td><td align="right" bgcolor="#FFFFFF">4,152 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes"></a>IsNotOfOneOfTheTypes

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 6,237 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">57,741 ns</td><td align="right" bgcolor="#FFFFFF">55,677 ns</td><td align="right" bgcolor="#FFFFFF">57,645 ns</td><td align="right" bgcolor="#FFFFFF">61,915 ns</td><td align="right" bgcolor="#FFFFFF">58,405 ns</td><td align="right" bgcolor="#FFFFFF">60,536 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes_Object"></a>IsNotOfOneOfTheTypes_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 6,901 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">61,683 ns</td><td align="right" bgcolor="#FFFFFF">58,229 ns</td><td align="right" bgcolor="#FFFFFF">62,157 ns</td><td align="right" bgcolor="#FFFFFF">63,453 ns</td><td align="right" bgcolor="#FFFFFF">59,635 ns</td><td align="right" bgcolor="#FFFFFF">65,131 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,060 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType"></a>IsNotOfType

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 4,184 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">40,397 ns</td><td align="right" bgcolor="#FFFFFF">39,141 ns</td><td align="right" bgcolor="#FFFFFF">39,591 ns</td><td align="right" bgcolor="#FFFFFF">39,528 ns</td><td align="right" bgcolor="#FFFFFF">40,061 ns</td><td align="right" bgcolor="#FFFFFF">43,325 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType_Object"></a>IsNotOfType_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 7,829 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">50,547 ns</td><td align="right" bgcolor="#FFFFFF">44,152 ns</td><td align="right" bgcolor="#FFFFFF">47,573 ns</td><td align="right" bgcolor="#FFFFFF">51,981 ns</td><td align="right" bgcolor="#FFFFFF">46,147 ns</td><td align="right" bgcolor="#FFFFFF">45,496 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOutOfRange"></a>IsNotOutOfRange

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 3,116 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,515 ns</td><td align="right" bgcolor="#FFFFFF">16,424 ns</td><td align="right" bgcolor="#FFFFFF">17,832 ns</td><td align="right" bgcolor="#FFFFFF">15,856 ns</td><td align="right" bgcolor="#FFFFFF">18,972 ns</td><td align="right" bgcolor="#FFFFFF">17,827 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FFFFFF">49,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#FFFFFF">0,048</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes"></a>IsOfOneOfTheTypes

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 23,504 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">51,404 ns</td><td align="right" bgcolor="#FFFFFF">63,104 ns</td><td align="right" bgcolor="#FFFFFF">42,379 ns</td><td align="right" bgcolor="#FFFFFF">42,811 ns</td><td align="right" bgcolor="#FFFFFF">42,293 ns</td><td align="right" bgcolor="#FFFFFF">39,600 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfOneOfTheTypes_Object"></a>IsOfOneOfTheTypes_Object

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 1,899 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">46,659 ns</td><td align="right" bgcolor="#FFFFFF">48,157 ns</td><td align="right" bgcolor="#FFFFFF">46,509 ns</td><td align="right" bgcolor="#FFFFFF">48,309 ns</td><td align="right" bgcolor="#FFFFFF">46,795 ns</td><td align="right" bgcolor="#FFFFFF">46,411 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType"></a>IsOfType

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 5,021 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">27,805 ns</td><td align="right" bgcolor="#FFFFFF">27,219 ns</td><td align="right" bgcolor="#FFFFFF">27,216 ns</td><td align="right" bgcolor="#FFFFFF">31,216 ns</td><td align="right" bgcolor="#FFFFFF">26,664 ns</td><td align="right" bgcolor="#FFFFFF">26,195 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType_Object"></a>IsOfType_Object

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 2,616 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">32,013 ns</td><td align="right" bgcolor="#FFFFFF">33,187 ns</td><td align="right" bgcolor="#FFFFFF">32,173 ns</td><td align="right" bgcolor="#FFFFFF">34,629 ns</td><td align="right" bgcolor="#FFFFFF">32,756 ns</td><td align="right" bgcolor="#FFFFFF">33,813 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="Assembly_ReflectionExtensions_Benchmark"></a>Assembly_ReflectionExtensions_Benchmark

### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 408,003 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#A8D08D">-9,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4275,536 ns</td><td align="right" bgcolor="#FFFFFF">4276,845 ns</td><td align="right" bgcolor="#FF4949">4527,269 ns (Δ = +250,424 ns)</td><td align="right" bgcolor="#A8D08D">4119,267 ns (Δ = -408,003 ns)</td><td align="right" bgcolor="#FFFFFF">4324,181 ns</td><td align="right" bgcolor="#FFFFFF">4154,272 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,276 μs</td><td align="right" bgcolor="#FFFFFF">4,277 μs</td><td align="right" bgcolor="#FFFFFF">4,527 μs</td><td align="right" bgcolor="#FFFFFF">4,119 μs</td><td align="right" bgcolor="#FFFFFF">4,324 μs</td><td align="right" bgcolor="#FFFFFF">4,154 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#FFFFFF">731,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#FFFFFF">0,714</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 939,872 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,0 %</td><td align="right" bgcolor="#A8D08D">-5,0 %</td><td align="right" bgcolor="#A8D08D">-12,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4497,897 ns</td><td align="right" bgcolor="#FFFFFF">4263,624 ns</td><td align="right" bgcolor="#FF4949">5203,496 ns (Δ = +939,872 ns)</td><td align="right" bgcolor="#A8D08D">4943,040 ns (Δ = -260,456 ns)</td><td align="right" bgcolor="#A8D08D">4303,672 ns (Δ = -639,368 ns)</td><td align="right" bgcolor="#FFFFFF">4293,789 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,498 μs</td><td align="right" bgcolor="#FFFFFF">4,264 μs</td><td align="right" bgcolor="#FFFFFF">5,203 μs</td><td align="right" bgcolor="#FFFFFF">4,943 μs</td><td align="right" bgcolor="#FFFFFF">4,304 μs</td><td align="right" bgcolor="#FFFFFF">4,294 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#FFFFFF">731,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#FFFFFF">0,714</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 270,211 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10118,125 ns</td><td align="right" bgcolor="#FFFFFF">10135,011 ns</td><td align="right" bgcolor="#FFFFFF">10101,661 ns</td><td align="right" bgcolor="#FFFFFF">10012,743 ns</td><td align="right" bgcolor="#FFFFFF">9976,776 ns</td><td align="right" bgcolor="#FFFFFF">9864,800 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10,118 μs</td><td align="right" bgcolor="#FFFFFF">10,135 μs</td><td align="right" bgcolor="#FFFFFF">10,102 μs</td><td align="right" bgcolor="#FFFFFF">10,013 μs</td><td align="right" bgcolor="#FFFFFF">9,977 μs</td><td align="right" bgcolor="#FFFFFF">9,865 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1383,000</td><td align="right" bgcolor="#FFFFFF">1383,000</td><td align="right" bgcolor="#FFFFFF">1383,000</td><td align="right" bgcolor="#FFFFFF">1383,000</td><td align="right" bgcolor="#FFFFFF">1383,000</td><td align="right" bgcolor="#FFFFFF">1383,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,351</td><td align="right" bgcolor="#FFFFFF">1,351</td><td align="right" bgcolor="#FFFFFF">1,351</td><td align="right" bgcolor="#FFFFFF">1,351</td><td align="right" bgcolor="#FFFFFF">1,351</td><td align="right" bgcolor="#FFFFFF">1,351</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 133,861 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4512,595 ns</td><td align="right" bgcolor="#FFFFFF">4378,733 ns</td><td align="right" bgcolor="#FFFFFF">4458,099 ns</td><td align="right" bgcolor="#FFFFFF">4395,271 ns</td><td align="right" bgcolor="#FFFFFF">4391,724 ns</td><td align="right" bgcolor="#FFFFFF">4441,299 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,513 μs</td><td align="right" bgcolor="#FFFFFF">4,379 μs</td><td align="right" bgcolor="#FFFFFF">4,458 μs</td><td align="right" bgcolor="#FFFFFF">4,395 μs</td><td align="right" bgcolor="#FFFFFF">4,392 μs</td><td align="right" bgcolor="#FFFFFF">4,441 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3053,000</td><td align="right" bgcolor="#FFFFFF">3053,000</td><td align="right" bgcolor="#FFFFFF">3053,000</td><td align="right" bgcolor="#FFFFFF">3053,000</td><td align="right" bgcolor="#FFFFFF">3053,000</td><td align="right" bgcolor="#FFFFFF">3053,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,981</td><td align="right" bgcolor="#FFFFFF">2,981</td><td align="right" bgcolor="#FFFFFF">2,981</td><td align="right" bgcolor="#FFFFFF">2,981</td><td align="right" bgcolor="#FFFFFF">2,981</td><td align="right" bgcolor="#FFFFFF">2,981</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td></tr></table>


## <a name="AssemblyExtensions_Benchmark"></a>AssemblyExtensions_Benchmark

### <a name="AssemblyExtensions_Benchmark_Company"></a>Company

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 451,697 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5002,697 ns</td><td align="right" bgcolor="#FFFFFF">5195,295 ns</td><td align="right" bgcolor="#FFFFFF">5413,377 ns</td><td align="right" bgcolor="#A8D08D">4961,680 ns (Δ = -451,697 ns)</td><td align="right" bgcolor="#FFFFFF">5187,416 ns</td><td align="right" bgcolor="#FFFFFF">5196,773 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,003 μs</td><td align="right" bgcolor="#FFFFFF">5,195 μs</td><td align="right" bgcolor="#FFFFFF">5,413 μs</td><td align="right" bgcolor="#FFFFFF">4,962 μs</td><td align="right" bgcolor="#FFFFFF">5,187 μs</td><td align="right" bgcolor="#FFFFFF">5,197 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FF4949">862,000 (Δ = +26,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FF4949">0,842 (Δ = +0,025)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 348,548 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5009,036 ns</td><td align="right" bgcolor="#FFFFFF">5170,040 ns</td><td align="right" bgcolor="#FFFFFF">5357,584 ns</td><td align="right" bgcolor="#FFFFFF">5178,883 ns</td><td align="right" bgcolor="#FFFFFF">5179,565 ns</td><td align="right" bgcolor="#FFFFFF">5218,069 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,009 μs</td><td align="right" bgcolor="#FFFFFF">5,170 μs</td><td align="right" bgcolor="#FFFFFF">5,358 μs</td><td align="right" bgcolor="#FFFFFF">5,179 μs</td><td align="right" bgcolor="#FFFFFF">5,180 μs</td><td align="right" bgcolor="#FFFFFF">5,218 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">885,000</td><td align="right" bgcolor="#FFFFFF">885,000</td><td align="right" bgcolor="#FFFFFF">885,000</td><td align="right" bgcolor="#FFFFFF">885,000</td><td align="right" bgcolor="#FFFFFF">885,000</td><td align="right" bgcolor="#FF4949">908,000 (Δ = +23,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,864</td><td align="right" bgcolor="#FFFFFF">0,864</td><td align="right" bgcolor="#FFFFFF">0,864</td><td align="right" bgcolor="#FFFFFF">0,864</td><td align="right" bgcolor="#FFFFFF">0,864</td><td align="right" bgcolor="#FF4949">0,887 (Δ = +0,022)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Description"></a>Description

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 337,355 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,2 %</td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5067,111 ns</td><td align="right" bgcolor="#FFFFFF">5072,013 ns</td><td align="right" bgcolor="#FF4949">5384,720 ns (Δ = +312,707 ns)</td><td align="right" bgcolor="#A8D08D">5047,365 ns (Δ = -337,355 ns)</td><td align="right" bgcolor="#FFFFFF">5070,792 ns</td><td align="right" bgcolor="#FFFFFF">5076,175 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,067 μs</td><td align="right" bgcolor="#FFFFFF">5,072 μs</td><td align="right" bgcolor="#FFFFFF">5,385 μs</td><td align="right" bgcolor="#FFFFFF">5,047 μs</td><td align="right" bgcolor="#FFFFFF">5,071 μs</td><td align="right" bgcolor="#FFFFFF">5,076 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">878,000 (Δ = +26,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,857 (Δ = +0,025)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 3437,603 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">274764,960 ns</td><td align="right" bgcolor="#FFFFFF">274803,617 ns</td><td align="right" bgcolor="#FFFFFF">277207,371 ns</td><td align="right" bgcolor="#FFFFFF">275070,248 ns</td><td align="right" bgcolor="#FFFFFF">273769,768 ns</td><td align="right" bgcolor="#FFFFFF">275083,619 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">274,765 μs</td><td align="right" bgcolor="#FFFFFF">274,804 μs</td><td align="right" bgcolor="#FFFFFF">277,207 μs</td><td align="right" bgcolor="#FFFFFF">275,070 μs</td><td align="right" bgcolor="#FFFFFF">273,770 μs</td><td align="right" bgcolor="#FFFFFF">275,084 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,275 ms</td><td align="right" bgcolor="#FFFFFF">0,275 ms</td><td align="right" bgcolor="#FFFFFF">0,277 ms</td><td align="right" bgcolor="#FFFFFF">0,275 ms</td><td align="right" bgcolor="#FFFFFF">0,274 ms</td><td align="right" bgcolor="#FFFFFF">0,275 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">5.6.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.6.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">24,000</td><td align="right" bgcolor="#FFFFFF">24,000</td><td align="right" bgcolor="#FFFFFF">24,000</td><td align="right" bgcolor="#FFFFFF">24,000</td><td align="right" bgcolor="#FFFFFF">24,000</td><td align="right" bgcolor="#FFFFFF">24,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20694,000</td><td align="right" bgcolor="#FFFFFF">20694,000</td><td align="right" bgcolor="#FFFFFF">20694,000</td><td align="right" bgcolor="#A8D08D">20686,000 (Δ = -8,000)</td><td align="right" bgcolor="#FF4949">20694,000 (Δ = +8,000)</td><td align="right" bgcolor="#FFFFFF">20694,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">20,209</td><td align="right" bgcolor="#FFFFFF">20,209</td><td align="right" bgcolor="#FFFFFF">20,209</td><td align="right" bgcolor="#A8D08D">20,201 (Δ = -0,008)</td><td align="right" bgcolor="#FF4949">20,209 (Δ = +0,008)</td><td align="right" bgcolor="#FFFFFF">20,209</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,020 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,020</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 96,789 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1907,352 ns</td><td align="right" bgcolor="#FFFFFF">1967,448 ns</td><td align="right" bgcolor="#FFFFFF">1948,747 ns</td><td align="right" bgcolor="#FFFFFF">2004,141 ns</td><td align="right" bgcolor="#FFFFFF">1968,264 ns</td><td align="right" bgcolor="#FFFFFF">1931,277 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,907 μs</td><td align="right" bgcolor="#FFFFFF">1,967 μs</td><td align="right" bgcolor="#FFFFFF">1,949 μs</td><td align="right" bgcolor="#FFFFFF">2,004 μs</td><td align="right" bgcolor="#FFFFFF">1,968 μs</td><td align="right" bgcolor="#FFFFFF">1,931 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1068,000</td><td align="right" bgcolor="#FFFFFF">1068,000</td><td align="right" bgcolor="#FFFFFF">1068,000</td><td align="right" bgcolor="#FFFFFF">1068,000</td><td align="right" bgcolor="#FFFFFF">1068,000</td><td align="right" bgcolor="#FFFFFF">1068,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,043</td><td align="right" bgcolor="#FFFFFF">1,043</td><td align="right" bgcolor="#FFFFFF">1,043</td><td align="right" bgcolor="#FFFFFF">1,043</td><td align="right" bgcolor="#FFFFFF">1,043</td><td align="right" bgcolor="#FFFFFF">1,043</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 203,160 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4255,523 ns</td><td align="right" bgcolor="#FFFFFF">4277,596 ns</td><td align="right" bgcolor="#FFFFFF">4324,944 ns</td><td align="right" bgcolor="#FFFFFF">4121,784 ns</td><td align="right" bgcolor="#FFFFFF">4194,367 ns</td><td align="right" bgcolor="#FFFFFF">4318,973 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,256 μs</td><td align="right" bgcolor="#FFFFFF">4,278 μs</td><td align="right" bgcolor="#FFFFFF">4,325 μs</td><td align="right" bgcolor="#FFFFFF">4,122 μs</td><td align="right" bgcolor="#FFFFFF">4,194 μs</td><td align="right" bgcolor="#FFFFFF">4,319 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td><td align="right" bgcolor="#FFFFFF">773,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td><td align="right" bgcolor="#FFFFFF">0,755</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Product"></a>Product

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 610,904 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,9 %</td><td align="right" bgcolor="#A8D08D">-8,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4989,949 ns</td><td align="right" bgcolor="#FFFFFF">5033,781 ns</td><td align="right" bgcolor="#FFFFFF">5194,860 ns</td><td align="right" bgcolor="#FFFFFF">5141,783 ns</td><td align="right" bgcolor="#FF4949">5600,853 ns (Δ = +459,071 ns)</td><td align="right" bgcolor="#A8D08D">5100,976 ns (Δ = -499,877 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,990 μs</td><td align="right" bgcolor="#FFFFFF">5,034 μs</td><td align="right" bgcolor="#FFFFFF">5,195 μs</td><td align="right" bgcolor="#FFFFFF">5,142 μs</td><td align="right" bgcolor="#FFFFFF">5,601 μs</td><td align="right" bgcolor="#FFFFFF">5,101 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">878,000 (Δ = +26,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,857 (Δ = +0,025)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Title"></a>Title

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 145,809 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5102,085 ns</td><td align="right" bgcolor="#FFFFFF">5141,260 ns</td><td align="right" bgcolor="#FFFFFF">5056,459 ns</td><td align="right" bgcolor="#FFFFFF">5133,168 ns</td><td align="right" bgcolor="#FFFFFF">4995,451 ns</td><td align="right" bgcolor="#FFFFFF">5093,388 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,102 μs</td><td align="right" bgcolor="#FFFFFF">5,141 μs</td><td align="right" bgcolor="#FFFFFF">5,056 μs</td><td align="right" bgcolor="#FFFFFF">5,133 μs</td><td align="right" bgcolor="#FFFFFF">4,995 μs</td><td align="right" bgcolor="#FFFFFF">5,093 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">878,000 (Δ = +26,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,857 (Δ = +0,025)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Version"></a>Version

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 46,491 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">693,709 ns</td><td align="right" bgcolor="#FFFFFF">702,800 ns</td><td align="right" bgcolor="#FFFFFF">704,800 ns</td><td align="right" bgcolor="#FFFFFF">740,200 ns</td><td align="right" bgcolor="#FFFFFF">699,723 ns</td><td align="right" bgcolor="#FFFFFF">702,965 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,694 μs</td><td align="right" bgcolor="#FFFFFF">0,703 μs</td><td align="right" bgcolor="#FFFFFF">0,705 μs</td><td align="right" bgcolor="#FFFFFF">0,740 μs</td><td align="right" bgcolor="#FFFFFF">0,700 μs</td><td align="right" bgcolor="#FFFFFF">0,703 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1268,000</td><td align="right" bgcolor="#FFFFFF">1268,000</td><td align="right" bgcolor="#FFFFFF">1268,000</td><td align="right" bgcolor="#FFFFFF">1268,000</td><td align="right" bgcolor="#FFFFFF">1268,000</td><td align="right" bgcolor="#FFFFFF">1268,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,238</td><td align="right" bgcolor="#FFFFFF">1,238</td><td align="right" bgcolor="#FFFFFF">1,238</td><td align="right" bgcolor="#FFFFFF">1,238</td><td align="right" bgcolor="#FFFFFF">1,238</td><td align="right" bgcolor="#FFFFFF">1,238</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 413,763 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+25,7 %</td><td align="right" bgcolor="#A8D08D">-18,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1495,488 ns</td><td align="right" bgcolor="#FFFFFF">1496,395 ns</td><td align="right" bgcolor="#FFFFFF">1504,997 ns</td><td align="right" bgcolor="#FF4949">1891,387 ns (Δ = +386,389 ns)</td><td align="right" bgcolor="#A8D08D">1538,424 ns (Δ = -352,963 ns)</td><td align="right" bgcolor="#FFFFFF">1477,624 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,495 μs</td><td align="right" bgcolor="#FFFFFF">1,496 μs</td><td align="right" bgcolor="#FFFFFF">1,505 μs</td><td align="right" bgcolor="#FFFFFF">1,891 μs</td><td align="right" bgcolor="#FFFFFF">1,538 μs</td><td align="right" bgcolor="#FFFFFF">1,478 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 84,088 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1861,317 ns</td><td align="right" bgcolor="#FFFFFF">1816,769 ns</td><td align="right" bgcolor="#FFFFFF">1814,689 ns</td><td align="right" bgcolor="#FFFFFF">1798,789 ns</td><td align="right" bgcolor="#FFFFFF">1882,877 ns</td><td align="right" bgcolor="#FFFFFF">1862,261 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,861 μs</td><td align="right" bgcolor="#FFFFFF">1,817 μs</td><td align="right" bgcolor="#FFFFFF">1,815 μs</td><td align="right" bgcolor="#FFFFFF">1,799 μs</td><td align="right" bgcolor="#FFFFFF">1,883 μs</td><td align="right" bgcolor="#FFFFFF">1,862 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 370,644 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+24,1 %</td><td align="right" bgcolor="#A8D08D">-17,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1586,521 ns</td><td align="right" bgcolor="#FFFFFF">1511,528 ns</td><td align="right" bgcolor="#FFFFFF">1512,643 ns</td><td align="right" bgcolor="#FF4949">1876,791 ns (Δ = +364,148 ns)</td><td align="right" bgcolor="#A8D08D">1544,192 ns (Δ = -332,599 ns)</td><td align="right" bgcolor="#FFFFFF">1506,147 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,587 μs</td><td align="right" bgcolor="#FFFFFF">1,512 μs</td><td align="right" bgcolor="#FFFFFF">1,513 μs</td><td align="right" bgcolor="#FFFFFF">1,877 μs</td><td align="right" bgcolor="#FFFFFF">1,544 μs</td><td align="right" bgcolor="#FFFFFF">1,506 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 135,336 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1938,869 ns</td><td align="right" bgcolor="#FFFFFF">1830,704 ns</td><td align="right" bgcolor="#FFFFFF">1816,384 ns</td><td align="right" bgcolor="#FFFFFF">1951,720 ns</td><td align="right" bgcolor="#FFFFFF">1852,536 ns</td><td align="right" bgcolor="#FFFFFF">1862,613 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,939 μs</td><td align="right" bgcolor="#FFFFFF">1,831 μs</td><td align="right" bgcolor="#FFFFFF">1,816 μs</td><td align="right" bgcolor="#FFFFFF">1,952 μs</td><td align="right" bgcolor="#FFFFFF">1,853 μs</td><td align="right" bgcolor="#FFFFFF">1,863 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 297,596 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,7 %</td><td align="right" bgcolor="#A8D08D">-14,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1558,424 ns</td><td align="right" bgcolor="#FFFFFF">1500,031 ns</td><td align="right" bgcolor="#FFFFFF">1526,977 ns</td><td align="right" bgcolor="#FF4949">1797,627 ns (Δ = +270,649 ns)</td><td align="right" bgcolor="#A8D08D">1531,077 ns (Δ = -266,549 ns)</td><td align="right" bgcolor="#FFFFFF">1574,709 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,558 μs</td><td align="right" bgcolor="#FFFFFF">1,500 μs</td><td align="right" bgcolor="#FFFFFF">1,527 μs</td><td align="right" bgcolor="#FFFFFF">1,798 μs</td><td align="right" bgcolor="#FFFFFF">1,531 μs</td><td align="right" bgcolor="#FFFFFF">1,575 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 373,144 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2173,493 ns</td><td align="right" bgcolor="#A8D08D">1854,489 ns (Δ = -319,004 ns)</td><td align="right" bgcolor="#FFFFFF">1800,349 ns</td><td align="right" bgcolor="#FFFFFF">1846,085 ns</td><td align="right" bgcolor="#FFFFFF">1874,419 ns</td><td align="right" bgcolor="#FFFFFF">1863,027 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,173 μs</td><td align="right" bgcolor="#FFFFFF">1,854 μs</td><td align="right" bgcolor="#FFFFFF">1,800 μs</td><td align="right" bgcolor="#FFFFFF">1,846 μs</td><td align="right" bgcolor="#FFFFFF">1,874 μs</td><td align="right" bgcolor="#FFFFFF">1,863 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 683,476 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+44,2 %</td><td align="right" bgcolor="#A8D08D">-30,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1584,171 ns</td><td align="right" bgcolor="#FFFFFF">1556,832 ns</td><td align="right" bgcolor="#FFFFFF">1539,245 ns</td><td align="right" bgcolor="#FF4949">2218,923 ns (Δ = +679,677 ns)</td><td align="right" bgcolor="#A8D08D">1550,531 ns (Δ = -668,392 ns)</td><td align="right" bgcolor="#FFFFFF">1535,447 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,584 μs</td><td align="right" bgcolor="#FFFFFF">1,557 μs</td><td align="right" bgcolor="#FFFFFF">1,539 μs</td><td align="right" bgcolor="#FFFFFF">2,219 μs</td><td align="right" bgcolor="#FFFFFF">1,551 μs</td><td align="right" bgcolor="#FFFFFF">1,535 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 70,923 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1870,285 ns</td><td align="right" bgcolor="#FFFFFF">1824,008 ns</td><td align="right" bgcolor="#FFFFFF">1812,740 ns</td><td align="right" bgcolor="#FFFFFF">1805,707 ns</td><td align="right" bgcolor="#FFFFFF">1829,795 ns</td><td align="right" bgcolor="#FFFFFF">1876,629 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,870 μs</td><td align="right" bgcolor="#FFFFFF">1,824 μs</td><td align="right" bgcolor="#FFFFFF">1,813 μs</td><td align="right" bgcolor="#FFFFFF">1,806 μs</td><td align="right" bgcolor="#FFFFFF">1,830 μs</td><td align="right" bgcolor="#FFFFFF">1,877 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 351,989 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,4 %</td><td align="right" bgcolor="#A8D08D">-15,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1478,485 ns</td><td align="right" bgcolor="#FFFFFF">1473,692 ns</td><td align="right" bgcolor="#FFFFFF">1503,328 ns</td><td align="right" bgcolor="#FF4949">1810,520 ns (Δ = +307,192 ns)</td><td align="right" bgcolor="#A8D08D">1531,835 ns (Δ = -278,685 ns)</td><td align="right" bgcolor="#FFFFFF">1458,531 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,478 μs</td><td align="right" bgcolor="#FFFFFF">1,474 μs</td><td align="right" bgcolor="#FFFFFF">1,503 μs</td><td align="right" bgcolor="#FFFFFF">1,811 μs</td><td align="right" bgcolor="#FFFFFF">1,532 μs</td><td align="right" bgcolor="#FFFFFF">1,459 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 105,381 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1834,171 ns</td><td align="right" bgcolor="#FFFFFF">1842,301 ns</td><td align="right" bgcolor="#FFFFFF">1902,739 ns</td><td align="right" bgcolor="#FFFFFF">1797,397 ns</td><td align="right" bgcolor="#FFFFFF">1902,779 ns</td><td align="right" bgcolor="#FFFFFF">1820,544 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,834 μs</td><td align="right" bgcolor="#FFFFFF">1,842 μs</td><td align="right" bgcolor="#FFFFFF">1,903 μs</td><td align="right" bgcolor="#FFFFFF">1,797 μs</td><td align="right" bgcolor="#FFFFFF">1,903 μs</td><td align="right" bgcolor="#FFFFFF">1,821 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 577,863 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+37,4 %</td><td align="right" bgcolor="#A8D08D">-27,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1573,291 ns</td><td align="right" bgcolor="#FFFFFF">1521,073 ns</td><td align="right" bgcolor="#FFFFFF">1527,648 ns</td><td align="right" bgcolor="#FF4949">2098,936 ns (Δ = +571,288 ns)</td><td align="right" bgcolor="#A8D08D">1522,963 ns (Δ = -575,973 ns)</td><td align="right" bgcolor="#FFFFFF">1581,731 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,573 μs</td><td align="right" bgcolor="#FFFFFF">1,521 μs</td><td align="right" bgcolor="#FFFFFF">1,528 μs</td><td align="right" bgcolor="#FFFFFF">2,099 μs</td><td align="right" bgcolor="#FFFFFF">1,523 μs</td><td align="right" bgcolor="#FFFFFF">1,582 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **5.6.0**

Slowest: 5.9.0

Δ: 152,693 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1884,205 ns</td><td align="right" bgcolor="#FFFFFF">1818,352 ns</td><td align="right" bgcolor="#FFFFFF">1822,419 ns</td><td align="right" bgcolor="#FFFFFF">1798,523 ns</td><td align="right" bgcolor="#FFFFFF">1951,216 ns</td><td align="right" bgcolor="#FFFFFF">1844,285 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,884 μs</td><td align="right" bgcolor="#FFFFFF">1,818 μs</td><td align="right" bgcolor="#FFFFFF">1,822 μs</td><td align="right" bgcolor="#FFFFFF">1,799 μs</td><td align="right" bgcolor="#FFFFFF">1,951 μs</td><td align="right" bgcolor="#FFFFFF">1,844 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 16,675 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">210,757 ns</td><td align="right" bgcolor="#FFFFFF">214,525 ns</td><td align="right" bgcolor="#FFFFFF">201,211 ns</td><td align="right" bgcolor="#FFFFFF">210,421 ns</td><td align="right" bgcolor="#FFFFFF">197,851 ns</td><td align="right" bgcolor="#FFFFFF">213,440 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,215 μs</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 24,368 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">206,255 ns</td><td align="right" bgcolor="#FFFFFF">209,832 ns</td><td align="right" bgcolor="#FFFFFF">209,197 ns</td><td align="right" bgcolor="#FFFFFF">215,195 ns</td><td align="right" bgcolor="#FFFFFF">201,592 ns</td><td align="right" bgcolor="#FFFFFF">225,960 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td><td align="right" bgcolor="#FFFFFF">0,209 μs</td><td align="right" bgcolor="#FFFFFF">0,215 μs</td><td align="right" bgcolor="#FFFFFF">0,202 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 21,165 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">220,224 ns</td><td align="right" bgcolor="#FFFFFF">206,117 ns</td><td align="right" bgcolor="#FFFFFF">199,059 ns</td><td align="right" bgcolor="#FFFFFF">210,077 ns</td><td align="right" bgcolor="#FFFFFF">212,441 ns</td><td align="right" bgcolor="#FFFFFF">211,096 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,220 μs</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#FFFFFF">0,199 μs</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td><td align="right" bgcolor="#FFFFFF">0,212 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 13,528 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">192,011 ns</td><td align="right" bgcolor="#FFFFFF">189,261 ns</td><td align="right" bgcolor="#FFFFFF">191,187 ns</td><td align="right" bgcolor="#FFFFFF">200,816 ns</td><td align="right" bgcolor="#FFFFFF">202,789 ns</td><td align="right" bgcolor="#FFFFFF">192,885 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,189 μs</td><td align="right" bgcolor="#FFFFFF">0,191 μs</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FFFFFF">0,203 μs</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#FFFFFF">0,118</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 9,036 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">192,384 ns</td><td align="right" bgcolor="#FFFFFF">189,513 ns</td><td align="right" bgcolor="#FFFFFF">195,024 ns</td><td align="right" bgcolor="#FFFFFF">196,189 ns</td><td align="right" bgcolor="#FFFFFF">191,652 ns</td><td align="right" bgcolor="#FFFFFF">198,549 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,190 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,199 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#FFFFFF">0,118</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 31,144 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">206,263 ns</td><td align="right" bgcolor="#FFFFFF">202,120 ns</td><td align="right" bgcolor="#FFFFFF">205,485 ns</td><td align="right" bgcolor="#FFFFFF">214,440 ns</td><td align="right" bgcolor="#FFFFFF">205,339 ns</td><td align="right" bgcolor="#FFFFFF">233,264 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#FFFFFF">0,202 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td><td align="right" bgcolor="#FFFFFF">220,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td><td align="right" bgcolor="#FFFFFF">0,215</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 68,235 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">677,507 ns</td><td align="right" bgcolor="#FFFFFF">665,448 ns</td><td align="right" bgcolor="#FFFFFF">633,429 ns</td><td align="right" bgcolor="#FFFFFF">701,664 ns</td><td align="right" bgcolor="#FFFFFF">667,597 ns</td><td align="right" bgcolor="#FFFFFF">687,203 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,678 μs</td><td align="right" bgcolor="#FFFFFF">0,665 μs</td><td align="right" bgcolor="#FFFFFF">0,633 μs</td><td align="right" bgcolor="#FFFFFF">0,702 μs</td><td align="right" bgcolor="#FFFFFF">0,668 μs</td><td align="right" bgcolor="#FFFFFF">0,687 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">187,000</td><td align="right" bgcolor="#FFFFFF">187,000</td><td align="right" bgcolor="#FFFFFF">187,000</td><td align="right" bgcolor="#FFFFFF">187,000</td><td align="right" bgcolor="#FFFFFF">187,000</td><td align="right" bgcolor="#FFFFFF">187,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,183</td><td align="right" bgcolor="#FFFFFF">0,183</td><td align="right" bgcolor="#FFFFFF">0,183</td><td align="right" bgcolor="#FFFFFF">0,183</td><td align="right" bgcolor="#FFFFFF">0,183</td><td align="right" bgcolor="#FFFFFF">0,183</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 5,652 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">95,861 ns</td><td align="right" bgcolor="#FFFFFF">91,056 ns</td><td align="right" bgcolor="#FFFFFF">92,755 ns</td><td align="right" bgcolor="#FFFFFF">94,248 ns</td><td align="right" bgcolor="#FFFFFF">96,708 ns</td><td align="right" bgcolor="#FFFFFF">96,392 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetName_Long"></a>GetName_Long

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 9,051 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">108,461 ns</td><td align="right" bgcolor="#FFFFFF">103,700 ns</td><td align="right" bgcolor="#FFFFFF">101,133 ns</td><td align="right" bgcolor="#FFFFFF">109,205 ns</td><td align="right" bgcolor="#FFFFFF">108,943 ns</td><td align="right" bgcolor="#FFFFFF">100,155 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetNames"></a>GetNames

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 216,080 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1367,080 ns</td><td align="right" bgcolor="#FFFFFF">1334,445 ns</td><td align="right" bgcolor="#FFFFFF">1352,984 ns</td><td align="right" bgcolor="#FFFFFF">1476,175 ns</td><td align="right" bgcolor="#FFFFFF">1288,408 ns</td><td align="right" bgcolor="#FFFFFF">1504,488 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,367 μs</td><td align="right" bgcolor="#FFFFFF">1,334 μs</td><td align="right" bgcolor="#FFFFFF">1,353 μs</td><td align="right" bgcolor="#FFFFFF">1,476 μs</td><td align="right" bgcolor="#FFFFFF">1,288 μs</td><td align="right" bgcolor="#FFFFFF">1,504 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">918,000</td><td align="right" bgcolor="#FFFFFF">918,000</td><td align="right" bgcolor="#FFFFFF">918,000</td><td align="right" bgcolor="#FFFFFF">918,000</td><td align="right" bgcolor="#FFFFFF">918,000</td><td align="right" bgcolor="#FFFFFF">918,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,896</td><td align="right" bgcolor="#FFFFFF">0,896</td><td align="right" bgcolor="#FFFFFF">0,896</td><td align="right" bgcolor="#FFFFFF">0,896</td><td align="right" bgcolor="#FFFFFF">0,896</td><td align="right" bgcolor="#FFFFFF">0,896</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Enum_Benchmark_GetValues"></a>GetValues

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 940,476 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+35,3 %</td><td align="right" bgcolor="#A8D08D">-25,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2457,813 ns</td><td align="right" bgcolor="#FFFFFF">2422,916 ns</td><td align="right" bgcolor="#FFFFFF">2485,075 ns</td><td align="right" bgcolor="#FF4949">3363,392 ns (Δ = +878,317 ns)</td><td align="right" bgcolor="#A8D08D">2492,168 ns (Δ = -871,224 ns)</td><td align="right" bgcolor="#FFFFFF">2681,536 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,458 μs</td><td align="right" bgcolor="#FFFFFF">2,423 μs</td><td align="right" bgcolor="#FFFFFF">2,485 μs</td><td align="right" bgcolor="#FFFFFF">3,363 μs</td><td align="right" bgcolor="#FFFFFF">2,492 μs</td><td align="right" bgcolor="#FFFFFF">2,682 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td><td align="right" bgcolor="#FFFFFF">1111,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td><td align="right" bgcolor="#FFFFFF">1,085</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 16,369 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">219,525 ns</td><td align="right" bgcolor="#FFFFFF">226,009 ns</td><td align="right" bgcolor="#FFFFFF">210,915 ns</td><td align="right" bgcolor="#FFFFFF">227,284 ns</td><td align="right" bgcolor="#FFFFFF">214,315 ns</td><td align="right" bgcolor="#FFFFFF">226,797 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,220 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_ToList"></a>ToList

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 256,717 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2621,483 ns</td><td align="right" bgcolor="#FFFFFF">2578,436 ns</td><td align="right" bgcolor="#FFFFFF">2521,840 ns</td><td align="right" bgcolor="#FFFFFF">2636,679 ns</td><td align="right" bgcolor="#FFFFFF">2550,520 ns</td><td align="right" bgcolor="#FFFFFF">2778,557 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,621 μs</td><td align="right" bgcolor="#FFFFFF">2,578 μs</td><td align="right" bgcolor="#FFFFFF">2,522 μs</td><td align="right" bgcolor="#FFFFFF">2,637 μs</td><td align="right" bgcolor="#FFFFFF">2,551 μs</td><td align="right" bgcolor="#FFFFFF">2,779 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1199,000</td><td align="right" bgcolor="#FFFFFF">1199,000</td><td align="right" bgcolor="#FFFFFF">1199,000</td><td align="right" bgcolor="#FFFFFF">1199,000</td><td align="right" bgcolor="#FFFFFF">1199,000</td><td align="right" bgcolor="#FFFFFF">1199,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,171</td><td align="right" bgcolor="#FFFFFF">1,171</td><td align="right" bgcolor="#FFFFFF">1,171</td><td align="right" bgcolor="#FFFFFF">1,171</td><td align="right" bgcolor="#FFFFFF">1,171</td><td align="right" bgcolor="#FFFFFF">1,171</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Enum_Benchmark_TryParse"></a>TryParse

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 17,691 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">221,595 ns</td><td align="right" bgcolor="#FFFFFF">228,113 ns</td><td align="right" bgcolor="#FFFFFF">222,120 ns</td><td align="right" bgcolor="#FFFFFF">230,432 ns</td><td align="right" bgcolor="#FFFFFF">234,741 ns</td><td align="right" bgcolor="#FFFFFF">239,285 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,222 μs</td><td align="right" bgcolor="#FFFFFF">0,228 μs</td><td align="right" bgcolor="#FFFFFF">0,222 μs</td><td align="right" bgcolor="#FFFFFF">0,230 μs</td><td align="right" bgcolor="#FFFFFF">0,235 μs</td><td align="right" bgcolor="#FFFFFF">0,239 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase"></a>TryParse_IgnoreCase

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 23,200 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">230,192 ns</td><td align="right" bgcolor="#FFFFFF">220,749 ns</td><td align="right" bgcolor="#FFFFFF">235,709 ns</td><td align="right" bgcolor="#FFFFFF">230,837 ns</td><td align="right" bgcolor="#FFFFFF">224,828 ns</td><td align="right" bgcolor="#FFFFFF">243,949 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,230 μs</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td><td align="right" bgcolor="#FFFFFF">0,225 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase_Nullable"></a>TryParse_IgnoreCase_Nullable

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 16,483 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">229,357 ns</td><td align="right" bgcolor="#FFFFFF">224,027 ns</td><td align="right" bgcolor="#FFFFFF">218,024 ns</td><td align="right" bgcolor="#FFFFFF">234,507 ns</td><td align="right" bgcolor="#FFFFFF">223,016 ns</td><td align="right" bgcolor="#FFFFFF">233,261 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,229 μs</td><td align="right" bgcolor="#FFFFFF">0,224 μs</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,235 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 14,233 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">221,396 ns</td><td align="right" bgcolor="#FFFFFF">235,629 ns</td><td align="right" bgcolor="#FFFFFF">228,723 ns</td><td align="right" bgcolor="#FFFFFF">224,512 ns</td><td align="right" bgcolor="#FFFFFF">223,307 ns</td><td align="right" bgcolor="#FFFFFF">225,915 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,229 μs</td><td align="right" bgcolor="#FFFFFF">0,225 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ExpressionHelper_Benchmark"></a>ExpressionHelper_Benchmark

### <a name="ExpressionHelper_Benchmark_GetOwner"></a>GetOwner

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 524,039 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+49,6 %</td><td align="right" bgcolor="#A8D08D">-30,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+38,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1030,099 ns</td><td align="right" bgcolor="#FF4949">1540,965 ns (Δ = +510,867 ns)</td><td align="right" bgcolor="#A8D08D">1065,864 ns (Δ = -475,101 ns)</td><td align="right" bgcolor="#FFFFFF">1016,927 ns</td><td align="right" bgcolor="#FFFFFF">1046,835 ns</td><td align="right" bgcolor="#FF4949">1452,909 ns (Δ = +406,075 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,030 μs</td><td align="right" bgcolor="#FFFFFF">1,541 μs</td><td align="right" bgcolor="#FFFFFF">1,066 μs</td><td align="right" bgcolor="#FFFFFF">1,017 μs</td><td align="right" bgcolor="#FFFFFF">1,047 μs</td><td align="right" bgcolor="#FFFFFF">1,453 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">652,000</td><td align="right" bgcolor="#FFFFFF">652,000</td><td align="right" bgcolor="#FFFFFF">652,000</td><td align="right" bgcolor="#FFFFFF">652,000</td><td align="right" bgcolor="#FFFFFF">652,000</td><td align="right" bgcolor="#FFFFFF">652,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,637</td><td align="right" bgcolor="#FFFFFF">0,637</td><td align="right" bgcolor="#FFFFFF">0,637</td><td align="right" bgcolor="#FFFFFF">0,637</td><td align="right" bgcolor="#FFFFFF">0,637</td><td align="right" bgcolor="#FFFFFF">0,637</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ExpressionHelper_Benchmark_GetPropertyName"></a>GetPropertyName

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 1654,899 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,5 %</td><td align="right" bgcolor="#A8D08D">-29,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+82,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2364,459 ns</td><td align="right" bgcolor="#FF4949">2849,517 ns (Δ = +485,059 ns)</td><td align="right" bgcolor="#A8D08D">1999,765 ns (Δ = -849,752 ns)</td><td align="right" bgcolor="#FFFFFF">2085,941 ns</td><td align="right" bgcolor="#FFFFFF">2002,389 ns</td><td align="right" bgcolor="#FF4949">3654,664 ns (Δ = +1652,275 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,364 μs</td><td align="right" bgcolor="#FFFFFF">2,850 μs</td><td align="right" bgcolor="#FFFFFF">2,000 μs</td><td align="right" bgcolor="#FFFFFF">2,086 μs</td><td align="right" bgcolor="#FFFFFF">2,002 μs</td><td align="right" bgcolor="#FFFFFF">3,655 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td><td align="right" bgcolor="#FFFFFF">1992,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td><td align="right" bgcolor="#FFFFFF">1,945</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td></tr></table>


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 6,659 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">66,387 ns</td><td align="right" bgcolor="#FFFFFF">65,779 ns</td><td align="right" bgcolor="#FFFFFF">70,037 ns</td><td align="right" bgcolor="#FFFFFF">63,379 ns</td><td align="right" bgcolor="#FFFFFF">67,328 ns</td><td align="right" bgcolor="#FFFFFF">64,707 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 10,275 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">62,288 ns</td><td align="right" bgcolor="#FFFFFF">62,555 ns</td><td align="right" bgcolor="#FFFFFF">72,563 ns</td><td align="right" bgcolor="#FFFFFF">65,763 ns</td><td align="right" bgcolor="#FFFFFF">63,499 ns</td><td align="right" bgcolor="#FFFFFF">64,795 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="HashHelper_Benchmark"></a>HashHelper_Benchmark

### <a name="HashHelper_Benchmark_HashHelper"></a>HashHelper

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 8,973 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,413 ns</td><td align="right" bgcolor="#FFFFFF">15,981 ns</td><td align="right" bgcolor="#FFFFFF">15,453 ns</td><td align="right" bgcolor="#FFFFFF">13,872 ns</td><td align="right" bgcolor="#FFFFFF">16,264 ns</td><td align="right" bgcolor="#FFFFFF">22,845 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="LanguageHelper_Benchmark"></a>LanguageHelper_Benchmark

### <a name="LanguageHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 2434,149 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+773,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">343,381 ns</td><td align="right" bgcolor="#FFFFFF">337,603 ns</td><td align="right" bgcolor="#FFFFFF">349,459 ns</td><td align="right" bgcolor="#FFFFFF">321,357 ns</td><td align="right" bgcolor="#FFFFFF">314,593 ns</td><td align="right" bgcolor="#FF4949">2748,743 ns (Δ = +2434,149 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,343 μs</td><td align="right" bgcolor="#FFFFFF">0,338 μs</td><td align="right" bgcolor="#FFFFFF">0,349 μs</td><td align="right" bgcolor="#FFFFFF">0,321 μs</td><td align="right" bgcolor="#FFFFFF">0,315 μs</td><td align="right" bgcolor="#FFFFFF">2,749 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +2,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+600,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">259,000</td><td align="right" bgcolor="#FFFFFF">259,000</td><td align="right" bgcolor="#FFFFFF">259,000</td><td align="right" bgcolor="#FFFFFF">259,000</td><td align="right" bgcolor="#FFFFFF">259,000</td><td align="right" bgcolor="#FF4949">1815,000 (Δ = +1556,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,253</td><td align="right" bgcolor="#FFFFFF">0,253</td><td align="right" bgcolor="#FFFFFF">0,253</td><td align="right" bgcolor="#FFFFFF">0,253</td><td align="right" bgcolor="#FFFFFF">0,253</td><td align="right" bgcolor="#FF4949">1,772 (Δ = +1,520)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,001)</td></tr></table>


## <a name="Log_Debug_Benchmark"></a>Log_Debug_Benchmark

### <a name="Log_Debug_Benchmark_Log_Debug_Format_1_Format_Argument"></a>Log_Debug_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 174,251 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">439,560 ns</td><td align="right" bgcolor="#FFFFFF">460,557 ns</td><td align="right" bgcolor="#FFFFFF">470,144 ns</td><td align="right" bgcolor="#FFFFFF">613,811 ns</td><td align="right" bgcolor="#FFFFFF">464,128 ns</td><td align="right" bgcolor="#FFFFFF">515,696 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,440 μs</td><td align="right" bgcolor="#FFFFFF">0,461 μs</td><td align="right" bgcolor="#FFFFFF">0,470 μs</td><td align="right" bgcolor="#FFFFFF">0,614 μs</td><td align="right" bgcolor="#FFFFFF">0,464 μs</td><td align="right" bgcolor="#FFFFFF">0,516 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_2_Format_Arguments"></a>Log_Debug_Format_2_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 210,719 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">519,915 ns</td><td align="right" bgcolor="#FFFFFF">525,867 ns</td><td align="right" bgcolor="#FFFFFF">516,684 ns</td><td align="right" bgcolor="#FFFFFF">727,403 ns</td><td align="right" bgcolor="#FFFFFF">521,976 ns</td><td align="right" bgcolor="#FFFFFF">558,264 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,520 μs</td><td align="right" bgcolor="#FFFFFF">0,526 μs</td><td align="right" bgcolor="#FFFFFF">0,517 μs</td><td align="right" bgcolor="#FFFFFF">0,727 μs</td><td align="right" bgcolor="#FFFFFF">0,522 μs</td><td align="right" bgcolor="#FFFFFF">0,558 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments"></a>Log_Debug_Format_3_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 260,179 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+42,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">626,699 ns</td><td align="right" bgcolor="#FFFFFF">668,072 ns</td><td align="right" bgcolor="#FFFFFF">614,605 ns</td><td align="right" bgcolor="#FF4949">874,784 ns (Δ = +260,179 ns)</td><td align="right" bgcolor="#FFFFFF">625,867 ns</td><td align="right" bgcolor="#FFFFFF">682,448 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,627 μs</td><td align="right" bgcolor="#FFFFFF">0,668 μs</td><td align="right" bgcolor="#FFFFFF">0,615 μs</td><td align="right" bgcolor="#FFFFFF">0,875 μs</td><td align="right" bgcolor="#FFFFFF">0,626 μs</td><td align="right" bgcolor="#FFFFFF">0,682 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_4_Format_Arguments"></a>Log_Debug_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 335,403 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+40,9 %</td><td align="right" bgcolor="#A8D08D">-30,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">754,104 ns</td><td align="right" bgcolor="#FFFFFF">763,268 ns</td><td align="right" bgcolor="#FFFFFF">773,291 ns</td><td align="right" bgcolor="#FF4949">1089,507 ns (Δ = +316,216 ns)</td><td align="right" bgcolor="#A8D08D">759,995 ns (Δ = -329,512 ns)</td><td align="right" bgcolor="#FFFFFF">809,843 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,754 μs</td><td align="right" bgcolor="#FFFFFF">0,763 μs</td><td align="right" bgcolor="#FFFFFF">0,773 μs</td><td align="right" bgcolor="#FFFFFF">1,090 μs</td><td align="right" bgcolor="#FFFFFF">0,760 μs</td><td align="right" bgcolor="#FFFFFF">0,810 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_5_Format_Arguments"></a>Log_Debug_Format_5_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 75,480 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">881,720 ns</td><td align="right" bgcolor="#FFFFFF">854,904 ns</td><td align="right" bgcolor="#FFFFFF">883,200 ns</td><td align="right" bgcolor="#FFFFFF">930,384 ns</td><td align="right" bgcolor="#FFFFFF">862,059 ns</td><td align="right" bgcolor="#FFFFFF">911,171 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,882 μs</td><td align="right" bgcolor="#FFFFFF">0,855 μs</td><td align="right" bgcolor="#FFFFFF">0,883 μs</td><td align="right" bgcolor="#FFFFFF">0,930 μs</td><td align="right" bgcolor="#FFFFFF">0,862 μs</td><td align="right" bgcolor="#FFFFFF">0,911 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments"></a>Log_Debug_Format_6_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 132,019 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1005,545 ns</td><td align="right" bgcolor="#FFFFFF">1008,952 ns</td><td align="right" bgcolor="#FFFFFF">1137,564 ns</td><td align="right" bgcolor="#FFFFFF">1019,547 ns</td><td align="right" bgcolor="#FFFFFF">1008,016 ns</td><td align="right" bgcolor="#FFFFFF">1072,195 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,006 μs</td><td align="right" bgcolor="#FFFFFF">1,009 μs</td><td align="right" bgcolor="#FFFFFF">1,138 μs</td><td align="right" bgcolor="#FFFFFF">1,020 μs</td><td align="right" bgcolor="#FFFFFF">1,008 μs</td><td align="right" bgcolor="#FFFFFF">1,072 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_7_Format_Arguments"></a>Log_Debug_Format_7_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 83,072 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1152,085 ns</td><td align="right" bgcolor="#FFFFFF">1149,365 ns</td><td align="right" bgcolor="#FFFFFF">1112,661 ns</td><td align="right" bgcolor="#FFFFFF">1162,437 ns</td><td align="right" bgcolor="#FFFFFF">1121,383 ns</td><td align="right" bgcolor="#FFFFFF">1195,733 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,152 μs</td><td align="right" bgcolor="#FFFFFF">1,149 μs</td><td align="right" bgcolor="#FFFFFF">1,113 μs</td><td align="right" bgcolor="#FFFFFF">1,162 μs</td><td align="right" bgcolor="#FFFFFF">1,121 μs</td><td align="right" bgcolor="#FFFFFF">1,196 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 3,696 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,861 ns</td><td align="right" bgcolor="#FFFFFF">0,684 ns</td><td align="right" bgcolor="#FFFFFF">1,080 ns</td><td align="right" bgcolor="#FFFFFF">0,171 ns</td><td align="right" bgcolor="#FFFFFF">0,165 ns</td><td align="right" bgcolor="#FFFFFF">1,263 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 4,288 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,533 ns</td><td align="right" bgcolor="#FFFFFF">11,005 ns</td><td align="right" bgcolor="#FFFFFF">10,245 ns</td><td align="right" bgcolor="#FFFFFF">11,845 ns</td><td align="right" bgcolor="#FFFFFF">10,677 ns</td><td align="right" bgcolor="#FFFFFF">11,789 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">59,000</td><td align="right" bgcolor="#FFFFFF">59,000</td><td align="right" bgcolor="#FFFFFF">59,000</td><td align="right" bgcolor="#FFFFFF">59,000</td><td align="right" bgcolor="#FFFFFF">59,000</td><td align="right" bgcolor="#FFFFFF">59,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,058</td><td align="right" bgcolor="#FFFFFF">0,058</td><td align="right" bgcolor="#FFFFFF">0,058</td><td align="right" bgcolor="#FFFFFF">0,058</td><td align="right" bgcolor="#FFFFFF">0,058</td><td align="right" bgcolor="#FFFFFF">0,058</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 4,375 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,761 ns</td><td align="right" bgcolor="#FFFFFF">8,680 ns</td><td align="right" bgcolor="#FFFFFF">7,571 ns</td><td align="right" bgcolor="#FFFFFF">7,772 ns</td><td align="right" bgcolor="#FFFFFF">7,387 ns</td><td align="right" bgcolor="#FFFFFF">7,960 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 25,589 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">211,333 ns</td><td align="right" bgcolor="#FFFFFF">216,885 ns</td><td align="right" bgcolor="#FFFFFF">208,773 ns</td><td align="right" bgcolor="#FFFFFF">217,832 ns</td><td align="right" bgcolor="#FFFFFF">214,336 ns</td><td align="right" bgcolor="#FFFFFF">234,363 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,217 μs</td><td align="right" bgcolor="#FFFFFF">0,209 μs</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#FFFFFF">161,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#FFFFFF">0,157</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 139,869 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">579,131 ns</td><td align="right" bgcolor="#FFFFFF">472,107 ns</td><td align="right" bgcolor="#FFFFFF">488,755 ns</td><td align="right" bgcolor="#FFFFFF">477,568 ns</td><td align="right" bgcolor="#FFFFFF">439,261 ns</td><td align="right" bgcolor="#FFFFFF">474,203 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,579 μs</td><td align="right" bgcolor="#FFFFFF">0,472 μs</td><td align="right" bgcolor="#FFFFFF">0,489 μs</td><td align="right" bgcolor="#FFFFFF">0,478 μs</td><td align="right" bgcolor="#FFFFFF">0,439 μs</td><td align="right" bgcolor="#FFFFFF">0,474 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">354,000</td><td align="right" bgcolor="#FFFFFF">354,000</td><td align="right" bgcolor="#FFFFFF">354,000</td><td align="right" bgcolor="#FFFFFF">354,000</td><td align="right" bgcolor="#FFFFFF">354,000</td><td align="right" bgcolor="#FFFFFF">354,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,346</td><td align="right" bgcolor="#FFFFFF">0,346</td><td align="right" bgcolor="#FFFFFF">0,346</td><td align="right" bgcolor="#FFFFFF">0,346</td><td align="right" bgcolor="#FFFFFF">0,346</td><td align="right" bgcolor="#FFFFFF">0,346</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 85,135 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">378,536 ns</td><td align="right" bgcolor="#FFFFFF">378,947 ns</td><td align="right" bgcolor="#FFFFFF">378,073 ns</td><td align="right" bgcolor="#FFFFFF">403,949 ns</td><td align="right" bgcolor="#FFFFFF">463,208 ns</td><td align="right" bgcolor="#FFFFFF">397,027 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,379 μs</td><td align="right" bgcolor="#FFFFFF">0,379 μs</td><td align="right" bgcolor="#FFFFFF">0,378 μs</td><td align="right" bgcolor="#FFFFFF">0,404 μs</td><td align="right" bgcolor="#FFFFFF">0,463 μs</td><td align="right" bgcolor="#FFFFFF">0,397 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Error_Benchmark"></a>Log_Error_Benchmark

### <a name="Log_Error_Benchmark_Log_Error_Format_1_Format_Argument"></a>Log_Error_Format_1_Format_Argument

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 193,803 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">617,220 ns</td><td align="right" bgcolor="#FFFFFF">441,975 ns</td><td align="right" bgcolor="#FFFFFF">429,416 ns</td><td align="right" bgcolor="#FFFFFF">477,219 ns</td><td align="right" bgcolor="#FFFFFF">423,417 ns</td><td align="right" bgcolor="#FFFFFF">435,235 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,617 μs</td><td align="right" bgcolor="#FFFFFF">0,442 μs</td><td align="right" bgcolor="#FFFFFF">0,429 μs</td><td align="right" bgcolor="#FFFFFF">0,477 μs</td><td align="right" bgcolor="#FFFFFF">0,423 μs</td><td align="right" bgcolor="#FFFFFF">0,435 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_2_Format_Arguments"></a>Log_Error_Format_2_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 189,471 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">708,196 ns</td><td align="right" bgcolor="#FFFFFF">524,472 ns</td><td align="right" bgcolor="#FFFFFF">518,725 ns</td><td align="right" bgcolor="#FFFFFF">544,845 ns</td><td align="right" bgcolor="#FFFFFF">521,269 ns</td><td align="right" bgcolor="#FFFFFF">546,549 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,708 μs</td><td align="right" bgcolor="#FFFFFF">0,524 μs</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td><td align="right" bgcolor="#FFFFFF">0,545 μs</td><td align="right" bgcolor="#FFFFFF">0,521 μs</td><td align="right" bgcolor="#FFFFFF">0,547 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_3_Format_Arguments"></a>Log_Error_Format_3_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 227,749 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">854,379 ns</td><td align="right" bgcolor="#FFFFFF">636,445 ns</td><td align="right" bgcolor="#FFFFFF">654,269 ns</td><td align="right" bgcolor="#FFFFFF">644,712 ns</td><td align="right" bgcolor="#FFFFFF">626,629 ns</td><td align="right" bgcolor="#FFFFFF">672,467 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,854 μs</td><td align="right" bgcolor="#FFFFFF">0,636 μs</td><td align="right" bgcolor="#FFFFFF">0,654 μs</td><td align="right" bgcolor="#FFFFFF">0,645 μs</td><td align="right" bgcolor="#FFFFFF">0,627 μs</td><td align="right" bgcolor="#FFFFFF">0,672 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_4_Format_Arguments"></a>Log_Error_Format_4_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 265,971 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1023,035 ns</td><td align="right" bgcolor="#FFFFFF">785,475 ns</td><td align="right" bgcolor="#FFFFFF">765,060 ns</td><td align="right" bgcolor="#FFFFFF">789,203 ns</td><td align="right" bgcolor="#FFFFFF">757,064 ns</td><td align="right" bgcolor="#FFFFFF">813,581 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,023 μs</td><td align="right" bgcolor="#FFFFFF">0,785 μs</td><td align="right" bgcolor="#FFFFFF">0,765 μs</td><td align="right" bgcolor="#FFFFFF">0,789 μs</td><td align="right" bgcolor="#FFFFFF">0,757 μs</td><td align="right" bgcolor="#FFFFFF">0,814 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_5_Format_Arguments"></a>Log_Error_Format_5_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 274,123 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1123,427 ns</td><td align="right" bgcolor="#A8D08D">869,784 ns (Δ = -253,643 ns)</td><td align="right" bgcolor="#FFFFFF">849,304 ns</td><td align="right" bgcolor="#FFFFFF">874,821 ns</td><td align="right" bgcolor="#FFFFFF">889,071 ns</td><td align="right" bgcolor="#FFFFFF">938,443 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,123 μs</td><td align="right" bgcolor="#FFFFFF">0,870 μs</td><td align="right" bgcolor="#FFFFFF">0,849 μs</td><td align="right" bgcolor="#FFFFFF">0,875 μs</td><td align="right" bgcolor="#FFFFFF">0,889 μs</td><td align="right" bgcolor="#FFFFFF">0,938 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_6_Format_Arguments"></a>Log_Error_Format_6_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 104,541 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1044,365 ns</td><td align="right" bgcolor="#FFFFFF">1034,056 ns</td><td align="right" bgcolor="#FFFFFF">1018,403 ns</td><td align="right" bgcolor="#FFFFFF">1035,029 ns</td><td align="right" bgcolor="#FFFFFF">984,672 ns</td><td align="right" bgcolor="#FFFFFF">1089,213 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,044 μs</td><td align="right" bgcolor="#FFFFFF">1,034 μs</td><td align="right" bgcolor="#FFFFFF">1,018 μs</td><td align="right" bgcolor="#FFFFFF">1,035 μs</td><td align="right" bgcolor="#FFFFFF">0,985 μs</td><td align="right" bgcolor="#FFFFFF">1,089 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_7_Format_Arguments"></a>Log_Error_Format_7_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 68,189 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1146,643 ns</td><td align="right" bgcolor="#FFFFFF">1184,009 ns</td><td align="right" bgcolor="#FFFFFF">1142,919 ns</td><td align="right" bgcolor="#FFFFFF">1210,933 ns</td><td align="right" bgcolor="#FFFFFF">1142,744 ns</td><td align="right" bgcolor="#FFFFFF">1208,411 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,147 μs</td><td align="right" bgcolor="#FFFFFF">1,184 μs</td><td align="right" bgcolor="#FFFFFF">1,143 μs</td><td align="right" bgcolor="#FFFFFF">1,211 μs</td><td align="right" bgcolor="#FFFFFF">1,143 μs</td><td align="right" bgcolor="#FFFFFF">1,208 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Info_Benchmark"></a>Log_Info_Benchmark

### <a name="Log_Info_Benchmark_Log_Info_Format_1_Format_Argument"></a>Log_Info_Format_1_Format_Argument

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 74,317 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">453,056 ns</td><td align="right" bgcolor="#FFFFFF">438,131 ns</td><td align="right" bgcolor="#FFFFFF">453,496 ns</td><td align="right" bgcolor="#FFFFFF">512,448 ns</td><td align="right" bgcolor="#FFFFFF">458,704 ns</td><td align="right" bgcolor="#FFFFFF">485,288 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,453 μs</td><td align="right" bgcolor="#FFFFFF">0,438 μs</td><td align="right" bgcolor="#FFFFFF">0,453 μs</td><td align="right" bgcolor="#FFFFFF">0,512 μs</td><td align="right" bgcolor="#FFFFFF">0,459 μs</td><td align="right" bgcolor="#FFFFFF">0,485 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_2_Format_Arguments"></a>Log_Info_Format_2_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 54,563 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">581,347 ns</td><td align="right" bgcolor="#FFFFFF">526,784 ns</td><td align="right" bgcolor="#FFFFFF">561,813 ns</td><td align="right" bgcolor="#FFFFFF">563,672 ns</td><td align="right" bgcolor="#FFFFFF">557,669 ns</td><td align="right" bgcolor="#FFFFFF">579,675 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,581 μs</td><td align="right" bgcolor="#FFFFFF">0,527 μs</td><td align="right" bgcolor="#FFFFFF">0,562 μs</td><td align="right" bgcolor="#FFFFFF">0,564 μs</td><td align="right" bgcolor="#FFFFFF">0,558 μs</td><td align="right" bgcolor="#FFFFFF">0,580 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">419,000</td><td align="right" bgcolor="#FFFFFF">419,000</td><td align="right" bgcolor="#FFFFFF">419,000</td><td align="right" bgcolor="#FFFFFF">419,000</td><td align="right" bgcolor="#FFFFFF">419,000</td><td align="right" bgcolor="#FFFFFF">419,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,409</td><td align="right" bgcolor="#FFFFFF">0,409</td><td align="right" bgcolor="#FFFFFF">0,409</td><td align="right" bgcolor="#FFFFFF">0,409</td><td align="right" bgcolor="#FFFFFF">0,409</td><td align="right" bgcolor="#FFFFFF">0,409</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_3_Format_Arguments"></a>Log_Info_Format_3_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 65,627 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">663,328 ns</td><td align="right" bgcolor="#FFFFFF">664,280 ns</td><td align="right" bgcolor="#FFFFFF">643,341 ns</td><td align="right" bgcolor="#FFFFFF">674,548 ns</td><td align="right" bgcolor="#FFFFFF">664,163 ns</td><td align="right" bgcolor="#FFFFFF">708,968 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,663 μs</td><td align="right" bgcolor="#FFFFFF">0,664 μs</td><td align="right" bgcolor="#FFFFFF">0,643 μs</td><td align="right" bgcolor="#FFFFFF">0,675 μs</td><td align="right" bgcolor="#FFFFFF">0,664 μs</td><td align="right" bgcolor="#FFFFFF">0,709 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">498,000</td><td align="right" bgcolor="#FFFFFF">498,000</td><td align="right" bgcolor="#FFFFFF">498,000</td><td align="right" bgcolor="#FFFFFF">498,000</td><td align="right" bgcolor="#FFFFFF">498,000</td><td align="right" bgcolor="#FFFFFF">498,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,486</td><td align="right" bgcolor="#FFFFFF">0,486</td><td align="right" bgcolor="#FFFFFF">0,486</td><td align="right" bgcolor="#FFFFFF">0,486</td><td align="right" bgcolor="#FFFFFF">0,486</td><td align="right" bgcolor="#FFFFFF">0,486</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_4_Format_Arguments"></a>Log_Info_Format_4_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 77,037 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">779,261 ns</td><td align="right" bgcolor="#FFFFFF">784,357 ns</td><td align="right" bgcolor="#FFFFFF">760,117 ns</td><td align="right" bgcolor="#FFFFFF">793,765 ns</td><td align="right" bgcolor="#FFFFFF">767,715 ns</td><td align="right" bgcolor="#FFFFFF">837,155 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,779 μs</td><td align="right" bgcolor="#FFFFFF">0,784 μs</td><td align="right" bgcolor="#FFFFFF">0,760 μs</td><td align="right" bgcolor="#FFFFFF">0,794 μs</td><td align="right" bgcolor="#FFFFFF">0,768 μs</td><td align="right" bgcolor="#FFFFFF">0,837 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_5_Format_Arguments"></a>Log_Info_Format_5_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 87,880 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">856,819 ns</td><td align="right" bgcolor="#FFFFFF">920,112 ns</td><td align="right" bgcolor="#FFFFFF">852,669 ns</td><td align="right" bgcolor="#FFFFFF">887,960 ns</td><td align="right" bgcolor="#FFFFFF">836,131 ns</td><td align="right" bgcolor="#FFFFFF">924,011 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,857 μs</td><td align="right" bgcolor="#FFFFFF">0,920 μs</td><td align="right" bgcolor="#FFFFFF">0,853 μs</td><td align="right" bgcolor="#FFFFFF">0,888 μs</td><td align="right" bgcolor="#FFFFFF">0,836 μs</td><td align="right" bgcolor="#FFFFFF">0,924 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_6_Format_Arguments"></a>Log_Info_Format_6_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 48,893 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">943,968 ns</td><td align="right" bgcolor="#FFFFFF">977,709 ns</td><td align="right" bgcolor="#FFFFFF">929,552 ns</td><td align="right" bgcolor="#FFFFFF">947,909 ns</td><td align="right" bgcolor="#FFFFFF">950,179 ns</td><td align="right" bgcolor="#FFFFFF">978,445 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,944 μs</td><td align="right" bgcolor="#FFFFFF">0,978 μs</td><td align="right" bgcolor="#FFFFFF">0,930 μs</td><td align="right" bgcolor="#FFFFFF">0,948 μs</td><td align="right" bgcolor="#FFFFFF">0,950 μs</td><td align="right" bgcolor="#FFFFFF">0,978 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">741,000</td><td align="right" bgcolor="#FFFFFF">741,000</td><td align="right" bgcolor="#FFFFFF">741,000</td><td align="right" bgcolor="#FFFFFF">741,000</td><td align="right" bgcolor="#FFFFFF">741,000</td><td align="right" bgcolor="#FFFFFF">741,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,724</td><td align="right" bgcolor="#FFFFFF">0,724</td><td align="right" bgcolor="#FFFFFF">0,724</td><td align="right" bgcolor="#FFFFFF">0,724</td><td align="right" bgcolor="#FFFFFF">0,724</td><td align="right" bgcolor="#FFFFFF">0,724</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments"></a>Log_Info_Format_7_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 432,356 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+35,5 %</td><td align="right" bgcolor="#A8D08D">-24,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1032,501 ns</td><td align="right" bgcolor="#FFFFFF">1050,661 ns</td><td align="right" bgcolor="#FFFFFF">1029,769 ns</td><td align="right" bgcolor="#FFFFFF">1079,032 ns</td><td align="right" bgcolor="#FF4949">1462,125 ns (Δ = +383,093 ns)</td><td align="right" bgcolor="#A8D08D">1101,987 ns (Δ = -360,139 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,033 μs</td><td align="right" bgcolor="#FFFFFF">1,051 μs</td><td align="right" bgcolor="#FFFFFF">1,030 μs</td><td align="right" bgcolor="#FFFFFF">1,079 μs</td><td align="right" bgcolor="#FFFFFF">1,462 μs</td><td align="right" bgcolor="#FFFFFF">1,102 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Status_Benchmark"></a>Log_Status_Benchmark

### <a name="Log_Status_Benchmark_Log_Status_Format_1_Format_Argument"></a>Log_Status_Format_1_Format_Argument

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 118,120 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">447,069 ns</td><td align="right" bgcolor="#FFFFFF">447,549 ns</td><td align="right" bgcolor="#FFFFFF">441,032 ns</td><td align="right" bgcolor="#FFFFFF">463,659 ns</td><td align="right" bgcolor="#FFFFFF">559,152 ns</td><td align="right" bgcolor="#FFFFFF">476,467 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,447 μs</td><td align="right" bgcolor="#FFFFFF">0,448 μs</td><td align="right" bgcolor="#FFFFFF">0,441 μs</td><td align="right" bgcolor="#FFFFFF">0,464 μs</td><td align="right" bgcolor="#FFFFFF">0,559 μs</td><td align="right" bgcolor="#FFFFFF">0,476 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_2_Format_Arguments"></a>Log_Status_Format_2_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 233,144 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">532,549 ns</td><td align="right" bgcolor="#FFFFFF">518,337 ns</td><td align="right" bgcolor="#FFFFFF">516,832 ns</td><td align="right" bgcolor="#FFFFFF">530,048 ns</td><td align="right" bgcolor="#FFFFFF">749,976 ns</td><td align="right" bgcolor="#FFFFFF">564,333 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,533 μs</td><td align="right" bgcolor="#FFFFFF">0,518 μs</td><td align="right" bgcolor="#FFFFFF">0,517 μs</td><td align="right" bgcolor="#FFFFFF">0,530 μs</td><td align="right" bgcolor="#FFFFFF">0,750 μs</td><td align="right" bgcolor="#FFFFFF">0,564 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_3_Format_Arguments"></a>Log_Status_Format_3_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 215,152 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">630,600 ns</td><td align="right" bgcolor="#FFFFFF">624,187 ns</td><td align="right" bgcolor="#FFFFFF">618,347 ns</td><td align="right" bgcolor="#FFFFFF">645,797 ns</td><td align="right" bgcolor="#FFFFFF">833,499 ns</td><td align="right" bgcolor="#FFFFFF">651,461 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,631 μs</td><td align="right" bgcolor="#FFFFFF">0,624 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,646 μs</td><td align="right" bgcolor="#FFFFFF">0,833 μs</td><td align="right" bgcolor="#FFFFFF">0,651 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments"></a>Log_Status_Format_4_Format_Arguments

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 399,707 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+47,3 %</td><td align="right" bgcolor="#A8D08D">-30,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">792,613 ns</td><td align="right" bgcolor="#FFFFFF">782,560 ns</td><td align="right" bgcolor="#FFFFFF">750,504 ns</td><td align="right" bgcolor="#FFFFFF">781,043 ns</td><td align="right" bgcolor="#FF4949">1150,211 ns (Δ = +369,168 ns)</td><td align="right" bgcolor="#A8D08D">805,513 ns (Δ = -344,697 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,793 μs</td><td align="right" bgcolor="#FFFFFF">0,783 μs</td><td align="right" bgcolor="#FFFFFF">0,751 μs</td><td align="right" bgcolor="#FFFFFF">0,781 μs</td><td align="right" bgcolor="#FFFFFF">1,150 μs</td><td align="right" bgcolor="#FFFFFF">0,806 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_5_Format_Arguments"></a>Log_Status_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 90,215 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">845,928 ns</td><td align="right" bgcolor="#FFFFFF">882,400 ns</td><td align="right" bgcolor="#FFFFFF">847,875 ns</td><td align="right" bgcolor="#FFFFFF">881,369 ns</td><td align="right" bgcolor="#FFFFFF">936,143 ns</td><td align="right" bgcolor="#FFFFFF">929,928 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,846 μs</td><td align="right" bgcolor="#FFFFFF">0,882 μs</td><td align="right" bgcolor="#FFFFFF">0,848 μs</td><td align="right" bgcolor="#FFFFFF">0,881 μs</td><td align="right" bgcolor="#FFFFFF">0,936 μs</td><td align="right" bgcolor="#FFFFFF">0,930 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_6_Format_Arguments"></a>Log_Status_Format_6_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 114,411 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1027,085 ns</td><td align="right" bgcolor="#FFFFFF">996,472 ns</td><td align="right" bgcolor="#FFFFFF">1005,665 ns</td><td align="right" bgcolor="#FFFFFF">1039,061 ns</td><td align="right" bgcolor="#FFFFFF">1011,347 ns</td><td align="right" bgcolor="#FFFFFF">1110,883 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,027 μs</td><td align="right" bgcolor="#FFFFFF">0,996 μs</td><td align="right" bgcolor="#FFFFFF">1,006 μs</td><td align="right" bgcolor="#FFFFFF">1,039 μs</td><td align="right" bgcolor="#FFFFFF">1,011 μs</td><td align="right" bgcolor="#FFFFFF">1,111 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_7_Format_Arguments"></a>Log_Status_Format_7_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 519,416 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+43,5 %</td><td align="right" bgcolor="#A8D08D">-31,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1155,288 ns</td><td align="right" bgcolor="#FFFFFF">1157,584 ns</td><td align="right" bgcolor="#FFFFFF">1143,829 ns</td><td align="right" bgcolor="#FF4949">1641,100 ns (Δ = +497,271 ns)</td><td align="right" bgcolor="#A8D08D">1121,684 ns (Δ = -519,416 ns)</td><td align="right" bgcolor="#FFFFFF">1207,704 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,155 μs</td><td align="right" bgcolor="#FFFFFF">1,158 μs</td><td align="right" bgcolor="#FFFFFF">1,144 μs</td><td align="right" bgcolor="#FFFFFF">1,641 μs</td><td align="right" bgcolor="#FFFFFF">1,122 μs</td><td align="right" bgcolor="#FFFFFF">1,208 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Warning_Benchmark"></a>Log_Warning_Benchmark

### <a name="Log_Warning_Benchmark_Log_Warning_Format_1_Format_Argument"></a>Log_Warning_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 109,387 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">425,717 ns</td><td align="right" bgcolor="#FFFFFF">436,200 ns</td><td align="right" bgcolor="#FFFFFF">431,896 ns</td><td align="right" bgcolor="#FFFFFF">535,104 ns</td><td align="right" bgcolor="#FFFFFF">439,152 ns</td><td align="right" bgcolor="#FFFFFF">458,936 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,426 μs</td><td align="right" bgcolor="#FFFFFF">0,436 μs</td><td align="right" bgcolor="#FFFFFF">0,432 μs</td><td align="right" bgcolor="#FFFFFF">0,535 μs</td><td align="right" bgcolor="#FFFFFF">0,439 μs</td><td align="right" bgcolor="#FFFFFF">0,459 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td><td align="right" bgcolor="#FFFFFF">308,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td><td align="right" bgcolor="#FFFFFF">0,301</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_2_Format_Arguments"></a>Log_Warning_Format_2_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 71,875 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">535,155 ns</td><td align="right" bgcolor="#FFFFFF">546,648 ns</td><td align="right" bgcolor="#FFFFFF">542,381 ns</td><td align="right" bgcolor="#FFFFFF">581,309 ns</td><td align="right" bgcolor="#FFFFFF">509,435 ns</td><td align="right" bgcolor="#FFFFFF">564,885 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,535 μs</td><td align="right" bgcolor="#FFFFFF">0,547 μs</td><td align="right" bgcolor="#FFFFFF">0,542 μs</td><td align="right" bgcolor="#FFFFFF">0,581 μs</td><td align="right" bgcolor="#FFFFFF">0,509 μs</td><td align="right" bgcolor="#FFFFFF">0,565 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td><td align="right" bgcolor="#FFFFFF">380,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td><td align="right" bgcolor="#FFFFFF">0,371</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_3_Format_Arguments"></a>Log_Warning_Format_3_Format_Arguments

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 216,667 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">629,621 ns</td><td align="right" bgcolor="#FFFFFF">626,821 ns</td><td align="right" bgcolor="#FFFFFF">827,280 ns</td><td align="right" bgcolor="#FFFFFF">643,560 ns</td><td align="right" bgcolor="#FFFFFF">610,613 ns</td><td align="right" bgcolor="#FFFFFF">662,411 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,630 μs</td><td align="right" bgcolor="#FFFFFF">0,627 μs</td><td align="right" bgcolor="#FFFFFF">0,827 μs</td><td align="right" bgcolor="#FFFFFF">0,644 μs</td><td align="right" bgcolor="#FFFFFF">0,611 μs</td><td align="right" bgcolor="#FFFFFF">0,662 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td><td align="right" bgcolor="#FFFFFF">452,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td><td align="right" bgcolor="#FFFFFF">0,441</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_4_Format_Arguments"></a>Log_Warning_Format_4_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 311,681 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+40,8 %</td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">795,853 ns</td><td align="right" bgcolor="#FFFFFF">764,564 ns</td><td align="right" bgcolor="#FF4949">1076,245 ns (Δ = +311,681 ns)</td><td align="right" bgcolor="#A8D08D">811,301 ns (Δ = -264,944 ns)</td><td align="right" bgcolor="#FFFFFF">769,608 ns</td><td align="right" bgcolor="#FFFFFF">814,440 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,796 μs</td><td align="right" bgcolor="#FFFFFF">0,765 μs</td><td align="right" bgcolor="#FFFFFF">1,076 μs</td><td align="right" bgcolor="#FFFFFF">0,811 μs</td><td align="right" bgcolor="#FFFFFF">0,770 μs</td><td align="right" bgcolor="#FFFFFF">0,814 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td><td align="right" bgcolor="#FFFFFF">580,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td><td align="right" bgcolor="#FFFFFF">0,566</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_5_Format_Arguments"></a>Log_Warning_Format_5_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 375,015 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+44,2 %</td><td align="right" bgcolor="#A8D08D">-28,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">855,461 ns</td><td align="right" bgcolor="#FFFFFF">849,139 ns</td><td align="right" bgcolor="#FF4949">1224,153 ns (Δ = +375,015 ns)</td><td align="right" bgcolor="#A8D08D">874,248 ns (Δ = -349,905 ns)</td><td align="right" bgcolor="#FFFFFF">935,661 ns</td><td align="right" bgcolor="#FFFFFF">1003,477 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,855 μs</td><td align="right" bgcolor="#FFFFFF">0,849 μs</td><td align="right" bgcolor="#FFFFFF">1,224 μs</td><td align="right" bgcolor="#FFFFFF">0,874 μs</td><td align="right" bgcolor="#FFFFFF">0,936 μs</td><td align="right" bgcolor="#FFFFFF">1,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_6_Format_Arguments"></a>Log_Warning_Format_6_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 251,336 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+24,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1030,467 ns</td><td align="right" bgcolor="#FFFFFF">1012,811 ns</td><td align="right" bgcolor="#FF4949">1264,147 ns (Δ = +251,336 ns)</td><td align="right" bgcolor="#FFFFFF">1059,648 ns</td><td align="right" bgcolor="#FFFFFF">1030,763 ns</td><td align="right" bgcolor="#FFFFFF">1158,931 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,030 μs</td><td align="right" bgcolor="#FFFFFF">1,013 μs</td><td align="right" bgcolor="#FFFFFF">1,264 μs</td><td align="right" bgcolor="#FFFFFF">1,060 μs</td><td align="right" bgcolor="#FFFFFF">1,031 μs</td><td align="right" bgcolor="#FFFFFF">1,159 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments"></a>Log_Warning_Format_7_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 315,661 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,5 %</td><td align="right" bgcolor="#A8D08D">-19,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1153,088 ns</td><td align="right" bgcolor="#FFFFFF">1146,608 ns</td><td align="right" bgcolor="#FF4949">1462,269 ns (Δ = +315,661 ns)</td><td align="right" bgcolor="#A8D08D">1177,720 ns (Δ = -284,549 ns)</td><td align="right" bgcolor="#FFFFFF">1172,624 ns</td><td align="right" bgcolor="#FFFFFF">1232,080 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,153 μs</td><td align="right" bgcolor="#FFFFFF">1,147 μs</td><td align="right" bgcolor="#FFFFFF">1,462 μs</td><td align="right" bgcolor="#FFFFFF">1,178 μs</td><td align="right" bgcolor="#FFFFFF">1,173 μs</td><td align="right" bgcolor="#FFFFFF">1,232 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 1221,008 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-35,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3388,357 ns</td><td align="right" bgcolor="#A8D08D">2170,483 ns (Δ = -1217,875 ns)</td><td align="right" bgcolor="#FFFFFF">2184,609 ns</td><td align="right" bgcolor="#FFFFFF">2195,175 ns</td><td align="right" bgcolor="#FFFFFF">2167,349 ns</td><td align="right" bgcolor="#FFFFFF">2212,504 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,388 μs</td><td align="right" bgcolor="#FFFFFF">2,170 μs</td><td align="right" bgcolor="#FFFFFF">2,185 μs</td><td align="right" bgcolor="#FFFFFF">2,195 μs</td><td align="right" bgcolor="#FFFFFF">2,167 μs</td><td align="right" bgcolor="#FFFFFF">2,213 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 1930,845 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-30,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+37,8 %</td><td align="right" bgcolor="#A8D08D">-33,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5597,896 ns</td><td align="right" bgcolor="#A8D08D">3904,383 ns (Δ = -1693,513 ns)</td><td align="right" bgcolor="#FFFFFF">3950,419 ns</td><td align="right" bgcolor="#FFFFFF">4138,323 ns</td><td align="right" bgcolor="#FF4949">5702,923 ns (Δ = +1564,600 ns)</td><td align="right" bgcolor="#A8D08D">3772,077 ns (Δ = -1930,845 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,598 μs</td><td align="right" bgcolor="#FFFFFF">3,904 μs</td><td align="right" bgcolor="#FFFFFF">3,950 μs</td><td align="right" bgcolor="#FFFFFF">4,138 μs</td><td align="right" bgcolor="#FFFFFF">5,703 μs</td><td align="right" bgcolor="#FFFFFF">3,772 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">724,000</td><td align="right" bgcolor="#FFFFFF">724,000</td><td align="right" bgcolor="#FFFFFF">724,000</td><td align="right" bgcolor="#FFFFFF">724,000</td><td align="right" bgcolor="#FFFFFF">724,000</td><td align="right" bgcolor="#A8D08D">723,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,707</td><td align="right" bgcolor="#FFFFFF">0,707</td><td align="right" bgcolor="#FFFFFF">0,707</td><td align="right" bgcolor="#FFFFFF">0,707</td><td align="right" bgcolor="#FFFFFF">0,707</td><td align="right" bgcolor="#A8D08D">0,706 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 1289,637 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-29,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+23,7 %</td><td align="right" bgcolor="#A8D08D">-21,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4169,792 ns</td><td align="right" bgcolor="#A8D08D">2943,645 ns (Δ = -1226,147 ns)</td><td align="right" bgcolor="#FFFFFF">2880,155 ns</td><td align="right" bgcolor="#FFFFFF">2994,584 ns</td><td align="right" bgcolor="#FF4949">3703,928 ns (Δ = +709,344 ns)</td><td align="right" bgcolor="#A8D08D">2913,173 ns (Δ = -790,755 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,170 μs</td><td align="right" bgcolor="#FFFFFF">2,944 μs</td><td align="right" bgcolor="#FFFFFF">2,880 μs</td><td align="right" bgcolor="#FFFFFF">2,995 μs</td><td align="right" bgcolor="#FFFFFF">3,704 μs</td><td align="right" bgcolor="#FFFFFF">2,913 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">675,000</td><td align="right" bgcolor="#FFFFFF">675,000</td><td align="right" bgcolor="#FFFFFF">675,000</td><td align="right" bgcolor="#FFFFFF">675,000</td><td align="right" bgcolor="#FFFFFF">675,000</td><td align="right" bgcolor="#FFFFFF">675,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,659</td><td align="right" bgcolor="#FFFFFF">0,659</td><td align="right" bgcolor="#FFFFFF">0,659</td><td align="right" bgcolor="#FFFFFF">0,659</td><td align="right" bgcolor="#FFFFFF">0,659</td><td align="right" bgcolor="#FFFFFF">0,659</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 891,265 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+38,4 %</td><td align="right" bgcolor="#A8D08D">-28,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3075,431 ns</td><td align="right" bgcolor="#A8D08D">2206,335 ns (Δ = -869,096 ns)</td><td align="right" bgcolor="#FFFFFF">2187,427 ns</td><td align="right" bgcolor="#FFFFFF">2204,988 ns</td><td align="right" bgcolor="#FF4949">3052,443 ns (Δ = +847,455 ns)</td><td align="right" bgcolor="#A8D08D">2184,165 ns (Δ = -868,277 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,075 μs</td><td align="right" bgcolor="#FFFFFF">2,206 μs</td><td align="right" bgcolor="#FFFFFF">2,187 μs</td><td align="right" bgcolor="#FFFFFF">2,205 μs</td><td align="right" bgcolor="#FFFFFF">3,052 μs</td><td align="right" bgcolor="#FFFFFF">2,184 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 2088,448 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+43,6 %</td><td align="right" bgcolor="#A8D08D">-36,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3927,873 ns</td><td align="right" bgcolor="#FFFFFF">4082,600 ns</td><td align="right" bgcolor="#FFFFFF">3960,272 ns</td><td align="right" bgcolor="#FFFFFF">4030,659 ns</td><td align="right" bgcolor="#FF4949">5786,493 ns (Δ = +1755,835 ns)</td><td align="right" bgcolor="#A8D08D">3698,045 ns (Δ = -2088,448 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,928 μs</td><td align="right" bgcolor="#FFFFFF">4,083 μs</td><td align="right" bgcolor="#FFFFFF">3,960 μs</td><td align="right" bgcolor="#FFFFFF">4,031 μs</td><td align="right" bgcolor="#FFFFFF">5,786 μs</td><td align="right" bgcolor="#FFFFFF">3,698 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">724,000</td><td align="right" bgcolor="#FFFFFF">724,000</td><td align="right" bgcolor="#FFFFFF">724,000</td><td align="right" bgcolor="#FFFFFF">724,000</td><td align="right" bgcolor="#FFFFFF">724,000</td><td align="right" bgcolor="#A8D08D">723,000 (Δ = -1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,707</td><td align="right" bgcolor="#FFFFFF">0,707</td><td align="right" bgcolor="#FFFFFF">0,707</td><td align="right" bgcolor="#FFFFFF">0,707</td><td align="right" bgcolor="#FFFFFF">0,707</td><td align="right" bgcolor="#A8D08D">0,706 (Δ = -0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 1916,061 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+36,0 %</td><td align="right" bgcolor="#A8D08D">-30,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5987,212 ns</td><td align="right" bgcolor="#A8D08D">4661,963 ns (Δ = -1325,249 ns)</td><td align="right" bgcolor="#FFFFFF">4605,971 ns</td><td align="right" bgcolor="#FFFFFF">4635,067 ns</td><td align="right" bgcolor="#FF4949">6303,477 ns (Δ = +1668,411 ns)</td><td align="right" bgcolor="#A8D08D">4387,416 ns (Δ = -1916,061 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,987 μs</td><td align="right" bgcolor="#FFFFFF">4,662 μs</td><td align="right" bgcolor="#FFFFFF">4,606 μs</td><td align="right" bgcolor="#FFFFFF">4,635 μs</td><td align="right" bgcolor="#FFFFFF">6,303 μs</td><td align="right" bgcolor="#FFFFFF">4,387 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1094,000</td><td align="right" bgcolor="#FFFFFF">1094,000</td><td align="right" bgcolor="#FFFFFF">1094,000</td><td align="right" bgcolor="#FFFFFF">1094,000</td><td align="right" bgcolor="#FFFFFF">1094,000</td><td align="right" bgcolor="#FFFFFF">1094,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,068</td><td align="right" bgcolor="#FFFFFF">1,068</td><td align="right" bgcolor="#FFFFFF">1,068</td><td align="right" bgcolor="#FFFFFF">1,068</td><td align="right" bgcolor="#FFFFFF">1,068</td><td align="right" bgcolor="#FFFFFF">1,068</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ModelBase_Constructor_Benchmark"></a>ModelBase_Constructor_Benchmark

### <a name="ModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 433,440 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2244,251 ns</td><td align="right" bgcolor="#FFFFFF">2323,981 ns</td><td align="right" bgcolor="#FFFFFF">2468,528 ns</td><td align="right" bgcolor="#FFFFFF">2677,691 ns</td><td align="right" bgcolor="#A8D08D">2254,416 ns (Δ = -423,275 ns)</td><td align="right" bgcolor="#FFFFFF">2352,640 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,244 μs</td><td align="right" bgcolor="#FFFFFF">2,324 μs</td><td align="right" bgcolor="#FFFFFF">2,469 μs</td><td align="right" bgcolor="#FFFFFF">2,678 μs</td><td align="right" bgcolor="#FFFFFF">2,254 μs</td><td align="right" bgcolor="#FFFFFF">2,353 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#A8D08D">934,000 (Δ = -39,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#A8D08D">0,912 (Δ = -0,038)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr></table>


## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 20,155 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">350,856 ns</td><td align="right" bgcolor="#FFFFFF">355,128 ns</td><td align="right" bgcolor="#FFFFFF">341,285 ns</td><td align="right" bgcolor="#FFFFFF">357,373 ns</td><td align="right" bgcolor="#FFFFFF">341,179 ns</td><td align="right" bgcolor="#FFFFFF">337,219 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,351 μs</td><td align="right" bgcolor="#FFFFFF">0,355 μs</td><td align="right" bgcolor="#FFFFFF">0,341 μs</td><td align="right" bgcolor="#FFFFFF">0,357 μs</td><td align="right" bgcolor="#FFFFFF">0,341 μs</td><td align="right" bgcolor="#FFFFFF">0,337 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#A8D08D">59,000 (Δ = -23,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#A8D08D">0,058 (Δ = -0,022)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 39,275 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">370,912 ns</td><td align="right" bgcolor="#FFFFFF">392,664 ns</td><td align="right" bgcolor="#FFFFFF">372,008 ns</td><td align="right" bgcolor="#FFFFFF">371,363 ns</td><td align="right" bgcolor="#FFFFFF">353,389 ns</td><td align="right" bgcolor="#FFFFFF">367,944 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,371 μs</td><td align="right" bgcolor="#FFFFFF">0,393 μs</td><td align="right" bgcolor="#FFFFFF">0,372 μs</td><td align="right" bgcolor="#FFFFFF">0,371 μs</td><td align="right" bgcolor="#FFFFFF">0,353 μs</td><td align="right" bgcolor="#FFFFFF">0,368 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#FFFFFF">82,000</td><td align="right" bgcolor="#A8D08D">59,000 (Δ = -23,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#FFFFFF">0,080</td><td align="right" bgcolor="#A8D08D">0,058 (Δ = -0,022)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 65,707 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">310,453 ns</td><td align="right" bgcolor="#FFFFFF">295,445 ns</td><td align="right" bgcolor="#FFFFFF">279,621 ns</td><td align="right" bgcolor="#FFFFFF">275,245 ns</td><td align="right" bgcolor="#FFFFFF">265,296 ns</td><td align="right" bgcolor="#FFFFFF">331,003 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,310 μs</td><td align="right" bgcolor="#FFFFFF">0,295 μs</td><td align="right" bgcolor="#FFFFFF">0,280 μs</td><td align="right" bgcolor="#FFFFFF">0,275 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,331 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">59,000</td><td align="right" bgcolor="#FFFFFF">59,000</td><td align="right" bgcolor="#FFFFFF">59,000</td><td align="right" bgcolor="#FFFFFF">59,000</td><td align="right" bgcolor="#FFFFFF">59,000</td><td align="right" bgcolor="#FFFFFF">59,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,058</td><td align="right" bgcolor="#FFFFFF">0,058</td><td align="right" bgcolor="#FFFFFF">0,058</td><td align="right" bgcolor="#FFFFFF">0,058</td><td align="right" bgcolor="#FFFFFF">0,058</td><td align="right" bgcolor="#FFFFFF">0,058</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ObjectHelper_Benchmark"></a>ObjectHelper_Benchmark

### <a name="ObjectHelper_Benchmark_AreEqual__Same_Reference"></a>AreEqual__Same_Reference

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 3,304 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,360 ns</td><td align="right" bgcolor="#FFFFFF">1,188 ns</td><td align="right" bgcolor="#FFFFFF">1,805 ns</td><td align="right" bgcolor="#FFFFFF">1,401 ns</td><td align="right" bgcolor="#FFFFFF">1,441 ns</td><td align="right" bgcolor="#FFFFFF">4,492 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Both_Null"></a>AreEqual_Both_Null

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 2,996 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,419 ns</td><td align="right" bgcolor="#FFFFFF">1,257 ns</td><td align="right" bgcolor="#FFFFFF">1,632 ns</td><td align="right" bgcolor="#FFFFFF">1,507 ns</td><td align="right" bgcolor="#FFFFFF">1,497 ns</td><td align="right" bgcolor="#FFFFFF">4,253 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Not_Same_Reference"></a>AreEqual_Not_Same_Reference

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 5,907 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,949 ns</td><td align="right" bgcolor="#FFFFFF">4,464 ns</td><td align="right" bgcolor="#FFFFFF">5,987 ns</td><td align="right" bgcolor="#FFFFFF">5,192 ns</td><td align="right" bgcolor="#FFFFFF">4,557 ns</td><td align="right" bgcolor="#FFFFFF">10,371 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_One_Null"></a>AreEqual_One_Null

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 2,469 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,835 ns</td><td align="right" bgcolor="#FFFFFF">1,629 ns</td><td align="right" bgcolor="#FFFFFF">2,088 ns</td><td align="right" bgcolor="#FFFFFF">1,248 ns</td><td align="right" bgcolor="#FFFFFF">1,760 ns</td><td align="right" bgcolor="#FFFFFF">3,717 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Strings"></a>AreEqual_Strings

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 2,904 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,003 ns</td><td align="right" bgcolor="#FFFFFF">6,357 ns</td><td align="right" bgcolor="#FFFFFF">8,267 ns</td><td align="right" bgcolor="#FFFFFF">5,507 ns</td><td align="right" bgcolor="#FFFFFF">5,909 ns</td><td align="right" bgcolor="#FFFFFF">8,411 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Both_Null"></a>AreEqualReferences_Both_Null

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 2,369 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,835 ns</td><td align="right" bgcolor="#FFFFFF">1,595 ns</td><td align="right" bgcolor="#FFFFFF">1,981 ns</td><td align="right" bgcolor="#FFFFFF">2,232 ns</td><td align="right" bgcolor="#FFFFFF">1,835 ns</td><td align="right" bgcolor="#FFFFFF">3,964 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Not_Same_Reference"></a>AreEqualReferences_Not_Same_Reference

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 15,973 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">42,533 ns</td><td align="right" bgcolor="#FFFFFF">35,384 ns</td><td align="right" bgcolor="#FFFFFF">35,483 ns</td><td align="right" bgcolor="#FFFFFF">35,904 ns</td><td align="right" bgcolor="#FFFFFF">40,648 ns</td><td align="right" bgcolor="#FFFFFF">51,357 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_One_Null"></a>AreEqualReferences_One_Null

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 1,221 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,579 ns</td><td align="right" bgcolor="#FFFFFF">2,008 ns</td><td align="right" bgcolor="#FFFFFF">2,272 ns</td><td align="right" bgcolor="#FFFFFF">1,504 ns</td><td align="right" bgcolor="#FFFFFF">1,915 ns</td><td align="right" bgcolor="#FFFFFF">2,725 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Same_Reference"></a>AreEqualReferences_Same_Reference

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 5,801 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,061 ns</td><td align="right" bgcolor="#FFFFFF">1,795 ns</td><td align="right" bgcolor="#FFFFFF">1,845 ns</td><td align="right" bgcolor="#FFFFFF">1,472 ns</td><td align="right" bgcolor="#FFFFFF">1,501 ns</td><td align="right" bgcolor="#FFFFFF">7,273 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Strings"></a>AreEqualReferences_Strings

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 7,240 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">60,533 ns</td><td align="right" bgcolor="#FFFFFF">55,891 ns</td><td align="right" bgcolor="#FFFFFF">56,157 ns</td><td align="right" bgcolor="#FFFFFF">54,735 ns</td><td align="right" bgcolor="#FFFFFF">53,293 ns</td><td align="right" bgcolor="#FFFFFF">57,715 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_IsNull"></a>IsNull

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 1,067 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,147 ns</td><td align="right" bgcolor="#FFFFFF">0,128 ns</td><td align="right" bgcolor="#FFFFFF">0,085 ns</td><td align="right" bgcolor="#FFFFFF">0,269 ns</td><td align="right" bgcolor="#FFFFFF">0,869 ns</td><td align="right" bgcolor="#FFFFFF">1,152 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ObjectToStringHelper_Benchmark"></a>ObjectToStringHelper_Benchmark

### <a name="ObjectToStringHelper_Benchmark_ToFullTypeString"></a>ToFullTypeString

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 5,443 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">79,787 ns</td><td align="right" bgcolor="#FFFFFF">79,757 ns</td><td align="right" bgcolor="#FFFFFF">75,352 ns</td><td align="right" bgcolor="#FFFFFF">75,424 ns</td><td align="right" bgcolor="#FFFFFF">74,907 ns</td><td align="right" bgcolor="#FFFFFF">80,349 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectToStringHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 2123,221 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-85,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2436,773 ns</td><td align="right" bgcolor="#FFFFFF">2388,587 ns</td><td align="right" bgcolor="#FFFFFF">2222,019 ns</td><td align="right" bgcolor="#FFFFFF">2186,776 ns</td><td align="right" bgcolor="#A8D08D">313,552 ns (Δ = -1873,224 ns)</td><td align="right" bgcolor="#FFFFFF">320,763 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,437 μs</td><td align="right" bgcolor="#FFFFFF">2,389 μs</td><td align="right" bgcolor="#FFFFFF">2,222 μs</td><td align="right" bgcolor="#FFFFFF">2,187 μs</td><td align="right" bgcolor="#FFFFFF">0,314 μs</td><td align="right" bgcolor="#FFFFFF">0,321 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-92,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1747,000</td><td align="right" bgcolor="#A8D08D">1711,000 (Δ = -36,000)</td><td align="right" bgcolor="#FFFFFF">1711,000</td><td align="right" bgcolor="#FFFFFF">1711,000</td><td align="right" bgcolor="#A8D08D">121,000 (Δ = -1590,000)</td><td align="right" bgcolor="#FFFFFF">121,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,706</td><td align="right" bgcolor="#A8D08D">1,671 (Δ = -0,035)</td><td align="right" bgcolor="#FFFFFF">1,671</td><td align="right" bgcolor="#FFFFFF">1,671</td><td align="right" bgcolor="#A8D08D">0,118 (Δ = -1,553)</td><td align="right" bgcolor="#FFFFFF">0,118</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectToStringHelper_Benchmark_ToTypeString"></a>ToTypeString

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 5,005 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,741 ns</td><td align="right" bgcolor="#FFFFFF">17,736 ns</td><td align="right" bgcolor="#FFFFFF">19,051 ns</td><td align="right" bgcolor="#FFFFFF">17,819 ns</td><td align="right" bgcolor="#FFFFFF">18,635 ns</td><td align="right" bgcolor="#FFFFFF">22,216 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ParallelHelper_Benchmark"></a>ParallelHelper_Benchmark

### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100"></a>ExecuteInParallel_ItemsPerBash_100

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 279464,133 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,3 %</td><td align="right" bgcolor="#A8D08D">-10,0 %</td><td align="right" bgcolor="#FF4949">+2,7 %</td><td align="right" bgcolor="#A8D08D">-3,1 %</td><td align="right" bgcolor="#FF4949">+2,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2505513,336 ns</td><td align="right" bgcolor="#FF4949">2663985,765 ns (Δ = +158472,429 ns)</td><td align="right" bgcolor="#A8D08D">2396373,123 ns (Δ = -267612,643 ns)</td><td align="right" bgcolor="#FF4949">2460557,037 ns (Δ = +64183,915 ns)</td><td align="right" bgcolor="#A8D08D">2384521,632 ns (Δ = -76035,405 ns)</td><td align="right" bgcolor="#FF4949">2436250,516 ns (Δ = +51728,884 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2505,513 μs</td><td align="right" bgcolor="#FFFFFF">2663,986 μs</td><td align="right" bgcolor="#A8D08D">2396,373 μs (Δ = -267,613 μs)</td><td align="right" bgcolor="#FFFFFF">2460,557 μs</td><td align="right" bgcolor="#FFFFFF">2384,522 μs</td><td align="right" bgcolor="#FFFFFF">2436,251 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,506 ms</td><td align="right" bgcolor="#FFFFFF">2,664 ms</td><td align="right" bgcolor="#FFFFFF">2,396 ms</td><td align="right" bgcolor="#FFFFFF">2,461 ms</td><td align="right" bgcolor="#FFFFFF">2,385 ms</td><td align="right" bgcolor="#FFFFFF">2,436 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0.0</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">199,000</td><td align="right" bgcolor="#FFFFFF">199,000</td><td align="right" bgcolor="#FFFFFF">199,000</td><td align="right" bgcolor="#FFFFFF">199,000</td><td align="right" bgcolor="#FFFFFF">199,000</td><td align="right" bgcolor="#FFFFFF">199,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#FF4949">+0,2 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">167076,000</td><td align="right" bgcolor="#FF4949">167673,000 (Δ = +597,000)</td><td align="right" bgcolor="#A8D08D">167661,000 (Δ = -12,000)</td><td align="right" bgcolor="#A8D08D">167190,000 (Δ = -471,000)</td><td align="right" bgcolor="#FF4949">167467,000 (Δ = +277,000)</td><td align="right" bgcolor="#FF4949">167540,000 (Δ = +73,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">163,160</td><td align="right" bgcolor="#FF4949">163,743 (Δ = +0,583)</td><td align="right" bgcolor="#A8D08D">163,731 (Δ = -0,012)</td><td align="right" bgcolor="#A8D08D">163,271 (Δ = -0,460)</td><td align="right" bgcolor="#FF4949">163,542 (Δ = +0,271)</td><td align="right" bgcolor="#FF4949">163,613 (Δ = +0,071)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,159</td><td align="right" bgcolor="#FF4949">0,160 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,159 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,160 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,160 (Δ = +0,000)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000"></a>ExecuteInParallel_ItemsPerBash_1000

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 838305,863 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,2 %</td><td align="right" bgcolor="#A8D08D">-6,0 %</td><td align="right" bgcolor="#FF4949">+12,9 %</td><td align="right" bgcolor="#A8D08D">-13,5 %</td><td align="right" bgcolor="#A8D08D">-48,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1475673,344 ns</td><td align="right" bgcolor="#A8D08D">1428874,865 ns (Δ = -46798,479 ns)</td><td align="right" bgcolor="#A8D08D">1343252,805 ns (Δ = -85622,060 ns)</td><td align="right" bgcolor="#FF4949">1516113,984 ns (Δ = +172861,179 ns)</td><td align="right" bgcolor="#A8D08D">1311902,384 ns (Δ = -204211,600 ns)</td><td align="right" bgcolor="#A8D08D">677808,121 ns (Δ = -634094,263 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1475,673 μs</td><td align="right" bgcolor="#FFFFFF">1428,875 μs</td><td align="right" bgcolor="#FFFFFF">1343,253 μs</td><td align="right" bgcolor="#FFFFFF">1516,114 μs</td><td align="right" bgcolor="#FFFFFF">1311,902 μs</td><td align="right" bgcolor="#A8D08D">677,808 μs (Δ = -634,094 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,476 ms</td><td align="right" bgcolor="#FFFFFF">1,429 ms</td><td align="right" bgcolor="#FFFFFF">1,343 ms</td><td align="right" bgcolor="#FFFFFF">1,516 ms</td><td align="right" bgcolor="#FFFFFF">1,312 ms</td><td align="right" bgcolor="#FFFFFF">0,678 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.4.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">108,000</td><td align="right" bgcolor="#FFFFFF">108,000</td><td align="right" bgcolor="#FFFFFF">108,000</td><td align="right" bgcolor="#FFFFFF">108,000</td><td align="right" bgcolor="#FFFFFF">108,000</td><td align="right" bgcolor="#FFFFFF">108,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#FF4949">+0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">91272,000</td><td align="right" bgcolor="#A8D08D">91184,000 (Δ = -88,000)</td><td align="right" bgcolor="#FF4949">91239,000 (Δ = +55,000)</td><td align="right" bgcolor="#A8D08D">91232,000 (Δ = -7,000)</td><td align="right" bgcolor="#FF4949">91332,000 (Δ = +100,000)</td><td align="right" bgcolor="#FF4949">91639,000 (Δ = +307,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">89,133</td><td align="right" bgcolor="#A8D08D">89,047 (Δ = -0,086)</td><td align="right" bgcolor="#FF4949">89,101 (Δ = +0,054)</td><td align="right" bgcolor="#A8D08D">89,094 (Δ = -0,007)</td><td align="right" bgcolor="#FF4949">89,191 (Δ = +0,098)</td><td align="right" bgcolor="#FF4949">89,491 (Δ = +0,300)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,087</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,000)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500"></a>ExecuteInParallel_ItemsPerBash_500

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 1064408,733 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,4 %</td><td align="right" bgcolor="#FF4949">+74,2 %</td><td align="right" bgcolor="#A8D08D">-53,0 %</td><td align="right" bgcolor="#FF4949">+62,8 %</td><td align="right" bgcolor="#A8D08D">-48,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">986521,373 ns</td><td align="right" bgcolor="#FF4949">1009780,752 ns (Δ = +23259,379 ns)</td><td align="right" bgcolor="#FF4949">1759489,059 ns (Δ = +749708,307 ns)</td><td align="right" bgcolor="#A8D08D">827505,435 ns (Δ = -931983,624 ns)</td><td align="right" bgcolor="#FF4949">1347352,139 ns (Δ = +519846,704 ns)</td><td align="right" bgcolor="#A8D08D">695080,325 ns (Δ = -652271,813 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">986,521 μs</td><td align="right" bgcolor="#FFFFFF">1009,781 μs</td><td align="right" bgcolor="#FF4949">1759,489 μs (Δ = +749,708 μs)</td><td align="right" bgcolor="#A8D08D">827,505 μs (Δ = -931,984 μs)</td><td align="right" bgcolor="#FF4949">1347,352 μs (Δ = +519,847 μs)</td><td align="right" bgcolor="#A8D08D">695,080 μs (Δ = -652,272 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,987 ms</td><td align="right" bgcolor="#FFFFFF">1,010 ms</td><td align="right" bgcolor="#FFFFFF">1,759 ms</td><td align="right" bgcolor="#FFFFFF">0,828 ms</td><td align="right" bgcolor="#FFFFFF">1,347 ms</td><td align="right" bgcolor="#FFFFFF">0,695 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.6.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">117,000</td><td align="right" bgcolor="#A8D08D">116,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">116,000</td><td align="right" bgcolor="#A8D08D">115,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">116,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">115,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#A8D08D">-1,0 %</td><td align="right" bgcolor="#FF4949">+1,0 %</td><td align="right" bgcolor="#A8D08D">-0,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">98224,000</td><td align="right" bgcolor="#A8D08D">98203,000 (Δ = -21,000)</td><td align="right" bgcolor="#A8D08D">98066,000 (Δ = -137,000)</td><td align="right" bgcolor="#A8D08D">97109,000 (Δ = -957,000)</td><td align="right" bgcolor="#FF4949">98091,000 (Δ = +982,000)</td><td align="right" bgcolor="#A8D08D">97176,000 (Δ = -915,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">95,922</td><td align="right" bgcolor="#A8D08D">95,901 (Δ = -0,021)</td><td align="right" bgcolor="#A8D08D">95,768 (Δ = -0,134)</td><td align="right" bgcolor="#A8D08D">94,833 (Δ = -0,935)</td><td align="right" bgcolor="#FF4949">95,792 (Δ = +0,959)</td><td align="right" bgcolor="#A8D08D">94,898 (Δ = -0,894)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,094</td><td align="right" bgcolor="#A8D08D">0,094 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,094 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,094 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,001)</td></tr></table>


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 13,733 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">87,947 ns</td><td align="right" bgcolor="#FFFFFF">89,859 ns</td><td align="right" bgcolor="#FFFFFF">89,664 ns</td><td align="right" bgcolor="#FFFFFF">94,819 ns</td><td align="right" bgcolor="#FFFFFF">82,549 ns</td><td align="right" bgcolor="#FFFFFF">96,283 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 17,983 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">98,804 ns</td><td align="right" bgcolor="#FFFFFF">82,699 ns</td><td align="right" bgcolor="#FFFFFF">84,091 ns</td><td align="right" bgcolor="#FFFFFF">89,709 ns</td><td align="right" bgcolor="#FFFFFF">85,221 ns</td><td align="right" bgcolor="#FFFFFF">80,821 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 8,069 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">51,080 ns</td><td align="right" bgcolor="#FFFFFF">55,053 ns</td><td align="right" bgcolor="#FFFFFF">52,957 ns</td><td align="right" bgcolor="#FFFFFF">53,472 ns</td><td align="right" bgcolor="#FFFFFF">54,008 ns</td><td align="right" bgcolor="#FFFFFF">46,984 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 324,443 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2154,803 ns</td><td align="right" bgcolor="#FFFFFF">2261,992 ns</td><td align="right" bgcolor="#FFFFFF">2216,417 ns</td><td align="right" bgcolor="#FFFFFF">2181,453 ns</td><td align="right" bgcolor="#FFFFFF">2392,075 ns</td><td align="right" bgcolor="#A8D08D">2067,632 ns (Δ = -324,443 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,155 μs</td><td align="right" bgcolor="#FFFFFF">2,262 μs</td><td align="right" bgcolor="#FFFFFF">2,216 μs</td><td align="right" bgcolor="#FFFFFF">2,181 μs</td><td align="right" bgcolor="#FFFFFF">2,392 μs</td><td align="right" bgcolor="#FFFFFF">2,068 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 169,580 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">595,389 ns</td><td align="right" bgcolor="#FFFFFF">631,804 ns</td><td align="right" bgcolor="#FFFFFF">735,655 ns</td><td align="right" bgcolor="#FFFFFF">617,043 ns</td><td align="right" bgcolor="#FFFFFF">591,419 ns</td><td align="right" bgcolor="#FFFFFF">566,075 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,595 μs</td><td align="right" bgcolor="#FFFFFF">0,632 μs</td><td align="right" bgcolor="#FFFFFF">0,736 μs</td><td align="right" bgcolor="#FFFFFF">0,617 μs</td><td align="right" bgcolor="#FFFFFF">0,591 μs</td><td align="right" bgcolor="#FFFFFF">0,566 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">75,000</td><td align="right" bgcolor="#FFFFFF">75,000</td><td align="right" bgcolor="#FFFFFF">75,000</td><td align="right" bgcolor="#FFFFFF">75,000</td><td align="right" bgcolor="#FFFFFF">75,000</td><td align="right" bgcolor="#FFFFFF">75,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,073</td><td align="right" bgcolor="#FFFFFF">0,073</td><td align="right" bgcolor="#FFFFFF">0,073</td><td align="right" bgcolor="#FFFFFF">0,073</td><td align="right" bgcolor="#FFFFFF">0,073</td><td align="right" bgcolor="#FFFFFF">0,073</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 278,231 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2610,568 ns</td><td align="right" bgcolor="#FFFFFF">2642,277 ns</td><td align="right" bgcolor="#FFFFFF">2589,184 ns</td><td align="right" bgcolor="#FFFFFF">2766,445 ns</td><td align="right" bgcolor="#FFFFFF">2523,251 ns</td><td align="right" bgcolor="#FFFFFF">2488,215 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,611 μs</td><td align="right" bgcolor="#FFFFFF">2,642 μs</td><td align="right" bgcolor="#FFFFFF">2,589 μs</td><td align="right" bgcolor="#FFFFFF">2,766 μs</td><td align="right" bgcolor="#FFFFFF">2,523 μs</td><td align="right" bgcolor="#FFFFFF">2,488 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">587,000</td><td align="right" bgcolor="#FFFFFF">587,000</td><td align="right" bgcolor="#FFFFFF">587,000</td><td align="right" bgcolor="#FFFFFF">587,000</td><td align="right" bgcolor="#FFFFFF">587,000</td><td align="right" bgcolor="#FFFFFF">587,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,573</td><td align="right" bgcolor="#FFFFFF">0,573</td><td align="right" bgcolor="#FFFFFF">0,573</td><td align="right" bgcolor="#FFFFFF">0,573</td><td align="right" bgcolor="#FFFFFF">0,573</td><td align="right" bgcolor="#FFFFFF">0,573</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 129,151 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2166,448 ns</td><td align="right" bgcolor="#FFFFFF">2267,672 ns</td><td align="right" bgcolor="#FFFFFF">2261,491 ns</td><td align="right" bgcolor="#FFFFFF">2222,917 ns</td><td align="right" bgcolor="#FFFFFF">2173,093 ns</td><td align="right" bgcolor="#FFFFFF">2295,599 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,166 μs</td><td align="right" bgcolor="#FFFFFF">2,268 μs</td><td align="right" bgcolor="#FFFFFF">2,261 μs</td><td align="right" bgcolor="#FFFFFF">2,223 μs</td><td align="right" bgcolor="#FFFFFF">2,173 μs</td><td align="right" bgcolor="#FFFFFF">2,296 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 50,564 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">615,329 ns</td><td align="right" bgcolor="#FFFFFF">605,429 ns</td><td align="right" bgcolor="#FFFFFF">641,295 ns</td><td align="right" bgcolor="#FFFFFF">630,323 ns</td><td align="right" bgcolor="#FFFFFF">622,635 ns</td><td align="right" bgcolor="#FFFFFF">590,731 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,615 μs</td><td align="right" bgcolor="#FFFFFF">0,605 μs</td><td align="right" bgcolor="#FFFFFF">0,641 μs</td><td align="right" bgcolor="#FFFFFF">0,630 μs</td><td align="right" bgcolor="#FFFFFF">0,623 μs</td><td align="right" bgcolor="#FFFFFF">0,591 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">75,000</td><td align="right" bgcolor="#FFFFFF">75,000</td><td align="right" bgcolor="#FFFFFF">75,000</td><td align="right" bgcolor="#FFFFFF">75,000</td><td align="right" bgcolor="#FFFFFF">75,000</td><td align="right" bgcolor="#FFFFFF">75,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,073</td><td align="right" bgcolor="#FFFFFF">0,073</td><td align="right" bgcolor="#FFFFFF">0,073</td><td align="right" bgcolor="#FFFFFF">0,073</td><td align="right" bgcolor="#FFFFFF">0,073</td><td align="right" bgcolor="#FFFFFF">0,073</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 36,229 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">505,083 ns</td><td align="right" bgcolor="#FFFFFF">522,877 ns</td><td align="right" bgcolor="#FFFFFF">519,643 ns</td><td align="right" bgcolor="#FFFFFF">535,368 ns</td><td align="right" bgcolor="#FFFFFF">529,939 ns</td><td align="right" bgcolor="#FFFFFF">499,139 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,505 μs</td><td align="right" bgcolor="#FFFFFF">0,523 μs</td><td align="right" bgcolor="#FFFFFF">0,520 μs</td><td align="right" bgcolor="#FFFFFF">0,535 μs</td><td align="right" bgcolor="#FFFFFF">0,530 μs</td><td align="right" bgcolor="#FFFFFF">0,499 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#FFFFFF">161,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#FFFFFF">0,157</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ResourceHelper_Benchmark"></a>ResourceHelper_Benchmark

### <a name="ResourceHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 2259,341 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+699,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">341,880 ns</td><td align="right" bgcolor="#FFFFFF">332,493 ns</td><td align="right" bgcolor="#FFFFFF">346,869 ns</td><td align="right" bgcolor="#FFFFFF">335,288 ns</td><td align="right" bgcolor="#FFFFFF">323,028 ns</td><td align="right" bgcolor="#FF4949">2582,369 ns (Δ = +2259,341 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,342 μs</td><td align="right" bgcolor="#FFFFFF">0,332 μs</td><td align="right" bgcolor="#FFFFFF">0,347 μs</td><td align="right" bgcolor="#FFFFFF">0,335 μs</td><td align="right" bgcolor="#FFFFFF">0,323 μs</td><td align="right" bgcolor="#FFFFFF">2,582 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +2,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+600,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">259,000</td><td align="right" bgcolor="#FFFFFF">259,000</td><td align="right" bgcolor="#FFFFFF">259,000</td><td align="right" bgcolor="#FFFFFF">259,000</td><td align="right" bgcolor="#FFFFFF">259,000</td><td align="right" bgcolor="#FF4949">1815,000 (Δ = +1556,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,253</td><td align="right" bgcolor="#FFFFFF">0,253</td><td align="right" bgcolor="#FFFFFF">0,253</td><td align="right" bgcolor="#FFFFFF">0,253</td><td align="right" bgcolor="#FFFFFF">0,253</td><td align="right" bgcolor="#FF4949">1,772 (Δ = +1,520)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,001)</td></tr></table>


## <a name="ScopeManager_Benchmark"></a>ScopeManager_Benchmark

### <a name="ScopeManager_Benchmark_Get_Existing_ScopeManager"></a>Get_Existing_ScopeManager

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 459,155 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+404,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">126,035 ns</td><td align="right" bgcolor="#FFFFFF">105,973 ns</td><td align="right" bgcolor="#FFFFFF">99,773 ns</td><td align="right" bgcolor="#FFFFFF">105,939 ns</td><td align="right" bgcolor="#FFFFFF">110,868 ns</td><td align="right" bgcolor="#FF4949">558,928 ns (Δ = +448,060 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td><td align="right" bgcolor="#FFFFFF">0,559 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2030,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FF4949">554,000 (Δ = +528,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FF4949">0,541 (Δ = +0,516)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="ScopeManager_Benchmark_Get_New_ScopeManager"></a>Get_New_ScopeManager

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 451,625 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+435,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">112,477 ns</td><td align="right" bgcolor="#FFFFFF">103,736 ns</td><td align="right" bgcolor="#FFFFFF">104,347 ns</td><td align="right" bgcolor="#FFFFFF">106,013 ns</td><td align="right" bgcolor="#FFFFFF">103,808 ns</td><td align="right" bgcolor="#FF4949">555,361 ns (Δ = +451,553 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,555 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2003,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FF4949">547,000 (Δ = +521,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FF4949">0,534 (Δ = +0,509)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 43357,784 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,0 %</td><td align="right" bgcolor="#A8D08D">-9,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">395844,760 ns</td><td align="right" bgcolor="#FFFFFF">397687,040 ns</td><td align="right" bgcolor="#FF4949">433570,584 ns (Δ = +35883,544 ns)</td><td align="right" bgcolor="#A8D08D">392237,917 ns (Δ = -41332,667 ns)</td><td align="right" bgcolor="#FFFFFF">390212,800 ns</td><td align="right" bgcolor="#FF4949">412752,296 ns (Δ = +22539,496 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">395,845 μs</td><td align="right" bgcolor="#FFFFFF">397,687 μs</td><td align="right" bgcolor="#FFFFFF">433,571 μs</td><td align="right" bgcolor="#FFFFFF">392,238 μs</td><td align="right" bgcolor="#FFFFFF">390,213 μs</td><td align="right" bgcolor="#FFFFFF">412,752 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,396 ms</td><td align="right" bgcolor="#FFFFFF">0,398 ms</td><td align="right" bgcolor="#FFFFFF">0,434 ms</td><td align="right" bgcolor="#FFFFFF">0,392 ms</td><td align="right" bgcolor="#FFFFFF">0,390 ms</td><td align="right" bgcolor="#FFFFFF">0,413 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.6.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">122,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">122,000</td><td align="right" bgcolor="#FF4949">150,000 (Δ = +28,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-1,2 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+22,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">104007,000</td><td align="right" bgcolor="#FF4949">104008,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">104001,000 (Δ = -7,000)</td><td align="right" bgcolor="#A8D08D">102802,000 (Δ = -1199,000)</td><td align="right" bgcolor="#FF4949">102808,000 (Δ = +6,000)</td><td align="right" bgcolor="#FF4949">126003,000 (Δ = +23195,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">101,569</td><td align="right" bgcolor="#FF4949">101,570 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">101,563 (Δ = -0,007)</td><td align="right" bgcolor="#A8D08D">100,393 (Δ = -1,171)</td><td align="right" bgcolor="#FF4949">100,398 (Δ = +0,006)</td><td align="right" bgcolor="#FF4949">123,050 (Δ = +22,651)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,099</td><td align="right" bgcolor="#FF4949">0,099 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,099 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,098 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,098 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,120 (Δ = +0,022)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 18732,632 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,9 %</td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#FF4949">+1,7 %</td><td align="right" bgcolor="#A8D08D">-4,9 %</td><td align="right" bgcolor="#FF4949">+4,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">238593,400 ns</td><td align="right" bgcolor="#FF4949">250260,856 ns (Δ = +11667,456 ns)</td><td align="right" bgcolor="#A8D08D">239282,936 ns (Δ = -10977,920 ns)</td><td align="right" bgcolor="#FF4949">243398,728 ns (Δ = +4115,792 ns)</td><td align="right" bgcolor="#A8D08D">231528,224 ns (Δ = -11870,504 ns)</td><td align="right" bgcolor="#FF4949">241398,389 ns (Δ = +9870,165 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">238,593 μs</td><td align="right" bgcolor="#FFFFFF">250,261 μs</td><td align="right" bgcolor="#FFFFFF">239,283 μs</td><td align="right" bgcolor="#FFFFFF">243,399 μs</td><td align="right" bgcolor="#FFFFFF">231,528 μs</td><td align="right" bgcolor="#FFFFFF">241,398 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,239 ms</td><td align="right" bgcolor="#FFFFFF">0,250 ms</td><td align="right" bgcolor="#FFFFFF">0,239 ms</td><td align="right" bgcolor="#FFFFFF">0,243 ms</td><td align="right" bgcolor="#FFFFFF">0,232 ms</td><td align="right" bgcolor="#FFFFFF">0,241 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">45,000</td><td align="right" bgcolor="#FFFFFF">45,000</td><td align="right" bgcolor="#FFFFFF">45,000</td><td align="right" bgcolor="#A8D08D">44,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">44,000</td><td align="right" bgcolor="#FF4949">52,000 (Δ = +8,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-2,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">38230,000</td><td align="right" bgcolor="#A8D08D">38211,000 (Δ = -19,000)</td><td align="right" bgcolor="#A8D08D">38210,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">37128,000 (Δ = -1082,000)</td><td align="right" bgcolor="#FFFFFF">37128,000</td><td align="right" bgcolor="#FF4949">43936,000 (Δ = +6808,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">37,334</td><td align="right" bgcolor="#A8D08D">37,315 (Δ = -0,019)</td><td align="right" bgcolor="#A8D08D">37,314 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">36,258 (Δ = -1,057)</td><td align="right" bgcolor="#FFFFFF">36,258</td><td align="right" bgcolor="#FF4949">42,906 (Δ = +6,648)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,035 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FF4949">0,042 (Δ = +0,006)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 45941,165 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,7 %</td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#FF4949">+12,6 %</td><td align="right" bgcolor="#A8D08D">-12,3 %</td><td align="right" bgcolor="#FF4949">+6,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">334315,533 ns</td><td align="right" bgcolor="#FF4949">343204,763 ns (Δ = +8889,229 ns)</td><td align="right" bgcolor="#A8D08D">331916,680 ns (Δ = -11288,083 ns)</td><td align="right" bgcolor="#FF4949">373716,696 ns (Δ = +41800,016 ns)</td><td align="right" bgcolor="#A8D08D">327775,531 ns (Δ = -45941,165 ns)</td><td align="right" bgcolor="#FF4949">348350,496 ns (Δ = +20574,965 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">334,316 μs</td><td align="right" bgcolor="#FFFFFF">343,205 μs</td><td align="right" bgcolor="#FFFFFF">331,917 μs</td><td align="right" bgcolor="#FFFFFF">373,717 μs</td><td align="right" bgcolor="#FFFFFF">327,776 μs</td><td align="right" bgcolor="#FFFFFF">348,350 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,334 ms</td><td align="right" bgcolor="#FFFFFF">0,343 ms</td><td align="right" bgcolor="#FFFFFF">0,332 ms</td><td align="right" bgcolor="#FFFFFF">0,374 ms</td><td align="right" bgcolor="#FFFFFF">0,328 ms</td><td align="right" bgcolor="#FFFFFF">0,348 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#FFFFFF">98,000</td><td align="right" bgcolor="#A8D08D">97,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">97,000</td><td align="right" bgcolor="#FF4949">124,000 (Δ = +27,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+28,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">82954,000</td><td align="right" bgcolor="#FF4949">82957,000 (Δ = +3,000)</td><td align="right" bgcolor="#A8D08D">82937,000 (Δ = -20,000)</td><td align="right" bgcolor="#A8D08D">81693,000 (Δ = -1244,000)</td><td align="right" bgcolor="#A8D08D">81690,000 (Δ = -3,000)</td><td align="right" bgcolor="#FF4949">104791,000 (Δ = +23101,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">81,010</td><td align="right" bgcolor="#FF4949">81,013 (Δ = +0,003)</td><td align="right" bgcolor="#A8D08D">80,993 (Δ = -0,020)</td><td align="right" bgcolor="#A8D08D">79,778 (Δ = -1,215)</td><td align="right" bgcolor="#A8D08D">79,775 (Δ = -0,003)</td><td align="right" bgcolor="#FF4949">102,335 (Δ = +22,560)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,079</td><td align="right" bgcolor="#FF4949">0,079 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,079 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,078 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,078 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,100 (Δ = +0,022)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 126627,307 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,5 %</td><td align="right" bgcolor="#FF4949">+7,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">904793,907 ns</td><td align="right" bgcolor="#A8D08D">865239,387 ns (Δ = -39554,520 ns)</td><td align="right" bgcolor="#A8D08D">827502,824 ns (Δ = -37736,563 ns)</td><td align="right" bgcolor="#FFFFFF">823349,440 ns</td><td align="right" bgcolor="#FF4949">885418,821 ns (Δ = +62069,381 ns)</td><td align="right" bgcolor="#FF4949">949976,747 ns (Δ = +64557,925 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">904,794 μs</td><td align="right" bgcolor="#FFFFFF">865,239 μs</td><td align="right" bgcolor="#FFFFFF">827,503 μs</td><td align="right" bgcolor="#FFFFFF">823,349 μs</td><td align="right" bgcolor="#FFFFFF">885,419 μs</td><td align="right" bgcolor="#FFFFFF">949,977 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,905 ms</td><td align="right" bgcolor="#FFFFFF">0,865 ms</td><td align="right" bgcolor="#FFFFFF">0,828 ms</td><td align="right" bgcolor="#FFFFFF">0,823 ms</td><td align="right" bgcolor="#FFFFFF">0,885 ms</td><td align="right" bgcolor="#FFFFFF">0,950 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">372,000</td><td align="right" bgcolor="#FFFFFF">372,000</td><td align="right" bgcolor="#FFFFFF">372,000</td><td align="right" bgcolor="#A8D08D">370,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">370,000</td><td align="right" bgcolor="#FF4949">495,000 (Δ = +125,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-0,7 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+33,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">312805,000</td><td align="right" bgcolor="#A8D08D">312774,000 (Δ = -31,000)</td><td align="right" bgcolor="#FF4949">312780,000 (Δ = +6,000)</td><td align="right" bgcolor="#A8D08D">310719,000 (Δ = -2061,000)</td><td align="right" bgcolor="#A8D08D">310701,000 (Δ = -18,000)</td><td align="right" bgcolor="#FF4949">415620,000 (Δ = +104919,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">305,474</td><td align="right" bgcolor="#A8D08D">305,443 (Δ = -0,030)</td><td align="right" bgcolor="#FF4949">305,449 (Δ = +0,006)</td><td align="right" bgcolor="#A8D08D">303,437 (Δ = -2,013)</td><td align="right" bgcolor="#A8D08D">303,419 (Δ = -0,018)</td><td align="right" bgcolor="#FF4949">405,879 (Δ = +102,460)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,298</td><td align="right" bgcolor="#A8D08D">0,298 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,298 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,396 (Δ = +0,100)</td></tr></table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 406367,261 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,2 %</td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#FF4949">+1,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12454335,301 ns</td><td align="right" bgcolor="#A8D08D">12308920,667 ns (Δ = -145414,635 ns)</td><td align="right" bgcolor="#A8D08D">12126930,012 ns (Δ = -181990,655 ns)</td><td align="right" bgcolor="#FF4949">12327926,363 ns (Δ = +200996,351 ns)</td><td align="right" bgcolor="#FFFFFF">12250876,051 ns</td><td align="right" bgcolor="#A8D08D">12047968,040 ns (Δ = -202908,011 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">12454,335 μs</td><td align="right" bgcolor="#FFFFFF">12308,921 μs</td><td align="right" bgcolor="#FFFFFF">12126,930 μs</td><td align="right" bgcolor="#FFFFFF">12327,926 μs</td><td align="right" bgcolor="#FFFFFF">12250,876 μs</td><td align="right" bgcolor="#FFFFFF">12047,968 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">12,454 ms</td><td align="right" bgcolor="#FFFFFF">12,309 ms</td><td align="right" bgcolor="#FFFFFF">12,127 ms</td><td align="right" bgcolor="#FFFFFF">12,328 ms</td><td align="right" bgcolor="#FFFFFF">12,251 ms</td><td align="right" bgcolor="#FFFFFF">12,048 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.5.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.5.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1827,000</td><td align="right" bgcolor="#A8D08D">1824,000 (Δ = -3,000)</td><td align="right" bgcolor="#A8D08D">1823,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">1824,000 (Δ = +1,000)</td><td align="right" bgcolor="#FF4949">1827,000 (Δ = +3,000)</td><td align="right" bgcolor="#FF4949">2024,000 (Δ = +197,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#FF4949">+10,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1533024,000</td><td align="right" bgcolor="#A8D08D">1530835,000 (Δ = -2189,000)</td><td align="right" bgcolor="#A8D08D">1529698,000 (Δ = -1137,000)</td><td align="right" bgcolor="#FF4949">1530809,000 (Δ = +1111,000)</td><td align="right" bgcolor="#FF4949">1532765,000 (Δ = +1956,000)</td><td align="right" bgcolor="#FF4949">1698807,000 (Δ = +166042,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1497,094</td><td align="right" bgcolor="#A8D08D">1494,956 (Δ = -2,138)</td><td align="right" bgcolor="#A8D08D">1493,846 (Δ = -1,110)</td><td align="right" bgcolor="#FF4949">1494,931 (Δ = +1,085)</td><td align="right" bgcolor="#FF4949">1496,841 (Δ = +1,910)</td><td align="right" bgcolor="#FF4949">1658,991 (Δ = +162,150)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,462</td><td align="right" bgcolor="#A8D08D">1,460 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">1,459 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">1,460 (Δ = +0,001)</td><td align="right" bgcolor="#FF4949">1,462 (Δ = +0,002)</td><td align="right" bgcolor="#FF4949">1,620 (Δ = +0,158)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 22783,496 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,7 %</td><td align="right" bgcolor="#A8D08D">-1,0 %</td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">701328,157 ns</td><td align="right" bgcolor="#FF4949">713545,803 ns (Δ = +12217,645 ns)</td><td align="right" bgcolor="#A8D08D">706405,504 ns (Δ = -7140,299 ns)</td><td align="right" bgcolor="#A8D08D">693572,092 ns (Δ = -12833,412 ns)</td><td align="right" bgcolor="#FFFFFF">690762,307 ns</td><td align="right" bgcolor="#FF4949">706446,549 ns (Δ = +15684,243 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">701,328 μs</td><td align="right" bgcolor="#FFFFFF">713,546 μs</td><td align="right" bgcolor="#FFFFFF">706,406 μs</td><td align="right" bgcolor="#FFFFFF">693,572 μs</td><td align="right" bgcolor="#FFFFFF">690,762 μs</td><td align="right" bgcolor="#FFFFFF">706,447 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,701 ms</td><td align="right" bgcolor="#FFFFFF">0,714 ms</td><td align="right" bgcolor="#FFFFFF">0,706 ms</td><td align="right" bgcolor="#FFFFFF">0,694 ms</td><td align="right" bgcolor="#FFFFFF">0,691 ms</td><td align="right" bgcolor="#FFFFFF">0,706 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#FFFFFF">102,000</td><td align="right" bgcolor="#A8D08D">101,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">101,000</td><td align="right" bgcolor="#FF4949">113,000 (Δ = +12,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,2 %</td><td align="right" bgcolor="#A8D08D">-1,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">86071,000</td><td align="right" bgcolor="#A8D08D">86032,000 (Δ = -39,000)</td><td align="right" bgcolor="#FF4949">86229,000 (Δ = +197,000)</td><td align="right" bgcolor="#A8D08D">85181,000 (Δ = -1048,000)</td><td align="right" bgcolor="#FFFFFF">85181,000</td><td align="right" bgcolor="#FF4949">95316,000 (Δ = +10135,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">84,054</td><td align="right" bgcolor="#A8D08D">84,016 (Δ = -0,038)</td><td align="right" bgcolor="#FF4949">84,208 (Δ = +0,192)</td><td align="right" bgcolor="#A8D08D">83,185 (Δ = -1,023)</td><td align="right" bgcolor="#FFFFFF">83,185</td><td align="right" bgcolor="#FF4949">93,082 (Δ = +9,897)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,082</td><td align="right" bgcolor="#A8D08D">0,082 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,082 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,081 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,081</td><td align="right" bgcolor="#FF4949">0,091 (Δ = +0,010)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 161654,088 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2182359,703 ns</td><td align="right" bgcolor="#FF4949">2322324,731 ns (Δ = +139965,028 ns)</td><td align="right" bgcolor="#A8D08D">2175104,133 ns (Δ = -147220,597 ns)</td><td align="right" bgcolor="#FFFFFF">2160670,643 ns</td><td align="right" bgcolor="#FFFFFF">2166775,027 ns</td><td align="right" bgcolor="#FFFFFF">2187553,040 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2182,360 μs</td><td align="right" bgcolor="#FFFFFF">2322,325 μs</td><td align="right" bgcolor="#FFFFFF">2175,104 μs</td><td align="right" bgcolor="#FFFFFF">2160,671 μs</td><td align="right" bgcolor="#FFFFFF">2166,775 μs</td><td align="right" bgcolor="#FFFFFF">2187,553 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,182 ms</td><td align="right" bgcolor="#FFFFFF">2,322 ms</td><td align="right" bgcolor="#FFFFFF">2,175 ms</td><td align="right" bgcolor="#FFFFFF">2,161 ms</td><td align="right" bgcolor="#FFFFFF">2,167 ms</td><td align="right" bgcolor="#FFFFFF">2,188 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.6.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">329,000</td><td align="right" bgcolor="#FFFFFF">329,000</td><td align="right" bgcolor="#FF4949">330,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">329,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">329,000</td><td align="right" bgcolor="#FF4949">367,000 (Δ = +38,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#A8D08D">-0,5 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+11,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">276737,000</td><td align="right" bgcolor="#A8D08D">276637,000 (Δ = -100,000)</td><td align="right" bgcolor="#FF4949">277653,000 (Δ = +1016,000)</td><td align="right" bgcolor="#A8D08D">276301,000 (Δ = -1352,000)</td><td align="right" bgcolor="#FF4949">276307,000 (Δ = +6,000)</td><td align="right" bgcolor="#FF4949">308459,000 (Δ = +32152,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">270,251</td><td align="right" bgcolor="#A8D08D">270,153 (Δ = -0,098)</td><td align="right" bgcolor="#FF4949">271,146 (Δ = +0,992)</td><td align="right" bgcolor="#A8D08D">269,825 (Δ = -1,320)</td><td align="right" bgcolor="#FF4949">269,831 (Δ = +0,006)</td><td align="right" bgcolor="#FF4949">301,229 (Δ = +31,398)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,264</td><td align="right" bgcolor="#A8D08D">0,264 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,265 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,264 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,264 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,294 (Δ = +0,031)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 184239,563 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#FF4949">+1,9 %</td><td align="right" bgcolor="#A8D08D">-1,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9647170,032 ns</td><td align="right" bgcolor="#A8D08D">9506701,707 ns (Δ = -140468,325 ns)</td><td align="right" bgcolor="#FF4949">9690941,269 ns (Δ = +184239,563 ns)</td><td align="right" bgcolor="#A8D08D">9560428,763 ns (Δ = -130512,507 ns)</td><td align="right" bgcolor="#FFFFFF">9545061,269 ns</td><td align="right" bgcolor="#FFFFFF">9629392,600 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9647,170 μs</td><td align="right" bgcolor="#FFFFFF">9506,702 μs</td><td align="right" bgcolor="#FFFFFF">9690,941 μs</td><td align="right" bgcolor="#FFFFFF">9560,429 μs</td><td align="right" bgcolor="#FFFFFF">9545,061 μs</td><td align="right" bgcolor="#FFFFFF">9629,393 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">9,647 ms</td><td align="right" bgcolor="#FFFFFF">9,507 ms</td><td align="right" bgcolor="#FFFFFF">9,691 ms</td><td align="right" bgcolor="#FFFFFF">9,560 ms</td><td align="right" bgcolor="#FFFFFF">9,545 ms</td><td align="right" bgcolor="#FFFFFF">9,629 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1468,000</td><td align="right" bgcolor="#FF4949">1469,000 (Δ = +1,000)</td><td align="right" bgcolor="#FF4949">1474,000 (Δ = +5,000)</td><td align="right" bgcolor="#A8D08D">1470,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">1470,000</td><td align="right" bgcolor="#FF4949">1659,000 (Δ = +189,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+12,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1232315,000</td><td align="right" bgcolor="#FF4949">1232529,000 (Δ = +214,000)</td><td align="right" bgcolor="#FF4949">1236931,000 (Δ = +4402,000)</td><td align="right" bgcolor="#A8D08D">1233785,000 (Δ = -3146,000)</td><td align="right" bgcolor="#A8D08D">1233777,000 (Δ = -8,000)</td><td align="right" bgcolor="#FF4949">1392087,000 (Δ = +158310,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1203,433</td><td align="right" bgcolor="#FF4949">1203,642 (Δ = +0,209)</td><td align="right" bgcolor="#FF4949">1207,940 (Δ = +4,299)</td><td align="right" bgcolor="#A8D08D">1204,868 (Δ = -3,072)</td><td align="right" bgcolor="#A8D08D">1204,860 (Δ = -0,008)</td><td align="right" bgcolor="#FF4949">1359,460 (Δ = +154,600)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,175</td><td align="right" bgcolor="#FF4949">1,175 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">1,180 (Δ = +0,004)</td><td align="right" bgcolor="#A8D08D">1,177 (Δ = -0,003)</td><td align="right" bgcolor="#A8D08D">1,177 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">1,328 (Δ = +0,151)</td></tr></table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 399818,965 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,5 %</td><td align="right" bgcolor="#A8D08D">-5,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">858393,731 ns</td><td align="right" bgcolor="#FF4949">922399,235 ns (Δ = +64005,504 ns)</td><td align="right" bgcolor="#A8D08D">870904,968 ns (Δ = -51494,267 ns)</td><td align="right" bgcolor="#FFFFFF">878143,341 ns</td><td align="right" bgcolor="#FFFFFF">873103,501 ns</td><td align="right" bgcolor="#A8D08D">522580,269 ns (Δ = -350523,232 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">858,394 μs</td><td align="right" bgcolor="#FFFFFF">922,399 μs</td><td align="right" bgcolor="#FFFFFF">870,905 μs</td><td align="right" bgcolor="#FFFFFF">878,143 μs</td><td align="right" bgcolor="#FFFFFF">873,104 μs</td><td align="right" bgcolor="#A8D08D">522,580 μs (Δ = -350,523 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,858 ms</td><td align="right" bgcolor="#FFFFFF">0,922 ms</td><td align="right" bgcolor="#FFFFFF">0,871 ms</td><td align="right" bgcolor="#FFFFFF">0,878 ms</td><td align="right" bgcolor="#FFFFFF">0,873 ms</td><td align="right" bgcolor="#FFFFFF">0,523 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.6.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">692,000</td><td align="right" bgcolor="#FFFFFF">692,000</td><td align="right" bgcolor="#FFFFFF">692,000</td><td align="right" bgcolor="#FF4949">700,000 (Δ = +8,000)</td><td align="right" bgcolor="#FFFFFF">700,000</td><td align="right" bgcolor="#A8D08D">155,000 (Δ = -545,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+1,3 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-77,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">582270,000</td><td align="right" bgcolor="#FF4949">582293,000 (Δ = +23,000)</td><td align="right" bgcolor="#A8D08D">582267,000 (Δ = -26,000)</td><td align="right" bgcolor="#FF4949">589597,000 (Δ = +7330,000)</td><td align="right" bgcolor="#FF4949">589617,000 (Δ = +20,000)</td><td align="right" bgcolor="#A8D08D">130764,000 (Δ = -458853,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">568,623</td><td align="right" bgcolor="#FF4949">568,646 (Δ = +0,022)</td><td align="right" bgcolor="#A8D08D">568,620 (Δ = -0,025)</td><td align="right" bgcolor="#FF4949">575,778 (Δ = +7,158)</td><td align="right" bgcolor="#FF4949">575,798 (Δ = +0,020)</td><td align="right" bgcolor="#A8D08D">127,699 (Δ = -448,099)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,555</td><td align="right" bgcolor="#FF4949">0,555 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,555 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,562 (Δ = +0,007)</td><td align="right" bgcolor="#FF4949">0,562 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,125 (Δ = -0,438)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 108883,125 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,8 %</td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,6 %</td><td align="right" bgcolor="#A8D08D">-27,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">345658,235 ns</td><td align="right" bgcolor="#A8D08D">304877,837 ns (Δ = -40780,397 ns)</td><td align="right" bgcolor="#A8D08D">294079,179 ns (Δ = -10798,659 ns)</td><td align="right" bgcolor="#FFFFFF">294356,352 ns</td><td align="right" bgcolor="#FF4949">325591,581 ns (Δ = +31235,229 ns)</td><td align="right" bgcolor="#A8D08D">236775,109 ns (Δ = -88816,472 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">345,658 μs</td><td align="right" bgcolor="#FFFFFF">304,878 μs</td><td align="right" bgcolor="#FFFFFF">294,079 μs</td><td align="right" bgcolor="#FFFFFF">294,356 μs</td><td align="right" bgcolor="#FFFFFF">325,592 μs</td><td align="right" bgcolor="#FFFFFF">236,775 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,346 ms</td><td align="right" bgcolor="#FFFFFF">0,305 ms</td><td align="right" bgcolor="#FFFFFF">0,294 ms</td><td align="right" bgcolor="#FFFFFF">0,294 ms</td><td align="right" bgcolor="#FFFFFF">0,326 ms</td><td align="right" bgcolor="#FFFFFF">0,237 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">163,000</td><td align="right" bgcolor="#FFFFFF">163,000</td><td align="right" bgcolor="#FFFFFF">163,000</td><td align="right" bgcolor="#FFFFFF">163,000</td><td align="right" bgcolor="#FFFFFF">163,000</td><td align="right" bgcolor="#A8D08D">48,000 (Δ = -115,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">-70,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">137639,000</td><td align="right" bgcolor="#A8D08D">137628,000 (Δ = -11,000)</td><td align="right" bgcolor="#A8D08D">137611,000 (Δ = -17,000)</td><td align="right" bgcolor="#FF4949">137799,000 (Δ = +188,000)</td><td align="right" bgcolor="#FF4949">137921,000 (Δ = +122,000)</td><td align="right" bgcolor="#A8D08D">40775,000 (Δ = -97146,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">134,413</td><td align="right" bgcolor="#A8D08D">134,402 (Δ = -0,011)</td><td align="right" bgcolor="#A8D08D">134,386 (Δ = -0,017)</td><td align="right" bgcolor="#FF4949">134,569 (Δ = +0,184)</td><td align="right" bgcolor="#FF4949">134,688 (Δ = +0,119)</td><td align="right" bgcolor="#A8D08D">39,819 (Δ = -94,869)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,131</td><td align="right" bgcolor="#A8D08D">0,131 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,131 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,131 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,132 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,039 (Δ = -0,093)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 201847,325 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,5 %</td><td align="right" bgcolor="#A8D08D">-35,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">545465,983 ns</td><td align="right" bgcolor="#FFFFFF">543265,789 ns</td><td align="right" bgcolor="#FF4949">561006,456 ns (Δ = +17740,667 ns)</td><td align="right" bgcolor="#FFFFFF">563277,029 ns</td><td align="right" bgcolor="#FF4949">577122,165 ns (Δ = +13845,136 ns)</td><td align="right" bgcolor="#A8D08D">375274,840 ns (Δ = -201847,325 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">545,466 μs</td><td align="right" bgcolor="#FFFFFF">543,266 μs</td><td align="right" bgcolor="#FFFFFF">561,006 μs</td><td align="right" bgcolor="#FFFFFF">563,277 μs</td><td align="right" bgcolor="#FFFFFF">577,122 μs</td><td align="right" bgcolor="#FFFFFF">375,275 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,545 ms</td><td align="right" bgcolor="#FFFFFF">0,543 ms</td><td align="right" bgcolor="#FFFFFF">0,561 ms</td><td align="right" bgcolor="#FFFFFF">0,563 ms</td><td align="right" bgcolor="#FFFFFF">0,577 ms</td><td align="right" bgcolor="#FFFFFF">0,375 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.6.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#A8D08D">513,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">520,000 (Δ = +7,000)</td><td align="right" bgcolor="#FFFFFF">520,000</td><td align="right" bgcolor="#A8D08D">103,000 (Δ = -417,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+1,2 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-80,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">433019,000</td><td align="right" bgcolor="#FF4949">433083,000 (Δ = +64,000)</td><td align="right" bgcolor="#A8D08D">432984,000 (Δ = -99,000)</td><td align="right" bgcolor="#FF4949">437981,000 (Δ = +4997,000)</td><td align="right" bgcolor="#FF4949">437998,000 (Δ = +17,000)</td><td align="right" bgcolor="#A8D08D">86530,000 (Δ = -351468,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">422,870</td><td align="right" bgcolor="#FF4949">422,933 (Δ = +0,063)</td><td align="right" bgcolor="#A8D08D">422,836 (Δ = -0,097)</td><td align="right" bgcolor="#FF4949">427,716 (Δ = +4,880)</td><td align="right" bgcolor="#FF4949">427,732 (Δ = +0,017)</td><td align="right" bgcolor="#A8D08D">84,502 (Δ = -343,230)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,413</td><td align="right" bgcolor="#FF4949">0,413 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,413 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,418 (Δ = +0,005)</td><td align="right" bgcolor="#FF4949">0,418 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,083 (Δ = -0,335)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 963917,440 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,5 %</td><td align="right" bgcolor="#FF4949">+1,1 %</td><td align="right" bgcolor="#FF4949">+6,1 %</td><td align="right" bgcolor="#FF4949">+1,4 %</td><td align="right" bgcolor="#A8D08D">-50,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1785091,136 ns</td><td align="right" bgcolor="#A8D08D">1757975,263 ns (Δ = -27115,873 ns)</td><td align="right" bgcolor="#FF4949">1776562,024 ns (Δ = +18586,761 ns)</td><td align="right" bgcolor="#FF4949">1884138,696 ns (Δ = +107576,672 ns)</td><td align="right" bgcolor="#FF4949">1910354,083 ns (Δ = +26215,387 ns)</td><td align="right" bgcolor="#A8D08D">946436,643 ns (Δ = -963917,440 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1785,091 μs</td><td align="right" bgcolor="#FFFFFF">1757,975 μs</td><td align="right" bgcolor="#FFFFFF">1776,562 μs</td><td align="right" bgcolor="#FFFFFF">1884,139 μs</td><td align="right" bgcolor="#FFFFFF">1910,354 μs</td><td align="right" bgcolor="#A8D08D">946,437 μs (Δ = -963,917 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,785 ms</td><td align="right" bgcolor="#FFFFFF">1,758 ms</td><td align="right" bgcolor="#FFFFFF">1,777 ms</td><td align="right" bgcolor="#FFFFFF">1,884 ms</td><td align="right" bgcolor="#FFFFFF">1,910 ms</td><td align="right" bgcolor="#FFFFFF">0,946 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.6.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.6.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2271,000</td><td align="right" bgcolor="#A8D08D">2270,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">2270,000</td><td align="right" bgcolor="#FF4949">2301,000 (Δ = +31,000)</td><td align="right" bgcolor="#FFFFFF">2301,000</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -1932,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+1,4 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-84,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1909353,000</td><td align="right" bgcolor="#A8D08D">1909141,000 (Δ = -212,000)</td><td align="right" bgcolor="#FF4949">1909304,000 (Δ = +163,000)</td><td align="right" bgcolor="#FF4949">1935435,000 (Δ = +26131,000)</td><td align="right" bgcolor="#A8D08D">1935218,000 (Δ = -217,000)</td><td align="right" bgcolor="#A8D08D">310241,000 (Δ = -1624977,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1864,603</td><td align="right" bgcolor="#A8D08D">1864,396 (Δ = -0,207)</td><td align="right" bgcolor="#FF4949">1864,555 (Δ = +0,159)</td><td align="right" bgcolor="#FF4949">1890,073 (Δ = +25,519)</td><td align="right" bgcolor="#A8D08D">1889,861 (Δ = -0,212)</td><td align="right" bgcolor="#A8D08D">302,970 (Δ = -1586,892)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,821</td><td align="right" bgcolor="#A8D08D">1,821 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">1,821 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">1,846 (Δ = +0,025)</td><td align="right" bgcolor="#A8D08D">1,846 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -1,550)</td></tr></table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 191,251 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">735,053 ns</td><td align="right" bgcolor="#FFFFFF">744,500 ns</td><td align="right" bgcolor="#FFFFFF">859,573 ns</td><td align="right" bgcolor="#FFFFFF">750,844 ns</td><td align="right" bgcolor="#FFFFFF">668,323 ns</td><td align="right" bgcolor="#FFFFFF">796,920 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,735 μs</td><td align="right" bgcolor="#FFFFFF">0,745 μs</td><td align="right" bgcolor="#FFFFFF">0,860 μs</td><td align="right" bgcolor="#FFFFFF">0,751 μs</td><td align="right" bgcolor="#FFFFFF">0,668 μs</td><td align="right" bgcolor="#FFFFFF">0,797 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">957,000</td><td align="right" bgcolor="#FFFFFF">957,000</td><td align="right" bgcolor="#FFFFFF">957,000</td><td align="right" bgcolor="#FFFFFF">957,000</td><td align="right" bgcolor="#A8D08D">875,000 (Δ = -82,000)</td><td align="right" bgcolor="#FFFFFF">875,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,935</td><td align="right" bgcolor="#FFFFFF">0,935</td><td align="right" bgcolor="#FFFFFF">0,935</td><td align="right" bgcolor="#FFFFFF">0,935</td><td align="right" bgcolor="#A8D08D">0,854 (Δ = -0,080)</td><td align="right" bgcolor="#FFFFFF">0,854</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 24,395 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">151,573 ns</td><td align="right" bgcolor="#FFFFFF">155,360 ns</td><td align="right" bgcolor="#FFFFFF">152,165 ns</td><td align="right" bgcolor="#FFFFFF">136,837 ns</td><td align="right" bgcolor="#FFFFFF">132,423 ns</td><td align="right" bgcolor="#FFFFFF">130,965 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,152 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,152 μs</td><td align="right" bgcolor="#FFFFFF">0,137 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Transient"></a>ResolveType_Transient

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 188,701 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2390,384 ns</td><td align="right" bgcolor="#FFFFFF">2555,032 ns</td><td align="right" bgcolor="#FFFFFF">2385,832 ns</td><td align="right" bgcolor="#FFFFFF">2574,533 ns</td><td align="right" bgcolor="#FFFFFF">2434,339 ns</td><td align="right" bgcolor="#FFFFFF">2456,064 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,390 μs</td><td align="right" bgcolor="#FFFFFF">2,555 μs</td><td align="right" bgcolor="#FFFFFF">2,386 μs</td><td align="right" bgcolor="#FFFFFF">2,575 μs</td><td align="right" bgcolor="#FFFFFF">2,434 μs</td><td align="right" bgcolor="#FFFFFF">2,456 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1461,000</td><td align="right" bgcolor="#A8D08D">1454,000 (Δ = -7,000)</td><td align="right" bgcolor="#FFFFFF">1454,000</td><td align="right" bgcolor="#FFFFFF">1454,000</td><td align="right" bgcolor="#FFFFFF">1454,000</td><td align="right" bgcolor="#FF4949">1727,000 (Δ = +273,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,427</td><td align="right" bgcolor="#A8D08D">1,420 (Δ = -0,007)</td><td align="right" bgcolor="#FFFFFF">1,420</td><td align="right" bgcolor="#FFFFFF">1,420</td><td align="right" bgcolor="#FFFFFF">1,420</td><td align="right" bgcolor="#FF4949">1,687 (Δ = +0,267)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 31,112 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">150,341 ns</td><td align="right" bgcolor="#FFFFFF">141,608 ns</td><td align="right" bgcolor="#FFFFFF">164,341 ns</td><td align="right" bgcolor="#FFFFFF">135,301 ns</td><td align="right" bgcolor="#FFFFFF">135,523 ns</td><td align="right" bgcolor="#FFFFFF">133,229 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,150 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,164 μs</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency"></a>ResolveType_With_Transient_Dependency

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 241,795 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4712,779 ns</td><td align="right" bgcolor="#FFFFFF">4884,224 ns</td><td align="right" bgcolor="#FFFFFF">4791,331 ns</td><td align="right" bgcolor="#FFFFFF">4954,573 ns</td><td align="right" bgcolor="#FFFFFF">4743,781 ns</td><td align="right" bgcolor="#FFFFFF">4924,712 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,713 μs</td><td align="right" bgcolor="#FFFFFF">4,884 μs</td><td align="right" bgcolor="#FFFFFF">4,791 μs</td><td align="right" bgcolor="#FFFFFF">4,955 μs</td><td align="right" bgcolor="#FFFFFF">4,744 μs</td><td align="right" bgcolor="#FFFFFF">4,925 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.6.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#FF4949">+17,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3063,000</td><td align="right" bgcolor="#A8D08D">3047,000 (Δ = -16,000)</td><td align="right" bgcolor="#FFFFFF">3047,000</td><td align="right" bgcolor="#FFFFFF">3047,000</td><td align="right" bgcolor="#FF4949">3050,000 (Δ = +3,000)</td><td align="right" bgcolor="#FF4949">3595,000 (Δ = +545,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,991</td><td align="right" bgcolor="#A8D08D">2,976 (Δ = -0,016)</td><td align="right" bgcolor="#FFFFFF">2,976</td><td align="right" bgcolor="#FFFFFF">2,976</td><td align="right" bgcolor="#FF4949">2,979 (Δ = +0,003)</td><td align="right" bgcolor="#FF4949">3,511 (Δ = +0,532)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,001)</td></tr></table>


## <a name="TagHelper_Benchmark"></a>TagHelper_Benchmark

### <a name="TagHelper_Benchmark_AreTagsEqual"></a>AreTagsEqual

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 3,644 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,812 ns</td><td align="right" bgcolor="#FFFFFF">5,247 ns</td><td align="right" bgcolor="#FFFFFF">6,245 ns</td><td align="right" bgcolor="#FFFFFF">6,067 ns</td><td align="right" bgcolor="#FFFFFF">6,464 ns</td><td align="right" bgcolor="#FFFFFF">8,891 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TagHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 12643,595 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,5 %</td><td align="right" bgcolor="#A8D08D">-3,7 %</td><td align="right" bgcolor="#FF4949">+5,4 %</td><td align="right" bgcolor="#A8D08D">-95,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12518,848 ns</td><td align="right" bgcolor="#FF4949">13078,983 ns (Δ = +560,135 ns)</td><td align="right" bgcolor="#A8D08D">12597,109 ns (Δ = -481,873 ns)</td><td align="right" bgcolor="#FF4949">13275,781 ns (Δ = +678,672 ns)</td><td align="right" bgcolor="#A8D08D">632,187 ns (Δ = -12643,595 ns)</td><td align="right" bgcolor="#FFFFFF">650,409 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">12,519 μs</td><td align="right" bgcolor="#FFFFFF">13,079 μs</td><td align="right" bgcolor="#FFFFFF">12,597 μs</td><td align="right" bgcolor="#FFFFFF">13,276 μs</td><td align="right" bgcolor="#FFFFFF">0,632 μs</td><td align="right" bgcolor="#FFFFFF">0,650 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-97,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">11025,000</td><td align="right" bgcolor="#A8D08D">10993,000 (Δ = -32,000)</td><td align="right" bgcolor="#FFFFFF">10993,000</td><td align="right" bgcolor="#FFFFFF">10993,000</td><td align="right" bgcolor="#A8D08D">282,000 (Δ = -10711,000)</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">10,767</td><td align="right" bgcolor="#A8D08D">10,735 (Δ = -0,031)</td><td align="right" bgcolor="#FFFFFF">10,735</td><td align="right" bgcolor="#FFFFFF">10,735</td><td align="right" bgcolor="#A8D08D">0,275 (Δ = -10,460)</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,011</td><td align="right" bgcolor="#A8D08D">0,010 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,010)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 6,323 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,528 ns</td><td align="right" bgcolor="#FFFFFF">18,139 ns</td><td align="right" bgcolor="#FFFFFF">24,461 ns</td><td align="right" bgcolor="#FFFFFF">21,488 ns</td><td align="right" bgcolor="#FFFFFF">18,509 ns</td><td align="right" bgcolor="#FFFFFF">21,645 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyEx"></a>GetAssemblyEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 6,867 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,891 ns</td><td align="right" bgcolor="#FFFFFF">15,925 ns</td><td align="right" bgcolor="#FFFFFF">20,821 ns</td><td align="right" bgcolor="#FFFFFF">14,723 ns</td><td align="right" bgcolor="#FFFFFF">14,929 ns</td><td align="right" bgcolor="#FFFFFF">13,955 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx"></a>GetAssemblyFullNameEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 8,880 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,701 ns</td><td align="right" bgcolor="#FFFFFF">18,381 ns</td><td align="right" bgcolor="#FFFFFF">25,235 ns</td><td align="right" bgcolor="#FFFFFF">17,237 ns</td><td align="right" bgcolor="#FFFFFF">18,128 ns</td><td align="right" bgcolor="#FFFFFF">16,355 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetBaseTypeEx"></a>GetBaseTypeEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 1,072 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,685 ns</td><td align="right" bgcolor="#FFFFFF">20,048 ns</td><td align="right" bgcolor="#FFFFFF">19,192 ns</td><td align="right" bgcolor="#FFFFFF">19,472 ns</td><td align="right" bgcolor="#FFFFFF">19,451 ns</td><td align="right" bgcolor="#FFFFFF">18,976 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorEx"></a>GetConstructorEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 30,632 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">190,611 ns</td><td align="right" bgcolor="#FFFFFF">201,328 ns</td><td align="right" bgcolor="#FFFFFF">199,141 ns</td><td align="right" bgcolor="#FFFFFF">207,939 ns</td><td align="right" bgcolor="#FFFFFF">218,899 ns</td><td align="right" bgcolor="#FFFFFF">188,267 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,191 μs</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FFFFFF">0,199 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorsEx"></a>GetConstructorsEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 8,216 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">56,893 ns</td><td align="right" bgcolor="#FFFFFF">60,115 ns</td><td align="right" bgcolor="#FFFFFF">65,109 ns</td><td align="right" bgcolor="#FFFFFF">62,779 ns</td><td align="right" bgcolor="#FFFFFF">60,440 ns</td><td align="right" bgcolor="#FFFFFF">59,467 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,060 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,060 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 145,353 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1884,917 ns</td><td align="right" bgcolor="#FFFFFF">1945,117 ns</td><td align="right" bgcolor="#FFFFFF">1835,093 ns</td><td align="right" bgcolor="#FFFFFF">1949,016 ns</td><td align="right" bgcolor="#FFFFFF">1803,663 ns</td><td align="right" bgcolor="#FFFFFF">1838,837 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,885 μs</td><td align="right" bgcolor="#FFFFFF">1,945 μs</td><td align="right" bgcolor="#FFFFFF">1,835 μs</td><td align="right" bgcolor="#FFFFFF">1,949 μs</td><td align="right" bgcolor="#FFFFFF">1,804 μs</td><td align="right" bgcolor="#FFFFFF">1,839 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 542,547 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6053,883 ns</td><td align="right" bgcolor="#FFFFFF">6239,053 ns</td><td align="right" bgcolor="#FFFFFF">6028,579 ns</td><td align="right" bgcolor="#FFFFFF">6134,645 ns</td><td align="right" bgcolor="#A8D08D">5696,507 ns (Δ = -438,139 ns)</td><td align="right" bgcolor="#FFFFFF">5813,128 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,054 μs</td><td align="right" bgcolor="#FFFFFF">6,239 μs</td><td align="right" bgcolor="#FFFFFF">6,029 μs</td><td align="right" bgcolor="#FFFFFF">6,135 μs</td><td align="right" bgcolor="#FFFFFF">5,697 μs</td><td align="right" bgcolor="#FFFFFF">5,813 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">813,000</td><td align="right" bgcolor="#FFFFFF">813,000</td><td align="right" bgcolor="#FFFFFF">813,000</td><td align="right" bgcolor="#FFFFFF">813,000</td><td align="right" bgcolor="#FFFFFF">813,000</td><td align="right" bgcolor="#FFFFFF">813,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,794</td><td align="right" bgcolor="#FFFFFF">0,794</td><td align="right" bgcolor="#FFFFFF">0,794</td><td align="right" bgcolor="#FFFFFF">0,794</td><td align="right" bgcolor="#FFFFFF">0,794</td><td align="right" bgcolor="#FFFFFF">0,794</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 125,635 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1862,365 ns</td><td align="right" bgcolor="#FFFFFF">1901,067 ns</td><td align="right" bgcolor="#FFFFFF">1837,853 ns</td><td align="right" bgcolor="#FFFFFF">1948,277 ns</td><td align="right" bgcolor="#FFFFFF">1850,685 ns</td><td align="right" bgcolor="#FFFFFF">1822,643 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,862 μs</td><td align="right" bgcolor="#FFFFFF">1,901 μs</td><td align="right" bgcolor="#FFFFFF">1,838 μs</td><td align="right" bgcolor="#FFFFFF">1,948 μs</td><td align="right" bgcolor="#FFFFFF">1,851 μs</td><td align="right" bgcolor="#FFFFFF">1,823 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 568,193 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6080,136 ns</td><td align="right" bgcolor="#FFFFFF">6012,509 ns</td><td align="right" bgcolor="#FF4949">6340,971 ns (Δ = +328,461 ns)</td><td align="right" bgcolor="#FFFFFF">6123,128 ns</td><td align="right" bgcolor="#A8D08D">5772,777 ns (Δ = -350,351 ns)</td><td align="right" bgcolor="#FFFFFF">5903,517 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,080 μs</td><td align="right" bgcolor="#FFFFFF">6,013 μs</td><td align="right" bgcolor="#FFFFFF">6,341 μs</td><td align="right" bgcolor="#FFFFFF">6,123 μs</td><td align="right" bgcolor="#FFFFFF">5,773 μs</td><td align="right" bgcolor="#FFFFFF">5,904 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">813,000</td><td align="right" bgcolor="#FFFFFF">813,000</td><td align="right" bgcolor="#FFFFFF">813,000</td><td align="right" bgcolor="#FFFFFF">813,000</td><td align="right" bgcolor="#FFFFFF">813,000</td><td align="right" bgcolor="#FFFFFF">813,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,794</td><td align="right" bgcolor="#FFFFFF">0,794</td><td align="right" bgcolor="#FFFFFF">0,794</td><td align="right" bgcolor="#FFFFFF">0,794</td><td align="right" bgcolor="#FFFFFF">0,794</td><td align="right" bgcolor="#FFFFFF">0,794</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 0,475 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,003 ns</td><td align="right" bgcolor="#FFFFFF">4,731 ns</td><td align="right" bgcolor="#FFFFFF">4,528 ns</td><td align="right" bgcolor="#FFFFFF">4,540 ns</td><td align="right" bgcolor="#FFFFFF">4,741 ns</td><td align="right" bgcolor="#FFFFFF">4,680 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 190,203 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">510,499 ns</td><td align="right" bgcolor="#FFFFFF">646,563 ns</td><td align="right" bgcolor="#FFFFFF">463,243 ns</td><td align="right" bgcolor="#FFFFFF">495,272 ns</td><td align="right" bgcolor="#FFFFFF">456,360 ns</td><td align="right" bgcolor="#FFFFFF">515,371 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,510 μs</td><td align="right" bgcolor="#FFFFFF">0,647 μs</td><td align="right" bgcolor="#FFFFFF">0,463 μs</td><td align="right" bgcolor="#FFFFFF">0,495 μs</td><td align="right" bgcolor="#FFFFFF">0,456 μs</td><td align="right" bgcolor="#FFFFFF">0,515 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FF4949">243,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FF4949">0,237 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Instance"></a>GetEventEx_Instance

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 15,877 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">90,800 ns</td><td align="right" bgcolor="#FFFFFF">79,885 ns</td><td align="right" bgcolor="#FFFFFF">77,571 ns</td><td align="right" bgcolor="#FFFFFF">86,453 ns</td><td align="right" bgcolor="#FFFFFF">75,183 ns</td><td align="right" bgcolor="#FFFFFF">74,923 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 548,571 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,5 %</td><td align="right" bgcolor="#A8D08D">-19,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1943,851 ns</td><td align="right" bgcolor="#FFFFFF">1909,427 ns</td><td align="right" bgcolor="#FFFFFF">1965,864 ns</td><td align="right" bgcolor="#FFFFFF">2039,045 ns</td><td align="right" bgcolor="#FF4949">2457,997 ns (Δ = +418,952 ns)</td><td align="right" bgcolor="#A8D08D">1975,152 ns (Δ = -482,845 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,944 μs</td><td align="right" bgcolor="#FFFFFF">1,909 μs</td><td align="right" bgcolor="#FFFFFF">1,966 μs</td><td align="right" bgcolor="#FFFFFF">2,039 μs</td><td align="right" bgcolor="#FFFFFF">2,458 μs</td><td align="right" bgcolor="#FFFFFF">1,975 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.6.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,0 %</td><td align="right" bgcolor="#FF4949">+268,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FF4949">206,000 (Δ = +6,000)</td><td align="right" bgcolor="#FF4949">760,000 (Δ = +554,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FF4949">0,201 (Δ = +0,006)</td><td align="right" bgcolor="#FF4949">0,742 (Δ = +0,541)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 42,480 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">703,800 ns</td><td align="right" bgcolor="#FFFFFF">701,256 ns</td><td align="right" bgcolor="#FFFFFF">725,680 ns</td><td align="right" bgcolor="#FFFFFF">721,349 ns</td><td align="right" bgcolor="#FFFFFF">683,200 ns</td><td align="right" bgcolor="#FFFFFF">697,629 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,704 μs</td><td align="right" bgcolor="#FFFFFF">0,701 μs</td><td align="right" bgcolor="#FFFFFF">0,726 μs</td><td align="right" bgcolor="#FFFFFF">0,721 μs</td><td align="right" bgcolor="#FFFFFF">0,683 μs</td><td align="right" bgcolor="#FFFFFF">0,698 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">400,000</td><td align="right" bgcolor="#FFFFFF">400,000</td><td align="right" bgcolor="#FFFFFF">400,000</td><td align="right" bgcolor="#FFFFFF">400,000</td><td align="right" bgcolor="#FFFFFF">400,000</td><td align="right" bgcolor="#FFFFFF">400,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,391</td><td align="right" bgcolor="#FFFFFF">0,391</td><td align="right" bgcolor="#FFFFFF">0,391</td><td align="right" bgcolor="#FFFFFF">0,391</td><td align="right" bgcolor="#FFFFFF">0,391</td><td align="right" bgcolor="#FFFFFF">0,391</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 31,845 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">313,600 ns</td><td align="right" bgcolor="#FFFFFF">308,173 ns</td><td align="right" bgcolor="#FFFFFF">288,317 ns</td><td align="right" bgcolor="#FFFFFF">294,419 ns</td><td align="right" bgcolor="#FFFFFF">307,031 ns</td><td align="right" bgcolor="#FFFFFF">281,755 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,314 μs</td><td align="right" bgcolor="#FFFFFF">0,308 μs</td><td align="right" bgcolor="#FFFFFF">0,288 μs</td><td align="right" bgcolor="#FFFFFF">0,294 μs</td><td align="right" bgcolor="#FFFFFF">0,307 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">301,000</td><td align="right" bgcolor="#FFFFFF">301,000</td><td align="right" bgcolor="#FFFFFF">301,000</td><td align="right" bgcolor="#FFFFFF">301,000</td><td align="right" bgcolor="#FFFFFF">301,000</td><td align="right" bgcolor="#FFFFFF">301,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,294</td><td align="right" bgcolor="#FFFFFF">0,294</td><td align="right" bgcolor="#FFFFFF">0,294</td><td align="right" bgcolor="#FFFFFF">0,294</td><td align="right" bgcolor="#FFFFFF">0,294</td><td align="right" bgcolor="#FFFFFF">0,294</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 18,637 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">494,160 ns</td><td align="right" bgcolor="#FFFFFF">480,309 ns</td><td align="right" bgcolor="#FFFFFF">477,611 ns</td><td align="right" bgcolor="#FFFFFF">496,248 ns</td><td align="right" bgcolor="#FFFFFF">482,949 ns</td><td align="right" bgcolor="#FFFFFF">482,701 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,494 μs</td><td align="right" bgcolor="#FFFFFF">0,480 μs</td><td align="right" bgcolor="#FFFFFF">0,478 μs</td><td align="right" bgcolor="#FFFFFF">0,496 μs</td><td align="right" bgcolor="#FFFFFF">0,483 μs</td><td align="right" bgcolor="#FFFFFF">0,483 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FF4949">243,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FF4949">0,237 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags"></a>GetFieldEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.4.0

Δ: 17,891 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">81,585 ns</td><td align="right" bgcolor="#FFFFFF">84,947 ns</td><td align="right" bgcolor="#FFFFFF">81,429 ns</td><td align="right" bgcolor="#FFFFFF">78,733 ns</td><td align="right" bgcolor="#FFFFFF">72,115 ns</td><td align="right" bgcolor="#FFFFFF">67,056 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 14,365 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">87,867 ns</td><td align="right" bgcolor="#FFFFFF">89,144 ns</td><td align="right" bgcolor="#FFFFFF">89,000 ns</td><td align="right" bgcolor="#FFFFFF">95,056 ns</td><td align="right" bgcolor="#FFFFFF">82,359 ns</td><td align="right" bgcolor="#FFFFFF">80,691 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,089 μs</td><td align="right" bgcolor="#FFFFFF">0,089 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 76,753 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">144,896 ns</td><td align="right" bgcolor="#FFFFFF">80,573 ns</td><td align="right" bgcolor="#FFFFFF">85,048 ns</td><td align="right" bgcolor="#FFFFFF">82,547 ns</td><td align="right" bgcolor="#FFFFFF">68,143 ns</td><td align="right" bgcolor="#FFFFFF">72,739 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 32,155 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">408,701 ns</td><td align="right" bgcolor="#FFFFFF">429,725 ns</td><td align="right" bgcolor="#FFFFFF">400,099 ns</td><td align="right" bgcolor="#FFFFFF">425,480 ns</td><td align="right" bgcolor="#FFFFFF">397,571 ns</td><td align="right" bgcolor="#FFFFFF">423,781 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,409 μs</td><td align="right" bgcolor="#FFFFFF">0,430 μs</td><td align="right" bgcolor="#FFFFFF">0,400 μs</td><td align="right" bgcolor="#FFFFFF">0,425 μs</td><td align="right" bgcolor="#FFFFFF">0,398 μs</td><td align="right" bgcolor="#FFFFFF">0,424 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.0.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">315,000</td><td align="right" bgcolor="#FF4949">347,000 (Δ = +32,000)</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FF4949">364,000 (Δ = +17,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,308</td><td align="right" bgcolor="#FF4949">0,339 (Δ = +0,031)</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FF4949">0,355 (Δ = +0,017)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 11,616 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">69,448 ns</td><td align="right" bgcolor="#FFFFFF">75,339 ns</td><td align="right" bgcolor="#FFFFFF">75,101 ns</td><td align="right" bgcolor="#FFFFFF">81,064 ns</td><td align="right" bgcolor="#FFFFFF">73,283 ns</td><td align="right" bgcolor="#FFFFFF">74,675 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 174,645 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">617,901 ns</td><td align="right" bgcolor="#FFFFFF">652,272 ns</td><td align="right" bgcolor="#FFFFFF">672,360 ns</td><td align="right" bgcolor="#FFFFFF">792,547 ns</td><td align="right" bgcolor="#FFFFFF">667,467 ns</td><td align="right" bgcolor="#FFFFFF">676,643 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,652 μs</td><td align="right" bgcolor="#FFFFFF">0,672 μs</td><td align="right" bgcolor="#FFFFFF">0,793 μs</td><td align="right" bgcolor="#FFFFFF">0,667 μs</td><td align="right" bgcolor="#FFFFFF">0,677 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.0.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">354,000</td><td align="right" bgcolor="#FF4949">387,000 (Δ = +33,000)</td><td align="right" bgcolor="#FFFFFF">387,000</td><td align="right" bgcolor="#FFFFFF">387,000</td><td align="right" bgcolor="#FFFFFF">387,000</td><td align="right" bgcolor="#FF4949">397,000 (Δ = +10,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,346</td><td align="right" bgcolor="#FF4949">0,378 (Δ = +0,032)</td><td align="right" bgcolor="#FFFFFF">0,378</td><td align="right" bgcolor="#FFFFFF">0,378</td><td align="right" bgcolor="#FFFFFF">0,378</td><td align="right" bgcolor="#FF4949">0,388 (Δ = +0,010)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 12,064 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">76,891 ns</td><td align="right" bgcolor="#FFFFFF">85,448 ns</td><td align="right" bgcolor="#FFFFFF">73,384 ns</td><td align="right" bgcolor="#FFFFFF">78,496 ns</td><td align="right" bgcolor="#FFFFFF">74,355 ns</td><td align="right" bgcolor="#FFFFFF">77,365 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 8,712 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">123,245 ns</td><td align="right" bgcolor="#FFFFFF">122,051 ns</td><td align="right" bgcolor="#FFFFFF">120,989 ns</td><td align="right" bgcolor="#FFFFFF">126,563 ns</td><td align="right" bgcolor="#FFFFFF">119,232 ns</td><td align="right" bgcolor="#FFFFFF">127,944 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx"></a>GetGenericTypeDefinitionEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 10,011 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">72,285 ns</td><td align="right" bgcolor="#FFFFFF">65,483 ns</td><td align="right" bgcolor="#FFFFFF">68,019 ns</td><td align="right" bgcolor="#FFFFFF">75,493 ns</td><td align="right" bgcolor="#FFFFFF">72,303 ns</td><td align="right" bgcolor="#FFFFFF">72,880 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetInterfacesEx"></a>GetInterfacesEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 5,059 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">107,211 ns</td><td align="right" bgcolor="#FFFFFF">108,547 ns</td><td align="right" bgcolor="#FFFFFF">105,984 ns</td><td align="right" bgcolor="#FFFFFF">111,043 ns</td><td align="right" bgcolor="#FFFFFF">109,581 ns</td><td align="right" bgcolor="#FFFFFF">108,317 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#FF4949">203,000 (Δ = +10,000)</td><td align="right" bgcolor="#FFFFFF">203,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#FF4949">0,198 (Δ = +0,010)</td><td align="right" bgcolor="#FFFFFF">0,198</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 55,584 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">934,781 ns</td><td align="right" bgcolor="#FFFFFF">927,128 ns</td><td align="right" bgcolor="#FFFFFF">890,859 ns</td><td align="right" bgcolor="#FFFFFF">946,443 ns</td><td align="right" bgcolor="#FFFFFF">914,093 ns</td><td align="right" bgcolor="#FFFFFF">921,587 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,935 μs</td><td align="right" bgcolor="#FFFFFF">0,927 μs</td><td align="right" bgcolor="#FFFFFF">0,891 μs</td><td align="right" bgcolor="#FFFFFF">0,946 μs</td><td align="right" bgcolor="#FFFFFF">0,914 μs</td><td align="right" bgcolor="#FFFFFF">0,922 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">269,000</td><td align="right" bgcolor="#FFFFFF">269,000</td><td align="right" bgcolor="#FFFFFF">269,000</td><td align="right" bgcolor="#FFFFFF">269,000</td><td align="right" bgcolor="#FFFFFF">269,000</td><td align="right" bgcolor="#FFFFFF">269,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,263</td><td align="right" bgcolor="#FFFFFF">0,263</td><td align="right" bgcolor="#FFFFFF">0,263</td><td align="right" bgcolor="#FFFFFF">0,263</td><td align="right" bgcolor="#FFFFFF">0,263</td><td align="right" bgcolor="#FFFFFF">0,263</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 121,716 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">487,517 ns</td><td align="right" bgcolor="#FFFFFF">601,761 ns</td><td align="right" bgcolor="#FFFFFF">480,045 ns</td><td align="right" bgcolor="#FFFFFF">493,973 ns</td><td align="right" bgcolor="#FFFFFF">504,936 ns</td><td align="right" bgcolor="#FFFFFF">486,549 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,488 μs</td><td align="right" bgcolor="#FFFFFF">0,602 μs</td><td align="right" bgcolor="#FFFFFF">0,480 μs</td><td align="right" bgcolor="#FFFFFF">0,494 μs</td><td align="right" bgcolor="#FFFFFF">0,505 μs</td><td align="right" bgcolor="#FFFFFF">0,487 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance"></a>GetMemberEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 36,137 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">468,504 ns</td><td align="right" bgcolor="#FFFFFF">475,240 ns</td><td align="right" bgcolor="#FFFFFF">481,099 ns</td><td align="right" bgcolor="#FFFFFF">487,579 ns</td><td align="right" bgcolor="#FFFFFF">451,441 ns</td><td align="right" bgcolor="#FFFFFF">473,645 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,469 μs</td><td align="right" bgcolor="#FFFFFF">0,475 μs</td><td align="right" bgcolor="#FFFFFF">0,481 μs</td><td align="right" bgcolor="#FFFFFF">0,488 μs</td><td align="right" bgcolor="#FFFFFF">0,451 μs</td><td align="right" bgcolor="#FFFFFF">0,474 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td><td align="right" bgcolor="#FFFFFF">36,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td><td align="right" bgcolor="#FFFFFF">0,035</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 50,716 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">457,784 ns</td><td align="right" bgcolor="#FFFFFF">503,139 ns</td><td align="right" bgcolor="#FFFFFF">452,787 ns</td><td align="right" bgcolor="#FFFFFF">489,589 ns</td><td align="right" bgcolor="#FFFFFF">452,423 ns</td><td align="right" bgcolor="#FFFFFF">462,200 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,458 μs</td><td align="right" bgcolor="#FFFFFF">0,503 μs</td><td align="right" bgcolor="#FFFFFF">0,453 μs</td><td align="right" bgcolor="#FFFFFF">0,490 μs</td><td align="right" bgcolor="#FFFFFF">0,452 μs</td><td align="right" bgcolor="#FFFFFF">0,462 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static"></a>GetMethodEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 77,808 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">511,459 ns</td><td align="right" bgcolor="#FFFFFF">508,229 ns</td><td align="right" bgcolor="#FFFFFF">566,952 ns</td><td align="right" bgcolor="#FFFFFF">522,509 ns</td><td align="right" bgcolor="#FFFFFF">489,144 ns</td><td align="right" bgcolor="#FFFFFF">501,328 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,511 μs</td><td align="right" bgcolor="#FFFFFF">0,508 μs</td><td align="right" bgcolor="#FFFFFF">0,567 μs</td><td align="right" bgcolor="#FFFFFF">0,523 μs</td><td align="right" bgcolor="#FFFFFF">0,489 μs</td><td align="right" bgcolor="#FFFFFF">0,501 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FF4949">243,000 (Δ = +1,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FF4949">0,237 (Δ = +0,001)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags"></a>GetMethodEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 8,293 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">92,861 ns</td><td align="right" bgcolor="#FFFFFF">98,496 ns</td><td align="right" bgcolor="#FFFFFF">90,203 ns</td><td align="right" bgcolor="#FFFFFF">96,621 ns</td><td align="right" bgcolor="#FFFFFF">92,323 ns</td><td align="right" bgcolor="#FFFFFF">91,504 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 19,080 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">103,168 ns</td><td align="right" bgcolor="#FFFFFF">109,136 ns</td><td align="right" bgcolor="#FFFFFF">117,877 ns</td><td align="right" bgcolor="#FFFFFF">113,669 ns</td><td align="right" bgcolor="#FFFFFF">101,656 ns</td><td align="right" bgcolor="#FFFFFF">98,797 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 17,727 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">95,077 ns</td><td align="right" bgcolor="#FFFFFF">102,571 ns</td><td align="right" bgcolor="#FFFFFF">99,579 ns</td><td align="right" bgcolor="#FFFFFF">103,464 ns</td><td align="right" bgcolor="#FFFFFF">96,528 ns</td><td align="right" bgcolor="#FFFFFF">112,804 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 5406,327 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,2 %</td><td align="right" bgcolor="#A8D08D">-45,7 %</td><td align="right" bgcolor="#FF4949">+54,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8912,239 ns</td><td align="right" bgcolor="#A8D08D">6093,728 ns (Δ = -2818,511 ns)</td><td align="right" bgcolor="#FFFFFF">6019,971 ns</td><td align="right" bgcolor="#FF4949">6451,413 ns (Δ = +431,443 ns)</td><td align="right" bgcolor="#A8D08D">3505,912 ns (Δ = -2945,501 ns)</td><td align="right" bgcolor="#FF4949">5410,240 ns (Δ = +1904,328 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,912 μs</td><td align="right" bgcolor="#FFFFFF">6,094 μs</td><td align="right" bgcolor="#FFFFFF">6,020 μs</td><td align="right" bgcolor="#FFFFFF">6,451 μs</td><td align="right" bgcolor="#FFFFFF">3,506 μs</td><td align="right" bgcolor="#FFFFFF">5,410 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">2066,000</td><td align="right" bgcolor="#FF4949">2135,000 (Δ = +69,000)</td><td align="right" bgcolor="#FFFFFF">2135,000</td><td align="right" bgcolor="#FFFFFF">2135,000</td><td align="right" bgcolor="#FFFFFF">2135,000</td><td align="right" bgcolor="#FF4949">2190,000 (Δ = +55,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,018</td><td align="right" bgcolor="#FF4949">2,085 (Δ = +0,067)</td><td align="right" bgcolor="#FFFFFF">2,085</td><td align="right" bgcolor="#FFFFFF">2,085</td><td align="right" bgcolor="#FFFFFF">2,085</td><td align="right" bgcolor="#FF4949">2,139 (Δ = +0,054)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 70,739 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">805,504 ns</td><td align="right" bgcolor="#FFFFFF">813,789 ns</td><td align="right" bgcolor="#FFFFFF">773,411 ns</td><td align="right" bgcolor="#FFFFFF">819,664 ns</td><td align="right" bgcolor="#FFFFFF">801,956 ns</td><td align="right" bgcolor="#FFFFFF">844,149 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,806 μs</td><td align="right" bgcolor="#FFFFFF">0,814 μs</td><td align="right" bgcolor="#FFFFFF">0,773 μs</td><td align="right" bgcolor="#FFFFFF">0,820 μs</td><td align="right" bgcolor="#FFFFFF">0,802 μs</td><td align="right" bgcolor="#FFFFFF">0,844 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+23,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FF4949">16,000 (Δ = +3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,013</td><td align="right" bgcolor="#FFFFFF">0,013</td><td align="right" bgcolor="#FFFFFF">0,013</td><td align="right" bgcolor="#FFFFFF">0,013</td><td align="right" bgcolor="#FFFFFF">0,013</td><td align="right" bgcolor="#FF4949">0,016 (Δ = +0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 5625,963 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,3 %</td><td align="right" bgcolor="#FF4949">+56,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9014,200 ns</td><td align="right" bgcolor="#A8D08D">5986,547 ns (Δ = -3027,653 ns)</td><td align="right" bgcolor="#FFFFFF">5872,547 ns</td><td align="right" bgcolor="#FFFFFF">6086,624 ns</td><td align="right" bgcolor="#A8D08D">3388,237 ns (Δ = -2698,387 ns)</td><td align="right" bgcolor="#FF4949">5297,200 ns (Δ = +1908,963 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,014 μs</td><td align="right" bgcolor="#FFFFFF">5,987 μs</td><td align="right" bgcolor="#FFFFFF">5,873 μs</td><td align="right" bgcolor="#FFFFFF">6,087 μs</td><td align="right" bgcolor="#FFFFFF">3,388 μs</td><td align="right" bgcolor="#FFFFFF">5,297 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,3 %</td><td align="right" bgcolor="#FF4949">+2,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3476,000</td><td align="right" bgcolor="#FF4949">3588,000 (Δ = +112,000)</td><td align="right" bgcolor="#FFFFFF">3588,000</td><td align="right" bgcolor="#FFFFFF">3588,000</td><td align="right" bgcolor="#FF4949">3634,000 (Δ = +46,000)</td><td align="right" bgcolor="#FF4949">3739,000 (Δ = +105,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,395</td><td align="right" bgcolor="#FF4949">3,504 (Δ = +0,109)</td><td align="right" bgcolor="#FFFFFF">3,504</td><td align="right" bgcolor="#FFFFFF">3,504</td><td align="right" bgcolor="#FF4949">3,549 (Δ = +0,045)</td><td align="right" bgcolor="#FF4949">3,651 (Δ = +0,103)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,004 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 73,520 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">766,683 ns</td><td align="right" bgcolor="#FFFFFF">786,885 ns</td><td align="right" bgcolor="#FFFFFF">791,789 ns</td><td align="right" bgcolor="#FFFFFF">820,888 ns</td><td align="right" bgcolor="#FFFFFF">774,453 ns</td><td align="right" bgcolor="#FFFFFF">840,203 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,767 μs</td><td align="right" bgcolor="#FFFFFF">0,787 μs</td><td align="right" bgcolor="#FFFFFF">0,792 μs</td><td align="right" bgcolor="#FFFFFF">0,821 μs</td><td align="right" bgcolor="#FFFFFF">0,774 μs</td><td align="right" bgcolor="#FFFFFF">0,840 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+23,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FF4949">16,000 (Δ = +3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,013</td><td align="right" bgcolor="#FFFFFF">0,013</td><td align="right" bgcolor="#FFFFFF">0,013</td><td align="right" bgcolor="#FFFFFF">0,013</td><td align="right" bgcolor="#FFFFFF">0,013</td><td align="right" bgcolor="#FF4949">0,016 (Δ = +0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 64,893 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">554,061 ns</td><td align="right" bgcolor="#FFFFFF">527,285 ns</td><td align="right" bgcolor="#FFFFFF">539,640 ns</td><td align="right" bgcolor="#FFFFFF">563,509 ns</td><td align="right" bgcolor="#FFFFFF">537,147 ns</td><td align="right" bgcolor="#FFFFFF">498,616 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,554 μs</td><td align="right" bgcolor="#FFFFFF">0,527 μs</td><td align="right" bgcolor="#FFFFFF">0,540 μs</td><td align="right" bgcolor="#FFFFFF">0,564 μs</td><td align="right" bgcolor="#FFFFFF">0,537 μs</td><td align="right" bgcolor="#FFFFFF">0,499 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">265,000</td><td align="right" bgcolor="#FFFFFF">265,000</td><td align="right" bgcolor="#FFFFFF">265,000</td><td align="right" bgcolor="#FFFFFF">265,000</td><td align="right" bgcolor="#FF4949">275,000 (Δ = +10,000)</td><td align="right" bgcolor="#FFFFFF">275,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,259</td><td align="right" bgcolor="#FFFFFF">0,259</td><td align="right" bgcolor="#FFFFFF">0,259</td><td align="right" bgcolor="#FFFFFF">0,259</td><td align="right" bgcolor="#FF4949">0,269 (Δ = +0,010)</td><td align="right" bgcolor="#FFFFFF">0,269</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 47,299 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">909,816 ns</td><td align="right" bgcolor="#FFFFFF">892,397 ns</td><td align="right" bgcolor="#FFFFFF">885,749 ns</td><td align="right" bgcolor="#FFFFFF">933,048 ns</td><td align="right" bgcolor="#FFFFFF">897,467 ns</td><td align="right" bgcolor="#FFFFFF">904,459 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,910 μs</td><td align="right" bgcolor="#FFFFFF">0,892 μs</td><td align="right" bgcolor="#FFFFFF">0,886 μs</td><td align="right" bgcolor="#FFFFFF">0,933 μs</td><td align="right" bgcolor="#FFFFFF">0,897 μs</td><td align="right" bgcolor="#FFFFFF">0,904 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">541,000</td><td align="right" bgcolor="#FFFFFF">541,000</td><td align="right" bgcolor="#FFFFFF">541,000</td><td align="right" bgcolor="#FFFFFF">541,000</td><td align="right" bgcolor="#FFFFFF">541,000</td><td align="right" bgcolor="#FFFFFF">541,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,528</td><td align="right" bgcolor="#FFFFFF">0,528</td><td align="right" bgcolor="#FFFFFF">0,528</td><td align="right" bgcolor="#FFFFFF">0,528</td><td align="right" bgcolor="#FFFFFF">0,528</td><td align="right" bgcolor="#FFFFFF">0,528</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 65,693 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">468,853 ns</td><td align="right" bgcolor="#FFFFFF">513,739 ns</td><td align="right" bgcolor="#FFFFFF">448,045 ns</td><td align="right" bgcolor="#FFFFFF">480,611 ns</td><td align="right" bgcolor="#FFFFFF">458,571 ns</td><td align="right" bgcolor="#FFFFFF">465,117 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,469 μs</td><td align="right" bgcolor="#FFFFFF">0,514 μs</td><td align="right" bgcolor="#FFFFFF">0,448 μs</td><td align="right" bgcolor="#FFFFFF">0,481 μs</td><td align="right" bgcolor="#FFFFFF">0,459 μs</td><td align="right" bgcolor="#FFFFFF">0,465 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">557,000</td><td align="right" bgcolor="#FFFFFF">557,000</td><td align="right" bgcolor="#FFFFFF">557,000</td><td align="right" bgcolor="#FFFFFF">557,000</td><td align="right" bgcolor="#FFFFFF">557,000</td><td align="right" bgcolor="#FFFFFF">557,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,544</td><td align="right" bgcolor="#FFFFFF">0,544</td><td align="right" bgcolor="#FFFFFF">0,544</td><td align="right" bgcolor="#FFFFFF">0,544</td><td align="right" bgcolor="#FFFFFF">0,544</td><td align="right" bgcolor="#FFFFFF">0,544</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 18,615 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">113,179 ns</td><td align="right" bgcolor="#FFFFFF">108,011 ns</td><td align="right" bgcolor="#FFFFFF">109,456 ns</td><td align="right" bgcolor="#FFFFFF">126,625 ns</td><td align="right" bgcolor="#FFFFFF">113,059 ns</td><td align="right" bgcolor="#FFFFFF">112,213 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 184,013 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">520,896 ns</td><td align="right" bgcolor="#FFFFFF">694,259 ns</td><td align="right" bgcolor="#FFFFFF">510,245 ns</td><td align="right" bgcolor="#FFFFFF">533,451 ns</td><td align="right" bgcolor="#FFFFFF">510,601 ns</td><td align="right" bgcolor="#FFFFFF">523,621 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,521 μs</td><td align="right" bgcolor="#FFFFFF">0,694 μs</td><td align="right" bgcolor="#FFFFFF">0,510 μs</td><td align="right" bgcolor="#FFFFFF">0,533 μs</td><td align="right" bgcolor="#FFFFFF">0,511 μs</td><td align="right" bgcolor="#FFFFFF">0,524 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FF4949">265,000 (Δ = +23,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FF4949">0,259 (Δ = +0,022)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance"></a>GetPropertyEx_Instance

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 57,829 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">112,048 ns</td><td align="right" bgcolor="#FFFFFF">158,693 ns</td><td align="right" bgcolor="#FFFFFF">100,864 ns</td><td align="right" bgcolor="#FFFFFF">107,979 ns</td><td align="right" bgcolor="#FFFFFF">104,779 ns</td><td align="right" bgcolor="#FFFFFF">115,880 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,159 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,116 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">26,000 (Δ = +26,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,025 (Δ = +0,025)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 777,147 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,2 %</td><td align="right" bgcolor="#A8D08D">-24,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2015,816 ns</td><td align="right" bgcolor="#FF4949">2564,792 ns (Δ = +548,976 ns)</td><td align="right" bgcolor="#A8D08D">1936,208 ns (Δ = -628,584 ns)</td><td align="right" bgcolor="#FFFFFF">2002,424 ns</td><td align="right" bgcolor="#FFFFFF">1787,645 ns</td><td align="right" bgcolor="#FF4949">2075,403 ns (Δ = +287,757 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,016 μs</td><td align="right" bgcolor="#FFFFFF">2,565 μs</td><td align="right" bgcolor="#FFFFFF">1,936 μs</td><td align="right" bgcolor="#FFFFFF">2,002 μs</td><td align="right" bgcolor="#FFFFFF">1,788 μs</td><td align="right" bgcolor="#FFFFFF">2,075 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.6.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,0 %</td><td align="right" bgcolor="#FF4949">+268,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FFFFFF">200,000</td><td align="right" bgcolor="#FF4949">206,000 (Δ = +6,000)</td><td align="right" bgcolor="#FF4949">760,000 (Δ = +554,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FFFFFF">0,195</td><td align="right" bgcolor="#FF4949">0,201 (Δ = +0,006)</td><td align="right" bgcolor="#FF4949">0,742 (Δ = +0,541)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 21,733 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">134,984 ns</td><td align="right" bgcolor="#FFFFFF">139,875 ns</td><td align="right" bgcolor="#FFFFFF">134,227 ns</td><td align="right" bgcolor="#FFFFFF">147,773 ns</td><td align="right" bgcolor="#FFFFFF">137,989 ns</td><td align="right" bgcolor="#FFFFFF">126,040 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,148 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetTypeInfo"></a>GetTypeInfo

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 1,800 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,451 ns</td><td align="right" bgcolor="#FFFFFF">8,195 ns</td><td align="right" bgcolor="#FFFFFF">7,651 ns</td><td align="right" bgcolor="#FFFFFF">8,045 ns</td><td align="right" bgcolor="#FFFFFF">8,459 ns</td><td align="right" bgcolor="#FFFFFF">7,963 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_HasBaseTypeEx"></a>HasBaseTypeEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 6,867 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,507 ns</td><td align="right" bgcolor="#FFFFFF">25,163 ns</td><td align="right" bgcolor="#FFFFFF">31,725 ns</td><td align="right" bgcolor="#FFFFFF">26,384 ns</td><td align="right" bgcolor="#FFFFFF">26,636 ns</td><td align="right" bgcolor="#FFFFFF">24,859 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx"></a>ImplementsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 4,165 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,371 ns</td><td align="right" bgcolor="#FFFFFF">28,536 ns</td><td align="right" bgcolor="#FFFFFF">25,264 ns</td><td align="right" bgcolor="#FFFFFF">26,933 ns</td><td align="right" bgcolor="#FFFFFF">27,888 ns</td><td align="right" bgcolor="#FFFFFF">24,523 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx"></a>ImplementsInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 2,144 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,632 ns</td><td align="right" bgcolor="#FFFFFF">23,776 ns</td><td align="right" bgcolor="#FFFFFF">22,461 ns</td><td align="right" bgcolor="#FFFFFF">23,317 ns</td><td align="right" bgcolor="#FFFFFF">22,108 ns</td><td align="right" bgcolor="#FFFFFF">22,752 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAbstractEx"></a>IsAbstractEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 1,475 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,032 ns</td><td align="right" bgcolor="#FFFFFF">10,416 ns</td><td align="right" bgcolor="#FFFFFF">11,525 ns</td><td align="right" bgcolor="#FFFFFF">11,027 ns</td><td align="right" bgcolor="#FFFFFF">11,477 ns</td><td align="right" bgcolor="#FFFFFF">10,051 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsArrayEx"></a>IsArrayEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 1,677 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,867 ns</td><td align="right" bgcolor="#FFFFFF">14,456 ns</td><td align="right" bgcolor="#FFFFFF">14,909 ns</td><td align="right" bgcolor="#FFFFFF">15,824 ns</td><td align="right" bgcolor="#FFFFFF">14,605 ns</td><td align="right" bgcolor="#FFFFFF">14,189 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAssignableFromEx"></a>IsAssignableFromEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 4,375 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,155 ns</td><td align="right" bgcolor="#FFFFFF">20,491 ns</td><td align="right" bgcolor="#FFFFFF">18,336 ns</td><td align="right" bgcolor="#FFFFFF">18,845 ns</td><td align="right" bgcolor="#FFFFFF">22,529 ns</td><td align="right" bgcolor="#FFFFFF">21,781 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 144,797 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">355,984 ns</td><td align="right" bgcolor="#FFFFFF">355,405 ns</td><td align="right" bgcolor="#FFFFFF">336,048 ns</td><td align="right" bgcolor="#FFFFFF">378,168 ns</td><td align="right" bgcolor="#FFFFFF">357,576 ns</td><td align="right" bgcolor="#FFFFFF">233,371 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,356 μs</td><td align="right" bgcolor="#FFFFFF">0,355 μs</td><td align="right" bgcolor="#FFFFFF">0,336 μs</td><td align="right" bgcolor="#FFFFFF">0,378 μs</td><td align="right" bgcolor="#FFFFFF">0,358 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsClassEx"></a>IsClassEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 10,433 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">125,944 ns</td><td align="right" bgcolor="#FFFFFF">123,515 ns</td><td align="right" bgcolor="#FFFFFF">121,763 ns</td><td align="right" bgcolor="#FFFFFF">131,557 ns</td><td align="right" bgcolor="#FFFFFF">121,124 ns</td><td align="right" bgcolor="#FFFFFF">124,803 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCOMObjectEx"></a>IsCOMObjectEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 1,379 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,499 ns</td><td align="right" bgcolor="#FFFFFF">16,341 ns</td><td align="right" bgcolor="#FFFFFF">15,912 ns</td><td align="right" bgcolor="#FFFFFF">16,784 ns</td><td align="right" bgcolor="#FFFFFF">17,291 ns</td><td align="right" bgcolor="#FFFFFF">16,872 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsEnumEx"></a>IsEnumEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 1,984 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,944 ns</td><td align="right" bgcolor="#FFFFFF">22,239 ns</td><td align="right" bgcolor="#FFFFFF">21,053 ns</td><td align="right" bgcolor="#FFFFFF">23,037 ns</td><td align="right" bgcolor="#FFFFFF">22,992 ns</td><td align="right" bgcolor="#FFFFFF">22,824 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 1,089 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,157 ns</td><td align="right" bgcolor="#FFFFFF">6,629 ns</td><td align="right" bgcolor="#FFFFFF">6,532 ns</td><td align="right" bgcolor="#FFFFFF">7,247 ns</td><td align="right" bgcolor="#FFFFFF">6,669 ns</td><td align="right" bgcolor="#FFFFFF">6,843 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeEx"></a>IsGenericTypeEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 1,277 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,613 ns</td><td align="right" bgcolor="#FFFFFF">6,504 ns</td><td align="right" bgcolor="#FFFFFF">5,867 ns</td><td align="right" bgcolor="#FFFFFF">7,144 ns</td><td align="right" bgcolor="#FFFFFF">6,176 ns</td><td align="right" bgcolor="#FFFFFF">6,317 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx"></a>IsInstanceOfTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 2817,913 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,2 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#FF4949">+8,5 %</td><td align="right" bgcolor="#FF4949">+2,6 %</td><td align="right" bgcolor="#FF4949">+5,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13174,495 ns</td><td align="right" bgcolor="#FF4949">14122,477 ns (Δ = +947,983 ns)</td><td align="right" bgcolor="#A8D08D">13553,701 ns (Δ = -568,776 ns)</td><td align="right" bgcolor="#FF4949">14710,157 ns (Δ = +1156,456 ns)</td><td align="right" bgcolor="#FF4949">15096,653 ns (Δ = +386,496 ns)</td><td align="right" bgcolor="#FF4949">15992,408 ns (Δ = +895,755 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13,174 μs</td><td align="right" bgcolor="#FFFFFF">14,122 μs</td><td align="right" bgcolor="#FFFFFF">13,554 μs</td><td align="right" bgcolor="#FFFFFF">14,710 μs</td><td align="right" bgcolor="#FFFFFF">15,097 μs</td><td align="right" bgcolor="#FFFFFF">15,992 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.4.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,4 %</td><td align="right" bgcolor="#FF4949">+6,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">6618,000</td><td align="right" bgcolor="#FF4949">6953,000 (Δ = +335,000)</td><td align="right" bgcolor="#FFFFFF">6953,000</td><td align="right" bgcolor="#FFFFFF">6953,000</td><td align="right" bgcolor="#FF4949">7187,000 (Δ = +234,000)</td><td align="right" bgcolor="#FF4949">7667,000 (Δ = +480,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">6,463</td><td align="right" bgcolor="#FF4949">6,790 (Δ = +0,327)</td><td align="right" bgcolor="#FFFFFF">6,790</td><td align="right" bgcolor="#FFFFFF">6,790</td><td align="right" bgcolor="#FF4949">7,019 (Δ = +0,229)</td><td align="right" bgcolor="#FF4949">7,487 (Δ = +0,469)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FF4949">0,007 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#FF4949">0,007 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,007 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 4,389 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,693 ns</td><td align="right" bgcolor="#FFFFFF">9,505 ns</td><td align="right" bgcolor="#FFFFFF">6,721 ns</td><td align="right" bgcolor="#FFFFFF">8,888 ns</td><td align="right" bgcolor="#FFFFFF">11,083 ns</td><td align="right" bgcolor="#FFFFFF">7,923 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsNestedPublicEx"></a>IsNestedPublicEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 4,192 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,808 ns</td><td align="right" bgcolor="#FFFFFF">14,320 ns</td><td align="right" bgcolor="#FFFFFF">11,683 ns</td><td align="right" bgcolor="#FFFFFF">10,475 ns</td><td align="right" bgcolor="#FFFFFF">10,128 ns</td><td align="right" bgcolor="#FFFFFF">10,139 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPrimitiveEx"></a>IsPrimitiveEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 2,069 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,412 ns</td><td align="right" bgcolor="#FFFFFF">10,027 ns</td><td align="right" bgcolor="#FFFFFF">10,897 ns</td><td align="right" bgcolor="#FFFFFF">12,032 ns</td><td align="right" bgcolor="#FFFFFF">12,096 ns</td><td align="right" bgcolor="#FFFFFF">10,680 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPublicEx"></a>IsPublicEx

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 14,440 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,821 ns</td><td align="right" bgcolor="#FFFFFF">24,304 ns</td><td align="right" bgcolor="#FFFFFF">10,048 ns</td><td align="right" bgcolor="#FFFFFF">10,947 ns</td><td align="right" bgcolor="#FFFFFF">9,864 ns</td><td align="right" bgcolor="#FFFFFF">10,181 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsSerializableEx"></a>IsSerializableEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 1,109 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,741 ns</td><td align="right" bgcolor="#FFFFFF">11,232 ns</td><td align="right" bgcolor="#FFFFFF">10,464 ns</td><td align="right" bgcolor="#FFFFFF">11,363 ns</td><td align="right" bgcolor="#FFFFFF">10,533 ns</td><td align="right" bgcolor="#FFFFFF">10,253 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsValueTypeEx"></a>IsValueTypeEx

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 7,459 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">27,253 ns</td><td align="right" bgcolor="#FFFFFF">28,101 ns</td><td align="right" bgcolor="#FFFFFF">25,264 ns</td><td align="right" bgcolor="#FFFFFF">28,157 ns</td><td align="right" bgcolor="#FFFFFF">26,808 ns</td><td align="right" bgcolor="#FFFFFF">32,723 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="TypeExtensions_Benchmark"></a>TypeExtensions_Benchmark

### <a name="TypeExtensions_Benchmark_GetCollectionElementType"></a>GetCollectionElementType

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 431,461 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-63,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">642,189 ns</td><td align="right" bgcolor="#A8D08D">232,581 ns (Δ = -409,608 ns)</td><td align="right" bgcolor="#FFFFFF">210,728 ns</td><td align="right" bgcolor="#FFFFFF">222,616 ns</td><td align="right" bgcolor="#FFFFFF">222,603 ns</td><td align="right" bgcolor="#FFFFFF">315,772 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,642 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,316 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-81,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#A8D08D">33,000 (Δ = -147,000)</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#A8D08D">0,032 (Δ = -0,144)</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsBasicType"></a>IsBasicType

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 3,699 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,979 ns</td><td align="right" bgcolor="#FFFFFF">13,803 ns</td><td align="right" bgcolor="#FFFFFF">14,069 ns</td><td align="right" bgcolor="#FFFFFF">14,237 ns</td><td align="right" bgcolor="#FFFFFF">14,592 ns</td><td align="right" bgcolor="#FFFFFF">17,501 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsClassType"></a>IsClassType

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 109,244 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">165,884 ns</td><td align="right" bgcolor="#FFFFFF">175,792 ns</td><td align="right" bgcolor="#FFFFFF">159,861 ns</td><td align="right" bgcolor="#FFFFFF">238,744 ns</td><td align="right" bgcolor="#FFFFFF">157,544 ns</td><td align="right" bgcolor="#FFFFFF">266,788 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#FFFFFF">0,176 μs</td><td align="right" bgcolor="#FFFFFF">0,160 μs</td><td align="right" bgcolor="#FFFFFF">0,239 μs</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,267 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsCollection"></a>IsCollection

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 19,429 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,921 ns</td><td align="right" bgcolor="#FFFFFF">26,251 ns</td><td align="right" bgcolor="#FFFFFF">24,669 ns</td><td align="right" bgcolor="#FFFFFF">43,707 ns</td><td align="right" bgcolor="#FFFFFF">24,277 ns</td><td align="right" bgcolor="#FFFFFF">35,839 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsDictionary"></a>IsDictionary

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 62,007 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">78,611 ns</td><td align="right" bgcolor="#FFFFFF">82,808 ns</td><td align="right" bgcolor="#FFFFFF">87,501 ns</td><td align="right" bgcolor="#FFFFFF">83,531 ns</td><td align="right" bgcolor="#FFFFFF">77,137 ns</td><td align="right" bgcolor="#FFFFFF">139,144 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsModelBase"></a>IsModelBase

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 8,232 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,327 ns</td><td align="right" bgcolor="#FFFFFF">22,495 ns</td><td align="right" bgcolor="#FFFFFF">22,153 ns</td><td align="right" bgcolor="#FFFFFF">21,928 ns</td><td align="right" bgcolor="#FFFFFF">20,485 ns</td><td align="right" bgcolor="#FFFFFF">28,717 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsNullableType"></a>IsNullableType

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 89,521 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">233,813 ns</td><td align="right" bgcolor="#FFFFFF">243,823 ns</td><td align="right" bgcolor="#FFFFFF">221,929 ns</td><td align="right" bgcolor="#FFFFFF">229,463 ns</td><td align="right" bgcolor="#FFFFFF">229,195 ns</td><td align="right" bgcolor="#FFFFFF">311,451 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td><td align="right" bgcolor="#FFFFFF">0,222 μs</td><td align="right" bgcolor="#FFFFFF">0,229 μs</td><td align="right" bgcolor="#FFFFFF">0,229 μs</td><td align="right" bgcolor="#FFFFFF">0,311 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="TypeFactory_Benchmark"></a>TypeFactory_Benchmark

### <a name="TypeFactory_Benchmark_CreateInstance"></a>CreateInstance

#### Performance

Fastest: **5.6.0**

Slowest: 5.5.0

Δ: 203,960 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1686,584 ns</td><td align="right" bgcolor="#FFFFFF">1721,144 ns</td><td align="right" bgcolor="#FFFFFF">1819,717 ns</td><td align="right" bgcolor="#FFFFFF">1615,757 ns</td><td align="right" bgcolor="#FFFFFF">1653,845 ns</td><td align="right" bgcolor="#FFFFFF">1661,832 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,687 μs</td><td align="right" bgcolor="#FFFFFF">1,721 μs</td><td align="right" bgcolor="#FFFFFF">1,820 μs</td><td align="right" bgcolor="#FFFFFF">1,616 μs</td><td align="right" bgcolor="#FFFFFF">1,654 μs</td><td align="right" bgcolor="#FFFFFF">1,662 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+26,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1062,000</td><td align="right" bgcolor="#A8D08D">1045,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">1045,000</td><td align="right" bgcolor="#FFFFFF">1045,000</td><td align="right" bgcolor="#FFFFFF">1045,000</td><td align="right" bgcolor="#FF4949">1323,000 (Δ = +278,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,037</td><td align="right" bgcolor="#A8D08D">1,021 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">1,021</td><td align="right" bgcolor="#FFFFFF">1,021</td><td align="right" bgcolor="#FFFFFF">1,021</td><td align="right" bgcolor="#FF4949">1,292 (Δ = +0,271)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **5.5.0**

Slowest: 5.6.0

Δ: 1406,371 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+91,2 %</td><td align="right" bgcolor="#A8D08D">-41,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1616,195 ns</td><td align="right" bgcolor="#FFFFFF">1569,731 ns</td><td align="right" bgcolor="#FFFFFF">1542,803 ns</td><td align="right" bgcolor="#FF4949">2949,173 ns (Δ = +1406,371 ns)</td><td align="right" bgcolor="#A8D08D">1727,301 ns (Δ = -1221,872 ns)</td><td align="right" bgcolor="#FFFFFF">1632,925 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,616 μs</td><td align="right" bgcolor="#FFFFFF">1,570 μs</td><td align="right" bgcolor="#FFFFFF">1,543 μs</td><td align="right" bgcolor="#FFFFFF">2,949 μs</td><td align="right" bgcolor="#FFFFFF">1,727 μs</td><td align="right" bgcolor="#FFFFFF">1,633 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+26,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1062,000</td><td align="right" bgcolor="#A8D08D">1045,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">1045,000</td><td align="right" bgcolor="#FFFFFF">1045,000</td><td align="right" bgcolor="#FFFFFF">1045,000</td><td align="right" bgcolor="#FF4949">1317,000 (Δ = +272,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,037</td><td align="right" bgcolor="#A8D08D">1,021 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">1,021</td><td align="right" bgcolor="#FFFFFF">1,021</td><td align="right" bgcolor="#FFFFFF">1,021</td><td align="right" bgcolor="#FF4949">1,286 (Δ = +0,266)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 336,197 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2158,891 ns</td><td align="right" bgcolor="#FFFFFF">2244,693 ns</td><td align="right" bgcolor="#FFFFFF">2190,223 ns</td><td align="right" bgcolor="#FF4949">2442,253 ns (Δ = +252,031 ns)</td><td align="right" bgcolor="#FFFFFF">2305,507 ns</td><td align="right" bgcolor="#FFFFFF">2106,056 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,159 μs</td><td align="right" bgcolor="#FFFFFF">2,245 μs</td><td align="right" bgcolor="#FFFFFF">2,190 μs</td><td align="right" bgcolor="#FFFFFF">2,442 μs</td><td align="right" bgcolor="#FFFFFF">2,306 μs</td><td align="right" bgcolor="#FFFFFF">2,106 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1484,000</td><td align="right" bgcolor="#FF4949">1494,000 (Δ = +10,000)</td><td align="right" bgcolor="#FFFFFF">1494,000</td><td align="right" bgcolor="#FFFFFF">1494,000</td><td align="right" bgcolor="#FFFFFF">1494,000</td><td align="right" bgcolor="#FF4949">1773,000 (Δ = +279,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,449</td><td align="right" bgcolor="#FF4949">1,459 (Δ = +0,010)</td><td align="right" bgcolor="#FFFFFF">1,459</td><td align="right" bgcolor="#FFFFFF">1,459</td><td align="right" bgcolor="#FFFFFF">1,459</td><td align="right" bgcolor="#FF4949">1,731 (Δ = +0,272)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 216,384 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2233,981 ns</td><td align="right" bgcolor="#FFFFFF">2292,027 ns</td><td align="right" bgcolor="#FFFFFF">2236,596 ns</td><td align="right" bgcolor="#FFFFFF">2336,200 ns</td><td align="right" bgcolor="#FFFFFF">2293,193 ns</td><td align="right" bgcolor="#FFFFFF">2450,365 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,234 μs</td><td align="right" bgcolor="#FFFFFF">2,292 μs</td><td align="right" bgcolor="#FFFFFF">2,237 μs</td><td align="right" bgcolor="#FFFFFF">2,336 μs</td><td align="right" bgcolor="#FFFFFF">2,293 μs</td><td align="right" bgcolor="#FFFFFF">2,450 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1694,000</td><td align="right" bgcolor="#FF4949">1701,000 (Δ = +7,000)</td><td align="right" bgcolor="#FFFFFF">1701,000</td><td align="right" bgcolor="#FFFFFF">1701,000</td><td align="right" bgcolor="#FFFFFF">1701,000</td><td align="right" bgcolor="#FF4949">1983,000 (Δ = +282,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,654</td><td align="right" bgcolor="#FF4949">1,661 (Δ = +0,007)</td><td align="right" bgcolor="#FFFFFF">1,661</td><td align="right" bgcolor="#FFFFFF">1,661</td><td align="right" bgcolor="#FFFFFF">1,661</td><td align="right" bgcolor="#FF4949">1,937 (Δ = +0,275)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


## <a name="UniqueIdentifierHelper_Benchmark"></a>UniqueIdentifierHelper_Benchmark

### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier"></a>GetUniqueIdentifier

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 24,924 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">75,379 ns</td><td align="right" bgcolor="#FFFFFF">81,836 ns</td><td align="right" bgcolor="#FFFFFF">75,825 ns</td><td align="right" bgcolor="#FFFFFF">56,912 ns</td><td align="right" bgcolor="#FFFFFF">60,527 ns</td><td align="right" bgcolor="#FFFFFF">68,589 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier_Generic"></a>GetUniqueIdentifier_Generic

#### Performance

Fastest: **5.6.0**

Slowest: 5.4.0

Δ: 19,224 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">74,503 ns</td><td align="right" bgcolor="#FFFFFF">76,928 ns</td><td align="right" bgcolor="#FFFFFF">75,584 ns</td><td align="right" bgcolor="#FFFFFF">57,704 ns</td><td align="right" bgcolor="#FFFFFF">69,211 ns</td><td align="right" bgcolor="#FFFFFF">62,159 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,058 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ValidatableModelBase_Constructor_Benchmark"></a>ValidatableModelBase_Constructor_Benchmark

### <a name="ValidatableModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 253,403 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2271,869 ns</td><td align="right" bgcolor="#FFFFFF">2331,736 ns</td><td align="right" bgcolor="#FFFFFF">2293,016 ns</td><td align="right" bgcolor="#FFFFFF">2424,965 ns</td><td align="right" bgcolor="#A8D08D">2171,563 ns (Δ = -253,403 ns)</td><td align="right" bgcolor="#FFFFFF">2342,795 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,272 μs</td><td align="right" bgcolor="#FFFFFF">2,332 μs</td><td align="right" bgcolor="#FFFFFF">2,293 μs</td><td align="right" bgcolor="#FFFFFF">2,425 μs</td><td align="right" bgcolor="#FFFFFF">2,172 μs</td><td align="right" bgcolor="#FFFFFF">2,343 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#FFFFFF">973,000</td><td align="right" bgcolor="#A8D08D">934,000 (Δ = -39,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#FFFFFF">0,950</td><td align="right" bgcolor="#A8D08D">0,912 (Δ = -0,038)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr></table>


## <a name="ValidationContext_Benchmark"></a>ValidationContext_Benchmark

### <a name="ValidationContext_Benchmark_GetBusinessRuleErrorCount"></a>GetBusinessRuleErrorCount

#### Performance

Fastest: **5.5.0**

Slowest: 5.0.0

Δ: 11,987 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">155,731 ns</td><td align="right" bgcolor="#FFFFFF">143,899 ns</td><td align="right" bgcolor="#FFFFFF">143,744 ns</td><td align="right" bgcolor="#FFFFFF">149,205 ns</td><td align="right" bgcolor="#FFFFFF">144,936 ns</td><td align="right" bgcolor="#FFFFFF">153,827 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleErrors"></a>GetBusinessRuleErrors

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 20,088 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">150,401 ns</td><td align="right" bgcolor="#FFFFFF">141,640 ns</td><td align="right" bgcolor="#FFFFFF">161,728 ns</td><td align="right" bgcolor="#FFFFFF">144,320 ns</td><td align="right" bgcolor="#FFFFFF">145,995 ns</td><td align="right" bgcolor="#FFFFFF">156,339 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,150 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,162 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleValidations"></a>GetBusinessRuleValidations

#### Performance

Fastest: **5.6.0**

Slowest: 5.12.0

Δ: 52,095 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">173,560 ns</td><td align="right" bgcolor="#FFFFFF">161,691 ns</td><td align="right" bgcolor="#FFFFFF">157,504 ns</td><td align="right" bgcolor="#FFFFFF">156,764 ns</td><td align="right" bgcolor="#FFFFFF">167,309 ns</td><td align="right" bgcolor="#FFFFFF">208,859 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,174 μs</td><td align="right" bgcolor="#FFFFFF">0,162 μs</td><td align="right" bgcolor="#FFFFFF">0,158 μs</td><td align="right" bgcolor="#FFFFFF">0,157 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#FFFFFF">0,209 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#FFFFFF">177,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#FFFFFF">0,173</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarningCount"></a>GetBusinessRuleWarningCount

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 39,604 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">156,605 ns</td><td align="right" bgcolor="#FFFFFF">155,168 ns</td><td align="right" bgcolor="#FFFFFF">145,739 ns</td><td align="right" bgcolor="#FFFFFF">184,195 ns</td><td align="right" bgcolor="#FFFFFF">144,591 ns</td><td align="right" bgcolor="#FFFFFF">165,819 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,157 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,184 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarnings"></a>GetBusinessRuleWarnings

#### Performance

Fastest: **5.5.0**

Slowest: 5.12.0

Δ: 26,104 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">148,384 ns</td><td align="right" bgcolor="#FFFFFF">143,979 ns</td><td align="right" bgcolor="#FFFFFF">141,355 ns</td><td align="right" bgcolor="#FFFFFF">153,443 ns</td><td align="right" bgcolor="#FFFFFF">144,824 ns</td><td align="right" bgcolor="#FFFFFF">167,459 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,148 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,153 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrorCount"></a>GetErrorCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 43,165 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">767,952 ns</td><td align="right" bgcolor="#FFFFFF">738,093 ns</td><td align="right" bgcolor="#FFFFFF">738,925 ns</td><td align="right" bgcolor="#FFFFFF">775,437 ns</td><td align="right" bgcolor="#FFFFFF">738,624 ns</td><td align="right" bgcolor="#FFFFFF">781,259 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,768 μs</td><td align="right" bgcolor="#FFFFFF">0,738 μs</td><td align="right" bgcolor="#FFFFFF">0,739 μs</td><td align="right" bgcolor="#FFFFFF">0,775 μs</td><td align="right" bgcolor="#FFFFFF">0,739 μs</td><td align="right" bgcolor="#FFFFFF">0,781 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrors"></a>GetErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 322,013 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+38,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">770,325 ns</td><td align="right" bgcolor="#FF4949">1069,675 ns (Δ = +299,349 ns)</td><td align="right" bgcolor="#FFFFFF">934,443 ns</td><td align="right" bgcolor="#FFFFFF">848,448 ns</td><td align="right" bgcolor="#FFFFFF">747,661 ns</td><td align="right" bgcolor="#FFFFFF">759,776 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,770 μs</td><td align="right" bgcolor="#FFFFFF">1,070 μs</td><td align="right" bgcolor="#FFFFFF">0,934 μs</td><td align="right" bgcolor="#FFFFFF">0,848 μs</td><td align="right" bgcolor="#FFFFFF">0,748 μs</td><td align="right" bgcolor="#FFFFFF">0,760 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrorCount"></a>GetFieldErrorCount

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 10,976 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">176,887 ns</td><td align="right" bgcolor="#FFFFFF">177,141 ns</td><td align="right" bgcolor="#FFFFFF">172,368 ns</td><td align="right" bgcolor="#FFFFFF">172,373 ns</td><td align="right" bgcolor="#FFFFFF">183,344 ns</td><td align="right" bgcolor="#FFFFFF">180,115 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,183 μs</td><td align="right" bgcolor="#FFFFFF">0,180 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrors"></a>GetFieldErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 62,125 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">176,259 ns</td><td align="right" bgcolor="#FFFFFF">229,417 ns</td><td align="right" bgcolor="#FFFFFF">171,717 ns</td><td align="right" bgcolor="#FFFFFF">183,517 ns</td><td align="right" bgcolor="#FFFFFF">167,292 ns</td><td align="right" bgcolor="#FFFFFF">177,467 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,176 μs</td><td align="right" bgcolor="#FFFFFF">0,229 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,184 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldValidations"></a>GetFieldValidations

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 15,741 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">191,099 ns</td><td align="right" bgcolor="#FFFFFF">176,536 ns</td><td align="right" bgcolor="#FFFFFF">179,912 ns</td><td align="right" bgcolor="#FFFFFF">181,507 ns</td><td align="right" bgcolor="#FFFFFF">183,952 ns</td><td align="right" bgcolor="#FFFFFF">192,277 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,191 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,180 μs</td><td align="right" bgcolor="#FFFFFF">0,182 μs</td><td align="right" bgcolor="#FFFFFF">0,184 μs</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#FFFFFF">177,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#FFFFFF">0,173</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarningCount"></a>GetFieldWarningCount

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 14,659 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">159,461 ns</td><td align="right" bgcolor="#FFFFFF">162,603 ns</td><td align="right" bgcolor="#FFFFFF">147,944 ns</td><td align="right" bgcolor="#FFFFFF">160,248 ns</td><td align="right" bgcolor="#FFFFFF">160,917 ns</td><td align="right" bgcolor="#FFFFFF">160,403 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,159 μs</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,148 μs</td><td align="right" bgcolor="#FFFFFF">0,160 μs</td><td align="right" bgcolor="#FFFFFF">0,161 μs</td><td align="right" bgcolor="#FFFFFF">0,160 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarnings"></a>GetFieldWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 60,965 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">149,104 ns</td><td align="right" bgcolor="#FFFFFF">210,069 ns</td><td align="right" bgcolor="#FFFFFF">150,232 ns</td><td align="right" bgcolor="#FFFFFF">162,648 ns</td><td align="right" bgcolor="#FFFFFF">149,131 ns</td><td align="right" bgcolor="#FFFFFF">164,083 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td><td align="right" bgcolor="#FFFFFF">0,150 μs</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,164 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetValidations"></a>GetValidations

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 55,659 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">349,907 ns</td><td align="right" bgcolor="#FFFFFF">350,789 ns</td><td align="right" bgcolor="#FFFFFF">360,019 ns</td><td align="right" bgcolor="#FFFFFF">373,931 ns</td><td align="right" bgcolor="#FFFFFF">376,912 ns</td><td align="right" bgcolor="#FFFFFF">405,565 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,350 μs</td><td align="right" bgcolor="#FFFFFF">0,351 μs</td><td align="right" bgcolor="#FFFFFF">0,360 μs</td><td align="right" bgcolor="#FFFFFF">0,374 μs</td><td align="right" bgcolor="#FFFFFF">0,377 μs</td><td align="right" bgcolor="#FFFFFF">0,406 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td><td align="right" bgcolor="#FFFFFF">347,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td><td align="right" bgcolor="#FFFFFF">0,339</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarningCount"></a>GetWarningCount

#### Performance

Fastest: **5.9.0**

Slowest: 5.0.0

Δ: 107,440 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">768,215 ns</td><td align="right" bgcolor="#FFFFFF">682,125 ns</td><td align="right" bgcolor="#FFFFFF">703,203 ns</td><td align="right" bgcolor="#FFFFFF">722,563 ns</td><td align="right" bgcolor="#FFFFFF">660,775 ns</td><td align="right" bgcolor="#FFFFFF">727,248 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,768 μs</td><td align="right" bgcolor="#FFFFFF">0,682 μs</td><td align="right" bgcolor="#FFFFFF">0,703 μs</td><td align="right" bgcolor="#FFFFFF">0,723 μs</td><td align="right" bgcolor="#FFFFFF">0,661 μs</td><td align="right" bgcolor="#FFFFFF">0,727 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarnings"></a>GetWarnings

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 70,469 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">687,952 ns</td><td align="right" bgcolor="#FFFFFF">755,835 ns</td><td align="right" bgcolor="#FFFFFF">694,376 ns</td><td align="right" bgcolor="#FFFFFF">702,812 ns</td><td align="right" bgcolor="#FFFFFF">685,365 ns</td><td align="right" bgcolor="#FFFFFF">705,925 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,688 μs</td><td align="right" bgcolor="#FFFFFF">0,756 μs</td><td align="right" bgcolor="#FFFFFF">0,694 μs</td><td align="right" bgcolor="#FFFFFF">0,703 μs</td><td align="right" bgcolor="#FFFFFF">0,685 μs</td><td align="right" bgcolor="#FFFFFF">0,706 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.5.0**

Slowest: 5.9.0

Δ: 20,472 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">178,019 ns</td><td align="right" bgcolor="#FFFFFF">176,659 ns</td><td align="right" bgcolor="#FFFFFF">167,171 ns</td><td align="right" bgcolor="#FFFFFF">184,117 ns</td><td align="right" bgcolor="#FFFFFF">187,643 ns</td><td align="right" bgcolor="#FFFFFF">184,923 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,178 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#FFFFFF">0,184 μs</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td><td align="right" bgcolor="#FFFFFF">0,185 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 13,827 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">163,379 ns</td><td align="right" bgcolor="#FFFFFF">149,669 ns</td><td align="right" bgcolor="#FFFFFF">162,488 ns</td><td align="right" bgcolor="#FFFFFF">160,661 ns</td><td align="right" bgcolor="#FFFFFF">163,101 ns</td><td align="right" bgcolor="#FFFFFF">163,496 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,150 μs</td><td align="right" bgcolor="#FFFFFF">0,162 μs</td><td align="right" bgcolor="#FFFFFF">0,161 μs</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#FFFFFF">170,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td><td align="right" bgcolor="#FFFFFF">0,166</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 17,571 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">212,381 ns</td><td align="right" bgcolor="#FFFFFF">215,541 ns</td><td align="right" bgcolor="#FFFFFF">197,971 ns</td><td align="right" bgcolor="#FFFFFF">213,456 ns</td><td align="right" bgcolor="#FFFFFF">211,512 ns</td><td align="right" bgcolor="#FFFFFF">212,981 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,212 μs</td><td align="right" bgcolor="#FFFFFF">0,216 μs</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,212 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">331,000</td><td align="right" bgcolor="#FFFFFF">331,000</td><td align="right" bgcolor="#FFFFFF">331,000</td><td align="right" bgcolor="#FFFFFF">331,000</td><td align="right" bgcolor="#FFFFFF">331,000</td><td align="right" bgcolor="#FFFFFF">331,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,323</td><td align="right" bgcolor="#FFFFFF">0,323</td><td align="right" bgcolor="#FFFFFF">0,323</td><td align="right" bgcolor="#FFFFFF">0,323</td><td align="right" bgcolor="#FFFFFF">0,323</td><td align="right" bgcolor="#FFFFFF">0,323</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ValidationSummary_Benchmark"></a>ValidationSummary_Benchmark

### <a name="ValidationSummary_Benchmark_BusinessRuleErrors"></a>BusinessRuleErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 1,248 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,909 ns</td><td align="right" bgcolor="#FFFFFF">5,315 ns</td><td align="right" bgcolor="#FFFFFF">6,157 ns</td><td align="right" bgcolor="#FFFFFF">5,640 ns</td><td align="right" bgcolor="#FFFFFF">4,936 ns</td><td align="right" bgcolor="#FFFFFF">5,904 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_BusinessRuleWarnings"></a>BusinessRuleWarnings

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 4,397 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,827 ns</td><td align="right" bgcolor="#FFFFFF">5,395 ns</td><td align="right" bgcolor="#FFFFFF">5,907 ns</td><td align="right" bgcolor="#FFFFFF">5,397 ns</td><td align="right" bgcolor="#FFFFFF">6,523 ns</td><td align="right" bgcolor="#FFFFFF">9,792 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldErrors"></a>FieldErrors

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 1,795 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,907 ns</td><td align="right" bgcolor="#FFFFFF">5,260 ns</td><td align="right" bgcolor="#FFFFFF">7,055 ns</td><td align="right" bgcolor="#FFFFFF">5,777 ns</td><td align="right" bgcolor="#FFFFFF">5,749 ns</td><td align="right" bgcolor="#FFFFFF">5,923 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldWarnings"></a>FieldWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 1,915 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,491 ns</td><td align="right" bgcolor="#FFFFFF">5,485 ns</td><td align="right" bgcolor="#FFFFFF">5,613 ns</td><td align="right" bgcolor="#FFFFFF">6,405 ns</td><td align="right" bgcolor="#FFFFFF">5,240 ns</td><td align="right" bgcolor="#FFFFFF">5,936 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasBusinessRuleErrors"></a>HasBusinessRuleErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 0,421 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ns</td><td align="right" bgcolor="#FFFFFF">0,427 ns</td><td align="right" bgcolor="#FFFFFF">0,083 ns</td><td align="right" bgcolor="#FFFFFF">0,104 ns</td><td align="right" bgcolor="#FFFFFF">0,029 ns</td><td align="right" bgcolor="#FFFFFF">0,429 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasBusinessRuleWarnings"></a>HasBusinessRuleWarnings

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 0,483 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,392 ns</td><td align="right" bgcolor="#FFFFFF">0,293 ns</td><td align="right" bgcolor="#FFFFFF">0,517 ns</td><td align="right" bgcolor="#FFFFFF">0,213 ns</td><td align="right" bgcolor="#FFFFFF">0,035 ns</td><td align="right" bgcolor="#FFFFFF">0,501 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 0,677 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,037 ns</td><td align="right" bgcolor="#FFFFFF">0,424 ns</td><td align="right" bgcolor="#FFFFFF">0,560 ns</td><td align="right" bgcolor="#FFFFFF">0,715 ns</td><td align="right" bgcolor="#FFFFFF">0,632 ns</td><td align="right" bgcolor="#FFFFFF">0,325 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldErrors"></a>HasFieldErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 0,928 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,547 ns</td><td align="right" bgcolor="#FFFFFF">0,376 ns</td><td align="right" bgcolor="#FFFFFF">0,723 ns</td><td align="right" bgcolor="#FFFFFF">0,403 ns</td><td align="right" bgcolor="#FFFFFF">0,053 ns</td><td align="right" bgcolor="#FFFFFF">0,981 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldWarnings"></a>HasFieldWarnings

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 0,531 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,397 ns</td><td align="right" bgcolor="#FFFFFF">0,360 ns</td><td align="right" bgcolor="#FFFFFF">0,296 ns</td><td align="right" bgcolor="#FFFFFF">0,709 ns</td><td align="right" bgcolor="#FFFFFF">0,179 ns</td><td align="right" bgcolor="#FFFFFF">0,421 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 1,737 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,173 ns</td><td align="right" bgcolor="#FFFFFF">1,911 ns</td><td align="right" bgcolor="#FFFFFF">0,776 ns</td><td align="right" bgcolor="#FFFFFF">0,811 ns</td><td align="right" bgcolor="#FFFFFF">0,663 ns</td><td align="right" bgcolor="#FFFFFF">0,389 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 220,276 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">693,939 ns</td><td align="right" bgcolor="#FFFFFF">912,400 ns</td><td align="right" bgcolor="#FFFFFF">692,124 ns</td><td align="right" bgcolor="#FFFFFF">701,641 ns</td><td align="right" bgcolor="#FFFFFF">714,731 ns</td><td align="right" bgcolor="#FFFFFF">719,275 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,694 μs</td><td align="right" bgcolor="#FFFFFF">0,912 μs</td><td align="right" bgcolor="#FFFFFF">0,692 μs</td><td align="right" bgcolor="#FFFFFF">0,702 μs</td><td align="right" bgcolor="#FFFFFF">0,715 μs</td><td align="right" bgcolor="#FFFFFF">0,719 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">741,000</td><td align="right" bgcolor="#FFFFFF">741,000</td><td align="right" bgcolor="#FFFFFF">741,000</td><td align="right" bgcolor="#FFFFFF">741,000</td><td align="right" bgcolor="#FFFFFF">741,000</td><td align="right" bgcolor="#FFFFFF">741,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,724</td><td align="right" bgcolor="#FFFFFF">0,724</td><td align="right" bgcolor="#FFFFFF">0,724</td><td align="right" bgcolor="#FFFFFF">0,724</td><td align="right" bgcolor="#FFFFFF">0,724</td><td align="right" bgcolor="#FFFFFF">0,724</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 9371,104 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+13,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,6 %</td><td align="right" bgcolor="#A8D08D">-15,3 %</td><td align="right" bgcolor="#FF4949">+53,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12129,685 ns</td><td align="right" bgcolor="#FF4949">13756,592 ns (Δ = +1626,907 ns)</td><td align="right" bgcolor="#FFFFFF">13586,827 ns</td><td align="right" bgcolor="#FF4949">16521,815 ns (Δ = +2934,988 ns)</td><td align="right" bgcolor="#A8D08D">14000,309 ns (Δ = -2521,505 ns)</td><td align="right" bgcolor="#FF4949">21500,789 ns (Δ = +7500,480 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">12,130 μs</td><td align="right" bgcolor="#FFFFFF">13,757 μs</td><td align="right" bgcolor="#FFFFFF">13,587 μs</td><td align="right" bgcolor="#FFFFFF">16,522 μs</td><td align="right" bgcolor="#FFFFFF">14,000 μs</td><td align="right" bgcolor="#FFFFFF">21,501 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,022 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.4.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.0.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+3,4 %</td><td align="right" bgcolor="#FF4949">+6,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">6536,000</td><td align="right" bgcolor="#FF4949">6875,000 (Δ = +339,000)</td><td align="right" bgcolor="#FFFFFF">6875,000</td><td align="right" bgcolor="#A8D08D">6874,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">7105,000 (Δ = +231,000)</td><td align="right" bgcolor="#FF4949">7588,000 (Δ = +483,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">6,383</td><td align="right" bgcolor="#FF4949">6,714 (Δ = +0,331)</td><td align="right" bgcolor="#FFFFFF">6,714</td><td align="right" bgcolor="#A8D08D">6,713 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">6,938 (Δ = +0,226)</td><td align="right" bgcolor="#FF4949">7,410 (Δ = +0,472)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FF4949">0,007 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,007 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,007 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,007 (Δ = +0,000)</td></tr></table>


