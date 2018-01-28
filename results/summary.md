# Benchmarks

Benchmark report generated on 28-jan-2018 22:31

All timings are average time per operation (thus the time represents a single operation)

**Legend**

*ns = nanosecond*

*μs = microsecond (= 1000 nanoseconds)*

*ms = millisecond (= 1000 microseconds)*


If versions behave the same (e.g. result in exactly the same values), this report will show the highest version to represent the most recent state at best.
If a higher version is at least 3% slower than the previous one, it will have a red background. If it is at least 3% faster, it will have a green background.

## Host environment information

BenchmarkDotNet=v0.10.9, OS=Windows 10.0.17083

Processor=Intel Core i7-3960X CPU 3.30GHz (Ivy Bridge), ProcessorCount=8



## Important benchmarks

### High priority (current version slower than previous one)

11 item(s)

1. [Log_Debug_Benchmark::Log_Debug_Format_3_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments) v5.3.0 is **35,10%** (Δ: 330,892 ns) slower than v5.2.0

2. [WeakEventListener_Benchmark::CollectionChanged_Notification](#WeakEventListener_Benchmark_CollectionChanged_Notification) v5.3.0 is **21,01%** (Δ: 265,200 ns) slower than v5.2.0

3. [Log_Debug_Benchmark::Log_Debug_Format_6_Format_Arguments](#Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments) v5.3.0 is **19,21%** (Δ: 292,800 ns) slower than v5.2.0

4. [Attribute_ReflectionExtensions_Benchmark::GetAttribute_Generic_From_Type](#Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type) v5.3.0 is **14,84%** (Δ: 532,578 ns) slower than v5.2.0

5. [ViewModelBase_Benchmark::Construction](#ViewModelBase_Benchmark_Construction) v5.3.0 is **13,22%** (Δ: 1899,440 ns) slower than v5.2.0

6. [Type_ReflectionExtensions_Benchmark::IsInstanceOfTypeEx](#Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx) v5.3.0 is **5,03%** (Δ: 749,299 ns) slower than v5.2.0

7. [Serialization_Xml_Benchmark::SerializeLevel1Models](#Serialization_Xml_Benchmark_SerializeLevel1Models) v5.3.0 is **3,44%** (Δ: 10299,762 ns) slower than v5.2.0

8. [Serialization_Xml_Benchmark::SerializeLevel3Models](#Serialization_Xml_Benchmark_SerializeLevel3Models) v5.3.0 is **2,14%** (Δ: 51515,103 ns) slower than v5.2.0

9. [Serialization_Json_Benchmark::SerializeComplexObjectGraph](#Serialization_Json_Benchmark_SerializeComplexObjectGraph) v5.3.0 is **2,06%** (Δ: 374713,185 ns) slower than v5.2.0

10. [Serialization_Json_Benchmark::SerializeLevel3Models](#Serialization_Json_Benchmark_SerializeLevel3Models) v5.3.0 is **1,54%** (Δ: 223457,752 ns) slower than v5.2.0

11. [Serialization_Xml_Benchmark::SerializeLevel2Models](#Serialization_Xml_Benchmark_SerializeLevel2Models) v5.3.0 is **1,44%** (Δ: 9319,713 ns) slower than v5.2.0



### Improved (current version faster than previous one)

4 item(s)

1. [TagHelper_Benchmark::ToString_](#TagHelper_Benchmark_ToString_) v5.3.0 is **66053,04%** (Δ: -334,462 ns) faster than v5.2.0

2. [Type_ReflectionExtensions_Benchmark::GetCustomAttributeEx_Inherit](#Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit) v5.3.0 is **45238,19%** (Δ: -429,859 ns) faster than v5.2.0

3. [Type_ReflectionExtensions_Benchmark::GetCustomAttributesEx](#Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx) v5.3.0 is **13551,85%** (Δ: -346,828 ns) faster than v5.2.0

4. [TypeExtensions_Benchmark::GetCollectionElementType](#TypeExtensions_Benchmark_GetCollectionElementType) v5.3.0 is **5901,31%** (Δ: -604,898 ns) faster than v5.2.0



## <a name="Argument_Benchmark"></a>Argument_Benchmark

### <a name="Argument_Benchmark_ImplementsInterface"></a>ImplementsInterface

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 8,147 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">97,952 ns</td><td align="right" bgcolor="#FFFFFF">106,098 ns</td><td align="right" bgcolor="#FFFFFF">98,168 ns</td><td align="right" bgcolor="#FFFFFF">102,160 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsInterface_Generic"></a>ImplementsInterface_Generic

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 5,777 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">98,873 ns</td><td align="right" bgcolor="#FFFFFF">102,463 ns</td><td align="right" bgcolor="#FFFFFF">99,782 ns</td><td align="right" bgcolor="#FFFFFF">104,650 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces"></a>ImplementsOneOfTheInterfaces

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 10,307 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">90,820 ns</td><td align="right" bgcolor="#FFFFFF">94,362 ns</td><td align="right" bgcolor="#FFFFFF">86,258 ns</td><td align="right" bgcolor="#FFFFFF">96,565 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_ImplementsOneOfTheInterfaces_Object"></a>ImplementsOneOfTheInterfaces_Object

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 7,217 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">97,103 ns</td><td align="right" bgcolor="#FFFFFF">97,352 ns</td><td align="right" bgcolor="#FFFFFF">95,100 ns</td><td align="right" bgcolor="#FFFFFF">102,317 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#FFFFFF">156,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#FFFFFF">0,152</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_InheritsFrom"></a>InheritsFrom

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 11,010 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">37,687 ns</td><td align="right" bgcolor="#FFFFFF">36,308 ns</td><td align="right" bgcolor="#FFFFFF">46,530 ns</td><td align="right" bgcolor="#FFFFFF">47,318 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_InheritsFrom_Generic"></a>InheritsFrom_Generic

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 13,453 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">44,933 ns</td><td align="right" bgcolor="#FFFFFF">41,538 ns</td><td align="right" bgcolor="#FFFFFF">52,910 ns</td><td align="right" bgcolor="#FFFFFF">54,992 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td><td align="right" bgcolor="#FFFFFF">0,053 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_InheritsFrom_Object"></a>InheritsFrom_Object

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 22,325 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">43,648 ns</td><td align="right" bgcolor="#FFFFFF">41,402 ns</td><td align="right" bgcolor="#FFFFFF">55,463 ns</td><td align="right" bgcolor="#FFFFFF">63,727 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,055 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsMatch"></a>IsMatch

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 128,600 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">686,448 ns</td><td align="right" bgcolor="#FFFFFF">680,320 ns</td><td align="right" bgcolor="#FFFFFF">657,322 ns</td><td align="right" bgcolor="#FFFFFF">785,922 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,686 μs</td><td align="right" bgcolor="#FFFFFF">0,680 μs</td><td align="right" bgcolor="#FFFFFF">0,657 μs</td><td align="right" bgcolor="#FFFFFF">0,786 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">184,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">184,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,180 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,180</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsMaximum"></a>IsMaximum

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 1,212 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,653 ns</td><td align="right" bgcolor="#FFFFFF">14,513 ns</td><td align="right" bgcolor="#FFFFFF">14,408 ns</td><td align="right" bgcolor="#FFFFFF">15,620 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsMinimal"></a>IsMinimal

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 2,720 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,993 ns</td><td align="right" bgcolor="#FFFFFF">16,188 ns</td><td align="right" bgcolor="#FFFFFF">16,430 ns</td><td align="right" bgcolor="#FFFFFF">18,713 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotEmpty"></a>IsNotEmpty

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 9,353 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,348 ns</td><td align="right" bgcolor="#FFFFFF">15,702 ns</td><td align="right" bgcolor="#FFFFFF">7,830 ns</td><td align="right" bgcolor="#FFFFFF">9,698 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotMatch"></a>IsNotMatch

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 20,747 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">528,212 ns</td><td align="right" bgcolor="#FFFFFF">520,380 ns</td><td align="right" bgcolor="#FFFFFF">523,208 ns</td><td align="right" bgcolor="#FFFFFF">541,127 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,528 μs</td><td align="right" bgcolor="#FFFFFF">0,520 μs</td><td align="right" bgcolor="#FFFFFF">0,523 μs</td><td align="right" bgcolor="#FFFFFF">0,541 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">184,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">184,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,180 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,180</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotNull"></a>IsNotNull

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 0,803 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,012 ns</td><td align="right" bgcolor="#FFFFFF">1,068 ns</td><td align="right" bgcolor="#FFFFFF">1,715 ns</td><td align="right" bgcolor="#FFFFFF">1,815 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotNullOrEmpty"></a>IsNotNullOrEmpty

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 2,137 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1,135 ns</td><td align="right" bgcolor="#FFFFFF">1,358 ns</td><td align="right" bgcolor="#FFFFFF">3,272 ns</td><td align="right" bgcolor="#FFFFFF">2,278 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotNullOrEmpty_Guid"></a>IsNotNullOrEmpty_Guid

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 1,837 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,808 ns</td><td align="right" bgcolor="#FFFFFF">11,137 ns</td><td align="right" bgcolor="#FFFFFF">11,480 ns</td><td align="right" bgcolor="#FFFFFF">11,645 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotNullOrEmptyArray"></a>IsNotNullOrEmptyArray

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 0,417 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,170 ns</td><td align="right" bgcolor="#FFFFFF">3,478 ns</td><td align="right" bgcolor="#FFFFFF">3,412 ns</td><td align="right" bgcolor="#FFFFFF">3,587 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotNullOrWhitespace"></a>IsNotNullOrWhitespace

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 4,517 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,503 ns</td><td align="right" bgcolor="#FFFFFF">15,070 ns</td><td align="right" bgcolor="#FFFFFF">17,537 ns</td><td align="right" bgcolor="#FFFFFF">19,020 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes"></a>IsNotOfOneOfTheTypes

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 15,132 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">82,812 ns</td><td align="right" bgcolor="#FFFFFF">83,128 ns</td><td align="right" bgcolor="#FFFFFF">95,815 ns</td><td align="right" bgcolor="#FFFFFF">97,943 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,083 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotOfOneOfTheTypes_Object"></a>IsNotOfOneOfTheTypes_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 19,612 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">87,378 ns</td><td align="right" bgcolor="#FFFFFF">90,915 ns</td><td align="right" bgcolor="#FFFFFF">103,710 ns</td><td align="right" bgcolor="#FFFFFF">106,990 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotOfType"></a>IsNotOfType

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 9,785 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">56,938 ns</td><td align="right" bgcolor="#FFFFFF">57,092 ns</td><td align="right" bgcolor="#FFFFFF">65,422 ns</td><td align="right" bgcolor="#FFFFFF">66,723 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,057 μs</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotOfType_Object"></a>IsNotOfType_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 8,593 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">65,023 ns</td><td align="right" bgcolor="#FFFFFF">68,813 ns</td><td align="right" bgcolor="#FFFFFF">72,470 ns</td><td align="right" bgcolor="#FFFFFF">73,617 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,065 μs</td><td align="right" bgcolor="#FFFFFF">0,069 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsNotOutOfRange"></a>IsNotOutOfRange

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 2,990 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,802 ns</td><td align="right" bgcolor="#FFFFFF">25,188 ns</td><td align="right" bgcolor="#FFFFFF">25,930 ns</td><td align="right" bgcolor="#FFFFFF">27,792 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#FFFFFF">49,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -24,000)</td><td align="right" bgcolor="#FFFFFF">25,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#FFFFFF">0,048</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,023)</td><td align="right" bgcolor="#FFFFFF">0,024</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes"></a>IsOfOneOfTheTypes

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 7,103 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">58,810 ns</td><td align="right" bgcolor="#FFFFFF">60,995 ns</td><td align="right" bgcolor="#FFFFFF">64,155 ns</td><td align="right" bgcolor="#FFFFFF">65,913 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td><td align="right" bgcolor="#FFFFFF">0,061 μs</td><td align="right" bgcolor="#FFFFFF">0,064 μs</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsOfOneOfTheTypes_Object"></a>IsOfOneOfTheTypes_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 5,803 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">66,485 ns</td><td align="right" bgcolor="#FFFFFF">67,133 ns</td><td align="right" bgcolor="#FFFFFF">69,650 ns</td><td align="right" bgcolor="#FFFFFF">72,288 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,066 μs</td><td align="right" bgcolor="#FFFFFF">0,067 μs</td><td align="right" bgcolor="#FFFFFF">0,070 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsOfType"></a>IsOfType

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 4,292 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">39,725 ns</td><td align="right" bgcolor="#FFFFFF">39,750 ns</td><td align="right" bgcolor="#FFFFFF">43,145 ns</td><td align="right" bgcolor="#FFFFFF">44,017 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td><td align="right" bgcolor="#FFFFFF">0,043 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Argument_Benchmark_IsOfType_Object"></a>IsOfType_Object

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 4,243 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">46,592 ns</td><td align="right" bgcolor="#FFFFFF">47,468 ns</td><td align="right" bgcolor="#FFFFFF">50,075 ns</td><td align="right" bgcolor="#FFFFFF">50,835 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,047 μs</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,051 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Assembly_ReflectionExtensions_Benchmark"></a>Assembly_ReflectionExtensions_Benchmark

### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 857,533 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7453,922 ns</td><td align="right" bgcolor="#FFFFFF">7464,625 ns</td><td align="right" bgcolor="#FF4949">8287,175 ns (Δ = +822,550 ns)</td><td align="right" bgcolor="#FFFFFF">8311,455 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,454 μs</td><td align="right" bgcolor="#FFFFFF">7,465 μs</td><td align="right" bgcolor="#FFFFFF">8,287 μs</td><td align="right" bgcolor="#FFFFFF">8,311 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#A8D08D">381,000 (Δ = -348,000)</td><td align="right" bgcolor="#FFFFFF">381,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#A8D08D">0,372 (Δ = -0,340)</td><td align="right" bgcolor="#FFFFFF">0,372</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 794,091 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7478,782 ns</td><td align="right" bgcolor="#FFFFFF">7598,330 ns</td><td align="right" bgcolor="#FF4949">8250,845 ns (Δ = +652,515 ns)</td><td align="right" bgcolor="#FFFFFF">8272,873 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,479 μs</td><td align="right" bgcolor="#FFFFFF">7,598 μs</td><td align="right" bgcolor="#FFFFFF">8,251 μs</td><td align="right" bgcolor="#FFFFFF">8,273 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#FFFFFF">729,000</td><td align="right" bgcolor="#A8D08D">381,000 (Δ = -348,000)</td><td align="right" bgcolor="#FFFFFF">381,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#FFFFFF">0,712</td><td align="right" bgcolor="#A8D08D">0,372 (Δ = -0,340)</td><td align="right" bgcolor="#FFFFFF">0,372</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetExportedTypesEx"></a>GetExportedTypesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 6093,627 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+41,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14553,417 ns</td><td align="right" bgcolor="#FFFFFF">14615,425 ns</td><td align="right" bgcolor="#FF4949">20636,618 ns (Δ = +6021,193 ns)</td><td align="right" bgcolor="#FFFFFF">20647,043 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">14,553 μs</td><td align="right" bgcolor="#FFFFFF">14,615 μs</td><td align="right" bgcolor="#FFFFFF">20,637 μs</td><td align="right" bgcolor="#FFFFFF">20,647 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,9 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1364,000</td><td align="right" bgcolor="#FF4949">1376,000 (Δ = +12,000)</td><td align="right" bgcolor="#A8D08D">688,000 (Δ = -688,000)</td><td align="right" bgcolor="#FFFFFF">688,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,332</td><td align="right" bgcolor="#FF4949">1,344 (Δ = +0,012)</td><td align="right" bgcolor="#A8D08D">0,672 (Δ = -0,672)</td><td align="right" bgcolor="#FFFFFF">0,672</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Assembly_ReflectionExtensions_Benchmark_GetTypesEx"></a>GetTypesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 3465,042 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+55,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5955,212 ns</td><td align="right" bgcolor="#FFFFFF">6024,570 ns</td><td align="right" bgcolor="#FF4949">9370,347 ns (Δ = +3345,777 ns)</td><td align="right" bgcolor="#FFFFFF">9420,253 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,955 μs</td><td align="right" bgcolor="#FFFFFF">6,025 μs</td><td align="right" bgcolor="#FFFFFF">9,370 μs</td><td align="right" bgcolor="#FFFFFF">9,420 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,1 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3011,000</td><td align="right" bgcolor="#FF4949">3043,000 (Δ = +32,000)</td><td align="right" bgcolor="#A8D08D">1523,000 (Δ = -1520,000)</td><td align="right" bgcolor="#A8D08D">1521,000 (Δ = -2,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,940</td><td align="right" bgcolor="#FF4949">2,972 (Δ = +0,031)</td><td align="right" bgcolor="#A8D08D">1,487 (Δ = -1,484)</td><td align="right" bgcolor="#A8D08D">1,485 (Δ = -0,002)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td></tr></table>


## <a name="AssemblyExtensions_Benchmark"></a>AssemblyExtensions_Benchmark

### <a name="AssemblyExtensions_Benchmark_Company"></a>Company

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 435,148 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9612,095 ns</td><td align="right" bgcolor="#FFFFFF">9568,167 ns</td><td align="right" bgcolor="#FF4949">9864,158 ns (Δ = +295,992 ns)</td><td align="right" bgcolor="#FFFFFF">10003,315 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,612 μs</td><td align="right" bgcolor="#FFFFFF">9,568 μs</td><td align="right" bgcolor="#FFFFFF">9,864 μs</td><td align="right" bgcolor="#FFFFFF">10,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#FFFFFF">836,000</td><td align="right" bgcolor="#A8D08D">430,000 (Δ = -406,000)</td><td align="right" bgcolor="#FFFFFF">430,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#FFFFFF">0,816</td><td align="right" bgcolor="#A8D08D">0,420 (Δ = -0,396)</td><td align="right" bgcolor="#FFFFFF">0,420</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Copyright"></a>Copyright

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 485,755 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9630,528 ns</td><td align="right" bgcolor="#FFFFFF">9678,687 ns</td><td align="right" bgcolor="#FF4949">10006,200 ns (Δ = +327,513 ns)</td><td align="right" bgcolor="#FFFFFF">10116,283 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,631 μs</td><td align="right" bgcolor="#FFFFFF">9,679 μs</td><td align="right" bgcolor="#FFFFFF">10,006 μs</td><td align="right" bgcolor="#FFFFFF">10,116 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#A8D08D">479,000 (Δ = -402,000)</td><td align="right" bgcolor="#FFFFFF">479,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#A8D08D">0,468 (Δ = -0,393)</td><td align="right" bgcolor="#FFFFFF">0,468</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Description"></a>Description

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 526,173 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+5,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9486,410 ns</td><td align="right" bgcolor="#FFFFFF">9365,733 ns</td><td align="right" bgcolor="#FF4949">9891,907 ns (Δ = +526,173 ns)</td><td align="right" bgcolor="#FFFFFF">9818,758 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,486 μs</td><td align="right" bgcolor="#FFFFFF">9,366 μs</td><td align="right" bgcolor="#FFFFFF">9,892 μs</td><td align="right" bgcolor="#FFFFFF">9,819 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">442,000 (Δ = -410,000)</td><td align="right" bgcolor="#FFFFFF">442,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,432 (Δ = -0,400)</td><td align="right" bgcolor="#FFFFFF">0,432</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetBuildDateTime"></a>GetBuildDateTime

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 180509,747 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">439282,073 ns</td><td align="right" bgcolor="#FFFFFF">443485,845 ns</td><td align="right" bgcolor="#A8D08D">263862,353 ns (Δ = -179623,492 ns)</td><td align="right" bgcolor="#FFFFFF">262976,098 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">439,282 μs</td><td align="right" bgcolor="#FFFFFF">443,486 μs</td><td align="right" bgcolor="#FFFFFF">263,862 μs</td><td align="right" bgcolor="#FFFFFF">262,976 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,439 ms</td><td align="right" bgcolor="#FFFFFF">0,443 ms</td><td align="right" bgcolor="#FFFFFF">0,264 ms</td><td align="right" bgcolor="#FFFFFF">0,263 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">30,000</td><td align="right" bgcolor="#FFFFFF">30,000</td><td align="right" bgcolor="#A8D08D">20,000 (Δ = -10,000)</td><td align="right" bgcolor="#FFFFFF">20,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FF4949">20,000 (Δ = +5,000)</td><td align="right" bgcolor="#FFFFFF">20,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20467,000</td><td align="right" bgcolor="#FFFFFF">20467,000</td><td align="right" bgcolor="#A8D08D">10920,000 (Δ = -9547,000)</td><td align="right" bgcolor="#FFFFFF">10920,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">19,987</td><td align="right" bgcolor="#FFFFFF">19,987</td><td align="right" bgcolor="#A8D08D">10,664 (Δ = -9,323)</td><td align="right" bgcolor="#FFFFFF">10,664</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,010 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,010</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_GetDirectory"></a>GetDirectory

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 889,155 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+35,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2455,030 ns</td><td align="right" bgcolor="#FFFFFF">2446,887 ns</td><td align="right" bgcolor="#FF4949">3316,890 ns (Δ = +870,003 ns)</td><td align="right" bgcolor="#FFFFFF">3336,042 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,455 μs</td><td align="right" bgcolor="#FFFFFF">2,447 μs</td><td align="right" bgcolor="#FFFFFF">3,317 μs</td><td align="right" bgcolor="#FFFFFF">3,336 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-25,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1012,000</td><td align="right" bgcolor="#FFFFFF">1012,000</td><td align="right" bgcolor="#A8D08D">750,000 (Δ = -262,000)</td><td align="right" bgcolor="#FFFFFF">750,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,988</td><td align="right" bgcolor="#FFFFFF">0,988</td><td align="right" bgcolor="#A8D08D">0,732 (Δ = -0,256)</td><td align="right" bgcolor="#FFFFFF">0,732</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_InformationalVersion"></a>InformationalVersion

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 750,937 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7636,020 ns</td><td align="right" bgcolor="#FFFFFF">7593,070 ns</td><td align="right" bgcolor="#FF4949">8344,007 ns (Δ = +750,937 ns)</td><td align="right" bgcolor="#FFFFFF">8340,312 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,636 μs</td><td align="right" bgcolor="#FFFFFF">7,593 μs</td><td align="right" bgcolor="#FFFFFF">8,344 μs</td><td align="right" bgcolor="#FFFFFF">8,340 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#A8D08D">422,000 (Δ = -348,000)</td><td align="right" bgcolor="#FFFFFF">422,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#A8D08D">0,412 (Δ = -0,340)</td><td align="right" bgcolor="#FFFFFF">0,412</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Product"></a>Product

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 279,585 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9728,298 ns</td><td align="right" bgcolor="#FFFFFF">9623,787 ns</td><td align="right" bgcolor="#FF4949">9903,372 ns (Δ = +279,585 ns)</td><td align="right" bgcolor="#FFFFFF">9837,824 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,728 μs</td><td align="right" bgcolor="#FFFFFF">9,624 μs</td><td align="right" bgcolor="#FFFFFF">9,903 μs</td><td align="right" bgcolor="#FFFFFF">9,838 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">442,000 (Δ = -410,000)</td><td align="right" bgcolor="#FFFFFF">442,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,432 (Δ = -0,400)</td><td align="right" bgcolor="#FFFFFF">0,432</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Title"></a>Title

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 443,342 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9661,025 ns</td><td align="right" bgcolor="#FFFFFF">9618,750 ns</td><td align="right" bgcolor="#FFFFFF">9851,090 ns</td><td align="right" bgcolor="#FFFFFF">10062,092 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">9,661 μs</td><td align="right" bgcolor="#FFFFFF">9,619 μs</td><td align="right" bgcolor="#FFFFFF">9,851 μs</td><td align="right" bgcolor="#FFFFFF">10,062 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">442,000 (Δ = -410,000)</td><td align="right" bgcolor="#FFFFFF">442,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,432 (Δ = -0,400)</td><td align="right" bgcolor="#FFFFFF">0,432</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="AssemblyExtensions_Benchmark_Version"></a>Version

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 17,085 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">937,220 ns</td><td align="right" bgcolor="#FFFFFF">930,877 ns</td><td align="right" bgcolor="#FFFFFF">947,962 ns</td><td align="right" bgcolor="#FFFFFF">944,813 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,937 μs</td><td align="right" bgcolor="#FFFFFF">0,931 μs</td><td align="right" bgcolor="#FFFFFF">0,948 μs</td><td align="right" bgcolor="#FFFFFF">0,945 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-28,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1233,000</td><td align="right" bgcolor="#FFFFFF">1233,000</td><td align="right" bgcolor="#A8D08D">881,000 (Δ = -352,000)</td><td align="right" bgcolor="#FFFFFF">881,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,204</td><td align="right" bgcolor="#FFFFFF">1,204</td><td align="right" bgcolor="#A8D08D">0,860 (Δ = -0,344)</td><td align="right" bgcolor="#FFFFFF">0,860</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Attribute_ReflectionExtensions_Benchmark"></a>Attribute_ReflectionExtensions_Benchmark

### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Member"></a>GetAttribute_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 417,168 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+12,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2565,677 ns</td><td align="right" bgcolor="#FFFFFF">2636,220 ns</td><td align="right" bgcolor="#FF4949">2961,768 ns (Δ = +325,548 ns)</td><td align="right" bgcolor="#FFFFFF">2982,845 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,566 μs</td><td align="right" bgcolor="#FFFFFF">2,636 μs</td><td align="right" bgcolor="#FFFFFF">2,962 μs</td><td align="right" bgcolor="#FFFFFF">2,983 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_From_Type"></a>GetAttribute_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 590,897 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+12,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3334,185 ns</td><td align="right" bgcolor="#FFFFFF">3216,612 ns</td><td align="right" bgcolor="#FF4949">3601,408 ns (Δ = +384,797 ns)</td><td align="right" bgcolor="#FFFFFF">3807,508 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,334 μs</td><td align="right" bgcolor="#FFFFFF">3,217 μs</td><td align="right" bgcolor="#FFFFFF">3,601 μs</td><td align="right" bgcolor="#FFFFFF">3,808 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Member"></a>GetAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 458,118 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2648,957 ns</td><td align="right" bgcolor="#FFFFFF">2614,947 ns</td><td align="right" bgcolor="#FF4949">3073,065 ns (Δ = +458,118 ns)</td><td align="right" bgcolor="#FFFFFF">2993,458 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,649 μs</td><td align="right" bgcolor="#FFFFFF">2,615 μs</td><td align="right" bgcolor="#FFFFFF">3,073 μs</td><td align="right" bgcolor="#FFFFFF">2,993 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_GetAttribute_Generic_From_Type"></a>GetAttribute_Generic_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 841,847 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,4 %</td><td align="right" bgcolor="#FF4949">+14,8 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3416,072 ns</td><td align="right" bgcolor="#FFFFFF">3280,602 ns</td><td align="right" bgcolor="#FF4949">3589,870 ns (Δ = +309,268 ns)</td><td align="right" bgcolor="#FF4949">4122,448 ns (Δ = +532,578 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,416 μs</td><td align="right" bgcolor="#FFFFFF">3,281 μs</td><td align="right" bgcolor="#FFFFFF">3,590 μs</td><td align="right" bgcolor="#FFFFFF">4,122 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Member"></a>IsDecoratedWithAttribute_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 488,817 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2608,155 ns</td><td align="right" bgcolor="#FFFFFF">2529,865 ns</td><td align="right" bgcolor="#FF4949">3018,682 ns (Δ = +488,817 ns)</td><td align="right" bgcolor="#FFFFFF">3002,805 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,608 μs</td><td align="right" bgcolor="#FFFFFF">2,530 μs</td><td align="right" bgcolor="#FFFFFF">3,019 μs</td><td align="right" bgcolor="#FFFFFF">3,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_From_Type"></a>IsDecoratedWithAttribute_From_Type

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 331,453 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3318,103 ns</td><td align="right" bgcolor="#FFFFFF">3343,507 ns</td><td align="right" bgcolor="#FFFFFF">3582,415 ns</td><td align="right" bgcolor="#FFFFFF">3649,557 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,318 μs</td><td align="right" bgcolor="#FFFFFF">3,344 μs</td><td align="right" bgcolor="#FFFFFF">3,582 μs</td><td align="right" bgcolor="#FFFFFF">3,650 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Member"></a>IsDecoratedWithAttribute_Generic_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 471,228 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2537,035 ns</td><td align="right" bgcolor="#FFFFFF">2610,247 ns</td><td align="right" bgcolor="#FF4949">3008,263 ns (Δ = +398,017 ns)</td><td align="right" bgcolor="#FFFFFF">2990,697 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,537 μs</td><td align="right" bgcolor="#FFFFFF">2,610 μs</td><td align="right" bgcolor="#FFFFFF">3,008 μs</td><td align="right" bgcolor="#FFFFFF">2,991 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_IsDecoratedWithAttribute_Generic_From_Type"></a>IsDecoratedWithAttribute_Generic_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 362,162 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3335,452 ns</td><td align="right" bgcolor="#FFFFFF">3289,798 ns</td><td align="right" bgcolor="#FF4949">3640,817 ns (Δ = +351,018 ns)</td><td align="right" bgcolor="#FFFFFF">3651,960 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,335 μs</td><td align="right" bgcolor="#FFFFFF">3,290 μs</td><td align="right" bgcolor="#FFFFFF">3,641 μs</td><td align="right" bgcolor="#FFFFFF">3,652 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Member"></a>TryGetAttribute_From_Member

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 473,692 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+16,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2507,665 ns</td><td align="right" bgcolor="#FFFFFF">2546,180 ns</td><td align="right" bgcolor="#FF4949">2975,673 ns (Δ = +429,493 ns)</td><td align="right" bgcolor="#FFFFFF">2981,357 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,508 μs</td><td align="right" bgcolor="#FFFFFF">2,546 μs</td><td align="right" bgcolor="#FFFFFF">2,976 μs</td><td align="right" bgcolor="#FFFFFF">2,981 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_From_Type"></a>TryGetAttribute_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 388,643 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+12,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3272,457 ns</td><td align="right" bgcolor="#FFFFFF">3243,928 ns</td><td align="right" bgcolor="#FF4949">3632,572 ns (Δ = +388,643 ns)</td><td align="right" bgcolor="#FFFFFF">3618,945 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,272 μs</td><td align="right" bgcolor="#FFFFFF">3,244 μs</td><td align="right" bgcolor="#FFFFFF">3,633 μs</td><td align="right" bgcolor="#FFFFFF">3,619 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Member"></a>TryGetAttribute_Generic_From_Member

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 543,135 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2626,657 ns</td><td align="right" bgcolor="#FFFFFF">2617,950 ns</td><td align="right" bgcolor="#FF4949">3013,013 ns (Δ = +395,063 ns)</td><td align="right" bgcolor="#FFFFFF">3161,085 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,627 μs</td><td align="right" bgcolor="#FFFFFF">2,618 μs</td><td align="right" bgcolor="#FFFFFF">3,013 μs</td><td align="right" bgcolor="#FFFFFF">3,161 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#FFFFFF">250,000</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#FFFFFF">0,244</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Attribute_ReflectionExtensions_Benchmark_TryGetAttribute_Generic_From_Type"></a>TryGetAttribute_Generic_From_Type

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 427,275 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+12,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3358,228 ns</td><td align="right" bgcolor="#FFFFFF">3227,082 ns</td><td align="right" bgcolor="#FF4949">3617,842 ns (Δ = +390,760 ns)</td><td align="right" bgcolor="#FFFFFF">3654,357 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,358 μs</td><td align="right" bgcolor="#FFFFFF">3,227 μs</td><td align="right" bgcolor="#FFFFFF">3,618 μs</td><td align="right" bgcolor="#FFFFFF">3,654 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="CacheStorage_Benchmark"></a>CacheStorage_Benchmark

### <a name="CacheStorage_Benchmark_Clear_Cache"></a>Clear_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 49,202 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">236,458 ns</td><td align="right" bgcolor="#FFFFFF">236,628 ns</td><td align="right" bgcolor="#FFFFFF">254,665 ns</td><td align="right" bgcolor="#FFFFFF">285,660 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,237 μs</td><td align="right" bgcolor="#FFFFFF">0,255 μs</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">111,000 (Δ = -106,000)</td><td align="right" bgcolor="#FFFFFF">111,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,108 (Δ = -0,104)</td><td align="right" bgcolor="#FFFFFF">0,108</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch"></a>GetFromCacheOrFetch

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 28,688 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">240,227 ns</td><td align="right" bgcolor="#FFFFFF">235,572 ns</td><td align="right" bgcolor="#FFFFFF">263,405 ns</td><td align="right" bgcolor="#FFFFFF">264,260 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,240 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,263 μs</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#A8D08D">74,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">74,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#A8D08D">0,072 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,072</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy"></a>GetFromCacheOrFetch_From_A_Cache_With_Expiration_Policy

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 22,294 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">244,003 ns</td><td align="right" bgcolor="#FFFFFF">247,115 ns</td><td align="right" bgcolor="#FFFFFF">260,175 ns</td><td align="right" bgcolor="#FFFFFF">266,298 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td><td align="right" bgcolor="#FFFFFF">0,260 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#FFFFFF">139,000</td><td align="right" bgcolor="#A8D08D">74,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">74,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#FFFFFF">0,136</td><td align="right" bgcolor="#A8D08D">0,072 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,072</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_GetValue_From_An_Already_Initialized_Cache"></a>GetValue_From_An_Already_Initialized_Cache

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 31,025 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">220,057 ns</td><td align="right" bgcolor="#FFFFFF">219,245 ns</td><td align="right" bgcolor="#FFFFFF">242,053 ns</td><td align="right" bgcolor="#FFFFFF">250,270 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,220 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td><td align="right" bgcolor="#FFFFFF">0,250 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">61,000 (Δ = -62,000)</td><td align="right" bgcolor="#FFFFFF">61,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#A8D08D">0,060 (Δ = -0,061)</td><td align="right" bgcolor="#FFFFFF">0,060</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_Overwrite_An_Existing_Cached_Value"></a>Overwrite_An_Existing_Cached_Value

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 28,120 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">219,983 ns</td><td align="right" bgcolor="#FFFFFF">218,948 ns</td><td align="right" bgcolor="#FFFFFF">244,082 ns</td><td align="right" bgcolor="#FFFFFF">247,068 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,220 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#FFFFFF">123,000</td><td align="right" bgcolor="#A8D08D">61,000 (Δ = -62,000)</td><td align="right" bgcolor="#FFFFFF">61,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#FFFFFF">0,120</td><td align="right" bgcolor="#A8D08D">0,060 (Δ = -0,061)</td><td align="right" bgcolor="#FFFFFF">0,060</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="CacheStorage_Benchmark_RemoveItem_From_Cache"></a>RemoveItem_From_Cache

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 37,530 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">230,752 ns</td><td align="right" bgcolor="#FFFFFF">235,647 ns</td><td align="right" bgcolor="#FFFFFF">255,623 ns</td><td align="right" bgcolor="#FFFFFF">268,282 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td><td align="right" bgcolor="#FFFFFF">0,236 μs</td><td align="right" bgcolor="#FFFFFF">0,256 μs</td><td align="right" bgcolor="#FFFFFF">0,268 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">111,000 (Δ = -106,000)</td><td align="right" bgcolor="#FFFFFF">111,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,108 (Δ = -0,104)</td><td align="right" bgcolor="#FFFFFF">0,108</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Enum_Benchmark"></a>Enum_Benchmark

### <a name="Enum_Benchmark_ConvertFromOtherEnumValue"></a>ConvertFromOtherEnumValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 139,615 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">839,852 ns</td><td align="right" bgcolor="#FFFFFF">845,117 ns</td><td align="right" bgcolor="#FFFFFF">979,467 ns</td><td align="right" bgcolor="#FFFFFF">934,243 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,840 μs</td><td align="right" bgcolor="#FFFFFF">0,845 μs</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">0,934 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">188,000</td><td align="right" bgcolor="#FFFFFF">188,000</td><td align="right" bgcolor="#A8D08D">94,000 (Δ = -94,000)</td><td align="right" bgcolor="#FFFFFF">94,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#FFFFFF">0,184</td><td align="right" bgcolor="#A8D08D">0,092 (Δ = -0,092)</td><td align="right" bgcolor="#FFFFFF">0,092</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetName"></a>GetName

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 13,205 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">119,907 ns</td><td align="right" bgcolor="#FFFFFF">121,353 ns</td><td align="right" bgcolor="#FFFFFF">131,727 ns</td><td align="right" bgcolor="#FFFFFF">133,112 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,120 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetName_Long"></a>GetName_Long

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 10,500 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">138,680 ns</td><td align="right" bgcolor="#FFFFFF">140,805 ns</td><td align="right" bgcolor="#FFFFFF">149,180 ns</td><td align="right" bgcolor="#FFFFFF">148,745 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td><td align="right" bgcolor="#FFFFFF">0,149 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetNames"></a>GetNames

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 213,348 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1974,748 ns</td><td align="right" bgcolor="#FFFFFF">1987,417 ns</td><td align="right" bgcolor="#FFFFFF">1774,068 ns</td><td align="right" bgcolor="#FFFFFF">1797,805 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,975 μs</td><td align="right" bgcolor="#FFFFFF">1,987 μs</td><td align="right" bgcolor="#FFFFFF">1,774 μs</td><td align="right" bgcolor="#FFFFFF">1,798 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">913,000</td><td align="right" bgcolor="#FFFFFF">913,000</td><td align="right" bgcolor="#A8D08D">467,000 (Δ = -446,000)</td><td align="right" bgcolor="#FFFFFF">467,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,892</td><td align="right" bgcolor="#FFFFFF">0,892</td><td align="right" bgcolor="#A8D08D">0,456 (Δ = -0,436)</td><td align="right" bgcolor="#FFFFFF">0,456</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_GetValues"></a>GetValues

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 23,535 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3736,247 ns</td><td align="right" bgcolor="#FFFFFF">3729,018 ns</td><td align="right" bgcolor="#FFFFFF">3723,275 ns</td><td align="right" bgcolor="#FFFFFF">3746,810 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,736 μs</td><td align="right" bgcolor="#FFFFFF">3,729 μs</td><td align="right" bgcolor="#FFFFFF">3,723 μs</td><td align="right" bgcolor="#FFFFFF">3,747 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-46,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1106,000</td><td align="right" bgcolor="#FFFFFF">1106,000</td><td align="right" bgcolor="#A8D08D">594,000 (Δ = -512,000)</td><td align="right" bgcolor="#FFFFFF">594,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,080</td><td align="right" bgcolor="#FFFFFF">1,080</td><td align="right" bgcolor="#A8D08D">0,580 (Δ = -0,500)</td><td align="right" bgcolor="#FFFFFF">0,580</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Enum_Benchmark_Parse"></a>Parse

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 44,637 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">272,335 ns</td><td align="right" bgcolor="#FFFFFF">273,790 ns</td><td align="right" bgcolor="#FFFFFF">308,110 ns</td><td align="right" bgcolor="#FFFFFF">316,972 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,272 μs</td><td align="right" bgcolor="#FFFFFF">0,274 μs</td><td align="right" bgcolor="#FFFFFF">0,308 μs</td><td align="right" bgcolor="#FFFFFF">0,317 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_ToList"></a>ToList

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 140,997 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3814,540 ns</td><td align="right" bgcolor="#FFFFFF">3870,580 ns</td><td align="right" bgcolor="#FFFFFF">3755,098 ns</td><td align="right" bgcolor="#FFFFFF">3896,095 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,815 μs</td><td align="right" bgcolor="#FFFFFF">3,871 μs</td><td align="right" bgcolor="#FFFFFF">3,755 μs</td><td align="right" bgcolor="#FFFFFF">3,896 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1196,000</td><td align="right" bgcolor="#FFFFFF">1196,000</td><td align="right" bgcolor="#A8D08D">651,000 (Δ = -545,000)</td><td align="right" bgcolor="#FFFFFF">651,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,168</td><td align="right" bgcolor="#FFFFFF">1,168</td><td align="right" bgcolor="#A8D08D">0,636 (Δ = -0,532)</td><td align="right" bgcolor="#FFFFFF">0,636</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="Enum_Benchmark_TryParse"></a>TryParse

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 39,018 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">292,677 ns</td><td align="right" bgcolor="#FFFFFF">289,355 ns</td><td align="right" bgcolor="#FFFFFF">328,373 ns</td><td align="right" bgcolor="#FFFFFF">323,543 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,289 μs</td><td align="right" bgcolor="#FFFFFF">0,328 μs</td><td align="right" bgcolor="#FFFFFF">0,324 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase"></a>TryParse_IgnoreCase

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 46,592 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">290,622 ns</td><td align="right" bgcolor="#FFFFFF">295,022 ns</td><td align="right" bgcolor="#FFFFFF">324,988 ns</td><td align="right" bgcolor="#FFFFFF">337,213 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,291 μs</td><td align="right" bgcolor="#FFFFFF">0,295 μs</td><td align="right" bgcolor="#FFFFFF">0,325 μs</td><td align="right" bgcolor="#FFFFFF">0,337 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_IgnoreCase_Nullable"></a>TryParse_IgnoreCase_Nullable

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 30,500 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">300,727 ns</td><td align="right" bgcolor="#FFFFFF">288,300 ns</td><td align="right" bgcolor="#FFFFFF">318,800 ns</td><td align="right" bgcolor="#FFFFFF">316,648 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,301 μs</td><td align="right" bgcolor="#FFFFFF">0,288 μs</td><td align="right" bgcolor="#FFFFFF">0,319 μs</td><td align="right" bgcolor="#FFFFFF">0,317 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Enum_Benchmark_TryParse_Nullable"></a>TryParse_Nullable

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 101,075 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">385,918 ns</td><td align="right" bgcolor="#FFFFFF">284,843 ns</td><td align="right" bgcolor="#FFFFFF">315,432 ns</td><td align="right" bgcolor="#FFFFFF">323,930 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,386 μs</td><td align="right" bgcolor="#FFFFFF">0,285 μs</td><td align="right" bgcolor="#FFFFFF">0,315 μs</td><td align="right" bgcolor="#FFFFFF">0,324 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -58,000)</td><td align="right" bgcolor="#FFFFFF">57,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,057)</td><td align="right" bgcolor="#FFFFFF">0,056</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ExpressionHelper_Benchmark"></a>ExpressionHelper_Benchmark

### <a name="ExpressionHelper_Benchmark_GetOwner"></a>GetOwner

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 177,045 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1880,965 ns</td><td align="right" bgcolor="#FFFFFF">1818,753 ns</td><td align="right" bgcolor="#FFFFFF">1843,226 ns</td><td align="right" bgcolor="#FFFFFF">1703,920 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,881 μs</td><td align="right" bgcolor="#FFFFFF">1,819 μs</td><td align="right" bgcolor="#FFFFFF">1,843 μs</td><td align="right" bgcolor="#FFFFFF">1,704 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#A8D08D">336,000 (Δ = -315,000)</td><td align="right" bgcolor="#FFFFFF">336,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#A8D08D">0,328 (Δ = -0,308)</td><td align="right" bgcolor="#FFFFFF">0,328</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ExpressionHelper_Benchmark_GetPropertyName"></a>GetPropertyName

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1432,672 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-29,1 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4915,200 ns</td><td align="right" bgcolor="#A8D08D">3482,528 ns (Δ = -1432,672 ns)</td><td align="right" bgcolor="#FFFFFF">3515,595 ns</td><td align="right" bgcolor="#FFFFFF">3504,825 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,915 μs</td><td align="right" bgcolor="#FFFFFF">3,483 μs</td><td align="right" bgcolor="#FFFFFF">3,516 μs</td><td align="right" bgcolor="#FFFFFF">3,505 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-0,1 %</td><td align="right" bgcolor="#A8D08D">-31,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1987,000</td><td align="right" bgcolor="#A8D08D">1986,000 (Δ = -1,000)</td><td align="right" bgcolor="#A8D08D">1368,000 (Δ = -618,000)</td><td align="right" bgcolor="#FFFFFF">1368,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,940</td><td align="right" bgcolor="#A8D08D">1,939 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">1,336 (Δ = -0,604)</td><td align="right" bgcolor="#FFFFFF">1,336</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="FastDateTime_vs_DateTime_Benchmark"></a>FastDateTime_vs_DateTime_Benchmark

### <a name="FastDateTime_vs_DateTime_Benchmark_DateTime_Now"></a>DateTime_Now

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 513,912 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+186,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">271,408 ns</td><td align="right" bgcolor="#FFFFFF">274,353 ns</td><td align="right" bgcolor="#FF4949">785,320 ns (Δ = +510,967 ns)</td><td align="right" bgcolor="#FFFFFF">784,248 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,271 μs</td><td align="right" bgcolor="#FFFFFF">0,274 μs</td><td align="right" bgcolor="#FFFFFF">0,785 μs</td><td align="right" bgcolor="#FFFFFF">0,784 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="FastDateTime_vs_DateTime_Benchmark_FastDateTime_Now"></a>FastDateTime_Now

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 55,855 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">44,627 ns</td><td align="right" bgcolor="#FFFFFF">45,938 ns</td><td align="right" bgcolor="#FFFFFF">100,392 ns</td><td align="right" bgcolor="#FFFFFF">100,482 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark"></a>FastDateTime_vs_DateTime_UtcNow_Benchmark

### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_DateTime_UtcNow"></a>DateTime_UtcNow

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2,165 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,470 ns</td><td align="right" bgcolor="#FFFFFF">6,305 ns</td><td align="right" bgcolor="#FFFFFF">7,840 ns</td><td align="right" bgcolor="#FFFFFF">6,412 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,006 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="FastDateTime_vs_DateTime_UtcNow_Benchmark_FastDateTime_UtcNow"></a>FastDateTime_UtcNow

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 0,957 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,322 ns</td><td align="right" bgcolor="#FFFFFF">7,480 ns</td><td align="right" bgcolor="#FFFFFF">7,496 ns</td><td align="right" bgcolor="#FFFFFF">8,278 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark"></a>FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark

### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashInsert"></a>FastBindingList_BashInsert

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 425,642 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">885,398 ns</td><td align="right" bgcolor="#FFFFFF">1061,448 ns</td><td align="right" bgcolor="#FFFFFF">1141,417 ns</td><td align="right" bgcolor="#FFFFFF">1311,040 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,885 μs</td><td align="right" bgcolor="#FFFFFF">1,061 μs</td><td align="right" bgcolor="#FFFFFF">1,141 μs</td><td align="right" bgcolor="#FFFFFF">1,311 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,3 %</td><td align="right" bgcolor="#A8D08D">-22,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1136,000</td><td align="right" bgcolor="#FF4949">1230,000 (Δ = +94,000)</td><td align="right" bgcolor="#A8D08D">948,000 (Δ = -282,000)</td><td align="right" bgcolor="#FFFFFF">948,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,109</td><td align="right" bgcolor="#FF4949">1,201 (Δ = +0,092)</td><td align="right" bgcolor="#A8D08D">0,926 (Δ = -0,275)</td><td align="right" bgcolor="#FFFFFF">0,926</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastBindingList_BashRemove"></a>FastBindingList_BashRemove

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 51,542 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">437,320 ns</td><td align="right" bgcolor="#FFFFFF">488,862 ns</td><td align="right" bgcolor="#FFFFFF">463,848 ns</td><td align="right" bgcolor="#FFFFFF">452,498 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,437 μs</td><td align="right" bgcolor="#FFFFFF">0,489 μs</td><td align="right" bgcolor="#FFFFFF">0,464 μs</td><td align="right" bgcolor="#FFFFFF">0,452 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#A8D08D">-21,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">418,000</td><td align="right" bgcolor="#FF4949">459,000 (Δ = +41,000)</td><td align="right" bgcolor="#A8D08D">360,000 (Δ = -99,000)</td><td align="right" bgcolor="#FFFFFF">360,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,408</td><td align="right" bgcolor="#FF4949">0,448 (Δ = +0,040)</td><td align="right" bgcolor="#A8D08D">0,352 (Δ = -0,097)</td><td align="right" bgcolor="#FFFFFF">0,352</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_FastObservableCollection_BashInsert"></a>FastObservableCollection_BashInsert

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 268,658 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2282,823 ns</td><td align="right" bgcolor="#FFFFFF">2410,857 ns</td><td align="right" bgcolor="#A8D08D">2142,198 ns (Δ = -268,658 ns)</td><td align="right" bgcolor="#FFFFFF">2172,615 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,283 μs</td><td align="right" bgcolor="#FFFFFF">2,411 μs</td><td align="right" bgcolor="#FFFFFF">2,142 μs</td><td align="right" bgcolor="#FFFFFF">2,173 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+2,4 %</td><td align="right" bgcolor="#A8D08D">-43,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4126,000</td><td align="right" bgcolor="#FF4949">4225,000 (Δ = +99,000)</td><td align="right" bgcolor="#A8D08D">2402,000 (Δ = -1823,000)</td><td align="right" bgcolor="#FFFFFF">2402,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">4,029</td><td align="right" bgcolor="#FF4949">4,126 (Δ = +0,097)</td><td align="right" bgcolor="#A8D08D">2,346 (Δ = -1,780)</td><td align="right" bgcolor="#FFFFFF">2,346</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FF4949">0,004 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,002)</td><td align="right" bgcolor="#FFFFFF">0,002</td></tr></table>


### <a name="FastObservableCollectionVsObservableCollectionVsFastBindingListBenchmark_ObservableCollection_BashInsert"></a>ObservableCollection_BashInsert

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 49,502 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">927,827 ns</td><td align="right" bgcolor="#FFFFFF">933,702 ns</td><td align="right" bgcolor="#FFFFFF">884,793 ns</td><td align="right" bgcolor="#FFFFFF">884,200 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,928 μs</td><td align="right" bgcolor="#FFFFFF">0,934 μs</td><td align="right" bgcolor="#FFFFFF">0,885 μs</td><td align="right" bgcolor="#FFFFFF">0,884 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">2017,000</td><td align="right" bgcolor="#FFFFFF">2017,000</td><td align="right" bgcolor="#A8D08D">1153,000 (Δ = -864,000)</td><td align="right" bgcolor="#FFFFFF">1153,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,970</td><td align="right" bgcolor="#FFFFFF">1,970</td><td align="right" bgcolor="#A8D08D">1,126 (Δ = -0,844)</td><td align="right" bgcolor="#FFFFFF">1,126</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="HashHelper_Benchmark"></a>HashHelper_Benchmark

### <a name="HashHelper_Benchmark_HashHelper"></a>HashHelper

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 8,315 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">22,158 ns</td><td align="right" bgcolor="#FFFFFF">20,177 ns</td><td align="right" bgcolor="#FFFFFF">28,492 ns</td><td align="right" bgcolor="#FFFFFF">28,067 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,022 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-19,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#FFFFFF">66,000</td><td align="right" bgcolor="#A8D08D">53,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">53,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#FFFFFF">0,064</td><td align="right" bgcolor="#A8D08D">0,052 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,052</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="LanguageHelper_Benchmark"></a>LanguageHelper_Benchmark

### <a name="LanguageHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 160,123 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">562,768 ns</td><td align="right" bgcolor="#FFFFFF">402,645 ns</td><td align="right" bgcolor="#FFFFFF">444,447 ns</td><td align="right" bgcolor="#FFFFFF">448,755 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,563 μs</td><td align="right" bgcolor="#FFFFFF">0,403 μs</td><td align="right" bgcolor="#FFFFFF">0,444 μs</td><td align="right" bgcolor="#FFFFFF">0,449 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#A8D08D">131,000 (Δ = -127,000)</td><td align="right" bgcolor="#FFFFFF">131,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#A8D08D">0,128 (Δ = -0,124)</td><td align="right" bgcolor="#FFFFFF">0,128</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Debug_Benchmark"></a>Log_Debug_Benchmark

### <a name="Log_Debug_Benchmark_Log_Debug_Format_1_Format_Argument"></a>Log_Debug_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 343,862 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">601,242 ns</td><td align="right" bgcolor="#FFFFFF">585,877 ns</td><td align="right" bgcolor="#FFFFFF">686,467 ns</td><td align="right" bgcolor="#FFFFFF">929,738 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,601 μs</td><td align="right" bgcolor="#FFFFFF">0,586 μs</td><td align="right" bgcolor="#FFFFFF">0,686 μs</td><td align="right" bgcolor="#FFFFFF">0,930 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#A8D08D">-33,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">340,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">225,000 (Δ = -115,000)</td><td align="right" bgcolor="#FFFFFF">225,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,332 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,220 (Δ = -0,112)</td><td align="right" bgcolor="#FFFFFF">0,220</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_2_Format_Arguments"></a>Log_Debug_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 112,048 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">747,712 ns</td><td align="right" bgcolor="#FFFFFF">697,963 ns</td><td align="right" bgcolor="#FFFFFF">808,720 ns</td><td align="right" bgcolor="#FFFFFF">810,011 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,748 μs</td><td align="right" bgcolor="#FFFFFF">0,698 μs</td><td align="right" bgcolor="#FFFFFF">0,809 μs</td><td align="right" bgcolor="#FFFFFF">0,810 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_3_Format_Arguments"></a>Log_Debug_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 440,278 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+35,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">891,430 ns</td><td align="right" bgcolor="#FFFFFF">833,225 ns</td><td align="right" bgcolor="#FFFFFF">942,612 ns</td><td align="right" bgcolor="#FF4949">1273,503 ns (Δ = +330,892 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,891 μs</td><td align="right" bgcolor="#FFFFFF">0,833 μs</td><td align="right" bgcolor="#FFFFFF">0,943 μs</td><td align="right" bgcolor="#FFFFFF">1,274 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,292</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_4_Format_Arguments"></a>Log_Debug_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 158,327 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1036,800 ns</td><td align="right" bgcolor="#FFFFFF">1005,218 ns</td><td align="right" bgcolor="#FFFFFF">1111,515 ns</td><td align="right" bgcolor="#FFFFFF">1163,545 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,037 μs</td><td align="right" bgcolor="#FFFFFF">1,005 μs</td><td align="right" bgcolor="#FFFFFF">1,112 μs</td><td align="right" bgcolor="#FFFFFF">1,164 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_5_Format_Arguments"></a>Log_Debug_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 135,108 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1168,348 ns</td><td align="right" bgcolor="#FFFFFF">1161,635 ns</td><td align="right" bgcolor="#FFFFFF">1294,207 ns</td><td align="right" bgcolor="#FFFFFF">1296,743 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,168 μs</td><td align="right" bgcolor="#FFFFFF">1,162 μs</td><td align="right" bgcolor="#FFFFFF">1,294 μs</td><td align="right" bgcolor="#FFFFFF">1,297 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_6_Format_Arguments"></a>Log_Debug_Format_6_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 449,042 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1399,383 ns</td><td align="right" bgcolor="#FFFFFF">1368,047 ns</td><td align="right" bgcolor="#FFFFFF">1524,288 ns</td><td align="right" bgcolor="#FF4949">1817,088 ns (Δ = +292,800 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,399 μs</td><td align="right" bgcolor="#FFFFFF">1,368 μs</td><td align="right" bgcolor="#FFFFFF">1,524 μs</td><td align="right" bgcolor="#FFFFFF">1,817 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Debug_Benchmark_Log_Debug_Format_7_Format_Arguments"></a>Log_Debug_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 235,583 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1439,362 ns</td><td align="right" bgcolor="#FFFFFF">1508,250 ns</td><td align="right" bgcolor="#FFFFFF">1674,391 ns</td><td align="right" bgcolor="#FFFFFF">1674,945 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,439 μs</td><td align="right" bgcolor="#FFFFFF">1,508 μs</td><td align="right" bgcolor="#FFFFFF">1,674 μs</td><td align="right" bgcolor="#FFFFFF">1,675 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Disabled_Benchmark"></a>Log_Disabled_Benchmark

### <a name="Log_Disabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 4,535 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5,308 ns</td><td align="right" bgcolor="#FFFFFF">5,335 ns</td><td align="right" bgcolor="#FFFFFF">0,800 ns</td><td align="right" bgcolor="#FFFFFF">1,312 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 6,717 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">19,882 ns</td><td align="right" bgcolor="#FFFFFF">19,042 ns</td><td align="right" bgcolor="#FFFFFF">13,165 ns</td><td align="right" bgcolor="#FFFFFF">14,153 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,019 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#FFFFFF">57,000</td><td align="right" bgcolor="#A8D08D">29,000 (Δ = -28,000)</td><td align="right" bgcolor="#FFFFFF">29,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#FFFFFF">0,056</td><td align="right" bgcolor="#A8D08D">0,028 (Δ = -0,027)</td><td align="right" bgcolor="#FFFFFF">0,028</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Disabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 6,048 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,555 ns</td><td align="right" bgcolor="#FFFFFF">15,663 ns</td><td align="right" bgcolor="#FFFFFF">9,615 ns</td><td align="right" bgcolor="#FFFFFF">10,950 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Enabled_Benchmark"></a>Log_Enabled_Benchmark

### <a name="Log_Enabled_Benchmark_Log_Info"></a>Log_Info

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 114,348 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">286,042 ns</td><td align="right" bgcolor="#FFFFFF">271,308 ns</td><td align="right" bgcolor="#FFFFFF">385,657 ns</td><td align="right" bgcolor="#FFFFFF">348,245 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,286 μs</td><td align="right" bgcolor="#FFFFFF">0,271 μs</td><td align="right" bgcolor="#FFFFFF">0,386 μs</td><td align="right" bgcolor="#FFFFFF">0,348 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,0 %</td><td align="right" bgcolor="#A8D08D">-37,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">193,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -62,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,188</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,061)</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithBoxing"></a>Log_Info_Format_WithBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 108,455 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">598,858 ns</td><td align="right" bgcolor="#FFFFFF">592,687 ns</td><td align="right" bgcolor="#FFFFFF">678,032 ns</td><td align="right" bgcolor="#FFFFFF">701,142 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,599 μs</td><td align="right" bgcolor="#FFFFFF">0,593 μs</td><td align="right" bgcolor="#FFFFFF">0,678 μs</td><td align="right" bgcolor="#FFFFFF">0,701 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">-32,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">385,000</td><td align="right" bgcolor="#A8D08D">352,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">238,000 (Δ = -114,000)</td><td align="right" bgcolor="#FFFFFF">238,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,376</td><td align="right" bgcolor="#A8D08D">0,344 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,232 (Δ = -0,111)</td><td align="right" bgcolor="#FFFFFF">0,232</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Enabled_Benchmark_Log_Info_Format_WithoutBoxing"></a>Log_Info_Format_WithoutBoxing

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 170,352 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">515,132 ns</td><td align="right" bgcolor="#FFFFFF">501,847 ns</td><td align="right" bgcolor="#FFFFFF">649,650 ns</td><td align="right" bgcolor="#FFFFFF">672,198 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,515 μs</td><td align="right" bgcolor="#FFFFFF">0,502 μs</td><td align="right" bgcolor="#FFFFFF">0,650 μs</td><td align="right" bgcolor="#FFFFFF">0,672 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,8 %</td><td align="right" bgcolor="#A8D08D">-26,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">377,000</td><td align="right" bgcolor="#A8D08D">344,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -90,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,368</td><td align="right" bgcolor="#A8D08D">0,336 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,088)</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Error_Benchmark"></a>Log_Error_Benchmark

### <a name="Log_Error_Benchmark_Log_Error_Format_1_Format_Argument"></a>Log_Error_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 114,895 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">607,810 ns</td><td align="right" bgcolor="#FFFFFF">549,583 ns</td><td align="right" bgcolor="#FFFFFF">644,973 ns</td><td align="right" bgcolor="#FFFFFF">664,478 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,608 μs</td><td align="right" bgcolor="#FFFFFF">0,550 μs</td><td align="right" bgcolor="#FFFFFF">0,645 μs</td><td align="right" bgcolor="#FFFFFF">0,664 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">209,000 (Δ = -98,000)</td><td align="right" bgcolor="#FFFFFF">209,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,204 (Δ = -0,096)</td><td align="right" bgcolor="#FFFFFF">0,204</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_2_Format_Arguments"></a>Log_Error_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 114,690 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">738,840 ns</td><td align="right" bgcolor="#FFFFFF">698,085 ns</td><td align="right" bgcolor="#FFFFFF">812,775 ns</td><td align="right" bgcolor="#FFFFFF">808,553 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,739 μs</td><td align="right" bgcolor="#FFFFFF">0,698 μs</td><td align="right" bgcolor="#FFFFFF">0,813 μs</td><td align="right" bgcolor="#FFFFFF">0,809 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_3_Format_Arguments"></a>Log_Error_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 134,657 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">885,388 ns</td><td align="right" bgcolor="#FFFFFF">837,620 ns</td><td align="right" bgcolor="#FFFFFF">961,827 ns</td><td align="right" bgcolor="#FFFFFF">972,277 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,885 μs</td><td align="right" bgcolor="#FFFFFF">0,838 μs</td><td align="right" bgcolor="#FFFFFF">0,962 μs</td><td align="right" bgcolor="#FFFFFF">0,972 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,292</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_4_Format_Arguments"></a>Log_Error_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 236,312 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1026,127 ns</td><td align="right" bgcolor="#FFFFFF">1011,703 ns</td><td align="right" bgcolor="#FFFFFF">1110,478 ns</td><td align="right" bgcolor="#FFFFFF">1248,015 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,026 μs</td><td align="right" bgcolor="#FFFFFF">1,012 μs</td><td align="right" bgcolor="#FFFFFF">1,110 μs</td><td align="right" bgcolor="#FFFFFF">1,248 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_5_Format_Arguments"></a>Log_Error_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 140,268 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1172,700 ns</td><td align="right" bgcolor="#FFFFFF">1148,660 ns</td><td align="right" bgcolor="#FFFFFF">1277,832 ns</td><td align="right" bgcolor="#FFFFFF">1288,928 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,173 μs</td><td align="right" bgcolor="#FFFFFF">1,149 μs</td><td align="right" bgcolor="#FFFFFF">1,278 μs</td><td align="right" bgcolor="#FFFFFF">1,289 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_6_Format_Arguments"></a>Log_Error_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 257,942 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1310,273 ns</td><td align="right" bgcolor="#FFFFFF">1357,355 ns</td><td align="right" bgcolor="#FFFFFF">1558,835 ns</td><td align="right" bgcolor="#FFFFFF">1568,215 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,310 μs</td><td align="right" bgcolor="#FFFFFF">1,357 μs</td><td align="right" bgcolor="#FFFFFF">1,559 μs</td><td align="right" bgcolor="#FFFFFF">1,568 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Error_Benchmark_Log_Error_Format_7_Format_Arguments"></a>Log_Error_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 249,148 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1437,342 ns</td><td align="right" bgcolor="#FFFFFF">1487,097 ns</td><td align="right" bgcolor="#FFFFFF">1686,490 ns</td><td align="right" bgcolor="#FFFFFF">1662,590 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,437 μs</td><td align="right" bgcolor="#FFFFFF">1,487 μs</td><td align="right" bgcolor="#FFFFFF">1,686 μs</td><td align="right" bgcolor="#FFFFFF">1,663 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Info_Benchmark"></a>Log_Info_Benchmark

### <a name="Log_Info_Benchmark_Log_Info_Format_1_Format_Argument"></a>Log_Info_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 103,645 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">596,453 ns</td><td align="right" bgcolor="#FFFFFF">586,257 ns</td><td align="right" bgcolor="#FFFFFF">678,130 ns</td><td align="right" bgcolor="#FFFFFF">689,902 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,596 μs</td><td align="right" bgcolor="#FFFFFF">0,586 μs</td><td align="right" bgcolor="#FFFFFF">0,678 μs</td><td align="right" bgcolor="#FFFFFF">0,690 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,9 %</td><td align="right" bgcolor="#A8D08D">-33,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">340,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">225,000 (Δ = -115,000)</td><td align="right" bgcolor="#FFFFFF">225,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,332 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,220 (Δ = -0,112)</td><td align="right" bgcolor="#FFFFFF">0,220</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_2_Format_Arguments"></a>Log_Info_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 135,428 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">738,518 ns</td><td align="right" bgcolor="#FFFFFF">728,928 ns</td><td align="right" bgcolor="#FFFFFF">852,243 ns</td><td align="right" bgcolor="#FFFFFF">864,357 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,739 μs</td><td align="right" bgcolor="#FFFFFF">0,729 μs</td><td align="right" bgcolor="#FFFFFF">0,852 μs</td><td align="right" bgcolor="#FFFFFF">0,864 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-7,3 %</td><td align="right" bgcolor="#A8D08D">-34,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">274,000 (Δ = -144,000)</td><td align="right" bgcolor="#FFFFFF">274,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,268 (Δ = -0,141)</td><td align="right" bgcolor="#FFFFFF">0,268</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_3_Format_Arguments"></a>Log_Info_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 134,102 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">889,602 ns</td><td align="right" bgcolor="#FFFFFF">870,573 ns</td><td align="right" bgcolor="#FFFFFF">1004,675 ns</td><td align="right" bgcolor="#FFFFFF">987,400 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,890 μs</td><td align="right" bgcolor="#FFFFFF">0,871 μs</td><td align="right" bgcolor="#FFFFFF">1,005 μs</td><td align="right" bgcolor="#FFFFFF">0,987 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,3 %</td><td align="right" bgcolor="#A8D08D">-35,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">500,000 (Δ = -28,000)</td><td align="right" bgcolor="#A8D08D">324,000 (Δ = -176,000)</td><td align="right" bgcolor="#FFFFFF">324,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,488 (Δ = -0,027)</td><td align="right" bgcolor="#A8D08D">0,316 (Δ = -0,172)</td><td align="right" bgcolor="#FFFFFF">0,316</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_4_Format_Arguments"></a>Log_Info_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 116,477 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1027,640 ns</td><td align="right" bgcolor="#FFFFFF">1025,283 ns</td><td align="right" bgcolor="#FFFFFF">1112,252 ns</td><td align="right" bgcolor="#FFFFFF">1141,760 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,028 μs</td><td align="right" bgcolor="#FFFFFF">1,025 μs</td><td align="right" bgcolor="#FFFFFF">1,112 μs</td><td align="right" bgcolor="#FFFFFF">1,142 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_5_Format_Arguments"></a>Log_Info_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 96,538 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1176,463 ns</td><td align="right" bgcolor="#FFFFFF">1162,073 ns</td><td align="right" bgcolor="#FFFFFF">1248,593 ns</td><td align="right" bgcolor="#FFFFFF">1258,612 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,176 μs</td><td align="right" bgcolor="#FFFFFF">1,162 μs</td><td align="right" bgcolor="#FFFFFF">1,249 μs</td><td align="right" bgcolor="#FFFFFF">1,259 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_6_Format_Arguments"></a>Log_Info_Format_6_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 253,763 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1307,478 ns</td><td align="right" bgcolor="#FFFFFF">1295,250 ns</td><td align="right" bgcolor="#FFFFFF">1425,683 ns</td><td align="right" bgcolor="#FFFFFF">1549,013 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,307 μs</td><td align="right" bgcolor="#FFFFFF">1,295 μs</td><td align="right" bgcolor="#FFFFFF">1,426 μs</td><td align="right" bgcolor="#FFFFFF">1,549 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#A8D08D">737,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">467,000 (Δ = -270,000)</td><td align="right" bgcolor="#FFFFFF">467,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#A8D08D">0,720 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,456 (Δ = -0,264)</td><td align="right" bgcolor="#FFFFFF">0,456</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Info_Benchmark_Log_Info_Format_7_Format_Arguments"></a>Log_Info_Format_7_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 161,227 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1449,468 ns</td><td align="right" bgcolor="#FFFFFF">1443,108 ns</td><td align="right" bgcolor="#FFFFFF">1604,335 ns</td><td align="right" bgcolor="#FFFFFF">1536,810 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,449 μs</td><td align="right" bgcolor="#FFFFFF">1,443 μs</td><td align="right" bgcolor="#FFFFFF">1,604 μs</td><td align="right" bgcolor="#FFFFFF">1,537 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#A8D08D">-37,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#A8D08D">819,000 (Δ = -33,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -303,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#A8D08D">0,800 (Δ = -0,032)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,296)</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Log_Status_Benchmark"></a>Log_Status_Benchmark

### <a name="Log_Status_Benchmark_Log_Status_Format_1_Format_Argument"></a>Log_Status_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 96,448 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">594,140 ns</td><td align="right" bgcolor="#FFFFFF">569,995 ns</td><td align="right" bgcolor="#FFFFFF">657,418 ns</td><td align="right" bgcolor="#FFFFFF">666,443 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,594 μs</td><td align="right" bgcolor="#FFFFFF">0,570 μs</td><td align="right" bgcolor="#FFFFFF">0,657 μs</td><td align="right" bgcolor="#FFFFFF">0,666 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">209,000 (Δ = -98,000)</td><td align="right" bgcolor="#FFFFFF">209,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,204 (Δ = -0,096)</td><td align="right" bgcolor="#FFFFFF">0,204</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_2_Format_Arguments"></a>Log_Status_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 172,883 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">737,417 ns</td><td align="right" bgcolor="#FFFFFF">706,413 ns</td><td align="right" bgcolor="#FFFFFF">815,120 ns</td><td align="right" bgcolor="#FFFFFF">879,297 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,737 μs</td><td align="right" bgcolor="#FFFFFF">0,706 μs</td><td align="right" bgcolor="#FFFFFF">0,815 μs</td><td align="right" bgcolor="#FFFFFF">0,879 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_3_Format_Arguments"></a>Log_Status_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 165,085 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">982,267 ns</td><td align="right" bgcolor="#FFFFFF">835,860 ns</td><td align="right" bgcolor="#FFFFFF">971,772 ns</td><td align="right" bgcolor="#FFFFFF">1000,945 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,982 μs</td><td align="right" bgcolor="#FFFFFF">0,836 μs</td><td align="right" bgcolor="#FFFFFF">0,972 μs</td><td align="right" bgcolor="#FFFFFF">1,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,292</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_4_Format_Arguments"></a>Log_Status_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 124,458 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1030,933 ns</td><td align="right" bgcolor="#FFFFFF">1024,288 ns</td><td align="right" bgcolor="#FFFFFF">1140,085 ns</td><td align="right" bgcolor="#FFFFFF">1148,747 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,031 μs</td><td align="right" bgcolor="#FFFFFF">1,024 μs</td><td align="right" bgcolor="#FFFFFF">1,140 μs</td><td align="right" bgcolor="#FFFFFF">1,149 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_5_Format_Arguments"></a>Log_Status_Format_5_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 129,968 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1179,448 ns</td><td align="right" bgcolor="#FFFFFF">1191,993 ns</td><td align="right" bgcolor="#FFFFFF">1255,107 ns</td><td align="right" bgcolor="#FFFFFF">1309,417 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,179 μs</td><td align="right" bgcolor="#FFFFFF">1,192 μs</td><td align="right" bgcolor="#FFFFFF">1,255 μs</td><td align="right" bgcolor="#FFFFFF">1,309 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_6_Format_Arguments"></a>Log_Status_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 279,087 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1306,973 ns</td><td align="right" bgcolor="#FFFFFF">1382,847 ns</td><td align="right" bgcolor="#FFFFFF">1532,627 ns</td><td align="right" bgcolor="#FFFFFF">1586,060 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,307 μs</td><td align="right" bgcolor="#FFFFFF">1,383 μs</td><td align="right" bgcolor="#FFFFFF">1,533 μs</td><td align="right" bgcolor="#FFFFFF">1,586 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Status_Benchmark_Log_Status_Format_7_Format_Arguments"></a>Log_Status_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 235,199 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1439,423 ns</td><td align="right" bgcolor="#FFFFFF">1514,205 ns</td><td align="right" bgcolor="#FFFFFF">1653,053 ns</td><td align="right" bgcolor="#FFFFFF">1674,623 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,439 μs</td><td align="right" bgcolor="#FFFFFF">1,514 μs</td><td align="right" bgcolor="#FFFFFF">1,653 μs</td><td align="right" bgcolor="#FFFFFF">1,675 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="Log_Warning_Benchmark"></a>Log_Warning_Benchmark

### <a name="Log_Warning_Benchmark_Log_Warning_Format_1_Format_Argument"></a>Log_Warning_Format_1_Format_Argument

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 93,982 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">601,790 ns</td><td align="right" bgcolor="#FFFFFF">587,570 ns</td><td align="right" bgcolor="#FFFFFF">640,227 ns</td><td align="right" bgcolor="#FFFFFF">681,552 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,602 μs</td><td align="right" bgcolor="#FFFFFF">0,588 μs</td><td align="right" bgcolor="#FFFFFF">0,640 μs</td><td align="right" bgcolor="#FFFFFF">0,682 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,8 %</td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">369,000</td><td align="right" bgcolor="#A8D08D">307,000 (Δ = -62,000)</td><td align="right" bgcolor="#A8D08D">209,000 (Δ = -98,000)</td><td align="right" bgcolor="#FFFFFF">209,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,360</td><td align="right" bgcolor="#A8D08D">0,300 (Δ = -0,061)</td><td align="right" bgcolor="#A8D08D">0,204 (Δ = -0,096)</td><td align="right" bgcolor="#FFFFFF">0,204</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_2_Format_Arguments"></a>Log_Warning_Format_2_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 172,532 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">747,305 ns</td><td align="right" bgcolor="#FFFFFF">705,893 ns</td><td align="right" bgcolor="#FFFFFF">815,820 ns</td><td align="right" bgcolor="#FFFFFF">878,425 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,747 μs</td><td align="right" bgcolor="#FFFFFF">0,706 μs</td><td align="right" bgcolor="#FFFFFF">0,816 μs</td><td align="right" bgcolor="#FFFFFF">0,878 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,4 %</td><td align="right" bgcolor="#A8D08D">-32,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">377,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">254,000 (Δ = -123,000)</td><td align="right" bgcolor="#FFFFFF">254,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,368 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,248 (Δ = -0,120)</td><td align="right" bgcolor="#FFFFFF">0,248</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_3_Format_Arguments"></a>Log_Warning_Format_3_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 135,203 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">884,173 ns</td><td align="right" bgcolor="#FFFFFF">835,500 ns</td><td align="right" bgcolor="#FFFFFF">952,217 ns</td><td align="right" bgcolor="#FFFFFF">970,703 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,884 μs</td><td align="right" bgcolor="#FFFFFF">0,836 μs</td><td align="right" bgcolor="#FFFFFF">0,952 μs</td><td align="right" bgcolor="#FFFFFF">0,971 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#A8D08D">-33,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">528,000</td><td align="right" bgcolor="#A8D08D">451,000 (Δ = -77,000)</td><td align="right" bgcolor="#A8D08D">299,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">299,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,516</td><td align="right" bgcolor="#A8D08D">0,440 (Δ = -0,075)</td><td align="right" bgcolor="#A8D08D">0,292 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,292</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_4_Format_Arguments"></a>Log_Warning_Format_4_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 129,792 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1041,343 ns</td><td align="right" bgcolor="#FFFFFF">1022,960 ns</td><td align="right" bgcolor="#FFFFFF">1123,658 ns</td><td align="right" bgcolor="#FFFFFF">1152,752 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,041 μs</td><td align="right" bgcolor="#FFFFFF">1,023 μs</td><td align="right" bgcolor="#FFFFFF">1,124 μs</td><td align="right" bgcolor="#FFFFFF">1,153 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-5,2 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">610,000</td><td align="right" bgcolor="#A8D08D">578,000 (Δ = -32,000)</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -209,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,596</td><td align="right" bgcolor="#A8D08D">0,564 (Δ = -0,031)</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,204)</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_5_Format_Arguments"></a>Log_Warning_Format_5_Format_Arguments

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 145,348 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1169,017 ns</td><td align="right" bgcolor="#FFFFFF">1155,155 ns</td><td align="right" bgcolor="#FFFFFF">1300,503 ns</td><td align="right" bgcolor="#FFFFFF">1271,318 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,169 μs</td><td align="right" bgcolor="#FFFFFF">1,155 μs</td><td align="right" bgcolor="#FFFFFF">1,301 μs</td><td align="right" bgcolor="#FFFFFF">1,271 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,2 %</td><td align="right" bgcolor="#A8D08D">-36,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">688,000</td><td align="right" bgcolor="#A8D08D">659,000 (Δ = -29,000)</td><td align="right" bgcolor="#A8D08D">418,000 (Δ = -241,000)</td><td align="right" bgcolor="#FFFFFF">418,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,672</td><td align="right" bgcolor="#A8D08D">0,644 (Δ = -0,028)</td><td align="right" bgcolor="#A8D08D">0,408 (Δ = -0,235)</td><td align="right" bgcolor="#FFFFFF">0,408</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_6_Format_Arguments"></a>Log_Warning_Format_6_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 288,810 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1311,805 ns</td><td align="right" bgcolor="#FFFFFF">1361,419 ns</td><td align="right" bgcolor="#FFFFFF">1553,495 ns</td><td align="right" bgcolor="#FFFFFF">1600,615 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,312 μs</td><td align="right" bgcolor="#FFFFFF">1,361 μs</td><td align="right" bgcolor="#FFFFFF">1,553 μs</td><td align="right" bgcolor="#FFFFFF">1,601 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#A8D08D">-38,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">770,000</td><td align="right" bgcolor="#FF4949">836,000 (Δ = +66,000)</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -320,000)</td><td align="right" bgcolor="#FFFFFF">516,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,752</td><td align="right" bgcolor="#FF4949">0,816 (Δ = +0,064)</td><td align="right" bgcolor="#A8D08D">0,504 (Δ = -0,313)</td><td align="right" bgcolor="#FFFFFF">0,504</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Log_Warning_Benchmark_Log_Warning_Format_7_Format_Arguments"></a>Log_Warning_Format_7_Format_Arguments

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 241,663 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1433,645 ns</td><td align="right" bgcolor="#FFFFFF">1508,478 ns</td><td align="right" bgcolor="#FFFFFF">1675,308 ns</td><td align="right" bgcolor="#FFFFFF">1656,495 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,434 μs</td><td align="right" bgcolor="#FFFFFF">1,508 μs</td><td align="right" bgcolor="#FFFFFF">1,675 μs</td><td align="right" bgcolor="#FFFFFF">1,656 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,2 %</td><td align="right" bgcolor="#A8D08D">-38,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">852,000</td><td align="right" bgcolor="#FF4949">922,000 (Δ = +70,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -357,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,832</td><td align="right" bgcolor="#FF4949">0,900 (Δ = +0,068)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,349)</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="MemberInfoExtensions_Benchmark"></a>MemberInfoExtensions_Benchmark

### <a name="MemberInfoExtensions_Benchmark_GetSignature_Constructor"></a>GetSignature_Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 90,537 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">303,707 ns</td><td align="right" bgcolor="#FFFFFF">275,157 ns</td><td align="right" bgcolor="#FFFFFF">365,693 ns</td><td align="right" bgcolor="#FFFFFF">301,497 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,304 μs</td><td align="right" bgcolor="#FFFFFF">0,275 μs</td><td align="right" bgcolor="#FFFFFF">0,366 μs</td><td align="right" bgcolor="#FFFFFF">0,301 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#A8D08D">106,000 (Δ = -103,000)</td><td align="right" bgcolor="#FFFFFF">106,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#A8D08D">0,104 (Δ = -0,101)</td><td align="right" bgcolor="#FFFFFF">0,104</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MemberInfoExtensions_Benchmark_GetSignature_Method"></a>GetSignature_Method

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 77,123 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">358,510 ns</td><td align="right" bgcolor="#FFFFFF">299,972 ns</td><td align="right" bgcolor="#FFFFFF">317,907 ns</td><td align="right" bgcolor="#FFFFFF">377,095 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,359 μs</td><td align="right" bgcolor="#FFFFFF">0,300 μs</td><td align="right" bgcolor="#FFFFFF">0,318 μs</td><td align="right" bgcolor="#FFFFFF">0,377 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#FFFFFF">209,000</td><td align="right" bgcolor="#A8D08D">106,000 (Δ = -103,000)</td><td align="right" bgcolor="#FFFFFF">106,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#FFFFFF">0,204</td><td align="right" bgcolor="#A8D08D">0,104 (Δ = -0,101)</td><td align="right" bgcolor="#FFFFFF">0,104</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="MethodInfo_ReflectionExtensions_Benchmark"></a>MethodInfo_ReflectionExtensions_Benchmark

### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 453,418 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3980,688 ns</td><td align="right" bgcolor="#FFFFFF">3908,903 ns</td><td align="right" bgcolor="#FF4949">4362,322 ns (Δ = +453,418 ns)</td><td align="right" bgcolor="#FFFFFF">4314,082 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,981 μs</td><td align="right" bgcolor="#FFFFFF">3,909 μs</td><td align="right" bgcolor="#FFFFFF">4,362 μs</td><td align="right" bgcolor="#FFFFFF">4,314 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#A8D08D">172,000 (Δ = -172,000)</td><td align="right" bgcolor="#FFFFFF">172,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#A8D08D">0,168 (Δ = -0,168)</td><td align="right" bgcolor="#FFFFFF">0,168</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 609,788 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6809,653 ns</td><td align="right" bgcolor="#FFFFFF">6647,508 ns</td><td align="right" bgcolor="#FF4949">7238,567 ns (Δ = +591,058 ns)</td><td align="right" bgcolor="#FFFFFF">7257,297 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,810 μs</td><td align="right" bgcolor="#FFFFFF">6,648 μs</td><td align="right" bgcolor="#FFFFFF">7,239 μs</td><td align="right" bgcolor="#FFFFFF">7,257 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -352,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,344)</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 393,680 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">5257,527 ns</td><td align="right" bgcolor="#FFFFFF">5211,243 ns</td><td align="right" bgcolor="#FF4949">5568,673 ns (Δ = +357,430 ns)</td><td align="right" bgcolor="#FFFFFF">5604,923 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">5,258 μs</td><td align="right" bgcolor="#FFFFFF">5,211 μs</td><td align="right" bgcolor="#FFFFFF">5,569 μs</td><td align="right" bgcolor="#FFFFFF">5,605 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#FFFFFF">676,000</td><td align="right" bgcolor="#A8D08D">348,000 (Δ = -328,000)</td><td align="right" bgcolor="#FFFFFF">348,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#FFFFFF">0,660</td><td align="right" bgcolor="#A8D08D">0,340 (Δ = -0,320)</td><td align="right" bgcolor="#FFFFFF">0,340</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 386,997 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3945,623 ns</td><td align="right" bgcolor="#FFFFFF">3938,688 ns</td><td align="right" bgcolor="#FF4949">4325,685 ns (Δ = +386,997 ns)</td><td align="right" bgcolor="#FFFFFF">4278,188 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,946 μs</td><td align="right" bgcolor="#FFFFFF">3,939 μs</td><td align="right" bgcolor="#FFFFFF">4,326 μs</td><td align="right" bgcolor="#FFFFFF">4,278 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#A8D08D">172,000 (Δ = -172,000)</td><td align="right" bgcolor="#FFFFFF">172,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#A8D08D">0,168 (Δ = -0,168)</td><td align="right" bgcolor="#FFFFFF">0,168</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 640,778 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6807,948 ns</td><td align="right" bgcolor="#FFFFFF">6618,027 ns</td><td align="right" bgcolor="#FF4949">7185,701 ns (Δ = +567,675 ns)</td><td align="right" bgcolor="#FFFFFF">7258,805 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,808 μs</td><td align="right" bgcolor="#FFFFFF">6,618 μs</td><td align="right" bgcolor="#FFFFFF">7,186 μs</td><td align="right" bgcolor="#FFFFFF">7,259 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">369,000 (Δ = -352,000)</td><td align="right" bgcolor="#FFFFFF">369,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,360 (Δ = -0,344)</td><td align="right" bgcolor="#FFFFFF">0,360</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="MethodInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 718,573 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+9,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7780,443 ns</td><td align="right" bgcolor="#FFFFFF">7702,950 ns</td><td align="right" bgcolor="#FF4949">8421,523 ns (Δ = +718,573 ns)</td><td align="right" bgcolor="#FFFFFF">8393,894 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,780 μs</td><td align="right" bgcolor="#FFFFFF">7,703 μs</td><td align="right" bgcolor="#FFFFFF">8,422 μs</td><td align="right" bgcolor="#FFFFFF">8,394 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1090,000</td><td align="right" bgcolor="#FFFFFF">1090,000</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -525,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,064</td><td align="right" bgcolor="#FFFFFF">1,064</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,513)</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ModelBase_Constructor_Benchmark"></a>ModelBase_Constructor_Benchmark

### <a name="ModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 713,558 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-20,6 %</td><td align="right" bgcolor="#FF4949">+17,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3463,287 ns</td><td align="right" bgcolor="#A8D08D">2749,728 ns (Δ = -713,558 ns)</td><td align="right" bgcolor="#FF4949">3222,990 ns (Δ = +473,262 ns)</td><td align="right" bgcolor="#FFFFFF">3354,793 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,463 μs</td><td align="right" bgcolor="#FFFFFF">2,750 μs</td><td align="right" bgcolor="#FFFFFF">3,223 μs</td><td align="right" bgcolor="#FFFFFF">3,355 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,5 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1720,000</td><td align="right" bgcolor="#A8D08D">971,000 (Δ = -749,000)</td><td align="right" bgcolor="#A8D08D">553,000 (Δ = -418,000)</td><td align="right" bgcolor="#FFFFFF">553,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,680</td><td align="right" bgcolor="#A8D08D">0,948 (Δ = -0,731)</td><td align="right" bgcolor="#A8D08D">0,540 (Δ = -0,408)</td><td align="right" bgcolor="#FFFFFF">0,540</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ModelBase_EqualityComparer_Benchmark"></a>ModelBase_EqualityComparer_Benchmark

### <a name="ModelBase_EqualityComparer_Benchmark_EqualityComparer"></a>EqualityComparer

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 585,842 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-17,0 %</td><td align="right" bgcolor="#FF4949">+17,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3447,343 ns</td><td align="right" bgcolor="#A8D08D">2861,502 ns (Δ = -585,842 ns)</td><td align="right" bgcolor="#FF4949">3353,883 ns (Δ = +492,382 ns)</td><td align="right" bgcolor="#FFFFFF">3195,827 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,447 μs</td><td align="right" bgcolor="#FFFFFF">2,862 μs</td><td align="right" bgcolor="#FFFFFF">3,354 μs</td><td align="right" bgcolor="#FFFFFF">3,196 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,5 %</td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1720,000</td><td align="right" bgcolor="#A8D08D">971,000 (Δ = -749,000)</td><td align="right" bgcolor="#A8D08D">553,000 (Δ = -418,000)</td><td align="right" bgcolor="#FFFFFF">553,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,680</td><td align="right" bgcolor="#A8D08D">0,948 (Δ = -0,731)</td><td align="right" bgcolor="#A8D08D">0,540 (Δ = -0,408)</td><td align="right" bgcolor="#FFFFFF">0,540</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ModelBase_EqualityComparer_Benchmark_GetHashCode_"></a>GetHashCode_

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1511,308 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-35,2 %</td><td align="right" bgcolor="#FF4949">+20,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4295,402 ns</td><td align="right" bgcolor="#A8D08D">2784,093 ns (Δ = -1511,308 ns)</td><td align="right" bgcolor="#FF4949">3365,097 ns (Δ = +581,003 ns)</td><td align="right" bgcolor="#FFFFFF">3191,980 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,295 μs</td><td align="right" bgcolor="#FFFFFF">2,784 μs</td><td align="right" bgcolor="#FFFFFF">3,365 μs</td><td align="right" bgcolor="#FFFFFF">3,192 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,3 %</td><td align="right" bgcolor="#A8D08D">-43,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1888,000</td><td align="right" bgcolor="#A8D08D">995,000 (Δ = -893,000)</td><td align="right" bgcolor="#A8D08D">565,000 (Δ = -430,000)</td><td align="right" bgcolor="#FFFFFF">565,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,844</td><td align="right" bgcolor="#A8D08D">0,972 (Δ = -0,872)</td><td align="right" bgcolor="#A8D08D">0,552 (Δ = -0,420)</td><td align="right" bgcolor="#FFFFFF">0,552</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ModelBase_GetValue_Benchmark"></a>ModelBase_GetValue_Benchmark

### <a name="ModelBase_GetValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 22,903 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">122,435 ns</td><td align="right" bgcolor="#FFFFFF">139,323 ns</td><td align="right" bgcolor="#FFFFFF">144,178 ns</td><td align="right" bgcolor="#FFFFFF">145,338 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ModelBase_GetValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 38,563 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">121,338 ns</td><td align="right" bgcolor="#FFFFFF">159,902 ns</td><td align="right" bgcolor="#FFFFFF">145,262 ns</td><td align="right" bgcolor="#FFFFFF">142,298 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,160 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ModelBase_GetValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 21,002 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">117,383 ns</td><td align="right" bgcolor="#FFFFFF">132,283 ns</td><td align="right" bgcolor="#FFFFFF">137,622 ns</td><td align="right" bgcolor="#FFFFFF">138,385 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,117 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ModelBase_SetValue_Benchmark"></a>ModelBase_SetValue_Benchmark

### <a name="ModelBase_SetValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1280,503 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-75,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1707,903 ns</td><td align="right" bgcolor="#A8D08D">427,400 ns (Δ = -1280,503 ns)</td><td align="right" bgcolor="#FFFFFF">500,255 ns</td><td align="right" bgcolor="#FFFFFF">476,283 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,708 μs</td><td align="right" bgcolor="#FFFFFF">0,427 μs</td><td align="right" bgcolor="#FFFFFF">0,500 μs</td><td align="right" bgcolor="#FFFFFF">0,476 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-86,9 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">627,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">41,000 (Δ = -41,000)</td><td align="right" bgcolor="#FFFFFF">41,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,612</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,040 (Δ = -0,040)</td><td align="right" bgcolor="#FFFFFF">0,040</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1312,108 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-74,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1762,272 ns</td><td align="right" bgcolor="#A8D08D">450,163 ns (Δ = -1312,108 ns)</td><td align="right" bgcolor="#FFFFFF">517,588 ns</td><td align="right" bgcolor="#FFFFFF">510,605 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,762 μs</td><td align="right" bgcolor="#FFFFFF">0,450 μs</td><td align="right" bgcolor="#FFFFFF">0,518 μs</td><td align="right" bgcolor="#FFFFFF">0,511 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-86,9 %</td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">627,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">41,000 (Δ = -41,000)</td><td align="right" bgcolor="#FFFFFF">41,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,612</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,040 (Δ = -0,040)</td><td align="right" bgcolor="#FFFFFF">0,040</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ModelBase_SetValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 1238,695 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,6 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1575,373 ns</td><td align="right" bgcolor="#A8D08D">336,678 ns (Δ = -1238,695 ns)</td><td align="right" bgcolor="#FFFFFF">362,643 ns</td><td align="right" bgcolor="#FFFFFF">349,820 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,575 μs</td><td align="right" bgcolor="#FFFFFF">0,337 μs</td><td align="right" bgcolor="#FFFFFF">0,363 μs</td><td align="right" bgcolor="#FFFFFF">0,350 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-90,5 %</td><td align="right" bgcolor="#A8D08D">-49,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">602,000</td><td align="right" bgcolor="#A8D08D">57,000 (Δ = -545,000)</td><td align="right" bgcolor="#A8D08D">29,000 (Δ = -28,000)</td><td align="right" bgcolor="#FFFFFF">29,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,588</td><td align="right" bgcolor="#A8D08D">0,056 (Δ = -0,532)</td><td align="right" bgcolor="#A8D08D">0,028 (Δ = -0,027)</td><td align="right" bgcolor="#FFFFFF">0,028</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ObjectHelper_Benchmark"></a>ObjectHelper_Benchmark

### <a name="ObjectHelper_Benchmark_AreEqual__Same_Reference"></a>AreEqual__Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 1,678 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3,327 ns</td><td align="right" bgcolor="#FFFFFF">2,223 ns</td><td align="right" bgcolor="#FFFFFF">3,132 ns</td><td align="right" bgcolor="#FFFFFF">3,902 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectHelper_Benchmark_AreEqual_Both_Null"></a>AreEqual_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,190 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,247 ns</td><td align="right" bgcolor="#FFFFFF">2,228 ns</td><td align="right" bgcolor="#FFFFFF">2,418 ns</td><td align="right" bgcolor="#FFFFFF">2,292 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectHelper_Benchmark_AreEqual_Not_Same_Reference"></a>AreEqual_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 5,398 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,605 ns</td><td align="right" bgcolor="#FFFFFF">7,890 ns</td><td align="right" bgcolor="#FFFFFF">12,728 ns</td><td align="right" bgcolor="#FFFFFF">13,288 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectHelper_Benchmark_AreEqual_One_Null"></a>AreEqual_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 4,763 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,007 ns</td><td align="right" bgcolor="#FFFFFF">2,243 ns</td><td align="right" bgcolor="#FFFFFF">2,570 ns</td><td align="right" bgcolor="#FFFFFF">2,815 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectHelper_Benchmark_AreEqual_Strings"></a>AreEqual_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 3,633 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,913 ns</td><td align="right" bgcolor="#FFFFFF">8,563 ns</td><td align="right" bgcolor="#FFFFFF">12,197 ns</td><td align="right" bgcolor="#FFFFFF">11,990 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Both_Null"></a>AreEqualReferences_Both_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,485 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,578 ns</td><td align="right" bgcolor="#FFFFFF">2,360 ns</td><td align="right" bgcolor="#FFFFFF">2,845 ns</td><td align="right" bgcolor="#FFFFFF">2,480 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Not_Same_Reference"></a>AreEqualReferences_Not_Same_Reference

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 14,534 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">49,813 ns</td><td align="right" bgcolor="#FFFFFF">47,717 ns</td><td align="right" bgcolor="#FFFFFF">58,998 ns</td><td align="right" bgcolor="#FFFFFF">62,251 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,050 μs</td><td align="right" bgcolor="#FFFFFF">0,048 μs</td><td align="right" bgcolor="#FFFFFF">0,059 μs</td><td align="right" bgcolor="#FFFFFF">0,062 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectHelper_Benchmark_AreEqualReferences_One_Null"></a>AreEqualReferences_One_Null

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 0,637 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,548 ns</td><td align="right" bgcolor="#FFFFFF">2,542 ns</td><td align="right" bgcolor="#FFFFFF">3,178 ns</td><td align="right" bgcolor="#FFFFFF">3,163 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Same_Reference"></a>AreEqualReferences_Same_Reference

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1,393 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2,475 ns</td><td align="right" bgcolor="#FFFFFF">2,547 ns</td><td align="right" bgcolor="#FFFFFF">3,868 ns</td><td align="right" bgcolor="#FFFFFF">3,480 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td><td align="right" bgcolor="#FFFFFF">0,004 μs</td><td align="right" bgcolor="#FFFFFF">0,003 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectHelper_Benchmark_AreEqualReferences_Strings"></a>AreEqualReferences_Strings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 21,395 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">76,435 ns</td><td align="right" bgcolor="#FFFFFF">72,628 ns</td><td align="right" bgcolor="#FFFFFF">94,023 ns</td><td align="right" bgcolor="#FFFFFF">91,363 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,073 μs</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,091 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectHelper_Benchmark_IsNull"></a>IsNull

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 0,047 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,065 ns</td><td align="right" bgcolor="#FFFFFF">0,048 ns</td><td align="right" bgcolor="#FFFFFF">0,039 ns</td><td align="right" bgcolor="#FFFFFF">0,086 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ObjectToStringHelper_Benchmark"></a>ObjectToStringHelper_Benchmark

### <a name="ObjectToStringHelper_Benchmark_ToFullTypeString"></a>ToFullTypeString

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 20,566 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">100,007 ns</td><td align="right" bgcolor="#FFFFFF">97,343 ns</td><td align="right" bgcolor="#FFFFFF">117,462 ns</td><td align="right" bgcolor="#FFFFFF">117,910 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,117 μs</td><td align="right" bgcolor="#FFFFFF">0,118 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ObjectToStringHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 296,496 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3494,446 ns</td><td align="right" bgcolor="#FFFFFF">3247,932 ns</td><td align="right" bgcolor="#FFFFFF">3197,950 ns</td><td align="right" bgcolor="#FFFFFF">3223,957 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,494 μs</td><td align="right" bgcolor="#FFFFFF">3,248 μs</td><td align="right" bgcolor="#FFFFFF">3,198 μs</td><td align="right" bgcolor="#FFFFFF">3,224 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1741,000</td><td align="right" bgcolor="#FFFFFF">1741,000</td><td align="right" bgcolor="#A8D08D">889,000 (Δ = -852,000)</td><td align="right" bgcolor="#FFFFFF">889,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,700</td><td align="right" bgcolor="#FFFFFF">1,700</td><td align="right" bgcolor="#A8D08D">0,868 (Δ = -0,832)</td><td align="right" bgcolor="#FFFFFF">0,868</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#FFFFFF">0,002</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ObjectToStringHelper_Benchmark_ToTypeString"></a>ToTypeString

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 2,758 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,053 ns</td><td align="right" bgcolor="#FFFFFF">22,958 ns</td><td align="right" bgcolor="#FFFFFF">25,645 ns</td><td align="right" bgcolor="#FFFFFF">25,717 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,024 μs</td><td align="right" bgcolor="#FFFFFF">0,023 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ParallelHelper_Benchmark"></a>ParallelHelper_Benchmark

### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_100"></a>ExecuteInParallel_ItemsPerBash_100

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 222467,307 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3183476,913 ns</td><td align="right" bgcolor="#A8D08D">3079604,425 ns (Δ = -103872,488 ns)</td><td align="right" bgcolor="#A8D08D">2961009,607 ns (Δ = -118594,818 ns)</td><td align="right" bgcolor="#FFFFFF">2962750,620 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3183,477 μs</td><td align="right" bgcolor="#FFFFFF">3079,604 μs</td><td align="right" bgcolor="#FFFFFF">2961,010 μs</td><td align="right" bgcolor="#FFFFFF">2962,751 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,183 ms</td><td align="right" bgcolor="#FFFFFF">3,080 ms</td><td align="right" bgcolor="#FFFFFF">2,961 ms</td><td align="right" bgcolor="#FFFFFF">2,963 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.3.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">275,000</td><td align="right" bgcolor="#A8D08D">261,000 (Δ = -14,000)</td><td align="right" bgcolor="#A8D08D">260,000 (Δ = -1,000)</td><td align="right" bgcolor="#FF4949">265,000 (Δ = +5,000)</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">40,000</td><td align="right" bgcolor="#A8D08D">35,000 (Δ = -5,000)</td><td align="right" bgcolor="#FF4949">260,000 (Δ = +225,000)</td><td align="right" bgcolor="#FF4949">265,000 (Δ = +5,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,7 %</td><td align="right" bgcolor="#A8D08D">-17,2 %</td><td align="right" bgcolor="#FF4949">+0,3 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">175535,000</td><td align="right" bgcolor="#A8D08D">167339,000 (Δ = -8196,000)</td><td align="right" bgcolor="#A8D08D">138578,000 (Δ = -28761,000)</td><td align="right" bgcolor="#FF4949">139015,000 (Δ = +437,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">171,421</td><td align="right" bgcolor="#A8D08D">163,417 (Δ = -8,004)</td><td align="right" bgcolor="#A8D08D">135,330 (Δ = -28,087)</td><td align="right" bgcolor="#FF4949">135,757 (Δ = +0,427)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,167</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,027)</td><td align="right" bgcolor="#FF4949">0,133 (Δ = +0,000)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_1000"></a>ExecuteInParallel_ItemsPerBash_1000

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 41469,630 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,2 %</td><td align="right" bgcolor="#FF4949">+1,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">670753,068 ns</td><td align="right" bgcolor="#A8D08D">629283,438 ns (Δ = -41469,630 ns)</td><td align="right" bgcolor="#FF4949">637968,652 ns (Δ = +8685,213 ns)</td><td align="right" bgcolor="#FFFFFF">633883,738 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">670,753 μs</td><td align="right" bgcolor="#FFFFFF">629,283 μs</td><td align="right" bgcolor="#FFFFFF">637,969 μs</td><td align="right" bgcolor="#FFFFFF">633,884 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,671 ms</td><td align="right" bgcolor="#FFFFFF">0,629 ms</td><td align="right" bgcolor="#FFFFFF">0,638 ms</td><td align="right" bgcolor="#FFFFFF">0,634 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">145,000</td><td align="right" bgcolor="#A8D08D">140,000 (Δ = -5,000)</td><td align="right" bgcolor="#FF4949">165,000 (Δ = +25,000)</td><td align="right" bgcolor="#FFFFFF">165,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FF4949">165,000 (Δ = +150,000)</td><td align="right" bgcolor="#FFFFFF">165,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,2 %</td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#A8D08D">-0,1 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">92193,000</td><td align="right" bgcolor="#A8D08D">91061,000 (Δ = -1132,000)</td><td align="right" bgcolor="#A8D08D">87403,000 (Δ = -3658,000)</td><td align="right" bgcolor="#A8D08D">87322,000 (Δ = -81,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">90,032</td><td align="right" bgcolor="#A8D08D">88,927 (Δ = -1,105)</td><td align="right" bgcolor="#A8D08D">85,354 (Δ = -3,572)</td><td align="right" bgcolor="#A8D08D">85,275 (Δ = -0,079)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,088</td><td align="right" bgcolor="#A8D08D">0,087 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,083 (Δ = -0,003)</td><td align="right" bgcolor="#A8D08D">0,083 (Δ = 0,000)</td></tr></table>


### <a name="ParallelHelper_Benchmark_ExecuteInParallel_ItemsPerBash_500"></a>ExecuteInParallel_ItemsPerBash_500

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 37333,532 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,5 %</td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">884195,090 ns</td><td align="right" bgcolor="#A8D08D">862348,135 ns (Δ = -21846,955 ns)</td><td align="right" bgcolor="#A8D08D">846861,558 ns (Δ = -15486,577 ns)</td><td align="right" bgcolor="#FFFFFF">849197,632 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">884,195 μs</td><td align="right" bgcolor="#FFFFFF">862,348 μs</td><td align="right" bgcolor="#FFFFFF">846,862 μs</td><td align="right" bgcolor="#FFFFFF">849,198 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,884 ms</td><td align="right" bgcolor="#FFFFFF">0,862 ms</td><td align="right" bgcolor="#FFFFFF">0,847 ms</td><td align="right" bgcolor="#FFFFFF">0,849 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">155,000</td><td align="right" bgcolor="#A8D08D">150,000 (Δ = -5,000)</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +20,000)</td><td align="right" bgcolor="#FFFFFF">170,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FF4949">170,000 (Δ = +155,000)</td><td align="right" bgcolor="#FFFFFF">170,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,7 %</td><td align="right" bgcolor="#A8D08D">-6,9 %</td><td align="right" bgcolor="#FF4949">+0,2 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">99023,000</td><td align="right" bgcolor="#A8D08D">97333,000 (Δ = -1690,000)</td><td align="right" bgcolor="#A8D08D">90660,000 (Δ = -6673,000)</td><td align="right" bgcolor="#FF4949">90810,000 (Δ = +150,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">96,702</td><td align="right" bgcolor="#A8D08D">95,052 (Δ = -1,650)</td><td align="right" bgcolor="#A8D08D">88,535 (Δ = -6,517)</td><td align="right" bgcolor="#FF4949">88,682 (Δ = +0,146)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,094</td><td align="right" bgcolor="#A8D08D">0,093 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,086 (Δ = -0,006)</td><td align="right" bgcolor="#FF4949">0,087 (Δ = +0,000)</td></tr></table>


## <a name="PropertyBag_GetPropertyValue_Benchmark"></a>PropertyBag_GetPropertyValue_Benchmark

### <a name="PropertyBag_GetPropertyValue_Benchmark_GetBoolValue"></a>GetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 2,870 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">75,812 ns</td><td align="right" bgcolor="#FFFFFF">75,297 ns</td><td align="right" bgcolor="#FFFFFF">78,062 ns</td><td align="right" bgcolor="#FFFFFF">78,167 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,075 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetIntValue"></a>GetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 4,000 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">75,887 ns</td><td align="right" bgcolor="#FFFFFF">75,878 ns</td><td align="right" bgcolor="#FFFFFF">79,878 ns</td><td align="right" bgcolor="#FFFFFF">79,713 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,076 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td><td align="right" bgcolor="#FFFFFF">0,080 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyBag_GetPropertyValue_Benchmark_GetStringValue"></a>GetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 5,960 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">81,437 ns</td><td align="right" bgcolor="#FFFFFF">80,818 ns</td><td align="right" bgcolor="#FFFFFF">86,497 ns</td><td align="right" bgcolor="#FFFFFF">86,778 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,086 μs</td><td align="right" bgcolor="#FFFFFF">0,087 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="PropertyBag_SetPropertyValue_Benchmark"></a>PropertyBag_SetPropertyValue_Benchmark

### <a name="PropertyBag_SetPropertyValue_Benchmark_SetBoolValue"></a>SetBoolValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 47,030 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">163,873 ns</td><td align="right" bgcolor="#FFFFFF">116,843 ns</td><td align="right" bgcolor="#FFFFFF">129,705 ns</td><td align="right" bgcolor="#FFFFFF">129,205 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,164 μs</td><td align="right" bgcolor="#FFFFFF">0,117 μs</td><td align="right" bgcolor="#FFFFFF">0,130 μs</td><td align="right" bgcolor="#FFFFFF">0,129 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetIntValue"></a>SetIntValue

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 49,077 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">162,697 ns</td><td align="right" bgcolor="#FFFFFF">113,620 ns</td><td align="right" bgcolor="#FFFFFF">125,837 ns</td><td align="right" bgcolor="#FFFFFF">129,913 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,163 μs</td><td align="right" bgcolor="#FFFFFF">0,114 μs</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td><td align="right" bgcolor="#FFFFFF">0,130 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-100,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -25,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -0,024)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyBag_SetPropertyValue_Benchmark_SetStringValue"></a>SetStringValue

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 12,114 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">72,165 ns</td><td align="right" bgcolor="#FFFFFF">72,150 ns</td><td align="right" bgcolor="#FFFFFF">83,833 ns</td><td align="right" bgcolor="#FFFFFF">84,264 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,072 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td><td align="right" bgcolor="#FFFFFF">0,084 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="PropertyInfo_ReflectionExtensions_Benchmark"></a>PropertyInfo_ReflectionExtensions_Benchmark

### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 237,823 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3787,622 ns</td><td align="right" bgcolor="#FFFFFF">3851,790 ns</td><td align="right" bgcolor="#FFFFFF">4025,445 ns</td><td align="right" bgcolor="#FFFFFF">3992,612 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,788 μs</td><td align="right" bgcolor="#FFFFFF">3,852 μs</td><td align="right" bgcolor="#FFFFFF">4,025 μs</td><td align="right" bgcolor="#FFFFFF">3,993 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -160,000)</td><td align="right" bgcolor="#FFFFFF">164,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,156)</td><td align="right" bgcolor="#FFFFFF">0,160</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 244,503 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">814,127 ns</td><td align="right" bgcolor="#FFFFFF">829,518 ns</td><td align="right" bgcolor="#FFFFFF">1010,435 ns</td><td align="right" bgcolor="#FFFFFF">1058,630 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,814 μs</td><td align="right" bgcolor="#FFFFFF">0,830 μs</td><td align="right" bgcolor="#FFFFFF">1,010 μs</td><td align="right" bgcolor="#FFFFFF">1,059 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#A8D08D">37,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">37,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,036</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 228,825 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4594,498 ns</td><td align="right" bgcolor="#FFFFFF">4581,858 ns</td><td align="right" bgcolor="#FFFFFF">4810,683 ns</td><td align="right" bgcolor="#FFFFFF">4792,908 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">4,594 μs</td><td align="right" bgcolor="#FFFFFF">4,582 μs</td><td align="right" bgcolor="#FFFFFF">4,811 μs</td><td align="right" bgcolor="#FFFFFF">4,793 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-48,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">586,000</td><td align="right" bgcolor="#FFFFFF">586,000</td><td align="right" bgcolor="#A8D08D">303,000 (Δ = -283,000)</td><td align="right" bgcolor="#FFFFFF">303,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,572</td><td align="right" bgcolor="#FFFFFF">0,572</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,276)</td><td align="right" bgcolor="#FFFFFF">0,296</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType"></a>GetCustomAttributesEx_AttributeType

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 228,321 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3740,792 ns</td><td align="right" bgcolor="#FFFFFF">3736,540 ns</td><td align="right" bgcolor="#FFFFFF">3964,861 ns</td><td align="right" bgcolor="#FFFFFF">3950,767 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,741 μs</td><td align="right" bgcolor="#FFFFFF">3,737 μs</td><td align="right" bgcolor="#FFFFFF">3,965 μs</td><td align="right" bgcolor="#FFFFFF">3,951 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#FFFFFF">324,000</td><td align="right" bgcolor="#A8D08D">164,000 (Δ = -160,000)</td><td align="right" bgcolor="#FFFFFF">164,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#FFFFFF">0,316</td><td align="right" bgcolor="#A8D08D">0,160 (Δ = -0,156)</td><td align="right" bgcolor="#FFFFFF">0,160</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_AttributeType__Inheritd"></a>GetCustomAttributesEx_AttributeType__Inheritd

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 242,670 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">807,002 ns</td><td align="right" bgcolor="#FFFFFF">795,482 ns</td><td align="right" bgcolor="#FFFFFF">1008,298 ns</td><td align="right" bgcolor="#FFFFFF">1038,152 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,807 μs</td><td align="right" bgcolor="#FFFFFF">0,795 μs</td><td align="right" bgcolor="#FFFFFF">1,008 μs</td><td align="right" bgcolor="#FFFFFF">1,038 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-50,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#FFFFFF">74,000</td><td align="right" bgcolor="#A8D08D">37,000 (Δ = -37,000)</td><td align="right" bgcolor="#FFFFFF">37,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#FFFFFF">0,072</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,036)</td><td align="right" bgcolor="#FFFFFF">0,036</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="PropertyInfo_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 119,903 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">663,750 ns</td><td align="right" bgcolor="#FFFFFF">699,798 ns</td><td align="right" bgcolor="#FFFFFF">780,357 ns</td><td align="right" bgcolor="#FFFFFF">783,653 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,664 μs</td><td align="right" bgcolor="#FFFFFF">0,700 μs</td><td align="right" bgcolor="#FFFFFF">0,780 μs</td><td align="right" bgcolor="#FFFFFF">0,784 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#FFFFFF">164,000</td><td align="right" bgcolor="#A8D08D">90,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">90,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#FFFFFF">0,160</td><td align="right" bgcolor="#A8D08D">0,088 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,088</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ResourceHelper_Benchmark"></a>ResourceHelper_Benchmark

### <a name="ResourceHelper_Benchmark_GetString"></a>GetString

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 157,463 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">584,525 ns</td><td align="right" bgcolor="#FFFFFF">427,062 ns</td><td align="right" bgcolor="#FFFFFF">481,685 ns</td><td align="right" bgcolor="#FFFFFF">463,267 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,585 μs</td><td align="right" bgcolor="#FFFFFF">0,427 μs</td><td align="right" bgcolor="#FFFFFF">0,482 μs</td><td align="right" bgcolor="#FFFFFF">0,463 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#FFFFFF">258,000</td><td align="right" bgcolor="#A8D08D">131,000 (Δ = -127,000)</td><td align="right" bgcolor="#FFFFFF">131,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#FFFFFF">0,252</td><td align="right" bgcolor="#A8D08D">0,128 (Δ = -0,124)</td><td align="right" bgcolor="#FFFFFF">0,128</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ScopeManager_Benchmark"></a>ScopeManager_Benchmark

### <a name="ScopeManager_Benchmark_Get_Existing_ScopeManager"></a>Get_Existing_ScopeManager

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 49,118 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">191,047 ns</td><td align="right" bgcolor="#FFFFFF">147,632 ns</td><td align="right" bgcolor="#FFFFFF">141,928 ns</td><td align="right" bgcolor="#FFFFFF">145,467 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,191 μs</td><td align="right" bgcolor="#FFFFFF">0,148 μs</td><td align="right" bgcolor="#FFFFFF">0,142 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,3 %</td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -90,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,088)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ScopeManager_Benchmark_Get_New_ScopeManager"></a>Get_New_ScopeManager

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 46,018 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">189,017 ns</td><td align="right" bgcolor="#FFFFFF">144,198 ns</td><td align="right" bgcolor="#FFFFFF">142,998 ns</td><td align="right" bgcolor="#FFFFFF">154,577 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,189 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,155 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-78,3 %</td><td align="right" bgcolor="#A8D08D">-52,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">115,000</td><td align="right" bgcolor="#A8D08D">25,000 (Δ = -90,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,112</td><td align="right" bgcolor="#A8D08D">0,024 (Δ = -0,088)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="Serialization_Binary_Benchmark"></a>Serialization_Binary_Benchmark

### <a name="Serialization_Binary_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 233938,332 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,3 %</td><td align="right" bgcolor="#A8D08D">-31,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">670636,435 ns</td><td align="right" bgcolor="#A8D08D">641786,842 ns (Δ = -28849,593 ns)</td><td align="right" bgcolor="#A8D08D">441004,117 ns (Δ = -200782,725 ns)</td><td align="right" bgcolor="#FFFFFF">436698,103 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">670,636 μs</td><td align="right" bgcolor="#FFFFFF">641,787 μs</td><td align="right" bgcolor="#FFFFFF">441,004 μs</td><td align="right" bgcolor="#FFFFFF">436,698 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,671 ms</td><td align="right" bgcolor="#FFFFFF">0,642 ms</td><td align="right" bgcolor="#FFFFFF">0,441 ms</td><td align="right" bgcolor="#FFFFFF">0,437 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">4.5.4</td><td align="right">5.2.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">170,000</td><td align="right" bgcolor="#A8D08D">160,000 (Δ = -10,000)</td><td align="right" bgcolor="#A8D08D">120,000 (Δ = -40,000)</td><td align="right" bgcolor="#FFFFFF">120,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">30,000</td><td align="right" bgcolor="#FF4949">40,000 (Δ = +10,000)</td><td align="right" bgcolor="#FF4949">80,000 (Δ = +40,000)</td><td align="right" bgcolor="#FFFFFF">80,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,8 %</td><td align="right" bgcolor="#A8D08D">-38,1 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">110631,000</td><td align="right" bgcolor="#A8D08D">103139,000 (Δ = -7492,000)</td><td align="right" bgcolor="#A8D08D">63869,000 (Δ = -39270,000)</td><td align="right" bgcolor="#A8D08D">63865,000 (Δ = -4,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">108,038</td><td align="right" bgcolor="#A8D08D">100,722 (Δ = -7,316)</td><td align="right" bgcolor="#A8D08D">62,372 (Δ = -38,350)</td><td align="right" bgcolor="#A8D08D">62,368 (Δ = -0,004)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,106</td><td align="right" bgcolor="#A8D08D">0,098 (Δ = -0,007)</td><td align="right" bgcolor="#A8D08D">0,061 (Δ = -0,037)</td><td align="right" bgcolor="#A8D08D">0,061 (Δ = 0,000)</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 201839,120 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,0 %</td><td align="right" bgcolor="#A8D08D">-47,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">419358,952 ns</td><td align="right" bgcolor="#A8D08D">415123,262 ns (Δ = -4235,690 ns)</td><td align="right" bgcolor="#A8D08D">217519,832 ns (Δ = -197603,430 ns)</td><td align="right" bgcolor="#FFFFFF">218625,317 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">419,359 μs</td><td align="right" bgcolor="#FFFFFF">415,123 μs</td><td align="right" bgcolor="#FFFFFF">217,520 μs</td><td align="right" bgcolor="#FFFFFF">218,625 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,419 ms</td><td align="right" bgcolor="#FFFFFF">0,415 ms</td><td align="right" bgcolor="#FFFFFF">0,218 ms</td><td align="right" bgcolor="#FFFFFF">0,219 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">60,000</td><td align="right" bgcolor="#A8D08D">55,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">35,000 (Δ = -20,000)</td><td align="right" bgcolor="#FFFFFF">35,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#A8D08D">15,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">10,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">10,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,3 %</td><td align="right" bgcolor="#A8D08D">-47,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">39196,000</td><td align="right" bgcolor="#A8D08D">37901,000 (Δ = -1295,000)</td><td align="right" bgcolor="#A8D08D">20026,000 (Δ = -17875,000)</td><td align="right" bgcolor="#FFFFFF">20026,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">38,277</td><td align="right" bgcolor="#A8D08D">37,013 (Δ = -1,265)</td><td align="right" bgcolor="#A8D08D">19,557 (Δ = -17,456)</td><td align="right" bgcolor="#FFFFFF">19,557</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,037</td><td align="right" bgcolor="#A8D08D">0,036 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,019 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,019</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 211174,537 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,8 %</td><td align="right" bgcolor="#A8D08D">-36,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">563152,188 ns</td><td align="right" bgcolor="#A8D08D">553253,475 ns (Δ = -9898,713 ns)</td><td align="right" bgcolor="#A8D08D">352703,585 ns (Δ = -200549,890 ns)</td><td align="right" bgcolor="#FFFFFF">351977,652 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">563,152 μs</td><td align="right" bgcolor="#FFFFFF">553,253 μs</td><td align="right" bgcolor="#FFFFFF">352,704 μs</td><td align="right" bgcolor="#FFFFFF">351,978 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,563 ms</td><td align="right" bgcolor="#FFFFFF">0,553 ms</td><td align="right" bgcolor="#FFFFFF">0,353 ms</td><td align="right" bgcolor="#FFFFFF">0,352 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#A8D08D">125,000 (Δ = -10,000)</td><td align="right" bgcolor="#A8D08D">90,000 (Δ = -35,000)</td><td align="right" bgcolor="#FFFFFF">90,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">30,000</td><td align="right" bgcolor="#FFFFFF">30,000</td><td align="right" bgcolor="#FF4949">36,000 (Δ = +6,000)</td><td align="right" bgcolor="#FFFFFF">36,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-6,3 %</td><td align="right" bgcolor="#A8D08D">-41,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">87805,000</td><td align="right" bgcolor="#A8D08D">82268,000 (Δ = -5537,000)</td><td align="right" bgcolor="#A8D08D">47887,000 (Δ = -34381,000)</td><td align="right" bgcolor="#FFFFFF">47887,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">85,747</td><td align="right" bgcolor="#A8D08D">80,340 (Δ = -5,407)</td><td align="right" bgcolor="#A8D08D">46,765 (Δ = -33,575)</td><td align="right" bgcolor="#FFFFFF">46,765</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,084</td><td align="right" bgcolor="#A8D08D">0,078 (Δ = -0,005)</td><td align="right" bgcolor="#A8D08D">0,046 (Δ = -0,033)</td><td align="right" bgcolor="#FFFFFF">0,046</td></tr></table>


### <a name="Serialization_Binary_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 259409,892 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,0 %</td><td align="right" bgcolor="#A8D08D">-15,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1348469,158 ns</td><td align="right" bgcolor="#A8D08D">1295194,253 ns (Δ = -53274,905 ns)</td><td align="right" bgcolor="#A8D08D">1089059,267 ns (Δ = -206134,987 ns)</td><td align="right" bgcolor="#FFFFFF">1092225,445 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1348,469 μs</td><td align="right" bgcolor="#FFFFFF">1295,194 μs</td><td align="right" bgcolor="#FFFFFF">1089,059 μs</td><td align="right" bgcolor="#FFFFFF">1092,225 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,348 ms</td><td align="right" bgcolor="#FFFFFF">1,295 ms</td><td align="right" bgcolor="#FFFFFF">1,089 ms</td><td align="right" bgcolor="#FFFFFF">1,092 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">530,000</td><td align="right" bgcolor="#A8D08D">490,000 (Δ = -40,000)</td><td align="right" bgcolor="#A8D08D">360,000 (Δ = -130,000)</td><td align="right" bgcolor="#FFFFFF">360,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">85,000</td><td align="right" bgcolor="#FFFFFF">85,000</td><td align="right" bgcolor="#A8D08D">55,000 (Δ = -30,000)</td><td align="right" bgcolor="#FFFFFF">55,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,0 %</td><td align="right" bgcolor="#A8D08D">-38,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">337064,000</td><td align="right" bgcolor="#A8D08D">310257,000 (Δ = -26807,000)</td><td align="right" bgcolor="#A8D08D">190729,000 (Δ = -119528,000)</td><td align="right" bgcolor="#FFFFFF">190729,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">329,164</td><td align="right" bgcolor="#A8D08D">302,985 (Δ = -26,179)</td><td align="right" bgcolor="#A8D08D">186,259 (Δ = -116,727)</td><td align="right" bgcolor="#FFFFFF">186,259</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,321</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,026)</td><td align="right" bgcolor="#A8D08D">0,182 (Δ = -0,114)</td><td align="right" bgcolor="#FFFFFF">0,182</td></tr></table>


## <a name="Serialization_Json_Benchmark"></a>Serialization_Json_Benchmark

### <a name="Serialization_Json_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 1438768,023 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,2 %</td><td align="right" bgcolor="#FF4949">+2,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17282532,318 ns</td><td align="right" bgcolor="#FFFFFF">17151554,108 ns</td><td align="right" bgcolor="#FF4949">18215608,947 ns (Δ = +1064054,838 ns)</td><td align="right" bgcolor="#FF4949">18590322,132 ns (Δ = +374713,185 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">17282,532 μs</td><td align="right" bgcolor="#FFFFFF">17151,554 μs</td><td align="right" bgcolor="#FF4949">18215,609 μs (Δ = +1064,055 μs)</td><td align="right" bgcolor="#FF4949">18590,322 μs (Δ = +374,713 μs)</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">17,283 ms</td><td align="right" bgcolor="#FFFFFF">17,152 ms</td><td align="right" bgcolor="#FFFFFF">18,216 ms</td><td align="right" bgcolor="#FFFFFF">18,590 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2456,000</td><td align="right" bgcolor="#A8D08D">2390,000 (Δ = -66,000)</td><td align="right" bgcolor="#A8D08D">1495,000 (Δ = -895,000)</td><td align="right" bgcolor="#FFFFFF">1495,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">816,000</td><td align="right" bgcolor="#A8D08D">795,000 (Δ = -21,000)</td><td align="right" bgcolor="#A8D08D">495,000 (Δ = -300,000)</td><td align="right" bgcolor="#FFFFFF">495,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,7 %</td><td align="right" bgcolor="#A8D08D">-47,8 %</td><td align="right" bgcolor="#A8D08D">0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1546633,000</td><td align="right" bgcolor="#A8D08D">1504714,000 (Δ = -41919,000)</td><td align="right" bgcolor="#A8D08D">784872,000 (Δ = -719842,000)</td><td align="right" bgcolor="#A8D08D">784842,000 (Δ = -30,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1510,384</td><td align="right" bgcolor="#A8D08D">1469,447 (Δ = -40,937)</td><td align="right" bgcolor="#A8D08D">766,477 (Δ = -702,971)</td><td align="right" bgcolor="#A8D08D">766,447 (Δ = -0,029)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,475</td><td align="right" bgcolor="#A8D08D">1,435 (Δ = -0,040)</td><td align="right" bgcolor="#A8D08D">0,749 (Δ = -0,686)</td><td align="right" bgcolor="#A8D08D">0,748 (Δ = 0,000)</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 142408,458 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1080634,655 ns</td><td align="right" bgcolor="#FFFFFF">1083816,505 ns</td><td align="right" bgcolor="#A8D08D">941408,047 ns (Δ = -142408,458 ns)</td><td align="right" bgcolor="#FFFFFF">950608,437 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1080,635 μs</td><td align="right" bgcolor="#FFFFFF">1083,817 μs</td><td align="right" bgcolor="#FFFFFF">941,408 μs</td><td align="right" bgcolor="#FFFFFF">950,608 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,081 ms</td><td align="right" bgcolor="#FFFFFF">1,084 ms</td><td align="right" bgcolor="#FFFFFF">0,941 ms</td><td align="right" bgcolor="#FFFFFF">0,951 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">135,000</td><td align="right" bgcolor="#A8D08D">130,000 (Δ = -5,000)</td><td align="right" bgcolor="#A8D08D">85,000 (Δ = -45,000)</td><td align="right" bgcolor="#FFFFFF">85,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">45,000</td><td align="right" bgcolor="#A8D08D">40,000 (Δ = -5,000)</td><td align="right" bgcolor="#FF4949">85,000 (Δ = +45,000)</td><td align="right" bgcolor="#FFFFFF">85,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#A8D08D">-47,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">86941,000</td><td align="right" bgcolor="#A8D08D">85308,000 (Δ = -1633,000)</td><td align="right" bgcolor="#A8D08D">44814,000 (Δ = -40494,000)</td><td align="right" bgcolor="#FFFFFF">44814,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">84,903</td><td align="right" bgcolor="#A8D08D">83,309 (Δ = -1,595)</td><td align="right" bgcolor="#A8D08D">43,764 (Δ = -39,545)</td><td align="right" bgcolor="#FFFFFF">43,764</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,083</td><td align="right" bgcolor="#A8D08D">0,081 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,043 (Δ = -0,039)</td><td align="right" bgcolor="#FFFFFF">0,043</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 55952,642 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+1,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3192412,935 ns</td><td align="right" bgcolor="#FFFFFF">3180305,403 ns</td><td align="right" bgcolor="#FF4949">3218089,073 ns (Δ = +37783,670 ns)</td><td align="right" bgcolor="#FFFFFF">3236258,045 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3192,413 μs</td><td align="right" bgcolor="#FFFFFF">3180,305 μs</td><td align="right" bgcolor="#FFFFFF">3218,089 μs</td><td align="right" bgcolor="#FFFFFF">3236,258 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">3,192 ms</td><td align="right" bgcolor="#FFFFFF">3,180 ms</td><td align="right" bgcolor="#FFFFFF">3,218 ms</td><td align="right" bgcolor="#FFFFFF">3,236 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">445,000</td><td align="right" bgcolor="#A8D08D">434,000 (Δ = -11,000)</td><td align="right" bgcolor="#A8D08D">270,000 (Δ = -164,000)</td><td align="right" bgcolor="#FFFFFF">270,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">130,000</td><td align="right" bgcolor="#A8D08D">115,000 (Δ = -15,000)</td><td align="right" bgcolor="#FF4949">270,000 (Δ = +155,000)</td><td align="right" bgcolor="#FFFFFF">270,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,6 %</td><td align="right" bgcolor="#A8D08D">-48,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">281774,000</td><td align="right" bgcolor="#A8D08D">274479,000 (Δ = -7295,000)</td><td align="right" bgcolor="#A8D08D">142444,000 (Δ = -132035,000)</td><td align="right" bgcolor="#FFFFFF">142444,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">275,170</td><td align="right" bgcolor="#A8D08D">268,046 (Δ = -7,124)</td><td align="right" bgcolor="#A8D08D">139,105 (Δ = -128,940)</td><td align="right" bgcolor="#FFFFFF">139,105</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,269</td><td align="right" bgcolor="#A8D08D">0,262 (Δ = -0,007)</td><td align="right" bgcolor="#A8D08D">0,136 (Δ = -0,126)</td><td align="right" bgcolor="#FFFFFF">0,136</td></tr></table>


### <a name="Serialization_Json_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 1133889,277 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,7 %</td><td align="right" bgcolor="#FF4949">+1,5 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">13755086,605 ns</td><td align="right" bgcolor="#FFFFFF">13631347,425 ns</td><td align="right" bgcolor="#FF4949">14541778,950 ns (Δ = +910431,525 ns)</td><td align="right" bgcolor="#FF4949">14765236,702 ns (Δ = +223457,752 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">13755,087 μs</td><td align="right" bgcolor="#FFFFFF">13631,347 μs</td><td align="right" bgcolor="#FF4949">14541,779 μs (Δ = +910,432 μs)</td><td align="right" bgcolor="#FFFFFF">14765,237 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">13,755 ms</td><td align="right" bgcolor="#FFFFFF">13,631 ms</td><td align="right" bgcolor="#FFFFFF">14,542 ms</td><td align="right" bgcolor="#FFFFFF">14,765 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">2005,000</td><td align="right" bgcolor="#A8D08D">1934,000 (Δ = -71,000)</td><td align="right" bgcolor="#A8D08D">1205,000 (Δ = -729,000)</td><td align="right" bgcolor="#FFFFFF">1205,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">557,000</td><td align="right" bgcolor="#A8D08D">516,000 (Δ = -41,000)</td><td align="right" bgcolor="#A8D08D">300,000 (Δ = -216,000)</td><td align="right" bgcolor="#FFFFFF">300,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,6 %</td><td align="right" bgcolor="#A8D08D">-47,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1263164,000</td><td align="right" bgcolor="#A8D08D">1218321,000 (Δ = -44843,000)</td><td align="right" bgcolor="#A8D08D">634273,000 (Δ = -584048,000)</td><td align="right" bgcolor="#FFFFFF">634273,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1233,559</td><td align="right" bgcolor="#A8D08D">1189,767 (Δ = -43,792)</td><td align="right" bgcolor="#A8D08D">619,407 (Δ = -570,359)</td><td align="right" bgcolor="#FFFFFF">619,407</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,205</td><td align="right" bgcolor="#A8D08D">1,162 (Δ = -0,043)</td><td align="right" bgcolor="#A8D08D">0,605 (Δ = -0,557)</td><td align="right" bgcolor="#FFFFFF">0,605</td></tr></table>


## <a name="Serialization_Xml_Benchmark"></a>Serialization_Xml_Benchmark

### <a name="Serialization_Xml_Benchmark_SerializeComplexObjectGraph"></a>SerializeComplexObjectGraph

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 217788,590 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,2 %</td><td align="right" bgcolor="#A8D08D">-14,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1317994,948 ns</td><td align="right" bgcolor="#A8D08D">1289010,390 ns (Δ = -28984,558 ns)</td><td align="right" bgcolor="#A8D08D">1100206,358 ns (Δ = -188804,032 ns)</td><td align="right" bgcolor="#FFFFFF">1109756,045 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1317,995 μs</td><td align="right" bgcolor="#FFFFFF">1289,010 μs</td><td align="right" bgcolor="#FFFFFF">1100,206 μs</td><td align="right" bgcolor="#FFFFFF">1109,756 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">1,318 ms</td><td align="right" bgcolor="#FFFFFF">1,289 ms</td><td align="right" bgcolor="#FFFFFF">1,100 ms</td><td align="right" bgcolor="#FFFFFF">1,110 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 1</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">930,000</td><td align="right" bgcolor="#A8D08D">915,000 (Δ = -15,000)</td><td align="right" bgcolor="#FF4949">950,000 (Δ = +35,000)</td><td align="right" bgcolor="#FFFFFF">950,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">150,000</td><td align="right" bgcolor="#A8D08D">146,000 (Δ = -4,000)</td><td align="right" bgcolor="#A8D08D">133,000 (Δ = -13,000)</td><td align="right" bgcolor="#FF4949">135,000 (Δ = +2,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,7 %</td><td align="right" bgcolor="#A8D08D">-13,3 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">587216,000</td><td align="right" bgcolor="#A8D08D">577296,000 (Δ = -9920,000)</td><td align="right" bgcolor="#A8D08D">500534,000 (Δ = -76762,000)</td><td align="right" bgcolor="#FF4949">500576,000 (Δ = +42,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">573,453</td><td align="right" bgcolor="#A8D08D">563,766 (Δ = -9,688)</td><td align="right" bgcolor="#A8D08D">488,803 (Δ = -74,963)</td><td align="right" bgcolor="#FF4949">488,844 (Δ = +0,041)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,560</td><td align="right" bgcolor="#A8D08D">0,551 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,477 (Δ = -0,073)</td><td align="right" bgcolor="#FF4949">0,477 (Δ = +0,000)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel1Models"></a>SerializeLevel1Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 207171,357 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,6 %</td><td align="right" bgcolor="#FF4949">+3,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">506567,588 ns</td><td align="right" bgcolor="#FFFFFF">503913,288 ns</td><td align="right" bgcolor="#A8D08D">299396,232 ns (Δ = -204517,057 ns)</td><td align="right" bgcolor="#FF4949">309695,993 ns (Δ = +10299,762 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">506,568 μs</td><td align="right" bgcolor="#FFFFFF">503,913 μs</td><td align="right" bgcolor="#FFFFFF">299,396 μs</td><td align="right" bgcolor="#FFFFFF">309,696 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,507 ms</td><td align="right" bgcolor="#FFFFFF">0,504 ms</td><td align="right" bgcolor="#FFFFFF">0,299 ms</td><td align="right" bgcolor="#FFFFFF">0,310 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">215,000</td><td align="right" bgcolor="#FFFFFF">215,000</td><td align="right" bgcolor="#FFFFFF">215,000</td><td align="right" bgcolor="#FFFFFF">215,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">35,000</td><td align="right" bgcolor="#FFFFFF">35,000</td><td align="right" bgcolor="#FF4949">215,000 (Δ = +180,000)</td><td align="right" bgcolor="#FFFFFF">215,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,4 %</td><td align="right" bgcolor="#A8D08D">-16,6 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">138507,000</td><td align="right" bgcolor="#A8D08D">136503,000 (Δ = -2004,000)</td><td align="right" bgcolor="#A8D08D">113851,000 (Δ = -22652,000)</td><td align="right" bgcolor="#FF4949">113854,000 (Δ = +3,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">135,261</td><td align="right" bgcolor="#A8D08D">133,304 (Δ = -1,957)</td><td align="right" bgcolor="#A8D08D">111,183 (Δ = -22,121)</td><td align="right" bgcolor="#FF4949">111,186 (Δ = +0,003)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,132</td><td align="right" bgcolor="#A8D08D">0,130 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,109 (Δ = -0,022)</td><td align="right" bgcolor="#FF4949">0,109 (Δ = +0,000)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel2Models"></a>SerializeLevel2Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 239832,503 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-26,9 %</td><td align="right" bgcolor="#FF4949">+1,4 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">885788,848 ns</td><td align="right" bgcolor="#FFFFFF">883289,465 ns</td><td align="right" bgcolor="#A8D08D">645956,345 ns (Δ = -237333,120 ns)</td><td align="right" bgcolor="#FF4949">655276,058 ns (Δ = +9319,713 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">885,789 μs</td><td align="right" bgcolor="#FFFFFF">883,289 μs</td><td align="right" bgcolor="#FFFFFF">645,956 μs</td><td align="right" bgcolor="#FFFFFF">655,276 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,886 ms</td><td align="right" bgcolor="#FFFFFF">0,883 ms</td><td align="right" bgcolor="#FFFFFF">0,646 ms</td><td align="right" bgcolor="#FFFFFF">0,655 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">690,000</td><td align="right" bgcolor="#A8D08D">680,000 (Δ = -10,000)</td><td align="right" bgcolor="#FF4949">710,000 (Δ = +30,000)</td><td align="right" bgcolor="#FFFFFF">710,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">84,000</td><td align="right" bgcolor="#A8D08D">75,000 (Δ = -9,000)</td><td align="right" bgcolor="#FF4949">250,000 (Δ = +175,000)</td><td align="right" bgcolor="#A8D08D">208,000 (Δ = -42,000)</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#A8D08D">-13,1 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">437438,000</td><td align="right" bgcolor="#A8D08D">429274,000 (Δ = -8164,000)</td><td align="right" bgcolor="#A8D08D">372960,000 (Δ = -56314,000)</td><td align="right" bgcolor="#FF4949">373038,000 (Δ = +78,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">427,186</td><td align="right" bgcolor="#A8D08D">419,213 (Δ = -7,973)</td><td align="right" bgcolor="#A8D08D">364,219 (Δ = -54,994)</td><td align="right" bgcolor="#FF4949">364,295 (Δ = +0,076)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,417</td><td align="right" bgcolor="#A8D08D">0,409 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,356 (Δ = -0,054)</td><td align="right" bgcolor="#FF4949">0,356 (Δ = +0,000)</td></tr></table>


### <a name="Serialization_Xml_Benchmark_SerializeLevel3Models"></a>SerializeLevel3Models

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 387221,168 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,2 %</td><td align="right" bgcolor="#A8D08D">-11,9 %</td><td align="right" bgcolor="#FF4949">+2,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2790239,847 ns</td><td align="right" bgcolor="#A8D08D">2728339,555 ns (Δ = -61900,292 ns)</td><td align="right" bgcolor="#A8D08D">2403018,678 ns (Δ = -325320,877 ns)</td><td align="right" bgcolor="#FF4949">2454533,782 ns (Δ = +51515,103 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2790,240 μs</td><td align="right" bgcolor="#FFFFFF">2728,340 μs</td><td align="right" bgcolor="#A8D08D">2403,019 μs (Δ = -325,321 μs)</td><td align="right" bgcolor="#FFFFFF">2454,534 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">2,790 ms</td><td align="right" bgcolor="#FFFFFF">2,728 ms</td><td align="right" bgcolor="#FFFFFF">2,403 ms</td><td align="right" bgcolor="#FFFFFF">2,455 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 1</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">3065,000</td><td align="right" bgcolor="#A8D08D">3000,000 (Δ = -65,000)</td><td align="right" bgcolor="#FF4949">3170,000 (Δ = +170,000)</td><td align="right" bgcolor="#FFFFFF">3170,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">504,000</td><td align="right" bgcolor="#A8D08D">493,000 (Δ = -11,000)</td><td align="right" bgcolor="#A8D08D">477,000 (Δ = -16,000)</td><td align="right" bgcolor="#FFFFFF">477,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-2,0 %</td><td align="right" bgcolor="#A8D08D">-12,0 %</td><td align="right" bgcolor="#FF4949">+0,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1930923,000</td><td align="right" bgcolor="#A8D08D">1892587,000 (Δ = -38336,000)</td><td align="right" bgcolor="#A8D08D">1665854,000 (Δ = -226733,000)</td><td align="right" bgcolor="#FF4949">1666145,000 (Δ = +291,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1885,667</td><td align="right" bgcolor="#A8D08D">1848,229 (Δ = -37,438)</td><td align="right" bgcolor="#A8D08D">1626,811 (Δ = -221,419)</td><td align="right" bgcolor="#FF4949">1627,095 (Δ = +0,284)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">1,841</td><td align="right" bgcolor="#A8D08D">1,805 (Δ = -0,037)</td><td align="right" bgcolor="#A8D08D">1,589 (Δ = -0,216)</td><td align="right" bgcolor="#FF4949">1,589 (Δ = +0,000)</td></tr></table>


## <a name="ServiceLocator_Benchmark"></a>ServiceLocator_Benchmark

### <a name="ServiceLocator_Benchmark_RegisterType"></a>RegisterType

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 278,368 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">731,503 ns</td><td align="right" bgcolor="#FFFFFF">976,620 ns</td><td align="right" bgcolor="#FFFFFF">995,025 ns</td><td align="right" bgcolor="#FFFFFF">1009,872 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,732 μs</td><td align="right" bgcolor="#FFFFFF">0,977 μs</td><td align="right" bgcolor="#FFFFFF">0,995 μs</td><td align="right" bgcolor="#FFFFFF">1,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,3 %</td><td align="right" bgcolor="#A8D08D">-26,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1040,000</td><td align="right" bgcolor="#A8D08D">922,000 (Δ = -118,000)</td><td align="right" bgcolor="#A8D08D">676,000 (Δ = -246,000)</td><td align="right" bgcolor="#FFFFFF">676,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,016</td><td align="right" bgcolor="#A8D08D">0,900 (Δ = -0,115)</td><td align="right" bgcolor="#A8D08D">0,660 (Δ = -0,240)</td><td align="right" bgcolor="#FFFFFF">0,660</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Singleton"></a>ResolveType_Singleton

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 77,356 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">188,265 ns</td><td align="right" bgcolor="#FFFFFF">186,068 ns</td><td align="right" bgcolor="#FFFFFF">198,328 ns</td><td align="right" bgcolor="#FFFFFF">263,424 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,188 μs</td><td align="right" bgcolor="#FFFFFF">0,186 μs</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td><td align="right" bgcolor="#FFFFFF">0,263 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_Transient"></a>ResolveType_Transient

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 229,470 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2922,420 ns</td><td align="right" bgcolor="#FFFFFF">3042,325 ns</td><td align="right" bgcolor="#FFFFFF">2812,855 ns</td><td align="right" bgcolor="#FFFFFF">2925,085 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,922 μs</td><td align="right" bgcolor="#FFFFFF">3,042 μs</td><td align="right" bgcolor="#FFFFFF">2,813 μs</td><td align="right" bgcolor="#FFFFFF">2,925 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+0,6 %</td><td align="right" bgcolor="#A8D08D">-39,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1425,000</td><td align="right" bgcolor="#FF4949">1433,000 (Δ = +8,000)</td><td align="right" bgcolor="#A8D08D">867,000 (Δ = -566,000)</td><td align="right" bgcolor="#FFFFFF">867,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,392</td><td align="right" bgcolor="#FF4949">1,399 (Δ = +0,008)</td><td align="right" bgcolor="#A8D08D">0,847 (Δ = -0,553)</td><td align="right" bgcolor="#FFFFFF">0,847</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Singleton_Dependency"></a>ResolveType_With_Singleton_Dependency

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 15,322 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">192,572 ns</td><td align="right" bgcolor="#FFFFFF">186,440 ns</td><td align="right" bgcolor="#FFFFFF">198,030 ns</td><td align="right" bgcolor="#FFFFFF">201,762 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FFFFFF">0,186 μs</td><td align="right" bgcolor="#FFFFFF">0,198 μs</td><td align="right" bgcolor="#FFFFFF">0,202 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#FFFFFF">147,000</td><td align="right" bgcolor="#A8D08D">82,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">82,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#FFFFFF">0,144</td><td align="right" bgcolor="#A8D08D">0,080 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,080</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ServiceLocator_Benchmark_ResolveType_With_Transient_Dependency"></a>ResolveType_With_Transient_Dependency

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 890,418 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-12,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6626,312 ns</td><td align="right" bgcolor="#FFFFFF">6542,983 ns</td><td align="right" bgcolor="#A8D08D">5735,893 ns (Δ = -807,090 ns)</td><td align="right" bgcolor="#FFFFFF">5878,922 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">6,626 μs</td><td align="right" bgcolor="#FFFFFF">6,543 μs</td><td align="right" bgcolor="#FFFFFF">5,736 μs</td><td align="right" bgcolor="#FFFFFF">5,879 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td><td align="right" bgcolor="#FFFFFF">0,006 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-4,5 %</td><td align="right" bgcolor="#A8D08D">-40,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">3147,000</td><td align="right" bgcolor="#A8D08D">3004,000 (Δ = -143,000)</td><td align="right" bgcolor="#A8D08D">1794,000 (Δ = -1210,000)</td><td align="right" bgcolor="#FFFFFF">1794,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">3,073</td><td align="right" bgcolor="#A8D08D">2,934 (Δ = -0,140)</td><td align="right" bgcolor="#A8D08D">1,752 (Δ = -1,182)</td><td align="right" bgcolor="#FFFFFF">1,752</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,002</td></tr></table>


## <a name="TagHelper_Benchmark"></a>TagHelper_Benchmark

### <a name="TagHelper_Benchmark_AreTagsEqual"></a>AreTagsEqual

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 2,975 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,337 ns</td><td align="right" bgcolor="#FFFFFF">9,215 ns</td><td align="right" bgcolor="#FFFFFF">12,190 ns</td><td align="right" bgcolor="#FFFFFF">12,067 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="TagHelper_Benchmark_ToString_"></a>ToString_

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 709,282 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-1,9 %</td><td align="right" bgcolor="#A8D08D">-1,7 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20043,583 ns</td><td align="right" bgcolor="#FFFFFF">20123,882 ns</td><td align="right" bgcolor="#A8D08D">19749,062 ns (Δ = -374,820 ns)</td><td align="right" bgcolor="#A8D08D">19414,600 ns (Δ = -334,462 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">20,044 μs</td><td align="right" bgcolor="#FFFFFF">20,124 μs</td><td align="right" bgcolor="#FFFFFF">19,749 μs</td><td align="right" bgcolor="#FFFFFF">19,415 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,020 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">5.2.0</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#FFFFFF">15,000</td><td align="right" bgcolor="#A8D08D">10,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">10,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">10,000 (Δ = +10,000)</td><td align="right" bgcolor="#FFFFFF">10,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">10996,000</td><td align="right" bgcolor="#FFFFFF">10996,000</td><td align="right" bgcolor="#A8D08D">5526,000 (Δ = -5470,000)</td><td align="right" bgcolor="#FFFFFF">5526,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">10,738</td><td align="right" bgcolor="#FFFFFF">10,738</td><td align="right" bgcolor="#A8D08D">5,396 (Δ = -5,342)</td><td align="right" bgcolor="#FFFFFF">5,396</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#FFFFFF">0,010</td><td align="right" bgcolor="#A8D08D">0,005 (Δ = -0,005)</td><td align="right" bgcolor="#FFFFFF">0,005</td></tr></table>


## <a name="Type_ReflectionExtensions_Benchmark"></a>Type_ReflectionExtensions_Benchmark

### <a name="Type_ReflectionExtensions_Benchmark_ContainsGenericParametersEx"></a>ContainsGenericParametersEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 5,167 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">27,582 ns</td><td align="right" bgcolor="#FFFFFF">25,672 ns</td><td align="right" bgcolor="#FFFFFF">30,838 ns</td><td align="right" bgcolor="#FFFFFF">29,298 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,031 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyEx"></a>GetAssemblyEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 7,718 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">18,452 ns</td><td align="right" bgcolor="#FFFFFF">17,598 ns</td><td align="right" bgcolor="#FFFFFF">25,235 ns</td><td align="right" bgcolor="#FFFFFF">25,317 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetAssemblyFullNameEx"></a>GetAssemblyFullNameEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 8,352 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,773 ns</td><td align="right" bgcolor="#FFFFFF">20,652 ns</td><td align="right" bgcolor="#FFFFFF">28,747 ns</td><td align="right" bgcolor="#FFFFFF">29,003 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetBaseTypeEx"></a>GetBaseTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 6,732 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">27,808 ns</td><td align="right" bgcolor="#FFFFFF">27,117 ns</td><td align="right" bgcolor="#FFFFFF">33,283 ns</td><td align="right" bgcolor="#FFFFFF">33,848 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorEx"></a>GetConstructorEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 39,837 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">261,690 ns</td><td align="right" bgcolor="#FFFFFF">266,373 ns</td><td align="right" bgcolor="#FFFFFF">300,567 ns</td><td align="right" bgcolor="#FFFFFF">301,527 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,262 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td><td align="right" bgcolor="#FFFFFF">0,301 μs</td><td align="right" bgcolor="#FFFFFF">0,302 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#FFFFFF">131,000</td><td align="right" bgcolor="#A8D08D">66,000 (Δ = -65,000)</td><td align="right" bgcolor="#FFFFFF">66,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#FFFFFF">0,128</td><td align="right" bgcolor="#A8D08D">0,064 (Δ = -0,063)</td><td align="right" bgcolor="#FFFFFF">0,064</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetConstructorsEx"></a>GetConstructorsEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 7,060 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">81,315 ns</td><td align="right" bgcolor="#FFFFFF">78,487 ns</td><td align="right" bgcolor="#FFFFFF">74,255 ns</td><td align="right" bgcolor="#FFFFFF">77,040 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,081 μs</td><td align="right" bgcolor="#FFFFFF">0,078 μs</td><td align="right" bgcolor="#FFFFFF">0,074 μs</td><td align="right" bgcolor="#FFFFFF">0,077 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx"></a>GetCustomAttributeEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 275,225 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3299,873 ns</td><td align="right" bgcolor="#FFFFFF">3346,322 ns</td><td align="right" bgcolor="#FFFFFF">3565,473 ns</td><td align="right" bgcolor="#FFFFFF">3575,098 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,300 μs</td><td align="right" bgcolor="#FFFFFF">3,346 μs</td><td align="right" bgcolor="#FFFFFF">3,565 μs</td><td align="right" bgcolor="#FFFFFF">3,575 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributeEx_Inherit"></a>GetCustomAttributeEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 2450,109 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,6 %</td><td align="right" bgcolor="#FF4949">+20,1 %</td><td align="right" bgcolor="#A8D08D">-4,1 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8073,847 ns</td><td align="right" bgcolor="#FF4949">8764,255 ns (Δ = +690,408 ns)</td><td align="right" bgcolor="#FF4949">10523,956 ns (Δ = +1759,701 ns)</td><td align="right" bgcolor="#A8D08D">10094,097 ns (Δ = -429,859 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,074 μs</td><td align="right" bgcolor="#FFFFFF">8,764 μs</td><td align="right" bgcolor="#FFFFFF">10,524 μs</td><td align="right" bgcolor="#FFFFFF">10,094 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,011 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +49,000)</td><td align="right" bgcolor="#A8D08D">410,000 (Δ = -401,000)</td><td align="right" bgcolor="#FFFFFF">410,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,048)</td><td align="right" bgcolor="#A8D08D">0,400 (Δ = -0,392)</td><td align="right" bgcolor="#FFFFFF">0,400</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx"></a>GetCustomAttributesEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 621,278 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+18,2 %</td><td align="right" bgcolor="#A8D08D">-8,9 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3286,088 ns</td><td align="right" bgcolor="#FFFFFF">3306,412 ns</td><td align="right" bgcolor="#FF4949">3907,367 ns (Δ = +600,955 ns)</td><td align="right" bgcolor="#A8D08D">3560,538 ns (Δ = -346,828 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,286 μs</td><td align="right" bgcolor="#FFFFFF">3,306 μs</td><td align="right" bgcolor="#FFFFFF">3,907 μs</td><td align="right" bgcolor="#FFFFFF">3,561 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td><td align="right" bgcolor="#FFFFFF">0,004 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#FFFFFF">283,000</td><td align="right" bgcolor="#A8D08D">143,000 (Δ = -140,000)</td><td align="right" bgcolor="#FFFFFF">143,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#FFFFFF">0,276</td><td align="right" bgcolor="#A8D08D">0,140 (Δ = -0,137)</td><td align="right" bgcolor="#FFFFFF">0,140</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetCustomAttributesEx_Inherit"></a>GetCustomAttributesEx_Inherit

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1984,007 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+8,9 %</td><td align="right" bgcolor="#FF4949">+14,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8048,457 ns</td><td align="right" bgcolor="#FF4949">8765,020 ns (Δ = +716,563 ns)</td><td align="right" bgcolor="#FF4949">10032,463 ns (Δ = +1267,443 ns)</td><td align="right" bgcolor="#FFFFFF">9959,765 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">8,048 μs</td><td align="right" bgcolor="#FFFFFF">8,765 μs</td><td align="right" bgcolor="#FFFFFF">10,032 μs</td><td align="right" bgcolor="#FFFFFF">9,960 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,008 ms</td><td align="right" bgcolor="#FFFFFF">0,009 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td><td align="right" bgcolor="#FFFFFF">0,010 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+6,4 %</td><td align="right" bgcolor="#A8D08D">-49,4 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">762,000</td><td align="right" bgcolor="#FF4949">811,000 (Δ = +49,000)</td><td align="right" bgcolor="#A8D08D">410,000 (Δ = -401,000)</td><td align="right" bgcolor="#FFFFFF">410,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,744</td><td align="right" bgcolor="#FF4949">0,792 (Δ = +0,048)</td><td align="right" bgcolor="#A8D08D">0,400 (Δ = -0,392)</td><td align="right" bgcolor="#FFFFFF">0,400</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetElementTypeEx"></a>GetElementTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 1,228 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,298 ns</td><td align="right" bgcolor="#FFFFFF">7,137 ns</td><td align="right" bgcolor="#FFFFFF">8,263 ns</td><td align="right" bgcolor="#FFFFFF">8,365 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Flatten_Static"></a>GetEventEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 92,282 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">706,340 ns</td><td align="right" bgcolor="#FFFFFF">746,803 ns</td><td align="right" bgcolor="#FFFFFF">654,522 ns</td><td align="right" bgcolor="#FFFFFF">658,452 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,706 μs</td><td align="right" bgcolor="#FFFFFF">0,747 μs</td><td align="right" bgcolor="#FFFFFF">0,655 μs</td><td align="right" bgcolor="#FFFFFF">0,658 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td><td align="right" bgcolor="#FFFFFF">123,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td><td align="right" bgcolor="#FFFFFF">0,120</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Instance"></a>GetEventEx_Instance

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 8,985 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">105,152 ns</td><td align="right" bgcolor="#FFFFFF">98,367 ns</td><td align="right" bgcolor="#FFFFFF">99,338 ns</td><td align="right" bgcolor="#FFFFFF">96,167 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,098 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventEx_Static_BindingFlags"></a>GetEventEx_Static_BindingFlags

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 325,157 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2732,770 ns</td><td align="right" bgcolor="#A8D08D">2433,402 ns (Δ = -299,368 ns)</td><td align="right" bgcolor="#FFFFFF">2436,727 ns</td><td align="right" bgcolor="#FFFFFF">2407,613 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,733 μs</td><td align="right" bgcolor="#FFFFFF">2,433 μs</td><td align="right" bgcolor="#FFFFFF">2,437 μs</td><td align="right" bgcolor="#FFFFFF">2,408 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,7 %</td><td align="right" bgcolor="#A8D08D">-49,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -24,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -99,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,023)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,097)</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Flatten_Static"></a>GetEventsEx_Flatten_Static

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 206,293 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1193,715 ns</td><td align="right" bgcolor="#FFFFFF">1059,870 ns</td><td align="right" bgcolor="#FFFFFF">987,578 ns</td><td align="right" bgcolor="#FFFFFF">987,422 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,194 μs</td><td align="right" bgcolor="#FFFFFF">1,060 μs</td><td align="right" bgcolor="#FFFFFF">0,988 μs</td><td align="right" bgcolor="#FFFFFF">0,987 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-15,6 %</td><td align="right" bgcolor="#A8D08D">-49,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">475,000</td><td align="right" bgcolor="#A8D08D">401,000 (Δ = -74,000)</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -200,000)</td><td align="right" bgcolor="#FFFFFF">201,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,464</td><td align="right" bgcolor="#A8D08D">0,392 (Δ = -0,072)</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,195)</td><td align="right" bgcolor="#FFFFFF">0,196</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetEventsEx_Instance"></a>GetEventsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 171,432 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">600,048 ns</td><td align="right" bgcolor="#FFFFFF">428,617 ns</td><td align="right" bgcolor="#FFFFFF">470,420 ns</td><td align="right" bgcolor="#FFFFFF">467,347 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,600 μs</td><td align="right" bgcolor="#FFFFFF">0,429 μs</td><td align="right" bgcolor="#FFFFFF">0,470 μs</td><td align="right" bgcolor="#FFFFFF">0,467 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-32,8 %</td><td align="right" bgcolor="#A8D08D">-49,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">451,000</td><td align="right" bgcolor="#A8D08D">303,000 (Δ = -148,000)</td><td align="right" bgcolor="#A8D08D">152,000 (Δ = -151,000)</td><td align="right" bgcolor="#FFFFFF">152,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,440</td><td align="right" bgcolor="#A8D08D">0,296 (Δ = -0,145)</td><td align="right" bgcolor="#A8D08D">0,148 (Δ = -0,147)</td><td align="right" bgcolor="#FFFFFF">0,148</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static"></a>GetFieldEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 77,785 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">719,128 ns</td><td align="right" bgcolor="#FFFFFF">744,053 ns</td><td align="right" bgcolor="#FFFFFF">666,268 ns</td><td align="right" bgcolor="#FFFFFF">667,325 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,719 μs</td><td align="right" bgcolor="#FFFFFF">0,744 μs</td><td align="right" bgcolor="#FFFFFF">0,666 μs</td><td align="right" bgcolor="#FFFFFF">0,667 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td><td align="right" bgcolor="#FFFFFF">123,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td><td align="right" bgcolor="#FFFFFF">0,120</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Flatten_Static_BindingFlags"></a>GetFieldEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 6,232 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">100,078 ns</td><td align="right" bgcolor="#FFFFFF">97,237 ns</td><td align="right" bgcolor="#FFFFFF">94,555 ns</td><td align="right" bgcolor="#FFFFFF">100,787 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,097 μs</td><td align="right" bgcolor="#FFFFFF">0,095 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance"></a>GetFieldEx_Instance

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 2,807 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">108,130 ns</td><td align="right" bgcolor="#FFFFFF">110,213 ns</td><td align="right" bgcolor="#FFFFFF">107,407 ns</td><td align="right" bgcolor="#FFFFFF">107,992 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,110 μs</td><td align="right" bgcolor="#FFFFFF">0,107 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldEx_Instance_BindingFlags"></a>GetFieldEx_Instance_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 3,133 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">98,760 ns</td><td align="right" bgcolor="#FFFFFF">98,883 ns</td><td align="right" bgcolor="#FFFFFF">96,442 ns</td><td align="right" bgcolor="#FFFFFF">99,575 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,099 μs</td><td align="right" bgcolor="#FFFFFF">0,096 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx"></a>GetFieldsEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 50,623 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">531,685 ns</td><td align="right" bgcolor="#FFFFFF">579,412 ns</td><td align="right" bgcolor="#FFFFFF">575,480 ns</td><td align="right" bgcolor="#FFFFFF">582,308 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,532 μs</td><td align="right" bgcolor="#FFFFFF">0,579 μs</td><td align="right" bgcolor="#FFFFFF">0,575 μs</td><td align="right" bgcolor="#FFFFFF">0,582 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,0 %</td><td align="right" bgcolor="#A8D08D">-44,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">274,000</td><td align="right" bgcolor="#FF4949">315,000 (Δ = +41,000)</td><td align="right" bgcolor="#A8D08D">176,000 (Δ = -139,000)</td><td align="right" bgcolor="#FFFFFF">176,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,268</td><td align="right" bgcolor="#FF4949">0,308 (Δ = +0,040)</td><td align="right" bgcolor="#A8D08D">0,172 (Δ = -0,136)</td><td align="right" bgcolor="#FFFFFF">0,172</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_BindingFlags"></a>GetFieldsEx_BindingFlags

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 9,820 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">92,953 ns</td><td align="right" bgcolor="#FFFFFF">102,773 ns</td><td align="right" bgcolor="#FFFFFF">101,650 ns</td><td align="right" bgcolor="#FFFFFF">100,960 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,093 μs</td><td align="right" bgcolor="#FFFFFF">0,103 μs</td><td align="right" bgcolor="#FFFFFF">0,102 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static"></a>GetFieldsEx_Static

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 86,127 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">855,145 ns</td><td align="right" bgcolor="#FFFFFF">913,815 ns</td><td align="right" bgcolor="#FFFFFF">939,360 ns</td><td align="right" bgcolor="#FFFFFF">941,272 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,855 μs</td><td align="right" bgcolor="#FFFFFF">0,914 μs</td><td align="right" bgcolor="#FFFFFF">0,939 μs</td><td align="right" bgcolor="#FFFFFF">0,941 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+7,2 %</td><td align="right" bgcolor="#A8D08D">-44,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#FF4949">356,000 (Δ = +24,000)</td><td align="right" bgcolor="#A8D08D">197,000 (Δ = -159,000)</td><td align="right" bgcolor="#FFFFFF">197,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#FF4949">0,348 (Δ = +0,023)</td><td align="right" bgcolor="#A8D08D">0,192 (Δ = -0,155)</td><td align="right" bgcolor="#FFFFFF">0,192</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetFieldsEx_Static_BindingFlags"></a>GetFieldsEx_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 1,568 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">100,876 ns</td><td align="right" bgcolor="#FFFFFF">99,557 ns</td><td align="right" bgcolor="#FFFFFF">100,902 ns</td><td align="right" bgcolor="#FFFFFF">101,125 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,100 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td><td align="right" bgcolor="#FFFFFF">0,101 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericArgumentsEx"></a>GetGenericArgumentsEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 81,832 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">156,870 ns</td><td align="right" bgcolor="#FFFFFF">155,718 ns</td><td align="right" bgcolor="#FFFFFF">237,550 ns</td><td align="right" bgcolor="#FFFFFF">231,178 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,157 μs</td><td align="right" bgcolor="#FFFFFF">0,156 μs</td><td align="right" bgcolor="#FFFFFF">0,238 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetGenericTypeDefinitionEx"></a>GetGenericTypeDefinitionEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 52,227 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">93,897 ns</td><td align="right" bgcolor="#FFFFFF">146,123 ns</td><td align="right" bgcolor="#FFFFFF">107,611 ns</td><td align="right" bgcolor="#FFFFFF">106,371 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,094 μs</td><td align="right" bgcolor="#FFFFFF">0,146 μs</td><td align="right" bgcolor="#FFFFFF">0,108 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetInterfacesEx"></a>GetInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 8,152 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">151,125 ns</td><td align="right" bgcolor="#FFFFFF">142,973 ns</td><td align="right" bgcolor="#FFFFFF">144,562 ns</td><td align="right" bgcolor="#FFFFFF">144,487 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,151 μs</td><td align="right" bgcolor="#FFFFFF">0,143 μs</td><td align="right" bgcolor="#FFFFFF">0,145 μs</td><td align="right" bgcolor="#FFFFFF">0,144 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-9,2 %</td><td align="right" bgcolor="#A8D08D">-50,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">217,000</td><td align="right" bgcolor="#A8D08D">197,000 (Δ = -20,000)</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -99,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,212</td><td align="right" bgcolor="#A8D08D">0,192 (Δ = -0,020)</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,097)</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static"></a>GetMemberEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 187,222 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1360,895 ns</td><td align="right" bgcolor="#FFFFFF">1394,667 ns</td><td align="right" bgcolor="#FFFFFF">1207,445 ns</td><td align="right" bgcolor="#FFFFFF">1213,600 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,361 μs</td><td align="right" bgcolor="#FFFFFF">1,395 μs</td><td align="right" bgcolor="#FFFFFF">1,207 μs</td><td align="right" bgcolor="#FFFFFF">1,214 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#FFFFFF">266,000</td><td align="right" bgcolor="#A8D08D">135,000 (Δ = -131,000)</td><td align="right" bgcolor="#FFFFFF">135,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#FFFFFF">0,260</td><td align="right" bgcolor="#A8D08D">0,132 (Δ = -0,128)</td><td align="right" bgcolor="#FFFFFF">0,132</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Flatten_Static_BindingFlags"></a>GetMemberEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 21,295 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">643,902 ns</td><td align="right" bgcolor="#FFFFFF">629,125 ns</td><td align="right" bgcolor="#FFFFFF">635,827 ns</td><td align="right" bgcolor="#FFFFFF">650,420 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,644 μs</td><td align="right" bgcolor="#FFFFFF">0,629 μs</td><td align="right" bgcolor="#FFFFFF">0,636 μs</td><td align="right" bgcolor="#FFFFFF">0,650 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance"></a>GetMemberEx_Instance

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 32,308 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">620,982 ns</td><td align="right" bgcolor="#FFFFFF">628,020 ns</td><td align="right" bgcolor="#FFFFFF">642,505 ns</td><td align="right" bgcolor="#FFFFFF">653,290 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,621 μs</td><td align="right" bgcolor="#FFFFFF">0,628 μs</td><td align="right" bgcolor="#FFFFFF">0,643 μs</td><td align="right" bgcolor="#FFFFFF">0,653 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#FFFFFF">37,000</td><td align="right" bgcolor="#A8D08D">20,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">20,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#FFFFFF">0,036</td><td align="right" bgcolor="#A8D08D">0,020 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,020</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMemberEx_Instance_BindingFlags"></a>GetMemberEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 25,825 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">602,495 ns</td><td align="right" bgcolor="#FFFFFF">596,560 ns</td><td align="right" bgcolor="#FFFFFF">612,275 ns</td><td align="right" bgcolor="#FFFFFF">622,385 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,602 μs</td><td align="right" bgcolor="#FFFFFF">0,597 μs</td><td align="right" bgcolor="#FFFFFF">0,612 μs</td><td align="right" bgcolor="#FFFFFF">0,622 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#FFFFFF">29,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -13,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#FFFFFF">0,028</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,013)</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static"></a>GetMethodEx_Flatten_Static

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 149,673 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">786,738 ns</td><td align="right" bgcolor="#FFFFFF">839,953 ns</td><td align="right" bgcolor="#FFFFFF">798,282 ns</td><td align="right" bgcolor="#FFFFFF">690,280 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,787 μs</td><td align="right" bgcolor="#FFFFFF">0,840 μs</td><td align="right" bgcolor="#FFFFFF">0,798 μs</td><td align="right" bgcolor="#FFFFFF">0,690 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td><td align="right" bgcolor="#FFFFFF">123,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td><td align="right" bgcolor="#FFFFFF">0,120</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Flatten_Static_BindingFlags"></a>GetMethodEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 4,228 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">123,658 ns</td><td align="right" bgcolor="#FFFFFF">121,987 ns</td><td align="right" bgcolor="#FFFFFF">121,402 ns</td><td align="right" bgcolor="#FFFFFF">125,630 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,124 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,126 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance"></a>GetMethodEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 4,333 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">137,532 ns</td><td align="right" bgcolor="#FFFFFF">133,198 ns</td><td align="right" bgcolor="#FFFFFF">134,155 ns</td><td align="right" bgcolor="#FFFFFF">134,642 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,138 μs</td><td align="right" bgcolor="#FFFFFF">0,133 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td><td align="right" bgcolor="#FFFFFF">0,135 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodEx_Instance_BindingFlags"></a>GetMethodEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 6,072 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">124,922 ns</td><td align="right" bgcolor="#FFFFFF">121,140 ns</td><td align="right" bgcolor="#FFFFFF">125,270 ns</td><td align="right" bgcolor="#FFFFFF">127,212 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">0,125 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static"></a>GetMethodsEx_Flatten_Static

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2164,415 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-29,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7346,365 ns</td><td align="right" bgcolor="#A8D08D">5181,950 ns (Δ = -2164,415 ns)</td><td align="right" bgcolor="#FFFFFF">5413,087 ns</td><td align="right" bgcolor="#FFFFFF">5488,113 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,346 μs</td><td align="right" bgcolor="#FFFFFF">5,182 μs</td><td align="right" bgcolor="#FFFFFF">5,413 μs</td><td align="right" bgcolor="#FFFFFF">5,488 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-30,5 %</td><td align="right" bgcolor="#A8D08D">-49,0 %</td><td align="right" bgcolor="#FF4949">+0,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">2945,000</td><td align="right" bgcolor="#A8D08D">2048,000 (Δ = -897,000)</td><td align="right" bgcolor="#A8D08D">1044,000 (Δ = -1004,000)</td><td align="right" bgcolor="#FF4949">1053,000 (Δ = +9,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">2,876</td><td align="right" bgcolor="#A8D08D">2,000 (Δ = -0,876)</td><td align="right" bgcolor="#A8D08D">1,020 (Δ = -0,980)</td><td align="right" bgcolor="#FF4949">1,028 (Δ = +0,009)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,003</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,001)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Flatten_Static_BindingFlags"></a>GetMethodsEx_Flatten_Static_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 413,437 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,4 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1317,397 ns</td><td align="right" bgcolor="#A8D08D">903,960 ns (Δ = -413,437 ns)</td><td align="right" bgcolor="#FFFFFF">1057,173 ns</td><td align="right" bgcolor="#FFFFFF">1059,178 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,317 μs</td><td align="right" bgcolor="#FFFFFF">0,904 μs</td><td align="right" bgcolor="#FFFFFF">1,057 μs</td><td align="right" bgcolor="#FFFFFF">1,059 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance"></a>GetMethodsEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 2368,890 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,5 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7076,295 ns</td><td align="right" bgcolor="#A8D08D">4707,405 ns (Δ = -2368,890 ns)</td><td align="right" bgcolor="#FFFFFF">4861,307 ns</td><td align="right" bgcolor="#FFFFFF">4941,388 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">7,076 μs</td><td align="right" bgcolor="#FFFFFF">4,707 μs</td><td align="right" bgcolor="#FFFFFF">4,861 μs</td><td align="right" bgcolor="#FFFFFF">4,941 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,007 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td><td align="right" bgcolor="#FFFFFF">0,005 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-31,9 %</td><td align="right" bgcolor="#A8D08D">-48,8 %</td><td align="right" bgcolor="#FF4949">+0,9 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">5093,000</td><td align="right" bgcolor="#A8D08D">3466,000 (Δ = -1627,000)</td><td align="right" bgcolor="#A8D08D">1774,000 (Δ = -1692,000)</td><td align="right" bgcolor="#FF4949">1790,000 (Δ = +16,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">4,974</td><td align="right" bgcolor="#A8D08D">3,385 (Δ = -1,589)</td><td align="right" bgcolor="#A8D08D">1,732 (Δ = -1,652)</td><td align="right" bgcolor="#FF4949">1,748 (Δ = +0,016)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,005</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,002 (Δ = -0,002)</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetMethodsEx_Instance_BindingFlags"></a>GetMethodsEx_Instance_BindingFlags

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 447,992 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-33,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1358,647 ns</td><td align="right" bgcolor="#A8D08D">910,655 ns (Δ = -447,992 ns)</td><td align="right" bgcolor="#FFFFFF">1054,993 ns</td><td align="right" bgcolor="#FFFFFF">1061,682 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,359 μs</td><td align="right" bgcolor="#FFFFFF">0,911 μs</td><td align="right" bgcolor="#FFFFFF">1,055 μs</td><td align="right" bgcolor="#FFFFFF">1,062 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-36,0 %</td><td align="right" bgcolor="#A8D08D">-25,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">25,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -9,000)</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">12,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,024</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,009)</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,012</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetParentTypes"></a>GetParentTypes

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 230,143 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">712,935 ns</td><td align="right" bgcolor="#FFFFFF">707,392 ns</td><td align="right" bgcolor="#FFFFFF">879,968 ns</td><td align="right" bgcolor="#FFFFFF">937,535 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,713 μs</td><td align="right" bgcolor="#FFFFFF">0,707 μs</td><td align="right" bgcolor="#FFFFFF">0,880 μs</td><td align="right" bgcolor="#FFFFFF">0,938 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-8,6 %</td><td align="right" bgcolor="#A8D08D">-47,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">291,000</td><td align="right" bgcolor="#A8D08D">266,000 (Δ = -25,000)</td><td align="right" bgcolor="#A8D08D">139,000 (Δ = -127,000)</td><td align="right" bgcolor="#FFFFFF">139,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,284</td><td align="right" bgcolor="#A8D08D">0,260 (Δ = -0,024)</td><td align="right" bgcolor="#A8D08D">0,136 (Δ = -0,124)</td><td align="right" bgcolor="#FFFFFF">0,136</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Flatten_Static"></a>GetPropertiesEx_Flatten_Static

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 304,807 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">1583,018 ns</td><td align="right" bgcolor="#FFFFFF">1335,068 ns</td><td align="right" bgcolor="#FFFFFF">1297,455 ns</td><td align="right" bgcolor="#FFFFFF">1278,212 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">1,583 μs</td><td align="right" bgcolor="#FFFFFF">1,335 μs</td><td align="right" bgcolor="#FFFFFF">1,297 μs</td><td align="right" bgcolor="#FFFFFF">1,278 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-16,9 %</td><td align="right" bgcolor="#A8D08D">-50,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">651,000</td><td align="right" bgcolor="#A8D08D">541,000 (Δ = -110,000)</td><td align="right" bgcolor="#A8D08D">270,000 (Δ = -271,000)</td><td align="right" bgcolor="#FFFFFF">270,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,636</td><td align="right" bgcolor="#A8D08D">0,528 (Δ = -0,107)</td><td align="right" bgcolor="#A8D08D">0,264 (Δ = -0,265)</td><td align="right" bgcolor="#FFFFFF">0,264</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Instance"></a>GetPropertiesEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 188,457 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">898,933 ns</td><td align="right" bgcolor="#FFFFFF">710,477 ns</td><td align="right" bgcolor="#FFFFFF">735,385 ns</td><td align="right" bgcolor="#FFFFFF">734,183 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,899 μs</td><td align="right" bgcolor="#FFFFFF">0,710 μs</td><td align="right" bgcolor="#FFFFFF">0,735 μs</td><td align="right" bgcolor="#FFFFFF">0,734 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,7 %</td><td align="right" bgcolor="#A8D08D">-49,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">721,000</td><td align="right" bgcolor="#A8D08D">557,000 (Δ = -164,000)</td><td align="right" bgcolor="#A8D08D">279,000 (Δ = -278,000)</td><td align="right" bgcolor="#FFFFFF">279,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,704</td><td align="right" bgcolor="#A8D08D">0,544 (Δ = -0,160)</td><td align="right" bgcolor="#A8D08D">0,272 (Δ = -0,271)</td><td align="right" bgcolor="#FFFFFF">0,272</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertiesEx_Static_BindingFlags"></a>GetPropertiesEx_Static_BindingFlags

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 25,733 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">193,115 ns</td><td align="right" bgcolor="#FFFFFF">172,282 ns</td><td align="right" bgcolor="#FFFFFF">167,593 ns</td><td align="right" bgcolor="#FFFFFF">167,382 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FFFFFF">0,172 μs</td><td align="right" bgcolor="#FFFFFF">0,168 μs</td><td align="right" bgcolor="#FFFFFF">0,167 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-40,0 %</td><td align="right" bgcolor="#A8D08D">-33,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">20,000</td><td align="right" bgcolor="#A8D08D">12,000 (Δ = -8,000)</td><td align="right" bgcolor="#A8D08D">8,000 (Δ = -4,000)</td><td align="right" bgcolor="#FFFFFF">8,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,020</td><td align="right" bgcolor="#A8D08D">0,012 (Δ = -0,008)</td><td align="right" bgcolor="#A8D08D">0,008 (Δ = -0,004)</td><td align="right" bgcolor="#FFFFFF">0,008</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Flatten_Static"></a>GetPropertyEx_Flatten_Static

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 92,152 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">777,575 ns</td><td align="right" bgcolor="#FFFFFF">771,010 ns</td><td align="right" bgcolor="#FFFFFF">685,423 ns</td><td align="right" bgcolor="#FFFFFF">688,517 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,778 μs</td><td align="right" bgcolor="#FFFFFF">0,771 μs</td><td align="right" bgcolor="#FFFFFF">0,685 μs</td><td align="right" bgcolor="#FFFFFF">0,689 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-49,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#FFFFFF">242,000</td><td align="right" bgcolor="#A8D08D">123,000 (Δ = -119,000)</td><td align="right" bgcolor="#FFFFFF">123,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#FFFFFF">0,236</td><td align="right" bgcolor="#A8D08D">0,120 (Δ = -0,116)</td><td align="right" bgcolor="#FFFFFF">0,120</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Instance"></a>GetPropertyEx_Instance

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 8,553 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">140,518 ns</td><td align="right" bgcolor="#FFFFFF">131,965 ns</td><td align="right" bgcolor="#FFFFFF">137,440 ns</td><td align="right" bgcolor="#FFFFFF">134,043 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,141 μs</td><td align="right" bgcolor="#FFFFFF">0,132 μs</td><td align="right" bgcolor="#FFFFFF">0,137 μs</td><td align="right" bgcolor="#FFFFFF">0,134 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td><td align="right" bgcolor="#FFFFFF">0,004</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetPropertyEx_Static_BindingFlags"></a>GetPropertyEx_Static_BindingFlags

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 343,507 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,0 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2798,753 ns</td><td align="right" bgcolor="#A8D08D">2492,127 ns (Δ = -306,627 ns)</td><td align="right" bgcolor="#FFFFFF">2455,246 ns</td><td align="right" bgcolor="#FFFFFF">2479,675 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,799 μs</td><td align="right" bgcolor="#FFFFFF">2,492 μs</td><td align="right" bgcolor="#FFFFFF">2,455 μs</td><td align="right" bgcolor="#FFFFFF">2,480 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-10,7 %</td><td align="right" bgcolor="#A8D08D">-49,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">225,000</td><td align="right" bgcolor="#A8D08D">201,000 (Δ = -24,000)</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -99,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,220</td><td align="right" bgcolor="#A8D08D">0,196 (Δ = -0,023)</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,097)</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetSafeFullName"></a>GetSafeFullName

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 94,005 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">168,512 ns</td><td align="right" bgcolor="#FFFFFF">176,423 ns</td><td align="right" bgcolor="#FFFFFF">248,355 ns</td><td align="right" bgcolor="#FFFFFF">262,517 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,169 μs</td><td align="right" bgcolor="#FFFFFF">0,176 μs</td><td align="right" bgcolor="#FFFFFF">0,248 μs</td><td align="right" bgcolor="#FFFFFF">0,263 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-3,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#FFFFFF">307,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -12,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#FFFFFF">0,300</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,012)</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_GetTypeInfo"></a>GetTypeInfo

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 2,573 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,810 ns</td><td align="right" bgcolor="#FFFFFF">11,655 ns</td><td align="right" bgcolor="#FFFFFF">14,068 ns</td><td align="right" bgcolor="#FFFFFF">14,228 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_HasBaseTypeEx"></a>HasBaseTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 8,190 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">33,017 ns</td><td align="right" bgcolor="#FFFFFF">31,862 ns</td><td align="right" bgcolor="#FFFFFF">39,437 ns</td><td align="right" bgcolor="#FFFFFF">40,052 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,033 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,040 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfaceEx"></a>ImplementsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 8,407 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">38,887 ns</td><td align="right" bgcolor="#FFFFFF">37,260 ns</td><td align="right" bgcolor="#FFFFFF">45,667 ns</td><td align="right" bgcolor="#FFFFFF">45,307 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,039 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,045 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_ImplementsInterfacesEx"></a>ImplementsInterfacesEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 9,542 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35,235 ns</td><td align="right" bgcolor="#FFFFFF">32,223 ns</td><td align="right" bgcolor="#FFFFFF">38,337 ns</td><td align="right" bgcolor="#FFFFFF">41,765 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,032 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,042 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsAbstractEx"></a>IsAbstractEx

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 2,175 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,537 ns</td><td align="right" bgcolor="#FFFFFF">14,588 ns</td><td align="right" bgcolor="#FFFFFF">13,057 ns</td><td align="right" bgcolor="#FFFFFF">12,413 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsArrayEx"></a>IsArrayEx

#### Performance

Fastest: **5.3.0**

Slowest: 5.2.0

Δ: 0,672 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">20,020 ns</td><td align="right" bgcolor="#FFFFFF">20,038 ns</td><td align="right" bgcolor="#FFFFFF">20,515 ns</td><td align="right" bgcolor="#FFFFFF">19,843 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td><td align="right" bgcolor="#FFFFFF">0,021 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsAssignableFromEx"></a>IsAssignableFromEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 9,100 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">24,698 ns</td><td align="right" bgcolor="#FFFFFF">25,260 ns</td><td align="right" bgcolor="#FFFFFF">29,778 ns</td><td align="right" bgcolor="#FFFFFF">33,798 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,025 μs</td><td align="right" bgcolor="#FFFFFF">0,030 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsCatelType"></a>IsCatelType

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 71,276 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">447,050 ns</td><td align="right" bgcolor="#FFFFFF">446,985 ns</td><td align="right" bgcolor="#FFFFFF">505,458 ns</td><td align="right" bgcolor="#FFFFFF">518,262 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,447 μs</td><td align="right" bgcolor="#FFFFFF">0,447 μs</td><td align="right" bgcolor="#FFFFFF">0,505 μs</td><td align="right" bgcolor="#FFFFFF">0,518 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsClassEx"></a>IsClassEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 68,728 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">139,047 ns</td><td align="right" bgcolor="#FFFFFF">173,330 ns</td><td align="right" bgcolor="#FFFFFF">207,775 ns</td><td align="right" bgcolor="#FFFFFF">207,082 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,139 μs</td><td align="right" bgcolor="#FFFFFF">0,173 μs</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,207 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsCOMObjectEx"></a>IsCOMObjectEx

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 9,035 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">25,843 ns</td><td align="right" bgcolor="#FFFFFF">34,878 ns</td><td align="right" bgcolor="#FFFFFF">26,057 ns</td><td align="right" bgcolor="#FFFFFF">27,807 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,035 μs</td><td align="right" bgcolor="#FFFFFF">0,026 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsEnumEx"></a>IsEnumEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 9,070 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,342 ns</td><td align="right" bgcolor="#FFFFFF">28,997 ns</td><td align="right" bgcolor="#FFFFFF">38,067 ns</td><td align="right" bgcolor="#FFFFFF">36,447 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,038 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeDefinitionEx"></a>IsGenericTypeDefinitionEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 2,407 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">8,613 ns</td><td align="right" bgcolor="#FFFFFF">8,438 ns</td><td align="right" bgcolor="#FFFFFF">10,845 ns</td><td align="right" bgcolor="#FFFFFF">10,032 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsGenericTypeEx"></a>IsGenericTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 2,120 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">9,522 ns</td><td align="right" bgcolor="#FFFFFF">9,448 ns</td><td align="right" bgcolor="#FFFFFF">11,208 ns</td><td align="right" bgcolor="#FFFFFF">11,568 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,010 μs</td><td align="right" bgcolor="#FFFFFF">0,009 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInstanceOfTypeEx"></a>IsInstanceOfTypeEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 20205,395 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,2 %</td><td align="right" bgcolor="#A8D08D">-13,1 %</td><td align="right" bgcolor="#FF4949">+5,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">35099,057 ns</td><td align="right" bgcolor="#A8D08D">17135,690 ns (Δ = -17963,367 ns)</td><td align="right" bgcolor="#A8D08D">14893,662 ns (Δ = -2242,028 ns)</td><td align="right" bgcolor="#FF4949">15642,961 ns (Δ = +749,299 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">35,099 μs</td><td align="right" bgcolor="#FFFFFF">17,136 μs</td><td align="right" bgcolor="#FFFFFF">14,894 μs</td><td align="right" bgcolor="#FFFFFF">15,643 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,035 ms</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,015 ms</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#A8D08D">5,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,000)</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +4,000)</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-24,4 %</td><td align="right" bgcolor="#A8D08D">-46,1 %</td><td align="right" bgcolor="#FF4949">+5,6 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">7851,000</td><td align="right" bgcolor="#A8D08D">5932,000 (Δ = -1919,000)</td><td align="right" bgcolor="#A8D08D">3197,000 (Δ = -2735,000)</td><td align="right" bgcolor="#FF4949">3377,000 (Δ = +180,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">7,667</td><td align="right" bgcolor="#A8D08D">5,793 (Δ = -1,874)</td><td align="right" bgcolor="#A8D08D">3,122 (Δ = -2,671)</td><td align="right" bgcolor="#FF4949">3,298 (Δ = +0,176)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,006 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,003)</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsInterfaceEx"></a>IsInterfaceEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 2,327 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">11,142 ns</td><td align="right" bgcolor="#FFFFFF">10,747 ns</td><td align="right" bgcolor="#FFFFFF">12,360 ns</td><td align="right" bgcolor="#FFFFFF">13,073 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,011 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsNestedPublicEx"></a>IsNestedPublicEx

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 2,953 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,690 ns</td><td align="right" bgcolor="#FFFFFF">14,592 ns</td><td align="right" bgcolor="#FFFFFF">13,897 ns</td><td align="right" bgcolor="#FFFFFF">12,737 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsPrimitiveEx"></a>IsPrimitiveEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 1,168 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,130 ns</td><td align="right" bgcolor="#FFFFFF">14,087 ns</td><td align="right" bgcolor="#FFFFFF">15,255 ns</td><td align="right" bgcolor="#FFFFFF">14,357 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsPublicEx"></a>IsPublicEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 2,142 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">14,587 ns</td><td align="right" bgcolor="#FFFFFF">14,462 ns</td><td align="right" bgcolor="#FFFFFF">12,445 ns</td><td align="right" bgcolor="#FFFFFF">13,210 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,015 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,012 μs</td><td align="right" bgcolor="#FFFFFF">0,013 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsSerializableEx"></a>IsSerializableEx

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 1,565 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">15,577 ns</td><td align="right" bgcolor="#FFFFFF">15,572 ns</td><td align="right" bgcolor="#FFFFFF">14,012 ns</td><td align="right" bgcolor="#FFFFFF">14,202 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,016 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td><td align="right" bgcolor="#FFFFFF">0,014 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="Type_ReflectionExtensions_Benchmark_IsValueTypeEx"></a>IsValueTypeEx

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 10,177 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">36,273 ns</td><td align="right" bgcolor="#FFFFFF">35,552 ns</td><td align="right" bgcolor="#FFFFFF">45,728 ns</td><td align="right" bgcolor="#FFFFFF">44,357 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,046 μs</td><td align="right" bgcolor="#FFFFFF">0,044 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="TypeExtensions_Benchmark"></a>TypeExtensions_Benchmark

### <a name="TypeExtensions_Benchmark_GetCollectionElementType"></a>GetCollectionElementType

#### Performance

Fastest: **5.3.0**

Slowest: 5.2.0

Δ: 604,898 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-62,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">927,137 ns</td><td align="right" bgcolor="#FFFFFF">905,093 ns</td><td align="right" bgcolor="#FFFFFF">975,587 ns</td><td align="right" bgcolor="#A8D08D">370,688 ns (Δ = -604,898 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,927 μs</td><td align="right" bgcolor="#FFFFFF">0,905 μs</td><td align="right" bgcolor="#FFFFFF">0,976 μs</td><td align="right" bgcolor="#FFFFFF">0,371 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-47,8 %</td><td align="right" bgcolor="#A8D08D">-83,0 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#FFFFFF">180,000</td><td align="right" bgcolor="#A8D08D">94,000 (Δ = -86,000)</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -78,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#FFFFFF">0,176</td><td align="right" bgcolor="#A8D08D">0,092 (Δ = -0,084)</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,076)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsBasicType"></a>IsBasicType

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 1,625 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17,942 ns</td><td align="right" bgcolor="#FFFFFF">17,880 ns</td><td align="right" bgcolor="#FFFFFF">18,213 ns</td><td align="right" bgcolor="#FFFFFF">19,505 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,018 μs</td><td align="right" bgcolor="#FFFFFF">0,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsClassType"></a>IsClassType

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 62,823 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">222,912 ns</td><td align="right" bgcolor="#FFFFFF">218,935 ns</td><td align="right" bgcolor="#FFFFFF">281,758 ns</td><td align="right" bgcolor="#FFFFFF">281,683 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td><td align="right" bgcolor="#FFFFFF">0,219 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsCollection"></a>IsCollection

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 7,155 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">34,480 ns</td><td align="right" bgcolor="#FFFFFF">34,070 ns</td><td align="right" bgcolor="#FFFFFF">40,540 ns</td><td align="right" bgcolor="#FFFFFF">41,225 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,034 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td><td align="right" bgcolor="#FFFFFF">0,041 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsDictionary"></a>IsDictionary

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 46,178 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">104,283 ns</td><td align="right" bgcolor="#FFFFFF">105,198 ns</td><td align="right" bgcolor="#FFFFFF">123,025 ns</td><td align="right" bgcolor="#FFFFFF">150,462 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,123 μs</td><td align="right" bgcolor="#FFFFFF">0,150 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsModelBase"></a>IsModelBase

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 8,748 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29,102 ns</td><td align="right" bgcolor="#FFFFFF">28,253 ns</td><td align="right" bgcolor="#FFFFFF">35,898 ns</td><td align="right" bgcolor="#FFFFFF">37,002 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,029 μs</td><td align="right" bgcolor="#FFFFFF">0,028 μs</td><td align="right" bgcolor="#FFFFFF">0,036 μs</td><td align="right" bgcolor="#FFFFFF">0,037 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="TypeExtensions_Benchmark_IsNullableType"></a>IsNullableType

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 99,482 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">292,802 ns</td><td align="right" bgcolor="#FFFFFF">290,162 ns</td><td align="right" bgcolor="#FFFFFF">387,298 ns</td><td align="right" bgcolor="#FFFFFF">389,643 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,293 μs</td><td align="right" bgcolor="#FFFFFF">0,290 μs</td><td align="right" bgcolor="#FFFFFF">0,387 μs</td><td align="right" bgcolor="#FFFFFF">0,390 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="TypeFactory_Benchmark"></a>TypeFactory_Benchmark

### <a name="TypeFactory_Benchmark_CreateInstance"></a>CreateInstance

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 328,940 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-13,6 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2315,050 ns</td><td align="right" bgcolor="#FFFFFF">2417,428 ns</td><td align="right" bgcolor="#A8D08D">2088,488 ns (Δ = -328,940 ns)</td><td align="right" bgcolor="#FFFFFF">2211,392 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,315 μs</td><td align="right" bgcolor="#FFFFFF">2,417 μs</td><td align="right" bgcolor="#FFFFFF">2,088 μs</td><td align="right" bgcolor="#FFFFFF">2,211 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,4 %</td><td align="right" bgcolor="#A8D08D">-36,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">889,000</td><td align="right" bgcolor="#FF4949">1044,000 (Δ = +155,000)</td><td align="right" bgcolor="#A8D08D">663,000 (Δ = -381,000)</td><td align="right" bgcolor="#FFFFFF">663,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,868</td><td align="right" bgcolor="#FF4949">1,020 (Δ = +0,151)</td><td align="right" bgcolor="#A8D08D">0,647 (Δ = -0,372)</td><td align="right" bgcolor="#FFFFFF">0,647</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstance_PropertyInjection"></a>CreateInstance_PropertyInjection

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 275,680 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-11,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2297,252 ns</td><td align="right" bgcolor="#FFFFFF">2398,555 ns</td><td align="right" bgcolor="#A8D08D">2122,875 ns (Δ = -275,680 ns)</td><td align="right" bgcolor="#FFFFFF">2333,992 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,297 μs</td><td align="right" bgcolor="#FFFFFF">2,399 μs</td><td align="right" bgcolor="#FFFFFF">2,123 μs</td><td align="right" bgcolor="#FFFFFF">2,334 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+17,6 %</td><td align="right" bgcolor="#A8D08D">-36,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">881,000</td><td align="right" bgcolor="#FF4949">1036,000 (Δ = +155,000)</td><td align="right" bgcolor="#A8D08D">658,000 (Δ = -378,000)</td><td align="right" bgcolor="#FFFFFF">658,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,860</td><td align="right" bgcolor="#FF4949">1,012 (Δ = +0,151)</td><td align="right" bgcolor="#A8D08D">0,643 (Δ = -0,369)</td><td align="right" bgcolor="#FFFFFF">0,643</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParameters"></a>CreateInstanceWithParameters

#### Performance

Fastest: **5.2.0**

Slowest: 5.0.0

Δ: 164,680 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2788,690 ns</td><td align="right" bgcolor="#FFFFFF">2876,677 ns</td><td align="right" bgcolor="#FFFFFF">2711,997 ns</td><td align="right" bgcolor="#FFFFFF">2721,682 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,789 μs</td><td align="right" bgcolor="#FFFFFF">2,877 μs</td><td align="right" bgcolor="#FFFFFF">2,712 μs</td><td align="right" bgcolor="#FFFFFF">2,722 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+11,7 %</td><td align="right" bgcolor="#A8D08D">-30,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1298,000</td><td align="right" bgcolor="#FF4949">1450,000 (Δ = +152,000)</td><td align="right" bgcolor="#A8D08D">1015,000 (Δ = -435,000)</td><td align="right" bgcolor="#FFFFFF">1015,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,268</td><td align="right" bgcolor="#FF4949">1,416 (Δ = +0,148)</td><td align="right" bgcolor="#A8D08D">0,991 (Δ = -0,425)</td><td align="right" bgcolor="#FFFFFF">0,991</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="TypeFactory_Benchmark_CreateInstanceWithParametersAndAutoCompletion"></a>CreateInstanceWithParametersAndAutoCompletion

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 327,612 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,8 %</td><td align="right" bgcolor="#A8D08D">-9,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">3040,072 ns</td><td align="right" bgcolor="#FF4949">3367,683 ns (Δ = +327,612 ns)</td><td align="right" bgcolor="#A8D08D">3055,752 ns (Δ = -311,932 ns)</td><td align="right" bgcolor="#FFFFFF">3245,780 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">3,040 μs</td><td align="right" bgcolor="#FFFFFF">3,368 μs</td><td align="right" bgcolor="#FFFFFF">3,056 μs</td><td align="right" bgcolor="#FFFFFF">3,246 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+10,0 %</td><td align="right" bgcolor="#A8D08D">-32,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1507,000</td><td align="right" bgcolor="#FF4949">1658,000 (Δ = +151,000)</td><td align="right" bgcolor="#A8D08D">1125,000 (Δ = -533,000)</td><td align="right" bgcolor="#FFFFFF">1125,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,472</td><td align="right" bgcolor="#FF4949">1,619 (Δ = +0,147)</td><td align="right" bgcolor="#A8D08D">1,099 (Δ = -0,521)</td><td align="right" bgcolor="#FFFFFF">1,099</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,002 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="UniqueIdentifierHelper_Benchmark"></a>UniqueIdentifierHelper_Benchmark

### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier"></a>GetUniqueIdentifier

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 22,402 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">104,602 ns</td><td align="right" bgcolor="#FFFFFF">106,400 ns</td><td align="right" bgcolor="#FFFFFF">121,533 ns</td><td align="right" bgcolor="#FFFFFF">127,003 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,106 μs</td><td align="right" bgcolor="#FFFFFF">0,122 μs</td><td align="right" bgcolor="#FFFFFF">0,127 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="UniqueIdentifierHelper_Benchmark_GetUniqueIdentifier_Generic"></a>GetUniqueIdentifier_Generic

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 15,242 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">104,920 ns</td><td align="right" bgcolor="#FFFFFF">104,177 ns</td><td align="right" bgcolor="#FFFFFF">119,200 ns</td><td align="right" bgcolor="#FFFFFF">119,418 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,105 μs</td><td align="right" bgcolor="#FFFFFF">0,104 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td><td align="right" bgcolor="#FFFFFF">0,119 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ValidatableModelBase_Constructor_Benchmark"></a>ValidatableModelBase_Constructor_Benchmark

### <a name="ValidatableModelBase_Constructor_Benchmark_Constructor"></a>Constructor

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 416,890 ns


<table><tr><th> </th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+14,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">2827,137 ns</td><td align="right" bgcolor="#FF4949">3244,027 ns (Δ = +416,890 ns)</td><td align="right" bgcolor="#FFFFFF">3205,310 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">2,827 μs</td><td align="right" bgcolor="#FFFFFF">3,244 μs</td><td align="right" bgcolor="#FFFFFF">3,205 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td><td align="right" bgcolor="#FFFFFF">0,003 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">971,000</td><td align="right" bgcolor="#A8D08D">553,000 (Δ = -418,000)</td><td align="right" bgcolor="#FFFFFF">553,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,948</td><td align="right" bgcolor="#A8D08D">0,540 (Δ = -0,408)</td><td align="right" bgcolor="#FFFFFF">0,540</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


## <a name="ValidationContext_Benchmark"></a>ValidationContext_Benchmark

### <a name="ValidationContext_Benchmark_GetBusinessRuleErrorCount"></a>GetBusinessRuleErrorCount

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 8,667 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">196,748 ns</td><td align="right" bgcolor="#FFFFFF">195,398 ns</td><td align="right" bgcolor="#FFFFFF">203,577 ns</td><td align="right" bgcolor="#FFFFFF">204,065 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,197 μs</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,204 μs</td><td align="right" bgcolor="#FFFFFF">0,204 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleErrors"></a>GetBusinessRuleErrors

#### Performance

Fastest: **5.0.0**

Slowest: 4.5.4

Δ: 31,548 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">224,307 ns</td><td align="right" bgcolor="#FFFFFF">192,758 ns</td><td align="right" bgcolor="#FFFFFF">201,475 ns</td><td align="right" bgcolor="#FFFFFF">206,567 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,224 μs</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FFFFFF">0,201 μs</td><td align="right" bgcolor="#FFFFFF">0,207 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleValidations"></a>GetBusinessRuleValidations

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 65,408 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">221,263 ns</td><td align="right" bgcolor="#FFFFFF">216,963 ns</td><td align="right" bgcolor="#FFFFFF">251,293 ns</td><td align="right" bgcolor="#FFFFFF">282,372 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,221 μs</td><td align="right" bgcolor="#FFFFFF">0,217 μs</td><td align="right" bgcolor="#FFFFFF">0,251 μs</td><td align="right" bgcolor="#FFFFFF">0,282 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarningCount"></a>GetBusinessRuleWarningCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 38,100 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">193,370 ns</td><td align="right" bgcolor="#FFFFFF">193,783 ns</td><td align="right" bgcolor="#FFFFFF">225,308 ns</td><td align="right" bgcolor="#FFFFFF">231,470 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,193 μs</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,225 μs</td><td align="right" bgcolor="#FFFFFF">0,231 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetBusinessRuleWarnings"></a>GetBusinessRuleWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.2.0

Δ: 71,892 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">194,880 ns</td><td align="right" bgcolor="#FFFFFF">194,435 ns</td><td align="right" bgcolor="#FFFFFF">266,327 ns</td><td align="right" bgcolor="#FFFFFF">254,792 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,195 μs</td><td align="right" bgcolor="#FFFFFF">0,194 μs</td><td align="right" bgcolor="#FFFFFF">0,266 μs</td><td align="right" bgcolor="#FFFFFF">0,255 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrorCount"></a>GetErrorCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 143,948 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">959,657 ns</td><td align="right" bgcolor="#FFFFFF">993,042 ns</td><td align="right" bgcolor="#FFFFFF">1103,605 ns</td><td align="right" bgcolor="#FFFFFF">1101,852 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,960 μs</td><td align="right" bgcolor="#FFFFFF">0,993 μs</td><td align="right" bgcolor="#FFFFFF">1,104 μs</td><td align="right" bgcolor="#FFFFFF">1,102 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetErrors"></a>GetErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 223,973 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">979,002 ns</td><td align="right" bgcolor="#FFFFFF">995,610 ns</td><td align="right" bgcolor="#FFFFFF">1105,402 ns</td><td align="right" bgcolor="#FFFFFF">1202,975 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,979 μs</td><td align="right" bgcolor="#FFFFFF">0,996 μs</td><td align="right" bgcolor="#FFFFFF">1,105 μs</td><td align="right" bgcolor="#FFFFFF">1,203 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrorCount"></a>GetFieldErrorCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 35,175 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">232,453 ns</td><td align="right" bgcolor="#FFFFFF">234,255 ns</td><td align="right" bgcolor="#FFFFFF">243,300 ns</td><td align="right" bgcolor="#FFFFFF">267,628 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,232 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,243 μs</td><td align="right" bgcolor="#FFFFFF">0,268 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldErrors"></a>GetFieldErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 36,755 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">233,958 ns</td><td align="right" bgcolor="#FFFFFF">233,505 ns</td><td align="right" bgcolor="#FFFFFF">268,383 ns</td><td align="right" bgcolor="#FFFFFF">270,260 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,268 μs</td><td align="right" bgcolor="#FFFFFF">0,270 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldValidations"></a>GetFieldValidations

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 29,982 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">258,530 ns</td><td align="right" bgcolor="#FFFFFF">265,002 ns</td><td align="right" bgcolor="#FFFFFF">263,792 ns</td><td align="right" bgcolor="#FFFFFF">288,512 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,259 μs</td><td align="right" bgcolor="#FFFFFF">0,265 μs</td><td align="right" bgcolor="#FFFFFF">0,264 μs</td><td align="right" bgcolor="#FFFFFF">0,289 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#FFFFFF">176,000</td><td align="right" bgcolor="#A8D08D">102,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">102,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#FFFFFF">0,172</td><td align="right" bgcolor="#A8D08D">0,100 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,100</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarningCount"></a>GetFieldWarningCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 53,468 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">205,118 ns</td><td align="right" bgcolor="#FFFFFF">212,165 ns</td><td align="right" bgcolor="#FFFFFF">258,587 ns</td><td align="right" bgcolor="#FFFFFF">247,102 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,205 μs</td><td align="right" bgcolor="#FFFFFF">0,212 μs</td><td align="right" bgcolor="#FFFFFF">0,259 μs</td><td align="right" bgcolor="#FFFFFF">0,247 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetFieldWarnings"></a>GetFieldWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 36,623 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">205,645 ns</td><td align="right" bgcolor="#FFFFFF">206,912 ns</td><td align="right" bgcolor="#FFFFFF">242,268 ns</td><td align="right" bgcolor="#FFFFFF">223,308 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,206 μs</td><td align="right" bgcolor="#FFFFFF">0,207 μs</td><td align="right" bgcolor="#FFFFFF">0,242 μs</td><td align="right" bgcolor="#FFFFFF">0,223 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetValidations"></a>GetValidations

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 248,273 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">497,993 ns</td><td align="right" bgcolor="#FFFFFF">490,550 ns</td><td align="right" bgcolor="#FFFFFF">625,713 ns</td><td align="right" bgcolor="#FFFFFF">738,823 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,498 μs</td><td align="right" bgcolor="#FFFFFF">0,491 μs</td><td align="right" bgcolor="#FFFFFF">0,626 μs</td><td align="right" bgcolor="#FFFFFF">0,739 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#FFFFFF">344,000</td><td align="right" bgcolor="#A8D08D">193,000 (Δ = -151,000)</td><td align="right" bgcolor="#FFFFFF">193,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#FFFFFF">0,336</td><td align="right" bgcolor="#A8D08D">0,188 (Δ = -0,147)</td><td align="right" bgcolor="#FFFFFF">0,188</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarningCount"></a>GetWarningCount

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 134,597 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">902,238 ns</td><td align="right" bgcolor="#FFFFFF">932,247 ns</td><td align="right" bgcolor="#FFFFFF">1036,835 ns</td><td align="right" bgcolor="#FFFFFF">1019,912 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,902 μs</td><td align="right" bgcolor="#FFFFFF">0,932 μs</td><td align="right" bgcolor="#FFFFFF">1,037 μs</td><td align="right" bgcolor="#FFFFFF">1,020 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_GetWarnings"></a>GetWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 210,845 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">919,328 ns</td><td align="right" bgcolor="#FFFFFF">935,288 ns</td><td align="right" bgcolor="#FFFFFF">1039,250 ns</td><td align="right" bgcolor="#FFFFFF">1130,173 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,919 μs</td><td align="right" bgcolor="#FFFFFF">0,935 μs</td><td align="right" bgcolor="#FFFFFF">1,039 μs</td><td align="right" bgcolor="#FFFFFF">1,130 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#FFFFFF">516,000</td><td align="right" bgcolor="#A8D08D">295,000 (Δ = -221,000)</td><td align="right" bgcolor="#FFFFFF">295,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#FFFFFF">0,504</td><td align="right" bgcolor="#A8D08D">0,288 (Δ = -0,216)</td><td align="right" bgcolor="#FFFFFF">0,288</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 36,522 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">234,027 ns</td><td align="right" bgcolor="#FFFFFF">233,488 ns</td><td align="right" bgcolor="#FFFFFF">269,078 ns</td><td align="right" bgcolor="#FFFFFF">270,010 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,234 μs</td><td align="right" bgcolor="#FFFFFF">0,233 μs</td><td align="right" bgcolor="#FFFFFF">0,269 μs</td><td align="right" bgcolor="#FFFFFF">0,270 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 58,472 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">208,330 ns</td><td align="right" bgcolor="#FFFFFF">211,040 ns</td><td align="right" bgcolor="#FFFFFF">266,802 ns</td><td align="right" bgcolor="#FFFFFF">244,435 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,208 μs</td><td align="right" bgcolor="#FFFFFF">0,211 μs</td><td align="right" bgcolor="#FFFFFF">0,267 μs</td><td align="right" bgcolor="#FFFFFF">0,244 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-43,0 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#FFFFFF">172,000</td><td align="right" bgcolor="#A8D08D">98,000 (Δ = -74,000)</td><td align="right" bgcolor="#FFFFFF">98,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#FFFFFF">0,168</td><td align="right" bgcolor="#A8D08D">0,096 (Δ = -0,072)</td><td align="right" bgcolor="#FFFFFF">0,096</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationContext_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 200,113 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">324,438 ns</td><td align="right" bgcolor="#FFFFFF">319,683 ns</td><td align="right" bgcolor="#FFFFFF">500,940 ns</td><td align="right" bgcolor="#FFFFFF">519,797 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,324 μs</td><td align="right" bgcolor="#FFFFFF">0,320 μs</td><td align="right" bgcolor="#FFFFFF">0,501 μs</td><td align="right" bgcolor="#FFFFFF">0,520 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-45,8 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#FFFFFF">332,000</td><td align="right" bgcolor="#A8D08D">180,000 (Δ = -152,000)</td><td align="right" bgcolor="#FFFFFF">180,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#FFFFFF">0,324</td><td align="right" bgcolor="#A8D08D">0,176 (Δ = -0,148)</td><td align="right" bgcolor="#FFFFFF">0,176</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ValidationSummary_Benchmark"></a>ValidationSummary_Benchmark

### <a name="ValidationSummary_Benchmark_BusinessRuleErrors"></a>BusinessRuleErrors

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 0,598 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,150 ns</td><td align="right" bgcolor="#FFFFFF">7,008 ns</td><td align="right" bgcolor="#FFFFFF">6,877 ns</td><td align="right" bgcolor="#FFFFFF">7,475 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_BusinessRuleWarnings"></a>BusinessRuleWarnings

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 1,238 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">6,973 ns</td><td align="right" bgcolor="#FFFFFF">7,200 ns</td><td align="right" bgcolor="#FFFFFF">7,075 ns</td><td align="right" bgcolor="#FFFFFF">8,212 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldErrors"></a>FieldErrors

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 0,795 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,060 ns</td><td align="right" bgcolor="#FFFFFF">7,427 ns</td><td align="right" bgcolor="#FFFFFF">6,955 ns</td><td align="right" bgcolor="#FFFFFF">7,750 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_FieldWarnings"></a>FieldWarnings

#### Performance

Fastest: **5.2.0**

Slowest: 5.3.0

Δ: 0,685 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">7,013 ns</td><td align="right" bgcolor="#FFFFFF">7,375 ns</td><td align="right" bgcolor="#FFFFFF">6,853 ns</td><td align="right" bgcolor="#FFFFFF">7,538 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,007 μs</td><td align="right" bgcolor="#FFFFFF">0,008 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-51,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#FFFFFF">33,000</td><td align="right" bgcolor="#A8D08D">16,000 (Δ = -17,000)</td><td align="right" bgcolor="#FFFFFF">16,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#FFFFFF">0,032</td><td align="right" bgcolor="#A8D08D">0,016 (Δ = -0,017)</td><td align="right" bgcolor="#FFFFFF">0,016</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasBusinessRuleErrors"></a>HasBusinessRuleErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 0,048 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,010 ns</td><td align="right" bgcolor="#FFFFFF">0,028 ns</td><td align="right" bgcolor="#FFFFFF">0,055 ns</td><td align="right" bgcolor="#FFFFFF">0,058 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasBusinessRuleWarnings"></a>HasBusinessRuleWarnings

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 0,040 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,048 ns</td><td align="right" bgcolor="#FFFFFF">0,015 ns</td><td align="right" bgcolor="#FFFFFF">0,040 ns</td><td align="right" bgcolor="#FFFFFF">0,055 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasErrors"></a>HasErrors

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 0,587 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,635 ns</td><td align="right" bgcolor="#FFFFFF">0,655 ns</td><td align="right" bgcolor="#FFFFFF">0,738 ns</td><td align="right" bgcolor="#FFFFFF">1,222 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasFieldErrors"></a>HasFieldErrors

#### Performance

Fastest: **5.0.0**

Slowest: 5.3.0

Δ: 0,588 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,062 ns</td><td align="right" bgcolor="#FFFFFF">0,029 ns</td><td align="right" bgcolor="#FFFFFF">0,043 ns</td><td align="right" bgcolor="#FFFFFF">0,617 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasFieldWarnings"></a>HasFieldWarnings

#### Performance

Fastest: **5.3.0**

Slowest: 5.0.0

Δ: 0,018 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,034 ns</td><td align="right" bgcolor="#FFFFFF">0,048 ns</td><td align="right" bgcolor="#FFFFFF">0,048 ns</td><td align="right" bgcolor="#FFFFFF">0,030 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td><td align="right" bgcolor="#FFFFFF">0,000 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_HasWarnings"></a>HasWarnings

#### Performance

Fastest: **5.3.0**

Slowest: 4.5.4

Δ: 0,213 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">0,868 ns</td><td align="right" bgcolor="#FFFFFF">0,700 ns</td><td align="right" bgcolor="#FFFFFF">0,657 ns</td><td align="right" bgcolor="#FFFFFF">0,655 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td><td align="right" bgcolor="#FFFFFF">0,001 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="ValidationSummary_Benchmark_Initialization"></a>Initialization

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 246,812 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">926,518 ns</td><td align="right" bgcolor="#FFFFFF">930,522 ns</td><td align="right" bgcolor="#FFFFFF">1173,330 ns</td><td align="right" bgcolor="#FFFFFF">1030,358 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,927 μs</td><td align="right" bgcolor="#FFFFFF">0,931 μs</td><td align="right" bgcolor="#FFFFFF">1,173 μs</td><td align="right" bgcolor="#FFFFFF">1,030 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-42,2 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">737,000</td><td align="right" bgcolor="#FFFFFF">737,000</td><td align="right" bgcolor="#A8D08D">426,000 (Δ = -311,000)</td><td align="right" bgcolor="#FFFFFF">426,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,720</td><td align="right" bgcolor="#FFFFFF">0,720</td><td align="right" bgcolor="#A8D08D">0,416 (Δ = -0,304)</td><td align="right" bgcolor="#FFFFFF">0,416</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


## <a name="ViewModelBase_Benchmark"></a>ViewModelBase_Benchmark

### <a name="ViewModelBase_Benchmark_Construction"></a>Construction

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 15278,537 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-44,0 %</td><td align="right" bgcolor="#A8D08D">-13,4 %</td><td align="right" bgcolor="#FF4949">+13,2 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">29649,897 ns</td><td align="right" bgcolor="#A8D08D">16594,282 ns (Δ = -13055,615 ns)</td><td align="right" bgcolor="#A8D08D">14371,360 ns (Δ = -2222,922 ns)</td><td align="right" bgcolor="#FF4949">16270,800 ns (Δ = +1899,440 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">29,650 μs</td><td align="right" bgcolor="#FFFFFF">16,594 μs</td><td align="right" bgcolor="#FFFFFF">14,371 μs</td><td align="right" bgcolor="#FFFFFF">16,271 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,030 ms</td><td align="right" bgcolor="#FFFFFF">0,017 ms</td><td align="right" bgcolor="#FFFFFF">0,014 ms</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">5.3.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 1</td><td align="right">5.0.0</td><td align="right">4.5.4</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.2.0</td><td align="right">4.5.4</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">10,000</td><td align="right" bgcolor="#A8D08D">5,000 (Δ = -5,000)</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#FFFFFF">5,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">5,000</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = -5,000)</td><td align="right" bgcolor="#FF4949">4,000 (Δ = +4,000)</td><td align="right" bgcolor="#FFFFFF">4,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#A8D08D">-22,6 %</td><td align="right" bgcolor="#A8D08D">-46,0 %</td><td align="right" bgcolor="#FF4949">+5,7 %</td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">7563,000</td><td align="right" bgcolor="#A8D08D">5852,000 (Δ = -1711,000)</td><td align="right" bgcolor="#A8D08D">3158,000 (Δ = -2694,000)</td><td align="right" bgcolor="#FF4949">3339,000 (Δ = +181,000)</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">7,386</td><td align="right" bgcolor="#A8D08D">5,715 (Δ = -1,671)</td><td align="right" bgcolor="#A8D08D">3,084 (Δ = -2,631)</td><td align="right" bgcolor="#FF4949">3,261 (Δ = +0,177)</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,007</td><td align="right" bgcolor="#A8D08D">0,006 (Δ = -0,002)</td><td align="right" bgcolor="#A8D08D">0,003 (Δ = -0,003)</td><td align="right" bgcolor="#FF4949">0,003 (Δ = +0,000)</td></tr></table>


## <a name="WeakEventListener_Benchmark"></a>WeakEventListener_Benchmark

### <a name="WeakEventListener_Benchmark_CollectionChanged_Notification"></a>CollectionChanged_Notification

#### Performance

Fastest: **4.5.4**

Slowest: 5.3.0

Δ: 1405,978 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+937,3 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+21,0 %</td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">121,472 ns</td><td align="right" bgcolor="#FF4949">1260,003 ns (Δ = +1138,532 ns)</td><td align="right" bgcolor="#FFFFFF">1262,250 ns</td><td align="right" bgcolor="#FF4949">1527,450 ns (Δ = +265,200 ns)</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,121 μs</td><td align="right" bgcolor="#FFFFFF">1,260 μs</td><td align="right" bgcolor="#FFFFFF">1,262 μs</td><td align="right" bgcolor="#FFFFFF">1,527 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,002 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">4.5.4</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+136,0 %</td><td align="right" bgcolor="#A8D08D">-47,9 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">175,000</td><td align="right" bgcolor="#FF4949">413,000 (Δ = +238,000)</td><td align="right" bgcolor="#A8D08D">215,000 (Δ = -198,000)</td><td align="right" bgcolor="#FFFFFF">215,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,171</td><td align="right" bgcolor="#FF4949">0,403 (Δ = +0,232)</td><td align="right" bgcolor="#A8D08D">0,210 (Δ = -0,193)</td><td align="right" bgcolor="#FFFFFF">0,210</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="WeakEventListener_Benchmark_GenericEvent_Notification"></a>GenericEvent_Notification

#### Performance

Fastest: **4.5.4**

Slowest: 5.2.0

Δ: 1123,190 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+3523,2 %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">26,665 ns</td><td align="right" bgcolor="#FF4949">966,113 ns (Δ = +939,448 ns)</td><td align="right" bgcolor="#FFFFFF">1149,855 ns</td><td align="right" bgcolor="#FFFFFF">1136,937 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,027 μs</td><td align="right" bgcolor="#FFFFFF">0,966 μs</td><td align="right" bgcolor="#FFFFFF">1,150 μs</td><td align="right" bgcolor="#FFFFFF">1,137 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td><td align="right" bgcolor="#FFFFFF">0,001 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">4.5.4</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+∞ %</td><td align="right" bgcolor="#A8D08D">-47,5 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">242,000 (Δ = +242,000)</td><td align="right" bgcolor="#A8D08D">127,000 (Δ = -115,000)</td><td align="right" bgcolor="#FFFFFF">127,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,236 (Δ = +0,236)</td><td align="right" bgcolor="#A8D08D">0,124 (Δ = -0,112)</td><td align="right" bgcolor="#FFFFFF">0,124</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FF4949">0,000 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,000 (Δ = 0,000)</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="WeakEventListener_Benchmark_PropertyChanged_Notification"></a>PropertyChanged_Notification

#### Performance

Fastest: **5.2.0**

Slowest: 4.5.4

Δ: 2,930 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">4,822 ns</td><td align="right" bgcolor="#FFFFFF">4,702 ns</td><td align="right" bgcolor="#FFFFFF">1,892 ns</td><td align="right" bgcolor="#FFFFFF">2,022 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,005 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td><td align="right" bgcolor="#FFFFFF">0,002 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td><td align="right" bgcolor="#FFFFFF">0,000 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">-</td><td align="right">-</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr></table>


### <a name="WeakEventListener_Benchmark_SubscribeToWeakGenericEvent"></a>SubscribeToWeakGenericEvent

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 3123,090 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+19,3 %</td><td align="right" bgcolor="#A8D08D">-8,1 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">16146,582 ns</td><td align="right" bgcolor="#FF4949">19269,672 ns (Δ = +3123,090 ns)</td><td align="right" bgcolor="#A8D08D">17712,467 ns (Δ = -1557,205 ns)</td><td align="right" bgcolor="#FFFFFF">17945,100 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">16,147 μs</td><td align="right" bgcolor="#FFFFFF">19,270 μs</td><td align="right" bgcolor="#FFFFFF">17,712 μs</td><td align="right" bgcolor="#FFFFFF">17,945 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,016 ms</td><td align="right" bgcolor="#FFFFFF">0,019 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,8 %</td><td align="right" bgcolor="#A8D08D">-49,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1224,000</td><td align="right" bgcolor="#FF4949">1478,000 (Δ = +254,000)</td><td align="right" bgcolor="#A8D08D">743,000 (Δ = -735,000)</td><td align="right" bgcolor="#FFFFFF">743,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,195</td><td align="right" bgcolor="#FF4949">1,443 (Δ = +0,248)</td><td align="right" bgcolor="#A8D08D">0,726 (Δ = -0,718)</td><td align="right" bgcolor="#FFFFFF">0,726</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


### <a name="WeakEventListener_Benchmark_SubscribeToWeakPropertyChangedEvent"></a>SubscribeToWeakPropertyChangedEvent

#### Performance

Fastest: **4.5.4**

Slowest: 5.0.0

Δ: 2830,257 ns


<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+15,9 %</td><td align="right" bgcolor="#A8D08D">-10,3 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Average ns / operation</td><td align="right" bgcolor="#FFFFFF">17750,463 ns</td><td align="right" bgcolor="#FF4949">20580,720 ns (Δ = +2830,257 ns)</td><td align="right" bgcolor="#A8D08D">18461,283 ns (Δ = -2119,437 ns)</td><td align="right" bgcolor="#FFFFFF">18322,593 ns</td></tr><tr><td>Average μs / operation</td><td align="right" bgcolor="#FFFFFF">17,750 μs</td><td align="right" bgcolor="#FFFFFF">20,581 μs</td><td align="right" bgcolor="#FFFFFF">18,461 μs</td><td align="right" bgcolor="#FFFFFF">18,323 μs</td></tr><tr><td>Average ms / operation</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,021 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td><td align="right" bgcolor="#FFFFFF">0,018 ms</td></tr></table>

#### Memory (per 1k operations)

<table><tr><th>Name</th><th>Least</th><th>Most</th></tr><tr><td>Gen 0</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 1</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Gen 2</td><td align="right">-</td><td align="right">-</td></tr><tr><td>Allocated Bytes</td><td align="right">5.3.0</td><td align="right">5.0.0</td></tr></table>
<table><tr><th> </th><th>4.5.4</th><th>5.0.0</th><th>5.2.0</th><th>5.3.0</th></tr><tr><td>Gen 0</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 1</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Gen 2</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td><td align="right" bgcolor="#FFFFFF">0,000</td></tr><tr><td>Δ %</td><td align="right" bgcolor="#FFFFFF"></td><td align="right" bgcolor="#FF4949">+20,8 %</td><td align="right" bgcolor="#A8D08D">-49,7 %</td><td align="right" bgcolor="#FFFFFF"></td></tr><tr><td>Allocated Bytes</td><td align="right" bgcolor="#FFFFFF">1224,000</td><td align="right" bgcolor="#FF4949">1478,000 (Δ = +254,000)</td><td align="right" bgcolor="#A8D08D">743,000 (Δ = -735,000)</td><td align="right" bgcolor="#FFFFFF">743,000</td></tr><tr><td>Allocated Kilobytes</td><td align="right" bgcolor="#FFFFFF">1,195</td><td align="right" bgcolor="#FF4949">1,443 (Δ = +0,248)</td><td align="right" bgcolor="#A8D08D">0,726 (Δ = -0,718)</td><td align="right" bgcolor="#FFFFFF">0,726</td></tr><tr><td>Allocated Megabytes</td><td align="right" bgcolor="#FFFFFF">0,001</td><td align="right" bgcolor="#FF4949">0,001 (Δ = +0,000)</td><td align="right" bgcolor="#A8D08D">0,001 (Δ = -0,001)</td><td align="right" bgcolor="#FFFFFF">0,001</td></tr></table>


