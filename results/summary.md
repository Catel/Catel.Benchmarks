# Benchmarks

Benchmark report generated on 17-okt-2019 10:05

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

7 item(s)

1. [ResourceHelper_Benchmark::GetString](#ResourceHelper_Benchmark_GetString) v5.12.0 is **489,76%** (Δ: 2655,075 ns) slower than v5.9.0

2. [LanguageHelper_Benchmark::GetString](#LanguageHelper_Benchmark_GetString) v5.12.0 is **415,73%** (Δ: 2192,352 ns) slower than v5.9.0

3. [ScopeManager_Benchmark::Get_Existing_ScopeManager](#ScopeManager_Benchmark_Get_Existing_ScopeManager) v5.12.0 is **304,34%** (Δ: 559,444 ns) slower than v5.9.0

4. [ScopeManager_Benchmark::Get_New_ScopeManager](#ScopeManager_Benchmark_Get_New_ScopeManager) v5.12.0 is **245,82%** (Δ: 469,897 ns) slower than v5.9.0

5. [ValidationContext_Benchmark::HasErrors](#ValidationContext_Benchmark_HasErrors) v5.12.0 is **130,92%** (Δ: 448,561 ns) slower than v5.9.0

6. [ValidationContext_Benchmark::HasWarnings](#ValidationContext_Benchmark_HasWarnings) v5.12.0 is **112,93%** (Δ: 341,139 ns) slower than v5.9.0

7. [ValidationContext_Benchmark::Initialization](#ValidationContext_Benchmark_Initialization) v5.12.0 is **54,78%** (Δ: 284,314 ns) slower than v5.9.0



### Improved (current version faster than previous one)

139 item(s)

1. [Serialization_Xml_Benchmark::SerializeLevel3Models](#Serialization_Xml_Benchmark_SerializeLevel3Models) v5.12.0 is **75,48%** (Δ: -3466477,892 ns) faster than v5.9.0

2. [Serialization_Xml_Benchmark::SerializeComplexObjectGraph](#Serialization_Xml_Benchmark_SerializeComplexObjectGraph) v5.12.0 is **69,24%** (Δ: -1361299,363 ns) faster than v5.9.0

3. [ExpressionHelper_Benchmark::GetOwner](#ExpressionHelper_Benchmark_GetOwner) v5.12.0 is **68,94%** (Δ: -2776,842 ns) faster than v5.9.0

4. [Serialization_Xml_Benchmark::SerializeLevel2Models](#Serialization_Xml_Benchmark_SerializeLevel2Models) v5.12.0 is **67,51%** (Δ: -899237,483 ns) faster than v5.9.0

5. [Serialization_Xml_Benchmark::SerializeLevel1Models](#Serialization_Xml_Benchmark_SerializeLevel1Models) v5.12.0 is **58,62%** (Δ: -399338,538 ns) faster than v5.9.0

6. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v5.12.0 is **58,47%** (Δ: -5849,270 ns) faster than v5.9.0

7. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType) v5.12.0 is **58,18%** (Δ: -3496,712 ns) faster than v5.9.0

8. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.12.0 is **57,75%** (Δ: -4579,660 ns) faster than v5.9.0

9. [Attribute_ReflectionExtensions_Benchmark::IsDecoratedWithAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type) v5.12.0 is **57,10%** (Δ: -2807,747 ns) faster than v5.9.0

10. [Attribute_ReflectionExtensions_Benchmark::TryGetAttribute_From_Member](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member) v5.12.0 is **57,03%** (Δ: -2311,213 ns) faster than v5.9.0

11. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx) v5.12.0 is **56,80%** (Δ: -3447,560 ns) faster than v5.9.0

12. [AssemblyExtensions_Benchmark::Company](#AssemblyExtensions_Benchmark_Company) v5.12.0 is **56,57%** (Δ: -7564,535 ns) faster than v5.9.0

13. [Attribute_ReflectionExtensions_Benchmark::TryGetAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type) v5.12.0 is **56,09%** (Δ: -2763,335 ns) faster than v5.9.0

14. [Type_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.12.0 is **55,94%** (Δ: -2735,631 ns) faster than v5.9.0

15. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.12.0 is **55,70%** (Δ: -3831,167 ns) faster than v5.9.0

16. [Attribute_ReflectionExtensions_Benchmark::TryGetAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type) v5.12.0 is **55,64%** (Δ: -2713,239 ns) faster than v5.9.0

17. [Type_ReflectionExtensions_Benchmark::GetCustomAttributeEx](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx) v5.12.0 is **55,62%** (Δ: -2755,973 ns) faster than v5.9.0

18. [Attribute_ReflectionExtensions_Benchmark::IsDecoratedWithAttribute_Generic_From_Member](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member) v5.12.0 is **55,42%** (Δ: -2290,266 ns) faster than v5.9.0

19. [Attribute_ReflectionExtensions_Benchmark::GetAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type) v5.12.0 is **55,20%** (Δ: -2754,424 ns) faster than v5.9.0

20. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx) v5.12.0 is **55,17%** (Δ: -3018,602 ns) faster than v5.9.0

21. [Attribute_ReflectionExtensions_Benchmark::GetAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type) v5.12.0 is **55,14%** (Δ: -2776,887 ns) faster than v5.9.0

22. [PropertyInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType](#PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType) v5.12.0 is **54,97%** (Δ: -3086,687 ns) faster than v5.9.0

23. [AssemblyExtensions_Benchmark::Description](#AssemblyExtensions_Benchmark_Description) v5.12.0 is **54,91%** (Δ: -7329,351 ns) faster than v5.9.0

24. [Attribute_ReflectionExtensions_Benchmark::IsDecoratedWithAttribute_From_Member](#Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member) v5.12.0 is **54,72%** (Δ: -2213,263 ns) faster than v5.9.0

25. [ExpressionHelper_Benchmark::GetPropertyName](#ExpressionHelper_Benchmark_GetPropertyName) v5.12.0 is **54,63%** (Δ: -3596,054 ns) faster than v5.9.0

Skipping 114 items since maximum list length is 25


## <a name="Argument_Benchmark"></a>Argument_Benchmark

### <a name="Argument_Benchmark_ImplementsInterface"></a>ImplementsInterface

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 66,408 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">87,835 ns</td><td align="right" bgcolor="#FFFFFF">84,204 ns</td><td align="right" bgcolor="#FFFFFF">141,374 ns</td><td align="right" bgcolor="#FFFFFF">142,040 ns</td><td align="right" bgcolor="#FFFFFF">148,631 ns</td><td align="right" bgcolor="#FFFFFF">82,222 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -154,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">154,000 (Δ = +154,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,150)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,150 (Δ = +0,150)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 102,870 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">91,397 ns</td><td align="right" bgcolor="#FFFFFF">84,027 ns</td><td align="right" bgcolor="#FFFFFF">144,322 ns</td><td align="right" bgcolor="#FFFFFF">143,331 ns</td><td align="right" bgcolor="#FFFFFF">180,718 ns</td><td align="right" bgcolor="#FFFFFF">77,848 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,181 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -154,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">154,000 (Δ = +154,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,150)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,150 (Δ = +0,150)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 68,085 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">82,256 ns</td><td align="right" bgcolor="#FFFFFF">79,388 ns</td><td align="right" bgcolor="#FFFFFF">133,675 ns</td><td align="right" bgcolor="#FFFFFF">133,082 ns</td><td align="right" bgcolor="#FFFFFF">143,426 ns</td><td align="right" bgcolor="#FFFFFF">75,341 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -154,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">154,000 (Δ = +154,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,150)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,150 (Δ = +0,150)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 73,919 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">111,687 ns</td><td align="right" bgcolor="#FFFFFF">84,097 ns</td><td align="right" bgcolor="#FFFFFF">142,642 ns</td><td align="right" bgcolor="#FFFFFF">146,652 ns</td><td align="right" bgcolor="#FFFFFF">151,359 ns</td><td align="right" bgcolor="#FFFFFF">77,439 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,151 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#FFFFFF">154,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -154,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">154,000 (Δ = +154,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#FFFFFF">0,150</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,150)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,150 (Δ = +0,150)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 18,126 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">37,787 ns</td><td align="right" bgcolor="#FFFFFF">32,864 ns</td><td align="right" bgcolor="#FFFFFF">50,542 ns</td><td align="right" bgcolor="#FFFFFF">50,990 ns</td><td align="right" bgcolor="#FFFFFF">48,992 ns</td><td align="right" bgcolor="#FFFFFF">36,606 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Generic"></a>InheritsFrom_Generic

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 20,708 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">39,775 ns</td><td align="right" bgcolor="#FFFFFF">40,788 ns</td><td align="right" bgcolor="#FFFFFF">56,916 ns</td><td align="right" bgcolor="#FFFFFF">56,925 ns</td><td align="right" bgcolor="#FFFFFF">56,867 ns</td><td align="right" bgcolor="#FFFFFF">36,217 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Object"></a>InheritsFrom_Object

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 24,382 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">39,098 ns</td><td align="right" bgcolor="#FFFFFF">38,973 ns</td><td align="right" bgcolor="#FFFFFF">55,311 ns</td><td align="right" bgcolor="#FFFFFF">56,239 ns</td><td align="right" bgcolor="#FFFFFF">59,242 ns</td><td align="right" bgcolor="#FFFFFF">34,861 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsMatch"></a>IsMatch

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 413,291 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+44,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">803,500 ns</td><td align="right" bgcolor="#FFFFFF">687,294 ns</td><td align="right" bgcolor="#FF4949">995,481 ns (Δ = +308,187 ns)</td><td align="right" bgcolor="#FFFFFF">1001,603 ns</td><td align="right" bgcolor="#FFFFFF">1017,296 ns</td><td align="right" bgcolor="#A8D08D">604,005 ns (Δ = -413,291 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,804 μs</td><td align="right" bgcolor="#FFFFFF">0,687 μs</td><td align="right" bgcolor="#FFFFFF">0,995 μs</td><td align="right" bgcolor="#FFFFFF">1,002 μs</td><td align="right" bgcolor="#FFFFFF">1,017 μs</td><td align="right" bgcolor="#FFFFFF">0,604 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -321,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">321,000 (Δ = +321,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,313 (Δ = +0,313)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsMaximum"></a>IsMaximum

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 12,075 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,293 ns</td><td align="right" bgcolor="#FFFFFF">12,957 ns</td><td align="right" bgcolor="#FFFFFF">21,492 ns</td><td align="right" bgcolor="#FFFFFF">23,076 ns</td><td align="right" bgcolor="#FFFFFF">23,351 ns</td><td align="right" bgcolor="#FFFFFF">11,276 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">25,000 (Δ = +25,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,024 (Δ = +0,024)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 12,162 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13,130 ns</td><td align="right" bgcolor="#FFFFFF">14,666 ns</td><td align="right" bgcolor="#FFFFFF">25,006 ns</td><td align="right" bgcolor="#FFFFFF">25,274 ns</td><td align="right" bgcolor="#FFFFFF">24,571 ns</td><td align="right" bgcolor="#FFFFFF">13,112 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">25,000 (Δ = +25,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,024 (Δ = +0,024)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 2,837 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,534 ns</td><td align="right" bgcolor="#FFFFFF">4,379 ns</td><td align="right" bgcolor="#FFFFFF">6,642 ns</td><td align="right" bgcolor="#FFFFFF">6,218 ns</td><td align="right" bgcolor="#FFFFFF">6,266 ns</td><td align="right" bgcolor="#FFFFFF">3,805 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotMatch"></a>IsNotMatch

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 264,789 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-34,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">534,072 ns</td><td align="right" bgcolor="#FFFFFF">525,215 ns</td><td align="right" bgcolor="#FFFFFF">740,522 ns</td><td align="right" bgcolor="#FFFFFF">737,337 ns</td><td align="right" bgcolor="#FFFFFF">758,157 ns</td><td align="right" bgcolor="#A8D08D">493,368 ns (Δ = -264,789 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,534 μs</td><td align="right" bgcolor="#FFFFFF">0,525 μs</td><td align="right" bgcolor="#FFFFFF">0,741 μs</td><td align="right" bgcolor="#FFFFFF">0,737 μs</td><td align="right" bgcolor="#FFFFFF">0,758 μs</td><td align="right" bgcolor="#FFFFFF">0,493 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -321,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">321,000 (Δ = +321,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,313 (Δ = +0,313)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsNotNull"></a>IsNotNull

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 1,721 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,580 ns</td><td align="right" bgcolor="#FFFFFF">0,533 ns</td><td align="right" bgcolor="#FFFFFF">1,785 ns</td><td align="right" bgcolor="#FFFFFF">1,806 ns</td><td align="right" bgcolor="#FFFFFF">2,180 ns</td><td align="right" bgcolor="#FFFFFF">0,459 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 2,067 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,683 ns</td><td align="right" bgcolor="#FFFFFF">0,132 ns</td><td align="right" bgcolor="#FFFFFF">1,332 ns</td><td align="right" bgcolor="#FFFFFF">2,199 ns</td><td align="right" bgcolor="#FFFFFF">2,192 ns</td><td align="right" bgcolor="#FFFFFF">0,387 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty_Guid"></a>IsNotNullOrEmpty_Guid

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 3,126 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,127 ns</td><td align="right" bgcolor="#FFFFFF">8,974 ns</td><td align="right" bgcolor="#FFFFFF">11,514 ns</td><td align="right" bgcolor="#FFFFFF">11,184 ns</td><td align="right" bgcolor="#FFFFFF">11,142 ns</td><td align="right" bgcolor="#FFFFFF">8,387 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmptyArray"></a>IsNotNullOrEmptyArray

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 2,189 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,527 ns</td><td align="right" bgcolor="#FFFFFF">2,958 ns</td><td align="right" bgcolor="#FFFFFF">4,624 ns</td><td align="right" bgcolor="#FFFFFF">5,019 ns</td><td align="right" bgcolor="#FFFFFF">5,022 ns</td><td align="right" bgcolor="#FFFFFF">2,833 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrWhitespace"></a>IsNotNullOrWhitespace

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 17,410 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,814 ns</td><td align="right" bgcolor="#FFFFFF">11,061 ns</td><td align="right" bgcolor="#FFFFFF">21,383 ns</td><td align="right" bgcolor="#FFFFFF">21,610 ns</td><td align="right" bgcolor="#FFFFFF">8,658 ns</td><td align="right" bgcolor="#FFFFFF">4,199 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes"></a>IsNotOfOneOfTheTypes

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 64,103 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">70,037 ns</td><td align="right" bgcolor="#FFFFFF">66,537 ns</td><td align="right" bgcolor="#FFFFFF">128,034 ns</td><td align="right" bgcolor="#FFFFFF">130,640 ns</td><td align="right" bgcolor="#FFFFFF">124,993 ns</td><td align="right" bgcolor="#FFFFFF">72,139 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes_Object"></a>IsNotOfOneOfTheTypes_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 66,813 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">80,873 ns</td><td align="right" bgcolor="#FFFFFF">71,122 ns</td><td align="right" bgcolor="#FFFFFF">136,349 ns</td><td align="right" bgcolor="#FFFFFF">137,935 ns</td><td align="right" bgcolor="#FFFFFF">133,687 ns</td><td align="right" bgcolor="#FFFFFF">71,727 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType"></a>IsNotOfType

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 35,973 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">49,289 ns</td><td align="right" bgcolor="#FFFFFF">49,519 ns</td><td align="right" bgcolor="#FFFFFF">78,679 ns</td><td align="right" bgcolor="#FFFFFF">79,348 ns</td><td align="right" bgcolor="#FFFFFF">78,534 ns</td><td align="right" bgcolor="#FFFFFF">43,375 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType_Object"></a>IsNotOfType_Object

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 40,287 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">67,455 ns</td><td align="right" bgcolor="#FFFFFF">54,361 ns</td><td align="right" bgcolor="#FFFFFF">85,921 ns</td><td align="right" bgcolor="#FFFFFF">86,378 ns</td><td align="right" bgcolor="#FFFFFF">92,514 ns</td><td align="right" bgcolor="#FFFFFF">52,227 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOutOfRange"></a>IsNotOutOfRange

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 16,686 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">23,846 ns</td><td align="right" bgcolor="#FFFFFF">19,535 ns</td><td align="right" bgcolor="#FFFFFF">34,619 ns</td><td align="right" bgcolor="#FFFFFF">34,449 ns</td><td align="right" bgcolor="#FFFFFF">34,458 ns</td><td align="right" bgcolor="#FFFFFF">17,932 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -49,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">49,000 (Δ = +49,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,048)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,048 (Δ = +0,048)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes"></a>IsOfOneOfTheTypes

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 42,457 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">64,528 ns</td><td align="right" bgcolor="#FFFFFF">48,928 ns</td><td align="right" bgcolor="#FFFFFF">79,041 ns</td><td align="right" bgcolor="#FFFFFF">79,994 ns</td><td align="right" bgcolor="#FFFFFF">90,894 ns</td><td align="right" bgcolor="#FFFFFF">48,436 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfOneOfTheTypes_Object"></a>IsOfOneOfTheTypes_Object

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 32,513 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">56,250 ns</td><td align="right" bgcolor="#FFFFFF">59,099 ns</td><td align="right" bgcolor="#FFFFFF">88,156 ns</td><td align="right" bgcolor="#FFFFFF">88,236 ns</td><td align="right" bgcolor="#FFFFFF">88,243 ns</td><td align="right" bgcolor="#FFFFFF">55,731 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType"></a>IsOfType

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 25,572 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">33,053 ns</td><td align="right" bgcolor="#FFFFFF">32,945 ns</td><td align="right" bgcolor="#FFFFFF">53,676 ns</td><td align="right" bgcolor="#FFFFFF">56,001 ns</td><td align="right" bgcolor="#FFFFFF">56,137 ns</td><td align="right" bgcolor="#FFFFFF">30,566 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType_Object"></a>IsOfType_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 27,034 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">45,484 ns</td><td align="right" bgcolor="#FFFFFF">39,674 ns</td><td align="right" bgcolor="#FFFFFF">64,223 ns</td><td align="right" bgcolor="#FFFFFF">63,180 ns</td><td align="right" bgcolor="#FFFFFF">66,708 ns</td><td align="right" bgcolor="#FFFFFF">40,439 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td><td align="right" bgcolor="#FFFFFF">0,063 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="Assembly_ReflectionExtensions_Benchmark"></a>Assembly_ReflectionExtensions_Benchmark

### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 5680,064 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#FF4949">+87,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5246,409 ns</td><td align="right" bgcolor="#FF4949">5698,213 ns (Δ = +451,805 ns)</td><td align="right" bgcolor="#FF4949">10674,938 ns (Δ = +4976,725 ns)</td><td align="right" bgcolor="#FFFFFF">10827,035 ns</td><td align="right" bgcolor="#FFFFFF">10926,473 ns</td><td align="right" bgcolor="#A8D08D">5282,203 ns (Δ = -5644,269 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,246 μs</td><td align="right" bgcolor="#FFFFFF">5,698 μs</td><td align="right" bgcolor="#FFFFFF">10,675 μs</td><td align="right" bgcolor="#FFFFFF">10,827 μs</td><td align="right" bgcolor="#FFFFFF">10,926 μs</td><td align="right" bgcolor="#FFFFFF">5,282 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -731,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">731,000 (Δ = +731,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,714)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,714 (Δ = +0,714)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 5575,008 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,1 %</td><td align="right" bgcolor="#FF4949">+97,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5902,587 ns</td><td align="right" bgcolor="#A8D08D">5425,958 ns (Δ = -476,629 ns)</td><td align="right" bgcolor="#FF4949">10714,677 ns (Δ = +5288,719 ns)</td><td align="right" bgcolor="#FFFFFF">10665,804 ns</td><td align="right" bgcolor="#FFFFFF">10754,432 ns</td><td align="right" bgcolor="#A8D08D">5179,424 ns (Δ = -5575,008 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,903 μs</td><td align="right" bgcolor="#FFFFFF">5,426 μs</td><td align="right" bgcolor="#FFFFFF">10,715 μs</td><td align="right" bgcolor="#FFFFFF">10,666 μs</td><td align="right" bgcolor="#FFFFFF">10,754 μs</td><td align="right" bgcolor="#FFFFFF">5,179 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#FFFFFF">731,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -731,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">731,000 (Δ = +731,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#FFFFFF">0,714</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,714)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,714 (Δ = +0,714)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 11110,683 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,1 %</td><td align="right" bgcolor="#FF4949">+77,0 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13253,972 ns</td><td align="right" bgcolor="#A8D08D">12574,195 ns (Δ = -679,777 ns)</td><td align="right" bgcolor="#FF4949">22250,956 ns (Δ = +9676,761 ns)</td><td align="right" bgcolor="#A8D08D">21362,228 ns (Δ = -888,728 ns)</td><td align="right" bgcolor="#FFFFFF">21372,731 ns</td><td align="right" bgcolor="#A8D08D">11140,273 ns (Δ = -10232,458 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13,254 μs</td><td align="right" bgcolor="#FFFFFF">12,574 μs</td><td align="right" bgcolor="#FFFFFF">22,251 μs</td><td align="right" bgcolor="#FFFFFF">21,362 μs</td><td align="right" bgcolor="#FFFFFF">21,373 μs</td><td align="right" bgcolor="#FFFFFF">11,140 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,022 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#A8D08D">3,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1382,000</td><td align="right" bgcolor="#FFFFFF">1382,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1382,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1382,000 (Δ = +1382,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,350</td><td align="right" bgcolor="#FFFFFF">1,350</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,350)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,350 (Δ = +1,350)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 4807,946 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,5 %</td><td align="right" bgcolor="#FF4949">+80,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5751,154 ns</td><td align="right" bgcolor="#A8D08D">5432,226 ns (Δ = -318,928 ns)</td><td align="right" bgcolor="#FF4949">9820,218 ns (Δ = +4387,992 ns)</td><td align="right" bgcolor="#FFFFFF">9752,663 ns</td><td align="right" bgcolor="#FFFFFF">9791,507 ns</td><td align="right" bgcolor="#A8D08D">5012,272 ns (Δ = -4779,235 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,751 μs</td><td align="right" bgcolor="#FFFFFF">5,432 μs</td><td align="right" bgcolor="#FFFFFF">9,820 μs</td><td align="right" bgcolor="#FFFFFF">9,753 μs</td><td align="right" bgcolor="#FFFFFF">9,792 μs</td><td align="right" bgcolor="#FFFFFF">5,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FF4949">9,000 (Δ = +2,000)</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#A8D08D">7,000 (Δ = -2,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3051,000</td><td align="right" bgcolor="#FFFFFF">3051,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -3051,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">3051,000 (Δ = +3051,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,979</td><td align="right" bgcolor="#FFFFFF">2,979</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2,979)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">2,979 (Δ = +2,979)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,003)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,003)</td></tr></table>


## <a name="AssemblyExtensions_Benchmark"></a>AssemblyExtensions_Benchmark

### <a name="AssemblyExtensions_Benchmark_Company"></a>Company

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 7837,844 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,8 %</td><td align="right" bgcolor="#FF4949">+112,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-56,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6739,471 ns</td><td align="right" bgcolor="#A8D08D">6417,069 ns (Δ = -322,402 ns)</td><td align="right" bgcolor="#FF4949">13645,066 ns (Δ = +7227,997 ns)</td><td align="right" bgcolor="#FFFFFF">13489,748 ns</td><td align="right" bgcolor="#FFFFFF">13371,756 ns</td><td align="right" bgcolor="#A8D08D">5807,222 ns (Δ = -7564,535 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,739 μs</td><td align="right" bgcolor="#FFFFFF">6,417 μs</td><td align="right" bgcolor="#FFFFFF">13,645 μs</td><td align="right" bgcolor="#FFFFFF">13,490 μs</td><td align="right" bgcolor="#FFFFFF">13,372 μs</td><td align="right" bgcolor="#FFFFFF">5,807 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -836,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">860,000 (Δ = +860,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,816)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,840 (Δ = +0,840)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 7333,955 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,4 %</td><td align="right" bgcolor="#FF4949">+115,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-53,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6839,924 ns</td><td align="right" bgcolor="#A8D08D">6336,695 ns (Δ = -503,229 ns)</td><td align="right" bgcolor="#FF4949">13670,649 ns (Δ = +7333,955 ns)</td><td align="right" bgcolor="#FFFFFF">13657,724 ns</td><td align="right" bgcolor="#FFFFFF">13614,626 ns</td><td align="right" bgcolor="#A8D08D">6396,157 ns (Δ = -7218,469 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,840 μs</td><td align="right" bgcolor="#FFFFFF">6,337 μs</td><td align="right" bgcolor="#FFFFFF">13,671 μs</td><td align="right" bgcolor="#FFFFFF">13,658 μs</td><td align="right" bgcolor="#FFFFFF">13,615 μs</td><td align="right" bgcolor="#FFFFFF">6,396 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">883,000</td><td align="right" bgcolor="#FFFFFF">883,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -883,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">908,000 (Δ = +908,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,862</td><td align="right" bgcolor="#FFFFFF">0,862</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,862)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,887 (Δ = +0,887)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Description"></a>Description

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 7329,351 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+113,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-54,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6257,234 ns</td><td align="right" bgcolor="#FFFFFF">6200,859 ns</td><td align="right" bgcolor="#FF4949">13229,529 ns (Δ = +7028,670 ns)</td><td align="right" bgcolor="#FFFFFF">13268,586 ns</td><td align="right" bgcolor="#FFFFFF">13347,221 ns</td><td align="right" bgcolor="#A8D08D">6017,870 ns (Δ = -7329,351 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,257 μs</td><td align="right" bgcolor="#FFFFFF">6,201 μs</td><td align="right" bgcolor="#FFFFFF">13,230 μs</td><td align="right" bgcolor="#FFFFFF">13,269 μs</td><td align="right" bgcolor="#FFFFFF">13,347 μs</td><td align="right" bgcolor="#FFFFFF">6,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -852,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">877,000 (Δ = +877,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,832)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,856 (Δ = +0,856)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 258221,470 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#FF4949">+80,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,1 %</td><td align="right" bgcolor="#A8D08D">-45,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">331753,932 ns</td><td align="right" bgcolor="#A8D08D">310785,109 ns (Δ = -20968,824 ns)</td><td align="right" bgcolor="#FF4949">561139,668 ns (Δ = +250354,560 ns)</td><td align="right" bgcolor="#FFFFFF">561220,130 ns</td><td align="right" bgcolor="#FF4949">567157,759 ns (Δ = +5937,630 ns)</td><td align="right" bgcolor="#A8D08D">308936,289 ns (Δ = -258221,470 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">331,754 μs</td><td align="right" bgcolor="#FFFFFF">310,785 μs</td><td align="right" bgcolor="#FF4949">561,140 μs (Δ = +250,355 μs)</td><td align="right" bgcolor="#FFFFFF">561,220 μs</td><td align="right" bgcolor="#FFFFFF">567,158 μs</td><td align="right" bgcolor="#A8D08D">308,936 μs (Δ = -258,221 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,332 ms</td><td align="right" bgcolor="#FFFFFF">0,311 ms</td><td align="right" bgcolor="#FFFFFF">0,561 ms</td><td align="right" bgcolor="#FFFFFF">0,561 ms</td><td align="right" bgcolor="#FFFFFF">0,567 ms</td><td align="right" bgcolor="#FFFFFF">0,309 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FF4949">65,000 (Δ = +16,000)</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#FFFFFF">65,000</td><td align="right" bgcolor="#A8D08D">49,000 (Δ = -16,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FF4949">7,000 (Δ = +3,000)</td><td align="right" bgcolor="#A8D08D">5,000 (Δ = -2,000)</td><td align="right" bgcolor="#FF4949">6,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">4,000 (Δ = -2,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20690,000</td><td align="right" bgcolor="#FFFFFF">20690,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -20690,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">20690,000 (Δ = +20690,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">20,205</td><td align="right" bgcolor="#FFFFFF">20,205</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -20,205)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">20,205 (Δ = +20,205)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,020)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,020 (Δ = +0,020)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 2103,148 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,9 %</td><td align="right" bgcolor="#FF4949">+82,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2966,369 ns</td><td align="right" bgcolor="#A8D08D">2404,451 ns (Δ = -561,918 ns)</td><td align="right" bgcolor="#FF4949">4384,953 ns (Δ = +1980,502 ns)</td><td align="right" bgcolor="#FFFFFF">4436,527 ns</td><td align="right" bgcolor="#FFFFFF">4330,398 ns</td><td align="right" bgcolor="#A8D08D">2333,379 ns (Δ = -1997,019 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,966 μs</td><td align="right" bgcolor="#FFFFFF">2,404 μs</td><td align="right" bgcolor="#FFFFFF">4,385 μs</td><td align="right" bgcolor="#FFFFFF">4,437 μs</td><td align="right" bgcolor="#FFFFFF">4,330 μs</td><td align="right" bgcolor="#FFFFFF">2,333 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1068,000</td><td align="right" bgcolor="#FFFFFF">1068,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1068,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1068,000 (Δ = +1068,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,043</td><td align="right" bgcolor="#FFFFFF">1,043</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,043)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,043 (Δ = +1,043)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 5657,157 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,7 %</td><td align="right" bgcolor="#FF4949">+102,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6206,149 ns</td><td align="right" bgcolor="#A8D08D">5357,906 ns (Δ = -848,243 ns)</td><td align="right" bgcolor="#FF4949">10856,369 ns (Δ = +5498,464 ns)</td><td align="right" bgcolor="#FFFFFF">11015,063 ns</td><td align="right" bgcolor="#FFFFFF">10969,099 ns</td><td align="right" bgcolor="#A8D08D">5373,010 ns (Δ = -5596,089 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,206 μs</td><td align="right" bgcolor="#FFFFFF">5,358 μs</td><td align="right" bgcolor="#FFFFFF">10,856 μs</td><td align="right" bgcolor="#FFFFFF">11,015 μs</td><td align="right" bgcolor="#FFFFFF">10,969 μs</td><td align="right" bgcolor="#FFFFFF">5,373 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">772,000</td><td align="right" bgcolor="#FFFFFF">772,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -772,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">772,000 (Δ = +772,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,754</td><td align="right" bgcolor="#FFFFFF">0,754</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,754)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,754 (Δ = +0,754)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Product"></a>Product

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 7289,064 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,0 %</td><td align="right" bgcolor="#FF4949">+106,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-53,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7146,116 ns</td><td align="right" bgcolor="#A8D08D">6575,874 ns (Δ = -570,243 ns)</td><td align="right" bgcolor="#FF4949">13548,295 ns (Δ = +6972,422 ns)</td><td align="right" bgcolor="#FFFFFF">13535,166 ns</td><td align="right" bgcolor="#FFFFFF">13417,947 ns</td><td align="right" bgcolor="#A8D08D">6259,231 ns (Δ = -7158,716 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,146 μs</td><td align="right" bgcolor="#FFFFFF">6,576 μs</td><td align="right" bgcolor="#FFFFFF">13,548 μs</td><td align="right" bgcolor="#FFFFFF">13,535 μs</td><td align="right" bgcolor="#FFFFFF">13,418 μs</td><td align="right" bgcolor="#FFFFFF">6,259 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -852,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">877,000 (Δ = +877,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,832)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,856 (Δ = +0,856)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Title"></a>Title

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 7705,689 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,1 %</td><td align="right" bgcolor="#FF4949">+131,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-54,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6290,236 ns</td><td align="right" bgcolor="#A8D08D">5841,525 ns (Δ = -448,711 ns)</td><td align="right" bgcolor="#FF4949">13540,677 ns (Δ = +7699,153 ns)</td><td align="right" bgcolor="#FFFFFF">13547,214 ns</td><td align="right" bgcolor="#FFFFFF">13490,582 ns</td><td align="right" bgcolor="#A8D08D">6134,592 ns (Δ = -7355,989 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,290 μs</td><td align="right" bgcolor="#FFFFFF">5,842 μs</td><td align="right" bgcolor="#FFFFFF">13,541 μs</td><td align="right" bgcolor="#FFFFFF">13,547 μs</td><td align="right" bgcolor="#FFFFFF">13,491 μs</td><td align="right" bgcolor="#FFFFFF">6,135 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -852,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">877,000 (Δ = +877,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,832)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,856 (Δ = +0,856)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Version"></a>Version

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 680,226 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+56,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">931,561 ns</td><td align="right" bgcolor="#FFFFFF">937,817 ns</td><td align="right" bgcolor="#FF4949">1469,052 ns (Δ = +531,236 ns)</td><td align="right" bgcolor="#FFFFFF">1589,879 ns</td><td align="right" bgcolor="#FFFFFF">1435,758 ns</td><td align="right" bgcolor="#A8D08D">909,653 ns (Δ = -526,105 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,932 μs</td><td align="right" bgcolor="#FFFFFF">0,938 μs</td><td align="right" bgcolor="#FFFFFF">1,469 μs</td><td align="right" bgcolor="#FFFFFF">1,590 μs</td><td align="right" bgcolor="#FFFFFF">1,436 μs</td><td align="right" bgcolor="#FFFFFF">0,910 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#A8D08D">3,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1268,000</td><td align="right" bgcolor="#FFFFFF">1268,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1268,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1268,000 (Δ = +1268,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,238</td><td align="right" bgcolor="#FFFFFF">1,238</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,238)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,238 (Δ = +1,238)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 2260,758 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,7 %</td><td align="right" bgcolor="#FF4949">+120,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-54,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2163,610 ns</td><td align="right" bgcolor="#A8D08D">1867,008 ns (Δ = -296,602 ns)</td><td align="right" bgcolor="#FF4949">4120,100 ns (Δ = +2253,092 ns)</td><td align="right" bgcolor="#FFFFFF">3897,046 ns</td><td align="right" bgcolor="#FFFFFF">4084,201 ns</td><td align="right" bgcolor="#A8D08D">1859,342 ns (Δ = -2224,859 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,164 μs</td><td align="right" bgcolor="#FFFFFF">1,867 μs</td><td align="right" bgcolor="#FFFFFF">4,120 μs</td><td align="right" bgcolor="#FFFFFF">3,897 μs</td><td align="right" bgcolor="#FFFFFF">4,084 μs</td><td align="right" bgcolor="#FFFFFF">1,859 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -249,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">249,000 (Δ = +249,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,243)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,243 (Δ = +0,243)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 2835,876 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,6 %</td><td align="right" bgcolor="#FF4949">+126,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-55,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2534,476 ns</td><td align="right" bgcolor="#A8D08D">2240,907 ns (Δ = -293,569 ns)</td><td align="right" bgcolor="#FF4949">5071,483 ns (Δ = +2830,576 ns)</td><td align="right" bgcolor="#FFFFFF">4976,891 ns</td><td align="right" bgcolor="#FFFFFF">4990,031 ns</td><td align="right" bgcolor="#A8D08D">2235,607 ns (Δ = -2754,424 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,534 μs</td><td align="right" bgcolor="#FFFFFF">2,241 μs</td><td align="right" bgcolor="#FFFFFF">5,071 μs</td><td align="right" bgcolor="#FFFFFF">4,977 μs</td><td align="right" bgcolor="#FFFFFF">4,990 μs</td><td align="right" bgcolor="#FFFFFF">2,236 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -282,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">282,000 (Δ = +282,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,275)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,275 (Δ = +0,275)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 2290,216 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+113,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1878,596 ns</td><td align="right" bgcolor="#FFFFFF">1956,190 ns</td><td align="right" bgcolor="#FF4949">4168,812 ns (Δ = +2212,622 ns)</td><td align="right" bgcolor="#FFFFFF">4166,677 ns</td><td align="right" bgcolor="#FFFFFF">4019,515 ns</td><td align="right" bgcolor="#A8D08D">1902,201 ns (Δ = -2117,314 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,879 μs</td><td align="right" bgcolor="#FFFFFF">1,956 μs</td><td align="right" bgcolor="#FFFFFF">4,169 μs</td><td align="right" bgcolor="#FFFFFF">4,167 μs</td><td align="right" bgcolor="#FFFFFF">4,020 μs</td><td align="right" bgcolor="#FFFFFF">1,902 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -249,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">249,000 (Δ = +249,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,243)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,243 (Δ = +0,243)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 2856,248 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,9 %</td><td align="right" bgcolor="#FF4949">+119,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-55,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2618,684 ns</td><td align="right" bgcolor="#A8D08D">2334,461 ns (Δ = -284,223 ns)</td><td align="right" bgcolor="#FF4949">5115,187 ns (Δ = +2780,726 ns)</td><td align="right" bgcolor="#FFFFFF">4900,223 ns</td><td align="right" bgcolor="#FFFFFF">5035,826 ns</td><td align="right" bgcolor="#A8D08D">2258,939 ns (Δ = -2776,887 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,619 μs</td><td align="right" bgcolor="#FFFFFF">2,334 μs</td><td align="right" bgcolor="#FFFFFF">5,115 μs</td><td align="right" bgcolor="#FFFFFF">4,900 μs</td><td align="right" bgcolor="#FFFFFF">5,036 μs</td><td align="right" bgcolor="#FFFFFF">2,259 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -282,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">282,000 (Δ = +282,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,275)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,275 (Δ = +0,275)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 2290,273 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+113,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-54,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2128,413 ns</td><td align="right" bgcolor="#FFFFFF">1929,011 ns</td><td align="right" bgcolor="#FF4949">4121,391 ns (Δ = +2192,379 ns)</td><td align="right" bgcolor="#FFFFFF">4076,694 ns</td><td align="right" bgcolor="#FFFFFF">4044,381 ns</td><td align="right" bgcolor="#A8D08D">1831,118 ns (Δ = -2213,263 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,128 μs</td><td align="right" bgcolor="#FFFFFF">1,929 μs</td><td align="right" bgcolor="#FFFFFF">4,121 μs</td><td align="right" bgcolor="#FFFFFF">4,077 μs</td><td align="right" bgcolor="#FFFFFF">4,044 μs</td><td align="right" bgcolor="#FFFFFF">1,831 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -249,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">249,000 (Δ = +249,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,243)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,243 (Δ = +0,243)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 2709,809 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+119,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-53,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2434,439 ns</td><td align="right" bgcolor="#FFFFFF">2275,950 ns</td><td align="right" bgcolor="#FF4949">4985,760 ns (Δ = +2709,809 ns)</td><td align="right" bgcolor="#FFFFFF">4928,296 ns</td><td align="right" bgcolor="#FFFFFF">4847,555 ns</td><td align="right" bgcolor="#A8D08D">2278,956 ns (Δ = -2568,599 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,434 μs</td><td align="right" bgcolor="#FFFFFF">2,276 μs</td><td align="right" bgcolor="#FFFFFF">4,986 μs</td><td align="right" bgcolor="#FFFFFF">4,928 μs</td><td align="right" bgcolor="#FFFFFF">4,848 μs</td><td align="right" bgcolor="#FFFFFF">2,279 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -282,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">282,000 (Δ = +282,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,275)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,275 (Δ = +0,275)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 2351,365 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-30,2 %</td><td align="right" bgcolor="#FF4949">+122,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-55,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2708,313 ns</td><td align="right" bgcolor="#A8D08D">1889,150 ns (Δ = -819,163 ns)</td><td align="right" bgcolor="#FF4949">4193,405 ns (Δ = +2304,254 ns)</td><td align="right" bgcolor="#FFFFFF">4096,159 ns</td><td align="right" bgcolor="#FFFFFF">4132,305 ns</td><td align="right" bgcolor="#A8D08D">1842,039 ns (Δ = -2290,266 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,708 μs</td><td align="right" bgcolor="#FFFFFF">1,889 μs</td><td align="right" bgcolor="#FFFFFF">4,193 μs</td><td align="right" bgcolor="#FFFFFF">4,096 μs</td><td align="right" bgcolor="#FFFFFF">4,132 μs</td><td align="right" bgcolor="#FFFFFF">1,842 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -249,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">249,000 (Δ = +249,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,243)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,243 (Δ = +0,243)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 3038,620 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+112,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-57,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2480,602 ns</td><td align="right" bgcolor="#FFFFFF">2378,522 ns</td><td align="right" bgcolor="#FF4949">5044,751 ns (Δ = +2666,229 ns)</td><td align="right" bgcolor="#FFFFFF">5148,201 ns</td><td align="right" bgcolor="#FFFFFF">4917,328 ns</td><td align="right" bgcolor="#A8D08D">2109,581 ns (Δ = -2807,747 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,481 μs</td><td align="right" bgcolor="#FFFFFF">2,379 μs</td><td align="right" bgcolor="#FFFFFF">5,045 μs</td><td align="right" bgcolor="#FFFFFF">5,148 μs</td><td align="right" bgcolor="#FFFFFF">4,917 μs</td><td align="right" bgcolor="#FFFFFF">2,110 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -282,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">282,000 (Δ = +282,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,275)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,275 (Δ = +0,275)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 2311,213 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+111,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-57,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1938,399 ns</td><td align="right" bgcolor="#FFFFFF">1909,857 ns</td><td align="right" bgcolor="#FF4949">4033,368 ns (Δ = +2123,510 ns)</td><td align="right" bgcolor="#FFFFFF">4001,600 ns</td><td align="right" bgcolor="#FFFFFF">4052,976 ns</td><td align="right" bgcolor="#A8D08D">1741,763 ns (Δ = -2311,213 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,938 μs</td><td align="right" bgcolor="#FFFFFF">1,910 μs</td><td align="right" bgcolor="#FFFFFF">4,033 μs</td><td align="right" bgcolor="#FFFFFF">4,002 μs</td><td align="right" bgcolor="#FFFFFF">4,053 μs</td><td align="right" bgcolor="#FFFFFF">1,742 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -249,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">249,000 (Δ = +249,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,243)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,243 (Δ = +0,243)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 2992,305 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+121,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,4 %</td><td align="right" bgcolor="#A8D08D">-55,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2274,323 ns</td><td align="right" bgcolor="#FFFFFF">2301,272 ns</td><td align="right" bgcolor="#FF4949">5089,995 ns (Δ = +2788,723 ns)</td><td align="right" bgcolor="#FFFFFF">5155,852 ns</td><td align="right" bgcolor="#A8D08D">4876,786 ns (Δ = -279,066 ns)</td><td align="right" bgcolor="#A8D08D">2163,547 ns (Δ = -2713,239 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,274 μs</td><td align="right" bgcolor="#FFFFFF">2,301 μs</td><td align="right" bgcolor="#FFFFFF">5,090 μs</td><td align="right" bgcolor="#FFFFFF">5,156 μs</td><td align="right" bgcolor="#FFFFFF">4,877 μs</td><td align="right" bgcolor="#FFFFFF">2,164 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -282,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">282,000 (Δ = +282,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,275)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,275 (Δ = +0,275)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 2229,114 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+109,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-53,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2013,550 ns</td><td align="right" bgcolor="#FFFFFF">1930,571 ns</td><td align="right" bgcolor="#FF4949">4047,553 ns (Δ = +2116,982 ns)</td><td align="right" bgcolor="#FFFFFF">4107,198 ns</td><td align="right" bgcolor="#FFFFFF">4135,586 ns</td><td align="right" bgcolor="#A8D08D">1906,472 ns (Δ = -2229,114 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,014 μs</td><td align="right" bgcolor="#FFFFFF">1,931 μs</td><td align="right" bgcolor="#FFFFFF">4,048 μs</td><td align="right" bgcolor="#FFFFFF">4,107 μs</td><td align="right" bgcolor="#FFFFFF">4,136 μs</td><td align="right" bgcolor="#FFFFFF">1,906 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#FFFFFF">249,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -249,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">249,000 (Δ = +249,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#FFFFFF">0,243</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,243)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,243 (Δ = +0,243)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 2933,809 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,6 %</td><td align="right" bgcolor="#FF4949">+125,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-56,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2811,397 ns</td><td align="right" bgcolor="#A8D08D">2260,234 ns (Δ = -551,163 ns)</td><td align="right" bgcolor="#FF4949">5097,256 ns (Δ = +2837,022 ns)</td><td align="right" bgcolor="#FFFFFF">5008,380 ns</td><td align="right" bgcolor="#FFFFFF">4926,782 ns</td><td align="right" bgcolor="#A8D08D">2163,447 ns (Δ = -2763,335 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,811 μs</td><td align="right" bgcolor="#FFFFFF">2,260 μs</td><td align="right" bgcolor="#FFFFFF">5,097 μs</td><td align="right" bgcolor="#FFFFFF">5,008 μs</td><td align="right" bgcolor="#FFFFFF">4,927 μs</td><td align="right" bgcolor="#FFFFFF">2,163 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -282,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">282,000 (Δ = +282,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,275)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,275 (Δ = +0,275)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 96,208 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">287,723 ns</td><td align="right" bgcolor="#FFFFFF">253,816 ns</td><td align="right" bgcolor="#FFFFFF">314,633 ns</td><td align="right" bgcolor="#FFFFFF">316,208 ns</td><td align="right" bgcolor="#FFFFFF">350,025 ns</td><td align="right" bgcolor="#FFFFFF">265,114 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,288 μs</td><td align="right" bgcolor="#FFFFFF">0,254 μs</td><td align="right" bgcolor="#FFFFFF">0,315 μs</td><td align="right" bgcolor="#FFFFFF">0,316 μs</td><td align="right" bgcolor="#FFFFFF">0,350 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">218,000</td><td align="right" bgcolor="#FFFFFF">218,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -218,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">218,000 (Δ = +218,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,213</td><td align="right" bgcolor="#FFFFFF">0,213</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,213)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,213 (Δ = +0,213)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 82,298 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">338,733 ns</td><td align="right" bgcolor="#FFFFFF">256,435 ns</td><td align="right" bgcolor="#FFFFFF">304,942 ns</td><td align="right" bgcolor="#FFFFFF">308,739 ns</td><td align="right" bgcolor="#FFFFFF">312,255 ns</td><td align="right" bgcolor="#FFFFFF">266,207 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,339 μs</td><td align="right" bgcolor="#FFFFFF">0,256 μs</td><td align="right" bgcolor="#FFFFFF">0,305 μs</td><td align="right" bgcolor="#FFFFFF">0,309 μs</td><td align="right" bgcolor="#FFFFFF">0,312 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -138,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">138,000 (Δ = +138,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,135)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,135 (Δ = +0,135)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 83,265 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">264,212 ns</td><td align="right" bgcolor="#FFFFFF">245,791 ns</td><td align="right" bgcolor="#FFFFFF">307,334 ns</td><td align="right" bgcolor="#FFFFFF">307,673 ns</td><td align="right" bgcolor="#FFFFFF">329,056 ns</td><td align="right" bgcolor="#FFFFFF">260,185 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td><td align="right" bgcolor="#FFFFFF">0,246 μs</td><td align="right" bgcolor="#FFFFFF">0,307 μs</td><td align="right" bgcolor="#FFFFFF">0,308 μs</td><td align="right" bgcolor="#FFFFFF">0,329 μs</td><td align="right" bgcolor="#FFFFFF">0,260 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -138,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">138,000 (Δ = +138,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#FFFFFF">0,135</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,135)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,135 (Δ = +0,135)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 60,720 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">240,521 ns</td><td align="right" bgcolor="#FFFFFF">226,030 ns</td><td align="right" bgcolor="#FFFFFF">277,959 ns</td><td align="right" bgcolor="#FFFFFF">278,834 ns</td><td align="right" bgcolor="#FFFFFF">286,750 ns</td><td align="right" bgcolor="#FFFFFF">239,678 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,241 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td><td align="right" bgcolor="#FFFFFF">0,278 μs</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td><td align="right" bgcolor="#FFFFFF">0,287 μs</td><td align="right" bgcolor="#FFFFFF">0,240 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -121,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">121,000 (Δ = +121,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,118)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,118 (Δ = +0,118)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 55,184 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">236,730 ns</td><td align="right" bgcolor="#FFFFFF">246,169 ns</td><td align="right" bgcolor="#FFFFFF">280,117 ns</td><td align="right" bgcolor="#FFFFFF">278,940 ns</td><td align="right" bgcolor="#FFFFFF">291,914 ns</td><td align="right" bgcolor="#FFFFFF">240,248 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td><td align="right" bgcolor="#FFFFFF">0,246 μs</td><td align="right" bgcolor="#FFFFFF">0,280 μs</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td><td align="right" bgcolor="#FFFFFF">0,240 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#FFFFFF">121,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -121,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">121,000 (Δ = +121,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#FFFFFF">0,118</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,118)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,118 (Δ = +0,118)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 69,227 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">266,348 ns</td><td align="right" bgcolor="#FFFFFF">254,316 ns</td><td align="right" bgcolor="#FFFFFF">312,524 ns</td><td align="right" bgcolor="#FFFFFF">321,242 ns</td><td align="right" bgcolor="#FFFFFF">323,544 ns</td><td align="right" bgcolor="#FFFFFF">259,632 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td><td align="right" bgcolor="#FFFFFF">0,254 μs</td><td align="right" bgcolor="#FFFFFF">0,313 μs</td><td align="right" bgcolor="#FFFFFF">0,321 μs</td><td align="right" bgcolor="#FFFFFF">0,324 μs</td><td align="right" bgcolor="#FFFFFF">0,260 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">218,000</td><td align="right" bgcolor="#FFFFFF">218,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -218,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">218,000 (Δ = +218,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,213</td><td align="right" bgcolor="#FFFFFF">0,213</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,213)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,213 (Δ = +0,213)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 875,415 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+66,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">839,482 ns</td><td align="right" bgcolor="#FFFFFF">822,825 ns</td><td align="right" bgcolor="#FF4949">1369,177 ns (Δ = +546,352 ns)</td><td align="right" bgcolor="#FFFFFF">1455,878 ns</td><td align="right" bgcolor="#FFFFFF">1691,158 ns</td><td align="right" bgcolor="#A8D08D">815,743 ns (Δ = -875,415 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,839 μs</td><td align="right" bgcolor="#FFFFFF">0,823 μs</td><td align="right" bgcolor="#FFFFFF">1,369 μs</td><td align="right" bgcolor="#FFFFFF">1,456 μs</td><td align="right" bgcolor="#FFFFFF">1,691 μs</td><td align="right" bgcolor="#FFFFFF">0,816 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">185,000</td><td align="right" bgcolor="#FFFFFF">185,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -185,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">185,000 (Δ = +185,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,181</td><td align="right" bgcolor="#FFFFFF">0,181</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,181)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,181 (Δ = +0,181)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 44,709 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">113,155 ns</td><td align="right" bgcolor="#FFFFFF">110,705 ns</td><td align="right" bgcolor="#FFFFFF">153,875 ns</td><td align="right" bgcolor="#FFFFFF">153,846 ns</td><td align="right" bgcolor="#FFFFFF">155,414 ns</td><td align="right" bgcolor="#FFFFFF">118,169 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">25,000 (Δ = +25,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,024 (Δ = +0,024)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_GetName_Long"></a>GetName_Long

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 54,418 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">171,434 ns</td><td align="right" bgcolor="#FFFFFF">122,326 ns</td><td align="right" bgcolor="#FFFFFF">171,442 ns</td><td align="right" bgcolor="#FFFFFF">171,922 ns</td><td align="right" bgcolor="#FFFFFF">176,744 ns</td><td align="right" bgcolor="#FFFFFF">130,763 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,171 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,171 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">25,000 (Δ = +25,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,024 (Δ = +0,024)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_GetNames"></a>GetNames

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 1244,179 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+79,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-41,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1708,913 ns</td><td align="right" bgcolor="#FFFFFF">1572,311 ns</td><td align="right" bgcolor="#FF4949">2816,490 ns (Δ = +1244,179 ns)</td><td align="right" bgcolor="#FFFFFF">2651,763 ns</td><td align="right" bgcolor="#FFFFFF">2783,400 ns</td><td align="right" bgcolor="#A8D08D">1633,330 ns (Δ = -1150,070 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,709 μs</td><td align="right" bgcolor="#FFFFFF">1,572 μs</td><td align="right" bgcolor="#FFFFFF">2,816 μs</td><td align="right" bgcolor="#FFFFFF">2,652 μs</td><td align="right" bgcolor="#FFFFFF">2,783 μs</td><td align="right" bgcolor="#FFFFFF">1,633 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">916,000</td><td align="right" bgcolor="#FFFFFF">916,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -916,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">916,000 (Δ = +916,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,895</td><td align="right" bgcolor="#FFFFFF">0,895</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,895)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,895 (Δ = +0,895)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Enum_Benchmark_GetValues"></a>GetValues

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 2718,392 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,5 %</td><td align="right" bgcolor="#FF4949">+83,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3438,745 ns</td><td align="right" bgcolor="#A8D08D">2974,020 ns (Δ = -464,725 ns)</td><td align="right" bgcolor="#FF4949">5460,128 ns (Δ = +2486,108 ns)</td><td align="right" bgcolor="#FFFFFF">5530,694 ns</td><td align="right" bgcolor="#FFFFFF">5681,859 ns</td><td align="right" bgcolor="#A8D08D">2963,467 ns (Δ = -2718,392 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,439 μs</td><td align="right" bgcolor="#FFFFFF">2,974 μs</td><td align="right" bgcolor="#FFFFFF">5,460 μs</td><td align="right" bgcolor="#FFFFFF">5,531 μs</td><td align="right" bgcolor="#FFFFFF">5,682 μs</td><td align="right" bgcolor="#FFFFFF">2,963 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1108,000</td><td align="right" bgcolor="#FFFFFF">1108,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1108,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1108,000 (Δ = +1108,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,082</td><td align="right" bgcolor="#FFFFFF">1,082</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,082)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,082 (Δ = +1,082)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 108,616 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">286,666 ns</td><td align="right" bgcolor="#FFFFFF">266,572 ns</td><td align="right" bgcolor="#FFFFFF">366,173 ns</td><td align="right" bgcolor="#FFFFFF">364,933 ns</td><td align="right" bgcolor="#FFFFFF">372,446 ns</td><td align="right" bgcolor="#FFFFFF">263,830 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,287 μs</td><td align="right" bgcolor="#FFFFFF">0,267 μs</td><td align="right" bgcolor="#FFFFFF">0,366 μs</td><td align="right" bgcolor="#FFFFFF">0,365 μs</td><td align="right" bgcolor="#FFFFFF">0,372 μs</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -113,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">113,000 (Δ = +113,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,110)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,110 (Δ = +0,110)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_ToList"></a>ToList

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 2655,043 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+85,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3236,366 ns</td><td align="right" bgcolor="#FFFFFF">3019,195 ns</td><td align="right" bgcolor="#FF4949">5597,946 ns (Δ = +2578,752 ns)</td><td align="right" bgcolor="#FFFFFF">5504,366 ns</td><td align="right" bgcolor="#FFFFFF">5674,238 ns</td><td align="right" bgcolor="#A8D08D">3067,991 ns (Δ = -2606,246 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,236 μs</td><td align="right" bgcolor="#FFFFFF">3,019 μs</td><td align="right" bgcolor="#FFFFFF">5,598 μs</td><td align="right" bgcolor="#FFFFFF">5,504 μs</td><td align="right" bgcolor="#FFFFFF">5,674 μs</td><td align="right" bgcolor="#FFFFFF">3,068 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1198,000</td><td align="right" bgcolor="#FFFFFF">1198,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1198,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1198,000 (Δ = +1198,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,170</td><td align="right" bgcolor="#FFFFFF">1,170</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,170)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,170 (Δ = +1,170)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Enum_Benchmark_TryParse"></a>TryParse

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 120,760 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">272,074 ns</td><td align="right" bgcolor="#FFFFFF">277,249 ns</td><td align="right" bgcolor="#FFFFFF">390,161 ns</td><td align="right" bgcolor="#FFFFFF">383,449 ns</td><td align="right" bgcolor="#FFFFFF">392,834 ns</td><td align="right" bgcolor="#FFFFFF">278,974 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td><td align="right" bgcolor="#FFFFFF">0,277 μs</td><td align="right" bgcolor="#FFFFFF">0,390 μs</td><td align="right" bgcolor="#FFFFFF">0,383 μs</td><td align="right" bgcolor="#FFFFFF">0,393 μs</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -113,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">113,000 (Δ = +113,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,110)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,110 (Δ = +0,110)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase"></a>TryParse_IgnoreCase

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 122,071 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">280,884 ns</td><td align="right" bgcolor="#FFFFFF">270,967 ns</td><td align="right" bgcolor="#FFFFFF">386,624 ns</td><td align="right" bgcolor="#FFFFFF">382,583 ns</td><td align="right" bgcolor="#FFFFFF">393,037 ns</td><td align="right" bgcolor="#FFFFFF">283,611 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,281 μs</td><td align="right" bgcolor="#FFFFFF">0,271 μs</td><td align="right" bgcolor="#FFFFFF">0,387 μs</td><td align="right" bgcolor="#FFFFFF">0,383 μs</td><td align="right" bgcolor="#FFFFFF">0,393 μs</td><td align="right" bgcolor="#FFFFFF">0,284 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -113,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">113,000 (Δ = +113,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,110)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,110 (Δ = +0,110)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase_Nullable"></a>TryParse_IgnoreCase_Nullable

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 125,946 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">271,692 ns</td><td align="right" bgcolor="#FFFFFF">281,464 ns</td><td align="right" bgcolor="#FFFFFF">383,807 ns</td><td align="right" bgcolor="#FFFFFF">381,193 ns</td><td align="right" bgcolor="#FFFFFF">397,638 ns</td><td align="right" bgcolor="#FFFFFF">278,782 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td><td align="right" bgcolor="#FFFFFF">0,281 μs</td><td align="right" bgcolor="#FFFFFF">0,384 μs</td><td align="right" bgcolor="#FFFFFF">0,381 μs</td><td align="right" bgcolor="#FFFFFF">0,398 μs</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -113,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">113,000 (Δ = +113,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,110)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,110 (Δ = +0,110)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 125,131 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">277,579 ns</td><td align="right" bgcolor="#FFFFFF">270,119 ns</td><td align="right" bgcolor="#FFFFFF">380,433 ns</td><td align="right" bgcolor="#FFFFFF">380,307 ns</td><td align="right" bgcolor="#FFFFFF">395,250 ns</td><td align="right" bgcolor="#FFFFFF">280,187 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,278 μs</td><td align="right" bgcolor="#FFFFFF">0,270 μs</td><td align="right" bgcolor="#FFFFFF">0,380 μs</td><td align="right" bgcolor="#FFFFFF">0,380 μs</td><td align="right" bgcolor="#FFFFFF">0,395 μs</td><td align="right" bgcolor="#FFFFFF">0,280 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#FFFFFF">113,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -113,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">113,000 (Δ = +113,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#FFFFFF">0,110</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,110)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,110 (Δ = +0,110)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="ExpressionHelper_Benchmark"></a>ExpressionHelper_Benchmark

### <a name="ExpressionHelper_Benchmark_GetOwner"></a>GetOwner

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 3037,963 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+42,2 %</td><td align="right" bgcolor="#FF4949">+184,0 %</td><td align="right" bgcolor="#A8D08D">-6,7 %</td><td align="right" bgcolor="#FF4949">+8,0 %</td><td align="right" bgcolor="#A8D08D">-68,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">990,071 ns</td><td align="right" bgcolor="#FF4949">1407,480 ns (Δ = +417,409 ns)</td><td align="right" bgcolor="#FF4949">3997,721 ns (Δ = +2590,241 ns)</td><td align="right" bgcolor="#A8D08D">3731,325 ns (Δ = -266,396 ns)</td><td align="right" bgcolor="#FF4949">4028,035 ns (Δ = +296,710 ns)</td><td align="right" bgcolor="#A8D08D">1251,193 ns (Δ = -2776,842 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,990 μs</td><td align="right" bgcolor="#FFFFFF">1,407 μs</td><td align="right" bgcolor="#FFFFFF">3,998 μs</td><td align="right" bgcolor="#FFFFFF">3,731 μs</td><td align="right" bgcolor="#FFFFFF">4,028 μs</td><td align="right" bgcolor="#FFFFFF">1,251 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">650,000</td><td align="right" bgcolor="#FFFFFF">650,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -650,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">650,000 (Δ = +650,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,635</td><td align="right" bgcolor="#FFFFFF">0,635</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,635)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,635 (Δ = +0,635)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="ExpressionHelper_Benchmark_GetPropertyName"></a>GetPropertyName

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 4678,326 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+26,5 %</td><td align="right" bgcolor="#FF4949">+167,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-54,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1903,967 ns</td><td align="right" bgcolor="#FF4949">2408,806 ns (Δ = +504,838 ns)</td><td align="right" bgcolor="#FF4949">6452,193 ns (Δ = +4043,388 ns)</td><td align="right" bgcolor="#FFFFFF">6552,434 ns</td><td align="right" bgcolor="#FFFFFF">6582,294 ns</td><td align="right" bgcolor="#A8D08D">2986,240 ns (Δ = -3596,054 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,904 μs</td><td align="right" bgcolor="#FFFFFF">2,409 μs</td><td align="right" bgcolor="#FFFFFF">6,452 μs</td><td align="right" bgcolor="#FFFFFF">6,552 μs</td><td align="right" bgcolor="#FFFFFF">6,582 μs</td><td align="right" bgcolor="#FFFFFF">2,986 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FF4949">6,000 (Δ = +2,000)</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#A8D08D">4,000 (Δ = -2,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1991,000</td><td align="right" bgcolor="#FFFFFF">1991,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1991,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1991,000 (Δ = +1991,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,944</td><td align="right" bgcolor="#FFFFFF">1,944</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,944)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,944 (Δ = +1,944)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,002)</td></tr></table>


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 71,208 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">97,120 ns</td><td align="right" bgcolor="#FFFFFF">69,545 ns</td><td align="right" bgcolor="#FFFFFF">132,377 ns</td><td align="right" bgcolor="#FFFFFF">140,753 ns</td><td align="right" bgcolor="#FFFFFF">139,274 ns</td><td align="right" bgcolor="#FFFFFF">81,727 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 34,356 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">80,876 ns</td><td align="right" bgcolor="#FFFFFF">78,106 ns</td><td align="right" bgcolor="#FFFFFF">111,928 ns</td><td align="right" bgcolor="#FFFFFF">112,153 ns</td><td align="right" bgcolor="#FFFFFF">112,462 ns</td><td align="right" bgcolor="#FFFFFF">85,051 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="HashHelper_Benchmark"></a>HashHelper_Benchmark

### <a name="HashHelper_Benchmark_HashHelper"></a>HashHelper

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 19,605 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,767 ns</td><td align="right" bgcolor="#FFFFFF">15,790 ns</td><td align="right" bgcolor="#FFFFFF">32,372 ns</td><td align="right" bgcolor="#FFFFFF">31,195 ns</td><td align="right" bgcolor="#FFFFFF">31,707 ns</td><td align="right" bgcolor="#FFFFFF">17,234 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -66,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">66,000 (Δ = +66,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,064)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,064 (Δ = +0,064)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="LanguageHelper_Benchmark"></a>LanguageHelper_Benchmark

### <a name="LanguageHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 2402,917 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+415,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">316,788 ns</td><td align="right" bgcolor="#FFFFFF">424,301 ns</td><td align="right" bgcolor="#FFFFFF">548,689 ns</td><td align="right" bgcolor="#FFFFFF">570,833 ns</td><td align="right" bgcolor="#FFFFFF">527,353 ns</td><td align="right" bgcolor="#FF4949">2719,705 ns (Δ = +2192,352 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,317 μs</td><td align="right" bgcolor="#FFFFFF">0,424 μs</td><td align="right" bgcolor="#FFFFFF">0,549 μs</td><td align="right" bgcolor="#FFFFFF">0,571 μs</td><td align="right" bgcolor="#FFFFFF">0,527 μs</td><td align="right" bgcolor="#FFFFFF">2,720 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +4,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">257,000</td><td align="right" bgcolor="#FFFFFF">257,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -257,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1814,000 (Δ = +1814,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,251</td><td align="right" bgcolor="#FFFFFF">0,251</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,251)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,771 (Δ = +1,771)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,002)</td></tr></table>


## <a name="Log_Debug_Benchmark"></a>Log_Debug_Benchmark

### <a name="Log_Debug_Benchmark_Log_Debug_Format_1_Format_Argument"></a>Log_Debug_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 416,310 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+59,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-37,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">545,046 ns</td><td align="right" bgcolor="#FFFFFF">572,458 ns</td><td align="right" bgcolor="#FF4949">911,134 ns (Δ = +338,676 ns)</td><td align="right" bgcolor="#FFFFFF">961,356 ns</td><td align="right" bgcolor="#FFFFFF">949,874 ns</td><td align="right" bgcolor="#A8D08D">589,453 ns (Δ = -360,421 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,545 μs</td><td align="right" bgcolor="#FFFFFF">0,572 μs</td><td align="right" bgcolor="#FFFFFF">0,911 μs</td><td align="right" bgcolor="#FFFFFF">0,961 μs</td><td align="right" bgcolor="#FFFFFF">0,950 μs</td><td align="right" bgcolor="#FFFFFF">0,589 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -338,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">338,000 (Δ = +338,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,330)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,330 (Δ = +0,330)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_2_Format_Arguments"></a>Log_Debug_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 466,865 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+59,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">622,282 ns</td><td align="right" bgcolor="#FFFFFF">642,406 ns</td><td align="right" bgcolor="#FF4949">1024,990 ns (Δ = +382,584 ns)</td><td align="right" bgcolor="#FFFFFF">1089,148 ns</td><td align="right" bgcolor="#FFFFFF">1081,083 ns</td><td align="right" bgcolor="#A8D08D">690,105 ns (Δ = -390,978 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,622 μs</td><td align="right" bgcolor="#FFFFFF">0,642 μs</td><td align="right" bgcolor="#FFFFFF">1,025 μs</td><td align="right" bgcolor="#FFFFFF">1,089 μs</td><td align="right" bgcolor="#FFFFFF">1,081 μs</td><td align="right" bgcolor="#FFFFFF">0,690 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">378,000</td><td align="right" bgcolor="#FFFFFF">378,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -378,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">378,000 (Δ = +378,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,369</td><td align="right" bgcolor="#FFFFFF">0,369</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,369)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,369 (Δ = +0,369)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments"></a>Log_Debug_Format_3_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 494,060 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+50,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">874,667 ns</td><td align="right" bgcolor="#FFFFFF">810,050 ns</td><td align="right" bgcolor="#FF4949">1222,422 ns (Δ = +412,372 ns)</td><td align="right" bgcolor="#FFFFFF">1244,524 ns</td><td align="right" bgcolor="#FFFFFF">1304,110 ns</td><td align="right" bgcolor="#A8D08D">866,207 ns (Δ = -437,904 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,875 μs</td><td align="right" bgcolor="#FFFFFF">0,810 μs</td><td align="right" bgcolor="#FFFFFF">1,222 μs</td><td align="right" bgcolor="#FFFFFF">1,245 μs</td><td align="right" bgcolor="#FFFFFF">1,304 μs</td><td align="right" bgcolor="#FFFFFF">0,866 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -451,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">451,000 (Δ = +451,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,440)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,440 (Δ = +0,440)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_4_Format_Arguments"></a>Log_Debug_Format_4_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 533,406 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+51,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1047,884 ns</td><td align="right" bgcolor="#FFFFFF">1003,302 ns</td><td align="right" bgcolor="#FF4949">1521,156 ns (Δ = +517,853 ns)</td><td align="right" bgcolor="#FFFFFF">1505,220 ns</td><td align="right" bgcolor="#FFFFFF">1536,708 ns</td><td align="right" bgcolor="#A8D08D">1016,765 ns (Δ = -519,944 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,048 μs</td><td align="right" bgcolor="#FFFFFF">1,003 μs</td><td align="right" bgcolor="#FFFFFF">1,521 μs</td><td align="right" bgcolor="#FFFFFF">1,505 μs</td><td align="right" bgcolor="#FFFFFF">1,537 μs</td><td align="right" bgcolor="#FFFFFF">1,017 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">578,000</td><td align="right" bgcolor="#FFFFFF">578,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -578,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">578,000 (Δ = +578,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,564</td><td align="right" bgcolor="#FFFFFF">0,564</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,564)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,564 (Δ = +0,564)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_5_Format_Arguments"></a>Log_Debug_Format_5_Format_Arguments

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 700,492 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+59,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-39,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1126,544 ns</td><td align="right" bgcolor="#FFFFFF">1073,173 ns</td><td align="right" bgcolor="#FF4949">1706,763 ns (Δ = +633,590 ns)</td><td align="right" bgcolor="#FFFFFF">1755,626 ns</td><td align="right" bgcolor="#FFFFFF">1741,600 ns</td><td align="right" bgcolor="#A8D08D">1055,134 ns (Δ = -686,466 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,127 μs</td><td align="right" bgcolor="#FFFFFF">1,073 μs</td><td align="right" bgcolor="#FFFFFF">1,707 μs</td><td align="right" bgcolor="#FFFFFF">1,756 μs</td><td align="right" bgcolor="#FFFFFF">1,742 μs</td><td align="right" bgcolor="#FFFFFF">1,055 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -659,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">659,000 (Δ = +659,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,644)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,644 (Δ = +0,644)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments"></a>Log_Debug_Format_6_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 760,429 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+51,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-34,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1335,309 ns</td><td align="right" bgcolor="#FFFFFF">1319,618 ns</td><td align="right" bgcolor="#FF4949">1992,016 ns (Δ = +672,398 ns)</td><td align="right" bgcolor="#FFFFFF">2073,386 ns</td><td align="right" bgcolor="#FFFFFF">2080,047 ns</td><td align="right" bgcolor="#A8D08D">1356,787 ns (Δ = -723,261 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,335 μs</td><td align="right" bgcolor="#FFFFFF">1,320 μs</td><td align="right" bgcolor="#FFFFFF">1,992 μs</td><td align="right" bgcolor="#FFFFFF">2,073 μs</td><td align="right" bgcolor="#FFFFFF">2,080 μs</td><td align="right" bgcolor="#FFFFFF">1,357 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -836,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +836,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,816)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,816)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_7_Format_Arguments"></a>Log_Debug_Format_7_Format_Arguments

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 859,536 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+54,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-37,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1441,162 ns</td><td align="right" bgcolor="#FFFFFF">1432,036 ns</td><td align="right" bgcolor="#FF4949">2218,008 ns (Δ = +785,972 ns)</td><td align="right" bgcolor="#FFFFFF">2233,865 ns</td><td align="right" bgcolor="#FFFFFF">2210,845 ns</td><td align="right" bgcolor="#A8D08D">1374,329 ns (Δ = -836,516 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,441 μs</td><td align="right" bgcolor="#FFFFFF">1,432 μs</td><td align="right" bgcolor="#FFFFFF">2,218 μs</td><td align="right" bgcolor="#FFFFFF">2,234 μs</td><td align="right" bgcolor="#FFFFFF">2,211 μs</td><td align="right" bgcolor="#FFFFFF">1,374 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -924,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">924,000 (Δ = +924,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,902)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,902 (Δ = +0,902)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 4,246 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,754 ns</td><td align="right" bgcolor="#FFFFFF">0,814 ns</td><td align="right" bgcolor="#FFFFFF">2,063 ns</td><td align="right" bgcolor="#FFFFFF">2,065 ns</td><td align="right" bgcolor="#FFFFFF">2,009 ns</td><td align="right" bgcolor="#FFFFFF">0,508 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 12,249 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,150 ns</td><td align="right" bgcolor="#FFFFFF">12,994 ns</td><td align="right" bgcolor="#FFFFFF">24,067 ns</td><td align="right" bgcolor="#FFFFFF">25,243 ns</td><td align="right" bgcolor="#FFFFFF">23,446 ns</td><td align="right" bgcolor="#FFFFFF">13,277 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -57,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">57,000 (Δ = +57,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,056)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,056 (Δ = +0,056)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 9,066 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,379 ns</td><td align="right" bgcolor="#FFFFFF">9,671 ns</td><td align="right" bgcolor="#FFFFFF">17,734 ns</td><td align="right" bgcolor="#FFFFFF">18,676 ns</td><td align="right" bgcolor="#FFFFFF">18,036 ns</td><td align="right" bgcolor="#FFFFFF">9,610 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -33,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +33,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 139,064 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">367,791 ns</td><td align="right" bgcolor="#FFFFFF">274,109 ns</td><td align="right" bgcolor="#FFFFFF">372,915 ns</td><td align="right" bgcolor="#FFFFFF">403,242 ns</td><td align="right" bgcolor="#FFFFFF">392,322 ns</td><td align="right" bgcolor="#FFFFFF">264,178 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,368 μs</td><td align="right" bgcolor="#FFFFFF">0,274 μs</td><td align="right" bgcolor="#FFFFFF">0,373 μs</td><td align="right" bgcolor="#FFFFFF">0,403 μs</td><td align="right" bgcolor="#FFFFFF">0,392 μs</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -161,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">161,000 (Δ = +161,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,157)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,157 (Δ = +0,157)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 389,889 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+65,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-38,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">708,997 ns</td><td align="right" bgcolor="#FFFFFF">554,115 ns</td><td align="right" bgcolor="#FF4949">918,379 ns (Δ = +364,264 ns)</td><td align="right" bgcolor="#FFFFFF">891,415 ns</td><td align="right" bgcolor="#FFFFFF">944,004 ns</td><td align="right" bgcolor="#A8D08D">585,428 ns (Δ = -358,576 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,709 μs</td><td align="right" bgcolor="#FFFFFF">0,554 μs</td><td align="right" bgcolor="#FFFFFF">0,918 μs</td><td align="right" bgcolor="#FFFFFF">0,891 μs</td><td align="right" bgcolor="#FFFFFF">0,944 μs</td><td align="right" bgcolor="#FFFFFF">0,585 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">354,000</td><td align="right" bgcolor="#FFFFFF">354,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -354,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">354,000 (Δ = +354,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,346</td><td align="right" bgcolor="#FFFFFF">0,346</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,346)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,346 (Δ = +0,346)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 335,472 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+59,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-39,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">466,513 ns</td><td align="right" bgcolor="#FFFFFF">486,117 ns</td><td align="right" bgcolor="#FF4949">776,230 ns (Δ = +290,113 ns)</td><td align="right" bgcolor="#FFFFFF">775,773 ns</td><td align="right" bgcolor="#FFFFFF">801,985 ns</td><td align="right" bgcolor="#A8D08D">489,098 ns (Δ = -312,887 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,467 μs</td><td align="right" bgcolor="#FFFFFF">0,486 μs</td><td align="right" bgcolor="#FFFFFF">0,776 μs</td><td align="right" bgcolor="#FFFFFF">0,776 μs</td><td align="right" bgcolor="#FFFFFF">0,802 μs</td><td align="right" bgcolor="#FFFFFF">0,489 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">346,000</td><td align="right" bgcolor="#FFFFFF">346,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -346,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">346,000 (Δ = +346,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,338</td><td align="right" bgcolor="#FFFFFF">0,338</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,338)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,338 (Δ = +0,338)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="Log_Error_Benchmark"></a>Log_Error_Benchmark

### <a name="Log_Error_Benchmark_Log_Error_Format_1_Format_Argument"></a>Log_Error_Format_1_Format_Argument

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 448,452 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+54,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">550,791 ns</td><td align="right" bgcolor="#FFFFFF">525,782 ns</td><td align="right" bgcolor="#FF4949">811,957 ns (Δ = +286,175 ns)</td><td align="right" bgcolor="#FFFFFF">854,156 ns</td><td align="right" bgcolor="#FFFFFF">974,234 ns</td><td align="right" bgcolor="#A8D08D">580,084 ns (Δ = -394,150 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,551 μs</td><td align="right" bgcolor="#FFFFFF">0,526 μs</td><td align="right" bgcolor="#FFFFFF">0,812 μs</td><td align="right" bgcolor="#FFFFFF">0,854 μs</td><td align="right" bgcolor="#FFFFFF">0,974 μs</td><td align="right" bgcolor="#FFFFFF">0,580 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">306,000</td><td align="right" bgcolor="#FFFFFF">306,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -306,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">305,000 (Δ = +305,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,299</td><td align="right" bgcolor="#FFFFFF">0,299</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,299)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,298 (Δ = +0,298)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_2_Format_Arguments"></a>Log_Error_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 440,385 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+53,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-35,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">631,969 ns</td><td align="right" bgcolor="#FFFFFF">671,057 ns</td><td align="right" bgcolor="#FF4949">1031,687 ns (Δ = +360,630 ns)</td><td align="right" bgcolor="#FFFFFF">1072,354 ns</td><td align="right" bgcolor="#FFFFFF">1066,305 ns</td><td align="right" bgcolor="#A8D08D">691,612 ns (Δ = -374,692 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,632 μs</td><td align="right" bgcolor="#FFFFFF">0,671 μs</td><td align="right" bgcolor="#FFFFFF">1,032 μs</td><td align="right" bgcolor="#FFFFFF">1,072 μs</td><td align="right" bgcolor="#FFFFFF">1,066 μs</td><td align="right" bgcolor="#FFFFFF">0,692 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">378,000</td><td align="right" bgcolor="#FFFFFF">378,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -378,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">378,000 (Δ = +378,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,369</td><td align="right" bgcolor="#FFFFFF">0,369</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,369)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,369 (Δ = +0,369)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_3_Format_Arguments"></a>Log_Error_Format_3_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 511,805 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+59,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-34,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">804,052 ns</td><td align="right" bgcolor="#FFFFFF">775,266 ns</td><td align="right" bgcolor="#FF4949">1233,005 ns (Δ = +457,739 ns)</td><td align="right" bgcolor="#FFFFFF">1229,548 ns</td><td align="right" bgcolor="#FFFFFF">1287,072 ns</td><td align="right" bgcolor="#A8D08D">843,759 ns (Δ = -443,313 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,804 μs</td><td align="right" bgcolor="#FFFFFF">0,775 μs</td><td align="right" bgcolor="#FFFFFF">1,233 μs</td><td align="right" bgcolor="#FFFFFF">1,230 μs</td><td align="right" bgcolor="#FFFFFF">1,287 μs</td><td align="right" bgcolor="#FFFFFF">0,844 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -451,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">451,000 (Δ = +451,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,440)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,440 (Δ = +0,440)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_4_Format_Arguments"></a>Log_Error_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 612,184 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+26,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-38,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">956,594 ns</td><td align="right" bgcolor="#FFFFFF">1173,296 ns</td><td align="right" bgcolor="#FF4949">1479,882 ns (Δ = +306,586 ns)</td><td align="right" bgcolor="#FFFFFF">1527,962 ns</td><td align="right" bgcolor="#FFFFFF">1568,778 ns</td><td align="right" bgcolor="#A8D08D">966,956 ns (Δ = -601,822 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,957 μs</td><td align="right" bgcolor="#FFFFFF">1,173 μs</td><td align="right" bgcolor="#FFFFFF">1,480 μs</td><td align="right" bgcolor="#FFFFFF">1,528 μs</td><td align="right" bgcolor="#FFFFFF">1,569 μs</td><td align="right" bgcolor="#FFFFFF">0,967 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">578,000</td><td align="right" bgcolor="#FFFFFF">578,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -578,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">578,000 (Δ = +578,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,564</td><td align="right" bgcolor="#FFFFFF">0,564</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,564)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,564 (Δ = +0,564)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_5_Format_Arguments"></a>Log_Error_Format_5_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 610,350 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+51,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1218,878 ns</td><td align="right" bgcolor="#FFFFFF">1120,612 ns</td><td align="right" bgcolor="#FF4949">1698,451 ns (Δ = +577,839 ns)</td><td align="right" bgcolor="#FFFFFF">1702,199 ns</td><td align="right" bgcolor="#FFFFFF">1730,962 ns</td><td align="right" bgcolor="#A8D08D">1157,584 ns (Δ = -573,377 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,219 μs</td><td align="right" bgcolor="#FFFFFF">1,121 μs</td><td align="right" bgcolor="#FFFFFF">1,698 μs</td><td align="right" bgcolor="#FFFFFF">1,702 μs</td><td align="right" bgcolor="#FFFFFF">1,731 μs</td><td align="right" bgcolor="#FFFFFF">1,158 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -659,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">659,000 (Δ = +659,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,644)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,644 (Δ = +0,644)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_6_Format_Arguments"></a>Log_Error_Format_6_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 763,774 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+57,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-35,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1304,970 ns</td><td align="right" bgcolor="#FFFFFF">1294,741 ns</td><td align="right" bgcolor="#FF4949">2042,906 ns (Δ = +748,164 ns)</td><td align="right" bgcolor="#FFFFFF">2021,510 ns</td><td align="right" bgcolor="#FFFFFF">2058,515 ns</td><td align="right" bgcolor="#A8D08D">1332,671 ns (Δ = -725,845 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,305 μs</td><td align="right" bgcolor="#FFFFFF">1,295 μs</td><td align="right" bgcolor="#FFFFFF">2,043 μs</td><td align="right" bgcolor="#FFFFFF">2,022 μs</td><td align="right" bgcolor="#FFFFFF">2,059 μs</td><td align="right" bgcolor="#FFFFFF">1,333 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -836,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +836,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,816)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,816)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_7_Format_Arguments"></a>Log_Error_Format_7_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 825,369 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+52,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-34,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1527,646 ns</td><td align="right" bgcolor="#FFFFFF">1433,515 ns</td><td align="right" bgcolor="#FF4949">2180,450 ns (Δ = +746,935 ns)</td><td align="right" bgcolor="#FFFFFF">2236,599 ns</td><td align="right" bgcolor="#FFFFFF">2258,884 ns</td><td align="right" bgcolor="#A8D08D">1471,981 ns (Δ = -786,903 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,528 μs</td><td align="right" bgcolor="#FFFFFF">1,434 μs</td><td align="right" bgcolor="#FFFFFF">2,180 μs</td><td align="right" bgcolor="#FFFFFF">2,237 μs</td><td align="right" bgcolor="#FFFFFF">2,259 μs</td><td align="right" bgcolor="#FFFFFF">1,472 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -924,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">924,000 (Δ = +924,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,902)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,902 (Δ = +0,902)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="Log_Info_Benchmark"></a>Log_Info_Benchmark

### <a name="Log_Info_Benchmark_Log_Info_Format_1_Format_Argument"></a>Log_Info_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 384,256 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+55,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-39,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">547,497 ns</td><td align="right" bgcolor="#FFFFFF">565,947 ns</td><td align="right" bgcolor="#FF4949">881,092 ns (Δ = +315,145 ns)</td><td align="right" bgcolor="#FFFFFF">931,753 ns</td><td align="right" bgcolor="#FFFFFF">920,954 ns</td><td align="right" bgcolor="#A8D08D">561,268 ns (Δ = -359,686 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,547 μs</td><td align="right" bgcolor="#FFFFFF">0,566 μs</td><td align="right" bgcolor="#FFFFFF">0,881 μs</td><td align="right" bgcolor="#FFFFFF">0,932 μs</td><td align="right" bgcolor="#FFFFFF">0,921 μs</td><td align="right" bgcolor="#FFFFFF">0,561 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#FFFFFF">338,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -338,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">338,000 (Δ = +338,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#FFFFFF">0,330</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,330)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,330 (Δ = +0,330)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_2_Format_Arguments"></a>Log_Info_Format_2_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 547,968 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,4 %</td><td align="right" bgcolor="#FF4949">+67,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-39,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">956,793 ns</td><td align="right" bgcolor="#A8D08D">655,977 ns (Δ = -300,816 ns)</td><td align="right" bgcolor="#FF4949">1100,907 ns (Δ = +444,931 ns)</td><td align="right" bgcolor="#FFFFFF">1172,631 ns</td><td align="right" bgcolor="#FFFFFF">1203,945 ns</td><td align="right" bgcolor="#A8D08D">726,298 ns (Δ = -477,647 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,957 μs</td><td align="right" bgcolor="#FFFFFF">0,656 μs</td><td align="right" bgcolor="#FFFFFF">1,101 μs</td><td align="right" bgcolor="#FFFFFF">1,173 μs</td><td align="right" bgcolor="#FFFFFF">1,204 μs</td><td align="right" bgcolor="#FFFFFF">0,726 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -418,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">418,000 (Δ = +418,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,408)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,408 (Δ = +0,408)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_3_Format_Arguments"></a>Log_Info_Format_3_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 552,697 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+60,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-35,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">836,385 ns</td><td align="right" bgcolor="#FFFFFF">807,984 ns</td><td align="right" bgcolor="#FF4949">1297,273 ns (Δ = +489,288 ns)</td><td align="right" bgcolor="#FFFFFF">1328,055 ns</td><td align="right" bgcolor="#FFFFFF">1360,682 ns</td><td align="right" bgcolor="#A8D08D">871,846 ns (Δ = -488,836 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,836 μs</td><td align="right" bgcolor="#FFFFFF">0,808 μs</td><td align="right" bgcolor="#FFFFFF">1,297 μs</td><td align="right" bgcolor="#FFFFFF">1,328 μs</td><td align="right" bgcolor="#FFFFFF">1,361 μs</td><td align="right" bgcolor="#FFFFFF">0,872 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">498,000</td><td align="right" bgcolor="#FFFFFF">498,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -498,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">498,000 (Δ = +498,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,486</td><td align="right" bgcolor="#FFFFFF">0,486</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,486)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,486 (Δ = +0,486)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_4_Format_Arguments"></a>Log_Info_Format_4_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 696,255 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,4 %</td><td align="right" bgcolor="#FF4949">+57,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1413,673 ns</td><td align="right" bgcolor="#A8D08D">969,806 ns (Δ = -443,867 ns)</td><td align="right" bgcolor="#FF4949">1526,594 ns (Δ = +556,788 ns)</td><td align="right" bgcolor="#FFFFFF">1607,884 ns</td><td align="right" bgcolor="#FFFFFF">1666,061 ns</td><td align="right" bgcolor="#A8D08D">988,041 ns (Δ = -678,021 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,414 μs</td><td align="right" bgcolor="#FFFFFF">0,970 μs</td><td align="right" bgcolor="#FFFFFF">1,527 μs</td><td align="right" bgcolor="#FFFFFF">1,608 μs</td><td align="right" bgcolor="#FFFFFF">1,666 μs</td><td align="right" bgcolor="#FFFFFF">0,988 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">578,000</td><td align="right" bgcolor="#FFFFFF">578,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -578,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">578,000 (Δ = +578,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,564</td><td align="right" bgcolor="#FFFFFF">0,564</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,564)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,564 (Δ = +0,564)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_5_Format_Arguments"></a>Log_Info_Format_5_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 699,573 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+59,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1120,117 ns</td><td align="right" bgcolor="#FFFFFF">1065,416 ns</td><td align="right" bgcolor="#FF4949">1697,772 ns (Δ = +632,356 ns)</td><td align="right" bgcolor="#FFFFFF">1764,989 ns</td><td align="right" bgcolor="#FFFFFF">1734,437 ns</td><td align="right" bgcolor="#A8D08D">1153,145 ns (Δ = -581,291 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,120 μs</td><td align="right" bgcolor="#FFFFFF">1,065 μs</td><td align="right" bgcolor="#FFFFFF">1,698 μs</td><td align="right" bgcolor="#FFFFFF">1,765 μs</td><td align="right" bgcolor="#FFFFFF">1,734 μs</td><td align="right" bgcolor="#FFFFFF">1,153 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -659,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">659,000 (Δ = +659,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,644)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,644 (Δ = +0,644)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_6_Format_Arguments"></a>Log_Info_Format_6_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 897,447 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+59,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-41,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1207,861 ns</td><td align="right" bgcolor="#FFFFFF">1202,714 ns</td><td align="right" bgcolor="#FF4949">1911,973 ns (Δ = +709,258 ns)</td><td align="right" bgcolor="#FFFFFF">1983,879 ns</td><td align="right" bgcolor="#FFFFFF">2100,161 ns</td><td align="right" bgcolor="#A8D08D">1238,305 ns (Δ = -861,856 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,208 μs</td><td align="right" bgcolor="#FFFFFF">1,203 μs</td><td align="right" bgcolor="#FFFFFF">1,912 μs</td><td align="right" bgcolor="#FFFFFF">1,984 μs</td><td align="right" bgcolor="#FFFFFF">2,100 μs</td><td align="right" bgcolor="#FFFFFF">1,238 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">739,000</td><td align="right" bgcolor="#FFFFFF">739,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -739,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">739,000 (Δ = +739,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,722</td><td align="right" bgcolor="#FFFFFF">0,722</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,722)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,722 (Δ = +0,722)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments"></a>Log_Info_Format_7_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 835,676 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+56,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-35,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1432,507 ns</td><td align="right" bgcolor="#FFFFFF">1319,411 ns</td><td align="right" bgcolor="#FF4949">2063,547 ns (Δ = +744,135 ns)</td><td align="right" bgcolor="#FFFFFF">2110,647 ns</td><td align="right" bgcolor="#FFFFFF">2155,087 ns</td><td align="right" bgcolor="#A8D08D">1390,116 ns (Δ = -764,971 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,433 μs</td><td align="right" bgcolor="#FFFFFF">1,319 μs</td><td align="right" bgcolor="#FFFFFF">2,064 μs</td><td align="right" bgcolor="#FFFFFF">2,111 μs</td><td align="right" bgcolor="#FFFFFF">2,155 μs</td><td align="right" bgcolor="#FFFFFF">1,390 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#FFFFFF">819,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -819,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">819,000 (Δ = +819,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#FFFFFF">0,800</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,800)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,800 (Δ = +0,800)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="Log_Status_Benchmark"></a>Log_Status_Benchmark

### <a name="Log_Status_Benchmark_Log_Status_Format_1_Format_Argument"></a>Log_Status_Format_1_Format_Argument

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 317,768 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+53,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-34,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">539,665 ns</td><td align="right" bgcolor="#FFFFFF">529,558 ns</td><td align="right" bgcolor="#FF4949">812,399 ns (Δ = +282,840 ns)</td><td align="right" bgcolor="#FFFFFF">839,539 ns</td><td align="right" bgcolor="#FFFFFF">847,326 ns</td><td align="right" bgcolor="#A8D08D">553,236 ns (Δ = -294,090 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,540 μs</td><td align="right" bgcolor="#FFFFFF">0,530 μs</td><td align="right" bgcolor="#FFFFFF">0,812 μs</td><td align="right" bgcolor="#FFFFFF">0,840 μs</td><td align="right" bgcolor="#FFFFFF">0,847 μs</td><td align="right" bgcolor="#FFFFFF">0,553 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">306,000</td><td align="right" bgcolor="#FFFFFF">306,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -306,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">305,000 (Δ = +305,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,299</td><td align="right" bgcolor="#FFFFFF">0,299</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,299)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,298 (Δ = +0,298)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_2_Format_Arguments"></a>Log_Status_Format_2_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 468,611 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+59,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-39,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">727,451 ns</td><td align="right" bgcolor="#FFFFFF">649,830 ns</td><td align="right" bgcolor="#FF4949">1034,952 ns (Δ = +385,122 ns)</td><td align="right" bgcolor="#FFFFFF">1065,254 ns</td><td align="right" bgcolor="#FFFFFF">1118,441 ns</td><td align="right" bgcolor="#A8D08D">682,152 ns (Δ = -436,290 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,727 μs</td><td align="right" bgcolor="#FFFFFF">0,650 μs</td><td align="right" bgcolor="#FFFFFF">1,035 μs</td><td align="right" bgcolor="#FFFFFF">1,065 μs</td><td align="right" bgcolor="#FFFFFF">1,118 μs</td><td align="right" bgcolor="#FFFFFF">0,682 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">378,000</td><td align="right" bgcolor="#FFFFFF">378,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -378,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">378,000 (Δ = +378,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,369</td><td align="right" bgcolor="#FFFFFF">0,369</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,369)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,369 (Δ = +0,369)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_3_Format_Arguments"></a>Log_Status_Format_3_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 512,176 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+58,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">804,673 ns</td><td align="right" bgcolor="#FFFFFF">768,576 ns</td><td align="right" bgcolor="#FF4949">1214,187 ns (Δ = +445,611 ns)</td><td align="right" bgcolor="#FFFFFF">1225,016 ns</td><td align="right" bgcolor="#FFFFFF">1280,752 ns</td><td align="right" bgcolor="#A8D08D">849,722 ns (Δ = -431,030 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,805 μs</td><td align="right" bgcolor="#FFFFFF">0,769 μs</td><td align="right" bgcolor="#FFFFFF">1,214 μs</td><td align="right" bgcolor="#FFFFFF">1,225 μs</td><td align="right" bgcolor="#FFFFFF">1,281 μs</td><td align="right" bgcolor="#FFFFFF">0,850 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -451,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">451,000 (Δ = +451,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,440)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,440 (Δ = +0,440)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments"></a>Log_Status_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 695,115 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+57,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-37,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">971,576 ns</td><td align="right" bgcolor="#FFFFFF">982,353 ns</td><td align="right" bgcolor="#FF4949">1544,356 ns (Δ = +562,004 ns)</td><td align="right" bgcolor="#FFFFFF">1531,470 ns</td><td align="right" bgcolor="#FFFFFF">1666,692 ns</td><td align="right" bgcolor="#A8D08D">1050,701 ns (Δ = -615,990 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,972 μs</td><td align="right" bgcolor="#FFFFFF">0,982 μs</td><td align="right" bgcolor="#FFFFFF">1,544 μs</td><td align="right" bgcolor="#FFFFFF">1,531 μs</td><td align="right" bgcolor="#FFFFFF">1,667 μs</td><td align="right" bgcolor="#FFFFFF">1,051 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">578,000</td><td align="right" bgcolor="#FFFFFF">578,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -578,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">578,000 (Δ = +578,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,564</td><td align="right" bgcolor="#FFFFFF">0,564</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,564)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,564 (Δ = +0,564)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_5_Format_Arguments"></a>Log_Status_Format_5_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 740,735 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,0 %</td><td align="right" bgcolor="#FF4949">+54,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-39,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1402,716 ns</td><td align="right" bgcolor="#A8D08D">1094,335 ns (Δ = -308,381 ns)</td><td align="right" bgcolor="#FF4949">1690,297 ns (Δ = +595,962 ns)</td><td align="right" bgcolor="#FFFFFF">1778,944 ns</td><td align="right" bgcolor="#FFFFFF">1835,070 ns</td><td align="right" bgcolor="#A8D08D">1103,880 ns (Δ = -731,190 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,403 μs</td><td align="right" bgcolor="#FFFFFF">1,094 μs</td><td align="right" bgcolor="#FFFFFF">1,690 μs</td><td align="right" bgcolor="#FFFFFF">1,779 μs</td><td align="right" bgcolor="#FFFFFF">1,835 μs</td><td align="right" bgcolor="#FFFFFF">1,104 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -659,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">659,000 (Δ = +659,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,644)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,644 (Δ = +0,644)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_6_Format_Arguments"></a>Log_Status_Format_6_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 853,145 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+58,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-38,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1317,652 ns</td><td align="right" bgcolor="#FFFFFF">1274,485 ns</td><td align="right" bgcolor="#FF4949">2017,911 ns (Δ = +743,427 ns)</td><td align="right" bgcolor="#FFFFFF">2076,065 ns</td><td align="right" bgcolor="#FFFFFF">2127,630 ns</td><td align="right" bgcolor="#A8D08D">1316,591 ns (Δ = -811,039 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,318 μs</td><td align="right" bgcolor="#FFFFFF">1,274 μs</td><td align="right" bgcolor="#FFFFFF">2,018 μs</td><td align="right" bgcolor="#FFFFFF">2,076 μs</td><td align="right" bgcolor="#FFFFFF">2,128 μs</td><td align="right" bgcolor="#FFFFFF">1,317 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -836,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +836,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,816)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,816)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_7_Format_Arguments"></a>Log_Status_Format_7_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 902,993 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,5 %</td><td align="right" bgcolor="#FF4949">+58,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-38,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1695,373 ns</td><td align="right" bgcolor="#A8D08D">1398,138 ns (Δ = -297,235 ns)</td><td align="right" bgcolor="#FF4949">2217,437 ns (Δ = +819,299 ns)</td><td align="right" bgcolor="#FFFFFF">2301,131 ns</td><td align="right" bgcolor="#FFFFFF">2261,300 ns</td><td align="right" bgcolor="#A8D08D">1402,951 ns (Δ = -858,349 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,695 μs</td><td align="right" bgcolor="#FFFFFF">1,398 μs</td><td align="right" bgcolor="#FFFFFF">2,217 μs</td><td align="right" bgcolor="#FFFFFF">2,301 μs</td><td align="right" bgcolor="#FFFFFF">2,261 μs</td><td align="right" bgcolor="#FFFFFF">1,403 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -924,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">924,000 (Δ = +924,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,902)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,902 (Δ = +0,902)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="Log_Warning_Benchmark"></a>Log_Warning_Benchmark

### <a name="Log_Warning_Benchmark_Log_Warning_Format_1_Format_Argument"></a>Log_Warning_Format_1_Format_Argument

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 325,715 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+59,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-37,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">549,288 ns</td><td align="right" bgcolor="#FFFFFF">523,758 ns</td><td align="right" bgcolor="#FF4949">833,486 ns (Δ = +309,728 ns)</td><td align="right" bgcolor="#FFFFFF">823,592 ns</td><td align="right" bgcolor="#FFFFFF">849,473 ns</td><td align="right" bgcolor="#A8D08D">535,204 ns (Δ = -314,269 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,549 μs</td><td align="right" bgcolor="#FFFFFF">0,524 μs</td><td align="right" bgcolor="#FFFFFF">0,833 μs</td><td align="right" bgcolor="#FFFFFF">0,824 μs</td><td align="right" bgcolor="#FFFFFF">0,849 μs</td><td align="right" bgcolor="#FFFFFF">0,535 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">306,000</td><td align="right" bgcolor="#FFFFFF">306,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -306,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">305,000 (Δ = +305,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,299</td><td align="right" bgcolor="#FFFFFF">0,299</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,299)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,298 (Δ = +0,298)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_2_Format_Arguments"></a>Log_Warning_Format_2_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 421,717 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,0 %</td><td align="right" bgcolor="#FF4949">+58,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">908,903 ns</td><td align="right" bgcolor="#A8D08D">654,040 ns (Δ = -254,863 ns)</td><td align="right" bgcolor="#FF4949">1039,267 ns (Δ = +385,227 ns)</td><td align="right" bgcolor="#FFFFFF">1070,717 ns</td><td align="right" bgcolor="#FFFFFF">1075,757 ns</td><td align="right" bgcolor="#A8D08D">688,289 ns (Δ = -387,468 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,909 μs</td><td align="right" bgcolor="#FFFFFF">0,654 μs</td><td align="right" bgcolor="#FFFFFF">1,039 μs</td><td align="right" bgcolor="#FFFFFF">1,071 μs</td><td align="right" bgcolor="#FFFFFF">1,076 μs</td><td align="right" bgcolor="#FFFFFF">0,688 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">378,000</td><td align="right" bgcolor="#FFFFFF">378,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -378,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">378,000 (Δ = +378,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,369</td><td align="right" bgcolor="#FFFFFF">0,369</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,369)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,369 (Δ = +0,369)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_3_Format_Arguments"></a>Log_Warning_Format_3_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 478,252 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+52,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">808,111 ns</td><td align="right" bgcolor="#FFFFFF">805,693 ns</td><td align="right" bgcolor="#FF4949">1226,630 ns (Δ = +420,937 ns)</td><td align="right" bgcolor="#FFFFFF">1229,365 ns</td><td align="right" bgcolor="#FFFFFF">1283,946 ns</td><td align="right" bgcolor="#A8D08D">850,855 ns (Δ = -433,091 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,808 μs</td><td align="right" bgcolor="#FFFFFF">0,806 μs</td><td align="right" bgcolor="#FFFFFF">1,227 μs</td><td align="right" bgcolor="#FFFFFF">1,229 μs</td><td align="right" bgcolor="#FFFFFF">1,284 μs</td><td align="right" bgcolor="#FFFFFF">0,851 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -451,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">451,000 (Δ = +451,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,440)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,440 (Δ = +0,440)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_4_Format_Arguments"></a>Log_Warning_Format_4_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 557,871 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+50,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1002,614 ns</td><td align="right" bgcolor="#FFFFFF">970,921 ns</td><td align="right" bgcolor="#FF4949">1459,762 ns (Δ = +488,841 ns)</td><td align="right" bgcolor="#FFFFFF">1513,194 ns</td><td align="right" bgcolor="#FFFFFF">1528,792 ns</td><td align="right" bgcolor="#A8D08D">1049,404 ns (Δ = -479,388 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,003 μs</td><td align="right" bgcolor="#FFFFFF">0,971 μs</td><td align="right" bgcolor="#FFFFFF">1,460 μs</td><td align="right" bgcolor="#FFFFFF">1,513 μs</td><td align="right" bgcolor="#FFFFFF">1,529 μs</td><td align="right" bgcolor="#FFFFFF">1,049 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">578,000</td><td align="right" bgcolor="#FFFFFF">578,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -578,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">578,000 (Δ = +578,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,564</td><td align="right" bgcolor="#FFFFFF">0,564</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,564)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,564 (Δ = +0,564)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_5_Format_Arguments"></a>Log_Warning_Format_5_Format_Arguments

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 692,072 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+48,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-39,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1230,130 ns</td><td align="right" bgcolor="#FFFFFF">1114,837 ns</td><td align="right" bgcolor="#FF4949">1654,585 ns (Δ = +539,747 ns)</td><td align="right" bgcolor="#FFFFFF">1752,083 ns</td><td align="right" bgcolor="#FFFFFF">1771,031 ns</td><td align="right" bgcolor="#A8D08D">1078,959 ns (Δ = -692,072 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,230 μs</td><td align="right" bgcolor="#FFFFFF">1,115 μs</td><td align="right" bgcolor="#FFFFFF">1,655 μs</td><td align="right" bgcolor="#FFFFFF">1,752 μs</td><td align="right" bgcolor="#FFFFFF">1,771 μs</td><td align="right" bgcolor="#FFFFFF">1,079 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -659,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">659,000 (Δ = +659,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#FFFFFF">0,644</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,644)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,644 (Δ = +0,644)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_6_Format_Arguments"></a>Log_Warning_Format_6_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 839,890 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+59,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1355,195 ns</td><td align="right" bgcolor="#FFFFFF">1242,601 ns</td><td align="right" bgcolor="#FF4949">1985,920 ns (Δ = +743,319 ns)</td><td align="right" bgcolor="#FFFFFF">2073,679 ns</td><td align="right" bgcolor="#FFFFFF">2082,491 ns</td><td align="right" bgcolor="#A8D08D">1592,702 ns (Δ = -489,789 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,355 μs</td><td align="right" bgcolor="#FFFFFF">1,243 μs</td><td align="right" bgcolor="#FFFFFF">1,986 μs</td><td align="right" bgcolor="#FFFFFF">2,074 μs</td><td align="right" bgcolor="#FFFFFF">2,082 μs</td><td align="right" bgcolor="#FFFFFF">1,593 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -836,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +836,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,816)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,816)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments"></a>Log_Warning_Format_7_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 904,903 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+53,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-34,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1442,919 ns</td><td align="right" bgcolor="#FFFFFF">1454,079 ns</td><td align="right" bgcolor="#FF4949">2225,311 ns (Δ = +771,233 ns)</td><td align="right" bgcolor="#FFFFFF">2321,906 ns</td><td align="right" bgcolor="#FFFFFF">2347,823 ns</td><td align="right" bgcolor="#A8D08D">1531,921 ns (Δ = -815,902 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,443 μs</td><td align="right" bgcolor="#FFFFFF">1,454 μs</td><td align="right" bgcolor="#FFFFFF">2,225 μs</td><td align="right" bgcolor="#FFFFFF">2,322 μs</td><td align="right" bgcolor="#FFFFFF">2,348 μs</td><td align="right" bgcolor="#FFFFFF">1,532 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#FFFFFF">924,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -924,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">924,000 (Δ = +924,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,902)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,902 (Δ = +0,902)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 3449,690 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,3 %</td><td align="right" bgcolor="#FF4949">+126,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-56,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2956,574 ns</td><td align="right" bgcolor="#A8D08D">2680,380 ns (Δ = -276,194 ns)</td><td align="right" bgcolor="#FF4949">6063,822 ns (Δ = +3383,442 ns)</td><td align="right" bgcolor="#FFFFFF">6071,511 ns</td><td align="right" bgcolor="#FFFFFF">6069,381 ns</td><td align="right" bgcolor="#A8D08D">2621,821 ns (Δ = -3447,560 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,957 μs</td><td align="right" bgcolor="#FFFFFF">2,680 μs</td><td align="right" bgcolor="#FFFFFF">6,064 μs</td><td align="right" bgcolor="#FFFFFF">6,072 μs</td><td align="right" bgcolor="#FFFFFF">6,069 μs</td><td align="right" bgcolor="#FFFFFF">2,622 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">346,000</td><td align="right" bgcolor="#FFFFFF">346,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -346,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">346,000 (Δ = +346,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,338</td><td align="right" bgcolor="#FFFFFF">0,338</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,338)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,338 (Δ = +0,338)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 5849,270 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#FF4949">+99,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-58,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5833,706 ns</td><td align="right" bgcolor="#A8D08D">4983,039 ns (Δ = -850,667 ns)</td><td align="right" bgcolor="#FF4949">9928,595 ns (Δ = +4945,556 ns)</td><td align="right" bgcolor="#FFFFFF">9966,583 ns</td><td align="right" bgcolor="#FFFFFF">10004,043 ns</td><td align="right" bgcolor="#A8D08D">4154,773 ns (Δ = -5849,270 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,834 μs</td><td align="right" bgcolor="#FFFFFF">4,983 μs</td><td align="right" bgcolor="#FFFFFF">9,929 μs</td><td align="right" bgcolor="#FFFFFF">9,967 μs</td><td align="right" bgcolor="#FFFFFF">10,004 μs</td><td align="right" bgcolor="#FFFFFF">4,155 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">723,000</td><td align="right" bgcolor="#FFFFFF">723,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -723,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">723,000 (Δ = +723,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,706</td><td align="right" bgcolor="#FFFFFF">0,706</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,706)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,706 (Δ = +0,706)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 4620,806 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+108,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-57,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3878,263 ns</td><td align="right" bgcolor="#FFFFFF">3811,647 ns</td><td align="right" bgcolor="#FF4949">7935,144 ns (Δ = +4123,498 ns)</td><td align="right" bgcolor="#FFFFFF">7971,096 ns</td><td align="right" bgcolor="#FFFFFF">7929,949 ns</td><td align="right" bgcolor="#A8D08D">3350,290 ns (Δ = -4579,660 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,878 μs</td><td align="right" bgcolor="#FFFFFF">3,812 μs</td><td align="right" bgcolor="#FFFFFF">7,935 μs</td><td align="right" bgcolor="#FFFFFF">7,971 μs</td><td align="right" bgcolor="#FFFFFF">7,930 μs</td><td align="right" bgcolor="#FFFFFF">3,350 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">675,000</td><td align="right" bgcolor="#FFFFFF">675,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -675,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">675,000 (Δ = +675,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,659</td><td align="right" bgcolor="#FFFFFF">0,659</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,659)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,659 (Δ = +0,659)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 3496,712 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+111,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-58,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3035,913 ns</td><td align="right" bgcolor="#FFFFFF">2801,310 ns</td><td align="right" bgcolor="#FF4949">5936,112 ns (Δ = +3134,802 ns)</td><td align="right" bgcolor="#FFFFFF">5957,381 ns</td><td align="right" bgcolor="#FFFFFF">6010,541 ns</td><td align="right" bgcolor="#A8D08D">2513,829 ns (Δ = -3496,712 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,036 μs</td><td align="right" bgcolor="#FFFFFF">2,801 μs</td><td align="right" bgcolor="#FFFFFF">5,936 μs</td><td align="right" bgcolor="#FFFFFF">5,957 μs</td><td align="right" bgcolor="#FFFFFF">6,011 μs</td><td align="right" bgcolor="#FFFFFF">2,514 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">346,000</td><td align="right" bgcolor="#FFFFFF">346,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -346,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">346,000 (Δ = +346,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,338</td><td align="right" bgcolor="#FFFFFF">0,338</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,338)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,338 (Δ = +0,338)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 5290,449 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+98,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-53,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5118,434 ns</td><td align="right" bgcolor="#FFFFFF">4994,039 ns</td><td align="right" bgcolor="#FF4949">9902,895 ns (Δ = +4908,856 ns)</td><td align="right" bgcolor="#FFFFFF">9856,076 ns</td><td align="right" bgcolor="#FFFFFF">9875,189 ns</td><td align="right" bgcolor="#A8D08D">4612,445 ns (Δ = -5262,744 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,118 μs</td><td align="right" bgcolor="#FFFFFF">4,994 μs</td><td align="right" bgcolor="#FFFFFF">9,903 μs</td><td align="right" bgcolor="#FFFFFF">9,856 μs</td><td align="right" bgcolor="#FFFFFF">9,875 μs</td><td align="right" bgcolor="#FFFFFF">4,612 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">723,000</td><td align="right" bgcolor="#FFFFFF">723,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -723,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">723,000 (Δ = +723,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,706</td><td align="right" bgcolor="#FFFFFF">0,706</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,706)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,706 (Δ = +0,706)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 6297,342 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,1 %</td><td align="right" bgcolor="#FF4949">+102,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-53,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6821,775 ns</td><td align="right" bgcolor="#A8D08D">5789,470 ns (Δ = -1032,305 ns)</td><td align="right" bgcolor="#FF4949">11723,417 ns (Δ = +5933,947 ns)</td><td align="right" bgcolor="#FFFFFF">11578,908 ns</td><td align="right" bgcolor="#FFFFFF">11775,845 ns</td><td align="right" bgcolor="#A8D08D">5478,503 ns (Δ = -6297,342 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,822 μs</td><td align="right" bgcolor="#FFFFFF">5,789 μs</td><td align="right" bgcolor="#FFFFFF">11,723 μs</td><td align="right" bgcolor="#FFFFFF">11,579 μs</td><td align="right" bgcolor="#FFFFFF">11,776 μs</td><td align="right" bgcolor="#FFFFFF">5,479 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1093,000</td><td align="right" bgcolor="#FFFFFF">1093,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1093,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1093,000 (Δ = +1093,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,067</td><td align="right" bgcolor="#FFFFFF">1,067</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,067)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,067 (Δ = +1,067)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="ModelBase_Constructor_Benchmark"></a>ModelBase_Constructor_Benchmark

### <a name="ModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 1288,145 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+36,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2970,133 ns</td><td align="right" bgcolor="#FFFFFF">3018,122 ns</td><td align="right" bgcolor="#FF4949">4123,311 ns (Δ = +1105,188 ns)</td><td align="right" bgcolor="#FFFFFF">3953,660 ns</td><td align="right" bgcolor="#FFFFFF">3754,289 ns</td><td align="right" bgcolor="#A8D08D">2835,166 ns (Δ = -919,123 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,970 μs</td><td align="right" bgcolor="#FFFFFF">3,018 μs</td><td align="right" bgcolor="#FFFFFF">4,123 μs</td><td align="right" bgcolor="#FFFFFF">3,954 μs</td><td align="right" bgcolor="#FFFFFF">3,754 μs</td><td align="right" bgcolor="#FFFFFF">2,835 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +2,000)</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">972,000</td><td align="right" bgcolor="#FFFFFF">972,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -972,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">932,000 (Δ = +932,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,949</td><td align="right" bgcolor="#FFFFFF">0,949</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,949)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,910 (Δ = +0,910)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 151,861 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">438,265 ns</td><td align="right" bgcolor="#FFFFFF">433,850 ns</td><td align="right" bgcolor="#FFFFFF">565,863 ns</td><td align="right" bgcolor="#FFFFFF">565,249 ns</td><td align="right" bgcolor="#FFFFFF">545,516 ns</td><td align="right" bgcolor="#FFFFFF">414,001 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,438 μs</td><td align="right" bgcolor="#FFFFFF">0,434 μs</td><td align="right" bgcolor="#FFFFFF">0,566 μs</td><td align="right" bgcolor="#FFFFFF">0,565 μs</td><td align="right" bgcolor="#FFFFFF">0,546 μs</td><td align="right" bgcolor="#FFFFFF">0,414 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">80,000</td><td align="right" bgcolor="#FFFFFF">80,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -80,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">57,000 (Δ = +57,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,078</td><td align="right" bgcolor="#FFFFFF">0,078</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,078)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,056 (Δ = +0,056)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 182,234 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">470,322 ns</td><td align="right" bgcolor="#FFFFFF">456,507 ns</td><td align="right" bgcolor="#FFFFFF">619,246 ns</td><td align="right" bgcolor="#FFFFFF">617,793 ns</td><td align="right" bgcolor="#FFFFFF">593,956 ns</td><td align="right" bgcolor="#FFFFFF">437,013 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,470 μs</td><td align="right" bgcolor="#FFFFFF">0,457 μs</td><td align="right" bgcolor="#FFFFFF">0,619 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,594 μs</td><td align="right" bgcolor="#FFFFFF">0,437 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">80,000</td><td align="right" bgcolor="#FFFFFF">80,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -80,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">57,000 (Δ = +57,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,078</td><td align="right" bgcolor="#FFFFFF">0,078</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,078)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,056 (Δ = +0,056)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 121,946 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">332,004 ns</td><td align="right" bgcolor="#FFFFFF">334,452 ns</td><td align="right" bgcolor="#FFFFFF">445,042 ns</td><td align="right" bgcolor="#FFFFFF">444,243 ns</td><td align="right" bgcolor="#FFFFFF">453,950 ns</td><td align="right" bgcolor="#FFFFFF">407,564 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,332 μs</td><td align="right" bgcolor="#FFFFFF">0,334 μs</td><td align="right" bgcolor="#FFFFFF">0,445 μs</td><td align="right" bgcolor="#FFFFFF">0,444 μs</td><td align="right" bgcolor="#FFFFFF">0,454 μs</td><td align="right" bgcolor="#FFFFFF">0,408 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -57,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">57,000 (Δ = +57,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,056)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,056 (Δ = +0,056)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="ObjectHelper_Benchmark"></a>ObjectHelper_Benchmark

### <a name="ObjectHelper_Benchmark_AreEqual__Same_Reference"></a>AreEqual__Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 1,594 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,381 ns</td><td align="right" bgcolor="#FFFFFF">1,515 ns</td><td align="right" bgcolor="#FFFFFF">2,960 ns</td><td align="right" bgcolor="#FFFFFF">2,975 ns</td><td align="right" bgcolor="#FFFFFF">2,959 ns</td><td align="right" bgcolor="#FFFFFF">2,437 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Both_Null"></a>AreEqual_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 1,895 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,127 ns</td><td align="right" bgcolor="#FFFFFF">1,537 ns</td><td align="right" bgcolor="#FFFFFF">2,979 ns</td><td align="right" bgcolor="#FFFFFF">3,023 ns</td><td align="right" bgcolor="#FFFFFF">2,580 ns</td><td align="right" bgcolor="#FFFFFF">2,002 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Not_Same_Reference"></a>AreEqual_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 5,951 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,766 ns</td><td align="right" bgcolor="#FFFFFF">5,820 ns</td><td align="right" bgcolor="#FFFFFF">10,693 ns</td><td align="right" bgcolor="#FFFFFF">10,709 ns</td><td align="right" bgcolor="#FFFFFF">10,718 ns</td><td align="right" bgcolor="#FFFFFF">6,991 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_One_Null"></a>AreEqual_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 1,843 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,149 ns</td><td align="right" bgcolor="#FFFFFF">1,486 ns</td><td align="right" bgcolor="#FFFFFF">2,965 ns</td><td align="right" bgcolor="#FFFFFF">2,992 ns</td><td align="right" bgcolor="#FFFFFF">2,982 ns</td><td align="right" bgcolor="#FFFFFF">2,729 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Strings"></a>AreEqual_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 7,431 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,284 ns</td><td align="right" bgcolor="#FFFFFF">7,435 ns</td><td align="right" bgcolor="#FFFFFF">12,715 ns</td><td align="right" bgcolor="#FFFFFF">12,490 ns</td><td align="right" bgcolor="#FFFFFF">11,882 ns</td><td align="right" bgcolor="#FFFFFF">7,098 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Both_Null"></a>AreEqualReferences_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 1,595 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,370 ns</td><td align="right" bgcolor="#FFFFFF">1,892 ns</td><td align="right" bgcolor="#FFFFFF">2,939 ns</td><td align="right" bgcolor="#FFFFFF">2,332 ns</td><td align="right" bgcolor="#FFFFFF">2,964 ns</td><td align="right" bgcolor="#FFFFFF">2,439 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Not_Same_Reference"></a>AreEqualReferences_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 30,426 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">34,612 ns</td><td align="right" bgcolor="#FFFFFF">43,368 ns</td><td align="right" bgcolor="#FFFFFF">65,038 ns</td><td align="right" bgcolor="#FFFFFF">64,863 ns</td><td align="right" bgcolor="#FFFFFF">65,019 ns</td><td align="right" bgcolor="#FFFFFF">44,860 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_One_Null"></a>AreEqualReferences_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 1,487 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,494 ns</td><td align="right" bgcolor="#FFFFFF">1,987 ns</td><td align="right" bgcolor="#FFFFFF">2,960 ns</td><td align="right" bgcolor="#FFFFFF">2,980 ns</td><td align="right" bgcolor="#FFFFFF">2,934 ns</td><td align="right" bgcolor="#FFFFFF">2,928 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Same_Reference"></a>AreEqualReferences_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 2,116 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,376 ns</td><td align="right" bgcolor="#FFFFFF">2,057 ns</td><td align="right" bgcolor="#FFFFFF">3,336 ns</td><td align="right" bgcolor="#FFFFFF">3,492 ns</td><td align="right" bgcolor="#FFFFFF">3,344 ns</td><td align="right" bgcolor="#FFFFFF">2,098 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Strings"></a>AreEqualReferences_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 48,701 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">52,075 ns</td><td align="right" bgcolor="#FFFFFF">65,923 ns</td><td align="right" bgcolor="#FFFFFF">100,366 ns</td><td align="right" bgcolor="#FFFFFF">100,776 ns</td><td align="right" bgcolor="#FFFFFF">98,319 ns</td><td align="right" bgcolor="#FFFFFF">85,971 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_IsNull"></a>IsNull

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 0,064 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,085 ns</td><td align="right" bgcolor="#FFFFFF">0,130 ns</td><td align="right" bgcolor="#FFFFFF">0,146 ns</td><td align="right" bgcolor="#FFFFFF">0,149 ns</td><td align="right" bgcolor="#FFFFFF">0,149 ns</td><td align="right" bgcolor="#FFFFFF">0,125 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ObjectToStringHelper_Benchmark"></a>ObjectToStringHelper_Benchmark

### <a name="ObjectToStringHelper_Benchmark_ToFullTypeString"></a>ToFullTypeString

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 53,474 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">71,073 ns</td><td align="right" bgcolor="#FFFFFF">97,018 ns</td><td align="right" bgcolor="#FFFFFF">123,346 ns</td><td align="right" bgcolor="#FFFFFF">124,547 ns</td><td align="right" bgcolor="#FFFFFF">123,919 ns</td><td align="right" bgcolor="#FFFFFF">102,392 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectToStringHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 4519,785 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,4 %</td><td align="right" bgcolor="#FF4949">+86,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-87,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2161,674 ns</td><td align="right" bgcolor="#FF4949">2645,411 ns (Δ = +483,737 ns)</td><td align="right" bgcolor="#FF4949">4936,809 ns (Δ = +2291,398 ns)</td><td align="right" bgcolor="#FFFFFF">4881,038 ns</td><td align="right" bgcolor="#A8D08D">609,276 ns (Δ = -4271,762 ns)</td><td align="right" bgcolor="#FFFFFF">417,024 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,162 μs</td><td align="right" bgcolor="#FFFFFF">2,645 μs</td><td align="right" bgcolor="#FFFFFF">4,937 μs</td><td align="right" bgcolor="#FFFFFF">4,881 μs</td><td align="right" bgcolor="#FFFFFF">0,609 μs</td><td align="right" bgcolor="#FFFFFF">0,417 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FF4949">5,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1743,000</td><td align="right" bgcolor="#A8D08D">1711,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1711,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">121,000 (Δ = +121,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,702</td><td align="right" bgcolor="#A8D08D">1,671 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,671)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,118 (Δ = +0,118)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ObjectToStringHelper_Benchmark_ToTypeString"></a>ToTypeString

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 13,561 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,666 ns</td><td align="right" bgcolor="#FFFFFF">19,122 ns</td><td align="right" bgcolor="#FFFFFF">29,227 ns</td><td align="right" bgcolor="#FFFFFF">29,128 ns</td><td align="right" bgcolor="#FFFFFF">29,202 ns</td><td align="right" bgcolor="#FFFFFF">20,662 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ParallelHelper_Benchmark"></a>ParallelHelper_Benchmark

### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100"></a>ExecuteInParallel_ItemsPerBash_100

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 1818882,226 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,5 %</td><td align="right" bgcolor="#FF4949">+62,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2787401,078 ns</td><td align="right" bgcolor="#FF4949">2829673,025 ns (Δ = +42271,947 ns)</td><td align="right" bgcolor="#FF4949">4606283,304 ns (Δ = +1776610,278 ns)</td><td align="right" bgcolor="#FFFFFF">4604879,528 ns</td><td align="right" bgcolor="#FFFFFF">4602547,231 ns</td><td align="right" bgcolor="#A8D08D">3474970,964 ns (Δ = -1127576,268 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2787,401 μs</td><td align="right" bgcolor="#FFFFFF">2829,673 μs</td><td align="right" bgcolor="#FF4949">4606,283 μs (Δ = +1776,610 μs)</td><td align="right" bgcolor="#FFFFFF">4604,880 μs</td><td align="right" bgcolor="#FFFFFF">4602,547 μs</td><td align="right" bgcolor="#A8D08D">3474,971 μs (Δ = -1127,576 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,787 ms</td><td align="right" bgcolor="#FFFFFF">2,830 ms</td><td align="right" bgcolor="#FFFFFF">4,606 ms</td><td align="right" bgcolor="#FFFFFF">4,605 ms</td><td align="right" bgcolor="#FFFFFF">4,603 ms</td><td align="right" bgcolor="#FFFFFF">3,475 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">402,000</td><td align="right" bgcolor="#A8D08D">401,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">536,000 (Δ = +135,000)</td><td align="right" bgcolor="#FFFFFF">536,000</td><td align="right" bgcolor="#FF4949">537,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">401,000 (Δ = -136,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">168823,000</td><td align="right" bgcolor="#A8D08D">168249,000 (Δ = -574,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -168249,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">168573,000 (Δ = +168573,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">164,866</td><td align="right" bgcolor="#A8D08D">164,306 (Δ = -0,561)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -164,306)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">164,622 (Δ = +164,622)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,161</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,160)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,161 (Δ = +0,161)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000"></a>ExecuteInParallel_ItemsPerBash_1000

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 364362,641 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,1 %</td><td align="right" bgcolor="#FF4949">+25,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">540750,563 ns</td><td align="right" bgcolor="#FF4949">719732,513 ns (Δ = +178981,950 ns)</td><td align="right" bgcolor="#FF4949">905113,204 ns (Δ = +185380,692 ns)</td><td align="right" bgcolor="#FFFFFF">902797,493 ns</td><td align="right" bgcolor="#FFFFFF">900636,969 ns</td><td align="right" bgcolor="#A8D08D">757039,865 ns (Δ = -143597,104 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">540,751 μs</td><td align="right" bgcolor="#FFFFFF">719,733 μs</td><td align="right" bgcolor="#FFFFFF">905,113 μs</td><td align="right" bgcolor="#FFFFFF">902,797 μs</td><td align="right" bgcolor="#FFFFFF">900,637 μs</td><td align="right" bgcolor="#FFFFFF">757,040 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,541 ms</td><td align="right" bgcolor="#FFFFFF">0,720 ms</td><td align="right" bgcolor="#FFFFFF">0,905 ms</td><td align="right" bgcolor="#FFFFFF">0,903 ms</td><td align="right" bgcolor="#FFFFFF">0,901 ms</td><td align="right" bgcolor="#FFFFFF">0,757 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">216,000</td><td align="right" bgcolor="#FFFFFF">216,000</td><td align="right" bgcolor="#FF4949">290,000 (Δ = +74,000)</td><td align="right" bgcolor="#FFFFFF">290,000</td><td align="right" bgcolor="#FF4949">291,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">216,000 (Δ = -75,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">91178,000</td><td align="right" bgcolor="#A8D08D">91161,000 (Δ = -17,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -91161,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">91240,000 (Δ = +91240,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">89,041</td><td align="right" bgcolor="#A8D08D">89,024 (Δ = -0,017)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -89,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">89,102 (Δ = +89,102)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,087</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,087)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,087)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500"></a>ExecuteInParallel_ItemsPerBash_500

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 559491,271 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,5 %</td><td align="right" bgcolor="#FF4949">+47,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">731555,567 ns</td><td align="right" bgcolor="#FF4949">874223,734 ns (Δ = +142668,168 ns)</td><td align="right" bgcolor="#FF4949">1291046,838 ns (Δ = +416823,104 ns)</td><td align="right" bgcolor="#FFFFFF">1290880,350 ns</td><td align="right" bgcolor="#FFFFFF">1288922,161 ns</td><td align="right" bgcolor="#A8D08D">961892,802 ns (Δ = -327029,359 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">731,556 μs</td><td align="right" bgcolor="#FFFFFF">874,224 μs</td><td align="right" bgcolor="#FF4949">1291,047 μs (Δ = +416,823 μs)</td><td align="right" bgcolor="#FFFFFF">1290,880 μs</td><td align="right" bgcolor="#FFFFFF">1288,922 μs</td><td align="right" bgcolor="#A8D08D">961,893 μs (Δ = -327,029 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,732 ms</td><td align="right" bgcolor="#FFFFFF">0,874 ms</td><td align="right" bgcolor="#FFFFFF">1,291 ms</td><td align="right" bgcolor="#FFFFFF">1,291 ms</td><td align="right" bgcolor="#FFFFFF">1,289 ms</td><td align="right" bgcolor="#FFFFFF">0,962 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">233,000</td><td align="right" bgcolor="#FFFFFF">233,000</td><td align="right" bgcolor="#FF4949">320,000 (Δ = +87,000)</td><td align="right" bgcolor="#A8D08D">315,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">314,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">233,000 (Δ = -81,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">97927,000</td><td align="right" bgcolor="#A8D08D">97839,000 (Δ = -88,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -97839,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">98110,000 (Δ = +98110,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">95,632</td><td align="right" bgcolor="#A8D08D">95,546 (Δ = -0,086)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -95,546)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">95,811 (Δ = +95,811)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,093</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,093)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,094 (Δ = +0,094)</td></tr></table>


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 50,857 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">151,724 ns</td><td align="right" bgcolor="#FFFFFF">113,366 ns</td><td align="right" bgcolor="#FFFFFF">155,387 ns</td><td align="right" bgcolor="#FFFFFF">146,910 ns</td><td align="right" bgcolor="#FFFFFF">134,998 ns</td><td align="right" bgcolor="#FFFFFF">104,530 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,152 μs</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 40,998 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">106,470 ns</td><td align="right" bgcolor="#FFFFFF">106,891 ns</td><td align="right" bgcolor="#FFFFFF">142,016 ns</td><td align="right" bgcolor="#FFFFFF">142,628 ns</td><td align="right" bgcolor="#FFFFFF">141,557 ns</td><td align="right" bgcolor="#FFFFFF">101,631 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 39,648 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">66,618 ns</td><td align="right" bgcolor="#FFFFFF">63,582 ns</td><td align="right" bgcolor="#FFFFFF">92,642 ns</td><td align="right" bgcolor="#FFFFFF">96,098 ns</td><td align="right" bgcolor="#FFFFFF">81,109 ns</td><td align="right" bgcolor="#FFFFFF">56,450 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 3135,291 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,2 %</td><td align="right" bgcolor="#FF4949">+78,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-55,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2700,932 ns</td><td align="right" bgcolor="#FF4949">3138,477 ns (Δ = +437,545 ns)</td><td align="right" bgcolor="#FF4949">5588,190 ns (Δ = +2449,713 ns)</td><td align="right" bgcolor="#FFFFFF">5505,280 ns</td><td align="right" bgcolor="#FFFFFF">5471,501 ns</td><td align="right" bgcolor="#A8D08D">2452,899 ns (Δ = -3018,602 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,701 μs</td><td align="right" bgcolor="#FFFFFF">3,138 μs</td><td align="right" bgcolor="#FFFFFF">5,588 μs</td><td align="right" bgcolor="#FFFFFF">5,505 μs</td><td align="right" bgcolor="#FFFFFF">5,472 μs</td><td align="right" bgcolor="#FFFFFF">2,453 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -321,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">321,000 (Δ = +321,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,313 (Δ = +0,313)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 698,545 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+74,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">766,379 ns</td><td align="right" bgcolor="#FFFFFF">740,472 ns</td><td align="right" bgcolor="#FF4949">1291,633 ns (Δ = +551,161 ns)</td><td align="right" bgcolor="#FFFFFF">1329,024 ns</td><td align="right" bgcolor="#FFFFFF">1380,346 ns</td><td align="right" bgcolor="#A8D08D">681,801 ns (Δ = -698,545 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,766 μs</td><td align="right" bgcolor="#FFFFFF">0,740 μs</td><td align="right" bgcolor="#FFFFFF">1,292 μs</td><td align="right" bgcolor="#FFFFFF">1,329 μs</td><td align="right" bgcolor="#FFFFFF">1,380 μs</td><td align="right" bgcolor="#FFFFFF">0,682 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">74,000 (Δ = +74,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,072 (Δ = +0,072)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 3869,106 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+109,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-55,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3312,331 ns</td><td align="right" bgcolor="#FFFFFF">3251,697 ns</td><td align="right" bgcolor="#FF4949">6800,718 ns (Δ = +3549,021 ns)</td><td align="right" bgcolor="#FFFFFF">6915,664 ns</td><td align="right" bgcolor="#FFFFFF">6877,726 ns</td><td align="right" bgcolor="#A8D08D">3046,559 ns (Δ = -3831,167 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,312 μs</td><td align="right" bgcolor="#FFFFFF">3,252 μs</td><td align="right" bgcolor="#FFFFFF">6,801 μs</td><td align="right" bgcolor="#FFFFFF">6,916 μs</td><td align="right" bgcolor="#FFFFFF">6,878 μs</td><td align="right" bgcolor="#FFFFFF">3,047 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">587,000</td><td align="right" bgcolor="#FFFFFF">587,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -587,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">587,000 (Δ = +587,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,573</td><td align="right" bgcolor="#FFFFFF">0,573</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,573)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,573 (Δ = +0,573)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 3162,061 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+98,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-55,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2767,243 ns</td><td align="right" bgcolor="#FFFFFF">2806,896 ns</td><td align="right" bgcolor="#FF4949">5559,569 ns (Δ = +2752,673 ns)</td><td align="right" bgcolor="#FFFFFF">5690,123 ns</td><td align="right" bgcolor="#FFFFFF">5614,749 ns</td><td align="right" bgcolor="#A8D08D">2528,062 ns (Δ = -3086,687 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,767 μs</td><td align="right" bgcolor="#FFFFFF">2,807 μs</td><td align="right" bgcolor="#FFFFFF">5,560 μs</td><td align="right" bgcolor="#FFFFFF">5,690 μs</td><td align="right" bgcolor="#FFFFFF">5,615 μs</td><td align="right" bgcolor="#FFFFFF">2,528 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -321,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">321,000 (Δ = +321,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,313 (Δ = +0,313)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 602,119 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+61,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">758,540 ns</td><td align="right" bgcolor="#FFFFFF">802,163 ns</td><td align="right" bgcolor="#FF4949">1296,588 ns (Δ = +494,424 ns)</td><td align="right" bgcolor="#FFFFFF">1349,930 ns</td><td align="right" bgcolor="#FFFFFF">1303,764 ns</td><td align="right" bgcolor="#A8D08D">747,811 ns (Δ = -555,953 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,759 μs</td><td align="right" bgcolor="#FFFFFF">0,802 μs</td><td align="right" bgcolor="#FFFFFF">1,297 μs</td><td align="right" bgcolor="#FFFFFF">1,350 μs</td><td align="right" bgcolor="#FFFFFF">1,304 μs</td><td align="right" bgcolor="#FFFFFF">0,748 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">74,000 (Δ = +74,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,072 (Δ = +0,072)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 617,769 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+88,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">735,918 ns</td><td align="right" bgcolor="#FFFFFF">632,815 ns</td><td align="right" bgcolor="#FF4949">1192,629 ns (Δ = +559,813 ns)</td><td align="right" bgcolor="#FFFFFF">1229,590 ns</td><td align="right" bgcolor="#FFFFFF">1227,655 ns</td><td align="right" bgcolor="#A8D08D">611,821 ns (Δ = -615,835 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,736 μs</td><td align="right" bgcolor="#FFFFFF">0,633 μs</td><td align="right" bgcolor="#FFFFFF">1,193 μs</td><td align="right" bgcolor="#FFFFFF">1,230 μs</td><td align="right" bgcolor="#FFFFFF">1,228 μs</td><td align="right" bgcolor="#FFFFFF">0,612 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#FFFFFF">161,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -161,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">161,000 (Δ = +161,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#FFFFFF">0,157</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,157)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,157 (Δ = +0,157)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="ResourceHelper_Benchmark"></a>ResourceHelper_Benchmark

### <a name="ResourceHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.0.0**

Slowest: 5.12.0

Δ: 2835,560 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+489,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">361,634 ns</td><td align="right" bgcolor="#FFFFFF">421,599 ns</td><td align="right" bgcolor="#FFFFFF">576,991 ns</td><td align="right" bgcolor="#FFFFFF">567,918 ns</td><td align="right" bgcolor="#FFFFFF">542,118 ns</td><td align="right" bgcolor="#FF4949">3197,193 ns (Δ = +2655,075 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,362 μs</td><td align="right" bgcolor="#FFFFFF">0,422 μs</td><td align="right" bgcolor="#FFFFFF">0,577 μs</td><td align="right" bgcolor="#FFFFFF">0,568 μs</td><td align="right" bgcolor="#FFFFFF">0,542 μs</td><td align="right" bgcolor="#FFFFFF">3,197 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +4,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">257,000</td><td align="right" bgcolor="#FFFFFF">257,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -257,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1814,000 (Δ = +1814,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,251</td><td align="right" bgcolor="#FFFFFF">0,251</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,251)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,771 (Δ = +1,771)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,002)</td></tr></table>


## <a name="ScopeManager_Benchmark"></a>ScopeManager_Benchmark

### <a name="ScopeManager_Benchmark_Get_Existing_ScopeManager"></a>Get_Existing_ScopeManager

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 622,928 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+304,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">126,127 ns</td><td align="right" bgcolor="#FFFFFF">120,338 ns</td><td align="right" bgcolor="#FFFFFF">176,948 ns</td><td align="right" bgcolor="#FFFFFF">177,849 ns</td><td align="right" bgcolor="#FFFFFF">183,821 ns</td><td align="right" bgcolor="#FF4949">743,265 ns (Δ = +559,444 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,177 μs</td><td align="right" bgcolor="#FFFFFF">0,178 μs</td><td align="right" bgcolor="#FFFFFF">0,184 μs</td><td align="right" bgcolor="#FFFFFF">0,743 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">554,000 (Δ = +554,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,541 (Δ = +0,541)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="ScopeManager_Benchmark_Get_New_ScopeManager"></a>Get_New_ScopeManager

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 540,466 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+245,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">124,095 ns</td><td align="right" bgcolor="#FFFFFF">120,584 ns</td><td align="right" bgcolor="#FFFFFF">177,979 ns</td><td align="right" bgcolor="#FFFFFF">174,990 ns</td><td align="right" bgcolor="#FFFFFF">191,153 ns</td><td align="right" bgcolor="#FF4949">661,050 ns (Δ = +469,897 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,178 μs</td><td align="right" bgcolor="#FFFFFF">0,175 μs</td><td align="right" bgcolor="#FFFFFF">0,191 μs</td><td align="right" bgcolor="#FFFFFF">0,661 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">546,000 (Δ = +546,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,533 (Δ = +0,533)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 432791,929 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,2 %</td><td align="right" bgcolor="#FF4949">+75,5 %</td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#FF4949">+1,8 %</td><td align="right" bgcolor="#A8D08D">-35,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">428136,349 ns</td><td align="right" bgcolor="#FF4949">488961,543 ns (Δ = +60825,194 ns)</td><td align="right" bgcolor="#FF4949">858192,769 ns (Δ = +369231,226 ns)</td><td align="right" bgcolor="#A8D08D">846115,762 ns (Δ = -12077,007 ns)</td><td align="right" bgcolor="#FF4949">860928,278 ns (Δ = +14812,517 ns)</td><td align="right" bgcolor="#A8D08D">551454,549 ns (Δ = -309473,729 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">428,136 μs</td><td align="right" bgcolor="#FFFFFF">488,962 μs</td><td align="right" bgcolor="#FF4949">858,193 μs (Δ = +369,231 μs)</td><td align="right" bgcolor="#FFFFFF">846,116 μs</td><td align="right" bgcolor="#FFFFFF">860,928 μs</td><td align="right" bgcolor="#A8D08D">551,455 μs (Δ = -309,474 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,428 ms</td><td align="right" bgcolor="#FFFFFF">0,489 ms</td><td align="right" bgcolor="#FFFFFF">0,858 ms</td><td align="right" bgcolor="#FFFFFF">0,846 ms</td><td align="right" bgcolor="#FFFFFF">0,861 ms</td><td align="right" bgcolor="#FFFFFF">0,551 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">247,000</td><td align="right" bgcolor="#FFFFFF">247,000</td><td align="right" bgcolor="#FF4949">331,000 (Δ = +84,000)</td><td align="right" bgcolor="#A8D08D">327,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">327,000</td><td align="right" bgcolor="#A8D08D">300,000 (Δ = -27,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">104005,000</td><td align="right" bgcolor="#A8D08D">103994,000 (Δ = -11,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -103994,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">125997,000 (Δ = +125997,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">101,567</td><td align="right" bgcolor="#A8D08D">101,557 (Δ = -0,011)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -101,557)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">123,044 (Δ = +123,044)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,099</td><td align="right" bgcolor="#A8D08D">0,099 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,099)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,120 (Δ = +0,120)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 299724,064 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+23,4 %</td><td align="right" bgcolor="#FF4949">+84,4 %</td><td align="right" bgcolor="#A8D08D">-2,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">234991,394 ns</td><td align="right" bgcolor="#FF4949">289955,824 ns (Δ = +54964,430 ns)</td><td align="right" bgcolor="#FF4949">534715,458 ns (Δ = +244759,634 ns)</td><td align="right" bgcolor="#A8D08D">519368,298 ns (Δ = -15347,160 ns)</td><td align="right" bgcolor="#FFFFFF">520081,281 ns</td><td align="right" bgcolor="#A8D08D">296892,641 ns (Δ = -223188,640 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">234,991 μs</td><td align="right" bgcolor="#FFFFFF">289,956 μs</td><td align="right" bgcolor="#FFFFFF">534,715 μs</td><td align="right" bgcolor="#FFFFFF">519,368 μs</td><td align="right" bgcolor="#FFFFFF">520,081 μs</td><td align="right" bgcolor="#FFFFFF">296,893 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,235 ms</td><td align="right" bgcolor="#FFFFFF">0,290 ms</td><td align="right" bgcolor="#FFFFFF">0,535 ms</td><td align="right" bgcolor="#FFFFFF">0,519 ms</td><td align="right" bgcolor="#FFFFFF">0,520 ms</td><td align="right" bgcolor="#FFFFFF">0,297 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">91,000</td><td align="right" bgcolor="#FFFFFF">91,000</td><td align="right" bgcolor="#FF4949">121,000 (Δ = +30,000)</td><td align="right" bgcolor="#A8D08D">118,000 (Δ = -3,000)</td><td align="right" bgcolor="#FFFFFF">118,000</td><td align="right" bgcolor="#A8D08D">104,000 (Δ = -14,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">38228,000</td><td align="right" bgcolor="#A8D08D">38212,000 (Δ = -16,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -38212,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">43934,000 (Δ = +43934,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">37,332</td><td align="right" bgcolor="#A8D08D">37,316 (Δ = -0,016)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -37,316)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">42,904 (Δ = +42,904)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,042 (Δ = +0,042)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 329494,807 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+81,0 %</td><td align="right" bgcolor="#A8D08D">-2,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-38,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">409308,309 ns</td><td align="right" bgcolor="#FFFFFF">406814,784 ns</td><td align="right" bgcolor="#FF4949">736309,590 ns (Δ = +329494,807 ns)</td><td align="right" bgcolor="#A8D08D">721763,679 ns (Δ = -14545,911 ns)</td><td align="right" bgcolor="#FFFFFF">718338,915 ns</td><td align="right" bgcolor="#A8D08D">444459,719 ns (Δ = -273879,197 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">409,308 μs</td><td align="right" bgcolor="#FFFFFF">406,815 μs</td><td align="right" bgcolor="#FF4949">736,310 μs (Δ = +329,495 μs)</td><td align="right" bgcolor="#FFFFFF">721,764 μs</td><td align="right" bgcolor="#FFFFFF">718,339 μs</td><td align="right" bgcolor="#A8D08D">444,460 μs (Δ = -273,879 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,409 ms</td><td align="right" bgcolor="#FFFFFF">0,407 ms</td><td align="right" bgcolor="#FFFFFF">0,736 ms</td><td align="right" bgcolor="#FFFFFF">0,722 ms</td><td align="right" bgcolor="#FFFFFF">0,718 ms</td><td align="right" bgcolor="#FFFFFF">0,444 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">197,000</td><td align="right" bgcolor="#FFFFFF">197,000</td><td align="right" bgcolor="#FF4949">264,000 (Δ = +67,000)</td><td align="right" bgcolor="#A8D08D">260,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">260,000</td><td align="right" bgcolor="#A8D08D">249,000 (Δ = -11,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">82953,000</td><td align="right" bgcolor="#A8D08D">82940,000 (Δ = -13,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -82940,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">104790,000 (Δ = +104790,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">81,009</td><td align="right" bgcolor="#A8D08D">80,996 (Δ = -0,013)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -80,996)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">102,334 (Δ = +102,334)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,079</td><td align="right" bgcolor="#A8D08D">0,079 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,079)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,100 (Δ = +0,100)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 852366,823 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,6 %</td><td align="right" bgcolor="#FF4949">+77,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">973840,023 ns</td><td align="right" bgcolor="#FF4949">1027935,225 ns (Δ = +54095,202 ns)</td><td align="right" bgcolor="#FF4949">1826206,846 ns (Δ = +798271,622 ns)</td><td align="right" bgcolor="#FFFFFF">1811663,259 ns</td><td align="right" bgcolor="#FFFFFF">1817985,997 ns</td><td align="right" bgcolor="#A8D08D">1217056,773 ns (Δ = -600929,224 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">973,840 μs</td><td align="right" bgcolor="#FFFFFF">1027,935 μs</td><td align="right" bgcolor="#FF4949">1826,207 μs (Δ = +798,272 μs)</td><td align="right" bgcolor="#FFFFFF">1811,663 μs</td><td align="right" bgcolor="#FFFFFF">1817,986 μs</td><td align="right" bgcolor="#A8D08D">1217,057 μs (Δ = -600,929 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,974 ms</td><td align="right" bgcolor="#FFFFFF">1,028 ms</td><td align="right" bgcolor="#FFFFFF">1,826 ms</td><td align="right" bgcolor="#FFFFFF">1,812 ms</td><td align="right" bgcolor="#FFFFFF">1,818 ms</td><td align="right" bgcolor="#FFFFFF">1,217 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">745,000</td><td align="right" bgcolor="#FFFFFF">745,000</td><td align="right" bgcolor="#FF4949">995,000 (Δ = +250,000)</td><td align="right" bgcolor="#A8D08D">989,000 (Δ = -6,000)</td><td align="right" bgcolor="#FFFFFF">989,000</td><td align="right" bgcolor="#FF4949">990,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">312810,000</td><td align="right" bgcolor="#A8D08D">312801,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -312801,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">415617,000 (Δ = +415617,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">305,479</td><td align="right" bgcolor="#A8D08D">305,470 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -305,470)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">405,876 (Δ = +405,876)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,298</td><td align="right" bgcolor="#A8D08D">0,298 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,298)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,396 (Δ = +0,396)</td></tr></table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 11316438,788 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,7 %</td><td align="right" bgcolor="#FF4949">+71,2 %</td><td align="right" bgcolor="#A8D08D">-1,0 %</td><td align="right" bgcolor="#FF4949">+1,8 %</td><td align="right" bgcolor="#A8D08D">-43,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18713111,176 ns</td><td align="right" bgcolor="#A8D08D">15212184,781 ns (Δ = -3500926,395 ns)</td><td align="right" bgcolor="#FF4949">26043944,448 ns (Δ = +10831759,667 ns)</td><td align="right" bgcolor="#A8D08D">25775418,940 ns (Δ = -268525,508 ns)</td><td align="right" bgcolor="#FF4949">26250717,707 ns (Δ = +475298,767 ns)</td><td align="right" bgcolor="#A8D08D">14934278,919 ns (Δ = -11316438,788 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">18713,111 μs</td><td align="right" bgcolor="#A8D08D">15212,185 μs (Δ = -3500,926 μs)</td><td align="right" bgcolor="#FF4949">26043,944 μs (Δ = +10831,760 μs)</td><td align="right" bgcolor="#A8D08D">25775,419 μs (Δ = -268,526 μs)</td><td align="right" bgcolor="#FF4949">26250,718 μs (Δ = +475,299 μs)</td><td align="right" bgcolor="#A8D08D">14934,279 μs (Δ = -11316,439 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">18,713 ms</td><td align="right" bgcolor="#FFFFFF">15,212 ms</td><td align="right" bgcolor="#FFFFFF">26,044 ms</td><td align="right" bgcolor="#FFFFFF">25,775 ms</td><td align="right" bgcolor="#FFFFFF">26,251 ms</td><td align="right" bgcolor="#FFFFFF">14,934 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 2</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3652,000</td><td align="right" bgcolor="#A8D08D">3651,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">4912,000 (Δ = +1261,000)</td><td align="right" bgcolor="#A8D08D">4902,000 (Δ = -10,000)</td><td align="right" bgcolor="#A8D08D">4896,000 (Δ = -6,000)</td><td align="right" bgcolor="#A8D08D">4075,000 (Δ = -821,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#A8D08D">7,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">14,000 (Δ = +7,000)</td><td align="right" bgcolor="#A8D08D">13,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">14,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">7,000 (Δ = -7,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1532168,000</td><td align="right" bgcolor="#A8D08D">1531502,000 (Δ = -666,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1531502,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1709446,000 (Δ = +1709446,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1496,258</td><td align="right" bgcolor="#A8D08D">1495,607 (Δ = -0,650)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1495,607)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1669,381 (Δ = +1669,381)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,461</td><td align="right" bgcolor="#A8D08D">1,461 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,461)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,630 (Δ = +1,630)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 633691,364 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#FF4949">+67,8 %</td><td align="right" bgcolor="#A8D08D">-2,0 %</td><td align="right" bgcolor="#FF4949">+3,9 %</td><td align="right" bgcolor="#A8D08D">-39,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">954076,330 ns</td><td align="right" bgcolor="#A8D08D">894175,601 ns (Δ = -59900,728 ns)</td><td align="right" bgcolor="#FF4949">1500868,706 ns (Δ = +606693,105 ns)</td><td align="right" bgcolor="#A8D08D">1470963,369 ns (Δ = -29905,337 ns)</td><td align="right" bgcolor="#FF4949">1527866,966 ns (Δ = +56903,597 ns)</td><td align="right" bgcolor="#A8D08D">919741,432 ns (Δ = -608125,534 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">954,076 μs</td><td align="right" bgcolor="#FFFFFF">894,176 μs</td><td align="right" bgcolor="#FF4949">1500,869 μs (Δ = +606,693 μs)</td><td align="right" bgcolor="#FFFFFF">1470,963 μs</td><td align="right" bgcolor="#FFFFFF">1527,867 μs</td><td align="right" bgcolor="#A8D08D">919,741 μs (Δ = -608,126 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,954 ms</td><td align="right" bgcolor="#FFFFFF">0,894 ms</td><td align="right" bgcolor="#FFFFFF">1,501 ms</td><td align="right" bgcolor="#FFFFFF">1,471 ms</td><td align="right" bgcolor="#FFFFFF">1,528 ms</td><td align="right" bgcolor="#FFFFFF">0,920 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">205,000</td><td align="right" bgcolor="#FFFFFF">205,000</td><td align="right" bgcolor="#FF4949">275,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">271,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">271,000</td><td align="right" bgcolor="#A8D08D">227,000 (Δ = -44,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">86060,000</td><td align="right" bgcolor="#A8D08D">86025,000 (Δ = -35,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -86025,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">95331,000 (Δ = +95331,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">84,043</td><td align="right" bgcolor="#A8D08D">84,009 (Δ = -0,034)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -84,009)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">93,097 (Δ = +93,097)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,082</td><td align="right" bgcolor="#A8D08D">0,082 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,082)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,091 (Δ = +0,091)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 1874622,929 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,2 %</td><td align="right" bgcolor="#FF4949">+67,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3013482,589 ns</td><td align="right" bgcolor="#A8D08D">2797616,614 ns (Δ = -215865,975 ns)</td><td align="right" bgcolor="#FF4949">4672239,543 ns (Δ = +1874622,929 ns)</td><td align="right" bgcolor="#FFFFFF">4635605,913 ns</td><td align="right" bgcolor="#FFFFFF">4637733,783 ns</td><td align="right" bgcolor="#A8D08D">2933690,053 ns (Δ = -1704043,730 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3013,483 μs</td><td align="right" bgcolor="#FFFFFF">2797,617 μs</td><td align="right" bgcolor="#FF4949">4672,240 μs (Δ = +1874,623 μs)</td><td align="right" bgcolor="#FFFFFF">4635,606 μs</td><td align="right" bgcolor="#FFFFFF">4637,734 μs</td><td align="right" bgcolor="#A8D08D">2933,690 μs (Δ = -1704,044 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,013 ms</td><td align="right" bgcolor="#FFFFFF">2,798 ms</td><td align="right" bgcolor="#FFFFFF">4,672 ms</td><td align="right" bgcolor="#FFFFFF">4,636 ms</td><td align="right" bgcolor="#FFFFFF">4,638 ms</td><td align="right" bgcolor="#FFFFFF">2,934 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FFFFFF">659,000</td><td align="right" bgcolor="#FF4949">887,000 (Δ = +228,000)</td><td align="right" bgcolor="#A8D08D">882,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">882,000</td><td align="right" bgcolor="#A8D08D">735,000 (Δ = -147,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">276618,000</td><td align="right" bgcolor="#FF4949">276637,000 (Δ = +19,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -276637,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">308495,000 (Δ = +308495,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">270,135</td><td align="right" bgcolor="#FF4949">270,153 (Δ = +0,019)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -270,153)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">301,265 (Δ = +301,265)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,264</td><td align="right" bgcolor="#FF4949">0,264 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,264)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,294 (Δ = +0,294)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 8881492,913 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,4 %</td><td align="right" bgcolor="#FF4949">+73,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,5 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15773182,692 ns</td><td align="right" bgcolor="#A8D08D">11927845,301 ns (Δ = -3845337,391 ns)</td><td align="right" bgcolor="#FF4949">20662593,588 ns (Δ = +8734748,286 ns)</td><td align="right" bgcolor="#FFFFFF">20504843,638 ns</td><td align="right" bgcolor="#FF4949">20809338,214 ns (Δ = +304494,576 ns)</td><td align="right" bgcolor="#A8D08D">12762747,198 ns (Δ = -8046591,016 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">15773,183 μs</td><td align="right" bgcolor="#A8D08D">11927,845 μs (Δ = -3845,337 μs)</td><td align="right" bgcolor="#FF4949">20662,594 μs (Δ = +8734,748 μs)</td><td align="right" bgcolor="#FFFFFF">20504,844 μs</td><td align="right" bgcolor="#FF4949">20809,338 μs (Δ = +304,495 μs)</td><td align="right" bgcolor="#A8D08D">12762,747 μs (Δ = -8046,591 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">15,773 ms</td><td align="right" bgcolor="#FFFFFF">11,928 ms</td><td align="right" bgcolor="#FFFFFF">20,663 ms</td><td align="right" bgcolor="#FFFFFF">20,505 ms</td><td align="right" bgcolor="#FFFFFF">20,809 ms</td><td align="right" bgcolor="#FFFFFF">12,763 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 2</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2935,000</td><td align="right" bgcolor="#FF4949">2938,000 (Δ = +3,000)</td><td align="right" bgcolor="#FF4949">3954,000 (Δ = +1016,000)</td><td align="right" bgcolor="#A8D08D">3932,000 (Δ = -22,000)</td><td align="right" bgcolor="#FF4949">3936,000 (Δ = +4,000)</td><td align="right" bgcolor="#A8D08D">3315,000 (Δ = -621,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#A8D08D">6,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">10,000 (Δ = +4,000)</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#A8D08D">6,000 (Δ = -4,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1231414,000</td><td align="right" bgcolor="#FF4949">1232489,000 (Δ = +1075,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1232489,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1390694,000 (Δ = +1390694,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1202,553</td><td align="right" bgcolor="#FF4949">1203,603 (Δ = +1,050)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1203,603)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1358,100 (Δ = +1358,100)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,174</td><td align="right" bgcolor="#FF4949">1,175 (Δ = +0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,175)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,326 (Δ = +1,326)</td></tr></table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 1361299,363 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,7 %</td><td align="right" bgcolor="#FF4949">+87,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#A8D08D">-69,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1145072,981 ns</td><td align="right" bgcolor="#A8D08D">1010960,376 ns (Δ = -134112,605 ns)</td><td align="right" bgcolor="#FF4949">1896079,614 ns (Δ = +885119,239 ns)</td><td align="right" bgcolor="#FFFFFF">1905298,767 ns</td><td align="right" bgcolor="#FF4949">1966144,451 ns (Δ = +60845,685 ns)</td><td align="right" bgcolor="#A8D08D">604845,089 ns (Δ = -1361299,363 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1145,073 μs</td><td align="right" bgcolor="#FFFFFF">1010,960 μs</td><td align="right" bgcolor="#FF4949">1896,080 μs (Δ = +885,119 μs)</td><td align="right" bgcolor="#FFFFFF">1905,299 μs</td><td align="right" bgcolor="#FFFFFF">1966,144 μs</td><td align="right" bgcolor="#A8D08D">604,845 μs (Δ = -1361,299 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,145 ms</td><td align="right" bgcolor="#FFFFFF">1,011 ms</td><td align="right" bgcolor="#FFFFFF">1,896 ms</td><td align="right" bgcolor="#FFFFFF">1,905 ms</td><td align="right" bgcolor="#FFFFFF">1,966 ms</td><td align="right" bgcolor="#FFFFFF">0,605 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.6.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1384,000</td><td align="right" bgcolor="#FFFFFF">1384,000</td><td align="right" bgcolor="#FF4949">1850,000 (Δ = +466,000)</td><td align="right" bgcolor="#FF4949">1874,000 (Δ = +24,000)</td><td align="right" bgcolor="#FFFFFF">1874,000</td><td align="right" bgcolor="#A8D08D">311,000 (Δ = -1563,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">582273,000</td><td align="right" bgcolor="#A8D08D">582234,000 (Δ = -39,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -582234,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">130869,000 (Δ = +130869,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">568,626</td><td align="right" bgcolor="#A8D08D">568,588 (Δ = -0,038)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -568,588)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">127,802 (Δ = +127,802)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,555</td><td align="right" bgcolor="#A8D08D">0,555 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,555)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,125 (Δ = +0,125)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 399338,538 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,3 %</td><td align="right" bgcolor="#FF4949">+89,7 %</td><td align="right" bgcolor="#A8D08D">-1,0 %</td><td align="right" bgcolor="#FF4949">+2,3 %</td><td align="right" bgcolor="#A8D08D">-58,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">450946,020 ns</td><td align="right" bgcolor="#A8D08D">354759,796 ns (Δ = -96186,224 ns)</td><td align="right" bgcolor="#FF4949">672812,733 ns (Δ = +318052,937 ns)</td><td align="right" bgcolor="#A8D08D">665765,330 ns (Δ = -7047,403 ns)</td><td align="right" bgcolor="#FF4949">681241,654 ns (Δ = +15476,325 ns)</td><td align="right" bgcolor="#A8D08D">281903,117 ns (Δ = -399338,538 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">450,946 μs</td><td align="right" bgcolor="#FFFFFF">354,760 μs</td><td align="right" bgcolor="#FF4949">672,813 μs (Δ = +318,053 μs)</td><td align="right" bgcolor="#FFFFFF">665,765 μs</td><td align="right" bgcolor="#FFFFFF">681,242 μs</td><td align="right" bgcolor="#A8D08D">281,903 μs (Δ = -399,339 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,451 ms</td><td align="right" bgcolor="#FFFFFF">0,355 ms</td><td align="right" bgcolor="#FFFFFF">0,673 ms</td><td align="right" bgcolor="#FFFFFF">0,666 ms</td><td align="right" bgcolor="#FFFFFF">0,681 ms</td><td align="right" bgcolor="#FFFFFF">0,282 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.6.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">327,000</td><td align="right" bgcolor="#FFFFFF">327,000</td><td align="right" bgcolor="#FF4949">436,000 (Δ = +109,000)</td><td align="right" bgcolor="#FF4949">438,000 (Δ = +2,000)</td><td align="right" bgcolor="#FFFFFF">438,000</td><td align="right" bgcolor="#A8D08D">97,000 (Δ = -341,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">137690,000</td><td align="right" bgcolor="#A8D08D">137653,000 (Δ = -37,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -137653,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">40775,000 (Δ = +40775,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">134,463</td><td align="right" bgcolor="#A8D08D">134,427 (Δ = -0,036)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -134,427)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">39,819 (Δ = +39,819)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,131</td><td align="right" bgcolor="#A8D08D">0,131 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,131)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,039 (Δ = +0,039)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 899237,483 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,5 %</td><td align="right" bgcolor="#FF4949">+96,6 %</td><td align="right" bgcolor="#FF4949">+2,2 %</td><td align="right" bgcolor="#FF4949">+3,6 %</td><td align="right" bgcolor="#A8D08D">-67,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">722417,836 ns</td><td align="right" bgcolor="#A8D08D">639688,069 ns (Δ = -82729,767 ns)</td><td align="right" bgcolor="#FF4949">1257781,296 ns (Δ = +618093,227 ns)</td><td align="right" bgcolor="#FF4949">1285231,230 ns (Δ = +27449,933 ns)</td><td align="right" bgcolor="#FF4949">1331960,480 ns (Δ = +46729,251 ns)</td><td align="right" bgcolor="#A8D08D">432722,997 ns (Δ = -899237,483 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">722,418 μs</td><td align="right" bgcolor="#FFFFFF">639,688 μs</td><td align="right" bgcolor="#FF4949">1257,781 μs (Δ = +618,093 μs)</td><td align="right" bgcolor="#FFFFFF">1285,231 μs</td><td align="right" bgcolor="#FFFFFF">1331,960 μs</td><td align="right" bgcolor="#A8D08D">432,723 μs (Δ = -899,237 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,722 ms</td><td align="right" bgcolor="#FFFFFF">0,640 ms</td><td align="right" bgcolor="#FFFFFF">1,258 ms</td><td align="right" bgcolor="#FFFFFF">1,285 ms</td><td align="right" bgcolor="#FFFFFF">1,332 ms</td><td align="right" bgcolor="#FFFFFF">0,433 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1028,000</td><td align="right" bgcolor="#FF4949">1029,000 (Δ = +1,000)</td><td align="right" bgcolor="#FF4949">1379,000 (Δ = +350,000)</td><td align="right" bgcolor="#FF4949">1390,000 (Δ = +11,000)</td><td align="right" bgcolor="#FF4949">1391,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">206,000 (Δ = -1185,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">433052,000</td><td align="right" bgcolor="#FF4949">433059,000 (Δ = +7,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -433059,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">86530,000 (Δ = +86530,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">422,902</td><td align="right" bgcolor="#FF4949">422,909 (Δ = +0,007)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -422,909)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">84,502 (Δ = +84,502)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,413</td><td align="right" bgcolor="#FF4949">0,413 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,413)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,083 (Δ = +0,083)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 3466477,892 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,8 %</td><td align="right" bgcolor="#FF4949">+108,6 %</td><td align="right" bgcolor="#FF4949">+4,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-75,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2547945,075 ns</td><td align="right" bgcolor="#A8D08D">2095036,531 ns (Δ = -452908,544 ns)</td><td align="right" bgcolor="#FF4949">4370556,174 ns (Δ = +2275519,644 ns)</td><td align="right" bgcolor="#FF4949">4577597,152 ns (Δ = +207040,978 ns)</td><td align="right" bgcolor="#FFFFFF">4592420,545 ns</td><td align="right" bgcolor="#A8D08D">1125942,653 ns (Δ = -3466477,892 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2547,945 μs</td><td align="right" bgcolor="#A8D08D">2095,037 μs (Δ = -452,909 μs)</td><td align="right" bgcolor="#FF4949">4370,556 μs (Δ = +2275,520 μs)</td><td align="right" bgcolor="#FFFFFF">4577,597 μs</td><td align="right" bgcolor="#FFFFFF">4592,421 μs</td><td align="right" bgcolor="#A8D08D">1125,943 μs (Δ = -3466,478 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,548 ms</td><td align="right" bgcolor="#FFFFFF">2,095 ms</td><td align="right" bgcolor="#FFFFFF">4,371 ms</td><td align="right" bgcolor="#FFFFFF">4,578 ms</td><td align="right" bgcolor="#FFFFFF">4,592 ms</td><td align="right" bgcolor="#FFFFFF">1,126 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.6.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">4542,000</td><td align="right" bgcolor="#FFFFFF">4542,000</td><td align="right" bgcolor="#FF4949">6058,000 (Δ = +1516,000)</td><td align="right" bgcolor="#FF4949">6144,000 (Δ = +86,000)</td><td align="right" bgcolor="#A8D08D">6143,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">739,000 (Δ = -5404,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +2,000)</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1909679,000</td><td align="right" bgcolor="#A8D08D">1909456,000 (Δ = -223,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1909456,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">310242,000 (Δ = +310242,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1864,921</td><td align="right" bgcolor="#A8D08D">1864,703 (Δ = -0,218)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1864,703)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">302,971 (Δ = +302,971)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,821</td><td align="right" bgcolor="#A8D08D">1,821 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,821)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,296 (Δ = +0,296)</td></tr></table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 855,372 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1044,031 ns</td><td align="right" bgcolor="#FFFFFF">1050,745 ns</td><td align="right" bgcolor="#FFFFFF">1261,470 ns</td><td align="right" bgcolor="#FFFFFF">1458,276 ns</td><td align="right" bgcolor="#FFFFFF">1667,769 ns</td><td align="right" bgcolor="#A8D08D">812,397 ns (Δ = -855,372 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,044 μs</td><td align="right" bgcolor="#FFFFFF">1,051 μs</td><td align="right" bgcolor="#FFFFFF">1,261 μs</td><td align="right" bgcolor="#FFFFFF">1,458 μs</td><td align="right" bgcolor="#FFFFFF">1,668 μs</td><td align="right" bgcolor="#FFFFFF">0,812 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2,000)</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +3,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">955,000</td><td align="right" bgcolor="#FFFFFF">955,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -955,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">875,000 (Δ = +875,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,933</td><td align="right" bgcolor="#FFFFFF">0,933</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,933)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,854 (Δ = +0,854)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 85,613 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">192,232 ns</td><td align="right" bgcolor="#FFFFFF">174,401 ns</td><td align="right" bgcolor="#FFFFFF">249,118 ns</td><td align="right" bgcolor="#FFFFFF">231,292 ns</td><td align="right" bgcolor="#FFFFFF">231,305 ns</td><td align="right" bgcolor="#FFFFFF">163,505 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,174 μs</td><td align="right" bgcolor="#FFFFFF">0,249 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td><td align="right" bgcolor="#FFFFFF">0,164 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">146,000</td><td align="right" bgcolor="#FFFFFF">146,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -146,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">146,000 (Δ = +146,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,143</td><td align="right" bgcolor="#FFFFFF">0,143</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,143)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,143 (Δ = +0,143)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Transient"></a>ResolveType_Transient

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 2052,726 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+69,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2842,950 ns</td><td align="right" bgcolor="#FFFFFF">2810,090 ns</td><td align="right" bgcolor="#FF4949">4773,635 ns (Δ = +1963,545 ns)</td><td align="right" bgcolor="#FFFFFF">4859,065 ns</td><td align="right" bgcolor="#FFFFFF">4678,762 ns</td><td align="right" bgcolor="#A8D08D">2806,339 ns (Δ = -1872,423 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,843 μs</td><td align="right" bgcolor="#FFFFFF">2,810 μs</td><td align="right" bgcolor="#FFFFFF">4,774 μs</td><td align="right" bgcolor="#FFFFFF">4,859 μs</td><td align="right" bgcolor="#FFFFFF">4,679 μs</td><td align="right" bgcolor="#FFFFFF">2,806 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,5 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1459,000</td><td align="right" bgcolor="#A8D08D">1451,000 (Δ = -8,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1451,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1725,000 (Δ = +1725,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,425</td><td align="right" bgcolor="#A8D08D">1,417 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,417)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,685 (Δ = +1,685)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,002)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 78,058 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">191,422 ns</td><td align="right" bgcolor="#FFFFFF">169,717 ns</td><td align="right" bgcolor="#FFFFFF">247,775 ns</td><td align="right" bgcolor="#FFFFFF">226,808 ns</td><td align="right" bgcolor="#FFFFFF">234,175 ns</td><td align="right" bgcolor="#FFFFFF">169,774 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,191 μs</td><td align="right" bgcolor="#FFFFFF">0,170 μs</td><td align="right" bgcolor="#FFFFFF">0,248 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,170 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">146,000</td><td align="right" bgcolor="#FFFFFF">146,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -146,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">146,000 (Δ = +146,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,143</td><td align="right" bgcolor="#FFFFFF">0,143</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,143)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,143 (Δ = +0,143)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency"></a>ResolveType_With_Transient_Dependency

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 4278,659 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+77,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-39,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5705,289 ns</td><td align="right" bgcolor="#FFFFFF">5554,771 ns</td><td align="right" bgcolor="#FF4949">9833,431 ns (Δ = +4278,659 ns)</td><td align="right" bgcolor="#FFFFFF">9772,600 ns</td><td align="right" bgcolor="#FFFFFF">9579,297 ns</td><td align="right" bgcolor="#A8D08D">5838,954 ns (Δ = -3740,343 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,705 μs</td><td align="right" bgcolor="#FFFFFF">5,555 μs</td><td align="right" bgcolor="#FFFFFF">9,833 μs</td><td align="right" bgcolor="#FFFFFF">9,773 μs</td><td align="right" bgcolor="#FFFFFF">9,579 μs</td><td align="right" bgcolor="#FFFFFF">5,839 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FF4949">9,000 (Δ = +2,000)</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#A8D08D">8,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,6 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3056,000</td><td align="right" bgcolor="#A8D08D">3039,000 (Δ = -17,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -3039,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">3593,000 (Δ = +3593,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,984</td><td align="right" bgcolor="#A8D08D">2,968 (Δ = -0,017)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2,968)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">3,509 (Δ = +3,509)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,003)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,003)</td></tr></table>


## <a name="TagHelper_Benchmark"></a>TagHelper_Benchmark

### <a name="TagHelper_Benchmark_AreTagsEqual"></a>AreTagsEqual

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 7,149 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,714 ns</td><td align="right" bgcolor="#FFFFFF">6,322 ns</td><td align="right" bgcolor="#FFFFFF">13,442 ns</td><td align="right" bgcolor="#FFFFFF">13,016 ns</td><td align="right" bgcolor="#FFFFFF">13,471 ns</td><td align="right" bgcolor="#FFFFFF">6,590 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TagHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 27375,892 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,6 %</td><td align="right" bgcolor="#FF4949">+94,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-94,1 %</td><td align="right" bgcolor="#A8D08D">-40,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11812,366 ns</td><td align="right" bgcolor="#FF4949">14478,521 ns (Δ = +2666,155 ns)</td><td align="right" bgcolor="#FF4949">28155,304 ns (Δ = +13676,782 ns)</td><td align="right" bgcolor="#FFFFFF">28368,740 ns</td><td align="right" bgcolor="#A8D08D">1680,923 ns (Δ = -26687,818 ns)</td><td align="right" bgcolor="#A8D08D">992,849 ns (Δ = -688,074 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">11,812 μs</td><td align="right" bgcolor="#FFFFFF">14,479 μs</td><td align="right" bgcolor="#FFFFFF">28,155 μs</td><td align="right" bgcolor="#FFFFFF">28,369 μs</td><td align="right" bgcolor="#FFFFFF">1,681 μs</td><td align="right" bgcolor="#FFFFFF">0,993 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,028 ms</td><td align="right" bgcolor="#FFFFFF">0,028 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FF4949">34,000 (Δ = +8,000)</td><td align="right" bgcolor="#FFFFFF">34,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -34,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">11016,000</td><td align="right" bgcolor="#A8D08D">10985,000 (Δ = -31,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -10985,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">282,000 (Δ = +282,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">10,758</td><td align="right" bgcolor="#A8D08D">10,728 (Δ = -0,030)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -10,728)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,275 (Δ = +0,275)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,011</td><td align="right" bgcolor="#A8D08D">0,010 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,010)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 19,331 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">23,990 ns</td><td align="right" bgcolor="#FFFFFF">22,497 ns</td><td align="right" bgcolor="#FFFFFF">37,683 ns</td><td align="right" bgcolor="#FFFFFF">37,119 ns</td><td align="right" bgcolor="#FFFFFF">36,255 ns</td><td align="right" bgcolor="#FFFFFF">18,352 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyEx"></a>GetAssemblyEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 14,075 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,943 ns</td><td align="right" bgcolor="#FFFFFF">19,807 ns</td><td align="right" bgcolor="#FFFFFF">26,469 ns</td><td align="right" bgcolor="#FFFFFF">26,442 ns</td><td align="right" bgcolor="#FFFFFF">30,026 ns</td><td align="right" bgcolor="#FFFFFF">15,950 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx"></a>GetAssemblyFullNameEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 12,038 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">23,737 ns</td><td align="right" bgcolor="#FFFFFF">20,569 ns</td><td align="right" bgcolor="#FFFFFF">29,417 ns</td><td align="right" bgcolor="#FFFFFF">30,582 ns</td><td align="right" bgcolor="#FFFFFF">31,460 ns</td><td align="right" bgcolor="#FFFFFF">19,422 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetBaseTypeEx"></a>GetBaseTypeEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 16,812 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">28,446 ns</td><td align="right" bgcolor="#FFFFFF">23,294 ns</td><td align="right" bgcolor="#FFFFFF">39,061 ns</td><td align="right" bgcolor="#FFFFFF">39,100 ns</td><td align="right" bgcolor="#FFFFFF">38,840 ns</td><td align="right" bgcolor="#FFFFFF">22,289 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorEx"></a>GetConstructorEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 116,506 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">247,521 ns</td><td align="right" bgcolor="#FFFFFF">245,787 ns</td><td align="right" bgcolor="#FFFFFF">361,383 ns</td><td align="right" bgcolor="#FFFFFF">362,292 ns</td><td align="right" bgcolor="#FFFFFF">360,391 ns</td><td align="right" bgcolor="#FFFFFF">247,162 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,248 μs</td><td align="right" bgcolor="#FFFFFF">0,246 μs</td><td align="right" bgcolor="#FFFFFF">0,361 μs</td><td align="right" bgcolor="#FFFFFF">0,362 μs</td><td align="right" bgcolor="#FFFFFF">0,360 μs</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">129,000</td><td align="right" bgcolor="#FFFFFF">129,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -129,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">129,000 (Δ = +129,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,126</td><td align="right" bgcolor="#FFFFFF">0,126</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,126)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,126 (Δ = +0,126)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorsEx"></a>GetConstructorsEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 40,981 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">79,660 ns</td><td align="right" bgcolor="#FFFFFF">71,993 ns</td><td align="right" bgcolor="#FFFFFF">107,606 ns</td><td align="right" bgcolor="#FFFFFF">106,610 ns</td><td align="right" bgcolor="#FFFFFF">109,881 ns</td><td align="right" bgcolor="#FFFFFF">68,900 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -33,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +33,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 2804,916 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+117,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-55,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2282,834 ns</td><td align="right" bgcolor="#FFFFFF">2285,385 ns</td><td align="right" bgcolor="#FF4949">4969,729 ns (Δ = +2684,345 ns)</td><td align="right" bgcolor="#FFFFFF">5003,639 ns</td><td align="right" bgcolor="#FFFFFF">4954,696 ns</td><td align="right" bgcolor="#A8D08D">2198,723 ns (Δ = -2755,973 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,283 μs</td><td align="right" bgcolor="#FFFFFF">2,285 μs</td><td align="right" bgcolor="#FFFFFF">4,970 μs</td><td align="right" bgcolor="#FFFFFF">5,004 μs</td><td align="right" bgcolor="#FFFFFF">4,955 μs</td><td align="right" bgcolor="#FFFFFF">2,199 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -282,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">282,000 (Δ = +282,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,275)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,275 (Δ = +0,275)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 8058,382 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,6 %</td><td align="right" bgcolor="#FF4949">+50,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,2 %</td><td align="right" bgcolor="#A8D08D">-42,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9048,912 ns</td><td align="right" bgcolor="#FF4949">10101,499 ns (Δ = +1052,588 ns)</td><td align="right" bgcolor="#FF4949">15244,697 ns (Δ = +5143,198 ns)</td><td align="right" bgcolor="#FFFFFF">15453,522 ns</td><td align="right" bgcolor="#A8D08D">12796,465 ns (Δ = -2657,057 ns)</td><td align="right" bgcolor="#A8D08D">7395,141 ns (Δ = -5401,324 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,049 μs</td><td align="right" bgcolor="#FFFFFF">10,101 μs</td><td align="right" bgcolor="#FFFFFF">15,245 μs</td><td align="right" bgcolor="#FFFFFF">15,454 μs</td><td align="right" bgcolor="#FFFFFF">12,796 μs</td><td align="right" bgcolor="#FFFFFF">7,395 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">811,000</td><td align="right" bgcolor="#FFFFFF">811,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -811,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +811,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,792</td><td align="right" bgcolor="#FFFFFF">0,792</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,792)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,792)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 2796,028 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,3 %</td><td align="right" bgcolor="#FF4949">+89,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-55,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2287,650 ns</td><td align="right" bgcolor="#FF4949">2615,358 ns (Δ = +327,708 ns)</td><td align="right" bgcolor="#FF4949">4950,522 ns (Δ = +2335,164 ns)</td><td align="right" bgcolor="#FFFFFF">4823,223 ns</td><td align="right" bgcolor="#FFFFFF">4890,125 ns</td><td align="right" bgcolor="#A8D08D">2154,495 ns (Δ = -2735,631 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,288 μs</td><td align="right" bgcolor="#FFFFFF">2,615 μs</td><td align="right" bgcolor="#FFFFFF">4,951 μs</td><td align="right" bgcolor="#FFFFFF">4,823 μs</td><td align="right" bgcolor="#FFFFFF">4,890 μs</td><td align="right" bgcolor="#FFFFFF">2,154 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#FFFFFF">282,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -282,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">282,000 (Δ = +282,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#FFFFFF">0,275</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,275)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,275 (Δ = +0,275)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 8065,293 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,1 %</td><td align="right" bgcolor="#FF4949">+79,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,0 %</td><td align="right" bgcolor="#A8D08D">-42,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9265,364 ns</td><td align="right" bgcolor="#A8D08D">8517,147 ns (Δ = -748,217 ns)</td><td align="right" bgcolor="#FF4949">15248,213 ns (Δ = +6731,066 ns)</td><td align="right" bgcolor="#FFFFFF">15356,459 ns</td><td align="right" bgcolor="#A8D08D">12598,229 ns (Δ = -2758,230 ns)</td><td align="right" bgcolor="#A8D08D">7291,166 ns (Δ = -5307,063 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,265 μs</td><td align="right" bgcolor="#FFFFFF">8,517 μs</td><td align="right" bgcolor="#FFFFFF">15,248 μs</td><td align="right" bgcolor="#FFFFFF">15,356 μs</td><td align="right" bgcolor="#FFFFFF">12,598 μs</td><td align="right" bgcolor="#FFFFFF">7,291 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">811,000</td><td align="right" bgcolor="#FFFFFF">811,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -811,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +811,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,792</td><td align="right" bgcolor="#FFFFFF">0,792</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,792)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,792)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 7,262 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,647 ns</td><td align="right" bgcolor="#FFFFFF">5,602 ns</td><td align="right" bgcolor="#FFFFFF">12,683 ns</td><td align="right" bgcolor="#FFFFFF">12,865 ns</td><td align="right" bgcolor="#FFFFFF">11,305 ns</td><td align="right" bgcolor="#FFFFFF">5,916 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 336,607 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+55,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-37,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">641,910 ns</td><td align="right" bgcolor="#FFFFFF">574,844 ns</td><td align="right" bgcolor="#FF4949">890,935 ns (Δ = +316,092 ns)</td><td align="right" bgcolor="#FFFFFF">903,055 ns</td><td align="right" bgcolor="#FFFFFF">909,504 ns</td><td align="right" bgcolor="#A8D08D">572,897 ns (Δ = -336,607 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,642 μs</td><td align="right" bgcolor="#FFFFFF">0,575 μs</td><td align="right" bgcolor="#FFFFFF">0,891 μs</td><td align="right" bgcolor="#FFFFFF">0,903 μs</td><td align="right" bgcolor="#FFFFFF">0,910 μs</td><td align="right" bgcolor="#FFFFFF">0,573 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -242,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">242,000 (Δ = +242,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,236)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,236 (Δ = +0,236)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Instance"></a>GetEventEx_Instance

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 61,958 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">93,442 ns</td><td align="right" bgcolor="#FFFFFF">91,329 ns</td><td align="right" bgcolor="#FFFFFF">129,442 ns</td><td align="right" bgcolor="#FFFFFF">141,420 ns</td><td align="right" bgcolor="#FFFFFF">118,531 ns</td><td align="right" bgcolor="#FFFFFF">79,462 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 916,817 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,5 %</td><td align="right" bgcolor="#FF4949">+40,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2641,482 ns</td><td align="right" bgcolor="#A8D08D">2284,804 ns (Δ = -356,678 ns)</td><td align="right" bgcolor="#FF4949">3201,621 ns (Δ = +916,817 ns)</td><td align="right" bgcolor="#FFFFFF">3191,503 ns</td><td align="right" bgcolor="#FFFFFF">3117,367 ns</td><td align="right" bgcolor="#FFFFFF">3099,045 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,641 μs</td><td align="right" bgcolor="#FFFFFF">2,285 μs</td><td align="right" bgcolor="#FFFFFF">3,202 μs</td><td align="right" bgcolor="#FFFFFF">3,192 μs</td><td align="right" bgcolor="#FFFFFF">3,117 μs</td><td align="right" bgcolor="#FFFFFF">3,099 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">195,000</td><td align="right" bgcolor="#FFFFFF">195,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -195,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">760,000 (Δ = +760,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,190)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,742 (Δ = +0,742)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 639,450 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+70,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-37,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">820,823 ns</td><td align="right" bgcolor="#FFFFFF">853,206 ns</td><td align="right" bgcolor="#FF4949">1453,568 ns (Δ = +600,362 ns)</td><td align="right" bgcolor="#FFFFFF">1347,851 ns</td><td align="right" bgcolor="#FFFFFF">1309,329 ns</td><td align="right" bgcolor="#A8D08D">814,117 ns (Δ = -495,212 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,821 μs</td><td align="right" bgcolor="#FFFFFF">0,853 μs</td><td align="right" bgcolor="#FFFFFF">1,454 μs</td><td align="right" bgcolor="#FFFFFF">1,348 μs</td><td align="right" bgcolor="#FFFFFF">1,309 μs</td><td align="right" bgcolor="#FFFFFF">0,814 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">396,000</td><td align="right" bgcolor="#FFFFFF">396,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -396,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">397,000 (Δ = +397,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,387</td><td align="right" bgcolor="#FFFFFF">0,387</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,387)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,388 (Δ = +0,388)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 240,138 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">361,183 ns</td><td align="right" bgcolor="#FFFFFF">344,547 ns</td><td align="right" bgcolor="#FFFFFF">575,290 ns</td><td align="right" bgcolor="#FFFFFF">584,685 ns</td><td align="right" bgcolor="#FFFFFF">572,924 ns</td><td align="right" bgcolor="#FFFFFF">349,442 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,361 μs</td><td align="right" bgcolor="#FFFFFF">0,345 μs</td><td align="right" bgcolor="#FFFFFF">0,575 μs</td><td align="right" bgcolor="#FFFFFF">0,585 μs</td><td align="right" bgcolor="#FFFFFF">0,573 μs</td><td align="right" bgcolor="#FFFFFF">0,349 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">300,000</td><td align="right" bgcolor="#FFFFFF">300,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -300,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">300,000 (Δ = +300,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,293</td><td align="right" bgcolor="#FFFFFF">0,293</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,293)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,293 (Δ = +0,293)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 383,267 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+54,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-37,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">583,788 ns</td><td align="right" bgcolor="#FFFFFF">586,138 ns</td><td align="right" bgcolor="#FF4949">905,639 ns (Δ = +319,500 ns)</td><td align="right" bgcolor="#FFFFFF">951,857 ns</td><td align="right" bgcolor="#FFFFFF">967,054 ns</td><td align="right" bgcolor="#A8D08D">609,369 ns (Δ = -357,686 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,584 μs</td><td align="right" bgcolor="#FFFFFF">0,586 μs</td><td align="right" bgcolor="#FFFFFF">0,906 μs</td><td align="right" bgcolor="#FFFFFF">0,952 μs</td><td align="right" bgcolor="#FFFFFF">0,967 μs</td><td align="right" bgcolor="#FFFFFF">0,609 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -242,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">242,000 (Δ = +242,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,236)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,236 (Δ = +0,236)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags"></a>GetFieldEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 54,098 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">88,097 ns</td><td align="right" bgcolor="#FFFFFF">87,663 ns</td><td align="right" bgcolor="#FFFFFF">127,919 ns</td><td align="right" bgcolor="#FFFFFF">127,819 ns</td><td align="right" bgcolor="#FFFFFF">115,409 ns</td><td align="right" bgcolor="#FFFFFF">73,821 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 58,444 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">112,505 ns</td><td align="right" bgcolor="#FFFFFF">99,278 ns</td><td align="right" bgcolor="#FFFFFF">139,848 ns</td><td align="right" bgcolor="#FFFFFF">146,426 ns</td><td align="right" bgcolor="#FFFFFF">123,135 ns</td><td align="right" bgcolor="#FFFFFF">87,981 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 60,361 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">90,688 ns</td><td align="right" bgcolor="#FFFFFF">90,052 ns</td><td align="right" bgcolor="#FFFFFF">131,700 ns</td><td align="right" bgcolor="#FFFFFF">126,701 ns</td><td align="right" bgcolor="#FFFFFF">116,825 ns</td><td align="right" bgcolor="#FFFFFF">71,339 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,117 μs</td><td align="right" bgcolor="#FFFFFF">0,071 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 389,794 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+71,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">570,248 ns</td><td align="right" bgcolor="#FFFFFF">498,304 ns</td><td align="right" bgcolor="#FF4949">854,189 ns (Δ = +355,885 ns)</td><td align="right" bgcolor="#FFFFFF">821,561 ns</td><td align="right" bgcolor="#FFFFFF">887,686 ns</td><td align="right" bgcolor="#A8D08D">497,892 ns (Δ = -389,794 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,570 μs</td><td align="right" bgcolor="#FFFFFF">0,498 μs</td><td align="right" bgcolor="#FFFFFF">0,854 μs</td><td align="right" bgcolor="#FFFFFF">0,822 μs</td><td align="right" bgcolor="#FFFFFF">0,888 μs</td><td align="right" bgcolor="#FFFFFF">0,498 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">315,000</td><td align="right" bgcolor="#FF4949">346,000 (Δ = +31,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -346,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">362,000 (Δ = +362,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,308</td><td align="right" bgcolor="#FF4949">0,338 (Δ = +0,030)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,338)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,354 (Δ = +0,354)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 44,963 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">86,214 ns</td><td align="right" bgcolor="#FFFFFF">85,704 ns</td><td align="right" bgcolor="#FFFFFF">129,736 ns</td><td align="right" bgcolor="#FFFFFF">129,991 ns</td><td align="right" bgcolor="#FFFFFF">128,301 ns</td><td align="right" bgcolor="#FFFFFF">85,028 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,130 μs</td><td align="right" bgcolor="#FFFFFF">0,130 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 545,287 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+65,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-38,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">759,052 ns</td><td align="right" bgcolor="#FFFFFF">789,552 ns</td><td align="right" bgcolor="#FF4949">1304,339 ns (Δ = +514,787 ns)</td><td align="right" bgcolor="#FFFFFF">1252,275 ns</td><td align="right" bgcolor="#FFFFFF">1262,683 ns</td><td align="right" bgcolor="#A8D08D">774,293 ns (Δ = -488,390 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,759 μs</td><td align="right" bgcolor="#FFFFFF">0,790 μs</td><td align="right" bgcolor="#FFFFFF">1,304 μs</td><td align="right" bgcolor="#FFFFFF">1,252 μs</td><td align="right" bgcolor="#FFFFFF">1,263 μs</td><td align="right" bgcolor="#FFFFFF">0,774 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,3 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">354,000</td><td align="right" bgcolor="#FF4949">387,000 (Δ = +33,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -387,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">395,000 (Δ = +395,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,346</td><td align="right" bgcolor="#FF4949">0,378 (Δ = +0,032)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,378)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,386 (Δ = +0,386)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 54,328 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">80,379 ns</td><td align="right" bgcolor="#FFFFFF">85,119 ns</td><td align="right" bgcolor="#FFFFFF">127,624 ns</td><td align="right" bgcolor="#FFFFFF">132,071 ns</td><td align="right" bgcolor="#FFFFFF">128,337 ns</td><td align="right" bgcolor="#FFFFFF">77,743 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 99,689 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">165,647 ns</td><td align="right" bgcolor="#FFFFFF">153,023 ns</td><td align="right" bgcolor="#FFFFFF">231,504 ns</td><td align="right" bgcolor="#FFFFFF">233,459 ns</td><td align="right" bgcolor="#FFFFFF">229,314 ns</td><td align="right" bgcolor="#FFFFFF">133,770 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#FFFFFF">0,153 μs</td><td align="right" bgcolor="#FFFFFF">0,232 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td><td align="right" bgcolor="#FFFFFF">0,229 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -33,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +33,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx"></a>GetGenericTypeDefinitionEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 64,079 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">81,513 ns</td><td align="right" bgcolor="#FFFFFF">79,564 ns</td><td align="right" bgcolor="#FFFFFF">143,642 ns</td><td align="right" bgcolor="#FFFFFF">140,469 ns</td><td align="right" bgcolor="#FFFFFF">137,935 ns</td><td align="right" bgcolor="#FFFFFF">80,304 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetInterfacesEx"></a>GetInterfacesEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 79,997 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">142,039 ns</td><td align="right" bgcolor="#FFFFFF">125,141 ns</td><td align="right" bgcolor="#FFFFFF">199,368 ns</td><td align="right" bgcolor="#FFFFFF">194,271 ns</td><td align="right" bgcolor="#FFFFFF">205,138 ns</td><td align="right" bgcolor="#FFFFFF">127,504 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,199 μs</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -193,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">202,000 (Δ = +202,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,188)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,197 (Δ = +0,197)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 859,495 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+65,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1097,907 ns</td><td align="right" bgcolor="#FFFFFF">1096,230 ns</td><td align="right" bgcolor="#FF4949">1810,720 ns (Δ = +714,490 ns)</td><td align="right" bgcolor="#FFFFFF">1860,917 ns</td><td align="right" bgcolor="#FFFFFF">1776,980 ns</td><td align="right" bgcolor="#A8D08D">1001,422 ns (Δ = -775,558 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,098 μs</td><td align="right" bgcolor="#FFFFFF">1,096 μs</td><td align="right" bgcolor="#FFFFFF">1,811 μs</td><td align="right" bgcolor="#FFFFFF">1,861 μs</td><td align="right" bgcolor="#FFFFFF">1,777 μs</td><td align="right" bgcolor="#FFFFFF">1,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">265,000</td><td align="right" bgcolor="#FFFFFF">265,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -265,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">265,000 (Δ = +265,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,259</td><td align="right" bgcolor="#FFFFFF">0,259</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,259)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,259 (Δ = +0,259)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 384,357 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+60,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-37,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">562,473 ns</td><td align="right" bgcolor="#FFFFFF">553,708 ns</td><td align="right" bgcolor="#FF4949">889,312 ns (Δ = +335,604 ns)</td><td align="right" bgcolor="#FFFFFF">906,333 ns</td><td align="right" bgcolor="#FFFFFF">837,212 ns</td><td align="right" bgcolor="#A8D08D">521,976 ns (Δ = -315,236 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,562 μs</td><td align="right" bgcolor="#FFFFFF">0,554 μs</td><td align="right" bgcolor="#FFFFFF">0,889 μs</td><td align="right" bgcolor="#FFFFFF">0,906 μs</td><td align="right" bgcolor="#FFFFFF">0,837 μs</td><td align="right" bgcolor="#FFFFFF">0,522 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -26,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">26,000 (Δ = +26,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,025)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,025 (Δ = +0,025)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance"></a>GetMemberEx_Instance

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 428,279 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+69,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-37,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">651,056 ns</td><td align="right" bgcolor="#FFFFFF">552,880 ns</td><td align="right" bgcolor="#FF4949">935,717 ns (Δ = +382,837 ns)</td><td align="right" bgcolor="#FFFFFF">978,852 ns</td><td align="right" bgcolor="#FFFFFF">873,287 ns</td><td align="right" bgcolor="#A8D08D">550,573 ns (Δ = -322,714 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,651 μs</td><td align="right" bgcolor="#FFFFFF">0,553 μs</td><td align="right" bgcolor="#FFFFFF">0,936 μs</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">0,873 μs</td><td align="right" bgcolor="#FFFFFF">0,551 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -33,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +33,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 377,326 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+65,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-39,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">700,019 ns</td><td align="right" bgcolor="#FFFFFF">523,679 ns</td><td align="right" bgcolor="#FF4949">866,947 ns (Δ = +343,268 ns)</td><td align="right" bgcolor="#FFFFFF">886,375 ns</td><td align="right" bgcolor="#FFFFFF">837,694 ns</td><td align="right" bgcolor="#A8D08D">509,049 ns (Δ = -328,645 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,700 μs</td><td align="right" bgcolor="#FFFFFF">0,524 μs</td><td align="right" bgcolor="#FFFFFF">0,867 μs</td><td align="right" bgcolor="#FFFFFF">0,886 μs</td><td align="right" bgcolor="#FFFFFF">0,838 μs</td><td align="right" bgcolor="#FFFFFF">0,509 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -26,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">26,000 (Δ = +26,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#FFFFFF">0,025</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,025)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,025 (Δ = +0,025)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static"></a>GetMethodEx_Flatten_Static

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 402,883 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+66,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">609,747 ns</td><td align="right" bgcolor="#FFFFFF">609,141 ns</td><td align="right" bgcolor="#FF4949">1012,024 ns (Δ = +402,883 ns)</td><td align="right" bgcolor="#FFFFFF">1007,620 ns</td><td align="right" bgcolor="#FFFFFF">897,777 ns</td><td align="right" bgcolor="#A8D08D">618,974 ns (Δ = -278,804 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,610 μs</td><td align="right" bgcolor="#FFFFFF">0,609 μs</td><td align="right" bgcolor="#FFFFFF">1,012 μs</td><td align="right" bgcolor="#FFFFFF">1,008 μs</td><td align="right" bgcolor="#FFFFFF">0,898 μs</td><td align="right" bgcolor="#FFFFFF">0,619 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">241,000</td><td align="right" bgcolor="#FFFFFF">241,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">241,000 (Δ = +241,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,235</td><td align="right" bgcolor="#FFFFFF">0,235</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,235 (Δ = +0,235)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags"></a>GetMethodEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 61,941 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">107,599 ns</td><td align="right" bgcolor="#FFFFFF">109,131 ns</td><td align="right" bgcolor="#FFFFFF">155,047 ns</td><td align="right" bgcolor="#FFFFFF">155,553 ns</td><td align="right" bgcolor="#FFFFFF">137,824 ns</td><td align="right" bgcolor="#FFFFFF">93,611 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 60,266 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">137,897 ns</td><td align="right" bgcolor="#FFFFFF">118,772 ns</td><td align="right" bgcolor="#FFFFFF">167,291 ns</td><td align="right" bgcolor="#FFFFFF">171,201 ns</td><td align="right" bgcolor="#FFFFFF">150,869 ns</td><td align="right" bgcolor="#FFFFFF">110,935 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td><td align="right" bgcolor="#FFFFFF">0,171 μs</td><td align="right" bgcolor="#FFFFFF">0,151 μs</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 56,349 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">111,328 ns</td><td align="right" bgcolor="#FFFFFF">105,444 ns</td><td align="right" bgcolor="#FFFFFF">154,323 ns</td><td align="right" bgcolor="#FFFFFF">154,505 ns</td><td align="right" bgcolor="#FFFFFF">140,996 ns</td><td align="right" bgcolor="#FFFFFF">98,155 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,154 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 7523,082 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+117,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,6 %</td><td align="right" bgcolor="#A8D08D">-25,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6151,465 ns</td><td align="right" bgcolor="#FFFFFF">6050,826 ns</td><td align="right" bgcolor="#FF4949">13151,306 ns (Δ = +7100,479 ns)</td><td align="right" bgcolor="#FFFFFF">13170,012 ns</td><td align="right" bgcolor="#A8D08D">7556,160 ns (Δ = -5613,852 ns)</td><td align="right" bgcolor="#A8D08D">5646,930 ns (Δ = -1909,230 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,151 μs</td><td align="right" bgcolor="#FFFFFF">6,051 μs</td><td align="right" bgcolor="#FFFFFF">13,151 μs</td><td align="right" bgcolor="#FFFFFF">13,170 μs</td><td align="right" bgcolor="#FFFFFF">7,556 μs</td><td align="right" bgcolor="#FFFFFF">5,647 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FF4949">5,000 (Δ = +1,000)</td><td align="right" bgcolor="#FF4949">6,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#A8D08D">5,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,0 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">2051,000</td><td align="right" bgcolor="#FF4949">2133,000 (Δ = +82,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2133,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">2183,000 (Δ = +2183,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,003</td><td align="right" bgcolor="#FF4949">2,083 (Δ = +0,080)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -2,083)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">2,132 (Δ = +2,132)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,002)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 462,516 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+44,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">944,911 ns</td><td align="right" bgcolor="#FFFFFF">931,912 ns</td><td align="right" bgcolor="#FF4949">1342,451 ns (Δ = +410,539 ns)</td><td align="right" bgcolor="#FFFFFF">1348,631 ns</td><td align="right" bgcolor="#FFFFFF">1394,428 ns</td><td align="right" bgcolor="#A8D08D">995,904 ns (Δ = -398,524 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,945 μs</td><td align="right" bgcolor="#FFFFFF">0,932 μs</td><td align="right" bgcolor="#FFFFFF">1,342 μs</td><td align="right" bgcolor="#FFFFFF">1,349 μs</td><td align="right" bgcolor="#FFFFFF">1,394 μs</td><td align="right" bgcolor="#FFFFFF">0,996 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -7,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">8,000 (Δ = +8,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,007)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,008 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 7378,289 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+122,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,1 %</td><td align="right" bgcolor="#A8D08D">-26,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5716,945 ns</td><td align="right" bgcolor="#FFFFFF">5635,905 ns</td><td align="right" bgcolor="#FF4949">12516,457 ns (Δ = +6880,553 ns)</td><td align="right" bgcolor="#FFFFFF">12425,336 ns</td><td align="right" bgcolor="#A8D08D">6951,099 ns (Δ = -5474,237 ns)</td><td align="right" bgcolor="#A8D08D">5138,168 ns (Δ = -1812,931 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,717 μs</td><td align="right" bgcolor="#FFFFFF">5,636 μs</td><td align="right" bgcolor="#FFFFFF">12,516 μs</td><td align="right" bgcolor="#FFFFFF">12,425 μs</td><td align="right" bgcolor="#FFFFFF">6,951 μs</td><td align="right" bgcolor="#FFFFFF">5,138 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,013 ms</td><td align="right" bgcolor="#FFFFFF">0,012 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#FF4949">10,000 (Δ = +2,000)</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FF4949">11,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">8,000 (Δ = -3,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,2 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3468,000</td><td align="right" bgcolor="#FF4949">3580,000 (Δ = +112,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -3580,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">3732,000 (Δ = +3732,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,387</td><td align="right" bgcolor="#FF4949">3,496 (Δ = +0,109)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -3,496)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">3,645 (Δ = +3,645)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,003)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,004 (Δ = +0,004)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 407,299 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+38,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-29,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">953,464 ns</td><td align="right" bgcolor="#FFFFFF">958,563 ns</td><td align="right" bgcolor="#FF4949">1328,156 ns (Δ = +369,593 ns)</td><td align="right" bgcolor="#FFFFFF">1308,092 ns</td><td align="right" bgcolor="#FFFFFF">1360,763 ns</td><td align="right" bgcolor="#A8D08D">954,820 ns (Δ = -405,943 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,953 μs</td><td align="right" bgcolor="#FFFFFF">0,959 μs</td><td align="right" bgcolor="#FFFFFF">1,328 μs</td><td align="right" bgcolor="#FFFFFF">1,308 μs</td><td align="right" bgcolor="#FFFFFF">1,361 μs</td><td align="right" bgcolor="#FFFFFF">0,955 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -7,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">8,000 (Δ = +8,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,007)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,008 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 381,848 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+52,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">731,676 ns</td><td align="right" bgcolor="#FFFFFF">642,683 ns</td><td align="right" bgcolor="#FF4949">978,796 ns (Δ = +336,113 ns)</td><td align="right" bgcolor="#FFFFFF">1015,813 ns</td><td align="right" bgcolor="#FFFFFF">956,178 ns</td><td align="right" bgcolor="#A8D08D">633,966 ns (Δ = -322,212 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,732 μs</td><td align="right" bgcolor="#FFFFFF">0,643 μs</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">1,016 μs</td><td align="right" bgcolor="#FFFFFF">0,956 μs</td><td align="right" bgcolor="#FFFFFF">0,634 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">265,000</td><td align="right" bgcolor="#FFFFFF">265,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -265,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">274,000 (Δ = +274,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,259</td><td align="right" bgcolor="#FFFFFF">0,259</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,259)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,268 (Δ = +0,268)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.9.0**

Slowest: 5.5.0

Δ: 2685,630 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+69,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-60,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2665,401 ns</td><td align="right" bgcolor="#FFFFFF">2617,671 ns</td><td align="right" bgcolor="#FF4949">4429,905 ns (Δ = +1812,233 ns)</td><td align="right" bgcolor="#FFFFFF">4403,808 ns</td><td align="right" bgcolor="#A8D08D">1744,275 ns (Δ = -2659,533 ns)</td><td align="right" bgcolor="#FFFFFF">1831,194 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,665 μs</td><td align="right" bgcolor="#FFFFFF">2,618 μs</td><td align="right" bgcolor="#FFFFFF">4,430 μs</td><td align="right" bgcolor="#FFFFFF">4,404 μs</td><td align="right" bgcolor="#FFFFFF">1,744 μs</td><td align="right" bgcolor="#FFFFFF">1,831 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">539,000</td><td align="right" bgcolor="#FFFFFF">539,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -539,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">539,000 (Δ = +539,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,526</td><td align="right" bgcolor="#FFFFFF">0,526</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,526)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,526 (Δ = +0,526)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 2804,377 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+93,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-73,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2121,264 ns</td><td align="right" bgcolor="#FFFFFF">1958,191 ns</td><td align="right" bgcolor="#FF4949">3781,060 ns (Δ = +1822,869 ns)</td><td align="right" bgcolor="#FFFFFF">3804,413 ns</td><td align="right" bgcolor="#A8D08D">1000,036 ns (Δ = -2804,377 ns)</td><td align="right" bgcolor="#FFFFFF">1238,844 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,121 μs</td><td align="right" bgcolor="#FFFFFF">1,958 μs</td><td align="right" bgcolor="#FFFFFF">3,781 μs</td><td align="right" bgcolor="#FFFFFF">3,804 μs</td><td align="right" bgcolor="#FFFFFF">1,000 μs</td><td align="right" bgcolor="#FFFFFF">1,239 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">551,000</td><td align="right" bgcolor="#FFFFFF">551,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -551,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">551,000 (Δ = +551,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,538</td><td align="right" bgcolor="#FFFFFF">0,538</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,538)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,538 (Δ = +0,538)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 87,881 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">116,100 ns</td><td align="right" bgcolor="#FFFFFF">112,398 ns</td><td align="right" bgcolor="#FFFFFF">194,649 ns</td><td align="right" bgcolor="#FFFFFF">196,560 ns</td><td align="right" bgcolor="#FFFFFF">199,518 ns</td><td align="right" bgcolor="#FFFFFF">111,637 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,116 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td><td align="right" bgcolor="#FFFFFF">0,200 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">5,000 (Δ = +5,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,005</td><td align="right" bgcolor="#FFFFFF">0,005</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,005)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,005 (Δ = +0,005)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 398,400 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+40,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">651,360 ns</td><td align="right" bgcolor="#FFFFFF">647,921 ns</td><td align="right" bgcolor="#FF4949">910,589 ns (Δ = +262,668 ns)</td><td align="right" bgcolor="#FFFFFF">951,848 ns</td><td align="right" bgcolor="#FFFFFF">924,732 ns</td><td align="right" bgcolor="#A8D08D">553,448 ns (Δ = -371,284 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,651 μs</td><td align="right" bgcolor="#FFFFFF">0,648 μs</td><td align="right" bgcolor="#FFFFFF">0,911 μs</td><td align="right" bgcolor="#FFFFFF">0,952 μs</td><td align="right" bgcolor="#FFFFFF">0,925 μs</td><td align="right" bgcolor="#FFFFFF">0,553 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -242,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">265,000 (Δ = +265,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,236)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,259 (Δ = +0,259)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance"></a>GetPropertyEx_Instance

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 56,986 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">126,265 ns</td><td align="right" bgcolor="#FFFFFF">120,645 ns</td><td align="right" bgcolor="#FFFFFF">169,192 ns</td><td align="right" bgcolor="#FFFFFF">171,735 ns</td><td align="right" bgcolor="#FFFFFF">150,273 ns</td><td align="right" bgcolor="#FFFFFF">114,749 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,169 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,150 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">25,000 (Δ = +25,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,024 (Δ = +0,024)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 1009,232 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+40,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2420,073 ns</td><td align="right" bgcolor="#FFFFFF">2332,090 ns</td><td align="right" bgcolor="#FF4949">3280,567 ns (Δ = +948,477 ns)</td><td align="right" bgcolor="#FFFFFF">3341,322 ns</td><td align="right" bgcolor="#FFFFFF">3173,686 ns</td><td align="right" bgcolor="#A8D08D">2868,843 ns (Δ = -304,843 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,420 μs</td><td align="right" bgcolor="#FFFFFF">2,332 μs</td><td align="right" bgcolor="#FFFFFF">3,281 μs</td><td align="right" bgcolor="#FFFFFF">3,341 μs</td><td align="right" bgcolor="#FFFFFF">3,174 μs</td><td align="right" bgcolor="#FFFFFF">2,869 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">195,000</td><td align="right" bgcolor="#FFFFFF">195,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -195,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">760,000 (Δ = +760,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,190)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,742 (Δ = +0,742)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 134,549 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">196,976 ns</td><td align="right" bgcolor="#FFFFFF">166,204 ns</td><td align="right" bgcolor="#FFFFFF">273,635 ns</td><td align="right" bgcolor="#FFFFFF">271,314 ns</td><td align="right" bgcolor="#FFFFFF">291,070 ns</td><td align="right" bgcolor="#FFFFFF">156,521 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#FFFFFF">0,274 μs</td><td align="right" bgcolor="#FFFFFF">0,271 μs</td><td align="right" bgcolor="#FFFFFF">0,291 μs</td><td align="right" bgcolor="#FFFFFF">0,157 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#FFFFFF">321,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -321,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">321,000 (Δ = +321,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#FFFFFF">0,313</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,313 (Δ = +0,313)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetTypeInfo"></a>GetTypeInfo

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 6,998 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,616 ns</td><td align="right" bgcolor="#FFFFFF">10,016 ns</td><td align="right" bgcolor="#FFFFFF">16,011 ns</td><td align="right" bgcolor="#FFFFFF">16,260 ns</td><td align="right" bgcolor="#FFFFFF">16,103 ns</td><td align="right" bgcolor="#FFFFFF">9,262 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_HasBaseTypeEx"></a>HasBaseTypeEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 23,711 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">31,095 ns</td><td align="right" bgcolor="#FFFFFF">30,046 ns</td><td align="right" bgcolor="#FFFFFF">47,051 ns</td><td align="right" bgcolor="#FFFFFF">48,987 ns</td><td align="right" bgcolor="#FFFFFF">52,380 ns</td><td align="right" bgcolor="#FFFFFF">28,670 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx"></a>ImplementsInterfaceEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 29,147 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">32,828 ns</td><td align="right" bgcolor="#FFFFFF">32,240 ns</td><td align="right" bgcolor="#FFFFFF">53,008 ns</td><td align="right" bgcolor="#FFFFFF">53,084 ns</td><td align="right" bgcolor="#FFFFFF">58,989 ns</td><td align="right" bgcolor="#FFFFFF">29,842 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx"></a>ImplementsInterfacesEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 29,186 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,841 ns</td><td align="right" bgcolor="#FFFFFF">28,412 ns</td><td align="right" bgcolor="#FFFFFF">47,016 ns</td><td align="right" bgcolor="#FFFFFF">51,218 ns</td><td align="right" bgcolor="#FFFFFF">54,295 ns</td><td align="right" bgcolor="#FFFFFF">25,109 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAbstractEx"></a>IsAbstractEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 12,433 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,532 ns</td><td align="right" bgcolor="#FFFFFF">12,650 ns</td><td align="right" bgcolor="#FFFFFF">24,965 ns</td><td align="right" bgcolor="#FFFFFF">24,861 ns</td><td align="right" bgcolor="#FFFFFF">24,689 ns</td><td align="right" bgcolor="#FFFFFF">12,988 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsArrayEx"></a>IsArrayEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 18,337 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,120 ns</td><td align="right" bgcolor="#FFFFFF">17,712 ns</td><td align="right" bgcolor="#FFFFFF">32,497 ns</td><td align="right" bgcolor="#FFFFFF">32,893 ns</td><td align="right" bgcolor="#FFFFFF">32,661 ns</td><td align="right" bgcolor="#FFFFFF">14,557 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAssignableFromEx"></a>IsAssignableFromEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 16,264 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,580 ns</td><td align="right" bgcolor="#FFFFFF">22,558 ns</td><td align="right" bgcolor="#FFFFFF">36,989 ns</td><td align="right" bgcolor="#FFFFFF">38,821 ns</td><td align="right" bgcolor="#FFFFFF">38,369 ns</td><td align="right" bgcolor="#FFFFFF">22,745 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 342,879 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">573,143 ns</td><td align="right" bgcolor="#FFFFFF">429,110 ns</td><td align="right" bgcolor="#FFFFFF">617,571 ns</td><td align="right" bgcolor="#FFFFFF">642,495 ns</td><td align="right" bgcolor="#FFFFFF">618,381 ns</td><td align="right" bgcolor="#A8D08D">299,615 ns (Δ = -318,766 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,573 μs</td><td align="right" bgcolor="#FFFFFF">0,429 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,642 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,300 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsClassEx"></a>IsClassEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 76,194 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">162,724 ns</td><td align="right" bgcolor="#FFFFFF">147,182 ns</td><td align="right" bgcolor="#FFFFFF">221,333 ns</td><td align="right" bgcolor="#FFFFFF">223,376 ns</td><td align="right" bgcolor="#FFFFFF">212,179 ns</td><td align="right" bgcolor="#FFFFFF">151,749 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,212 μs</td><td align="right" bgcolor="#FFFFFF">0,152 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCOMObjectEx"></a>IsCOMObjectEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 19,462 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,252 ns</td><td align="right" bgcolor="#FFFFFF">19,574 ns</td><td align="right" bgcolor="#FFFFFF">38,939 ns</td><td align="right" bgcolor="#FFFFFF">39,036 ns</td><td align="right" bgcolor="#FFFFFF">37,936 ns</td><td align="right" bgcolor="#FFFFFF">20,013 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsEnumEx"></a>IsEnumEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 14,797 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30,021 ns</td><td align="right" bgcolor="#FFFFFF">28,615 ns</td><td align="right" bgcolor="#FFFFFF">40,544 ns</td><td align="right" bgcolor="#FFFFFF">41,298 ns</td><td align="right" bgcolor="#FFFFFF">40,505 ns</td><td align="right" bgcolor="#FFFFFF">26,501 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 3,857 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,113 ns</td><td align="right" bgcolor="#FFFFFF">8,036 ns</td><td align="right" bgcolor="#FFFFFF">10,844 ns</td><td align="right" bgcolor="#FFFFFF">11,236 ns</td><td align="right" bgcolor="#FFFFFF">11,338 ns</td><td align="right" bgcolor="#FFFFFF">7,481 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeEx"></a>IsGenericTypeEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 6,334 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,405 ns</td><td align="right" bgcolor="#FFFFFF">8,035 ns</td><td align="right" bgcolor="#FFFFFF">12,158 ns</td><td align="right" bgcolor="#FFFFFF">12,108 ns</td><td align="right" bgcolor="#FFFFFF">12,401 ns</td><td align="right" bgcolor="#FFFFFF">6,067 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx"></a>IsInstanceOfTypeEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 16938,383 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,3 %</td><td align="right" bgcolor="#FF4949">+77,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,8 %</td><td align="right" bgcolor="#A8D08D">-37,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18811,785 ns</td><td align="right" bgcolor="#A8D08D">18371,539 ns (Δ = -440,245 ns)</td><td align="right" bgcolor="#FF4949">32572,844 ns (Δ = +14201,305 ns)</td><td align="right" bgcolor="#FFFFFF">32746,315 ns</td><td align="right" bgcolor="#FF4949">35309,923 ns (Δ = +2563,608 ns)</td><td align="right" bgcolor="#A8D08D">21935,876 ns (Δ = -13374,047 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">18,812 μs</td><td align="right" bgcolor="#FFFFFF">18,372 μs</td><td align="right" bgcolor="#FFFFFF">32,573 μs</td><td align="right" bgcolor="#FFFFFF">32,746 μs</td><td align="right" bgcolor="#FFFFFF">35,310 μs</td><td align="right" bgcolor="#FFFFFF">21,936 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td><td align="right" bgcolor="#FFFFFF">0,035 ms</td><td align="right" bgcolor="#FFFFFF">0,022 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FF4949">6,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,8 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">5802,000</td><td align="right" bgcolor="#FF4949">6138,000 (Δ = +336,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -6138,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">6853,000 (Δ = +6853,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">5,666</td><td align="right" bgcolor="#FF4949">5,994 (Δ = +0,328)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,994)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">6,692 (Δ = +6,692)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,006</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,006)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,007 (Δ = +0,007)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 5,220 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,401 ns</td><td align="right" bgcolor="#FFFFFF">9,703 ns</td><td align="right" bgcolor="#FFFFFF">13,502 ns</td><td align="right" bgcolor="#FFFFFF">13,621 ns</td><td align="right" bgcolor="#FFFFFF">13,287 ns</td><td align="right" bgcolor="#FFFFFF">9,576 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsNestedPublicEx"></a>IsNestedPublicEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 15,909 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,173 ns</td><td align="right" bgcolor="#FFFFFF">12,398 ns</td><td align="right" bgcolor="#FFFFFF">22,587 ns</td><td align="right" bgcolor="#FFFFFF">27,082 ns</td><td align="right" bgcolor="#FFFFFF">25,491 ns</td><td align="right" bgcolor="#FFFFFF">11,173 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPrimitiveEx"></a>IsPrimitiveEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 6,395 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,123 ns</td><td align="right" bgcolor="#FFFFFF">12,760 ns</td><td align="right" bgcolor="#FFFFFF">18,112 ns</td><td align="right" bgcolor="#FFFFFF">18,518 ns</td><td align="right" bgcolor="#FFFFFF">18,113 ns</td><td align="right" bgcolor="#FFFFFF">12,653 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPublicEx"></a>IsPublicEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 13,666 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">12,650 ns</td><td align="right" bgcolor="#FFFFFF">12,282 ns</td><td align="right" bgcolor="#FFFFFF">22,523 ns</td><td align="right" bgcolor="#FFFFFF">25,914 ns</td><td align="right" bgcolor="#FFFFFF">25,948 ns</td><td align="right" bgcolor="#FFFFFF">12,599 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsSerializableEx"></a>IsSerializableEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 16,424 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,447 ns</td><td align="right" bgcolor="#FFFFFF">13,153 ns</td><td align="right" bgcolor="#FFFFFF">25,107 ns</td><td align="right" bgcolor="#FFFFFF">28,722 ns</td><td align="right" bgcolor="#FFFFFF">27,134 ns</td><td align="right" bgcolor="#FFFFFF">12,298 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsValueTypeEx"></a>IsValueTypeEx

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 20,664 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">33,370 ns</td><td align="right" bgcolor="#FFFFFF">33,002 ns</td><td align="right" bgcolor="#FFFFFF">51,670 ns</td><td align="right" bgcolor="#FFFFFF">49,865 ns</td><td align="right" bgcolor="#FFFFFF">50,307 ns</td><td align="right" bgcolor="#FFFFFF">31,006 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,052 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="TypeExtensions_Benchmark"></a>TypeExtensions_Benchmark

### <a name="TypeExtensions_Benchmark_GetCollectionElementType"></a>GetCollectionElementType

#### Performance

Fastest: **5.12.0**

Slowest: 5.0.0

Δ: 557,298 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-67,4 %</td><td align="right" bgcolor="#FF4949">+129,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">825,232 ns</td><td align="right" bgcolor="#A8D08D">269,293 ns (Δ = -555,939 ns)</td><td align="right" bgcolor="#FF4949">619,041 ns (Δ = +349,748 ns)</td><td align="right" bgcolor="#FFFFFF">526,756 ns</td><td align="right" bgcolor="#FFFFFF">540,558 ns</td><td align="right" bgcolor="#A8D08D">267,934 ns (Δ = -272,625 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,825 μs</td><td align="right" bgcolor="#FFFFFF">0,269 μs</td><td align="right" bgcolor="#FFFFFF">0,619 μs</td><td align="right" bgcolor="#FFFFFF">0,527 μs</td><td align="right" bgcolor="#FFFFFF">0,541 μs</td><td align="right" bgcolor="#FFFFFF">0,268 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-81,4 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#A8D08D">33,000 (Δ = -144,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -33,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +33,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#A8D08D">0,032 (Δ = -0,141)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsBasicType"></a>IsBasicType

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 20,586 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17,047 ns</td><td align="right" bgcolor="#FFFFFF">17,671 ns</td><td align="right" bgcolor="#FFFFFF">24,008 ns</td><td align="right" bgcolor="#FFFFFF">37,634 ns</td><td align="right" bgcolor="#FFFFFF">23,365 ns</td><td align="right" bgcolor="#FFFFFF">17,493 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsClassType"></a>IsClassType

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 153,713 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">216,571 ns</td><td align="right" bgcolor="#FFFFFF">200,927 ns</td><td align="right" bgcolor="#FFFFFF">350,969 ns</td><td align="right" bgcolor="#FFFFFF">330,394 ns</td><td align="right" bgcolor="#FFFFFF">354,641 ns</td><td align="right" bgcolor="#FFFFFF">214,628 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,217 μs</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FFFFFF">0,351 μs</td><td align="right" bgcolor="#FFFFFF">0,330 μs</td><td align="right" bgcolor="#FFFFFF">0,355 μs</td><td align="right" bgcolor="#FFFFFF">0,215 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsCollection"></a>IsCollection

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 17,440 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30,914 ns</td><td align="right" bgcolor="#FFFFFF">30,837 ns</td><td align="right" bgcolor="#FFFFFF">45,741 ns</td><td align="right" bgcolor="#FFFFFF">45,313 ns</td><td align="right" bgcolor="#FFFFFF">45,364 ns</td><td align="right" bgcolor="#FFFFFF">28,301 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsDictionary"></a>IsDictionary

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 50,418 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">127,521 ns</td><td align="right" bgcolor="#FFFFFF">96,367 ns</td><td align="right" bgcolor="#FFFFFF">145,505 ns</td><td align="right" bgcolor="#FFFFFF">146,785 ns</td><td align="right" bgcolor="#FFFFFF">146,010 ns</td><td align="right" bgcolor="#FFFFFF">101,284 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsModelBase"></a>IsModelBase

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 19,926 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">34,881 ns</td><td align="right" bgcolor="#FFFFFF">26,136 ns</td><td align="right" bgcolor="#FFFFFF">38,328 ns</td><td align="right" bgcolor="#FFFFFF">45,458 ns</td><td align="right" bgcolor="#FFFFFF">42,099 ns</td><td align="right" bgcolor="#FFFFFF">25,532 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsNullableType"></a>IsNullableType

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 262,245 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+91,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">291,942 ns</td><td align="right" bgcolor="#FFFFFF">285,899 ns</td><td align="right" bgcolor="#FF4949">548,144 ns (Δ = +262,245 ns)</td><td align="right" bgcolor="#FFFFFF">547,669 ns</td><td align="right" bgcolor="#FFFFFF">542,538 ns</td><td align="right" bgcolor="#A8D08D">291,571 ns (Δ = -250,967 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,548 μs</td><td align="right" bgcolor="#FFFFFF">0,548 μs</td><td align="right" bgcolor="#FFFFFF">0,543 μs</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -33,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +33,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="TypeFactory_Benchmark"></a>TypeFactory_Benchmark

### <a name="TypeFactory_Benchmark_CreateInstance"></a>CreateInstance

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 2684,908 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+126,8 %</td><td align="right" bgcolor="#A8D08D">-13,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-54,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1979,314 ns</td><td align="right" bgcolor="#FFFFFF">2032,635 ns</td><td align="right" bgcolor="#FF4949">4610,724 ns (Δ = +2578,089 ns)</td><td align="right" bgcolor="#A8D08D">3991,669 ns (Δ = -619,055 ns)</td><td align="right" bgcolor="#FFFFFF">4225,043 ns</td><td align="right" bgcolor="#A8D08D">1925,816 ns (Δ = -2299,227 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,979 μs</td><td align="right" bgcolor="#FFFFFF">2,033 μs</td><td align="right" bgcolor="#FFFFFF">4,611 μs</td><td align="right" bgcolor="#FFFFFF">3,992 μs</td><td align="right" bgcolor="#FFFFFF">4,225 μs</td><td align="right" bgcolor="#FFFFFF">1,926 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1060,000</td><td align="right" bgcolor="#A8D08D">1045,000 (Δ = -15,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1045,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1316,000 (Δ = +1316,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,035</td><td align="right" bgcolor="#A8D08D">1,021 (Δ = -0,015)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,021)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,285 (Δ = +1,285)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 2162,313 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+106,0 %</td><td align="right" bgcolor="#A8D08D">-6,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1948,169 ns</td><td align="right" bgcolor="#FFFFFF">1995,353 ns</td><td align="right" bgcolor="#FF4949">4110,482 ns (Δ = +2115,129 ns)</td><td align="right" bgcolor="#A8D08D">3835,968 ns (Δ = -274,514 ns)</td><td align="right" bgcolor="#FFFFFF">4007,763 ns</td><td align="right" bgcolor="#A8D08D">2096,566 ns (Δ = -1911,197 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,948 μs</td><td align="right" bgcolor="#FFFFFF">1,995 μs</td><td align="right" bgcolor="#FFFFFF">4,110 μs</td><td align="right" bgcolor="#FFFFFF">3,836 μs</td><td align="right" bgcolor="#FFFFFF">4,008 μs</td><td align="right" bgcolor="#FFFFFF">2,097 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,3 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1060,000</td><td align="right" bgcolor="#A8D08D">1046,000 (Δ = -14,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1046,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1308,000 (Δ = +1308,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,035</td><td align="right" bgcolor="#A8D08D">1,021 (Δ = -0,014)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,021)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,277 (Δ = +1,277)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 2260,754 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+81,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2641,850 ns</td><td align="right" bgcolor="#FFFFFF">2593,848 ns</td><td align="right" bgcolor="#FF4949">4715,710 ns (Δ = +2121,862 ns)</td><td align="right" bgcolor="#FFFFFF">4614,100 ns</td><td align="right" bgcolor="#FFFFFF">4508,847 ns</td><td align="right" bgcolor="#A8D08D">2454,955 ns (Δ = -2053,892 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,642 μs</td><td align="right" bgcolor="#FFFFFF">2,594 μs</td><td align="right" bgcolor="#FFFFFF">4,716 μs</td><td align="right" bgcolor="#FFFFFF">4,614 μs</td><td align="right" bgcolor="#FFFFFF">4,509 μs</td><td align="right" bgcolor="#FFFFFF">2,455 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,5 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1484,000</td><td align="right" bgcolor="#FF4949">1492,000 (Δ = +8,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1492,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1773,000 (Δ = +1773,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,449</td><td align="right" bgcolor="#FF4949">1,457 (Δ = +0,008)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,457)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,731 (Δ = +1,731)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,002)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 2603,353 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,7 %</td><td align="right" bgcolor="#FF4949">+93,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3327,290 ns</td><td align="right" bgcolor="#A8D08D">2771,139 ns (Δ = -556,151 ns)</td><td align="right" bgcolor="#FF4949">5374,492 ns (Δ = +2603,353 ns)</td><td align="right" bgcolor="#FFFFFF">5342,681 ns</td><td align="right" bgcolor="#FFFFFF">5295,949 ns</td><td align="right" bgcolor="#A8D08D">2838,849 ns (Δ = -2457,100 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,327 μs</td><td align="right" bgcolor="#FFFFFF">2,771 μs</td><td align="right" bgcolor="#FFFFFF">5,374 μs</td><td align="right" bgcolor="#FFFFFF">5,343 μs</td><td align="right" bgcolor="#FFFFFF">5,296 μs</td><td align="right" bgcolor="#FFFFFF">2,839 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FF4949">5,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#A8D08D">4,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,5 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1693,000</td><td align="right" bgcolor="#FF4949">1701,000 (Δ = +8,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1701,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1981,000 (Δ = +1981,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,653</td><td align="right" bgcolor="#FF4949">1,661 (Δ = +0,008)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,661)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,935 (Δ = +1,935)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,002)</td></tr></table>


## <a name="UniqueIdentifierHelper_Benchmark"></a>UniqueIdentifierHelper_Benchmark

### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier"></a>GetUniqueIdentifier

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 73,289 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">84,999 ns</td><td align="right" bgcolor="#FFFFFF">93,721 ns</td><td align="right" bgcolor="#FFFFFF">143,633 ns</td><td align="right" bgcolor="#FFFFFF">96,359 ns</td><td align="right" bgcolor="#FFFFFF">96,178 ns</td><td align="right" bgcolor="#FFFFFF">70,345 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier_Generic"></a>GetUniqueIdentifier_Generic

#### Performance

Fastest: **5.12.0**

Slowest: 5.5.0

Δ: 79,327 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">92,809 ns</td><td align="right" bgcolor="#FFFFFF">93,117 ns</td><td align="right" bgcolor="#FFFFFF">144,032 ns</td><td align="right" bgcolor="#FFFFFF">97,449 ns</td><td align="right" bgcolor="#FFFFFF">97,886 ns</td><td align="right" bgcolor="#FFFFFF">64,705 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ValidatableModelBase_Constructor_Benchmark"></a>ValidatableModelBase_Constructor_Benchmark

### <a name="ValidatableModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 1244,191 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FF4949">+36,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3712,295 ns</td><td align="right" bgcolor="#A8D08D">2915,433 ns (Δ = -796,862 ns)</td><td align="right" bgcolor="#FF4949">3987,358 ns (Δ = +1071,924 ns)</td><td align="right" bgcolor="#FFFFFF">4012,801 ns</td><td align="right" bgcolor="#FFFFFF">3850,276 ns</td><td align="right" bgcolor="#A8D08D">2768,610 ns (Δ = -1081,666 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,712 μs</td><td align="right" bgcolor="#FFFFFF">2,915 μs</td><td align="right" bgcolor="#FFFFFF">3,987 μs</td><td align="right" bgcolor="#FFFFFF">4,013 μs</td><td align="right" bgcolor="#FFFFFF">3,850 μs</td><td align="right" bgcolor="#FFFFFF">2,769 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +2,000)</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">972,000</td><td align="right" bgcolor="#FFFFFF">972,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -972,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">932,000 (Δ = +932,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,949</td><td align="right" bgcolor="#FFFFFF">0,949</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,949)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,910 (Δ = +0,910)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="ValidationContext_Benchmark"></a>ValidationContext_Benchmark

### <a name="ValidationContext_Benchmark_GetBusinessRuleErrorCount"></a>GetBusinessRuleErrorCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 113,543 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">182,100 ns</td><td align="right" bgcolor="#FFFFFF">180,879 ns</td><td align="right" bgcolor="#FFFFFF">286,897 ns</td><td align="right" bgcolor="#FFFFFF">294,422 ns</td><td align="right" bgcolor="#FFFFFF">277,207 ns</td><td align="right" bgcolor="#FFFFFF">264,487 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,182 μs</td><td align="right" bgcolor="#FFFFFF">0,181 μs</td><td align="right" bgcolor="#FFFFFF">0,287 μs</td><td align="right" bgcolor="#FFFFFF">0,294 μs</td><td align="right" bgcolor="#FFFFFF">0,277 μs</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -169,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">169,000 (Δ = +169,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,165)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,165 (Δ = +0,165)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleErrors"></a>GetBusinessRuleErrors

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 119,167 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">180,624 ns</td><td align="right" bgcolor="#FFFFFF">174,076 ns</td><td align="right" bgcolor="#FFFFFF">285,476 ns</td><td align="right" bgcolor="#FFFFFF">293,243 ns</td><td align="right" bgcolor="#FFFFFF">283,311 ns</td><td align="right" bgcolor="#FFFFFF">184,044 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,181 μs</td><td align="right" bgcolor="#FFFFFF">0,174 μs</td><td align="right" bgcolor="#FFFFFF">0,285 μs</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,283 μs</td><td align="right" bgcolor="#FFFFFF">0,184 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -169,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">169,000 (Δ = +169,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,165)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,165 (Δ = +0,165)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleValidations"></a>GetBusinessRuleValidations

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 157,164 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">194,745 ns</td><td align="right" bgcolor="#FFFFFF">184,556 ns</td><td align="right" bgcolor="#FFFFFF">341,720 ns</td><td align="right" bgcolor="#FFFFFF">341,492 ns</td><td align="right" bgcolor="#FFFFFF">315,192 ns</td><td align="right" bgcolor="#FFFFFF">193,971 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,185 μs</td><td align="right" bgcolor="#FFFFFF">0,342 μs</td><td align="right" bgcolor="#FFFFFF">0,341 μs</td><td align="right" bgcolor="#FFFFFF">0,315 μs</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -177,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">177,000 (Δ = +177,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,173)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,173 (Δ = +0,173)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarningCount"></a>GetBusinessRuleWarningCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 123,931 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">180,802 ns</td><td align="right" bgcolor="#FFFFFF">171,341 ns</td><td align="right" bgcolor="#FFFFFF">290,015 ns</td><td align="right" bgcolor="#FFFFFF">295,272 ns</td><td align="right" bgcolor="#FFFFFF">273,100 ns</td><td align="right" bgcolor="#FFFFFF">187,707 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,181 μs</td><td align="right" bgcolor="#FFFFFF">0,171 μs</td><td align="right" bgcolor="#FFFFFF">0,290 μs</td><td align="right" bgcolor="#FFFFFF">0,295 μs</td><td align="right" bgcolor="#FFFFFF">0,273 μs</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -169,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">169,000 (Δ = +169,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,165)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,165 (Δ = +0,165)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarnings"></a>GetBusinessRuleWarnings

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 130,096 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">193,753 ns</td><td align="right" bgcolor="#FFFFFF">168,673 ns</td><td align="right" bgcolor="#FFFFFF">298,769 ns</td><td align="right" bgcolor="#FFFFFF">281,726 ns</td><td align="right" bgcolor="#FFFFFF">279,376 ns</td><td align="right" bgcolor="#FFFFFF">180,876 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,169 μs</td><td align="right" bgcolor="#FFFFFF">0,299 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td><td align="right" bgcolor="#FFFFFF">0,181 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -169,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">169,000 (Δ = +169,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,165)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,165 (Δ = +0,165)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrorCount"></a>GetErrorCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 782,398 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+82,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">929,355 ns</td><td align="right" bgcolor="#FFFFFF">872,549 ns</td><td align="right" bgcolor="#FF4949">1589,591 ns (Δ = +717,041 ns)</td><td align="right" bgcolor="#FFFFFF">1463,309 ns</td><td align="right" bgcolor="#FFFFFF">1654,947 ns</td><td align="right" bgcolor="#A8D08D">938,389 ns (Δ = -716,558 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,929 μs</td><td align="right" bgcolor="#FFFFFF">0,873 μs</td><td align="right" bgcolor="#FFFFFF">1,590 μs</td><td align="right" bgcolor="#FFFFFF">1,463 μs</td><td align="right" bgcolor="#FFFFFF">1,655 μs</td><td align="right" bgcolor="#FFFFFF">0,938 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -514,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">514,000 (Δ = +514,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,502)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,502 (Δ = +0,502)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrors"></a>GetErrors

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 775,498 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+74,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1123,015 ns</td><td align="right" bgcolor="#FFFFFF">912,439 ns</td><td align="right" bgcolor="#FF4949">1594,682 ns (Δ = +682,244 ns)</td><td align="right" bgcolor="#FFFFFF">1595,271 ns</td><td align="right" bgcolor="#FFFFFF">1687,937 ns</td><td align="right" bgcolor="#A8D08D">940,242 ns (Δ = -747,695 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,123 μs</td><td align="right" bgcolor="#FFFFFF">0,912 μs</td><td align="right" bgcolor="#FFFFFF">1,595 μs</td><td align="right" bgcolor="#FFFFFF">1,595 μs</td><td align="right" bgcolor="#FFFFFF">1,688 μs</td><td align="right" bgcolor="#FFFFFF">0,940 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -514,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">514,000 (Δ = +514,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,502)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,502 (Δ = +0,502)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrorCount"></a>GetFieldErrorCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 154,492 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">221,426 ns</td><td align="right" bgcolor="#FFFFFF">214,137 ns</td><td align="right" bgcolor="#FFFFFF">359,979 ns</td><td align="right" bgcolor="#FFFFFF">368,629 ns</td><td align="right" bgcolor="#FFFFFF">349,781 ns</td><td align="right" bgcolor="#FFFFFF">280,124 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,360 μs</td><td align="right" bgcolor="#FFFFFF">0,369 μs</td><td align="right" bgcolor="#FFFFFF">0,350 μs</td><td align="right" bgcolor="#FFFFFF">0,280 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -169,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">169,000 (Δ = +169,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,165)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,165 (Δ = +0,165)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrors"></a>GetFieldErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 151,315 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">209,553 ns</td><td align="right" bgcolor="#FFFFFF">216,205 ns</td><td align="right" bgcolor="#FFFFFF">354,195 ns</td><td align="right" bgcolor="#FFFFFF">360,867 ns</td><td align="right" bgcolor="#FFFFFF">335,859 ns</td><td align="right" bgcolor="#FFFFFF">226,720 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td><td align="right" bgcolor="#FFFFFF">0,216 μs</td><td align="right" bgcolor="#FFFFFF">0,354 μs</td><td align="right" bgcolor="#FFFFFF">0,361 μs</td><td align="right" bgcolor="#FFFFFF">0,336 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -169,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">169,000 (Δ = +169,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,165)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,165 (Δ = +0,165)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldValidations"></a>GetFieldValidations

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 186,327 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">222,147 ns</td><td align="right" bgcolor="#FFFFFF">224,928 ns</td><td align="right" bgcolor="#FFFFFF">408,474 ns</td><td align="right" bgcolor="#FFFFFF">367,479 ns</td><td align="right" bgcolor="#FFFFFF">362,813 ns</td><td align="right" bgcolor="#FFFFFF">239,796 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,222 μs</td><td align="right" bgcolor="#FFFFFF">0,225 μs</td><td align="right" bgcolor="#FFFFFF">0,408 μs</td><td align="right" bgcolor="#FFFFFF">0,367 μs</td><td align="right" bgcolor="#FFFFFF">0,363 μs</td><td align="right" bgcolor="#FFFFFF">0,240 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#FFFFFF">177,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -177,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">177,000 (Δ = +177,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#FFFFFF">0,173</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,173)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,173 (Δ = +0,173)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarningCount"></a>GetFieldWarningCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.5.0

Δ: 145,751 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">260,042 ns</td><td align="right" bgcolor="#FFFFFF">189,819 ns</td><td align="right" bgcolor="#FFFFFF">335,569 ns</td><td align="right" bgcolor="#FFFFFF">312,208 ns</td><td align="right" bgcolor="#FFFFFF">296,457 ns</td><td align="right" bgcolor="#FFFFFF">197,040 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,260 μs</td><td align="right" bgcolor="#FFFFFF">0,190 μs</td><td align="right" bgcolor="#FFFFFF">0,336 μs</td><td align="right" bgcolor="#FFFFFF">0,312 μs</td><td align="right" bgcolor="#FFFFFF">0,296 μs</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -169,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">169,000 (Δ = +169,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,165)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,165 (Δ = +0,165)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarnings"></a>GetFieldWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.5.0

Δ: 136,887 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">185,236 ns</td><td align="right" bgcolor="#FFFFFF">190,872 ns</td><td align="right" bgcolor="#FFFFFF">322,123 ns</td><td align="right" bgcolor="#FFFFFF">307,273 ns</td><td align="right" bgcolor="#FFFFFF">286,959 ns</td><td align="right" bgcolor="#FFFFFF">192,475 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,185 μs</td><td align="right" bgcolor="#FFFFFF">0,191 μs</td><td align="right" bgcolor="#FFFFFF">0,322 μs</td><td align="right" bgcolor="#FFFFFF">0,307 μs</td><td align="right" bgcolor="#FFFFFF">0,287 μs</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -169,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">169,000 (Δ = +169,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,165)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,165 (Δ = +0,165)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetValidations"></a>GetValidations

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 333,411 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+70,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">433,673 ns</td><td align="right" bgcolor="#FFFFFF">445,257 ns</td><td align="right" bgcolor="#FF4949">758,797 ns (Δ = +313,539 ns)</td><td align="right" bgcolor="#FFFFFF">767,085 ns</td><td align="right" bgcolor="#FFFFFF">755,278 ns</td><td align="right" bgcolor="#A8D08D">479,044 ns (Δ = -276,234 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,434 μs</td><td align="right" bgcolor="#FFFFFF">0,445 μs</td><td align="right" bgcolor="#FFFFFF">0,759 μs</td><td align="right" bgcolor="#FFFFFF">0,767 μs</td><td align="right" bgcolor="#FFFFFF">0,755 μs</td><td align="right" bgcolor="#FFFFFF">0,479 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">346,000</td><td align="right" bgcolor="#FFFFFF">346,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -346,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">346,000 (Δ = +346,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,338</td><td align="right" bgcolor="#FFFFFF">0,338</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,338)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,338 (Δ = +0,338)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarningCount"></a>GetWarningCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 780,398 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+68,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">923,494 ns</td><td align="right" bgcolor="#FFFFFF">799,229 ns</td><td align="right" bgcolor="#FF4949">1346,175 ns (Δ = +546,946 ns)</td><td align="right" bgcolor="#FFFFFF">1579,627 ns</td><td align="right" bgcolor="#FFFFFF">1569,011 ns</td><td align="right" bgcolor="#A8D08D">885,594 ns (Δ = -683,416 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,923 μs</td><td align="right" bgcolor="#FFFFFF">0,799 μs</td><td align="right" bgcolor="#FFFFFF">1,346 μs</td><td align="right" bgcolor="#FFFFFF">1,580 μs</td><td align="right" bgcolor="#FFFFFF">1,569 μs</td><td align="right" bgcolor="#FFFFFF">0,886 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -514,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">514,000 (Δ = +514,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,502)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,502 (Δ = +0,502)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarnings"></a>GetWarnings

#### Performance

Fastest: **5.4.0**

Slowest: 5.9.0

Δ: 749,610 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+85,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-41,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">891,654 ns</td><td align="right" bgcolor="#FFFFFF">815,011 ns</td><td align="right" bgcolor="#FF4949">1515,210 ns (Δ = +700,199 ns)</td><td align="right" bgcolor="#FFFFFF">1410,529 ns</td><td align="right" bgcolor="#FFFFFF">1564,621 ns</td><td align="right" bgcolor="#A8D08D">923,490 ns (Δ = -641,130 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,892 μs</td><td align="right" bgcolor="#FFFFFF">0,815 μs</td><td align="right" bgcolor="#FFFFFF">1,515 μs</td><td align="right" bgcolor="#FFFFFF">1,411 μs</td><td align="right" bgcolor="#FFFFFF">1,565 μs</td><td align="right" bgcolor="#FFFFFF">0,923 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.0.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#FFFFFF">514,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -514,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">514,000 (Δ = +514,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#FFFFFF">0,502</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,502)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,502 (Δ = +0,502)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 581,568 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+130,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">238,917 ns</td><td align="right" bgcolor="#FFFFFF">209,612 ns</td><td align="right" bgcolor="#FFFFFF">347,497 ns</td><td align="right" bgcolor="#FFFFFF">351,940 ns</td><td align="right" bgcolor="#FFFFFF">342,620 ns</td><td align="right" bgcolor="#FF4949">791,181 ns (Δ = +448,561 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,239 μs</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td><td align="right" bgcolor="#FFFFFF">0,347 μs</td><td align="right" bgcolor="#FFFFFF">0,352 μs</td><td align="right" bgcolor="#FFFFFF">0,343 μs</td><td align="right" bgcolor="#FFFFFF">0,791 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -169,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">169,000 (Δ = +169,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,165)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,165 (Δ = +0,165)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 458,110 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+112,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">191,776 ns</td><td align="right" bgcolor="#FFFFFF">185,116 ns</td><td align="right" bgcolor="#FFFFFF">312,853 ns</td><td align="right" bgcolor="#FFFFFF">321,914 ns</td><td align="right" bgcolor="#FFFFFF">302,087 ns</td><td align="right" bgcolor="#FF4949">643,226 ns (Δ = +341,139 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,185 μs</td><td align="right" bgcolor="#FFFFFF">0,313 μs</td><td align="right" bgcolor="#FFFFFF">0,322 μs</td><td align="right" bgcolor="#FFFFFF">0,302 μs</td><td align="right" bgcolor="#FFFFFF">0,643 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#FFFFFF">169,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -169,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">169,000 (Δ = +169,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#FFFFFF">0,165</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,165)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,165 (Δ = +0,165)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.4.0**

Slowest: 5.12.0

Δ: 556,321 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+54,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">284,214 ns</td><td align="right" bgcolor="#FFFFFF">246,979 ns</td><td align="right" bgcolor="#FFFFFF">492,272 ns</td><td align="right" bgcolor="#FFFFFF">519,171 ns</td><td align="right" bgcolor="#FFFFFF">518,986 ns</td><td align="right" bgcolor="#FF4949">803,299 ns (Δ = +284,314 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,284 μs</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td><td align="right" bgcolor="#FFFFFF">0,492 μs</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td><td align="right" bgcolor="#FFFFFF">0,803 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">329,000</td><td align="right" bgcolor="#FFFFFF">329,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -329,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">329,000 (Δ = +329,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,321</td><td align="right" bgcolor="#FFFFFF">0,321</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,321)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,321 (Δ = +0,321)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="ValidationSummary_Benchmark"></a>ValidationSummary_Benchmark

### <a name="ValidationSummary_Benchmark_BusinessRuleErrors"></a>BusinessRuleErrors

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 6,164 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,188 ns</td><td align="right" bgcolor="#FFFFFF">6,550 ns</td><td align="right" bgcolor="#FFFFFF">10,951 ns</td><td align="right" bgcolor="#FFFFFF">12,714 ns</td><td align="right" bgcolor="#FFFFFF">12,410 ns</td><td align="right" bgcolor="#FFFFFF">7,171 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -33,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +33,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationSummary_Benchmark_BusinessRuleWarnings"></a>BusinessRuleWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.9.0

Δ: 6,376 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,159 ns</td><td align="right" bgcolor="#FFFFFF">6,878 ns</td><td align="right" bgcolor="#FFFFFF">11,713 ns</td><td align="right" bgcolor="#FFFFFF">12,508 ns</td><td align="right" bgcolor="#FFFFFF">12,535 ns</td><td align="right" bgcolor="#FFFFFF">7,044 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -33,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +33,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldErrors"></a>FieldErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 6,489 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,950 ns</td><td align="right" bgcolor="#FFFFFF">6,943 ns</td><td align="right" bgcolor="#FFFFFF">10,944 ns</td><td align="right" bgcolor="#FFFFFF">12,439 ns</td><td align="right" bgcolor="#FFFFFF">12,412 ns</td><td align="right" bgcolor="#FFFFFF">6,124 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -33,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +33,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldWarnings"></a>FieldWarnings

#### Performance

Fastest: **5.12.0**

Slowest: 5.6.0

Δ: 6,637 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,444 ns</td><td align="right" bgcolor="#FFFFFF">6,759 ns</td><td align="right" bgcolor="#FFFFFF">12,109 ns</td><td align="right" bgcolor="#FFFFFF">12,708 ns</td><td align="right" bgcolor="#FFFFFF">12,396 ns</td><td align="right" bgcolor="#FFFFFF">6,071 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -33,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +33,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasBusinessRuleErrors"></a>HasBusinessRuleErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.4.0

Δ: 0,602 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,137 ns</td><td align="right" bgcolor="#FFFFFF">0,602 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FFFFFF">0,467 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FFFFFF">0,509 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasBusinessRuleWarnings"></a>HasBusinessRuleWarnings

#### Performance

Fastest: **5.9.0**

Slowest: 5.12.0

Δ: 0,529 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,036 ns</td><td align="right" bgcolor="#FFFFFF">0,510 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FFFFFF">0,484 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FFFFFF">0,529 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 1,356 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,061 ns</td><td align="right" bgcolor="#FFFFFF">0,484 ns</td><td align="right" bgcolor="#FFFFFF">0,315 ns</td><td align="right" bgcolor="#FFFFFF">1,417 ns</td><td align="right" bgcolor="#FFFFFF">0,776 ns</td><td align="right" bgcolor="#FFFFFF">0,398 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldErrors"></a>HasFieldErrors

#### Performance

Fastest: **5.9.0**

Slowest: 5.6.0

Δ: 0,698 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FFFFFF">0,426 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FFFFFF">0,698 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FFFFFF">0,414 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldWarnings"></a>HasFieldWarnings

#### Performance

Fastest: **5.5.0**

Slowest: 5.4.0

Δ: 0,516 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,166 ns</td><td align="right" bgcolor="#FFFFFF">0,516 ns</td><td align="right" bgcolor="#FFFFFF">0,000 ns</td><td align="right" bgcolor="#FFFFFF">0,468 ns</td><td align="right" bgcolor="#FFFFFF">0,292 ns</td><td align="right" bgcolor="#FFFFFF">0,344 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.6.0

Δ: 2,344 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,111 ns</td><td align="right" bgcolor="#FFFFFF">0,519 ns</td><td align="right" bgcolor="#FFFFFF">0,446 ns</td><td align="right" bgcolor="#FFFFFF">2,455 ns</td><td align="right" bgcolor="#FFFFFF">0,785 ns</td><td align="right" bgcolor="#FFFFFF">0,383 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.12.0**

Slowest: 5.9.0

Δ: 626,429 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+62,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-41,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">909,261 ns</td><td align="right" bgcolor="#FFFFFF">893,585 ns</td><td align="right" bgcolor="#FF4949">1454,703 ns (Δ = +561,117 ns)</td><td align="right" bgcolor="#FFFFFF">1401,061 ns</td><td align="right" bgcolor="#FFFFFF">1504,351 ns</td><td align="right" bgcolor="#A8D08D">877,923 ns (Δ = -626,429 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,909 μs</td><td align="right" bgcolor="#FFFFFF">0,894 μs</td><td align="right" bgcolor="#FFFFFF">1,455 μs</td><td align="right" bgcolor="#FFFFFF">1,401 μs</td><td align="right" bgcolor="#FFFFFF">1,504 μs</td><td align="right" bgcolor="#FFFFFF">0,878 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.12.0</td><td align="right">5.5.0</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FF4949">2,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">739,000</td><td align="right" bgcolor="#FFFFFF">739,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -739,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">739,000 (Δ = +739,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,722</td><td align="right" bgcolor="#FFFFFF">0,722</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,722)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,722 (Δ = +0,722)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,001)</td></tr></table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.4.0**

Slowest: 5.6.0

Δ: 14976,164 ns


<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,8 %</td><td align="right" bgcolor="#FF4949">+80,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-29,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19560,939 ns</td><td align="right" bgcolor="#A8D08D">18433,755 ns (Δ = -1127,184 ns)</td><td align="right" bgcolor="#FF4949">33346,082 ns (Δ = +14912,327 ns)</td><td align="right" bgcolor="#FFFFFF">33409,920 ns</td><td align="right" bgcolor="#FFFFFF">33163,453 ns</td><td align="right" bgcolor="#A8D08D">23415,388 ns (Δ = -9748,065 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">19,561 μs</td><td align="right" bgcolor="#FFFFFF">18,434 μs</td><td align="right" bgcolor="#FFFFFF">33,346 μs</td><td align="right" bgcolor="#FFFFFF">33,410 μs</td><td align="right" bgcolor="#FFFFFF">33,163 μs</td><td align="right" bgcolor="#FFFFFF">23,415 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td><td align="right" bgcolor="#FFFFFF">0,033 ms</td><td align="right" bgcolor="#FFFFFF">0,023 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.6.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 1</td><td align="right">5.12.0</td><td align="right">5.9.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.9.0</td><td align="right">5.12.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.4.0</th><th>5.5.0</th><th>5.6.0</th><th>5.9.0</th><th>5.12.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FF4949">6,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">6,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +1,000)</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">5721,000</td><td align="right" bgcolor="#FF4949">6059,000 (Δ = +338,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -6059,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">6773,000 (Δ = +6773,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">5,587</td><td align="right" bgcolor="#FF4949">5,917 (Δ = +0,330)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,917)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">6,614 (Δ = +6,614)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,005</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,006)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,006)</td></tr></table>


