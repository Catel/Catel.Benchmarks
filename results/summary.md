# Benchmarks

Benchmark report generated on 03-mei-2018 15:45

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


If versions behave the same (e.g. result in exactly the same values), this report will show the highest version to represent the most recent state at best.
If a higher version is at least 3% slower than the previous one, it will have a red background. If it is at least 3% faster, it will have a green background.

## Host environment information

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134, VM=Hyper-V

Intel Core i7-3960X CPU 3.30GHz (Ivy Bridge), 1 CPU, 8 logical and 8 physical cores



## Important benchmarks

### High priority (current version slower than previous one)

15 item(s)

1. [Serialization_Binary_Benchmark::SerializeLevel1Models](#Serialization_Binary_Benchmark_SerializeLevel1Models) v5.4.0 is **33,20%** (Δ: 106414,948 ns) slower than v5.3.0

2. [Serialization_Xml_Benchmark::SerializeLevel1Models](#Serialization_Xml_Benchmark_SerializeLevel1Models) v5.4.0 is **28,62%** (Δ: 115706,911 ns) slower than v5.3.0

3. [AssemblyExtensions_Benchmark::GetBuildDateTime](#AssemblyExtensions_Benchmark_GetBuildDateTime) v5.4.0 is **24,62%** (Δ: 86514,835 ns) slower than v5.3.0

4. [Serialization_Binary_Benchmark::SerializeLevel2Models](#Serialization_Binary_Benchmark_SerializeLevel2Models) v5.4.0 is **23,95%** (Δ: 108787,546 ns) slower than v5.3.0

5. [Serialization_Xml_Benchmark::SerializeLevel2Models](#Serialization_Xml_Benchmark_SerializeLevel2Models) v5.4.0 is **18,02%** (Δ: 140311,788 ns) slower than v5.3.0

6. [Serialization_Binary_Benchmark::SerializeComplexObjectGraph](#Serialization_Binary_Benchmark_SerializeComplexObjectGraph) v5.4.0 is **17,00%** (Δ: 94114,327 ns) slower than v5.3.0

7. [Attribute_ReflectionExtensions_Benchmark::TryGetAttribute_From_Type](#Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type) v5.4.0 is **13,21%** (Δ: 457,902 ns) slower than v5.3.0

8. [Serialization_Binary_Benchmark::SerializeLevel3Models](#Serialization_Binary_Benchmark_SerializeLevel3Models) v5.4.0 is **10,18%** (Δ: 122410,508 ns) slower than v5.3.0

9. [Serialization_Xml_Benchmark::SerializeComplexObjectGraph](#Serialization_Xml_Benchmark_SerializeComplexObjectGraph) v5.4.0 is **9,94%** (Δ: 120945,054 ns) slower than v5.3.0

10. [Serialization_Xml_Benchmark::SerializeLevel3Models](#Serialization_Xml_Benchmark_SerializeLevel3Models) v5.4.0 is **8,72%** (Δ: 231203,153 ns) slower than v5.3.0

11. [WeakEventListener_Benchmark::SubscribeToWeakPropertyChangedEvent](#WeakEventListener_Benchmark_SubscribeToWeakPropertyChangedEvent) v5.4.0 is **6,69%** (Δ: 1318,152 ns) slower than v5.3.0

12. [Serialization_Json_Benchmark::SerializeLevel1Models](#Serialization_Json_Benchmark_SerializeLevel1Models) v5.4.0 is **6,44%** (Δ: 65189,347 ns) slower than v5.3.0

13. [Type_ReflectionExtensions_Benchmark::IsInstanceOfTypeEx](#Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx) v5.4.0 is **5,75%** (Δ: 927,174 ns) slower than v5.3.0

14. [WeakEventListener_Benchmark::SubscribeToWeakGenericEvent](#WeakEventListener_Benchmark_SubscribeToWeakGenericEvent) v5.4.0 is **5,25%** (Δ: 974,896 ns) slower than v5.3.0

15. [TagHelper_Benchmark::ToString_](#TagHelper_Benchmark_ToString_) v5.4.0 is **3,27%** (Δ: 653,279 ns) slower than v5.3.0



### Improved (current version faster than previous one)

22 item(s)

1. [Assembly_ReflectionExtensions_Benchmark::GetTypesEx](#Assembly_ReflectionExtensions_Benchmark_GetTypesEx) v5.4.0 is **21,75%** (Δ: -1701,623 ns) faster than v5.3.0

2. [Assembly_ReflectionExtensions_Benchmark::GetExportedTypesEx](#Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx) v5.4.0 is **16,54%** (Δ: -2919,611 ns) faster than v5.3.0

3. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx) v5.4.0 is **9,94%** (Δ: -432,827 ns) faster than v5.3.0

4. [AssemblyExtensions_Benchmark::GetDirectory](#AssemblyExtensions_Benchmark_GetDirectory) v5.4.0 is **9,43%** (Δ: -282,132 ns) faster than v5.3.0

5. [ModelBase_Constructor_Benchmark::Constructor](#ModelBase_Constructor_Benchmark_Constructor) v5.4.0 is **8,55%** (Δ: -254,007 ns) faster than v5.3.0

6. [AssemblyExtensions_Benchmark::InformationalVersion](#AssemblyExtensions_Benchmark_InformationalVersion) v5.4.0 is **7,43%** (Δ: -598,522 ns) faster than v5.3.0

7. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.4.0 is **5,81%** (Δ: -328,107 ns) faster than v5.3.0

8. [Assembly_ReflectionExtensions_Benchmark::GetCustomAttributeEx](#Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx) v5.4.0 is **5,57%** (Δ: -435,391 ns) faster than v5.3.0

9. [Assembly_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.4.0 is **5,55%** (Δ: -432,348 ns) faster than v5.3.0

10. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v5.4.0 is **4,85%** (Δ: -339,477 ns) faster than v5.3.0

11. [AssemblyExtensions_Benchmark::Copyright](#AssemblyExtensions_Benchmark_Copyright) v5.4.0 is **4,66%** (Δ: -459,216 ns) faster than v5.3.0

12. [Type_ReflectionExtensions_Benchmark::GetCustomAttributesEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit) v5.4.0 is **4,07%** (Δ: -393,163 ns) faster than v5.3.0

13. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_AttributeType__Inheritd](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd) v5.4.0 is **3,89%** (Δ: -270,941 ns) faster than v5.3.0

14. [MethodInfo_ReflectionExtensions_Benchmark::GetCustomAttributesEx_Inherit](#MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit) v5.4.0 is **3,87%** (Δ: -315,274 ns) faster than v5.3.0

15. [Serialization_Json_Benchmark::SerializeLevel3Models](#Serialization_Json_Benchmark_SerializeLevel3Models) v5.4.0 is **3,78%** (Δ: -528294,218 ns) faster than v5.3.0

16. [Type_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v5.4.0 is **3,68%** (Δ: -355,974 ns) faster than v5.3.0

17. [Serialization_Json_Benchmark::SerializeComplexObjectGraph](#Serialization_Json_Benchmark_SerializeComplexObjectGraph) v5.4.0 is **3,62%** (Δ: -637894,455 ns) faster than v5.3.0

18. [AssemblyExtensions_Benchmark::Product](#AssemblyExtensions_Benchmark_Product) v5.4.0 is **3,57%** (Δ: -349,752 ns) faster than v5.3.0

19. [AssemblyExtensions_Benchmark::Description](#AssemblyExtensions_Benchmark_Description) v5.4.0 is **3,19%** (Δ: -308,256 ns) faster than v5.3.0

20. [AssemblyExtensions_Benchmark::Title](#AssemblyExtensions_Benchmark_Title) v5.4.0 is **2,74%** (Δ: -263,807 ns) faster than v5.3.0

21. [Serialization_Json_Benchmark::SerializeLevel2Models](#Serialization_Json_Benchmark_SerializeLevel2Models) v5.4.0 is **1,54%** (Δ: -49179,587 ns) faster than v5.3.0

22. [ParallelHelper_Benchmark::ExecuteInParallel_ItemsPerBash_1000](#ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000) v5.4.0 is **1,16%** (Δ: -7484,668 ns) faster than v5.3.0



## <a name="Argument_Benchmark"></a>Argument_Benchmark

### <a name="Argument_Benchmark_ImplementsInterface"></a>ImplementsInterface

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 34,895 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">129,488 ns</td><td align="right" bgcolor="#FFFFFF">95,907 ns</td><td align="right" bgcolor="#FFFFFF">94,841 ns</td><td align="right" bgcolor="#FFFFFF">97,112 ns</td><td align="right" bgcolor="#FFFFFF">97,037 ns</td><td align="right" bgcolor="#FFFFFF">94,593 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">119,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">119,000</td><td align="right" bgcolor="#FFFFFF">119,000</td><td align="right" bgcolor="#FF4949">156,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,116 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,116</td><td align="right" bgcolor="#FFFFFF">0,116</td><td align="right" bgcolor="#FF4949">0,152 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 4,573 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">98,039 ns</td><td align="right" bgcolor="#FFFFFF">97,301 ns</td><td align="right" bgcolor="#FFFFFF">96,304 ns</td><td align="right" bgcolor="#FFFFFF">100,213 ns</td><td align="right" bgcolor="#FFFFFF">97,018 ns</td><td align="right" bgcolor="#FFFFFF">95,640 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">119,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">119,000</td><td align="right" bgcolor="#FFFFFF">119,000</td><td align="right" bgcolor="#FF4949">156,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,116 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,116</td><td align="right" bgcolor="#FFFFFF">0,116</td><td align="right" bgcolor="#FF4949">0,152 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 4,022 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">92,378 ns</td><td align="right" bgcolor="#FFFFFF">94,005 ns</td><td align="right" bgcolor="#FFFFFF">89,983 ns</td><td align="right" bgcolor="#FFFFFF">90,691 ns</td><td align="right" bgcolor="#FFFFFF">93,203 ns</td><td align="right" bgcolor="#FFFFFF">93,227 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,092 μs</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,090 μs</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">119,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">119,000</td><td align="right" bgcolor="#FFFFFF">119,000</td><td align="right" bgcolor="#FF4949">156,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,116 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,116</td><td align="right" bgcolor="#FFFFFF">0,116</td><td align="right" bgcolor="#FF4949">0,152 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 30,239 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">125,702 ns</td><td align="right" bgcolor="#FFFFFF">99,827 ns</td><td align="right" bgcolor="#FFFFFF">97,223 ns</td><td align="right" bgcolor="#FFFFFF">95,464 ns</td><td align="right" bgcolor="#FFFFFF">95,836 ns</td><td align="right" bgcolor="#FFFFFF">96,995 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">119,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">119,000</td><td align="right" bgcolor="#FFFFFF">119,000</td><td align="right" bgcolor="#FF4949">156,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,116 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,116</td><td align="right" bgcolor="#FFFFFF">0,116</td><td align="right" bgcolor="#FF4949">0,152 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 6,528 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">36,986 ns</td><td align="right" bgcolor="#FFFFFF">37,065 ns</td><td align="right" bgcolor="#FFFFFF">42,367 ns</td><td align="right" bgcolor="#FFFFFF">41,502 ns</td><td align="right" bgcolor="#FFFFFF">42,306 ns</td><td align="right" bgcolor="#FFFFFF">35,838 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Generic"></a>InheritsFrom_Generic

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 7,984 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">42,428 ns</td><td align="right" bgcolor="#FFFFFF">42,644 ns</td><td align="right" bgcolor="#FFFFFF">49,241 ns</td><td align="right" bgcolor="#FFFFFF">48,563 ns</td><td align="right" bgcolor="#FFFFFF">47,849 ns</td><td align="right" bgcolor="#FFFFFF">41,257 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_InheritsFrom_Object"></a>InheritsFrom_Object

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 7,171 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">41,852 ns</td><td align="right" bgcolor="#FFFFFF">42,100 ns</td><td align="right" bgcolor="#FFFFFF">47,538 ns</td><td align="right" bgcolor="#FFFFFF">48,345 ns</td><td align="right" bgcolor="#FFFFFF">47,551 ns</td><td align="right" bgcolor="#FFFFFF">41,174 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsMatch"></a>IsMatch

#### Performance

Fastest: **5.1.0**

Slowest: 5.2.0

Δ: 84,038 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">677,606 ns</td><td align="right" bgcolor="#FFFFFF">692,036 ns</td><td align="right" bgcolor="#FFFFFF">654,230 ns</td><td align="right" bgcolor="#FFFFFF">738,268 ns</td><td align="right" bgcolor="#FFFFFF">679,853 ns</td><td align="right" bgcolor="#FFFFFF">658,637 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,678 μs</td><td align="right" bgcolor="#FFFFFF">0,692 μs</td><td align="right" bgcolor="#FFFFFF">0,654 μs</td><td align="right" bgcolor="#FFFFFF">0,738 μs</td><td align="right" bgcolor="#FFFFFF">0,680 μs</td><td align="right" bgcolor="#FFFFFF">0,659 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -70,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FF4949">324,000 (Δ = +70,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,068)</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FF4949">0,316 (Δ = +0,068)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsMaximum"></a>IsMaximum

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 2,101 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,918 ns</td><td align="right" bgcolor="#FFFFFF">14,454 ns</td><td align="right" bgcolor="#FFFFFF">14,393 ns</td><td align="right" bgcolor="#FFFFFF">14,475 ns</td><td align="right" bgcolor="#FFFFFF">15,584 ns</td><td align="right" bgcolor="#FFFFFF">16,493 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+35,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">18,500 (Δ = -6,500)</td><td align="right" bgcolor="#FFFFFF">18,500</td><td align="right" bgcolor="#FFFFFF">18,500</td><td align="right" bgcolor="#FF4949">25,000 (Δ = +6,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,018 (Δ = -0,006)</td><td align="right" bgcolor="#FFFFFF">0,018</td><td align="right" bgcolor="#FFFFFF">0,018</td><td align="right" bgcolor="#FF4949">0,024 (Δ = +0,006)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1,319 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,063 ns</td><td align="right" bgcolor="#FFFFFF">15,990 ns</td><td align="right" bgcolor="#FFFFFF">16,523 ns</td><td align="right" bgcolor="#FFFFFF">17,309 ns</td><td align="right" bgcolor="#FFFFFF">17,171 ns</td><td align="right" bgcolor="#FFFFFF">16,623 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+35,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">18,500 (Δ = -6,500)</td><td align="right" bgcolor="#FFFFFF">18,500</td><td align="right" bgcolor="#FFFFFF">18,500</td><td align="right" bgcolor="#FF4949">25,000 (Δ = +6,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,018 (Δ = -0,006)</td><td align="right" bgcolor="#FFFFFF">0,018</td><td align="right" bgcolor="#FFFFFF">0,018</td><td align="right" bgcolor="#FF4949">0,024 (Δ = +0,006)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,720 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,348 ns</td><td align="right" bgcolor="#FFFFFF">6,325 ns</td><td align="right" bgcolor="#FFFFFF">6,868 ns</td><td align="right" bgcolor="#FFFFFF">7,045 ns</td><td align="right" bgcolor="#FFFFFF">6,986 ns</td><td align="right" bgcolor="#FFFFFF">6,472 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotMatch"></a>IsNotMatch

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 18,926 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">508,178 ns</td><td align="right" bgcolor="#FFFFFF">519,294 ns</td><td align="right" bgcolor="#FFFFFF">519,196 ns</td><td align="right" bgcolor="#FFFFFF">510,572 ns</td><td align="right" bgcolor="#FFFFFF">518,761 ns</td><td align="right" bgcolor="#FFFFFF">500,368 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,508 μs</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td><td align="right" bgcolor="#FFFFFF">0,511 μs</td><td align="right" bgcolor="#FFFFFF">0,519 μs</td><td align="right" bgcolor="#FFFFFF">0,500 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -70,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FFFFFF">254,000</td><td align="right" bgcolor="#FF4949">324,000 (Δ = +70,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,068)</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FFFFFF">0,248</td><td align="right" bgcolor="#FF4949">0,316 (Δ = +0,068)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsNotNull"></a>IsNotNull

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,454 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,186 ns</td><td align="right" bgcolor="#FFFFFF">1,068 ns</td><td align="right" bgcolor="#FFFFFF">1,211 ns</td><td align="right" bgcolor="#FFFFFF">1,523 ns</td><td align="right" bgcolor="#FFFFFF">1,483 ns</td><td align="right" bgcolor="#FFFFFF">1,080 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 0,976 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,353 ns</td><td align="right" bgcolor="#FFFFFF">0,920 ns</td><td align="right" bgcolor="#FFFFFF">1,867 ns</td><td align="right" bgcolor="#FFFFFF">1,748 ns</td><td align="right" bgcolor="#FFFFFF">1,896 ns</td><td align="right" bgcolor="#FFFFFF">1,172 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmpty_Guid"></a>IsNotNullOrEmpty_Guid

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 3,910 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10,637 ns</td><td align="right" bgcolor="#FFFFFF">9,831 ns</td><td align="right" bgcolor="#FFFFFF">13,403 ns</td><td align="right" bgcolor="#FFFFFF">10,763 ns</td><td align="right" bgcolor="#FFFFFF">11,979 ns</td><td align="right" bgcolor="#FFFFFF">9,493 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrEmptyArray"></a>IsNotNullOrEmptyArray

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 0,274 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,461 ns</td><td align="right" bgcolor="#FFFFFF">3,187 ns</td><td align="right" bgcolor="#FFFFFF">3,211 ns</td><td align="right" bgcolor="#FFFFFF">3,386 ns</td><td align="right" bgcolor="#FFFFFF">3,331 ns</td><td align="right" bgcolor="#FFFFFF">3,455 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotNullOrWhitespace"></a>IsNotNullOrWhitespace

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 3,007 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,759 ns</td><td align="right" bgcolor="#FFFFFF">14,261 ns</td><td align="right" bgcolor="#FFFFFF">15,579 ns</td><td align="right" bgcolor="#FFFFFF">17,268 ns</td><td align="right" bgcolor="#FFFFFF">16,055 ns</td><td align="right" bgcolor="#FFFFFF">15,224 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes"></a>IsNotOfOneOfTheTypes

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 9,514 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">82,021 ns</td><td align="right" bgcolor="#FFFFFF">81,291 ns</td><td align="right" bgcolor="#FFFFFF">88,508 ns</td><td align="right" bgcolor="#FFFFFF">86,657 ns</td><td align="right" bgcolor="#FFFFFF">88,053 ns</td><td align="right" bgcolor="#FFFFFF">78,993 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,089 μs</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes_Object"></a>IsNotOfOneOfTheTypes_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 9,751 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">86,638 ns</td><td align="right" bgcolor="#FFFFFF">88,259 ns</td><td align="right" bgcolor="#FFFFFF">95,281 ns</td><td align="right" bgcolor="#FFFFFF">94,536 ns</td><td align="right" bgcolor="#FFFFFF">96,388 ns</td><td align="right" bgcolor="#FFFFFF">87,002 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td><td align="right" bgcolor="#FFFFFF">0,088 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType"></a>IsNotOfType

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 5,698 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">56,852 ns</td><td align="right" bgcolor="#FFFFFF">58,539 ns</td><td align="right" bgcolor="#FFFFFF">60,998 ns</td><td align="right" bgcolor="#FFFFFF">61,369 ns</td><td align="right" bgcolor="#FFFFFF">61,535 ns</td><td align="right" bgcolor="#FFFFFF">55,837 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td><td align="right" bgcolor="#FFFFFF">0,056 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOfType_Object"></a>IsNotOfType_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 4,830 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">64,265 ns</td><td align="right" bgcolor="#FFFFFF">69,095 ns</td><td align="right" bgcolor="#FFFFFF">68,658 ns</td><td align="right" bgcolor="#FFFFFF">68,343 ns</td><td align="right" bgcolor="#FFFFFF">68,561 ns</td><td align="right" bgcolor="#FFFFFF">65,378 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsNotOutOfRange"></a>IsNotOutOfRange

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 2,809 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">23,549 ns</td><td align="right" bgcolor="#FFFFFF">24,052 ns</td><td align="right" bgcolor="#FFFFFF">25,783 ns</td><td align="right" bgcolor="#FFFFFF">25,998 ns</td><td align="right" bgcolor="#FFFFFF">26,358 ns</td><td align="right" bgcolor="#FFFFFF">24,452 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#A8D08D">37,000 (Δ = -12,000)</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FF4949">49,000 (Δ = +12,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,012)</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FF4949">0,048 (Δ = +0,012)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes"></a>IsOfOneOfTheTypes

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 9,232 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">57,383 ns</td><td align="right" bgcolor="#FFFFFF">58,859 ns</td><td align="right" bgcolor="#FFFFFF">66,138 ns</td><td align="right" bgcolor="#FFFFFF">59,720 ns</td><td align="right" bgcolor="#FFFFFF">61,346 ns</td><td align="right" bgcolor="#FFFFFF">56,907 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,060 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfOneOfTheTypes_Object"></a>IsOfOneOfTheTypes_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 3,753 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">64,174 ns</td><td align="right" bgcolor="#FFFFFF">64,716 ns</td><td align="right" bgcolor="#FFFFFF">67,583 ns</td><td align="right" bgcolor="#FFFFFF">67,928 ns</td><td align="right" bgcolor="#FFFFFF">67,911 ns</td><td align="right" bgcolor="#FFFFFF">64,417 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,068 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType"></a>IsOfType

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 2,601 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">38,478 ns</td><td align="right" bgcolor="#FFFFFF">39,006 ns</td><td align="right" bgcolor="#FFFFFF">40,726 ns</td><td align="right" bgcolor="#FFFFFF">40,255 ns</td><td align="right" bgcolor="#FFFFFF">40,984 ns</td><td align="right" bgcolor="#FFFFFF">38,383 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Argument_Benchmark_IsOfType_Object"></a>IsOfType_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 3,581 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">46,795 ns</td><td align="right" bgcolor="#FFFFFF">47,788 ns</td><td align="right" bgcolor="#FFFFFF">48,290 ns</td><td align="right" bgcolor="#FFFFFF">48,198 ns</td><td align="right" bgcolor="#FFFFFF">50,377 ns</td><td align="right" bgcolor="#FFFFFF">47,777 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="Assembly_ReflectionExtensions_Benchmark"></a>Assembly_ReflectionExtensions_Benchmark

### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 464,047 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,6 %</td><td align="right" bgcolor="#FF4949">+6,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7767,756 ns</td><td align="right" bgcolor="#A8D08D">7407,640 ns (Δ = -360,116 ns)</td><td align="right" bgcolor="#FF4949">7850,840 ns (Δ = +443,200 ns)</td><td align="right" bgcolor="#FFFFFF">7799,677 ns</td><td align="right" bgcolor="#FFFFFF">7822,184 ns</td><td align="right" bgcolor="#A8D08D">7386,793 ns (Δ = -435,391 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,768 μs</td><td align="right" bgcolor="#FFFFFF">7,408 μs</td><td align="right" bgcolor="#FFFFFF">7,851 μs</td><td align="right" bgcolor="#FFFFFF">7,800 μs</td><td align="right" bgcolor="#FFFFFF">7,822 μs</td><td align="right" bgcolor="#FFFFFF">7,387 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#A8D08D">555,000 (Δ = -174,000)</td><td align="right" bgcolor="#FFFFFF">555,000</td><td align="right" bgcolor="#FFFFFF">555,000</td><td align="right" bgcolor="#FF4949">729,000 (Δ = +174,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#A8D08D">0,542 (Δ = -0,170)</td><td align="right" bgcolor="#FFFFFF">0,542</td><td align="right" bgcolor="#FFFFFF">0,542</td><td align="right" bgcolor="#FF4949">0,712 (Δ = +0,170)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 490,816 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7502,168 ns</td><td align="right" bgcolor="#FFFFFF">7410,848 ns</td><td align="right" bgcolor="#FF4949">7853,469 ns (Δ = +442,622 ns)</td><td align="right" bgcolor="#FFFFFF">7827,174 ns</td><td align="right" bgcolor="#FFFFFF">7795,002 ns</td><td align="right" bgcolor="#A8D08D">7362,653 ns (Δ = -432,348 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,502 μs</td><td align="right" bgcolor="#FFFFFF">7,411 μs</td><td align="right" bgcolor="#FFFFFF">7,853 μs</td><td align="right" bgcolor="#FFFFFF">7,827 μs</td><td align="right" bgcolor="#FFFFFF">7,795 μs</td><td align="right" bgcolor="#FFFFFF">7,363 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#A8D08D">555,000 (Δ = -174,000)</td><td align="right" bgcolor="#FFFFFF">555,000</td><td align="right" bgcolor="#FFFFFF">555,000</td><td align="right" bgcolor="#FF4949">729,000 (Δ = +174,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#A8D08D">0,542 (Δ = -0,170)</td><td align="right" bgcolor="#FFFFFF">0,542</td><td align="right" bgcolor="#FFFFFF">0,542</td><td align="right" bgcolor="#FF4949">0,712 (Δ = +0,170)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 2990,086 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,7 %</td><td align="right" bgcolor="#FF4949">+20,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15065,953 ns</td><td align="right" bgcolor="#A8D08D">14666,092 ns (Δ = -399,862 ns)</td><td align="right" bgcolor="#FF4949">17594,426 ns (Δ = +2928,334 ns)</td><td align="right" bgcolor="#FFFFFF">17608,916 ns</td><td align="right" bgcolor="#FFFFFF">17656,178 ns</td><td align="right" bgcolor="#A8D08D">14736,567 ns (Δ = -2919,611 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">15,066 μs</td><td align="right" bgcolor="#FFFFFF">14,666 μs</td><td align="right" bgcolor="#FFFFFF">17,594 μs</td><td align="right" bgcolor="#FFFFFF">17,609 μs</td><td align="right" bgcolor="#FFFFFF">17,656 μs</td><td align="right" bgcolor="#FFFFFF">14,737 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,9 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1364,000</td><td align="right" bgcolor="#FF4949">1376,000 (Δ = +12,000)</td><td align="right" bgcolor="#A8D08D">1032,000 (Δ = -344,000)</td><td align="right" bgcolor="#FFFFFF">1032,000</td><td align="right" bgcolor="#FFFFFF">1032,000</td><td align="right" bgcolor="#FF4949">1376,000 (Δ = +344,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,332</td><td align="right" bgcolor="#FF4949">1,344 (Δ = +0,012)</td><td align="right" bgcolor="#A8D08D">1,008 (Δ = -0,336)</td><td align="right" bgcolor="#FFFFFF">1,008</td><td align="right" bgcolor="#FFFFFF">1,008</td><td align="right" bgcolor="#FF4949">1,344 (Δ = +0,336)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 1805,350 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6018,290 ns</td><td align="right" bgcolor="#FFFFFF">6029,456 ns</td><td align="right" bgcolor="#FF4949">7713,574 ns (Δ = +1684,118 ns)</td><td align="right" bgcolor="#FFFFFF">7711,595 ns</td><td align="right" bgcolor="#FFFFFF">7823,640 ns</td><td align="right" bgcolor="#A8D08D">6122,017 ns (Δ = -1701,623 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,018 μs</td><td align="right" bgcolor="#FFFFFF">6,029 μs</td><td align="right" bgcolor="#FFFFFF">7,714 μs</td><td align="right" bgcolor="#FFFFFF">7,712 μs</td><td align="right" bgcolor="#FFFFFF">7,824 μs</td><td align="right" bgcolor="#FFFFFF">6,122 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,1 %</td><td align="right" bgcolor="#A8D08D">-24,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3019,000</td><td align="right" bgcolor="#FF4949">3051,500 (Δ = +32,500)</td><td align="right" bgcolor="#A8D08D">2292,000 (Δ = -759,500)</td><td align="right" bgcolor="#FFFFFF">2292,000</td><td align="right" bgcolor="#FFFFFF">2292,000</td><td align="right" bgcolor="#FF4949">3060,000 (Δ = +768,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,948</td><td align="right" bgcolor="#FF4949">2,980 (Δ = +0,032)</td><td align="right" bgcolor="#A8D08D">2,238 (Δ = -0,742)</td><td align="right" bgcolor="#FFFFFF">2,238</td><td align="right" bgcolor="#FFFFFF">2,238</td><td align="right" bgcolor="#FF4949">2,988 (Δ = +0,750)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,001)</td></tr></table>


## <a name="AssemblyExtensions_Benchmark"></a>AssemblyExtensions_Benchmark

### <a name="AssemblyExtensions_Benchmark_Company"></a>Company

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 339,924 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9523,373 ns</td><td align="right" bgcolor="#FFFFFF">9530,788 ns</td><td align="right" bgcolor="#FFFFFF">9761,243 ns</td><td align="right" bgcolor="#FFFFFF">9634,204 ns</td><td align="right" bgcolor="#FFFFFF">9621,979 ns</td><td align="right" bgcolor="#FFFFFF">9421,318 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,523 μs</td><td align="right" bgcolor="#FFFFFF">9,531 μs</td><td align="right" bgcolor="#FFFFFF">9,761 μs</td><td align="right" bgcolor="#FFFFFF">9,634 μs</td><td align="right" bgcolor="#FFFFFF">9,622 μs</td><td align="right" bgcolor="#FFFFFF">9,421 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#A8D08D">633,000 (Δ = -203,000)</td><td align="right" bgcolor="#FFFFFF">633,000</td><td align="right" bgcolor="#FFFFFF">633,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +203,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#A8D08D">0,618 (Δ = -0,198)</td><td align="right" bgcolor="#FFFFFF">0,618</td><td align="right" bgcolor="#FFFFFF">0,618</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,198)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 503,818 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9894,218 ns</td><td align="right" bgcolor="#FFFFFF">9674,285 ns</td><td align="right" bgcolor="#FFFFFF">9735,836 ns</td><td align="right" bgcolor="#FFFFFF">9772,949 ns</td><td align="right" bgcolor="#FFFFFF">9849,616 ns</td><td align="right" bgcolor="#A8D08D">9390,400 ns (Δ = -459,216 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,894 μs</td><td align="right" bgcolor="#FFFFFF">9,674 μs</td><td align="right" bgcolor="#FFFFFF">9,736 μs</td><td align="right" bgcolor="#FFFFFF">9,773 μs</td><td align="right" bgcolor="#FFFFFF">9,850 μs</td><td align="right" bgcolor="#FFFFFF">9,390 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+29,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#A8D08D">680,000 (Δ = -201,000)</td><td align="right" bgcolor="#FFFFFF">680,000</td><td align="right" bgcolor="#FFFFFF">680,000</td><td align="right" bgcolor="#FF4949">881,000 (Δ = +201,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#A8D08D">0,664 (Δ = -0,196)</td><td align="right" bgcolor="#FFFFFF">0,664</td><td align="right" bgcolor="#FFFFFF">0,664</td><td align="right" bgcolor="#FF4949">0,860 (Δ = +0,196)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Description"></a>Description

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 425,863 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9508,656 ns</td><td align="right" bgcolor="#FF4949">9789,059 ns (Δ = +280,403 ns)</td><td align="right" bgcolor="#FFFFFF">9722,409 ns</td><td align="right" bgcolor="#FFFFFF">9641,073 ns</td><td align="right" bgcolor="#FFFFFF">9671,453 ns</td><td align="right" bgcolor="#A8D08D">9363,197 ns (Δ = -308,256 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,509 μs</td><td align="right" bgcolor="#FFFFFF">9,789 μs</td><td align="right" bgcolor="#FFFFFF">9,722 μs</td><td align="right" bgcolor="#FFFFFF">9,641 μs</td><td align="right" bgcolor="#FFFFFF">9,671 μs</td><td align="right" bgcolor="#FFFFFF">9,363 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">647,000 (Δ = -205,000)</td><td align="right" bgcolor="#FFFFFF">647,000</td><td align="right" bgcolor="#FFFFFF">647,000</td><td align="right" bgcolor="#FF4949">852,000 (Δ = +205,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,632 (Δ = -0,200)</td><td align="right" bgcolor="#FFFFFF">0,632</td><td align="right" bgcolor="#FFFFFF">0,632</td><td align="right" bgcolor="#FF4949">0,832 (Δ = +0,200)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 93604,807 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,7 %</td><td align="right" bgcolor="#A8D08D">-21,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+24,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">435025,508 ns</td><td align="right" bgcolor="#FF4949">442206,699 ns (Δ = +7181,191 ns)</td><td align="right" bgcolor="#A8D08D">348601,893 ns (Δ = -93604,807 ns)</td><td align="right" bgcolor="#FFFFFF">350885,788 ns</td><td align="right" bgcolor="#FFFFFF">351395,770 ns</td><td align="right" bgcolor="#FF4949">437910,605 ns (Δ = +86514,835 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">435,026 μs</td><td align="right" bgcolor="#FFFFFF">442,207 μs</td><td align="right" bgcolor="#FFFFFF">348,602 μs</td><td align="right" bgcolor="#FFFFFF">350,886 μs</td><td align="right" bgcolor="#FFFFFF">351,396 μs</td><td align="right" bgcolor="#FFFFFF">437,911 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,435 ms</td><td align="right" bgcolor="#FFFFFF">0,442 ms</td><td align="right" bgcolor="#FFFFFF">0,349 ms</td><td align="right" bgcolor="#FFFFFF">0,351 ms</td><td align="right" bgcolor="#FFFFFF">0,351 ms</td><td align="right" bgcolor="#FFFFFF">0,438 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#A8D08D">5,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FF4949">6,000 (Δ = +1,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,500 (Δ = -0,500)</td><td align="right" bgcolor="#FFFFFF">2,500</td><td align="right" bgcolor="#FFFFFF">2,500</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +0,500)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">-23,3 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+30,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20499,000</td><td align="right" bgcolor="#A8D08D">20498,500 (Δ = -0,500)</td><td align="right" bgcolor="#A8D08D">15728,000 (Δ = -4770,500)</td><td align="right" bgcolor="#A8D08D">15727,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">15727,000</td><td align="right" bgcolor="#FF4949">20538,000 (Δ = +4811,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">20,019</td><td align="right" bgcolor="#A8D08D">20,018 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">15,359 (Δ = -4,659)</td><td align="right" bgcolor="#A8D08D">15,358 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">15,358</td><td align="right" bgcolor="#FF4949">20,057 (Δ = +4,698)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,015 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">0,015 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,015</td><td align="right" bgcolor="#FF4949">0,020 (Δ = +0,005)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 421,318 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2576,663 ns</td><td align="right" bgcolor="#FFFFFF">2570,526 ns</td><td align="right" bgcolor="#FF4949">2977,380 ns (Δ = +406,854 ns)</td><td align="right" bgcolor="#FFFFFF">2985,053 ns</td><td align="right" bgcolor="#FFFFFF">2991,844 ns</td><td align="right" bgcolor="#A8D08D">2709,712 ns (Δ = -282,132 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,577 μs</td><td align="right" bgcolor="#FFFFFF">2,571 μs</td><td align="right" bgcolor="#FFFFFF">2,977 μs</td><td align="right" bgcolor="#FFFFFF">2,985 μs</td><td align="right" bgcolor="#FFFFFF">2,992 μs</td><td align="right" bgcolor="#FFFFFF">2,710 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1038,500</td><td align="right" bgcolor="#FFFFFF">1038,500</td><td align="right" bgcolor="#A8D08D">907,500 (Δ = -131,000)</td><td align="right" bgcolor="#FFFFFF">907,500</td><td align="right" bgcolor="#FFFFFF">907,500</td><td align="right" bgcolor="#FF4949">1065,000 (Δ = +157,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,014</td><td align="right" bgcolor="#FFFFFF">1,014</td><td align="right" bgcolor="#A8D08D">0,886 (Δ = -0,128)</td><td align="right" bgcolor="#FFFFFF">0,886</td><td align="right" bgcolor="#FFFFFF">0,886</td><td align="right" bgcolor="#FF4949">1,040 (Δ = +0,154)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 598,522 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7620,196 ns</td><td align="right" bgcolor="#FFFFFF">7593,611 ns</td><td align="right" bgcolor="#FF4949">7965,688 ns (Δ = +372,077 ns)</td><td align="right" bgcolor="#FFFFFF">7936,988 ns</td><td align="right" bgcolor="#FFFFFF">8057,353 ns</td><td align="right" bgcolor="#A8D08D">7458,830 ns (Δ = -598,522 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,620 μs</td><td align="right" bgcolor="#FFFFFF">7,594 μs</td><td align="right" bgcolor="#FFFFFF">7,966 μs</td><td align="right" bgcolor="#FFFFFF">7,937 μs</td><td align="right" bgcolor="#FFFFFF">8,057 μs</td><td align="right" bgcolor="#FFFFFF">7,459 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+29,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#A8D08D">596,000 (Δ = -174,000)</td><td align="right" bgcolor="#FFFFFF">596,000</td><td align="right" bgcolor="#FFFFFF">596,000</td><td align="right" bgcolor="#FF4949">770,000 (Δ = +174,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#A8D08D">0,582 (Δ = -0,170)</td><td align="right" bgcolor="#FFFFFF">0,582</td><td align="right" bgcolor="#FFFFFF">0,582</td><td align="right" bgcolor="#FF4949">0,752 (Δ = +0,170)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Product"></a>Product

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 513,878 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9610,826 ns</td><td align="right" bgcolor="#FF4949">9970,353 ns (Δ = +359,527 ns)</td><td align="right" bgcolor="#FFFFFF">9738,547 ns</td><td align="right" bgcolor="#FFFFFF">9929,430 ns</td><td align="right" bgcolor="#FFFFFF">9806,227 ns</td><td align="right" bgcolor="#A8D08D">9456,475 ns (Δ = -349,752 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,611 μs</td><td align="right" bgcolor="#FFFFFF">9,970 μs</td><td align="right" bgcolor="#FFFFFF">9,739 μs</td><td align="right" bgcolor="#FFFFFF">9,929 μs</td><td align="right" bgcolor="#FFFFFF">9,806 μs</td><td align="right" bgcolor="#FFFFFF">9,456 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">647,000 (Δ = -205,000)</td><td align="right" bgcolor="#FFFFFF">647,000</td><td align="right" bgcolor="#FFFFFF">647,000</td><td align="right" bgcolor="#FF4949">852,000 (Δ = +205,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,632 (Δ = -0,200)</td><td align="right" bgcolor="#FFFFFF">0,632</td><td align="right" bgcolor="#FFFFFF">0,632</td><td align="right" bgcolor="#FF4949">0,832 (Δ = +0,200)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Title"></a>Title

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 1602,710 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">10961,523 ns</td><td align="right" bgcolor="#A8D08D">9678,178 ns (Δ = -1283,346 ns)</td><td align="right" bgcolor="#FFFFFF">9683,475 ns</td><td align="right" bgcolor="#FFFFFF">9599,178 ns</td><td align="right" bgcolor="#FFFFFF">9622,621 ns</td><td align="right" bgcolor="#A8D08D">9358,813 ns (Δ = -263,807 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">10,962 μs</td><td align="right" bgcolor="#FFFFFF">9,678 μs</td><td align="right" bgcolor="#FFFFFF">9,683 μs</td><td align="right" bgcolor="#FFFFFF">9,599 μs</td><td align="right" bgcolor="#FFFFFF">9,623 μs</td><td align="right" bgcolor="#FFFFFF">9,359 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">647,000 (Δ = -205,000)</td><td align="right" bgcolor="#FFFFFF">647,000</td><td align="right" bgcolor="#FFFFFF">647,000</td><td align="right" bgcolor="#FF4949">852,000 (Δ = +205,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,632 (Δ = -0,200)</td><td align="right" bgcolor="#FFFFFF">0,632</td><td align="right" bgcolor="#FFFFFF">0,632</td><td align="right" bgcolor="#FF4949">0,832 (Δ = +0,200)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Version"></a>Version

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 51,767 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1000,306 ns</td><td align="right" bgcolor="#FFFFFF">1007,574 ns</td><td align="right" bgcolor="#FFFFFF">955,807 ns</td><td align="right" bgcolor="#FFFFFF">959,261 ns</td><td align="right" bgcolor="#FFFFFF">962,298 ns</td><td align="right" bgcolor="#FFFFFF">972,908 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,000 μs</td><td align="right" bgcolor="#FFFFFF">1,008 μs</td><td align="right" bgcolor="#FFFFFF">0,956 μs</td><td align="right" bgcolor="#FFFFFF">0,959 μs</td><td align="right" bgcolor="#FFFFFF">0,962 μs</td><td align="right" bgcolor="#FFFFFF">0,973 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1249,500</td><td align="right" bgcolor="#FFFFFF">1249,500</td><td align="right" bgcolor="#A8D08D">1073,500 (Δ = -176,000)</td><td align="right" bgcolor="#FFFFFF">1073,500</td><td align="right" bgcolor="#FFFFFF">1073,500</td><td align="right" bgcolor="#FF4949">1266,000 (Δ = +192,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,220</td><td align="right" bgcolor="#FFFFFF">1,220</td><td align="right" bgcolor="#A8D08D">1,048 (Δ = -0,172)</td><td align="right" bgcolor="#FFFFFF">1,048</td><td align="right" bgcolor="#FFFFFF">1,048</td><td align="right" bgcolor="#FF4949">1,236 (Δ = +0,188)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 234,962 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2555,938 ns</td><td align="right" bgcolor="#FFFFFF">2531,374 ns</td><td align="right" bgcolor="#FFFFFF">2760,574 ns</td><td align="right" bgcolor="#FFFFFF">2761,518 ns</td><td align="right" bgcolor="#FFFFFF">2766,336 ns</td><td align="right" bgcolor="#FFFFFF">2574,412 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,556 μs</td><td align="right" bgcolor="#FFFFFF">2,531 μs</td><td align="right" bgcolor="#FFFFFF">2,761 μs</td><td align="right" bgcolor="#FFFFFF">2,762 μs</td><td align="right" bgcolor="#FFFFFF">2,766 μs</td><td align="right" bgcolor="#FFFFFF">2,574 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">188,500 (Δ = -61,500)</td><td align="right" bgcolor="#FFFFFF">188,500</td><td align="right" bgcolor="#FFFFFF">188,500</td><td align="right" bgcolor="#FF4949">250,000 (Δ = +61,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,184 (Δ = -0,060)</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FF4949">0,244 (Δ = +0,060)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 187,793 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3347,284 ns</td><td align="right" bgcolor="#FFFFFF">3350,742 ns</td><td align="right" bgcolor="#FFFFFF">3485,248 ns</td><td align="right" bgcolor="#FFFFFF">3471,325 ns</td><td align="right" bgcolor="#FFFFFF">3470,682 ns</td><td align="right" bgcolor="#FFFFFF">3535,077 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,347 μs</td><td align="right" bgcolor="#FFFFFF">3,351 μs</td><td align="right" bgcolor="#FFFFFF">3,485 μs</td><td align="right" bgcolor="#FFFFFF">3,471 μs</td><td align="right" bgcolor="#FFFFFF">3,471 μs</td><td align="right" bgcolor="#FFFFFF">3,535 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">213,000 (Δ = -70,000)</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FF4949">283,000 (Δ = +70,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,208 (Δ = -0,068)</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FF4949">0,276 (Δ = +0,068)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 231,193 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2646,364 ns</td><td align="right" bgcolor="#FFFFFF">2587,581 ns</td><td align="right" bgcolor="#FFFFFF">2816,280 ns</td><td align="right" bgcolor="#FFFFFF">2804,356 ns</td><td align="right" bgcolor="#FFFFFF">2818,774 ns</td><td align="right" bgcolor="#FFFFFF">2673,833 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,646 μs</td><td align="right" bgcolor="#FFFFFF">2,588 μs</td><td align="right" bgcolor="#FFFFFF">2,816 μs</td><td align="right" bgcolor="#FFFFFF">2,804 μs</td><td align="right" bgcolor="#FFFFFF">2,819 μs</td><td align="right" bgcolor="#FFFFFF">2,674 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">188,500 (Δ = -61,500)</td><td align="right" bgcolor="#FFFFFF">188,500</td><td align="right" bgcolor="#FFFFFF">188,500</td><td align="right" bgcolor="#FF4949">250,000 (Δ = +61,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,184 (Δ = -0,060)</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FF4949">0,244 (Δ = +0,060)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 133,401 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3387,625 ns</td><td align="right" bgcolor="#FFFFFF">3404,425 ns</td><td align="right" bgcolor="#FFFFFF">3519,418 ns</td><td align="right" bgcolor="#FFFFFF">3489,312 ns</td><td align="right" bgcolor="#FFFFFF">3521,026 ns</td><td align="right" bgcolor="#FFFFFF">3519,835 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,388 μs</td><td align="right" bgcolor="#FFFFFF">3,404 μs</td><td align="right" bgcolor="#FFFFFF">3,519 μs</td><td align="right" bgcolor="#FFFFFF">3,489 μs</td><td align="right" bgcolor="#FFFFFF">3,521 μs</td><td align="right" bgcolor="#FFFFFF">3,520 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">213,000 (Δ = -70,000)</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FF4949">283,000 (Δ = +70,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,208 (Δ = -0,068)</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FF4949">0,276 (Δ = +0,068)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 254,089 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2578,618 ns</td><td align="right" bgcolor="#FFFFFF">2541,976 ns</td><td align="right" bgcolor="#FFFFFF">2790,586 ns</td><td align="right" bgcolor="#FFFFFF">2752,798 ns</td><td align="right" bgcolor="#FFFFFF">2796,065 ns</td><td align="right" bgcolor="#FFFFFF">2595,903 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,579 μs</td><td align="right" bgcolor="#FFFFFF">2,542 μs</td><td align="right" bgcolor="#FFFFFF">2,791 μs</td><td align="right" bgcolor="#FFFFFF">2,753 μs</td><td align="right" bgcolor="#FFFFFF">2,796 μs</td><td align="right" bgcolor="#FFFFFF">2,596 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">188,500 (Δ = -61,500)</td><td align="right" bgcolor="#FFFFFF">188,500</td><td align="right" bgcolor="#FFFFFF">188,500</td><td align="right" bgcolor="#FF4949">250,000 (Δ = +61,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,184 (Δ = -0,060)</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FF4949">0,244 (Δ = +0,060)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 128,633 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3455,440 ns</td><td align="right" bgcolor="#FFFFFF">3397,668 ns</td><td align="right" bgcolor="#FFFFFF">3492,533 ns</td><td align="right" bgcolor="#FFFFFF">3526,301 ns</td><td align="right" bgcolor="#FFFFFF">3501,953 ns</td><td align="right" bgcolor="#FFFFFF">3515,208 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,455 μs</td><td align="right" bgcolor="#FFFFFF">3,398 μs</td><td align="right" bgcolor="#FFFFFF">3,493 μs</td><td align="right" bgcolor="#FFFFFF">3,526 μs</td><td align="right" bgcolor="#FFFFFF">3,502 μs</td><td align="right" bgcolor="#FFFFFF">3,515 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">213,000 (Δ = -70,000)</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FF4949">283,000 (Δ = +70,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,208 (Δ = -0,068)</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FF4949">0,276 (Δ = +0,068)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 249,831 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2594,431 ns</td><td align="right" bgcolor="#FFFFFF">2582,142 ns</td><td align="right" bgcolor="#FFFFFF">2831,973 ns</td><td align="right" bgcolor="#FFFFFF">2765,410 ns</td><td align="right" bgcolor="#FFFFFF">2816,083 ns</td><td align="right" bgcolor="#FFFFFF">2589,443 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,594 μs</td><td align="right" bgcolor="#FFFFFF">2,582 μs</td><td align="right" bgcolor="#FFFFFF">2,832 μs</td><td align="right" bgcolor="#FFFFFF">2,765 μs</td><td align="right" bgcolor="#FFFFFF">2,816 μs</td><td align="right" bgcolor="#FFFFFF">2,589 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">188,500 (Δ = -61,500)</td><td align="right" bgcolor="#FFFFFF">188,500</td><td align="right" bgcolor="#FFFFFF">188,500</td><td align="right" bgcolor="#FF4949">250,000 (Δ = +61,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,184 (Δ = -0,060)</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FF4949">0,244 (Δ = +0,060)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 135,061 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3403,945 ns</td><td align="right" bgcolor="#FFFFFF">3393,664 ns</td><td align="right" bgcolor="#FFFFFF">3528,725 ns</td><td align="right" bgcolor="#FFFFFF">3493,206 ns</td><td align="right" bgcolor="#FFFFFF">3505,236 ns</td><td align="right" bgcolor="#FFFFFF">3512,955 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,404 μs</td><td align="right" bgcolor="#FFFFFF">3,394 μs</td><td align="right" bgcolor="#FFFFFF">3,529 μs</td><td align="right" bgcolor="#FFFFFF">3,493 μs</td><td align="right" bgcolor="#FFFFFF">3,505 μs</td><td align="right" bgcolor="#FFFFFF">3,513 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">213,000 (Δ = -70,000)</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FF4949">283,000 (Δ = +70,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,208 (Δ = -0,068)</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FF4949">0,276 (Δ = +0,068)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 278,718 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2566,989 ns</td><td align="right" bgcolor="#FFFFFF">2533,157 ns</td><td align="right" bgcolor="#FF4949">2811,875 ns (Δ = +278,718 ns)</td><td align="right" bgcolor="#FFFFFF">2742,788 ns</td><td align="right" bgcolor="#FFFFFF">2772,994 ns</td><td align="right" bgcolor="#FFFFFF">2552,732 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,567 μs</td><td align="right" bgcolor="#FFFFFF">2,533 μs</td><td align="right" bgcolor="#FFFFFF">2,812 μs</td><td align="right" bgcolor="#FFFFFF">2,743 μs</td><td align="right" bgcolor="#FFFFFF">2,773 μs</td><td align="right" bgcolor="#FFFFFF">2,553 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">188,500 (Δ = -61,500)</td><td align="right" bgcolor="#FFFFFF">188,500</td><td align="right" bgcolor="#FFFFFF">188,500</td><td align="right" bgcolor="#FF4949">250,000 (Δ = +61,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,184 (Δ = -0,060)</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FF4949">0,244 (Δ = +0,060)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 591,714 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+13,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3331,716 ns</td><td align="right" bgcolor="#FFFFFF">3348,013 ns</td><td align="right" bgcolor="#FFFFFF">3483,080 ns</td><td align="right" bgcolor="#FFFFFF">3531,662 ns</td><td align="right" bgcolor="#FFFFFF">3465,528 ns</td><td align="right" bgcolor="#FF4949">3923,430 ns (Δ = +457,902 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,332 μs</td><td align="right" bgcolor="#FFFFFF">3,348 μs</td><td align="right" bgcolor="#FFFFFF">3,483 μs</td><td align="right" bgcolor="#FFFFFF">3,532 μs</td><td align="right" bgcolor="#FFFFFF">3,466 μs</td><td align="right" bgcolor="#FFFFFF">3,923 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">213,000 (Δ = -70,000)</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FF4949">283,000 (Δ = +70,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,208 (Δ = -0,068)</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FF4949">0,276 (Δ = +0,068)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 212,501 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2667,967 ns</td><td align="right" bgcolor="#FFFFFF">2636,335 ns</td><td align="right" bgcolor="#FFFFFF">2820,091 ns</td><td align="right" bgcolor="#FFFFFF">2822,175 ns</td><td align="right" bgcolor="#FFFFFF">2848,836 ns</td><td align="right" bgcolor="#FFFFFF">2667,885 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,668 μs</td><td align="right" bgcolor="#FFFFFF">2,636 μs</td><td align="right" bgcolor="#FFFFFF">2,820 μs</td><td align="right" bgcolor="#FFFFFF">2,822 μs</td><td align="right" bgcolor="#FFFFFF">2,849 μs</td><td align="right" bgcolor="#FFFFFF">2,668 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">188,500 (Δ = -61,500)</td><td align="right" bgcolor="#FFFFFF">188,500</td><td align="right" bgcolor="#FFFFFF">188,500</td><td align="right" bgcolor="#FF4949">250,000 (Δ = +61,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,184 (Δ = -0,060)</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FF4949">0,244 (Δ = +0,060)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 403,568 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,5 %</td><td align="right" bgcolor="#A8D08D">-6,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3398,418 ns</td><td align="right" bgcolor="#FFFFFF">3436,842 ns</td><td align="right" bgcolor="#FFFFFF">3536,121 ns</td><td align="right" bgcolor="#FF4949">3801,987 ns (Δ = +265,865 ns)</td><td align="right" bgcolor="#A8D08D">3543,058 ns (Δ = -258,928 ns)</td><td align="right" bgcolor="#FFFFFF">3513,868 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,398 μs</td><td align="right" bgcolor="#FFFFFF">3,437 μs</td><td align="right" bgcolor="#FFFFFF">3,536 μs</td><td align="right" bgcolor="#FFFFFF">3,802 μs</td><td align="right" bgcolor="#FFFFFF">3,543 μs</td><td align="right" bgcolor="#FFFFFF">3,514 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">213,000 (Δ = -70,000)</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FF4949">283,000 (Δ = +70,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,208 (Δ = -0,068)</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FF4949">0,276 (Δ = +0,068)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 15,814 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">232,822 ns</td><td align="right" bgcolor="#FFFFFF">236,755 ns</td><td align="right" bgcolor="#FFFFFF">248,351 ns</td><td align="right" bgcolor="#FFFFFF">246,873 ns</td><td align="right" bgcolor="#FFFFFF">248,636 ns</td><td align="right" bgcolor="#FFFFFF">240,917 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td><td align="right" bgcolor="#FFFFFF">0,248 μs</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td><td align="right" bgcolor="#FFFFFF">0,249 μs</td><td align="right" bgcolor="#FFFFFF">0,241 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -53,000)</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FF4949">217,000 (Δ = +53,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,052)</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FF4949">0,212 (Δ = +0,052)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 13,657 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">247,315 ns</td><td align="right" bgcolor="#FFFFFF">239,057 ns</td><td align="right" bgcolor="#FFFFFF">252,667 ns</td><td align="right" bgcolor="#FFFFFF">252,598 ns</td><td align="right" bgcolor="#FFFFFF">252,714 ns</td><td align="right" bgcolor="#FFFFFF">245,128 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td><td align="right" bgcolor="#FFFFFF">0,239 μs</td><td align="right" bgcolor="#FFFFFF">0,253 μs</td><td align="right" bgcolor="#FFFFFF">0,253 μs</td><td align="right" bgcolor="#FFFFFF">0,253 μs</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+30,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#A8D08D">106,500 (Δ = -32,500)</td><td align="right" bgcolor="#FFFFFF">106,500</td><td align="right" bgcolor="#FFFFFF">106,500</td><td align="right" bgcolor="#FF4949">139,000 (Δ = +32,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#A8D08D">0,104 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,104</td><td align="right" bgcolor="#FFFFFF">0,104</td><td align="right" bgcolor="#FF4949">0,136 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 11,758 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">245,349 ns</td><td align="right" bgcolor="#FFFFFF">242,950 ns</td><td align="right" bgcolor="#FFFFFF">254,681 ns</td><td align="right" bgcolor="#FFFFFF">254,708 ns</td><td align="right" bgcolor="#FFFFFF">254,704 ns</td><td align="right" bgcolor="#FFFFFF">247,295 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td><td align="right" bgcolor="#FFFFFF">0,243 μs</td><td align="right" bgcolor="#FFFFFF">0,255 μs</td><td align="right" bgcolor="#FFFFFF">0,255 μs</td><td align="right" bgcolor="#FFFFFF">0,255 μs</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+30,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#A8D08D">106,500 (Δ = -32,500)</td><td align="right" bgcolor="#FFFFFF">106,500</td><td align="right" bgcolor="#FFFFFF">106,500</td><td align="right" bgcolor="#FF4949">139,000 (Δ = +32,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#A8D08D">0,104 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,104</td><td align="right" bgcolor="#FFFFFF">0,104</td><td align="right" bgcolor="#FF4949">0,136 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 13,645 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">221,224 ns</td><td align="right" bgcolor="#FFFFFF">223,838 ns</td><td align="right" bgcolor="#FFFFFF">234,869 ns</td><td align="right" bgcolor="#FFFFFF">232,143 ns</td><td align="right" bgcolor="#FFFFFF">234,024 ns</td><td align="right" bgcolor="#FFFFFF">226,952 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,224 μs</td><td align="right" bgcolor="#FFFFFF">0,235 μs</td><td align="right" bgcolor="#FFFFFF">0,232 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">92,000 (Δ = -31,000)</td><td align="right" bgcolor="#FFFFFF">92,000</td><td align="right" bgcolor="#FFFFFF">92,000</td><td align="right" bgcolor="#FF4949">123,000 (Δ = +31,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#A8D08D">0,090 (Δ = -0,030)</td><td align="right" bgcolor="#FFFFFF">0,090</td><td align="right" bgcolor="#FFFFFF">0,090</td><td align="right" bgcolor="#FF4949">0,120 (Δ = +0,030)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 22,157 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">222,239 ns</td><td align="right" bgcolor="#FFFFFF">221,878 ns</td><td align="right" bgcolor="#FFFFFF">232,994 ns</td><td align="right" bgcolor="#FFFFFF">234,095 ns</td><td align="right" bgcolor="#FFFFFF">244,035 ns</td><td align="right" bgcolor="#FFFFFF">225,362 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,222 μs</td><td align="right" bgcolor="#FFFFFF">0,222 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td><td align="right" bgcolor="#FFFFFF">0,225 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">92,000 (Δ = -31,000)</td><td align="right" bgcolor="#FFFFFF">92,000</td><td align="right" bgcolor="#FFFFFF">92,000</td><td align="right" bgcolor="#FF4949">123,000 (Δ = +31,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#A8D08D">0,090 (Δ = -0,030)</td><td align="right" bgcolor="#FFFFFF">0,090</td><td align="right" bgcolor="#FFFFFF">0,090</td><td align="right" bgcolor="#FF4949">0,120 (Δ = +0,030)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 15,605 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">234,917 ns</td><td align="right" bgcolor="#FFFFFF">238,708 ns</td><td align="right" bgcolor="#FFFFFF">250,522 ns</td><td align="right" bgcolor="#FFFFFF">247,534 ns</td><td align="right" bgcolor="#FFFFFF">248,232 ns</td><td align="right" bgcolor="#FFFFFF">241,675 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,235 μs</td><td align="right" bgcolor="#FFFFFF">0,239 μs</td><td align="right" bgcolor="#FFFFFF">0,251 μs</td><td align="right" bgcolor="#FFFFFF">0,248 μs</td><td align="right" bgcolor="#FFFFFF">0,248 μs</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -53,000)</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FF4949">217,000 (Δ = +53,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,052)</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FF4949">0,212 (Δ = +0,052)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 68,293 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">862,321 ns</td><td align="right" bgcolor="#FFFFFF">847,678 ns</td><td align="right" bgcolor="#FFFFFF">888,413 ns</td><td align="right" bgcolor="#FFFFFF">915,971 ns</td><td align="right" bgcolor="#FFFFFF">901,447 ns</td><td align="right" bgcolor="#FFFFFF">860,483 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,862 μs</td><td align="right" bgcolor="#FFFFFF">0,848 μs</td><td align="right" bgcolor="#FFFFFF">0,888 μs</td><td align="right" bgcolor="#FFFFFF">0,916 μs</td><td align="right" bgcolor="#FFFFFF">0,901 μs</td><td align="right" bgcolor="#FFFFFF">0,860 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">188,000</td><td align="right" bgcolor="#FFFFFF">188,000</td><td align="right" bgcolor="#A8D08D">141,000 (Δ = -47,000)</td><td align="right" bgcolor="#FFFFFF">141,000</td><td align="right" bgcolor="#FFFFFF">141,000</td><td align="right" bgcolor="#FF4949">188,000 (Δ = +47,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#A8D08D">0,138 (Δ = -0,046)</td><td align="right" bgcolor="#FFFFFF">0,138</td><td align="right" bgcolor="#FFFFFF">0,138</td><td align="right" bgcolor="#FF4949">0,184 (Δ = +0,046)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 33,104 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">119,546 ns</td><td align="right" bgcolor="#FFFFFF">118,998 ns</td><td align="right" bgcolor="#FFFFFF">151,688 ns</td><td align="right" bgcolor="#FFFFFF">125,562 ns</td><td align="right" bgcolor="#FFFFFF">125,261 ns</td><td align="right" bgcolor="#FFFFFF">118,583 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td><td align="right" bgcolor="#FFFFFF">0,152 μs</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+35,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">18,500 (Δ = -6,500)</td><td align="right" bgcolor="#FFFFFF">18,500</td><td align="right" bgcolor="#FFFFFF">18,500</td><td align="right" bgcolor="#FF4949">25,000 (Δ = +6,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,018 (Δ = -0,006)</td><td align="right" bgcolor="#FFFFFF">0,018</td><td align="right" bgcolor="#FFFFFF">0,018</td><td align="right" bgcolor="#FF4949">0,024 (Δ = +0,006)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_GetName_Long"></a>GetName_Long

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 5,517 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">139,906 ns</td><td align="right" bgcolor="#FFFFFF">137,985 ns</td><td align="right" bgcolor="#FFFFFF">143,502 ns</td><td align="right" bgcolor="#FFFFFF">143,487 ns</td><td align="right" bgcolor="#FFFFFF">142,521 ns</td><td align="right" bgcolor="#FFFFFF">138,447 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-18,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">20,500 (Δ = -4,500)</td><td align="right" bgcolor="#FFFFFF">20,500</td><td align="right" bgcolor="#FFFFFF">20,500</td><td align="right" bgcolor="#FF4949">25,000 (Δ = +4,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FF4949">0,024 (Δ = +0,004)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_GetNames"></a>GetNames

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 173,483 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2014,469 ns</td><td align="right" bgcolor="#FFFFFF">2015,074 ns</td><td align="right" bgcolor="#FFFFFF">1918,972 ns</td><td align="right" bgcolor="#FFFFFF">1941,500 ns</td><td align="right" bgcolor="#FFFFFF">1929,053 ns</td><td align="right" bgcolor="#FFFFFF">2092,455 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,014 μs</td><td align="right" bgcolor="#FFFFFF">2,015 μs</td><td align="right" bgcolor="#FFFFFF">1,919 μs</td><td align="right" bgcolor="#FFFFFF">1,942 μs</td><td align="right" bgcolor="#FFFFFF">1,929 μs</td><td align="right" bgcolor="#FFFFFF">2,092 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">913,000</td><td align="right" bgcolor="#FFFFFF">913,000</td><td align="right" bgcolor="#A8D08D">690,000 (Δ = -223,000)</td><td align="right" bgcolor="#FFFFFF">690,000</td><td align="right" bgcolor="#FFFFFF">690,000</td><td align="right" bgcolor="#FF4949">913,000 (Δ = +223,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,892</td><td align="right" bgcolor="#FFFFFF">0,892</td><td align="right" bgcolor="#A8D08D">0,674 (Δ = -0,218)</td><td align="right" bgcolor="#FFFFFF">0,674</td><td align="right" bgcolor="#FFFFFF">0,674</td><td align="right" bgcolor="#FF4949">0,892 (Δ = +0,218)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_GetValues"></a>GetValues

#### Performance

Fastest: **5.2.0**

Slowest: 5.1.0

Δ: 490,937 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,6 %</td><td align="right" bgcolor="#A8D08D">-11,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3763,666 ns</td><td align="right" bgcolor="#FFFFFF">3782,922 ns</td><td align="right" bgcolor="#FF4949">4223,371 ns (Δ = +440,449 ns)</td><td align="right" bgcolor="#A8D08D">3732,433 ns (Δ = -490,937 ns)</td><td align="right" bgcolor="#FFFFFF">3769,047 ns</td><td align="right" bgcolor="#FFFFFF">3986,737 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,764 μs</td><td align="right" bgcolor="#FFFFFF">3,783 μs</td><td align="right" bgcolor="#FFFFFF">4,223 μs</td><td align="right" bgcolor="#FFFFFF">3,732 μs</td><td align="right" bgcolor="#FFFFFF">3,769 μs</td><td align="right" bgcolor="#FFFFFF">3,987 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+30,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1106,000</td><td align="right" bgcolor="#FFFFFF">1106,000</td><td align="right" bgcolor="#A8D08D">850,000 (Δ = -256,000)</td><td align="right" bgcolor="#FFFFFF">850,000</td><td align="right" bgcolor="#FFFFFF">850,000</td><td align="right" bgcolor="#FF4949">1106,000 (Δ = +256,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,080</td><td align="right" bgcolor="#FFFFFF">1,080</td><td align="right" bgcolor="#A8D08D">0,830 (Δ = -0,250)</td><td align="right" bgcolor="#FFFFFF">0,830</td><td align="right" bgcolor="#FFFFFF">0,830</td><td align="right" bgcolor="#FF4949">1,080 (Δ = +0,250)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 21,524 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">273,273 ns</td><td align="right" bgcolor="#FFFFFF">278,783 ns</td><td align="right" bgcolor="#FFFFFF">291,278 ns</td><td align="right" bgcolor="#FFFFFF">293,363 ns</td><td align="right" bgcolor="#FFFFFF">294,798 ns</td><td align="right" bgcolor="#FFFFFF">273,535 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,273 μs</td><td align="right" bgcolor="#FFFFFF">0,279 μs</td><td align="right" bgcolor="#FFFFFF">0,291 μs</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,295 μs</td><td align="right" bgcolor="#FFFFFF">0,274 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">86,000 (Δ = -29,000)</td><td align="right" bgcolor="#FFFFFF">86,000</td><td align="right" bgcolor="#FFFFFF">86,000</td><td align="right" bgcolor="#FF4949">115,000 (Δ = +29,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,084 (Δ = -0,028)</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#FF4949">0,112 (Δ = +0,028)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_ToList"></a>ToList

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 163,174 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3883,730 ns</td><td align="right" bgcolor="#FFFFFF">3856,188 ns</td><td align="right" bgcolor="#FFFFFF">3755,429 ns</td><td align="right" bgcolor="#FFFFFF">3853,730 ns</td><td align="right" bgcolor="#FFFFFF">3838,891 ns</td><td align="right" bgcolor="#FFFFFF">3918,603 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,884 μs</td><td align="right" bgcolor="#FFFFFF">3,856 μs</td><td align="right" bgcolor="#FFFFFF">3,755 μs</td><td align="right" bgcolor="#FFFFFF">3,854 μs</td><td align="right" bgcolor="#FFFFFF">3,839 μs</td><td align="right" bgcolor="#FFFFFF">3,919 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+29,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1196,000</td><td align="right" bgcolor="#FFFFFF">1196,000</td><td align="right" bgcolor="#A8D08D">923,500 (Δ = -272,500)</td><td align="right" bgcolor="#FFFFFF">923,500</td><td align="right" bgcolor="#FFFFFF">923,500</td><td align="right" bgcolor="#FF4949">1196,000 (Δ = +272,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,168</td><td align="right" bgcolor="#FFFFFF">1,168</td><td align="right" bgcolor="#A8D08D">0,902 (Δ = -0,266)</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FFFFFF">0,902</td><td align="right" bgcolor="#FF4949">1,168 (Δ = +0,266)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_TryParse"></a>TryParse

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 17,212 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">293,407 ns</td><td align="right" bgcolor="#FFFFFF">289,657 ns</td><td align="right" bgcolor="#FFFFFF">305,478 ns</td><td align="right" bgcolor="#FFFFFF">305,957 ns</td><td align="right" bgcolor="#FFFFFF">304,878 ns</td><td align="right" bgcolor="#FFFFFF">288,745 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,290 μs</td><td align="right" bgcolor="#FFFFFF">0,305 μs</td><td align="right" bgcolor="#FFFFFF">0,306 μs</td><td align="right" bgcolor="#FFFFFF">0,305 μs</td><td align="right" bgcolor="#FFFFFF">0,289 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">86,000 (Δ = -29,000)</td><td align="right" bgcolor="#FFFFFF">86,000</td><td align="right" bgcolor="#FFFFFF">86,000</td><td align="right" bgcolor="#FF4949">115,000 (Δ = +29,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,084 (Δ = -0,028)</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#FF4949">0,112 (Δ = +0,028)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase"></a>TryParse_IgnoreCase

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 21,148 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">293,445 ns</td><td align="right" bgcolor="#FFFFFF">292,444 ns</td><td align="right" bgcolor="#FFFFFF">306,921 ns</td><td align="right" bgcolor="#FFFFFF">308,000 ns</td><td align="right" bgcolor="#FFFFFF">309,281 ns</td><td align="right" bgcolor="#FFFFFF">288,133 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td><td align="right" bgcolor="#FFFFFF">0,307 μs</td><td align="right" bgcolor="#FFFFFF">0,308 μs</td><td align="right" bgcolor="#FFFFFF">0,309 μs</td><td align="right" bgcolor="#FFFFFF">0,288 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">86,000 (Δ = -29,000)</td><td align="right" bgcolor="#FFFFFF">86,000</td><td align="right" bgcolor="#FFFFFF">86,000</td><td align="right" bgcolor="#FF4949">115,000 (Δ = +29,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,084 (Δ = -0,028)</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#FF4949">0,112 (Δ = +0,028)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase_Nullable"></a>TryParse_IgnoreCase_Nullable

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 21,958 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">285,802 ns</td><td align="right" bgcolor="#FFFFFF">291,316 ns</td><td align="right" bgcolor="#FFFFFF">304,743 ns</td><td align="right" bgcolor="#FFFFFF">305,160 ns</td><td align="right" bgcolor="#FFFFFF">307,760 ns</td><td align="right" bgcolor="#FFFFFF">288,372 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,291 μs</td><td align="right" bgcolor="#FFFFFF">0,305 μs</td><td align="right" bgcolor="#FFFFFF">0,305 μs</td><td align="right" bgcolor="#FFFFFF">0,308 μs</td><td align="right" bgcolor="#FFFFFF">0,288 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">86,000 (Δ = -29,000)</td><td align="right" bgcolor="#FFFFFF">86,000</td><td align="right" bgcolor="#FFFFFF">86,000</td><td align="right" bgcolor="#FF4949">115,000 (Δ = +29,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,084 (Δ = -0,028)</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#FF4949">0,112 (Δ = +0,028)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 28,043 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">286,288 ns</td><td align="right" bgcolor="#FFFFFF">285,685 ns</td><td align="right" bgcolor="#FFFFFF">305,503 ns</td><td align="right" bgcolor="#FFFFFF">313,728 ns</td><td align="right" bgcolor="#FFFFFF">303,710 ns</td><td align="right" bgcolor="#FFFFFF">285,733 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,306 μs</td><td align="right" bgcolor="#FFFFFF">0,314 μs</td><td align="right" bgcolor="#FFFFFF">0,304 μs</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">86,000 (Δ = -29,000)</td><td align="right" bgcolor="#FFFFFF">86,000</td><td align="right" bgcolor="#FFFFFF">86,000</td><td align="right" bgcolor="#FF4949">115,000 (Δ = +29,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,084 (Δ = -0,028)</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#FF4949">0,112 (Δ = +0,028)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="ExpressionHelper_Benchmark"></a>ExpressionHelper_Benchmark

### <a name="ExpressionHelper_Benchmark_GetOwner"></a>GetOwner

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 195,121 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1942,343 ns</td><td align="right" bgcolor="#FFFFFF">1867,132 ns</td><td align="right" bgcolor="#FFFFFF">1769,510 ns</td><td align="right" bgcolor="#FFFFFF">1875,133 ns</td><td align="right" bgcolor="#FFFFFF">1798,932 ns</td><td align="right" bgcolor="#FFFFFF">1964,632 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,942 μs</td><td align="right" bgcolor="#FFFFFF">1,867 μs</td><td align="right" bgcolor="#FFFFFF">1,770 μs</td><td align="right" bgcolor="#FFFFFF">1,875 μs</td><td align="right" bgcolor="#FFFFFF">1,799 μs</td><td align="right" bgcolor="#FFFFFF">1,965 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#A8D08D">493,500 (Δ = -157,500)</td><td align="right" bgcolor="#FFFFFF">493,500</td><td align="right" bgcolor="#FFFFFF">493,500</td><td align="right" bgcolor="#FF4949">651,000 (Δ = +157,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#A8D08D">0,482 (Δ = -0,154)</td><td align="right" bgcolor="#FFFFFF">0,482</td><td align="right" bgcolor="#FFFFFF">0,482</td><td align="right" bgcolor="#FF4949">0,636 (Δ = +0,154)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="ExpressionHelper_Benchmark_GetPropertyName"></a>GetPropertyName

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 309,682 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3867,687 ns</td><td align="right" bgcolor="#A8D08D">3574,167 ns (Δ = -293,520 ns)</td><td align="right" bgcolor="#FFFFFF">3558,005 ns</td><td align="right" bgcolor="#FFFFFF">3566,435 ns</td><td align="right" bgcolor="#FFFFFF">3584,808 ns</td><td align="right" bgcolor="#FFFFFF">3682,800 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,868 μs</td><td align="right" bgcolor="#FFFFFF">3,574 μs</td><td align="right" bgcolor="#FFFFFF">3,558 μs</td><td align="right" bgcolor="#FFFFFF">3,566 μs</td><td align="right" bgcolor="#FFFFFF">3,585 μs</td><td align="right" bgcolor="#FFFFFF">3,683 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1987,000</td><td align="right" bgcolor="#FFFFFF">1987,000</td><td align="right" bgcolor="#A8D08D">1677,500 (Δ = -309,500)</td><td align="right" bgcolor="#FFFFFF">1677,500</td><td align="right" bgcolor="#FFFFFF">1677,500</td><td align="right" bgcolor="#FF4949">1987,000 (Δ = +309,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,940</td><td align="right" bgcolor="#FFFFFF">1,940</td><td align="right" bgcolor="#A8D08D">1,638 (Δ = -0,302)</td><td align="right" bgcolor="#FFFFFF">1,638</td><td align="right" bgcolor="#FFFFFF">1,638</td><td align="right" bgcolor="#FF4949">1,940 (Δ = +0,302)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


## <a name="FastDateTime_vs_DateTime_Benchmark"></a>FastDateTime_vs_DateTime_Benchmark

### <a name="FastDateTime_vs_DateTime_Benchmark_DateTime_Now"></a>DateTime_Now

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 262,298 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+87,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">286,244 ns</td><td align="right" bgcolor="#FFFFFF">292,092 ns</td><td align="right" bgcolor="#FF4949">548,542 ns (Δ = +256,450 ns)</td><td align="right" bgcolor="#FFFFFF">544,552 ns</td><td align="right" bgcolor="#FFFFFF">543,492 ns</td><td align="right" bgcolor="#FFFFFF">362,556 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td><td align="right" bgcolor="#FFFFFF">0,549 μs</td><td align="right" bgcolor="#FFFFFF">0,545 μs</td><td align="right" bgcolor="#FFFFFF">0,543 μs</td><td align="right" bgcolor="#FFFFFF">0,363 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 29,578 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">44,764 ns</td><td align="right" bgcolor="#FFFFFF">44,361 ns</td><td align="right" bgcolor="#FFFFFF">73,938 ns</td><td align="right" bgcolor="#FFFFFF">72,014 ns</td><td align="right" bgcolor="#FFFFFF">72,976 ns</td><td align="right" bgcolor="#FFFFFF">47,797 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 0,245 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,368 ns</td><td align="right" bgcolor="#FFFFFF">6,366 ns</td><td align="right" bgcolor="#FFFFFF">6,311 ns</td><td align="right" bgcolor="#FFFFFF">6,322 ns</td><td align="right" bgcolor="#FFFFFF">6,522 ns</td><td align="right" bgcolor="#FFFFFF">6,277 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 0,177 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,415 ns</td><td align="right" bgcolor="#FFFFFF">7,415 ns</td><td align="right" bgcolor="#FFFFFF">7,423 ns</td><td align="right" bgcolor="#FFFFFF">7,403 ns</td><td align="right" bgcolor="#FFFFFF">7,579 ns</td><td align="right" bgcolor="#FFFFFF">7,457 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark"></a>FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark

### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashInsert"></a>FastBindingList_BashInsert

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 213,317 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">922,838 ns</td><td align="right" bgcolor="#FFFFFF">1095,700 ns</td><td align="right" bgcolor="#FFFFFF">1133,467 ns</td><td align="right" bgcolor="#FFFFFF">1136,154 ns</td><td align="right" bgcolor="#FFFFFF">1127,829 ns</td><td align="right" bgcolor="#FFFFFF">1131,822 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,923 μs</td><td align="right" bgcolor="#FFFFFF">1,096 μs</td><td align="right" bgcolor="#FFFFFF">1,133 μs</td><td align="right" bgcolor="#FFFFFF">1,136 μs</td><td align="right" bgcolor="#FFFFFF">1,128 μs</td><td align="right" bgcolor="#FFFFFF">1,132 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">4.5.4</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,6 %</td><td align="right" bgcolor="#A8D08D">-6,4 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#FF4949">+21,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">979,000</td><td align="right" bgcolor="#FF4949">1073,000 (Δ = +94,000)</td><td align="right" bgcolor="#A8D08D">1004,000 (Δ = -69,000)</td><td align="right" bgcolor="#A8D08D">1003,500 (Δ = -0,500)</td><td align="right" bgcolor="#FF4949">1004,500 (Δ = +1,000)</td><td align="right" bgcolor="#FF4949">1218,000 (Δ = +213,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,956</td><td align="right" bgcolor="#FF4949">1,048 (Δ = +0,092)</td><td align="right" bgcolor="#A8D08D">0,980 (Δ = -0,067)</td><td align="right" bgcolor="#A8D08D">0,980 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,981 (Δ = +0,001)</td><td align="right" bgcolor="#FF4949">1,189 (Δ = +0,208)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashRemove"></a>FastBindingList_BashRemove

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 77,821 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">442,869 ns</td><td align="right" bgcolor="#FFFFFF">463,171 ns</td><td align="right" bgcolor="#FFFFFF">502,183 ns</td><td align="right" bgcolor="#FFFFFF">494,841 ns</td><td align="right" bgcolor="#FFFFFF">480,388 ns</td><td align="right" bgcolor="#FFFFFF">520,690 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,443 μs</td><td align="right" bgcolor="#FFFFFF">0,463 μs</td><td align="right" bgcolor="#FFFFFF">0,502 μs</td><td align="right" bgcolor="#FFFFFF">0,495 μs</td><td align="right" bgcolor="#FFFFFF">0,480 μs</td><td align="right" bgcolor="#FFFFFF">0,521 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">4.5.4</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#FF4949">+4,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+25,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FF4949">459,000 (Δ = +41,000)</td><td align="right" bgcolor="#FF4949">481,000 (Δ = +22,000)</td><td align="right" bgcolor="#FFFFFF">481,000</td><td align="right" bgcolor="#FFFFFF">481,000</td><td align="right" bgcolor="#FF4949">602,000 (Δ = +121,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FF4949">0,448 (Δ = +0,040)</td><td align="right" bgcolor="#FF4949">0,470 (Δ = +0,021)</td><td align="right" bgcolor="#FFFFFF">0,470</td><td align="right" bgcolor="#FFFFFF">0,470</td><td align="right" bgcolor="#FF4949">0,588 (Δ = +0,118)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastObservableCollection_BashInsert"></a>FastObservableCollection_BashInsert

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 350,784 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2152,764 ns</td><td align="right" bgcolor="#FF4949">2503,548 ns (Δ = +350,784 ns)</td><td align="right" bgcolor="#FFFFFF">2391,638 ns</td><td align="right" bgcolor="#FFFFFF">2257,535 ns</td><td align="right" bgcolor="#FFFFFF">2273,413 ns</td><td align="right" bgcolor="#FFFFFF">2324,728 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,153 μs</td><td align="right" bgcolor="#FFFFFF">2,504 μs</td><td align="right" bgcolor="#FFFFFF">2,392 μs</td><td align="right" bgcolor="#FFFFFF">2,258 μs</td><td align="right" bgcolor="#FFFFFF">2,273 μs</td><td align="right" bgcolor="#FFFFFF">2,325 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,500 (Δ = -0,500)</td><td align="right" bgcolor="#FFFFFF">0,500</td><td align="right" bgcolor="#FFFFFF">0,500</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +0,500)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,5 %</td><td align="right" bgcolor="#A8D08D">-22,3 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+29,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3969,000</td><td align="right" bgcolor="#FF4949">4067,000 (Δ = +98,000)</td><td align="right" bgcolor="#A8D08D">3160,000 (Δ = -907,000)</td><td align="right" bgcolor="#FF4949">3160,500 (Δ = +0,500)</td><td align="right" bgcolor="#FFFFFF">3160,500</td><td align="right" bgcolor="#FF4949">4076,000 (Δ = +915,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,876</td><td align="right" bgcolor="#FF4949">3,972 (Δ = +0,096)</td><td align="right" bgcolor="#A8D08D">3,086 (Δ = -0,886)</td><td align="right" bgcolor="#FF4949">3,086 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">3,086</td><td align="right" bgcolor="#FF4949">3,980 (Δ = +0,894)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FF4949">0,004 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,004 (Δ = +0,001)</td></tr></table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_ObservableCollection_BashInsert"></a>ObservableCollection_BashInsert

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 100,296 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1011,022 ns</td><td align="right" bgcolor="#FFFFFF">936,775 ns</td><td align="right" bgcolor="#FFFFFF">916,340 ns</td><td align="right" bgcolor="#FFFFFF">910,727 ns</td><td align="right" bgcolor="#FFFFFF">924,460 ns</td><td align="right" bgcolor="#FFFFFF">956,002 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,011 μs</td><td align="right" bgcolor="#FFFFFF">0,937 μs</td><td align="right" bgcolor="#FFFFFF">0,916 μs</td><td align="right" bgcolor="#FFFFFF">0,911 μs</td><td align="right" bgcolor="#FFFFFF">0,924 μs</td><td align="right" bgcolor="#FFFFFF">0,956 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">-23,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+30,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1857,500</td><td align="right" bgcolor="#FF4949">1860,000 (Δ = +2,500)</td><td align="right" bgcolor="#A8D08D">1427,500 (Δ = -432,500)</td><td align="right" bgcolor="#FFFFFF">1427,500</td><td align="right" bgcolor="#A8D08D">1426,000 (Δ = -1,500)</td><td align="right" bgcolor="#FF4949">1858,000 (Δ = +432,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,814</td><td align="right" bgcolor="#FF4949">1,816 (Δ = +0,002)</td><td align="right" bgcolor="#A8D08D">1,394 (Δ = -0,422)</td><td align="right" bgcolor="#FFFFFF">1,394</td><td align="right" bgcolor="#A8D08D">1,393 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">1,814 (Δ = +0,422)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


## <a name="HashHelper_Benchmark"></a>HashHelper_Benchmark

### <a name="HashHelper_Benchmark_HashHelper"></a>HashHelper

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 4,551 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">21,887 ns</td><td align="right" bgcolor="#FFFFFF">20,464 ns</td><td align="right" bgcolor="#FFFFFF">24,086 ns</td><td align="right" bgcolor="#FFFFFF">24,642 ns</td><td align="right" bgcolor="#FFFFFF">25,015 ns</td><td align="right" bgcolor="#FFFFFF">23,585 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#A8D08D">59,500 (Δ = -6,500)</td><td align="right" bgcolor="#FFFFFF">59,500</td><td align="right" bgcolor="#FFFFFF">59,500</td><td align="right" bgcolor="#FF4949">66,000 (Δ = +6,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#A8D08D">0,058 (Δ = -0,006)</td><td align="right" bgcolor="#FFFFFF">0,058</td><td align="right" bgcolor="#FFFFFF">0,058</td><td align="right" bgcolor="#FF4949">0,064 (Δ = +0,006)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="LanguageHelper_Benchmark"></a>LanguageHelper_Benchmark

### <a name="LanguageHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 194,754 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">600,490 ns</td><td align="right" bgcolor="#FFFFFF">410,409 ns</td><td align="right" bgcolor="#FFFFFF">407,093 ns</td><td align="right" bgcolor="#FFFFFF">407,637 ns</td><td align="right" bgcolor="#FFFFFF">405,736 ns</td><td align="right" bgcolor="#FFFFFF">408,838 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,600 μs</td><td align="right" bgcolor="#FFFFFF">0,410 μs</td><td align="right" bgcolor="#FFFFFF">0,407 μs</td><td align="right" bgcolor="#FFFFFF">0,408 μs</td><td align="right" bgcolor="#FFFFFF">0,406 μs</td><td align="right" bgcolor="#FFFFFF">0,409 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#A8D08D">194,500 (Δ = -63,500)</td><td align="right" bgcolor="#FFFFFF">194,500</td><td align="right" bgcolor="#FFFFFF">194,500</td><td align="right" bgcolor="#FF4949">258,000 (Δ = +63,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#A8D08D">0,190 (Δ = -0,062)</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FF4949">0,252 (Δ = +0,062)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="Log_Debug_Benchmark"></a>Log_Debug_Benchmark

### <a name="Log_Debug_Benchmark_Log_Debug_Format_1_Format_Argument"></a>Log_Debug_Format_1_Format_Argument

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 76,546 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">610,269 ns</td><td align="right" bgcolor="#FFFFFF">593,908 ns</td><td align="right" bgcolor="#FFFFFF">639,719 ns</td><td align="right" bgcolor="#FFFFFF">665,906 ns</td><td align="right" bgcolor="#FFFFFF">634,168 ns</td><td align="right" bgcolor="#FFFFFF">589,360 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,610 μs</td><td align="right" bgcolor="#FFFFFF">0,594 μs</td><td align="right" bgcolor="#FFFFFF">0,640 μs</td><td align="right" bgcolor="#FFFFFF">0,666 μs</td><td align="right" bgcolor="#FFFFFF">0,634 μs</td><td align="right" bgcolor="#FFFFFF">0,589 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#A8D08D">-16,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">340,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">282,500 (Δ = -57,500)</td><td align="right" bgcolor="#FFFFFF">282,500</td><td align="right" bgcolor="#FFFFFF">282,500</td><td align="right" bgcolor="#FF4949">340,000 (Δ = +57,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,332 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,276 (Δ = -0,056)</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FF4949">0,332 (Δ = +0,056)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_2_Format_Arguments"></a>Log_Debug_Format_2_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 91,689 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">784,003 ns</td><td align="right" bgcolor="#FFFFFF">704,211 ns</td><td align="right" bgcolor="#FFFFFF">753,504 ns</td><td align="right" bgcolor="#FFFFFF">752,662 ns</td><td align="right" bgcolor="#FFFFFF">744,922 ns</td><td align="right" bgcolor="#FFFFFF">692,313 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,784 μs</td><td align="right" bgcolor="#FFFFFF">0,704 μs</td><td align="right" bgcolor="#FFFFFF">0,754 μs</td><td align="right" bgcolor="#FFFFFF">0,753 μs</td><td align="right" bgcolor="#FFFFFF">0,745 μs</td><td align="right" bgcolor="#FFFFFF">0,692 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-16,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">315,500 (Δ = -61,500)</td><td align="right" bgcolor="#FFFFFF">315,500</td><td align="right" bgcolor="#FFFFFF">315,500</td><td align="right" bgcolor="#FF4949">377,000 (Δ = +61,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,308 (Δ = -0,060)</td><td align="right" bgcolor="#FFFFFF">0,308</td><td align="right" bgcolor="#FFFFFF">0,308</td><td align="right" bgcolor="#FF4949">0,368 (Δ = +0,060)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments"></a>Log_Debug_Format_3_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 193,951 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">897,233 ns</td><td align="right" bgcolor="#FFFFFF">837,970 ns</td><td align="right" bgcolor="#FFFFFF">896,462 ns</td><td align="right" bgcolor="#FFFFFF">1018,838 ns</td><td align="right" bgcolor="#FFFFFF">890,241 ns</td><td align="right" bgcolor="#FFFFFF">824,887 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,897 μs</td><td align="right" bgcolor="#FFFFFF">0,838 μs</td><td align="right" bgcolor="#FFFFFF">0,896 μs</td><td align="right" bgcolor="#FFFFFF">1,019 μs</td><td align="right" bgcolor="#FFFFFF">0,890 μs</td><td align="right" bgcolor="#FFFFFF">0,825 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-16,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">375,000 (Δ = -76,000)</td><td align="right" bgcolor="#FFFFFF">375,000</td><td align="right" bgcolor="#FFFFFF">375,000</td><td align="right" bgcolor="#FF4949">451,000 (Δ = +76,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,366 (Δ = -0,074)</td><td align="right" bgcolor="#FFFFFF">0,366</td><td align="right" bgcolor="#FFFFFF">0,366</td><td align="right" bgcolor="#FF4949">0,440 (Δ = +0,074)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_4_Format_Arguments"></a>Log_Debug_Format_4_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 69,104 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1038,019 ns</td><td align="right" bgcolor="#FFFFFF">1012,937 ns</td><td align="right" bgcolor="#FFFFFF">1078,133 ns</td><td align="right" bgcolor="#FFFFFF">1064,861 ns</td><td align="right" bgcolor="#FFFFFF">1054,544 ns</td><td align="right" bgcolor="#FFFFFF">1009,028 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,038 μs</td><td align="right" bgcolor="#FFFFFF">1,013 μs</td><td align="right" bgcolor="#FFFFFF">1,078 μs</td><td align="right" bgcolor="#FFFFFF">1,065 μs</td><td align="right" bgcolor="#FFFFFF">1,055 μs</td><td align="right" bgcolor="#FFFFFF">1,009 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-18,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">473,500 (Δ = -104,500)</td><td align="right" bgcolor="#FFFFFF">473,500</td><td align="right" bgcolor="#FFFFFF">473,500</td><td align="right" bgcolor="#FF4949">578,000 (Δ = +104,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,462 (Δ = -0,102)</td><td align="right" bgcolor="#FFFFFF">0,462</td><td align="right" bgcolor="#FFFFFF">0,462</td><td align="right" bgcolor="#FF4949">0,564 (Δ = +0,102)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_5_Format_Arguments"></a>Log_Debug_Format_5_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 43,106 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1171,027 ns</td><td align="right" bgcolor="#FFFFFF">1200,387 ns</td><td align="right" bgcolor="#FFFFFF">1199,636 ns</td><td align="right" bgcolor="#FFFFFF">1194,794 ns</td><td align="right" bgcolor="#FFFFFF">1204,536 ns</td><td align="right" bgcolor="#FFFFFF">1161,430 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,171 μs</td><td align="right" bgcolor="#FFFFFF">1,200 μs</td><td align="right" bgcolor="#FFFFFF">1,200 μs</td><td align="right" bgcolor="#FFFFFF">1,195 μs</td><td align="right" bgcolor="#FFFFFF">1,205 μs</td><td align="right" bgcolor="#FFFFFF">1,161 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-18,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">538,500 (Δ = -120,500)</td><td align="right" bgcolor="#FFFFFF">538,500</td><td align="right" bgcolor="#FFFFFF">538,500</td><td align="right" bgcolor="#FF4949">659,000 (Δ = +120,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,526 (Δ = -0,118)</td><td align="right" bgcolor="#FFFFFF">0,526</td><td align="right" bgcolor="#FFFFFF">0,526</td><td align="right" bgcolor="#FF4949">0,644 (Δ = +0,118)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments"></a>Log_Debug_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 117,458 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1336,056 ns</td><td align="right" bgcolor="#FFFFFF">1386,725 ns</td><td align="right" bgcolor="#FFFFFF">1430,249 ns</td><td align="right" bgcolor="#FFFFFF">1437,527 ns</td><td align="right" bgcolor="#FFFFFF">1453,514 ns</td><td align="right" bgcolor="#FFFFFF">1358,310 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,336 μs</td><td align="right" bgcolor="#FFFFFF">1,387 μs</td><td align="right" bgcolor="#FFFFFF">1,430 μs</td><td align="right" bgcolor="#FFFFFF">1,438 μs</td><td align="right" bgcolor="#FFFFFF">1,454 μs</td><td align="right" bgcolor="#FFFFFF">1,358 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-19,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+23,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">676,000 (Δ = -160,000)</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +160,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,660 (Δ = -0,156)</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,156)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_7_Format_Arguments"></a>Log_Debug_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 169,784 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1436,579 ns</td><td align="right" bgcolor="#FFFFFF">1534,133 ns</td><td align="right" bgcolor="#FFFFFF">1606,363 ns</td><td align="right" bgcolor="#FFFFFF">1565,334 ns</td><td align="right" bgcolor="#FFFFFF">1573,605 ns</td><td align="right" bgcolor="#FFFFFF">1511,990 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,437 μs</td><td align="right" bgcolor="#FFFFFF">1,534 μs</td><td align="right" bgcolor="#FFFFFF">1,606 μs</td><td align="right" bgcolor="#FFFFFF">1,565 μs</td><td align="right" bgcolor="#FFFFFF">1,574 μs</td><td align="right" bgcolor="#FFFFFF">1,512 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-19,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+24,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">743,500 (Δ = -178,500)</td><td align="right" bgcolor="#FFFFFF">743,500</td><td align="right" bgcolor="#FFFFFF">743,500</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +178,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,726 (Δ = -0,174)</td><td align="right" bgcolor="#FFFFFF">0,726</td><td align="right" bgcolor="#FFFFFF">0,726</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,174)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 4,640 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,036 ns</td><td align="right" bgcolor="#FFFFFF">5,377 ns</td><td align="right" bgcolor="#FFFFFF">0,737 ns</td><td align="right" bgcolor="#FFFFFF">0,826 ns</td><td align="right" bgcolor="#FFFFFF">1,140 ns</td><td align="right" bgcolor="#FFFFFF">1,272 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 6,344 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,076 ns</td><td align="right" bgcolor="#FFFFFF">20,532 ns</td><td align="right" bgcolor="#FFFFFF">14,188 ns</td><td align="right" bgcolor="#FFFFFF">14,429 ns</td><td align="right" bgcolor="#FFFFFF">15,582 ns</td><td align="right" bgcolor="#FFFFFF">16,193 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#A8D08D">43,000 (Δ = -14,000)</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FF4949">57,000 (Δ = +14,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#A8D08D">0,042 (Δ = -0,014)</td><td align="right" bgcolor="#FFFFFF">0,042</td><td align="right" bgcolor="#FFFFFF">0,042</td><td align="right" bgcolor="#FF4949">0,056 (Δ = +0,014)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 5,974 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,456 ns</td><td align="right" bgcolor="#FFFFFF">16,713 ns</td><td align="right" bgcolor="#FFFFFF">10,891 ns</td><td align="right" bgcolor="#FFFFFF">10,739 ns</td><td align="right" bgcolor="#FFFFFF">10,859 ns</td><td align="right" bgcolor="#FFFFFF">11,170 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,017 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">24,500 (Δ = -8,500)</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +8,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,008)</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 51,846 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">279,668 ns</td><td align="right" bgcolor="#FFFFFF">276,676 ns</td><td align="right" bgcolor="#FFFFFF">324,523 ns</td><td align="right" bgcolor="#FFFFFF">325,133 ns</td><td align="right" bgcolor="#FFFFFF">311,576 ns</td><td align="right" bgcolor="#FFFFFF">273,287 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,280 μs</td><td align="right" bgcolor="#FFFFFF">0,277 μs</td><td align="right" bgcolor="#FFFFFF">0,325 μs</td><td align="right" bgcolor="#FFFFFF">0,325 μs</td><td align="right" bgcolor="#FFFFFF">0,312 μs</td><td align="right" bgcolor="#FFFFFF">0,273 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,0 %</td><td align="right" bgcolor="#A8D08D">-18,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+23,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">133,000 (Δ = -31,000)</td><td align="right" bgcolor="#FFFFFF">133,000</td><td align="right" bgcolor="#FFFFFF">133,000</td><td align="right" bgcolor="#FF4949">164,000 (Δ = +31,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,130 (Δ = -0,030)</td><td align="right" bgcolor="#FFFFFF">0,130</td><td align="right" bgcolor="#FFFFFF">0,130</td><td align="right" bgcolor="#FF4949">0,160 (Δ = +0,030)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 35,801 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">612,749 ns</td><td align="right" bgcolor="#FFFFFF">624,947 ns</td><td align="right" bgcolor="#FFFFFF">646,358 ns</td><td align="right" bgcolor="#FFFFFF">641,182 ns</td><td align="right" bgcolor="#FFFFFF">639,118 ns</td><td align="right" bgcolor="#FFFFFF">610,557 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,613 μs</td><td align="right" bgcolor="#FFFFFF">0,625 μs</td><td align="right" bgcolor="#FFFFFF">0,646 μs</td><td align="right" bgcolor="#FFFFFF">0,641 μs</td><td align="right" bgcolor="#FFFFFF">0,639 μs</td><td align="right" bgcolor="#FFFFFF">0,611 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">-16,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">385,000</td><td align="right" bgcolor="#A8D08D">352,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -57,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FFFFFF">295,000</td><td align="right" bgcolor="#FF4949">352,000 (Δ = +57,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,376</td><td align="right" bgcolor="#A8D08D">0,344 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,056)</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FFFFFF">0,288</td><td align="right" bgcolor="#FF4949">0,344 (Δ = +0,056)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 77,721 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">515,166 ns</td><td align="right" bgcolor="#FFFFFF">505,720 ns</td><td align="right" bgcolor="#FFFFFF">575,964 ns</td><td align="right" bgcolor="#FFFFFF">583,441 ns</td><td align="right" bgcolor="#FFFFFF">574,732 ns</td><td align="right" bgcolor="#FFFFFF">509,667 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,515 μs</td><td align="right" bgcolor="#FFFFFF">0,506 μs</td><td align="right" bgcolor="#FFFFFF">0,576 μs</td><td align="right" bgcolor="#FFFFFF">0,583 μs</td><td align="right" bgcolor="#FFFFFF">0,575 μs</td><td align="right" bgcolor="#FFFFFF">0,510 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,8 %</td><td align="right" bgcolor="#A8D08D">-13,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">377,000</td><td align="right" bgcolor="#A8D08D">344,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -45,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FF4949">344,000 (Δ = +45,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,368</td><td align="right" bgcolor="#A8D08D">0,336 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,044)</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FF4949">0,336 (Δ = +0,044)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="Log_Error_Benchmark"></a>Log_Error_Benchmark

### <a name="Log_Error_Benchmark_Log_Error_Format_1_Format_Argument"></a>Log_Error_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 100,660 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">628,567 ns</td><td align="right" bgcolor="#FFFFFF">556,738 ns</td><td align="right" bgcolor="#FFFFFF">603,640 ns</td><td align="right" bgcolor="#FFFFFF">657,397 ns</td><td align="right" bgcolor="#FFFFFF">595,621 ns</td><td align="right" bgcolor="#FFFFFF">560,370 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,629 μs</td><td align="right" bgcolor="#FFFFFF">0,557 μs</td><td align="right" bgcolor="#FFFFFF">0,604 μs</td><td align="right" bgcolor="#FFFFFF">0,657 μs</td><td align="right" bgcolor="#FFFFFF">0,596 μs</td><td align="right" bgcolor="#FFFFFF">0,560 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-16,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">258,000 (Δ = -49,000)</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FF4949">307,000 (Δ = +49,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,252 (Δ = -0,048)</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FF4949">0,300 (Δ = +0,048)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_2_Format_Arguments"></a>Log_Error_Format_2_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 76,227 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">768,075 ns</td><td align="right" bgcolor="#FFFFFF">699,818 ns</td><td align="right" bgcolor="#FFFFFF">754,464 ns</td><td align="right" bgcolor="#FFFFFF">751,202 ns</td><td align="right" bgcolor="#FFFFFF">748,184 ns</td><td align="right" bgcolor="#FFFFFF">691,848 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,768 μs</td><td align="right" bgcolor="#FFFFFF">0,700 μs</td><td align="right" bgcolor="#FFFFFF">0,754 μs</td><td align="right" bgcolor="#FFFFFF">0,751 μs</td><td align="right" bgcolor="#FFFFFF">0,748 μs</td><td align="right" bgcolor="#FFFFFF">0,692 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-16,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">315,500 (Δ = -61,500)</td><td align="right" bgcolor="#FFFFFF">315,500</td><td align="right" bgcolor="#FFFFFF">315,500</td><td align="right" bgcolor="#FF4949">377,000 (Δ = +61,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,308 (Δ = -0,060)</td><td align="right" bgcolor="#FFFFFF">0,308</td><td align="right" bgcolor="#FFFFFF">0,308</td><td align="right" bgcolor="#FF4949">0,368 (Δ = +0,060)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_3_Format_Arguments"></a>Log_Error_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 51,215 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">896,316 ns</td><td align="right" bgcolor="#FFFFFF">845,101 ns</td><td align="right" bgcolor="#FFFFFF">891,079 ns</td><td align="right" bgcolor="#FFFFFF">894,236 ns</td><td align="right" bgcolor="#FFFFFF">892,527 ns</td><td align="right" bgcolor="#FFFFFF">848,842 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,896 μs</td><td align="right" bgcolor="#FFFFFF">0,845 μs</td><td align="right" bgcolor="#FFFFFF">0,891 μs</td><td align="right" bgcolor="#FFFFFF">0,894 μs</td><td align="right" bgcolor="#FFFFFF">0,893 μs</td><td align="right" bgcolor="#FFFFFF">0,849 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-16,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">375,000 (Δ = -76,000)</td><td align="right" bgcolor="#FFFFFF">375,000</td><td align="right" bgcolor="#FFFFFF">375,000</td><td align="right" bgcolor="#FF4949">451,000 (Δ = +76,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,366 (Δ = -0,074)</td><td align="right" bgcolor="#FFFFFF">0,366</td><td align="right" bgcolor="#FFFFFF">0,366</td><td align="right" bgcolor="#FF4949">0,440 (Δ = +0,074)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_4_Format_Arguments"></a>Log_Error_Format_4_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 57,458 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1057,528 ns</td><td align="right" bgcolor="#FFFFFF">1008,908 ns</td><td align="right" bgcolor="#FFFFFF">1063,923 ns</td><td align="right" bgcolor="#FFFFFF">1058,622 ns</td><td align="right" bgcolor="#FFFFFF">1059,051 ns</td><td align="right" bgcolor="#FFFFFF">1006,465 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,058 μs</td><td align="right" bgcolor="#FFFFFF">1,009 μs</td><td align="right" bgcolor="#FFFFFF">1,064 μs</td><td align="right" bgcolor="#FFFFFF">1,059 μs</td><td align="right" bgcolor="#FFFFFF">1,059 μs</td><td align="right" bgcolor="#FFFFFF">1,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-18,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">473,500 (Δ = -104,500)</td><td align="right" bgcolor="#FFFFFF">473,500</td><td align="right" bgcolor="#FFFFFF">473,500</td><td align="right" bgcolor="#FF4949">578,000 (Δ = +104,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,462 (Δ = -0,102)</td><td align="right" bgcolor="#FFFFFF">0,462</td><td align="right" bgcolor="#FFFFFF">0,462</td><td align="right" bgcolor="#FF4949">0,564 (Δ = +0,102)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_5_Format_Arguments"></a>Log_Error_Format_5_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 165,447 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1308,660 ns</td><td align="right" bgcolor="#FFFFFF">1157,562 ns</td><td align="right" bgcolor="#FFFFFF">1204,858 ns</td><td align="right" bgcolor="#FFFFFF">1210,566 ns</td><td align="right" bgcolor="#FFFFFF">1199,249 ns</td><td align="right" bgcolor="#FFFFFF">1143,213 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,309 μs</td><td align="right" bgcolor="#FFFFFF">1,158 μs</td><td align="right" bgcolor="#FFFFFF">1,205 μs</td><td align="right" bgcolor="#FFFFFF">1,211 μs</td><td align="right" bgcolor="#FFFFFF">1,199 μs</td><td align="right" bgcolor="#FFFFFF">1,143 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-18,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">538,500 (Δ = -120,500)</td><td align="right" bgcolor="#FFFFFF">538,500</td><td align="right" bgcolor="#FFFFFF">538,500</td><td align="right" bgcolor="#FF4949">659,000 (Δ = +120,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,526 (Δ = -0,118)</td><td align="right" bgcolor="#FFFFFF">0,526</td><td align="right" bgcolor="#FFFFFF">0,526</td><td align="right" bgcolor="#FF4949">0,644 (Δ = +0,118)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_6_Format_Arguments"></a>Log_Error_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 148,599 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1308,268 ns</td><td align="right" bgcolor="#FFFFFF">1380,033 ns</td><td align="right" bgcolor="#FFFFFF">1456,868 ns</td><td align="right" bgcolor="#FFFFFF">1423,172 ns</td><td align="right" bgcolor="#FFFFFF">1456,473 ns</td><td align="right" bgcolor="#FFFFFF">1405,105 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,308 μs</td><td align="right" bgcolor="#FFFFFF">1,380 μs</td><td align="right" bgcolor="#FFFFFF">1,457 μs</td><td align="right" bgcolor="#FFFFFF">1,423 μs</td><td align="right" bgcolor="#FFFFFF">1,456 μs</td><td align="right" bgcolor="#FFFFFF">1,405 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-19,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+23,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">676,000 (Δ = -160,000)</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +160,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,660 (Δ = -0,156)</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,156)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_7_Format_Arguments"></a>Log_Error_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 155,496 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1458,742 ns</td><td align="right" bgcolor="#FFFFFF">1518,911 ns</td><td align="right" bgcolor="#FFFFFF">1614,239 ns</td><td align="right" bgcolor="#FFFFFF">1597,569 ns</td><td align="right" bgcolor="#FFFFFF">1582,576 ns</td><td align="right" bgcolor="#FFFFFF">1477,213 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,459 μs</td><td align="right" bgcolor="#FFFFFF">1,519 μs</td><td align="right" bgcolor="#FFFFFF">1,614 μs</td><td align="right" bgcolor="#FFFFFF">1,598 μs</td><td align="right" bgcolor="#FFFFFF">1,583 μs</td><td align="right" bgcolor="#FFFFFF">1,477 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-19,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+24,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">743,500 (Δ = -178,500)</td><td align="right" bgcolor="#FFFFFF">743,500</td><td align="right" bgcolor="#FFFFFF">743,500</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +178,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,726 (Δ = -0,174)</td><td align="right" bgcolor="#FFFFFF">0,726</td><td align="right" bgcolor="#FFFFFF">0,726</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,174)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="Log_Info_Benchmark"></a>Log_Info_Benchmark

### <a name="Log_Info_Benchmark_Log_Info_Format_1_Format_Argument"></a>Log_Info_Format_1_Format_Argument

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 71,159 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">617,678 ns</td><td align="right" bgcolor="#FFFFFF">596,633 ns</td><td align="right" bgcolor="#FFFFFF">653,556 ns</td><td align="right" bgcolor="#FFFFFF">644,414 ns</td><td align="right" bgcolor="#FFFFFF">628,541 ns</td><td align="right" bgcolor="#FFFFFF">582,397 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,597 μs</td><td align="right" bgcolor="#FFFFFF">0,654 μs</td><td align="right" bgcolor="#FFFFFF">0,644 μs</td><td align="right" bgcolor="#FFFFFF">0,629 μs</td><td align="right" bgcolor="#FFFFFF">0,582 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#A8D08D">-16,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">340,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">282,500 (Δ = -57,500)</td><td align="right" bgcolor="#FFFFFF">282,500</td><td align="right" bgcolor="#FFFFFF">282,500</td><td align="right" bgcolor="#FF4949">340,000 (Δ = +57,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,332 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,276 (Δ = -0,056)</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FF4949">0,332 (Δ = +0,056)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_2_Format_Arguments"></a>Log_Info_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 62,766 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">782,608 ns</td><td align="right" bgcolor="#FFFFFF">735,186 ns</td><td align="right" bgcolor="#FFFFFF">789,465 ns</td><td align="right" bgcolor="#FFFFFF">797,952 ns</td><td align="right" bgcolor="#FFFFFF">790,620 ns</td><td align="right" bgcolor="#FFFFFF">763,075 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,783 μs</td><td align="right" bgcolor="#FFFFFF">0,735 μs</td><td align="right" bgcolor="#FFFFFF">0,789 μs</td><td align="right" bgcolor="#FFFFFF">0,798 μs</td><td align="right" bgcolor="#FFFFFF">0,791 μs</td><td align="right" bgcolor="#FFFFFF">0,763 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,3 %</td><td align="right" bgcolor="#A8D08D">-17,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">346,000 (Δ = -72,000)</td><td align="right" bgcolor="#FFFFFF">346,000</td><td align="right" bgcolor="#FFFFFF">346,000</td><td align="right" bgcolor="#FF4949">418,000 (Δ = +72,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,338 (Δ = -0,070)</td><td align="right" bgcolor="#FFFFFF">0,338</td><td align="right" bgcolor="#FFFFFF">0,338</td><td align="right" bgcolor="#FF4949">0,408 (Δ = +0,070)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_3_Format_Arguments"></a>Log_Info_Format_3_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 111,825 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">922,158 ns</td><td align="right" bgcolor="#FFFFFF">882,235 ns</td><td align="right" bgcolor="#FFFFFF">940,283 ns</td><td align="right" bgcolor="#FFFFFF">982,431 ns</td><td align="right" bgcolor="#FFFFFF">930,495 ns</td><td align="right" bgcolor="#FFFFFF">870,607 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,922 μs</td><td align="right" bgcolor="#FFFFFF">0,882 μs</td><td align="right" bgcolor="#FFFFFF">0,940 μs</td><td align="right" bgcolor="#FFFFFF">0,982 μs</td><td align="right" bgcolor="#FFFFFF">0,930 μs</td><td align="right" bgcolor="#FFFFFF">0,871 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#A8D08D">-17,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">500,000 (Δ = -28,000)</td><td align="right" bgcolor="#A8D08D">412,000 (Δ = -88,000)</td><td align="right" bgcolor="#FFFFFF">412,000</td><td align="right" bgcolor="#FFFFFF">412,000</td><td align="right" bgcolor="#FF4949">500,000 (Δ = +88,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,488 (Δ = -0,027)</td><td align="right" bgcolor="#A8D08D">0,402 (Δ = -0,086)</td><td align="right" bgcolor="#FFFFFF">0,402</td><td align="right" bgcolor="#FFFFFF">0,402</td><td align="right" bgcolor="#FF4949">0,488 (Δ = +0,086)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_4_Format_Arguments"></a>Log_Info_Format_4_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 104,350 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1070,912 ns</td><td align="right" bgcolor="#FFFFFF">1038,216 ns</td><td align="right" bgcolor="#FFFFFF">1100,713 ns</td><td align="right" bgcolor="#FFFFFF">1111,045 ns</td><td align="right" bgcolor="#FFFFFF">1067,978 ns</td><td align="right" bgcolor="#FFFFFF">1006,695 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,071 μs</td><td align="right" bgcolor="#FFFFFF">1,038 μs</td><td align="right" bgcolor="#FFFFFF">1,101 μs</td><td align="right" bgcolor="#FFFFFF">1,111 μs</td><td align="right" bgcolor="#FFFFFF">1,068 μs</td><td align="right" bgcolor="#FFFFFF">1,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-18,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">473,500 (Δ = -104,500)</td><td align="right" bgcolor="#FFFFFF">473,500</td><td align="right" bgcolor="#FFFFFF">473,500</td><td align="right" bgcolor="#FF4949">578,000 (Δ = +104,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,462 (Δ = -0,102)</td><td align="right" bgcolor="#FFFFFF">0,462</td><td align="right" bgcolor="#FFFFFF">0,462</td><td align="right" bgcolor="#FF4949">0,564 (Δ = +0,102)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_5_Format_Arguments"></a>Log_Info_Format_5_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 88,157 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1180,361 ns</td><td align="right" bgcolor="#FFFFFF">1221,193 ns</td><td align="right" bgcolor="#FFFFFF">1233,925 ns</td><td align="right" bgcolor="#FFFFFF">1209,498 ns</td><td align="right" bgcolor="#FFFFFF">1195,561 ns</td><td align="right" bgcolor="#FFFFFF">1145,768 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,180 μs</td><td align="right" bgcolor="#FFFFFF">1,221 μs</td><td align="right" bgcolor="#FFFFFF">1,234 μs</td><td align="right" bgcolor="#FFFFFF">1,209 μs</td><td align="right" bgcolor="#FFFFFF">1,196 μs</td><td align="right" bgcolor="#FFFFFF">1,146 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-18,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">538,500 (Δ = -120,500)</td><td align="right" bgcolor="#FFFFFF">538,500</td><td align="right" bgcolor="#FFFFFF">538,500</td><td align="right" bgcolor="#FF4949">659,000 (Δ = +120,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,526 (Δ = -0,118)</td><td align="right" bgcolor="#FFFFFF">0,526</td><td align="right" bgcolor="#FFFFFF">0,526</td><td align="right" bgcolor="#FF4949">0,644 (Δ = +0,118)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_6_Format_Arguments"></a>Log_Info_Format_6_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 77,618 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1317,883 ns</td><td align="right" bgcolor="#FFFFFF">1330,926 ns</td><td align="right" bgcolor="#FFFFFF">1352,389 ns</td><td align="right" bgcolor="#FFFFFF">1344,369 ns</td><td align="right" bgcolor="#FFFFFF">1371,150 ns</td><td align="right" bgcolor="#FFFFFF">1293,532 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,318 μs</td><td align="right" bgcolor="#FFFFFF">1,331 μs</td><td align="right" bgcolor="#FFFFFF">1,352 μs</td><td align="right" bgcolor="#FFFFFF">1,344 μs</td><td align="right" bgcolor="#FFFFFF">1,371 μs</td><td align="right" bgcolor="#FFFFFF">1,294 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#A8D08D">-18,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#A8D08D">737,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">602,000 (Δ = -135,000)</td><td align="right" bgcolor="#FFFFFF">602,000</td><td align="right" bgcolor="#FFFFFF">602,000</td><td align="right" bgcolor="#FF4949">737,000 (Δ = +135,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#A8D08D">0,720 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,588 (Δ = -0,132)</td><td align="right" bgcolor="#FFFFFF">0,588</td><td align="right" bgcolor="#FFFFFF">0,588</td><td align="right" bgcolor="#FF4949">0,720 (Δ = +0,132)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments"></a>Log_Info_Format_7_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 92,452 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1466,358 ns</td><td align="right" bgcolor="#FFFFFF">1419,583 ns</td><td align="right" bgcolor="#FFFFFF">1503,919 ns</td><td align="right" bgcolor="#FFFFFF">1495,440 ns</td><td align="right" bgcolor="#FFFFFF">1490,036 ns</td><td align="right" bgcolor="#FFFFFF">1411,467 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,466 μs</td><td align="right" bgcolor="#FFFFFF">1,420 μs</td><td align="right" bgcolor="#FFFFFF">1,504 μs</td><td align="right" bgcolor="#FFFFFF">1,495 μs</td><td align="right" bgcolor="#FFFFFF">1,490 μs</td><td align="right" bgcolor="#FFFFFF">1,411 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#A8D08D">-18,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">819,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">667,500 (Δ = -151,500)</td><td align="right" bgcolor="#FFFFFF">667,500</td><td align="right" bgcolor="#FFFFFF">667,500</td><td align="right" bgcolor="#FF4949">819,000 (Δ = +151,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,800 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,652 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,652</td><td align="right" bgcolor="#FFFFFF">0,652</td><td align="right" bgcolor="#FF4949">0,800 (Δ = +0,148)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="Log_Status_Benchmark"></a>Log_Status_Benchmark

### <a name="Log_Status_Benchmark_Log_Status_Format_1_Format_Argument"></a>Log_Status_Format_1_Format_Argument

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 75,621 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">624,293 ns</td><td align="right" bgcolor="#FFFFFF">564,754 ns</td><td align="right" bgcolor="#FFFFFF">608,907 ns</td><td align="right" bgcolor="#FFFFFF">605,353 ns</td><td align="right" bgcolor="#FFFFFF">595,704 ns</td><td align="right" bgcolor="#FFFFFF">548,672 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,624 μs</td><td align="right" bgcolor="#FFFFFF">0,565 μs</td><td align="right" bgcolor="#FFFFFF">0,609 μs</td><td align="right" bgcolor="#FFFFFF">0,605 μs</td><td align="right" bgcolor="#FFFFFF">0,596 μs</td><td align="right" bgcolor="#FFFFFF">0,549 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-16,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">258,000 (Δ = -49,000)</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FF4949">307,000 (Δ = +49,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,252 (Δ = -0,048)</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FF4949">0,300 (Δ = +0,048)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_2_Format_Arguments"></a>Log_Status_Format_2_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 144,540 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">844,027 ns</td><td align="right" bgcolor="#FFFFFF">709,335 ns</td><td align="right" bgcolor="#FFFFFF">748,069 ns</td><td align="right" bgcolor="#FFFFFF">744,412 ns</td><td align="right" bgcolor="#FFFFFF">750,299 ns</td><td align="right" bgcolor="#FFFFFF">699,487 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,844 μs</td><td align="right" bgcolor="#FFFFFF">0,709 μs</td><td align="right" bgcolor="#FFFFFF">0,748 μs</td><td align="right" bgcolor="#FFFFFF">0,744 μs</td><td align="right" bgcolor="#FFFFFF">0,750 μs</td><td align="right" bgcolor="#FFFFFF">0,699 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-16,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">315,500 (Δ = -61,500)</td><td align="right" bgcolor="#FFFFFF">315,500</td><td align="right" bgcolor="#FFFFFF">315,500</td><td align="right" bgcolor="#FF4949">377,000 (Δ = +61,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,308 (Δ = -0,060)</td><td align="right" bgcolor="#FFFFFF">0,308</td><td align="right" bgcolor="#FFFFFF">0,308</td><td align="right" bgcolor="#FF4949">0,368 (Δ = +0,060)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_3_Format_Arguments"></a>Log_Status_Format_3_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 120,130 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">955,190 ns</td><td align="right" bgcolor="#FFFFFF">837,255 ns</td><td align="right" bgcolor="#FFFFFF">895,527 ns</td><td align="right" bgcolor="#FFFFFF">897,725 ns</td><td align="right" bgcolor="#FFFFFF">897,461 ns</td><td align="right" bgcolor="#FFFFFF">835,060 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,955 μs</td><td align="right" bgcolor="#FFFFFF">0,837 μs</td><td align="right" bgcolor="#FFFFFF">0,896 μs</td><td align="right" bgcolor="#FFFFFF">0,898 μs</td><td align="right" bgcolor="#FFFFFF">0,897 μs</td><td align="right" bgcolor="#FFFFFF">0,835 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-16,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">375,000 (Δ = -76,000)</td><td align="right" bgcolor="#FFFFFF">375,000</td><td align="right" bgcolor="#FFFFFF">375,000</td><td align="right" bgcolor="#FF4949">451,000 (Δ = +76,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,366 (Δ = -0,074)</td><td align="right" bgcolor="#FFFFFF">0,366</td><td align="right" bgcolor="#FFFFFF">0,366</td><td align="right" bgcolor="#FF4949">0,440 (Δ = +0,074)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments"></a>Log_Status_Format_4_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 141,891 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1132,798 ns</td><td align="right" bgcolor="#FFFFFF">1014,991 ns</td><td align="right" bgcolor="#FFFFFF">1082,975 ns</td><td align="right" bgcolor="#FFFFFF">1064,745 ns</td><td align="right" bgcolor="#FFFFFF">1145,768 ns</td><td align="right" bgcolor="#FFFFFF">1003,877 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,133 μs</td><td align="right" bgcolor="#FFFFFF">1,015 μs</td><td align="right" bgcolor="#FFFFFF">1,083 μs</td><td align="right" bgcolor="#FFFFFF">1,065 μs</td><td align="right" bgcolor="#FFFFFF">1,146 μs</td><td align="right" bgcolor="#FFFFFF">1,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-18,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">473,500 (Δ = -104,500)</td><td align="right" bgcolor="#FFFFFF">473,500</td><td align="right" bgcolor="#FFFFFF">473,500</td><td align="right" bgcolor="#FF4949">578,000 (Δ = +104,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,462 (Δ = -0,102)</td><td align="right" bgcolor="#FFFFFF">0,462</td><td align="right" bgcolor="#FFFFFF">0,462</td><td align="right" bgcolor="#FF4949">0,564 (Δ = +0,102)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_5_Format_Arguments"></a>Log_Status_Format_5_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 65,365 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1203,071 ns</td><td align="right" bgcolor="#FFFFFF">1163,750 ns</td><td align="right" bgcolor="#FFFFFF">1218,317 ns</td><td align="right" bgcolor="#FFFFFF">1208,213 ns</td><td align="right" bgcolor="#FFFFFF">1205,357 ns</td><td align="right" bgcolor="#FFFFFF">1152,952 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,203 μs</td><td align="right" bgcolor="#FFFFFF">1,164 μs</td><td align="right" bgcolor="#FFFFFF">1,218 μs</td><td align="right" bgcolor="#FFFFFF">1,208 μs</td><td align="right" bgcolor="#FFFFFF">1,205 μs</td><td align="right" bgcolor="#FFFFFF">1,153 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-18,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">538,500 (Δ = -120,500)</td><td align="right" bgcolor="#FFFFFF">538,500</td><td align="right" bgcolor="#FFFFFF">538,500</td><td align="right" bgcolor="#FF4949">659,000 (Δ = +120,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,526 (Δ = -0,118)</td><td align="right" bgcolor="#FFFFFF">0,526</td><td align="right" bgcolor="#FFFFFF">0,526</td><td align="right" bgcolor="#FF4949">0,644 (Δ = +0,118)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_6_Format_Arguments"></a>Log_Status_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 202,153 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1316,648 ns</td><td align="right" bgcolor="#FFFFFF">1373,633 ns</td><td align="right" bgcolor="#FFFFFF">1455,095 ns</td><td align="right" bgcolor="#FFFFFF">1432,854 ns</td><td align="right" bgcolor="#FFFFFF">1518,801 ns</td><td align="right" bgcolor="#FFFFFF">1403,130 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,317 μs</td><td align="right" bgcolor="#FFFFFF">1,374 μs</td><td align="right" bgcolor="#FFFFFF">1,455 μs</td><td align="right" bgcolor="#FFFFFF">1,433 μs</td><td align="right" bgcolor="#FFFFFF">1,519 μs</td><td align="right" bgcolor="#FFFFFF">1,403 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-19,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+23,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">676,000 (Δ = -160,000)</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +160,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,660 (Δ = -0,156)</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,156)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_7_Format_Arguments"></a>Log_Status_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 173,614 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1426,016 ns</td><td align="right" bgcolor="#FFFFFF">1512,807 ns</td><td align="right" bgcolor="#FFFFFF">1599,630 ns</td><td align="right" bgcolor="#FFFFFF">1592,021 ns</td><td align="right" bgcolor="#FFFFFF">1592,973 ns</td><td align="right" bgcolor="#FFFFFF">1512,867 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,426 μs</td><td align="right" bgcolor="#FFFFFF">1,513 μs</td><td align="right" bgcolor="#FFFFFF">1,600 μs</td><td align="right" bgcolor="#FFFFFF">1,592 μs</td><td align="right" bgcolor="#FFFFFF">1,593 μs</td><td align="right" bgcolor="#FFFFFF">1,513 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-19,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+24,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">743,500 (Δ = -178,500)</td><td align="right" bgcolor="#FFFFFF">743,500</td><td align="right" bgcolor="#FFFFFF">743,500</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +178,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,726 (Δ = -0,174)</td><td align="right" bgcolor="#FFFFFF">0,726</td><td align="right" bgcolor="#FFFFFF">0,726</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,174)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="Log_Warning_Benchmark"></a>Log_Warning_Benchmark

### <a name="Log_Warning_Benchmark_Log_Warning_Format_1_Format_Argument"></a>Log_Warning_Format_1_Format_Argument

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 83,335 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">638,510 ns</td><td align="right" bgcolor="#FFFFFF">566,638 ns</td><td align="right" bgcolor="#FFFFFF">609,494 ns</td><td align="right" bgcolor="#FFFFFF">600,490 ns</td><td align="right" bgcolor="#FFFFFF">603,415 ns</td><td align="right" bgcolor="#FFFFFF">555,175 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,639 μs</td><td align="right" bgcolor="#FFFFFF">0,567 μs</td><td align="right" bgcolor="#FFFFFF">0,609 μs</td><td align="right" bgcolor="#FFFFFF">0,600 μs</td><td align="right" bgcolor="#FFFFFF">0,603 μs</td><td align="right" bgcolor="#FFFFFF">0,555 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-16,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">258,000 (Δ = -49,000)</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FF4949">307,000 (Δ = +49,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,252 (Δ = -0,048)</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FF4949">0,300 (Δ = +0,048)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_2_Format_Arguments"></a>Log_Warning_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 73,809 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">737,984 ns</td><td align="right" bgcolor="#FFFFFF">697,640 ns</td><td align="right" bgcolor="#FFFFFF">771,449 ns</td><td align="right" bgcolor="#FFFFFF">746,073 ns</td><td align="right" bgcolor="#FFFFFF">753,748 ns</td><td align="right" bgcolor="#FFFFFF">731,773 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,738 μs</td><td align="right" bgcolor="#FFFFFF">0,698 μs</td><td align="right" bgcolor="#FFFFFF">0,771 μs</td><td align="right" bgcolor="#FFFFFF">0,746 μs</td><td align="right" bgcolor="#FFFFFF">0,754 μs</td><td align="right" bgcolor="#FFFFFF">0,732 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-16,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">315,500 (Δ = -61,500)</td><td align="right" bgcolor="#FFFFFF">315,500</td><td align="right" bgcolor="#FFFFFF">315,500</td><td align="right" bgcolor="#FF4949">377,000 (Δ = +61,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,308 (Δ = -0,060)</td><td align="right" bgcolor="#FFFFFF">0,308</td><td align="right" bgcolor="#FFFFFF">0,308</td><td align="right" bgcolor="#FF4949">0,368 (Δ = +0,060)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_3_Format_Arguments"></a>Log_Warning_Format_3_Format_Arguments

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 100,785 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">932,960 ns</td><td align="right" bgcolor="#FFFFFF">836,038 ns</td><td align="right" bgcolor="#FFFFFF">907,343 ns</td><td align="right" bgcolor="#FFFFFF">899,218 ns</td><td align="right" bgcolor="#FFFFFF">907,229 ns</td><td align="right" bgcolor="#FFFFFF">832,175 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,933 μs</td><td align="right" bgcolor="#FFFFFF">0,836 μs</td><td align="right" bgcolor="#FFFFFF">0,907 μs</td><td align="right" bgcolor="#FFFFFF">0,899 μs</td><td align="right" bgcolor="#FFFFFF">0,907 μs</td><td align="right" bgcolor="#FFFFFF">0,832 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-16,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">375,000 (Δ = -76,000)</td><td align="right" bgcolor="#FFFFFF">375,000</td><td align="right" bgcolor="#FFFFFF">375,000</td><td align="right" bgcolor="#FF4949">451,000 (Δ = +76,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,366 (Δ = -0,074)</td><td align="right" bgcolor="#FFFFFF">0,366</td><td align="right" bgcolor="#FFFFFF">0,366</td><td align="right" bgcolor="#FF4949">0,440 (Δ = +0,074)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_4_Format_Arguments"></a>Log_Warning_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 97,958 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1102,173 ns</td><td align="right" bgcolor="#FFFFFF">1004,215 ns</td><td align="right" bgcolor="#FFFFFF">1061,288 ns</td><td align="right" bgcolor="#FFFFFF">1070,316 ns</td><td align="right" bgcolor="#FFFFFF">1065,707 ns</td><td align="right" bgcolor="#FFFFFF">1010,383 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,102 μs</td><td align="right" bgcolor="#FFFFFF">1,004 μs</td><td align="right" bgcolor="#FFFFFF">1,061 μs</td><td align="right" bgcolor="#FFFFFF">1,070 μs</td><td align="right" bgcolor="#FFFFFF">1,066 μs</td><td align="right" bgcolor="#FFFFFF">1,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-18,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">473,500 (Δ = -104,500)</td><td align="right" bgcolor="#FFFFFF">473,500</td><td align="right" bgcolor="#FFFFFF">473,500</td><td align="right" bgcolor="#FF4949">578,000 (Δ = +104,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,462 (Δ = -0,102)</td><td align="right" bgcolor="#FFFFFF">0,462</td><td align="right" bgcolor="#FFFFFF">0,462</td><td align="right" bgcolor="#FF4949">0,564 (Δ = +0,102)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_5_Format_Arguments"></a>Log_Warning_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 60,237 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1179,937 ns</td><td align="right" bgcolor="#FFFFFF">1157,333 ns</td><td align="right" bgcolor="#FFFFFF">1213,553 ns</td><td align="right" bgcolor="#FFFFFF">1217,570 ns</td><td align="right" bgcolor="#FFFFFF">1204,058 ns</td><td align="right" bgcolor="#FFFFFF">1158,168 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,180 μs</td><td align="right" bgcolor="#FFFFFF">1,157 μs</td><td align="right" bgcolor="#FFFFFF">1,214 μs</td><td align="right" bgcolor="#FFFFFF">1,218 μs</td><td align="right" bgcolor="#FFFFFF">1,204 μs</td><td align="right" bgcolor="#FFFFFF">1,158 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-18,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">538,500 (Δ = -120,500)</td><td align="right" bgcolor="#FFFFFF">538,500</td><td align="right" bgcolor="#FFFFFF">538,500</td><td align="right" bgcolor="#FF4949">659,000 (Δ = +120,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,526 (Δ = -0,118)</td><td align="right" bgcolor="#FFFFFF">0,526</td><td align="right" bgcolor="#FFFFFF">0,526</td><td align="right" bgcolor="#FF4949">0,644 (Δ = +0,118)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_6_Format_Arguments"></a>Log_Warning_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 136,215 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1312,026 ns</td><td align="right" bgcolor="#FFFFFF">1386,331 ns</td><td align="right" bgcolor="#FFFFFF">1433,482 ns</td><td align="right" bgcolor="#FFFFFF">1442,108 ns</td><td align="right" bgcolor="#FFFFFF">1448,241 ns</td><td align="right" bgcolor="#FFFFFF">1356,448 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,312 μs</td><td align="right" bgcolor="#FFFFFF">1,386 μs</td><td align="right" bgcolor="#FFFFFF">1,433 μs</td><td align="right" bgcolor="#FFFFFF">1,442 μs</td><td align="right" bgcolor="#FFFFFF">1,448 μs</td><td align="right" bgcolor="#FFFFFF">1,356 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-19,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+23,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">676,000 (Δ = -160,000)</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +160,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,660 (Δ = -0,156)</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,156)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments"></a>Log_Warning_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 142,957 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1448,290 ns</td><td align="right" bgcolor="#FFFFFF">1510,536 ns</td><td align="right" bgcolor="#FFFFFF">1568,031 ns</td><td align="right" bgcolor="#FFFFFF">1579,258 ns</td><td align="right" bgcolor="#FFFFFF">1591,247 ns</td><td align="right" bgcolor="#FFFFFF">1538,337 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,448 μs</td><td align="right" bgcolor="#FFFFFF">1,511 μs</td><td align="right" bgcolor="#FFFFFF">1,568 μs</td><td align="right" bgcolor="#FFFFFF">1,579 μs</td><td align="right" bgcolor="#FFFFFF">1,591 μs</td><td align="right" bgcolor="#FFFFFF">1,538 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-19,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+24,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">743,500 (Δ = -178,500)</td><td align="right" bgcolor="#FFFFFF">743,500</td><td align="right" bgcolor="#FFFFFF">743,500</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +178,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,726 (Δ = -0,174)</td><td align="right" bgcolor="#FFFFFF">0,726</td><td align="right" bgcolor="#FFFFFF">0,726</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,174)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="MemberInfoExtensions_Benchmark"></a>MemberInfoExtensions_Benchmark

### <a name="MemberInfoExtensions_Benchmark_GetSignature_Constructor"></a>GetSignature_Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 42,238 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">315,824 ns</td><td align="right" bgcolor="#FFFFFF">273,586 ns</td><td align="right" bgcolor="#FFFFFF">275,621 ns</td><td align="right" bgcolor="#FFFFFF">280,501 ns</td><td align="right" bgcolor="#FFFFFF">277,173 ns</td><td align="right" bgcolor="#FFFFFF">274,402 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,316 μs</td><td align="right" bgcolor="#FFFFFF">0,274 μs</td><td align="right" bgcolor="#FFFFFF">0,276 μs</td><td align="right" bgcolor="#FFFFFF">0,281 μs</td><td align="right" bgcolor="#FFFFFF">0,277 μs</td><td align="right" bgcolor="#FFFFFF">0,274 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#A8D08D">157,500 (Δ = -51,500)</td><td align="right" bgcolor="#FFFFFF">157,500</td><td align="right" bgcolor="#FFFFFF">157,500</td><td align="right" bgcolor="#FF4949">209,000 (Δ = +51,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#A8D08D">0,154 (Δ = -0,050)</td><td align="right" bgcolor="#FFFFFF">0,154</td><td align="right" bgcolor="#FFFFFF">0,154</td><td align="right" bgcolor="#FF4949">0,204 (Δ = +0,050)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="MemberInfoExtensions_Benchmark_GetSignature_Method"></a>GetSignature_Method

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 125,733 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">426,318 ns</td><td align="right" bgcolor="#FFFFFF">300,937 ns</td><td align="right" bgcolor="#FFFFFF">339,705 ns</td><td align="right" bgcolor="#FFFFFF">312,429 ns</td><td align="right" bgcolor="#FFFFFF">308,527 ns</td><td align="right" bgcolor="#FFFFFF">300,585 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,426 μs</td><td align="right" bgcolor="#FFFFFF">0,301 μs</td><td align="right" bgcolor="#FFFFFF">0,340 μs</td><td align="right" bgcolor="#FFFFFF">0,312 μs</td><td align="right" bgcolor="#FFFFFF">0,309 μs</td><td align="right" bgcolor="#FFFFFF">0,301 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#A8D08D">157,500 (Δ = -51,500)</td><td align="right" bgcolor="#FFFFFF">157,500</td><td align="right" bgcolor="#FFFFFF">157,500</td><td align="right" bgcolor="#FF4949">209,000 (Δ = +51,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#A8D08D">0,154 (Δ = -0,050)</td><td align="right" bgcolor="#FFFFFF">0,154</td><td align="right" bgcolor="#FFFFFF">0,154</td><td align="right" bgcolor="#FF4949">0,204 (Δ = +0,050)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 458,758 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,1 %</td><td align="right" bgcolor="#A8D08D">-9,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3893,734 ns</td><td align="right" bgcolor="#FFFFFF">3915,180 ns</td><td align="right" bgcolor="#FF4949">4240,826 ns (Δ = +325,646 ns)</td><td align="right" bgcolor="#FFFFFF">4100,607 ns</td><td align="right" bgcolor="#FF4949">4352,492 ns (Δ = +251,886 ns)</td><td align="right" bgcolor="#A8D08D">3919,665 ns (Δ = -432,827 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,894 μs</td><td align="right" bgcolor="#FFFFFF">3,915 μs</td><td align="right" bgcolor="#FFFFFF">4,241 μs</td><td align="right" bgcolor="#FFFFFF">4,101 μs</td><td align="right" bgcolor="#FFFFFF">4,352 μs</td><td align="right" bgcolor="#FFFFFF">3,920 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#A8D08D">258,000 (Δ = -86,000)</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FF4949">344,000 (Δ = +86,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#A8D08D">0,252 (Δ = -0,084)</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FF4949">0,336 (Δ = +0,084)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 510,593 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6758,274 ns</td><td align="right" bgcolor="#FFFFFF">6692,053 ns</td><td align="right" bgcolor="#FF4949">7175,713 ns (Δ = +483,660 ns)</td><td align="right" bgcolor="#FFFFFF">6951,879 ns</td><td align="right" bgcolor="#FFFFFF">7004,597 ns</td><td align="right" bgcolor="#A8D08D">6665,120 ns (Δ = -339,477 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,758 μs</td><td align="right" bgcolor="#FFFFFF">6,692 μs</td><td align="right" bgcolor="#FFFFFF">7,176 μs</td><td align="right" bgcolor="#FFFFFF">6,952 μs</td><td align="right" bgcolor="#FFFFFF">7,005 μs</td><td align="right" bgcolor="#FFFFFF">6,665 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">545,000 (Δ = -176,000)</td><td align="right" bgcolor="#FFFFFF">545,000</td><td align="right" bgcolor="#FFFFFF">545,000</td><td align="right" bgcolor="#FF4949">721,000 (Δ = +176,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,532 (Δ = -0,172)</td><td align="right" bgcolor="#FFFFFF">0,532</td><td align="right" bgcolor="#FFFFFF">0,532</td><td align="right" bgcolor="#FF4949">0,704 (Δ = +0,172)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 448,274 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,2 %</td><td align="right" bgcolor="#A8D08D">-5,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5284,996 ns</td><td align="right" bgcolor="#FFFFFF">5200,185 ns</td><td align="right" bgcolor="#FFFFFF">5377,208 ns</td><td align="right" bgcolor="#FFFFFF">5367,122 ns</td><td align="right" bgcolor="#FF4949">5648,459 ns (Δ = +281,337 ns)</td><td align="right" bgcolor="#A8D08D">5320,352 ns (Δ = -328,107 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,285 μs</td><td align="right" bgcolor="#FFFFFF">5,200 μs</td><td align="right" bgcolor="#FFFFFF">5,377 μs</td><td align="right" bgcolor="#FFFFFF">5,367 μs</td><td align="right" bgcolor="#FFFFFF">5,648 μs</td><td align="right" bgcolor="#FFFFFF">5,320 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#A8D08D">512,000 (Δ = -164,000)</td><td align="right" bgcolor="#FFFFFF">512,000</td><td align="right" bgcolor="#FFFFFF">512,000</td><td align="right" bgcolor="#FF4949">676,000 (Δ = +164,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#A8D08D">0,500 (Δ = -0,160)</td><td align="right" bgcolor="#FFFFFF">0,500</td><td align="right" bgcolor="#FFFFFF">0,500</td><td align="right" bgcolor="#FF4949">0,660 (Δ = +0,160)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 320,110 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3915,556 ns</td><td align="right" bgcolor="#FFFFFF">3902,426 ns</td><td align="right" bgcolor="#FF4949">4187,869 ns (Δ = +285,443 ns)</td><td align="right" bgcolor="#FFFFFF">4055,496 ns</td><td align="right" bgcolor="#FFFFFF">4105,144 ns</td><td align="right" bgcolor="#FFFFFF">3867,759 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,916 μs</td><td align="right" bgcolor="#FFFFFF">3,902 μs</td><td align="right" bgcolor="#FFFFFF">4,188 μs</td><td align="right" bgcolor="#FFFFFF">4,055 μs</td><td align="right" bgcolor="#FFFFFF">4,105 μs</td><td align="right" bgcolor="#FFFFFF">3,868 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#A8D08D">258,000 (Δ = -86,000)</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FF4949">344,000 (Δ = +86,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#A8D08D">0,252 (Δ = -0,084)</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FF4949">0,336 (Δ = +0,084)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 296,353 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6822,928 ns</td><td align="right" bgcolor="#FFFFFF">6670,278 ns</td><td align="right" bgcolor="#FF4949">6932,031 ns (Δ = +261,753 ns)</td><td align="right" bgcolor="#FFFFFF">6958,261 ns</td><td align="right" bgcolor="#FFFFFF">6966,631 ns</td><td align="right" bgcolor="#A8D08D">6695,690 ns (Δ = -270,941 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,823 μs</td><td align="right" bgcolor="#FFFFFF">6,670 μs</td><td align="right" bgcolor="#FFFFFF">6,932 μs</td><td align="right" bgcolor="#FFFFFF">6,958 μs</td><td align="right" bgcolor="#FFFFFF">6,967 μs</td><td align="right" bgcolor="#FFFFFF">6,696 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">545,000 (Δ = -176,000)</td><td align="right" bgcolor="#FFFFFF">545,000</td><td align="right" bgcolor="#FFFFFF">545,000</td><td align="right" bgcolor="#FF4949">721,000 (Δ = +176,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,532 (Δ = -0,172)</td><td align="right" bgcolor="#FFFFFF">0,532</td><td align="right" bgcolor="#FFFFFF">0,532</td><td align="right" bgcolor="#FF4949">0,704 (Δ = +0,172)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 894,576 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,6 %</td><td align="right" bgcolor="#A8D08D">-5,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7877,153 ns</td><td align="right" bgcolor="#FFFFFF">7730,518 ns</td><td align="right" bgcolor="#FF4949">8625,094 ns (Δ = +894,576 ns)</td><td align="right" bgcolor="#A8D08D">8117,438 ns (Δ = -507,657 ns)</td><td align="right" bgcolor="#FFFFFF">8146,888 ns</td><td align="right" bgcolor="#A8D08D">7831,613 ns (Δ = -315,274 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,877 μs</td><td align="right" bgcolor="#FFFFFF">7,731 μs</td><td align="right" bgcolor="#FFFFFF">8,625 μs</td><td align="right" bgcolor="#FFFFFF">8,117 μs</td><td align="right" bgcolor="#FFFFFF">8,147 μs</td><td align="right" bgcolor="#FFFFFF">7,832 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1090,000</td><td align="right" bgcolor="#FFFFFF">1090,000</td><td align="right" bgcolor="#A8D08D">827,500 (Δ = -262,500)</td><td align="right" bgcolor="#FFFFFF">827,500</td><td align="right" bgcolor="#FFFFFF">827,500</td><td align="right" bgcolor="#FF4949">1090,000 (Δ = +262,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,064</td><td align="right" bgcolor="#FFFFFF">1,064</td><td align="right" bgcolor="#A8D08D">0,808 (Δ = -0,256)</td><td align="right" bgcolor="#FFFFFF">0,808</td><td align="right" bgcolor="#FFFFFF">0,808</td><td align="right" bgcolor="#FF4949">1,064 (Δ = +0,256)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="ModelBase_Constructor_Benchmark"></a>ModelBase_Constructor_Benchmark

### <a name="ModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 860,493 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,4 %</td><td align="right" bgcolor="#FF4949">+9,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3521,376 ns</td><td align="right" bgcolor="#A8D08D">2660,883 ns (Δ = -860,493 ns)</td><td align="right" bgcolor="#FF4949">2915,361 ns (Δ = +254,477 ns)</td><td align="right" bgcolor="#FFFFFF">3011,316 ns</td><td align="right" bgcolor="#FFFFFF">2971,244 ns</td><td align="right" bgcolor="#A8D08D">2717,237 ns (Δ = -254,007 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,521 μs</td><td align="right" bgcolor="#FFFFFF">2,661 μs</td><td align="right" bgcolor="#FFFFFF">2,915 μs</td><td align="right" bgcolor="#FFFFFF">3,011 μs</td><td align="right" bgcolor="#FFFFFF">2,971 μs</td><td align="right" bgcolor="#FFFFFF">2,717 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,5 %</td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1720,000</td><td align="right" bgcolor="#A8D08D">971,000 (Δ = -749,000)</td><td align="right" bgcolor="#A8D08D">762,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">971,000 (Δ = +209,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,680</td><td align="right" bgcolor="#A8D08D">0,948 (Δ = -0,731)</td><td align="right" bgcolor="#A8D08D">0,744 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,948 (Δ = +0,204)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="ModelBase_EqualityComparer_Benchmark"></a>ModelBase_EqualityComparer_Benchmark

### <a name="ModelBase_EqualityComparer_Benchmark_EqualityComparer"></a>EqualityComparer

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 815,430 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3468,132 ns</td><td align="right" bgcolor="#A8D08D">2652,702 ns (Δ = -815,430 ns)</td><td align="right" bgcolor="#FFFFFF">2889,653 ns</td><td align="right" bgcolor="#FFFFFF">2908,478 ns</td><td align="right" bgcolor="#FFFFFF">2880,762 ns</td><td align="right" bgcolor="#FFFFFF">2728,718 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,468 μs</td><td align="right" bgcolor="#FFFFFF">2,653 μs</td><td align="right" bgcolor="#FFFFFF">2,890 μs</td><td align="right" bgcolor="#FFFFFF">2,908 μs</td><td align="right" bgcolor="#FFFFFF">2,881 μs</td><td align="right" bgcolor="#FFFFFF">2,729 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,5 %</td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1720,000</td><td align="right" bgcolor="#A8D08D">971,000 (Δ = -749,000)</td><td align="right" bgcolor="#A8D08D">762,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">971,000 (Δ = +209,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,680</td><td align="right" bgcolor="#A8D08D">0,948 (Δ = -0,731)</td><td align="right" bgcolor="#A8D08D">0,744 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,948 (Δ = +0,204)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="ModelBase_EqualityComparer_Benchmark_GetHashCode_"></a>GetHashCode_

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1681,477 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-38,4 %</td><td align="right" bgcolor="#FF4949">+10,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4376,270 ns</td><td align="right" bgcolor="#A8D08D">2694,793 ns (Δ = -1681,477 ns)</td><td align="right" bgcolor="#FF4949">2966,774 ns (Δ = +271,982 ns)</td><td align="right" bgcolor="#FFFFFF">2971,592 ns</td><td align="right" bgcolor="#FFFFFF">2965,758 ns</td><td align="right" bgcolor="#FFFFFF">2748,093 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,376 μs</td><td align="right" bgcolor="#FFFFFF">2,695 μs</td><td align="right" bgcolor="#FFFFFF">2,967 μs</td><td align="right" bgcolor="#FFFFFF">2,972 μs</td><td align="right" bgcolor="#FFFFFF">2,966 μs</td><td align="right" bgcolor="#FFFFFF">2,748 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,3 %</td><td align="right" bgcolor="#A8D08D">-21,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1888,000</td><td align="right" bgcolor="#A8D08D">995,000 (Δ = -893,000)</td><td align="right" bgcolor="#A8D08D">780,000 (Δ = -215,000)</td><td align="right" bgcolor="#FFFFFF">780,000</td><td align="right" bgcolor="#FFFFFF">780,000</td><td align="right" bgcolor="#FF4949">995,000 (Δ = +215,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,844</td><td align="right" bgcolor="#A8D08D">0,972 (Δ = -0,872)</td><td align="right" bgcolor="#A8D08D">0,762 (Δ = -0,210)</td><td align="right" bgcolor="#FFFFFF">0,762</td><td align="right" bgcolor="#FFFFFF">0,762</td><td align="right" bgcolor="#FF4949">0,972 (Δ = +0,210)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="ModelBase_GetValue_Benchmark"></a>ModelBase_GetValue_Benchmark

### <a name="ModelBase_GetValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 35,573 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">126,076 ns</td><td align="right" bgcolor="#FFFFFF">141,314 ns</td><td align="right" bgcolor="#FFFFFF">161,649 ns</td><td align="right" bgcolor="#FFFFFF">143,359 ns</td><td align="right" bgcolor="#FFFFFF">147,435 ns</td><td align="right" bgcolor="#FFFFFF">139,704 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,162 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,140 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ModelBase_GetValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 18,163 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">127,834 ns</td><td align="right" bgcolor="#FFFFFF">138,393 ns</td><td align="right" bgcolor="#FFFFFF">140,569 ns</td><td align="right" bgcolor="#FFFFFF">143,473 ns</td><td align="right" bgcolor="#FFFFFF">145,997 ns</td><td align="right" bgcolor="#FFFFFF">138,265 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ModelBase_GetValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 18,762 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">120,179 ns</td><td align="right" bgcolor="#FFFFFF">134,363 ns</td><td align="right" bgcolor="#FFFFFF">135,500 ns</td><td align="right" bgcolor="#FFFFFF">138,942 ns</td><td align="right" bgcolor="#FFFFFF">136,151 ns</td><td align="right" bgcolor="#FFFFFF">132,942 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1403,853 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-76,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1834,122 ns</td><td align="right" bgcolor="#A8D08D">430,270 ns (Δ = -1403,853 ns)</td><td align="right" bgcolor="#FFFFFF">451,927 ns</td><td align="right" bgcolor="#FFFFFF">457,407 ns</td><td align="right" bgcolor="#FFFFFF">446,559 ns</td><td align="right" bgcolor="#FFFFFF">471,183 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,834 μs</td><td align="right" bgcolor="#FFFFFF">0,430 μs</td><td align="right" bgcolor="#FFFFFF">0,452 μs</td><td align="right" bgcolor="#FFFFFF">0,457 μs</td><td align="right" bgcolor="#FFFFFF">0,447 μs</td><td align="right" bgcolor="#FFFFFF">0,471 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-86,9 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">627,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">61,500 (Δ = -20,500)</td><td align="right" bgcolor="#FFFFFF">61,500</td><td align="right" bgcolor="#FFFFFF">61,500</td><td align="right" bgcolor="#FF4949">82,000 (Δ = +20,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,612</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,060 (Δ = -0,020)</td><td align="right" bgcolor="#FFFFFF">0,060</td><td align="right" bgcolor="#FFFFFF">0,060</td><td align="right" bgcolor="#FF4949">0,080 (Δ = +0,020)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 1346,923 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-74,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1803,658 ns</td><td align="right" bgcolor="#A8D08D">460,513 ns (Δ = -1343,144 ns)</td><td align="right" bgcolor="#FFFFFF">475,766 ns</td><td align="right" bgcolor="#FFFFFF">516,261 ns</td><td align="right" bgcolor="#FFFFFF">478,042 ns</td><td align="right" bgcolor="#FFFFFF">456,735 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,804 μs</td><td align="right" bgcolor="#FFFFFF">0,461 μs</td><td align="right" bgcolor="#FFFFFF">0,476 μs</td><td align="right" bgcolor="#FFFFFF">0,516 μs</td><td align="right" bgcolor="#FFFFFF">0,478 μs</td><td align="right" bgcolor="#FFFFFF">0,457 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-86,9 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">627,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">61,500 (Δ = -20,500)</td><td align="right" bgcolor="#FFFFFF">61,500</td><td align="right" bgcolor="#FFFFFF">61,500</td><td align="right" bgcolor="#FF4949">82,000 (Δ = +20,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,612</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,060 (Δ = -0,020)</td><td align="right" bgcolor="#FFFFFF">0,060</td><td align="right" bgcolor="#FFFFFF">0,060</td><td align="right" bgcolor="#FF4949">0,080 (Δ = +0,020)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 1270,708 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1613,577 ns</td><td align="right" bgcolor="#A8D08D">351,613 ns (Δ = -1261,964 ns)</td><td align="right" bgcolor="#FFFFFF">342,868 ns</td><td align="right" bgcolor="#FFFFFF">345,239 ns</td><td align="right" bgcolor="#FFFFFF">348,746 ns</td><td align="right" bgcolor="#FFFFFF">367,395 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,614 μs</td><td align="right" bgcolor="#FFFFFF">0,352 μs</td><td align="right" bgcolor="#FFFFFF">0,343 μs</td><td align="right" bgcolor="#FFFFFF">0,345 μs</td><td align="right" bgcolor="#FFFFFF">0,349 μs</td><td align="right" bgcolor="#FFFFFF">0,367 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-90,5 %</td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">602,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">43,000 (Δ = -14,000)</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FF4949">57,000 (Δ = +14,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,588</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,042 (Δ = -0,014)</td><td align="right" bgcolor="#FFFFFF">0,042</td><td align="right" bgcolor="#FFFFFF">0,042</td><td align="right" bgcolor="#FF4949">0,056 (Δ = +0,014)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="ObjectHelper_Benchmark"></a>ObjectHelper_Benchmark

### <a name="ObjectHelper_Benchmark_AreEqual__Same_Reference"></a>AreEqual__Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,942 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,325 ns</td><td align="right" bgcolor="#FFFFFF">2,227 ns</td><td align="right" bgcolor="#FFFFFF">2,823 ns</td><td align="right" bgcolor="#FFFFFF">3,168 ns</td><td align="right" bgcolor="#FFFFFF">2,608 ns</td><td align="right" bgcolor="#FFFFFF">2,552 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Both_Null"></a>AreEqual_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 0,161 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,280 ns</td><td align="right" bgcolor="#FFFFFF">2,201 ns</td><td align="right" bgcolor="#FFFFFF">2,261 ns</td><td align="right" bgcolor="#FFFFFF">2,301 ns</td><td align="right" bgcolor="#FFFFFF">2,362 ns</td><td align="right" bgcolor="#FFFFFF">2,238 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Not_Same_Reference"></a>AreEqual_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 2,797 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,578 ns</td><td align="right" bgcolor="#FFFFFF">8,053 ns</td><td align="right" bgcolor="#FFFFFF">10,520 ns</td><td align="right" bgcolor="#FFFFFF">10,849 ns</td><td align="right" bgcolor="#FFFFFF">10,316 ns</td><td align="right" bgcolor="#FFFFFF">8,568 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_One_Null"></a>AreEqual_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 0,678 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,888 ns</td><td align="right" bgcolor="#FFFFFF">2,211 ns</td><td align="right" bgcolor="#FFFFFF">2,741 ns</td><td align="right" bgcolor="#FFFFFF">2,806 ns</td><td align="right" bgcolor="#FFFFFF">2,458 ns</td><td align="right" bgcolor="#FFFFFF">2,860 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqual_Strings"></a>AreEqual_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 1,588 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,846 ns</td><td align="right" bgcolor="#FFFFFF">8,483 ns</td><td align="right" bgcolor="#FFFFFF">9,681 ns</td><td align="right" bgcolor="#FFFFFF">9,930 ns</td><td align="right" bgcolor="#FFFFFF">10,072 ns</td><td align="right" bgcolor="#FFFFFF">8,713 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Both_Null"></a>AreEqualReferences_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 21,028 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">23,347 ns</td><td align="right" bgcolor="#FFFFFF">2,318 ns</td><td align="right" bgcolor="#FFFFFF">2,616 ns</td><td align="right" bgcolor="#FFFFFF">2,552 ns</td><td align="right" bgcolor="#FFFFFF">2,597 ns</td><td align="right" bgcolor="#FFFFFF">2,520 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Not_Same_Reference"></a>AreEqualReferences_Not_Same_Reference

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 5,453 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">48,868 ns</td><td align="right" bgcolor="#FFFFFF">49,986 ns</td><td align="right" bgcolor="#FFFFFF">53,880 ns</td><td align="right" bgcolor="#FFFFFF">54,321 ns</td><td align="right" bgcolor="#FFFFFF">53,559 ns</td><td align="right" bgcolor="#FFFFFF">49,550 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,049 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,054 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_One_Null"></a>AreEqualReferences_One_Null

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 0,395 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,615 ns</td><td align="right" bgcolor="#FFFFFF">2,525 ns</td><td align="right" bgcolor="#FFFFFF">2,833 ns</td><td align="right" bgcolor="#FFFFFF">2,905 ns</td><td align="right" bgcolor="#FFFFFF">2,849 ns</td><td align="right" bgcolor="#FFFFFF">2,510 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Same_Reference"></a>AreEqualReferences_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 1,054 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,688 ns</td><td align="right" bgcolor="#FFFFFF">2,381 ns</td><td align="right" bgcolor="#FFFFFF">3,435 ns</td><td align="right" bgcolor="#FFFFFF">2,950 ns</td><td align="right" bgcolor="#FFFFFF">3,366 ns</td><td align="right" bgcolor="#FFFFFF">2,497 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Strings"></a>AreEqualReferences_Strings

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 11,856 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">85,187 ns</td><td align="right" bgcolor="#FFFFFF">77,523 ns</td><td align="right" bgcolor="#FFFFFF">83,974 ns</td><td align="right" bgcolor="#FFFFFF">85,148 ns</td><td align="right" bgcolor="#FFFFFF">85,908 ns</td><td align="right" bgcolor="#FFFFFF">74,052 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectHelper_Benchmark_IsNull"></a>IsNull

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 0,499 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,524 ns</td><td align="right" bgcolor="#FFFFFF">0,025 ns</td><td align="right" bgcolor="#FFFFFF">0,069 ns</td><td align="right" bgcolor="#FFFFFF">0,048 ns</td><td align="right" bgcolor="#FFFFFF">0,113 ns</td><td align="right" bgcolor="#FFFFFF">0,068 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ObjectToStringHelper_Benchmark"></a>ObjectToStringHelper_Benchmark

### <a name="ObjectToStringHelper_Benchmark_ToFullTypeString"></a>ToFullTypeString

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 12,760 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">100,199 ns</td><td align="right" bgcolor="#FFFFFF">96,493 ns</td><td align="right" bgcolor="#FFFFFF">108,290 ns</td><td align="right" bgcolor="#FFFFFF">106,369 ns</td><td align="right" bgcolor="#FFFFFF">109,253 ns</td><td align="right" bgcolor="#FFFFFF">97,270 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,109 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ObjectToStringHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.3.0**

Slowest: 5.2.0

Δ: 426,628 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,1 %</td><td align="right" bgcolor="#A8D08D">-11,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3458,577 ns</td><td align="right" bgcolor="#FFFFFF">3305,137 ns</td><td align="right" bgcolor="#FFFFFF">3347,711 ns</td><td align="right" bgcolor="#FF4949">3687,434 ns (Δ = +339,723 ns)</td><td align="right" bgcolor="#A8D08D">3260,807 ns (Δ = -426,628 ns)</td><td align="right" bgcolor="#FFFFFF">3335,590 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,459 μs</td><td align="right" bgcolor="#FFFFFF">3,305 μs</td><td align="right" bgcolor="#FFFFFF">3,348 μs</td><td align="right" bgcolor="#FFFFFF">3,687 μs</td><td align="right" bgcolor="#FFFFFF">3,261 μs</td><td align="right" bgcolor="#FFFFFF">3,336 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">-24,0 %</td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1740,500</td><td align="right" bgcolor="#FF4949">1741,000 (Δ = +0,500)</td><td align="right" bgcolor="#A8D08D">1323,000 (Δ = -418,000)</td><td align="right" bgcolor="#A8D08D">1298,500 (Δ = -24,500)</td><td align="right" bgcolor="#FFFFFF">1298,500</td><td align="right" bgcolor="#FF4949">1708,000 (Δ = +409,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,700</td><td align="right" bgcolor="#FF4949">1,700 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">1,292 (Δ = -0,408)</td><td align="right" bgcolor="#A8D08D">1,268 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">1,268</td><td align="right" bgcolor="#FF4949">1,668 (Δ = +0,400)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


### <a name="ObjectToStringHelper_Benchmark_ToTypeString"></a>ToTypeString

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 2,226 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,025 ns</td><td align="right" bgcolor="#FFFFFF">23,189 ns</td><td align="right" bgcolor="#FFFFFF">24,770 ns</td><td align="right" bgcolor="#FFFFFF">25,415 ns</td><td align="right" bgcolor="#FFFFFF">24,100 ns</td><td align="right" bgcolor="#FFFFFF">23,260 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ParallelHelper_Benchmark"></a>ParallelHelper_Benchmark

### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100"></a>ExecuteInParallel_ItemsPerBash_100

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 1711419,925 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+52,2 %</td><td align="right" bgcolor="#A8D08D">-35,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3140220,933 ns</td><td align="right" bgcolor="#FF4949">4778219,771 ns (Δ = +1637998,838 ns)</td><td align="right" bgcolor="#A8D08D">3073626,835 ns (Δ = -1704592,936 ns)</td><td align="right" bgcolor="#FFFFFF">3095541,748 ns</td><td align="right" bgcolor="#FFFFFF">3066799,846 ns</td><td align="right" bgcolor="#FFFFFF">3088436,072 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3140,221 μs</td><td align="right" bgcolor="#FF4949">4778,220 μs (Δ = +1637,999 μs)</td><td align="right" bgcolor="#A8D08D">3073,627 μs (Δ = -1704,593 μs)</td><td align="right" bgcolor="#FFFFFF">3095,542 μs</td><td align="right" bgcolor="#FFFFFF">3066,800 μs</td><td align="right" bgcolor="#FFFFFF">3088,436 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,140 ms</td><td align="right" bgcolor="#FFFFFF">4,778 ms</td><td align="right" bgcolor="#FFFFFF">3,074 ms</td><td align="right" bgcolor="#FFFFFF">3,096 ms</td><td align="right" bgcolor="#FFFFFF">3,067 ms</td><td align="right" bgcolor="#FFFFFF">3,088 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">55,000</td><td align="right" bgcolor="#A8D08D">52,500 (Δ = -2,500)</td><td align="right" bgcolor="#A8D08D">52,000 (Δ = -0,500)</td><td align="right" bgcolor="#FFFFFF">52,000</td><td align="right" bgcolor="#FF4949">52,500 (Δ = +0,500)</td><td align="right" bgcolor="#A8D08D">52,000 (Δ = -0,500)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">8,000</td><td align="right" bgcolor="#A8D08D">7,500 (Δ = -0,500)</td><td align="right" bgcolor="#FF4949">29,500 (Δ = +22,000)</td><td align="right" bgcolor="#FFFFFF">29,500</td><td align="right" bgcolor="#FFFFFF">29,500</td><td align="right" bgcolor="#A8D08D">7,000 (Δ = -22,500)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,5 %</td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+9,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">175379,000</td><td align="right" bgcolor="#A8D08D">167454,000 (Δ = -7925,000)</td><td align="right" bgcolor="#A8D08D">153106,500 (Δ = -14347,500)</td><td align="right" bgcolor="#A8D08D">153070,500 (Δ = -36,000)</td><td align="right" bgcolor="#FF4949">153135,500 (Δ = +65,000)</td><td align="right" bgcolor="#FF4949">167492,000 (Δ = +14356,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">171,269</td><td align="right" bgcolor="#A8D08D">163,529 (Δ = -7,739)</td><td align="right" bgcolor="#A8D08D">149,518 (Δ = -14,011)</td><td align="right" bgcolor="#A8D08D">149,483 (Δ = -0,035)</td><td align="right" bgcolor="#FF4949">149,546 (Δ = +0,063)</td><td align="right" bgcolor="#FF4949">163,566 (Δ = +14,020)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,167</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,146 (Δ = -0,014)</td><td align="right" bgcolor="#A8D08D">0,146 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,146 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,160 (Δ = +0,014)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000"></a>ExecuteInParallel_ItemsPerBash_1000

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 107239,942 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+13,6 %</td><td align="right" bgcolor="#A8D08D">-9,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,6 %</td><td align="right" bgcolor="#A8D08D">-1,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">656944,658 ns</td><td align="right" bgcolor="#FF4949">746077,147 ns (Δ = +89132,489 ns)</td><td align="right" bgcolor="#A8D08D">675560,967 ns (Δ = -70516,180 ns)</td><td align="right" bgcolor="#FFFFFF">677752,796 ns</td><td align="right" bgcolor="#A8D08D">646321,873 ns (Δ = -31430,923 ns)</td><td align="right" bgcolor="#A8D08D">638837,205 ns (Δ = -7484,668 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">656,945 μs</td><td align="right" bgcolor="#FFFFFF">746,077 μs</td><td align="right" bgcolor="#FFFFFF">675,561 μs</td><td align="right" bgcolor="#FFFFFF">677,753 μs</td><td align="right" bgcolor="#FFFFFF">646,322 μs</td><td align="right" bgcolor="#FFFFFF">638,837 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,657 ms</td><td align="right" bgcolor="#FFFFFF">0,746 ms</td><td align="right" bgcolor="#FFFFFF">0,676 ms</td><td align="right" bgcolor="#FFFFFF">0,678 ms</td><td align="right" bgcolor="#FFFFFF">0,646 ms</td><td align="right" bgcolor="#FFFFFF">0,639 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">30,500 (Δ = +2,500)</td><td align="right" bgcolor="#FFFFFF">30,500</td><td align="right" bgcolor="#FFFFFF">30,500</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -2,500)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FF4949">18,000 (Δ = +15,000)</td><td align="right" bgcolor="#FFFFFF">18,000</td><td align="right" bgcolor="#FFFFFF">18,000</td><td align="right" bgcolor="#A8D08D">3,000 (Δ = -15,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,2 %</td><td align="right" bgcolor="#A8D08D">-2,1 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#FF4949">+2,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">92202,500</td><td align="right" bgcolor="#A8D08D">91107,500 (Δ = -1095,000)</td><td align="right" bgcolor="#A8D08D">89228,000 (Δ = -1879,500)</td><td align="right" bgcolor="#A8D08D">89174,000 (Δ = -54,000)</td><td align="right" bgcolor="#FF4949">89265,000 (Δ = +91,000)</td><td align="right" bgcolor="#FF4949">91105,000 (Δ = +1840,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">90,042</td><td align="right" bgcolor="#A8D08D">88,972 (Δ = -1,069)</td><td align="right" bgcolor="#A8D08D">87,137 (Δ = -1,835)</td><td align="right" bgcolor="#A8D08D">87,084 (Δ = -0,053)</td><td align="right" bgcolor="#FF4949">87,173 (Δ = +0,089)</td><td align="right" bgcolor="#FF4949">88,970 (Δ = +1,797)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,088</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,085 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,085 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,085 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,002)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500"></a>ExecuteInParallel_ItemsPerBash_500

#### Performance

Fastest: **5.4.0**

Slowest: 5.0.0

Δ: 340373,182 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+36,1 %</td><td align="right" bgcolor="#A8D08D">-28,0 %</td><td align="right" bgcolor="#FF4949">+1,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">887045,265 ns</td><td align="right" bgcolor="#FF4949">1207445,345 ns (Δ = +320400,080 ns)</td><td align="right" bgcolor="#A8D08D">868891,730 ns (Δ = -338553,615 ns)</td><td align="right" bgcolor="#FF4949">879341,737 ns (Δ = +10450,007 ns)</td><td align="right" bgcolor="#FFFFFF">874783,470 ns</td><td align="right" bgcolor="#FFFFFF">867072,163 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">887,045 μs</td><td align="right" bgcolor="#FF4949">1207,445 μs (Δ = +320,400 μs)</td><td align="right" bgcolor="#A8D08D">868,892 μs (Δ = -338,554 μs)</td><td align="right" bgcolor="#FFFFFF">879,342 μs</td><td align="right" bgcolor="#FFFFFF">874,783 μs</td><td align="right" bgcolor="#FFFFFF">867,072 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,887 ms</td><td align="right" bgcolor="#FFFFFF">1,207 ms</td><td align="right" bgcolor="#FFFFFF">0,869 ms</td><td align="right" bgcolor="#FFFFFF">0,879 ms</td><td align="right" bgcolor="#FFFFFF">0,875 ms</td><td align="right" bgcolor="#FFFFFF">0,867 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">31,000</td><td align="right" bgcolor="#A8D08D">30,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">32,000 (Δ = +2,000)</td><td align="right" bgcolor="#FFFFFF">32,000</td><td align="right" bgcolor="#FFFFFF">32,000</td><td align="right" bgcolor="#A8D08D">30,000 (Δ = -2,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FF4949">18,500 (Δ = +15,500)</td><td align="right" bgcolor="#FFFFFF">18,500</td><td align="right" bgcolor="#FFFFFF">18,500</td><td align="right" bgcolor="#A8D08D">3,000 (Δ = -15,500)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,7 %</td><td align="right" bgcolor="#A8D08D">-3,4 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+3,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">99020,000</td><td align="right" bgcolor="#A8D08D">97365,000 (Δ = -1655,000)</td><td align="right" bgcolor="#A8D08D">94039,000 (Δ = -3326,000)</td><td align="right" bgcolor="#A8D08D">94031,500 (Δ = -7,500)</td><td align="right" bgcolor="#A8D08D">94009,000 (Δ = -22,500)</td><td align="right" bgcolor="#FF4949">97281,000 (Δ = +3272,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">96,699</td><td align="right" bgcolor="#A8D08D">95,083 (Δ = -1,616)</td><td align="right" bgcolor="#A8D08D">91,835 (Δ = -3,248)</td><td align="right" bgcolor="#A8D08D">91,828 (Δ = -0,007)</td><td align="right" bgcolor="#A8D08D">91,806 (Δ = -0,022)</td><td align="right" bgcolor="#FF4949">95,001 (Δ = +3,195)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,094</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,090 (Δ = -0,003)</td><td align="right" bgcolor="#A8D08D">0,090 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,090 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,093 (Δ = +0,003)</td></tr></table>


## <a name="PropertyBag_GetPropertyValue_Benchmark"></a>PropertyBag_GetPropertyValue_Benchmark

### <a name="PropertyBag_GetPropertyValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 3,403 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">79,008 ns</td><td align="right" bgcolor="#FFFFFF">76,935 ns</td><td align="right" bgcolor="#FFFFFF">77,396 ns</td><td align="right" bgcolor="#FFFFFF">80,132 ns</td><td align="right" bgcolor="#FFFFFF">79,662 ns</td><td align="right" bgcolor="#FFFFFF">76,728 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1,660 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">75,901 ns</td><td align="right" bgcolor="#FFFFFF">77,111 ns</td><td align="right" bgcolor="#FFFFFF">77,527 ns</td><td align="right" bgcolor="#FFFFFF">77,561 ns</td><td align="right" bgcolor="#FFFFFF">76,901 ns</td><td align="right" bgcolor="#FFFFFF">77,188 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 4,494 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">85,782 ns</td><td align="right" bgcolor="#FFFFFF">83,596 ns</td><td align="right" bgcolor="#FFFFFF">85,038 ns</td><td align="right" bgcolor="#FFFFFF">85,337 ns</td><td align="right" bgcolor="#FFFFFF">84,718 ns</td><td align="right" bgcolor="#FFFFFF">81,288 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,085 μs</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 46,097 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">164,152 ns</td><td align="right" bgcolor="#FFFFFF">118,055 ns</td><td align="right" bgcolor="#FFFFFF">123,972 ns</td><td align="right" bgcolor="#FFFFFF">124,509 ns</td><td align="right" bgcolor="#FFFFFF">124,479 ns</td><td align="right" bgcolor="#FFFFFF">118,318 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,164 μs</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 47,727 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">162,651 ns</td><td align="right" bgcolor="#FFFFFF">114,924 ns</td><td align="right" bgcolor="#FFFFFF">121,260 ns</td><td align="right" bgcolor="#FFFFFF">121,634 ns</td><td align="right" bgcolor="#FFFFFF">121,427 ns</td><td align="right" bgcolor="#FFFFFF">115,473 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 13,178 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">73,027 ns</td><td align="right" bgcolor="#FFFFFF">73,359 ns</td><td align="right" bgcolor="#FFFFFF">86,204 ns</td><td align="right" bgcolor="#FFFFFF">78,019 ns</td><td align="right" bgcolor="#FFFFFF">79,943 ns</td><td align="right" bgcolor="#FFFFFF">73,868 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 159,229 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3852,544 ns</td><td align="right" bgcolor="#FFFFFF">3848,236 ns</td><td align="right" bgcolor="#FFFFFF">4007,465 ns</td><td align="right" bgcolor="#FFFFFF">3935,933 ns</td><td align="right" bgcolor="#FFFFFF">3976,495 ns</td><td align="right" bgcolor="#FFFFFF">3860,007 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,853 μs</td><td align="right" bgcolor="#FFFFFF">3,848 μs</td><td align="right" bgcolor="#FFFFFF">4,007 μs</td><td align="right" bgcolor="#FFFFFF">3,936 μs</td><td align="right" bgcolor="#FFFFFF">3,976 μs</td><td align="right" bgcolor="#FFFFFF">3,860 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">244,000 (Δ = -80,000)</td><td align="right" bgcolor="#FFFFFF">244,000</td><td align="right" bgcolor="#FFFFFF">244,000</td><td align="right" bgcolor="#FF4949">324,000 (Δ = +80,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,238 (Δ = -0,078)</td><td align="right" bgcolor="#FFFFFF">0,238</td><td align="right" bgcolor="#FFFFFF">0,238</td><td align="right" bgcolor="#FF4949">0,316 (Δ = +0,078)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 119,948 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">851,357 ns</td><td align="right" bgcolor="#FFFFFF">884,824 ns</td><td align="right" bgcolor="#FFFFFF">933,778 ns</td><td align="right" bgcolor="#FFFFFF">946,072 ns</td><td align="right" bgcolor="#FFFFFF">971,305 ns</td><td align="right" bgcolor="#FFFFFF">965,462 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,851 μs</td><td align="right" bgcolor="#FFFFFF">0,885 μs</td><td align="right" bgcolor="#FFFFFF">0,934 μs</td><td align="right" bgcolor="#FFFFFF">0,946 μs</td><td align="right" bgcolor="#FFFFFF">0,971 μs</td><td align="right" bgcolor="#FFFFFF">0,965 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#A8D08D">55,500 (Δ = -18,500)</td><td align="right" bgcolor="#FFFFFF">55,500</td><td align="right" bgcolor="#FFFFFF">55,500</td><td align="right" bgcolor="#FF4949">74,000 (Δ = +18,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#A8D08D">0,054 (Δ = -0,018)</td><td align="right" bgcolor="#FFFFFF">0,054</td><td align="right" bgcolor="#FFFFFF">0,054</td><td align="right" bgcolor="#FF4949">0,072 (Δ = +0,018)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 136,270 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4752,132 ns</td><td align="right" bgcolor="#FFFFFF">4693,400 ns</td><td align="right" bgcolor="#FFFFFF">4829,670 ns</td><td align="right" bgcolor="#FFFFFF">4823,680 ns</td><td align="right" bgcolor="#FFFFFF">4775,172 ns</td><td align="right" bgcolor="#FFFFFF">4755,725 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,752 μs</td><td align="right" bgcolor="#FFFFFF">4,693 μs</td><td align="right" bgcolor="#FFFFFF">4,830 μs</td><td align="right" bgcolor="#FFFFFF">4,824 μs</td><td align="right" bgcolor="#FFFFFF">4,775 μs</td><td align="right" bgcolor="#FFFFFF">4,756 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">586,000</td><td align="right" bgcolor="#FFFFFF">586,000</td><td align="right" bgcolor="#A8D08D">444,500 (Δ = -141,500)</td><td align="right" bgcolor="#FFFFFF">444,500</td><td align="right" bgcolor="#FFFFFF">444,500</td><td align="right" bgcolor="#FF4949">586,000 (Δ = +141,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,572</td><td align="right" bgcolor="#FFFFFF">0,572</td><td align="right" bgcolor="#A8D08D">0,434 (Δ = -0,138)</td><td align="right" bgcolor="#FFFFFF">0,434</td><td align="right" bgcolor="#FFFFFF">0,434</td><td align="right" bgcolor="#FF4949">0,572 (Δ = +0,138)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 107,655 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3846,920 ns</td><td align="right" bgcolor="#FFFFFF">3831,133 ns</td><td align="right" bgcolor="#FFFFFF">3938,788 ns</td><td align="right" bgcolor="#FFFFFF">3931,240 ns</td><td align="right" bgcolor="#FFFFFF">3920,428 ns</td><td align="right" bgcolor="#FFFFFF">3858,915 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,847 μs</td><td align="right" bgcolor="#FFFFFF">3,831 μs</td><td align="right" bgcolor="#FFFFFF">3,939 μs</td><td align="right" bgcolor="#FFFFFF">3,931 μs</td><td align="right" bgcolor="#FFFFFF">3,920 μs</td><td align="right" bgcolor="#FFFFFF">3,859 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">244,000 (Δ = -80,000)</td><td align="right" bgcolor="#FFFFFF">244,000</td><td align="right" bgcolor="#FFFFFF">244,000</td><td align="right" bgcolor="#FF4949">324,000 (Δ = +80,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,238 (Δ = -0,078)</td><td align="right" bgcolor="#FFFFFF">0,238</td><td align="right" bgcolor="#FFFFFF">0,238</td><td align="right" bgcolor="#FF4949">0,316 (Δ = +0,078)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 110,704 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">851,090 ns</td><td align="right" bgcolor="#FFFFFF">883,032 ns</td><td align="right" bgcolor="#FFFFFF">932,476 ns</td><td align="right" bgcolor="#FFFFFF">939,782 ns</td><td align="right" bgcolor="#FFFFFF">961,794 ns</td><td align="right" bgcolor="#FFFFFF">942,868 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,851 μs</td><td align="right" bgcolor="#FFFFFF">0,883 μs</td><td align="right" bgcolor="#FFFFFF">0,932 μs</td><td align="right" bgcolor="#FFFFFF">0,940 μs</td><td align="right" bgcolor="#FFFFFF">0,962 μs</td><td align="right" bgcolor="#FFFFFF">0,943 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#A8D08D">55,500 (Δ = -18,500)</td><td align="right" bgcolor="#FFFFFF">55,500</td><td align="right" bgcolor="#FFFFFF">55,500</td><td align="right" bgcolor="#FF4949">74,000 (Δ = +18,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#A8D08D">0,054 (Δ = -0,018)</td><td align="right" bgcolor="#FFFFFF">0,054</td><td align="right" bgcolor="#FFFFFF">0,054</td><td align="right" bgcolor="#FF4949">0,072 (Δ = +0,018)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 98,951 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">767,896 ns</td><td align="right" bgcolor="#FFFFFF">744,509 ns</td><td align="right" bgcolor="#FFFFFF">843,460 ns</td><td align="right" bgcolor="#FFFFFF">813,968 ns</td><td align="right" bgcolor="#FFFFFF">836,081 ns</td><td align="right" bgcolor="#FFFFFF">805,593 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,768 μs</td><td align="right" bgcolor="#FFFFFF">0,745 μs</td><td align="right" bgcolor="#FFFFFF">0,843 μs</td><td align="right" bgcolor="#FFFFFF">0,814 μs</td><td align="right" bgcolor="#FFFFFF">0,836 μs</td><td align="right" bgcolor="#FFFFFF">0,806 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+29,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FFFFFF">127,000</td><td align="right" bgcolor="#FF4949">164,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FFFFFF">0,124</td><td align="right" bgcolor="#FF4949">0,160 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="ResourceHelper_Benchmark"></a>ResourceHelper_Benchmark

### <a name="ResourceHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 123,047 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">543,812 ns</td><td align="right" bgcolor="#FFFFFF">420,971 ns</td><td align="right" bgcolor="#FFFFFF">457,654 ns</td><td align="right" bgcolor="#FFFFFF">431,136 ns</td><td align="right" bgcolor="#FFFFFF">420,765 ns</td><td align="right" bgcolor="#FFFFFF">422,563 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,544 μs</td><td align="right" bgcolor="#FFFFFF">0,421 μs</td><td align="right" bgcolor="#FFFFFF">0,458 μs</td><td align="right" bgcolor="#FFFFFF">0,431 μs</td><td align="right" bgcolor="#FFFFFF">0,421 μs</td><td align="right" bgcolor="#FFFFFF">0,423 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#A8D08D">194,500 (Δ = -63,500)</td><td align="right" bgcolor="#FFFFFF">194,500</td><td align="right" bgcolor="#FFFFFF">194,500</td><td align="right" bgcolor="#FF4949">258,000 (Δ = +63,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#A8D08D">0,190 (Δ = -0,062)</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FFFFFF">0,190</td><td align="right" bgcolor="#FF4949">0,252 (Δ = +0,062)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="ScopeManager_Benchmark"></a>ScopeManager_Benchmark

### <a name="ScopeManager_Benchmark_Get_Existing_ScopeManager"></a>Get_Existing_ScopeManager

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 51,073 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">193,050 ns</td><td align="right" bgcolor="#FFFFFF">147,232 ns</td><td align="right" bgcolor="#FFFFFF">143,029 ns</td><td align="right" bgcolor="#FFFFFF">142,641 ns</td><td align="right" bgcolor="#FFFFFF">141,978 ns</td><td align="right" bgcolor="#FFFFFF">142,058 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,3 %</td><td align="right" bgcolor="#A8D08D">-26,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+35,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -90,000)</td><td align="right" bgcolor="#A8D08D">18,500 (Δ = -6,500)</td><td align="right" bgcolor="#FFFFFF">18,500</td><td align="right" bgcolor="#FFFFFF">18,500</td><td align="right" bgcolor="#FF4949">25,000 (Δ = +6,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,088)</td><td align="right" bgcolor="#A8D08D">0,018 (Δ = -0,006)</td><td align="right" bgcolor="#FFFFFF">0,018</td><td align="right" bgcolor="#FFFFFF">0,018</td><td align="right" bgcolor="#FF4949">0,024 (Δ = +0,006)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ScopeManager_Benchmark_Get_New_ScopeManager"></a>Get_New_ScopeManager

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 49,668 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">192,172 ns</td><td align="right" bgcolor="#FFFFFF">155,343 ns</td><td align="right" bgcolor="#FFFFFF">142,504 ns</td><td align="right" bgcolor="#FFFFFF">143,684 ns</td><td align="right" bgcolor="#FFFFFF">142,671 ns</td><td align="right" bgcolor="#FFFFFF">142,800 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,3 %</td><td align="right" bgcolor="#A8D08D">-26,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+35,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -90,000)</td><td align="right" bgcolor="#A8D08D">18,500 (Δ = -6,500)</td><td align="right" bgcolor="#FFFFFF">18,500</td><td align="right" bgcolor="#FFFFFF">18,500</td><td align="right" bgcolor="#FF4949">25,000 (Δ = +6,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,088)</td><td align="right" bgcolor="#A8D08D">0,018 (Δ = -0,006)</td><td align="right" bgcolor="#FFFFFF">0,018</td><td align="right" bgcolor="#FFFFFF">0,018</td><td align="right" bgcolor="#FF4949">0,024 (Δ = +0,006)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 108571,192 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,0 %</td><td align="right" bgcolor="#A8D08D">-15,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">658549,206 ns</td><td align="right" bgcolor="#A8D08D">651970,746 ns (Δ = -6578,460 ns)</td><td align="right" bgcolor="#A8D08D">552618,241 ns (Δ = -99352,505 ns)</td><td align="right" bgcolor="#FFFFFF">549978,013 ns</td><td align="right" bgcolor="#FFFFFF">553725,998 ns</td><td align="right" bgcolor="#FF4949">647840,325 ns (Δ = +94114,327 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">658,549 μs</td><td align="right" bgcolor="#FFFFFF">651,971 μs</td><td align="right" bgcolor="#FFFFFF">552,618 μs</td><td align="right" bgcolor="#FFFFFF">549,978 μs</td><td align="right" bgcolor="#FFFFFF">553,726 μs</td><td align="right" bgcolor="#FFFFFF">647,840 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,659 ms</td><td align="right" bgcolor="#FFFFFF">0,652 ms</td><td align="right" bgcolor="#FFFFFF">0,553 ms</td><td align="right" bgcolor="#FFFFFF">0,550 ms</td><td align="right" bgcolor="#FFFFFF">0,554 ms</td><td align="right" bgcolor="#FFFFFF">0,648 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">35,000</td><td align="right" bgcolor="#A8D08D">32,000 (Δ = -3,000)</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">28,000</td><td align="right" bgcolor="#FFFFFF">28,000</td><td align="right" bgcolor="#FF4949">32,000 (Δ = +4,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#A8D08D">6,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">5,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FF4949">6,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,8 %</td><td align="right" bgcolor="#A8D08D">-19,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+23,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">110667,500</td><td align="right" bgcolor="#A8D08D">103134,000 (Δ = -7533,500)</td><td align="right" bgcolor="#A8D08D">83497,000 (Δ = -19637,000)</td><td align="right" bgcolor="#FF4949">83497,500 (Δ = +0,500)</td><td align="right" bgcolor="#A8D08D">83496,500 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">103132,000 (Δ = +19635,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">108,074</td><td align="right" bgcolor="#A8D08D">100,717 (Δ = -7,357)</td><td align="right" bgcolor="#A8D08D">81,540 (Δ = -19,177)</td><td align="right" bgcolor="#FF4949">81,541 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">81,540 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">100,715 (Δ = +19,175)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,106</td><td align="right" bgcolor="#A8D08D">0,098 (Δ = -0,007)</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,019)</td><td align="right" bgcolor="#FF4949">0,080 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,098 (Δ = +0,019)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 106948,944 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">418397,786 ns</td><td align="right" bgcolor="#FFFFFF">418264,838 ns</td><td align="right" bgcolor="#A8D08D">319967,264 ns (Δ = -98297,573 ns)</td><td align="right" bgcolor="#FFFFFF">322991,303 ns</td><td align="right" bgcolor="#FFFFFF">320501,260 ns</td><td align="right" bgcolor="#FF4949">426916,208 ns (Δ = +106414,948 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">418,398 μs</td><td align="right" bgcolor="#FFFFFF">418,265 μs</td><td align="right" bgcolor="#FFFFFF">319,967 μs</td><td align="right" bgcolor="#FFFFFF">322,991 μs</td><td align="right" bgcolor="#FFFFFF">320,501 μs</td><td align="right" bgcolor="#FFFFFF">426,916 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,418 ms</td><td align="right" bgcolor="#FFFFFF">0,418 ms</td><td align="right" bgcolor="#FFFFFF">0,320 ms</td><td align="right" bgcolor="#FFFFFF">0,323 ms</td><td align="right" bgcolor="#FFFFFF">0,321 ms</td><td align="right" bgcolor="#FFFFFF">0,427 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#FFFFFF">12,000</td><td align="right" bgcolor="#A8D08D">9,500 (Δ = -2,500)</td><td align="right" bgcolor="#FFFFFF">9,500</td><td align="right" bgcolor="#FFFFFF">9,500</td><td align="right" bgcolor="#FF4949">12,000 (Δ = +2,500)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#A8D08D">3,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#A8D08D">-23,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+30,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">39199,500</td><td align="right" bgcolor="#A8D08D">37909,500 (Δ = -1290,000)</td><td align="right" bgcolor="#A8D08D">28961,000 (Δ = -8948,500)</td><td align="right" bgcolor="#FFFFFF">28961,000</td><td align="right" bgcolor="#FFFFFF">28961,000</td><td align="right" bgcolor="#FF4949">37901,000 (Δ = +8940,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">38,281</td><td align="right" bgcolor="#A8D08D">37,021 (Δ = -1,260)</td><td align="right" bgcolor="#A8D08D">28,282 (Δ = -8,739)</td><td align="right" bgcolor="#FFFFFF">28,282</td><td align="right" bgcolor="#FFFFFF">28,282</td><td align="right" bgcolor="#FF4949">37,013 (Δ = +8,730)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,037</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,028 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FF4949">0,036 (Δ = +0,009)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.3.0**

Slowest: 5.4.0

Δ: 108787,546 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+24,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">562653,328 ns</td><td align="right" bgcolor="#FFFFFF">558229,010 ns</td><td align="right" bgcolor="#A8D08D">458621,754 ns (Δ = -99607,256 ns)</td><td align="right" bgcolor="#FFFFFF">455803,744 ns</td><td align="right" bgcolor="#FFFFFF">454227,129 ns</td><td align="right" bgcolor="#FF4949">563014,675 ns (Δ = +108787,546 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">562,653 μs</td><td align="right" bgcolor="#FFFFFF">558,229 μs</td><td align="right" bgcolor="#FFFFFF">458,622 μs</td><td align="right" bgcolor="#FFFFFF">455,804 μs</td><td align="right" bgcolor="#FFFFFF">454,227 μs</td><td align="right" bgcolor="#FFFFFF">563,015 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,563 ms</td><td align="right" bgcolor="#FFFFFF">0,558 ms</td><td align="right" bgcolor="#FFFFFF">0,459 ms</td><td align="right" bgcolor="#FFFFFF">0,456 ms</td><td align="right" bgcolor="#FFFFFF">0,454 ms</td><td align="right" bgcolor="#FFFFFF">0,563 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">27,000</td><td align="right" bgcolor="#A8D08D">26,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">22,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">22,000</td><td align="right" bgcolor="#FFFFFF">22,000</td><td align="right" bgcolor="#FF4949">26,000 (Δ = +4,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FFFFFF">6,000</td><td align="right" bgcolor="#FF4949">7,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#A8D08D">6,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#A8D08D">-20,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+26,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">87815,500</td><td align="right" bgcolor="#A8D08D">82281,000 (Δ = -5534,500)</td><td align="right" bgcolor="#A8D08D">65077,500 (Δ = -17203,500)</td><td align="right" bgcolor="#FFFFFF">65077,500</td><td align="right" bgcolor="#A8D08D">65077,000 (Δ = -0,500)</td><td align="right" bgcolor="#FF4949">82272,000 (Δ = +17195,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">85,757</td><td align="right" bgcolor="#A8D08D">80,353 (Δ = -5,405)</td><td align="right" bgcolor="#A8D08D">63,552 (Δ = -16,800)</td><td align="right" bgcolor="#FFFFFF">63,552</td><td align="right" bgcolor="#A8D08D">63,552 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">80,344 (Δ = +16,792)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#A8D08D">0,078 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">0,062 (Δ = -0,016)</td><td align="right" bgcolor="#FFFFFF">0,062</td><td align="right" bgcolor="#A8D08D">0,062 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,078 (Δ = +0,016)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 129943,564 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,0 %</td><td align="right" bgcolor="#A8D08D">-7,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1331205,261 ns</td><td align="right" bgcolor="#A8D08D">1304088,615 ns (Δ = -27116,646 ns)</td><td align="right" bgcolor="#A8D08D">1211233,656 ns (Δ = -92854,959 ns)</td><td align="right" bgcolor="#FFFFFF">1201261,697 ns</td><td align="right" bgcolor="#FFFFFF">1203041,537 ns</td><td align="right" bgcolor="#FF4949">1325452,045 ns (Δ = +122410,508 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1331,205 μs</td><td align="right" bgcolor="#FFFFFF">1304,089 μs</td><td align="right" bgcolor="#FFFFFF">1211,234 μs</td><td align="right" bgcolor="#FFFFFF">1201,262 μs</td><td align="right" bgcolor="#FFFFFF">1203,042 μs</td><td align="right" bgcolor="#FFFFFF">1325,452 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,331 ms</td><td align="right" bgcolor="#FFFFFF">1,304 ms</td><td align="right" bgcolor="#FFFFFF">1,211 ms</td><td align="right" bgcolor="#FFFFFF">1,201 ms</td><td align="right" bgcolor="#FFFFFF">1,203 ms</td><td align="right" bgcolor="#FFFFFF">1,325 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">107,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">85,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">85,000</td><td align="right" bgcolor="#FFFFFF">85,000</td><td align="right" bgcolor="#FF4949">98,000 (Δ = +13,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">17,500</td><td align="right" bgcolor="#A8D08D">17,000 (Δ = -0,500)</td><td align="right" bgcolor="#A8D08D">14,000 (Δ = -3,000)</td><td align="right" bgcolor="#FFFFFF">14,000</td><td align="right" bgcolor="#FFFFFF">14,000</td><td align="right" bgcolor="#FF4949">17,000 (Δ = +3,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,0 %</td><td align="right" bgcolor="#A8D08D">-19,3 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+23,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">337097,500</td><td align="right" bgcolor="#A8D08D">310258,000 (Δ = -26839,500)</td><td align="right" bgcolor="#A8D08D">250482,000 (Δ = -59776,000)</td><td align="right" bgcolor="#FF4949">250486,000 (Δ = +4,000)</td><td align="right" bgcolor="#A8D08D">250483,500 (Δ = -2,500)</td><td align="right" bgcolor="#FF4949">310240,000 (Δ = +59756,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">329,197</td><td align="right" bgcolor="#A8D08D">302,986 (Δ = -26,210)</td><td align="right" bgcolor="#A8D08D">244,611 (Δ = -58,375)</td><td align="right" bgcolor="#FF4949">244,615 (Δ = +0,004)</td><td align="right" bgcolor="#A8D08D">244,613 (Δ = -0,002)</td><td align="right" bgcolor="#FF4949">302,969 (Δ = +58,356)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,321</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,026)</td><td align="right" bgcolor="#A8D08D">0,239 (Δ = -0,057)</td><td align="right" bgcolor="#FF4949">0,239 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,239 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,296 (Δ = +0,057)</td></tr></table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 759376,140 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,0 %</td><td align="right" bgcolor="#FF4949">+2,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17462857,995 ns</td><td align="right" bgcolor="#A8D08D">17116483,693 ns (Δ = -346374,302 ns)</td><td align="right" bgcolor="#FF4949">17584198,164 ns (Δ = +467714,472 ns)</td><td align="right" bgcolor="#FFFFFF">17722765,985 ns</td><td align="right" bgcolor="#FFFFFF">17601284,300 ns</td><td align="right" bgcolor="#A8D08D">16963389,845 ns (Δ = -637894,455 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">17462,858 μs</td><td align="right" bgcolor="#A8D08D">17116,484 μs (Δ = -346,374 μs)</td><td align="right" bgcolor="#FF4949">17584,198 μs (Δ = +467,714 μs)</td><td align="right" bgcolor="#FFFFFF">17722,766 μs</td><td align="right" bgcolor="#FFFFFF">17601,284 μs</td><td align="right" bgcolor="#A8D08D">16963,390 μs (Δ = -637,894 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">17,463 ms</td><td align="right" bgcolor="#FFFFFF">17,116 ms</td><td align="right" bgcolor="#FFFFFF">17,584 ms</td><td align="right" bgcolor="#FFFFFF">17,723 ms</td><td align="right" bgcolor="#FFFFFF">17,601 ms</td><td align="right" bgcolor="#FFFFFF">16,963 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">491,000</td><td align="right" bgcolor="#A8D08D">478,000 (Δ = -13,000)</td><td align="right" bgcolor="#A8D08D">388,500 (Δ = -89,500)</td><td align="right" bgcolor="#FFFFFF">388,500</td><td align="right" bgcolor="#FFFFFF">388,500</td><td align="right" bgcolor="#FF4949">478,000 (Δ = +89,500)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">163,000</td><td align="right" bgcolor="#A8D08D">159,000 (Δ = -4,000)</td><td align="right" bgcolor="#A8D08D">129,000 (Δ = -30,000)</td><td align="right" bgcolor="#FFFFFF">129,000</td><td align="right" bgcolor="#FFFFFF">129,000</td><td align="right" bgcolor="#FF4949">159,000 (Δ = +30,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,7 %</td><td align="right" bgcolor="#A8D08D">-23,9 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+31,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1547039,000</td><td align="right" bgcolor="#A8D08D">1504690,000 (Δ = -42349,000)</td><td align="right" bgcolor="#A8D08D">1145500,500 (Δ = -359189,500)</td><td align="right" bgcolor="#A8D08D">1145255,500 (Δ = -245,000)</td><td align="right" bgcolor="#A8D08D">1144922,000 (Δ = -333,500)</td><td align="right" bgcolor="#FF4949">1505137,000 (Δ = +360215,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1510,780</td><td align="right" bgcolor="#A8D08D">1469,424 (Δ = -41,356)</td><td align="right" bgcolor="#A8D08D">1118,653 (Δ = -350,771)</td><td align="right" bgcolor="#A8D08D">1118,414 (Δ = -0,239)</td><td align="right" bgcolor="#A8D08D">1118,088 (Δ = -0,326)</td><td align="right" bgcolor="#FF4949">1469,860 (Δ = +351,772)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,475</td><td align="right" bgcolor="#A8D08D">1,435 (Δ = -0,040)</td><td align="right" bgcolor="#A8D08D">1,092 (Δ = -0,343)</td><td align="right" bgcolor="#A8D08D">1,092 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">1,092 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">1,435 (Δ = +0,344)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 75867,825 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1087660,040 ns</td><td align="right" bgcolor="#FFFFFF">1079038,929 ns</td><td align="right" bgcolor="#A8D08D">1014222,166 ns (Δ = -64816,763 ns)</td><td align="right" bgcolor="#FFFFFF">1019418,024 ns</td><td align="right" bgcolor="#FFFFFF">1011792,215 ns</td><td align="right" bgcolor="#FF4949">1076981,562 ns (Δ = +65189,347 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1087,660 μs</td><td align="right" bgcolor="#FFFFFF">1079,039 μs</td><td align="right" bgcolor="#FFFFFF">1014,222 μs</td><td align="right" bgcolor="#FFFFFF">1019,418 μs</td><td align="right" bgcolor="#FFFFFF">1011,792 μs</td><td align="right" bgcolor="#FFFFFF">1076,982 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,088 ms</td><td align="right" bgcolor="#FFFFFF">1,079 ms</td><td align="right" bgcolor="#FFFFFF">1,014 ms</td><td align="right" bgcolor="#FFFFFF">1,019 ms</td><td align="right" bgcolor="#FFFFFF">1,012 ms</td><td align="right" bgcolor="#FFFFFF">1,077 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">27,000</td><td align="right" bgcolor="#FFFFFF">27,000</td><td align="right" bgcolor="#A8D08D">22,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">22,000</td><td align="right" bgcolor="#FFFFFF">22,000</td><td align="right" bgcolor="#FF4949">27,000 (Δ = +5,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FFFFFF">9,000</td><td align="right" bgcolor="#FF4949">13,000 (Δ = +4,000)</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#FFFFFF">13,000</td><td align="right" bgcolor="#A8D08D">9,000 (Δ = -4,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#A8D08D">-23,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">86985,000</td><td align="right" bgcolor="#A8D08D">85308,000 (Δ = -1677,000)</td><td align="right" bgcolor="#A8D08D">65004,000 (Δ = -20304,000)</td><td align="right" bgcolor="#FFFFFF">65004,000</td><td align="right" bgcolor="#FFFFFF">65004,000</td><td align="right" bgcolor="#FF4949">85199,000 (Δ = +20195,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">84,946</td><td align="right" bgcolor="#A8D08D">83,309 (Δ = -1,638)</td><td align="right" bgcolor="#A8D08D">63,480 (Δ = -19,828)</td><td align="right" bgcolor="#FFFFFF">63,480</td><td align="right" bgcolor="#FFFFFF">63,480</td><td align="right" bgcolor="#FF4949">83,202 (Δ = +19,722)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,083</td><td align="right" bgcolor="#A8D08D">0,081 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,062 (Δ = -0,019)</td><td align="right" bgcolor="#FFFFFF">0,062</td><td align="right" bgcolor="#FFFFFF">0,062</td><td align="right" bgcolor="#FF4949">0,081 (Δ = +0,019)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 86576,975 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3223224,093 ns</td><td align="right" bgcolor="#A8D08D">3160904,151 ns (Δ = -62319,943 ns)</td><td align="right" bgcolor="#FFFFFF">3187474,077 ns</td><td align="right" bgcolor="#FFFFFF">3196882,143 ns</td><td align="right" bgcolor="#FFFFFF">3185826,706 ns</td><td align="right" bgcolor="#A8D08D">3136647,118 ns (Δ = -49179,587 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3223,224 μs</td><td align="right" bgcolor="#FFFFFF">3160,904 μs</td><td align="right" bgcolor="#FFFFFF">3187,474 μs</td><td align="right" bgcolor="#FFFFFF">3196,882 μs</td><td align="right" bgcolor="#FFFFFF">3185,827 μs</td><td align="right" bgcolor="#FFFFFF">3136,647 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,223 ms</td><td align="right" bgcolor="#FFFFFF">3,161 ms</td><td align="right" bgcolor="#FFFFFF">3,187 ms</td><td align="right" bgcolor="#FFFFFF">3,197 ms</td><td align="right" bgcolor="#FFFFFF">3,186 ms</td><td align="right" bgcolor="#FFFFFF">3,137 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">5.3.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">89,000</td><td align="right" bgcolor="#A8D08D">87,000 (Δ = -2,000)</td><td align="right" bgcolor="#A8D08D">70,500 (Δ = -16,500)</td><td align="right" bgcolor="#FFFFFF">70,500</td><td align="right" bgcolor="#FFFFFF">70,500</td><td align="right" bgcolor="#FF4949">87,000 (Δ = +16,500)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">26,000</td><td align="right" bgcolor="#A8D08D">24,500 (Δ = -1,500)</td><td align="right" bgcolor="#FF4949">39,000 (Δ = +14,500)</td><td align="right" bgcolor="#FFFFFF">39,000</td><td align="right" bgcolor="#FF4949">39,500 (Δ = +0,500)</td><td align="right" bgcolor="#A8D08D">24,000 (Δ = -15,500)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,8 %</td><td align="right" bgcolor="#A8D08D">-24,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#FF4949">+31,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">281767,000</td><td align="right" bgcolor="#A8D08D">273987,500 (Δ = -7779,500)</td><td align="right" bgcolor="#A8D08D">208084,000 (Δ = -65903,500)</td><td align="right" bgcolor="#FFFFFF">208084,000</td><td align="right" bgcolor="#FF4949">208366,500 (Δ = +282,500)</td><td align="right" bgcolor="#FF4949">273728,000 (Δ = +65361,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">275,163</td><td align="right" bgcolor="#A8D08D">267,566 (Δ = -7,597)</td><td align="right" bgcolor="#A8D08D">203,207 (Δ = -64,359)</td><td align="right" bgcolor="#FFFFFF">203,207</td><td align="right" bgcolor="#FF4949">203,483 (Δ = +0,276)</td><td align="right" bgcolor="#FF4949">267,313 (Δ = +63,830)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,269</td><td align="right" bgcolor="#A8D08D">0,261 (Δ = -0,007)</td><td align="right" bgcolor="#A8D08D">0,198 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,198</td><td align="right" bgcolor="#FF4949">0,199 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,261 (Δ = +0,062)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 624469,328 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,6 %</td><td align="right" bgcolor="#FF4949">+3,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13856912,187 ns</td><td align="right" bgcolor="#A8D08D">13502106,521 ns (Δ = -354805,666 ns)</td><td align="right" bgcolor="#FF4949">14009308,105 ns (Δ = +507201,584 ns)</td><td align="right" bgcolor="#FFFFFF">14085968,097 ns</td><td align="right" bgcolor="#FFFFFF">13989792,987 ns</td><td align="right" bgcolor="#A8D08D">13461498,768 ns (Δ = -528294,218 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13856,912 μs</td><td align="right" bgcolor="#A8D08D">13502,107 μs (Δ = -354,806 μs)</td><td align="right" bgcolor="#FF4949">14009,308 μs (Δ = +507,202 μs)</td><td align="right" bgcolor="#FFFFFF">14085,968 μs</td><td align="right" bgcolor="#FFFFFF">13989,793 μs</td><td align="right" bgcolor="#A8D08D">13461,499 μs (Δ = -528,294 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">13,857 ms</td><td align="right" bgcolor="#FFFFFF">13,502 ms</td><td align="right" bgcolor="#FFFFFF">14,009 ms</td><td align="right" bgcolor="#FFFFFF">14,086 ms</td><td align="right" bgcolor="#FFFFFF">13,990 ms</td><td align="right" bgcolor="#FFFFFF">13,461 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">401,000</td><td align="right" bgcolor="#A8D08D">387,000 (Δ = -14,000)</td><td align="right" bgcolor="#A8D08D">313,500 (Δ = -73,500)</td><td align="right" bgcolor="#FFFFFF">313,500</td><td align="right" bgcolor="#FFFFFF">313,500</td><td align="right" bgcolor="#FF4949">386,000 (Δ = +72,500)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">111,000</td><td align="right" bgcolor="#A8D08D">104,000 (Δ = -7,000)</td><td align="right" bgcolor="#A8D08D">78,000 (Δ = -26,000)</td><td align="right" bgcolor="#FFFFFF">78,000</td><td align="right" bgcolor="#FF4949">79,500 (Δ = +1,500)</td><td align="right" bgcolor="#FF4949">96,000 (Δ = +16,500)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#A8D08D">-24,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+31,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1263087,000</td><td align="right" bgcolor="#A8D08D">1218479,000 (Δ = -44608,000)</td><td align="right" bgcolor="#A8D08D">925287,500 (Δ = -293191,500)</td><td align="right" bgcolor="#FFFFFF">925287,500</td><td align="right" bgcolor="#FF4949">925613,000 (Δ = +325,500)</td><td align="right" bgcolor="#FF4949">1216307,000 (Δ = +290694,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1233,483</td><td align="right" bgcolor="#A8D08D">1189,921 (Δ = -43,563)</td><td align="right" bgcolor="#A8D08D">903,601 (Δ = -286,320)</td><td align="right" bgcolor="#FFFFFF">903,601</td><td align="right" bgcolor="#FF4949">903,919 (Δ = +0,318)</td><td align="right" bgcolor="#FF4949">1187,800 (Δ = +283,881)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,205</td><td align="right" bgcolor="#A8D08D">1,162 (Δ = -0,043)</td><td align="right" bgcolor="#A8D08D">0,882 (Δ = -0,280)</td><td align="right" bgcolor="#FFFFFF">0,882</td><td align="right" bgcolor="#FF4949">0,883 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">1,160 (Δ = +0,277)</td></tr></table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 139485,450 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,3 %</td><td align="right" bgcolor="#A8D08D">-8,4 %</td><td align="right" bgcolor="#FF4949">+1,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1326085,878 ns</td><td align="right" bgcolor="#A8D08D">1308552,860 ns (Δ = -17533,019 ns)</td><td align="right" bgcolor="#A8D08D">1198022,983 ns (Δ = -110529,876 ns)</td><td align="right" bgcolor="#FF4949">1212896,174 ns (Δ = +14873,191 ns)</td><td align="right" bgcolor="#FFFFFF">1216563,379 ns</td><td align="right" bgcolor="#FF4949">1337508,433 ns (Δ = +120945,054 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1326,086 μs</td><td align="right" bgcolor="#FFFFFF">1308,553 μs</td><td align="right" bgcolor="#FFFFFF">1198,023 μs</td><td align="right" bgcolor="#FFFFFF">1212,896 μs</td><td align="right" bgcolor="#FFFFFF">1216,563 μs</td><td align="right" bgcolor="#FFFFFF">1337,508 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,326 ms</td><td align="right" bgcolor="#FFFFFF">1,309 ms</td><td align="right" bgcolor="#FFFFFF">1,198 ms</td><td align="right" bgcolor="#FFFFFF">1,213 ms</td><td align="right" bgcolor="#FFFFFF">1,217 ms</td><td align="right" bgcolor="#FFFFFF">1,338 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">186,000</td><td align="right" bgcolor="#A8D08D">183,000 (Δ = -3,000)</td><td align="right" bgcolor="#FF4949">186,500 (Δ = +3,500)</td><td align="right" bgcolor="#FFFFFF">186,500</td><td align="right" bgcolor="#FFFFFF">186,500</td><td align="right" bgcolor="#A8D08D">183,000 (Δ = -3,500)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">30,500</td><td align="right" bgcolor="#A8D08D">30,000 (Δ = -0,500)</td><td align="right" bgcolor="#A8D08D">28,500 (Δ = -1,500)</td><td align="right" bgcolor="#FFFFFF">28,500</td><td align="right" bgcolor="#A8D08D">28,000 (Δ = -0,500)</td><td align="right" bgcolor="#FF4949">30,000 (Δ = +2,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,7 %</td><td align="right" bgcolor="#A8D08D">-6,7 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+7,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">587235,500</td><td align="right" bgcolor="#A8D08D">577343,500 (Δ = -9892,000)</td><td align="right" bgcolor="#A8D08D">538939,000 (Δ = -38404,500)</td><td align="right" bgcolor="#FF4949">538952,000 (Δ = +13,000)</td><td align="right" bgcolor="#A8D08D">538928,000 (Δ = -24,000)</td><td align="right" bgcolor="#FF4949">577326,000 (Δ = +38398,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">573,472</td><td align="right" bgcolor="#A8D08D">563,812 (Δ = -9,660)</td><td align="right" bgcolor="#A8D08D">526,308 (Δ = -37,504)</td><td align="right" bgcolor="#FF4949">526,320 (Δ = +0,013)</td><td align="right" bgcolor="#A8D08D">526,297 (Δ = -0,023)</td><td align="right" bgcolor="#FF4949">563,795 (Δ = +37,498)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,560</td><td align="right" bgcolor="#A8D08D">0,551 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,514 (Δ = -0,037)</td><td align="right" bgcolor="#FF4949">0,514 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,514 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,551 (Δ = +0,037)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.3.0**

Slowest: 5.4.0

Δ: 115706,911 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,7 %</td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+28,6 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">502387,576 ns</td><td align="right" bgcolor="#FF4949">511038,105 ns (Δ = +8650,529 ns)</td><td align="right" bgcolor="#A8D08D">425240,409 ns (Δ = -85797,696 ns)</td><td align="right" bgcolor="#A8D08D">407024,564 ns (Δ = -18215,845 ns)</td><td align="right" bgcolor="#FFFFFF">404356,836 ns</td><td align="right" bgcolor="#FF4949">520063,747 ns (Δ = +115706,911 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">502,388 μs</td><td align="right" bgcolor="#FFFFFF">511,038 μs</td><td align="right" bgcolor="#FFFFFF">425,240 μs</td><td align="right" bgcolor="#FFFFFF">407,025 μs</td><td align="right" bgcolor="#FFFFFF">404,357 μs</td><td align="right" bgcolor="#FFFFFF">520,064 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,502 ms</td><td align="right" bgcolor="#FFFFFF">0,511 ms</td><td align="right" bgcolor="#FFFFFF">0,425 ms</td><td align="right" bgcolor="#FFFFFF">0,407 ms</td><td align="right" bgcolor="#FFFFFF">0,404 ms</td><td align="right" bgcolor="#FFFFFF">0,520 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td><td align="right" bgcolor="#FFFFFF">43,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FFFFFF">7,000</td><td align="right" bgcolor="#FF4949">25,000 (Δ = +18,000)</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">7,000 (Δ = -18,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#A8D08D">-8,3 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">138496,500</td><td align="right" bgcolor="#A8D08D">136498,500 (Δ = -1998,000)</td><td align="right" bgcolor="#A8D08D">125157,000 (Δ = -11341,500)</td><td align="right" bgcolor="#FF4949">125164,000 (Δ = +7,000)</td><td align="right" bgcolor="#FFFFFF">125164,000</td><td align="right" bgcolor="#FF4949">136456,000 (Δ = +11292,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">135,250</td><td align="right" bgcolor="#A8D08D">133,299 (Δ = -1,951)</td><td align="right" bgcolor="#A8D08D">122,224 (Δ = -11,076)</td><td align="right" bgcolor="#FF4949">122,230 (Δ = +0,007)</td><td align="right" bgcolor="#FFFFFF">122,230</td><td align="right" bgcolor="#FF4949">133,258 (Δ = +11,027)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#A8D08D">0,130 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,119 (Δ = -0,011)</td><td align="right" bgcolor="#FF4949">0,119 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,119</td><td align="right" bgcolor="#FF4949">0,130 (Δ = +0,011)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 154650,449 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,3 %</td><td align="right" bgcolor="#A8D08D">-13,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,7 %</td><td align="right" bgcolor="#FF4949">+18,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">892929,368 ns</td><td align="right" bgcolor="#A8D08D">881120,979 ns (Δ = -11808,388 ns)</td><td align="right" bgcolor="#A8D08D">764488,493 ns (Δ = -116632,487 ns)</td><td align="right" bgcolor="#FFFFFF">765805,750 ns</td><td align="right" bgcolor="#FF4949">778827,154 ns (Δ = +13021,404 ns)</td><td align="right" bgcolor="#FF4949">919138,942 ns (Δ = +140311,788 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">892,929 μs</td><td align="right" bgcolor="#FFFFFF">881,121 μs</td><td align="right" bgcolor="#FFFFFF">764,488 μs</td><td align="right" bgcolor="#FFFFFF">765,806 μs</td><td align="right" bgcolor="#FFFFFF">778,827 μs</td><td align="right" bgcolor="#FFFFFF">919,139 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,893 ms</td><td align="right" bgcolor="#FFFFFF">0,881 ms</td><td align="right" bgcolor="#FFFFFF">0,764 ms</td><td align="right" bgcolor="#FFFFFF">0,766 ms</td><td align="right" bgcolor="#FFFFFF">0,779 ms</td><td align="right" bgcolor="#FFFFFF">0,919 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">5.3.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">138,000</td><td align="right" bgcolor="#A8D08D">136,000 (Δ = -2,000)</td><td align="right" bgcolor="#FF4949">139,000 (Δ = +3,000)</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#A8D08D">136,000 (Δ = -3,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">17,000</td><td align="right" bgcolor="#A8D08D">15,000 (Δ = -2,000)</td><td align="right" bgcolor="#FF4949">24,500 (Δ = +9,500)</td><td align="right" bgcolor="#FF4949">29,500 (Δ = +5,000)</td><td align="right" bgcolor="#FF4949">78,500 (Δ = +49,000)</td><td align="right" bgcolor="#A8D08D">15,000 (Δ = -63,500)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#A8D08D">-6,6 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+7,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">437418,000</td><td align="right" bgcolor="#A8D08D">429251,000 (Δ = -8167,000)</td><td align="right" bgcolor="#A8D08D">401113,000 (Δ = -28138,000)</td><td align="right" bgcolor="#FF4949">401124,000 (Δ = +11,000)</td><td align="right" bgcolor="#A8D08D">401116,500 (Δ = -7,500)</td><td align="right" bgcolor="#FF4949">429258,000 (Δ = +28141,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">427,166</td><td align="right" bgcolor="#A8D08D">419,190 (Δ = -7,976)</td><td align="right" bgcolor="#A8D08D">391,712 (Δ = -27,479)</td><td align="right" bgcolor="#FF4949">391,723 (Δ = +0,011)</td><td align="right" bgcolor="#A8D08D">391,715 (Δ = -0,007)</td><td align="right" bgcolor="#FF4949">419,197 (Δ = +27,482)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,417</td><td align="right" bgcolor="#A8D08D">0,409 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,383 (Δ = -0,027)</td><td align="right" bgcolor="#FF4949">0,383 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,383 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,409 (Δ = +0,027)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.2.0**

Slowest: 5.4.0

Δ: 290794,340 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#A8D08D">-6,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,3 %</td><td align="right" bgcolor="#FF4949">+8,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2827115,055 ns</td><td align="right" bgcolor="#A8D08D">2788064,756 ns (Δ = -39050,299 ns)</td><td align="right" bgcolor="#A8D08D">2602249,937 ns (Δ = -185814,819 ns)</td><td align="right" bgcolor="#FFFFFF">2590637,210 ns</td><td align="right" bgcolor="#FF4949">2650228,397 ns (Δ = +59591,187 ns)</td><td align="right" bgcolor="#FF4949">2881431,550 ns (Δ = +231203,153 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2827,115 μs</td><td align="right" bgcolor="#FFFFFF">2788,065 μs</td><td align="right" bgcolor="#FFFFFF">2602,250 μs</td><td align="right" bgcolor="#FFFFFF">2590,637 μs</td><td align="right" bgcolor="#FFFFFF">2650,228 μs</td><td align="right" bgcolor="#FFFFFF">2881,432 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,827 ms</td><td align="right" bgcolor="#FFFFFF">2,788 ms</td><td align="right" bgcolor="#FFFFFF">2,602 ms</td><td align="right" bgcolor="#FFFFFF">2,591 ms</td><td align="right" bgcolor="#FFFFFF">2,650 ms</td><td align="right" bgcolor="#FFFFFF">2,881 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 1</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">613,000</td><td align="right" bgcolor="#A8D08D">601,000 (Δ = -12,000)</td><td align="right" bgcolor="#FF4949">617,500 (Δ = +16,500)</td><td align="right" bgcolor="#FFFFFF">617,500</td><td align="right" bgcolor="#FFFFFF">617,500</td><td align="right" bgcolor="#A8D08D">601,000 (Δ = -16,500)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">101,000</td><td align="right" bgcolor="#A8D08D">98,500 (Δ = -2,500)</td><td align="right" bgcolor="#A8D08D">97,000 (Δ = -1,500)</td><td align="right" bgcolor="#A8D08D">96,500 (Δ = -0,500)</td><td align="right" bgcolor="#FF4949">97,000 (Δ = +0,500)</td><td align="right" bgcolor="#FF4949">99,000 (Δ = +2,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,0 %</td><td align="right" bgcolor="#A8D08D">-6,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+6,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1930844,000</td><td align="right" bgcolor="#A8D08D">1892602,000 (Δ = -38242,000)</td><td align="right" bgcolor="#A8D08D">1779267,500 (Δ = -113334,500)</td><td align="right" bgcolor="#FF4949">1779305,000 (Δ = +37,500)</td><td align="right" bgcolor="#FF4949">1779308,000 (Δ = +3,000)</td><td align="right" bgcolor="#FF4949">1892536,000 (Δ = +113228,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1885,590</td><td align="right" bgcolor="#A8D08D">1848,244 (Δ = -37,346)</td><td align="right" bgcolor="#A8D08D">1737,566 (Δ = -110,678)</td><td align="right" bgcolor="#FF4949">1737,603 (Δ = +0,037)</td><td align="right" bgcolor="#FF4949">1737,605 (Δ = +0,003)</td><td align="right" bgcolor="#FF4949">1848,180 (Δ = +110,574)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,841</td><td align="right" bgcolor="#A8D08D">1,805 (Δ = -0,036)</td><td align="right" bgcolor="#A8D08D">1,697 (Δ = -0,108)</td><td align="right" bgcolor="#FF4949">1,697 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">1,697 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">1,805 (Δ = +0,108)</td></tr></table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 253,306 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">746,489 ns</td><td align="right" bgcolor="#FF4949">999,795 ns (Δ = +253,306 ns)</td><td align="right" bgcolor="#FFFFFF">965,540 ns</td><td align="right" bgcolor="#FFFFFF">958,980 ns</td><td align="right" bgcolor="#FFFFFF">956,663 ns</td><td align="right" bgcolor="#FFFFFF">905,318 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,746 μs</td><td align="right" bgcolor="#FFFFFF">1,000 μs</td><td align="right" bgcolor="#FFFFFF">0,966 μs</td><td align="right" bgcolor="#FFFFFF">0,959 μs</td><td align="right" bgcolor="#FFFFFF">0,957 μs</td><td align="right" bgcolor="#FFFFFF">0,905 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,2 %</td><td align="right" bgcolor="#A8D08D">-13,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1056,500</td><td align="right" bgcolor="#A8D08D">938,000 (Δ = -118,500)</td><td align="right" bgcolor="#A8D08D">815,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">815,000</td><td align="right" bgcolor="#FFFFFF">815,000</td><td align="right" bgcolor="#FF4949">954,000 (Δ = +139,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,032</td><td align="right" bgcolor="#A8D08D">0,916 (Δ = -0,116)</td><td align="right" bgcolor="#A8D08D">0,796 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,796</td><td align="right" bgcolor="#FFFFFF">0,796</td><td align="right" bgcolor="#FF4949">0,932 (Δ = +0,136)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 10,563 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">193,076 ns</td><td align="right" bgcolor="#FFFFFF">192,255 ns</td><td align="right" bgcolor="#FFFFFF">198,793 ns</td><td align="right" bgcolor="#FFFFFF">192,116 ns</td><td align="right" bgcolor="#FFFFFF">192,882 ns</td><td align="right" bgcolor="#FFFFFF">188,230 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,199 μs</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+28,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#A8D08D">114,500 (Δ = -32,500)</td><td align="right" bgcolor="#FFFFFF">114,500</td><td align="right" bgcolor="#FFFFFF">114,500</td><td align="right" bgcolor="#FF4949">147,000 (Δ = +32,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#A8D08D">0,112 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FF4949">0,144 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Transient"></a>ResolveType_Transient

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 270,802 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2921,280 ns</td><td align="right" bgcolor="#FF4949">3176,779 ns (Δ = +255,499 ns)</td><td align="right" bgcolor="#FFFFFF">3062,333 ns</td><td align="right" bgcolor="#FFFFFF">2957,598 ns</td><td align="right" bgcolor="#FFFFFF">2957,706 ns</td><td align="right" bgcolor="#FFFFFF">3192,082 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,921 μs</td><td align="right" bgcolor="#FFFFFF">3,177 μs</td><td align="right" bgcolor="#FFFFFF">3,062 μs</td><td align="right" bgcolor="#FFFFFF">2,958 μs</td><td align="right" bgcolor="#FFFFFF">2,958 μs</td><td align="right" bgcolor="#FFFFFF">3,192 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td><td align="right" bgcolor="#A8D08D">-20,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+25,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1409,000</td><td align="right" bgcolor="#FF4949">1417,000 (Δ = +8,000)</td><td align="right" bgcolor="#A8D08D">1132,500 (Δ = -284,500)</td><td align="right" bgcolor="#FFFFFF">1132,500</td><td align="right" bgcolor="#FFFFFF">1132,500</td><td align="right" bgcolor="#FF4949">1417,000 (Δ = +284,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,376</td><td align="right" bgcolor="#FF4949">1,384 (Δ = +0,008)</td><td align="right" bgcolor="#A8D08D">1,106 (Δ = -0,278)</td><td align="right" bgcolor="#FFFFFF">1,106</td><td align="right" bgcolor="#FFFFFF">1,106</td><td align="right" bgcolor="#FF4949">1,384 (Δ = +0,278)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 11,655 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">189,578 ns</td><td align="right" bgcolor="#FFFFFF">190,435 ns</td><td align="right" bgcolor="#FFFFFF">194,883 ns</td><td align="right" bgcolor="#FFFFFF">192,145 ns</td><td align="right" bgcolor="#FFFFFF">192,555 ns</td><td align="right" bgcolor="#FFFFFF">183,228 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,190 μs</td><td align="right" bgcolor="#FFFFFF">0,190 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FFFFFF">0,183 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+28,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#A8D08D">114,500 (Δ = -32,500)</td><td align="right" bgcolor="#FFFFFF">114,500</td><td align="right" bgcolor="#FFFFFF">114,500</td><td align="right" bgcolor="#FF4949">147,000 (Δ = +32,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#A8D08D">0,112 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FF4949">0,144 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency"></a>ResolveType_With_Transient_Dependency

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 936,480 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6973,770 ns</td><td align="right" bgcolor="#A8D08D">6334,576 ns (Δ = -639,194 ns)</td><td align="right" bgcolor="#FFFFFF">6158,270 ns</td><td align="right" bgcolor="#FFFFFF">6037,290 ns</td><td align="right" bgcolor="#FFFFFF">6225,440 ns</td><td align="right" bgcolor="#FFFFFF">6451,893 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,974 μs</td><td align="right" bgcolor="#FFFFFF">6,335 μs</td><td align="right" bgcolor="#FFFFFF">6,158 μs</td><td align="right" bgcolor="#FFFFFF">6,037 μs</td><td align="right" bgcolor="#FFFFFF">6,225 μs</td><td align="right" bgcolor="#FFFFFF">6,452 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,6 %</td><td align="right" bgcolor="#A8D08D">-20,3 %</td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+25,5 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3162,500</td><td align="right" bgcolor="#A8D08D">3017,500 (Δ = -145,000)</td><td align="right" bgcolor="#A8D08D">2405,500 (Δ = -612,000)</td><td align="right" bgcolor="#FF4949">2407,500 (Δ = +2,000)</td><td align="right" bgcolor="#A8D08D">2406,500 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">3019,000 (Δ = +612,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,088</td><td align="right" bgcolor="#A8D08D">2,947 (Δ = -0,142)</td><td align="right" bgcolor="#A8D08D">2,349 (Δ = -0,598)</td><td align="right" bgcolor="#FF4949">2,351 (Δ = +0,002)</td><td align="right" bgcolor="#A8D08D">2,350 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">2,948 (Δ = +0,598)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,001)</td></tr></table>


## <a name="TagHelper_Benchmark"></a>TagHelper_Benchmark

### <a name="TagHelper_Benchmark_AreTagsEqual"></a>AreTagsEqual

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 2,702 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,391 ns</td><td align="right" bgcolor="#FFFFFF">9,182 ns</td><td align="right" bgcolor="#FFFFFF">10,669 ns</td><td align="right" bgcolor="#FFFFFF">10,880 ns</td><td align="right" bgcolor="#FFFFFF">11,883 ns</td><td align="right" bgcolor="#FFFFFF">9,465 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TagHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 1047,053 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20967,734 ns</td><td align="right" bgcolor="#A8D08D">20052,739 ns (Δ = -914,995 ns)</td><td align="right" bgcolor="#FFFFFF">19982,799 ns</td><td align="right" bgcolor="#FFFFFF">19920,682 ns</td><td align="right" bgcolor="#FFFFFF">19964,773 ns</td><td align="right" bgcolor="#FF4949">20618,052 ns (Δ = +653,279 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">20,968 μs</td><td align="right" bgcolor="#FFFFFF">20,053 μs</td><td align="right" bgcolor="#FFFFFF">19,983 μs</td><td align="right" bgcolor="#FFFFFF">19,921 μs</td><td align="right" bgcolor="#FFFFFF">19,965 μs</td><td align="right" bgcolor="#FFFFFF">20,618 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">5.1.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#FFFFFF">3,000</td><td align="right" bgcolor="#A8D08D">2,500 (Δ = -0,500)</td><td align="right" bgcolor="#FFFFFF">2,500</td><td align="right" bgcolor="#FFFFFF">2,500</td><td align="right" bgcolor="#FF4949">3,000 (Δ = +0,500)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,8 %</td><td align="right" bgcolor="#A8D08D">-0,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">10994,000</td><td align="right" bgcolor="#FFFFFF">10994,000</td><td align="right" bgcolor="#A8D08D">8268,000 (Δ = -2726,000)</td><td align="right" bgcolor="#A8D08D">8244,000 (Δ = -24,000)</td><td align="right" bgcolor="#FFFFFF">8244,000</td><td align="right" bgcolor="#FF4949">10962,000 (Δ = +2718,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">10,736</td><td align="right" bgcolor="#FFFFFF">10,736</td><td align="right" bgcolor="#A8D08D">8,074 (Δ = -2,662)</td><td align="right" bgcolor="#A8D08D">8,051 (Δ = -0,023)</td><td align="right" bgcolor="#FFFFFF">8,051</td><td align="right" bgcolor="#FF4949">10,705 (Δ = +2,654)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#A8D08D">0,008 (Δ = -0,003)</td><td align="right" bgcolor="#A8D08D">0,008 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,008</td><td align="right" bgcolor="#FF4949">0,010 (Δ = +0,003)</td></tr></table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 3,729 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,472 ns</td><td align="right" bgcolor="#FFFFFF">25,533 ns</td><td align="right" bgcolor="#FFFFFF">29,263 ns</td><td align="right" bgcolor="#FFFFFF">27,408 ns</td><td align="right" bgcolor="#FFFFFF">27,638 ns</td><td align="right" bgcolor="#FFFFFF">25,598 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyEx"></a>GetAssemblyEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 3,654 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,772 ns</td><td align="right" bgcolor="#FFFFFF">18,770 ns</td><td align="right" bgcolor="#FFFFFF">22,424 ns</td><td align="right" bgcolor="#FFFFFF">21,902 ns</td><td align="right" bgcolor="#FFFFFF">22,000 ns</td><td align="right" bgcolor="#FFFFFF">19,352 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx"></a>GetAssemblyFullNameEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 4,810 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,486 ns</td><td align="right" bgcolor="#FFFFFF">20,449 ns</td><td align="right" bgcolor="#FFFFFF">25,110 ns</td><td align="right" bgcolor="#FFFFFF">24,666 ns</td><td align="right" bgcolor="#FFFFFF">23,868 ns</td><td align="right" bgcolor="#FFFFFF">20,300 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetBaseTypeEx"></a>GetBaseTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 4,099 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,570 ns</td><td align="right" bgcolor="#FFFFFF">25,792 ns</td><td align="right" bgcolor="#FFFFFF">29,891 ns</td><td align="right" bgcolor="#FFFFFF">29,741 ns</td><td align="right" bgcolor="#FFFFFF">29,828 ns</td><td align="right" bgcolor="#FFFFFF">26,747 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorEx"></a>GetConstructorEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 21,914 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">264,543 ns</td><td align="right" bgcolor="#FFFFFF">265,284 ns</td><td align="right" bgcolor="#FFFFFF">284,227 ns</td><td align="right" bgcolor="#FFFFFF">286,086 ns</td><td align="right" bgcolor="#FFFFFF">286,458 ns</td><td align="right" bgcolor="#FFFFFF">272,277 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,284 μs</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#A8D08D">98,500 (Δ = -32,500)</td><td align="right" bgcolor="#FFFFFF">98,500</td><td align="right" bgcolor="#FFFFFF">98,500</td><td align="right" bgcolor="#FF4949">131,000 (Δ = +32,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,032)</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FFFFFF">0,096</td><td align="right" bgcolor="#FF4949">0,128 (Δ = +0,032)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorsEx"></a>GetConstructorsEx

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 6,607 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">79,471 ns</td><td align="right" bgcolor="#FFFFFF">78,662 ns</td><td align="right" bgcolor="#FFFFFF">75,391 ns</td><td align="right" bgcolor="#FFFFFF">78,277 ns</td><td align="right" bgcolor="#FFFFFF">76,779 ns</td><td align="right" bgcolor="#FFFFFF">81,998 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,079 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td><td align="right" bgcolor="#FFFFFF">0,082 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">24,500 (Δ = -8,500)</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +8,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,008)</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 167,561 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3364,964 ns</td><td align="right" bgcolor="#FFFFFF">3391,272 ns</td><td align="right" bgcolor="#FFFFFF">3506,654 ns</td><td align="right" bgcolor="#FFFFFF">3478,031 ns</td><td align="right" bgcolor="#FFFFFF">3516,047 ns</td><td align="right" bgcolor="#FFFFFF">3532,525 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,365 μs</td><td align="right" bgcolor="#FFFFFF">3,391 μs</td><td align="right" bgcolor="#FFFFFF">3,507 μs</td><td align="right" bgcolor="#FFFFFF">3,478 μs</td><td align="right" bgcolor="#FFFFFF">3,516 μs</td><td align="right" bgcolor="#FFFFFF">3,533 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">213,000 (Δ = -70,000)</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FF4949">283,000 (Δ = +70,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,208 (Δ = -0,068)</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FF4949">0,276 (Δ = +0,068)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 1252,943 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,1 %</td><td align="right" bgcolor="#FF4949">+7,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8412,158 ns</td><td align="right" bgcolor="#FF4949">9013,051 ns (Δ = +600,892 ns)</td><td align="right" bgcolor="#FF4949">9646,922 ns (Δ = +633,871 ns)</td><td align="right" bgcolor="#FFFFFF">9632,102 ns</td><td align="right" bgcolor="#FFFFFF">9665,101 ns</td><td align="right" bgcolor="#A8D08D">9309,127 ns (Δ = -355,974 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,412 μs</td><td align="right" bgcolor="#FFFFFF">9,013 μs</td><td align="right" bgcolor="#FFFFFF">9,647 μs</td><td align="right" bgcolor="#FFFFFF">9,632 μs</td><td align="right" bgcolor="#FFFFFF">9,665 μs</td><td align="right" bgcolor="#FFFFFF">9,309 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +49,000)</td><td align="right" bgcolor="#A8D08D">610,500 (Δ = -200,500)</td><td align="right" bgcolor="#FFFFFF">610,500</td><td align="right" bgcolor="#FFFFFF">610,500</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +200,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,048)</td><td align="right" bgcolor="#A8D08D">0,596 (Δ = -0,196)</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,196)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 142,110 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3483,457 ns</td><td align="right" bgcolor="#FFFFFF">3370,903 ns</td><td align="right" bgcolor="#FFFFFF">3473,284 ns</td><td align="right" bgcolor="#FFFFFF">3513,012 ns</td><td align="right" bgcolor="#FFFFFF">3497,839 ns</td><td align="right" bgcolor="#FFFFFF">3508,330 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,483 μs</td><td align="right" bgcolor="#FFFFFF">3,371 μs</td><td align="right" bgcolor="#FFFFFF">3,473 μs</td><td align="right" bgcolor="#FFFFFF">3,513 μs</td><td align="right" bgcolor="#FFFFFF">3,498 μs</td><td align="right" bgcolor="#FFFFFF">3,508 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">213,000 (Δ = -70,000)</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FFFFFF">213,000</td><td align="right" bgcolor="#FF4949">283,000 (Δ = +70,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,208 (Δ = -0,068)</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FFFFFF">0,208</td><td align="right" bgcolor="#FF4949">0,276 (Δ = +0,068)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 1300,170 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,6 %</td><td align="right" bgcolor="#FF4949">+7,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8352,887 ns</td><td align="right" bgcolor="#FF4949">8986,157 ns (Δ = +633,270 ns)</td><td align="right" bgcolor="#FF4949">9651,038 ns (Δ = +664,882 ns)</td><td align="right" bgcolor="#FFFFFF">9630,463 ns</td><td align="right" bgcolor="#FFFFFF">9653,057 ns</td><td align="right" bgcolor="#A8D08D">9259,893 ns (Δ = -393,163 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,353 μs</td><td align="right" bgcolor="#FFFFFF">8,986 μs</td><td align="right" bgcolor="#FFFFFF">9,651 μs</td><td align="right" bgcolor="#FFFFFF">9,630 μs</td><td align="right" bgcolor="#FFFFFF">9,653 μs</td><td align="right" bgcolor="#FFFFFF">9,260 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +49,000)</td><td align="right" bgcolor="#A8D08D">610,500 (Δ = -200,500)</td><td align="right" bgcolor="#FFFFFF">610,500</td><td align="right" bgcolor="#FFFFFF">610,500</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +200,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,048)</td><td align="right" bgcolor="#A8D08D">0,596 (Δ = -0,196)</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,196)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 0,783 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,381 ns</td><td align="right" bgcolor="#FFFFFF">7,258 ns</td><td align="right" bgcolor="#FFFFFF">7,966 ns</td><td align="right" bgcolor="#FFFFFF">7,808 ns</td><td align="right" bgcolor="#FFFFFF">8,040 ns</td><td align="right" bgcolor="#FFFFFF">7,733 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 38,854 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">726,339 ns</td><td align="right" bgcolor="#FFFFFF">713,292 ns</td><td align="right" bgcolor="#FFFFFF">692,922 ns</td><td align="right" bgcolor="#FFFFFF">687,485 ns</td><td align="right" bgcolor="#FFFFFF">691,653 ns</td><td align="right" bgcolor="#FFFFFF">721,562 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,726 μs</td><td align="right" bgcolor="#FFFFFF">0,713 μs</td><td align="right" bgcolor="#FFFFFF">0,693 μs</td><td align="right" bgcolor="#FFFFFF">0,687 μs</td><td align="right" bgcolor="#FFFFFF">0,692 μs</td><td align="right" bgcolor="#FFFFFF">0,722 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">182,500 (Δ = -59,500)</td><td align="right" bgcolor="#FFFFFF">182,500</td><td align="right" bgcolor="#FFFFFF">182,500</td><td align="right" bgcolor="#FF4949">242,000 (Δ = +59,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,178 (Δ = -0,058)</td><td align="right" bgcolor="#FFFFFF">0,178</td><td align="right" bgcolor="#FFFFFF">0,178</td><td align="right" bgcolor="#FF4949">0,236 (Δ = +0,058)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Instance"></a>GetEventEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 13,813 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">110,961 ns</td><td align="right" bgcolor="#FFFFFF">97,148 ns</td><td align="right" bgcolor="#FFFFFF">100,605 ns</td><td align="right" bgcolor="#FFFFFF">97,705 ns</td><td align="right" bgcolor="#FFFFFF">98,865 ns</td><td align="right" bgcolor="#FFFFFF">99,668 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,111 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 332,078 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2714,381 ns</td><td align="right" bgcolor="#A8D08D">2382,302 ns (Δ = -332,078 ns)</td><td align="right" bgcolor="#FFFFFF">2501,108 ns</td><td align="right" bgcolor="#FFFFFF">2389,261 ns</td><td align="right" bgcolor="#FFFFFF">2442,418 ns</td><td align="right" bgcolor="#FFFFFF">2412,628 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,714 μs</td><td align="right" bgcolor="#FFFFFF">2,382 μs</td><td align="right" bgcolor="#FFFFFF">2,501 μs</td><td align="right" bgcolor="#FFFFFF">2,389 μs</td><td align="right" bgcolor="#FFFFFF">2,442 μs</td><td align="right" bgcolor="#FFFFFF">2,413 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,7 %</td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -24,000)</td><td align="right" bgcolor="#A8D08D">151,500 (Δ = -49,500)</td><td align="right" bgcolor="#FFFFFF">151,500</td><td align="right" bgcolor="#FFFFFF">151,500</td><td align="right" bgcolor="#FF4949">201,000 (Δ = +49,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,023)</td><td align="right" bgcolor="#A8D08D">0,148 (Δ = -0,048)</td><td align="right" bgcolor="#FFFFFF">0,148</td><td align="right" bgcolor="#FFFFFF">0,148</td><td align="right" bgcolor="#FF4949">0,196 (Δ = +0,048)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 190,412 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1191,243 ns</td><td align="right" bgcolor="#FFFFFF">1024,398 ns</td><td align="right" bgcolor="#FFFFFF">1007,916 ns</td><td align="right" bgcolor="#FFFFFF">1089,118 ns</td><td align="right" bgcolor="#FFFFFF">1000,831 ns</td><td align="right" bgcolor="#FFFFFF">1020,038 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,191 μs</td><td align="right" bgcolor="#FFFFFF">1,024 μs</td><td align="right" bgcolor="#FFFFFF">1,008 μs</td><td align="right" bgcolor="#FFFFFF">1,089 μs</td><td align="right" bgcolor="#FFFFFF">1,001 μs</td><td align="right" bgcolor="#FFFFFF">1,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#A8D08D">-24,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">475,000</td><td align="right" bgcolor="#A8D08D">401,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">301,000 (Δ = -100,000)</td><td align="right" bgcolor="#FFFFFF">301,000</td><td align="right" bgcolor="#FFFFFF">301,000</td><td align="right" bgcolor="#FF4949">401,000 (Δ = +100,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,464</td><td align="right" bgcolor="#A8D08D">0,392 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,294 (Δ = -0,098)</td><td align="right" bgcolor="#FFFFFF">0,294</td><td align="right" bgcolor="#FFFFFF">0,294</td><td align="right" bgcolor="#FF4949">0,392 (Δ = +0,098)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 166,727 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">603,021 ns</td><td align="right" bgcolor="#FFFFFF">439,497 ns</td><td align="right" bgcolor="#FFFFFF">445,341 ns</td><td align="right" bgcolor="#FFFFFF">448,546 ns</td><td align="right" bgcolor="#FFFFFF">452,427 ns</td><td align="right" bgcolor="#FFFFFF">436,293 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,603 μs</td><td align="right" bgcolor="#FFFFFF">0,439 μs</td><td align="right" bgcolor="#FFFFFF">0,445 μs</td><td align="right" bgcolor="#FFFFFF">0,449 μs</td><td align="right" bgcolor="#FFFFFF">0,452 μs</td><td align="right" bgcolor="#FFFFFF">0,436 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,8 %</td><td align="right" bgcolor="#A8D08D">-24,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">303,000 (Δ = -148,000)</td><td align="right" bgcolor="#A8D08D">227,500 (Δ = -75,500)</td><td align="right" bgcolor="#FFFFFF">227,500</td><td align="right" bgcolor="#FFFFFF">227,500</td><td align="right" bgcolor="#FF4949">303,000 (Δ = +75,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,145)</td><td align="right" bgcolor="#A8D08D">0,222 (Δ = -0,074)</td><td align="right" bgcolor="#FFFFFF">0,222</td><td align="right" bgcolor="#FFFFFF">0,222</td><td align="right" bgcolor="#FF4949">0,296 (Δ = +0,074)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 52,292 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">745,583 ns</td><td align="right" bgcolor="#FFFFFF">719,338 ns</td><td align="right" bgcolor="#FFFFFF">693,291 ns</td><td align="right" bgcolor="#FFFFFF">701,723 ns</td><td align="right" bgcolor="#FFFFFF">704,000 ns</td><td align="right" bgcolor="#FFFFFF">722,730 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,746 μs</td><td align="right" bgcolor="#FFFFFF">0,719 μs</td><td align="right" bgcolor="#FFFFFF">0,693 μs</td><td align="right" bgcolor="#FFFFFF">0,702 μs</td><td align="right" bgcolor="#FFFFFF">0,704 μs</td><td align="right" bgcolor="#FFFFFF">0,723 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">182,500 (Δ = -59,500)</td><td align="right" bgcolor="#FFFFFF">182,500</td><td align="right" bgcolor="#FFFFFF">182,500</td><td align="right" bgcolor="#FF4949">242,000 (Δ = +59,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,178 (Δ = -0,058)</td><td align="right" bgcolor="#FFFFFF">0,178</td><td align="right" bgcolor="#FFFFFF">0,178</td><td align="right" bgcolor="#FF4949">0,236 (Δ = +0,058)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags"></a>GetFieldEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 14,057 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">101,763 ns</td><td align="right" bgcolor="#FFFFFF">97,539 ns</td><td align="right" bgcolor="#FFFFFF">101,811 ns</td><td align="right" bgcolor="#FFFFFF">102,905 ns</td><td align="right" bgcolor="#FFFFFF">106,477 ns</td><td align="right" bgcolor="#FFFFFF">111,597 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 14,593 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">124,276 ns</td><td align="right" bgcolor="#FFFFFF">109,683 ns</td><td align="right" bgcolor="#FFFFFF">110,401 ns</td><td align="right" bgcolor="#FFFFFF">112,674 ns</td><td align="right" bgcolor="#FFFFFF">118,056 ns</td><td align="right" bgcolor="#FFFFFF">123,455 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 5.1.0

Δ: 11,805 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">102,399 ns</td><td align="right" bgcolor="#FFFFFF">102,636 ns</td><td align="right" bgcolor="#FFFFFF">113,109 ns</td><td align="right" bgcolor="#FFFFFF">101,304 ns</td><td align="right" bgcolor="#FFFFFF">104,843 ns</td><td align="right" bgcolor="#FFFFFF">106,965 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 62,026 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">547,722 ns</td><td align="right" bgcolor="#FFFFFF">581,991 ns</td><td align="right" bgcolor="#FFFFFF">609,748 ns</td><td align="right" bgcolor="#FFFFFF">593,393 ns</td><td align="right" bgcolor="#FFFFFF">580,974 ns</td><td align="right" bgcolor="#FFFFFF">593,327 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,548 μs</td><td align="right" bgcolor="#FFFFFF">0,582 μs</td><td align="right" bgcolor="#FFFFFF">0,610 μs</td><td align="right" bgcolor="#FFFFFF">0,593 μs</td><td align="right" bgcolor="#FFFFFF">0,581 μs</td><td align="right" bgcolor="#FFFFFF">0,593 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,0 %</td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FF4949">+10,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">274,000</td><td align="right" bgcolor="#FF4949">315,000 (Δ = +41,000)</td><td align="right" bgcolor="#A8D08D">237,500 (Δ = -77,500)</td><td align="right" bgcolor="#FF4949">262,000 (Δ = +24,500)</td><td align="right" bgcolor="#FFFFFF">262,000</td><td align="right" bgcolor="#FF4949">348,000 (Δ = +86,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,268</td><td align="right" bgcolor="#FF4949">0,308 (Δ = +0,040)</td><td align="right" bgcolor="#A8D08D">0,232 (Δ = -0,076)</td><td align="right" bgcolor="#FF4949">0,256 (Δ = +0,024)</td><td align="right" bgcolor="#FFFFFF">0,256</td><td align="right" bgcolor="#FF4949">0,340 (Δ = +0,084)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 5.4.0

Δ: 4,901 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">103,931 ns</td><td align="right" bgcolor="#FFFFFF">103,803 ns</td><td align="right" bgcolor="#FFFFFF">101,084 ns</td><td align="right" bgcolor="#FFFFFF">103,706 ns</td><td align="right" bgcolor="#FFFFFF">104,525 ns</td><td align="right" bgcolor="#FFFFFF">105,985 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 117,243 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">872,262 ns</td><td align="right" bgcolor="#FFFFFF">920,154 ns</td><td align="right" bgcolor="#FFFFFF">945,627 ns</td><td align="right" bgcolor="#FFFFFF">977,984 ns</td><td align="right" bgcolor="#FFFFFF">963,653 ns</td><td align="right" bgcolor="#FFFFFF">989,505 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,872 μs</td><td align="right" bgcolor="#FFFFFF">0,920 μs</td><td align="right" bgcolor="#FFFFFF">0,946 μs</td><td align="right" bgcolor="#FFFFFF">0,978 μs</td><td align="right" bgcolor="#FFFFFF">0,964 μs</td><td align="right" bgcolor="#FFFFFF">0,990 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,2 %</td><td align="right" bgcolor="#A8D08D">-24,7 %</td><td align="right" bgcolor="#FF4949">+9,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#FF4949">356,000 (Δ = +24,000)</td><td align="right" bgcolor="#A8D08D">268,000 (Δ = -88,000)</td><td align="right" bgcolor="#FF4949">293,000 (Δ = +25,000)</td><td align="right" bgcolor="#FFFFFF">293,000</td><td align="right" bgcolor="#FF4949">389,000 (Δ = +96,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#FF4949">0,348 (Δ = +0,023)</td><td align="right" bgcolor="#A8D08D">0,262 (Δ = -0,086)</td><td align="right" bgcolor="#FF4949">0,286 (Δ = +0,024)</td><td align="right" bgcolor="#FFFFFF">0,286</td><td align="right" bgcolor="#FF4949">0,380 (Δ = +0,094)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 29,454 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">92,508 ns</td><td align="right" bgcolor="#FFFFFF">99,843 ns</td><td align="right" bgcolor="#FFFFFF">95,838 ns</td><td align="right" bgcolor="#FFFFFF">103,960 ns</td><td align="right" bgcolor="#FFFFFF">121,962 ns</td><td align="right" bgcolor="#FFFFFF">105,883 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 39,834 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">155,517 ns</td><td align="right" bgcolor="#FFFFFF">155,011 ns</td><td align="right" bgcolor="#FFFFFF">194,845 ns</td><td align="right" bgcolor="#FFFFFF">192,464 ns</td><td align="right" bgcolor="#FFFFFF">187,240 ns</td><td align="right" bgcolor="#FFFFFF">156,560 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,187 μs</td><td align="right" bgcolor="#FFFFFF">0,157 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">24,500 (Δ = -8,500)</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +8,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,008)</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx"></a>GetGenericTypeDefinitionEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 19,195 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">95,363 ns</td><td align="right" bgcolor="#FFFFFF">94,384 ns</td><td align="right" bgcolor="#FFFFFF">113,579 ns</td><td align="right" bgcolor="#FFFFFF">100,167 ns</td><td align="right" bgcolor="#FFFFFF">113,447 ns</td><td align="right" bgcolor="#FFFFFF">96,588 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetInterfacesEx"></a>GetInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 15,169 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">156,095 ns</td><td align="right" bgcolor="#FFFFFF">140,926 ns</td><td align="right" bgcolor="#FFFFFF">143,061 ns</td><td align="right" bgcolor="#FFFFFF">143,405 ns</td><td align="right" bgcolor="#FFFFFF">146,614 ns</td><td align="right" bgcolor="#FFFFFF">152,407 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,147 μs</td><td align="right" bgcolor="#FFFFFF">0,152 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,2 %</td><td align="right" bgcolor="#A8D08D">-25,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">197,000 (Δ = -20,000)</td><td align="right" bgcolor="#A8D08D">147,500 (Δ = -49,500)</td><td align="right" bgcolor="#FFFFFF">147,500</td><td align="right" bgcolor="#FFFFFF">147,500</td><td align="right" bgcolor="#FF4949">197,000 (Δ = +49,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,192 (Δ = -0,020)</td><td align="right" bgcolor="#A8D08D">0,144 (Δ = -0,048)</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FF4949">0,192 (Δ = +0,048)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 263,218 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1520,492 ns</td><td align="right" bgcolor="#FFFFFF">1338,475 ns</td><td align="right" bgcolor="#FFFFFF">1331,226 ns</td><td align="right" bgcolor="#FFFFFF">1257,274 ns</td><td align="right" bgcolor="#FFFFFF">1263,115 ns</td><td align="right" bgcolor="#FFFFFF">1275,985 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,520 μs</td><td align="right" bgcolor="#FFFFFF">1,338 μs</td><td align="right" bgcolor="#FFFFFF">1,331 μs</td><td align="right" bgcolor="#FFFFFF">1,257 μs</td><td align="right" bgcolor="#FFFFFF">1,263 μs</td><td align="right" bgcolor="#FFFFFF">1,276 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#A8D08D">200,500 (Δ = -65,500)</td><td align="right" bgcolor="#FFFFFF">200,500</td><td align="right" bgcolor="#FFFFFF">200,500</td><td align="right" bgcolor="#FF4949">266,000 (Δ = +65,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,064)</td><td align="right" bgcolor="#FFFFFF">0,196</td><td align="right" bgcolor="#FFFFFF">0,196</td><td align="right" bgcolor="#FF4949">0,260 (Δ = +0,064)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 5.3.0

Δ: 15,938 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">643,780 ns</td><td align="right" bgcolor="#FFFFFF">648,292 ns</td><td align="right" bgcolor="#FFFFFF">635,353 ns</td><td align="right" bgcolor="#FFFFFF">639,847 ns</td><td align="right" bgcolor="#FFFFFF">651,291 ns</td><td align="right" bgcolor="#FFFFFF">649,168 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,644 μs</td><td align="right" bgcolor="#FFFFFF">0,648 μs</td><td align="right" bgcolor="#FFFFFF">0,635 μs</td><td align="right" bgcolor="#FFFFFF">0,640 μs</td><td align="right" bgcolor="#FFFFFF">0,651 μs</td><td align="right" bgcolor="#FFFFFF">0,649 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+28,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">22,500 (Δ = -6,500)</td><td align="right" bgcolor="#FFFFFF">22,500</td><td align="right" bgcolor="#FFFFFF">22,500</td><td align="right" bgcolor="#FF4949">29,000 (Δ = +6,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#A8D08D">0,022 (Δ = -0,006)</td><td align="right" bgcolor="#FFFFFF">0,022</td><td align="right" bgcolor="#FFFFFF">0,022</td><td align="right" bgcolor="#FF4949">0,028 (Δ = +0,006)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance"></a>GetMemberEx_Instance

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 13,358 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">630,567 ns</td><td align="right" bgcolor="#FFFFFF">643,924 ns</td><td align="right" bgcolor="#FFFFFF">634,858 ns</td><td align="right" bgcolor="#FFFFFF">638,231 ns</td><td align="right" bgcolor="#FFFFFF">641,140 ns</td><td align="right" bgcolor="#FFFFFF">632,503 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,631 μs</td><td align="right" bgcolor="#FFFFFF">0,644 μs</td><td align="right" bgcolor="#FFFFFF">0,635 μs</td><td align="right" bgcolor="#FFFFFF">0,638 μs</td><td align="right" bgcolor="#FFFFFF">0,641 μs</td><td align="right" bgcolor="#FFFFFF">0,633 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+29,8 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#A8D08D">28,500 (Δ = -8,500)</td><td align="right" bgcolor="#FFFFFF">28,500</td><td align="right" bgcolor="#FFFFFF">28,500</td><td align="right" bgcolor="#FF4949">37,000 (Δ = +8,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#A8D08D">0,028 (Δ = -0,008)</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FF4949">0,036 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **5.1.0**

Slowest: 5.3.0

Δ: 15,126 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">616,573 ns</td><td align="right" bgcolor="#FFFFFF">614,569 ns</td><td align="right" bgcolor="#FFFFFF">605,333 ns</td><td align="right" bgcolor="#FFFFFF">610,473 ns</td><td align="right" bgcolor="#FFFFFF">620,458 ns</td><td align="right" bgcolor="#FFFFFF">611,003 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,617 μs</td><td align="right" bgcolor="#FFFFFF">0,615 μs</td><td align="right" bgcolor="#FFFFFF">0,605 μs</td><td align="right" bgcolor="#FFFFFF">0,610 μs</td><td align="right" bgcolor="#FFFFFF">0,620 μs</td><td align="right" bgcolor="#FFFFFF">0,611 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+28,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">22,500 (Δ = -6,500)</td><td align="right" bgcolor="#FFFFFF">22,500</td><td align="right" bgcolor="#FFFFFF">22,500</td><td align="right" bgcolor="#FF4949">29,000 (Δ = +6,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#A8D08D">0,022 (Δ = -0,006)</td><td align="right" bgcolor="#FFFFFF">0,022</td><td align="right" bgcolor="#FFFFFF">0,022</td><td align="right" bgcolor="#FF4949">0,028 (Δ = +0,006)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static"></a>GetMethodEx_Flatten_Static

#### Performance

Fastest: **5.1.0**

Slowest: 5.2.0

Δ: 45,347 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">766,030 ns</td><td align="right" bgcolor="#FFFFFF">746,560 ns</td><td align="right" bgcolor="#FFFFFF">724,739 ns</td><td align="right" bgcolor="#FFFFFF">770,086 ns</td><td align="right" bgcolor="#FFFFFF">731,428 ns</td><td align="right" bgcolor="#FFFFFF">743,542 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,766 μs</td><td align="right" bgcolor="#FFFFFF">0,747 μs</td><td align="right" bgcolor="#FFFFFF">0,725 μs</td><td align="right" bgcolor="#FFFFFF">0,770 μs</td><td align="right" bgcolor="#FFFFFF">0,731 μs</td><td align="right" bgcolor="#FFFFFF">0,744 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">182,500 (Δ = -59,500)</td><td align="right" bgcolor="#FFFFFF">182,500</td><td align="right" bgcolor="#FFFFFF">182,500</td><td align="right" bgcolor="#FF4949">242,000 (Δ = +59,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,178 (Δ = -0,058)</td><td align="right" bgcolor="#FFFFFF">0,178</td><td align="right" bgcolor="#FFFFFF">0,178</td><td align="right" bgcolor="#FF4949">0,236 (Δ = +0,058)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags"></a>GetMethodEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 4,875 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">127,411 ns</td><td align="right" bgcolor="#FFFFFF">122,536 ns</td><td align="right" bgcolor="#FFFFFF">125,891 ns</td><td align="right" bgcolor="#FFFFFF">124,038 ns</td><td align="right" bgcolor="#FFFFFF">124,102 ns</td><td align="right" bgcolor="#FFFFFF">125,062 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **5.1.0**

Slowest: 5.0.0

Δ: 6,689 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">137,927 ns</td><td align="right" bgcolor="#FFFFFF">140,622 ns</td><td align="right" bgcolor="#FFFFFF">133,933 ns</td><td align="right" bgcolor="#FFFFFF">136,918 ns</td><td align="right" bgcolor="#FFFFFF">137,513 ns</td><td align="right" bgcolor="#FFFFFF">136,125 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,137 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 17,194 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">125,023 ns</td><td align="right" bgcolor="#FFFFFF">119,641 ns</td><td align="right" bgcolor="#FFFFFF">136,835 ns</td><td align="right" bgcolor="#FFFFFF">124,127 ns</td><td align="right" bgcolor="#FFFFFF">125,283 ns</td><td align="right" bgcolor="#FFFFFF">124,790 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,137 μs</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2254,256 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-30,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7376,891 ns</td><td align="right" bgcolor="#A8D08D">5122,635 ns (Δ = -2254,256 ns)</td><td align="right" bgcolor="#FFFFFF">5307,508 ns</td><td align="right" bgcolor="#FFFFFF">5388,785 ns</td><td align="right" bgcolor="#FFFFFF">5416,744 ns</td><td align="right" bgcolor="#FFFFFF">5288,740 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,377 μs</td><td align="right" bgcolor="#FFFFFF">5,123 μs</td><td align="right" bgcolor="#FFFFFF">5,308 μs</td><td align="right" bgcolor="#FFFFFF">5,389 μs</td><td align="right" bgcolor="#FFFFFF">5,417 μs</td><td align="right" bgcolor="#FFFFFF">5,289 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-30,5 %</td><td align="right" bgcolor="#A8D08D">-23,8 %</td><td align="right" bgcolor="#FF4949">+0,4 %</td><td align="right" bgcolor="#FF4949">+0,8 %</td><td align="right" bgcolor="#FF4949">+33,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">2945,000</td><td align="right" bgcolor="#A8D08D">2048,000 (Δ = -897,000)</td><td align="right" bgcolor="#A8D08D">1560,500 (Δ = -487,500)</td><td align="right" bgcolor="#FF4949">1566,500 (Δ = +6,000)</td><td align="right" bgcolor="#FF4949">1579,000 (Δ = +12,500)</td><td align="right" bgcolor="#FF4949">2105,000 (Δ = +526,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,876</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -0,876)</td><td align="right" bgcolor="#A8D08D">1,524 (Δ = -0,476)</td><td align="right" bgcolor="#FF4949">1,530 (Δ = +0,006)</td><td align="right" bgcolor="#FF4949">1,542 (Δ = +0,012)</td><td align="right" bgcolor="#FF4949">2,056 (Δ = +0,514)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 414,701 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1318,335 ns</td><td align="right" bgcolor="#A8D08D">903,634 ns (Δ = -414,701 ns)</td><td align="right" bgcolor="#FFFFFF">983,262 ns</td><td align="right" bgcolor="#FFFFFF">1055,229 ns</td><td align="right" bgcolor="#FFFFFF">999,815 ns</td><td align="right" bgcolor="#FFFFFF">932,885 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,318 μs</td><td align="right" bgcolor="#FFFFFF">0,904 μs</td><td align="right" bgcolor="#FFFFFF">0,983 μs</td><td align="right" bgcolor="#FFFFFF">1,055 μs</td><td align="right" bgcolor="#FFFFFF">1,000 μs</td><td align="right" bgcolor="#FFFFFF">0,933 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#A8D08D">-12,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">14,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">14,000</td><td align="right" bgcolor="#FFFFFF">14,000</td><td align="right" bgcolor="#FF4949">16,000 (Δ = +2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,014 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,014</td><td align="right" bgcolor="#FFFFFF">0,014</td><td align="right" bgcolor="#FF4949">0,016 (Δ = +0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2389,207 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7072,650 ns</td><td align="right" bgcolor="#A8D08D">4683,443 ns (Δ = -2389,207 ns)</td><td align="right" bgcolor="#FFFFFF">4812,048 ns</td><td align="right" bgcolor="#FFFFFF">4843,336 ns</td><td align="right" bgcolor="#FFFFFF">4966,389 ns</td><td align="right" bgcolor="#FFFFFF">4846,590 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,073 μs</td><td align="right" bgcolor="#FFFFFF">4,683 μs</td><td align="right" bgcolor="#FFFFFF">4,812 μs</td><td align="right" bgcolor="#FFFFFF">4,843 μs</td><td align="right" bgcolor="#FFFFFF">4,966 μs</td><td align="right" bgcolor="#FFFFFF">4,847 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#A8D08D">-23,6 %</td><td align="right" bgcolor="#FF4949">+0,5 %</td><td align="right" bgcolor="#FF4949">+0,9 %</td><td align="right" bgcolor="#FF4949">+33,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">5092,000</td><td align="right" bgcolor="#A8D08D">3466,500 (Δ = -1625,500)</td><td align="right" bgcolor="#A8D08D">2648,000 (Δ = -818,500)</td><td align="right" bgcolor="#FF4949">2660,500 (Δ = +12,500)</td><td align="right" bgcolor="#FF4949">2684,000 (Δ = +23,500)</td><td align="right" bgcolor="#FF4949">3579,000 (Δ = +895,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">4,973</td><td align="right" bgcolor="#A8D08D">3,385 (Δ = -1,587)</td><td align="right" bgcolor="#A8D08D">2,586 (Δ = -0,799)</td><td align="right" bgcolor="#FF4949">2,598 (Δ = +0,012)</td><td align="right" bgcolor="#FF4949">2,621 (Δ = +0,023)</td><td align="right" bgcolor="#FF4949">3,495 (Δ = +0,874)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,005</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 414,416 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1320,491 ns</td><td align="right" bgcolor="#A8D08D">906,075 ns (Δ = -414,416 ns)</td><td align="right" bgcolor="#FFFFFF">985,762 ns</td><td align="right" bgcolor="#FFFFFF">992,966 ns</td><td align="right" bgcolor="#FFFFFF">999,923 ns</td><td align="right" bgcolor="#FFFFFF">1012,514 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,320 μs</td><td align="right" bgcolor="#FFFFFF">0,906 μs</td><td align="right" bgcolor="#FFFFFF">0,986 μs</td><td align="right" bgcolor="#FFFFFF">0,993 μs</td><td align="right" bgcolor="#FFFFFF">1,000 μs</td><td align="right" bgcolor="#FFFFFF">1,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#A8D08D">-12,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">14,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">14,000</td><td align="right" bgcolor="#FFFFFF">14,000</td><td align="right" bgcolor="#FF4949">16,000 (Δ = +2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,014 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,014</td><td align="right" bgcolor="#FFFFFF">0,014</td><td align="right" bgcolor="#FF4949">0,016 (Δ = +0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 139,727 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">728,641 ns</td><td align="right" bgcolor="#FFFFFF">713,024 ns</td><td align="right" bgcolor="#FFFFFF">758,465 ns</td><td align="right" bgcolor="#FFFFFF">814,997 ns</td><td align="right" bgcolor="#FFFFFF">852,752 ns</td><td align="right" bgcolor="#FFFFFF">717,770 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,729 μs</td><td align="right" bgcolor="#FFFFFF">0,713 μs</td><td align="right" bgcolor="#FFFFFF">0,758 μs</td><td align="right" bgcolor="#FFFFFF">0,815 μs</td><td align="right" bgcolor="#FFFFFF">0,853 μs</td><td align="right" bgcolor="#FFFFFF">0,718 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">-23,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">291,000</td><td align="right" bgcolor="#A8D08D">266,000 (Δ = -25,000)</td><td align="right" bgcolor="#A8D08D">202,500 (Δ = -63,500)</td><td align="right" bgcolor="#FFFFFF">202,500</td><td align="right" bgcolor="#FFFFFF">202,500</td><td align="right" bgcolor="#FF4949">266,000 (Δ = +63,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,284</td><td align="right" bgcolor="#A8D08D">0,260 (Δ = -0,024)</td><td align="right" bgcolor="#A8D08D">0,198 (Δ = -0,062)</td><td align="right" bgcolor="#FFFFFF">0,198</td><td align="right" bgcolor="#FFFFFF">0,198</td><td align="right" bgcolor="#FF4949">0,260 (Δ = +0,062)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 258,704 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1568,228 ns</td><td align="right" bgcolor="#FFFFFF">1332,538 ns</td><td align="right" bgcolor="#FFFFFF">1418,785 ns</td><td align="right" bgcolor="#FFFFFF">1324,763 ns</td><td align="right" bgcolor="#FFFFFF">1309,523 ns</td><td align="right" bgcolor="#FFFFFF">1330,455 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,568 μs</td><td align="right" bgcolor="#FFFFFF">1,333 μs</td><td align="right" bgcolor="#FFFFFF">1,419 μs</td><td align="right" bgcolor="#FFFFFF">1,325 μs</td><td align="right" bgcolor="#FFFFFF">1,310 μs</td><td align="right" bgcolor="#FFFFFF">1,330 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">650,500</td><td align="right" bgcolor="#A8D08D">541,000 (Δ = -109,500)</td><td align="right" bgcolor="#A8D08D">405,500 (Δ = -135,500)</td><td align="right" bgcolor="#FFFFFF">405,500</td><td align="right" bgcolor="#FFFFFF">405,500</td><td align="right" bgcolor="#FF4949">541,000 (Δ = +135,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,635</td><td align="right" bgcolor="#A8D08D">0,528 (Δ = -0,107)</td><td align="right" bgcolor="#A8D08D">0,396 (Δ = -0,132)</td><td align="right" bgcolor="#FFFFFF">0,396</td><td align="right" bgcolor="#FFFFFF">0,396</td><td align="right" bgcolor="#FF4949">0,528 (Δ = +0,132)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 168,137 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">884,291 ns</td><td align="right" bgcolor="#FFFFFF">720,485 ns</td><td align="right" bgcolor="#FFFFFF">725,144 ns</td><td align="right" bgcolor="#FFFFFF">717,511 ns</td><td align="right" bgcolor="#FFFFFF">724,119 ns</td><td align="right" bgcolor="#FFFFFF">716,153 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,884 μs</td><td align="right" bgcolor="#FFFFFF">0,720 μs</td><td align="right" bgcolor="#FFFFFF">0,725 μs</td><td align="right" bgcolor="#FFFFFF">0,718 μs</td><td align="right" bgcolor="#FFFFFF">0,724 μs</td><td align="right" bgcolor="#FFFFFF">0,716 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,7 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+33,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">557,000 (Δ = -164,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -139,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FF4949">557,000 (Δ = +139,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,544 (Δ = -0,160)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,136)</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FF4949">0,544 (Δ = +0,136)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 23,730 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">189,447 ns</td><td align="right" bgcolor="#FFFFFF">167,996 ns</td><td align="right" bgcolor="#FFFFFF">168,957 ns</td><td align="right" bgcolor="#FFFFFF">165,717 ns</td><td align="right" bgcolor="#FFFFFF">167,661 ns</td><td align="right" bgcolor="#FFFFFF">170,243 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,189 μs</td><td align="right" bgcolor="#FFFFFF">0,168 μs</td><td align="right" bgcolor="#FFFFFF">0,169 μs</td><td align="right" bgcolor="#FFFFFF">0,166 μs</td><td align="right" bgcolor="#FFFFFF">0,168 μs</td><td align="right" bgcolor="#FFFFFF">0,170 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,0 %</td><td align="right" bgcolor="#A8D08D">-16,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -8,000)</td><td align="right" bgcolor="#A8D08D">10,000 (Δ = -2,000)</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#FF4949">12,000 (Δ = +2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,010 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FF4949">0,012 (Δ = +0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 5.1.0

Δ: 58,147 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">768,731 ns</td><td align="right" bgcolor="#FFFFFF">740,417 ns</td><td align="right" bgcolor="#FFFFFF">776,682 ns</td><td align="right" bgcolor="#FFFFFF">718,534 ns</td><td align="right" bgcolor="#FFFFFF">727,303 ns</td><td align="right" bgcolor="#FFFFFF">749,092 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,769 μs</td><td align="right" bgcolor="#FFFFFF">0,740 μs</td><td align="right" bgcolor="#FFFFFF">0,777 μs</td><td align="right" bgcolor="#FFFFFF">0,719 μs</td><td align="right" bgcolor="#FFFFFF">0,727 μs</td><td align="right" bgcolor="#FFFFFF">0,749 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">182,500 (Δ = -59,500)</td><td align="right" bgcolor="#FFFFFF">182,500</td><td align="right" bgcolor="#FFFFFF">182,500</td><td align="right" bgcolor="#FF4949">242,000 (Δ = +59,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,178 (Δ = -0,058)</td><td align="right" bgcolor="#FFFFFF">0,178</td><td align="right" bgcolor="#FFFFFF">0,178</td><td align="right" bgcolor="#FF4949">0,236 (Δ = +0,058)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance"></a>GetPropertyEx_Instance

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 7,804 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">132,567 ns</td><td align="right" bgcolor="#FFFFFF">132,768 ns</td><td align="right" bgcolor="#FFFFFF">133,813 ns</td><td align="right" bgcolor="#FFFFFF">131,221 ns</td><td align="right" bgcolor="#FFFFFF">139,025 ns</td><td align="right" bgcolor="#FFFFFF">135,878 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,131 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,136 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 354,068 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2786,310 ns</td><td align="right" bgcolor="#A8D08D">2432,243 ns (Δ = -354,068 ns)</td><td align="right" bgcolor="#FFFFFF">2457,542 ns</td><td align="right" bgcolor="#FFFFFF">2441,300 ns</td><td align="right" bgcolor="#FFFFFF">2495,713 ns</td><td align="right" bgcolor="#FFFFFF">2474,852 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,786 μs</td><td align="right" bgcolor="#FFFFFF">2,432 μs</td><td align="right" bgcolor="#FFFFFF">2,458 μs</td><td align="right" bgcolor="#FFFFFF">2,441 μs</td><td align="right" bgcolor="#FFFFFF">2,496 μs</td><td align="right" bgcolor="#FFFFFF">2,475 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,7 %</td><td align="right" bgcolor="#A8D08D">-24,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+32,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -24,000)</td><td align="right" bgcolor="#A8D08D">151,500 (Δ = -49,500)</td><td align="right" bgcolor="#FFFFFF">151,500</td><td align="right" bgcolor="#FFFFFF">151,500</td><td align="right" bgcolor="#FF4949">201,000 (Δ = +49,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,023)</td><td align="right" bgcolor="#A8D08D">0,148 (Δ = -0,048)</td><td align="right" bgcolor="#FFFFFF">0,148</td><td align="right" bgcolor="#FFFFFF">0,148</td><td align="right" bgcolor="#FF4949">0,196 (Δ = +0,048)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 46,584 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">172,350 ns</td><td align="right" bgcolor="#FFFFFF">172,132 ns</td><td align="right" bgcolor="#FFFFFF">211,538 ns</td><td align="right" bgcolor="#FFFFFF">212,862 ns</td><td align="right" bgcolor="#FFFFFF">218,716 ns</td><td align="right" bgcolor="#FFFFFF">183,223 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,212 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,183 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">315,500</td><td align="right" bgcolor="#FFFFFF">315,500</td><td align="right" bgcolor="#A8D08D">309,500 (Δ = -6,000)</td><td align="right" bgcolor="#FFFFFF">309,500</td><td align="right" bgcolor="#FFFFFF">309,500</td><td align="right" bgcolor="#FF4949">324,000 (Δ = +14,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,308</td><td align="right" bgcolor="#FFFFFF">0,308</td><td align="right" bgcolor="#A8D08D">0,302 (Δ = -0,006)</td><td align="right" bgcolor="#FFFFFF">0,302</td><td align="right" bgcolor="#FFFFFF">0,302</td><td align="right" bgcolor="#FF4949">0,316 (Δ = +0,014)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetTypeInfo"></a>GetTypeInfo

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 1,640 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,783 ns</td><td align="right" bgcolor="#FFFFFF">11,782 ns</td><td align="right" bgcolor="#FFFFFF">12,963 ns</td><td align="right" bgcolor="#FFFFFF">13,073 ns</td><td align="right" bgcolor="#FFFFFF">13,422 ns</td><td align="right" bgcolor="#FFFFFF">11,947 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_HasBaseTypeEx"></a>HasBaseTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 6,142 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">33,424 ns</td><td align="right" bgcolor="#FFFFFF">32,071 ns</td><td align="right" bgcolor="#FFFFFF">36,897 ns</td><td align="right" bgcolor="#FFFFFF">38,213 ns</td><td align="right" bgcolor="#FFFFFF">36,112 ns</td><td align="right" bgcolor="#FFFFFF">32,855 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx"></a>ImplementsInterfaceEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 7,959 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">40,904 ns</td><td align="right" bgcolor="#FFFFFF">36,617 ns</td><td align="right" bgcolor="#FFFFFF">44,494 ns</td><td align="right" bgcolor="#FFFFFF">42,008 ns</td><td align="right" bgcolor="#FFFFFF">43,064 ns</td><td align="right" bgcolor="#FFFFFF">36,535 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx"></a>ImplementsInterfacesEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 6,032 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35,152 ns</td><td align="right" bgcolor="#FFFFFF">33,802 ns</td><td align="right" bgcolor="#FFFFFF">38,154 ns</td><td align="right" bgcolor="#FFFFFF">36,488 ns</td><td align="right" bgcolor="#FFFFFF">36,817 ns</td><td align="right" bgcolor="#FFFFFF">32,122 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAbstractEx"></a>IsAbstractEx

#### Performance

Fastest: **5.2.0**

Slowest: 5.4.0

Δ: 1,423 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,769 ns</td><td align="right" bgcolor="#FFFFFF">14,536 ns</td><td align="right" bgcolor="#FFFFFF">13,878 ns</td><td align="right" bgcolor="#FFFFFF">13,786 ns</td><td align="right" bgcolor="#FFFFFF">13,868 ns</td><td align="right" bgcolor="#FFFFFF">15,208 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsArrayEx"></a>IsArrayEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 0,931 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,680 ns</td><td align="right" bgcolor="#FFFFFF">19,878 ns</td><td align="right" bgcolor="#FFFFFF">20,611 ns</td><td align="right" bgcolor="#FFFFFF">19,780 ns</td><td align="right" bgcolor="#FFFFFF">19,820 ns</td><td align="right" bgcolor="#FFFFFF">19,823 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsAssignableFromEx"></a>IsAssignableFromEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 4,583 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,914 ns</td><td align="right" bgcolor="#FFFFFF">24,746 ns</td><td align="right" bgcolor="#FFFFFF">29,328 ns</td><td align="right" bgcolor="#FFFFFF">28,035 ns</td><td align="right" bgcolor="#FFFFFF">27,716 ns</td><td align="right" bgcolor="#FFFFFF">25,665 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 33,693 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">443,027 ns</td><td align="right" bgcolor="#FFFFFF">445,039 ns</td><td align="right" bgcolor="#FFFFFF">476,719 ns</td><td align="right" bgcolor="#FFFFFF">472,008 ns</td><td align="right" bgcolor="#FFFFFF">475,571 ns</td><td align="right" bgcolor="#FFFFFF">450,827 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,443 μs</td><td align="right" bgcolor="#FFFFFF">0,445 μs</td><td align="right" bgcolor="#FFFFFF">0,477 μs</td><td align="right" bgcolor="#FFFFFF">0,472 μs</td><td align="right" bgcolor="#FFFFFF">0,476 μs</td><td align="right" bgcolor="#FFFFFF">0,451 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsClassEx"></a>IsClassEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 40,552 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">151,604 ns</td><td align="right" bgcolor="#FFFFFF">174,047 ns</td><td align="right" bgcolor="#FFFFFF">192,156 ns</td><td align="right" bgcolor="#FFFFFF">189,440 ns</td><td align="right" bgcolor="#FFFFFF">189,107 ns</td><td align="right" bgcolor="#FFFFFF">172,345 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,152 μs</td><td align="right" bgcolor="#FFFFFF">0,174 μs</td><td align="right" bgcolor="#FFFFFF">0,192 μs</td><td align="right" bgcolor="#FFFFFF">0,189 μs</td><td align="right" bgcolor="#FFFFFF">0,189 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsCOMObjectEx"></a>IsCOMObjectEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.4.0

Δ: 3,614 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,652 ns</td><td align="right" bgcolor="#FFFFFF">25,584 ns</td><td align="right" bgcolor="#FFFFFF">25,688 ns</td><td align="right" bgcolor="#FFFFFF">25,598 ns</td><td align="right" bgcolor="#FFFFFF">29,107 ns</td><td align="right" bgcolor="#FFFFFF">29,198 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsEnumEx"></a>IsEnumEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 4,531 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">30,025 ns</td><td align="right" bgcolor="#FFFFFF">29,326 ns</td><td align="right" bgcolor="#FFFFFF">33,857 ns</td><td align="right" bgcolor="#FFFFFF">32,770 ns</td><td align="right" bgcolor="#FFFFFF">33,089 ns</td><td align="right" bgcolor="#FFFFFF">30,797 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1,455 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,942 ns</td><td align="right" bgcolor="#FFFFFF">8,720 ns</td><td align="right" bgcolor="#FFFFFF">9,821 ns</td><td align="right" bgcolor="#FFFFFF">10,175 ns</td><td align="right" bgcolor="#FFFFFF">9,621 ns</td><td align="right" bgcolor="#FFFFFF">9,163 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeEx"></a>IsGenericTypeEx

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 2,034 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,453 ns</td><td align="right" bgcolor="#FFFFFF">9,635 ns</td><td align="right" bgcolor="#FFFFFF">10,128 ns</td><td align="right" bgcolor="#FFFFFF">10,447 ns</td><td align="right" bgcolor="#FFFFFF">11,193 ns</td><td align="right" bgcolor="#FFFFFF">9,158 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx"></a>IsInstanceOfTypeEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 19310,297 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,9 %</td><td align="right" bgcolor="#A8D08D">-7,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+4,2 %</td><td align="right" bgcolor="#FF4949">+5,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">34786,468 ns</td><td align="right" bgcolor="#A8D08D">16731,748 ns (Δ = -18054,720 ns)</td><td align="right" bgcolor="#A8D08D">15537,468 ns (Δ = -1194,279 ns)</td><td align="right" bgcolor="#FFFFFF">15476,171 ns</td><td align="right" bgcolor="#FF4949">16121,871 ns (Δ = +645,700 ns)</td><td align="right" bgcolor="#FF4949">17049,045 ns (Δ = +927,174 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">34,786 μs</td><td align="right" bgcolor="#FFFFFF">16,732 μs</td><td align="right" bgcolor="#FFFFFF">15,537 μs</td><td align="right" bgcolor="#FFFFFF">15,476 μs</td><td align="right" bgcolor="#FFFFFF">16,122 μs</td><td align="right" bgcolor="#FFFFFF">17,049 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,035 ms</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,500 (Δ = +0,500)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,500)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,9 %</td><td align="right" bgcolor="#A8D08D">-23,2 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td><td align="right" bgcolor="#FF4949">+5,8 %</td><td align="right" bgcolor="#FF4949">+30,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">7704,000</td><td align="right" bgcolor="#A8D08D">5785,500 (Δ = -1918,500)</td><td align="right" bgcolor="#A8D08D">4440,500 (Δ = -1345,000)</td><td align="right" bgcolor="#A8D08D">4438,500 (Δ = -2,000)</td><td align="right" bgcolor="#FF4949">4696,500 (Δ = +258,000)</td><td align="right" bgcolor="#FF4949">6121,000 (Δ = +1424,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">7,523</td><td align="right" bgcolor="#A8D08D">5,650 (Δ = -1,874)</td><td align="right" bgcolor="#A8D08D">4,336 (Δ = -1,313)</td><td align="right" bgcolor="#A8D08D">4,334 (Δ = -0,002)</td><td align="right" bgcolor="#FF4949">4,586 (Δ = +0,252)</td><td align="right" bgcolor="#FF4949">5,978 (Δ = +1,391)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,006 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,004 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,004 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,004 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,001)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 1,233 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,111 ns</td><td align="right" bgcolor="#FFFFFF">10,844 ns</td><td align="right" bgcolor="#FFFFFF">11,966 ns</td><td align="right" bgcolor="#FFFFFF">11,537 ns</td><td align="right" bgcolor="#FFFFFF">12,077 ns</td><td align="right" bgcolor="#FFFFFF">11,370 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsNestedPublicEx"></a>IsNestedPublicEx

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 1,138 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,918 ns</td><td align="right" bgcolor="#FFFFFF">14,522 ns</td><td align="right" bgcolor="#FFFFFF">14,043 ns</td><td align="right" bgcolor="#FFFFFF">14,378 ns</td><td align="right" bgcolor="#FFFFFF">13,779 ns</td><td align="right" bgcolor="#FFFFFF">14,863 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPrimitiveEx"></a>IsPrimitiveEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 0,706 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,025 ns</td><td align="right" bgcolor="#FFFFFF">13,799 ns</td><td align="right" bgcolor="#FFFFFF">14,505 ns</td><td align="right" bgcolor="#FFFFFF">13,958 ns</td><td align="right" bgcolor="#FFFFFF">14,410 ns</td><td align="right" bgcolor="#FFFFFF">13,922 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsPublicEx"></a>IsPublicEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 1,027 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,796 ns</td><td align="right" bgcolor="#FFFFFF">14,679 ns</td><td align="right" bgcolor="#FFFFFF">14,224 ns</td><td align="right" bgcolor="#FFFFFF">13,769 ns</td><td align="right" bgcolor="#FFFFFF">14,684 ns</td><td align="right" bgcolor="#FFFFFF">14,685 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsSerializableEx"></a>IsSerializableEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 1,483 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16,376 ns</td><td align="right" bgcolor="#FFFFFF">15,525 ns</td><td align="right" bgcolor="#FFFFFF">15,344 ns</td><td align="right" bgcolor="#FFFFFF">14,893 ns</td><td align="right" bgcolor="#FFFFFF">14,936 ns</td><td align="right" bgcolor="#FFFFFF">15,798 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="Type_ReflectionExtensions_Benchmark_IsValueTypeEx"></a>IsValueTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 5,279 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35,675 ns</td><td align="right" bgcolor="#FFFFFF">35,408 ns</td><td align="right" bgcolor="#FFFFFF">40,688 ns</td><td align="right" bgcolor="#FFFFFF">39,876 ns</td><td align="right" bgcolor="#FFFFFF">40,498 ns</td><td align="right" bgcolor="#FFFFFF">35,713 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="TypeExtensions_Benchmark"></a>TypeExtensions_Benchmark

### <a name="TypeExtensions_Benchmark_GetCollectionElementType"></a>GetCollectionElementType

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 715,656 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-67,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">867,911 ns</td><td align="right" bgcolor="#FFFFFF">868,559 ns</td><td align="right" bgcolor="#FFFFFF">970,591 ns</td><td align="right" bgcolor="#FFFFFF">992,508 ns</td><td align="right" bgcolor="#A8D08D">320,087 ns (Δ = -672,421 ns)</td><td align="right" bgcolor="#FFFFFF">276,852 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,868 μs</td><td align="right" bgcolor="#FFFFFF">0,869 μs</td><td align="right" bgcolor="#FFFFFF">0,971 μs</td><td align="right" bgcolor="#FFFFFF">0,993 μs</td><td align="right" bgcolor="#FFFFFF">0,320 μs</td><td align="right" bgcolor="#FFFFFF">0,277 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-82,1 %</td><td align="right" bgcolor="#FF4949">+34,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#A8D08D">137,000 (Δ = -43,000)</td><td align="right" bgcolor="#FFFFFF">137,000</td><td align="right" bgcolor="#A8D08D">24,500 (Δ = -112,500)</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +8,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#A8D08D">0,134 (Δ = -0,042)</td><td align="right" bgcolor="#FFFFFF">0,134</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,110)</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsBasicType"></a>IsBasicType

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 5,496 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,279 ns</td><td align="right" bgcolor="#FFFFFF">17,852 ns</td><td align="right" bgcolor="#FFFFFF">23,348 ns</td><td align="right" bgcolor="#FFFFFF">18,671 ns</td><td align="right" bgcolor="#FFFFFF">19,025 ns</td><td align="right" bgcolor="#FFFFFF">18,265 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsClassType"></a>IsClassType

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 35,946 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">218,068 ns</td><td align="right" bgcolor="#FFFFFF">220,124 ns</td><td align="right" bgcolor="#FFFFFF">252,193 ns</td><td align="right" bgcolor="#FFFFFF">254,013 ns</td><td align="right" bgcolor="#FFFFFF">248,649 ns</td><td align="right" bgcolor="#FFFFFF">218,728 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,220 μs</td><td align="right" bgcolor="#FFFFFF">0,252 μs</td><td align="right" bgcolor="#FFFFFF">0,254 μs</td><td align="right" bgcolor="#FFFFFF">0,249 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsCollection"></a>IsCollection

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 5,220 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">34,626 ns</td><td align="right" bgcolor="#FFFFFF">35,401 ns</td><td align="right" bgcolor="#FFFFFF">39,095 ns</td><td align="right" bgcolor="#FFFFFF">37,041 ns</td><td align="right" bgcolor="#FFFFFF">38,233 ns</td><td align="right" bgcolor="#FFFFFF">33,875 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsDictionary"></a>IsDictionary

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 31,203 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">105,796 ns</td><td align="right" bgcolor="#FFFFFF">104,493 ns</td><td align="right" bgcolor="#FFFFFF">113,670 ns</td><td align="right" bgcolor="#FFFFFF">128,141 ns</td><td align="right" bgcolor="#FFFFFF">135,128 ns</td><td align="right" bgcolor="#FFFFFF">103,925 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,128 μs</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsModelBase"></a>IsModelBase

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 6,193 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,266 ns</td><td align="right" bgcolor="#FFFFFF">29,668 ns</td><td align="right" bgcolor="#FFFFFF">34,554 ns</td><td align="right" bgcolor="#FFFFFF">33,753 ns</td><td align="right" bgcolor="#FFFFFF">32,823 ns</td><td align="right" bgcolor="#FFFFFF">28,361 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="TypeExtensions_Benchmark_IsNullableType"></a>IsNullableType

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 126,318 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">291,983 ns</td><td align="right" bgcolor="#FFFFFF">292,199 ns</td><td align="right" bgcolor="#FFFFFF">346,602 ns</td><td align="right" bgcolor="#FFFFFF">414,892 ns</td><td align="right" bgcolor="#FFFFFF">345,773 ns</td><td align="right" bgcolor="#FFFFFF">288,573 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td><td align="right" bgcolor="#FFFFFF">0,292 μs</td><td align="right" bgcolor="#FFFFFF">0,347 μs</td><td align="right" bgcolor="#FFFFFF">0,415 μs</td><td align="right" bgcolor="#FFFFFF">0,346 μs</td><td align="right" bgcolor="#FFFFFF">0,289 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">24,500 (Δ = -8,500)</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +8,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,008)</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="TypeFactory_Benchmark"></a>TypeFactory_Benchmark

### <a name="TypeFactory_Benchmark_CreateInstance"></a>CreateInstance

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 234,972 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2251,853 ns</td><td align="right" bgcolor="#FFFFFF">2486,826 ns</td><td align="right" bgcolor="#FFFFFF">2346,558 ns</td><td align="right" bgcolor="#FFFFFF">2340,525 ns</td><td align="right" bgcolor="#FFFFFF">2382,225 ns</td><td align="right" bgcolor="#FFFFFF">2444,313 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,252 μs</td><td align="right" bgcolor="#FFFFFF">2,487 μs</td><td align="right" bgcolor="#FFFFFF">2,347 μs</td><td align="right" bgcolor="#FFFFFF">2,341 μs</td><td align="right" bgcolor="#FFFFFF">2,382 μs</td><td align="right" bgcolor="#FFFFFF">2,444 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,0 %</td><td align="right" bgcolor="#A8D08D">-19,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">868,000</td><td align="right" bgcolor="#FF4949">1024,000 (Δ = +156,000)</td><td align="right" bgcolor="#A8D08D">827,500 (Δ = -196,500)</td><td align="right" bgcolor="#FFFFFF">827,500</td><td align="right" bgcolor="#FFFFFF">827,500</td><td align="right" bgcolor="#FF4949">1012,000 (Δ = +184,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,848</td><td align="right" bgcolor="#FF4949">1,000 (Δ = +0,152)</td><td align="right" bgcolor="#A8D08D">0,808 (Δ = -0,192)</td><td align="right" bgcolor="#FFFFFF">0,808</td><td align="right" bgcolor="#FFFFFF">0,808</td><td align="right" bgcolor="#FF4949">0,988 (Δ = +0,180)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 253,806 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2268,536 ns</td><td align="right" bgcolor="#FF4949">2522,342 ns (Δ = +253,806 ns)</td><td align="right" bgcolor="#FFFFFF">2292,373 ns</td><td align="right" bgcolor="#FFFFFF">2386,113 ns</td><td align="right" bgcolor="#FFFFFF">2355,677 ns</td><td align="right" bgcolor="#FFFFFF">2505,522 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,269 μs</td><td align="right" bgcolor="#FFFFFF">2,522 μs</td><td align="right" bgcolor="#FFFFFF">2,292 μs</td><td align="right" bgcolor="#FFFFFF">2,386 μs</td><td align="right" bgcolor="#FFFFFF">2,356 μs</td><td align="right" bgcolor="#FFFFFF">2,506 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,1 %</td><td align="right" bgcolor="#A8D08D">-19,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+22,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">864,000</td><td align="right" bgcolor="#FF4949">1020,000 (Δ = +156,000)</td><td align="right" bgcolor="#A8D08D">825,500 (Δ = -194,500)</td><td align="right" bgcolor="#FFFFFF">825,500</td><td align="right" bgcolor="#FFFFFF">825,500</td><td align="right" bgcolor="#FF4949">1012,000 (Δ = +186,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,844</td><td align="right" bgcolor="#FF4949">0,996 (Δ = +0,152)</td><td align="right" bgcolor="#A8D08D">0,806 (Δ = -0,190)</td><td align="right" bgcolor="#FFFFFF">0,806</td><td align="right" bgcolor="#FFFFFF">0,806</td><td align="right" bgcolor="#FF4949">0,988 (Δ = +0,182)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 182,969 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2758,311 ns</td><td align="right" bgcolor="#FFFFFF">2941,280 ns</td><td align="right" bgcolor="#FFFFFF">2828,583 ns</td><td align="right" bgcolor="#FFFFFF">2834,069 ns</td><td align="right" bgcolor="#FFFFFF">2815,273 ns</td><td align="right" bgcolor="#FFFFFF">2815,372 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,758 μs</td><td align="right" bgcolor="#FFFFFF">2,941 μs</td><td align="right" bgcolor="#FFFFFF">2,829 μs</td><td align="right" bgcolor="#FFFFFF">2,834 μs</td><td align="right" bgcolor="#FFFFFF">2,815 μs</td><td align="right" bgcolor="#FFFFFF">2,815 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,8 %</td><td align="right" bgcolor="#A8D08D">-14,7 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1286,000</td><td align="right" bgcolor="#FF4949">1437,500 (Δ = +151,500)</td><td align="right" bgcolor="#A8D08D">1226,500 (Δ = -211,000)</td><td align="right" bgcolor="#FFFFFF">1226,500</td><td align="right" bgcolor="#FFFFFF">1226,500</td><td align="right" bgcolor="#FF4949">1458,000 (Δ = +231,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,256</td><td align="right" bgcolor="#FF4949">1,404 (Δ = +0,148)</td><td align="right" bgcolor="#A8D08D">1,198 (Δ = -0,206)</td><td align="right" bgcolor="#FFFFFF">1,198</td><td align="right" bgcolor="#FFFFFF">1,198</td><td align="right" bgcolor="#FF4949">1,424 (Δ = +0,226)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 304,142 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3090,205 ns</td><td align="right" bgcolor="#FFFFFF">3323,443 ns</td><td align="right" bgcolor="#FFFFFF">3299,442 ns</td><td align="right" bgcolor="#FFFFFF">3198,308 ns</td><td align="right" bgcolor="#FFFFFF">3363,524 ns</td><td align="right" bgcolor="#FFFFFF">3394,347 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,090 μs</td><td align="right" bgcolor="#FFFFFF">3,323 μs</td><td align="right" bgcolor="#FFFFFF">3,299 μs</td><td align="right" bgcolor="#FFFFFF">3,198 μs</td><td align="right" bgcolor="#FFFFFF">3,364 μs</td><td align="right" bgcolor="#FFFFFF">3,394 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">5.4.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,2 %</td><td align="right" bgcolor="#A8D08D">-15,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,1 %</td><td align="right" bgcolor="#FF4949">+20,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1494,000</td><td align="right" bgcolor="#FF4949">1647,000 (Δ = +153,000)</td><td align="right" bgcolor="#A8D08D">1385,500 (Δ = -261,500)</td><td align="right" bgcolor="#FFFFFF">1385,500</td><td align="right" bgcolor="#FF4949">1386,500 (Δ = +1,000)</td><td align="right" bgcolor="#FF4949">1667,000 (Δ = +280,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,459</td><td align="right" bgcolor="#FF4949">1,608 (Δ = +0,149)</td><td align="right" bgcolor="#A8D08D">1,353 (Δ = -0,255)</td><td align="right" bgcolor="#FFFFFF">1,353</td><td align="right" bgcolor="#FF4949">1,354 (Δ = +0,001)</td><td align="right" bgcolor="#FF4949">1,628 (Δ = +0,274)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


## <a name="UniqueIdentifierHelper_Benchmark"></a>UniqueIdentifierHelper_Benchmark

### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier"></a>GetUniqueIdentifier

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 10,464 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">109,636 ns</td><td align="right" bgcolor="#FFFFFF">104,306 ns</td><td align="right" bgcolor="#FFFFFF">112,763 ns</td><td align="right" bgcolor="#FFFFFF">113,198 ns</td><td align="right" bgcolor="#FFFFFF">114,770 ns</td><td align="right" bgcolor="#FFFFFF">106,275 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td><td align="right" bgcolor="#FFFFFF">0,113 μs</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier_Generic"></a>GetUniqueIdentifier_Generic

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 10,013 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">107,761 ns</td><td align="right" bgcolor="#FFFFFF">103,643 ns</td><td align="right" bgcolor="#FFFFFF">113,655 ns</td><td align="right" bgcolor="#FFFFFF">111,886 ns</td><td align="right" bgcolor="#FFFFFF">112,066 ns</td><td align="right" bgcolor="#FFFFFF">106,165 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,112 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


## <a name="ValidatableModelBase_Constructor_Benchmark"></a>ValidatableModelBase_Constructor_Benchmark

### <a name="ValidatableModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 288,484 ns


<table><tr><th> </th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2870,916 ns</td><td align="right" bgcolor="#FFFFFF">2950,910 ns</td><td align="right" bgcolor="#FFFFFF">3037,814 ns</td><td align="right" bgcolor="#FFFFFF">2943,669 ns</td><td align="right" bgcolor="#FFFFFF">2749,330 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,871 μs</td><td align="right" bgcolor="#FFFFFF">2,951 μs</td><td align="right" bgcolor="#FFFFFF">3,038 μs</td><td align="right" bgcolor="#FFFFFF">2,944 μs</td><td align="right" bgcolor="#FFFFFF">2,749 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">971,000</td><td align="right" bgcolor="#A8D08D">762,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">971,000 (Δ = +209,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,948</td><td align="right" bgcolor="#A8D08D">0,744 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,948 (Δ = +0,204)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="ValidationContext_Benchmark"></a>ValidationContext_Benchmark

### <a name="ValidationContext_Benchmark_GetBusinessRuleErrorCount"></a>GetBusinessRuleErrorCount

#### Performance

Fastest: **5.4.0**

Slowest: 4.5.4

Δ: 34,696 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">231,828 ns</td><td align="right" bgcolor="#FFFFFF">222,696 ns</td><td align="right" bgcolor="#FFFFFF">226,921 ns</td><td align="right" bgcolor="#FFFFFF">217,728 ns</td><td align="right" bgcolor="#FFFFFF">210,998 ns</td><td align="right" bgcolor="#FFFFFF">197,132 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,232 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FF4949">172,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FF4949">0,168 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleErrors"></a>GetBusinessRuleErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 30,857 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">195,838 ns</td><td align="right" bgcolor="#FFFFFF">193,755 ns</td><td align="right" bgcolor="#FFFFFF">224,612 ns</td><td align="right" bgcolor="#FFFFFF">206,497 ns</td><td align="right" bgcolor="#FFFFFF">211,337 ns</td><td align="right" bgcolor="#FFFFFF">194,822 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,196 μs</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,225 μs</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FF4949">172,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FF4949">0,168 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleValidations"></a>GetBusinessRuleValidations

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 29,038 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">217,998 ns</td><td align="right" bgcolor="#FFFFFF">222,095 ns</td><td align="right" bgcolor="#FFFFFF">228,209 ns</td><td align="right" bgcolor="#FFFFFF">225,682 ns</td><td align="right" bgcolor="#FFFFFF">247,036 ns</td><td align="right" bgcolor="#FFFFFF">219,113 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,218 μs</td><td align="right" bgcolor="#FFFFFF">0,222 μs</td><td align="right" bgcolor="#FFFFFF">0,228 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+26,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#A8D08D">139,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FF4949">176,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#A8D08D">0,136 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FF4949">0,172 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarningCount"></a>GetBusinessRuleWarningCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 33,837 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">193,552 ns</td><td align="right" bgcolor="#FFFFFF">206,864 ns</td><td align="right" bgcolor="#FFFFFF">227,389 ns</td><td align="right" bgcolor="#FFFFFF">210,561 ns</td><td align="right" bgcolor="#FFFFFF">210,520 ns</td><td align="right" bgcolor="#FFFFFF">202,597 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,207 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,203 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FF4949">172,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FF4949">0,168 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarnings"></a>GetBusinessRuleWarnings

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 48,357 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">201,974 ns</td><td align="right" bgcolor="#FFFFFF">213,985 ns</td><td align="right" bgcolor="#FFFFFF">222,623 ns</td><td align="right" bgcolor="#FFFFFF">245,352 ns</td><td align="right" bgcolor="#FFFFFF">213,138 ns</td><td align="right" bgcolor="#FFFFFF">196,995 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,202 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,245 μs</td><td align="right" bgcolor="#FFFFFF">0,213 μs</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FF4949">172,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FF4949">0,168 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrorCount"></a>GetErrorCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 146,955 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">990,264 ns</td><td align="right" bgcolor="#FFFFFF">1061,951 ns</td><td align="right" bgcolor="#FFFFFF">1101,875 ns</td><td align="right" bgcolor="#FFFFFF">1048,579 ns</td><td align="right" bgcolor="#FFFFFF">1037,243 ns</td><td align="right" bgcolor="#FFFFFF">954,920 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,990 μs</td><td align="right" bgcolor="#FFFFFF">1,062 μs</td><td align="right" bgcolor="#FFFFFF">1,102 μs</td><td align="right" bgcolor="#FFFFFF">1,049 μs</td><td align="right" bgcolor="#FFFFFF">1,037 μs</td><td align="right" bgcolor="#FFFFFF">0,955 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">405,500 (Δ = -110,500)</td><td align="right" bgcolor="#FFFFFF">405,500</td><td align="right" bgcolor="#FFFFFF">405,500</td><td align="right" bgcolor="#FF4949">516,000 (Δ = +110,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,396 (Δ = -0,108)</td><td align="right" bgcolor="#FFFFFF">0,396</td><td align="right" bgcolor="#FFFFFF">0,396</td><td align="right" bgcolor="#FF4949">0,504 (Δ = +0,108)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrors"></a>GetErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 102,863 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">993,242 ns</td><td align="right" bgcolor="#FFFFFF">968,305 ns</td><td align="right" bgcolor="#FFFFFF">1071,168 ns</td><td align="right" bgcolor="#FFFFFF">1044,103 ns</td><td align="right" bgcolor="#FFFFFF">1038,283 ns</td><td align="right" bgcolor="#FFFFFF">974,127 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,993 μs</td><td align="right" bgcolor="#FFFFFF">0,968 μs</td><td align="right" bgcolor="#FFFFFF">1,071 μs</td><td align="right" bgcolor="#FFFFFF">1,044 μs</td><td align="right" bgcolor="#FFFFFF">1,038 μs</td><td align="right" bgcolor="#FFFFFF">0,974 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">405,500 (Δ = -110,500)</td><td align="right" bgcolor="#FFFFFF">405,500</td><td align="right" bgcolor="#FFFFFF">405,500</td><td align="right" bgcolor="#FF4949">516,000 (Δ = +110,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,396 (Δ = -0,108)</td><td align="right" bgcolor="#FFFFFF">0,396</td><td align="right" bgcolor="#FFFFFF">0,396</td><td align="right" bgcolor="#FF4949">0,504 (Δ = +0,108)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrorCount"></a>GetFieldErrorCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 30,566 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">236,076 ns</td><td align="right" bgcolor="#FFFFFF">236,273 ns</td><td align="right" bgcolor="#FFFFFF">253,899 ns</td><td align="right" bgcolor="#FFFFFF">260,952 ns</td><td align="right" bgcolor="#FFFFFF">266,486 ns</td><td align="right" bgcolor="#FFFFFF">235,920 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,254 μs</td><td align="right" bgcolor="#FFFFFF">0,261 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FF4949">172,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FF4949">0,168 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrors"></a>GetFieldErrors

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 39,808 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">237,504 ns</td><td align="right" bgcolor="#FFFFFF">258,158 ns</td><td align="right" bgcolor="#FFFFFF">252,259 ns</td><td align="right" bgcolor="#FFFFFF">273,869 ns</td><td align="right" bgcolor="#FFFFFF">255,341 ns</td><td align="right" bgcolor="#FFFFFF">234,062 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,238 μs</td><td align="right" bgcolor="#FFFFFF">0,258 μs</td><td align="right" bgcolor="#FFFFFF">0,252 μs</td><td align="right" bgcolor="#FFFFFF">0,274 μs</td><td align="right" bgcolor="#FFFFFF">0,255 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FF4949">172,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FF4949">0,168 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldValidations"></a>GetFieldValidations

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 33,796 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">251,663 ns</td><td align="right" bgcolor="#FFFFFF">266,358 ns</td><td align="right" bgcolor="#FFFFFF">285,459 ns</td><td align="right" bgcolor="#FFFFFF">273,153 ns</td><td align="right" bgcolor="#FFFFFF">273,383 ns</td><td align="right" bgcolor="#FFFFFF">255,315 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,252 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td><td align="right" bgcolor="#FFFFFF">0,285 μs</td><td align="right" bgcolor="#FFFFFF">0,273 μs</td><td align="right" bgcolor="#FFFFFF">0,273 μs</td><td align="right" bgcolor="#FFFFFF">0,255 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+26,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#A8D08D">139,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FF4949">176,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#A8D08D">0,136 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FF4949">0,172 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarningCount"></a>GetFieldWarningCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 43,047 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">207,852 ns</td><td align="right" bgcolor="#FFFFFF">215,781 ns</td><td align="right" bgcolor="#FFFFFF">250,899 ns</td><td align="right" bgcolor="#FFFFFF">229,469 ns</td><td align="right" bgcolor="#FFFFFF">223,634 ns</td><td align="right" bgcolor="#FFFFFF">233,218 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,216 μs</td><td align="right" bgcolor="#FFFFFF">0,251 μs</td><td align="right" bgcolor="#FFFFFF">0,229 μs</td><td align="right" bgcolor="#FFFFFF">0,224 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FF4949">172,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FF4949">0,168 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarnings"></a>GetFieldWarnings

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 15,214 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">215,537 ns</td><td align="right" bgcolor="#FFFFFF">227,125 ns</td><td align="right" bgcolor="#FFFFFF">225,942 ns</td><td align="right" bgcolor="#FFFFFF">229,279 ns</td><td align="right" bgcolor="#FFFFFF">227,446 ns</td><td align="right" bgcolor="#FFFFFF">214,065 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,216 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td><td align="right" bgcolor="#FFFFFF">0,226 μs</td><td align="right" bgcolor="#FFFFFF">0,229 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td><td align="right" bgcolor="#FFFFFF">0,214 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FF4949">172,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FF4949">0,168 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetValidations"></a>GetValidations

#### Performance

Fastest: **5.0.0**

Slowest: 5.1.0

Δ: 119,334 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">499,243 ns</td><td align="right" bgcolor="#FFFFFF">498,569 ns</td><td align="right" bgcolor="#FFFFFF">617,903 ns</td><td align="right" bgcolor="#FFFFFF">566,708 ns</td><td align="right" bgcolor="#FFFFFF">562,205 ns</td><td align="right" bgcolor="#FFFFFF">511,407 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,499 μs</td><td align="right" bgcolor="#FFFFFF">0,499 μs</td><td align="right" bgcolor="#FFFFFF">0,618 μs</td><td align="right" bgcolor="#FFFFFF">0,567 μs</td><td align="right" bgcolor="#FFFFFF">0,562 μs</td><td align="right" bgcolor="#FFFFFF">0,511 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+28,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#A8D08D">268,500 (Δ = -75,500)</td><td align="right" bgcolor="#FFFFFF">268,500</td><td align="right" bgcolor="#FFFFFF">268,500</td><td align="right" bgcolor="#FF4949">344,000 (Δ = +75,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#A8D08D">0,262 (Δ = -0,074)</td><td align="right" bgcolor="#FFFFFF">0,262</td><td align="right" bgcolor="#FFFFFF">0,262</td><td align="right" bgcolor="#FF4949">0,336 (Δ = +0,074)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarningCount"></a>GetWarningCount

#### Performance

Fastest: **5.4.0**

Slowest: 5.2.0

Δ: 49,235 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">952,178 ns</td><td align="right" bgcolor="#FFFFFF">949,907 ns</td><td align="right" bgcolor="#FFFFFF">976,587 ns</td><td align="right" bgcolor="#FFFFFF">979,355 ns</td><td align="right" bgcolor="#FFFFFF">971,832 ns</td><td align="right" bgcolor="#FFFFFF">930,120 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,952 μs</td><td align="right" bgcolor="#FFFFFF">0,950 μs</td><td align="right" bgcolor="#FFFFFF">0,977 μs</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">0,972 μs</td><td align="right" bgcolor="#FFFFFF">0,930 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">405,500 (Δ = -110,500)</td><td align="right" bgcolor="#FFFFFF">405,500</td><td align="right" bgcolor="#FFFFFF">405,500</td><td align="right" bgcolor="#FF4949">516,000 (Δ = +110,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,396 (Δ = -0,108)</td><td align="right" bgcolor="#FFFFFF">0,396</td><td align="right" bgcolor="#FFFFFF">0,396</td><td align="right" bgcolor="#FF4949">0,504 (Δ = +0,108)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarnings"></a>GetWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 67,446 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">911,380 ns</td><td align="right" bgcolor="#FFFFFF">927,745 ns</td><td align="right" bgcolor="#FFFFFF">942,043 ns</td><td align="right" bgcolor="#FFFFFF">978,826 ns</td><td align="right" bgcolor="#FFFFFF">978,705 ns</td><td align="right" bgcolor="#FFFFFF">927,198 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,911 μs</td><td align="right" bgcolor="#FFFFFF">0,928 μs</td><td align="right" bgcolor="#FFFFFF">0,942 μs</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">0,927 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">405,500 (Δ = -110,500)</td><td align="right" bgcolor="#FFFFFF">405,500</td><td align="right" bgcolor="#FFFFFF">405,500</td><td align="right" bgcolor="#FF4949">516,000 (Δ = +110,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,396 (Δ = -0,108)</td><td align="right" bgcolor="#FFFFFF">0,396</td><td align="right" bgcolor="#FFFFFF">0,396</td><td align="right" bgcolor="#FF4949">0,504 (Δ = +0,108)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 35,213 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">237,147 ns</td><td align="right" bgcolor="#FFFFFF">249,626 ns</td><td align="right" bgcolor="#FFFFFF">272,360 ns</td><td align="right" bgcolor="#FFFFFF">261,043 ns</td><td align="right" bgcolor="#FFFFFF">256,545 ns</td><td align="right" bgcolor="#FFFFFF">239,528 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td><td align="right" bgcolor="#FFFFFF">0,250 μs</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td><td align="right" bgcolor="#FFFFFF">0,261 μs</td><td align="right" bgcolor="#FFFFFF">0,257 μs</td><td align="right" bgcolor="#FFFFFF">0,240 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FF4949">172,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FF4949">0,168 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.1.0

Δ: 27,502 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">209,608 ns</td><td align="right" bgcolor="#FFFFFF">222,200 ns</td><td align="right" bgcolor="#FFFFFF">237,110 ns</td><td align="right" bgcolor="#FFFFFF">227,386 ns</td><td align="right" bgcolor="#FFFFFF">227,613 ns</td><td align="right" bgcolor="#FFFFFF">211,298 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,210 μs</td><td align="right" bgcolor="#FFFFFF">0,222 μs</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td><td align="right" bgcolor="#FFFFFF">0,227 μs</td><td align="right" bgcolor="#FFFFFF">0,228 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+27,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#FF4949">172,000 (Δ = +37,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#FF4949">0,168 (Δ = +0,036)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationContext_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.4.0**

Slowest: 5.3.0

Δ: 70,875 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">337,088 ns</td><td align="right" bgcolor="#FFFFFF">349,941 ns</td><td align="right" bgcolor="#FFFFFF">402,452 ns</td><td align="right" bgcolor="#FFFFFF">401,953 ns</td><td align="right" bgcolor="#FFFFFF">403,772 ns</td><td align="right" bgcolor="#FFFFFF">332,897 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,337 μs</td><td align="right" bgcolor="#FFFFFF">0,350 μs</td><td align="right" bgcolor="#FFFFFF">0,402 μs</td><td align="right" bgcolor="#FFFFFF">0,402 μs</td><td align="right" bgcolor="#FFFFFF">0,404 μs</td><td align="right" bgcolor="#FFFFFF">0,333 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+29,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#A8D08D">256,000 (Δ = -76,000)</td><td align="right" bgcolor="#FFFFFF">256,000</td><td align="right" bgcolor="#FFFFFF">256,000</td><td align="right" bgcolor="#FF4949">332,000 (Δ = +76,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#A8D08D">0,250 (Δ = -0,074)</td><td align="right" bgcolor="#FFFFFF">0,250</td><td align="right" bgcolor="#FFFFFF">0,250</td><td align="right" bgcolor="#FF4949">0,324 (Δ = +0,074)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


## <a name="ValidationSummary_Benchmark"></a>ValidationSummary_Benchmark

### <a name="ValidationSummary_Benchmark_BusinessRuleErrors"></a>BusinessRuleErrors

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 1,198 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,920 ns</td><td align="right" bgcolor="#FFFFFF">7,214 ns</td><td align="right" bgcolor="#FFFFFF">7,243 ns</td><td align="right" bgcolor="#FFFFFF">6,874 ns</td><td align="right" bgcolor="#FFFFFF">8,073 ns</td><td align="right" bgcolor="#FFFFFF">7,975 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">24,500 (Δ = -8,500)</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +8,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,008)</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationSummary_Benchmark_BusinessRuleWarnings"></a>BusinessRuleWarnings

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 1,599 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,880 ns</td><td align="right" bgcolor="#FFFFFF">7,204 ns</td><td align="right" bgcolor="#FFFFFF">7,086 ns</td><td align="right" bgcolor="#FFFFFF">6,795 ns</td><td align="right" bgcolor="#FFFFFF">8,394 ns</td><td align="right" bgcolor="#FFFFFF">7,578 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">24,500 (Δ = -8,500)</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +8,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,008)</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldErrors"></a>FieldErrors

#### Performance

Fastest: **5.2.0**

Slowest: 5.4.0

Δ: 1,207 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,876 ns</td><td align="right" bgcolor="#FFFFFF">7,202 ns</td><td align="right" bgcolor="#FFFFFF">7,133 ns</td><td align="right" bgcolor="#FFFFFF">6,800 ns</td><td align="right" bgcolor="#FFFFFF">7,589 ns</td><td align="right" bgcolor="#FFFFFF">8,007 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">24,500 (Δ = -8,500)</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +8,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,008)</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldWarnings"></a>FieldWarnings

#### Performance

Fastest: **5.2.0**

Slowest: 5.4.0

Δ: 0,638 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,226 ns</td><td align="right" bgcolor="#FFFFFF">7,305 ns</td><td align="right" bgcolor="#FFFFFF">7,140 ns</td><td align="right" bgcolor="#FFFFFF">7,040 ns</td><td align="right" bgcolor="#FFFFFF">7,173 ns</td><td align="right" bgcolor="#FFFFFF">7,678 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+34,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">24,500 (Δ = -8,500)</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FFFFFF">24,500</td><td align="right" bgcolor="#FF4949">33,000 (Δ = +8,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,008)</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FF4949">0,032 (Δ = +0,008)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasBusinessRuleErrors"></a>HasBusinessRuleErrors

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 0,037 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,053 ns</td><td align="right" bgcolor="#FFFFFF">0,036 ns</td><td align="right" bgcolor="#FFFFFF">0,038 ns</td><td align="right" bgcolor="#FFFFFF">0,015 ns</td><td align="right" bgcolor="#FFFFFF">0,021 ns</td><td align="right" bgcolor="#FFFFFF">0,047 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasBusinessRuleWarnings"></a>HasBusinessRuleWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 0,054 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ns</td><td align="right" bgcolor="#FFFFFF">0,033 ns</td><td align="right" bgcolor="#FFFFFF">0,032 ns</td><td align="right" bgcolor="#FFFFFF">0,033 ns</td><td align="right" bgcolor="#FFFFFF">0,061 ns</td><td align="right" bgcolor="#FFFFFF">0,021 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.1.0**

Slowest: 5.2.0

Δ: 0,073 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,611 ns</td><td align="right" bgcolor="#FFFFFF">0,637 ns</td><td align="right" bgcolor="#FFFFFF">0,581 ns</td><td align="right" bgcolor="#FFFFFF">0,654 ns</td><td align="right" bgcolor="#FFFFFF">0,650 ns</td><td align="right" bgcolor="#FFFFFF">0,612 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldErrors"></a>HasFieldErrors

#### Performance

Fastest: **5.2.0**

Slowest: 5.4.0

Δ: 0,075 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,031 ns</td><td align="right" bgcolor="#FFFFFF">0,042 ns</td><td align="right" bgcolor="#FFFFFF">0,031 ns</td><td align="right" bgcolor="#FFFFFF">0,027 ns</td><td align="right" bgcolor="#FFFFFF">0,047 ns</td><td align="right" bgcolor="#FFFFFF">0,102 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasFieldWarnings"></a>HasFieldWarnings

#### Performance

Fastest: **5.1.0**

Slowest: 5.3.0

Δ: 0,046 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,039 ns</td><td align="right" bgcolor="#FFFFFF">0,053 ns</td><td align="right" bgcolor="#FFFFFF">0,010 ns</td><td align="right" bgcolor="#FFFFFF">0,023 ns</td><td align="right" bgcolor="#FFFFFF">0,056 ns</td><td align="right" bgcolor="#FFFFFF">0,045 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,065 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,646 ns</td><td align="right" bgcolor="#FFFFFF">0,608 ns</td><td align="right" bgcolor="#FFFFFF">0,627 ns</td><td align="right" bgcolor="#FFFFFF">0,672 ns</td><td align="right" bgcolor="#FFFFFF">0,615 ns</td><td align="right" bgcolor="#FFFFFF">0,633 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="ValidationSummary_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.4.0**

Slowest: 5.1.0

Δ: 179,877 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">935,023 ns</td><td align="right" bgcolor="#FFFFFF">1028,902 ns</td><td align="right" bgcolor="#FFFFFF">1113,940 ns</td><td align="right" bgcolor="#FFFFFF">1041,227 ns</td><td align="right" bgcolor="#FFFFFF">959,984 ns</td><td align="right" bgcolor="#FFFFFF">934,063 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,935 μs</td><td align="right" bgcolor="#FFFFFF">1,029 μs</td><td align="right" bgcolor="#FFFFFF">1,114 μs</td><td align="right" bgcolor="#FFFFFF">1,041 μs</td><td align="right" bgcolor="#FFFFFF">0,960 μs</td><td align="right" bgcolor="#FFFFFF">0,934 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-21,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+26,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">737,000</td><td align="right" bgcolor="#FFFFFF">737,000</td><td align="right" bgcolor="#A8D08D">581,500 (Δ = -155,500)</td><td align="right" bgcolor="#FFFFFF">581,500</td><td align="right" bgcolor="#FFFFFF">581,500</td><td align="right" bgcolor="#FF4949">737,000 (Δ = +155,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,720</td><td align="right" bgcolor="#FFFFFF">0,720</td><td align="right" bgcolor="#A8D08D">0,568 (Δ = -0,152)</td><td align="right" bgcolor="#FFFFFF">0,568</td><td align="right" bgcolor="#FFFFFF">0,568</td><td align="right" bgcolor="#FF4949">0,720 (Δ = +0,152)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.1.0**

Slowest: 4.5.4

Δ: 13898,525 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29302,242 ns</td><td align="right" bgcolor="#A8D08D">16716,760 ns (Δ = -12585,482 ns)</td><td align="right" bgcolor="#A8D08D">15403,717 ns (Δ = -1313,043 ns)</td><td align="right" bgcolor="#FFFFFF">15472,207 ns</td><td align="right" bgcolor="#FF4949">16242,116 ns (Δ = +769,909 ns)</td><td align="right" bgcolor="#FFFFFF">16389,003 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">29,302 μs</td><td align="right" bgcolor="#FFFFFF">16,717 μs</td><td align="right" bgcolor="#FFFFFF">15,404 μs</td><td align="right" bgcolor="#FFFFFF">15,472 μs</td><td align="right" bgcolor="#FFFFFF">16,242 μs</td><td align="right" bgcolor="#FFFFFF">16,389 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,029 ms</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.4.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.1.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2,000</td><td align="right" bgcolor="#A8D08D">1,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#FFFFFF">1,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">1,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -1,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,500 (Δ = +0,500)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,500)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-23,1 %</td><td align="right" bgcolor="#A8D08D">-23,2 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td><td align="right" bgcolor="#FF4949">+5,9 %</td><td align="right" bgcolor="#FF4949">+30,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">7418,000</td><td align="right" bgcolor="#A8D08D">5706,000 (Δ = -1712,000)</td><td align="right" bgcolor="#A8D08D">4380,500 (Δ = -1325,500)</td><td align="right" bgcolor="#FF4949">4382,000 (Δ = +1,500)</td><td align="right" bgcolor="#FF4949">4640,000 (Δ = +258,000)</td><td align="right" bgcolor="#FF4949">6044,000 (Δ = +1404,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">7,244</td><td align="right" bgcolor="#A8D08D">5,572 (Δ = -1,672)</td><td align="right" bgcolor="#A8D08D">4,278 (Δ = -1,294)</td><td align="right" bgcolor="#FF4949">4,279 (Δ = +0,001)</td><td align="right" bgcolor="#FF4949">4,531 (Δ = +0,252)</td><td align="right" bgcolor="#FF4949">5,902 (Δ = +1,371)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,005 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,004 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,004 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,004 (Δ = +0,000)</td><td align="right" bgcolor="#FF4949">0,006 (Δ = +0,001)</td></tr></table>


## <a name="WeakEventListener_Benchmark"></a>WeakEventListener_Benchmark

### <a name="WeakEventListener_Benchmark_CollectionChanged_Notification"></a>CollectionChanged_Notification

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1150,688 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+948,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">114,949 ns</td><td align="right" bgcolor="#FF4949">1204,961 ns (Δ = +1090,012 ns)</td><td align="right" bgcolor="#FFFFFF">1257,942 ns</td><td align="right" bgcolor="#FFFFFF">1265,638 ns</td><td align="right" bgcolor="#FFFFFF">1244,464 ns</td><td align="right" bgcolor="#FFFFFF">1237,948 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,115 μs</td><td align="right" bgcolor="#FFFFFF">1,205 μs</td><td align="right" bgcolor="#FFFFFF">1,258 μs</td><td align="right" bgcolor="#FFFFFF">1,266 μs</td><td align="right" bgcolor="#FFFFFF">1,244 μs</td><td align="right" bgcolor="#FFFFFF">1,238 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">4.5.4</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+151,9 %</td><td align="right" bgcolor="#A8D08D">-23,9 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,4 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FF4949">393,000 (Δ = +237,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -94,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FFFFFF">299,000</td><td align="right" bgcolor="#FF4949">393,000 (Δ = +94,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FF4949">0,384 (Δ = +0,231)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,092)</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FFFFFF">0,292</td><td align="right" bgcolor="#FF4949">0,384 (Δ = +0,092)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="WeakEventListener_Benchmark_GenericEvent_Notification"></a>GenericEvent_Notification

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 1069,141 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3680,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">27,504 ns</td><td align="right" bgcolor="#FF4949">1039,743 ns (Δ = +1012,238 ns)</td><td align="right" bgcolor="#FFFFFF">1079,368 ns</td><td align="right" bgcolor="#FFFFFF">1066,124 ns</td><td align="right" bgcolor="#FFFFFF">1096,645 ns</td><td align="right" bgcolor="#FFFFFF">1038,002 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">1,040 μs</td><td align="right" bgcolor="#FFFFFF">1,079 μs</td><td align="right" bgcolor="#FFFFFF">1,066 μs</td><td align="right" bgcolor="#FFFFFF">1,097 μs</td><td align="right" bgcolor="#FFFFFF">1,038 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">4.5.4</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#A8D08D">-23,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+31,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">242,000 (Δ = +242,000)</td><td align="right" bgcolor="#A8D08D">184,500 (Δ = -57,500)</td><td align="right" bgcolor="#FFFFFF">184,500</td><td align="right" bgcolor="#FFFFFF">184,500</td><td align="right" bgcolor="#FF4949">242,000 (Δ = +57,500)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,236 (Δ = +0,236)</td><td align="right" bgcolor="#A8D08D">0,180 (Δ = -0,056)</td><td align="right" bgcolor="#FFFFFF">0,180</td><td align="right" bgcolor="#FFFFFF">0,180</td><td align="right" bgcolor="#FF4949">0,236 (Δ = +0,056)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td></tr></table>


### <a name="WeakEventListener_Benchmark_PropertyChanged_Notification"></a>PropertyChanged_Notification

#### Performance

Fastest: **5.2.0**

Slowest: 5.4.0

Δ: 1,496 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,727 ns</td><td align="right" bgcolor="#FFFFFF">4,770 ns</td><td align="right" bgcolor="#FFFFFF">3,578 ns</td><td align="right" bgcolor="#FFFFFF">3,331 ns</td><td align="right" bgcolor="#FFFFFF">3,335 ns</td><td align="right" bgcolor="#FFFFFF">4,827 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

No memory usage


### <a name="WeakEventListener_Benchmark_SubscribeToWeakGenericEvent"></a>SubscribeToWeakGenericEvent

#### Performance

Fastest: **4.5.4**

Slowest: 5.4.0

Δ: 3213,733 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,8 %</td><td align="right" bgcolor="#A8D08D">-3,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,3 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16325,912 ns</td><td align="right" bgcolor="#FF4949">19229,833 ns (Δ = +2903,921 ns)</td><td align="right" bgcolor="#A8D08D">18562,665 ns (Δ = -667,168 ns)</td><td align="right" bgcolor="#FFFFFF">18615,848 ns</td><td align="right" bgcolor="#FFFFFF">18564,749 ns</td><td align="right" bgcolor="#FF4949">19539,645 ns (Δ = +974,896 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">16,326 μs</td><td align="right" bgcolor="#FFFFFF">19,230 μs</td><td align="right" bgcolor="#FFFFFF">18,563 μs</td><td align="right" bgcolor="#FFFFFF">18,616 μs</td><td align="right" bgcolor="#FFFFFF">18,565 μs</td><td align="right" bgcolor="#FFFFFF">19,540 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,2 %</td><td align="right" bgcolor="#A8D08D">-24,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+33,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1204,500</td><td align="right" bgcolor="#FF4949">1459,500 (Δ = +255,000)</td><td align="right" bgcolor="#A8D08D">1098,000 (Δ = -361,500)</td><td align="right" bgcolor="#FFFFFF">1098,000</td><td align="right" bgcolor="#A8D08D">1097,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">1459,000 (Δ = +362,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,176</td><td align="right" bgcolor="#FF4949">1,425 (Δ = +0,249)</td><td align="right" bgcolor="#A8D08D">1,072 (Δ = -0,353)</td><td align="right" bgcolor="#FFFFFF">1,072</td><td align="right" bgcolor="#A8D08D">1,071 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">1,425 (Δ = +0,354)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="WeakEventListener_Benchmark_SubscribeToWeakPropertyChangedEvent"></a>SubscribeToWeakPropertyChangedEvent

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 3703,568 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,2 %</td><td align="right" bgcolor="#A8D08D">-5,8 %</td><td align="right" bgcolor="#A8D08D">-1,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17496,646 ns</td><td align="right" bgcolor="#FF4949">21200,214 ns (Δ = +3703,568 ns)</td><td align="right" bgcolor="#A8D08D">19966,931 ns (Δ = -1233,283 ns)</td><td align="right" bgcolor="#A8D08D">19643,063 ns (Δ = -323,867 ns)</td><td align="right" bgcolor="#FFFFFF">19691,785 ns</td><td align="right" bgcolor="#FF4949">21009,937 ns (Δ = +1318,152 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">17,497 μs</td><td align="right" bgcolor="#FFFFFF">21,200 μs</td><td align="right" bgcolor="#FFFFFF">19,967 μs</td><td align="right" bgcolor="#FFFFFF">19,643 μs</td><td align="right" bgcolor="#FFFFFF">19,692 μs</td><td align="right" bgcolor="#FFFFFF">21,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.1.0</th><th>5.2.0</th><th>5.3.0</th><th>5.4.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,2 %</td><td align="right" bgcolor="#A8D08D">-24,8 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#FF4949">+33,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1204,500</td><td align="right" bgcolor="#FF4949">1459,500 (Δ = +255,000)</td><td align="right" bgcolor="#A8D08D">1098,000 (Δ = -361,500)</td><td align="right" bgcolor="#FFFFFF">1098,000</td><td align="right" bgcolor="#A8D08D">1097,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">1459,000 (Δ = +362,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,176</td><td align="right" bgcolor="#FF4949">1,425 (Δ = +0,249)</td><td align="right" bgcolor="#A8D08D">1,072 (Δ = -0,353)</td><td align="right" bgcolor="#FFFFFF">1,072</td><td align="right" bgcolor="#A8D08D">1,071 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">1,425 (Δ = +0,354)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


